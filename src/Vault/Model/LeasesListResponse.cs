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
    /// LeasesListResponse
    /// </summary>
    [DataContract(Name = "LeasesListResponse")]
    public partial class LeasesListResponse : IEquatable<LeasesListResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="LeasesListResponse" /> class.
        /// </summary>

        /// <param name="Counts">Number of matching leases per mount.</param>

        /// <param name="LeaseCount">Number of matching leases.</param>


        public LeasesListResponse(int Counts = default(int), int LeaseCount = default(int))
        {

            this.Counts = Counts;

            this.LeaseCount = LeaseCount;

        }

        /// <summary>
        /// Number of matching leases per mount
        /// </summary>
        /// <value>Number of matching leases per mount</value>
        [DataMember(Name = "counts", EmitDefaultValue = false)]

        public int Counts { get; set; }


        /// <summary>
        /// Number of matching leases
        /// </summary>
        /// <value>Number of matching leases</value>
        [DataMember(Name = "lease_count", EmitDefaultValue = false)]

        public int LeaseCount { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LeasesListResponse {\n");
            sb.Append("  Counts: ").Append(Counts).Append("\n");
            sb.Append("  LeaseCount: ").Append(LeaseCount).Append("\n");
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
            return this.Equals(input as LeasesListResponse);
        }

        /// <summary>
        /// Returns true if LeasesListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of LeasesListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeasesListResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Counts == input.Counts ||

                    this.Counts.Equals(input.Counts)
                ) &&
                (
                    this.LeaseCount == input.LeaseCount ||

                    this.LeaseCount.Equals(input.LeaseCount)
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


                hashCode = (hashCode * 59) + this.Counts.GetHashCode();

                hashCode = (hashCode * 59) + this.LeaseCount.GetHashCode();
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
