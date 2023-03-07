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
    /// TransitGenerateHMACWithAlgorithmRequest
    /// </summary>
    [DataContract(Name = "TransitGenerateHMACWithAlgorithmRequest")]

    public partial class TransitGenerateHMACWithAlgorithmRequest : IEquatable<TransitGenerateHMACWithAlgorithmRequest>, IValidatableObject
    {









        /// <summary>
        /// Initializes a new instance of the <see cref="TransitGenerateHMACWithAlgorithmRequest" /> class.
        /// </summary>

        /// <param name="Algorithm">Algorithm to use (POST body parameter). Valid values are: * sha2-224 * sha2-256 * sha2-384 * sha2-512 * sha3-224 * sha3-256 * sha3-384 * sha3-512 Defaults to \&quot;sha2-256\&quot;. (default to &quot;sha2-256&quot;).</param>

        /// <param name="Input">The base64-encoded input data.</param>

        /// <param name="KeyVersion">The version of the key to use for generating the HMAC. Must be 0 (for latest) or a value greater than or equal to the min_encryption_version configured on the key..</param>


        public TransitGenerateHMACWithAlgorithmRequest(string Algorithm = "sha2-256", string Input = default(string), int KeyVersion = default(int))
        {

            // use default value if no "Algorithm" provided
            this.Algorithm = Algorithm ?? "sha2-256";


            this.Input = Input;

            this.KeyVersion = KeyVersion;

        }

        /// <summary>
        /// Algorithm to use (POST body parameter). Valid values are: * sha2-224 * sha2-256 * sha2-384 * sha2-512 * sha3-224 * sha3-256 * sha3-384 * sha3-512 Defaults to \&quot;sha2-256\&quot;.
        /// </summary>
        /// <value>Algorithm to use (POST body parameter). Valid values are: * sha2-224 * sha2-256 * sha2-384 * sha2-512 * sha3-224 * sha3-256 * sha3-384 * sha3-512 Defaults to \&quot;sha2-256\&quot;.</value>
        [DataMember(Name = "algorithm", EmitDefaultValue = false)]


        public string Algorithm { get; set; }


        /// <summary>
        /// The base64-encoded input data
        /// </summary>
        /// <value>The base64-encoded input data</value>
        [DataMember(Name = "input", EmitDefaultValue = false)]


        public string Input { get; set; }


        /// <summary>
        /// The version of the key to use for generating the HMAC. Must be 0 (for latest) or a value greater than or equal to the min_encryption_version configured on the key.
        /// </summary>
        /// <value>The version of the key to use for generating the HMAC. Must be 0 (for latest) or a value greater than or equal to the min_encryption_version configured on the key.</value>
        [DataMember(Name = "key_version", EmitDefaultValue = false)]


        public int KeyVersion { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransitGenerateHMACWithAlgorithmRequest {\n");
            sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  KeyVersion: ").Append(KeyVersion).Append("\n");
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
            return this.Equals(input as TransitGenerateHMACWithAlgorithmRequest);
        }

        /// <summary>
        /// Returns true if TransitGenerateHMACWithAlgorithmRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransitGenerateHMACWithAlgorithmRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransitGenerateHMACWithAlgorithmRequest input)
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
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))

                ) &&
                (
                    this.KeyVersion == input.KeyVersion ||

                    this.KeyVersion.Equals(input.KeyVersion)
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

                if (this.Input != null)
                {
                    hashCode = (hashCode * 59) + this.Input.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.KeyVersion.GetHashCode();
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
