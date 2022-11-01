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
    ///  Class for testing SystemUnsealRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SystemUnsealRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SystemUnsealRequest
        //private SystemUnsealRequest instance;

        public SystemUnsealRequestTests()
        {
            // TODO uncomment below to create an instance of SystemUnsealRequest
            //instance = new SystemUnsealRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SystemUnsealRequest
        /// </summary>
        [Fact]
        public void SystemUnsealRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" SystemUnsealRequest
            //Assert.IsType<SystemUnsealRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Key'
        /// </summary>
        [Fact]
        public void KeyTest()
        {
            // TODO unit test for the property 'Key'
        }
        /// <summary>
        /// Test the property 'Reset'
        /// </summary>
        [Fact]
        public void ResetTest()
        {
            // TODO unit test for the property 'Reset'
        }

    }

}
