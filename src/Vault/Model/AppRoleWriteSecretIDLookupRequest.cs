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
    /// AppRoleWriteSecretIDLookupRequest
    /// </summary>
    [DataContract(Name = "AppRoleWriteSecretIDLookupRequest")]
    public partial class AppRoleWriteSecretIDLookupRequest : IEquatable<AppRoleWriteSecretIDLookupRequest>, IValidatableObject
    {



        /// <summary>
        /// Initializes a new instance of the <see cref="AppRoleWriteSecretIDLookupRequest" /> class.
        /// </summary>

        /// <param name="SecretId">SecretID attached to the role..</param>


        public AppRoleWriteSecretIDLookupRequest(string SecretId = default(string))
        {

            this.SecretId = SecretId;

        }

        /// <summary>
        /// SecretID attached to the role.
        /// </summary>
        /// <value>SecretID attached to the role.</value>
        [DataMember(Name = "secret_id", EmitDefaultValue = false)]

        public string SecretId { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppRoleWriteSecretIDLookupRequest {\n");
            sb.Append("  SecretId: ").Append(SecretId).Append("\n");
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
            return this.Equals(input as AppRoleWriteSecretIDLookupRequest);
        }

        /// <summary>
        /// Returns true if AppRoleWriteSecretIDLookupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AppRoleWriteSecretIDLookupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppRoleWriteSecretIDLookupRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.SecretId == input.SecretId ||
                    (this.SecretId != null &&
                    this.SecretId.Equals(input.SecretId))

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

                if (this.SecretId != null)
                {
                    hashCode = (hashCode * 59) + this.SecretId.GetHashCode();
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
