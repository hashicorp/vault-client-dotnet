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
    /// IdentityEntityMergeRequest
    /// </summary>
    [DataContract(Name = "IdentityEntityMergeRequest")]
    public partial class IdentityEntityMergeRequest : IEquatable<IdentityEntityMergeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityEntityMergeRequest" /> class.
        /// </summary>
        /// <param name="force">Setting this will follow the &#39;mine&#39; strategy for merging MFA secrets. If there are secrets of the same type both in entities that are merged from and in entity into which all others are getting merged, secrets in the destination will be unaltered. If not set, this API will throw an error containing all the conflicts..</param>
        /// <param name="fromEntityIds">Entity IDs which needs to get merged.</param>
        /// <param name="toEntityId">Entity ID into which all the other entities need to get merged.</param>
        public IdentityEntityMergeRequest(bool force = default(bool), List<string> fromEntityIds = default(List<string>), string toEntityId = default(string))
        {
            this.Force = force;
            this.FromEntityIds = fromEntityIds;
            this.ToEntityId = toEntityId;
        }

        /// <summary>
        /// Setting this will follow the &#39;mine&#39; strategy for merging MFA secrets. If there are secrets of the same type both in entities that are merged from and in entity into which all others are getting merged, secrets in the destination will be unaltered. If not set, this API will throw an error containing all the conflicts.
        /// </summary>
        /// <value>Setting this will follow the &#39;mine&#39; strategy for merging MFA secrets. If there are secrets of the same type both in entities that are merged from and in entity into which all others are getting merged, secrets in the destination will be unaltered. If not set, this API will throw an error containing all the conflicts.</value>
        [DataMember(Name = "force", EmitDefaultValue = true)]
        public bool Force { get; set; }

        /// <summary>
        /// Entity IDs which needs to get merged
        /// </summary>
        /// <value>Entity IDs which needs to get merged</value>
        [DataMember(Name = "from_entity_ids", EmitDefaultValue = false)]
        public List<string> FromEntityIds { get; set; }

        /// <summary>
        /// Entity ID into which all the other entities need to get merged
        /// </summary>
        /// <value>Entity ID into which all the other entities need to get merged</value>
        [DataMember(Name = "to_entity_id", EmitDefaultValue = false)]
        public string ToEntityId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IdentityEntityMergeRequest {\n");
            sb.Append("  Force: ").Append(Force).Append("\n");
            sb.Append("  FromEntityIds: ").Append(FromEntityIds).Append("\n");
            sb.Append("  ToEntityId: ").Append(ToEntityId).Append("\n");
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
            return this.Equals(input as IdentityEntityMergeRequest);
        }

        /// <summary>
        /// Returns true if IdentityEntityMergeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of IdentityEntityMergeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentityEntityMergeRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Force == input.Force ||
                    this.Force.Equals(input.Force)
                ) && 
                (
                    this.FromEntityIds == input.FromEntityIds ||
                    this.FromEntityIds != null &&
                    input.FromEntityIds != null &&
                    this.FromEntityIds.SequenceEqual(input.FromEntityIds)
                ) && 
                (
                    this.ToEntityId == input.ToEntityId ||
                    (this.ToEntityId != null &&
                    this.ToEntityId.Equals(input.ToEntityId))
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
                hashCode = (hashCode * 59) + this.Force.GetHashCode();
                if (this.FromEntityIds != null)
                {
                    hashCode = (hashCode * 59) + this.FromEntityIds.GetHashCode();
                }
                if (this.ToEntityId != null)
                {
                    hashCode = (hashCode * 59) + this.ToEntityId.GetHashCode();
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
