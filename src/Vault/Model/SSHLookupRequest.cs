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
    /// SSHLookupRequest
    /// </summary>
    [DataContract(Name = "SSHLookupRequest")]

    public partial class SSHLookupRequest : IEquatable<SSHLookupRequest>, IValidatableObject
    {





        /// <summary>
        /// Initializes a new instance of the <see cref="SSHLookupRequest" /> class.
        /// </summary>

        /// <param name="Ip">[Required] IP address of remote host.</param>


        public SSHLookupRequest(string Ip = default(string))
        {

            this.Ip = Ip;

        }

        /// <summary>
        /// [Required] IP address of remote host
        /// </summary>
        /// <value>[Required] IP address of remote host</value>
        [DataMember(Name = "ip", EmitDefaultValue = false)]


        public string Ip { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SSHLookupRequest {\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
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
            return this.Equals(input as SSHLookupRequest);
        }

        /// <summary>
        /// Returns true if SSHLookupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SSHLookupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SSHLookupRequest input)
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
