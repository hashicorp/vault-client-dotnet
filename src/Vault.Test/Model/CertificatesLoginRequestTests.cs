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
    ///  Class for testing CertificatesLoginRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CertificatesLoginRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CertificatesLoginRequest
        //private CertificatesLoginRequest instance;

        public CertificatesLoginRequestTests()
        {
            // TODO uncomment below to create an instance of CertificatesLoginRequest
            //instance = new CertificatesLoginRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CertificatesLoginRequest
        /// </summary>
        [Fact]
        public void CertificatesLoginRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" CertificatesLoginRequest
            //Assert.IsType<CertificatesLoginRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

    }

}
