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
    ///  Class for testing GcpRoleRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GcpRoleRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GcpRoleRequest
        //private GcpRoleRequest instance;

        public GcpRoleRequestTests()
        {
            // TODO uncomment below to create an instance of GcpRoleRequest
            //instance = new GcpRoleRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GcpRoleRequest
        /// </summary>
        [Fact]
        public void GcpRoleRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" GcpRoleRequest
            //Assert.IsType<GcpRoleRequest>(instance);
        }


        /// <summary>
        /// Test the property 'AddGroupAliases'
        /// </summary>
        [Fact]
        public void AddGroupAliasesTest()
        {
            // TODO unit test for the property 'AddGroupAliases'
        }
        /// <summary>
        /// Test the property 'AllowGceInference'
        /// </summary>
        [Fact]
        public void AllowGceInferenceTest()
        {
            // TODO unit test for the property 'AllowGceInference'
        }
        /// <summary>
        /// Test the property 'BoundInstanceGroup'
        /// </summary>
        [Fact]
        public void BoundInstanceGroupTest()
        {
            // TODO unit test for the property 'BoundInstanceGroup'
        }
        /// <summary>
        /// Test the property 'BoundInstanceGroups'
        /// </summary>
        [Fact]
        public void BoundInstanceGroupsTest()
        {
            // TODO unit test for the property 'BoundInstanceGroups'
        }
        /// <summary>
        /// Test the property 'BoundLabels'
        /// </summary>
        [Fact]
        public void BoundLabelsTest()
        {
            // TODO unit test for the property 'BoundLabels'
        }
        /// <summary>
        /// Test the property 'BoundProjects'
        /// </summary>
        [Fact]
        public void BoundProjectsTest()
        {
            // TODO unit test for the property 'BoundProjects'
        }
        /// <summary>
        /// Test the property 'BoundRegion'
        /// </summary>
        [Fact]
        public void BoundRegionTest()
        {
            // TODO unit test for the property 'BoundRegion'
        }
        /// <summary>
        /// Test the property 'BoundRegions'
        /// </summary>
        [Fact]
        public void BoundRegionsTest()
        {
            // TODO unit test for the property 'BoundRegions'
        }
        /// <summary>
        /// Test the property 'BoundServiceAccounts'
        /// </summary>
        [Fact]
        public void BoundServiceAccountsTest()
        {
            // TODO unit test for the property 'BoundServiceAccounts'
        }
        /// <summary>
        /// Test the property 'BoundZone'
        /// </summary>
        [Fact]
        public void BoundZoneTest()
        {
            // TODO unit test for the property 'BoundZone'
        }
        /// <summary>
        /// Test the property 'BoundZones'
        /// </summary>
        [Fact]
        public void BoundZonesTest()
        {
            // TODO unit test for the property 'BoundZones'
        }
        /// <summary>
        /// Test the property 'MaxJwtExp'
        /// </summary>
        [Fact]
        public void MaxJwtExpTest()
        {
            // TODO unit test for the property 'MaxJwtExp'
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
        /// Test the property 'ProjectId'
        /// </summary>
        [Fact]
        public void ProjectIdTest()
        {
            // TODO unit test for the property 'ProjectId'
        }
        /// <summary>
        /// Test the property 'ServiceAccounts'
        /// </summary>
        [Fact]
        public void ServiceAccountsTest()
        {
            // TODO unit test for the property 'ServiceAccounts'
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
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }

    }

}
