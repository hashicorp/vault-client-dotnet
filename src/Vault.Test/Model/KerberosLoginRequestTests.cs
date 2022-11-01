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
    ///  Class for testing KerberosLoginRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class KerberosLoginRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for KerberosLoginRequest
        //private KerberosLoginRequest instance;

        public KerberosLoginRequestTests()
        {
            // TODO uncomment below to create an instance of KerberosLoginRequest
            //instance = new KerberosLoginRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of KerberosLoginRequest
        /// </summary>
        [Fact]
        public void KerberosLoginRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" KerberosLoginRequest
            //Assert.IsType<KerberosLoginRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Authorization'
        /// </summary>
        [Fact]
        public void AuthorizationTest()
        {
            // TODO unit test for the property 'Authorization'
        }

    }

}
