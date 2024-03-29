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
    /// SshConfigureZeroAddressRequest
    /// </summary>
    [DataContract(Name = "SshConfigureZeroAddressRequest")]
    public partial class SshConfigureZeroAddressRequest : IEquatable<SshConfigureZeroAddressRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="SshConfigureZeroAddressRequest" /> class.
        /// </summary>

        /// <param name="Roles">[Required] Comma separated list of role names which allows credentials to be requested for any IP address. CIDR blocks previously registered under these roles will be ignored..</param>


        public SshConfigureZeroAddressRequest(List<string> Roles = default(List<string>))
        {

            this.Roles = Roles;

        }

        /// <summary>
        /// [Required] Comma separated list of role names which allows credentials to be requested for any IP address. CIDR blocks previously registered under these roles will be ignored.
        /// </summary>
        /// <value>[Required] Comma separated list of role names which allows credentials to be requested for any IP address. CIDR blocks previously registered under these roles will be ignored.</value>
        [DataMember(Name = "roles", EmitDefaultValue = false)]

        public List<string> Roles { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SshConfigureZeroAddressRequest {\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
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
            return this.Equals(input as SshConfigureZeroAddressRequest);
        }

        /// <summary>
        /// Returns true if SshConfigureZeroAddressRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SshConfigureZeroAddressRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SshConfigureZeroAddressRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
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

                if (this.Roles != null)
                {
                    hashCode = (hashCode * 59) + this.Roles.GetHashCode();
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
