# Vault.Model.MfaCreateOktaMethodRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiToken** | **string** | Okta API key. | [optional] 
**BaseUrl** | **string** | The base domain to use for the Okta API. When not specified in the configuration, \&quot;okta.com\&quot; is used. | [optional] 
**MethodName** | **string** | The unique name identifier for this MFA method. | [optional] 
**OrgName** | **string** | Name of the organization to be used in the Okta API. | [optional] 
**PrimaryEmail** | **bool** | If true, the username will only match the primary email for the account. Defaults to false. | [optional] 
**Production** | **bool** | (DEPRECATED) Use base_url instead. | [optional] 
**UsernameFormat** | **string** | A template string for mapping Identity names to MFA method names. Values to substitute should be placed in {{}}. For example, \&quot;{{entity.name}}@example.com\&quot;. If blank, the Entity&#x27;s name field will be used as-is. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

