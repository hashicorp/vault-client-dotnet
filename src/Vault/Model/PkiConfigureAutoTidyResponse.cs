// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0
//
// Code generated with OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

using System.ComponentModel.DataAnnotations;
using FileParameter = Vault.Client.FileParameter;


namespace Vault.Model
{
    /// <summary>
    /// PkiConfigureAutoTidyResponse
    /// </summary>
    [DataContract(Name = "PkiConfigureAutoTidyResponse")]
    public partial class PkiConfigureAutoTidyResponse : IEquatable<PkiConfigureAutoTidyResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PkiConfigureAutoTidyResponse" /> class.
        /// </summary>

        /// <param name="Enabled">Specifies whether automatic tidy is enabled or not.</param>

        /// <param name="IntervalDuration">Specifies the duration between automatic tidy operation.</param>

        /// <param name="IssuerSafetyBuffer">Issuer safety buffer.</param>

        /// <param name="PauseDuration">Duration to pause between tidying certificates.</param>

        /// <param name="RevocationQueueSafetyBuffer">RevocationQueueSafetyBuffer.</param>

        /// <param name="SafetyBuffer">Safety buffer time duration.</param>

        /// <param name="TidyCertStore">Specifies whether to tidy up the certificate store.</param>

        /// <param name="TidyCrossClusterRevokedCerts">TidyCrossClusterRevokedCerts.</param>

        /// <param name="TidyExpiredIssuers">Specifies whether tidy expired issuers.</param>

        /// <param name="TidyMoveLegacyCaBundle">TidyMoveLegacyCaBundle.</param>

        /// <param name="TidyRevocationQueue">TidyRevocationQueue.</param>

        /// <param name="TidyRevokedCertIssuerAssociations">Specifies whether to associate revoked certificates with their corresponding issuers.</param>

        /// <param name="TidyRevokedCerts">Specifies whether to remove all invalid and expired certificates from storage.</param>


        public PkiConfigureAutoTidyResponse(bool Enabled = default(bool), int IntervalDuration = default(int), int IssuerSafetyBuffer = default(int), string PauseDuration = default(string), int RevocationQueueSafetyBuffer = default(int), int SafetyBuffer = default(int), bool TidyCertStore = default(bool), bool TidyCrossClusterRevokedCerts = default(bool), bool TidyExpiredIssuers = default(bool), bool TidyMoveLegacyCaBundle = default(bool), bool TidyRevocationQueue = default(bool), bool TidyRevokedCertIssuerAssociations = default(bool), bool TidyRevokedCerts = default(bool))
        {

            this.Enabled = Enabled;

            this.IntervalDuration = IntervalDuration;

            this.IssuerSafetyBuffer = IssuerSafetyBuffer;

            this.PauseDuration = PauseDuration;

            this.RevocationQueueSafetyBuffer = RevocationQueueSafetyBuffer;

            this.SafetyBuffer = SafetyBuffer;

            this.TidyCertStore = TidyCertStore;

            this.TidyCrossClusterRevokedCerts = TidyCrossClusterRevokedCerts;

            this.TidyExpiredIssuers = TidyExpiredIssuers;

            this.TidyMoveLegacyCaBundle = TidyMoveLegacyCaBundle;

            this.TidyRevocationQueue = TidyRevocationQueue;

            this.TidyRevokedCertIssuerAssociations = TidyRevokedCertIssuerAssociations;

            this.TidyRevokedCerts = TidyRevokedCerts;

        }

        /// <summary>
        /// Specifies whether automatic tidy is enabled or not
        /// </summary>
        /// <value>Specifies whether automatic tidy is enabled or not</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]

        public bool Enabled { get; set; }


        /// <summary>
        /// Specifies the duration between automatic tidy operation
        /// </summary>
        /// <value>Specifies the duration between automatic tidy operation</value>
        [DataMember(Name = "interval_duration", EmitDefaultValue = false)]

        public int IntervalDuration { get; set; }


        /// <summary>
        /// Issuer safety buffer
        /// </summary>
        /// <value>Issuer safety buffer</value>
        [DataMember(Name = "issuer_safety_buffer", EmitDefaultValue = false)]

