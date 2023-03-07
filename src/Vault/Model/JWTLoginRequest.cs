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
    /// JWTLoginRequest
    /// </summary>
    [DataContract(Name = "JWTLoginRequest")]
    public partial class JWTLoginRequest : IEquatable<JWTLoginRequest>, IValidatableObject
    {







        /// <summary>
        /// Initializes a new instance of the <see cref="JWTLoginRequest" /> class.
        /// </summary>

        /// <param name="Jwt">The signed JWT to validate..</param>

        /// <param name="Role">The role to log in against..</param>


        public JWTLoginRequest(string Jwt = default(string), string Role = default(string))
        {

            this.Jwt = Jwt;

            this.Role = Role;

        }

        /// <summary>
        /// The signed JWT to validate.
        /// </summary>
        /// <value>The signed JWT to validate.</value>
        [DataMember(Name = "jwt", EmitDefaultValue = false)]

        public string Jwt { get; set; }


        /// <summary>
        /// The role to log in against.
        /// </summary>
        /// <value>The role to log in against.</value>
        [DataMember(Name = "role", EmitDefaultValue = false)]

        public string Role { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JWTLoginRequest {\n");
            sb.Append("  Jwt: ").Append(Jwt).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
            return this.Equals(input as JWTLoginRequest);
        }

        /// <summary>
        /// Returns true if JWTLoginRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of JWTLoginRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JWTLoginRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Jwt == input.Jwt ||
                    (this.Jwt != null &&
                    this.Jwt.Equals(input.Jwt))

                ) &&
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))

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

                if (this.Jwt != null)
                {
                    hashCode = (hashCode * 59) + this.Jwt.GetHashCode();
                }

                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
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
