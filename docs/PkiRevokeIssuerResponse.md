# Vault.Model.PkiRevokeIssuerResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CaChain** | **List&lt;string&gt;** | Certificate Authority Chain | [optional] 
**Certificate** | **string** | Certificate | [optional] 
**CrlDistributionPoints** | **List&lt;string&gt;** | Specifies the URL values for the CRL Distribution Points field | [optional] 
**IssuerId** | **string** | ID of the issuer | [optional] 
**IssuerName** | **string** | Name of the issuer | [optional] 
**IssuingCertificates** | **List&lt;string&gt;** | Specifies the URL values for the Issuing Certificate field | [optional] 
**KeyId** | **string** | ID of the Key | [optional] 
**LeafNotAfterBehavior** | **string** |  | [optional] 
**ManualChain** | **List&lt;string&gt;** | Manual Chain | [optional] 
**OcspServers** | **List&lt;string&gt;** | Specifies the URL values for the OCSP Servers field | [optional] 
**RevocationSignatureAlgorithm** | **string** | Which signature algorithm to use when building CRLs | [optional] 
**RevocationTime** | **long** | Time of revocation | [optional] 
**RevocationTimeRfc3339** | **DateTime** | RFC formatted time of revocation | [optional] 
**Revoked** | **bool** | Whether the issuer was revoked | [optional] 
**Usage** | **string** | Allowed usage | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

