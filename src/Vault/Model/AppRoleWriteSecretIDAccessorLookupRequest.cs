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
    /// AppRoleWriteSecretIDAccessorLookupRequest
    /// </summary>
    [DataContract(Name = "AppRoleWriteSecretIDAccessorLookupRequest")]

    public partial class AppRoleWriteSecretIDAccessorLookupRequest : IEquatable<AppRoleWriteSecretIDAccessorLookupRequest>, IValidatableObject
    {





        /// <summary>
        /// Initializes a new instance of the <see cref="AppRoleWriteSecretIDAccessorLookupRequest" /> class.
        /// </summary>

        /// <param name="SecretIdAccessor">Accessor of the SecretID.</param>


        public AppRoleWriteSecretIDAccessorLookupRequest(string SecretIdAccessor = default(string))
        {

            this.SecretIdAccessor = SecretIdAccessor;

        }

        /// <summary>
        /// Accessor of the SecretID
        /// </summary>
        /// <value>Accessor of the SecretID</value>
        [DataMember(Name = "secret_id_accessor", EmitDefaultValue = false)]


        public string SecretIdAccessor { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppRoleWriteSecretIDAccessorLookupRequest {\n");
            sb.Append("  SecretIdAccessor: ").Append(SecretIdAccessor).Append("\n");
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
            return this.Equals(input as AppRoleWriteSecretIDAccessorLookupRequest);
        }

        /// <summary>
        /// Returns true if AppRoleWriteSecretIDAccessorLookupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AppRoleWriteSecretIDAccessorLookupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppRoleWriteSecretIDAccessorLookupRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.SecretIdAccessor == input.SecretIdAccessor ||
                    (this.SecretIdAccessor != null &&
                    this.SecretIdAccessor.Equals(input.SecretIdAccessor))

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

                if (this.SecretIdAccessor != null)
                {
                    hashCode = (hashCode * 59) + this.SecretIdAccessor.GetHashCode();
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
