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
    ///  Class for testing AppRoleWriteCustomSecretIDRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AppRoleWriteCustomSecretIDRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AppRoleWriteCustomSecretIDRequest
        //private AppRoleWriteCustomSecretIDRequest instance;

        public AppRoleWriteCustomSecretIDRequestTests()
        {
            // TODO uncomment below to create an instance of AppRoleWriteCustomSecretIDRequest
            //instance = new AppRoleWriteCustomSecretIDRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AppRoleWriteCustomSecretIDRequest
        /// </summary>
        [Fact]
        public void AppRoleWriteCustomSecretIDRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" AppRoleWriteCustomSecretIDRequest
            //Assert.IsType<AppRoleWriteCustomSecretIDRequest>(instance);
        }


        /// <summary>
        /// Test the property 'CidrList'
        /// </summary>
        [Fact]
        public void CidrListTest()
        {
            // TODO unit test for the property 'CidrList'
        }
        /// <summary>
        /// Test the property 'Metadata'
        /// </summary>
        [Fact]
        public void MetadataTest()
        {
            // TODO unit test for the property 'Metadata'
        }
        /// <summary>
        /// Test the property 'NumUses'
        /// </summary>
        [Fact]
        public void NumUsesTest()
        {
            // TODO unit test for the property 'NumUses'
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
        /// Test the property 'TokenBoundCidrs'
        /// </summary>
        [Fact]
        public void TokenBoundCidrsTest()
        {
            // TODO unit test for the property 'TokenBoundCidrs'
        }
        /// <summary>
        /// Test the property 'Ttl'
        /// </summary>
        [Fact]
        public void TtlTest()
        {
            // TODO unit test for the property 'Ttl'
        }

    }

}
