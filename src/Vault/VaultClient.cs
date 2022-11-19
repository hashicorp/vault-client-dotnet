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
        public void SetWrapTTL(int ttlSeconds)
        {
            if (ttlSeconds < 1)
            {
                throw new ArgumentException("TTL should be greater than 0");
            }

            _apiClient.SetWrapTTL(ttlSeconds);
        }

        /// <summary>
        /// Clears the current X-Vault-Wrap-TTL header
        /// </summary>
        public void ClearWrapTTL()
        {
            _apiClient.SetWrapTTL(0);
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
    }
}