# Vault.Model.AzureWriteAuthRoleRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BoundGroupIds** | **List&lt;string&gt;** | Comma-separated list of group ids that login is restricted to. | [optional] 
**BoundLocations** | **List&lt;string&gt;** | Comma-separated list of locations that login is restricted to. | [optional] 
**BoundResourceGroups** | **List&lt;string&gt;** | Comma-separated list of resource groups that login is restricted to. | [optional] 
**BoundScaleSets** | **List&lt;string&gt;** | Comma-separated list of scale sets that login is restricted to. | [optional] 
**BoundServicePrincipalIds** | **List&lt;string&gt;** | Comma-separated list of service principal ids that login is restricted to. | [optional] 
**BoundSubscriptionIds** | **List&lt;string&gt;** | Comma-separated list of subscription ids that login is restricted to. | [optional] 
**MaxTtl** | **int** | Use \&quot;token_max_ttl\&quot; instead. If this and \&quot;token_max_ttl\&quot; are both specified, only \&quot;token_max_ttl\&quot; will be used. | [optional] 
**NumUses** | **int** | Use \&quot;token_num_uses\&quot; instead. If this and \&quot;token_num_uses\&quot; are both specified, only \&quot;token_num_uses\&quot; will be used. | [optional] 
**Period** | **int** | Use \&quot;token_period\&quot; instead. If this and \&quot;token_period\&quot; are both specified, only \&quot;token_period\&quot; will be used. | [optional] 
**Policies** | **List&lt;string&gt;** | Use \&quot;token_policies\&quot; instead. If this and \&quot;token_policies\&quot; are both specified, only \&quot;token_policies\&quot; will be used. | [optional] 
**TokenBoundCidrs** | **List&lt;string&gt;** | Comma separated string or JSON list of CIDR blocks. If set, specifies the blocks of IP addresses which are allowed to use the generated token. | [optional] 
**TokenExplicitMaxTtl** | **int** | If set, tokens created via this role carry an explicit maximum TTL. During renewal, the current maximum TTL values of the role and the mount are not checked for changes, and any updates to these values will have no effect on the token being renewed. | [optional] 
**TokenMaxTtl** | **int** | The maximum lifetime of the generated token | [optional] 
**TokenNoDefaultPolicy** | **bool** | If true, the &#39;default&#39; policy will not automatically be added to generated tokens | [optional] 
**TokenNumUses** | **int** | The maximum number of times a token may be used, a value of zero means unlimited | [optional] 
**TokenPeriod** | **int** | If set, tokens created via this role will have no max lifetime; instead, their renewal period will be fixed to this value. This takes an integer number of seconds, or a string duration (e.g. \&quot;24h\&quot;). | [optional] 
**TokenPolicies** | **List&lt;string&gt;** | Comma-separated list of policies | [optional] 
**TokenTtl** | **int** | The initial ttl of the token to generate | [optional] 
**TokenType** | **string** | The type of token to generate, service or batch | [optional] [default to "default-service"]
**Ttl** | **int** | Use \&quot;token_ttl\&quot; instead. If this and \&quot;token_ttl\&quot; are both specified, only \&quot;token_ttl\&quot; will be used. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

