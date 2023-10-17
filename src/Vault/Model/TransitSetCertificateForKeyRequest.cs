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
    /// TransitSetCertificateForKeyRequest
    /// </summary>
    [DataContract(Name = "TransitSetCertificateForKeyRequest")]
    public partial class TransitSetCertificateForKeyRequest : IEquatable<TransitSetCertificateForKeyRequest>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TransitSetCertificateForKeyRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransitSetCertificateForKeyRequest() { }


        /// <summary>
        /// Initializes a new instance of the <see cref="TransitSetCertificateForKeyRequest" /> class.
        /// </summary>

        /// <param name="CertificateChain">PEM encoded certificate chain. It should be composed by one or more concatenated PEM blocks and ordered starting from the end-entity certificate. (required).</param>

        /// <param name="_Version">Optional version of key, &#x27;latest&#x27; if not set.</param>


        public TransitSetCertificateForKeyRequest(string CertificateChain = default(string), int _Version = default(int))
        {

            // to ensure "CertificateChain" is required (not null)
            if (CertificateChain == null)
            {
                throw new ArgumentNullException("CertificateChain is a required property for TransitSetCertificateForKeyRequest and cannot be null");
            }
            this.CertificateChain = CertificateChain;


            this._Version = _Version;

        }

        /// <summary>
        /// PEM encoded certificate chain. It should be composed by one or more concatenated PEM blocks and ordered starting from the end-entity certificate.
        /// </summary>
        /// <value>PEM encoded certificate chain. It should be composed by one or more concatenated PEM blocks and ordered starting from the end-entity certificate.</value>
        [DataMember(Name = "certificate_chain", IsRequired = true, EmitDefaultValue = false)]

        public string CertificateChain { get; set; }


        /// <summary>
        /// Optional version of key, &#x27;latest&#x27; if not set
        /// </summary>
        /// <value>Optional version of key, &#x27;latest&#x27; if not set</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]

        public int _Version { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransitSetCertificateForKeyRequest {\n");
            sb.Append("  CertificateChain: ").Append(CertificateChain).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
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
            return this.Equals(input as TransitSetCertificateForKeyRequest);
        }

        /// <summary>
        /// Returns true if TransitSetCertificateForKeyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransitSetCertificateForKeyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransitSetCertificateForKeyRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.CertificateChain == input.CertificateChain ||
                    (this.CertificateChain != null &&
                    this.CertificateChain.Equals(input.CertificateChain))

                ) &&
                (
                    this._Version == input._Version ||

                    this._Version.Equals(input._Version)
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

                if (this.CertificateChain != null)
                {
                    hashCode = (hashCode * 59) + this.CertificateChain.GetHashCode();
                }


                hashCode = (hashCode * 59) + this._Version.GetHashCode();
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
