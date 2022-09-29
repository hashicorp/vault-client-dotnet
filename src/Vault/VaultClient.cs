/*
 * HashiCorp Vault API
 *
 * HTTP API that gives you full access to Vault. All API routes are prefixed with `/v1/`.
 *
 * The version of the OpenAPI document: 1.12.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Net.Http;
using Vault.Api;
using Vault.Client;

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

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultClient"/> class
        /// </summary>
        public VaultClient(Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException(nameof(Configuration));

            _apiClient = new ApiClient(configuration);

            this.Auth = new Vault.Api.Auth(_apiClient);
            this.Identity = new Vault.Api.Identity(_apiClient);
            this.Secrets = new Vault.Api.Secrets(_apiClient);
            this.System = new Vault.Api.System(_apiClient);
        }

        /// <summary>
        /// Sets the client token to inject as a header into Api calls
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
        /// Sets the Namespace value to be used as a header with api calls
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
    }
}