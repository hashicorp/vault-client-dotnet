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
    /// PkiIssuersRotateRootResponse
    /// </summary>
    [DataContract(Name = "PkiIssuersRotateRootResponse")]
    public partial class PkiIssuersRotateRootResponse : IEquatable<PkiIssuersRotateRootResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PkiIssuersRotateRootResponse" /> class.
        /// </summary>

        /// <param name="Certificate">The generated self-signed CA certificate..</param>

        /// <param name="Expiration">The expiration of the given..</param>

        /// <param name="IssuerId">The ID of the issuer.</param>

        /// <param name="IssuerName">The name of the issuer..</param>

        /// <param name="IssuingCa">The issuing certificate authority..</param>

        /// <param name="KeyId">The ID of the key..</param>

        /// <param name="KeyName">The key name if given..</param>

        /// <param name="PrivateKey">The private key if exported was specified..</param>

        /// <param name="SerialNumber">The requested Subject&#x27;s named serial number..</param>


        public PkiIssuersRotateRootResponse(string Certificate = default(string), string Expiration = default(string), string IssuerId = default(string), string IssuerName = default(string), string IssuingCa = default(string), string KeyId = default(string), string KeyName = default(string), string PrivateKey = default(string), string SerialNumber = default(string))
        {

            this.Certificate = Certificate;

            this.Expiration = Expiration;

            this.IssuerId = IssuerId;

            this.IssuerName = IssuerName;

            this.IssuingCa = IssuingCa;

            this.KeyId = KeyId;

            this.KeyName = KeyName;

            this.PrivateKey = PrivateKey;

            this.SerialNumber = SerialNumber;

        }

        /// <summary>
        /// The generated self-signed CA certificate.
        /// </summary>
        /// <value>The generated self-signed CA certificate.</value>
        [DataMember(Name = "certificate", EmitDefaultValue = false)]

        public string Certificate { get; set; }


        /// <summary>
        /// The expiration of the given.
        /// </summary>
        /// <value>The expiration of the given.</value>
        [DataMember(Name = "expiration", EmitDefaultValue = false)]

        public string Expiration { get; set; }


        /// <summary>
        /// The ID of the issuer
        /// </summary>
        /// <value>The ID of the issuer</value>
        [DataMember(Name = "issuer_id", EmitDefaultValue = false)]

        public string IssuerId { get; set; }


        /// <summary>
        /// The name of the issuer.
        /// </summary>
        /// <value>The name of the issuer.</value>
        [DataMember(Name = "issuer_name", EmitDefaultValue = false)]

        public string IssuerName { get; set; }


        /// <summary>
        /// The issuing certificate authority.
        /// </summary>
        /// <value>The issuing certificate authority.</value>
        [DataMember(Name = "issuing_ca", EmitDefaultValue = false)]

        public string IssuingCa { get; set; }


        /// <summary>
        /// The ID of the key.
        /// </summary>
        /// <value>The ID of the key.</value>
        [DataMember(Name = "key_id", EmitDefaultValue = false)]

        public string KeyId { get; set; }


        /// <summary>
        /// The key name if given.
        /// </summary>
        /// <value>The key name if given.</value>
        [DataMember(Name = "key_name", EmitDefaultValue = false)]

        public string KeyName { get; set; }


        /// <summary>
        /// The private key if exported was specified.
        /// </summary>
        /// <value>The private key if exported was specified.</value>
        [DataMember(Name = "private_key", EmitDefaultValue = false)]

        public string PrivateKey { get; set; }


        /// <summary>
        /// The requested Subject&#x27;s named serial number.
        /// </summary>
        /// <value>The requested Subject&#x27;s named serial number.</value>
        [DataMember(Name = "serial_number", EmitDefaultValue = false)]

        public string SerialNumber { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiIssuersRotateRootResponse {\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  IssuerId: ").Append(IssuerId).Append("\n");
            sb.Append("  IssuerName: ").Append(IssuerName).Append("\n");
            sb.Append("  IssuingCa: ").Append(IssuingCa).Append("\n");
            sb.Append("  KeyId: ").Append(KeyId).Append("\n");
            sb.Append("  KeyName: ").Append(KeyName).Append("\n");
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
            return this.Equals(input as PkiIssuersRotateRootResponse);
        }

        /// <summary>
        /// Returns true if PkiIssuersRotateRootResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiIssuersRotateRootResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiIssuersRotateRootResponse input)
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
                    this.Expiration == input.Expiration ||
                    (this.Expiration != null &&
                    this.Expiration.Equals(input.Expiration))

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

                ) &&
                (
                    this.IssuingCa == input.IssuingCa ||
                    (this.IssuingCa != null &&
                    this.IssuingCa.Equals(input.IssuingCa))

                ) &&
                (
                    this.KeyId == input.KeyId ||
                    (this.KeyId != null &&
                    this.KeyId.Equals(input.KeyId))

                ) &&
                (
                    this.KeyName == input.KeyName ||
                    (this.KeyName != null &&
                    this.KeyName.Equals(input.KeyName))

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

                if (this.Expiration != null)
                {
                    hashCode = (hashCode * 59) + this.Expiration.GetHashCode();
                }

                if (this.IssuerId != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerId.GetHashCode();
                }

                if (this.IssuerName != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerName.GetHashCode();
                }

                if (this.IssuingCa != null)
                {
                    hashCode = (hashCode * 59) + this.IssuingCa.GetHashCode();
                }

                if (this.KeyId != null)
                {
                    hashCode = (hashCode * 59) + this.KeyId.GetHashCode();
                }

                if (this.KeyName != null)
                {
                    hashCode = (hashCode * 59) + this.KeyName.GetHashCode();
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
