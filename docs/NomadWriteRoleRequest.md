# Vault.Model.NomadWriteRoleRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Global** | **bool** | Boolean value describing if the token should be global or not. Defaults to false. | [optional] 
**Policies** | **List&lt;string&gt;** | Comma-separated string or list of policies as previously created in Nomad. Required for &#39;client&#39; token. | [optional] 
**Type** | **string** | Which type of token to create: &#39;client&#39; or &#39;management&#39;. If a &#39;management&#39; token, the \&quot;policies\&quot; parameter is not required. Defaults to &#39;client&#39;. | [optional] [default to "client"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

