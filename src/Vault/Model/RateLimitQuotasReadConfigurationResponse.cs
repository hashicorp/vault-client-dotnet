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
    /// RateLimitQuotasReadConfigurationResponse
    /// </summary>
    [DataContract(Name = "RateLimitQuotasReadConfigurationResponse")]
    public partial class RateLimitQuotasReadConfigurationResponse : IEquatable<RateLimitQuotasReadConfigurationResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitQuotasReadConfigurationResponse" /> class.
        /// </summary>

        /// <param name="EnableRateLimitAuditLogging">EnableRateLimitAuditLogging.</param>

        /// <param name="EnableRateLimitResponseHeaders">EnableRateLimitResponseHeaders.</param>

        /// <param name="RateLimitExemptPaths">RateLimitExemptPaths.</param>


        public RateLimitQuotasReadConfigurationResponse(bool EnableRateLimitAuditLogging = default(bool), bool EnableRateLimitResponseHeaders = default(bool), List<string> RateLimitExemptPaths = default(List<string>))
        {

            this.EnableRateLimitAuditLogging = EnableRateLimitAuditLogging;

            this.EnableRateLimitResponseHeaders = EnableRateLimitResponseHeaders;

            this.RateLimitExemptPaths = RateLimitExemptPaths;

        }

        /// <summary>
        /// Gets or Sets EnableRateLimitAuditLogging
        /// </summary>
        [DataMember(Name = "enable_rate_limit_audit_logging", EmitDefaultValue = true)]

        public bool EnableRateLimitAuditLogging { get; set; }


        /// <summary>
        /// Gets or Sets EnableRateLimitResponseHeaders
        /// </summary>
        [DataMember(Name = "enable_rate_limit_response_headers", EmitDefaultValue = true)]

        public bool EnableRateLimitResponseHeaders { get; set; }


        /// <summary>
        /// Gets or Sets RateLimitExemptPaths
        /// </summary>
        [DataMember(Name = "rate_limit_exempt_paths", EmitDefaultValue = false)]

        public List<string> RateLimitExemptPaths { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RateLimitQuotasReadConfigurationResponse {\n");
            sb.Append("  EnableRateLimitAuditLogging: ").Append(EnableRateLimitAuditLogging).Append("\n");
            sb.Append("  EnableRateLimitResponseHeaders: ").Append(EnableRateLimitResponseHeaders).Append("\n");
            sb.Append("  RateLimitExemptPaths: ").Append(RateLimitExemptPaths).Append("\n");
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
            return this.Equals(input as RateLimitQuotasReadConfigurationResponse);
        }

        /// <summary>
        /// Returns true if RateLimitQuotasReadConfigurationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RateLimitQuotasReadConfigurationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RateLimitQuotasReadConfigurationResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.EnableRateLimitAuditLogging == input.EnableRateLimitAuditLogging ||

                    this.EnableRateLimitAuditLogging.Equals(input.EnableRateLimitAuditLogging)
                ) &&
                (
                    this.EnableRateLimitResponseHeaders == input.EnableRateLimitResponseHeaders ||

                    this.EnableRateLimitResponseHeaders.Equals(input.EnableRateLimitResponseHeaders)
                ) &&
                (
                    this.RateLimitExemptPaths == input.RateLimitExemptPaths ||
                    this.RateLimitExemptPaths != null &&
                    input.RateLimitExemptPaths != null &&
                    this.RateLimitExemptPaths.SequenceEqual(input.RateLimitExemptPaths)
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


                hashCode = (hashCode * 59) + this.EnableRateLimitAuditLogging.GetHashCode();

                hashCode = (hashCode * 59) + this.EnableRateLimitResponseHeaders.GetHashCode();
                if (this.RateLimitExemptPaths != null)
                {
                    hashCode = (hashCode * 59) + this.RateLimitExemptPaths.GetHashCode();
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
