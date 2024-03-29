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
    /// LdapLibraryCheckOutRequest
    /// </summary>
    [DataContract(Name = "LdapLibraryCheckOutRequest")]
    public partial class LdapLibraryCheckOutRequest : IEquatable<LdapLibraryCheckOutRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="LdapLibraryCheckOutRequest" /> class.
        /// </summary>

        /// <param name="Ttl">The length of time before the check-out will expire, in seconds..</param>


        public LdapLibraryCheckOutRequest(string Ttl = default(string))
        {

            this.Ttl = Ttl;

        }

        /// <summary>
        /// The length of time before the check-out will expire, in seconds.
        /// </summary>
        /// <value>The length of time before the check-out will expire, in seconds.</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]

        public string Ttl { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LdapLibraryCheckOutRequest {\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
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
            return this.Equals(input as LdapLibraryCheckOutRequest);
        }

        /// <summary>
        /// Returns true if LdapLibraryCheckOutRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LdapLibraryCheckOutRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LdapLibraryCheckOutRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Ttl == input.Ttl ||
                    (this.Ttl != null &&
                    this.Ttl.Equals(input.Ttl))

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

                if (this.Ttl != null)
                {
                    hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
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
