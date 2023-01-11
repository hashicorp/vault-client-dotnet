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
    ///  Class for testing AWSConfigWriteIdentityRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AWSConfigWriteIdentityRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AWSConfigWriteIdentityRequest
        //private AWSConfigWriteIdentityRequest instance;

        public AWSConfigWriteIdentityRequestTests()
        {
            // TODO uncomment below to create an instance of AWSConfigWriteIdentityRequest
            //instance = new AWSConfigWriteIdentityRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AWSConfigWriteIdentityRequest
        /// </summary>
        [Fact]
        public void AWSConfigWriteIdentityRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" AWSConfigWriteIdentityRequest
            //Assert.IsType<AWSConfigWriteIdentityRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Ec2Alias'
        /// </summary>
        [Fact]
        public void Ec2AliasTest()
        {
            // TODO unit test for the property 'Ec2Alias'
        }
        /// <summary>
        /// Test the property 'Ec2Metadata'
        /// </summary>
        [Fact]
        public void Ec2MetadataTest()
        {
            // TODO unit test for the property 'Ec2Metadata'
        }
        /// <summary>
        /// Test the property 'IamAlias'
        /// </summary>
        [Fact]
        public void IamAliasTest()
        {
            // TODO unit test for the property 'IamAlias'
        }
        /// <summary>
        /// Test the property 'IamMetadata'
        /// </summary>
        [Fact]
        public void IamMetadataTest()
        {
            // TODO unit test for the property 'IamMetadata'
        }

    }

}
