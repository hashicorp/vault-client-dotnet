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
    ///  Class for testing RevokePrefixRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RevokePrefixRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for RevokePrefixRequest
        //private RevokePrefixRequest instance;

        public RevokePrefixRequestTests()
        {
            // TODO uncomment below to create an instance of RevokePrefixRequest
            //instance = new RevokePrefixRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RevokePrefixRequest
        /// </summary>
        [Fact]
        public void RevokePrefixRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" RevokePrefixRequest
            //Assert.IsType<RevokePrefixRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Sync'
        /// </summary>
        [Fact]
        public void SyncTest()
        {
            // TODO unit test for the property 'Sync'
        }

    }

}
