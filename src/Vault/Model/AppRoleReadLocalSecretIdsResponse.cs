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
    /// AppRoleReadLocalSecretIdsResponse
    /// </summary>
    [DataContract(Name = "AppRoleReadLocalSecretIdsResponse")]
    public partial class AppRoleReadLocalSecretIdsResponse : IEquatable<AppRoleReadLocalSecretIdsResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="AppRoleReadLocalSecretIdsResponse" /> class.
        /// </summary>

        /// <param name="LocalSecretIds">If true, the secret identifiers generated using this role will be cluster local. This can only be set during role creation and once set, it can&#x27;t be reset later.</param>


        public AppRoleReadLocalSecretIdsResponse(bool LocalSecretIds = default(bool))
        {

            this.LocalSecretIds = LocalSecretIds;

        }

        /// <summary>
        /// If true, the secret identifiers generated using this role will be cluster local. This can only be set during role creation and once set, it can&#x27;t be reset later
        /// </summary>
        /// <value>If true, the secret identifiers generated using this role will be cluster local. This can only be set during role creation and once set, it can&#x27;t be reset later</value>
        [DataMember(Name = "local_secret_ids", EmitDefaultValue = true)]

        public bool LocalSecretIds { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppRoleReadLocalSecretIdsResponse {\n");
            sb.Append("  LocalSecretIds: ").Append(LocalSecretIds).Append("\n");
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
            return this.Equals(input as AppRoleReadLocalSecretIdsResponse);
        }

        /// <summary>
        /// Returns true if AppRoleReadLocalSecretIdsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AppRoleReadLocalSecretIdsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppRoleReadLocalSecretIdsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.LocalSecretIds == input.LocalSecretIds ||

                    this.LocalSecretIds.Equals(input.LocalSecretIds)
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


                hashCode = (hashCode * 59) + this.LocalSecretIds.GetHashCode();
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
