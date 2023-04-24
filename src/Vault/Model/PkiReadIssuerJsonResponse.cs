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
    /// PkiReadIssuerJsonResponse
    /// </summary>
    [DataContract(Name = "PkiReadIssuerJsonResponse")]
    public partial class PkiReadIssuerJsonResponse : IEquatable<PkiReadIssuerJsonResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PkiReadIssuerJsonResponse" /> class.
        /// </summary>

        /// <param name="CaChain">CA Chain.</param>

        /// <param name="Certificate">Certificate.</param>

        /// <param name="IssuerId">Issuer Id.</param>

        /// <param name="IssuerName">Issuer Name.</param>


        public PkiReadIssuerJsonResponse(List<string> CaChain = default(List<string>), string Certificate = default(string), string IssuerId = default(string), string IssuerName = default(string))
        {

            this.CaChain = CaChain;

            this.Certificate = Certificate;

            this.IssuerId = IssuerId;

            this.IssuerName = IssuerName;

        }

        /// <summary>
        /// CA Chain
        /// </summary>
        /// <value>CA Chain</value>
        [DataMember(Name = "ca_chain", EmitDefaultValue = false)]

        public List<string> CaChain { get; set; }


        /// <summary>
        /// Certificate
        /// </summary>
        /// <value>Certificate</value>
        [DataMember(Name = "certificate", EmitDefaultValue = false)]

        public string Certificate { get; set; }


        /// <summary>
        /// Issuer Id
        /// </summary>
        /// <value>Issuer Id</value>
        [DataMember(Name = "issuer_id", EmitDefaultValue = false)]

        public string IssuerId { get; set; }


        /// <summary>
        /// Issuer Name
        /// </summary>
        /// <value>Issuer Name</value>
        [DataMember(Name = "issuer_name", EmitDefaultValue = false)]

        public string IssuerName { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiReadIssuerJsonResponse {\n");
            sb.Append("  CaChain: ").Append(CaChain).Append("\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  IssuerId: ").Append(IssuerId).Append("\n");
            sb.Append("  IssuerName: ").Append(IssuerName).Append("\n");
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
            return this.Equals(input as PkiReadIssuerJsonResponse);
        }

        /// <summary>
        /// Returns true if PkiReadIssuerJsonResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiReadIssuerJsonResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiReadIssuerJsonResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.CaChain == input.CaChain ||
                    this.CaChain != null &&
                    input.CaChain != null &&
                    this.CaChain.SequenceEqual(input.CaChain)
                ) &&
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))

                ) &&
                (
                    this.IssuerId == input.IssuerId ||
                    (this.IssuerId != null &&
                    this.IssuerId.Equals(input.IssuerId))

                ) &&
                (
                    this.IssuerName == input.IssuerName ||
                    (this.IssuerName != null &&
                    this.IssuerName.Equals(input.IssuerName))

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

                if (this.CaChain != null)
                {
                    hashCode = (hashCode * 59) + this.CaChain.GetHashCode();
                }

                if (this.Certificate != null)
                {
                    hashCode = (hashCode * 59) + this.Certificate.GetHashCode();
                }

                if (this.IssuerId != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerId.GetHashCode();
                }

                if (this.IssuerName != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerName.GetHashCode();
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
