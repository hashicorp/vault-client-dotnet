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
    /// UserpassWriteUserPasswordRequest
    /// </summary>
    [DataContract(Name = "UserpassWriteUserPasswordRequest")]

    public partial class UserpassWriteUserPasswordRequest : IEquatable<UserpassWriteUserPasswordRequest>, IValidatableObject
    {





        /// <summary>
        /// Initializes a new instance of the <see cref="UserpassWriteUserPasswordRequest" /> class.
        /// </summary>

        /// <param name="Password">Password for this user..</param>


        public UserpassWriteUserPasswordRequest(string Password = default(string))
        {

            this.Password = Password;

        }

        /// <summary>
        /// Password for this user.
        /// </summary>
        /// <value>Password for this user.</value>
        [DataMember(Name = "password", EmitDefaultValue = false)]


        public string Password { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserpassWriteUserPasswordRequest {\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(input as UserpassWriteUserPasswordRequest);
        }

        /// <summary>
        /// Returns true if UserpassWriteUserPasswordRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UserpassWriteUserPasswordRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserpassWriteUserPasswordRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))

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

                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
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
