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
    /// KvV2DeleteVersionsRequest
    /// </summary>
    [DataContract(Name = "KvV2DeleteVersionsRequest")]
    public partial class KvV2DeleteVersionsRequest : IEquatable<KvV2DeleteVersionsRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="KvV2DeleteVersionsRequest" /> class.
        /// </summary>

        /// <param name="Versions">The versions to be archived. The versioned data will not be deleted, but it will no longer be returned in normal get requests..</param>


        public KvV2DeleteVersionsRequest(List<int> Versions = default(List<int>))
        {

            this.Versions = Versions;

        }

        /// <summary>
        /// The versions to be archived. The versioned data will not be deleted, but it will no longer be returned in normal get requests.
        /// </summary>
        /// <value>The versions to be archived. The versioned data will not be deleted, but it will no longer be returned in normal get requests.</value>
        [DataMember(Name = "versions", EmitDefaultValue = false)]

        public List<int> Versions { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KvV2DeleteVersionsRequest {\n");
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
            return this.Equals(input as KvV2DeleteVersionsRequest);
        }

        /// <summary>
        /// Returns true if KvV2DeleteVersionsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of KvV2DeleteVersionsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KvV2DeleteVersionsRequest input)
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
