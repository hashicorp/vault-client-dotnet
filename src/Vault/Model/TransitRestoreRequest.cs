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
    /// TransitRestoreRequest
    /// </summary>
    [DataContract(Name = "TransitRestoreRequest")]
    public partial class TransitRestoreRequest : IEquatable<TransitRestoreRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransitRestoreRequest" /> class.
        /// </summary>
        /// <param name="backup">Backed up key data to be restored. This should be the output from the &#39;backup/&#39; endpoint..</param>
        /// <param name="force">If set and a key by the given name exists, force the restore operation and override the key. (default to false).</param>
        /// <param name="name">If set, this will be the name of the restored key..</param>
        public TransitRestoreRequest(string backup = default(string), bool force = false, string name = default(string))
        {
            this.Backup = backup;
            this.Force = force;
            this.Name = name;
        }

        /// <summary>
        /// Backed up key data to be restored. This should be the output from the &#39;backup/&#39; endpoint.
        /// </summary>
        /// <value>Backed up key data to be restored. This should be the output from the &#39;backup/&#39; endpoint.</value>
        [DataMember(Name = "backup", EmitDefaultValue = false)]
        public string Backup { get; set; }

        /// <summary>
        /// If set and a key by the given name exists, force the restore operation and override the key.
        /// </summary>
        /// <value>If set and a key by the given name exists, force the restore operation and override the key.</value>
        [DataMember(Name = "force", EmitDefaultValue = true)]
        public bool Force { get; set; }

        /// <summary>
        /// If set, this will be the name of the restored key.
        /// </summary>
        /// <value>If set, this will be the name of the restored key.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransitRestoreRequest {\n");
            sb.Append("  Backup: ").Append(Backup).Append("\n");
            sb.Append("  Force: ").Append(Force).Append("\n");
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
            return this.Equals(input as TransitRestoreRequest);
        }

        /// <summary>
        /// Returns true if TransitRestoreRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransitRestoreRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransitRestoreRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Backup == input.Backup ||
                    (this.Backup != null &&
                    this.Backup.Equals(input.Backup))
                ) && 
                (
                    this.Force == input.Force ||
                    this.Force.Equals(input.Force)
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
                if (this.Backup != null)
                {
                    hashCode = (hashCode * 59) + this.Backup.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Force.GetHashCode();
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
