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
    ///  Class for testing SystemInitRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SystemInitRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SystemInitRequest
        //private SystemInitRequest instance;

        public SystemInitRequestTests()
        {
            // TODO uncomment below to create an instance of SystemInitRequest
            //instance = new SystemInitRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SystemInitRequest
        /// </summary>
        [Fact]
        public void SystemInitRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" SystemInitRequest
            //Assert.IsType<SystemInitRequest>(instance);
        }


        /// <summary>
        /// Test the property 'PgpKeys'
        /// </summary>
        [Fact]
        public void PgpKeysTest()
        {
            // TODO unit test for the property 'PgpKeys'
        }
        /// <summary>
        /// Test the property 'RecoveryPgpKeys'
        /// </summary>
        [Fact]
        public void RecoveryPgpKeysTest()
        {
            // TODO unit test for the property 'RecoveryPgpKeys'
        }
        /// <summary>
        /// Test the property 'RecoveryShares'
        /// </summary>
        [Fact]
        public void RecoverySharesTest()
        {
            // TODO unit test for the property 'RecoveryShares'
        }
        /// <summary>
        /// Test the property 'RecoveryThreshold'
        /// </summary>
        [Fact]
        public void RecoveryThresholdTest()
        {
            // TODO unit test for the property 'RecoveryThreshold'
        }
        /// <summary>
        /// Test the property 'RootTokenPgpKey'
        /// </summary>
        [Fact]
        public void RootTokenPgpKeyTest()
        {
            // TODO unit test for the property 'RootTokenPgpKey'
        }
        /// <summary>
        /// Test the property 'SecretShares'
        /// </summary>
        [Fact]
        public void SecretSharesTest()
        {
            // TODO unit test for the property 'SecretShares'
        }
        /// <summary>
        /// Test the property 'SecretThreshold'
        /// </summary>
        [Fact]
        public void SecretThresholdTest()
        {
            // TODO unit test for the property 'SecretThreshold'
        }
        /// <summary>
        /// Test the property 'StoredShares'
        /// </summary>
        [Fact]
        public void StoredSharesTest()
        {
            // TODO unit test for the property 'StoredShares'
        }

    }

}