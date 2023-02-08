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
    /// EntityLookupRequest
    /// </summary>
    [DataContract(Name = "EntityLookupRequest")]
    public partial class EntityLookupRequest : IEquatable<EntityLookupRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityLookupRequest" /> class.
        /// </summary>
        /// <param name="aliasId">ID of the alias..</param>
        /// <param name="aliasMountAccessor">Accessor of the mount to which the alias belongs to. This should be supplied in conjunction with &#39;alias_name&#39;..</param>
        /// <param name="aliasName">Name of the alias. This should be supplied in conjunction with &#39;alias_mount_accessor&#39;..</param>
        /// <param name="id">ID of the entity..</param>
        /// <param name="name">Name of the entity..</param>
        public EntityLookupRequest(string aliasId = default(string), string aliasMountAccessor = default(string), string aliasName = default(string), string id = default(string), string name = default(string))
        {
            this.AliasId = aliasId;
            this.AliasMountAccessor = aliasMountAccessor;
            this.AliasName = aliasName;
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// ID of the alias.
        /// </summary>
        /// <value>ID of the alias.</value>
        [DataMember(Name = "alias_id", EmitDefaultValue = false)]
        public string AliasId { get; set; }

        /// <summary>
        /// Accessor of the mount to which the alias belongs to. This should be supplied in conjunction with &#39;alias_name&#39;.
        /// </summary>
        /// <value>Accessor of the mount to which the alias belongs to. This should be supplied in conjunction with &#39;alias_name&#39;.</value>
        [DataMember(Name = "alias_mount_accessor", EmitDefaultValue = false)]
        public string AliasMountAccessor { get; set; }

        /// <summary>
        /// Name of the alias. This should be supplied in conjunction with &#39;alias_mount_accessor&#39;.
        /// </summary>
        /// <value>Name of the alias. This should be supplied in conjunction with &#39;alias_mount_accessor&#39;.</value>
        [DataMember(Name = "alias_name", EmitDefaultValue = false)]
        public string AliasName { get; set; }

        /// <summary>
        /// ID of the entity.
        /// </summary>
        /// <value>ID of the entity.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the entity.
        /// </summary>
        /// <value>Name of the entity.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EntityLookupRequest {\n");
            sb.Append("  AliasId: ").Append(AliasId).Append("\n");
            sb.Append("  AliasMountAccessor: ").Append(AliasMountAccessor).Append("\n");
            sb.Append("  AliasName: ").Append(AliasName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as EntityLookupRequest);
        }

        /// <summary>
        /// Returns true if EntityLookupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EntityLookupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityLookupRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AliasId == input.AliasId ||
                    (this.AliasId != null &&
                    this.AliasId.Equals(input.AliasId))
                ) && 
                (
                    this.AliasMountAccessor == input.AliasMountAccessor ||
                    (this.AliasMountAccessor != null &&
                    this.AliasMountAccessor.Equals(input.AliasMountAccessor))
                ) && 
                (
                    this.AliasName == input.AliasName ||
                    (this.AliasName != null &&
                    this.AliasName.Equals(input.AliasName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.AliasId != null)
                {
                    hashCode = (hashCode * 59) + this.AliasId.GetHashCode();
                }
                if (this.AliasMountAccessor != null)
                {
                    hashCode = (hashCode * 59) + this.AliasMountAccessor.GetHashCode();
                }
                if (this.AliasName != null)
                {
                    hashCode = (hashCode * 59) + this.AliasName.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
