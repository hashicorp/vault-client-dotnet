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
    ///  Class for testing WriteInternalCountersConfigRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class WriteInternalCountersConfigRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for WriteInternalCountersConfigRequest
        //private WriteInternalCountersConfigRequest instance;

        public WriteInternalCountersConfigRequestTests()
        {
            // TODO uncomment below to create an instance of WriteInternalCountersConfigRequest
            //instance = new WriteInternalCountersConfigRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WriteInternalCountersConfigRequest
        /// </summary>
        [Fact]
        public void WriteInternalCountersConfigRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" WriteInternalCountersConfigRequest
            //Assert.IsType<WriteInternalCountersConfigRequest>(instance);
        }


        /// <summary>
        /// Test the property 'DefaultReportMonths'
        /// </summary>
        [Fact]
        public void DefaultReportMonthsTest()
        {
            // TODO unit test for the property 'DefaultReportMonths'
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
        /// Test the property 'RetentionMonths'
        /// </summary>
        [Fact]
        public void RetentionMonthsTest()
        {
            // TODO unit test for the property 'RetentionMonths'
        }

    }

}
