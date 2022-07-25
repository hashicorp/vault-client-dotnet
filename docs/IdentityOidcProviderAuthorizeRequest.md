# Vault.Model.IdentityOidcProviderAuthorizeRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | The ID of the requesting client. | 
**CodeChallenge** | **string** | The code challenge derived from the code verifier. | [optional] 
**CodeChallengeMethod** | **string** | The method that was used to derive the code challenge. The following methods are supported: &#39;S256&#39;, &#39;plain&#39;. Defaults to &#39;plain&#39;. | [optional] [default to "plain"]
**MaxAge** | **int** | The allowable elapsed time in seconds since the last time the end-user was actively authenticated. | [optional] 
**Nonce** | **string** | The value that will be returned in the ID token nonce claim after a token exchange. | [optional] 
**RedirectUri** | **string** | The redirection URI to which the response will be sent. | 
**ResponseType** | **string** | The OIDC authentication flow to be used. The following response types are supported: &#39;code&#39; | 
**Scope** | **string** | A space-delimited, case-sensitive list of scopes to be requested. The &#39;openid&#39; scope is required. | 
**State** | **string** | The value used to maintain state between the authentication request and client. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

