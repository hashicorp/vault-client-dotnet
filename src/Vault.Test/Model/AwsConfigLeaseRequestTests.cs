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
    ///  Class for testing AwsConfigLeaseRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AwsConfigLeaseRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AwsConfigLeaseRequest
        //private AwsConfigLeaseRequest instance;

        public AwsConfigLeaseRequestTests()
        {
            // TODO uncomment below to create an instance of AwsConfigLeaseRequest
            //instance = new AwsConfigLeaseRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AwsConfigLeaseRequest
        /// </summary>
        [Fact]
        public void AwsConfigLeaseRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" AwsConfigLeaseRequest
            //Assert.IsType<AwsConfigLeaseRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Lease'
        /// </summary>
        [Fact]
        public void LeaseTest()
        {
            // TODO unit test for the property 'Lease'
        }
        /// <summary>
        /// Test the property 'LeaseMax'
        /// </summary>
        [Fact]
        public void LeaseMaxTest()
        {
            // TODO unit test for the property 'LeaseMax'
        }

    }

}
