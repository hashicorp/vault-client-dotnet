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
    ///  Class for testing WriteLoggerRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class WriteLoggerRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for WriteLoggerRequest
        //private WriteLoggerRequest instance;

        public WriteLoggerRequestTests()
        {
            // TODO uncomment below to create an instance of WriteLoggerRequest
            //instance = new WriteLoggerRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WriteLoggerRequest
        /// </summary>
        [Fact]
        public void WriteLoggerRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" WriteLoggerRequest
            //Assert.IsType<WriteLoggerRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Level'
        /// </summary>
        [Fact]
        public void LevelTest()
        {
            // TODO unit test for the property 'Level'
        }

    }

}