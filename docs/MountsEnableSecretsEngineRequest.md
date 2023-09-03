# Vault.Model.MountsEnableSecretsEngineRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Config** | **Object** | Configuration for this mount, such as default_lease_ttl and max_lease_ttl. | [optional] 
**Description** | **string** | User-friendly description for this mount. | [optional] 
**ExternalEntropyAccess** | **bool** | Whether to give the mount access to Vault&#x27;s external entropy. | [optional] [default to false]
**Local** | **bool** | Mark the mount as a local mount, which is not replicated and is unaffected by replication. | [optional] [default to false]
**Options** | **Object** | The options to pass into the backend. Should be a json object with string keys and values. | [optional] 
**PluginName** | **string** | Name of the plugin to mount based from the name registered in the plugin catalog. | [optional] 
**PluginVersion** | **string** | The semantic version of the plugin to use, or image tag if oci_image is provided. | [optional] 
**SealWrap** | **bool** | Whether to turn on seal wrapping for the mount. | [optional] [default to false]
**Type** | **string** | The type of the backend. Example: \&quot;passthrough\&quot; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

