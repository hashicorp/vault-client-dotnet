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
    /// RateLimitQuotasReadResponse
    /// </summary>
    [DataContract(Name = "RateLimitQuotasReadResponse")]
    public partial class RateLimitQuotasReadResponse : IEquatable<RateLimitQuotasReadResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitQuotasReadResponse" /> class.
        /// </summary>

        /// <param name="BlockInterval">BlockInterval.</param>

        /// <param name="Inheritable">Inheritable.</param>

        /// <param name="Interval">Interval.</param>

        /// <param name="Name">Name.</param>

        /// <param name="Path">Path.</param>

        /// <param name="Rate">Rate.</param>

        /// <param name="Role">Role.</param>

        /// <param name="Type">Type.</param>


        public RateLimitQuotasReadResponse(int BlockInterval = default(int), bool Inheritable = default(bool), int Interval = default(int), string Name = default(string), string Path = default(string), float Rate = default(float), string Role = default(string), string Type = default(string))
        {

            this.BlockInterval = BlockInterval;

            this.Inheritable = Inheritable;

            this.Interval = Interval;

            this.Name = Name;

            this.Path = Path;

            this.Rate = Rate;

            this.Role = Role;

            this.Type = Type;

        }

        /// <summary>
        /// Gets or Sets BlockInterval
        /// </summary>
        [DataMember(Name = "block_interval", EmitDefaultValue = false)]

        public int BlockInterval { get; set; }


        /// <summary>
        /// Gets or Sets Inheritable
        /// </summary>
        [DataMember(Name = "inheritable", EmitDefaultValue = true)]

        public bool Inheritable { get; set; }


        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name = "interval", EmitDefaultValue = false)]

        public int Interval { get; set; }


        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]

        public string Name { get; set; }


        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name = "path", EmitDefaultValue = false)]

        public string Path { get; set; }


        /// <summary>
        /// Gets or Sets Rate
        /// </summary>
        [DataMember(Name = "rate", EmitDefaultValue = false)]

        public float Rate { get; set; }


        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name = "role", EmitDefaultValue = false)]

        public string Role { get; set; }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]

        public string Type { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RateLimitQuotasReadResponse {\n");
            sb.Append("  BlockInterval: ").Append(BlockInterval).Append("\n");
            sb.Append("  Inheritable: ").Append(Inheritable).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as RateLimitQuotasReadResponse);
        }

        /// <summary>
        /// Returns true if RateLimitQuotasReadResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RateLimitQuotasReadResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RateLimitQuotasReadResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.BlockInterval == input.BlockInterval ||

                    this.BlockInterval.Equals(input.BlockInterval)
                ) &&
                (
                    this.Inheritable == input.Inheritable ||

                    this.Inheritable.Equals(input.Inheritable)
                ) &&
                (
                    this.Interval == input.Interval ||

                    this.Interval.Equals(input.Interval)
                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))

                ) &&
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))

                ) &&
                (
                    this.Rate == input.Rate ||

                    this.Rate.Equals(input.Rate)
                ) &&
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))

                ) &&
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))

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


                hashCode = (hashCode * 59) + this.BlockInterval.GetHashCode();

                hashCode = (hashCode * 59) + this.Inheritable.GetHashCode();

                hashCode = (hashCode * 59) + this.Interval.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }

                if (this.Path != null)
                {
                    hashCode = (hashCode * 59) + this.Path.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Rate.GetHashCode();
                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
                }

                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
