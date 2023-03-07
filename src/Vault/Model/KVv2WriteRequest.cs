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
    /// KVv2WriteRequest
    /// </summary>
    [DataContract(Name = "KVv2WriteRequest")]
    public partial class KVv2WriteRequest : IEquatable<KVv2WriteRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="KVv2WriteRequest" /> class.
        /// </summary>

        /// <param name="Data">The contents of the data map will be stored and returned on read..</param>

        /// <param name="Options">Options for writing a KV entry. Set the \&quot;cas\&quot; value to use a Check-And-Set operation. If not set the write will be allowed. If set to 0 a write will only be allowed if the key doesn’t exist. If the index is non-zero the write will only be allowed if the key’s current version matches the version specified in the cas parameter..</param>

        /// <param name="_Version">If provided during a read, the value at the version number will be returned.</param>


        public KVv2WriteRequest(Object Data = default(Object), Object Options = default(Object), int _Version = default(int))
        {

            this.Data = Data;

            this.Options = Options;

            this._Version = _Version;

        }

        /// <summary>
        /// The contents of the data map will be stored and returned on read.
        /// </summary>
        /// <value>The contents of the data map will be stored and returned on read.</value>
        [DataMember(Name = "data", EmitDefaultValue = false)]

        public Object Data { get; set; }


        /// <summary>
        /// Options for writing a KV entry. Set the \&quot;cas\&quot; value to use a Check-And-Set operation. If not set the write will be allowed. If set to 0 a write will only be allowed if the key doesn’t exist. If the index is non-zero the write will only be allowed if the key’s current version matches the version specified in the cas parameter.
        /// </summary>
        /// <value>Options for writing a KV entry. Set the \&quot;cas\&quot; value to use a Check-And-Set operation. If not set the write will be allowed. If set to 0 a write will only be allowed if the key doesn’t exist. If the index is non-zero the write will only be allowed if the key’s current version matches the version specified in the cas parameter.</value>
        [DataMember(Name = "options", EmitDefaultValue = false)]

        public Object Options { get; set; }


        /// <summary>
        /// If provided during a read, the value at the version number will be returned
        /// </summary>
        /// <value>If provided during a read, the value at the version number will be returned</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]

        public int _Version { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KVv2WriteRequest {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as KVv2WriteRequest);
        }

        /// <summary>
        /// Returns true if KVv2WriteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of KVv2WriteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KVv2WriteRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))

                ) &&
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))

                ) &&
                (
                    this._Version == input._Version ||

                    this._Version.Equals(input._Version)
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

                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }

                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
                }


                hashCode = (hashCode * 59) + this._Version.GetHashCode();
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
