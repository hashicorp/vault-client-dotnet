// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

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
    /// AWSConfigWriteSecurityTokenServiceAccountRequest
    /// </summary>
    [DataContract(Name = "AWSConfigWriteSecurityTokenServiceAccountRequest")]
    public partial class AWSConfigWriteSecurityTokenServiceAccountRequest : IEquatable<AWSConfigWriteSecurityTokenServiceAccountRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AWSConfigWriteSecurityTokenServiceAccountRequest" /> class.
        /// </summary>
        /// <param name="stsRole">AWS ARN for STS role to be assumed when interacting with the account specified. The Vault server must have permissions to assume this role..</param>
        public AWSConfigWriteSecurityTokenServiceAccountRequest(string stsRole = default(string))
        {
            this.StsRole = stsRole;
        }

        /// <summary>
        /// AWS ARN for STS role to be assumed when interacting with the account specified. The Vault server must have permissions to assume this role.
        /// </summary>
        /// <value>AWS ARN for STS role to be assumed when interacting with the account specified. The Vault server must have permissions to assume this role.</value>
        [DataMember(Name = "sts_role", EmitDefaultValue = false)]
        public string StsRole { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AWSConfigWriteSecurityTokenServiceAccountRequest {\n");
            sb.Append("  StsRole: ").Append(StsRole).Append("\n");
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
            return this.Equals(input as AWSConfigWriteSecurityTokenServiceAccountRequest);
        }

        /// <summary>
        /// Returns true if AWSConfigWriteSecurityTokenServiceAccountRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AWSConfigWriteSecurityTokenServiceAccountRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AWSConfigWriteSecurityTokenServiceAccountRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StsRole == input.StsRole ||
                    (this.StsRole != null &&
                    this.StsRole.Equals(input.StsRole))
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
                if (this.StsRole != null)
                {
                    hashCode = (hashCode * 59) + this.StsRole.GetHashCode();
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
