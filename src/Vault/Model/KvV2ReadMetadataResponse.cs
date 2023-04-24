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
    /// KvV2ReadMetadataResponse
    /// </summary>
    [DataContract(Name = "KvV2ReadMetadataResponse")]
    public partial class KvV2ReadMetadataResponse : IEquatable<KvV2ReadMetadataResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="KvV2ReadMetadataResponse" /> class.
        /// </summary>

        /// <param name="CasRequired">CasRequired.</param>

        /// <param name="CreatedTime">CreatedTime.</param>

        /// <param name="CurrentVersion">CurrentVersion.</param>

        /// <param name="CustomMetadata">User-provided key-value pairs that are used to describe arbitrary and version-agnostic information about a secret..</param>

        /// <param name="DeleteVersionAfter">The length of time before a version is deleted..</param>

        /// <param name="MaxVersions">The number of versions to keep.</param>

        /// <param name="OldestVersion">OldestVersion.</param>

        /// <param name="UpdatedTime">UpdatedTime.</param>

        /// <param name="Versions">Versions.</param>


        public KvV2ReadMetadataResponse(bool CasRequired = default(bool), DateTime CreatedTime = default(DateTime), long CurrentVersion = default(long), Object CustomMetadata = default(Object), int DeleteVersionAfter = default(int), long MaxVersions = default(long), long OldestVersion = default(long), DateTime UpdatedTime = default(DateTime), Object Versions = default(Object))
        {

            this.CasRequired = CasRequired;

            this.CreatedTime = CreatedTime;

            this.CurrentVersion = CurrentVersion;

            this.CustomMetadata = CustomMetadata;

            this.DeleteVersionAfter = DeleteVersionAfter;

            this.MaxVersions = MaxVersions;

            this.OldestVersion = OldestVersion;

            this.UpdatedTime = UpdatedTime;

            this.Versions = Versions;

        }

        /// <summary>
        /// Gets or Sets CasRequired
        /// </summary>
        [DataMember(Name = "cas_required", EmitDefaultValue = true)]

        public bool CasRequired { get; set; }


        /// <summary>
        /// Gets or Sets CreatedTime
        /// </summary>
        [DataMember(Name = "created_time", EmitDefaultValue = false)]

        public DateTime CreatedTime { get; set; }


        /// <summary>
        /// Gets or Sets CurrentVersion
        /// </summary>
        [DataMember(Name = "current_version", EmitDefaultValue = false)]

        public long CurrentVersion { get; set; }


        /// <summary>
        /// User-provided key-value pairs that are used to describe arbitrary and version-agnostic information about a secret.
        /// </summary>
        /// <value>User-provided key-value pairs that are used to describe arbitrary and version-agnostic information about a secret.</value>
        [DataMember(Name = "custom_metadata", EmitDefaultValue = false)]

        public Object CustomMetadata { get; set; }


        /// <summary>
        /// The length of time before a version is deleted.
        /// </summary>
        /// <value>The length of time before a version is deleted.</value>
        [DataMember(Name = "delete_version_after", EmitDefaultValue = false)]

        public int DeleteVersionAfter { get; set; }


        /// <summary>
        /// The number of versions to keep
        /// </summary>
        /// <value>The number of versions to keep</value>
        [DataMember(Name = "max_versions", EmitDefaultValue = false)]

        public long MaxVersions { get; set; }


        /// <summary>
        /// Gets or Sets OldestVersion
        /// </summary>
        [DataMember(Name = "oldest_version", EmitDefaultValue = false)]

        public long OldestVersion { get; set; }


        /// <summary>
        /// Gets or Sets UpdatedTime
        /// </summary>
        [DataMember(Name = "updated_time", EmitDefaultValue = false)]

        public DateTime UpdatedTime { get; set; }


        /// <summary>
        /// Gets or Sets Versions
        /// </summary>
        [DataMember(Name = "versions", EmitDefaultValue = false)]

        public Object Versions { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KvV2ReadMetadataResponse {\n");
            sb.Append("  CasRequired: ").Append(CasRequired).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  CurrentVersion: ").Append(CurrentVersion).Append("\n");
            sb.Append("  CustomMetadata: ").Append(CustomMetadata).Append("\n");
            sb.Append("  DeleteVersionAfter: ").Append(DeleteVersionAfter).Append("\n");
            sb.Append("  MaxVersions: ").Append(MaxVersions).Append("\n");
            sb.Append("  OldestVersion: ").Append(OldestVersion).Append("\n");
            sb.Append("  UpdatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  Versions: ").Append(Versions).Append("\n");
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
            return this.Equals(input as KvV2ReadMetadataResponse);
        }

        /// <summary>
        /// Returns true if KvV2ReadMetadataResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of KvV2ReadMetadataResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KvV2ReadMetadataResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.CasRequired == input.CasRequired ||

                    this.CasRequired.Equals(input.CasRequired)
                ) &&
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))

                ) &&
                (
                    this.CurrentVersion == input.CurrentVersion ||

                    this.CurrentVersion.Equals(input.CurrentVersion)
                ) &&
                (
                    this.CustomMetadata == input.CustomMetadata ||
                    (this.CustomMetadata != null &&
                    this.CustomMetadata.Equals(input.CustomMetadata))

                ) &&
                (
                    this.DeleteVersionAfter == input.DeleteVersionAfter ||

                    this.DeleteVersionAfter.Equals(input.DeleteVersionAfter)
                ) &&
                (
                    this.MaxVersions == input.MaxVersions ||

                    this.MaxVersions.Equals(input.MaxVersions)
                ) &&
                (
                    this.OldestVersion == input.OldestVersion ||

                    this.OldestVersion.Equals(input.OldestVersion)
                ) &&
                (
                    this.UpdatedTime == input.UpdatedTime ||
                    (this.UpdatedTime != null &&
                    this.UpdatedTime.Equals(input.UpdatedTime))

                ) &&
                (
                    this.Versions == input.Versions ||
                    (this.Versions != null &&
                    this.Versions.Equals(input.Versions))

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


                hashCode = (hashCode * 59) + this.CasRequired.GetHashCode();
                if (this.CreatedTime != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedTime.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.CurrentVersion.GetHashCode();
                if (this.CustomMetadata != null)
                {
                    hashCode = (hashCode * 59) + this.CustomMetadata.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.DeleteVersionAfter.GetHashCode();

                hashCode = (hashCode * 59) + this.MaxVersions.GetHashCode();

                hashCode = (hashCode * 59) + this.OldestVersion.GetHashCode();
                if (this.UpdatedTime != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedTime.GetHashCode();
                }

                if (this.Versions != null)
                {
                    hashCode = (hashCode * 59) + this.Versions.GetHashCode();
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
