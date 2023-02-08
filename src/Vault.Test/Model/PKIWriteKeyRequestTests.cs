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
    ///  Class for testing PKIWriteKeyRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PKIWriteKeyRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PKIWriteKeyRequest
        //private PKIWriteKeyRequest instance;

        public PKIWriteKeyRequestTests()
        {
            // TODO uncomment below to create an instance of PKIWriteKeyRequest
            //instance = new PKIWriteKeyRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PKIWriteKeyRequest
        /// </summary>
        [Fact]
        public void PKIWriteKeyRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" PKIWriteKeyRequest
            //Assert.IsType<PKIWriteKeyRequest>(instance);
        }


        /// <summary>
        /// Test the property 'KeyName'
        /// </summary>
        [Fact]
        public void KeyNameTest()
        {
            // TODO unit test for the property 'KeyName'
        }

    }

}
