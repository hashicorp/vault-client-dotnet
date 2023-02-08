// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

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
    /// TransitEncryptRequest
    /// </summary>
    [DataContract(Name = "TransitEncryptRequest")]
    public partial class TransitEncryptRequest : IEquatable<TransitEncryptRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransitEncryptRequest" /> class.
        /// </summary>
        /// <param name="associatedData">When using an AEAD cipher mode, such as AES-GCM, this parameter allows passing associated data (AD/AAD) into the encryption function; this data must be passed on subsequent decryption requests but can be transited in plaintext. On successful decryption, both the ciphertext and the associated data are attested not to have been tampered with..</param>
        /// <param name="context">Base64 encoded context for key derivation. Required if key derivation is enabled.</param>
        /// <param name="convergentEncryption">This parameter will only be used when a key is expected to be created. Whether to support convergent encryption. This is only supported when using a key with key derivation enabled and will require all requests to carry both a context and 96-bit (12-byte) nonce. The given nonce will be used in place of a randomly generated nonce. As a result, when the same context and nonce are supplied, the same ciphertext is generated. It is *very important* when using this mode that you ensure that all nonces are unique for a given context. Failing to do so will severely impact the ciphertext&#39;s security..</param>
        /// <param name="keyVersion">The version of the key to use for encryption. Must be 0 (for latest) or a value greater than or equal to the min_encryption_version configured on the key..</param>
        /// <param name="nonce">Base64 encoded nonce value. Must be provided if convergent encryption is enabled for this key and the key was generated with Vault 0.6.1. Not required for keys created in 0.6.2+. The value must be exactly 96 bits (12 bytes) long and the user must ensure that for any given context (and thus, any given encryption key) this nonce value is **never reused**..</param>
        /// <param name="partialFailureResponseCode">Ordinarily, if a batch item fails to encrypt due to a bad input, but other batch items succeed, the HTTP response code is 400 (Bad Request). Some applications may want to treat partial failures differently. Providing the parameter returns the given response code integer instead of a 400 in this case. If all values fail HTTP 400 is still returned..</param>
        /// <param name="plaintext">Base64 encoded plaintext value to be encrypted.</param>
        /// <param name="type">This parameter is required when encryption key is expected to be created. When performing an upsert operation, the type of key to create. Currently, \&quot;aes128-gcm96\&quot; (symmetric) and \&quot;aes256-gcm96\&quot; (symmetric) are the only types supported. Defaults to \&quot;aes256-gcm96\&quot;. (default to &quot;aes256-gcm96&quot;).</param>
        public TransitEncryptRequest(string associatedData = default(string), string context = default(string), bool convergentEncryption = default(bool), int keyVersion = default(int), string nonce = default(string), int partialFailureResponseCode = default(int), string plaintext = default(string), string type = "aes256-gcm96")
        {
            this.AssociatedData = associatedData;
            this.Context = context;
            this.ConvergentEncryption = convergentEncryption;
            this.KeyVersion = keyVersion;
            this.Nonce = nonce;
            this.PartialFailureResponseCode = partialFailureResponseCode;
            this.Plaintext = plaintext;
            // use default value if no "type" provided
            this.Type = type ?? "aes256-gcm96";
        }

        /// <summary>
        /// When using an AEAD cipher mode, such as AES-GCM, this parameter allows passing associated data (AD/AAD) into the encryption function; this data must be passed on subsequent decryption requests but can be transited in plaintext. On successful decryption, both the ciphertext and the associated data are attested not to have been tampered with.
        /// </summary>
        /// <value>When using an AEAD cipher mode, such as AES-GCM, this parameter allows passing associated data (AD/AAD) into the encryption function; this data must be passed on subsequent decryption requests but can be transited in plaintext. On successful decryption, both the ciphertext and the associated data are attested not to have been tampered with.</value>
        [DataMember(Name = "associated_data", EmitDefaultValue = false)]
        public string AssociatedData { get; set; }

        /// <summary>
        /// Base64 encoded context for key derivation. Required if key derivation is enabled
        /// </summary>
        /// <value>Base64 encoded context for key derivation. Required if key derivation is enabled</value>
        [DataMember(Name = "context", EmitDefaultValue = false)]
        public string Context { get; set; }

        /// <summary>
        /// This parameter will only be used when a key is expected to be created. Whether to support convergent encryption. This is only supported when using a key with key derivation enabled and will require all requests to carry both a context and 96-bit (12-byte) nonce. The given nonce will be used in place of a randomly generated nonce. As a result, when the same context and nonce are supplied, the same ciphertext is generated. It is *very important* when using this mode that you ensure that all nonces are unique for a given context. Failing to do so will severely impact the ciphertext&#39;s security.
        /// </summary>
        /// <value>This parameter will only be used when a key is expected to be created. Whether to support convergent encryption. This is only supported when using a key with key derivation enabled and will require all requests to carry both a context and 96-bit (12-byte) nonce. The given nonce will be used in place of a randomly generated nonce. As a result, when the same context and nonce are supplied, the same ciphertext is generated. It is *very important* when using this mode that you ensure that all nonces are unique for a given context. Failing to do so will severely impact the ciphertext&#39;s security.</value>
        [DataMember(Name = "convergent_encryption", EmitDefaultValue = true)]
        public bool ConvergentEncryption { get; set; }

        /// <summary>
        /// The version of the key to use for encryption. Must be 0 (for latest) or a value greater than or equal to the min_encryption_version configured on the key.
        /// </summary>
        /// <value>The version of the key to use for encryption. Must be 0 (for latest) or a value greater than or equal to the min_encryption_version configured on the key.</value>
        [DataMember(Name = "key_version", EmitDefaultValue = false)]
        public int KeyVersion { get; set; }

        /// <summary>
        /// Base64 encoded nonce value. Must be provided if convergent encryption is enabled for this key and the key was generated with Vault 0.6.1. Not required for keys created in 0.6.2+. The value must be exactly 96 bits (12 bytes) long and the user must ensure that for any given context (and thus, any given encryption key) this nonce value is **never reused**.
        /// </summary>
        /// <value>Base64 encoded nonce value. Must be provided if convergent encryption is enabled for this key and the key was generated with Vault 0.6.1. Not required for keys created in 0.6.2+. The value must be exactly 96 bits (12 bytes) long and the user must ensure that for any given context (and thus, any given encryption key) this nonce value is **never reused**.</value>
        [DataMember(Name = "nonce", EmitDefaultValue = false)]
        public string Nonce { get; set; }

        /// <summary>
        /// Ordinarily, if a batch item fails to encrypt due to a bad input, but other batch items succeed, the HTTP response code is 400 (Bad Request). Some applications may want to treat partial failures differently. Providing the parameter returns the given response code integer instead of a 400 in this case. If all values fail HTTP 400 is still returned.
        /// </summary>
        /// <value>Ordinarily, if a batch item fails to encrypt due to a bad input, but other batch items succeed, the HTTP response code is 400 (Bad Request). Some applications may want to treat partial failures differently. Providing the parameter returns the given response code integer instead of a 400 in this case. If all values fail HTTP 400 is still returned.</value>
        [DataMember(Name = "partial_failure_response_code", EmitDefaultValue = false)]
        public int PartialFailureResponseCode { get; set; }

        /// <summary>
        /// Base64 encoded plaintext value to be encrypted
        /// </summary>
        /// <value>Base64 encoded plaintext value to be encrypted</value>
        [DataMember(Name = "plaintext", EmitDefaultValue = false)]
        public string Plaintext { get; set; }

        /// <summary>
        /// This parameter is required when encryption key is expected to be created. When performing an upsert operation, the type of key to create. Currently, \&quot;aes128-gcm96\&quot; (symmetric) and \&quot;aes256-gcm96\&quot; (symmetric) are the only types supported. Defaults to \&quot;aes256-gcm96\&quot;.
        /// </summary>
        /// <value>This parameter is required when encryption key is expected to be created. When performing an upsert operation, the type of key to create. Currently, \&quot;aes128-gcm96\&quot; (symmetric) and \&quot;aes256-gcm96\&quot; (symmetric) are the only types supported. Defaults to \&quot;aes256-gcm96\&quot;.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransitEncryptRequest {\n");
            sb.Append("  AssociatedData: ").Append(AssociatedData).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  ConvergentEncryption: ").Append(ConvergentEncryption).Append("\n");
            sb.Append("  KeyVersion: ").Append(KeyVersion).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  PartialFailureResponseCode: ").Append(PartialFailureResponseCode).Append("\n");
            sb.Append("  Plaintext: ").Append(Plaintext).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as TransitEncryptRequest);
        }

        /// <summary>
        /// Returns true if TransitEncryptRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransitEncryptRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransitEncryptRequest input)
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
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.ConvergentEncryption == input.ConvergentEncryption ||
                    this.ConvergentEncryption.Equals(input.ConvergentEncryption)
                ) && 
                (
                    this.KeyVersion == input.KeyVersion ||
                    this.KeyVersion.Equals(input.KeyVersion)
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))
                ) && 
                (
                    this.PartialFailureResponseCode == input.PartialFailureResponseCode ||
                    this.PartialFailureResponseCode.Equals(input.PartialFailureResponseCode)
                ) && 
                (
                    this.Plaintext == input.Plaintext ||
                    (this.Plaintext != null &&
                    this.Plaintext.Equals(input.Plaintext))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Context != null)
                {
                    hashCode = (hashCode * 59) + this.Context.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ConvergentEncryption.GetHashCode();
                hashCode = (hashCode * 59) + this.KeyVersion.GetHashCode();
                if (this.Nonce != null)
                {
                    hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PartialFailureResponseCode.GetHashCode();
                if (this.Plaintext != null)
                {
                    hashCode = (hashCode * 59) + this.Plaintext.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
