# Vault.Model.AppRoleWriteSecretIdRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CidrList** | **List&lt;string&gt;** | Comma separated string or list of CIDR blocks enforcing secret IDs to be used from specific set of IP addresses. If &#x27;bound_cidr_list&#x27; is set on the role, then the list of CIDR blocks listed here should be a subset of the CIDR blocks listed on the role. | [optional] 
**Metadata** | **string** | Metadata to be tied to the SecretID. This should be a JSON formatted string containing the metadata in key value pairs. | [optional] 
**NumUses** | **int** | Number of times this SecretID can be used, after which the SecretID expires. Overrides secret_id_num_uses role option when supplied. May not be higher than role&#x27;s secret_id_num_uses. | [optional] 
**TokenBoundCidrs** | **List&lt;string&gt;** | Comma separated string or JSON list of CIDR blocks. If set, specifies the blocks of IP addresses which are allowed to use the generated token. | [optional] 
**Ttl** | **string** | Duration in seconds after which this SecretID expires. Overrides secret_id_ttl role option when supplied. May not be longer than role&#x27;s secret_id_ttl. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

