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
    /// LeaderStatusResponse
    /// </summary>
    [DataContract(Name = "LeaderStatusResponse")]
    public partial class LeaderStatusResponse : IEquatable<LeaderStatusResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="LeaderStatusResponse" /> class.
        /// </summary>

        /// <param name="ActiveTime">ActiveTime.</param>

        /// <param name="HaEnabled">HaEnabled.</param>

        /// <param name="IsSelf">IsSelf.</param>

        /// <param name="LastWal">LastWal.</param>

        /// <param name="LeaderAddress">LeaderAddress.</param>

        /// <param name="LeaderClusterAddress">LeaderClusterAddress.</param>

        /// <param name="PerformanceStandby">PerformanceStandby.</param>

        /// <param name="PerformanceStandbyLastRemoteWal">PerformanceStandbyLastRemoteWal.</param>

        /// <param name="RaftAppliedIndex">RaftAppliedIndex.</param>

        /// <param name="RaftCommittedIndex">RaftCommittedIndex.</param>


        public LeaderStatusResponse(DateTime ActiveTime = default(DateTime), bool HaEnabled = default(bool), bool IsSelf = default(bool), long LastWal = default(long), string LeaderAddress = default(string), string LeaderClusterAddress = default(string), bool PerformanceStandby = default(bool), long PerformanceStandbyLastRemoteWal = default(long), long RaftAppliedIndex = default(long), long RaftCommittedIndex = default(long))
        {

            this.ActiveTime = ActiveTime;

            this.HaEnabled = HaEnabled;

            this.IsSelf = IsSelf;

            this.LastWal = LastWal;

            this.LeaderAddress = LeaderAddress;

            this.LeaderClusterAddress = LeaderClusterAddress;

            this.PerformanceStandby = PerformanceStandby;

            this.PerformanceStandbyLastRemoteWal = PerformanceStandbyLastRemoteWal;

            this.RaftAppliedIndex = RaftAppliedIndex;

            this.RaftCommittedIndex = RaftCommittedIndex;

        }

        /// <summary>
        /// Gets or Sets ActiveTime
        /// </summary>
        [DataMember(Name = "active_time", EmitDefaultValue = false)]

        public DateTime ActiveTime { get; set; }


        /// <summary>
        /// Gets or Sets HaEnabled
        /// </summary>
        [DataMember(Name = "ha_enabled", EmitDefaultValue = true)]

        public bool HaEnabled { get; set; }


        /// <summary>
        /// Gets or Sets IsSelf
        /// </summary>
        [DataMember(Name = "is_self", EmitDefaultValue = true)]

        public bool IsSelf { get; set; }


        /// <summary>
        /// Gets or Sets LastWal
        /// </summary>
        [DataMember(Name = "last_wal", EmitDefaultValue = false)]

        public long LastWal { get; set; }


        /// <summary>
        /// Gets or Sets LeaderAddress
        /// </summary>
        [DataMember(Name = "leader_address", EmitDefaultValue = false)]

        public string LeaderAddress { get; set; }


        /// <summary>
        /// Gets or Sets LeaderClusterAddress
        /// </summary>
        [DataMember(Name = "leader_cluster_address", EmitDefaultValue = false)]

        public string LeaderClusterAddress { get; set; }


        /// <summary>
        /// Gets or Sets PerformanceStandby
        /// </summary>
        [DataMember(Name = "performance_standby", EmitDefaultValue = true)]

        public bool PerformanceStandby { get; set; }


        /// <summary>
        /// Gets or Sets PerformanceStandbyLastRemoteWal
        /// </summary>
        [DataMember(Name = "performance_standby_last_remote_wal", EmitDefaultValue = false)]

        public long PerformanceStandbyLastRemoteWal { get; set; }


        /// <summary>
        /// Gets or Sets RaftAppliedIndex
        /// </summary>
        [DataMember(Name = "raft_applied_index", EmitDefaultValue = false)]

        public long RaftAppliedIndex { get; set; }


        /// <summary>
        /// Gets or Sets RaftCommittedIndex
        /// </summary>
        [DataMember(Name = "raft_committed_index", EmitDefaultValue = false)]

        public long RaftCommittedIndex { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LeaderStatusResponse {\n");
            sb.Append("  ActiveTime: ").Append(ActiveTime).Append("\n");
            sb.Append("  HaEnabled: ").Append(HaEnabled).Append("\n");
            sb.Append("  IsSelf: ").Append(IsSelf).Append("\n");
            sb.Append("  LastWal: ").Append(LastWal).Append("\n");
            sb.Append("  LeaderAddress: ").Append(LeaderAddress).Append("\n");
            sb.Append("  LeaderClusterAddress: ").Append(LeaderClusterAddress).Append("\n");
            sb.Append("  PerformanceStandby: ").Append(PerformanceStandby).Append("\n");
            sb.Append("  PerformanceStandbyLastRemoteWal: ").Append(PerformanceStandbyLastRemoteWal).Append("\n");
            sb.Append("  RaftAppliedIndex: ").Append(RaftAppliedIndex).Append("\n");
            sb.Append("  RaftCommittedIndex: ").Append(RaftCommittedIndex).Append("\n");
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
            return this.Equals(input as LeaderStatusResponse);
        }

        /// <summary>
        /// Returns true if LeaderStatusResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of LeaderStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeaderStatusResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.ActiveTime == input.ActiveTime ||
                    (this.ActiveTime != null &&
                    this.ActiveTime.Equals(input.ActiveTime))

                ) &&
                (
                    this.HaEnabled == input.HaEnabled ||

                    this.HaEnabled.Equals(input.HaEnabled)
                ) &&
                (
                    this.IsSelf == input.IsSelf ||

                    this.IsSelf.Equals(input.IsSelf)
                ) &&
                (
                    this.LastWal == input.LastWal ||

                    this.LastWal.Equals(input.LastWal)
                ) &&
                (
                    this.LeaderAddress == input.LeaderAddress ||
                    (this.LeaderAddress != null &&
                    this.LeaderAddress.Equals(input.LeaderAddress))

                ) &&
                (
                    this.LeaderClusterAddress == input.LeaderClusterAddress ||
                    (this.LeaderClusterAddress != null &&
                    this.LeaderClusterAddress.Equals(input.LeaderClusterAddress))

                ) &&
                (
                    this.PerformanceStandby == input.PerformanceStandby ||

                    this.PerformanceStandby.Equals(input.PerformanceStandby)
                ) &&
                (
                    this.PerformanceStandbyLastRemoteWal == input.PerformanceStandbyLastRemoteWal ||

                    this.PerformanceStandbyLastRemoteWal.Equals(input.PerformanceStandbyLastRemoteWal)
                ) &&
                (
                    this.RaftAppliedIndex == input.RaftAppliedIndex ||

                    this.RaftAppliedIndex.Equals(input.RaftAppliedIndex)
                ) &&
                (
                    this.RaftCommittedIndex == input.RaftCommittedIndex ||

                    this.RaftCommittedIndex.Equals(input.RaftCommittedIndex)
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

                if (this.ActiveTime != null)
                {
                    hashCode = (hashCode * 59) + this.ActiveTime.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.HaEnabled.GetHashCode();

                hashCode = (hashCode * 59) + this.IsSelf.GetHashCode();

                hashCode = (hashCode * 59) + this.LastWal.GetHashCode();
                if (this.LeaderAddress != null)
                {
                    hashCode = (hashCode * 59) + this.LeaderAddress.GetHashCode();
                }

                if (this.LeaderClusterAddress != null)
                {
                    hashCode = (hashCode * 59) + this.LeaderClusterAddress.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.PerformanceStandby.GetHashCode();

                hashCode = (hashCode * 59) + this.PerformanceStandbyLastRemoteWal.GetHashCode();

                hashCode = (hashCode * 59) + this.RaftAppliedIndex.GetHashCode();

                hashCode = (hashCode * 59) + this.RaftCommittedIndex.GetHashCode();
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
