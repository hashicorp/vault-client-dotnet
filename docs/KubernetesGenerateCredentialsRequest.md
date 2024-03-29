# Vault.Model.KubernetesGenerateCredentialsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Audiences** | **List&lt;string&gt;** | The intended audiences of the generated credentials | [optional] 
**ClusterRoleBinding** | **bool** | If true, generate a ClusterRoleBinding to grant permissions across the whole cluster instead of within a namespace. Requires the Vault role to have kubernetes_role_type set to ClusterRole. | [optional] 
**KubernetesNamespace** | **string** | The name of the Kubernetes namespace in which to generate the credentials | 
**Ttl** | **string** | The TTL of the generated credentials | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

