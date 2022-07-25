# Vault.Model.GcpLoginRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Jwt** | **string** | A signed JWT. This is either a self-signed service account JWT (&#39;iam&#39; roles only) or a GCE identity metadata token (&#39;iam&#39;, &#39;gce&#39; roles). | [optional] 
**Role** | **string** | Name of the role against which the login is being attempted. Required. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

