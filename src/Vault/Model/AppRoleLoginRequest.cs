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
    /// AppRoleLoginRequest
    /// </summary>
    [DataContract(Name = "AppRoleLoginRequest")]
    public partial class AppRoleLoginRequest : IEquatable<AppRoleLoginRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppRoleLoginRequest" /> class.
        /// </summary>
        /// <param name="roleId">Unique identifier of the Role. Required to be supplied when the &#39;bind_secret_id&#39; constraint is set..</param>
        /// <param name="secretId">SecretID belong to the App role (default to &quot;&quot;).</param>
        public AppRoleLoginRequest(string roleId = default(string), string secretId = "")
        {
            this.RoleId = roleId;
            // use default value if no "secretId" provided
            this.SecretId = secretId ?? "";
        }

        /// <summary>
        /// Unique identifier of the Role. Required to be supplied when the &#39;bind_secret_id&#39; constraint is set.
        /// </summary>
        /// <value>Unique identifier of the Role. Required to be supplied when the &#39;bind_secret_id&#39; constraint is set.</value>
        [DataMember(Name = "role_id", EmitDefaultValue = false)]
        public string RoleId { get; set; }

        /// <summary>
        /// SecretID belong to the App role
        /// </summary>
        /// <value>SecretID belong to the App role</value>
        [DataMember(Name = "secret_id", EmitDefaultValue = false)]
        public string SecretId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppRoleLoginRequest {\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
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
            return this.Equals(input as AppRoleLoginRequest);
        }

        /// <summary>
        /// Returns true if AppRoleLoginRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AppRoleLoginRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppRoleLoginRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RoleId == input.RoleId ||
                    (this.RoleId != null &&
                    this.RoleId.Equals(input.RoleId))
                ) && 
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
                if (this.RoleId != null)
                {
                    hashCode = (hashCode * 59) + this.RoleId.GetHashCode();
                }
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
