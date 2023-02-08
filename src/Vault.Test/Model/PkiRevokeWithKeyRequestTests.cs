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
    ///  Class for testing PKIRevokeWithKeyRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PKIRevokeWithKeyRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PKIRevokeWithKeyRequest
        //private PKIRevokeWithKeyRequest instance;

        public PKIRevokeWithKeyRequestTests()
        {
            // TODO uncomment below to create an instance of PKIRevokeWithKeyRequest
            //instance = new PKIRevokeWithKeyRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PKIRevokeWithKeyRequest
        /// </summary>
        [Fact]
        public void PKIRevokeWithKeyRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" PKIRevokeWithKeyRequest
            //Assert.IsType<PKIRevokeWithKeyRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Certificate'
        /// </summary>
        [Fact]
        public void CertificateTest()
        {
            // TODO unit test for the property 'Certificate'
        }
        /// <summary>
        /// Test the property 'PrivateKey'
        /// </summary>
        [Fact]
        public void PrivateKeyTest()
        {
            // TODO unit test for the property 'PrivateKey'
        }
        /// <summary>
        /// Test the property 'SerialNumber'
        /// </summary>
        [Fact]
        public void SerialNumberTest()
        {
            // TODO unit test for the property 'SerialNumber'
        }

    }

}
