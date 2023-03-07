# Vault.Model.KubernetesWriteCredentialsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterRoleBinding** | **bool** | If true, generate a ClusterRoleBinding to grant permissions across the whole cluster instead of within a namespace. Requires the Vault role to have kubernetes_role_type set to ClusterRole. | [optional] 
**KubernetesNamespace** | **string** | The name of the Kubernetes namespace in which to generate the credentials | 
**Ttl** | **int** | The TTL of the generated credentials | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

