# Vault.Model.ConsulWriteRoleRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConsulNamespace** | **string** | Indicates which namespace that the token will be created within. Defaults to &#39;default&#39;. Available in Consul 1.7 and above. | [optional] 
**ConsulPolicies** | **List&lt;string&gt;** | List of policies to attach to the token. Either \&quot;consul_policies\&quot; or \&quot;consul_roles\&quot; are required for Consul 1.5 and above, or just \&quot;consul_policies\&quot; if using Consul 1.4. | [optional] 
**ConsulRoles** | **List&lt;string&gt;** | List of Consul roles to attach to the token. Either \&quot;policies\&quot; or \&quot;consul_roles\&quot; are required for Consul 1.5 and above. | [optional] 
**Lease** | **int** | Use \&quot;ttl\&quot; instead. | [optional] 
**Local** | **bool** | Indicates that the token should not be replicated globally and instead be local to the current datacenter. Available in Consul 1.4 and above. | [optional] 
**MaxTtl** | **int** | Max TTL for the Consul token created from the role. | [optional] 
**NodeIdentities** | **List&lt;string&gt;** | List of Node Identities to attach to the token. Available in Consul 1.8.1 or above. | [optional] 
**Partition** | **string** | Indicates which admin partition that the token will be created within. Defaults to &#39;default&#39;. Available in Consul 1.11 and above. | [optional] 
**Policies** | **List&lt;string&gt;** | Use \&quot;consul_policies\&quot; instead. | [optional] 
**Policy** | **string** | Policy document, base64 encoded. Required for &#39;client&#39; tokens. Required for Consul pre-1.4. | [optional] 
**ServiceIdentities** | **List&lt;string&gt;** | List of Service Identities to attach to the token, separated by semicolons. Available in Consul 1.5 or above. | [optional] 
**TokenType** | **string** | Which type of token to create: &#39;client&#39; or &#39;management&#39;. If a &#39;management&#39; token, the \&quot;policy\&quot;, \&quot;policies\&quot;, and \&quot;consul_roles\&quot; parameters are not required. Defaults to &#39;client&#39;. | [optional] [default to "client"]
**Ttl** | **int** | TTL for the Consul token created from the role. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

