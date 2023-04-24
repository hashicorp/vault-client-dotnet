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
    /// PkiIssuerSignSelfIssuedResponse
    /// </summary>
    [DataContract(Name = "PkiIssuerSignSelfIssuedResponse")]
    public partial class PkiIssuerSignSelfIssuedResponse : IEquatable<PkiIssuerSignSelfIssuedResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PkiIssuerSignSelfIssuedResponse" /> class.
        /// </summary>

        /// <param name="Certificate">Certificate.</param>

        /// <param name="IssuingCa">Issuing CA.</param>


        public PkiIssuerSignSelfIssuedResponse(string Certificate = default(string), string IssuingCa = default(string))
        {

            this.Certificate = Certificate;

            this.IssuingCa = IssuingCa;

        }

        /// <summary>
        /// Certificate
        /// </summary>
        /// <value>Certificate</value>
        [DataMember(Name = "certificate", EmitDefaultValue = false)]

        public string Certificate { get; set; }


        /// <summary>
        /// Issuing CA
        /// </summary>
        /// <value>Issuing CA</value>
        [DataMember(Name = "issuing_ca", EmitDefaultValue = false)]

        public string IssuingCa { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiIssuerSignSelfIssuedResponse {\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  IssuingCa: ").Append(IssuingCa).Append("\n");
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
            return this.Equals(input as PkiIssuerSignSelfIssuedResponse);
        }

        /// <summary>
        /// Returns true if PkiIssuerSignSelfIssuedResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiIssuerSignSelfIssuedResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiIssuerSignSelfIssuedResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))

                ) &&
                (
                    this.IssuingCa == input.IssuingCa ||
                    (this.IssuingCa != null &&
                    this.IssuingCa.Equals(input.IssuingCa))

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

                if (this.Certificate != null)
                {
                    hashCode = (hashCode * 59) + this.Certificate.GetHashCode();
                }

                if (this.IssuingCa != null)
                {
                    hashCode = (hashCode * 59) + this.IssuingCa.GetHashCode();
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
