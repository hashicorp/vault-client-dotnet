# Vault.Model.ApproleRoleSecretIdRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CidrList** | **List&lt;string&gt;** | Comma separated string or list of CIDR blocks enforcing secret IDs to be used from specific set of IP addresses. If &#39;bound_cidr_list&#39; is set on the role, then the list of CIDR blocks listed here should be a subset of the CIDR blocks listed on the role. | [optional] 
**Metadata** | **string** | Metadata to be tied to the SecretID. This should be a JSON formatted string containing the metadata in key value pairs. | [optional] 
**TokenBoundCidrs** | **List&lt;string&gt;** | Comma separated string or JSON list of CIDR blocks. If set, specifies the blocks of IP addresses which are allowed to use the generated token. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

