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
    /// AwsWriteStaticRolesNameRequest
    /// </summary>
    [DataContract(Name = "AwsWriteStaticRolesNameRequest")]
    public partial class AwsWriteStaticRolesNameRequest : IEquatable<AwsWriteStaticRolesNameRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="AwsWriteStaticRolesNameRequest" /> class.
        /// </summary>

        /// <param name="RotationPeriod">Period by which to rotate the backing credential of the adopted user. This can be a Go duration (e.g, &#x27;1m&#x27;, 24h&#x27;), or an integer number of seconds..</param>

        /// <param name="Username">The IAM user to adopt as a static role..</param>


        public AwsWriteStaticRolesNameRequest(string RotationPeriod = default(string), string Username = default(string))
        {

            this.RotationPeriod = RotationPeriod;

            this.Username = Username;

        }

        /// <summary>
        /// Period by which to rotate the backing credential of the adopted user. This can be a Go duration (e.g, &#x27;1m&#x27;, 24h&#x27;), or an integer number of seconds.
        /// </summary>
        /// <value>Period by which to rotate the backing credential of the adopted user. This can be a Go duration (e.g, &#x27;1m&#x27;, 24h&#x27;), or an integer number of seconds.</value>
        [DataMember(Name = "rotation_period", EmitDefaultValue = false)]

        public string RotationPeriod { get; set; }


        /// <summary>
        /// The IAM user to adopt as a static role.
        /// </summary>
        /// <value>The IAM user to adopt as a static role.</value>
        [DataMember(Name = "username", EmitDefaultValue = false)]

        public string Username { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AwsWriteStaticRolesNameRequest {\n");
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
            return this.Equals(input as AwsWriteStaticRolesNameRequest);
        }

        /// <summary>
        /// Returns true if AwsWriteStaticRolesNameRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AwsWriteStaticRolesNameRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AwsWriteStaticRolesNameRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.RotationPeriod == input.RotationPeriod ||
                    (this.RotationPeriod != null &&
                    this.RotationPeriod.Equals(input.RotationPeriod))

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

                if (this.RotationPeriod != null)
                {
                    hashCode = (hashCode * 59) + this.RotationPeriod.GetHashCode();
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
