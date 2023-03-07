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
    /// OIDCWriteAssignmentRequest
    /// </summary>
    [DataContract(Name = "OIDCWriteAssignmentRequest")]
    public partial class OIDCWriteAssignmentRequest : IEquatable<OIDCWriteAssignmentRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="OIDCWriteAssignmentRequest" /> class.
        /// </summary>

        /// <param name="EntityIds">Comma separated string or array of identity entity IDs.</param>

        /// <param name="GroupIds">Comma separated string or array of identity group IDs.</param>


        public OIDCWriteAssignmentRequest(List<string> EntityIds = default(List<string>), List<string> GroupIds = default(List<string>))
        {

            this.EntityIds = EntityIds;

            this.GroupIds = GroupIds;

        }

        /// <summary>
        /// Comma separated string or array of identity entity IDs
        /// </summary>
        /// <value>Comma separated string or array of identity entity IDs</value>
        [DataMember(Name = "entity_ids", EmitDefaultValue = false)]

        public List<string> EntityIds { get; set; }


        /// <summary>
        /// Comma separated string or array of identity group IDs
        /// </summary>
        /// <value>Comma separated string or array of identity group IDs</value>
        [DataMember(Name = "group_ids", EmitDefaultValue = false)]

        public List<string> GroupIds { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OIDCWriteAssignmentRequest {\n");
            sb.Append("  EntityIds: ").Append(EntityIds).Append("\n");
            sb.Append("  GroupIds: ").Append(GroupIds).Append("\n");
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
            return this.Equals(input as OIDCWriteAssignmentRequest);
        }

        /// <summary>
        /// Returns true if OIDCWriteAssignmentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OIDCWriteAssignmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OIDCWriteAssignmentRequest input)
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
                ) &&
                (
                    this.GroupIds == input.GroupIds ||
                    this.GroupIds != null &&
                    input.GroupIds != null &&
                    this.GroupIds.SequenceEqual(input.GroupIds)
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

                if (this.GroupIds != null)
                {
                    hashCode = (hashCode * 59) + this.GroupIds.GetHashCode();
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
