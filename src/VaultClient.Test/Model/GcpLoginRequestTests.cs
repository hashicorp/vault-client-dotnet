/*
 * HashiCorp Vault API
 *
 * HTTP API that gives you full access to Vault. All API routes are prefixed with `/v1/`.
 *
 * The version of the OpenAPI document: 1.11.0
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
    ///  Class for testing GcpLoginRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GcpLoginRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GcpLoginRequest
        //private GcpLoginRequest instance;

        public GcpLoginRequestTests()
        {
            // TODO uncomment below to create an instance of GcpLoginRequest
            //instance = new GcpLoginRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GcpLoginRequest
        /// </summary>
        [Fact]
        public void GcpLoginRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" GcpLoginRequest
            //Assert.IsType<GcpLoginRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Jwt'
        /// </summary>
        [Fact]
        public void JwtTest()
        {
            // TODO unit test for the property 'Jwt'
        }
        /// <summary>
        /// Test the property 'Role'
        /// </summary>
        [Fact]
        public void RoleTest()
        {
            // TODO unit test for the property 'Role'
        }

    }

}
