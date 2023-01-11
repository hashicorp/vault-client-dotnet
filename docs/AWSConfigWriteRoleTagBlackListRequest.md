# Vault.Model.AWSConfigWriteRoleTagBlackListRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisablePeriodicTidy** | **bool** | If set to &#39;true&#39;, disables the periodic tidying of deny listed entries. | [optional] [default to false]
**SafetyBuffer** | **int** | The amount of extra time that must have passed beyond the roletag expiration, before it is removed from the backend storage. Defaults to 4320h (180 days). | [optional] [default to 15552000]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
