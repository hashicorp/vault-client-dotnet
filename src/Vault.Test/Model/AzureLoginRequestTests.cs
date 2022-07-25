/*
 * HashiCorp Vault API
 *
 * HTTP API that gives you full access to Vault. All API routes are prefixed with `/v1/`.
 *
 * The version of the OpenAPI document: 1.12.0
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
    ///  Class for testing AzureLoginRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AzureLoginRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AzureLoginRequest
        //private AzureLoginRequest instance;

        public AzureLoginRequestTests()
        {
            // TODO uncomment below to create an instance of AzureLoginRequest
            //instance = new AzureLoginRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AzureLoginRequest
        /// </summary>
        [Fact]
        public void AzureLoginRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" AzureLoginRequest
            //Assert.IsType<AzureLoginRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Jwt'
        /// </summary>
        [Fact]
        public void JwtTest()
        {
            // TODO unit test for the property 'Jwt'
        }
        /// <summary>
        /// Test the property 'ResourceGroupName'
        /// </summary>
        [Fact]
        public void ResourceGroupNameTest()
        {
            // TODO unit test for the property 'ResourceGroupName'
        }
        /// <summary>
        /// Test the property 'Role'
        /// </summary>
        [Fact]
        public void RoleTest()
        {
            // TODO unit test for the property 'Role'
        }
        /// <summary>
        /// Test the property 'SubscriptionId'
        /// </summary>
        [Fact]
        public void SubscriptionIdTest()
        {
            // TODO unit test for the property 'SubscriptionId'
        }
        /// <summary>
        /// Test the property 'VmName'
        /// </summary>
        [Fact]
        public void VmNameTest()
        {
            // TODO unit test for the property 'VmName'
        }
        /// <summary>
        /// Test the property 'VmssName'
        /// </summary>
        [Fact]
        public void VmssNameTest()
        {
            // TODO unit test for the property 'VmssName'
        }

    }

}