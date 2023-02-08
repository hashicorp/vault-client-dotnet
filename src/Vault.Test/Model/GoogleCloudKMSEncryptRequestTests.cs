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
    ///  Class for testing GoogleCloudKMSEncryptRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GoogleCloudKMSEncryptRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GoogleCloudKMSEncryptRequest
        //private GoogleCloudKMSEncryptRequest instance;

        public GoogleCloudKMSEncryptRequestTests()
        {
            // TODO uncomment below to create an instance of GoogleCloudKMSEncryptRequest
            //instance = new GoogleCloudKMSEncryptRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GoogleCloudKMSEncryptRequest
        /// </summary>
        [Fact]
        public void GoogleCloudKMSEncryptRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" GoogleCloudKMSEncryptRequest
            //Assert.IsType<GoogleCloudKMSEncryptRequest>(instance);
        }


        /// <summary>
        /// Test the property 'AdditionalAuthenticatedData'
        /// </summary>
        [Fact]
        public void AdditionalAuthenticatedDataTest()
        {
            // TODO unit test for the property 'AdditionalAuthenticatedData'
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
        /// Test the property 'Plaintext'
        /// </summary>
        [Fact]
        public void PlaintextTest()
        {
            // TODO unit test for the property 'Plaintext'
        }

    }

}
