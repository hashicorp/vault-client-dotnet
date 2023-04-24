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
    /// InternalUiReadResultantAclResponse
    /// </summary>
    [DataContract(Name = "InternalUiReadResultantAclResponse")]
    public partial class InternalUiReadResultantAclResponse : IEquatable<InternalUiReadResultantAclResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="InternalUiReadResultantAclResponse" /> class.
        /// </summary>

        /// <param name="ExactPaths">ExactPaths.</param>

        /// <param name="GlobPaths">GlobPaths.</param>

        /// <param name="Root">Root.</param>


        public InternalUiReadResultantAclResponse(Object ExactPaths = default(Object), Object GlobPaths = default(Object), bool Root = default(bool))
        {

            this.ExactPaths = ExactPaths;

            this.GlobPaths = GlobPaths;

            this.Root = Root;

        }

        /// <summary>
        /// Gets or Sets ExactPaths
        /// </summary>
        [DataMember(Name = "exact_paths", EmitDefaultValue = false)]

        public Object ExactPaths { get; set; }


        /// <summary>
        /// Gets or Sets GlobPaths
        /// </summary>
        [DataMember(Name = "glob_paths", EmitDefaultValue = false)]

        public Object GlobPaths { get; set; }


        /// <summary>
        /// Gets or Sets Root
        /// </summary>
        [DataMember(Name = "root", EmitDefaultValue = true)]

        public bool Root { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InternalUiReadResultantAclResponse {\n");
            sb.Append("  ExactPaths: ").Append(ExactPaths).Append("\n");
            sb.Append("  GlobPaths: ").Append(GlobPaths).Append("\n");
            sb.Append("  Root: ").Append(Root).Append("\n");
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
            return this.Equals(input as InternalUiReadResultantAclResponse);
        }

        /// <summary>
        /// Returns true if InternalUiReadResultantAclResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InternalUiReadResultantAclResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InternalUiReadResultantAclResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.ExactPaths == input.ExactPaths ||
                    (this.ExactPaths != null &&
                    this.ExactPaths.Equals(input.ExactPaths))

                ) &&
                (
                    this.GlobPaths == input.GlobPaths ||
                    (this.GlobPaths != null &&
                    this.GlobPaths.Equals(input.GlobPaths))

                ) &&
                (
                    this.Root == input.Root ||

                    this.Root.Equals(input.Root)
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

                if (this.ExactPaths != null)
                {
                    hashCode = (hashCode * 59) + this.ExactPaths.GetHashCode();
                }

                if (this.GlobPaths != null)
                {
                    hashCode = (hashCode * 59) + this.GlobPaths.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Root.GetHashCode();
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
