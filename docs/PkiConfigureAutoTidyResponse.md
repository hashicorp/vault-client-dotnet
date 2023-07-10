# Vault.Model.PkiConfigureAutoTidyResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcmeAccountSafetyBuffer** | **int** | Safety buffer after creation after which accounts lacking orders are revoked | [optional] 
**Enabled** | **bool** | Specifies whether automatic tidy is enabled or not | [optional] 
**IntervalDuration** | **int** | Specifies the duration between automatic tidy operation | [optional] 
**IssuerSafetyBuffer** | **int** | Issuer safety buffer | [optional] 
**MaintainStoredCertificateCounts** | **bool** |  | [optional] 
**PauseDuration** | **string** | Duration to pause between tidying certificates | [optional] 
**PublishStoredCertificateCountMetrics** | **bool** |  | [optional] 
**RevocationQueueSafetyBuffer** | **int** |  | [optional] 
**SafetyBuffer** | **int** | Safety buffer time duration | [optional] 
**TidyAcme** | **bool** | Tidy Unused Acme Accounts, and Orders | [optional] 
**TidyCertStore** | **bool** | Specifies whether to tidy up the certificate store | [optional] 
**TidyCrossClusterRevokedCerts** | **bool** | Tidy the cross-cluster revoked certificate store | [optional] 
**TidyExpiredIssuers** | **bool** | Specifies whether tidy expired issuers | [optional] 
**TidyMoveLegacyCaBundle** | **bool** |  | [optional] 
**TidyRevocationQueue** | **bool** |  | [optional] 
**TidyRevokedCertIssuerAssociations** | **bool** | Specifies whether to associate revoked certificates with their corresponding issuers | [optional] 
**TidyRevokedCerts** | **bool** | Specifies whether to remove all invalid and expired certificates from storage | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

