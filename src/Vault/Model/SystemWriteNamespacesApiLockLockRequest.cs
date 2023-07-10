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
    /// SystemWriteNamespacesApiLockLockRequest
    /// </summary>
    [DataContract(Name = "SystemWriteNamespacesApiLockLockRequest")]
    public partial class SystemWriteNamespacesApiLockLockRequest : IEquatable<SystemWriteNamespacesApiLockLockRequest>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemWriteNamespacesApiLockLockRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SystemWriteNamespacesApiLockLockRequest() { }


        /// <summary>
        /// Initializes a new instance of the <see cref="SystemWriteNamespacesApiLockLockRequest" /> class.
        /// </summary>

        /// <param name="Path">Path (required).</param>


        public SystemWriteNamespacesApiLockLockRequest(string Path = default(string))
        {

            // to ensure "Path" is required (not null)
            if (Path == null)
            {
                throw new ArgumentNullException("Path is a required property for SystemWriteNamespacesApiLockLockRequest and cannot be null");
            }
            this.Path = Path;


        }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name = "path", IsRequired = true, EmitDefaultValue = false)]

        public string Path { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SystemWriteNamespacesApiLockLockRequest {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
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
            return this.Equals(input as SystemWriteNamespacesApiLockLockRequest);
        }

        /// <summary>
        /// Returns true if SystemWriteNamespacesApiLockLockRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemWriteNamespacesApiLockLockRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemWriteNamespacesApiLockLockRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))

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

                if (this.Path != null)
                {
                    hashCode = (hashCode * 59) + this.Path.GetHashCode();
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
