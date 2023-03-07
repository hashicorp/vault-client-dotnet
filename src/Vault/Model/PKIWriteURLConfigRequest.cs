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
    /// PKIWriteURLConfigRequest
    /// </summary>
    [DataContract(Name = "PKIWriteURLConfigRequest")]
    public partial class PKIWriteURLConfigRequest : IEquatable<PKIWriteURLConfigRequest>, IValidatableObject
    {











        /// <summary>
        /// Initializes a new instance of the <see cref="PKIWriteURLConfigRequest" /> class.
        /// </summary>

        /// <param name="CrlDistributionPoints">Comma-separated list of URLs to be used for the CRL distribution points attribute. See also RFC 5280 Section 4.2.1.13..</param>

        /// <param name="EnableTemplating">Whether or not to enabling templating of the above AIA fields. When templating is enabled the special values &#x27;{{issuer_id}}&#x27; and &#x27;{{cluster_path}}&#x27; are available, but the addresses are not checked for URI validity until issuance time. This requires /config/cluster&#x27;s path to be set on all PR Secondary clusters. (default to false).</param>

        /// <param name="IssuingCertificates">Comma-separated list of URLs to be used for the issuing certificate attribute. See also RFC 5280 Section 4.2.2.1..</param>

        /// <param name="OcspServers">Comma-separated list of URLs to be used for the OCSP servers attribute. See also RFC 5280 Section 4.2.2.1..</param>


        public PKIWriteURLConfigRequest(List<string> CrlDistributionPoints = default(List<string>), bool EnableTemplating = false, List<string> IssuingCertificates = default(List<string>), List<string> OcspServers = default(List<string>))
        {

            this.CrlDistributionPoints = CrlDistributionPoints;

            this.EnableTemplating = EnableTemplating;

            this.IssuingCertificates = IssuingCertificates;

            this.OcspServers = OcspServers;

        }

        /// <summary>
        /// Comma-separated list of URLs to be used for the CRL distribution points attribute. See also RFC 5280 Section 4.2.1.13.
        /// </summary>
        /// <value>Comma-separated list of URLs to be used for the CRL distribution points attribute. See also RFC 5280 Section 4.2.1.13.</value>
        [DataMember(Name = "crl_distribution_points", EmitDefaultValue = false)]


        public List<string> CrlDistributionPoints { get; set; }


        /// <summary>
        /// Whether or not to enabling templating of the above AIA fields. When templating is enabled the special values &#x27;{{issuer_id}}&#x27; and &#x27;{{cluster_path}}&#x27; are available, but the addresses are not checked for URI validity until issuance time. This requires /config/cluster&#x27;s path to be set on all PR Secondary clusters.
        /// </summary>
        /// <value>Whether or not to enabling templating of the above AIA fields. When templating is enabled the special values &#x27;{{issuer_id}}&#x27; and &#x27;{{cluster_path}}&#x27; are available, but the addresses are not checked for URI validity until issuance time. This requires /config/cluster&#x27;s path to be set on all PR Secondary clusters.</value>
        [DataMember(Name = "enable_templating", EmitDefaultValue = true)]


        public bool EnableTemplating { get; set; }


        /// <summary>
        /// Comma-separated list of URLs to be used for the issuing certificate attribute. See also RFC 5280 Section 4.2.2.1.
        /// </summary>
        /// <value>Comma-separated list of URLs to be used for the issuing certificate attribute. See also RFC 5280 Section 4.2.2.1.</value>
        [DataMember(Name = "issuing_certificates", EmitDefaultValue = false)]


        public List<string> IssuingCertificates { get; set; }


        /// <summary>
        /// Comma-separated list of URLs to be used for the OCSP servers attribute. See also RFC 5280 Section 4.2.2.1.
        /// </summary>
        /// <value>Comma-separated list of URLs to be used for the OCSP servers attribute. See also RFC 5280 Section 4.2.2.1.</value>
        [DataMember(Name = "ocsp_servers", EmitDefaultValue = false)]


        public List<string> OcspServers { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PKIWriteURLConfigRequest {\n");
            sb.Append("  CrlDistributionPoints: ").Append(CrlDistributionPoints).Append("\n");
            sb.Append("  EnableTemplating: ").Append(EnableTemplating).Append("\n");
            sb.Append("  IssuingCertificates: ").Append(IssuingCertificates).Append("\n");
            sb.Append("  OcspServers: ").Append(OcspServers).Append("\n");
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
            return this.Equals(input as PKIWriteURLConfigRequest);
        }

        /// <summary>
        /// Returns true if PKIWriteURLConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PKIWriteURLConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PKIWriteURLConfigRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.CrlDistributionPoints == input.CrlDistributionPoints ||
                    this.CrlDistributionPoints != null &&
                    input.CrlDistributionPoints != null &&
                    this.CrlDistributionPoints.SequenceEqual(input.CrlDistributionPoints)
                ) &&
                (
                    this.EnableTemplating == input.EnableTemplating ||

                    this.EnableTemplating.Equals(input.EnableTemplating)
                ) &&
                (
                    this.IssuingCertificates == input.IssuingCertificates ||
                    this.IssuingCertificates != null &&
                    input.IssuingCertificates != null &&
                    this.IssuingCertificates.SequenceEqual(input.IssuingCertificates)
                ) &&
                (
                    this.OcspServers == input.OcspServers ||
                    this.OcspServers != null &&
                    input.OcspServers != null &&
                    this.OcspServers.SequenceEqual(input.OcspServers)
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

                if (this.CrlDistributionPoints != null)
                {
                    hashCode = (hashCode * 59) + this.CrlDistributionPoints.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.EnableTemplating.GetHashCode();
                if (this.IssuingCertificates != null)
                {
                    hashCode = (hashCode * 59) + this.IssuingCertificates.GetHashCode();
                }

                if (this.OcspServers != null)
                {
                    hashCode = (hashCode * 59) + this.OcspServers.GetHashCode();
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