        public int IssuerSafetyBuffer { get; set; }


        /// <summary>
        /// Duration to pause between tidying certificates
        /// </summary>
        /// <value>Duration to pause between tidying certificates</value>
        [DataMember(Name = "pause_duration", EmitDefaultValue = false)]

        public string PauseDuration { get; set; }


        /// <summary>
        /// Gets or Sets RevocationQueueSafetyBuffer
        /// </summary>
        [DataMember(Name = "revocation_queue_safety_buffer", EmitDefaultValue = false)]

        public int RevocationQueueSafetyBuffer { get; set; }


        /// <summary>
        /// Safety buffer time duration
        /// </summary>
        /// <value>Safety buffer time duration</value>
        [DataMember(Name = "safety_buffer", EmitDefaultValue = false)]

        public int SafetyBuffer { get; set; }


        /// <summary>
        /// Specifies whether to tidy up the certificate store
        /// </summary>
        /// <value>Specifies whether to tidy up the certificate store</value>
        [DataMember(Name = "tidy_cert_store", EmitDefaultValue = true)]

        public bool TidyCertStore { get; set; }


        /// <summary>
        /// Gets or Sets TidyCrossClusterRevokedCerts
        /// </summary>
        [DataMember(Name = "tidy_cross_cluster_revoked_certs", EmitDefaultValue = true)]

        public bool TidyCrossClusterRevokedCerts { get; set; }


        /// <summary>
        /// Specifies whether tidy expired issuers
        /// </summary>
        /// <value>Specifies whether tidy expired issuers</value>
        [DataMember(Name = "tidy_expired_issuers", EmitDefaultValue = true)]

        public bool TidyExpiredIssuers { get; set; }


        /// <summary>
        /// Gets or Sets TidyMoveLegacyCaBundle
        /// </summary>
        [DataMember(Name = "tidy_move_legacy_ca_bundle", EmitDefaultValue = true)]

        public bool TidyMoveLegacyCaBundle { get; set; }


        /// <summary>
        /// Gets or Sets TidyRevocationQueue
        /// </summary>
        [DataMember(Name = "tidy_revocation_queue", EmitDefaultValue = true)]

        public bool TidyRevocationQueue { get; set; }


        /// <summary>
        /// Specifies whether to associate revoked certificates with their corresponding issuers
        /// </summary>
        /// <value>Specifies whether to associate revoked certificates with their corresponding issuers</value>
        [DataMember(Name = "tidy_revoked_cert_issuer_associations", EmitDefaultValue = true)]

        public bool TidyRevokedCertIssuerAssociations { get; set; }


        /// <summary>
        /// Specifies whether to remove all invalid and expired certificates from storage
        /// </summary>
        /// <value>Specifies whether to remove all invalid and expired certificates from storage</value>
        [DataMember(Name = "tidy_revoked_certs", EmitDefaultValue = true)]

