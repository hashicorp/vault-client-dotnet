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
    /// UnsealResponse
    /// </summary>
    [DataContract(Name = "UnsealResponse")]
    public partial class UnsealResponse : IEquatable<UnsealResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="UnsealResponse" /> class.
        /// </summary>

        /// <param name="BuildDate">BuildDate.</param>

        /// <param name="ClusterId">ClusterId.</param>

        /// <param name="ClusterName">ClusterName.</param>

        /// <param name="HcpLinkResourceID">HcpLinkResourceID.</param>

        /// <param name="HcpLinkStatus">HcpLinkStatus.</param>

        /// <param name="Initialized">Initialized.</param>

        /// <param name="Migration">Migration.</param>

        /// <param name="N">N.</param>

        /// <param name="Nonce">Nonce.</param>

        /// <param name="Progress">Progress.</param>

        /// <param name="RecoverySeal">RecoverySeal.</param>

        /// <param name="Sealed">Sealed.</param>

        /// <param name="StorageType">StorageType.</param>

        /// <param name="T">T.</param>

        /// <param name="Type">Type.</param>

        /// <param name="_Version">_Version.</param>


        public UnsealResponse(string BuildDate = default(string), string ClusterId = default(string), string ClusterName = default(string), string HcpLinkResourceID = default(string), string HcpLinkStatus = default(string), bool Initialized = default(bool), bool Migration = default(bool), int N = default(int), string Nonce = default(string), int Progress = default(int), bool RecoverySeal = default(bool), bool Sealed = default(bool), string StorageType = default(string), int T = default(int), string Type = default(string), string _Version = default(string))
        {

            this.BuildDate = BuildDate;

            this.ClusterId = ClusterId;

            this.ClusterName = ClusterName;

            this.HcpLinkResourceID = HcpLinkResourceID;

            this.HcpLinkStatus = HcpLinkStatus;

            this.Initialized = Initialized;

            this.Migration = Migration;

            this.N = N;

            this.Nonce = Nonce;

            this.Progress = Progress;

            this.RecoverySeal = RecoverySeal;

            this.Sealed = Sealed;

            this.StorageType = StorageType;

            this.T = T;

            this.Type = Type;

            this._Version = _Version;

        }

        /// <summary>
        /// Gets or Sets BuildDate
        /// </summary>
        [DataMember(Name = "build_date", EmitDefaultValue = false)]

        public string BuildDate { get; set; }


        /// <summary>
        /// Gets or Sets ClusterId
        /// </summary>
        [DataMember(Name = "cluster_id", EmitDefaultValue = false)]

        public string ClusterId { get; set; }


        /// <summary>
        /// Gets or Sets ClusterName
        /// </summary>
        [DataMember(Name = "cluster_name", EmitDefaultValue = false)]

        public string ClusterName { get; set; }


        /// <summary>
        /// Gets or Sets HcpLinkResourceID
        /// </summary>
        [DataMember(Name = "hcp_link_resource_ID", EmitDefaultValue = false)]

        public string HcpLinkResourceID { get; set; }


        /// <summary>
        /// Gets or Sets HcpLinkStatus
        /// </summary>
        [DataMember(Name = "hcp_link_status", EmitDefaultValue = false)]

        public string HcpLinkStatus { get; set; }


        /// <summary>
        /// Gets or Sets Initialized
        /// </summary>
        [DataMember(Name = "initialized", EmitDefaultValue = true)]

        public bool Initialized { get; set; }


        /// <summary>
        /// Gets or Sets Migration
        /// </summary>
        [DataMember(Name = "migration", EmitDefaultValue = true)]

        public bool Migration { get; set; }


        /// <summary>
        /// Gets or Sets N
        /// </summary>
        [DataMember(Name = "n", EmitDefaultValue = false)]

        public int N { get; set; }


        /// <summary>
        /// Gets or Sets Nonce
        /// </summary>
        [DataMember(Name = "nonce", EmitDefaultValue = false)]

        public string Nonce { get; set; }


        /// <summary>
        /// Gets or Sets Progress
        /// </summary>
        [DataMember(Name = "progress", EmitDefaultValue = false)]

        public int Progress { get; set; }


        /// <summary>
        /// Gets or Sets RecoverySeal
        /// </summary>
        [DataMember(Name = "recovery_seal", EmitDefaultValue = true)]

        public bool RecoverySeal { get; set; }


        /// <summary>
        /// Gets or Sets Sealed
        /// </summary>
        [DataMember(Name = "sealed", EmitDefaultValue = true)]

        public bool Sealed { get; set; }


        /// <summary>
        /// Gets or Sets StorageType
        /// </summary>
        [DataMember(Name = "storage_type", EmitDefaultValue = false)]

        public string StorageType { get; set; }


        /// <summary>
        /// Gets or Sets T
        /// </summary>
        [DataMember(Name = "t", EmitDefaultValue = false)]

        public int T { get; set; }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]

        public string Type { get; set; }


        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]

        public string _Version { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UnsealResponse {\n");
            sb.Append("  BuildDate: ").Append(BuildDate).Append("\n");
            sb.Append("  ClusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  ClusterName: ").Append(ClusterName).Append("\n");
            sb.Append("  HcpLinkResourceID: ").Append(HcpLinkResourceID).Append("\n");
            sb.Append("  HcpLinkStatus: ").Append(HcpLinkStatus).Append("\n");
            sb.Append("  Initialized: ").Append(Initialized).Append("\n");
            sb.Append("  Migration: ").Append(Migration).Append("\n");
            sb.Append("  N: ").Append(N).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  RecoverySeal: ").Append(RecoverySeal).Append("\n");
            sb.Append("  Sealed: ").Append(Sealed).Append("\n");
            sb.Append("  StorageType: ").Append(StorageType).Append("\n");
            sb.Append("  T: ").Append(T).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as UnsealResponse);
        }

        /// <summary>
        /// Returns true if UnsealResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UnsealResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnsealResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.BuildDate == input.BuildDate ||
                    (this.BuildDate != null &&
                    this.BuildDate.Equals(input.BuildDate))

                ) &&
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))

                ) &&
                (
                    this.ClusterName == input.ClusterName ||
                    (this.ClusterName != null &&
                    this.ClusterName.Equals(input.ClusterName))

                ) &&
                (
                    this.HcpLinkResourceID == input.HcpLinkResourceID ||
                    (this.HcpLinkResourceID != null &&
                    this.HcpLinkResourceID.Equals(input.HcpLinkResourceID))

                ) &&
                (
                    this.HcpLinkStatus == input.HcpLinkStatus ||
                    (this.HcpLinkStatus != null &&
                    this.HcpLinkStatus.Equals(input.HcpLinkStatus))

                ) &&
                (
                    this.Initialized == input.Initialized ||

                    this.Initialized.Equals(input.Initialized)
                ) &&
                (
                    this.Migration == input.Migration ||

                    this.Migration.Equals(input.Migration)
                ) &&
                (
                    this.N == input.N ||

                    this.N.Equals(input.N)
                ) &&
                (
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))

                ) &&
                (
                    this.Progress == input.Progress ||

                    this.Progress.Equals(input.Progress)
                ) &&
                (
                    this.RecoverySeal == input.RecoverySeal ||

                    this.RecoverySeal.Equals(input.RecoverySeal)
                ) &&
                (
                    this.Sealed == input.Sealed ||

                    this.Sealed.Equals(input.Sealed)
                ) &&
                (
                    this.StorageType == input.StorageType ||
                    (this.StorageType != null &&
                    this.StorageType.Equals(input.StorageType))

                ) &&
                (
                    this.T == input.T ||

                    this.T.Equals(input.T)
                ) &&
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))

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

                if (this.BuildDate != null)
                {
                    hashCode = (hashCode * 59) + this.BuildDate.GetHashCode();
                }

                if (this.ClusterId != null)
                {
                    hashCode = (hashCode * 59) + this.ClusterId.GetHashCode();
                }

                if (this.ClusterName != null)
                {
                    hashCode = (hashCode * 59) + this.ClusterName.GetHashCode();
                }

                if (this.HcpLinkResourceID != null)
                {
                    hashCode = (hashCode * 59) + this.HcpLinkResourceID.GetHashCode();
                }

                if (this.HcpLinkStatus != null)
                {
                    hashCode = (hashCode * 59) + this.HcpLinkStatus.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Initialized.GetHashCode();

                hashCode = (hashCode * 59) + this.Migration.GetHashCode();

                hashCode = (hashCode * 59) + this.N.GetHashCode();
                if (this.Nonce != null)
                {
                    hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Progress.GetHashCode();

                hashCode = (hashCode * 59) + this.RecoverySeal.GetHashCode();

                hashCode = (hashCode * 59) + this.Sealed.GetHashCode();
                if (this.StorageType != null)
                {
                    hashCode = (hashCode * 59) + this.StorageType.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.T.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
