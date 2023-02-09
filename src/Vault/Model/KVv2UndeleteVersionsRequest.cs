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
    /// KVv2UndeleteVersionsRequest
    /// </summary>
    [DataContract(Name = "KVv2UndeleteVersionsRequest")]
    public partial class KVv2UndeleteVersionsRequest : IEquatable<KVv2UndeleteVersionsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KVv2UndeleteVersionsRequest" /> class.
        /// </summary>
        /// <param name="versions">The versions to unarchive. The versions will be restored and their data will be returned on normal get requests..</param>
        public KVv2UndeleteVersionsRequest(List<int> versions = default(List<int>))
        {
            this.Versions = versions;
        }

        /// <summary>
        /// The versions to unarchive. The versions will be restored and their data will be returned on normal get requests.
        /// </summary>
        /// <value>The versions to unarchive. The versions will be restored and their data will be returned on normal get requests.</value>
        [DataMember(Name = "versions", EmitDefaultValue = false)]
        public List<int> Versions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KVv2UndeleteVersionsRequest {\n");
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
            return this.Equals(input as KVv2UndeleteVersionsRequest);
        }

        /// <summary>
        /// Returns true if KVv2UndeleteVersionsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of KVv2UndeleteVersionsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KVv2UndeleteVersionsRequest input)
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
