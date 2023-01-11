# Vault.Model.GroupWriteByIDRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MemberEntityIds** | **List&lt;string&gt;** | Entity IDs to be assigned as group members. | [optional] 
**MemberGroupIds** | **List&lt;string&gt;** | Group IDs to be assigned as group members. | [optional] 
**Metadata** | **Object** | Metadata to be associated with the group. In CLI, this parameter can be repeated multiple times, and it all gets merged together. For example: vault &lt;command&gt; &lt;path&gt; metadata&#x3D;key1&#x3D;value1 metadata&#x3D;key2&#x3D;value2 | [optional] 
**Name** | **string** | Name of the group. | [optional] 
**Policies** | **List&lt;string&gt;** | Policies to be tied to the group. | [optional] 
**Type** | **string** | Type of the group, &#39;internal&#39; or &#39;external&#39;. Defaults to &#39;internal&#39; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

