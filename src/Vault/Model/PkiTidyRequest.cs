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
    /// PkiTidyRequest
    /// </summary>
    [DataContract(Name = "PkiTidyRequest")]
    public partial class PkiTidyRequest : IEquatable<PkiTidyRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PkiTidyRequest" /> class.
        /// </summary>

        /// <param name="AcmeAccountSafetyBuffer">The amount of time that must pass after creation that an account with no orders is marked revoked, and the amount of time after being marked revoked or deactivated. (default to &quot;2592000&quot;).</param>

        /// <param name="IssuerSafetyBuffer">The amount of extra time that must have passed beyond issuer&#x27;s expiration before it is removed from the backend storage. Defaults to 8760 hours (1 year). (default to &quot;31536000&quot;).</param>

        /// <param name="PauseDuration">The amount of time to wait between processing certificates. This allows operators to change the execution profile of tidy to take consume less resources by slowing down how long it takes to run. Note that the entire list of certificates will be stored in memory during the entire tidy operation, but resources to read/process/update existing entries will be spread out over a greater period of time. By default this is zero seconds. (default to &quot;0s&quot;).</param>

        /// <param name="RevocationQueueSafetyBuffer">The amount of time that must pass from the cross-cluster revocation request being initiated to when it will be slated for removal. Setting this too low may remove valid revocation requests before the owning cluster has a chance to process them, especially if the cluster is offline. (default to &quot;172800&quot;).</param>

        /// <param name="SafetyBuffer">The amount of extra time that must have passed beyond certificate expiration before it is removed from the backend storage and/or revocation list. Defaults to 72 hours. (default to &quot;259200&quot;).</param>

        /// <param name="TidyAcme">Set to true to enable tidying ACME accounts, orders and authorizations. ACME orders are tidied (deleted) safety_buffer after the certificate associated with them expires, or after the order and relevant authorizations have expired if no certificate was produced. Authorizations are tidied with the corresponding order. When a valid ACME Account is at least acme_account_safety_buffer old, and has no remaining orders associated with it, the account is marked as revoked. After another acme_account_safety_buffer has passed from the revocation or deactivation date, a revoked or deactivated ACME account is deleted. (default to false).</param>

        /// <param name="TidyCertStore">Set to true to enable tidying up the certificate store.</param>

        /// <param name="TidyCrossClusterRevokedCerts">Set to true to enable tidying up the cross-cluster revoked certificate store. Only runs on the active primary node..</param>

        /// <param name="TidyExpiredIssuers">Set to true to automatically remove expired issuers past the issuer_safety_buffer. No keys will be removed as part of this operation..</param>

        /// <param name="TidyMoveLegacyCaBundle">Set to true to move the legacy ca_bundle from /config/ca_bundle to /config/ca_bundle.bak. This prevents downgrades to pre-Vault 1.11 versions (as older PKI engines do not know about the new multi-issuer storage layout), but improves the performance on seal wrapped PKI mounts. This will only occur if at least issuer_safety_buffer time has occurred after the initial storage migration. This backup is saved in case of an issue in future migrations. Operators may consider removing it via sys/raw if they desire. The backup will be removed via a DELETE /root call, but note that this removes ALL issuers within the mount (and is thus not desirable in most operational scenarios)..</param>

        /// <param name="TidyRevocationList">Deprecated; synonym for &#x27;tidy_revoked_certs.</param>

        /// <param name="TidyRevocationQueue">Set to true to remove stale revocation queue entries that haven&#x27;t been confirmed by any active cluster. Only runs on the active primary node (default to false).</param>

        /// <param name="TidyRevokedCertIssuerAssociations">Set to true to validate issuer associations on revocation entries. This helps increase the performance of CRL building and OCSP responses..</param>

        /// <param name="TidyRevokedCerts">Set to true to expire all revoked and expired certificates, removing them both from the CRL and from storage. The CRL will be rotated if this causes any values to be removed..</param>


        public PkiTidyRequest(string AcmeAccountSafetyBuffer = "2592000", string IssuerSafetyBuffer = "31536000", string PauseDuration = "0s", string RevocationQueueSafetyBuffer = "172800", string SafetyBuffer = "259200", bool TidyAcme = false, bool TidyCertStore = default(bool), bool TidyCrossClusterRevokedCerts = default(bool), bool TidyExpiredIssuers = default(bool), bool TidyMoveLegacyCaBundle = default(bool), bool TidyRevocationList = default(bool), bool TidyRevocationQueue = false, bool TidyRevokedCertIssuerAssociations = default(bool), bool TidyRevokedCerts = default(bool))
        {

            // use default value if no "AcmeAccountSafetyBuffer" provided
            this.AcmeAccountSafetyBuffer = AcmeAccountSafetyBuffer ?? "2592000";


            // use default value if no "IssuerSafetyBuffer" provided
            this.IssuerSafetyBuffer = IssuerSafetyBuffer ?? "31536000";


            // use default value if no "PauseDuration" provided
            this.PauseDuration = PauseDuration ?? "0s";


            // use default value if no "RevocationQueueSafetyBuffer" provided
            this.RevocationQueueSafetyBuffer = RevocationQueueSafetyBuffer ?? "172800";


            // use default value if no "SafetyBuffer" provided
            this.SafetyBuffer = SafetyBuffer ?? "259200";


            this.TidyAcme = TidyAcme;

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
        /// The amount of time that must pass after creation that an account with no orders is marked revoked, and the amount of time after being marked revoked or deactivated.
        /// </summary>
        /// <value>The amount of time that must pass after creation that an account with no orders is marked revoked, and the amount of time after being marked revoked or deactivated.</value>
        [DataMember(Name = "acme_account_safety_buffer", EmitDefaultValue = false)]

        public string AcmeAccountSafetyBuffer { get; set; }


        /// <summary>
        /// The amount of extra time that must have passed beyond issuer&#x27;s expiration before it is removed from the backend storage. Defaults to 8760 hours (1 year).
        /// </summary>
        /// <value>The amount of extra time that must have passed beyond issuer&#x27;s expiration before it is removed from the backend storage. Defaults to 8760 hours (1 year).</value>
        [DataMember(Name = "issuer_safety_buffer", EmitDefaultValue = false)]

        public string IssuerSafetyBuffer { get; set; }


        /// <summary>
        /// The amount of time to wait between processing certificates. This allows operators to change the execution profile of tidy to take consume less resources by slowing down how long it takes to run. Note that the entire list of certificates will be stored in memory during the entire tidy operation, but resources to read/process/update existing entries will be spread out over a greater period of time. By default this is zero seconds.
        /// </summary>
        /// <value>The amount of time to wait between processing certificates. This allows operators to change the execution profile of tidy to take consume less resources by slowing down how long it takes to run. Note that the entire list of certificates will be stored in memory during the entire tidy operation, but resources to read/process/update existing entries will be spread out over a greater period of time. By default this is zero seconds.</value>
        [DataMember(Name = "pause_duration", EmitDefaultValue = false)]

        public string PauseDuration { get; set; }


        /// <summary>
        /// The amount of time that must pass from the cross-cluster revocation request being initiated to when it will be slated for removal. Setting this too low may remove valid revocation requests before the owning cluster has a chance to process them, especially if the cluster is offline.
        /// </summary>
        /// <value>The amount of time that must pass from the cross-cluster revocation request being initiated to when it will be slated for removal. Setting this too low may remove valid revocation requests before the owning cluster has a chance to process them, especially if the cluster is offline.</value>
        [DataMember(Name = "revocation_queue_safety_buffer", EmitDefaultValue = false)]

        public string RevocationQueueSafetyBuffer { get; set; }


        /// <summary>
        /// The amount of extra time that must have passed beyond certificate expiration before it is removed from the backend storage and/or revocation list. Defaults to 72 hours.
        /// </summary>
        /// <value>The amount of extra time that must have passed beyond certificate expiration before it is removed from the backend storage and/or revocation list. Defaults to 72 hours.</value>
        [DataMember(Name = "safety_buffer", EmitDefaultValue = false)]

        public string SafetyBuffer { get; set; }


        /// <summary>
        /// Set to true to enable tidying ACME accounts, orders and authorizations. ACME orders are tidied (deleted) safety_buffer after the certificate associated with them expires, or after the order and relevant authorizations have expired if no certificate was produced. Authorizations are tidied with the corresponding order. When a valid ACME Account is at least acme_account_safety_buffer old, and has no remaining orders associated with it, the account is marked as revoked. After another acme_account_safety_buffer has passed from the revocation or deactivation date, a revoked or deactivated ACME account is deleted.
        /// </summary>
        /// <value>Set to true to enable tidying ACME accounts, orders and authorizations. ACME orders are tidied (deleted) safety_buffer after the certificate associated with them expires, or after the order and relevant authorizations have expired if no certificate was produced. Authorizations are tidied with the corresponding order. When a valid ACME Account is at least acme_account_safety_buffer old, and has no remaining orders associated with it, the account is marked as revoked. After another acme_account_safety_buffer has passed from the revocation or deactivation date, a revoked or deactivated ACME account is deleted.</value>
        [DataMember(Name = "tidy_acme", EmitDefaultValue = true)]

        public bool TidyAcme { get; set; }


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
            sb.Append("class PkiTidyRequest {\n");
            sb.Append("  AcmeAccountSafetyBuffer: ").Append(AcmeAccountSafetyBuffer).Append("\n");
            sb.Append("  IssuerSafetyBuffer: ").Append(IssuerSafetyBuffer).Append("\n");
            sb.Append("  PauseDuration: ").Append(PauseDuration).Append("\n");
            sb.Append("  RevocationQueueSafetyBuffer: ").Append(RevocationQueueSafetyBuffer).Append("\n");
            sb.Append("  SafetyBuffer: ").Append(SafetyBuffer).Append("\n");
            sb.Append("  TidyAcme: ").Append(TidyAcme).Append("\n");
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
            return this.Equals(input as PkiTidyRequest);
        }

        /// <summary>
        /// Returns true if PkiTidyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiTidyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiTidyRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AcmeAccountSafetyBuffer == input.AcmeAccountSafetyBuffer ||
                    (this.AcmeAccountSafetyBuffer != null &&
                    this.AcmeAccountSafetyBuffer.Equals(input.AcmeAccountSafetyBuffer))

                ) &&
                (
                    this.IssuerSafetyBuffer == input.IssuerSafetyBuffer ||
                    (this.IssuerSafetyBuffer != null &&
                    this.IssuerSafetyBuffer.Equals(input.IssuerSafetyBuffer))

                ) &&
                (
                    this.PauseDuration == input.PauseDuration ||
                    (this.PauseDuration != null &&
                    this.PauseDuration.Equals(input.PauseDuration))

                ) &&
                (
                    this.RevocationQueueSafetyBuffer == input.RevocationQueueSafetyBuffer ||
                    (this.RevocationQueueSafetyBuffer != null &&
                    this.RevocationQueueSafetyBuffer.Equals(input.RevocationQueueSafetyBuffer))

                ) &&
                (
                    this.SafetyBuffer == input.SafetyBuffer ||
                    (this.SafetyBuffer != null &&
                    this.SafetyBuffer.Equals(input.SafetyBuffer))

                ) &&
                (
                    this.TidyAcme == input.TidyAcme ||

                    this.TidyAcme.Equals(input.TidyAcme)
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

                if (this.AcmeAccountSafetyBuffer != null)
                {
                    hashCode = (hashCode * 59) + this.AcmeAccountSafetyBuffer.GetHashCode();
                }

                if (this.IssuerSafetyBuffer != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerSafetyBuffer.GetHashCode();
                }

                if (this.PauseDuration != null)
                {
                    hashCode = (hashCode * 59) + this.PauseDuration.GetHashCode();
                }

                if (this.RevocationQueueSafetyBuffer != null)
                {
                    hashCode = (hashCode * 59) + this.RevocationQueueSafetyBuffer.GetHashCode();
                }

                if (this.SafetyBuffer != null)
                {
                    hashCode = (hashCode * 59) + this.SafetyBuffer.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.TidyAcme.GetHashCode();

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
