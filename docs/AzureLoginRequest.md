# Vault.Model.AzureLoginRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Jwt** | **string** | A signed JWT | [optional] 
**ResourceGroupName** | **string** | The resource group from the instance. | [optional] 
**ResourceId** | **string** | The fully qualified ID of the resource, includingthe resource name and resource type. Use the format, /subscriptions/{guid}/resourceGroups/{resource-group-name}/{resource-provider-namespace}/{resource-type}/{resource-name}. This value is ignored if vm_name or vmss_name is specified. | [optional] 
**Role** | **string** | The token role. | [optional] 
**SubscriptionId** | **string** | The subscription id for the instance. | [optional] 
**VmName** | **string** | The name of the virtual machine. This value is ignored if vmss_name is specified. | [optional] 
**VmssName** | **string** | The name of the virtual machine scale set the instance is in. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

