# Vault.Model.PluginsCatalogReadPluginConfigurationResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Args** | **List&lt;string&gt;** | The args passed to plugin command. | [optional] 
**Builtin** | **bool** |  | [optional] 
**Command** | **string** | The command used to start the plugin. The executable defined in this command must exist in vault&#x27;s plugin directory. | [optional] 
**DeprecationStatus** | **string** |  | [optional] 
**Name** | **string** | The name of the plugin | [optional] 
**Sha256** | **string** | The SHA256 sum of the executable used in the command field. This should be HEX encoded. | [optional] 
**_Version** | **string** | The semantic version of the plugin to use. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

