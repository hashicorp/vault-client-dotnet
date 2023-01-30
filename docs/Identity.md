# Vault.Api.Identity

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AliasDeleteByID**](Identity.md#aliasdeletebyid) | **DELETE** /identity/alias/id/{id} | Update, read or delete an alias ID.
[**AliasListByID**](Identity.md#aliaslistbyid) | **GET** /identity/alias/id | List all the alias IDs.
[**AliasReadByID**](Identity.md#aliasreadbyid) | **GET** /identity/alias/id/{id} | Update, read or delete an alias ID.
[**AliasWrite**](Identity.md#aliaswrite) | **POST** /identity/alias | Create a new alias.
[**AliasWriteByID**](Identity.md#aliaswritebyid) | **POST** /identity/alias/id/{id} | Update, read or delete an alias ID.
[**EntityBatchDelete**](Identity.md#entitybatchdelete) | **POST** /identity/entity/batch-delete | Delete all of the entities provided
[**EntityDeleteAliasByID**](Identity.md#entitydeletealiasbyid) | **DELETE** /identity/entity-alias/id/{id} | Update, read or delete an alias ID.
[**EntityDeleteByID**](Identity.md#entitydeletebyid) | **DELETE** /identity/entity/id/{id} | Update, read or delete an entity using entity ID
[**EntityDeleteByName**](Identity.md#entitydeletebyname) | **DELETE** /identity/entity/name/{name} | Update, read or delete an entity using entity name
[**EntityListAliasesByID**](Identity.md#entitylistaliasesbyid) | **GET** /identity/entity-alias/id | List all the alias IDs.
[**EntityListByID**](Identity.md#entitylistbyid) | **GET** /identity/entity/id | List all the entity IDs
[**EntityListByName**](Identity.md#entitylistbyname) | **GET** /identity/entity/name | List all the entity names
[**EntityLookup**](Identity.md#entitylookup) | **POST** /identity/lookup/entity | Query entities based on various properties.
[**EntityMerge**](Identity.md#entitymerge) | **POST** /identity/entity/merge | Merge two or more entities together
[**EntityReadAliasByID**](Identity.md#entityreadaliasbyid) | **GET** /identity/entity-alias/id/{id} | Update, read or delete an alias ID.
[**EntityReadByID**](Identity.md#entityreadbyid) | **GET** /identity/entity/id/{id} | Update, read or delete an entity using entity ID
[**EntityReadByName**](Identity.md#entityreadbyname) | **GET** /identity/entity/name/{name} | Update, read or delete an entity using entity name
[**EntityWrite**](Identity.md#entitywrite) | **POST** /identity/entity | Create a new entity
[**EntityWriteAlias**](Identity.md#entitywritealias) | **POST** /identity/entity-alias | Create a new alias.
[**EntityWriteAliasByID**](Identity.md#entitywritealiasbyid) | **POST** /identity/entity-alias/id/{id} | Update, read or delete an alias ID.
[**EntityWriteByID**](Identity.md#entitywritebyid) | **POST** /identity/entity/id/{id} | Update, read or delete an entity using entity ID
[**EntityWriteByName**](Identity.md#entitywritebyname) | **POST** /identity/entity/name/{name} | Update, read or delete an entity using entity name
[**GroupDeleteAliasByID**](Identity.md#groupdeletealiasbyid) | **DELETE** /identity/group-alias/id/{id} | 
[**GroupDeleteByID**](Identity.md#groupdeletebyid) | **DELETE** /identity/group/id/{id} | Update or delete an existing group using its ID.
[**GroupDeleteByName**](Identity.md#groupdeletebyname) | **DELETE** /identity/group/name/{name} | 
[**GroupListAliasesByID**](Identity.md#grouplistaliasesbyid) | **GET** /identity/group-alias/id | List all the group alias IDs.
[**GroupListByID**](Identity.md#grouplistbyid) | **GET** /identity/group/id | List all the group IDs.
[**GroupListByName**](Identity.md#grouplistbyname) | **GET** /identity/group/name | 
[**GroupLookup**](Identity.md#grouplookup) | **POST** /identity/lookup/group | Query groups based on various properties.
[**GroupReadAliasByID**](Identity.md#groupreadaliasbyid) | **GET** /identity/group-alias/id/{id} | 
[**GroupReadByID**](Identity.md#groupreadbyid) | **GET** /identity/group/id/{id} | Update or delete an existing group using its ID.
[**GroupReadByName**](Identity.md#groupreadbyname) | **GET** /identity/group/name/{name} | 
[**GroupWrite**](Identity.md#groupwrite) | **POST** /identity/group | Create a new group.
[**GroupWriteAlias**](Identity.md#groupwritealias) | **POST** /identity/group-alias | Creates a new group alias, or updates an existing one.
[**GroupWriteAliasByID**](Identity.md#groupwritealiasbyid) | **POST** /identity/group-alias/id/{id} | 
[**GroupWriteByID**](Identity.md#groupwritebyid) | **POST** /identity/group/id/{id} | Update or delete an existing group using its ID.
[**GroupWriteByName**](Identity.md#groupwritebyname) | **POST** /identity/group/name/{name} | 
[**MFADeleteLoginEnforcement**](Identity.md#mfadeleteloginenforcement) | **DELETE** /identity/mfa/login-enforcement/{name} | Delete a login enforcement
[**MFAListLoginEnforcements**](Identity.md#mfalistloginenforcements) | **GET** /identity/mfa/login-enforcement | List login enforcements
[**MFAMethodAdminDestroyTOTP**](Identity.md#mfamethodadmindestroytotp) | **POST** /identity/mfa/method/totp/admin-destroy | Destroys a TOTP secret for the given MFA method ID on the given entity
[**MFAMethodAdminGenerateTOTP**](Identity.md#mfamethodadmingeneratetotp) | **POST** /identity/mfa/method/totp/admin-generate | Update or create TOTP secret for the given method ID on the given entity.
[**MFAMethodDeleteDuo**](Identity.md#mfamethoddeleteduo) | **DELETE** /identity/mfa/method/duo/{method_id} | Delete a configuration for the given MFA method
[**MFAMethodDeleteOkta**](Identity.md#mfamethoddeleteokta) | **DELETE** /identity/mfa/method/okta/{method_id} | Delete a configuration for the given MFA method
[**MFAMethodDeletePingID**](Identity.md#mfamethoddeletepingid) | **DELETE** /identity/mfa/method/pingid/{method_id} | Delete a configuration for the given MFA method
[**MFAMethodDeleteTOTP**](Identity.md#mfamethoddeletetotp) | **DELETE** /identity/mfa/method/totp/{method_id} | Delete a configuration for the given MFA method
[**MFAMethodGenerateTOTP**](Identity.md#mfamethodgeneratetotp) | **POST** /identity/mfa/method/totp/generate | Update or create TOTP secret for the given method ID on the given entity.
[**MFAMethodList**](Identity.md#mfamethodlist) | **GET** /identity/mfa/method | List MFA method configurations for all MFA methods
[**MFAMethodListDuo**](Identity.md#mfamethodlistduo) | **GET** /identity/mfa/method/duo | List MFA method configurations for the given MFA method
[**MFAMethodListOkta**](Identity.md#mfamethodlistokta) | **GET** /identity/mfa/method/okta | List MFA method configurations for the given MFA method
[**MFAMethodListPingID**](Identity.md#mfamethodlistpingid) | **GET** /identity/mfa/method/pingid | List MFA method configurations for the given MFA method
[**MFAMethodListTOTP**](Identity.md#mfamethodlisttotp) | **GET** /identity/mfa/method/totp | List MFA method configurations for the given MFA method
[**MFAMethodRead**](Identity.md#mfamethodread) | **GET** /identity/mfa/method/{method_id} | Read the current configuration for the given ID regardless of the MFA method type
[**MFAMethodReadDuo**](Identity.md#mfamethodreadduo) | **GET** /identity/mfa/method/duo/{method_id} | Read the current configuration for the given MFA method
[**MFAMethodReadOkta**](Identity.md#mfamethodreadokta) | **GET** /identity/mfa/method/okta/{method_id} | Read the current configuration for the given MFA method
[**MFAMethodReadPingID**](Identity.md#mfamethodreadpingid) | **GET** /identity/mfa/method/pingid/{method_id} | Read the current configuration for the given MFA method
[**MFAMethodReadTOTP**](Identity.md#mfamethodreadtotp) | **GET** /identity/mfa/method/totp/{method_id} | Read the current configuration for the given MFA method
[**MFAMethodWriteDuo**](Identity.md#mfamethodwriteduo) | **POST** /identity/mfa/method/duo/{method_id} | Update or create a configuration for the given MFA method
[**MFAMethodWriteOkta**](Identity.md#mfamethodwriteokta) | **POST** /identity/mfa/method/okta/{method_id} | Update or create a configuration for the given MFA method
[**MFAMethodWritePingID**](Identity.md#mfamethodwritepingid) | **POST** /identity/mfa/method/pingid/{method_id} | Update or create a configuration for the given MFA method
[**MFAMethodWriteTOTP**](Identity.md#mfamethodwritetotp) | **POST** /identity/mfa/method/totp/{method_id} | Update or create a configuration for the given MFA method
[**MFAReadLoginEnforcement**](Identity.md#mfareadloginenforcement) | **GET** /identity/mfa/login-enforcement/{name} | Read the current login enforcement
[**MFAWriteLoginEnforcement**](Identity.md#mfawriteloginenforcement) | **POST** /identity/mfa/login-enforcement/{name} | Create or update a login enforcement
[**OIDCDeleteAssignment**](Identity.md#oidcdeleteassignment) | **DELETE** /identity/oidc/assignment/{name} | 
[**OIDCDeleteClient**](Identity.md#oidcdeleteclient) | **DELETE** /identity/oidc/client/{name} | 
[**OIDCDeleteKey**](Identity.md#oidcdeletekey) | **DELETE** /identity/oidc/key/{name} | CRUD operations for OIDC keys.
[**OIDCDeleteProvider**](Identity.md#oidcdeleteprovider) | **DELETE** /identity/oidc/provider/{name} | 
[**OIDCDeleteRole**](Identity.md#oidcdeleterole) | **DELETE** /identity/oidc/role/{name} | CRUD operations on OIDC Roles
[**OIDCDeleteScope**](Identity.md#oidcdeletescope) | **DELETE** /identity/oidc/scope/{name} | 
[**OIDCIntrospect**](Identity.md#oidcintrospect) | **POST** /identity/oidc/introspect | Verify the authenticity of an OIDC token
[**OIDCListAssignments**](Identity.md#oidclistassignments) | **GET** /identity/oidc/assignment | 
[**OIDCListClients**](Identity.md#oidclistclients) | **GET** /identity/oidc/client | 
[**OIDCListKeys**](Identity.md#oidclistkeys) | **GET** /identity/oidc/key | List OIDC keys
[**OIDCListProviders**](Identity.md#oidclistproviders) | **GET** /identity/oidc/provider | 
[**OIDCListRoles**](Identity.md#oidclistroles) | **GET** /identity/oidc/role | List configured OIDC roles
[**OIDCListScopes**](Identity.md#oidclistscopes) | **GET** /identity/oidc/scope | 
[**OIDCReadAssignment**](Identity.md#oidcreadassignment) | **GET** /identity/oidc/assignment/{name} | 
[**OIDCReadClient**](Identity.md#oidcreadclient) | **GET** /identity/oidc/client/{name} | 
[**OIDCReadConfig**](Identity.md#oidcreadconfig) | **GET** /identity/oidc/config | OIDC configuration
[**OIDCReadKey**](Identity.md#oidcreadkey) | **GET** /identity/oidc/key/{name} | CRUD operations for OIDC keys.
[**OIDCReadProvider**](Identity.md#oidcreadprovider) | **GET** /identity/oidc/provider/{name} | 
[**OIDCReadProviderAuthorize**](Identity.md#oidcreadproviderauthorize) | **GET** /identity/oidc/provider/{name}/authorize | 
[**OIDCReadProviderUserInfo**](Identity.md#oidcreadprovideruserinfo) | **GET** /identity/oidc/provider/{name}/userinfo | 
[**OIDCReadProviderWellKnownKeys**](Identity.md#oidcreadproviderwellknownkeys) | **GET** /identity/oidc/provider/{name}/.well-known/keys | 
[**OIDCReadProviderWellKnownOpenIDConfiguration**](Identity.md#oidcreadproviderwellknownopenidconfiguration) | **GET** /identity/oidc/provider/{name}/.well-known/openid-configuration | 
[**OIDCReadRole**](Identity.md#oidcreadrole) | **GET** /identity/oidc/role/{name} | CRUD operations on OIDC Roles
[**OIDCReadScope**](Identity.md#oidcreadscope) | **GET** /identity/oidc/scope/{name} | 
[**OIDCReadToken**](Identity.md#oidcreadtoken) | **GET** /identity/oidc/token/{name} | Generate an OIDC token
[**OIDCReadWellKnownKeys**](Identity.md#oidcreadwellknownkeys) | **GET** /identity/oidc/.well-known/keys | Retrieve public keys
[**OIDCReadWellKnownOpenIDConfiguration**](Identity.md#oidcreadwellknownopenidconfiguration) | **GET** /identity/oidc/.well-known/openid-configuration | Query OIDC configurations
[**OIDCRotateKey**](Identity.md#oidcrotatekey) | **POST** /identity/oidc/key/{name}/rotate | Rotate a named OIDC key.
[**OIDCWriteAssignment**](Identity.md#oidcwriteassignment) | **POST** /identity/oidc/assignment/{name} | 
[**OIDCWriteClient**](Identity.md#oidcwriteclient) | **POST** /identity/oidc/client/{name} | 
[**OIDCWriteConfig**](Identity.md#oidcwriteconfig) | **POST** /identity/oidc/config | OIDC configuration
[**OIDCWriteKey**](Identity.md#oidcwritekey) | **POST** /identity/oidc/key/{name} | CRUD operations for OIDC keys.
[**OIDCWriteProvider**](Identity.md#oidcwriteprovider) | **POST** /identity/oidc/provider/{name} | 
[**OIDCWriteProviderAuthorize**](Identity.md#oidcwriteproviderauthorize) | **POST** /identity/oidc/provider/{name}/authorize | 
[**OIDCWriteProviderToken**](Identity.md#oidcwriteprovidertoken) | **POST** /identity/oidc/provider/{name}/token | 
[**OIDCWriteProviderUserInfo**](Identity.md#oidcwriteprovideruserinfo) | **POST** /identity/oidc/provider/{name}/userinfo | 
[**OIDCWriteRole**](Identity.md#oidcwriterole) | **POST** /identity/oidc/role/{name} | CRUD operations on OIDC Roles
[**OIDCWriteScope**](Identity.md#oidcwritescope) | **POST** /identity/oidc/scope/{name} | 
[**PersonaIDDeleteByID**](Identity.md#personaiddeletebyid) | **DELETE** /identity/persona/id/{id} | Update, read or delete an alias ID.
[**PersonaIDReadByID**](Identity.md#personaidreadbyid) | **GET** /identity/persona/id/{id} | Update, read or delete an alias ID.
[**PersonaIDWriteByID**](Identity.md#personaidwritebyid) | **POST** /identity/persona/id/{id} | Update, read or delete an alias ID.
[**PersonaListByID**](Identity.md#personalistbyid) | **GET** /identity/persona/id | List all the alias IDs.
[**PersonaWrite**](Identity.md#personawrite) | **POST** /identity/persona | Create a new alias.


<a name="aliasdeletebyid"></a>
# **AliasDeleteByID**
> void AliasDeleteByID (string id, TimeSpan? wrapTTL = null)

Update, read or delete an alias ID.

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
    public class AliasDeleteByIDExample
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
                // Update, read or delete an alias ID.
                apiInstance.AliasDeleteByID(string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.AliasDeleteByID: " + e.Message );
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
# **AliasListByID**
> void AliasListByID (TimeSpan? wrapTTL = null)

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
    public class AliasListByIDExample
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
                apiInstance.AliasListByID(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.AliasListByID: " + e.Message );
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

<a name="aliasreadbyid"></a>
# **AliasReadByID**
> void AliasReadByID (string id, TimeSpan? wrapTTL = null)

Update, read or delete an alias ID.

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
    public class AliasReadByIDExample
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
                // Update, read or delete an alias ID.
                apiInstance.AliasReadByID(string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.AliasReadByID: " + e.Message );
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

<a name="aliaswrite"></a>
# **AliasWrite**
> void AliasWrite (AliasWriteRequest aliasWriteRequest, TimeSpan? wrapTTL = null)

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
    public class AliasWriteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var aliasWriteRequest = new AliasWriteRequest(); // AliasWriteRequest | 

            try
            {
                // Create a new alias.
                apiInstance.AliasWrite(AliasWriteRequest aliasWriteRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.AliasWrite: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aliasWriteRequest** | [**AliasWriteRequest**](AliasWriteRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aliaswritebyid"></a>
# **AliasWriteByID**
> void AliasWriteByID (AliasWriteByIDRequest aliasWriteByIDRequest, string id, TimeSpan? wrapTTL = null)

Update, read or delete an alias ID.

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
    public class AliasWriteByIDExample
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
            var aliasWriteByIDRequest = new AliasWriteByIDRequest(); // AliasWriteByIDRequest | 

            try
            {
                // Update, read or delete an alias ID.
                apiInstance.AliasWriteByID(AliasWriteByIDRequest aliasWriteByIDRequest, string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.AliasWriteByID: " + e.Message );
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
 **aliasWriteByIDRequest** | [**AliasWriteByIDRequest**](AliasWriteByIDRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
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

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="entitydeletealiasbyid"></a>
# **EntityDeleteAliasByID**
> void EntityDeleteAliasByID (string id, TimeSpan? wrapTTL = null)

Update, read or delete an alias ID.

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
    public class EntityDeleteAliasByIDExample
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
                // Update, read or delete an alias ID.
                apiInstance.EntityDeleteAliasByID(string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityDeleteAliasByID: " + e.Message );
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
# **EntityDeleteByID**
> void EntityDeleteByID (string id, TimeSpan? wrapTTL = null)

Update, read or delete an entity using entity ID

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
    public class EntityDeleteByIDExample
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
                // Update, read or delete an entity using entity ID
                apiInstance.EntityDeleteByID(string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityDeleteByID: " + e.Message );
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

Update, read or delete an entity using entity name

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
                // Update, read or delete an entity using entity name
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
# **EntityListAliasesByID**
> void EntityListAliasesByID (TimeSpan? wrapTTL = null)

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
    public class EntityListAliasesByIDExample
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
                apiInstance.EntityListAliasesByID(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityListAliasesByID: " + e.Message );
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

<a name="entitylistbyid"></a>
# **EntityListByID**
> void EntityListByID (TimeSpan? wrapTTL = null)

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
    public class EntityListByIDExample
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
                apiInstance.EntityListByID(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityListByID: " + e.Message );
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

<a name="entitylistbyname"></a>
# **EntityListByName**
> void EntityListByName (TimeSpan? wrapTTL = null)

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
                apiInstance.EntityListByName(TimeSpan? wrapTTL = null);
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

<a name="entitylookup"></a>
# **EntityLookup**
> void EntityLookup (EntityLookupRequest entityLookupRequest, TimeSpan? wrapTTL = null)

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
    public class EntityLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var entityLookupRequest = new EntityLookupRequest(); // EntityLookupRequest | 

            try
            {
                // Query entities based on various properties.
                apiInstance.EntityLookup(EntityLookupRequest entityLookupRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityLookup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entityLookupRequest** | [**EntityLookupRequest**](EntityLookupRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
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

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="entityreadaliasbyid"></a>
# **EntityReadAliasByID**
> void EntityReadAliasByID (string id, TimeSpan? wrapTTL = null)

Update, read or delete an alias ID.

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
    public class EntityReadAliasByIDExample
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
                // Update, read or delete an alias ID.
                apiInstance.EntityReadAliasByID(string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityReadAliasByID: " + e.Message );
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
# **EntityReadByID**
> void EntityReadByID (string id, TimeSpan? wrapTTL = null)

Update, read or delete an entity using entity ID

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
    public class EntityReadByIDExample
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
                // Update, read or delete an entity using entity ID
                apiInstance.EntityReadByID(string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityReadByID: " + e.Message );
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

Update, read or delete an entity using entity name

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
                // Update, read or delete an entity using entity name
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

<a name="entitywrite"></a>
# **EntityWrite**
> void EntityWrite (EntityWriteRequest entityWriteRequest, TimeSpan? wrapTTL = null)

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
    public class EntityWriteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var entityWriteRequest = new EntityWriteRequest(); // EntityWriteRequest | 

            try
            {
                // Create a new entity
                apiInstance.EntityWrite(EntityWriteRequest entityWriteRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityWrite: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entityWriteRequest** | [**EntityWriteRequest**](EntityWriteRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="entitywritealias"></a>
# **EntityWriteAlias**
> void EntityWriteAlias (EntityWriteAliasRequest entityWriteAliasRequest, TimeSpan? wrapTTL = null)

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
    public class EntityWriteAliasExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var entityWriteAliasRequest = new EntityWriteAliasRequest(); // EntityWriteAliasRequest | 

            try
            {
                // Create a new alias.
                apiInstance.EntityWriteAlias(EntityWriteAliasRequest entityWriteAliasRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityWriteAlias: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entityWriteAliasRequest** | [**EntityWriteAliasRequest**](EntityWriteAliasRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="entitywritealiasbyid"></a>
# **EntityWriteAliasByID**
> void EntityWriteAliasByID (EntityWriteAliasByIDRequest entityWriteAliasByIDRequest, string id, TimeSpan? wrapTTL = null)

Update, read or delete an alias ID.

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
    public class EntityWriteAliasByIDExample
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
            var entityWriteAliasByIDRequest = new EntityWriteAliasByIDRequest(); // EntityWriteAliasByIDRequest | 

            try
            {
                // Update, read or delete an alias ID.
                apiInstance.EntityWriteAliasByID(EntityWriteAliasByIDRequest entityWriteAliasByIDRequest, string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityWriteAliasByID: " + e.Message );
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
 **entityWriteAliasByIDRequest** | [**EntityWriteAliasByIDRequest**](EntityWriteAliasByIDRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="entitywritebyid"></a>
# **EntityWriteByID**
> void EntityWriteByID (EntityWriteByIDRequest entityWriteByIDRequest, string id, TimeSpan? wrapTTL = null)

Update, read or delete an entity using entity ID

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
    public class EntityWriteByIDExample
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
            var entityWriteByIDRequest = new EntityWriteByIDRequest(); // EntityWriteByIDRequest | 

            try
            {
                // Update, read or delete an entity using entity ID
                apiInstance.EntityWriteByID(EntityWriteByIDRequest entityWriteByIDRequest, string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityWriteByID: " + e.Message );
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
 **entityWriteByIDRequest** | [**EntityWriteByIDRequest**](EntityWriteByIDRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="entitywritebyname"></a>
# **EntityWriteByName**
> void EntityWriteByName (EntityWriteByNameRequest entityWriteByNameRequest, string name, TimeSpan? wrapTTL = null)

Update, read or delete an entity using entity name

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
    public class EntityWriteByNameExample
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
            var entityWriteByNameRequest = new EntityWriteByNameRequest(); // EntityWriteByNameRequest | 

            try
            {
                // Update, read or delete an entity using entity name
                apiInstance.EntityWriteByName(EntityWriteByNameRequest entityWriteByNameRequest, string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.EntityWriteByName: " + e.Message );
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
 **entityWriteByNameRequest** | [**EntityWriteByNameRequest**](EntityWriteByNameRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupdeletealiasbyid"></a>
# **GroupDeleteAliasByID**
> void GroupDeleteAliasByID (string id, TimeSpan? wrapTTL = null)



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
    public class GroupDeleteAliasByIDExample
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
                apiInstance.GroupDeleteAliasByID(string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupDeleteAliasByID: " + e.Message );
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
# **GroupDeleteByID**
> void GroupDeleteByID (string id, TimeSpan? wrapTTL = null)

Update or delete an existing group using its ID.

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
    public class GroupDeleteByIDExample
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
                // Update or delete an existing group using its ID.
                apiInstance.GroupDeleteByID(string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupDeleteByID: " + e.Message );
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
# **GroupListAliasesByID**
> void GroupListAliasesByID (TimeSpan? wrapTTL = null)

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
    public class GroupListAliasesByIDExample
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
                apiInstance.GroupListAliasesByID(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupListAliasesByID: " + e.Message );
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

<a name="grouplistbyid"></a>
# **GroupListByID**
> void GroupListByID (TimeSpan? wrapTTL = null)

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
    public class GroupListByIDExample
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
                apiInstance.GroupListByID(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupListByID: " + e.Message );
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

<a name="grouplistbyname"></a>
# **GroupListByName**
> void GroupListByName (TimeSpan? wrapTTL = null)



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
                apiInstance.GroupListByName(TimeSpan? wrapTTL = null);
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

<a name="grouplookup"></a>
# **GroupLookup**
> void GroupLookup (GroupLookupRequest groupLookupRequest, TimeSpan? wrapTTL = null)

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
    public class GroupLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var groupLookupRequest = new GroupLookupRequest(); // GroupLookupRequest | 

            try
            {
                // Query groups based on various properties.
                apiInstance.GroupLookup(GroupLookupRequest groupLookupRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupLookup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupLookupRequest** | [**GroupLookupRequest**](GroupLookupRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupreadaliasbyid"></a>
# **GroupReadAliasByID**
> void GroupReadAliasByID (string id, TimeSpan? wrapTTL = null)



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
    public class GroupReadAliasByIDExample
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
                apiInstance.GroupReadAliasByID(string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupReadAliasByID: " + e.Message );
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
# **GroupReadByID**
> void GroupReadByID (string id, TimeSpan? wrapTTL = null)

Update or delete an existing group using its ID.

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
    public class GroupReadByIDExample
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
                // Update or delete an existing group using its ID.
                apiInstance.GroupReadByID(string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupReadByID: " + e.Message );
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

<a name="groupwrite"></a>
# **GroupWrite**
> void GroupWrite (GroupWriteRequest groupWriteRequest, TimeSpan? wrapTTL = null)

Create a new group.

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
    public class GroupWriteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var groupWriteRequest = new GroupWriteRequest(); // GroupWriteRequest | 

            try
            {
                // Create a new group.
                apiInstance.GroupWrite(GroupWriteRequest groupWriteRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupWrite: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupWriteRequest** | [**GroupWriteRequest**](GroupWriteRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupwritealias"></a>
# **GroupWriteAlias**
> void GroupWriteAlias (GroupWriteAliasRequest groupWriteAliasRequest, TimeSpan? wrapTTL = null)

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
    public class GroupWriteAliasExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var groupWriteAliasRequest = new GroupWriteAliasRequest(); // GroupWriteAliasRequest | 

            try
            {
                // Creates a new group alias, or updates an existing one.
                apiInstance.GroupWriteAlias(GroupWriteAliasRequest groupWriteAliasRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupWriteAlias: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupWriteAliasRequest** | [**GroupWriteAliasRequest**](GroupWriteAliasRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupwritealiasbyid"></a>
# **GroupWriteAliasByID**
> void GroupWriteAliasByID (GroupWriteAliasByIDRequest groupWriteAliasByIDRequest, string id, TimeSpan? wrapTTL = null)



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
    public class GroupWriteAliasByIDExample
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
            var groupWriteAliasByIDRequest = new GroupWriteAliasByIDRequest(); // GroupWriteAliasByIDRequest | 

            try
            {
                apiInstance.GroupWriteAliasByID(GroupWriteAliasByIDRequest groupWriteAliasByIDRequest, string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupWriteAliasByID: " + e.Message );
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
 **groupWriteAliasByIDRequest** | [**GroupWriteAliasByIDRequest**](GroupWriteAliasByIDRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupwritebyid"></a>
# **GroupWriteByID**
> void GroupWriteByID (GroupWriteByIDRequest groupWriteByIDRequest, string id, TimeSpan? wrapTTL = null)

Update or delete an existing group using its ID.

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
    public class GroupWriteByIDExample
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
            var groupWriteByIDRequest = new GroupWriteByIDRequest(); // GroupWriteByIDRequest | 

            try
            {
                // Update or delete an existing group using its ID.
                apiInstance.GroupWriteByID(GroupWriteByIDRequest groupWriteByIDRequest, string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupWriteByID: " + e.Message );
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
 **groupWriteByIDRequest** | [**GroupWriteByIDRequest**](GroupWriteByIDRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupwritebyname"></a>
# **GroupWriteByName**
> void GroupWriteByName (GroupWriteByNameRequest groupWriteByNameRequest, string name, TimeSpan? wrapTTL = null)



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
    public class GroupWriteByNameExample
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
            var groupWriteByNameRequest = new GroupWriteByNameRequest(); // GroupWriteByNameRequest | 

            try
            {
                apiInstance.GroupWriteByName(GroupWriteByNameRequest groupWriteByNameRequest, string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GroupWriteByName: " + e.Message );
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
 **groupWriteByNameRequest** | [**GroupWriteByNameRequest**](GroupWriteByNameRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mfadeleteloginenforcement"></a>
# **MFADeleteLoginEnforcement**
> void MFADeleteLoginEnforcement (string name, TimeSpan? wrapTTL = null)

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
    public class MFADeleteLoginEnforcementExample
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
                apiInstance.MFADeleteLoginEnforcement(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MFADeleteLoginEnforcement: " + e.Message );
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

<a name="mfalistloginenforcements"></a>
# **MFAListLoginEnforcements**
> void MFAListLoginEnforcements (TimeSpan? wrapTTL = null)

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
    public class MFAListLoginEnforcementsExample
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
                apiInstance.MFAListLoginEnforcements(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MFAListLoginEnforcements: " + e.Message );
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

<a name="mfamethodadmindestroytotp"></a>
# **MFAMethodAdminDestroyTOTP**
> void MFAMethodAdminDestroyTOTP (MFAMethodAdminDestroyTOTPRequest mFAMethodAdminDestroyTOTPRequest, TimeSpan? wrapTTL = null)

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
    public class MFAMethodAdminDestroyTOTPExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var mFAMethodAdminDestroyTOTPRequest = new MFAMethodAdminDestroyTOTPRequest(); // MFAMethodAdminDestroyTOTPRequest | 

            try
            {
                // Destroys a TOTP secret for the given MFA method ID on the given entity
                apiInstance.MFAMethodAdminDestroyTOTP(MFAMethodAdminDestroyTOTPRequest mFAMethodAdminDestroyTOTPRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MFAMethodAdminDestroyTOTP: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mFAMethodAdminDestroyTOTPRequest** | [**MFAMethodAdminDestroyTOTPRequest**](MFAMethodAdminDestroyTOTPRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mfamethodadmingeneratetotp"></a>
# **MFAMethodAdminGenerateTOTP**
> void MFAMethodAdminGenerateTOTP (MFAMethodAdminGenerateTOTPRequest mFAMethodAdminGenerateTOTPRequest, TimeSpan? wrapTTL = null)

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
    public class MFAMethodAdminGenerateTOTPExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var mFAMethodAdminGenerateTOTPRequest = new MFAMethodAdminGenerateTOTPRequest(); // MFAMethodAdminGenerateTOTPRequest | 

            try
            {
                // Update or create TOTP secret for the given method ID on the given entity.
                apiInstance.MFAMethodAdminGenerateTOTP(MFAMethodAdminGenerateTOTPRequest mFAMethodAdminGenerateTOTPRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MFAMethodAdminGenerateTOTP: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mFAMethodAdminGenerateTOTPRequest** | [**MFAMethodAdminGenerateTOTPRequest**](MFAMethodAdminGenerateTOTPRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mfamethoddeleteduo"></a>
# **MFAMethodDeleteDuo**
> void MFAMethodDeleteDuo (string methodId, TimeSpan? wrapTTL = null)

Delete a configuration for the given MFA method

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
    public class MFAMethodDeleteDuoExample
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
                // Delete a configuration for the given MFA method
                apiInstance.MFAMethodDeleteDuo(string methodId, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MFAMethodDeleteDuo: " + e.Message );
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

<a name="mfamethoddeleteokta"></a>
# **MFAMethodDeleteOkta**
> void MFAMethodDeleteOkta (string methodId, TimeSpan? wrapTTL = null)

Delete a configuration for the given MFA method

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
    public class MFAMethodDeleteOktaExample
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
                // Delete a configuration for the given MFA method
                apiInstance.MFAMethodDeleteOkta(string methodId, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MFAMethodDeleteOkta: " + e.Message );
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

<a name="mfamethoddeletepingid"></a>
# **MFAMethodDeletePingID**
> void MFAMethodDeletePingID (string methodId, TimeSpan? wrapTTL = null)

Delete a configuration for the given MFA method

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
    public class MFAMethodDeletePingIDExample
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
                // Delete a configuration for the given MFA method
                apiInstance.MFAMethodDeletePingID(string methodId, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MFAMethodDeletePingID: " + e.Message );
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

<a name="mfamethoddeletetotp"></a>
# **MFAMethodDeleteTOTP**
> void MFAMethodDeleteTOTP (string methodId, TimeSpan? wrapTTL = null)

Delete a configuration for the given MFA method

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
    public class MFAMethodDeleteTOTPExample
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
                // Delete a configuration for the given MFA method
                apiInstance.MFAMethodDeleteTOTP(string methodId, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MFAMethodDeleteTOTP: " + e.Message );
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

<a name="mfamethodgeneratetotp"></a>
# **MFAMethodGenerateTOTP**
> void MFAMethodGenerateTOTP (MFAMethodGenerateTOTPRequest mFAMethodGenerateTOTPRequest, TimeSpan? wrapTTL = null)

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
    public class MFAMethodGenerateTOTPExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var mFAMethodGenerateTOTPRequest = new MFAMethodGenerateTOTPRequest(); // MFAMethodGenerateTOTPRequest | 

            try
            {
                // Update or create TOTP secret for the given method ID on the given entity.
                apiInstance.MFAMethodGenerateTOTP(MFAMethodGenerateTOTPRequest mFAMethodGenerateTOTPRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MFAMethodGenerateTOTP: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mFAMethodGenerateTOTPRequest** | [**MFAMethodGenerateTOTPRequest**](MFAMethodGenerateTOTPRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mfamethodlist"></a>
# **MFAMethodList**
> void MFAMethodList (TimeSpan? wrapTTL = null)

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
    public class MFAMethodListExample
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
                apiInstance.MFAMethodList(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MFAMethodList: " + e.Message );
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

<a name="mfamethodlistduo"></a>
# **MFAMethodListDuo**
> void MFAMethodListDuo (TimeSpan? wrapTTL = null)

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
    public class MFAMethodListDuoExample
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
                apiInstance.MFAMethodListDuo(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MFAMethodListDuo: " + e.Message );
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

<a name="mfamethodlistokta"></a>
# **MFAMethodListOkta**
> void MFAMethodListOkta (TimeSpan? wrapTTL = null)

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
    public class MFAMethodListOktaExample
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
                apiInstance.MFAMethodListOkta(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MFAMethodListOkta: " + e.Message );
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

<a name="mfamethodlistpingid"></a>
# **MFAMethodListPingID**
> void MFAMethodListPingID (TimeSpan? wrapTTL = null)

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
    public class MFAMethodListPingIDExample
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
                apiInstance.MFAMethodListPingID(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MFAMethodListPingID: " + e.Message );
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

<a name="mfamethodlisttotp"></a>
# **MFAMethodListTOTP**
> void MFAMethodListTOTP (TimeSpan? wrapTTL = null)

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
    public class MFAMethodListTOTPExample
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
                apiInstance.MFAMethodListTOTP(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MFAMethodListTOTP: " + e.Message );
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

<a name="mfamethodread"></a>
# **MFAMethodRead**
> void MFAMethodRead (string methodId, TimeSpan? wrapTTL = null)

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
    public class MFAMethodReadExample
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
                apiInstance.MFAMethodRead(string methodId, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MFAMethodRead: " + e.Message );
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

<a name="mfamethodreadduo"></a>
# **MFAMethodReadDuo**
> void MFAMethodReadDuo (string methodId, TimeSpan? wrapTTL = null)

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
    public class MFAMethodReadDuoExample
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
                apiInstance.MFAMethodReadDuo(string methodId, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MFAMethodReadDuo: " + e.Message );
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

<a name="mfamethodreadokta"></a>
# **MFAMethodReadOkta**
> void MFAMethodReadOkta (string methodId, TimeSpan? wrapTTL = null)

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
    public class MFAMethodReadOktaExample
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
                apiInstance.MFAMethodReadOkta(string methodId, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MFAMethodReadOkta: " + e.Message );
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

<a name="mfamethodreadpingid"></a>
# **MFAMethodReadPingID**
> void MFAMethodReadPingID (string methodId, TimeSpan? wrapTTL = null)

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
    public class MFAMethodReadPingIDExample
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
                apiInstance.MFAMethodReadPingID(string methodId, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MFAMethodReadPingID: " + e.Message );
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

<a name="mfamethodreadtotp"></a>
# **MFAMethodReadTOTP**
> void MFAMethodReadTOTP (string methodId, TimeSpan? wrapTTL = null)

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
    public class MFAMethodReadTOTPExample
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
                apiInstance.MFAMethodReadTOTP(string methodId, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MFAMethodReadTOTP: " + e.Message );
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

<a name="mfamethodwriteduo"></a>
# **MFAMethodWriteDuo**
> void MFAMethodWriteDuo (MFAMethodWriteDuoRequest mFAMethodWriteDuoRequest, string methodId, TimeSpan? wrapTTL = null)

Update or create a configuration for the given MFA method

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
    public class MFAMethodWriteDuoExample
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
            var mFAMethodWriteDuoRequest = new MFAMethodWriteDuoRequest(); // MFAMethodWriteDuoRequest | 

            try
            {
                // Update or create a configuration for the given MFA method
                apiInstance.MFAMethodWriteDuo(MFAMethodWriteDuoRequest mFAMethodWriteDuoRequest, string methodId, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MFAMethodWriteDuo: " + e.Message );
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
 **mFAMethodWriteDuoRequest** | [**MFAMethodWriteDuoRequest**](MFAMethodWriteDuoRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mfamethodwriteokta"></a>
# **MFAMethodWriteOkta**
> void MFAMethodWriteOkta (MFAMethodWriteOktaRequest mFAMethodWriteOktaRequest, string methodId, TimeSpan? wrapTTL = null)

Update or create a configuration for the given MFA method

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
    public class MFAMethodWriteOktaExample
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
            var mFAMethodWriteOktaRequest = new MFAMethodWriteOktaRequest(); // MFAMethodWriteOktaRequest | 

            try
            {
                // Update or create a configuration for the given MFA method
                apiInstance.MFAMethodWriteOkta(MFAMethodWriteOktaRequest mFAMethodWriteOktaRequest, string methodId, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MFAMethodWriteOkta: " + e.Message );
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
 **mFAMethodWriteOktaRequest** | [**MFAMethodWriteOktaRequest**](MFAMethodWriteOktaRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mfamethodwritepingid"></a>
# **MFAMethodWritePingID**
> void MFAMethodWritePingID (MFAMethodWritePingIDRequest mFAMethodWritePingIDRequest, string methodId, TimeSpan? wrapTTL = null)

Update or create a configuration for the given MFA method

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
    public class MFAMethodWritePingIDExample
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
            var mFAMethodWritePingIDRequest = new MFAMethodWritePingIDRequest(); // MFAMethodWritePingIDRequest | 

            try
            {
                // Update or create a configuration for the given MFA method
                apiInstance.MFAMethodWritePingID(MFAMethodWritePingIDRequest mFAMethodWritePingIDRequest, string methodId, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MFAMethodWritePingID: " + e.Message );
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
 **mFAMethodWritePingIDRequest** | [**MFAMethodWritePingIDRequest**](MFAMethodWritePingIDRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mfamethodwritetotp"></a>
# **MFAMethodWriteTOTP**
> void MFAMethodWriteTOTP (MFAMethodWriteTOTPRequest mFAMethodWriteTOTPRequest, string methodId, TimeSpan? wrapTTL = null)

Update or create a configuration for the given MFA method

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
    public class MFAMethodWriteTOTPExample
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
            var mFAMethodWriteTOTPRequest = new MFAMethodWriteTOTPRequest(); // MFAMethodWriteTOTPRequest | 

            try
            {
                // Update or create a configuration for the given MFA method
                apiInstance.MFAMethodWriteTOTP(MFAMethodWriteTOTPRequest mFAMethodWriteTOTPRequest, string methodId, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MFAMethodWriteTOTP: " + e.Message );
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
 **mFAMethodWriteTOTPRequest** | [**MFAMethodWriteTOTPRequest**](MFAMethodWriteTOTPRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mfareadloginenforcement"></a>
# **MFAReadLoginEnforcement**
> void MFAReadLoginEnforcement (string name, TimeSpan? wrapTTL = null)

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
    public class MFAReadLoginEnforcementExample
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
                apiInstance.MFAReadLoginEnforcement(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MFAReadLoginEnforcement: " + e.Message );
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

<a name="mfawriteloginenforcement"></a>
# **MFAWriteLoginEnforcement**
> void MFAWriteLoginEnforcement (MFAWriteLoginEnforcementRequest mFAWriteLoginEnforcementRequest, string name, TimeSpan? wrapTTL = null)

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
    public class MFAWriteLoginEnforcementExample
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
            var mFAWriteLoginEnforcementRequest = new MFAWriteLoginEnforcementRequest(); // MFAWriteLoginEnforcementRequest | 

            try
            {
                // Create or update a login enforcement
                apiInstance.MFAWriteLoginEnforcement(MFAWriteLoginEnforcementRequest mFAWriteLoginEnforcementRequest, string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.MFAWriteLoginEnforcement: " + e.Message );
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
 **mFAWriteLoginEnforcementRequest** | [**MFAWriteLoginEnforcementRequest**](MFAWriteLoginEnforcementRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oidcdeleteassignment"></a>
# **OIDCDeleteAssignment**
> void OIDCDeleteAssignment (string name, TimeSpan? wrapTTL = null)



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
    public class OIDCDeleteAssignmentExample
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
                apiInstance.OIDCDeleteAssignment(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCDeleteAssignment: " + e.Message );
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
# **OIDCDeleteClient**
> void OIDCDeleteClient (string name, TimeSpan? wrapTTL = null)



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
    public class OIDCDeleteClientExample
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
                apiInstance.OIDCDeleteClient(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCDeleteClient: " + e.Message );
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
# **OIDCDeleteKey**
> void OIDCDeleteKey (string name, TimeSpan? wrapTTL = null)

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
    public class OIDCDeleteKeyExample
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
                apiInstance.OIDCDeleteKey(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCDeleteKey: " + e.Message );
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
# **OIDCDeleteProvider**
> void OIDCDeleteProvider (string name, TimeSpan? wrapTTL = null)



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
    public class OIDCDeleteProviderExample
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
                apiInstance.OIDCDeleteProvider(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCDeleteProvider: " + e.Message );
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
# **OIDCDeleteRole**
> void OIDCDeleteRole (string name, TimeSpan? wrapTTL = null)

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
    public class OIDCDeleteRoleExample
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
                apiInstance.OIDCDeleteRole(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCDeleteRole: " + e.Message );
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
# **OIDCDeleteScope**
> void OIDCDeleteScope (string name, TimeSpan? wrapTTL = null)



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
    public class OIDCDeleteScopeExample
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
                apiInstance.OIDCDeleteScope(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCDeleteScope: " + e.Message );
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

<a name="oidcintrospect"></a>
# **OIDCIntrospect**
> void OIDCIntrospect (OIDCIntrospectRequest oIDCIntrospectRequest, TimeSpan? wrapTTL = null)

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
    public class OIDCIntrospectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var oIDCIntrospectRequest = new OIDCIntrospectRequest(); // OIDCIntrospectRequest | 

            try
            {
                // Verify the authenticity of an OIDC token
                apiInstance.OIDCIntrospect(OIDCIntrospectRequest oIDCIntrospectRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCIntrospect: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oIDCIntrospectRequest** | [**OIDCIntrospectRequest**](OIDCIntrospectRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oidclistassignments"></a>
# **OIDCListAssignments**
> void OIDCListAssignments (TimeSpan? wrapTTL = null)



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
    public class OIDCListAssignmentsExample
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
                apiInstance.OIDCListAssignments(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCListAssignments: " + e.Message );
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

<a name="oidclistclients"></a>
# **OIDCListClients**
> void OIDCListClients (TimeSpan? wrapTTL = null)



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
    public class OIDCListClientsExample
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
                apiInstance.OIDCListClients(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCListClients: " + e.Message );
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

<a name="oidclistkeys"></a>
# **OIDCListKeys**
> void OIDCListKeys (TimeSpan? wrapTTL = null)

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
    public class OIDCListKeysExample
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
                apiInstance.OIDCListKeys(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCListKeys: " + e.Message );
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

<a name="oidclistproviders"></a>
# **OIDCListProviders**
> void OIDCListProviders (string allowedClientId = default(string), TimeSpan? wrapTTL = null)



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
    public class OIDCListProvidersExample
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
                apiInstance.OIDCListProviders(string allowedClientId = default(string), TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCListProviders: " + e.Message );
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

<a name="oidclistroles"></a>
# **OIDCListRoles**
> void OIDCListRoles (TimeSpan? wrapTTL = null)

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
    public class OIDCListRolesExample
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
                apiInstance.OIDCListRoles(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCListRoles: " + e.Message );
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

<a name="oidclistscopes"></a>
# **OIDCListScopes**
> void OIDCListScopes (TimeSpan? wrapTTL = null)



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
    public class OIDCListScopesExample
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
                apiInstance.OIDCListScopes(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCListScopes: " + e.Message );
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
# **OIDCReadAssignment**
> void OIDCReadAssignment (string name, TimeSpan? wrapTTL = null)



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
    public class OIDCReadAssignmentExample
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
                apiInstance.OIDCReadAssignment(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCReadAssignment: " + e.Message );
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
# **OIDCReadClient**
> void OIDCReadClient (string name, TimeSpan? wrapTTL = null)



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
    public class OIDCReadClientExample
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
                apiInstance.OIDCReadClient(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCReadClient: " + e.Message );
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

<a name="oidcreadconfig"></a>
# **OIDCReadConfig**
> void OIDCReadConfig (TimeSpan? wrapTTL = null)

OIDC configuration

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
    public class OIDCReadConfigExample
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
                // OIDC configuration
                apiInstance.OIDCReadConfig(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCReadConfig: " + e.Message );
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
# **OIDCReadKey**
> void OIDCReadKey (string name, TimeSpan? wrapTTL = null)

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
    public class OIDCReadKeyExample
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
                apiInstance.OIDCReadKey(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCReadKey: " + e.Message );
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

<a name="oidcreadprovider"></a>
# **OIDCReadProvider**
> void OIDCReadProvider (string name, TimeSpan? wrapTTL = null)



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
    public class OIDCReadProviderExample
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
                apiInstance.OIDCReadProvider(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCReadProvider: " + e.Message );
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

<a name="oidcreadproviderauthorize"></a>
# **OIDCReadProviderAuthorize**
> void OIDCReadProviderAuthorize (string name, TimeSpan? wrapTTL = null)



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
    public class OIDCReadProviderAuthorizeExample
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
                apiInstance.OIDCReadProviderAuthorize(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCReadProviderAuthorize: " + e.Message );
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

<a name="oidcreadprovideruserinfo"></a>
# **OIDCReadProviderUserInfo**
> void OIDCReadProviderUserInfo (string name, TimeSpan? wrapTTL = null)



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
    public class OIDCReadProviderUserInfoExample
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
                apiInstance.OIDCReadProviderUserInfo(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCReadProviderUserInfo: " + e.Message );
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

<a name="oidcreadproviderwellknownkeys"></a>
# **OIDCReadProviderWellKnownKeys**
> void OIDCReadProviderWellKnownKeys (string name, TimeSpan? wrapTTL = null)



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
    public class OIDCReadProviderWellKnownKeysExample
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
                apiInstance.OIDCReadProviderWellKnownKeys(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCReadProviderWellKnownKeys: " + e.Message );
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

<a name="oidcreadproviderwellknownopenidconfiguration"></a>
# **OIDCReadProviderWellKnownOpenIDConfiguration**
> void OIDCReadProviderWellKnownOpenIDConfiguration (string name, TimeSpan? wrapTTL = null)



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
    public class OIDCReadProviderWellKnownOpenIDConfigurationExample
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
                apiInstance.OIDCReadProviderWellKnownOpenIDConfiguration(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCReadProviderWellKnownOpenIDConfiguration: " + e.Message );
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

<a name="oidcreadrole"></a>
# **OIDCReadRole**
> void OIDCReadRole (string name, TimeSpan? wrapTTL = null)

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
    public class OIDCReadRoleExample
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
                apiInstance.OIDCReadRole(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCReadRole: " + e.Message );
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
# **OIDCReadScope**
> void OIDCReadScope (string name, TimeSpan? wrapTTL = null)



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
    public class OIDCReadScopeExample
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
                apiInstance.OIDCReadScope(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCReadScope: " + e.Message );
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

<a name="oidcreadtoken"></a>
# **OIDCReadToken**
> void OIDCReadToken (string name, TimeSpan? wrapTTL = null)

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
    public class OIDCReadTokenExample
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
                apiInstance.OIDCReadToken(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCReadToken: " + e.Message );
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

<a name="oidcreadwellknownkeys"></a>
# **OIDCReadWellKnownKeys**
> void OIDCReadWellKnownKeys (TimeSpan? wrapTTL = null)

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
    public class OIDCReadWellKnownKeysExample
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
                apiInstance.OIDCReadWellKnownKeys(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCReadWellKnownKeys: " + e.Message );
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

<a name="oidcreadwellknownopenidconfiguration"></a>
# **OIDCReadWellKnownOpenIDConfiguration**
> void OIDCReadWellKnownOpenIDConfiguration (TimeSpan? wrapTTL = null)

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
    public class OIDCReadWellKnownOpenIDConfigurationExample
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
                apiInstance.OIDCReadWellKnownOpenIDConfiguration(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCReadWellKnownOpenIDConfiguration: " + e.Message );
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

<a name="oidcrotatekey"></a>
# **OIDCRotateKey**
> void OIDCRotateKey (OIDCRotateKeyRequest oIDCRotateKeyRequest, string name, TimeSpan? wrapTTL = null)

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
    public class OIDCRotateKeyExample
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
            var oIDCRotateKeyRequest = new OIDCRotateKeyRequest(); // OIDCRotateKeyRequest | 

            try
            {
                // Rotate a named OIDC key.
                apiInstance.OIDCRotateKey(OIDCRotateKeyRequest oIDCRotateKeyRequest, string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCRotateKey: " + e.Message );
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
 **oIDCRotateKeyRequest** | [**OIDCRotateKeyRequest**](OIDCRotateKeyRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oidcwriteassignment"></a>
# **OIDCWriteAssignment**
> void OIDCWriteAssignment (OIDCWriteAssignmentRequest oIDCWriteAssignmentRequest, string name, TimeSpan? wrapTTL = null)



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
    public class OIDCWriteAssignmentExample
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
            var oIDCWriteAssignmentRequest = new OIDCWriteAssignmentRequest(); // OIDCWriteAssignmentRequest | 

            try
            {
                apiInstance.OIDCWriteAssignment(OIDCWriteAssignmentRequest oIDCWriteAssignmentRequest, string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCWriteAssignment: " + e.Message );
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
 **oIDCWriteAssignmentRequest** | [**OIDCWriteAssignmentRequest**](OIDCWriteAssignmentRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oidcwriteclient"></a>
# **OIDCWriteClient**
> void OIDCWriteClient (OIDCWriteClientRequest oIDCWriteClientRequest, string name, TimeSpan? wrapTTL = null)



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
    public class OIDCWriteClientExample
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
            var oIDCWriteClientRequest = new OIDCWriteClientRequest(); // OIDCWriteClientRequest | 

            try
            {
                apiInstance.OIDCWriteClient(OIDCWriteClientRequest oIDCWriteClientRequest, string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCWriteClient: " + e.Message );
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
 **oIDCWriteClientRequest** | [**OIDCWriteClientRequest**](OIDCWriteClientRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oidcwriteconfig"></a>
# **OIDCWriteConfig**
> void OIDCWriteConfig (OIDCWriteConfigRequest oIDCWriteConfigRequest, TimeSpan? wrapTTL = null)

OIDC configuration

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
    public class OIDCWriteConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var oIDCWriteConfigRequest = new OIDCWriteConfigRequest(); // OIDCWriteConfigRequest | 

            try
            {
                // OIDC configuration
                apiInstance.OIDCWriteConfig(OIDCWriteConfigRequest oIDCWriteConfigRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCWriteConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oIDCWriteConfigRequest** | [**OIDCWriteConfigRequest**](OIDCWriteConfigRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oidcwritekey"></a>
# **OIDCWriteKey**
> void OIDCWriteKey (OIDCWriteKeyRequest oIDCWriteKeyRequest, string name, TimeSpan? wrapTTL = null)

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
    public class OIDCWriteKeyExample
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
            var oIDCWriteKeyRequest = new OIDCWriteKeyRequest(); // OIDCWriteKeyRequest | 

            try
            {
                // CRUD operations for OIDC keys.
                apiInstance.OIDCWriteKey(OIDCWriteKeyRequest oIDCWriteKeyRequest, string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCWriteKey: " + e.Message );
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
 **oIDCWriteKeyRequest** | [**OIDCWriteKeyRequest**](OIDCWriteKeyRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oidcwriteprovider"></a>
# **OIDCWriteProvider**
> void OIDCWriteProvider (OIDCWriteProviderRequest oIDCWriteProviderRequest, string name, TimeSpan? wrapTTL = null)



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
    public class OIDCWriteProviderExample
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
            var oIDCWriteProviderRequest = new OIDCWriteProviderRequest(); // OIDCWriteProviderRequest | 

            try
            {
                apiInstance.OIDCWriteProvider(OIDCWriteProviderRequest oIDCWriteProviderRequest, string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCWriteProvider: " + e.Message );
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
 **oIDCWriteProviderRequest** | [**OIDCWriteProviderRequest**](OIDCWriteProviderRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oidcwriteproviderauthorize"></a>
# **OIDCWriteProviderAuthorize**
> void OIDCWriteProviderAuthorize (OIDCWriteProviderAuthorizeRequest oIDCWriteProviderAuthorizeRequest, string name, TimeSpan? wrapTTL = null)



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
    public class OIDCWriteProviderAuthorizeExample
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
            var oIDCWriteProviderAuthorizeRequest = new OIDCWriteProviderAuthorizeRequest(); // OIDCWriteProviderAuthorizeRequest | 

            try
            {
                apiInstance.OIDCWriteProviderAuthorize(OIDCWriteProviderAuthorizeRequest oIDCWriteProviderAuthorizeRequest, string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCWriteProviderAuthorize: " + e.Message );
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
 **oIDCWriteProviderAuthorizeRequest** | [**OIDCWriteProviderAuthorizeRequest**](OIDCWriteProviderAuthorizeRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oidcwriteprovidertoken"></a>
# **OIDCWriteProviderToken**
> void OIDCWriteProviderToken (OIDCWriteProviderTokenRequest oIDCWriteProviderTokenRequest, string name, TimeSpan? wrapTTL = null)



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
    public class OIDCWriteProviderTokenExample
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
            var oIDCWriteProviderTokenRequest = new OIDCWriteProviderTokenRequest(); // OIDCWriteProviderTokenRequest | 

            try
            {
                apiInstance.OIDCWriteProviderToken(OIDCWriteProviderTokenRequest oIDCWriteProviderTokenRequest, string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCWriteProviderToken: " + e.Message );
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
 **oIDCWriteProviderTokenRequest** | [**OIDCWriteProviderTokenRequest**](OIDCWriteProviderTokenRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oidcwriteprovideruserinfo"></a>
# **OIDCWriteProviderUserInfo**
> void OIDCWriteProviderUserInfo (string name, TimeSpan? wrapTTL = null)



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
    public class OIDCWriteProviderUserInfoExample
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
                apiInstance.OIDCWriteProviderUserInfo(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCWriteProviderUserInfo: " + e.Message );
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

<a name="oidcwriterole"></a>
# **OIDCWriteRole**
> void OIDCWriteRole (OIDCWriteRoleRequest oIDCWriteRoleRequest, string name, TimeSpan? wrapTTL = null)

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
    public class OIDCWriteRoleExample
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
            var oIDCWriteRoleRequest = new OIDCWriteRoleRequest(); // OIDCWriteRoleRequest | 

            try
            {
                // CRUD operations on OIDC Roles
                apiInstance.OIDCWriteRole(OIDCWriteRoleRequest oIDCWriteRoleRequest, string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCWriteRole: " + e.Message );
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
 **oIDCWriteRoleRequest** | [**OIDCWriteRoleRequest**](OIDCWriteRoleRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oidcwritescope"></a>
# **OIDCWriteScope**
> void OIDCWriteScope (OIDCWriteScopeRequest oIDCWriteScopeRequest, string name, TimeSpan? wrapTTL = null)



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
    public class OIDCWriteScopeExample
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
            var oIDCWriteScopeRequest = new OIDCWriteScopeRequest(); // OIDCWriteScopeRequest | 

            try
            {
                apiInstance.OIDCWriteScope(OIDCWriteScopeRequest oIDCWriteScopeRequest, string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.OIDCWriteScope: " + e.Message );
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
 **oIDCWriteScopeRequest** | [**OIDCWriteScopeRequest**](OIDCWriteScopeRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="personaiddeletebyid"></a>
# **PersonaIDDeleteByID**
> void PersonaIDDeleteByID (string id, TimeSpan? wrapTTL = null)

Update, read or delete an alias ID.

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
    public class PersonaIDDeleteByIDExample
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
                // Update, read or delete an alias ID.
                apiInstance.PersonaIDDeleteByID(string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PersonaIDDeleteByID: " + e.Message );
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

<a name="personaidreadbyid"></a>
# **PersonaIDReadByID**
> void PersonaIDReadByID (string id, TimeSpan? wrapTTL = null)

Update, read or delete an alias ID.

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
    public class PersonaIDReadByIDExample
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
                // Update, read or delete an alias ID.
                apiInstance.PersonaIDReadByID(string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PersonaIDReadByID: " + e.Message );
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

<a name="personaidwritebyid"></a>
# **PersonaIDWriteByID**
> void PersonaIDWriteByID (PersonaIDWriteByIDRequest personaIDWriteByIDRequest, string id, TimeSpan? wrapTTL = null)

Update, read or delete an alias ID.

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
    public class PersonaIDWriteByIDExample
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
            var personaIDWriteByIDRequest = new PersonaIDWriteByIDRequest(); // PersonaIDWriteByIDRequest | 

            try
            {
                // Update, read or delete an alias ID.
                apiInstance.PersonaIDWriteByID(PersonaIDWriteByIDRequest personaIDWriteByIDRequest, string id, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PersonaIDWriteByID: " + e.Message );
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
 **personaIDWriteByIDRequest** | [**PersonaIDWriteByIDRequest**](PersonaIDWriteByIDRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="personalistbyid"></a>
# **PersonaListByID**
> void PersonaListByID (TimeSpan? wrapTTL = null)

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
    public class PersonaListByIDExample
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
                apiInstance.PersonaListByID(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PersonaListByID: " + e.Message );
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

<a name="personawrite"></a>
# **PersonaWrite**
> void PersonaWrite (PersonaWriteRequest personaWriteRequest, TimeSpan? wrapTTL = null)

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
    public class PersonaWriteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var personaWriteRequest = new PersonaWriteRequest(); // PersonaWriteRequest | 

            try
            {
                // Create a new alias.
                apiInstance.PersonaWrite(PersonaWriteRequest personaWriteRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PersonaWrite: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personaWriteRequest** | [**PersonaWriteRequest**](PersonaWriteRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

