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
    /// WriteInternalCountersConfigRequest
    /// </summary>
    [DataContract(Name = "WriteInternalCountersConfigRequest")]
    public partial class WriteInternalCountersConfigRequest : IEquatable<WriteInternalCountersConfigRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="WriteInternalCountersConfigRequest" /> class.
        /// </summary>

        /// <param name="DefaultReportMonths">Number of months to report if no start date specified. (default to 12).</param>

        /// <param name="Enabled">Enable or disable collection of client count: enable, disable, or default. (default to &quot;default&quot;).</param>

        /// <param name="RetentionMonths">Number of months of client data to retain. Setting to 0 will clear all existing data. (default to 24).</param>


        public WriteInternalCountersConfigRequest(int DefaultReportMonths = 12, string Enabled = "default", int RetentionMonths = 24)
        {

            this.DefaultReportMonths = DefaultReportMonths;

            // use default value if no "Enabled" provided
            this.Enabled = Enabled ?? "default";


            this.RetentionMonths = RetentionMonths;

        }

        /// <summary>
        /// Number of months to report if no start date specified.
        /// </summary>
        /// <value>Number of months to report if no start date specified.</value>
        [DataMember(Name = "default_report_months", EmitDefaultValue = false)]

        public int DefaultReportMonths { get; set; }


        /// <summary>
        /// Enable or disable collection of client count: enable, disable, or default.
        /// </summary>
        /// <value>Enable or disable collection of client count: enable, disable, or default.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]

        public string Enabled { get; set; }


        /// <summary>
        /// Number of months of client data to retain. Setting to 0 will clear all existing data.
        /// </summary>
        /// <value>Number of months of client data to retain. Setting to 0 will clear all existing data.</value>
        [DataMember(Name = "retention_months", EmitDefaultValue = false)]

        public int RetentionMonths { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WriteInternalCountersConfigRequest {\n");
            sb.Append("  DefaultReportMonths: ").Append(DefaultReportMonths).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  RetentionMonths: ").Append(RetentionMonths).Append("\n");
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
            return this.Equals(input as WriteInternalCountersConfigRequest);
        }

        /// <summary>
        /// Returns true if WriteInternalCountersConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WriteInternalCountersConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WriteInternalCountersConfigRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.DefaultReportMonths == input.DefaultReportMonths ||

                    this.DefaultReportMonths.Equals(input.DefaultReportMonths)
                ) &&
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))

                ) &&
                (
                    this.RetentionMonths == input.RetentionMonths ||

                    this.RetentionMonths.Equals(input.RetentionMonths)
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


                hashCode = (hashCode * 59) + this.DefaultReportMonths.GetHashCode();
                if (this.Enabled != null)
                {
                    hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.RetentionMonths.GetHashCode();
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
