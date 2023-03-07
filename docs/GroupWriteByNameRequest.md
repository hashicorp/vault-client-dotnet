# Vault.Model.GroupWriteByNameRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | ID of the group. If set, updates the corresponding existing group. | [optional] **MemberEntityIds** | **List&lt;string&gt;** | Entity IDs to be assigned as group members. | [optional] **MemberGroupIds** | **List&lt;string&gt;** | Group IDs to be assigned as group members. | [optional] **Metadata** | **Object** | Metadata to be associated with the group. In CLI, this parameter can be repeated multiple times, and it all gets merged together. For example: vault &lt;command&gt; &lt;path&gt; metadata&#x3D;key1&#x3D;value1 metadata&#x3D;key2&#x3D;value2 | [optional] **Policies** | **List&lt;string&gt;** | Policies to be tied to the group. | [optional] **Type** | **string** | Type of the group, &#x27;internal&#x27; or &#x27;external&#x27;. Defaults to &#x27;internal&#x27; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

