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
    /// AppRoleWriteSecretIdBoundCidrsRequest
    /// </summary>
    [DataContract(Name = "AppRoleWriteSecretIdBoundCidrsRequest")]
    public partial class AppRoleWriteSecretIdBoundCidrsRequest : IEquatable<AppRoleWriteSecretIdBoundCidrsRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="AppRoleWriteSecretIdBoundCidrsRequest" /> class.
        /// </summary>

        /// <param name="SecretIdBoundCidrs">Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can perform the login operation..</param>


        public AppRoleWriteSecretIdBoundCidrsRequest(List<string> SecretIdBoundCidrs = default(List<string>))
        {

            this.SecretIdBoundCidrs = SecretIdBoundCidrs;

        }

        /// <summary>
        /// Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can perform the login operation.
        /// </summary>
        /// <value>Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can perform the login operation.</value>
        [DataMember(Name = "secret_id_bound_cidrs", EmitDefaultValue = false)]

        public List<string> SecretIdBoundCidrs { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppRoleWriteSecretIdBoundCidrsRequest {\n");
            sb.Append("  SecretIdBoundCidrs: ").Append(SecretIdBoundCidrs).Append("\n");
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
            return this.Equals(input as AppRoleWriteSecretIdBoundCidrsRequest);
        }

        /// <summary>
        /// Returns true if AppRoleWriteSecretIdBoundCidrsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AppRoleWriteSecretIdBoundCidrsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppRoleWriteSecretIdBoundCidrsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.SecretIdBoundCidrs == input.SecretIdBoundCidrs ||
                    this.SecretIdBoundCidrs != null &&
                    input.SecretIdBoundCidrs != null &&
                    this.SecretIdBoundCidrs.SequenceEqual(input.SecretIdBoundCidrs)
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

                if (this.SecretIdBoundCidrs != null)
                {
                    hashCode = (hashCode * 59) + this.SecretIdBoundCidrs.GetHashCode();
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
