// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

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
    /// GroupWriteByNameRequest
    /// </summary>
    [DataContract(Name = "GroupWriteByNameRequest")]
    public partial class GroupWriteByNameRequest : IEquatable<GroupWriteByNameRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupWriteByNameRequest" /> class.
        /// </summary>
        /// <param name="id">ID of the group. If set, updates the corresponding existing group..</param>
        /// <param name="memberEntityIds">Entity IDs to be assigned as group members..</param>
        /// <param name="memberGroupIds">Group IDs to be assigned as group members..</param>
        /// <param name="metadata">Metadata to be associated with the group. In CLI, this parameter can be repeated multiple times, and it all gets merged together. For example: vault &lt;command&gt; &lt;path&gt; metadata&#x3D;key1&#x3D;value1 metadata&#x3D;key2&#x3D;value2.</param>
        /// <param name="policies">Policies to be tied to the group..</param>
        /// <param name="type">Type of the group, &#39;internal&#39; or &#39;external&#39;. Defaults to &#39;internal&#39;.</param>
        public GroupWriteByNameRequest(string id = default(string), List<string> memberEntityIds = default(List<string>), List<string> memberGroupIds = default(List<string>), Object metadata = default(Object), List<string> policies = default(List<string>), string type = default(string))
        {
            this.Id = id;
            this.MemberEntityIds = memberEntityIds;
            this.MemberGroupIds = memberGroupIds;
            this.Metadata = metadata;
            this.Policies = policies;
            this.Type = type;
        }

        /// <summary>
        /// ID of the group. If set, updates the corresponding existing group.
        /// </summary>
        /// <value>ID of the group. If set, updates the corresponding existing group.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Entity IDs to be assigned as group members.
        /// </summary>
        /// <value>Entity IDs to be assigned as group members.</value>
        [DataMember(Name = "member_entity_ids", EmitDefaultValue = false)]
        public List<string> MemberEntityIds { get; set; }

        /// <summary>
        /// Group IDs to be assigned as group members.
        /// </summary>
        /// <value>Group IDs to be assigned as group members.</value>
        [DataMember(Name = "member_group_ids", EmitDefaultValue = false)]
        public List<string> MemberGroupIds { get; set; }

        /// <summary>
        /// Metadata to be associated with the group. In CLI, this parameter can be repeated multiple times, and it all gets merged together. For example: vault &lt;command&gt; &lt;path&gt; metadata&#x3D;key1&#x3D;value1 metadata&#x3D;key2&#x3D;value2
        /// </summary>
        /// <value>Metadata to be associated with the group. In CLI, this parameter can be repeated multiple times, and it all gets merged together. For example: vault &lt;command&gt; &lt;path&gt; metadata&#x3D;key1&#x3D;value1 metadata&#x3D;key2&#x3D;value2</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Policies to be tied to the group.
        /// </summary>
        /// <value>Policies to be tied to the group.</value>
        [DataMember(Name = "policies", EmitDefaultValue = false)]
        public List<string> Policies { get; set; }

        /// <summary>
        /// Type of the group, &#39;internal&#39; or &#39;external&#39;. Defaults to &#39;internal&#39;
        /// </summary>
        /// <value>Type of the group, &#39;internal&#39; or &#39;external&#39;. Defaults to &#39;internal&#39;</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupWriteByNameRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MemberEntityIds: ").Append(MemberEntityIds).Append("\n");
            sb.Append("  MemberGroupIds: ").Append(MemberGroupIds).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as GroupWriteByNameRequest);
        }

        /// <summary>
        /// Returns true if GroupWriteByNameRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupWriteByNameRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupWriteByNameRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MemberEntityIds == input.MemberEntityIds ||
                    this.MemberEntityIds != null &&
                    input.MemberEntityIds != null &&
                    this.MemberEntityIds.SequenceEqual(input.MemberEntityIds)
                ) && 
                (
                    this.MemberGroupIds == input.MemberGroupIds ||
                    this.MemberGroupIds != null &&
                    input.MemberGroupIds != null &&
                    this.MemberGroupIds.SequenceEqual(input.MemberGroupIds)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Policies == input.Policies ||
                    this.Policies != null &&
                    input.Policies != null &&
                    this.Policies.SequenceEqual(input.Policies)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.MemberEntityIds != null)
                {
                    hashCode = (hashCode * 59) + this.MemberEntityIds.GetHashCode();
                }
                if (this.MemberGroupIds != null)
                {
                    hashCode = (hashCode * 59) + this.MemberGroupIds.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.Policies != null)
                {
                    hashCode = (hashCode * 59) + this.Policies.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
