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
    /// LeasesReadLeaseResponse
    /// </summary>
    [DataContract(Name = "LeasesReadLeaseResponse")]
    public partial class LeasesReadLeaseResponse : IEquatable<LeasesReadLeaseResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="LeasesReadLeaseResponse" /> class.
        /// </summary>

        /// <param name="ExpireTime">Optional lease expiry time.</param>

        /// <param name="Id">Lease id.</param>

        /// <param name="IssueTime">Timestamp for the lease&#x27;s issue time.</param>

        /// <param name="LastRenewal">Optional Timestamp of the last time the lease was renewed.</param>

        /// <param name="Renewable">True if the lease is able to be renewed.</param>

        /// <param name="Ttl">Time to Live set for the lease, returns 0 if unset.</param>


        public LeasesReadLeaseResponse(DateTime ExpireTime = default(DateTime), string Id = default(string), DateTime IssueTime = default(DateTime), DateTime LastRenewal = default(DateTime), bool Renewable = default(bool), int Ttl = default(int))
        {

            this.ExpireTime = ExpireTime;

            this.Id = Id;

            this.IssueTime = IssueTime;

            this.LastRenewal = LastRenewal;

            this.Renewable = Renewable;

            this.Ttl = Ttl;

        }

        /// <summary>
        /// Optional lease expiry time
        /// </summary>
        /// <value>Optional lease expiry time</value>
        [DataMember(Name = "expire_time", EmitDefaultValue = false)]

        public DateTime ExpireTime { get; set; }


        /// <summary>
        /// Lease id
        /// </summary>
        /// <value>Lease id</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]

        public string Id { get; set; }


        /// <summary>
        /// Timestamp for the lease&#x27;s issue time
        /// </summary>
        /// <value>Timestamp for the lease&#x27;s issue time</value>
        [DataMember(Name = "issue_time", EmitDefaultValue = false)]

        public DateTime IssueTime { get; set; }


        /// <summary>
        /// Optional Timestamp of the last time the lease was renewed
        /// </summary>
        /// <value>Optional Timestamp of the last time the lease was renewed</value>
        [DataMember(Name = "last_renewal", EmitDefaultValue = false)]

        public DateTime LastRenewal { get; set; }


        /// <summary>
        /// True if the lease is able to be renewed
        /// </summary>
        /// <value>True if the lease is able to be renewed</value>
        [DataMember(Name = "renewable", EmitDefaultValue = true)]

        public bool Renewable { get; set; }


        /// <summary>
        /// Time to Live set for the lease, returns 0 if unset
        /// </summary>
        /// <value>Time to Live set for the lease, returns 0 if unset</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]

        public int Ttl { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LeasesReadLeaseResponse {\n");
            sb.Append("  ExpireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IssueTime: ").Append(IssueTime).Append("\n");
            sb.Append("  LastRenewal: ").Append(LastRenewal).Append("\n");
            sb.Append("  Renewable: ").Append(Renewable).Append("\n");
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
            return this.Equals(input as LeasesReadLeaseResponse);
        }

        /// <summary>
        /// Returns true if LeasesReadLeaseResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of LeasesReadLeaseResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeasesReadLeaseResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.ExpireTime == input.ExpireTime ||
                    (this.ExpireTime != null &&
                    this.ExpireTime.Equals(input.ExpireTime))

                ) &&
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))

                ) &&
                (
                    this.IssueTime == input.IssueTime ||
                    (this.IssueTime != null &&
                    this.IssueTime.Equals(input.IssueTime))

                ) &&
                (
                    this.LastRenewal == input.LastRenewal ||
                    (this.LastRenewal != null &&
                    this.LastRenewal.Equals(input.LastRenewal))

                ) &&
                (
                    this.Renewable == input.Renewable ||

                    this.Renewable.Equals(input.Renewable)
                ) &&
                (
                    this.Ttl == input.Ttl ||

                    this.Ttl.Equals(input.Ttl)
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

                if (this.ExpireTime != null)
                {
                    hashCode = (hashCode * 59) + this.ExpireTime.GetHashCode();
                }

                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }

                if (this.IssueTime != null)
                {
                    hashCode = (hashCode * 59) + this.IssueTime.GetHashCode();
                }

                if (this.LastRenewal != null)
                {
                    hashCode = (hashCode * 59) + this.LastRenewal.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Renewable.GetHashCode();

                hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
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
