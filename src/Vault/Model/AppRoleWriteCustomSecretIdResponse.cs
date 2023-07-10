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
    /// AppRoleWriteCustomSecretIdResponse
    /// </summary>
    [DataContract(Name = "AppRoleWriteCustomSecretIdResponse")]
    public partial class AppRoleWriteCustomSecretIdResponse : IEquatable<AppRoleWriteCustomSecretIdResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="AppRoleWriteCustomSecretIdResponse" /> class.
        /// </summary>

        /// <param name="SecretId">Secret ID attached to the role..</param>

        /// <param name="SecretIdAccessor">Accessor of the secret ID.</param>

        /// <param name="SecretIdNumUses">Number of times a secret ID can access the role, after which the secret ID will expire..</param>

        /// <param name="SecretIdTtl">Duration in seconds after which the issued secret ID expires..</param>


        public AppRoleWriteCustomSecretIdResponse(string SecretId = default(string), string SecretIdAccessor = default(string), int SecretIdNumUses = default(int), string SecretIdTtl = default(string))
        {

            this.SecretId = SecretId;

            this.SecretIdAccessor = SecretIdAccessor;

            this.SecretIdNumUses = SecretIdNumUses;

            this.SecretIdTtl = SecretIdTtl;

        }

        /// <summary>
        /// Secret ID attached to the role.
        /// </summary>
        /// <value>Secret ID attached to the role.</value>
        [DataMember(Name = "secret_id", EmitDefaultValue = false)]

        public string SecretId { get; set; }


        /// <summary>
        /// Accessor of the secret ID
        /// </summary>
        /// <value>Accessor of the secret ID</value>
        [DataMember(Name = "secret_id_accessor", EmitDefaultValue = false)]

        public string SecretIdAccessor { get; set; }


        /// <summary>
        /// Number of times a secret ID can access the role, after which the secret ID will expire.
        /// </summary>
        /// <value>Number of times a secret ID can access the role, after which the secret ID will expire.</value>
        [DataMember(Name = "secret_id_num_uses", EmitDefaultValue = false)]

        public int SecretIdNumUses { get; set; }


        /// <summary>
        /// Duration in seconds after which the issued secret ID expires.
        /// </summary>
        /// <value>Duration in seconds after which the issued secret ID expires.</value>
        [DataMember(Name = "secret_id_ttl", EmitDefaultValue = false)]

        public string SecretIdTtl { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppRoleWriteCustomSecretIdResponse {\n");
            sb.Append("  SecretId: ").Append(SecretId).Append("\n");
            sb.Append("  SecretIdAccessor: ").Append(SecretIdAccessor).Append("\n");
            sb.Append("  SecretIdNumUses: ").Append(SecretIdNumUses).Append("\n");
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
            return this.Equals(input as AppRoleWriteCustomSecretIdResponse);
        }

        /// <summary>
        /// Returns true if AppRoleWriteCustomSecretIdResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AppRoleWriteCustomSecretIdResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppRoleWriteCustomSecretIdResponse input)
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

                ) &&
                (
                    this.SecretIdAccessor == input.SecretIdAccessor ||
                    (this.SecretIdAccessor != null &&
                    this.SecretIdAccessor.Equals(input.SecretIdAccessor))

                ) &&
                (
                    this.SecretIdNumUses == input.SecretIdNumUses ||

                    this.SecretIdNumUses.Equals(input.SecretIdNumUses)
                ) &&
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

                if (this.SecretId != null)
                {
                    hashCode = (hashCode * 59) + this.SecretId.GetHashCode();
                }

                if (this.SecretIdAccessor != null)
                {
                    hashCode = (hashCode * 59) + this.SecretIdAccessor.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.SecretIdNumUses.GetHashCode();
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
