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
    ///  Class for testing TransitGenerateRandomSourceRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TransitGenerateRandomSourceRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TransitGenerateRandomSourceRequest
        //private TransitGenerateRandomSourceRequest instance;

        public TransitGenerateRandomSourceRequestTests()
        {
            // TODO uncomment below to create an instance of TransitGenerateRandomSourceRequest
            //instance = new TransitGenerateRandomSourceRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TransitGenerateRandomSourceRequest
        /// </summary>
        [Fact]
        public void TransitGenerateRandomSourceRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" TransitGenerateRandomSourceRequest
            //Assert.IsType<TransitGenerateRandomSourceRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Bytes'
        /// </summary>
        [Fact]
        public void BytesTest()
        {
            // TODO unit test for the property 'Bytes'
        }
        /// <summary>
        /// Test the property 'Format'
        /// </summary>
        [Fact]
        public void FormatTest()
        {
            // TODO unit test for the property 'Format'
        }
        /// <summary>
        /// Test the property 'Urlbytes'
        /// </summary>
        [Fact]
        public void UrlbytesTest()
        {
            // TODO unit test for the property 'Urlbytes'
        }

    }

}
