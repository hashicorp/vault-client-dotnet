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
    /// TransitWriteCacheConfigRequest
    /// </summary>
    [DataContract(Name = "TransitWriteCacheConfigRequest")]
    public partial class TransitWriteCacheConfigRequest : IEquatable<TransitWriteCacheConfigRequest>, IValidatableObject
    {



        /// <summary>
        /// Initializes a new instance of the <see cref="TransitWriteCacheConfigRequest" /> class.
        /// </summary>

        /// <param name="Size">Size of cache, use 0 for an unlimited cache size, defaults to 0 (default to 0).</param>


        public TransitWriteCacheConfigRequest(int Size = 0)
        {

            this.Size = Size;

        }

        /// <summary>
        /// Size of cache, use 0 for an unlimited cache size, defaults to 0
        /// </summary>
        /// <value>Size of cache, use 0 for an unlimited cache size, defaults to 0</value>
        [DataMember(Name = "size", EmitDefaultValue = false)]

        public int Size { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransitWriteCacheConfigRequest {\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
            return this.Equals(input as TransitWriteCacheConfigRequest);
        }

        /// <summary>
        /// Returns true if TransitWriteCacheConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransitWriteCacheConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransitWriteCacheConfigRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Size == input.Size ||

                    this.Size.Equals(input.Size)
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


                hashCode = (hashCode * 59) + this.Size.GetHashCode();
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
