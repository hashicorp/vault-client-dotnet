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
    /// SSHWriteKeysRequest
    /// </summary>
    [DataContract(Name = "SSHWriteKeysRequest")]

    public partial class SSHWriteKeysRequest : IEquatable<SSHWriteKeysRequest>, IValidatableObject
    {





        /// <summary>
        /// Initializes a new instance of the <see cref="SSHWriteKeysRequest" /> class.
        /// </summary>

        /// <param name="Key">[Required] SSH private key with super user privileges in host.</param>


        public SSHWriteKeysRequest(string Key = default(string))
        {

            this.Key = Key;

        }

        /// <summary>
        /// [Required] SSH private key with super user privileges in host
        /// </summary>
        /// <value>[Required] SSH private key with super user privileges in host</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]


        public string Key { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SSHWriteKeysRequest {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
            return this.Equals(input as SSHWriteKeysRequest);
        }

        /// <summary>
        /// Returns true if SSHWriteKeysRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SSHWriteKeysRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SSHWriteKeysRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))

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

                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
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
