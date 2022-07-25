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
    ///  Class for testing SshLookupRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SshLookupRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SshLookupRequest
        //private SshLookupRequest instance;

        public SshLookupRequestTests()
        {
            // TODO uncomment below to create an instance of SshLookupRequest
            //instance = new SshLookupRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SshLookupRequest
        /// </summary>
        [Fact]
        public void SshLookupRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" SshLookupRequest
            //Assert.IsType<SshLookupRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Ip'
        /// </summary>
        [Fact]
        public void IpTest()
        {
            // TODO unit test for the property 'Ip'
        }

    }

}