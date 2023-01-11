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
    ///  Class for testing TransitGenerateHMACWithAlgorithmRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TransitGenerateHMACWithAlgorithmRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TransitGenerateHMACWithAlgorithmRequest
        //private TransitGenerateHMACWithAlgorithmRequest instance;

        public TransitGenerateHMACWithAlgorithmRequestTests()
        {
            // TODO uncomment below to create an instance of TransitGenerateHMACWithAlgorithmRequest
            //instance = new TransitGenerateHMACWithAlgorithmRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TransitGenerateHMACWithAlgorithmRequest
        /// </summary>
        [Fact]
        public void TransitGenerateHMACWithAlgorithmRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" TransitGenerateHMACWithAlgorithmRequest
            //Assert.IsType<TransitGenerateHMACWithAlgorithmRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Algorithm'
        /// </summary>
        [Fact]
        public void AlgorithmTest()
        {
            // TODO unit test for the property 'Algorithm'
        }
        /// <summary>
        /// Test the property 'Input'
        /// </summary>
        [Fact]
        public void InputTest()
        {
            // TODO unit test for the property 'Input'
        }
        /// <summary>
        /// Test the property 'KeyVersion'
        /// </summary>
        [Fact]
        public void KeyVersionTest()
        {
            // TODO unit test for the property 'KeyVersion'
        }

    }

}
