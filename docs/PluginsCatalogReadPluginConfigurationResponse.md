# Vault.Model.PluginsCatalogReadPluginConfigurationResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Args** | **List&lt;string&gt;** | The args passed to plugin command. | [optional] 
**Builtin** | **bool** |  | [optional] 
**Command** | **string** | The command used to start the plugin. The executable defined in this command must exist in vault&#x27;s plugin directory. | [optional] 
**DeprecationStatus** | **string** |  | [optional] 
**Name** | **string** | The name of the plugin | [optional] 
**OciImage** | **string** | The name of the OCI image to be run, without the tag or SHA256. Must already be present on the machine. | [optional] 
**Sha256** | **string** | The SHA256 sum of the executable or container to be run. This should be HEX encoded. | [optional] 
**_Version** | **string** | The semantic version of the plugin to use, or image tag if oci_image is provided. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

