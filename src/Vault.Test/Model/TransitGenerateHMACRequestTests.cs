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
    ///  Class for testing TransitGenerateHMACRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TransitGenerateHMACRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TransitGenerateHMACRequest
        //private TransitGenerateHMACRequest instance;

        public TransitGenerateHMACRequestTests()
        {
            // TODO uncomment below to create an instance of TransitGenerateHMACRequest
            //instance = new TransitGenerateHMACRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TransitGenerateHMACRequest
        /// </summary>
        [Fact]
        public void TransitGenerateHMACRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" TransitGenerateHMACRequest
            //Assert.IsType<TransitGenerateHMACRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Algorithm'
        /// </summary>
        [Fact]
        public void AlgorithmTest()
        {
            // TODO unit test for the property 'Algorithm'
        }
        /// <summary>
        /// Test the property 'Input'
        /// </summary>
        [Fact]
        public void InputTest()
        {
            // TODO unit test for the property 'Input'
        }
        /// <summary>
        /// Test the property 'KeyVersion'
        /// </summary>
        [Fact]
        public void KeyVersionTest()
        {
            // TODO unit test for the property 'KeyVersion'
        }
        /// <summary>
        /// Test the property 'Urlalgorithm'
        /// </summary>
        [Fact]
        public void UrlalgorithmTest()
        {
            // TODO unit test for the property 'Urlalgorithm'
        }

    }

}
