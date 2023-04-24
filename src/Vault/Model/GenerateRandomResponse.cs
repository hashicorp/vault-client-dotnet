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
    /// GenerateRandomResponse
    /// </summary>
    [DataContract(Name = "GenerateRandomResponse")]
    public partial class GenerateRandomResponse : IEquatable<GenerateRandomResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRandomResponse" /> class.
        /// </summary>

        /// <param name="RandomBytes">RandomBytes.</param>


        public GenerateRandomResponse(string RandomBytes = default(string))
        {

            this.RandomBytes = RandomBytes;

        }

        /// <summary>
        /// Gets or Sets RandomBytes
        /// </summary>
        [DataMember(Name = "random_bytes", EmitDefaultValue = false)]

        public string RandomBytes { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GenerateRandomResponse {\n");
            sb.Append("  RandomBytes: ").Append(RandomBytes).Append("\n");
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
            return this.Equals(input as GenerateRandomResponse);
        }

        /// <summary>
        /// Returns true if GenerateRandomResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GenerateRandomResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerateRandomResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.RandomBytes == input.RandomBytes ||
                    (this.RandomBytes != null &&
                    this.RandomBytes.Equals(input.RandomBytes))

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

                if (this.RandomBytes != null)
                {
                    hashCode = (hashCode * 59) + this.RandomBytes.GetHashCode();
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
