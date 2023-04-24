# Vault.Model.RateLimitQuotasWriteRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BlockInterval** | **int** | If set, when a client reaches a rate limit threshold, the client will be prohibited from any further requests until after the &#x27;block_interval&#x27; has elapsed. | [optional] 
**Interval** | **int** | The duration to enforce rate limiting for (default &#x27;1s&#x27;). | [optional] 
**Path** | **string** | Path of the mount or namespace to apply the quota. A blank path configures a global quota. For example namespace1/ adds a quota to a full namespace, namespace1/auth/userpass adds a quota to userpass in namespace1. | [optional] 
**Rate** | **float** | The maximum number of requests in a given interval to be allowed by the quota rule. The &#x27;rate&#x27; must be positive. | [optional] 
**Role** | **string** | Login role to apply this quota to. Note that when set, path must be configured to a valid auth method with a concept of roles. | [optional] 
**Type** | **string** | Type of the quota rule. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
