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
    /// ToolsGenerateRandomSourceBytesRequest
    /// </summary>
    [DataContract(Name = "ToolsGenerateRandomSourceBytesRequest")]

    public partial class ToolsGenerateRandomSourceBytesRequest : IEquatable<ToolsGenerateRandomSourceBytesRequest>, IValidatableObject
    {







        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGenerateRandomSourceBytesRequest" /> class.
        /// </summary>

        /// <param name="Bytes">The number of bytes to generate (POST body parameter). Defaults to 32 (256 bits). (default to 32).</param>

        /// <param name="Format">Encoding format to use. Can be \&quot;hex\&quot; or \&quot;base64\&quot;. Defaults to \&quot;base64\&quot;. (default to &quot;base64&quot;).</param>


        public ToolsGenerateRandomSourceBytesRequest(int Bytes = 32, string Format = "base64")
        {

            this.Bytes = Bytes;

            // use default value if no "Format" provided
            this.Format = Format ?? "base64";


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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ToolsGenerateRandomSourceBytesRequest {\n");
            sb.Append("  Bytes: ").Append(Bytes).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
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
            return this.Equals(input as ToolsGenerateRandomSourceBytesRequest);
        }

        /// <summary>
        /// Returns true if ToolsGenerateRandomSourceBytesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ToolsGenerateRandomSourceBytesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ToolsGenerateRandomSourceBytesRequest input)
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
