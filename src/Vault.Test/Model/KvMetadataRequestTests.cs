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
    ///  Class for testing KvMetadataRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class KvMetadataRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for KvMetadataRequest
        //private KvMetadataRequest instance;

        public KvMetadataRequestTests()
        {
            // TODO uncomment below to create an instance of KvMetadataRequest
            //instance = new KvMetadataRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of KvMetadataRequest
        /// </summary>
        [Fact]
        public void KvMetadataRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" KvMetadataRequest
            //Assert.IsType<KvMetadataRequest>(instance);
        }


        /// <summary>
        /// Test the property 'CasRequired'
        /// </summary>
        [Fact]
        public void CasRequiredTest()
        {
            // TODO unit test for the property 'CasRequired'
        }
        /// <summary>
        /// Test the property 'CustomMetadata'
        /// </summary>
        [Fact]
        public void CustomMetadataTest()
        {
            // TODO unit test for the property 'CustomMetadata'
        }
        /// <summary>
        /// Test the property 'DeleteVersionAfter'
        /// </summary>
        [Fact]
        public void DeleteVersionAfterTest()
        {
            // TODO unit test for the property 'DeleteVersionAfter'
        }
        /// <summary>
        /// Test the property 'MaxVersions'
        /// </summary>
        [Fact]
        public void MaxVersionsTest()
        {
            // TODO unit test for the property 'MaxVersions'
        }

    }

}