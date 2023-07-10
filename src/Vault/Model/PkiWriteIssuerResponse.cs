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
    /// PkiWriteIssuerResponse
    /// </summary>
    [DataContract(Name = "PkiWriteIssuerResponse")]
    public partial class PkiWriteIssuerResponse : IEquatable<PkiWriteIssuerResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PkiWriteIssuerResponse" /> class.
        /// </summary>

        /// <param name="CaChain">CA Chain.</param>

        /// <param name="Certificate">Certificate.</param>

        /// <param name="CrlDistributionPoints">CRL Distribution Points.</param>

        /// <param name="EnableAiaUrlTemplating">Whether or not templating is enabled for AIA fields.</param>

        /// <param name="IssuerId">Issuer Id.</param>

        /// <param name="IssuerName">Issuer Name.</param>

        /// <param name="IssuingCertificates">Issuing Certificates.</param>

        /// <param name="KeyId">Key Id.</param>

        /// <param name="LeafNotAfterBehavior">Leaf Not After Behavior.</param>

        /// <param name="ManualChain">Manual Chain.</param>

        /// <param name="OcspServers">OSCP Servers.</param>

        /// <param name="RevocationSignatureAlgorithm">Revocation Signature Alogrithm.</param>

        /// <param name="RevocationTime">RevocationTime.</param>

        /// <param name="RevocationTimeRfc3339">RevocationTimeRfc3339.</param>

        /// <param name="Revoked">Revoked.</param>

        /// <param name="Usage">Usage.</param>


        public PkiWriteIssuerResponse(List<string> CaChain = default(List<string>), string Certificate = default(string), List<string> CrlDistributionPoints = default(List<string>), bool EnableAiaUrlTemplating = default(bool), string IssuerId = default(string), string IssuerName = default(string), List<string> IssuingCertificates = default(List<string>), string KeyId = default(string), string LeafNotAfterBehavior = default(string), List<string> ManualChain = default(List<string>), List<string> OcspServers = default(List<string>), string RevocationSignatureAlgorithm = default(string), int RevocationTime = default(int), string RevocationTimeRfc3339 = default(string), bool Revoked = default(bool), string Usage = default(string))
        {

            this.CaChain = CaChain;

            this.Certificate = Certificate;

            this.CrlDistributionPoints = CrlDistributionPoints;

            this.EnableAiaUrlTemplating = EnableAiaUrlTemplating;

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
        /// CA Chain
        /// </summary>
        /// <value>CA Chain</value>
        [DataMember(Name = "ca_chain", EmitDefaultValue = false)]

        public List<string> CaChain { get; set; }


        /// <summary>
        /// Certificate
        /// </summary>
        /// <value>Certificate</value>
        [DataMember(Name = "certificate", EmitDefaultValue = false)]

        public string Certificate { get; set; }


        /// <summary>
        /// CRL Distribution Points
        /// </summary>
        /// <value>CRL Distribution Points</value>
        [DataMember(Name = "crl_distribution_points", EmitDefaultValue = false)]

        public List<string> CrlDistributionPoints { get; set; }


        /// <summary>
        /// Whether or not templating is enabled for AIA fields
        /// </summary>
        /// <value>Whether or not templating is enabled for AIA fields</value>
        [DataMember(Name = "enable_aia_url_templating", EmitDefaultValue = true)]

        public bool EnableAiaUrlTemplating { get; set; }


        /// <summary>
        /// Issuer Id
        /// </summary>
        /// <value>Issuer Id</value>
        [DataMember(Name = "issuer_id", EmitDefaultValue = false)]

        public string IssuerId { get; set; }


        /// <summary>
        /// Issuer Name
        /// </summary>
        /// <value>Issuer Name</value>
        [DataMember(Name = "issuer_name", EmitDefaultValue = false)]

        public string IssuerName { get; set; }


        /// <summary>
        /// Issuing Certificates
        /// </summary>
        /// <value>Issuing Certificates</value>
        [DataMember(Name = "issuing_certificates", EmitDefaultValue = false)]

        public List<string> IssuingCertificates { get; set; }


        /// <summary>
        /// Key Id
        /// </summary>
        /// <value>Key Id</value>
        [DataMember(Name = "key_id", EmitDefaultValue = false)]

        public string KeyId { get; set; }


        /// <summary>
        /// Leaf Not After Behavior
        /// </summary>
        /// <value>Leaf Not After Behavior</value>
        [DataMember(Name = "leaf_not_after_behavior", EmitDefaultValue = false)]

        public string LeafNotAfterBehavior { get; set; }


        /// <summary>
        /// Manual Chain
        /// </summary>
        /// <value>Manual Chain</value>
        [DataMember(Name = "manual_chain", EmitDefaultValue = false)]

        public List<string> ManualChain { get; set; }


        /// <summary>
        /// OSCP Servers
        /// </summary>
        /// <value>OSCP Servers</value>
        [DataMember(Name = "ocsp_servers", EmitDefaultValue = false)]

        public List<string> OcspServers { get; set; }


        /// <summary>
        /// Revocation Signature Alogrithm
        /// </summary>
        /// <value>Revocation Signature Alogrithm</value>
        [DataMember(Name = "revocation_signature_algorithm", EmitDefaultValue = false)]

        public string RevocationSignatureAlgorithm { get; set; }


        /// <summary>
        /// Gets or Sets RevocationTime
        /// </summary>
        [DataMember(Name = "revocation_time", EmitDefaultValue = false)]

        public int RevocationTime { get; set; }


        /// <summary>
        /// Gets or Sets RevocationTimeRfc3339
        /// </summary>
        [DataMember(Name = "revocation_time_rfc3339", EmitDefaultValue = false)]

        public string RevocationTimeRfc3339 { get; set; }


        /// <summary>
        /// Revoked
        /// </summary>
        /// <value>Revoked</value>
        [DataMember(Name = "revoked", EmitDefaultValue = true)]

        public bool Revoked { get; set; }


        /// <summary>
        /// Usage
        /// </summary>
        /// <value>Usage</value>
        [DataMember(Name = "usage", EmitDefaultValue = false)]

        public string Usage { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiWriteIssuerResponse {\n");
            sb.Append("  CaChain: ").Append(CaChain).Append("\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  CrlDistributionPoints: ").Append(CrlDistributionPoints).Append("\n");
            sb.Append("  EnableAiaUrlTemplating: ").Append(EnableAiaUrlTemplating).Append("\n");
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
            return this.Equals(input as PkiWriteIssuerResponse);
        }

        /// <summary>
        /// Returns true if PkiWriteIssuerResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiWriteIssuerResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiWriteIssuerResponse input)
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
                    this.EnableAiaUrlTemplating == input.EnableAiaUrlTemplating ||

                    this.EnableAiaUrlTemplating.Equals(input.EnableAiaUrlTemplating)
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


                hashCode = (hashCode * 59) + this.EnableAiaUrlTemplating.GetHashCode();
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
