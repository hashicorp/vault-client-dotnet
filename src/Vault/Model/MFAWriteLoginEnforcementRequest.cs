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
    /// MfaWriteLoginEnforcementRequest
    /// </summary>
    [DataContract(Name = "MfaWriteLoginEnforcementRequest")]
    public partial class MfaWriteLoginEnforcementRequest : IEquatable<MfaWriteLoginEnforcementRequest>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="MfaWriteLoginEnforcementRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MfaWriteLoginEnforcementRequest() { }


        /// <summary>
        /// Initializes a new instance of the <see cref="MfaWriteLoginEnforcementRequest" /> class.
        /// </summary>

        /// <param name="AuthMethodAccessors">Array of auth mount accessor IDs.</param>

        /// <param name="AuthMethodTypes">Array of auth mount types.</param>

        /// <param name="IdentityEntityIds">Array of identity entity IDs.</param>

        /// <param name="IdentityGroupIds">Array of identity group IDs.</param>

        /// <param name="MfaMethodIds">Array of Method IDs that determine what methods will be enforced (required).</param>


        public MfaWriteLoginEnforcementRequest(List<string> AuthMethodAccessors = default(List<string>), List<string> AuthMethodTypes = default(List<string>), List<string> IdentityEntityIds = default(List<string>), List<string> IdentityGroupIds = default(List<string>), List<string> MfaMethodIds = default(List<string>))
        {

            // to ensure "MfaMethodIds" is required (not null)
            if (MfaMethodIds == null)
            {
                throw new ArgumentNullException("MfaMethodIds is a required property for MfaWriteLoginEnforcementRequest and cannot be null");
            }
            this.MfaMethodIds = MfaMethodIds;


            this.AuthMethodAccessors = AuthMethodAccessors;

            this.AuthMethodTypes = AuthMethodTypes;

            this.IdentityEntityIds = IdentityEntityIds;

            this.IdentityGroupIds = IdentityGroupIds;

        }

        /// <summary>
        /// Array of auth mount accessor IDs
        /// </summary>
        /// <value>Array of auth mount accessor IDs</value>
        [DataMember(Name = "auth_method_accessors", EmitDefaultValue = false)]

        public List<string> AuthMethodAccessors { get; set; }


        /// <summary>
        /// Array of auth mount types
        /// </summary>
        /// <value>Array of auth mount types</value>
        [DataMember(Name = "auth_method_types", EmitDefaultValue = false)]

        public List<string> AuthMethodTypes { get; set; }


        /// <summary>
        /// Array of identity entity IDs
        /// </summary>
        /// <value>Array of identity entity IDs</value>
        [DataMember(Name = "identity_entity_ids", EmitDefaultValue = false)]

        public List<string> IdentityEntityIds { get; set; }


        /// <summary>
        /// Array of identity group IDs
        /// </summary>
        /// <value>Array of identity group IDs</value>
        [DataMember(Name = "identity_group_ids", EmitDefaultValue = false)]

        public List<string> IdentityGroupIds { get; set; }


        /// <summary>
        /// Array of Method IDs that determine what methods will be enforced
        /// </summary>
        /// <value>Array of Method IDs that determine what methods will be enforced</value>
        [DataMember(Name = "mfa_method_ids", IsRequired = true, EmitDefaultValue = false)]

        public List<string> MfaMethodIds { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MfaWriteLoginEnforcementRequest {\n");
            sb.Append("  AuthMethodAccessors: ").Append(AuthMethodAccessors).Append("\n");
            sb.Append("  AuthMethodTypes: ").Append(AuthMethodTypes).Append("\n");
            sb.Append("  IdentityEntityIds: ").Append(IdentityEntityIds).Append("\n");
            sb.Append("  IdentityGroupIds: ").Append(IdentityGroupIds).Append("\n");
            sb.Append("  MfaMethodIds: ").Append(MfaMethodIds).Append("\n");
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
            return this.Equals(input as MfaWriteLoginEnforcementRequest);
        }

        /// <summary>
        /// Returns true if MfaWriteLoginEnforcementRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MfaWriteLoginEnforcementRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MfaWriteLoginEnforcementRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AuthMethodAccessors == input.AuthMethodAccessors ||
                    this.AuthMethodAccessors != null &&
                    input.AuthMethodAccessors != null &&
                    this.AuthMethodAccessors.SequenceEqual(input.AuthMethodAccessors)
                ) &&
                (
                    this.AuthMethodTypes == input.AuthMethodTypes ||
                    this.AuthMethodTypes != null &&
                    input.AuthMethodTypes != null &&
                    this.AuthMethodTypes.SequenceEqual(input.AuthMethodTypes)
                ) &&
                (
                    this.IdentityEntityIds == input.IdentityEntityIds ||
                    this.IdentityEntityIds != null &&
                    input.IdentityEntityIds != null &&
                    this.IdentityEntityIds.SequenceEqual(input.IdentityEntityIds)
                ) &&
                (
                    this.IdentityGroupIds == input.IdentityGroupIds ||
                    this.IdentityGroupIds != null &&
                    input.IdentityGroupIds != null &&
                    this.IdentityGroupIds.SequenceEqual(input.IdentityGroupIds)
                ) &&
                (
                    this.MfaMethodIds == input.MfaMethodIds ||
                    this.MfaMethodIds != null &&
                    input.MfaMethodIds != null &&
                    this.MfaMethodIds.SequenceEqual(input.MfaMethodIds)
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

                if (this.AuthMethodAccessors != null)
                {
                    hashCode = (hashCode * 59) + this.AuthMethodAccessors.GetHashCode();
                }

                if (this.AuthMethodTypes != null)
                {
                    hashCode = (hashCode * 59) + this.AuthMethodTypes.GetHashCode();
                }

                if (this.IdentityEntityIds != null)
                {
                    hashCode = (hashCode * 59) + this.IdentityEntityIds.GetHashCode();
                }

                if (this.IdentityGroupIds != null)
                {
                    hashCode = (hashCode * 59) + this.IdentityGroupIds.GetHashCode();
                }

                if (this.MfaMethodIds != null)
                {
                    hashCode = (hashCode * 59) + this.MfaMethodIds.GetHashCode();
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
