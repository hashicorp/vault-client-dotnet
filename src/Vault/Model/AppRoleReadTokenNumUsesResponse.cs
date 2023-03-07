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
    /// AppRoleReadTokenNumUsesResponse
    /// </summary>
    [DataContract(Name = "AppRoleReadTokenNumUsesResponse")]
    public partial class AppRoleReadTokenNumUsesResponse : IEquatable<AppRoleReadTokenNumUsesResponse>, IValidatableObject
    {





        /// <summary>
        /// Initializes a new instance of the <see cref="AppRoleReadTokenNumUsesResponse" /> class.
        /// </summary>

        /// <param name="TokenNumUses">The maximum number of times a token may be used, a value of zero means unlimited.</param>


        public AppRoleReadTokenNumUsesResponse(int TokenNumUses = default(int))
        {

            this.TokenNumUses = TokenNumUses;

        }

        /// <summary>
        /// The maximum number of times a token may be used, a value of zero means unlimited
        /// </summary>
        /// <value>The maximum number of times a token may be used, a value of zero means unlimited</value>
        [DataMember(Name = "token_num_uses", EmitDefaultValue = false)]

        public int TokenNumUses { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppRoleReadTokenNumUsesResponse {\n");
            sb.Append("  TokenNumUses: ").Append(TokenNumUses).Append("\n");
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
            return this.Equals(input as AppRoleReadTokenNumUsesResponse);
        }

        /// <summary>
        /// Returns true if AppRoleReadTokenNumUsesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AppRoleReadTokenNumUsesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppRoleReadTokenNumUsesResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.TokenNumUses == input.TokenNumUses ||

                    this.TokenNumUses.Equals(input.TokenNumUses)
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


                hashCode = (hashCode * 59) + this.TokenNumUses.GetHashCode();
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
