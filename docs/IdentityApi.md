# Vault.Api.Identity

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AliasCreate**](IdentityApi.md#aliascreate) | **POST** /identity/alias | Create a new alias.
[**AliasDeleteById**](IdentityApi.md#aliasdeletebyid) | **DELETE** /identity/alias/id/{id} | 
[**AliasListById**](IdentityApi.md#aliaslistbyid) | **GET** /identity/alias/id/ | List all the alias IDs.
[**AliasReadById**](IdentityApi.md#aliasreadbyid) | **GET** /identity/alias/id/{id} | 
[**AliasUpdateById**](IdentityApi.md#aliasupdatebyid) | **POST** /identity/alias/id/{id} | 
[**EntityBatchDelete**](IdentityApi.md#entitybatchdelete) | **POST** /identity/entity/batch-delete | Delete all of the entities provided
[**EntityCreate**](IdentityApi.md#entitycreate) | **POST** /identity/entity | Create a new entity
[**EntityCreateAlias**](IdentityApi.md#entitycreatealias) | **POST** /identity/entity-alias | Create a new alias.
[**EntityDeleteAliasById**](IdentityApi.md#entitydeletealiasbyid) | **DELETE** /identity/entity-alias/id/{id} | 
[**EntityDeleteById**](IdentityApi.md#entitydeletebyid) | **DELETE** /identity/entity/id/{id} | 
[**EntityDeleteByName**](IdentityApi.md#entitydeletebyname) | **DELETE** /identity/entity/name/{name} | 
[**EntityListAliasesById**](IdentityApi.md#entitylistaliasesbyid) | **GET** /identity/entity-alias/id/ | List all the alias IDs.
[**EntityListById**](IdentityApi.md#entitylistbyid) | **GET** /identity/entity/id/ | List all the entity IDs
[**EntityListByName**](IdentityApi.md#entitylistbyname) | **GET** /identity/entity/name/ | List all the entity names
[**EntityLookUp**](IdentityApi.md#entitylookup) | **POST** /identity/lookup/entity | Query entities based on various properties.
[**EntityMerge**](IdentityApi.md#entitymerge) | **POST** /identity/entity/merge | Merge two or more entities together
[**EntityReadAliasById**](IdentityApi.md#entityreadaliasbyid) | **GET** /identity/entity-alias/id/{id} | 
[**EntityReadById**](IdentityApi.md#entityreadbyid) | **GET** /identity/entity/id/{id} | 
[**EntityReadByName**](IdentityApi.md#entityreadbyname) | **GET** /identity/entity/name/{name} | 
[**EntityUpdateAliasById**](IdentityApi.md#entityupdatealiasbyid) | **POST** /identity/entity-alias/id/{id} | 
[**EntityUpdateById**](IdentityApi.md#entityupdatebyid) | **POST** /identity/entity/id/{id} | 
[**EntityUpdateByName**](IdentityApi.md#entityupdatebyname) | **POST** /identity/entity/name/{name} | 
[**GroupCreate**](IdentityApi.md#groupcreate) | **POST** /identity/group | 
[**GroupCreateAlias**](IdentityApi.md#groupcreatealias) | **POST** /identity/group-alias | Creates a new group alias, or updates an existing one.
[**GroupDeleteAliasById**](IdentityApi.md#groupdeletealiasbyid) | **DELETE** /identity/group-alias/id/{id} | 
[**GroupDeleteById**](IdentityApi.md#groupdeletebyid) | **DELETE** /identity/group/id/{id} | 
[**GroupDeleteByName**](IdentityApi.md#groupdeletebyname) | **DELETE** /identity/group/name/{name} | 
[**GroupListAliasesById**](IdentityApi.md#grouplistaliasesbyid) | **GET** /identity/group-alias/id/ | List all the group alias IDs.
[**GroupListById**](IdentityApi.md#grouplistbyid) | **GET** /identity/group/id/ | List all the group IDs.
[**GroupListByName**](IdentityApi.md#grouplistbyname) | **GET** /identity/group/name/ | 
[**GroupLookUp**](IdentityApi.md#grouplookup) | **POST** /identity/lookup/group | Query groups based on various properties.
[**GroupReadAliasById**](IdentityApi.md#groupreadaliasbyid) | **GET** /identity/group-alias/id/{id} | 
[**GroupReadById**](IdentityApi.md#groupreadbyid) | **GET** /identity/group/id/{id} | 
[**GroupReadByName**](IdentityApi.md#groupreadbyname) | **GET** /identity/group/name/{name} | 
[**GroupUpdateAliasById**](IdentityApi.md#groupupdatealiasbyid) | **POST** /identity/group-alias/id/{id} | 
[**GroupUpdateById**](IdentityApi.md#groupupdatebyid) | **POST** /identity/group/id/{id} | 
[**GroupUpdateByName**](IdentityApi.md#groupupdatebyname) | **POST** /identity/group/name/{name} | 
[**MfaAdminDestroyTotpSecret**](IdentityApi.md#mfaadmindestroytotpsecret) | **POST** /identity/mfa/method/totp/admin-destroy | Destroys a TOTP secret for the given MFA method ID on the given entity
[**MfaAdminGenerateTotpSecret**](IdentityApi.md#mfaadmingeneratetotpsecret) | **POST** /identity/mfa/method/totp/admin-generate | Update or create TOTP secret for the given method ID on the given entity.
[**MfaCreateDuoMethod**](IdentityApi.md#mfacreateduomethod) | **POST** /identity/mfa/method/duo | Create the given MFA method
[**MfaCreateOktaMethod**](IdentityApi.md#mfacreateoktamethod) | **POST** /identity/mfa/method/okta | Create the given MFA method
[**MfaCreatePingIdMethod**](IdentityApi.md#mfacreatepingidmethod) | **POST** /identity/mfa/method/pingid | Create the given MFA method
[**MfaCreateTotpMethod**](IdentityApi.md#mfacreatetotpmethod) | **POST** /identity/mfa/method/totp | Create the given MFA method
[**MfaDeleteDuoMethod**](IdentityApi.md#mfadeleteduomethod) | **DELETE** /identity/mfa/method/duo/{method_id} | Delete the given MFA method
[**MfaDeleteLoginEnforcement**](IdentityApi.md#mfadeleteloginenforcement) | **DELETE** /identity/mfa/login-enforcement/{name} | Delete a login enforcement
[**MfaDeleteOktaMethod**](IdentityApi.md#mfadeleteoktamethod) | **DELETE** /identity/mfa/method/okta/{method_id} | Delete the given MFA method
[**MfaDeletePingIdMethod**](IdentityApi.md#mfadeletepingidmethod) | **DELETE** /identity/mfa/method/pingid/{method_id} | Delete the given MFA method
[**MfaDeleteTotpMethod**](IdentityApi.md#mfadeletetotpmethod) | **DELETE** /identity/mfa/method/totp/{method_id} | Delete the given MFA method
[**MfaGenerateTotpSecret**](IdentityApi.md#mfageneratetotpsecret) | **POST** /identity/mfa/method/totp/generate | Update or create TOTP secret for the given method ID on the given entity.
[**MfaListDuoMethods**](IdentityApi.md#mfalistduomethods) | **GET** /identity/mfa/method/duo/ | List MFA method configurations for the given MFA method
[**MfaListLoginEnforcements**](IdentityApi.md#mfalistloginenforcements) | **GET** /identity/mfa/login-enforcement/ | List login enforcements
[**MfaListMethods**](IdentityApi.md#mfalistmethods) | **GET** /identity/mfa/method/ | List MFA method configurations for all MFA methods
[**MfaListOktaMethods**](IdentityApi.md#mfalistoktamethods) | **GET** /identity/mfa/method/okta/ | List MFA method configurations for the given MFA method
[**MfaListPingIdMethods**](IdentityApi.md#mfalistpingidmethods) | **GET** /identity/mfa/method/pingid/ | List MFA method configurations for the given MFA method
[**MfaListTotpMethods**](IdentityApi.md#mfalisttotpmethods) | **GET** /identity/mfa/method/totp/ | List MFA method configurations for the given MFA method
[**MfaReadDuoMethod**](IdentityApi.md#mfareadduomethod) | **GET** /identity/mfa/method/duo/{method_id} | Read the current configuration for the given MFA method
[**MfaReadLoginEnforcement**](IdentityApi.md#mfareadloginenforcement) | **GET** /identity/mfa/login-enforcement/{name} | Read the current login enforcement
[**MfaReadMethod**](IdentityApi.md#mfareadmethod) | **GET** /identity/mfa/method/{method_id} | Read the current configuration for the given ID regardless of the MFA method type
[**MfaReadOktaMethod**](IdentityApi.md#mfareadoktamethod) | **GET** /identity/mfa/method/okta/{method_id} | Read the current configuration for the given MFA method
[**MfaReadPingIdMethod**](IdentityApi.md#mfareadpingidmethod) | **GET** /identity/mfa/method/pingid/{method_id} | Read the current configuration for the given MFA method
[**MfaReadTotpMethod**](IdentityApi.md#mfareadtotpmethod) | **GET** /identity/mfa/method/totp/{method_id} | Read the current configuration for the given MFA method
[**MfaUpdateDuoMethod**](IdentityApi.md#mfaupdateduomethod) | **POST** /identity/mfa/method/duo/{method_id} | Update the configuration for the given MFA method
[**MfaUpdateOktaMethod**](IdentityApi.md#mfaupdateoktamethod) | **POST** /identity/mfa/method/okta/{method_id} | Update the configuration for the given MFA method
[**MfaUpdatePingIdMethod**](IdentityApi.md#mfaupdatepingidmethod) | **POST** /identity/mfa/method/pingid/{method_id} | Update the configuration for the given MFA method
[**MfaUpdateTotpMethod**](IdentityApi.md#mfaupdatetotpmethod) | **POST** /identity/mfa/method/totp/{method_id} | Update the configuration for the given MFA method
[**MfaWriteLoginEnforcement**](IdentityApi.md#mfawriteloginenforcement) | **POST** /identity/mfa/login-enforcement/{name} | Create or update a login enforcement
[**OidcConfigure**](IdentityApi.md#oidcconfigure) | **POST** /identity/oidc/config | 
[**OidcDeleteAssignment**](IdentityApi.md#oidcdeleteassignment) | **DELETE** /identity/oidc/assignment/{name} | 
[**OidcDeleteClient**](IdentityApi.md#oidcdeleteclient) | **DELETE** /identity/oidc/client/{name} | 
[**OidcDeleteKey**](IdentityApi.md#oidcdeletekey) | **DELETE** /identity/oidc/key/{name} | CRUD operations for OIDC keys.
[**OidcDeleteProvider**](IdentityApi.md#oidcdeleteprovider) | **DELETE** /identity/oidc/provider/{name} | 
[**OidcDeleteRole**](IdentityApi.md#oidcdeleterole) | **DELETE** /identity/oidc/role/{name} | CRUD operations on OIDC Roles
[**OidcDeleteScope**](IdentityApi.md#oidcdeletescope) | **DELETE** /identity/oidc/scope/{name} | 
[**OidcGenerateToken**](IdentityApi.md#oidcgeneratetoken) | **GET** /identity/oidc/token/{name} | Generate an OIDC token
[**OidcIntrospect**](IdentityApi.md#oidcintrospect) | **POST** /identity/oidc/introspect | Verify the authenticity of an OIDC token
[**OidcListAssignments**](IdentityApi.md#oidclistassignments) | **GET** /identity/oidc/assignment/ | 
[**OidcListClients**](IdentityApi.md#oidclistclients) | **GET** /identity/oidc/client/ | 
[**OidcListKeys**](IdentityApi.md#oidclistkeys) | **GET** /identity/oidc/key/ | List OIDC keys
[**OidcListProviders**](IdentityApi.md#oidclistproviders) | **GET** /identity/oidc/provider/ | 
[**OidcListRoles**](IdentityApi.md#oidclistroles) | **GET** /identity/oidc/role/ | List configured OIDC roles
[**OidcListScopes**](IdentityApi.md#oidclistscopes) | **GET** /identity/oidc/scope/ | 
[**OidcProviderAuthorize**](IdentityApi.md#oidcproviderauthorize) | **GET** /identity/oidc/provider/{name}/authorize | 
[**OidcProviderAuthorizeWithParameters**](IdentityApi.md#oidcproviderauthorizewithparameters) | **POST** /identity/oidc/provider/{name}/authorize | 
[**OidcProviderToken**](IdentityApi.md#oidcprovidertoken) | **POST** /identity/oidc/provider/{name}/token | 
[**OidcProviderUserInfo**](IdentityApi.md#oidcprovideruserinfo) | **GET** /identity/oidc/provider/{name}/userinfo | 
[**OidcReadAssignment**](IdentityApi.md#oidcreadassignment) | **GET** /identity/oidc/assignment/{name} | 
[**OidcReadClient**](IdentityApi.md#oidcreadclient) | **GET** /identity/oidc/client/{name} | 
[**OidcReadConfiguration**](IdentityApi.md#oidcreadconfiguration) | **GET** /identity/oidc/config | 
[**OidcReadKey**](IdentityApi.md#oidcreadkey) | **GET** /identity/oidc/key/{name} | CRUD operations for OIDC keys.
[**OidcReadOpenIdConfiguration**](IdentityApi.md#oidcreadopenidconfiguration) | **GET** /identity/oidc/.well-known/openid-configuration | Query OIDC configurations
[**OidcReadProvider**](IdentityApi.md#oidcreadprovider) | **GET** /identity/oidc/provider/{name} | 
[**OidcReadProviderOpenIdConfiguration**](IdentityApi.md#oidcreadprovideropenidconfiguration) | **GET** /identity/oidc/provider/{name}/.well-known/openid-configuration | 
[**OidcReadProviderPublicKeys**](IdentityApi.md#oidcreadproviderpublickeys) | **GET** /identity/oidc/provider/{name}/.well-known/keys | 
[**OidcReadPublicKeys**](IdentityApi.md#oidcreadpublickeys) | **GET** /identity/oidc/.well-known/keys | Retrieve public keys
[**OidcReadRole**](IdentityApi.md#oidcreadrole) | **GET** /identity/oidc/role/{name} | CRUD operations on OIDC Roles
[**OidcReadScope**](IdentityApi.md#oidcreadscope) | **GET** /identity/oidc/scope/{name} | 
[**OidcRotateKey**](IdentityApi.md#oidcrotatekey) | **POST** /identity/oidc/key/{name}/rotate | Rotate a named OIDC key.
[**OidcWriteAssignment**](IdentityApi.md#oidcwriteassignment) | **POST** /identity/oidc/assignment/{name} | 
[**OidcWriteClient**](IdentityApi.md#oidcwriteclient) | **POST** /identity/oidc/client/{name} | 
[**OidcWriteKey**](IdentityApi.md#oidcwritekey) | **POST** /identity/oidc/key/{name} | CRUD operations for OIDC keys.
[**OidcWriteProvider**](IdentityApi.md#oidcwriteprovider) | **POST** /identity/oidc/provider/{name} | 
[**OidcWriteRole**](IdentityApi.md#oidcwriterole) | **POST** /identity/oidc/role/{name} | CRUD operations on OIDC Roles
[**OidcWriteScope**](IdentityApi.md#oidcwritescope) | **POST** /identity/oidc/scope/{name} | 
[**PersonaCreate**](IdentityApi.md#personacreate) | **POST** /identity/persona | Create a new alias.
[**PersonaDeleteById**](IdentityApi.md#personadeletebyid) | **DELETE** /identity/persona/id/{id} | 
[**PersonaListById**](IdentityApi.md#personalistbyid) | **GET** /identity/persona/id/ | List all the alias IDs.
[**PersonaReadById**](IdentityApi.md#personareadbyid) | **GET** /identity/persona/id/{id} | 
[**PersonaUpdateById**](IdentityApi.md#personaupdatebyid) | **POST** /identity/persona/id/{id} | 




<a name="aliascreate"></a>
# **AliasCreate**

> void AliasCreate (AliasCreateRequest aliasCreateRequest, TimeSpan? wrapTTL = null)

Create a new alias.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AliasCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            
            var aliasCreateRequest = new AliasCreateRequest(); // AliasCreateRequest | 
            
            

            try
            {
                
                // Create a new alias.
                

                apiInstance.AliasCreate(AliasCreateRequest aliasCreateRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.AliasCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aliasCreateRequest** | [**AliasCreateRequest**](AliasCreateRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="aliasdeletebyid"></a>
# **AliasDeleteById**

> void AliasDeleteById (string id, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AliasDeleteByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var id = "id_example";  // string | ID of the alias
            
            
            

            try
            {
                

                apiInstance.AliasDeleteById(string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.AliasDeleteById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the alias | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | empty body |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="aliaslistbyid"></a>
# **AliasListById**

> StandardListResponse AliasListById (TimeSpan? wrapTTL = null)

List all the alias IDs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AliasListByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // List all the alias IDs.
                

                StandardListResponse result = apiInstance.AliasListById(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.AliasListById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 


### Return type

[**StandardListResponse**](StandardListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="aliasreadbyid"></a>
# **AliasReadById**

> void AliasReadById (string id, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AliasReadByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var id = "id_example";  // string | ID of the alias
            
            
            

            try
            {
                

                apiInstance.AliasReadById(string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.AliasReadById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the alias | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="aliasupdatebyid"></a>
# **AliasUpdateById**

> void AliasUpdateById (string id, AliasUpdateByIdRequest aliasUpdateByIdRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AliasUpdateByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var id = "id_example";  // string | ID of the alias
            
            
            
            
            
            var aliasUpdateByIdRequest = new AliasUpdateByIdRequest(); // AliasUpdateByIdRequest | 
            
            

            try
            {
                

                apiInstance.AliasUpdateById(string id, AliasUpdateByIdRequest aliasUpdateByIdRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.AliasUpdateById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the alias | 
 **aliasUpdateByIdRequest** | [**AliasUpdateByIdRequest**](AliasUpdateByIdRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="entitybatchdelete"></a>
# **EntityBatchDelete**

> void EntityBatchDelete (EntityBatchDeleteRequest entityBatchDeleteRequest, TimeSpan? wrapTTL = null)

Delete all of the entities provided

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class EntityBatchDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            
            var entityBatchDeleteRequest = new EntityBatchDeleteRequest(); // EntityBatchDeleteRequest | 
            
            

            try
            {
                
                // Delete all of the entities provided
                

                apiInstance.EntityBatchDelete(EntityBatchDeleteRequest entityBatchDeleteRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityBatchDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entityBatchDeleteRequest** | [**EntityBatchDeleteRequest**](EntityBatchDeleteRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="entitycreate"></a>
# **EntityCreate**

> void EntityCreate (EntityCreateRequest entityCreateRequest, TimeSpan? wrapTTL = null)

Create a new entity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class EntityCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            
            var entityCreateRequest = new EntityCreateRequest(); // EntityCreateRequest | 
            
            

            try
            {
                
                // Create a new entity
                

                apiInstance.EntityCreate(EntityCreateRequest entityCreateRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entityCreateRequest** | [**EntityCreateRequest**](EntityCreateRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="entitycreatealias"></a>
# **EntityCreateAlias**

> void EntityCreateAlias (EntityCreateAliasRequest entityCreateAliasRequest, TimeSpan? wrapTTL = null)

Create a new alias.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class EntityCreateAliasExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            
            var entityCreateAliasRequest = new EntityCreateAliasRequest(); // EntityCreateAliasRequest | 
            
            

            try
            {
                
                // Create a new alias.
                

                apiInstance.EntityCreateAlias(EntityCreateAliasRequest entityCreateAliasRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityCreateAlias: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entityCreateAliasRequest** | [**EntityCreateAliasRequest**](EntityCreateAliasRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="entitydeletealiasbyid"></a>
# **EntityDeleteAliasById**

> void EntityDeleteAliasById (string id, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class EntityDeleteAliasByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var id = "id_example";  // string | ID of the alias
            
            
            

            try
            {
                

                apiInstance.EntityDeleteAliasById(string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityDeleteAliasById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the alias | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | empty body |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="entitydeletebyid"></a>
# **EntityDeleteById**

> void EntityDeleteById (string id, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class EntityDeleteByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var id = "id_example";  // string | ID of the entity. If set, updates the corresponding existing entity.
            
            
            

            try
            {
                

                apiInstance.EntityDeleteById(string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityDeleteById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the entity. If set, updates the corresponding existing entity. | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | empty body |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="entitydeletebyname"></a>
# **EntityDeleteByName**

> void EntityDeleteByName (string name, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class EntityDeleteByNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the entity
            
            
            

            try
            {
                

                apiInstance.EntityDeleteByName(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityDeleteByName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the entity | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | empty body |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="entitylistaliasesbyid"></a>
# **EntityListAliasesById**

> StandardListResponse EntityListAliasesById (TimeSpan? wrapTTL = null)

List all the alias IDs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class EntityListAliasesByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // List all the alias IDs.
                

                StandardListResponse result = apiInstance.EntityListAliasesById(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityListAliasesById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 


### Return type

[**StandardListResponse**](StandardListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="entitylistbyid"></a>
# **EntityListById**

> StandardListResponse EntityListById (TimeSpan? wrapTTL = null)

List all the entity IDs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class EntityListByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // List all the entity IDs
                

                StandardListResponse result = apiInstance.EntityListById(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityListById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 


### Return type

[**StandardListResponse**](StandardListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="entitylistbyname"></a>
# **EntityListByName**

> StandardListResponse EntityListByName (TimeSpan? wrapTTL = null)

List all the entity names

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class EntityListByNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // List all the entity names
                

                StandardListResponse result = apiInstance.EntityListByName(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityListByName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 


### Return type

[**StandardListResponse**](StandardListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="entitylookup"></a>
# **EntityLookUp**

> void EntityLookUp (EntityLookUpRequest entityLookUpRequest, TimeSpan? wrapTTL = null)

Query entities based on various properties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class EntityLookUpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            
            var entityLookUpRequest = new EntityLookUpRequest(); // EntityLookUpRequest | 
            
            

            try
            {
                
                // Query entities based on various properties.
                

                apiInstance.EntityLookUp(EntityLookUpRequest entityLookUpRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityLookUp: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entityLookUpRequest** | [**EntityLookUpRequest**](EntityLookUpRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="entitymerge"></a>
# **EntityMerge**

> void EntityMerge (EntityMergeRequest entityMergeRequest, TimeSpan? wrapTTL = null)

Merge two or more entities together

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class EntityMergeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            
            var entityMergeRequest = new EntityMergeRequest(); // EntityMergeRequest | 
            
            

            try
            {
                
                // Merge two or more entities together
                

                apiInstance.EntityMerge(EntityMergeRequest entityMergeRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityMerge: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entityMergeRequest** | [**EntityMergeRequest**](EntityMergeRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="entityreadaliasbyid"></a>
# **EntityReadAliasById**

> void EntityReadAliasById (string id, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class EntityReadAliasByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var id = "id_example";  // string | ID of the alias
            
            
            

            try
            {
                

                apiInstance.EntityReadAliasById(string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityReadAliasById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the alias | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="entityreadbyid"></a>
# **EntityReadById**

> void EntityReadById (string id, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class EntityReadByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var id = "id_example";  // string | ID of the entity. If set, updates the corresponding existing entity.
            
            
            

            try
            {
                

                apiInstance.EntityReadById(string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityReadById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the entity. If set, updates the corresponding existing entity. | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="entityreadbyname"></a>
# **EntityReadByName**

> void EntityReadByName (string name, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class EntityReadByNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the entity
            
            
            

            try
            {
                

                apiInstance.EntityReadByName(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityReadByName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the entity | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="entityupdatealiasbyid"></a>
# **EntityUpdateAliasById**

> void EntityUpdateAliasById (string id, EntityUpdateAliasByIdRequest entityUpdateAliasByIdRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class EntityUpdateAliasByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var id = "id_example";  // string | ID of the alias
            
            
            
            
            
            var entityUpdateAliasByIdRequest = new EntityUpdateAliasByIdRequest(); // EntityUpdateAliasByIdRequest | 
            
            

            try
            {
                

                apiInstance.EntityUpdateAliasById(string id, EntityUpdateAliasByIdRequest entityUpdateAliasByIdRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityUpdateAliasById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the alias | 
 **entityUpdateAliasByIdRequest** | [**EntityUpdateAliasByIdRequest**](EntityUpdateAliasByIdRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="entityupdatebyid"></a>
# **EntityUpdateById**

> void EntityUpdateById (string id, EntityUpdateByIdRequest entityUpdateByIdRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class EntityUpdateByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var id = "id_example";  // string | ID of the entity. If set, updates the corresponding existing entity.
            
            
            
            
            
            var entityUpdateByIdRequest = new EntityUpdateByIdRequest(); // EntityUpdateByIdRequest | 
            
            

            try
            {
                

                apiInstance.EntityUpdateById(string id, EntityUpdateByIdRequest entityUpdateByIdRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityUpdateById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the entity. If set, updates the corresponding existing entity. | 
 **entityUpdateByIdRequest** | [**EntityUpdateByIdRequest**](EntityUpdateByIdRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="entityupdatebyname"></a>
# **EntityUpdateByName**

> void EntityUpdateByName (string name, EntityUpdateByNameRequest entityUpdateByNameRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class EntityUpdateByNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the entity
            
            
            
            
            
            var entityUpdateByNameRequest = new EntityUpdateByNameRequest(); // EntityUpdateByNameRequest | 
            
            

            try
            {
                

                apiInstance.EntityUpdateByName(string name, EntityUpdateByNameRequest entityUpdateByNameRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityUpdateByName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the entity | 
 **entityUpdateByNameRequest** | [**EntityUpdateByNameRequest**](EntityUpdateByNameRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="groupcreate"></a>
# **GroupCreate**

> void GroupCreate (GroupCreateRequest groupCreateRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GroupCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            
            var groupCreateRequest = new GroupCreateRequest(); // GroupCreateRequest | 
            
            

            try
            {
                

                apiInstance.GroupCreate(GroupCreateRequest groupCreateRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupCreateRequest** | [**GroupCreateRequest**](GroupCreateRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="groupcreatealias"></a>
# **GroupCreateAlias**

> void GroupCreateAlias (GroupCreateAliasRequest groupCreateAliasRequest, TimeSpan? wrapTTL = null)

Creates a new group alias, or updates an existing one.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GroupCreateAliasExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            
            var groupCreateAliasRequest = new GroupCreateAliasRequest(); // GroupCreateAliasRequest | 
            
            

            try
            {
                
                // Creates a new group alias, or updates an existing one.
                

                apiInstance.GroupCreateAlias(GroupCreateAliasRequest groupCreateAliasRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupCreateAlias: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupCreateAliasRequest** | [**GroupCreateAliasRequest**](GroupCreateAliasRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="groupdeletealiasbyid"></a>
# **GroupDeleteAliasById**

> void GroupDeleteAliasById (string id, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GroupDeleteAliasByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var id = "id_example";  // string | ID of the group alias.
            
            
            

            try
            {
                

                apiInstance.GroupDeleteAliasById(string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupDeleteAliasById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the group alias. | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | empty body |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="groupdeletebyid"></a>
# **GroupDeleteById**

> void GroupDeleteById (string id, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GroupDeleteByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var id = "id_example";  // string | ID of the group. If set, updates the corresponding existing group.
            
            
            

            try
            {
                

                apiInstance.GroupDeleteById(string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupDeleteById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the group. If set, updates the corresponding existing group. | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | empty body |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="groupdeletebyname"></a>
# **GroupDeleteByName**

> void GroupDeleteByName (string name, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GroupDeleteByNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the group.
            
            
            

            try
            {
                

                apiInstance.GroupDeleteByName(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupDeleteByName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the group. | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | empty body |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="grouplistaliasesbyid"></a>
# **GroupListAliasesById**

> StandardListResponse GroupListAliasesById (TimeSpan? wrapTTL = null)

List all the group alias IDs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GroupListAliasesByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // List all the group alias IDs.
                

                StandardListResponse result = apiInstance.GroupListAliasesById(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupListAliasesById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 


### Return type

[**StandardListResponse**](StandardListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="grouplistbyid"></a>
# **GroupListById**

> StandardListResponse GroupListById (TimeSpan? wrapTTL = null)

List all the group IDs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GroupListByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // List all the group IDs.
                

                StandardListResponse result = apiInstance.GroupListById(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupListById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 


### Return type

[**StandardListResponse**](StandardListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="grouplistbyname"></a>
# **GroupListByName**

> StandardListResponse GroupListByName (TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GroupListByNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                StandardListResponse result = apiInstance.GroupListByName(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupListByName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 


### Return type

[**StandardListResponse**](StandardListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="grouplookup"></a>
# **GroupLookUp**

> void GroupLookUp (GroupLookUpRequest groupLookUpRequest, TimeSpan? wrapTTL = null)

Query groups based on various properties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GroupLookUpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            
            var groupLookUpRequest = new GroupLookUpRequest(); // GroupLookUpRequest | 
            
            

            try
            {
                
                // Query groups based on various properties.
                

                apiInstance.GroupLookUp(GroupLookUpRequest groupLookUpRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupLookUp: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupLookUpRequest** | [**GroupLookUpRequest**](GroupLookUpRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="groupreadaliasbyid"></a>
# **GroupReadAliasById**

> void GroupReadAliasById (string id, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GroupReadAliasByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var id = "id_example";  // string | ID of the group alias.
            
            
            

            try
            {
                

                apiInstance.GroupReadAliasById(string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupReadAliasById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the group alias. | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="groupreadbyid"></a>
# **GroupReadById**

> void GroupReadById (string id, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GroupReadByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var id = "id_example";  // string | ID of the group. If set, updates the corresponding existing group.
            
            
            

            try
            {
                

                apiInstance.GroupReadById(string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupReadById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the group. If set, updates the corresponding existing group. | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="groupreadbyname"></a>
# **GroupReadByName**

> void GroupReadByName (string name, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GroupReadByNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the group.
            
            
            

            try
            {
                

                apiInstance.GroupReadByName(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupReadByName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the group. | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="groupupdatealiasbyid"></a>
# **GroupUpdateAliasById**

> void GroupUpdateAliasById (string id, GroupUpdateAliasByIdRequest groupUpdateAliasByIdRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GroupUpdateAliasByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var id = "id_example";  // string | ID of the group alias.
            
            
            
            
            
            var groupUpdateAliasByIdRequest = new GroupUpdateAliasByIdRequest(); // GroupUpdateAliasByIdRequest | 
            
            

            try
            {
                

                apiInstance.GroupUpdateAliasById(string id, GroupUpdateAliasByIdRequest groupUpdateAliasByIdRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupUpdateAliasById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the group alias. | 
 **groupUpdateAliasByIdRequest** | [**GroupUpdateAliasByIdRequest**](GroupUpdateAliasByIdRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="groupupdatebyid"></a>
# **GroupUpdateById**

> void GroupUpdateById (string id, GroupUpdateByIdRequest groupUpdateByIdRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GroupUpdateByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var id = "id_example";  // string | ID of the group. If set, updates the corresponding existing group.
            
            
            
            
            
            var groupUpdateByIdRequest = new GroupUpdateByIdRequest(); // GroupUpdateByIdRequest | 
            
            

            try
            {
                

                apiInstance.GroupUpdateById(string id, GroupUpdateByIdRequest groupUpdateByIdRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupUpdateById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the group. If set, updates the corresponding existing group. | 
 **groupUpdateByIdRequest** | [**GroupUpdateByIdRequest**](GroupUpdateByIdRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="groupupdatebyname"></a>
# **GroupUpdateByName**

> void GroupUpdateByName (string name, GroupUpdateByNameRequest groupUpdateByNameRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GroupUpdateByNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the group.
            
            
            
            
            
            var groupUpdateByNameRequest = new GroupUpdateByNameRequest(); // GroupUpdateByNameRequest | 
            
            

            try
            {
                

                apiInstance.GroupUpdateByName(string name, GroupUpdateByNameRequest groupUpdateByNameRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupUpdateByName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the group. | 
 **groupUpdateByNameRequest** | [**GroupUpdateByNameRequest**](GroupUpdateByNameRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfaadmindestroytotpsecret"></a>
# **MfaAdminDestroyTotpSecret**

> void MfaAdminDestroyTotpSecret (MfaAdminDestroyTotpSecretRequest mfaAdminDestroyTotpSecretRequest, TimeSpan? wrapTTL = null)

Destroys a TOTP secret for the given MFA method ID on the given entity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaAdminDestroyTotpSecretExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            
            var mfaAdminDestroyTotpSecretRequest = new MfaAdminDestroyTotpSecretRequest(); // MfaAdminDestroyTotpSecretRequest | 
            
            

            try
            {
                
                // Destroys a TOTP secret for the given MFA method ID on the given entity
                

                apiInstance.MfaAdminDestroyTotpSecret(MfaAdminDestroyTotpSecretRequest mfaAdminDestroyTotpSecretRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaAdminDestroyTotpSecret: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mfaAdminDestroyTotpSecretRequest** | [**MfaAdminDestroyTotpSecretRequest**](MfaAdminDestroyTotpSecretRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfaadmingeneratetotpsecret"></a>
# **MfaAdminGenerateTotpSecret**

> void MfaAdminGenerateTotpSecret (MfaAdminGenerateTotpSecretRequest mfaAdminGenerateTotpSecretRequest, TimeSpan? wrapTTL = null)

Update or create TOTP secret for the given method ID on the given entity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaAdminGenerateTotpSecretExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            
            var mfaAdminGenerateTotpSecretRequest = new MfaAdminGenerateTotpSecretRequest(); // MfaAdminGenerateTotpSecretRequest | 
            
            

            try
            {
                
                // Update or create TOTP secret for the given method ID on the given entity.
                

                apiInstance.MfaAdminGenerateTotpSecret(MfaAdminGenerateTotpSecretRequest mfaAdminGenerateTotpSecretRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaAdminGenerateTotpSecret: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mfaAdminGenerateTotpSecretRequest** | [**MfaAdminGenerateTotpSecretRequest**](MfaAdminGenerateTotpSecretRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfacreateduomethod"></a>
# **MfaCreateDuoMethod**

> void MfaCreateDuoMethod (MfaCreateDuoMethodRequest mfaCreateDuoMethodRequest, TimeSpan? wrapTTL = null)

Create the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaCreateDuoMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            
            var mfaCreateDuoMethodRequest = new MfaCreateDuoMethodRequest(); // MfaCreateDuoMethodRequest | 
            
            

            try
            {
                
                // Create the given MFA method
                

                apiInstance.MfaCreateDuoMethod(MfaCreateDuoMethodRequest mfaCreateDuoMethodRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaCreateDuoMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mfaCreateDuoMethodRequest** | [**MfaCreateDuoMethodRequest**](MfaCreateDuoMethodRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfacreateoktamethod"></a>
# **MfaCreateOktaMethod**

> void MfaCreateOktaMethod (MfaCreateOktaMethodRequest mfaCreateOktaMethodRequest, TimeSpan? wrapTTL = null)

Create the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaCreateOktaMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            
            var mfaCreateOktaMethodRequest = new MfaCreateOktaMethodRequest(); // MfaCreateOktaMethodRequest | 
            
            

            try
            {
                
                // Create the given MFA method
                

                apiInstance.MfaCreateOktaMethod(MfaCreateOktaMethodRequest mfaCreateOktaMethodRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaCreateOktaMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mfaCreateOktaMethodRequest** | [**MfaCreateOktaMethodRequest**](MfaCreateOktaMethodRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfacreatepingidmethod"></a>
# **MfaCreatePingIdMethod**

> void MfaCreatePingIdMethod (MfaCreatePingIdMethodRequest mfaCreatePingIdMethodRequest, TimeSpan? wrapTTL = null)

Create the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaCreatePingIdMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            
            var mfaCreatePingIdMethodRequest = new MfaCreatePingIdMethodRequest(); // MfaCreatePingIdMethodRequest | 
            
            

            try
            {
                
                // Create the given MFA method
                

                apiInstance.MfaCreatePingIdMethod(MfaCreatePingIdMethodRequest mfaCreatePingIdMethodRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaCreatePingIdMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mfaCreatePingIdMethodRequest** | [**MfaCreatePingIdMethodRequest**](MfaCreatePingIdMethodRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfacreatetotpmethod"></a>
# **MfaCreateTotpMethod**

> void MfaCreateTotpMethod (MfaCreateTotpMethodRequest mfaCreateTotpMethodRequest, TimeSpan? wrapTTL = null)

Create the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaCreateTotpMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            
            var mfaCreateTotpMethodRequest = new MfaCreateTotpMethodRequest(); // MfaCreateTotpMethodRequest | 
            
            

            try
            {
                
                // Create the given MFA method
                

                apiInstance.MfaCreateTotpMethod(MfaCreateTotpMethodRequest mfaCreateTotpMethodRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaCreateTotpMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mfaCreateTotpMethodRequest** | [**MfaCreateTotpMethodRequest**](MfaCreateTotpMethodRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfadeleteduomethod"></a>
# **MfaDeleteDuoMethod**

> void MfaDeleteDuoMethod (string methodId, TimeSpan? wrapTTL = null)

Delete the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaDeleteDuoMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var methodId = "methodId_example";  // string | The unique identifier for this MFA method.
            
            
            

            try
            {
                
                // Delete the given MFA method
                

                apiInstance.MfaDeleteDuoMethod(string methodId, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaDeleteDuoMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **methodId** | **string**| The unique identifier for this MFA method. | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | empty body |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfadeleteloginenforcement"></a>
# **MfaDeleteLoginEnforcement**

> void MfaDeleteLoginEnforcement (string name, TimeSpan? wrapTTL = null)

Delete a login enforcement

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaDeleteLoginEnforcementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name for this login enforcement configuration
            
            
            

            try
            {
                
                // Delete a login enforcement
                

                apiInstance.MfaDeleteLoginEnforcement(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaDeleteLoginEnforcement: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name for this login enforcement configuration | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | empty body |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfadeleteoktamethod"></a>
# **MfaDeleteOktaMethod**

> void MfaDeleteOktaMethod (string methodId, TimeSpan? wrapTTL = null)

Delete the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaDeleteOktaMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var methodId = "methodId_example";  // string | The unique identifier for this MFA method.
            
            
            

            try
            {
                
                // Delete the given MFA method
                

                apiInstance.MfaDeleteOktaMethod(string methodId, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaDeleteOktaMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **methodId** | **string**| The unique identifier for this MFA method. | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | empty body |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfadeletepingidmethod"></a>
# **MfaDeletePingIdMethod**

> void MfaDeletePingIdMethod (string methodId, TimeSpan? wrapTTL = null)

Delete the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaDeletePingIdMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var methodId = "methodId_example";  // string | The unique identifier for this MFA method.
            
            
            

            try
            {
                
                // Delete the given MFA method
                

                apiInstance.MfaDeletePingIdMethod(string methodId, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaDeletePingIdMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **methodId** | **string**| The unique identifier for this MFA method. | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | empty body |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfadeletetotpmethod"></a>
# **MfaDeleteTotpMethod**

> void MfaDeleteTotpMethod (string methodId, TimeSpan? wrapTTL = null)

Delete the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaDeleteTotpMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var methodId = "methodId_example";  // string | The unique identifier for this MFA method.
            
            
            

            try
            {
                
                // Delete the given MFA method
                

                apiInstance.MfaDeleteTotpMethod(string methodId, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaDeleteTotpMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **methodId** | **string**| The unique identifier for this MFA method. | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | empty body |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfageneratetotpsecret"></a>
# **MfaGenerateTotpSecret**

> void MfaGenerateTotpSecret (MfaGenerateTotpSecretRequest mfaGenerateTotpSecretRequest, TimeSpan? wrapTTL = null)

Update or create TOTP secret for the given method ID on the given entity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaGenerateTotpSecretExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            
            var mfaGenerateTotpSecretRequest = new MfaGenerateTotpSecretRequest(); // MfaGenerateTotpSecretRequest | 
            
            

            try
            {
                
                // Update or create TOTP secret for the given method ID on the given entity.
                

                apiInstance.MfaGenerateTotpSecret(MfaGenerateTotpSecretRequest mfaGenerateTotpSecretRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaGenerateTotpSecret: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mfaGenerateTotpSecretRequest** | [**MfaGenerateTotpSecretRequest**](MfaGenerateTotpSecretRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfalistduomethods"></a>
# **MfaListDuoMethods**

> StandardListResponse MfaListDuoMethods (TimeSpan? wrapTTL = null)

List MFA method configurations for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaListDuoMethodsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // List MFA method configurations for the given MFA method
                

                StandardListResponse result = apiInstance.MfaListDuoMethods(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaListDuoMethods: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 


### Return type

[**StandardListResponse**](StandardListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfalistloginenforcements"></a>
# **MfaListLoginEnforcements**

> StandardListResponse MfaListLoginEnforcements (TimeSpan? wrapTTL = null)

List login enforcements

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaListLoginEnforcementsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // List login enforcements
                

                StandardListResponse result = apiInstance.MfaListLoginEnforcements(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaListLoginEnforcements: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 


### Return type

[**StandardListResponse**](StandardListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfalistmethods"></a>
# **MfaListMethods**

> StandardListResponse MfaListMethods (TimeSpan? wrapTTL = null)

List MFA method configurations for all MFA methods

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaListMethodsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // List MFA method configurations for all MFA methods
                

                StandardListResponse result = apiInstance.MfaListMethods(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaListMethods: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 


### Return type

[**StandardListResponse**](StandardListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfalistoktamethods"></a>
# **MfaListOktaMethods**

> StandardListResponse MfaListOktaMethods (TimeSpan? wrapTTL = null)

List MFA method configurations for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaListOktaMethodsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // List MFA method configurations for the given MFA method
                

                StandardListResponse result = apiInstance.MfaListOktaMethods(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaListOktaMethods: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 


### Return type

[**StandardListResponse**](StandardListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfalistpingidmethods"></a>
# **MfaListPingIdMethods**

> StandardListResponse MfaListPingIdMethods (TimeSpan? wrapTTL = null)

List MFA method configurations for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaListPingIdMethodsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // List MFA method configurations for the given MFA method
                

                StandardListResponse result = apiInstance.MfaListPingIdMethods(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaListPingIdMethods: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 


### Return type

[**StandardListResponse**](StandardListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfalisttotpmethods"></a>
# **MfaListTotpMethods**

> StandardListResponse MfaListTotpMethods (TimeSpan? wrapTTL = null)

List MFA method configurations for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaListTotpMethodsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // List MFA method configurations for the given MFA method
                

                StandardListResponse result = apiInstance.MfaListTotpMethods(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaListTotpMethods: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 


### Return type

[**StandardListResponse**](StandardListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfareadduomethod"></a>
# **MfaReadDuoMethod**

> void MfaReadDuoMethod (string methodId, TimeSpan? wrapTTL = null)

Read the current configuration for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaReadDuoMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var methodId = "methodId_example";  // string | The unique identifier for this MFA method.
            
            
            

            try
            {
                
                // Read the current configuration for the given MFA method
                

                apiInstance.MfaReadDuoMethod(string methodId, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaReadDuoMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **methodId** | **string**| The unique identifier for this MFA method. | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfareadloginenforcement"></a>
# **MfaReadLoginEnforcement**

> void MfaReadLoginEnforcement (string name, TimeSpan? wrapTTL = null)

Read the current login enforcement

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaReadLoginEnforcementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name for this login enforcement configuration
            
            
            

            try
            {
                
                // Read the current login enforcement
                

                apiInstance.MfaReadLoginEnforcement(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaReadLoginEnforcement: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name for this login enforcement configuration | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfareadmethod"></a>
# **MfaReadMethod**

> void MfaReadMethod (string methodId, TimeSpan? wrapTTL = null)

Read the current configuration for the given ID regardless of the MFA method type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaReadMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var methodId = "methodId_example";  // string | The unique identifier for this MFA method.
            
            
            

            try
            {
                
                // Read the current configuration for the given ID regardless of the MFA method type
                

                apiInstance.MfaReadMethod(string methodId, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaReadMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **methodId** | **string**| The unique identifier for this MFA method. | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfareadoktamethod"></a>
# **MfaReadOktaMethod**

> void MfaReadOktaMethod (string methodId, TimeSpan? wrapTTL = null)

Read the current configuration for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaReadOktaMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var methodId = "methodId_example";  // string | The unique identifier for this MFA method.
            
            
            

            try
            {
                
                // Read the current configuration for the given MFA method
                

                apiInstance.MfaReadOktaMethod(string methodId, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaReadOktaMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **methodId** | **string**| The unique identifier for this MFA method. | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfareadpingidmethod"></a>
# **MfaReadPingIdMethod**

> void MfaReadPingIdMethod (string methodId, TimeSpan? wrapTTL = null)

Read the current configuration for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaReadPingIdMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var methodId = "methodId_example";  // string | The unique identifier for this MFA method.
            
            
            

            try
            {
                
                // Read the current configuration for the given MFA method
                

                apiInstance.MfaReadPingIdMethod(string methodId, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaReadPingIdMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **methodId** | **string**| The unique identifier for this MFA method. | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfareadtotpmethod"></a>
# **MfaReadTotpMethod**

> void MfaReadTotpMethod (string methodId, TimeSpan? wrapTTL = null)

Read the current configuration for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaReadTotpMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var methodId = "methodId_example";  // string | The unique identifier for this MFA method.
            
            
            

            try
            {
                
                // Read the current configuration for the given MFA method
                

                apiInstance.MfaReadTotpMethod(string methodId, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaReadTotpMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **methodId** | **string**| The unique identifier for this MFA method. | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfaupdateduomethod"></a>
# **MfaUpdateDuoMethod**

> void MfaUpdateDuoMethod (string methodId, MfaUpdateDuoMethodRequest mfaUpdateDuoMethodRequest, TimeSpan? wrapTTL = null)

Update the configuration for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaUpdateDuoMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var methodId = "methodId_example";  // string | The unique identifier for this MFA method.
            
            
            
            
            
            var mfaUpdateDuoMethodRequest = new MfaUpdateDuoMethodRequest(); // MfaUpdateDuoMethodRequest | 
            
            

            try
            {
                
                // Update the configuration for the given MFA method
                

                apiInstance.MfaUpdateDuoMethod(string methodId, MfaUpdateDuoMethodRequest mfaUpdateDuoMethodRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaUpdateDuoMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **methodId** | **string**| The unique identifier for this MFA method. | 
 **mfaUpdateDuoMethodRequest** | [**MfaUpdateDuoMethodRequest**](MfaUpdateDuoMethodRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfaupdateoktamethod"></a>
# **MfaUpdateOktaMethod**

> void MfaUpdateOktaMethod (string methodId, MfaUpdateOktaMethodRequest mfaUpdateOktaMethodRequest, TimeSpan? wrapTTL = null)

Update the configuration for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaUpdateOktaMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var methodId = "methodId_example";  // string | The unique identifier for this MFA method.
            
            
            
            
            
            var mfaUpdateOktaMethodRequest = new MfaUpdateOktaMethodRequest(); // MfaUpdateOktaMethodRequest | 
            
            

            try
            {
                
                // Update the configuration for the given MFA method
                

                apiInstance.MfaUpdateOktaMethod(string methodId, MfaUpdateOktaMethodRequest mfaUpdateOktaMethodRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaUpdateOktaMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **methodId** | **string**| The unique identifier for this MFA method. | 
 **mfaUpdateOktaMethodRequest** | [**MfaUpdateOktaMethodRequest**](MfaUpdateOktaMethodRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfaupdatepingidmethod"></a>
# **MfaUpdatePingIdMethod**

> void MfaUpdatePingIdMethod (string methodId, MfaUpdatePingIdMethodRequest mfaUpdatePingIdMethodRequest, TimeSpan? wrapTTL = null)

Update the configuration for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaUpdatePingIdMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var methodId = "methodId_example";  // string | The unique identifier for this MFA method.
            
            
            
            
            
            var mfaUpdatePingIdMethodRequest = new MfaUpdatePingIdMethodRequest(); // MfaUpdatePingIdMethodRequest | 
            
            

            try
            {
                
                // Update the configuration for the given MFA method
                

                apiInstance.MfaUpdatePingIdMethod(string methodId, MfaUpdatePingIdMethodRequest mfaUpdatePingIdMethodRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaUpdatePingIdMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **methodId** | **string**| The unique identifier for this MFA method. | 
 **mfaUpdatePingIdMethodRequest** | [**MfaUpdatePingIdMethodRequest**](MfaUpdatePingIdMethodRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfaupdatetotpmethod"></a>
# **MfaUpdateTotpMethod**

> void MfaUpdateTotpMethod (string methodId, MfaUpdateTotpMethodRequest mfaUpdateTotpMethodRequest, TimeSpan? wrapTTL = null)

Update the configuration for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaUpdateTotpMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var methodId = "methodId_example";  // string | The unique identifier for this MFA method.
            
            
            
            
            
            var mfaUpdateTotpMethodRequest = new MfaUpdateTotpMethodRequest(); // MfaUpdateTotpMethodRequest | 
            
            

            try
            {
                
                // Update the configuration for the given MFA method
                

                apiInstance.MfaUpdateTotpMethod(string methodId, MfaUpdateTotpMethodRequest mfaUpdateTotpMethodRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaUpdateTotpMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **methodId** | **string**| The unique identifier for this MFA method. | 
 **mfaUpdateTotpMethodRequest** | [**MfaUpdateTotpMethodRequest**](MfaUpdateTotpMethodRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mfawriteloginenforcement"></a>
# **MfaWriteLoginEnforcement**

> void MfaWriteLoginEnforcement (string name, MfaWriteLoginEnforcementRequest mfaWriteLoginEnforcementRequest, TimeSpan? wrapTTL = null)

Create or update a login enforcement

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MfaWriteLoginEnforcementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name for this login enforcement configuration
            
            
            
            
            
            var mfaWriteLoginEnforcementRequest = new MfaWriteLoginEnforcementRequest(); // MfaWriteLoginEnforcementRequest | 
            
            

            try
            {
                
                // Create or update a login enforcement
                

                apiInstance.MfaWriteLoginEnforcement(string name, MfaWriteLoginEnforcementRequest mfaWriteLoginEnforcementRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MfaWriteLoginEnforcement: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name for this login enforcement configuration | 
 **mfaWriteLoginEnforcementRequest** | [**MfaWriteLoginEnforcementRequest**](MfaWriteLoginEnforcementRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcconfigure"></a>
# **OidcConfigure**

> void OidcConfigure (OidcConfigureRequest oidcConfigureRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            
            var oidcConfigureRequest = new OidcConfigureRequest(); // OidcConfigureRequest | 
            
            

            try
            {
                

                apiInstance.OidcConfigure(OidcConfigureRequest oidcConfigureRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcConfigure: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oidcConfigureRequest** | [**OidcConfigureRequest**](OidcConfigureRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcdeleteassignment"></a>
# **OidcDeleteAssignment**

> void OidcDeleteAssignment (string name, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcDeleteAssignmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the assignment
            
            
            

            try
            {
                

                apiInstance.OidcDeleteAssignment(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcDeleteAssignment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the assignment | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | empty body |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcdeleteclient"></a>
# **OidcDeleteClient**

> void OidcDeleteClient (string name, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcDeleteClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the client.
            
            
            

            try
            {
                

                apiInstance.OidcDeleteClient(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcDeleteClient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the client. | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | empty body |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcdeletekey"></a>
# **OidcDeleteKey**

> void OidcDeleteKey (string name, TimeSpan? wrapTTL = null)

CRUD operations for OIDC keys.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcDeleteKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the key
            
            
            

            try
            {
                
                // CRUD operations for OIDC keys.
                

                apiInstance.OidcDeleteKey(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcDeleteKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the key | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | empty body |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcdeleteprovider"></a>
# **OidcDeleteProvider**

> void OidcDeleteProvider (string name, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcDeleteProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the provider
            
            
            

            try
            {
                

                apiInstance.OidcDeleteProvider(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcDeleteProvider: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the provider | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | empty body |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcdeleterole"></a>
# **OidcDeleteRole**

> void OidcDeleteRole (string name, TimeSpan? wrapTTL = null)

CRUD operations on OIDC Roles

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcDeleteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            

            try
            {
                
                // CRUD operations on OIDC Roles
                

                apiInstance.OidcDeleteRole(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcDeleteRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the role | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | empty body |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcdeletescope"></a>
# **OidcDeleteScope**

> void OidcDeleteScope (string name, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcDeleteScopeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the scope
            
            
            

            try
            {
                

                apiInstance.OidcDeleteScope(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcDeleteScope: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the scope | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | empty body |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcgeneratetoken"></a>
# **OidcGenerateToken**

> void OidcGenerateToken (string name, TimeSpan? wrapTTL = null)

Generate an OIDC token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcGenerateTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            

            try
            {
                
                // Generate an OIDC token
                

                apiInstance.OidcGenerateToken(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcGenerateToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the role | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcintrospect"></a>
# **OidcIntrospect**

> void OidcIntrospect (OidcIntrospectRequest oidcIntrospectRequest, TimeSpan? wrapTTL = null)

Verify the authenticity of an OIDC token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcIntrospectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            
            var oidcIntrospectRequest = new OidcIntrospectRequest(); // OidcIntrospectRequest | 
            
            

            try
            {
                
                // Verify the authenticity of an OIDC token
                

                apiInstance.OidcIntrospect(OidcIntrospectRequest oidcIntrospectRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcIntrospect: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oidcIntrospectRequest** | [**OidcIntrospectRequest**](OidcIntrospectRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidclistassignments"></a>
# **OidcListAssignments**

> StandardListResponse OidcListAssignments (TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcListAssignmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                StandardListResponse result = apiInstance.OidcListAssignments(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcListAssignments: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 


### Return type

[**StandardListResponse**](StandardListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidclistclients"></a>
# **OidcListClients**

> StandardListResponse OidcListClients (TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcListClientsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                StandardListResponse result = apiInstance.OidcListClients(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcListClients: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 


### Return type

[**StandardListResponse**](StandardListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidclistkeys"></a>
# **OidcListKeys**

> StandardListResponse OidcListKeys (TimeSpan? wrapTTL = null)

List OIDC keys

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcListKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // List OIDC keys
                

                StandardListResponse result = apiInstance.OidcListKeys(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcListKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 


### Return type

[**StandardListResponse**](StandardListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidclistproviders"></a>
# **OidcListProviders**

> StandardListResponse OidcListProviders (string allowedClientId = default(string), TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcListProvidersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            
            
            var allowedClientId = "\"\"";  // string | Filters the list of OIDC providers to those that allow the given client ID in their set of allowed_client_ids. (optional)  (default to "")
            
            
            

            try
            {
                

                StandardListResponse result = apiInstance.OidcListProviders(string allowedClientId = default(string), TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcListProviders: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 
 **allowedClientId** | **string**| Filters the list of OIDC providers to those that allow the given client ID in their set of allowed_client_ids. | [optional] [default to &quot;&quot;]


### Return type

[**StandardListResponse**](StandardListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidclistroles"></a>
# **OidcListRoles**

> StandardListResponse OidcListRoles (TimeSpan? wrapTTL = null)

List configured OIDC roles

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // List configured OIDC roles
                

                StandardListResponse result = apiInstance.OidcListRoles(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcListRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 


### Return type

[**StandardListResponse**](StandardListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidclistscopes"></a>
# **OidcListScopes**

> StandardListResponse OidcListScopes (TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcListScopesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                StandardListResponse result = apiInstance.OidcListScopes(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcListScopes: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 


### Return type

[**StandardListResponse**](StandardListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcproviderauthorize"></a>
# **OidcProviderAuthorize**

> void OidcProviderAuthorize (string name, string clientId = default(string), string codeChallenge = default(string), string codeChallengeMethod = default(string), int? maxAge = default(int?), string nonce = default(string), string redirectUri = default(string), string responseType = default(string), string scope = default(string), string state = default(string), TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcProviderAuthorizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the provider
            
            
            
            
            var clientId = "clientId_example";  // string | The ID of the requesting client. (optional) 
            
            
            
            
            var codeChallenge = "codeChallenge_example";  // string | The code challenge derived from the code verifier. (optional) 
            
            
            
            
            var codeChallengeMethod = "\"plain\"";  // string | The method that was used to derive the code challenge. The following methods are supported: 'S256', 'plain'. Defaults to 'plain'. (optional)  (default to "plain")
            
            
            
            
            var maxAge = 56;  // int? | The allowable elapsed time in seconds since the last time the end-user was actively authenticated. (optional) 
            
            
            
            
            var nonce = "nonce_example";  // string | The value that will be returned in the ID token nonce claim after a token exchange. (optional) 
            
            
            
            
            var redirectUri = "redirectUri_example";  // string | The redirection URI to which the response will be sent. (optional) 
            
            
            
            
            var responseType = "responseType_example";  // string | The OIDC authentication flow to be used. The following response types are supported: 'code' (optional) 
            
            
            
            
            var scope = "scope_example";  // string | A space-delimited, case-sensitive list of scopes to be requested. The 'openid' scope is required. (optional) 
            
            
            
            
            var state = "state_example";  // string | The value used to maintain state between the authentication request and client. (optional) 
            
            
            

            try
            {
                

                apiInstance.OidcProviderAuthorize(string name, string clientId = default(string), string codeChallenge = default(string), string codeChallengeMethod = default(string), int? maxAge = default(int?), string nonce = default(string), string redirectUri = default(string), string responseType = default(string), string scope = default(string), string state = default(string), TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcProviderAuthorize: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the provider | 
 **clientId** | **string**| The ID of the requesting client. | [optional] 
 **codeChallenge** | **string**| The code challenge derived from the code verifier. | [optional] 
 **codeChallengeMethod** | **string**| The method that was used to derive the code challenge. The following methods are supported: &#x27;S256&#x27;, &#x27;plain&#x27;. Defaults to &#x27;plain&#x27;. | [optional] [default to &quot;plain&quot;]
 **maxAge** | **int?**| The allowable elapsed time in seconds since the last time the end-user was actively authenticated. | [optional] 
 **nonce** | **string**| The value that will be returned in the ID token nonce claim after a token exchange. | [optional] 
 **redirectUri** | **string**| The redirection URI to which the response will be sent. | [optional] 
 **responseType** | **string**| The OIDC authentication flow to be used. The following response types are supported: &#x27;code&#x27; | [optional] 
 **scope** | **string**| A space-delimited, case-sensitive list of scopes to be requested. The &#x27;openid&#x27; scope is required. | [optional] 
 **state** | **string**| The value used to maintain state between the authentication request and client. | [optional] 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcproviderauthorizewithparameters"></a>
# **OidcProviderAuthorizeWithParameters**

> void OidcProviderAuthorizeWithParameters (string name, OidcProviderAuthorizeWithParametersRequest oidcProviderAuthorizeWithParametersRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcProviderAuthorizeWithParametersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the provider
            
            
            
            
            
            var oidcProviderAuthorizeWithParametersRequest = new OidcProviderAuthorizeWithParametersRequest(); // OidcProviderAuthorizeWithParametersRequest | 
            
            

            try
            {
                

                apiInstance.OidcProviderAuthorizeWithParameters(string name, OidcProviderAuthorizeWithParametersRequest oidcProviderAuthorizeWithParametersRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcProviderAuthorizeWithParameters: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the provider | 
 **oidcProviderAuthorizeWithParametersRequest** | [**OidcProviderAuthorizeWithParametersRequest**](OidcProviderAuthorizeWithParametersRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcprovidertoken"></a>
# **OidcProviderToken**

> void OidcProviderToken (string name, OidcProviderTokenRequest oidcProviderTokenRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcProviderTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the provider
            
            
            
            
            
            var oidcProviderTokenRequest = new OidcProviderTokenRequest(); // OidcProviderTokenRequest | 
            
            

            try
            {
                

                apiInstance.OidcProviderToken(string name, OidcProviderTokenRequest oidcProviderTokenRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcProviderToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the provider | 
 **oidcProviderTokenRequest** | [**OidcProviderTokenRequest**](OidcProviderTokenRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcprovideruserinfo"></a>
# **OidcProviderUserInfo**

> void OidcProviderUserInfo (string name, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcProviderUserInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the provider
            
            
            

            try
            {
                

                apiInstance.OidcProviderUserInfo(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcProviderUserInfo: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the provider | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcreadassignment"></a>
# **OidcReadAssignment**

> void OidcReadAssignment (string name, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcReadAssignmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the assignment
            
            
            

            try
            {
                

                apiInstance.OidcReadAssignment(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcReadAssignment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the assignment | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcreadclient"></a>
# **OidcReadClient**

> void OidcReadClient (string name, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcReadClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the client.
            
            
            

            try
            {
                

                apiInstance.OidcReadClient(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcReadClient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the client. | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcreadconfiguration"></a>
# **OidcReadConfiguration**

> void OidcReadConfiguration (TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcReadConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            

            try
            {
                

                apiInstance.OidcReadConfiguration(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcReadConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcreadkey"></a>
# **OidcReadKey**

> void OidcReadKey (string name, TimeSpan? wrapTTL = null)

CRUD operations for OIDC keys.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcReadKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the key
            
            
            

            try
            {
                
                // CRUD operations for OIDC keys.
                

                apiInstance.OidcReadKey(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcReadKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the key | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcreadopenidconfiguration"></a>
# **OidcReadOpenIdConfiguration**

> void OidcReadOpenIdConfiguration (TimeSpan? wrapTTL = null)

Query OIDC configurations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcReadOpenIdConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            

            try
            {
                
                // Query OIDC configurations
                

                apiInstance.OidcReadOpenIdConfiguration(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcReadOpenIdConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcreadprovider"></a>
# **OidcReadProvider**

> void OidcReadProvider (string name, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcReadProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the provider
            
            
            

            try
            {
                

                apiInstance.OidcReadProvider(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcReadProvider: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the provider | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcreadprovideropenidconfiguration"></a>
# **OidcReadProviderOpenIdConfiguration**

> void OidcReadProviderOpenIdConfiguration (string name, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcReadProviderOpenIdConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the provider
            
            
            

            try
            {
                

                apiInstance.OidcReadProviderOpenIdConfiguration(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcReadProviderOpenIdConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the provider | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcreadproviderpublickeys"></a>
# **OidcReadProviderPublicKeys**

> void OidcReadProviderPublicKeys (string name, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcReadProviderPublicKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the provider
            
            
            

            try
            {
                

                apiInstance.OidcReadProviderPublicKeys(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcReadProviderPublicKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the provider | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcreadpublickeys"></a>
# **OidcReadPublicKeys**

> void OidcReadPublicKeys (TimeSpan? wrapTTL = null)

Retrieve public keys

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcReadPublicKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            

            try
            {
                
                // Retrieve public keys
                

                apiInstance.OidcReadPublicKeys(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcReadPublicKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcreadrole"></a>
# **OidcReadRole**

> void OidcReadRole (string name, TimeSpan? wrapTTL = null)

CRUD operations on OIDC Roles

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcReadRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            

            try
            {
                
                // CRUD operations on OIDC Roles
                

                apiInstance.OidcReadRole(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcReadRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the role | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcreadscope"></a>
# **OidcReadScope**

> void OidcReadScope (string name, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcReadScopeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the scope
            
            
            

            try
            {
                

                apiInstance.OidcReadScope(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcReadScope: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the scope | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcrotatekey"></a>
# **OidcRotateKey**

> void OidcRotateKey (string name, OidcRotateKeyRequest oidcRotateKeyRequest, TimeSpan? wrapTTL = null)

Rotate a named OIDC key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcRotateKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the key
            
            
            
            
            
            var oidcRotateKeyRequest = new OidcRotateKeyRequest(); // OidcRotateKeyRequest | 
            
            

            try
            {
                
                // Rotate a named OIDC key.
                

                apiInstance.OidcRotateKey(string name, OidcRotateKeyRequest oidcRotateKeyRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcRotateKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the key | 
 **oidcRotateKeyRequest** | [**OidcRotateKeyRequest**](OidcRotateKeyRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcwriteassignment"></a>
# **OidcWriteAssignment**

> void OidcWriteAssignment (string name, OidcWriteAssignmentRequest oidcWriteAssignmentRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcWriteAssignmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the assignment
            
            
            
            
            
            var oidcWriteAssignmentRequest = new OidcWriteAssignmentRequest(); // OidcWriteAssignmentRequest | 
            
            

            try
            {
                

                apiInstance.OidcWriteAssignment(string name, OidcWriteAssignmentRequest oidcWriteAssignmentRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcWriteAssignment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the assignment | 
 **oidcWriteAssignmentRequest** | [**OidcWriteAssignmentRequest**](OidcWriteAssignmentRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcwriteclient"></a>
# **OidcWriteClient**

> void OidcWriteClient (string name, OidcWriteClientRequest oidcWriteClientRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcWriteClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the client.
            
            
            
            
            
            var oidcWriteClientRequest = new OidcWriteClientRequest(); // OidcWriteClientRequest | 
            
            

            try
            {
                

                apiInstance.OidcWriteClient(string name, OidcWriteClientRequest oidcWriteClientRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcWriteClient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the client. | 
 **oidcWriteClientRequest** | [**OidcWriteClientRequest**](OidcWriteClientRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcwritekey"></a>
# **OidcWriteKey**

> void OidcWriteKey (string name, OidcWriteKeyRequest oidcWriteKeyRequest, TimeSpan? wrapTTL = null)

CRUD operations for OIDC keys.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcWriteKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the key
            
            
            
            
            
            var oidcWriteKeyRequest = new OidcWriteKeyRequest(); // OidcWriteKeyRequest | 
            
            

            try
            {
                
                // CRUD operations for OIDC keys.
                

                apiInstance.OidcWriteKey(string name, OidcWriteKeyRequest oidcWriteKeyRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcWriteKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the key | 
 **oidcWriteKeyRequest** | [**OidcWriteKeyRequest**](OidcWriteKeyRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcwriteprovider"></a>
# **OidcWriteProvider**

> void OidcWriteProvider (string name, OidcWriteProviderRequest oidcWriteProviderRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcWriteProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the provider
            
            
            
            
            
            var oidcWriteProviderRequest = new OidcWriteProviderRequest(); // OidcWriteProviderRequest | 
            
            

            try
            {
                

                apiInstance.OidcWriteProvider(string name, OidcWriteProviderRequest oidcWriteProviderRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcWriteProvider: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the provider | 
 **oidcWriteProviderRequest** | [**OidcWriteProviderRequest**](OidcWriteProviderRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcwriterole"></a>
# **OidcWriteRole**

> void OidcWriteRole (string name, OidcWriteRoleRequest oidcWriteRoleRequest, TimeSpan? wrapTTL = null)

CRUD operations on OIDC Roles

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcWriteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            
            
            
            var oidcWriteRoleRequest = new OidcWriteRoleRequest(); // OidcWriteRoleRequest | 
            
            

            try
            {
                
                // CRUD operations on OIDC Roles
                

                apiInstance.OidcWriteRole(string name, OidcWriteRoleRequest oidcWriteRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcWriteRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the role | 
 **oidcWriteRoleRequest** | [**OidcWriteRoleRequest**](OidcWriteRoleRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="oidcwritescope"></a>
# **OidcWriteScope**

> void OidcWriteScope (string name, OidcWriteScopeRequest oidcWriteScopeRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OidcWriteScopeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the scope
            
            
            
            
            
            var oidcWriteScopeRequest = new OidcWriteScopeRequest(); // OidcWriteScopeRequest | 
            
            

            try
            {
                

                apiInstance.OidcWriteScope(string name, OidcWriteScopeRequest oidcWriteScopeRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OidcWriteScope: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the scope | 
 **oidcWriteScopeRequest** | [**OidcWriteScopeRequest**](OidcWriteScopeRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="personacreate"></a>
# **PersonaCreate**

> void PersonaCreate (PersonaCreateRequest personaCreateRequest, TimeSpan? wrapTTL = null)

Create a new alias.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PersonaCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            
            var personaCreateRequest = new PersonaCreateRequest(); // PersonaCreateRequest | 
            
            

            try
            {
                
                // Create a new alias.
                

                apiInstance.PersonaCreate(PersonaCreateRequest personaCreateRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PersonaCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personaCreateRequest** | [**PersonaCreateRequest**](PersonaCreateRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="personadeletebyid"></a>
# **PersonaDeleteById**

> void PersonaDeleteById (string id, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PersonaDeleteByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var id = "id_example";  // string | ID of the persona
            
            
            

            try
            {
                

                apiInstance.PersonaDeleteById(string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PersonaDeleteById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the persona | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | empty body |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="personalistbyid"></a>
# **PersonaListById**

> StandardListResponse PersonaListById (TimeSpan? wrapTTL = null)

List all the alias IDs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PersonaListByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // List all the alias IDs.
                

                StandardListResponse result = apiInstance.PersonaListById(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PersonaListById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 


### Return type

[**StandardListResponse**](StandardListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="personareadbyid"></a>
# **PersonaReadById**

> void PersonaReadById (string id, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PersonaReadByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var id = "id_example";  // string | ID of the persona
            
            
            

            try
            {
                

                apiInstance.PersonaReadById(string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PersonaReadById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the persona | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="personaupdatebyid"></a>
# **PersonaUpdateById**

> void PersonaUpdateById (string id, PersonaUpdateByIdRequest personaUpdateByIdRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PersonaUpdateByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            
            
            
            
            var id = "id_example";  // string | ID of the persona
            
            
            
            
            
            var personaUpdateByIdRequest = new PersonaUpdateByIdRequest(); // PersonaUpdateByIdRequest | 
            
            

            try
            {
                

                apiInstance.PersonaUpdateById(string id, PersonaUpdateByIdRequest personaUpdateByIdRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PersonaUpdateById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the persona | 
 **personaUpdateByIdRequest** | [**PersonaUpdateByIdRequest**](PersonaUpdateByIdRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)



