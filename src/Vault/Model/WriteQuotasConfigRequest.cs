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
    /// WriteQuotasConfigRequest
    /// </summary>
    [DataContract(Name = "WriteQuotasConfigRequest")]
    public partial class WriteQuotasConfigRequest : IEquatable<WriteQuotasConfigRequest>, IValidatableObject
    {









        /// <summary>
        /// Initializes a new instance of the <see cref="WriteQuotasConfigRequest" /> class.
        /// </summary>

        /// <param name="EnableRateLimitAuditLogging">If set, starts audit logging of requests that get rejected due to rate limit quota rule violations..</param>

        /// <param name="EnableRateLimitResponseHeaders">If set, additional rate limit quota HTTP headers will be added to responses..</param>

        /// <param name="RateLimitExemptPaths">Specifies the list of exempt paths from all rate limit quotas. If empty no paths will be exempt..</param>


        public WriteQuotasConfigRequest(bool EnableRateLimitAuditLogging = default(bool), bool EnableRateLimitResponseHeaders = default(bool), List<string> RateLimitExemptPaths = default(List<string>))
        {

            this.EnableRateLimitAuditLogging = EnableRateLimitAuditLogging;

            this.EnableRateLimitResponseHeaders = EnableRateLimitResponseHeaders;

            this.RateLimitExemptPaths = RateLimitExemptPaths;

        }

        /// <summary>
        /// If set, starts audit logging of requests that get rejected due to rate limit quota rule violations.
        /// </summary>
        /// <value>If set, starts audit logging of requests that get rejected due to rate limit quota rule violations.</value>
        [DataMember(Name = "enable_rate_limit_audit_logging", EmitDefaultValue = true)]

        public bool EnableRateLimitAuditLogging { get; set; }


        /// <summary>
        /// If set, additional rate limit quota HTTP headers will be added to responses.
        /// </summary>
        /// <value>If set, additional rate limit quota HTTP headers will be added to responses.</value>
        [DataMember(Name = "enable_rate_limit_response_headers", EmitDefaultValue = true)]

        public bool EnableRateLimitResponseHeaders { get; set; }


        /// <summary>
        /// Specifies the list of exempt paths from all rate limit quotas. If empty no paths will be exempt.
        /// </summary>
        /// <value>Specifies the list of exempt paths from all rate limit quotas. If empty no paths will be exempt.</value>
        [DataMember(Name = "rate_limit_exempt_paths", EmitDefaultValue = false)]

        public List<string> RateLimitExemptPaths { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WriteQuotasConfigRequest {\n");
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
            return this.Equals(input as WriteQuotasConfigRequest);
        }

        /// <summary>
        /// Returns true if WriteQuotasConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WriteQuotasConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WriteQuotasConfigRequest input)
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
