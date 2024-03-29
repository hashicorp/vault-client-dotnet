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
    /// OidcRotateKeyRequest
    /// </summary>
    [DataContract(Name = "OidcRotateKeyRequest")]
    public partial class OidcRotateKeyRequest : IEquatable<OidcRotateKeyRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="OidcRotateKeyRequest" /> class.
        /// </summary>

        /// <param name="VerificationTtl">Controls how long the public portion of a key will be available for verification after being rotated. Setting verification_ttl here will override the verification_ttl set on the key..</param>


        public OidcRotateKeyRequest(string VerificationTtl = default(string))
        {

            this.VerificationTtl = VerificationTtl;

        }

        /// <summary>
        /// Controls how long the public portion of a key will be available for verification after being rotated. Setting verification_ttl here will override the verification_ttl set on the key.
        /// </summary>
        /// <value>Controls how long the public portion of a key will be available for verification after being rotated. Setting verification_ttl here will override the verification_ttl set on the key.</value>
        [DataMember(Name = "verification_ttl", EmitDefaultValue = false)]

        public string VerificationTtl { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OidcRotateKeyRequest {\n");
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
            return this.Equals(input as OidcRotateKeyRequest);
        }

        /// <summary>
        /// Returns true if OidcRotateKeyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OidcRotateKeyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OidcRotateKeyRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.VerificationTtl == input.VerificationTtl ||
                    (this.VerificationTtl != null &&
                    this.VerificationTtl.Equals(input.VerificationTtl))

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

                if (this.VerificationTtl != null)
                {
                    hashCode = (hashCode * 59) + this.VerificationTtl.GetHashCode();
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
