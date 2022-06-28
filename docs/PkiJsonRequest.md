# VaultClient.Model.PkiJsonRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IssuerName** | **string** | Provide a name to the generated or existing issuer, the name must be unique across all issuers and not be the reserved value &#39;default&#39; | [optional] 
**IssuerRef** | **string** | Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [optional] [default to "default"]
**LeafNotAfterBehavior** | **string** | Behavior of leaf&#39;s NotAfter fields: \&quot;err\&quot; to error if the computed NotAfter date exceeds that of this issuer; \&quot;truncate\&quot; to silently truncate to that of this issuer; or \&quot;permit\&quot; to allow this issuance to succeed (with NotAfter exceeding that of an issuer). Note that not all values will results in certificates that can be validated through the entire validity period. It is suggested to use \&quot;truncate\&quot; for intermediate CAs and \&quot;permit\&quot; only for root CAs. | [optional] [default to "err"]
**ManualChain** | **List&lt;string&gt;** | Chain of issuer references to use to build this issuer&#39;s computed CAChain field, when non-empty. | [optional] 
**Usage** | **List&lt;string&gt;** | Comma-separated list (or string slice) of usages for this issuer; valid values are \&quot;read-only\&quot;, \&quot;issuing-certificates\&quot;, and \&quot;crl-signing\&quot;. Multiple values may be specified. Read-only is implicit and always set. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

