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
    /// GoogleCloudKMSVerifyRequest
    /// </summary>
    [DataContract(Name = "GoogleCloudKMSVerifyRequest")]
    public partial class GoogleCloudKMSVerifyRequest : IEquatable<GoogleCloudKMSVerifyRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleCloudKMSVerifyRequest" /> class.
        /// </summary>
        /// <param name="digest">Digest to verify. This digest must use the same SHA algorithm as the underlying Cloud KMS key. The digest must be the base64-encoded binary value. This field is required..</param>
        /// <param name="keyVersion">Integer version of the crypto key version to use for verification. This field is required..</param>
        /// <param name="signature">Base64-encoded signature to use for verification. This field is required..</param>
        public GoogleCloudKMSVerifyRequest(string digest = default(string), int keyVersion = default(int), string signature = default(string))
        {
            this.Digest = digest;
            this.KeyVersion = keyVersion;
            this.Signature = signature;
        }

        /// <summary>
        /// Digest to verify. This digest must use the same SHA algorithm as the underlying Cloud KMS key. The digest must be the base64-encoded binary value. This field is required.
        /// </summary>
        /// <value>Digest to verify. This digest must use the same SHA algorithm as the underlying Cloud KMS key. The digest must be the base64-encoded binary value. This field is required.</value>
        [DataMember(Name = "digest", EmitDefaultValue = false)]
        public string Digest { get; set; }

        /// <summary>
        /// Integer version of the crypto key version to use for verification. This field is required.
        /// </summary>
        /// <value>Integer version of the crypto key version to use for verification. This field is required.</value>
        [DataMember(Name = "key_version", EmitDefaultValue = false)]
        public int KeyVersion { get; set; }

        /// <summary>
        /// Base64-encoded signature to use for verification. This field is required.
        /// </summary>
        /// <value>Base64-encoded signature to use for verification. This field is required.</value>
        [DataMember(Name = "signature", EmitDefaultValue = false)]
        public string Signature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoogleCloudKMSVerifyRequest {\n");
            sb.Append("  Digest: ").Append(Digest).Append("\n");
            sb.Append("  KeyVersion: ").Append(KeyVersion).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
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
            return this.Equals(input as GoogleCloudKMSVerifyRequest);
        }

        /// <summary>
        /// Returns true if GoogleCloudKMSVerifyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleCloudKMSVerifyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleCloudKMSVerifyRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Digest == input.Digest ||
                    (this.Digest != null &&
                    this.Digest.Equals(input.Digest))
                ) &&
                (
                    this.KeyVersion == input.KeyVersion ||
                    this.KeyVersion.Equals(input.KeyVersion)
                ) &&
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
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
                if (this.Digest != null)
                {
                    hashCode = (hashCode * 59) + this.Digest.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.KeyVersion.GetHashCode();
                if (this.Signature != null)
                {
                    hashCode = (hashCode * 59) + this.Signature.GetHashCode();
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
