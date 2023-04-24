# Vault.Model.DatabaseWriteStaticRoleRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CredentialConfig** | **Object** | The configuration for the given credential_type. | [optional] 
**CredentialType** | **string** | The type of credential to manage. Options include: &#x27;password&#x27;, &#x27;rsa_private_key&#x27;. Defaults to &#x27;password&#x27;. | [optional] [default to "password"]
**DbName** | **string** | Name of the database this role acts on. | [optional] 
**RotationPeriod** | **int** | Period for automatic credential rotation of the given username. Not valid unless used with \&quot;username\&quot;. | [optional] 
**RotationStatements** | **List&lt;string&gt;** | Specifies the database statements to be executed to rotate the accounts credentials. Not every plugin type will support this functionality. See the plugin&#x27;s API page for more information on support and formatting for this parameter. | [optional] 
**Username** | **string** | Name of the static user account for Vault to manage. Requires \&quot;rotation_period\&quot; to be specified | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
