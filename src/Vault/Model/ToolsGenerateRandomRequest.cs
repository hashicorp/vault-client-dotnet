// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

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
    /// ToolsGenerateRandomRequest
    /// </summary>
    [DataContract(Name = "ToolsGenerateRandomRequest")]
    public partial class ToolsGenerateRandomRequest : IEquatable<ToolsGenerateRandomRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGenerateRandomRequest" /> class.
        /// </summary>
        /// <param name="bytes">The number of bytes to generate (POST body parameter). Defaults to 32 (256 bits). (default to 32).</param>
        /// <param name="format">Encoding format to use. Can be \&quot;hex\&quot; or \&quot;base64\&quot;. Defaults to \&quot;base64\&quot;. (default to &quot;base64&quot;).</param>
        /// <param name="source">Which system to source random data from, ether \&quot;platform\&quot;, \&quot;seal\&quot;, or \&quot;all\&quot;. (default to &quot;platform&quot;).</param>
        /// <param name="urlbytes">The number of bytes to generate (POST URL parameter).</param>
        public ToolsGenerateRandomRequest(int bytes = 32, string format = "base64", string source = "platform", string urlbytes = default(string))
        {
            this.Bytes = bytes;
            // use default value if no "format" provided
            this.Format = format ?? "base64";
            // use default value if no "source" provided
            this.Source = source ?? "platform";
            this.Urlbytes = urlbytes;
        }

        /// <summary>
        /// The number of bytes to generate (POST body parameter). Defaults to 32 (256 bits).
        /// </summary>
        /// <value>The number of bytes to generate (POST body parameter). Defaults to 32 (256 bits).</value>
        [DataMember(Name = "bytes", EmitDefaultValue = false)]
        public int Bytes { get; set; }

        /// <summary>
        /// Encoding format to use. Can be \&quot;hex\&quot; or \&quot;base64\&quot;. Defaults to \&quot;base64\&quot;.
        /// </summary>
        /// <value>Encoding format to use. Can be \&quot;hex\&quot; or \&quot;base64\&quot;. Defaults to \&quot;base64\&quot;.</value>
        [DataMember(Name = "format", EmitDefaultValue = false)]
        public string Format { get; set; }

        /// <summary>
        /// Which system to source random data from, ether \&quot;platform\&quot;, \&quot;seal\&quot;, or \&quot;all\&quot;.
        /// </summary>
        /// <value>Which system to source random data from, ether \&quot;platform\&quot;, \&quot;seal\&quot;, or \&quot;all\&quot;.</value>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// The number of bytes to generate (POST URL parameter)
        /// </summary>
        /// <value>The number of bytes to generate (POST URL parameter)</value>
        [DataMember(Name = "urlbytes", EmitDefaultValue = false)]
        public string Urlbytes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ToolsGenerateRandomRequest {\n");
            sb.Append("  Bytes: ").Append(Bytes).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Urlbytes: ").Append(Urlbytes).Append("\n");
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
            return this.Equals(input as ToolsGenerateRandomRequest);
        }

        /// <summary>
        /// Returns true if ToolsGenerateRandomRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ToolsGenerateRandomRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ToolsGenerateRandomRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Bytes == input.Bytes ||
                    this.Bytes.Equals(input.Bytes)
                ) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Urlbytes == input.Urlbytes ||
                    (this.Urlbytes != null &&
                    this.Urlbytes.Equals(input.Urlbytes))
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
                hashCode = (hashCode * 59) + this.Bytes.GetHashCode();
                if (this.Format != null)
                {
                    hashCode = (hashCode * 59) + this.Format.GetHashCode();
                }
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                if (this.Urlbytes != null)
                {
                    hashCode = (hashCode * 59) + this.Urlbytes.GetHashCode();
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
