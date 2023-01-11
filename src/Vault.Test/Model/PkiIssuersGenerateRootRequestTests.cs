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
    ///  Class for testing PKIIssuersGenerateRootRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PKIIssuersGenerateRootRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PKIIssuersGenerateRootRequest
        //private PKIIssuersGenerateRootRequest instance;

        public PKIIssuersGenerateRootRequestTests()
        {
            // TODO uncomment below to create an instance of PKIIssuersGenerateRootRequest
            //instance = new PKIIssuersGenerateRootRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PKIIssuersGenerateRootRequest
        /// </summary>
        [Fact]
        public void PKIIssuersGenerateRootRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" PKIIssuersGenerateRootRequest
            //Assert.IsType<PKIIssuersGenerateRootRequest>(instance);
        }


        /// <summary>
        /// Test the property 'AltNames'
        /// </summary>
        [Fact]
        public void AltNamesTest()
        {
            // TODO unit test for the property 'AltNames'
        }
        /// <summary>
        /// Test the property 'CommonName'
        /// </summary>
        [Fact]
        public void CommonNameTest()
        {
            // TODO unit test for the property 'CommonName'
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
        /// Test the property 'ExcludeCnFromSans'
        /// </summary>
        [Fact]
        public void ExcludeCnFromSansTest()
        {
            // TODO unit test for the property 'ExcludeCnFromSans'
        }
        /// <summary>
        /// Test the property 'Format'
        /// </summary>
        [Fact]
        public void FormatTest()
        {
            // TODO unit test for the property 'Format'
        }
        /// <summary>
        /// Test the property 'IpSans'
        /// </summary>
        [Fact]
        public void IpSansTest()
        {
            // TODO unit test for the property 'IpSans'
        }
        /// <summary>
        /// Test the property 'IssuerName'
        /// </summary>
        [Fact]
        public void IssuerNameTest()
        {
            // TODO unit test for the property 'IssuerName'
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
        /// Test the property 'KeyName'
        /// </summary>
        [Fact]
        public void KeyNameTest()
        {
            // TODO unit test for the property 'KeyName'
        }
        /// <summary>
        /// Test the property 'KeyRef'
        /// </summary>
        [Fact]
        public void KeyRefTest()
        {
            // TODO unit test for the property 'KeyRef'
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
        /// Test the property 'Locality'
        /// </summary>
        [Fact]
        public void LocalityTest()
        {
            // TODO unit test for the property 'Locality'
        }
        /// <summary>
        /// Test the property 'ManagedKeyId'
        /// </summary>
        [Fact]
        public void ManagedKeyIdTest()
        {
            // TODO unit test for the property 'ManagedKeyId'
        }
        /// <summary>
        /// Test the property 'ManagedKeyName'
        /// </summary>
        [Fact]
        public void ManagedKeyNameTest()
        {
            // TODO unit test for the property 'ManagedKeyName'
        }
        /// <summary>
        /// Test the property 'MaxPathLength'
        /// </summary>
        [Fact]
        public void MaxPathLengthTest()
        {
            // TODO unit test for the property 'MaxPathLength'
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
        /// Test the property 'OtherSans'
        /// </summary>
        [Fact]
        public void OtherSansTest()
        {
            // TODO unit test for the property 'OtherSans'
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
        /// Test the property 'PermittedDnsDomains'
        /// </summary>
        [Fact]
        public void PermittedDnsDomainsTest()
        {
            // TODO unit test for the property 'PermittedDnsDomains'
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
        /// Test the property 'PrivateKeyFormat'
        /// </summary>
        [Fact]
        public void PrivateKeyFormatTest()
        {
            // TODO unit test for the property 'PrivateKeyFormat'
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
        /// Test the property 'SerialNumber'
        /// </summary>
        [Fact]
        public void SerialNumberTest()
        {
            // TODO unit test for the property 'SerialNumber'
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
        /// Test the property 'UriSans'
        /// </summary>
        [Fact]
        public void UriSansTest()
        {
            // TODO unit test for the property 'UriSans'
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
