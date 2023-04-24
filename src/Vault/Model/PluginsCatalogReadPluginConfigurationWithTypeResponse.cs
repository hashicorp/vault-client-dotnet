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
    /// PluginsCatalogReadPluginConfigurationWithTypeResponse
    /// </summary>
    [DataContract(Name = "PluginsCatalogReadPluginConfigurationWithTypeResponse")]
    public partial class PluginsCatalogReadPluginConfigurationWithTypeResponse : IEquatable<PluginsCatalogReadPluginConfigurationWithTypeResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PluginsCatalogReadPluginConfigurationWithTypeResponse" /> class.
        /// </summary>

        /// <param name="Args">The args passed to plugin command..</param>

        /// <param name="Builtin">Builtin.</param>

        /// <param name="Command">The command used to start the plugin. The executable defined in this command must exist in vault&#x27;s plugin directory..</param>

        /// <param name="DeprecationStatus">DeprecationStatus.</param>

        /// <param name="Name">The name of the plugin.</param>

        /// <param name="Sha256">The SHA256 sum of the executable used in the command field. This should be HEX encoded..</param>

        /// <param name="_Version">The semantic version of the plugin to use..</param>


        public PluginsCatalogReadPluginConfigurationWithTypeResponse(List<string> Args = default(List<string>), bool Builtin = default(bool), string Command = default(string), string DeprecationStatus = default(string), string Name = default(string), string Sha256 = default(string), string _Version = default(string))
        {

            this.Args = Args;

            this.Builtin = Builtin;

            this.Command = Command;

            this.DeprecationStatus = DeprecationStatus;

            this.Name = Name;

            this.Sha256 = Sha256;

            this._Version = _Version;

        }

        /// <summary>
        /// The args passed to plugin command.
        /// </summary>
        /// <value>The args passed to plugin command.</value>
        [DataMember(Name = "args", EmitDefaultValue = false)]

        public List<string> Args { get; set; }


        /// <summary>
        /// Gets or Sets Builtin
        /// </summary>
        [DataMember(Name = "builtin", EmitDefaultValue = true)]

        public bool Builtin { get; set; }


        /// <summary>
        /// The command used to start the plugin. The executable defined in this command must exist in vault&#x27;s plugin directory.
        /// </summary>
        /// <value>The command used to start the plugin. The executable defined in this command must exist in vault&#x27;s plugin directory.</value>
        [DataMember(Name = "command", EmitDefaultValue = false)]

        public string Command { get; set; }


        /// <summary>
        /// Gets or Sets DeprecationStatus
        /// </summary>
        [DataMember(Name = "deprecation_status", EmitDefaultValue = false)]

        public string DeprecationStatus { get; set; }


        /// <summary>
        /// The name of the plugin
        /// </summary>
        /// <value>The name of the plugin</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]

        public string Name { get; set; }


        /// <summary>
        /// The SHA256 sum of the executable used in the command field. This should be HEX encoded.
        /// </summary>
        /// <value>The SHA256 sum of the executable used in the command field. This should be HEX encoded.</value>
        [DataMember(Name = "sha256", EmitDefaultValue = false)]

        public string Sha256 { get; set; }


        /// <summary>
        /// The semantic version of the plugin to use.
        /// </summary>
        /// <value>The semantic version of the plugin to use.</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]

        public string _Version { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PluginsCatalogReadPluginConfigurationWithTypeResponse {\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
            sb.Append("  Builtin: ").Append(Builtin).Append("\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
            sb.Append("  DeprecationStatus: ").Append(DeprecationStatus).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Sha256: ").Append(Sha256).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
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
            return this.Equals(input as PluginsCatalogReadPluginConfigurationWithTypeResponse);
        }

        /// <summary>
        /// Returns true if PluginsCatalogReadPluginConfigurationWithTypeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PluginsCatalogReadPluginConfigurationWithTypeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PluginsCatalogReadPluginConfigurationWithTypeResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Args == input.Args ||
                    this.Args != null &&
                    input.Args != null &&
                    this.Args.SequenceEqual(input.Args)
                ) &&
                (
                    this.Builtin == input.Builtin ||

                    this.Builtin.Equals(input.Builtin)
                ) &&
                (
                    this.Command == input.Command ||
                    (this.Command != null &&
                    this.Command.Equals(input.Command))

                ) &&
                (
                    this.DeprecationStatus == input.DeprecationStatus ||
                    (this.DeprecationStatus != null &&
                    this.DeprecationStatus.Equals(input.DeprecationStatus))

                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))

                ) &&
                (
                    this.Sha256 == input.Sha256 ||
                    (this.Sha256 != null &&
                    this.Sha256.Equals(input.Sha256))

                ) &&
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))

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

                if (this.Args != null)
                {
                    hashCode = (hashCode * 59) + this.Args.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Builtin.GetHashCode();
                if (this.Command != null)
                {
                    hashCode = (hashCode * 59) + this.Command.GetHashCode();
                }

                if (this.DeprecationStatus != null)
                {
                    hashCode = (hashCode * 59) + this.DeprecationStatus.GetHashCode();
                }

                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }

                if (this.Sha256 != null)
                {
                    hashCode = (hashCode * 59) + this.Sha256.GetHashCode();
                }

                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
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