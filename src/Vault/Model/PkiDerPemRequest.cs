/*
 * HashiCorp Vault API
 *
 * HTTP API that gives you full access to Vault. All API routes are prefixed with `/v1/`.
 *
 * The version of the OpenAPI document: 1.12.0
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
using OpenAPIDateConverter = Vault.Client.OpenAPIDateConverter;

namespace Vault.Model
{
    /// <summary>
    /// PkiDerPemRequest
    /// </summary>
    [DataContract(Name = "PkiDerPemRequest")]
    public partial class PkiDerPemRequest : IEquatable<PkiDerPemRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PkiDerPemRequest" /> class.
        /// </summary>
        /// <param name="issuerName">Provide a name to the generated or existing issuer, the name must be unique across all issuers and not be the reserved value &#39;default&#39;.</param>
        /// <param name="leafNotAfterBehavior">Behavior of leaf&#39;s NotAfter fields: \&quot;err\&quot; to error if the computed NotAfter date exceeds that of this issuer; \&quot;truncate\&quot; to silently truncate to that of this issuer; or \&quot;permit\&quot; to allow this issuance to succeed (with NotAfter exceeding that of an issuer). Note that not all values will results in certificates that can be validated through the entire validity period. It is suggested to use \&quot;truncate\&quot; for intermediate CAs and \&quot;permit\&quot; only for root CAs. (default to &quot;err&quot;).</param>
        /// <param name="manualChain">Chain of issuer references to use to build this issuer&#39;s computed CAChain field, when non-empty..</param>
        /// <param name="usage">Comma-separated list (or string slice) of usages for this issuer; valid values are \&quot;read-only\&quot;, \&quot;issuing-certificates\&quot;, and \&quot;crl-signing\&quot;. Multiple values may be specified. Read-only is implicit and always set..</param>
        public PkiDerPemRequest(string issuerName = default(string), string leafNotAfterBehavior = "err", List<string> manualChain = default(List<string>), List<string> usage = default(List<string>))
        {
            this.IssuerName = issuerName;
            // use default value if no "leafNotAfterBehavior" provided
            this.LeafNotAfterBehavior = leafNotAfterBehavior ?? "err";
            this.ManualChain = manualChain;
            this.Usage = usage;
        }

        /// <summary>
        /// Provide a name to the generated or existing issuer, the name must be unique across all issuers and not be the reserved value &#39;default&#39;
        /// </summary>
        /// <value>Provide a name to the generated or existing issuer, the name must be unique across all issuers and not be the reserved value &#39;default&#39;</value>
        [DataMember(Name = "issuer_name", EmitDefaultValue = false)]
        public string IssuerName { get; set; }

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
        /// Comma-separated list (or string slice) of usages for this issuer; valid values are \&quot;read-only\&quot;, \&quot;issuing-certificates\&quot;, and \&quot;crl-signing\&quot;. Multiple values may be specified. Read-only is implicit and always set.
        /// </summary>
        /// <value>Comma-separated list (or string slice) of usages for this issuer; valid values are \&quot;read-only\&quot;, \&quot;issuing-certificates\&quot;, and \&quot;crl-signing\&quot;. Multiple values may be specified. Read-only is implicit and always set.</value>
        [DataMember(Name = "usage", EmitDefaultValue = false)]
        public List<string> Usage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiDerPemRequest {\n");
            sb.Append("  IssuerName: ").Append(IssuerName).Append("\n");
            sb.Append("  LeafNotAfterBehavior: ").Append(LeafNotAfterBehavior).Append("\n");
            sb.Append("  ManualChain: ").Append(ManualChain).Append("\n");
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
            return this.Equals(input as PkiDerPemRequest);
        }

        /// <summary>
        /// Returns true if PkiDerPemRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiDerPemRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiDerPemRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IssuerName == input.IssuerName ||
                    (this.IssuerName != null &&
                    this.IssuerName.Equals(input.IssuerName))
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
                if (this.IssuerName != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerName.GetHashCode();
                }
                if (this.LeafNotAfterBehavior != null)
                {
                    hashCode = (hashCode * 59) + this.LeafNotAfterBehavior.GetHashCode();
                }
                if (this.ManualChain != null)
                {
                    hashCode = (hashCode * 59) + this.ManualChain.GetHashCode();
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