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
    ///  Class for testing TransitRestoreRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TransitRestoreRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TransitRestoreRequest
        //private TransitRestoreRequest instance;

        public TransitRestoreRequestTests()
        {
            // TODO uncomment below to create an instance of TransitRestoreRequest
            //instance = new TransitRestoreRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TransitRestoreRequest
        /// </summary>
        [Fact]
        public void TransitRestoreRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" TransitRestoreRequest
            //Assert.IsType<TransitRestoreRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Backup'
        /// </summary>
        [Fact]
        public void BackupTest()
        {
            // TODO unit test for the property 'Backup'
        }
        /// <summary>
        /// Test the property 'Force'
        /// </summary>
        [Fact]
        public void ForceTest()
        {
            // TODO unit test for the property 'Force'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

    }

}
