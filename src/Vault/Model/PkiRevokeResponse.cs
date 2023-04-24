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
    /// PkiRevokeResponse
    /// </summary>
    [DataContract(Name = "PkiRevokeResponse")]
    public partial class PkiRevokeResponse : IEquatable<PkiRevokeResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PkiRevokeResponse" /> class.
        /// </summary>

        /// <param name="RevocationTime">Revocation Time.</param>

        /// <param name="RevocationTimeRfc3339">Revocation Time.</param>

        /// <param name="State">Revocation State.</param>


        public PkiRevokeResponse(int RevocationTime = default(int), DateTime RevocationTimeRfc3339 = default(DateTime), string State = default(string))
        {

            this.RevocationTime = RevocationTime;

            this.RevocationTimeRfc3339 = RevocationTimeRfc3339;

            this.State = State;

        }

        /// <summary>
        /// Revocation Time
        /// </summary>
        /// <value>Revocation Time</value>
        [DataMember(Name = "revocation_time", EmitDefaultValue = false)]

        public int RevocationTime { get; set; }


        /// <summary>
        /// Revocation Time
        /// </summary>
        /// <value>Revocation Time</value>
        [DataMember(Name = "revocation_time_rfc3339", EmitDefaultValue = false)]

        public DateTime RevocationTimeRfc3339 { get; set; }


        /// <summary>
        /// Revocation State
        /// </summary>
        /// <value>Revocation State</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]

        public string State { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiRevokeResponse {\n");
            sb.Append("  RevocationTime: ").Append(RevocationTime).Append("\n");
            sb.Append("  RevocationTimeRfc3339: ").Append(RevocationTimeRfc3339).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as PkiRevokeResponse);
        }

        /// <summary>
        /// Returns true if PkiRevokeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiRevokeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiRevokeResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.RevocationTime == input.RevocationTime ||

                    this.RevocationTime.Equals(input.RevocationTime)
                ) &&
                (
                    this.RevocationTimeRfc3339 == input.RevocationTimeRfc3339 ||
                    (this.RevocationTimeRfc3339 != null &&
                    this.RevocationTimeRfc3339.Equals(input.RevocationTimeRfc3339))

                ) &&
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))

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


                hashCode = (hashCode * 59) + this.RevocationTime.GetHashCode();
                if (this.RevocationTimeRfc3339 != null)
                {
                    hashCode = (hashCode * 59) + this.RevocationTimeRfc3339.GetHashCode();
                }

                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
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
