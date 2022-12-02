/*
 * HashiCorp Vault API
 *
 * HTTP API that gives you full access to Vault. All API routes are prefixed with `/v1/`.
 *
 * The version of the OpenAPI document: 1.13.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vault.Client;
using Vault.Model;

namespace Vault
{
    public class VaultClient
    {

        /// <summary>
        /// To access Vault Auth methods
        /// </summary>
        public Vault.Api.Auth Auth;

        /// <summary>
        /// To access Vault Identity methods
        /// </summary>
        public Vault.Api.Identity Identity;

        /// <summary>
        /// To access Vault Secrets methods
        /// </summary>
        public Vault.Api.Secrets Secrets;

        /// <summary>
        /// To access Vault System methods
        /// </summary>
        public Vault.Api.System System;

        private ApiClient _apiClient;

        private ExceptionFactory _exceptionFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultClient"/> class
        /// </summary>
        public VaultClient(VaultConfiguration configuration)
        {
            if (configuration == null) throw new ArgumentNullException(nameof(VaultConfiguration));

            _apiClient = new ApiClient(configuration);
            _exceptionFactory = VaultConfiguration.DefaultExceptionFactory;

            this.Auth = new Vault.Api.Auth(_apiClient);
            this.Identity = new Vault.Api.Identity(_apiClient);
            this.Secrets = new Vault.Api.Secrets(_apiClient);
            this.System = new Vault.Api.System(_apiClient);
        }

        /// <summary>
        /// Sets the X-Vault-Token header
        /// </summary>
        public void SetToken(string token)
        {
            if (string.IsNullOrEmpty(token))
            {
                throw new ArgumentNullException("Token cannot be empty");
            }

            _apiClient.SetToken(token);
        }

        /// <summary>
        /// Sets X-Vault-Namespace header
        /// </summary>
        public void SetNamespace(string Namespace)
        {
            if (string.IsNullOrEmpty(Namespace))
            {
                throw new ArgumentNullException("Namespace cannot be empty");
            }

            _apiClient.SetNamespace(Namespace);
        }

        /// <summary>
        /// Clears the currently set namespace
        /// </summary>
        public void ClearNamespace()
        {
            _apiClient.SetNamespace(string.Empty);
        }

        /// <summary>
        /// Sets the X-Vault-Wrap-TTL header
        /// <remarks>
        /// Sets the response wrapping TTL to the given duration
        /// for subsequent requests. Vault will then wrap responses 
        /// and return a response-wrapping token instead.
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </summary>
        public void SetWrapTTL(TimeSpan ttl)
        {
            if (ttl.TotalSeconds < 1)
            {
                throw new ArgumentException("Time to live must be greater than 0");
            }

            _apiClient.SetWrapTTL(ttl);
        }

        /// <summary>
        /// Clears the current X-Vault-Wrap-TTL header
        /// </summary>
        public void ClearWrapTTL()
        {
            _apiClient.SetWrapTTL(TimeSpan.Zero);
        }

        /// <summary>
        /// Adds a dictionary of custom headers to current list of custom headers
        /// </summary>
        public void AddCustomHeaders(Dictionary<string, string> headersToAdd)
        {
            _apiClient.AddCustomHeaders(headersToAdd);
        }

        /// <summary>
        /// Overwrites or adds an existing header
        /// </summary>
        public void SetCustomHeader(KeyValuePair<string, string> headerToAdd)
        {
            _apiClient.SetCustomHeader(headerToAdd);
        }

        /// <summary>
        /// Clear all custom headers
        /// </summary>
        public void ClearCustomHeaders()
        {
            _apiClient.ClearCustomHeaders();
        }

        /// <summary>
        /// Setting MFA Headers ("X-Vault-MFA") on subsequent requests
        /// See: https://learn.hashicorp.com/tutorials/vault/multi-factor-authentication
        /// </summary>
        public void SetMFACredentials(List<string> MFACredentials)
        {
            _apiClient.SetMFACredentials(MFACredentials);
        }

        /// <summary>
        /// Clear MFA Credentials headers
        /// </summary>
        public void ClearMFACredentials()
        {
            _apiClient.ClearMFACredentials();
        }


        /// <summary>
        /// Generic Read
        /// </summary>
        public VaultResponse<T> Read<T>(string path)
        {
            return ReadAsync<T>(path).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Generic Read Async
        /// </summary>
        public async Task<VaultResponse<T>> ReadAsync<T>(string path)
        {
            if (string.IsNullOrEmpty(path)) throw new ArgumentNullException("path", "Cannot be null");

            var apiResponse = await _apiClient.GetAsync<Object>(path, new RequestOptions());

            Exception exception = this._exceptionFactory("GenericReadAsync", apiResponse);
            if (exception != null) throw exception;

            return ClientUtils.ToVaultResponse<T>(apiResponse.RawContent);
        }

        /// <summary>
        /// Generic Write
        /// </summary>
        public VaultResponse<T> Write<T>(string path)
        {
            return WriteAsync<T>(path).GetAwaiter().GetResult(); ;
        }

        /// <summary>
        /// Generic Write Async
        /// </summary>
        public async Task<VaultResponse<T>> WriteAsync<T>(string path)
        {
            if (string.IsNullOrEmpty(path)) throw new ArgumentNullException("path", "Cannot be null");

            var apiResponse = await _apiClient.GetAsync<Object>(path, new RequestOptions());

            Exception exception = this._exceptionFactory("GenericWriteAsync", apiResponse);
            if (exception != null) throw exception;

            return ClientUtils.ToVaultResponse<T>(apiResponse.RawContent);
        }

        /// <summary>
        /// Generic Delete
        /// </summary>
        public VaultResponse<T> Delete<T>(string path)
        {
            return DeleteAsync<T>(path).GetAwaiter().GetResult(); ;
        }

        /// <summary>
        /// Generic Delete Async
        /// </summary>
        public async Task<VaultResponse<T>> DeleteAsync<T>(string path)
        {
            if (string.IsNullOrEmpty(path)) throw new ArgumentNullException("path", "Cannot be null");

            var apiResponse = await _apiClient.DeleteAsync<Object>(path, new RequestOptions());

            Exception exception = this._exceptionFactory("GenericDeleteAsync", apiResponse);
            if (exception != null) throw exception;

            return ClientUtils.ToVaultResponse<T>(apiResponse.RawContent);
        }

        /// <summary>
        /// Generic List
        /// </summary>
        public VaultResponse<T> List<T>(string path)
        {
            return ListAsync<T>(path).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Generic List Async
        /// </summary>
        public async Task<VaultResponse<T>> ListAsync<T>(string path)
        {
            if (string.IsNullOrEmpty(path)) throw new ArgumentNullException("path", "Cannot be null");

            RequestOptions requestOptions = new RequestOptions();
            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));

            var apiResponse = await _apiClient.GetAsync<Object>(path, requestOptions);

            Exception exception = this._exceptionFactory("GenericListAsync", apiResponse);
            if (exception != null) throw exception;

            return ClientUtils.ToVaultResponse<T>(apiResponse.RawContent);
        }

        /// <summary>
        /// Unwrap a response
        /// <remarks>
        /// Attempts to to unwrap the token provided
        /// </remarks>
        /// <see href="https://developer.hashicorp.com/vault/docs/concepts/response-wrapping"/>
        /// </summary>
        public VaultResponse<T> Unwrap<T>(string token)
        {
            return UnwrapAsync<T>(token).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Async unwrap a response
        /// <remarks>
        /// Attempts to to unwrap the token provided
        /// </remarks>
        /// <see href="https://developer.hashicorp.com/vault/docs/concepts/response-wrapping"/>
        /// </summary>
        public async Task<VaultResponse<T>> UnwrapAsync<T>(string token)
        {
            if (string.IsNullOrEmpty(token)) throw new ArgumentNullException("Token", "Token cannot be empty");

            RequestOptions requestOptions = new RequestOptions();
            requestOptions.Data = new SystemWrappingUnwrapRequest(token);
            var response = await this._apiClient.PostAsync<Object>("/sys/wrapping/unwrap", requestOptions);

            Exception exception = this._exceptionFactory("SystemUnwrapAsync", response);
            if (exception != null) throw exception;

            return ClientUtils.ToVaultResponse<T>(response.RawContent);
        }
    }
}