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
    /// PkiIssuerSignIntermediateResponse
    /// </summary>
    [DataContract(Name = "PkiIssuerSignIntermediateResponse")]
    public partial class PkiIssuerSignIntermediateResponse : IEquatable<PkiIssuerSignIntermediateResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PkiIssuerSignIntermediateResponse" /> class.
        /// </summary>

        /// <param name="CaChain">CA Chain.</param>

        /// <param name="Certificate">Certificate.</param>

        /// <param name="Expiration">Expiration Time.</param>

        /// <param name="IssuingCa">Issuing CA.</param>

        /// <param name="SerialNumber">Serial Number.</param>


        public PkiIssuerSignIntermediateResponse(List<string> CaChain = default(List<string>), string Certificate = default(string), long Expiration = default(long), string IssuingCa = default(string), string SerialNumber = default(string))
        {

            this.CaChain = CaChain;

            this.Certificate = Certificate;

            this.Expiration = Expiration;

            this.IssuingCa = IssuingCa;

            this.SerialNumber = SerialNumber;

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
        /// Expiration Time
        /// </summary>
        /// <value>Expiration Time</value>
        [DataMember(Name = "expiration", EmitDefaultValue = false)]

        public long Expiration { get; set; }


        /// <summary>
        /// Issuing CA
        /// </summary>
        /// <value>Issuing CA</value>
        [DataMember(Name = "issuing_ca", EmitDefaultValue = false)]

        public string IssuingCa { get; set; }


        /// <summary>
        /// Serial Number
        /// </summary>
        /// <value>Serial Number</value>
        [DataMember(Name = "serial_number", EmitDefaultValue = false)]

        public string SerialNumber { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiIssuerSignIntermediateResponse {\n");
            sb.Append("  CaChain: ").Append(CaChain).Append("\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  IssuingCa: ").Append(IssuingCa).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
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
            return this.Equals(input as PkiIssuerSignIntermediateResponse);
        }

        /// <summary>
        /// Returns true if PkiIssuerSignIntermediateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiIssuerSignIntermediateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiIssuerSignIntermediateResponse input)
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
                    this.Expiration == input.Expiration ||

                    this.Expiration.Equals(input.Expiration)
                ) &&
                (
                    this.IssuingCa == input.IssuingCa ||
                    (this.IssuingCa != null &&
                    this.IssuingCa.Equals(input.IssuingCa))

                ) &&
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))

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


                hashCode = (hashCode * 59) + this.Expiration.GetHashCode();
                if (this.IssuingCa != null)
                {
                    hashCode = (hashCode * 59) + this.IssuingCa.GetHashCode();
                }

                if (this.SerialNumber != null)
                {
                    hashCode = (hashCode * 59) + this.SerialNumber.GetHashCode();
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
