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
    ///  Class for testing PkiKmsRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PkiKmsRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PkiKmsRequest
        //private PkiKmsRequest instance;

        public PkiKmsRequestTests()
        {
            // TODO uncomment below to create an instance of PkiKmsRequest
            //instance = new PkiKmsRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PkiKmsRequest
        /// </summary>
        [Fact]
        public void PkiKmsRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" PkiKmsRequest
            //Assert.IsType<PkiKmsRequest>(instance);
        }


        /// <summary>
        /// Test the property 'KeyBits'
        /// </summary>
        [Fact]
        public void KeyBitsTest()
        {
            // TODO unit test for the property 'KeyBits'
        }
        /// <summary>
        /// Test the property 'KeyName'
        /// </summary>
        [Fact]
        public void KeyNameTest()
        {
            // TODO unit test for the property 'KeyName'
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
        /// Test the property 'ManagedKeyId'
        /// </summary>
        [Fact]
        public void ManagedKeyIdTest()
        {
            // TODO unit test for the property 'ManagedKeyId'
        }
        /// <summary>
        /// Test the property 'ManagedKeyName'
        /// </summary>
        [Fact]
        public void ManagedKeyNameTest()
        {
            // TODO unit test for the property 'ManagedKeyName'
        }

    }

}
