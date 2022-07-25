# Vault.Model.SshSignRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CertType** | **string** | Type of certificate to be created; either \&quot;user\&quot; or \&quot;host\&quot;. | [optional] [default to "user"]
**CriticalOptions** | **Object** | Critical options that the certificate should be signed for. | [optional] 
**Extensions** | **Object** | Extensions that the certificate should be signed for. | [optional] 
**KeyId** | **string** | Key id that the created certificate should have. If not specified, the display name of the token will be used. | [optional] 
**PublicKey** | **string** | SSH public key that should be signed. | [optional] 
**Ttl** | **int** | The requested Time To Live for the SSH certificate; sets the expiration date. If not specified the role default, backend default, or system default TTL is used, in that order. Cannot be later than the role max TTL. | [optional] 
**ValidPrincipals** | **string** | Valid principals, either usernames or hostnames, that the certificate should be signed for. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

