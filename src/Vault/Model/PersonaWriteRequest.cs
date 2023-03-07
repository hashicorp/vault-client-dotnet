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
    /// PersonaWriteRequest
    /// </summary>
    [DataContract(Name = "PersonaWriteRequest")]
    public partial class PersonaWriteRequest : IEquatable<PersonaWriteRequest>, IValidatableObject
    {













        /// <summary>
        /// Initializes a new instance of the <see cref="PersonaWriteRequest" /> class.
        /// </summary>

        /// <param name="EntityId">Entity ID to which this persona belongs to.</param>

        /// <param name="Id">ID of the persona.</param>

        /// <param name="Metadata">Metadata to be associated with the persona. In CLI, this parameter can be repeated multiple times, and it all gets merged together. For example: vault &lt;command&gt; &lt;path&gt; metadata&#x3D;key1&#x3D;value1 metadata&#x3D;key2&#x3D;value2.</param>

        /// <param name="MountAccessor">Mount accessor to which this persona belongs to.</param>

        /// <param name="Name">Name of the persona.</param>


        public PersonaWriteRequest(string EntityId = default(string), string Id = default(string), Object Metadata = default(Object), string MountAccessor = default(string), string Name = default(string))
        {

            this.EntityId = EntityId;

            this.Id = Id;

            this.Metadata = Metadata;

            this.MountAccessor = MountAccessor;

            this.Name = Name;

        }

        /// <summary>
        /// Entity ID to which this persona belongs to
        /// </summary>
        /// <value>Entity ID to which this persona belongs to</value>
        [DataMember(Name = "entity_id", EmitDefaultValue = false)]

        public string EntityId { get; set; }


        /// <summary>
        /// ID of the persona
        /// </summary>
        /// <value>ID of the persona</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]

        public string Id { get; set; }


        /// <summary>
        /// Metadata to be associated with the persona. In CLI, this parameter can be repeated multiple times, and it all gets merged together. For example: vault &lt;command&gt; &lt;path&gt; metadata&#x3D;key1&#x3D;value1 metadata&#x3D;key2&#x3D;value2
        /// </summary>
        /// <value>Metadata to be associated with the persona. In CLI, this parameter can be repeated multiple times, and it all gets merged together. For example: vault &lt;command&gt; &lt;path&gt; metadata&#x3D;key1&#x3D;value1 metadata&#x3D;key2&#x3D;value2</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]

        public Object Metadata { get; set; }


        /// <summary>
        /// Mount accessor to which this persona belongs to
        /// </summary>
        /// <value>Mount accessor to which this persona belongs to</value>
        [DataMember(Name = "mount_accessor", EmitDefaultValue = false)]

        public string MountAccessor { get; set; }


        /// <summary>
        /// Name of the persona
        /// </summary>
        /// <value>Name of the persona</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]

        public string Name { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PersonaWriteRequest {\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as PersonaWriteRequest);
        }

        /// <summary>
        /// Returns true if PersonaWriteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PersonaWriteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersonaWriteRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
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
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))

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

                if (this.EntityId != null)
                {
                    hashCode = (hashCode * 59) + this.EntityId.GetHashCode();
                }

                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }

                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
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
