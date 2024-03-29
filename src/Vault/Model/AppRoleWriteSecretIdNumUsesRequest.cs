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
    /// AppRoleWriteSecretIdNumUsesRequest
    /// </summary>
    [DataContract(Name = "AppRoleWriteSecretIdNumUsesRequest")]
    public partial class AppRoleWriteSecretIdNumUsesRequest : IEquatable<AppRoleWriteSecretIdNumUsesRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="AppRoleWriteSecretIdNumUsesRequest" /> class.
        /// </summary>

        /// <param name="SecretIdNumUses">Number of times a SecretID can access the role, after which the SecretID will expire..</param>


        public AppRoleWriteSecretIdNumUsesRequest(int SecretIdNumUses = default(int))
        {

            this.SecretIdNumUses = SecretIdNumUses;

        }

        /// <summary>
        /// Number of times a SecretID can access the role, after which the SecretID will expire.
        /// </summary>
        /// <value>Number of times a SecretID can access the role, after which the SecretID will expire.</value>
        [DataMember(Name = "secret_id_num_uses", EmitDefaultValue = false)]

        public int SecretIdNumUses { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppRoleWriteSecretIdNumUsesRequest {\n");
            sb.Append("  SecretIdNumUses: ").Append(SecretIdNumUses).Append("\n");
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
            return this.Equals(input as AppRoleWriteSecretIdNumUsesRequest);
        }

        /// <summary>
        /// Returns true if AppRoleWriteSecretIdNumUsesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AppRoleWriteSecretIdNumUsesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppRoleWriteSecretIdNumUsesRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.SecretIdNumUses == input.SecretIdNumUses ||

                    this.SecretIdNumUses.Equals(input.SecretIdNumUses)
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


                hashCode = (hashCode * 59) + this.SecretIdNumUses.GetHashCode();
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
