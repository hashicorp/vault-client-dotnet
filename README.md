# Vault - the C# library for the HashiCorp Vault API

## :warning: _Stability Warning: Under Development!_ :warning:

## Contents

1. [Overview](#overview)
1. [Installation](#installation)
1. [Getting Started](#getting-started)
1. [Examples](#exmples)
    - [Creating a VaultClient](#creating-a-vault-client)
    - [Reading secrets with `kv v2`](#secrets-engines)
    - [Logging in with `AppRole` auth method](#auth-methods)
1. [Local Development](#local-development)
1. [Documentation for API Endpoints](#documentation-for-api-endpoints)

## Overview

A C# client library [generated][openapi-generator] from `OpenAPI` 
[specification file][openapi-spec] to interact with [Hashicorp]hashicorp
[Vault][vault]. The library currently supports the following features:

- Custom HttpClientHandler
- Retry logic using [Polly][polly]
- Vault token support
- Vault namespace support
- Thread-safe operations

## Installation

### Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

### Dependencies

- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Vault;
using Vault.Api;
using Vault.Client;
using Vault.Model;
```

## Getting Started
Here is a simple copy-pastable example of using the library to get a list of
currently enabled secrets engines (equivalent to `GET /v1/sys/mounts`). This example 
works with a Vault server started in dev mode with a hardcoded root token (e.g.
`vault server -dev -dev-root-token-id="my-token");

```csharp
using Vault;
using Vault.Client;

namespace Example
{
    public class Example
    {
        public static void Main()
        {
            string address = "http://127.0.0.1:8200";
            Configuration config = new Configuration(address);

            VaultClient vaultClient = new VaultClient(config);
            vaultClient.SetToken("root");

            ApiResponse<Object> resp = await vaultClient.System.GetSysMounts();

            // Write out the json
            Console.Writeline(resp.Content);
        }
    }
}
```
_**Note**_: the responses are currently generic objects that need
to be marshalled into an appropriate model. Structured responses are 
coming soon!

## Examples

### Creating a Vault Client
The VaultClient requires you pass it a `Configuration` object. 

```csharp
Configuration config = new Configuration("http:127.0.0.1:8200");
VaultClient vaultClient = new VaultClient(config);
```

You can also add custom configuration including a custom `HttpClientHandler` and a custom Timeout as shown below.

```csharp
HttpClientHandler myClientHandler = new HttpClientHandler();

Configuration config = new Configuration("http://127.0.0.1:8200",
                                          myClientHandler,
                                          TimeSpan.FromSeconds(10));
```

The `SetToken` method can be used to set the `X-Vault-Token` header with the given token for subsequent requests.

```csharp
vaultClient.SetToken("dev-only-token");
```

### Secrets Engines
To call secrets endpoints, simply use the `VaultClient.Secrets` object, as shown below.

```csharp
ApiResponse<Object> resp = await vaultClient.Secrets.GetKvPathAsync("path");

Console.Writeline(resp.Content);
```

**Note** All calls have both an async and synchronous implementation. E.g.
```chsarp
ApiResponse<Object> respAsync = await vaultClient.Secrets.GetKvPathAsync("path");
ApiResponse<Object> respSync = vaultClient.Secrets.GetKvPath("path");
```

### Auth Methods
To call auth method endpoints, simply use the `VaultClient.Auth` object, as shown below. Some will require passing in 
request objects.

```csharp
ApiResponse<Object> resp = await vaultClient.Auth.PostAuthApproleLogin(new ApproleLoginRequest("role_id", "secret_id"));

Console.Writeline(resp.Content);
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*Auth* | [**DeleteAuthAlicloudRoleRole**](docs/Auth.md#deleteauthalicloudrolerole) | **DELETE** /auth/alicloud/role/{role} | Create a role and associate policies to it.
*Auth* | [**DeleteAuthAppIdMapAppIdKey**](docs/Auth.md#deleteauthappidmapappidkey) | **DELETE** /auth/app-id/map/app-id/{key} | Read/write/delete a single app-id mapping
*Auth* | [**DeleteAuthAppIdMapUserIdKey**](docs/Auth.md#deleteauthappidmapuseridkey) | **DELETE** /auth/app-id/map/user-id/{key} | Read/write/delete a single user-id mapping
*Auth* | [**DeleteAuthApproleRoleRoleName**](docs/Auth.md#deleteauthapprolerolerolename) | **DELETE** /auth/approle/role/{role_name} | Register an role with the backend.
*Auth* | [**DeleteAuthApproleRoleRoleNameBindSecretId**](docs/Auth.md#deleteauthapprolerolerolenamebindsecretid) | **DELETE** /auth/approle/role/{role_name}/bind-secret-id | Impose secret_id to be presented during login using this role.
*Auth* | [**DeleteAuthApproleRoleRoleNameBoundCidrList**](docs/Auth.md#deleteauthapprolerolerolenameboundcidrlist) | **DELETE** /auth/approle/role/{role_name}/bound-cidr-list | Deprecated: Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
*Auth* | [**DeleteAuthApproleRoleRoleNamePeriod**](docs/Auth.md#deleteauthapprolerolerolenameperiod) | **DELETE** /auth/approle/role/{role_name}/period | Updates the value of 'period' on the role
*Auth* | [**DeleteAuthApproleRoleRoleNamePolicies**](docs/Auth.md#deleteauthapprolerolerolenamepolicies) | **DELETE** /auth/approle/role/{role_name}/policies | Policies of the role.
*Auth* | [**DeleteAuthApproleRoleRoleNameSecretIdAccessorDestroy**](docs/Auth.md#deleteauthapprolerolerolenamesecretidaccessordestroy) | **DELETE** /auth/approle/role/{role_name}/secret-id-accessor/destroy | 
*Auth* | [**DeleteAuthApproleRoleRoleNameSecretIdBoundCidrs**](docs/Auth.md#deleteauthapprolerolerolenamesecretidboundcidrs) | **DELETE** /auth/approle/role/{role_name}/secret-id-bound-cidrs | Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
*Auth* | [**DeleteAuthApproleRoleRoleNameSecretIdDestroy**](docs/Auth.md#deleteauthapprolerolerolenamesecretiddestroy) | **DELETE** /auth/approle/role/{role_name}/secret-id/destroy | Invalidate an issued secret_id
*Auth* | [**DeleteAuthApproleRoleRoleNameSecretIdNumUses**](docs/Auth.md#deleteauthapprolerolerolenamesecretidnumuses) | **DELETE** /auth/approle/role/{role_name}/secret-id-num-uses | Use limit of the SecretID generated against the role.
*Auth* | [**DeleteAuthApproleRoleRoleNameSecretIdTtl**](docs/Auth.md#deleteauthapprolerolerolenamesecretidttl) | **DELETE** /auth/approle/role/{role_name}/secret-id-ttl | Duration in seconds, representing the lifetime of the SecretIDs that are generated against the role using 'role/<role_name>/secret-id' or 'role/<role_name>/custom-secret-id' endpoints.
*Auth* | [**DeleteAuthApproleRoleRoleNameTokenBoundCidrs**](docs/Auth.md#deleteauthapprolerolerolenametokenboundcidrs) | **DELETE** /auth/approle/role/{role_name}/token-bound-cidrs | Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token.
*Auth* | [**DeleteAuthApproleRoleRoleNameTokenMaxTtl**](docs/Auth.md#deleteauthapprolerolerolenametokenmaxttl) | **DELETE** /auth/approle/role/{role_name}/token-max-ttl | Duration in seconds, the maximum lifetime of the tokens issued by using the SecretIDs that were generated against this role, after which the tokens are not allowed to be renewed.
*Auth* | [**DeleteAuthApproleRoleRoleNameTokenNumUses**](docs/Auth.md#deleteauthapprolerolerolenametokennumuses) | **DELETE** /auth/approle/role/{role_name}/token-num-uses | Number of times issued tokens can be used
*Auth* | [**DeleteAuthApproleRoleRoleNameTokenTtl**](docs/Auth.md#deleteauthapprolerolerolenametokenttl) | **DELETE** /auth/approle/role/{role_name}/token-ttl | Duration in seconds, the lifetime of the token issued by using the SecretID that is generated against this role, before which the token needs to be renewed.
*Auth* | [**DeleteAuthAwsConfigCertificateCertName**](docs/Auth.md#deleteauthawsconfigcertificatecertname) | **DELETE** /auth/aws/config/certificate/{cert_name} | 
*Auth* | [**DeleteAuthAwsConfigClient**](docs/Auth.md#deleteauthawsconfigclient) | **DELETE** /auth/aws/config/client | 
*Auth* | [**DeleteAuthAwsConfigStsAccountId**](docs/Auth.md#deleteauthawsconfigstsaccountid) | **DELETE** /auth/aws/config/sts/{account_id} | 
*Auth* | [**DeleteAuthAwsConfigTidyIdentityAccesslist**](docs/Auth.md#deleteauthawsconfigtidyidentityaccesslist) | **DELETE** /auth/aws/config/tidy/identity-accesslist | 
*Auth* | [**DeleteAuthAwsConfigTidyIdentityWhitelist**](docs/Auth.md#deleteauthawsconfigtidyidentitywhitelist) | **DELETE** /auth/aws/config/tidy/identity-whitelist | 
*Auth* | [**DeleteAuthAwsConfigTidyRoletagBlacklist**](docs/Auth.md#deleteauthawsconfigtidyroletagblacklist) | **DELETE** /auth/aws/config/tidy/roletag-blacklist | 
*Auth* | [**DeleteAuthAwsConfigTidyRoletagDenylist**](docs/Auth.md#deleteauthawsconfigtidyroletagdenylist) | **DELETE** /auth/aws/config/tidy/roletag-denylist | 
*Auth* | [**DeleteAuthAwsIdentityAccesslistInstanceId**](docs/Auth.md#deleteauthawsidentityaccesslistinstanceid) | **DELETE** /auth/aws/identity-accesslist/{instance_id} | 
*Auth* | [**DeleteAuthAwsIdentityWhitelistInstanceId**](docs/Auth.md#deleteauthawsidentitywhitelistinstanceid) | **DELETE** /auth/aws/identity-whitelist/{instance_id} | 
*Auth* | [**DeleteAuthAwsRoleRole**](docs/Auth.md#deleteauthawsrolerole) | **DELETE** /auth/aws/role/{role} | 
*Auth* | [**DeleteAuthAwsRoletagBlacklistRoleTag**](docs/Auth.md#deleteauthawsroletagblacklistroletag) | **DELETE** /auth/aws/roletag-blacklist/{role_tag} | 
*Auth* | [**DeleteAuthAwsRoletagDenylistRoleTag**](docs/Auth.md#deleteauthawsroletagdenylistroletag) | **DELETE** /auth/aws/roletag-denylist/{role_tag} | 
*Auth* | [**DeleteAuthAzureConfig**](docs/Auth.md#deleteauthazureconfig) | **DELETE** /auth/azure/config | 
*Auth* | [**DeleteAuthAzureRoleName**](docs/Auth.md#deleteauthazurerolename) | **DELETE** /auth/azure/role/{name} | 
*Auth* | [**DeleteAuthCertCertsName**](docs/Auth.md#deleteauthcertcertsname) | **DELETE** /auth/cert/certs/{name} | Manage trusted certificates used for authentication.
*Auth* | [**DeleteAuthCertCrlsName**](docs/Auth.md#deleteauthcertcrlsname) | **DELETE** /auth/cert/crls/{name} | Manage Certificate Revocation Lists checked during authentication.
*Auth* | [**DeleteAuthCfConfig**](docs/Auth.md#deleteauthcfconfig) | **DELETE** /auth/cf/config | 
*Auth* | [**DeleteAuthCfRolesRole**](docs/Auth.md#deleteauthcfrolesrole) | **DELETE** /auth/cf/roles/{role} | 
*Auth* | [**DeleteAuthGcpRoleName**](docs/Auth.md#deleteauthgcprolename) | **DELETE** /auth/gcp/role/{name} | Create a GCP role with associated policies and required attributes.
*Auth* | [**DeleteAuthGithubMapTeamsKey**](docs/Auth.md#deleteauthgithubmapteamskey) | **DELETE** /auth/github/map/teams/{key} | Read/write/delete a single teams mapping
*Auth* | [**DeleteAuthGithubMapUsersKey**](docs/Auth.md#deleteauthgithubmapuserskey) | **DELETE** /auth/github/map/users/{key} | Read/write/delete a single users mapping
*Auth* | [**DeleteAuthJwtRoleName**](docs/Auth.md#deleteauthjwtrolename) | **DELETE** /auth/jwt/role/{name} | Delete an existing role.
*Auth* | [**DeleteAuthKerberosGroupsName**](docs/Auth.md#deleteauthkerberosgroupsname) | **DELETE** /auth/kerberos/groups/{name} | 
*Auth* | [**DeleteAuthKubernetesRoleName**](docs/Auth.md#deleteauthkubernetesrolename) | **DELETE** /auth/kubernetes/role/{name} | Register an role with the backend.
*Auth* | [**DeleteAuthLdapGroupsName**](docs/Auth.md#deleteauthldapgroupsname) | **DELETE** /auth/ldap/groups/{name} | Manage additional groups for users allowed to authenticate.
*Auth* | [**DeleteAuthLdapUsersName**](docs/Auth.md#deleteauthldapusersname) | **DELETE** /auth/ldap/users/{name} | Manage users allowed to authenticate.
*Auth* | [**DeleteAuthOciConfig**](docs/Auth.md#deleteauthociconfig) | **DELETE** /auth/oci/config | Manages the configuration for the Vault Auth Plugin.
*Auth* | [**DeleteAuthOciRoleRole**](docs/Auth.md#deleteauthocirolerole) | **DELETE** /auth/oci/role/{role} | Create a role and associate policies to it.
*Auth* | [**DeleteAuthOidcRoleName**](docs/Auth.md#deleteauthoidcrolename) | **DELETE** /auth/oidc/role/{name} | Delete an existing role.
*Auth* | [**DeleteAuthOktaGroupsName**](docs/Auth.md#deleteauthoktagroupsname) | **DELETE** /auth/okta/groups/{name} | Manage users allowed to authenticate.
*Auth* | [**DeleteAuthOktaUsersName**](docs/Auth.md#deleteauthoktausersname) | **DELETE** /auth/okta/users/{name} | Manage additional groups for users allowed to authenticate.
*Auth* | [**DeleteAuthRadiusUsersName**](docs/Auth.md#deleteauthradiususersname) | **DELETE** /auth/radius/users/{name} | Manage users allowed to authenticate.
*Auth* | [**DeleteAuthTokenRolesRoleName**](docs/Auth.md#deleteauthtokenrolesrolename) | **DELETE** /auth/token/roles/{role_name} | 
*Auth* | [**DeleteAuthUserpassUsersUsername**](docs/Auth.md#deleteauthuserpassusersusername) | **DELETE** /auth/userpass/users/{username} | Manage users allowed to authenticate.
*Auth* | [**GetAuthAlicloudRole**](docs/Auth.md#getauthalicloudrole) | **GET** /auth/alicloud/role | Lists all the roles that are registered with Vault.
*Auth* | [**GetAuthAlicloudRoleRole**](docs/Auth.md#getauthalicloudrolerole) | **GET** /auth/alicloud/role/{role} | Create a role and associate policies to it.
*Auth* | [**GetAuthAlicloudRoles**](docs/Auth.md#getauthalicloudroles) | **GET** /auth/alicloud/roles | Lists all the roles that are registered with Vault.
*Auth* | [**GetAuthAppIdMapAppId**](docs/Auth.md#getauthappidmapappid) | **GET** /auth/app-id/map/app-id | Read mappings for app-id
*Auth* | [**GetAuthAppIdMapAppIdKey**](docs/Auth.md#getauthappidmapappidkey) | **GET** /auth/app-id/map/app-id/{key} | Read/write/delete a single app-id mapping
*Auth* | [**GetAuthAppIdMapUserId**](docs/Auth.md#getauthappidmapuserid) | **GET** /auth/app-id/map/user-id | Read mappings for user-id
*Auth* | [**GetAuthAppIdMapUserIdKey**](docs/Auth.md#getauthappidmapuseridkey) | **GET** /auth/app-id/map/user-id/{key} | Read/write/delete a single user-id mapping
*Auth* | [**GetAuthApproleRole**](docs/Auth.md#getauthapprolerole) | **GET** /auth/approle/role | Lists all the roles registered with the backend.
*Auth* | [**GetAuthApproleRoleRoleName**](docs/Auth.md#getauthapprolerolerolename) | **GET** /auth/approle/role/{role_name} | Register an role with the backend.
*Auth* | [**GetAuthApproleRoleRoleNameBindSecretId**](docs/Auth.md#getauthapprolerolerolenamebindsecretid) | **GET** /auth/approle/role/{role_name}/bind-secret-id | Impose secret_id to be presented during login using this role.
*Auth* | [**GetAuthApproleRoleRoleNameBoundCidrList**](docs/Auth.md#getauthapprolerolerolenameboundcidrlist) | **GET** /auth/approle/role/{role_name}/bound-cidr-list | Deprecated: Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
*Auth* | [**GetAuthApproleRoleRoleNameLocalSecretIds**](docs/Auth.md#getauthapprolerolerolenamelocalsecretids) | **GET** /auth/approle/role/{role_name}/local-secret-ids | Enables cluster local secret IDs
*Auth* | [**GetAuthApproleRoleRoleNamePeriod**](docs/Auth.md#getauthapprolerolerolenameperiod) | **GET** /auth/approle/role/{role_name}/period | Updates the value of 'period' on the role
*Auth* | [**GetAuthApproleRoleRoleNamePolicies**](docs/Auth.md#getauthapprolerolerolenamepolicies) | **GET** /auth/approle/role/{role_name}/policies | Policies of the role.
*Auth* | [**GetAuthApproleRoleRoleNameRoleId**](docs/Auth.md#getauthapprolerolerolenameroleid) | **GET** /auth/approle/role/{role_name}/role-id | Returns the 'role_id' of the role.
*Auth* | [**GetAuthApproleRoleRoleNameSecretId**](docs/Auth.md#getauthapprolerolerolenamesecretid) | **GET** /auth/approle/role/{role_name}/secret-id | Generate a SecretID against this role.
*Auth* | [**GetAuthApproleRoleRoleNameSecretIdBoundCidrs**](docs/Auth.md#getauthapprolerolerolenamesecretidboundcidrs) | **GET** /auth/approle/role/{role_name}/secret-id-bound-cidrs | Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
*Auth* | [**GetAuthApproleRoleRoleNameSecretIdNumUses**](docs/Auth.md#getauthapprolerolerolenamesecretidnumuses) | **GET** /auth/approle/role/{role_name}/secret-id-num-uses | Use limit of the SecretID generated against the role.
*Auth* | [**GetAuthApproleRoleRoleNameSecretIdTtl**](docs/Auth.md#getauthapprolerolerolenamesecretidttl) | **GET** /auth/approle/role/{role_name}/secret-id-ttl | Duration in seconds, representing the lifetime of the SecretIDs that are generated against the role using 'role/<role_name>/secret-id' or 'role/<role_name>/custom-secret-id' endpoints.
*Auth* | [**GetAuthApproleRoleRoleNameTokenBoundCidrs**](docs/Auth.md#getauthapprolerolerolenametokenboundcidrs) | **GET** /auth/approle/role/{role_name}/token-bound-cidrs | Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token.
*Auth* | [**GetAuthApproleRoleRoleNameTokenMaxTtl**](docs/Auth.md#getauthapprolerolerolenametokenmaxttl) | **GET** /auth/approle/role/{role_name}/token-max-ttl | Duration in seconds, the maximum lifetime of the tokens issued by using the SecretIDs that were generated against this role, after which the tokens are not allowed to be renewed.
*Auth* | [**GetAuthApproleRoleRoleNameTokenNumUses**](docs/Auth.md#getauthapprolerolerolenametokennumuses) | **GET** /auth/approle/role/{role_name}/token-num-uses | Number of times issued tokens can be used
*Auth* | [**GetAuthApproleRoleRoleNameTokenTtl**](docs/Auth.md#getauthapprolerolerolenametokenttl) | **GET** /auth/approle/role/{role_name}/token-ttl | Duration in seconds, the lifetime of the token issued by using the SecretID that is generated against this role, before which the token needs to be renewed.
*Auth* | [**GetAuthAwsConfigCertificateCertName**](docs/Auth.md#getauthawsconfigcertificatecertname) | **GET** /auth/aws/config/certificate/{cert_name} | 
*Auth* | [**GetAuthAwsConfigCertificates**](docs/Auth.md#getauthawsconfigcertificates) | **GET** /auth/aws/config/certificates | 
*Auth* | [**GetAuthAwsConfigClient**](docs/Auth.md#getauthawsconfigclient) | **GET** /auth/aws/config/client | 
*Auth* | [**GetAuthAwsConfigIdentity**](docs/Auth.md#getauthawsconfigidentity) | **GET** /auth/aws/config/identity | 
*Auth* | [**GetAuthAwsConfigSts**](docs/Auth.md#getauthawsconfigsts) | **GET** /auth/aws/config/sts | 
*Auth* | [**GetAuthAwsConfigStsAccountId**](docs/Auth.md#getauthawsconfigstsaccountid) | **GET** /auth/aws/config/sts/{account_id} | 
*Auth* | [**GetAuthAwsConfigTidyIdentityAccesslist**](docs/Auth.md#getauthawsconfigtidyidentityaccesslist) | **GET** /auth/aws/config/tidy/identity-accesslist | 
*Auth* | [**GetAuthAwsConfigTidyIdentityWhitelist**](docs/Auth.md#getauthawsconfigtidyidentitywhitelist) | **GET** /auth/aws/config/tidy/identity-whitelist | 
*Auth* | [**GetAuthAwsConfigTidyRoletagBlacklist**](docs/Auth.md#getauthawsconfigtidyroletagblacklist) | **GET** /auth/aws/config/tidy/roletag-blacklist | 
*Auth* | [**GetAuthAwsConfigTidyRoletagDenylist**](docs/Auth.md#getauthawsconfigtidyroletagdenylist) | **GET** /auth/aws/config/tidy/roletag-denylist | 
*Auth* | [**GetAuthAwsIdentityAccesslist**](docs/Auth.md#getauthawsidentityaccesslist) | **GET** /auth/aws/identity-accesslist | 
*Auth* | [**GetAuthAwsIdentityAccesslistInstanceId**](docs/Auth.md#getauthawsidentityaccesslistinstanceid) | **GET** /auth/aws/identity-accesslist/{instance_id} | 
*Auth* | [**GetAuthAwsIdentityWhitelist**](docs/Auth.md#getauthawsidentitywhitelist) | **GET** /auth/aws/identity-whitelist | 
*Auth* | [**GetAuthAwsIdentityWhitelistInstanceId**](docs/Auth.md#getauthawsidentitywhitelistinstanceid) | **GET** /auth/aws/identity-whitelist/{instance_id} | 
*Auth* | [**GetAuthAwsRole**](docs/Auth.md#getauthawsrole) | **GET** /auth/aws/role | 
*Auth* | [**GetAuthAwsRoleRole**](docs/Auth.md#getauthawsrolerole) | **GET** /auth/aws/role/{role} | 
*Auth* | [**GetAuthAwsRoles**](docs/Auth.md#getauthawsroles) | **GET** /auth/aws/roles | 
*Auth* | [**GetAuthAwsRoletagBlacklist**](docs/Auth.md#getauthawsroletagblacklist) | **GET** /auth/aws/roletag-blacklist | 
*Auth* | [**GetAuthAwsRoletagBlacklistRoleTag**](docs/Auth.md#getauthawsroletagblacklistroletag) | **GET** /auth/aws/roletag-blacklist/{role_tag} | 
*Auth* | [**GetAuthAwsRoletagDenylist**](docs/Auth.md#getauthawsroletagdenylist) | **GET** /auth/aws/roletag-denylist | 
*Auth* | [**GetAuthAwsRoletagDenylistRoleTag**](docs/Auth.md#getauthawsroletagdenylistroletag) | **GET** /auth/aws/roletag-denylist/{role_tag} | 
*Auth* | [**GetAuthAzureConfig**](docs/Auth.md#getauthazureconfig) | **GET** /auth/azure/config | 
*Auth* | [**GetAuthAzureRole**](docs/Auth.md#getauthazurerole) | **GET** /auth/azure/role | 
*Auth* | [**GetAuthAzureRoleName**](docs/Auth.md#getauthazurerolename) | **GET** /auth/azure/role/{name} | 
*Auth* | [**GetAuthCentrifyConfig**](docs/Auth.md#getauthcentrifyconfig) | **GET** /auth/centrify/config | This path allows you to configure the centrify auth provider to interact with the Centrify Identity Services Platform for authenticating users.
*Auth* | [**GetAuthCertCerts**](docs/Auth.md#getauthcertcerts) | **GET** /auth/cert/certs | Manage trusted certificates used for authentication.
*Auth* | [**GetAuthCertCertsName**](docs/Auth.md#getauthcertcertsname) | **GET** /auth/cert/certs/{name} | Manage trusted certificates used for authentication.
*Auth* | [**GetAuthCertCrlsName**](docs/Auth.md#getauthcertcrlsname) | **GET** /auth/cert/crls/{name} | Manage Certificate Revocation Lists checked during authentication.
*Auth* | [**GetAuthCfConfig**](docs/Auth.md#getauthcfconfig) | **GET** /auth/cf/config | 
*Auth* | [**GetAuthCfRoles**](docs/Auth.md#getauthcfroles) | **GET** /auth/cf/roles | 
*Auth* | [**GetAuthCfRolesRole**](docs/Auth.md#getauthcfrolesrole) | **GET** /auth/cf/roles/{role} | 
*Auth* | [**GetAuthGcpConfig**](docs/Auth.md#getauthgcpconfig) | **GET** /auth/gcp/config | Configure credentials used to query the GCP IAM API to verify authenticating service accounts
*Auth* | [**GetAuthGcpRole**](docs/Auth.md#getauthgcprole) | **GET** /auth/gcp/role | Lists all the roles that are registered with Vault.
*Auth* | [**GetAuthGcpRoleName**](docs/Auth.md#getauthgcprolename) | **GET** /auth/gcp/role/{name} | Create a GCP role with associated policies and required attributes.
*Auth* | [**GetAuthGcpRoles**](docs/Auth.md#getauthgcproles) | **GET** /auth/gcp/roles | Lists all the roles that are registered with Vault.
*Auth* | [**GetAuthGithubConfig**](docs/Auth.md#getauthgithubconfig) | **GET** /auth/github/config | 
*Auth* | [**GetAuthGithubMapTeams**](docs/Auth.md#getauthgithubmapteams) | **GET** /auth/github/map/teams | Read mappings for teams
*Auth* | [**GetAuthGithubMapTeamsKey**](docs/Auth.md#getauthgithubmapteamskey) | **GET** /auth/github/map/teams/{key} | Read/write/delete a single teams mapping
*Auth* | [**GetAuthGithubMapUsers**](docs/Auth.md#getauthgithubmapusers) | **GET** /auth/github/map/users | Read mappings for users
*Auth* | [**GetAuthGithubMapUsersKey**](docs/Auth.md#getauthgithubmapuserskey) | **GET** /auth/github/map/users/{key} | Read/write/delete a single users mapping
*Auth* | [**GetAuthJwtConfig**](docs/Auth.md#getauthjwtconfig) | **GET** /auth/jwt/config | Read the current JWT authentication backend configuration.
*Auth* | [**GetAuthJwtOidcCallback**](docs/Auth.md#getauthjwtoidccallback) | **GET** /auth/jwt/oidc/callback | Callback endpoint to complete an OIDC login.
*Auth* | [**GetAuthJwtRole**](docs/Auth.md#getauthjwtrole) | **GET** /auth/jwt/role | Lists all the roles registered with the backend.
*Auth* | [**GetAuthJwtRoleName**](docs/Auth.md#getauthjwtrolename) | **GET** /auth/jwt/role/{name} | Read an existing role.
*Auth* | [**GetAuthKerberosConfig**](docs/Auth.md#getauthkerberosconfig) | **GET** /auth/kerberos/config | 
*Auth* | [**GetAuthKerberosConfigLdap**](docs/Auth.md#getauthkerberosconfigldap) | **GET** /auth/kerberos/config/ldap | 
*Auth* | [**GetAuthKerberosGroups**](docs/Auth.md#getauthkerberosgroups) | **GET** /auth/kerberos/groups | 
*Auth* | [**GetAuthKerberosGroupsName**](docs/Auth.md#getauthkerberosgroupsname) | **GET** /auth/kerberos/groups/{name} | 
*Auth* | [**GetAuthKerberosLogin**](docs/Auth.md#getauthkerberoslogin) | **GET** /auth/kerberos/login | 
*Auth* | [**GetAuthKubernetesConfig**](docs/Auth.md#getauthkubernetesconfig) | **GET** /auth/kubernetes/config | Configures the JWT Public Key and Kubernetes API information.
*Auth* | [**GetAuthKubernetesRole**](docs/Auth.md#getauthkubernetesrole) | **GET** /auth/kubernetes/role | Lists all the roles registered with the backend.
*Auth* | [**GetAuthKubernetesRoleName**](docs/Auth.md#getauthkubernetesrolename) | **GET** /auth/kubernetes/role/{name} | Register an role with the backend.
*Auth* | [**GetAuthLdapConfig**](docs/Auth.md#getauthldapconfig) | **GET** /auth/ldap/config | Configure the LDAP server to connect to, along with its options.
*Auth* | [**GetAuthLdapGroups**](docs/Auth.md#getauthldapgroups) | **GET** /auth/ldap/groups | Manage additional groups for users allowed to authenticate.
*Auth* | [**GetAuthLdapGroupsName**](docs/Auth.md#getauthldapgroupsname) | **GET** /auth/ldap/groups/{name} | Manage additional groups for users allowed to authenticate.
*Auth* | [**GetAuthLdapUsers**](docs/Auth.md#getauthldapusers) | **GET** /auth/ldap/users | Manage users allowed to authenticate.
*Auth* | [**GetAuthLdapUsersName**](docs/Auth.md#getauthldapusersname) | **GET** /auth/ldap/users/{name} | Manage users allowed to authenticate.
*Auth* | [**GetAuthOciConfig**](docs/Auth.md#getauthociconfig) | **GET** /auth/oci/config | Manages the configuration for the Vault Auth Plugin.
*Auth* | [**GetAuthOciRole**](docs/Auth.md#getauthocirole) | **GET** /auth/oci/role | Lists all the roles that are registered with Vault.
*Auth* | [**GetAuthOciRoleRole**](docs/Auth.md#getauthocirolerole) | **GET** /auth/oci/role/{role} | Create a role and associate policies to it.
*Auth* | [**GetAuthOidcConfig**](docs/Auth.md#getauthoidcconfig) | **GET** /auth/oidc/config | Read the current JWT authentication backend configuration.
*Auth* | [**GetAuthOidcOidcCallback**](docs/Auth.md#getauthoidcoidccallback) | **GET** /auth/oidc/oidc/callback | Callback endpoint to complete an OIDC login.
*Auth* | [**GetAuthOidcRole**](docs/Auth.md#getauthoidcrole) | **GET** /auth/oidc/role | Lists all the roles registered with the backend.
*Auth* | [**GetAuthOidcRoleName**](docs/Auth.md#getauthoidcrolename) | **GET** /auth/oidc/role/{name} | Read an existing role.
*Auth* | [**GetAuthOktaConfig**](docs/Auth.md#getauthoktaconfig) | **GET** /auth/okta/config | This endpoint allows you to configure the Okta and its configuration options.  The Okta organization are the characters at the front of the URL for Okta. Example https://ORG.okta.com
*Auth* | [**GetAuthOktaGroups**](docs/Auth.md#getauthoktagroups) | **GET** /auth/okta/groups | Manage users allowed to authenticate.
*Auth* | [**GetAuthOktaGroupsName**](docs/Auth.md#getauthoktagroupsname) | **GET** /auth/okta/groups/{name} | Manage users allowed to authenticate.
*Auth* | [**GetAuthOktaUsers**](docs/Auth.md#getauthoktausers) | **GET** /auth/okta/users | Manage additional groups for users allowed to authenticate.
*Auth* | [**GetAuthOktaUsersName**](docs/Auth.md#getauthoktausersname) | **GET** /auth/okta/users/{name} | Manage additional groups for users allowed to authenticate.
*Auth* | [**GetAuthOktaVerifyNonce**](docs/Auth.md#getauthoktaverifynonce) | **GET** /auth/okta/verify/{nonce} | 
*Auth* | [**GetAuthRadiusConfig**](docs/Auth.md#getauthradiusconfig) | **GET** /auth/radius/config | Configure the RADIUS server to connect to, along with its options.
*Auth* | [**GetAuthRadiusUsers**](docs/Auth.md#getauthradiususers) | **GET** /auth/radius/users | Manage users allowed to authenticate.
*Auth* | [**GetAuthRadiusUsersName**](docs/Auth.md#getauthradiususersname) | **GET** /auth/radius/users/{name} | Manage users allowed to authenticate.
*Auth* | [**GetAuthTokenAccessors**](docs/Auth.md#getauthtokenaccessors) | **GET** /auth/token/accessors/ | List token accessors, which can then be be used to iterate and discover their properties or revoke them. Because this can be used to cause a denial of service, this endpoint requires 'sudo' capability in addition to 'list'.
*Auth* | [**GetAuthTokenLookup**](docs/Auth.md#getauthtokenlookup) | **GET** /auth/token/lookup | This endpoint will lookup a token and its properties.
*Auth* | [**GetAuthTokenLookupSelf**](docs/Auth.md#getauthtokenlookupself) | **GET** /auth/token/lookup-self | This endpoint will lookup a token and its properties.
*Auth* | [**GetAuthTokenRoles**](docs/Auth.md#getauthtokenroles) | **GET** /auth/token/roles | This endpoint lists configured roles.
*Auth* | [**GetAuthTokenRolesRoleName**](docs/Auth.md#getauthtokenrolesrolename) | **GET** /auth/token/roles/{role_name} | 
*Auth* | [**GetAuthUserpassUsers**](docs/Auth.md#getauthuserpassusers) | **GET** /auth/userpass/users | Manage users allowed to authenticate.
*Auth* | [**GetAuthUserpassUsersUsername**](docs/Auth.md#getauthuserpassusersusername) | **GET** /auth/userpass/users/{username} | Manage users allowed to authenticate.
*Auth* | [**PostAuthAlicloudLogin**](docs/Auth.md#postauthalicloudlogin) | **POST** /auth/alicloud/login | Authenticates an RAM entity with Vault.
*Auth* | [**PostAuthAlicloudRoleRole**](docs/Auth.md#postauthalicloudrolerole) | **POST** /auth/alicloud/role/{role} | Create a role and associate policies to it.
*Auth* | [**PostAuthAppIdLogin**](docs/Auth.md#postauthappidlogin) | **POST** /auth/app-id/login | Log in with an App ID and User ID.
*Auth* | [**PostAuthAppIdLoginAppId**](docs/Auth.md#postauthappidloginappid) | **POST** /auth/app-id/login/{app_id} | Log in with an App ID and User ID.
*Auth* | [**PostAuthAppIdMapAppIdKey**](docs/Auth.md#postauthappidmapappidkey) | **POST** /auth/app-id/map/app-id/{key} | Read/write/delete a single app-id mapping
*Auth* | [**PostAuthAppIdMapUserIdKey**](docs/Auth.md#postauthappidmapuseridkey) | **POST** /auth/app-id/map/user-id/{key} | Read/write/delete a single user-id mapping
*Auth* | [**PostAuthApproleLogin**](docs/Auth.md#postauthapprolelogin) | **POST** /auth/approle/login | 
*Auth* | [**PostAuthApproleRoleRoleName**](docs/Auth.md#postauthapprolerolerolename) | **POST** /auth/approle/role/{role_name} | Register an role with the backend.
*Auth* | [**PostAuthApproleRoleRoleNameBindSecretId**](docs/Auth.md#postauthapprolerolerolenamebindsecretid) | **POST** /auth/approle/role/{role_name}/bind-secret-id | Impose secret_id to be presented during login using this role.
*Auth* | [**PostAuthApproleRoleRoleNameBoundCidrList**](docs/Auth.md#postauthapprolerolerolenameboundcidrlist) | **POST** /auth/approle/role/{role_name}/bound-cidr-list | Deprecated: Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
*Auth* | [**PostAuthApproleRoleRoleNameCustomSecretId**](docs/Auth.md#postauthapprolerolerolenamecustomsecretid) | **POST** /auth/approle/role/{role_name}/custom-secret-id | Assign a SecretID of choice against the role.
*Auth* | [**PostAuthApproleRoleRoleNamePeriod**](docs/Auth.md#postauthapprolerolerolenameperiod) | **POST** /auth/approle/role/{role_name}/period | Updates the value of 'period' on the role
*Auth* | [**PostAuthApproleRoleRoleNamePolicies**](docs/Auth.md#postauthapprolerolerolenamepolicies) | **POST** /auth/approle/role/{role_name}/policies | Policies of the role.
*Auth* | [**PostAuthApproleRoleRoleNameRoleId**](docs/Auth.md#postauthapprolerolerolenameroleid) | **POST** /auth/approle/role/{role_name}/role-id | Returns the 'role_id' of the role.
*Auth* | [**PostAuthApproleRoleRoleNameSecretId**](docs/Auth.md#postauthapprolerolerolenamesecretid) | **POST** /auth/approle/role/{role_name}/secret-id | Generate a SecretID against this role.
*Auth* | [**PostAuthApproleRoleRoleNameSecretIdAccessorDestroy**](docs/Auth.md#postauthapprolerolerolenamesecretidaccessordestroy) | **POST** /auth/approle/role/{role_name}/secret-id-accessor/destroy | 
*Auth* | [**PostAuthApproleRoleRoleNameSecretIdAccessorLookup**](docs/Auth.md#postauthapprolerolerolenamesecretidaccessorlookup) | **POST** /auth/approle/role/{role_name}/secret-id-accessor/lookup | 
*Auth* | [**PostAuthApproleRoleRoleNameSecretIdBoundCidrs**](docs/Auth.md#postauthapprolerolerolenamesecretidboundcidrs) | **POST** /auth/approle/role/{role_name}/secret-id-bound-cidrs | Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
*Auth* | [**PostAuthApproleRoleRoleNameSecretIdDestroy**](docs/Auth.md#postauthapprolerolerolenamesecretiddestroy) | **POST** /auth/approle/role/{role_name}/secret-id/destroy | Invalidate an issued secret_id
*Auth* | [**PostAuthApproleRoleRoleNameSecretIdLookup**](docs/Auth.md#postauthapprolerolerolenamesecretidlookup) | **POST** /auth/approle/role/{role_name}/secret-id/lookup | Read the properties of an issued secret_id
*Auth* | [**PostAuthApproleRoleRoleNameSecretIdNumUses**](docs/Auth.md#postauthapprolerolerolenamesecretidnumuses) | **POST** /auth/approle/role/{role_name}/secret-id-num-uses | Use limit of the SecretID generated against the role.
*Auth* | [**PostAuthApproleRoleRoleNameSecretIdTtl**](docs/Auth.md#postauthapprolerolerolenamesecretidttl) | **POST** /auth/approle/role/{role_name}/secret-id-ttl | Duration in seconds, representing the lifetime of the SecretIDs that are generated against the role using 'role/<role_name>/secret-id' or 'role/<role_name>/custom-secret-id' endpoints.
*Auth* | [**PostAuthApproleRoleRoleNameTokenBoundCidrs**](docs/Auth.md#postauthapprolerolerolenametokenboundcidrs) | **POST** /auth/approle/role/{role_name}/token-bound-cidrs | Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token.
*Auth* | [**PostAuthApproleRoleRoleNameTokenMaxTtl**](docs/Auth.md#postauthapprolerolerolenametokenmaxttl) | **POST** /auth/approle/role/{role_name}/token-max-ttl | Duration in seconds, the maximum lifetime of the tokens issued by using the SecretIDs that were generated against this role, after which the tokens are not allowed to be renewed.
*Auth* | [**PostAuthApproleRoleRoleNameTokenNumUses**](docs/Auth.md#postauthapprolerolerolenametokennumuses) | **POST** /auth/approle/role/{role_name}/token-num-uses | Number of times issued tokens can be used
*Auth* | [**PostAuthApproleRoleRoleNameTokenTtl**](docs/Auth.md#postauthapprolerolerolenametokenttl) | **POST** /auth/approle/role/{role_name}/token-ttl | Duration in seconds, the lifetime of the token issued by using the SecretID that is generated against this role, before which the token needs to be renewed.
*Auth* | [**PostAuthApproleTidySecretId**](docs/Auth.md#postauthapproletidysecretid) | **POST** /auth/approle/tidy/secret-id | Trigger the clean-up of expired SecretID entries.
*Auth* | [**PostAuthAwsConfigCertificateCertName**](docs/Auth.md#postauthawsconfigcertificatecertname) | **POST** /auth/aws/config/certificate/{cert_name} | 
*Auth* | [**PostAuthAwsConfigClient**](docs/Auth.md#postauthawsconfigclient) | **POST** /auth/aws/config/client | 
*Auth* | [**PostAuthAwsConfigIdentity**](docs/Auth.md#postauthawsconfigidentity) | **POST** /auth/aws/config/identity | 
*Auth* | [**PostAuthAwsConfigRotateRoot**](docs/Auth.md#postauthawsconfigrotateroot) | **POST** /auth/aws/config/rotate-root | 
*Auth* | [**PostAuthAwsConfigStsAccountId**](docs/Auth.md#postauthawsconfigstsaccountid) | **POST** /auth/aws/config/sts/{account_id} | 
*Auth* | [**PostAuthAwsConfigTidyIdentityAccesslist**](docs/Auth.md#postauthawsconfigtidyidentityaccesslist) | **POST** /auth/aws/config/tidy/identity-accesslist | 
*Auth* | [**PostAuthAwsConfigTidyIdentityWhitelist**](docs/Auth.md#postauthawsconfigtidyidentitywhitelist) | **POST** /auth/aws/config/tidy/identity-whitelist | 
*Auth* | [**PostAuthAwsConfigTidyRoletagBlacklist**](docs/Auth.md#postauthawsconfigtidyroletagblacklist) | **POST** /auth/aws/config/tidy/roletag-blacklist | 
*Auth* | [**PostAuthAwsConfigTidyRoletagDenylist**](docs/Auth.md#postauthawsconfigtidyroletagdenylist) | **POST** /auth/aws/config/tidy/roletag-denylist | 
*Auth* | [**PostAuthAwsLogin**](docs/Auth.md#postauthawslogin) | **POST** /auth/aws/login | 
*Auth* | [**PostAuthAwsRoleRole**](docs/Auth.md#postauthawsrolerole) | **POST** /auth/aws/role/{role} | 
*Auth* | [**PostAuthAwsRoleRoleTag**](docs/Auth.md#postauthawsroleroletag) | **POST** /auth/aws/role/{role}/tag | 
*Auth* | [**PostAuthAwsRoletagBlacklistRoleTag**](docs/Auth.md#postauthawsroletagblacklistroletag) | **POST** /auth/aws/roletag-blacklist/{role_tag} | 
*Auth* | [**PostAuthAwsRoletagDenylistRoleTag**](docs/Auth.md#postauthawsroletagdenylistroletag) | **POST** /auth/aws/roletag-denylist/{role_tag} | 
*Auth* | [**PostAuthAwsTidyIdentityAccesslist**](docs/Auth.md#postauthawstidyidentityaccesslist) | **POST** /auth/aws/tidy/identity-accesslist | 
*Auth* | [**PostAuthAwsTidyIdentityWhitelist**](docs/Auth.md#postauthawstidyidentitywhitelist) | **POST** /auth/aws/tidy/identity-whitelist | 
*Auth* | [**PostAuthAwsTidyRoletagBlacklist**](docs/Auth.md#postauthawstidyroletagblacklist) | **POST** /auth/aws/tidy/roletag-blacklist | 
*Auth* | [**PostAuthAwsTidyRoletagDenylist**](docs/Auth.md#postauthawstidyroletagdenylist) | **POST** /auth/aws/tidy/roletag-denylist | 
*Auth* | [**PostAuthAzureConfig**](docs/Auth.md#postauthazureconfig) | **POST** /auth/azure/config | 
*Auth* | [**PostAuthAzureLogin**](docs/Auth.md#postauthazurelogin) | **POST** /auth/azure/login | 
*Auth* | [**PostAuthAzureRoleName**](docs/Auth.md#postauthazurerolename) | **POST** /auth/azure/role/{name} | 
*Auth* | [**PostAuthCentrifyConfig**](docs/Auth.md#postauthcentrifyconfig) | **POST** /auth/centrify/config | This path allows you to configure the centrify auth provider to interact with the Centrify Identity Services Platform for authenticating users.
*Auth* | [**PostAuthCentrifyLogin**](docs/Auth.md#postauthcentrifylogin) | **POST** /auth/centrify/login | Log in with a username and password.
*Auth* | [**PostAuthCertCertsName**](docs/Auth.md#postauthcertcertsname) | **POST** /auth/cert/certs/{name} | Manage trusted certificates used for authentication.
*Auth* | [**PostAuthCertConfig**](docs/Auth.md#postauthcertconfig) | **POST** /auth/cert/config | 
*Auth* | [**PostAuthCertCrlsName**](docs/Auth.md#postauthcertcrlsname) | **POST** /auth/cert/crls/{name} | Manage Certificate Revocation Lists checked during authentication.
*Auth* | [**PostAuthCertLogin**](docs/Auth.md#postauthcertlogin) | **POST** /auth/cert/login | 
*Auth* | [**PostAuthCfConfig**](docs/Auth.md#postauthcfconfig) | **POST** /auth/cf/config | 
*Auth* | [**PostAuthCfLogin**](docs/Auth.md#postauthcflogin) | **POST** /auth/cf/login | 
*Auth* | [**PostAuthCfRolesRole**](docs/Auth.md#postauthcfrolesrole) | **POST** /auth/cf/roles/{role} | 
*Auth* | [**PostAuthGcpConfig**](docs/Auth.md#postauthgcpconfig) | **POST** /auth/gcp/config | Configure credentials used to query the GCP IAM API to verify authenticating service accounts
*Auth* | [**PostAuthGcpLogin**](docs/Auth.md#postauthgcplogin) | **POST** /auth/gcp/login | 
*Auth* | [**PostAuthGcpRoleName**](docs/Auth.md#postauthgcprolename) | **POST** /auth/gcp/role/{name} | Create a GCP role with associated policies and required attributes.
*Auth* | [**PostAuthGcpRoleNameLabels**](docs/Auth.md#postauthgcprolenamelabels) | **POST** /auth/gcp/role/{name}/labels | Add or remove labels for an existing 'gce' role
*Auth* | [**PostAuthGcpRoleNameServiceAccounts**](docs/Auth.md#postauthgcprolenameserviceaccounts) | **POST** /auth/gcp/role/{name}/service-accounts | Add or remove service accounts for an existing `iam` role
*Auth* | [**PostAuthGithubConfig**](docs/Auth.md#postauthgithubconfig) | **POST** /auth/github/config | 
*Auth* | [**PostAuthGithubLogin**](docs/Auth.md#postauthgithublogin) | **POST** /auth/github/login | 
*Auth* | [**PostAuthGithubMapTeamsKey**](docs/Auth.md#postauthgithubmapteamskey) | **POST** /auth/github/map/teams/{key} | Read/write/delete a single teams mapping
*Auth* | [**PostAuthGithubMapUsersKey**](docs/Auth.md#postauthgithubmapuserskey) | **POST** /auth/github/map/users/{key} | Read/write/delete a single users mapping
*Auth* | [**PostAuthJwtConfig**](docs/Auth.md#postauthjwtconfig) | **POST** /auth/jwt/config | Configure the JWT authentication backend.
*Auth* | [**PostAuthJwtLogin**](docs/Auth.md#postauthjwtlogin) | **POST** /auth/jwt/login | Authenticates to Vault using a JWT (or OIDC) token.
*Auth* | [**PostAuthJwtOidcAuthUrl**](docs/Auth.md#postauthjwtoidcauthurl) | **POST** /auth/jwt/oidc/auth_url | Request an authorization URL to start an OIDC login flow.
*Auth* | [**PostAuthJwtOidcCallback**](docs/Auth.md#postauthjwtoidccallback) | **POST** /auth/jwt/oidc/callback | Callback endpoint to handle form_posts.
*Auth* | [**PostAuthJwtRoleName**](docs/Auth.md#postauthjwtrolename) | **POST** /auth/jwt/role/{name} | Register an role with the backend.
*Auth* | [**PostAuthKerberosConfig**](docs/Auth.md#postauthkerberosconfig) | **POST** /auth/kerberos/config | 
*Auth* | [**PostAuthKerberosConfigLdap**](docs/Auth.md#postauthkerberosconfigldap) | **POST** /auth/kerberos/config/ldap | 
*Auth* | [**PostAuthKerberosGroupsName**](docs/Auth.md#postauthkerberosgroupsname) | **POST** /auth/kerberos/groups/{name} | 
*Auth* | [**PostAuthKerberosLogin**](docs/Auth.md#postauthkerberoslogin) | **POST** /auth/kerberos/login | 
*Auth* | [**PostAuthKubernetesConfig**](docs/Auth.md#postauthkubernetesconfig) | **POST** /auth/kubernetes/config | Configures the JWT Public Key and Kubernetes API information.
*Auth* | [**PostAuthKubernetesLogin**](docs/Auth.md#postauthkuberneteslogin) | **POST** /auth/kubernetes/login | Authenticates Kubernetes service accounts with Vault.
*Auth* | [**PostAuthKubernetesRoleName**](docs/Auth.md#postauthkubernetesrolename) | **POST** /auth/kubernetes/role/{name} | Register an role with the backend.
*Auth* | [**PostAuthLdapConfig**](docs/Auth.md#postauthldapconfig) | **POST** /auth/ldap/config | Configure the LDAP server to connect to, along with its options.
*Auth* | [**PostAuthLdapGroupsName**](docs/Auth.md#postauthldapgroupsname) | **POST** /auth/ldap/groups/{name} | Manage additional groups for users allowed to authenticate.
*Auth* | [**PostAuthLdapLoginUsername**](docs/Auth.md#postauthldaploginusername) | **POST** /auth/ldap/login/{username} | Log in with a username and password.
*Auth* | [**PostAuthLdapUsersName**](docs/Auth.md#postauthldapusersname) | **POST** /auth/ldap/users/{name} | Manage users allowed to authenticate.
*Auth* | [**PostAuthOciConfig**](docs/Auth.md#postauthociconfig) | **POST** /auth/oci/config | Manages the configuration for the Vault Auth Plugin.
*Auth* | [**PostAuthOciLoginRole**](docs/Auth.md#postauthociloginrole) | **POST** /auth/oci/login/{role} | Authenticates to Vault using OCI credentials
*Auth* | [**PostAuthOciRoleRole**](docs/Auth.md#postauthocirolerole) | **POST** /auth/oci/role/{role} | Create a role and associate policies to it.
*Auth* | [**PostAuthOidcConfig**](docs/Auth.md#postauthoidcconfig) | **POST** /auth/oidc/config | Configure the JWT authentication backend.
*Auth* | [**PostAuthOidcLogin**](docs/Auth.md#postauthoidclogin) | **POST** /auth/oidc/login | Authenticates to Vault using a JWT (or OIDC) token.
*Auth* | [**PostAuthOidcOidcAuthUrl**](docs/Auth.md#postauthoidcoidcauthurl) | **POST** /auth/oidc/oidc/auth_url | Request an authorization URL to start an OIDC login flow.
*Auth* | [**PostAuthOidcOidcCallback**](docs/Auth.md#postauthoidcoidccallback) | **POST** /auth/oidc/oidc/callback | Callback endpoint to handle form_posts.
*Auth* | [**PostAuthOidcRoleName**](docs/Auth.md#postauthoidcrolename) | **POST** /auth/oidc/role/{name} | Register an role with the backend.
*Auth* | [**PostAuthOktaConfig**](docs/Auth.md#postauthoktaconfig) | **POST** /auth/okta/config | This endpoint allows you to configure the Okta and its configuration options.  The Okta organization are the characters at the front of the URL for Okta. Example https://ORG.okta.com
*Auth* | [**PostAuthOktaGroupsName**](docs/Auth.md#postauthoktagroupsname) | **POST** /auth/okta/groups/{name} | Manage users allowed to authenticate.
*Auth* | [**PostAuthOktaLoginUsername**](docs/Auth.md#postauthoktaloginusername) | **POST** /auth/okta/login/{username} | Log in with a username and password.
*Auth* | [**PostAuthOktaUsersName**](docs/Auth.md#postauthoktausersname) | **POST** /auth/okta/users/{name} | Manage additional groups for users allowed to authenticate.
*Auth* | [**PostAuthRadiusConfig**](docs/Auth.md#postauthradiusconfig) | **POST** /auth/radius/config | Configure the RADIUS server to connect to, along with its options.
*Auth* | [**PostAuthRadiusLogin**](docs/Auth.md#postauthradiuslogin) | **POST** /auth/radius/login | Log in with a username and password.
*Auth* | [**PostAuthRadiusLoginUrlusername**](docs/Auth.md#postauthradiusloginurlusername) | **POST** /auth/radius/login/{urlusername} | Log in with a username and password.
*Auth* | [**PostAuthRadiusUsersName**](docs/Auth.md#postauthradiususersname) | **POST** /auth/radius/users/{name} | Manage users allowed to authenticate.
*Auth* | [**PostAuthTokenCreate**](docs/Auth.md#postauthtokencreate) | **POST** /auth/token/create | The token create path is used to create new tokens.
*Auth* | [**PostAuthTokenCreateOrphan**](docs/Auth.md#postauthtokencreateorphan) | **POST** /auth/token/create-orphan | The token create path is used to create new orphan tokens.
*Auth* | [**PostAuthTokenCreateRoleName**](docs/Auth.md#postauthtokencreaterolename) | **POST** /auth/token/create/{role_name} | This token create path is used to create new tokens adhering to the given role.
*Auth* | [**PostAuthTokenLookup**](docs/Auth.md#postauthtokenlookup) | **POST** /auth/token/lookup | This endpoint will lookup a token and its properties.
*Auth* | [**PostAuthTokenLookupAccessor**](docs/Auth.md#postauthtokenlookupaccessor) | **POST** /auth/token/lookup-accessor | This endpoint will lookup a token associated with the given accessor and its properties. Response will not contain the token ID.
*Auth* | [**PostAuthTokenLookupSelf**](docs/Auth.md#postauthtokenlookupself) | **POST** /auth/token/lookup-self | This endpoint will lookup a token and its properties.
*Auth* | [**PostAuthTokenRenew**](docs/Auth.md#postauthtokenrenew) | **POST** /auth/token/renew | This endpoint will renew the given token and prevent expiration.
*Auth* | [**PostAuthTokenRenewAccessor**](docs/Auth.md#postauthtokenrenewaccessor) | **POST** /auth/token/renew-accessor | This endpoint will renew a token associated with the given accessor and its properties. Response will not contain the token ID.
*Auth* | [**PostAuthTokenRenewSelf**](docs/Auth.md#postauthtokenrenewself) | **POST** /auth/token/renew-self | This endpoint will renew the token used to call it and prevent expiration.
*Auth* | [**PostAuthTokenRevoke**](docs/Auth.md#postauthtokenrevoke) | **POST** /auth/token/revoke | This endpoint will delete the given token and all of its child tokens.
*Auth* | [**PostAuthTokenRevokeAccessor**](docs/Auth.md#postauthtokenrevokeaccessor) | **POST** /auth/token/revoke-accessor | This endpoint will delete the token associated with the accessor and all of its child tokens.
*Auth* | [**PostAuthTokenRevokeOrphan**](docs/Auth.md#postauthtokenrevokeorphan) | **POST** /auth/token/revoke-orphan | This endpoint will delete the token and orphan its child tokens.
*Auth* | [**PostAuthTokenRevokeSelf**](docs/Auth.md#postauthtokenrevokeself) | **POST** /auth/token/revoke-self | This endpoint will delete the token used to call it and all of its child tokens.
*Auth* | [**PostAuthTokenRolesRoleName**](docs/Auth.md#postauthtokenrolesrolename) | **POST** /auth/token/roles/{role_name} | 
*Auth* | [**PostAuthTokenTidy**](docs/Auth.md#postauthtokentidy) | **POST** /auth/token/tidy | This endpoint performs cleanup tasks that can be run if certain error conditions have occurred.
*Auth* | [**PostAuthUserpassLoginUsername**](docs/Auth.md#postauthuserpassloginusername) | **POST** /auth/userpass/login/{username} | Log in with a username and password.
*Auth* | [**PostAuthUserpassUsersUsername**](docs/Auth.md#postauthuserpassusersusername) | **POST** /auth/userpass/users/{username} | Manage users allowed to authenticate.
*Auth* | [**PostAuthUserpassUsersUsernamePassword**](docs/Auth.md#postauthuserpassusersusernamepassword) | **POST** /auth/userpass/users/{username}/password | Reset user's password.
*Auth* | [**PostAuthUserpassUsersUsernamePolicies**](docs/Auth.md#postauthuserpassusersusernamepolicies) | **POST** /auth/userpass/users/{username}/policies | Update the policies associated with the username.
*Identity* | [**DeleteIdentityAliasIdId**](docs/Identity.md#deleteidentityaliasidid) | **DELETE** /identity/alias/id/{id} | Update, read or delete an alias ID.
*Identity* | [**DeleteIdentityEntityAliasIdId**](docs/Identity.md#deleteidentityentityaliasidid) | **DELETE** /identity/entity-alias/id/{id} | Update, read or delete an alias ID.
*Identity* | [**DeleteIdentityEntityIdId**](docs/Identity.md#deleteidentityentityidid) | **DELETE** /identity/entity/id/{id} | Update, read or delete an entity using entity ID
*Identity* | [**DeleteIdentityEntityNameName**](docs/Identity.md#deleteidentityentitynamename) | **DELETE** /identity/entity/name/{name} | Update, read or delete an entity using entity name
*Identity* | [**DeleteIdentityGroupAliasIdId**](docs/Identity.md#deleteidentitygroupaliasidid) | **DELETE** /identity/group-alias/id/{id} | 
*Identity* | [**DeleteIdentityGroupIdId**](docs/Identity.md#deleteidentitygroupidid) | **DELETE** /identity/group/id/{id} | Update or delete an existing group using its ID.
*Identity* | [**DeleteIdentityGroupNameName**](docs/Identity.md#deleteidentitygroupnamename) | **DELETE** /identity/group/name/{name} | 
*Identity* | [**DeleteIdentityMfaLoginEnforcementName**](docs/Identity.md#deleteidentitymfaloginenforcementname) | **DELETE** /identity/mfa/login-enforcement/{name} | Delete a login enforcement
*Identity* | [**DeleteIdentityMfaMethodDuoMethodId**](docs/Identity.md#deleteidentitymfamethodduomethodid) | **DELETE** /identity/mfa/method/duo/{method_id} | Delete a configuration for the given MFA method
*Identity* | [**DeleteIdentityMfaMethodOktaMethodId**](docs/Identity.md#deleteidentitymfamethodoktamethodid) | **DELETE** /identity/mfa/method/okta/{method_id} | Delete a configuration for the given MFA method
*Identity* | [**DeleteIdentityMfaMethodPingidMethodId**](docs/Identity.md#deleteidentitymfamethodpingidmethodid) | **DELETE** /identity/mfa/method/pingid/{method_id} | Delete a configuration for the given MFA method
*Identity* | [**DeleteIdentityMfaMethodTotpMethodId**](docs/Identity.md#deleteidentitymfamethodtotpmethodid) | **DELETE** /identity/mfa/method/totp/{method_id} | Delete a configuration for the given MFA method
*Identity* | [**DeleteIdentityOidcAssignmentName**](docs/Identity.md#deleteidentityoidcassignmentname) | **DELETE** /identity/oidc/assignment/{name} | 
*Identity* | [**DeleteIdentityOidcClientName**](docs/Identity.md#deleteidentityoidcclientname) | **DELETE** /identity/oidc/client/{name} | 
*Identity* | [**DeleteIdentityOidcKeyName**](docs/Identity.md#deleteidentityoidckeyname) | **DELETE** /identity/oidc/key/{name} | CRUD operations for OIDC keys.
*Identity* | [**DeleteIdentityOidcProviderName**](docs/Identity.md#deleteidentityoidcprovidername) | **DELETE** /identity/oidc/provider/{name} | 
*Identity* | [**DeleteIdentityOidcRoleName**](docs/Identity.md#deleteidentityoidcrolename) | **DELETE** /identity/oidc/role/{name} | CRUD operations on OIDC Roles
*Identity* | [**DeleteIdentityOidcScopeName**](docs/Identity.md#deleteidentityoidcscopename) | **DELETE** /identity/oidc/scope/{name} | 
*Identity* | [**DeleteIdentityPersonaIdId**](docs/Identity.md#deleteidentitypersonaidid) | **DELETE** /identity/persona/id/{id} | Update, read or delete an alias ID.
*Identity* | [**GetIdentityAliasId**](docs/Identity.md#getidentityaliasid) | **GET** /identity/alias/id | List all the alias IDs.
*Identity* | [**GetIdentityAliasIdId**](docs/Identity.md#getidentityaliasidid) | **GET** /identity/alias/id/{id} | Update, read or delete an alias ID.
*Identity* | [**GetIdentityEntityAliasId**](docs/Identity.md#getidentityentityaliasid) | **GET** /identity/entity-alias/id | List all the alias IDs.
*Identity* | [**GetIdentityEntityAliasIdId**](docs/Identity.md#getidentityentityaliasidid) | **GET** /identity/entity-alias/id/{id} | Update, read or delete an alias ID.
*Identity* | [**GetIdentityEntityId**](docs/Identity.md#getidentityentityid) | **GET** /identity/entity/id | List all the entity IDs
*Identity* | [**GetIdentityEntityIdId**](docs/Identity.md#getidentityentityidid) | **GET** /identity/entity/id/{id} | Update, read or delete an entity using entity ID
*Identity* | [**GetIdentityEntityName**](docs/Identity.md#getidentityentityname) | **GET** /identity/entity/name | List all the entity names
*Identity* | [**GetIdentityEntityNameName**](docs/Identity.md#getidentityentitynamename) | **GET** /identity/entity/name/{name} | Update, read or delete an entity using entity name
*Identity* | [**GetIdentityGroupAliasId**](docs/Identity.md#getidentitygroupaliasid) | **GET** /identity/group-alias/id | List all the group alias IDs.
*Identity* | [**GetIdentityGroupAliasIdId**](docs/Identity.md#getidentitygroupaliasidid) | **GET** /identity/group-alias/id/{id} | 
*Identity* | [**GetIdentityGroupId**](docs/Identity.md#getidentitygroupid) | **GET** /identity/group/id | List all the group IDs.
*Identity* | [**GetIdentityGroupIdId**](docs/Identity.md#getidentitygroupidid) | **GET** /identity/group/id/{id} | Update or delete an existing group using its ID.
*Identity* | [**GetIdentityGroupName**](docs/Identity.md#getidentitygroupname) | **GET** /identity/group/name | 
*Identity* | [**GetIdentityGroupNameName**](docs/Identity.md#getidentitygroupnamename) | **GET** /identity/group/name/{name} | 
*Identity* | [**GetIdentityMfaLoginEnforcement**](docs/Identity.md#getidentitymfaloginenforcement) | **GET** /identity/mfa/login-enforcement | List login enforcements
*Identity* | [**GetIdentityMfaLoginEnforcementName**](docs/Identity.md#getidentitymfaloginenforcementname) | **GET** /identity/mfa/login-enforcement/{name} | Read the current login enforcement
*Identity* | [**GetIdentityMfaMethod**](docs/Identity.md#getidentitymfamethod) | **GET** /identity/mfa/method | List MFA method configurations for all MFA methods
*Identity* | [**GetIdentityMfaMethodDuo**](docs/Identity.md#getidentitymfamethodduo) | **GET** /identity/mfa/method/duo | List MFA method configurations for the given MFA method
*Identity* | [**GetIdentityMfaMethodDuoMethodId**](docs/Identity.md#getidentitymfamethodduomethodid) | **GET** /identity/mfa/method/duo/{method_id} | Read the current configuration for the given MFA method
*Identity* | [**GetIdentityMfaMethodMethodId**](docs/Identity.md#getidentitymfamethodmethodid) | **GET** /identity/mfa/method/{method_id} | Read the current configuration for the given ID regardless of the MFA method type
*Identity* | [**GetIdentityMfaMethodOkta**](docs/Identity.md#getidentitymfamethodokta) | **GET** /identity/mfa/method/okta | List MFA method configurations for the given MFA method
*Identity* | [**GetIdentityMfaMethodOktaMethodId**](docs/Identity.md#getidentitymfamethodoktamethodid) | **GET** /identity/mfa/method/okta/{method_id} | Read the current configuration for the given MFA method
*Identity* | [**GetIdentityMfaMethodPingid**](docs/Identity.md#getidentitymfamethodpingid) | **GET** /identity/mfa/method/pingid | List MFA method configurations for the given MFA method
*Identity* | [**GetIdentityMfaMethodPingidMethodId**](docs/Identity.md#getidentitymfamethodpingidmethodid) | **GET** /identity/mfa/method/pingid/{method_id} | Read the current configuration for the given MFA method
*Identity* | [**GetIdentityMfaMethodTotp**](docs/Identity.md#getidentitymfamethodtotp) | **GET** /identity/mfa/method/totp | List MFA method configurations for the given MFA method
*Identity* | [**GetIdentityMfaMethodTotpMethodId**](docs/Identity.md#getidentitymfamethodtotpmethodid) | **GET** /identity/mfa/method/totp/{method_id} | Read the current configuration for the given MFA method
*Identity* | [**GetIdentityOidcAssignment**](docs/Identity.md#getidentityoidcassignment) | **GET** /identity/oidc/assignment | 
*Identity* | [**GetIdentityOidcAssignmentName**](docs/Identity.md#getidentityoidcassignmentname) | **GET** /identity/oidc/assignment/{name} | 
*Identity* | [**GetIdentityOidcClient**](docs/Identity.md#getidentityoidcclient) | **GET** /identity/oidc/client | 
*Identity* | [**GetIdentityOidcClientName**](docs/Identity.md#getidentityoidcclientname) | **GET** /identity/oidc/client/{name} | 
*Identity* | [**GetIdentityOidcConfig**](docs/Identity.md#getidentityoidcconfig) | **GET** /identity/oidc/config | OIDC configuration
*Identity* | [**GetIdentityOidcKey**](docs/Identity.md#getidentityoidckey) | **GET** /identity/oidc/key | List OIDC keys
*Identity* | [**GetIdentityOidcKeyName**](docs/Identity.md#getidentityoidckeyname) | **GET** /identity/oidc/key/{name} | CRUD operations for OIDC keys.
*Identity* | [**GetIdentityOidcProvider**](docs/Identity.md#getidentityoidcprovider) | **GET** /identity/oidc/provider | 
*Identity* | [**GetIdentityOidcProviderName**](docs/Identity.md#getidentityoidcprovidername) | **GET** /identity/oidc/provider/{name} | 
*Identity* | [**GetIdentityOidcProviderNameAuthorize**](docs/Identity.md#getidentityoidcprovidernameauthorize) | **GET** /identity/oidc/provider/{name}/authorize | 
*Identity* | [**GetIdentityOidcProviderNameUserinfo**](docs/Identity.md#getidentityoidcprovidernameuserinfo) | **GET** /identity/oidc/provider/{name}/userinfo | 
*Identity* | [**GetIdentityOidcProviderNameWellKnownKeys**](docs/Identity.md#getidentityoidcprovidernamewellknownkeys) | **GET** /identity/oidc/provider/{name}/.well-known/keys | 
*Identity* | [**GetIdentityOidcProviderNameWellKnownOpenidConfiguration**](docs/Identity.md#getidentityoidcprovidernamewellknownopenidconfiguration) | **GET** /identity/oidc/provider/{name}/.well-known/openid-configuration | 
*Identity* | [**GetIdentityOidcRole**](docs/Identity.md#getidentityoidcrole) | **GET** /identity/oidc/role | List configured OIDC roles
*Identity* | [**GetIdentityOidcRoleName**](docs/Identity.md#getidentityoidcrolename) | **GET** /identity/oidc/role/{name} | CRUD operations on OIDC Roles
*Identity* | [**GetIdentityOidcScope**](docs/Identity.md#getidentityoidcscope) | **GET** /identity/oidc/scope | 
*Identity* | [**GetIdentityOidcScopeName**](docs/Identity.md#getidentityoidcscopename) | **GET** /identity/oidc/scope/{name} | 
*Identity* | [**GetIdentityOidcTokenName**](docs/Identity.md#getidentityoidctokenname) | **GET** /identity/oidc/token/{name} | Generate an OIDC token
*Identity* | [**GetIdentityOidcWellKnownKeys**](docs/Identity.md#getidentityoidcwellknownkeys) | **GET** /identity/oidc/.well-known/keys | Retrieve public keys
*Identity* | [**GetIdentityOidcWellKnownOpenidConfiguration**](docs/Identity.md#getidentityoidcwellknownopenidconfiguration) | **GET** /identity/oidc/.well-known/openid-configuration | Query OIDC configurations
*Identity* | [**GetIdentityPersonaId**](docs/Identity.md#getidentitypersonaid) | **GET** /identity/persona/id | List all the alias IDs.
*Identity* | [**GetIdentityPersonaIdId**](docs/Identity.md#getidentitypersonaidid) | **GET** /identity/persona/id/{id} | Update, read or delete an alias ID.
*Identity* | [**PostIdentityAlias**](docs/Identity.md#postidentityalias) | **POST** /identity/alias | Create a new alias.
*Identity* | [**PostIdentityAliasIdId**](docs/Identity.md#postidentityaliasidid) | **POST** /identity/alias/id/{id} | Update, read or delete an alias ID.
*Identity* | [**PostIdentityEntity**](docs/Identity.md#postidentityentity) | **POST** /identity/entity | Create a new entity
*Identity* | [**PostIdentityEntityAlias**](docs/Identity.md#postidentityentityalias) | **POST** /identity/entity-alias | Create a new alias.
*Identity* | [**PostIdentityEntityAliasIdId**](docs/Identity.md#postidentityentityaliasidid) | **POST** /identity/entity-alias/id/{id} | Update, read or delete an alias ID.
*Identity* | [**PostIdentityEntityBatchDelete**](docs/Identity.md#postidentityentitybatchdelete) | **POST** /identity/entity/batch-delete | Delete all of the entities provided
*Identity* | [**PostIdentityEntityIdId**](docs/Identity.md#postidentityentityidid) | **POST** /identity/entity/id/{id} | Update, read or delete an entity using entity ID
*Identity* | [**PostIdentityEntityMerge**](docs/Identity.md#postidentityentitymerge) | **POST** /identity/entity/merge | Merge two or more entities together
*Identity* | [**PostIdentityEntityNameName**](docs/Identity.md#postidentityentitynamename) | **POST** /identity/entity/name/{name} | Update, read or delete an entity using entity name
*Identity* | [**PostIdentityGroup**](docs/Identity.md#postidentitygroup) | **POST** /identity/group | Create a new group.
*Identity* | [**PostIdentityGroupAlias**](docs/Identity.md#postidentitygroupalias) | **POST** /identity/group-alias | Creates a new group alias, or updates an existing one.
*Identity* | [**PostIdentityGroupAliasIdId**](docs/Identity.md#postidentitygroupaliasidid) | **POST** /identity/group-alias/id/{id} | 
*Identity* | [**PostIdentityGroupIdId**](docs/Identity.md#postidentitygroupidid) | **POST** /identity/group/id/{id} | Update or delete an existing group using its ID.
*Identity* | [**PostIdentityGroupNameName**](docs/Identity.md#postidentitygroupnamename) | **POST** /identity/group/name/{name} | 
*Identity* | [**PostIdentityLookupEntity**](docs/Identity.md#postidentitylookupentity) | **POST** /identity/lookup/entity | Query entities based on various properties.
*Identity* | [**PostIdentityLookupGroup**](docs/Identity.md#postidentitylookupgroup) | **POST** /identity/lookup/group | Query groups based on various properties.
*Identity* | [**PostIdentityMfaLoginEnforcementName**](docs/Identity.md#postidentitymfaloginenforcementname) | **POST** /identity/mfa/login-enforcement/{name} | Create or update a login enforcement
*Identity* | [**PostIdentityMfaMethodDuoMethodId**](docs/Identity.md#postidentitymfamethodduomethodid) | **POST** /identity/mfa/method/duo/{method_id} | Update or create a configuration for the given MFA method
*Identity* | [**PostIdentityMfaMethodOktaMethodId**](docs/Identity.md#postidentitymfamethodoktamethodid) | **POST** /identity/mfa/method/okta/{method_id} | Update or create a configuration for the given MFA method
*Identity* | [**PostIdentityMfaMethodPingidMethodId**](docs/Identity.md#postidentitymfamethodpingidmethodid) | **POST** /identity/mfa/method/pingid/{method_id} | Update or create a configuration for the given MFA method
*Identity* | [**PostIdentityMfaMethodTotpAdminDestroy**](docs/Identity.md#postidentitymfamethodtotpadmindestroy) | **POST** /identity/mfa/method/totp/admin-destroy | Destroys a TOTP secret for the given MFA method ID on the given entity
*Identity* | [**PostIdentityMfaMethodTotpAdminGenerate**](docs/Identity.md#postidentitymfamethodtotpadmingenerate) | **POST** /identity/mfa/method/totp/admin-generate | Update or create TOTP secret for the given method ID on the given entity.
*Identity* | [**PostIdentityMfaMethodTotpGenerate**](docs/Identity.md#postidentitymfamethodtotpgenerate) | **POST** /identity/mfa/method/totp/generate | Update or create TOTP secret for the given method ID on the given entity.
*Identity* | [**PostIdentityMfaMethodTotpMethodId**](docs/Identity.md#postidentitymfamethodtotpmethodid) | **POST** /identity/mfa/method/totp/{method_id} | Update or create a configuration for the given MFA method
*Identity* | [**PostIdentityOidcAssignmentName**](docs/Identity.md#postidentityoidcassignmentname) | **POST** /identity/oidc/assignment/{name} | 
*Identity* | [**PostIdentityOidcClientName**](docs/Identity.md#postidentityoidcclientname) | **POST** /identity/oidc/client/{name} | 
*Identity* | [**PostIdentityOidcConfig**](docs/Identity.md#postidentityoidcconfig) | **POST** /identity/oidc/config | OIDC configuration
*Identity* | [**PostIdentityOidcIntrospect**](docs/Identity.md#postidentityoidcintrospect) | **POST** /identity/oidc/introspect | Verify the authenticity of an OIDC token
*Identity* | [**PostIdentityOidcKeyName**](docs/Identity.md#postidentityoidckeyname) | **POST** /identity/oidc/key/{name} | CRUD operations for OIDC keys.
*Identity* | [**PostIdentityOidcKeyNameRotate**](docs/Identity.md#postidentityoidckeynamerotate) | **POST** /identity/oidc/key/{name}/rotate | Rotate a named OIDC key.
*Identity* | [**PostIdentityOidcProviderName**](docs/Identity.md#postidentityoidcprovidername) | **POST** /identity/oidc/provider/{name} | 
*Identity* | [**PostIdentityOidcProviderNameAuthorize**](docs/Identity.md#postidentityoidcprovidernameauthorize) | **POST** /identity/oidc/provider/{name}/authorize | 
*Identity* | [**PostIdentityOidcProviderNameToken**](docs/Identity.md#postidentityoidcprovidernametoken) | **POST** /identity/oidc/provider/{name}/token | 
*Identity* | [**PostIdentityOidcProviderNameUserinfo**](docs/Identity.md#postidentityoidcprovidernameuserinfo) | **POST** /identity/oidc/provider/{name}/userinfo | 
*Identity* | [**PostIdentityOidcRoleName**](docs/Identity.md#postidentityoidcrolename) | **POST** /identity/oidc/role/{name} | CRUD operations on OIDC Roles
*Identity* | [**PostIdentityOidcScopeName**](docs/Identity.md#postidentityoidcscopename) | **POST** /identity/oidc/scope/{name} | 
*Identity* | [**PostIdentityPersona**](docs/Identity.md#postidentitypersona) | **POST** /identity/persona | Create a new alias.
*Identity* | [**PostIdentityPersonaIdId**](docs/Identity.md#postidentitypersonaidid) | **POST** /identity/persona/id/{id} | Update, read or delete an alias ID.
*Secrets* | [**DeleteAdConfig**](docs/Secrets.md#deleteadconfig) | **DELETE** /ad/config | Configure the AD server to connect to, along with password options.
*Secrets* | [**DeleteAdLibraryName**](docs/Secrets.md#deleteadlibraryname) | **DELETE** /ad/library/{name} | Delete a library set.
*Secrets* | [**DeleteAdRolesName**](docs/Secrets.md#deleteadrolesname) | **DELETE** /ad/roles/{name} | Manage roles to build links between Vault and Active Directory service accounts.
*Secrets* | [**DeleteAlicloudConfig**](docs/Secrets.md#deletealicloudconfig) | **DELETE** /alicloud/config | Configure the access key and secret to use for RAM and STS calls.
*Secrets* | [**DeleteAlicloudRoleName**](docs/Secrets.md#deletealicloudrolename) | **DELETE** /alicloud/role/{name} | Read, write and reference policies and roles that API keys or STS credentials can be made for.
*Secrets* | [**DeleteAwsRolesName**](docs/Secrets.md#deleteawsrolesname) | **DELETE** /aws/roles/{name} | Read, write and reference IAM policies that access keys can be made for.
*Secrets* | [**DeleteAzureConfig**](docs/Secrets.md#deleteazureconfig) | **DELETE** /azure/config | 
*Secrets* | [**DeleteAzureRolesName**](docs/Secrets.md#deleteazurerolesname) | **DELETE** /azure/roles/{name} | Manage the Vault roles used to generate Azure credentials.
*Secrets* | [**DeleteConsulRolesName**](docs/Secrets.md#deleteconsulrolesname) | **DELETE** /consul/roles/{name} | 
*Secrets* | [**DeleteCubbyholePath**](docs/Secrets.md#deletecubbyholepath) | **DELETE** /cubbyhole/{path} | Deletes the secret at the specified location.
*Secrets* | [**DeleteGcpRolesetName**](docs/Secrets.md#deletegcprolesetname) | **DELETE** /gcp/roleset/{name} | 
*Secrets* | [**DeleteGcpStaticAccountName**](docs/Secrets.md#deletegcpstaticaccountname) | **DELETE** /gcp/static-account/{name} | 
*Secrets* | [**DeleteGcpkmsConfig**](docs/Secrets.md#deletegcpkmsconfig) | **DELETE** /gcpkms/config | Configure the GCP KMS secrets engine
*Secrets* | [**DeleteGcpkmsKeysDeregisterKey**](docs/Secrets.md#deletegcpkmskeysderegisterkey) | **DELETE** /gcpkms/keys/deregister/{key} | Deregister an existing key in Vault
*Secrets* | [**DeleteGcpkmsKeysKey**](docs/Secrets.md#deletegcpkmskeyskey) | **DELETE** /gcpkms/keys/{key} | Interact with crypto keys in Vault and Google Cloud KMS
*Secrets* | [**DeleteGcpkmsKeysTrimKey**](docs/Secrets.md#deletegcpkmskeystrimkey) | **DELETE** /gcpkms/keys/trim/{key} | Delete old crypto key versions from Google Cloud KMS
*Secrets* | [**DeleteKubernetesConfig**](docs/Secrets.md#deletekubernetesconfig) | **DELETE** /kubernetes/config | 
*Secrets* | [**DeleteKubernetesRolesName**](docs/Secrets.md#deletekubernetesrolesname) | **DELETE** /kubernetes/roles/{name} | 
*Secrets* | [**DeleteKvPath**](docs/Secrets.md#deletekvpath) | **DELETE** /kv/{path} | Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.
*Secrets* | [**DeleteMongodbatlasRolesName**](docs/Secrets.md#deletemongodbatlasrolesname) | **DELETE** /mongodbatlas/roles/{name} | Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
*Secrets* | [**DeleteNomadConfigAccess**](docs/Secrets.md#deletenomadconfigaccess) | **DELETE** /nomad/config/access | 
*Secrets* | [**DeleteNomadConfigLease**](docs/Secrets.md#deletenomadconfiglease) | **DELETE** /nomad/config/lease | Configure the lease parameters for generated tokens
*Secrets* | [**DeleteNomadRoleName**](docs/Secrets.md#deletenomadrolename) | **DELETE** /nomad/role/{name} | 
*Secrets* | [**DeleteOpenldapConfig**](docs/Secrets.md#deleteopenldapconfig) | **DELETE** /openldap/config | 
*Secrets* | [**DeleteOpenldapRoleName**](docs/Secrets.md#deleteopenldaprolename) | **DELETE** /openldap/role/{name} | 
*Secrets* | [**DeleteOpenldapStaticRoleName**](docs/Secrets.md#deleteopenldapstaticrolename) | **DELETE** /openldap/static-role/{name} | 
*Secrets* | [**DeletePkiIssuerRefDerPem**](docs/Secrets.md#deletepkiissuerrefderpem) | **DELETE** /pki/{issuer_ref}/der|/pem | 
*Secrets* | [**DeletePkiJson**](docs/Secrets.md#deletepkijson) | **DELETE** /pki//json | 
*Secrets* | [**DeletePkiKeyKeyRef**](docs/Secrets.md#deletepkikeykeyref) | **DELETE** /pki/key/{key_ref} | 
*Secrets* | [**DeletePkiRolesName**](docs/Secrets.md#deletepkirolesname) | **DELETE** /pki/roles/{name} | 
*Secrets* | [**DeletePkiRoot**](docs/Secrets.md#deletepkiroot) | **DELETE** /pki/root | 
*Secrets* | [**DeleteRabbitmqRolesName**](docs/Secrets.md#deleterabbitmqrolesname) | **DELETE** /rabbitmq/roles/{name} | Manage the roles that can be created with this backend.
*Secrets* | [**DeleteSecretDataPath**](docs/Secrets.md#deletesecretdatapath) | **DELETE** /secret/data/{path} | Write, Patch, Read, and Delete data in the Key-Value Store.
*Secrets* | [**DeleteSecretMetadataPath**](docs/Secrets.md#deletesecretmetadatapath) | **DELETE** /secret/metadata/{path} | Configures settings for the KV store
*Secrets* | [**DeleteSshConfigCa**](docs/Secrets.md#deletesshconfigca) | **DELETE** /ssh/config/ca | Set the SSH private key used for signing certificates.
*Secrets* | [**DeleteSshConfigZeroaddress**](docs/Secrets.md#deletesshconfigzeroaddress) | **DELETE** /ssh/config/zeroaddress | Assign zero address as default CIDR block for select roles.
*Secrets* | [**DeleteSshKeysKeyName**](docs/Secrets.md#deletesshkeyskeyname) | **DELETE** /ssh/keys/{key_name} | Register a shared private key with Vault.
*Secrets* | [**DeleteSshRolesRole**](docs/Secrets.md#deletesshrolesrole) | **DELETE** /ssh/roles/{role} | Manage the 'roles' that can be created with this backend.
*Secrets* | [**DeleteTerraformConfig**](docs/Secrets.md#deleteterraformconfig) | **DELETE** /terraform/config | 
*Secrets* | [**DeleteTerraformRoleName**](docs/Secrets.md#deleteterraformrolename) | **DELETE** /terraform/role/{name} | 
*Secrets* | [**DeleteTotpKeysName**](docs/Secrets.md#deletetotpkeysname) | **DELETE** /totp/keys/{name} | Manage the keys that can be created with this backend.
*Secrets* | [**DeleteTransitKeysName**](docs/Secrets.md#deletetransitkeysname) | **DELETE** /transit/keys/{name} | Managed named encryption keys
*Secrets* | [**GetAdConfig**](docs/Secrets.md#getadconfig) | **GET** /ad/config | Configure the AD server to connect to, along with password options.
*Secrets* | [**GetAdCredsName**](docs/Secrets.md#getadcredsname) | **GET** /ad/creds/{name} | 
*Secrets* | [**GetAdLibrary**](docs/Secrets.md#getadlibrary) | **GET** /ad/library | 
*Secrets* | [**GetAdLibraryName**](docs/Secrets.md#getadlibraryname) | **GET** /ad/library/{name} | Read a library set.
*Secrets* | [**GetAdLibraryNameStatus**](docs/Secrets.md#getadlibrarynamestatus) | **GET** /ad/library/{name}/status | Check the status of the service accounts in a library set.
*Secrets* | [**GetAdRoles**](docs/Secrets.md#getadroles) | **GET** /ad/roles | List the name of each role currently stored.
*Secrets* | [**GetAdRolesName**](docs/Secrets.md#getadrolesname) | **GET** /ad/roles/{name} | Manage roles to build links between Vault and Active Directory service accounts.
*Secrets* | [**GetAdRotateRoot**](docs/Secrets.md#getadrotateroot) | **GET** /ad/rotate-root | 
*Secrets* | [**GetAlicloudConfig**](docs/Secrets.md#getalicloudconfig) | **GET** /alicloud/config | Configure the access key and secret to use for RAM and STS calls.
*Secrets* | [**GetAlicloudCredsName**](docs/Secrets.md#getalicloudcredsname) | **GET** /alicloud/creds/{name} | Generate an API key or STS credential using the given role's configuration.'
*Secrets* | [**GetAlicloudRole**](docs/Secrets.md#getalicloudrole) | **GET** /alicloud/role | List the existing roles in this backend.
*Secrets* | [**GetAlicloudRoleName**](docs/Secrets.md#getalicloudrolename) | **GET** /alicloud/role/{name} | Read, write and reference policies and roles that API keys or STS credentials can be made for.
*Secrets* | [**GetAwsConfigLease**](docs/Secrets.md#getawsconfiglease) | **GET** /aws/config/lease | Configure the default lease information for generated credentials.
*Secrets* | [**GetAwsConfigRoot**](docs/Secrets.md#getawsconfigroot) | **GET** /aws/config/root | Configure the root credentials that are used to manage IAM.
*Secrets* | [**GetAwsCreds**](docs/Secrets.md#getawscreds) | **GET** /aws/creds | Generate AWS credentials from a specific Vault role.
*Secrets* | [**GetAwsRoles**](docs/Secrets.md#getawsroles) | **GET** /aws/roles | List the existing roles in this backend
*Secrets* | [**GetAwsRolesName**](docs/Secrets.md#getawsrolesname) | **GET** /aws/roles/{name} | Read, write and reference IAM policies that access keys can be made for.
*Secrets* | [**GetAwsStsName**](docs/Secrets.md#getawsstsname) | **GET** /aws/sts/{name} | Generate AWS credentials from a specific Vault role.
*Secrets* | [**GetAzureConfig**](docs/Secrets.md#getazureconfig) | **GET** /azure/config | 
*Secrets* | [**GetAzureCredsRole**](docs/Secrets.md#getazurecredsrole) | **GET** /azure/creds/{role} | 
*Secrets* | [**GetAzureRoles**](docs/Secrets.md#getazureroles) | **GET** /azure/roles | List existing roles.
*Secrets* | [**GetAzureRolesName**](docs/Secrets.md#getazurerolesname) | **GET** /azure/roles/{name} | Manage the Vault roles used to generate Azure credentials.
*Secrets* | [**GetConsulConfigAccess**](docs/Secrets.md#getconsulconfigaccess) | **GET** /consul/config/access | 
*Secrets* | [**GetConsulCredsRole**](docs/Secrets.md#getconsulcredsrole) | **GET** /consul/creds/{role} | 
*Secrets* | [**GetConsulRoles**](docs/Secrets.md#getconsulroles) | **GET** /consul/roles | 
*Secrets* | [**GetConsulRolesName**](docs/Secrets.md#getconsulrolesname) | **GET** /consul/roles/{name} | 
*Secrets* | [**GetCubbyholePath**](docs/Secrets.md#getcubbyholepath) | **GET** /cubbyhole/{path} | Retrieve the secret at the specified location.
*Secrets* | [**GetGcpConfig**](docs/Secrets.md#getgcpconfig) | **GET** /gcp/config | 
*Secrets* | [**GetGcpKeyRoleset**](docs/Secrets.md#getgcpkeyroleset) | **GET** /gcp/key/{roleset} | 
*Secrets* | [**GetGcpRolesetName**](docs/Secrets.md#getgcprolesetname) | **GET** /gcp/roleset/{name} | 
*Secrets* | [**GetGcpRolesetRolesetKey**](docs/Secrets.md#getgcprolesetrolesetkey) | **GET** /gcp/roleset/{roleset}/key | 
*Secrets* | [**GetGcpRolesetRolesetToken**](docs/Secrets.md#getgcprolesetrolesettoken) | **GET** /gcp/roleset/{roleset}/token | 
*Secrets* | [**GetGcpRolesets**](docs/Secrets.md#getgcprolesets) | **GET** /gcp/rolesets | 
*Secrets* | [**GetGcpStaticAccountName**](docs/Secrets.md#getgcpstaticaccountname) | **GET** /gcp/static-account/{name} | 
*Secrets* | [**GetGcpStaticAccountNameKey**](docs/Secrets.md#getgcpstaticaccountnamekey) | **GET** /gcp/static-account/{name}/key | 
*Secrets* | [**GetGcpStaticAccountNameToken**](docs/Secrets.md#getgcpstaticaccountnametoken) | **GET** /gcp/static-account/{name}/token | 
*Secrets* | [**GetGcpStaticAccounts**](docs/Secrets.md#getgcpstaticaccounts) | **GET** /gcp/static-accounts | 
*Secrets* | [**GetGcpTokenRoleset**](docs/Secrets.md#getgcptokenroleset) | **GET** /gcp/token/{roleset} | 
*Secrets* | [**GetGcpkmsConfig**](docs/Secrets.md#getgcpkmsconfig) | **GET** /gcpkms/config | Configure the GCP KMS secrets engine
*Secrets* | [**GetGcpkmsKeys**](docs/Secrets.md#getgcpkmskeys) | **GET** /gcpkms/keys | List named keys
*Secrets* | [**GetGcpkmsKeysConfigKey**](docs/Secrets.md#getgcpkmskeysconfigkey) | **GET** /gcpkms/keys/config/{key} | Configure the key in Vault
*Secrets* | [**GetGcpkmsKeysKey**](docs/Secrets.md#getgcpkmskeyskey) | **GET** /gcpkms/keys/{key} | Interact with crypto keys in Vault and Google Cloud KMS
*Secrets* | [**GetGcpkmsPubkeyKey**](docs/Secrets.md#getgcpkmspubkeykey) | **GET** /gcpkms/pubkey/{key} | Retrieve the public key associated with the named key
*Secrets* | [**GetKubernetesConfig**](docs/Secrets.md#getkubernetesconfig) | **GET** /kubernetes/config | 
*Secrets* | [**GetKubernetesRoles**](docs/Secrets.md#getkubernetesroles) | **GET** /kubernetes/roles | 
*Secrets* | [**GetKubernetesRolesName**](docs/Secrets.md#getkubernetesrolesname) | **GET** /kubernetes/roles/{name} | 
*Secrets* | [**GetKvPath**](docs/Secrets.md#getkvpath) | **GET** /kv/{path} | Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.
*Secrets* | [**GetMongodbatlasConfig**](docs/Secrets.md#getmongodbatlasconfig) | **GET** /mongodbatlas/config | Configure the  credentials that are used to manage Database Users.
*Secrets* | [**GetMongodbatlasCredsName**](docs/Secrets.md#getmongodbatlascredsname) | **GET** /mongodbatlas/creds/{name} | Generate MongoDB Atlas Programmatic API from a specific Vault role.
*Secrets* | [**GetMongodbatlasRoles**](docs/Secrets.md#getmongodbatlasroles) | **GET** /mongodbatlas/roles | List the existing roles in this backend
*Secrets* | [**GetMongodbatlasRolesName**](docs/Secrets.md#getmongodbatlasrolesname) | **GET** /mongodbatlas/roles/{name} | Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
*Secrets* | [**GetNomadConfigAccess**](docs/Secrets.md#getnomadconfigaccess) | **GET** /nomad/config/access | 
*Secrets* | [**GetNomadConfigLease**](docs/Secrets.md#getnomadconfiglease) | **GET** /nomad/config/lease | Configure the lease parameters for generated tokens
*Secrets* | [**GetNomadCredsName**](docs/Secrets.md#getnomadcredsname) | **GET** /nomad/creds/{name} | 
*Secrets* | [**GetNomadRole**](docs/Secrets.md#getnomadrole) | **GET** /nomad/role | 
*Secrets* | [**GetNomadRoleName**](docs/Secrets.md#getnomadrolename) | **GET** /nomad/role/{name} | 
*Secrets* | [**GetOpenldapConfig**](docs/Secrets.md#getopenldapconfig) | **GET** /openldap/config | 
*Secrets* | [**GetOpenldapCredsName**](docs/Secrets.md#getopenldapcredsname) | **GET** /openldap/creds/{name} | 
*Secrets* | [**GetOpenldapRole**](docs/Secrets.md#getopenldaprole) | **GET** /openldap/role | 
*Secrets* | [**GetOpenldapRoleName**](docs/Secrets.md#getopenldaprolename) | **GET** /openldap/role/{name} | 
*Secrets* | [**GetOpenldapStaticCredName**](docs/Secrets.md#getopenldapstaticcredname) | **GET** /openldap/static-cred/{name} | 
*Secrets* | [**GetOpenldapStaticRole**](docs/Secrets.md#getopenldapstaticrole) | **GET** /openldap/static-role | 
*Secrets* | [**GetOpenldapStaticRoleName**](docs/Secrets.md#getopenldapstaticrolename) | **GET** /openldap/static-role/{name} | 
*Secrets* | [**GetPkiCa**](docs/Secrets.md#getpkica) | **GET** /pki/ca | 
*Secrets* | [**GetPkiCaChain**](docs/Secrets.md#getpkicachain) | **GET** /pki/ca_chain | 
*Secrets* | [**GetPkiCaPem**](docs/Secrets.md#getpkicapem) | **GET** /pki/ca/pem | 
*Secrets* | [**GetPkiCertCaChain**](docs/Secrets.md#getpkicertcachain) | **GET** /pki/cert/ca_chain | 
*Secrets* | [**GetPkiCertCrl**](docs/Secrets.md#getpkicertcrl) | **GET** /pki/cert/crl | 
*Secrets* | [**GetPkiCertSerial**](docs/Secrets.md#getpkicertserial) | **GET** /pki/cert/{serial} | 
*Secrets* | [**GetPkiCertSerialRaw**](docs/Secrets.md#getpkicertserialraw) | **GET** /pki/cert/{serial}/raw | 
*Secrets* | [**GetPkiCertSerialRawPem**](docs/Secrets.md#getpkicertserialrawpem) | **GET** /pki/cert/{serial}/raw/pem | 
*Secrets* | [**GetPkiCerts**](docs/Secrets.md#getpkicerts) | **GET** /pki/certs | 
*Secrets* | [**GetPkiConfigCrl**](docs/Secrets.md#getpkiconfigcrl) | **GET** /pki/config/crl | 
*Secrets* | [**GetPkiConfigIssuers**](docs/Secrets.md#getpkiconfigissuers) | **GET** /pki/config/issuers | 
*Secrets* | [**GetPkiConfigKeys**](docs/Secrets.md#getpkiconfigkeys) | **GET** /pki/config/keys | 
*Secrets* | [**GetPkiConfigUrls**](docs/Secrets.md#getpkiconfigurls) | **GET** /pki/config/urls | 
*Secrets* | [**GetPkiCrl**](docs/Secrets.md#getpkicrl) | **GET** /pki/crl | 
*Secrets* | [**GetPkiCrlPem**](docs/Secrets.md#getpkicrlpem) | **GET** /pki/crl/pem | 
*Secrets* | [**GetPkiCrlRotate**](docs/Secrets.md#getpkicrlrotate) | **GET** /pki/crl/rotate | 
*Secrets* | [**GetPkiDer**](docs/Secrets.md#getpkider) | **GET** /pki//der | 
*Secrets* | [**GetPkiIssuerRefCrlPem**](docs/Secrets.md#getpkiissuerrefcrlpem) | **GET** /pki/{issuer_ref}/crl/pem | 
*Secrets* | [**GetPkiIssuerRefDerPem**](docs/Secrets.md#getpkiissuerrefderpem) | **GET** /pki/{issuer_ref}/der|/pem | 
*Secrets* | [**GetPkiIssuers**](docs/Secrets.md#getpkiissuers) | **GET** /pki/issuers | 
*Secrets* | [**GetPkiJson**](docs/Secrets.md#getpkijson) | **GET** /pki//json | 
*Secrets* | [**GetPkiKeyKeyRef**](docs/Secrets.md#getpkikeykeyref) | **GET** /pki/key/{key_ref} | 
*Secrets* | [**GetPkiKeys**](docs/Secrets.md#getpkikeys) | **GET** /pki/keys | 
*Secrets* | [**GetPkiRoles**](docs/Secrets.md#getpkiroles) | **GET** /pki/roles | 
*Secrets* | [**GetPkiRolesName**](docs/Secrets.md#getpkirolesname) | **GET** /pki/roles/{name} | 
*Secrets* | [**GetPkiTidyStatus**](docs/Secrets.md#getpkitidystatus) | **GET** /pki/tidy-status | 
*Secrets* | [**GetRabbitmqConfigLease**](docs/Secrets.md#getrabbitmqconfiglease) | **GET** /rabbitmq/config/lease | Configure the lease parameters for generated credentials
*Secrets* | [**GetRabbitmqCredsName**](docs/Secrets.md#getrabbitmqcredsname) | **GET** /rabbitmq/creds/{name} | Request RabbitMQ credentials for a certain role.
*Secrets* | [**GetRabbitmqRoles**](docs/Secrets.md#getrabbitmqroles) | **GET** /rabbitmq/roles | Manage the roles that can be created with this backend.
*Secrets* | [**GetRabbitmqRolesName**](docs/Secrets.md#getrabbitmqrolesname) | **GET** /rabbitmq/roles/{name} | Manage the roles that can be created with this backend.
*Secrets* | [**GetSecretConfig**](docs/Secrets.md#getsecretconfig) | **GET** /secret/config | Read the backend level settings.
*Secrets* | [**GetSecretDataPath**](docs/Secrets.md#getsecretdatapath) | **GET** /secret/data/{path} | Write, Patch, Read, and Delete data in the Key-Value Store.
*Secrets* | [**GetSecretMetadataPath**](docs/Secrets.md#getsecretmetadatapath) | **GET** /secret/metadata/{path} | Configures settings for the KV store
*Secrets* | [**GetSecretSubkeysPath**](docs/Secrets.md#getsecretsubkeyspath) | **GET** /secret/subkeys/{path} | Read the structure of a secret entry from the Key-Value store with the values removed.
*Secrets* | [**GetSshConfigCa**](docs/Secrets.md#getsshconfigca) | **GET** /ssh/config/ca | Set the SSH private key used for signing certificates.
*Secrets* | [**GetSshConfigZeroaddress**](docs/Secrets.md#getsshconfigzeroaddress) | **GET** /ssh/config/zeroaddress | Assign zero address as default CIDR block for select roles.
*Secrets* | [**GetSshPublicKey**](docs/Secrets.md#getsshpublickey) | **GET** /ssh/public_key | Retrieve the public key.
*Secrets* | [**GetSshRoles**](docs/Secrets.md#getsshroles) | **GET** /ssh/roles | Manage the 'roles' that can be created with this backend.
*Secrets* | [**GetSshRolesRole**](docs/Secrets.md#getsshrolesrole) | **GET** /ssh/roles/{role} | Manage the 'roles' that can be created with this backend.
*Secrets* | [**GetTerraformConfig**](docs/Secrets.md#getterraformconfig) | **GET** /terraform/config | 
*Secrets* | [**GetTerraformCredsName**](docs/Secrets.md#getterraformcredsname) | **GET** /terraform/creds/{name} | Generate a Terraform Cloud or Enterprise API token from a specific Vault role.
*Secrets* | [**GetTerraformRole**](docs/Secrets.md#getterraformrole) | **GET** /terraform/role | 
*Secrets* | [**GetTerraformRoleName**](docs/Secrets.md#getterraformrolename) | **GET** /terraform/role/{name} | 
*Secrets* | [**GetTotpCodeName**](docs/Secrets.md#gettotpcodename) | **GET** /totp/code/{name} | Request time-based one-time use password or validate a password for a certain key .
*Secrets* | [**GetTotpKeys**](docs/Secrets.md#gettotpkeys) | **GET** /totp/keys | Manage the keys that can be created with this backend.
*Secrets* | [**GetTotpKeysName**](docs/Secrets.md#gettotpkeysname) | **GET** /totp/keys/{name} | Manage the keys that can be created with this backend.
*Secrets* | [**GetTransitBackupName**](docs/Secrets.md#gettransitbackupname) | **GET** /transit/backup/{name} | Backup the named key
*Secrets* | [**GetTransitCacheConfig**](docs/Secrets.md#gettransitcacheconfig) | **GET** /transit/cache-config | Returns the size of the active cache
*Secrets* | [**GetTransitExportTypeName**](docs/Secrets.md#gettransitexporttypename) | **GET** /transit/export/{type}/{name} | Export named encryption or signing key
*Secrets* | [**GetTransitExportTypeNameVersion**](docs/Secrets.md#gettransitexporttypenameversion) | **GET** /transit/export/{type}/{name}/{version} | Export named encryption or signing key
*Secrets* | [**GetTransitKeys**](docs/Secrets.md#gettransitkeys) | **GET** /transit/keys | Managed named encryption keys
*Secrets* | [**GetTransitKeysName**](docs/Secrets.md#gettransitkeysname) | **GET** /transit/keys/{name} | Managed named encryption keys
*Secrets* | [**GetTransitWrappingKey**](docs/Secrets.md#gettransitwrappingkey) | **GET** /transit/wrapping_key | Returns the public key to use for wrapping imported keys
*Secrets* | [**PostAdConfig**](docs/Secrets.md#postadconfig) | **POST** /ad/config | Configure the AD server to connect to, along with password options.
*Secrets* | [**PostAdLibraryManageNameCheckIn**](docs/Secrets.md#postadlibrarymanagenamecheckin) | **POST** /ad/library/manage/{name}/check-in | Check service accounts in to the library.
*Secrets* | [**PostAdLibraryName**](docs/Secrets.md#postadlibraryname) | **POST** /ad/library/{name} | Update a library set.
*Secrets* | [**PostAdLibraryNameCheckIn**](docs/Secrets.md#postadlibrarynamecheckin) | **POST** /ad/library/{name}/check-in | Check service accounts in to the library.
*Secrets* | [**PostAdLibraryNameCheckOut**](docs/Secrets.md#postadlibrarynamecheckout) | **POST** /ad/library/{name}/check-out | Check a service account out from the library.
*Secrets* | [**PostAdRolesName**](docs/Secrets.md#postadrolesname) | **POST** /ad/roles/{name} | Manage roles to build links between Vault and Active Directory service accounts.
*Secrets* | [**PostAdRotateRoleName**](docs/Secrets.md#postadrotaterolename) | **POST** /ad/rotate-role/{name} | 
*Secrets* | [**PostAdRotateRoot**](docs/Secrets.md#postadrotateroot) | **POST** /ad/rotate-root | 
*Secrets* | [**PostAlicloudConfig**](docs/Secrets.md#postalicloudconfig) | **POST** /alicloud/config | Configure the access key and secret to use for RAM and STS calls.
*Secrets* | [**PostAlicloudRoleName**](docs/Secrets.md#postalicloudrolename) | **POST** /alicloud/role/{name} | Read, write and reference policies and roles that API keys or STS credentials can be made for.
*Secrets* | [**PostAwsConfigLease**](docs/Secrets.md#postawsconfiglease) | **POST** /aws/config/lease | Configure the default lease information for generated credentials.
*Secrets* | [**PostAwsConfigRoot**](docs/Secrets.md#postawsconfigroot) | **POST** /aws/config/root | Configure the root credentials that are used to manage IAM.
*Secrets* | [**PostAwsConfigRotateRoot**](docs/Secrets.md#postawsconfigrotateroot) | **POST** /aws/config/rotate-root | 
*Secrets* | [**PostAwsCreds**](docs/Secrets.md#postawscreds) | **POST** /aws/creds | Generate AWS credentials from a specific Vault role.
*Secrets* | [**PostAwsRolesName**](docs/Secrets.md#postawsrolesname) | **POST** /aws/roles/{name} | Read, write and reference IAM policies that access keys can be made for.
*Secrets* | [**PostAwsStsName**](docs/Secrets.md#postawsstsname) | **POST** /aws/sts/{name} | Generate AWS credentials from a specific Vault role.
*Secrets* | [**PostAzureConfig**](docs/Secrets.md#postazureconfig) | **POST** /azure/config | 
*Secrets* | [**PostAzureRolesName**](docs/Secrets.md#postazurerolesname) | **POST** /azure/roles/{name} | Manage the Vault roles used to generate Azure credentials.
*Secrets* | [**PostAzureRotateRoot**](docs/Secrets.md#postazurerotateroot) | **POST** /azure/rotate-root | 
*Secrets* | [**PostConsulConfigAccess**](docs/Secrets.md#postconsulconfigaccess) | **POST** /consul/config/access | 
*Secrets* | [**PostConsulRolesName**](docs/Secrets.md#postconsulrolesname) | **POST** /consul/roles/{name} | 
*Secrets* | [**PostCubbyholePath**](docs/Secrets.md#postcubbyholepath) | **POST** /cubbyhole/{path} | Store a secret at the specified location.
*Secrets* | [**PostGcpConfig**](docs/Secrets.md#postgcpconfig) | **POST** /gcp/config | 
*Secrets* | [**PostGcpConfigRotateRoot**](docs/Secrets.md#postgcpconfigrotateroot) | **POST** /gcp/config/rotate-root | 
*Secrets* | [**PostGcpKeyRoleset**](docs/Secrets.md#postgcpkeyroleset) | **POST** /gcp/key/{roleset} | 
*Secrets* | [**PostGcpRolesetName**](docs/Secrets.md#postgcprolesetname) | **POST** /gcp/roleset/{name} | 
*Secrets* | [**PostGcpRolesetNameRotate**](docs/Secrets.md#postgcprolesetnamerotate) | **POST** /gcp/roleset/{name}/rotate | 
*Secrets* | [**PostGcpRolesetNameRotateKey**](docs/Secrets.md#postgcprolesetnamerotatekey) | **POST** /gcp/roleset/{name}/rotate-key | 
*Secrets* | [**PostGcpRolesetRolesetKey**](docs/Secrets.md#postgcprolesetrolesetkey) | **POST** /gcp/roleset/{roleset}/key | 
*Secrets* | [**PostGcpRolesetRolesetToken**](docs/Secrets.md#postgcprolesetrolesettoken) | **POST** /gcp/roleset/{roleset}/token | 
*Secrets* | [**PostGcpStaticAccountName**](docs/Secrets.md#postgcpstaticaccountname) | **POST** /gcp/static-account/{name} | 
*Secrets* | [**PostGcpStaticAccountNameKey**](docs/Secrets.md#postgcpstaticaccountnamekey) | **POST** /gcp/static-account/{name}/key | 
*Secrets* | [**PostGcpStaticAccountNameRotateKey**](docs/Secrets.md#postgcpstaticaccountnamerotatekey) | **POST** /gcp/static-account/{name}/rotate-key | 
*Secrets* | [**PostGcpStaticAccountNameToken**](docs/Secrets.md#postgcpstaticaccountnametoken) | **POST** /gcp/static-account/{name}/token | 
*Secrets* | [**PostGcpTokenRoleset**](docs/Secrets.md#postgcptokenroleset) | **POST** /gcp/token/{roleset} | 
*Secrets* | [**PostGcpkmsConfig**](docs/Secrets.md#postgcpkmsconfig) | **POST** /gcpkms/config | Configure the GCP KMS secrets engine
*Secrets* | [**PostGcpkmsDecryptKey**](docs/Secrets.md#postgcpkmsdecryptkey) | **POST** /gcpkms/decrypt/{key} | Decrypt a ciphertext value using a named key
*Secrets* | [**PostGcpkmsEncryptKey**](docs/Secrets.md#postgcpkmsencryptkey) | **POST** /gcpkms/encrypt/{key} | Encrypt a plaintext value using a named key
*Secrets* | [**PostGcpkmsKeysConfigKey**](docs/Secrets.md#postgcpkmskeysconfigkey) | **POST** /gcpkms/keys/config/{key} | Configure the key in Vault
*Secrets* | [**PostGcpkmsKeysDeregisterKey**](docs/Secrets.md#postgcpkmskeysderegisterkey) | **POST** /gcpkms/keys/deregister/{key} | Deregister an existing key in Vault
*Secrets* | [**PostGcpkmsKeysKey**](docs/Secrets.md#postgcpkmskeyskey) | **POST** /gcpkms/keys/{key} | Interact with crypto keys in Vault and Google Cloud KMS
*Secrets* | [**PostGcpkmsKeysRegisterKey**](docs/Secrets.md#postgcpkmskeysregisterkey) | **POST** /gcpkms/keys/register/{key} | Register an existing crypto key in Google Cloud KMS
*Secrets* | [**PostGcpkmsKeysRotateKey**](docs/Secrets.md#postgcpkmskeysrotatekey) | **POST** /gcpkms/keys/rotate/{key} | Rotate a crypto key to a new primary version
*Secrets* | [**PostGcpkmsKeysTrimKey**](docs/Secrets.md#postgcpkmskeystrimkey) | **POST** /gcpkms/keys/trim/{key} | Delete old crypto key versions from Google Cloud KMS
*Secrets* | [**PostGcpkmsReencryptKey**](docs/Secrets.md#postgcpkmsreencryptkey) | **POST** /gcpkms/reencrypt/{key} | Re-encrypt existing ciphertext data to a new version
*Secrets* | [**PostGcpkmsSignKey**](docs/Secrets.md#postgcpkmssignkey) | **POST** /gcpkms/sign/{key} | Signs a message or digest using a named key
*Secrets* | [**PostGcpkmsVerifyKey**](docs/Secrets.md#postgcpkmsverifykey) | **POST** /gcpkms/verify/{key} | Verify a signature using a named key
*Secrets* | [**PostKubernetesConfig**](docs/Secrets.md#postkubernetesconfig) | **POST** /kubernetes/config | 
*Secrets* | [**PostKubernetesCredsName**](docs/Secrets.md#postkubernetescredsname) | **POST** /kubernetes/creds/{name} | 
*Secrets* | [**PostKubernetesRolesName**](docs/Secrets.md#postkubernetesrolesname) | **POST** /kubernetes/roles/{name} | 
*Secrets* | [**PostKvPath**](docs/Secrets.md#postkvpath) | **POST** /kv/{path} | Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.
*Secrets* | [**PostMongodbatlasConfig**](docs/Secrets.md#postmongodbatlasconfig) | **POST** /mongodbatlas/config | Configure the  credentials that are used to manage Database Users.
*Secrets* | [**PostMongodbatlasCredsName**](docs/Secrets.md#postmongodbatlascredsname) | **POST** /mongodbatlas/creds/{name} | Generate MongoDB Atlas Programmatic API from a specific Vault role.
*Secrets* | [**PostMongodbatlasRolesName**](docs/Secrets.md#postmongodbatlasrolesname) | **POST** /mongodbatlas/roles/{name} | Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
*Secrets* | [**PostNomadConfigAccess**](docs/Secrets.md#postnomadconfigaccess) | **POST** /nomad/config/access | 
*Secrets* | [**PostNomadConfigLease**](docs/Secrets.md#postnomadconfiglease) | **POST** /nomad/config/lease | Configure the lease parameters for generated tokens
*Secrets* | [**PostNomadRoleName**](docs/Secrets.md#postnomadrolename) | **POST** /nomad/role/{name} | 
*Secrets* | [**PostOpenldapConfig**](docs/Secrets.md#postopenldapconfig) | **POST** /openldap/config | 
*Secrets* | [**PostOpenldapRoleName**](docs/Secrets.md#postopenldaprolename) | **POST** /openldap/role/{name} | 
*Secrets* | [**PostOpenldapRotateRoleName**](docs/Secrets.md#postopenldaprotaterolename) | **POST** /openldap/rotate-role/{name} | 
*Secrets* | [**PostOpenldapRotateRoot**](docs/Secrets.md#postopenldaprotateroot) | **POST** /openldap/rotate-root | 
*Secrets* | [**PostOpenldapStaticRoleName**](docs/Secrets.md#postopenldapstaticrolename) | **POST** /openldap/static-role/{name} | 
*Secrets* | [**PostPkiBundle**](docs/Secrets.md#postpkibundle) | **POST** /pki/bundle | 
*Secrets* | [**PostPkiCert**](docs/Secrets.md#postpkicert) | **POST** /pki/cert | 
*Secrets* | [**PostPkiConfigCa**](docs/Secrets.md#postpkiconfigca) | **POST** /pki/config/ca | 
*Secrets* | [**PostPkiConfigCrl**](docs/Secrets.md#postpkiconfigcrl) | **POST** /pki/config/crl | 
*Secrets* | [**PostPkiConfigIssuers**](docs/Secrets.md#postpkiconfigissuers) | **POST** /pki/config/issuers | 
*Secrets* | [**PostPkiConfigKeys**](docs/Secrets.md#postpkiconfigkeys) | **POST** /pki/config/keys | 
*Secrets* | [**PostPkiConfigUrls**](docs/Secrets.md#postpkiconfigurls) | **POST** /pki/config/urls | 
*Secrets* | [**PostPkiIntermediateCrossSign**](docs/Secrets.md#postpkiintermediatecrosssign) | **POST** /pki/intermediate/cross-sign | 
*Secrets* | [**PostPkiIntermediateGenerateExported**](docs/Secrets.md#postpkiintermediategenerateexported) | **POST** /pki/intermediate/generate/{exported} | 
*Secrets* | [**PostPkiIntermediateSetSigned**](docs/Secrets.md#postpkiintermediatesetsigned) | **POST** /pki/intermediate/set-signed | 
*Secrets* | [**PostPkiInternalExported**](docs/Secrets.md#postpkiinternalexported) | **POST** /pki/internal|exported | 
*Secrets* | [**PostPkiIssueRole**](docs/Secrets.md#postpkiissuerole) | **POST** /pki/issue/{role} | 
*Secrets* | [**PostPkiIssuerIssuerRefIssueRole**](docs/Secrets.md#postpkiissuerissuerrefissuerole) | **POST** /pki/issuer/{issuer_ref}/issue/{role} | 
*Secrets* | [**PostPkiIssuerIssuerRefSignIntermediate**](docs/Secrets.md#postpkiissuerissuerrefsignintermediate) | **POST** /pki/issuer/{issuer_ref}/sign-intermediate | 
*Secrets* | [**PostPkiIssuerIssuerRefSignRole**](docs/Secrets.md#postpkiissuerissuerrefsignrole) | **POST** /pki/issuer/{issuer_ref}/sign/{role} | 
*Secrets* | [**PostPkiIssuerIssuerRefSignSelfIssued**](docs/Secrets.md#postpkiissuerissuerrefsignselfissued) | **POST** /pki/issuer/{issuer_ref}/sign-self-issued | 
*Secrets* | [**PostPkiIssuerIssuerRefSignVerbatim**](docs/Secrets.md#postpkiissuerissuerrefsignverbatim) | **POST** /pki/issuer/{issuer_ref}/sign-verbatim | 
*Secrets* | [**PostPkiIssuerIssuerRefSignVerbatimRole**](docs/Secrets.md#postpkiissuerissuerrefsignverbatimrole) | **POST** /pki/issuer/{issuer_ref}/sign-verbatim/{role} | 
*Secrets* | [**PostPkiIssuerRefDerPem**](docs/Secrets.md#postpkiissuerrefderpem) | **POST** /pki/{issuer_ref}/der|/pem | 
*Secrets* | [**PostPkiIssuersGenerateIntermediateExported**](docs/Secrets.md#postpkiissuersgenerateintermediateexported) | **POST** /pki/issuers/generate/intermediate/{exported} | 
*Secrets* | [**PostPkiIssuersGenerateRootExported**](docs/Secrets.md#postpkiissuersgeneraterootexported) | **POST** /pki/issuers/generate/root/{exported} | 
*Secrets* | [**PostPkiJson**](docs/Secrets.md#postpkijson) | **POST** /pki//json | 
*Secrets* | [**PostPkiKeyKeyRef**](docs/Secrets.md#postpkikeykeyref) | **POST** /pki/key/{key_ref} | 
*Secrets* | [**PostPkiKeysImport**](docs/Secrets.md#postpkikeysimport) | **POST** /pki/keys/import | 
*Secrets* | [**PostPkiKms**](docs/Secrets.md#postpkikms) | **POST** /pki/kms | 
*Secrets* | [**PostPkiRevoke**](docs/Secrets.md#postpkirevoke) | **POST** /pki/revoke | 
*Secrets* | [**PostPkiRolesName**](docs/Secrets.md#postpkirolesname) | **POST** /pki/roles/{name} | 
*Secrets* | [**PostPkiRootGenerateExported**](docs/Secrets.md#postpkirootgenerateexported) | **POST** /pki/root/generate/{exported} | 
*Secrets* | [**PostPkiRootReplace**](docs/Secrets.md#postpkirootreplace) | **POST** /pki/root/replace | 
*Secrets* | [**PostPkiRootRotateExported**](docs/Secrets.md#postpkirootrotateexported) | **POST** /pki/root/rotate/{exported} | 
*Secrets* | [**PostPkiRootSignIntermediate**](docs/Secrets.md#postpkirootsignintermediate) | **POST** /pki/root/sign-intermediate | 
*Secrets* | [**PostPkiRootSignSelfIssued**](docs/Secrets.md#postpkirootsignselfissued) | **POST** /pki/root/sign-self-issued | 
*Secrets* | [**PostPkiSignRole**](docs/Secrets.md#postpkisignrole) | **POST** /pki/sign/{role} | 
*Secrets* | [**PostPkiSignVerbatim**](docs/Secrets.md#postpkisignverbatim) | **POST** /pki/sign-verbatim | 
*Secrets* | [**PostPkiSignVerbatimRole**](docs/Secrets.md#postpkisignverbatimrole) | **POST** /pki/sign-verbatim/{role} | 
*Secrets* | [**PostPkiTidy**](docs/Secrets.md#postpkitidy) | **POST** /pki/tidy | 
*Secrets* | [**PostRabbitmqConfigConnection**](docs/Secrets.md#postrabbitmqconfigconnection) | **POST** /rabbitmq/config/connection | Configure the connection URI, username, and password to talk to RabbitMQ management HTTP API.
*Secrets* | [**PostRabbitmqConfigLease**](docs/Secrets.md#postrabbitmqconfiglease) | **POST** /rabbitmq/config/lease | Configure the lease parameters for generated credentials
*Secrets* | [**PostRabbitmqRolesName**](docs/Secrets.md#postrabbitmqrolesname) | **POST** /rabbitmq/roles/{name} | Manage the roles that can be created with this backend.
*Secrets* | [**PostSecretConfig**](docs/Secrets.md#postsecretconfig) | **POST** /secret/config | Configure backend level settings that are applied to every key in the key-value store.
*Secrets* | [**PostSecretDataPath**](docs/Secrets.md#postsecretdatapath) | **POST** /secret/data/{path} | Write, Patch, Read, and Delete data in the Key-Value Store.
*Secrets* | [**PostSecretDeletePath**](docs/Secrets.md#postsecretdeletepath) | **POST** /secret/delete/{path} | Marks one or more versions as deleted in the KV store.
*Secrets* | [**PostSecretDestroyPath**](docs/Secrets.md#postsecretdestroypath) | **POST** /secret/destroy/{path} | Permanently removes one or more versions in the KV store
*Secrets* | [**PostSecretMetadataPath**](docs/Secrets.md#postsecretmetadatapath) | **POST** /secret/metadata/{path} | Configures settings for the KV store
*Secrets* | [**PostSecretUndeletePath**](docs/Secrets.md#postsecretundeletepath) | **POST** /secret/undelete/{path} | Undeletes one or more versions from the KV store.
*Secrets* | [**PostSshConfigCa**](docs/Secrets.md#postsshconfigca) | **POST** /ssh/config/ca | Set the SSH private key used for signing certificates.
*Secrets* | [**PostSshConfigZeroaddress**](docs/Secrets.md#postsshconfigzeroaddress) | **POST** /ssh/config/zeroaddress | Assign zero address as default CIDR block for select roles.
*Secrets* | [**PostSshCredsRole**](docs/Secrets.md#postsshcredsrole) | **POST** /ssh/creds/{role} | Creates a credential for establishing SSH connection with the remote host.
*Secrets* | [**PostSshKeysKeyName**](docs/Secrets.md#postsshkeyskeyname) | **POST** /ssh/keys/{key_name} | Register a shared private key with Vault.
*Secrets* | [**PostSshLookup**](docs/Secrets.md#postsshlookup) | **POST** /ssh/lookup | List all the roles associated with the given IP address.
*Secrets* | [**PostSshRolesRole**](docs/Secrets.md#postsshrolesrole) | **POST** /ssh/roles/{role} | Manage the 'roles' that can be created with this backend.
*Secrets* | [**PostSshSignRole**](docs/Secrets.md#postsshsignrole) | **POST** /ssh/sign/{role} | Request signing an SSH key using a certain role with the provided details.
*Secrets* | [**PostSshVerify**](docs/Secrets.md#postsshverify) | **POST** /ssh/verify | Validate the OTP provided by Vault SSH Agent.
*Secrets* | [**PostTerraformConfig**](docs/Secrets.md#postterraformconfig) | **POST** /terraform/config | 
*Secrets* | [**PostTerraformCredsName**](docs/Secrets.md#postterraformcredsname) | **POST** /terraform/creds/{name} | Generate a Terraform Cloud or Enterprise API token from a specific Vault role.
*Secrets* | [**PostTerraformRoleName**](docs/Secrets.md#postterraformrolename) | **POST** /terraform/role/{name} | 
*Secrets* | [**PostTerraformRotateRoleName**](docs/Secrets.md#postterraformrotaterolename) | **POST** /terraform/rotate-role/{name} | 
*Secrets* | [**PostTotpCodeName**](docs/Secrets.md#posttotpcodename) | **POST** /totp/code/{name} | Request time-based one-time use password or validate a password for a certain key .
*Secrets* | [**PostTotpKeysName**](docs/Secrets.md#posttotpkeysname) | **POST** /totp/keys/{name} | Manage the keys that can be created with this backend.
*Secrets* | [**PostTransitCacheConfig**](docs/Secrets.md#posttransitcacheconfig) | **POST** /transit/cache-config | Configures a new cache of the specified size
*Secrets* | [**PostTransitDatakeyPlaintextName**](docs/Secrets.md#posttransitdatakeyplaintextname) | **POST** /transit/datakey/{plaintext}/{name} | Generate a data key
*Secrets* | [**PostTransitDecryptName**](docs/Secrets.md#posttransitdecryptname) | **POST** /transit/decrypt/{name} | Decrypt a ciphertext value using a named key
*Secrets* | [**PostTransitEncryptName**](docs/Secrets.md#posttransitencryptname) | **POST** /transit/encrypt/{name} | Encrypt a plaintext value or a batch of plaintext blocks using a named key
*Secrets* | [**PostTransitHash**](docs/Secrets.md#posttransithash) | **POST** /transit/hash | Generate a hash sum for input data
*Secrets* | [**PostTransitHashUrlalgorithm**](docs/Secrets.md#posttransithashurlalgorithm) | **POST** /transit/hash/{urlalgorithm} | Generate a hash sum for input data
*Secrets* | [**PostTransitHmacName**](docs/Secrets.md#posttransithmacname) | **POST** /transit/hmac/{name} | Generate an HMAC for input data using the named key
*Secrets* | [**PostTransitHmacNameUrlalgorithm**](docs/Secrets.md#posttransithmacnameurlalgorithm) | **POST** /transit/hmac/{name}/{urlalgorithm} | Generate an HMAC for input data using the named key
*Secrets* | [**PostTransitKeysName**](docs/Secrets.md#posttransitkeysname) | **POST** /transit/keys/{name} | Managed named encryption keys
*Secrets* | [**PostTransitKeysNameConfig**](docs/Secrets.md#posttransitkeysnameconfig) | **POST** /transit/keys/{name}/config | Configure a named encryption key
*Secrets* | [**PostTransitKeysNameImport**](docs/Secrets.md#posttransitkeysnameimport) | **POST** /transit/keys/{name}/import | Imports an externally-generated key into a new transit key
*Secrets* | [**PostTransitKeysNameImportVersion**](docs/Secrets.md#posttransitkeysnameimportversion) | **POST** /transit/keys/{name}/import_version | Imports an externally-generated key into an existing imported key
*Secrets* | [**PostTransitKeysNameRotate**](docs/Secrets.md#posttransitkeysnamerotate) | **POST** /transit/keys/{name}/rotate | Rotate named encryption key
*Secrets* | [**PostTransitKeysNameTrim**](docs/Secrets.md#posttransitkeysnametrim) | **POST** /transit/keys/{name}/trim | Trim key versions of a named key
*Secrets* | [**PostTransitRandom**](docs/Secrets.md#posttransitrandom) | **POST** /transit/random | Generate random bytes
*Secrets* | [**PostTransitRandomSource**](docs/Secrets.md#posttransitrandomsource) | **POST** /transit/random/{source} | Generate random bytes
*Secrets* | [**PostTransitRandomSourceUrlbytes**](docs/Secrets.md#posttransitrandomsourceurlbytes) | **POST** /transit/random/{source}/{urlbytes} | Generate random bytes
*Secrets* | [**PostTransitRandomUrlbytes**](docs/Secrets.md#posttransitrandomurlbytes) | **POST** /transit/random/{urlbytes} | Generate random bytes
*Secrets* | [**PostTransitRestore**](docs/Secrets.md#posttransitrestore) | **POST** /transit/restore | Restore the named key
*Secrets* | [**PostTransitRestoreName**](docs/Secrets.md#posttransitrestorename) | **POST** /transit/restore/{name} | Restore the named key
*Secrets* | [**PostTransitRewrapName**](docs/Secrets.md#posttransitrewrapname) | **POST** /transit/rewrap/{name} | Rewrap ciphertext
*Secrets* | [**PostTransitSignName**](docs/Secrets.md#posttransitsignname) | **POST** /transit/sign/{name} | Generate a signature for input data using the named key
*Secrets* | [**PostTransitSignNameUrlalgorithm**](docs/Secrets.md#posttransitsignnameurlalgorithm) | **POST** /transit/sign/{name}/{urlalgorithm} | Generate a signature for input data using the named key
*Secrets* | [**PostTransitVerifyName**](docs/Secrets.md#posttransitverifyname) | **POST** /transit/verify/{name} | Verify a signature or HMAC for input data created using the named key
*Secrets* | [**PostTransitVerifyNameUrlalgorithm**](docs/Secrets.md#posttransitverifynameurlalgorithm) | **POST** /transit/verify/{name}/{urlalgorithm} | Verify a signature or HMAC for input data created using the named key
*System* | [**DeleteSysAuditPath**](docs/System.md#deletesysauditpath) | **DELETE** /sys/audit/{path} | Disable the audit device at the given path.
*System* | [**DeleteSysAuthPath**](docs/System.md#deletesysauthpath) | **DELETE** /sys/auth/{path} | Disable the auth method at the given auth path
*System* | [**DeleteSysConfigAuditingRequestHeadersHeader**](docs/System.md#deletesysconfigauditingrequestheadersheader) | **DELETE** /sys/config/auditing/request-headers/{header} | Disable auditing of the given request header.
*System* | [**DeleteSysConfigCors**](docs/System.md#deletesysconfigcors) | **DELETE** /sys/config/cors | Remove any CORS settings.
*System* | [**DeleteSysConfigUiHeadersHeader**](docs/System.md#deletesysconfiguiheadersheader) | **DELETE** /sys/config/ui/headers/{header} | Remove a UI header.
*System* | [**DeleteSysGenerateRoot**](docs/System.md#deletesysgenerateroot) | **DELETE** /sys/generate-root | Cancels any in-progress root generation attempt.
*System* | [**DeleteSysGenerateRootAttempt**](docs/System.md#deletesysgeneraterootattempt) | **DELETE** /sys/generate-root/attempt | Cancels any in-progress root generation attempt.
*System* | [**DeleteSysMountsPath**](docs/System.md#deletesysmountspath) | **DELETE** /sys/mounts/{path} | Disable the mount point specified at the given path.
*System* | [**DeleteSysPluginsCatalogName**](docs/System.md#deletesyspluginscatalogname) | **DELETE** /sys/plugins/catalog/{name} | Remove the plugin with the given name.
*System* | [**DeleteSysPluginsCatalogTypeName**](docs/System.md#deletesyspluginscatalogtypename) | **DELETE** /sys/plugins/catalog/{type}/{name} | Remove the plugin with the given name.
*System* | [**DeleteSysPoliciesAclName**](docs/System.md#deletesyspoliciesaclname) | **DELETE** /sys/policies/acl/{name} | Delete the ACL policy with the given name.
*System* | [**DeleteSysPoliciesPasswordName**](docs/System.md#deletesyspoliciespasswordname) | **DELETE** /sys/policies/password/{name} | Delete a password policy.
*System* | [**DeleteSysPolicyName**](docs/System.md#deletesyspolicyname) | **DELETE** /sys/policy/{name} | Delete the policy with the given name.
*System* | [**DeleteSysQuotasRateLimitName**](docs/System.md#deletesysquotasratelimitname) | **DELETE** /sys/quotas/rate-limit/{name} | 
*System* | [**DeleteSysRaw**](docs/System.md#deletesysraw) | **DELETE** /sys/raw | Delete the key with given path.
*System* | [**DeleteSysRawPath**](docs/System.md#deletesysrawpath) | **DELETE** /sys/raw/{path} | Delete the key with given path.
*System* | [**DeleteSysRekeyBackup**](docs/System.md#deletesysrekeybackup) | **DELETE** /sys/rekey/backup | Delete the backup copy of PGP-encrypted unseal keys.
*System* | [**DeleteSysRekeyInit**](docs/System.md#deletesysrekeyinit) | **DELETE** /sys/rekey/init | Cancels any in-progress rekey.
*System* | [**DeleteSysRekeyRecoveryKeyBackup**](docs/System.md#deletesysrekeyrecoverykeybackup) | **DELETE** /sys/rekey/recovery-key-backup | Allows fetching or deleting the backup of the rotated unseal keys.
*System* | [**DeleteSysRekeyVerify**](docs/System.md#deletesysrekeyverify) | **DELETE** /sys/rekey/verify | Cancel any in-progress rekey verification operation.
*System* | [**GetSysAudit**](docs/System.md#getsysaudit) | **GET** /sys/audit | List the enabled audit devices.
*System* | [**GetSysAuth**](docs/System.md#getsysauth) | **GET** /sys/auth | List the currently enabled credential backends.
*System* | [**GetSysAuthPath**](docs/System.md#getsysauthpath) | **GET** /sys/auth/{path} | Read the configuration of the auth engine at the given path.
*System* | [**GetSysAuthPathTune**](docs/System.md#getsysauthpathtune) | **GET** /sys/auth/{path}/tune | Reads the given auth path's configuration.
*System* | [**GetSysConfigAuditingRequestHeaders**](docs/System.md#getsysconfigauditingrequestheaders) | **GET** /sys/config/auditing/request-headers | List the request headers that are configured to be audited.
*System* | [**GetSysConfigAuditingRequestHeadersHeader**](docs/System.md#getsysconfigauditingrequestheadersheader) | **GET** /sys/config/auditing/request-headers/{header} | List the information for the given request header.
*System* | [**GetSysConfigCors**](docs/System.md#getsysconfigcors) | **GET** /sys/config/cors | Return the current CORS settings.
*System* | [**GetSysConfigStateSanitized**](docs/System.md#getsysconfigstatesanitized) | **GET** /sys/config/state/sanitized | Return a sanitized version of the Vault server configuration.
*System* | [**GetSysConfigUiHeaders**](docs/System.md#getsysconfiguiheaders) | **GET** /sys/config/ui/headers/ | Return a list of configured UI headers.
*System* | [**GetSysConfigUiHeadersHeader**](docs/System.md#getsysconfiguiheadersheader) | **GET** /sys/config/ui/headers/{header} | Return the given UI header's configuration
*System* | [**GetSysGenerateRoot**](docs/System.md#getsysgenerateroot) | **GET** /sys/generate-root | Read the configuration and progress of the current root generation attempt.
*System* | [**GetSysGenerateRootAttempt**](docs/System.md#getsysgeneraterootattempt) | **GET** /sys/generate-root/attempt | Read the configuration and progress of the current root generation attempt.
*System* | [**GetSysHaStatus**](docs/System.md#getsyshastatus) | **GET** /sys/ha-status | Check the HA status of a Vault cluster
*System* | [**GetSysHealth**](docs/System.md#getsyshealth) | **GET** /sys/health | Returns the health status of Vault.
*System* | [**GetSysHostInfo**](docs/System.md#getsyshostinfo) | **GET** /sys/host-info | Information about the host instance that this Vault server is running on.
*System* | [**GetSysInFlightReq**](docs/System.md#getsysinflightreq) | **GET** /sys/in-flight-req | reports in-flight requests
*System* | [**GetSysInit**](docs/System.md#getsysinit) | **GET** /sys/init | Returns the initialization status of Vault.
*System* | [**GetSysInternalCountersActivity**](docs/System.md#getsysinternalcountersactivity) | **GET** /sys/internal/counters/activity | Report the client count metrics, for this namespace and all child namespaces.
*System* | [**GetSysInternalCountersActivityExport**](docs/System.md#getsysinternalcountersactivityexport) | **GET** /sys/internal/counters/activity/export | Report the client count metrics, for this namespace and all child namespaces.
*System* | [**GetSysInternalCountersActivityMonthly**](docs/System.md#getsysinternalcountersactivitymonthly) | **GET** /sys/internal/counters/activity/monthly | Report the number of clients for this month, for this namespace and all child namespaces.
*System* | [**GetSysInternalCountersConfig**](docs/System.md#getsysinternalcountersconfig) | **GET** /sys/internal/counters/config | Read the client count tracking configuration.
*System* | [**GetSysInternalCountersEntities**](docs/System.md#getsysinternalcountersentities) | **GET** /sys/internal/counters/entities | Backwards compatibility is not guaranteed for this API
*System* | [**GetSysInternalCountersRequests**](docs/System.md#getsysinternalcountersrequests) | **GET** /sys/internal/counters/requests | Backwards compatibility is not guaranteed for this API
*System* | [**GetSysInternalCountersTokens**](docs/System.md#getsysinternalcounterstokens) | **GET** /sys/internal/counters/tokens | Backwards compatibility is not guaranteed for this API
*System* | [**GetSysInternalSpecsOpenapi**](docs/System.md#getsysinternalspecsopenapi) | **GET** /sys/internal/specs/openapi | Generate an OpenAPI 3 document of all mounted paths.
*System* | [**GetSysInternalUiFeatureFlags**](docs/System.md#getsysinternaluifeatureflags) | **GET** /sys/internal/ui/feature-flags | Lists enabled feature flags.
*System* | [**GetSysInternalUiMounts**](docs/System.md#getsysinternaluimounts) | **GET** /sys/internal/ui/mounts | Lists all enabled and visible auth and secrets mounts.
*System* | [**GetSysInternalUiMountsPath**](docs/System.md#getsysinternaluimountspath) | **GET** /sys/internal/ui/mounts/{path} | Return information about the given mount.
*System* | [**GetSysInternalUiNamespaces**](docs/System.md#getsysinternaluinamespaces) | **GET** /sys/internal/ui/namespaces | Backwards compatibility is not guaranteed for this API
*System* | [**GetSysInternalUiResultantAcl**](docs/System.md#getsysinternaluiresultantacl) | **GET** /sys/internal/ui/resultant-acl | Backwards compatibility is not guaranteed for this API
*System* | [**GetSysKeyStatus**](docs/System.md#getsyskeystatus) | **GET** /sys/key-status | Provides information about the backend encryption key.
*System* | [**GetSysLeader**](docs/System.md#getsysleader) | **GET** /sys/leader | Returns the high availability status and current leader instance of Vault.
*System* | [**GetSysLeases**](docs/System.md#getsysleases) | **GET** /sys/leases | List leases associated with this Vault cluster
*System* | [**GetSysLeasesCount**](docs/System.md#getsysleasescount) | **GET** /sys/leases/count | Count of leases associated with this Vault cluster
*System* | [**GetSysLeasesLookup**](docs/System.md#getsysleaseslookup) | **GET** /sys/leases/lookup/ | Returns a list of lease ids.
*System* | [**GetSysLeasesLookupPrefix**](docs/System.md#getsysleaseslookupprefix) | **GET** /sys/leases/lookup/{prefix} | Returns a list of lease ids.
*System* | [**GetSysMetrics**](docs/System.md#getsysmetrics) | **GET** /sys/metrics | Export the metrics aggregated for telemetry purpose.
*System* | [**GetSysMonitor**](docs/System.md#getsysmonitor) | **GET** /sys/monitor | 
*System* | [**GetSysMounts**](docs/System.md#getsysmounts) | **GET** /sys/mounts | List the currently mounted backends.
*System* | [**GetSysMountsPath**](docs/System.md#getsysmountspath) | **GET** /sys/mounts/{path} | Read the configuration of the secret engine at the given path.
*System* | [**GetSysMountsPathTune**](docs/System.md#getsysmountspathtune) | **GET** /sys/mounts/{path}/tune | Tune backend configuration parameters for this mount.
*System* | [**GetSysPluginsCatalog**](docs/System.md#getsyspluginscatalog) | **GET** /sys/plugins/catalog | Lists all the plugins known to Vault
*System* | [**GetSysPluginsCatalogName**](docs/System.md#getsyspluginscatalogname) | **GET** /sys/plugins/catalog/{name} | Return the configuration data for the plugin with the given name.
*System* | [**GetSysPluginsCatalogType**](docs/System.md#getsyspluginscatalogtype) | **GET** /sys/plugins/catalog/{type} | List the plugins in the catalog.
*System* | [**GetSysPluginsCatalogTypeName**](docs/System.md#getsyspluginscatalogtypename) | **GET** /sys/plugins/catalog/{type}/{name} | Return the configuration data for the plugin with the given name.
*System* | [**GetSysPoliciesAcl**](docs/System.md#getsyspoliciesacl) | **GET** /sys/policies/acl | List the configured access control policies.
*System* | [**GetSysPoliciesAclName**](docs/System.md#getsyspoliciesaclname) | **GET** /sys/policies/acl/{name} | Retrieve information about the named ACL policy.
*System* | [**GetSysPoliciesPassword**](docs/System.md#getsyspoliciespassword) | **GET** /sys/policies/password | List the existing password policies.
*System* | [**GetSysPoliciesPasswordName**](docs/System.md#getsyspoliciespasswordname) | **GET** /sys/policies/password/{name} | Retrieve an existing password policy.
*System* | [**GetSysPoliciesPasswordNameGenerate**](docs/System.md#getsyspoliciespasswordnamegenerate) | **GET** /sys/policies/password/{name}/generate | Generate a password from an existing password policy.
*System* | [**GetSysPolicy**](docs/System.md#getsyspolicy) | **GET** /sys/policy | List the configured access control policies.
*System* | [**GetSysPolicyName**](docs/System.md#getsyspolicyname) | **GET** /sys/policy/{name} | Retrieve the policy body for the named policy.
*System* | [**GetSysPprof**](docs/System.md#getsyspprof) | **GET** /sys/pprof/ | Returns an HTML page listing the available profiles.
*System* | [**GetSysPprofAllocs**](docs/System.md#getsyspprofallocs) | **GET** /sys/pprof/allocs | Returns a sampling of all past memory allocations.
*System* | [**GetSysPprofBlock**](docs/System.md#getsyspprofblock) | **GET** /sys/pprof/block | Returns stack traces that led to blocking on synchronization primitives
*System* | [**GetSysPprofCmdline**](docs/System.md#getsyspprofcmdline) | **GET** /sys/pprof/cmdline | Returns the running program's command line.
*System* | [**GetSysPprofGoroutine**](docs/System.md#getsyspprofgoroutine) | **GET** /sys/pprof/goroutine | Returns stack traces of all current goroutines.
*System* | [**GetSysPprofHeap**](docs/System.md#getsyspprofheap) | **GET** /sys/pprof/heap | Returns a sampling of memory allocations of live object.
*System* | [**GetSysPprofMutex**](docs/System.md#getsyspprofmutex) | **GET** /sys/pprof/mutex | Returns stack traces of holders of contended mutexes
*System* | [**GetSysPprofProfile**](docs/System.md#getsyspprofprofile) | **GET** /sys/pprof/profile | Returns a pprof-formatted cpu profile payload.
*System* | [**GetSysPprofSymbol**](docs/System.md#getsyspprofsymbol) | **GET** /sys/pprof/symbol | Returns the program counters listed in the request.
*System* | [**GetSysPprofThreadcreate**](docs/System.md#getsyspprofthreadcreate) | **GET** /sys/pprof/threadcreate | Returns stack traces that led to the creation of new OS threads
*System* | [**GetSysPprofTrace**](docs/System.md#getsyspproftrace) | **GET** /sys/pprof/trace | Returns the execution trace in binary form.
*System* | [**GetSysQuotasConfig**](docs/System.md#getsysquotasconfig) | **GET** /sys/quotas/config | 
*System* | [**GetSysQuotasRateLimit**](docs/System.md#getsysquotasratelimit) | **GET** /sys/quotas/rate-limit | 
*System* | [**GetSysQuotasRateLimitName**](docs/System.md#getsysquotasratelimitname) | **GET** /sys/quotas/rate-limit/{name} | 
*System* | [**GetSysRaw**](docs/System.md#getsysraw) | **GET** /sys/raw | Read the value of the key at the given path.
*System* | [**GetSysRawPath**](docs/System.md#getsysrawpath) | **GET** /sys/raw/{path} | Read the value of the key at the given path.
*System* | [**GetSysRekeyBackup**](docs/System.md#getsysrekeybackup) | **GET** /sys/rekey/backup | Return the backup copy of PGP-encrypted unseal keys.
*System* | [**GetSysRekeyInit**](docs/System.md#getsysrekeyinit) | **GET** /sys/rekey/init | Reads the configuration and progress of the current rekey attempt.
*System* | [**GetSysRekeyRecoveryKeyBackup**](docs/System.md#getsysrekeyrecoverykeybackup) | **GET** /sys/rekey/recovery-key-backup | Allows fetching or deleting the backup of the rotated unseal keys.
*System* | [**GetSysRekeyVerify**](docs/System.md#getsysrekeyverify) | **GET** /sys/rekey/verify | Read the configuration and progress of the current rekey verification attempt.
*System* | [**GetSysRemountStatusMigrationId**](docs/System.md#getsysremountstatusmigrationid) | **GET** /sys/remount/status/{migration_id} | Check status of a mount migration
*System* | [**GetSysReplicationStatus**](docs/System.md#getsysreplicationstatus) | **GET** /sys/replication/status | 
*System* | [**GetSysRotateConfig**](docs/System.md#getsysrotateconfig) | **GET** /sys/rotate/config | 
*System* | [**GetSysSealStatus**](docs/System.md#getsyssealstatus) | **GET** /sys/seal-status | Check the seal status of a Vault.
*System* | [**GetSysVersionHistory**](docs/System.md#getsysversionhistory) | **GET** /sys/version-history/ | Returns map of historical version change entries
*System* | [**GetSysWrappingLookup**](docs/System.md#getsyswrappinglookup) | **GET** /sys/wrapping/lookup | Look up wrapping properties for the requester's token.
*System* | [**PostSysAuditHashPath**](docs/System.md#postsysaudithashpath) | **POST** /sys/audit-hash/{path} | The hash of the given string via the given audit backend
*System* | [**PostSysAuditPath**](docs/System.md#postsysauditpath) | **POST** /sys/audit/{path} | Enable a new audit device at the supplied path.
*System* | [**PostSysAuthPath**](docs/System.md#postsysauthpath) | **POST** /sys/auth/{path} | Enables a new auth method.
*System* | [**PostSysAuthPathTune**](docs/System.md#postsysauthpathtune) | **POST** /sys/auth/{path}/tune | Tune configuration parameters for a given auth path.
*System* | [**PostSysCapabilities**](docs/System.md#postsyscapabilities) | **POST** /sys/capabilities | Fetches the capabilities of the given token on the given path.
*System* | [**PostSysCapabilitiesAccessor**](docs/System.md#postsyscapabilitiesaccessor) | **POST** /sys/capabilities-accessor | Fetches the capabilities of the token associated with the given token, on the given path.
*System* | [**PostSysCapabilitiesSelf**](docs/System.md#postsyscapabilitiesself) | **POST** /sys/capabilities-self | Fetches the capabilities of the given token on the given path.
*System* | [**PostSysConfigAuditingRequestHeadersHeader**](docs/System.md#postsysconfigauditingrequestheadersheader) | **POST** /sys/config/auditing/request-headers/{header} | Enable auditing of a header.
*System* | [**PostSysConfigCors**](docs/System.md#postsysconfigcors) | **POST** /sys/config/cors | Configure the CORS settings.
*System* | [**PostSysConfigReloadSubsystem**](docs/System.md#postsysconfigreloadsubsystem) | **POST** /sys/config/reload/{subsystem} | Reload the given subsystem
*System* | [**PostSysConfigUiHeadersHeader**](docs/System.md#postsysconfiguiheadersheader) | **POST** /sys/config/ui/headers/{header} | Configure the values to be returned for the UI header.
*System* | [**PostSysGenerateRoot**](docs/System.md#postsysgenerateroot) | **POST** /sys/generate-root | Initializes a new root generation attempt.
*System* | [**PostSysGenerateRootAttempt**](docs/System.md#postsysgeneraterootattempt) | **POST** /sys/generate-root/attempt | Initializes a new root generation attempt.
*System* | [**PostSysGenerateRootUpdate**](docs/System.md#postsysgeneraterootupdate) | **POST** /sys/generate-root/update | Enter a single unseal key share to progress the root generation attempt.
*System* | [**PostSysInit**](docs/System.md#postsysinit) | **POST** /sys/init | Initialize a new Vault.
*System* | [**PostSysInternalCountersConfig**](docs/System.md#postsysinternalcountersconfig) | **POST** /sys/internal/counters/config | Enable or disable collection of client count, set retention period, or set default reporting period.
*System* | [**PostSysLeasesLookup**](docs/System.md#postsysleaseslookup) | **POST** /sys/leases/lookup | Retrieve lease metadata.
*System* | [**PostSysLeasesRenew**](docs/System.md#postsysleasesrenew) | **POST** /sys/leases/renew | Renews a lease, requesting to extend the lease.
*System* | [**PostSysLeasesRenewUrlLeaseId**](docs/System.md#postsysleasesrenewurlleaseid) | **POST** /sys/leases/renew/{url_lease_id} | Renews a lease, requesting to extend the lease.
*System* | [**PostSysLeasesRevoke**](docs/System.md#postsysleasesrevoke) | **POST** /sys/leases/revoke | Revokes a lease immediately.
*System* | [**PostSysLeasesRevokeForcePrefix**](docs/System.md#postsysleasesrevokeforceprefix) | **POST** /sys/leases/revoke-force/{prefix} | Revokes all secrets or tokens generated under a given prefix immediately
*System* | [**PostSysLeasesRevokePrefixPrefix**](docs/System.md#postsysleasesrevokeprefixprefix) | **POST** /sys/leases/revoke-prefix/{prefix} | Revokes all secrets (via a lease ID prefix) or tokens (via the tokens' path property) generated under a given prefix immediately.
*System* | [**PostSysLeasesRevokeUrlLeaseId**](docs/System.md#postsysleasesrevokeurlleaseid) | **POST** /sys/leases/revoke/{url_lease_id} | Revokes a lease immediately.
*System* | [**PostSysLeasesTidy**](docs/System.md#postsysleasestidy) | **POST** /sys/leases/tidy | This endpoint performs cleanup tasks that can be run if certain error conditions have occurred.
*System* | [**PostSysMfaValidate**](docs/System.md#postsysmfavalidate) | **POST** /sys/mfa/validate | Validates the login for the given MFA methods. Upon successful validation, it returns an auth response containing the client token
*System* | [**PostSysMountsPath**](docs/System.md#postsysmountspath) | **POST** /sys/mounts/{path} | Enable a new secrets engine at the given path.
*System* | [**PostSysMountsPathTune**](docs/System.md#postsysmountspathtune) | **POST** /sys/mounts/{path}/tune | Tune backend configuration parameters for this mount.
*System* | [**PostSysPluginsCatalogName**](docs/System.md#postsyspluginscatalogname) | **POST** /sys/plugins/catalog/{name} | Register a new plugin, or updates an existing one with the supplied name.
*System* | [**PostSysPluginsCatalogTypeName**](docs/System.md#postsyspluginscatalogtypename) | **POST** /sys/plugins/catalog/{type}/{name} | Register a new plugin, or updates an existing one with the supplied name.
*System* | [**PostSysPluginsReloadBackend**](docs/System.md#postsyspluginsreloadbackend) | **POST** /sys/plugins/reload/backend | Reload mounted plugin backends.
*System* | [**PostSysPoliciesAclName**](docs/System.md#postsyspoliciesaclname) | **POST** /sys/policies/acl/{name} | Add a new or update an existing ACL policy.
*System* | [**PostSysPoliciesPasswordName**](docs/System.md#postsyspoliciespasswordname) | **POST** /sys/policies/password/{name} | Add a new or update an existing password policy.
*System* | [**PostSysPolicyName**](docs/System.md#postsyspolicyname) | **POST** /sys/policy/{name} | Add a new or update an existing policy.
*System* | [**PostSysQuotasConfig**](docs/System.md#postsysquotasconfig) | **POST** /sys/quotas/config | 
*System* | [**PostSysQuotasRateLimitName**](docs/System.md#postsysquotasratelimitname) | **POST** /sys/quotas/rate-limit/{name} | 
*System* | [**PostSysRaw**](docs/System.md#postsysraw) | **POST** /sys/raw | Update the value of the key at the given path.
*System* | [**PostSysRawPath**](docs/System.md#postsysrawpath) | **POST** /sys/raw/{path} | Update the value of the key at the given path.
*System* | [**PostSysRekeyInit**](docs/System.md#postsysrekeyinit) | **POST** /sys/rekey/init | Initializes a new rekey attempt.
*System* | [**PostSysRekeyUpdate**](docs/System.md#postsysrekeyupdate) | **POST** /sys/rekey/update | Enter a single unseal key share to progress the rekey of the Vault.
*System* | [**PostSysRekeyVerify**](docs/System.md#postsysrekeyverify) | **POST** /sys/rekey/verify | Enter a single new key share to progress the rekey verification operation.
*System* | [**PostSysRemount**](docs/System.md#postsysremount) | **POST** /sys/remount | Initiate a mount migration
*System* | [**PostSysRenew**](docs/System.md#postsysrenew) | **POST** /sys/renew | Renews a lease, requesting to extend the lease.
*System* | [**PostSysRenewUrlLeaseId**](docs/System.md#postsysrenewurlleaseid) | **POST** /sys/renew/{url_lease_id} | Renews a lease, requesting to extend the lease.
*System* | [**PostSysRevoke**](docs/System.md#postsysrevoke) | **POST** /sys/revoke | Revokes a lease immediately.
*System* | [**PostSysRevokeForcePrefix**](docs/System.md#postsysrevokeforceprefix) | **POST** /sys/revoke-force/{prefix} | Revokes all secrets or tokens generated under a given prefix immediately
*System* | [**PostSysRevokePrefixPrefix**](docs/System.md#postsysrevokeprefixprefix) | **POST** /sys/revoke-prefix/{prefix} | Revokes all secrets (via a lease ID prefix) or tokens (via the tokens' path property) generated under a given prefix immediately.
*System* | [**PostSysRevokeUrlLeaseId**](docs/System.md#postsysrevokeurlleaseid) | **POST** /sys/revoke/{url_lease_id} | Revokes a lease immediately.
*System* | [**PostSysRotate**](docs/System.md#postsysrotate) | **POST** /sys/rotate | Rotates the backend encryption key used to persist data.
*System* | [**PostSysRotateConfig**](docs/System.md#postsysrotateconfig) | **POST** /sys/rotate/config | 
*System* | [**PostSysSeal**](docs/System.md#postsysseal) | **POST** /sys/seal | Seal the Vault.
*System* | [**PostSysStepDown**](docs/System.md#postsysstepdown) | **POST** /sys/step-down | Cause the node to give up active status.
*System* | [**PostSysToolsHash**](docs/System.md#postsystoolshash) | **POST** /sys/tools/hash | Generate a hash sum for input data
*System* | [**PostSysToolsHashUrlalgorithm**](docs/System.md#postsystoolshashurlalgorithm) | **POST** /sys/tools/hash/{urlalgorithm} | Generate a hash sum for input data
*System* | [**PostSysToolsRandom**](docs/System.md#postsystoolsrandom) | **POST** /sys/tools/random | Generate random bytes
*System* | [**PostSysToolsRandomSource**](docs/System.md#postsystoolsrandomsource) | **POST** /sys/tools/random/{source} | Generate random bytes
*System* | [**PostSysToolsRandomSourceUrlbytes**](docs/System.md#postsystoolsrandomsourceurlbytes) | **POST** /sys/tools/random/{source}/{urlbytes} | Generate random bytes
*System* | [**PostSysToolsRandomUrlbytes**](docs/System.md#postsystoolsrandomurlbytes) | **POST** /sys/tools/random/{urlbytes} | Generate random bytes
*System* | [**PostSysUnseal**](docs/System.md#postsysunseal) | **POST** /sys/unseal | Unseal the Vault.
*System* | [**PostSysWrappingLookup**](docs/System.md#postsyswrappinglookup) | **POST** /sys/wrapping/lookup | Look up wrapping properties for the given token.
*System* | [**PostSysWrappingRewrap**](docs/System.md#postsyswrappingrewrap) | **POST** /sys/wrapping/rewrap | Rotates a response-wrapped token.
*System* | [**PostSysWrappingUnwrap**](docs/System.md#postsyswrappingunwrap) | **POST** /sys/wrapping/unwrap | Unwraps a response-wrapped token.
*System* | [**PostSysWrappingWrap**](docs/System.md#postsyswrappingwrap) | **POST** /sys/wrapping/wrap | Response-wraps an arbitrary JSON object.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AdConfigRequest](docs/AdConfigRequest.md)
 - [Model.AdLibraryCheckInRequest](docs/AdLibraryCheckInRequest.md)
 - [Model.AdLibraryCheckOutRequest](docs/AdLibraryCheckOutRequest.md)
 - [Model.AdLibraryManageCheckInRequest](docs/AdLibraryManageCheckInRequest.md)
 - [Model.AdLibraryRequest](docs/AdLibraryRequest.md)
 - [Model.AdRolesRequest](docs/AdRolesRequest.md)
 - [Model.AlicloudConfigRequest](docs/AlicloudConfigRequest.md)
 - [Model.AlicloudLoginRequest](docs/AlicloudLoginRequest.md)
 - [Model.AlicloudRoleRequest](docs/AlicloudRoleRequest.md)
 - [Model.AppIdLoginRequest](docs/AppIdLoginRequest.md)
 - [Model.AppIdMapAppIdRequest](docs/AppIdMapAppIdRequest.md)
 - [Model.AppIdMapUserIdRequest](docs/AppIdMapUserIdRequest.md)
 - [Model.ApproleLoginRequest](docs/ApproleLoginRequest.md)
 - [Model.ApproleRoleBindSecretIdRequest](docs/ApproleRoleBindSecretIdRequest.md)
 - [Model.ApproleRoleBoundCidrListRequest](docs/ApproleRoleBoundCidrListRequest.md)
 - [Model.ApproleRoleCustomSecretIdRequest](docs/ApproleRoleCustomSecretIdRequest.md)
 - [Model.ApproleRolePeriodRequest](docs/ApproleRolePeriodRequest.md)
 - [Model.ApproleRolePoliciesRequest](docs/ApproleRolePoliciesRequest.md)
 - [Model.ApproleRoleRequest](docs/ApproleRoleRequest.md)
 - [Model.ApproleRoleRoleIdRequest](docs/ApproleRoleRoleIdRequest.md)
 - [Model.ApproleRoleSecretIdAccessorDestroyRequest](docs/ApproleRoleSecretIdAccessorDestroyRequest.md)
 - [Model.ApproleRoleSecretIdAccessorLookupRequest](docs/ApproleRoleSecretIdAccessorLookupRequest.md)
 - [Model.ApproleRoleSecretIdBoundCidrsRequest](docs/ApproleRoleSecretIdBoundCidrsRequest.md)
 - [Model.ApproleRoleSecretIdDestroyRequest](docs/ApproleRoleSecretIdDestroyRequest.md)
 - [Model.ApproleRoleSecretIdLookupRequest](docs/ApproleRoleSecretIdLookupRequest.md)
 - [Model.ApproleRoleSecretIdNumUsesRequest](docs/ApproleRoleSecretIdNumUsesRequest.md)
 - [Model.ApproleRoleSecretIdRequest](docs/ApproleRoleSecretIdRequest.md)
 - [Model.ApproleRoleSecretIdTtlRequest](docs/ApproleRoleSecretIdTtlRequest.md)
 - [Model.ApproleRoleTokenBoundCidrsRequest](docs/ApproleRoleTokenBoundCidrsRequest.md)
 - [Model.ApproleRoleTokenMaxTtlRequest](docs/ApproleRoleTokenMaxTtlRequest.md)
 - [Model.ApproleRoleTokenNumUsesRequest](docs/ApproleRoleTokenNumUsesRequest.md)
 - [Model.ApproleRoleTokenTtlRequest](docs/ApproleRoleTokenTtlRequest.md)
 - [Model.AwsConfigCertificateRequest](docs/AwsConfigCertificateRequest.md)
 - [Model.AwsConfigClientRequest](docs/AwsConfigClientRequest.md)
 - [Model.AwsConfigIdentityRequest](docs/AwsConfigIdentityRequest.md)
 - [Model.AwsConfigLeaseRequest](docs/AwsConfigLeaseRequest.md)
 - [Model.AwsConfigRootRequest](docs/AwsConfigRootRequest.md)
 - [Model.AwsConfigStsRequest](docs/AwsConfigStsRequest.md)
 - [Model.AwsConfigTidyIdentityAccesslistRequest](docs/AwsConfigTidyIdentityAccesslistRequest.md)
 - [Model.AwsConfigTidyIdentityWhitelistRequest](docs/AwsConfigTidyIdentityWhitelistRequest.md)
 - [Model.AwsConfigTidyRoletagBlacklistRequest](docs/AwsConfigTidyRoletagBlacklistRequest.md)
 - [Model.AwsConfigTidyRoletagDenylistRequest](docs/AwsConfigTidyRoletagDenylistRequest.md)
 - [Model.AwsCredsRequest](docs/AwsCredsRequest.md)
 - [Model.AwsLoginRequest](docs/AwsLoginRequest.md)
 - [Model.AwsRoleRequest](docs/AwsRoleRequest.md)
 - [Model.AwsRoleTagRequest](docs/AwsRoleTagRequest.md)
 - [Model.AwsRolesRequest](docs/AwsRolesRequest.md)
 - [Model.AwsStsRequest](docs/AwsStsRequest.md)
 - [Model.AwsTidyIdentityAccesslistRequest](docs/AwsTidyIdentityAccesslistRequest.md)
 - [Model.AwsTidyIdentityWhitelistRequest](docs/AwsTidyIdentityWhitelistRequest.md)
 - [Model.AwsTidyRoletagBlacklistRequest](docs/AwsTidyRoletagBlacklistRequest.md)
 - [Model.AwsTidyRoletagDenylistRequest](docs/AwsTidyRoletagDenylistRequest.md)
 - [Model.AzureConfigRequest](docs/AzureConfigRequest.md)
 - [Model.AzureLoginRequest](docs/AzureLoginRequest.md)
 - [Model.AzureRoleRequest](docs/AzureRoleRequest.md)
 - [Model.AzureRolesRequest](docs/AzureRolesRequest.md)
 - [Model.CentrifyConfigRequest](docs/CentrifyConfigRequest.md)
 - [Model.CentrifyLoginRequest](docs/CentrifyLoginRequest.md)
 - [Model.CertCertsRequest](docs/CertCertsRequest.md)
 - [Model.CertConfigRequest](docs/CertConfigRequest.md)
 - [Model.CertCrlsRequest](docs/CertCrlsRequest.md)
 - [Model.CertLoginRequest](docs/CertLoginRequest.md)
 - [Model.CfConfigRequest](docs/CfConfigRequest.md)
 - [Model.CfLoginRequest](docs/CfLoginRequest.md)
 - [Model.CfRolesRequest](docs/CfRolesRequest.md)
 - [Model.ConsulConfigAccessRequest](docs/ConsulConfigAccessRequest.md)
 - [Model.ConsulRolesRequest](docs/ConsulRolesRequest.md)
 - [Model.GcpConfigRequest](docs/GcpConfigRequest.md)
 - [Model.GcpKeyRequest](docs/GcpKeyRequest.md)
 - [Model.GcpLoginRequest](docs/GcpLoginRequest.md)
 - [Model.GcpRoleLabelsRequest](docs/GcpRoleLabelsRequest.md)
 - [Model.GcpRoleRequest](docs/GcpRoleRequest.md)
 - [Model.GcpRoleServiceAccountsRequest](docs/GcpRoleServiceAccountsRequest.md)
 - [Model.GcpRolesetKeyRequest](docs/GcpRolesetKeyRequest.md)
 - [Model.GcpRolesetRequest](docs/GcpRolesetRequest.md)
 - [Model.GcpStaticAccountKeyRequest](docs/GcpStaticAccountKeyRequest.md)
 - [Model.GcpStaticAccountRequest](docs/GcpStaticAccountRequest.md)
 - [Model.GcpkmsConfigRequest](docs/GcpkmsConfigRequest.md)
 - [Model.GcpkmsDecryptRequest](docs/GcpkmsDecryptRequest.md)
 - [Model.GcpkmsEncryptRequest](docs/GcpkmsEncryptRequest.md)
 - [Model.GcpkmsKeysConfigRequest](docs/GcpkmsKeysConfigRequest.md)
 - [Model.GcpkmsKeysRegisterRequest](docs/GcpkmsKeysRegisterRequest.md)
 - [Model.GcpkmsKeysRequest](docs/GcpkmsKeysRequest.md)
 - [Model.GcpkmsReencryptRequest](docs/GcpkmsReencryptRequest.md)
 - [Model.GcpkmsSignRequest](docs/GcpkmsSignRequest.md)
 - [Model.GcpkmsVerifyRequest](docs/GcpkmsVerifyRequest.md)
 - [Model.GithubConfigRequest](docs/GithubConfigRequest.md)
 - [Model.GithubLoginRequest](docs/GithubLoginRequest.md)
 - [Model.GithubMapTeamsRequest](docs/GithubMapTeamsRequest.md)
 - [Model.GithubMapUsersRequest](docs/GithubMapUsersRequest.md)
 - [Model.IdentityAliasIdRequest](docs/IdentityAliasIdRequest.md)
 - [Model.IdentityAliasRequest](docs/IdentityAliasRequest.md)
 - [Model.IdentityEntityAliasIdRequest](docs/IdentityEntityAliasIdRequest.md)
 - [Model.IdentityEntityAliasRequest](docs/IdentityEntityAliasRequest.md)
 - [Model.IdentityEntityBatchDeleteRequest](docs/IdentityEntityBatchDeleteRequest.md)
 - [Model.IdentityEntityIdRequest](docs/IdentityEntityIdRequest.md)
 - [Model.IdentityEntityMergeRequest](docs/IdentityEntityMergeRequest.md)
 - [Model.IdentityEntityNameRequest](docs/IdentityEntityNameRequest.md)
 - [Model.IdentityEntityRequest](docs/IdentityEntityRequest.md)
 - [Model.IdentityGroupAliasIdRequest](docs/IdentityGroupAliasIdRequest.md)
 - [Model.IdentityGroupAliasRequest](docs/IdentityGroupAliasRequest.md)
 - [Model.IdentityGroupIdRequest](docs/IdentityGroupIdRequest.md)
 - [Model.IdentityGroupNameRequest](docs/IdentityGroupNameRequest.md)
 - [Model.IdentityGroupRequest](docs/IdentityGroupRequest.md)
 - [Model.IdentityLookupEntityRequest](docs/IdentityLookupEntityRequest.md)
 - [Model.IdentityLookupGroupRequest](docs/IdentityLookupGroupRequest.md)
 - [Model.IdentityMfaLoginEnforcementRequest](docs/IdentityMfaLoginEnforcementRequest.md)
 - [Model.IdentityMfaMethodDuoRequest](docs/IdentityMfaMethodDuoRequest.md)
 - [Model.IdentityMfaMethodOktaRequest](docs/IdentityMfaMethodOktaRequest.md)
 - [Model.IdentityMfaMethodPingidRequest](docs/IdentityMfaMethodPingidRequest.md)
 - [Model.IdentityMfaMethodTotpAdminDestroyRequest](docs/IdentityMfaMethodTotpAdminDestroyRequest.md)
 - [Model.IdentityMfaMethodTotpAdminGenerateRequest](docs/IdentityMfaMethodTotpAdminGenerateRequest.md)
 - [Model.IdentityMfaMethodTotpGenerateRequest](docs/IdentityMfaMethodTotpGenerateRequest.md)
 - [Model.IdentityMfaMethodTotpRequest](docs/IdentityMfaMethodTotpRequest.md)
 - [Model.IdentityOidcAssignmentRequest](docs/IdentityOidcAssignmentRequest.md)
 - [Model.IdentityOidcClientRequest](docs/IdentityOidcClientRequest.md)
 - [Model.IdentityOidcConfigRequest](docs/IdentityOidcConfigRequest.md)
 - [Model.IdentityOidcIntrospectRequest](docs/IdentityOidcIntrospectRequest.md)
 - [Model.IdentityOidcKeyRequest](docs/IdentityOidcKeyRequest.md)
 - [Model.IdentityOidcKeyRotateRequest](docs/IdentityOidcKeyRotateRequest.md)
 - [Model.IdentityOidcProviderAuthorizeRequest](docs/IdentityOidcProviderAuthorizeRequest.md)
 - [Model.IdentityOidcProviderRequest](docs/IdentityOidcProviderRequest.md)
 - [Model.IdentityOidcProviderTokenRequest](docs/IdentityOidcProviderTokenRequest.md)
 - [Model.IdentityOidcRoleRequest](docs/IdentityOidcRoleRequest.md)
 - [Model.IdentityOidcScopeRequest](docs/IdentityOidcScopeRequest.md)
 - [Model.IdentityPersonaIdRequest](docs/IdentityPersonaIdRequest.md)
 - [Model.IdentityPersonaRequest](docs/IdentityPersonaRequest.md)
 - [Model.JwtConfigRequest](docs/JwtConfigRequest.md)
 - [Model.JwtLoginRequest](docs/JwtLoginRequest.md)
 - [Model.JwtOidcAuthUrlRequest](docs/JwtOidcAuthUrlRequest.md)
 - [Model.JwtOidcCallbackRequest](docs/JwtOidcCallbackRequest.md)
 - [Model.JwtRoleRequest](docs/JwtRoleRequest.md)
 - [Model.KerberosConfigLdapRequest](docs/KerberosConfigLdapRequest.md)
 - [Model.KerberosConfigRequest](docs/KerberosConfigRequest.md)
 - [Model.KerberosGroupsRequest](docs/KerberosGroupsRequest.md)
 - [Model.KerberosLoginRequest](docs/KerberosLoginRequest.md)
 - [Model.KubernetesConfigRequest](docs/KubernetesConfigRequest.md)
 - [Model.KubernetesCredsRequest](docs/KubernetesCredsRequest.md)
 - [Model.KubernetesLoginRequest](docs/KubernetesLoginRequest.md)
 - [Model.KubernetesRoleRequest](docs/KubernetesRoleRequest.md)
 - [Model.KubernetesRolesRequest](docs/KubernetesRolesRequest.md)
 - [Model.KvConfigRequest](docs/KvConfigRequest.md)
 - [Model.KvDataRequest](docs/KvDataRequest.md)
 - [Model.KvDeleteRequest](docs/KvDeleteRequest.md)
 - [Model.KvDestroyRequest](docs/KvDestroyRequest.md)
 - [Model.KvMetadataRequest](docs/KvMetadataRequest.md)
 - [Model.KvUndeleteRequest](docs/KvUndeleteRequest.md)
 - [Model.LdapConfigRequest](docs/LdapConfigRequest.md)
 - [Model.LdapGroupsRequest](docs/LdapGroupsRequest.md)
 - [Model.LdapLoginRequest](docs/LdapLoginRequest.md)
 - [Model.LdapUsersRequest](docs/LdapUsersRequest.md)
 - [Model.MongodbatlasConfigRequest](docs/MongodbatlasConfigRequest.md)
 - [Model.MongodbatlasRolesRequest](docs/MongodbatlasRolesRequest.md)
 - [Model.NomadConfigAccessRequest](docs/NomadConfigAccessRequest.md)
 - [Model.NomadConfigLeaseRequest](docs/NomadConfigLeaseRequest.md)
 - [Model.NomadRoleRequest](docs/NomadRoleRequest.md)
 - [Model.OciConfigRequest](docs/OciConfigRequest.md)
 - [Model.OciLoginRequest](docs/OciLoginRequest.md)
 - [Model.OciRoleRequest](docs/OciRoleRequest.md)
 - [Model.OidcConfigRequest](docs/OidcConfigRequest.md)
 - [Model.OidcLoginRequest](docs/OidcLoginRequest.md)
 - [Model.OidcOidcAuthUrlRequest](docs/OidcOidcAuthUrlRequest.md)
 - [Model.OidcOidcCallbackRequest](docs/OidcOidcCallbackRequest.md)
 - [Model.OidcRoleRequest](docs/OidcRoleRequest.md)
 - [Model.OktaConfigRequest](docs/OktaConfigRequest.md)
 - [Model.OktaGroupsRequest](docs/OktaGroupsRequest.md)
 - [Model.OktaLoginRequest](docs/OktaLoginRequest.md)
 - [Model.OktaUsersRequest](docs/OktaUsersRequest.md)
 - [Model.OpenldapConfigRequest](docs/OpenldapConfigRequest.md)
 - [Model.OpenldapRoleRequest](docs/OpenldapRoleRequest.md)
 - [Model.OpenldapStaticRoleRequest](docs/OpenldapStaticRoleRequest.md)
 - [Model.PkiBundleRequest](docs/PkiBundleRequest.md)
 - [Model.PkiCertRequest](docs/PkiCertRequest.md)
 - [Model.PkiConfigCaRequest](docs/PkiConfigCaRequest.md)
 - [Model.PkiConfigCrlRequest](docs/PkiConfigCrlRequest.md)
 - [Model.PkiConfigIssuersRequest](docs/PkiConfigIssuersRequest.md)
 - [Model.PkiConfigKeysRequest](docs/PkiConfigKeysRequest.md)
 - [Model.PkiConfigUrlsRequest](docs/PkiConfigUrlsRequest.md)
 - [Model.PkiDerPemRequest](docs/PkiDerPemRequest.md)
 - [Model.PkiIntermediateCrossSignRequest](docs/PkiIntermediateCrossSignRequest.md)
 - [Model.PkiIntermediateGenerateRequest](docs/PkiIntermediateGenerateRequest.md)
 - [Model.PkiIntermediateSetSignedRequest](docs/PkiIntermediateSetSignedRequest.md)
 - [Model.PkiInternalExportedRequest](docs/PkiInternalExportedRequest.md)
 - [Model.PkiIssueRequest](docs/PkiIssueRequest.md)
 - [Model.PkiIssuerIssueRequest](docs/PkiIssuerIssueRequest.md)
 - [Model.PkiIssuerSignIntermediateRequest](docs/PkiIssuerSignIntermediateRequest.md)
 - [Model.PkiIssuerSignRequest](docs/PkiIssuerSignRequest.md)
 - [Model.PkiIssuerSignSelfIssuedRequest](docs/PkiIssuerSignSelfIssuedRequest.md)
 - [Model.PkiIssuerSignVerbatimRequest](docs/PkiIssuerSignVerbatimRequest.md)
 - [Model.PkiIssuersGenerateIntermediateRequest](docs/PkiIssuersGenerateIntermediateRequest.md)
 - [Model.PkiIssuersGenerateRootRequest](docs/PkiIssuersGenerateRootRequest.md)
 - [Model.PkiJsonRequest](docs/PkiJsonRequest.md)
 - [Model.PkiKeyRequest](docs/PkiKeyRequest.md)
 - [Model.PkiKeysImportRequest](docs/PkiKeysImportRequest.md)
 - [Model.PkiKmsRequest](docs/PkiKmsRequest.md)
 - [Model.PkiRevokeRequest](docs/PkiRevokeRequest.md)
 - [Model.PkiRolesRequest](docs/PkiRolesRequest.md)
 - [Model.PkiRootGenerateRequest](docs/PkiRootGenerateRequest.md)
 - [Model.PkiRootReplaceRequest](docs/PkiRootReplaceRequest.md)
 - [Model.PkiRootRotateRequest](docs/PkiRootRotateRequest.md)
 - [Model.PkiRootSignIntermediateRequest](docs/PkiRootSignIntermediateRequest.md)
 - [Model.PkiRootSignSelfIssuedRequest](docs/PkiRootSignSelfIssuedRequest.md)
 - [Model.PkiSignRequest](docs/PkiSignRequest.md)
 - [Model.PkiSignVerbatimRequest](docs/PkiSignVerbatimRequest.md)
 - [Model.PkiTidyRequest](docs/PkiTidyRequest.md)
 - [Model.RabbitmqConfigConnectionRequest](docs/RabbitmqConfigConnectionRequest.md)
 - [Model.RabbitmqConfigLeaseRequest](docs/RabbitmqConfigLeaseRequest.md)
 - [Model.RabbitmqRolesRequest](docs/RabbitmqRolesRequest.md)
 - [Model.RadiusConfigRequest](docs/RadiusConfigRequest.md)
 - [Model.RadiusLoginRequest](docs/RadiusLoginRequest.md)
 - [Model.RadiusUsersRequest](docs/RadiusUsersRequest.md)
 - [Model.SshConfigCaRequest](docs/SshConfigCaRequest.md)
 - [Model.SshConfigZeroaddressRequest](docs/SshConfigZeroaddressRequest.md)
 - [Model.SshCredsRequest](docs/SshCredsRequest.md)
 - [Model.SshKeysRequest](docs/SshKeysRequest.md)
 - [Model.SshLookupRequest](docs/SshLookupRequest.md)
 - [Model.SshRolesRequest](docs/SshRolesRequest.md)
 - [Model.SshSignRequest](docs/SshSignRequest.md)
 - [Model.SshVerifyRequest](docs/SshVerifyRequest.md)
 - [Model.SystemAuditHashRequest](docs/SystemAuditHashRequest.md)
 - [Model.SystemAuditRequest](docs/SystemAuditRequest.md)
 - [Model.SystemAuthRequest](docs/SystemAuthRequest.md)
 - [Model.SystemAuthTuneRequest](docs/SystemAuthTuneRequest.md)
 - [Model.SystemCapabilitiesAccessorRequest](docs/SystemCapabilitiesAccessorRequest.md)
 - [Model.SystemCapabilitiesRequest](docs/SystemCapabilitiesRequest.md)
 - [Model.SystemCapabilitiesSelfRequest](docs/SystemCapabilitiesSelfRequest.md)
 - [Model.SystemConfigAuditingRequestHeadersRequest](docs/SystemConfigAuditingRequestHeadersRequest.md)
 - [Model.SystemConfigCorsRequest](docs/SystemConfigCorsRequest.md)
 - [Model.SystemConfigUiHeadersRequest](docs/SystemConfigUiHeadersRequest.md)
 - [Model.SystemGenerateRootAttemptRequest](docs/SystemGenerateRootAttemptRequest.md)
 - [Model.SystemGenerateRootRequest](docs/SystemGenerateRootRequest.md)
 - [Model.SystemGenerateRootUpdateRequest](docs/SystemGenerateRootUpdateRequest.md)
 - [Model.SystemInitRequest](docs/SystemInitRequest.md)
 - [Model.SystemInternalCountersConfigRequest](docs/SystemInternalCountersConfigRequest.md)
 - [Model.SystemInternalSpecsOpenapiRequest](docs/SystemInternalSpecsOpenapiRequest.md)
 - [Model.SystemLeasesLookupRequest](docs/SystemLeasesLookupRequest.md)
 - [Model.SystemLeasesRenewLeaseRequest](docs/SystemLeasesRenewLeaseRequest.md)
 - [Model.SystemLeasesRenewRequest](docs/SystemLeasesRenewRequest.md)
 - [Model.SystemLeasesRevokeLeaseRequest](docs/SystemLeasesRevokeLeaseRequest.md)
 - [Model.SystemLeasesRevokePrefixRequest](docs/SystemLeasesRevokePrefixRequest.md)
 - [Model.SystemLeasesRevokeRequest](docs/SystemLeasesRevokeRequest.md)
 - [Model.SystemMfaValidateRequest](docs/SystemMfaValidateRequest.md)
 - [Model.SystemMountsRequest](docs/SystemMountsRequest.md)
 - [Model.SystemMountsTuneRequest](docs/SystemMountsTuneRequest.md)
 - [Model.SystemPluginsCatalogRequest](docs/SystemPluginsCatalogRequest.md)
 - [Model.SystemPluginsReloadBackendRequest](docs/SystemPluginsReloadBackendRequest.md)
 - [Model.SystemPoliciesAclRequest](docs/SystemPoliciesAclRequest.md)
 - [Model.SystemPoliciesPasswordRequest](docs/SystemPoliciesPasswordRequest.md)
 - [Model.SystemPolicyRequest](docs/SystemPolicyRequest.md)
 - [Model.SystemQuotasConfigRequest](docs/SystemQuotasConfigRequest.md)
 - [Model.SystemQuotasRateLimitRequest](docs/SystemQuotasRateLimitRequest.md)
 - [Model.SystemRawRequest](docs/SystemRawRequest.md)
 - [Model.SystemRekeyInitRequest](docs/SystemRekeyInitRequest.md)
 - [Model.SystemRekeyUpdateRequest](docs/SystemRekeyUpdateRequest.md)
 - [Model.SystemRekeyVerifyRequest](docs/SystemRekeyVerifyRequest.md)
 - [Model.SystemRemountRequest](docs/SystemRemountRequest.md)
 - [Model.SystemRenewLeaseRequest](docs/SystemRenewLeaseRequest.md)
 - [Model.SystemRenewRequest](docs/SystemRenewRequest.md)
 - [Model.SystemRevokeLeaseRequest](docs/SystemRevokeLeaseRequest.md)
 - [Model.SystemRevokePrefixRequest](docs/SystemRevokePrefixRequest.md)
 - [Model.SystemRevokeRequest](docs/SystemRevokeRequest.md)
 - [Model.SystemRotateConfigRequest](docs/SystemRotateConfigRequest.md)
 - [Model.SystemToolsHashRequest](docs/SystemToolsHashRequest.md)
 - [Model.SystemToolsRandomRequest](docs/SystemToolsRandomRequest.md)
 - [Model.SystemUnsealRequest](docs/SystemUnsealRequest.md)
 - [Model.SystemWrappingLookupRequest](docs/SystemWrappingLookupRequest.md)
 - [Model.SystemWrappingRewrapRequest](docs/SystemWrappingRewrapRequest.md)
 - [Model.SystemWrappingUnwrapRequest](docs/SystemWrappingUnwrapRequest.md)
 - [Model.TerraformConfigRequest](docs/TerraformConfigRequest.md)
 - [Model.TerraformRoleRequest](docs/TerraformRoleRequest.md)
 - [Model.TokenLookupAccessorRequest](docs/TokenLookupAccessorRequest.md)
 - [Model.TokenLookupRequest](docs/TokenLookupRequest.md)
 - [Model.TokenLookupSelfRequest](docs/TokenLookupSelfRequest.md)
 - [Model.TokenRenewAccessorRequest](docs/TokenRenewAccessorRequest.md)
 - [Model.TokenRenewRequest](docs/TokenRenewRequest.md)
 - [Model.TokenRenewSelfRequest](docs/TokenRenewSelfRequest.md)
 - [Model.TokenRevokeAccessorRequest](docs/TokenRevokeAccessorRequest.md)
 - [Model.TokenRevokeOrphanRequest](docs/TokenRevokeOrphanRequest.md)
 - [Model.TokenRevokeRequest](docs/TokenRevokeRequest.md)
 - [Model.TokenRolesRequest](docs/TokenRolesRequest.md)
 - [Model.TotpCodeRequest](docs/TotpCodeRequest.md)
 - [Model.TotpKeysRequest](docs/TotpKeysRequest.md)
 - [Model.TransitCacheConfigRequest](docs/TransitCacheConfigRequest.md)
 - [Model.TransitDatakeyRequest](docs/TransitDatakeyRequest.md)
 - [Model.TransitDecryptRequest](docs/TransitDecryptRequest.md)
 - [Model.TransitEncryptRequest](docs/TransitEncryptRequest.md)
 - [Model.TransitHashRequest](docs/TransitHashRequest.md)
 - [Model.TransitHmacRequest](docs/TransitHmacRequest.md)
 - [Model.TransitKeysConfigRequest](docs/TransitKeysConfigRequest.md)
 - [Model.TransitKeysImportRequest](docs/TransitKeysImportRequest.md)
 - [Model.TransitKeysImportVersionRequest](docs/TransitKeysImportVersionRequest.md)
 - [Model.TransitKeysRequest](docs/TransitKeysRequest.md)
 - [Model.TransitKeysTrimRequest](docs/TransitKeysTrimRequest.md)
 - [Model.TransitRandomRequest](docs/TransitRandomRequest.md)
 - [Model.TransitRestoreRequest](docs/TransitRestoreRequest.md)
 - [Model.TransitRewrapRequest](docs/TransitRewrapRequest.md)
 - [Model.TransitSignRequest](docs/TransitSignRequest.md)
 - [Model.TransitVerifyRequest](docs/TransitVerifyRequest.md)
 - [Model.UserpassLoginRequest](docs/UserpassLoginRequest.md)
 - [Model.UserpassUsersPasswordRequest](docs/UserpassUsersPasswordRequest.md)
 - [Model.UserpassUsersPoliciesRequest](docs/UserpassUsersPoliciesRequest.md)
 - [Model.UserpassUsersRequest](docs/UserpassUsersRequest.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.

[hashicorp]:             https://www.hashicorp.com/
[vault]:                 https://www.vaultproject.io/
[openapi-spec]:          openapi.json
[openapi-generator]:	 https://openapi-generator.tech/docs/generators/csharp-netcore
[polly]:                 http://www.thepollyproject.org/
