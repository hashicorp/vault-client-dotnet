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
    /// CollectHostInformationResponse
    /// </summary>
    [DataContract(Name = "CollectHostInformationResponse")]
    public partial class CollectHostInformationResponse : IEquatable<CollectHostInformationResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="CollectHostInformationResponse" /> class.
        /// </summary>

        /// <param name="Cpu">Cpu.</param>

        /// <param name="CpuTimes">CpuTimes.</param>

        /// <param name="Disk">Disk.</param>

        /// <param name="Host">Host.</param>

        /// <param name="Memory">Memory.</param>

        /// <param name="Timestamp">Timestamp.</param>


        public CollectHostInformationResponse(List<Object> Cpu = default(List<Object>), List<Object> CpuTimes = default(List<Object>), List<Object> Disk = default(List<Object>), Object Host = default(Object), Object Memory = default(Object), DateTime Timestamp = default(DateTime))
        {

            this.Cpu = Cpu;

            this.CpuTimes = CpuTimes;

            this.Disk = Disk;

            this.Host = Host;

            this.Memory = Memory;

            this.Timestamp = Timestamp;

        }

        /// <summary>
        /// Gets or Sets Cpu
        /// </summary>
        [DataMember(Name = "cpu", EmitDefaultValue = false)]

        public List<Object> Cpu { get; set; }


        /// <summary>
        /// Gets or Sets CpuTimes
        /// </summary>
        [DataMember(Name = "cpu_times", EmitDefaultValue = false)]

        public List<Object> CpuTimes { get; set; }


        /// <summary>
        /// Gets or Sets Disk
        /// </summary>
        [DataMember(Name = "disk", EmitDefaultValue = false)]

        public List<Object> Disk { get; set; }


        /// <summary>
        /// Gets or Sets Host
        /// </summary>
        [DataMember(Name = "host", EmitDefaultValue = false)]

        public Object Host { get; set; }


        /// <summary>
        /// Gets or Sets Memory
        /// </summary>
        [DataMember(Name = "memory", EmitDefaultValue = false)]

        public Object Memory { get; set; }


        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]

        public DateTime Timestamp { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CollectHostInformationResponse {\n");
            sb.Append("  Cpu: ").Append(Cpu).Append("\n");
            sb.Append("  CpuTimes: ").Append(CpuTimes).Append("\n");
            sb.Append("  Disk: ").Append(Disk).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Memory: ").Append(Memory).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as CollectHostInformationResponse);
        }

        /// <summary>
        /// Returns true if CollectHostInformationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CollectHostInformationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollectHostInformationResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Cpu == input.Cpu ||
                    this.Cpu != null &&
                    input.Cpu != null &&
                    this.Cpu.SequenceEqual(input.Cpu)
                ) &&
                (
                    this.CpuTimes == input.CpuTimes ||
                    this.CpuTimes != null &&
                    input.CpuTimes != null &&
                    this.CpuTimes.SequenceEqual(input.CpuTimes)
                ) &&
                (
                    this.Disk == input.Disk ||
                    this.Disk != null &&
                    input.Disk != null &&
                    this.Disk.SequenceEqual(input.Disk)
                ) &&
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))

                ) &&
                (
                    this.Memory == input.Memory ||
                    (this.Memory != null &&
                    this.Memory.Equals(input.Memory))

                ) &&
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))

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

                if (this.Cpu != null)
                {
                    hashCode = (hashCode * 59) + this.Cpu.GetHashCode();
                }

                if (this.CpuTimes != null)
                {
                    hashCode = (hashCode * 59) + this.CpuTimes.GetHashCode();
                }

                if (this.Disk != null)
                {
                    hashCode = (hashCode * 59) + this.Disk.GetHashCode();
                }

                if (this.Host != null)
                {
                    hashCode = (hashCode * 59) + this.Host.GetHashCode();
                }

                if (this.Memory != null)
                {
                    hashCode = (hashCode * 59) + this.Memory.GetHashCode();
                }

                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
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
