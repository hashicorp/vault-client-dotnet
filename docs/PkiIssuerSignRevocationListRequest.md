# Vault.Model.PkiIssuerSignRevocationListRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CrlNumber** | **int** | The sequence number to be written within the CRL Number extension. | [optional] 
**DeltaCrlBaseNumber** | **int** | Using a zero or greater value specifies the base CRL revision number to encode within a Delta CRL indicator extension, otherwise the extension will not be added. | [optional] [default to -1]
**Extensions** | **List&lt;Object&gt;** | A list of maps containing extensions with keys id (string), critical (bool), value (string) | [optional] 
**Format** | **string** | The format of the combined CRL, can be \&quot;pem\&quot; or \&quot;der\&quot;. If \&quot;der\&quot;, the value will be base64 encoded. Defaults to \&quot;pem\&quot;. | [optional] [default to "pem"]
**NextUpdate** | **string** | The amount of time the generated CRL should be valid; defaults to 72 hours. | [optional] [default to "72h"]
**RevokedCerts** | **List&lt;Object&gt;** | A list of maps containing the keys serial_number (string), revocation_time (string), and extensions (map with keys id (string), critical (bool), value (string)) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

