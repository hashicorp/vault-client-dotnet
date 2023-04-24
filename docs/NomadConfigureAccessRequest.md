# Vault.Model.NomadConfigureAccessRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** | Nomad server address | [optional] 
**CaCert** | **string** | CA certificate to use when verifying Nomad server certificate, must be x509 PEM encoded. | [optional] 
**ClientCert** | **string** | Client certificate used for Nomad&#x27;s TLS communication, must be x509 PEM encoded and if this is set you need to also set client_key. | [optional] 
**ClientKey** | **string** | Client key used for Nomad&#x27;s TLS communication, must be x509 PEM encoded and if this is set you need to also set client_cert. | [optional] 
**MaxTokenNameLength** | **int** | Max length for name of generated Nomad tokens | [optional] 
**Token** | **string** | Token for API calls | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

