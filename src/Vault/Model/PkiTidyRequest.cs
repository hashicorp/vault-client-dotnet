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
        /// <param name="safetyBuffer">The amount of extra time that must have passed beyond certificate expiration before it is removed from the backend storage and/or revocation list. Defaults to 72 hours. (default to 259200).</param>
        /// <param name="tidyCertStore">Set to true to enable tidying up the certificate store.</param>
        /// <param name="tidyRevocationList">Deprecated; synonym for &#39;tidy_revoked_certs.</param>
        /// <param name="tidyRevokedCerts">Set to true to expire all revoked and expired certificates, removing them both from the CRL and from storage. The CRL will be rotated if this causes any values to be removed..</param>
        public PkiTidyRequest(int safetyBuffer = 259200, bool tidyCertStore = default(bool), bool tidyRevocationList = default(bool), bool tidyRevokedCerts = default(bool))
        {
            this.SafetyBuffer = safetyBuffer;
            this.TidyCertStore = tidyCertStore;
            this.TidyRevocationList = tidyRevocationList;
            this.TidyRevokedCerts = tidyRevokedCerts;
        }

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
        /// Deprecated; synonym for &#39;tidy_revoked_certs
        /// </summary>
        /// <value>Deprecated; synonym for &#39;tidy_revoked_certs</value>
        [DataMember(Name = "tidy_revocation_list", EmitDefaultValue = true)]
        public bool TidyRevocationList { get; set; }

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
            sb.Append("  SafetyBuffer: ").Append(SafetyBuffer).Append("\n");
            sb.Append("  TidyCertStore: ").Append(TidyCertStore).Append("\n");
            sb.Append("  TidyRevocationList: ").Append(TidyRevocationList).Append("\n");
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
                    this.SafetyBuffer == input.SafetyBuffer ||
                    this.SafetyBuffer.Equals(input.SafetyBuffer)
                ) && 
                (
                    this.TidyCertStore == input.TidyCertStore ||
                    this.TidyCertStore.Equals(input.TidyCertStore)
                ) && 
                (
                    this.TidyRevocationList == input.TidyRevocationList ||
                    this.TidyRevocationList.Equals(input.TidyRevocationList)
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
                hashCode = (hashCode * 59) + this.SafetyBuffer.GetHashCode();
                hashCode = (hashCode * 59) + this.TidyCertStore.GetHashCode();
                hashCode = (hashCode * 59) + this.TidyRevocationList.GetHashCode();
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
