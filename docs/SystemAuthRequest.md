# Vault.Model.SystemAuthRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Config** | **Object** | Configuration for this mount, such as plugin_name. | [optional] 
**Description** | **string** | User-friendly description for this credential backend. | [optional] 
**ExternalEntropyAccess** | **bool** | Whether to give the mount access to Vault&#39;s external entropy. | [optional] [default to false]
**Local** | **bool** | Mark the mount as a local mount, which is not replicated and is unaffected by replication. | [optional] [default to false]
**Options** | **Object** | The options to pass into the backend. Should be a json object with string keys and values. | [optional] 
**PluginName** | **string** | Name of the auth plugin to use based from the name in the plugin catalog. | [optional] 
**PluginVersion** | **string** | The semantic version of the plugin to use. | [optional] 
**SealWrap** | **bool** | Whether to turn on seal wrapping for the mount. | [optional] [default to false]
**Type** | **string** | The type of the backend. Example: \&quot;userpass\&quot; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

