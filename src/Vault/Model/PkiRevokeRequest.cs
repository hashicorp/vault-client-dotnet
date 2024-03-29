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
    /// PkiRevokeRequest
    /// </summary>
    [DataContract(Name = "PkiRevokeRequest")]
    public partial class PkiRevokeRequest : IEquatable<PkiRevokeRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PkiRevokeRequest" /> class.
        /// </summary>

        /// <param name="Certificate">Certificate to revoke in PEM format; must be signed by an issuer in this mount..</param>

        /// <param name="SerialNumber">Certificate serial number, in colon- or hyphen-separated octal.</param>


        public PkiRevokeRequest(string Certificate = default(string), string SerialNumber = default(string))
        {

            this.Certificate = Certificate;

            this.SerialNumber = SerialNumber;

        }

        /// <summary>
        /// Certificate to revoke in PEM format; must be signed by an issuer in this mount.
        /// </summary>
        /// <value>Certificate to revoke in PEM format; must be signed by an issuer in this mount.</value>
        [DataMember(Name = "certificate", EmitDefaultValue = false)]

        public string Certificate { get; set; }


        /// <summary>
        /// Certificate serial number, in colon- or hyphen-separated octal
        /// </summary>
        /// <value>Certificate serial number, in colon- or hyphen-separated octal</value>
        [DataMember(Name = "serial_number", EmitDefaultValue = false)]

        public string SerialNumber { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiRevokeRequest {\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
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
            return this.Equals(input as PkiRevokeRequest);
        }

        /// <summary>
        /// Returns true if PkiRevokeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiRevokeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiRevokeRequest input)
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

                if (this.Certificate != null)
                {
                    hashCode = (hashCode * 59) + this.Certificate.GetHashCode();
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
