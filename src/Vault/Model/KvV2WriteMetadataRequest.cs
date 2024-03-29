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
    /// KvV2WriteMetadataRequest
    /// </summary>
    [DataContract(Name = "KvV2WriteMetadataRequest")]
    public partial class KvV2WriteMetadataRequest : IEquatable<KvV2WriteMetadataRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="KvV2WriteMetadataRequest" /> class.
        /// </summary>

        /// <param name="CasRequired">If true the key will require the cas parameter to be set on all write requests. If false, the backend’s configuration will be used..</param>

        /// <param name="CustomMetadata">User-provided key-value pairs that are used to describe arbitrary and version-agnostic information about a secret..</param>

        /// <param name="DeleteVersionAfter">The length of time before a version is deleted. If not set, the backend&#x27;s configured delete_version_after is used. Cannot be greater than the backend&#x27;s delete_version_after. A zero duration clears the current setting. A negative duration will cause an error..</param>

        /// <param name="MaxVersions">The number of versions to keep. If not set, the backend’s configured max version is used..</param>


        public KvV2WriteMetadataRequest(bool CasRequired = default(bool), Object CustomMetadata = default(Object), string DeleteVersionAfter = default(string), int MaxVersions = default(int))
        {

            this.CasRequired = CasRequired;

            this.CustomMetadata = CustomMetadata;

            this.DeleteVersionAfter = DeleteVersionAfter;

            this.MaxVersions = MaxVersions;

        }

        /// <summary>
        /// If true the key will require the cas parameter to be set on all write requests. If false, the backend’s configuration will be used.
        /// </summary>
        /// <value>If true the key will require the cas parameter to be set on all write requests. If false, the backend’s configuration will be used.</value>
        [DataMember(Name = "cas_required", EmitDefaultValue = true)]

        public bool CasRequired { get; set; }


        /// <summary>
        /// User-provided key-value pairs that are used to describe arbitrary and version-agnostic information about a secret.
        /// </summary>
        /// <value>User-provided key-value pairs that are used to describe arbitrary and version-agnostic information about a secret.</value>
        [DataMember(Name = "custom_metadata", EmitDefaultValue = false)]

        public Object CustomMetadata { get; set; }


        /// <summary>
        /// The length of time before a version is deleted. If not set, the backend&#x27;s configured delete_version_after is used. Cannot be greater than the backend&#x27;s delete_version_after. A zero duration clears the current setting. A negative duration will cause an error.
        /// </summary>
        /// <value>The length of time before a version is deleted. If not set, the backend&#x27;s configured delete_version_after is used. Cannot be greater than the backend&#x27;s delete_version_after. A zero duration clears the current setting. A negative duration will cause an error.</value>
        [DataMember(Name = "delete_version_after", EmitDefaultValue = false)]

        public string DeleteVersionAfter { get; set; }


        /// <summary>
        /// The number of versions to keep. If not set, the backend’s configured max version is used.
        /// </summary>
        /// <value>The number of versions to keep. If not set, the backend’s configured max version is used.</value>
        [DataMember(Name = "max_versions", EmitDefaultValue = false)]

        public int MaxVersions { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KvV2WriteMetadataRequest {\n");
            sb.Append("  CasRequired: ").Append(CasRequired).Append("\n");
            sb.Append("  CustomMetadata: ").Append(CustomMetadata).Append("\n");
            sb.Append("  DeleteVersionAfter: ").Append(DeleteVersionAfter).Append("\n");
            sb.Append("  MaxVersions: ").Append(MaxVersions).Append("\n");
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
            return this.Equals(input as KvV2WriteMetadataRequest);
        }

        /// <summary>
        /// Returns true if KvV2WriteMetadataRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of KvV2WriteMetadataRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KvV2WriteMetadataRequest input)
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
                    this.CustomMetadata == input.CustomMetadata ||
                    (this.CustomMetadata != null &&
                    this.CustomMetadata.Equals(input.CustomMetadata))

                ) &&
                (
                    this.DeleteVersionAfter == input.DeleteVersionAfter ||
                    (this.DeleteVersionAfter != null &&
                    this.DeleteVersionAfter.Equals(input.DeleteVersionAfter))

                ) &&
                (
                    this.MaxVersions == input.MaxVersions ||

                    this.MaxVersions.Equals(input.MaxVersions)
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
                if (this.CustomMetadata != null)
                {
                    hashCode = (hashCode * 59) + this.CustomMetadata.GetHashCode();
                }

                if (this.DeleteVersionAfter != null)
                {
                    hashCode = (hashCode * 59) + this.DeleteVersionAfter.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.MaxVersions.GetHashCode();
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
