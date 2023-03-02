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
    /// TokenRevokeOrphanRequest
    /// </summary>
    [DataContract(Name = "TokenRevokeOrphanRequest")]

    public partial class TokenRevokeOrphanRequest : IEquatable<TokenRevokeOrphanRequest>, IValidatableObject
    {





        /// <summary>
        /// Initializes a new instance of the <see cref="TokenRevokeOrphanRequest" /> class.
        /// </summary>

        /// <param name="Token">Token to revoke (request body).</param>


        public TokenRevokeOrphanRequest(string Token = default(string))
        {

            this.Token = Token;

        }

        /// <summary>
        /// Token to revoke (request body)
        /// </summary>
        /// <value>Token to revoke (request body)</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]


        public string Token { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokenRevokeOrphanRequest {\n");
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
            return this.Equals(input as TokenRevokeOrphanRequest);
        }

        /// <summary>
        /// Returns true if TokenRevokeOrphanRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenRevokeOrphanRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenRevokeOrphanRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
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
