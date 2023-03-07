# Vault.Model.ConsulWriteAccessConfigRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** | Consul server address | [optional] 
**CaCert** | **string** | CA certificate to use when verifying Consul server certificate, must be x509 PEM encoded. | [optional] 
**ClientCert** | **string** | Client certificate used for Consul&#x27;s TLS communication, must be x509 PEM encoded and if this is set you need to also set client_key. | [optional] 
**ClientKey** | **string** | Client key used for Consul&#x27;s TLS communication, must be x509 PEM encoded and if this is set you need to also set client_cert. | [optional] 
**Scheme** | **string** | URI scheme for the Consul address | [optional] [default to "http"]
**Token** | **string** | Token for API calls | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

