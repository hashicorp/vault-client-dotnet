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
    ///  Class for testing PkiKeysImportRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PkiKeysImportRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PkiKeysImportRequest
        //private PkiKeysImportRequest instance;

        public PkiKeysImportRequestTests()
        {
            // TODO uncomment below to create an instance of PkiKeysImportRequest
            //instance = new PkiKeysImportRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PkiKeysImportRequest
        /// </summary>
        [Fact]
        public void PkiKeysImportRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" PkiKeysImportRequest
            //Assert.IsType<PkiKeysImportRequest>(instance);
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
        /// Test the property 'PemBundle'
        /// </summary>
        [Fact]
        public void PemBundleTest()
        {
            // TODO unit test for the property 'PemBundle'
        }

    }

}
