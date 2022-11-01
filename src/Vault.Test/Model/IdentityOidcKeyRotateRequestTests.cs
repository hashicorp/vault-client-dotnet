/*
 * HashiCorp Vault API
 *
 * HTTP API that gives you full access to Vault. All API routes are prefixed with `/v1/`.
 *
 * The version of the OpenAPI document: 1.13.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Vault.Api;
using Vault.Model;
using Vault.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Vault.Test.Model
{
    /// <summary>
    ///  Class for testing IdentityOidcKeyRotateRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class IdentityOidcKeyRotateRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for IdentityOidcKeyRotateRequest
        //private IdentityOidcKeyRotateRequest instance;

        public IdentityOidcKeyRotateRequestTests()
        {
            // TODO uncomment below to create an instance of IdentityOidcKeyRotateRequest
            //instance = new IdentityOidcKeyRotateRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IdentityOidcKeyRotateRequest
        /// </summary>
        [Fact]
        public void IdentityOidcKeyRotateRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" IdentityOidcKeyRotateRequest
            //Assert.IsType<IdentityOidcKeyRotateRequest>(instance);
        }


        /// <summary>
        /// Test the property 'VerificationTtl'
        /// </summary>
        [Fact]
        public void VerificationTtlTest()
        {
            // TODO unit test for the property 'VerificationTtl'
        }

    }

}
