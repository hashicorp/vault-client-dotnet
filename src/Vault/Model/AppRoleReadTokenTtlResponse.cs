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
    /// AppRoleReadTokenTtlResponse
    /// </summary>
    [DataContract(Name = "AppRoleReadTokenTtlResponse")]
    public partial class AppRoleReadTokenTtlResponse : IEquatable<AppRoleReadTokenTtlResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="AppRoleReadTokenTtlResponse" /> class.
        /// </summary>

        /// <param name="TokenTtl">The initial ttl of the token to generate.</param>


        public AppRoleReadTokenTtlResponse(string TokenTtl = default(string))
        {

            this.TokenTtl = TokenTtl;

        }

        /// <summary>
        /// The initial ttl of the token to generate
        /// </summary>
        /// <value>The initial ttl of the token to generate</value>
        [DataMember(Name = "token_ttl", EmitDefaultValue = false)]

        public string TokenTtl { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppRoleReadTokenTtlResponse {\n");
            sb.Append("  TokenTtl: ").Append(TokenTtl).Append("\n");
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
            return this.Equals(input as AppRoleReadTokenTtlResponse);
        }

        /// <summary>
        /// Returns true if AppRoleReadTokenTtlResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AppRoleReadTokenTtlResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppRoleReadTokenTtlResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.TokenTtl == input.TokenTtl ||
                    (this.TokenTtl != null &&
                    this.TokenTtl.Equals(input.TokenTtl))

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

                if (this.TokenTtl != null)
                {
                    hashCode = (hashCode * 59) + this.TokenTtl.GetHashCode();
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
