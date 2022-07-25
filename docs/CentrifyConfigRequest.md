# Vault.Model.CentrifyConfigRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AppId** | **string** | OAuth2 App ID | [optional] [default to "vault_io_integration"]
**ClientId** | **string** | OAuth2 Client ID | [optional] 
**ClientSecret** | **string** | OAuth2 Client Secret | [optional] 
**Policies** | **List&lt;string&gt;** | Use \&quot;token_policies\&quot; instead. If this and \&quot;token_policies\&quot; are both specified, only \&quot;token_policies\&quot; will be used. | [optional] 
**Scope** | **string** | OAuth2 App Scope | [optional] [default to "vault_io_integration"]
**ServiceUrl** | **string** | Service URL (https://&lt;tenant&gt;.my.centrify.com) | [optional] 
**TokenBoundCidrs** | **List&lt;string&gt;** | Comma separated string or JSON list of CIDR blocks. If set, specifies the blocks of IP addresses which are allowed to use the generated token. | [optional] 
**TokenNoDefaultPolicy** | **bool** | If true, the &#39;default&#39; policy will not automatically be added to generated tokens | [optional] 
**TokenNumUses** | **int** | The maximum number of times a token may be used, a value of zero means unlimited | [optional] 
**TokenPolicies** | **List&lt;string&gt;** | Comma-separated list of policies | [optional] 
**TokenTtl** | **int** | The initial ttl of the token to generate | [optional] 
**TokenType** | **string** | The type of token to generate, service or batch | [optional] [default to "default-service"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

