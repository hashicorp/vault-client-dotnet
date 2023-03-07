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
    /// GoogleCloudKMSDecryptRequest
    /// </summary>
    [DataContract(Name = "GoogleCloudKMSDecryptRequest")]
    public partial class GoogleCloudKMSDecryptRequest : IEquatable<GoogleCloudKMSDecryptRequest>, IValidatableObject
    {





        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleCloudKMSDecryptRequest" /> class.
        /// </summary>

        /// <param name="AdditionalAuthenticatedData">Optional data that was specified during encryption of this payload..</param>

        /// <param name="Ciphertext">Ciphertext to decrypt as previously returned from an encrypt operation. This must be base64-encoded ciphertext as previously returned from an encrypt operation..</param>

        /// <param name="KeyVersion">Integer version of the crypto key version to use for decryption. This is required for asymmetric keys. For symmetric keys, Cloud KMS will choose the correct version automatically..</param>


        public GoogleCloudKMSDecryptRequest(string AdditionalAuthenticatedData = default(string), string Ciphertext = default(string), int KeyVersion = default(int))
        {

            this.AdditionalAuthenticatedData = AdditionalAuthenticatedData;

            this.Ciphertext = Ciphertext;

            this.KeyVersion = KeyVersion;

        }

        /// <summary>
        /// Optional data that was specified during encryption of this payload.
        /// </summary>
        /// <value>Optional data that was specified during encryption of this payload.</value>
        [DataMember(Name = "additional_authenticated_data", EmitDefaultValue = false)]

        public string AdditionalAuthenticatedData { get; set; }


        /// <summary>
        /// Ciphertext to decrypt as previously returned from an encrypt operation. This must be base64-encoded ciphertext as previously returned from an encrypt operation.
        /// </summary>
        /// <value>Ciphertext to decrypt as previously returned from an encrypt operation. This must be base64-encoded ciphertext as previously returned from an encrypt operation.</value>
        [DataMember(Name = "ciphertext", EmitDefaultValue = false)]

        public string Ciphertext { get; set; }


        /// <summary>
        /// Integer version of the crypto key version to use for decryption. This is required for asymmetric keys. For symmetric keys, Cloud KMS will choose the correct version automatically.
        /// </summary>
        /// <value>Integer version of the crypto key version to use for decryption. This is required for asymmetric keys. For symmetric keys, Cloud KMS will choose the correct version automatically.</value>
        [DataMember(Name = "key_version", EmitDefaultValue = false)]

        public int KeyVersion { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoogleCloudKMSDecryptRequest {\n");
            sb.Append("  AdditionalAuthenticatedData: ").Append(AdditionalAuthenticatedData).Append("\n");
            sb.Append("  Ciphertext: ").Append(Ciphertext).Append("\n");
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
            return this.Equals(input as GoogleCloudKMSDecryptRequest);
        }

        /// <summary>
        /// Returns true if GoogleCloudKMSDecryptRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleCloudKMSDecryptRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleCloudKMSDecryptRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AdditionalAuthenticatedData == input.AdditionalAuthenticatedData ||
                    (this.AdditionalAuthenticatedData != null &&
                    this.AdditionalAuthenticatedData.Equals(input.AdditionalAuthenticatedData))

                ) &&
                (
                    this.Ciphertext == input.Ciphertext ||
                    (this.Ciphertext != null &&
                    this.Ciphertext.Equals(input.Ciphertext))

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

                if (this.AdditionalAuthenticatedData != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalAuthenticatedData.GetHashCode();
                }

                if (this.Ciphertext != null)
                {
                    hashCode = (hashCode * 59) + this.Ciphertext.GetHashCode();
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
