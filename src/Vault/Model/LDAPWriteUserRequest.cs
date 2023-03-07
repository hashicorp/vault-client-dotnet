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
    /// LDAPWriteUserRequest
    /// </summary>
    [DataContract(Name = "LDAPWriteUserRequest")]
    public partial class LDAPWriteUserRequest : IEquatable<LDAPWriteUserRequest>, IValidatableObject
    {




        /// <summary>
        /// Initializes a new instance of the <see cref="LDAPWriteUserRequest" /> class.
        /// </summary>

        /// <param name="Groups">Comma-separated list of additional groups associated with the user..</param>

        /// <param name="Policies">Comma-separated list of policies associated with the user..</param>


        public LDAPWriteUserRequest(List<string> Groups = default(List<string>), List<string> Policies = default(List<string>))
        {

            this.Groups = Groups;

            this.Policies = Policies;

        }

        /// <summary>
        /// Comma-separated list of additional groups associated with the user.
        /// </summary>
        /// <value>Comma-separated list of additional groups associated with the user.</value>
        [DataMember(Name = "groups", EmitDefaultValue = false)]

        public List<string> Groups { get; set; }


        /// <summary>
        /// Comma-separated list of policies associated with the user.
        /// </summary>
        /// <value>Comma-separated list of policies associated with the user.</value>
        [DataMember(Name = "policies", EmitDefaultValue = false)]

        public List<string> Policies { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LDAPWriteUserRequest {\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
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
            return this.Equals(input as LDAPWriteUserRequest);
        }

        /// <summary>
        /// Returns true if LDAPWriteUserRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LDAPWriteUserRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LDAPWriteUserRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) &&
                (
                    this.Policies == input.Policies ||
                    this.Policies != null &&
                    input.Policies != null &&
                    this.Policies.SequenceEqual(input.Policies)
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

                if (this.Groups != null)
                {
                    hashCode = (hashCode * 59) + this.Groups.GetHashCode();
                }

                if (this.Policies != null)
                {
                    hashCode = (hashCode * 59) + this.Policies.GetHashCode();
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
