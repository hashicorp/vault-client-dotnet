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
    /// CorsReadConfigurationResponse
    /// </summary>
    [DataContract(Name = "CorsReadConfigurationResponse")]
    public partial class CorsReadConfigurationResponse : IEquatable<CorsReadConfigurationResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="CorsReadConfigurationResponse" /> class.
        /// </summary>

        /// <param name="AllowedHeaders">AllowedHeaders.</param>

        /// <param name="AllowedOrigins">AllowedOrigins.</param>

        /// <param name="Enabled">Enabled.</param>


        public CorsReadConfigurationResponse(List<string> AllowedHeaders = default(List<string>), List<string> AllowedOrigins = default(List<string>), bool Enabled = default(bool))
        {

            this.AllowedHeaders = AllowedHeaders;

            this.AllowedOrigins = AllowedOrigins;

            this.Enabled = Enabled;

        }

        /// <summary>
        /// Gets or Sets AllowedHeaders
        /// </summary>
        [DataMember(Name = "allowed_headers", EmitDefaultValue = false)]

        public List<string> AllowedHeaders { get; set; }


        /// <summary>
        /// Gets or Sets AllowedOrigins
        /// </summary>
        [DataMember(Name = "allowed_origins", EmitDefaultValue = false)]

        public List<string> AllowedOrigins { get; set; }


        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]

        public bool Enabled { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CorsReadConfigurationResponse {\n");
            sb.Append("  AllowedHeaders: ").Append(AllowedHeaders).Append("\n");
            sb.Append("  AllowedOrigins: ").Append(AllowedOrigins).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(input as CorsReadConfigurationResponse);
        }

        /// <summary>
        /// Returns true if CorsReadConfigurationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CorsReadConfigurationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CorsReadConfigurationResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AllowedHeaders == input.AllowedHeaders ||
                    this.AllowedHeaders != null &&
                    input.AllowedHeaders != null &&
                    this.AllowedHeaders.SequenceEqual(input.AllowedHeaders)
                ) &&
                (
                    this.AllowedOrigins == input.AllowedOrigins ||
                    this.AllowedOrigins != null &&
                    input.AllowedOrigins != null &&
                    this.AllowedOrigins.SequenceEqual(input.AllowedOrigins)
                ) &&
                (
                    this.Enabled == input.Enabled ||

                    this.Enabled.Equals(input.Enabled)
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

                if (this.AllowedHeaders != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedHeaders.GetHashCode();
                }

                if (this.AllowedOrigins != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedOrigins.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
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
