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
    /// KvV2ReadSubkeysResponse
    /// </summary>
    [DataContract(Name = "KvV2ReadSubkeysResponse")]
    public partial class KvV2ReadSubkeysResponse : IEquatable<KvV2ReadSubkeysResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="KvV2ReadSubkeysResponse" /> class.
        /// </summary>

        /// <param name="Metadata">Metadata.</param>

        /// <param name="Subkeys">Subkeys.</param>


        public KvV2ReadSubkeysResponse(Object Metadata = default(Object), Object Subkeys = default(Object))
        {

            this.Metadata = Metadata;

            this.Subkeys = Subkeys;

        }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]

        public Object Metadata { get; set; }


        /// <summary>
        /// Gets or Sets Subkeys
        /// </summary>
        [DataMember(Name = "subkeys", EmitDefaultValue = false)]

        public Object Subkeys { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KvV2ReadSubkeysResponse {\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Subkeys: ").Append(Subkeys).Append("\n");
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
            return this.Equals(input as KvV2ReadSubkeysResponse);
        }

        /// <summary>
        /// Returns true if KvV2ReadSubkeysResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of KvV2ReadSubkeysResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KvV2ReadSubkeysResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))

                ) &&
                (
                    this.Subkeys == input.Subkeys ||
                    (this.Subkeys != null &&
                    this.Subkeys.Equals(input.Subkeys))

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

                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }

                if (this.Subkeys != null)
                {
                    hashCode = (hashCode * 59) + this.Subkeys.GetHashCode();
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
