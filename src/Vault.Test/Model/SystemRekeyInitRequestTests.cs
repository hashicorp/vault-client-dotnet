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
    ///  Class for testing SystemRekeyInitRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SystemRekeyInitRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SystemRekeyInitRequest
        //private SystemRekeyInitRequest instance;

        public SystemRekeyInitRequestTests()
        {
            // TODO uncomment below to create an instance of SystemRekeyInitRequest
            //instance = new SystemRekeyInitRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SystemRekeyInitRequest
        /// </summary>
        [Fact]
        public void SystemRekeyInitRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" SystemRekeyInitRequest
            //Assert.IsType<SystemRekeyInitRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Backup'
        /// </summary>
        [Fact]
        public void BackupTest()
        {
            // TODO unit test for the property 'Backup'
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
        /// Test the property 'RequireVerification'
        /// </summary>
        [Fact]
        public void RequireVerificationTest()
        {
            // TODO unit test for the property 'RequireVerification'
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

    }

}
