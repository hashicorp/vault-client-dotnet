# Vault.Model.OidcWriteKeyRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Algorithm** | **string** | Signing algorithm to use. This will default to RS256. | [optional] [default to "RS256"]
**AllowedClientIds** | **List&lt;string&gt;** | Comma separated string or array of role client ids allowed to use this key for signing. If empty no roles are allowed. If \&quot;*\&quot; all roles are allowed. | [optional] 
**RotationPeriod** | **string** | How often to generate a new keypair. | [optional] [default to "24h"]
**VerificationTtl** | **string** | Controls how long the public portion of a key will be available for verification after being rotated. | [optional] [default to "24h"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

