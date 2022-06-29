/*
 * HashiCorp Vault API
 *
 * HTTP API that gives you full access to Vault. All API routes are prefixed with `/v1/`.
 *
 * The version of the OpenAPI document: 1.11.0
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
using FileParameter = VaultClient.Client.FileParameter;
using OpenAPIDateConverter = VaultClient.Client.OpenAPIDateConverter;

namespace VaultClient.Model
{
    /// <summary>
    /// PkiRootSignSelfIssuedRequest
    /// </summary>
    [DataContract(Name = "PkiRootSignSelfIssuedRequest")]
    public partial class PkiRootSignSelfIssuedRequest : IEquatable<PkiRootSignSelfIssuedRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PkiRootSignSelfIssuedRequest" /> class.
        /// </summary>
        /// <param name="certificate">PEM-format self-issued certificate to be signed..</param>
        /// <param name="issuerRef">Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. (default to &quot;default&quot;).</param>
        /// <param name="requireMatchingCertificateAlgorithms">If true, require the public key algorithm of the signer to match that of the self issued certificate. (default to false).</param>
        public PkiRootSignSelfIssuedRequest(string certificate = default(string), string issuerRef = "default", bool requireMatchingCertificateAlgorithms = false)
        {
            this.Certificate = certificate;
            // use default value if no "issuerRef" provided
            this.IssuerRef = issuerRef ?? "default";
            this.RequireMatchingCertificateAlgorithms = requireMatchingCertificateAlgorithms;
        }

        /// <summary>
        /// PEM-format self-issued certificate to be signed.
        /// </summary>
        /// <value>PEM-format self-issued certificate to be signed.</value>
        [DataMember(Name = "certificate", EmitDefaultValue = false)]
        public string Certificate { get; set; }

        /// <summary>
        /// Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer.
        /// </summary>
        /// <value>Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer.</value>
        [DataMember(Name = "issuer_ref", EmitDefaultValue = false)]
        public string IssuerRef { get; set; }

        /// <summary>
        /// If true, require the public key algorithm of the signer to match that of the self issued certificate.
        /// </summary>
        /// <value>If true, require the public key algorithm of the signer to match that of the self issued certificate.</value>
        [DataMember(Name = "require_matching_certificate_algorithms", EmitDefaultValue = true)]
        public bool RequireMatchingCertificateAlgorithms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiRootSignSelfIssuedRequest {\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  IssuerRef: ").Append(IssuerRef).Append("\n");
            sb.Append("  RequireMatchingCertificateAlgorithms: ").Append(RequireMatchingCertificateAlgorithms).Append("\n");
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
            return this.Equals(input as PkiRootSignSelfIssuedRequest);
        }

        /// <summary>
        /// Returns true if PkiRootSignSelfIssuedRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiRootSignSelfIssuedRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiRootSignSelfIssuedRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))
                ) && 
                (
                    this.IssuerRef == input.IssuerRef ||
                    (this.IssuerRef != null &&
                    this.IssuerRef.Equals(input.IssuerRef))
                ) && 
                (
                    this.RequireMatchingCertificateAlgorithms == input.RequireMatchingCertificateAlgorithms ||
                    this.RequireMatchingCertificateAlgorithms.Equals(input.RequireMatchingCertificateAlgorithms)
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
                if (this.Certificate != null)
                {
                    hashCode = (hashCode * 59) + this.Certificate.GetHashCode();
                }
                if (this.IssuerRef != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerRef.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RequireMatchingCertificateAlgorithms.GetHashCode();
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
