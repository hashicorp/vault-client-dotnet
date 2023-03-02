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
    /// PKIRootSignSelfIssuedRequest
    /// </summary>
    [DataContract(Name = "PKIRootSignSelfIssuedRequest")]

    public partial class PKIRootSignSelfIssuedRequest : IEquatable<PKIRootSignSelfIssuedRequest>, IValidatableObject
    {









        /// <summary>
        /// Initializes a new instance of the <see cref="PKIRootSignSelfIssuedRequest" /> class.
        /// </summary>

        /// <param name="Certificate">PEM-format self-issued certificate to be signed..</param>

        /// <param name="IssuerRef">Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. (default to &quot;default&quot;).</param>

        /// <param name="RequireMatchingCertificateAlgorithms">If true, require the public key algorithm of the signer to match that of the self issued certificate. (default to false).</param>


        public PKIRootSignSelfIssuedRequest(string Certificate = default(string), string IssuerRef = "default", bool RequireMatchingCertificateAlgorithms = false)
        {

            this.Certificate = Certificate;

            // use default value if no "IssuerRef" provided
            this.IssuerRef = IssuerRef ?? "default";


            this.RequireMatchingCertificateAlgorithms = RequireMatchingCertificateAlgorithms;

        }

        /// <summary>
        /// PEM-format self-issued certificate to be signed.
        /// </summary>
        /// <value>PEM-format self-issued certificate to be signed.</value>
        [DataMember(Name = "certificate", EmitDefaultValue = false)]


        public string Certificate { get; set; }


        /// <summary>
        /// Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer.
        /// </summary>
        /// <value>Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer.</value>
        [DataMember(Name = "issuer_ref", EmitDefaultValue = false)]


        public string IssuerRef { get; set; }


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
            sb.Append("class PKIRootSignSelfIssuedRequest {\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  IssuerRef: ").Append(IssuerRef).Append("\n");
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
            return this.Equals(input as PKIRootSignSelfIssuedRequest);
        }

        /// <summary>
        /// Returns true if PKIRootSignSelfIssuedRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PKIRootSignSelfIssuedRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PKIRootSignSelfIssuedRequest input)
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
                    this.IssuerRef == input.IssuerRef ||
                    (this.IssuerRef != null &&
                    this.IssuerRef.Equals(input.IssuerRef))

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

                if (this.IssuerRef != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerRef.GetHashCode();
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
