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
    /// AppRoleReadRoleResponse
    /// </summary>
    [DataContract(Name = "AppRoleReadRoleResponse")]

    public partial class AppRoleReadRoleResponse : IEquatable<AppRoleReadRoleResponse>, IValidatableObject
    {



































        /// <summary>
        /// Initializes a new instance of the <see cref="AppRoleReadRoleResponse" /> class.
        /// </summary>

        /// <param name="BindSecretId">Impose secret ID to be presented when logging in using this role..</param>

        /// <param name="LocalSecretIds">If true, the secret identifiers generated using this role will be cluster local. This can only be set during role creation and once set, it can&#x27;t be reset later.</param>

        /// <param name="Period">Use \&quot;token_period\&quot; instead. If this and \&quot;token_period\&quot; are both specified, only \&quot;token_period\&quot; will be used..</param>

        /// <param name="Policies">Use \&quot;token_policies\&quot; instead. If this and \&quot;token_policies\&quot; are both specified, only \&quot;token_policies\&quot; will be used..</param>

        /// <param name="SecretIdBoundCidrs">Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can perform the login operation..</param>

        /// <param name="SecretIdNumUses">Number of times a secret ID can access the role, after which the secret ID will expire..</param>

        /// <param name="SecretIdTtl">Duration in seconds after which the issued secret ID expires..</param>

        /// <param name="TokenBoundCidrs">Comma separated string or JSON list of CIDR blocks. If set, specifies the blocks of IP addresses which are allowed to use the generated token..</param>

        /// <param name="TokenExplicitMaxTtl">If set, tokens created via this role carry an explicit maximum TTL. During renewal, the current maximum TTL values of the role and the mount are not checked for changes, and any updates to these values will have no effect on the token being renewed..</param>

        /// <param name="TokenMaxTtl">The maximum lifetime of the generated token.</param>

        /// <param name="TokenNoDefaultPolicy">If true, the &#x27;default&#x27; policy will not automatically be added to generated tokens.</param>

        /// <param name="TokenNumUses">The maximum number of times a token may be used, a value of zero means unlimited.</param>

        /// <param name="TokenPeriod">If set, tokens created via this role will have no max lifetime; instead, their renewal period will be fixed to this value..</param>

        /// <param name="TokenPolicies">Comma-separated list of policies.</param>

        /// <param name="TokenTtl">The initial ttl of the token to generate.</param>

        /// <param name="TokenType">The type of token to generate, service or batch (default to &quot;default-service&quot;).</param>


        public AppRoleReadRoleResponse(bool BindSecretId = default(bool), bool LocalSecretIds = default(bool), int Period = default(int), List<string> Policies = default(List<string>), List<string> SecretIdBoundCidrs = default(List<string>), int SecretIdNumUses = default(int), int SecretIdTtl = default(int), List<string> TokenBoundCidrs = default(List<string>), int TokenExplicitMaxTtl = default(int), int TokenMaxTtl = default(int), bool TokenNoDefaultPolicy = default(bool), int TokenNumUses = default(int), int TokenPeriod = default(int), List<string> TokenPolicies = default(List<string>), int TokenTtl = default(int), string TokenType = "default-service")
        {

            this.BindSecretId = BindSecretId;

            this.LocalSecretIds = LocalSecretIds;

            this.Period = Period;

            this.Policies = Policies;

            this.SecretIdBoundCidrs = SecretIdBoundCidrs;

            this.SecretIdNumUses = SecretIdNumUses;

            this.SecretIdTtl = SecretIdTtl;

            this.TokenBoundCidrs = TokenBoundCidrs;

            this.TokenExplicitMaxTtl = TokenExplicitMaxTtl;

            this.TokenMaxTtl = TokenMaxTtl;

            this.TokenNoDefaultPolicy = TokenNoDefaultPolicy;

            this.TokenNumUses = TokenNumUses;

            this.TokenPeriod = TokenPeriod;

            this.TokenPolicies = TokenPolicies;

            this.TokenTtl = TokenTtl;

            // use default value if no "TokenType" provided
            this.TokenType = TokenType ?? "default-service";


        }

        /// <summary>
        /// Impose secret ID to be presented when logging in using this role.
        /// </summary>
        /// <value>Impose secret ID to be presented when logging in using this role.</value>
        [DataMember(Name = "bind_secret_id", EmitDefaultValue = true)]


        public bool BindSecretId { get; set; }


        /// <summary>
        /// If true, the secret identifiers generated using this role will be cluster local. This can only be set during role creation and once set, it can&#x27;t be reset later
        /// </summary>
        /// <value>If true, the secret identifiers generated using this role will be cluster local. This can only be set during role creation and once set, it can&#x27;t be reset later</value>
        [DataMember(Name = "local_secret_ids", EmitDefaultValue = true)]


        public bool LocalSecretIds { get; set; }


        /// <summary>
        /// Use \&quot;token_period\&quot; instead. If this and \&quot;token_period\&quot; are both specified, only \&quot;token_period\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_period\&quot; instead. If this and \&quot;token_period\&quot; are both specified, only \&quot;token_period\&quot; will be used.</value>
        [DataMember(Name = "period", EmitDefaultValue = false)]

        [Obsolete]
        public int Period { get; set; }


        /// <summary>
        /// Use \&quot;token_policies\&quot; instead. If this and \&quot;token_policies\&quot; are both specified, only \&quot;token_policies\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_policies\&quot; instead. If this and \&quot;token_policies\&quot; are both specified, only \&quot;token_policies\&quot; will be used.</value>
        [DataMember(Name = "policies", EmitDefaultValue = false)]

        [Obsolete]
        public List<string> Policies { get; set; }


        /// <summary>
        /// Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can perform the login operation.
        /// </summary>
        /// <value>Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can perform the login operation.</value>
        [DataMember(Name = "secret_id_bound_cidrs", EmitDefaultValue = false)]


        public List<string> SecretIdBoundCidrs { get; set; }


        /// <summary>
        /// Number of times a secret ID can access the role, after which the secret ID will expire.
        /// </summary>
        /// <value>Number of times a secret ID can access the role, after which the secret ID will expire.</value>
        [DataMember(Name = "secret_id_num_uses", EmitDefaultValue = false)]


        public int SecretIdNumUses { get; set; }


        /// <summary>
        /// Duration in seconds after which the issued secret ID expires.
        /// </summary>
        /// <value>Duration in seconds after which the issued secret ID expires.</value>
        [DataMember(Name = "secret_id_ttl", EmitDefaultValue = false)]


        public int SecretIdTtl { get; set; }


        /// <summary>
        /// Comma separated string or JSON list of CIDR blocks. If set, specifies the blocks of IP addresses which are allowed to use the generated token.
        /// </summary>
        /// <value>Comma separated string or JSON list of CIDR blocks. If set, specifies the blocks of IP addresses which are allowed to use the generated token.</value>
        [DataMember(Name = "token_bound_cidrs", EmitDefaultValue = false)]


        public List<string> TokenBoundCidrs { get; set; }


        /// <summary>
        /// If set, tokens created via this role carry an explicit maximum TTL. During renewal, the current maximum TTL values of the role and the mount are not checked for changes, and any updates to these values will have no effect on the token being renewed.
        /// </summary>
        /// <value>If set, tokens created via this role carry an explicit maximum TTL. During renewal, the current maximum TTL values of the role and the mount are not checked for changes, and any updates to these values will have no effect on the token being renewed.</value>
        [DataMember(Name = "token_explicit_max_ttl", EmitDefaultValue = false)]


        public int TokenExplicitMaxTtl { get; set; }


        /// <summary>
        /// The maximum lifetime of the generated token
        /// </summary>
        /// <value>The maximum lifetime of the generated token</value>
        [DataMember(Name = "token_max_ttl", EmitDefaultValue = false)]


        public int TokenMaxTtl { get; set; }


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
        /// If set, tokens created via this role will have no max lifetime; instead, their renewal period will be fixed to this value.
        /// </summary>
        /// <value>If set, tokens created via this role will have no max lifetime; instead, their renewal period will be fixed to this value.</value>
        [DataMember(Name = "token_period", EmitDefaultValue = false)]


        public int TokenPeriod { get; set; }


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
            sb.Append("class AppRoleReadRoleResponse {\n");
            sb.Append("  BindSecretId: ").Append(BindSecretId).Append("\n");
            sb.Append("  LocalSecretIds: ").Append(LocalSecretIds).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
            sb.Append("  SecretIdBoundCidrs: ").Append(SecretIdBoundCidrs).Append("\n");
            sb.Append("  SecretIdNumUses: ").Append(SecretIdNumUses).Append("\n");
            sb.Append("  SecretIdTtl: ").Append(SecretIdTtl).Append("\n");
            sb.Append("  TokenBoundCidrs: ").Append(TokenBoundCidrs).Append("\n");
            sb.Append("  TokenExplicitMaxTtl: ").Append(TokenExplicitMaxTtl).Append("\n");
            sb.Append("  TokenMaxTtl: ").Append(TokenMaxTtl).Append("\n");
            sb.Append("  TokenNoDefaultPolicy: ").Append(TokenNoDefaultPolicy).Append("\n");
            sb.Append("  TokenNumUses: ").Append(TokenNumUses).Append("\n");
            sb.Append("  TokenPeriod: ").Append(TokenPeriod).Append("\n");
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
            return this.Equals(input as AppRoleReadRoleResponse);
        }

        /// <summary>
        /// Returns true if AppRoleReadRoleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AppRoleReadRoleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppRoleReadRoleResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.BindSecretId == input.BindSecretId ||

                    this.BindSecretId.Equals(input.BindSecretId)
                ) &&
                (
                    this.LocalSecretIds == input.LocalSecretIds ||

                    this.LocalSecretIds.Equals(input.LocalSecretIds)
                ) &&
                (
                    this.Period == input.Period ||

                    this.Period.Equals(input.Period)
                ) &&
                (
                    this.Policies == input.Policies ||
                    this.Policies != null &&
                    input.Policies != null &&
                    this.Policies.SequenceEqual(input.Policies)
                ) &&
                (
                    this.SecretIdBoundCidrs == input.SecretIdBoundCidrs ||
                    this.SecretIdBoundCidrs != null &&
                    input.SecretIdBoundCidrs != null &&
                    this.SecretIdBoundCidrs.SequenceEqual(input.SecretIdBoundCidrs)
                ) &&
                (
                    this.SecretIdNumUses == input.SecretIdNumUses ||

                    this.SecretIdNumUses.Equals(input.SecretIdNumUses)
                ) &&
                (
                    this.SecretIdTtl == input.SecretIdTtl ||

                    this.SecretIdTtl.Equals(input.SecretIdTtl)
                ) &&
                (
                    this.TokenBoundCidrs == input.TokenBoundCidrs ||
                    this.TokenBoundCidrs != null &&
                    input.TokenBoundCidrs != null &&
                    this.TokenBoundCidrs.SequenceEqual(input.TokenBoundCidrs)
                ) &&
                (
                    this.TokenExplicitMaxTtl == input.TokenExplicitMaxTtl ||

                    this.TokenExplicitMaxTtl.Equals(input.TokenExplicitMaxTtl)
                ) &&
                (
                    this.TokenMaxTtl == input.TokenMaxTtl ||

                    this.TokenMaxTtl.Equals(input.TokenMaxTtl)
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
                    this.TokenPeriod == input.TokenPeriod ||

                    this.TokenPeriod.Equals(input.TokenPeriod)
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


                hashCode = (hashCode * 59) + this.BindSecretId.GetHashCode();

                hashCode = (hashCode * 59) + this.LocalSecretIds.GetHashCode();

                hashCode = (hashCode * 59) + this.Period.GetHashCode();
                if (this.Policies != null)
                {
                    hashCode = (hashCode * 59) + this.Policies.GetHashCode();
                }

                if (this.SecretIdBoundCidrs != null)
                {
                    hashCode = (hashCode * 59) + this.SecretIdBoundCidrs.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.SecretIdNumUses.GetHashCode();

                hashCode = (hashCode * 59) + this.SecretIdTtl.GetHashCode();
                if (this.TokenBoundCidrs != null)
                {
                    hashCode = (hashCode * 59) + this.TokenBoundCidrs.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.TokenExplicitMaxTtl.GetHashCode();

                hashCode = (hashCode * 59) + this.TokenMaxTtl.GetHashCode();

                hashCode = (hashCode * 59) + this.TokenNoDefaultPolicy.GetHashCode();

                hashCode = (hashCode * 59) + this.TokenNumUses.GetHashCode();

                hashCode = (hashCode * 59) + this.TokenPeriod.GetHashCode();
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
