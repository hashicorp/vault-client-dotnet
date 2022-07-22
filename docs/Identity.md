# VaultClient.Api.Identity

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteIdentityAliasIdId**](Identity.md#deleteidentityaliasidid) | **DELETE** /identity/alias/id/{id} | Update, read or delete an alias ID.
[**DeleteIdentityEntityAliasIdId**](Identity.md#deleteidentityentityaliasidid) | **DELETE** /identity/entity-alias/id/{id} | Update, read or delete an alias ID.
[**DeleteIdentityEntityIdId**](Identity.md#deleteidentityentityidid) | **DELETE** /identity/entity/id/{id} | Update, read or delete an entity using entity ID
[**DeleteIdentityEntityNameName**](Identity.md#deleteidentityentitynamename) | **DELETE** /identity/entity/name/{name} | Update, read or delete an entity using entity name
[**DeleteIdentityGroupAliasIdId**](Identity.md#deleteidentitygroupaliasidid) | **DELETE** /identity/group-alias/id/{id} | 
[**DeleteIdentityGroupIdId**](Identity.md#deleteidentitygroupidid) | **DELETE** /identity/group/id/{id} | Update or delete an existing group using its ID.
[**DeleteIdentityGroupNameName**](Identity.md#deleteidentitygroupnamename) | **DELETE** /identity/group/name/{name} | 
[**DeleteIdentityMfaLoginEnforcementName**](Identity.md#deleteidentitymfaloginenforcementname) | **DELETE** /identity/mfa/login-enforcement/{name} | Delete a login enforcement
[**DeleteIdentityMfaMethodDuoMethodId**](Identity.md#deleteidentitymfamethodduomethodid) | **DELETE** /identity/mfa/method/duo/{method_id} | Delete a configuration for the given MFA method
[**DeleteIdentityMfaMethodOktaMethodId**](Identity.md#deleteidentitymfamethodoktamethodid) | **DELETE** /identity/mfa/method/okta/{method_id} | Delete a configuration for the given MFA method
[**DeleteIdentityMfaMethodPingidMethodId**](Identity.md#deleteidentitymfamethodpingidmethodid) | **DELETE** /identity/mfa/method/pingid/{method_id} | Delete a configuration for the given MFA method
[**DeleteIdentityMfaMethodTotpMethodId**](Identity.md#deleteidentitymfamethodtotpmethodid) | **DELETE** /identity/mfa/method/totp/{method_id} | Delete a configuration for the given MFA method
[**DeleteIdentityOidcAssignmentName**](Identity.md#deleteidentityoidcassignmentname) | **DELETE** /identity/oidc/assignment/{name} | 
[**DeleteIdentityOidcClientName**](Identity.md#deleteidentityoidcclientname) | **DELETE** /identity/oidc/client/{name} | 
[**DeleteIdentityOidcKeyName**](Identity.md#deleteidentityoidckeyname) | **DELETE** /identity/oidc/key/{name} | CRUD operations for OIDC keys.
[**DeleteIdentityOidcProviderName**](Identity.md#deleteidentityoidcprovidername) | **DELETE** /identity/oidc/provider/{name} | 
[**DeleteIdentityOidcRoleName**](Identity.md#deleteidentityoidcrolename) | **DELETE** /identity/oidc/role/{name} | CRUD operations on OIDC Roles
[**DeleteIdentityOidcScopeName**](Identity.md#deleteidentityoidcscopename) | **DELETE** /identity/oidc/scope/{name} | 
[**DeleteIdentityPersonaIdId**](Identity.md#deleteidentitypersonaidid) | **DELETE** /identity/persona/id/{id} | Update, read or delete an alias ID.
[**GetIdentityAliasId**](Identity.md#getidentityaliasid) | **GET** /identity/alias/id | List all the alias IDs.
[**GetIdentityAliasIdId**](Identity.md#getidentityaliasidid) | **GET** /identity/alias/id/{id} | Update, read or delete an alias ID.
[**GetIdentityEntityAliasId**](Identity.md#getidentityentityaliasid) | **GET** /identity/entity-alias/id | List all the alias IDs.
[**GetIdentityEntityAliasIdId**](Identity.md#getidentityentityaliasidid) | **GET** /identity/entity-alias/id/{id} | Update, read or delete an alias ID.
[**GetIdentityEntityId**](Identity.md#getidentityentityid) | **GET** /identity/entity/id | List all the entity IDs
[**GetIdentityEntityIdId**](Identity.md#getidentityentityidid) | **GET** /identity/entity/id/{id} | Update, read or delete an entity using entity ID
[**GetIdentityEntityName**](Identity.md#getidentityentityname) | **GET** /identity/entity/name | List all the entity names
[**GetIdentityEntityNameName**](Identity.md#getidentityentitynamename) | **GET** /identity/entity/name/{name} | Update, read or delete an entity using entity name
[**GetIdentityGroupAliasId**](Identity.md#getidentitygroupaliasid) | **GET** /identity/group-alias/id | List all the group alias IDs.
[**GetIdentityGroupAliasIdId**](Identity.md#getidentitygroupaliasidid) | **GET** /identity/group-alias/id/{id} | 
[**GetIdentityGroupId**](Identity.md#getidentitygroupid) | **GET** /identity/group/id | List all the group IDs.
[**GetIdentityGroupIdId**](Identity.md#getidentitygroupidid) | **GET** /identity/group/id/{id} | Update or delete an existing group using its ID.
[**GetIdentityGroupName**](Identity.md#getidentitygroupname) | **GET** /identity/group/name | 
[**GetIdentityGroupNameName**](Identity.md#getidentitygroupnamename) | **GET** /identity/group/name/{name} | 
[**GetIdentityMfaLoginEnforcement**](Identity.md#getidentitymfaloginenforcement) | **GET** /identity/mfa/login-enforcement | List login enforcements
[**GetIdentityMfaLoginEnforcementName**](Identity.md#getidentitymfaloginenforcementname) | **GET** /identity/mfa/login-enforcement/{name} | Read the current login enforcement
[**GetIdentityMfaMethod**](Identity.md#getidentitymfamethod) | **GET** /identity/mfa/method | List MFA method configurations for all MFA methods
[**GetIdentityMfaMethodDuo**](Identity.md#getidentitymfamethodduo) | **GET** /identity/mfa/method/duo | List MFA method configurations for the given MFA method
[**GetIdentityMfaMethodDuoMethodId**](Identity.md#getidentitymfamethodduomethodid) | **GET** /identity/mfa/method/duo/{method_id} | Read the current configuration for the given MFA method
[**GetIdentityMfaMethodMethodId**](Identity.md#getidentitymfamethodmethodid) | **GET** /identity/mfa/method/{method_id} | Read the current configuration for the given ID regardless of the MFA method type
[**GetIdentityMfaMethodOkta**](Identity.md#getidentitymfamethodokta) | **GET** /identity/mfa/method/okta | List MFA method configurations for the given MFA method
[**GetIdentityMfaMethodOktaMethodId**](Identity.md#getidentitymfamethodoktamethodid) | **GET** /identity/mfa/method/okta/{method_id} | Read the current configuration for the given MFA method
[**GetIdentityMfaMethodPingid**](Identity.md#getidentitymfamethodpingid) | **GET** /identity/mfa/method/pingid | List MFA method configurations for the given MFA method
[**GetIdentityMfaMethodPingidMethodId**](Identity.md#getidentitymfamethodpingidmethodid) | **GET** /identity/mfa/method/pingid/{method_id} | Read the current configuration for the given MFA method
[**GetIdentityMfaMethodTotp**](Identity.md#getidentitymfamethodtotp) | **GET** /identity/mfa/method/totp | List MFA method configurations for the given MFA method
[**GetIdentityMfaMethodTotpMethodId**](Identity.md#getidentitymfamethodtotpmethodid) | **GET** /identity/mfa/method/totp/{method_id} | Read the current configuration for the given MFA method
[**GetIdentityOidcAssignment**](Identity.md#getidentityoidcassignment) | **GET** /identity/oidc/assignment | 
[**GetIdentityOidcAssignmentName**](Identity.md#getidentityoidcassignmentname) | **GET** /identity/oidc/assignment/{name} | 
[**GetIdentityOidcClient**](Identity.md#getidentityoidcclient) | **GET** /identity/oidc/client | 
[**GetIdentityOidcClientName**](Identity.md#getidentityoidcclientname) | **GET** /identity/oidc/client/{name} | 
[**GetIdentityOidcConfig**](Identity.md#getidentityoidcconfig) | **GET** /identity/oidc/config | OIDC configuration
[**GetIdentityOidcKey**](Identity.md#getidentityoidckey) | **GET** /identity/oidc/key | List OIDC keys
[**GetIdentityOidcKeyName**](Identity.md#getidentityoidckeyname) | **GET** /identity/oidc/key/{name} | CRUD operations for OIDC keys.
[**GetIdentityOidcProvider**](Identity.md#getidentityoidcprovider) | **GET** /identity/oidc/provider | 
[**GetIdentityOidcProviderName**](Identity.md#getidentityoidcprovidername) | **GET** /identity/oidc/provider/{name} | 
[**GetIdentityOidcProviderNameAuthorize**](Identity.md#getidentityoidcprovidernameauthorize) | **GET** /identity/oidc/provider/{name}/authorize | 
[**GetIdentityOidcProviderNameUserinfo**](Identity.md#getidentityoidcprovidernameuserinfo) | **GET** /identity/oidc/provider/{name}/userinfo | 
[**GetIdentityOidcProviderNameWellKnownKeys**](Identity.md#getidentityoidcprovidernamewellknownkeys) | **GET** /identity/oidc/provider/{name}/.well-known/keys | 
[**GetIdentityOidcProviderNameWellKnownOpenidConfiguration**](Identity.md#getidentityoidcprovidernamewellknownopenidconfiguration) | **GET** /identity/oidc/provider/{name}/.well-known/openid-configuration | 
[**GetIdentityOidcRole**](Identity.md#getidentityoidcrole) | **GET** /identity/oidc/role | List configured OIDC roles
[**GetIdentityOidcRoleName**](Identity.md#getidentityoidcrolename) | **GET** /identity/oidc/role/{name} | CRUD operations on OIDC Roles
[**GetIdentityOidcScope**](Identity.md#getidentityoidcscope) | **GET** /identity/oidc/scope | 
[**GetIdentityOidcScopeName**](Identity.md#getidentityoidcscopename) | **GET** /identity/oidc/scope/{name} | 
[**GetIdentityOidcTokenName**](Identity.md#getidentityoidctokenname) | **GET** /identity/oidc/token/{name} | Generate an OIDC token
[**GetIdentityOidcWellKnownKeys**](Identity.md#getidentityoidcwellknownkeys) | **GET** /identity/oidc/.well-known/keys | Retrieve public keys
[**GetIdentityOidcWellKnownOpenidConfiguration**](Identity.md#getidentityoidcwellknownopenidconfiguration) | **GET** /identity/oidc/.well-known/openid-configuration | Query OIDC configurations
[**GetIdentityPersonaId**](Identity.md#getidentitypersonaid) | **GET** /identity/persona/id | List all the alias IDs.
[**GetIdentityPersonaIdId**](Identity.md#getidentitypersonaidid) | **GET** /identity/persona/id/{id} | Update, read or delete an alias ID.
[**PostIdentityAlias**](Identity.md#postidentityalias) | **POST** /identity/alias | Create a new alias.
[**PostIdentityAliasIdId**](Identity.md#postidentityaliasidid) | **POST** /identity/alias/id/{id} | Update, read or delete an alias ID.
[**PostIdentityEntity**](Identity.md#postidentityentity) | **POST** /identity/entity | Create a new entity
[**PostIdentityEntityAlias**](Identity.md#postidentityentityalias) | **POST** /identity/entity-alias | Create a new alias.
[**PostIdentityEntityAliasIdId**](Identity.md#postidentityentityaliasidid) | **POST** /identity/entity-alias/id/{id} | Update, read or delete an alias ID.
[**PostIdentityEntityBatchDelete**](Identity.md#postidentityentitybatchdelete) | **POST** /identity/entity/batch-delete | Delete all of the entities provided
[**PostIdentityEntityIdId**](Identity.md#postidentityentityidid) | **POST** /identity/entity/id/{id} | Update, read or delete an entity using entity ID
[**PostIdentityEntityMerge**](Identity.md#postidentityentitymerge) | **POST** /identity/entity/merge | Merge two or more entities together
[**PostIdentityEntityNameName**](Identity.md#postidentityentitynamename) | **POST** /identity/entity/name/{name} | Update, read or delete an entity using entity name
[**PostIdentityGroup**](Identity.md#postidentitygroup) | **POST** /identity/group | Create a new group.
[**PostIdentityGroupAlias**](Identity.md#postidentitygroupalias) | **POST** /identity/group-alias | Creates a new group alias, or updates an existing one.
[**PostIdentityGroupAliasIdId**](Identity.md#postidentitygroupaliasidid) | **POST** /identity/group-alias/id/{id} | 
[**PostIdentityGroupIdId**](Identity.md#postidentitygroupidid) | **POST** /identity/group/id/{id} | Update or delete an existing group using its ID.
[**PostIdentityGroupNameName**](Identity.md#postidentitygroupnamename) | **POST** /identity/group/name/{name} | 
[**PostIdentityLookupEntity**](Identity.md#postidentitylookupentity) | **POST** /identity/lookup/entity | Query entities based on various properties.
[**PostIdentityLookupGroup**](Identity.md#postidentitylookupgroup) | **POST** /identity/lookup/group | Query groups based on various properties.
[**PostIdentityMfaLoginEnforcementName**](Identity.md#postidentitymfaloginenforcementname) | **POST** /identity/mfa/login-enforcement/{name} | Create or update a login enforcement
[**PostIdentityMfaMethodDuoMethodId**](Identity.md#postidentitymfamethodduomethodid) | **POST** /identity/mfa/method/duo/{method_id} | Update or create a configuration for the given MFA method
[**PostIdentityMfaMethodOktaMethodId**](Identity.md#postidentitymfamethodoktamethodid) | **POST** /identity/mfa/method/okta/{method_id} | Update or create a configuration for the given MFA method
[**PostIdentityMfaMethodPingidMethodId**](Identity.md#postidentitymfamethodpingidmethodid) | **POST** /identity/mfa/method/pingid/{method_id} | Update or create a configuration for the given MFA method
[**PostIdentityMfaMethodTotpAdminDestroy**](Identity.md#postidentitymfamethodtotpadmindestroy) | **POST** /identity/mfa/method/totp/admin-destroy | Destroys a TOTP secret for the given MFA method ID on the given entity
[**PostIdentityMfaMethodTotpAdminGenerate**](Identity.md#postidentitymfamethodtotpadmingenerate) | **POST** /identity/mfa/method/totp/admin-generate | Update or create TOTP secret for the given method ID on the given entity.
[**PostIdentityMfaMethodTotpGenerate**](Identity.md#postidentitymfamethodtotpgenerate) | **POST** /identity/mfa/method/totp/generate | Update or create TOTP secret for the given method ID on the given entity.
[**PostIdentityMfaMethodTotpMethodId**](Identity.md#postidentitymfamethodtotpmethodid) | **POST** /identity/mfa/method/totp/{method_id} | Update or create a configuration for the given MFA method
[**PostIdentityOidcAssignmentName**](Identity.md#postidentityoidcassignmentname) | **POST** /identity/oidc/assignment/{name} | 
[**PostIdentityOidcClientName**](Identity.md#postidentityoidcclientname) | **POST** /identity/oidc/client/{name} | 
[**PostIdentityOidcConfig**](Identity.md#postidentityoidcconfig) | **POST** /identity/oidc/config | OIDC configuration
[**PostIdentityOidcIntrospect**](Identity.md#postidentityoidcintrospect) | **POST** /identity/oidc/introspect | Verify the authenticity of an OIDC token
[**PostIdentityOidcKeyName**](Identity.md#postidentityoidckeyname) | **POST** /identity/oidc/key/{name} | CRUD operations for OIDC keys.
[**PostIdentityOidcKeyNameRotate**](Identity.md#postidentityoidckeynamerotate) | **POST** /identity/oidc/key/{name}/rotate | Rotate a named OIDC key.
[**PostIdentityOidcProviderName**](Identity.md#postidentityoidcprovidername) | **POST** /identity/oidc/provider/{name} | 
[**PostIdentityOidcProviderNameAuthorize**](Identity.md#postidentityoidcprovidernameauthorize) | **POST** /identity/oidc/provider/{name}/authorize | 
[**PostIdentityOidcProviderNameToken**](Identity.md#postidentityoidcprovidernametoken) | **POST** /identity/oidc/provider/{name}/token | 
[**PostIdentityOidcProviderNameUserinfo**](Identity.md#postidentityoidcprovidernameuserinfo) | **POST** /identity/oidc/provider/{name}/userinfo | 
[**PostIdentityOidcRoleName**](Identity.md#postidentityoidcrolename) | **POST** /identity/oidc/role/{name} | CRUD operations on OIDC Roles
[**PostIdentityOidcScopeName**](Identity.md#postidentityoidcscopename) | **POST** /identity/oidc/scope/{name} | 
[**PostIdentityPersona**](Identity.md#postidentitypersona) | **POST** /identity/persona | Create a new alias.
[**PostIdentityPersonaIdId**](Identity.md#postidentitypersonaidid) | **POST** /identity/persona/id/{id} | Update, read or delete an alias ID.


<a name="deleteidentityaliasidid"></a>
# **DeleteIdentityAliasIdId**
> void DeleteIdentityAliasIdId (string id)

Update, read or delete an alias ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteIdentityAliasIdIdExample
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
                apiInstance.DeleteIdentityAliasIdId(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.DeleteIdentityAliasIdId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deleteidentityentityaliasidid"></a>
# **DeleteIdentityEntityAliasIdId**
> void DeleteIdentityEntityAliasIdId (string id)

Update, read or delete an alias ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteIdentityEntityAliasIdIdExample
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
                apiInstance.DeleteIdentityEntityAliasIdId(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.DeleteIdentityEntityAliasIdId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deleteidentityentityidid"></a>
# **DeleteIdentityEntityIdId**
> void DeleteIdentityEntityIdId (string id)

Update, read or delete an entity using entity ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteIdentityEntityIdIdExample
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
                apiInstance.DeleteIdentityEntityIdId(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.DeleteIdentityEntityIdId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deleteidentityentitynamename"></a>
# **DeleteIdentityEntityNameName**
> void DeleteIdentityEntityNameName (string name)

Update, read or delete an entity using entity name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteIdentityEntityNameNameExample
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
                apiInstance.DeleteIdentityEntityNameName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.DeleteIdentityEntityNameName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deleteidentitygroupaliasidid"></a>
# **DeleteIdentityGroupAliasIdId**
> void DeleteIdentityGroupAliasIdId (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteIdentityGroupAliasIdIdExample
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
                apiInstance.DeleteIdentityGroupAliasIdId(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.DeleteIdentityGroupAliasIdId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deleteidentitygroupidid"></a>
# **DeleteIdentityGroupIdId**
> void DeleteIdentityGroupIdId (string id)

Update or delete an existing group using its ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteIdentityGroupIdIdExample
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
                apiInstance.DeleteIdentityGroupIdId(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.DeleteIdentityGroupIdId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deleteidentitygroupnamename"></a>
# **DeleteIdentityGroupNameName**
> void DeleteIdentityGroupNameName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteIdentityGroupNameNameExample
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
                apiInstance.DeleteIdentityGroupNameName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.DeleteIdentityGroupNameName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deleteidentitymfaloginenforcementname"></a>
# **DeleteIdentityMfaLoginEnforcementName**
> void DeleteIdentityMfaLoginEnforcementName (string name)

Delete a login enforcement

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteIdentityMfaLoginEnforcementNameExample
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
                apiInstance.DeleteIdentityMfaLoginEnforcementName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.DeleteIdentityMfaLoginEnforcementName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deleteidentitymfamethodduomethodid"></a>
# **DeleteIdentityMfaMethodDuoMethodId**
> void DeleteIdentityMfaMethodDuoMethodId (string methodId)

Delete a configuration for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteIdentityMfaMethodDuoMethodIdExample
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
                apiInstance.DeleteIdentityMfaMethodDuoMethodId(methodId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.DeleteIdentityMfaMethodDuoMethodId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deleteidentitymfamethodoktamethodid"></a>
# **DeleteIdentityMfaMethodOktaMethodId**
> void DeleteIdentityMfaMethodOktaMethodId (string methodId)

Delete a configuration for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteIdentityMfaMethodOktaMethodIdExample
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
                apiInstance.DeleteIdentityMfaMethodOktaMethodId(methodId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.DeleteIdentityMfaMethodOktaMethodId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deleteidentitymfamethodpingidmethodid"></a>
# **DeleteIdentityMfaMethodPingidMethodId**
> void DeleteIdentityMfaMethodPingidMethodId (string methodId)

Delete a configuration for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteIdentityMfaMethodPingidMethodIdExample
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
                apiInstance.DeleteIdentityMfaMethodPingidMethodId(methodId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.DeleteIdentityMfaMethodPingidMethodId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deleteidentitymfamethodtotpmethodid"></a>
# **DeleteIdentityMfaMethodTotpMethodId**
> void DeleteIdentityMfaMethodTotpMethodId (string methodId)

Delete a configuration for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteIdentityMfaMethodTotpMethodIdExample
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
                apiInstance.DeleteIdentityMfaMethodTotpMethodId(methodId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.DeleteIdentityMfaMethodTotpMethodId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deleteidentityoidcassignmentname"></a>
# **DeleteIdentityOidcAssignmentName**
> void DeleteIdentityOidcAssignmentName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteIdentityOidcAssignmentNameExample
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
                apiInstance.DeleteIdentityOidcAssignmentName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.DeleteIdentityOidcAssignmentName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deleteidentityoidcclientname"></a>
# **DeleteIdentityOidcClientName**
> void DeleteIdentityOidcClientName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteIdentityOidcClientNameExample
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
                apiInstance.DeleteIdentityOidcClientName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.DeleteIdentityOidcClientName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deleteidentityoidckeyname"></a>
# **DeleteIdentityOidcKeyName**
> void DeleteIdentityOidcKeyName (string name)

CRUD operations for OIDC keys.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteIdentityOidcKeyNameExample
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
                apiInstance.DeleteIdentityOidcKeyName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.DeleteIdentityOidcKeyName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deleteidentityoidcprovidername"></a>
# **DeleteIdentityOidcProviderName**
> void DeleteIdentityOidcProviderName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteIdentityOidcProviderNameExample
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
                apiInstance.DeleteIdentityOidcProviderName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.DeleteIdentityOidcProviderName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deleteidentityoidcrolename"></a>
# **DeleteIdentityOidcRoleName**
> void DeleteIdentityOidcRoleName (string name)

CRUD operations on OIDC Roles

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteIdentityOidcRoleNameExample
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
                apiInstance.DeleteIdentityOidcRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.DeleteIdentityOidcRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deleteidentityoidcscopename"></a>
# **DeleteIdentityOidcScopeName**
> void DeleteIdentityOidcScopeName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteIdentityOidcScopeNameExample
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
                apiInstance.DeleteIdentityOidcScopeName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.DeleteIdentityOidcScopeName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deleteidentitypersonaidid"></a>
# **DeleteIdentityPersonaIdId**
> void DeleteIdentityPersonaIdId (string id)

Update, read or delete an alias ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteIdentityPersonaIdIdExample
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
                apiInstance.DeleteIdentityPersonaIdId(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.DeleteIdentityPersonaIdId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityaliasid"></a>
# **GetIdentityAliasId**
> void GetIdentityAliasId (string list)

List all the alias IDs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityAliasIdExample
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
                apiInstance.GetIdentityAliasId(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityAliasId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityaliasidid"></a>
# **GetIdentityAliasIdId**
> void GetIdentityAliasIdId (string id)

Update, read or delete an alias ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityAliasIdIdExample
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
                apiInstance.GetIdentityAliasIdId(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityAliasIdId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityentityaliasid"></a>
# **GetIdentityEntityAliasId**
> void GetIdentityEntityAliasId (string list)

List all the alias IDs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityEntityAliasIdExample
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
                apiInstance.GetIdentityEntityAliasId(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityEntityAliasId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityentityaliasidid"></a>
# **GetIdentityEntityAliasIdId**
> void GetIdentityEntityAliasIdId (string id)

Update, read or delete an alias ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityEntityAliasIdIdExample
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
                apiInstance.GetIdentityEntityAliasIdId(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityEntityAliasIdId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityentityid"></a>
# **GetIdentityEntityId**
> void GetIdentityEntityId (string list)

List all the entity IDs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityEntityIdExample
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
                apiInstance.GetIdentityEntityId(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityEntityId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityentityidid"></a>
# **GetIdentityEntityIdId**
> void GetIdentityEntityIdId (string id)

Update, read or delete an entity using entity ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityEntityIdIdExample
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
                apiInstance.GetIdentityEntityIdId(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityEntityIdId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityentityname"></a>
# **GetIdentityEntityName**
> void GetIdentityEntityName (string list)

List all the entity names

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityEntityNameExample
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
                apiInstance.GetIdentityEntityName(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityEntityName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityentitynamename"></a>
# **GetIdentityEntityNameName**
> void GetIdentityEntityNameName (string name)

Update, read or delete an entity using entity name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityEntityNameNameExample
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
                apiInstance.GetIdentityEntityNameName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityEntityNameName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentitygroupaliasid"></a>
# **GetIdentityGroupAliasId**
> void GetIdentityGroupAliasId (string list)

List all the group alias IDs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityGroupAliasIdExample
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
                apiInstance.GetIdentityGroupAliasId(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityGroupAliasId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentitygroupaliasidid"></a>
# **GetIdentityGroupAliasIdId**
> void GetIdentityGroupAliasIdId (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityGroupAliasIdIdExample
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
                apiInstance.GetIdentityGroupAliasIdId(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityGroupAliasIdId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentitygroupid"></a>
# **GetIdentityGroupId**
> void GetIdentityGroupId (string list)

List all the group IDs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityGroupIdExample
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
                apiInstance.GetIdentityGroupId(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityGroupId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentitygroupidid"></a>
# **GetIdentityGroupIdId**
> void GetIdentityGroupIdId (string id)

Update or delete an existing group using its ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityGroupIdIdExample
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
                apiInstance.GetIdentityGroupIdId(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityGroupIdId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentitygroupname"></a>
# **GetIdentityGroupName**
> void GetIdentityGroupName (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityGroupNameExample
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
                apiInstance.GetIdentityGroupName(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityGroupName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentitygroupnamename"></a>
# **GetIdentityGroupNameName**
> void GetIdentityGroupNameName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityGroupNameNameExample
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
                apiInstance.GetIdentityGroupNameName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityGroupNameName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentitymfaloginenforcement"></a>
# **GetIdentityMfaLoginEnforcement**
> void GetIdentityMfaLoginEnforcement (string list)

List login enforcements

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityMfaLoginEnforcementExample
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
                apiInstance.GetIdentityMfaLoginEnforcement(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityMfaLoginEnforcement: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentitymfaloginenforcementname"></a>
# **GetIdentityMfaLoginEnforcementName**
> void GetIdentityMfaLoginEnforcementName (string name)

Read the current login enforcement

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityMfaLoginEnforcementNameExample
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
                apiInstance.GetIdentityMfaLoginEnforcementName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityMfaLoginEnforcementName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentitymfamethod"></a>
# **GetIdentityMfaMethod**
> void GetIdentityMfaMethod (string list)

List MFA method configurations for all MFA methods

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityMfaMethodExample
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
                apiInstance.GetIdentityMfaMethod(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityMfaMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentitymfamethodduo"></a>
# **GetIdentityMfaMethodDuo**
> void GetIdentityMfaMethodDuo (string list)

List MFA method configurations for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityMfaMethodDuoExample
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
                apiInstance.GetIdentityMfaMethodDuo(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityMfaMethodDuo: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentitymfamethodduomethodid"></a>
# **GetIdentityMfaMethodDuoMethodId**
> void GetIdentityMfaMethodDuoMethodId (string methodId)

Read the current configuration for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityMfaMethodDuoMethodIdExample
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
                apiInstance.GetIdentityMfaMethodDuoMethodId(methodId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityMfaMethodDuoMethodId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentitymfamethodmethodid"></a>
# **GetIdentityMfaMethodMethodId**
> void GetIdentityMfaMethodMethodId (string methodId)

Read the current configuration for the given ID regardless of the MFA method type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityMfaMethodMethodIdExample
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
                apiInstance.GetIdentityMfaMethodMethodId(methodId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityMfaMethodMethodId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentitymfamethodokta"></a>
# **GetIdentityMfaMethodOkta**
> void GetIdentityMfaMethodOkta (string list)

List MFA method configurations for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityMfaMethodOktaExample
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
                apiInstance.GetIdentityMfaMethodOkta(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityMfaMethodOkta: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentitymfamethodoktamethodid"></a>
# **GetIdentityMfaMethodOktaMethodId**
> void GetIdentityMfaMethodOktaMethodId (string methodId)

Read the current configuration for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityMfaMethodOktaMethodIdExample
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
                apiInstance.GetIdentityMfaMethodOktaMethodId(methodId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityMfaMethodOktaMethodId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentitymfamethodpingid"></a>
# **GetIdentityMfaMethodPingid**
> void GetIdentityMfaMethodPingid (string list)

List MFA method configurations for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityMfaMethodPingidExample
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
                apiInstance.GetIdentityMfaMethodPingid(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityMfaMethodPingid: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentitymfamethodpingidmethodid"></a>
# **GetIdentityMfaMethodPingidMethodId**
> void GetIdentityMfaMethodPingidMethodId (string methodId)

Read the current configuration for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityMfaMethodPingidMethodIdExample
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
                apiInstance.GetIdentityMfaMethodPingidMethodId(methodId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityMfaMethodPingidMethodId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentitymfamethodtotp"></a>
# **GetIdentityMfaMethodTotp**
> void GetIdentityMfaMethodTotp (string list)

List MFA method configurations for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityMfaMethodTotpExample
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
                apiInstance.GetIdentityMfaMethodTotp(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityMfaMethodTotp: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentitymfamethodtotpmethodid"></a>
# **GetIdentityMfaMethodTotpMethodId**
> void GetIdentityMfaMethodTotpMethodId (string methodId)

Read the current configuration for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityMfaMethodTotpMethodIdExample
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
                apiInstance.GetIdentityMfaMethodTotpMethodId(methodId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityMfaMethodTotpMethodId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityoidcassignment"></a>
# **GetIdentityOidcAssignment**
> void GetIdentityOidcAssignment (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityOidcAssignmentExample
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
                apiInstance.GetIdentityOidcAssignment(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityOidcAssignment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityoidcassignmentname"></a>
# **GetIdentityOidcAssignmentName**
> void GetIdentityOidcAssignmentName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityOidcAssignmentNameExample
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
                apiInstance.GetIdentityOidcAssignmentName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityOidcAssignmentName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityoidcclient"></a>
# **GetIdentityOidcClient**
> void GetIdentityOidcClient (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityOidcClientExample
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
                apiInstance.GetIdentityOidcClient(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityOidcClient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityoidcclientname"></a>
# **GetIdentityOidcClientName**
> void GetIdentityOidcClientName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityOidcClientNameExample
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
                apiInstance.GetIdentityOidcClientName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityOidcClientName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityoidcconfig"></a>
# **GetIdentityOidcConfig**
> void GetIdentityOidcConfig ()

OIDC configuration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityOidcConfigExample
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
                apiInstance.GetIdentityOidcConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityOidcConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityoidckey"></a>
# **GetIdentityOidcKey**
> void GetIdentityOidcKey (string list)

List OIDC keys

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityOidcKeyExample
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
                apiInstance.GetIdentityOidcKey(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityOidcKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityoidckeyname"></a>
# **GetIdentityOidcKeyName**
> void GetIdentityOidcKeyName (string name)

CRUD operations for OIDC keys.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityOidcKeyNameExample
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
                apiInstance.GetIdentityOidcKeyName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityOidcKeyName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityoidcprovider"></a>
# **GetIdentityOidcProvider**
> void GetIdentityOidcProvider (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityOidcProviderExample
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
                apiInstance.GetIdentityOidcProvider(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityOidcProvider: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityoidcprovidername"></a>
# **GetIdentityOidcProviderName**
> void GetIdentityOidcProviderName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityOidcProviderNameExample
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
                apiInstance.GetIdentityOidcProviderName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityOidcProviderName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityoidcprovidernameauthorize"></a>
# **GetIdentityOidcProviderNameAuthorize**
> void GetIdentityOidcProviderNameAuthorize (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityOidcProviderNameAuthorizeExample
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
                apiInstance.GetIdentityOidcProviderNameAuthorize(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityOidcProviderNameAuthorize: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityoidcprovidernameuserinfo"></a>
# **GetIdentityOidcProviderNameUserinfo**
> void GetIdentityOidcProviderNameUserinfo (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityOidcProviderNameUserinfoExample
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
                apiInstance.GetIdentityOidcProviderNameUserinfo(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityOidcProviderNameUserinfo: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityoidcprovidernamewellknownkeys"></a>
# **GetIdentityOidcProviderNameWellKnownKeys**
> void GetIdentityOidcProviderNameWellKnownKeys (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityOidcProviderNameWellKnownKeysExample
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
                apiInstance.GetIdentityOidcProviderNameWellKnownKeys(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityOidcProviderNameWellKnownKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityoidcprovidernamewellknownopenidconfiguration"></a>
# **GetIdentityOidcProviderNameWellKnownOpenidConfiguration**
> void GetIdentityOidcProviderNameWellKnownOpenidConfiguration (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityOidcProviderNameWellKnownOpenidConfigurationExample
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
                apiInstance.GetIdentityOidcProviderNameWellKnownOpenidConfiguration(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityOidcProviderNameWellKnownOpenidConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityoidcrole"></a>
# **GetIdentityOidcRole**
> void GetIdentityOidcRole (string list)

List configured OIDC roles

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityOidcRoleExample
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
                apiInstance.GetIdentityOidcRole(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityOidcRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityoidcrolename"></a>
# **GetIdentityOidcRoleName**
> void GetIdentityOidcRoleName (string name)

CRUD operations on OIDC Roles

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityOidcRoleNameExample
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
                apiInstance.GetIdentityOidcRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityOidcRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityoidcscope"></a>
# **GetIdentityOidcScope**
> void GetIdentityOidcScope (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityOidcScopeExample
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
                apiInstance.GetIdentityOidcScope(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityOidcScope: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityoidcscopename"></a>
# **GetIdentityOidcScopeName**
> void GetIdentityOidcScopeName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityOidcScopeNameExample
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
                apiInstance.GetIdentityOidcScopeName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityOidcScopeName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityoidctokenname"></a>
# **GetIdentityOidcTokenName**
> void GetIdentityOidcTokenName (string name)

Generate an OIDC token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityOidcTokenNameExample
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
                apiInstance.GetIdentityOidcTokenName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityOidcTokenName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityoidcwellknownkeys"></a>
# **GetIdentityOidcWellKnownKeys**
> void GetIdentityOidcWellKnownKeys ()

Retrieve public keys

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityOidcWellKnownKeysExample
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
                apiInstance.GetIdentityOidcWellKnownKeys();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityOidcWellKnownKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentityoidcwellknownopenidconfiguration"></a>
# **GetIdentityOidcWellKnownOpenidConfiguration**
> void GetIdentityOidcWellKnownOpenidConfiguration ()

Query OIDC configurations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityOidcWellKnownOpenidConfigurationExample
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
                apiInstance.GetIdentityOidcWellKnownOpenidConfiguration();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityOidcWellKnownOpenidConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentitypersonaid"></a>
# **GetIdentityPersonaId**
> void GetIdentityPersonaId (string list)

List all the alias IDs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityPersonaIdExample
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
                apiInstance.GetIdentityPersonaId(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityPersonaId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getidentitypersonaidid"></a>
# **GetIdentityPersonaIdId**
> void GetIdentityPersonaIdId (string id)

Update, read or delete an alias ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetIdentityPersonaIdIdExample
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
                apiInstance.GetIdentityPersonaIdId(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.GetIdentityPersonaIdId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="postidentityalias"></a>
# **PostIdentityAlias**
> void PostIdentityAlias (IdentityAliasRequest identityAliasRequest = null)

Create a new alias.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityAliasExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var identityAliasRequest = new IdentityAliasRequest(); // IdentityAliasRequest |  (optional) 

            try
            {
                // Create a new alias.
                apiInstance.PostIdentityAlias(identityAliasRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityAlias: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identityAliasRequest** | [**IdentityAliasRequest**](IdentityAliasRequest.md)|  | [optional] 

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

<a name="postidentityaliasidid"></a>
# **PostIdentityAliasIdId**
> void PostIdentityAliasIdId (string id, IdentityAliasIdRequest identityAliasIdRequest = null)

Update, read or delete an alias ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityAliasIdIdExample
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
            var identityAliasIdRequest = new IdentityAliasIdRequest(); // IdentityAliasIdRequest |  (optional) 

            try
            {
                // Update, read or delete an alias ID.
                apiInstance.PostIdentityAliasIdId(id, identityAliasIdRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityAliasIdId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the alias | 
 **identityAliasIdRequest** | [**IdentityAliasIdRequest**](IdentityAliasIdRequest.md)|  | [optional] 

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

<a name="postidentityentity"></a>
# **PostIdentityEntity**
> void PostIdentityEntity (IdentityEntityRequest identityEntityRequest = null)

Create a new entity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityEntityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var identityEntityRequest = new IdentityEntityRequest(); // IdentityEntityRequest |  (optional) 

            try
            {
                // Create a new entity
                apiInstance.PostIdentityEntity(identityEntityRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityEntity: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identityEntityRequest** | [**IdentityEntityRequest**](IdentityEntityRequest.md)|  | [optional] 

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

<a name="postidentityentityalias"></a>
# **PostIdentityEntityAlias**
> void PostIdentityEntityAlias (IdentityEntityAliasRequest identityEntityAliasRequest = null)

Create a new alias.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityEntityAliasExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var identityEntityAliasRequest = new IdentityEntityAliasRequest(); // IdentityEntityAliasRequest |  (optional) 

            try
            {
                // Create a new alias.
                apiInstance.PostIdentityEntityAlias(identityEntityAliasRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityEntityAlias: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identityEntityAliasRequest** | [**IdentityEntityAliasRequest**](IdentityEntityAliasRequest.md)|  | [optional] 

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

<a name="postidentityentityaliasidid"></a>
# **PostIdentityEntityAliasIdId**
> void PostIdentityEntityAliasIdId (string id, IdentityEntityAliasIdRequest identityEntityAliasIdRequest = null)

Update, read or delete an alias ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityEntityAliasIdIdExample
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
            var identityEntityAliasIdRequest = new IdentityEntityAliasIdRequest(); // IdentityEntityAliasIdRequest |  (optional) 

            try
            {
                // Update, read or delete an alias ID.
                apiInstance.PostIdentityEntityAliasIdId(id, identityEntityAliasIdRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityEntityAliasIdId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the alias | 
 **identityEntityAliasIdRequest** | [**IdentityEntityAliasIdRequest**](IdentityEntityAliasIdRequest.md)|  | [optional] 

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

<a name="postidentityentitybatchdelete"></a>
# **PostIdentityEntityBatchDelete**
> void PostIdentityEntityBatchDelete (IdentityEntityBatchDeleteRequest identityEntityBatchDeleteRequest = null)

Delete all of the entities provided

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityEntityBatchDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var identityEntityBatchDeleteRequest = new IdentityEntityBatchDeleteRequest(); // IdentityEntityBatchDeleteRequest |  (optional) 

            try
            {
                // Delete all of the entities provided
                apiInstance.PostIdentityEntityBatchDelete(identityEntityBatchDeleteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityEntityBatchDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identityEntityBatchDeleteRequest** | [**IdentityEntityBatchDeleteRequest**](IdentityEntityBatchDeleteRequest.md)|  | [optional] 

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

<a name="postidentityentityidid"></a>
# **PostIdentityEntityIdId**
> void PostIdentityEntityIdId (string id, IdentityEntityIdRequest identityEntityIdRequest = null)

Update, read or delete an entity using entity ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityEntityIdIdExample
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
            var identityEntityIdRequest = new IdentityEntityIdRequest(); // IdentityEntityIdRequest |  (optional) 

            try
            {
                // Update, read or delete an entity using entity ID
                apiInstance.PostIdentityEntityIdId(id, identityEntityIdRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityEntityIdId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the entity. If set, updates the corresponding existing entity. | 
 **identityEntityIdRequest** | [**IdentityEntityIdRequest**](IdentityEntityIdRequest.md)|  | [optional] 

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

<a name="postidentityentitymerge"></a>
# **PostIdentityEntityMerge**
> void PostIdentityEntityMerge (IdentityEntityMergeRequest identityEntityMergeRequest = null)

Merge two or more entities together

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityEntityMergeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var identityEntityMergeRequest = new IdentityEntityMergeRequest(); // IdentityEntityMergeRequest |  (optional) 

            try
            {
                // Merge two or more entities together
                apiInstance.PostIdentityEntityMerge(identityEntityMergeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityEntityMerge: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identityEntityMergeRequest** | [**IdentityEntityMergeRequest**](IdentityEntityMergeRequest.md)|  | [optional] 

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

<a name="postidentityentitynamename"></a>
# **PostIdentityEntityNameName**
> void PostIdentityEntityNameName (string name, IdentityEntityNameRequest identityEntityNameRequest = null)

Update, read or delete an entity using entity name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityEntityNameNameExample
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
            var identityEntityNameRequest = new IdentityEntityNameRequest(); // IdentityEntityNameRequest |  (optional) 

            try
            {
                // Update, read or delete an entity using entity name
                apiInstance.PostIdentityEntityNameName(name, identityEntityNameRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityEntityNameName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the entity | 
 **identityEntityNameRequest** | [**IdentityEntityNameRequest**](IdentityEntityNameRequest.md)|  | [optional] 

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

<a name="postidentitygroup"></a>
# **PostIdentityGroup**
> void PostIdentityGroup (IdentityGroupRequest identityGroupRequest = null)

Create a new group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var identityGroupRequest = new IdentityGroupRequest(); // IdentityGroupRequest |  (optional) 

            try
            {
                // Create a new group.
                apiInstance.PostIdentityGroup(identityGroupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identityGroupRequest** | [**IdentityGroupRequest**](IdentityGroupRequest.md)|  | [optional] 

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

<a name="postidentitygroupalias"></a>
# **PostIdentityGroupAlias**
> void PostIdentityGroupAlias (IdentityGroupAliasRequest identityGroupAliasRequest = null)

Creates a new group alias, or updates an existing one.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityGroupAliasExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var identityGroupAliasRequest = new IdentityGroupAliasRequest(); // IdentityGroupAliasRequest |  (optional) 

            try
            {
                // Creates a new group alias, or updates an existing one.
                apiInstance.PostIdentityGroupAlias(identityGroupAliasRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityGroupAlias: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identityGroupAliasRequest** | [**IdentityGroupAliasRequest**](IdentityGroupAliasRequest.md)|  | [optional] 

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

<a name="postidentitygroupaliasidid"></a>
# **PostIdentityGroupAliasIdId**
> void PostIdentityGroupAliasIdId (string id, IdentityGroupAliasIdRequest identityGroupAliasIdRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityGroupAliasIdIdExample
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
            var identityGroupAliasIdRequest = new IdentityGroupAliasIdRequest(); // IdentityGroupAliasIdRequest |  (optional) 

            try
            {
                apiInstance.PostIdentityGroupAliasIdId(id, identityGroupAliasIdRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityGroupAliasIdId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the group alias. | 
 **identityGroupAliasIdRequest** | [**IdentityGroupAliasIdRequest**](IdentityGroupAliasIdRequest.md)|  | [optional] 

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

<a name="postidentitygroupidid"></a>
# **PostIdentityGroupIdId**
> void PostIdentityGroupIdId (string id, IdentityGroupIdRequest identityGroupIdRequest = null)

Update or delete an existing group using its ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityGroupIdIdExample
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
            var identityGroupIdRequest = new IdentityGroupIdRequest(); // IdentityGroupIdRequest |  (optional) 

            try
            {
                // Update or delete an existing group using its ID.
                apiInstance.PostIdentityGroupIdId(id, identityGroupIdRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityGroupIdId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the group. If set, updates the corresponding existing group. | 
 **identityGroupIdRequest** | [**IdentityGroupIdRequest**](IdentityGroupIdRequest.md)|  | [optional] 

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

<a name="postidentitygroupnamename"></a>
# **PostIdentityGroupNameName**
> void PostIdentityGroupNameName (string name, IdentityGroupNameRequest identityGroupNameRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityGroupNameNameExample
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
            var identityGroupNameRequest = new IdentityGroupNameRequest(); // IdentityGroupNameRequest |  (optional) 

            try
            {
                apiInstance.PostIdentityGroupNameName(name, identityGroupNameRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityGroupNameName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the group. | 
 **identityGroupNameRequest** | [**IdentityGroupNameRequest**](IdentityGroupNameRequest.md)|  | [optional] 

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

<a name="postidentitylookupentity"></a>
# **PostIdentityLookupEntity**
> void PostIdentityLookupEntity (IdentityLookupEntityRequest identityLookupEntityRequest = null)

Query entities based on various properties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityLookupEntityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var identityLookupEntityRequest = new IdentityLookupEntityRequest(); // IdentityLookupEntityRequest |  (optional) 

            try
            {
                // Query entities based on various properties.
                apiInstance.PostIdentityLookupEntity(identityLookupEntityRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityLookupEntity: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identityLookupEntityRequest** | [**IdentityLookupEntityRequest**](IdentityLookupEntityRequest.md)|  | [optional] 

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

<a name="postidentitylookupgroup"></a>
# **PostIdentityLookupGroup**
> void PostIdentityLookupGroup (IdentityLookupGroupRequest identityLookupGroupRequest = null)

Query groups based on various properties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityLookupGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var identityLookupGroupRequest = new IdentityLookupGroupRequest(); // IdentityLookupGroupRequest |  (optional) 

            try
            {
                // Query groups based on various properties.
                apiInstance.PostIdentityLookupGroup(identityLookupGroupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityLookupGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identityLookupGroupRequest** | [**IdentityLookupGroupRequest**](IdentityLookupGroupRequest.md)|  | [optional] 

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

<a name="postidentitymfaloginenforcementname"></a>
# **PostIdentityMfaLoginEnforcementName**
> void PostIdentityMfaLoginEnforcementName (string name, IdentityMfaLoginEnforcementRequest identityMfaLoginEnforcementRequest = null)

Create or update a login enforcement

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityMfaLoginEnforcementNameExample
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
            var identityMfaLoginEnforcementRequest = new IdentityMfaLoginEnforcementRequest(); // IdentityMfaLoginEnforcementRequest |  (optional) 

            try
            {
                // Create or update a login enforcement
                apiInstance.PostIdentityMfaLoginEnforcementName(name, identityMfaLoginEnforcementRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityMfaLoginEnforcementName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name for this login enforcement configuration | 
 **identityMfaLoginEnforcementRequest** | [**IdentityMfaLoginEnforcementRequest**](IdentityMfaLoginEnforcementRequest.md)|  | [optional] 

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

<a name="postidentitymfamethodduomethodid"></a>
# **PostIdentityMfaMethodDuoMethodId**
> void PostIdentityMfaMethodDuoMethodId (string methodId, IdentityMfaMethodDuoRequest identityMfaMethodDuoRequest = null)

Update or create a configuration for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityMfaMethodDuoMethodIdExample
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
            var identityMfaMethodDuoRequest = new IdentityMfaMethodDuoRequest(); // IdentityMfaMethodDuoRequest |  (optional) 

            try
            {
                // Update or create a configuration for the given MFA method
                apiInstance.PostIdentityMfaMethodDuoMethodId(methodId, identityMfaMethodDuoRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityMfaMethodDuoMethodId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **methodId** | **string**| The unique identifier for this MFA method. | 
 **identityMfaMethodDuoRequest** | [**IdentityMfaMethodDuoRequest**](IdentityMfaMethodDuoRequest.md)|  | [optional] 

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

<a name="postidentitymfamethodoktamethodid"></a>
# **PostIdentityMfaMethodOktaMethodId**
> void PostIdentityMfaMethodOktaMethodId (string methodId, IdentityMfaMethodOktaRequest identityMfaMethodOktaRequest = null)

Update or create a configuration for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityMfaMethodOktaMethodIdExample
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
            var identityMfaMethodOktaRequest = new IdentityMfaMethodOktaRequest(); // IdentityMfaMethodOktaRequest |  (optional) 

            try
            {
                // Update or create a configuration for the given MFA method
                apiInstance.PostIdentityMfaMethodOktaMethodId(methodId, identityMfaMethodOktaRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityMfaMethodOktaMethodId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **methodId** | **string**| The unique identifier for this MFA method. | 
 **identityMfaMethodOktaRequest** | [**IdentityMfaMethodOktaRequest**](IdentityMfaMethodOktaRequest.md)|  | [optional] 

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

<a name="postidentitymfamethodpingidmethodid"></a>
# **PostIdentityMfaMethodPingidMethodId**
> void PostIdentityMfaMethodPingidMethodId (string methodId, IdentityMfaMethodPingidRequest identityMfaMethodPingidRequest = null)

Update or create a configuration for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityMfaMethodPingidMethodIdExample
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
            var identityMfaMethodPingidRequest = new IdentityMfaMethodPingidRequest(); // IdentityMfaMethodPingidRequest |  (optional) 

            try
            {
                // Update or create a configuration for the given MFA method
                apiInstance.PostIdentityMfaMethodPingidMethodId(methodId, identityMfaMethodPingidRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityMfaMethodPingidMethodId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **methodId** | **string**| The unique identifier for this MFA method. | 
 **identityMfaMethodPingidRequest** | [**IdentityMfaMethodPingidRequest**](IdentityMfaMethodPingidRequest.md)|  | [optional] 

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

<a name="postidentitymfamethodtotpadmindestroy"></a>
# **PostIdentityMfaMethodTotpAdminDestroy**
> void PostIdentityMfaMethodTotpAdminDestroy (IdentityMfaMethodTotpAdminDestroyRequest identityMfaMethodTotpAdminDestroyRequest = null)

Destroys a TOTP secret for the given MFA method ID on the given entity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityMfaMethodTotpAdminDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var identityMfaMethodTotpAdminDestroyRequest = new IdentityMfaMethodTotpAdminDestroyRequest(); // IdentityMfaMethodTotpAdminDestroyRequest |  (optional) 

            try
            {
                // Destroys a TOTP secret for the given MFA method ID on the given entity
                apiInstance.PostIdentityMfaMethodTotpAdminDestroy(identityMfaMethodTotpAdminDestroyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityMfaMethodTotpAdminDestroy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identityMfaMethodTotpAdminDestroyRequest** | [**IdentityMfaMethodTotpAdminDestroyRequest**](IdentityMfaMethodTotpAdminDestroyRequest.md)|  | [optional] 

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

<a name="postidentitymfamethodtotpadmingenerate"></a>
# **PostIdentityMfaMethodTotpAdminGenerate**
> void PostIdentityMfaMethodTotpAdminGenerate (IdentityMfaMethodTotpAdminGenerateRequest identityMfaMethodTotpAdminGenerateRequest = null)

Update or create TOTP secret for the given method ID on the given entity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityMfaMethodTotpAdminGenerateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var identityMfaMethodTotpAdminGenerateRequest = new IdentityMfaMethodTotpAdminGenerateRequest(); // IdentityMfaMethodTotpAdminGenerateRequest |  (optional) 

            try
            {
                // Update or create TOTP secret for the given method ID on the given entity.
                apiInstance.PostIdentityMfaMethodTotpAdminGenerate(identityMfaMethodTotpAdminGenerateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityMfaMethodTotpAdminGenerate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identityMfaMethodTotpAdminGenerateRequest** | [**IdentityMfaMethodTotpAdminGenerateRequest**](IdentityMfaMethodTotpAdminGenerateRequest.md)|  | [optional] 

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

<a name="postidentitymfamethodtotpgenerate"></a>
# **PostIdentityMfaMethodTotpGenerate**
> void PostIdentityMfaMethodTotpGenerate (IdentityMfaMethodTotpGenerateRequest identityMfaMethodTotpGenerateRequest = null)

Update or create TOTP secret for the given method ID on the given entity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityMfaMethodTotpGenerateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var identityMfaMethodTotpGenerateRequest = new IdentityMfaMethodTotpGenerateRequest(); // IdentityMfaMethodTotpGenerateRequest |  (optional) 

            try
            {
                // Update or create TOTP secret for the given method ID on the given entity.
                apiInstance.PostIdentityMfaMethodTotpGenerate(identityMfaMethodTotpGenerateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityMfaMethodTotpGenerate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identityMfaMethodTotpGenerateRequest** | [**IdentityMfaMethodTotpGenerateRequest**](IdentityMfaMethodTotpGenerateRequest.md)|  | [optional] 

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

<a name="postidentitymfamethodtotpmethodid"></a>
# **PostIdentityMfaMethodTotpMethodId**
> void PostIdentityMfaMethodTotpMethodId (string methodId, IdentityMfaMethodTotpRequest identityMfaMethodTotpRequest = null)

Update or create a configuration for the given MFA method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityMfaMethodTotpMethodIdExample
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
            var identityMfaMethodTotpRequest = new IdentityMfaMethodTotpRequest(); // IdentityMfaMethodTotpRequest |  (optional) 

            try
            {
                // Update or create a configuration for the given MFA method
                apiInstance.PostIdentityMfaMethodTotpMethodId(methodId, identityMfaMethodTotpRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityMfaMethodTotpMethodId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **methodId** | **string**| The unique identifier for this MFA method. | 
 **identityMfaMethodTotpRequest** | [**IdentityMfaMethodTotpRequest**](IdentityMfaMethodTotpRequest.md)|  | [optional] 

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

<a name="postidentityoidcassignmentname"></a>
# **PostIdentityOidcAssignmentName**
> void PostIdentityOidcAssignmentName (string name, IdentityOidcAssignmentRequest identityOidcAssignmentRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityOidcAssignmentNameExample
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
            var identityOidcAssignmentRequest = new IdentityOidcAssignmentRequest(); // IdentityOidcAssignmentRequest |  (optional) 

            try
            {
                apiInstance.PostIdentityOidcAssignmentName(name, identityOidcAssignmentRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityOidcAssignmentName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the assignment | 
 **identityOidcAssignmentRequest** | [**IdentityOidcAssignmentRequest**](IdentityOidcAssignmentRequest.md)|  | [optional] 

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

<a name="postidentityoidcclientname"></a>
# **PostIdentityOidcClientName**
> void PostIdentityOidcClientName (string name, IdentityOidcClientRequest identityOidcClientRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityOidcClientNameExample
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
            var identityOidcClientRequest = new IdentityOidcClientRequest(); // IdentityOidcClientRequest |  (optional) 

            try
            {
                apiInstance.PostIdentityOidcClientName(name, identityOidcClientRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityOidcClientName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the client. | 
 **identityOidcClientRequest** | [**IdentityOidcClientRequest**](IdentityOidcClientRequest.md)|  | [optional] 

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

<a name="postidentityoidcconfig"></a>
# **PostIdentityOidcConfig**
> void PostIdentityOidcConfig (IdentityOidcConfigRequest identityOidcConfigRequest = null)

OIDC configuration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityOidcConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var identityOidcConfigRequest = new IdentityOidcConfigRequest(); // IdentityOidcConfigRequest |  (optional) 

            try
            {
                // OIDC configuration
                apiInstance.PostIdentityOidcConfig(identityOidcConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityOidcConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identityOidcConfigRequest** | [**IdentityOidcConfigRequest**](IdentityOidcConfigRequest.md)|  | [optional] 

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

<a name="postidentityoidcintrospect"></a>
# **PostIdentityOidcIntrospect**
> void PostIdentityOidcIntrospect (IdentityOidcIntrospectRequest identityOidcIntrospectRequest = null)

Verify the authenticity of an OIDC token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityOidcIntrospectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var identityOidcIntrospectRequest = new IdentityOidcIntrospectRequest(); // IdentityOidcIntrospectRequest |  (optional) 

            try
            {
                // Verify the authenticity of an OIDC token
                apiInstance.PostIdentityOidcIntrospect(identityOidcIntrospectRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityOidcIntrospect: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identityOidcIntrospectRequest** | [**IdentityOidcIntrospectRequest**](IdentityOidcIntrospectRequest.md)|  | [optional] 

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

<a name="postidentityoidckeyname"></a>
# **PostIdentityOidcKeyName**
> void PostIdentityOidcKeyName (string name, IdentityOidcKeyRequest identityOidcKeyRequest = null)

CRUD operations for OIDC keys.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityOidcKeyNameExample
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
            var identityOidcKeyRequest = new IdentityOidcKeyRequest(); // IdentityOidcKeyRequest |  (optional) 

            try
            {
                // CRUD operations for OIDC keys.
                apiInstance.PostIdentityOidcKeyName(name, identityOidcKeyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityOidcKeyName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the key | 
 **identityOidcKeyRequest** | [**IdentityOidcKeyRequest**](IdentityOidcKeyRequest.md)|  | [optional] 

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

<a name="postidentityoidckeynamerotate"></a>
# **PostIdentityOidcKeyNameRotate**
> void PostIdentityOidcKeyNameRotate (string name, IdentityOidcKeyRotateRequest identityOidcKeyRotateRequest = null)

Rotate a named OIDC key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityOidcKeyNameRotateExample
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
            var identityOidcKeyRotateRequest = new IdentityOidcKeyRotateRequest(); // IdentityOidcKeyRotateRequest |  (optional) 

            try
            {
                // Rotate a named OIDC key.
                apiInstance.PostIdentityOidcKeyNameRotate(name, identityOidcKeyRotateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityOidcKeyNameRotate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the key | 
 **identityOidcKeyRotateRequest** | [**IdentityOidcKeyRotateRequest**](IdentityOidcKeyRotateRequest.md)|  | [optional] 

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

<a name="postidentityoidcprovidername"></a>
# **PostIdentityOidcProviderName**
> void PostIdentityOidcProviderName (string name, IdentityOidcProviderRequest identityOidcProviderRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityOidcProviderNameExample
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
            var identityOidcProviderRequest = new IdentityOidcProviderRequest(); // IdentityOidcProviderRequest |  (optional) 

            try
            {
                apiInstance.PostIdentityOidcProviderName(name, identityOidcProviderRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityOidcProviderName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the provider | 
 **identityOidcProviderRequest** | [**IdentityOidcProviderRequest**](IdentityOidcProviderRequest.md)|  | [optional] 

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

<a name="postidentityoidcprovidernameauthorize"></a>
# **PostIdentityOidcProviderNameAuthorize**
> void PostIdentityOidcProviderNameAuthorize (string name, IdentityOidcProviderAuthorizeRequest identityOidcProviderAuthorizeRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityOidcProviderNameAuthorizeExample
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
            var identityOidcProviderAuthorizeRequest = new IdentityOidcProviderAuthorizeRequest(); // IdentityOidcProviderAuthorizeRequest |  (optional) 

            try
            {
                apiInstance.PostIdentityOidcProviderNameAuthorize(name, identityOidcProviderAuthorizeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityOidcProviderNameAuthorize: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the provider | 
 **identityOidcProviderAuthorizeRequest** | [**IdentityOidcProviderAuthorizeRequest**](IdentityOidcProviderAuthorizeRequest.md)|  | [optional] 

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

<a name="postidentityoidcprovidernametoken"></a>
# **PostIdentityOidcProviderNameToken**
> void PostIdentityOidcProviderNameToken (string name, IdentityOidcProviderTokenRequest identityOidcProviderTokenRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityOidcProviderNameTokenExample
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
            var identityOidcProviderTokenRequest = new IdentityOidcProviderTokenRequest(); // IdentityOidcProviderTokenRequest |  (optional) 

            try
            {
                apiInstance.PostIdentityOidcProviderNameToken(name, identityOidcProviderTokenRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityOidcProviderNameToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the provider | 
 **identityOidcProviderTokenRequest** | [**IdentityOidcProviderTokenRequest**](IdentityOidcProviderTokenRequest.md)|  | [optional] 

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

<a name="postidentityoidcprovidernameuserinfo"></a>
# **PostIdentityOidcProviderNameUserinfo**
> void PostIdentityOidcProviderNameUserinfo (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityOidcProviderNameUserinfoExample
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
                apiInstance.PostIdentityOidcProviderNameUserinfo(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityOidcProviderNameUserinfo: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="postidentityoidcrolename"></a>
# **PostIdentityOidcRoleName**
> void PostIdentityOidcRoleName (string name, IdentityOidcRoleRequest identityOidcRoleRequest = null)

CRUD operations on OIDC Roles

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityOidcRoleNameExample
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
            var identityOidcRoleRequest = new IdentityOidcRoleRequest(); // IdentityOidcRoleRequest |  (optional) 

            try
            {
                // CRUD operations on OIDC Roles
                apiInstance.PostIdentityOidcRoleName(name, identityOidcRoleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityOidcRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the role | 
 **identityOidcRoleRequest** | [**IdentityOidcRoleRequest**](IdentityOidcRoleRequest.md)|  | [optional] 

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

<a name="postidentityoidcscopename"></a>
# **PostIdentityOidcScopeName**
> void PostIdentityOidcScopeName (string name, IdentityOidcScopeRequest identityOidcScopeRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityOidcScopeNameExample
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
            var identityOidcScopeRequest = new IdentityOidcScopeRequest(); // IdentityOidcScopeRequest |  (optional) 

            try
            {
                apiInstance.PostIdentityOidcScopeName(name, identityOidcScopeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityOidcScopeName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the scope | 
 **identityOidcScopeRequest** | [**IdentityOidcScopeRequest**](IdentityOidcScopeRequest.md)|  | [optional] 

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

<a name="postidentitypersona"></a>
# **PostIdentityPersona**
> void PostIdentityPersona (IdentityPersonaRequest identityPersonaRequest = null)

Create a new alias.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityPersonaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Identity(httpClient, config, httpClientHandler);
            var identityPersonaRequest = new IdentityPersonaRequest(); // IdentityPersonaRequest |  (optional) 

            try
            {
                // Create a new alias.
                apiInstance.PostIdentityPersona(identityPersonaRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityPersona: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identityPersonaRequest** | [**IdentityPersonaRequest**](IdentityPersonaRequest.md)|  | [optional] 

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

<a name="postidentitypersonaidid"></a>
# **PostIdentityPersonaIdId**
> void PostIdentityPersonaIdId (string id, IdentityPersonaIdRequest identityPersonaIdRequest = null)

Update, read or delete an alias ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostIdentityPersonaIdIdExample
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
            var identityPersonaIdRequest = new IdentityPersonaIdRequest(); // IdentityPersonaIdRequest |  (optional) 

            try
            {
                // Update, read or delete an alias ID.
                apiInstance.PostIdentityPersonaIdId(id, identityPersonaIdRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.PostIdentityPersonaIdId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the persona | 
 **identityPersonaIdRequest** | [**IdentityPersonaIdRequest**](IdentityPersonaIdRequest.md)|  | [optional] 

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

