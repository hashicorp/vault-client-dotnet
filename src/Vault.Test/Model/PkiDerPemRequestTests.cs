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
    ///  Class for testing PkiDerPemRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PkiDerPemRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PkiDerPemRequest
        //private PkiDerPemRequest instance;

        public PkiDerPemRequestTests()
        {
            // TODO uncomment below to create an instance of PkiDerPemRequest
            //instance = new PkiDerPemRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PkiDerPemRequest
        /// </summary>
        [Fact]
        public void PkiDerPemRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" PkiDerPemRequest
            //Assert.IsType<PkiDerPemRequest>(instance);
        }


        /// <summary>
        /// Test the property 'IssuerName'
        /// </summary>
        [Fact]
        public void IssuerNameTest()
        {
            // TODO unit test for the property 'IssuerName'
        }
        /// <summary>
        /// Test the property 'LeafNotAfterBehavior'
        /// </summary>
        [Fact]
        public void LeafNotAfterBehaviorTest()
        {
            // TODO unit test for the property 'LeafNotAfterBehavior'
        }
        /// <summary>
        /// Test the property 'ManualChain'
        /// </summary>
        [Fact]
        public void ManualChainTest()
        {
            // TODO unit test for the property 'ManualChain'
        }
        /// <summary>
        /// Test the property 'Usage'
        /// </summary>
        [Fact]
        public void UsageTest()
        {
            // TODO unit test for the property 'Usage'
        }

    }

}