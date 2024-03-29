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
    /// GithubWriteUserMappingRequest
    /// </summary>
    [DataContract(Name = "GithubWriteUserMappingRequest")]
    public partial class GithubWriteUserMappingRequest : IEquatable<GithubWriteUserMappingRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="GithubWriteUserMappingRequest" /> class.
        /// </summary>

        /// <param name="Value">Value for users mapping.</param>


        public GithubWriteUserMappingRequest(string Value = default(string))
        {

            this.Value = Value;

        }

        /// <summary>
        /// Value for users mapping
        /// </summary>
        /// <value>Value for users mapping</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]

        public string Value { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GithubWriteUserMappingRequest {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as GithubWriteUserMappingRequest);
        }

        /// <summary>
        /// Returns true if GithubWriteUserMappingRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GithubWriteUserMappingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GithubWriteUserMappingRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))

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

                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
