# Vault.Model.AWSConfigWriteIdentityAccessListRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisablePeriodicTidy** | **bool** | If set to &#39;true&#39;, disables the periodic tidying of the &#39;identity-accesslist/&lt;instance_id&gt;&#39; entries. | [optional] [default to false]
**SafetyBuffer** | **int** | The amount of extra time that must have passed beyond the identity&#39;s expiration, before it is removed from the backend storage. | [optional] [default to 259200]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

