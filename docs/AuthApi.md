# VaultClient.Api.AuthApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAuthAlicloudRoleRole**](AuthApi.md#deleteauthalicloudrolerole) | **DELETE** /auth/alicloud/role/{role} | Create a role and associate policies to it.
[**DeleteAuthAppIdMapAppIdKey**](AuthApi.md#deleteauthappidmapappidkey) | **DELETE** /auth/app-id/map/app-id/{key} | Read/write/delete a single app-id mapping
[**DeleteAuthAppIdMapUserIdKey**](AuthApi.md#deleteauthappidmapuseridkey) | **DELETE** /auth/app-id/map/user-id/{key} | Read/write/delete a single user-id mapping
[**DeleteAuthApproleRoleRoleName**](AuthApi.md#deleteauthapprolerolerolename) | **DELETE** /auth/approle/role/{role_name} | Register an role with the backend.
[**DeleteAuthApproleRoleRoleNameBindSecretId**](AuthApi.md#deleteauthapprolerolerolenamebindsecretid) | **DELETE** /auth/approle/role/{role_name}/bind-secret-id | Impose secret_id to be presented during login using this role.
[**DeleteAuthApproleRoleRoleNameBoundCidrList**](AuthApi.md#deleteauthapprolerolerolenameboundcidrlist) | **DELETE** /auth/approle/role/{role_name}/bound-cidr-list | Deprecated: Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
[**DeleteAuthApproleRoleRoleNamePeriod**](AuthApi.md#deleteauthapprolerolerolenameperiod) | **DELETE** /auth/approle/role/{role_name}/period | Updates the value of &#39;period&#39; on the role
[**DeleteAuthApproleRoleRoleNamePolicies**](AuthApi.md#deleteauthapprolerolerolenamepolicies) | **DELETE** /auth/approle/role/{role_name}/policies | Policies of the role.
[**DeleteAuthApproleRoleRoleNameSecretIdAccessorDestroy**](AuthApi.md#deleteauthapprolerolerolenamesecretidaccessordestroy) | **DELETE** /auth/approle/role/{role_name}/secret-id-accessor/destroy | 
[**DeleteAuthApproleRoleRoleNameSecretIdBoundCidrs**](AuthApi.md#deleteauthapprolerolerolenamesecretidboundcidrs) | **DELETE** /auth/approle/role/{role_name}/secret-id-bound-cidrs | Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
[**DeleteAuthApproleRoleRoleNameSecretIdDestroy**](AuthApi.md#deleteauthapprolerolerolenamesecretiddestroy) | **DELETE** /auth/approle/role/{role_name}/secret-id/destroy | Invalidate an issued secret_id
[**DeleteAuthApproleRoleRoleNameSecretIdNumUses**](AuthApi.md#deleteauthapprolerolerolenamesecretidnumuses) | **DELETE** /auth/approle/role/{role_name}/secret-id-num-uses | Use limit of the SecretID generated against the role.
[**DeleteAuthApproleRoleRoleNameSecretIdTtl**](AuthApi.md#deleteauthapprolerolerolenamesecretidttl) | **DELETE** /auth/approle/role/{role_name}/secret-id-ttl | Duration in seconds, representing the lifetime of the SecretIDs that are generated against the role using &#39;role/&lt;role_name&gt;/secret-id&#39; or &#39;role/&lt;role_name&gt;/custom-secret-id&#39; endpoints.
[**DeleteAuthApproleRoleRoleNameTokenBoundCidrs**](AuthApi.md#deleteauthapprolerolerolenametokenboundcidrs) | **DELETE** /auth/approle/role/{role_name}/token-bound-cidrs | Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token.
[**DeleteAuthApproleRoleRoleNameTokenMaxTtl**](AuthApi.md#deleteauthapprolerolerolenametokenmaxttl) | **DELETE** /auth/approle/role/{role_name}/token-max-ttl | Duration in seconds, the maximum lifetime of the tokens issued by using the SecretIDs that were generated against this role, after which the tokens are not allowed to be renewed.
[**DeleteAuthApproleRoleRoleNameTokenNumUses**](AuthApi.md#deleteauthapprolerolerolenametokennumuses) | **DELETE** /auth/approle/role/{role_name}/token-num-uses | Number of times issued tokens can be used
[**DeleteAuthApproleRoleRoleNameTokenTtl**](AuthApi.md#deleteauthapprolerolerolenametokenttl) | **DELETE** /auth/approle/role/{role_name}/token-ttl | Duration in seconds, the lifetime of the token issued by using the SecretID that is generated against this role, before which the token needs to be renewed.
[**DeleteAuthAwsConfigCertificateCertName**](AuthApi.md#deleteauthawsconfigcertificatecertname) | **DELETE** /auth/aws/config/certificate/{cert_name} | 
[**DeleteAuthAwsConfigClient**](AuthApi.md#deleteauthawsconfigclient) | **DELETE** /auth/aws/config/client | 
[**DeleteAuthAwsConfigStsAccountId**](AuthApi.md#deleteauthawsconfigstsaccountid) | **DELETE** /auth/aws/config/sts/{account_id} | 
[**DeleteAuthAwsConfigTidyIdentityAccesslist**](AuthApi.md#deleteauthawsconfigtidyidentityaccesslist) | **DELETE** /auth/aws/config/tidy/identity-accesslist | 
[**DeleteAuthAwsConfigTidyIdentityWhitelist**](AuthApi.md#deleteauthawsconfigtidyidentitywhitelist) | **DELETE** /auth/aws/config/tidy/identity-whitelist | 
[**DeleteAuthAwsConfigTidyRoletagBlacklist**](AuthApi.md#deleteauthawsconfigtidyroletagblacklist) | **DELETE** /auth/aws/config/tidy/roletag-blacklist | 
[**DeleteAuthAwsConfigTidyRoletagDenylist**](AuthApi.md#deleteauthawsconfigtidyroletagdenylist) | **DELETE** /auth/aws/config/tidy/roletag-denylist | 
[**DeleteAuthAwsIdentityAccesslistInstanceId**](AuthApi.md#deleteauthawsidentityaccesslistinstanceid) | **DELETE** /auth/aws/identity-accesslist/{instance_id} | 
[**DeleteAuthAwsIdentityWhitelistInstanceId**](AuthApi.md#deleteauthawsidentitywhitelistinstanceid) | **DELETE** /auth/aws/identity-whitelist/{instance_id} | 
[**DeleteAuthAwsRoleRole**](AuthApi.md#deleteauthawsrolerole) | **DELETE** /auth/aws/role/{role} | 
[**DeleteAuthAwsRoletagBlacklistRoleTag**](AuthApi.md#deleteauthawsroletagblacklistroletag) | **DELETE** /auth/aws/roletag-blacklist/{role_tag} | 
[**DeleteAuthAwsRoletagDenylistRoleTag**](AuthApi.md#deleteauthawsroletagdenylistroletag) | **DELETE** /auth/aws/roletag-denylist/{role_tag} | 
[**DeleteAuthAzureConfig**](AuthApi.md#deleteauthazureconfig) | **DELETE** /auth/azure/config | 
[**DeleteAuthAzureRoleName**](AuthApi.md#deleteauthazurerolename) | **DELETE** /auth/azure/role/{name} | 
[**DeleteAuthCertCertsName**](AuthApi.md#deleteauthcertcertsname) | **DELETE** /auth/cert/certs/{name} | Manage trusted certificates used for authentication.
[**DeleteAuthCertCrlsName**](AuthApi.md#deleteauthcertcrlsname) | **DELETE** /auth/cert/crls/{name} | Manage Certificate Revocation Lists checked during authentication.
[**DeleteAuthCfConfig**](AuthApi.md#deleteauthcfconfig) | **DELETE** /auth/cf/config | 
[**DeleteAuthCfRolesRole**](AuthApi.md#deleteauthcfrolesrole) | **DELETE** /auth/cf/roles/{role} | 
[**DeleteAuthGcpRoleName**](AuthApi.md#deleteauthgcprolename) | **DELETE** /auth/gcp/role/{name} | Create a GCP role with associated policies and required attributes.
[**DeleteAuthGithubMapTeamsKey**](AuthApi.md#deleteauthgithubmapteamskey) | **DELETE** /auth/github/map/teams/{key} | Read/write/delete a single teams mapping
[**DeleteAuthGithubMapUsersKey**](AuthApi.md#deleteauthgithubmapuserskey) | **DELETE** /auth/github/map/users/{key} | Read/write/delete a single users mapping
[**DeleteAuthJwtRoleName**](AuthApi.md#deleteauthjwtrolename) | **DELETE** /auth/jwt/role/{name} | Delete an existing role.
[**DeleteAuthKerberosGroupsName**](AuthApi.md#deleteauthkerberosgroupsname) | **DELETE** /auth/kerberos/groups/{name} | 
[**DeleteAuthKubernetesRoleName**](AuthApi.md#deleteauthkubernetesrolename) | **DELETE** /auth/kubernetes/role/{name} | Register an role with the backend.
[**DeleteAuthLdapGroupsName**](AuthApi.md#deleteauthldapgroupsname) | **DELETE** /auth/ldap/groups/{name} | Manage additional groups for users allowed to authenticate.
[**DeleteAuthLdapUsersName**](AuthApi.md#deleteauthldapusersname) | **DELETE** /auth/ldap/users/{name} | Manage users allowed to authenticate.
[**DeleteAuthOciConfig**](AuthApi.md#deleteauthociconfig) | **DELETE** /auth/oci/config | Manages the configuration for the Vault Auth Plugin.
[**DeleteAuthOciRoleRole**](AuthApi.md#deleteauthocirolerole) | **DELETE** /auth/oci/role/{role} | Create a role and associate policies to it.
[**DeleteAuthOidcRoleName**](AuthApi.md#deleteauthoidcrolename) | **DELETE** /auth/oidc/role/{name} | Delete an existing role.
[**DeleteAuthOktaGroupsName**](AuthApi.md#deleteauthoktagroupsname) | **DELETE** /auth/okta/groups/{name} | Manage users allowed to authenticate.
[**DeleteAuthOktaUsersName**](AuthApi.md#deleteauthoktausersname) | **DELETE** /auth/okta/users/{name} | Manage additional groups for users allowed to authenticate.
[**DeleteAuthRadiusUsersName**](AuthApi.md#deleteauthradiususersname) | **DELETE** /auth/radius/users/{name} | Manage users allowed to authenticate.
[**DeleteAuthTokenRolesRoleName**](AuthApi.md#deleteauthtokenrolesrolename) | **DELETE** /auth/token/roles/{role_name} | 
[**DeleteAuthUserpassUsersUsername**](AuthApi.md#deleteauthuserpassusersusername) | **DELETE** /auth/userpass/users/{username} | Manage users allowed to authenticate.
[**GetAuthAlicloudRole**](AuthApi.md#getauthalicloudrole) | **GET** /auth/alicloud/role | Lists all the roles that are registered with Vault.
[**GetAuthAlicloudRoleRole**](AuthApi.md#getauthalicloudrolerole) | **GET** /auth/alicloud/role/{role} | Create a role and associate policies to it.
[**GetAuthAlicloudRoles**](AuthApi.md#getauthalicloudroles) | **GET** /auth/alicloud/roles | Lists all the roles that are registered with Vault.
[**GetAuthAppIdMapAppId**](AuthApi.md#getauthappidmapappid) | **GET** /auth/app-id/map/app-id | Read mappings for app-id
[**GetAuthAppIdMapAppIdKey**](AuthApi.md#getauthappidmapappidkey) | **GET** /auth/app-id/map/app-id/{key} | Read/write/delete a single app-id mapping
[**GetAuthAppIdMapUserId**](AuthApi.md#getauthappidmapuserid) | **GET** /auth/app-id/map/user-id | Read mappings for user-id
[**GetAuthAppIdMapUserIdKey**](AuthApi.md#getauthappidmapuseridkey) | **GET** /auth/app-id/map/user-id/{key} | Read/write/delete a single user-id mapping
[**GetAuthApproleRole**](AuthApi.md#getauthapprolerole) | **GET** /auth/approle/role | Lists all the roles registered with the backend.
[**GetAuthApproleRoleRoleName**](AuthApi.md#getauthapprolerolerolename) | **GET** /auth/approle/role/{role_name} | Register an role with the backend.
[**GetAuthApproleRoleRoleNameBindSecretId**](AuthApi.md#getauthapprolerolerolenamebindsecretid) | **GET** /auth/approle/role/{role_name}/bind-secret-id | Impose secret_id to be presented during login using this role.
[**GetAuthApproleRoleRoleNameBoundCidrList**](AuthApi.md#getauthapprolerolerolenameboundcidrlist) | **GET** /auth/approle/role/{role_name}/bound-cidr-list | Deprecated: Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
[**GetAuthApproleRoleRoleNameLocalSecretIds**](AuthApi.md#getauthapprolerolerolenamelocalsecretids) | **GET** /auth/approle/role/{role_name}/local-secret-ids | Enables cluster local secret IDs
[**GetAuthApproleRoleRoleNamePeriod**](AuthApi.md#getauthapprolerolerolenameperiod) | **GET** /auth/approle/role/{role_name}/period | Updates the value of &#39;period&#39; on the role
[**GetAuthApproleRoleRoleNamePolicies**](AuthApi.md#getauthapprolerolerolenamepolicies) | **GET** /auth/approle/role/{role_name}/policies | Policies of the role.
[**GetAuthApproleRoleRoleNameRoleId**](AuthApi.md#getauthapprolerolerolenameroleid) | **GET** /auth/approle/role/{role_name}/role-id | Returns the &#39;role_id&#39; of the role.
[**GetAuthApproleRoleRoleNameSecretId**](AuthApi.md#getauthapprolerolerolenamesecretid) | **GET** /auth/approle/role/{role_name}/secret-id | Generate a SecretID against this role.
[**GetAuthApproleRoleRoleNameSecretIdBoundCidrs**](AuthApi.md#getauthapprolerolerolenamesecretidboundcidrs) | **GET** /auth/approle/role/{role_name}/secret-id-bound-cidrs | Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
[**GetAuthApproleRoleRoleNameSecretIdNumUses**](AuthApi.md#getauthapprolerolerolenamesecretidnumuses) | **GET** /auth/approle/role/{role_name}/secret-id-num-uses | Use limit of the SecretID generated against the role.
[**GetAuthApproleRoleRoleNameSecretIdTtl**](AuthApi.md#getauthapprolerolerolenamesecretidttl) | **GET** /auth/approle/role/{role_name}/secret-id-ttl | Duration in seconds, representing the lifetime of the SecretIDs that are generated against the role using &#39;role/&lt;role_name&gt;/secret-id&#39; or &#39;role/&lt;role_name&gt;/custom-secret-id&#39; endpoints.
[**GetAuthApproleRoleRoleNameTokenBoundCidrs**](AuthApi.md#getauthapprolerolerolenametokenboundcidrs) | **GET** /auth/approle/role/{role_name}/token-bound-cidrs | Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token.
[**GetAuthApproleRoleRoleNameTokenMaxTtl**](AuthApi.md#getauthapprolerolerolenametokenmaxttl) | **GET** /auth/approle/role/{role_name}/token-max-ttl | Duration in seconds, the maximum lifetime of the tokens issued by using the SecretIDs that were generated against this role, after which the tokens are not allowed to be renewed.
[**GetAuthApproleRoleRoleNameTokenNumUses**](AuthApi.md#getauthapprolerolerolenametokennumuses) | **GET** /auth/approle/role/{role_name}/token-num-uses | Number of times issued tokens can be used
[**GetAuthApproleRoleRoleNameTokenTtl**](AuthApi.md#getauthapprolerolerolenametokenttl) | **GET** /auth/approle/role/{role_name}/token-ttl | Duration in seconds, the lifetime of the token issued by using the SecretID that is generated against this role, before which the token needs to be renewed.
[**GetAuthAwsConfigCertificateCertName**](AuthApi.md#getauthawsconfigcertificatecertname) | **GET** /auth/aws/config/certificate/{cert_name} | 
[**GetAuthAwsConfigCertificates**](AuthApi.md#getauthawsconfigcertificates) | **GET** /auth/aws/config/certificates | 
[**GetAuthAwsConfigClient**](AuthApi.md#getauthawsconfigclient) | **GET** /auth/aws/config/client | 
[**GetAuthAwsConfigIdentity**](AuthApi.md#getauthawsconfigidentity) | **GET** /auth/aws/config/identity | 
[**GetAuthAwsConfigSts**](AuthApi.md#getauthawsconfigsts) | **GET** /auth/aws/config/sts | 
[**GetAuthAwsConfigStsAccountId**](AuthApi.md#getauthawsconfigstsaccountid) | **GET** /auth/aws/config/sts/{account_id} | 
[**GetAuthAwsConfigTidyIdentityAccesslist**](AuthApi.md#getauthawsconfigtidyidentityaccesslist) | **GET** /auth/aws/config/tidy/identity-accesslist | 
[**GetAuthAwsConfigTidyIdentityWhitelist**](AuthApi.md#getauthawsconfigtidyidentitywhitelist) | **GET** /auth/aws/config/tidy/identity-whitelist | 
[**GetAuthAwsConfigTidyRoletagBlacklist**](AuthApi.md#getauthawsconfigtidyroletagblacklist) | **GET** /auth/aws/config/tidy/roletag-blacklist | 
[**GetAuthAwsConfigTidyRoletagDenylist**](AuthApi.md#getauthawsconfigtidyroletagdenylist) | **GET** /auth/aws/config/tidy/roletag-denylist | 
[**GetAuthAwsIdentityAccesslist**](AuthApi.md#getauthawsidentityaccesslist) | **GET** /auth/aws/identity-accesslist | 
[**GetAuthAwsIdentityAccesslistInstanceId**](AuthApi.md#getauthawsidentityaccesslistinstanceid) | **GET** /auth/aws/identity-accesslist/{instance_id} | 
[**GetAuthAwsIdentityWhitelist**](AuthApi.md#getauthawsidentitywhitelist) | **GET** /auth/aws/identity-whitelist | 
[**GetAuthAwsIdentityWhitelistInstanceId**](AuthApi.md#getauthawsidentitywhitelistinstanceid) | **GET** /auth/aws/identity-whitelist/{instance_id} | 
[**GetAuthAwsRole**](AuthApi.md#getauthawsrole) | **GET** /auth/aws/role | 
[**GetAuthAwsRoleRole**](AuthApi.md#getauthawsrolerole) | **GET** /auth/aws/role/{role} | 
[**GetAuthAwsRoles**](AuthApi.md#getauthawsroles) | **GET** /auth/aws/roles | 
[**GetAuthAwsRoletagBlacklist**](AuthApi.md#getauthawsroletagblacklist) | **GET** /auth/aws/roletag-blacklist | 
[**GetAuthAwsRoletagBlacklistRoleTag**](AuthApi.md#getauthawsroletagblacklistroletag) | **GET** /auth/aws/roletag-blacklist/{role_tag} | 
[**GetAuthAwsRoletagDenylist**](AuthApi.md#getauthawsroletagdenylist) | **GET** /auth/aws/roletag-denylist | 
[**GetAuthAwsRoletagDenylistRoleTag**](AuthApi.md#getauthawsroletagdenylistroletag) | **GET** /auth/aws/roletag-denylist/{role_tag} | 
[**GetAuthAzureConfig**](AuthApi.md#getauthazureconfig) | **GET** /auth/azure/config | 
[**GetAuthAzureRole**](AuthApi.md#getauthazurerole) | **GET** /auth/azure/role | 
[**GetAuthAzureRoleName**](AuthApi.md#getauthazurerolename) | **GET** /auth/azure/role/{name} | 
[**GetAuthCentrifyConfig**](AuthApi.md#getauthcentrifyconfig) | **GET** /auth/centrify/config | This path allows you to configure the centrify auth provider to interact with the Centrify Identity Services Platform for authenticating users.
[**GetAuthCertCerts**](AuthApi.md#getauthcertcerts) | **GET** /auth/cert/certs | Manage trusted certificates used for authentication.
[**GetAuthCertCertsName**](AuthApi.md#getauthcertcertsname) | **GET** /auth/cert/certs/{name} | Manage trusted certificates used for authentication.
[**GetAuthCertCrlsName**](AuthApi.md#getauthcertcrlsname) | **GET** /auth/cert/crls/{name} | Manage Certificate Revocation Lists checked during authentication.
[**GetAuthCfConfig**](AuthApi.md#getauthcfconfig) | **GET** /auth/cf/config | 
[**GetAuthCfRoles**](AuthApi.md#getauthcfroles) | **GET** /auth/cf/roles | 
[**GetAuthCfRolesRole**](AuthApi.md#getauthcfrolesrole) | **GET** /auth/cf/roles/{role} | 
[**GetAuthGcpConfig**](AuthApi.md#getauthgcpconfig) | **GET** /auth/gcp/config | Configure credentials used to query the GCP IAM API to verify authenticating service accounts
[**GetAuthGcpRole**](AuthApi.md#getauthgcprole) | **GET** /auth/gcp/role | Lists all the roles that are registered with Vault.
[**GetAuthGcpRoleName**](AuthApi.md#getauthgcprolename) | **GET** /auth/gcp/role/{name} | Create a GCP role with associated policies and required attributes.
[**GetAuthGcpRoles**](AuthApi.md#getauthgcproles) | **GET** /auth/gcp/roles | Lists all the roles that are registered with Vault.
[**GetAuthGithubConfig**](AuthApi.md#getauthgithubconfig) | **GET** /auth/github/config | 
[**GetAuthGithubMapTeams**](AuthApi.md#getauthgithubmapteams) | **GET** /auth/github/map/teams | Read mappings for teams
[**GetAuthGithubMapTeamsKey**](AuthApi.md#getauthgithubmapteamskey) | **GET** /auth/github/map/teams/{key} | Read/write/delete a single teams mapping
[**GetAuthGithubMapUsers**](AuthApi.md#getauthgithubmapusers) | **GET** /auth/github/map/users | Read mappings for users
[**GetAuthGithubMapUsersKey**](AuthApi.md#getauthgithubmapuserskey) | **GET** /auth/github/map/users/{key} | Read/write/delete a single users mapping
[**GetAuthJwtConfig**](AuthApi.md#getauthjwtconfig) | **GET** /auth/jwt/config | Read the current JWT authentication backend configuration.
[**GetAuthJwtOidcCallback**](AuthApi.md#getauthjwtoidccallback) | **GET** /auth/jwt/oidc/callback | Callback endpoint to complete an OIDC login.
[**GetAuthJwtRole**](AuthApi.md#getauthjwtrole) | **GET** /auth/jwt/role | Lists all the roles registered with the backend.
[**GetAuthJwtRoleName**](AuthApi.md#getauthjwtrolename) | **GET** /auth/jwt/role/{name} | Read an existing role.
[**GetAuthKerberosConfig**](AuthApi.md#getauthkerberosconfig) | **GET** /auth/kerberos/config | 
[**GetAuthKerberosConfigLdap**](AuthApi.md#getauthkerberosconfigldap) | **GET** /auth/kerberos/config/ldap | 
[**GetAuthKerberosGroups**](AuthApi.md#getauthkerberosgroups) | **GET** /auth/kerberos/groups | 
[**GetAuthKerberosGroupsName**](AuthApi.md#getauthkerberosgroupsname) | **GET** /auth/kerberos/groups/{name} | 
[**GetAuthKerberosLogin**](AuthApi.md#getauthkerberoslogin) | **GET** /auth/kerberos/login | 
[**GetAuthKubernetesConfig**](AuthApi.md#getauthkubernetesconfig) | **GET** /auth/kubernetes/config | Configures the JWT Public Key and Kubernetes API information.
[**GetAuthKubernetesRole**](AuthApi.md#getauthkubernetesrole) | **GET** /auth/kubernetes/role | Lists all the roles registered with the backend.
[**GetAuthKubernetesRoleName**](AuthApi.md#getauthkubernetesrolename) | **GET** /auth/kubernetes/role/{name} | Register an role with the backend.
[**GetAuthLdapConfig**](AuthApi.md#getauthldapconfig) | **GET** /auth/ldap/config | Configure the LDAP server to connect to, along with its options.
[**GetAuthLdapGroups**](AuthApi.md#getauthldapgroups) | **GET** /auth/ldap/groups | Manage additional groups for users allowed to authenticate.
[**GetAuthLdapGroupsName**](AuthApi.md#getauthldapgroupsname) | **GET** /auth/ldap/groups/{name} | Manage additional groups for users allowed to authenticate.
[**GetAuthLdapUsers**](AuthApi.md#getauthldapusers) | **GET** /auth/ldap/users | Manage users allowed to authenticate.
[**GetAuthLdapUsersName**](AuthApi.md#getauthldapusersname) | **GET** /auth/ldap/users/{name} | Manage users allowed to authenticate.
[**GetAuthOciConfig**](AuthApi.md#getauthociconfig) | **GET** /auth/oci/config | Manages the configuration for the Vault Auth Plugin.
[**GetAuthOciRole**](AuthApi.md#getauthocirole) | **GET** /auth/oci/role | Lists all the roles that are registered with Vault.
[**GetAuthOciRoleRole**](AuthApi.md#getauthocirolerole) | **GET** /auth/oci/role/{role} | Create a role and associate policies to it.
[**GetAuthOidcConfig**](AuthApi.md#getauthoidcconfig) | **GET** /auth/oidc/config | Read the current JWT authentication backend configuration.
[**GetAuthOidcOidcCallback**](AuthApi.md#getauthoidcoidccallback) | **GET** /auth/oidc/oidc/callback | Callback endpoint to complete an OIDC login.
[**GetAuthOidcRole**](AuthApi.md#getauthoidcrole) | **GET** /auth/oidc/role | Lists all the roles registered with the backend.
[**GetAuthOidcRoleName**](AuthApi.md#getauthoidcrolename) | **GET** /auth/oidc/role/{name} | Read an existing role.
[**GetAuthOktaConfig**](AuthApi.md#getauthoktaconfig) | **GET** /auth/okta/config | This endpoint allows you to configure the Okta and its configuration options.  The Okta organization are the characters at the front of the URL for Okta. Example https://ORG.okta.com
[**GetAuthOktaGroups**](AuthApi.md#getauthoktagroups) | **GET** /auth/okta/groups | Manage users allowed to authenticate.
[**GetAuthOktaGroupsName**](AuthApi.md#getauthoktagroupsname) | **GET** /auth/okta/groups/{name} | Manage users allowed to authenticate.
[**GetAuthOktaUsers**](AuthApi.md#getauthoktausers) | **GET** /auth/okta/users | Manage additional groups for users allowed to authenticate.
[**GetAuthOktaUsersName**](AuthApi.md#getauthoktausersname) | **GET** /auth/okta/users/{name} | Manage additional groups for users allowed to authenticate.
[**GetAuthOktaVerifyNonce**](AuthApi.md#getauthoktaverifynonce) | **GET** /auth/okta/verify/{nonce} | 
[**GetAuthRadiusConfig**](AuthApi.md#getauthradiusconfig) | **GET** /auth/radius/config | Configure the RADIUS server to connect to, along with its options.
[**GetAuthRadiusUsers**](AuthApi.md#getauthradiususers) | **GET** /auth/radius/users | Manage users allowed to authenticate.
[**GetAuthRadiusUsersName**](AuthApi.md#getauthradiususersname) | **GET** /auth/radius/users/{name} | Manage users allowed to authenticate.
[**GetAuthTokenAccessors**](AuthApi.md#getauthtokenaccessors) | **GET** /auth/token/accessors/ | List token accessors, which can then be be used to iterate and discover their properties or revoke them. Because this can be used to cause a denial of service, this endpoint requires &#39;sudo&#39; capability in addition to &#39;list&#39;.
[**GetAuthTokenLookup**](AuthApi.md#getauthtokenlookup) | **GET** /auth/token/lookup | This endpoint will lookup a token and its properties.
[**GetAuthTokenLookupSelf**](AuthApi.md#getauthtokenlookupself) | **GET** /auth/token/lookup-self | This endpoint will lookup a token and its properties.
[**GetAuthTokenRoles**](AuthApi.md#getauthtokenroles) | **GET** /auth/token/roles | This endpoint lists configured roles.
[**GetAuthTokenRolesRoleName**](AuthApi.md#getauthtokenrolesrolename) | **GET** /auth/token/roles/{role_name} | 
[**GetAuthUserpassUsers**](AuthApi.md#getauthuserpassusers) | **GET** /auth/userpass/users | Manage users allowed to authenticate.
[**GetAuthUserpassUsersUsername**](AuthApi.md#getauthuserpassusersusername) | **GET** /auth/userpass/users/{username} | Manage users allowed to authenticate.
[**PostAuthAlicloudLogin**](AuthApi.md#postauthalicloudlogin) | **POST** /auth/alicloud/login | Authenticates an RAM entity with Vault.
[**PostAuthAlicloudRoleRole**](AuthApi.md#postauthalicloudrolerole) | **POST** /auth/alicloud/role/{role} | Create a role and associate policies to it.
[**PostAuthAppIdLogin**](AuthApi.md#postauthappidlogin) | **POST** /auth/app-id/login | Log in with an App ID and User ID.
[**PostAuthAppIdLoginAppId**](AuthApi.md#postauthappidloginappid) | **POST** /auth/app-id/login/{app_id} | Log in with an App ID and User ID.
[**PostAuthAppIdMapAppIdKey**](AuthApi.md#postauthappidmapappidkey) | **POST** /auth/app-id/map/app-id/{key} | Read/write/delete a single app-id mapping
[**PostAuthAppIdMapUserIdKey**](AuthApi.md#postauthappidmapuseridkey) | **POST** /auth/app-id/map/user-id/{key} | Read/write/delete a single user-id mapping
[**PostAuthApproleLogin**](AuthApi.md#postauthapprolelogin) | **POST** /auth/approle/login | 
[**PostAuthApproleRoleRoleName**](AuthApi.md#postauthapprolerolerolename) | **POST** /auth/approle/role/{role_name} | Register an role with the backend.
[**PostAuthApproleRoleRoleNameBindSecretId**](AuthApi.md#postauthapprolerolerolenamebindsecretid) | **POST** /auth/approle/role/{role_name}/bind-secret-id | Impose secret_id to be presented during login using this role.
[**PostAuthApproleRoleRoleNameBoundCidrList**](AuthApi.md#postauthapprolerolerolenameboundcidrlist) | **POST** /auth/approle/role/{role_name}/bound-cidr-list | Deprecated: Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
[**PostAuthApproleRoleRoleNameCustomSecretId**](AuthApi.md#postauthapprolerolerolenamecustomsecretid) | **POST** /auth/approle/role/{role_name}/custom-secret-id | Assign a SecretID of choice against the role.
[**PostAuthApproleRoleRoleNamePeriod**](AuthApi.md#postauthapprolerolerolenameperiod) | **POST** /auth/approle/role/{role_name}/period | Updates the value of &#39;period&#39; on the role
[**PostAuthApproleRoleRoleNamePolicies**](AuthApi.md#postauthapprolerolerolenamepolicies) | **POST** /auth/approle/role/{role_name}/policies | Policies of the role.
[**PostAuthApproleRoleRoleNameRoleId**](AuthApi.md#postauthapprolerolerolenameroleid) | **POST** /auth/approle/role/{role_name}/role-id | Returns the &#39;role_id&#39; of the role.
[**PostAuthApproleRoleRoleNameSecretId**](AuthApi.md#postauthapprolerolerolenamesecretid) | **POST** /auth/approle/role/{role_name}/secret-id | Generate a SecretID against this role.
[**PostAuthApproleRoleRoleNameSecretIdAccessorDestroy**](AuthApi.md#postauthapprolerolerolenamesecretidaccessordestroy) | **POST** /auth/approle/role/{role_name}/secret-id-accessor/destroy | 
[**PostAuthApproleRoleRoleNameSecretIdAccessorLookup**](AuthApi.md#postauthapprolerolerolenamesecretidaccessorlookup) | **POST** /auth/approle/role/{role_name}/secret-id-accessor/lookup | 
[**PostAuthApproleRoleRoleNameSecretIdBoundCidrs**](AuthApi.md#postauthapprolerolerolenamesecretidboundcidrs) | **POST** /auth/approle/role/{role_name}/secret-id-bound-cidrs | Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
[**PostAuthApproleRoleRoleNameSecretIdDestroy**](AuthApi.md#postauthapprolerolerolenamesecretiddestroy) | **POST** /auth/approle/role/{role_name}/secret-id/destroy | Invalidate an issued secret_id
[**PostAuthApproleRoleRoleNameSecretIdLookup**](AuthApi.md#postauthapprolerolerolenamesecretidlookup) | **POST** /auth/approle/role/{role_name}/secret-id/lookup | Read the properties of an issued secret_id
[**PostAuthApproleRoleRoleNameSecretIdNumUses**](AuthApi.md#postauthapprolerolerolenamesecretidnumuses) | **POST** /auth/approle/role/{role_name}/secret-id-num-uses | Use limit of the SecretID generated against the role.
[**PostAuthApproleRoleRoleNameSecretIdTtl**](AuthApi.md#postauthapprolerolerolenamesecretidttl) | **POST** /auth/approle/role/{role_name}/secret-id-ttl | Duration in seconds, representing the lifetime of the SecretIDs that are generated against the role using &#39;role/&lt;role_name&gt;/secret-id&#39; or &#39;role/&lt;role_name&gt;/custom-secret-id&#39; endpoints.
[**PostAuthApproleRoleRoleNameTokenBoundCidrs**](AuthApi.md#postauthapprolerolerolenametokenboundcidrs) | **POST** /auth/approle/role/{role_name}/token-bound-cidrs | Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token.
[**PostAuthApproleRoleRoleNameTokenMaxTtl**](AuthApi.md#postauthapprolerolerolenametokenmaxttl) | **POST** /auth/approle/role/{role_name}/token-max-ttl | Duration in seconds, the maximum lifetime of the tokens issued by using the SecretIDs that were generated against this role, after which the tokens are not allowed to be renewed.
[**PostAuthApproleRoleRoleNameTokenNumUses**](AuthApi.md#postauthapprolerolerolenametokennumuses) | **POST** /auth/approle/role/{role_name}/token-num-uses | Number of times issued tokens can be used
[**PostAuthApproleRoleRoleNameTokenTtl**](AuthApi.md#postauthapprolerolerolenametokenttl) | **POST** /auth/approle/role/{role_name}/token-ttl | Duration in seconds, the lifetime of the token issued by using the SecretID that is generated against this role, before which the token needs to be renewed.
[**PostAuthApproleTidySecretId**](AuthApi.md#postauthapproletidysecretid) | **POST** /auth/approle/tidy/secret-id | Trigger the clean-up of expired SecretID entries.
[**PostAuthAwsConfigCertificateCertName**](AuthApi.md#postauthawsconfigcertificatecertname) | **POST** /auth/aws/config/certificate/{cert_name} | 
[**PostAuthAwsConfigClient**](AuthApi.md#postauthawsconfigclient) | **POST** /auth/aws/config/client | 
[**PostAuthAwsConfigIdentity**](AuthApi.md#postauthawsconfigidentity) | **POST** /auth/aws/config/identity | 
[**PostAuthAwsConfigRotateRoot**](AuthApi.md#postauthawsconfigrotateroot) | **POST** /auth/aws/config/rotate-root | 
[**PostAuthAwsConfigStsAccountId**](AuthApi.md#postauthawsconfigstsaccountid) | **POST** /auth/aws/config/sts/{account_id} | 
[**PostAuthAwsConfigTidyIdentityAccesslist**](AuthApi.md#postauthawsconfigtidyidentityaccesslist) | **POST** /auth/aws/config/tidy/identity-accesslist | 
[**PostAuthAwsConfigTidyIdentityWhitelist**](AuthApi.md#postauthawsconfigtidyidentitywhitelist) | **POST** /auth/aws/config/tidy/identity-whitelist | 
[**PostAuthAwsConfigTidyRoletagBlacklist**](AuthApi.md#postauthawsconfigtidyroletagblacklist) | **POST** /auth/aws/config/tidy/roletag-blacklist | 
[**PostAuthAwsConfigTidyRoletagDenylist**](AuthApi.md#postauthawsconfigtidyroletagdenylist) | **POST** /auth/aws/config/tidy/roletag-denylist | 
[**PostAuthAwsLogin**](AuthApi.md#postauthawslogin) | **POST** /auth/aws/login | 
[**PostAuthAwsRoleRole**](AuthApi.md#postauthawsrolerole) | **POST** /auth/aws/role/{role} | 
[**PostAuthAwsRoleRoleTag**](AuthApi.md#postauthawsroleroletag) | **POST** /auth/aws/role/{role}/tag | 
[**PostAuthAwsRoletagBlacklistRoleTag**](AuthApi.md#postauthawsroletagblacklistroletag) | **POST** /auth/aws/roletag-blacklist/{role_tag} | 
[**PostAuthAwsRoletagDenylistRoleTag**](AuthApi.md#postauthawsroletagdenylistroletag) | **POST** /auth/aws/roletag-denylist/{role_tag} | 
[**PostAuthAwsTidyIdentityAccesslist**](AuthApi.md#postauthawstidyidentityaccesslist) | **POST** /auth/aws/tidy/identity-accesslist | 
[**PostAuthAwsTidyIdentityWhitelist**](AuthApi.md#postauthawstidyidentitywhitelist) | **POST** /auth/aws/tidy/identity-whitelist | 
[**PostAuthAwsTidyRoletagBlacklist**](AuthApi.md#postauthawstidyroletagblacklist) | **POST** /auth/aws/tidy/roletag-blacklist | 
[**PostAuthAwsTidyRoletagDenylist**](AuthApi.md#postauthawstidyroletagdenylist) | **POST** /auth/aws/tidy/roletag-denylist | 
[**PostAuthAzureConfig**](AuthApi.md#postauthazureconfig) | **POST** /auth/azure/config | 
[**PostAuthAzureLogin**](AuthApi.md#postauthazurelogin) | **POST** /auth/azure/login | 
[**PostAuthAzureRoleName**](AuthApi.md#postauthazurerolename) | **POST** /auth/azure/role/{name} | 
[**PostAuthCentrifyConfig**](AuthApi.md#postauthcentrifyconfig) | **POST** /auth/centrify/config | This path allows you to configure the centrify auth provider to interact with the Centrify Identity Services Platform for authenticating users.
[**PostAuthCentrifyLogin**](AuthApi.md#postauthcentrifylogin) | **POST** /auth/centrify/login | Log in with a username and password.
[**PostAuthCertCertsName**](AuthApi.md#postauthcertcertsname) | **POST** /auth/cert/certs/{name} | Manage trusted certificates used for authentication.
[**PostAuthCertConfig**](AuthApi.md#postauthcertconfig) | **POST** /auth/cert/config | 
[**PostAuthCertCrlsName**](AuthApi.md#postauthcertcrlsname) | **POST** /auth/cert/crls/{name} | Manage Certificate Revocation Lists checked during authentication.
[**PostAuthCertLogin**](AuthApi.md#postauthcertlogin) | **POST** /auth/cert/login | 
[**PostAuthCfConfig**](AuthApi.md#postauthcfconfig) | **POST** /auth/cf/config | 
[**PostAuthCfLogin**](AuthApi.md#postauthcflogin) | **POST** /auth/cf/login | 
[**PostAuthCfRolesRole**](AuthApi.md#postauthcfrolesrole) | **POST** /auth/cf/roles/{role} | 
[**PostAuthGcpConfig**](AuthApi.md#postauthgcpconfig) | **POST** /auth/gcp/config | Configure credentials used to query the GCP IAM API to verify authenticating service accounts
[**PostAuthGcpLogin**](AuthApi.md#postauthgcplogin) | **POST** /auth/gcp/login | 
[**PostAuthGcpRoleName**](AuthApi.md#postauthgcprolename) | **POST** /auth/gcp/role/{name} | Create a GCP role with associated policies and required attributes.
[**PostAuthGcpRoleNameLabels**](AuthApi.md#postauthgcprolenamelabels) | **POST** /auth/gcp/role/{name}/labels | Add or remove labels for an existing &#39;gce&#39; role
[**PostAuthGcpRoleNameServiceAccounts**](AuthApi.md#postauthgcprolenameserviceaccounts) | **POST** /auth/gcp/role/{name}/service-accounts | Add or remove service accounts for an existing &#x60;iam&#x60; role
[**PostAuthGithubConfig**](AuthApi.md#postauthgithubconfig) | **POST** /auth/github/config | 
[**PostAuthGithubLogin**](AuthApi.md#postauthgithublogin) | **POST** /auth/github/login | 
[**PostAuthGithubMapTeamsKey**](AuthApi.md#postauthgithubmapteamskey) | **POST** /auth/github/map/teams/{key} | Read/write/delete a single teams mapping
[**PostAuthGithubMapUsersKey**](AuthApi.md#postauthgithubmapuserskey) | **POST** /auth/github/map/users/{key} | Read/write/delete a single users mapping
[**PostAuthJwtConfig**](AuthApi.md#postauthjwtconfig) | **POST** /auth/jwt/config | Configure the JWT authentication backend.
[**PostAuthJwtLogin**](AuthApi.md#postauthjwtlogin) | **POST** /auth/jwt/login | Authenticates to Vault using a JWT (or OIDC) token.
[**PostAuthJwtOidcAuthUrl**](AuthApi.md#postauthjwtoidcauthurl) | **POST** /auth/jwt/oidc/auth_url | Request an authorization URL to start an OIDC login flow.
[**PostAuthJwtOidcCallback**](AuthApi.md#postauthjwtoidccallback) | **POST** /auth/jwt/oidc/callback | Callback endpoint to handle form_posts.
[**PostAuthJwtRoleName**](AuthApi.md#postauthjwtrolename) | **POST** /auth/jwt/role/{name} | Register an role with the backend.
[**PostAuthKerberosConfig**](AuthApi.md#postauthkerberosconfig) | **POST** /auth/kerberos/config | 
[**PostAuthKerberosConfigLdap**](AuthApi.md#postauthkerberosconfigldap) | **POST** /auth/kerberos/config/ldap | 
[**PostAuthKerberosGroupsName**](AuthApi.md#postauthkerberosgroupsname) | **POST** /auth/kerberos/groups/{name} | 
[**PostAuthKerberosLogin**](AuthApi.md#postauthkerberoslogin) | **POST** /auth/kerberos/login | 
[**PostAuthKubernetesConfig**](AuthApi.md#postauthkubernetesconfig) | **POST** /auth/kubernetes/config | Configures the JWT Public Key and Kubernetes API information.
[**PostAuthKubernetesLogin**](AuthApi.md#postauthkuberneteslogin) | **POST** /auth/kubernetes/login | Authenticates Kubernetes service accounts with Vault.
[**PostAuthKubernetesRoleName**](AuthApi.md#postauthkubernetesrolename) | **POST** /auth/kubernetes/role/{name} | Register an role with the backend.
[**PostAuthLdapConfig**](AuthApi.md#postauthldapconfig) | **POST** /auth/ldap/config | Configure the LDAP server to connect to, along with its options.
[**PostAuthLdapGroupsName**](AuthApi.md#postauthldapgroupsname) | **POST** /auth/ldap/groups/{name} | Manage additional groups for users allowed to authenticate.
[**PostAuthLdapLoginUsername**](AuthApi.md#postauthldaploginusername) | **POST** /auth/ldap/login/{username} | Log in with a username and password.
[**PostAuthLdapUsersName**](AuthApi.md#postauthldapusersname) | **POST** /auth/ldap/users/{name} | Manage users allowed to authenticate.
[**PostAuthOciConfig**](AuthApi.md#postauthociconfig) | **POST** /auth/oci/config | Manages the configuration for the Vault Auth Plugin.
[**PostAuthOciLoginRole**](AuthApi.md#postauthociloginrole) | **POST** /auth/oci/login/{role} | Authenticates to Vault using OCI credentials
[**PostAuthOciRoleRole**](AuthApi.md#postauthocirolerole) | **POST** /auth/oci/role/{role} | Create a role and associate policies to it.
[**PostAuthOidcConfig**](AuthApi.md#postauthoidcconfig) | **POST** /auth/oidc/config | Configure the JWT authentication backend.
[**PostAuthOidcLogin**](AuthApi.md#postauthoidclogin) | **POST** /auth/oidc/login | Authenticates to Vault using a JWT (or OIDC) token.
[**PostAuthOidcOidcAuthUrl**](AuthApi.md#postauthoidcoidcauthurl) | **POST** /auth/oidc/oidc/auth_url | Request an authorization URL to start an OIDC login flow.
[**PostAuthOidcOidcCallback**](AuthApi.md#postauthoidcoidccallback) | **POST** /auth/oidc/oidc/callback | Callback endpoint to handle form_posts.
[**PostAuthOidcRoleName**](AuthApi.md#postauthoidcrolename) | **POST** /auth/oidc/role/{name} | Register an role with the backend.
[**PostAuthOktaConfig**](AuthApi.md#postauthoktaconfig) | **POST** /auth/okta/config | This endpoint allows you to configure the Okta and its configuration options.  The Okta organization are the characters at the front of the URL for Okta. Example https://ORG.okta.com
[**PostAuthOktaGroupsName**](AuthApi.md#postauthoktagroupsname) | **POST** /auth/okta/groups/{name} | Manage users allowed to authenticate.
[**PostAuthOktaLoginUsername**](AuthApi.md#postauthoktaloginusername) | **POST** /auth/okta/login/{username} | Log in with a username and password.
[**PostAuthOktaUsersName**](AuthApi.md#postauthoktausersname) | **POST** /auth/okta/users/{name} | Manage additional groups for users allowed to authenticate.
[**PostAuthRadiusConfig**](AuthApi.md#postauthradiusconfig) | **POST** /auth/radius/config | Configure the RADIUS server to connect to, along with its options.
[**PostAuthRadiusLogin**](AuthApi.md#postauthradiuslogin) | **POST** /auth/radius/login | Log in with a username and password.
[**PostAuthRadiusLoginUrlusername**](AuthApi.md#postauthradiusloginurlusername) | **POST** /auth/radius/login/{urlusername} | Log in with a username and password.
[**PostAuthRadiusUsersName**](AuthApi.md#postauthradiususersname) | **POST** /auth/radius/users/{name} | Manage users allowed to authenticate.
[**PostAuthTokenCreate**](AuthApi.md#postauthtokencreate) | **POST** /auth/token/create | The token create path is used to create new tokens.
[**PostAuthTokenCreateOrphan**](AuthApi.md#postauthtokencreateorphan) | **POST** /auth/token/create-orphan | The token create path is used to create new orphan tokens.
[**PostAuthTokenCreateRoleName**](AuthApi.md#postauthtokencreaterolename) | **POST** /auth/token/create/{role_name} | This token create path is used to create new tokens adhering to the given role.
[**PostAuthTokenLookup**](AuthApi.md#postauthtokenlookup) | **POST** /auth/token/lookup | This endpoint will lookup a token and its properties.
[**PostAuthTokenLookupAccessor**](AuthApi.md#postauthtokenlookupaccessor) | **POST** /auth/token/lookup-accessor | This endpoint will lookup a token associated with the given accessor and its properties. Response will not contain the token ID.
[**PostAuthTokenLookupSelf**](AuthApi.md#postauthtokenlookupself) | **POST** /auth/token/lookup-self | This endpoint will lookup a token and its properties.
[**PostAuthTokenRenew**](AuthApi.md#postauthtokenrenew) | **POST** /auth/token/renew | This endpoint will renew the given token and prevent expiration.
[**PostAuthTokenRenewAccessor**](AuthApi.md#postauthtokenrenewaccessor) | **POST** /auth/token/renew-accessor | This endpoint will renew a token associated with the given accessor and its properties. Response will not contain the token ID.
[**PostAuthTokenRenewSelf**](AuthApi.md#postauthtokenrenewself) | **POST** /auth/token/renew-self | This endpoint will renew the token used to call it and prevent expiration.
[**PostAuthTokenRevoke**](AuthApi.md#postauthtokenrevoke) | **POST** /auth/token/revoke | This endpoint will delete the given token and all of its child tokens.
[**PostAuthTokenRevokeAccessor**](AuthApi.md#postauthtokenrevokeaccessor) | **POST** /auth/token/revoke-accessor | This endpoint will delete the token associated with the accessor and all of its child tokens.
[**PostAuthTokenRevokeOrphan**](AuthApi.md#postauthtokenrevokeorphan) | **POST** /auth/token/revoke-orphan | This endpoint will delete the token and orphan its child tokens.
[**PostAuthTokenRevokeSelf**](AuthApi.md#postauthtokenrevokeself) | **POST** /auth/token/revoke-self | This endpoint will delete the token used to call it and all of its child tokens.
[**PostAuthTokenRolesRoleName**](AuthApi.md#postauthtokenrolesrolename) | **POST** /auth/token/roles/{role_name} | 
[**PostAuthTokenTidy**](AuthApi.md#postauthtokentidy) | **POST** /auth/token/tidy | This endpoint performs cleanup tasks that can be run if certain error conditions have occurred.
[**PostAuthUserpassLoginUsername**](AuthApi.md#postauthuserpassloginusername) | **POST** /auth/userpass/login/{username} | Log in with a username and password.
[**PostAuthUserpassUsersUsername**](AuthApi.md#postauthuserpassusersusername) | **POST** /auth/userpass/users/{username} | Manage users allowed to authenticate.
[**PostAuthUserpassUsersUsernamePassword**](AuthApi.md#postauthuserpassusersusernamepassword) | **POST** /auth/userpass/users/{username}/password | Reset user&#39;s password.
[**PostAuthUserpassUsersUsernamePolicies**](AuthApi.md#postauthuserpassusersusernamepolicies) | **POST** /auth/userpass/users/{username}/policies | Update the policies associated with the username.


<a name="deleteauthalicloudrolerole"></a>
# **DeleteAuthAlicloudRoleRole**
> void DeleteAuthAlicloudRoleRole (string role)

Create a role and associate policies to it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthAlicloudRoleRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var role = "role_example";  // string | The name of the role as it should appear in Vault.

            try
            {
                // Create a role and associate policies to it.
                apiInstance.DeleteAuthAlicloudRoleRole(role);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthAlicloudRoleRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The name of the role as it should appear in Vault. | 

### Return type

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

<a name="deleteauthappidmapappidkey"></a>
# **DeleteAuthAppIdMapAppIdKey**
> void DeleteAuthAppIdMapAppIdKey (string key)

Read/write/delete a single app-id mapping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthAppIdMapAppIdKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var key = "key_example";  // string | Key for the app-id mapping

            try
            {
                // Read/write/delete a single app-id mapping
                apiInstance.DeleteAuthAppIdMapAppIdKey(key);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthAppIdMapAppIdKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Key for the app-id mapping | 

### Return type

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

<a name="deleteauthappidmapuseridkey"></a>
# **DeleteAuthAppIdMapUserIdKey**
> void DeleteAuthAppIdMapUserIdKey (string key)

Read/write/delete a single user-id mapping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthAppIdMapUserIdKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var key = "key_example";  // string | Key for the user-id mapping

            try
            {
                // Read/write/delete a single user-id mapping
                apiInstance.DeleteAuthAppIdMapUserIdKey(key);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthAppIdMapUserIdKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Key for the user-id mapping | 

### Return type

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

<a name="deleteauthapprolerolerolename"></a>
# **DeleteAuthApproleRoleRoleName**
> void DeleteAuthApproleRoleRoleName (string roleName)

Register an role with the backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Register an role with the backend.
                apiInstance.DeleteAuthApproleRoleRoleName(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthApproleRoleRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

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

<a name="deleteauthapprolerolerolenamebindsecretid"></a>
# **DeleteAuthApproleRoleRoleNameBindSecretId**
> void DeleteAuthApproleRoleRoleNameBindSecretId (string roleName)

Impose secret_id to be presented during login using this role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNameBindSecretIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Impose secret_id to be presented during login using this role.
                apiInstance.DeleteAuthApproleRoleRoleNameBindSecretId(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthApproleRoleRoleNameBindSecretId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

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

<a name="deleteauthapprolerolerolenameboundcidrlist"></a>
# **DeleteAuthApproleRoleRoleNameBoundCidrList**
> void DeleteAuthApproleRoleRoleNameBoundCidrList (string roleName)

Deprecated: Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNameBoundCidrListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Deprecated: Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
                apiInstance.DeleteAuthApproleRoleRoleNameBoundCidrList(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthApproleRoleRoleNameBoundCidrList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

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

<a name="deleteauthapprolerolerolenameperiod"></a>
# **DeleteAuthApproleRoleRoleNamePeriod**
> void DeleteAuthApproleRoleRoleNamePeriod (string roleName)

Updates the value of 'period' on the role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNamePeriodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Updates the value of 'period' on the role
                apiInstance.DeleteAuthApproleRoleRoleNamePeriod(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthApproleRoleRoleNamePeriod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

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

<a name="deleteauthapprolerolerolenamepolicies"></a>
# **DeleteAuthApproleRoleRoleNamePolicies**
> void DeleteAuthApproleRoleRoleNamePolicies (string roleName)

Policies of the role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNamePoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Policies of the role.
                apiInstance.DeleteAuthApproleRoleRoleNamePolicies(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthApproleRoleRoleNamePolicies: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

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

<a name="deleteauthapprolerolerolenamesecretidaccessordestroy"></a>
# **DeleteAuthApproleRoleRoleNameSecretIdAccessorDestroy**
> void DeleteAuthApproleRoleRoleNameSecretIdAccessorDestroy (string roleName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNameSecretIdAccessorDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                apiInstance.DeleteAuthApproleRoleRoleNameSecretIdAccessorDestroy(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthApproleRoleRoleNameSecretIdAccessorDestroy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

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

<a name="deleteauthapprolerolerolenamesecretidboundcidrs"></a>
# **DeleteAuthApproleRoleRoleNameSecretIdBoundCidrs**
> void DeleteAuthApproleRoleRoleNameSecretIdBoundCidrs (string roleName)

Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNameSecretIdBoundCidrsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
                apiInstance.DeleteAuthApproleRoleRoleNameSecretIdBoundCidrs(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthApproleRoleRoleNameSecretIdBoundCidrs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

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

<a name="deleteauthapprolerolerolenamesecretiddestroy"></a>
# **DeleteAuthApproleRoleRoleNameSecretIdDestroy**
> void DeleteAuthApproleRoleRoleNameSecretIdDestroy (string roleName)

Invalidate an issued secret_id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNameSecretIdDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Invalidate an issued secret_id
                apiInstance.DeleteAuthApproleRoleRoleNameSecretIdDestroy(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthApproleRoleRoleNameSecretIdDestroy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

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

<a name="deleteauthapprolerolerolenamesecretidnumuses"></a>
# **DeleteAuthApproleRoleRoleNameSecretIdNumUses**
> void DeleteAuthApproleRoleRoleNameSecretIdNumUses (string roleName)

Use limit of the SecretID generated against the role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNameSecretIdNumUsesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Use limit of the SecretID generated against the role.
                apiInstance.DeleteAuthApproleRoleRoleNameSecretIdNumUses(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthApproleRoleRoleNameSecretIdNumUses: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

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

<a name="deleteauthapprolerolerolenamesecretidttl"></a>
# **DeleteAuthApproleRoleRoleNameSecretIdTtl**
> void DeleteAuthApproleRoleRoleNameSecretIdTtl (string roleName)

Duration in seconds, representing the lifetime of the SecretIDs that are generated against the role using 'role/<role_name>/secret-id' or 'role/<role_name>/custom-secret-id' endpoints.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNameSecretIdTtlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Duration in seconds, representing the lifetime of the SecretIDs that are generated against the role using 'role/<role_name>/secret-id' or 'role/<role_name>/custom-secret-id' endpoints.
                apiInstance.DeleteAuthApproleRoleRoleNameSecretIdTtl(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthApproleRoleRoleNameSecretIdTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

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

<a name="deleteauthapprolerolerolenametokenboundcidrs"></a>
# **DeleteAuthApproleRoleRoleNameTokenBoundCidrs**
> void DeleteAuthApproleRoleRoleNameTokenBoundCidrs (string roleName)

Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNameTokenBoundCidrsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token.
                apiInstance.DeleteAuthApproleRoleRoleNameTokenBoundCidrs(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthApproleRoleRoleNameTokenBoundCidrs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

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

<a name="deleteauthapprolerolerolenametokenmaxttl"></a>
# **DeleteAuthApproleRoleRoleNameTokenMaxTtl**
> void DeleteAuthApproleRoleRoleNameTokenMaxTtl (string roleName)

Duration in seconds, the maximum lifetime of the tokens issued by using the SecretIDs that were generated against this role, after which the tokens are not allowed to be renewed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNameTokenMaxTtlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Duration in seconds, the maximum lifetime of the tokens issued by using the SecretIDs that were generated against this role, after which the tokens are not allowed to be renewed.
                apiInstance.DeleteAuthApproleRoleRoleNameTokenMaxTtl(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthApproleRoleRoleNameTokenMaxTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

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

<a name="deleteauthapprolerolerolenametokennumuses"></a>
# **DeleteAuthApproleRoleRoleNameTokenNumUses**
> void DeleteAuthApproleRoleRoleNameTokenNumUses (string roleName)

Number of times issued tokens can be used

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNameTokenNumUsesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Number of times issued tokens can be used
                apiInstance.DeleteAuthApproleRoleRoleNameTokenNumUses(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthApproleRoleRoleNameTokenNumUses: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

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

<a name="deleteauthapprolerolerolenametokenttl"></a>
# **DeleteAuthApproleRoleRoleNameTokenTtl**
> void DeleteAuthApproleRoleRoleNameTokenTtl (string roleName)

Duration in seconds, the lifetime of the token issued by using the SecretID that is generated against this role, before which the token needs to be renewed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNameTokenTtlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Duration in seconds, the lifetime of the token issued by using the SecretID that is generated against this role, before which the token needs to be renewed.
                apiInstance.DeleteAuthApproleRoleRoleNameTokenTtl(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthApproleRoleRoleNameTokenTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

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

<a name="deleteauthawsconfigcertificatecertname"></a>
# **DeleteAuthAwsConfigCertificateCertName**
> void DeleteAuthAwsConfigCertificateCertName (string certName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthAwsConfigCertificateCertNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var certName = "certName_example";  // string | Name of the certificate.

            try
            {
                apiInstance.DeleteAuthAwsConfigCertificateCertName(certName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthAwsConfigCertificateCertName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

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

<a name="deleteauthawsconfigclient"></a>
# **DeleteAuthAwsConfigClient**
> void DeleteAuthAwsConfigClient ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthAwsConfigClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                apiInstance.DeleteAuthAwsConfigClient();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthAwsConfigClient: " + e.Message );
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
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthawsconfigstsaccountid"></a>
# **DeleteAuthAwsConfigStsAccountId**
> void DeleteAuthAwsConfigStsAccountId (string accountId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthAwsConfigStsAccountIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var accountId = "accountId_example";  // string | AWS account ID to be associated with STS role. If set, Vault will use assumed credentials to verify any login attempts from EC2 instances in this account.

            try
            {
                apiInstance.DeleteAuthAwsConfigStsAccountId(accountId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthAwsConfigStsAccountId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

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

<a name="deleteauthawsconfigtidyidentityaccesslist"></a>
# **DeleteAuthAwsConfigTidyIdentityAccesslist**
> void DeleteAuthAwsConfigTidyIdentityAccesslist ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthAwsConfigTidyIdentityAccesslistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                apiInstance.DeleteAuthAwsConfigTidyIdentityAccesslist();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthAwsConfigTidyIdentityAccesslist: " + e.Message );
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
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthawsconfigtidyidentitywhitelist"></a>
# **DeleteAuthAwsConfigTidyIdentityWhitelist**
> void DeleteAuthAwsConfigTidyIdentityWhitelist ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthAwsConfigTidyIdentityWhitelistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                apiInstance.DeleteAuthAwsConfigTidyIdentityWhitelist();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthAwsConfigTidyIdentityWhitelist: " + e.Message );
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
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthawsconfigtidyroletagblacklist"></a>
# **DeleteAuthAwsConfigTidyRoletagBlacklist**
> void DeleteAuthAwsConfigTidyRoletagBlacklist ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthAwsConfigTidyRoletagBlacklistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                apiInstance.DeleteAuthAwsConfigTidyRoletagBlacklist();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthAwsConfigTidyRoletagBlacklist: " + e.Message );
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
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthawsconfigtidyroletagdenylist"></a>
# **DeleteAuthAwsConfigTidyRoletagDenylist**
> void DeleteAuthAwsConfigTidyRoletagDenylist ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthAwsConfigTidyRoletagDenylistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                apiInstance.DeleteAuthAwsConfigTidyRoletagDenylist();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthAwsConfigTidyRoletagDenylist: " + e.Message );
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
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthawsidentityaccesslistinstanceid"></a>
# **DeleteAuthAwsIdentityAccesslistInstanceId**
> void DeleteAuthAwsIdentityAccesslistInstanceId (string instanceId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthAwsIdentityAccesslistInstanceIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var instanceId = "instanceId_example";  // string | EC2 instance ID. A successful login operation from an EC2 instance gets cached in this accesslist, keyed off of instance ID.

            try
            {
                apiInstance.DeleteAuthAwsIdentityAccesslistInstanceId(instanceId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthAwsIdentityAccesslistInstanceId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

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

<a name="deleteauthawsidentitywhitelistinstanceid"></a>
# **DeleteAuthAwsIdentityWhitelistInstanceId**
> void DeleteAuthAwsIdentityWhitelistInstanceId (string instanceId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthAwsIdentityWhitelistInstanceIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var instanceId = "instanceId_example";  // string | EC2 instance ID. A successful login operation from an EC2 instance gets cached in this accesslist, keyed off of instance ID.

            try
            {
                apiInstance.DeleteAuthAwsIdentityWhitelistInstanceId(instanceId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthAwsIdentityWhitelistInstanceId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

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

<a name="deleteauthawsrolerole"></a>
# **DeleteAuthAwsRoleRole**
> void DeleteAuthAwsRoleRole (string role)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthAwsRoleRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var role = "role_example";  // string | Name of the role.

            try
            {
                apiInstance.DeleteAuthAwsRoleRole(role);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthAwsRoleRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

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

<a name="deleteauthawsroletagblacklistroletag"></a>
# **DeleteAuthAwsRoletagBlacklistRoleTag**
> void DeleteAuthAwsRoletagBlacklistRoleTag (string roleTag)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthAwsRoletagBlacklistRoleTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleTag = "roleTag_example";  // string | Role tag to be deny listed. The tag can be supplied as-is. In order to avoid any encoding problems, it can be base64 encoded.

            try
            {
                apiInstance.DeleteAuthAwsRoletagBlacklistRoleTag(roleTag);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthAwsRoletagBlacklistRoleTag: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

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

<a name="deleteauthawsroletagdenylistroletag"></a>
# **DeleteAuthAwsRoletagDenylistRoleTag**
> void DeleteAuthAwsRoletagDenylistRoleTag (string roleTag)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthAwsRoletagDenylistRoleTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleTag = "roleTag_example";  // string | Role tag to be deny listed. The tag can be supplied as-is. In order to avoid any encoding problems, it can be base64 encoded.

            try
            {
                apiInstance.DeleteAuthAwsRoletagDenylistRoleTag(roleTag);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthAwsRoletagDenylistRoleTag: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

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

<a name="deleteauthazureconfig"></a>
# **DeleteAuthAzureConfig**
> void DeleteAuthAzureConfig ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthAzureConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                apiInstance.DeleteAuthAzureConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthAzureConfig: " + e.Message );
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
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthazurerolename"></a>
# **DeleteAuthAzureRoleName**
> void DeleteAuthAzureRoleName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthAzureRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the role.

            try
            {
                apiInstance.DeleteAuthAzureRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthAzureRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

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

<a name="deleteauthcertcertsname"></a>
# **DeleteAuthCertCertsName**
> void DeleteAuthCertCertsName (string name)

Manage trusted certificates used for authentication.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthCertCertsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | The name of the certificate

            try
            {
                // Manage trusted certificates used for authentication.
                apiInstance.DeleteAuthCertCertsName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthCertCertsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

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

<a name="deleteauthcertcrlsname"></a>
# **DeleteAuthCertCrlsName**
> void DeleteAuthCertCrlsName (string name)

Manage Certificate Revocation Lists checked during authentication.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthCertCrlsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | The name of the certificate

            try
            {
                // Manage Certificate Revocation Lists checked during authentication.
                apiInstance.DeleteAuthCertCrlsName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthCertCrlsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

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

<a name="deleteauthcfconfig"></a>
# **DeleteAuthCfConfig**
> void DeleteAuthCfConfig ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthCfConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                apiInstance.DeleteAuthCfConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthCfConfig: " + e.Message );
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
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthcfrolesrole"></a>
# **DeleteAuthCfRolesRole**
> void DeleteAuthCfRolesRole (string role)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthCfRolesRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var role = "role_example";  // string | The name of the role.

            try
            {
                apiInstance.DeleteAuthCfRolesRole(role);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthCfRolesRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

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

<a name="deleteauthgcprolename"></a>
# **DeleteAuthGcpRoleName**
> void DeleteAuthGcpRoleName (string name)

Create a GCP role with associated policies and required attributes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthGcpRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the role.

            try
            {
                // Create a GCP role with associated policies and required attributes.
                apiInstance.DeleteAuthGcpRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthGcpRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

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

<a name="deleteauthgithubmapteamskey"></a>
# **DeleteAuthGithubMapTeamsKey**
> void DeleteAuthGithubMapTeamsKey (string key)

Read/write/delete a single teams mapping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthGithubMapTeamsKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var key = "key_example";  // string | Key for the teams mapping

            try
            {
                // Read/write/delete a single teams mapping
                apiInstance.DeleteAuthGithubMapTeamsKey(key);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthGithubMapTeamsKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

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

<a name="deleteauthgithubmapuserskey"></a>
# **DeleteAuthGithubMapUsersKey**
> void DeleteAuthGithubMapUsersKey (string key)

Read/write/delete a single users mapping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthGithubMapUsersKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var key = "key_example";  // string | Key for the users mapping

            try
            {
                // Read/write/delete a single users mapping
                apiInstance.DeleteAuthGithubMapUsersKey(key);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthGithubMapUsersKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

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

<a name="deleteauthjwtrolename"></a>
# **DeleteAuthJwtRoleName**
> void DeleteAuthJwtRoleName (string name)

Delete an existing role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthJwtRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the role.

            try
            {
                // Delete an existing role.
                apiInstance.DeleteAuthJwtRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthJwtRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

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

<a name="deleteauthkerberosgroupsname"></a>
# **DeleteAuthKerberosGroupsName**
> void DeleteAuthKerberosGroupsName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthKerberosGroupsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the LDAP group.

            try
            {
                apiInstance.DeleteAuthKerberosGroupsName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthKerberosGroupsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

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

<a name="deleteauthkubernetesrolename"></a>
# **DeleteAuthKubernetesRoleName**
> void DeleteAuthKubernetesRoleName (string name)

Register an role with the backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthKubernetesRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the role.

            try
            {
                // Register an role with the backend.
                apiInstance.DeleteAuthKubernetesRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthKubernetesRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

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

<a name="deleteauthldapgroupsname"></a>
# **DeleteAuthLdapGroupsName**
> void DeleteAuthLdapGroupsName (string name)

Manage additional groups for users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthLdapGroupsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the LDAP group.

            try
            {
                // Manage additional groups for users allowed to authenticate.
                apiInstance.DeleteAuthLdapGroupsName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthLdapGroupsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

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

<a name="deleteauthldapusersname"></a>
# **DeleteAuthLdapUsersName**
> void DeleteAuthLdapUsersName (string name)

Manage users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthLdapUsersNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the LDAP user.

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.DeleteAuthLdapUsersName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthLdapUsersName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the LDAP user. | 

### Return type

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

<a name="deleteauthociconfig"></a>
# **DeleteAuthOciConfig**
> void DeleteAuthOciConfig ()

Manages the configuration for the Vault Auth Plugin.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthOciConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                // Manages the configuration for the Vault Auth Plugin.
                apiInstance.DeleteAuthOciConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthOciConfig: " + e.Message );
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
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthocirolerole"></a>
# **DeleteAuthOciRoleRole**
> void DeleteAuthOciRoleRole (string role)

Create a role and associate policies to it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthOciRoleRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var role = "role_example";  // string | Name of the role.

            try
            {
                // Create a role and associate policies to it.
                apiInstance.DeleteAuthOciRoleRole(role);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthOciRoleRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

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

<a name="deleteauthoidcrolename"></a>
# **DeleteAuthOidcRoleName**
> void DeleteAuthOidcRoleName (string name)

Delete an existing role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthOidcRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the role.

            try
            {
                // Delete an existing role.
                apiInstance.DeleteAuthOidcRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthOidcRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

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

<a name="deleteauthoktagroupsname"></a>
# **DeleteAuthOktaGroupsName**
> void DeleteAuthOktaGroupsName (string name)

Manage users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthOktaGroupsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the Okta group.

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.DeleteAuthOktaGroupsName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthOktaGroupsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the Okta group. | 

### Return type

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

<a name="deleteauthoktausersname"></a>
# **DeleteAuthOktaUsersName**
> void DeleteAuthOktaUsersName (string name)

Manage additional groups for users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthOktaUsersNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the user.

            try
            {
                // Manage additional groups for users allowed to authenticate.
                apiInstance.DeleteAuthOktaUsersName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthOktaUsersName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

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

<a name="deleteauthradiususersname"></a>
# **DeleteAuthRadiusUsersName**
> void DeleteAuthRadiusUsersName (string name)

Manage users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthRadiusUsersNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the RADIUS user.

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.DeleteAuthRadiusUsersName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthRadiusUsersName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

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

<a name="deleteauthtokenrolesrolename"></a>
# **DeleteAuthTokenRolesRoleName**
> void DeleteAuthTokenRolesRoleName (string roleName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthTokenRolesRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role

            try
            {
                apiInstance.DeleteAuthTokenRolesRoleName(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthTokenRolesRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

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

<a name="deleteauthuserpassusersusername"></a>
# **DeleteAuthUserpassUsersUsername**
> void DeleteAuthUserpassUsersUsername (string username)

Manage users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAuthUserpassUsersUsernameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var username = "username_example";  // string | Username for this user.

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.DeleteAuthUserpassUsersUsername(username);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAuthUserpassUsersUsername: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

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

<a name="getauthalicloudrole"></a>
# **GetAuthAlicloudRole**
> void GetAuthAlicloudRole (string list)

Lists all the roles that are registered with Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAlicloudRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                // Lists all the roles that are registered with Vault.
                apiInstance.GetAuthAlicloudRole(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAlicloudRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthalicloudrolerole"></a>
# **GetAuthAlicloudRoleRole**
> void GetAuthAlicloudRoleRole (string role)

Create a role and associate policies to it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAlicloudRoleRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var role = "role_example";  // string | The name of the role as it should appear in Vault.

            try
            {
                // Create a role and associate policies to it.
                apiInstance.GetAuthAlicloudRoleRole(role);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAlicloudRoleRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The name of the role as it should appear in Vault. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthalicloudroles"></a>
# **GetAuthAlicloudRoles**
> void GetAuthAlicloudRoles (string list)

Lists all the roles that are registered with Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAlicloudRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                // Lists all the roles that are registered with Vault.
                apiInstance.GetAuthAlicloudRoles(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAlicloudRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthappidmapappid"></a>
# **GetAuthAppIdMapAppId**
> void GetAuthAppIdMapAppId (string list = null)

Read mappings for app-id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAppIdMapAppIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "list_example";  // string | Return a list if `true` (optional) 

            try
            {
                // Read mappings for app-id
                apiInstance.GetAuthAppIdMapAppId(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAppIdMapAppId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="getauthappidmapappidkey"></a>
# **GetAuthAppIdMapAppIdKey**
> void GetAuthAppIdMapAppIdKey (string key)

Read/write/delete a single app-id mapping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAppIdMapAppIdKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var key = "key_example";  // string | Key for the app-id mapping

            try
            {
                // Read/write/delete a single app-id mapping
                apiInstance.GetAuthAppIdMapAppIdKey(key);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAppIdMapAppIdKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Key for the app-id mapping | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthappidmapuserid"></a>
# **GetAuthAppIdMapUserId**
> void GetAuthAppIdMapUserId (string list = null)

Read mappings for user-id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAppIdMapUserIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "list_example";  // string | Return a list if `true` (optional) 

            try
            {
                // Read mappings for user-id
                apiInstance.GetAuthAppIdMapUserId(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAppIdMapUserId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="getauthappidmapuseridkey"></a>
# **GetAuthAppIdMapUserIdKey**
> void GetAuthAppIdMapUserIdKey (string key)

Read/write/delete a single user-id mapping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAppIdMapUserIdKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var key = "key_example";  // string | Key for the user-id mapping

            try
            {
                // Read/write/delete a single user-id mapping
                apiInstance.GetAuthAppIdMapUserIdKey(key);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAppIdMapUserIdKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Key for the user-id mapping | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthapprolerole"></a>
# **GetAuthApproleRole**
> void GetAuthApproleRole (string list)

Lists all the roles registered with the backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthApproleRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                // Lists all the roles registered with the backend.
                apiInstance.GetAuthApproleRole(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthApproleRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthapprolerolerolename"></a>
# **GetAuthApproleRoleRoleName**
> void GetAuthApproleRoleRoleName (string roleName)

Register an role with the backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Register an role with the backend.
                apiInstance.GetAuthApproleRoleRoleName(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthApproleRoleRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthapprolerolerolenamebindsecretid"></a>
# **GetAuthApproleRoleRoleNameBindSecretId**
> void GetAuthApproleRoleRoleNameBindSecretId (string roleName)

Impose secret_id to be presented during login using this role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameBindSecretIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Impose secret_id to be presented during login using this role.
                apiInstance.GetAuthApproleRoleRoleNameBindSecretId(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthApproleRoleRoleNameBindSecretId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthapprolerolerolenameboundcidrlist"></a>
# **GetAuthApproleRoleRoleNameBoundCidrList**
> void GetAuthApproleRoleRoleNameBoundCidrList (string roleName)

Deprecated: Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameBoundCidrListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Deprecated: Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
                apiInstance.GetAuthApproleRoleRoleNameBoundCidrList(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthApproleRoleRoleNameBoundCidrList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthapprolerolerolenamelocalsecretids"></a>
# **GetAuthApproleRoleRoleNameLocalSecretIds**
> void GetAuthApproleRoleRoleNameLocalSecretIds (string roleName)

Enables cluster local secret IDs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameLocalSecretIdsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Enables cluster local secret IDs
                apiInstance.GetAuthApproleRoleRoleNameLocalSecretIds(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthApproleRoleRoleNameLocalSecretIds: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthapprolerolerolenameperiod"></a>
# **GetAuthApproleRoleRoleNamePeriod**
> void GetAuthApproleRoleRoleNamePeriod (string roleName)

Updates the value of 'period' on the role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNamePeriodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Updates the value of 'period' on the role
                apiInstance.GetAuthApproleRoleRoleNamePeriod(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthApproleRoleRoleNamePeriod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthapprolerolerolenamepolicies"></a>
# **GetAuthApproleRoleRoleNamePolicies**
> void GetAuthApproleRoleRoleNamePolicies (string roleName)

Policies of the role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNamePoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Policies of the role.
                apiInstance.GetAuthApproleRoleRoleNamePolicies(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthApproleRoleRoleNamePolicies: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthapprolerolerolenameroleid"></a>
# **GetAuthApproleRoleRoleNameRoleId**
> void GetAuthApproleRoleRoleNameRoleId (string roleName)

Returns the 'role_id' of the role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameRoleIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Returns the 'role_id' of the role.
                apiInstance.GetAuthApproleRoleRoleNameRoleId(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthApproleRoleRoleNameRoleId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthapprolerolerolenamesecretid"></a>
# **GetAuthApproleRoleRoleNameSecretId**
> void GetAuthApproleRoleRoleNameSecretId (string roleName, string list)

Generate a SecretID against this role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameSecretIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.
            var list = "true";  // string | Must be set to `true`

            try
            {
                // Generate a SecretID against this role.
                apiInstance.GetAuthApproleRoleRoleNameSecretId(roleName, list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthApproleRoleRoleNameSecretId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 
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

<a name="getauthapprolerolerolenamesecretidboundcidrs"></a>
# **GetAuthApproleRoleRoleNameSecretIdBoundCidrs**
> void GetAuthApproleRoleRoleNameSecretIdBoundCidrs (string roleName)

Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameSecretIdBoundCidrsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
                apiInstance.GetAuthApproleRoleRoleNameSecretIdBoundCidrs(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthApproleRoleRoleNameSecretIdBoundCidrs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthapprolerolerolenamesecretidnumuses"></a>
# **GetAuthApproleRoleRoleNameSecretIdNumUses**
> void GetAuthApproleRoleRoleNameSecretIdNumUses (string roleName)

Use limit of the SecretID generated against the role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameSecretIdNumUsesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Use limit of the SecretID generated against the role.
                apiInstance.GetAuthApproleRoleRoleNameSecretIdNumUses(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthApproleRoleRoleNameSecretIdNumUses: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthapprolerolerolenamesecretidttl"></a>
# **GetAuthApproleRoleRoleNameSecretIdTtl**
> void GetAuthApproleRoleRoleNameSecretIdTtl (string roleName)

Duration in seconds, representing the lifetime of the SecretIDs that are generated against the role using 'role/<role_name>/secret-id' or 'role/<role_name>/custom-secret-id' endpoints.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameSecretIdTtlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Duration in seconds, representing the lifetime of the SecretIDs that are generated against the role using 'role/<role_name>/secret-id' or 'role/<role_name>/custom-secret-id' endpoints.
                apiInstance.GetAuthApproleRoleRoleNameSecretIdTtl(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthApproleRoleRoleNameSecretIdTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthapprolerolerolenametokenboundcidrs"></a>
# **GetAuthApproleRoleRoleNameTokenBoundCidrs**
> void GetAuthApproleRoleRoleNameTokenBoundCidrs (string roleName)

Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameTokenBoundCidrsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token.
                apiInstance.GetAuthApproleRoleRoleNameTokenBoundCidrs(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthApproleRoleRoleNameTokenBoundCidrs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthapprolerolerolenametokenmaxttl"></a>
# **GetAuthApproleRoleRoleNameTokenMaxTtl**
> void GetAuthApproleRoleRoleNameTokenMaxTtl (string roleName)

Duration in seconds, the maximum lifetime of the tokens issued by using the SecretIDs that were generated against this role, after which the tokens are not allowed to be renewed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameTokenMaxTtlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Duration in seconds, the maximum lifetime of the tokens issued by using the SecretIDs that were generated against this role, after which the tokens are not allowed to be renewed.
                apiInstance.GetAuthApproleRoleRoleNameTokenMaxTtl(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthApproleRoleRoleNameTokenMaxTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthapprolerolerolenametokennumuses"></a>
# **GetAuthApproleRoleRoleNameTokenNumUses**
> void GetAuthApproleRoleRoleNameTokenNumUses (string roleName)

Number of times issued tokens can be used

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameTokenNumUsesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Number of times issued tokens can be used
                apiInstance.GetAuthApproleRoleRoleNameTokenNumUses(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthApproleRoleRoleNameTokenNumUses: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthapprolerolerolenametokenttl"></a>
# **GetAuthApproleRoleRoleNameTokenTtl**
> void GetAuthApproleRoleRoleNameTokenTtl (string roleName)

Duration in seconds, the lifetime of the token issued by using the SecretID that is generated against this role, before which the token needs to be renewed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameTokenTtlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.

            try
            {
                // Duration in seconds, the lifetime of the token issued by using the SecretID that is generated against this role, before which the token needs to be renewed.
                apiInstance.GetAuthApproleRoleRoleNameTokenTtl(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthApproleRoleRoleNameTokenTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthawsconfigcertificatecertname"></a>
# **GetAuthAwsConfigCertificateCertName**
> void GetAuthAwsConfigCertificateCertName (string certName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAwsConfigCertificateCertNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var certName = "certName_example";  // string | Name of the certificate.

            try
            {
                apiInstance.GetAuthAwsConfigCertificateCertName(certName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAwsConfigCertificateCertName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthawsconfigcertificates"></a>
# **GetAuthAwsConfigCertificates**
> void GetAuthAwsConfigCertificates (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAwsConfigCertificatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                apiInstance.GetAuthAwsConfigCertificates(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAwsConfigCertificates: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthawsconfigclient"></a>
# **GetAuthAwsConfigClient**
> void GetAuthAwsConfigClient ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAwsConfigClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                apiInstance.GetAuthAwsConfigClient();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAwsConfigClient: " + e.Message );
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

<a name="getauthawsconfigidentity"></a>
# **GetAuthAwsConfigIdentity**
> void GetAuthAwsConfigIdentity ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAwsConfigIdentityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                apiInstance.GetAuthAwsConfigIdentity();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAwsConfigIdentity: " + e.Message );
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

<a name="getauthawsconfigsts"></a>
# **GetAuthAwsConfigSts**
> void GetAuthAwsConfigSts (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAwsConfigStsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                apiInstance.GetAuthAwsConfigSts(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAwsConfigSts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthawsconfigstsaccountid"></a>
# **GetAuthAwsConfigStsAccountId**
> void GetAuthAwsConfigStsAccountId (string accountId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAwsConfigStsAccountIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var accountId = "accountId_example";  // string | AWS account ID to be associated with STS role. If set, Vault will use assumed credentials to verify any login attempts from EC2 instances in this account.

            try
            {
                apiInstance.GetAuthAwsConfigStsAccountId(accountId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAwsConfigStsAccountId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthawsconfigtidyidentityaccesslist"></a>
# **GetAuthAwsConfigTidyIdentityAccesslist**
> void GetAuthAwsConfigTidyIdentityAccesslist ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAwsConfigTidyIdentityAccesslistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                apiInstance.GetAuthAwsConfigTidyIdentityAccesslist();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAwsConfigTidyIdentityAccesslist: " + e.Message );
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

<a name="getauthawsconfigtidyidentitywhitelist"></a>
# **GetAuthAwsConfigTidyIdentityWhitelist**
> void GetAuthAwsConfigTidyIdentityWhitelist ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAwsConfigTidyIdentityWhitelistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                apiInstance.GetAuthAwsConfigTidyIdentityWhitelist();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAwsConfigTidyIdentityWhitelist: " + e.Message );
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

<a name="getauthawsconfigtidyroletagblacklist"></a>
# **GetAuthAwsConfigTidyRoletagBlacklist**
> void GetAuthAwsConfigTidyRoletagBlacklist ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAwsConfigTidyRoletagBlacklistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                apiInstance.GetAuthAwsConfigTidyRoletagBlacklist();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAwsConfigTidyRoletagBlacklist: " + e.Message );
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

<a name="getauthawsconfigtidyroletagdenylist"></a>
# **GetAuthAwsConfigTidyRoletagDenylist**
> void GetAuthAwsConfigTidyRoletagDenylist ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAwsConfigTidyRoletagDenylistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                apiInstance.GetAuthAwsConfigTidyRoletagDenylist();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAwsConfigTidyRoletagDenylist: " + e.Message );
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

<a name="getauthawsidentityaccesslist"></a>
# **GetAuthAwsIdentityAccesslist**
> void GetAuthAwsIdentityAccesslist (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAwsIdentityAccesslistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                apiInstance.GetAuthAwsIdentityAccesslist(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAwsIdentityAccesslist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthawsidentityaccesslistinstanceid"></a>
# **GetAuthAwsIdentityAccesslistInstanceId**
> void GetAuthAwsIdentityAccesslistInstanceId (string instanceId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAwsIdentityAccesslistInstanceIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var instanceId = "instanceId_example";  // string | EC2 instance ID. A successful login operation from an EC2 instance gets cached in this accesslist, keyed off of instance ID.

            try
            {
                apiInstance.GetAuthAwsIdentityAccesslistInstanceId(instanceId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAwsIdentityAccesslistInstanceId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthawsidentitywhitelist"></a>
# **GetAuthAwsIdentityWhitelist**
> void GetAuthAwsIdentityWhitelist (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAwsIdentityWhitelistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                apiInstance.GetAuthAwsIdentityWhitelist(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAwsIdentityWhitelist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthawsidentitywhitelistinstanceid"></a>
# **GetAuthAwsIdentityWhitelistInstanceId**
> void GetAuthAwsIdentityWhitelistInstanceId (string instanceId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAwsIdentityWhitelistInstanceIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var instanceId = "instanceId_example";  // string | EC2 instance ID. A successful login operation from an EC2 instance gets cached in this accesslist, keyed off of instance ID.

            try
            {
                apiInstance.GetAuthAwsIdentityWhitelistInstanceId(instanceId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAwsIdentityWhitelistInstanceId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthawsrole"></a>
# **GetAuthAwsRole**
> void GetAuthAwsRole (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAwsRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                apiInstance.GetAuthAwsRole(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAwsRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthawsrolerole"></a>
# **GetAuthAwsRoleRole**
> void GetAuthAwsRoleRole (string role)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAwsRoleRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var role = "role_example";  // string | Name of the role.

            try
            {
                apiInstance.GetAuthAwsRoleRole(role);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAwsRoleRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthawsroles"></a>
# **GetAuthAwsRoles**
> void GetAuthAwsRoles (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAwsRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                apiInstance.GetAuthAwsRoles(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAwsRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthawsroletagblacklist"></a>
# **GetAuthAwsRoletagBlacklist**
> void GetAuthAwsRoletagBlacklist (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAwsRoletagBlacklistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                apiInstance.GetAuthAwsRoletagBlacklist(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAwsRoletagBlacklist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthawsroletagblacklistroletag"></a>
# **GetAuthAwsRoletagBlacklistRoleTag**
> void GetAuthAwsRoletagBlacklistRoleTag (string roleTag)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAwsRoletagBlacklistRoleTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleTag = "roleTag_example";  // string | Role tag to be deny listed. The tag can be supplied as-is. In order to avoid any encoding problems, it can be base64 encoded.

            try
            {
                apiInstance.GetAuthAwsRoletagBlacklistRoleTag(roleTag);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAwsRoletagBlacklistRoleTag: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthawsroletagdenylist"></a>
# **GetAuthAwsRoletagDenylist**
> void GetAuthAwsRoletagDenylist (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAwsRoletagDenylistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                apiInstance.GetAuthAwsRoletagDenylist(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAwsRoletagDenylist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthawsroletagdenylistroletag"></a>
# **GetAuthAwsRoletagDenylistRoleTag**
> void GetAuthAwsRoletagDenylistRoleTag (string roleTag)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAwsRoletagDenylistRoleTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleTag = "roleTag_example";  // string | Role tag to be deny listed. The tag can be supplied as-is. In order to avoid any encoding problems, it can be base64 encoded.

            try
            {
                apiInstance.GetAuthAwsRoletagDenylistRoleTag(roleTag);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAwsRoletagDenylistRoleTag: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthazureconfig"></a>
# **GetAuthAzureConfig**
> void GetAuthAzureConfig ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAzureConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                apiInstance.GetAuthAzureConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAzureConfig: " + e.Message );
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

<a name="getauthazurerole"></a>
# **GetAuthAzureRole**
> void GetAuthAzureRole (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAzureRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                apiInstance.GetAuthAzureRole(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAzureRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthazurerolename"></a>
# **GetAuthAzureRoleName**
> void GetAuthAzureRoleName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthAzureRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the role.

            try
            {
                apiInstance.GetAuthAzureRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthAzureRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthcentrifyconfig"></a>
# **GetAuthCentrifyConfig**
> void GetAuthCentrifyConfig ()

This path allows you to configure the centrify auth provider to interact with the Centrify Identity Services Platform for authenticating users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthCentrifyConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                // This path allows you to configure the centrify auth provider to interact with the Centrify Identity Services Platform for authenticating users.
                apiInstance.GetAuthCentrifyConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthCentrifyConfig: " + e.Message );
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

<a name="getauthcertcerts"></a>
# **GetAuthCertCerts**
> void GetAuthCertCerts (string list)

Manage trusted certificates used for authentication.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthCertCertsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                // Manage trusted certificates used for authentication.
                apiInstance.GetAuthCertCerts(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthCertCerts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthcertcertsname"></a>
# **GetAuthCertCertsName**
> void GetAuthCertCertsName (string name)

Manage trusted certificates used for authentication.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthCertCertsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | The name of the certificate

            try
            {
                // Manage trusted certificates used for authentication.
                apiInstance.GetAuthCertCertsName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthCertCertsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthcertcrlsname"></a>
# **GetAuthCertCrlsName**
> void GetAuthCertCrlsName (string name)

Manage Certificate Revocation Lists checked during authentication.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthCertCrlsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | The name of the certificate

            try
            {
                // Manage Certificate Revocation Lists checked during authentication.
                apiInstance.GetAuthCertCrlsName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthCertCrlsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthcfconfig"></a>
# **GetAuthCfConfig**
> void GetAuthCfConfig ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthCfConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                apiInstance.GetAuthCfConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthCfConfig: " + e.Message );
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

<a name="getauthcfroles"></a>
# **GetAuthCfRoles**
> void GetAuthCfRoles (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthCfRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                apiInstance.GetAuthCfRoles(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthCfRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthcfrolesrole"></a>
# **GetAuthCfRolesRole**
> void GetAuthCfRolesRole (string role)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthCfRolesRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var role = "role_example";  // string | The name of the role.

            try
            {
                apiInstance.GetAuthCfRolesRole(role);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthCfRolesRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthgcpconfig"></a>
# **GetAuthGcpConfig**
> void GetAuthGcpConfig ()

Configure credentials used to query the GCP IAM API to verify authenticating service accounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthGcpConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                // Configure credentials used to query the GCP IAM API to verify authenticating service accounts
                apiInstance.GetAuthGcpConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthGcpConfig: " + e.Message );
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

<a name="getauthgcprole"></a>
# **GetAuthGcpRole**
> void GetAuthGcpRole (string list)

Lists all the roles that are registered with Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthGcpRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                // Lists all the roles that are registered with Vault.
                apiInstance.GetAuthGcpRole(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthGcpRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthgcprolename"></a>
# **GetAuthGcpRoleName**
> void GetAuthGcpRoleName (string name)

Create a GCP role with associated policies and required attributes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthGcpRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the role.

            try
            {
                // Create a GCP role with associated policies and required attributes.
                apiInstance.GetAuthGcpRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthGcpRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthgcproles"></a>
# **GetAuthGcpRoles**
> void GetAuthGcpRoles (string list)

Lists all the roles that are registered with Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthGcpRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                // Lists all the roles that are registered with Vault.
                apiInstance.GetAuthGcpRoles(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthGcpRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthgithubconfig"></a>
# **GetAuthGithubConfig**
> void GetAuthGithubConfig ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthGithubConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                apiInstance.GetAuthGithubConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthGithubConfig: " + e.Message );
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

<a name="getauthgithubmapteams"></a>
# **GetAuthGithubMapTeams**
> void GetAuthGithubMapTeams (string list = null)

Read mappings for teams

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthGithubMapTeamsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "list_example";  // string | Return a list if `true` (optional) 

            try
            {
                // Read mappings for teams
                apiInstance.GetAuthGithubMapTeams(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthGithubMapTeams: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="getauthgithubmapteamskey"></a>
# **GetAuthGithubMapTeamsKey**
> void GetAuthGithubMapTeamsKey (string key)

Read/write/delete a single teams mapping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthGithubMapTeamsKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var key = "key_example";  // string | Key for the teams mapping

            try
            {
                // Read/write/delete a single teams mapping
                apiInstance.GetAuthGithubMapTeamsKey(key);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthGithubMapTeamsKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthgithubmapusers"></a>
# **GetAuthGithubMapUsers**
> void GetAuthGithubMapUsers (string list = null)

Read mappings for users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthGithubMapUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "list_example";  // string | Return a list if `true` (optional) 

            try
            {
                // Read mappings for users
                apiInstance.GetAuthGithubMapUsers(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthGithubMapUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="getauthgithubmapuserskey"></a>
# **GetAuthGithubMapUsersKey**
> void GetAuthGithubMapUsersKey (string key)

Read/write/delete a single users mapping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthGithubMapUsersKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var key = "key_example";  // string | Key for the users mapping

            try
            {
                // Read/write/delete a single users mapping
                apiInstance.GetAuthGithubMapUsersKey(key);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthGithubMapUsersKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthjwtconfig"></a>
# **GetAuthJwtConfig**
> void GetAuthJwtConfig ()

Read the current JWT authentication backend configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthJwtConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                // Read the current JWT authentication backend configuration.
                apiInstance.GetAuthJwtConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthJwtConfig: " + e.Message );
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

<a name="getauthjwtoidccallback"></a>
# **GetAuthJwtOidcCallback**
> void GetAuthJwtOidcCallback ()

Callback endpoint to complete an OIDC login.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthJwtOidcCallbackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                // Callback endpoint to complete an OIDC login.
                apiInstance.GetAuthJwtOidcCallback();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthJwtOidcCallback: " + e.Message );
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

<a name="getauthjwtrole"></a>
# **GetAuthJwtRole**
> void GetAuthJwtRole (string list)

Lists all the roles registered with the backend.

The list will contain the names of the roles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthJwtRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                // Lists all the roles registered with the backend.
                apiInstance.GetAuthJwtRole(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthJwtRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthjwtrolename"></a>
# **GetAuthJwtRoleName**
> void GetAuthJwtRoleName (string name)

Read an existing role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthJwtRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the role.

            try
            {
                // Read an existing role.
                apiInstance.GetAuthJwtRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthJwtRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthkerberosconfig"></a>
# **GetAuthKerberosConfig**
> void GetAuthKerberosConfig ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthKerberosConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                apiInstance.GetAuthKerberosConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthKerberosConfig: " + e.Message );
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

<a name="getauthkerberosconfigldap"></a>
# **GetAuthKerberosConfigLdap**
> void GetAuthKerberosConfigLdap ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthKerberosConfigLdapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                apiInstance.GetAuthKerberosConfigLdap();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthKerberosConfigLdap: " + e.Message );
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

<a name="getauthkerberosgroups"></a>
# **GetAuthKerberosGroups**
> void GetAuthKerberosGroups (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthKerberosGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                apiInstance.GetAuthKerberosGroups(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthKerberosGroups: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthkerberosgroupsname"></a>
# **GetAuthKerberosGroupsName**
> void GetAuthKerberosGroupsName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthKerberosGroupsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the LDAP group.

            try
            {
                apiInstance.GetAuthKerberosGroupsName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthKerberosGroupsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthkerberoslogin"></a>
# **GetAuthKerberosLogin**
> void GetAuthKerberosLogin ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthKerberosLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                apiInstance.GetAuthKerberosLogin();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthKerberosLogin: " + e.Message );
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

<a name="getauthkubernetesconfig"></a>
# **GetAuthKubernetesConfig**
> void GetAuthKubernetesConfig ()

Configures the JWT Public Key and Kubernetes API information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthKubernetesConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                // Configures the JWT Public Key and Kubernetes API information.
                apiInstance.GetAuthKubernetesConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthKubernetesConfig: " + e.Message );
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

<a name="getauthkubernetesrole"></a>
# **GetAuthKubernetesRole**
> void GetAuthKubernetesRole (string list)

Lists all the roles registered with the backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthKubernetesRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                // Lists all the roles registered with the backend.
                apiInstance.GetAuthKubernetesRole(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthKubernetesRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthkubernetesrolename"></a>
# **GetAuthKubernetesRoleName**
> void GetAuthKubernetesRoleName (string name)

Register an role with the backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthKubernetesRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the role.

            try
            {
                // Register an role with the backend.
                apiInstance.GetAuthKubernetesRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthKubernetesRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthldapconfig"></a>
# **GetAuthLdapConfig**
> void GetAuthLdapConfig ()

Configure the LDAP server to connect to, along with its options.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthLdapConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                // Configure the LDAP server to connect to, along with its options.
                apiInstance.GetAuthLdapConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthLdapConfig: " + e.Message );
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

<a name="getauthldapgroups"></a>
# **GetAuthLdapGroups**
> void GetAuthLdapGroups (string list)

Manage additional groups for users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthLdapGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                // Manage additional groups for users allowed to authenticate.
                apiInstance.GetAuthLdapGroups(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthLdapGroups: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthldapgroupsname"></a>
# **GetAuthLdapGroupsName**
> void GetAuthLdapGroupsName (string name)

Manage additional groups for users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthLdapGroupsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the LDAP group.

            try
            {
                // Manage additional groups for users allowed to authenticate.
                apiInstance.GetAuthLdapGroupsName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthLdapGroupsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthldapusers"></a>
# **GetAuthLdapUsers**
> void GetAuthLdapUsers (string list)

Manage users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthLdapUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.GetAuthLdapUsers(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthLdapUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthldapusersname"></a>
# **GetAuthLdapUsersName**
> void GetAuthLdapUsersName (string name)

Manage users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthLdapUsersNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the LDAP user.

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.GetAuthLdapUsersName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthLdapUsersName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the LDAP user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthociconfig"></a>
# **GetAuthOciConfig**
> void GetAuthOciConfig ()

Manages the configuration for the Vault Auth Plugin.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthOciConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                // Manages the configuration for the Vault Auth Plugin.
                apiInstance.GetAuthOciConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthOciConfig: " + e.Message );
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

<a name="getauthocirole"></a>
# **GetAuthOciRole**
> void GetAuthOciRole (string list)

Lists all the roles that are registered with Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthOciRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                // Lists all the roles that are registered with Vault.
                apiInstance.GetAuthOciRole(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthOciRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthocirolerole"></a>
# **GetAuthOciRoleRole**
> void GetAuthOciRoleRole (string role)

Create a role and associate policies to it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthOciRoleRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var role = "role_example";  // string | Name of the role.

            try
            {
                // Create a role and associate policies to it.
                apiInstance.GetAuthOciRoleRole(role);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthOciRoleRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthoidcconfig"></a>
# **GetAuthOidcConfig**
> void GetAuthOidcConfig ()

Read the current JWT authentication backend configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthOidcConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                // Read the current JWT authentication backend configuration.
                apiInstance.GetAuthOidcConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthOidcConfig: " + e.Message );
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

<a name="getauthoidcoidccallback"></a>
# **GetAuthOidcOidcCallback**
> void GetAuthOidcOidcCallback ()

Callback endpoint to complete an OIDC login.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthOidcOidcCallbackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                // Callback endpoint to complete an OIDC login.
                apiInstance.GetAuthOidcOidcCallback();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthOidcOidcCallback: " + e.Message );
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

<a name="getauthoidcrole"></a>
# **GetAuthOidcRole**
> void GetAuthOidcRole (string list)

Lists all the roles registered with the backend.

The list will contain the names of the roles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthOidcRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                // Lists all the roles registered with the backend.
                apiInstance.GetAuthOidcRole(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthOidcRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthoidcrolename"></a>
# **GetAuthOidcRoleName**
> void GetAuthOidcRoleName (string name)

Read an existing role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthOidcRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the role.

            try
            {
                // Read an existing role.
                apiInstance.GetAuthOidcRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthOidcRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthoktaconfig"></a>
# **GetAuthOktaConfig**
> void GetAuthOktaConfig ()

This endpoint allows you to configure the Okta and its configuration options.  The Okta organization are the characters at the front of the URL for Okta. Example https://ORG.okta.com

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthOktaConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                // This endpoint allows you to configure the Okta and its configuration options.  The Okta organization are the characters at the front of the URL for Okta. Example https://ORG.okta.com
                apiInstance.GetAuthOktaConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthOktaConfig: " + e.Message );
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

<a name="getauthoktagroups"></a>
# **GetAuthOktaGroups**
> void GetAuthOktaGroups (string list)

Manage users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthOktaGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.GetAuthOktaGroups(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthOktaGroups: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthoktagroupsname"></a>
# **GetAuthOktaGroupsName**
> void GetAuthOktaGroupsName (string name)

Manage users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthOktaGroupsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the Okta group.

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.GetAuthOktaGroupsName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthOktaGroupsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the Okta group. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthoktausers"></a>
# **GetAuthOktaUsers**
> void GetAuthOktaUsers (string list)

Manage additional groups for users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthOktaUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                // Manage additional groups for users allowed to authenticate.
                apiInstance.GetAuthOktaUsers(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthOktaUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthoktausersname"></a>
# **GetAuthOktaUsersName**
> void GetAuthOktaUsersName (string name)

Manage additional groups for users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthOktaUsersNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the user.

            try
            {
                // Manage additional groups for users allowed to authenticate.
                apiInstance.GetAuthOktaUsersName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthOktaUsersName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthoktaverifynonce"></a>
# **GetAuthOktaVerifyNonce**
> void GetAuthOktaVerifyNonce (string nonce)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthOktaVerifyNonceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var nonce = "nonce_example";  // string | Nonce provided during a login request to retrieve the number verification challenge for the matching request.

            try
            {
                apiInstance.GetAuthOktaVerifyNonce(nonce);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthOktaVerifyNonce: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthradiusconfig"></a>
# **GetAuthRadiusConfig**
> void GetAuthRadiusConfig ()

Configure the RADIUS server to connect to, along with its options.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthRadiusConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                // Configure the RADIUS server to connect to, along with its options.
                apiInstance.GetAuthRadiusConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthRadiusConfig: " + e.Message );
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

<a name="getauthradiususers"></a>
# **GetAuthRadiusUsers**
> void GetAuthRadiusUsers (string list)

Manage users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthRadiusUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.GetAuthRadiusUsers(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthRadiusUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthradiususersname"></a>
# **GetAuthRadiusUsersName**
> void GetAuthRadiusUsersName (string name)

Manage users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthRadiusUsersNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the RADIUS user.

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.GetAuthRadiusUsersName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthRadiusUsersName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthtokenaccessors"></a>
# **GetAuthTokenAccessors**
> void GetAuthTokenAccessors (string list)

List token accessors, which can then be be used to iterate and discover their properties or revoke them. Because this can be used to cause a denial of service, this endpoint requires 'sudo' capability in addition to 'list'.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthTokenAccessorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                // List token accessors, which can then be be used to iterate and discover their properties or revoke them. Because this can be used to cause a denial of service, this endpoint requires 'sudo' capability in addition to 'list'.
                apiInstance.GetAuthTokenAccessors(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthTokenAccessors: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthtokenlookup"></a>
# **GetAuthTokenLookup**
> void GetAuthTokenLookup ()

This endpoint will lookup a token and its properties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthTokenLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                // This endpoint will lookup a token and its properties.
                apiInstance.GetAuthTokenLookup();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthTokenLookup: " + e.Message );
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

<a name="getauthtokenlookupself"></a>
# **GetAuthTokenLookupSelf**
> void GetAuthTokenLookupSelf ()

This endpoint will lookup a token and its properties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthTokenLookupSelfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                // This endpoint will lookup a token and its properties.
                apiInstance.GetAuthTokenLookupSelf();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthTokenLookupSelf: " + e.Message );
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

<a name="getauthtokenroles"></a>
# **GetAuthTokenRoles**
> void GetAuthTokenRoles (string list)

This endpoint lists configured roles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthTokenRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                // This endpoint lists configured roles.
                apiInstance.GetAuthTokenRoles(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthTokenRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthtokenrolesrolename"></a>
# **GetAuthTokenRolesRoleName**
> void GetAuthTokenRolesRoleName (string roleName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthTokenRolesRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role

            try
            {
                apiInstance.GetAuthTokenRolesRoleName(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthTokenRolesRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthuserpassusers"></a>
# **GetAuthUserpassUsers**
> void GetAuthUserpassUsers (string list)

Manage users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthUserpassUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var list = "true";  // string | Must be set to `true`

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.GetAuthUserpassUsers(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthUserpassUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getauthuserpassusersusername"></a>
# **GetAuthUserpassUsersUsername**
> void GetAuthUserpassUsersUsername (string username)

Manage users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAuthUserpassUsersUsernameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var username = "username_example";  // string | Username for this user.

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.GetAuthUserpassUsersUsername(username);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAuthUserpassUsersUsername: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthalicloudlogin"></a>
# **PostAuthAlicloudLogin**
> void PostAuthAlicloudLogin (AlicloudLoginRequest alicloudLoginRequest = null)

Authenticates an RAM entity with Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAlicloudLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var alicloudLoginRequest = new AlicloudLoginRequest(); // AlicloudLoginRequest |  (optional) 

            try
            {
                // Authenticates an RAM entity with Vault.
                apiInstance.PostAuthAlicloudLogin(alicloudLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAlicloudLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **alicloudLoginRequest** | [**AlicloudLoginRequest**](AlicloudLoginRequest.md)|  | [optional] 

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

<a name="postauthalicloudrolerole"></a>
# **PostAuthAlicloudRoleRole**
> void PostAuthAlicloudRoleRole (string role, AlicloudRoleRequest alicloudRoleRequest = null)

Create a role and associate policies to it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAlicloudRoleRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var role = "role_example";  // string | The name of the role as it should appear in Vault.
            var alicloudRoleRequest = new AlicloudRoleRequest(); // AlicloudRoleRequest |  (optional) 

            try
            {
                // Create a role and associate policies to it.
                apiInstance.PostAuthAlicloudRoleRole(role, alicloudRoleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAlicloudRoleRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The name of the role as it should appear in Vault. | 
 **alicloudRoleRequest** | [**AlicloudRoleRequest**](AlicloudRoleRequest.md)|  | [optional] 

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

<a name="postauthappidlogin"></a>
# **PostAuthAppIdLogin**
> void PostAuthAppIdLogin (AppIdLoginRequest appIdLoginRequest = null)

Log in with an App ID and User ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAppIdLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var appIdLoginRequest = new AppIdLoginRequest(); // AppIdLoginRequest |  (optional) 

            try
            {
                // Log in with an App ID and User ID.
                apiInstance.PostAuthAppIdLogin(appIdLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAppIdLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appIdLoginRequest** | [**AppIdLoginRequest**](AppIdLoginRequest.md)|  | [optional] 

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

<a name="postauthappidloginappid"></a>
# **PostAuthAppIdLoginAppId**
> void PostAuthAppIdLoginAppId (string appId, AppIdLoginRequest appIdLoginRequest = null)

Log in with an App ID and User ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAppIdLoginAppIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var appId = "appId_example";  // string | The unique app ID
            var appIdLoginRequest = new AppIdLoginRequest(); // AppIdLoginRequest |  (optional) 

            try
            {
                // Log in with an App ID and User ID.
                apiInstance.PostAuthAppIdLoginAppId(appId, appIdLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAppIdLoginAppId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| The unique app ID | 
 **appIdLoginRequest** | [**AppIdLoginRequest**](AppIdLoginRequest.md)|  | [optional] 

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

<a name="postauthappidmapappidkey"></a>
# **PostAuthAppIdMapAppIdKey**
> void PostAuthAppIdMapAppIdKey (string key, AppIdMapAppIdRequest appIdMapAppIdRequest = null)

Read/write/delete a single app-id mapping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAppIdMapAppIdKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var key = "key_example";  // string | Key for the app-id mapping
            var appIdMapAppIdRequest = new AppIdMapAppIdRequest(); // AppIdMapAppIdRequest |  (optional) 

            try
            {
                // Read/write/delete a single app-id mapping
                apiInstance.PostAuthAppIdMapAppIdKey(key, appIdMapAppIdRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAppIdMapAppIdKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Key for the app-id mapping | 
 **appIdMapAppIdRequest** | [**AppIdMapAppIdRequest**](AppIdMapAppIdRequest.md)|  | [optional] 

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

<a name="postauthappidmapuseridkey"></a>
# **PostAuthAppIdMapUserIdKey**
> void PostAuthAppIdMapUserIdKey (string key, AppIdMapUserIdRequest appIdMapUserIdRequest = null)

Read/write/delete a single user-id mapping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAppIdMapUserIdKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var key = "key_example";  // string | Key for the user-id mapping
            var appIdMapUserIdRequest = new AppIdMapUserIdRequest(); // AppIdMapUserIdRequest |  (optional) 

            try
            {
                // Read/write/delete a single user-id mapping
                apiInstance.PostAuthAppIdMapUserIdKey(key, appIdMapUserIdRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAppIdMapUserIdKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Key for the user-id mapping | 
 **appIdMapUserIdRequest** | [**AppIdMapUserIdRequest**](AppIdMapUserIdRequest.md)|  | [optional] 

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

<a name="postauthapprolelogin"></a>
# **PostAuthApproleLogin**
> void PostAuthApproleLogin (ApproleLoginRequest approleLoginRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthApproleLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var approleLoginRequest = new ApproleLoginRequest(); // ApproleLoginRequest |  (optional) 

            try
            {
                apiInstance.PostAuthApproleLogin(approleLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthApproleLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **approleLoginRequest** | [**ApproleLoginRequest**](ApproleLoginRequest.md)|  | [optional] 

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

<a name="postauthapprolerolerolename"></a>
# **PostAuthApproleRoleRoleName**
> void PostAuthApproleRoleRoleName (string roleName, ApproleRoleRequest approleRoleRequest = null)

Register an role with the backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.
            var approleRoleRequest = new ApproleRoleRequest(); // ApproleRoleRequest |  (optional) 

            try
            {
                // Register an role with the backend.
                apiInstance.PostAuthApproleRoleRoleName(roleName, approleRoleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthApproleRoleRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 
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

<a name="postauthapprolerolerolenamebindsecretid"></a>
# **PostAuthApproleRoleRoleNameBindSecretId**
> void PostAuthApproleRoleRoleNameBindSecretId (string roleName, ApproleRoleBindSecretIdRequest approleRoleBindSecretIdRequest = null)

Impose secret_id to be presented during login using this role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameBindSecretIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.
            var approleRoleBindSecretIdRequest = new ApproleRoleBindSecretIdRequest(); // ApproleRoleBindSecretIdRequest |  (optional) 

            try
            {
                // Impose secret_id to be presented during login using this role.
                apiInstance.PostAuthApproleRoleRoleNameBindSecretId(roleName, approleRoleBindSecretIdRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthApproleRoleRoleNameBindSecretId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 
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

<a name="postauthapprolerolerolenameboundcidrlist"></a>
# **PostAuthApproleRoleRoleNameBoundCidrList**
> void PostAuthApproleRoleRoleNameBoundCidrList (string roleName, ApproleRoleBoundCidrListRequest approleRoleBoundCidrListRequest = null)

Deprecated: Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameBoundCidrListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.
            var approleRoleBoundCidrListRequest = new ApproleRoleBoundCidrListRequest(); // ApproleRoleBoundCidrListRequest |  (optional) 

            try
            {
                // Deprecated: Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
                apiInstance.PostAuthApproleRoleRoleNameBoundCidrList(roleName, approleRoleBoundCidrListRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthApproleRoleRoleNameBoundCidrList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 
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

<a name="postauthapprolerolerolenamecustomsecretid"></a>
# **PostAuthApproleRoleRoleNameCustomSecretId**
> void PostAuthApproleRoleRoleNameCustomSecretId (string roleName, ApproleRoleCustomSecretIdRequest approleRoleCustomSecretIdRequest = null)

Assign a SecretID of choice against the role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameCustomSecretIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.
            var approleRoleCustomSecretIdRequest = new ApproleRoleCustomSecretIdRequest(); // ApproleRoleCustomSecretIdRequest |  (optional) 

            try
            {
                // Assign a SecretID of choice against the role.
                apiInstance.PostAuthApproleRoleRoleNameCustomSecretId(roleName, approleRoleCustomSecretIdRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthApproleRoleRoleNameCustomSecretId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 
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

<a name="postauthapprolerolerolenameperiod"></a>
# **PostAuthApproleRoleRoleNamePeriod**
> void PostAuthApproleRoleRoleNamePeriod (string roleName, ApproleRolePeriodRequest approleRolePeriodRequest = null)

Updates the value of 'period' on the role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNamePeriodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.
            var approleRolePeriodRequest = new ApproleRolePeriodRequest(); // ApproleRolePeriodRequest |  (optional) 

            try
            {
                // Updates the value of 'period' on the role
                apiInstance.PostAuthApproleRoleRoleNamePeriod(roleName, approleRolePeriodRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthApproleRoleRoleNamePeriod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 
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

<a name="postauthapprolerolerolenamepolicies"></a>
# **PostAuthApproleRoleRoleNamePolicies**
> void PostAuthApproleRoleRoleNamePolicies (string roleName, ApproleRolePoliciesRequest approleRolePoliciesRequest = null)

Policies of the role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNamePoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.
            var approleRolePoliciesRequest = new ApproleRolePoliciesRequest(); // ApproleRolePoliciesRequest |  (optional) 

            try
            {
                // Policies of the role.
                apiInstance.PostAuthApproleRoleRoleNamePolicies(roleName, approleRolePoliciesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthApproleRoleRoleNamePolicies: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 
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

<a name="postauthapprolerolerolenameroleid"></a>
# **PostAuthApproleRoleRoleNameRoleId**
> void PostAuthApproleRoleRoleNameRoleId (string roleName, ApproleRoleRoleIdRequest approleRoleRoleIdRequest = null)

Returns the 'role_id' of the role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameRoleIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.
            var approleRoleRoleIdRequest = new ApproleRoleRoleIdRequest(); // ApproleRoleRoleIdRequest |  (optional) 

            try
            {
                // Returns the 'role_id' of the role.
                apiInstance.PostAuthApproleRoleRoleNameRoleId(roleName, approleRoleRoleIdRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthApproleRoleRoleNameRoleId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 
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

<a name="postauthapprolerolerolenamesecretid"></a>
# **PostAuthApproleRoleRoleNameSecretId**
> void PostAuthApproleRoleRoleNameSecretId (string roleName, ApproleRoleSecretIdRequest approleRoleSecretIdRequest = null)

Generate a SecretID against this role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameSecretIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.
            var approleRoleSecretIdRequest = new ApproleRoleSecretIdRequest(); // ApproleRoleSecretIdRequest |  (optional) 

            try
            {
                // Generate a SecretID against this role.
                apiInstance.PostAuthApproleRoleRoleNameSecretId(roleName, approleRoleSecretIdRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthApproleRoleRoleNameSecretId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 
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

<a name="postauthapprolerolerolenamesecretidaccessordestroy"></a>
# **PostAuthApproleRoleRoleNameSecretIdAccessorDestroy**
> void PostAuthApproleRoleRoleNameSecretIdAccessorDestroy (string roleName, ApproleRoleSecretIdAccessorDestroyRequest approleRoleSecretIdAccessorDestroyRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameSecretIdAccessorDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.
            var approleRoleSecretIdAccessorDestroyRequest = new ApproleRoleSecretIdAccessorDestroyRequest(); // ApproleRoleSecretIdAccessorDestroyRequest |  (optional) 

            try
            {
                apiInstance.PostAuthApproleRoleRoleNameSecretIdAccessorDestroy(roleName, approleRoleSecretIdAccessorDestroyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthApproleRoleRoleNameSecretIdAccessorDestroy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 
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

<a name="postauthapprolerolerolenamesecretidaccessorlookup"></a>
# **PostAuthApproleRoleRoleNameSecretIdAccessorLookup**
> void PostAuthApproleRoleRoleNameSecretIdAccessorLookup (string roleName, ApproleRoleSecretIdAccessorLookupRequest approleRoleSecretIdAccessorLookupRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameSecretIdAccessorLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.
            var approleRoleSecretIdAccessorLookupRequest = new ApproleRoleSecretIdAccessorLookupRequest(); // ApproleRoleSecretIdAccessorLookupRequest |  (optional) 

            try
            {
                apiInstance.PostAuthApproleRoleRoleNameSecretIdAccessorLookup(roleName, approleRoleSecretIdAccessorLookupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthApproleRoleRoleNameSecretIdAccessorLookup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 
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

<a name="postauthapprolerolerolenamesecretidboundcidrs"></a>
# **PostAuthApproleRoleRoleNameSecretIdBoundCidrs**
> void PostAuthApproleRoleRoleNameSecretIdBoundCidrs (string roleName, ApproleRoleSecretIdBoundCidrsRequest approleRoleSecretIdBoundCidrsRequest = null)

Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameSecretIdBoundCidrsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.
            var approleRoleSecretIdBoundCidrsRequest = new ApproleRoleSecretIdBoundCidrsRequest(); // ApproleRoleSecretIdBoundCidrsRequest |  (optional) 

            try
            {
                // Comma separated list of CIDR blocks, if set, specifies blocks of IP addresses which can perform the login operation
                apiInstance.PostAuthApproleRoleRoleNameSecretIdBoundCidrs(roleName, approleRoleSecretIdBoundCidrsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthApproleRoleRoleNameSecretIdBoundCidrs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 
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

<a name="postauthapprolerolerolenamesecretiddestroy"></a>
# **PostAuthApproleRoleRoleNameSecretIdDestroy**
> void PostAuthApproleRoleRoleNameSecretIdDestroy (string roleName, ApproleRoleSecretIdDestroyRequest approleRoleSecretIdDestroyRequest = null)

Invalidate an issued secret_id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameSecretIdDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.
            var approleRoleSecretIdDestroyRequest = new ApproleRoleSecretIdDestroyRequest(); // ApproleRoleSecretIdDestroyRequest |  (optional) 

            try
            {
                // Invalidate an issued secret_id
                apiInstance.PostAuthApproleRoleRoleNameSecretIdDestroy(roleName, approleRoleSecretIdDestroyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthApproleRoleRoleNameSecretIdDestroy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 
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

<a name="postauthapprolerolerolenamesecretidlookup"></a>
# **PostAuthApproleRoleRoleNameSecretIdLookup**
> void PostAuthApproleRoleRoleNameSecretIdLookup (string roleName, ApproleRoleSecretIdLookupRequest approleRoleSecretIdLookupRequest = null)

Read the properties of an issued secret_id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameSecretIdLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.
            var approleRoleSecretIdLookupRequest = new ApproleRoleSecretIdLookupRequest(); // ApproleRoleSecretIdLookupRequest |  (optional) 

            try
            {
                // Read the properties of an issued secret_id
                apiInstance.PostAuthApproleRoleRoleNameSecretIdLookup(roleName, approleRoleSecretIdLookupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthApproleRoleRoleNameSecretIdLookup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 
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

<a name="postauthapprolerolerolenamesecretidnumuses"></a>
# **PostAuthApproleRoleRoleNameSecretIdNumUses**
> void PostAuthApproleRoleRoleNameSecretIdNumUses (string roleName, ApproleRoleSecretIdNumUsesRequest approleRoleSecretIdNumUsesRequest = null)

Use limit of the SecretID generated against the role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameSecretIdNumUsesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.
            var approleRoleSecretIdNumUsesRequest = new ApproleRoleSecretIdNumUsesRequest(); // ApproleRoleSecretIdNumUsesRequest |  (optional) 

            try
            {
                // Use limit of the SecretID generated against the role.
                apiInstance.PostAuthApproleRoleRoleNameSecretIdNumUses(roleName, approleRoleSecretIdNumUsesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthApproleRoleRoleNameSecretIdNumUses: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 
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

<a name="postauthapprolerolerolenamesecretidttl"></a>
# **PostAuthApproleRoleRoleNameSecretIdTtl**
> void PostAuthApproleRoleRoleNameSecretIdTtl (string roleName, ApproleRoleSecretIdTtlRequest approleRoleSecretIdTtlRequest = null)

Duration in seconds, representing the lifetime of the SecretIDs that are generated against the role using 'role/<role_name>/secret-id' or 'role/<role_name>/custom-secret-id' endpoints.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameSecretIdTtlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.
            var approleRoleSecretIdTtlRequest = new ApproleRoleSecretIdTtlRequest(); // ApproleRoleSecretIdTtlRequest |  (optional) 

            try
            {
                // Duration in seconds, representing the lifetime of the SecretIDs that are generated against the role using 'role/<role_name>/secret-id' or 'role/<role_name>/custom-secret-id' endpoints.
                apiInstance.PostAuthApproleRoleRoleNameSecretIdTtl(roleName, approleRoleSecretIdTtlRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthApproleRoleRoleNameSecretIdTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 
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

<a name="postauthapprolerolerolenametokenboundcidrs"></a>
# **PostAuthApproleRoleRoleNameTokenBoundCidrs**
> void PostAuthApproleRoleRoleNameTokenBoundCidrs (string roleName, ApproleRoleTokenBoundCidrsRequest approleRoleTokenBoundCidrsRequest = null)

Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameTokenBoundCidrsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.
            var approleRoleTokenBoundCidrsRequest = new ApproleRoleTokenBoundCidrsRequest(); // ApproleRoleTokenBoundCidrsRequest |  (optional) 

            try
            {
                // Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token.
                apiInstance.PostAuthApproleRoleRoleNameTokenBoundCidrs(roleName, approleRoleTokenBoundCidrsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthApproleRoleRoleNameTokenBoundCidrs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 
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

<a name="postauthapprolerolerolenametokenmaxttl"></a>
# **PostAuthApproleRoleRoleNameTokenMaxTtl**
> void PostAuthApproleRoleRoleNameTokenMaxTtl (string roleName, ApproleRoleTokenMaxTtlRequest approleRoleTokenMaxTtlRequest = null)

Duration in seconds, the maximum lifetime of the tokens issued by using the SecretIDs that were generated against this role, after which the tokens are not allowed to be renewed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameTokenMaxTtlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.
            var approleRoleTokenMaxTtlRequest = new ApproleRoleTokenMaxTtlRequest(); // ApproleRoleTokenMaxTtlRequest |  (optional) 

            try
            {
                // Duration in seconds, the maximum lifetime of the tokens issued by using the SecretIDs that were generated against this role, after which the tokens are not allowed to be renewed.
                apiInstance.PostAuthApproleRoleRoleNameTokenMaxTtl(roleName, approleRoleTokenMaxTtlRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthApproleRoleRoleNameTokenMaxTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 
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

<a name="postauthapprolerolerolenametokennumuses"></a>
# **PostAuthApproleRoleRoleNameTokenNumUses**
> void PostAuthApproleRoleRoleNameTokenNumUses (string roleName, ApproleRoleTokenNumUsesRequest approleRoleTokenNumUsesRequest = null)

Number of times issued tokens can be used

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameTokenNumUsesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.
            var approleRoleTokenNumUsesRequest = new ApproleRoleTokenNumUsesRequest(); // ApproleRoleTokenNumUsesRequest |  (optional) 

            try
            {
                // Number of times issued tokens can be used
                apiInstance.PostAuthApproleRoleRoleNameTokenNumUses(roleName, approleRoleTokenNumUsesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthApproleRoleRoleNameTokenNumUses: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 
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

<a name="postauthapprolerolerolenametokenttl"></a>
# **PostAuthApproleRoleRoleNameTokenTtl**
> void PostAuthApproleRoleRoleNameTokenTtl (string roleName, ApproleRoleTokenTtlRequest approleRoleTokenTtlRequest = null)

Duration in seconds, the lifetime of the token issued by using the SecretID that is generated against this role, before which the token needs to be renewed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameTokenTtlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role.
            var approleRoleTokenTtlRequest = new ApproleRoleTokenTtlRequest(); // ApproleRoleTokenTtlRequest |  (optional) 

            try
            {
                // Duration in seconds, the lifetime of the token issued by using the SecretID that is generated against this role, before which the token needs to be renewed.
                apiInstance.PostAuthApproleRoleRoleNameTokenTtl(roleName, approleRoleTokenTtlRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthApproleRoleRoleNameTokenTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. | 
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

<a name="postauthapproletidysecretid"></a>
# **PostAuthApproleTidySecretId**
> void PostAuthApproleTidySecretId ()

Trigger the clean-up of expired SecretID entries.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthApproleTidySecretIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                // Trigger the clean-up of expired SecretID entries.
                apiInstance.PostAuthApproleTidySecretId();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthApproleTidySecretId: " + e.Message );
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

<a name="postauthawsconfigcertificatecertname"></a>
# **PostAuthAwsConfigCertificateCertName**
> void PostAuthAwsConfigCertificateCertName (string certName, AwsConfigCertificateRequest awsConfigCertificateRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAwsConfigCertificateCertNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var certName = "certName_example";  // string | Name of the certificate.
            var awsConfigCertificateRequest = new AwsConfigCertificateRequest(); // AwsConfigCertificateRequest |  (optional) 

            try
            {
                apiInstance.PostAuthAwsConfigCertificateCertName(certName, awsConfigCertificateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAwsConfigCertificateCertName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postauthawsconfigclient"></a>
# **PostAuthAwsConfigClient**
> void PostAuthAwsConfigClient (AwsConfigClientRequest awsConfigClientRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAwsConfigClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var awsConfigClientRequest = new AwsConfigClientRequest(); // AwsConfigClientRequest |  (optional) 

            try
            {
                apiInstance.PostAuthAwsConfigClient(awsConfigClientRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAwsConfigClient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="postauthawsconfigidentity"></a>
# **PostAuthAwsConfigIdentity**
> void PostAuthAwsConfigIdentity (AwsConfigIdentityRequest awsConfigIdentityRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAwsConfigIdentityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var awsConfigIdentityRequest = new AwsConfigIdentityRequest(); // AwsConfigIdentityRequest |  (optional) 

            try
            {
                apiInstance.PostAuthAwsConfigIdentity(awsConfigIdentityRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAwsConfigIdentity: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="postauthawsconfigrotateroot"></a>
# **PostAuthAwsConfigRotateRoot**
> void PostAuthAwsConfigRotateRoot ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAwsConfigRotateRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                apiInstance.PostAuthAwsConfigRotateRoot();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAwsConfigRotateRoot: " + e.Message );
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

<a name="postauthawsconfigstsaccountid"></a>
# **PostAuthAwsConfigStsAccountId**
> void PostAuthAwsConfigStsAccountId (string accountId, AwsConfigStsRequest awsConfigStsRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAwsConfigStsAccountIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var accountId = "accountId_example";  // string | AWS account ID to be associated with STS role. If set, Vault will use assumed credentials to verify any login attempts from EC2 instances in this account.
            var awsConfigStsRequest = new AwsConfigStsRequest(); // AwsConfigStsRequest |  (optional) 

            try
            {
                apiInstance.PostAuthAwsConfigStsAccountId(accountId, awsConfigStsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAwsConfigStsAccountId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postauthawsconfigtidyidentityaccesslist"></a>
# **PostAuthAwsConfigTidyIdentityAccesslist**
> void PostAuthAwsConfigTidyIdentityAccesslist (AwsConfigTidyIdentityAccesslistRequest awsConfigTidyIdentityAccesslistRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAwsConfigTidyIdentityAccesslistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var awsConfigTidyIdentityAccesslistRequest = new AwsConfigTidyIdentityAccesslistRequest(); // AwsConfigTidyIdentityAccesslistRequest |  (optional) 

            try
            {
                apiInstance.PostAuthAwsConfigTidyIdentityAccesslist(awsConfigTidyIdentityAccesslistRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAwsConfigTidyIdentityAccesslist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="postauthawsconfigtidyidentitywhitelist"></a>
# **PostAuthAwsConfigTidyIdentityWhitelist**
> void PostAuthAwsConfigTidyIdentityWhitelist (AwsConfigTidyIdentityWhitelistRequest awsConfigTidyIdentityWhitelistRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAwsConfigTidyIdentityWhitelistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var awsConfigTidyIdentityWhitelistRequest = new AwsConfigTidyIdentityWhitelistRequest(); // AwsConfigTidyIdentityWhitelistRequest |  (optional) 

            try
            {
                apiInstance.PostAuthAwsConfigTidyIdentityWhitelist(awsConfigTidyIdentityWhitelistRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAwsConfigTidyIdentityWhitelist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="postauthawsconfigtidyroletagblacklist"></a>
# **PostAuthAwsConfigTidyRoletagBlacklist**
> void PostAuthAwsConfigTidyRoletagBlacklist (AwsConfigTidyRoletagBlacklistRequest awsConfigTidyRoletagBlacklistRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAwsConfigTidyRoletagBlacklistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var awsConfigTidyRoletagBlacklistRequest = new AwsConfigTidyRoletagBlacklistRequest(); // AwsConfigTidyRoletagBlacklistRequest |  (optional) 

            try
            {
                apiInstance.PostAuthAwsConfigTidyRoletagBlacklist(awsConfigTidyRoletagBlacklistRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAwsConfigTidyRoletagBlacklist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="postauthawsconfigtidyroletagdenylist"></a>
# **PostAuthAwsConfigTidyRoletagDenylist**
> void PostAuthAwsConfigTidyRoletagDenylist (AwsConfigTidyRoletagDenylistRequest awsConfigTidyRoletagDenylistRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAwsConfigTidyRoletagDenylistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var awsConfigTidyRoletagDenylistRequest = new AwsConfigTidyRoletagDenylistRequest(); // AwsConfigTidyRoletagDenylistRequest |  (optional) 

            try
            {
                apiInstance.PostAuthAwsConfigTidyRoletagDenylist(awsConfigTidyRoletagDenylistRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAwsConfigTidyRoletagDenylist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="postauthawslogin"></a>
# **PostAuthAwsLogin**
> void PostAuthAwsLogin (AwsLoginRequest awsLoginRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAwsLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var awsLoginRequest = new AwsLoginRequest(); // AwsLoginRequest |  (optional) 

            try
            {
                apiInstance.PostAuthAwsLogin(awsLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAwsLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsLoginRequest** | [**AwsLoginRequest**](AwsLoginRequest.md)|  | [optional] 

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

<a name="postauthawsrolerole"></a>
# **PostAuthAwsRoleRole**
> void PostAuthAwsRoleRole (string role, AwsRoleRequest awsRoleRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAwsRoleRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var role = "role_example";  // string | Name of the role.
            var awsRoleRequest = new AwsRoleRequest(); // AwsRoleRequest |  (optional) 

            try
            {
                apiInstance.PostAuthAwsRoleRole(role, awsRoleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAwsRoleRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postauthawsroleroletag"></a>
# **PostAuthAwsRoleRoleTag**
> void PostAuthAwsRoleRoleTag (string role, AwsRoleTagRequest awsRoleTagRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAwsRoleRoleTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var role = "role_example";  // string | Name of the role.
            var awsRoleTagRequest = new AwsRoleTagRequest(); // AwsRoleTagRequest |  (optional) 

            try
            {
                apiInstance.PostAuthAwsRoleRoleTag(role, awsRoleTagRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAwsRoleRoleTag: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postauthawsroletagblacklistroletag"></a>
# **PostAuthAwsRoletagBlacklistRoleTag**
> void PostAuthAwsRoletagBlacklistRoleTag (string roleTag)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAwsRoletagBlacklistRoleTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleTag = "roleTag_example";  // string | Role tag to be deny listed. The tag can be supplied as-is. In order to avoid any encoding problems, it can be base64 encoded.

            try
            {
                apiInstance.PostAuthAwsRoletagBlacklistRoleTag(roleTag);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAwsRoletagBlacklistRoleTag: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthawsroletagdenylistroletag"></a>
# **PostAuthAwsRoletagDenylistRoleTag**
> void PostAuthAwsRoletagDenylistRoleTag (string roleTag)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAwsRoletagDenylistRoleTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleTag = "roleTag_example";  // string | Role tag to be deny listed. The tag can be supplied as-is. In order to avoid any encoding problems, it can be base64 encoded.

            try
            {
                apiInstance.PostAuthAwsRoletagDenylistRoleTag(roleTag);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAwsRoletagDenylistRoleTag: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthawstidyidentityaccesslist"></a>
# **PostAuthAwsTidyIdentityAccesslist**
> void PostAuthAwsTidyIdentityAccesslist (AwsTidyIdentityAccesslistRequest awsTidyIdentityAccesslistRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAwsTidyIdentityAccesslistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var awsTidyIdentityAccesslistRequest = new AwsTidyIdentityAccesslistRequest(); // AwsTidyIdentityAccesslistRequest |  (optional) 

            try
            {
                apiInstance.PostAuthAwsTidyIdentityAccesslist(awsTidyIdentityAccesslistRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAwsTidyIdentityAccesslist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="postauthawstidyidentitywhitelist"></a>
# **PostAuthAwsTidyIdentityWhitelist**
> void PostAuthAwsTidyIdentityWhitelist (AwsTidyIdentityWhitelistRequest awsTidyIdentityWhitelistRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAwsTidyIdentityWhitelistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var awsTidyIdentityWhitelistRequest = new AwsTidyIdentityWhitelistRequest(); // AwsTidyIdentityWhitelistRequest |  (optional) 

            try
            {
                apiInstance.PostAuthAwsTidyIdentityWhitelist(awsTidyIdentityWhitelistRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAwsTidyIdentityWhitelist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="postauthawstidyroletagblacklist"></a>
# **PostAuthAwsTidyRoletagBlacklist**
> void PostAuthAwsTidyRoletagBlacklist (AwsTidyRoletagBlacklistRequest awsTidyRoletagBlacklistRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAwsTidyRoletagBlacklistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var awsTidyRoletagBlacklistRequest = new AwsTidyRoletagBlacklistRequest(); // AwsTidyRoletagBlacklistRequest |  (optional) 

            try
            {
                apiInstance.PostAuthAwsTidyRoletagBlacklist(awsTidyRoletagBlacklistRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAwsTidyRoletagBlacklist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="postauthawstidyroletagdenylist"></a>
# **PostAuthAwsTidyRoletagDenylist**
> void PostAuthAwsTidyRoletagDenylist (AwsTidyRoletagDenylistRequest awsTidyRoletagDenylistRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAwsTidyRoletagDenylistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var awsTidyRoletagDenylistRequest = new AwsTidyRoletagDenylistRequest(); // AwsTidyRoletagDenylistRequest |  (optional) 

            try
            {
                apiInstance.PostAuthAwsTidyRoletagDenylist(awsTidyRoletagDenylistRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAwsTidyRoletagDenylist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="postauthazureconfig"></a>
# **PostAuthAzureConfig**
> void PostAuthAzureConfig (AzureConfigRequest azureConfigRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAzureConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var azureConfigRequest = new AzureConfigRequest(); // AzureConfigRequest |  (optional) 

            try
            {
                apiInstance.PostAuthAzureConfig(azureConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAzureConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **azureConfigRequest** | [**AzureConfigRequest**](AzureConfigRequest.md)|  | [optional] 

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

<a name="postauthazurelogin"></a>
# **PostAuthAzureLogin**
> void PostAuthAzureLogin (AzureLoginRequest azureLoginRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAzureLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var azureLoginRequest = new AzureLoginRequest(); // AzureLoginRequest |  (optional) 

            try
            {
                apiInstance.PostAuthAzureLogin(azureLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAzureLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **azureLoginRequest** | [**AzureLoginRequest**](AzureLoginRequest.md)|  | [optional] 

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

<a name="postauthazurerolename"></a>
# **PostAuthAzureRoleName**
> void PostAuthAzureRoleName (string name, AzureRoleRequest azureRoleRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthAzureRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the role.
            var azureRoleRequest = new AzureRoleRequest(); // AzureRoleRequest |  (optional) 

            try
            {
                apiInstance.PostAuthAzureRoleName(name, azureRoleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthAzureRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **azureRoleRequest** | [**AzureRoleRequest**](AzureRoleRequest.md)|  | [optional] 

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

<a name="postauthcentrifyconfig"></a>
# **PostAuthCentrifyConfig**
> void PostAuthCentrifyConfig (CentrifyConfigRequest centrifyConfigRequest = null)

This path allows you to configure the centrify auth provider to interact with the Centrify Identity Services Platform for authenticating users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthCentrifyConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var centrifyConfigRequest = new CentrifyConfigRequest(); // CentrifyConfigRequest |  (optional) 

            try
            {
                // This path allows you to configure the centrify auth provider to interact with the Centrify Identity Services Platform for authenticating users.
                apiInstance.PostAuthCentrifyConfig(centrifyConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthCentrifyConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **centrifyConfigRequest** | [**CentrifyConfigRequest**](CentrifyConfigRequest.md)|  | [optional] 

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

<a name="postauthcentrifylogin"></a>
# **PostAuthCentrifyLogin**
> void PostAuthCentrifyLogin (CentrifyLoginRequest centrifyLoginRequest = null)

Log in with a username and password.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthCentrifyLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var centrifyLoginRequest = new CentrifyLoginRequest(); // CentrifyLoginRequest |  (optional) 

            try
            {
                // Log in with a username and password.
                apiInstance.PostAuthCentrifyLogin(centrifyLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthCentrifyLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **centrifyLoginRequest** | [**CentrifyLoginRequest**](CentrifyLoginRequest.md)|  | [optional] 

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

<a name="postauthcertcertsname"></a>
# **PostAuthCertCertsName**
> void PostAuthCertCertsName (string name, CertCertsRequest certCertsRequest = null)

Manage trusted certificates used for authentication.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthCertCertsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | The name of the certificate
            var certCertsRequest = new CertCertsRequest(); // CertCertsRequest |  (optional) 

            try
            {
                // Manage trusted certificates used for authentication.
                apiInstance.PostAuthCertCertsName(name, certCertsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthCertCertsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postauthcertconfig"></a>
# **PostAuthCertConfig**
> void PostAuthCertConfig (CertConfigRequest certConfigRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthCertConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var certConfigRequest = new CertConfigRequest(); // CertConfigRequest |  (optional) 

            try
            {
                apiInstance.PostAuthCertConfig(certConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthCertConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **certConfigRequest** | [**CertConfigRequest**](CertConfigRequest.md)|  | [optional] 

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

<a name="postauthcertcrlsname"></a>
# **PostAuthCertCrlsName**
> void PostAuthCertCrlsName (string name, CertCrlsRequest certCrlsRequest = null)

Manage Certificate Revocation Lists checked during authentication.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthCertCrlsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | The name of the certificate
            var certCrlsRequest = new CertCrlsRequest(); // CertCrlsRequest |  (optional) 

            try
            {
                // Manage Certificate Revocation Lists checked during authentication.
                apiInstance.PostAuthCertCrlsName(name, certCrlsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthCertCrlsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postauthcertlogin"></a>
# **PostAuthCertLogin**
> void PostAuthCertLogin (CertLoginRequest certLoginRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthCertLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var certLoginRequest = new CertLoginRequest(); // CertLoginRequest |  (optional) 

            try
            {
                apiInstance.PostAuthCertLogin(certLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthCertLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **certLoginRequest** | [**CertLoginRequest**](CertLoginRequest.md)|  | [optional] 

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

<a name="postauthcfconfig"></a>
# **PostAuthCfConfig**
> void PostAuthCfConfig (CfConfigRequest cfConfigRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthCfConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var cfConfigRequest = new CfConfigRequest(); // CfConfigRequest |  (optional) 

            try
            {
                apiInstance.PostAuthCfConfig(cfConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthCfConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cfConfigRequest** | [**CfConfigRequest**](CfConfigRequest.md)|  | [optional] 

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

<a name="postauthcflogin"></a>
# **PostAuthCfLogin**
> void PostAuthCfLogin (CfLoginRequest cfLoginRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthCfLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var cfLoginRequest = new CfLoginRequest(); // CfLoginRequest |  (optional) 

            try
            {
                apiInstance.PostAuthCfLogin(cfLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthCfLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cfLoginRequest** | [**CfLoginRequest**](CfLoginRequest.md)|  | [optional] 

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

<a name="postauthcfrolesrole"></a>
# **PostAuthCfRolesRole**
> void PostAuthCfRolesRole (string role, CfRolesRequest cfRolesRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthCfRolesRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var role = "role_example";  // string | The name of the role.
            var cfRolesRequest = new CfRolesRequest(); // CfRolesRequest |  (optional) 

            try
            {
                apiInstance.PostAuthCfRolesRole(role, cfRolesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthCfRolesRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postauthgcpconfig"></a>
# **PostAuthGcpConfig**
> void PostAuthGcpConfig (GcpConfigRequest gcpConfigRequest = null)

Configure credentials used to query the GCP IAM API to verify authenticating service accounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthGcpConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var gcpConfigRequest = new GcpConfigRequest(); // GcpConfigRequest |  (optional) 

            try
            {
                // Configure credentials used to query the GCP IAM API to verify authenticating service accounts
                apiInstance.PostAuthGcpConfig(gcpConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthGcpConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gcpConfigRequest** | [**GcpConfigRequest**](GcpConfigRequest.md)|  | [optional] 

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

<a name="postauthgcplogin"></a>
# **PostAuthGcpLogin**
> void PostAuthGcpLogin (GcpLoginRequest gcpLoginRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthGcpLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var gcpLoginRequest = new GcpLoginRequest(); // GcpLoginRequest |  (optional) 

            try
            {
                apiInstance.PostAuthGcpLogin(gcpLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthGcpLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gcpLoginRequest** | [**GcpLoginRequest**](GcpLoginRequest.md)|  | [optional] 

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

<a name="postauthgcprolename"></a>
# **PostAuthGcpRoleName**
> void PostAuthGcpRoleName (string name, GcpRoleRequest gcpRoleRequest = null)

Create a GCP role with associated policies and required attributes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthGcpRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the role.
            var gcpRoleRequest = new GcpRoleRequest(); // GcpRoleRequest |  (optional) 

            try
            {
                // Create a GCP role with associated policies and required attributes.
                apiInstance.PostAuthGcpRoleName(name, gcpRoleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthGcpRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **gcpRoleRequest** | [**GcpRoleRequest**](GcpRoleRequest.md)|  | [optional] 

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

<a name="postauthgcprolenamelabels"></a>
# **PostAuthGcpRoleNameLabels**
> void PostAuthGcpRoleNameLabels (string name, GcpRoleLabelsRequest gcpRoleLabelsRequest = null)

Add or remove labels for an existing 'gce' role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthGcpRoleNameLabelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the role.
            var gcpRoleLabelsRequest = new GcpRoleLabelsRequest(); // GcpRoleLabelsRequest |  (optional) 

            try
            {
                // Add or remove labels for an existing 'gce' role
                apiInstance.PostAuthGcpRoleNameLabels(name, gcpRoleLabelsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthGcpRoleNameLabels: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postauthgcprolenameserviceaccounts"></a>
# **PostAuthGcpRoleNameServiceAccounts**
> void PostAuthGcpRoleNameServiceAccounts (string name, GcpRoleServiceAccountsRequest gcpRoleServiceAccountsRequest = null)

Add or remove service accounts for an existing `iam` role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthGcpRoleNameServiceAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the role.
            var gcpRoleServiceAccountsRequest = new GcpRoleServiceAccountsRequest(); // GcpRoleServiceAccountsRequest |  (optional) 

            try
            {
                // Add or remove service accounts for an existing `iam` role
                apiInstance.PostAuthGcpRoleNameServiceAccounts(name, gcpRoleServiceAccountsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthGcpRoleNameServiceAccounts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postauthgithubconfig"></a>
# **PostAuthGithubConfig**
> void PostAuthGithubConfig (GithubConfigRequest githubConfigRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthGithubConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var githubConfigRequest = new GithubConfigRequest(); // GithubConfigRequest |  (optional) 

            try
            {
                apiInstance.PostAuthGithubConfig(githubConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthGithubConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **githubConfigRequest** | [**GithubConfigRequest**](GithubConfigRequest.md)|  | [optional] 

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

<a name="postauthgithublogin"></a>
# **PostAuthGithubLogin**
> void PostAuthGithubLogin (GithubLoginRequest githubLoginRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthGithubLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var githubLoginRequest = new GithubLoginRequest(); // GithubLoginRequest |  (optional) 

            try
            {
                apiInstance.PostAuthGithubLogin(githubLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthGithubLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **githubLoginRequest** | [**GithubLoginRequest**](GithubLoginRequest.md)|  | [optional] 

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

<a name="postauthgithubmapteamskey"></a>
# **PostAuthGithubMapTeamsKey**
> void PostAuthGithubMapTeamsKey (string key, GithubMapTeamsRequest githubMapTeamsRequest = null)

Read/write/delete a single teams mapping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthGithubMapTeamsKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var key = "key_example";  // string | Key for the teams mapping
            var githubMapTeamsRequest = new GithubMapTeamsRequest(); // GithubMapTeamsRequest |  (optional) 

            try
            {
                // Read/write/delete a single teams mapping
                apiInstance.PostAuthGithubMapTeamsKey(key, githubMapTeamsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthGithubMapTeamsKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postauthgithubmapuserskey"></a>
# **PostAuthGithubMapUsersKey**
> void PostAuthGithubMapUsersKey (string key, GithubMapUsersRequest githubMapUsersRequest = null)

Read/write/delete a single users mapping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthGithubMapUsersKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var key = "key_example";  // string | Key for the users mapping
            var githubMapUsersRequest = new GithubMapUsersRequest(); // GithubMapUsersRequest |  (optional) 

            try
            {
                // Read/write/delete a single users mapping
                apiInstance.PostAuthGithubMapUsersKey(key, githubMapUsersRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthGithubMapUsersKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postauthjwtconfig"></a>
# **PostAuthJwtConfig**
> void PostAuthJwtConfig (JwtConfigRequest jwtConfigRequest = null)

Configure the JWT authentication backend.

The JWT authentication backend validates JWTs (or OIDC) using the configured credentials. If using OIDC Discovery, the URL must be provided, along with (optionally) the CA cert to use for the connection. If performing JWT validation locally, a set of public keys must be provided.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthJwtConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var jwtConfigRequest = new JwtConfigRequest(); // JwtConfigRequest |  (optional) 

            try
            {
                // Configure the JWT authentication backend.
                apiInstance.PostAuthJwtConfig(jwtConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthJwtConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jwtConfigRequest** | [**JwtConfigRequest**](JwtConfigRequest.md)|  | [optional] 

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

<a name="postauthjwtlogin"></a>
# **PostAuthJwtLogin**
> void PostAuthJwtLogin (JwtLoginRequest jwtLoginRequest = null)

Authenticates to Vault using a JWT (or OIDC) token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthJwtLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var jwtLoginRequest = new JwtLoginRequest(); // JwtLoginRequest |  (optional) 

            try
            {
                // Authenticates to Vault using a JWT (or OIDC) token.
                apiInstance.PostAuthJwtLogin(jwtLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthJwtLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jwtLoginRequest** | [**JwtLoginRequest**](JwtLoginRequest.md)|  | [optional] 

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

<a name="postauthjwtoidcauthurl"></a>
# **PostAuthJwtOidcAuthUrl**
> void PostAuthJwtOidcAuthUrl (JwtOidcAuthUrlRequest jwtOidcAuthUrlRequest = null)

Request an authorization URL to start an OIDC login flow.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthJwtOidcAuthUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var jwtOidcAuthUrlRequest = new JwtOidcAuthUrlRequest(); // JwtOidcAuthUrlRequest |  (optional) 

            try
            {
                // Request an authorization URL to start an OIDC login flow.
                apiInstance.PostAuthJwtOidcAuthUrl(jwtOidcAuthUrlRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthJwtOidcAuthUrl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jwtOidcAuthUrlRequest** | [**JwtOidcAuthUrlRequest**](JwtOidcAuthUrlRequest.md)|  | [optional] 

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

<a name="postauthjwtoidccallback"></a>
# **PostAuthJwtOidcCallback**
> void PostAuthJwtOidcCallback (JwtOidcCallbackRequest jwtOidcCallbackRequest = null)

Callback endpoint to handle form_posts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthJwtOidcCallbackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var jwtOidcCallbackRequest = new JwtOidcCallbackRequest(); // JwtOidcCallbackRequest |  (optional) 

            try
            {
                // Callback endpoint to handle form_posts.
                apiInstance.PostAuthJwtOidcCallback(jwtOidcCallbackRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthJwtOidcCallback: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jwtOidcCallbackRequest** | [**JwtOidcCallbackRequest**](JwtOidcCallbackRequest.md)|  | [optional] 

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

<a name="postauthjwtrolename"></a>
# **PostAuthJwtRoleName**
> void PostAuthJwtRoleName (string name, JwtRoleRequest jwtRoleRequest = null)

Register an role with the backend.

A role is required to authenticate with this backend. The role binds   JWT token information with token policies and settings.   The bindings, token polices and token settings can all be configured   using this endpoint

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthJwtRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the role.
            var jwtRoleRequest = new JwtRoleRequest(); // JwtRoleRequest |  (optional) 

            try
            {
                // Register an role with the backend.
                apiInstance.PostAuthJwtRoleName(name, jwtRoleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthJwtRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **jwtRoleRequest** | [**JwtRoleRequest**](JwtRoleRequest.md)|  | [optional] 

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

<a name="postauthkerberosconfig"></a>
# **PostAuthKerberosConfig**
> void PostAuthKerberosConfig (KerberosConfigRequest kerberosConfigRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthKerberosConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var kerberosConfigRequest = new KerberosConfigRequest(); // KerberosConfigRequest |  (optional) 

            try
            {
                apiInstance.PostAuthKerberosConfig(kerberosConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthKerberosConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kerberosConfigRequest** | [**KerberosConfigRequest**](KerberosConfigRequest.md)|  | [optional] 

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

<a name="postauthkerberosconfigldap"></a>
# **PostAuthKerberosConfigLdap**
> void PostAuthKerberosConfigLdap (KerberosConfigLdapRequest kerberosConfigLdapRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthKerberosConfigLdapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var kerberosConfigLdapRequest = new KerberosConfigLdapRequest(); // KerberosConfigLdapRequest |  (optional) 

            try
            {
                apiInstance.PostAuthKerberosConfigLdap(kerberosConfigLdapRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthKerberosConfigLdap: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="postauthkerberosgroupsname"></a>
# **PostAuthKerberosGroupsName**
> void PostAuthKerberosGroupsName (string name, KerberosGroupsRequest kerberosGroupsRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthKerberosGroupsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the LDAP group.
            var kerberosGroupsRequest = new KerberosGroupsRequest(); // KerberosGroupsRequest |  (optional) 

            try
            {
                apiInstance.PostAuthKerberosGroupsName(name, kerberosGroupsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthKerberosGroupsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postauthkerberoslogin"></a>
# **PostAuthKerberosLogin**
> void PostAuthKerberosLogin (KerberosLoginRequest kerberosLoginRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthKerberosLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var kerberosLoginRequest = new KerberosLoginRequest(); // KerberosLoginRequest |  (optional) 

            try
            {
                apiInstance.PostAuthKerberosLogin(kerberosLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthKerberosLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kerberosLoginRequest** | [**KerberosLoginRequest**](KerberosLoginRequest.md)|  | [optional] 

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

<a name="postauthkubernetesconfig"></a>
# **PostAuthKubernetesConfig**
> void PostAuthKubernetesConfig (KubernetesConfigRequest kubernetesConfigRequest = null)

Configures the JWT Public Key and Kubernetes API information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthKubernetesConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var kubernetesConfigRequest = new KubernetesConfigRequest(); // KubernetesConfigRequest |  (optional) 

            try
            {
                // Configures the JWT Public Key and Kubernetes API information.
                apiInstance.PostAuthKubernetesConfig(kubernetesConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthKubernetesConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kubernetesConfigRequest** | [**KubernetesConfigRequest**](KubernetesConfigRequest.md)|  | [optional] 

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

<a name="postauthkuberneteslogin"></a>
# **PostAuthKubernetesLogin**
> void PostAuthKubernetesLogin (KubernetesLoginRequest kubernetesLoginRequest = null)

Authenticates Kubernetes service accounts with Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthKubernetesLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var kubernetesLoginRequest = new KubernetesLoginRequest(); // KubernetesLoginRequest |  (optional) 

            try
            {
                // Authenticates Kubernetes service accounts with Vault.
                apiInstance.PostAuthKubernetesLogin(kubernetesLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthKubernetesLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kubernetesLoginRequest** | [**KubernetesLoginRequest**](KubernetesLoginRequest.md)|  | [optional] 

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

<a name="postauthkubernetesrolename"></a>
# **PostAuthKubernetesRoleName**
> void PostAuthKubernetesRoleName (string name, KubernetesRoleRequest kubernetesRoleRequest = null)

Register an role with the backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthKubernetesRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the role.
            var kubernetesRoleRequest = new KubernetesRoleRequest(); // KubernetesRoleRequest |  (optional) 

            try
            {
                // Register an role with the backend.
                apiInstance.PostAuthKubernetesRoleName(name, kubernetesRoleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthKubernetesRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **kubernetesRoleRequest** | [**KubernetesRoleRequest**](KubernetesRoleRequest.md)|  | [optional] 

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

<a name="postauthldapconfig"></a>
# **PostAuthLdapConfig**
> void PostAuthLdapConfig (LdapConfigRequest ldapConfigRequest = null)

Configure the LDAP server to connect to, along with its options.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthLdapConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var ldapConfigRequest = new LdapConfigRequest(); // LdapConfigRequest |  (optional) 

            try
            {
                // Configure the LDAP server to connect to, along with its options.
                apiInstance.PostAuthLdapConfig(ldapConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthLdapConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ldapConfigRequest** | [**LdapConfigRequest**](LdapConfigRequest.md)|  | [optional] 

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

<a name="postauthldapgroupsname"></a>
# **PostAuthLdapGroupsName**
> void PostAuthLdapGroupsName (string name, LdapGroupsRequest ldapGroupsRequest = null)

Manage additional groups for users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthLdapGroupsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the LDAP group.
            var ldapGroupsRequest = new LdapGroupsRequest(); // LdapGroupsRequest |  (optional) 

            try
            {
                // Manage additional groups for users allowed to authenticate.
                apiInstance.PostAuthLdapGroupsName(name, ldapGroupsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthLdapGroupsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **ldapGroupsRequest** | [**LdapGroupsRequest**](LdapGroupsRequest.md)|  | [optional] 

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

<a name="postauthldaploginusername"></a>
# **PostAuthLdapLoginUsername**
> void PostAuthLdapLoginUsername (string username, LdapLoginRequest ldapLoginRequest = null)

Log in with a username and password.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthLdapLoginUsernameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var username = "username_example";  // string | DN (distinguished name) to be used for login.
            var ldapLoginRequest = new LdapLoginRequest(); // LdapLoginRequest |  (optional) 

            try
            {
                // Log in with a username and password.
                apiInstance.PostAuthLdapLoginUsername(username, ldapLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthLdapLoginUsername: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| DN (distinguished name) to be used for login. | 
 **ldapLoginRequest** | [**LdapLoginRequest**](LdapLoginRequest.md)|  | [optional] 

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

<a name="postauthldapusersname"></a>
# **PostAuthLdapUsersName**
> void PostAuthLdapUsersName (string name, LdapUsersRequest ldapUsersRequest = null)

Manage users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthLdapUsersNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the LDAP user.
            var ldapUsersRequest = new LdapUsersRequest(); // LdapUsersRequest |  (optional) 

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.PostAuthLdapUsersName(name, ldapUsersRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthLdapUsersName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the LDAP user. | 
 **ldapUsersRequest** | [**LdapUsersRequest**](LdapUsersRequest.md)|  | [optional] 

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

<a name="postauthociconfig"></a>
# **PostAuthOciConfig**
> void PostAuthOciConfig (OciConfigRequest ociConfigRequest = null)

Manages the configuration for the Vault Auth Plugin.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthOciConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var ociConfigRequest = new OciConfigRequest(); // OciConfigRequest |  (optional) 

            try
            {
                // Manages the configuration for the Vault Auth Plugin.
                apiInstance.PostAuthOciConfig(ociConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthOciConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ociConfigRequest** | [**OciConfigRequest**](OciConfigRequest.md)|  | [optional] 

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

<a name="postauthociloginrole"></a>
# **PostAuthOciLoginRole**
> void PostAuthOciLoginRole (string role, OciLoginRequest ociLoginRequest = null)

Authenticates to Vault using OCI credentials

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthOciLoginRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var role = "role_example";  // string | Name of the role.
            var ociLoginRequest = new OciLoginRequest(); // OciLoginRequest |  (optional) 

            try
            {
                // Authenticates to Vault using OCI credentials
                apiInstance.PostAuthOciLoginRole(role, ociLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthOciLoginRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postauthocirolerole"></a>
# **PostAuthOciRoleRole**
> void PostAuthOciRoleRole (string role, OciRoleRequest ociRoleRequest = null)

Create a role and associate policies to it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthOciRoleRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var role = "role_example";  // string | Name of the role.
            var ociRoleRequest = new OciRoleRequest(); // OciRoleRequest |  (optional) 

            try
            {
                // Create a role and associate policies to it.
                apiInstance.PostAuthOciRoleRole(role, ociRoleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthOciRoleRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **ociRoleRequest** | [**OciRoleRequest**](OciRoleRequest.md)|  | [optional] 

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

<a name="postauthoidcconfig"></a>
# **PostAuthOidcConfig**
> void PostAuthOidcConfig (OidcConfigRequest oidcConfigRequest = null)

Configure the JWT authentication backend.

The JWT authentication backend validates JWTs (or OIDC) using the configured credentials. If using OIDC Discovery, the URL must be provided, along with (optionally) the CA cert to use for the connection. If performing JWT validation locally, a set of public keys must be provided.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthOidcConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var oidcConfigRequest = new OidcConfigRequest(); // OidcConfigRequest |  (optional) 

            try
            {
                // Configure the JWT authentication backend.
                apiInstance.PostAuthOidcConfig(oidcConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthOidcConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="postauthoidclogin"></a>
# **PostAuthOidcLogin**
> void PostAuthOidcLogin (OidcLoginRequest oidcLoginRequest = null)

Authenticates to Vault using a JWT (or OIDC) token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthOidcLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var oidcLoginRequest = new OidcLoginRequest(); // OidcLoginRequest |  (optional) 

            try
            {
                // Authenticates to Vault using a JWT (or OIDC) token.
                apiInstance.PostAuthOidcLogin(oidcLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthOidcLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="postauthoidcoidcauthurl"></a>
# **PostAuthOidcOidcAuthUrl**
> void PostAuthOidcOidcAuthUrl (OidcOidcAuthUrlRequest oidcOidcAuthUrlRequest = null)

Request an authorization URL to start an OIDC login flow.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthOidcOidcAuthUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var oidcOidcAuthUrlRequest = new OidcOidcAuthUrlRequest(); // OidcOidcAuthUrlRequest |  (optional) 

            try
            {
                // Request an authorization URL to start an OIDC login flow.
                apiInstance.PostAuthOidcOidcAuthUrl(oidcOidcAuthUrlRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthOidcOidcAuthUrl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="postauthoidcoidccallback"></a>
# **PostAuthOidcOidcCallback**
> void PostAuthOidcOidcCallback (OidcOidcCallbackRequest oidcOidcCallbackRequest = null)

Callback endpoint to handle form_posts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthOidcOidcCallbackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var oidcOidcCallbackRequest = new OidcOidcCallbackRequest(); // OidcOidcCallbackRequest |  (optional) 

            try
            {
                // Callback endpoint to handle form_posts.
                apiInstance.PostAuthOidcOidcCallback(oidcOidcCallbackRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthOidcOidcCallback: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="postauthoidcrolename"></a>
# **PostAuthOidcRoleName**
> void PostAuthOidcRoleName (string name, OidcRoleRequest oidcRoleRequest = null)

Register an role with the backend.

A role is required to authenticate with this backend. The role binds   JWT token information with token policies and settings.   The bindings, token polices and token settings can all be configured   using this endpoint

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthOidcRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the role.
            var oidcRoleRequest = new OidcRoleRequest(); // OidcRoleRequest |  (optional) 

            try
            {
                // Register an role with the backend.
                apiInstance.PostAuthOidcRoleName(name, oidcRoleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthOidcRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postauthoktaconfig"></a>
# **PostAuthOktaConfig**
> void PostAuthOktaConfig (OktaConfigRequest oktaConfigRequest = null)

This endpoint allows you to configure the Okta and its configuration options.  The Okta organization are the characters at the front of the URL for Okta. Example https://ORG.okta.com

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthOktaConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var oktaConfigRequest = new OktaConfigRequest(); // OktaConfigRequest |  (optional) 

            try
            {
                // This endpoint allows you to configure the Okta and its configuration options.  The Okta organization are the characters at the front of the URL for Okta. Example https://ORG.okta.com
                apiInstance.PostAuthOktaConfig(oktaConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthOktaConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oktaConfigRequest** | [**OktaConfigRequest**](OktaConfigRequest.md)|  | [optional] 

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

<a name="postauthoktagroupsname"></a>
# **PostAuthOktaGroupsName**
> void PostAuthOktaGroupsName (string name, OktaGroupsRequest oktaGroupsRequest = null)

Manage users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthOktaGroupsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the Okta group.
            var oktaGroupsRequest = new OktaGroupsRequest(); // OktaGroupsRequest |  (optional) 

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.PostAuthOktaGroupsName(name, oktaGroupsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthOktaGroupsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the Okta group. | 
 **oktaGroupsRequest** | [**OktaGroupsRequest**](OktaGroupsRequest.md)|  | [optional] 

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

<a name="postauthoktaloginusername"></a>
# **PostAuthOktaLoginUsername**
> void PostAuthOktaLoginUsername (string username, OktaLoginRequest oktaLoginRequest = null)

Log in with a username and password.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthOktaLoginUsernameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var username = "username_example";  // string | Username to be used for login.
            var oktaLoginRequest = new OktaLoginRequest(); // OktaLoginRequest |  (optional) 

            try
            {
                // Log in with a username and password.
                apiInstance.PostAuthOktaLoginUsername(username, oktaLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthOktaLoginUsername: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **oktaLoginRequest** | [**OktaLoginRequest**](OktaLoginRequest.md)|  | [optional] 

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

<a name="postauthoktausersname"></a>
# **PostAuthOktaUsersName**
> void PostAuthOktaUsersName (string name, OktaUsersRequest oktaUsersRequest = null)

Manage additional groups for users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthOktaUsersNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the user.
            var oktaUsersRequest = new OktaUsersRequest(); // OktaUsersRequest |  (optional) 

            try
            {
                // Manage additional groups for users allowed to authenticate.
                apiInstance.PostAuthOktaUsersName(name, oktaUsersRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthOktaUsersName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **oktaUsersRequest** | [**OktaUsersRequest**](OktaUsersRequest.md)|  | [optional] 

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

<a name="postauthradiusconfig"></a>
# **PostAuthRadiusConfig**
> void PostAuthRadiusConfig (RadiusConfigRequest radiusConfigRequest = null)

Configure the RADIUS server to connect to, along with its options.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthRadiusConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var radiusConfigRequest = new RadiusConfigRequest(); // RadiusConfigRequest |  (optional) 

            try
            {
                // Configure the RADIUS server to connect to, along with its options.
                apiInstance.PostAuthRadiusConfig(radiusConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthRadiusConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **radiusConfigRequest** | [**RadiusConfigRequest**](RadiusConfigRequest.md)|  | [optional] 

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

<a name="postauthradiuslogin"></a>
# **PostAuthRadiusLogin**
> void PostAuthRadiusLogin (RadiusLoginRequest radiusLoginRequest = null)

Log in with a username and password.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthRadiusLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var radiusLoginRequest = new RadiusLoginRequest(); // RadiusLoginRequest |  (optional) 

            try
            {
                // Log in with a username and password.
                apiInstance.PostAuthRadiusLogin(radiusLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthRadiusLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="postauthradiusloginurlusername"></a>
# **PostAuthRadiusLoginUrlusername**
> void PostAuthRadiusLoginUrlusername (string urlusername, RadiusLoginRequest radiusLoginRequest = null)

Log in with a username and password.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthRadiusLoginUrlusernameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var urlusername = "urlusername_example";  // string | Username to be used for login. (URL parameter)
            var radiusLoginRequest = new RadiusLoginRequest(); // RadiusLoginRequest |  (optional) 

            try
            {
                // Log in with a username and password.
                apiInstance.PostAuthRadiusLoginUrlusername(urlusername, radiusLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthRadiusLoginUrlusername: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postauthradiususersname"></a>
# **PostAuthRadiusUsersName**
> void PostAuthRadiusUsersName (string name, RadiusUsersRequest radiusUsersRequest = null)

Manage users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthRadiusUsersNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of the RADIUS user.
            var radiusUsersRequest = new RadiusUsersRequest(); // RadiusUsersRequest |  (optional) 

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.PostAuthRadiusUsersName(name, radiusUsersRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthRadiusUsersName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postauthtokencreate"></a>
# **PostAuthTokenCreate**
> void PostAuthTokenCreate ()

The token create path is used to create new tokens.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthTokenCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                // The token create path is used to create new tokens.
                apiInstance.PostAuthTokenCreate();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthTokenCreate: " + e.Message );
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

<a name="postauthtokencreateorphan"></a>
# **PostAuthTokenCreateOrphan**
> void PostAuthTokenCreateOrphan ()

The token create path is used to create new orphan tokens.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthTokenCreateOrphanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                // The token create path is used to create new orphan tokens.
                apiInstance.PostAuthTokenCreateOrphan();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthTokenCreateOrphan: " + e.Message );
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

<a name="postauthtokencreaterolename"></a>
# **PostAuthTokenCreateRoleName**
> void PostAuthTokenCreateRoleName (string roleName)

This token create path is used to create new tokens adhering to the given role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthTokenCreateRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role

            try
            {
                // This token create path is used to create new tokens adhering to the given role.
                apiInstance.PostAuthTokenCreateRoleName(roleName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthTokenCreateRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthtokenlookup"></a>
# **PostAuthTokenLookup**
> void PostAuthTokenLookup (TokenLookupRequest tokenLookupRequest = null)

This endpoint will lookup a token and its properties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthTokenLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var tokenLookupRequest = new TokenLookupRequest(); // TokenLookupRequest |  (optional) 

            try
            {
                // This endpoint will lookup a token and its properties.
                apiInstance.PostAuthTokenLookup(tokenLookupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthTokenLookup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="postauthtokenlookupaccessor"></a>
# **PostAuthTokenLookupAccessor**
> void PostAuthTokenLookupAccessor (TokenLookupAccessorRequest tokenLookupAccessorRequest = null)

This endpoint will lookup a token associated with the given accessor and its properties. Response will not contain the token ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthTokenLookupAccessorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var tokenLookupAccessorRequest = new TokenLookupAccessorRequest(); // TokenLookupAccessorRequest |  (optional) 

            try
            {
                // This endpoint will lookup a token associated with the given accessor and its properties. Response will not contain the token ID.
                apiInstance.PostAuthTokenLookupAccessor(tokenLookupAccessorRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthTokenLookupAccessor: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="postauthtokenlookupself"></a>
# **PostAuthTokenLookupSelf**
> void PostAuthTokenLookupSelf (TokenLookupSelfRequest tokenLookupSelfRequest = null)

This endpoint will lookup a token and its properties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthTokenLookupSelfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var tokenLookupSelfRequest = new TokenLookupSelfRequest(); // TokenLookupSelfRequest |  (optional) 

            try
            {
                // This endpoint will lookup a token and its properties.
                apiInstance.PostAuthTokenLookupSelf(tokenLookupSelfRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthTokenLookupSelf: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="postauthtokenrenew"></a>
# **PostAuthTokenRenew**
> void PostAuthTokenRenew (TokenRenewRequest tokenRenewRequest = null)

This endpoint will renew the given token and prevent expiration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthTokenRenewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var tokenRenewRequest = new TokenRenewRequest(); // TokenRenewRequest |  (optional) 

            try
            {
                // This endpoint will renew the given token and prevent expiration.
                apiInstance.PostAuthTokenRenew(tokenRenewRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthTokenRenew: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="postauthtokenrenewaccessor"></a>
# **PostAuthTokenRenewAccessor**
> void PostAuthTokenRenewAccessor (TokenRenewAccessorRequest tokenRenewAccessorRequest = null)

This endpoint will renew a token associated with the given accessor and its properties. Response will not contain the token ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthTokenRenewAccessorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var tokenRenewAccessorRequest = new TokenRenewAccessorRequest(); // TokenRenewAccessorRequest |  (optional) 

            try
            {
                // This endpoint will renew a token associated with the given accessor and its properties. Response will not contain the token ID.
                apiInstance.PostAuthTokenRenewAccessor(tokenRenewAccessorRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthTokenRenewAccessor: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="postauthtokenrenewself"></a>
# **PostAuthTokenRenewSelf**
> void PostAuthTokenRenewSelf (TokenRenewSelfRequest tokenRenewSelfRequest = null)

This endpoint will renew the token used to call it and prevent expiration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthTokenRenewSelfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var tokenRenewSelfRequest = new TokenRenewSelfRequest(); // TokenRenewSelfRequest |  (optional) 

            try
            {
                // This endpoint will renew the token used to call it and prevent expiration.
                apiInstance.PostAuthTokenRenewSelf(tokenRenewSelfRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthTokenRenewSelf: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="postauthtokenrevoke"></a>
# **PostAuthTokenRevoke**
> void PostAuthTokenRevoke (TokenRevokeRequest tokenRevokeRequest = null)

This endpoint will delete the given token and all of its child tokens.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthTokenRevokeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var tokenRevokeRequest = new TokenRevokeRequest(); // TokenRevokeRequest |  (optional) 

            try
            {
                // This endpoint will delete the given token and all of its child tokens.
                apiInstance.PostAuthTokenRevoke(tokenRevokeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthTokenRevoke: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="postauthtokenrevokeaccessor"></a>
# **PostAuthTokenRevokeAccessor**
> void PostAuthTokenRevokeAccessor (TokenRevokeAccessorRequest tokenRevokeAccessorRequest = null)

This endpoint will delete the token associated with the accessor and all of its child tokens.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthTokenRevokeAccessorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var tokenRevokeAccessorRequest = new TokenRevokeAccessorRequest(); // TokenRevokeAccessorRequest |  (optional) 

            try
            {
                // This endpoint will delete the token associated with the accessor and all of its child tokens.
                apiInstance.PostAuthTokenRevokeAccessor(tokenRevokeAccessorRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthTokenRevokeAccessor: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="postauthtokenrevokeorphan"></a>
# **PostAuthTokenRevokeOrphan**
> void PostAuthTokenRevokeOrphan (TokenRevokeOrphanRequest tokenRevokeOrphanRequest = null)

This endpoint will delete the token and orphan its child tokens.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthTokenRevokeOrphanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var tokenRevokeOrphanRequest = new TokenRevokeOrphanRequest(); // TokenRevokeOrphanRequest |  (optional) 

            try
            {
                // This endpoint will delete the token and orphan its child tokens.
                apiInstance.PostAuthTokenRevokeOrphan(tokenRevokeOrphanRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthTokenRevokeOrphan: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="postauthtokenrevokeself"></a>
# **PostAuthTokenRevokeSelf**
> void PostAuthTokenRevokeSelf ()

This endpoint will delete the token used to call it and all of its child tokens.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthTokenRevokeSelfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                // This endpoint will delete the token used to call it and all of its child tokens.
                apiInstance.PostAuthTokenRevokeSelf();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthTokenRevokeSelf: " + e.Message );
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

<a name="postauthtokenrolesrolename"></a>
# **PostAuthTokenRolesRoleName**
> void PostAuthTokenRolesRoleName (string roleName, TokenRolesRequest tokenRolesRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthTokenRolesRoleNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var roleName = "roleName_example";  // string | Name of the role
            var tokenRolesRequest = new TokenRolesRequest(); // TokenRolesRequest |  (optional) 

            try
            {
                apiInstance.PostAuthTokenRolesRoleName(roleName, tokenRolesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthTokenRolesRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postauthtokentidy"></a>
# **PostAuthTokenTidy**
> void PostAuthTokenTidy ()

This endpoint performs cleanup tasks that can be run if certain error conditions have occurred.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthTokenTidyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);

            try
            {
                // This endpoint performs cleanup tasks that can be run if certain error conditions have occurred.
                apiInstance.PostAuthTokenTidy();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthTokenTidy: " + e.Message );
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

<a name="postauthuserpassloginusername"></a>
# **PostAuthUserpassLoginUsername**
> void PostAuthUserpassLoginUsername (string username, UserpassLoginRequest userpassLoginRequest = null)

Log in with a username and password.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthUserpassLoginUsernameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var username = "username_example";  // string | Username of the user.
            var userpassLoginRequest = new UserpassLoginRequest(); // UserpassLoginRequest |  (optional) 

            try
            {
                // Log in with a username and password.
                apiInstance.PostAuthUserpassLoginUsername(username, userpassLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthUserpassLoginUsername: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postauthuserpassusersusername"></a>
# **PostAuthUserpassUsersUsername**
> void PostAuthUserpassUsersUsername (string username, UserpassUsersRequest userpassUsersRequest = null)

Manage users allowed to authenticate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthUserpassUsersUsernameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var username = "username_example";  // string | Username for this user.
            var userpassUsersRequest = new UserpassUsersRequest(); // UserpassUsersRequest |  (optional) 

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.PostAuthUserpassUsersUsername(username, userpassUsersRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthUserpassUsersUsername: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postauthuserpassusersusernamepassword"></a>
# **PostAuthUserpassUsersUsernamePassword**
> void PostAuthUserpassUsersUsernamePassword (string username, UserpassUsersPasswordRequest userpassUsersPasswordRequest = null)

Reset user's password.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthUserpassUsersUsernamePasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var username = "username_example";  // string | Username for this user.
            var userpassUsersPasswordRequest = new UserpassUsersPasswordRequest(); // UserpassUsersPasswordRequest |  (optional) 

            try
            {
                // Reset user's password.
                apiInstance.PostAuthUserpassUsersUsernamePassword(username, userpassUsersPasswordRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthUserpassUsersUsernamePassword: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postauthuserpassusersusernamepolicies"></a>
# **PostAuthUserpassUsersUsernamePolicies**
> void PostAuthUserpassUsersUsernamePolicies (string username, UserpassUsersPoliciesRequest userpassUsersPoliciesRequest = null)

Update the policies associated with the username.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAuthUserpassUsersUsernamePoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var username = "username_example";  // string | Username for this user.
            var userpassUsersPoliciesRequest = new UserpassUsersPoliciesRequest(); // UserpassUsersPoliciesRequest |  (optional) 

            try
            {
                // Update the policies associated with the username.
                apiInstance.PostAuthUserpassUsersUsernamePolicies(username, userpassUsersPoliciesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.PostAuthUserpassUsersUsernamePolicies: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

