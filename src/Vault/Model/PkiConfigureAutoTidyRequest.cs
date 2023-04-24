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
    /// PkiConfigureAutoTidyRequest
    /// </summary>
    [DataContract(Name = "PkiConfigureAutoTidyRequest")]
    public partial class PkiConfigureAutoTidyRequest : IEquatable<PkiConfigureAutoTidyRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PkiConfigureAutoTidyRequest" /> class.
        /// </summary>

        /// <param name="Enabled">Set to true to enable automatic tidy operations..</param>

        /// <param name="IntervalDuration">Interval at which to run an auto-tidy operation. This is the time between tidy invocations (after one finishes to the start of the next). Running a manual tidy will reset this duration. (default to 43200).</param>

        /// <param name="IssuerSafetyBuffer">The amount of extra time that must have passed beyond issuer&#x27;s expiration before it is removed from the backend storage. Defaults to 8760 hours (1 year). (default to 31536000).</param>

        /// <param name="MaintainStoredCertificateCounts">This configures whether stored certificates are counted upon initialization of the backend, and whether during normal operation, a running count of certificates stored is maintained. (default to false).</param>

        /// <param name="PauseDuration">The amount of time to wait between processing certificates. This allows operators to change the execution profile of tidy to take consume less resources by slowing down how long it takes to run. Note that the entire list of certificates will be stored in memory during the entire tidy operation, but resources to read/process/update existing entries will be spread out over a greater period of time. By default this is zero seconds. (default to &quot;0s&quot;).</param>

        /// <param name="PublishStoredCertificateCountMetrics">This configures whether the stored certificate count is published to the metrics consumer. It does not affect if the stored certificate count is maintained, and if maintained, it will be available on the tidy-status endpoint. (default to false).</param>

        /// <param name="RevocationQueueSafetyBuffer">The amount of time that must pass from the cross-cluster revocation request being initiated to when it will be slated for removal. Setting this too low may remove valid revocation requests before the owning cluster has a chance to process them, especially if the cluster is offline. (default to 172800).</param>

        /// <param name="SafetyBuffer">The amount of extra time that must have passed beyond certificate expiration before it is removed from the backend storage and/or revocation list. Defaults to 72 hours. (default to 259200).</param>

        /// <param name="TidyCertStore">Set to true to enable tidying up the certificate store.</param>

        /// <param name="TidyCrossClusterRevokedCerts">Set to true to enable tidying up the cross-cluster revoked certificate store. Only runs on the active primary node..</param>

        /// <param name="TidyExpiredIssuers">Set to true to automatically remove expired issuers past the issuer_safety_buffer. No keys will be removed as part of this operation..</param>

        /// <param name="TidyMoveLegacyCaBundle">Set to true to move the legacy ca_bundle from /config/ca_bundle to /config/ca_bundle.bak. This prevents downgrades to pre-Vault 1.11 versions (as older PKI engines do not know about the new multi-issuer storage layout), but improves the performance on seal wrapped PKI mounts. This will only occur if at least issuer_safety_buffer time has occurred after the initial storage migration. This backup is saved in case of an issue in future migrations. Operators may consider removing it via sys/raw if they desire. The backup will be removed via a DELETE /root call, but note that this removes ALL issuers within the mount (and is thus not desirable in most operational scenarios)..</param>

        /// <param name="TidyRevocationList">Deprecated; synonym for &#x27;tidy_revoked_certs.</param>

        /// <param name="TidyRevocationQueue">Set to true to remove stale revocation queue entries that haven&#x27;t been confirmed by any active cluster. Only runs on the active primary node (default to false).</param>

        /// <param name="TidyRevokedCertIssuerAssociations">Set to true to validate issuer associations on revocation entries. This helps increase the performance of CRL building and OCSP responses..</param>

        /// <param name="TidyRevokedCerts">Set to true to expire all revoked and expired certificates, removing them both from the CRL and from storage. The CRL will be rotated if this causes any values to be removed..</param>


        public PkiConfigureAutoTidyRequest(bool Enabled = default(bool), int IntervalDuration = 43200, int IssuerSafetyBuffer = 31536000, bool MaintainStoredCertificateCounts = false, string PauseDuration = "0s", bool PublishStoredCertificateCountMetrics = false, int RevocationQueueSafetyBuffer = 172800, int SafetyBuffer = 259200, bool TidyCertStore = default(bool), bool TidyCrossClusterRevokedCerts = default(bool), bool TidyExpiredIssuers = default(bool), bool TidyMoveLegacyCaBundle = default(bool), bool TidyRevocationList = default(bool), bool TidyRevocationQueue = false, bool TidyRevokedCertIssuerAssociations = default(bool), bool TidyRevokedCerts = default(bool))
        {

            this.Enabled = Enabled;

            this.IntervalDuration = IntervalDuration;

            this.IssuerSafetyBuffer = IssuerSafetyBuffer;

            this.MaintainStoredCertificateCounts = MaintainStoredCertificateCounts;

            // use default value if no "PauseDuration" provided
            this.PauseDuration = PauseDuration ?? "0s";


            this.PublishStoredCertificateCountMetrics = PublishStoredCertificateCountMetrics;

            this.RevocationQueueSafetyBuffer = RevocationQueueSafetyBuffer;

            this.SafetyBuffer = SafetyBuffer;

            this.TidyCertStore = TidyCertStore;

            this.TidyCrossClusterRevokedCerts = TidyCrossClusterRevokedCerts;

            this.TidyExpiredIssuers = TidyExpiredIssuers;

            this.TidyMoveLegacyCaBundle = TidyMoveLegacyCaBundle;

            this.TidyRevocationList = TidyRevocationList;

            this.TidyRevocationQueue = TidyRevocationQueue;

            this.TidyRevokedCertIssuerAssociations = TidyRevokedCertIssuerAssociations;

            this.TidyRevokedCerts = TidyRevokedCerts;

        }

        /// <summary>
        /// Set to true to enable automatic tidy operations.
        /// </summary>
        /// <value>Set to true to enable automatic tidy operations.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]

        public bool Enabled { get; set; }


        /// <summary>
        /// Interval at which to run an auto-tidy operation. This is the time between tidy invocations (after one finishes to the start of the next). Running a manual tidy will reset this duration.
        /// </summary>
        /// <value>Interval at which to run an auto-tidy operation. This is the time between tidy invocations (after one finishes to the start of the next). Running a manual tidy will reset this duration.</value>
        [DataMember(Name = "interval_duration", EmitDefaultValue = false)]

        public int IntervalDuration { get; set; }


        /// <summary>
        /// The amount of extra time that must have passed beyond issuer&#x27;s expiration before it is removed from the backend storage. Defaults to 8760 hours (1 year).
        /// </summary>
        /// <value>The amount of extra time that must have passed beyond issuer&#x27;s expiration before it is removed from the backend storage. Defaults to 8760 hours (1 year).</value>
        [DataMember(Name = "issuer_safety_buffer", EmitDefaultValue = false)]

        public int IssuerSafetyBuffer { get; set; }


        /// <summary>
        /// This configures whether stored certificates are counted upon initialization of the backend, and whether during normal operation, a running count of certificates stored is maintained.
        /// </summary>
        /// <value>This configures whether stored certificates are counted upon initialization of the backend, and whether during normal operation, a running count of certificates stored is maintained.</value>
        [DataMember(Name = "maintain_stored_certificate_counts", EmitDefaultValue = true)]

        public bool MaintainStoredCertificateCounts { get; set; }


        /// <summary>
        /// The amount of time to wait between processing certificates. This allows operators to change the execution profile of tidy to take consume less resources by slowing down how long it takes to run. Note that the entire list of certificates will be stored in memory during the entire tidy operation, but resources to read/process/update existing entries will be spread out over a greater period of time. By default this is zero seconds.
        /// </summary>
        /// <value>The amount of time to wait between processing certificates. This allows operators to change the execution profile of tidy to take consume less resources by slowing down how long it takes to run. Note that the entire list of certificates will be stored in memory during the entire tidy operation, but resources to read/process/update existing entries will be spread out over a greater period of time. By default this is zero seconds.</value>
        [DataMember(Name = "pause_duration", EmitDefaultValue = false)]

        public string PauseDuration { get; set; }


        /// <summary>
        /// This configures whether the stored certificate count is published to the metrics consumer. It does not affect if the stored certificate count is maintained, and if maintained, it will be available on the tidy-status endpoint.
        /// </summary>
        /// <value>This configures whether the stored certificate count is published to the metrics consumer. It does not affect if the stored certificate count is maintained, and if maintained, it will be available on the tidy-status endpoint.</value>
        [DataMember(Name = "publish_stored_certificate_count_metrics", EmitDefaultValue = true)]

        public bool PublishStoredCertificateCountMetrics { get; set; }


        /// <summary>
        /// The amount of time that must pass from the cross-cluster revocation request being initiated to when it will be slated for removal. Setting this too low may remove valid revocation requests before the owning cluster has a chance to process them, especially if the cluster is offline.
        /// </summary>
        /// <value>The amount of time that must pass from the cross-cluster revocation request being initiated to when it will be slated for removal. Setting this too low may remove valid revocation requests before the owning cluster has a chance to process them, especially if the cluster is offline.</value>
        [DataMember(Name = "revocation_queue_safety_buffer", EmitDefaultValue = false)]

        public int RevocationQueueSafetyBuffer { get; set; }


        /// <summary>
        /// The amount of extra time that must have passed beyond certificate expiration before it is removed from the backend storage and/or revocation list. Defaults to 72 hours.
        /// </summary>
        /// <value>The amount of extra time that must have passed beyond certificate expiration before it is removed from the backend storage and/or revocation list. Defaults to 72 hours.</value>
        [DataMember(Name = "safety_buffer", EmitDefaultValue = false)]

        public int SafetyBuffer { get; set; }


        /// <summary>
        /// Set to true to enable tidying up the certificate store
        /// </summary>
        /// <value>Set to true to enable tidying up the certificate store</value>
        [DataMember(Name = "tidy_cert_store", EmitDefaultValue = true)]

        public bool TidyCertStore { get; set; }


        /// <summary>
        /// Set to true to enable tidying up the cross-cluster revoked certificate store. Only runs on the active primary node.
        /// </summary>
        /// <value>Set to true to enable tidying up the cross-cluster revoked certificate store. Only runs on the active primary node.</value>
        [DataMember(Name = "tidy_cross_cluster_revoked_certs", EmitDefaultValue = true)]

        public bool TidyCrossClusterRevokedCerts { get; set; }


        /// <summary>
        /// Set to true to automatically remove expired issuers past the issuer_safety_buffer. No keys will be removed as part of this operation.
        /// </summary>
        /// <value>Set to true to automatically remove expired issuers past the issuer_safety_buffer. No keys will be removed as part of this operation.</value>
        [DataMember(Name = "tidy_expired_issuers", EmitDefaultValue = true)]

        public bool TidyExpiredIssuers { get; set; }


        /// <summary>
        /// Set to true to move the legacy ca_bundle from /config/ca_bundle to /config/ca_bundle.bak. This prevents downgrades to pre-Vault 1.11 versions (as older PKI engines do not know about the new multi-issuer storage layout), but improves the performance on seal wrapped PKI mounts. This will only occur if at least issuer_safety_buffer time has occurred after the initial storage migration. This backup is saved in case of an issue in future migrations. Operators may consider removing it via sys/raw if they desire. The backup will be removed via a DELETE /root call, but note that this removes ALL issuers within the mount (and is thus not desirable in most operational scenarios).
        /// </summary>
        /// <value>Set to true to move the legacy ca_bundle from /config/ca_bundle to /config/ca_bundle.bak. This prevents downgrades to pre-Vault 1.11 versions (as older PKI engines do not know about the new multi-issuer storage layout), but improves the performance on seal wrapped PKI mounts. This will only occur if at least issuer_safety_buffer time has occurred after the initial storage migration. This backup is saved in case of an issue in future migrations. Operators may consider removing it via sys/raw if they desire. The backup will be removed via a DELETE /root call, but note that this removes ALL issuers within the mount (and is thus not desirable in most operational scenarios).</value>
        [DataMember(Name = "tidy_move_legacy_ca_bundle", EmitDefaultValue = true)]

        public bool TidyMoveLegacyCaBundle { get; set; }


        /// <summary>
        /// Deprecated; synonym for &#x27;tidy_revoked_certs
        /// </summary>
        /// <value>Deprecated; synonym for &#x27;tidy_revoked_certs</value>
        [DataMember(Name = "tidy_revocation_list", EmitDefaultValue = true)]

        public bool TidyRevocationList { get; set; }


        /// <summary>
        /// Set to true to remove stale revocation queue entries that haven&#x27;t been confirmed by any active cluster. Only runs on the active primary node
        /// </summary>
        /// <value>Set to true to remove stale revocation queue entries that haven&#x27;t been confirmed by any active cluster. Only runs on the active primary node</value>
        [DataMember(Name = "tidy_revocation_queue", EmitDefaultValue = true)]

        public bool TidyRevocationQueue { get; set; }


        /// <summary>
        /// Set to true to validate issuer associations on revocation entries. This helps increase the performance of CRL building and OCSP responses.
        /// </summary>
        /// <value>Set to true to validate issuer associations on revocation entries. This helps increase the performance of CRL building and OCSP responses.</value>
        [DataMember(Name = "tidy_revoked_cert_issuer_associations", EmitDefaultValue = true)]

        public bool TidyRevokedCertIssuerAssociations { get; set; }


        /// <summary>
        /// Set to true to expire all revoked and expired certificates, removing them both from the CRL and from storage. The CRL will be rotated if this causes any values to be removed.
        /// </summary>
        /// <value>Set to true to expire all revoked and expired certificates, removing them both from the CRL and from storage. The CRL will be rotated if this causes any values to be removed.</value>
        [DataMember(Name = "tidy_revoked_certs", EmitDefaultValue = true)]

        public bool TidyRevokedCerts { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiConfigureAutoTidyRequest {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  IntervalDuration: ").Append(IntervalDuration).Append("\n");
            sb.Append("  IssuerSafetyBuffer: ").Append(IssuerSafetyBuffer).Append("\n");
            sb.Append("  MaintainStoredCertificateCounts: ").Append(MaintainStoredCertificateCounts).Append("\n");
            sb.Append("  PauseDuration: ").Append(PauseDuration).Append("\n");
            sb.Append("  PublishStoredCertificateCountMetrics: ").Append(PublishStoredCertificateCountMetrics).Append("\n");
            sb.Append("  RevocationQueueSafetyBuffer: ").Append(RevocationQueueSafetyBuffer).Append("\n");
            sb.Append("  SafetyBuffer: ").Append(SafetyBuffer).Append("\n");
            sb.Append("  TidyCertStore: ").Append(TidyCertStore).Append("\n");
            sb.Append("  TidyCrossClusterRevokedCerts: ").Append(TidyCrossClusterRevokedCerts).Append("\n");
            sb.Append("  TidyExpiredIssuers: ").Append(TidyExpiredIssuers).Append("\n");
            sb.Append("  TidyMoveLegacyCaBundle: ").Append(TidyMoveLegacyCaBundle).Append("\n");
            sb.Append("  TidyRevocationList: ").Append(TidyRevocationList).Append("\n");
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
            return this.Equals(input as PkiConfigureAutoTidyRequest);
        }

        /// <summary>
        /// Returns true if PkiConfigureAutoTidyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiConfigureAutoTidyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiConfigureAutoTidyRequest input)
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
                    this.MaintainStoredCertificateCounts == input.MaintainStoredCertificateCounts ||

                    this.MaintainStoredCertificateCounts.Equals(input.MaintainStoredCertificateCounts)
                ) &&
                (
                    this.PauseDuration == input.PauseDuration ||
                    (this.PauseDuration != null &&
                    this.PauseDuration.Equals(input.PauseDuration))

                ) &&
                (
                    this.PublishStoredCertificateCountMetrics == input.PublishStoredCertificateCountMetrics ||

                    this.PublishStoredCertificateCountMetrics.Equals(input.PublishStoredCertificateCountMetrics)
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
                    this.TidyRevocationList == input.TidyRevocationList ||

                    this.TidyRevocationList.Equals(input.TidyRevocationList)
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

                hashCode = (hashCode * 59) + this.MaintainStoredCertificateCounts.GetHashCode();
                if (this.PauseDuration != null)
                {
                    hashCode = (hashCode * 59) + this.PauseDuration.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.PublishStoredCertificateCountMetrics.GetHashCode();

                hashCode = (hashCode * 59) + this.RevocationQueueSafetyBuffer.GetHashCode();

                hashCode = (hashCode * 59) + this.SafetyBuffer.GetHashCode();

                hashCode = (hashCode * 59) + this.TidyCertStore.GetHashCode();

                hashCode = (hashCode * 59) + this.TidyCrossClusterRevokedCerts.GetHashCode();

                hashCode = (hashCode * 59) + this.TidyExpiredIssuers.GetHashCode();

                hashCode = (hashCode * 59) + this.TidyMoveLegacyCaBundle.GetHashCode();

                hashCode = (hashCode * 59) + this.TidyRevocationList.GetHashCode();

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
