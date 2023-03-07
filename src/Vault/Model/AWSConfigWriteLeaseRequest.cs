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
    /// AWSConfigWriteLeaseRequest
    /// </summary>
    [DataContract(Name = "AWSConfigWriteLeaseRequest")]
    public partial class AWSConfigWriteLeaseRequest : IEquatable<AWSConfigWriteLeaseRequest>, IValidatableObject
    {







        /// <summary>
        /// Initializes a new instance of the <see cref="AWSConfigWriteLeaseRequest" /> class.
        /// </summary>

        /// <param name="Lease">Default lease for roles..</param>

        /// <param name="LeaseMax">Maximum time a credential is valid for..</param>


        public AWSConfigWriteLeaseRequest(string Lease = default(string), string LeaseMax = default(string))
        {

            this.Lease = Lease;

            this.LeaseMax = LeaseMax;

        }

        /// <summary>
        /// Default lease for roles.
        /// </summary>
        /// <value>Default lease for roles.</value>
        [DataMember(Name = "lease", EmitDefaultValue = false)]

        public string Lease { get; set; }


        /// <summary>
        /// Maximum time a credential is valid for.
        /// </summary>
        /// <value>Maximum time a credential is valid for.</value>
        [DataMember(Name = "lease_max", EmitDefaultValue = false)]

        public string LeaseMax { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AWSConfigWriteLeaseRequest {\n");
            sb.Append("  Lease: ").Append(Lease).Append("\n");
            sb.Append("  LeaseMax: ").Append(LeaseMax).Append("\n");
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
            return this.Equals(input as AWSConfigWriteLeaseRequest);
        }

        /// <summary>
        /// Returns true if AWSConfigWriteLeaseRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AWSConfigWriteLeaseRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AWSConfigWriteLeaseRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Lease == input.Lease ||
                    (this.Lease != null &&
                    this.Lease.Equals(input.Lease))

                ) &&
                (
                    this.LeaseMax == input.LeaseMax ||
                    (this.LeaseMax != null &&
                    this.LeaseMax.Equals(input.LeaseMax))

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

                if (this.Lease != null)
                {
                    hashCode = (hashCode * 59) + this.Lease.GetHashCode();
                }

                if (this.LeaseMax != null)
                {
                    hashCode = (hashCode * 59) + this.LeaseMax.GetHashCode();
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
