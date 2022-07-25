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
    ///  Class for testing IdentityMfaLoginEnforcementRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class IdentityMfaLoginEnforcementRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for IdentityMfaLoginEnforcementRequest
        //private IdentityMfaLoginEnforcementRequest instance;

        public IdentityMfaLoginEnforcementRequestTests()
        {
            // TODO uncomment below to create an instance of IdentityMfaLoginEnforcementRequest
            //instance = new IdentityMfaLoginEnforcementRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IdentityMfaLoginEnforcementRequest
        /// </summary>
        [Fact]
        public void IdentityMfaLoginEnforcementRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" IdentityMfaLoginEnforcementRequest
            //Assert.IsType<IdentityMfaLoginEnforcementRequest>(instance);
        }


        /// <summary>
        /// Test the property 'AuthMethodAccessors'
        /// </summary>
        [Fact]
        public void AuthMethodAccessorsTest()
        {
            // TODO unit test for the property 'AuthMethodAccessors'
        }
        /// <summary>
        /// Test the property 'AuthMethodTypes'
        /// </summary>
        [Fact]
        public void AuthMethodTypesTest()
        {
            // TODO unit test for the property 'AuthMethodTypes'
        }
        /// <summary>
        /// Test the property 'IdentityEntityIds'
        /// </summary>
        [Fact]
        public void IdentityEntityIdsTest()
        {
            // TODO unit test for the property 'IdentityEntityIds'
        }
        /// <summary>
        /// Test the property 'IdentityGroupIds'
        /// </summary>
        [Fact]
        public void IdentityGroupIdsTest()
        {
            // TODO unit test for the property 'IdentityGroupIds'
        }
        /// <summary>
        /// Test the property 'MfaMethodIds'
        /// </summary>
        [Fact]
        public void MfaMethodIdsTest()
        {
            // TODO unit test for the property 'MfaMethodIds'
        }

    }

}