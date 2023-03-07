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
    /// KVv2WriteConfigRequest
    /// </summary>
    [DataContract(Name = "KVv2WriteConfigRequest")]
    public partial class KVv2WriteConfigRequest : IEquatable<KVv2WriteConfigRequest>, IValidatableObject
    {









        /// <summary>
        /// Initializes a new instance of the <see cref="KVv2WriteConfigRequest" /> class.
        /// </summary>

        /// <param name="CasRequired">If true, the backend will require the cas parameter to be set for each write.</param>

        /// <param name="DeleteVersionAfter">If set, the length of time before a version is deleted. A negative duration disables the use of delete_version_after on all keys. A zero duration clears the current setting. Accepts a Go duration format string..</param>

        /// <param name="MaxVersions">The number of versions to keep for each key. Defaults to 10.</param>


        public KVv2WriteConfigRequest(bool CasRequired = default(bool), int DeleteVersionAfter = default(int), int MaxVersions = default(int))
        {

            this.CasRequired = CasRequired;

            this.DeleteVersionAfter = DeleteVersionAfter;

            this.MaxVersions = MaxVersions;

        }

        /// <summary>
        /// If true, the backend will require the cas parameter to be set for each write
        /// </summary>
        /// <value>If true, the backend will require the cas parameter to be set for each write</value>
        [DataMember(Name = "cas_required", EmitDefaultValue = true)]

        public bool CasRequired { get; set; }


        /// <summary>
        /// If set, the length of time before a version is deleted. A negative duration disables the use of delete_version_after on all keys. A zero duration clears the current setting. Accepts a Go duration format string.
        /// </summary>
        /// <value>If set, the length of time before a version is deleted. A negative duration disables the use of delete_version_after on all keys. A zero duration clears the current setting. Accepts a Go duration format string.</value>
        [DataMember(Name = "delete_version_after", EmitDefaultValue = false)]

        public int DeleteVersionAfter { get; set; }


        /// <summary>
        /// The number of versions to keep for each key. Defaults to 10
        /// </summary>
        /// <value>The number of versions to keep for each key. Defaults to 10</value>
        [DataMember(Name = "max_versions", EmitDefaultValue = false)]

        public int MaxVersions { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KVv2WriteConfigRequest {\n");
            sb.Append("  CasRequired: ").Append(CasRequired).Append("\n");
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
            return this.Equals(input as KVv2WriteConfigRequest);
        }

        /// <summary>
        /// Returns true if KVv2WriteConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of KVv2WriteConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KVv2WriteConfigRequest input)
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
                    this.DeleteVersionAfter == input.DeleteVersionAfter ||

                    this.DeleteVersionAfter.Equals(input.DeleteVersionAfter)
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

                hashCode = (hashCode * 59) + this.DeleteVersionAfter.GetHashCode();

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
