# Vault.Model.TransitWriteKeyConfigRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

**AllowPlaintextBackup** | **bool** | Enables taking a backup of the named key in plaintext format. Once set, this cannot be disabled. | [optional] **AutoRotatePeriod** | **int** | Amount of time the key should live before being automatically rotated. A value of 0 disables automatic rotation for the key. | [optional] **DeletionAllowed** | **bool** | Whether to allow deletion of the key | [optional] **Exportable** | **bool** | Enables export of the key. Once set, this cannot be disabled. | [optional] **MinDecryptionVersion** | **int** | If set, the minimum version of the key allowed to be decrypted. For signing keys, the minimum version allowed to be used for verification. | [optional] **MinEncryptionVersion** | **int** | If set, the minimum version of the key allowed to be used for encryption; or for signing keys, to be used for signing. If set to zero, only the latest version of the key is allowed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

