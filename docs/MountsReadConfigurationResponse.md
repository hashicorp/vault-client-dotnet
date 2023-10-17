# Vault.Model.MountsReadConfigurationResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accessor** | **string** |  | [optional] 
**Config** | **Object** | Configuration for this mount, such as default_lease_ttl and max_lease_ttl. | [optional] 
**DeprecationStatus** | **string** |  | [optional] 
**Description** | **string** | User-friendly description for this mount. | [optional] 
**ExternalEntropyAccess** | **bool** |  | [optional] 
**Local** | **bool** | Mark the mount as a local mount, which is not replicated and is unaffected by replication. | [optional] [default to false]
**Options** | **Object** | The options to pass into the backend. Should be a json object with string keys and values. | [optional] 
**PluginVersion** | **string** | The semantic version of the plugin to use, or image tag if oci_image is provided. | [optional] 
**RunningPluginVersion** | **string** |  | [optional] 
**RunningSha256** | **string** |  | [optional] 
**SealWrap** | **bool** | Whether to turn on seal wrapping for the mount. | [optional] [default to false]
**Type** | **string** | The type of the backend. Example: \&quot;passthrough\&quot; | [optional] 
**Uuid** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

