# Vault.Model.AppRoleLookUpSecretIdResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CidrList** | **List&lt;string&gt;** | List of CIDR blocks enforcing secret IDs to be used from specific set of IP addresses. If &#x27;bound_cidr_list&#x27; is set on the role, then the list of CIDR blocks listed here should be a subset of the CIDR blocks listed on the role. | [optional] 
**CreationTime** | **DateTime** |  | [optional] 
**ExpirationTime** | **DateTime** |  | [optional] 
**LastUpdatedTime** | **DateTime** |  | [optional] 
**Metadata** | **Object** |  | [optional] 
**SecretIdAccessor** | **string** | Accessor of the secret ID | [optional] 
**SecretIdNumUses** | **int** | Number of times a secret ID can access the role, after which the secret ID will expire. | [optional] 
**SecretIdTtl** | **string** | Duration in seconds after which the issued secret ID expires. | [optional] 
**TokenBoundCidrs** | **List&lt;string&gt;** | List of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token. Should be a subset of the token CIDR blocks listed on the role, if any. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

