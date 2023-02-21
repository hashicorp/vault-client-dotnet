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
    /// TransitDecryptRequest
    /// </summary>
    [DataContract(Name = "TransitDecryptRequest")]
    public partial class TransitDecryptRequest : IEquatable<TransitDecryptRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransitDecryptRequest" /> class.
        /// </summary>
        /// <param name="associatedData">When using an AEAD cipher mode, such as AES-GCM, this parameter allows passing associated data (AD/AAD) into the encryption function; this data must be passed on subsequent decryption requests but can be transited in plaintext. On successful decryption, both the ciphertext and the associated data are attested not to have been tampered with..</param>
        /// <param name="ciphertext">The ciphertext to decrypt, provided as returned by encrypt..</param>
        /// <param name="context">Base64 encoded context for key derivation. Required if key derivation is enabled..</param>
        /// <param name="nonce">Base64 encoded nonce value used during encryption. Must be provided if convergent encryption is enabled for this key and the key was generated with Vault 0.6.1. Not required for keys created in 0.6.2+..</param>
        /// <param name="partialFailureResponseCode">Ordinarily, if a batch item fails to decrypt due to a bad input, but other batch items succeed, the HTTP response code is 400 (Bad Request). Some applications may want to treat partial failures differently. Providing the parameter returns the given response code integer instead of a 400 in this case. If all values fail HTTP 400 is still returned..</param>
        public TransitDecryptRequest(string associatedData = default(string), string ciphertext = default(string), string context = default(string), string nonce = default(string), int partialFailureResponseCode = default(int))
        {
            this.AssociatedData = associatedData;
            this.Ciphertext = ciphertext;
            this.Context = context;
            this.Nonce = nonce;
            this.PartialFailureResponseCode = partialFailureResponseCode;
        }

        /// <summary>
        /// When using an AEAD cipher mode, such as AES-GCM, this parameter allows passing associated data (AD/AAD) into the encryption function; this data must be passed on subsequent decryption requests but can be transited in plaintext. On successful decryption, both the ciphertext and the associated data are attested not to have been tampered with.
        /// </summary>
        /// <value>When using an AEAD cipher mode, such as AES-GCM, this parameter allows passing associated data (AD/AAD) into the encryption function; this data must be passed on subsequent decryption requests but can be transited in plaintext. On successful decryption, both the ciphertext and the associated data are attested not to have been tampered with.</value>
        [DataMember(Name = "associated_data", EmitDefaultValue = false)]
        public string AssociatedData { get; set; }

        /// <summary>
        /// The ciphertext to decrypt, provided as returned by encrypt.
        /// </summary>
        /// <value>The ciphertext to decrypt, provided as returned by encrypt.</value>
        [DataMember(Name = "ciphertext", EmitDefaultValue = false)]
        public string Ciphertext { get; set; }

        /// <summary>
        /// Base64 encoded context for key derivation. Required if key derivation is enabled.
        /// </summary>
        /// <value>Base64 encoded context for key derivation. Required if key derivation is enabled.</value>
        [DataMember(Name = "context", EmitDefaultValue = false)]
        public string Context { get; set; }

        /// <summary>
        /// Base64 encoded nonce value used during encryption. Must be provided if convergent encryption is enabled for this key and the key was generated with Vault 0.6.1. Not required for keys created in 0.6.2+.
        /// </summary>
        /// <value>Base64 encoded nonce value used during encryption. Must be provided if convergent encryption is enabled for this key and the key was generated with Vault 0.6.1. Not required for keys created in 0.6.2+.</value>
        [DataMember(Name = "nonce", EmitDefaultValue = false)]
        public string Nonce { get; set; }

        /// <summary>
        /// Ordinarily, if a batch item fails to decrypt due to a bad input, but other batch items succeed, the HTTP response code is 400 (Bad Request). Some applications may want to treat partial failures differently. Providing the parameter returns the given response code integer instead of a 400 in this case. If all values fail HTTP 400 is still returned.
        /// </summary>
        /// <value>Ordinarily, if a batch item fails to decrypt due to a bad input, but other batch items succeed, the HTTP response code is 400 (Bad Request). Some applications may want to treat partial failures differently. Providing the parameter returns the given response code integer instead of a 400 in this case. If all values fail HTTP 400 is still returned.</value>
        [DataMember(Name = "partial_failure_response_code", EmitDefaultValue = false)]
        public int PartialFailureResponseCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransitDecryptRequest {\n");
            sb.Append("  AssociatedData: ").Append(AssociatedData).Append("\n");
            sb.Append("  Ciphertext: ").Append(Ciphertext).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  PartialFailureResponseCode: ").Append(PartialFailureResponseCode).Append("\n");
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
            return this.Equals(input as TransitDecryptRequest);
        }

        /// <summary>
        /// Returns true if TransitDecryptRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransitDecryptRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransitDecryptRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AssociatedData == input.AssociatedData ||
                    (this.AssociatedData != null &&
                    this.AssociatedData.Equals(input.AssociatedData))
                ) &&
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
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))
                ) &&
                (
                    this.PartialFailureResponseCode == input.PartialFailureResponseCode ||
                    this.PartialFailureResponseCode.Equals(input.PartialFailureResponseCode)
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
                if (this.AssociatedData != null)
                {
                    hashCode = (hashCode * 59) + this.AssociatedData.GetHashCode();
                }
                if (this.Ciphertext != null)
                {
                    hashCode = (hashCode * 59) + this.Ciphertext.GetHashCode();
                }
                if (this.Context != null)
                {
                    hashCode = (hashCode * 59) + this.Context.GetHashCode();
                }
                if (this.Nonce != null)
                {
                    hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PartialFailureResponseCode.GetHashCode();
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
