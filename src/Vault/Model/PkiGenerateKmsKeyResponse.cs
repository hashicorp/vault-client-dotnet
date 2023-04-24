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
    /// PkiGenerateKmsKeyResponse
    /// </summary>
    [DataContract(Name = "PkiGenerateKmsKeyResponse")]
    public partial class PkiGenerateKmsKeyResponse : IEquatable<PkiGenerateKmsKeyResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PkiGenerateKmsKeyResponse" /> class.
        /// </summary>

        /// <param name="KeyId">ID assigned to this key..</param>

        /// <param name="KeyName">Name assigned to this key..</param>

        /// <param name="KeyType">The type of key to use; defaults to RSA. \&quot;rsa\&quot; \&quot;ec\&quot; and \&quot;ed25519\&quot; are the only valid values..</param>

        /// <param name="PrivateKey">The private key string.</param>


        public PkiGenerateKmsKeyResponse(string KeyId = default(string), string KeyName = default(string), string KeyType = default(string), string PrivateKey = default(string))
        {

            this.KeyId = KeyId;

            this.KeyName = KeyName;

            this.KeyType = KeyType;

            this.PrivateKey = PrivateKey;

        }

        /// <summary>
        /// ID assigned to this key.
        /// </summary>
        /// <value>ID assigned to this key.</value>
        [DataMember(Name = "key_id", EmitDefaultValue = false)]

        public string KeyId { get; set; }


        /// <summary>
        /// Name assigned to this key.
        /// </summary>
        /// <value>Name assigned to this key.</value>
        [DataMember(Name = "key_name", EmitDefaultValue = false)]

        public string KeyName { get; set; }


        /// <summary>
        /// The type of key to use; defaults to RSA. \&quot;rsa\&quot; \&quot;ec\&quot; and \&quot;ed25519\&quot; are the only valid values.
        /// </summary>
        /// <value>The type of key to use; defaults to RSA. \&quot;rsa\&quot; \&quot;ec\&quot; and \&quot;ed25519\&quot; are the only valid values.</value>
        [DataMember(Name = "key_type", EmitDefaultValue = false)]

        public string KeyType { get; set; }


        /// <summary>
        /// The private key string
        /// </summary>
        /// <value>The private key string</value>
        [DataMember(Name = "private_key", EmitDefaultValue = false)]

        public string PrivateKey { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiGenerateKmsKeyResponse {\n");
            sb.Append("  KeyId: ").Append(KeyId).Append("\n");
            sb.Append("  KeyName: ").Append(KeyName).Append("\n");
            sb.Append("  KeyType: ").Append(KeyType).Append("\n");
            sb.Append("  PrivateKey: ").Append(PrivateKey).Append("\n");
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
            return this.Equals(input as PkiGenerateKmsKeyResponse);
        }

        /// <summary>
        /// Returns true if PkiGenerateKmsKeyResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiGenerateKmsKeyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiGenerateKmsKeyResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.KeyId == input.KeyId ||
                    (this.KeyId != null &&
                    this.KeyId.Equals(input.KeyId))

                ) &&
                (
                    this.KeyName == input.KeyName ||
                    (this.KeyName != null &&
                    this.KeyName.Equals(input.KeyName))

                ) &&
                (
                    this.KeyType == input.KeyType ||
                    (this.KeyType != null &&
                    this.KeyType.Equals(input.KeyType))

                ) &&
                (
                    this.PrivateKey == input.PrivateKey ||
                    (this.PrivateKey != null &&
                    this.PrivateKey.Equals(input.PrivateKey))

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

                if (this.KeyId != null)
                {
                    hashCode = (hashCode * 59) + this.KeyId.GetHashCode();
                }

                if (this.KeyName != null)
                {
                    hashCode = (hashCode * 59) + this.KeyName.GetHashCode();
                }

                if (this.KeyType != null)
                {
                    hashCode = (hashCode * 59) + this.KeyType.GetHashCode();
                }

                if (this.PrivateKey != null)
                {
                    hashCode = (hashCode * 59) + this.PrivateKey.GetHashCode();
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
