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
    /// GoogleCloudKMSSignRequest
    /// </summary>
    [DataContract(Name = "GoogleCloudKMSSignRequest")]
    public partial class GoogleCloudKMSSignRequest : IEquatable<GoogleCloudKMSSignRequest>, IValidatableObject
    {







        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleCloudKMSSignRequest" /> class.
        /// </summary>

        /// <param name="Digest">Digest to sign. This digest must use the same SHA algorithm as the underlying Cloud KMS key. The digest must be the base64-encoded binary value. This field is required..</param>

        /// <param name="KeyVersion">Integer version of the crypto key version to use for signing. This field is required..</param>


        public GoogleCloudKMSSignRequest(string Digest = default(string), int KeyVersion = default(int))
        {

            this.Digest = Digest;

            this.KeyVersion = KeyVersion;

        }

        /// <summary>
        /// Digest to sign. This digest must use the same SHA algorithm as the underlying Cloud KMS key. The digest must be the base64-encoded binary value. This field is required.
        /// </summary>
        /// <value>Digest to sign. This digest must use the same SHA algorithm as the underlying Cloud KMS key. The digest must be the base64-encoded binary value. This field is required.</value>
        [DataMember(Name = "digest", EmitDefaultValue = false)]


        public string Digest { get; set; }


        /// <summary>
        /// Integer version of the crypto key version to use for signing. This field is required.
        /// </summary>
        /// <value>Integer version of the crypto key version to use for signing. This field is required.</value>
        [DataMember(Name = "key_version", EmitDefaultValue = false)]


        public int KeyVersion { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoogleCloudKMSSignRequest {\n");
            sb.Append("  Digest: ").Append(Digest).Append("\n");
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
            return this.Equals(input as GoogleCloudKMSSignRequest);
        }

        /// <summary>
        /// Returns true if GoogleCloudKMSSignRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleCloudKMSSignRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleCloudKMSSignRequest input)
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
