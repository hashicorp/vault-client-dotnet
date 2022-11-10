# Vault - the C# library for the HashiCorp Vault API

## :warning: _Stability Warning: Under Development!_ :warning:

## Contents

1. [Overview](#overview)
1. [Installation](#installation)
1. [Getting Started](#getting-started)
1. [Examples](#exmples)
    - [Configuring a Vault Client](#configuring-a-vault-client)
    - [Reading secrets with `kv v2`](#secrets-engines)
    - [Logging in with `AppRole` auth method](#auth-methods)
1. [Documentation for API Endpoints](#documentation-for-api-endpoints)

## Overview

A C# client library [generated][openapi-generator] from `OpenAPI` 
[specification file][openapi-spec] to interact with [Hashicorp][hashicorp] [Vault][vault]. The library currently supports the following features:

- Custom HttpClientHandler
- Retry logic using [Polly][polly]
- Vault token support
- Vault namespace support
- Thread-safe operations

## Installation

The Nuget packages are hosted in an internal Nuget feed that can be found in [Artifactory][artifactory].
You can add this Nuget feed as a source with your Nuget with the following command

```shell-session
nuget sources add \
    -name Artifactory \ 
    -source https://artifactory.hashicorp.engineering/ui/repos/tree/General/vault-devex-nuget-local \
    -username "myusername" \
    -password "mypassword"
```

You can then install the package via the following command.

```shell-session
 nuget install Vault -source Artifactory -Version "PackageVersion"
```

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

### Local Development

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
`vault server -dev -dev-root-token-id="my-token"`);

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
            vaultClient.SetToken("my-token");

            try 
            {
                ApiResponse<Object> resp = vaultClient.System.GetSysMounts();

                // Write out response content
                Console.Writeline(resp.Content);
            }
            catch (VaultApiException e)
            {
                Console.WriteLine("Failed to read mounts with message {0}", e.Message);
            }
        }
    }
}
```
_**Note**_: the responses are currently generic objects that need
to be marshalled into an appropriate model. Structured responses are 
coming soon!

## Examples

### Configuring a Vault Client
The VaultClient requires you pass it a `Configuration` object. 

```csharp
Configuration config = new Configuration("http:127.0.0.1:8200");
VaultClient vaultClient = new VaultClient(config);
```

You can also add custom configuration including a custom `HttpClientHandler`.
This can be used to intercept requests and add custom logic before the base
`SendAsync` is called by the HttpClient. See [HttpClientHandler docs][http-client-handler-docs] for more details.

```csharp
// Create a custom HttpClientHandler
HttpClientHandler myClientHandler = new HttpClientHandler();

Configuration config = new Configuration("http://127.0.0.1:8200",
                                          myClientHandler);
```

The VaultClient also allows you to set a custom Timeout for all API calls.

```csharp
Configuration config = new Configuration(basePath: address, 
                                        httpClientHandler: httpClientHandler, 
                                        timeout: TimeSpan.FromSeconds(15));
```

### Setting Headers
The `SetToken` method can be used to set the `X-Vault-Token` header with the given token for subsequent requests.

```csharp
vaultClient.SetToken("my-token");
```

The `SetNamespace` can be used to set the default namespace header. 

```csharp
vaultClient.SetNamespace("n1");
vaultClient.ClearNamespace();
```

The Vault client also allows for adding custom headers that will be applied to every request.

```csharp
var myCustomHeaders = new Dictionary<string, string> 
{
    { "my-custom-header", "myHeaders"}    
};

vaultClient.AddCustomHeaders(myCustomHeaders);
vaultClient.ClearCustomHeaders();
```

### Reading a KV Secret
To call secrets endpoints, simply use the `VaultClient.Secrets` object, as shown below.

```csharp
// Read a secret
ApiResponse<Object> resp = await vaultClient.Secrets.GetKvPathAsync("path");

Console.Writeline(resp.Content);
```

_**Note**_: we are using the generated endpoints for reading and writing `kv v2` secrets.
These methods are hardcoded to use `/secret` as the mount path. In the future, we plan to 
introduce overriding the default mountpath in each call.

All calls have both an async and synchronous implementation. E.g.
```chsarp
ApiResponse<Object> respAsync = await vaultClient.Secrets.GetKvPathAsync("path");
ApiResponse<Object> respSync = vaultClient.Secrets.GetKvPath("path");
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*Auth* | [**DeleteApproleRoleRoleName**](docs/Auth.md#deleteapprolerolerolename) | **DELETE** /auth/{mount_path}/role/{role_name} | Register an role with the backend.
*Auth* | [**DeleteApproleRoleRoleNameBindSecretId**](docs/Auth.md#deleteapprolerolerolenamebindsecretid) | **DELETE** /auth/{mount_path}/role/{role_name}/bind-secret-id | Impose secret_id to be presented during login using this role.
*Auth* | [**DeleteApproleRoleRoleNameBoundCidrList**](docs/Auth.md#deleteapprolerolerolenameboundcidrlist) | **DELETE** /auth/{mount_path}/role/{role_name}/bound-cidr-list | Deprecated: Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
*Auth* | [**DeleteApproleRoleRoleNamePeriod**](docs/Auth.md#deleteapprolerolerolenameperiod) | **DELETE** /auth/{mount_path}/role/{role_name}/period | Updates the value of 'period' on the role
*Auth* | [**DeleteApproleRoleRoleNamePolicies**](docs/Auth.md#deleteapprolerolerolenamepolicies) | **DELETE** /auth/{mount_path}/role/{role_name}/policies | Policies of the role.
*Auth* | [**DeleteApproleRoleRoleNameSecretIdAccessorDestroy**](docs/Auth.md#deleteapprolerolerolenamesecretidaccessordestroy) | **DELETE** /auth/{mount_path}/role/{role_name}/secret-id-accessor/destroy | 
*Auth* | [**DeleteApproleRoleRoleNameSecretIdBoundCidrs**](docs/Auth.md#deleteapprolerolerolenamesecretidboundcidrs) | **DELETE** /auth/{mount_path}/role/{role_name}/secret-id-bound-cidrs | Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
*Auth* | [**DeleteApproleRoleRoleNameSecretIdDestroy**](docs/Auth.md#deleteapprolerolerolenamesecretiddestroy) | **DELETE** /auth/{mount_path}/role/{role_name}/secret-id/destroy | Invalidate an issued secret_id
*Auth* | [**DeleteApproleRoleRoleNameSecretIdNumUses**](docs/Auth.md#deleteapprolerolerolenamesecretidnumuses) | **DELETE** /auth/{mount_path}/role/{role_name}/secret-id-num-uses | Use limit of the SecretID generated against the role.
*Auth* | [**DeleteApproleRoleRoleNameSecretIdTtl**](docs/Auth.md#deleteapprolerolerolenamesecretidttl) | **DELETE** /auth/{mount_path}/role/{role_name}/secret-id-ttl | Duration in seconds of the SecretID generated against the role.
*Auth* | [**DeleteApproleRoleRoleNameTokenBoundCidrs**](docs/Auth.md#deleteapprolerolerolenametokenboundcidrs) | **DELETE** /auth/{mount_path}/role/{role_name}/token-bound-cidrs | Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token.
*Auth* | [**DeleteApproleRoleRoleNameTokenMaxTtl**](docs/Auth.md#deleteapprolerolerolenametokenmaxttl) | **DELETE** /auth/{mount_path}/role/{role_name}/token-max-ttl | Duration in seconds, the maximum lifetime of the tokens issued by using the SecretIDs that were generated against this role, after which the tokens are not allowed to be renewed.
*Auth* | [**DeleteApproleRoleRoleNameTokenNumUses**](docs/Auth.md#deleteapprolerolerolenametokennumuses) | **DELETE** /auth/{mount_path}/role/{role_name}/token-num-uses | Number of times issued tokens can be used
*Auth* | [**DeleteApproleRoleRoleNameTokenTtl**](docs/Auth.md#deleteapprolerolerolenametokenttl) | **DELETE** /auth/{mount_path}/role/{role_name}/token-ttl | Duration in seconds, the lifetime of the token issued by using the SecretID that is generated against this role, before which the token needs to be renewed.
*Auth* | [**DeleteAwsConfigCertificateCertName**](docs/Auth.md#deleteawsconfigcertificatecertname) | **DELETE** /auth/{mount_path}/config/certificate/{cert_name} | 
*Auth* | [**DeleteAwsConfigClient**](docs/Auth.md#deleteawsconfigclient) | **DELETE** /auth/{mount_path}/config/client | 
*Auth* | [**DeleteAwsConfigStsAccountId**](docs/Auth.md#deleteawsconfigstsaccountid) | **DELETE** /auth/{mount_path}/config/sts/{account_id} | 
*Auth* | [**DeleteAwsConfigTidyIdentityAccesslist**](docs/Auth.md#deleteawsconfigtidyidentityaccesslist) | **DELETE** /auth/{mount_path}/config/tidy/identity-accesslist | 
*Auth* | [**DeleteAwsConfigTidyIdentityWhitelist**](docs/Auth.md#deleteawsconfigtidyidentitywhitelist) | **DELETE** /auth/{mount_path}/config/tidy/identity-whitelist | 
*Auth* | [**DeleteAwsConfigTidyRoletagBlacklist**](docs/Auth.md#deleteawsconfigtidyroletagblacklist) | **DELETE** /auth/{mount_path}/config/tidy/roletag-blacklist | 
*Auth* | [**DeleteAwsConfigTidyRoletagDenylist**](docs/Auth.md#deleteawsconfigtidyroletagdenylist) | **DELETE** /auth/{mount_path}/config/tidy/roletag-denylist | 
*Auth* | [**DeleteAwsIdentityAccesslistInstanceId**](docs/Auth.md#deleteawsidentityaccesslistinstanceid) | **DELETE** /auth/{mount_path}/identity-accesslist/{instance_id} | 
*Auth* | [**DeleteAwsIdentityWhitelistInstanceId**](docs/Auth.md#deleteawsidentitywhitelistinstanceid) | **DELETE** /auth/{mount_path}/identity-whitelist/{instance_id} | 
*Auth* | [**DeleteAwsRoleRole**](docs/Auth.md#deleteawsrolerole) | **DELETE** /auth/{mount_path}/role/{role} | 
*Auth* | [**DeleteAwsRoletagBlacklistRoleTag**](docs/Auth.md#deleteawsroletagblacklistroletag) | **DELETE** /auth/{mount_path}/roletag-blacklist/{role_tag} | 
*Auth* | [**DeleteAwsRoletagDenylistRoleTag**](docs/Auth.md#deleteawsroletagdenylistroletag) | **DELETE** /auth/{mount_path}/roletag-denylist/{role_tag} | 
*Auth* | [**DeleteCertCertsName**](docs/Auth.md#deletecertcertsname) | **DELETE** /auth/{mount_path}/certs/{name} | Manage trusted certificates used for authentication.
*Auth* | [**DeleteCertCrlsName**](docs/Auth.md#deletecertcrlsname) | **DELETE** /auth/{mount_path}/crls/{name} | Manage Certificate Revocation Lists checked during authentication.
*Auth* | [**DeleteCfRolesRole**](docs/Auth.md#deletecfrolesrole) | **DELETE** /auth/{mount_path}/roles/{role} | 
*Auth* | [**DeleteGithubMapTeamsKey**](docs/Auth.md#deletegithubmapteamskey) | **DELETE** /auth/{mount_path}/map/teams/{key} | Read/write/delete a single teams mapping
*Auth* | [**DeleteGithubMapUsersKey**](docs/Auth.md#deletegithubmapuserskey) | **DELETE** /auth/{mount_path}/map/users/{key} | Read/write/delete a single users mapping
*Auth* | [**DeleteKerberosGroupsName**](docs/Auth.md#deletekerberosgroupsname) | **DELETE** /auth/{mount_path}/groups/{name} | 
*Auth* | [**DeleteOidcRoleName**](docs/Auth.md#deleteoidcrolename) | **DELETE** /auth/{mount_path}/role/{name} | Delete an existing role.
*Auth* | [**DeleteRadiusUsersName**](docs/Auth.md#deleteradiususersname) | **DELETE** /auth/{mount_path}/users/{name} | Manage users allowed to authenticate.
*Auth* | [**DeleteTokenRolesRoleName**](docs/Auth.md#deletetokenrolesrolename) | **DELETE** /auth/{mount_path}/roles/{role_name} | 
*Auth* | [**DeleteUserpassUsersUsername**](docs/Auth.md#deleteuserpassusersusername) | **DELETE** /auth/{mount_path}/users/{username} | Manage users allowed to authenticate.
*Auth* | [**ListApproleRoleRoleNameSecretId**](docs/Auth.md#listapprolerolerolenamesecretid) | **GET** /auth/{mount_path}/role/{role_name}/secret-id | Generate a SecretID against this role.
*Auth* | [**ListAwsConfigCertificates**](docs/Auth.md#listawsconfigcertificates) | **GET** /auth/{mount_path}/config/certificates | 
*Auth* | [**ListAwsConfigSts**](docs/Auth.md#listawsconfigsts) | **GET** /auth/{mount_path}/config/sts | 
*Auth* | [**ListAwsIdentityAccesslist**](docs/Auth.md#listawsidentityaccesslist) | **GET** /auth/{mount_path}/identity-accesslist | 
*Auth* | [**ListAwsIdentityWhitelist**](docs/Auth.md#listawsidentitywhitelist) | **GET** /auth/{mount_path}/identity-whitelist | 
*Auth* | [**ListAwsRoletagBlacklist**](docs/Auth.md#listawsroletagblacklist) | **GET** /auth/{mount_path}/roletag-blacklist | 
*Auth* | [**ListAwsRoletagDenylist**](docs/Auth.md#listawsroletagdenylist) | **GET** /auth/{mount_path}/roletag-denylist | 
*Auth* | [**ListCertCerts**](docs/Auth.md#listcertcerts) | **GET** /auth/{mount_path}/certs | Manage trusted certificates used for authentication.
*Auth* | [**ListGcpRoles**](docs/Auth.md#listgcproles) | **GET** /auth/{mount_path}/roles | Lists all the roles that are registered with Vault.
*Auth* | [**ListKerberosGroups**](docs/Auth.md#listkerberosgroups) | **GET** /auth/{mount_path}/groups | 
*Auth* | [**ListOidcRole**](docs/Auth.md#listoidcrole) | **GET** /auth/{mount_path}/role | Lists all the roles registered with the backend.
*Auth* | [**ListTokenAccessors**](docs/Auth.md#listtokenaccessors) | **GET** /auth/{mount_path}/accessors/ | List token accessors, which can then be be used to iterate and discover their properties or revoke them. Because this can be used to cause a denial of service, this endpoint requires 'sudo' capability in addition to 'list'.
*Auth* | [**ListUserpassUsers**](docs/Auth.md#listuserpassusers) | **GET** /auth/{mount_path}/users | Manage users allowed to authenticate.
*Auth* | [**ReadApproleRoleRoleName**](docs/Auth.md#readapprolerolerolename) | **GET** /auth/{mount_path}/role/{role_name} | Register an role with the backend.
*Auth* | [**ReadApproleRoleRoleNameBindSecretId**](docs/Auth.md#readapprolerolerolenamebindsecretid) | **GET** /auth/{mount_path}/role/{role_name}/bind-secret-id | Impose secret_id to be presented during login using this role.
*Auth* | [**ReadApproleRoleRoleNameBoundCidrList**](docs/Auth.md#readapprolerolerolenameboundcidrlist) | **GET** /auth/{mount_path}/role/{role_name}/bound-cidr-list | Deprecated: Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
*Auth* | [**ReadApproleRoleRoleNameLocalSecretIds**](docs/Auth.md#readapprolerolerolenamelocalsecretids) | **GET** /auth/{mount_path}/role/{role_name}/local-secret-ids | Enables cluster local secret IDs
*Auth* | [**ReadApproleRoleRoleNamePeriod**](docs/Auth.md#readapprolerolerolenameperiod) | **GET** /auth/{mount_path}/role/{role_name}/period | Updates the value of 'period' on the role
*Auth* | [**ReadApproleRoleRoleNamePolicies**](docs/Auth.md#readapprolerolerolenamepolicies) | **GET** /auth/{mount_path}/role/{role_name}/policies | Policies of the role.
*Auth* | [**ReadApproleRoleRoleNameRoleId**](docs/Auth.md#readapprolerolerolenameroleid) | **GET** /auth/{mount_path}/role/{role_name}/role-id | Returns the 'role_id' of the role.
*Auth* | [**ReadApproleRoleRoleNameSecretIdBoundCidrs**](docs/Auth.md#readapprolerolerolenamesecretidboundcidrs) | **GET** /auth/{mount_path}/role/{role_name}/secret-id-bound-cidrs | Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
*Auth* | [**ReadApproleRoleRoleNameSecretIdNumUses**](docs/Auth.md#readapprolerolerolenamesecretidnumuses) | **GET** /auth/{mount_path}/role/{role_name}/secret-id-num-uses | Use limit of the SecretID generated against the role.
*Auth* | [**ReadApproleRoleRoleNameSecretIdTtl**](docs/Auth.md#readapprolerolerolenamesecretidttl) | **GET** /auth/{mount_path}/role/{role_name}/secret-id-ttl | Duration in seconds of the SecretID generated against the role.
*Auth* | [**ReadApproleRoleRoleNameTokenBoundCidrs**](docs/Auth.md#readapprolerolerolenametokenboundcidrs) | **GET** /auth/{mount_path}/role/{role_name}/token-bound-cidrs | Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token.
*Auth* | [**ReadApproleRoleRoleNameTokenMaxTtl**](docs/Auth.md#readapprolerolerolenametokenmaxttl) | **GET** /auth/{mount_path}/role/{role_name}/token-max-ttl | Duration in seconds, the maximum lifetime of the tokens issued by using the SecretIDs that were generated against this role, after which the tokens are not allowed to be renewed.
*Auth* | [**ReadApproleRoleRoleNameTokenNumUses**](docs/Auth.md#readapprolerolerolenametokennumuses) | **GET** /auth/{mount_path}/role/{role_name}/token-num-uses | Number of times issued tokens can be used
*Auth* | [**ReadApproleRoleRoleNameTokenTtl**](docs/Auth.md#readapprolerolerolenametokenttl) | **GET** /auth/{mount_path}/role/{role_name}/token-ttl | Duration in seconds, the lifetime of the token issued by using the SecretID that is generated against this role, before which the token needs to be renewed.
*Auth* | [**ReadAwsConfigCertificateCertName**](docs/Auth.md#readawsconfigcertificatecertname) | **GET** /auth/{mount_path}/config/certificate/{cert_name} | 
*Auth* | [**ReadAwsConfigClient**](docs/Auth.md#readawsconfigclient) | **GET** /auth/{mount_path}/config/client | 
*Auth* | [**ReadAwsConfigIdentity**](docs/Auth.md#readawsconfigidentity) | **GET** /auth/{mount_path}/config/identity | 
*Auth* | [**ReadAwsConfigStsAccountId**](docs/Auth.md#readawsconfigstsaccountid) | **GET** /auth/{mount_path}/config/sts/{account_id} | 
*Auth* | [**ReadAwsConfigTidyIdentityAccesslist**](docs/Auth.md#readawsconfigtidyidentityaccesslist) | **GET** /auth/{mount_path}/config/tidy/identity-accesslist | 
*Auth* | [**ReadAwsConfigTidyIdentityWhitelist**](docs/Auth.md#readawsconfigtidyidentitywhitelist) | **GET** /auth/{mount_path}/config/tidy/identity-whitelist | 
*Auth* | [**ReadAwsConfigTidyRoletagBlacklist**](docs/Auth.md#readawsconfigtidyroletagblacklist) | **GET** /auth/{mount_path}/config/tidy/roletag-blacklist | 
*Auth* | [**ReadAwsConfigTidyRoletagDenylist**](docs/Auth.md#readawsconfigtidyroletagdenylist) | **GET** /auth/{mount_path}/config/tidy/roletag-denylist | 
*Auth* | [**ReadAwsIdentityAccesslistInstanceId**](docs/Auth.md#readawsidentityaccesslistinstanceid) | **GET** /auth/{mount_path}/identity-accesslist/{instance_id} | 
*Auth* | [**ReadAwsIdentityWhitelistInstanceId**](docs/Auth.md#readawsidentitywhitelistinstanceid) | **GET** /auth/{mount_path}/identity-whitelist/{instance_id} | 
*Auth* | [**ReadAwsRoleRole**](docs/Auth.md#readawsrolerole) | **GET** /auth/{mount_path}/role/{role} | 
*Auth* | [**ReadAwsRoletagBlacklistRoleTag**](docs/Auth.md#readawsroletagblacklistroletag) | **GET** /auth/{mount_path}/roletag-blacklist/{role_tag} | 
*Auth* | [**ReadAwsRoletagDenylistRoleTag**](docs/Auth.md#readawsroletagdenylistroletag) | **GET** /auth/{mount_path}/roletag-denylist/{role_tag} | 
*Auth* | [**ReadCertCertsName**](docs/Auth.md#readcertcertsname) | **GET** /auth/{mount_path}/certs/{name} | Manage trusted certificates used for authentication.
*Auth* | [**ReadCertCrlsName**](docs/Auth.md#readcertcrlsname) | **GET** /auth/{mount_path}/crls/{name} | Manage Certificate Revocation Lists checked during authentication.
*Auth* | [**ReadCfRolesRole**](docs/Auth.md#readcfrolesrole) | **GET** /auth/{mount_path}/roles/{role} | 
*Auth* | [**ReadGithubMapTeams**](docs/Auth.md#readgithubmapteams) | **GET** /auth/{mount_path}/map/teams | Read mappings for teams
*Auth* | [**ReadGithubMapTeamsKey**](docs/Auth.md#readgithubmapteamskey) | **GET** /auth/{mount_path}/map/teams/{key} | Read/write/delete a single teams mapping
*Auth* | [**ReadGithubMapUsers**](docs/Auth.md#readgithubmapusers) | **GET** /auth/{mount_path}/map/users | Read mappings for users
*Auth* | [**ReadGithubMapUsersKey**](docs/Auth.md#readgithubmapuserskey) | **GET** /auth/{mount_path}/map/users/{key} | Read/write/delete a single users mapping
*Auth* | [**ReadKerberosConfigLdap**](docs/Auth.md#readkerberosconfigldap) | **GET** /auth/{mount_path}/config/ldap | 
*Auth* | [**ReadKerberosGroupsName**](docs/Auth.md#readkerberosgroupsname) | **GET** /auth/{mount_path}/groups/{name} | 
*Auth* | [**ReadOidcConfig**](docs/Auth.md#readoidcconfig) | **GET** /auth/{mount_path}/config | Read the current JWT authentication backend configuration.
*Auth* | [**ReadOidcOidcCallback**](docs/Auth.md#readoidcoidccallback) | **GET** /auth/{mount_path}/oidc/callback | Callback endpoint to complete an OIDC login.
*Auth* | [**ReadOidcRoleName**](docs/Auth.md#readoidcrolename) | **GET** /auth/{mount_path}/role/{name} | Read an existing role.
*Auth* | [**ReadOktaVerifyNonce**](docs/Auth.md#readoktaverifynonce) | **GET** /auth/{mount_path}/verify/{nonce} | 
*Auth* | [**ReadRadiusUsersName**](docs/Auth.md#readradiususersname) | **GET** /auth/{mount_path}/users/{name} | Manage users allowed to authenticate.
*Auth* | [**ReadTokenLookup**](docs/Auth.md#readtokenlookup) | **GET** /auth/{mount_path}/lookup | This endpoint will lookup a token and its properties.
*Auth* | [**ReadTokenLookupSelf**](docs/Auth.md#readtokenlookupself) | **GET** /auth/{mount_path}/lookup-self | This endpoint will lookup a token and its properties.
*Auth* | [**ReadTokenRolesRoleName**](docs/Auth.md#readtokenrolesrolename) | **GET** /auth/{mount_path}/roles/{role_name} | 
*Auth* | [**ReadUserpassUsersUsername**](docs/Auth.md#readuserpassusersusername) | **GET** /auth/{mount_path}/users/{username} | Manage users allowed to authenticate.
*Auth* | [**UpdateApproleRoleRoleName**](docs/Auth.md#updateapprolerolerolename) | **POST** /auth/{mount_path}/role/{role_name} | Register an role with the backend.
*Auth* | [**UpdateApproleRoleRoleNameBindSecretId**](docs/Auth.md#updateapprolerolerolenamebindsecretid) | **POST** /auth/{mount_path}/role/{role_name}/bind-secret-id | Impose secret_id to be presented during login using this role.
*Auth* | [**UpdateApproleRoleRoleNameBoundCidrList**](docs/Auth.md#updateapprolerolerolenameboundcidrlist) | **POST** /auth/{mount_path}/role/{role_name}/bound-cidr-list | Deprecated: Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
*Auth* | [**UpdateApproleRoleRoleNameCustomSecretId**](docs/Auth.md#updateapprolerolerolenamecustomsecretid) | **POST** /auth/{mount_path}/role/{role_name}/custom-secret-id | Assign a SecretID of choice against the role.
*Auth* | [**UpdateApproleRoleRoleNamePeriod**](docs/Auth.md#updateapprolerolerolenameperiod) | **POST** /auth/{mount_path}/role/{role_name}/period | Updates the value of 'period' on the role
*Auth* | [**UpdateApproleRoleRoleNamePolicies**](docs/Auth.md#updateapprolerolerolenamepolicies) | **POST** /auth/{mount_path}/role/{role_name}/policies | Policies of the role.
*Auth* | [**UpdateApproleRoleRoleNameRoleId**](docs/Auth.md#updateapprolerolerolenameroleid) | **POST** /auth/{mount_path}/role/{role_name}/role-id | Returns the 'role_id' of the role.
*Auth* | [**UpdateApproleRoleRoleNameSecretId**](docs/Auth.md#updateapprolerolerolenamesecretid) | **POST** /auth/{mount_path}/role/{role_name}/secret-id | Generate a SecretID against this role.
*Auth* | [**UpdateApproleRoleRoleNameSecretIdAccessorDestroy**](docs/Auth.md#updateapprolerolerolenamesecretidaccessordestroy) | **POST** /auth/{mount_path}/role/{role_name}/secret-id-accessor/destroy | 
*Auth* | [**UpdateApproleRoleRoleNameSecretIdAccessorLookup**](docs/Auth.md#updateapprolerolerolenamesecretidaccessorlookup) | **POST** /auth/{mount_path}/role/{role_name}/secret-id-accessor/lookup | 
*Auth* | [**UpdateApproleRoleRoleNameSecretIdBoundCidrs**](docs/Auth.md#updateapprolerolerolenamesecretidboundcidrs) | **POST** /auth/{mount_path}/role/{role_name}/secret-id-bound-cidrs | Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
*Auth* | [**UpdateApproleRoleRoleNameSecretIdDestroy**](docs/Auth.md#updateapprolerolerolenamesecretiddestroy) | **POST** /auth/{mount_path}/role/{role_name}/secret-id/destroy | Invalidate an issued secret_id
*Auth* | [**UpdateApproleRoleRoleNameSecretIdLookup**](docs/Auth.md#updateapprolerolerolenamesecretidlookup) | **POST** /auth/{mount_path}/role/{role_name}/secret-id/lookup | Read the properties of an issued secret_id
*Auth* | [**UpdateApproleRoleRoleNameSecretIdNumUses**](docs/Auth.md#updateapprolerolerolenamesecretidnumuses) | **POST** /auth/{mount_path}/role/{role_name}/secret-id-num-uses | Use limit of the SecretID generated against the role.
*Auth* | [**UpdateApproleRoleRoleNameSecretIdTtl**](docs/Auth.md#updateapprolerolerolenamesecretidttl) | **POST** /auth/{mount_path}/role/{role_name}/secret-id-ttl | Duration in seconds of the SecretID generated against the role.
*Auth* | [**UpdateApproleRoleRoleNameTokenBoundCidrs**](docs/Auth.md#updateapprolerolerolenametokenboundcidrs) | **POST** /auth/{mount_path}/role/{role_name}/token-bound-cidrs | Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token.
*Auth* | [**UpdateApproleRoleRoleNameTokenMaxTtl**](docs/Auth.md#updateapprolerolerolenametokenmaxttl) | **POST** /auth/{mount_path}/role/{role_name}/token-max-ttl | Duration in seconds, the maximum lifetime of the tokens issued by using the SecretIDs that were generated against this role, after which the tokens are not allowed to be renewed.
*Auth* | [**UpdateApproleRoleRoleNameTokenNumUses**](docs/Auth.md#updateapprolerolerolenametokennumuses) | **POST** /auth/{mount_path}/role/{role_name}/token-num-uses | Number of times issued tokens can be used
*Auth* | [**UpdateApproleRoleRoleNameTokenTtl**](docs/Auth.md#updateapprolerolerolenametokenttl) | **POST** /auth/{mount_path}/role/{role_name}/token-ttl | Duration in seconds, the lifetime of the token issued by using the SecretID that is generated against this role, before which the token needs to be renewed.
*Auth* | [**UpdateApproleTidySecretId**](docs/Auth.md#updateapproletidysecretid) | **POST** /auth/{mount_path}/tidy/secret-id | Trigger the clean-up of expired SecretID entries.
*Auth* | [**UpdateAwsConfigCertificateCertName**](docs/Auth.md#updateawsconfigcertificatecertname) | **POST** /auth/{mount_path}/config/certificate/{cert_name} | 
*Auth* | [**UpdateAwsConfigClient**](docs/Auth.md#updateawsconfigclient) | **POST** /auth/{mount_path}/config/client | 
*Auth* | [**UpdateAwsConfigIdentity**](docs/Auth.md#updateawsconfigidentity) | **POST** /auth/{mount_path}/config/identity | 
*Auth* | [**UpdateAwsConfigRotateRoot**](docs/Auth.md#updateawsconfigrotateroot) | **POST** /auth/{mount_path}/config/rotate-root | 
*Auth* | [**UpdateAwsConfigStsAccountId**](docs/Auth.md#updateawsconfigstsaccountid) | **POST** /auth/{mount_path}/config/sts/{account_id} | 
*Auth* | [**UpdateAwsConfigTidyIdentityAccesslist**](docs/Auth.md#updateawsconfigtidyidentityaccesslist) | **POST** /auth/{mount_path}/config/tidy/identity-accesslist | 
*Auth* | [**UpdateAwsConfigTidyIdentityWhitelist**](docs/Auth.md#updateawsconfigtidyidentitywhitelist) | **POST** /auth/{mount_path}/config/tidy/identity-whitelist | 
*Auth* | [**UpdateAwsConfigTidyRoletagBlacklist**](docs/Auth.md#updateawsconfigtidyroletagblacklist) | **POST** /auth/{mount_path}/config/tidy/roletag-blacklist | 
*Auth* | [**UpdateAwsConfigTidyRoletagDenylist**](docs/Auth.md#updateawsconfigtidyroletagdenylist) | **POST** /auth/{mount_path}/config/tidy/roletag-denylist | 
*Auth* | [**UpdateAwsRoleRole**](docs/Auth.md#updateawsrolerole) | **POST** /auth/{mount_path}/role/{role} | 
*Auth* | [**UpdateAwsRoleRoleTag**](docs/Auth.md#updateawsroleroletag) | **POST** /auth/{mount_path}/role/{role}/tag | 
*Auth* | [**UpdateAwsRoletagBlacklistRoleTag**](docs/Auth.md#updateawsroletagblacklistroletag) | **POST** /auth/{mount_path}/roletag-blacklist/{role_tag} | 
*Auth* | [**UpdateAwsRoletagDenylistRoleTag**](docs/Auth.md#updateawsroletagdenylistroletag) | **POST** /auth/{mount_path}/roletag-denylist/{role_tag} | 
*Auth* | [**UpdateAwsTidyIdentityAccesslist**](docs/Auth.md#updateawstidyidentityaccesslist) | **POST** /auth/{mount_path}/tidy/identity-accesslist | 
*Auth* | [**UpdateAwsTidyIdentityWhitelist**](docs/Auth.md#updateawstidyidentitywhitelist) | **POST** /auth/{mount_path}/tidy/identity-whitelist | 
*Auth* | [**UpdateAwsTidyRoletagBlacklist**](docs/Auth.md#updateawstidyroletagblacklist) | **POST** /auth/{mount_path}/tidy/roletag-blacklist | 
*Auth* | [**UpdateAwsTidyRoletagDenylist**](docs/Auth.md#updateawstidyroletagdenylist) | **POST** /auth/{mount_path}/tidy/roletag-denylist | 
*Auth* | [**UpdateCertCertsName**](docs/Auth.md#updatecertcertsname) | **POST** /auth/{mount_path}/certs/{name} | Manage trusted certificates used for authentication.
*Auth* | [**UpdateCertCrlsName**](docs/Auth.md#updatecertcrlsname) | **POST** /auth/{mount_path}/crls/{name} | Manage Certificate Revocation Lists checked during authentication.
*Auth* | [**UpdateCfRolesRole**](docs/Auth.md#updatecfrolesrole) | **POST** /auth/{mount_path}/roles/{role} | 
*Auth* | [**UpdateGcpRoleNameLabels**](docs/Auth.md#updategcprolenamelabels) | **POST** /auth/{mount_path}/role/{name}/labels | Add or remove labels for an existing 'gce' role
*Auth* | [**UpdateGcpRoleNameServiceAccounts**](docs/Auth.md#updategcprolenameserviceaccounts) | **POST** /auth/{mount_path}/role/{name}/service-accounts | Add or remove service accounts for an existing `iam` role
*Auth* | [**UpdateGithubMapTeamsKey**](docs/Auth.md#updategithubmapteamskey) | **POST** /auth/{mount_path}/map/teams/{key} | Read/write/delete a single teams mapping
*Auth* | [**UpdateGithubMapUsersKey**](docs/Auth.md#updategithubmapuserskey) | **POST** /auth/{mount_path}/map/users/{key} | Read/write/delete a single users mapping
*Auth* | [**UpdateKerberosConfigLdap**](docs/Auth.md#updatekerberosconfigldap) | **POST** /auth/{mount_path}/config/ldap | 
*Auth* | [**UpdateKerberosGroupsName**](docs/Auth.md#updatekerberosgroupsname) | **POST** /auth/{mount_path}/groups/{name} | 
*Auth* | [**UpdateOciLoginRole**](docs/Auth.md#updateociloginrole) | **POST** /auth/{mount_path}/login/{role} | Authenticates to Vault using OCI credentials
*Auth* | [**UpdateOidcConfig**](docs/Auth.md#updateoidcconfig) | **POST** /auth/{mount_path}/config | Configure the JWT authentication backend.
*Auth* | [**UpdateOidcLogin**](docs/Auth.md#updateoidclogin) | **POST** /auth/{mount_path}/login | Authenticates to Vault using a JWT (or OIDC) token.
*Auth* | [**UpdateOidcOidcAuthUrl**](docs/Auth.md#updateoidcoidcauthurl) | **POST** /auth/{mount_path}/oidc/auth_url | Request an authorization URL to start an OIDC login flow.
*Auth* | [**UpdateOidcOidcCallback**](docs/Auth.md#updateoidcoidccallback) | **POST** /auth/{mount_path}/oidc/callback | Callback endpoint to handle form_posts.
*Auth* | [**UpdateOidcRoleName**](docs/Auth.md#updateoidcrolename) | **POST** /auth/{mount_path}/role/{name} | Register an role with the backend.
*Auth* | [**UpdateRadiusLoginUrlusername**](docs/Auth.md#updateradiusloginurlusername) | **POST** /auth/{mount_path}/login/{urlusername} | Log in with a username and password.
*Auth* | [**UpdateRadiusUsersName**](docs/Auth.md#updateradiususersname) | **POST** /auth/{mount_path}/users/{name} | Manage users allowed to authenticate.
*Auth* | [**UpdateTokenCreate**](docs/Auth.md#updatetokencreate) | **POST** /auth/{mount_path}/create | The token create path is used to create new tokens.
*Auth* | [**UpdateTokenCreateOrphan**](docs/Auth.md#updatetokencreateorphan) | **POST** /auth/{mount_path}/create-orphan | The token create path is used to create new orphan tokens.
*Auth* | [**UpdateTokenCreateRoleName**](docs/Auth.md#updatetokencreaterolename) | **POST** /auth/{mount_path}/create/{role_name} | This token create path is used to create new tokens adhering to the given role.
*Auth* | [**UpdateTokenLookup**](docs/Auth.md#updatetokenlookup) | **POST** /auth/{mount_path}/lookup | This endpoint will lookup a token and its properties.
*Auth* | [**UpdateTokenLookupAccessor**](docs/Auth.md#updatetokenlookupaccessor) | **POST** /auth/{mount_path}/lookup-accessor | This endpoint will lookup a token associated with the given accessor and its properties. Response will not contain the token ID.
*Auth* | [**UpdateTokenLookupSelf**](docs/Auth.md#updatetokenlookupself) | **POST** /auth/{mount_path}/lookup-self | This endpoint will lookup a token and its properties.
*Auth* | [**UpdateTokenRenew**](docs/Auth.md#updatetokenrenew) | **POST** /auth/{mount_path}/renew | This endpoint will renew the given token and prevent expiration.
*Auth* | [**UpdateTokenRenewAccessor**](docs/Auth.md#updatetokenrenewaccessor) | **POST** /auth/{mount_path}/renew-accessor | This endpoint will renew a token associated with the given accessor and its properties. Response will not contain the token ID.
*Auth* | [**UpdateTokenRenewSelf**](docs/Auth.md#updatetokenrenewself) | **POST** /auth/{mount_path}/renew-self | This endpoint will renew the token used to call it and prevent expiration.
*Auth* | [**UpdateTokenRevoke**](docs/Auth.md#updatetokenrevoke) | **POST** /auth/{mount_path}/revoke | This endpoint will delete the given token and all of its child tokens.
*Auth* | [**UpdateTokenRevokeAccessor**](docs/Auth.md#updatetokenrevokeaccessor) | **POST** /auth/{mount_path}/revoke-accessor | This endpoint will delete the token associated with the accessor and all of its child tokens.
*Auth* | [**UpdateTokenRevokeOrphan**](docs/Auth.md#updatetokenrevokeorphan) | **POST** /auth/{mount_path}/revoke-orphan | This endpoint will delete the token and orphan its child tokens.
*Auth* | [**UpdateTokenRevokeSelf**](docs/Auth.md#updatetokenrevokeself) | **POST** /auth/{mount_path}/revoke-self | This endpoint will delete the token used to call it and all of its child tokens.
*Auth* | [**UpdateTokenRolesRoleName**](docs/Auth.md#updatetokenrolesrolename) | **POST** /auth/{mount_path}/roles/{role_name} | 
*Auth* | [**UpdateTokenTidy**](docs/Auth.md#updatetokentidy) | **POST** /auth/{mount_path}/tidy | This endpoint performs cleanup tasks that can be run if certain error conditions have occurred.
*Auth* | [**UpdateUserpassLoginUsername**](docs/Auth.md#updateuserpassloginusername) | **POST** /auth/{mount_path}/login/{username} | Log in with a username and password.
*Auth* | [**UpdateUserpassUsersUsername**](docs/Auth.md#updateuserpassusersusername) | **POST** /auth/{mount_path}/users/{username} | Manage users allowed to authenticate.
*Auth* | [**UpdateUserpassUsersUsernamePassword**](docs/Auth.md#updateuserpassusersusernamepassword) | **POST** /auth/{mount_path}/users/{username}/password | Reset user's password.
*Auth* | [**UpdateUserpassUsersUsernamePolicies**](docs/Auth.md#updateuserpassusersusernamepolicies) | **POST** /auth/{mount_path}/users/{username}/policies | Update the policies associated with the username.
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
*Identity* | [**ListIdentityAliasId**](docs/Identity.md#listidentityaliasid) | **GET** /identity/alias/id | List all the alias IDs.
*Identity* | [**ListIdentityEntityAliasId**](docs/Identity.md#listidentityentityaliasid) | **GET** /identity/entity-alias/id | List all the alias IDs.
*Identity* | [**ListIdentityEntityId**](docs/Identity.md#listidentityentityid) | **GET** /identity/entity/id | List all the entity IDs
*Identity* | [**ListIdentityEntityName**](docs/Identity.md#listidentityentityname) | **GET** /identity/entity/name | List all the entity names
*Identity* | [**ListIdentityGroupAliasId**](docs/Identity.md#listidentitygroupaliasid) | **GET** /identity/group-alias/id | List all the group alias IDs.
*Identity* | [**ListIdentityGroupId**](docs/Identity.md#listidentitygroupid) | **GET** /identity/group/id | List all the group IDs.
*Identity* | [**ListIdentityGroupName**](docs/Identity.md#listidentitygroupname) | **GET** /identity/group/name | 
*Identity* | [**ListIdentityMfaLoginEnforcement**](docs/Identity.md#listidentitymfaloginenforcement) | **GET** /identity/mfa/login-enforcement | List login enforcements
*Identity* | [**ListIdentityMfaMethod**](docs/Identity.md#listidentitymfamethod) | **GET** /identity/mfa/method | List MFA method configurations for all MFA methods
*Identity* | [**ListIdentityMfaMethodDuo**](docs/Identity.md#listidentitymfamethodduo) | **GET** /identity/mfa/method/duo | List MFA method configurations for the given MFA method
*Identity* | [**ListIdentityMfaMethodOkta**](docs/Identity.md#listidentitymfamethodokta) | **GET** /identity/mfa/method/okta | List MFA method configurations for the given MFA method
*Identity* | [**ListIdentityMfaMethodPingid**](docs/Identity.md#listidentitymfamethodpingid) | **GET** /identity/mfa/method/pingid | List MFA method configurations for the given MFA method
*Identity* | [**ListIdentityMfaMethodTotp**](docs/Identity.md#listidentitymfamethodtotp) | **GET** /identity/mfa/method/totp | List MFA method configurations for the given MFA method
*Identity* | [**ListIdentityOidcAssignment**](docs/Identity.md#listidentityoidcassignment) | **GET** /identity/oidc/assignment | 
*Identity* | [**ListIdentityOidcClient**](docs/Identity.md#listidentityoidcclient) | **GET** /identity/oidc/client | 
*Identity* | [**ListIdentityOidcKey**](docs/Identity.md#listidentityoidckey) | **GET** /identity/oidc/key | List OIDC keys
*Identity* | [**ListIdentityOidcProvider**](docs/Identity.md#listidentityoidcprovider) | **GET** /identity/oidc/provider | 
*Identity* | [**ListIdentityOidcRole**](docs/Identity.md#listidentityoidcrole) | **GET** /identity/oidc/role | List configured OIDC roles
*Identity* | [**ListIdentityOidcScope**](docs/Identity.md#listidentityoidcscope) | **GET** /identity/oidc/scope | 
*Identity* | [**ListIdentityPersonaId**](docs/Identity.md#listidentitypersonaid) | **GET** /identity/persona/id | List all the alias IDs.
*Identity* | [**ReadIdentityAliasIdId**](docs/Identity.md#readidentityaliasidid) | **GET** /identity/alias/id/{id} | Update, read or delete an alias ID.
*Identity* | [**ReadIdentityEntityAliasIdId**](docs/Identity.md#readidentityentityaliasidid) | **GET** /identity/entity-alias/id/{id} | Update, read or delete an alias ID.
*Identity* | [**ReadIdentityEntityIdId**](docs/Identity.md#readidentityentityidid) | **GET** /identity/entity/id/{id} | Update, read or delete an entity using entity ID
*Identity* | [**ReadIdentityEntityNameName**](docs/Identity.md#readidentityentitynamename) | **GET** /identity/entity/name/{name} | Update, read or delete an entity using entity name
*Identity* | [**ReadIdentityGroupAliasIdId**](docs/Identity.md#readidentitygroupaliasidid) | **GET** /identity/group-alias/id/{id} | 
*Identity* | [**ReadIdentityGroupIdId**](docs/Identity.md#readidentitygroupidid) | **GET** /identity/group/id/{id} | Update or delete an existing group using its ID.
*Identity* | [**ReadIdentityGroupNameName**](docs/Identity.md#readidentitygroupnamename) | **GET** /identity/group/name/{name} | 
*Identity* | [**ReadIdentityMfaLoginEnforcementName**](docs/Identity.md#readidentitymfaloginenforcementname) | **GET** /identity/mfa/login-enforcement/{name} | Read the current login enforcement
*Identity* | [**ReadIdentityMfaMethodDuoMethodId**](docs/Identity.md#readidentitymfamethodduomethodid) | **GET** /identity/mfa/method/duo/{method_id} | Read the current configuration for the given MFA method
*Identity* | [**ReadIdentityMfaMethodMethodId**](docs/Identity.md#readidentitymfamethodmethodid) | **GET** /identity/mfa/method/{method_id} | Read the current configuration for the given ID regardless of the MFA method type
*Identity* | [**ReadIdentityMfaMethodOktaMethodId**](docs/Identity.md#readidentitymfamethodoktamethodid) | **GET** /identity/mfa/method/okta/{method_id} | Read the current configuration for the given MFA method
*Identity* | [**ReadIdentityMfaMethodPingidMethodId**](docs/Identity.md#readidentitymfamethodpingidmethodid) | **GET** /identity/mfa/method/pingid/{method_id} | Read the current configuration for the given MFA method
*Identity* | [**ReadIdentityMfaMethodTotpMethodId**](docs/Identity.md#readidentitymfamethodtotpmethodid) | **GET** /identity/mfa/method/totp/{method_id} | Read the current configuration for the given MFA method
*Identity* | [**ReadIdentityOidcAssignmentName**](docs/Identity.md#readidentityoidcassignmentname) | **GET** /identity/oidc/assignment/{name} | 
*Identity* | [**ReadIdentityOidcClientName**](docs/Identity.md#readidentityoidcclientname) | **GET** /identity/oidc/client/{name} | 
*Identity* | [**ReadIdentityOidcConfig**](docs/Identity.md#readidentityoidcconfig) | **GET** /identity/oidc/config | OIDC configuration
*Identity* | [**ReadIdentityOidcKeyName**](docs/Identity.md#readidentityoidckeyname) | **GET** /identity/oidc/key/{name} | CRUD operations for OIDC keys.
*Identity* | [**ReadIdentityOidcProviderName**](docs/Identity.md#readidentityoidcprovidername) | **GET** /identity/oidc/provider/{name} | 
*Identity* | [**ReadIdentityOidcProviderNameAuthorize**](docs/Identity.md#readidentityoidcprovidernameauthorize) | **GET** /identity/oidc/provider/{name}/authorize | 
*Identity* | [**ReadIdentityOidcProviderNameUserinfo**](docs/Identity.md#readidentityoidcprovidernameuserinfo) | **GET** /identity/oidc/provider/{name}/userinfo | 
*Identity* | [**ReadIdentityOidcProviderNameWellKnownKeys**](docs/Identity.md#readidentityoidcprovidernamewellknownkeys) | **GET** /identity/oidc/provider/{name}/.well-known/keys | 
*Identity* | [**ReadIdentityOidcProviderNameWellKnownOpenidConfiguration**](docs/Identity.md#readidentityoidcprovidernamewellknownopenidconfiguration) | **GET** /identity/oidc/provider/{name}/.well-known/openid-configuration | 
*Identity* | [**ReadIdentityOidcRoleName**](docs/Identity.md#readidentityoidcrolename) | **GET** /identity/oidc/role/{name} | CRUD operations on OIDC Roles
*Identity* | [**ReadIdentityOidcScopeName**](docs/Identity.md#readidentityoidcscopename) | **GET** /identity/oidc/scope/{name} | 
*Identity* | [**ReadIdentityOidcTokenName**](docs/Identity.md#readidentityoidctokenname) | **GET** /identity/oidc/token/{name} | Generate an OIDC token
*Identity* | [**ReadIdentityOidcWellKnownKeys**](docs/Identity.md#readidentityoidcwellknownkeys) | **GET** /identity/oidc/.well-known/keys | Retrieve public keys
*Identity* | [**ReadIdentityOidcWellKnownOpenidConfiguration**](docs/Identity.md#readidentityoidcwellknownopenidconfiguration) | **GET** /identity/oidc/.well-known/openid-configuration | Query OIDC configurations
*Identity* | [**ReadIdentityPersonaIdId**](docs/Identity.md#readidentitypersonaidid) | **GET** /identity/persona/id/{id} | Update, read or delete an alias ID.
*Identity* | [**UpdateIdentityAlias**](docs/Identity.md#updateidentityalias) | **POST** /identity/alias | Create a new alias.
*Identity* | [**UpdateIdentityAliasIdId**](docs/Identity.md#updateidentityaliasidid) | **POST** /identity/alias/id/{id} | Update, read or delete an alias ID.
*Identity* | [**UpdateIdentityEntity**](docs/Identity.md#updateidentityentity) | **POST** /identity/entity | Create a new entity
*Identity* | [**UpdateIdentityEntityAlias**](docs/Identity.md#updateidentityentityalias) | **POST** /identity/entity-alias | Create a new alias.
*Identity* | [**UpdateIdentityEntityAliasIdId**](docs/Identity.md#updateidentityentityaliasidid) | **POST** /identity/entity-alias/id/{id} | Update, read or delete an alias ID.
*Identity* | [**UpdateIdentityEntityBatchDelete**](docs/Identity.md#updateidentityentitybatchdelete) | **POST** /identity/entity/batch-delete | Delete all of the entities provided
*Identity* | [**UpdateIdentityEntityIdId**](docs/Identity.md#updateidentityentityidid) | **POST** /identity/entity/id/{id} | Update, read or delete an entity using entity ID
*Identity* | [**UpdateIdentityEntityMerge**](docs/Identity.md#updateidentityentitymerge) | **POST** /identity/entity/merge | Merge two or more entities together
*Identity* | [**UpdateIdentityEntityNameName**](docs/Identity.md#updateidentityentitynamename) | **POST** /identity/entity/name/{name} | Update, read or delete an entity using entity name
*Identity* | [**UpdateIdentityGroup**](docs/Identity.md#updateidentitygroup) | **POST** /identity/group | Create a new group.
*Identity* | [**UpdateIdentityGroupAlias**](docs/Identity.md#updateidentitygroupalias) | **POST** /identity/group-alias | Creates a new group alias, or updates an existing one.
*Identity* | [**UpdateIdentityGroupAliasIdId**](docs/Identity.md#updateidentitygroupaliasidid) | **POST** /identity/group-alias/id/{id} | 
*Identity* | [**UpdateIdentityGroupIdId**](docs/Identity.md#updateidentitygroupidid) | **POST** /identity/group/id/{id} | Update or delete an existing group using its ID.
*Identity* | [**UpdateIdentityGroupNameName**](docs/Identity.md#updateidentitygroupnamename) | **POST** /identity/group/name/{name} | 
*Identity* | [**UpdateIdentityLookupEntity**](docs/Identity.md#updateidentitylookupentity) | **POST** /identity/lookup/entity | Query entities based on various properties.
*Identity* | [**UpdateIdentityLookupGroup**](docs/Identity.md#updateidentitylookupgroup) | **POST** /identity/lookup/group | Query groups based on various properties.
*Identity* | [**UpdateIdentityMfaLoginEnforcementName**](docs/Identity.md#updateidentitymfaloginenforcementname) | **POST** /identity/mfa/login-enforcement/{name} | Create or update a login enforcement
*Identity* | [**UpdateIdentityMfaMethodDuoMethodId**](docs/Identity.md#updateidentitymfamethodduomethodid) | **POST** /identity/mfa/method/duo/{method_id} | Update or create a configuration for the given MFA method
*Identity* | [**UpdateIdentityMfaMethodOktaMethodId**](docs/Identity.md#updateidentitymfamethodoktamethodid) | **POST** /identity/mfa/method/okta/{method_id} | Update or create a configuration for the given MFA method
*Identity* | [**UpdateIdentityMfaMethodPingidMethodId**](docs/Identity.md#updateidentitymfamethodpingidmethodid) | **POST** /identity/mfa/method/pingid/{method_id} | Update or create a configuration for the given MFA method
*Identity* | [**UpdateIdentityMfaMethodTotpAdminDestroy**](docs/Identity.md#updateidentitymfamethodtotpadmindestroy) | **POST** /identity/mfa/method/totp/admin-destroy | Destroys a TOTP secret for the given MFA method ID on the given entity
*Identity* | [**UpdateIdentityMfaMethodTotpAdminGenerate**](docs/Identity.md#updateidentitymfamethodtotpadmingenerate) | **POST** /identity/mfa/method/totp/admin-generate | Update or create TOTP secret for the given method ID on the given entity.
*Identity* | [**UpdateIdentityMfaMethodTotpGenerate**](docs/Identity.md#updateidentitymfamethodtotpgenerate) | **POST** /identity/mfa/method/totp/generate | Update or create TOTP secret for the given method ID on the given entity.
*Identity* | [**UpdateIdentityMfaMethodTotpMethodId**](docs/Identity.md#updateidentitymfamethodtotpmethodid) | **POST** /identity/mfa/method/totp/{method_id} | Update or create a configuration for the given MFA method
*Identity* | [**UpdateIdentityOidcAssignmentName**](docs/Identity.md#updateidentityoidcassignmentname) | **POST** /identity/oidc/assignment/{name} | 
*Identity* | [**UpdateIdentityOidcClientName**](docs/Identity.md#updateidentityoidcclientname) | **POST** /identity/oidc/client/{name} | 
*Identity* | [**UpdateIdentityOidcConfig**](docs/Identity.md#updateidentityoidcconfig) | **POST** /identity/oidc/config | OIDC configuration
*Identity* | [**UpdateIdentityOidcIntrospect**](docs/Identity.md#updateidentityoidcintrospect) | **POST** /identity/oidc/introspect | Verify the authenticity of an OIDC token
*Identity* | [**UpdateIdentityOidcKeyName**](docs/Identity.md#updateidentityoidckeyname) | **POST** /identity/oidc/key/{name} | CRUD operations for OIDC keys.
*Identity* | [**UpdateIdentityOidcKeyNameRotate**](docs/Identity.md#updateidentityoidckeynamerotate) | **POST** /identity/oidc/key/{name}/rotate | Rotate a named OIDC key.
*Identity* | [**UpdateIdentityOidcProviderName**](docs/Identity.md#updateidentityoidcprovidername) | **POST** /identity/oidc/provider/{name} | 
*Identity* | [**UpdateIdentityOidcProviderNameAuthorize**](docs/Identity.md#updateidentityoidcprovidernameauthorize) | **POST** /identity/oidc/provider/{name}/authorize | 
*Identity* | [**UpdateIdentityOidcProviderNameToken**](docs/Identity.md#updateidentityoidcprovidernametoken) | **POST** /identity/oidc/provider/{name}/token | 
*Identity* | [**UpdateIdentityOidcProviderNameUserinfo**](docs/Identity.md#updateidentityoidcprovidernameuserinfo) | **POST** /identity/oidc/provider/{name}/userinfo | 
*Identity* | [**UpdateIdentityOidcRoleName**](docs/Identity.md#updateidentityoidcrolename) | **POST** /identity/oidc/role/{name} | CRUD operations on OIDC Roles
*Identity* | [**UpdateIdentityOidcScopeName**](docs/Identity.md#updateidentityoidcscopename) | **POST** /identity/oidc/scope/{name} | 
*Identity* | [**UpdateIdentityPersona**](docs/Identity.md#updateidentitypersona) | **POST** /identity/persona | Create a new alias.
*Identity* | [**UpdateIdentityPersonaIdId**](docs/Identity.md#updateidentitypersonaidid) | **POST** /identity/persona/id/{id} | Update, read or delete an alias ID.
*Secrets* | [**DeleteAwsRolesName**](docs/Secrets.md#deleteawsrolesname) | **DELETE** /{mount_path}/roles/{name} | Read, write and reference IAM policies that access keys can be made for.
*Secrets* | [**DeleteCubbyholePath**](docs/Secrets.md#deletecubbyholepath) | **DELETE** /{mount_path}/{path} | Deletes the secret at the specified location.
*Secrets* | [**DeleteGcpRolesetName**](docs/Secrets.md#deletegcprolesetname) | **DELETE** /{mount_path}/roleset/{name} | 
*Secrets* | [**DeleteGcpStaticAccountName**](docs/Secrets.md#deletegcpstaticaccountname) | **DELETE** /{mount_path}/static-account/{name} | 
*Secrets* | [**DeleteGcpkmsKeysDeregisterKey**](docs/Secrets.md#deletegcpkmskeysderegisterkey) | **DELETE** /{mount_path}/keys/deregister/{key} | Deregister an existing key in Vault
*Secrets* | [**DeleteGcpkmsKeysKey**](docs/Secrets.md#deletegcpkmskeyskey) | **DELETE** /{mount_path}/keys/{key} | Interact with crypto keys in Vault and Google Cloud KMS
*Secrets* | [**DeleteGcpkmsKeysTrimKey**](docs/Secrets.md#deletegcpkmskeystrimkey) | **DELETE** /{mount_path}/keys/trim/{key} | Delete old crypto key versions from Google Cloud KMS
*Secrets* | [**DeleteLdapLibraryName**](docs/Secrets.md#deleteldaplibraryname) | **DELETE** /{mount_path}/library/{name} | Delete a library set.
*Secrets* | [**DeleteLdapRoleName**](docs/Secrets.md#deleteldaprolename) | **DELETE** /{mount_path}/role/{name} | 
*Secrets* | [**DeleteLdapStaticRoleName**](docs/Secrets.md#deleteldapstaticrolename) | **DELETE** /{mount_path}/static-role/{name} | 
*Secrets* | [**DeleteNomadConfigAccess**](docs/Secrets.md#deletenomadconfigaccess) | **DELETE** /{mount_path}/config/access | 
*Secrets* | [**DeletePkiIssuerRefDerPem**](docs/Secrets.md#deletepkiissuerrefderpem) | **DELETE** /{mount_path}/{issuer_ref}/der|/pem | 
*Secrets* | [**DeletePkiJson**](docs/Secrets.md#deletepkijson) | **DELETE** /{mount_path}//json | 
*Secrets* | [**DeletePkiKeyKeyRef**](docs/Secrets.md#deletepkikeykeyref) | **DELETE** /{mount_path}/key/{key_ref} | 
*Secrets* | [**DeletePkiRoot**](docs/Secrets.md#deletepkiroot) | **DELETE** /{mount_path}/root | 
*Secrets* | [**DeleteSecretDataPath**](docs/Secrets.md#deletesecretdatapath) | **DELETE** /{mount_path}/data/{path} | Write, Patch, Read, and Delete data in the Key-Value Store.
*Secrets* | [**DeleteSecretMetadataPath**](docs/Secrets.md#deletesecretmetadatapath) | **DELETE** /{mount_path}/metadata/{path} | Configures settings for the KV store
*Secrets* | [**DeleteSshConfigZeroaddress**](docs/Secrets.md#deletesshconfigzeroaddress) | **DELETE** /{mount_path}/config/zeroaddress | Assign zero address as default CIDR block for select roles.
*Secrets* | [**DeleteSshKeysKeyName**](docs/Secrets.md#deletesshkeyskeyname) | **DELETE** /{mount_path}/keys/{key_name} | Register a shared private key with Vault.
*Secrets* | [**DeleteSshRolesRole**](docs/Secrets.md#deletesshrolesrole) | **DELETE** /{mount_path}/roles/{role} | Manage the 'roles' that can be created with this backend.
*Secrets* | [**DeleteTotpKeysName**](docs/Secrets.md#deletetotpkeysname) | **DELETE** /{mount_path}/keys/{name} | Manage the keys that can be created with this backend.
*Secrets* | [**ListAwsRoles**](docs/Secrets.md#listawsroles) | **GET** /{mount_path}/roles | List the existing roles in this backend
*Secrets* | [**ListGcpRolesets**](docs/Secrets.md#listgcprolesets) | **GET** /{mount_path}/rolesets | 
*Secrets* | [**ListGcpStaticAccounts**](docs/Secrets.md#listgcpstaticaccounts) | **GET** /{mount_path}/static-accounts | 
*Secrets* | [**ListLdapLibrary**](docs/Secrets.md#listldaplibrary) | **GET** /{mount_path}/library | 
*Secrets* | [**ListLdapRole**](docs/Secrets.md#listldaprole) | **GET** /{mount_path}/role | 
*Secrets* | [**ListLdapStaticRole**](docs/Secrets.md#listldapstaticrole) | **GET** /{mount_path}/static-role | 
*Secrets* | [**ListPkiCerts**](docs/Secrets.md#listpkicerts) | **GET** /{mount_path}/certs | 
*Secrets* | [**ListPkiIssuers**](docs/Secrets.md#listpkiissuers) | **GET** /{mount_path}/issuers | 
*Secrets* | [**ListTotpKeys**](docs/Secrets.md#listtotpkeys) | **GET** /{mount_path}/keys | Manage the keys that can be created with this backend.
*Secrets* | [**ReadAwsConfigLease**](docs/Secrets.md#readawsconfiglease) | **GET** /{mount_path}/config/lease | Configure the default lease information for generated credentials.
*Secrets* | [**ReadAwsConfigRoot**](docs/Secrets.md#readawsconfigroot) | **GET** /{mount_path}/config/root | Configure the root credentials that are used to manage IAM.
*Secrets* | [**ReadAwsCreds**](docs/Secrets.md#readawscreds) | **GET** /{mount_path}/creds | Generate AWS credentials from a specific Vault role.
*Secrets* | [**ReadAwsRolesName**](docs/Secrets.md#readawsrolesname) | **GET** /{mount_path}/roles/{name} | Read, write and reference IAM policies that access keys can be made for.
*Secrets* | [**ReadAwsStsName**](docs/Secrets.md#readawsstsname) | **GET** /{mount_path}/sts/{name} | Generate AWS credentials from a specific Vault role.
*Secrets* | [**ReadAzureCredsRole**](docs/Secrets.md#readazurecredsrole) | **GET** /{mount_path}/creds/{role} | 
*Secrets* | [**ReadCubbyholePath**](docs/Secrets.md#readcubbyholepath) | **GET** /{mount_path}/{path} | Retrieve the secret at the specified location.
*Secrets* | [**ReadGcpConfig**](docs/Secrets.md#readgcpconfig) | **GET** /{mount_path}/config | 
*Secrets* | [**ReadGcpKeyRoleset**](docs/Secrets.md#readgcpkeyroleset) | **GET** /{mount_path}/key/{roleset} | 
*Secrets* | [**ReadGcpRolesetName**](docs/Secrets.md#readgcprolesetname) | **GET** /{mount_path}/roleset/{name} | 
*Secrets* | [**ReadGcpRolesetRolesetKey**](docs/Secrets.md#readgcprolesetrolesetkey) | **GET** /{mount_path}/roleset/{roleset}/key | 
*Secrets* | [**ReadGcpRolesetRolesetToken**](docs/Secrets.md#readgcprolesetrolesettoken) | **GET** /{mount_path}/roleset/{roleset}/token | 
*Secrets* | [**ReadGcpStaticAccountName**](docs/Secrets.md#readgcpstaticaccountname) | **GET** /{mount_path}/static-account/{name} | 
*Secrets* | [**ReadGcpStaticAccountNameKey**](docs/Secrets.md#readgcpstaticaccountnamekey) | **GET** /{mount_path}/static-account/{name}/key | 
*Secrets* | [**ReadGcpStaticAccountNameToken**](docs/Secrets.md#readgcpstaticaccountnametoken) | **GET** /{mount_path}/static-account/{name}/token | 
*Secrets* | [**ReadGcpTokenRoleset**](docs/Secrets.md#readgcptokenroleset) | **GET** /{mount_path}/token/{roleset} | 
*Secrets* | [**ReadGcpkmsKeysConfigKey**](docs/Secrets.md#readgcpkmskeysconfigkey) | **GET** /{mount_path}/keys/config/{key} | Configure the key in Vault
*Secrets* | [**ReadGcpkmsKeysKey**](docs/Secrets.md#readgcpkmskeyskey) | **GET** /{mount_path}/keys/{key} | Interact with crypto keys in Vault and Google Cloud KMS
*Secrets* | [**ReadGcpkmsPubkeyKey**](docs/Secrets.md#readgcpkmspubkeykey) | **GET** /{mount_path}/pubkey/{key} | Retrieve the public key associated with the named key
*Secrets* | [**ReadLdapCredsName**](docs/Secrets.md#readldapcredsname) | **GET** /{mount_path}/creds/{name} | 
*Secrets* | [**ReadLdapLibraryName**](docs/Secrets.md#readldaplibraryname) | **GET** /{mount_path}/library/{name} | Read a library set.
*Secrets* | [**ReadLdapLibraryNameStatus**](docs/Secrets.md#readldaplibrarynamestatus) | **GET** /{mount_path}/library/{name}/status | Check the status of the service accounts in a library set.
*Secrets* | [**ReadLdapRoleName**](docs/Secrets.md#readldaprolename) | **GET** /{mount_path}/role/{name} | 
*Secrets* | [**ReadLdapStaticCredName**](docs/Secrets.md#readldapstaticcredname) | **GET** /{mount_path}/static-cred/{name} | 
*Secrets* | [**ReadLdapStaticRoleName**](docs/Secrets.md#readldapstaticrolename) | **GET** /{mount_path}/static-role/{name} | 
*Secrets* | [**ReadNomadConfigAccess**](docs/Secrets.md#readnomadconfigaccess) | **GET** /{mount_path}/config/access | 
*Secrets* | [**ReadPkiCa**](docs/Secrets.md#readpkica) | **GET** /{mount_path}/ca | 
*Secrets* | [**ReadPkiCaChain**](docs/Secrets.md#readpkicachain) | **GET** /{mount_path}/ca_chain | 
*Secrets* | [**ReadPkiCaPem**](docs/Secrets.md#readpkicapem) | **GET** /{mount_path}/ca/pem | 
*Secrets* | [**ReadPkiCertCaChain**](docs/Secrets.md#readpkicertcachain) | **GET** /{mount_path}/cert/ca_chain | 
*Secrets* | [**ReadPkiCertSerial**](docs/Secrets.md#readpkicertserial) | **GET** /{mount_path}/cert/{serial} | 
*Secrets* | [**ReadPkiCertSerialRaw**](docs/Secrets.md#readpkicertserialraw) | **GET** /{mount_path}/cert/{serial}/raw | 
*Secrets* | [**ReadPkiCertSerialRawPem**](docs/Secrets.md#readpkicertserialrawpem) | **GET** /{mount_path}/cert/{serial}/raw/pem | 
*Secrets* | [**ReadPkiConfigAutoTidy**](docs/Secrets.md#readpkiconfigautotidy) | **GET** /{mount_path}/config/auto-tidy | 
*Secrets* | [**ReadPkiConfigCrl**](docs/Secrets.md#readpkiconfigcrl) | **GET** /{mount_path}/config/crl | 
*Secrets* | [**ReadPkiConfigIssuers**](docs/Secrets.md#readpkiconfigissuers) | **GET** /{mount_path}/config/issuers | 
*Secrets* | [**ReadPkiConfigKeys**](docs/Secrets.md#readpkiconfigkeys) | **GET** /{mount_path}/config/keys | 
*Secrets* | [**ReadPkiConfigUrls**](docs/Secrets.md#readpkiconfigurls) | **GET** /{mount_path}/config/urls | 
*Secrets* | [**ReadPkiCrl**](docs/Secrets.md#readpkicrl) | **GET** /{mount_path}/crl | 
*Secrets* | [**ReadPkiCrlRotate**](docs/Secrets.md#readpkicrlrotate) | **GET** /{mount_path}/crl/rotate | 
*Secrets* | [**ReadPkiCrlRotateDelta**](docs/Secrets.md#readpkicrlrotatedelta) | **GET** /{mount_path}/crl/rotate-delta | 
*Secrets* | [**ReadPkiDelta**](docs/Secrets.md#readpkidelta) | **GET** /{mount_path}//delta | 
*Secrets* | [**ReadPkiDeltaCrl**](docs/Secrets.md#readpkideltacrl) | **GET** /{mount_path}/delta-crl | 
*Secrets* | [**ReadPkiDeltaPem**](docs/Secrets.md#readpkideltapem) | **GET** /{mount_path}//delta/pem | 
*Secrets* | [**ReadPkiDer**](docs/Secrets.md#readpkider) | **GET** /{mount_path}//der | 
*Secrets* | [**ReadPkiIssuerRefCrlPemDerDeltaPem**](docs/Secrets.md#readpkiissuerrefcrlpemderdeltapem) | **GET** /{mount_path}/{issuer_ref}/crl/pem|/der|/delta/pem | 
*Secrets* | [**ReadPkiIssuerRefDerPem**](docs/Secrets.md#readpkiissuerrefderpem) | **GET** /{mount_path}/{issuer_ref}/der|/pem | 
*Secrets* | [**ReadPkiJson**](docs/Secrets.md#readpkijson) | **GET** /{mount_path}//json | 
*Secrets* | [**ReadPkiKeyKeyRef**](docs/Secrets.md#readpkikeykeyref) | **GET** /{mount_path}/key/{key_ref} | 
*Secrets* | [**ReadPkiOcspReq**](docs/Secrets.md#readpkiocspreq) | **GET** /{mount_path}/ocsp/{req} | 
*Secrets* | [**ReadPkiPem**](docs/Secrets.md#readpkipem) | **GET** /{mount_path}//pem | 
*Secrets* | [**ReadPkiTidyStatus**](docs/Secrets.md#readpkitidystatus) | **GET** /{mount_path}/tidy-status | 
*Secrets* | [**ReadSecretDataPath**](docs/Secrets.md#readsecretdatapath) | **GET** /{mount_path}/data/{path} | Write, Patch, Read, and Delete data in the Key-Value Store.
*Secrets* | [**ReadSecretMetadataPath**](docs/Secrets.md#readsecretmetadatapath) | **GET** /{mount_path}/metadata/{path} | Configures settings for the KV store
*Secrets* | [**ReadSecretSubkeysPath**](docs/Secrets.md#readsecretsubkeyspath) | **GET** /{mount_path}/subkeys/{path} | Read the structure of a secret entry from the Key-Value store with the values removed.
*Secrets* | [**ReadSshConfigZeroaddress**](docs/Secrets.md#readsshconfigzeroaddress) | **GET** /{mount_path}/config/zeroaddress | Assign zero address as default CIDR block for select roles.
*Secrets* | [**ReadSshPublicKey**](docs/Secrets.md#readsshpublickey) | **GET** /{mount_path}/public_key | Retrieve the public key.
*Secrets* | [**ReadSshRolesRole**](docs/Secrets.md#readsshrolesrole) | **GET** /{mount_path}/roles/{role} | Manage the 'roles' that can be created with this backend.
*Secrets* | [**ReadTotpCodeName**](docs/Secrets.md#readtotpcodename) | **GET** /{mount_path}/code/{name} | Request time-based one-time use password or validate a password for a certain key .
*Secrets* | [**ReadTotpKeysName**](docs/Secrets.md#readtotpkeysname) | **GET** /{mount_path}/keys/{name} | Manage the keys that can be created with this backend.
*Secrets* | [**ReadTransitBackupName**](docs/Secrets.md#readtransitbackupname) | **GET** /{mount_path}/backup/{name} | Backup the named key
*Secrets* | [**ReadTransitCacheConfig**](docs/Secrets.md#readtransitcacheconfig) | **GET** /{mount_path}/cache-config | Returns the size of the active cache
*Secrets* | [**ReadTransitExportTypeName**](docs/Secrets.md#readtransitexporttypename) | **GET** /{mount_path}/export/{type}/{name} | Export named encryption or signing key
*Secrets* | [**ReadTransitExportTypeNameVersion**](docs/Secrets.md#readtransitexporttypenameversion) | **GET** /{mount_path}/export/{type}/{name}/{version} | Export named encryption or signing key
*Secrets* | [**ReadTransitWrappingKey**](docs/Secrets.md#readtransitwrappingkey) | **GET** /{mount_path}/wrapping_key | Returns the public key to use for wrapping imported keys
*Secrets* | [**UpdateAwsConfigLease**](docs/Secrets.md#updateawsconfiglease) | **POST** /{mount_path}/config/lease | Configure the default lease information for generated credentials.
*Secrets* | [**UpdateAwsConfigRoot**](docs/Secrets.md#updateawsconfigroot) | **POST** /{mount_path}/config/root | Configure the root credentials that are used to manage IAM.
*Secrets* | [**UpdateAwsCreds**](docs/Secrets.md#updateawscreds) | **POST** /{mount_path}/creds | Generate AWS credentials from a specific Vault role.
*Secrets* | [**UpdateAwsRolesName**](docs/Secrets.md#updateawsrolesname) | **POST** /{mount_path}/roles/{name} | Read, write and reference IAM policies that access keys can be made for.
*Secrets* | [**UpdateAwsStsName**](docs/Secrets.md#updateawsstsname) | **POST** /{mount_path}/sts/{name} | Generate AWS credentials from a specific Vault role.
*Secrets* | [**UpdateCubbyholePath**](docs/Secrets.md#updatecubbyholepath) | **POST** /{mount_path}/{path} | Store a secret at the specified location.
*Secrets* | [**UpdateGcpConfig**](docs/Secrets.md#updategcpconfig) | **POST** /{mount_path}/config | 
*Secrets* | [**UpdateGcpConfigRotateRoot**](docs/Secrets.md#updategcpconfigrotateroot) | **POST** /{mount_path}/config/rotate-root | 
*Secrets* | [**UpdateGcpKeyRoleset**](docs/Secrets.md#updategcpkeyroleset) | **POST** /{mount_path}/key/{roleset} | 
*Secrets* | [**UpdateGcpRolesetName**](docs/Secrets.md#updategcprolesetname) | **POST** /{mount_path}/roleset/{name} | 
*Secrets* | [**UpdateGcpRolesetNameRotate**](docs/Secrets.md#updategcprolesetnamerotate) | **POST** /{mount_path}/roleset/{name}/rotate | 
*Secrets* | [**UpdateGcpRolesetNameRotateKey**](docs/Secrets.md#updategcprolesetnamerotatekey) | **POST** /{mount_path}/roleset/{name}/rotate-key | 
*Secrets* | [**UpdateGcpRolesetRolesetKey**](docs/Secrets.md#updategcprolesetrolesetkey) | **POST** /{mount_path}/roleset/{roleset}/key | 
*Secrets* | [**UpdateGcpRolesetRolesetToken**](docs/Secrets.md#updategcprolesetrolesettoken) | **POST** /{mount_path}/roleset/{roleset}/token | 
*Secrets* | [**UpdateGcpStaticAccountName**](docs/Secrets.md#updategcpstaticaccountname) | **POST** /{mount_path}/static-account/{name} | 
*Secrets* | [**UpdateGcpStaticAccountNameKey**](docs/Secrets.md#updategcpstaticaccountnamekey) | **POST** /{mount_path}/static-account/{name}/key | 
*Secrets* | [**UpdateGcpStaticAccountNameRotateKey**](docs/Secrets.md#updategcpstaticaccountnamerotatekey) | **POST** /{mount_path}/static-account/{name}/rotate-key | 
*Secrets* | [**UpdateGcpStaticAccountNameToken**](docs/Secrets.md#updategcpstaticaccountnametoken) | **POST** /{mount_path}/static-account/{name}/token | 
*Secrets* | [**UpdateGcpTokenRoleset**](docs/Secrets.md#updategcptokenroleset) | **POST** /{mount_path}/token/{roleset} | 
*Secrets* | [**UpdateGcpkmsDecryptKey**](docs/Secrets.md#updategcpkmsdecryptkey) | **POST** /{mount_path}/decrypt/{key} | Decrypt a ciphertext value using a named key
*Secrets* | [**UpdateGcpkmsEncryptKey**](docs/Secrets.md#updategcpkmsencryptkey) | **POST** /{mount_path}/encrypt/{key} | Encrypt a plaintext value using a named key
*Secrets* | [**UpdateGcpkmsKeysConfigKey**](docs/Secrets.md#updategcpkmskeysconfigkey) | **POST** /{mount_path}/keys/config/{key} | Configure the key in Vault
*Secrets* | [**UpdateGcpkmsKeysDeregisterKey**](docs/Secrets.md#updategcpkmskeysderegisterkey) | **POST** /{mount_path}/keys/deregister/{key} | Deregister an existing key in Vault
*Secrets* | [**UpdateGcpkmsKeysKey**](docs/Secrets.md#updategcpkmskeyskey) | **POST** /{mount_path}/keys/{key} | Interact with crypto keys in Vault and Google Cloud KMS
*Secrets* | [**UpdateGcpkmsKeysRegisterKey**](docs/Secrets.md#updategcpkmskeysregisterkey) | **POST** /{mount_path}/keys/register/{key} | Register an existing crypto key in Google Cloud KMS
*Secrets* | [**UpdateGcpkmsKeysRotateKey**](docs/Secrets.md#updategcpkmskeysrotatekey) | **POST** /{mount_path}/keys/rotate/{key} | Rotate a crypto key to a new primary version
*Secrets* | [**UpdateGcpkmsKeysTrimKey**](docs/Secrets.md#updategcpkmskeystrimkey) | **POST** /{mount_path}/keys/trim/{key} | Delete old crypto key versions from Google Cloud KMS
*Secrets* | [**UpdateGcpkmsReencryptKey**](docs/Secrets.md#updategcpkmsreencryptkey) | **POST** /{mount_path}/reencrypt/{key} | Re-encrypt existing ciphertext data to a new version
*Secrets* | [**UpdateGcpkmsSignKey**](docs/Secrets.md#updategcpkmssignkey) | **POST** /{mount_path}/sign/{key} | Signs a message or digest using a named key
*Secrets* | [**UpdateGcpkmsVerifyKey**](docs/Secrets.md#updategcpkmsverifykey) | **POST** /{mount_path}/verify/{key} | Verify a signature using a named key
*Secrets* | [**UpdateLdapLibraryManageNameCheckIn**](docs/Secrets.md#updateldaplibrarymanagenamecheckin) | **POST** /{mount_path}/library/manage/{name}/check-in | Check service accounts in to the library.
*Secrets* | [**UpdateLdapLibraryName**](docs/Secrets.md#updateldaplibraryname) | **POST** /{mount_path}/library/{name} | Update a library set.
*Secrets* | [**UpdateLdapLibraryNameCheckIn**](docs/Secrets.md#updateldaplibrarynamecheckin) | **POST** /{mount_path}/library/{name}/check-in | Check service accounts in to the library.
*Secrets* | [**UpdateLdapLibraryNameCheckOut**](docs/Secrets.md#updateldaplibrarynamecheckout) | **POST** /{mount_path}/library/{name}/check-out | Check a service account out from the library.
*Secrets* | [**UpdateLdapRoleName**](docs/Secrets.md#updateldaprolename) | **POST** /{mount_path}/role/{name} | 
*Secrets* | [**UpdateLdapRotateRoleName**](docs/Secrets.md#updateldaprotaterolename) | **POST** /{mount_path}/rotate-role/{name} | 
*Secrets* | [**UpdateLdapRotateRoot**](docs/Secrets.md#updateldaprotateroot) | **POST** /{mount_path}/rotate-root | 
*Secrets* | [**UpdateLdapStaticRoleName**](docs/Secrets.md#updateldapstaticrolename) | **POST** /{mount_path}/static-role/{name} | 
*Secrets* | [**UpdateNomadConfigAccess**](docs/Secrets.md#updatenomadconfigaccess) | **POST** /{mount_path}/config/access | 
*Secrets* | [**UpdatePkiBundle**](docs/Secrets.md#updatepkibundle) | **POST** /{mount_path}/bundle | 
*Secrets* | [**UpdatePkiCert**](docs/Secrets.md#updatepkicert) | **POST** /{mount_path}/cert | 
*Secrets* | [**UpdatePkiConfigAutoTidy**](docs/Secrets.md#updatepkiconfigautotidy) | **POST** /{mount_path}/config/auto-tidy | 
*Secrets* | [**UpdatePkiConfigCa**](docs/Secrets.md#updatepkiconfigca) | **POST** /{mount_path}/config/ca | 
*Secrets* | [**UpdatePkiConfigCrl**](docs/Secrets.md#updatepkiconfigcrl) | **POST** /{mount_path}/config/crl | 
*Secrets* | [**UpdatePkiConfigIssuers**](docs/Secrets.md#updatepkiconfigissuers) | **POST** /{mount_path}/config/issuers | 
*Secrets* | [**UpdatePkiConfigKeys**](docs/Secrets.md#updatepkiconfigkeys) | **POST** /{mount_path}/config/keys | 
*Secrets* | [**UpdatePkiConfigUrls**](docs/Secrets.md#updatepkiconfigurls) | **POST** /{mount_path}/config/urls | 
*Secrets* | [**UpdatePkiIntermediateCrossSign**](docs/Secrets.md#updatepkiintermediatecrosssign) | **POST** /{mount_path}/intermediate/cross-sign | 
*Secrets* | [**UpdatePkiIntermediateGenerateExported**](docs/Secrets.md#updatepkiintermediategenerateexported) | **POST** /{mount_path}/intermediate/generate/{exported} | 
*Secrets* | [**UpdatePkiIntermediateSetSigned**](docs/Secrets.md#updatepkiintermediatesetsigned) | **POST** /{mount_path}/intermediate/set-signed | 
*Secrets* | [**UpdatePkiIssueRole**](docs/Secrets.md#updatepkiissuerole) | **POST** /{mount_path}/issue/{role} | 
*Secrets* | [**UpdatePkiIssuerIssuerRefIssueRole**](docs/Secrets.md#updatepkiissuerissuerrefissuerole) | **POST** /{mount_path}/issuer/{issuer_ref}/issue/{role} | 
*Secrets* | [**UpdatePkiIssuerIssuerRefRevoke**](docs/Secrets.md#updatepkiissuerissuerrefrevoke) | **POST** /{mount_path}/issuer/{issuer_ref}/revoke | 
*Secrets* | [**UpdatePkiIssuerIssuerRefSignIntermediate**](docs/Secrets.md#updatepkiissuerissuerrefsignintermediate) | **POST** /{mount_path}/issuer/{issuer_ref}/sign-intermediate | 
*Secrets* | [**UpdatePkiIssuerIssuerRefSignRole**](docs/Secrets.md#updatepkiissuerissuerrefsignrole) | **POST** /{mount_path}/issuer/{issuer_ref}/sign/{role} | 
*Secrets* | [**UpdatePkiIssuerIssuerRefSignSelfIssued**](docs/Secrets.md#updatepkiissuerissuerrefsignselfissued) | **POST** /{mount_path}/issuer/{issuer_ref}/sign-self-issued | 
*Secrets* | [**UpdatePkiIssuerIssuerRefSignVerbatim**](docs/Secrets.md#updatepkiissuerissuerrefsignverbatim) | **POST** /{mount_path}/issuer/{issuer_ref}/sign-verbatim | 
*Secrets* | [**UpdatePkiIssuerIssuerRefSignVerbatimRole**](docs/Secrets.md#updatepkiissuerissuerrefsignverbatimrole) | **POST** /{mount_path}/issuer/{issuer_ref}/sign-verbatim/{role} | 
*Secrets* | [**UpdatePkiIssuersGenerateIntermediateExported**](docs/Secrets.md#updatepkiissuersgenerateintermediateexported) | **POST** /{mount_path}/issuers/generate/intermediate/{exported} | 
*Secrets* | [**UpdatePkiIssuersGenerateRootExported**](docs/Secrets.md#updatepkiissuersgeneraterootexported) | **POST** /{mount_path}/issuers/generate/root/{exported} | 
*Secrets* | [**UpdatePkiJson**](docs/Secrets.md#updatepkijson) | **POST** /{mount_path}//json | 
*Secrets* | [**UpdatePkiKeyKeyRef**](docs/Secrets.md#updatepkikeykeyref) | **POST** /{mount_path}/key/{key_ref} | 
*Secrets* | [**UpdatePkiKeysImport**](docs/Secrets.md#updatepkikeysimport) | **POST** /{mount_path}/keys/import | 
*Secrets* | [**UpdatePkiKms**](docs/Secrets.md#updatepkikms) | **POST** /{mount_path}/kms | 
*Secrets* | [**UpdatePkiOcsp**](docs/Secrets.md#updatepkiocsp) | **POST** /{mount_path}/ocsp | 
*Secrets* | [**UpdatePkiRevoke**](docs/Secrets.md#updatepkirevoke) | **POST** /{mount_path}/revoke | 
*Secrets* | [**UpdatePkiRevokeWithKey**](docs/Secrets.md#updatepkirevokewithkey) | **POST** /{mount_path}/revoke-with-key | 
*Secrets* | [**UpdatePkiRootGenerateExported**](docs/Secrets.md#updatepkirootgenerateexported) | **POST** /{mount_path}/root/generate/{exported} | 
*Secrets* | [**UpdatePkiRootReplace**](docs/Secrets.md#updatepkirootreplace) | **POST** /{mount_path}/root/replace | 
*Secrets* | [**UpdatePkiRootRotateExported**](docs/Secrets.md#updatepkirootrotateexported) | **POST** /{mount_path}/root/rotate/{exported} | 
*Secrets* | [**UpdatePkiRootSignIntermediate**](docs/Secrets.md#updatepkirootsignintermediate) | **POST** /{mount_path}/root/sign-intermediate | 
*Secrets* | [**UpdatePkiRootSignSelfIssued**](docs/Secrets.md#updatepkirootsignselfissued) | **POST** /{mount_path}/root/sign-self-issued | 
*Secrets* | [**UpdatePkiSignRole**](docs/Secrets.md#updatepkisignrole) | **POST** /{mount_path}/sign/{role} | 
*Secrets* | [**UpdatePkiSignVerbatim**](docs/Secrets.md#updatepkisignverbatim) | **POST** /{mount_path}/sign-verbatim | 
*Secrets* | [**UpdatePkiSignVerbatimRole**](docs/Secrets.md#updatepkisignverbatimrole) | **POST** /{mount_path}/sign-verbatim/{role} | 
*Secrets* | [**UpdatePkiTidy**](docs/Secrets.md#updatepkitidy) | **POST** /{mount_path}/tidy | 
*Secrets* | [**UpdatePkiTidyCancel**](docs/Secrets.md#updatepkitidycancel) | **POST** /{mount_path}/tidy-cancel | 
*Secrets* | [**UpdateRabbitmqConfigConnection**](docs/Secrets.md#updaterabbitmqconfigconnection) | **POST** /{mount_path}/config/connection | Configure the connection URI, username, and password to talk to RabbitMQ management HTTP API.
*Secrets* | [**UpdateSecretDataPath**](docs/Secrets.md#updatesecretdatapath) | **POST** /{mount_path}/data/{path} | Write, Patch, Read, and Delete data in the Key-Value Store.
*Secrets* | [**UpdateSecretDeletePath**](docs/Secrets.md#updatesecretdeletepath) | **POST** /{mount_path}/delete/{path} | Marks one or more versions as deleted in the KV store.
*Secrets* | [**UpdateSecretDestroyPath**](docs/Secrets.md#updatesecretdestroypath) | **POST** /{mount_path}/destroy/{path} | Permanently removes one or more versions in the KV store
*Secrets* | [**UpdateSecretMetadataPath**](docs/Secrets.md#updatesecretmetadatapath) | **POST** /{mount_path}/metadata/{path} | Configures settings for the KV store
*Secrets* | [**UpdateSecretUndeletePath**](docs/Secrets.md#updatesecretundeletepath) | **POST** /{mount_path}/undelete/{path} | Undeletes one or more versions from the KV store.
*Secrets* | [**UpdateSshConfigZeroaddress**](docs/Secrets.md#updatesshconfigzeroaddress) | **POST** /{mount_path}/config/zeroaddress | Assign zero address as default CIDR block for select roles.
*Secrets* | [**UpdateSshKeysKeyName**](docs/Secrets.md#updatesshkeyskeyname) | **POST** /{mount_path}/keys/{key_name} | Register a shared private key with Vault.
*Secrets* | [**UpdateSshLookup**](docs/Secrets.md#updatesshlookup) | **POST** /{mount_path}/lookup | List all the roles associated with the given IP address.
*Secrets* | [**UpdateSshRolesRole**](docs/Secrets.md#updatesshrolesrole) | **POST** /{mount_path}/roles/{role} | Manage the 'roles' that can be created with this backend.
*Secrets* | [**UpdateSshVerify**](docs/Secrets.md#updatesshverify) | **POST** /{mount_path}/verify | Validate the OTP provided by Vault SSH Agent.
*Secrets* | [**UpdateTotpCodeName**](docs/Secrets.md#updatetotpcodename) | **POST** /{mount_path}/code/{name} | Request time-based one-time use password or validate a password for a certain key .
*Secrets* | [**UpdateTotpKeysName**](docs/Secrets.md#updatetotpkeysname) | **POST** /{mount_path}/keys/{name} | Manage the keys that can be created with this backend.
*Secrets* | [**UpdateTransitCacheConfig**](docs/Secrets.md#updatetransitcacheconfig) | **POST** /{mount_path}/cache-config | Configures a new cache of the specified size
*Secrets* | [**UpdateTransitDatakeyPlaintextName**](docs/Secrets.md#updatetransitdatakeyplaintextname) | **POST** /{mount_path}/datakey/{plaintext}/{name} | Generate a data key
*Secrets* | [**UpdateTransitDecryptName**](docs/Secrets.md#updatetransitdecryptname) | **POST** /{mount_path}/decrypt/{name} | Decrypt a ciphertext value using a named key
*Secrets* | [**UpdateTransitEncryptName**](docs/Secrets.md#updatetransitencryptname) | **POST** /{mount_path}/encrypt/{name} | Encrypt a plaintext value or a batch of plaintext blocks using a named key
*Secrets* | [**UpdateTransitHash**](docs/Secrets.md#updatetransithash) | **POST** /{mount_path}/hash | Generate a hash sum for input data
*Secrets* | [**UpdateTransitHashUrlalgorithm**](docs/Secrets.md#updatetransithashurlalgorithm) | **POST** /{mount_path}/hash/{urlalgorithm} | Generate a hash sum for input data
*Secrets* | [**UpdateTransitHmacName**](docs/Secrets.md#updatetransithmacname) | **POST** /{mount_path}/hmac/{name} | Generate an HMAC for input data using the named key
*Secrets* | [**UpdateTransitHmacNameUrlalgorithm**](docs/Secrets.md#updatetransithmacnameurlalgorithm) | **POST** /{mount_path}/hmac/{name}/{urlalgorithm} | Generate an HMAC for input data using the named key
*Secrets* | [**UpdateTransitKeysNameConfig**](docs/Secrets.md#updatetransitkeysnameconfig) | **POST** /{mount_path}/keys/{name}/config | Configure a named encryption key
*Secrets* | [**UpdateTransitKeysNameImport**](docs/Secrets.md#updatetransitkeysnameimport) | **POST** /{mount_path}/keys/{name}/import | Imports an externally-generated key into a new transit key
*Secrets* | [**UpdateTransitKeysNameImportVersion**](docs/Secrets.md#updatetransitkeysnameimportversion) | **POST** /{mount_path}/keys/{name}/import_version | Imports an externally-generated key into an existing imported key
*Secrets* | [**UpdateTransitKeysNameRotate**](docs/Secrets.md#updatetransitkeysnamerotate) | **POST** /{mount_path}/keys/{name}/rotate | Rotate named encryption key
*Secrets* | [**UpdateTransitKeysNameTrim**](docs/Secrets.md#updatetransitkeysnametrim) | **POST** /{mount_path}/keys/{name}/trim | Trim key versions of a named key
*Secrets* | [**UpdateTransitRandom**](docs/Secrets.md#updatetransitrandom) | **POST** /{mount_path}/random | Generate random bytes
*Secrets* | [**UpdateTransitRandomSource**](docs/Secrets.md#updatetransitrandomsource) | **POST** /{mount_path}/random/{source} | Generate random bytes
*Secrets* | [**UpdateTransitRandomSourceUrlbytes**](docs/Secrets.md#updatetransitrandomsourceurlbytes) | **POST** /{mount_path}/random/{source}/{urlbytes} | Generate random bytes
*Secrets* | [**UpdateTransitRandomUrlbytes**](docs/Secrets.md#updatetransitrandomurlbytes) | **POST** /{mount_path}/random/{urlbytes} | Generate random bytes
*Secrets* | [**UpdateTransitRestore**](docs/Secrets.md#updatetransitrestore) | **POST** /{mount_path}/restore | Restore the named key
*Secrets* | [**UpdateTransitRestoreName**](docs/Secrets.md#updatetransitrestorename) | **POST** /{mount_path}/restore/{name} | Restore the named key
*Secrets* | [**UpdateTransitRewrapName**](docs/Secrets.md#updatetransitrewrapname) | **POST** /{mount_path}/rewrap/{name} | Rewrap ciphertext
*Secrets* | [**UpdateTransitSignName**](docs/Secrets.md#updatetransitsignname) | **POST** /{mount_path}/sign/{name} | Generate a signature for input data using the named key
*Secrets* | [**UpdateTransitSignNameUrlalgorithm**](docs/Secrets.md#updatetransitsignnameurlalgorithm) | **POST** /{mount_path}/sign/{name}/{urlalgorithm} | Generate a signature for input data using the named key
*Secrets* | [**UpdateTransitVerifyName**](docs/Secrets.md#updatetransitverifyname) | **POST** /{mount_path}/verify/{name} | Verify a signature or HMAC for input data created using the named key
*Secrets* | [**UpdateTransitVerifyNameUrlalgorithm**](docs/Secrets.md#updatetransitverifynameurlalgorithm) | **POST** /{mount_path}/verify/{name}/{urlalgorithm} | Verify a signature or HMAC for input data created using the named key
*System* | [**DeleteSystemAuditPath**](docs/System.md#deletesystemauditpath) | **DELETE** /sys/audit/{path} | Disable the audit device at the given path.
*System* | [**DeleteSystemAuthPath**](docs/System.md#deletesystemauthpath) | **DELETE** /sys/auth/{path} | Disable the auth method at the given auth path
*System* | [**DeleteSystemConfigAuditingRequestHeadersHeader**](docs/System.md#deletesystemconfigauditingrequestheadersheader) | **DELETE** /sys/config/auditing/request-headers/{header} | Disable auditing of the given request header.
*System* | [**DeleteSystemConfigCors**](docs/System.md#deletesystemconfigcors) | **DELETE** /sys/config/cors | Remove any CORS settings.
*System* | [**DeleteSystemConfigUiHeadersHeader**](docs/System.md#deletesystemconfiguiheadersheader) | **DELETE** /sys/config/ui/headers/{header} | Remove a UI header.
*System* | [**DeleteSystemGenerateRoot**](docs/System.md#deletesystemgenerateroot) | **DELETE** /sys/generate-root | Cancels any in-progress root generation attempt.
*System* | [**DeleteSystemGenerateRootAttempt**](docs/System.md#deletesystemgeneraterootattempt) | **DELETE** /sys/generate-root/attempt | Cancels any in-progress root generation attempt.
*System* | [**DeleteSystemLoggers**](docs/System.md#deletesystemloggers) | **DELETE** /sys/loggers | Revert the all loggers to use log level provided in config.
*System* | [**DeleteSystemLoggersName**](docs/System.md#deletesystemloggersname) | **DELETE** /sys/loggers/{name} | Revert a single logger to use log level provided in config.
*System* | [**DeleteSystemMountsPath**](docs/System.md#deletesystemmountspath) | **DELETE** /sys/mounts/{path} | Disable the mount point specified at the given path.
*System* | [**DeleteSystemPluginsCatalogName**](docs/System.md#deletesystempluginscatalogname) | **DELETE** /sys/plugins/catalog/{name} | Remove the plugin with the given name.
*System* | [**DeleteSystemPluginsCatalogTypeName**](docs/System.md#deletesystempluginscatalogtypename) | **DELETE** /sys/plugins/catalog/{type}/{name} | Remove the plugin with the given name.
*System* | [**DeleteSystemPoliciesAclName**](docs/System.md#deletesystempoliciesaclname) | **DELETE** /sys/policies/acl/{name} | Delete the ACL policy with the given name.
*System* | [**DeleteSystemPoliciesPasswordName**](docs/System.md#deletesystempoliciespasswordname) | **DELETE** /sys/policies/password/{name} | Delete a password policy.
*System* | [**DeleteSystemPolicyName**](docs/System.md#deletesystempolicyname) | **DELETE** /sys/policy/{name} | Delete the policy with the given name.
*System* | [**DeleteSystemQuotasRateLimitName**](docs/System.md#deletesystemquotasratelimitname) | **DELETE** /sys/quotas/rate-limit/{name} | 
*System* | [**DeleteSystemRaw**](docs/System.md#deletesystemraw) | **DELETE** /sys/raw | Delete the key with given path.
*System* | [**DeleteSystemRawPath**](docs/System.md#deletesystemrawpath) | **DELETE** /sys/raw/{path} | Delete the key with given path.
*System* | [**DeleteSystemRekeyBackup**](docs/System.md#deletesystemrekeybackup) | **DELETE** /sys/rekey/backup | Delete the backup copy of PGP-encrypted unseal keys.
*System* | [**DeleteSystemRekeyInit**](docs/System.md#deletesystemrekeyinit) | **DELETE** /sys/rekey/init | Cancels any in-progress rekey.
*System* | [**DeleteSystemRekeyRecoveryKeyBackup**](docs/System.md#deletesystemrekeyrecoverykeybackup) | **DELETE** /sys/rekey/recovery-key-backup | Allows fetching or deleting the backup of the rotated unseal keys.
*System* | [**DeleteSystemRekeyVerify**](docs/System.md#deletesystemrekeyverify) | **DELETE** /sys/rekey/verify | Cancel any in-progress rekey verification operation.
*System* | [**ListSystemConfigUiHeaders**](docs/System.md#listsystemconfiguiheaders) | **GET** /sys/config/ui/headers/ | Return a list of configured UI headers.
*System* | [**ListSystemLeasesLookup**](docs/System.md#listsystemleaseslookup) | **GET** /sys/leases/lookup/ | Returns a list of lease ids.
*System* | [**ListSystemLeasesLookupPrefix**](docs/System.md#listsystemleaseslookupprefix) | **GET** /sys/leases/lookup/{prefix} | Returns a list of lease ids.
*System* | [**ListSystemPluginsCatalogType**](docs/System.md#listsystempluginscatalogtype) | **GET** /sys/plugins/catalog/{type} | List the plugins in the catalog.
*System* | [**ListSystemPoliciesAcl**](docs/System.md#listsystempoliciesacl) | **GET** /sys/policies/acl | List the configured access control policies.
*System* | [**ListSystemPoliciesPassword**](docs/System.md#listsystempoliciespassword) | **GET** /sys/policies/password | List the existing password policies.
*System* | [**ListSystemQuotasRateLimit**](docs/System.md#listsystemquotasratelimit) | **GET** /sys/quotas/rate-limit | 
*System* | [**ListSystemVersionHistory**](docs/System.md#listsystemversionhistory) | **GET** /sys/version-history/ | Returns map of historical version change entries
*System* | [**ReadSystemAudit**](docs/System.md#readsystemaudit) | **GET** /sys/audit | List the enabled audit devices.
*System* | [**ReadSystemAuth**](docs/System.md#readsystemauth) | **GET** /sys/auth | List the currently enabled credential backends.
*System* | [**ReadSystemAuthPath**](docs/System.md#readsystemauthpath) | **GET** /sys/auth/{path} | Read the configuration of the auth engine at the given path.
*System* | [**ReadSystemAuthPathTune**](docs/System.md#readsystemauthpathtune) | **GET** /sys/auth/{path}/tune | Reads the given auth path's configuration.
*System* | [**ReadSystemConfigAuditingRequestHeaders**](docs/System.md#readsystemconfigauditingrequestheaders) | **GET** /sys/config/auditing/request-headers | List the request headers that are configured to be audited.
*System* | [**ReadSystemConfigAuditingRequestHeadersHeader**](docs/System.md#readsystemconfigauditingrequestheadersheader) | **GET** /sys/config/auditing/request-headers/{header} | List the information for the given request header.
*System* | [**ReadSystemConfigCors**](docs/System.md#readsystemconfigcors) | **GET** /sys/config/cors | Return the current CORS settings.
*System* | [**ReadSystemConfigStateSanitized**](docs/System.md#readsystemconfigstatesanitized) | **GET** /sys/config/state/sanitized | Return a sanitized version of the Vault server configuration.
*System* | [**ReadSystemConfigUiHeadersHeader**](docs/System.md#readsystemconfiguiheadersheader) | **GET** /sys/config/ui/headers/{header} | Return the given UI header's configuration
*System* | [**ReadSystemGenerateRoot**](docs/System.md#readsystemgenerateroot) | **GET** /sys/generate-root | Read the configuration and progress of the current root generation attempt.
*System* | [**ReadSystemGenerateRootAttempt**](docs/System.md#readsystemgeneraterootattempt) | **GET** /sys/generate-root/attempt | Read the configuration and progress of the current root generation attempt.
*System* | [**ReadSystemHaStatus**](docs/System.md#readsystemhastatus) | **GET** /sys/ha-status | Check the HA status of a Vault cluster
*System* | [**ReadSystemHealth**](docs/System.md#readsystemhealth) | **GET** /sys/health | Returns the health status of Vault.
*System* | [**ReadSystemHostInfo**](docs/System.md#readsystemhostinfo) | **GET** /sys/host-info | Information about the host instance that this Vault server is running on.
*System* | [**ReadSystemInFlightReq**](docs/System.md#readsysteminflightreq) | **GET** /sys/in-flight-req | reports in-flight requests
*System* | [**ReadSystemInit**](docs/System.md#readsysteminit) | **GET** /sys/init | Returns the initialization status of Vault.
*System* | [**ReadSystemInternalCountersActivity**](docs/System.md#readsysteminternalcountersactivity) | **GET** /sys/internal/counters/activity | Report the client count metrics, for this namespace and all child namespaces.
*System* | [**ReadSystemInternalCountersActivityExport**](docs/System.md#readsysteminternalcountersactivityexport) | **GET** /sys/internal/counters/activity/export | Report the client count metrics, for this namespace and all child namespaces.
*System* | [**ReadSystemInternalCountersActivityMonthly**](docs/System.md#readsysteminternalcountersactivitymonthly) | **GET** /sys/internal/counters/activity/monthly | Report the number of clients for this month, for this namespace and all child namespaces.
*System* | [**ReadSystemInternalCountersConfig**](docs/System.md#readsysteminternalcountersconfig) | **GET** /sys/internal/counters/config | Read the client count tracking configuration.
*System* | [**ReadSystemInternalCountersEntities**](docs/System.md#readsysteminternalcountersentities) | **GET** /sys/internal/counters/entities | Backwards compatibility is not guaranteed for this API
*System* | [**ReadSystemInternalCountersRequests**](docs/System.md#readsysteminternalcountersrequests) | **GET** /sys/internal/counters/requests | Backwards compatibility is not guaranteed for this API
*System* | [**ReadSystemInternalCountersTokens**](docs/System.md#readsysteminternalcounterstokens) | **GET** /sys/internal/counters/tokens | Backwards compatibility is not guaranteed for this API
*System* | [**ReadSystemInternalSpecsOpenapi**](docs/System.md#readsysteminternalspecsopenapi) | **GET** /sys/internal/specs/openapi | Generate an OpenAPI 3 document of all mounted paths.
*System* | [**ReadSystemInternalUiFeatureFlags**](docs/System.md#readsysteminternaluifeatureflags) | **GET** /sys/internal/ui/feature-flags | Lists enabled feature flags.
*System* | [**ReadSystemInternalUiMounts**](docs/System.md#readsysteminternaluimounts) | **GET** /sys/internal/ui/mounts | Lists all enabled and visible auth and secrets mounts.
*System* | [**ReadSystemInternalUiMountsPath**](docs/System.md#readsysteminternaluimountspath) | **GET** /sys/internal/ui/mounts/{path} | Return information about the given mount.
*System* | [**ReadSystemInternalUiNamespaces**](docs/System.md#readsysteminternaluinamespaces) | **GET** /sys/internal/ui/namespaces | Backwards compatibility is not guaranteed for this API
*System* | [**ReadSystemInternalUiResultantAcl**](docs/System.md#readsysteminternaluiresultantacl) | **GET** /sys/internal/ui/resultant-acl | Backwards compatibility is not guaranteed for this API
*System* | [**ReadSystemKeyStatus**](docs/System.md#readsystemkeystatus) | **GET** /sys/key-status | Provides information about the backend encryption key.
*System* | [**ReadSystemLeader**](docs/System.md#readsystemleader) | **GET** /sys/leader | Returns the high availability status and current leader instance of Vault.
*System* | [**ReadSystemLeases**](docs/System.md#readsystemleases) | **GET** /sys/leases | List leases associated with this Vault cluster
*System* | [**ReadSystemLeasesCount**](docs/System.md#readsystemleasescount) | **GET** /sys/leases/count | Count of leases associated with this Vault cluster
*System* | [**ReadSystemMetrics**](docs/System.md#readsystemmetrics) | **GET** /sys/metrics | Export the metrics aggregated for telemetry purpose.
*System* | [**ReadSystemMonitor**](docs/System.md#readsystemmonitor) | **GET** /sys/monitor | 
*System* | [**ReadSystemMounts**](docs/System.md#readsystemmounts) | **GET** /sys/mounts | List the currently mounted backends.
*System* | [**ReadSystemMountsPath**](docs/System.md#readsystemmountspath) | **GET** /sys/mounts/{path} | Read the configuration of the secret engine at the given path.
*System* | [**ReadSystemMountsPathTune**](docs/System.md#readsystemmountspathtune) | **GET** /sys/mounts/{path}/tune | Tune backend configuration parameters for this mount.
*System* | [**ReadSystemPluginsCatalog**](docs/System.md#readsystempluginscatalog) | **GET** /sys/plugins/catalog | Lists all the plugins known to Vault
*System* | [**ReadSystemPluginsCatalogName**](docs/System.md#readsystempluginscatalogname) | **GET** /sys/plugins/catalog/{name} | Return the configuration data for the plugin with the given name.
*System* | [**ReadSystemPluginsCatalogTypeName**](docs/System.md#readsystempluginscatalogtypename) | **GET** /sys/plugins/catalog/{type}/{name} | Return the configuration data for the plugin with the given name.
*System* | [**ReadSystemPoliciesAclName**](docs/System.md#readsystempoliciesaclname) | **GET** /sys/policies/acl/{name} | Retrieve information about the named ACL policy.
*System* | [**ReadSystemPoliciesPasswordName**](docs/System.md#readsystempoliciespasswordname) | **GET** /sys/policies/password/{name} | Retrieve an existing password policy.
*System* | [**ReadSystemPoliciesPasswordNameGenerate**](docs/System.md#readsystempoliciespasswordnamegenerate) | **GET** /sys/policies/password/{name}/generate | Generate a password from an existing password policy.
*System* | [**ReadSystemPolicy**](docs/System.md#readsystempolicy) | **GET** /sys/policy | List the configured access control policies.
*System* | [**ReadSystemPolicyName**](docs/System.md#readsystempolicyname) | **GET** /sys/policy/{name} | Retrieve the policy body for the named policy.
*System* | [**ReadSystemPprof**](docs/System.md#readsystempprof) | **GET** /sys/pprof/ | Returns an HTML page listing the available profiles.
*System* | [**ReadSystemPprofAllocs**](docs/System.md#readsystempprofallocs) | **GET** /sys/pprof/allocs | Returns a sampling of all past memory allocations.
*System* | [**ReadSystemPprofBlock**](docs/System.md#readsystempprofblock) | **GET** /sys/pprof/block | Returns stack traces that led to blocking on synchronization primitives
*System* | [**ReadSystemPprofCmdline**](docs/System.md#readsystempprofcmdline) | **GET** /sys/pprof/cmdline | Returns the running program's command line.
*System* | [**ReadSystemPprofGoroutine**](docs/System.md#readsystempprofgoroutine) | **GET** /sys/pprof/goroutine | Returns stack traces of all current goroutines.
*System* | [**ReadSystemPprofHeap**](docs/System.md#readsystempprofheap) | **GET** /sys/pprof/heap | Returns a sampling of memory allocations of live object.
*System* | [**ReadSystemPprofMutex**](docs/System.md#readsystempprofmutex) | **GET** /sys/pprof/mutex | Returns stack traces of holders of contended mutexes
*System* | [**ReadSystemPprofProfile**](docs/System.md#readsystempprofprofile) | **GET** /sys/pprof/profile | Returns a pprof-formatted cpu profile payload.
*System* | [**ReadSystemPprofSymbol**](docs/System.md#readsystempprofsymbol) | **GET** /sys/pprof/symbol | Returns the program counters listed in the request.
*System* | [**ReadSystemPprofThreadcreate**](docs/System.md#readsystempprofthreadcreate) | **GET** /sys/pprof/threadcreate | Returns stack traces that led to the creation of new OS threads
*System* | [**ReadSystemPprofTrace**](docs/System.md#readsystempproftrace) | **GET** /sys/pprof/trace | Returns the execution trace in binary form.
*System* | [**ReadSystemQuotasConfig**](docs/System.md#readsystemquotasconfig) | **GET** /sys/quotas/config | 
*System* | [**ReadSystemQuotasRateLimitName**](docs/System.md#readsystemquotasratelimitname) | **GET** /sys/quotas/rate-limit/{name} | 
*System* | [**ReadSystemRaw**](docs/System.md#readsystemraw) | **GET** /sys/raw | Read the value of the key at the given path.
*System* | [**ReadSystemRawPath**](docs/System.md#readsystemrawpath) | **GET** /sys/raw/{path} | Read the value of the key at the given path.
*System* | [**ReadSystemRekeyBackup**](docs/System.md#readsystemrekeybackup) | **GET** /sys/rekey/backup | Return the backup copy of PGP-encrypted unseal keys.
*System* | [**ReadSystemRekeyInit**](docs/System.md#readsystemrekeyinit) | **GET** /sys/rekey/init | Reads the configuration and progress of the current rekey attempt.
*System* | [**ReadSystemRekeyRecoveryKeyBackup**](docs/System.md#readsystemrekeyrecoverykeybackup) | **GET** /sys/rekey/recovery-key-backup | Allows fetching or deleting the backup of the rotated unseal keys.
*System* | [**ReadSystemRekeyVerify**](docs/System.md#readsystemrekeyverify) | **GET** /sys/rekey/verify | Read the configuration and progress of the current rekey verification attempt.
*System* | [**ReadSystemRemountStatusMigrationId**](docs/System.md#readsystemremountstatusmigrationid) | **GET** /sys/remount/status/{migration_id} | Check status of a mount migration
*System* | [**ReadSystemReplicationStatus**](docs/System.md#readsystemreplicationstatus) | **GET** /sys/replication/status | 
*System* | [**ReadSystemRotateConfig**](docs/System.md#readsystemrotateconfig) | **GET** /sys/rotate/config | 
*System* | [**ReadSystemSealStatus**](docs/System.md#readsystemsealstatus) | **GET** /sys/seal-status | Check the seal status of a Vault.
*System* | [**ReadSystemWrappingLookup**](docs/System.md#readsystemwrappinglookup) | **GET** /sys/wrapping/lookup | Look up wrapping properties for the requester's token.
*System* | [**UpdateSystemAuditHashPath**](docs/System.md#updatesystemaudithashpath) | **POST** /sys/audit-hash/{path} | The hash of the given string via the given audit backend
*System* | [**UpdateSystemAuditPath**](docs/System.md#updatesystemauditpath) | **POST** /sys/audit/{path} | Enable a new audit device at the supplied path.
*System* | [**UpdateSystemAuthPath**](docs/System.md#updatesystemauthpath) | **POST** /sys/auth/{path} | Enables a new auth method.
*System* | [**UpdateSystemAuthPathTune**](docs/System.md#updatesystemauthpathtune) | **POST** /sys/auth/{path}/tune | Tune configuration parameters for a given auth path.
*System* | [**UpdateSystemCapabilities**](docs/System.md#updatesystemcapabilities) | **POST** /sys/capabilities | Fetches the capabilities of the given token on the given path.
*System* | [**UpdateSystemCapabilitiesAccessor**](docs/System.md#updatesystemcapabilitiesaccessor) | **POST** /sys/capabilities-accessor | Fetches the capabilities of the token associated with the given token, on the given path.
*System* | [**UpdateSystemCapabilitiesSelf**](docs/System.md#updatesystemcapabilitiesself) | **POST** /sys/capabilities-self | Fetches the capabilities of the given token on the given path.
*System* | [**UpdateSystemConfigAuditingRequestHeadersHeader**](docs/System.md#updatesystemconfigauditingrequestheadersheader) | **POST** /sys/config/auditing/request-headers/{header} | Enable auditing of a header.
*System* | [**UpdateSystemConfigCors**](docs/System.md#updatesystemconfigcors) | **POST** /sys/config/cors | Configure the CORS settings.
*System* | [**UpdateSystemConfigReloadSubsystem**](docs/System.md#updatesystemconfigreloadsubsystem) | **POST** /sys/config/reload/{subsystem} | Reload the given subsystem
*System* | [**UpdateSystemConfigUiHeadersHeader**](docs/System.md#updatesystemconfiguiheadersheader) | **POST** /sys/config/ui/headers/{header} | Configure the values to be returned for the UI header.
*System* | [**UpdateSystemGenerateRoot**](docs/System.md#updatesystemgenerateroot) | **POST** /sys/generate-root | Initializes a new root generation attempt.
*System* | [**UpdateSystemGenerateRootAttempt**](docs/System.md#updatesystemgeneraterootattempt) | **POST** /sys/generate-root/attempt | Initializes a new root generation attempt.
*System* | [**UpdateSystemGenerateRootUpdate**](docs/System.md#updatesystemgeneraterootupdate) | **POST** /sys/generate-root/update | Enter a single unseal key share to progress the root generation attempt.
*System* | [**UpdateSystemInit**](docs/System.md#updatesysteminit) | **POST** /sys/init | Initialize a new Vault.
*System* | [**UpdateSystemInternalCountersConfig**](docs/System.md#updatesysteminternalcountersconfig) | **POST** /sys/internal/counters/config | Enable or disable collection of client count, set retention period, or set default reporting period.
*System* | [**UpdateSystemLeasesLookup**](docs/System.md#updatesystemleaseslookup) | **POST** /sys/leases/lookup | Retrieve lease metadata.
*System* | [**UpdateSystemLeasesRenew**](docs/System.md#updatesystemleasesrenew) | **POST** /sys/leases/renew | Renews a lease, requesting to extend the lease.
*System* | [**UpdateSystemLeasesRenewUrlLeaseId**](docs/System.md#updatesystemleasesrenewurlleaseid) | **POST** /sys/leases/renew/{url_lease_id} | Renews a lease, requesting to extend the lease.
*System* | [**UpdateSystemLeasesRevoke**](docs/System.md#updatesystemleasesrevoke) | **POST** /sys/leases/revoke | Revokes a lease immediately.
*System* | [**UpdateSystemLeasesRevokeForcePrefix**](docs/System.md#updatesystemleasesrevokeforceprefix) | **POST** /sys/leases/revoke-force/{prefix} | Revokes all secrets or tokens generated under a given prefix immediately
*System* | [**UpdateSystemLeasesRevokePrefixPrefix**](docs/System.md#updatesystemleasesrevokeprefixprefix) | **POST** /sys/leases/revoke-prefix/{prefix} | Revokes all secrets (via a lease ID prefix) or tokens (via the tokens' path property) generated under a given prefix immediately.
*System* | [**UpdateSystemLeasesRevokeUrlLeaseId**](docs/System.md#updatesystemleasesrevokeurlleaseid) | **POST** /sys/leases/revoke/{url_lease_id} | Revokes a lease immediately.
*System* | [**UpdateSystemLeasesTidy**](docs/System.md#updatesystemleasestidy) | **POST** /sys/leases/tidy | This endpoint performs cleanup tasks that can be run if certain error conditions have occurred.
*System* | [**UpdateSystemLoggers**](docs/System.md#updatesystemloggers) | **POST** /sys/loggers | Modify the log level for all existing loggers.
*System* | [**UpdateSystemLoggersName**](docs/System.md#updatesystemloggersname) | **POST** /sys/loggers/{name} | Modify the log level of a single logger.
*System* | [**UpdateSystemMfaValidate**](docs/System.md#updatesystemmfavalidate) | **POST** /sys/mfa/validate | Validates the login for the given MFA methods. Upon successful validation, it returns an auth response containing the client token
*System* | [**UpdateSystemMountsPath**](docs/System.md#updatesystemmountspath) | **POST** /sys/mounts/{path} | Enable a new secrets engine at the given path.
*System* | [**UpdateSystemMountsPathTune**](docs/System.md#updatesystemmountspathtune) | **POST** /sys/mounts/{path}/tune | Tune backend configuration parameters for this mount.
*System* | [**UpdateSystemPluginsCatalogName**](docs/System.md#updatesystempluginscatalogname) | **POST** /sys/plugins/catalog/{name} | Register a new plugin, or updates an existing one with the supplied name.
*System* | [**UpdateSystemPluginsCatalogTypeName**](docs/System.md#updatesystempluginscatalogtypename) | **POST** /sys/plugins/catalog/{type}/{name} | Register a new plugin, or updates an existing one with the supplied name.
*System* | [**UpdateSystemPluginsReloadBackend**](docs/System.md#updatesystempluginsreloadbackend) | **POST** /sys/plugins/reload/backend | Reload mounted plugin backends.
*System* | [**UpdateSystemPoliciesAclName**](docs/System.md#updatesystempoliciesaclname) | **POST** /sys/policies/acl/{name} | Add a new or update an existing ACL policy.
*System* | [**UpdateSystemPoliciesPasswordName**](docs/System.md#updatesystempoliciespasswordname) | **POST** /sys/policies/password/{name} | Add a new or update an existing password policy.
*System* | [**UpdateSystemPolicyName**](docs/System.md#updatesystempolicyname) | **POST** /sys/policy/{name} | Add a new or update an existing policy.
*System* | [**UpdateSystemQuotasConfig**](docs/System.md#updatesystemquotasconfig) | **POST** /sys/quotas/config | 
*System* | [**UpdateSystemQuotasRateLimitName**](docs/System.md#updatesystemquotasratelimitname) | **POST** /sys/quotas/rate-limit/{name} | 
*System* | [**UpdateSystemRaw**](docs/System.md#updatesystemraw) | **POST** /sys/raw | Update the value of the key at the given path.
*System* | [**UpdateSystemRawPath**](docs/System.md#updatesystemrawpath) | **POST** /sys/raw/{path} | Update the value of the key at the given path.
*System* | [**UpdateSystemRekeyInit**](docs/System.md#updatesystemrekeyinit) | **POST** /sys/rekey/init | Initializes a new rekey attempt.
*System* | [**UpdateSystemRekeyUpdate**](docs/System.md#updatesystemrekeyupdate) | **POST** /sys/rekey/update | Enter a single unseal key share to progress the rekey of the Vault.
*System* | [**UpdateSystemRekeyVerify**](docs/System.md#updatesystemrekeyverify) | **POST** /sys/rekey/verify | Enter a single new key share to progress the rekey verification operation.
*System* | [**UpdateSystemRemount**](docs/System.md#updatesystemremount) | **POST** /sys/remount | Initiate a mount migration
*System* | [**UpdateSystemRenew**](docs/System.md#updatesystemrenew) | **POST** /sys/renew | Renews a lease, requesting to extend the lease.
*System* | [**UpdateSystemRenewUrlLeaseId**](docs/System.md#updatesystemrenewurlleaseid) | **POST** /sys/renew/{url_lease_id} | Renews a lease, requesting to extend the lease.
*System* | [**UpdateSystemRevoke**](docs/System.md#updatesystemrevoke) | **POST** /sys/revoke | Revokes a lease immediately.
*System* | [**UpdateSystemRevokeForcePrefix**](docs/System.md#updatesystemrevokeforceprefix) | **POST** /sys/revoke-force/{prefix} | Revokes all secrets or tokens generated under a given prefix immediately
*System* | [**UpdateSystemRevokePrefixPrefix**](docs/System.md#updatesystemrevokeprefixprefix) | **POST** /sys/revoke-prefix/{prefix} | Revokes all secrets (via a lease ID prefix) or tokens (via the tokens' path property) generated under a given prefix immediately.
*System* | [**UpdateSystemRevokeUrlLeaseId**](docs/System.md#updatesystemrevokeurlleaseid) | **POST** /sys/revoke/{url_lease_id} | Revokes a lease immediately.
*System* | [**UpdateSystemRotate**](docs/System.md#updatesystemrotate) | **POST** /sys/rotate | Rotates the backend encryption key used to persist data.
*System* | [**UpdateSystemRotateConfig**](docs/System.md#updatesystemrotateconfig) | **POST** /sys/rotate/config | 
*System* | [**UpdateSystemSeal**](docs/System.md#updatesystemseal) | **POST** /sys/seal | Seal the Vault.
*System* | [**UpdateSystemStepDown**](docs/System.md#updatesystemstepdown) | **POST** /sys/step-down | Cause the node to give up active status.
*System* | [**UpdateSystemToolsHash**](docs/System.md#updatesystemtoolshash) | **POST** /sys/tools/hash | Generate a hash sum for input data
*System* | [**UpdateSystemToolsHashUrlalgorithm**](docs/System.md#updatesystemtoolshashurlalgorithm) | **POST** /sys/tools/hash/{urlalgorithm} | Generate a hash sum for input data
*System* | [**UpdateSystemToolsRandom**](docs/System.md#updatesystemtoolsrandom) | **POST** /sys/tools/random | Generate random bytes
*System* | [**UpdateSystemToolsRandomSource**](docs/System.md#updatesystemtoolsrandomsource) | **POST** /sys/tools/random/{source} | Generate random bytes
*System* | [**UpdateSystemToolsRandomSourceUrlbytes**](docs/System.md#updatesystemtoolsrandomsourceurlbytes) | **POST** /sys/tools/random/{source}/{urlbytes} | Generate random bytes
*System* | [**UpdateSystemToolsRandomUrlbytes**](docs/System.md#updatesystemtoolsrandomurlbytes) | **POST** /sys/tools/random/{urlbytes} | Generate random bytes
*System* | [**UpdateSystemUnseal**](docs/System.md#updatesystemunseal) | **POST** /sys/unseal | Unseal the Vault.
*System* | [**UpdateSystemWrappingLookup**](docs/System.md#updatesystemwrappinglookup) | **POST** /sys/wrapping/lookup | Look up wrapping properties for the given token.
*System* | [**UpdateSystemWrappingRewrap**](docs/System.md#updatesystemwrappingrewrap) | **POST** /sys/wrapping/rewrap | Rotates a response-wrapped token.
*System* | [**UpdateSystemWrappingUnwrap**](docs/System.md#updatesystemwrappingunwrap) | **POST** /sys/wrapping/unwrap | Unwraps a response-wrapped token.
*System* | [**UpdateSystemWrappingWrap**](docs/System.md#updatesystemwrappingwrap) | **POST** /sys/wrapping/wrap | Response-wraps an arbitrary JSON object.


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
 - [Model.LdapLibraryCheckInRequest](docs/LdapLibraryCheckInRequest.md)
 - [Model.LdapLibraryCheckOutRequest](docs/LdapLibraryCheckOutRequest.md)
 - [Model.LdapLibraryManageCheckInRequest](docs/LdapLibraryManageCheckInRequest.md)
 - [Model.LdapLibraryRequest](docs/LdapLibraryRequest.md)
 - [Model.LdapLoginRequest](docs/LdapLoginRequest.md)
 - [Model.LdapRoleRequest](docs/LdapRoleRequest.md)
 - [Model.LdapStaticRoleRequest](docs/LdapStaticRoleRequest.md)
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
 - [Model.OpenldapLibraryCheckInRequest](docs/OpenldapLibraryCheckInRequest.md)
 - [Model.OpenldapLibraryCheckOutRequest](docs/OpenldapLibraryCheckOutRequest.md)
 - [Model.OpenldapLibraryManageCheckInRequest](docs/OpenldapLibraryManageCheckInRequest.md)
 - [Model.OpenldapLibraryRequest](docs/OpenldapLibraryRequest.md)
 - [Model.OpenldapRoleRequest](docs/OpenldapRoleRequest.md)
 - [Model.OpenldapStaticRoleRequest](docs/OpenldapStaticRoleRequest.md)
 - [Model.PkiBundleRequest](docs/PkiBundleRequest.md)
 - [Model.PkiCertRequest](docs/PkiCertRequest.md)
 - [Model.PkiConfigAutoTidyRequest](docs/PkiConfigAutoTidyRequest.md)
 - [Model.PkiConfigCaRequest](docs/PkiConfigCaRequest.md)
 - [Model.PkiConfigCrlRequest](docs/PkiConfigCrlRequest.md)
 - [Model.PkiConfigIssuersRequest](docs/PkiConfigIssuersRequest.md)
 - [Model.PkiConfigKeysRequest](docs/PkiConfigKeysRequest.md)
 - [Model.PkiConfigUrlsRequest](docs/PkiConfigUrlsRequest.md)
 - [Model.PkiIntermediateCrossSignRequest](docs/PkiIntermediateCrossSignRequest.md)
 - [Model.PkiIntermediateGenerateRequest](docs/PkiIntermediateGenerateRequest.md)
 - [Model.PkiIntermediateSetSignedRequest](docs/PkiIntermediateSetSignedRequest.md)
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
 - [Model.PkiRevokeWithKeyRequest](docs/PkiRevokeWithKeyRequest.md)
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
 - [Model.SshIssueRequest](docs/SshIssueRequest.md)
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
 - [Model.SystemLoggersRequest](docs/SystemLoggersRequest.md)
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
 - [Model.TokenCreateOrphanRequest](docs/TokenCreateOrphanRequest.md)
 - [Model.TokenCreateRequest](docs/TokenCreateRequest.md)
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

[artifactory]:                  https://artifactory.hashicorp.engineering/ui/repos/tree/General/vault-devex-nuget-local
[hashicorp]:                    https://www.hashicorp.com/
[vault]:                        https://www.vaultproject.io/
[openapi-spec]:                 openapi.json
[openapi-generator]:	        https://openapi-generator.tech/docs/generators/csharp-netcore
[polly]:                        http://www.thepollyproject.org/
[http-client-handler-docs]:     https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclienthandler?view=net-6.0
