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
    ///  Class for testing GcpRolesetKeyRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GcpRolesetKeyRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GcpRolesetKeyRequest
        //private GcpRolesetKeyRequest instance;

        public GcpRolesetKeyRequestTests()
        {
            // TODO uncomment below to create an instance of GcpRolesetKeyRequest
            //instance = new GcpRolesetKeyRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GcpRolesetKeyRequest
        /// </summary>
        [Fact]
        public void GcpRolesetKeyRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" GcpRolesetKeyRequest
            //Assert.IsType<GcpRolesetKeyRequest>(instance);
        }


        /// <summary>
        /// Test the property 'KeyAlgorithm'
        /// </summary>
        [Fact]
        public void KeyAlgorithmTest()
        {
            // TODO unit test for the property 'KeyAlgorithm'
        }
        /// <summary>
        /// Test the property 'KeyType'
        /// </summary>
        [Fact]
        public void KeyTypeTest()
        {
            // TODO unit test for the property 'KeyType'
        }
        /// <summary>
        /// Test the property 'Ttl'
        /// </summary>
        [Fact]
        public void TtlTest()
        {
            // TODO unit test for the property 'Ttl'
        }

    }

}