        public bool TidyRevokedCerts { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiConfigureAutoTidyResponse {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  IntervalDuration: ").Append(IntervalDuration).Append("\n");
            sb.Append("  IssuerSafetyBuffer: ").Append(IssuerSafetyBuffer).Append("\n");
            sb.Append("  PauseDuration: ").Append(PauseDuration).Append("\n");
            sb.Append("  RevocationQueueSafetyBuffer: ").Append(RevocationQueueSafetyBuffer).Append("\n");
            sb.Append("  SafetyBuffer: ").Append(SafetyBuffer).Append("\n");
            sb.Append("  TidyCertStore: ").Append(TidyCertStore).Append("\n");
            sb.Append("  TidyCrossClusterRevokedCerts: ").Append(TidyCrossClusterRevokedCerts).Append("\n");
            sb.Append("  TidyExpiredIssuers: ").Append(TidyExpiredIssuers).Append("\n");
            sb.Append("  TidyMoveLegacyCaBundle: ").Append(TidyMoveLegacyCaBundle).Append("\n");
            sb.Append("  TidyRevocationQueue: ").Append(TidyRevocationQueue).Append("\n");
            sb.Append("  TidyRevokedCertIssuerAssociations: ").Append(TidyRevokedCertIssuerAssociations).Append("\n");
            sb.Append("  TidyRevokedCerts: ").Append(TidyRevokedCerts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PkiConfigureAutoTidyResponse);
        }

        /// <summary>
        /// Returns true if PkiConfigureAutoTidyResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiConfigureAutoTidyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiConfigureAutoTidyResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Enabled == input.Enabled ||

                    this.Enabled.Equals(input.Enabled)
                ) &&
                (
                    this.IntervalDuration == input.IntervalDuration ||

                    this.IntervalDuration.Equals(input.IntervalDuration)
                ) &&
                (
                    this.IssuerSafetyBuffer == input.IssuerSafetyBuffer ||

                    this.IssuerSafetyBuffer.Equals(input.IssuerSafetyBuffer)
                ) &&
                (
                    this.PauseDuration == input.PauseDuration ||
                    (this.PauseDuration != null &&
                    this.PauseDuration.Equals(input.PauseDuration))

                ) &&
                (
                    this.RevocationQueueSafetyBuffer == input.RevocationQueueSafetyBuffer ||

                    this.RevocationQueueSafetyBuffer.Equals(input.RevocationQueueSafetyBuffer)
                ) &&
                (
                    this.SafetyBuffer == input.SafetyBuffer ||

                    this.SafetyBuffer.Equals(input.SafetyBuffer)
                ) &&
                (
                    this.TidyCertStore == input.TidyCertStore ||

                    this.TidyCertStore.Equals(input.TidyCertStore)
                ) &&
                (
                    this.TidyCrossClusterRevokedCerts == input.TidyCrossClusterRevokedCerts ||

                    this.TidyCrossClusterRevokedCerts.Equals(input.TidyCrossClusterRevokedCerts)
                ) &&
                (
                    this.TidyExpiredIssuers == input.TidyExpiredIssuers ||

                    this.TidyExpiredIssuers.Equals(input.TidyExpiredIssuers)
                ) &&
                (
                    this.TidyMoveLegacyCaBundle == input.TidyMoveLegacyCaBundle ||

                    this.TidyMoveLegacyCaBundle.Equals(input.TidyMoveLegacyCaBundle)
                ) &&
                (
                    this.TidyRevocationQueue == input.TidyRevocationQueue ||

                    this.TidyRevocationQueue.Equals(input.TidyRevocationQueue)
                ) &&
                (
                    this.TidyRevokedCertIssuerAssociations == input.TidyRevokedCertIssuerAssociations ||

                    this.TidyRevokedCertIssuerAssociations.Equals(input.TidyRevokedCertIssuerAssociations)
                ) &&
                (
                    this.TidyRevokedCerts == input.TidyRevokedCerts ||

                    this.TidyRevokedCerts.Equals(input.TidyRevokedCerts)
                );

        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;


                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();

                hashCode = (hashCode * 59) + this.IntervalDuration.GetHashCode();

                hashCode = (hashCode * 59) + this.IssuerSafetyBuffer.GetHashCode();
                if (this.PauseDuration != null)
                {
                    hashCode = (hashCode * 59) + this.PauseDuration.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.RevocationQueueSafetyBuffer.GetHashCode();

                hashCode = (hashCode * 59) + this.SafetyBuffer.GetHashCode();

                hashCode = (hashCode * 59) + this.TidyCertStore.GetHashCode();

                hashCode = (hashCode * 59) + this.TidyCrossClusterRevokedCerts.GetHashCode();

                hashCode = (hashCode * 59) + this.TidyExpiredIssuers.GetHashCode();

                hashCode = (hashCode * 59) + this.TidyMoveLegacyCaBundle.GetHashCode();

                hashCode = (hashCode * 59) + this.TidyRevocationQueue.GetHashCode();

                hashCode = (hashCode * 59) + this.TidyRevokedCertIssuerAssociations.GetHashCode();

                hashCode = (hashCode * 59) + this.TidyRevokedCerts.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
