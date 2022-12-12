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
    ///  Class for testing PkiIssuerSignRevocationListRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PkiIssuerSignRevocationListRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PkiIssuerSignRevocationListRequest
        //private PkiIssuerSignRevocationListRequest instance;

        public PkiIssuerSignRevocationListRequestTests()
        {
            // TODO uncomment below to create an instance of PkiIssuerSignRevocationListRequest
            //instance = new PkiIssuerSignRevocationListRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PkiIssuerSignRevocationListRequest
        /// </summary>
        [Fact]
        public void PkiIssuerSignRevocationListRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" PkiIssuerSignRevocationListRequest
            //Assert.IsType<PkiIssuerSignRevocationListRequest>(instance);
        }


        /// <summary>
        /// Test the property 'CrlNumber'
        /// </summary>
        [Fact]
        public void CrlNumberTest()
        {
            // TODO unit test for the property 'CrlNumber'
        }
        /// <summary>
        /// Test the property 'DeltaCrlBaseNumber'
        /// </summary>
        [Fact]
        public void DeltaCrlBaseNumberTest()
        {
            // TODO unit test for the property 'DeltaCrlBaseNumber'
        }
        /// <summary>
        /// Test the property 'Extensions'
        /// </summary>
        [Fact]
        public void ExtensionsTest()
        {
            // TODO unit test for the property 'Extensions'
        }
        /// <summary>
        /// Test the property 'Format'
        /// </summary>
        [Fact]
        public void FormatTest()
        {
            // TODO unit test for the property 'Format'
        }
        /// <summary>
        /// Test the property 'NextUpdate'
        /// </summary>
        [Fact]
        public void NextUpdateTest()
        {
            // TODO unit test for the property 'NextUpdate'
        }
        /// <summary>
        /// Test the property 'RevokedCerts'
        /// </summary>
        [Fact]
        public void RevokedCertsTest()
        {
            // TODO unit test for the property 'RevokedCerts'
        }

    }

}
