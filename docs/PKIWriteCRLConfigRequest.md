# Vault.Model.PKIWriteCRLConfigRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoRebuild** | **bool** | If set to true, enables automatic rebuilding of the CRL | [optional] **AutoRebuildGracePeriod** | **string** | The time before the CRL expires to automatically rebuild it, when enabled. Must be shorter than the CRL expiry. Defaults to 12h. | [optional] [default to "12h"]
**DeltaRebuildInterval** | **string** | The time between delta CRL rebuilds if a new revocation has occurred. Must be shorter than the CRL expiry. Defaults to 15m. | [optional] [default to "15m"]
**Disable** | **bool** | If set to true, disables generating the CRL entirely. | [optional] **EnableDelta** | **bool** | Whether to enable delta CRLs between authoritative CRL rebuilds | [optional] **Expiry** | **string** | The amount of time the generated CRL should be valid; defaults to 72 hours | [optional] [default to "72h"]
**OcspDisable** | **bool** | If set to true, ocsp unauthorized responses will be returned. | [optional] **OcspExpiry** | **string** | The amount of time an OCSP response will be valid (controls the NextUpdate field); defaults to 12 hours | [optional] [default to "1h"]


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

