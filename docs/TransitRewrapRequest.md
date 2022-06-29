# VaultClient.Model.TransitRewrapRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ciphertext** | **string** | Ciphertext value to rewrap | [optional] 
**Context** | **string** | Base64 encoded context for key derivation. Required for derived keys. | [optional] 
**KeyVersion** | **int** | The version of the key to use for encryption. Must be 0 (for latest) or a value greater than or equal to the min_encryption_version configured on the key. | [optional] 
**Nonce** | **string** | Nonce for when convergent encryption is used | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

