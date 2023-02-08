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
    ///  Class for testing LDAPWriteRoleRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LDAPWriteRoleRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for LDAPWriteRoleRequest
        //private LDAPWriteRoleRequest instance;

        public LDAPWriteRoleRequestTests()
        {
            // TODO uncomment below to create an instance of LDAPWriteRoleRequest
            //instance = new LDAPWriteRoleRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LDAPWriteRoleRequest
        /// </summary>
        [Fact]
        public void LDAPWriteRoleRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" LDAPWriteRoleRequest
            //Assert.IsType<LDAPWriteRoleRequest>(instance);
        }


        /// <summary>
        /// Test the property 'CreationLdif'
        /// </summary>
        [Fact]
        public void CreationLdifTest()
        {
            // TODO unit test for the property 'CreationLdif'
        }
        /// <summary>
        /// Test the property 'DefaultTtl'
        /// </summary>
        [Fact]
        public void DefaultTtlTest()
        {
            // TODO unit test for the property 'DefaultTtl'
        }
        /// <summary>
        /// Test the property 'DeletionLdif'
        /// </summary>
        [Fact]
        public void DeletionLdifTest()
        {
            // TODO unit test for the property 'DeletionLdif'
        }
        /// <summary>
        /// Test the property 'MaxTtl'
        /// </summary>
        [Fact]
        public void MaxTtlTest()
        {
            // TODO unit test for the property 'MaxTtl'
        }
        /// <summary>
        /// Test the property 'RollbackLdif'
        /// </summary>
        [Fact]
        public void RollbackLdifTest()
        {
            // TODO unit test for the property 'RollbackLdif'
        }
        /// <summary>
        /// Test the property 'UsernameTemplate'
        /// </summary>
        [Fact]
        public void UsernameTemplateTest()
        {
            // TODO unit test for the property 'UsernameTemplate'
        }

    }

}
