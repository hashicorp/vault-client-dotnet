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
    /// PluginsRuntimesCatalogRegisterPluginRuntimeRequest
    /// </summary>
    [DataContract(Name = "PluginsRuntimesCatalogRegisterPluginRuntimeRequest")]
    public partial class PluginsRuntimesCatalogRegisterPluginRuntimeRequest : IEquatable<PluginsRuntimesCatalogRegisterPluginRuntimeRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PluginsRuntimesCatalogRegisterPluginRuntimeRequest" /> class.
        /// </summary>

        /// <param name="CgroupParent">Optional parent cgroup for the container.</param>

        /// <param name="CpuNanos">The limit of runtime CPU in nanos.</param>

        /// <param name="MemoryBytes">The limit of runtime memory in bytes.</param>

        /// <param name="OciRuntime">The OCI-compatible runtime (default \&quot;runsc\&quot;).</param>


        public PluginsRuntimesCatalogRegisterPluginRuntimeRequest(string CgroupParent = default(string), long CpuNanos = default(long), long MemoryBytes = default(long), string OciRuntime = default(string))
        {

            this.CgroupParent = CgroupParent;

            this.CpuNanos = CpuNanos;

            this.MemoryBytes = MemoryBytes;

            this.OciRuntime = OciRuntime;

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
        /// The OCI-compatible runtime (default \&quot;runsc\&quot;)
        /// </summary>
        /// <value>The OCI-compatible runtime (default \&quot;runsc\&quot;)</value>
        [DataMember(Name = "oci_runtime", EmitDefaultValue = false)]

        public string OciRuntime { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PluginsRuntimesCatalogRegisterPluginRuntimeRequest {\n");
            sb.Append("  CgroupParent: ").Append(CgroupParent).Append("\n");
            sb.Append("  CpuNanos: ").Append(CpuNanos).Append("\n");
            sb.Append("  MemoryBytes: ").Append(MemoryBytes).Append("\n");
            sb.Append("  OciRuntime: ").Append(OciRuntime).Append("\n");
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
            return this.Equals(input as PluginsRuntimesCatalogRegisterPluginRuntimeRequest);
        }

        /// <summary>
        /// Returns true if PluginsRuntimesCatalogRegisterPluginRuntimeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PluginsRuntimesCatalogRegisterPluginRuntimeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PluginsRuntimesCatalogRegisterPluginRuntimeRequest input)
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
                    this.OciRuntime == input.OciRuntime ||
                    (this.OciRuntime != null &&
                    this.OciRuntime.Equals(input.OciRuntime))

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
                if (this.OciRuntime != null)
                {
                    hashCode = (hashCode * 59) + this.OciRuntime.GetHashCode();
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
