# Vault.Model.TransitGenerateDataKeyRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bits** | **int** | Number of bits for the key; currently 128, 256, and 512 bits are supported. Defaults to 256. | [optional] [default to 256]
**Context** | **string** | Context for key derivation. Required for derived keys. | [optional] 
**KeyVersion** | **int** | The version of the Vault key to use for encryption of the data key. Must be 0 (for latest) or a value greater than or equal to the min_encryption_version configured on the key. | [optional] 
**Nonce** | **string** | Nonce for when convergent encryption v1 is used (only in Vault 0.6.1) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

