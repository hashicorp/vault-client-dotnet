# Vault.Api.Auth

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthUpdateAwsConfigRotateRoot**](Auth.md#authupdateawsconfigrotateroot) | **POST** /auth/{mount_path}/config/rotate-root | 
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
[**DeleteKubernetesRoleName**](Auth.md#deletekubernetesrolename) | **DELETE** /auth/{mount_path}/role/{name} | Register an role with the backend.
[**DeleteOktaUsersName**](Auth.md#deleteoktausersname) | **DELETE** /auth/{mount_path}/users/{name} | Manage additional groups for users allowed to authenticate.
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
[**ListKubernetesRole**](Auth.md#listkubernetesrole) | **GET** /auth/{mount_path}/role | Lists all the roles registered with the backend.
[**ListOktaUsers**](Auth.md#listoktausers) | **GET** /auth/{mount_path}/users | Manage additional groups for users allowed to authenticate.
[**ListTokenAccessors**](Auth.md#listtokenaccessors) | **GET** /auth/{mount_path}/accessors/ | List token accessors, which can then be be used to iterate and discover their properties or revoke them. Because this can be used to cause a denial of service, this endpoint requires &#39;sudo&#39; capability in addition to &#39;list&#39;.
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
[**ReadKubernetesConfig**](Auth.md#readkubernetesconfig) | **GET** /auth/{mount_path}/config | Configures the JWT Public Key and Kubernetes API information.
[**ReadKubernetesRoleName**](Auth.md#readkubernetesrolename) | **GET** /auth/{mount_path}/role/{name} | Register an role with the backend.
[**ReadOidcOidcCallback**](Auth.md#readoidcoidccallback) | **GET** /auth/{mount_path}/oidc/callback | Callback endpoint to complete an OIDC login.
[**ReadOktaUsersName**](Auth.md#readoktausersname) | **GET** /auth/{mount_path}/users/{name} | Manage additional groups for users allowed to authenticate.
[**ReadOktaVerifyNonce**](Auth.md#readoktaverifynonce) | **GET** /auth/{mount_path}/verify/{nonce} | 
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
[**UpdateKubernetesConfig**](Auth.md#updatekubernetesconfig) | **POST** /auth/{mount_path}/config | Configures the JWT Public Key and Kubernetes API information.
[**UpdateKubernetesLogin**](Auth.md#updatekuberneteslogin) | **POST** /auth/{mount_path}/login | Authenticates Kubernetes service accounts with Vault.
[**UpdateKubernetesRoleName**](Auth.md#updatekubernetesrolename) | **POST** /auth/{mount_path}/role/{name} | Register an role with the backend.
[**UpdateOciLoginRole**](Auth.md#updateociloginrole) | **POST** /auth/{mount_path}/login/{role} | Authenticates to Vault using OCI credentials
[**UpdateOidcOidcAuthUrl**](Auth.md#updateoidcoidcauthurl) | **POST** /auth/{mount_path}/oidc/auth_url | Request an authorization URL to start an OIDC login flow.
[**UpdateOidcOidcCallback**](Auth.md#updateoidcoidccallback) | **POST** /auth/{mount_path}/oidc/callback | Callback endpoint to handle form_posts.
[**UpdateOktaLoginUsername**](Auth.md#updateoktaloginusername) | **POST** /auth/{mount_path}/login/{username} | Log in with a username and password.
[**UpdateOktaUsersName**](Auth.md#updateoktausersname) | **POST** /auth/{mount_path}/users/{name} | Manage additional groups for users allowed to authenticate.
[**UpdateRadiusLoginUrlusername**](Auth.md#updateradiusloginurlusername) | **POST** /auth/{mount_path}/login/{urlusername} | Log in with a username and password.
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
[**UpdateUserpassUsersUsername**](Auth.md#updateuserpassusersusername) | **POST** /auth/{mount_path}/users/{username} | Manage users allowed to authenticate.
[**UpdateUserpassUsersUsernamePassword**](Auth.md#updateuserpassusersusernamepassword) | **POST** /auth/{mount_path}/users/{username}/password | Reset user&#39;s password.
[**UpdateUserpassUsersUsernamePolicies**](Auth.md#updateuserpassusersusernamepolicies) | **POST** /auth/{mount_path}/users/{username}/policies | Update the policies associated with the username.


<a name="authupdateawsconfigrotateroot"></a>
# **AuthUpdateAwsConfigRotateRoot**
> void AuthUpdateAwsConfigRotateRoot (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AuthUpdateAwsConfigRotateRootExample
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
                apiInstance.AuthUpdateAwsConfigRotateRoot(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AuthUpdateAwsConfigRotateRoot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="deletekubernetesrolename"></a>
# **DeleteKubernetesRoleName**
> void DeleteKubernetesRoleName (string name, string mountPath = null)

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
    public class DeleteKubernetesRoleNameExample
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
            var mountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                // Register an role with the backend.
                apiInstance.DeleteKubernetesRoleName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteKubernetesRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kubernetes&quot;]

### Return type

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

<a name="deleteoktausersname"></a>
# **DeleteOktaUsersName**
> void DeleteOktaUsersName (string name, string mountPath = null)

Manage additional groups for users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteOktaUsersNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | Name of the user.
            var mountPath = "\"okta\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "okta")

            try
            {
                // Manage additional groups for users allowed to authenticate.
                apiInstance.DeleteOktaUsersName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteOktaUsersName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the user. | 
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

<a name="listkubernetesrole"></a>
# **ListKubernetesRole**
> void ListKubernetesRole (string list, string mountPath = null)

Lists all the roles registered with the backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListKubernetesRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true` (default to false)
            var mountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                // Lists all the roles registered with the backend.
                apiInstance.ListKubernetesRole(list, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ListKubernetesRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | [default to false]
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kubernetes&quot;]

### Return type

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

<a name="listoktausers"></a>
# **ListOktaUsers**
> void ListOktaUsers (string list, string mountPath = null)

Manage additional groups for users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListOktaUsersExample
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
            var mountPath = "\"okta\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "okta")

            try
            {
                // Manage additional groups for users allowed to authenticate.
                apiInstance.ListOktaUsers(list, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ListOktaUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
            var list = "\"false\"";  // string | Return a list if `true` (optional)  (default to "false")

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
 **list** | **string**| Return a list if &#x60;true&#x60; | [optional] [default to &quot;false&quot;]

### Return type

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
            var list = "\"false\"";  // string | Return a list if `true` (optional)  (default to "false")

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
 **list** | **string**| Return a list if &#x60;true&#x60; | [optional] [default to &quot;false&quot;]

### Return type

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

<a name="readkubernetesconfig"></a>
# **ReadKubernetesConfig**
> void ReadKubernetesConfig (string mountPath = null)

Configures the JWT Public Key and Kubernetes API information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadKubernetesConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var mountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                // Configures the JWT Public Key and Kubernetes API information.
                apiInstance.ReadKubernetesConfig(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadKubernetesConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kubernetes&quot;]

### Return type

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

<a name="readkubernetesrolename"></a>
# **ReadKubernetesRoleName**
> void ReadKubernetesRoleName (string name, string mountPath = null)

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
    public class ReadKubernetesRoleNameExample
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
            var mountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                // Register an role with the backend.
                apiInstance.ReadKubernetesRoleName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadKubernetesRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kubernetes&quot;]

### Return type

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

<a name="readoktausersname"></a>
# **ReadOktaUsersName**
> void ReadOktaUsersName (string name, string mountPath = null)

Manage additional groups for users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadOktaUsersNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | Name of the user.
            var mountPath = "\"okta\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "okta")

            try
            {
                // Manage additional groups for users allowed to authenticate.
                apiInstance.ReadOktaUsersName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.ReadOktaUsersName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the user. | 
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
> void UpdateApproleRoleRoleName (string roleName, ApproleRoleRequest approleRoleRequest, string mountPath = null)

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
            var approleRoleRequest = new ApproleRoleRequest(); // ApproleRoleRequest | 
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Register an role with the backend.
                apiInstance.UpdateApproleRoleRoleName(roleName, approleRoleRequest, mountPath);
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
 **approleRoleRequest** | [**ApproleRoleRequest**](ApproleRoleRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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
> void UpdateApproleRoleRoleNameBindSecretId (string roleName, ApproleRoleBindSecretIdRequest approleRoleBindSecretIdRequest, string mountPath = null)

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
            var approleRoleBindSecretIdRequest = new ApproleRoleBindSecretIdRequest(); // ApproleRoleBindSecretIdRequest | 
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Impose secret_id to be presented during login using this role.
                apiInstance.UpdateApproleRoleRoleNameBindSecretId(roleName, approleRoleBindSecretIdRequest, mountPath);
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
 **approleRoleBindSecretIdRequest** | [**ApproleRoleBindSecretIdRequest**](ApproleRoleBindSecretIdRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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
> void UpdateApproleRoleRoleNameBoundCidrList (string roleName, ApproleRoleBoundCidrListRequest approleRoleBoundCidrListRequest, string mountPath = null)

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
            var approleRoleBoundCidrListRequest = new ApproleRoleBoundCidrListRequest(); // ApproleRoleBoundCidrListRequest | 
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Deprecated: Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
                apiInstance.UpdateApproleRoleRoleNameBoundCidrList(roleName, approleRoleBoundCidrListRequest, mountPath);
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
 **approleRoleBoundCidrListRequest** | [**ApproleRoleBoundCidrListRequest**](ApproleRoleBoundCidrListRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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
> void UpdateApproleRoleRoleNameCustomSecretId (string roleName, ApproleRoleCustomSecretIdRequest approleRoleCustomSecretIdRequest, string mountPath = null)

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
            var approleRoleCustomSecretIdRequest = new ApproleRoleCustomSecretIdRequest(); // ApproleRoleCustomSecretIdRequest | 
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Assign a SecretID of choice against the role.
                apiInstance.UpdateApproleRoleRoleNameCustomSecretId(roleName, approleRoleCustomSecretIdRequest, mountPath);
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
 **approleRoleCustomSecretIdRequest** | [**ApproleRoleCustomSecretIdRequest**](ApproleRoleCustomSecretIdRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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
> void UpdateApproleRoleRoleNamePeriod (string roleName, ApproleRolePeriodRequest approleRolePeriodRequest, string mountPath = null)

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
            var approleRolePeriodRequest = new ApproleRolePeriodRequest(); // ApproleRolePeriodRequest | 
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Updates the value of 'period' on the role
                apiInstance.UpdateApproleRoleRoleNamePeriod(roleName, approleRolePeriodRequest, mountPath);
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
 **approleRolePeriodRequest** | [**ApproleRolePeriodRequest**](ApproleRolePeriodRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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
> void UpdateApproleRoleRoleNamePolicies (string roleName, ApproleRolePoliciesRequest approleRolePoliciesRequest, string mountPath = null)

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
            var approleRolePoliciesRequest = new ApproleRolePoliciesRequest(); // ApproleRolePoliciesRequest | 
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Policies of the role.
                apiInstance.UpdateApproleRoleRoleNamePolicies(roleName, approleRolePoliciesRequest, mountPath);
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
 **approleRolePoliciesRequest** | [**ApproleRolePoliciesRequest**](ApproleRolePoliciesRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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
> void UpdateApproleRoleRoleNameRoleId (string roleName, ApproleRoleRoleIdRequest approleRoleRoleIdRequest, string mountPath = null)

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
            var approleRoleRoleIdRequest = new ApproleRoleRoleIdRequest(); // ApproleRoleRoleIdRequest | 
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Returns the 'role_id' of the role.
                apiInstance.UpdateApproleRoleRoleNameRoleId(roleName, approleRoleRoleIdRequest, mountPath);
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
 **approleRoleRoleIdRequest** | [**ApproleRoleRoleIdRequest**](ApproleRoleRoleIdRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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
> void UpdateApproleRoleRoleNameSecretId (string roleName, ApproleRoleSecretIdRequest approleRoleSecretIdRequest, string mountPath = null)

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
            var approleRoleSecretIdRequest = new ApproleRoleSecretIdRequest(); // ApproleRoleSecretIdRequest | 
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Generate a SecretID against this role.
                apiInstance.UpdateApproleRoleRoleNameSecretId(roleName, approleRoleSecretIdRequest, mountPath);
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
 **approleRoleSecretIdRequest** | [**ApproleRoleSecretIdRequest**](ApproleRoleSecretIdRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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
> void UpdateApproleRoleRoleNameSecretIdAccessorDestroy (string roleName, ApproleRoleSecretIdAccessorDestroyRequest approleRoleSecretIdAccessorDestroyRequest, string mountPath = null)



### Example
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
            var approleRoleSecretIdAccessorDestroyRequest = new ApproleRoleSecretIdAccessorDestroyRequest(); // ApproleRoleSecretIdAccessorDestroyRequest | 
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.UpdateApproleRoleRoleNameSecretIdAccessorDestroy(roleName, approleRoleSecretIdAccessorDestroyRequest, mountPath);
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
 **approleRoleSecretIdAccessorDestroyRequest** | [**ApproleRoleSecretIdAccessorDestroyRequest**](ApproleRoleSecretIdAccessorDestroyRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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
> void UpdateApproleRoleRoleNameSecretIdAccessorLookup (string roleName, ApproleRoleSecretIdAccessorLookupRequest approleRoleSecretIdAccessorLookupRequest, string mountPath = null)



### Example
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
            var approleRoleSecretIdAccessorLookupRequest = new ApproleRoleSecretIdAccessorLookupRequest(); // ApproleRoleSecretIdAccessorLookupRequest | 
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.UpdateApproleRoleRoleNameSecretIdAccessorLookup(roleName, approleRoleSecretIdAccessorLookupRequest, mountPath);
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
 **approleRoleSecretIdAccessorLookupRequest** | [**ApproleRoleSecretIdAccessorLookupRequest**](ApproleRoleSecretIdAccessorLookupRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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
> void UpdateApproleRoleRoleNameSecretIdBoundCidrs (string roleName, ApproleRoleSecretIdBoundCidrsRequest approleRoleSecretIdBoundCidrsRequest, string mountPath = null)

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
            var approleRoleSecretIdBoundCidrsRequest = new ApproleRoleSecretIdBoundCidrsRequest(); // ApproleRoleSecretIdBoundCidrsRequest | 
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
                apiInstance.UpdateApproleRoleRoleNameSecretIdBoundCidrs(roleName, approleRoleSecretIdBoundCidrsRequest, mountPath);
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
 **approleRoleSecretIdBoundCidrsRequest** | [**ApproleRoleSecretIdBoundCidrsRequest**](ApproleRoleSecretIdBoundCidrsRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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
> void UpdateApproleRoleRoleNameSecretIdDestroy (string roleName, ApproleRoleSecretIdDestroyRequest approleRoleSecretIdDestroyRequest, string mountPath = null)

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
            var approleRoleSecretIdDestroyRequest = new ApproleRoleSecretIdDestroyRequest(); // ApproleRoleSecretIdDestroyRequest | 
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Invalidate an issued secret_id
                apiInstance.UpdateApproleRoleRoleNameSecretIdDestroy(roleName, approleRoleSecretIdDestroyRequest, mountPath);
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
 **approleRoleSecretIdDestroyRequest** | [**ApproleRoleSecretIdDestroyRequest**](ApproleRoleSecretIdDestroyRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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
> void UpdateApproleRoleRoleNameSecretIdLookup (string roleName, ApproleRoleSecretIdLookupRequest approleRoleSecretIdLookupRequest, string mountPath = null)

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
            var approleRoleSecretIdLookupRequest = new ApproleRoleSecretIdLookupRequest(); // ApproleRoleSecretIdLookupRequest | 
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Read the properties of an issued secret_id
                apiInstance.UpdateApproleRoleRoleNameSecretIdLookup(roleName, approleRoleSecretIdLookupRequest, mountPath);
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
 **approleRoleSecretIdLookupRequest** | [**ApproleRoleSecretIdLookupRequest**](ApproleRoleSecretIdLookupRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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
> void UpdateApproleRoleRoleNameSecretIdNumUses (string roleName, ApproleRoleSecretIdNumUsesRequest approleRoleSecretIdNumUsesRequest, string mountPath = null)

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
            var approleRoleSecretIdNumUsesRequest = new ApproleRoleSecretIdNumUsesRequest(); // ApproleRoleSecretIdNumUsesRequest | 
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Use limit of the SecretID generated against the role.
                apiInstance.UpdateApproleRoleRoleNameSecretIdNumUses(roleName, approleRoleSecretIdNumUsesRequest, mountPath);
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
 **approleRoleSecretIdNumUsesRequest** | [**ApproleRoleSecretIdNumUsesRequest**](ApproleRoleSecretIdNumUsesRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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
> void UpdateApproleRoleRoleNameSecretIdTtl (string roleName, ApproleRoleSecretIdTtlRequest approleRoleSecretIdTtlRequest, string mountPath = null)

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
            var approleRoleSecretIdTtlRequest = new ApproleRoleSecretIdTtlRequest(); // ApproleRoleSecretIdTtlRequest | 
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Duration in seconds of the SecretID generated against the role.
                apiInstance.UpdateApproleRoleRoleNameSecretIdTtl(roleName, approleRoleSecretIdTtlRequest, mountPath);
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
 **approleRoleSecretIdTtlRequest** | [**ApproleRoleSecretIdTtlRequest**](ApproleRoleSecretIdTtlRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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
> void UpdateApproleRoleRoleNameTokenBoundCidrs (string roleName, ApproleRoleTokenBoundCidrsRequest approleRoleTokenBoundCidrsRequest, string mountPath = null)

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
            var approleRoleTokenBoundCidrsRequest = new ApproleRoleTokenBoundCidrsRequest(); // ApproleRoleTokenBoundCidrsRequest | 
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token.
                apiInstance.UpdateApproleRoleRoleNameTokenBoundCidrs(roleName, approleRoleTokenBoundCidrsRequest, mountPath);
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
 **approleRoleTokenBoundCidrsRequest** | [**ApproleRoleTokenBoundCidrsRequest**](ApproleRoleTokenBoundCidrsRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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
> void UpdateApproleRoleRoleNameTokenMaxTtl (string roleName, ApproleRoleTokenMaxTtlRequest approleRoleTokenMaxTtlRequest, string mountPath = null)

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
            var approleRoleTokenMaxTtlRequest = new ApproleRoleTokenMaxTtlRequest(); // ApproleRoleTokenMaxTtlRequest | 
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Duration in seconds, the maximum lifetime of the tokens issued by using the SecretIDs that were generated against this role, after which the tokens are not allowed to be renewed.
                apiInstance.UpdateApproleRoleRoleNameTokenMaxTtl(roleName, approleRoleTokenMaxTtlRequest, mountPath);
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
 **approleRoleTokenMaxTtlRequest** | [**ApproleRoleTokenMaxTtlRequest**](ApproleRoleTokenMaxTtlRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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
> void UpdateApproleRoleRoleNameTokenNumUses (string roleName, ApproleRoleTokenNumUsesRequest approleRoleTokenNumUsesRequest, string mountPath = null)

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
            var approleRoleTokenNumUsesRequest = new ApproleRoleTokenNumUsesRequest(); // ApproleRoleTokenNumUsesRequest | 
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Number of times issued tokens can be used
                apiInstance.UpdateApproleRoleRoleNameTokenNumUses(roleName, approleRoleTokenNumUsesRequest, mountPath);
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
 **approleRoleTokenNumUsesRequest** | [**ApproleRoleTokenNumUsesRequest**](ApproleRoleTokenNumUsesRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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
> void UpdateApproleRoleRoleNameTokenTtl (string roleName, ApproleRoleTokenTtlRequest approleRoleTokenTtlRequest, string mountPath = null)

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
            var approleRoleTokenTtlRequest = new ApproleRoleTokenTtlRequest(); // ApproleRoleTokenTtlRequest | 
            var mountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Duration in seconds, the lifetime of the token issued by using the SecretID that is generated against this role, before which the token needs to be renewed.
                apiInstance.UpdateApproleRoleRoleNameTokenTtl(roleName, approleRoleTokenTtlRequest, mountPath);
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
 **approleRoleTokenTtlRequest** | [**ApproleRoleTokenTtlRequest**](ApproleRoleTokenTtlRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

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
> void UpdateAwsConfigCertificateCertName (string certName, AwsConfigCertificateRequest awsConfigCertificateRequest, string mountPath = null)



### Example
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
            var awsConfigCertificateRequest = new AwsConfigCertificateRequest(); // AwsConfigCertificateRequest | 
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.UpdateAwsConfigCertificateCertName(certName, awsConfigCertificateRequest, mountPath);
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
 **awsConfigCertificateRequest** | [**AwsConfigCertificateRequest**](AwsConfigCertificateRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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
> void UpdateAwsConfigClient (AwsConfigClientRequest awsConfigClientRequest, string mountPath = null)



### Example
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
            var awsConfigClientRequest = new AwsConfigClientRequest(); // AwsConfigClientRequest | 
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.UpdateAwsConfigClient(awsConfigClientRequest, mountPath);
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
 **awsConfigClientRequest** | [**AwsConfigClientRequest**](AwsConfigClientRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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
> void UpdateAwsConfigIdentity (AwsConfigIdentityRequest awsConfigIdentityRequest, string mountPath = null)



### Example
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
            var awsConfigIdentityRequest = new AwsConfigIdentityRequest(); // AwsConfigIdentityRequest | 
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.UpdateAwsConfigIdentity(awsConfigIdentityRequest, mountPath);
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
 **awsConfigIdentityRequest** | [**AwsConfigIdentityRequest**](AwsConfigIdentityRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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

<a name="updateawsconfigstsaccountid"></a>
# **UpdateAwsConfigStsAccountId**
> void UpdateAwsConfigStsAccountId (string accountId, AwsConfigStsRequest awsConfigStsRequest, string mountPath = null)



### Example
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
            var awsConfigStsRequest = new AwsConfigStsRequest(); // AwsConfigStsRequest | 
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.UpdateAwsConfigStsAccountId(accountId, awsConfigStsRequest, mountPath);
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
 **awsConfigStsRequest** | [**AwsConfigStsRequest**](AwsConfigStsRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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
> void UpdateAwsConfigTidyIdentityAccesslist (AwsConfigTidyIdentityAccesslistRequest awsConfigTidyIdentityAccesslistRequest, string mountPath = null)



### Example
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
            var awsConfigTidyIdentityAccesslistRequest = new AwsConfigTidyIdentityAccesslistRequest(); // AwsConfigTidyIdentityAccesslistRequest | 
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.UpdateAwsConfigTidyIdentityAccesslist(awsConfigTidyIdentityAccesslistRequest, mountPath);
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
 **awsConfigTidyIdentityAccesslistRequest** | [**AwsConfigTidyIdentityAccesslistRequest**](AwsConfigTidyIdentityAccesslistRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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
> void UpdateAwsConfigTidyIdentityWhitelist (AwsConfigTidyIdentityWhitelistRequest awsConfigTidyIdentityWhitelistRequest, string mountPath = null)



### Example
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
            var awsConfigTidyIdentityWhitelistRequest = new AwsConfigTidyIdentityWhitelistRequest(); // AwsConfigTidyIdentityWhitelistRequest | 
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.UpdateAwsConfigTidyIdentityWhitelist(awsConfigTidyIdentityWhitelistRequest, mountPath);
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
 **awsConfigTidyIdentityWhitelistRequest** | [**AwsConfigTidyIdentityWhitelistRequest**](AwsConfigTidyIdentityWhitelistRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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
> void UpdateAwsConfigTidyRoletagBlacklist (AwsConfigTidyRoletagBlacklistRequest awsConfigTidyRoletagBlacklistRequest, string mountPath = null)



### Example
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
            var awsConfigTidyRoletagBlacklistRequest = new AwsConfigTidyRoletagBlacklistRequest(); // AwsConfigTidyRoletagBlacklistRequest | 
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.UpdateAwsConfigTidyRoletagBlacklist(awsConfigTidyRoletagBlacklistRequest, mountPath);
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
 **awsConfigTidyRoletagBlacklistRequest** | [**AwsConfigTidyRoletagBlacklistRequest**](AwsConfigTidyRoletagBlacklistRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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
> void UpdateAwsConfigTidyRoletagDenylist (AwsConfigTidyRoletagDenylistRequest awsConfigTidyRoletagDenylistRequest, string mountPath = null)



### Example
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
            var awsConfigTidyRoletagDenylistRequest = new AwsConfigTidyRoletagDenylistRequest(); // AwsConfigTidyRoletagDenylistRequest | 
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.UpdateAwsConfigTidyRoletagDenylist(awsConfigTidyRoletagDenylistRequest, mountPath);
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
 **awsConfigTidyRoletagDenylistRequest** | [**AwsConfigTidyRoletagDenylistRequest**](AwsConfigTidyRoletagDenylistRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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
> void UpdateAwsRoleRole (string role, AwsRoleRequest awsRoleRequest, string mountPath = null)



### Example
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
            var awsRoleRequest = new AwsRoleRequest(); // AwsRoleRequest | 
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.UpdateAwsRoleRole(role, awsRoleRequest, mountPath);
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
 **awsRoleRequest** | [**AwsRoleRequest**](AwsRoleRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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
> void UpdateAwsRoleRoleTag (string role, AwsRoleTagRequest awsRoleTagRequest, string mountPath = null)



### Example
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
            var awsRoleTagRequest = new AwsRoleTagRequest(); // AwsRoleTagRequest | 
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.UpdateAwsRoleRoleTag(role, awsRoleTagRequest, mountPath);
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
 **awsRoleTagRequest** | [**AwsRoleTagRequest**](AwsRoleTagRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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
> void UpdateAwsTidyIdentityAccesslist (AwsTidyIdentityAccesslistRequest awsTidyIdentityAccesslistRequest, string mountPath = null)



### Example
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
            var awsTidyIdentityAccesslistRequest = new AwsTidyIdentityAccesslistRequest(); // AwsTidyIdentityAccesslistRequest | 
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.UpdateAwsTidyIdentityAccesslist(awsTidyIdentityAccesslistRequest, mountPath);
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
 **awsTidyIdentityAccesslistRequest** | [**AwsTidyIdentityAccesslistRequest**](AwsTidyIdentityAccesslistRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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
> void UpdateAwsTidyIdentityWhitelist (AwsTidyIdentityWhitelistRequest awsTidyIdentityWhitelistRequest, string mountPath = null)



### Example
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
            var awsTidyIdentityWhitelistRequest = new AwsTidyIdentityWhitelistRequest(); // AwsTidyIdentityWhitelistRequest | 
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.UpdateAwsTidyIdentityWhitelist(awsTidyIdentityWhitelistRequest, mountPath);
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
 **awsTidyIdentityWhitelistRequest** | [**AwsTidyIdentityWhitelistRequest**](AwsTidyIdentityWhitelistRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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
> void UpdateAwsTidyRoletagBlacklist (AwsTidyRoletagBlacklistRequest awsTidyRoletagBlacklistRequest, string mountPath = null)



### Example
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
            var awsTidyRoletagBlacklistRequest = new AwsTidyRoletagBlacklistRequest(); // AwsTidyRoletagBlacklistRequest | 
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.UpdateAwsTidyRoletagBlacklist(awsTidyRoletagBlacklistRequest, mountPath);
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
 **awsTidyRoletagBlacklistRequest** | [**AwsTidyRoletagBlacklistRequest**](AwsTidyRoletagBlacklistRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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
> void UpdateAwsTidyRoletagDenylist (AwsTidyRoletagDenylistRequest awsTidyRoletagDenylistRequest, string mountPath = null)



### Example
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
            var awsTidyRoletagDenylistRequest = new AwsTidyRoletagDenylistRequest(); // AwsTidyRoletagDenylistRequest | 
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.UpdateAwsTidyRoletagDenylist(awsTidyRoletagDenylistRequest, mountPath);
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
 **awsTidyRoletagDenylistRequest** | [**AwsTidyRoletagDenylistRequest**](AwsTidyRoletagDenylistRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

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
> void UpdateCertCertsName (string name, CertCertsRequest certCertsRequest, string mountPath = null)

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
            var certCertsRequest = new CertCertsRequest(); // CertCertsRequest | 
            var mountPath = "\"cert\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cert")

            try
            {
                // Manage trusted certificates used for authentication.
                apiInstance.UpdateCertCertsName(name, certCertsRequest, mountPath);
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
 **certCertsRequest** | [**CertCertsRequest**](CertCertsRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cert&quot;]

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
> void UpdateCertCrlsName (string name, CertCrlsRequest certCrlsRequest, string mountPath = null)

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
            var certCrlsRequest = new CertCrlsRequest(); // CertCrlsRequest | 
            var mountPath = "\"cert\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cert")

            try
            {
                // Manage Certificate Revocation Lists checked during authentication.
                apiInstance.UpdateCertCrlsName(name, certCrlsRequest, mountPath);
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
 **certCrlsRequest** | [**CertCrlsRequest**](CertCrlsRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cert&quot;]

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
> void UpdateCfRolesRole (string role, CfRolesRequest cfRolesRequest, string mountPath = null)



### Example
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
            var cfRolesRequest = new CfRolesRequest(); // CfRolesRequest | 
            var mountPath = "\"cf\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cf")

            try
            {
                apiInstance.UpdateCfRolesRole(role, cfRolesRequest, mountPath);
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
 **cfRolesRequest** | [**CfRolesRequest**](CfRolesRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cf&quot;]

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
> void UpdateGcpRoleNameLabels (string name, GcpRoleLabelsRequest gcpRoleLabelsRequest, string mountPath = null)

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
            var gcpRoleLabelsRequest = new GcpRoleLabelsRequest(); // GcpRoleLabelsRequest | 
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                // Add or remove labels for an existing 'gce' role
                apiInstance.UpdateGcpRoleNameLabels(name, gcpRoleLabelsRequest, mountPath);
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
 **gcpRoleLabelsRequest** | [**GcpRoleLabelsRequest**](GcpRoleLabelsRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcp&quot;]

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
> void UpdateGcpRoleNameServiceAccounts (string name, GcpRoleServiceAccountsRequest gcpRoleServiceAccountsRequest, string mountPath = null)

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
            var gcpRoleServiceAccountsRequest = new GcpRoleServiceAccountsRequest(); // GcpRoleServiceAccountsRequest | 
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                // Add or remove service accounts for an existing `iam` role
                apiInstance.UpdateGcpRoleNameServiceAccounts(name, gcpRoleServiceAccountsRequest, mountPath);
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
 **gcpRoleServiceAccountsRequest** | [**GcpRoleServiceAccountsRequest**](GcpRoleServiceAccountsRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcp&quot;]

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
> void UpdateGithubMapTeamsKey (string key, GithubMapTeamsRequest githubMapTeamsRequest, string mountPath = null)

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
            var githubMapTeamsRequest = new GithubMapTeamsRequest(); // GithubMapTeamsRequest | 
            var mountPath = "\"github\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "github")

            try
            {
                // Read/write/delete a single teams mapping
                apiInstance.UpdateGithubMapTeamsKey(key, githubMapTeamsRequest, mountPath);
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
 **githubMapTeamsRequest** | [**GithubMapTeamsRequest**](GithubMapTeamsRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;github&quot;]

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
> void UpdateGithubMapUsersKey (string key, GithubMapUsersRequest githubMapUsersRequest, string mountPath = null)

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
            var githubMapUsersRequest = new GithubMapUsersRequest(); // GithubMapUsersRequest | 
            var mountPath = "\"github\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "github")

            try
            {
                // Read/write/delete a single users mapping
                apiInstance.UpdateGithubMapUsersKey(key, githubMapUsersRequest, mountPath);
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
 **githubMapUsersRequest** | [**GithubMapUsersRequest**](GithubMapUsersRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;github&quot;]

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
> void UpdateKerberosConfigLdap (KerberosConfigLdapRequest kerberosConfigLdapRequest, string mountPath = null)



### Example
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
            var kerberosConfigLdapRequest = new KerberosConfigLdapRequest(); // KerberosConfigLdapRequest | 
            var mountPath = "\"kerberos\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kerberos")

            try
            {
                apiInstance.UpdateKerberosConfigLdap(kerberosConfigLdapRequest, mountPath);
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
 **kerberosConfigLdapRequest** | [**KerberosConfigLdapRequest**](KerberosConfigLdapRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kerberos&quot;]

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
> void UpdateKerberosGroupsName (string name, KerberosGroupsRequest kerberosGroupsRequest, string mountPath = null)



### Example
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
            var kerberosGroupsRequest = new KerberosGroupsRequest(); // KerberosGroupsRequest | 
            var mountPath = "\"kerberos\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kerberos")

            try
            {
                apiInstance.UpdateKerberosGroupsName(name, kerberosGroupsRequest, mountPath);
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
 **kerberosGroupsRequest** | [**KerberosGroupsRequest**](KerberosGroupsRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kerberos&quot;]

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

<a name="updatekubernetesconfig"></a>
# **UpdateKubernetesConfig**
> void UpdateKubernetesConfig (KubernetesConfigRequest kubernetesConfigRequest, string mountPath = null)

Configures the JWT Public Key and Kubernetes API information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateKubernetesConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var kubernetesConfigRequest = new KubernetesConfigRequest(); // KubernetesConfigRequest | 
            var mountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                // Configures the JWT Public Key and Kubernetes API information.
                apiInstance.UpdateKubernetesConfig(kubernetesConfigRequest, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateKubernetesConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kubernetesConfigRequest** | [**KubernetesConfigRequest**](KubernetesConfigRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kubernetes&quot;]

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

<a name="updatekuberneteslogin"></a>
# **UpdateKubernetesLogin**
> void UpdateKubernetesLogin (KubernetesLoginRequest kubernetesLoginRequest, string mountPath = null)

Authenticates Kubernetes service accounts with Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateKubernetesLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var kubernetesLoginRequest = new KubernetesLoginRequest(); // KubernetesLoginRequest | 
            var mountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                // Authenticates Kubernetes service accounts with Vault.
                apiInstance.UpdateKubernetesLogin(kubernetesLoginRequest, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateKubernetesLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kubernetesLoginRequest** | [**KubernetesLoginRequest**](KubernetesLoginRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kubernetes&quot;]

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

<a name="updatekubernetesrolename"></a>
# **UpdateKubernetesRoleName**
> void UpdateKubernetesRoleName (string name, KubernetesRoleRequest kubernetesRoleRequest, string mountPath = null)

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
    public class UpdateKubernetesRoleNameExample
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
            var kubernetesRoleRequest = new KubernetesRoleRequest(); // KubernetesRoleRequest | 
            var mountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                // Register an role with the backend.
                apiInstance.UpdateKubernetesRoleName(name, kubernetesRoleRequest, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateKubernetesRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **kubernetesRoleRequest** | [**KubernetesRoleRequest**](KubernetesRoleRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kubernetes&quot;]

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
> void UpdateOciLoginRole (string role, OciLoginRequest ociLoginRequest, string mountPath = null)

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
            var ociLoginRequest = new OciLoginRequest(); // OciLoginRequest | 
            var mountPath = "\"oci\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oci")

            try
            {
                // Authenticates to Vault using OCI credentials
                apiInstance.UpdateOciLoginRole(role, ociLoginRequest, mountPath);
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
 **ociLoginRequest** | [**OciLoginRequest**](OciLoginRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oci&quot;]

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
> void UpdateOidcOidcAuthUrl (OidcOidcAuthUrlRequest oidcOidcAuthUrlRequest, string mountPath = null)

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
            var oidcOidcAuthUrlRequest = new OidcOidcAuthUrlRequest(); // OidcOidcAuthUrlRequest | 
            var mountPath = "\"oidc\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oidc")

            try
            {
                // Request an authorization URL to start an OIDC login flow.
                apiInstance.UpdateOidcOidcAuthUrl(oidcOidcAuthUrlRequest, mountPath);
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
 **oidcOidcAuthUrlRequest** | [**OidcOidcAuthUrlRequest**](OidcOidcAuthUrlRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oidc&quot;]

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
> void UpdateOidcOidcCallback (OidcOidcCallbackRequest oidcOidcCallbackRequest, string mountPath = null)

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
            var oidcOidcCallbackRequest = new OidcOidcCallbackRequest(); // OidcOidcCallbackRequest | 
            var mountPath = "\"oidc\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oidc")

            try
            {
                // Callback endpoint to handle form_posts.
                apiInstance.UpdateOidcOidcCallback(oidcOidcCallbackRequest, mountPath);
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
 **oidcOidcCallbackRequest** | [**OidcOidcCallbackRequest**](OidcOidcCallbackRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oidc&quot;]

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

<a name="updateoktaloginusername"></a>
# **UpdateOktaLoginUsername**
> void UpdateOktaLoginUsername (string username, OktaLoginRequest oktaLoginRequest, string mountPath = null)

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
    public class UpdateOktaLoginUsernameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var username = "username_example";  // string | Username to be used for login.
            var oktaLoginRequest = new OktaLoginRequest(); // OktaLoginRequest | 
            var mountPath = "\"okta\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "okta")

            try
            {
                // Log in with a username and password.
                apiInstance.UpdateOktaLoginUsername(username, oktaLoginRequest, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateOktaLoginUsername: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| Username to be used for login. | 
 **oktaLoginRequest** | [**OktaLoginRequest**](OktaLoginRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;okta&quot;]

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

<a name="updateoktausersname"></a>
# **UpdateOktaUsersName**
> void UpdateOktaUsersName (string name, OktaUsersRequest oktaUsersRequest, string mountPath = null)

Manage additional groups for users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateOktaUsersNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | Name of the user.
            var oktaUsersRequest = new OktaUsersRequest(); // OktaUsersRequest | 
            var mountPath = "\"okta\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "okta")

            try
            {
                // Manage additional groups for users allowed to authenticate.
                apiInstance.UpdateOktaUsersName(name, oktaUsersRequest, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UpdateOktaUsersName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the user. | 
 **oktaUsersRequest** | [**OktaUsersRequest**](OktaUsersRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;okta&quot;]

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
> void UpdateRadiusLoginUrlusername (string urlusername, RadiusLoginRequest radiusLoginRequest, string mountPath = null)

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
            var radiusLoginRequest = new RadiusLoginRequest(); // RadiusLoginRequest | 
            var mountPath = "\"radius\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "radius")

            try
            {
                // Log in with a username and password.
                apiInstance.UpdateRadiusLoginUrlusername(urlusername, radiusLoginRequest, mountPath);
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
 **radiusLoginRequest** | [**RadiusLoginRequest**](RadiusLoginRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;radius&quot;]

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
> void UpdateTokenCreate (TokenCreateRequest tokenCreateRequest, string format = null, string mountPath = null)

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
            var tokenCreateRequest = new TokenCreateRequest(); // TokenCreateRequest | 
            var format = "\"json\"";  // string | Return json formatted output (optional)  (default to "json")
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // The token create path is used to create new tokens.
                apiInstance.UpdateTokenCreate(tokenCreateRequest, format, mountPath);
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
 **tokenCreateRequest** | [**TokenCreateRequest**](TokenCreateRequest.md)|  | 
 **format** | **string**| Return json formatted output | [optional] [default to &quot;json&quot;]
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

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
> void UpdateTokenCreateOrphan (TokenCreateOrphanRequest tokenCreateOrphanRequest, string format = null, string mountPath = null)

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
            var tokenCreateOrphanRequest = new TokenCreateOrphanRequest(); // TokenCreateOrphanRequest | 
            var format = "\"json\"";  // string | Return json formatted output (optional)  (default to "json")
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // The token create path is used to create new orphan tokens.
                apiInstance.UpdateTokenCreateOrphan(tokenCreateOrphanRequest, format, mountPath);
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
 **tokenCreateOrphanRequest** | [**TokenCreateOrphanRequest**](TokenCreateOrphanRequest.md)|  | 
 **format** | **string**| Return json formatted output | [optional] [default to &quot;json&quot;]
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

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
> void UpdateTokenCreateRoleName (string roleName, TokenCreateRequest tokenCreateRequest, string format = null, string mountPath = null)

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
            var tokenCreateRequest = new TokenCreateRequest(); // TokenCreateRequest | 
            var format = "\"json\"";  // string | Return json formatted output (optional)  (default to "json")
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This token create path is used to create new tokens adhering to the given role.
                apiInstance.UpdateTokenCreateRoleName(roleName, tokenCreateRequest, format, mountPath);
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
 **tokenCreateRequest** | [**TokenCreateRequest**](TokenCreateRequest.md)|  | 
 **format** | **string**| Return json formatted output | [optional] [default to &quot;json&quot;]
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

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
> void UpdateTokenLookup (TokenLookupRequest tokenLookupRequest, string mountPath = null)

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
            var tokenLookupRequest = new TokenLookupRequest(); // TokenLookupRequest | 
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint will lookup a token and its properties.
                apiInstance.UpdateTokenLookup(tokenLookupRequest, mountPath);
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
 **tokenLookupRequest** | [**TokenLookupRequest**](TokenLookupRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

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
> void UpdateTokenLookupAccessor (TokenLookupAccessorRequest tokenLookupAccessorRequest, string mountPath = null)

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
            var tokenLookupAccessorRequest = new TokenLookupAccessorRequest(); // TokenLookupAccessorRequest | 
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint will lookup a token associated with the given accessor and its properties. Response will not contain the token ID.
                apiInstance.UpdateTokenLookupAccessor(tokenLookupAccessorRequest, mountPath);
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
 **tokenLookupAccessorRequest** | [**TokenLookupAccessorRequest**](TokenLookupAccessorRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

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
> void UpdateTokenLookupSelf (TokenLookupSelfRequest tokenLookupSelfRequest, string mountPath = null)

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
            var tokenLookupSelfRequest = new TokenLookupSelfRequest(); // TokenLookupSelfRequest | 
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint will lookup a token and its properties.
                apiInstance.UpdateTokenLookupSelf(tokenLookupSelfRequest, mountPath);
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
 **tokenLookupSelfRequest** | [**TokenLookupSelfRequest**](TokenLookupSelfRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

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
> void UpdateTokenRenew (TokenRenewRequest tokenRenewRequest, string mountPath = null)

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
            var tokenRenewRequest = new TokenRenewRequest(); // TokenRenewRequest | 
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint will renew the given token and prevent expiration.
                apiInstance.UpdateTokenRenew(tokenRenewRequest, mountPath);
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
 **tokenRenewRequest** | [**TokenRenewRequest**](TokenRenewRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

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
> void UpdateTokenRenewAccessor (TokenRenewAccessorRequest tokenRenewAccessorRequest, string mountPath = null)

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
            var tokenRenewAccessorRequest = new TokenRenewAccessorRequest(); // TokenRenewAccessorRequest | 
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint will renew a token associated with the given accessor and its properties. Response will not contain the token ID.
                apiInstance.UpdateTokenRenewAccessor(tokenRenewAccessorRequest, mountPath);
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
 **tokenRenewAccessorRequest** | [**TokenRenewAccessorRequest**](TokenRenewAccessorRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

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
> void UpdateTokenRenewSelf (TokenRenewSelfRequest tokenRenewSelfRequest, string mountPath = null)

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
            var tokenRenewSelfRequest = new TokenRenewSelfRequest(); // TokenRenewSelfRequest | 
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint will renew the token used to call it and prevent expiration.
                apiInstance.UpdateTokenRenewSelf(tokenRenewSelfRequest, mountPath);
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
 **tokenRenewSelfRequest** | [**TokenRenewSelfRequest**](TokenRenewSelfRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

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
> void UpdateTokenRevoke (TokenRevokeRequest tokenRevokeRequest, string mountPath = null)

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
            var tokenRevokeRequest = new TokenRevokeRequest(); // TokenRevokeRequest | 
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint will delete the given token and all of its child tokens.
                apiInstance.UpdateTokenRevoke(tokenRevokeRequest, mountPath);
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
 **tokenRevokeRequest** | [**TokenRevokeRequest**](TokenRevokeRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

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
> void UpdateTokenRevokeAccessor (TokenRevokeAccessorRequest tokenRevokeAccessorRequest, string mountPath = null)

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
            var tokenRevokeAccessorRequest = new TokenRevokeAccessorRequest(); // TokenRevokeAccessorRequest | 
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint will delete the token associated with the accessor and all of its child tokens.
                apiInstance.UpdateTokenRevokeAccessor(tokenRevokeAccessorRequest, mountPath);
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
 **tokenRevokeAccessorRequest** | [**TokenRevokeAccessorRequest**](TokenRevokeAccessorRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

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
> void UpdateTokenRevokeOrphan (TokenRevokeOrphanRequest tokenRevokeOrphanRequest, string mountPath = null)

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
            var tokenRevokeOrphanRequest = new TokenRevokeOrphanRequest(); // TokenRevokeOrphanRequest | 
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint will delete the token and orphan its child tokens.
                apiInstance.UpdateTokenRevokeOrphan(tokenRevokeOrphanRequest, mountPath);
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
 **tokenRevokeOrphanRequest** | [**TokenRevokeOrphanRequest**](TokenRevokeOrphanRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

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
> void UpdateTokenRolesRoleName (string roleName, TokenRolesRequest tokenRolesRequest, string mountPath = null)



### Example
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
            var tokenRolesRequest = new TokenRolesRequest(); // TokenRolesRequest | 
            var mountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                apiInstance.UpdateTokenRolesRoleName(roleName, tokenRolesRequest, mountPath);
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
 **tokenRolesRequest** | [**TokenRolesRequest**](TokenRolesRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

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

<a name="updateuserpassusersusername"></a>
# **UpdateUserpassUsersUsername**
> void UpdateUserpassUsersUsername (string username, UserpassUsersRequest userpassUsersRequest, string mountPath = null)

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
            var userpassUsersRequest = new UserpassUsersRequest(); // UserpassUsersRequest | 
            var mountPath = "\"userpass\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "userpass")

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.UpdateUserpassUsersUsername(username, userpassUsersRequest, mountPath);
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
 **userpassUsersRequest** | [**UserpassUsersRequest**](UserpassUsersRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;userpass&quot;]

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
> void UpdateUserpassUsersUsernamePassword (string username, UserpassUsersPasswordRequest userpassUsersPasswordRequest, string mountPath = null)

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
            var userpassUsersPasswordRequest = new UserpassUsersPasswordRequest(); // UserpassUsersPasswordRequest | 
            var mountPath = "\"userpass\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "userpass")

            try
            {
                // Reset user's password.
                apiInstance.UpdateUserpassUsersUsernamePassword(username, userpassUsersPasswordRequest, mountPath);
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
 **userpassUsersPasswordRequest** | [**UserpassUsersPasswordRequest**](UserpassUsersPasswordRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;userpass&quot;]

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
> void UpdateUserpassUsersUsernamePolicies (string username, UserpassUsersPoliciesRequest userpassUsersPoliciesRequest, string mountPath = null)

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
            var userpassUsersPoliciesRequest = new UserpassUsersPoliciesRequest(); // UserpassUsersPoliciesRequest | 
            var mountPath = "\"userpass\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "userpass")

            try
            {
                // Update the policies associated with the username.
                apiInstance.UpdateUserpassUsersUsernamePolicies(username, userpassUsersPoliciesRequest, mountPath);
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
 **userpassUsersPoliciesRequest** | [**UserpassUsersPoliciesRequest**](UserpassUsersPoliciesRequest.md)|  | 
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;userpass&quot;]

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

