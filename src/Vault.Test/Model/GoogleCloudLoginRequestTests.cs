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
    ///  Class for testing GoogleCloudLoginRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GoogleCloudLoginRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GoogleCloudLoginRequest
        //private GoogleCloudLoginRequest instance;

        public GoogleCloudLoginRequestTests()
        {
            // TODO uncomment below to create an instance of GoogleCloudLoginRequest
            //instance = new GoogleCloudLoginRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GoogleCloudLoginRequest
        /// </summary>
        [Fact]
        public void GoogleCloudLoginRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" GoogleCloudLoginRequest
            //Assert.IsType<GoogleCloudLoginRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Jwt'
        /// </summary>
        [Fact]
        public void JwtTest()
        {
            // TODO unit test for the property 'Jwt'
        }
        /// <summary>
        /// Test the property 'Role'
        /// </summary>
        [Fact]
        public void RoleTest()
        {
            // TODO unit test for the property 'Role'
        }

    }

}
