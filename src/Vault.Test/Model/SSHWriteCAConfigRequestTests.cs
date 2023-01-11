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
    ///  Class for testing SSHWriteCAConfigRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SSHWriteCAConfigRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SSHWriteCAConfigRequest
        //private SSHWriteCAConfigRequest instance;

        public SSHWriteCAConfigRequestTests()
        {
            // TODO uncomment below to create an instance of SSHWriteCAConfigRequest
            //instance = new SSHWriteCAConfigRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SSHWriteCAConfigRequest
        /// </summary>
        [Fact]
        public void SSHWriteCAConfigRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" SSHWriteCAConfigRequest
            //Assert.IsType<SSHWriteCAConfigRequest>(instance);
        }


        /// <summary>
        /// Test the property 'GenerateSigningKey'
        /// </summary>
        [Fact]
        public void GenerateSigningKeyTest()
        {
            // TODO unit test for the property 'GenerateSigningKey'
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
        /// Test the property 'KeyType'
        /// </summary>
        [Fact]
        public void KeyTypeTest()
        {
            // TODO unit test for the property 'KeyType'
        }
        /// <summary>
        /// Test the property 'PrivateKey'
        /// </summary>
        [Fact]
        public void PrivateKeyTest()
        {
            // TODO unit test for the property 'PrivateKey'
        }
        /// <summary>
        /// Test the property 'PublicKey'
        /// </summary>
        [Fact]
        public void PublicKeyTest()
        {
            // TODO unit test for the property 'PublicKey'
        }

    }

}
