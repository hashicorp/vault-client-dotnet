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
    /// TransitImportKeyVersionRequest
    /// </summary>
    [DataContract(Name = "TransitImportKeyVersionRequest")]
    public partial class TransitImportKeyVersionRequest : IEquatable<TransitImportKeyVersionRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="TransitImportKeyVersionRequest" /> class.
        /// </summary>

        /// <param name="Ciphertext">The base64-encoded ciphertext of the keys. The AES key should be encrypted using OAEP with the wrapping key and then concatenated with the import key, wrapped by the AES key..</param>

        /// <param name="HashFunction">The hash function used as a random oracle in the OAEP wrapping of the user-generated, ephemeral AES key. Can be one of \&quot;SHA1\&quot;, \&quot;SHA224\&quot;, \&quot;SHA256\&quot; (default), \&quot;SHA384\&quot;, or \&quot;SHA512\&quot; (default to &quot;SHA256&quot;).</param>

        /// <param name="PublicKey">The plaintext public key to be imported. If \&quot;ciphertext\&quot; is set, this field is ignored..</param>

        /// <param name="_Version">Key version to be updated, if left empty, a new version will be created unless a private key is specified and the &#x27;Latest&#x27; key is missing a private key..</param>


        public TransitImportKeyVersionRequest(string Ciphertext = default(string), string HashFunction = "SHA256", string PublicKey = default(string), int _Version = default(int))
        {

            this.Ciphertext = Ciphertext;

            // use default value if no "HashFunction" provided
            this.HashFunction = HashFunction ?? "SHA256";


            this.PublicKey = PublicKey;

            this._Version = _Version;

        }

        /// <summary>
        /// The base64-encoded ciphertext of the keys. The AES key should be encrypted using OAEP with the wrapping key and then concatenated with the import key, wrapped by the AES key.
        /// </summary>
        /// <value>The base64-encoded ciphertext of the keys. The AES key should be encrypted using OAEP with the wrapping key and then concatenated with the import key, wrapped by the AES key.</value>
        [DataMember(Name = "ciphertext", EmitDefaultValue = false)]

        public string Ciphertext { get; set; }


        /// <summary>
        /// The hash function used as a random oracle in the OAEP wrapping of the user-generated, ephemeral AES key. Can be one of \&quot;SHA1\&quot;, \&quot;SHA224\&quot;, \&quot;SHA256\&quot; (default), \&quot;SHA384\&quot;, or \&quot;SHA512\&quot;
        /// </summary>
        /// <value>The hash function used as a random oracle in the OAEP wrapping of the user-generated, ephemeral AES key. Can be one of \&quot;SHA1\&quot;, \&quot;SHA224\&quot;, \&quot;SHA256\&quot; (default), \&quot;SHA384\&quot;, or \&quot;SHA512\&quot;</value>
        [DataMember(Name = "hash_function", EmitDefaultValue = false)]

        public string HashFunction { get; set; }


        /// <summary>
        /// The plaintext public key to be imported. If \&quot;ciphertext\&quot; is set, this field is ignored.
        /// </summary>
        /// <value>The plaintext public key to be imported. If \&quot;ciphertext\&quot; is set, this field is ignored.</value>
        [DataMember(Name = "public_key", EmitDefaultValue = false)]

        public string PublicKey { get; set; }


        /// <summary>
        /// Key version to be updated, if left empty, a new version will be created unless a private key is specified and the &#x27;Latest&#x27; key is missing a private key.
        /// </summary>
        /// <value>Key version to be updated, if left empty, a new version will be created unless a private key is specified and the &#x27;Latest&#x27; key is missing a private key.</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]

        public int _Version { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransitImportKeyVersionRequest {\n");
            sb.Append("  Ciphertext: ").Append(Ciphertext).Append("\n");
            sb.Append("  HashFunction: ").Append(HashFunction).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
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
            return this.Equals(input as TransitImportKeyVersionRequest);
        }

        /// <summary>
        /// Returns true if TransitImportKeyVersionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransitImportKeyVersionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransitImportKeyVersionRequest input)
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
                    this._Version == input._Version ||

                    this._Version.Equals(input._Version)
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

                if (this.HashFunction != null)
                {
                    hashCode = (hashCode * 59) + this.HashFunction.GetHashCode();
                }

                if (this.PublicKey != null)
                {
                    hashCode = (hashCode * 59) + this.PublicKey.GetHashCode();
                }


                hashCode = (hashCode * 59) + this._Version.GetHashCode();
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
