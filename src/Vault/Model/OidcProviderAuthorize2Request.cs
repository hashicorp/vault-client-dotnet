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
    /// OidcProviderAuthorize2Request
    /// </summary>
    [DataContract(Name = "OidcProviderAuthorize2Request")]
    public partial class OidcProviderAuthorize2Request : IEquatable<OidcProviderAuthorize2Request>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="OidcProviderAuthorize2Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OidcProviderAuthorize2Request() { }


        /// <summary>
        /// Initializes a new instance of the <see cref="OidcProviderAuthorize2Request" /> class.
        /// </summary>

        /// <param name="ClientId">The ID of the requesting client. (required).</param>

        /// <param name="CodeChallenge">The code challenge derived from the code verifier..</param>

        /// <param name="CodeChallengeMethod">The method that was used to derive the code challenge. The following methods are supported: &#x27;S256&#x27;, &#x27;plain&#x27;. Defaults to &#x27;plain&#x27;. (default to &quot;plain&quot;).</param>

        /// <param name="MaxAge">The allowable elapsed time in seconds since the last time the end-user was actively authenticated..</param>

        /// <param name="Nonce">The value that will be returned in the ID token nonce claim after a token exchange..</param>

        /// <param name="RedirectUri">The redirection URI to which the response will be sent. (required).</param>

        /// <param name="ResponseType">The OIDC authentication flow to be used. The following response types are supported: &#x27;code&#x27; (required).</param>

        /// <param name="Scope">A space-delimited, case-sensitive list of scopes to be requested. The &#x27;openid&#x27; scope is required. (required).</param>

        /// <param name="State">The value used to maintain state between the authentication request and client..</param>


        public OidcProviderAuthorize2Request(string ClientId = default(string), string CodeChallenge = default(string), string CodeChallengeMethod = "plain", int MaxAge = default(int), string Nonce = default(string), string RedirectUri = default(string), string ResponseType = default(string), string Scope = default(string), string State = default(string))
        {

            // to ensure "ClientId" is required (not null)
            if (ClientId == null)
            {
                throw new ArgumentNullException("ClientId is a required property for OidcProviderAuthorize2Request and cannot be null");
            }
            this.ClientId = ClientId;


            // to ensure "RedirectUri" is required (not null)
            if (RedirectUri == null)
            {
                throw new ArgumentNullException("RedirectUri is a required property for OidcProviderAuthorize2Request and cannot be null");
            }
            this.RedirectUri = RedirectUri;


            // to ensure "ResponseType" is required (not null)
            if (ResponseType == null)
            {
                throw new ArgumentNullException("ResponseType is a required property for OidcProviderAuthorize2Request and cannot be null");
            }
            this.ResponseType = ResponseType;


            // to ensure "Scope" is required (not null)
            if (Scope == null)
            {
                throw new ArgumentNullException("Scope is a required property for OidcProviderAuthorize2Request and cannot be null");
            }
            this.Scope = Scope;


            this.CodeChallenge = CodeChallenge;

            // use default value if no "CodeChallengeMethod" provided
            this.CodeChallengeMethod = CodeChallengeMethod ?? "plain";


            this.MaxAge = MaxAge;

            this.Nonce = Nonce;

            this.State = State;

        }

        /// <summary>
        /// The ID of the requesting client.
        /// </summary>
        /// <value>The ID of the requesting client.</value>
        [DataMember(Name = "client_id", IsRequired = true, EmitDefaultValue = false)]

        public string ClientId { get; set; }


        /// <summary>
        /// The code challenge derived from the code verifier.
        /// </summary>
        /// <value>The code challenge derived from the code verifier.</value>
        [DataMember(Name = "code_challenge", EmitDefaultValue = false)]

        public string CodeChallenge { get; set; }


        /// <summary>
        /// The method that was used to derive the code challenge. The following methods are supported: &#x27;S256&#x27;, &#x27;plain&#x27;. Defaults to &#x27;plain&#x27;.
        /// </summary>
        /// <value>The method that was used to derive the code challenge. The following methods are supported: &#x27;S256&#x27;, &#x27;plain&#x27;. Defaults to &#x27;plain&#x27;.</value>
        [DataMember(Name = "code_challenge_method", EmitDefaultValue = false)]

        public string CodeChallengeMethod { get; set; }


        /// <summary>
        /// The allowable elapsed time in seconds since the last time the end-user was actively authenticated.
        /// </summary>
        /// <value>The allowable elapsed time in seconds since the last time the end-user was actively authenticated.</value>
        [DataMember(Name = "max_age", EmitDefaultValue = false)]

        public int MaxAge { get; set; }


        /// <summary>
        /// The value that will be returned in the ID token nonce claim after a token exchange.
        /// </summary>
        /// <value>The value that will be returned in the ID token nonce claim after a token exchange.</value>
        [DataMember(Name = "nonce", EmitDefaultValue = false)]

        public string Nonce { get; set; }


        /// <summary>
        /// The redirection URI to which the response will be sent.
        /// </summary>
        /// <value>The redirection URI to which the response will be sent.</value>
        [DataMember(Name = "redirect_uri", IsRequired = true, EmitDefaultValue = false)]

        public string RedirectUri { get; set; }


        /// <summary>
        /// The OIDC authentication flow to be used. The following response types are supported: &#x27;code&#x27;
        /// </summary>
        /// <value>The OIDC authentication flow to be used. The following response types are supported: &#x27;code&#x27;</value>
        [DataMember(Name = "response_type", IsRequired = true, EmitDefaultValue = false)]

        public string ResponseType { get; set; }


        /// <summary>
        /// A space-delimited, case-sensitive list of scopes to be requested. The &#x27;openid&#x27; scope is required.
        /// </summary>
        /// <value>A space-delimited, case-sensitive list of scopes to be requested. The &#x27;openid&#x27; scope is required.</value>
        [DataMember(Name = "scope", IsRequired = true, EmitDefaultValue = false)]

        public string Scope { get; set; }


        /// <summary>
        /// The value used to maintain state between the authentication request and client.
        /// </summary>
        /// <value>The value used to maintain state between the authentication request and client.</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]

        public string State { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OidcProviderAuthorize2Request {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  CodeChallenge: ").Append(CodeChallenge).Append("\n");
            sb.Append("  CodeChallengeMethod: ").Append(CodeChallengeMethod).Append("\n");
            sb.Append("  MaxAge: ").Append(MaxAge).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  RedirectUri: ").Append(RedirectUri).Append("\n");
            sb.Append("  ResponseType: ").Append(ResponseType).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as OidcProviderAuthorize2Request);
        }

        /// <summary>
        /// Returns true if OidcProviderAuthorize2Request instances are equal
        /// </summary>
        /// <param name="input">Instance of OidcProviderAuthorize2Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OidcProviderAuthorize2Request input)
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
                    this.CodeChallenge == input.CodeChallenge ||
                    (this.CodeChallenge != null &&
                    this.CodeChallenge.Equals(input.CodeChallenge))

                ) &&
                (
                    this.CodeChallengeMethod == input.CodeChallengeMethod ||
                    (this.CodeChallengeMethod != null &&
                    this.CodeChallengeMethod.Equals(input.CodeChallengeMethod))

                ) &&
                (
                    this.MaxAge == input.MaxAge ||

                    this.MaxAge.Equals(input.MaxAge)
                ) &&
                (
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))

                ) &&
                (
                    this.RedirectUri == input.RedirectUri ||
                    (this.RedirectUri != null &&
                    this.RedirectUri.Equals(input.RedirectUri))

                ) &&
                (
                    this.ResponseType == input.ResponseType ||
                    (this.ResponseType != null &&
                    this.ResponseType.Equals(input.ResponseType))

                ) &&
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))

                ) &&
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))

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

                if (this.CodeChallenge != null)
                {
                    hashCode = (hashCode * 59) + this.CodeChallenge.GetHashCode();
                }

                if (this.CodeChallengeMethod != null)
                {
                    hashCode = (hashCode * 59) + this.CodeChallengeMethod.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.MaxAge.GetHashCode();
                if (this.Nonce != null)
                {
                    hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                }

                if (this.RedirectUri != null)
                {
                    hashCode = (hashCode * 59) + this.RedirectUri.GetHashCode();
                }

                if (this.ResponseType != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseType.GetHashCode();
                }

                if (this.Scope != null)
                {
                    hashCode = (hashCode * 59) + this.Scope.GetHashCode();
                }

                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
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
