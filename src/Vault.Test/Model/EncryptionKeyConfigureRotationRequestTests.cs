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
    ///  Class for testing EncryptionKeyConfigureRotationRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EncryptionKeyConfigureRotationRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for EncryptionKeyConfigureRotationRequest
        //private EncryptionKeyConfigureRotationRequest instance;

        public EncryptionKeyConfigureRotationRequestTests()
        {
            // TODO uncomment below to create an instance of EncryptionKeyConfigureRotationRequest
            //instance = new EncryptionKeyConfigureRotationRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EncryptionKeyConfigureRotationRequest
        /// </summary>
        [Fact]
        public void EncryptionKeyConfigureRotationRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" EncryptionKeyConfigureRotationRequest
            //Assert.IsType<EncryptionKeyConfigureRotationRequest>(instance);
        }




        /// <summary>
        /// Test the property 'Enabled'
        /// </summary>
        [Fact]
        public void EnabledTest()
        {
            // TODO unit test for the property 'Enabled'
        }

        /// <summary>
        /// Test the property 'Interval'
        /// </summary>
        [Fact]
        public void IntervalTest()
        {
            // TODO unit test for the property 'Interval'
        }

        /// <summary>
        /// Test the property 'MaxOperations'
        /// </summary>
        [Fact]
        public void MaxOperationsTest()
        {
            // TODO unit test for the property 'MaxOperations'
        }


    }

}


