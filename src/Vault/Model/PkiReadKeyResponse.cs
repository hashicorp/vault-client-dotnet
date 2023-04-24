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
    /// PkiReadKeyResponse
    /// </summary>
    [DataContract(Name = "PkiReadKeyResponse")]
    public partial class PkiReadKeyResponse : IEquatable<PkiReadKeyResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PkiReadKeyResponse" /> class.
        /// </summary>

        /// <param name="KeyId">Key Id.</param>

        /// <param name="KeyName">Key Name.</param>

        /// <param name="KeyType">Key Type.</param>

        /// <param name="ManagedKeyId">Managed Key Id.</param>

        /// <param name="ManagedKeyName">Managed Key Name.</param>


        public PkiReadKeyResponse(string KeyId = default(string), string KeyName = default(string), string KeyType = default(string), string ManagedKeyId = default(string), string ManagedKeyName = default(string))
        {

            this.KeyId = KeyId;

            this.KeyName = KeyName;

            this.KeyType = KeyType;

            this.ManagedKeyId = ManagedKeyId;

            this.ManagedKeyName = ManagedKeyName;

        }

        /// <summary>
        /// Key Id
        /// </summary>
        /// <value>Key Id</value>
        [DataMember(Name = "key_id", EmitDefaultValue = false)]

        public string KeyId { get; set; }


        /// <summary>
        /// Key Name
        /// </summary>
        /// <value>Key Name</value>
        [DataMember(Name = "key_name", EmitDefaultValue = false)]

        public string KeyName { get; set; }


        /// <summary>
        /// Key Type
        /// </summary>
        /// <value>Key Type</value>
        [DataMember(Name = "key_type", EmitDefaultValue = false)]

        public string KeyType { get; set; }


        /// <summary>
        /// Managed Key Id
        /// </summary>
        /// <value>Managed Key Id</value>
        [DataMember(Name = "managed_key_id", EmitDefaultValue = false)]

        public string ManagedKeyId { get; set; }


        /// <summary>
        /// Managed Key Name
        /// </summary>
        /// <value>Managed Key Name</value>
        [DataMember(Name = "managed_key_name", EmitDefaultValue = false)]

        public string ManagedKeyName { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiReadKeyResponse {\n");
            sb.Append("  KeyId: ").Append(KeyId).Append("\n");
            sb.Append("  KeyName: ").Append(KeyName).Append("\n");
            sb.Append("  KeyType: ").Append(KeyType).Append("\n");
            sb.Append("  ManagedKeyId: ").Append(ManagedKeyId).Append("\n");
            sb.Append("  ManagedKeyName: ").Append(ManagedKeyName).Append("\n");
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
            return this.Equals(input as PkiReadKeyResponse);
        }

        /// <summary>
        /// Returns true if PkiReadKeyResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiReadKeyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiReadKeyResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.KeyId == input.KeyId ||
                    (this.KeyId != null &&
                    this.KeyId.Equals(input.KeyId))

                ) &&
                (
                    this.KeyName == input.KeyName ||
                    (this.KeyName != null &&
                    this.KeyName.Equals(input.KeyName))

                ) &&
                (
                    this.KeyType == input.KeyType ||
                    (this.KeyType != null &&
                    this.KeyType.Equals(input.KeyType))

                ) &&
                (
                    this.ManagedKeyId == input.ManagedKeyId ||
                    (this.ManagedKeyId != null &&
                    this.ManagedKeyId.Equals(input.ManagedKeyId))

                ) &&
                (
                    this.ManagedKeyName == input.ManagedKeyName ||
                    (this.ManagedKeyName != null &&
                    this.ManagedKeyName.Equals(input.ManagedKeyName))

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

                if (this.KeyId != null)
                {
                    hashCode = (hashCode * 59) + this.KeyId.GetHashCode();
                }

                if (this.KeyName != null)
                {
                    hashCode = (hashCode * 59) + this.KeyName.GetHashCode();
                }

                if (this.KeyType != null)
                {
                    hashCode = (hashCode * 59) + this.KeyType.GetHashCode();
                }

                if (this.ManagedKeyId != null)
                {
                    hashCode = (hashCode * 59) + this.ManagedKeyId.GetHashCode();
                }

                if (this.ManagedKeyName != null)
                {
                    hashCode = (hashCode * 59) + this.ManagedKeyName.GetHashCode();
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
