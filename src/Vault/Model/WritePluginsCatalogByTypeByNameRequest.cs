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
    /// WritePluginsCatalogByTypeByNameRequest
    /// </summary>
    [DataContract(Name = "WritePluginsCatalogByTypeByNameRequest")]

    public partial class WritePluginsCatalogByTypeByNameRequest : IEquatable<WritePluginsCatalogByTypeByNameRequest>, IValidatableObject
    {













        /// <summary>
        /// Initializes a new instance of the <see cref="WritePluginsCatalogByTypeByNameRequest" /> class.
        /// </summary>

        /// <param name="Args">The args passed to plugin command..</param>

        /// <param name="Command">The command used to start the plugin. The executable defined in this command must exist in vault&#x27;s plugin directory..</param>

        /// <param name="Env">The environment variables passed to plugin command. Each entry is of the form \&quot;key&#x3D;value\&quot;..</param>

        /// <param name="Sha256">The SHA256 sum of the executable used in the command field. This should be HEX encoded..</param>

        /// <param name="_Version">The semantic version of the plugin to use..</param>


        public WritePluginsCatalogByTypeByNameRequest(List<string> Args = default(List<string>), string Command = default(string), List<string> Env = default(List<string>), string Sha256 = default(string), string _Version = default(string))
        {

            this.Args = Args;

            this.Command = Command;

            this.Env = Env;

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
        /// The command used to start the plugin. The executable defined in this command must exist in vault&#x27;s plugin directory.
        /// </summary>
        /// <value>The command used to start the plugin. The executable defined in this command must exist in vault&#x27;s plugin directory.</value>
        [DataMember(Name = "command", EmitDefaultValue = false)]


        public string Command { get; set; }


        /// <summary>
        /// The environment variables passed to plugin command. Each entry is of the form \&quot;key&#x3D;value\&quot;.
        /// </summary>
        /// <value>The environment variables passed to plugin command. Each entry is of the form \&quot;key&#x3D;value\&quot;.</value>
        [DataMember(Name = "env", EmitDefaultValue = false)]


        public List<string> Env { get; set; }


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
            sb.Append("class WritePluginsCatalogByTypeByNameRequest {\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
            sb.Append("  Env: ").Append(Env).Append("\n");
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
            return this.Equals(input as WritePluginsCatalogByTypeByNameRequest);
        }

        /// <summary>
        /// Returns true if WritePluginsCatalogByTypeByNameRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WritePluginsCatalogByTypeByNameRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WritePluginsCatalogByTypeByNameRequest input)
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
                    this.Command == input.Command ||
                    (this.Command != null &&
                    this.Command.Equals(input.Command))

                ) &&
                (
                    this.Env == input.Env ||
                    this.Env != null &&
                    input.Env != null &&
                    this.Env.SequenceEqual(input.Env)
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

                if (this.Command != null)
                {
                    hashCode = (hashCode * 59) + this.Command.GetHashCode();
                }

                if (this.Env != null)
                {
                    hashCode = (hashCode * 59) + this.Env.GetHashCode();
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
