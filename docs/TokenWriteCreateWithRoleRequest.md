# Vault.Model.TokenWriteCreateWithRoleRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | Name to associate with this token | [optional] 
**EntityAlias** | **string** | Name of the entity alias to associate with this token | [optional] 
**ExplicitMaxTtl** | **string** | Explicit Max TTL of this token | [optional] 
**Id** | **string** | Value for the token | [optional] 
**Metadata** | **Object** | Arbitrary key&#x3D;value metadata to associate with the token | [optional] 
**NoDefaultPolicy** | **bool** | Do not include default policy for this token | [optional] 
**NoParent** | **bool** | Create the token with no parent | [optional] 
**NumUses** | **int** | Max number of uses for this token | [optional] 
**Period** | **string** | Renew period | [optional] 
**Policies** | **List&lt;string&gt;** | List of policies for the token | [optional] 
**Renewable** | **bool** | Allow token to be renewed past its initial TTL up to system/mount maximum TTL | [optional] 
**Ttl** | **string** | Time to live for this token | [optional] 
**Type** | **string** | Token type | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

