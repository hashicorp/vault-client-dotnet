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
    /// TransitWriteKeyRequest
    /// </summary>
    [DataContract(Name = "TransitWriteKeyRequest")]
    public partial class TransitWriteKeyRequest : IEquatable<TransitWriteKeyRequest>, IValidatableObject
    {










        /// <summary>
        /// Initializes a new instance of the <see cref="TransitWriteKeyRequest" /> class.
        /// </summary>

        /// <param name="AllowPlaintextBackup">Enables taking a backup of the named key in plaintext format. Once set, this cannot be disabled..</param>

        /// <param name="AutoRotatePeriod">Amount of time the key should live before being automatically rotated. A value of 0 (default) disables automatic rotation for the key. (default to 0).</param>

        /// <param name="Context">Base64 encoded context for key derivation. When reading a key with key derivation enabled, if the key type supports public keys, this will return the public key for the given context..</param>

        /// <param name="ConvergentEncryption">Whether to support convergent encryption. This is only supported when using a key with key derivation enabled and will require all requests to carry both a context and 96-bit (12-byte) nonce. The given nonce will be used in place of a randomly generated nonce. As a result, when the same context and nonce are supplied, the same ciphertext is generated. It is *very important* when using this mode that you ensure that all nonces are unique for a given context. Failing to do so will severely impact the ciphertext&#x27;s security..</param>

        /// <param name="Derived">Enables key derivation mode. This allows for per-transaction unique keys for encryption operations..</param>

        /// <param name="Exportable">Enables keys to be exportable. This allows for all the valid keys in the key ring to be exported..</param>

        /// <param name="KeySize">The key size in bytes for the algorithm. Only applies to HMAC and must be no fewer than 32 bytes and no more than 512 (default to 0).</param>

        /// <param name="Type">The type of key to create. Currently, \&quot;aes128-gcm96\&quot; (symmetric), \&quot;aes256-gcm96\&quot; (symmetric), \&quot;ecdsa-p256\&quot; (asymmetric), \&quot;ecdsa-p384\&quot; (asymmetric), \&quot;ecdsa-p521\&quot; (asymmetric), \&quot;ed25519\&quot; (asymmetric), \&quot;rsa-2048\&quot; (asymmetric), \&quot;rsa-3072\&quot; (asymmetric), \&quot;rsa-4096\&quot; (asymmetric) are supported. Defaults to \&quot;aes256-gcm96\&quot;. (default to &quot;aes256-gcm96&quot;).</param>


        public TransitWriteKeyRequest(bool AllowPlaintextBackup = default(bool), int AutoRotatePeriod = 0, string Context = default(string), bool ConvergentEncryption = default(bool), bool Derived = default(bool), bool Exportable = default(bool), int KeySize = 0, string Type = "aes256-gcm96")
        {

            this.AllowPlaintextBackup = AllowPlaintextBackup;

            this.AutoRotatePeriod = AutoRotatePeriod;

            this.Context = Context;

            this.ConvergentEncryption = ConvergentEncryption;

            this.Derived = Derived;

            this.Exportable = Exportable;

            this.KeySize = KeySize;

            // use default value if no "Type" provided
            this.Type = Type ?? "aes256-gcm96";


        }

        /// <summary>
        /// Enables taking a backup of the named key in plaintext format. Once set, this cannot be disabled.
        /// </summary>
        /// <value>Enables taking a backup of the named key in plaintext format. Once set, this cannot be disabled.</value>
        [DataMember(Name = "allow_plaintext_backup", EmitDefaultValue = true)]

        public bool AllowPlaintextBackup { get; set; }


        /// <summary>
        /// Amount of time the key should live before being automatically rotated. A value of 0 (default) disables automatic rotation for the key.
        /// </summary>
        /// <value>Amount of time the key should live before being automatically rotated. A value of 0 (default) disables automatic rotation for the key.</value>
        [DataMember(Name = "auto_rotate_period", EmitDefaultValue = false)]

        public int AutoRotatePeriod { get; set; }


        /// <summary>
        /// Base64 encoded context for key derivation. When reading a key with key derivation enabled, if the key type supports public keys, this will return the public key for the given context.
        /// </summary>
        /// <value>Base64 encoded context for key derivation. When reading a key with key derivation enabled, if the key type supports public keys, this will return the public key for the given context.</value>
        [DataMember(Name = "context", EmitDefaultValue = false)]

        public string Context { get; set; }


        /// <summary>
        /// Whether to support convergent encryption. This is only supported when using a key with key derivation enabled and will require all requests to carry both a context and 96-bit (12-byte) nonce. The given nonce will be used in place of a randomly generated nonce. As a result, when the same context and nonce are supplied, the same ciphertext is generated. It is *very important* when using this mode that you ensure that all nonces are unique for a given context. Failing to do so will severely impact the ciphertext&#x27;s security.
        /// </summary>
        /// <value>Whether to support convergent encryption. This is only supported when using a key with key derivation enabled and will require all requests to carry both a context and 96-bit (12-byte) nonce. The given nonce will be used in place of a randomly generated nonce. As a result, when the same context and nonce are supplied, the same ciphertext is generated. It is *very important* when using this mode that you ensure that all nonces are unique for a given context. Failing to do so will severely impact the ciphertext&#x27;s security.</value>
        [DataMember(Name = "convergent_encryption", EmitDefaultValue = true)]

        public bool ConvergentEncryption { get; set; }


        /// <summary>
        /// Enables key derivation mode. This allows for per-transaction unique keys for encryption operations.
        /// </summary>
        /// <value>Enables key derivation mode. This allows for per-transaction unique keys for encryption operations.</value>
        [DataMember(Name = "derived", EmitDefaultValue = true)]

        public bool Derived { get; set; }


        /// <summary>
        /// Enables keys to be exportable. This allows for all the valid keys in the key ring to be exported.
        /// </summary>
        /// <value>Enables keys to be exportable. This allows for all the valid keys in the key ring to be exported.</value>
        [DataMember(Name = "exportable", EmitDefaultValue = true)]

        public bool Exportable { get; set; }


        /// <summary>
        /// The key size in bytes for the algorithm. Only applies to HMAC and must be no fewer than 32 bytes and no more than 512
        /// </summary>
        /// <value>The key size in bytes for the algorithm. Only applies to HMAC and must be no fewer than 32 bytes and no more than 512</value>
        [DataMember(Name = "key_size", EmitDefaultValue = false)]

        public int KeySize { get; set; }


        /// <summary>
        /// The type of key to create. Currently, \&quot;aes128-gcm96\&quot; (symmetric), \&quot;aes256-gcm96\&quot; (symmetric), \&quot;ecdsa-p256\&quot; (asymmetric), \&quot;ecdsa-p384\&quot; (asymmetric), \&quot;ecdsa-p521\&quot; (asymmetric), \&quot;ed25519\&quot; (asymmetric), \&quot;rsa-2048\&quot; (asymmetric), \&quot;rsa-3072\&quot; (asymmetric), \&quot;rsa-4096\&quot; (asymmetric) are supported. Defaults to \&quot;aes256-gcm96\&quot;.
        /// </summary>
        /// <value>The type of key to create. Currently, \&quot;aes128-gcm96\&quot; (symmetric), \&quot;aes256-gcm96\&quot; (symmetric), \&quot;ecdsa-p256\&quot; (asymmetric), \&quot;ecdsa-p384\&quot; (asymmetric), \&quot;ecdsa-p521\&quot; (asymmetric), \&quot;ed25519\&quot; (asymmetric), \&quot;rsa-2048\&quot; (asymmetric), \&quot;rsa-3072\&quot; (asymmetric), \&quot;rsa-4096\&quot; (asymmetric) are supported. Defaults to \&quot;aes256-gcm96\&quot;.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]

        public string Type { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransitWriteKeyRequest {\n");
            sb.Append("  AllowPlaintextBackup: ").Append(AllowPlaintextBackup).Append("\n");
            sb.Append("  AutoRotatePeriod: ").Append(AutoRotatePeriod).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  ConvergentEncryption: ").Append(ConvergentEncryption).Append("\n");
            sb.Append("  Derived: ").Append(Derived).Append("\n");
            sb.Append("  Exportable: ").Append(Exportable).Append("\n");
            sb.Append("  KeySize: ").Append(KeySize).Append("\n");
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
            return this.Equals(input as TransitWriteKeyRequest);
        }

        /// <summary>
        /// Returns true if TransitWriteKeyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransitWriteKeyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransitWriteKeyRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AllowPlaintextBackup == input.AllowPlaintextBackup ||

                    this.AllowPlaintextBackup.Equals(input.AllowPlaintextBackup)
                ) &&
                (
                    this.AutoRotatePeriod == input.AutoRotatePeriod ||

                    this.AutoRotatePeriod.Equals(input.AutoRotatePeriod)
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
                    this.Derived == input.Derived ||

                    this.Derived.Equals(input.Derived)
                ) &&
                (
                    this.Exportable == input.Exportable ||

                    this.Exportable.Equals(input.Exportable)
                ) &&
                (
                    this.KeySize == input.KeySize ||

                    this.KeySize.Equals(input.KeySize)
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


                hashCode = (hashCode * 59) + this.AllowPlaintextBackup.GetHashCode();

                hashCode = (hashCode * 59) + this.AutoRotatePeriod.GetHashCode();
                if (this.Context != null)
                {
                    hashCode = (hashCode * 59) + this.Context.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.ConvergentEncryption.GetHashCode();

                hashCode = (hashCode * 59) + this.Derived.GetHashCode();

                hashCode = (hashCode * 59) + this.Exportable.GetHashCode();

                hashCode = (hashCode * 59) + this.KeySize.GetHashCode();
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
