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
    /// WriteConfigCORSRequest
    /// </summary>
    [DataContract(Name = "WriteConfigCORSRequest")]
    public partial class WriteConfigCORSRequest : IEquatable<WriteConfigCORSRequest>, IValidatableObject
    {









        /// <summary>
        /// Initializes a new instance of the <see cref="WriteConfigCORSRequest" /> class.
        /// </summary>

        /// <param name="AllowedHeaders">A comma-separated string or array of strings indicating headers that are allowed on cross-origin requests..</param>

        /// <param name="AllowedOrigins">A comma-separated string or array of strings indicating origins that may make cross-origin requests..</param>

        /// <param name="Enable">Enables or disables CORS headers on requests..</param>


        public WriteConfigCORSRequest(List<string> AllowedHeaders = default(List<string>), List<string> AllowedOrigins = default(List<string>), bool Enable = default(bool))
        {

            this.AllowedHeaders = AllowedHeaders;

            this.AllowedOrigins = AllowedOrigins;

            this.Enable = Enable;

        }

        /// <summary>
        /// A comma-separated string or array of strings indicating headers that are allowed on cross-origin requests.
        /// </summary>
        /// <value>A comma-separated string or array of strings indicating headers that are allowed on cross-origin requests.</value>
        [DataMember(Name = "allowed_headers", EmitDefaultValue = false)]

        public List<string> AllowedHeaders { get; set; }


        /// <summary>
        /// A comma-separated string or array of strings indicating origins that may make cross-origin requests.
        /// </summary>
        /// <value>A comma-separated string or array of strings indicating origins that may make cross-origin requests.</value>
        [DataMember(Name = "allowed_origins", EmitDefaultValue = false)]

        public List<string> AllowedOrigins { get; set; }


        /// <summary>
        /// Enables or disables CORS headers on requests.
        /// </summary>
        /// <value>Enables or disables CORS headers on requests.</value>
        [DataMember(Name = "enable", EmitDefaultValue = true)]

        public bool Enable { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WriteConfigCORSRequest {\n");
            sb.Append("  AllowedHeaders: ").Append(AllowedHeaders).Append("\n");
            sb.Append("  AllowedOrigins: ").Append(AllowedOrigins).Append("\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
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
            return this.Equals(input as WriteConfigCORSRequest);
        }

        /// <summary>
        /// Returns true if WriteConfigCORSRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WriteConfigCORSRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WriteConfigCORSRequest input)
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
                    this.Enable == input.Enable ||

                    this.Enable.Equals(input.Enable)
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


                hashCode = (hashCode * 59) + this.Enable.GetHashCode();
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
