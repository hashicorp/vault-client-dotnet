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
    ///  Class for testing PkiRootSignSelfIssuedRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PkiRootSignSelfIssuedRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PkiRootSignSelfIssuedRequest
        //private PkiRootSignSelfIssuedRequest instance;

        public PkiRootSignSelfIssuedRequestTests()
        {
            // TODO uncomment below to create an instance of PkiRootSignSelfIssuedRequest
            //instance = new PkiRootSignSelfIssuedRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PkiRootSignSelfIssuedRequest
        /// </summary>
        [Fact]
        public void PkiRootSignSelfIssuedRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" PkiRootSignSelfIssuedRequest
            //Assert.IsType<PkiRootSignSelfIssuedRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Certificate'
        /// </summary>
        [Fact]
        public void CertificateTest()
        {
            // TODO unit test for the property 'Certificate'
        }
        /// <summary>
        /// Test the property 'IssuerRef'
        /// </summary>
        [Fact]
        public void IssuerRefTest()
        {
            // TODO unit test for the property 'IssuerRef'
        }
        /// <summary>
        /// Test the property 'RequireMatchingCertificateAlgorithms'
        /// </summary>
        [Fact]
        public void RequireMatchingCertificateAlgorithmsTest()
        {
            // TODO unit test for the property 'RequireMatchingCertificateAlgorithms'
        }

    }

}
