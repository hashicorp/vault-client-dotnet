// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

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
    ///  Class for testing CertificatesWriteRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CertificatesWriteRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CertificatesWriteRequest
        //private CertificatesWriteRequest instance;

        public CertificatesWriteRequestTests()
        {
            // TODO uncomment below to create an instance of CertificatesWriteRequest
            //instance = new CertificatesWriteRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CertificatesWriteRequest
        /// </summary>
        [Fact]
        public void CertificatesWriteRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" CertificatesWriteRequest
            //Assert.IsType<CertificatesWriteRequest>(instance);
        }


        /// <summary>
        /// Test the property 'AllowedCommonNames'
        /// </summary>
        [Fact]
        public void AllowedCommonNamesTest()
        {
            // TODO unit test for the property 'AllowedCommonNames'
        }
        /// <summary>
        /// Test the property 'AllowedDnsSans'
        /// </summary>
        [Fact]
        public void AllowedDnsSansTest()
        {
            // TODO unit test for the property 'AllowedDnsSans'
        }
        /// <summary>
        /// Test the property 'AllowedEmailSans'
        /// </summary>
        [Fact]
        public void AllowedEmailSansTest()
        {
            // TODO unit test for the property 'AllowedEmailSans'
        }
        /// <summary>
        /// Test the property 'AllowedMetadataExtensions'
        /// </summary>
        [Fact]
        public void AllowedMetadataExtensionsTest()
        {
            // TODO unit test for the property 'AllowedMetadataExtensions'
        }
        /// <summary>
        /// Test the property 'AllowedNames'
        /// </summary>
        [Fact]
        public void AllowedNamesTest()
        {
            // TODO unit test for the property 'AllowedNames'
        }
        /// <summary>
        /// Test the property 'AllowedOrganizationalUnits'
        /// </summary>
        [Fact]
        public void AllowedOrganizationalUnitsTest()
        {
            // TODO unit test for the property 'AllowedOrganizationalUnits'
        }
        /// <summary>
        /// Test the property 'AllowedUriSans'
        /// </summary>
        [Fact]
        public void AllowedUriSansTest()
        {
            // TODO unit test for the property 'AllowedUriSans'
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
        /// Test the property 'Certificate'
        /// </summary>
        [Fact]
        public void CertificateTest()
        {
            // TODO unit test for the property 'Certificate'
        }
        /// <summary>
        /// Test the property 'DisplayName'
        /// </summary>
        [Fact]
        public void DisplayNameTest()
        {
            // TODO unit test for the property 'DisplayName'
        }
        /// <summary>
        /// Test the property 'Lease'
        /// </summary>
        [Fact]
        public void LeaseTest()
        {
            // TODO unit test for the property 'Lease'
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
        /// Test the property 'OcspCaCertificates'
        /// </summary>
        [Fact]
        public void OcspCaCertificatesTest()
        {
            // TODO unit test for the property 'OcspCaCertificates'
        }
        /// <summary>
        /// Test the property 'OcspEnabled'
        /// </summary>
        [Fact]
        public void OcspEnabledTest()
        {
            // TODO unit test for the property 'OcspEnabled'
        }
        /// <summary>
        /// Test the property 'OcspFailOpen'
        /// </summary>
        [Fact]
        public void OcspFailOpenTest()
        {
            // TODO unit test for the property 'OcspFailOpen'
        }
        /// <summary>
        /// Test the property 'OcspQueryAllServers'
        /// </summary>
        [Fact]
        public void OcspQueryAllServersTest()
        {
            // TODO unit test for the property 'OcspQueryAllServers'
        }
        /// <summary>
        /// Test the property 'OcspServersOverride'
        /// </summary>
        [Fact]
        public void OcspServersOverrideTest()
        {
            // TODO unit test for the property 'OcspServersOverride'
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
        /// Test the property 'RequiredExtensions'
        /// </summary>
        [Fact]
        public void RequiredExtensionsTest()
        {
            // TODO unit test for the property 'RequiredExtensions'
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

    }

}
