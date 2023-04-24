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
    /// PkiRevokeIssuerResponse
    /// </summary>
    [DataContract(Name = "PkiRevokeIssuerResponse")]
    public partial class PkiRevokeIssuerResponse : IEquatable<PkiRevokeIssuerResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PkiRevokeIssuerResponse" /> class.
        /// </summary>

        /// <param name="CaChain">Certificate Authority Chain.</param>

        /// <param name="Certificate">Certificate.</param>

        /// <param name="CrlDistributionPoints">Specifies the URL values for the CRL Distribution Points field.</param>

        /// <param name="IssuerId">ID of the issuer.</param>

        /// <param name="IssuerName">Name of the issuer.</param>

        /// <param name="IssuingCertificates">Specifies the URL values for the Issuing Certificate field.</param>

        /// <param name="KeyId">ID of the Key.</param>

        /// <param name="LeafNotAfterBehavior">LeafNotAfterBehavior.</param>

        /// <param name="ManualChain">Manual Chain.</param>

        /// <param name="OcspServers">Specifies the URL values for the OCSP Servers field.</param>

        /// <param name="RevocationSignatureAlgorithm">Which signature algorithm to use when building CRLs.</param>

        /// <param name="RevocationTime">Time of revocation.</param>

        /// <param name="RevocationTimeRfc3339">RFC formatted time of revocation.</param>

        /// <param name="Revoked">Whether the issuer was revoked.</param>

        /// <param name="Usage">Allowed usage.</param>


        public PkiRevokeIssuerResponse(List<string> CaChain = default(List<string>), string Certificate = default(string), List<string> CrlDistributionPoints = default(List<string>), string IssuerId = default(string), string IssuerName = default(string), List<string> IssuingCertificates = default(List<string>), string KeyId = default(string), string LeafNotAfterBehavior = default(string), List<string> ManualChain = default(List<string>), List<string> OcspServers = default(List<string>), string RevocationSignatureAlgorithm = default(string), long RevocationTime = default(long), DateTime RevocationTimeRfc3339 = default(DateTime), bool Revoked = default(bool), string Usage = default(string))
        {

            this.CaChain = CaChain;

            this.Certificate = Certificate;

            this.CrlDistributionPoints = CrlDistributionPoints;

            this.IssuerId = IssuerId;

            this.IssuerName = IssuerName;

            this.IssuingCertificates = IssuingCertificates;

            this.KeyId = KeyId;

            this.LeafNotAfterBehavior = LeafNotAfterBehavior;

            this.ManualChain = ManualChain;

            this.OcspServers = OcspServers;

            this.RevocationSignatureAlgorithm = RevocationSignatureAlgorithm;

            this.RevocationTime = RevocationTime;

            this.RevocationTimeRfc3339 = RevocationTimeRfc3339;

            this.Revoked = Revoked;

            this.Usage = Usage;

        }

        /// <summary>
        /// Certificate Authority Chain
        /// </summary>
        /// <value>Certificate Authority Chain</value>
        [DataMember(Name = "ca_chain", EmitDefaultValue = false)]

        public List<string> CaChain { get; set; }


        /// <summary>
        /// Certificate
        /// </summary>
        /// <value>Certificate</value>
        [DataMember(Name = "certificate", EmitDefaultValue = false)]

        public string Certificate { get; set; }


        /// <summary>
        /// Specifies the URL values for the CRL Distribution Points field
        /// </summary>
        /// <value>Specifies the URL values for the CRL Distribution Points field</value>
        [DataMember(Name = "crl_distribution_points", EmitDefaultValue = false)]

        public List<string> CrlDistributionPoints { get; set; }


        /// <summary>
        /// ID of the issuer
        /// </summary>
        /// <value>ID of the issuer</value>
        [DataMember(Name = "issuer_id", EmitDefaultValue = false)]

        public string IssuerId { get; set; }


        /// <summary>
        /// Name of the issuer
        /// </summary>
        /// <value>Name of the issuer</value>
        [DataMember(Name = "issuer_name", EmitDefaultValue = false)]

        public string IssuerName { get; set; }


        /// <summary>
        /// Specifies the URL values for the Issuing Certificate field
        /// </summary>
        /// <value>Specifies the URL values for the Issuing Certificate field</value>
        [DataMember(Name = "issuing_certificates", EmitDefaultValue = false)]

        public List<string> IssuingCertificates { get; set; }


        /// <summary>
        /// ID of the Key
        /// </summary>
        /// <value>ID of the Key</value>
        [DataMember(Name = "key_id", EmitDefaultValue = false)]

        public string KeyId { get; set; }


        /// <summary>
        /// Gets or Sets LeafNotAfterBehavior
        /// </summary>
        [DataMember(Name = "leaf_not_after_behavior", EmitDefaultValue = false)]

        public string LeafNotAfterBehavior { get; set; }


        /// <summary>
        /// Manual Chain
        /// </summary>
        /// <value>Manual Chain</value>
        [DataMember(Name = "manual_chain", EmitDefaultValue = false)]

        public List<string> ManualChain { get; set; }


        /// <summary>
        /// Specifies the URL values for the OCSP Servers field
        /// </summary>
        /// <value>Specifies the URL values for the OCSP Servers field</value>
        [DataMember(Name = "ocsp_servers", EmitDefaultValue = false)]

        public List<string> OcspServers { get; set; }


        /// <summary>
        /// Which signature algorithm to use when building CRLs
        /// </summary>
        /// <value>Which signature algorithm to use when building CRLs</value>
        [DataMember(Name = "revocation_signature_algorithm", EmitDefaultValue = false)]

        public string RevocationSignatureAlgorithm { get; set; }


        /// <summary>
        /// Time of revocation
        /// </summary>
        /// <value>Time of revocation</value>
        [DataMember(Name = "revocation_time", EmitDefaultValue = false)]

        public long RevocationTime { get; set; }


        /// <summary>
        /// RFC formatted time of revocation
        /// </summary>
        /// <value>RFC formatted time of revocation</value>
        [DataMember(Name = "revocation_time_rfc3339", EmitDefaultValue = false)]

        public DateTime RevocationTimeRfc3339 { get; set; }


        /// <summary>
        /// Whether the issuer was revoked
        /// </summary>
        /// <value>Whether the issuer was revoked</value>
        [DataMember(Name = "revoked", EmitDefaultValue = true)]

        public bool Revoked { get; set; }


        /// <summary>
        /// Allowed usage
        /// </summary>
        /// <value>Allowed usage</value>
        [DataMember(Name = "usage", EmitDefaultValue = false)]

        public string Usage { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiRevokeIssuerResponse {\n");
            sb.Append("  CaChain: ").Append(CaChain).Append("\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  CrlDistributionPoints: ").Append(CrlDistributionPoints).Append("\n");
            sb.Append("  IssuerId: ").Append(IssuerId).Append("\n");
            sb.Append("  IssuerName: ").Append(IssuerName).Append("\n");
            sb.Append("  IssuingCertificates: ").Append(IssuingCertificates).Append("\n");
            sb.Append("  KeyId: ").Append(KeyId).Append("\n");
            sb.Append("  LeafNotAfterBehavior: ").Append(LeafNotAfterBehavior).Append("\n");
            sb.Append("  ManualChain: ").Append(ManualChain).Append("\n");
            sb.Append("  OcspServers: ").Append(OcspServers).Append("\n");
            sb.Append("  RevocationSignatureAlgorithm: ").Append(RevocationSignatureAlgorithm).Append("\n");
            sb.Append("  RevocationTime: ").Append(RevocationTime).Append("\n");
            sb.Append("  RevocationTimeRfc3339: ").Append(RevocationTimeRfc3339).Append("\n");
            sb.Append("  Revoked: ").Append(Revoked).Append("\n");
            sb.Append("  Usage: ").Append(Usage).Append("\n");
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
            return this.Equals(input as PkiRevokeIssuerResponse);
        }

        /// <summary>
        /// Returns true if PkiRevokeIssuerResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiRevokeIssuerResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiRevokeIssuerResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.CaChain == input.CaChain ||
                    this.CaChain != null &&
                    input.CaChain != null &&
                    this.CaChain.SequenceEqual(input.CaChain)
                ) &&
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))

                ) &&
                (
                    this.CrlDistributionPoints == input.CrlDistributionPoints ||
                    this.CrlDistributionPoints != null &&
                    input.CrlDistributionPoints != null &&
                    this.CrlDistributionPoints.SequenceEqual(input.CrlDistributionPoints)
                ) &&
                (
                    this.IssuerId == input.IssuerId ||
                    (this.IssuerId != null &&
                    this.IssuerId.Equals(input.IssuerId))

                ) &&
                (
                    this.IssuerName == input.IssuerName ||
                    (this.IssuerName != null &&
                    this.IssuerName.Equals(input.IssuerName))

                ) &&
                (
                    this.IssuingCertificates == input.IssuingCertificates ||
                    this.IssuingCertificates != null &&
                    input.IssuingCertificates != null &&
                    this.IssuingCertificates.SequenceEqual(input.IssuingCertificates)
                ) &&
                (
                    this.KeyId == input.KeyId ||
                    (this.KeyId != null &&
                    this.KeyId.Equals(input.KeyId))

                ) &&
                (
                    this.LeafNotAfterBehavior == input.LeafNotAfterBehavior ||
                    (this.LeafNotAfterBehavior != null &&
                    this.LeafNotAfterBehavior.Equals(input.LeafNotAfterBehavior))

                ) &&
                (
                    this.ManualChain == input.ManualChain ||
                    this.ManualChain != null &&
                    input.ManualChain != null &&
                    this.ManualChain.SequenceEqual(input.ManualChain)
                ) &&
                (
                    this.OcspServers == input.OcspServers ||
                    this.OcspServers != null &&
                    input.OcspServers != null &&
                    this.OcspServers.SequenceEqual(input.OcspServers)
                ) &&
                (
                    this.RevocationSignatureAlgorithm == input.RevocationSignatureAlgorithm ||
                    (this.RevocationSignatureAlgorithm != null &&
                    this.RevocationSignatureAlgorithm.Equals(input.RevocationSignatureAlgorithm))

                ) &&
                (
                    this.RevocationTime == input.RevocationTime ||

                    this.RevocationTime.Equals(input.RevocationTime)
                ) &&
                (
                    this.RevocationTimeRfc3339 == input.RevocationTimeRfc3339 ||
                    (this.RevocationTimeRfc3339 != null &&
                    this.RevocationTimeRfc3339.Equals(input.RevocationTimeRfc3339))

                ) &&
                (
                    this.Revoked == input.Revoked ||

                    this.Revoked.Equals(input.Revoked)
                ) &&
                (
                    this.Usage == input.Usage ||
                    (this.Usage != null &&
                    this.Usage.Equals(input.Usage))

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

                if (this.CaChain != null)
                {
                    hashCode = (hashCode * 59) + this.CaChain.GetHashCode();
                }

                if (this.Certificate != null)
                {
                    hashCode = (hashCode * 59) + this.Certificate.GetHashCode();
                }

                if (this.CrlDistributionPoints != null)
                {
                    hashCode = (hashCode * 59) + this.CrlDistributionPoints.GetHashCode();
                }

                if (this.IssuerId != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerId.GetHashCode();
                }

                if (this.IssuerName != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerName.GetHashCode();
                }

                if (this.IssuingCertificates != null)
                {
                    hashCode = (hashCode * 59) + this.IssuingCertificates.GetHashCode();
                }

                if (this.KeyId != null)
                {
                    hashCode = (hashCode * 59) + this.KeyId.GetHashCode();
                }

                if (this.LeafNotAfterBehavior != null)
                {
                    hashCode = (hashCode * 59) + this.LeafNotAfterBehavior.GetHashCode();
                }

                if (this.ManualChain != null)
                {
                    hashCode = (hashCode * 59) + this.ManualChain.GetHashCode();
                }

                if (this.OcspServers != null)
                {
                    hashCode = (hashCode * 59) + this.OcspServers.GetHashCode();
                }

                if (this.RevocationSignatureAlgorithm != null)
                {
                    hashCode = (hashCode * 59) + this.RevocationSignatureAlgorithm.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.RevocationTime.GetHashCode();
                if (this.RevocationTimeRfc3339 != null)
                {
                    hashCode = (hashCode * 59) + this.RevocationTimeRfc3339.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Revoked.GetHashCode();
                if (this.Usage != null)
                {
                    hashCode = (hashCode * 59) + this.Usage.GetHashCode();
                }

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
