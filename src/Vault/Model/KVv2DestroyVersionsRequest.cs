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
    /// KVv2DestroyVersionsRequest
    /// </summary>
    [DataContract(Name = "KVv2DestroyVersionsRequest")]
    public partial class KVv2DestroyVersionsRequest : IEquatable<KVv2DestroyVersionsRequest>, IValidatableObject
    {





        /// <summary>
        /// Initializes a new instance of the <see cref="KVv2DestroyVersionsRequest" /> class.
        /// </summary>

        /// <param name="Versions">The versions to destroy. Their data will be permanently deleted..</param>


        public KVv2DestroyVersionsRequest(List<int> Versions = default(List<int>))
        {

            this.Versions = Versions;

        }

        /// <summary>
        /// The versions to destroy. Their data will be permanently deleted.
        /// </summary>
        /// <value>The versions to destroy. Their data will be permanently deleted.</value>
        [DataMember(Name = "versions", EmitDefaultValue = false)]


        public List<int> Versions { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KVv2DestroyVersionsRequest {\n");
            sb.Append("  Versions: ").Append(Versions).Append("\n");
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
            return this.Equals(input as KVv2DestroyVersionsRequest);
        }

        /// <summary>
        /// Returns true if KVv2DestroyVersionsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of KVv2DestroyVersionsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KVv2DestroyVersionsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Versions == input.Versions ||
                    this.Versions != null &&
                    input.Versions != null &&
                    this.Versions.SequenceEqual(input.Versions)
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

                if (this.Versions != null)
                {
                    hashCode = (hashCode * 59) + this.Versions.GetHashCode();
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
