// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

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
    /// GoogleCloudKMSWriteKeyConfigRequest
    /// </summary>
    [DataContract(Name = "GoogleCloudKMSWriteKeyConfigRequest")]
    public partial class GoogleCloudKMSWriteKeyConfigRequest : IEquatable<GoogleCloudKMSWriteKeyConfigRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleCloudKMSWriteKeyConfigRequest" /> class.
        /// </summary>
        /// <param name="maxVersion">Maximum allowed crypto key version. If set to a positive value, key versions greater than the given value are not permitted to be used. If set to 0 or a negative value, there is no maximum key version..</param>
        /// <param name="minVersion">Minimum allowed crypto key version. If set to a positive value, key versions less than the given value are not permitted to be used. If set to 0 or a negative value, there is no minimum key version. This value only affects encryption/re-encryption, not decryption. To restrict old values from being decrypted, increase this value and then perform a trim operation..</param>
        public GoogleCloudKMSWriteKeyConfigRequest(int maxVersion = default(int), int minVersion = default(int))
        {
            this.MaxVersion = maxVersion;
            this.MinVersion = minVersion;
        }

        /// <summary>
        /// Maximum allowed crypto key version. If set to a positive value, key versions greater than the given value are not permitted to be used. If set to 0 or a negative value, there is no maximum key version.
        /// </summary>
        /// <value>Maximum allowed crypto key version. If set to a positive value, key versions greater than the given value are not permitted to be used. If set to 0 or a negative value, there is no maximum key version.</value>
        [DataMember(Name = "max_version", EmitDefaultValue = false)]
        public int MaxVersion { get; set; }

        /// <summary>
        /// Minimum allowed crypto key version. If set to a positive value, key versions less than the given value are not permitted to be used. If set to 0 or a negative value, there is no minimum key version. This value only affects encryption/re-encryption, not decryption. To restrict old values from being decrypted, increase this value and then perform a trim operation.
        /// </summary>
        /// <value>Minimum allowed crypto key version. If set to a positive value, key versions less than the given value are not permitted to be used. If set to 0 or a negative value, there is no minimum key version. This value only affects encryption/re-encryption, not decryption. To restrict old values from being decrypted, increase this value and then perform a trim operation.</value>
        [DataMember(Name = "min_version", EmitDefaultValue = false)]
        public int MinVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoogleCloudKMSWriteKeyConfigRequest {\n");
            sb.Append("  MaxVersion: ").Append(MaxVersion).Append("\n");
            sb.Append("  MinVersion: ").Append(MinVersion).Append("\n");
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
            return this.Equals(input as GoogleCloudKMSWriteKeyConfigRequest);
        }

        /// <summary>
        /// Returns true if GoogleCloudKMSWriteKeyConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleCloudKMSWriteKeyConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleCloudKMSWriteKeyConfigRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MaxVersion == input.MaxVersion ||
                    this.MaxVersion.Equals(input.MaxVersion)
                ) && 
                (
                    this.MinVersion == input.MinVersion ||
                    this.MinVersion.Equals(input.MinVersion)
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
                hashCode = (hashCode * 59) + this.MaxVersion.GetHashCode();
                hashCode = (hashCode * 59) + this.MinVersion.GetHashCode();
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
