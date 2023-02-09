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
    /// WriteConfigUIHeaderRequest
    /// </summary>
    [DataContract(Name = "WriteConfigUIHeaderRequest")]
    public partial class WriteConfigUIHeaderRequest : IEquatable<WriteConfigUIHeaderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WriteConfigUIHeaderRequest" /> class.
        /// </summary>
        /// <param name="multivalue">Returns multiple values if true.</param>
        /// <param name="values">The values to set the header..</param>
        public WriteConfigUIHeaderRequest(bool multivalue = default(bool), List<string> values = default(List<string>))
        {
            this.Multivalue = multivalue;
            this.Values = values;
        }

        /// <summary>
        /// Returns multiple values if true
        /// </summary>
        /// <value>Returns multiple values if true</value>
        [DataMember(Name = "multivalue", EmitDefaultValue = true)]
        public bool Multivalue { get; set; }

        /// <summary>
        /// The values to set the header.
        /// </summary>
        /// <value>The values to set the header.</value>
        [DataMember(Name = "values", EmitDefaultValue = false)]
        public List<string> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WriteConfigUIHeaderRequest {\n");
            sb.Append("  Multivalue: ").Append(Multivalue).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(input as WriteConfigUIHeaderRequest);
        }

        /// <summary>
        /// Returns true if WriteConfigUIHeaderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WriteConfigUIHeaderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WriteConfigUIHeaderRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Multivalue == input.Multivalue ||
                    this.Multivalue.Equals(input.Multivalue)
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
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
                hashCode = (hashCode * 59) + this.Multivalue.GetHashCode();
                if (this.Values != null)
                {
                    hashCode = (hashCode * 59) + this.Values.GetHashCode();
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
