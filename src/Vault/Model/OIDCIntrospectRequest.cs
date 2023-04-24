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
    /// OidcIntrospectRequest
    /// </summary>
    [DataContract(Name = "OidcIntrospectRequest")]
    public partial class OidcIntrospectRequest : IEquatable<OidcIntrospectRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="OidcIntrospectRequest" /> class.
        /// </summary>

        /// <param name="ClientId">Optional client_id to verify.</param>

        /// <param name="Token">Token to verify.</param>


        public OidcIntrospectRequest(string ClientId = default(string), string Token = default(string))
        {

            this.ClientId = ClientId;

            this.Token = Token;

        }

        /// <summary>
        /// Optional client_id to verify
        /// </summary>
        /// <value>Optional client_id to verify</value>
        [DataMember(Name = "client_id", EmitDefaultValue = false)]

        public string ClientId { get; set; }


        /// <summary>
        /// Token to verify
        /// </summary>
        /// <value>Token to verify</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]

        public string Token { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OidcIntrospectRequest {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
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
            return this.Equals(input as OidcIntrospectRequest);
        }

        /// <summary>
        /// Returns true if OidcIntrospectRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OidcIntrospectRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OidcIntrospectRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))

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

                if (this.ClientId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientId.GetHashCode();
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
