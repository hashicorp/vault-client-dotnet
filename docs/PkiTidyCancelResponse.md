# Vault.Model.PkiTidyCancelResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CertStoreDeletedCount** | **int** | The number of certificate storage entries deleted | [optional] 
**CrossRevokedCertDeletedCount** | **int** |  | [optional] 
**CurrentCertStoreCount** | **int** | The number of revoked certificate entries deleted | [optional] 
**CurrentRevokedCertCount** | **int** | The number of revoked certificate entries deleted | [optional] 
**Error** | **string** | The error message | [optional] 
**InternalBackendUuid** | **string** |  | [optional] 
**IssuerSafetyBuffer** | **int** | Issuer safety buffer | [optional] 
**Message** | **string** | Message of the operation | [optional] 
**MissingIssuerCertCount** | **int** |  | [optional] 
**PauseDuration** | **string** | Duration to pause between tidying certificates | [optional] 
**RevocationQueueDeletedCount** | **int** |  | [optional] 
**RevokedCertDeletedCount** | **int** | The number of revoked certificate entries deleted | [optional] 
**SafetyBuffer** | **int** | Safety buffer time duration | [optional] 
**State** | **string** | One of Inactive, Running, Finished, or Error | [optional] 
**TidyCertStore** | **bool** | Tidy certificate store | [optional] 
**TidyCrossClusterRevokedCerts** | **bool** |  | [optional] 
**TidyExpiredIssuers** | **bool** | Tidy expired issuers | [optional] 
**TidyMoveLegacyCaBundle** | **bool** |  | [optional] 
**TidyRevocationQueue** | **bool** |  | [optional] 
**TidyRevokedCertIssuerAssociations** | **bool** | Tidy revoked certificate issuer associations | [optional] 
**TidyRevokedCerts** | **bool** | Tidy revoked certificates | [optional] 
**TimeFinished** | **string** | Time the operation finished | [optional] 
**TimeStarted** | **string** | Time the operation started | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

