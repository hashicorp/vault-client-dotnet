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
    /// GenerateRandomRequest
    /// </summary>
    [DataContract(Name = "GenerateRandomRequest")]
    public partial class GenerateRandomRequest : IEquatable<GenerateRandomRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRandomRequest" /> class.
        /// </summary>

        /// <param name="Bytes">The number of bytes to generate (POST body parameter). Defaults to 32 (256 bits). (default to 32).</param>

        /// <param name="Format">Encoding format to use. Can be \&quot;hex\&quot; or \&quot;base64\&quot;. Defaults to \&quot;base64\&quot;. (default to &quot;base64&quot;).</param>

        /// <param name="Source">Which system to source random data from, ether \&quot;platform\&quot;, \&quot;seal\&quot;, or \&quot;all\&quot;. (default to &quot;platform&quot;).</param>

        /// <param name="Urlbytes">The number of bytes to generate (POST URL parameter).</param>


        public GenerateRandomRequest(int Bytes = 32, string Format = "base64", string Source = "platform", string Urlbytes = default(string))
        {

            this.Bytes = Bytes;

            // use default value if no "Format" provided
            this.Format = Format ?? "base64";


            // use default value if no "Source" provided
            this.Source = Source ?? "platform";


            this.Urlbytes = Urlbytes;

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
            sb.Append("class GenerateRandomRequest {\n");
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
            return this.Equals(input as GenerateRandomRequest);
        }

        /// <summary>
        /// Returns true if GenerateRandomRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GenerateRandomRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerateRandomRequest input)
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