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
    /// MFAMethodGenerateTOTPRequest
    /// </summary>
    [DataContract(Name = "MFAMethodGenerateTOTPRequest")]

    public partial class MFAMethodGenerateTOTPRequest : IEquatable<MFAMethodGenerateTOTPRequest>, IValidatableObject
    {




        /// <summary>
        /// Initializes a new instance of the <see cref="MFAMethodGenerateTOTPRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MFAMethodGenerateTOTPRequest() { }


        /// <summary>
        /// Initializes a new instance of the <see cref="MFAMethodGenerateTOTPRequest" /> class.
        /// </summary>

        /// <param name="MethodId">The unique identifier for this MFA method. (required).</param>


        public MFAMethodGenerateTOTPRequest(string MethodId = default(string))
        {

            // to ensure "MethodId" is required (not null)
            if (MethodId == null)
            {
                throw new ArgumentNullException("MethodId is a required property for MFAMethodGenerateTOTPRequest and cannot be null");
            }
            this.MethodId = MethodId;


        }

        /// <summary>
        /// The unique identifier for this MFA method.
        /// </summary>
        /// <value>The unique identifier for this MFA method.</value>
        [DataMember(Name = "method_id", IsRequired = true, EmitDefaultValue = false)]


        public string MethodId { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MFAMethodGenerateTOTPRequest {\n");
            sb.Append("  MethodId: ").Append(MethodId).Append("\n");
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
            return this.Equals(input as MFAMethodGenerateTOTPRequest);
        }

        /// <summary>
        /// Returns true if MFAMethodGenerateTOTPRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MFAMethodGenerateTOTPRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MFAMethodGenerateTOTPRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.MethodId == input.MethodId ||
                    (this.MethodId != null &&
                    this.MethodId.Equals(input.MethodId))

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

                if (this.MethodId != null)
                {
                    hashCode = (hashCode * 59) + this.MethodId.GetHashCode();
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
