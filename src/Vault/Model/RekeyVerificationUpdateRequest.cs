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
    /// RekeyVerificationUpdateRequest
    /// </summary>
    [DataContract(Name = "RekeyVerificationUpdateRequest")]
    public partial class RekeyVerificationUpdateRequest : IEquatable<RekeyVerificationUpdateRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="RekeyVerificationUpdateRequest" /> class.
        /// </summary>

        /// <param name="Key">Specifies a single unseal share key from the new set of shares..</param>

        /// <param name="Nonce">Specifies the nonce of the rekey verification operation..</param>


        public RekeyVerificationUpdateRequest(string Key = default(string), string Nonce = default(string))
        {

            this.Key = Key;

            this.Nonce = Nonce;

        }

        /// <summary>
        /// Specifies a single unseal share key from the new set of shares.
        /// </summary>
        /// <value>Specifies a single unseal share key from the new set of shares.</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]

        public string Key { get; set; }


        /// <summary>
        /// Specifies the nonce of the rekey verification operation.
        /// </summary>
        /// <value>Specifies the nonce of the rekey verification operation.</value>
        [DataMember(Name = "nonce", EmitDefaultValue = false)]

        public string Nonce { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RekeyVerificationUpdateRequest {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
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
            return this.Equals(input as RekeyVerificationUpdateRequest);
        }

        /// <summary>
        /// Returns true if RekeyVerificationUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RekeyVerificationUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RekeyVerificationUpdateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))

                ) &&
                (
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))

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

                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }

                if (this.Nonce != null)
                {
                    hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
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
