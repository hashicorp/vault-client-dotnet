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
    /// TokenWriteRoleRequest
    /// </summary>
    [DataContract(Name = "TokenWriteRoleRequest")]
    public partial class TokenWriteRoleRequest : IEquatable<TokenWriteRoleRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="TokenWriteRoleRequest" /> class.
        /// </summary>

        /// <param name="AllowedEntityAliases">String or JSON list of allowed entity aliases. If set, specifies the entity aliases which are allowed to be used during token generation. This field supports globbing..</param>

        /// <param name="AllowedPolicies">If set, tokens can be created with any subset of the policies in this list, rather than the normal semantics of tokens being a subset of the calling token&#x27;s policies. The parameter is a comma-delimited string of policy names..</param>

        /// <param name="AllowedPoliciesGlob">If set, tokens can be created with any subset of glob matched policies in this list, rather than the normal semantics of tokens being a subset of the calling token&#x27;s policies. The parameter is a comma-delimited string of policy name globs..</param>

        /// <param name="BoundCidrs">Use &#x27;token_bound_cidrs&#x27; instead..</param>

        /// <param name="DisallowedPolicies">If set, successful token creation via this role will require that no policies in the given list are requested. The parameter is a comma-delimited string of policy names..</param>

        /// <param name="DisallowedPoliciesGlob">If set, successful token creation via this role will require that no requested policies glob match any of policies in this list. The parameter is a comma-delimited string of policy name globs..</param>

        /// <param name="ExplicitMaxTtl">Use &#x27;token_explicit_max_ttl&#x27; instead..</param>

        /// <param name="Orphan">If true, tokens created via this role will be orphan tokens (have no parent).</param>

        /// <param name="PathSuffix">If set, tokens created via this role will contain the given suffix as a part of their path. This can be used to assist use of the &#x27;revoke-prefix&#x27; endpoint later on. The given suffix must match the regular expression.\\w[\\w-.]+\\w.</param>

        /// <param name="Period">Use &#x27;token_period&#x27; instead..</param>

        /// <param name="Renewable">Tokens created via this role will be renewable or not according to this value. Defaults to \&quot;true\&quot;. (default to true).</param>

        /// <param name="TokenBoundCidrs">Comma separated string or JSON list of CIDR blocks. If set, specifies the blocks of IP addresses which are allowed to use the generated token..</param>

        /// <param name="TokenExplicitMaxTtl">If set, tokens created via this role carry an explicit maximum TTL. During renewal, the current maximum TTL values of the role and the mount are not checked for changes, and any updates to these values will have no effect on the token being renewed..</param>

        /// <param name="TokenNoDefaultPolicy">If true, the &#x27;default&#x27; policy will not automatically be added to generated tokens.</param>

        /// <param name="TokenNumUses">The maximum number of times a token may be used, a value of zero means unlimited.</param>

        /// <param name="TokenPeriod">If set, tokens created via this role will have no max lifetime; instead, their renewal period will be fixed to this value. This takes an integer number of seconds, or a string duration (e.g. \&quot;24h\&quot;)..</param>

        /// <param name="TokenType">The type of token to generate, service or batch (default to &quot;default-service&quot;).</param>


        public TokenWriteRoleRequest(List<string> AllowedEntityAliases = default(List<string>), List<string> AllowedPolicies = default(List<string>), List<string> AllowedPoliciesGlob = default(List<string>), List<string> BoundCidrs = default(List<string>), List<string> DisallowedPolicies = default(List<string>), List<string> DisallowedPoliciesGlob = default(List<string>), string ExplicitMaxTtl = default(string), bool Orphan = default(bool), string PathSuffix = default(string), string Period = default(string), bool Renewable = true, List<string> TokenBoundCidrs = default(List<string>), string TokenExplicitMaxTtl = default(string), bool TokenNoDefaultPolicy = default(bool), int TokenNumUses = default(int), string TokenPeriod = default(string), string TokenType = "default-service")
        {

            this.AllowedEntityAliases = AllowedEntityAliases;

            this.AllowedPolicies = AllowedPolicies;

            this.AllowedPoliciesGlob = AllowedPoliciesGlob;

            this.BoundCidrs = BoundCidrs;

            this.DisallowedPolicies = DisallowedPolicies;

            this.DisallowedPoliciesGlob = DisallowedPoliciesGlob;

            this.ExplicitMaxTtl = ExplicitMaxTtl;

            this.Orphan = Orphan;

            this.PathSuffix = PathSuffix;

            this.Period = Period;

            this.Renewable = Renewable;

            this.TokenBoundCidrs = TokenBoundCidrs;

            this.TokenExplicitMaxTtl = TokenExplicitMaxTtl;

            this.TokenNoDefaultPolicy = TokenNoDefaultPolicy;

            this.TokenNumUses = TokenNumUses;

            this.TokenPeriod = TokenPeriod;

            // use default value if no "TokenType" provided
            this.TokenType = TokenType ?? "default-service";


        }

        /// <summary>
        /// String or JSON list of allowed entity aliases. If set, specifies the entity aliases which are allowed to be used during token generation. This field supports globbing.
        /// </summary>
        /// <value>String or JSON list of allowed entity aliases. If set, specifies the entity aliases which are allowed to be used during token generation. This field supports globbing.</value>
        [DataMember(Name = "allowed_entity_aliases", EmitDefaultValue = false)]

        public List<string> AllowedEntityAliases { get; set; }


        /// <summary>
        /// If set, tokens can be created with any subset of the policies in this list, rather than the normal semantics of tokens being a subset of the calling token&#x27;s policies. The parameter is a comma-delimited string of policy names.
        /// </summary>
        /// <value>If set, tokens can be created with any subset of the policies in this list, rather than the normal semantics of tokens being a subset of the calling token&#x27;s policies. The parameter is a comma-delimited string of policy names.</value>
        [DataMember(Name = "allowed_policies", EmitDefaultValue = false)]

        public List<string> AllowedPolicies { get; set; }


        /// <summary>
        /// If set, tokens can be created with any subset of glob matched policies in this list, rather than the normal semantics of tokens being a subset of the calling token&#x27;s policies. The parameter is a comma-delimited string of policy name globs.
        /// </summary>
        /// <value>If set, tokens can be created with any subset of glob matched policies in this list, rather than the normal semantics of tokens being a subset of the calling token&#x27;s policies. The parameter is a comma-delimited string of policy name globs.</value>
        [DataMember(Name = "allowed_policies_glob", EmitDefaultValue = false)]

        public List<string> AllowedPoliciesGlob { get; set; }


        /// <summary>
        /// Use &#x27;token_bound_cidrs&#x27; instead.
        /// </summary>
        /// <value>Use &#x27;token_bound_cidrs&#x27; instead.</value>
        [DataMember(Name = "bound_cidrs", EmitDefaultValue = false)]

        [Obsolete] public List<string> BoundCidrs { get; set; }


        /// <summary>
        /// If set, successful token creation via this role will require that no policies in the given list are requested. The parameter is a comma-delimited string of policy names.
        /// </summary>
        /// <value>If set, successful token creation via this role will require that no policies in the given list are requested. The parameter is a comma-delimited string of policy names.</value>
        [DataMember(Name = "disallowed_policies", EmitDefaultValue = false)]

        public List<string> DisallowedPolicies { get; set; }


        /// <summary>
        /// If set, successful token creation via this role will require that no requested policies glob match any of policies in this list. The parameter is a comma-delimited string of policy name globs.
        /// </summary>
        /// <value>If set, successful token creation via this role will require that no requested policies glob match any of policies in this list. The parameter is a comma-delimited string of policy name globs.</value>
        [DataMember(Name = "disallowed_policies_glob", EmitDefaultValue = false)]

        public List<string> DisallowedPoliciesGlob { get; set; }


        /// <summary>
        /// Use &#x27;token_explicit_max_ttl&#x27; instead.
        /// </summary>
        /// <value>Use &#x27;token_explicit_max_ttl&#x27; instead.</value>
        [DataMember(Name = "explicit_max_ttl", EmitDefaultValue = false)]

        [Obsolete] public string ExplicitMaxTtl { get; set; }


        /// <summary>
        /// If true, tokens created via this role will be orphan tokens (have no parent)
        /// </summary>
        /// <value>If true, tokens created via this role will be orphan tokens (have no parent)</value>
        [DataMember(Name = "orphan", EmitDefaultValue = true)]

        public bool Orphan { get; set; }


        /// <summary>
        /// If set, tokens created via this role will contain the given suffix as a part of their path. This can be used to assist use of the &#x27;revoke-prefix&#x27; endpoint later on. The given suffix must match the regular expression.\\w[\\w-.]+\\w
        /// </summary>
        /// <value>If set, tokens created via this role will contain the given suffix as a part of their path. This can be used to assist use of the &#x27;revoke-prefix&#x27; endpoint later on. The given suffix must match the regular expression.\\w[\\w-.]+\\w</value>
        [DataMember(Name = "path_suffix", EmitDefaultValue = false)]

        public string PathSuffix { get; set; }


        /// <summary>
        /// Use &#x27;token_period&#x27; instead.
        /// </summary>
        /// <value>Use &#x27;token_period&#x27; instead.</value>
        [DataMember(Name = "period", EmitDefaultValue = false)]

        [Obsolete] public string Period { get; set; }


        /// <summary>
        /// Tokens created via this role will be renewable or not according to this value. Defaults to \&quot;true\&quot;.
        /// </summary>
        /// <value>Tokens created via this role will be renewable or not according to this value. Defaults to \&quot;true\&quot;.</value>
        [DataMember(Name = "renewable", EmitDefaultValue = true)]

        public bool Renewable { get; set; }


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

        public string TokenExplicitMaxTtl { get; set; }


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
        /// If set, tokens created via this role will have no max lifetime; instead, their renewal period will be fixed to this value. This takes an integer number of seconds, or a string duration (e.g. \&quot;24h\&quot;).
        /// </summary>
        /// <value>If set, tokens created via this role will have no max lifetime; instead, their renewal period will be fixed to this value. This takes an integer number of seconds, or a string duration (e.g. \&quot;24h\&quot;).</value>
        [DataMember(Name = "token_period", EmitDefaultValue = false)]

        public string TokenPeriod { get; set; }


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
            sb.Append("class TokenWriteRoleRequest {\n");
            sb.Append("  AllowedEntityAliases: ").Append(AllowedEntityAliases).Append("\n");
            sb.Append("  AllowedPolicies: ").Append(AllowedPolicies).Append("\n");
            sb.Append("  AllowedPoliciesGlob: ").Append(AllowedPoliciesGlob).Append("\n");
            sb.Append("  BoundCidrs: ").Append(BoundCidrs).Append("\n");
            sb.Append("  DisallowedPolicies: ").Append(DisallowedPolicies).Append("\n");
            sb.Append("  DisallowedPoliciesGlob: ").Append(DisallowedPoliciesGlob).Append("\n");
            sb.Append("  ExplicitMaxTtl: ").Append(ExplicitMaxTtl).Append("\n");
            sb.Append("  Orphan: ").Append(Orphan).Append("\n");
            sb.Append("  PathSuffix: ").Append(PathSuffix).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Renewable: ").Append(Renewable).Append("\n");
            sb.Append("  TokenBoundCidrs: ").Append(TokenBoundCidrs).Append("\n");
            sb.Append("  TokenExplicitMaxTtl: ").Append(TokenExplicitMaxTtl).Append("\n");
            sb.Append("  TokenNoDefaultPolicy: ").Append(TokenNoDefaultPolicy).Append("\n");
            sb.Append("  TokenNumUses: ").Append(TokenNumUses).Append("\n");
            sb.Append("  TokenPeriod: ").Append(TokenPeriod).Append("\n");
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
            return this.Equals(input as TokenWriteRoleRequest);
        }

        /// <summary>
        /// Returns true if TokenWriteRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenWriteRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenWriteRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AllowedEntityAliases == input.AllowedEntityAliases ||
                    this.AllowedEntityAliases != null &&
                    input.AllowedEntityAliases != null &&
                    this.AllowedEntityAliases.SequenceEqual(input.AllowedEntityAliases)
                ) &&
                (
                    this.AllowedPolicies == input.AllowedPolicies ||
                    this.AllowedPolicies != null &&
                    input.AllowedPolicies != null &&
                    this.AllowedPolicies.SequenceEqual(input.AllowedPolicies)
                ) &&
                (
                    this.AllowedPoliciesGlob == input.AllowedPoliciesGlob ||
                    this.AllowedPoliciesGlob != null &&
                    input.AllowedPoliciesGlob != null &&
                    this.AllowedPoliciesGlob.SequenceEqual(input.AllowedPoliciesGlob)
                ) &&
                (
                    this.BoundCidrs == input.BoundCidrs ||
                    this.BoundCidrs != null &&
                    input.BoundCidrs != null &&
                    this.BoundCidrs.SequenceEqual(input.BoundCidrs)
                ) &&
                (
                    this.DisallowedPolicies == input.DisallowedPolicies ||
                    this.DisallowedPolicies != null &&
                    input.DisallowedPolicies != null &&
                    this.DisallowedPolicies.SequenceEqual(input.DisallowedPolicies)
                ) &&
                (
                    this.DisallowedPoliciesGlob == input.DisallowedPoliciesGlob ||
                    this.DisallowedPoliciesGlob != null &&
                    input.DisallowedPoliciesGlob != null &&
                    this.DisallowedPoliciesGlob.SequenceEqual(input.DisallowedPoliciesGlob)
                ) &&
                (
                    this.ExplicitMaxTtl == input.ExplicitMaxTtl ||
                    (this.ExplicitMaxTtl != null &&
                    this.ExplicitMaxTtl.Equals(input.ExplicitMaxTtl))

                ) &&
                (
                    this.Orphan == input.Orphan ||

                    this.Orphan.Equals(input.Orphan)
                ) &&
                (
                    this.PathSuffix == input.PathSuffix ||
                    (this.PathSuffix != null &&
                    this.PathSuffix.Equals(input.PathSuffix))

                ) &&
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))

                ) &&
                (
                    this.Renewable == input.Renewable ||

                    this.Renewable.Equals(input.Renewable)
                ) &&
                (
                    this.TokenBoundCidrs == input.TokenBoundCidrs ||
                    this.TokenBoundCidrs != null &&
                    input.TokenBoundCidrs != null &&
                    this.TokenBoundCidrs.SequenceEqual(input.TokenBoundCidrs)
                ) &&
                (
                    this.TokenExplicitMaxTtl == input.TokenExplicitMaxTtl ||
                    (this.TokenExplicitMaxTtl != null &&
                    this.TokenExplicitMaxTtl.Equals(input.TokenExplicitMaxTtl))

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
                    (this.TokenPeriod != null &&
                    this.TokenPeriod.Equals(input.TokenPeriod))

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

                if (this.AllowedEntityAliases != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedEntityAliases.GetHashCode();
                }

                if (this.AllowedPolicies != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedPolicies.GetHashCode();
                }

                if (this.AllowedPoliciesGlob != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedPoliciesGlob.GetHashCode();
                }

                if (this.BoundCidrs != null)
                {
                    hashCode = (hashCode * 59) + this.BoundCidrs.GetHashCode();
                }

                if (this.DisallowedPolicies != null)
                {
                    hashCode = (hashCode * 59) + this.DisallowedPolicies.GetHashCode();
                }

                if (this.DisallowedPoliciesGlob != null)
                {
                    hashCode = (hashCode * 59) + this.DisallowedPoliciesGlob.GetHashCode();
                }

                if (this.ExplicitMaxTtl != null)
                {
                    hashCode = (hashCode * 59) + this.ExplicitMaxTtl.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Orphan.GetHashCode();
                if (this.PathSuffix != null)
                {
                    hashCode = (hashCode * 59) + this.PathSuffix.GetHashCode();
                }

                if (this.Period != null)
                {
                    hashCode = (hashCode * 59) + this.Period.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Renewable.GetHashCode();
                if (this.TokenBoundCidrs != null)
                {
                    hashCode = (hashCode * 59) + this.TokenBoundCidrs.GetHashCode();
                }

                if (this.TokenExplicitMaxTtl != null)
                {
                    hashCode = (hashCode * 59) + this.TokenExplicitMaxTtl.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.TokenNoDefaultPolicy.GetHashCode();

                hashCode = (hashCode * 59) + this.TokenNumUses.GetHashCode();
                if (this.TokenPeriod != null)
                {
                    hashCode = (hashCode * 59) + this.TokenPeriod.GetHashCode();
                }

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
