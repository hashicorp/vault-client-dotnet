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
    /// PKITidyRequest
    /// </summary>
    [DataContract(Name = "PKITidyRequest")]
    public partial class PKITidyRequest : IEquatable<PKITidyRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PKITidyRequest" /> class.
        /// </summary>

        /// <param name="IssuerSafetyBuffer">The amount of extra time that must have passed beyond issuer&#x27;s expiration before it is removed from the backend storage. Defaults to 8760 hours (1 year). (default to 31536000).</param>

        /// <param name="PauseDuration">The amount of time to wait between processing certificates. This allows operators to change the execution profile of tidy to take consume less resources by slowing down how long it takes to run. Note that the entire list of certificates will be stored in memory during the entire tidy operation, but resources to read/process/update existing entries will be spread out over a greater period of time. By default this is zero seconds. (default to &quot;0s&quot;).</param>

        /// <param name="SafetyBuffer">The amount of extra time that must have passed beyond certificate expiration before it is removed from the backend storage and/or revocation list. Defaults to 72 hours. (default to 259200).</param>

        /// <param name="TidyCertStore">Set to true to enable tidying up the certificate store.</param>

        /// <param name="TidyExpiredIssuers">Set to true to automatically remove expired issuers past the issuer_safety_buffer. No keys will be removed as part of this operation..</param>

        /// <param name="TidyRevocationList">Deprecated; synonym for &#x27;tidy_revoked_certs.</param>

        /// <param name="TidyRevokedCertIssuerAssociations">Set to true to validate issuer associations on revocation entries. This helps increase the performance of CRL building and OCSP responses..</param>

        /// <param name="TidyRevokedCerts">Set to true to expire all revoked and expired certificates, removing them both from the CRL and from storage. The CRL will be rotated if this causes any values to be removed..</param>


        public PKITidyRequest(int IssuerSafetyBuffer = 31536000, string PauseDuration = "0s", int SafetyBuffer = 259200, bool TidyCertStore = default(bool), bool TidyExpiredIssuers = default(bool), bool TidyRevocationList = default(bool), bool TidyRevokedCertIssuerAssociations = default(bool), bool TidyRevokedCerts = default(bool))
        {

            this.IssuerSafetyBuffer = IssuerSafetyBuffer;

            // use default value if no "PauseDuration" provided
            this.PauseDuration = PauseDuration ?? "0s";


            this.SafetyBuffer = SafetyBuffer;

            this.TidyCertStore = TidyCertStore;

            this.TidyExpiredIssuers = TidyExpiredIssuers;

            this.TidyRevocationList = TidyRevocationList;

            this.TidyRevokedCertIssuerAssociations = TidyRevokedCertIssuerAssociations;

            this.TidyRevokedCerts = TidyRevokedCerts;

        }

        /// <summary>
        /// The amount of extra time that must have passed beyond issuer&#x27;s expiration before it is removed from the backend storage. Defaults to 8760 hours (1 year).
        /// </summary>
        /// <value>The amount of extra time that must have passed beyond issuer&#x27;s expiration before it is removed from the backend storage. Defaults to 8760 hours (1 year).</value>
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
        /// Deprecated; synonym for &#x27;tidy_revoked_certs
        /// </summary>
        /// <value>Deprecated; synonym for &#x27;tidy_revoked_certs</value>
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
            sb.Append("class PKITidyRequest {\n");
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
            return this.Equals(input as PKITidyRequest);
        }

        /// <summary>
        /// Returns true if PKITidyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PKITidyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PKITidyRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
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
