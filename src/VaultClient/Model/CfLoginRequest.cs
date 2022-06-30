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
using OpenAPIDateConverter = VaultClient.Client.OpenAPIDateConverter;

namespace VaultClient.Model
{
    /// <summary>
    /// CfLoginRequest
    /// </summary>
    [DataContract(Name = "CfLoginRequest")]
    public partial class CfLoginRequest : IEquatable<CfLoginRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CfLoginRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CfLoginRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CfLoginRequest" /> class.
        /// </summary>
        /// <param name="cfInstanceCert">The full body of the file available at the CF_INSTANCE_CERT path on the CF instance. (required).</param>
        /// <param name="role">The name of the role to authenticate against. (required).</param>
        /// <param name="signature">The signature generated by the client certificate&#39;s private key. (required).</param>
        /// <param name="signingTime">The date and time used to construct the signature. (required).</param>
        public CfLoginRequest(string cfInstanceCert = default(string), string role = default(string), string signature = default(string), string signingTime = default(string))
        {
            // to ensure "cfInstanceCert" is required (not null)
            if (cfInstanceCert == null) {
                throw new ArgumentNullException("cfInstanceCert is a required property for CfLoginRequest and cannot be null");
            }
            this.CfInstanceCert = cfInstanceCert;
            // to ensure "role" is required (not null)
            if (role == null) {
                throw new ArgumentNullException("role is a required property for CfLoginRequest and cannot be null");
            }
            this.Role = role;
            // to ensure "signature" is required (not null)
            if (signature == null) {
                throw new ArgumentNullException("signature is a required property for CfLoginRequest and cannot be null");
            }
            this.Signature = signature;
            // to ensure "signingTime" is required (not null)
            if (signingTime == null) {
                throw new ArgumentNullException("signingTime is a required property for CfLoginRequest and cannot be null");
            }
            this.SigningTime = signingTime;
        }

        /// <summary>
        /// The full body of the file available at the CF_INSTANCE_CERT path on the CF instance.
        /// </summary>
        /// <value>The full body of the file available at the CF_INSTANCE_CERT path on the CF instance.</value>
        [DataMember(Name = "cf_instance_cert", IsRequired = true, EmitDefaultValue = false)]
        public string CfInstanceCert { get; set; }

        /// <summary>
        /// The name of the role to authenticate against.
        /// </summary>
        /// <value>The name of the role to authenticate against.</value>
        [DataMember(Name = "role", IsRequired = true, EmitDefaultValue = false)]
        public string Role { get; set; }

        /// <summary>
        /// The signature generated by the client certificate&#39;s private key.
        /// </summary>
        /// <value>The signature generated by the client certificate&#39;s private key.</value>
        [DataMember(Name = "signature", IsRequired = true, EmitDefaultValue = false)]
        public string Signature { get; set; }

        /// <summary>
        /// The date and time used to construct the signature.
        /// </summary>
        /// <value>The date and time used to construct the signature.</value>
        [DataMember(Name = "signing_time", IsRequired = true, EmitDefaultValue = false)]
        public string SigningTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CfLoginRequest {\n");
            sb.Append("  CfInstanceCert: ").Append(CfInstanceCert).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  SigningTime: ").Append(SigningTime).Append("\n");
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
            return this.Equals(input as CfLoginRequest);
        }

        /// <summary>
        /// Returns true if CfLoginRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CfLoginRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CfLoginRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CfInstanceCert == input.CfInstanceCert ||
                    (this.CfInstanceCert != null &&
                    this.CfInstanceCert.Equals(input.CfInstanceCert))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
                ) && 
                (
                    this.SigningTime == input.SigningTime ||
                    (this.SigningTime != null &&
                    this.SigningTime.Equals(input.SigningTime))
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
                if (this.CfInstanceCert != null)
                {
                    hashCode = (hashCode * 59) + this.CfInstanceCert.GetHashCode();
                }
                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
                }
                if (this.Signature != null)
                {
                    hashCode = (hashCode * 59) + this.Signature.GetHashCode();
                }
                if (this.SigningTime != null)
                {
                    hashCode = (hashCode * 59) + this.SigningTime.GetHashCode();
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
