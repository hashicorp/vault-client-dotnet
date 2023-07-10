# Vault.Model.PkiTidyCancelResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcmeAccountDeletedCount** | **int** | The number of revoked acme accounts removed | [optional] 
**AcmeAccountRevokedCount** | **int** | The number of unused acme accounts revoked | [optional] 
**AcmeAccountSafetyBuffer** | **int** | Safety buffer after creation after which accounts lacking orders are revoked | [optional] 
**AcmeOrdersDeletedCount** | **int** | The number of expired, unused acme orders removed | [optional] 
**CertStoreDeletedCount** | **int** | The number of certificate storage entries deleted | [optional] 
**CrossRevokedCertDeletedCount** | **int** |  | [optional] 
**CurrentCertStoreCount** | **int** | The number of revoked certificate entries deleted | [optional] 
**CurrentRevokedCertCount** | **int** | The number of revoked certificate entries deleted | [optional] 
**Error** | **string** | The error message | [optional] 
**InternalBackendUuid** | **string** |  | [optional] 
**IssuerSafetyBuffer** | **int** | Issuer safety buffer | [optional] 
**LastAutoTidyFinished** | **string** | Time the last auto-tidy operation finished | [optional] 
**Message** | **string** | Message of the operation | [optional] 
**MissingIssuerCertCount** | **int** |  | [optional] 
**PauseDuration** | **string** | Duration to pause between tidying certificates | [optional] 
**RevocationQueueDeletedCount** | **int** |  | [optional] 
**RevocationQueueSafetyBuffer** | **int** | Revocation queue safety buffer | [optional] 
**RevokedCertDeletedCount** | **int** | The number of revoked certificate entries deleted | [optional] 
**SafetyBuffer** | **int** | Safety buffer time duration | [optional] 
**State** | **string** | One of Inactive, Running, Finished, or Error | [optional] 
**TidyAcme** | **bool** | Tidy Unused Acme Accounts, and Orders | [optional] 
**TidyCertStore** | **bool** | Tidy certificate store | [optional] 
**TidyCrossClusterRevokedCerts** | **bool** | Tidy the cross-cluster revoked certificate store | [optional] 
**TidyExpiredIssuers** | **bool** | Tidy expired issuers | [optional] 
**TidyMoveLegacyCaBundle** | **bool** |  | [optional] 
**TidyRevocationQueue** | **bool** |  | [optional] 
**TidyRevokedCertIssuerAssociations** | **bool** | Tidy revoked certificate issuer associations | [optional] 
**TidyRevokedCerts** | **bool** | Tidy revoked certificates | [optional] 
**TimeFinished** | **string** | Time the operation finished | [optional] 
**TimeStarted** | **string** | Time the operation started | [optional] 
**TotalAcmeAccountCount** | **int** | Total number of acme accounts iterated over | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

