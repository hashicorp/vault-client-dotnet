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
    /// PoliciesWriteAclPolicy2Request
    /// </summary>
    [DataContract(Name = "PoliciesWriteAclPolicy2Request")]
    public partial class PoliciesWriteAclPolicy2Request : IEquatable<PoliciesWriteAclPolicy2Request>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PoliciesWriteAclPolicy2Request" /> class.
        /// </summary>

        /// <param name="Policy">The rules of the policy..</param>

        /// <param name="Rules">The rules of the policy..</param>


        public PoliciesWriteAclPolicy2Request(string Policy = default(string), string Rules = default(string))
        {

            this.Policy = Policy;

            this.Rules = Rules;

        }

        /// <summary>
        /// The rules of the policy.
        /// </summary>
        /// <value>The rules of the policy.</value>
        [DataMember(Name = "policy", EmitDefaultValue = false)]

        public string Policy { get; set; }


        /// <summary>
        /// The rules of the policy.
        /// </summary>
        /// <value>The rules of the policy.</value>
        [DataMember(Name = "rules", EmitDefaultValue = false)]

        [Obsolete] public string Rules { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PoliciesWriteAclPolicy2Request {\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
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
            return this.Equals(input as PoliciesWriteAclPolicy2Request);
        }

        /// <summary>
        /// Returns true if PoliciesWriteAclPolicy2Request instances are equal
        /// </summary>
        /// <param name="input">Instance of PoliciesWriteAclPolicy2Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PoliciesWriteAclPolicy2Request input)
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

                ) &&
                (
                    this.Rules == input.Rules ||
                    (this.Rules != null &&
                    this.Rules.Equals(input.Rules))

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

                if (this.Rules != null)
                {
                    hashCode = (hashCode * 59) + this.Rules.GetHashCode();
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
