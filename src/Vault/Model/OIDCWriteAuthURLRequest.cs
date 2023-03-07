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
    /// OIDCWriteAuthURLRequest
    /// </summary>
    [DataContract(Name = "OIDCWriteAuthURLRequest")]
    public partial class OIDCWriteAuthURLRequest : IEquatable<OIDCWriteAuthURLRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="OIDCWriteAuthURLRequest" /> class.
        /// </summary>

        /// <param name="ClientNonce">Optional client-provided nonce that must match during callback, if present..</param>

        /// <param name="RedirectUri">The OAuth redirect_uri to use in the authorization URL..</param>

        /// <param name="Role">The role to issue an OIDC authorization URL against..</param>


        public OIDCWriteAuthURLRequest(string ClientNonce = default(string), string RedirectUri = default(string), string Role = default(string))
        {

            this.ClientNonce = ClientNonce;

            this.RedirectUri = RedirectUri;

            this.Role = Role;

        }

        /// <summary>
        /// Optional client-provided nonce that must match during callback, if present.
        /// </summary>
        /// <value>Optional client-provided nonce that must match during callback, if present.</value>
        [DataMember(Name = "client_nonce", EmitDefaultValue = false)]

        public string ClientNonce { get; set; }


        /// <summary>
        /// The OAuth redirect_uri to use in the authorization URL.
        /// </summary>
        /// <value>The OAuth redirect_uri to use in the authorization URL.</value>
        [DataMember(Name = "redirect_uri", EmitDefaultValue = false)]

        public string RedirectUri { get; set; }


        /// <summary>
        /// The role to issue an OIDC authorization URL against.
        /// </summary>
        /// <value>The role to issue an OIDC authorization URL against.</value>
        [DataMember(Name = "role", EmitDefaultValue = false)]

        public string Role { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OIDCWriteAuthURLRequest {\n");
            sb.Append("  ClientNonce: ").Append(ClientNonce).Append("\n");
            sb.Append("  RedirectUri: ").Append(RedirectUri).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
            return this.Equals(input as OIDCWriteAuthURLRequest);
        }

        /// <summary>
        /// Returns true if OIDCWriteAuthURLRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OIDCWriteAuthURLRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OIDCWriteAuthURLRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.ClientNonce == input.ClientNonce ||
                    (this.ClientNonce != null &&
                    this.ClientNonce.Equals(input.ClientNonce))

                ) &&
                (
                    this.RedirectUri == input.RedirectUri ||
                    (this.RedirectUri != null &&
                    this.RedirectUri.Equals(input.RedirectUri))

                ) &&
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))

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

                if (this.ClientNonce != null)
                {
                    hashCode = (hashCode * 59) + this.ClientNonce.GetHashCode();
                }

                if (this.RedirectUri != null)
                {
                    hashCode = (hashCode * 59) + this.RedirectUri.GetHashCode();
                }

                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
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
