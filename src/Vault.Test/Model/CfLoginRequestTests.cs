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
    ///  Class for testing CfLoginRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CfLoginRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CfLoginRequest
        //private CfLoginRequest instance;

        public CfLoginRequestTests()
        {
            // TODO uncomment below to create an instance of CfLoginRequest
            //instance = new CfLoginRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CfLoginRequest
        /// </summary>
        [Fact]
        public void CfLoginRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" CfLoginRequest
            //Assert.IsType<CfLoginRequest>(instance);
        }


        /// <summary>
        /// Test the property 'CfInstanceCert'
        /// </summary>
        [Fact]
        public void CfInstanceCertTest()
        {
            // TODO unit test for the property 'CfInstanceCert'
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
        /// Test the property 'Signature'
        /// </summary>
        [Fact]
        public void SignatureTest()
        {
            // TODO unit test for the property 'Signature'
        }
        /// <summary>
        /// Test the property 'SigningTime'
        /// </summary>
        [Fact]
        public void SigningTimeTest()
        {
            // TODO unit test for the property 'SigningTime'
        }

    }

}
