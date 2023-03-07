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
    /// GoogleCloudWriteKeyRequest
    /// </summary>
    [DataContract(Name = "GoogleCloudWriteKeyRequest")]
    public partial class GoogleCloudWriteKeyRequest : IEquatable<GoogleCloudWriteKeyRequest>, IValidatableObject
    {









        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleCloudWriteKeyRequest" /> class.
        /// </summary>

        /// <param name="KeyAlgorithm">Private key algorithm for service account key - defaults to KEY_ALG_RSA_2048\&quot; (default to &quot;KEY_ALG_RSA_2048&quot;).</param>

        /// <param name="KeyType">Private key type for service account key - defaults to TYPE_GOOGLE_CREDENTIALS_FILE\&quot; (default to &quot;TYPE_GOOGLE_CREDENTIALS_FILE&quot;).</param>

        /// <param name="Ttl">Lifetime of the service account key.</param>


        public GoogleCloudWriteKeyRequest(string KeyAlgorithm = "KEY_ALG_RSA_2048", string KeyType = "TYPE_GOOGLE_CREDENTIALS_FILE", int Ttl = default(int))
        {

            // use default value if no "KeyAlgorithm" provided
            this.KeyAlgorithm = KeyAlgorithm ?? "KEY_ALG_RSA_2048";


            // use default value if no "KeyType" provided
            this.KeyType = KeyType ?? "TYPE_GOOGLE_CREDENTIALS_FILE";


            this.Ttl = Ttl;

        }

        /// <summary>
        /// Private key algorithm for service account key - defaults to KEY_ALG_RSA_2048\&quot;
        /// </summary>
        /// <value>Private key algorithm for service account key - defaults to KEY_ALG_RSA_2048\&quot;</value>
        [DataMember(Name = "key_algorithm", EmitDefaultValue = false)]


        public string KeyAlgorithm { get; set; }


        /// <summary>
        /// Private key type for service account key - defaults to TYPE_GOOGLE_CREDENTIALS_FILE\&quot;
        /// </summary>
        /// <value>Private key type for service account key - defaults to TYPE_GOOGLE_CREDENTIALS_FILE\&quot;</value>
        [DataMember(Name = "key_type", EmitDefaultValue = false)]


        public string KeyType { get; set; }


        /// <summary>
        /// Lifetime of the service account key
        /// </summary>
        /// <value>Lifetime of the service account key</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]


        public int Ttl { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoogleCloudWriteKeyRequest {\n");
            sb.Append("  KeyAlgorithm: ").Append(KeyAlgorithm).Append("\n");
            sb.Append("  KeyType: ").Append(KeyType).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
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
            return this.Equals(input as GoogleCloudWriteKeyRequest);
        }

        /// <summary>
        /// Returns true if GoogleCloudWriteKeyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleCloudWriteKeyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleCloudWriteKeyRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.KeyAlgorithm == input.KeyAlgorithm ||
                    (this.KeyAlgorithm != null &&
                    this.KeyAlgorithm.Equals(input.KeyAlgorithm))

                ) &&
                (
                    this.KeyType == input.KeyType ||
                    (this.KeyType != null &&
                    this.KeyType.Equals(input.KeyType))

                ) &&
                (
                    this.Ttl == input.Ttl ||

                    this.Ttl.Equals(input.Ttl)
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

                if (this.KeyAlgorithm != null)
                {
                    hashCode = (hashCode * 59) + this.KeyAlgorithm.GetHashCode();
                }

                if (this.KeyType != null)
                {
                    hashCode = (hashCode * 59) + this.KeyType.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
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
