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
    /// CentrifyWriteConfigRequest
    /// </summary>
    [DataContract(Name = "CentrifyWriteConfigRequest")]

    public partial class CentrifyWriteConfigRequest : IEquatable<CentrifyWriteConfigRequest>, IValidatableObject
    {



























        /// <summary>
        /// Initializes a new instance of the <see cref="CentrifyWriteConfigRequest" /> class.
        /// </summary>

        /// <param name="AppId">OAuth2 App ID (default to &quot;vault_io_integration&quot;).</param>

        /// <param name="ClientId">OAuth2 Client ID.</param>

        /// <param name="ClientSecret">OAuth2 Client Secret.</param>

        /// <param name="Policies">Use \&quot;token_policies\&quot; instead. If this and \&quot;token_policies\&quot; are both specified, only \&quot;token_policies\&quot; will be used..</param>

        /// <param name="Scope">OAuth2 App Scope (default to &quot;vault_io_integration&quot;).</param>

        /// <param name="ServiceUrl">Service URL (https://&lt;tenant&gt;.my.centrify.com).</param>

        /// <param name="TokenBoundCidrs">Comma separated string or JSON list of CIDR blocks. If set, specifies the blocks of IP addresses which are allowed to use the generated token..</param>

        /// <param name="TokenNoDefaultPolicy">If true, the &#x27;default&#x27; policy will not automatically be added to generated tokens.</param>

        /// <param name="TokenNumUses">The maximum number of times a token may be used, a value of zero means unlimited.</param>

        /// <param name="TokenPolicies">Comma-separated list of policies.</param>

        /// <param name="TokenTtl">The initial ttl of the token to generate.</param>

        /// <param name="TokenType">The type of token to generate, service or batch (default to &quot;default-service&quot;).</param>


        public CentrifyWriteConfigRequest(string AppId = "vault_io_integration", string ClientId = default(string), string ClientSecret = default(string), List<string> Policies = default(List<string>), string Scope = "vault_io_integration", string ServiceUrl = default(string), List<string> TokenBoundCidrs = default(List<string>), bool TokenNoDefaultPolicy = default(bool), int TokenNumUses = default(int), List<string> TokenPolicies = default(List<string>), int TokenTtl = default(int), string TokenType = "default-service")
        {

            // use default value if no "AppId" provided
            this.AppId = AppId ?? "vault_io_integration";


            this.ClientId = ClientId;

            this.ClientSecret = ClientSecret;

            this.Policies = Policies;

            // use default value if no "Scope" provided
            this.Scope = Scope ?? "vault_io_integration";


            this.ServiceUrl = ServiceUrl;

            this.TokenBoundCidrs = TokenBoundCidrs;

            this.TokenNoDefaultPolicy = TokenNoDefaultPolicy;

            this.TokenNumUses = TokenNumUses;

            this.TokenPolicies = TokenPolicies;

            this.TokenTtl = TokenTtl;

            // use default value if no "TokenType" provided
            this.TokenType = TokenType ?? "default-service";


        }

        /// <summary>
        /// OAuth2 App ID
        /// </summary>
        /// <value>OAuth2 App ID</value>
        [DataMember(Name = "app_id", EmitDefaultValue = false)]


        public string AppId { get; set; }


        /// <summary>
        /// OAuth2 Client ID
        /// </summary>
        /// <value>OAuth2 Client ID</value>
        [DataMember(Name = "client_id", EmitDefaultValue = false)]


        public string ClientId { get; set; }


        /// <summary>
        /// OAuth2 Client Secret
        /// </summary>
        /// <value>OAuth2 Client Secret</value>
        [DataMember(Name = "client_secret", EmitDefaultValue = false)]


        public string ClientSecret { get; set; }


        /// <summary>
        /// Use \&quot;token_policies\&quot; instead. If this and \&quot;token_policies\&quot; are both specified, only \&quot;token_policies\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_policies\&quot; instead. If this and \&quot;token_policies\&quot; are both specified, only \&quot;token_policies\&quot; will be used.</value>
        [DataMember(Name = "policies", EmitDefaultValue = false)]

        [Obsolete]
        public List<string> Policies { get; set; }


        /// <summary>
        /// OAuth2 App Scope
        /// </summary>
        /// <value>OAuth2 App Scope</value>
        [DataMember(Name = "scope", EmitDefaultValue = false)]


        public string Scope { get; set; }


        /// <summary>
        /// Service URL (https://&lt;tenant&gt;.my.centrify.com)
        /// </summary>
        /// <value>Service URL (https://&lt;tenant&gt;.my.centrify.com)</value>
        [DataMember(Name = "service_url", EmitDefaultValue = false)]


        public string ServiceUrl { get; set; }


        /// <summary>
        /// Comma separated string or JSON list of CIDR blocks. If set, specifies the blocks of IP addresses which are allowed to use the generated token.
        /// </summary>
        /// <value>Comma separated string or JSON list of CIDR blocks. If set, specifies the blocks of IP addresses which are allowed to use the generated token.</value>
        [DataMember(Name = "token_bound_cidrs", EmitDefaultValue = false)]


        public List<string> TokenBoundCidrs { get; set; }


        /// <summary>
        /// If true, the &#x27;default&#x27; policy will not automatically be added to generated tokens
        /// </summary>
        /// <value>If true, the &#x27;default&#x27; policy will not automatically be added to generated tokens</value>
        [DataMember(Name = "token_no_default_policy", EmitDefaultValue = true)]


        public bool TokenNoDefaultPolicy { get; set; }


        /// <summary>
        /// The maximum number of times a token may be used, a value of zero means unlimited
        /// </summary>
        /// <value>The maximum number of times a token may be used, a value of zero means unlimited</value>
        [DataMember(Name = "token_num_uses", EmitDefaultValue = false)]


        public int TokenNumUses { get; set; }


        /// <summary>
        /// Comma-separated list of policies
        /// </summary>
        /// <value>Comma-separated list of policies</value>
        [DataMember(Name = "token_policies", EmitDefaultValue = false)]


        public List<string> TokenPolicies { get; set; }


        /// <summary>
        /// The initial ttl of the token to generate
        /// </summary>
        /// <value>The initial ttl of the token to generate</value>
        [DataMember(Name = "token_ttl", EmitDefaultValue = false)]


        public int TokenTtl { get; set; }


        /// <summary>
        /// The type of token to generate, service or batch
        /// </summary>
        /// <value>The type of token to generate, service or batch</value>
        [DataMember(Name = "token_type", EmitDefaultValue = false)]


        public string TokenType { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CentrifyWriteConfigRequest {\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ServiceUrl: ").Append(ServiceUrl).Append("\n");
            sb.Append("  TokenBoundCidrs: ").Append(TokenBoundCidrs).Append("\n");
            sb.Append("  TokenNoDefaultPolicy: ").Append(TokenNoDefaultPolicy).Append("\n");
            sb.Append("  TokenNumUses: ").Append(TokenNumUses).Append("\n");
            sb.Append("  TokenPolicies: ").Append(TokenPolicies).Append("\n");
            sb.Append("  TokenTtl: ").Append(TokenTtl).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
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
            return this.Equals(input as CentrifyWriteConfigRequest);
        }

        /// <summary>
        /// Returns true if CentrifyWriteConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CentrifyWriteConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CentrifyWriteConfigRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))

                ) &&
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
                    this.Policies == input.Policies ||
                    this.Policies != null &&
                    input.Policies != null &&
                    this.Policies.SequenceEqual(input.Policies)
                ) &&
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))

                ) &&
                (
                    this.ServiceUrl == input.ServiceUrl ||
                    (this.ServiceUrl != null &&
                    this.ServiceUrl.Equals(input.ServiceUrl))

                ) &&
                (
                    this.TokenBoundCidrs == input.TokenBoundCidrs ||
                    this.TokenBoundCidrs != null &&
                    input.TokenBoundCidrs != null &&
                    this.TokenBoundCidrs.SequenceEqual(input.TokenBoundCidrs)
                ) &&
                (
                    this.TokenNoDefaultPolicy == input.TokenNoDefaultPolicy ||

                    this.TokenNoDefaultPolicy.Equals(input.TokenNoDefaultPolicy)
                ) &&
                (
                    this.TokenNumUses == input.TokenNumUses ||

                    this.TokenNumUses.Equals(input.TokenNumUses)
                ) &&
                (
                    this.TokenPolicies == input.TokenPolicies ||
                    this.TokenPolicies != null &&
                    input.TokenPolicies != null &&
                    this.TokenPolicies.SequenceEqual(input.TokenPolicies)
                ) &&
                (
                    this.TokenTtl == input.TokenTtl ||

                    this.TokenTtl.Equals(input.TokenTtl)
                ) &&
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))

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

                if (this.AppId != null)
                {
                    hashCode = (hashCode * 59) + this.AppId.GetHashCode();
                }

                if (this.ClientId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientId.GetHashCode();
                }

                if (this.ClientSecret != null)
                {
                    hashCode = (hashCode * 59) + this.ClientSecret.GetHashCode();
                }

                if (this.Policies != null)
                {
                    hashCode = (hashCode * 59) + this.Policies.GetHashCode();
                }

                if (this.Scope != null)
                {
                    hashCode = (hashCode * 59) + this.Scope.GetHashCode();
                }

                if (this.ServiceUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceUrl.GetHashCode();
                }

                if (this.TokenBoundCidrs != null)
                {
                    hashCode = (hashCode * 59) + this.TokenBoundCidrs.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.TokenNoDefaultPolicy.GetHashCode();

                hashCode = (hashCode * 59) + this.TokenNumUses.GetHashCode();
                if (this.TokenPolicies != null)
                {
                    hashCode = (hashCode * 59) + this.TokenPolicies.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.TokenTtl.GetHashCode();
                if (this.TokenType != null)
                {
                    hashCode = (hashCode * 59) + this.TokenType.GetHashCode();
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
