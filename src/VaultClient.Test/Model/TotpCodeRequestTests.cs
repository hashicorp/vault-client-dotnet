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
    ///  Class for testing TotpCodeRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TotpCodeRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TotpCodeRequest
        //private TotpCodeRequest instance;

        public TotpCodeRequestTests()
        {
            // TODO uncomment below to create an instance of TotpCodeRequest
            //instance = new TotpCodeRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TotpCodeRequest
        /// </summary>
        [Fact]
        public void TotpCodeRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" TotpCodeRequest
            //Assert.IsType<TotpCodeRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Code'
        /// </summary>
        [Fact]
        public void CodeTest()
        {
            // TODO unit test for the property 'Code'
        }

    }

}
