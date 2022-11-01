/*
 * HashiCorp Vault API
 *
 * HTTP API that gives you full access to Vault. All API routes are prefixed with `/v1/`.
 *
 * The version of the OpenAPI document: 1.13.0
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
    /// SystemPolicyRequest
    /// </summary>
    [DataContract(Name = "SystemPolicyRequest")]
    public partial class SystemPolicyRequest : IEquatable<SystemPolicyRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemPolicyRequest" /> class.
        /// </summary>
        /// <param name="policy">The rules of the policy..</param>
        /// <param name="rules">The rules of the policy..</param>
        public SystemPolicyRequest(string policy = default(string), string rules = default(string))
        {
            this.Policy = policy;
            this.Rules = rules;
        }

        /// <summary>
        /// The rules of the policy.
        /// </summary>
        /// <value>The rules of the policy.</value>
        [DataMember(Name = "policy", EmitDefaultValue = false)]
        public string Policy { get; set; }

        /// <summary>
        /// The rules of the policy.
        /// </summary>
        /// <value>The rules of the policy.</value>
        [DataMember(Name = "rules", EmitDefaultValue = false)]
        [Obsolete]
        public string Rules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SystemPolicyRequest {\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
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
            return this.Equals(input as SystemPolicyRequest);
        }

        /// <summary>
        /// Returns true if SystemPolicyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemPolicyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemPolicyRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
                ) && 
                (
                    this.Rules == input.Rules ||
                    (this.Rules != null &&
                    this.Rules.Equals(input.Rules))
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
                if (this.Policy != null)
                {
                    hashCode = (hashCode * 59) + this.Policy.GetHashCode();
                }
                if (this.Rules != null)
                {
                    hashCode = (hashCode * 59) + this.Rules.GetHashCode();
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
