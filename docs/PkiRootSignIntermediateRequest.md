# Vault.Model.PkiRootSignIntermediateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AltNames** | **string** | The requested Subject Alternative Names, if any, in a comma-delimited list. May contain both DNS names and email addresses. | [optional] 
**CommonName** | **string** | The requested common name; if you want more than one, specify the alternative names in the alt_names map. If not specified when signing, the common name will be taken from the CSR; other names must still be specified in alt_names or ip_sans. | [optional] 
**Country** | **List&lt;string&gt;** | If set, Country will be set to this value. | [optional] 
**Csr** | **string** | PEM-format CSR to be signed. | [optional] [default to ""]
**ExcludeCnFromSans** | **bool** | If true, the Common Name will not be included in DNS or Email Subject Alternate Names. Defaults to false (CN is included). | [optional] [default to false]
**Format** | **string** | Format for returned data. Can be \&quot;pem\&quot;, \&quot;der\&quot;, or \&quot;pem_bundle\&quot;. If \&quot;pem_bundle\&quot;, any private key and issuing cert will be appended to the certificate pem. If \&quot;der\&quot;, the value will be base64 encoded. Defaults to \&quot;pem\&quot;. | [optional] [default to FormatEnum.Pem]
**IpSans** | **List&lt;string&gt;** | The requested IP SANs, if any, in a comma-delimited list | [optional] 
**IssuerName** | **string** | Provide a name to the generated or existing issuer, the name must be unique across all issuers and not be the reserved value &#39;default&#39; | [optional] 
**IssuerRef** | **string** | Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [optional] [default to "default"]
**Locality** | **List&lt;string&gt;** | If set, Locality will be set to this value. | [optional] 
**MaxPathLength** | **int** | The maximum allowable path length | [optional] [default to -1]
**NotAfter** | **string** | Set the not after field of the certificate with specified date value. The value format should be given in UTC format YYYY-MM-ddTHH:MM:SSZ | [optional] 
**NotBeforeDuration** | **int** | The duration before now which the certificate needs to be backdated by. | [optional] [default to 30]
**Organization** | **List&lt;string&gt;** | If set, O (Organization) will be set to this value. | [optional] 
**OtherSans** | **List&lt;string&gt;** | Requested other SANs, in an array with the format &lt;oid&gt;;UTF8:&lt;utf8 string value&gt; for each entry. | [optional] 
**Ou** | **List&lt;string&gt;** | If set, OU (OrganizationalUnit) will be set to this value. | [optional] 
**PermittedDnsDomains** | **List&lt;string&gt;** | Domains for which this certificate is allowed to sign or issue child certificates. If set, all DNS names (subject and alt) on child certs must be exact matches or subsets of the given domains (see https://tools.ietf.org/html/rfc5280#section-4.2.1.10). | [optional] 
**PostalCode** | **List&lt;string&gt;** | If set, Postal Code will be set to this value. | [optional] 
**PrivateKeyFormat** | **string** | Format for the returned private key. Generally the default will be controlled by the \&quot;format\&quot; parameter as either base64-encoded DER or PEM-encoded DER. However, this can be set to \&quot;pkcs8\&quot; to have the returned private key contain base64-encoded pkcs8 or PEM-encoded pkcs8 instead. Defaults to \&quot;der\&quot;. | [optional] [default to PrivateKeyFormatEnum.Der]
**Province** | **List&lt;string&gt;** | If set, Province will be set to this value. | [optional] 
**SerialNumber** | **string** | The Subject&#39;s requested serial number, if any. See RFC 4519 Section 2.31 &#39;serialNumber&#39; for a description of this field. If you want more than one, specify alternative names in the alt_names map using OID 2.5.4.5. This has no impact on the final certificate&#39;s Serial Number field. | [optional] 
**StreetAddress** | **List&lt;string&gt;** | If set, Street Address will be set to this value. | [optional] 
**Ttl** | **int** | The requested Time To Live for the certificate; sets the expiration date. If not specified the role default, backend default, or system default TTL is used, in that order. Cannot be larger than the mount max TTL. Note: this only has an effect when generating a CA cert or signing a CA cert, not when generating a CSR for an intermediate CA. | [optional] 
**UriSans** | **List&lt;string&gt;** | The requested URI SANs, if any, in a comma-delimited list. | [optional] 
**UseCsrValues** | **bool** | If true, then: 1) Subject information, including names and alternate names, will be preserved from the CSR rather than using values provided in the other parameters to this path; 2) Any key usages requested in the CSR will be added to the basic set of key usages used for CA certs signed by this path; for instance, the non-repudiation flag; 3) Extensions requested in the CSR will be copied into the issued certificate. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

