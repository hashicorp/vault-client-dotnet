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
    ///  Class for testing SystemRotateConfigRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SystemRotateConfigRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SystemRotateConfigRequest
        //private SystemRotateConfigRequest instance;

        public SystemRotateConfigRequestTests()
        {
            // TODO uncomment below to create an instance of SystemRotateConfigRequest
            //instance = new SystemRotateConfigRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SystemRotateConfigRequest
        /// </summary>
        [Fact]
        public void SystemRotateConfigRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" SystemRotateConfigRequest
            //Assert.IsType<SystemRotateConfigRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Enabled'
        /// </summary>
        [Fact]
        public void EnabledTest()
        {
            // TODO unit test for the property 'Enabled'
        }
        /// <summary>
        /// Test the property 'Interval'
        /// </summary>
        [Fact]
        public void IntervalTest()
        {
            // TODO unit test for the property 'Interval'
        }
        /// <summary>
        /// Test the property 'MaxOperations'
        /// </summary>
        [Fact]
        public void MaxOperationsTest()
        {
            // TODO unit test for the property 'MaxOperations'
        }

    }

}
