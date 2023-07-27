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
    /// PkiIssuerSignWithRoleResponse
    /// </summary>
    [DataContract(Name = "PkiIssuerSignWithRoleResponse")]
    public partial class PkiIssuerSignWithRoleResponse : IEquatable<PkiIssuerSignWithRoleResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PkiIssuerSignWithRoleResponse" /> class.
        /// </summary>

        /// <param name="CaChain">Certificate Chain.</param>

        /// <param name="Certificate">Certificate.</param>

        /// <param name="Expiration">Time of expiration.</param>

        /// <param name="IssuingCa">Issuing Certificate Authority.</param>

        /// <param name="SerialNumber">Serial Number.</param>


        public PkiIssuerSignWithRoleResponse(List<string> CaChain = default(List<string>), string Certificate = default(string), long Expiration = default(long), string IssuingCa = default(string), string SerialNumber = default(string))
        {

            this.CaChain = CaChain;

            this.Certificate = Certificate;

            this.Expiration = Expiration;

            this.IssuingCa = IssuingCa;

            this.SerialNumber = SerialNumber;

        }

        /// <summary>
        /// Certificate Chain
        /// </summary>
        /// <value>Certificate Chain</value>
        [DataMember(Name = "ca_chain", EmitDefaultValue = false)]

        public List<string> CaChain { get; set; }


        /// <summary>
        /// Certificate
        /// </summary>
        /// <value>Certificate</value>
        [DataMember(Name = "certificate", EmitDefaultValue = false)]

        public string Certificate { get; set; }


        /// <summary>
        /// Time of expiration
        /// </summary>
        /// <value>Time of expiration</value>
        [DataMember(Name = "expiration", EmitDefaultValue = false)]

        public long Expiration { get; set; }


        /// <summary>
        /// Issuing Certificate Authority
        /// </summary>
        /// <value>Issuing Certificate Authority</value>
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
            sb.Append("class PkiIssuerSignWithRoleResponse {\n");
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
            return this.Equals(input as PkiIssuerSignWithRoleResponse);
        }

        /// <summary>
        /// Returns true if PkiIssuerSignWithRoleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiIssuerSignWithRoleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiIssuerSignWithRoleResponse input)
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
