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
    /// WritePluginsReloadBackendRequest
    /// </summary>
    [DataContract(Name = "WritePluginsReloadBackendRequest")]
    public partial class WritePluginsReloadBackendRequest : IEquatable<WritePluginsReloadBackendRequest>, IValidatableObject
    {









        /// <summary>
        /// Initializes a new instance of the <see cref="WritePluginsReloadBackendRequest" /> class.
        /// </summary>

        /// <param name="Mounts">The mount paths of the plugin backends to reload..</param>

        /// <param name="Plugin">The name of the plugin to reload, as registered in the plugin catalog..</param>

        /// <param name="Scope">Scope.</param>


        public WritePluginsReloadBackendRequest(List<string> Mounts = default(List<string>), string Plugin = default(string), string Scope = default(string))
        {

            this.Mounts = Mounts;

            this.Plugin = Plugin;

            this.Scope = Scope;

        }

        /// <summary>
        /// The mount paths of the plugin backends to reload.
        /// </summary>
        /// <value>The mount paths of the plugin backends to reload.</value>
        [DataMember(Name = "mounts", EmitDefaultValue = false)]


        public List<string> Mounts { get; set; }


        /// <summary>
        /// The name of the plugin to reload, as registered in the plugin catalog.
        /// </summary>
        /// <value>The name of the plugin to reload, as registered in the plugin catalog.</value>
        [DataMember(Name = "plugin", EmitDefaultValue = false)]


        public string Plugin { get; set; }


        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name = "scope", EmitDefaultValue = false)]


        public string Scope { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WritePluginsReloadBackendRequest {\n");
            sb.Append("  Mounts: ").Append(Mounts).Append("\n");
            sb.Append("  Plugin: ").Append(Plugin).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
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
            return this.Equals(input as WritePluginsReloadBackendRequest);
        }

        /// <summary>
        /// Returns true if WritePluginsReloadBackendRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WritePluginsReloadBackendRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WritePluginsReloadBackendRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Mounts == input.Mounts ||
                    this.Mounts != null &&
                    input.Mounts != null &&
                    this.Mounts.SequenceEqual(input.Mounts)
                ) &&
                (
                    this.Plugin == input.Plugin ||
                    (this.Plugin != null &&
                    this.Plugin.Equals(input.Plugin))

                ) &&
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))

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

                if (this.Mounts != null)
                {
                    hashCode = (hashCode * 59) + this.Mounts.GetHashCode();
                }

                if (this.Plugin != null)
                {
                    hashCode = (hashCode * 59) + this.Plugin.GetHashCode();
                }

                if (this.Scope != null)
                {
                    hashCode = (hashCode * 59) + this.Scope.GetHashCode();
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
