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
    ///  Class for testing PkiRolesRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PkiRolesRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PkiRolesRequest
        //private PkiRolesRequest instance;

        public PkiRolesRequestTests()
        {
            // TODO uncomment below to create an instance of PkiRolesRequest
            //instance = new PkiRolesRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PkiRolesRequest
        /// </summary>
        [Fact]
        public void PkiRolesRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" PkiRolesRequest
            //Assert.IsType<PkiRolesRequest>(instance);
        }


        /// <summary>
        /// Test the property 'AllowAnyName'
        /// </summary>
        [Fact]
        public void AllowAnyNameTest()
        {
            // TODO unit test for the property 'AllowAnyName'
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
        /// Test the property 'AllowGlobDomains'
        /// </summary>
        [Fact]
        public void AllowGlobDomainsTest()
        {
            // TODO unit test for the property 'AllowGlobDomains'
        }
        /// <summary>
        /// Test the property 'AllowIpSans'
        /// </summary>
        [Fact]
        public void AllowIpSansTest()
        {
            // TODO unit test for the property 'AllowIpSans'
        }
        /// <summary>
        /// Test the property 'AllowLocalhost'
        /// </summary>
        [Fact]
        public void AllowLocalhostTest()
        {
            // TODO unit test for the property 'AllowLocalhost'
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
        /// Test the property 'AllowWildcardCertificates'
        /// </summary>
        [Fact]
        public void AllowWildcardCertificatesTest()
        {
            // TODO unit test for the property 'AllowWildcardCertificates'
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
        /// Test the property 'AllowedDomainsTemplate'
        /// </summary>
        [Fact]
        public void AllowedDomainsTemplateTest()
        {
            // TODO unit test for the property 'AllowedDomainsTemplate'
        }
        /// <summary>
        /// Test the property 'AllowedOtherSans'
        /// </summary>
        [Fact]
        public void AllowedOtherSansTest()
        {
            // TODO unit test for the property 'AllowedOtherSans'
        }
        /// <summary>
        /// Test the property 'AllowedSerialNumbers'
        /// </summary>
        [Fact]
        public void AllowedSerialNumbersTest()
        {
            // TODO unit test for the property 'AllowedSerialNumbers'
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
        /// Test the property 'AllowedUriSansTemplate'
        /// </summary>
        [Fact]
        public void AllowedUriSansTemplateTest()
        {
            // TODO unit test for the property 'AllowedUriSansTemplate'
        }
        /// <summary>
        /// Test the property 'Backend'
        /// </summary>
        [Fact]
        public void BackendTest()
        {
            // TODO unit test for the property 'Backend'
        }
        /// <summary>
        /// Test the property 'BasicConstraintsValidForNonCa'
        /// </summary>
        [Fact]
        public void BasicConstraintsValidForNonCaTest()
        {
            // TODO unit test for the property 'BasicConstraintsValidForNonCa'
        }
        /// <summary>
        /// Test the property 'ClientFlag'
        /// </summary>
        [Fact]
        public void ClientFlagTest()
        {
            // TODO unit test for the property 'ClientFlag'
        }
        /// <summary>
        /// Test the property 'CnValidations'
        /// </summary>
        [Fact]
        public void CnValidationsTest()
        {
            // TODO unit test for the property 'CnValidations'
        }
        /// <summary>
        /// Test the property 'CodeSigningFlag'
        /// </summary>
        [Fact]
        public void CodeSigningFlagTest()
        {
            // TODO unit test for the property 'CodeSigningFlag'
        }
        /// <summary>
        /// Test the property 'Country'
        /// </summary>
        [Fact]
        public void CountryTest()
        {
            // TODO unit test for the property 'Country'
        }
        /// <summary>
        /// Test the property 'EmailProtectionFlag'
        /// </summary>
        [Fact]
        public void EmailProtectionFlagTest()
        {
            // TODO unit test for the property 'EmailProtectionFlag'
        }
        /// <summary>
        /// Test the property 'EnforceHostnames'
        /// </summary>
        [Fact]
        public void EnforceHostnamesTest()
        {
            // TODO unit test for the property 'EnforceHostnames'
        }
        /// <summary>
        /// Test the property 'ExtKeyUsage'
        /// </summary>
        [Fact]
        public void ExtKeyUsageTest()
        {
            // TODO unit test for the property 'ExtKeyUsage'
        }
        /// <summary>
        /// Test the property 'ExtKeyUsageOids'
        /// </summary>
        [Fact]
        public void ExtKeyUsageOidsTest()
        {
            // TODO unit test for the property 'ExtKeyUsageOids'
        }
        /// <summary>
        /// Test the property 'GenerateLease'
        /// </summary>
        [Fact]
        public void GenerateLeaseTest()
        {
            // TODO unit test for the property 'GenerateLease'
        }
        /// <summary>
        /// Test the property 'IssuerRef'
        /// </summary>
        [Fact]
        public void IssuerRefTest()
        {
            // TODO unit test for the property 'IssuerRef'
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
        /// Test the property 'KeyType'
        /// </summary>
        [Fact]
        public void KeyTypeTest()
        {
            // TODO unit test for the property 'KeyType'
        }
        /// <summary>
        /// Test the property 'KeyUsage'
        /// </summary>
        [Fact]
        public void KeyUsageTest()
        {
            // TODO unit test for the property 'KeyUsage'
        }
        /// <summary>
        /// Test the property 'Locality'
        /// </summary>
        [Fact]
        public void LocalityTest()
        {
            // TODO unit test for the property 'Locality'
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
        /// Test the property 'NoStore'
        /// </summary>
        [Fact]
        public void NoStoreTest()
        {
            // TODO unit test for the property 'NoStore'
        }
        /// <summary>
        /// Test the property 'NotAfter'
        /// </summary>
        [Fact]
        public void NotAfterTest()
        {
            // TODO unit test for the property 'NotAfter'
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
        /// Test the property 'Organization'
        /// </summary>
        [Fact]
        public void OrganizationTest()
        {
            // TODO unit test for the property 'Organization'
        }
        /// <summary>
        /// Test the property 'Ou'
        /// </summary>
        [Fact]
        public void OuTest()
        {
            // TODO unit test for the property 'Ou'
        }
        /// <summary>
        /// Test the property 'PolicyIdentifiers'
        /// </summary>
        [Fact]
        public void PolicyIdentifiersTest()
        {
            // TODO unit test for the property 'PolicyIdentifiers'
        }
        /// <summary>
        /// Test the property 'PostalCode'
        /// </summary>
        [Fact]
        public void PostalCodeTest()
        {
            // TODO unit test for the property 'PostalCode'
        }
        /// <summary>
        /// Test the property 'Province'
        /// </summary>
        [Fact]
        public void ProvinceTest()
        {
            // TODO unit test for the property 'Province'
        }
        /// <summary>
        /// Test the property 'RequireCn'
        /// </summary>
        [Fact]
        public void RequireCnTest()
        {
            // TODO unit test for the property 'RequireCn'
        }
        /// <summary>
        /// Test the property 'ServerFlag'
        /// </summary>
        [Fact]
        public void ServerFlagTest()
        {
            // TODO unit test for the property 'ServerFlag'
        }
        /// <summary>
        /// Test the property 'SignatureBits'
        /// </summary>
        [Fact]
        public void SignatureBitsTest()
        {
            // TODO unit test for the property 'SignatureBits'
        }
        /// <summary>
        /// Test the property 'StreetAddress'
        /// </summary>
        [Fact]
        public void StreetAddressTest()
        {
            // TODO unit test for the property 'StreetAddress'
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
        /// Test the property 'UseCsrCommonName'
        /// </summary>
        [Fact]
        public void UseCsrCommonNameTest()
        {
            // TODO unit test for the property 'UseCsrCommonName'
        }
        /// <summary>
        /// Test the property 'UseCsrSans'
        /// </summary>
        [Fact]
        public void UseCsrSansTest()
        {
            // TODO unit test for the property 'UseCsrSans'
        }
        /// <summary>
        /// Test the property 'UsePss'
        /// </summary>
        [Fact]
        public void UsePssTest()
        {
            // TODO unit test for the property 'UsePss'
        }

    }

}
