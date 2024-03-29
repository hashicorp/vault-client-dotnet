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
    /// GoogleCloudKmsEncryptRequest
    /// </summary>
    [DataContract(Name = "GoogleCloudKmsEncryptRequest")]
    public partial class GoogleCloudKmsEncryptRequest : IEquatable<GoogleCloudKmsEncryptRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleCloudKmsEncryptRequest" /> class.
        /// </summary>

        /// <param name="AdditionalAuthenticatedData">Optional base64-encoded data that, if specified, must also be provided to decrypt this payload..</param>

        /// <param name="KeyVersion">Integer version of the crypto key version to use for encryption. If unspecified, this defaults to the latest active crypto key version..</param>

        /// <param name="Plaintext">Plaintext value to be encrypted. This can be a string or binary, but the size is limited. See the Google Cloud KMS documentation for information on size limitations by key types..</param>


        public GoogleCloudKmsEncryptRequest(string AdditionalAuthenticatedData = default(string), int KeyVersion = default(int), string Plaintext = default(string))
        {

            this.AdditionalAuthenticatedData = AdditionalAuthenticatedData;

            this.KeyVersion = KeyVersion;

            this.Plaintext = Plaintext;

        }

        /// <summary>
        /// Optional base64-encoded data that, if specified, must also be provided to decrypt this payload.
        /// </summary>
        /// <value>Optional base64-encoded data that, if specified, must also be provided to decrypt this payload.</value>
        [DataMember(Name = "additional_authenticated_data", EmitDefaultValue = false)]

        public string AdditionalAuthenticatedData { get; set; }


        /// <summary>
        /// Integer version of the crypto key version to use for encryption. If unspecified, this defaults to the latest active crypto key version.
        /// </summary>
        /// <value>Integer version of the crypto key version to use for encryption. If unspecified, this defaults to the latest active crypto key version.</value>
        [DataMember(Name = "key_version", EmitDefaultValue = false)]

        public int KeyVersion { get; set; }


        /// <summary>
        /// Plaintext value to be encrypted. This can be a string or binary, but the size is limited. See the Google Cloud KMS documentation for information on size limitations by key types.
        /// </summary>
        /// <value>Plaintext value to be encrypted. This can be a string or binary, but the size is limited. See the Google Cloud KMS documentation for information on size limitations by key types.</value>
        [DataMember(Name = "plaintext", EmitDefaultValue = false)]

        public string Plaintext { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoogleCloudKmsEncryptRequest {\n");
            sb.Append("  AdditionalAuthenticatedData: ").Append(AdditionalAuthenticatedData).Append("\n");
            sb.Append("  KeyVersion: ").Append(KeyVersion).Append("\n");
            sb.Append("  Plaintext: ").Append(Plaintext).Append("\n");
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
            return this.Equals(input as GoogleCloudKmsEncryptRequest);
        }

        /// <summary>
        /// Returns true if GoogleCloudKmsEncryptRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleCloudKmsEncryptRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleCloudKmsEncryptRequest input)
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
                    this.KeyVersion == input.KeyVersion ||

                    this.KeyVersion.Equals(input.KeyVersion)
                ) &&
                (
                    this.Plaintext == input.Plaintext ||
                    (this.Plaintext != null &&
                    this.Plaintext.Equals(input.Plaintext))

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


                hashCode = (hashCode * 59) + this.KeyVersion.GetHashCode();
                if (this.Plaintext != null)
                {
                    hashCode = (hashCode * 59) + this.Plaintext.GetHashCode();
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
