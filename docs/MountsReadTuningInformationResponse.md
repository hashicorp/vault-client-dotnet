# Vault.Model.MountsReadTuningInformationResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedManagedKeys** | **List&lt;string&gt;** |  | [optional] 
**AllowedResponseHeaders** | **List&lt;string&gt;** | A list of headers to whitelist and allow a plugin to set on responses. | [optional] 
**AuditNonHmacRequestKeys** | **List&lt;string&gt;** |  | [optional] 
**AuditNonHmacResponseKeys** | **List&lt;string&gt;** |  | [optional] 
**DefaultLeaseTtl** | **int** | The default lease TTL for this mount. | [optional] 
**Description** | **string** | User-friendly description for this credential backend. | [optional] 
**ExternalEntropyAccess** | **bool** |  | [optional] 
**ForceNoCache** | **bool** |  | [optional] 
**ListingVisibility** | **string** |  | [optional] 
**MaxLeaseTtl** | **int** | The max lease TTL for this mount. | [optional] 
**Options** | **Object** | The options to pass into the backend. Should be a json object with string keys and values. | [optional] 
**PassthroughRequestHeaders** | **List&lt;string&gt;** |  | [optional] 
**PluginVersion** | **string** | The semantic version of the plugin to use. | [optional] 
**TokenType** | **string** | The type of token to issue (service or batch). | [optional] 
**UserLockoutCounterResetDuration** | **long** |  | [optional] 
**UserLockoutDisable** | **bool** |  | [optional] 
**UserLockoutDuration** | **long** |  | [optional] 
**UserLockoutThreshold** | **long** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

