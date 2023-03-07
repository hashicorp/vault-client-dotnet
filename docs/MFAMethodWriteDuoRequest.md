# Vault.Model.MFAMethodWriteDuoRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiHostname** | **string** | API host name for Duo. | [optional] **IntegrationKey** | **string** | Integration key for Duo. | [optional] **MethodId** | **string** | The unique identifier for this MFA method. | [optional] **PushInfo** | **string** | Push information for Duo. | [optional] **SecretKey** | **string** | Secret key for Duo. | [optional] **UsePasscode** | **bool** | If true, the user is reminded to use the passcode upon MFA validation. This option does not enforce using the passcode. Defaults to false. | [optional] **UsernameFormat** | **string** | A template string for mapping Identity names to MFA method names. Values to subtitute should be placed in {{}}. For example, \&quot;{{alias.name}}@example.com\&quot;. Currently-supported mappings: alias.name: The name returned by the mount configured via the mount_accessor parameter If blank, the Alias&#x27;s name field will be used as-is. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

