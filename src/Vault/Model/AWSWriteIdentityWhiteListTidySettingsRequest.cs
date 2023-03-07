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
    /// AWSWriteIdentityWhiteListTidySettingsRequest
    /// </summary>
    [DataContract(Name = "AWSWriteIdentityWhiteListTidySettingsRequest")]
    public partial class AWSWriteIdentityWhiteListTidySettingsRequest : IEquatable<AWSWriteIdentityWhiteListTidySettingsRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="AWSWriteIdentityWhiteListTidySettingsRequest" /> class.
        /// </summary>

        /// <param name="SafetyBuffer">The amount of extra time that must have passed beyond the identity&#x27;s expiration, before it is removed from the backend storage. (default to 259200).</param>


        public AWSWriteIdentityWhiteListTidySettingsRequest(int SafetyBuffer = 259200)
        {

            this.SafetyBuffer = SafetyBuffer;

        }

        /// <summary>
        /// The amount of extra time that must have passed beyond the identity&#x27;s expiration, before it is removed from the backend storage.
        /// </summary>
        /// <value>The amount of extra time that must have passed beyond the identity&#x27;s expiration, before it is removed from the backend storage.</value>
        [DataMember(Name = "safety_buffer", EmitDefaultValue = false)]

        public int SafetyBuffer { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AWSWriteIdentityWhiteListTidySettingsRequest {\n");
            sb.Append("  SafetyBuffer: ").Append(SafetyBuffer).Append("\n");
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
            return this.Equals(input as AWSWriteIdentityWhiteListTidySettingsRequest);
        }

        /// <summary>
        /// Returns true if AWSWriteIdentityWhiteListTidySettingsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AWSWriteIdentityWhiteListTidySettingsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AWSWriteIdentityWhiteListTidySettingsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.SafetyBuffer == input.SafetyBuffer ||

                    this.SafetyBuffer.Equals(input.SafetyBuffer)
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


                hashCode = (hashCode * 59) + this.SafetyBuffer.GetHashCode();
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
