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
    ///  Class for testing IdentityMfaMethodPingidRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class IdentityMfaMethodPingidRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for IdentityMfaMethodPingidRequest
        //private IdentityMfaMethodPingidRequest instance;

        public IdentityMfaMethodPingidRequestTests()
        {
            // TODO uncomment below to create an instance of IdentityMfaMethodPingidRequest
            //instance = new IdentityMfaMethodPingidRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IdentityMfaMethodPingidRequest
        /// </summary>
        [Fact]
        public void IdentityMfaMethodPingidRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" IdentityMfaMethodPingidRequest
            //Assert.IsType<IdentityMfaMethodPingidRequest>(instance);
        }


        /// <summary>
        /// Test the property 'MethodId'
        /// </summary>
        [Fact]
        public void MethodIdTest()
        {
            // TODO unit test for the property 'MethodId'
        }
        /// <summary>
        /// Test the property 'SettingsFileBase64'
        /// </summary>
        [Fact]
        public void SettingsFileBase64Test()
        {
            // TODO unit test for the property 'SettingsFileBase64'
        }
        /// <summary>
        /// Test the property 'UsernameFormat'
        /// </summary>
        [Fact]
        public void UsernameFormatTest()
        {
            // TODO unit test for the property 'UsernameFormat'
        }

    }

}
