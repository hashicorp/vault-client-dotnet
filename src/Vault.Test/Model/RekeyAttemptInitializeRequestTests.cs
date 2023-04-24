// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0
//
// Code generated with OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

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
    ///  Class for testing RekeyAttemptInitializeRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RekeyAttemptInitializeRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for RekeyAttemptInitializeRequest
        //private RekeyAttemptInitializeRequest instance;

        public RekeyAttemptInitializeRequestTests()
        {
            // TODO uncomment below to create an instance of RekeyAttemptInitializeRequest
            //instance = new RekeyAttemptInitializeRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RekeyAttemptInitializeRequest
        /// </summary>
        [Fact]
        public void RekeyAttemptInitializeRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" RekeyAttemptInitializeRequest
            //Assert.IsType<RekeyAttemptInitializeRequest>(instance);
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

