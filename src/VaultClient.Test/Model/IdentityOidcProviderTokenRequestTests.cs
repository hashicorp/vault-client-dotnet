/*
 * HashiCorp Vault API
 *
 * HTTP API that gives you full access to Vault. All API routes are prefixed with `/v1/`.
 *
 * The version of the OpenAPI document: 1.12.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using VaultClient.Api;
using VaultClient.Model;
using VaultClient.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace VaultClient.Test.Model
{
    /// <summary>
    ///  Class for testing IdentityOidcProviderTokenRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class IdentityOidcProviderTokenRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for IdentityOidcProviderTokenRequest
        //private IdentityOidcProviderTokenRequest instance;

        public IdentityOidcProviderTokenRequestTests()
        {
            // TODO uncomment below to create an instance of IdentityOidcProviderTokenRequest
            //instance = new IdentityOidcProviderTokenRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IdentityOidcProviderTokenRequest
        /// </summary>
        [Fact]
        public void IdentityOidcProviderTokenRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" IdentityOidcProviderTokenRequest
            //Assert.IsType<IdentityOidcProviderTokenRequest>(instance);
        }


        /// <summary>
        /// Test the property 'ClientId'
        /// </summary>
        [Fact]
        public void ClientIdTest()
        {
            // TODO unit test for the property 'ClientId'
        }
        /// <summary>
        /// Test the property 'Code'
        /// </summary>
        [Fact]
        public void CodeTest()
        {
            // TODO unit test for the property 'Code'
        }
        /// <summary>
        /// Test the property 'CodeVerifier'
        /// </summary>
        [Fact]
        public void CodeVerifierTest()
        {
            // TODO unit test for the property 'CodeVerifier'
        }
        /// <summary>
        /// Test the property 'GrantType'
        /// </summary>
        [Fact]
        public void GrantTypeTest()
        {
            // TODO unit test for the property 'GrantType'
        }
        /// <summary>
        /// Test the property 'RedirectUri'
        /// </summary>
        [Fact]
        public void RedirectUriTest()
        {
            // TODO unit test for the property 'RedirectUri'
        }

    }

}
