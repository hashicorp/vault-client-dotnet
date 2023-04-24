# Vault.Model.MountsTuneConfigurationParametersRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedManagedKeys** | **List&lt;string&gt;** |  | [optional] 
**AllowedResponseHeaders** | **List&lt;string&gt;** | A list of headers to whitelist and allow a plugin to set on responses. | [optional] 
**AuditNonHmacRequestKeys** | **List&lt;string&gt;** | The list of keys in the request data object that will not be HMAC&#x27;ed by audit devices. | [optional] 
**AuditNonHmacResponseKeys** | **List&lt;string&gt;** | The list of keys in the response data object that will not be HMAC&#x27;ed by audit devices. | [optional] 
**DefaultLeaseTtl** | **string** | The default lease TTL for this mount. | [optional] 
**Description** | **string** | User-friendly description for this credential backend. | [optional] 
**ListingVisibility** | **string** | Determines the visibility of the mount in the UI-specific listing endpoint. Accepted value are &#x27;unauth&#x27; and &#x27;hidden&#x27;, with the empty default (&#x27;&#x27;) behaving like &#x27;hidden&#x27;. | [optional] 
**MaxLeaseTtl** | **string** | The max lease TTL for this mount. | [optional] 
**Options** | **Object** | The options to pass into the backend. Should be a json object with string keys and values. | [optional] 
**PassthroughRequestHeaders** | **List&lt;string&gt;** | A list of headers to whitelist and pass from the request to the plugin. | [optional] 
**PluginVersion** | **string** | The semantic version of the plugin to use. | [optional] 
**TokenType** | **string** | The type of token to issue (service or batch). | [optional] 
**UserLockoutConfig** | **Object** | The user lockout configuration to pass into the backend. Should be a json object with string keys and values. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

