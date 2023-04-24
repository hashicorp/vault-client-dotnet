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
    /// RootTokenGenerationInitializeRequest
    /// </summary>
    [DataContract(Name = "RootTokenGenerationInitializeRequest")]
    public partial class RootTokenGenerationInitializeRequest : IEquatable<RootTokenGenerationInitializeRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="RootTokenGenerationInitializeRequest" /> class.
        /// </summary>

        /// <param name="PgpKey">Specifies a base64-encoded PGP public key..</param>


        public RootTokenGenerationInitializeRequest(string PgpKey = default(string))
        {

            this.PgpKey = PgpKey;

        }

        /// <summary>
        /// Specifies a base64-encoded PGP public key.
        /// </summary>
        /// <value>Specifies a base64-encoded PGP public key.</value>
        [DataMember(Name = "pgp_key", EmitDefaultValue = false)]

        public string PgpKey { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RootTokenGenerationInitializeRequest {\n");
            sb.Append("  PgpKey: ").Append(PgpKey).Append("\n");
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
            return this.Equals(input as RootTokenGenerationInitializeRequest);
        }

        /// <summary>
        /// Returns true if RootTokenGenerationInitializeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RootTokenGenerationInitializeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RootTokenGenerationInitializeRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.PgpKey == input.PgpKey ||
                    (this.PgpKey != null &&
                    this.PgpKey.Equals(input.PgpKey))

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

                if (this.PgpKey != null)
                {
                    hashCode = (hashCode * 59) + this.PgpKey.GetHashCode();
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
