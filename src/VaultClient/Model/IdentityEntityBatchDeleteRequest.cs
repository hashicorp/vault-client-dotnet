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
using FileParameter = VaultClient.Client.FileParameter;
using OpenAPIDateConverter = VaultClient.Client.OpenAPIDateConverter;

namespace VaultClient.Model
{
    /// <summary>
    /// IdentityEntityBatchDeleteRequest
    /// </summary>
    [DataContract(Name = "IdentityEntityBatchDeleteRequest")]
    public partial class IdentityEntityBatchDeleteRequest : IEquatable<IdentityEntityBatchDeleteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityEntityBatchDeleteRequest" /> class.
        /// </summary>
        /// <param name="entityIds">Entity IDs to delete.</param>
        public IdentityEntityBatchDeleteRequest(List<string> entityIds = default(List<string>))
        {
            this.EntityIds = entityIds;
        }

        /// <summary>
        /// Entity IDs to delete
        /// </summary>
        /// <value>Entity IDs to delete</value>
        [DataMember(Name = "entity_ids", EmitDefaultValue = false)]
        public List<string> EntityIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IdentityEntityBatchDeleteRequest {\n");
            sb.Append("  EntityIds: ").Append(EntityIds).Append("\n");
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
            return this.Equals(input as IdentityEntityBatchDeleteRequest);
        }

        /// <summary>
        /// Returns true if IdentityEntityBatchDeleteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of IdentityEntityBatchDeleteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentityEntityBatchDeleteRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EntityIds == input.EntityIds ||
                    this.EntityIds != null &&
                    input.EntityIds != null &&
                    this.EntityIds.SequenceEqual(input.EntityIds)
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
                if (this.EntityIds != null)
                {
                    hashCode = (hashCode * 59) + this.EntityIds.GetHashCode();
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
