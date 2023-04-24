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
    ///  Class for testing PkiConfigureAutoTidyRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PkiConfigureAutoTidyRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PkiConfigureAutoTidyRequest
        //private PkiConfigureAutoTidyRequest instance;

        public PkiConfigureAutoTidyRequestTests()
        {
            // TODO uncomment below to create an instance of PkiConfigureAutoTidyRequest
            //instance = new PkiConfigureAutoTidyRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PkiConfigureAutoTidyRequest
        /// </summary>
        [Fact]
        public void PkiConfigureAutoTidyRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" PkiConfigureAutoTidyRequest
            //Assert.IsType<PkiConfigureAutoTidyRequest>(instance);
        }




        /// <summary>
        /// Test the property 'Enabled'
        /// </summary>
        [Fact]
        public void EnabledTest()
        {
            // TODO unit test for the property 'Enabled'
        }

        /// <summary>
        /// Test the property 'IntervalDuration'
        /// </summary>
        [Fact]
        public void IntervalDurationTest()
        {
            // TODO unit test for the property 'IntervalDuration'
        }

        /// <summary>
        /// Test the property 'IssuerSafetyBuffer'
        /// </summary>
        [Fact]
        public void IssuerSafetyBufferTest()
        {
            // TODO unit test for the property 'IssuerSafetyBuffer'
        }

        /// <summary>
        /// Test the property 'MaintainStoredCertificateCounts'
        /// </summary>
        [Fact]
        public void MaintainStoredCertificateCountsTest()
        {
            // TODO unit test for the property 'MaintainStoredCertificateCounts'
        }

        /// <summary>
        /// Test the property 'PauseDuration'
        /// </summary>
        [Fact]
        public void PauseDurationTest()
        {
            // TODO unit test for the property 'PauseDuration'
        }

        /// <summary>
        /// Test the property 'PublishStoredCertificateCountMetrics'
        /// </summary>
        [Fact]
        public void PublishStoredCertificateCountMetricsTest()
        {
            // TODO unit test for the property 'PublishStoredCertificateCountMetrics'
        }

        /// <summary>
        /// Test the property 'RevocationQueueSafetyBuffer'
        /// </summary>
        [Fact]
        public void RevocationQueueSafetyBufferTest()
        {
            // TODO unit test for the property 'RevocationQueueSafetyBuffer'
        }

        /// <summary>
        /// Test the property 'SafetyBuffer'
        /// </summary>
        [Fact]
        public void SafetyBufferTest()
        {
            // TODO unit test for the property 'SafetyBuffer'
        }

        /// <summary>
        /// Test the property 'TidyCertStore'
        /// </summary>
        [Fact]
        public void TidyCertStoreTest()
        {
            // TODO unit test for the property 'TidyCertStore'
        }

        /// <summary>
        /// Test the property 'TidyCrossClusterRevokedCerts'
        /// </summary>
        [Fact]
        public void TidyCrossClusterRevokedCertsTest()
        {
            // TODO unit test for the property 'TidyCrossClusterRevokedCerts'
        }

        /// <summary>
        /// Test the property 'TidyExpiredIssuers'
        /// </summary>
        [Fact]
        public void TidyExpiredIssuersTest()
        {
            // TODO unit test for the property 'TidyExpiredIssuers'
        }

        /// <summary>
        /// Test the property 'TidyMoveLegacyCaBundle'
        /// </summary>
        [Fact]
        public void TidyMoveLegacyCaBundleTest()
        {
            // TODO unit test for the property 'TidyMoveLegacyCaBundle'
        }

        /// <summary>
        /// Test the property 'TidyRevocationList'
        /// </summary>
        [Fact]
        public void TidyRevocationListTest()
        {
            // TODO unit test for the property 'TidyRevocationList'
        }

        /// <summary>
        /// Test the property 'TidyRevocationQueue'
        /// </summary>
        [Fact]
        public void TidyRevocationQueueTest()
        {
            // TODO unit test for the property 'TidyRevocationQueue'
        }

        /// <summary>
        /// Test the property 'TidyRevokedCertIssuerAssociations'
        /// </summary>
        [Fact]
        public void TidyRevokedCertIssuerAssociationsTest()
        {
            // TODO unit test for the property 'TidyRevokedCertIssuerAssociations'
        }

        /// <summary>
        /// Test the property 'TidyRevokedCerts'
        /// </summary>
        [Fact]
        public void TidyRevokedCertsTest()
        {
            // TODO unit test for the property 'TidyRevokedCerts'
        }


    }

}

