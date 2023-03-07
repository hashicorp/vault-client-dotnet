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
    /// CentrifyLoginRequest
    /// </summary>
    [DataContract(Name = "CentrifyLoginRequest")]

    public partial class CentrifyLoginRequest : IEquatable<CentrifyLoginRequest>, IValidatableObject
    {









        /// <summary>
        /// Initializes a new instance of the <see cref="CentrifyLoginRequest" /> class.
        /// </summary>

        /// <param name="Mode">Auth mode (&#x27;ro&#x27; for resource owner, &#x27;cc&#x27; for credential client). (default to &quot;ro&quot;).</param>

        /// <param name="Password">Password for this user..</param>

        /// <param name="Username">Username of the user..</param>


        public CentrifyLoginRequest(string Mode = "ro", string Password = default(string), string Username = default(string))
        {

            // use default value if no "Mode" provided
            this.Mode = Mode ?? "ro";


            this.Password = Password;

            this.Username = Username;

        }

        /// <summary>
        /// Auth mode (&#x27;ro&#x27; for resource owner, &#x27;cc&#x27; for credential client).
        /// </summary>
        /// <value>Auth mode (&#x27;ro&#x27; for resource owner, &#x27;cc&#x27; for credential client).</value>
        [DataMember(Name = "mode", EmitDefaultValue = false)]


        public string Mode { get; set; }


        /// <summary>
        /// Password for this user.
        /// </summary>
        /// <value>Password for this user.</value>
        [DataMember(Name = "password", EmitDefaultValue = false)]


        public string Password { get; set; }


        /// <summary>
        /// Username of the user.
        /// </summary>
        /// <value>Username of the user.</value>
        [DataMember(Name = "username", EmitDefaultValue = false)]


        public string Username { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CentrifyLoginRequest {\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(input as CentrifyLoginRequest);
        }

        /// <summary>
        /// Returns true if CentrifyLoginRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CentrifyLoginRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CentrifyLoginRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))

                ) &&
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))

                ) &&
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))

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

                if (this.Mode != null)
                {
                    hashCode = (hashCode * 59) + this.Mode.GetHashCode();
                }

                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }

                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
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
