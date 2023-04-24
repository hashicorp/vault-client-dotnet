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
    /// EncryptionKeyReadRotationConfigurationResponse
    /// </summary>
    [DataContract(Name = "EncryptionKeyReadRotationConfigurationResponse")]
    public partial class EncryptionKeyReadRotationConfigurationResponse : IEquatable<EncryptionKeyReadRotationConfigurationResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptionKeyReadRotationConfigurationResponse" /> class.
        /// </summary>

        /// <param name="Enabled">Enabled.</param>

        /// <param name="Interval">Interval.</param>

        /// <param name="MaxOperations">MaxOperations.</param>


        public EncryptionKeyReadRotationConfigurationResponse(bool Enabled = default(bool), int Interval = default(int), long MaxOperations = default(long))
        {

            this.Enabled = Enabled;

            this.Interval = Interval;

            this.MaxOperations = MaxOperations;

        }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]

        public bool Enabled { get; set; }


        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name = "interval", EmitDefaultValue = false)]

        public int Interval { get; set; }


        /// <summary>
        /// Gets or Sets MaxOperations
        /// </summary>
        [DataMember(Name = "max_operations", EmitDefaultValue = false)]

        public long MaxOperations { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EncryptionKeyReadRotationConfigurationResponse {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  MaxOperations: ").Append(MaxOperations).Append("\n");
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
            return this.Equals(input as EncryptionKeyReadRotationConfigurationResponse);
        }

        /// <summary>
        /// Returns true if EncryptionKeyReadRotationConfigurationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EncryptionKeyReadRotationConfigurationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EncryptionKeyReadRotationConfigurationResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Enabled == input.Enabled ||

                    this.Enabled.Equals(input.Enabled)
                ) &&
                (
                    this.Interval == input.Interval ||

                    this.Interval.Equals(input.Interval)
                ) &&
                (
                    this.MaxOperations == input.MaxOperations ||

                    this.MaxOperations.Equals(input.MaxOperations)
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


                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();

                hashCode = (hashCode * 59) + this.Interval.GetHashCode();

                hashCode = (hashCode * 59) + this.MaxOperations.GetHashCode();
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
