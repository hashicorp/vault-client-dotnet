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
    ///  Class for testing NomadWriteRoleRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class NomadWriteRoleRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for NomadWriteRoleRequest
        //private NomadWriteRoleRequest instance;

        public NomadWriteRoleRequestTests()
        {
            // TODO uncomment below to create an instance of NomadWriteRoleRequest
            //instance = new NomadWriteRoleRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of NomadWriteRoleRequest
        /// </summary>
        [Fact]
        public void NomadWriteRoleRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" NomadWriteRoleRequest
            //Assert.IsType<NomadWriteRoleRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Global'
        /// </summary>
        [Fact]
        public void GlobalTest()
        {
            // TODO unit test for the property 'Global'
        }
        /// <summary>
        /// Test the property 'Policies'
        /// </summary>
        [Fact]
        public void PoliciesTest()
        {
            // TODO unit test for the property 'Policies'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }

    }

}