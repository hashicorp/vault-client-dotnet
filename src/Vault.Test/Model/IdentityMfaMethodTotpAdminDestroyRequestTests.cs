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
    ///  Class for testing IdentityMfaMethodTotpAdminDestroyRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class IdentityMfaMethodTotpAdminDestroyRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for IdentityMfaMethodTotpAdminDestroyRequest
        //private IdentityMfaMethodTotpAdminDestroyRequest instance;

        public IdentityMfaMethodTotpAdminDestroyRequestTests()
        {
            // TODO uncomment below to create an instance of IdentityMfaMethodTotpAdminDestroyRequest
            //instance = new IdentityMfaMethodTotpAdminDestroyRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IdentityMfaMethodTotpAdminDestroyRequest
        /// </summary>
        [Fact]
        public void IdentityMfaMethodTotpAdminDestroyRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" IdentityMfaMethodTotpAdminDestroyRequest
            //Assert.IsType<IdentityMfaMethodTotpAdminDestroyRequest>(instance);
        }


        /// <summary>
        /// Test the property 'EntityId'
        /// </summary>
        [Fact]
        public void EntityIdTest()
        {
            // TODO unit test for the property 'EntityId'
        }
        /// <summary>
        /// Test the property 'MethodId'
        /// </summary>
        [Fact]
        public void MethodIdTest()
        {
            // TODO unit test for the property 'MethodId'
        }

    }

}
