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
    /// LeasesRenewLeaseWithIdRequest
    /// </summary>
    [DataContract(Name = "LeasesRenewLeaseWithIdRequest")]
    public partial class LeasesRenewLeaseWithIdRequest : IEquatable<LeasesRenewLeaseWithIdRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="LeasesRenewLeaseWithIdRequest" /> class.
        /// </summary>

        /// <param name="Increment">The desired increment in seconds to the lease.</param>

        /// <param name="LeaseId">The lease identifier to renew. This is included with a lease..</param>


        public LeasesRenewLeaseWithIdRequest(int Increment = default(int), string LeaseId = default(string))
        {

            this.Increment = Increment;

            this.LeaseId = LeaseId;

        }

        /// <summary>
        /// The desired increment in seconds to the lease
        /// </summary>
        /// <value>The desired increment in seconds to the lease</value>
        [DataMember(Name = "increment", EmitDefaultValue = false)]

        public int Increment { get; set; }


        /// <summary>
        /// The lease identifier to renew. This is included with a lease.
        /// </summary>
        /// <value>The lease identifier to renew. This is included with a lease.</value>
        [DataMember(Name = "lease_id", EmitDefaultValue = false)]

        public string LeaseId { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LeasesRenewLeaseWithIdRequest {\n");
            sb.Append("  Increment: ").Append(Increment).Append("\n");
            sb.Append("  LeaseId: ").Append(LeaseId).Append("\n");
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
            return this.Equals(input as LeasesRenewLeaseWithIdRequest);
        }

        /// <summary>
        /// Returns true if LeasesRenewLeaseWithIdRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LeasesRenewLeaseWithIdRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeasesRenewLeaseWithIdRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Increment == input.Increment ||

                    this.Increment.Equals(input.Increment)
                ) &&
                (
                    this.LeaseId == input.LeaseId ||
                    (this.LeaseId != null &&
                    this.LeaseId.Equals(input.LeaseId))

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


                hashCode = (hashCode * 59) + this.Increment.GetHashCode();
                if (this.LeaseId != null)
                {
                    hashCode = (hashCode * 59) + this.LeaseId.GetHashCode();
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
