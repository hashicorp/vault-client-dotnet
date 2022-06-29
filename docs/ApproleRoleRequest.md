# VaultClient.Model.ApproleRoleRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BindSecretId** | **bool** | Impose secret_id to be presented when logging in using this role. Defaults to &#39;true&#39;. | [optional] [default to true]
**BoundCidrList** | **List&lt;string&gt;** | Use \&quot;secret_id_bound_cidrs\&quot; instead. | [optional] 
**LocalSecretIds** | **bool** | If set, the secret IDs generated using this role will be cluster local. This can only be set during role creation and once set, it can&#39;t be reset later. | [optional] 
**Period** | **int** | Use \&quot;token_period\&quot; instead. If this and \&quot;token_period\&quot; are both specified, only \&quot;token_period\&quot; will be used. | [optional] 
**Policies** | **List&lt;string&gt;** | Use \&quot;token_policies\&quot; instead. If this and \&quot;token_policies\&quot; are both specified, only \&quot;token_policies\&quot; will be used. | [optional] 
**RoleId** | **string** | Identifier of the role. Defaults to a UUID. | [optional] 
**SecretIdBoundCidrs** | **List&lt;string&gt;** | Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can perform the login operation. | [optional] 
**SecretIdNumUses** | **int** | Number of times a SecretID can access the role, after which the SecretID will expire. Defaults to 0 meaning that the the secret_id is of unlimited use. | [optional] 
**SecretIdTtl** | **int** | Duration in seconds after which the issued SecretID should expire. Defaults to 0, meaning no expiration. | [optional] 
**TokenBoundCidrs** | **List&lt;string&gt;** | Comma separated string or JSON list of CIDR blocks. If set, specifies the blocks of IP addresses which are allowed to use the generated token. | [optional] 
**TokenExplicitMaxTtl** | **int** | If set, tokens created via this role carry an explicit maximum TTL. During renewal, the current maximum TTL values of the role and the mount are not checked for changes, and any updates to these values will have no effect on the token being renewed. | [optional] 
**TokenMaxTtl** | **int** | The maximum lifetime of the generated token | [optional] 
**TokenNoDefaultPolicy** | **bool** | If true, the &#39;default&#39; policy will not automatically be added to generated tokens | [optional] 
**TokenNumUses** | **int** | The maximum number of times a token may be used, a value of zero means unlimited | [optional] 
**TokenPeriod** | **int** | If set, tokens created via this role will have no max lifetime; instead, their renewal period will be fixed to this value. This takes an integer number of seconds, or a string duration (e.g. \&quot;24h\&quot;). | [optional] 
**TokenPolicies** | **List&lt;string&gt;** | Comma-separated list of policies | [optional] 
**TokenTtl** | **int** | The initial ttl of the token to generate | [optional] 
**TokenType** | **string** | The type of token to generate, service or batch | [optional] [default to "default-service"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

