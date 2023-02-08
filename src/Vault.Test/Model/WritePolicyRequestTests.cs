// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

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
    ///  Class for testing WritePolicyRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class WritePolicyRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for WritePolicyRequest
        //private WritePolicyRequest instance;

        public WritePolicyRequestTests()
        {
            // TODO uncomment below to create an instance of WritePolicyRequest
            //instance = new WritePolicyRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WritePolicyRequest
        /// </summary>
        [Fact]
        public void WritePolicyRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" WritePolicyRequest
            //Assert.IsType<WritePolicyRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Policy'
        /// </summary>
        [Fact]
        public void PolicyTest()
        {
            // TODO unit test for the property 'Policy'
        }
        /// <summary>
        /// Test the property 'Rules'
        /// </summary>
        [Fact]
        public void RulesTest()
        {
            // TODO unit test for the property 'Rules'
        }

    }

}
