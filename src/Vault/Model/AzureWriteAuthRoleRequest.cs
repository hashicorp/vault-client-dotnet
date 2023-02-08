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
    /// AzureWriteAuthRoleRequest
    /// </summary>
    [DataContract(Name = "AzureWriteAuthRoleRequest")]
    public partial class AzureWriteAuthRoleRequest : IEquatable<AzureWriteAuthRoleRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureWriteAuthRoleRequest" /> class.
        /// </summary>
        /// <param name="boundGroupIds">Comma-separated list of group ids that login is restricted to..</param>
        /// <param name="boundLocations">Comma-separated list of locations that login is restricted to..</param>
        /// <param name="boundResourceGroups">Comma-separated list of resource groups that login is restricted to..</param>
        /// <param name="boundScaleSets">Comma-separated list of scale sets that login is restricted to..</param>
        /// <param name="boundServicePrincipalIds">Comma-separated list of service principal ids that login is restricted to..</param>
        /// <param name="boundSubscriptionIds">Comma-separated list of subscription ids that login is restricted to..</param>
        /// <param name="maxTtl">Use \&quot;token_max_ttl\&quot; instead. If this and \&quot;token_max_ttl\&quot; are both specified, only \&quot;token_max_ttl\&quot; will be used..</param>
        /// <param name="numUses">Use \&quot;token_num_uses\&quot; instead. If this and \&quot;token_num_uses\&quot; are both specified, only \&quot;token_num_uses\&quot; will be used..</param>
        /// <param name="period">Use \&quot;token_period\&quot; instead. If this and \&quot;token_period\&quot; are both specified, only \&quot;token_period\&quot; will be used..</param>
        /// <param name="policies">Use \&quot;token_policies\&quot; instead. If this and \&quot;token_policies\&quot; are both specified, only \&quot;token_policies\&quot; will be used..</param>
        /// <param name="tokenBoundCidrs">Comma separated string or JSON list of CIDR blocks. If set, specifies the blocks of IP addresses which are allowed to use the generated token..</param>
        /// <param name="tokenExplicitMaxTtl">If set, tokens created via this role carry an explicit maximum TTL. During renewal, the current maximum TTL values of the role and the mount are not checked for changes, and any updates to these values will have no effect on the token being renewed..</param>
        /// <param name="tokenMaxTtl">The maximum lifetime of the generated token.</param>
        /// <param name="tokenNoDefaultPolicy">If true, the &#39;default&#39; policy will not automatically be added to generated tokens.</param>
        /// <param name="tokenNumUses">The maximum number of times a token may be used, a value of zero means unlimited.</param>
        /// <param name="tokenPeriod">If set, tokens created via this role will have no max lifetime; instead, their renewal period will be fixed to this value. This takes an integer number of seconds, or a string duration (e.g. \&quot;24h\&quot;)..</param>
        /// <param name="tokenPolicies">Comma-separated list of policies.</param>
        /// <param name="tokenTtl">The initial ttl of the token to generate.</param>
        /// <param name="tokenType">The type of token to generate, service or batch (default to &quot;default-service&quot;).</param>
        /// <param name="ttl">Use \&quot;token_ttl\&quot; instead. If this and \&quot;token_ttl\&quot; are both specified, only \&quot;token_ttl\&quot; will be used..</param>
        public AzureWriteAuthRoleRequest(List<string> boundGroupIds = default(List<string>), List<string> boundLocations = default(List<string>), List<string> boundResourceGroups = default(List<string>), List<string> boundScaleSets = default(List<string>), List<string> boundServicePrincipalIds = default(List<string>), List<string> boundSubscriptionIds = default(List<string>), int maxTtl = default(int), int numUses = default(int), int period = default(int), List<string> policies = default(List<string>), List<string> tokenBoundCidrs = default(List<string>), int tokenExplicitMaxTtl = default(int), int tokenMaxTtl = default(int), bool tokenNoDefaultPolicy = default(bool), int tokenNumUses = default(int), int tokenPeriod = default(int), List<string> tokenPolicies = default(List<string>), int tokenTtl = default(int), string tokenType = "default-service", int ttl = default(int))
        {
            this.BoundGroupIds = boundGroupIds;
            this.BoundLocations = boundLocations;
            this.BoundResourceGroups = boundResourceGroups;
            this.BoundScaleSets = boundScaleSets;
            this.BoundServicePrincipalIds = boundServicePrincipalIds;
            this.BoundSubscriptionIds = boundSubscriptionIds;
            this.MaxTtl = maxTtl;
            this.NumUses = numUses;
            this.Period = period;
            this.Policies = policies;
            this.TokenBoundCidrs = tokenBoundCidrs;
            this.TokenExplicitMaxTtl = tokenExplicitMaxTtl;
            this.TokenMaxTtl = tokenMaxTtl;
            this.TokenNoDefaultPolicy = tokenNoDefaultPolicy;
            this.TokenNumUses = tokenNumUses;
            this.TokenPeriod = tokenPeriod;
            this.TokenPolicies = tokenPolicies;
            this.TokenTtl = tokenTtl;
            // use default value if no "tokenType" provided
            this.TokenType = tokenType ?? "default-service";
            this.Ttl = ttl;
        }

        /// <summary>
        /// Comma-separated list of group ids that login is restricted to.
        /// </summary>
        /// <value>Comma-separated list of group ids that login is restricted to.</value>
        [DataMember(Name = "bound_group_ids", EmitDefaultValue = false)]
        public List<string> BoundGroupIds { get; set; }

        /// <summary>
        /// Comma-separated list of locations that login is restricted to.
        /// </summary>
        /// <value>Comma-separated list of locations that login is restricted to.</value>
        [DataMember(Name = "bound_locations", EmitDefaultValue = false)]
        public List<string> BoundLocations { get; set; }

        /// <summary>
        /// Comma-separated list of resource groups that login is restricted to.
        /// </summary>
        /// <value>Comma-separated list of resource groups that login is restricted to.</value>
        [DataMember(Name = "bound_resource_groups", EmitDefaultValue = false)]
        public List<string> BoundResourceGroups { get; set; }

        /// <summary>
        /// Comma-separated list of scale sets that login is restricted to.
        /// </summary>
        /// <value>Comma-separated list of scale sets that login is restricted to.</value>
        [DataMember(Name = "bound_scale_sets", EmitDefaultValue = false)]
        public List<string> BoundScaleSets { get; set; }

        /// <summary>
        /// Comma-separated list of service principal ids that login is restricted to.
        /// </summary>
        /// <value>Comma-separated list of service principal ids that login is restricted to.</value>
        [DataMember(Name = "bound_service_principal_ids", EmitDefaultValue = false)]
        public List<string> BoundServicePrincipalIds { get; set; }

        /// <summary>
        /// Comma-separated list of subscription ids that login is restricted to.
        /// </summary>
        /// <value>Comma-separated list of subscription ids that login is restricted to.</value>
        [DataMember(Name = "bound_subscription_ids", EmitDefaultValue = false)]
        public List<string> BoundSubscriptionIds { get; set; }

        /// <summary>
        /// Use \&quot;token_max_ttl\&quot; instead. If this and \&quot;token_max_ttl\&quot; are both specified, only \&quot;token_max_ttl\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_max_ttl\&quot; instead. If this and \&quot;token_max_ttl\&quot; are both specified, only \&quot;token_max_ttl\&quot; will be used.</value>
        [DataMember(Name = "max_ttl", EmitDefaultValue = false)]
        [Obsolete]
        public int MaxTtl { get; set; }

        /// <summary>
        /// Use \&quot;token_num_uses\&quot; instead. If this and \&quot;token_num_uses\&quot; are both specified, only \&quot;token_num_uses\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_num_uses\&quot; instead. If this and \&quot;token_num_uses\&quot; are both specified, only \&quot;token_num_uses\&quot; will be used.</value>
        [DataMember(Name = "num_uses", EmitDefaultValue = false)]
        [Obsolete]
        public int NumUses { get; set; }

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
        /// If true, the &#39;default&#39; policy will not automatically be added to generated tokens
        /// </summary>
        /// <value>If true, the &#39;default&#39; policy will not automatically be added to generated tokens</value>
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
        /// Use \&quot;token_ttl\&quot; instead. If this and \&quot;token_ttl\&quot; are both specified, only \&quot;token_ttl\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_ttl\&quot; instead. If this and \&quot;token_ttl\&quot; are both specified, only \&quot;token_ttl\&quot; will be used.</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]
        [Obsolete]
        public int Ttl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AzureWriteAuthRoleRequest {\n");
            sb.Append("  BoundGroupIds: ").Append(BoundGroupIds).Append("\n");
            sb.Append("  BoundLocations: ").Append(BoundLocations).Append("\n");
            sb.Append("  BoundResourceGroups: ").Append(BoundResourceGroups).Append("\n");
            sb.Append("  BoundScaleSets: ").Append(BoundScaleSets).Append("\n");
            sb.Append("  BoundServicePrincipalIds: ").Append(BoundServicePrincipalIds).Append("\n");
            sb.Append("  BoundSubscriptionIds: ").Append(BoundSubscriptionIds).Append("\n");
            sb.Append("  MaxTtl: ").Append(MaxTtl).Append("\n");
            sb.Append("  NumUses: ").Append(NumUses).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
            sb.Append("  TokenBoundCidrs: ").Append(TokenBoundCidrs).Append("\n");
            sb.Append("  TokenExplicitMaxTtl: ").Append(TokenExplicitMaxTtl).Append("\n");
            sb.Append("  TokenMaxTtl: ").Append(TokenMaxTtl).Append("\n");
            sb.Append("  TokenNoDefaultPolicy: ").Append(TokenNoDefaultPolicy).Append("\n");
            sb.Append("  TokenNumUses: ").Append(TokenNumUses).Append("\n");
            sb.Append("  TokenPeriod: ").Append(TokenPeriod).Append("\n");
            sb.Append("  TokenPolicies: ").Append(TokenPolicies).Append("\n");
            sb.Append("  TokenTtl: ").Append(TokenTtl).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
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
            return this.Equals(input as AzureWriteAuthRoleRequest);
        }

        /// <summary>
        /// Returns true if AzureWriteAuthRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AzureWriteAuthRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AzureWriteAuthRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BoundGroupIds == input.BoundGroupIds ||
                    this.BoundGroupIds != null &&
                    input.BoundGroupIds != null &&
                    this.BoundGroupIds.SequenceEqual(input.BoundGroupIds)
                ) && 
                (
                    this.BoundLocations == input.BoundLocations ||
                    this.BoundLocations != null &&
                    input.BoundLocations != null &&
                    this.BoundLocations.SequenceEqual(input.BoundLocations)
                ) && 
                (
                    this.BoundResourceGroups == input.BoundResourceGroups ||
                    this.BoundResourceGroups != null &&
                    input.BoundResourceGroups != null &&
                    this.BoundResourceGroups.SequenceEqual(input.BoundResourceGroups)
                ) && 
                (
                    this.BoundScaleSets == input.BoundScaleSets ||
                    this.BoundScaleSets != null &&
                    input.BoundScaleSets != null &&
                    this.BoundScaleSets.SequenceEqual(input.BoundScaleSets)
                ) && 
                (
                    this.BoundServicePrincipalIds == input.BoundServicePrincipalIds ||
                    this.BoundServicePrincipalIds != null &&
                    input.BoundServicePrincipalIds != null &&
                    this.BoundServicePrincipalIds.SequenceEqual(input.BoundServicePrincipalIds)
                ) && 
                (
                    this.BoundSubscriptionIds == input.BoundSubscriptionIds ||
                    this.BoundSubscriptionIds != null &&
                    input.BoundSubscriptionIds != null &&
                    this.BoundSubscriptionIds.SequenceEqual(input.BoundSubscriptionIds)
                ) && 
                (
                    this.MaxTtl == input.MaxTtl ||
                    this.MaxTtl.Equals(input.MaxTtl)
                ) && 
                (
                    this.NumUses == input.NumUses ||
                    this.NumUses.Equals(input.NumUses)
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
                ) && 
                (
                    this.Ttl == input.Ttl ||
                    this.Ttl.Equals(input.Ttl)
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
                if (this.BoundGroupIds != null)
                {
                    hashCode = (hashCode * 59) + this.BoundGroupIds.GetHashCode();
                }
                if (this.BoundLocations != null)
                {
                    hashCode = (hashCode * 59) + this.BoundLocations.GetHashCode();
                }
                if (this.BoundResourceGroups != null)
                {
                    hashCode = (hashCode * 59) + this.BoundResourceGroups.GetHashCode();
                }
                if (this.BoundScaleSets != null)
                {
                    hashCode = (hashCode * 59) + this.BoundScaleSets.GetHashCode();
                }
                if (this.BoundServicePrincipalIds != null)
                {
                    hashCode = (hashCode * 59) + this.BoundServicePrincipalIds.GetHashCode();
                }
                if (this.BoundSubscriptionIds != null)
                {
                    hashCode = (hashCode * 59) + this.BoundSubscriptionIds.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxTtl.GetHashCode();
                hashCode = (hashCode * 59) + this.NumUses.GetHashCode();
                hashCode = (hashCode * 59) + this.Period.GetHashCode();
                if (this.Policies != null)
                {
                    hashCode = (hashCode * 59) + this.Policies.GetHashCode();
                }
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
                hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
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
