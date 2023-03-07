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
    /// SSHWriteCredentialsRequest
    /// </summary>
    [DataContract(Name = "SSHWriteCredentialsRequest")]
    public partial class SSHWriteCredentialsRequest : IEquatable<SSHWriteCredentialsRequest>, IValidatableObject
    {




        /// <summary>
        /// Initializes a new instance of the <see cref="SSHWriteCredentialsRequest" /> class.
        /// </summary>

        /// <param name="Ip">[Required] IP of the remote host.</param>

        /// <param name="Username">[Optional] Username in remote host.</param>


        public SSHWriteCredentialsRequest(string Ip = default(string), string Username = default(string))
        {

            this.Ip = Ip;

            this.Username = Username;

        }

        /// <summary>
        /// [Required] IP of the remote host
        /// </summary>
        /// <value>[Required] IP of the remote host</value>
        [DataMember(Name = "ip", EmitDefaultValue = false)]

        public string Ip { get; set; }


        /// <summary>
        /// [Optional] Username in remote host
        /// </summary>
        /// <value>[Optional] Username in remote host</value>
        [DataMember(Name = "username", EmitDefaultValue = false)]

        public string Username { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SSHWriteCredentialsRequest {\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
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
            return this.Equals(input as SSHWriteCredentialsRequest);
        }

        /// <summary>
        /// Returns true if SSHWriteCredentialsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SSHWriteCredentialsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SSHWriteCredentialsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))

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

                if (this.Ip != null)
                {
                    hashCode = (hashCode * 59) + this.Ip.GetHashCode();
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
