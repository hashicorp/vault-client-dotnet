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
    /// SshVerifyOtpRequest
    /// </summary>
    [DataContract(Name = "SshVerifyOtpRequest")]
    public partial class SshVerifyOtpRequest : IEquatable<SshVerifyOtpRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="SshVerifyOtpRequest" /> class.
        /// </summary>

        /// <param name="Otp">[Required] One-Time-Key that needs to be validated.</param>


        public SshVerifyOtpRequest(string Otp = default(string))
        {

            this.Otp = Otp;

        }

        /// <summary>
        /// [Required] One-Time-Key that needs to be validated
        /// </summary>
        /// <value>[Required] One-Time-Key that needs to be validated</value>
        [DataMember(Name = "otp", EmitDefaultValue = false)]

        public string Otp { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SshVerifyOtpRequest {\n");
            sb.Append("  Otp: ").Append(Otp).Append("\n");
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
            return this.Equals(input as SshVerifyOtpRequest);
        }

        /// <summary>
        /// Returns true if SshVerifyOtpRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SshVerifyOtpRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SshVerifyOtpRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Otp == input.Otp ||
                    (this.Otp != null &&
                    this.Otp.Equals(input.Otp))

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

                if (this.Otp != null)
                {
                    hashCode = (hashCode * 59) + this.Otp.GetHashCode();
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
