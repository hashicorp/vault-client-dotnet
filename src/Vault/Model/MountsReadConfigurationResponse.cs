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
    /// MountsReadConfigurationResponse
    /// </summary>
    [DataContract(Name = "MountsReadConfigurationResponse")]
    public partial class MountsReadConfigurationResponse : IEquatable<MountsReadConfigurationResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="MountsReadConfigurationResponse" /> class.
        /// </summary>

        /// <param name="Accessor">Accessor.</param>

        /// <param name="Config">Configuration for this mount, such as default_lease_ttl and max_lease_ttl..</param>

        /// <param name="DeprecationStatus">DeprecationStatus.</param>

        /// <param name="Description">User-friendly description for this mount..</param>

        /// <param name="ExternalEntropyAccess">ExternalEntropyAccess.</param>

        /// <param name="Local">Mark the mount as a local mount, which is not replicated and is unaffected by replication. (default to false).</param>

        /// <param name="Options">The options to pass into the backend. Should be a json object with string keys and values..</param>

        /// <param name="PluginVersion">The semantic version of the plugin to use, or image tag if oci_image is provided..</param>

        /// <param name="RunningPluginVersion">RunningPluginVersion.</param>

        /// <param name="RunningSha256">RunningSha256.</param>

        /// <param name="SealWrap">Whether to turn on seal wrapping for the mount. (default to false).</param>

        /// <param name="Type">The type of the backend. Example: \&quot;passthrough\&quot;.</param>

        /// <param name="Uuid">Uuid.</param>


        public MountsReadConfigurationResponse(string Accessor = default(string), Object Config = default(Object), string DeprecationStatus = default(string), string Description = default(string), bool ExternalEntropyAccess = default(bool), bool Local = false, Object Options = default(Object), string PluginVersion = default(string), string RunningPluginVersion = default(string), string RunningSha256 = default(string), bool SealWrap = false, string Type = default(string), string Uuid = default(string))
        {

            this.Accessor = Accessor;

            this.Config = Config;

            this.DeprecationStatus = DeprecationStatus;

            this.Description = Description;

            this.ExternalEntropyAccess = ExternalEntropyAccess;

            this.Local = Local;

            this.Options = Options;

            this.PluginVersion = PluginVersion;

            this.RunningPluginVersion = RunningPluginVersion;

            this.RunningSha256 = RunningSha256;

            this.SealWrap = SealWrap;

            this.Type = Type;

            this.Uuid = Uuid;

        }

        /// <summary>
        /// Gets or Sets Accessor
        /// </summary>
        [DataMember(Name = "accessor", EmitDefaultValue = false)]

        public string Accessor { get; set; }


        /// <summary>
        /// Configuration for this mount, such as default_lease_ttl and max_lease_ttl.
        /// </summary>
        /// <value>Configuration for this mount, such as default_lease_ttl and max_lease_ttl.</value>
        [DataMember(Name = "config", EmitDefaultValue = false)]

        public Object Config { get; set; }


        /// <summary>
        /// Gets or Sets DeprecationStatus
        /// </summary>
        [DataMember(Name = "deprecation_status", EmitDefaultValue = false)]

        public string DeprecationStatus { get; set; }


        /// <summary>
        /// User-friendly description for this mount.
        /// </summary>
        /// <value>User-friendly description for this mount.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]

        public string Description { get; set; }


        /// <summary>
        /// Gets or Sets ExternalEntropyAccess
        /// </summary>
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
        /// The semantic version of the plugin to use, or image tag if oci_image is provided.
        /// </summary>
        /// <value>The semantic version of the plugin to use, or image tag if oci_image is provided.</value>
        [DataMember(Name = "plugin_version", EmitDefaultValue = false)]

        public string PluginVersion { get; set; }


        /// <summary>
        /// Gets or Sets RunningPluginVersion
        /// </summary>
        [DataMember(Name = "running_plugin_version", EmitDefaultValue = false)]

        public string RunningPluginVersion { get; set; }


        /// <summary>
        /// Gets or Sets RunningSha256
        /// </summary>
        [DataMember(Name = "running_sha256", EmitDefaultValue = false)]

        public string RunningSha256 { get; set; }


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
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", EmitDefaultValue = false)]

        public string Uuid { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MountsReadConfigurationResponse {\n");
            sb.Append("  Accessor: ").Append(Accessor).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  DeprecationStatus: ").Append(DeprecationStatus).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExternalEntropyAccess: ").Append(ExternalEntropyAccess).Append("\n");
            sb.Append("  Local: ").Append(Local).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  PluginVersion: ").Append(PluginVersion).Append("\n");
            sb.Append("  RunningPluginVersion: ").Append(RunningPluginVersion).Append("\n");
            sb.Append("  RunningSha256: ").Append(RunningSha256).Append("\n");
            sb.Append("  SealWrap: ").Append(SealWrap).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
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
            return this.Equals(input as MountsReadConfigurationResponse);
        }

        /// <summary>
        /// Returns true if MountsReadConfigurationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MountsReadConfigurationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MountsReadConfigurationResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Accessor == input.Accessor ||
                    (this.Accessor != null &&
                    this.Accessor.Equals(input.Accessor))

                ) &&
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))

                ) &&
                (
                    this.DeprecationStatus == input.DeprecationStatus ||
                    (this.DeprecationStatus != null &&
                    this.DeprecationStatus.Equals(input.DeprecationStatus))

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
                    this.PluginVersion == input.PluginVersion ||
                    (this.PluginVersion != null &&
                    this.PluginVersion.Equals(input.PluginVersion))

                ) &&
                (
                    this.RunningPluginVersion == input.RunningPluginVersion ||
                    (this.RunningPluginVersion != null &&
                    this.RunningPluginVersion.Equals(input.RunningPluginVersion))

                ) &&
                (
                    this.RunningSha256 == input.RunningSha256 ||
                    (this.RunningSha256 != null &&
                    this.RunningSha256.Equals(input.RunningSha256))

                ) &&
                (
                    this.SealWrap == input.SealWrap ||

                    this.SealWrap.Equals(input.SealWrap)
                ) &&
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))

                ) &&
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))

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

                if (this.Accessor != null)
                {
                    hashCode = (hashCode * 59) + this.Accessor.GetHashCode();
                }

                if (this.Config != null)
                {
                    hashCode = (hashCode * 59) + this.Config.GetHashCode();
                }

                if (this.DeprecationStatus != null)
                {
                    hashCode = (hashCode * 59) + this.DeprecationStatus.GetHashCode();
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

                if (this.PluginVersion != null)
                {
                    hashCode = (hashCode * 59) + this.PluginVersion.GetHashCode();
                }

                if (this.RunningPluginVersion != null)
                {
                    hashCode = (hashCode * 59) + this.RunningPluginVersion.GetHashCode();
                }

                if (this.RunningSha256 != null)
                {
                    hashCode = (hashCode * 59) + this.RunningSha256.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.SealWrap.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }

                if (this.Uuid != null)
                {
                    hashCode = (hashCode * 59) + this.Uuid.GetHashCode();
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
