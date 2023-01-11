# Vault.Model.CertificatesWriteCRLRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Crl** | **string** | The public CRL that should be trusted to attest to certificates&#39; validity statuses. May be DER or PEM encoded. Note: the expiration time is ignored; if the CRL is no longer valid, delete it using the same name as specified here. | [optional] 
**Url** | **string** | The URL of a CRL distribution point. Only one of &#39;crl&#39; or &#39;url&#39; parameters should be specified. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
