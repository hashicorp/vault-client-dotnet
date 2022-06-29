# VaultClient.Model.IdentityOidcClientRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessTokenTtl** | **int** | The time-to-live for access tokens obtained by the client. | [optional] 
**Assignments** | **List&lt;string&gt;** | Comma separated string or array of assignment resources. | [optional] 
**ClientType** | **string** | The client type based on its ability to maintain confidentiality of credentials. The following client types are supported: &#39;confidential&#39;, &#39;public&#39;. Defaults to &#39;confidential&#39;. | [optional] [default to "confidential"]
**IdTokenTtl** | **int** | The time-to-live for ID tokens obtained by the client. | [optional] 
**Key** | **string** | A reference to a named key resource. Cannot be modified after creation. Defaults to the &#39;default&#39; key. | [optional] [default to "default"]
**RedirectUris** | **List&lt;string&gt;** | Comma separated string or array of redirect URIs used by the client. One of these values must exactly match the redirect_uri parameter value used in each authentication request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

