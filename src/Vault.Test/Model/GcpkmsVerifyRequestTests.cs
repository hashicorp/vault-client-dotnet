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
    ///  Class for testing GcpkmsVerifyRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GcpkmsVerifyRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GcpkmsVerifyRequest
        //private GcpkmsVerifyRequest instance;

        public GcpkmsVerifyRequestTests()
        {
            // TODO uncomment below to create an instance of GcpkmsVerifyRequest
            //instance = new GcpkmsVerifyRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GcpkmsVerifyRequest
        /// </summary>
        [Fact]
        public void GcpkmsVerifyRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" GcpkmsVerifyRequest
            //Assert.IsType<GcpkmsVerifyRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Digest'
        /// </summary>
        [Fact]
        public void DigestTest()
        {
            // TODO unit test for the property 'Digest'
        }
        /// <summary>
        /// Test the property 'KeyVersion'
        /// </summary>
        [Fact]
        public void KeyVersionTest()
        {
            // TODO unit test for the property 'KeyVersion'
        }
        /// <summary>
        /// Test the property 'Signature'
        /// </summary>
        [Fact]
        public void SignatureTest()
        {
            // TODO unit test for the property 'Signature'
        }

    }

}