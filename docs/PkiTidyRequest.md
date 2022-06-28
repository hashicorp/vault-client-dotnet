# VaultClient.Model.PkiTidyRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SafetyBuffer** | **int** | The amount of extra time that must have passed beyond certificate expiration before it is removed from the backend storage and/or revocation list. Defaults to 72 hours. | [optional] [default to 259200]
**TidyCertStore** | **bool** | Set to true to enable tidying up the certificate store | [optional] 
**TidyRevocationList** | **bool** | Deprecated; synonym for &#39;tidy_revoked_certs | [optional] 
**TidyRevokedCerts** | **bool** | Set to true to expire all revoked and expired certificates, removing them both from the CRL and from storage. The CRL will be rotated if this causes any values to be removed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

