# Vault.Model.OidcWriteRoleRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | Optional client_id | [optional] 
**Key** | **string** | The OIDC key to use for generating tokens. The specified key must already exist. | 
**Template** | **string** | The template string to use for generating tokens. This may be in string-ified JSON or base64 format. | [optional] 
**Ttl** | **string** | TTL of the tokens generated against the role. | [optional] [default to "24h"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

