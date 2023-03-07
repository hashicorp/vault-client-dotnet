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
    /// OpenLDAPWriteStaticRoleRequest
    /// </summary>
    [DataContract(Name = "OpenLDAPWriteStaticRoleRequest")]

    public partial class OpenLDAPWriteStaticRoleRequest : IEquatable<OpenLDAPWriteStaticRoleRequest>, IValidatableObject
    {









        /// <summary>
        /// Initializes a new instance of the <see cref="OpenLDAPWriteStaticRoleRequest" /> class.
        /// </summary>

        /// <param name="Dn">The distinguished name of the entry to manage..</param>

        /// <param name="RotationPeriod">Period for automatic credential rotation of the given entry..</param>

        /// <param name="Username">The username/logon name for the entry with which this role will be associated..</param>


        public OpenLDAPWriteStaticRoleRequest(string Dn = default(string), int RotationPeriod = default(int), string Username = default(string))
        {

            this.Dn = Dn;

            this.RotationPeriod = RotationPeriod;

            this.Username = Username;

        }

        /// <summary>
        /// The distinguished name of the entry to manage.
        /// </summary>
        /// <value>The distinguished name of the entry to manage.</value>
        [DataMember(Name = "dn", EmitDefaultValue = false)]


        public string Dn { get; set; }


        /// <summary>
        /// Period for automatic credential rotation of the given entry.
        /// </summary>
        /// <value>Period for automatic credential rotation of the given entry.</value>
        [DataMember(Name = "rotation_period", EmitDefaultValue = false)]


        public int RotationPeriod { get; set; }


        /// <summary>
        /// The username/logon name for the entry with which this role will be associated.
        /// </summary>
        /// <value>The username/logon name for the entry with which this role will be associated.</value>
        [DataMember(Name = "username", EmitDefaultValue = false)]


        public string Username { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OpenLDAPWriteStaticRoleRequest {\n");
            sb.Append("  Dn: ").Append(Dn).Append("\n");
            sb.Append("  RotationPeriod: ").Append(RotationPeriod).Append("\n");
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
            return this.Equals(input as OpenLDAPWriteStaticRoleRequest);
        }

        /// <summary>
        /// Returns true if OpenLDAPWriteStaticRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OpenLDAPWriteStaticRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenLDAPWriteStaticRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Dn == input.Dn ||
                    (this.Dn != null &&
                    this.Dn.Equals(input.Dn))

                ) &&
                (
                    this.RotationPeriod == input.RotationPeriod ||

                    this.RotationPeriod.Equals(input.RotationPeriod)
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

                if (this.Dn != null)
                {
                    hashCode = (hashCode * 59) + this.Dn.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.RotationPeriod.GetHashCode();
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
