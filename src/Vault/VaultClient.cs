/*
 * HashiCorp Vault API
 *
 * HTTP API that gives you full access to Vault. All API routes are prefixed with `/v1/`.
 *
 * The version of the OpenAPI document: 1.12.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
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
        
        private readonly Configuration _configuration;

        private readonly ApiClient _apiClient;

        public VaultClient(string VaultAddress)
        {
            if(string.IsNullOrEmpty(VaultAddress))
            {
                throw new ArgumentException("Cannot be empty", "VaultAddress");
            }

            _configuration = new Configuration();
            _configuration.BasePath = VaultAddress;

            _apiClient = new ApiClient(_configuration);
            
            this.Auth = new Vault.Api.Auth(_apiClient);
            this.Identity = new Vault.Api.Identity(_apiClient);
            this.Secrets = new Vault.Api.Secrets(_apiClient);
            this.System = new Vault.Api.System(_apiClient);
        }
    }    
}