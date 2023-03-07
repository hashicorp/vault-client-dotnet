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
    /// TOTPWriteCodeRequest
    /// </summary>
    [DataContract(Name = "TOTPWriteCodeRequest")]
    public partial class TOTPWriteCodeRequest : IEquatable<TOTPWriteCodeRequest>, IValidatableObject
    {



        /// <summary>
        /// Initializes a new instance of the <see cref="TOTPWriteCodeRequest" /> class.
        /// </summary>

        /// <param name="Code">TOTP code to be validated..</param>


        public TOTPWriteCodeRequest(string Code = default(string))
        {

            this.Code = Code;

        }

        /// <summary>
        /// TOTP code to be validated.
        /// </summary>
        /// <value>TOTP code to be validated.</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]

        public string Code { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TOTPWriteCodeRequest {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return this.Equals(input as TOTPWriteCodeRequest);
        }

        /// <summary>
        /// Returns true if TOTPWriteCodeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TOTPWriteCodeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TOTPWriteCodeRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))

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

                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
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
