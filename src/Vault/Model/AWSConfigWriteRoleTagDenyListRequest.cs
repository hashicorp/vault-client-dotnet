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
    /// AWSConfigWriteRoleTagDenyListRequest
    /// </summary>
    [DataContract(Name = "AWSConfigWriteRoleTagDenyListRequest")]

    public partial class AWSConfigWriteRoleTagDenyListRequest : IEquatable<AWSConfigWriteRoleTagDenyListRequest>, IValidatableObject
    {







        /// <summary>
        /// Initializes a new instance of the <see cref="AWSConfigWriteRoleTagDenyListRequest" /> class.
        /// </summary>

        /// <param name="DisablePeriodicTidy">If set to &#x27;true&#x27;, disables the periodic tidying of deny listed entries. (default to false).</param>

        /// <param name="SafetyBuffer">The amount of extra time that must have passed beyond the roletag expiration, before it is removed from the backend storage. Defaults to 4320h (180 days). (default to 15552000).</param>


        public AWSConfigWriteRoleTagDenyListRequest(bool DisablePeriodicTidy = false, int SafetyBuffer = 15552000)
        {

            this.DisablePeriodicTidy = DisablePeriodicTidy;

            this.SafetyBuffer = SafetyBuffer;

        }

        /// <summary>
        /// If set to &#x27;true&#x27;, disables the periodic tidying of deny listed entries.
        /// </summary>
        /// <value>If set to &#x27;true&#x27;, disables the periodic tidying of deny listed entries.</value>
        [DataMember(Name = "disable_periodic_tidy", EmitDefaultValue = true)]


        public bool DisablePeriodicTidy { get; set; }


        /// <summary>
        /// The amount of extra time that must have passed beyond the roletag expiration, before it is removed from the backend storage. Defaults to 4320h (180 days).
        /// </summary>
        /// <value>The amount of extra time that must have passed beyond the roletag expiration, before it is removed from the backend storage. Defaults to 4320h (180 days).</value>
        [DataMember(Name = "safety_buffer", EmitDefaultValue = false)]


        public int SafetyBuffer { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AWSConfigWriteRoleTagDenyListRequest {\n");
            sb.Append("  DisablePeriodicTidy: ").Append(DisablePeriodicTidy).Append("\n");
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
            return this.Equals(input as AWSConfigWriteRoleTagDenyListRequest);
        }

        /// <summary>
        /// Returns true if AWSConfigWriteRoleTagDenyListRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AWSConfigWriteRoleTagDenyListRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AWSConfigWriteRoleTagDenyListRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.DisablePeriodicTidy == input.DisablePeriodicTidy ||

                    this.DisablePeriodicTidy.Equals(input.DisablePeriodicTidy)
                ) &&
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


                hashCode = (hashCode * 59) + this.DisablePeriodicTidy.GetHashCode();

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
