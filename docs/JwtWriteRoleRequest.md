# Vault.Model.JwtWriteRoleRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedRedirectUris** | **List&lt;string&gt;** | Comma-separated list of allowed values for redirect_uri | [optional] 
**BoundAudiences** | **List&lt;string&gt;** | Comma-separated list of &#x27;aud&#x27; claims that are valid for login; any match is sufficient | [optional] 
**BoundCidrs** | **List&lt;string&gt;** | Use \&quot;token_bound_cidrs\&quot; instead. If this and \&quot;token_bound_cidrs\&quot; are both specified, only \&quot;token_bound_cidrs\&quot; will be used. | [optional] 
**BoundClaims** | **Object** | Map of claims/values which must match for login | [optional] 
**BoundClaimsType** | **string** | How to interpret values in the map of claims/values (which must match for login): allowed values are &#x27;string&#x27; or &#x27;glob&#x27; | [optional] [default to "string"]
**BoundSubject** | **string** | The &#x27;sub&#x27; claim that is valid for login. Optional. | [optional] 
**ClaimMappings** | **Object** | Mappings of claims (key) that will be copied to a metadata field (value) | [optional] 
**ClockSkewLeeway** | **string** | Duration in seconds of leeway when validating all claims to account for clock skew. Defaults to 60 (1 minute) if set to 0 and can be disabled if set to -1. | [optional] [default to "60000000000"]
**ExpirationLeeway** | **string** | Duration in seconds of leeway when validating expiration of a token to account for clock skew. Defaults to 150 (2.5 minutes) if set to 0 and can be disabled if set to -1. | [optional] [default to "150"]
**GroupsClaim** | **string** | The claim to use for the Identity group alias names | [optional] 
**MaxAge** | **string** | Specifies the allowable elapsed time in seconds since the last time the user was actively authenticated. | [optional] 
**MaxTtl** | **string** | Use \&quot;token_max_ttl\&quot; instead. If this and \&quot;token_max_ttl\&quot; are both specified, only \&quot;token_max_ttl\&quot; will be used. | [optional] 
**NotBeforeLeeway** | **string** | Duration in seconds of leeway when validating not before values of a token to account for clock skew. Defaults to 150 (2.5 minutes) if set to 0 and can be disabled if set to -1. | [optional] [default to "150"]
**NumUses** | **int** | Use \&quot;token_num_uses\&quot; instead. If this and \&quot;token_num_uses\&quot; are both specified, only \&quot;token_num_uses\&quot; will be used. | [optional] 
**OidcScopes** | **List&lt;string&gt;** | Comma-separated list of OIDC scopes | [optional] 
**Period** | **string** | Use \&quot;token_period\&quot; instead. If this and \&quot;token_period\&quot; are both specified, only \&quot;token_period\&quot; will be used. | [optional] 
**Policies** | **List&lt;string&gt;** | Use \&quot;token_policies\&quot; instead. If this and \&quot;token_policies\&quot; are both specified, only \&quot;token_policies\&quot; will be used. | [optional] 
**RoleType** | **string** | Type of the role, either &#x27;jwt&#x27; or &#x27;oidc&#x27;. | [optional] 
**TokenBoundCidrs** | **List&lt;string&gt;** | Comma separated string or JSON list of CIDR blocks. If set, specifies the blocks of IP addresses which are allowed to use the generated token. | [optional] 
**TokenExplicitMaxTtl** | **string** | If set, tokens created via this role carry an explicit maximum TTL. During renewal, the current maximum TTL values of the role and the mount are not checked for changes, and any updates to these values will have no effect on the token being renewed. | [optional] 
**TokenMaxTtl** | **string** | The maximum lifetime of the generated token | [optional] 
**TokenNoDefaultPolicy** | **bool** | If true, the &#x27;default&#x27; policy will not automatically be added to generated tokens | [optional] 
**TokenNumUses** | **int** | The maximum number of times a token may be used, a value of zero means unlimited | [optional] 
**TokenPeriod** | **string** | If set, tokens created via this role will have no max lifetime; instead, their renewal period will be fixed to this value. This takes an integer number of seconds, or a string duration (e.g. \&quot;24h\&quot;). | [optional] 
**TokenPolicies** | **List&lt;string&gt;** | Comma-separated list of policies | [optional] 
**TokenTtl** | **string** | The initial ttl of the token to generate | [optional] 
**TokenType** | **string** | The type of token to generate, service or batch | [optional] [default to "default-service"]
**Ttl** | **string** | Use \&quot;token_ttl\&quot; instead. If this and \&quot;token_ttl\&quot; are both specified, only \&quot;token_ttl\&quot; will be used. | [optional] 
**UserClaim** | **string** | The claim to use for the Identity entity alias name | [optional] 
**UserClaimJsonPointer** | **bool** | If true, the user_claim value will use JSON pointer syntax for referencing claims. | [optional] 
**VerboseOidcLogging** | **bool** | Log received OIDC tokens and claims when debug-level logging is active. Not recommended in production since sensitive information may be present in OIDC responses. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

