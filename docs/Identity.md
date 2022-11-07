# Vault.Api.Identity

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
[**ListIdentityAliasId**](Identity.md#listidentityaliasid) | **GET** /identity/alias/id | List all the alias IDs.
[**ListIdentityEntityAliasId**](Identity.md#listidentityentityaliasid) | **GET** /identity/entity-alias/id | List all the alias IDs.
[**ListIdentityEntityId**](Identity.md#listidentityentityid) | **GET** /identity/entity/id | List all the entity IDs
[**ListIdentityEntityName**](Identity.md#listidentityentityname) | **GET** /identity/entity/name | List all the entity names
[**ListIdentityGroupAliasId**](Identity.md#listidentitygroupaliasid) | **GET** /identity/group-alias/id | List all the group alias IDs.
[**ListIdentityGroupId**](Identity.md#listidentitygroupid) | **GET** /identity/group/id | List all the group IDs.
[**ListIdentityGroupName**](Identity.md#listidentitygroupname) | **GET** /identity/group/name | 
[**ListIdentityMfaLoginEnforcement**](Identity.md#listidentitymfaloginenforcement) | **GET** /identity/mfa/login-enforcement | List login enforcements
[**ListIdentityMfaMethod**](Identity.md#listidentitymfamethod) | **GET** /identity/mfa/method | List MFA method configurations for all MFA methods
[**ListIdentityMfaMethodDuo**](Identity.md#listidentitymfamethodduo) | **GET** /identity/mfa/method/duo | List MFA method configurations for the given MFA method
[**ListIdentityMfaMethodOkta**](Identity.md#listidentitymfamethodokta) | **GET** /identity/mfa/method/okta | List MFA method configurations for the given MFA method
[**ListIdentityMfaMethodPingid**](Identity.md#listidentitymfamethodpingid) | **GET** /identity/mfa/method/pingid | List MFA method configurations for the given MFA method
[**ListIdentityMfaMethodTotp**](Identity.md#listidentitymfamethodtotp) | **GET** /identity/mfa/method/totp | List MFA method configurations for the given MFA method
[**ListIdentityOidcAssignment**](Identity.md#listidentityoidcassignment) | **GET** /identity/oidc/assignment | 
[**ListIdentityOidcClient**](Identity.md#listidentityoidcclient) | **GET** /identity/oidc/client | 
[**ListIdentityOidcKey**](Identity.md#listidentityoidckey) | **GET** /identity/oidc/key | List OIDC keys
[**ListIdentityOidcProvider**](Identity.md#listidentityoidcprovider) | **GET** /identity/oidc/provider | 
[**ListIdentityOidcRole**](Identity.md#listidentityoidcrole) | **GET** /identity/oidc/role | List configured OIDC roles
[**ListIdentityOidcScope**](Identity.md#listidentityoidcscope) | **GET** /identity/oidc/scope | 
[**ListIdentityPersonaId**](Identity.md#listidentitypersonaid) | **GET** /identity/persona/id | List all the alias IDs.
[**ReadIdentityAliasIdId**](Identity.md#readidentityaliasidid) | **GET** /identity/alias/id/{id} | Update, read or delete an alias ID.
[**ReadIdentityEntityAliasIdId**](Identity.md#readidentityentityaliasidid) | **GET** /identity/entity-alias/id/{id} | Update, read or delete an alias ID.
[**ReadIdentityEntityIdId**](Identity.md#readidentityentityidid) | **GET** /identity/entity/id/{id} | Update, read or delete an entity using entity ID
[**ReadIdentityEntityNameName**](Identity.md#readidentityentitynamename) | **GET** /identity/entity/name/{name} | Update, read or delete an entity using entity name
[**ReadIdentityGroupAliasIdId**](Identity.md#readidentitygroupaliasidid) | **GET** /identity/group-alias/id/{id} | 
[**ReadIdentityGroupIdId**](Identity.md#readidentitygroupidid) | **GET** /identity/group/id/{id} | Update or delete an existing group using its ID.
[**ReadIdentityGroupNameName**](Identity.md#readidentitygroupnamename) | **GET** /identity/group/name/{name} | 
[**ReadIdentityMfaLoginEnforcementName**](Identity.md#readidentitymfaloginenforcementname) | **GET** /identity/mfa/login-enforcement/{name} | Read the current login enforcement
[**ReadIdentityMfaMethodDuoMethodId**](Identity.md#readidentitymfamethodduomethodid) | **GET** /identity/mfa/method/duo/{method_id} | Read the current configuration for the given MFA method
[**ReadIdentityMfaMethodMethodId**](Identity.md#readidentitymfamethodmethodid) | **GET** /identity/mfa/method/{method_id} | Read the current configuration for the given ID regardless of the MFA method type
[**ReadIdentityMfaMethodOktaMethodId**](Identity.md#readidentitymfamethodoktamethodid) | **GET** /identity/mfa/method/okta/{method_id} | Read the current configuration for the given MFA method
[**ReadIdentityMfaMethodPingidMethodId**](Identity.md#readidentitymfamethodpingidmethodid) | **GET** /identity/mfa/method/pingid/{method_id} | Read the current configuration for the given MFA method
[**ReadIdentityMfaMethodTotpMethodId**](Identity.md#readidentitymfamethodtotpmethodid) | **GET** /identity/mfa/method/totp/{method_id} | Read the current configuration for the given MFA method
[**ReadIdentityOidcAssignmentName**](Identity.md#readidentityoidcassignmentname) | **GET** /identity/oidc/assignment/{name} | 
[**ReadIdentityOidcClientName**](Identity.md#readidentityoidcclientname) | **GET** /identity/oidc/client/{name} | 
[**ReadIdentityOidcConfig**](Identity.md#readidentityoidcconfig) | **GET** /identity/oidc/config | OIDC configuration
[**ReadIdentityOidcKeyName**](Identity.md#readidentityoidckeyname) | **GET** /identity/oidc/key/{name} | CRUD operations for OIDC keys.
[**ReadIdentityOidcProviderName**](Identity.md#readidentityoidcprovidername) | **GET** /identity/oidc/provider/{name} | 
[**ReadIdentityOidcProviderNameAuthorize**](Identity.md#readidentityoidcprovidernameauthorize) | **GET** /identity/oidc/provider/{name}/authorize | 
[**ReadIdentityOidcProviderNameUserinfo**](Identity.md#readidentityoidcprovidernameuserinfo) | **GET** /identity/oidc/provider/{name}/userinfo | 
[**ReadIdentityOidcProviderNameWellKnownKeys**](Identity.md#readidentityoidcprovidernamewellknownkeys) | **GET** /identity/oidc/provider/{name}/.well-known/keys | 
[**ReadIdentityOidcProviderNameWellKnownOpenidConfiguration**](Identity.md#readidentityoidcprovidernamewellknownopenidconfiguration) | **GET** /identity/oidc/provider/{name}/.well-known/openid-configuration | 
[**ReadIdentityOidcRoleName**](Identity.md#readidentityoidcrolename) | **GET** /identity/oidc/role/{name} | CRUD operations on OIDC Roles
[**ReadIdentityOidcScopeName**](Identity.md#readidentityoidcscopename) | **GET** /identity/oidc/scope/{name} | 
[**ReadIdentityOidcTokenName**](Identity.md#readidentityoidctokenname) | **GET** /identity/oidc/token/{name} | Generate an OIDC token
[**ReadIdentityOidcWellKnownKeys**](Identity.md#readidentityoidcwellknownkeys) | **GET** /identity/oidc/.well-known/keys | Retrieve public keys
[**ReadIdentityOidcWellKnownOpenidConfiguration**](Identity.md#readidentityoidcwellknownopenidconfiguration) | **GET** /identity/oidc/.well-known/openid-configuration | Query OIDC configurations
[**ReadIdentityPersonaIdId**](Identity.md#readidentitypersonaidid) | **GET** /identity/persona/id/{id} | Update, read or delete an alias ID.
[**UpdateIdentityAlias**](Identity.md#updateidentityalias) | **POST** /identity/alias | Create a new alias.
[**UpdateIdentityAliasIdId**](Identity.md#updateidentityaliasidid) | **POST** /identity/alias/id/{id} | Update, read or delete an alias ID.
[**UpdateIdentityEntity**](Identity.md#updateidentityentity) | **POST** /identity/entity | Create a new entity
[**UpdateIdentityEntityAlias**](Identity.md#updateidentityentityalias) | **POST** /identity/entity-alias | Create a new alias.
[**UpdateIdentityEntityAliasIdId**](Identity.md#updateidentityentityaliasidid) | **POST** /identity/entity-alias/id/{id} | Update, read or delete an alias ID.
[**UpdateIdentityEntityBatchDelete**](Identity.md#updateidentityentitybatchdelete) | **POST** /identity/entity/batch-delete | Delete all of the entities provided
[**UpdateIdentityEntityIdId**](Identity.md#updateidentityentityidid) | **POST** /identity/entity/id/{id} | Update, read or delete an entity using entity ID
[**UpdateIdentityEntityMerge**](Identity.md#updateidentityentitymerge) | **POST** /identity/entity/merge | Merge two or more entities together
[**UpdateIdentityEntityNameName**](Identity.md#updateidentityentitynamename) | **POST** /identity/entity/name/{name} | Update, read or delete an entity using entity name
[**UpdateIdentityGroup**](Identity.md#updateidentitygroup) | **POST** /identity/group | Create a new group.
[**UpdateIdentityGroupAlias**](Identity.md#updateidentitygroupalias) | **POST** /identity/group-alias | Creates a new group alias, or updates an existing one.
[**UpdateIdentityGroupAliasIdId**](Identity.md#updateidentitygroupaliasidid) | **POST** /identity/group-alias/id/{id} | 
[**UpdateIdentityGroupIdId**](Identity.md#updateidentitygroupidid) | **POST** /identity/group/id/{id} | Update or delete an existing group using its ID.
[**UpdateIdentityGroupNameName**](Identity.md#updateidentitygroupnamename) | **POST** /identity/group/name/{name} | 
[**UpdateIdentityLookupEntity**](Identity.md#updateidentitylookupentity) | **POST** /identity/lookup/entity | Query entities based on various properties.
[**UpdateIdentityLookupGroup**](Identity.md#updateidentitylookupgroup) | **POST** /identity/lookup/group | Query groups based on various properties.
[**UpdateIdentityMfaLoginEnforcementName**](Identity.md#updateidentitymfaloginenforcementname) | **POST** /identity/mfa/login-enforcement/{name} | Create or update a login enforcement
[**UpdateIdentityMfaMethodDuoMethodId**](Identity.md#updateidentitymfamethodduomethodid) | **POST** /identity/mfa/method/duo/{method_id} | Update or create a configuration for the given MFA method
[**UpdateIdentityMfaMethodOktaMethodId**](Identity.md#updateidentitymfamethodoktamethodid) | **POST** /identity/mfa/method/okta/{method_id} | Update or create a configuration for the given MFA method
[**UpdateIdentityMfaMethodPingidMethodId**](Identity.md#updateidentitymfamethodpingidmethodid) | **POST** /identity/mfa/method/pingid/{method_id} | Update or create a configuration for the given MFA method
[**UpdateIdentityMfaMethodTotpAdminDestroy**](Identity.md#updateidentitymfamethodtotpadmindestroy) | **POST** /identity/mfa/method/totp/admin-destroy | Destroys a TOTP secret for the given MFA method ID on the given entity
[**UpdateIdentityMfaMethodTotpAdminGenerate**](Identity.md#updateidentitymfamethodtotpadmingenerate) | **POST** /identity/mfa/method/totp/admin-generate | Update or create TOTP secret for the given method ID on the given entity.
[**UpdateIdentityMfaMethodTotpGenerate**](Identity.md#updateidentitymfamethodtotpgenerate) | **POST** /identity/mfa/method/totp/generate | Update or create TOTP secret for the given method ID on the given entity.
[**UpdateIdentityMfaMethodTotpMethodId**](Identity.md#updateidentitymfamethodtotpmethodid) | **POST** /identity/mfa/method/totp/{method_id} | Update or create a configuration for the given MFA method
[**UpdateIdentityOidcAssignmentName**](Identity.md#updateidentityoidcassignmentname) | **POST** /identity/oidc/assignment/{name} | 
[**UpdateIdentityOidcClientName**](Identity.md#updateidentityoidcclientname) | **POST** /identity/oidc/client/{name} | 
[**UpdateIdentityOidcConfig**](Identity.md#updateidentityoidcconfig) | **POST** /identity/oidc/config | OIDC configuration
[**UpdateIdentityOidcIntrospect**](Identity.md#updateidentityoidcintrospect) | **POST** /identity/oidc/introspect | Verify the authenticity of an OIDC token
[**UpdateIdentityOidcKeyName**](Identity.md#updateidentityoidckeyname) | **POST** /identity/oidc/key/{name} | CRUD operations for OIDC keys.
[**UpdateIdentityOidcKeyNameRotate**](Identity.md#updateidentityoidckeynamerotate) | **POST** /identity/oidc/key/{name}/rotate | Rotate a named OIDC key.
[**UpdateIdentityOidcProviderName**](Identity.md#updateidentityoidcprovidername) | **POST** /identity/oidc/provider/{name} | 
[**UpdateIdentityOidcProviderNameAuthorize**](Identity.md#updateidentityoidcprovidernameauthorize) | **POST** /identity/oidc/provider/{name}/authorize | 
[**UpdateIdentityOidcProviderNameToken**](Identity.md#updateidentityoidcprovidernametoken) | **POST** /identity/oidc/provider/{name}/token | 
[**UpdateIdentityOidcProviderNameUserinfo**](Identity.md#updateidentityoidcprovidernameuserinfo) | **POST** /identity/oidc/provider/{name}/userinfo | 
[**UpdateIdentityOidcRoleName**](Identity.md#updateidentityoidcrolename) | **POST** /identity/oidc/role/{name} | CRUD operations on OIDC Roles
[**UpdateIdentityOidcScopeName**](Identity.md#updateidentityoidcscopename) | **POST** /identity/oidc/scope/{name} | 
[**UpdateIdentityPersona**](Identity.md#updateidentitypersona) | **POST** /identity/persona | Create a new alias.
[**UpdateIdentityPersonaIdId**](Identity.md#updateidentitypersonaidid) | **POST** /identity/persona/id/{id} | Update, read or delete an alias ID.


<a name="deleteidentityaliasidid"></a>
# **DeleteIdentityAliasIdId**
> void DeleteIdentityAliasIdId (string id)

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
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
using Vault.Api;
using Vault.Client;
using Vault.Model;

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

<a name="listidentityaliasid"></a>
# **ListIdentityAliasId**
> void ListIdentityAliasId (string list)

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
    public class ListIdentityAliasIdExample
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
                apiInstance.ListIdentityAliasId(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ListIdentityAliasId: " + e.Message );
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

<a name="listidentityentityaliasid"></a>
# **ListIdentityEntityAliasId**
> void ListIdentityEntityAliasId (string list)

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
    public class ListIdentityEntityAliasIdExample
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
                apiInstance.ListIdentityEntityAliasId(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ListIdentityEntityAliasId: " + e.Message );
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

<a name="listidentityentityid"></a>
# **ListIdentityEntityId**
> void ListIdentityEntityId (string list)

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
    public class ListIdentityEntityIdExample
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
                apiInstance.ListIdentityEntityId(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ListIdentityEntityId: " + e.Message );
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

<a name="listidentityentityname"></a>
# **ListIdentityEntityName**
> void ListIdentityEntityName (string list)

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
    public class ListIdentityEntityNameExample
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
                apiInstance.ListIdentityEntityName(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ListIdentityEntityName: " + e.Message );
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

<a name="listidentitygroupaliasid"></a>
# **ListIdentityGroupAliasId**
> void ListIdentityGroupAliasId (string list)

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
    public class ListIdentityGroupAliasIdExample
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
                apiInstance.ListIdentityGroupAliasId(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ListIdentityGroupAliasId: " + e.Message );
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

<a name="listidentitygroupid"></a>
# **ListIdentityGroupId**
> void ListIdentityGroupId (string list)

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
    public class ListIdentityGroupIdExample
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
                apiInstance.ListIdentityGroupId(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ListIdentityGroupId: " + e.Message );
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

<a name="listidentitygroupname"></a>
# **ListIdentityGroupName**
> void ListIdentityGroupName (string list)



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
    public class ListIdentityGroupNameExample
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
                apiInstance.ListIdentityGroupName(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ListIdentityGroupName: " + e.Message );
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

<a name="listidentitymfaloginenforcement"></a>
# **ListIdentityMfaLoginEnforcement**
> void ListIdentityMfaLoginEnforcement (string list)

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
    public class ListIdentityMfaLoginEnforcementExample
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
                apiInstance.ListIdentityMfaLoginEnforcement(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ListIdentityMfaLoginEnforcement: " + e.Message );
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

<a name="listidentitymfamethod"></a>
# **ListIdentityMfaMethod**
> void ListIdentityMfaMethod (string list)

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
    public class ListIdentityMfaMethodExample
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
                apiInstance.ListIdentityMfaMethod(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ListIdentityMfaMethod: " + e.Message );
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

<a name="listidentitymfamethodduo"></a>
# **ListIdentityMfaMethodDuo**
> void ListIdentityMfaMethodDuo (string list)

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
    public class ListIdentityMfaMethodDuoExample
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
                apiInstance.ListIdentityMfaMethodDuo(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ListIdentityMfaMethodDuo: " + e.Message );
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

<a name="listidentitymfamethodokta"></a>
# **ListIdentityMfaMethodOkta**
> void ListIdentityMfaMethodOkta (string list)

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
    public class ListIdentityMfaMethodOktaExample
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
                apiInstance.ListIdentityMfaMethodOkta(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ListIdentityMfaMethodOkta: " + e.Message );
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

<a name="listidentitymfamethodpingid"></a>
# **ListIdentityMfaMethodPingid**
> void ListIdentityMfaMethodPingid (string list)

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
    public class ListIdentityMfaMethodPingidExample
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
                apiInstance.ListIdentityMfaMethodPingid(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ListIdentityMfaMethodPingid: " + e.Message );
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

<a name="listidentitymfamethodtotp"></a>
# **ListIdentityMfaMethodTotp**
> void ListIdentityMfaMethodTotp (string list)

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
    public class ListIdentityMfaMethodTotpExample
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
                apiInstance.ListIdentityMfaMethodTotp(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ListIdentityMfaMethodTotp: " + e.Message );
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

<a name="listidentityoidcassignment"></a>
# **ListIdentityOidcAssignment**
> void ListIdentityOidcAssignment (string list)



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
    public class ListIdentityOidcAssignmentExample
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
                apiInstance.ListIdentityOidcAssignment(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ListIdentityOidcAssignment: " + e.Message );
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

<a name="listidentityoidcclient"></a>
# **ListIdentityOidcClient**
> void ListIdentityOidcClient (string list)



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
    public class ListIdentityOidcClientExample
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
                apiInstance.ListIdentityOidcClient(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ListIdentityOidcClient: " + e.Message );
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

<a name="listidentityoidckey"></a>
# **ListIdentityOidcKey**
> void ListIdentityOidcKey (string list)

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
    public class ListIdentityOidcKeyExample
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
                apiInstance.ListIdentityOidcKey(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ListIdentityOidcKey: " + e.Message );
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

<a name="listidentityoidcprovider"></a>
# **ListIdentityOidcProvider**
> void ListIdentityOidcProvider (string list, string allowedClientId = null)



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
    public class ListIdentityOidcProviderExample
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
                apiInstance.ListIdentityOidcProvider(list, allowedClientId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ListIdentityOidcProvider: " + e.Message );
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

<a name="listidentityoidcrole"></a>
# **ListIdentityOidcRole**
> void ListIdentityOidcRole (string list)

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
    public class ListIdentityOidcRoleExample
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
                apiInstance.ListIdentityOidcRole(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ListIdentityOidcRole: " + e.Message );
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

<a name="listidentityoidcscope"></a>
# **ListIdentityOidcScope**
> void ListIdentityOidcScope (string list)



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
    public class ListIdentityOidcScopeExample
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
                apiInstance.ListIdentityOidcScope(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ListIdentityOidcScope: " + e.Message );
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

<a name="listidentitypersonaid"></a>
# **ListIdentityPersonaId**
> void ListIdentityPersonaId (string list)

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
    public class ListIdentityPersonaIdExample
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
                apiInstance.ListIdentityPersonaId(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ListIdentityPersonaId: " + e.Message );
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

<a name="readidentityaliasidid"></a>
# **ReadIdentityAliasIdId**
> void ReadIdentityAliasIdId (string id)

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
    public class ReadIdentityAliasIdIdExample
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
                apiInstance.ReadIdentityAliasIdId(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityAliasIdId: " + e.Message );
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

<a name="readidentityentityaliasidid"></a>
# **ReadIdentityEntityAliasIdId**
> void ReadIdentityEntityAliasIdId (string id)

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
    public class ReadIdentityEntityAliasIdIdExample
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
                apiInstance.ReadIdentityEntityAliasIdId(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityEntityAliasIdId: " + e.Message );
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

<a name="readidentityentityidid"></a>
# **ReadIdentityEntityIdId**
> void ReadIdentityEntityIdId (string id)

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
    public class ReadIdentityEntityIdIdExample
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
                apiInstance.ReadIdentityEntityIdId(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityEntityIdId: " + e.Message );
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

<a name="readidentityentitynamename"></a>
# **ReadIdentityEntityNameName**
> void ReadIdentityEntityNameName (string name)

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
    public class ReadIdentityEntityNameNameExample
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
                apiInstance.ReadIdentityEntityNameName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityEntityNameName: " + e.Message );
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

<a name="readidentitygroupaliasidid"></a>
# **ReadIdentityGroupAliasIdId**
> void ReadIdentityGroupAliasIdId (string id)



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
    public class ReadIdentityGroupAliasIdIdExample
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
                apiInstance.ReadIdentityGroupAliasIdId(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityGroupAliasIdId: " + e.Message );
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

<a name="readidentitygroupidid"></a>
# **ReadIdentityGroupIdId**
> void ReadIdentityGroupIdId (string id)

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
    public class ReadIdentityGroupIdIdExample
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
                apiInstance.ReadIdentityGroupIdId(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityGroupIdId: " + e.Message );
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

<a name="readidentitygroupnamename"></a>
# **ReadIdentityGroupNameName**
> void ReadIdentityGroupNameName (string name)



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
    public class ReadIdentityGroupNameNameExample
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
                apiInstance.ReadIdentityGroupNameName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityGroupNameName: " + e.Message );
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

<a name="readidentitymfaloginenforcementname"></a>
# **ReadIdentityMfaLoginEnforcementName**
> void ReadIdentityMfaLoginEnforcementName (string name)

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
    public class ReadIdentityMfaLoginEnforcementNameExample
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
                apiInstance.ReadIdentityMfaLoginEnforcementName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityMfaLoginEnforcementName: " + e.Message );
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

<a name="readidentitymfamethodduomethodid"></a>
# **ReadIdentityMfaMethodDuoMethodId**
> void ReadIdentityMfaMethodDuoMethodId (string methodId)

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
    public class ReadIdentityMfaMethodDuoMethodIdExample
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
                apiInstance.ReadIdentityMfaMethodDuoMethodId(methodId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityMfaMethodDuoMethodId: " + e.Message );
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

<a name="readidentitymfamethodmethodid"></a>
# **ReadIdentityMfaMethodMethodId**
> void ReadIdentityMfaMethodMethodId (string methodId)

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
    public class ReadIdentityMfaMethodMethodIdExample
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
                apiInstance.ReadIdentityMfaMethodMethodId(methodId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityMfaMethodMethodId: " + e.Message );
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

<a name="readidentitymfamethodoktamethodid"></a>
# **ReadIdentityMfaMethodOktaMethodId**
> void ReadIdentityMfaMethodOktaMethodId (string methodId)

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
    public class ReadIdentityMfaMethodOktaMethodIdExample
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
                apiInstance.ReadIdentityMfaMethodOktaMethodId(methodId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityMfaMethodOktaMethodId: " + e.Message );
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

<a name="readidentitymfamethodpingidmethodid"></a>
# **ReadIdentityMfaMethodPingidMethodId**
> void ReadIdentityMfaMethodPingidMethodId (string methodId)

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
    public class ReadIdentityMfaMethodPingidMethodIdExample
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
                apiInstance.ReadIdentityMfaMethodPingidMethodId(methodId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityMfaMethodPingidMethodId: " + e.Message );
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

<a name="readidentitymfamethodtotpmethodid"></a>
# **ReadIdentityMfaMethodTotpMethodId**
> void ReadIdentityMfaMethodTotpMethodId (string methodId)

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
    public class ReadIdentityMfaMethodTotpMethodIdExample
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
                apiInstance.ReadIdentityMfaMethodTotpMethodId(methodId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityMfaMethodTotpMethodId: " + e.Message );
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

<a name="readidentityoidcassignmentname"></a>
# **ReadIdentityOidcAssignmentName**
> void ReadIdentityOidcAssignmentName (string name)



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
    public class ReadIdentityOidcAssignmentNameExample
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
                apiInstance.ReadIdentityOidcAssignmentName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityOidcAssignmentName: " + e.Message );
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

<a name="readidentityoidcclientname"></a>
# **ReadIdentityOidcClientName**
> void ReadIdentityOidcClientName (string name)



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
    public class ReadIdentityOidcClientNameExample
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
                apiInstance.ReadIdentityOidcClientName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityOidcClientName: " + e.Message );
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

<a name="readidentityoidcconfig"></a>
# **ReadIdentityOidcConfig**
> void ReadIdentityOidcConfig ()

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
    public class ReadIdentityOidcConfigExample
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
                apiInstance.ReadIdentityOidcConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityOidcConfig: " + e.Message );
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

<a name="readidentityoidckeyname"></a>
# **ReadIdentityOidcKeyName**
> void ReadIdentityOidcKeyName (string name)

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
    public class ReadIdentityOidcKeyNameExample
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
                apiInstance.ReadIdentityOidcKeyName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityOidcKeyName: " + e.Message );
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

<a name="readidentityoidcprovidername"></a>
# **ReadIdentityOidcProviderName**
> void ReadIdentityOidcProviderName (string name)



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
    public class ReadIdentityOidcProviderNameExample
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
                apiInstance.ReadIdentityOidcProviderName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityOidcProviderName: " + e.Message );
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

<a name="readidentityoidcprovidernameauthorize"></a>
# **ReadIdentityOidcProviderNameAuthorize**
> void ReadIdentityOidcProviderNameAuthorize (string name)



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
    public class ReadIdentityOidcProviderNameAuthorizeExample
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
                apiInstance.ReadIdentityOidcProviderNameAuthorize(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityOidcProviderNameAuthorize: " + e.Message );
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

<a name="readidentityoidcprovidernameuserinfo"></a>
# **ReadIdentityOidcProviderNameUserinfo**
> void ReadIdentityOidcProviderNameUserinfo (string name)



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
    public class ReadIdentityOidcProviderNameUserinfoExample
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
                apiInstance.ReadIdentityOidcProviderNameUserinfo(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityOidcProviderNameUserinfo: " + e.Message );
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

<a name="readidentityoidcprovidernamewellknownkeys"></a>
# **ReadIdentityOidcProviderNameWellKnownKeys**
> void ReadIdentityOidcProviderNameWellKnownKeys (string name)



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
    public class ReadIdentityOidcProviderNameWellKnownKeysExample
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
                apiInstance.ReadIdentityOidcProviderNameWellKnownKeys(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityOidcProviderNameWellKnownKeys: " + e.Message );
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

<a name="readidentityoidcprovidernamewellknownopenidconfiguration"></a>
# **ReadIdentityOidcProviderNameWellKnownOpenidConfiguration**
> void ReadIdentityOidcProviderNameWellKnownOpenidConfiguration (string name)



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
    public class ReadIdentityOidcProviderNameWellKnownOpenidConfigurationExample
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
                apiInstance.ReadIdentityOidcProviderNameWellKnownOpenidConfiguration(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityOidcProviderNameWellKnownOpenidConfiguration: " + e.Message );
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

<a name="readidentityoidcrolename"></a>
# **ReadIdentityOidcRoleName**
> void ReadIdentityOidcRoleName (string name)

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
    public class ReadIdentityOidcRoleNameExample
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
                apiInstance.ReadIdentityOidcRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityOidcRoleName: " + e.Message );
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

<a name="readidentityoidcscopename"></a>
# **ReadIdentityOidcScopeName**
> void ReadIdentityOidcScopeName (string name)



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
    public class ReadIdentityOidcScopeNameExample
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
                apiInstance.ReadIdentityOidcScopeName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityOidcScopeName: " + e.Message );
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

<a name="readidentityoidctokenname"></a>
# **ReadIdentityOidcTokenName**
> void ReadIdentityOidcTokenName (string name)

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
    public class ReadIdentityOidcTokenNameExample
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
                apiInstance.ReadIdentityOidcTokenName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityOidcTokenName: " + e.Message );
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

<a name="readidentityoidcwellknownkeys"></a>
# **ReadIdentityOidcWellKnownKeys**
> void ReadIdentityOidcWellKnownKeys ()

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
    public class ReadIdentityOidcWellKnownKeysExample
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
                apiInstance.ReadIdentityOidcWellKnownKeys();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityOidcWellKnownKeys: " + e.Message );
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

<a name="readidentityoidcwellknownopenidconfiguration"></a>
# **ReadIdentityOidcWellKnownOpenidConfiguration**
> void ReadIdentityOidcWellKnownOpenidConfiguration ()

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
    public class ReadIdentityOidcWellKnownOpenidConfigurationExample
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
                apiInstance.ReadIdentityOidcWellKnownOpenidConfiguration();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityOidcWellKnownOpenidConfiguration: " + e.Message );
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

<a name="readidentitypersonaidid"></a>
# **ReadIdentityPersonaIdId**
> void ReadIdentityPersonaIdId (string id)

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
    public class ReadIdentityPersonaIdIdExample
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
                apiInstance.ReadIdentityPersonaIdId(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.ReadIdentityPersonaIdId: " + e.Message );
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

<a name="updateidentityalias"></a>
# **UpdateIdentityAlias**
> void UpdateIdentityAlias (IdentityAliasRequest identityAliasRequest = null)

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
    public class UpdateIdentityAliasExample
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
                apiInstance.UpdateIdentityAlias(identityAliasRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityAlias: " + e.Message );
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

<a name="updateidentityaliasidid"></a>
# **UpdateIdentityAliasIdId**
> void UpdateIdentityAliasIdId (string id, IdentityAliasIdRequest identityAliasIdRequest = null)

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
    public class UpdateIdentityAliasIdIdExample
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
                apiInstance.UpdateIdentityAliasIdId(id, identityAliasIdRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityAliasIdId: " + e.Message );
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

<a name="updateidentityentity"></a>
# **UpdateIdentityEntity**
> void UpdateIdentityEntity (IdentityEntityRequest identityEntityRequest = null)

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
    public class UpdateIdentityEntityExample
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
                apiInstance.UpdateIdentityEntity(identityEntityRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityEntity: " + e.Message );
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

<a name="updateidentityentityalias"></a>
# **UpdateIdentityEntityAlias**
> void UpdateIdentityEntityAlias (IdentityEntityAliasRequest identityEntityAliasRequest = null)

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
    public class UpdateIdentityEntityAliasExample
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
                apiInstance.UpdateIdentityEntityAlias(identityEntityAliasRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityEntityAlias: " + e.Message );
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

<a name="updateidentityentityaliasidid"></a>
# **UpdateIdentityEntityAliasIdId**
> void UpdateIdentityEntityAliasIdId (string id, IdentityEntityAliasIdRequest identityEntityAliasIdRequest = null)

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
    public class UpdateIdentityEntityAliasIdIdExample
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
                apiInstance.UpdateIdentityEntityAliasIdId(id, identityEntityAliasIdRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityEntityAliasIdId: " + e.Message );
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

<a name="updateidentityentitybatchdelete"></a>
# **UpdateIdentityEntityBatchDelete**
> void UpdateIdentityEntityBatchDelete (IdentityEntityBatchDeleteRequest identityEntityBatchDeleteRequest = null)

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
    public class UpdateIdentityEntityBatchDeleteExample
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
                apiInstance.UpdateIdentityEntityBatchDelete(identityEntityBatchDeleteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityEntityBatchDelete: " + e.Message );
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

<a name="updateidentityentityidid"></a>
# **UpdateIdentityEntityIdId**
> void UpdateIdentityEntityIdId (string id, IdentityEntityIdRequest identityEntityIdRequest = null)

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
    public class UpdateIdentityEntityIdIdExample
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
                apiInstance.UpdateIdentityEntityIdId(id, identityEntityIdRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityEntityIdId: " + e.Message );
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

<a name="updateidentityentitymerge"></a>
# **UpdateIdentityEntityMerge**
> void UpdateIdentityEntityMerge (IdentityEntityMergeRequest identityEntityMergeRequest = null)

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
    public class UpdateIdentityEntityMergeExample
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
                apiInstance.UpdateIdentityEntityMerge(identityEntityMergeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityEntityMerge: " + e.Message );
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

<a name="updateidentityentitynamename"></a>
# **UpdateIdentityEntityNameName**
> void UpdateIdentityEntityNameName (string name, IdentityEntityNameRequest identityEntityNameRequest = null)

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
    public class UpdateIdentityEntityNameNameExample
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
                apiInstance.UpdateIdentityEntityNameName(name, identityEntityNameRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityEntityNameName: " + e.Message );
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

<a name="updateidentitygroup"></a>
# **UpdateIdentityGroup**
> void UpdateIdentityGroup (IdentityGroupRequest identityGroupRequest = null)

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
    public class UpdateIdentityGroupExample
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
                apiInstance.UpdateIdentityGroup(identityGroupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityGroup: " + e.Message );
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

<a name="updateidentitygroupalias"></a>
# **UpdateIdentityGroupAlias**
> void UpdateIdentityGroupAlias (IdentityGroupAliasRequest identityGroupAliasRequest = null)

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
    public class UpdateIdentityGroupAliasExample
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
                apiInstance.UpdateIdentityGroupAlias(identityGroupAliasRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityGroupAlias: " + e.Message );
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

<a name="updateidentitygroupaliasidid"></a>
# **UpdateIdentityGroupAliasIdId**
> void UpdateIdentityGroupAliasIdId (string id, IdentityGroupAliasIdRequest identityGroupAliasIdRequest = null)



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
    public class UpdateIdentityGroupAliasIdIdExample
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
                apiInstance.UpdateIdentityGroupAliasIdId(id, identityGroupAliasIdRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityGroupAliasIdId: " + e.Message );
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

<a name="updateidentitygroupidid"></a>
# **UpdateIdentityGroupIdId**
> void UpdateIdentityGroupIdId (string id, IdentityGroupIdRequest identityGroupIdRequest = null)

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
    public class UpdateIdentityGroupIdIdExample
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
                apiInstance.UpdateIdentityGroupIdId(id, identityGroupIdRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityGroupIdId: " + e.Message );
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

<a name="updateidentitygroupnamename"></a>
# **UpdateIdentityGroupNameName**
> void UpdateIdentityGroupNameName (string name, IdentityGroupNameRequest identityGroupNameRequest = null)



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
    public class UpdateIdentityGroupNameNameExample
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
                apiInstance.UpdateIdentityGroupNameName(name, identityGroupNameRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityGroupNameName: " + e.Message );
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

<a name="updateidentitylookupentity"></a>
# **UpdateIdentityLookupEntity**
> void UpdateIdentityLookupEntity (IdentityLookupEntityRequest identityLookupEntityRequest = null)

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
    public class UpdateIdentityLookupEntityExample
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
                apiInstance.UpdateIdentityLookupEntity(identityLookupEntityRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityLookupEntity: " + e.Message );
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

<a name="updateidentitylookupgroup"></a>
# **UpdateIdentityLookupGroup**
> void UpdateIdentityLookupGroup (IdentityLookupGroupRequest identityLookupGroupRequest = null)

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
    public class UpdateIdentityLookupGroupExample
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
                apiInstance.UpdateIdentityLookupGroup(identityLookupGroupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityLookupGroup: " + e.Message );
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

<a name="updateidentitymfaloginenforcementname"></a>
# **UpdateIdentityMfaLoginEnforcementName**
> void UpdateIdentityMfaLoginEnforcementName (string name, IdentityMfaLoginEnforcementRequest identityMfaLoginEnforcementRequest = null)

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
    public class UpdateIdentityMfaLoginEnforcementNameExample
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
                apiInstance.UpdateIdentityMfaLoginEnforcementName(name, identityMfaLoginEnforcementRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityMfaLoginEnforcementName: " + e.Message );
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

<a name="updateidentitymfamethodduomethodid"></a>
# **UpdateIdentityMfaMethodDuoMethodId**
> void UpdateIdentityMfaMethodDuoMethodId (string methodId, IdentityMfaMethodDuoRequest identityMfaMethodDuoRequest = null)

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
    public class UpdateIdentityMfaMethodDuoMethodIdExample
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
                apiInstance.UpdateIdentityMfaMethodDuoMethodId(methodId, identityMfaMethodDuoRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityMfaMethodDuoMethodId: " + e.Message );
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

<a name="updateidentitymfamethodoktamethodid"></a>
# **UpdateIdentityMfaMethodOktaMethodId**
> void UpdateIdentityMfaMethodOktaMethodId (string methodId, IdentityMfaMethodOktaRequest identityMfaMethodOktaRequest = null)

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
    public class UpdateIdentityMfaMethodOktaMethodIdExample
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
                apiInstance.UpdateIdentityMfaMethodOktaMethodId(methodId, identityMfaMethodOktaRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityMfaMethodOktaMethodId: " + e.Message );
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

<a name="updateidentitymfamethodpingidmethodid"></a>
# **UpdateIdentityMfaMethodPingidMethodId**
> void UpdateIdentityMfaMethodPingidMethodId (string methodId, IdentityMfaMethodPingidRequest identityMfaMethodPingidRequest = null)

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
    public class UpdateIdentityMfaMethodPingidMethodIdExample
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
                apiInstance.UpdateIdentityMfaMethodPingidMethodId(methodId, identityMfaMethodPingidRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityMfaMethodPingidMethodId: " + e.Message );
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

<a name="updateidentitymfamethodtotpadmindestroy"></a>
# **UpdateIdentityMfaMethodTotpAdminDestroy**
> void UpdateIdentityMfaMethodTotpAdminDestroy (IdentityMfaMethodTotpAdminDestroyRequest identityMfaMethodTotpAdminDestroyRequest = null)

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
    public class UpdateIdentityMfaMethodTotpAdminDestroyExample
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
                apiInstance.UpdateIdentityMfaMethodTotpAdminDestroy(identityMfaMethodTotpAdminDestroyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityMfaMethodTotpAdminDestroy: " + e.Message );
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

<a name="updateidentitymfamethodtotpadmingenerate"></a>
# **UpdateIdentityMfaMethodTotpAdminGenerate**
> void UpdateIdentityMfaMethodTotpAdminGenerate (IdentityMfaMethodTotpAdminGenerateRequest identityMfaMethodTotpAdminGenerateRequest = null)

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
    public class UpdateIdentityMfaMethodTotpAdminGenerateExample
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
                apiInstance.UpdateIdentityMfaMethodTotpAdminGenerate(identityMfaMethodTotpAdminGenerateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityMfaMethodTotpAdminGenerate: " + e.Message );
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

<a name="updateidentitymfamethodtotpgenerate"></a>
# **UpdateIdentityMfaMethodTotpGenerate**
> void UpdateIdentityMfaMethodTotpGenerate (IdentityMfaMethodTotpGenerateRequest identityMfaMethodTotpGenerateRequest = null)

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
    public class UpdateIdentityMfaMethodTotpGenerateExample
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
                apiInstance.UpdateIdentityMfaMethodTotpGenerate(identityMfaMethodTotpGenerateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityMfaMethodTotpGenerate: " + e.Message );
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

<a name="updateidentitymfamethodtotpmethodid"></a>
# **UpdateIdentityMfaMethodTotpMethodId**
> void UpdateIdentityMfaMethodTotpMethodId (string methodId, IdentityMfaMethodTotpRequest identityMfaMethodTotpRequest = null)

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
    public class UpdateIdentityMfaMethodTotpMethodIdExample
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
                apiInstance.UpdateIdentityMfaMethodTotpMethodId(methodId, identityMfaMethodTotpRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityMfaMethodTotpMethodId: " + e.Message );
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

<a name="updateidentityoidcassignmentname"></a>
# **UpdateIdentityOidcAssignmentName**
> void UpdateIdentityOidcAssignmentName (string name, IdentityOidcAssignmentRequest identityOidcAssignmentRequest = null)



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
    public class UpdateIdentityOidcAssignmentNameExample
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
                apiInstance.UpdateIdentityOidcAssignmentName(name, identityOidcAssignmentRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityOidcAssignmentName: " + e.Message );
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

<a name="updateidentityoidcclientname"></a>
# **UpdateIdentityOidcClientName**
> void UpdateIdentityOidcClientName (string name, IdentityOidcClientRequest identityOidcClientRequest = null)



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
    public class UpdateIdentityOidcClientNameExample
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
                apiInstance.UpdateIdentityOidcClientName(name, identityOidcClientRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityOidcClientName: " + e.Message );
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

<a name="updateidentityoidcconfig"></a>
# **UpdateIdentityOidcConfig**
> void UpdateIdentityOidcConfig (IdentityOidcConfigRequest identityOidcConfigRequest = null)

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
    public class UpdateIdentityOidcConfigExample
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
                apiInstance.UpdateIdentityOidcConfig(identityOidcConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityOidcConfig: " + e.Message );
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

<a name="updateidentityoidcintrospect"></a>
# **UpdateIdentityOidcIntrospect**
> void UpdateIdentityOidcIntrospect (IdentityOidcIntrospectRequest identityOidcIntrospectRequest = null)

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
    public class UpdateIdentityOidcIntrospectExample
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
                apiInstance.UpdateIdentityOidcIntrospect(identityOidcIntrospectRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityOidcIntrospect: " + e.Message );
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

<a name="updateidentityoidckeyname"></a>
# **UpdateIdentityOidcKeyName**
> void UpdateIdentityOidcKeyName (string name, IdentityOidcKeyRequest identityOidcKeyRequest = null)

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
    public class UpdateIdentityOidcKeyNameExample
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
                apiInstance.UpdateIdentityOidcKeyName(name, identityOidcKeyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityOidcKeyName: " + e.Message );
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

<a name="updateidentityoidckeynamerotate"></a>
# **UpdateIdentityOidcKeyNameRotate**
> void UpdateIdentityOidcKeyNameRotate (string name, IdentityOidcKeyRotateRequest identityOidcKeyRotateRequest = null)

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
    public class UpdateIdentityOidcKeyNameRotateExample
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
                apiInstance.UpdateIdentityOidcKeyNameRotate(name, identityOidcKeyRotateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityOidcKeyNameRotate: " + e.Message );
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

<a name="updateidentityoidcprovidername"></a>
# **UpdateIdentityOidcProviderName**
> void UpdateIdentityOidcProviderName (string name, IdentityOidcProviderRequest identityOidcProviderRequest = null)



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
    public class UpdateIdentityOidcProviderNameExample
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
                apiInstance.UpdateIdentityOidcProviderName(name, identityOidcProviderRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityOidcProviderName: " + e.Message );
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

<a name="updateidentityoidcprovidernameauthorize"></a>
# **UpdateIdentityOidcProviderNameAuthorize**
> void UpdateIdentityOidcProviderNameAuthorize (string name, IdentityOidcProviderAuthorizeRequest identityOidcProviderAuthorizeRequest = null)



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
    public class UpdateIdentityOidcProviderNameAuthorizeExample
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
                apiInstance.UpdateIdentityOidcProviderNameAuthorize(name, identityOidcProviderAuthorizeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityOidcProviderNameAuthorize: " + e.Message );
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

<a name="updateidentityoidcprovidernametoken"></a>
# **UpdateIdentityOidcProviderNameToken**
> void UpdateIdentityOidcProviderNameToken (string name, IdentityOidcProviderTokenRequest identityOidcProviderTokenRequest = null)



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
    public class UpdateIdentityOidcProviderNameTokenExample
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
                apiInstance.UpdateIdentityOidcProviderNameToken(name, identityOidcProviderTokenRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityOidcProviderNameToken: " + e.Message );
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

<a name="updateidentityoidcprovidernameuserinfo"></a>
# **UpdateIdentityOidcProviderNameUserinfo**
> void UpdateIdentityOidcProviderNameUserinfo (string name)



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
    public class UpdateIdentityOidcProviderNameUserinfoExample
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
                apiInstance.UpdateIdentityOidcProviderNameUserinfo(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityOidcProviderNameUserinfo: " + e.Message );
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

<a name="updateidentityoidcrolename"></a>
# **UpdateIdentityOidcRoleName**
> void UpdateIdentityOidcRoleName (string name, IdentityOidcRoleRequest identityOidcRoleRequest = null)

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
    public class UpdateIdentityOidcRoleNameExample
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
                apiInstance.UpdateIdentityOidcRoleName(name, identityOidcRoleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityOidcRoleName: " + e.Message );
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

<a name="updateidentityoidcscopename"></a>
# **UpdateIdentityOidcScopeName**
> void UpdateIdentityOidcScopeName (string name, IdentityOidcScopeRequest identityOidcScopeRequest = null)



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
    public class UpdateIdentityOidcScopeNameExample
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
                apiInstance.UpdateIdentityOidcScopeName(name, identityOidcScopeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityOidcScopeName: " + e.Message );
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

<a name="updateidentitypersona"></a>
# **UpdateIdentityPersona**
> void UpdateIdentityPersona (IdentityPersonaRequest identityPersonaRequest = null)

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
    public class UpdateIdentityPersonaExample
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
                apiInstance.UpdateIdentityPersona(identityPersonaRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityPersona: " + e.Message );
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

<a name="updateidentitypersonaidid"></a>
# **UpdateIdentityPersonaIdId**
> void UpdateIdentityPersonaIdId (string id, IdentityPersonaIdRequest identityPersonaIdRequest = null)

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
    public class UpdateIdentityPersonaIdIdExample
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
                apiInstance.UpdateIdentityPersonaIdId(id, identityPersonaIdRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Identity.UpdateIdentityPersonaIdId: " + e.Message );
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

