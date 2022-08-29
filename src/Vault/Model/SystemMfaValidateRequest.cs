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
    /// SystemMfaValidateRequest
    /// </summary>
    [DataContract(Name = "SystemMfaValidateRequest")]
    public partial class SystemMfaValidateRequest : IEquatable<SystemMfaValidateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemMfaValidateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SystemMfaValidateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemMfaValidateRequest" /> class.
        /// </summary>
        /// <param name="mfaPayload">A map from MFA method ID to a slice of passcodes or an empty slice if the method does not use passcodes (required).</param>
        /// <param name="mfaRequestId">ID for this MFA request (required).</param>
        public SystemMfaValidateRequest(Object mfaPayload = default(Object), string mfaRequestId = default(string))
        {
            // to ensure "mfaPayload" is required (not null)
            if (mfaPayload == null) {
                throw new ArgumentNullException("mfaPayload is a required property for SystemMfaValidateRequest and cannot be null");
            }
            this.MfaPayload = mfaPayload;
            // to ensure "mfaRequestId" is required (not null)
            if (mfaRequestId == null) {
                throw new ArgumentNullException("mfaRequestId is a required property for SystemMfaValidateRequest and cannot be null");
            }
            this.MfaRequestId = mfaRequestId;
        }

        /// <summary>
        /// A map from MFA method ID to a slice of passcodes or an empty slice if the method does not use passcodes
        /// </summary>
        /// <value>A map from MFA method ID to a slice of passcodes or an empty slice if the method does not use passcodes</value>
        [DataMember(Name = "mfa_payload", IsRequired = true, EmitDefaultValue = false)]
        public Object MfaPayload { get; set; }

        /// <summary>
        /// ID for this MFA request
        /// </summary>
        /// <value>ID for this MFA request</value>
        [DataMember(Name = "mfa_request_id", IsRequired = true, EmitDefaultValue = false)]
        public string MfaRequestId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SystemMfaValidateRequest {\n");
            sb.Append("  MfaPayload: ").Append(MfaPayload).Append("\n");
            sb.Append("  MfaRequestId: ").Append(MfaRequestId).Append("\n");
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
            return this.Equals(input as SystemMfaValidateRequest);
        }

        /// <summary>
        /// Returns true if SystemMfaValidateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemMfaValidateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemMfaValidateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MfaPayload == input.MfaPayload ||
                    (this.MfaPayload != null &&
                    this.MfaPayload.Equals(input.MfaPayload))
                ) && 
                (
                    this.MfaRequestId == input.MfaRequestId ||
                    (this.MfaRequestId != null &&
                    this.MfaRequestId.Equals(input.MfaRequestId))
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
                if (this.MfaPayload != null)
                {
                    hashCode = (hashCode * 59) + this.MfaPayload.GetHashCode();
                }
                if (this.MfaRequestId != null)
                {
                    hashCode = (hashCode * 59) + this.MfaRequestId.GetHashCode();
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
