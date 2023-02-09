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
    /// OIDCWriteProviderTokenRequest
    /// </summary>
    [DataContract(Name = "OIDCWriteProviderTokenRequest")]
    public partial class OIDCWriteProviderTokenRequest : IEquatable<OIDCWriteProviderTokenRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OIDCWriteProviderTokenRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OIDCWriteProviderTokenRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OIDCWriteProviderTokenRequest" /> class.
        /// </summary>
        /// <param name="clientId">The ID of the requesting client..</param>
        /// <param name="clientSecret">The secret of the requesting client..</param>
        /// <param name="code">The authorization code received from the provider&#39;s authorization endpoint. (required).</param>
        /// <param name="codeVerifier">The code verifier associated with the authorization code..</param>
        /// <param name="grantType">The authorization grant type. The following grant types are supported: &#39;authorization_code&#39;. (required).</param>
        /// <param name="redirectUri">The callback location where the authentication response was sent. (required).</param>
        public OIDCWriteProviderTokenRequest(string clientId = default(string), string clientSecret = default(string), string code = default(string), string codeVerifier = default(string), string grantType = default(string), string redirectUri = default(string))
        {
            // to ensure "code" is required (not null)
            if (code == null) {
                throw new ArgumentNullException("code is a required property for OIDCWriteProviderTokenRequest and cannot be null");
            }
            this.Code = code;
            // to ensure "grantType" is required (not null)
            if (grantType == null) {
                throw new ArgumentNullException("grantType is a required property for OIDCWriteProviderTokenRequest and cannot be null");
            }
            this.GrantType = grantType;
            // to ensure "redirectUri" is required (not null)
            if (redirectUri == null) {
                throw new ArgumentNullException("redirectUri is a required property for OIDCWriteProviderTokenRequest and cannot be null");
            }
            this.RedirectUri = redirectUri;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.CodeVerifier = codeVerifier;
        }

        /// <summary>
        /// The ID of the requesting client.
        /// </summary>
        /// <value>The ID of the requesting client.</value>
        [DataMember(Name = "client_id", EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// The secret of the requesting client.
        /// </summary>
        /// <value>The secret of the requesting client.</value>
        [DataMember(Name = "client_secret", EmitDefaultValue = false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// The authorization code received from the provider&#39;s authorization endpoint.
        /// </summary>
        /// <value>The authorization code received from the provider&#39;s authorization endpoint.</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// The code verifier associated with the authorization code.
        /// </summary>
        /// <value>The code verifier associated with the authorization code.</value>
        [DataMember(Name = "code_verifier", EmitDefaultValue = false)]
        public string CodeVerifier { get; set; }

        /// <summary>
        /// The authorization grant type. The following grant types are supported: &#39;authorization_code&#39;.
        /// </summary>
        /// <value>The authorization grant type. The following grant types are supported: &#39;authorization_code&#39;.</value>
        [DataMember(Name = "grant_type", IsRequired = true, EmitDefaultValue = false)]
        public string GrantType { get; set; }

        /// <summary>
        /// The callback location where the authentication response was sent.
        /// </summary>
        /// <value>The callback location where the authentication response was sent.</value>
        [DataMember(Name = "redirect_uri", IsRequired = true, EmitDefaultValue = false)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OIDCWriteProviderTokenRequest {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  CodeVerifier: ").Append(CodeVerifier).Append("\n");
            sb.Append("  GrantType: ").Append(GrantType).Append("\n");
            sb.Append("  RedirectUri: ").Append(RedirectUri).Append("\n");
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
            return this.Equals(input as OIDCWriteProviderTokenRequest);
        }

        /// <summary>
        /// Returns true if OIDCWriteProviderTokenRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OIDCWriteProviderTokenRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OIDCWriteProviderTokenRequest input)
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
                    this.ClientSecret == input.ClientSecret ||
                    (this.ClientSecret != null &&
                    this.ClientSecret.Equals(input.ClientSecret))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.CodeVerifier == input.CodeVerifier ||
                    (this.CodeVerifier != null &&
                    this.CodeVerifier.Equals(input.CodeVerifier))
                ) && 
                (
                    this.GrantType == input.GrantType ||
                    (this.GrantType != null &&
                    this.GrantType.Equals(input.GrantType))
                ) && 
                (
                    this.RedirectUri == input.RedirectUri ||
                    (this.RedirectUri != null &&
                    this.RedirectUri.Equals(input.RedirectUri))
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
                if (this.ClientSecret != null)
                {
                    hashCode = (hashCode * 59) + this.ClientSecret.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.CodeVerifier != null)
                {
                    hashCode = (hashCode * 59) + this.CodeVerifier.GetHashCode();
                }
                if (this.GrantType != null)
                {
                    hashCode = (hashCode * 59) + this.GrantType.GetHashCode();
                }
                if (this.RedirectUri != null)
                {
                    hashCode = (hashCode * 59) + this.RedirectUri.GetHashCode();
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
