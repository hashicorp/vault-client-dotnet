# Vault.Model.CloudFoundryConfigureRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CfApiAddr** | **string** | CF’s API address. | [optional] 
**CfApiMutualTlsCertificate** | **string** | The PEM-format certificates that are presented for mutual TLS with the CloudFoundry API. If not set, mutual TLS is not used | [optional] 
**CfApiMutualTlsKey** | **string** | The PEM-format private key that are used for mutual TLS with the CloudFoundry API. If not set, mutual TLS is not used | [optional] 
**CfApiTrustedCertificates** | **List&lt;string&gt;** | The PEM-format CA certificates that are acceptable for the CF API to present. | [optional] 
**CfClientId** | **string** | The client id for CF’s API. | [optional] 
**CfClientSecret** | **string** | The client secret for CF’s API. | [optional] 
**CfPassword** | **string** | The password for CF’s API. | [optional] 
**CfUsername** | **string** | The username for CF’s API. | [optional] 
**IdentityCaCertificates** | **List&lt;string&gt;** | The PEM-format CA certificates that are required to have issued the instance certificates presented for logging in. | [optional] 
**LoginMaxSecondsNotAfter** | **int** | Duration in seconds for the maximum acceptable length in the future a \&quot;signing_time\&quot; can be. Useful for clock drift. Set low to reduce the opportunity for replay attacks. | [optional] [default to 60]
**LoginMaxSecondsNotBefore** | **string** | Duration in seconds for the maximum acceptable age of a \&quot;signing_time\&quot;. Useful for clock drift. Set low to reduce the opportunity for replay attacks. | [optional] [default to "300"]
**PcfApiAddr** | **string** | Deprecated. Please use \&quot;cf_api_addr\&quot;. | [optional] 
**PcfApiTrustedCertificates** | **List&lt;string&gt;** | Deprecated. Please use \&quot;cf_api_trusted_certificates\&quot;. | [optional] 
**PcfPassword** | **string** | Deprecated. Please use \&quot;cf_password\&quot;. | [optional] 
**PcfUsername** | **string** | Deprecated. Please use \&quot;cf_username\&quot;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

