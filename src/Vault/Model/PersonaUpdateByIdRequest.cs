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
    /// PersonaUpdateByIdRequest
    /// </summary>
    [DataContract(Name = "PersonaUpdateByIdRequest")]
    public partial class PersonaUpdateByIdRequest : IEquatable<PersonaUpdateByIdRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PersonaUpdateByIdRequest" /> class.
        /// </summary>

        /// <param name="EntityId">Entity ID to which this persona should be tied to.</param>

        /// <param name="Metadata">Metadata to be associated with the persona. In CLI, this parameter can be repeated multiple times, and it all gets merged together. For example: vault &lt;command&gt; &lt;path&gt; metadata&#x3D;key1&#x3D;value1 metadata&#x3D;key2&#x3D;value2.</param>

        /// <param name="MountAccessor">Mount accessor to which this persona belongs to.</param>

        /// <param name="Name">Name of the persona.</param>


        public PersonaUpdateByIdRequest(string EntityId = default(string), Object Metadata = default(Object), string MountAccessor = default(string), string Name = default(string))
        {

            this.EntityId = EntityId;

            this.Metadata = Metadata;

            this.MountAccessor = MountAccessor;

            this.Name = Name;

        }

        /// <summary>
        /// Entity ID to which this persona should be tied to
        /// </summary>
        /// <value>Entity ID to which this persona should be tied to</value>
        [DataMember(Name = "entity_id", EmitDefaultValue = false)]

        public string EntityId { get; set; }


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
            sb.Append("class PersonaUpdateByIdRequest {\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
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
            return this.Equals(input as PersonaUpdateByIdRequest);
        }

        /// <summary>
        /// Returns true if PersonaUpdateByIdRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PersonaUpdateByIdRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersonaUpdateByIdRequest input)
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
