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
    ///  Class for testing AdLibraryRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AdLibraryRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AdLibraryRequest
        //private AdLibraryRequest instance;

        public AdLibraryRequestTests()
        {
            // TODO uncomment below to create an instance of AdLibraryRequest
            //instance = new AdLibraryRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AdLibraryRequest
        /// </summary>
        [Fact]
        public void AdLibraryRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" AdLibraryRequest
            //Assert.IsType<AdLibraryRequest>(instance);
        }


        /// <summary>
        /// Test the property 'DisableCheckInEnforcement'
        /// </summary>
        [Fact]
        public void DisableCheckInEnforcementTest()
        {
            // TODO unit test for the property 'DisableCheckInEnforcement'
        }
        /// <summary>
        /// Test the property 'MaxTtl'
        /// </summary>
        [Fact]
        public void MaxTtlTest()
        {
            // TODO unit test for the property 'MaxTtl'
        }
        /// <summary>
        /// Test the property 'ServiceAccountNames'
        /// </summary>
        [Fact]
        public void ServiceAccountNamesTest()
        {
            // TODO unit test for the property 'ServiceAccountNames'
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
