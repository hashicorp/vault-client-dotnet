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
    /// OIDCRotateKeyRequest
    /// </summary>
    [DataContract(Name = "OIDCRotateKeyRequest")]
    public partial class OIDCRotateKeyRequest : IEquatable<OIDCRotateKeyRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OIDCRotateKeyRequest" /> class.
        /// </summary>
        /// <param name="verificationTtl">Controls how long the public portion of a key will be available for verification after being rotated. Setting verification_ttl here will override the verification_ttl set on the key..</param>
        public OIDCRotateKeyRequest(int verificationTtl = default(int))
        {
            this.VerificationTtl = verificationTtl;
        }

        /// <summary>
        /// Controls how long the public portion of a key will be available for verification after being rotated. Setting verification_ttl here will override the verification_ttl set on the key.
        /// </summary>
        /// <value>Controls how long the public portion of a key will be available for verification after being rotated. Setting verification_ttl here will override the verification_ttl set on the key.</value>
        [DataMember(Name = "verification_ttl", EmitDefaultValue = false)]
        public int VerificationTtl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OIDCRotateKeyRequest {\n");
            sb.Append("  VerificationTtl: ").Append(VerificationTtl).Append("\n");
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
            return this.Equals(input as OIDCRotateKeyRequest);
        }

        /// <summary>
        /// Returns true if OIDCRotateKeyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OIDCRotateKeyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OIDCRotateKeyRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.VerificationTtl == input.VerificationTtl ||
                    this.VerificationTtl.Equals(input.VerificationTtl)
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
                hashCode = (hashCode * 59) + this.VerificationTtl.GetHashCode();
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
