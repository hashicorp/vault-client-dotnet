# Vault.Model.GoogleCloudWriteRolesetRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bindings** | **string** | Bindings configuration string. | [optional] 
**Project** | **string** | Name of the GCP project that this roleset&#39;s service account will belong to. | [optional] 
**SecretType** | **string** | Type of secret generated for this role set. Defaults to &#39;access_token&#39; | [optional] [default to "access_token"]
**TokenScopes** | **List&lt;string&gt;** | List of OAuth scopes to assign to credentials generated under this role set | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

