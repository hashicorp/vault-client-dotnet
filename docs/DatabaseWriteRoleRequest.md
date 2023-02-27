# Vault.Model.DatabaseWriteRoleRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreationStatements** | **List&lt;string&gt;** | Specifies the database statements executed to create and configure a user. See the plugin&#39;s API page for more information on support and formatting for this parameter. | [optional] 
**CredentialConfig** | **Object** | The configuration for the given credential_type. | [optional] 
**CredentialType** | **string** | The type of credential to manage. Options include: &#39;password&#39;, &#39;rsa_private_key&#39;. Defaults to &#39;password&#39;. | [optional] [default to "password"]
**DbName** | **string** | Name of the database this role acts on. | [optional] 
**DefaultTtl** | **int** | Default ttl for role. | [optional] 
**MaxTtl** | **int** | Maximum time a credential is valid for | [optional] 
**RenewStatements** | **List&lt;string&gt;** | Specifies the database statements to be executed to renew a user. Not every plugin type will support this functionality. See the plugin&#39;s API page for more information on support and formatting for this parameter. | [optional] 
**RevocationStatements** | **List&lt;string&gt;** | Specifies the database statements to be executed to revoke a user. See the plugin&#39;s API page for more information on support and formatting for this parameter. | [optional] 
**RollbackStatements** | **List&lt;string&gt;** | Specifies the database statements to be executed rollback a create operation in the event of an error. Not every plugin type will support this functionality. See the plugin&#39;s API page for more information on support and formatting for this parameter. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

