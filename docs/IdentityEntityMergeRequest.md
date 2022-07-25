# Vault.Model.IdentityEntityMergeRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Force** | **bool** | Setting this will follow the &#39;mine&#39; strategy for merging MFA secrets. If there are secrets of the same type both in entities that are merged from and in entity into which all others are getting merged, secrets in the destination will be unaltered. If not set, this API will throw an error containing all the conflicts. | [optional] 
**FromEntityIds** | **List&lt;string&gt;** | Entity IDs which needs to get merged | [optional] 
**ToEntityId** | **string** | Entity ID into which all the other entities need to get merged | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

