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
    /// TokenRenewSelfRequest
    /// </summary>
    [DataContract(Name = "TokenRenewSelfRequest")]
    public partial class TokenRenewSelfRequest : IEquatable<TokenRenewSelfRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="TokenRenewSelfRequest" /> class.
        /// </summary>

        /// <param name="Increment">The desired increment in seconds to the token expiration (default to &quot;0&quot;).</param>

        /// <param name="Token">Token to renew (unused, does not need to be set).</param>


        public TokenRenewSelfRequest(string Increment = "0", string Token = default(string))
        {

            // use default value if no "Increment" provided
            this.Increment = Increment ?? "0";


            this.Token = Token;

        }

        /// <summary>
        /// The desired increment in seconds to the token expiration
        /// </summary>
        /// <value>The desired increment in seconds to the token expiration</value>
        [DataMember(Name = "increment", EmitDefaultValue = false)]

        public string Increment { get; set; }


        /// <summary>
        /// Token to renew (unused, does not need to be set)
        /// </summary>
        /// <value>Token to renew (unused, does not need to be set)</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]

        public string Token { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokenRenewSelfRequest {\n");
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
            return this.Equals(input as TokenRenewSelfRequest);
        }

        /// <summary>
        /// Returns true if TokenRenewSelfRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenRenewSelfRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenRenewSelfRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Increment == input.Increment ||
                    (this.Increment != null &&
                    this.Increment.Equals(input.Increment))

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

                if (this.Increment != null)
                {
                    hashCode = (hashCode * 59) + this.Increment.GetHashCode();
                }

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
