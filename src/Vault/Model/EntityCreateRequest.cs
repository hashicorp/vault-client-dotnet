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
    /// EntityCreateRequest
    /// </summary>
    [DataContract(Name = "EntityCreateRequest")]
    public partial class EntityCreateRequest : IEquatable<EntityCreateRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="EntityCreateRequest" /> class.
        /// </summary>

        /// <param name="Disabled">If set true, tokens tied to this identity will not be able to be used (but will not be revoked)..</param>

        /// <param name="Id">ID of the entity. If set, updates the corresponding existing entity..</param>

        /// <param name="Metadata">Metadata to be associated with the entity. In CLI, this parameter can be repeated multiple times, and it all gets merged together. For example: vault &lt;command&gt; &lt;path&gt; metadata&#x3D;key1&#x3D;value1 metadata&#x3D;key2&#x3D;value2.</param>

        /// <param name="Name">Name of the entity.</param>

        /// <param name="Policies">Policies to be tied to the entity..</param>


        public EntityCreateRequest(bool Disabled = default(bool), string Id = default(string), Object Metadata = default(Object), string Name = default(string), List<string> Policies = default(List<string>))
        {

            this.Disabled = Disabled;

            this.Id = Id;

            this.Metadata = Metadata;

            this.Name = Name;

            this.Policies = Policies;

        }

        /// <summary>
        /// If set true, tokens tied to this identity will not be able to be used (but will not be revoked).
        /// </summary>
        /// <value>If set true, tokens tied to this identity will not be able to be used (but will not be revoked).</value>
        [DataMember(Name = "disabled", EmitDefaultValue = true)]

        public bool Disabled { get; set; }


        /// <summary>
        /// ID of the entity. If set, updates the corresponding existing entity.
        /// </summary>
        /// <value>ID of the entity. If set, updates the corresponding existing entity.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]

        public string Id { get; set; }


        /// <summary>
        /// Metadata to be associated with the entity. In CLI, this parameter can be repeated multiple times, and it all gets merged together. For example: vault &lt;command&gt; &lt;path&gt; metadata&#x3D;key1&#x3D;value1 metadata&#x3D;key2&#x3D;value2
        /// </summary>
        /// <value>Metadata to be associated with the entity. In CLI, this parameter can be repeated multiple times, and it all gets merged together. For example: vault &lt;command&gt; &lt;path&gt; metadata&#x3D;key1&#x3D;value1 metadata&#x3D;key2&#x3D;value2</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]

        public Object Metadata { get; set; }


        /// <summary>
        /// Name of the entity
        /// </summary>
        /// <value>Name of the entity</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]

        public string Name { get; set; }


        /// <summary>
        /// Policies to be tied to the entity.
        /// </summary>
        /// <value>Policies to be tied to the entity.</value>
        [DataMember(Name = "policies", EmitDefaultValue = false)]

        public List<string> Policies { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EntityCreateRequest {\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
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
            return this.Equals(input as EntityCreateRequest);
        }

        /// <summary>
        /// Returns true if EntityCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EntityCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityCreateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Disabled == input.Disabled ||

                    this.Disabled.Equals(input.Disabled)
                ) &&
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))

                ) &&
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))

                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))

                ) &&
                (
                    this.Policies == input.Policies ||
                    this.Policies != null &&
                    input.Policies != null &&
                    this.Policies.SequenceEqual(input.Policies)
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


                hashCode = (hashCode * 59) + this.Disabled.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }

                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }

                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }

                if (this.Policies != null)
                {
                    hashCode = (hashCode * 59) + this.Policies.GetHashCode();
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
