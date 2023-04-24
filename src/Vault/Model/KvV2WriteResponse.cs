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
    /// KvV2WriteResponse
    /// </summary>
    [DataContract(Name = "KvV2WriteResponse")]
    public partial class KvV2WriteResponse : IEquatable<KvV2WriteResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="KvV2WriteResponse" /> class.
        /// </summary>

        /// <param name="CreatedTime">CreatedTime.</param>

        /// <param name="CustomMetadata">CustomMetadata.</param>

        /// <param name="DeletionTime">DeletionTime.</param>

        /// <param name="Destroyed">Destroyed.</param>

        /// <param name="_Version">_Version.</param>


        public KvV2WriteResponse(DateTime CreatedTime = default(DateTime), Object CustomMetadata = default(Object), string DeletionTime = default(string), bool Destroyed = default(bool), long _Version = default(long))
        {

            this.CreatedTime = CreatedTime;

            this.CustomMetadata = CustomMetadata;

            this.DeletionTime = DeletionTime;

            this.Destroyed = Destroyed;

            this._Version = _Version;

        }

        /// <summary>
        /// Gets or Sets CreatedTime
        /// </summary>
        [DataMember(Name = "created_time", EmitDefaultValue = false)]

        public DateTime CreatedTime { get; set; }


        /// <summary>
        /// Gets or Sets CustomMetadata
        /// </summary>
        [DataMember(Name = "custom_metadata", EmitDefaultValue = false)]

        public Object CustomMetadata { get; set; }


        /// <summary>
        /// Gets or Sets DeletionTime
        /// </summary>
        [DataMember(Name = "deletion_time", EmitDefaultValue = false)]

        public string DeletionTime { get; set; }


        /// <summary>
        /// Gets or Sets Destroyed
        /// </summary>
        [DataMember(Name = "destroyed", EmitDefaultValue = true)]

        public bool Destroyed { get; set; }


        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]

        public long _Version { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KvV2WriteResponse {\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  CustomMetadata: ").Append(CustomMetadata).Append("\n");
            sb.Append("  DeletionTime: ").Append(DeletionTime).Append("\n");
            sb.Append("  Destroyed: ").Append(Destroyed).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
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
            return this.Equals(input as KvV2WriteResponse);
        }

        /// <summary>
        /// Returns true if KvV2WriteResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of KvV2WriteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KvV2WriteResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))

                ) &&
                (
                    this.CustomMetadata == input.CustomMetadata ||
                    (this.CustomMetadata != null &&
                    this.CustomMetadata.Equals(input.CustomMetadata))

                ) &&
                (
                    this.DeletionTime == input.DeletionTime ||
                    (this.DeletionTime != null &&
                    this.DeletionTime.Equals(input.DeletionTime))

                ) &&
                (
                    this.Destroyed == input.Destroyed ||

                    this.Destroyed.Equals(input.Destroyed)
                ) &&
                (
                    this._Version == input._Version ||

                    this._Version.Equals(input._Version)
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

                if (this.CreatedTime != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedTime.GetHashCode();
                }

                if (this.CustomMetadata != null)
                {
                    hashCode = (hashCode * 59) + this.CustomMetadata.GetHashCode();
                }

                if (this.DeletionTime != null)
                {
                    hashCode = (hashCode * 59) + this.DeletionTime.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Destroyed.GetHashCode();

                hashCode = (hashCode * 59) + this._Version.GetHashCode();
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
