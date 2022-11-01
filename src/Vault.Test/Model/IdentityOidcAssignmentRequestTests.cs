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
    ///  Class for testing IdentityOidcAssignmentRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class IdentityOidcAssignmentRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for IdentityOidcAssignmentRequest
        //private IdentityOidcAssignmentRequest instance;

        public IdentityOidcAssignmentRequestTests()
        {
            // TODO uncomment below to create an instance of IdentityOidcAssignmentRequest
            //instance = new IdentityOidcAssignmentRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IdentityOidcAssignmentRequest
        /// </summary>
        [Fact]
        public void IdentityOidcAssignmentRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" IdentityOidcAssignmentRequest
            //Assert.IsType<IdentityOidcAssignmentRequest>(instance);
        }


        /// <summary>
        /// Test the property 'EntityIds'
        /// </summary>
        [Fact]
        public void EntityIdsTest()
        {
            // TODO unit test for the property 'EntityIds'
        }
        /// <summary>
        /// Test the property 'GroupIds'
        /// </summary>
        [Fact]
        public void GroupIdsTest()
        {
            // TODO unit test for the property 'GroupIds'
        }

    }

}
