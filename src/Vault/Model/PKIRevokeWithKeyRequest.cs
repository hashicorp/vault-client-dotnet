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
    /// PKIRevokeWithKeyRequest
    /// </summary>
    [DataContract(Name = "PKIRevokeWithKeyRequest")]
    public partial class PKIRevokeWithKeyRequest : IEquatable<PKIRevokeWithKeyRequest>, IValidatableObject
    {





        /// <summary>
        /// Initializes a new instance of the <see cref="PKIRevokeWithKeyRequest" /> class.
        /// </summary>

        /// <param name="Certificate">Certificate to revoke in PEM format; must be signed by an issuer in this mount..</param>

        /// <param name="PrivateKey">Key to use to verify revocation permission; must be in PEM format..</param>

        /// <param name="SerialNumber">Certificate serial number, in colon- or hyphen-separated octal.</param>


        public PKIRevokeWithKeyRequest(string Certificate = default(string), string PrivateKey = default(string), string SerialNumber = default(string))
        {

            this.Certificate = Certificate;

            this.PrivateKey = PrivateKey;

            this.SerialNumber = SerialNumber;

        }

        /// <summary>
        /// Certificate to revoke in PEM format; must be signed by an issuer in this mount.
        /// </summary>
        /// <value>Certificate to revoke in PEM format; must be signed by an issuer in this mount.</value>
        [DataMember(Name = "certificate", EmitDefaultValue = false)]

        public string Certificate { get; set; }


        /// <summary>
        /// Key to use to verify revocation permission; must be in PEM format.
        /// </summary>
        /// <value>Key to use to verify revocation permission; must be in PEM format.</value>
        [DataMember(Name = "private_key", EmitDefaultValue = false)]

        public string PrivateKey { get; set; }


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
            sb.Append("class PKIRevokeWithKeyRequest {\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  PrivateKey: ").Append(PrivateKey).Append("\n");
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
            return this.Equals(input as PKIRevokeWithKeyRequest);
        }

        /// <summary>
        /// Returns true if PKIRevokeWithKeyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PKIRevokeWithKeyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PKIRevokeWithKeyRequest input)
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
                    this.PrivateKey == input.PrivateKey ||
                    (this.PrivateKey != null &&
                    this.PrivateKey.Equals(input.PrivateKey))

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

                if (this.PrivateKey != null)
                {
                    hashCode = (hashCode * 59) + this.PrivateKey.GetHashCode();
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
