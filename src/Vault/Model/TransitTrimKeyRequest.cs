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
    /// TransitTrimKeyRequest
    /// </summary>
    [DataContract(Name = "TransitTrimKeyRequest")]

    public partial class TransitTrimKeyRequest : IEquatable<TransitTrimKeyRequest>, IValidatableObject
    {





        /// <summary>
        /// Initializes a new instance of the <see cref="TransitTrimKeyRequest" /> class.
        /// </summary>

        /// <param name="MinAvailableVersion">The minimum available version for the key ring. All versions before this version will be permanently deleted. This value can at most be equal to the lesser of &#x27;min_decryption_version&#x27; and &#x27;min_encryption_version&#x27;. This is not allowed to be set when either &#x27;min_encryption_version&#x27; or &#x27;min_decryption_version&#x27; is set to zero..</param>


        public TransitTrimKeyRequest(int MinAvailableVersion = default(int))
        {

            this.MinAvailableVersion = MinAvailableVersion;

        }

        /// <summary>
        /// The minimum available version for the key ring. All versions before this version will be permanently deleted. This value can at most be equal to the lesser of &#x27;min_decryption_version&#x27; and &#x27;min_encryption_version&#x27;. This is not allowed to be set when either &#x27;min_encryption_version&#x27; or &#x27;min_decryption_version&#x27; is set to zero.
        /// </summary>
        /// <value>The minimum available version for the key ring. All versions before this version will be permanently deleted. This value can at most be equal to the lesser of &#x27;min_decryption_version&#x27; and &#x27;min_encryption_version&#x27;. This is not allowed to be set when either &#x27;min_encryption_version&#x27; or &#x27;min_decryption_version&#x27; is set to zero.</value>
        [DataMember(Name = "min_available_version", EmitDefaultValue = false)]


        public int MinAvailableVersion { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransitTrimKeyRequest {\n");
            sb.Append("  MinAvailableVersion: ").Append(MinAvailableVersion).Append("\n");
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
            return this.Equals(input as TransitTrimKeyRequest);
        }

        /// <summary>
        /// Returns true if TransitTrimKeyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransitTrimKeyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransitTrimKeyRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.MinAvailableVersion == input.MinAvailableVersion ||

                    this.MinAvailableVersion.Equals(input.MinAvailableVersion)
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


                hashCode = (hashCode * 59) + this.MinAvailableVersion.GetHashCode();
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
