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
    /// AwsTidyIdentityWhitelistRequest
    /// </summary>
    [DataContract(Name = "AwsTidyIdentityWhitelistRequest")]
    public partial class AwsTidyIdentityWhitelistRequest : IEquatable<AwsTidyIdentityWhitelistRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AwsTidyIdentityWhitelistRequest" /> class.
        /// </summary>
        /// <param name="safetyBuffer">The amount of extra time that must have passed beyond the identity&#39;s expiration, before it is removed from the backend storage. (default to 259200).</param>
        public AwsTidyIdentityWhitelistRequest(int safetyBuffer = 259200)
        {
            this.SafetyBuffer = safetyBuffer;
        }

        /// <summary>
        /// The amount of extra time that must have passed beyond the identity&#39;s expiration, before it is removed from the backend storage.
        /// </summary>
        /// <value>The amount of extra time that must have passed beyond the identity&#39;s expiration, before it is removed from the backend storage.</value>
        [DataMember(Name = "safety_buffer", EmitDefaultValue = false)]
        public int SafetyBuffer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AwsTidyIdentityWhitelistRequest {\n");
            sb.Append("  SafetyBuffer: ").Append(SafetyBuffer).Append("\n");
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
            return this.Equals(input as AwsTidyIdentityWhitelistRequest);
        }

        /// <summary>
        /// Returns true if AwsTidyIdentityWhitelistRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AwsTidyIdentityWhitelistRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AwsTidyIdentityWhitelistRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SafetyBuffer == input.SafetyBuffer ||
                    this.SafetyBuffer.Equals(input.SafetyBuffer)
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
