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
    /// PluginsReloadBackendsResponse
    /// </summary>
    [DataContract(Name = "PluginsReloadBackendsResponse")]
    public partial class PluginsReloadBackendsResponse : IEquatable<PluginsReloadBackendsResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PluginsReloadBackendsResponse" /> class.
        /// </summary>

        /// <param name="ReloadId">ReloadId.</param>


        public PluginsReloadBackendsResponse(string ReloadId = default(string))
        {

            this.ReloadId = ReloadId;

        }

        /// <summary>
        /// Gets or Sets ReloadId
        /// </summary>
        [DataMember(Name = "reload_id", EmitDefaultValue = false)]

        public string ReloadId { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PluginsReloadBackendsResponse {\n");
            sb.Append("  ReloadId: ").Append(ReloadId).Append("\n");
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
            return this.Equals(input as PluginsReloadBackendsResponse);
        }

        /// <summary>
        /// Returns true if PluginsReloadBackendsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PluginsReloadBackendsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PluginsReloadBackendsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.ReloadId == input.ReloadId ||
                    (this.ReloadId != null &&
                    this.ReloadId.Equals(input.ReloadId))

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

                if (this.ReloadId != null)
                {
                    hashCode = (hashCode * 59) + this.ReloadId.GetHashCode();
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
