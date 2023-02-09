// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0
//
// Code generated with OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.


using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ErrorEventArgs = Newtonsoft.Json.Serialization.ErrorEventArgs;
using System.Net.Http;
using System.Net.Http.Headers;
using Polly;

namespace Vault.Client
{
    /// <summary>
    /// To Serialize/Deserialize JSON using our custom logic, but only when ContentType is JSON.
    /// </summary>
    internal class CustomJsonCodec
    {
        private readonly VaultConfiguration _configuration;
        private static readonly string _contentType = "application/json";
        private readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
        {
            // OpenAPI generated types generally hide default constructors.
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy
                {
                    OverrideSpecifiedNames = false
                }
            }
        };

        public CustomJsonCodec(VaultConfiguration configuration)
        {
            _configuration = configuration;
        }

        public CustomJsonCodec(JsonSerializerSettings serializerSettings, VaultConfiguration configuration)
        {
            _serializerSettings = serializerSettings;
            _configuration = configuration;
        }

        /// <summary>
        /// Serialize the object into a JSON string.
        /// </summary>
        /// <param name="obj">Object to be serialized.</param>
        /// <returns>A JSON string.</returns>
        public string Serialize(object obj)
        {
            if (obj != null && obj is Vault.Model.AbstractOpenAPISchema)
            {
                // the object to be serialized is an oneOf/anyOf schema
                return ((Vault.Model.AbstractOpenAPISchema)obj).ToJson();
            }
            else
            {
                return JsonConvert.SerializeObject(obj, _serializerSettings);
            }
        }

        public async Task<T> Deserialize<T>(HttpResponseMessage response)
        {
            var result = (T)await Deserialize(response, typeof(T));
            return result;
        }

        /// <summary>
        /// Deserialize the JSON string into a proper object.
        /// </summary>
        /// <param name="response">The HTTP response.</param>
        /// <param name="type">Object type.</param>
        /// <returns>Object representation of the JSON string.</returns>
        internal async Task<object> Deserialize(HttpResponseMessage response, Type type)
        {
            IList<string> headers = response.Headers.Select(x => x.Key + "=" + x.Value).ToList();

            if (type == typeof(byte[])) // return byte array
            {
                return await response.Content.ReadAsByteArrayAsync();
            }

            // TODO: ? if (type.IsAssignableFrom(typeof(Stream)))
            if (type == typeof(Stream))
            {
                var bytes = await response.Content.ReadAsByteArrayAsync();
                if (headers != null)
                {
                    var filePath = string.IsNullOrEmpty(_configuration.TempFolderPath)
                        ? Path.GetTempPath()
                        : _configuration.TempFolderPath;
                    var regex = new Regex(@"Content-Disposition=.*filename=['""]?([^'""\s]+)['""]?$");
                    foreach (var header in headers)
                    {
                        var match = regex.Match(header.ToString());
                        if (match.Success)
                        {
                            string fileName = filePath + ClientUtils.SanitizeFilename(match.Groups[1].Value.Replace("\"", "").Replace("'", ""));
                            File.WriteAllBytes(fileName, bytes);
                            return new FileStream(fileName, FileMode.Open);
                        }
                    }
                }
                var stream = new MemoryStream(bytes);
                return stream;
            }

            if (type.Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
            {
                return DateTime.Parse(await response.Content.ReadAsStringAsync(), null, System.Globalization.DateTimeStyles.RoundtripKind);
            }

            if (type == typeof(string) || type.Name.StartsWith("System.Nullable")) // return primitive type
            {
                return Convert.ChangeType(await response.Content.ReadAsStringAsync(), type);
            }

            // at this point, it must be a model (json)
            try
            {
                return JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync(), type, _serializerSettings);
            }
            catch (Exception e)
            {
                throw new VaultApiException(500, e.Message);
            }
        }

        public string RootElement { get; set; }
        public string Namespace { get; set; }
        public string DateFormat { get; set; }

