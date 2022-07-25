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
    ///  Class for testing RabbitmqConfigLeaseRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RabbitmqConfigLeaseRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for RabbitmqConfigLeaseRequest
        //private RabbitmqConfigLeaseRequest instance;

        public RabbitmqConfigLeaseRequestTests()
        {
            // TODO uncomment below to create an instance of RabbitmqConfigLeaseRequest
            //instance = new RabbitmqConfigLeaseRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RabbitmqConfigLeaseRequest
        /// </summary>
        [Fact]
        public void RabbitmqConfigLeaseRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" RabbitmqConfigLeaseRequest
            //Assert.IsType<RabbitmqConfigLeaseRequest>(instance);
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
        /// Test the property 'Ttl'
        /// </summary>
        [Fact]
        public void TtlTest()
        {
            // TODO unit test for the property 'Ttl'
        }

    }

}