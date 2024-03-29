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
    /// ReadWrappingPropertiesResponse
    /// </summary>
    [DataContract(Name = "ReadWrappingPropertiesResponse")]
    public partial class ReadWrappingPropertiesResponse : IEquatable<ReadWrappingPropertiesResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="ReadWrappingPropertiesResponse" /> class.
        /// </summary>

        /// <param name="CreationPath">CreationPath.</param>

        /// <param name="CreationTime">CreationTime.</param>

        /// <param name="CreationTtl">CreationTtl.</param>


        public ReadWrappingPropertiesResponse(string CreationPath = default(string), DateTime CreationTime = default(DateTime), string CreationTtl = default(string))
        {

            this.CreationPath = CreationPath;

            this.CreationTime = CreationTime;

            this.CreationTtl = CreationTtl;

        }

        /// <summary>
        /// Gets or Sets CreationPath
        /// </summary>
        [DataMember(Name = "creation_path", EmitDefaultValue = false)]

        public string CreationPath { get; set; }


        /// <summary>
        /// Gets or Sets CreationTime
        /// </summary>
        [DataMember(Name = "creation_time", EmitDefaultValue = false)]

        public DateTime CreationTime { get; set; }


        /// <summary>
        /// Gets or Sets CreationTtl
        /// </summary>
        [DataMember(Name = "creation_ttl", EmitDefaultValue = false)]

        public string CreationTtl { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReadWrappingPropertiesResponse {\n");
            sb.Append("  CreationPath: ").Append(CreationPath).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  CreationTtl: ").Append(CreationTtl).Append("\n");
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
            return this.Equals(input as ReadWrappingPropertiesResponse);
        }

        /// <summary>
        /// Returns true if ReadWrappingPropertiesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ReadWrappingPropertiesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReadWrappingPropertiesResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.CreationPath == input.CreationPath ||
                    (this.CreationPath != null &&
                    this.CreationPath.Equals(input.CreationPath))

                ) &&
                (
                    this.CreationTime == input.CreationTime ||
                    (this.CreationTime != null &&
                    this.CreationTime.Equals(input.CreationTime))

                ) &&
                (
                    this.CreationTtl == input.CreationTtl ||
                    (this.CreationTtl != null &&
                    this.CreationTtl.Equals(input.CreationTtl))

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

                if (this.CreationPath != null)
                {
                    hashCode = (hashCode * 59) + this.CreationPath.GetHashCode();
                }

                if (this.CreationTime != null)
                {
                    hashCode = (hashCode * 59) + this.CreationTime.GetHashCode();
                }

                if (this.CreationTtl != null)
                {
                    hashCode = (hashCode * 59) + this.CreationTtl.GetHashCode();
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
