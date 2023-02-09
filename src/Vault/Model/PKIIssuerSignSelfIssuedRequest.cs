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
    /// PKIIssuerSignSelfIssuedRequest
    /// </summary>
    [DataContract(Name = "PKIIssuerSignSelfIssuedRequest")]
    public partial class PKIIssuerSignSelfIssuedRequest : IEquatable<PKIIssuerSignSelfIssuedRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PKIIssuerSignSelfIssuedRequest" /> class.
        /// </summary>
        /// <param name="certificate">PEM-format self-issued certificate to be signed..</param>
        /// <param name="requireMatchingCertificateAlgorithms">If true, require the public key algorithm of the signer to match that of the self issued certificate. (default to false).</param>
        public PKIIssuerSignSelfIssuedRequest(string certificate = default(string), bool requireMatchingCertificateAlgorithms = false)
        {
            this.Certificate = certificate;
            this.RequireMatchingCertificateAlgorithms = requireMatchingCertificateAlgorithms;
        }

        /// <summary>
        /// PEM-format self-issued certificate to be signed.
        /// </summary>
        /// <value>PEM-format self-issued certificate to be signed.</value>
        [DataMember(Name = "certificate", EmitDefaultValue = false)]
        public string Certificate { get; set; }

        /// <summary>
        /// If true, require the public key algorithm of the signer to match that of the self issued certificate.
        /// </summary>
        /// <value>If true, require the public key algorithm of the signer to match that of the self issued certificate.</value>
        [DataMember(Name = "require_matching_certificate_algorithms", EmitDefaultValue = true)]
        public bool RequireMatchingCertificateAlgorithms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PKIIssuerSignSelfIssuedRequest {\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  RequireMatchingCertificateAlgorithms: ").Append(RequireMatchingCertificateAlgorithms).Append("\n");
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
            return this.Equals(input as PKIIssuerSignSelfIssuedRequest);
        }

        /// <summary>
        /// Returns true if PKIIssuerSignSelfIssuedRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PKIIssuerSignSelfIssuedRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PKIIssuerSignSelfIssuedRequest input)
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
                    this.RequireMatchingCertificateAlgorithms == input.RequireMatchingCertificateAlgorithms ||
                    this.RequireMatchingCertificateAlgorithms.Equals(input.RequireMatchingCertificateAlgorithms)
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
                hashCode = (hashCode * 59) + this.RequireMatchingCertificateAlgorithms.GetHashCode();
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
