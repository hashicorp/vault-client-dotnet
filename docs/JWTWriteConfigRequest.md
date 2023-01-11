# Vault.Model.JWTWriteConfigRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BoundIssuer** | **string** | The value against which to match the &#39;iss&#39; claim in a JWT. Optional. | [optional] 
**DefaultRole** | **string** | The default role to use if none is provided during login. If not set, a role is required during login. | [optional] 
**JwksCaPem** | **string** | The CA certificate or chain of certificates, in PEM format, to use to validate connections to the JWKS URL. If not set, system certificates are used. | [optional] 
**JwksUrl** | **string** | JWKS URL to use to authenticate signatures. Cannot be used with \&quot;oidc_discovery_url\&quot; or \&quot;jwt_validation_pubkeys\&quot;. | [optional] 
**JwtSupportedAlgs** | **List&lt;string&gt;** | A list of supported signing algorithms. Defaults to RS256. | [optional] 
**JwtValidationPubkeys** | **List&lt;string&gt;** | A list of PEM-encoded public keys to use to authenticate signatures locally. Cannot be used with \&quot;jwks_url\&quot; or \&quot;oidc_discovery_url\&quot;. | [optional] 
**NamespaceInState** | **bool** | Pass namespace in the OIDC state parameter instead of as a separate query parameter. With this setting, the allowed redirect URL(s) in Vault and on the provider side should not contain a namespace query parameter. This means only one redirect URL entry needs to be maintained on the provider side for all vault namespaces that will be authenticating against it. Defaults to true for new configs. | [optional] 
**OidcClientId** | **string** | The OAuth Client ID configured with your OIDC provider. | [optional] 
**OidcClientSecret** | **string** | The OAuth Client Secret configured with your OIDC provider. | [optional] 
**OidcDiscoveryCaPem** | **string** | The CA certificate or chain of certificates, in PEM format, to use to validate connections to the OIDC Discovery URL. If not set, system certificates are used. | [optional] 
**OidcDiscoveryUrl** | **string** | OIDC Discovery URL, without any .well-known component (base path). Cannot be used with \&quot;jwks_url\&quot; or \&quot;jwt_validation_pubkeys\&quot;. | [optional] 
**OidcResponseMode** | **string** | The response mode to be used in the OAuth2 request. Allowed values are &#39;query&#39; and &#39;form_post&#39;. | [optional] 
**OidcResponseTypes** | **List&lt;string&gt;** | The response types to request. Allowed values are &#39;code&#39; and &#39;id_token&#39;. Defaults to &#39;code&#39;. | [optional] 
**ProviderConfig** | **Object** | Provider-specific configuration. Optional. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

