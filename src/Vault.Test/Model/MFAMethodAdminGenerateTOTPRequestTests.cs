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
    ///  Class for testing MFAMethodAdminGenerateTOTPRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MFAMethodAdminGenerateTOTPRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MFAMethodAdminGenerateTOTPRequest
        //private MFAMethodAdminGenerateTOTPRequest instance;

        public MFAMethodAdminGenerateTOTPRequestTests()
        {
            // TODO uncomment below to create an instance of MFAMethodAdminGenerateTOTPRequest
            //instance = new MFAMethodAdminGenerateTOTPRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MFAMethodAdminGenerateTOTPRequest
        /// </summary>
        [Fact]
        public void MFAMethodAdminGenerateTOTPRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" MFAMethodAdminGenerateTOTPRequest
            //Assert.IsType<MFAMethodAdminGenerateTOTPRequest>(instance);
        }


        /// <summary>
        /// Test the property 'EntityId'
        /// </summary>
        [Fact]
        public void EntityIdTest()
        {
            // TODO unit test for the property 'EntityId'
        }
        /// <summary>
        /// Test the property 'MethodId'
        /// </summary>
        [Fact]
        public void MethodIdTest()
        {
            // TODO unit test for the property 'MethodId'
        }

    }

}