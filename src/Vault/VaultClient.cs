// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

// Code generated with OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.


using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vault.Client;
using Vault.Model;

namespace Vault
{
    /// <summary>
    /// The primary Vault client class
    /// </summary>
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
        /// <param name="path">Path to read from</param>
        /// <param name="queryParameters">Optional dictionary of query parameters</param>
        /// </summary>
        public VaultResponse<T> Read<T>(string path, Dictionary<string, object> queryParameters = null)
        {
            return ReadAsync<T>(path, queryParameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Generic Read Async
        /// <param name="path">Path to read from</param>
        /// <param name="queryParameters">Optional dictionary of query parameters</param>
        /// </summary>
        public async Task<VaultResponse<T>> ReadAsync<T>(string path, Dictionary<string, object> queryParameters = null)
        {
            if (string.IsNullOrEmpty(path)) throw new ArgumentNullException("path", "Cannot be null or empty");

            RequestOptions requestOptions = new RequestOptions();
            if (queryParameters != null)
            {
                requestOptions.QueryParameters.Add(ClientUtils.DictionaryToMultimap(queryParameters));
            }

            var apiResponse = await _apiClient.GetAsync<T>(ClientUtils.SanitizePath(path), requestOptions);

            Exception exception = this._exceptionFactory("Read", apiResponse);
            if (exception != null) throw exception;

            return ClientUtils.ToVaultResponse<T>(apiResponse.RawContent);
        }

        /// <summary>
        /// Generic Write
        /// <param name="path">Path to write to</param>
        /// <param name="data">Data to be written</param>
        /// </summary>
        public VaultResponse<T> Write<T>(string path, Dictionary<string, object> data)
        {
            return WriteAsync<T>(path, data).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Generic Write Async
        /// <param name="path">Path to write to</param>
        /// <param name="data">Data to be written</param>
        /// </summary>
        public async Task<VaultResponse<T>> WriteAsync<T>(string path, Dictionary<string, object> data)
        {
            if (string.IsNullOrEmpty(path)) throw new ArgumentNullException("path", "Cannot be null or empty");

            RequestOptions requestOptions = new RequestOptions();
            requestOptions.Data = data;
            var apiResponse = await _apiClient.PostAsync<T>(ClientUtils.SanitizePath(path), requestOptions);

            Exception exception = this._exceptionFactory("Write", apiResponse);
            if (exception != null) throw exception;

            return ClientUtils.ToVaultResponse<T>(apiResponse.RawContent);
        }

        /// <summary>
        /// Generic Delete
        /// <param name="path">Path to delete at</param>
        /// <param name="queryParameters">Optional dictionary of query parameters</param>
        /// </summary>
        public VaultResponse<T> Delete<T>(string path, Dictionary<string, object> queryParameters = null)
        {
            return DeleteAsync<T>(path, queryParameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Generic Delete Async
        /// <param name="path">Path to delete at</param>
        /// <param name="queryParameters">Optional dictionary of query parameters</param>
        /// </summary>
        public async Task<VaultResponse<T>> DeleteAsync<T>(string path, Dictionary<string, object> queryParameters = null)
        {
            if (string.IsNullOrEmpty(path)) throw new ArgumentNullException("path", "Cannot be null or empty");

            RequestOptions requestOptions = new RequestOptions();
            if (queryParameters != null)
            {
                requestOptions.QueryParameters.Add(ClientUtils.DictionaryToMultimap(queryParameters));
            }

            var apiResponse = await _apiClient.DeleteAsync<T>(ClientUtils.SanitizePath(path), requestOptions);

            Exception exception = this._exceptionFactory("Delete", apiResponse);
            if (exception != null) throw exception;

            return ClientUtils.ToVaultResponse<T>(apiResponse.RawContent);
        }

        /// <summary>
        /// Generic List
        /// <param name="path">Path to list at</param>
        /// </summary>
        public VaultResponse<T> List<T>(string path)
        {
            return ListAsync<T>(path).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Generic List Async
        /// <param name="path">Path to list at</param>
        /// </summary>
        public async Task<VaultResponse<T>> ListAsync<T>(string path)
        {
            if (string.IsNullOrEmpty(path)) throw new ArgumentNullException("path", "Cannot be null or empty");

            RequestOptions requestOptions = new RequestOptions();
            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));

            var apiResponse = await _apiClient.GetAsync<T>(ClientUtils.SanitizePath(path), requestOptions);

            Exception exception = this._exceptionFactory("List", apiResponse);
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
            if (string.IsNullOrEmpty(token)) throw new ArgumentNullException("Token", "Token cannot be null or empty");

            RequestOptions requestOptions = new RequestOptions();
            requestOptions.Data = new WrappingUnwrapRequest(token);
            var response = await this._apiClient.PostAsync<Object>("/sys/wrapping/unwrap", requestOptions);

            Exception exception = this._exceptionFactory("SystemUnwrapAsync", response);
            if (exception != null) throw exception;

            return ClientUtils.ToVaultResponse<T>(response.RawContent);
        }
    }
}