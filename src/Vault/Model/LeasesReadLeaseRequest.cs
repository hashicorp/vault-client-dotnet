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
    /// LeasesReadLeaseRequest
    /// </summary>
    [DataContract(Name = "LeasesReadLeaseRequest")]
    public partial class LeasesReadLeaseRequest : IEquatable<LeasesReadLeaseRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="LeasesReadLeaseRequest" /> class.
        /// </summary>

        /// <param name="LeaseId">The lease identifier to renew. This is included with a lease..</param>


        public LeasesReadLeaseRequest(string LeaseId = default(string))
        {

            this.LeaseId = LeaseId;

        }

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
            sb.Append("class LeasesReadLeaseRequest {\n");
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
            return this.Equals(input as LeasesReadLeaseRequest);
        }

        /// <summary>
        /// Returns true if LeasesReadLeaseRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LeasesReadLeaseRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeasesReadLeaseRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
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
