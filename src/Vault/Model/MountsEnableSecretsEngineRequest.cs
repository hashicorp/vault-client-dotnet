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
    /// MountsEnableSecretsEngineRequest
    /// </summary>
    [DataContract(Name = "MountsEnableSecretsEngineRequest")]
    public partial class MountsEnableSecretsEngineRequest : IEquatable<MountsEnableSecretsEngineRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="MountsEnableSecretsEngineRequest" /> class.
        /// </summary>

        /// <param name="Config">Configuration for this mount, such as default_lease_ttl and max_lease_ttl..</param>

        /// <param name="Description">User-friendly description for this mount..</param>

        /// <param name="ExternalEntropyAccess">Whether to give the mount access to Vault&#x27;s external entropy. (default to false).</param>

        /// <param name="Local">Mark the mount as a local mount, which is not replicated and is unaffected by replication. (default to false).</param>

        /// <param name="Options">The options to pass into the backend. Should be a json object with string keys and values..</param>

        /// <param name="PluginName">Name of the plugin to mount based from the name registered in the plugin catalog..</param>

        /// <param name="PluginVersion">The semantic version of the plugin to use, or image tag if oci_image is provided..</param>

        /// <param name="SealWrap">Whether to turn on seal wrapping for the mount. (default to false).</param>

        /// <param name="Type">The type of the backend. Example: \&quot;passthrough\&quot;.</param>


        public MountsEnableSecretsEngineRequest(Object Config = default(Object), string Description = default(string), bool ExternalEntropyAccess = false, bool Local = false, Object Options = default(Object), string PluginName = default(string), string PluginVersion = default(string), bool SealWrap = false, string Type = default(string))
        {

            this.Config = Config;

            this.Description = Description;

            this.ExternalEntropyAccess = ExternalEntropyAccess;

            this.Local = Local;

            this.Options = Options;

            this.PluginName = PluginName;

            this.PluginVersion = PluginVersion;

            this.SealWrap = SealWrap;

            this.Type = Type;

        }

        /// <summary>
        /// Configuration for this mount, such as default_lease_ttl and max_lease_ttl.
        /// </summary>
        /// <value>Configuration for this mount, such as default_lease_ttl and max_lease_ttl.</value>
        [DataMember(Name = "config", EmitDefaultValue = false)]

        public Object Config { get; set; }


        /// <summary>
        /// User-friendly description for this mount.
        /// </summary>
        /// <value>User-friendly description for this mount.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]

        public string Description { get; set; }


        /// <summary>
        /// Whether to give the mount access to Vault&#x27;s external entropy.
        /// </summary>
        /// <value>Whether to give the mount access to Vault&#x27;s external entropy.</value>
        [DataMember(Name = "external_entropy_access", EmitDefaultValue = true)]

        public bool ExternalEntropyAccess { get; set; }


        /// <summary>
        /// Mark the mount as a local mount, which is not replicated and is unaffected by replication.
        /// </summary>
        /// <value>Mark the mount as a local mount, which is not replicated and is unaffected by replication.</value>
        [DataMember(Name = "local", EmitDefaultValue = true)]

        public bool Local { get; set; }


        /// <summary>
        /// The options to pass into the backend. Should be a json object with string keys and values.
        /// </summary>
        /// <value>The options to pass into the backend. Should be a json object with string keys and values.</value>
        [DataMember(Name = "options", EmitDefaultValue = false)]

        public Object Options { get; set; }


        /// <summary>
        /// Name of the plugin to mount based from the name registered in the plugin catalog.
        /// </summary>
        /// <value>Name of the plugin to mount based from the name registered in the plugin catalog.</value>
        [DataMember(Name = "plugin_name", EmitDefaultValue = false)]

        public string PluginName { get; set; }


        /// <summary>
        /// The semantic version of the plugin to use, or image tag if oci_image is provided.
        /// </summary>
        /// <value>The semantic version of the plugin to use, or image tag if oci_image is provided.</value>
        [DataMember(Name = "plugin_version", EmitDefaultValue = false)]

        public string PluginVersion { get; set; }


        /// <summary>
        /// Whether to turn on seal wrapping for the mount.
        /// </summary>
        /// <value>Whether to turn on seal wrapping for the mount.</value>
        [DataMember(Name = "seal_wrap", EmitDefaultValue = true)]

        public bool SealWrap { get; set; }


        /// <summary>
        /// The type of the backend. Example: \&quot;passthrough\&quot;
        /// </summary>
        /// <value>The type of the backend. Example: \&quot;passthrough\&quot;</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]

        public string Type { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MountsEnableSecretsEngineRequest {\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExternalEntropyAccess: ").Append(ExternalEntropyAccess).Append("\n");
            sb.Append("  Local: ").Append(Local).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  PluginName: ").Append(PluginName).Append("\n");
            sb.Append("  PluginVersion: ").Append(PluginVersion).Append("\n");
            sb.Append("  SealWrap: ").Append(SealWrap).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as MountsEnableSecretsEngineRequest);
        }

        /// <summary>
        /// Returns true if MountsEnableSecretsEngineRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MountsEnableSecretsEngineRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MountsEnableSecretsEngineRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))

                ) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))

                ) &&
                (
                    this.ExternalEntropyAccess == input.ExternalEntropyAccess ||

                    this.ExternalEntropyAccess.Equals(input.ExternalEntropyAccess)
                ) &&
                (
                    this.Local == input.Local ||

                    this.Local.Equals(input.Local)
                ) &&
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))

                ) &&
                (
                    this.PluginName == input.PluginName ||
                    (this.PluginName != null &&
                    this.PluginName.Equals(input.PluginName))

                ) &&
                (
                    this.PluginVersion == input.PluginVersion ||
                    (this.PluginVersion != null &&
                    this.PluginVersion.Equals(input.PluginVersion))

                ) &&
                (
                    this.SealWrap == input.SealWrap ||

                    this.SealWrap.Equals(input.SealWrap)
                ) &&
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))

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

                if (this.Config != null)
                {
                    hashCode = (hashCode * 59) + this.Config.GetHashCode();
                }

                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.ExternalEntropyAccess.GetHashCode();

                hashCode = (hashCode * 59) + this.Local.GetHashCode();
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
                }

                if (this.PluginName != null)
                {
                    hashCode = (hashCode * 59) + this.PluginName.GetHashCode();
                }

                if (this.PluginVersion != null)
                {
                    hashCode = (hashCode * 59) + this.PluginVersion.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.SealWrap.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
