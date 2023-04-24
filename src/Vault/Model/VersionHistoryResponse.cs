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
    /// VersionHistoryResponse
    /// </summary>
    [DataContract(Name = "VersionHistoryResponse")]
    public partial class VersionHistoryResponse : IEquatable<VersionHistoryResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="VersionHistoryResponse" /> class.
        /// </summary>

        /// <param name="KeyInfo">KeyInfo.</param>

        /// <param name="Keys">Keys.</param>


        public VersionHistoryResponse(Object KeyInfo = default(Object), List<string> Keys = default(List<string>))
        {

            this.KeyInfo = KeyInfo;

            this.Keys = Keys;

        }

        /// <summary>
        /// Gets or Sets KeyInfo
        /// </summary>
        [DataMember(Name = "key_info", EmitDefaultValue = false)]

        public Object KeyInfo { get; set; }


        /// <summary>
        /// Gets or Sets Keys
        /// </summary>
        [DataMember(Name = "keys", EmitDefaultValue = false)]

        public List<string> Keys { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VersionHistoryResponse {\n");
            sb.Append("  KeyInfo: ").Append(KeyInfo).Append("\n");
            sb.Append("  Keys: ").Append(Keys).Append("\n");
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
            return this.Equals(input as VersionHistoryResponse);
        }

        /// <summary>
        /// Returns true if VersionHistoryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of VersionHistoryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VersionHistoryResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.KeyInfo == input.KeyInfo ||
                    (this.KeyInfo != null &&
                    this.KeyInfo.Equals(input.KeyInfo))

                ) &&
                (
                    this.Keys == input.Keys ||
                    this.Keys != null &&
                    input.Keys != null &&
                    this.Keys.SequenceEqual(input.Keys)
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

                if (this.KeyInfo != null)
                {
                    hashCode = (hashCode * 59) + this.KeyInfo.GetHashCode();
                }

                if (this.Keys != null)
                {
                    hashCode = (hashCode * 59) + this.Keys.GetHashCode();
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
