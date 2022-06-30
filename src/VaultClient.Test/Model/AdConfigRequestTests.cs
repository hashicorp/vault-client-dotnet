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
    ///  Class for testing AdConfigRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AdConfigRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AdConfigRequest
        //private AdConfigRequest instance;

        public AdConfigRequestTests()
        {
            // TODO uncomment below to create an instance of AdConfigRequest
            //instance = new AdConfigRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AdConfigRequest
        /// </summary>
        [Fact]
        public void AdConfigRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" AdConfigRequest
            //Assert.IsType<AdConfigRequest>(instance);
        }


        /// <summary>
        /// Test the property 'AnonymousGroupSearch'
        /// </summary>
        [Fact]
        public void AnonymousGroupSearchTest()
        {
            // TODO unit test for the property 'AnonymousGroupSearch'
        }
        /// <summary>
        /// Test the property 'Binddn'
        /// </summary>
        [Fact]
        public void BinddnTest()
        {
            // TODO unit test for the property 'Binddn'
        }
        /// <summary>
        /// Test the property 'Bindpass'
        /// </summary>
        [Fact]
        public void BindpassTest()
        {
            // TODO unit test for the property 'Bindpass'
        }
        /// <summary>
        /// Test the property 'CaseSensitiveNames'
        /// </summary>
        [Fact]
        public void CaseSensitiveNamesTest()
        {
            // TODO unit test for the property 'CaseSensitiveNames'
        }
        /// <summary>
        /// Test the property 'Certificate'
        /// </summary>
        [Fact]
        public void CertificateTest()
        {
            // TODO unit test for the property 'Certificate'
        }
        /// <summary>
        /// Test the property 'ClientTlsCert'
        /// </summary>
        [Fact]
        public void ClientTlsCertTest()
        {
            // TODO unit test for the property 'ClientTlsCert'
        }
        /// <summary>
        /// Test the property 'ClientTlsKey'
        /// </summary>
        [Fact]
        public void ClientTlsKeyTest()
        {
            // TODO unit test for the property 'ClientTlsKey'
        }
        /// <summary>
        /// Test the property 'DenyNullBind'
        /// </summary>
        [Fact]
        public void DenyNullBindTest()
        {
            // TODO unit test for the property 'DenyNullBind'
        }
        /// <summary>
        /// Test the property 'Discoverdn'
        /// </summary>
        [Fact]
        public void DiscoverdnTest()
        {
            // TODO unit test for the property 'Discoverdn'
        }
        /// <summary>
        /// Test the property 'Formatter'
        /// </summary>
        [Fact]
        public void FormatterTest()
        {
            // TODO unit test for the property 'Formatter'
        }
        /// <summary>
        /// Test the property 'Groupattr'
        /// </summary>
        [Fact]
        public void GroupattrTest()
        {
            // TODO unit test for the property 'Groupattr'
        }
        /// <summary>
        /// Test the property 'Groupdn'
        /// </summary>
        [Fact]
        public void GroupdnTest()
        {
            // TODO unit test for the property 'Groupdn'
        }
        /// <summary>
        /// Test the property 'Groupfilter'
        /// </summary>
        [Fact]
        public void GroupfilterTest()
        {
            // TODO unit test for the property 'Groupfilter'
        }
        /// <summary>
        /// Test the property 'InsecureTls'
        /// </summary>
        [Fact]
        public void InsecureTlsTest()
        {
            // TODO unit test for the property 'InsecureTls'
        }
        /// <summary>
        /// Test the property 'LastRotationTolerance'
        /// </summary>
        [Fact]
        public void LastRotationToleranceTest()
        {
            // TODO unit test for the property 'LastRotationTolerance'
        }
        /// <summary>
        /// Test the property 'Length'
        /// </summary>
        [Fact]
        public void LengthTest()
        {
            // TODO unit test for the property 'Length'
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
        /// Test the property 'PasswordPolicy'
        /// </summary>
        [Fact]
        public void PasswordPolicyTest()
        {
            // TODO unit test for the property 'PasswordPolicy'
        }
        /// <summary>
        /// Test the property 'RequestTimeout'
        /// </summary>
        [Fact]
        public void RequestTimeoutTest()
        {
            // TODO unit test for the property 'RequestTimeout'
        }
        /// <summary>
        /// Test the property 'Starttls'
        /// </summary>
        [Fact]
        public void StarttlsTest()
        {
            // TODO unit test for the property 'Starttls'
        }
        /// <summary>
        /// Test the property 'TlsMaxVersion'
        /// </summary>
        [Fact]
        public void TlsMaxVersionTest()
        {
            // TODO unit test for the property 'TlsMaxVersion'
        }
        /// <summary>
        /// Test the property 'TlsMinVersion'
        /// </summary>
        [Fact]
        public void TlsMinVersionTest()
        {
            // TODO unit test for the property 'TlsMinVersion'
        }
        /// <summary>
        /// Test the property 'Ttl'
        /// </summary>
        [Fact]
        public void TtlTest()
        {
            // TODO unit test for the property 'Ttl'
        }
        /// <summary>
        /// Test the property 'Upndomain'
        /// </summary>
        [Fact]
        public void UpndomainTest()
        {
            // TODO unit test for the property 'Upndomain'
        }
        /// <summary>
        /// Test the property 'Url'
        /// </summary>
        [Fact]
        public void UrlTest()
        {
            // TODO unit test for the property 'Url'
        }
        /// <summary>
        /// Test the property 'UsePre111GroupCnBehavior'
        /// </summary>
        [Fact]
        public void UsePre111GroupCnBehaviorTest()
        {
            // TODO unit test for the property 'UsePre111GroupCnBehavior'
        }
        /// <summary>
        /// Test the property 'UseTokenGroups'
        /// </summary>
        [Fact]
        public void UseTokenGroupsTest()
        {
            // TODO unit test for the property 'UseTokenGroups'
        }
        /// <summary>
        /// Test the property 'Userattr'
        /// </summary>
        [Fact]
        public void UserattrTest()
        {
            // TODO unit test for the property 'Userattr'
        }
        /// <summary>
        /// Test the property 'Userdn'
        /// </summary>
        [Fact]
        public void UserdnTest()
        {
            // TODO unit test for the property 'Userdn'
        }
        /// <summary>
        /// Test the property 'Userfilter'
        /// </summary>
        [Fact]
        public void UserfilterTest()
        {
            // TODO unit test for the property 'Userfilter'
        }
        /// <summary>
        /// Test the property 'UsernameAsAlias'
        /// </summary>
        [Fact]
        public void UsernameAsAliasTest()
        {
            // TODO unit test for the property 'UsernameAsAlias'
        }

    }

}
