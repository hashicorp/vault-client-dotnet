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
    /// TransitRewrapRequest
    /// </summary>
    [DataContract(Name = "TransitRewrapRequest")]

    public partial class TransitRewrapRequest : IEquatable<TransitRewrapRequest>, IValidatableObject
    {











        /// <summary>
        /// Initializes a new instance of the <see cref="TransitRewrapRequest" /> class.
        /// </summary>

        /// <param name="Ciphertext">Ciphertext value to rewrap.</param>

        /// <param name="Context">Base64 encoded context for key derivation. Required for derived keys..</param>

        /// <param name="KeyVersion">The version of the key to use for encryption. Must be 0 (for latest) or a value greater than or equal to the min_encryption_version configured on the key..</param>

        /// <param name="Nonce">Nonce for when convergent encryption is used.</param>


        public TransitRewrapRequest(string Ciphertext = default(string), string Context = default(string), int KeyVersion = default(int), string Nonce = default(string))
        {

            this.Ciphertext = Ciphertext;

            this.Context = Context;

            this.KeyVersion = KeyVersion;

            this.Nonce = Nonce;

        }

        /// <summary>
        /// Ciphertext value to rewrap
        /// </summary>
        /// <value>Ciphertext value to rewrap</value>
        [DataMember(Name = "ciphertext", EmitDefaultValue = false)]


        public string Ciphertext { get; set; }


        /// <summary>
        /// Base64 encoded context for key derivation. Required for derived keys.
        /// </summary>
        /// <value>Base64 encoded context for key derivation. Required for derived keys.</value>
        [DataMember(Name = "context", EmitDefaultValue = false)]


        public string Context { get; set; }


        /// <summary>
        /// The version of the key to use for encryption. Must be 0 (for latest) or a value greater than or equal to the min_encryption_version configured on the key.
        /// </summary>
        /// <value>The version of the key to use for encryption. Must be 0 (for latest) or a value greater than or equal to the min_encryption_version configured on the key.</value>
        [DataMember(Name = "key_version", EmitDefaultValue = false)]


        public int KeyVersion { get; set; }


        /// <summary>
        /// Nonce for when convergent encryption is used
        /// </summary>
        /// <value>Nonce for when convergent encryption is used</value>
        [DataMember(Name = "nonce", EmitDefaultValue = false)]


        public string Nonce { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransitRewrapRequest {\n");
            sb.Append("  Ciphertext: ").Append(Ciphertext).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  KeyVersion: ").Append(KeyVersion).Append("\n");
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
            return this.Equals(input as TransitRewrapRequest);
        }

        /// <summary>
        /// Returns true if TransitRewrapRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransitRewrapRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransitRewrapRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Ciphertext == input.Ciphertext ||
                    (this.Ciphertext != null &&
                    this.Ciphertext.Equals(input.Ciphertext))

                ) &&
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))

                ) &&
                (
                    this.KeyVersion == input.KeyVersion ||

                    this.KeyVersion.Equals(input.KeyVersion)
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

                if (this.Ciphertext != null)
                {
                    hashCode = (hashCode * 59) + this.Ciphertext.GetHashCode();
                }

                if (this.Context != null)
                {
                    hashCode = (hashCode * 59) + this.Context.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.KeyVersion.GetHashCode();
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
