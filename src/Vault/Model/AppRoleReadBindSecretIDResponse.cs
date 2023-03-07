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
    /// AppRoleReadBindSecretIDResponse
    /// </summary>
    [DataContract(Name = "AppRoleReadBindSecretIDResponse")]

    public partial class AppRoleReadBindSecretIDResponse : IEquatable<AppRoleReadBindSecretIDResponse>, IValidatableObject
    {





        /// <summary>
        /// Initializes a new instance of the <see cref="AppRoleReadBindSecretIDResponse" /> class.
        /// </summary>

        /// <param name="BindSecretId">Impose secret_id to be presented when logging in using this role. Defaults to &#x27;true&#x27;..</param>


        public AppRoleReadBindSecretIDResponse(bool BindSecretId = default(bool))
        {

            this.BindSecretId = BindSecretId;

        }

        /// <summary>
        /// Impose secret_id to be presented when logging in using this role. Defaults to &#x27;true&#x27;.
        /// </summary>
        /// <value>Impose secret_id to be presented when logging in using this role. Defaults to &#x27;true&#x27;.</value>
        [DataMember(Name = "bind_secret_id", EmitDefaultValue = true)]


        public bool BindSecretId { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppRoleReadBindSecretIDResponse {\n");
            sb.Append("  BindSecretId: ").Append(BindSecretId).Append("\n");
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
            return this.Equals(input as AppRoleReadBindSecretIDResponse);
        }

        /// <summary>
        /// Returns true if AppRoleReadBindSecretIDResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AppRoleReadBindSecretIDResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppRoleReadBindSecretIDResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.BindSecretId == input.BindSecretId ||

                    this.BindSecretId.Equals(input.BindSecretId)
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


                hashCode = (hashCode * 59) + this.BindSecretId.GetHashCode();
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
