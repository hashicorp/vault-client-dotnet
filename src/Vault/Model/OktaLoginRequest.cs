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
    /// OktaLoginRequest
    /// </summary>
    [DataContract(Name = "OktaLoginRequest")]
    public partial class OktaLoginRequest : IEquatable<OktaLoginRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OktaLoginRequest" /> class.
        /// </summary>
        /// <param name="nonce">Nonce provided if performing login that requires number verification challenge. Logins through the vault login CLI command will automatically generate a nonce..</param>
        /// <param name="password">Password for this user..</param>
        /// <param name="provider">Preferred factor provider..</param>
        /// <param name="totp">TOTP passcode..</param>
        public OktaLoginRequest(string nonce = default(string), string password = default(string), string provider = default(string), string totp = default(string))
        {
            this.Nonce = nonce;
            this.Password = password;
            this.Provider = provider;
            this.Totp = totp;
        }

        /// <summary>
        /// Nonce provided if performing login that requires number verification challenge. Logins through the vault login CLI command will automatically generate a nonce.
        /// </summary>
        /// <value>Nonce provided if performing login that requires number verification challenge. Logins through the vault login CLI command will automatically generate a nonce.</value>
        [DataMember(Name = "nonce", EmitDefaultValue = false)]
        public string Nonce { get; set; }

        /// <summary>
        /// Password for this user.
        /// </summary>
        /// <value>Password for this user.</value>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Preferred factor provider.
        /// </summary>
        /// <value>Preferred factor provider.</value>
        [DataMember(Name = "provider", EmitDefaultValue = false)]
        public string Provider { get; set; }

        /// <summary>
        /// TOTP passcode.
        /// </summary>
        /// <value>TOTP passcode.</value>
        [DataMember(Name = "totp", EmitDefaultValue = false)]
        public string Totp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OktaLoginRequest {\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Totp: ").Append(Totp).Append("\n");
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
            return this.Equals(input as OktaLoginRequest);
        }

        /// <summary>
        /// Returns true if OktaLoginRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OktaLoginRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OktaLoginRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.Totp == input.Totp ||
                    (this.Totp != null &&
                    this.Totp.Equals(input.Totp))
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
                if (this.Nonce != null)
                {
                    hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                if (this.Provider != null)
                {
                    hashCode = (hashCode * 59) + this.Provider.GetHashCode();
                }
                if (this.Totp != null)
                {
                    hashCode = (hashCode * 59) + this.Totp.GetHashCode();
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
