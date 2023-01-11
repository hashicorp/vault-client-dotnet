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
    ///  Class for testing OpenLDAPWriteLibraryRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class OpenLDAPWriteLibraryRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for OpenLDAPWriteLibraryRequest
        //private OpenLDAPWriteLibraryRequest instance;

        public OpenLDAPWriteLibraryRequestTests()
        {
            // TODO uncomment below to create an instance of OpenLDAPWriteLibraryRequest
            //instance = new OpenLDAPWriteLibraryRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OpenLDAPWriteLibraryRequest
        /// </summary>
        [Fact]
        public void OpenLDAPWriteLibraryRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" OpenLDAPWriteLibraryRequest
            //Assert.IsType<OpenLDAPWriteLibraryRequest>(instance);
        }


        /// <summary>
        /// Test the property 'DisableCheckInEnforcement'
        /// </summary>
        [Fact]
        public void DisableCheckInEnforcementTest()
        {
            // TODO unit test for the property 'DisableCheckInEnforcement'
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
        /// Test the property 'ServiceAccountNames'
        /// </summary>
        [Fact]
        public void ServiceAccountNamesTest()
        {
            // TODO unit test for the property 'ServiceAccountNames'
        }
        /// <summary>
        /// Test the property 'Ttl'
        /// </summary>
        [Fact]
        public void TtlTest()
        {
            // TODO unit test for the property 'Ttl'
        }

    }

}