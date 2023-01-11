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
    ///  Class for testing GoogleCloudKMSReencryptRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GoogleCloudKMSReencryptRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GoogleCloudKMSReencryptRequest
        //private GoogleCloudKMSReencryptRequest instance;

        public GoogleCloudKMSReencryptRequestTests()
        {
            // TODO uncomment below to create an instance of GoogleCloudKMSReencryptRequest
            //instance = new GoogleCloudKMSReencryptRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GoogleCloudKMSReencryptRequest
        /// </summary>
        [Fact]
        public void GoogleCloudKMSReencryptRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" GoogleCloudKMSReencryptRequest
            //Assert.IsType<GoogleCloudKMSReencryptRequest>(instance);
        }


        /// <summary>
        /// Test the property 'AdditionalAuthenticatedData'
        /// </summary>
        [Fact]
        public void AdditionalAuthenticatedDataTest()
        {
            // TODO unit test for the property 'AdditionalAuthenticatedData'
        }
        /// <summary>
        /// Test the property 'Ciphertext'
        /// </summary>
        [Fact]
        public void CiphertextTest()
        {
            // TODO unit test for the property 'Ciphertext'
        }
        /// <summary>
        /// Test the property 'KeyVersion'
        /// </summary>
        [Fact]
        public void KeyVersionTest()
        {
            // TODO unit test for the property 'KeyVersion'
        }

    }

}
