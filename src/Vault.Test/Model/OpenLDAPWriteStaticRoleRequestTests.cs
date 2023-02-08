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
    ///  Class for testing OpenLDAPWriteStaticRoleRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class OpenLDAPWriteStaticRoleRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for OpenLDAPWriteStaticRoleRequest
        //private OpenLDAPWriteStaticRoleRequest instance;

        public OpenLDAPWriteStaticRoleRequestTests()
        {
            // TODO uncomment below to create an instance of OpenLDAPWriteStaticRoleRequest
            //instance = new OpenLDAPWriteStaticRoleRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OpenLDAPWriteStaticRoleRequest
        /// </summary>
        [Fact]
        public void OpenLDAPWriteStaticRoleRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" OpenLDAPWriteStaticRoleRequest
            //Assert.IsType<OpenLDAPWriteStaticRoleRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Dn'
        /// </summary>
        [Fact]
        public void DnTest()
        {
            // TODO unit test for the property 'Dn'
        }
        /// <summary>
        /// Test the property 'RotationPeriod'
        /// </summary>
        [Fact]
        public void RotationPeriodTest()
        {
            // TODO unit test for the property 'RotationPeriod'
        }
        /// <summary>
        /// Test the property 'Username'
        /// </summary>
        [Fact]
        public void UsernameTest()
        {
            // TODO unit test for the property 'Username'
        }

    }

}
