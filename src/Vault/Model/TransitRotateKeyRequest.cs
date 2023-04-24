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
    /// TransitRotateKeyRequest
    /// </summary>
    [DataContract(Name = "TransitRotateKeyRequest")]
    public partial class TransitRotateKeyRequest : IEquatable<TransitRotateKeyRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="TransitRotateKeyRequest" /> class.
        /// </summary>

        /// <param name="ManagedKeyId">The UUID of the managed key to use for the new version of this transit key.</param>

        /// <param name="ManagedKeyName">The name of the managed key to use for the new version of this transit key.</param>


        public TransitRotateKeyRequest(string ManagedKeyId = default(string), string ManagedKeyName = default(string))
        {

            this.ManagedKeyId = ManagedKeyId;

            this.ManagedKeyName = ManagedKeyName;

        }

        /// <summary>
        /// The UUID of the managed key to use for the new version of this transit key
        /// </summary>
        /// <value>The UUID of the managed key to use for the new version of this transit key</value>
        [DataMember(Name = "managed_key_id", EmitDefaultValue = false)]

        public string ManagedKeyId { get; set; }


        /// <summary>
        /// The name of the managed key to use for the new version of this transit key
        /// </summary>
        /// <value>The name of the managed key to use for the new version of this transit key</value>
        [DataMember(Name = "managed_key_name", EmitDefaultValue = false)]

        public string ManagedKeyName { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransitRotateKeyRequest {\n");
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
            return this.Equals(input as TransitRotateKeyRequest);
        }

        /// <summary>
        /// Returns true if TransitRotateKeyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransitRotateKeyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransitRotateKeyRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
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
