# Vault.Api.Auth

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteApproleRoleRoleName**](Auth.md#deleteapprolerolerolename) | **DELETE** /auth/{mount_path}/role/{role_name} | Register an role with the backend.
[**DeleteApproleRoleRoleNameBindSecretId**](Auth.md#deleteapprolerolerolenamebindsecretid) | **DELETE** /auth/{mount_path}/role/{role_name}/bind-secret-id | Impose secret_id to be presented during login using this role.
[**DeleteApproleRoleRoleNameBoundCidrList**](Auth.md#deleteapprolerolerolenameboundcidrlist) | **DELETE** /auth/{mount_path}/role/{role_name}/bound-cidr-list | Deprecated: Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
[**DeleteApproleRoleRoleNamePeriod**](Auth.md#deleteapprolerolerolenameperiod) | **DELETE** /auth/{mount_path}/role/{role_name}/period | Updates the value of &#39;period&#39; on the role
[**DeleteApproleRoleRoleNamePolicies**](Auth.md#deleteapprolerolerolenamepolicies) | **DELETE** /auth/{mount_path}/role/{role_name}/policies | Policies of the role.
[**DeleteApproleRoleRoleNameSecretIdAccessorDestroy**](Auth.md#deleteapprolerolerolenamesecretidaccessordestroy) | **DELETE** /auth/{mount_path}/role/{role_name}/secret-id-accessor/destroy | 
[**DeleteApproleRoleRoleNameSecretIdBoundCidrs**](Auth.md#deleteapprolerolerolenamesecretidboundcidrs) | **DELETE** /auth/{mount_path}/role/{role_name}/secret-id-bound-cidrs | Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
[**DeleteApproleRoleRoleNameSecretIdDestroy**](Auth.md#deleteapprolerolerolenamesecretiddestroy) | **DELETE** /auth/{mount_path}/role/{role_name}/secret-id/destroy | Invalidate an issued secret_id
[**DeleteApproleRoleRoleNameSecretIdNumUses**](Auth.md#deleteapprolerolerolenamesecretidnumuses) | **DELETE** /auth/{mount_path}/role/{role_name}/secret-id-num-uses | Use limit of the SecretID generated against the role.
[**DeleteApproleRoleRoleNameSecretIdTtl**](Auth.md#deleteapprolerolerolenamesecretidttl) | **DELETE** /auth/{mount_path}/role/{role_name}/secret-id-ttl | Duration in seconds of the SecretID generated against the role.
[**DeleteApproleRoleRoleNameTokenBoundCidrs**](Auth.md#deleteapprolerolerolenametokenboundcidrs) | **DELETE** /auth/{mount_path}/role/{role_name}/token-bound-cidrs | Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token.
[**DeleteApproleRoleRoleNameTokenMaxTtl**](Auth.md#deleteapprolerolerolenametokenmaxttl) | **DELETE** /auth/{mount_path}/role/{role_name}/token-max-ttl | Duration in seconds, the maximum lifetime of the tokens issued by using the SecretIDs that were generated against this role, after which the tokens are not allowed to be renewed.
[**DeleteApproleRoleRoleNameTokenNumUses**](Auth.md#deleteapprolerolerolenametokennumuses) | **DELETE** /auth/{mount_path}/role/{role_name}/token-num-uses | Number of times issued tokens can be used
[**DeleteApproleRoleRoleNameTokenTtl**](Auth.md#deleteapprolerolerolenametokenttl) | **DELETE** /auth/{mount_path}/role/{role_name}/token-ttl | Duration in seconds, the lifetime of the token issued by using the SecretID that is generated against this role, before which the token needs to be renewed.
[**DeleteAwsConfigCertificateCertName**](Auth.md#deleteawsconfigcertificatecertname) | **DELETE** /auth/{mount_path}/config/certificate/{cert_name} | 
[**DeleteAwsConfigClient**](Auth.md#deleteawsconfigclient) | **DELETE** /auth/{mount_path}/config/client | 
[**DeleteAwsConfigStsAccountId**](Auth.md#deleteawsconfigstsaccountid) | **DELETE** /auth/{mount_path}/config/sts/{account_id} | 
[**DeleteAwsConfigTidyIdentityAccesslist**](Auth.md#deleteawsconfigtidyidentityaccesslist) | **DELETE** /auth/{mount_path}/config/tidy/identity-accesslist | 
[**DeleteAwsConfigTidyIdentityWhitelist**](Auth.md#deleteawsconfigtidyidentitywhitelist) | **DELETE** /auth/{mount_path}/config/tidy/identity-whitelist | 
[**DeleteAwsConfigTidyRoletagBlacklist**](Auth.md#deleteawsconfigtidyroletagblacklist) | **DELETE** /auth/{mount_path}/config/tidy/roletag-blacklist | 
[**DeleteAwsConfigTidyRoletagDenylist**](Auth.md#deleteawsconfigtidyroletagdenylist) | **DELETE** /auth/{mount_path}/config/tidy/roletag-denylist | 
[**DeleteAwsIdentityAccesslistInstanceId**](Auth.md#deleteawsidentityaccesslistinstanceid) | **DELETE** /auth/{mount_path}/identity-accesslist/{instance_id} | 
[**DeleteAwsIdentityWhitelistInstanceId**](Auth.md#deleteawsidentitywhitelistinstanceid) | **DELETE** /auth/{mount_path}/identity-whitelist/{instance_id} | 
[**DeleteAwsRoleRole**](Auth.md#deleteawsrolerole) | **DELETE** /auth/{mount_path}/role/{role} | 
[**DeleteAwsRoletagBlacklistRoleTag**](Auth.md#deleteawsroletagblacklistroletag) | **DELETE** /auth/{mount_path}/roletag-blacklist/{role_tag} | 
[**DeleteAwsRoletagDenylistRoleTag**](Auth.md#deleteawsroletagdenylistroletag) | **DELETE** /auth/{mount_path}/roletag-denylist/{role_tag} | 
[**DeleteCertCertsName**](Auth.md#deletecertcertsname) | **DELETE** /auth/{mount_path}/certs/{name} | Manage trusted certificates used for authentication.
[**DeleteCertCrlsName**](Auth.md#deletecertcrlsname) | **DELETE** /auth/{mount_path}/crls/{name} | Manage Certificate Revocation Lists checked during authentication.
[**DeleteCfRolesRole**](Auth.md#deletecfrolesrole) | **DELETE** /auth/{mount_path}/roles/{role} | 
[**DeleteGithubMapTeamsKey**](Auth.md#deletegithubmapteamskey) | **DELETE** /auth/{mount_path}/map/teams/{key} | Read/write/delete a single teams mapping
[**DeleteGithubMapUsersKey**](Auth.md#deletegithubmapuserskey) | **DELETE** /auth/{mount_path}/map/users/{key} | Read/write/delete a single users mapping
[**DeleteKerberosGroupsName**](Auth.md#deletekerberosgroupsname) | **DELETE** /auth/{mount_path}/groups/{name} | 
[**DeleteOidcRoleName**](Auth.md#deleteoidcrolename) | **DELETE** /auth/{mount_path}/role/{name} | Delete an existing role.
[**DeleteRadiusUsersName**](Auth.md#deleteradiususersname) | **DELETE** /auth/{mount_path}/users/{name} | Manage users allowed to authenticate.
[**DeleteTokenRolesRoleName**](Auth.md#deletetokenrolesrolename) | **DELETE** /auth/{mount_path}/roles/{role_name} | 
[**DeleteUserpassUsersUsername**](Auth.md#deleteuserpassusersusername) | **DELETE** /auth/{mount_path}/users/{username} | Manage users allowed to authenticate.
[**ListApproleRoleRoleNameSecretId**](Auth.md#listapprolerolerolenamesecretid) | **GET** /auth/{mount_path}/role/{role_name}/secret-id | Generate a SecretID against this role.
[**ListAwsConfigCertificates**](Auth.md#listawsconfigcertificates) | **GET** /auth/{mount_path}/config/certificates | 
[**ListAwsConfigSts**](Auth.md#listawsconfigsts) | **GET** /auth/{mount_path}/config/sts | 
[**ListAwsIdentityAccesslist**](Auth.md#listawsidentityaccesslist) | **GET** /auth/{mount_path}/identity-accesslist | 
[**ListAwsIdentityWhitelist**](Auth.md#listawsidentitywhitelist) | **GET** /auth/{mount_path}/identity-whitelist | 
[**ListAwsRoletagBlacklist**](Auth.md#listawsroletagblacklist) | **GET** /auth/{mount_path}/roletag-blacklist | 
[**ListAwsRoletagDenylist**](Auth.md#listawsroletagdenylist) | **GET** /auth/{mount_path}/roletag-denylist | 
[**ListCertCerts**](Auth.md#listcertcerts) | **GET** /auth/{mount_path}/certs | Manage trusted certificates used for authentication.
[**ListGcpRoles**](Auth.md#listgcproles) | **GET** /auth/{mount_path}/roles | Lists all the roles that are registered with Vault.
[**ListKerberosGroups**](Auth.md#listkerberosgroups) | **GET** /auth/{mount_path}/groups | 
[**ListOidcRole**](Auth.md#listoidcrole) | **GET** /auth/{mount_path}/role | Lists all the roles registered with the backend.
[**ListTokenAccessors**](Auth.md#listtokenaccessors) | **GET** /auth/{mount_path}/accessors/ | List token accessors, which can then be be used to iterate and discover their properties or revoke them. Because this can be used to cause a denial of service, this endpoint requires &#39;sudo&#39; capability in addition to &#39;list&#39;.
[**ListUserpassUsers**](Auth.md#listuserpassusers) | **GET** /auth/{mount_path}/users | Manage users allowed to authenticate.
[**ReadApproleRoleRoleName**](Auth.md#readapprolerolerolename) | **GET** /auth/{mount_path}/role/{role_name} | Register an role with the backend.
[**ReadApproleRoleRoleNameBindSecretId**](Auth.md#readapprolerolerolenamebindsecretid) | **GET** /auth/{mount_path}/role/{role_name}/bind-secret-id | Impose secret_id to be presented during login using this role.
[**ReadApproleRoleRoleNameBoundCidrList**](Auth.md#readapprolerolerolenameboundcidrlist) | **GET** /auth/{mount_path}/role/{role_name}/bound-cidr-list | Deprecated: Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
[**ReadApproleRoleRoleNameLocalSecretIds**](Auth.md#readapprolerolerolenamelocalsecretids) | **GET** /auth/{mount_path}/role/{role_name}/local-secret-ids | Enables cluster local secret IDs
[**ReadApproleRoleRoleNamePeriod**](Auth.md#readapprolerolerolenameperiod) | **GET** /auth/{mount_path}/role/{role_name}/period | Updates the value of &#39;period&#39; on the role
[**ReadApproleRoleRoleNamePolicies**](Auth.md#readapprolerolerolenamepolicies) | **GET** /auth/{mount_path}/role/{role_name}/policies | Policies of the role.
[**ReadApproleRoleRoleNameRoleId**](Auth.md#readapprolerolerolenameroleid) | **GET** /auth/{mount_path}/role/{role_name}/role-id | Returns the &#39;role_id&#39; of the role.
[**ReadApproleRoleRoleNameSecretIdBoundCidrs**](Auth.md#readapprolerolerolenamesecretidboundcidrs) | **GET** /auth/{mount_path}/role/{role_name}/secret-id-bound-cidrs | Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
[**ReadApproleRoleRoleNameSecretIdNumUses**](Auth.md#readapprolerolerolenamesecretidnumuses) | **GET** /auth/{mount_path}/role/{role_name}/secret-id-num-uses | Use limit of the SecretID generated against the role.
[**ReadApproleRoleRoleNameSecretIdTtl**](Auth.md#readapprolerolerolenamesecretidttl) | **GET** /auth/{mount_path}/role/{role_name}/secret-id-ttl | Duration in seconds of the SecretID generated against the role.
[**ReadApproleRoleRoleNameTokenBoundCidrs**](Auth.md#readapprolerolerolenametokenboundcidrs) | **GET** /auth/{mount_path}/role/{role_name}/token-bound-cidrs | Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token.
[**ReadApproleRoleRoleNameTokenMaxTtl**](Auth.md#readapprolerolerolenametokenmaxttl) | **GET** /auth/{mount_path}/role/{role_name}/token-max-ttl | Duration in seconds, the maximum lifetime of the tokens issued by using the SecretIDs that were generated against this role, after which the tokens are not allowed to be renewed.
[**ReadApproleRoleRoleNameTokenNumUses**](Auth.md#readapprolerolerolenametokennumuses) | **GET** /auth/{mount_path}/role/{role_name}/token-num-uses | Number of times issued tokens can be used
[**ReadApproleRoleRoleNameTokenTtl**](Auth.md#readapprolerolerolenametokenttl) | **GET** /auth/{mount_path}/role/{role_name}/token-ttl | Duration in seconds, the lifetime of the token issued by using the SecretID that is generated against this role, before which the token needs to be renewed.
[**ReadAwsConfigCertificateCertName**](Auth.md#readawsconfigcertificatecertname) | **GET** /auth/{mount_path}/config/certificate/{cert_name} | 
[**ReadAwsConfigClient**](Auth.md#readawsconfigclient) | **GET** /auth/{mount_path}/config/client | 
[**ReadAwsConfigIdentity**](Auth.md#readawsconfigidentity) | **GET** /auth/{mount_path}/config/identity | 
[**ReadAwsConfigStsAccountId**](Auth.md#readawsconfigstsaccountid) | **GET** /auth/{mount_path}/config/sts/{account_id} | 
[**ReadAwsConfigTidyIdentityAccesslist**](Auth.md#readawsconfigtidyidentityaccesslist) | **GET** /auth/{mount_path}/config/tidy/identity-accesslist | 
[**ReadAwsConfigTidyIdentityWhitelist**](Auth.md#readawsconfigtidyidentitywhitelist) | **GET** /auth/{mount_path}/config/tidy/identity-whitelist | 
[**ReadAwsConfigTidyRoletagBlacklist**](Auth.md#readawsconfigtidyroletagblacklist) | **GET** /auth/{mount_path}/config/tidy/roletag-blacklist | 
[**ReadAwsConfigTidyRoletagDenylist**](Auth.md#readawsconfigtidyroletagdenylist) | **GET** /auth/{mount_path}/config/tidy/roletag-denylist | 
[**ReadAwsIdentityAccesslistInstanceId**](Auth.md#readawsidentityaccesslistinstanceid) | **GET** /auth/{mount_path}/identity-accesslist/{instance_id} | 
[**ReadAwsIdentityWhitelistInstanceId**](Auth.md#readawsidentitywhitelistinstanceid) | **GET** /auth/{mount_path}/identity-whitelist/{instance_id} | 
[**ReadAwsRoleRole**](Auth.md#readawsrolerole) | **GET** /auth/{mount_path}/role/{role} | 
[**ReadAwsRoletagBlacklistRoleTag**](Auth.md#readawsroletagblacklistroletag) | **GET** /auth/{mount_path}/roletag-blacklist/{role_tag} | 
[**ReadAwsRoletagDenylistRoleTag**](Auth.md#readawsroletagdenylistroletag) | **GET** /auth/{mount_path}/roletag-denylist/{role_tag} | 
[**ReadCertCertsName**](Auth.md#readcertcertsname) | **GET** /auth/{mount_path}/certs/{name} | Manage trusted certificates used for authentication.
[**ReadCertCrlsName**](Auth.md#readcertcrlsname) | **GET** /auth/{mount_path}/crls/{name} | Manage Certificate Revocation Lists checked during authentication.
[**ReadCfRolesRole**](Auth.md#readcfrolesrole) | **GET** /auth/{mount_path}/roles/{role} | 
[**ReadGithubMapTeams**](Auth.md#readgithubmapteams) | **GET** /auth/{mount_path}/map/teams | Read mappings for teams
[**ReadGithubMapTeamsKey**](Auth.md#readgithubmapteamskey) | **GET** /auth/{mount_path}/map/teams/{key} | Read/write/delete a single teams mapping
[**ReadGithubMapUsers**](Auth.md#readgithubmapusers) | **GET** /auth/{mount_path}/map/users | Read mappings for users
[**ReadGithubMapUsersKey**](Auth.md#readgithubmapuserskey) | **GET** /auth/{mount_path}/map/users/{key} | Read/write/delete a single users mapping
[**ReadKerberosConfigLdap**](Auth.md#readkerberosconfigldap) | **GET** /auth/{mount_path}/config/ldap | 
[**ReadKerberosGroupsName**](Auth.md#readkerberosgroupsname) | **GET** /auth/{mount_path}/groups/{name} | 
[**ReadOidcConfig**](Auth.md#readoidcconfig) | **GET** /auth/{mount_path}/config | Read the current JWT authentication backend configuration.
[**ReadOidcOidcCallback**](Auth.md#readoidcoidccallback) | **GET** /auth/{mount_path}/oidc/callback | Callback endpoint to complete an OIDC login.
[**ReadOidcRoleName**](Auth.md#readoidcrolename) | **GET** /auth/{mount_path}/role/{name} | Read an existing role.
[**ReadOktaVerifyNonce**](Auth.md#readoktaverifynonce) | **GET** /auth/{mount_path}/verify/{nonce} | 
[**ReadRadiusUsersName**](Auth.md#readradiususersname) | **GET** /auth/{mount_path}/users/{name} | Manage users allowed to authenticate.
[**ReadTokenLookup**](Auth.md#readtokenlookup) | **GET** /auth/{mount_path}/lookup | This endpoint will lookup a token and its properties.
[**ReadTokenLookupSelf**](Auth.md#readtokenlookupself) | **GET** /auth/{mount_path}/lookup-self | This endpoint will lookup a token and its properties.
[**ReadTokenRolesRoleName**](Auth.md#readtokenrolesrolename) | **GET** /auth/{mount_path}/roles/{role_name} | 
[**ReadUserpassUsersUsername**](Auth.md#readuserpassusersusername) | **GET** /auth/{mount_path}/users/{username} | Manage users allowed to authenticate.
[**UpdateApproleRoleRoleName**](Auth.md#updateapprolerolerolename) | **POST** /auth/{mount_path}/role/{role_name} | Register an role with the backend.
[**UpdateApproleRoleRoleNameBindSecretId**](Auth.md#updateapprolerolerolenamebindsecretid) | **POST** /auth/{mount_path}/role/{role_name}/bind-secret-id | Impose secret_id to be presented during login using this role.
[**UpdateApproleRoleRoleNameBoundCidrList**](Auth.md#updateapprolerolerolenameboundcidrlist) | **POST** /auth/{mount_path}/role/{role_name}/bound-cidr-list | Deprecated: Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
[**UpdateApproleRoleRoleNameCustomSecretId**](Auth.md#updateapprolerolerolenamecustomsecretid) | **POST** /auth/{mount_path}/role/{role_name}/custom-secret-id | Assign a SecretID of choice against the role.
[**UpdateApproleRoleRoleNamePeriod**](Auth.md#updateapprolerolerolenameperiod) | **POST** /auth/{mount_path}/role/{role_name}/period | Updates the value of &#39;period&#39; on the role
[**UpdateApproleRoleRoleNamePolicies**](Auth.md#updateapprolerolerolenamepolicies) | **POST** /auth/{mount_path}/role/{role_name}/policies | Policies of the role.
[**UpdateApproleRoleRoleNameRoleId**](Auth.md#updateapprolerolerolenameroleid) | **POST** /auth/{mount_path}/role/{role_name}/role-id | Returns the &#39;role_id&#39; of the role.
[**UpdateApproleRoleRoleNameSecretId**](Auth.md#updateapprolerolerolenamesecretid) | **POST** /auth/{mount_path}/role/{role_name}/secret-id | Generate a SecretID against this role.
[**UpdateApproleRoleRoleNameSecretIdAccessorDestroy**](Auth.md#updateapprolerolerolenamesecretidaccessordestroy) | **POST** /auth/{mount_path}/role/{role_name}/secret-id-accessor/destroy | 
[**UpdateApproleRoleRoleNameSecretIdAccessorLookup**](Auth.md#updateapprolerolerolenamesecretidaccessorlookup) | **POST** /auth/{mount_path}/role/{role_name}/secret-id-accessor/lookup | 
[**UpdateApproleRoleRoleNameSecretIdBoundCidrs**](Auth.md#updateapprolerolerolenamesecretidboundcidrs) | **POST** /auth/{mount_path}/role/{role_name}/secret-id-bound-cidrs | Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
[**UpdateApproleRoleRoleNameSecretIdDestroy**](Auth.md#updateapprolerolerolenamesecretiddestroy) | **POST** /auth/{mount_path}/role/{role_name}/secret-id/destroy | Invalidate an issued secret_id
[**UpdateApproleRoleRoleNameSecretIdLookup**](Auth.md#updateapprolerolerolenamesecretidlookup) | **POST** /auth/{mount_path}/role/{role_name}/secret-id/lookup | Read the properties of an issued secret_id
[**UpdateApproleRoleRoleNameSecretIdNumUses**](Auth.md#updateapprolerolerolenamesecretidnumuses) | **POST** /auth/{mount_path}/role/{role_name}/secret-id-num-uses | Use limit of the SecretID generated against the role.
[**UpdateApproleRoleRoleNameSecretIdTtl**](Auth.md#updateapprolerolerolenamesecretidttl) | **POST** /auth/{mount_path}/role/{role_name}/secret-id-ttl | Duration in seconds of the SecretID generated against the role.
[**UpdateApproleRoleRoleNameTokenBoundCidrs**](Auth.md#updateapprolerolerolenametokenboundcidrs) | **POST** /auth/{mount_path}/role/{role_name}/token-bound-cidrs | Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token.
[**UpdateApproleRoleRoleNameTokenMaxTtl**](Auth.md#updateapprolerolerolenametokenmaxttl) | **POST** /auth/{mount_path}/role/{role_name}/token-max-ttl | Duration in seconds, the maximum lifetime of the tokens issued by using the SecretIDs that were generated against this role, after which the tokens are not allowed to be renewed.
[**UpdateApproleRoleRoleNameTokenNumUses**](Auth.md#updateapprolerolerolenametokennumuses) | **POST** /auth/{mount_path}/role/{role_name}/token-num-uses | Number of times issued tokens can be used
[**UpdateApproleRoleRoleNameTokenTtl**](Auth.md#updateapprolerolerolenametokenttl) | **POST** /auth/{mount_path}/role/{role_name}/token-ttl | Duration in seconds, the lifetime of the token issued by using the SecretID that is generated against this role, before which the token needs to be renewed.
[**UpdateApproleTidySecretId**](Auth.md#updateapproletidysecretid) | **POST** /auth/{mount_path}/tidy/secret-id | Trigger the clean-up of expired SecretID entries.
[**UpdateAwsConfigCertificateCertName**](Auth.md#updateawsconfigcertificatecertname) | **POST** /auth/{mount_path}/config/certificate/{cert_name} | 
[**UpdateAwsConfigClient**](Auth.md#updateawsconfigclient) | **POST** /auth/{mount_path}/config/client | 
[**UpdateAwsConfigIdentity**](Auth.md#updateawsconfigidentity) | **POST** /auth/{mount_path}/config/identity | 
[**UpdateAwsConfigRotateRoot**](Auth.md#updateawsconfigrotateroot) | **POST** /auth/{mount_path}/config/rotate-root | 
[**UpdateAwsConfigStsAccountId**](Auth.md#updateawsconfigstsaccountid) | **POST** /auth/{mount_path}/config/sts/{account_id} | 
[**UpdateAwsConfigTidyIdentityAccesslist**](Auth.md#updateawsconfigtidyidentityaccesslist) | **POST** /auth/{mount_path}/config/tidy/identity-accesslist | 
[**UpdateAwsConfigTidyIdentityWhitelist**](Auth.md#updateawsconfigtidyidentitywhitelist) | **POST** /auth/{mount_path}/config/tidy/identity-whitelist | 
[**UpdateAwsConfigTidyRoletagBlacklist**](Auth.md#updateawsconfigtidyroletagblacklist) | **POST** /auth/{mount_path}/config/tidy/roletag-blacklist | 
[**UpdateAwsConfigTidyRoletagDenylist**](Auth.md#updateawsconfigtidyroletagdenylist) | **POST** /auth/{mount_path}/config/tidy/roletag-denylist | 
[**UpdateAwsRoleRole**](Auth.md#updateawsrolerole) | **POST** /auth/{mount_path}/role/{role} | 
[**UpdateAwsRoleRoleTag**](Auth.md#updateawsroleroletag) | **POST** /auth/{mount_path}/role/{role}/tag | 
[**UpdateAwsRoletagBlacklistRoleTag**](Auth.md#updateawsroletagblacklistroletag) | **POST** /auth/{mount_path}/roletag-blacklist/{role_tag} | 
[**UpdateAwsRoletagDenylistRoleTag**](Auth.md#updateawsroletagdenylistroletag) | **POST** /auth/{mount_path}/roletag-denylist/{role_tag} | 
[**UpdateAwsTidyIdentityAccesslist**](Auth.md#updateawstidyidentityaccesslist) | **POST** /auth/{mount_path}/tidy/identity-accesslist | 
[**UpdateAwsTidyIdentityWhitelist**](Auth.md#updateawstidyidentitywhitelist) | **POST** /auth/{mount_path}/tidy/identity-whitelist | 
[**UpdateAwsTidyRoletagBlacklist**](Auth.md#updateawstidyroletagblacklist) | **POST** /auth/{mount_path}/tidy/roletag-blacklist | 
[**UpdateAwsTidyRoletagDenylist**](Auth.md#updateawstidyroletagdenylist) | **POST** /auth/{mount_path}/tidy/roletag-denylist | 
[**UpdateCertCertsName**](Auth.md#updatecertcertsname) | **POST** /auth/{mount_path}/certs/{name} | Manage trusted certificates used for authentication.
[**UpdateCertCrlsName**](Auth.md#updatecertcrlsname) | **POST** /auth/{mount_path}/crls/{name} | Manage Certificate Revocation Lists checked during authentication.
[**UpdateCfRolesRole**](Auth.md#updatecfrolesrole) | **POST** /auth/{mount_path}/roles/{role} | 
[**UpdateGcpRoleNameLabels**](Auth.md#updategcprolenamelabels) | **POST** /auth/{mount_path}/role/{name}/labels | Add or remove labels for an existing &#39;gce&#39; role
[**UpdateGcpRoleNameServiceAccounts**](Auth.md#updategcprolenameserviceaccounts) | **POST** /auth/{mount_path}/role/{name}/service-accounts | Add or remove service accounts for an existing &#x60;iam&#x60; role
[**UpdateGithubMapTeamsKey**](Auth.md#updategithubmapteamskey) | **POST** /auth/{mount_path}/map/teams/{key} | Read/write/delete a single teams mapping
[**UpdateGithubMapUsersKey**](Auth.md#updategithubmapuserskey) | **POST** /auth/{mount_path}/map/users/{key} | Read/write/delete a single users mapping
[**UpdateKerberosConfigLdap**](Auth.md#updatekerberosconfigldap) | **POST** /auth/{mount_path}/config/ldap | 
[**UpdateKerberosGroupsName**](Auth.md#updatekerberosgroupsname) | **POST** /auth/{mount_path}/groups/{name} | 
[**UpdateOciLoginRole**](Auth.md#updateociloginrole) | **POST** /auth/{mount_path}/login/{role} | Authenticates to Vault using OCI credentials
[**UpdateOidcConfig**](Auth.md#updateoidcconfig) | **POST** /auth/{mount_path}/config | Configure the JWT authentication backend.
[**UpdateOidcLogin**](Auth.md#updateoidclogin) | **POST** /auth/{mount_path}/login | Authenticates to Vault using a JWT (or OIDC) token.
[**UpdateOidcOidcAuthUrl**](Auth.md#updateoidcoidcauthurl) | **POST** /auth/{mount_path}/oidc/auth_url | Request an authorization URL to start an OIDC login flow.
[**UpdateOidcOidcCallback**](Auth.md#updateoidcoidccallback) | **POST** /auth/{mount_path}/oidc/callback | Callback endpoint to handle form_posts.
[**UpdateOidcRoleName**](Auth.md#updateoidcrolename) | **POST** /auth/{mount_path}/role/{name} | Register an role with the backend.
[**UpdateRadiusLoginUrlusername**](Auth.md#updateradiusloginurlusername) | **POST** /auth/{mount_path}/login/{urlusername} | Log in with a username and password.
[**UpdateRadiusUsersName**](Auth.md#updateradiususersname) | **POST** /auth/{mount_path}/users/{name} | Manage users allowed to authenticate.
[**UpdateTokenCreate**](Auth.md#updatetokencreate) | **POST** /auth/{mount_path}/create | The token create path is used to create new tokens.
[**UpdateTokenCreateOrphan**](Auth.md#updatetokencreateorphan) | **POST** /auth/{mount_path}/create-orphan | The token create path is used to create new orphan tokens.
[**UpdateTokenCreateRoleName**](Auth.md#updatetokencreaterolename) | **POST** /auth/{mount_path}/create/{role_name} | This token create path is used to create new tokens adhering to the given role.
[**UpdateTokenLookup**](Auth.md#updatetokenlookup) | **POST** /auth/{mount_path}/lookup | This endpoint will lookup a token and its properties.
[**UpdateTokenLookupAccessor**](Auth.md#updatetokenlookupaccessor) | **POST** /auth/{mount_path}/lookup-accessor | This endpoint will lookup a token associated with the given accessor and its properties. Response will not contain the token ID.
[**UpdateTokenLookupSelf**](Auth.md#updatetokenlookupself) | **POST** /auth/{mount_path}/lookup-self | This endpoint will lookup a token and its properties.
[**UpdateTokenRenew**](Auth.md#updatetokenrenew) | **POST** /auth/{mount_path}/renew | This endpoint will renew the given token and prevent expiration.
[**UpdateTokenRenewAccessor**](Auth.md#updatetokenrenewaccessor) | **POST** /auth/{mount_path}/renew-accessor | This endpoint will renew a token associated with the given accessor and its properties. Response will not contain the token ID.
[**UpdateTokenRenewSelf**](Auth.md#updatetokenrenewself) | **POST** /auth/{mount_path}/renew-self | This endpoint will renew the token used to call it and prevent expiration.
[**UpdateTokenRevoke**](Auth.md#updatetokenrevoke) | **POST** /auth/{mount_path}/revoke | This endpoint will delete the given token and all of its child tokens.
[**UpdateTokenRevokeAccessor**](Auth.md#updatetokenrevokeaccessor) | **POST** /auth/{mount_path}/revoke-accessor | This endpoint will delete the token associated with the accessor and all of its child tokens.
[**UpdateTokenRevokeOrphan**](Auth.md#updatetokenrevokeorphan) | **POST** /auth/{mount_path}/revoke-orphan | This endpoint will delete the token and orphan its child tokens.
[**UpdateTokenRevokeSelf**](Auth.md#updatetokenrevokeself) | **POST** /auth/{mount_path}/revoke-self | This endpoint will delete the token used to call it and all of its child tokens.
[**UpdateTokenRolesRoleName**](Auth.md#updatetokenrolesrolename) | **POST** /auth/{mount_path}/roles/{role_name} | 
[**UpdateTokenTidy**](Auth.md#updatetokentidy) | **POST** /auth/{mount_path}/tidy | This endpoint performs cleanup tasks that can be run if certain error conditions have occurred.
[**UpdateUserpassLoginUsername**](Auth.md#updateuserpassloginusername) | **POST** /auth/{mount_path}/login/{username} | Log in with a username and password.
[**UpdateUserpassUsersUsername**](Auth.md#updateuserpassusersusername) | **POST** /auth/{mount_path}/users/{username} | Manage users allowed to authenticate.
[**UpdateUserpassUsersUsernamePassword**](Auth.md#updateuserpassusersusernamepassword) | **POST** /auth/{mount_path}/users/{username}/password | Reset user&#39;s password.
[**UpdateUserpassUsersUsernamePolicies**](Auth.md#updateuserpassusersusernamepolicies) | **POST** /auth/{mount_path}/users/{username}/policies | Update the policies associated with the username.


<a name="deleteapprolerolerolename"></a>
# **DeleteApproleRoleRoleName**
> void DeleteApproleRoleRoleName (string roleName, string mountPath = null)

Register an role with the backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteApproleRoleRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Register an role with the backend.
                apiInstance.DeleteApproleRoleRoleName(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteApproleRoleRoleName: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="deleteapprolerolerolenamebindsecretid"></a>
# **DeleteApproleRoleRoleNameBindSecretId**
> void DeleteApproleRoleRoleNameBindSecretId (string roleName, string mountPath = null)

Impose secret_id to be presented during login using this role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteApproleRoleRoleNameBindSecretIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Impose secret_id to be presented during login using this role.
                apiInstance.DeleteApproleRoleRoleNameBindSecretId(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteApproleRoleRoleNameBindSecretId: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="deleteapprolerolerolenameboundcidrlist"></a>
# **DeleteApproleRoleRoleNameBoundCidrList**
> void DeleteApproleRoleRoleNameBoundCidrList (string roleName, string mountPath = null)

Deprecated: Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteApproleRoleRoleNameBoundCidrListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Deprecated: Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
                apiInstance.DeleteApproleRoleRoleNameBoundCidrList(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteApproleRoleRoleNameBoundCidrList: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="deleteapprolerolerolenameperiod"></a>
# **DeleteApproleRoleRoleNamePeriod**
> void DeleteApproleRoleRoleNamePeriod (string roleName, string mountPath = null)

Updates the value of 'period' on the role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteApproleRoleRoleNamePeriodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Updates the value of 'period' on the role
                apiInstance.DeleteApproleRoleRoleNamePeriod(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteApproleRoleRoleNamePeriod: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="deleteapprolerolerolenamepolicies"></a>
# **DeleteApproleRoleRoleNamePolicies**
> void DeleteApproleRoleRoleNamePolicies (string roleName, string mountPath = null)

Policies of the role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteApproleRoleRoleNamePoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Policies of the role.
                apiInstance.DeleteApproleRoleRoleNamePolicies(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteApproleRoleRoleNamePolicies: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="deleteapprolerolerolenamesecretidaccessordestroy"></a>
# **DeleteApproleRoleRoleNameSecretIdAccessorDestroy**
> void DeleteApproleRoleRoleNameSecretIdAccessorDestroy (string roleName, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteApproleRoleRoleNameSecretIdAccessorDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.DeleteApproleRoleRoleNameSecretIdAccessorDestroy(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteApproleRoleRoleNameSecretIdAccessorDestroy: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="deleteapprolerolerolenamesecretidboundcidrs"></a>
# **DeleteApproleRoleRoleNameSecretIdBoundCidrs**
> void DeleteApproleRoleRoleNameSecretIdBoundCidrs (string roleName, string mountPath = null)

Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteApproleRoleRoleNameSecretIdBoundCidrsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
                apiInstance.DeleteApproleRoleRoleNameSecretIdBoundCidrs(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteApproleRoleRoleNameSecretIdBoundCidrs: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="deleteapprolerolerolenamesecretiddestroy"></a>
# **DeleteApproleRoleRoleNameSecretIdDestroy**
> void DeleteApproleRoleRoleNameSecretIdDestroy (string roleName, string mountPath = null)

Invalidate an issued secret_id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteApproleRoleRoleNameSecretIdDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Invalidate an issued secret_id
                apiInstance.DeleteApproleRoleRoleNameSecretIdDestroy(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteApproleRoleRoleNameSecretIdDestroy: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="deleteapprolerolerolenamesecretidnumuses"></a>
# **DeleteApproleRoleRoleNameSecretIdNumUses**
> void DeleteApproleRoleRoleNameSecretIdNumUses (string roleName, string mountPath = null)

Use limit of the SecretID generated against the role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteApproleRoleRoleNameSecretIdNumUsesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Use limit of the SecretID generated against the role.
                apiInstance.DeleteApproleRoleRoleNameSecretIdNumUses(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteApproleRoleRoleNameSecretIdNumUses: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="deleteapprolerolerolenamesecretidttl"></a>
# **DeleteApproleRoleRoleNameSecretIdTtl**
> void DeleteApproleRoleRoleNameSecretIdTtl (string roleName, string mountPath = null)

Duration in seconds of the SecretID generated against the role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteApproleRoleRoleNameSecretIdTtlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Duration in seconds of the SecretID generated against the role.
                apiInstance.DeleteApproleRoleRoleNameSecretIdTtl(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteApproleRoleRoleNameSecretIdTtl: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="deleteapprolerolerolenametokenboundcidrs"></a>
# **DeleteApproleRoleRoleNameTokenBoundCidrs**
> void DeleteApproleRoleRoleNameTokenBoundCidrs (string roleName, string mountPath = null)

Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteApproleRoleRoleNameTokenBoundCidrsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token.
                apiInstance.DeleteApproleRoleRoleNameTokenBoundCidrs(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteApproleRoleRoleNameTokenBoundCidrs: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="deleteapprolerolerolenametokenmaxttl"></a>
# **DeleteApproleRoleRoleNameTokenMaxTtl**
> void DeleteApproleRoleRoleNameTokenMaxTtl (string roleName, string mountPath = null)

Duration in seconds, the maximum lifetime of the tokens issued by using the SecretIDs that were generated against this role, after which the tokens are not allowed to be renewed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteApproleRoleRoleNameTokenMaxTtlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Duration in seconds, the maximum lifetime of the tokens issued by using the SecretIDs that were generated against this role, after which the tokens are not allowed to be renewed.
                apiInstance.DeleteApproleRoleRoleNameTokenMaxTtl(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteApproleRoleRoleNameTokenMaxTtl: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="deleteapprolerolerolenametokennumuses"></a>
# **DeleteApproleRoleRoleNameTokenNumUses**
> void DeleteApproleRoleRoleNameTokenNumUses (string roleName, string mountPath = null)

Number of times issued tokens can be used

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteApproleRoleRoleNameTokenNumUsesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Number of times issued tokens can be used
                apiInstance.DeleteApproleRoleRoleNameTokenNumUses(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteApproleRoleRoleNameTokenNumUses: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="deleteapprolerolerolenametokenttl"></a>
# **DeleteApproleRoleRoleNameTokenTtl**
> void DeleteApproleRoleRoleNameTokenTtl (string roleName, string mountPath = null)

Duration in seconds, the lifetime of the token issued by using the SecretID that is generated against this role, before which the token needs to be renewed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteApproleRoleRoleNameTokenTtlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Duration in seconds, the lifetime of the token issued by using the SecretID that is generated against this role, before which the token needs to be renewed.
                apiInstance.DeleteApproleRoleRoleNameTokenTtl(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteApproleRoleRoleNameTokenTtl: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="deleteawsconfigcertificatecertname"></a>
# **DeleteAwsConfigCertificateCertName**
> void DeleteAwsConfigCertificateCertName (string certName, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAwsConfigCertificateCertNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var certName = "certName_example";  // string | Name of the certificate.
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.DeleteAwsConfigCertificateCertName(certName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAwsConfigCertificateCertName: " + e.Message );
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
 **certName** | **string**| Name of the certificate. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="deleteawsconfigclient"></a>
# **DeleteAwsConfigClient**
> void DeleteAwsConfigClient (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAwsConfigClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.DeleteAwsConfigClient(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAwsConfigClient: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="deleteawsconfigstsaccountid"></a>
# **DeleteAwsConfigStsAccountId**
> void DeleteAwsConfigStsAccountId (string accountId, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAwsConfigStsAccountIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var accountId = "accountId_example";  // string | AWS account ID to be associated with STS role. If set, Vault will use assumed credentials to verify any login attempts from EC2 instances in this account.
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.DeleteAwsConfigStsAccountId(accountId, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAwsConfigStsAccountId: " + e.Message );
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
 **accountId** | **string**| AWS account ID to be associated with STS role. If set, Vault will use assumed credentials to verify any login attempts from EC2 instances in this account. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="deleteawsconfigtidyidentityaccesslist"></a>
# **DeleteAwsConfigTidyIdentityAccesslist**
> void DeleteAwsConfigTidyIdentityAccesslist (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAwsConfigTidyIdentityAccesslistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.DeleteAwsConfigTidyIdentityAccesslist(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAwsConfigTidyIdentityAccesslist: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="deleteawsconfigtidyidentitywhitelist"></a>
# **DeleteAwsConfigTidyIdentityWhitelist**
> void DeleteAwsConfigTidyIdentityWhitelist (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAwsConfigTidyIdentityWhitelistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.DeleteAwsConfigTidyIdentityWhitelist(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAwsConfigTidyIdentityWhitelist: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="deleteawsconfigtidyroletagblacklist"></a>
# **DeleteAwsConfigTidyRoletagBlacklist**
> void DeleteAwsConfigTidyRoletagBlacklist (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAwsConfigTidyRoletagBlacklistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.DeleteAwsConfigTidyRoletagBlacklist(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAwsConfigTidyRoletagBlacklist: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="deleteawsconfigtidyroletagdenylist"></a>
# **DeleteAwsConfigTidyRoletagDenylist**
> void DeleteAwsConfigTidyRoletagDenylist (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAwsConfigTidyRoletagDenylistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.DeleteAwsConfigTidyRoletagDenylist(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAwsConfigTidyRoletagDenylist: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="deleteawsidentityaccesslistinstanceid"></a>
# **DeleteAwsIdentityAccesslistInstanceId**
> void DeleteAwsIdentityAccesslistInstanceId (string instanceId, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAwsIdentityAccesslistInstanceIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var instanceId = "instanceId_example";  // string | EC2 instance ID. A successful login operation from an EC2 instance gets cached in this accesslist, keyed off of instance ID.
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.DeleteAwsIdentityAccesslistInstanceId(instanceId, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAwsIdentityAccesslistInstanceId: " + e.Message );
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
 **instanceId** | **string**| EC2 instance ID. A successful login operation from an EC2 instance gets cached in this accesslist, keyed off of instance ID. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="deleteawsidentitywhitelistinstanceid"></a>
# **DeleteAwsIdentityWhitelistInstanceId**
> void DeleteAwsIdentityWhitelistInstanceId (string instanceId, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAwsIdentityWhitelistInstanceIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var instanceId = "instanceId_example";  // string | EC2 instance ID. A successful login operation from an EC2 instance gets cached in this accesslist, keyed off of instance ID.
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.DeleteAwsIdentityWhitelistInstanceId(instanceId, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAwsIdentityWhitelistInstanceId: " + e.Message );
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
 **instanceId** | **string**| EC2 instance ID. A successful login operation from an EC2 instance gets cached in this accesslist, keyed off of instance ID. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="deleteawsrolerole"></a>
# **DeleteAwsRoleRole**
> void DeleteAwsRoleRole (string role, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAwsRoleRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var role = "role_example";  // string | Name of the role.
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.DeleteAwsRoleRole(role, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAwsRoleRole: " + e.Message );
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
 **role** | **string**| Name of the role. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="deleteawsroletagblacklistroletag"></a>
# **DeleteAwsRoletagBlacklistRoleTag**
> void DeleteAwsRoletagBlacklistRoleTag (string roleTag, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAwsRoletagBlacklistRoleTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleTag = "roleTag_example";  // string | Role tag to be deny listed. The tag can be supplied as-is. In order to avoid any encoding problems, it can be base64 encoded.
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.DeleteAwsRoletagBlacklistRoleTag(roleTag, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAwsRoletagBlacklistRoleTag: " + e.Message );
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
 **roleTag** | **string**| Role tag to be deny listed. The tag can be supplied as-is. In order to avoid any encoding problems, it can be base64 encoded. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="deleteawsroletagdenylistroletag"></a>
# **DeleteAwsRoletagDenylistRoleTag**
> void DeleteAwsRoletagDenylistRoleTag (string roleTag, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAwsRoletagDenylistRoleTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleTag = "roleTag_example";  // string | Role tag to be deny listed. The tag can be supplied as-is. In order to avoid any encoding problems, it can be base64 encoded.
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.DeleteAwsRoletagDenylistRoleTag(roleTag, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAwsRoletagDenylistRoleTag: " + e.Message );
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
 **roleTag** | **string**| Role tag to be deny listed. The tag can be supplied as-is. In order to avoid any encoding problems, it can be base64 encoded. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="deletecertcertsname"></a>
# **DeleteCertCertsName**
> void DeleteCertCertsName (string name, string mountPath = null)

Manage trusted certificates used for authentication.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteCertCertsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The name of the certificate
            var mountPath = "\"cert\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cert")

            try
            {
                // Manage trusted certificates used for authentication.
                apiInstance.DeleteCertCertsName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteCertCertsName: " + e.Message );
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
 **name** | **string**| The name of the certificate | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cert&quot;]

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

<a name="deletecertcrlsname"></a>
# **DeleteCertCrlsName**
> void DeleteCertCrlsName (string name, string mountPath = null)

Manage Certificate Revocation Lists checked during authentication.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteCertCrlsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The name of the certificate
            var mountPath = "\"cert\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cert")

            try
            {
                // Manage Certificate Revocation Lists checked during authentication.
                apiInstance.DeleteCertCrlsName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteCertCrlsName: " + e.Message );
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
 **name** | **string**| The name of the certificate | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cert&quot;]

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

<a name="deletecfrolesrole"></a>
# **DeleteCfRolesRole**
> void DeleteCfRolesRole (string role, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteCfRolesRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var role = "role_example";  // string | The name of the role.
            var mountPath = "\"cf\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cf")

            try
            {
                apiInstance.DeleteCfRolesRole(role, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteCfRolesRole: " + e.Message );
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
 **role** | **string**| The name of the role. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cf&quot;]

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

<a name="deletegithubmapteamskey"></a>
# **DeleteGithubMapTeamsKey**
> void DeleteGithubMapTeamsKey (string key, string mountPath = null)

Read/write/delete a single teams mapping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteGithubMapTeamsKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var key = "key_example";  // string | Key for the teams mapping
            var mountPath = "\"github\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "github")

            try
            {
                // Read/write/delete a single teams mapping
                apiInstance.DeleteGithubMapTeamsKey(key, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteGithubMapTeamsKey: " + e.Message );
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
 **key** | **string**| Key for the teams mapping | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;github&quot;]

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

<a name="deletegithubmapuserskey"></a>
# **DeleteGithubMapUsersKey**
> void DeleteGithubMapUsersKey (string key, string mountPath = null)

Read/write/delete a single users mapping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteGithubMapUsersKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var key = "key_example";  // string | Key for the users mapping
            var mountPath = "\"github\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "github")

            try
            {
                // Read/write/delete a single users mapping
                apiInstance.DeleteGithubMapUsersKey(key, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteGithubMapUsersKey: " + e.Message );
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
 **key** | **string**| Key for the users mapping | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;github&quot;]

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

<a name="deletekerberosgroupsname"></a>
# **DeleteKerberosGroupsName**
> void DeleteKerberosGroupsName (string name, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteKerberosGroupsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | Name of the LDAP group.
            var mountPath = "\"kerberos\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kerberos")

            try
            {
                apiInstance.DeleteKerberosGroupsName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteKerberosGroupsName: " + e.Message );
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
 **name** | **string**| Name of the LDAP group. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kerberos&quot;]

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

<a name="deleteoidcrolename"></a>
# **DeleteOidcRoleName**
> void DeleteOidcRoleName (string name, string mountPath = null)

Delete an existing role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteOidcRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | Name of the role.
            var mountPath = "\"oidc\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oidc")

            try
            {
                // Delete an existing role.
                apiInstance.DeleteOidcRoleName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteOidcRoleName: " + e.Message );
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
 **name** | **string**| Name of the role. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oidc&quot;]

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

<a name="deleteradiususersname"></a>
# **DeleteRadiusUsersName**
> void DeleteRadiusUsersName (string name, string mountPath = null)

Manage users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteRadiusUsersNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | Name of the RADIUS user.
            var mountPath = "\"radius\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "radius")

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.DeleteRadiusUsersName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteRadiusUsersName: " + e.Message );
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
 **name** | **string**| Name of the RADIUS user. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;radius&quot;]

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

<a name="deletetokenrolesrolename"></a>
# **DeleteTokenRolesRoleName**
> void DeleteTokenRolesRoleName (string roleName, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteTokenRolesRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                apiInstance.DeleteTokenRolesRoleName(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteTokenRolesRoleName: " + e.Message );
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
 **roleName** | **string**| Name of the role | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

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

<a name="deleteuserpassusersusername"></a>
# **DeleteUserpassUsersUsername**
> void DeleteUserpassUsersUsername (string username, string mountPath = null)

Manage users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteUserpassUsersUsernameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var username = "username_example";  // string | Username for this user.
            var mountPath = "\"userpass\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "userpass")

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.DeleteUserpassUsersUsername(username, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteUserpassUsersUsername: " + e.Message );
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
 **username** | **string**| Username for this user. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;userpass&quot;]

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

<a name="listapprolerolerolenamesecretid"></a>
# **ListApproleRoleRoleNameSecretId**
> void ListApproleRoleRoleNameSecretId (string roleName, string list, string mountPath = null)

Generate a SecretID against this role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListApproleRoleRoleNameSecretIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var list = "true";  // string | Must be set to `true`
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Generate a SecretID against this role.
                apiInstance.ListApproleRoleRoleNameSecretId(roleName, list, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ListApproleRoleRoleNameSecretId: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **list** | **string**| Must be set to &#x60;true&#x60; | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="listawsconfigcertificates"></a>
# **ListAwsConfigCertificates**
> void ListAwsConfigCertificates (string list, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListAwsConfigCertificatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.ListAwsConfigCertificates(list, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ListAwsConfigCertificates: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="listawsconfigsts"></a>
# **ListAwsConfigSts**
> void ListAwsConfigSts (string list, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListAwsConfigStsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.ListAwsConfigSts(list, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ListAwsConfigSts: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="listawsidentityaccesslist"></a>
# **ListAwsIdentityAccesslist**
> void ListAwsIdentityAccesslist (string list, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListAwsIdentityAccesslistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.ListAwsIdentityAccesslist(list, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ListAwsIdentityAccesslist: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="listawsidentitywhitelist"></a>
# **ListAwsIdentityWhitelist**
> void ListAwsIdentityWhitelist (string list, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListAwsIdentityWhitelistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.ListAwsIdentityWhitelist(list, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ListAwsIdentityWhitelist: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="listawsroletagblacklist"></a>
# **ListAwsRoletagBlacklist**
> void ListAwsRoletagBlacklist (string list, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListAwsRoletagBlacklistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.ListAwsRoletagBlacklist(list, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ListAwsRoletagBlacklist: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="listawsroletagdenylist"></a>
# **ListAwsRoletagDenylist**
> void ListAwsRoletagDenylist (string list, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListAwsRoletagDenylistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.ListAwsRoletagDenylist(list, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ListAwsRoletagDenylist: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="listcertcerts"></a>
# **ListCertCerts**
> void ListCertCerts (string list, string mountPath = null)

Manage trusted certificates used for authentication.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListCertCertsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var mountPath = "\"cert\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cert")

            try
            {
                // Manage trusted certificates used for authentication.
                apiInstance.ListCertCerts(list, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ListCertCerts: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cert&quot;]

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

<a name="listgcproles"></a>
# **ListGcpRoles**
> void ListGcpRoles (string list, string mountPath = null)

Lists all the roles that are registered with Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListGcpRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                // Lists all the roles that are registered with Vault.
                apiInstance.ListGcpRoles(list, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ListGcpRoles: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcp&quot;]

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

<a name="listkerberosgroups"></a>
# **ListKerberosGroups**
> void ListKerberosGroups (string list, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListKerberosGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var mountPath = "\"kerberos\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kerberos")

            try
            {
                apiInstance.ListKerberosGroups(list, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ListKerberosGroups: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kerberos&quot;]

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

<a name="listoidcrole"></a>
# **ListOidcRole**
> void ListOidcRole (string list, string mountPath = null)

Lists all the roles registered with the backend.

The list will contain the names of the roles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListOidcRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var mountPath = "\"oidc\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oidc")

            try
            {
                // Lists all the roles registered with the backend.
                apiInstance.ListOidcRole(list, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ListOidcRole: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oidc&quot;]

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

<a name="listtokenaccessors"></a>
# **ListTokenAccessors**
> void ListTokenAccessors (string list, string mountPath = null)

List token accessors, which can then be be used to iterate and discover their properties or revoke them. Because this can be used to cause a denial of service, this endpoint requires 'sudo' capability in addition to 'list'.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListTokenAccessorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // List token accessors, which can then be be used to iterate and discover their properties or revoke them. Because this can be used to cause a denial of service, this endpoint requires 'sudo' capability in addition to 'list'.
                apiInstance.ListTokenAccessors(list, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ListTokenAccessors: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

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

<a name="listuserpassusers"></a>
# **ListUserpassUsers**
> void ListUserpassUsers (string list, string mountPath = null)

Manage users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListUserpassUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var mountPath = "\"userpass\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "userpass")

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.ListUserpassUsers(list, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ListUserpassUsers: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;userpass&quot;]

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

<a name="readapprolerolerolename"></a>
# **ReadApproleRoleRoleName**
> void ReadApproleRoleRoleName (string roleName, string mountPath = null)

Register an role with the backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadApproleRoleRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Register an role with the backend.
                apiInstance.ReadApproleRoleRoleName(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadApproleRoleRoleName: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="readapprolerolerolenamebindsecretid"></a>
# **ReadApproleRoleRoleNameBindSecretId**
> void ReadApproleRoleRoleNameBindSecretId (string roleName, string mountPath = null)

Impose secret_id to be presented during login using this role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadApproleRoleRoleNameBindSecretIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Impose secret_id to be presented during login using this role.
                apiInstance.ReadApproleRoleRoleNameBindSecretId(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadApproleRoleRoleNameBindSecretId: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="readapprolerolerolenameboundcidrlist"></a>
# **ReadApproleRoleRoleNameBoundCidrList**
> void ReadApproleRoleRoleNameBoundCidrList (string roleName, string mountPath = null)

Deprecated: Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadApproleRoleRoleNameBoundCidrListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Deprecated: Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
                apiInstance.ReadApproleRoleRoleNameBoundCidrList(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadApproleRoleRoleNameBoundCidrList: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="readapprolerolerolenamelocalsecretids"></a>
# **ReadApproleRoleRoleNameLocalSecretIds**
> void ReadApproleRoleRoleNameLocalSecretIds (string roleName, string mountPath = null)

Enables cluster local secret IDs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadApproleRoleRoleNameLocalSecretIdsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Enables cluster local secret IDs
                apiInstance.ReadApproleRoleRoleNameLocalSecretIds(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadApproleRoleRoleNameLocalSecretIds: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="readapprolerolerolenameperiod"></a>
# **ReadApproleRoleRoleNamePeriod**
> void ReadApproleRoleRoleNamePeriod (string roleName, string mountPath = null)

Updates the value of 'period' on the role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadApproleRoleRoleNamePeriodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Updates the value of 'period' on the role
                apiInstance.ReadApproleRoleRoleNamePeriod(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadApproleRoleRoleNamePeriod: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="readapprolerolerolenamepolicies"></a>
# **ReadApproleRoleRoleNamePolicies**
> void ReadApproleRoleRoleNamePolicies (string roleName, string mountPath = null)

Policies of the role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadApproleRoleRoleNamePoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Policies of the role.
                apiInstance.ReadApproleRoleRoleNamePolicies(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadApproleRoleRoleNamePolicies: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="readapprolerolerolenameroleid"></a>
# **ReadApproleRoleRoleNameRoleId**
> void ReadApproleRoleRoleNameRoleId (string roleName, string mountPath = null)

Returns the 'role_id' of the role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadApproleRoleRoleNameRoleIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Returns the 'role_id' of the role.
                apiInstance.ReadApproleRoleRoleNameRoleId(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadApproleRoleRoleNameRoleId: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="readapprolerolerolenamesecretidboundcidrs"></a>
# **ReadApproleRoleRoleNameSecretIdBoundCidrs**
> void ReadApproleRoleRoleNameSecretIdBoundCidrs (string roleName, string mountPath = null)

Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadApproleRoleRoleNameSecretIdBoundCidrsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
                apiInstance.ReadApproleRoleRoleNameSecretIdBoundCidrs(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadApproleRoleRoleNameSecretIdBoundCidrs: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="readapprolerolerolenamesecretidnumuses"></a>
# **ReadApproleRoleRoleNameSecretIdNumUses**
> void ReadApproleRoleRoleNameSecretIdNumUses (string roleName, string mountPath = null)

Use limit of the SecretID generated against the role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadApproleRoleRoleNameSecretIdNumUsesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Use limit of the SecretID generated against the role.
                apiInstance.ReadApproleRoleRoleNameSecretIdNumUses(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadApproleRoleRoleNameSecretIdNumUses: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="readapprolerolerolenamesecretidttl"></a>
# **ReadApproleRoleRoleNameSecretIdTtl**
> void ReadApproleRoleRoleNameSecretIdTtl (string roleName, string mountPath = null)

Duration in seconds of the SecretID generated against the role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadApproleRoleRoleNameSecretIdTtlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Duration in seconds of the SecretID generated against the role.
                apiInstance.ReadApproleRoleRoleNameSecretIdTtl(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadApproleRoleRoleNameSecretIdTtl: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="readapprolerolerolenametokenboundcidrs"></a>
# **ReadApproleRoleRoleNameTokenBoundCidrs**
> void ReadApproleRoleRoleNameTokenBoundCidrs (string roleName, string mountPath = null)

Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadApproleRoleRoleNameTokenBoundCidrsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token.
                apiInstance.ReadApproleRoleRoleNameTokenBoundCidrs(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadApproleRoleRoleNameTokenBoundCidrs: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="readapprolerolerolenametokenmaxttl"></a>
# **ReadApproleRoleRoleNameTokenMaxTtl**
> void ReadApproleRoleRoleNameTokenMaxTtl (string roleName, string mountPath = null)

Duration in seconds, the maximum lifetime of the tokens issued by using the SecretIDs that were generated against this role, after which the tokens are not allowed to be renewed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadApproleRoleRoleNameTokenMaxTtlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Duration in seconds, the maximum lifetime of the tokens issued by using the SecretIDs that were generated against this role, after which the tokens are not allowed to be renewed.
                apiInstance.ReadApproleRoleRoleNameTokenMaxTtl(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadApproleRoleRoleNameTokenMaxTtl: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="readapprolerolerolenametokennumuses"></a>
# **ReadApproleRoleRoleNameTokenNumUses**
> void ReadApproleRoleRoleNameTokenNumUses (string roleName, string mountPath = null)

Number of times issued tokens can be used

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadApproleRoleRoleNameTokenNumUsesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Number of times issued tokens can be used
                apiInstance.ReadApproleRoleRoleNameTokenNumUses(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadApproleRoleRoleNameTokenNumUses: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="readapprolerolerolenametokenttl"></a>
# **ReadApproleRoleRoleNameTokenTtl**
> void ReadApproleRoleRoleNameTokenTtl (string roleName, string mountPath = null)

Duration in seconds, the lifetime of the token issued by using the SecretID that is generated against this role, before which the token needs to be renewed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadApproleRoleRoleNameTokenTtlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Duration in seconds, the lifetime of the token issued by using the SecretID that is generated against this role, before which the token needs to be renewed.
                apiInstance.ReadApproleRoleRoleNameTokenTtl(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadApproleRoleRoleNameTokenTtl: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="readawsconfigcertificatecertname"></a>
# **ReadAwsConfigCertificateCertName**
> void ReadAwsConfigCertificateCertName (string certName, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadAwsConfigCertificateCertNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var certName = "certName_example";  // string | Name of the certificate.
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.ReadAwsConfigCertificateCertName(certName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadAwsConfigCertificateCertName: " + e.Message );
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
 **certName** | **string**| Name of the certificate. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="readawsconfigclient"></a>
# **ReadAwsConfigClient**
> void ReadAwsConfigClient (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadAwsConfigClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.ReadAwsConfigClient(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadAwsConfigClient: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="readawsconfigidentity"></a>
# **ReadAwsConfigIdentity**
> void ReadAwsConfigIdentity (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadAwsConfigIdentityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.ReadAwsConfigIdentity(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadAwsConfigIdentity: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="readawsconfigstsaccountid"></a>
# **ReadAwsConfigStsAccountId**
> void ReadAwsConfigStsAccountId (string accountId, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadAwsConfigStsAccountIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var accountId = "accountId_example";  // string | AWS account ID to be associated with STS role. If set, Vault will use assumed credentials to verify any login attempts from EC2 instances in this account.
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.ReadAwsConfigStsAccountId(accountId, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadAwsConfigStsAccountId: " + e.Message );
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
 **accountId** | **string**| AWS account ID to be associated with STS role. If set, Vault will use assumed credentials to verify any login attempts from EC2 instances in this account. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="readawsconfigtidyidentityaccesslist"></a>
# **ReadAwsConfigTidyIdentityAccesslist**
> void ReadAwsConfigTidyIdentityAccesslist (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadAwsConfigTidyIdentityAccesslistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.ReadAwsConfigTidyIdentityAccesslist(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadAwsConfigTidyIdentityAccesslist: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="readawsconfigtidyidentitywhitelist"></a>
# **ReadAwsConfigTidyIdentityWhitelist**
> void ReadAwsConfigTidyIdentityWhitelist (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadAwsConfigTidyIdentityWhitelistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.ReadAwsConfigTidyIdentityWhitelist(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadAwsConfigTidyIdentityWhitelist: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="readawsconfigtidyroletagblacklist"></a>
# **ReadAwsConfigTidyRoletagBlacklist**
> void ReadAwsConfigTidyRoletagBlacklist (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadAwsConfigTidyRoletagBlacklistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.ReadAwsConfigTidyRoletagBlacklist(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadAwsConfigTidyRoletagBlacklist: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="readawsconfigtidyroletagdenylist"></a>
# **ReadAwsConfigTidyRoletagDenylist**
> void ReadAwsConfigTidyRoletagDenylist (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadAwsConfigTidyRoletagDenylistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.ReadAwsConfigTidyRoletagDenylist(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadAwsConfigTidyRoletagDenylist: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="readawsidentityaccesslistinstanceid"></a>
# **ReadAwsIdentityAccesslistInstanceId**
> void ReadAwsIdentityAccesslistInstanceId (string instanceId, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadAwsIdentityAccesslistInstanceIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var instanceId = "instanceId_example";  // string | EC2 instance ID. A successful login operation from an EC2 instance gets cached in this accesslist, keyed off of instance ID.
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.ReadAwsIdentityAccesslistInstanceId(instanceId, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadAwsIdentityAccesslistInstanceId: " + e.Message );
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
 **instanceId** | **string**| EC2 instance ID. A successful login operation from an EC2 instance gets cached in this accesslist, keyed off of instance ID. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="readawsidentitywhitelistinstanceid"></a>
# **ReadAwsIdentityWhitelistInstanceId**
> void ReadAwsIdentityWhitelistInstanceId (string instanceId, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadAwsIdentityWhitelistInstanceIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var instanceId = "instanceId_example";  // string | EC2 instance ID. A successful login operation from an EC2 instance gets cached in this accesslist, keyed off of instance ID.
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.ReadAwsIdentityWhitelistInstanceId(instanceId, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadAwsIdentityWhitelistInstanceId: " + e.Message );
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
 **instanceId** | **string**| EC2 instance ID. A successful login operation from an EC2 instance gets cached in this accesslist, keyed off of instance ID. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="readawsrolerole"></a>
# **ReadAwsRoleRole**
> void ReadAwsRoleRole (string role, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadAwsRoleRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var role = "role_example";  // string | Name of the role.
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.ReadAwsRoleRole(role, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadAwsRoleRole: " + e.Message );
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
 **role** | **string**| Name of the role. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="readawsroletagblacklistroletag"></a>
# **ReadAwsRoletagBlacklistRoleTag**
> void ReadAwsRoletagBlacklistRoleTag (string roleTag, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadAwsRoletagBlacklistRoleTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleTag = "roleTag_example";  // string | Role tag to be deny listed. The tag can be supplied as-is. In order to avoid any encoding problems, it can be base64 encoded.
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.ReadAwsRoletagBlacklistRoleTag(roleTag, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadAwsRoletagBlacklistRoleTag: " + e.Message );
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
 **roleTag** | **string**| Role tag to be deny listed. The tag can be supplied as-is. In order to avoid any encoding problems, it can be base64 encoded. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="readawsroletagdenylistroletag"></a>
# **ReadAwsRoletagDenylistRoleTag**
> void ReadAwsRoletagDenylistRoleTag (string roleTag, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadAwsRoletagDenylistRoleTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleTag = "roleTag_example";  // string | Role tag to be deny listed. The tag can be supplied as-is. In order to avoid any encoding problems, it can be base64 encoded.
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.ReadAwsRoletagDenylistRoleTag(roleTag, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadAwsRoletagDenylistRoleTag: " + e.Message );
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
 **roleTag** | **string**| Role tag to be deny listed. The tag can be supplied as-is. In order to avoid any encoding problems, it can be base64 encoded. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="readcertcertsname"></a>
# **ReadCertCertsName**
> void ReadCertCertsName (string name, string mountPath = null)

Manage trusted certificates used for authentication.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadCertCertsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The name of the certificate
            var mountPath = "\"cert\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cert")

            try
            {
                // Manage trusted certificates used for authentication.
                apiInstance.ReadCertCertsName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadCertCertsName: " + e.Message );
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
 **name** | **string**| The name of the certificate | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cert&quot;]

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

<a name="readcertcrlsname"></a>
# **ReadCertCrlsName**
> void ReadCertCrlsName (string name, string mountPath = null)

Manage Certificate Revocation Lists checked during authentication.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadCertCrlsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The name of the certificate
            var mountPath = "\"cert\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cert")

            try
            {
                // Manage Certificate Revocation Lists checked during authentication.
                apiInstance.ReadCertCrlsName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadCertCrlsName: " + e.Message );
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
 **name** | **string**| The name of the certificate | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cert&quot;]

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

<a name="readcfrolesrole"></a>
# **ReadCfRolesRole**
> void ReadCfRolesRole (string role, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadCfRolesRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var role = "role_example";  // string | The name of the role.
            var mountPath = "\"cf\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cf")

            try
            {
                apiInstance.ReadCfRolesRole(role, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadCfRolesRole: " + e.Message );
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
 **role** | **string**| The name of the role. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cf&quot;]

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

<a name="readgithubmapteams"></a>
# **ReadGithubMapTeams**
> void ReadGithubMapTeams (string mountPath = null, string list = null)

Read mappings for teams

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadGithubMapTeamsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"github\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "github")
            var list = "list_example";  // string | Return a list if `true` (optional) 

            try
            {
                // Read mappings for teams
                apiInstance.ReadGithubMapTeams(mountPath, list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadGithubMapTeams: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;github&quot;]
 **list** | **string**| Return a list if &#x60;true&#x60; | [optional] 

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

<a name="readgithubmapteamskey"></a>
# **ReadGithubMapTeamsKey**
> void ReadGithubMapTeamsKey (string key, string mountPath = null)

Read/write/delete a single teams mapping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadGithubMapTeamsKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var key = "key_example";  // string | Key for the teams mapping
            var mountPath = "\"github\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "github")

            try
            {
                // Read/write/delete a single teams mapping
                apiInstance.ReadGithubMapTeamsKey(key, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadGithubMapTeamsKey: " + e.Message );
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
 **key** | **string**| Key for the teams mapping | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;github&quot;]

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

<a name="readgithubmapusers"></a>
# **ReadGithubMapUsers**
> void ReadGithubMapUsers (string mountPath = null, string list = null)

Read mappings for users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadGithubMapUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"github\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "github")
            var list = "list_example";  // string | Return a list if `true` (optional) 

            try
            {
                // Read mappings for users
                apiInstance.ReadGithubMapUsers(mountPath, list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadGithubMapUsers: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;github&quot;]
 **list** | **string**| Return a list if &#x60;true&#x60; | [optional] 

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

<a name="readgithubmapuserskey"></a>
# **ReadGithubMapUsersKey**
> void ReadGithubMapUsersKey (string key, string mountPath = null)

Read/write/delete a single users mapping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadGithubMapUsersKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var key = "key_example";  // string | Key for the users mapping
            var mountPath = "\"github\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "github")

            try
            {
                // Read/write/delete a single users mapping
                apiInstance.ReadGithubMapUsersKey(key, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadGithubMapUsersKey: " + e.Message );
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
 **key** | **string**| Key for the users mapping | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;github&quot;]

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

<a name="readkerberosconfigldap"></a>
# **ReadKerberosConfigLdap**
> void ReadKerberosConfigLdap (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadKerberosConfigLdapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"kerberos\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kerberos")

            try
            {
                apiInstance.ReadKerberosConfigLdap(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadKerberosConfigLdap: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kerberos&quot;]

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

<a name="readkerberosgroupsname"></a>
# **ReadKerberosGroupsName**
> void ReadKerberosGroupsName (string name, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadKerberosGroupsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | Name of the LDAP group.
            var mountPath = "\"kerberos\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kerberos")

            try
            {
                apiInstance.ReadKerberosGroupsName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadKerberosGroupsName: " + e.Message );
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
 **name** | **string**| Name of the LDAP group. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kerberos&quot;]

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

<a name="readoidcconfig"></a>
# **ReadOidcConfig**
> void ReadOidcConfig (string mountPath = null)

Read the current JWT authentication backend configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadOidcConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"oidc\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oidc")

            try
            {
                // Read the current JWT authentication backend configuration.
                apiInstance.ReadOidcConfig(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadOidcConfig: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oidc&quot;]

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

<a name="readoidcoidccallback"></a>
# **ReadOidcOidcCallback**
> void ReadOidcOidcCallback (string mountPath = null)

Callback endpoint to complete an OIDC login.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadOidcOidcCallbackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"oidc\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oidc")

            try
            {
                // Callback endpoint to complete an OIDC login.
                apiInstance.ReadOidcOidcCallback(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadOidcOidcCallback: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oidc&quot;]

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

<a name="readoidcrolename"></a>
# **ReadOidcRoleName**
> void ReadOidcRoleName (string name, string mountPath = null)

Read an existing role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadOidcRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | Name of the role.
            var mountPath = "\"oidc\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oidc")

            try
            {
                // Read an existing role.
                apiInstance.ReadOidcRoleName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadOidcRoleName: " + e.Message );
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
 **name** | **string**| Name of the role. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oidc&quot;]

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

<a name="readoktaverifynonce"></a>
# **ReadOktaVerifyNonce**
> void ReadOktaVerifyNonce (string nonce, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadOktaVerifyNonceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var nonce = "nonce_example";  // string | Nonce provided during a login request to retrieve the number verification challenge for the matching request.
            var mountPath = "\"okta\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "okta")

            try
            {
                apiInstance.ReadOktaVerifyNonce(nonce, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadOktaVerifyNonce: " + e.Message );
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
 **nonce** | **string**| Nonce provided during a login request to retrieve the number verification challenge for the matching request. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;okta&quot;]

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

<a name="readradiususersname"></a>
# **ReadRadiusUsersName**
> void ReadRadiusUsersName (string name, string mountPath = null)

Manage users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadRadiusUsersNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | Name of the RADIUS user.
            var mountPath = "\"radius\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "radius")

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.ReadRadiusUsersName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadRadiusUsersName: " + e.Message );
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
 **name** | **string**| Name of the RADIUS user. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;radius&quot;]

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

<a name="readtokenlookup"></a>
# **ReadTokenLookup**
> void ReadTokenLookup (string mountPath = null)

This endpoint will lookup a token and its properties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadTokenLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint will lookup a token and its properties.
                apiInstance.ReadTokenLookup(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadTokenLookup: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

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

<a name="readtokenlookupself"></a>
# **ReadTokenLookupSelf**
> void ReadTokenLookupSelf (string mountPath = null)

This endpoint will lookup a token and its properties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadTokenLookupSelfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint will lookup a token and its properties.
                apiInstance.ReadTokenLookupSelf(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadTokenLookupSelf: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

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

<a name="readtokenrolesrolename"></a>
# **ReadTokenRolesRoleName**
> void ReadTokenRolesRoleName (string roleName, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadTokenRolesRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                apiInstance.ReadTokenRolesRoleName(roleName, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadTokenRolesRoleName: " + e.Message );
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
 **roleName** | **string**| Name of the role | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

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

<a name="readuserpassusersusername"></a>
# **ReadUserpassUsersUsername**
> void ReadUserpassUsersUsername (string username, string mountPath = null)

Manage users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadUserpassUsersUsernameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var username = "username_example";  // string | Username for this user.
            var mountPath = "\"userpass\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "userpass")

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.ReadUserpassUsersUsername(username, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadUserpassUsersUsername: " + e.Message );
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
 **username** | **string**| Username for this user. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;userpass&quot;]

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

<a name="updateapprolerolerolename"></a>
# **UpdateApproleRoleRoleName**
> void UpdateApproleRoleRoleName (string roleName, string mountPath = null, ApproleRoleRequest approleRoleRequest = null)

Register an role with the backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateApproleRoleRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")
            var approleRoleRequest = new ApproleRoleRequest(); // ApproleRoleRequest |  (optional) 

            try
            {
                // Register an role with the backend.
                apiInstance.UpdateApproleRoleRoleName(roleName, mountPath, approleRoleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateApproleRoleRoleName: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]
 **approleRoleRequest** | [**ApproleRoleRequest**](ApproleRoleRequest.md)|  | [optional] 

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

<a name="updateapprolerolerolenamebindsecretid"></a>
# **UpdateApproleRoleRoleNameBindSecretId**
> void UpdateApproleRoleRoleNameBindSecretId (string roleName, string mountPath = null, ApproleRoleBindSecretIdRequest approleRoleBindSecretIdRequest = null)

Impose secret_id to be presented during login using this role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateApproleRoleRoleNameBindSecretIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")
            var approleRoleBindSecretIdRequest = new ApproleRoleBindSecretIdRequest(); // ApproleRoleBindSecretIdRequest |  (optional) 

            try
            {
                // Impose secret_id to be presented during login using this role.
                apiInstance.UpdateApproleRoleRoleNameBindSecretId(roleName, mountPath, approleRoleBindSecretIdRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateApproleRoleRoleNameBindSecretId: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]
 **approleRoleBindSecretIdRequest** | [**ApproleRoleBindSecretIdRequest**](ApproleRoleBindSecretIdRequest.md)|  | [optional] 

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

<a name="updateapprolerolerolenameboundcidrlist"></a>
# **UpdateApproleRoleRoleNameBoundCidrList**
> void UpdateApproleRoleRoleNameBoundCidrList (string roleName, string mountPath = null, ApproleRoleBoundCidrListRequest approleRoleBoundCidrListRequest = null)

Deprecated: Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateApproleRoleRoleNameBoundCidrListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")
            var approleRoleBoundCidrListRequest = new ApproleRoleBoundCidrListRequest(); // ApproleRoleBoundCidrListRequest |  (optional) 

            try
            {
                // Deprecated: Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
                apiInstance.UpdateApproleRoleRoleNameBoundCidrList(roleName, mountPath, approleRoleBoundCidrListRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateApproleRoleRoleNameBoundCidrList: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]
 **approleRoleBoundCidrListRequest** | [**ApproleRoleBoundCidrListRequest**](ApproleRoleBoundCidrListRequest.md)|  | [optional] 

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

<a name="updateapprolerolerolenamecustomsecretid"></a>
# **UpdateApproleRoleRoleNameCustomSecretId**
> void UpdateApproleRoleRoleNameCustomSecretId (string roleName, string mountPath = null, ApproleRoleCustomSecretIdRequest approleRoleCustomSecretIdRequest = null)

Assign a SecretID of choice against the role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateApproleRoleRoleNameCustomSecretIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")
            var approleRoleCustomSecretIdRequest = new ApproleRoleCustomSecretIdRequest(); // ApproleRoleCustomSecretIdRequest |  (optional) 

            try
            {
                // Assign a SecretID of choice against the role.
                apiInstance.UpdateApproleRoleRoleNameCustomSecretId(roleName, mountPath, approleRoleCustomSecretIdRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateApproleRoleRoleNameCustomSecretId: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]
 **approleRoleCustomSecretIdRequest** | [**ApproleRoleCustomSecretIdRequest**](ApproleRoleCustomSecretIdRequest.md)|  | [optional] 

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

<a name="updateapprolerolerolenameperiod"></a>
# **UpdateApproleRoleRoleNamePeriod**
> void UpdateApproleRoleRoleNamePeriod (string roleName, string mountPath = null, ApproleRolePeriodRequest approleRolePeriodRequest = null)

Updates the value of 'period' on the role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateApproleRoleRoleNamePeriodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")
            var approleRolePeriodRequest = new ApproleRolePeriodRequest(); // ApproleRolePeriodRequest |  (optional) 

            try
            {
                // Updates the value of 'period' on the role
                apiInstance.UpdateApproleRoleRoleNamePeriod(roleName, mountPath, approleRolePeriodRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateApproleRoleRoleNamePeriod: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]
 **approleRolePeriodRequest** | [**ApproleRolePeriodRequest**](ApproleRolePeriodRequest.md)|  | [optional] 

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

<a name="updateapprolerolerolenamepolicies"></a>
# **UpdateApproleRoleRoleNamePolicies**
> void UpdateApproleRoleRoleNamePolicies (string roleName, string mountPath = null, ApproleRolePoliciesRequest approleRolePoliciesRequest = null)

Policies of the role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateApproleRoleRoleNamePoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")
            var approleRolePoliciesRequest = new ApproleRolePoliciesRequest(); // ApproleRolePoliciesRequest |  (optional) 

            try
            {
                // Policies of the role.
                apiInstance.UpdateApproleRoleRoleNamePolicies(roleName, mountPath, approleRolePoliciesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateApproleRoleRoleNamePolicies: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]
 **approleRolePoliciesRequest** | [**ApproleRolePoliciesRequest**](ApproleRolePoliciesRequest.md)|  | [optional] 

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

<a name="updateapprolerolerolenameroleid"></a>
# **UpdateApproleRoleRoleNameRoleId**
> void UpdateApproleRoleRoleNameRoleId (string roleName, string mountPath = null, ApproleRoleRoleIdRequest approleRoleRoleIdRequest = null)

Returns the 'role_id' of the role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateApproleRoleRoleNameRoleIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")
            var approleRoleRoleIdRequest = new ApproleRoleRoleIdRequest(); // ApproleRoleRoleIdRequest |  (optional) 

            try
            {
                // Returns the 'role_id' of the role.
                apiInstance.UpdateApproleRoleRoleNameRoleId(roleName, mountPath, approleRoleRoleIdRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateApproleRoleRoleNameRoleId: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]
 **approleRoleRoleIdRequest** | [**ApproleRoleRoleIdRequest**](ApproleRoleRoleIdRequest.md)|  | [optional] 

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

<a name="updateapprolerolerolenamesecretid"></a>
# **UpdateApproleRoleRoleNameSecretId**
> void UpdateApproleRoleRoleNameSecretId (string roleName, string mountPath = null, ApproleRoleSecretIdRequest approleRoleSecretIdRequest = null)

Generate a SecretID against this role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateApproleRoleRoleNameSecretIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")
            var approleRoleSecretIdRequest = new ApproleRoleSecretIdRequest(); // ApproleRoleSecretIdRequest |  (optional) 

            try
            {
                // Generate a SecretID against this role.
                apiInstance.UpdateApproleRoleRoleNameSecretId(roleName, mountPath, approleRoleSecretIdRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateApproleRoleRoleNameSecretId: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]
 **approleRoleSecretIdRequest** | [**ApproleRoleSecretIdRequest**](ApproleRoleSecretIdRequest.md)|  | [optional] 

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

<a name="updateapprolerolerolenamesecretidaccessordestroy"></a>
# **UpdateApproleRoleRoleNameSecretIdAccessorDestroy**
> void UpdateApproleRoleRoleNameSecretIdAccessorDestroy (string roleName, string mountPath = null, ApproleRoleSecretIdAccessorDestroyRequest approleRoleSecretIdAccessorDestroyRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateApproleRoleRoleNameSecretIdAccessorDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")
            var approleRoleSecretIdAccessorDestroyRequest = new ApproleRoleSecretIdAccessorDestroyRequest(); // ApproleRoleSecretIdAccessorDestroyRequest |  (optional) 

            try
            {
                apiInstance.UpdateApproleRoleRoleNameSecretIdAccessorDestroy(roleName, mountPath, approleRoleSecretIdAccessorDestroyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateApproleRoleRoleNameSecretIdAccessorDestroy: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]
 **approleRoleSecretIdAccessorDestroyRequest** | [**ApproleRoleSecretIdAccessorDestroyRequest**](ApproleRoleSecretIdAccessorDestroyRequest.md)|  | [optional] 

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

<a name="updateapprolerolerolenamesecretidaccessorlookup"></a>
# **UpdateApproleRoleRoleNameSecretIdAccessorLookup**
> void UpdateApproleRoleRoleNameSecretIdAccessorLookup (string roleName, string mountPath = null, ApproleRoleSecretIdAccessorLookupRequest approleRoleSecretIdAccessorLookupRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateApproleRoleRoleNameSecretIdAccessorLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")
            var approleRoleSecretIdAccessorLookupRequest = new ApproleRoleSecretIdAccessorLookupRequest(); // ApproleRoleSecretIdAccessorLookupRequest |  (optional) 

            try
            {
                apiInstance.UpdateApproleRoleRoleNameSecretIdAccessorLookup(roleName, mountPath, approleRoleSecretIdAccessorLookupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateApproleRoleRoleNameSecretIdAccessorLookup: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]
 **approleRoleSecretIdAccessorLookupRequest** | [**ApproleRoleSecretIdAccessorLookupRequest**](ApproleRoleSecretIdAccessorLookupRequest.md)|  | [optional] 

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

<a name="updateapprolerolerolenamesecretidboundcidrs"></a>
# **UpdateApproleRoleRoleNameSecretIdBoundCidrs**
> void UpdateApproleRoleRoleNameSecretIdBoundCidrs (string roleName, string mountPath = null, ApproleRoleSecretIdBoundCidrsRequest approleRoleSecretIdBoundCidrsRequest = null)

Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateApproleRoleRoleNameSecretIdBoundCidrsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")
            var approleRoleSecretIdBoundCidrsRequest = new ApproleRoleSecretIdBoundCidrsRequest(); // ApproleRoleSecretIdBoundCidrsRequest |  (optional) 

            try
            {
                // Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
                apiInstance.UpdateApproleRoleRoleNameSecretIdBoundCidrs(roleName, mountPath, approleRoleSecretIdBoundCidrsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateApproleRoleRoleNameSecretIdBoundCidrs: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]
 **approleRoleSecretIdBoundCidrsRequest** | [**ApproleRoleSecretIdBoundCidrsRequest**](ApproleRoleSecretIdBoundCidrsRequest.md)|  | [optional] 

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

<a name="updateapprolerolerolenamesecretiddestroy"></a>
# **UpdateApproleRoleRoleNameSecretIdDestroy**
> void UpdateApproleRoleRoleNameSecretIdDestroy (string roleName, string mountPath = null, ApproleRoleSecretIdDestroyRequest approleRoleSecretIdDestroyRequest = null)

Invalidate an issued secret_id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateApproleRoleRoleNameSecretIdDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")
            var approleRoleSecretIdDestroyRequest = new ApproleRoleSecretIdDestroyRequest(); // ApproleRoleSecretIdDestroyRequest |  (optional) 

            try
            {
                // Invalidate an issued secret_id
                apiInstance.UpdateApproleRoleRoleNameSecretIdDestroy(roleName, mountPath, approleRoleSecretIdDestroyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateApproleRoleRoleNameSecretIdDestroy: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]
 **approleRoleSecretIdDestroyRequest** | [**ApproleRoleSecretIdDestroyRequest**](ApproleRoleSecretIdDestroyRequest.md)|  | [optional] 

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

<a name="updateapprolerolerolenamesecretidlookup"></a>
# **UpdateApproleRoleRoleNameSecretIdLookup**
> void UpdateApproleRoleRoleNameSecretIdLookup (string roleName, string mountPath = null, ApproleRoleSecretIdLookupRequest approleRoleSecretIdLookupRequest = null)

Read the properties of an issued secret_id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateApproleRoleRoleNameSecretIdLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")
            var approleRoleSecretIdLookupRequest = new ApproleRoleSecretIdLookupRequest(); // ApproleRoleSecretIdLookupRequest |  (optional) 

            try
            {
                // Read the properties of an issued secret_id
                apiInstance.UpdateApproleRoleRoleNameSecretIdLookup(roleName, mountPath, approleRoleSecretIdLookupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateApproleRoleRoleNameSecretIdLookup: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]
 **approleRoleSecretIdLookupRequest** | [**ApproleRoleSecretIdLookupRequest**](ApproleRoleSecretIdLookupRequest.md)|  | [optional] 

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

<a name="updateapprolerolerolenamesecretidnumuses"></a>
# **UpdateApproleRoleRoleNameSecretIdNumUses**
> void UpdateApproleRoleRoleNameSecretIdNumUses (string roleName, string mountPath = null, ApproleRoleSecretIdNumUsesRequest approleRoleSecretIdNumUsesRequest = null)

Use limit of the SecretID generated against the role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateApproleRoleRoleNameSecretIdNumUsesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")
            var approleRoleSecretIdNumUsesRequest = new ApproleRoleSecretIdNumUsesRequest(); // ApproleRoleSecretIdNumUsesRequest |  (optional) 

            try
            {
                // Use limit of the SecretID generated against the role.
                apiInstance.UpdateApproleRoleRoleNameSecretIdNumUses(roleName, mountPath, approleRoleSecretIdNumUsesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateApproleRoleRoleNameSecretIdNumUses: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]
 **approleRoleSecretIdNumUsesRequest** | [**ApproleRoleSecretIdNumUsesRequest**](ApproleRoleSecretIdNumUsesRequest.md)|  | [optional] 

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

<a name="updateapprolerolerolenamesecretidttl"></a>
# **UpdateApproleRoleRoleNameSecretIdTtl**
> void UpdateApproleRoleRoleNameSecretIdTtl (string roleName, string mountPath = null, ApproleRoleSecretIdTtlRequest approleRoleSecretIdTtlRequest = null)

Duration in seconds of the SecretID generated against the role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateApproleRoleRoleNameSecretIdTtlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")
            var approleRoleSecretIdTtlRequest = new ApproleRoleSecretIdTtlRequest(); // ApproleRoleSecretIdTtlRequest |  (optional) 

            try
            {
                // Duration in seconds of the SecretID generated against the role.
                apiInstance.UpdateApproleRoleRoleNameSecretIdTtl(roleName, mountPath, approleRoleSecretIdTtlRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateApproleRoleRoleNameSecretIdTtl: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]
 **approleRoleSecretIdTtlRequest** | [**ApproleRoleSecretIdTtlRequest**](ApproleRoleSecretIdTtlRequest.md)|  | [optional] 

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

<a name="updateapprolerolerolenametokenboundcidrs"></a>
# **UpdateApproleRoleRoleNameTokenBoundCidrs**
> void UpdateApproleRoleRoleNameTokenBoundCidrs (string roleName, string mountPath = null, ApproleRoleTokenBoundCidrsRequest approleRoleTokenBoundCidrsRequest = null)

Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateApproleRoleRoleNameTokenBoundCidrsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")
            var approleRoleTokenBoundCidrsRequest = new ApproleRoleTokenBoundCidrsRequest(); // ApproleRoleTokenBoundCidrsRequest |  (optional) 

            try
            {
                // Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token.
                apiInstance.UpdateApproleRoleRoleNameTokenBoundCidrs(roleName, mountPath, approleRoleTokenBoundCidrsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateApproleRoleRoleNameTokenBoundCidrs: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]
 **approleRoleTokenBoundCidrsRequest** | [**ApproleRoleTokenBoundCidrsRequest**](ApproleRoleTokenBoundCidrsRequest.md)|  | [optional] 

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

<a name="updateapprolerolerolenametokenmaxttl"></a>
# **UpdateApproleRoleRoleNameTokenMaxTtl**
> void UpdateApproleRoleRoleNameTokenMaxTtl (string roleName, string mountPath = null, ApproleRoleTokenMaxTtlRequest approleRoleTokenMaxTtlRequest = null)

Duration in seconds, the maximum lifetime of the tokens issued by using the SecretIDs that were generated against this role, after which the tokens are not allowed to be renewed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateApproleRoleRoleNameTokenMaxTtlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")
            var approleRoleTokenMaxTtlRequest = new ApproleRoleTokenMaxTtlRequest(); // ApproleRoleTokenMaxTtlRequest |  (optional) 

            try
            {
                // Duration in seconds, the maximum lifetime of the tokens issued by using the SecretIDs that were generated against this role, after which the tokens are not allowed to be renewed.
                apiInstance.UpdateApproleRoleRoleNameTokenMaxTtl(roleName, mountPath, approleRoleTokenMaxTtlRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateApproleRoleRoleNameTokenMaxTtl: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]
 **approleRoleTokenMaxTtlRequest** | [**ApproleRoleTokenMaxTtlRequest**](ApproleRoleTokenMaxTtlRequest.md)|  | [optional] 

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

<a name="updateapprolerolerolenametokennumuses"></a>
# **UpdateApproleRoleRoleNameTokenNumUses**
> void UpdateApproleRoleRoleNameTokenNumUses (string roleName, string mountPath = null, ApproleRoleTokenNumUsesRequest approleRoleTokenNumUsesRequest = null)

Number of times issued tokens can be used

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateApproleRoleRoleNameTokenNumUsesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")
            var approleRoleTokenNumUsesRequest = new ApproleRoleTokenNumUsesRequest(); // ApproleRoleTokenNumUsesRequest |  (optional) 

            try
            {
                // Number of times issued tokens can be used
                apiInstance.UpdateApproleRoleRoleNameTokenNumUses(roleName, mountPath, approleRoleTokenNumUsesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateApproleRoleRoleNameTokenNumUses: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]
 **approleRoleTokenNumUsesRequest** | [**ApproleRoleTokenNumUsesRequest**](ApproleRoleTokenNumUsesRequest.md)|  | [optional] 

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

<a name="updateapprolerolerolenametokenttl"></a>
# **UpdateApproleRoleRoleNameTokenTtl**
> void UpdateApproleRoleRoleNameTokenTtl (string roleName, string mountPath = null, ApproleRoleTokenTtlRequest approleRoleTokenTtlRequest = null)

Duration in seconds, the lifetime of the token issued by using the SecretID that is generated against this role, before which the token needs to be renewed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateApproleRoleRoleNameTokenTtlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role. Must be less than 4096 bytes.
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")
            var approleRoleTokenTtlRequest = new ApproleRoleTokenTtlRequest(); // ApproleRoleTokenTtlRequest |  (optional) 

            try
            {
                // Duration in seconds, the lifetime of the token issued by using the SecretID that is generated against this role, before which the token needs to be renewed.
                apiInstance.UpdateApproleRoleRoleNameTokenTtl(roleName, mountPath, approleRoleTokenTtlRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateApproleRoleRoleNameTokenTtl: " + e.Message );
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
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]
 **approleRoleTokenTtlRequest** | [**ApproleRoleTokenTtlRequest**](ApproleRoleTokenTtlRequest.md)|  | [optional] 

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

<a name="updateapproletidysecretid"></a>
# **UpdateApproleTidySecretId**
> void UpdateApproleTidySecretId (string mountPath = null)

Trigger the clean-up of expired SecretID entries.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateApproleTidySecretIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Trigger the clean-up of expired SecretID entries.
                apiInstance.UpdateApproleTidySecretId(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateApproleTidySecretId: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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

<a name="updateawsconfigcertificatecertname"></a>
# **UpdateAwsConfigCertificateCertName**
> void UpdateAwsConfigCertificateCertName (string certName, string mountPath = null, AwsConfigCertificateRequest awsConfigCertificateRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateAwsConfigCertificateCertNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var certName = "certName_example";  // string | Name of the certificate.
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")
            var awsConfigCertificateRequest = new AwsConfigCertificateRequest(); // AwsConfigCertificateRequest |  (optional) 

            try
            {
                apiInstance.UpdateAwsConfigCertificateCertName(certName, mountPath, awsConfigCertificateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateAwsConfigCertificateCertName: " + e.Message );
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
 **certName** | **string**| Name of the certificate. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]
 **awsConfigCertificateRequest** | [**AwsConfigCertificateRequest**](AwsConfigCertificateRequest.md)|  | [optional] 

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

<a name="updateawsconfigclient"></a>
# **UpdateAwsConfigClient**
> void UpdateAwsConfigClient (string mountPath = null, AwsConfigClientRequest awsConfigClientRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateAwsConfigClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")
            var awsConfigClientRequest = new AwsConfigClientRequest(); // AwsConfigClientRequest |  (optional) 

            try
            {
                apiInstance.UpdateAwsConfigClient(mountPath, awsConfigClientRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateAwsConfigClient: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]
 **awsConfigClientRequest** | [**AwsConfigClientRequest**](AwsConfigClientRequest.md)|  | [optional] 

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

<a name="updateawsconfigidentity"></a>
# **UpdateAwsConfigIdentity**
> void UpdateAwsConfigIdentity (string mountPath = null, AwsConfigIdentityRequest awsConfigIdentityRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateAwsConfigIdentityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")
            var awsConfigIdentityRequest = new AwsConfigIdentityRequest(); // AwsConfigIdentityRequest |  (optional) 

            try
            {
                apiInstance.UpdateAwsConfigIdentity(mountPath, awsConfigIdentityRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateAwsConfigIdentity: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]
 **awsConfigIdentityRequest** | [**AwsConfigIdentityRequest**](AwsConfigIdentityRequest.md)|  | [optional] 

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

<a name="updateawsconfigrotateroot"></a>
# **UpdateAwsConfigRotateRoot**
> void UpdateAwsConfigRotateRoot (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateAwsConfigRotateRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.UpdateAwsConfigRotateRoot(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateAwsConfigRotateRoot: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="updateawsconfigstsaccountid"></a>
# **UpdateAwsConfigStsAccountId**
> void UpdateAwsConfigStsAccountId (string accountId, string mountPath = null, AwsConfigStsRequest awsConfigStsRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateAwsConfigStsAccountIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var accountId = "accountId_example";  // string | AWS account ID to be associated with STS role. If set, Vault will use assumed credentials to verify any login attempts from EC2 instances in this account.
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")
            var awsConfigStsRequest = new AwsConfigStsRequest(); // AwsConfigStsRequest |  (optional) 

            try
            {
                apiInstance.UpdateAwsConfigStsAccountId(accountId, mountPath, awsConfigStsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateAwsConfigStsAccountId: " + e.Message );
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
 **accountId** | **string**| AWS account ID to be associated with STS role. If set, Vault will use assumed credentials to verify any login attempts from EC2 instances in this account. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]
 **awsConfigStsRequest** | [**AwsConfigStsRequest**](AwsConfigStsRequest.md)|  | [optional] 

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

<a name="updateawsconfigtidyidentityaccesslist"></a>
# **UpdateAwsConfigTidyIdentityAccesslist**
> void UpdateAwsConfigTidyIdentityAccesslist (string mountPath = null, AwsConfigTidyIdentityAccesslistRequest awsConfigTidyIdentityAccesslistRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateAwsConfigTidyIdentityAccesslistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")
            var awsConfigTidyIdentityAccesslistRequest = new AwsConfigTidyIdentityAccesslistRequest(); // AwsConfigTidyIdentityAccesslistRequest |  (optional) 

            try
            {
                apiInstance.UpdateAwsConfigTidyIdentityAccesslist(mountPath, awsConfigTidyIdentityAccesslistRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateAwsConfigTidyIdentityAccesslist: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]
 **awsConfigTidyIdentityAccesslistRequest** | [**AwsConfigTidyIdentityAccesslistRequest**](AwsConfigTidyIdentityAccesslistRequest.md)|  | [optional] 

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

<a name="updateawsconfigtidyidentitywhitelist"></a>
# **UpdateAwsConfigTidyIdentityWhitelist**
> void UpdateAwsConfigTidyIdentityWhitelist (string mountPath = null, AwsConfigTidyIdentityWhitelistRequest awsConfigTidyIdentityWhitelistRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateAwsConfigTidyIdentityWhitelistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")
            var awsConfigTidyIdentityWhitelistRequest = new AwsConfigTidyIdentityWhitelistRequest(); // AwsConfigTidyIdentityWhitelistRequest |  (optional) 

            try
            {
                apiInstance.UpdateAwsConfigTidyIdentityWhitelist(mountPath, awsConfigTidyIdentityWhitelistRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateAwsConfigTidyIdentityWhitelist: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]
 **awsConfigTidyIdentityWhitelistRequest** | [**AwsConfigTidyIdentityWhitelistRequest**](AwsConfigTidyIdentityWhitelistRequest.md)|  | [optional] 

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

<a name="updateawsconfigtidyroletagblacklist"></a>
# **UpdateAwsConfigTidyRoletagBlacklist**
> void UpdateAwsConfigTidyRoletagBlacklist (string mountPath = null, AwsConfigTidyRoletagBlacklistRequest awsConfigTidyRoletagBlacklistRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateAwsConfigTidyRoletagBlacklistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")
            var awsConfigTidyRoletagBlacklistRequest = new AwsConfigTidyRoletagBlacklistRequest(); // AwsConfigTidyRoletagBlacklistRequest |  (optional) 

            try
            {
                apiInstance.UpdateAwsConfigTidyRoletagBlacklist(mountPath, awsConfigTidyRoletagBlacklistRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateAwsConfigTidyRoletagBlacklist: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]
 **awsConfigTidyRoletagBlacklistRequest** | [**AwsConfigTidyRoletagBlacklistRequest**](AwsConfigTidyRoletagBlacklistRequest.md)|  | [optional] 

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

<a name="updateawsconfigtidyroletagdenylist"></a>
# **UpdateAwsConfigTidyRoletagDenylist**
> void UpdateAwsConfigTidyRoletagDenylist (string mountPath = null, AwsConfigTidyRoletagDenylistRequest awsConfigTidyRoletagDenylistRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateAwsConfigTidyRoletagDenylistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")
            var awsConfigTidyRoletagDenylistRequest = new AwsConfigTidyRoletagDenylistRequest(); // AwsConfigTidyRoletagDenylistRequest |  (optional) 

            try
            {
                apiInstance.UpdateAwsConfigTidyRoletagDenylist(mountPath, awsConfigTidyRoletagDenylistRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateAwsConfigTidyRoletagDenylist: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]
 **awsConfigTidyRoletagDenylistRequest** | [**AwsConfigTidyRoletagDenylistRequest**](AwsConfigTidyRoletagDenylistRequest.md)|  | [optional] 

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

<a name="updateawsrolerole"></a>
# **UpdateAwsRoleRole**
> void UpdateAwsRoleRole (string role, string mountPath = null, AwsRoleRequest awsRoleRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateAwsRoleRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var role = "role_example";  // string | Name of the role.
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")
            var awsRoleRequest = new AwsRoleRequest(); // AwsRoleRequest |  (optional) 

            try
            {
                apiInstance.UpdateAwsRoleRole(role, mountPath, awsRoleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateAwsRoleRole: " + e.Message );
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
 **role** | **string**| Name of the role. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]
 **awsRoleRequest** | [**AwsRoleRequest**](AwsRoleRequest.md)|  | [optional] 

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

<a name="updateawsroleroletag"></a>
# **UpdateAwsRoleRoleTag**
> void UpdateAwsRoleRoleTag (string role, string mountPath = null, AwsRoleTagRequest awsRoleTagRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateAwsRoleRoleTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var role = "role_example";  // string | Name of the role.
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")
            var awsRoleTagRequest = new AwsRoleTagRequest(); // AwsRoleTagRequest |  (optional) 

            try
            {
                apiInstance.UpdateAwsRoleRoleTag(role, mountPath, awsRoleTagRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateAwsRoleRoleTag: " + e.Message );
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
 **role** | **string**| Name of the role. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]
 **awsRoleTagRequest** | [**AwsRoleTagRequest**](AwsRoleTagRequest.md)|  | [optional] 

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

<a name="updateawsroletagblacklistroletag"></a>
# **UpdateAwsRoletagBlacklistRoleTag**
> void UpdateAwsRoletagBlacklistRoleTag (string roleTag, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateAwsRoletagBlacklistRoleTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleTag = "roleTag_example";  // string | Role tag to be deny listed. The tag can be supplied as-is. In order to avoid any encoding problems, it can be base64 encoded.
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.UpdateAwsRoletagBlacklistRoleTag(roleTag, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateAwsRoletagBlacklistRoleTag: " + e.Message );
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
 **roleTag** | **string**| Role tag to be deny listed. The tag can be supplied as-is. In order to avoid any encoding problems, it can be base64 encoded. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="updateawsroletagdenylistroletag"></a>
# **UpdateAwsRoletagDenylistRoleTag**
> void UpdateAwsRoletagDenylistRoleTag (string roleTag, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateAwsRoletagDenylistRoleTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleTag = "roleTag_example";  // string | Role tag to be deny listed. The tag can be supplied as-is. In order to avoid any encoding problems, it can be base64 encoded.
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.UpdateAwsRoletagDenylistRoleTag(roleTag, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateAwsRoletagDenylistRoleTag: " + e.Message );
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
 **roleTag** | **string**| Role tag to be deny listed. The tag can be supplied as-is. In order to avoid any encoding problems, it can be base64 encoded. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="updateawstidyidentityaccesslist"></a>
# **UpdateAwsTidyIdentityAccesslist**
> void UpdateAwsTidyIdentityAccesslist (string mountPath = null, AwsTidyIdentityAccesslistRequest awsTidyIdentityAccesslistRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateAwsTidyIdentityAccesslistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")
            var awsTidyIdentityAccesslistRequest = new AwsTidyIdentityAccesslistRequest(); // AwsTidyIdentityAccesslistRequest |  (optional) 

            try
            {
                apiInstance.UpdateAwsTidyIdentityAccesslist(mountPath, awsTidyIdentityAccesslistRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateAwsTidyIdentityAccesslist: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]
 **awsTidyIdentityAccesslistRequest** | [**AwsTidyIdentityAccesslistRequest**](AwsTidyIdentityAccesslistRequest.md)|  | [optional] 

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

<a name="updateawstidyidentitywhitelist"></a>
# **UpdateAwsTidyIdentityWhitelist**
> void UpdateAwsTidyIdentityWhitelist (string mountPath = null, AwsTidyIdentityWhitelistRequest awsTidyIdentityWhitelistRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateAwsTidyIdentityWhitelistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")
            var awsTidyIdentityWhitelistRequest = new AwsTidyIdentityWhitelistRequest(); // AwsTidyIdentityWhitelistRequest |  (optional) 

            try
            {
                apiInstance.UpdateAwsTidyIdentityWhitelist(mountPath, awsTidyIdentityWhitelistRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateAwsTidyIdentityWhitelist: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]
 **awsTidyIdentityWhitelistRequest** | [**AwsTidyIdentityWhitelistRequest**](AwsTidyIdentityWhitelistRequest.md)|  | [optional] 

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

<a name="updateawstidyroletagblacklist"></a>
# **UpdateAwsTidyRoletagBlacklist**
> void UpdateAwsTidyRoletagBlacklist (string mountPath = null, AwsTidyRoletagBlacklistRequest awsTidyRoletagBlacklistRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateAwsTidyRoletagBlacklistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")
            var awsTidyRoletagBlacklistRequest = new AwsTidyRoletagBlacklistRequest(); // AwsTidyRoletagBlacklistRequest |  (optional) 

            try
            {
                apiInstance.UpdateAwsTidyRoletagBlacklist(mountPath, awsTidyRoletagBlacklistRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateAwsTidyRoletagBlacklist: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]
 **awsTidyRoletagBlacklistRequest** | [**AwsTidyRoletagBlacklistRequest**](AwsTidyRoletagBlacklistRequest.md)|  | [optional] 

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

<a name="updateawstidyroletagdenylist"></a>
# **UpdateAwsTidyRoletagDenylist**
> void UpdateAwsTidyRoletagDenylist (string mountPath = null, AwsTidyRoletagDenylistRequest awsTidyRoletagDenylistRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateAwsTidyRoletagDenylistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")
            var awsTidyRoletagDenylistRequest = new AwsTidyRoletagDenylistRequest(); // AwsTidyRoletagDenylistRequest |  (optional) 

            try
            {
                apiInstance.UpdateAwsTidyRoletagDenylist(mountPath, awsTidyRoletagDenylistRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateAwsTidyRoletagDenylist: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]
 **awsTidyRoletagDenylistRequest** | [**AwsTidyRoletagDenylistRequest**](AwsTidyRoletagDenylistRequest.md)|  | [optional] 

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

<a name="updatecertcertsname"></a>
# **UpdateCertCertsName**
> void UpdateCertCertsName (string name, string mountPath = null, CertCertsRequest certCertsRequest = null)

Manage trusted certificates used for authentication.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateCertCertsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The name of the certificate
            var mountPath = "\"cert\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cert")
            var certCertsRequest = new CertCertsRequest(); // CertCertsRequest |  (optional) 

            try
            {
                // Manage trusted certificates used for authentication.
                apiInstance.UpdateCertCertsName(name, mountPath, certCertsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateCertCertsName: " + e.Message );
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
 **name** | **string**| The name of the certificate | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cert&quot;]
 **certCertsRequest** | [**CertCertsRequest**](CertCertsRequest.md)|  | [optional] 

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

<a name="updatecertcrlsname"></a>
# **UpdateCertCrlsName**
> void UpdateCertCrlsName (string name, string mountPath = null, CertCrlsRequest certCrlsRequest = null)

Manage Certificate Revocation Lists checked during authentication.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateCertCrlsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The name of the certificate
            var mountPath = "\"cert\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cert")
            var certCrlsRequest = new CertCrlsRequest(); // CertCrlsRequest |  (optional) 

            try
            {
                // Manage Certificate Revocation Lists checked during authentication.
                apiInstance.UpdateCertCrlsName(name, mountPath, certCrlsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateCertCrlsName: " + e.Message );
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
 **name** | **string**| The name of the certificate | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cert&quot;]
 **certCrlsRequest** | [**CertCrlsRequest**](CertCrlsRequest.md)|  | [optional] 

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

<a name="updatecfrolesrole"></a>
# **UpdateCfRolesRole**
> void UpdateCfRolesRole (string role, string mountPath = null, CfRolesRequest cfRolesRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateCfRolesRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var role = "role_example";  // string | The name of the role.
            var mountPath = "\"cf\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cf")
            var cfRolesRequest = new CfRolesRequest(); // CfRolesRequest |  (optional) 

            try
            {
                apiInstance.UpdateCfRolesRole(role, mountPath, cfRolesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateCfRolesRole: " + e.Message );
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
 **role** | **string**| The name of the role. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cf&quot;]
 **cfRolesRequest** | [**CfRolesRequest**](CfRolesRequest.md)|  | [optional] 

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

<a name="updategcprolenamelabels"></a>
# **UpdateGcpRoleNameLabels**
> void UpdateGcpRoleNameLabels (string name, string mountPath = null, GcpRoleLabelsRequest gcpRoleLabelsRequest = null)

Add or remove labels for an existing 'gce' role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateGcpRoleNameLabelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | Name of the role.
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")
            var gcpRoleLabelsRequest = new GcpRoleLabelsRequest(); // GcpRoleLabelsRequest |  (optional) 

            try
            {
                // Add or remove labels for an existing 'gce' role
                apiInstance.UpdateGcpRoleNameLabels(name, mountPath, gcpRoleLabelsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateGcpRoleNameLabels: " + e.Message );
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
 **name** | **string**| Name of the role. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcp&quot;]
 **gcpRoleLabelsRequest** | [**GcpRoleLabelsRequest**](GcpRoleLabelsRequest.md)|  | [optional] 

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

<a name="updategcprolenameserviceaccounts"></a>
# **UpdateGcpRoleNameServiceAccounts**
> void UpdateGcpRoleNameServiceAccounts (string name, string mountPath = null, GcpRoleServiceAccountsRequest gcpRoleServiceAccountsRequest = null)

Add or remove service accounts for an existing `iam` role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateGcpRoleNameServiceAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | Name of the role.
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")
            var gcpRoleServiceAccountsRequest = new GcpRoleServiceAccountsRequest(); // GcpRoleServiceAccountsRequest |  (optional) 

            try
            {
                // Add or remove service accounts for an existing `iam` role
                apiInstance.UpdateGcpRoleNameServiceAccounts(name, mountPath, gcpRoleServiceAccountsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateGcpRoleNameServiceAccounts: " + e.Message );
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
 **name** | **string**| Name of the role. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcp&quot;]
 **gcpRoleServiceAccountsRequest** | [**GcpRoleServiceAccountsRequest**](GcpRoleServiceAccountsRequest.md)|  | [optional] 

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

<a name="updategithubmapteamskey"></a>
# **UpdateGithubMapTeamsKey**
> void UpdateGithubMapTeamsKey (string key, string mountPath = null, GithubMapTeamsRequest githubMapTeamsRequest = null)

Read/write/delete a single teams mapping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateGithubMapTeamsKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var key = "key_example";  // string | Key for the teams mapping
            var mountPath = "\"github\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "github")
            var githubMapTeamsRequest = new GithubMapTeamsRequest(); // GithubMapTeamsRequest |  (optional) 

            try
            {
                // Read/write/delete a single teams mapping
                apiInstance.UpdateGithubMapTeamsKey(key, mountPath, githubMapTeamsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateGithubMapTeamsKey: " + e.Message );
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
 **key** | **string**| Key for the teams mapping | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;github&quot;]
 **githubMapTeamsRequest** | [**GithubMapTeamsRequest**](GithubMapTeamsRequest.md)|  | [optional] 

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

<a name="updategithubmapuserskey"></a>
# **UpdateGithubMapUsersKey**
> void UpdateGithubMapUsersKey (string key, string mountPath = null, GithubMapUsersRequest githubMapUsersRequest = null)

Read/write/delete a single users mapping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateGithubMapUsersKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var key = "key_example";  // string | Key for the users mapping
            var mountPath = "\"github\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "github")
            var githubMapUsersRequest = new GithubMapUsersRequest(); // GithubMapUsersRequest |  (optional) 

            try
            {
                // Read/write/delete a single users mapping
                apiInstance.UpdateGithubMapUsersKey(key, mountPath, githubMapUsersRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateGithubMapUsersKey: " + e.Message );
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
 **key** | **string**| Key for the users mapping | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;github&quot;]
 **githubMapUsersRequest** | [**GithubMapUsersRequest**](GithubMapUsersRequest.md)|  | [optional] 

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

<a name="updatekerberosconfigldap"></a>
# **UpdateKerberosConfigLdap**
> void UpdateKerberosConfigLdap (string mountPath = null, KerberosConfigLdapRequest kerberosConfigLdapRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateKerberosConfigLdapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"kerberos\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kerberos")
            var kerberosConfigLdapRequest = new KerberosConfigLdapRequest(); // KerberosConfigLdapRequest |  (optional) 

            try
            {
                apiInstance.UpdateKerberosConfigLdap(mountPath, kerberosConfigLdapRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateKerberosConfigLdap: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kerberos&quot;]
 **kerberosConfigLdapRequest** | [**KerberosConfigLdapRequest**](KerberosConfigLdapRequest.md)|  | [optional] 

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

<a name="updatekerberosgroupsname"></a>
# **UpdateKerberosGroupsName**
> void UpdateKerberosGroupsName (string name, string mountPath = null, KerberosGroupsRequest kerberosGroupsRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateKerberosGroupsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | Name of the LDAP group.
            var mountPath = "\"kerberos\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kerberos")
            var kerberosGroupsRequest = new KerberosGroupsRequest(); // KerberosGroupsRequest |  (optional) 

            try
            {
                apiInstance.UpdateKerberosGroupsName(name, mountPath, kerberosGroupsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateKerberosGroupsName: " + e.Message );
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
 **name** | **string**| Name of the LDAP group. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kerberos&quot;]
 **kerberosGroupsRequest** | [**KerberosGroupsRequest**](KerberosGroupsRequest.md)|  | [optional] 

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

<a name="updateociloginrole"></a>
# **UpdateOciLoginRole**
> void UpdateOciLoginRole (string role, string mountPath = null, OciLoginRequest ociLoginRequest = null)

Authenticates to Vault using OCI credentials

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateOciLoginRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var role = "role_example";  // string | Name of the role.
            var mountPath = "\"oci\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oci")
            var ociLoginRequest = new OciLoginRequest(); // OciLoginRequest |  (optional) 

            try
            {
                // Authenticates to Vault using OCI credentials
                apiInstance.UpdateOciLoginRole(role, mountPath, ociLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateOciLoginRole: " + e.Message );
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
 **role** | **string**| Name of the role. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oci&quot;]
 **ociLoginRequest** | [**OciLoginRequest**](OciLoginRequest.md)|  | [optional] 

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

<a name="updateoidcconfig"></a>
# **UpdateOidcConfig**
> void UpdateOidcConfig (string mountPath = null, OidcConfigRequest oidcConfigRequest = null)

Configure the JWT authentication backend.

The JWT authentication backend validates JWTs (or OIDC) using the configured credentials. If using OIDC Discovery, the URL must be provided, along with (optionally) the CA cert to use for the connection. If performing JWT validation locally, a set of public keys must be provided.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateOidcConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"oidc\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oidc")
            var oidcConfigRequest = new OidcConfigRequest(); // OidcConfigRequest |  (optional) 

            try
            {
                // Configure the JWT authentication backend.
                apiInstance.UpdateOidcConfig(mountPath, oidcConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateOidcConfig: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oidc&quot;]
 **oidcConfigRequest** | [**OidcConfigRequest**](OidcConfigRequest.md)|  | [optional] 

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

<a name="updateoidclogin"></a>
# **UpdateOidcLogin**
> void UpdateOidcLogin (string mountPath = null, OidcLoginRequest oidcLoginRequest = null)

Authenticates to Vault using a JWT (or OIDC) token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateOidcLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"oidc\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oidc")
            var oidcLoginRequest = new OidcLoginRequest(); // OidcLoginRequest |  (optional) 

            try
            {
                // Authenticates to Vault using a JWT (or OIDC) token.
                apiInstance.UpdateOidcLogin(mountPath, oidcLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateOidcLogin: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oidc&quot;]
 **oidcLoginRequest** | [**OidcLoginRequest**](OidcLoginRequest.md)|  | [optional] 

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

<a name="updateoidcoidcauthurl"></a>
# **UpdateOidcOidcAuthUrl**
> void UpdateOidcOidcAuthUrl (string mountPath = null, OidcOidcAuthUrlRequest oidcOidcAuthUrlRequest = null)

Request an authorization URL to start an OIDC login flow.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateOidcOidcAuthUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"oidc\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oidc")
            var oidcOidcAuthUrlRequest = new OidcOidcAuthUrlRequest(); // OidcOidcAuthUrlRequest |  (optional) 

            try
            {
                // Request an authorization URL to start an OIDC login flow.
                apiInstance.UpdateOidcOidcAuthUrl(mountPath, oidcOidcAuthUrlRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateOidcOidcAuthUrl: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oidc&quot;]
 **oidcOidcAuthUrlRequest** | [**OidcOidcAuthUrlRequest**](OidcOidcAuthUrlRequest.md)|  | [optional] 

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

<a name="updateoidcoidccallback"></a>
# **UpdateOidcOidcCallback**
> void UpdateOidcOidcCallback (string mountPath = null, OidcOidcCallbackRequest oidcOidcCallbackRequest = null)

Callback endpoint to handle form_posts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateOidcOidcCallbackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"oidc\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oidc")
            var oidcOidcCallbackRequest = new OidcOidcCallbackRequest(); // OidcOidcCallbackRequest |  (optional) 

            try
            {
                // Callback endpoint to handle form_posts.
                apiInstance.UpdateOidcOidcCallback(mountPath, oidcOidcCallbackRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateOidcOidcCallback: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oidc&quot;]
 **oidcOidcCallbackRequest** | [**OidcOidcCallbackRequest**](OidcOidcCallbackRequest.md)|  | [optional] 

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

<a name="updateoidcrolename"></a>
# **UpdateOidcRoleName**
> void UpdateOidcRoleName (string name, string mountPath = null, OidcRoleRequest oidcRoleRequest = null)

Register an role with the backend.

A role is required to authenticate with this backend. The role binds   JWT token information with token policies and settings.   The bindings, token polices and token settings can all be configured   using this endpoint

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateOidcRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | Name of the role.
            var mountPath = "\"oidc\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oidc")
            var oidcRoleRequest = new OidcRoleRequest(); // OidcRoleRequest |  (optional) 

            try
            {
                // Register an role with the backend.
                apiInstance.UpdateOidcRoleName(name, mountPath, oidcRoleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateOidcRoleName: " + e.Message );
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
 **name** | **string**| Name of the role. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oidc&quot;]
 **oidcRoleRequest** | [**OidcRoleRequest**](OidcRoleRequest.md)|  | [optional] 

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

<a name="updateradiusloginurlusername"></a>
# **UpdateRadiusLoginUrlusername**
> void UpdateRadiusLoginUrlusername (string urlusername, string mountPath = null, RadiusLoginRequest radiusLoginRequest = null)

Log in with a username and password.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateRadiusLoginUrlusernameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var urlusername = "urlusername_example";  // string | Username to be used for login. (URL parameter)
            var mountPath = "\"radius\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "radius")
            var radiusLoginRequest = new RadiusLoginRequest(); // RadiusLoginRequest |  (optional) 

            try
            {
                // Log in with a username and password.
                apiInstance.UpdateRadiusLoginUrlusername(urlusername, mountPath, radiusLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateRadiusLoginUrlusername: " + e.Message );
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
 **urlusername** | **string**| Username to be used for login. (URL parameter) | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;radius&quot;]
 **radiusLoginRequest** | [**RadiusLoginRequest**](RadiusLoginRequest.md)|  | [optional] 

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

<a name="updateradiususersname"></a>
# **UpdateRadiusUsersName**
> void UpdateRadiusUsersName (string name, string mountPath = null, RadiusUsersRequest radiusUsersRequest = null)

Manage users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateRadiusUsersNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | Name of the RADIUS user.
            var mountPath = "\"radius\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "radius")
            var radiusUsersRequest = new RadiusUsersRequest(); // RadiusUsersRequest |  (optional) 

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.UpdateRadiusUsersName(name, mountPath, radiusUsersRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateRadiusUsersName: " + e.Message );
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
 **name** | **string**| Name of the RADIUS user. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;radius&quot;]
 **radiusUsersRequest** | [**RadiusUsersRequest**](RadiusUsersRequest.md)|  | [optional] 

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

<a name="updatetokencreate"></a>
# **UpdateTokenCreate**
> void UpdateTokenCreate (string format = null, string mountPath = null, TokenCreateRequest tokenCreateRequest = null)

The token create path is used to create new tokens.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateTokenCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var format = "format_example";  // string | Return json formatted output (optional) 
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")
            var tokenCreateRequest = new TokenCreateRequest(); // TokenCreateRequest |  (optional) 

            try
            {
                // The token create path is used to create new tokens.
                apiInstance.UpdateTokenCreate(format, mountPath, tokenCreateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateTokenCreate: " + e.Message );
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
 **format** | **string**| Return json formatted output | [optional] 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]
 **tokenCreateRequest** | [**TokenCreateRequest**](TokenCreateRequest.md)|  | [optional] 

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

<a name="updatetokencreateorphan"></a>
# **UpdateTokenCreateOrphan**
> void UpdateTokenCreateOrphan (string format = null, string mountPath = null, TokenCreateOrphanRequest tokenCreateOrphanRequest = null)

The token create path is used to create new orphan tokens.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateTokenCreateOrphanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var format = "format_example";  // string | Return json formatted output (optional) 
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")
            var tokenCreateOrphanRequest = new TokenCreateOrphanRequest(); // TokenCreateOrphanRequest |  (optional) 

            try
            {
                // The token create path is used to create new orphan tokens.
                apiInstance.UpdateTokenCreateOrphan(format, mountPath, tokenCreateOrphanRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateTokenCreateOrphan: " + e.Message );
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
 **format** | **string**| Return json formatted output | [optional] 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]
 **tokenCreateOrphanRequest** | [**TokenCreateOrphanRequest**](TokenCreateOrphanRequest.md)|  | [optional] 

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

<a name="updatetokencreaterolename"></a>
# **UpdateTokenCreateRoleName**
> void UpdateTokenCreateRoleName (string roleName, string format = null, string mountPath = null, TokenCreateRequest tokenCreateRequest = null)

This token create path is used to create new tokens adhering to the given role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateTokenCreateRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role
            var format = "format_example";  // string | Return json formatted output (optional) 
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")
            var tokenCreateRequest = new TokenCreateRequest(); // TokenCreateRequest |  (optional) 

            try
            {
                // This token create path is used to create new tokens adhering to the given role.
                apiInstance.UpdateTokenCreateRoleName(roleName, format, mountPath, tokenCreateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateTokenCreateRoleName: " + e.Message );
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
 **roleName** | **string**| Name of the role | 
 **format** | **string**| Return json formatted output | [optional] 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]
 **tokenCreateRequest** | [**TokenCreateRequest**](TokenCreateRequest.md)|  | [optional] 

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

<a name="updatetokenlookup"></a>
# **UpdateTokenLookup**
> void UpdateTokenLookup (string mountPath = null, TokenLookupRequest tokenLookupRequest = null)

This endpoint will lookup a token and its properties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateTokenLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")
            var tokenLookupRequest = new TokenLookupRequest(); // TokenLookupRequest |  (optional) 

            try
            {
                // This endpoint will lookup a token and its properties.
                apiInstance.UpdateTokenLookup(mountPath, tokenLookupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateTokenLookup: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]
 **tokenLookupRequest** | [**TokenLookupRequest**](TokenLookupRequest.md)|  | [optional] 

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

<a name="updatetokenlookupaccessor"></a>
# **UpdateTokenLookupAccessor**
> void UpdateTokenLookupAccessor (string mountPath = null, TokenLookupAccessorRequest tokenLookupAccessorRequest = null)

This endpoint will lookup a token associated with the given accessor and its properties. Response will not contain the token ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateTokenLookupAccessorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")
            var tokenLookupAccessorRequest = new TokenLookupAccessorRequest(); // TokenLookupAccessorRequest |  (optional) 

            try
            {
                // This endpoint will lookup a token associated with the given accessor and its properties. Response will not contain the token ID.
                apiInstance.UpdateTokenLookupAccessor(mountPath, tokenLookupAccessorRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateTokenLookupAccessor: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]
 **tokenLookupAccessorRequest** | [**TokenLookupAccessorRequest**](TokenLookupAccessorRequest.md)|  | [optional] 

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

<a name="updatetokenlookupself"></a>
# **UpdateTokenLookupSelf**
> void UpdateTokenLookupSelf (string mountPath = null, TokenLookupSelfRequest tokenLookupSelfRequest = null)

This endpoint will lookup a token and its properties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateTokenLookupSelfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")
            var tokenLookupSelfRequest = new TokenLookupSelfRequest(); // TokenLookupSelfRequest |  (optional) 

            try
            {
                // This endpoint will lookup a token and its properties.
                apiInstance.UpdateTokenLookupSelf(mountPath, tokenLookupSelfRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateTokenLookupSelf: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]
 **tokenLookupSelfRequest** | [**TokenLookupSelfRequest**](TokenLookupSelfRequest.md)|  | [optional] 

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

<a name="updatetokenrenew"></a>
# **UpdateTokenRenew**
> void UpdateTokenRenew (string mountPath = null, TokenRenewRequest tokenRenewRequest = null)

This endpoint will renew the given token and prevent expiration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateTokenRenewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")
            var tokenRenewRequest = new TokenRenewRequest(); // TokenRenewRequest |  (optional) 

            try
            {
                // This endpoint will renew the given token and prevent expiration.
                apiInstance.UpdateTokenRenew(mountPath, tokenRenewRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateTokenRenew: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]
 **tokenRenewRequest** | [**TokenRenewRequest**](TokenRenewRequest.md)|  | [optional] 

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

<a name="updatetokenrenewaccessor"></a>
# **UpdateTokenRenewAccessor**
> void UpdateTokenRenewAccessor (string mountPath = null, TokenRenewAccessorRequest tokenRenewAccessorRequest = null)

This endpoint will renew a token associated with the given accessor and its properties. Response will not contain the token ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateTokenRenewAccessorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")
            var tokenRenewAccessorRequest = new TokenRenewAccessorRequest(); // TokenRenewAccessorRequest |  (optional) 

            try
            {
                // This endpoint will renew a token associated with the given accessor and its properties. Response will not contain the token ID.
                apiInstance.UpdateTokenRenewAccessor(mountPath, tokenRenewAccessorRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateTokenRenewAccessor: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]
 **tokenRenewAccessorRequest** | [**TokenRenewAccessorRequest**](TokenRenewAccessorRequest.md)|  | [optional] 

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

<a name="updatetokenrenewself"></a>
# **UpdateTokenRenewSelf**
> void UpdateTokenRenewSelf (string mountPath = null, TokenRenewSelfRequest tokenRenewSelfRequest = null)

This endpoint will renew the token used to call it and prevent expiration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateTokenRenewSelfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")
            var tokenRenewSelfRequest = new TokenRenewSelfRequest(); // TokenRenewSelfRequest |  (optional) 

            try
            {
                // This endpoint will renew the token used to call it and prevent expiration.
                apiInstance.UpdateTokenRenewSelf(mountPath, tokenRenewSelfRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateTokenRenewSelf: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]
 **tokenRenewSelfRequest** | [**TokenRenewSelfRequest**](TokenRenewSelfRequest.md)|  | [optional] 

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

<a name="updatetokenrevoke"></a>
# **UpdateTokenRevoke**
> void UpdateTokenRevoke (string mountPath = null, TokenRevokeRequest tokenRevokeRequest = null)

This endpoint will delete the given token and all of its child tokens.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateTokenRevokeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")
            var tokenRevokeRequest = new TokenRevokeRequest(); // TokenRevokeRequest |  (optional) 

            try
            {
                // This endpoint will delete the given token and all of its child tokens.
                apiInstance.UpdateTokenRevoke(mountPath, tokenRevokeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateTokenRevoke: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]
 **tokenRevokeRequest** | [**TokenRevokeRequest**](TokenRevokeRequest.md)|  | [optional] 

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

<a name="updatetokenrevokeaccessor"></a>
# **UpdateTokenRevokeAccessor**
> void UpdateTokenRevokeAccessor (string mountPath = null, TokenRevokeAccessorRequest tokenRevokeAccessorRequest = null)

This endpoint will delete the token associated with the accessor and all of its child tokens.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateTokenRevokeAccessorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")
            var tokenRevokeAccessorRequest = new TokenRevokeAccessorRequest(); // TokenRevokeAccessorRequest |  (optional) 

            try
            {
                // This endpoint will delete the token associated with the accessor and all of its child tokens.
                apiInstance.UpdateTokenRevokeAccessor(mountPath, tokenRevokeAccessorRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateTokenRevokeAccessor: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]
 **tokenRevokeAccessorRequest** | [**TokenRevokeAccessorRequest**](TokenRevokeAccessorRequest.md)|  | [optional] 

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

<a name="updatetokenrevokeorphan"></a>
# **UpdateTokenRevokeOrphan**
> void UpdateTokenRevokeOrphan (string mountPath = null, TokenRevokeOrphanRequest tokenRevokeOrphanRequest = null)

This endpoint will delete the token and orphan its child tokens.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateTokenRevokeOrphanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")
            var tokenRevokeOrphanRequest = new TokenRevokeOrphanRequest(); // TokenRevokeOrphanRequest |  (optional) 

            try
            {
                // This endpoint will delete the token and orphan its child tokens.
                apiInstance.UpdateTokenRevokeOrphan(mountPath, tokenRevokeOrphanRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateTokenRevokeOrphan: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]
 **tokenRevokeOrphanRequest** | [**TokenRevokeOrphanRequest**](TokenRevokeOrphanRequest.md)|  | [optional] 

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

<a name="updatetokenrevokeself"></a>
# **UpdateTokenRevokeSelf**
> void UpdateTokenRevokeSelf (string mountPath = null)

This endpoint will delete the token used to call it and all of its child tokens.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateTokenRevokeSelfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint will delete the token used to call it and all of its child tokens.
                apiInstance.UpdateTokenRevokeSelf(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateTokenRevokeSelf: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

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

<a name="updatetokenrolesrolename"></a>
# **UpdateTokenRolesRoleName**
> void UpdateTokenRolesRoleName (string roleName, string mountPath = null, TokenRolesRequest tokenRolesRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateTokenRolesRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var roleName = "roleName_example";  // string | Name of the role
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")
            var tokenRolesRequest = new TokenRolesRequest(); // TokenRolesRequest |  (optional) 

            try
            {
                apiInstance.UpdateTokenRolesRoleName(roleName, mountPath, tokenRolesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateTokenRolesRoleName: " + e.Message );
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
 **roleName** | **string**| Name of the role | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]
 **tokenRolesRequest** | [**TokenRolesRequest**](TokenRolesRequest.md)|  | [optional] 

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

<a name="updatetokentidy"></a>
# **UpdateTokenTidy**
> void UpdateTokenTidy (string mountPath = null)

This endpoint performs cleanup tasks that can be run if certain error conditions have occurred.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateTokenTidyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint performs cleanup tasks that can be run if certain error conditions have occurred.
                apiInstance.UpdateTokenTidy(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateTokenTidy: " + e.Message );
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

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

<a name="updateuserpassloginusername"></a>
# **UpdateUserpassLoginUsername**
> void UpdateUserpassLoginUsername (string username, string mountPath = null, UserpassLoginRequest userpassLoginRequest = null)

Log in with a username and password.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateUserpassLoginUsernameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var username = "username_example";  // string | Username of the user.
            var mountPath = "\"userpass\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "userpass")
            var userpassLoginRequest = new UserpassLoginRequest(); // UserpassLoginRequest |  (optional) 

            try
            {
                // Log in with a username and password.
                apiInstance.UpdateUserpassLoginUsername(username, mountPath, userpassLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateUserpassLoginUsername: " + e.Message );
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
 **username** | **string**| Username of the user. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;userpass&quot;]
 **userpassLoginRequest** | [**UserpassLoginRequest**](UserpassLoginRequest.md)|  | [optional] 

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

<a name="updateuserpassusersusername"></a>
# **UpdateUserpassUsersUsername**
> void UpdateUserpassUsersUsername (string username, string mountPath = null, UserpassUsersRequest userpassUsersRequest = null)

Manage users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateUserpassUsersUsernameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var username = "username_example";  // string | Username for this user.
            var mountPath = "\"userpass\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "userpass")
            var userpassUsersRequest = new UserpassUsersRequest(); // UserpassUsersRequest |  (optional) 

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.UpdateUserpassUsersUsername(username, mountPath, userpassUsersRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateUserpassUsersUsername: " + e.Message );
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
 **username** | **string**| Username for this user. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;userpass&quot;]
 **userpassUsersRequest** | [**UserpassUsersRequest**](UserpassUsersRequest.md)|  | [optional] 

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

<a name="updateuserpassusersusernamepassword"></a>
# **UpdateUserpassUsersUsernamePassword**
> void UpdateUserpassUsersUsernamePassword (string username, string mountPath = null, UserpassUsersPasswordRequest userpassUsersPasswordRequest = null)

Reset user's password.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateUserpassUsersUsernamePasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var username = "username_example";  // string | Username for this user.
            var mountPath = "\"userpass\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "userpass")
            var userpassUsersPasswordRequest = new UserpassUsersPasswordRequest(); // UserpassUsersPasswordRequest |  (optional) 

            try
            {
                // Reset user's password.
                apiInstance.UpdateUserpassUsersUsernamePassword(username, mountPath, userpassUsersPasswordRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateUserpassUsersUsernamePassword: " + e.Message );
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
 **username** | **string**| Username for this user. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;userpass&quot;]
 **userpassUsersPasswordRequest** | [**UserpassUsersPasswordRequest**](UserpassUsersPasswordRequest.md)|  | [optional] 

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

<a name="updateuserpassusersusernamepolicies"></a>
# **UpdateUserpassUsersUsernamePolicies**
> void UpdateUserpassUsersUsernamePolicies (string username, string mountPath = null, UserpassUsersPoliciesRequest userpassUsersPoliciesRequest = null)

Update the policies associated with the username.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateUserpassUsersUsernamePoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var username = "username_example";  // string | Username for this user.
            var mountPath = "\"userpass\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "userpass")
            var userpassUsersPoliciesRequest = new UserpassUsersPoliciesRequest(); // UserpassUsersPoliciesRequest |  (optional) 

            try
            {
                // Update the policies associated with the username.
                apiInstance.UpdateUserpassUsersUsernamePolicies(username, mountPath, userpassUsersPoliciesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateUserpassUsersUsernamePolicies: " + e.Message );
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
 **username** | **string**| Username for this user. | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;userpass&quot;]
 **userpassUsersPoliciesRequest** | [**UserpassUsersPoliciesRequest**](UserpassUsersPoliciesRequest.md)|  | [optional] 

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

