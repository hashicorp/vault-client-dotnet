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
    /// TransitKeysTrimRequest
    /// </summary>
    [DataContract(Name = "TransitKeysTrimRequest")]
    public partial class TransitKeysTrimRequest : IEquatable<TransitKeysTrimRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransitKeysTrimRequest" /> class.
        /// </summary>
        /// <param name="minAvailableVersion">The minimum available version for the key ring. All versions before this version will be permanently deleted. This value can at most be equal to the lesser of &#39;min_decryption_version&#39; and &#39;min_encryption_version&#39;. This is not allowed to be set when either &#39;min_encryption_version&#39; or &#39;min_decryption_version&#39; is set to zero..</param>
        public TransitKeysTrimRequest(int minAvailableVersion = default(int))
        {
            this.MinAvailableVersion = minAvailableVersion;
        }

        /// <summary>
        /// The minimum available version for the key ring. All versions before this version will be permanently deleted. This value can at most be equal to the lesser of &#39;min_decryption_version&#39; and &#39;min_encryption_version&#39;. This is not allowed to be set when either &#39;min_encryption_version&#39; or &#39;min_decryption_version&#39; is set to zero.
        /// </summary>
        /// <value>The minimum available version for the key ring. All versions before this version will be permanently deleted. This value can at most be equal to the lesser of &#39;min_decryption_version&#39; and &#39;min_encryption_version&#39;. This is not allowed to be set when either &#39;min_encryption_version&#39; or &#39;min_decryption_version&#39; is set to zero.</value>
        [DataMember(Name = "min_available_version", EmitDefaultValue = false)]
        public int MinAvailableVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransitKeysTrimRequest {\n");
            sb.Append("  MinAvailableVersion: ").Append(MinAvailableVersion).Append("\n");
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
            return this.Equals(input as TransitKeysTrimRequest);
        }

        /// <summary>
        /// Returns true if TransitKeysTrimRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransitKeysTrimRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransitKeysTrimRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MinAvailableVersion == input.MinAvailableVersion ||
                    this.MinAvailableVersion.Equals(input.MinAvailableVersion)
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
                hashCode = (hashCode * 59) + this.MinAvailableVersion.GetHashCode();
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