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
    /// AppRoleReadTokenMaxTtlResponse
    /// </summary>
    [DataContract(Name = "AppRoleReadTokenMaxTtlResponse")]
    public partial class AppRoleReadTokenMaxTtlResponse : IEquatable<AppRoleReadTokenMaxTtlResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="AppRoleReadTokenMaxTtlResponse" /> class.
        /// </summary>

        /// <param name="TokenMaxTtl">The maximum lifetime of the generated token.</param>


        public AppRoleReadTokenMaxTtlResponse(string TokenMaxTtl = default(string))
        {

            this.TokenMaxTtl = TokenMaxTtl;

        }

        /// <summary>
        /// The maximum lifetime of the generated token
        /// </summary>
        /// <value>The maximum lifetime of the generated token</value>
        [DataMember(Name = "token_max_ttl", EmitDefaultValue = false)]

        public string TokenMaxTtl { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppRoleReadTokenMaxTtlResponse {\n");
            sb.Append("  TokenMaxTtl: ").Append(TokenMaxTtl).Append("\n");
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
            return this.Equals(input as AppRoleReadTokenMaxTtlResponse);
        }

        /// <summary>
        /// Returns true if AppRoleReadTokenMaxTtlResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AppRoleReadTokenMaxTtlResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppRoleReadTokenMaxTtlResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.TokenMaxTtl == input.TokenMaxTtl ||
                    (this.TokenMaxTtl != null &&
                    this.TokenMaxTtl.Equals(input.TokenMaxTtl))

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

                if (this.TokenMaxTtl != null)
                {
                    hashCode = (hashCode * 59) + this.TokenMaxTtl.GetHashCode();
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
