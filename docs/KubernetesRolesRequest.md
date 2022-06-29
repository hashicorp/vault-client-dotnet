# VaultClient.Model.KubernetesRolesRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalMetadata** | **Object** | Additional labels and annotations to apply to all generated object in Kubernetes. | [optional] 
**AllowedKubernetesNamespaces** | **List&lt;string&gt;** | A list of the valid Kubernetes namespaces in which this role can be used for creating service accounts. If set to \&quot;*\&quot; all namespaces are allowed. | 
**GeneratedRoleRules** | **string** | The Role or ClusterRole rules to use when generating a role. Accepts either a JSON or YAML object. If set, the entire chain of Kubernetes objects will be generated. | [optional] 
**KubernetesRoleName** | **string** | The pre-existing Role or ClusterRole to bind a generated service account to. If set, Kubernetes token, service account, and role binding objects will be created. | [optional] 
**KubernetesRoleType** | **string** | Specifies whether the Kubernetes role is a Role or ClusterRole. | [optional] [default to "Role"]
**NameTemplate** | **string** | The name template to use when generating service accounts, roles and role bindings. If unset, a default template is used. | [optional] 
**ServiceAccountName** | **string** | The pre-existing service account to generate tokens for. Mutually exclusive with all role parameters. If set, only a Kubernetes token will be created. | [optional] 
**TokenDefaultTtl** | **int** | The default ttl for generated Kubernetes service accounts. If not set or set to 0, will use system default. | [optional] 
**TokenMaxTtl** | **int** | The maximum valid ttl for generated Kubernetes tokens. If not set or set to 0, will use system default. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

