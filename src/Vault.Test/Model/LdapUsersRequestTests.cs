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
    ///  Class for testing LdapUsersRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LdapUsersRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for LdapUsersRequest
        //private LdapUsersRequest instance;

        public LdapUsersRequestTests()
        {
            // TODO uncomment below to create an instance of LdapUsersRequest
            //instance = new LdapUsersRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LdapUsersRequest
        /// </summary>
        [Fact]
        public void LdapUsersRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" LdapUsersRequest
            //Assert.IsType<LdapUsersRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Groups'
        /// </summary>
        [Fact]
        public void GroupsTest()
        {
            // TODO unit test for the property 'Groups'
        }
        /// <summary>
        /// Test the property 'Policies'
        /// </summary>
        [Fact]
        public void PoliciesTest()
        {
            // TODO unit test for the property 'Policies'
        }

    }

}
