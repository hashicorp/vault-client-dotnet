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
    /// AliasWriteRequest
    /// </summary>
    [DataContract(Name = "AliasWriteRequest")]
    public partial class AliasWriteRequest : IEquatable<AliasWriteRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="AliasWriteRequest" /> class.
        /// </summary>

        /// <param name="CanonicalId">Entity ID to which this alias belongs to.</param>

        /// <param name="EntityId">Entity ID to which this alias belongs to. This field is deprecated in favor of &#x27;canonical_id&#x27;..</param>

        /// <param name="Id">ID of the alias.</param>

        /// <param name="MountAccessor">Mount accessor to which this alias belongs to.</param>

        /// <param name="Name">Name of the alias.</param>


        public AliasWriteRequest(string CanonicalId = default(string), string EntityId = default(string), string Id = default(string), string MountAccessor = default(string), string Name = default(string))
        {

            this.CanonicalId = CanonicalId;

            this.EntityId = EntityId;

            this.Id = Id;

            this.MountAccessor = MountAccessor;

            this.Name = Name;

        }

        /// <summary>
        /// Entity ID to which this alias belongs to
        /// </summary>
        /// <value>Entity ID to which this alias belongs to</value>
        [DataMember(Name = "canonical_id", EmitDefaultValue = false)]

        public string CanonicalId { get; set; }


        /// <summary>
        /// Entity ID to which this alias belongs to. This field is deprecated in favor of &#x27;canonical_id&#x27;.
        /// </summary>
        /// <value>Entity ID to which this alias belongs to. This field is deprecated in favor of &#x27;canonical_id&#x27;.</value>
        [DataMember(Name = "entity_id", EmitDefaultValue = false)]

        public string EntityId { get; set; }


        /// <summary>
        /// ID of the alias
        /// </summary>
        /// <value>ID of the alias</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]

        public string Id { get; set; }


        /// <summary>
        /// Mount accessor to which this alias belongs to
        /// </summary>
        /// <value>Mount accessor to which this alias belongs to</value>
        [DataMember(Name = "mount_accessor", EmitDefaultValue = false)]

        public string MountAccessor { get; set; }


        /// <summary>
        /// Name of the alias
        /// </summary>
        /// <value>Name of the alias</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]

        public string Name { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AliasWriteRequest {\n");
            sb.Append("  CanonicalId: ").Append(CanonicalId).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MountAccessor: ").Append(MountAccessor).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as AliasWriteRequest);
        }

        /// <summary>
        /// Returns true if AliasWriteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AliasWriteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AliasWriteRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.CanonicalId == input.CanonicalId ||
                    (this.CanonicalId != null &&
                    this.CanonicalId.Equals(input.CanonicalId))

                ) &&
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))

                ) &&
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))

                ) &&
                (
                    this.MountAccessor == input.MountAccessor ||
                    (this.MountAccessor != null &&
                    this.MountAccessor.Equals(input.MountAccessor))

                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))

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

                if (this.CanonicalId != null)
                {
                    hashCode = (hashCode * 59) + this.CanonicalId.GetHashCode();
                }

                if (this.EntityId != null)
                {
                    hashCode = (hashCode * 59) + this.EntityId.GetHashCode();
                }

                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }

                if (this.MountAccessor != null)
                {
                    hashCode = (hashCode * 59) + this.MountAccessor.GetHashCode();
                }

                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
