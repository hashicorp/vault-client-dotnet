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
    /// RekeyVerificationReadProgressResponse
    /// </summary>
    [DataContract(Name = "RekeyVerificationReadProgressResponse")]
    public partial class RekeyVerificationReadProgressResponse : IEquatable<RekeyVerificationReadProgressResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="RekeyVerificationReadProgressResponse" /> class.
        /// </summary>

        /// <param name="N">N.</param>

        /// <param name="Nounce">Nounce.</param>

        /// <param name="Progress">Progress.</param>

        /// <param name="Started">Started.</param>

        /// <param name="T">T.</param>


        public RekeyVerificationReadProgressResponse(int N = default(int), string Nounce = default(string), int Progress = default(int), string Started = default(string), int T = default(int))
        {

            this.N = N;

            this.Nounce = Nounce;

            this.Progress = Progress;

            this.Started = Started;

            this.T = T;

        }

        /// <summary>
        /// Gets or Sets N
        /// </summary>
        [DataMember(Name = "n", EmitDefaultValue = false)]

        public int N { get; set; }


        /// <summary>
        /// Gets or Sets Nounce
        /// </summary>
        [DataMember(Name = "nounce", EmitDefaultValue = false)]

        public string Nounce { get; set; }


        /// <summary>
        /// Gets or Sets Progress
        /// </summary>
        [DataMember(Name = "progress", EmitDefaultValue = false)]

        public int Progress { get; set; }


        /// <summary>
        /// Gets or Sets Started
        /// </summary>
        [DataMember(Name = "started", EmitDefaultValue = false)]

        public string Started { get; set; }


        /// <summary>
        /// Gets or Sets T
        /// </summary>
        [DataMember(Name = "t", EmitDefaultValue = false)]

        public int T { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RekeyVerificationReadProgressResponse {\n");
            sb.Append("  N: ").Append(N).Append("\n");
            sb.Append("  Nounce: ").Append(Nounce).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  Started: ").Append(Started).Append("\n");
            sb.Append("  T: ").Append(T).Append("\n");
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
            return this.Equals(input as RekeyVerificationReadProgressResponse);
        }

        /// <summary>
        /// Returns true if RekeyVerificationReadProgressResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RekeyVerificationReadProgressResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RekeyVerificationReadProgressResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.N == input.N ||

                    this.N.Equals(input.N)
                ) &&
                (
                    this.Nounce == input.Nounce ||
                    (this.Nounce != null &&
                    this.Nounce.Equals(input.Nounce))

                ) &&
                (
                    this.Progress == input.Progress ||

                    this.Progress.Equals(input.Progress)
                ) &&
                (
                    this.Started == input.Started ||
                    (this.Started != null &&
                    this.Started.Equals(input.Started))

                ) &&
                (
                    this.T == input.T ||

                    this.T.Equals(input.T)
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


                hashCode = (hashCode * 59) + this.N.GetHashCode();
                if (this.Nounce != null)
                {
                    hashCode = (hashCode * 59) + this.Nounce.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Progress.GetHashCode();
                if (this.Started != null)
                {
                    hashCode = (hashCode * 59) + this.Started.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.T.GetHashCode();
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
