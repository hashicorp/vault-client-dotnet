# Vault.Model.TerraformWriteRoleRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MaxTtl** | **int** | Maximum time for role. If not set or set to 0, will use system default. | [optional] 
**Organization** | **string** | Name of the Terraform Cloud or Enterprise organization | [optional] 
**TeamId** | **string** | ID of the Terraform Cloud or Enterprise team under organization (e.g., settings/teams/team-xxxxxxxxxxxxx) | [optional] 
**Ttl** | **int** | Default lease for generated credentials. If not set or set to 0, will use system default. | [optional] 
**UserId** | **string** | ID of the Terraform Cloud or Enterprise user (e.g., user-xxxxxxxxxxxxxxxx) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

