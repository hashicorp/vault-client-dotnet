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
    /// NomadConfigureLeaseRequest
    /// </summary>
    [DataContract(Name = "NomadConfigureLeaseRequest")]
    public partial class NomadConfigureLeaseRequest : IEquatable<NomadConfigureLeaseRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="NomadConfigureLeaseRequest" /> class.
        /// </summary>

        /// <param name="MaxTtl">Duration after which the issued token should not be allowed to be renewed.</param>

        /// <param name="Ttl">Duration before which the issued token needs renewal.</param>


        public NomadConfigureLeaseRequest(string MaxTtl = default(string), string Ttl = default(string))
        {

            this.MaxTtl = MaxTtl;

            this.Ttl = Ttl;

        }

        /// <summary>
        /// Duration after which the issued token should not be allowed to be renewed
        /// </summary>
        /// <value>Duration after which the issued token should not be allowed to be renewed</value>
        [DataMember(Name = "max_ttl", EmitDefaultValue = false)]

        public string MaxTtl { get; set; }


        /// <summary>
        /// Duration before which the issued token needs renewal
        /// </summary>
        /// <value>Duration before which the issued token needs renewal</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]

        public string Ttl { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NomadConfigureLeaseRequest {\n");
            sb.Append("  MaxTtl: ").Append(MaxTtl).Append("\n");
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
            return this.Equals(input as NomadConfigureLeaseRequest);
        }

        /// <summary>
        /// Returns true if NomadConfigureLeaseRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of NomadConfigureLeaseRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NomadConfigureLeaseRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.MaxTtl == input.MaxTtl ||
                    (this.MaxTtl != null &&
                    this.MaxTtl.Equals(input.MaxTtl))

                ) &&
                (
                    this.Ttl == input.Ttl ||
                    (this.Ttl != null &&
                    this.Ttl.Equals(input.Ttl))

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

                if (this.MaxTtl != null)
                {
                    hashCode = (hashCode * 59) + this.MaxTtl.GetHashCode();
                }

                if (this.Ttl != null)
                {
                    hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
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
