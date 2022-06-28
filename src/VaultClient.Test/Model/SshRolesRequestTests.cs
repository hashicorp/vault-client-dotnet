/*
 * HashiCorp Vault API
 *
 * HTTP API that gives you full access to Vault. All API routes are prefixed with `/v1/`.
 *
 * The version of the OpenAPI document: 1.11.0
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
    ///  Class for testing SshRolesRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SshRolesRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SshRolesRequest
        //private SshRolesRequest instance;

        public SshRolesRequestTests()
        {
            // TODO uncomment below to create an instance of SshRolesRequest
            //instance = new SshRolesRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SshRolesRequest
        /// </summary>
        [Fact]
        public void SshRolesRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" SshRolesRequest
            //Assert.IsType<SshRolesRequest>(instance);
        }


        /// <summary>
        /// Test the property 'AdminUser'
        /// </summary>
        [Fact]
        public void AdminUserTest()
        {
            // TODO unit test for the property 'AdminUser'
        }
        /// <summary>
        /// Test the property 'AlgorithmSigner'
        /// </summary>
        [Fact]
        public void AlgorithmSignerTest()
        {
            // TODO unit test for the property 'AlgorithmSigner'
        }
        /// <summary>
        /// Test the property 'AllowBareDomains'
        /// </summary>
        [Fact]
        public void AllowBareDomainsTest()
        {
            // TODO unit test for the property 'AllowBareDomains'
        }
        /// <summary>
        /// Test the property 'AllowHostCertificates'
        /// </summary>
        [Fact]
        public void AllowHostCertificatesTest()
        {
            // TODO unit test for the property 'AllowHostCertificates'
        }
        /// <summary>
        /// Test the property 'AllowSubdomains'
        /// </summary>
        [Fact]
        public void AllowSubdomainsTest()
        {
            // TODO unit test for the property 'AllowSubdomains'
        }
        /// <summary>
        /// Test the property 'AllowUserCertificates'
        /// </summary>
        [Fact]
        public void AllowUserCertificatesTest()
        {
            // TODO unit test for the property 'AllowUserCertificates'
        }
        /// <summary>
        /// Test the property 'AllowUserKeyIds'
        /// </summary>
        [Fact]
        public void AllowUserKeyIdsTest()
        {
            // TODO unit test for the property 'AllowUserKeyIds'
        }
        /// <summary>
        /// Test the property 'AllowedCriticalOptions'
        /// </summary>
        [Fact]
        public void AllowedCriticalOptionsTest()
        {
            // TODO unit test for the property 'AllowedCriticalOptions'
        }
        /// <summary>
        /// Test the property 'AllowedDomains'
        /// </summary>
        [Fact]
        public void AllowedDomainsTest()
        {
            // TODO unit test for the property 'AllowedDomains'
        }
        /// <summary>
        /// Test the property 'AllowedExtensions'
        /// </summary>
        [Fact]
        public void AllowedExtensionsTest()
        {
            // TODO unit test for the property 'AllowedExtensions'
        }
        /// <summary>
        /// Test the property 'AllowedUserKeyLengths'
        /// </summary>
        [Fact]
        public void AllowedUserKeyLengthsTest()
        {
            // TODO unit test for the property 'AllowedUserKeyLengths'
        }
        /// <summary>
        /// Test the property 'AllowedUsers'
        /// </summary>
        [Fact]
        public void AllowedUsersTest()
        {
            // TODO unit test for the property 'AllowedUsers'
        }
        /// <summary>
        /// Test the property 'AllowedUsersTemplate'
        /// </summary>
        [Fact]
        public void AllowedUsersTemplateTest()
        {
            // TODO unit test for the property 'AllowedUsersTemplate'
        }
        /// <summary>
        /// Test the property 'CidrList'
        /// </summary>
        [Fact]
        public void CidrListTest()
        {
            // TODO unit test for the property 'CidrList'
        }
        /// <summary>
        /// Test the property 'DefaultCriticalOptions'
        /// </summary>
        [Fact]
        public void DefaultCriticalOptionsTest()
        {
            // TODO unit test for the property 'DefaultCriticalOptions'
        }
        /// <summary>
        /// Test the property 'DefaultExtensions'
        /// </summary>
        [Fact]
        public void DefaultExtensionsTest()
        {
            // TODO unit test for the property 'DefaultExtensions'
        }
        /// <summary>
        /// Test the property 'DefaultExtensionsTemplate'
        /// </summary>
        [Fact]
        public void DefaultExtensionsTemplateTest()
        {
            // TODO unit test for the property 'DefaultExtensionsTemplate'
        }
        /// <summary>
        /// Test the property 'DefaultUser'
        /// </summary>
        [Fact]
        public void DefaultUserTest()
        {
            // TODO unit test for the property 'DefaultUser'
        }
        /// <summary>
        /// Test the property 'ExcludeCidrList'
        /// </summary>
        [Fact]
        public void ExcludeCidrListTest()
        {
            // TODO unit test for the property 'ExcludeCidrList'
        }
        /// <summary>
        /// Test the property 'InstallScript'
        /// </summary>
        [Fact]
        public void InstallScriptTest()
        {
            // TODO unit test for the property 'InstallScript'
        }
        /// <summary>
        /// Test the property 'Key'
        /// </summary>
        [Fact]
        public void KeyTest()
        {
            // TODO unit test for the property 'Key'
        }
        /// <summary>
        /// Test the property 'KeyBits'
        /// </summary>
        [Fact]
        public void KeyBitsTest()
        {
            // TODO unit test for the property 'KeyBits'
        }
        /// <summary>
        /// Test the property 'KeyIdFormat'
        /// </summary>
        [Fact]
        public void KeyIdFormatTest()
        {
            // TODO unit test for the property 'KeyIdFormat'
        }
        /// <summary>
        /// Test the property 'KeyOptionSpecs'
        /// </summary>
        [Fact]
        public void KeyOptionSpecsTest()
        {
            // TODO unit test for the property 'KeyOptionSpecs'
        }
        /// <summary>
        /// Test the property 'KeyType'
        /// </summary>
        [Fact]
        public void KeyTypeTest()
        {
            // TODO unit test for the property 'KeyType'
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
        /// Test the property 'NotBeforeDuration'
        /// </summary>
        [Fact]
        public void NotBeforeDurationTest()
        {
            // TODO unit test for the property 'NotBeforeDuration'
        }
        /// <summary>
        /// Test the property 'Port'
        /// </summary>
        [Fact]
        public void PortTest()
        {
            // TODO unit test for the property 'Port'
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
