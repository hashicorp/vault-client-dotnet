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
    /// GoogleCloudKMSRegisterKeyRequest
    /// </summary>
    [DataContract(Name = "GoogleCloudKMSRegisterKeyRequest")]
    public partial class GoogleCloudKMSRegisterKeyRequest : IEquatable<GoogleCloudKMSRegisterKeyRequest>, IValidatableObject
    {




        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleCloudKMSRegisterKeyRequest" /> class.
        /// </summary>

        /// <param name="CryptoKey">Full resource ID of the crypto key including the project, location, key ring, and crypto key like \&quot;projects/%s/locations/%s/keyRings/%s/cryptoKeys/%s\&quot;. This crypto key must already exist in Google Cloud KMS unless verify is set to \&quot;false\&quot;..</param>

        /// <param name="Verify">Verify that the given Google Cloud KMS crypto key exists and is accessible before creating the storage entry in Vault. Set this to \&quot;false\&quot; if the key will not exist at creation time. (default to true).</param>


        public GoogleCloudKMSRegisterKeyRequest(string CryptoKey = default(string), bool Verify = true)
        {

            this.CryptoKey = CryptoKey;

            this.Verify = Verify;

        }

        /// <summary>
        /// Full resource ID of the crypto key including the project, location, key ring, and crypto key like \&quot;projects/%s/locations/%s/keyRings/%s/cryptoKeys/%s\&quot;. This crypto key must already exist in Google Cloud KMS unless verify is set to \&quot;false\&quot;.
        /// </summary>
        /// <value>Full resource ID of the crypto key including the project, location, key ring, and crypto key like \&quot;projects/%s/locations/%s/keyRings/%s/cryptoKeys/%s\&quot;. This crypto key must already exist in Google Cloud KMS unless verify is set to \&quot;false\&quot;.</value>
        [DataMember(Name = "crypto_key", EmitDefaultValue = false)]

        public string CryptoKey { get; set; }


        /// <summary>
        /// Verify that the given Google Cloud KMS crypto key exists and is accessible before creating the storage entry in Vault. Set this to \&quot;false\&quot; if the key will not exist at creation time.
        /// </summary>
        /// <value>Verify that the given Google Cloud KMS crypto key exists and is accessible before creating the storage entry in Vault. Set this to \&quot;false\&quot; if the key will not exist at creation time.</value>
        [DataMember(Name = "verify", EmitDefaultValue = true)]

        public bool Verify { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoogleCloudKMSRegisterKeyRequest {\n");
            sb.Append("  CryptoKey: ").Append(CryptoKey).Append("\n");
            sb.Append("  Verify: ").Append(Verify).Append("\n");
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
            return this.Equals(input as GoogleCloudKMSRegisterKeyRequest);
        }

        /// <summary>
        /// Returns true if GoogleCloudKMSRegisterKeyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleCloudKMSRegisterKeyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleCloudKMSRegisterKeyRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.CryptoKey == input.CryptoKey ||
                    (this.CryptoKey != null &&
                    this.CryptoKey.Equals(input.CryptoKey))

                ) &&
                (
                    this.Verify == input.Verify ||

                    this.Verify.Equals(input.Verify)
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

                if (this.CryptoKey != null)
                {
                    hashCode = (hashCode * 59) + this.CryptoKey.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Verify.GetHashCode();
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
