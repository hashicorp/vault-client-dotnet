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
    ///  Class for testing TokenRenewSelfRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TokenRenewSelfRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TokenRenewSelfRequest
        //private TokenRenewSelfRequest instance;

        public TokenRenewSelfRequestTests()
        {
            // TODO uncomment below to create an instance of TokenRenewSelfRequest
            //instance = new TokenRenewSelfRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TokenRenewSelfRequest
        /// </summary>
        [Fact]
        public void TokenRenewSelfRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" TokenRenewSelfRequest
            //Assert.IsType<TokenRenewSelfRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Increment'
        /// </summary>
        [Fact]
        public void IncrementTest()
        {
            // TODO unit test for the property 'Increment'
        }
        /// <summary>
        /// Test the property 'Token'
        /// </summary>
        [Fact]
        public void TokenTest()
        {
            // TODO unit test for the property 'Token'
        }

    }

}