        public string ContentType
        {
            get { return _contentType; }
            set { throw new InvalidOperationException("Not allowed to set content type."); }
        }
    }

    internal class RequestHeaders
    {
        public string Token { get; set; } = string.Empty;

        public string Namespace { get; set; } = string.Empty;

        public List<string> MFACredentials = new List<string>();

        public int ResponseWrapTTL = 0;

        public Dictionary<string, string> CustomHeaders = new Dictionary<string, string> { };
    }

    /// <summary>
    /// Provides a default implementation of an Api client (both synchronous and asynchronous implementations),
    /// encapsulating general REST accessor use cases.
    /// </summary>
    /// <remarks>
    /// The Dispose method will manage the HttpClient lifecycle when not passed by constructor.
    /// </remarks>
    public partial class ApiClient : ISynchronousClient, IAsynchronousClient
    {
        /// <summary>
        /// Vault configuration object for all requests
        /// </summary>
        public readonly VaultConfiguration Configuration;

        private readonly object _requestHeaderLock = new object();

        private RequestHeaders _requestHeaders = new RequestHeaders();

        /// <summary>
        /// Specifies the settings on a <see cref="JsonSerializer" /> object.
        /// These settings can be adjusted to accommodate custom serialization rules.
        /// </summary>
        public JsonSerializerSettings SerializerSettings { get; set; } = new JsonSerializerSettings
        {
            // OpenAPI generated types generally hide default constructors.
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy
                {
                    OverrideSpecifiedNames = false
                }
            }
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" />.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public ApiClient(VaultConfiguration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("client cannot be null");

            Configuration = configuration;
        }

        internal void SetWrapTTL(TimeSpan ttl)
        {
            lock (_requestHeaderLock)
            {
                _requestHeaders.ResponseWrapTTL = (int)ttl.TotalSeconds;
            }
        }

        /// <summary>
        /// Set Token Header Value
        /// </summary>
        internal void SetToken(string token)
        {
            lock (_requestHeaderLock)
            {
                _requestHeaders.Token = token;
            }
        }

        /// <summary>
        /// Set Namespace Header Value
        /// </summary>
        internal void SetNamespace(string Namespace)
        {
            lock (_requestHeaderLock)
            {
                _requestHeaders.Namespace = Namespace;
            }
        }

        /// <summary>
        /// Adds a dictionary of custom headers to current list of custom headers.
        /// </summary>
        internal void AddCustomHeaders(Dictionary<string, string> headersToAdd)
        {
            lock (_requestHeaderLock)
            {
                foreach (var header in headersToAdd)
                {
                    if (header.Key.StartsWith("X-VAULT"))
                    {
                        throw new ArgumentException("Header cannot start with \"X-VAULT\"");
                    }
                    _requestHeaders.CustomHeaders.Add(header.Key, header.Value);
                }
            }
        }

        /// <summary>
        /// Adds a KeyValuePair to the current list of custom headers.
        /// If it already exists it will be overwritten
        /// </summary>
        internal void SetCustomHeader(KeyValuePair<string, string> headerToAdd)
        {
            lock (_requestHeaderLock)
            {
                if (headerToAdd.Key.StartsWith("X-VAULT"))
                {
                    throw new ArgumentException("Header cannot start with \"X-VAULT\"");
                }

                if (_requestHeaders.CustomHeaders.ContainsKey(headerToAdd.Key))
                {
                    _requestHeaders.CustomHeaders[headerToAdd.Key] = headerToAdd.Value;
                }
                else
                {
                    _requestHeaders.CustomHeaders.Add(headerToAdd.Key, headerToAdd.Value);
                }
            }
        }

        /// <summary>
        /// Clears all custom headers
        /// </summary>
        internal void ClearCustomHeaders()
        {
            lock (_requestHeaderLock)
            {
                _requestHeaders.CustomHeaders.Clear();
            }
        }

        /// <summary>
        /// Set MFA Credential Headers 
        /// </summary>
        internal void SetMFACredentials(List<string> MFACredentials)
        {
            lock (_requestHeaderLock)
            {
                _requestHeaders.MFACredentials = MFACredentials;
            }
        }

        /// <summary>
        /// Clear MFA Credential Headers
        /// </summary>
        internal void ClearMFACredentials()
        {
            lock (_requestHeaderLock)
            {
                _requestHeaders.MFACredentials.Clear();
            }
        }

        /// Prepares multipart/form-data content
        HttpContent PrepareMultipartFormDataContent(RequestOptions options)
        {
            string boundary = "---------" + Guid.NewGuid().ToString().ToUpperInvariant();
            var multipartContent = new MultipartFormDataContent(boundary);
            foreach (var formParameter in options.FormParameters)
            {
                multipartContent.Add(new StringContent(formParameter.Value), formParameter.Key);
            }

            if (options.FileParameters != null && options.FileParameters.Count > 0)
            {
                foreach (var fileParam in options.FileParameters)
                {
                    foreach (var file in fileParam.Value)
                    {
                        var content = new StreamContent(file.Content);
                        content.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType);
                        multipartContent.Add(content, fileParam.Key, file.Name);
                    }
                }
            }
            return multipartContent;
        }

        /// <summary>
        /// Provides all logic for constructing a new HttpRequestMessage.
        /// At this point, all information for querying the service is known. Here, it is simply
        /// mapped into the a HttpRequestMessage.
        /// </summary>
        /// <param name="method">The type of Http method</param>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <returns>[private] A new HttpRequestMessage instance.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        private HttpRequestMessage NewRequest(
            HttpMethod method,
            string path,
            RequestOptions options)
        {
            if (path == null) throw new ArgumentNullException("path");
            if (options == null) throw new ArgumentNullException("options");

            string prefix = "v1";

            WebRequestPathBuilder builder = new WebRequestPathBuilder(Configuration.BasePath + prefix, path);

            builder.AddPathParameters(options.PathParameters);

            builder.AddQueryParameters(options.QueryParameters);

            HttpRequestMessage request = new HttpRequestMessage(method, builder.GetFullUri());

            lock (_requestHeaderLock)
            {
                string token = _requestHeaders.Token;
                if (!string.IsNullOrEmpty(token))
                {
                    request.Headers.TryAddWithoutValidation("X-Vault-Token", token);
                }

                string ns = _requestHeaders.Namespace;
                if (!string.IsNullOrEmpty(ns))
                {
                    request.Headers.TryAddWithoutValidation("X-Vault-Namespace", ns);
                }

                int wrapTTL = _requestHeaders.ResponseWrapTTL;
                if (wrapTTL > 0 && !options.HeaderParameters.ContainsKey("X-Vault-Wrap-TTL"))
                {
                    request.Headers.TryAddWithoutValidation("X-Vault-Wrap-TTL", wrapTTL.ToString());
                }

                foreach (var header in _requestHeaders.CustomHeaders)
                {
                    request.Headers.TryAddWithoutValidation(header.Key, header.Value);
                }

                foreach (string mfaCredential in _requestHeaders.MFACredentials)
                {
                    request.Headers.TryAddWithoutValidation("X-Vault-MFA", mfaCredential);
                }
            }

            if (Configuration.UserAgent != null)
            {
                request.Headers.TryAddWithoutValidation("User-Agent", Configuration.UserAgent);
            }

            if (Configuration.DefaultHeaders != null)
            {
                foreach (var headerParam in Configuration.DefaultHeaders)
                {
                    request.Headers.Add(headerParam.Key, headerParam.Value);
                }
            }

            if (options.HeaderParameters != null)
            {
                foreach (var headerParam in options.HeaderParameters)
                {
                    foreach (var value in headerParam.Value)
                    {
                        // Todo make content headers actually content headers
                        request.Headers.TryAddWithoutValidation(headerParam.Key, value);
                    }
                }
            }

            List<Tuple<HttpContent, string, string>> contentList = new List<Tuple<HttpContent, string, string>>();

            string contentType = null;
            if (options.HeaderParameters != null && options.HeaderParameters.ContainsKey("Content-Type"))
            {
                var contentTypes = options.HeaderParameters["Content-Type"];
                contentType = contentTypes.FirstOrDefault();
            }

            if (contentType == "multipart/form-data")
            {
                request.Content = PrepareMultipartFormDataContent(options);
            }
            else if (contentType == "application/x-www-form-urlencoded")
            {
                request.Content = new FormUrlEncodedContent(options.FormParameters);
            }
            else
            {
                if (options.Data != null)
                {
                    if (options.Data is FileParameter fp)
                    {
                        contentType = contentType ?? "application/octet-stream";

                        var streamContent = new StreamContent(fp.Content);
                        streamContent.Headers.ContentType = new MediaTypeHeaderValue(contentType);
                        request.Content = streamContent;
                    }
                    else
                    {
                        var serializer = new CustomJsonCodec(SerializerSettings, Configuration);
                        request.Content = new StringContent(serializer.Serialize(options.Data), new UTF8Encoding(),
                            "application/json");
                    }
                }
            }



            // TODO provide an alternative that allows cookies per request instead of per API client
            if (options.Cookies != null && options.Cookies.Count > 0)
            {
                request.Properties["CookieContainer"] = options.Cookies;
            }

            return request;
        }

        partial void InterceptRequest(HttpRequestMessage req);
        partial void InterceptResponse(HttpRequestMessage req, HttpResponseMessage response);

        private async Task<ApiResponse<T>> ToApiResponse<T>(HttpResponseMessage response, object responseData, Uri uri)
        {
            T result = (T)responseData;
            string rawContent = await response.Content.ReadAsStringAsync();

            var transformed = new ApiResponse<T>(response.StatusCode, new Multimap<string, string>(), result, rawContent)
            {
                ErrorText = response.ReasonPhrase,
                Cookies = new List<Cookie>()
            };

            // process response headers, e.g. Access-Control-Allow-Methods
            if (response.Headers != null)
            {
                foreach (var responseHeader in response.Headers)
                {
                    transformed.Headers.Add(responseHeader.Key, ClientUtils.ParameterToString(responseHeader.Value));
                }
            }

            // process response content headers, e.g. Content-Type
            if (response.Content.Headers != null)
            {
                foreach (var responseHeader in response.Content.Headers)
                {
                    transformed.Headers.Add(responseHeader.Key, ClientUtils.ParameterToString(responseHeader.Value));
                }
            }

            if (Configuration.HttpClientHandler != null && response != null)
            {
                try
                {
                    foreach (Cookie cookie in Configuration.HttpClientHandler.CookieContainer.GetCookies(uri))
                    {
                        transformed.Cookies.Add(cookie);
                    }
                }
                catch (PlatformNotSupportedException) { }
            }

            return transformed;
        }

        private ApiResponse<T> Exec<T>(HttpRequestMessage req)
        {
            return ExecAsync<T>(req).GetAwaiter().GetResult();
        }

        private async Task<ApiResponse<T>> ExecAsync<T>(HttpRequestMessage req,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var deserializer = new CustomJsonCodec(SerializerSettings, Configuration);

            var finalToken = cancellationToken;

            if (Configuration.Timeout > 0)
            {
                var tokenSource = new CancellationTokenSource(Configuration.Timeout);
                finalToken = CancellationTokenSource.CreateLinkedTokenSource(finalToken, tokenSource.Token).Token;
            }

            var cookieContainer = req.Properties.ContainsKey("CookieContainer") ? req.Properties["CookieContainer"] as List<Cookie> : null;

            if (cookieContainer != null)
            {
                if (Configuration.HttpClientHandler == null) throw new InvalidOperationException("Request property `CookieContainer` not supported when the client is explicitly created without an HttpClientHandler, use the proper constructor.");
                foreach (var cookie in cookieContainer)
                {
                    Configuration.HttpClientHandler.CookieContainer.Add(cookie);
                }
            }

            InterceptRequest(req);

            HttpResponseMessage response;
            if (Configuration.RetryConfiguration.RetryPolicy != null)
            {
                var retryPolicy = Configuration.RetryConfiguration.RetryPolicy;
                var rateLimitPolicy = Configuration.RateLimitConfiguration.RateLimitPolicy;
                var policy = Policy.WrapAsync<HttpResponseMessage>(retryPolicy, rateLimitPolicy);

                var policyResult = await policy
                    .ExecuteAndCaptureAsync(async () =>
                    {
                        return await Configuration.HttpClient.SendAsync(ClientUtils.CloneRequest(req), cancellationToken);
                    })
                    .ConfigureAwait(false);


                if (policyResult.Outcome == OutcomeType.Successful)
                {
                    response = policyResult.Result;
                }
                else
                {
                    throw policyResult.FinalException;
                }
            }
            else
            {
                response = await Configuration.HttpClient.SendAsync(req, cancellationToken).ConfigureAwait(false);
            }

            if (!response.IsSuccessStatusCode)
            {
                return await ToApiResponse<T>(response, default(T), req.RequestUri);
            }

            object responseData = await deserializer.Deserialize<T>(response);

            // if the response type is oneOf/anyOf, call FromJSON to deserialize the data
            if (typeof(Vault.Model.AbstractOpenAPISchema).IsAssignableFrom(typeof(T)))
            {
                responseData = (T)typeof(T).GetMethod("FromJson").Invoke(null, new object[] { response.Content });
            }
            else if (typeof(T).Name == "Stream") // for binary response
            {
                responseData = (T)(object)await response.Content.ReadAsStreamAsync();
            }

            InterceptResponse(req, response);

            return await ToApiResponse<T>(response, responseData, req.RequestUri);
        }

        #region IAsynchronousClient
        /// <summary>
        /// Make a HTTP GET request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> GetAsync<T>(string path, RequestOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ExecAsync<T>(NewRequest(HttpMethod.Get, path, options), cancellationToken);
        }

        /// <summary>
        /// Make a HTTP POST request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> PostAsync<T>(string path, RequestOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ExecAsync<T>(NewRequest(HttpMethod.Post, path, options), cancellationToken);
        }

        /// <summary>
        /// Make a HTTP PUT request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> PutAsync<T>(string path, RequestOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ExecAsync<T>(NewRequest(HttpMethod.Put, path, options), cancellationToken);
        }

        /// <summary>
        /// Make a HTTP DELETE request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> DeleteAsync<T>(string path, RequestOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ExecAsync<T>(NewRequest(HttpMethod.Delete, path, options), cancellationToken);
        }

        /// <summary>
        /// Make a HTTP HEAD request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> HeadAsync<T>(string path, RequestOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ExecAsync<T>(NewRequest(HttpMethod.Head, path, options), cancellationToken);
        }

        /// <summary>
        /// Make a HTTP OPTION request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> OptionsAsync<T>(string path, RequestOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ExecAsync<T>(NewRequest(HttpMethod.Options, path, options), cancellationToken);
        }

        /// <summary>
        /// Make a HTTP PATCH request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> PatchAsync<T>(string path, RequestOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ExecAsync<T>(NewRequest(new HttpMethod("PATCH"), path, options), cancellationToken);
        }
        #endregion IAsynchronousClient

        #region ISynchronousClient
        /// <summary>
        /// Make a HTTP GET request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Get<T>(string path, RequestOptions options)
        {
            return Exec<T>(NewRequest(HttpMethod.Get, path, options));
        }

        /// <summary>
        /// Make a HTTP POST request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Post<T>(string path, RequestOptions options)
        {
            return Exec<T>(NewRequest(HttpMethod.Post, path, options));
        }

        /// <summary>
        /// Make a HTTP PUT request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Put<T>(string path, RequestOptions options)
        {
            return Exec<T>(NewRequest(HttpMethod.Put, path, options));
        }

        /// <summary>
        /// Make a HTTP DELETE request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Delete<T>(string path, RequestOptions options)
        {
            return Exec<T>(NewRequest(HttpMethod.Delete, path, options));
        }

        /// <summary>
        /// Make a HTTP HEAD request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Head<T>(string path, RequestOptions options)
        {
            return Exec<T>(NewRequest(HttpMethod.Head, path, options));
        }

        /// <summary>
        /// Make a HTTP OPTION request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Options<T>(string path, RequestOptions options)
        {
            return Exec<T>(NewRequest(HttpMethod.Options, path, options));
        }

        /// <summary>
        /// Make a HTTP PATCH request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Patch<T>(string path, RequestOptions options)
        {
            return Exec<T>(NewRequest(new HttpMethod("PATCH"), path, options));
        }
        #endregion ISynchronousClient
    }
}
