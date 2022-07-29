/*
 * HashiCorp Vault API
 *
 * HTTP API that gives you full access to Vault. All API routes are prefixed with `/v1/`.
 *
 * The version of the OpenAPI document: 1.12.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Net.Http;
using Vault.Api;
using Vault.Client;

namespace Vault
{
    public class VaultClient
    {
        public Vault.Api.Auth Auth;
        public Vault.Api.Identity Identity;
        public Vault.Api.Secrets Secrets;
        public Vault.Api.System System;
                
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultClient"/> class
        /// </summary>
        public VaultClient(Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException(nameof(Configuration));

            var apiClient = new ApiClient(configuration);

            this.Auth = new Vault.Api.Auth(apiClient);
            this.Identity = new Vault.Api.Identity(apiClient);
            this.Secrets = new Vault.Api.Secrets(apiClient);
            this.System = new Vault.Api.System(apiClient);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultClient"/> class
        /// </summary>
        public VaultClient(string VaultAddress)
        {
            if(string.IsNullOrEmpty(VaultAddress))
            {
                throw new ArgumentException("Cannot be empty", "VaultAddress");
            }

            var configuration = new Configuration(VaultAddress);

            var apiClient = new ApiClient(configuration);
            
            this.Auth = new Vault.Api.Auth(apiClient);
            this.Identity = new Vault.Api.Identity(apiClient);
            this.Secrets = new Vault.Api.Secrets(apiClient);
            this.System = new Vault.Api.System(apiClient);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultClient"/> class
        /// </summary>
        public VaultClient(string VaultAddress, HttpClient httpClient)
        {
            if(string.IsNullOrEmpty(VaultAddress)) throw new ArgumentException("Cannot be empty", "VaultAddress");
            if(httpClient == null) throw new ArgumentNullException(nameof(httpClient));

            var configuration = new Configuration(VaultAddress);

            var apiClient = new ApiClient(configuration, httpClient);
            
            this.Auth = new Vault.Api.Auth(apiClient);
            this.Identity = new Vault.Api.Identity(apiClient);
            this.Secrets = new Vault.Api.Secrets(apiClient);
            this.System = new Vault.Api.System(apiClient);
        }
    }    
}