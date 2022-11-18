/*
 * HashiCorp Vault API
 *
 * HTTP API that gives you full access to Vault. All API routes are prefixed with `/v1/`.
 *
 * The version of the OpenAPI document: 1.13.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


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
    /// PkiConfigAutoTidyRequest
    /// </summary>
    [DataContract(Name = "PkiConfigAutoTidyRequest")]
    public partial class PkiConfigAutoTidyRequest : IEquatable<PkiConfigAutoTidyRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PkiConfigAutoTidyRequest" /> class.
        /// </summary>
        /// <param name="enabled">Set to true to enable automatic tidy operations..</param>
        /// <param name="intervalDuration">Interval at which to run an auto-tidy operation. This is the time between tidy invocations (after one finishes to the start of the next). Running a manual tidy will reset this duration. (default to 43200).</param>
        /// <param name="issuerSafetyBuffer">The amount of extra time that must have passed beyond issuer&#39;s expiration before it is removed from the backend storage. Defaults to 8760 hours (1 year). (default to 31536000).</param>
        /// <param name="pauseDuration">The amount of time to wait between processing certificates. This allows operators to change the execution profile of tidy to take consume less resources by slowing down how long it takes to run. Note that the entire list of certificates will be stored in memory during the entire tidy operation, but resources to read/process/update existing entries will be spread out over a greater period of time. By default this is zero seconds. (default to &quot;0s&quot;).</param>
        /// <param name="safetyBuffer">The amount of extra time that must have passed beyond certificate expiration before it is removed from the backend storage and/or revocation list. Defaults to 72 hours. (default to 259200).</param>
        /// <param name="tidyCertStore">Set to true to enable tidying up the certificate store.</param>
        /// <param name="tidyExpiredIssuers">Set to true to automatically remove expired issuers past the issuer_safety_buffer. No keys will be removed as part of this operation..</param>
        /// <param name="tidyRevocationList">Deprecated; synonym for &#39;tidy_revoked_certs.</param>
        /// <param name="tidyRevokedCertIssuerAssociations">Set to true to validate issuer associations on revocation entries. This helps increase the performance of CRL building and OCSP responses..</param>
        /// <param name="tidyRevokedCerts">Set to true to expire all revoked and expired certificates, removing them both from the CRL and from storage. The CRL will be rotated if this causes any values to be removed..</param>
        public PkiConfigAutoTidyRequest(bool enabled = default(bool), int intervalDuration = 43200, int issuerSafetyBuffer = 31536000, string pauseDuration = "0s", int safetyBuffer = 259200, bool tidyCertStore = default(bool), bool tidyExpiredIssuers = default(bool), bool tidyRevocationList = default(bool), bool tidyRevokedCertIssuerAssociations = default(bool), bool tidyRevokedCerts = default(bool))
        {
            this.Enabled = enabled;
            this.IntervalDuration = intervalDuration;
            this.IssuerSafetyBuffer = issuerSafetyBuffer;
            // use default value if no "pauseDuration" provided
            this.PauseDuration = pauseDuration ?? "0s";
            this.SafetyBuffer = safetyBuffer;
            this.TidyCertStore = tidyCertStore;
            this.TidyExpiredIssuers = tidyExpiredIssuers;
            this.TidyRevocationList = tidyRevocationList;
            this.TidyRevokedCertIssuerAssociations = tidyRevokedCertIssuerAssociations;
            this.TidyRevokedCerts = tidyRevokedCerts;
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
        /// The amount of extra time that must have passed beyond issuer&#39;s expiration before it is removed from the backend storage. Defaults to 8760 hours (1 year).
        /// </summary>
        /// <value>The amount of extra time that must have passed beyond issuer&#39;s expiration before it is removed from the backend storage. Defaults to 8760 hours (1 year).</value>
        [DataMember(Name = "issuer_safety_buffer", EmitDefaultValue = false)]
        public int IssuerSafetyBuffer { get; set; }

        /// <summary>
        /// The amount of time to wait between processing certificates. This allows operators to change the execution profile of tidy to take consume less resources by slowing down how long it takes to run. Note that the entire list of certificates will be stored in memory during the entire tidy operation, but resources to read/process/update existing entries will be spread out over a greater period of time. By default this is zero seconds.
        /// </summary>
        /// <value>The amount of time to wait between processing certificates. This allows operators to change the execution profile of tidy to take consume less resources by slowing down how long it takes to run. Note that the entire list of certificates will be stored in memory during the entire tidy operation, but resources to read/process/update existing entries will be spread out over a greater period of time. By default this is zero seconds.</value>
        [DataMember(Name = "pause_duration", EmitDefaultValue = false)]
        public string PauseDuration { get; set; }

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
        /// Set to true to automatically remove expired issuers past the issuer_safety_buffer. No keys will be removed as part of this operation.
        /// </summary>
        /// <value>Set to true to automatically remove expired issuers past the issuer_safety_buffer. No keys will be removed as part of this operation.</value>
        [DataMember(Name = "tidy_expired_issuers", EmitDefaultValue = true)]
        public bool TidyExpiredIssuers { get; set; }

        /// <summary>
        /// Deprecated; synonym for &#39;tidy_revoked_certs
        /// </summary>
        /// <value>Deprecated; synonym for &#39;tidy_revoked_certs</value>
        [DataMember(Name = "tidy_revocation_list", EmitDefaultValue = true)]
        public bool TidyRevocationList { get; set; }

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
            sb.Append("class PkiConfigAutoTidyRequest {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  IntervalDuration: ").Append(IntervalDuration).Append("\n");
            sb.Append("  IssuerSafetyBuffer: ").Append(IssuerSafetyBuffer).Append("\n");
            sb.Append("  PauseDuration: ").Append(PauseDuration).Append("\n");
            sb.Append("  SafetyBuffer: ").Append(SafetyBuffer).Append("\n");
            sb.Append("  TidyCertStore: ").Append(TidyCertStore).Append("\n");
            sb.Append("  TidyExpiredIssuers: ").Append(TidyExpiredIssuers).Append("\n");
            sb.Append("  TidyRevocationList: ").Append(TidyRevocationList).Append("\n");
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
            return this.Equals(input as PkiConfigAutoTidyRequest);
        }

        /// <summary>
        /// Returns true if PkiConfigAutoTidyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiConfigAutoTidyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiConfigAutoTidyRequest input)
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
                    this.SafetyBuffer == input.SafetyBuffer ||
                    this.SafetyBuffer.Equals(input.SafetyBuffer)
                ) && 
                (
                    this.TidyCertStore == input.TidyCertStore ||
                    this.TidyCertStore.Equals(input.TidyCertStore)
                ) && 
                (
                    this.TidyExpiredIssuers == input.TidyExpiredIssuers ||
                    this.TidyExpiredIssuers.Equals(input.TidyExpiredIssuers)
                ) && 
                (
                    this.TidyRevocationList == input.TidyRevocationList ||
                    this.TidyRevocationList.Equals(input.TidyRevocationList)
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
                hashCode = (hashCode * 59) + this.SafetyBuffer.GetHashCode();
                hashCode = (hashCode * 59) + this.TidyCertStore.GetHashCode();
                hashCode = (hashCode * 59) + this.TidyExpiredIssuers.GetHashCode();
                hashCode = (hashCode * 59) + this.TidyRevocationList.GetHashCode();
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
