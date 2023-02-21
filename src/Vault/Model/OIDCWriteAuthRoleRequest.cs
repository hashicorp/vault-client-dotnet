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
    /// OIDCWriteAuthRoleRequest
    /// </summary>
    [DataContract(Name = "OIDCWriteAuthRoleRequest")]
    public partial class OIDCWriteAuthRoleRequest : IEquatable<OIDCWriteAuthRoleRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OIDCWriteAuthRoleRequest" /> class.
        /// </summary>
        /// <param name="allowedRedirectUris">Comma-separated list of allowed values for redirect_uri.</param>
        /// <param name="boundAudiences">Comma-separated list of &#39;aud&#39; claims that are valid for login; any match is sufficient.</param>
        /// <param name="boundCidrs">Use \&quot;token_bound_cidrs\&quot; instead. If this and \&quot;token_bound_cidrs\&quot; are both specified, only \&quot;token_bound_cidrs\&quot; will be used..</param>
        /// <param name="boundClaims">Map of claims/values which must match for login.</param>
        /// <param name="boundClaimsType">How to interpret values in the map of claims/values (which must match for login): allowed values are &#39;string&#39; or &#39;glob&#39; (default to &quot;string&quot;).</param>
        /// <param name="boundSubject">The &#39;sub&#39; claim that is valid for login. Optional..</param>
        /// <param name="claimMappings">Mappings of claims (key) that will be copied to a metadata field (value).</param>
        /// <param name="clockSkewLeeway">Duration in seconds of leeway when validating all claims to account for clock skew. Defaults to 60 (1 minute) if set to 0 and can be disabled if set to -1..</param>
        /// <param name="expirationLeeway">Duration in seconds of leeway when validating expiration of a token to account for clock skew. Defaults to 150 (2.5 minutes) if set to 0 and can be disabled if set to -1. (default to 150).</param>
        /// <param name="groupsClaim">The claim to use for the Identity group alias names.</param>
        /// <param name="maxAge">Specifies the allowable elapsed time in seconds since the last time the user was actively authenticated..</param>
        /// <param name="maxTtl">Use \&quot;token_max_ttl\&quot; instead. If this and \&quot;token_max_ttl\&quot; are both specified, only \&quot;token_max_ttl\&quot; will be used..</param>
        /// <param name="notBeforeLeeway">Duration in seconds of leeway when validating not before values of a token to account for clock skew. Defaults to 150 (2.5 minutes) if set to 0 and can be disabled if set to -1. (default to 150).</param>
        /// <param name="numUses">Use \&quot;token_num_uses\&quot; instead. If this and \&quot;token_num_uses\&quot; are both specified, only \&quot;token_num_uses\&quot; will be used..</param>
        /// <param name="oidcScopes">Comma-separated list of OIDC scopes.</param>
        /// <param name="period">Use \&quot;token_period\&quot; instead. If this and \&quot;token_period\&quot; are both specified, only \&quot;token_period\&quot; will be used..</param>
        /// <param name="policies">Use \&quot;token_policies\&quot; instead. If this and \&quot;token_policies\&quot; are both specified, only \&quot;token_policies\&quot; will be used..</param>
        /// <param name="roleType">Type of the role, either &#39;jwt&#39; or &#39;oidc&#39;..</param>
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
        /// <param name="userClaim">The claim to use for the Identity entity alias name.</param>
        /// <param name="userClaimJsonPointer">If true, the user_claim value will use JSON pointer syntax for referencing claims..</param>
        /// <param name="verboseOidcLogging">Log received OIDC tokens and claims when debug-level logging is active. Not recommended in production since sensitive information may be present in OIDC responses..</param>
        public OIDCWriteAuthRoleRequest(List<string> allowedRedirectUris = default(List<string>), List<string> boundAudiences = default(List<string>), List<string> boundCidrs = default(List<string>), Object boundClaims = default(Object), string boundClaimsType = "string", string boundSubject = default(string), Object claimMappings = default(Object), int clockSkewLeeway = default(int), int expirationLeeway = 150, string groupsClaim = default(string), int maxAge = default(int), int maxTtl = default(int), int notBeforeLeeway = 150, int numUses = default(int), List<string> oidcScopes = default(List<string>), int period = default(int), List<string> policies = default(List<string>), string roleType = default(string), List<string> tokenBoundCidrs = default(List<string>), int tokenExplicitMaxTtl = default(int), int tokenMaxTtl = default(int), bool tokenNoDefaultPolicy = default(bool), int tokenNumUses = default(int), int tokenPeriod = default(int), List<string> tokenPolicies = default(List<string>), int tokenTtl = default(int), string tokenType = "default-service", int ttl = default(int), string userClaim = default(string), bool userClaimJsonPointer = default(bool), bool verboseOidcLogging = default(bool))
        {
            this.AllowedRedirectUris = allowedRedirectUris;
            this.BoundAudiences = boundAudiences;
            this.BoundCidrs = boundCidrs;
            this.BoundClaims = boundClaims;
            // use default value if no "boundClaimsType" provided
            this.BoundClaimsType = boundClaimsType ?? "string";
            this.BoundSubject = boundSubject;
            this.ClaimMappings = claimMappings;
            this.ClockSkewLeeway = clockSkewLeeway;
            this.ExpirationLeeway = expirationLeeway;
            this.GroupsClaim = groupsClaim;
            this.MaxAge = maxAge;
            this.MaxTtl = maxTtl;
            this.NotBeforeLeeway = notBeforeLeeway;
            this.NumUses = numUses;
            this.OidcScopes = oidcScopes;
            this.Period = period;
            this.Policies = policies;
            this.RoleType = roleType;
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
            this.UserClaim = userClaim;
            this.UserClaimJsonPointer = userClaimJsonPointer;
            this.VerboseOidcLogging = verboseOidcLogging;
        }

        /// <summary>
        /// Comma-separated list of allowed values for redirect_uri
        /// </summary>
        /// <value>Comma-separated list of allowed values for redirect_uri</value>
        [DataMember(Name = "allowed_redirect_uris", EmitDefaultValue = false)]
        public List<string> AllowedRedirectUris { get; set; }

        /// <summary>
        /// Comma-separated list of &#39;aud&#39; claims that are valid for login; any match is sufficient
        /// </summary>
        /// <value>Comma-separated list of &#39;aud&#39; claims that are valid for login; any match is sufficient</value>
        [DataMember(Name = "bound_audiences", EmitDefaultValue = false)]
        public List<string> BoundAudiences { get; set; }

        /// <summary>
        /// Use \&quot;token_bound_cidrs\&quot; instead. If this and \&quot;token_bound_cidrs\&quot; are both specified, only \&quot;token_bound_cidrs\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_bound_cidrs\&quot; instead. If this and \&quot;token_bound_cidrs\&quot; are both specified, only \&quot;token_bound_cidrs\&quot; will be used.</value>
        [DataMember(Name = "bound_cidrs", EmitDefaultValue = false)]
        [Obsolete]
        public List<string> BoundCidrs { get; set; }

        /// <summary>
        /// Map of claims/values which must match for login
        /// </summary>
        /// <value>Map of claims/values which must match for login</value>
        [DataMember(Name = "bound_claims", EmitDefaultValue = false)]
        public Object BoundClaims { get; set; }

        /// <summary>
        /// How to interpret values in the map of claims/values (which must match for login): allowed values are &#39;string&#39; or &#39;glob&#39;
        /// </summary>
        /// <value>How to interpret values in the map of claims/values (which must match for login): allowed values are &#39;string&#39; or &#39;glob&#39;</value>
        [DataMember(Name = "bound_claims_type", EmitDefaultValue = false)]
        public string BoundClaimsType { get; set; }

        /// <summary>
        /// The &#39;sub&#39; claim that is valid for login. Optional.
        /// </summary>
        /// <value>The &#39;sub&#39; claim that is valid for login. Optional.</value>
        [DataMember(Name = "bound_subject", EmitDefaultValue = false)]
        public string BoundSubject { get; set; }

        /// <summary>
        /// Mappings of claims (key) that will be copied to a metadata field (value)
        /// </summary>
        /// <value>Mappings of claims (key) that will be copied to a metadata field (value)</value>
        [DataMember(Name = "claim_mappings", EmitDefaultValue = false)]
        public Object ClaimMappings { get; set; }

        /// <summary>
        /// Duration in seconds of leeway when validating all claims to account for clock skew. Defaults to 60 (1 minute) if set to 0 and can be disabled if set to -1.
        /// </summary>
        /// <value>Duration in seconds of leeway when validating all claims to account for clock skew. Defaults to 60 (1 minute) if set to 0 and can be disabled if set to -1.</value>
        [DataMember(Name = "clock_skew_leeway", EmitDefaultValue = false)]
        public int ClockSkewLeeway { get; set; }

        /// <summary>
        /// Duration in seconds of leeway when validating expiration of a token to account for clock skew. Defaults to 150 (2.5 minutes) if set to 0 and can be disabled if set to -1.
        /// </summary>
        /// <value>Duration in seconds of leeway when validating expiration of a token to account for clock skew. Defaults to 150 (2.5 minutes) if set to 0 and can be disabled if set to -1.</value>
        [DataMember(Name = "expiration_leeway", EmitDefaultValue = false)]
        public int ExpirationLeeway { get; set; }

        /// <summary>
        /// The claim to use for the Identity group alias names
        /// </summary>
        /// <value>The claim to use for the Identity group alias names</value>
        [DataMember(Name = "groups_claim", EmitDefaultValue = false)]
        public string GroupsClaim { get; set; }

        /// <summary>
        /// Specifies the allowable elapsed time in seconds since the last time the user was actively authenticated.
        /// </summary>
        /// <value>Specifies the allowable elapsed time in seconds since the last time the user was actively authenticated.</value>
        [DataMember(Name = "max_age", EmitDefaultValue = false)]
        public int MaxAge { get; set; }

        /// <summary>
        /// Use \&quot;token_max_ttl\&quot; instead. If this and \&quot;token_max_ttl\&quot; are both specified, only \&quot;token_max_ttl\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_max_ttl\&quot; instead. If this and \&quot;token_max_ttl\&quot; are both specified, only \&quot;token_max_ttl\&quot; will be used.</value>
        [DataMember(Name = "max_ttl", EmitDefaultValue = false)]
        [Obsolete]
        public int MaxTtl { get; set; }

        /// <summary>
        /// Duration in seconds of leeway when validating not before values of a token to account for clock skew. Defaults to 150 (2.5 minutes) if set to 0 and can be disabled if set to -1.
        /// </summary>
        /// <value>Duration in seconds of leeway when validating not before values of a token to account for clock skew. Defaults to 150 (2.5 minutes) if set to 0 and can be disabled if set to -1.</value>
        [DataMember(Name = "not_before_leeway", EmitDefaultValue = false)]
        public int NotBeforeLeeway { get; set; }

        /// <summary>
        /// Use \&quot;token_num_uses\&quot; instead. If this and \&quot;token_num_uses\&quot; are both specified, only \&quot;token_num_uses\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_num_uses\&quot; instead. If this and \&quot;token_num_uses\&quot; are both specified, only \&quot;token_num_uses\&quot; will be used.</value>
        [DataMember(Name = "num_uses", EmitDefaultValue = false)]
        [Obsolete]
        public int NumUses { get; set; }

        /// <summary>
        /// Comma-separated list of OIDC scopes
        /// </summary>
        /// <value>Comma-separated list of OIDC scopes</value>
        [DataMember(Name = "oidc_scopes", EmitDefaultValue = false)]
        public List<string> OidcScopes { get; set; }

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
        /// Type of the role, either &#39;jwt&#39; or &#39;oidc&#39;.
        /// </summary>
        /// <value>Type of the role, either &#39;jwt&#39; or &#39;oidc&#39;.</value>
        [DataMember(Name = "role_type", EmitDefaultValue = false)]
        public string RoleType { get; set; }

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
        /// The claim to use for the Identity entity alias name
        /// </summary>
        /// <value>The claim to use for the Identity entity alias name</value>
        [DataMember(Name = "user_claim", EmitDefaultValue = false)]
        public string UserClaim { get; set; }

        /// <summary>
        /// If true, the user_claim value will use JSON pointer syntax for referencing claims.
        /// </summary>
        /// <value>If true, the user_claim value will use JSON pointer syntax for referencing claims.</value>
        [DataMember(Name = "user_claim_json_pointer", EmitDefaultValue = true)]
        public bool UserClaimJsonPointer { get; set; }

        /// <summary>
        /// Log received OIDC tokens and claims when debug-level logging is active. Not recommended in production since sensitive information may be present in OIDC responses.
        /// </summary>
        /// <value>Log received OIDC tokens and claims when debug-level logging is active. Not recommended in production since sensitive information may be present in OIDC responses.</value>
        [DataMember(Name = "verbose_oidc_logging", EmitDefaultValue = true)]
        public bool VerboseOidcLogging { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OIDCWriteAuthRoleRequest {\n");
            sb.Append("  AllowedRedirectUris: ").Append(AllowedRedirectUris).Append("\n");
            sb.Append("  BoundAudiences: ").Append(BoundAudiences).Append("\n");
            sb.Append("  BoundCidrs: ").Append(BoundCidrs).Append("\n");
            sb.Append("  BoundClaims: ").Append(BoundClaims).Append("\n");
            sb.Append("  BoundClaimsType: ").Append(BoundClaimsType).Append("\n");
            sb.Append("  BoundSubject: ").Append(BoundSubject).Append("\n");
            sb.Append("  ClaimMappings: ").Append(ClaimMappings).Append("\n");
            sb.Append("  ClockSkewLeeway: ").Append(ClockSkewLeeway).Append("\n");
            sb.Append("  ExpirationLeeway: ").Append(ExpirationLeeway).Append("\n");
            sb.Append("  GroupsClaim: ").Append(GroupsClaim).Append("\n");
            sb.Append("  MaxAge: ").Append(MaxAge).Append("\n");
            sb.Append("  MaxTtl: ").Append(MaxTtl).Append("\n");
            sb.Append("  NotBeforeLeeway: ").Append(NotBeforeLeeway).Append("\n");
            sb.Append("  NumUses: ").Append(NumUses).Append("\n");
            sb.Append("  OidcScopes: ").Append(OidcScopes).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
            sb.Append("  RoleType: ").Append(RoleType).Append("\n");
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
            sb.Append("  UserClaim: ").Append(UserClaim).Append("\n");
            sb.Append("  UserClaimJsonPointer: ").Append(UserClaimJsonPointer).Append("\n");
            sb.Append("  VerboseOidcLogging: ").Append(VerboseOidcLogging).Append("\n");
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
            return this.Equals(input as OIDCWriteAuthRoleRequest);
        }

        /// <summary>
        /// Returns true if OIDCWriteAuthRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OIDCWriteAuthRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OIDCWriteAuthRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AllowedRedirectUris == input.AllowedRedirectUris ||
                    this.AllowedRedirectUris != null &&
                    input.AllowedRedirectUris != null &&
                    this.AllowedRedirectUris.SequenceEqual(input.AllowedRedirectUris)
                ) &&
                (
                    this.BoundAudiences == input.BoundAudiences ||
                    this.BoundAudiences != null &&
                    input.BoundAudiences != null &&
                    this.BoundAudiences.SequenceEqual(input.BoundAudiences)
                ) &&
                (
                    this.BoundCidrs == input.BoundCidrs ||
                    this.BoundCidrs != null &&
                    input.BoundCidrs != null &&
                    this.BoundCidrs.SequenceEqual(input.BoundCidrs)
                ) &&
                (
                    this.BoundClaims == input.BoundClaims ||
                    (this.BoundClaims != null &&
                    this.BoundClaims.Equals(input.BoundClaims))
                ) &&
                (
                    this.BoundClaimsType == input.BoundClaimsType ||
                    (this.BoundClaimsType != null &&
                    this.BoundClaimsType.Equals(input.BoundClaimsType))
                ) &&
                (
                    this.BoundSubject == input.BoundSubject ||
                    (this.BoundSubject != null &&
                    this.BoundSubject.Equals(input.BoundSubject))
                ) &&
                (
                    this.ClaimMappings == input.ClaimMappings ||
                    (this.ClaimMappings != null &&
                    this.ClaimMappings.Equals(input.ClaimMappings))
                ) &&
                (
                    this.ClockSkewLeeway == input.ClockSkewLeeway ||
                    this.ClockSkewLeeway.Equals(input.ClockSkewLeeway)
                ) &&
                (
                    this.ExpirationLeeway == input.ExpirationLeeway ||
                    this.ExpirationLeeway.Equals(input.ExpirationLeeway)
                ) &&
                (
                    this.GroupsClaim == input.GroupsClaim ||
                    (this.GroupsClaim != null &&
                    this.GroupsClaim.Equals(input.GroupsClaim))
                ) &&
                (
                    this.MaxAge == input.MaxAge ||
                    this.MaxAge.Equals(input.MaxAge)
                ) &&
                (
                    this.MaxTtl == input.MaxTtl ||
                    this.MaxTtl.Equals(input.MaxTtl)
                ) &&
                (
                    this.NotBeforeLeeway == input.NotBeforeLeeway ||
                    this.NotBeforeLeeway.Equals(input.NotBeforeLeeway)
                ) &&
                (
                    this.NumUses == input.NumUses ||
                    this.NumUses.Equals(input.NumUses)
                ) &&
                (
                    this.OidcScopes == input.OidcScopes ||
                    this.OidcScopes != null &&
                    input.OidcScopes != null &&
                    this.OidcScopes.SequenceEqual(input.OidcScopes)
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
                    this.RoleType == input.RoleType ||
                    (this.RoleType != null &&
                    this.RoleType.Equals(input.RoleType))
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
                ) &&
                (
                    this.UserClaim == input.UserClaim ||
                    (this.UserClaim != null &&
                    this.UserClaim.Equals(input.UserClaim))
                ) &&
                (
                    this.UserClaimJsonPointer == input.UserClaimJsonPointer ||
                    this.UserClaimJsonPointer.Equals(input.UserClaimJsonPointer)
                ) &&
                (
                    this.VerboseOidcLogging == input.VerboseOidcLogging ||
                    this.VerboseOidcLogging.Equals(input.VerboseOidcLogging)
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
                if (this.AllowedRedirectUris != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedRedirectUris.GetHashCode();
                }
                if (this.BoundAudiences != null)
                {
                    hashCode = (hashCode * 59) + this.BoundAudiences.GetHashCode();
                }
                if (this.BoundCidrs != null)
                {
                    hashCode = (hashCode * 59) + this.BoundCidrs.GetHashCode();
                }
                if (this.BoundClaims != null)
                {
                    hashCode = (hashCode * 59) + this.BoundClaims.GetHashCode();
                }
                if (this.BoundClaimsType != null)
                {
                    hashCode = (hashCode * 59) + this.BoundClaimsType.GetHashCode();
                }
                if (this.BoundSubject != null)
                {
                    hashCode = (hashCode * 59) + this.BoundSubject.GetHashCode();
                }
                if (this.ClaimMappings != null)
                {
                    hashCode = (hashCode * 59) + this.ClaimMappings.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ClockSkewLeeway.GetHashCode();
                hashCode = (hashCode * 59) + this.ExpirationLeeway.GetHashCode();
                if (this.GroupsClaim != null)
                {
                    hashCode = (hashCode * 59) + this.GroupsClaim.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxAge.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxTtl.GetHashCode();
                hashCode = (hashCode * 59) + this.NotBeforeLeeway.GetHashCode();
                hashCode = (hashCode * 59) + this.NumUses.GetHashCode();
                if (this.OidcScopes != null)
                {
                    hashCode = (hashCode * 59) + this.OidcScopes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Period.GetHashCode();
                if (this.Policies != null)
                {
                    hashCode = (hashCode * 59) + this.Policies.GetHashCode();
                }
                if (this.RoleType != null)
                {
                    hashCode = (hashCode * 59) + this.RoleType.GetHashCode();
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
                if (this.UserClaim != null)
                {
                    hashCode = (hashCode * 59) + this.UserClaim.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UserClaimJsonPointer.GetHashCode();
                hashCode = (hashCode * 59) + this.VerboseOidcLogging.GetHashCode();
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
