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
    /// WritePoliciesPasswordRequest
    /// </summary>
    [DataContract(Name = "WritePoliciesPasswordRequest")]
    public partial class WritePoliciesPasswordRequest : IEquatable<WritePoliciesPasswordRequest>, IValidatableObject
    {





        /// <summary>
        /// Initializes a new instance of the <see cref="WritePoliciesPasswordRequest" /> class.
        /// </summary>

        /// <param name="Policy">The password policy.</param>


        public WritePoliciesPasswordRequest(string Policy = default(string))
        {

            this.Policy = Policy;

        }

        /// <summary>
        /// The password policy
        /// </summary>
        /// <value>The password policy</value>
        [DataMember(Name = "policy", EmitDefaultValue = false)]

        public string Policy { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WritePoliciesPasswordRequest {\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
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
            return this.Equals(input as WritePoliciesPasswordRequest);
        }

        /// <summary>
        /// Returns true if WritePoliciesPasswordRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WritePoliciesPasswordRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WritePoliciesPasswordRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))

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

                if (this.Policy != null)
                {
                    hashCode = (hashCode * 59) + this.Policy.GetHashCode();
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
