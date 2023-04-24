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
    /// RekeyVerificationUpdateResponse
    /// </summary>
    [DataContract(Name = "RekeyVerificationUpdateResponse")]
    public partial class RekeyVerificationUpdateResponse : IEquatable<RekeyVerificationUpdateResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="RekeyVerificationUpdateResponse" /> class.
        /// </summary>

        /// <param name="Complete">Complete.</param>

        /// <param name="Nounce">Nounce.</param>


        public RekeyVerificationUpdateResponse(bool Complete = default(bool), string Nounce = default(string))
        {

            this.Complete = Complete;

            this.Nounce = Nounce;

        }

        /// <summary>
        /// Gets or Sets Complete
        /// </summary>
        [DataMember(Name = "complete", EmitDefaultValue = true)]

        public bool Complete { get; set; }


        /// <summary>
        /// Gets or Sets Nounce
        /// </summary>
        [DataMember(Name = "nounce", EmitDefaultValue = false)]

        public string Nounce { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RekeyVerificationUpdateResponse {\n");
            sb.Append("  Complete: ").Append(Complete).Append("\n");
            sb.Append("  Nounce: ").Append(Nounce).Append("\n");
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
            return this.Equals(input as RekeyVerificationUpdateResponse);
        }

        /// <summary>
        /// Returns true if RekeyVerificationUpdateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RekeyVerificationUpdateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RekeyVerificationUpdateResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Complete == input.Complete ||

                    this.Complete.Equals(input.Complete)
                ) &&
                (
                    this.Nounce == input.Nounce ||
                    (this.Nounce != null &&
                    this.Nounce.Equals(input.Nounce))

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


                hashCode = (hashCode * 59) + this.Complete.GetHashCode();
                if (this.Nounce != null)
                {
                    hashCode = (hashCode * 59) + this.Nounce.GetHashCode();
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
