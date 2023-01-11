# Vault.Model.TransitVerifyWithAlgorithmRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Algorithm** | **string** | Deprecated: use \&quot;hash_algorithm\&quot; instead. | [optional] [default to "sha2-256"]
**Context** | **string** | Base64 encoded context for key derivation. Required if key derivation is enabled; currently only available with ed25519 keys. | [optional] 
**HashAlgorithm** | **string** | Hash algorithm to use (POST body parameter). Valid values are: * sha1 * sha2-224 * sha2-256 * sha2-384 * sha2-512 * sha3-224 * sha3-256 * sha3-384 * sha3-512 * none Defaults to \&quot;sha2-256\&quot;. Not valid for all key types. See note about none on signing path. | [optional] [default to "sha2-256"]
**Hmac** | **string** | The HMAC, including vault header/key version | [optional] 
**Input** | **string** | The base64-encoded input data to verify | [optional] 
**MarshalingAlgorithm** | **string** | The method by which to unmarshal the signature when verifying. The default is &#39;asn1&#39; which is used by openssl and X.509; can also be set to &#39;jws&#39; which is used for JWT signatures in which case the signature is also expected to be url-safe base64 encoding instead of standard base64 encoding. Currently only valid for ECDSA P-256 key types\&quot;. | [optional] [default to "asn1"]
**Prehashed** | **bool** | Set to &#39;true&#39; when the input is already hashed. If the key type is &#39;rsa-2048&#39;, &#39;rsa-3072&#39; or &#39;rsa-4096&#39;, then the algorithm used to hash the input should be indicated by the &#39;algorithm&#39; parameter. | [optional] 
**SaltLength** | **string** | The salt length used to sign. Currently only applies to the RSA PSS signature scheme. Options are &#39;auto&#39; (the default used by Golang, causing the salt to be as large as possible when signing), &#39;hash&#39; (causes the salt length to equal the length of the hash used in the signature), or an integer between the minimum and the maximum permissible salt lengths for the given RSA key size. Defaults to &#39;auto&#39;. | [optional] [default to "auto"]
**Signature** | **string** | The signature, including vault header/key version | [optional] 
**SignatureAlgorithm** | **string** | The signature algorithm to use for signature verification. Currently only applies to RSA key types. Options are &#39;pss&#39; or &#39;pkcs1v15&#39;. Defaults to &#39;pss&#39; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

