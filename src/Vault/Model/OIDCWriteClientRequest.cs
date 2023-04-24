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
    /// OidcWriteClientRequest
    /// </summary>
    [DataContract(Name = "OidcWriteClientRequest")]
    public partial class OidcWriteClientRequest : IEquatable<OidcWriteClientRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="OidcWriteClientRequest" /> class.
        /// </summary>

        /// <param name="AccessTokenTtl">The time-to-live for access tokens obtained by the client..</param>

        /// <param name="Assignments">Comma separated string or array of assignment resources..</param>

        /// <param name="ClientType">The client type based on its ability to maintain confidentiality of credentials. The following client types are supported: &#x27;confidential&#x27;, &#x27;public&#x27;. Defaults to &#x27;confidential&#x27;. (default to &quot;confidential&quot;).</param>

        /// <param name="IdTokenTtl">The time-to-live for ID tokens obtained by the client..</param>

        /// <param name="Key">A reference to a named key resource. Cannot be modified after creation. Defaults to the &#x27;default&#x27; key. (default to &quot;default&quot;).</param>

        /// <param name="RedirectUris">Comma separated string or array of redirect URIs used by the client. One of these values must exactly match the redirect_uri parameter value used in each authentication request..</param>


        public OidcWriteClientRequest(int AccessTokenTtl = default(int), List<string> Assignments = default(List<string>), string ClientType = "confidential", int IdTokenTtl = default(int), string Key = "default", List<string> RedirectUris = default(List<string>))
        {

            this.AccessTokenTtl = AccessTokenTtl;

            this.Assignments = Assignments;

            // use default value if no "ClientType" provided
            this.ClientType = ClientType ?? "confidential";


            this.IdTokenTtl = IdTokenTtl;

            // use default value if no "Key" provided
            this.Key = Key ?? "default";


            this.RedirectUris = RedirectUris;

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
        /// The client type based on its ability to maintain confidentiality of credentials. The following client types are supported: &#x27;confidential&#x27;, &#x27;public&#x27;. Defaults to &#x27;confidential&#x27;.
        /// </summary>
        /// <value>The client type based on its ability to maintain confidentiality of credentials. The following client types are supported: &#x27;confidential&#x27;, &#x27;public&#x27;. Defaults to &#x27;confidential&#x27;.</value>
        [DataMember(Name = "client_type", EmitDefaultValue = false)]

        public string ClientType { get; set; }


        /// <summary>
        /// The time-to-live for ID tokens obtained by the client.
        /// </summary>
        /// <value>The time-to-live for ID tokens obtained by the client.</value>
        [DataMember(Name = "id_token_ttl", EmitDefaultValue = false)]

        public int IdTokenTtl { get; set; }


        /// <summary>
        /// A reference to a named key resource. Cannot be modified after creation. Defaults to the &#x27;default&#x27; key.
        /// </summary>
        /// <value>A reference to a named key resource. Cannot be modified after creation. Defaults to the &#x27;default&#x27; key.</value>
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
            sb.Append("class OidcWriteClientRequest {\n");
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
            return this.Equals(input as OidcWriteClientRequest);
        }

        /// <summary>
        /// Returns true if OidcWriteClientRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OidcWriteClientRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OidcWriteClientRequest input)
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
