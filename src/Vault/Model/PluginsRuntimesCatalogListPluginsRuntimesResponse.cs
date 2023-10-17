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
    /// PluginsRuntimesCatalogListPluginsRuntimesResponse
    /// </summary>
    [DataContract(Name = "PluginsRuntimesCatalogListPluginsRuntimesResponse")]
    public partial class PluginsRuntimesCatalogListPluginsRuntimesResponse : IEquatable<PluginsRuntimesCatalogListPluginsRuntimesResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PluginsRuntimesCatalogListPluginsRuntimesResponse" /> class.
        /// </summary>

        /// <param name="Runtimes">List of all plugin runtimes in the catalog.</param>


        public PluginsRuntimesCatalogListPluginsRuntimesResponse(List<Object> Runtimes = default(List<Object>))
        {

            this.Runtimes = Runtimes;

        }

        /// <summary>
        /// List of all plugin runtimes in the catalog
        /// </summary>
        /// <value>List of all plugin runtimes in the catalog</value>
        [DataMember(Name = "runtimes", EmitDefaultValue = false)]

        public List<Object> Runtimes { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PluginsRuntimesCatalogListPluginsRuntimesResponse {\n");
            sb.Append("  Runtimes: ").Append(Runtimes).Append("\n");
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
            return this.Equals(input as PluginsRuntimesCatalogListPluginsRuntimesResponse);
        }

        /// <summary>
        /// Returns true if PluginsRuntimesCatalogListPluginsRuntimesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PluginsRuntimesCatalogListPluginsRuntimesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PluginsRuntimesCatalogListPluginsRuntimesResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Runtimes == input.Runtimes ||
                    this.Runtimes != null &&
                    input.Runtimes != null &&
                    this.Runtimes.SequenceEqual(input.Runtimes)
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

                if (this.Runtimes != null)
                {
                    hashCode = (hashCode * 59) + this.Runtimes.GetHashCode();
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
