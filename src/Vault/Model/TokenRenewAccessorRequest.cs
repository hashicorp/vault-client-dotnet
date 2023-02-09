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
    /// TokenRenewAccessorRequest
    /// </summary>
    [DataContract(Name = "TokenRenewAccessorRequest")]
    public partial class TokenRenewAccessorRequest : IEquatable<TokenRenewAccessorRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenRenewAccessorRequest" /> class.
        /// </summary>
        /// <param name="accessor">Accessor of the token to renew (request body).</param>
        /// <param name="increment">The desired increment in seconds to the token expiration (default to 0).</param>
        public TokenRenewAccessorRequest(string accessor = default(string), int increment = 0)
        {
            this.Accessor = accessor;
            this.Increment = increment;
        }

        /// <summary>
        /// Accessor of the token to renew (request body)
        /// </summary>
        /// <value>Accessor of the token to renew (request body)</value>
        [DataMember(Name = "accessor", EmitDefaultValue = false)]
        public string Accessor { get; set; }

        /// <summary>
        /// The desired increment in seconds to the token expiration
        /// </summary>
        /// <value>The desired increment in seconds to the token expiration</value>
        [DataMember(Name = "increment", EmitDefaultValue = false)]
        public int Increment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokenRenewAccessorRequest {\n");
            sb.Append("  Accessor: ").Append(Accessor).Append("\n");
            sb.Append("  Increment: ").Append(Increment).Append("\n");
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
            return this.Equals(input as TokenRenewAccessorRequest);
        }

        /// <summary>
        /// Returns true if TokenRenewAccessorRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenRenewAccessorRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenRenewAccessorRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Accessor == input.Accessor ||
                    (this.Accessor != null &&
                    this.Accessor.Equals(input.Accessor))
                ) && 
                (
                    this.Increment == input.Increment ||
                    this.Increment.Equals(input.Increment)
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
                if (this.Accessor != null)
                {
                    hashCode = (hashCode * 59) + this.Accessor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Increment.GetHashCode();
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
