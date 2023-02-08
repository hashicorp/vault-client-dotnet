// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

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
    /// TokenRenewRequest
    /// </summary>
    [DataContract(Name = "TokenRenewRequest")]
    public partial class TokenRenewRequest : IEquatable<TokenRenewRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenRenewRequest" /> class.
        /// </summary>
        /// <param name="increment">The desired increment in seconds to the token expiration (default to 0).</param>
        /// <param name="token">Token to renew (request body).</param>
        public TokenRenewRequest(int increment = 0, string token = default(string))
        {
            this.Increment = increment;
            this.Token = token;
        }

        /// <summary>
        /// The desired increment in seconds to the token expiration
        /// </summary>
        /// <value>The desired increment in seconds to the token expiration</value>
        [DataMember(Name = "increment", EmitDefaultValue = false)]
        public int Increment { get; set; }

        /// <summary>
        /// Token to renew (request body)
        /// </summary>
        /// <value>Token to renew (request body)</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokenRenewRequest {\n");
            sb.Append("  Increment: ").Append(Increment).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(input as TokenRenewRequest);
        }

        /// <summary>
        /// Returns true if TokenRenewRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenRenewRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenRenewRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Increment == input.Increment ||
                    this.Increment.Equals(input.Increment)
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
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
                hashCode = (hashCode * 59) + this.Increment.GetHashCode();
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
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
