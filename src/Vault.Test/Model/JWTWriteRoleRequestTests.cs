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
    ///  Class for testing JWTWriteRoleRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class JWTWriteRoleRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for JWTWriteRoleRequest
        //private JWTWriteRoleRequest instance;

        public JWTWriteRoleRequestTests()
        {
            // TODO uncomment below to create an instance of JWTWriteRoleRequest
            //instance = new JWTWriteRoleRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of JWTWriteRoleRequest
        /// </summary>
        [Fact]
        public void JWTWriteRoleRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" JWTWriteRoleRequest
            //Assert.IsType<JWTWriteRoleRequest>(instance);
        }


        /// <summary>
        /// Test the property 'AllowedRedirectUris'
        /// </summary>
        [Fact]
        public void AllowedRedirectUrisTest()
        {
            // TODO unit test for the property 'AllowedRedirectUris'
        }
        /// <summary>
        /// Test the property 'BoundAudiences'
        /// </summary>
        [Fact]
        public void BoundAudiencesTest()
        {
            // TODO unit test for the property 'BoundAudiences'
        }
        /// <summary>
        /// Test the property 'BoundCidrs'
        /// </summary>
        [Fact]
        public void BoundCidrsTest()
        {
            // TODO unit test for the property 'BoundCidrs'
        }
        /// <summary>
        /// Test the property 'BoundClaims'
        /// </summary>
        [Fact]
        public void BoundClaimsTest()
        {
            // TODO unit test for the property 'BoundClaims'
        }
        /// <summary>
        /// Test the property 'BoundClaimsType'
        /// </summary>
        [Fact]
        public void BoundClaimsTypeTest()
        {
            // TODO unit test for the property 'BoundClaimsType'
        }
        /// <summary>
        /// Test the property 'BoundSubject'
        /// </summary>
        [Fact]
        public void BoundSubjectTest()
        {
            // TODO unit test for the property 'BoundSubject'
        }
        /// <summary>
        /// Test the property 'ClaimMappings'
        /// </summary>
        [Fact]
        public void ClaimMappingsTest()
        {
            // TODO unit test for the property 'ClaimMappings'
        }
        /// <summary>
        /// Test the property 'ClockSkewLeeway'
        /// </summary>
        [Fact]
        public void ClockSkewLeewayTest()
        {
            // TODO unit test for the property 'ClockSkewLeeway'
        }
        /// <summary>
        /// Test the property 'ExpirationLeeway'
        /// </summary>
        [Fact]
        public void ExpirationLeewayTest()
        {
            // TODO unit test for the property 'ExpirationLeeway'
        }
        /// <summary>
        /// Test the property 'GroupsClaim'
        /// </summary>
        [Fact]
        public void GroupsClaimTest()
        {
            // TODO unit test for the property 'GroupsClaim'
        }
        /// <summary>
        /// Test the property 'MaxAge'
        /// </summary>
        [Fact]
        public void MaxAgeTest()
        {
            // TODO unit test for the property 'MaxAge'
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
        /// Test the property 'NotBeforeLeeway'
        /// </summary>
        [Fact]
        public void NotBeforeLeewayTest()
        {
            // TODO unit test for the property 'NotBeforeLeeway'
        }
        /// <summary>
        /// Test the property 'NumUses'
        /// </summary>
        [Fact]
        public void NumUsesTest()
        {
            // TODO unit test for the property 'NumUses'
        }
        /// <summary>
        /// Test the property 'OidcScopes'
        /// </summary>
        [Fact]
        public void OidcScopesTest()
        {
            // TODO unit test for the property 'OidcScopes'
        }
        /// <summary>
        /// Test the property 'Period'
        /// </summary>
        [Fact]
        public void PeriodTest()
        {
            // TODO unit test for the property 'Period'
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
        /// Test the property 'RoleType'
        /// </summary>
        [Fact]
        public void RoleTypeTest()
        {
            // TODO unit test for the property 'RoleType'
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
        /// Test the property 'Ttl'
        /// </summary>
        [Fact]
        public void TtlTest()
        {
            // TODO unit test for the property 'Ttl'
        }
        /// <summary>
        /// Test the property 'UserClaim'
        /// </summary>
        [Fact]
        public void UserClaimTest()
        {
            // TODO unit test for the property 'UserClaim'
        }
        /// <summary>
        /// Test the property 'UserClaimJsonPointer'
        /// </summary>
        [Fact]
        public void UserClaimJsonPointerTest()
        {
            // TODO unit test for the property 'UserClaimJsonPointer'
        }
        /// <summary>
        /// Test the property 'VerboseOidcLogging'
        /// </summary>
        [Fact]
        public void VerboseOidcLoggingTest()
        {
            // TODO unit test for the property 'VerboseOidcLogging'
        }

    }

}
