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
    ///  Class for testing LdapConfigureAuthRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LdapConfigureAuthRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for LdapConfigureAuthRequest
        //private LdapConfigureAuthRequest instance;

        public LdapConfigureAuthRequestTests()
        {
            // TODO uncomment below to create an instance of LdapConfigureAuthRequest
            //instance = new LdapConfigureAuthRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LdapConfigureAuthRequest
        /// </summary>
        [Fact]
        public void LdapConfigureAuthRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" LdapConfigureAuthRequest
            //Assert.IsType<LdapConfigureAuthRequest>(instance);
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
        /// Test the property 'ConnectionTimeout'
        /// </summary>
        [Fact]
        public void ConnectionTimeoutTest()
        {
            // TODO unit test for the property 'ConnectionTimeout'
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
        /// Test the property 'DereferenceAliases'
        /// </summary>
        [Fact]
        public void DereferenceAliasesTest()
        {
            // TODO unit test for the property 'DereferenceAliases'
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
        /// Test the property 'MaxPageSize'
        /// </summary>
        [Fact]
        public void MaxPageSizeTest()
        {
            // TODO unit test for the property 'MaxPageSize'
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
        /// Test the property 'TokenBoundCidrs'
        /// </summary>
        [Fact]
        public void TokenBoundCidrsTest()
        {
            // TODO unit test for the property 'TokenBoundCidrs'
        }

        /// <summary>
        /// Test the property 'TokenExplicitMaxTtl'
        /// </summary>
        [Fact]
        public void TokenExplicitMaxTtlTest()
        {
            // TODO unit test for the property 'TokenExplicitMaxTtl'
        }

        /// <summary>
        /// Test the property 'TokenMaxTtl'
        /// </summary>
        [Fact]
        public void TokenMaxTtlTest()
        {
            // TODO unit test for the property 'TokenMaxTtl'
        }

        /// <summary>
        /// Test the property 'TokenNoDefaultPolicy'
        /// </summary>
        [Fact]
        public void TokenNoDefaultPolicyTest()
        {
            // TODO unit test for the property 'TokenNoDefaultPolicy'
        }

        /// <summary>
        /// Test the property 'TokenNumUses'
        /// </summary>
        [Fact]
        public void TokenNumUsesTest()
        {
            // TODO unit test for the property 'TokenNumUses'
        }

        /// <summary>
        /// Test the property 'TokenPeriod'
        /// </summary>
        [Fact]
        public void TokenPeriodTest()
        {
            // TODO unit test for the property 'TokenPeriod'
        }

        /// <summary>
        /// Test the property 'TokenPolicies'
        /// </summary>
        [Fact]
        public void TokenPoliciesTest()
        {
            // TODO unit test for the property 'TokenPolicies'
        }

        /// <summary>
        /// Test the property 'TokenTtl'
        /// </summary>
        [Fact]
        public void TokenTtlTest()
        {
            // TODO unit test for the property 'TokenTtl'
        }

        /// <summary>
        /// Test the property 'TokenType'
        /// </summary>
        [Fact]
        public void TokenTypeTest()
        {
            // TODO unit test for the property 'TokenType'
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

