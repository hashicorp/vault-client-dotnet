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
    /// RekeyReadBackupKeyResponse
    /// </summary>
    [DataContract(Name = "RekeyReadBackupKeyResponse")]
    public partial class RekeyReadBackupKeyResponse : IEquatable<RekeyReadBackupKeyResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="RekeyReadBackupKeyResponse" /> class.
        /// </summary>

        /// <param name="Keys">Keys.</param>

        /// <param name="KeysBase64">KeysBase64.</param>

        /// <param name="Nonce">Nonce.</param>


        public RekeyReadBackupKeyResponse(Object Keys = default(Object), Object KeysBase64 = default(Object), string Nonce = default(string))
        {

            this.Keys = Keys;

            this.KeysBase64 = KeysBase64;

            this.Nonce = Nonce;

        }

        /// <summary>
        /// Gets or Sets Keys
        /// </summary>
        [DataMember(Name = "keys", EmitDefaultValue = false)]

        public Object Keys { get; set; }


        /// <summary>
        /// Gets or Sets KeysBase64
        /// </summary>
        [DataMember(Name = "keys_base64", EmitDefaultValue = false)]

        public Object KeysBase64 { get; set; }


        /// <summary>
        /// Gets or Sets Nonce
        /// </summary>
        [DataMember(Name = "nonce", EmitDefaultValue = false)]

        public string Nonce { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RekeyReadBackupKeyResponse {\n");
            sb.Append("  Keys: ").Append(Keys).Append("\n");
            sb.Append("  KeysBase64: ").Append(KeysBase64).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
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
            return this.Equals(input as RekeyReadBackupKeyResponse);
        }

        /// <summary>
        /// Returns true if RekeyReadBackupKeyResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RekeyReadBackupKeyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RekeyReadBackupKeyResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Keys == input.Keys ||
                    (this.Keys != null &&
                    this.Keys.Equals(input.Keys))

                ) &&
                (
                    this.KeysBase64 == input.KeysBase64 ||
                    (this.KeysBase64 != null &&
                    this.KeysBase64.Equals(input.KeysBase64))

                ) &&
                (
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))

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

                if (this.Keys != null)
                {
                    hashCode = (hashCode * 59) + this.Keys.GetHashCode();
                }

                if (this.KeysBase64 != null)
                {
                    hashCode = (hashCode * 59) + this.KeysBase64.GetHashCode();
                }

                if (this.Nonce != null)
                {
                    hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
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
