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
    /// GenerateHashRequest
    /// </summary>
    [DataContract(Name = "GenerateHashRequest")]
    public partial class GenerateHashRequest : IEquatable<GenerateHashRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateHashRequest" /> class.
        /// </summary>

        /// <param name="Algorithm">Algorithm to use (POST body parameter). Valid values are: * sha2-224 * sha2-256 * sha2-384 * sha2-512 Defaults to \&quot;sha2-256\&quot;. (default to &quot;sha2-256&quot;).</param>

        /// <param name="Format">Encoding format to use. Can be \&quot;hex\&quot; or \&quot;base64\&quot;. Defaults to \&quot;hex\&quot;. (default to &quot;hex&quot;).</param>

        /// <param name="Input">The base64-encoded input data.</param>


        public GenerateHashRequest(string Algorithm = "sha2-256", string Format = "hex", string Input = default(string))
        {

            // use default value if no "Algorithm" provided
            this.Algorithm = Algorithm ?? "sha2-256";


            // use default value if no "Format" provided
            this.Format = Format ?? "hex";


            this.Input = Input;

        }

        /// <summary>
        /// Algorithm to use (POST body parameter). Valid values are: * sha2-224 * sha2-256 * sha2-384 * sha2-512 Defaults to \&quot;sha2-256\&quot;.
        /// </summary>
        /// <value>Algorithm to use (POST body parameter). Valid values are: * sha2-224 * sha2-256 * sha2-384 * sha2-512 Defaults to \&quot;sha2-256\&quot;.</value>
        [DataMember(Name = "algorithm", EmitDefaultValue = false)]

        public string Algorithm { get; set; }


        /// <summary>
        /// Encoding format to use. Can be \&quot;hex\&quot; or \&quot;base64\&quot;. Defaults to \&quot;hex\&quot;.
        /// </summary>
        /// <value>Encoding format to use. Can be \&quot;hex\&quot; or \&quot;base64\&quot;. Defaults to \&quot;hex\&quot;.</value>
        [DataMember(Name = "format", EmitDefaultValue = false)]

        public string Format { get; set; }


        /// <summary>
        /// The base64-encoded input data
        /// </summary>
        /// <value>The base64-encoded input data</value>
        [DataMember(Name = "input", EmitDefaultValue = false)]

        public string Input { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GenerateHashRequest {\n");
            sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
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
            return this.Equals(input as GenerateHashRequest);
        }

        /// <summary>
        /// Returns true if GenerateHashRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GenerateHashRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerateHashRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Algorithm == input.Algorithm ||
                    (this.Algorithm != null &&
                    this.Algorithm.Equals(input.Algorithm))

                ) &&
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))

                ) &&
                (
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))

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

                if (this.Algorithm != null)
                {
                    hashCode = (hashCode * 59) + this.Algorithm.GetHashCode();
                }

                if (this.Format != null)
                {
                    hashCode = (hashCode * 59) + this.Format.GetHashCode();
                }

                if (this.Input != null)
                {
                    hashCode = (hashCode * 59) + this.Input.GetHashCode();
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
