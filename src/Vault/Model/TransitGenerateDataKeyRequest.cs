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
    /// TransitGenerateDataKeyRequest
    /// </summary>
    [DataContract(Name = "TransitGenerateDataKeyRequest")]
    public partial class TransitGenerateDataKeyRequest : IEquatable<TransitGenerateDataKeyRequest>, IValidatableObject
    {











        /// <summary>
        /// Initializes a new instance of the <see cref="TransitGenerateDataKeyRequest" /> class.
        /// </summary>

        /// <param name="Bits">Number of bits for the key; currently 128, 256, and 512 bits are supported. Defaults to 256. (default to 256).</param>

        /// <param name="Context">Context for key derivation. Required for derived keys..</param>

        /// <param name="KeyVersion">The version of the Vault key to use for encryption of the data key. Must be 0 (for latest) or a value greater than or equal to the min_encryption_version configured on the key..</param>

        /// <param name="Nonce">Nonce for when convergent encryption v1 is used (only in Vault 0.6.1).</param>


        public TransitGenerateDataKeyRequest(int Bits = 256, string Context = default(string), int KeyVersion = default(int), string Nonce = default(string))
        {

            this.Bits = Bits;

            this.Context = Context;

            this.KeyVersion = KeyVersion;

            this.Nonce = Nonce;

        }

        /// <summary>
        /// Number of bits for the key; currently 128, 256, and 512 bits are supported. Defaults to 256.
        /// </summary>
        /// <value>Number of bits for the key; currently 128, 256, and 512 bits are supported. Defaults to 256.</value>
        [DataMember(Name = "bits", EmitDefaultValue = false)]


        public int Bits { get; set; }


        /// <summary>
        /// Context for key derivation. Required for derived keys.
        /// </summary>
        /// <value>Context for key derivation. Required for derived keys.</value>
        [DataMember(Name = "context", EmitDefaultValue = false)]


        public string Context { get; set; }


        /// <summary>
        /// The version of the Vault key to use for encryption of the data key. Must be 0 (for latest) or a value greater than or equal to the min_encryption_version configured on the key.
        /// </summary>
        /// <value>The version of the Vault key to use for encryption of the data key. Must be 0 (for latest) or a value greater than or equal to the min_encryption_version configured on the key.</value>
        [DataMember(Name = "key_version", EmitDefaultValue = false)]


        public int KeyVersion { get; set; }


        /// <summary>
        /// Nonce for when convergent encryption v1 is used (only in Vault 0.6.1)
        /// </summary>
        /// <value>Nonce for when convergent encryption v1 is used (only in Vault 0.6.1)</value>
        [DataMember(Name = "nonce", EmitDefaultValue = false)]


        public string Nonce { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransitGenerateDataKeyRequest {\n");
            sb.Append("  Bits: ").Append(Bits).Append("\n");
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
            return this.Equals(input as TransitGenerateDataKeyRequest);
        }

        /// <summary>
        /// Returns true if TransitGenerateDataKeyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransitGenerateDataKeyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransitGenerateDataKeyRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Bits == input.Bits ||

                    this.Bits.Equals(input.Bits)
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


                hashCode = (hashCode * 59) + this.Bits.GetHashCode();
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
