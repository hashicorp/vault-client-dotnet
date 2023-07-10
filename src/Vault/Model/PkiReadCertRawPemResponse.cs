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
    /// PkiReadCertRawPemResponse
    /// </summary>
    [DataContract(Name = "PkiReadCertRawPemResponse")]
    public partial class PkiReadCertRawPemResponse : IEquatable<PkiReadCertRawPemResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PkiReadCertRawPemResponse" /> class.
        /// </summary>

        /// <param name="CaChain">Issuing CA Chain.</param>

        /// <param name="Certificate">Certificate.</param>

        /// <param name="IssuerId">ID of the issuer.</param>

        /// <param name="RevocationTime">Revocation time.</param>

        /// <param name="RevocationTimeRfc3339">Revocation time RFC 3339 formatted.</param>


        public PkiReadCertRawPemResponse(string CaChain = default(string), string Certificate = default(string), string IssuerId = default(string), long RevocationTime = default(long), string RevocationTimeRfc3339 = default(string))
        {

            this.CaChain = CaChain;

            this.Certificate = Certificate;

            this.IssuerId = IssuerId;

            this.RevocationTime = RevocationTime;

            this.RevocationTimeRfc3339 = RevocationTimeRfc3339;

        }

        /// <summary>
        /// Issuing CA Chain
        /// </summary>
        /// <value>Issuing CA Chain</value>
        [DataMember(Name = "ca_chain", EmitDefaultValue = false)]

        public string CaChain { get; set; }


        /// <summary>
        /// Certificate
        /// </summary>
        /// <value>Certificate</value>
        [DataMember(Name = "certificate", EmitDefaultValue = false)]

        public string Certificate { get; set; }


        /// <summary>
        /// ID of the issuer
        /// </summary>
        /// <value>ID of the issuer</value>
        [DataMember(Name = "issuer_id", EmitDefaultValue = false)]

        public string IssuerId { get; set; }


        /// <summary>
        /// Revocation time
        /// </summary>
        /// <value>Revocation time</value>
        [DataMember(Name = "revocation_time", EmitDefaultValue = false)]

        public long RevocationTime { get; set; }


        /// <summary>
        /// Revocation time RFC 3339 formatted
        /// </summary>
        /// <value>Revocation time RFC 3339 formatted</value>
        [DataMember(Name = "revocation_time_rfc3339", EmitDefaultValue = false)]

        public string RevocationTimeRfc3339 { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiReadCertRawPemResponse {\n");
            sb.Append("  CaChain: ").Append(CaChain).Append("\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  IssuerId: ").Append(IssuerId).Append("\n");
            sb.Append("  RevocationTime: ").Append(RevocationTime).Append("\n");
            sb.Append("  RevocationTimeRfc3339: ").Append(RevocationTimeRfc3339).Append("\n");
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
            return this.Equals(input as PkiReadCertRawPemResponse);
        }

        /// <summary>
        /// Returns true if PkiReadCertRawPemResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiReadCertRawPemResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiReadCertRawPemResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.CaChain == input.CaChain ||
                    (this.CaChain != null &&
                    this.CaChain.Equals(input.CaChain))

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
                    this.RevocationTime == input.RevocationTime ||

                    this.RevocationTime.Equals(input.RevocationTime)
                ) &&
                (
                    this.RevocationTimeRfc3339 == input.RevocationTimeRfc3339 ||
                    (this.RevocationTimeRfc3339 != null &&
                    this.RevocationTimeRfc3339.Equals(input.RevocationTimeRfc3339))

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


                hashCode = (hashCode * 59) + this.RevocationTime.GetHashCode();
                if (this.RevocationTimeRfc3339 != null)
                {
                    hashCode = (hashCode * 59) + this.RevocationTimeRfc3339.GetHashCode();
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
