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
    /// GroupLookupRequest
    /// </summary>
    [DataContract(Name = "GroupLookupRequest")]
    public partial class GroupLookupRequest : IEquatable<GroupLookupRequest>, IValidatableObject
    {













        /// <summary>
        /// Initializes a new instance of the <see cref="GroupLookupRequest" /> class.
        /// </summary>

        /// <param name="AliasId">ID of the alias..</param>

        /// <param name="AliasMountAccessor">Accessor of the mount to which the alias belongs to. This should be supplied in conjunction with &#x27;alias_name&#x27;..</param>

        /// <param name="AliasName">Name of the alias. This should be supplied in conjunction with &#x27;alias_mount_accessor&#x27;..</param>

        /// <param name="Id">ID of the group..</param>

        /// <param name="Name">Name of the group..</param>


        public GroupLookupRequest(string AliasId = default(string), string AliasMountAccessor = default(string), string AliasName = default(string), string Id = default(string), string Name = default(string))
        {

            this.AliasId = AliasId;

            this.AliasMountAccessor = AliasMountAccessor;

            this.AliasName = AliasName;

            this.Id = Id;

            this.Name = Name;

        }

        /// <summary>
        /// ID of the alias.
        /// </summary>
        /// <value>ID of the alias.</value>
        [DataMember(Name = "alias_id", EmitDefaultValue = false)]


        public string AliasId { get; set; }


        /// <summary>
        /// Accessor of the mount to which the alias belongs to. This should be supplied in conjunction with &#x27;alias_name&#x27;.
        /// </summary>
        /// <value>Accessor of the mount to which the alias belongs to. This should be supplied in conjunction with &#x27;alias_name&#x27;.</value>
        [DataMember(Name = "alias_mount_accessor", EmitDefaultValue = false)]


        public string AliasMountAccessor { get; set; }


        /// <summary>
        /// Name of the alias. This should be supplied in conjunction with &#x27;alias_mount_accessor&#x27;.
        /// </summary>
        /// <value>Name of the alias. This should be supplied in conjunction with &#x27;alias_mount_accessor&#x27;.</value>
        [DataMember(Name = "alias_name", EmitDefaultValue = false)]


        public string AliasName { get; set; }


        /// <summary>
        /// ID of the group.
        /// </summary>
        /// <value>ID of the group.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]


        public string Id { get; set; }


        /// <summary>
        /// Name of the group.
        /// </summary>
        /// <value>Name of the group.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]


        public string Name { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupLookupRequest {\n");
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
            return this.Equals(input as GroupLookupRequest);
        }

        /// <summary>
        /// Returns true if GroupLookupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupLookupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupLookupRequest input)
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
