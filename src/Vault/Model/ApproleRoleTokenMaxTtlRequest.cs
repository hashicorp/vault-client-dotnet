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
    /// ApproleRoleTokenMaxTtlRequest
    /// </summary>
    [DataContract(Name = "ApproleRoleTokenMaxTtlRequest")]
    public partial class ApproleRoleTokenMaxTtlRequest : IEquatable<ApproleRoleTokenMaxTtlRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApproleRoleTokenMaxTtlRequest" /> class.
        /// </summary>
        /// <param name="tokenMaxTtl">The maximum lifetime of the generated token.</param>
        public ApproleRoleTokenMaxTtlRequest(int tokenMaxTtl = default(int))
        {
            this.TokenMaxTtl = tokenMaxTtl;
        }

        /// <summary>
        /// The maximum lifetime of the generated token
        /// </summary>
        /// <value>The maximum lifetime of the generated token</value>
        [DataMember(Name = "token_max_ttl", EmitDefaultValue = false)]
        public int TokenMaxTtl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApproleRoleTokenMaxTtlRequest {\n");
            sb.Append("  TokenMaxTtl: ").Append(TokenMaxTtl).Append("\n");
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
            return this.Equals(input as ApproleRoleTokenMaxTtlRequest);
        }

        /// <summary>
        /// Returns true if ApproleRoleTokenMaxTtlRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApproleRoleTokenMaxTtlRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApproleRoleTokenMaxTtlRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TokenMaxTtl == input.TokenMaxTtl ||
                    this.TokenMaxTtl.Equals(input.TokenMaxTtl)
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
                hashCode = (hashCode * 59) + this.TokenMaxTtl.GetHashCode();
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
