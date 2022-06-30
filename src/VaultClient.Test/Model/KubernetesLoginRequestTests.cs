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
using VaultClient.Api;
using VaultClient.Model;
using VaultClient.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace VaultClient.Test.Model
{
    /// <summary>
    ///  Class for testing KubernetesLoginRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class KubernetesLoginRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for KubernetesLoginRequest
        //private KubernetesLoginRequest instance;

        public KubernetesLoginRequestTests()
        {
            // TODO uncomment below to create an instance of KubernetesLoginRequest
            //instance = new KubernetesLoginRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of KubernetesLoginRequest
        /// </summary>
        [Fact]
        public void KubernetesLoginRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" KubernetesLoginRequest
            //Assert.IsType<KubernetesLoginRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Jwt'
        /// </summary>
        [Fact]
        public void JwtTest()
        {
            // TODO unit test for the property 'Jwt'
        }
        /// <summary>
        /// Test the property 'Role'
        /// </summary>
        [Fact]
        public void RoleTest()
        {
            // TODO unit test for the property 'Role'
        }

    }

}
