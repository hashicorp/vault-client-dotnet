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
    /// KubernetesLoginRequest
    /// </summary>
    [DataContract(Name = "KubernetesLoginRequest")]
    public partial class KubernetesLoginRequest : IEquatable<KubernetesLoginRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="KubernetesLoginRequest" /> class.
        /// </summary>

        /// <param name="Jwt">A signed JWT for authenticating a service account. This field is required..</param>

        /// <param name="Role">Name of the role against which the login is being attempted. This field is required.</param>


        public KubernetesLoginRequest(string Jwt = default(string), string Role = default(string))
        {

            this.Jwt = Jwt;

            this.Role = Role;

        }

        /// <summary>
        /// A signed JWT for authenticating a service account. This field is required.
        /// </summary>
        /// <value>A signed JWT for authenticating a service account. This field is required.</value>
        [DataMember(Name = "jwt", EmitDefaultValue = false)]

        public string Jwt { get; set; }


        /// <summary>
        /// Name of the role against which the login is being attempted. This field is required
        /// </summary>
        /// <value>Name of the role against which the login is being attempted. This field is required</value>
        [DataMember(Name = "role", EmitDefaultValue = false)]

        public string Role { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KubernetesLoginRequest {\n");
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
            return this.Equals(input as KubernetesLoginRequest);
        }

        /// <summary>
        /// Returns true if KubernetesLoginRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of KubernetesLoginRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KubernetesLoginRequest input)
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
