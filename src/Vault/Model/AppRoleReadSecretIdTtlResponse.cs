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
    /// AppRoleReadSecretIdTtlResponse
    /// </summary>
    [DataContract(Name = "AppRoleReadSecretIdTtlResponse")]
    public partial class AppRoleReadSecretIdTtlResponse : IEquatable<AppRoleReadSecretIdTtlResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="AppRoleReadSecretIdTtlResponse" /> class.
        /// </summary>

        /// <param name="SecretIdTtl">Duration in seconds after which the issued secret ID should expire. Defaults to 0, meaning no expiration..</param>


        public AppRoleReadSecretIdTtlResponse(string SecretIdTtl = default(string))
        {

            this.SecretIdTtl = SecretIdTtl;

        }

        /// <summary>
        /// Duration in seconds after which the issued secret ID should expire. Defaults to 0, meaning no expiration.
        /// </summary>
        /// <value>Duration in seconds after which the issued secret ID should expire. Defaults to 0, meaning no expiration.</value>
        [DataMember(Name = "secret_id_ttl", EmitDefaultValue = false)]

        public string SecretIdTtl { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppRoleReadSecretIdTtlResponse {\n");
            sb.Append("  SecretIdTtl: ").Append(SecretIdTtl).Append("\n");
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
            return this.Equals(input as AppRoleReadSecretIdTtlResponse);
        }

        /// <summary>
        /// Returns true if AppRoleReadSecretIdTtlResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AppRoleReadSecretIdTtlResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppRoleReadSecretIdTtlResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.SecretIdTtl == input.SecretIdTtl ||
                    (this.SecretIdTtl != null &&
                    this.SecretIdTtl.Equals(input.SecretIdTtl))

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

                if (this.SecretIdTtl != null)
                {
                    hashCode = (hashCode * 59) + this.SecretIdTtl.GetHashCode();
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
