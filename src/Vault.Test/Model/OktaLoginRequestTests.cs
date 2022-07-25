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
using Vault.Api;
using Vault.Model;
using Vault.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Vault.Test.Model
{
    /// <summary>
    ///  Class for testing OktaLoginRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class OktaLoginRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for OktaLoginRequest
        //private OktaLoginRequest instance;

        public OktaLoginRequestTests()
        {
            // TODO uncomment below to create an instance of OktaLoginRequest
            //instance = new OktaLoginRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OktaLoginRequest
        /// </summary>
        [Fact]
        public void OktaLoginRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" OktaLoginRequest
            //Assert.IsType<OktaLoginRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Nonce'
        /// </summary>
        [Fact]
        public void NonceTest()
        {
            // TODO unit test for the property 'Nonce'
        }
        /// <summary>
        /// Test the property 'Password'
        /// </summary>
        [Fact]
        public void PasswordTest()
        {
            // TODO unit test for the property 'Password'
        }
        /// <summary>
        /// Test the property 'Provider'
        /// </summary>
        [Fact]
        public void ProviderTest()
        {
            // TODO unit test for the property 'Provider'
        }
        /// <summary>
        /// Test the property 'Totp'
        /// </summary>
        [Fact]
        public void TotpTest()
        {
            // TODO unit test for the property 'Totp'
        }

    }

}