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
    /// CertificatesWriteCRLRequest
    /// </summary>
    [DataContract(Name = "CertificatesWriteCRLRequest")]
    public partial class CertificatesWriteCRLRequest : IEquatable<CertificatesWriteCRLRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="CertificatesWriteCRLRequest" /> class.
        /// </summary>

        /// <param name="Crl">The public CRL that should be trusted to attest to certificates&#x27; validity statuses. May be DER or PEM encoded. Note: the expiration time is ignored; if the CRL is no longer valid, delete it using the same name as specified here..</param>

        /// <param name="Url">The URL of a CRL distribution point. Only one of &#x27;crl&#x27; or &#x27;url&#x27; parameters should be specified..</param>


        public CertificatesWriteCRLRequest(string Crl = default(string), string Url = default(string))
        {

            this.Crl = Crl;

            this.Url = Url;

        }

        /// <summary>
        /// The public CRL that should be trusted to attest to certificates&#x27; validity statuses. May be DER or PEM encoded. Note: the expiration time is ignored; if the CRL is no longer valid, delete it using the same name as specified here.
        /// </summary>
        /// <value>The public CRL that should be trusted to attest to certificates&#x27; validity statuses. May be DER or PEM encoded. Note: the expiration time is ignored; if the CRL is no longer valid, delete it using the same name as specified here.</value>
        [DataMember(Name = "crl", EmitDefaultValue = false)]

        public string Crl { get; set; }


        /// <summary>
        /// The URL of a CRL distribution point. Only one of &#x27;crl&#x27; or &#x27;url&#x27; parameters should be specified.
        /// </summary>
        /// <value>The URL of a CRL distribution point. Only one of &#x27;crl&#x27; or &#x27;url&#x27; parameters should be specified.</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]

        public string Url { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CertificatesWriteCRLRequest {\n");
            sb.Append("  Crl: ").Append(Crl).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as CertificatesWriteCRLRequest);
        }

        /// <summary>
        /// Returns true if CertificatesWriteCRLRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CertificatesWriteCRLRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CertificatesWriteCRLRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Crl == input.Crl ||
                    (this.Crl != null &&
                    this.Crl.Equals(input.Crl))

                ) &&
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))

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

                if (this.Crl != null)
                {
                    hashCode = (hashCode * 59) + this.Crl.GetHashCode();
                }

                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
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
