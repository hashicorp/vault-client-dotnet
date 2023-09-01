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
    /// PluginsRuntimesCatalogReadPluginRuntimeConfigurationResponse
    /// </summary>
    [DataContract(Name = "PluginsRuntimesCatalogReadPluginRuntimeConfigurationResponse")]
    public partial class PluginsRuntimesCatalogReadPluginRuntimeConfigurationResponse : IEquatable<PluginsRuntimesCatalogReadPluginRuntimeConfigurationResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PluginsRuntimesCatalogReadPluginRuntimeConfigurationResponse" /> class.
        /// </summary>

        /// <param name="CgroupParent">Optional parent cgroup for the container.</param>

        /// <param name="CpuNanos">The limit of runtime CPU in nanos.</param>

        /// <param name="MemoryBytes">The limit of runtime memory in bytes.</param>

        /// <param name="Name">The name of the plugin runtime.</param>

        /// <param name="OciRuntime">The OCI-compatible runtime (default \&quot;runsc\&quot;).</param>

        /// <param name="Type">The type of the plugin runtime.</param>


        public PluginsRuntimesCatalogReadPluginRuntimeConfigurationResponse(string CgroupParent = default(string), long CpuNanos = default(long), long MemoryBytes = default(long), string Name = default(string), string OciRuntime = default(string), string Type = default(string))
        {

            this.CgroupParent = CgroupParent;

            this.CpuNanos = CpuNanos;

            this.MemoryBytes = MemoryBytes;

            this.Name = Name;

            this.OciRuntime = OciRuntime;

            this.Type = Type;

        }

        /// <summary>
        /// Optional parent cgroup for the container
        /// </summary>
        /// <value>Optional parent cgroup for the container</value>
        [DataMember(Name = "cgroup_parent", EmitDefaultValue = false)]

        public string CgroupParent { get; set; }


        /// <summary>
        /// The limit of runtime CPU in nanos
        /// </summary>
        /// <value>The limit of runtime CPU in nanos</value>
        [DataMember(Name = "cpu_nanos", EmitDefaultValue = false)]

        public long CpuNanos { get; set; }


        /// <summary>
        /// The limit of runtime memory in bytes
        /// </summary>
        /// <value>The limit of runtime memory in bytes</value>
        [DataMember(Name = "memory_bytes", EmitDefaultValue = false)]

        public long MemoryBytes { get; set; }


        /// <summary>
        /// The name of the plugin runtime
        /// </summary>
        /// <value>The name of the plugin runtime</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]

        public string Name { get; set; }


        /// <summary>
        /// The OCI-compatible runtime (default \&quot;runsc\&quot;)
        /// </summary>
        /// <value>The OCI-compatible runtime (default \&quot;runsc\&quot;)</value>
        [DataMember(Name = "oci_runtime", EmitDefaultValue = false)]

        public string OciRuntime { get; set; }


        /// <summary>
        /// The type of the plugin runtime
        /// </summary>
        /// <value>The type of the plugin runtime</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]

        public string Type { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PluginsRuntimesCatalogReadPluginRuntimeConfigurationResponse {\n");
            sb.Append("  CgroupParent: ").Append(CgroupParent).Append("\n");
            sb.Append("  CpuNanos: ").Append(CpuNanos).Append("\n");
            sb.Append("  MemoryBytes: ").Append(MemoryBytes).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OciRuntime: ").Append(OciRuntime).Append("\n");
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
            return this.Equals(input as PluginsRuntimesCatalogReadPluginRuntimeConfigurationResponse);
        }

        /// <summary>
        /// Returns true if PluginsRuntimesCatalogReadPluginRuntimeConfigurationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PluginsRuntimesCatalogReadPluginRuntimeConfigurationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PluginsRuntimesCatalogReadPluginRuntimeConfigurationResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.CgroupParent == input.CgroupParent ||
                    (this.CgroupParent != null &&
                    this.CgroupParent.Equals(input.CgroupParent))

                ) &&
                (
                    this.CpuNanos == input.CpuNanos ||

                    this.CpuNanos.Equals(input.CpuNanos)
                ) &&
                (
                    this.MemoryBytes == input.MemoryBytes ||

                    this.MemoryBytes.Equals(input.MemoryBytes)
                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))

                ) &&
                (
                    this.OciRuntime == input.OciRuntime ||
                    (this.OciRuntime != null &&
                    this.OciRuntime.Equals(input.OciRuntime))

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

                if (this.CgroupParent != null)
                {
                    hashCode = (hashCode * 59) + this.CgroupParent.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.CpuNanos.GetHashCode();

                hashCode = (hashCode * 59) + this.MemoryBytes.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }

                if (this.OciRuntime != null)
                {
                    hashCode = (hashCode * 59) + this.OciRuntime.GetHashCode();
                }

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
