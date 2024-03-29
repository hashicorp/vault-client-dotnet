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
    /// TransitImportKeyRequest
    /// </summary>
    [DataContract(Name = "TransitImportKeyRequest")]
    public partial class TransitImportKeyRequest : IEquatable<TransitImportKeyRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="TransitImportKeyRequest" /> class.
        /// </summary>

        /// <param name="AllowPlaintextBackup">Enables taking a backup of the named key in plaintext format. Once set, this cannot be disabled..</param>

        /// <param name="AllowRotation">True if the imported key may be rotated within Vault; false otherwise..</param>

        /// <param name="AutoRotatePeriod">Amount of time the key should live before being automatically rotated. A value of 0 (default) disables automatic rotation for the key. (default to &quot;0&quot;).</param>

        /// <param name="Ciphertext">The base64-encoded ciphertext of the keys. The AES key should be encrypted using OAEP with the wrapping key and then concatenated with the import key, wrapped by the AES key..</param>

        /// <param name="Context">Base64 encoded context for key derivation. When reading a key with key derivation enabled, if the key type supports public keys, this will return the public key for the given context..</param>

        /// <param name="Derived">Enables key derivation mode. This allows for per-transaction unique keys for encryption operations..</param>

        /// <param name="Exportable">Enables keys to be exportable. This allows for all the valid keys in the key ring to be exported..</param>

        /// <param name="HashFunction">The hash function used as a random oracle in the OAEP wrapping of the user-generated, ephemeral AES key. Can be one of \&quot;SHA1\&quot;, \&quot;SHA224\&quot;, \&quot;SHA256\&quot; (default), \&quot;SHA384\&quot;, or \&quot;SHA512\&quot; (default to &quot;SHA256&quot;).</param>

        /// <param name="PublicKey">The plaintext PEM public key to be imported. If \&quot;ciphertext\&quot; is set, this field is ignored..</param>

        /// <param name="Type">The type of key being imported. Currently, \&quot;aes128-gcm96\&quot; (symmetric), \&quot;aes256-gcm96\&quot; (symmetric), \&quot;ecdsa-p256\&quot; (asymmetric), \&quot;ecdsa-p384\&quot; (asymmetric), \&quot;ecdsa-p521\&quot; (asymmetric), \&quot;ed25519\&quot; (asymmetric), \&quot;rsa-2048\&quot; (asymmetric), \&quot;rsa-3072\&quot; (asymmetric), \&quot;rsa-4096\&quot; (asymmetric) are supported. Defaults to \&quot;aes256-gcm96\&quot;. (default to &quot;aes256-gcm96&quot;).</param>


        public TransitImportKeyRequest(bool AllowPlaintextBackup = default(bool), bool AllowRotation = default(bool), string AutoRotatePeriod = "0", string Ciphertext = default(string), string Context = default(string), bool Derived = default(bool), bool Exportable = default(bool), string HashFunction = "SHA256", string PublicKey = default(string), string Type = "aes256-gcm96")
        {

            this.AllowPlaintextBackup = AllowPlaintextBackup;

            this.AllowRotation = AllowRotation;

            // use default value if no "AutoRotatePeriod" provided
            this.AutoRotatePeriod = AutoRotatePeriod ?? "0";


            this.Ciphertext = Ciphertext;

            this.Context = Context;

            this.Derived = Derived;

            this.Exportable = Exportable;

            // use default value if no "HashFunction" provided
            this.HashFunction = HashFunction ?? "SHA256";


            this.PublicKey = PublicKey;

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
        /// True if the imported key may be rotated within Vault; false otherwise.
        /// </summary>
        /// <value>True if the imported key may be rotated within Vault; false otherwise.</value>
        [DataMember(Name = "allow_rotation", EmitDefaultValue = true)]

        public bool AllowRotation { get; set; }


        /// <summary>
        /// Amount of time the key should live before being automatically rotated. A value of 0 (default) disables automatic rotation for the key.
        /// </summary>
        /// <value>Amount of time the key should live before being automatically rotated. A value of 0 (default) disables automatic rotation for the key.</value>
        [DataMember(Name = "auto_rotate_period", EmitDefaultValue = false)]

        public string AutoRotatePeriod { get; set; }


        /// <summary>
        /// The base64-encoded ciphertext of the keys. The AES key should be encrypted using OAEP with the wrapping key and then concatenated with the import key, wrapped by the AES key.
        /// </summary>
        /// <value>The base64-encoded ciphertext of the keys. The AES key should be encrypted using OAEP with the wrapping key and then concatenated with the import key, wrapped by the AES key.</value>
        [DataMember(Name = "ciphertext", EmitDefaultValue = false)]

        public string Ciphertext { get; set; }


        /// <summary>
        /// Base64 encoded context for key derivation. When reading a key with key derivation enabled, if the key type supports public keys, this will return the public key for the given context.
        /// </summary>
        /// <value>Base64 encoded context for key derivation. When reading a key with key derivation enabled, if the key type supports public keys, this will return the public key for the given context.</value>
        [DataMember(Name = "context", EmitDefaultValue = false)]

        public string Context { get; set; }


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
        /// The hash function used as a random oracle in the OAEP wrapping of the user-generated, ephemeral AES key. Can be one of \&quot;SHA1\&quot;, \&quot;SHA224\&quot;, \&quot;SHA256\&quot; (default), \&quot;SHA384\&quot;, or \&quot;SHA512\&quot;
        /// </summary>
        /// <value>The hash function used as a random oracle in the OAEP wrapping of the user-generated, ephemeral AES key. Can be one of \&quot;SHA1\&quot;, \&quot;SHA224\&quot;, \&quot;SHA256\&quot; (default), \&quot;SHA384\&quot;, or \&quot;SHA512\&quot;</value>
        [DataMember(Name = "hash_function", EmitDefaultValue = false)]

        public string HashFunction { get; set; }


        /// <summary>
        /// The plaintext PEM public key to be imported. If \&quot;ciphertext\&quot; is set, this field is ignored.
        /// </summary>
        /// <value>The plaintext PEM public key to be imported. If \&quot;ciphertext\&quot; is set, this field is ignored.</value>
        [DataMember(Name = "public_key", EmitDefaultValue = false)]

        public string PublicKey { get; set; }


        /// <summary>
        /// The type of key being imported. Currently, \&quot;aes128-gcm96\&quot; (symmetric), \&quot;aes256-gcm96\&quot; (symmetric), \&quot;ecdsa-p256\&quot; (asymmetric), \&quot;ecdsa-p384\&quot; (asymmetric), \&quot;ecdsa-p521\&quot; (asymmetric), \&quot;ed25519\&quot; (asymmetric), \&quot;rsa-2048\&quot; (asymmetric), \&quot;rsa-3072\&quot; (asymmetric), \&quot;rsa-4096\&quot; (asymmetric) are supported. Defaults to \&quot;aes256-gcm96\&quot;.
        /// </summary>
        /// <value>The type of key being imported. Currently, \&quot;aes128-gcm96\&quot; (symmetric), \&quot;aes256-gcm96\&quot; (symmetric), \&quot;ecdsa-p256\&quot; (asymmetric), \&quot;ecdsa-p384\&quot; (asymmetric), \&quot;ecdsa-p521\&quot; (asymmetric), \&quot;ed25519\&quot; (asymmetric), \&quot;rsa-2048\&quot; (asymmetric), \&quot;rsa-3072\&quot; (asymmetric), \&quot;rsa-4096\&quot; (asymmetric) are supported. Defaults to \&quot;aes256-gcm96\&quot;.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]

        public string Type { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransitImportKeyRequest {\n");
            sb.Append("  AllowPlaintextBackup: ").Append(AllowPlaintextBackup).Append("\n");
            sb.Append("  AllowRotation: ").Append(AllowRotation).Append("\n");
            sb.Append("  AutoRotatePeriod: ").Append(AutoRotatePeriod).Append("\n");
            sb.Append("  Ciphertext: ").Append(Ciphertext).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Derived: ").Append(Derived).Append("\n");
            sb.Append("  Exportable: ").Append(Exportable).Append("\n");
            sb.Append("  HashFunction: ").Append(HashFunction).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
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
            return this.Equals(input as TransitImportKeyRequest);
        }

        /// <summary>
        /// Returns true if TransitImportKeyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransitImportKeyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransitImportKeyRequest input)
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
                    this.AllowRotation == input.AllowRotation ||

                    this.AllowRotation.Equals(input.AllowRotation)
                ) &&
                (
                    this.AutoRotatePeriod == input.AutoRotatePeriod ||
                    (this.AutoRotatePeriod != null &&
                    this.AutoRotatePeriod.Equals(input.AutoRotatePeriod))

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
                    this.Derived == input.Derived ||

                    this.Derived.Equals(input.Derived)
                ) &&
                (
                    this.Exportable == input.Exportable ||

                    this.Exportable.Equals(input.Exportable)
                ) &&
                (
                    this.HashFunction == input.HashFunction ||
                    (this.HashFunction != null &&
                    this.HashFunction.Equals(input.HashFunction))

                ) &&
                (
                    this.PublicKey == input.PublicKey ||
                    (this.PublicKey != null &&
                    this.PublicKey.Equals(input.PublicKey))

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

                hashCode = (hashCode * 59) + this.AllowRotation.GetHashCode();
                if (this.AutoRotatePeriod != null)
                {
                    hashCode = (hashCode * 59) + this.AutoRotatePeriod.GetHashCode();
                }

                if (this.Ciphertext != null)
                {
                    hashCode = (hashCode * 59) + this.Ciphertext.GetHashCode();
                }

                if (this.Context != null)
                {
                    hashCode = (hashCode * 59) + this.Context.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Derived.GetHashCode();

                hashCode = (hashCode * 59) + this.Exportable.GetHashCode();
                if (this.HashFunction != null)
                {
                    hashCode = (hashCode * 59) + this.HashFunction.GetHashCode();
                }

                if (this.PublicKey != null)
                {
                    hashCode = (hashCode * 59) + this.PublicKey.GetHashCode();
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
