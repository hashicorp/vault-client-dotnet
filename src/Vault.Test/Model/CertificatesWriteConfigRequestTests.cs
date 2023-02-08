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
    ///  Class for testing CertificatesWriteConfigRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CertificatesWriteConfigRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CertificatesWriteConfigRequest
        //private CertificatesWriteConfigRequest instance;

        public CertificatesWriteConfigRequestTests()
        {
            // TODO uncomment below to create an instance of CertificatesWriteConfigRequest
            //instance = new CertificatesWriteConfigRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CertificatesWriteConfigRequest
        /// </summary>
        [Fact]
        public void CertificatesWriteConfigRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" CertificatesWriteConfigRequest
            //Assert.IsType<CertificatesWriteConfigRequest>(instance);
        }


        /// <summary>
        /// Test the property 'DisableBinding'
        /// </summary>
        [Fact]
        public void DisableBindingTest()
        {
            // TODO unit test for the property 'DisableBinding'
        }
        /// <summary>
        /// Test the property 'EnableIdentityAliasMetadata'
        /// </summary>
        [Fact]
        public void EnableIdentityAliasMetadataTest()
        {
            // TODO unit test for the property 'EnableIdentityAliasMetadata'
        }
        /// <summary>
        /// Test the property 'OcspCacheSize'
        /// </summary>
        [Fact]
        public void OcspCacheSizeTest()
        {
            // TODO unit test for the property 'OcspCacheSize'
        }

    }

}
