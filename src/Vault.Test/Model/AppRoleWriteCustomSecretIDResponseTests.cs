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
    ///  Class for testing AppRoleWriteCustomSecretIDResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AppRoleWriteCustomSecretIDResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AppRoleWriteCustomSecretIDResponse
        //private AppRoleWriteCustomSecretIDResponse instance;

        public AppRoleWriteCustomSecretIDResponseTests()
        {
            // TODO uncomment below to create an instance of AppRoleWriteCustomSecretIDResponse
            //instance = new AppRoleWriteCustomSecretIDResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AppRoleWriteCustomSecretIDResponse
        /// </summary>
        [Fact]
        public void AppRoleWriteCustomSecretIDResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" AppRoleWriteCustomSecretIDResponse
            //Assert.IsType<AppRoleWriteCustomSecretIDResponse>(instance);
        }


        /// <summary>
        /// Test the property 'SecretId'
        /// </summary>
        [Fact]
        public void SecretIdTest()
        {
            // TODO unit test for the property 'SecretId'
        }
        /// <summary>
        /// Test the property 'SecretIdAccessor'
        /// </summary>
        [Fact]
        public void SecretIdAccessorTest()
        {
            // TODO unit test for the property 'SecretIdAccessor'
        }
        /// <summary>
        /// Test the property 'SecretIdNumUses'
        /// </summary>
        [Fact]
        public void SecretIdNumUsesTest()
        {
            // TODO unit test for the property 'SecretIdNumUses'
        }
        /// <summary>
        /// Test the property 'SecretIdTtl'
        /// </summary>
        [Fact]
        public void SecretIdTtlTest()
        {
            // TODO unit test for the property 'SecretIdTtl'
        }

    }

}
