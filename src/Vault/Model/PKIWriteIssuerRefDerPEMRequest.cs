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
    /// PKIWriteIssuerRefDerPEMRequest
    /// </summary>
    [DataContract(Name = "PKIWriteIssuerRefDerPEMRequest")]
    public partial class PKIWriteIssuerRefDerPEMRequest : IEquatable<PKIWriteIssuerRefDerPEMRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PKIWriteIssuerRefDerPEMRequest" /> class.
        /// </summary>
        /// <param name="crlDistributionPoints">Comma-separated list of URLs to be used for the CRL distribution points attribute. See also RFC 5280 Section 4.2.1.13..</param>
        /// <param name="enableAiaUrlTemplating">Whether or not to enabling templating of the above AIA fields. When templating is enabled the special values &#39;{{issuer_id}}&#39; and &#39;{{cluster_path}}&#39; are available, but the addresses are not checked for URL validity until issuance time. This requires /config/cluster&#39;s path to be set on all PR Secondary clusters. (default to false).</param>
        /// <param name="issuerName">Provide a name to the generated or existing issuer, the name must be unique across all issuers and not be the reserved value &#39;default&#39;.</param>
        /// <param name="issuingCertificates">Comma-separated list of URLs to be used for the issuing certificate attribute. See also RFC 5280 Section 4.2.2.1..</param>
        /// <param name="leafNotAfterBehavior">Behavior of leaf&#39;s NotAfter fields: \&quot;err\&quot; to error if the computed NotAfter date exceeds that of this issuer; \&quot;truncate\&quot; to silently truncate to that of this issuer; or \&quot;permit\&quot; to allow this issuance to succeed (with NotAfter exceeding that of an issuer). Note that not all values will results in certificates that can be validated through the entire validity period. It is suggested to use \&quot;truncate\&quot; for intermediate CAs and \&quot;permit\&quot; only for root CAs. (default to &quot;err&quot;).</param>
        /// <param name="manualChain">Chain of issuer references to use to build this issuer&#39;s computed CAChain field, when non-empty..</param>
        /// <param name="ocspServers">Comma-separated list of URLs to be used for the OCSP servers attribute. See also RFC 5280 Section 4.2.2.1..</param>
        /// <param name="revocationSignatureAlgorithm">Which x509.SignatureAlgorithm name to use for signing CRLs. This parameter allows differentiation between PKCS#1v1.5 and PSS keys and choice of signature hash algorithm. The default (empty string) value is for Go to select the signature algorithm. This can fail if the underlying key does not support the requested signature algorithm, which may not be known at modification time (such as with PKCS#11 managed RSA keys). (default to &quot;&quot;).</param>
        /// <param name="usage">Comma-separated list (or string slice) of usages for this issuer; valid values are \&quot;read-only\&quot;, \&quot;issuing-certificates\&quot;, \&quot;crl-signing\&quot;, and \&quot;ocsp-signing\&quot;. Multiple values may be specified. Read-only is implicit and always set..</param>
        public PKIWriteIssuerRefDerPEMRequest(List<string> crlDistributionPoints = default(List<string>), bool enableAiaUrlTemplating = false, string issuerName = default(string), List<string> issuingCertificates = default(List<string>), string leafNotAfterBehavior = "err", List<string> manualChain = default(List<string>), List<string> ocspServers = default(List<string>), string revocationSignatureAlgorithm = "", List<string> usage = default(List<string>))
        {
            this.CrlDistributionPoints = crlDistributionPoints;
            this.EnableAiaUrlTemplating = enableAiaUrlTemplating;
            this.IssuerName = issuerName;
            this.IssuingCertificates = issuingCertificates;
            // use default value if no "leafNotAfterBehavior" provided
            this.LeafNotAfterBehavior = leafNotAfterBehavior ?? "err";
            this.ManualChain = manualChain;
            this.OcspServers = ocspServers;
            // use default value if no "revocationSignatureAlgorithm" provided
            this.RevocationSignatureAlgorithm = revocationSignatureAlgorithm ?? "";
            this.Usage = usage;
        }

        /// <summary>
        /// Comma-separated list of URLs to be used for the CRL distribution points attribute. See also RFC 5280 Section 4.2.1.13.
        /// </summary>
        /// <value>Comma-separated list of URLs to be used for the CRL distribution points attribute. See also RFC 5280 Section 4.2.1.13.</value>
        [DataMember(Name = "crl_distribution_points", EmitDefaultValue = false)]
        public List<string> CrlDistributionPoints { get; set; }

        /// <summary>
        /// Whether or not to enabling templating of the above AIA fields. When templating is enabled the special values &#39;{{issuer_id}}&#39; and &#39;{{cluster_path}}&#39; are available, but the addresses are not checked for URL validity until issuance time. This requires /config/cluster&#39;s path to be set on all PR Secondary clusters.
        /// </summary>
        /// <value>Whether or not to enabling templating of the above AIA fields. When templating is enabled the special values &#39;{{issuer_id}}&#39; and &#39;{{cluster_path}}&#39; are available, but the addresses are not checked for URL validity until issuance time. This requires /config/cluster&#39;s path to be set on all PR Secondary clusters.</value>
        [DataMember(Name = "enable_aia_url_templating", EmitDefaultValue = true)]
        public bool EnableAiaUrlTemplating { get; set; }

        /// <summary>
        /// Provide a name to the generated or existing issuer, the name must be unique across all issuers and not be the reserved value &#39;default&#39;
        /// </summary>
        /// <value>Provide a name to the generated or existing issuer, the name must be unique across all issuers and not be the reserved value &#39;default&#39;</value>
        [DataMember(Name = "issuer_name", EmitDefaultValue = false)]
        public string IssuerName { get; set; }

        /// <summary>
        /// Comma-separated list of URLs to be used for the issuing certificate attribute. See also RFC 5280 Section 4.2.2.1.
        /// </summary>
        /// <value>Comma-separated list of URLs to be used for the issuing certificate attribute. See also RFC 5280 Section 4.2.2.1.</value>
        [DataMember(Name = "issuing_certificates", EmitDefaultValue = false)]
        public List<string> IssuingCertificates { get; set; }

        /// <summary>
        /// Behavior of leaf&#39;s NotAfter fields: \&quot;err\&quot; to error if the computed NotAfter date exceeds that of this issuer; \&quot;truncate\&quot; to silently truncate to that of this issuer; or \&quot;permit\&quot; to allow this issuance to succeed (with NotAfter exceeding that of an issuer). Note that not all values will results in certificates that can be validated through the entire validity period. It is suggested to use \&quot;truncate\&quot; for intermediate CAs and \&quot;permit\&quot; only for root CAs.
        /// </summary>
        /// <value>Behavior of leaf&#39;s NotAfter fields: \&quot;err\&quot; to error if the computed NotAfter date exceeds that of this issuer; \&quot;truncate\&quot; to silently truncate to that of this issuer; or \&quot;permit\&quot; to allow this issuance to succeed (with NotAfter exceeding that of an issuer). Note that not all values will results in certificates that can be validated through the entire validity period. It is suggested to use \&quot;truncate\&quot; for intermediate CAs and \&quot;permit\&quot; only for root CAs.</value>
        [DataMember(Name = "leaf_not_after_behavior", EmitDefaultValue = false)]
        public string LeafNotAfterBehavior { get; set; }

        /// <summary>
        /// Chain of issuer references to use to build this issuer&#39;s computed CAChain field, when non-empty.
        /// </summary>
        /// <value>Chain of issuer references to use to build this issuer&#39;s computed CAChain field, when non-empty.</value>
        [DataMember(Name = "manual_chain", EmitDefaultValue = false)]
        public List<string> ManualChain { get; set; }

        /// <summary>
        /// Comma-separated list of URLs to be used for the OCSP servers attribute. See also RFC 5280 Section 4.2.2.1.
        /// </summary>
        /// <value>Comma-separated list of URLs to be used for the OCSP servers attribute. See also RFC 5280 Section 4.2.2.1.</value>
        [DataMember(Name = "ocsp_servers", EmitDefaultValue = false)]
        public List<string> OcspServers { get; set; }

        /// <summary>
        /// Which x509.SignatureAlgorithm name to use for signing CRLs. This parameter allows differentiation between PKCS#1v1.5 and PSS keys and choice of signature hash algorithm. The default (empty string) value is for Go to select the signature algorithm. This can fail if the underlying key does not support the requested signature algorithm, which may not be known at modification time (such as with PKCS#11 managed RSA keys).
        /// </summary>
        /// <value>Which x509.SignatureAlgorithm name to use for signing CRLs. This parameter allows differentiation between PKCS#1v1.5 and PSS keys and choice of signature hash algorithm. The default (empty string) value is for Go to select the signature algorithm. This can fail if the underlying key does not support the requested signature algorithm, which may not be known at modification time (such as with PKCS#11 managed RSA keys).</value>
        [DataMember(Name = "revocation_signature_algorithm", EmitDefaultValue = false)]
        public string RevocationSignatureAlgorithm { get; set; }

        /// <summary>
        /// Comma-separated list (or string slice) of usages for this issuer; valid values are \&quot;read-only\&quot;, \&quot;issuing-certificates\&quot;, \&quot;crl-signing\&quot;, and \&quot;ocsp-signing\&quot;. Multiple values may be specified. Read-only is implicit and always set.
        /// </summary>
        /// <value>Comma-separated list (or string slice) of usages for this issuer; valid values are \&quot;read-only\&quot;, \&quot;issuing-certificates\&quot;, \&quot;crl-signing\&quot;, and \&quot;ocsp-signing\&quot;. Multiple values may be specified. Read-only is implicit and always set.</value>
        [DataMember(Name = "usage", EmitDefaultValue = false)]
        public List<string> Usage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PKIWriteIssuerRefDerPEMRequest {\n");
            sb.Append("  CrlDistributionPoints: ").Append(CrlDistributionPoints).Append("\n");
            sb.Append("  EnableAiaUrlTemplating: ").Append(EnableAiaUrlTemplating).Append("\n");
            sb.Append("  IssuerName: ").Append(IssuerName).Append("\n");
            sb.Append("  IssuingCertificates: ").Append(IssuingCertificates).Append("\n");
            sb.Append("  LeafNotAfterBehavior: ").Append(LeafNotAfterBehavior).Append("\n");
            sb.Append("  ManualChain: ").Append(ManualChain).Append("\n");
            sb.Append("  OcspServers: ").Append(OcspServers).Append("\n");
            sb.Append("  RevocationSignatureAlgorithm: ").Append(RevocationSignatureAlgorithm).Append("\n");
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
            return this.Equals(input as PKIWriteIssuerRefDerPEMRequest);
        }

        /// <summary>
        /// Returns true if PKIWriteIssuerRefDerPEMRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PKIWriteIssuerRefDerPEMRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PKIWriteIssuerRefDerPEMRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
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
                    this.Usage == input.Usage ||
                    this.Usage != null &&
                    input.Usage != null &&
                    this.Usage.SequenceEqual(input.Usage)
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
                if (this.CrlDistributionPoints != null)
                {
                    hashCode = (hashCode * 59) + this.CrlDistributionPoints.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EnableAiaUrlTemplating.GetHashCode();
                if (this.IssuerName != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerName.GetHashCode();
                }
                if (this.IssuingCertificates != null)
                {
                    hashCode = (hashCode * 59) + this.IssuingCertificates.GetHashCode();
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
