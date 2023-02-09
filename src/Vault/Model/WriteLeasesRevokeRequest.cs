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
    /// WriteLeasesRevokeRequest
    /// </summary>
    [DataContract(Name = "WriteLeasesRevokeRequest")]
    public partial class WriteLeasesRevokeRequest : IEquatable<WriteLeasesRevokeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WriteLeasesRevokeRequest" /> class.
        /// </summary>
        /// <param name="leaseId">The lease identifier to renew. This is included with a lease..</param>
        /// <param name="sync">Whether or not to perform the revocation synchronously (default to true).</param>
        /// <param name="urlLeaseId">The lease identifier to renew. This is included with a lease..</param>
        public WriteLeasesRevokeRequest(string leaseId = default(string), bool sync = true, string urlLeaseId = default(string))
        {
            this.LeaseId = leaseId;
            this.Sync = sync;
            this.UrlLeaseId = urlLeaseId;
        }

        /// <summary>
        /// The lease identifier to renew. This is included with a lease.
        /// </summary>
        /// <value>The lease identifier to renew. This is included with a lease.</value>
        [DataMember(Name = "lease_id", EmitDefaultValue = false)]
        public string LeaseId { get; set; }

        /// <summary>
        /// Whether or not to perform the revocation synchronously
        /// </summary>
        /// <value>Whether or not to perform the revocation synchronously</value>
        [DataMember(Name = "sync", EmitDefaultValue = true)]
        public bool Sync { get; set; }

        /// <summary>
        /// The lease identifier to renew. This is included with a lease.
        /// </summary>
        /// <value>The lease identifier to renew. This is included with a lease.</value>
        [DataMember(Name = "url_lease_id", EmitDefaultValue = false)]
        public string UrlLeaseId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WriteLeasesRevokeRequest {\n");
            sb.Append("  LeaseId: ").Append(LeaseId).Append("\n");
            sb.Append("  Sync: ").Append(Sync).Append("\n");
            sb.Append("  UrlLeaseId: ").Append(UrlLeaseId).Append("\n");
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
            return this.Equals(input as WriteLeasesRevokeRequest);
        }

        /// <summary>
        /// Returns true if WriteLeasesRevokeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WriteLeasesRevokeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WriteLeasesRevokeRequest input)
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
                ) && 
                (
                    this.Sync == input.Sync ||
                    this.Sync.Equals(input.Sync)
                ) && 
                (
                    this.UrlLeaseId == input.UrlLeaseId ||
                    (this.UrlLeaseId != null &&
                    this.UrlLeaseId.Equals(input.UrlLeaseId))
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
                hashCode = (hashCode * 59) + this.Sync.GetHashCode();
                if (this.UrlLeaseId != null)
                {
                    hashCode = (hashCode * 59) + this.UrlLeaseId.GetHashCode();
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
