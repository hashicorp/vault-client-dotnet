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
    ///  Class for testing GoogleCloudWriteRolesetKeyRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GoogleCloudWriteRolesetKeyRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GoogleCloudWriteRolesetKeyRequest
        //private GoogleCloudWriteRolesetKeyRequest instance;

        public GoogleCloudWriteRolesetKeyRequestTests()
        {
            // TODO uncomment below to create an instance of GoogleCloudWriteRolesetKeyRequest
            //instance = new GoogleCloudWriteRolesetKeyRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GoogleCloudWriteRolesetKeyRequest
        /// </summary>
        [Fact]
        public void GoogleCloudWriteRolesetKeyRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" GoogleCloudWriteRolesetKeyRequest
            //Assert.IsType<GoogleCloudWriteRolesetKeyRequest>(instance);
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