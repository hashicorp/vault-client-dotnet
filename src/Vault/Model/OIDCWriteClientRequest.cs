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
    /// OIDCWriteClientRequest
    /// </summary>
    [DataContract(Name = "OIDCWriteClientRequest")]
    public partial class OIDCWriteClientRequest : IEquatable<OIDCWriteClientRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OIDCWriteClientRequest" /> class.
        /// </summary>
        /// <param name="accessTokenTtl">The time-to-live for access tokens obtained by the client..</param>
        /// <param name="assignments">Comma separated string or array of assignment resources..</param>
        /// <param name="clientType">The client type based on its ability to maintain confidentiality of credentials. The following client types are supported: &#39;confidential&#39;, &#39;public&#39;. Defaults to &#39;confidential&#39;. (default to &quot;confidential&quot;).</param>
        /// <param name="idTokenTtl">The time-to-live for ID tokens obtained by the client..</param>
        /// <param name="key">A reference to a named key resource. Cannot be modified after creation. Defaults to the &#39;default&#39; key. (default to &quot;default&quot;).</param>
        /// <param name="redirectUris">Comma separated string or array of redirect URIs used by the client. One of these values must exactly match the redirect_uri parameter value used in each authentication request..</param>
        public OIDCWriteClientRequest(int accessTokenTtl = default(int), List<string> assignments = default(List<string>), string clientType = "confidential", int idTokenTtl = default(int), string key = "default", List<string> redirectUris = default(List<string>))
        {
            this.AccessTokenTtl = accessTokenTtl;
            this.Assignments = assignments;
            // use default value if no "clientType" provided
            this.ClientType = clientType ?? "confidential";
            this.IdTokenTtl = idTokenTtl;
            // use default value if no "key" provided
            this.Key = key ?? "default";
            this.RedirectUris = redirectUris;
        }

        /// <summary>
        /// The time-to-live for access tokens obtained by the client.
        /// </summary>
        /// <value>The time-to-live for access tokens obtained by the client.</value>
        [DataMember(Name = "access_token_ttl", EmitDefaultValue = false)]
        public int AccessTokenTtl { get; set; }

        /// <summary>
        /// Comma separated string or array of assignment resources.
        /// </summary>
        /// <value>Comma separated string or array of assignment resources.</value>
        [DataMember(Name = "assignments", EmitDefaultValue = false)]
        public List<string> Assignments { get; set; }

        /// <summary>
        /// The client type based on its ability to maintain confidentiality of credentials. The following client types are supported: &#39;confidential&#39;, &#39;public&#39;. Defaults to &#39;confidential&#39;.
        /// </summary>
        /// <value>The client type based on its ability to maintain confidentiality of credentials. The following client types are supported: &#39;confidential&#39;, &#39;public&#39;. Defaults to &#39;confidential&#39;.</value>
        [DataMember(Name = "client_type", EmitDefaultValue = false)]
        public string ClientType { get; set; }

        /// <summary>
        /// The time-to-live for ID tokens obtained by the client.
        /// </summary>
        /// <value>The time-to-live for ID tokens obtained by the client.</value>
        [DataMember(Name = "id_token_ttl", EmitDefaultValue = false)]
        public int IdTokenTtl { get; set; }

        /// <summary>
        /// A reference to a named key resource. Cannot be modified after creation. Defaults to the &#39;default&#39; key.
        /// </summary>
        /// <value>A reference to a named key resource. Cannot be modified after creation. Defaults to the &#39;default&#39; key.</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Comma separated string or array of redirect URIs used by the client. One of these values must exactly match the redirect_uri parameter value used in each authentication request.
        /// </summary>
        /// <value>Comma separated string or array of redirect URIs used by the client. One of these values must exactly match the redirect_uri parameter value used in each authentication request.</value>
        [DataMember(Name = "redirect_uris", EmitDefaultValue = false)]
        public List<string> RedirectUris { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OIDCWriteClientRequest {\n");
            sb.Append("  AccessTokenTtl: ").Append(AccessTokenTtl).Append("\n");
            sb.Append("  Assignments: ").Append(Assignments).Append("\n");
            sb.Append("  ClientType: ").Append(ClientType).Append("\n");
            sb.Append("  IdTokenTtl: ").Append(IdTokenTtl).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  RedirectUris: ").Append(RedirectUris).Append("\n");
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
            return this.Equals(input as OIDCWriteClientRequest);
        }

        /// <summary>
        /// Returns true if OIDCWriteClientRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OIDCWriteClientRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OIDCWriteClientRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccessTokenTtl == input.AccessTokenTtl ||
                    this.AccessTokenTtl.Equals(input.AccessTokenTtl)
                ) && 
                (
                    this.Assignments == input.Assignments ||
                    this.Assignments != null &&
                    input.Assignments != null &&
                    this.Assignments.SequenceEqual(input.Assignments)
                ) && 
                (
                    this.ClientType == input.ClientType ||
                    (this.ClientType != null &&
                    this.ClientType.Equals(input.ClientType))
                ) && 
                (
                    this.IdTokenTtl == input.IdTokenTtl ||
                    this.IdTokenTtl.Equals(input.IdTokenTtl)
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.RedirectUris == input.RedirectUris ||
                    this.RedirectUris != null &&
                    input.RedirectUris != null &&
                    this.RedirectUris.SequenceEqual(input.RedirectUris)
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
                hashCode = (hashCode * 59) + this.AccessTokenTtl.GetHashCode();
                if (this.Assignments != null)
                {
                    hashCode = (hashCode * 59) + this.Assignments.GetHashCode();
                }
                if (this.ClientType != null)
                {
                    hashCode = (hashCode * 59) + this.ClientType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IdTokenTtl.GetHashCode();
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                if (this.RedirectUris != null)
                {
                    hashCode = (hashCode * 59) + this.RedirectUris.GetHashCode();
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
