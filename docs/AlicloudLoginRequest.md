# VaultClient.Model.AlicloudLoginRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdentityRequestHeaders** | **string** | The request headers. This must include the headers over which AliCloud has included a signature. | [optional] 
**IdentityRequestUrl** | **string** | Base64-encoded full URL against which to make the AliCloud request. | [optional] 
**Role** | **string** | Name of the role against which the login is being attempted. If &#39;role&#39; is not specified, then the login endpoint looks for a role name in the ARN returned by the GetCallerIdentity request. If a matching role is not found, login fails. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

