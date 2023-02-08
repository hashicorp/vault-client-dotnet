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
    ///  Class for testing AWSConfigWriteRoleTagDenyListRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AWSConfigWriteRoleTagDenyListRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AWSConfigWriteRoleTagDenyListRequest
        //private AWSConfigWriteRoleTagDenyListRequest instance;

        public AWSConfigWriteRoleTagDenyListRequestTests()
        {
            // TODO uncomment below to create an instance of AWSConfigWriteRoleTagDenyListRequest
            //instance = new AWSConfigWriteRoleTagDenyListRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AWSConfigWriteRoleTagDenyListRequest
        /// </summary>
        [Fact]
        public void AWSConfigWriteRoleTagDenyListRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" AWSConfigWriteRoleTagDenyListRequest
            //Assert.IsType<AWSConfigWriteRoleTagDenyListRequest>(instance);
        }


        /// <summary>
        /// Test the property 'DisablePeriodicTidy'
        /// </summary>
        [Fact]
        public void DisablePeriodicTidyTest()
        {
            // TODO unit test for the property 'DisablePeriodicTidy'
        }
        /// <summary>
        /// Test the property 'SafetyBuffer'
        /// </summary>
        [Fact]
        public void SafetyBufferTest()
        {
            // TODO unit test for the property 'SafetyBuffer'
        }

    }

}
