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
    /// UnsealRequest
    /// </summary>
    [DataContract(Name = "UnsealRequest")]
    public partial class UnsealRequest : IEquatable<UnsealRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnsealRequest" /> class.
        /// </summary>
        /// <param name="key">Specifies a single unseal key share. This is required unless reset is true..</param>
        /// <param name="reset">Specifies if previously-provided unseal keys are discarded and the unseal process is reset..</param>
        public UnsealRequest(string key = default(string), bool reset = default(bool))
        {
            this.Key = key;
            this.Reset = reset;
        }

        /// <summary>
        /// Specifies a single unseal key share. This is required unless reset is true.
        /// </summary>
        /// <value>Specifies a single unseal key share. This is required unless reset is true.</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Specifies if previously-provided unseal keys are discarded and the unseal process is reset.
        /// </summary>
        /// <value>Specifies if previously-provided unseal keys are discarded and the unseal process is reset.</value>
        [DataMember(Name = "reset", EmitDefaultValue = true)]
        public bool Reset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UnsealRequest {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Reset: ").Append(Reset).Append("\n");
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
            return this.Equals(input as UnsealRequest);
        }

        /// <summary>
        /// Returns true if UnsealRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UnsealRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnsealRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) &&
                (
                    this.Reset == input.Reset ||
                    this.Reset.Equals(input.Reset)
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
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Reset.GetHashCode();
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
