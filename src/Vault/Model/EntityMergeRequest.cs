// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0
//
// Code generated with OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

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
    /// EntityMergeRequest
    /// </summary>
    [DataContract(Name = "EntityMergeRequest")]

    public partial class EntityMergeRequest : IEquatable<EntityMergeRequest>, IValidatableObject
    {











        /// <summary>
        /// Initializes a new instance of the <see cref="EntityMergeRequest" /> class.
        /// </summary>

        /// <param name="ConflictingAliasIdsToKeep">Alias IDs to keep in case of conflicting aliases. Ignored if no conflicting aliases found.</param>

        /// <param name="Force">Setting this will follow the &#x27;mine&#x27; strategy for merging MFA secrets. If there are secrets of the same type both in entities that are merged from and in entity into which all others are getting merged, secrets in the destination will be unaltered. If not set, this API will throw an error containing all the conflicts..</param>

        /// <param name="FromEntityIds">Entity IDs which need to get merged.</param>

        /// <param name="ToEntityId">Entity ID into which all the other entities need to get merged.</param>


        public EntityMergeRequest(List<string> ConflictingAliasIdsToKeep = default(List<string>), bool Force = default(bool), List<string> FromEntityIds = default(List<string>), string ToEntityId = default(string))
        {

            this.ConflictingAliasIdsToKeep = ConflictingAliasIdsToKeep;

            this.Force = Force;

            this.FromEntityIds = FromEntityIds;

            this.ToEntityId = ToEntityId;

        }

        /// <summary>
        /// Alias IDs to keep in case of conflicting aliases. Ignored if no conflicting aliases found
        /// </summary>
        /// <value>Alias IDs to keep in case of conflicting aliases. Ignored if no conflicting aliases found</value>
        [DataMember(Name = "conflicting_alias_ids_to_keep", EmitDefaultValue = false)]


        public List<string> ConflictingAliasIdsToKeep { get; set; }


        /// <summary>
        /// Setting this will follow the &#x27;mine&#x27; strategy for merging MFA secrets. If there are secrets of the same type both in entities that are merged from and in entity into which all others are getting merged, secrets in the destination will be unaltered. If not set, this API will throw an error containing all the conflicts.
        /// </summary>
        /// <value>Setting this will follow the &#x27;mine&#x27; strategy for merging MFA secrets. If there are secrets of the same type both in entities that are merged from and in entity into which all others are getting merged, secrets in the destination will be unaltered. If not set, this API will throw an error containing all the conflicts.</value>
        [DataMember(Name = "force", EmitDefaultValue = true)]


        public bool Force { get; set; }


        /// <summary>
        /// Entity IDs which need to get merged
        /// </summary>
        /// <value>Entity IDs which need to get merged</value>
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
            sb.Append("class EntityMergeRequest {\n");
            sb.Append("  ConflictingAliasIdsToKeep: ").Append(ConflictingAliasIdsToKeep).Append("\n");
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
            return this.Equals(input as EntityMergeRequest);
        }

        /// <summary>
        /// Returns true if EntityMergeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EntityMergeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityMergeRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.ConflictingAliasIdsToKeep == input.ConflictingAliasIdsToKeep ||
                    this.ConflictingAliasIdsToKeep != null &&
                    input.ConflictingAliasIdsToKeep != null &&
                    this.ConflictingAliasIdsToKeep.SequenceEqual(input.ConflictingAliasIdsToKeep)
                ) &&
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

                if (this.ConflictingAliasIdsToKeep != null)
                {
                    hashCode = (hashCode * 59) + this.ConflictingAliasIdsToKeep.GetHashCode();
                }


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
