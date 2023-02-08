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
    ///  Class for testing TransitVerifyRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TransitVerifyRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TransitVerifyRequest
        //private TransitVerifyRequest instance;

        public TransitVerifyRequestTests()
        {
            // TODO uncomment below to create an instance of TransitVerifyRequest
            //instance = new TransitVerifyRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TransitVerifyRequest
        /// </summary>
        [Fact]
        public void TransitVerifyRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" TransitVerifyRequest
            //Assert.IsType<TransitVerifyRequest>(instance);
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
        /// Test the property 'Context'
        /// </summary>
        [Fact]
        public void ContextTest()
        {
            // TODO unit test for the property 'Context'
        }
        /// <summary>
        /// Test the property 'HashAlgorithm'
        /// </summary>
        [Fact]
        public void HashAlgorithmTest()
        {
            // TODO unit test for the property 'HashAlgorithm'
        }
        /// <summary>
        /// Test the property 'Hmac'
        /// </summary>
        [Fact]
        public void HmacTest()
        {
            // TODO unit test for the property 'Hmac'
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
        /// Test the property 'MarshalingAlgorithm'
        /// </summary>
        [Fact]
        public void MarshalingAlgorithmTest()
        {
            // TODO unit test for the property 'MarshalingAlgorithm'
        }
        /// <summary>
        /// Test the property 'Prehashed'
        /// </summary>
        [Fact]
        public void PrehashedTest()
        {
            // TODO unit test for the property 'Prehashed'
        }
        /// <summary>
        /// Test the property 'SaltLength'
        /// </summary>
        [Fact]
        public void SaltLengthTest()
        {
            // TODO unit test for the property 'SaltLength'
        }
        /// <summary>
        /// Test the property 'Signature'
        /// </summary>
        [Fact]
        public void SignatureTest()
        {
            // TODO unit test for the property 'Signature'
        }
        /// <summary>
        /// Test the property 'SignatureAlgorithm'
        /// </summary>
        [Fact]
        public void SignatureAlgorithmTest()
        {
            // TODO unit test for the property 'SignatureAlgorithm'
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
