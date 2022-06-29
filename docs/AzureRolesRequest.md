# VaultClient.Model.AzureRolesRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplicationObjectId** | **string** | Application Object ID to use for static service principal credentials. | [optional] 
**AzureGroups** | **string** | JSON list of Azure groups to add the service principal to. | [optional] 
**AzureRoles** | **string** | JSON list of Azure roles to assign. | [optional] 
**MaxTtl** | **int** | Maximum time a service principal. If not set or set to 0, will use system default. | [optional] 
**Ttl** | **int** | Default lease for generated credentials. If not set or set to 0, will use system default. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

