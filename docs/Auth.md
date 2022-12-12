# Vault.Api.Auth

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAuthAlicloudRoleRole**](Auth.md#deleteauthalicloudrolerole) | **DELETE** /auth/{alicloud_mount_path}/role/{role} | Create a role and associate policies to it.
[**DeleteAuthApproleRoleRoleName**](Auth.md#deleteauthapprolerolerolename) | **DELETE** /auth/{approle_mount_path}/role/{role_name} | 
[**DeleteAuthApproleRoleRoleNameBindSecretId**](Auth.md#deleteauthapprolerolerolenamebindsecretid) | **DELETE** /auth/{approle_mount_path}/role/{role_name}/bind-secret-id | 
[**DeleteAuthApproleRoleRoleNameBoundCidrList**](Auth.md#deleteauthapprolerolerolenameboundcidrlist) | **DELETE** /auth/{approle_mount_path}/role/{role_name}/bound-cidr-list | 
[**DeleteAuthApproleRoleRoleNamePeriod**](Auth.md#deleteauthapprolerolerolenameperiod) | **DELETE** /auth/{approle_mount_path}/role/{role_name}/period | 
[**DeleteAuthApproleRoleRoleNamePolicies**](Auth.md#deleteauthapprolerolerolenamepolicies) | **DELETE** /auth/{approle_mount_path}/role/{role_name}/policies | 
[**DeleteAuthApproleRoleRoleNameSecretIdAccessorDestroy**](Auth.md#deleteauthapprolerolerolenamesecretidaccessordestroy) | **DELETE** /auth/{approle_mount_path}/role/{role_name}/secret-id-accessor/destroy | 
[**DeleteAuthApproleRoleRoleNameSecretIdBoundCidrs**](Auth.md#deleteauthapprolerolerolenamesecretidboundcidrs) | **DELETE** /auth/{approle_mount_path}/role/{role_name}/secret-id-bound-cidrs | 
[**DeleteAuthApproleRoleRoleNameSecretIdDestroy**](Auth.md#deleteauthapprolerolerolenamesecretiddestroy) | **DELETE** /auth/{approle_mount_path}/role/{role_name}/secret-id/destroy | 
[**DeleteAuthApproleRoleRoleNameSecretIdNumUses**](Auth.md#deleteauthapprolerolerolenamesecretidnumuses) | **DELETE** /auth/{approle_mount_path}/role/{role_name}/secret-id-num-uses | 
[**DeleteAuthApproleRoleRoleNameSecretIdTtl**](Auth.md#deleteauthapprolerolerolenamesecretidttl) | **DELETE** /auth/{approle_mount_path}/role/{role_name}/secret-id-ttl | 
[**DeleteAuthApproleRoleRoleNameTokenBoundCidrs**](Auth.md#deleteauthapprolerolerolenametokenboundcidrs) | **DELETE** /auth/{approle_mount_path}/role/{role_name}/token-bound-cidrs | 
[**DeleteAuthApproleRoleRoleNameTokenMaxTtl**](Auth.md#deleteauthapprolerolerolenametokenmaxttl) | **DELETE** /auth/{approle_mount_path}/role/{role_name}/token-max-ttl | 
[**DeleteAuthApproleRoleRoleNameTokenNumUses**](Auth.md#deleteauthapprolerolerolenametokennumuses) | **DELETE** /auth/{approle_mount_path}/role/{role_name}/token-num-uses | 
[**DeleteAuthApproleRoleRoleNameTokenTtl**](Auth.md#deleteauthapprolerolerolenametokenttl) | **DELETE** /auth/{approle_mount_path}/role/{role_name}/token-ttl | 
[**DeleteAuthAwsConfigCertificateCertName**](Auth.md#deleteauthawsconfigcertificatecertname) | **DELETE** /auth/{aws_mount_path}/config/certificate/{cert_name} | 
[**DeleteAuthAwsConfigClient**](Auth.md#deleteauthawsconfigclient) | **DELETE** /auth/{aws_mount_path}/config/client | 
[**DeleteAuthAwsConfigStsAccountId**](Auth.md#deleteauthawsconfigstsaccountid) | **DELETE** /auth/{aws_mount_path}/config/sts/{account_id} | 
[**DeleteAuthAwsConfigTidyIdentityAccesslist**](Auth.md#deleteauthawsconfigtidyidentityaccesslist) | **DELETE** /auth/{aws_mount_path}/config/tidy/identity-accesslist | 
[**DeleteAuthAwsConfigTidyIdentityWhitelist**](Auth.md#deleteauthawsconfigtidyidentitywhitelist) | **DELETE** /auth/{aws_mount_path}/config/tidy/identity-whitelist | 
[**DeleteAuthAwsConfigTidyRoletagBlacklist**](Auth.md#deleteauthawsconfigtidyroletagblacklist) | **DELETE** /auth/{aws_mount_path}/config/tidy/roletag-blacklist | 
[**DeleteAuthAwsConfigTidyRoletagDenylist**](Auth.md#deleteauthawsconfigtidyroletagdenylist) | **DELETE** /auth/{aws_mount_path}/config/tidy/roletag-denylist | 
[**DeleteAuthAwsIdentityAccesslistInstanceId**](Auth.md#deleteauthawsidentityaccesslistinstanceid) | **DELETE** /auth/{aws_mount_path}/identity-accesslist/{instance_id} | 
[**DeleteAuthAwsIdentityWhitelistInstanceId**](Auth.md#deleteauthawsidentitywhitelistinstanceid) | **DELETE** /auth/{aws_mount_path}/identity-whitelist/{instance_id} | 
[**DeleteAuthAwsRoleRole**](Auth.md#deleteauthawsrolerole) | **DELETE** /auth/{aws_mount_path}/role/{role} | 
[**DeleteAuthAwsRoletagBlacklistRoleTag**](Auth.md#deleteauthawsroletagblacklistroletag) | **DELETE** /auth/{aws_mount_path}/roletag-blacklist/{role_tag} | 
[**DeleteAuthAwsRoletagDenylistRoleTag**](Auth.md#deleteauthawsroletagdenylistroletag) | **DELETE** /auth/{aws_mount_path}/roletag-denylist/{role_tag} | 
[**DeleteAuthAzureConfig**](Auth.md#deleteauthazureconfig) | **DELETE** /auth/{azure_mount_path}/config | 
[**DeleteAuthAzureRoleName**](Auth.md#deleteauthazurerolename) | **DELETE** /auth/{azure_mount_path}/role/{name} | 
[**DeleteAuthCertCertsName**](Auth.md#deleteauthcertcertsname) | **DELETE** /auth/{cert_mount_path}/certs/{name} | Manage trusted certificates used for authentication.
[**DeleteAuthCertCrlsName**](Auth.md#deleteauthcertcrlsname) | **DELETE** /auth/{cert_mount_path}/crls/{name} | Manage Certificate Revocation Lists checked during authentication.
[**DeleteAuthCfConfig**](Auth.md#deleteauthcfconfig) | **DELETE** /auth/{cf_mount_path}/config | 
[**DeleteAuthCfRolesRole**](Auth.md#deleteauthcfrolesrole) | **DELETE** /auth/{cf_mount_path}/roles/{role} | 
[**DeleteAuthGcpRoleName**](Auth.md#deleteauthgcprolename) | **DELETE** /auth/{gcp_mount_path}/role/{name} | Create a GCP role with associated policies and required attributes.
[**DeleteAuthGithubMapTeamsKey**](Auth.md#deleteauthgithubmapteamskey) | **DELETE** /auth/{github_mount_path}/map/teams/{key} | Read/write/delete a single teams mapping
[**DeleteAuthGithubMapUsersKey**](Auth.md#deleteauthgithubmapuserskey) | **DELETE** /auth/{github_mount_path}/map/users/{key} | Read/write/delete a single users mapping
[**DeleteAuthJwtRoleName**](Auth.md#deleteauthjwtrolename) | **DELETE** /auth/{jwt_mount_path}/role/{name} | Delete an existing role.
[**DeleteAuthKerberosGroupsName**](Auth.md#deleteauthkerberosgroupsname) | **DELETE** /auth/{kerberos_mount_path}/groups/{name} | 
[**DeleteAuthKubernetesRoleName**](Auth.md#deleteauthkubernetesrolename) | **DELETE** /auth/{kubernetes_mount_path}/role/{name} | Register an role with the backend.
[**DeleteAuthLdapGroupsName**](Auth.md#deleteauthldapgroupsname) | **DELETE** /auth/{ldap_mount_path}/groups/{name} | Manage additional groups for users allowed to authenticate.
[**DeleteAuthLdapUsersName**](Auth.md#deleteauthldapusersname) | **DELETE** /auth/{ldap_mount_path}/users/{name} | Manage users allowed to authenticate.
[**DeleteAuthOciConfig**](Auth.md#deleteauthociconfig) | **DELETE** /auth/{oci_mount_path}/config | Manages the configuration for the Vault Auth Plugin.
[**DeleteAuthOciRoleRole**](Auth.md#deleteauthocirolerole) | **DELETE** /auth/{oci_mount_path}/role/{role} | Create a role and associate policies to it.
[**DeleteAuthOidcRoleName**](Auth.md#deleteauthoidcrolename) | **DELETE** /auth/{oidc_mount_path}/role/{name} | Delete an existing role.
[**DeleteAuthOktaGroupsName**](Auth.md#deleteauthoktagroupsname) | **DELETE** /auth/{okta_mount_path}/groups/{name} | Manage users allowed to authenticate.
[**DeleteAuthOktaUsersName**](Auth.md#deleteauthoktausersname) | **DELETE** /auth/{okta_mount_path}/users/{name} | Manage additional groups for users allowed to authenticate.
[**DeleteAuthRadiusUsersName**](Auth.md#deleteauthradiususersname) | **DELETE** /auth/{radius_mount_path}/users/{name} | Manage users allowed to authenticate.
[**DeleteAuthTokenRolesRoleName**](Auth.md#deleteauthtokenrolesrolename) | **DELETE** /auth/{token_mount_path}/roles/{role_name} | 
[**DeleteAuthUserpassUsersUsername**](Auth.md#deleteauthuserpassusersusername) | **DELETE** /auth/{userpass_mount_path}/users/{username} | Manage users allowed to authenticate.
[**GetAuthAlicloudRole**](Auth.md#getauthalicloudrole) | **GET** /auth/{alicloud_mount_path}/role | Lists all the roles that are registered with Vault.
[**GetAuthAlicloudRoleRole**](Auth.md#getauthalicloudrolerole) | **GET** /auth/{alicloud_mount_path}/role/{role} | Create a role and associate policies to it.
[**GetAuthAlicloudRoles**](Auth.md#getauthalicloudroles) | **GET** /auth/{alicloud_mount_path}/roles | Lists all the roles that are registered with Vault.
[**GetAuthApproleRole**](Auth.md#getauthapprolerole) | **GET** /auth/{approle_mount_path}/role | 
[**GetAuthApproleRoleRoleName**](Auth.md#getauthapprolerolerolename) | **GET** /auth/{approle_mount_path}/role/{role_name} | 
[**GetAuthApproleRoleRoleNameBindSecretId**](Auth.md#getauthapprolerolerolenamebindsecretid) | **GET** /auth/{approle_mount_path}/role/{role_name}/bind-secret-id | 
[**GetAuthApproleRoleRoleNameBoundCidrList**](Auth.md#getauthapprolerolerolenameboundcidrlist) | **GET** /auth/{approle_mount_path}/role/{role_name}/bound-cidr-list | 
[**GetAuthApproleRoleRoleNameLocalSecretIds**](Auth.md#getauthapprolerolerolenamelocalsecretids) | **GET** /auth/{approle_mount_path}/role/{role_name}/local-secret-ids | 
[**GetAuthApproleRoleRoleNamePeriod**](Auth.md#getauthapprolerolerolenameperiod) | **GET** /auth/{approle_mount_path}/role/{role_name}/period | 
[**GetAuthApproleRoleRoleNamePolicies**](Auth.md#getauthapprolerolerolenamepolicies) | **GET** /auth/{approle_mount_path}/role/{role_name}/policies | 
[**GetAuthApproleRoleRoleNameRoleId**](Auth.md#getauthapprolerolerolenameroleid) | **GET** /auth/{approle_mount_path}/role/{role_name}/role-id | 
[**GetAuthApproleRoleRoleNameSecretId**](Auth.md#getauthapprolerolerolenamesecretid) | **GET** /auth/{approle_mount_path}/role/{role_name}/secret-id | 
[**GetAuthApproleRoleRoleNameSecretIdBoundCidrs**](Auth.md#getauthapprolerolerolenamesecretidboundcidrs) | **GET** /auth/{approle_mount_path}/role/{role_name}/secret-id-bound-cidrs | 
[**GetAuthApproleRoleRoleNameSecretIdNumUses**](Auth.md#getauthapprolerolerolenamesecretidnumuses) | **GET** /auth/{approle_mount_path}/role/{role_name}/secret-id-num-uses | 
[**GetAuthApproleRoleRoleNameSecretIdTtl**](Auth.md#getauthapprolerolerolenamesecretidttl) | **GET** /auth/{approle_mount_path}/role/{role_name}/secret-id-ttl | 
[**GetAuthApproleRoleRoleNameTokenBoundCidrs**](Auth.md#getauthapprolerolerolenametokenboundcidrs) | **GET** /auth/{approle_mount_path}/role/{role_name}/token-bound-cidrs | 
[**GetAuthApproleRoleRoleNameTokenMaxTtl**](Auth.md#getauthapprolerolerolenametokenmaxttl) | **GET** /auth/{approle_mount_path}/role/{role_name}/token-max-ttl | 
[**GetAuthApproleRoleRoleNameTokenNumUses**](Auth.md#getauthapprolerolerolenametokennumuses) | **GET** /auth/{approle_mount_path}/role/{role_name}/token-num-uses | 
[**GetAuthApproleRoleRoleNameTokenTtl**](Auth.md#getauthapprolerolerolenametokenttl) | **GET** /auth/{approle_mount_path}/role/{role_name}/token-ttl | 
[**GetAuthAwsConfigCertificateCertName**](Auth.md#getauthawsconfigcertificatecertname) | **GET** /auth/{aws_mount_path}/config/certificate/{cert_name} | 
[**GetAuthAwsConfigCertificates**](Auth.md#getauthawsconfigcertificates) | **GET** /auth/{aws_mount_path}/config/certificates | 
[**GetAuthAwsConfigClient**](Auth.md#getauthawsconfigclient) | **GET** /auth/{aws_mount_path}/config/client | 
[**GetAuthAwsConfigIdentity**](Auth.md#getauthawsconfigidentity) | **GET** /auth/{aws_mount_path}/config/identity | 
[**GetAuthAwsConfigSts**](Auth.md#getauthawsconfigsts) | **GET** /auth/{aws_mount_path}/config/sts | 
[**GetAuthAwsConfigStsAccountId**](Auth.md#getauthawsconfigstsaccountid) | **GET** /auth/{aws_mount_path}/config/sts/{account_id} | 
[**GetAuthAwsConfigTidyIdentityAccesslist**](Auth.md#getauthawsconfigtidyidentityaccesslist) | **GET** /auth/{aws_mount_path}/config/tidy/identity-accesslist | 
[**GetAuthAwsConfigTidyIdentityWhitelist**](Auth.md#getauthawsconfigtidyidentitywhitelist) | **GET** /auth/{aws_mount_path}/config/tidy/identity-whitelist | 
[**GetAuthAwsConfigTidyRoletagBlacklist**](Auth.md#getauthawsconfigtidyroletagblacklist) | **GET** /auth/{aws_mount_path}/config/tidy/roletag-blacklist | 
[**GetAuthAwsConfigTidyRoletagDenylist**](Auth.md#getauthawsconfigtidyroletagdenylist) | **GET** /auth/{aws_mount_path}/config/tidy/roletag-denylist | 
[**GetAuthAwsIdentityAccesslist**](Auth.md#getauthawsidentityaccesslist) | **GET** /auth/{aws_mount_path}/identity-accesslist | 
[**GetAuthAwsIdentityAccesslistInstanceId**](Auth.md#getauthawsidentityaccesslistinstanceid) | **GET** /auth/{aws_mount_path}/identity-accesslist/{instance_id} | 
[**GetAuthAwsIdentityWhitelist**](Auth.md#getauthawsidentitywhitelist) | **GET** /auth/{aws_mount_path}/identity-whitelist | 
[**GetAuthAwsIdentityWhitelistInstanceId**](Auth.md#getauthawsidentitywhitelistinstanceid) | **GET** /auth/{aws_mount_path}/identity-whitelist/{instance_id} | 
[**GetAuthAwsRole**](Auth.md#getauthawsrole) | **GET** /auth/{aws_mount_path}/role | 
[**GetAuthAwsRoleRole**](Auth.md#getauthawsrolerole) | **GET** /auth/{aws_mount_path}/role/{role} | 
[**GetAuthAwsRoles**](Auth.md#getauthawsroles) | **GET** /auth/{aws_mount_path}/roles | 
[**GetAuthAwsRoletagBlacklist**](Auth.md#getauthawsroletagblacklist) | **GET** /auth/{aws_mount_path}/roletag-blacklist | 
[**GetAuthAwsRoletagBlacklistRoleTag**](Auth.md#getauthawsroletagblacklistroletag) | **GET** /auth/{aws_mount_path}/roletag-blacklist/{role_tag} | 
[**GetAuthAwsRoletagDenylist**](Auth.md#getauthawsroletagdenylist) | **GET** /auth/{aws_mount_path}/roletag-denylist | 
[**GetAuthAwsRoletagDenylistRoleTag**](Auth.md#getauthawsroletagdenylistroletag) | **GET** /auth/{aws_mount_path}/roletag-denylist/{role_tag} | 
[**GetAuthAzureConfig**](Auth.md#getauthazureconfig) | **GET** /auth/{azure_mount_path}/config | 
[**GetAuthAzureRole**](Auth.md#getauthazurerole) | **GET** /auth/{azure_mount_path}/role | 
[**GetAuthAzureRoleName**](Auth.md#getauthazurerolename) | **GET** /auth/{azure_mount_path}/role/{name} | 
[**GetAuthCentrifyConfig**](Auth.md#getauthcentrifyconfig) | **GET** /auth/{centrify_mount_path}/config | This path allows you to configure the centrify auth provider to interact with the Centrify Identity Services Platform for authenticating users.
[**GetAuthCertCerts**](Auth.md#getauthcertcerts) | **GET** /auth/{cert_mount_path}/certs | Manage trusted certificates used for authentication.
[**GetAuthCertCertsName**](Auth.md#getauthcertcertsname) | **GET** /auth/{cert_mount_path}/certs/{name} | Manage trusted certificates used for authentication.
[**GetAuthCertConfig**](Auth.md#getauthcertconfig) | **GET** /auth/{cert_mount_path}/config | 
[**GetAuthCertCrls**](Auth.md#getauthcertcrls) | **GET** /auth/{cert_mount_path}/crls | 
[**GetAuthCertCrlsName**](Auth.md#getauthcertcrlsname) | **GET** /auth/{cert_mount_path}/crls/{name} | Manage Certificate Revocation Lists checked during authentication.
[**GetAuthCfConfig**](Auth.md#getauthcfconfig) | **GET** /auth/{cf_mount_path}/config | 
[**GetAuthCfRoles**](Auth.md#getauthcfroles) | **GET** /auth/{cf_mount_path}/roles | 
[**GetAuthCfRolesRole**](Auth.md#getauthcfrolesrole) | **GET** /auth/{cf_mount_path}/roles/{role} | 
[**GetAuthGcpConfig**](Auth.md#getauthgcpconfig) | **GET** /auth/{gcp_mount_path}/config | Configure credentials used to query the GCP IAM API to verify authenticating service accounts
[**GetAuthGcpRole**](Auth.md#getauthgcprole) | **GET** /auth/{gcp_mount_path}/role | Lists all the roles that are registered with Vault.
[**GetAuthGcpRoleName**](Auth.md#getauthgcprolename) | **GET** /auth/{gcp_mount_path}/role/{name} | Create a GCP role with associated policies and required attributes.
[**GetAuthGcpRoles**](Auth.md#getauthgcproles) | **GET** /auth/{gcp_mount_path}/roles | Lists all the roles that are registered with Vault.
[**GetAuthGithubConfig**](Auth.md#getauthgithubconfig) | **GET** /auth/{github_mount_path}/config | 
[**GetAuthGithubMapTeams**](Auth.md#getauthgithubmapteams) | **GET** /auth/{github_mount_path}/map/teams | Read mappings for teams
[**GetAuthGithubMapTeamsKey**](Auth.md#getauthgithubmapteamskey) | **GET** /auth/{github_mount_path}/map/teams/{key} | Read/write/delete a single teams mapping
[**GetAuthGithubMapUsers**](Auth.md#getauthgithubmapusers) | **GET** /auth/{github_mount_path}/map/users | Read mappings for users
[**GetAuthGithubMapUsersKey**](Auth.md#getauthgithubmapuserskey) | **GET** /auth/{github_mount_path}/map/users/{key} | Read/write/delete a single users mapping
[**GetAuthJwtConfig**](Auth.md#getauthjwtconfig) | **GET** /auth/{jwt_mount_path}/config | Read the current JWT authentication backend configuration.
[**GetAuthJwtOidcCallback**](Auth.md#getauthjwtoidccallback) | **GET** /auth/{jwt_mount_path}/oidc/callback | Callback endpoint to complete an OIDC login.
[**GetAuthJwtRole**](Auth.md#getauthjwtrole) | **GET** /auth/{jwt_mount_path}/role | Lists all the roles registered with the backend.
[**GetAuthJwtRoleName**](Auth.md#getauthjwtrolename) | **GET** /auth/{jwt_mount_path}/role/{name} | Read an existing role.
[**GetAuthKerberosConfig**](Auth.md#getauthkerberosconfig) | **GET** /auth/{kerberos_mount_path}/config | 
[**GetAuthKerberosConfigLdap**](Auth.md#getauthkerberosconfigldap) | **GET** /auth/{kerberos_mount_path}/config/ldap | 
[**GetAuthKerberosGroups**](Auth.md#getauthkerberosgroups) | **GET** /auth/{kerberos_mount_path}/groups | 
[**GetAuthKerberosGroupsName**](Auth.md#getauthkerberosgroupsname) | **GET** /auth/{kerberos_mount_path}/groups/{name} | 
[**GetAuthKerberosLogin**](Auth.md#getauthkerberoslogin) | **GET** /auth/{kerberos_mount_path}/login | 
[**GetAuthKubernetesConfig**](Auth.md#getauthkubernetesconfig) | **GET** /auth/{kubernetes_mount_path}/config | Configures the JWT Public Key and Kubernetes API information.
[**GetAuthKubernetesRole**](Auth.md#getauthkubernetesrole) | **GET** /auth/{kubernetes_mount_path}/role | Lists all the roles registered with the backend.
[**GetAuthKubernetesRoleName**](Auth.md#getauthkubernetesrolename) | **GET** /auth/{kubernetes_mount_path}/role/{name} | Register an role with the backend.
[**GetAuthLdapConfig**](Auth.md#getauthldapconfig) | **GET** /auth/{ldap_mount_path}/config | Configure the LDAP server to connect to, along with its options.
[**GetAuthLdapGroups**](Auth.md#getauthldapgroups) | **GET** /auth/{ldap_mount_path}/groups | Manage additional groups for users allowed to authenticate.
[**GetAuthLdapGroupsName**](Auth.md#getauthldapgroupsname) | **GET** /auth/{ldap_mount_path}/groups/{name} | Manage additional groups for users allowed to authenticate.
[**GetAuthLdapUsers**](Auth.md#getauthldapusers) | **GET** /auth/{ldap_mount_path}/users | Manage users allowed to authenticate.
[**GetAuthLdapUsersName**](Auth.md#getauthldapusersname) | **GET** /auth/{ldap_mount_path}/users/{name} | Manage users allowed to authenticate.
[**GetAuthOciConfig**](Auth.md#getauthociconfig) | **GET** /auth/{oci_mount_path}/config | Manages the configuration for the Vault Auth Plugin.
[**GetAuthOciRole**](Auth.md#getauthocirole) | **GET** /auth/{oci_mount_path}/role | Lists all the roles that are registered with Vault.
[**GetAuthOciRoleRole**](Auth.md#getauthocirolerole) | **GET** /auth/{oci_mount_path}/role/{role} | Create a role and associate policies to it.
[**GetAuthOidcConfig**](Auth.md#getauthoidcconfig) | **GET** /auth/{oidc_mount_path}/config | Read the current JWT authentication backend configuration.
[**GetAuthOidcOidcCallback**](Auth.md#getauthoidcoidccallback) | **GET** /auth/{oidc_mount_path}/oidc/callback | Callback endpoint to complete an OIDC login.
[**GetAuthOidcRole**](Auth.md#getauthoidcrole) | **GET** /auth/{oidc_mount_path}/role | Lists all the roles registered with the backend.
[**GetAuthOidcRoleName**](Auth.md#getauthoidcrolename) | **GET** /auth/{oidc_mount_path}/role/{name} | Read an existing role.
[**GetAuthOktaConfig**](Auth.md#getauthoktaconfig) | **GET** /auth/{okta_mount_path}/config | This endpoint allows you to configure the Okta and its configuration options.  The Okta organization are the characters at the front of the URL for Okta. Example https://ORG.okta.com
[**GetAuthOktaGroups**](Auth.md#getauthoktagroups) | **GET** /auth/{okta_mount_path}/groups | Manage users allowed to authenticate.
[**GetAuthOktaGroupsName**](Auth.md#getauthoktagroupsname) | **GET** /auth/{okta_mount_path}/groups/{name} | Manage users allowed to authenticate.
[**GetAuthOktaUsers**](Auth.md#getauthoktausers) | **GET** /auth/{okta_mount_path}/users | Manage additional groups for users allowed to authenticate.
[**GetAuthOktaUsersName**](Auth.md#getauthoktausersname) | **GET** /auth/{okta_mount_path}/users/{name} | Manage additional groups for users allowed to authenticate.
[**GetAuthOktaVerifyNonce**](Auth.md#getauthoktaverifynonce) | **GET** /auth/{okta_mount_path}/verify/{nonce} | 
[**GetAuthRadiusConfig**](Auth.md#getauthradiusconfig) | **GET** /auth/{radius_mount_path}/config | Configure the RADIUS server to connect to, along with its options.
[**GetAuthRadiusUsers**](Auth.md#getauthradiususers) | **GET** /auth/{radius_mount_path}/users | Manage users allowed to authenticate.
[**GetAuthRadiusUsersName**](Auth.md#getauthradiususersname) | **GET** /auth/{radius_mount_path}/users/{name} | Manage users allowed to authenticate.
[**GetAuthTokenAccessors**](Auth.md#getauthtokenaccessors) | **GET** /auth/{token_mount_path}/accessors/ | List token accessors, which can then be be used to iterate and discover their properties or revoke them. Because this can be used to cause a denial of service, this endpoint requires &#39;sudo&#39; capability in addition to &#39;list&#39;.
[**GetAuthTokenLookup**](Auth.md#getauthtokenlookup) | **GET** /auth/{token_mount_path}/lookup | This endpoint will lookup a token and its properties.
[**GetAuthTokenLookupSelf**](Auth.md#getauthtokenlookupself) | **GET** /auth/{token_mount_path}/lookup-self | This endpoint will lookup a token and its properties.
[**GetAuthTokenRoles**](Auth.md#getauthtokenroles) | **GET** /auth/{token_mount_path}/roles | This endpoint lists configured roles.
[**GetAuthTokenRolesRoleName**](Auth.md#getauthtokenrolesrolename) | **GET** /auth/{token_mount_path}/roles/{role_name} | 
[**GetAuthUserpassUsers**](Auth.md#getauthuserpassusers) | **GET** /auth/{userpass_mount_path}/users | Manage users allowed to authenticate.
[**GetAuthUserpassUsersUsername**](Auth.md#getauthuserpassusersusername) | **GET** /auth/{userpass_mount_path}/users/{username} | Manage users allowed to authenticate.
[**PostAuthAlicloudLogin**](Auth.md#postauthalicloudlogin) | **POST** /auth/{alicloud_mount_path}/login | Authenticates an RAM entity with Vault.
[**PostAuthAlicloudRoleRole**](Auth.md#postauthalicloudrolerole) | **POST** /auth/{alicloud_mount_path}/role/{role} | Create a role and associate policies to it.
[**PostAuthApproleLogin**](Auth.md#postauthapprolelogin) | **POST** /auth/{approle_mount_path}/login | 
[**PostAuthApproleRoleRoleName**](Auth.md#postauthapprolerolerolename) | **POST** /auth/{approle_mount_path}/role/{role_name} | 
[**PostAuthApproleRoleRoleNameBindSecretId**](Auth.md#postauthapprolerolerolenamebindsecretid) | **POST** /auth/{approle_mount_path}/role/{role_name}/bind-secret-id | 
[**PostAuthApproleRoleRoleNameBoundCidrList**](Auth.md#postauthapprolerolerolenameboundcidrlist) | **POST** /auth/{approle_mount_path}/role/{role_name}/bound-cidr-list | 
[**PostAuthApproleRoleRoleNameCustomSecretId**](Auth.md#postauthapprolerolerolenamecustomsecretid) | **POST** /auth/{approle_mount_path}/role/{role_name}/custom-secret-id | 
[**PostAuthApproleRoleRoleNamePeriod**](Auth.md#postauthapprolerolerolenameperiod) | **POST** /auth/{approle_mount_path}/role/{role_name}/period | 
[**PostAuthApproleRoleRoleNamePolicies**](Auth.md#postauthapprolerolerolenamepolicies) | **POST** /auth/{approle_mount_path}/role/{role_name}/policies | 
[**PostAuthApproleRoleRoleNameRoleId**](Auth.md#postauthapprolerolerolenameroleid) | **POST** /auth/{approle_mount_path}/role/{role_name}/role-id | 
[**PostAuthApproleRoleRoleNameSecretId**](Auth.md#postauthapprolerolerolenamesecretid) | **POST** /auth/{approle_mount_path}/role/{role_name}/secret-id | 
[**PostAuthApproleRoleRoleNameSecretIdAccessorDestroy**](Auth.md#postauthapprolerolerolenamesecretidaccessordestroy) | **POST** /auth/{approle_mount_path}/role/{role_name}/secret-id-accessor/destroy | 
[**PostAuthApproleRoleRoleNameSecretIdAccessorLookup**](Auth.md#postauthapprolerolerolenamesecretidaccessorlookup) | **POST** /auth/{approle_mount_path}/role/{role_name}/secret-id-accessor/lookup | 
[**PostAuthApproleRoleRoleNameSecretIdBoundCidrs**](Auth.md#postauthapprolerolerolenamesecretidboundcidrs) | **POST** /auth/{approle_mount_path}/role/{role_name}/secret-id-bound-cidrs | 
[**PostAuthApproleRoleRoleNameSecretIdDestroy**](Auth.md#postauthapprolerolerolenamesecretiddestroy) | **POST** /auth/{approle_mount_path}/role/{role_name}/secret-id/destroy | 
[**PostAuthApproleRoleRoleNameSecretIdLookup**](Auth.md#postauthapprolerolerolenamesecretidlookup) | **POST** /auth/{approle_mount_path}/role/{role_name}/secret-id/lookup | 
[**PostAuthApproleRoleRoleNameSecretIdNumUses**](Auth.md#postauthapprolerolerolenamesecretidnumuses) | **POST** /auth/{approle_mount_path}/role/{role_name}/secret-id-num-uses | 
[**PostAuthApproleRoleRoleNameSecretIdTtl**](Auth.md#postauthapprolerolerolenamesecretidttl) | **POST** /auth/{approle_mount_path}/role/{role_name}/secret-id-ttl | 
[**PostAuthApproleRoleRoleNameTokenBoundCidrs**](Auth.md#postauthapprolerolerolenametokenboundcidrs) | **POST** /auth/{approle_mount_path}/role/{role_name}/token-bound-cidrs | 
[**PostAuthApproleRoleRoleNameTokenMaxTtl**](Auth.md#postauthapprolerolerolenametokenmaxttl) | **POST** /auth/{approle_mount_path}/role/{role_name}/token-max-ttl | 
[**PostAuthApproleRoleRoleNameTokenNumUses**](Auth.md#postauthapprolerolerolenametokennumuses) | **POST** /auth/{approle_mount_path}/role/{role_name}/token-num-uses | 
[**PostAuthApproleRoleRoleNameTokenTtl**](Auth.md#postauthapprolerolerolenametokenttl) | **POST** /auth/{approle_mount_path}/role/{role_name}/token-ttl | 
[**PostAuthApproleTidySecretId**](Auth.md#postauthapproletidysecretid) | **POST** /auth/{approle_mount_path}/tidy/secret-id | Trigger the clean-up of expired SecretID entries.
[**PostAuthAwsConfigCertificateCertName**](Auth.md#postauthawsconfigcertificatecertname) | **POST** /auth/{aws_mount_path}/config/certificate/{cert_name} | 
[**PostAuthAwsConfigClient**](Auth.md#postauthawsconfigclient) | **POST** /auth/{aws_mount_path}/config/client | 
[**PostAuthAwsConfigIdentity**](Auth.md#postauthawsconfigidentity) | **POST** /auth/{aws_mount_path}/config/identity | 
[**PostAuthAwsConfigRotateRoot**](Auth.md#postauthawsconfigrotateroot) | **POST** /auth/{aws_mount_path}/config/rotate-root | 
[**PostAuthAwsConfigStsAccountId**](Auth.md#postauthawsconfigstsaccountid) | **POST** /auth/{aws_mount_path}/config/sts/{account_id} | 
[**PostAuthAwsConfigTidyIdentityAccesslist**](Auth.md#postauthawsconfigtidyidentityaccesslist) | **POST** /auth/{aws_mount_path}/config/tidy/identity-accesslist | 
[**PostAuthAwsConfigTidyIdentityWhitelist**](Auth.md#postauthawsconfigtidyidentitywhitelist) | **POST** /auth/{aws_mount_path}/config/tidy/identity-whitelist | 
[**PostAuthAwsConfigTidyRoletagBlacklist**](Auth.md#postauthawsconfigtidyroletagblacklist) | **POST** /auth/{aws_mount_path}/config/tidy/roletag-blacklist | 
[**PostAuthAwsConfigTidyRoletagDenylist**](Auth.md#postauthawsconfigtidyroletagdenylist) | **POST** /auth/{aws_mount_path}/config/tidy/roletag-denylist | 
[**PostAuthAwsLogin**](Auth.md#postauthawslogin) | **POST** /auth/{aws_mount_path}/login | 
[**PostAuthAwsRoleRole**](Auth.md#postauthawsrolerole) | **POST** /auth/{aws_mount_path}/role/{role} | 
[**PostAuthAwsRoleRoleTag**](Auth.md#postauthawsroleroletag) | **POST** /auth/{aws_mount_path}/role/{role}/tag | 
[**PostAuthAwsRoletagBlacklistRoleTag**](Auth.md#postauthawsroletagblacklistroletag) | **POST** /auth/{aws_mount_path}/roletag-blacklist/{role_tag} | 
[**PostAuthAwsRoletagDenylistRoleTag**](Auth.md#postauthawsroletagdenylistroletag) | **POST** /auth/{aws_mount_path}/roletag-denylist/{role_tag} | 
[**PostAuthAwsTidyIdentityAccesslist**](Auth.md#postauthawstidyidentityaccesslist) | **POST** /auth/{aws_mount_path}/tidy/identity-accesslist | 
[**PostAuthAwsTidyIdentityWhitelist**](Auth.md#postauthawstidyidentitywhitelist) | **POST** /auth/{aws_mount_path}/tidy/identity-whitelist | 
[**PostAuthAwsTidyRoletagBlacklist**](Auth.md#postauthawstidyroletagblacklist) | **POST** /auth/{aws_mount_path}/tidy/roletag-blacklist | 
[**PostAuthAwsTidyRoletagDenylist**](Auth.md#postauthawstidyroletagdenylist) | **POST** /auth/{aws_mount_path}/tidy/roletag-denylist | 
[**PostAuthAzureConfig**](Auth.md#postauthazureconfig) | **POST** /auth/{azure_mount_path}/config | 
[**PostAuthAzureLogin**](Auth.md#postauthazurelogin) | **POST** /auth/{azure_mount_path}/login | 
[**PostAuthAzureRoleName**](Auth.md#postauthazurerolename) | **POST** /auth/{azure_mount_path}/role/{name} | 
[**PostAuthCentrifyConfig**](Auth.md#postauthcentrifyconfig) | **POST** /auth/{centrify_mount_path}/config | This path allows you to configure the centrify auth provider to interact with the Centrify Identity Services Platform for authenticating users.
[**PostAuthCentrifyLogin**](Auth.md#postauthcentrifylogin) | **POST** /auth/{centrify_mount_path}/login | Log in with a username and password.
[**PostAuthCertCertsName**](Auth.md#postauthcertcertsname) | **POST** /auth/{cert_mount_path}/certs/{name} | Manage trusted certificates used for authentication.
[**PostAuthCertConfig**](Auth.md#postauthcertconfig) | **POST** /auth/{cert_mount_path}/config | 
[**PostAuthCertCrlsName**](Auth.md#postauthcertcrlsname) | **POST** /auth/{cert_mount_path}/crls/{name} | Manage Certificate Revocation Lists checked during authentication.
[**PostAuthCertLogin**](Auth.md#postauthcertlogin) | **POST** /auth/{cert_mount_path}/login | 
[**PostAuthCfConfig**](Auth.md#postauthcfconfig) | **POST** /auth/{cf_mount_path}/config | 
[**PostAuthCfLogin**](Auth.md#postauthcflogin) | **POST** /auth/{cf_mount_path}/login | 
[**PostAuthCfRolesRole**](Auth.md#postauthcfrolesrole) | **POST** /auth/{cf_mount_path}/roles/{role} | 
[**PostAuthGcpConfig**](Auth.md#postauthgcpconfig) | **POST** /auth/{gcp_mount_path}/config | Configure credentials used to query the GCP IAM API to verify authenticating service accounts
[**PostAuthGcpLogin**](Auth.md#postauthgcplogin) | **POST** /auth/{gcp_mount_path}/login | 
[**PostAuthGcpRoleName**](Auth.md#postauthgcprolename) | **POST** /auth/{gcp_mount_path}/role/{name} | Create a GCP role with associated policies and required attributes.
[**PostAuthGcpRoleNameLabels**](Auth.md#postauthgcprolenamelabels) | **POST** /auth/{gcp_mount_path}/role/{name}/labels | Add or remove labels for an existing &#39;gce&#39; role
[**PostAuthGcpRoleNameServiceAccounts**](Auth.md#postauthgcprolenameserviceaccounts) | **POST** /auth/{gcp_mount_path}/role/{name}/service-accounts | Add or remove service accounts for an existing &#x60;iam&#x60; role
[**PostAuthGithubConfig**](Auth.md#postauthgithubconfig) | **POST** /auth/{github_mount_path}/config | 
[**PostAuthGithubLogin**](Auth.md#postauthgithublogin) | **POST** /auth/{github_mount_path}/login | 
[**PostAuthGithubMapTeamsKey**](Auth.md#postauthgithubmapteamskey) | **POST** /auth/{github_mount_path}/map/teams/{key} | Read/write/delete a single teams mapping
[**PostAuthGithubMapUsersKey**](Auth.md#postauthgithubmapuserskey) | **POST** /auth/{github_mount_path}/map/users/{key} | Read/write/delete a single users mapping
[**PostAuthJwtConfig**](Auth.md#postauthjwtconfig) | **POST** /auth/{jwt_mount_path}/config | Configure the JWT authentication backend.
[**PostAuthJwtLogin**](Auth.md#postauthjwtlogin) | **POST** /auth/{jwt_mount_path}/login | Authenticates to Vault using a JWT (or OIDC) token.
[**PostAuthJwtOidcAuthUrl**](Auth.md#postauthjwtoidcauthurl) | **POST** /auth/{jwt_mount_path}/oidc/auth_url | Request an authorization URL to start an OIDC login flow.
[**PostAuthJwtOidcCallback**](Auth.md#postauthjwtoidccallback) | **POST** /auth/{jwt_mount_path}/oidc/callback | Callback endpoint to handle form_posts.
[**PostAuthJwtRoleName**](Auth.md#postauthjwtrolename) | **POST** /auth/{jwt_mount_path}/role/{name} | Register an role with the backend.
[**PostAuthKerberosConfig**](Auth.md#postauthkerberosconfig) | **POST** /auth/{kerberos_mount_path}/config | 
[**PostAuthKerberosConfigLdap**](Auth.md#postauthkerberosconfigldap) | **POST** /auth/{kerberos_mount_path}/config/ldap | 
[**PostAuthKerberosGroupsName**](Auth.md#postauthkerberosgroupsname) | **POST** /auth/{kerberos_mount_path}/groups/{name} | 
[**PostAuthKerberosLogin**](Auth.md#postauthkerberoslogin) | **POST** /auth/{kerberos_mount_path}/login | 
[**PostAuthKubernetesConfig**](Auth.md#postauthkubernetesconfig) | **POST** /auth/{kubernetes_mount_path}/config | Configures the JWT Public Key and Kubernetes API information.
[**PostAuthKubernetesLogin**](Auth.md#postauthkuberneteslogin) | **POST** /auth/{kubernetes_mount_path}/login | Authenticates Kubernetes service accounts with Vault.
[**PostAuthKubernetesRoleName**](Auth.md#postauthkubernetesrolename) | **POST** /auth/{kubernetes_mount_path}/role/{name} | Register an role with the backend.
[**PostAuthLdapConfig**](Auth.md#postauthldapconfig) | **POST** /auth/{ldap_mount_path}/config | Configure the LDAP server to connect to, along with its options.
[**PostAuthLdapGroupsName**](Auth.md#postauthldapgroupsname) | **POST** /auth/{ldap_mount_path}/groups/{name} | Manage additional groups for users allowed to authenticate.
[**PostAuthLdapLoginUsername**](Auth.md#postauthldaploginusername) | **POST** /auth/{ldap_mount_path}/login/{username} | Log in with a username and password.
[**PostAuthLdapUsersName**](Auth.md#postauthldapusersname) | **POST** /auth/{ldap_mount_path}/users/{name} | Manage users allowed to authenticate.
[**PostAuthOciConfig**](Auth.md#postauthociconfig) | **POST** /auth/{oci_mount_path}/config | Manages the configuration for the Vault Auth Plugin.
[**PostAuthOciLoginRole**](Auth.md#postauthociloginrole) | **POST** /auth/{oci_mount_path}/login/{role} | Authenticates to Vault using OCI credentials
[**PostAuthOciRoleRole**](Auth.md#postauthocirolerole) | **POST** /auth/{oci_mount_path}/role/{role} | Create a role and associate policies to it.
[**PostAuthOidcConfig**](Auth.md#postauthoidcconfig) | **POST** /auth/{oidc_mount_path}/config | Configure the JWT authentication backend.
[**PostAuthOidcLogin**](Auth.md#postauthoidclogin) | **POST** /auth/{oidc_mount_path}/login | Authenticates to Vault using a JWT (or OIDC) token.
[**PostAuthOidcOidcAuthUrl**](Auth.md#postauthoidcoidcauthurl) | **POST** /auth/{oidc_mount_path}/oidc/auth_url | Request an authorization URL to start an OIDC login flow.
[**PostAuthOidcOidcCallback**](Auth.md#postauthoidcoidccallback) | **POST** /auth/{oidc_mount_path}/oidc/callback | Callback endpoint to handle form_posts.
[**PostAuthOidcRoleName**](Auth.md#postauthoidcrolename) | **POST** /auth/{oidc_mount_path}/role/{name} | Register an role with the backend.
[**PostAuthOktaConfig**](Auth.md#postauthoktaconfig) | **POST** /auth/{okta_mount_path}/config | This endpoint allows you to configure the Okta and its configuration options.  The Okta organization are the characters at the front of the URL for Okta. Example https://ORG.okta.com
[**PostAuthOktaGroupsName**](Auth.md#postauthoktagroupsname) | **POST** /auth/{okta_mount_path}/groups/{name} | Manage users allowed to authenticate.
[**PostAuthOktaLoginUsername**](Auth.md#postauthoktaloginusername) | **POST** /auth/{okta_mount_path}/login/{username} | Log in with a username and password.
[**PostAuthOktaUsersName**](Auth.md#postauthoktausersname) | **POST** /auth/{okta_mount_path}/users/{name} | Manage additional groups for users allowed to authenticate.
[**PostAuthRadiusConfig**](Auth.md#postauthradiusconfig) | **POST** /auth/{radius_mount_path}/config | Configure the RADIUS server to connect to, along with its options.
[**PostAuthRadiusLogin**](Auth.md#postauthradiuslogin) | **POST** /auth/{radius_mount_path}/login | Log in with a username and password.
[**PostAuthRadiusLoginUrlusername**](Auth.md#postauthradiusloginurlusername) | **POST** /auth/{radius_mount_path}/login/{urlusername} | Log in with a username and password.
[**PostAuthRadiusUsersName**](Auth.md#postauthradiususersname) | **POST** /auth/{radius_mount_path}/users/{name} | Manage users allowed to authenticate.
[**PostAuthTokenCreate**](Auth.md#postauthtokencreate) | **POST** /auth/{token_mount_path}/create | The token create path is used to create new tokens.
[**PostAuthTokenCreateOrphan**](Auth.md#postauthtokencreateorphan) | **POST** /auth/{token_mount_path}/create-orphan | The token create path is used to create new orphan tokens.
[**PostAuthTokenCreateRoleName**](Auth.md#postauthtokencreaterolename) | **POST** /auth/{token_mount_path}/create/{role_name} | This token create path is used to create new tokens adhering to the given role.
[**PostAuthTokenLookup**](Auth.md#postauthtokenlookup) | **POST** /auth/{token_mount_path}/lookup | This endpoint will lookup a token and its properties.
[**PostAuthTokenLookupAccessor**](Auth.md#postauthtokenlookupaccessor) | **POST** /auth/{token_mount_path}/lookup-accessor | This endpoint will lookup a token associated with the given accessor and its properties. Response will not contain the token ID.
[**PostAuthTokenLookupSelf**](Auth.md#postauthtokenlookupself) | **POST** /auth/{token_mount_path}/lookup-self | This endpoint will lookup a token and its properties.
[**PostAuthTokenRenew**](Auth.md#postauthtokenrenew) | **POST** /auth/{token_mount_path}/renew | This endpoint will renew the given token and prevent expiration.
[**PostAuthTokenRenewAccessor**](Auth.md#postauthtokenrenewaccessor) | **POST** /auth/{token_mount_path}/renew-accessor | This endpoint will renew a token associated with the given accessor and its properties. Response will not contain the token ID.
[**PostAuthTokenRenewSelf**](Auth.md#postauthtokenrenewself) | **POST** /auth/{token_mount_path}/renew-self | This endpoint will renew the token used to call it and prevent expiration.
[**PostAuthTokenRevoke**](Auth.md#postauthtokenrevoke) | **POST** /auth/{token_mount_path}/revoke | This endpoint will delete the given token and all of its child tokens.
[**PostAuthTokenRevokeAccessor**](Auth.md#postauthtokenrevokeaccessor) | **POST** /auth/{token_mount_path}/revoke-accessor | This endpoint will delete the token associated with the accessor and all of its child tokens.
[**PostAuthTokenRevokeOrphan**](Auth.md#postauthtokenrevokeorphan) | **POST** /auth/{token_mount_path}/revoke-orphan | This endpoint will delete the token and orphan its child tokens.
[**PostAuthTokenRevokeSelf**](Auth.md#postauthtokenrevokeself) | **POST** /auth/{token_mount_path}/revoke-self | This endpoint will delete the token used to call it and all of its child tokens.
[**PostAuthTokenRolesRoleName**](Auth.md#postauthtokenrolesrolename) | **POST** /auth/{token_mount_path}/roles/{role_name} | 
[**PostAuthTokenTidy**](Auth.md#postauthtokentidy) | **POST** /auth/{token_mount_path}/tidy | This endpoint performs cleanup tasks that can be run if certain error conditions have occurred.
[**PostAuthUserpassLoginUsername**](Auth.md#postauthuserpassloginusername) | **POST** /auth/{userpass_mount_path}/login/{username} | Log in with a username and password.
[**PostAuthUserpassUsersUsername**](Auth.md#postauthuserpassusersusername) | **POST** /auth/{userpass_mount_path}/users/{username} | Manage users allowed to authenticate.
[**PostAuthUserpassUsersUsernamePassword**](Auth.md#postauthuserpassusersusernamepassword) | **POST** /auth/{userpass_mount_path}/users/{username}/password | Reset user&#39;s password.
[**PostAuthUserpassUsersUsernamePolicies**](Auth.md#postauthuserpassusersusernamepolicies) | **POST** /auth/{userpass_mount_path}/users/{username}/policies | Update the policies associated with the username.


<a name="deleteauthalicloudrolerole"></a>
# **DeleteAuthAlicloudRoleRole**
> void DeleteAuthAlicloudRoleRole (string role, string alicloudMountPath = null)

Create a role and associate policies to it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthAlicloudRoleRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var role = "role_example";  // string | The name of the role as it should appear in Vault.
            var alicloudMountPath = "\"alicloud\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "alicloud")

            try
            {
                // Create a role and associate policies to it.
                apiInstance.DeleteAuthAlicloudRoleRole(role, alicloudMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthAlicloudRoleRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **alicloudMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;alicloud&quot;]

### Return type

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
> void DeleteAuthApproleRoleRoleName (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNameExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.DeleteAuthApproleRoleRoleName(roleName, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthApproleRoleRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthapprolerolerolenamebindsecretid"></a>
# **DeleteAuthApproleRoleRoleNameBindSecretId**
> void DeleteAuthApproleRoleRoleNameBindSecretId (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNameBindSecretIdExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.DeleteAuthApproleRoleRoleNameBindSecretId(roleName, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthApproleRoleRoleNameBindSecretId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthapprolerolerolenameboundcidrlist"></a>
# **DeleteAuthApproleRoleRoleNameBoundCidrList**
> void DeleteAuthApproleRoleRoleNameBoundCidrList (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNameBoundCidrListExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.DeleteAuthApproleRoleRoleNameBoundCidrList(roleName, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthApproleRoleRoleNameBoundCidrList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthapprolerolerolenameperiod"></a>
# **DeleteAuthApproleRoleRoleNamePeriod**
> void DeleteAuthApproleRoleRoleNamePeriod (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNamePeriodExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.DeleteAuthApproleRoleRoleNamePeriod(roleName, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthApproleRoleRoleNamePeriod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthapprolerolerolenamepolicies"></a>
# **DeleteAuthApproleRoleRoleNamePolicies**
> void DeleteAuthApproleRoleRoleNamePolicies (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNamePoliciesExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.DeleteAuthApproleRoleRoleNamePolicies(roleName, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthApproleRoleRoleNamePolicies: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthapprolerolerolenamesecretidaccessordestroy"></a>
# **DeleteAuthApproleRoleRoleNameSecretIdAccessorDestroy**
> void DeleteAuthApproleRoleRoleNameSecretIdAccessorDestroy (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNameSecretIdAccessorDestroyExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.DeleteAuthApproleRoleRoleNameSecretIdAccessorDestroy(roleName, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthApproleRoleRoleNameSecretIdAccessorDestroy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthapprolerolerolenamesecretidboundcidrs"></a>
# **DeleteAuthApproleRoleRoleNameSecretIdBoundCidrs**
> void DeleteAuthApproleRoleRoleNameSecretIdBoundCidrs (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNameSecretIdBoundCidrsExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.DeleteAuthApproleRoleRoleNameSecretIdBoundCidrs(roleName, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthApproleRoleRoleNameSecretIdBoundCidrs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthapprolerolerolenamesecretiddestroy"></a>
# **DeleteAuthApproleRoleRoleNameSecretIdDestroy**
> void DeleteAuthApproleRoleRoleNameSecretIdDestroy (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNameSecretIdDestroyExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.DeleteAuthApproleRoleRoleNameSecretIdDestroy(roleName, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthApproleRoleRoleNameSecretIdDestroy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthapprolerolerolenamesecretidnumuses"></a>
# **DeleteAuthApproleRoleRoleNameSecretIdNumUses**
> void DeleteAuthApproleRoleRoleNameSecretIdNumUses (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNameSecretIdNumUsesExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.DeleteAuthApproleRoleRoleNameSecretIdNumUses(roleName, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthApproleRoleRoleNameSecretIdNumUses: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthapprolerolerolenamesecretidttl"></a>
# **DeleteAuthApproleRoleRoleNameSecretIdTtl**
> void DeleteAuthApproleRoleRoleNameSecretIdTtl (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNameSecretIdTtlExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.DeleteAuthApproleRoleRoleNameSecretIdTtl(roleName, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthApproleRoleRoleNameSecretIdTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthapprolerolerolenametokenboundcidrs"></a>
# **DeleteAuthApproleRoleRoleNameTokenBoundCidrs**
> void DeleteAuthApproleRoleRoleNameTokenBoundCidrs (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNameTokenBoundCidrsExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.DeleteAuthApproleRoleRoleNameTokenBoundCidrs(roleName, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthApproleRoleRoleNameTokenBoundCidrs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthapprolerolerolenametokenmaxttl"></a>
# **DeleteAuthApproleRoleRoleNameTokenMaxTtl**
> void DeleteAuthApproleRoleRoleNameTokenMaxTtl (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNameTokenMaxTtlExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.DeleteAuthApproleRoleRoleNameTokenMaxTtl(roleName, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthApproleRoleRoleNameTokenMaxTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthapprolerolerolenametokennumuses"></a>
# **DeleteAuthApproleRoleRoleNameTokenNumUses**
> void DeleteAuthApproleRoleRoleNameTokenNumUses (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNameTokenNumUsesExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.DeleteAuthApproleRoleRoleNameTokenNumUses(roleName, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthApproleRoleRoleNameTokenNumUses: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthapprolerolerolenametokenttl"></a>
# **DeleteAuthApproleRoleRoleNameTokenTtl**
> void DeleteAuthApproleRoleRoleNameTokenTtl (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthApproleRoleRoleNameTokenTtlExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.DeleteAuthApproleRoleRoleNameTokenTtl(roleName, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthApproleRoleRoleNameTokenTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthawsconfigcertificatecertname"></a>
# **DeleteAuthAwsConfigCertificateCertName**
> void DeleteAuthAwsConfigCertificateCertName (string certName, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthAwsConfigCertificateCertNameExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.DeleteAuthAwsConfigCertificateCertName(certName, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthAwsConfigCertificateCertName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

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
> void DeleteAuthAwsConfigClient (string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthAwsConfigClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.DeleteAuthAwsConfigClient(awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthAwsConfigClient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

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
> void DeleteAuthAwsConfigStsAccountId (string accountId, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthAwsConfigStsAccountIdExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.DeleteAuthAwsConfigStsAccountId(accountId, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthAwsConfigStsAccountId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

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
> void DeleteAuthAwsConfigTidyIdentityAccesslist (string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthAwsConfigTidyIdentityAccesslistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.DeleteAuthAwsConfigTidyIdentityAccesslist(awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthAwsConfigTidyIdentityAccesslist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

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
> void DeleteAuthAwsConfigTidyIdentityWhitelist (string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthAwsConfigTidyIdentityWhitelistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.DeleteAuthAwsConfigTidyIdentityWhitelist(awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthAwsConfigTidyIdentityWhitelist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

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
> void DeleteAuthAwsConfigTidyRoletagBlacklist (string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthAwsConfigTidyRoletagBlacklistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.DeleteAuthAwsConfigTidyRoletagBlacklist(awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthAwsConfigTidyRoletagBlacklist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

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
> void DeleteAuthAwsConfigTidyRoletagDenylist (string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthAwsConfigTidyRoletagDenylistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.DeleteAuthAwsConfigTidyRoletagDenylist(awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthAwsConfigTidyRoletagDenylist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

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
> void DeleteAuthAwsIdentityAccesslistInstanceId (string instanceId, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthAwsIdentityAccesslistInstanceIdExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.DeleteAuthAwsIdentityAccesslistInstanceId(instanceId, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthAwsIdentityAccesslistInstanceId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

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
> void DeleteAuthAwsIdentityWhitelistInstanceId (string instanceId, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthAwsIdentityWhitelistInstanceIdExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.DeleteAuthAwsIdentityWhitelistInstanceId(instanceId, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthAwsIdentityWhitelistInstanceId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

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
> void DeleteAuthAwsRoleRole (string role, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthAwsRoleRoleExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.DeleteAuthAwsRoleRole(role, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthAwsRoleRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

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
> void DeleteAuthAwsRoletagBlacklistRoleTag (string roleTag, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthAwsRoletagBlacklistRoleTagExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.DeleteAuthAwsRoletagBlacklistRoleTag(roleTag, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthAwsRoletagBlacklistRoleTag: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

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
> void DeleteAuthAwsRoletagDenylistRoleTag (string roleTag, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthAwsRoletagDenylistRoleTagExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.DeleteAuthAwsRoletagDenylistRoleTag(roleTag, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthAwsRoletagDenylistRoleTag: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

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
> void DeleteAuthAzureConfig (string azureMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthAzureConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                apiInstance.DeleteAuthAzureConfig(azureMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthAzureConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **azureMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;azure&quot;]

### Return type

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
> void DeleteAuthAzureRoleName (string name, string azureMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthAzureRoleNameExample
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
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                apiInstance.DeleteAuthAzureRoleName(name, azureMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthAzureRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **azureMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;azure&quot;]

### Return type

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
> void DeleteAuthCertCertsName (string name, string certMountPath = null)

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
    public class DeleteAuthCertCertsNameExample
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
            var certMountPath = "\"cert\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cert")

            try
            {
                // Manage trusted certificates used for authentication.
                apiInstance.DeleteAuthCertCertsName(name, certMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthCertCertsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **certMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cert&quot;]

### Return type

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
> void DeleteAuthCertCrlsName (string name, string certMountPath = null)

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
    public class DeleteAuthCertCrlsNameExample
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
            var certMountPath = "\"cert\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cert")

            try
            {
                // Manage Certificate Revocation Lists checked during authentication.
                apiInstance.DeleteAuthCertCrlsName(name, certMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthCertCrlsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **certMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cert&quot;]

### Return type

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
> void DeleteAuthCfConfig (string cfMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthCfConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var cfMountPath = "\"cf\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cf")

            try
            {
                apiInstance.DeleteAuthCfConfig(cfMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthCfConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cfMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cf&quot;]

### Return type

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
> void DeleteAuthCfRolesRole (string role, string cfMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthCfRolesRoleExample
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
            var cfMountPath = "\"cf\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cf")

            try
            {
                apiInstance.DeleteAuthCfRolesRole(role, cfMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthCfRolesRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **cfMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cf&quot;]

### Return type

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
> void DeleteAuthGcpRoleName (string name, string gcpMountPath = null)

Create a GCP role with associated policies and required attributes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthGcpRoleNameExample
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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                // Create a GCP role with associated policies and required attributes.
                apiInstance.DeleteAuthGcpRoleName(name, gcpMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthGcpRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **gcpMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcp&quot;]

### Return type

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
> void DeleteAuthGithubMapTeamsKey (string key, string githubMountPath = null)

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
    public class DeleteAuthGithubMapTeamsKeyExample
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
            var githubMountPath = "\"github\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "github")

            try
            {
                // Read/write/delete a single teams mapping
                apiInstance.DeleteAuthGithubMapTeamsKey(key, githubMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthGithubMapTeamsKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **githubMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;github&quot;]

### Return type

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
> void DeleteAuthGithubMapUsersKey (string key, string githubMountPath = null)

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
    public class DeleteAuthGithubMapUsersKeyExample
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
            var githubMountPath = "\"github\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "github")

            try
            {
                // Read/write/delete a single users mapping
                apiInstance.DeleteAuthGithubMapUsersKey(key, githubMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthGithubMapUsersKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **githubMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;github&quot;]

### Return type

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
> void DeleteAuthJwtRoleName (string name, string jwtMountPath = null)

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
    public class DeleteAuthJwtRoleNameExample
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
            var jwtMountPath = "\"jwt\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "jwt")

            try
            {
                // Delete an existing role.
                apiInstance.DeleteAuthJwtRoleName(name, jwtMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthJwtRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **jwtMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;jwt&quot;]

### Return type

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
> void DeleteAuthKerberosGroupsName (string name, string kerberosMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthKerberosGroupsNameExample
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
            var kerberosMountPath = "\"kerberos\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kerberos")

            try
            {
                apiInstance.DeleteAuthKerberosGroupsName(name, kerberosMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthKerberosGroupsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **kerberosMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kerberos&quot;]

### Return type

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
> void DeleteAuthKubernetesRoleName (string name, string kubernetesMountPath = null)

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
    public class DeleteAuthKubernetesRoleNameExample
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
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                // Register an role with the backend.
                apiInstance.DeleteAuthKubernetesRoleName(name, kubernetesMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthKubernetesRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **kubernetesMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kubernetes&quot;]

### Return type

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
> void DeleteAuthLdapGroupsName (string name, string ldapMountPath = null)

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
    public class DeleteAuthLdapGroupsNameExample
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
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                // Manage additional groups for users allowed to authenticate.
                apiInstance.DeleteAuthLdapGroupsName(name, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthLdapGroupsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **ldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]

### Return type

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
> void DeleteAuthLdapUsersName (string name, string ldapMountPath = null)

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
    public class DeleteAuthLdapUsersNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | Name of the LDAP user.
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.DeleteAuthLdapUsersName(name, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthLdapUsersName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **ldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]

### Return type

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
> void DeleteAuthOciConfig (string ociMountPath = null)

Manages the configuration for the Vault Auth Plugin.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthOciConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var ociMountPath = "\"oci\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oci")

            try
            {
                // Manages the configuration for the Vault Auth Plugin.
                apiInstance.DeleteAuthOciConfig(ociMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthOciConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ociMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oci&quot;]

### Return type

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
> void DeleteAuthOciRoleRole (string role, string ociMountPath = null)

Create a role and associate policies to it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthOciRoleRoleExample
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
            var ociMountPath = "\"oci\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oci")

            try
            {
                // Create a role and associate policies to it.
                apiInstance.DeleteAuthOciRoleRole(role, ociMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthOciRoleRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **ociMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oci&quot;]

### Return type

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
> void DeleteAuthOidcRoleName (string name, string oidcMountPath = null)

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
    public class DeleteAuthOidcRoleNameExample
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
            var oidcMountPath = "\"oidc\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oidc")

            try
            {
                // Delete an existing role.
                apiInstance.DeleteAuthOidcRoleName(name, oidcMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthOidcRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **oidcMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oidc&quot;]

### Return type

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
> void DeleteAuthOktaGroupsName (string name, string oktaMountPath = null)

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
    public class DeleteAuthOktaGroupsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | Name of the Okta group.
            var oktaMountPath = "\"okta\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "okta")

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.DeleteAuthOktaGroupsName(name, oktaMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthOktaGroupsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **oktaMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;okta&quot;]

### Return type

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
> void DeleteAuthOktaUsersName (string name, string oktaMountPath = null)

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
    public class DeleteAuthOktaUsersNameExample
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
            var oktaMountPath = "\"okta\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "okta")

            try
            {
                // Manage additional groups for users allowed to authenticate.
                apiInstance.DeleteAuthOktaUsersName(name, oktaMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthOktaUsersName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **oktaMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;okta&quot;]

### Return type

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
> void DeleteAuthRadiusUsersName (string name, string radiusMountPath = null)

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
    public class DeleteAuthRadiusUsersNameExample
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
            var radiusMountPath = "\"radius\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "radius")

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.DeleteAuthRadiusUsersName(name, radiusMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthRadiusUsersName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **radiusMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;radius&quot;]

### Return type

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
> void DeleteAuthTokenRolesRoleName (string roleName, string tokenMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthTokenRolesRoleNameExample
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
            var tokenMountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                apiInstance.DeleteAuthTokenRolesRoleName(roleName, tokenMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthTokenRolesRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **tokenMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

### Return type

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
> void DeleteAuthUserpassUsersUsername (string username, string userpassMountPath = null)

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
    public class DeleteAuthUserpassUsersUsernameExample
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
            var userpassMountPath = "\"userpass\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "userpass")

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.DeleteAuthUserpassUsersUsername(username, userpassMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.DeleteAuthUserpassUsersUsername: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **userpassMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;userpass&quot;]

### Return type

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
> void GetAuthAlicloudRole (string list, string alicloudMountPath = null)

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
    public class GetAuthAlicloudRoleExample
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
            var alicloudMountPath = "\"alicloud\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "alicloud")

            try
            {
                // Lists all the roles that are registered with Vault.
                apiInstance.GetAuthAlicloudRole(list, alicloudMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAlicloudRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **alicloudMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;alicloud&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthAlicloudRoleRole (string role, string alicloudMountPath = null)

Create a role and associate policies to it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthAlicloudRoleRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var role = "role_example";  // string | The name of the role as it should appear in Vault.
            var alicloudMountPath = "\"alicloud\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "alicloud")

            try
            {
                // Create a role and associate policies to it.
                apiInstance.GetAuthAlicloudRoleRole(role, alicloudMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAlicloudRoleRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **alicloudMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;alicloud&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthAlicloudRoles (string list, string alicloudMountPath = null)

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
    public class GetAuthAlicloudRolesExample
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
            var alicloudMountPath = "\"alicloud\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "alicloud")

            try
            {
                // Lists all the roles that are registered with Vault.
                apiInstance.GetAuthAlicloudRoles(list, alicloudMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAlicloudRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **alicloudMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;alicloud&quot;]

### Return type

void (empty response body)

### Authorization

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
> ApproleRoleResponse GetAuthApproleRole (string list, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthApproleRoleExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                ApproleRoleResponse result = apiInstance.GetAuthApproleRole(list, approleMountPath);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthApproleRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

[**ApproleRoleResponse**](ApproleRoleResponse.md)

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

<a name="getauthapprolerolerolename"></a>
# **GetAuthApproleRoleRoleName**
> ApproleRoleResponse GetAuthApproleRoleRoleName (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                ApproleRoleResponse result = apiInstance.GetAuthApproleRoleRoleName(roleName, approleMountPath);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthApproleRoleRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

[**ApproleRoleResponse**](ApproleRoleResponse.md)

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

<a name="getauthapprolerolerolenamebindsecretid"></a>
# **GetAuthApproleRoleRoleNameBindSecretId**
> ApproleRoleBindSecretIdResponse GetAuthApproleRoleRoleNameBindSecretId (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameBindSecretIdExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                ApproleRoleBindSecretIdResponse result = apiInstance.GetAuthApproleRoleRoleNameBindSecretId(roleName, approleMountPath);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthApproleRoleRoleNameBindSecretId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

[**ApproleRoleBindSecretIdResponse**](ApproleRoleBindSecretIdResponse.md)

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

<a name="getauthapprolerolerolenameboundcidrlist"></a>
# **GetAuthApproleRoleRoleNameBoundCidrList**
> ApproleRoleBoundCidrListResponse GetAuthApproleRoleRoleNameBoundCidrList (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameBoundCidrListExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                ApproleRoleBoundCidrListResponse result = apiInstance.GetAuthApproleRoleRoleNameBoundCidrList(roleName, approleMountPath);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthApproleRoleRoleNameBoundCidrList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

[**ApproleRoleBoundCidrListResponse**](ApproleRoleBoundCidrListResponse.md)

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

<a name="getauthapprolerolerolenamelocalsecretids"></a>
# **GetAuthApproleRoleRoleNameLocalSecretIds**
> ApproleRoleLocalSecretIdsResponse GetAuthApproleRoleRoleNameLocalSecretIds (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameLocalSecretIdsExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                ApproleRoleLocalSecretIdsResponse result = apiInstance.GetAuthApproleRoleRoleNameLocalSecretIds(roleName, approleMountPath);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthApproleRoleRoleNameLocalSecretIds: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

[**ApproleRoleLocalSecretIdsResponse**](ApproleRoleLocalSecretIdsResponse.md)

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

<a name="getauthapprolerolerolenameperiod"></a>
# **GetAuthApproleRoleRoleNamePeriod**
> ApproleRolePeriodResponse GetAuthApproleRoleRoleNamePeriod (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNamePeriodExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                ApproleRolePeriodResponse result = apiInstance.GetAuthApproleRoleRoleNamePeriod(roleName, approleMountPath);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthApproleRoleRoleNamePeriod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

[**ApproleRolePeriodResponse**](ApproleRolePeriodResponse.md)

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

<a name="getauthapprolerolerolenamepolicies"></a>
# **GetAuthApproleRoleRoleNamePolicies**
> ApproleRolePoliciesResponse GetAuthApproleRoleRoleNamePolicies (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNamePoliciesExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                ApproleRolePoliciesResponse result = apiInstance.GetAuthApproleRoleRoleNamePolicies(roleName, approleMountPath);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthApproleRoleRoleNamePolicies: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

[**ApproleRolePoliciesResponse**](ApproleRolePoliciesResponse.md)

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

<a name="getauthapprolerolerolenameroleid"></a>
# **GetAuthApproleRoleRoleNameRoleId**
> ApproleRoleRoleIdResponse GetAuthApproleRoleRoleNameRoleId (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameRoleIdExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                ApproleRoleRoleIdResponse result = apiInstance.GetAuthApproleRoleRoleNameRoleId(roleName, approleMountPath);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthApproleRoleRoleNameRoleId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

[**ApproleRoleRoleIdResponse**](ApproleRoleRoleIdResponse.md)

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

<a name="getauthapprolerolerolenamesecretid"></a>
# **GetAuthApproleRoleRoleNameSecretId**
> ApproleRoleSecretIdResponse GetAuthApproleRoleRoleNameSecretId (string roleName, string list, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameSecretIdExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                ApproleRoleSecretIdResponse result = apiInstance.GetAuthApproleRoleRoleNameSecretId(roleName, list, approleMountPath);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthApproleRoleRoleNameSecretId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

[**ApproleRoleSecretIdResponse**](ApproleRoleSecretIdResponse.md)

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

<a name="getauthapprolerolerolenamesecretidboundcidrs"></a>
# **GetAuthApproleRoleRoleNameSecretIdBoundCidrs**
> ApproleRoleSecretIdBoundCidrsResponse GetAuthApproleRoleRoleNameSecretIdBoundCidrs (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameSecretIdBoundCidrsExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                ApproleRoleSecretIdBoundCidrsResponse result = apiInstance.GetAuthApproleRoleRoleNameSecretIdBoundCidrs(roleName, approleMountPath);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthApproleRoleRoleNameSecretIdBoundCidrs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

[**ApproleRoleSecretIdBoundCidrsResponse**](ApproleRoleSecretIdBoundCidrsResponse.md)

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

<a name="getauthapprolerolerolenamesecretidnumuses"></a>
# **GetAuthApproleRoleRoleNameSecretIdNumUses**
> ApproleRoleSecretIdNumUsesResponse GetAuthApproleRoleRoleNameSecretIdNumUses (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameSecretIdNumUsesExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                ApproleRoleSecretIdNumUsesResponse result = apiInstance.GetAuthApproleRoleRoleNameSecretIdNumUses(roleName, approleMountPath);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthApproleRoleRoleNameSecretIdNumUses: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

[**ApproleRoleSecretIdNumUsesResponse**](ApproleRoleSecretIdNumUsesResponse.md)

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

<a name="getauthapprolerolerolenamesecretidttl"></a>
# **GetAuthApproleRoleRoleNameSecretIdTtl**
> ApproleRoleSecretIdTtlResponse GetAuthApproleRoleRoleNameSecretIdTtl (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameSecretIdTtlExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                ApproleRoleSecretIdTtlResponse result = apiInstance.GetAuthApproleRoleRoleNameSecretIdTtl(roleName, approleMountPath);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthApproleRoleRoleNameSecretIdTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

[**ApproleRoleSecretIdTtlResponse**](ApproleRoleSecretIdTtlResponse.md)

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

<a name="getauthapprolerolerolenametokenboundcidrs"></a>
# **GetAuthApproleRoleRoleNameTokenBoundCidrs**
> ApproleRoleTokenBoundCidrsResponse GetAuthApproleRoleRoleNameTokenBoundCidrs (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameTokenBoundCidrsExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                ApproleRoleTokenBoundCidrsResponse result = apiInstance.GetAuthApproleRoleRoleNameTokenBoundCidrs(roleName, approleMountPath);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthApproleRoleRoleNameTokenBoundCidrs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

[**ApproleRoleTokenBoundCidrsResponse**](ApproleRoleTokenBoundCidrsResponse.md)

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

<a name="getauthapprolerolerolenametokenmaxttl"></a>
# **GetAuthApproleRoleRoleNameTokenMaxTtl**
> ApproleRoleTokenMaxTtlResponse GetAuthApproleRoleRoleNameTokenMaxTtl (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameTokenMaxTtlExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                ApproleRoleTokenMaxTtlResponse result = apiInstance.GetAuthApproleRoleRoleNameTokenMaxTtl(roleName, approleMountPath);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthApproleRoleRoleNameTokenMaxTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

[**ApproleRoleTokenMaxTtlResponse**](ApproleRoleTokenMaxTtlResponse.md)

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

<a name="getauthapprolerolerolenametokennumuses"></a>
# **GetAuthApproleRoleRoleNameTokenNumUses**
> ApproleRoleTokenNumUsesResponse GetAuthApproleRoleRoleNameTokenNumUses (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameTokenNumUsesExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                ApproleRoleTokenNumUsesResponse result = apiInstance.GetAuthApproleRoleRoleNameTokenNumUses(roleName, approleMountPath);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthApproleRoleRoleNameTokenNumUses: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

[**ApproleRoleTokenNumUsesResponse**](ApproleRoleTokenNumUsesResponse.md)

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

<a name="getauthapprolerolerolenametokenttl"></a>
# **GetAuthApproleRoleRoleNameTokenTtl**
> ApproleRoleTokenTtlResponse GetAuthApproleRoleRoleNameTokenTtl (string roleName, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthApproleRoleRoleNameTokenTtlExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                ApproleRoleTokenTtlResponse result = apiInstance.GetAuthApproleRoleRoleNameTokenTtl(roleName, approleMountPath);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthApproleRoleRoleNameTokenTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

[**ApproleRoleTokenTtlResponse**](ApproleRoleTokenTtlResponse.md)

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

<a name="getauthawsconfigcertificatecertname"></a>
# **GetAuthAwsConfigCertificateCertName**
> void GetAuthAwsConfigCertificateCertName (string certName, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthAwsConfigCertificateCertNameExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.GetAuthAwsConfigCertificateCertName(certName, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAwsConfigCertificateCertName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthAwsConfigCertificates (string list, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthAwsConfigCertificatesExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.GetAuthAwsConfigCertificates(list, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAwsConfigCertificates: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthAwsConfigClient (string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthAwsConfigClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.GetAuthAwsConfigClient(awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAwsConfigClient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthAwsConfigIdentity (string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthAwsConfigIdentityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.GetAuthAwsConfigIdentity(awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAwsConfigIdentity: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthAwsConfigSts (string list, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthAwsConfigStsExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.GetAuthAwsConfigSts(list, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAwsConfigSts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthAwsConfigStsAccountId (string accountId, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthAwsConfigStsAccountIdExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.GetAuthAwsConfigStsAccountId(accountId, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAwsConfigStsAccountId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthAwsConfigTidyIdentityAccesslist (string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthAwsConfigTidyIdentityAccesslistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.GetAuthAwsConfigTidyIdentityAccesslist(awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAwsConfigTidyIdentityAccesslist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthAwsConfigTidyIdentityWhitelist (string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthAwsConfigTidyIdentityWhitelistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.GetAuthAwsConfigTidyIdentityWhitelist(awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAwsConfigTidyIdentityWhitelist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthAwsConfigTidyRoletagBlacklist (string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthAwsConfigTidyRoletagBlacklistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.GetAuthAwsConfigTidyRoletagBlacklist(awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAwsConfigTidyRoletagBlacklist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthAwsConfigTidyRoletagDenylist (string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthAwsConfigTidyRoletagDenylistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.GetAuthAwsConfigTidyRoletagDenylist(awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAwsConfigTidyRoletagDenylist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthAwsIdentityAccesslist (string list, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthAwsIdentityAccesslistExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.GetAuthAwsIdentityAccesslist(list, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAwsIdentityAccesslist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthAwsIdentityAccesslistInstanceId (string instanceId, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthAwsIdentityAccesslistInstanceIdExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.GetAuthAwsIdentityAccesslistInstanceId(instanceId, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAwsIdentityAccesslistInstanceId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthAwsIdentityWhitelist (string list, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthAwsIdentityWhitelistExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.GetAuthAwsIdentityWhitelist(list, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAwsIdentityWhitelist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthAwsIdentityWhitelistInstanceId (string instanceId, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthAwsIdentityWhitelistInstanceIdExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.GetAuthAwsIdentityWhitelistInstanceId(instanceId, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAwsIdentityWhitelistInstanceId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthAwsRole (string list, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthAwsRoleExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.GetAuthAwsRole(list, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAwsRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthAwsRoleRole (string role, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthAwsRoleRoleExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.GetAuthAwsRoleRole(role, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAwsRoleRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthAwsRoles (string list, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthAwsRolesExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.GetAuthAwsRoles(list, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAwsRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthAwsRoletagBlacklist (string list, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthAwsRoletagBlacklistExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.GetAuthAwsRoletagBlacklist(list, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAwsRoletagBlacklist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthAwsRoletagBlacklistRoleTag (string roleTag, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthAwsRoletagBlacklistRoleTagExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.GetAuthAwsRoletagBlacklistRoleTag(roleTag, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAwsRoletagBlacklistRoleTag: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthAwsRoletagDenylist (string list, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthAwsRoletagDenylistExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.GetAuthAwsRoletagDenylist(list, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAwsRoletagDenylist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthAwsRoletagDenylistRoleTag (string roleTag, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthAwsRoletagDenylistRoleTagExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.GetAuthAwsRoletagDenylistRoleTag(roleTag, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAwsRoletagDenylistRoleTag: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthAzureConfig (string azureMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthAzureConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                apiInstance.GetAuthAzureConfig(azureMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAzureConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **azureMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;azure&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthAzureRole (string list, string azureMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthAzureRoleExample
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
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                apiInstance.GetAuthAzureRole(list, azureMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAzureRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **azureMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;azure&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthAzureRoleName (string name, string azureMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthAzureRoleNameExample
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
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                apiInstance.GetAuthAzureRoleName(name, azureMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthAzureRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **azureMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;azure&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthCentrifyConfig (string centrifyMountPath = null)

This path allows you to configure the centrify auth provider to interact with the Centrify Identity Services Platform for authenticating users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthCentrifyConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var centrifyMountPath = "\"centrify\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "centrify")

            try
            {
                // This path allows you to configure the centrify auth provider to interact with the Centrify Identity Services Platform for authenticating users.
                apiInstance.GetAuthCentrifyConfig(centrifyMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthCentrifyConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **centrifyMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;centrify&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthCertCerts (string list, string certMountPath = null)

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
    public class GetAuthCertCertsExample
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
            var certMountPath = "\"cert\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cert")

            try
            {
                // Manage trusted certificates used for authentication.
                apiInstance.GetAuthCertCerts(list, certMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthCertCerts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **certMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cert&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthCertCertsName (string name, string certMountPath = null)

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
    public class GetAuthCertCertsNameExample
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
            var certMountPath = "\"cert\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cert")

            try
            {
                // Manage trusted certificates used for authentication.
                apiInstance.GetAuthCertCertsName(name, certMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthCertCertsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **certMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cert&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthcertconfig"></a>
# **GetAuthCertConfig**
> void GetAuthCertConfig (string certMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthCertConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var certMountPath = "\"cert\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cert")

            try
            {
                apiInstance.GetAuthCertConfig(certMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthCertConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **certMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cert&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthcertcrls"></a>
# **GetAuthCertCrls**
> void GetAuthCertCrls (string list, string certMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthCertCrlsExample
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
            var certMountPath = "\"cert\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cert")

            try
            {
                apiInstance.GetAuthCertCrls(list, certMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthCertCrls: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **certMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cert&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthCertCrlsName (string name, string certMountPath = null)

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
    public class GetAuthCertCrlsNameExample
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
            var certMountPath = "\"cert\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cert")

            try
            {
                // Manage Certificate Revocation Lists checked during authentication.
                apiInstance.GetAuthCertCrlsName(name, certMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthCertCrlsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **certMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cert&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthCfConfig (string cfMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthCfConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var cfMountPath = "\"cf\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cf")

            try
            {
                apiInstance.GetAuthCfConfig(cfMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthCfConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cfMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cf&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthCfRoles (string list, string cfMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthCfRolesExample
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
            var cfMountPath = "\"cf\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cf")

            try
            {
                apiInstance.GetAuthCfRoles(list, cfMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthCfRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **cfMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cf&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthCfRolesRole (string role, string cfMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthCfRolesRoleExample
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
            var cfMountPath = "\"cf\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cf")

            try
            {
                apiInstance.GetAuthCfRolesRole(role, cfMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthCfRolesRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **cfMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cf&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthGcpConfig (string gcpMountPath = null)

Configure credentials used to query the GCP IAM API to verify authenticating service accounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthGcpConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                // Configure credentials used to query the GCP IAM API to verify authenticating service accounts
                apiInstance.GetAuthGcpConfig(gcpMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthGcpConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gcpMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcp&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthGcpRole (string list, string gcpMountPath = null)

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
    public class GetAuthGcpRoleExample
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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                // Lists all the roles that are registered with Vault.
                apiInstance.GetAuthGcpRole(list, gcpMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthGcpRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **gcpMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcp&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthGcpRoleName (string name, string gcpMountPath = null)

Create a GCP role with associated policies and required attributes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthGcpRoleNameExample
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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                // Create a GCP role with associated policies and required attributes.
                apiInstance.GetAuthGcpRoleName(name, gcpMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthGcpRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **gcpMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcp&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthGcpRoles (string list, string gcpMountPath = null)

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
    public class GetAuthGcpRolesExample
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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                // Lists all the roles that are registered with Vault.
                apiInstance.GetAuthGcpRoles(list, gcpMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthGcpRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **gcpMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcp&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthGithubConfig (string githubMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthGithubConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var githubMountPath = "\"github\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "github")

            try
            {
                apiInstance.GetAuthGithubConfig(githubMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthGithubConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **githubMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;github&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthGithubMapTeams (string githubMountPath = null, string list = null)

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
    public class GetAuthGithubMapTeamsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var githubMountPath = "\"github\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "github")
            var list = "\"false\"";  // string | Return a list if `true` (optional)  (default to "false")

            try
            {
                // Read mappings for teams
                apiInstance.GetAuthGithubMapTeams(githubMountPath, list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthGithubMapTeams: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **githubMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;github&quot;]
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

<a name="getauthgithubmapteamskey"></a>
# **GetAuthGithubMapTeamsKey**
> void GetAuthGithubMapTeamsKey (string key, string githubMountPath = null)

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
    public class GetAuthGithubMapTeamsKeyExample
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
            var githubMountPath = "\"github\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "github")

            try
            {
                // Read/write/delete a single teams mapping
                apiInstance.GetAuthGithubMapTeamsKey(key, githubMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthGithubMapTeamsKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **githubMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;github&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthGithubMapUsers (string githubMountPath = null, string list = null)

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
    public class GetAuthGithubMapUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var githubMountPath = "\"github\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "github")
            var list = "\"false\"";  // string | Return a list if `true` (optional)  (default to "false")

            try
            {
                // Read mappings for users
                apiInstance.GetAuthGithubMapUsers(githubMountPath, list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthGithubMapUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **githubMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;github&quot;]
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

<a name="getauthgithubmapuserskey"></a>
# **GetAuthGithubMapUsersKey**
> void GetAuthGithubMapUsersKey (string key, string githubMountPath = null)

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
    public class GetAuthGithubMapUsersKeyExample
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
            var githubMountPath = "\"github\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "github")

            try
            {
                // Read/write/delete a single users mapping
                apiInstance.GetAuthGithubMapUsersKey(key, githubMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthGithubMapUsersKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **githubMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;github&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthJwtConfig (string jwtMountPath = null)

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
    public class GetAuthJwtConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var jwtMountPath = "\"jwt\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "jwt")

            try
            {
                // Read the current JWT authentication backend configuration.
                apiInstance.GetAuthJwtConfig(jwtMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthJwtConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jwtMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;jwt&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthJwtOidcCallback (string jwtMountPath = null)

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
    public class GetAuthJwtOidcCallbackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var jwtMountPath = "\"jwt\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "jwt")

            try
            {
                // Callback endpoint to complete an OIDC login.
                apiInstance.GetAuthJwtOidcCallback(jwtMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthJwtOidcCallback: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jwtMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;jwt&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthJwtRole (string list, string jwtMountPath = null)

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
    public class GetAuthJwtRoleExample
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
            var jwtMountPath = "\"jwt\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "jwt")

            try
            {
                // Lists all the roles registered with the backend.
                apiInstance.GetAuthJwtRole(list, jwtMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthJwtRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **jwtMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;jwt&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthJwtRoleName (string name, string jwtMountPath = null)

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
    public class GetAuthJwtRoleNameExample
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
            var jwtMountPath = "\"jwt\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "jwt")

            try
            {
                // Read an existing role.
                apiInstance.GetAuthJwtRoleName(name, jwtMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthJwtRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **jwtMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;jwt&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthKerberosConfig (string kerberosMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthKerberosConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var kerberosMountPath = "\"kerberos\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kerberos")

            try
            {
                apiInstance.GetAuthKerberosConfig(kerberosMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthKerberosConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kerberosMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kerberos&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthKerberosConfigLdap (string kerberosMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthKerberosConfigLdapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var kerberosMountPath = "\"kerberos\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kerberos")

            try
            {
                apiInstance.GetAuthKerberosConfigLdap(kerberosMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthKerberosConfigLdap: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kerberosMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kerberos&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthKerberosGroups (string list, string kerberosMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthKerberosGroupsExample
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
            var kerberosMountPath = "\"kerberos\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kerberos")

            try
            {
                apiInstance.GetAuthKerberosGroups(list, kerberosMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthKerberosGroups: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **kerberosMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kerberos&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthKerberosGroupsName (string name, string kerberosMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthKerberosGroupsNameExample
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
            var kerberosMountPath = "\"kerberos\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kerberos")

            try
            {
                apiInstance.GetAuthKerberosGroupsName(name, kerberosMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthKerberosGroupsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **kerberosMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kerberos&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthKerberosLogin (string kerberosMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthKerberosLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var kerberosMountPath = "\"kerberos\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kerberos")

            try
            {
                apiInstance.GetAuthKerberosLogin(kerberosMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthKerberosLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kerberosMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kerberos&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthKubernetesConfig (string kubernetesMountPath = null)

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
    public class GetAuthKubernetesConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                // Configures the JWT Public Key and Kubernetes API information.
                apiInstance.GetAuthKubernetesConfig(kubernetesMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthKubernetesConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kubernetesMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kubernetes&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthKubernetesRole (string list, string kubernetesMountPath = null)

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
    public class GetAuthKubernetesRoleExample
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
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                // Lists all the roles registered with the backend.
                apiInstance.GetAuthKubernetesRole(list, kubernetesMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthKubernetesRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **kubernetesMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kubernetes&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthKubernetesRoleName (string name, string kubernetesMountPath = null)

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
    public class GetAuthKubernetesRoleNameExample
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
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                // Register an role with the backend.
                apiInstance.GetAuthKubernetesRoleName(name, kubernetesMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthKubernetesRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **kubernetesMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kubernetes&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthLdapConfig (string ldapMountPath = null)

Configure the LDAP server to connect to, along with its options.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthLdapConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                // Configure the LDAP server to connect to, along with its options.
                apiInstance.GetAuthLdapConfig(ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthLdapConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthLdapGroups (string list, string ldapMountPath = null)

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
    public class GetAuthLdapGroupsExample
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
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                // Manage additional groups for users allowed to authenticate.
                apiInstance.GetAuthLdapGroups(list, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthLdapGroups: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **ldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthLdapGroupsName (string name, string ldapMountPath = null)

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
    public class GetAuthLdapGroupsNameExample
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
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                // Manage additional groups for users allowed to authenticate.
                apiInstance.GetAuthLdapGroupsName(name, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthLdapGroupsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **ldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthLdapUsers (string list, string ldapMountPath = null)

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
    public class GetAuthLdapUsersExample
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
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.GetAuthLdapUsers(list, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthLdapUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **ldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthLdapUsersName (string name, string ldapMountPath = null)

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
    public class GetAuthLdapUsersNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | Name of the LDAP user.
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.GetAuthLdapUsersName(name, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthLdapUsersName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **ldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthOciConfig (string ociMountPath = null)

Manages the configuration for the Vault Auth Plugin.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthOciConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var ociMountPath = "\"oci\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oci")

            try
            {
                // Manages the configuration for the Vault Auth Plugin.
                apiInstance.GetAuthOciConfig(ociMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthOciConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ociMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oci&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthOciRole (string list, string ociMountPath = null)

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
    public class GetAuthOciRoleExample
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
            var ociMountPath = "\"oci\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oci")

            try
            {
                // Lists all the roles that are registered with Vault.
                apiInstance.GetAuthOciRole(list, ociMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthOciRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **ociMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oci&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthOciRoleRole (string role, string ociMountPath = null)

Create a role and associate policies to it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthOciRoleRoleExample
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
            var ociMountPath = "\"oci\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oci")

            try
            {
                // Create a role and associate policies to it.
                apiInstance.GetAuthOciRoleRole(role, ociMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthOciRoleRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **ociMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oci&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthOidcConfig (string oidcMountPath = null)

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
    public class GetAuthOidcConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var oidcMountPath = "\"oidc\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oidc")

            try
            {
                // Read the current JWT authentication backend configuration.
                apiInstance.GetAuthOidcConfig(oidcMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthOidcConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oidcMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oidc&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthOidcOidcCallback (string oidcMountPath = null)

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
    public class GetAuthOidcOidcCallbackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var oidcMountPath = "\"oidc\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oidc")

            try
            {
                // Callback endpoint to complete an OIDC login.
                apiInstance.GetAuthOidcOidcCallback(oidcMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthOidcOidcCallback: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oidcMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oidc&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthOidcRole (string list, string oidcMountPath = null)

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
    public class GetAuthOidcRoleExample
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
            var oidcMountPath = "\"oidc\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oidc")

            try
            {
                // Lists all the roles registered with the backend.
                apiInstance.GetAuthOidcRole(list, oidcMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthOidcRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **oidcMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oidc&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthOidcRoleName (string name, string oidcMountPath = null)

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
    public class GetAuthOidcRoleNameExample
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
            var oidcMountPath = "\"oidc\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oidc")

            try
            {
                // Read an existing role.
                apiInstance.GetAuthOidcRoleName(name, oidcMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthOidcRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **oidcMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oidc&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthOktaConfig (string oktaMountPath = null)

This endpoint allows you to configure the Okta and its configuration options.  The Okta organization are the characters at the front of the URL for Okta. Example https://ORG.okta.com

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthOktaConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var oktaMountPath = "\"okta\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "okta")

            try
            {
                // This endpoint allows you to configure the Okta and its configuration options.  The Okta organization are the characters at the front of the URL for Okta. Example https://ORG.okta.com
                apiInstance.GetAuthOktaConfig(oktaMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthOktaConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oktaMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;okta&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthOktaGroups (string list, string oktaMountPath = null)

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
    public class GetAuthOktaGroupsExample
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
            var oktaMountPath = "\"okta\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "okta")

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.GetAuthOktaGroups(list, oktaMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthOktaGroups: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **oktaMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;okta&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthOktaGroupsName (string name, string oktaMountPath = null)

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
    public class GetAuthOktaGroupsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | Name of the Okta group.
            var oktaMountPath = "\"okta\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "okta")

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.GetAuthOktaGroupsName(name, oktaMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthOktaGroupsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **oktaMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;okta&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthOktaUsers (string list, string oktaMountPath = null)

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
    public class GetAuthOktaUsersExample
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
            var oktaMountPath = "\"okta\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "okta")

            try
            {
                // Manage additional groups for users allowed to authenticate.
                apiInstance.GetAuthOktaUsers(list, oktaMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthOktaUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **oktaMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;okta&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthOktaUsersName (string name, string oktaMountPath = null)

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
    public class GetAuthOktaUsersNameExample
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
            var oktaMountPath = "\"okta\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "okta")

            try
            {
                // Manage additional groups for users allowed to authenticate.
                apiInstance.GetAuthOktaUsersName(name, oktaMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthOktaUsersName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **oktaMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;okta&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthOktaVerifyNonce (string nonce, string oktaMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthOktaVerifyNonceExample
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
            var oktaMountPath = "\"okta\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "okta")

            try
            {
                apiInstance.GetAuthOktaVerifyNonce(nonce, oktaMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthOktaVerifyNonce: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **oktaMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;okta&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthRadiusConfig (string radiusMountPath = null)

Configure the RADIUS server to connect to, along with its options.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthRadiusConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var radiusMountPath = "\"radius\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "radius")

            try
            {
                // Configure the RADIUS server to connect to, along with its options.
                apiInstance.GetAuthRadiusConfig(radiusMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthRadiusConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **radiusMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;radius&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthRadiusUsers (string list, string radiusMountPath = null)

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
    public class GetAuthRadiusUsersExample
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
            var radiusMountPath = "\"radius\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "radius")

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.GetAuthRadiusUsers(list, radiusMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthRadiusUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **radiusMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;radius&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthRadiusUsersName (string name, string radiusMountPath = null)

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
    public class GetAuthRadiusUsersNameExample
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
            var radiusMountPath = "\"radius\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "radius")

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.GetAuthRadiusUsersName(name, radiusMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthRadiusUsersName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **radiusMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;radius&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthTokenAccessors (string list, string tokenMountPath = null)

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
    public class GetAuthTokenAccessorsExample
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
            var tokenMountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // List token accessors, which can then be be used to iterate and discover their properties or revoke them. Because this can be used to cause a denial of service, this endpoint requires 'sudo' capability in addition to 'list'.
                apiInstance.GetAuthTokenAccessors(list, tokenMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthTokenAccessors: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **tokenMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthTokenLookup (string tokenMountPath = null)

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
    public class GetAuthTokenLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var tokenMountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint will lookup a token and its properties.
                apiInstance.GetAuthTokenLookup(tokenMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthTokenLookup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthTokenLookupSelf (string tokenMountPath = null)

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
    public class GetAuthTokenLookupSelfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var tokenMountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint will lookup a token and its properties.
                apiInstance.GetAuthTokenLookupSelf(tokenMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthTokenLookupSelf: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthTokenRoles (string list, string tokenMountPath = null)

This endpoint lists configured roles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthTokenRolesExample
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
            var tokenMountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint lists configured roles.
                apiInstance.GetAuthTokenRoles(list, tokenMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthTokenRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **tokenMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthTokenRolesRoleName (string roleName, string tokenMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetAuthTokenRolesRoleNameExample
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
            var tokenMountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                apiInstance.GetAuthTokenRolesRoleName(roleName, tokenMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthTokenRolesRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **tokenMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthUserpassUsers (string list, string userpassMountPath = null)

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
    public class GetAuthUserpassUsersExample
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
            var userpassMountPath = "\"userpass\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "userpass")

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.GetAuthUserpassUsers(list, userpassMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthUserpassUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **userpassMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;userpass&quot;]

### Return type

void (empty response body)

### Authorization

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
> void GetAuthUserpassUsersUsername (string username, string userpassMountPath = null)

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
    public class GetAuthUserpassUsersUsernameExample
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
            var userpassMountPath = "\"userpass\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "userpass")

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.GetAuthUserpassUsersUsername(username, userpassMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GetAuthUserpassUsersUsername: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **userpassMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;userpass&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthAlicloudLogin (AlicloudLoginRequest alicloudLoginRequest, string alicloudMountPath = null)

Authenticates an RAM entity with Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthAlicloudLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var alicloudLoginRequest = new AlicloudLoginRequest(); // AlicloudLoginRequest | 
            var alicloudMountPath = "\"alicloud\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "alicloud")

            try
            {
                // Authenticates an RAM entity with Vault.
                apiInstance.PostAuthAlicloudLogin(alicloudLoginRequest, alicloudMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthAlicloudLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **alicloudLoginRequest** | [**AlicloudLoginRequest**](AlicloudLoginRequest.md)|  | 
 **alicloudMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;alicloud&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthAlicloudRoleRole (string role, AlicloudRoleRequest alicloudRoleRequest, string alicloudMountPath = null)

Create a role and associate policies to it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthAlicloudRoleRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var role = "role_example";  // string | The name of the role as it should appear in Vault.
            var alicloudRoleRequest = new AlicloudRoleRequest(); // AlicloudRoleRequest | 
            var alicloudMountPath = "\"alicloud\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "alicloud")

            try
            {
                // Create a role and associate policies to it.
                apiInstance.PostAuthAlicloudRoleRole(role, alicloudRoleRequest, alicloudMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthAlicloudRoleRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **alicloudRoleRequest** | [**AlicloudRoleRequest**](AlicloudRoleRequest.md)|  | 
 **alicloudMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;alicloud&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthApproleLogin (ApproleLoginRequest approleLoginRequest, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthApproleLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var approleLoginRequest = new ApproleLoginRequest(); // ApproleLoginRequest | 
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.PostAuthApproleLogin(approleLoginRequest, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthApproleLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **approleLoginRequest** | [**ApproleLoginRequest**](ApproleLoginRequest.md)|  | 
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthApproleRoleRoleName (string roleName, ApproleRoleRequest approleRoleRequest, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.PostAuthApproleRoleRoleName(roleName, approleRoleRequest, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthApproleRoleRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthApproleRoleRoleNameBindSecretId (string roleName, ApproleRoleBindSecretIdRequest approleRoleBindSecretIdRequest, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameBindSecretIdExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.PostAuthApproleRoleRoleNameBindSecretId(roleName, approleRoleBindSecretIdRequest, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthApproleRoleRoleNameBindSecretId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthapprolerolerolenameboundcidrlist"></a>
# **PostAuthApproleRoleRoleNameBoundCidrList**
> void PostAuthApproleRoleRoleNameBoundCidrList (string roleName, ApproleRoleBoundCidrListRequest approleRoleBoundCidrListRequest, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameBoundCidrListExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.PostAuthApproleRoleRoleNameBoundCidrList(roleName, approleRoleBoundCidrListRequest, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthApproleRoleRoleNameBoundCidrList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthapprolerolerolenamecustomsecretid"></a>
# **PostAuthApproleRoleRoleNameCustomSecretId**
> ApproleRoleCustomSecretIdResponse PostAuthApproleRoleRoleNameCustomSecretId (string roleName, ApproleRoleCustomSecretIdRequest approleRoleCustomSecretIdRequest, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameCustomSecretIdExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                ApproleRoleCustomSecretIdResponse result = apiInstance.PostAuthApproleRoleRoleNameCustomSecretId(roleName, approleRoleCustomSecretIdRequest, approleMountPath);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthApproleRoleRoleNameCustomSecretId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

[**ApproleRoleCustomSecretIdResponse**](ApproleRoleCustomSecretIdResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthapprolerolerolenameperiod"></a>
# **PostAuthApproleRoleRoleNamePeriod**
> void PostAuthApproleRoleRoleNamePeriod (string roleName, ApproleRolePeriodRequest approleRolePeriodRequest, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNamePeriodExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.PostAuthApproleRoleRoleNamePeriod(roleName, approleRolePeriodRequest, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthApproleRoleRoleNamePeriod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthapprolerolerolenamepolicies"></a>
# **PostAuthApproleRoleRoleNamePolicies**
> void PostAuthApproleRoleRoleNamePolicies (string roleName, ApproleRolePoliciesRequest approleRolePoliciesRequest, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNamePoliciesExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.PostAuthApproleRoleRoleNamePolicies(roleName, approleRolePoliciesRequest, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthApproleRoleRoleNamePolicies: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthapprolerolerolenameroleid"></a>
# **PostAuthApproleRoleRoleNameRoleId**
> void PostAuthApproleRoleRoleNameRoleId (string roleName, ApproleRoleRoleIdRequest approleRoleRoleIdRequest, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameRoleIdExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.PostAuthApproleRoleRoleNameRoleId(roleName, approleRoleRoleIdRequest, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthApproleRoleRoleNameRoleId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthapprolerolerolenamesecretid"></a>
# **PostAuthApproleRoleRoleNameSecretId**
> ApproleRoleSecretIdResponse PostAuthApproleRoleRoleNameSecretId (string roleName, ApproleRoleSecretIdRequest approleRoleSecretIdRequest, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameSecretIdExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                ApproleRoleSecretIdResponse result = apiInstance.PostAuthApproleRoleRoleNameSecretId(roleName, approleRoleSecretIdRequest, approleMountPath);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthApproleRoleRoleNameSecretId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

[**ApproleRoleSecretIdResponse**](ApproleRoleSecretIdResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthapprolerolerolenamesecretidaccessordestroy"></a>
# **PostAuthApproleRoleRoleNameSecretIdAccessorDestroy**
> void PostAuthApproleRoleRoleNameSecretIdAccessorDestroy (string roleName, ApproleRoleSecretIdAccessorDestroyRequest approleRoleSecretIdAccessorDestroyRequest, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameSecretIdAccessorDestroyExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.PostAuthApproleRoleRoleNameSecretIdAccessorDestroy(roleName, approleRoleSecretIdAccessorDestroyRequest, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthApproleRoleRoleNameSecretIdAccessorDestroy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthapprolerolerolenamesecretidaccessorlookup"></a>
# **PostAuthApproleRoleRoleNameSecretIdAccessorLookup**
> ApproleRoleSecretIdAccessorLookupResponse PostAuthApproleRoleRoleNameSecretIdAccessorLookup (string roleName, ApproleRoleSecretIdAccessorLookupRequest approleRoleSecretIdAccessorLookupRequest, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameSecretIdAccessorLookupExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                ApproleRoleSecretIdAccessorLookupResponse result = apiInstance.PostAuthApproleRoleRoleNameSecretIdAccessorLookup(roleName, approleRoleSecretIdAccessorLookupRequest, approleMountPath);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthApproleRoleRoleNameSecretIdAccessorLookup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

[**ApproleRoleSecretIdAccessorLookupResponse**](ApproleRoleSecretIdAccessorLookupResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthapprolerolerolenamesecretidboundcidrs"></a>
# **PostAuthApproleRoleRoleNameSecretIdBoundCidrs**
> void PostAuthApproleRoleRoleNameSecretIdBoundCidrs (string roleName, ApproleRoleSecretIdBoundCidrsRequest approleRoleSecretIdBoundCidrsRequest, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameSecretIdBoundCidrsExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.PostAuthApproleRoleRoleNameSecretIdBoundCidrs(roleName, approleRoleSecretIdBoundCidrsRequest, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthApproleRoleRoleNameSecretIdBoundCidrs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthapprolerolerolenamesecretiddestroy"></a>
# **PostAuthApproleRoleRoleNameSecretIdDestroy**
> void PostAuthApproleRoleRoleNameSecretIdDestroy (string roleName, ApproleRoleSecretIdDestroyRequest approleRoleSecretIdDestroyRequest, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameSecretIdDestroyExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.PostAuthApproleRoleRoleNameSecretIdDestroy(roleName, approleRoleSecretIdDestroyRequest, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthApproleRoleRoleNameSecretIdDestroy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthapprolerolerolenamesecretidlookup"></a>
# **PostAuthApproleRoleRoleNameSecretIdLookup**
> ApproleRoleSecretIdLookupResponse PostAuthApproleRoleRoleNameSecretIdLookup (string roleName, ApproleRoleSecretIdLookupRequest approleRoleSecretIdLookupRequest, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameSecretIdLookupExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                ApproleRoleSecretIdLookupResponse result = apiInstance.PostAuthApproleRoleRoleNameSecretIdLookup(roleName, approleRoleSecretIdLookupRequest, approleMountPath);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthApproleRoleRoleNameSecretIdLookup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

[**ApproleRoleSecretIdLookupResponse**](ApproleRoleSecretIdLookupResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthapprolerolerolenamesecretidnumuses"></a>
# **PostAuthApproleRoleRoleNameSecretIdNumUses**
> void PostAuthApproleRoleRoleNameSecretIdNumUses (string roleName, ApproleRoleSecretIdNumUsesRequest approleRoleSecretIdNumUsesRequest, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameSecretIdNumUsesExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.PostAuthApproleRoleRoleNameSecretIdNumUses(roleName, approleRoleSecretIdNumUsesRequest, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthApproleRoleRoleNameSecretIdNumUses: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthapprolerolerolenamesecretidttl"></a>
# **PostAuthApproleRoleRoleNameSecretIdTtl**
> void PostAuthApproleRoleRoleNameSecretIdTtl (string roleName, ApproleRoleSecretIdTtlRequest approleRoleSecretIdTtlRequest, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameSecretIdTtlExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.PostAuthApproleRoleRoleNameSecretIdTtl(roleName, approleRoleSecretIdTtlRequest, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthApproleRoleRoleNameSecretIdTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthapprolerolerolenametokenboundcidrs"></a>
# **PostAuthApproleRoleRoleNameTokenBoundCidrs**
> void PostAuthApproleRoleRoleNameTokenBoundCidrs (string roleName, ApproleRoleTokenBoundCidrsRequest approleRoleTokenBoundCidrsRequest, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameTokenBoundCidrsExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.PostAuthApproleRoleRoleNameTokenBoundCidrs(roleName, approleRoleTokenBoundCidrsRequest, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthApproleRoleRoleNameTokenBoundCidrs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthapprolerolerolenametokenmaxttl"></a>
# **PostAuthApproleRoleRoleNameTokenMaxTtl**
> void PostAuthApproleRoleRoleNameTokenMaxTtl (string roleName, ApproleRoleTokenMaxTtlRequest approleRoleTokenMaxTtlRequest, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameTokenMaxTtlExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.PostAuthApproleRoleRoleNameTokenMaxTtl(roleName, approleRoleTokenMaxTtlRequest, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthApproleRoleRoleNameTokenMaxTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthapprolerolerolenametokennumuses"></a>
# **PostAuthApproleRoleRoleNameTokenNumUses**
> void PostAuthApproleRoleRoleNameTokenNumUses (string roleName, ApproleRoleTokenNumUsesRequest approleRoleTokenNumUsesRequest, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameTokenNumUsesExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.PostAuthApproleRoleRoleNameTokenNumUses(roleName, approleRoleTokenNumUsesRequest, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthApproleRoleRoleNameTokenNumUses: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthapprolerolerolenametokenttl"></a>
# **PostAuthApproleRoleRoleNameTokenTtl**
> void PostAuthApproleRoleRoleNameTokenTtl (string roleName, ApproleRoleTokenTtlRequest approleRoleTokenTtlRequest, string approleMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthApproleRoleRoleNameTokenTtlExample
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
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                apiInstance.PostAuthApproleRoleRoleNameTokenTtl(roleName, approleRoleTokenTtlRequest, approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthApproleRoleRoleNameTokenTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthapproletidysecretid"></a>
# **PostAuthApproleTidySecretId**
> void PostAuthApproleTidySecretId (string approleMountPath = null)

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
    public class PostAuthApproleTidySecretIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var approleMountPath = "\"approle\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "approle")

            try
            {
                // Trigger the clean-up of expired SecretID entries.
                apiInstance.PostAuthApproleTidySecretId(approleMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthApproleTidySecretId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **approleMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;approle&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthAwsConfigCertificateCertName (string certName, AwsConfigCertificateRequest awsConfigCertificateRequest, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthAwsConfigCertificateCertNameExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.PostAuthAwsConfigCertificateCertName(certName, awsConfigCertificateRequest, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthAwsConfigCertificateCertName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthAwsConfigClient (AwsConfigClientRequest awsConfigClientRequest, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthAwsConfigClientExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.PostAuthAwsConfigClient(awsConfigClientRequest, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthAwsConfigClient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthAwsConfigIdentity (AwsConfigIdentityRequest awsConfigIdentityRequest, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthAwsConfigIdentityExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.PostAuthAwsConfigIdentity(awsConfigIdentityRequest, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthAwsConfigIdentity: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthAwsConfigRotateRoot (string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthAwsConfigRotateRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.PostAuthAwsConfigRotateRoot(awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthAwsConfigRotateRoot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthAwsConfigStsAccountId (string accountId, AwsConfigStsRequest awsConfigStsRequest, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthAwsConfigStsAccountIdExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.PostAuthAwsConfigStsAccountId(accountId, awsConfigStsRequest, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthAwsConfigStsAccountId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthAwsConfigTidyIdentityAccesslist (AwsConfigTidyIdentityAccesslistRequest awsConfigTidyIdentityAccesslistRequest, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthAwsConfigTidyIdentityAccesslistExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.PostAuthAwsConfigTidyIdentityAccesslist(awsConfigTidyIdentityAccesslistRequest, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthAwsConfigTidyIdentityAccesslist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthAwsConfigTidyIdentityWhitelist (AwsConfigTidyIdentityWhitelistRequest awsConfigTidyIdentityWhitelistRequest, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthAwsConfigTidyIdentityWhitelistExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.PostAuthAwsConfigTidyIdentityWhitelist(awsConfigTidyIdentityWhitelistRequest, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthAwsConfigTidyIdentityWhitelist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthAwsConfigTidyRoletagBlacklist (AwsConfigTidyRoletagBlacklistRequest awsConfigTidyRoletagBlacklistRequest, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthAwsConfigTidyRoletagBlacklistExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.PostAuthAwsConfigTidyRoletagBlacklist(awsConfigTidyRoletagBlacklistRequest, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthAwsConfigTidyRoletagBlacklist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthAwsConfigTidyRoletagDenylist (AwsConfigTidyRoletagDenylistRequest awsConfigTidyRoletagDenylistRequest, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthAwsConfigTidyRoletagDenylistExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.PostAuthAwsConfigTidyRoletagDenylist(awsConfigTidyRoletagDenylistRequest, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthAwsConfigTidyRoletagDenylist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthAwsLogin (AwsLoginRequest awsLoginRequest, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthAwsLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var awsLoginRequest = new AwsLoginRequest(); // AwsLoginRequest | 
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.PostAuthAwsLogin(awsLoginRequest, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthAwsLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsLoginRequest** | [**AwsLoginRequest**](AwsLoginRequest.md)|  | 
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthAwsRoleRole (string role, AwsRoleRequest awsRoleRequest, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthAwsRoleRoleExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.PostAuthAwsRoleRole(role, awsRoleRequest, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthAwsRoleRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthAwsRoleRoleTag (string role, AwsRoleTagRequest awsRoleTagRequest, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthAwsRoleRoleTagExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.PostAuthAwsRoleRoleTag(role, awsRoleTagRequest, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthAwsRoleRoleTag: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthAwsRoletagBlacklistRoleTag (string roleTag, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthAwsRoletagBlacklistRoleTagExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.PostAuthAwsRoletagBlacklistRoleTag(roleTag, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthAwsRoletagBlacklistRoleTag: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthAwsRoletagDenylistRoleTag (string roleTag, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthAwsRoletagDenylistRoleTagExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.PostAuthAwsRoletagDenylistRoleTag(roleTag, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthAwsRoletagDenylistRoleTag: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthAwsTidyIdentityAccesslist (AwsTidyIdentityAccesslistRequest awsTidyIdentityAccesslistRequest, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthAwsTidyIdentityAccesslistExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.PostAuthAwsTidyIdentityAccesslist(awsTidyIdentityAccesslistRequest, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthAwsTidyIdentityAccesslist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthAwsTidyIdentityWhitelist (AwsTidyIdentityWhitelistRequest awsTidyIdentityWhitelistRequest, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthAwsTidyIdentityWhitelistExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.PostAuthAwsTidyIdentityWhitelist(awsTidyIdentityWhitelistRequest, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthAwsTidyIdentityWhitelist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthAwsTidyRoletagBlacklist (AwsTidyRoletagBlacklistRequest awsTidyRoletagBlacklistRequest, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthAwsTidyRoletagBlacklistExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.PostAuthAwsTidyRoletagBlacklist(awsTidyRoletagBlacklistRequest, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthAwsTidyRoletagBlacklist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthAwsTidyRoletagDenylist (AwsTidyRoletagDenylistRequest awsTidyRoletagDenylistRequest, string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthAwsTidyRoletagDenylistExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.PostAuthAwsTidyRoletagDenylist(awsTidyRoletagDenylistRequest, awsMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthAwsTidyRoletagDenylist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthAzureConfig (AzureConfigRequest azureConfigRequest, string azureMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthAzureConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var azureConfigRequest = new AzureConfigRequest(); // AzureConfigRequest | 
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                apiInstance.PostAuthAzureConfig(azureConfigRequest, azureMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthAzureConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **azureConfigRequest** | [**AzureConfigRequest**](AzureConfigRequest.md)|  | 
 **azureMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;azure&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthAzureLogin (AzureLoginRequest azureLoginRequest, string azureMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthAzureLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var azureLoginRequest = new AzureLoginRequest(); // AzureLoginRequest | 
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                apiInstance.PostAuthAzureLogin(azureLoginRequest, azureMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthAzureLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **azureLoginRequest** | [**AzureLoginRequest**](AzureLoginRequest.md)|  | 
 **azureMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;azure&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthAzureRoleName (string name, AzureRoleRequest azureRoleRequest, string azureMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthAzureRoleNameExample
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
            var azureRoleRequest = new AzureRoleRequest(); // AzureRoleRequest | 
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                apiInstance.PostAuthAzureRoleName(name, azureRoleRequest, azureMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthAzureRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **azureRoleRequest** | [**AzureRoleRequest**](AzureRoleRequest.md)|  | 
 **azureMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;azure&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthCentrifyConfig (CentrifyConfigRequest centrifyConfigRequest, string centrifyMountPath = null)

This path allows you to configure the centrify auth provider to interact with the Centrify Identity Services Platform for authenticating users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthCentrifyConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var centrifyConfigRequest = new CentrifyConfigRequest(); // CentrifyConfigRequest | 
            var centrifyMountPath = "\"centrify\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "centrify")

            try
            {
                // This path allows you to configure the centrify auth provider to interact with the Centrify Identity Services Platform for authenticating users.
                apiInstance.PostAuthCentrifyConfig(centrifyConfigRequest, centrifyMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthCentrifyConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **centrifyConfigRequest** | [**CentrifyConfigRequest**](CentrifyConfigRequest.md)|  | 
 **centrifyMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;centrify&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthCentrifyLogin (CentrifyLoginRequest centrifyLoginRequest, string centrifyMountPath = null)

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
    public class PostAuthCentrifyLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var centrifyLoginRequest = new CentrifyLoginRequest(); // CentrifyLoginRequest | 
            var centrifyMountPath = "\"centrify\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "centrify")

            try
            {
                // Log in with a username and password.
                apiInstance.PostAuthCentrifyLogin(centrifyLoginRequest, centrifyMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthCentrifyLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **centrifyLoginRequest** | [**CentrifyLoginRequest**](CentrifyLoginRequest.md)|  | 
 **centrifyMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;centrify&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthCertCertsName (string name, CertCertsRequest certCertsRequest, string certMountPath = null)

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
    public class PostAuthCertCertsNameExample
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
            var certMountPath = "\"cert\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cert")

            try
            {
                // Manage trusted certificates used for authentication.
                apiInstance.PostAuthCertCertsName(name, certCertsRequest, certMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthCertCertsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **certMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cert&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthCertConfig (CertConfigRequest certConfigRequest, string certMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthCertConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var certConfigRequest = new CertConfigRequest(); // CertConfigRequest | 
            var certMountPath = "\"cert\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cert")

            try
            {
                apiInstance.PostAuthCertConfig(certConfigRequest, certMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthCertConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **certConfigRequest** | [**CertConfigRequest**](CertConfigRequest.md)|  | 
 **certMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cert&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthCertCrlsName (string name, CertCrlsRequest certCrlsRequest, string certMountPath = null)

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
    public class PostAuthCertCrlsNameExample
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
            var certMountPath = "\"cert\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cert")

            try
            {
                // Manage Certificate Revocation Lists checked during authentication.
                apiInstance.PostAuthCertCrlsName(name, certCrlsRequest, certMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthCertCrlsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **certMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cert&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthCertLogin (CertLoginRequest certLoginRequest, string certMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthCertLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var certLoginRequest = new CertLoginRequest(); // CertLoginRequest | 
            var certMountPath = "\"cert\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cert")

            try
            {
                apiInstance.PostAuthCertLogin(certLoginRequest, certMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthCertLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **certLoginRequest** | [**CertLoginRequest**](CertLoginRequest.md)|  | 
 **certMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cert&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthCfConfig (CfConfigRequest cfConfigRequest, string cfMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthCfConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var cfConfigRequest = new CfConfigRequest(); // CfConfigRequest | 
            var cfMountPath = "\"cf\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cf")

            try
            {
                apiInstance.PostAuthCfConfig(cfConfigRequest, cfMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthCfConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cfConfigRequest** | [**CfConfigRequest**](CfConfigRequest.md)|  | 
 **cfMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cf&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthCfLogin (CfLoginRequest cfLoginRequest, string cfMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthCfLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var cfLoginRequest = new CfLoginRequest(); // CfLoginRequest | 
            var cfMountPath = "\"cf\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cf")

            try
            {
                apiInstance.PostAuthCfLogin(cfLoginRequest, cfMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthCfLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cfLoginRequest** | [**CfLoginRequest**](CfLoginRequest.md)|  | 
 **cfMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cf&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthCfRolesRole (string role, CfRolesRequest cfRolesRequest, string cfMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthCfRolesRoleExample
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
            var cfMountPath = "\"cf\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cf")

            try
            {
                apiInstance.PostAuthCfRolesRole(role, cfRolesRequest, cfMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthCfRolesRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **cfMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cf&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthGcpConfig (GcpConfigRequest gcpConfigRequest, string gcpMountPath = null)

Configure credentials used to query the GCP IAM API to verify authenticating service accounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthGcpConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var gcpConfigRequest = new GcpConfigRequest(); // GcpConfigRequest | 
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                // Configure credentials used to query the GCP IAM API to verify authenticating service accounts
                apiInstance.PostAuthGcpConfig(gcpConfigRequest, gcpMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthGcpConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gcpConfigRequest** | [**GcpConfigRequest**](GcpConfigRequest.md)|  | 
 **gcpMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcp&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthGcpLogin (GcpLoginRequest gcpLoginRequest, string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthGcpLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var gcpLoginRequest = new GcpLoginRequest(); // GcpLoginRequest | 
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.PostAuthGcpLogin(gcpLoginRequest, gcpMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthGcpLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gcpLoginRequest** | [**GcpLoginRequest**](GcpLoginRequest.md)|  | 
 **gcpMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcp&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthGcpRoleName (string name, GcpRoleRequest gcpRoleRequest, string gcpMountPath = null)

Create a GCP role with associated policies and required attributes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthGcpRoleNameExample
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
            var gcpRoleRequest = new GcpRoleRequest(); // GcpRoleRequest | 
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                // Create a GCP role with associated policies and required attributes.
                apiInstance.PostAuthGcpRoleName(name, gcpRoleRequest, gcpMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthGcpRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **gcpRoleRequest** | [**GcpRoleRequest**](GcpRoleRequest.md)|  | 
 **gcpMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcp&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthGcpRoleNameLabels (string name, GcpRoleLabelsRequest gcpRoleLabelsRequest, string gcpMountPath = null)

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
    public class PostAuthGcpRoleNameLabelsExample
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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                // Add or remove labels for an existing 'gce' role
                apiInstance.PostAuthGcpRoleNameLabels(name, gcpRoleLabelsRequest, gcpMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthGcpRoleNameLabels: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **gcpMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcp&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthGcpRoleNameServiceAccounts (string name, GcpRoleServiceAccountsRequest gcpRoleServiceAccountsRequest, string gcpMountPath = null)

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
    public class PostAuthGcpRoleNameServiceAccountsExample
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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                // Add or remove service accounts for an existing `iam` role
                apiInstance.PostAuthGcpRoleNameServiceAccounts(name, gcpRoleServiceAccountsRequest, gcpMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthGcpRoleNameServiceAccounts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **gcpMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcp&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthGithubConfig (GithubConfigRequest githubConfigRequest, string githubMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthGithubConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var githubConfigRequest = new GithubConfigRequest(); // GithubConfigRequest | 
            var githubMountPath = "\"github\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "github")

            try
            {
                apiInstance.PostAuthGithubConfig(githubConfigRequest, githubMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthGithubConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **githubConfigRequest** | [**GithubConfigRequest**](GithubConfigRequest.md)|  | 
 **githubMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;github&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthGithubLogin (GithubLoginRequest githubLoginRequest, string githubMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthGithubLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var githubLoginRequest = new GithubLoginRequest(); // GithubLoginRequest | 
            var githubMountPath = "\"github\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "github")

            try
            {
                apiInstance.PostAuthGithubLogin(githubLoginRequest, githubMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthGithubLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **githubLoginRequest** | [**GithubLoginRequest**](GithubLoginRequest.md)|  | 
 **githubMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;github&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthGithubMapTeamsKey (string key, GithubMapTeamsRequest githubMapTeamsRequest, string githubMountPath = null)

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
    public class PostAuthGithubMapTeamsKeyExample
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
            var githubMountPath = "\"github\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "github")

            try
            {
                // Read/write/delete a single teams mapping
                apiInstance.PostAuthGithubMapTeamsKey(key, githubMapTeamsRequest, githubMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthGithubMapTeamsKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **githubMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;github&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthGithubMapUsersKey (string key, GithubMapUsersRequest githubMapUsersRequest, string githubMountPath = null)

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
    public class PostAuthGithubMapUsersKeyExample
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
            var githubMountPath = "\"github\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "github")

            try
            {
                // Read/write/delete a single users mapping
                apiInstance.PostAuthGithubMapUsersKey(key, githubMapUsersRequest, githubMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthGithubMapUsersKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **githubMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;github&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthJwtConfig (JwtConfigRequest jwtConfigRequest, string jwtMountPath = null)

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
    public class PostAuthJwtConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var jwtConfigRequest = new JwtConfigRequest(); // JwtConfigRequest | 
            var jwtMountPath = "\"jwt\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "jwt")

            try
            {
                // Configure the JWT authentication backend.
                apiInstance.PostAuthJwtConfig(jwtConfigRequest, jwtMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthJwtConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jwtConfigRequest** | [**JwtConfigRequest**](JwtConfigRequest.md)|  | 
 **jwtMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;jwt&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthJwtLogin (JwtLoginRequest jwtLoginRequest, string jwtMountPath = null)

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
    public class PostAuthJwtLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var jwtLoginRequest = new JwtLoginRequest(); // JwtLoginRequest | 
            var jwtMountPath = "\"jwt\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "jwt")

            try
            {
                // Authenticates to Vault using a JWT (or OIDC) token.
                apiInstance.PostAuthJwtLogin(jwtLoginRequest, jwtMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthJwtLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jwtLoginRequest** | [**JwtLoginRequest**](JwtLoginRequest.md)|  | 
 **jwtMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;jwt&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthJwtOidcAuthUrl (JwtOidcAuthUrlRequest jwtOidcAuthUrlRequest, string jwtMountPath = null)

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
    public class PostAuthJwtOidcAuthUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var jwtOidcAuthUrlRequest = new JwtOidcAuthUrlRequest(); // JwtOidcAuthUrlRequest | 
            var jwtMountPath = "\"jwt\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "jwt")

            try
            {
                // Request an authorization URL to start an OIDC login flow.
                apiInstance.PostAuthJwtOidcAuthUrl(jwtOidcAuthUrlRequest, jwtMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthJwtOidcAuthUrl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jwtOidcAuthUrlRequest** | [**JwtOidcAuthUrlRequest**](JwtOidcAuthUrlRequest.md)|  | 
 **jwtMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;jwt&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthJwtOidcCallback (JwtOidcCallbackRequest jwtOidcCallbackRequest, string jwtMountPath = null)

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
    public class PostAuthJwtOidcCallbackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var jwtOidcCallbackRequest = new JwtOidcCallbackRequest(); // JwtOidcCallbackRequest | 
            var jwtMountPath = "\"jwt\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "jwt")

            try
            {
                // Callback endpoint to handle form_posts.
                apiInstance.PostAuthJwtOidcCallback(jwtOidcCallbackRequest, jwtMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthJwtOidcCallback: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jwtOidcCallbackRequest** | [**JwtOidcCallbackRequest**](JwtOidcCallbackRequest.md)|  | 
 **jwtMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;jwt&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthJwtRoleName (string name, JwtRoleRequest jwtRoleRequest, string jwtMountPath = null)

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
    public class PostAuthJwtRoleNameExample
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
            var jwtRoleRequest = new JwtRoleRequest(); // JwtRoleRequest | 
            var jwtMountPath = "\"jwt\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "jwt")

            try
            {
                // Register an role with the backend.
                apiInstance.PostAuthJwtRoleName(name, jwtRoleRequest, jwtMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthJwtRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **jwtRoleRequest** | [**JwtRoleRequest**](JwtRoleRequest.md)|  | 
 **jwtMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;jwt&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthKerberosConfig (KerberosConfigRequest kerberosConfigRequest, string kerberosMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthKerberosConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var kerberosConfigRequest = new KerberosConfigRequest(); // KerberosConfigRequest | 
            var kerberosMountPath = "\"kerberos\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kerberos")

            try
            {
                apiInstance.PostAuthKerberosConfig(kerberosConfigRequest, kerberosMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthKerberosConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kerberosConfigRequest** | [**KerberosConfigRequest**](KerberosConfigRequest.md)|  | 
 **kerberosMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kerberos&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthKerberosConfigLdap (KerberosConfigLdapRequest kerberosConfigLdapRequest, string kerberosMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthKerberosConfigLdapExample
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
            var kerberosMountPath = "\"kerberos\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kerberos")

            try
            {
                apiInstance.PostAuthKerberosConfigLdap(kerberosConfigLdapRequest, kerberosMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthKerberosConfigLdap: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **kerberosMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kerberos&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthKerberosGroupsName (string name, KerberosGroupsRequest kerberosGroupsRequest, string kerberosMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthKerberosGroupsNameExample
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
            var kerberosMountPath = "\"kerberos\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kerberos")

            try
            {
                apiInstance.PostAuthKerberosGroupsName(name, kerberosGroupsRequest, kerberosMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthKerberosGroupsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **kerberosMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kerberos&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthKerberosLogin (KerberosLoginRequest kerberosLoginRequest, string kerberosMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthKerberosLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var kerberosLoginRequest = new KerberosLoginRequest(); // KerberosLoginRequest | 
            var kerberosMountPath = "\"kerberos\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kerberos")

            try
            {
                apiInstance.PostAuthKerberosLogin(kerberosLoginRequest, kerberosMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthKerberosLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kerberosLoginRequest** | [**KerberosLoginRequest**](KerberosLoginRequest.md)|  | 
 **kerberosMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kerberos&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthKubernetesConfig (KubernetesConfigRequest kubernetesConfigRequest, string kubernetesMountPath = null)

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
    public class PostAuthKubernetesConfigExample
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
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                // Configures the JWT Public Key and Kubernetes API information.
                apiInstance.PostAuthKubernetesConfig(kubernetesConfigRequest, kubernetesMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthKubernetesConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **kubernetesMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kubernetes&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthKubernetesLogin (KubernetesLoginRequest kubernetesLoginRequest, string kubernetesMountPath = null)

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
    public class PostAuthKubernetesLoginExample
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
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                // Authenticates Kubernetes service accounts with Vault.
                apiInstance.PostAuthKubernetesLogin(kubernetesLoginRequest, kubernetesMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthKubernetesLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **kubernetesMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kubernetes&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthKubernetesRoleName (string name, KubernetesRoleRequest kubernetesRoleRequest, string kubernetesMountPath = null)

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
    public class PostAuthKubernetesRoleNameExample
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
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                // Register an role with the backend.
                apiInstance.PostAuthKubernetesRoleName(name, kubernetesRoleRequest, kubernetesMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthKubernetesRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **kubernetesMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kubernetes&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthLdapConfig (LdapConfigRequest ldapConfigRequest, string ldapMountPath = null)

Configure the LDAP server to connect to, along with its options.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthLdapConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var ldapConfigRequest = new LdapConfigRequest(); // LdapConfigRequest | 
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                // Configure the LDAP server to connect to, along with its options.
                apiInstance.PostAuthLdapConfig(ldapConfigRequest, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthLdapConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ldapConfigRequest** | [**LdapConfigRequest**](LdapConfigRequest.md)|  | 
 **ldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthLdapGroupsName (string name, LdapGroupsRequest ldapGroupsRequest, string ldapMountPath = null)

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
    public class PostAuthLdapGroupsNameExample
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
            var ldapGroupsRequest = new LdapGroupsRequest(); // LdapGroupsRequest | 
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                // Manage additional groups for users allowed to authenticate.
                apiInstance.PostAuthLdapGroupsName(name, ldapGroupsRequest, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthLdapGroupsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **ldapGroupsRequest** | [**LdapGroupsRequest**](LdapGroupsRequest.md)|  | 
 **ldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthLdapLoginUsername (string username, LdapLoginRequest ldapLoginRequest, string ldapMountPath = null)

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
    public class PostAuthLdapLoginUsernameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var username = "username_example";  // string | DN (distinguished name) to be used for login.
            var ldapLoginRequest = new LdapLoginRequest(); // LdapLoginRequest | 
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                // Log in with a username and password.
                apiInstance.PostAuthLdapLoginUsername(username, ldapLoginRequest, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthLdapLoginUsername: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **ldapLoginRequest** | [**LdapLoginRequest**](LdapLoginRequest.md)|  | 
 **ldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthLdapUsersName (string name, LdapUsersRequest ldapUsersRequest, string ldapMountPath = null)

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
    public class PostAuthLdapUsersNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | Name of the LDAP user.
            var ldapUsersRequest = new LdapUsersRequest(); // LdapUsersRequest | 
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.PostAuthLdapUsersName(name, ldapUsersRequest, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthLdapUsersName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **ldapUsersRequest** | [**LdapUsersRequest**](LdapUsersRequest.md)|  | 
 **ldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthOciConfig (OciConfigRequest ociConfigRequest, string ociMountPath = null)

Manages the configuration for the Vault Auth Plugin.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthOciConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var ociConfigRequest = new OciConfigRequest(); // OciConfigRequest | 
            var ociMountPath = "\"oci\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oci")

            try
            {
                // Manages the configuration for the Vault Auth Plugin.
                apiInstance.PostAuthOciConfig(ociConfigRequest, ociMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthOciConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ociConfigRequest** | [**OciConfigRequest**](OciConfigRequest.md)|  | 
 **ociMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oci&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthOciLoginRole (string role, OciLoginRequest ociLoginRequest, string ociMountPath = null)

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
    public class PostAuthOciLoginRoleExample
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
            var ociMountPath = "\"oci\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oci")

            try
            {
                // Authenticates to Vault using OCI credentials
                apiInstance.PostAuthOciLoginRole(role, ociLoginRequest, ociMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthOciLoginRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **ociMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oci&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthOciRoleRole (string role, OciRoleRequest ociRoleRequest, string ociMountPath = null)

Create a role and associate policies to it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthOciRoleRoleExample
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
            var ociRoleRequest = new OciRoleRequest(); // OciRoleRequest | 
            var ociMountPath = "\"oci\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oci")

            try
            {
                // Create a role and associate policies to it.
                apiInstance.PostAuthOciRoleRole(role, ociRoleRequest, ociMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthOciRoleRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **ociRoleRequest** | [**OciRoleRequest**](OciRoleRequest.md)|  | 
 **ociMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oci&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthOidcConfig (OidcConfigRequest oidcConfigRequest, string oidcMountPath = null)

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
    public class PostAuthOidcConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var oidcConfigRequest = new OidcConfigRequest(); // OidcConfigRequest | 
            var oidcMountPath = "\"oidc\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oidc")

            try
            {
                // Configure the JWT authentication backend.
                apiInstance.PostAuthOidcConfig(oidcConfigRequest, oidcMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthOidcConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oidcConfigRequest** | [**OidcConfigRequest**](OidcConfigRequest.md)|  | 
 **oidcMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oidc&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthOidcLogin (OidcLoginRequest oidcLoginRequest, string oidcMountPath = null)

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
    public class PostAuthOidcLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var oidcLoginRequest = new OidcLoginRequest(); // OidcLoginRequest | 
            var oidcMountPath = "\"oidc\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oidc")

            try
            {
                // Authenticates to Vault using a JWT (or OIDC) token.
                apiInstance.PostAuthOidcLogin(oidcLoginRequest, oidcMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthOidcLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oidcLoginRequest** | [**OidcLoginRequest**](OidcLoginRequest.md)|  | 
 **oidcMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oidc&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthOidcOidcAuthUrl (OidcOidcAuthUrlRequest oidcOidcAuthUrlRequest, string oidcMountPath = null)

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
    public class PostAuthOidcOidcAuthUrlExample
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
            var oidcMountPath = "\"oidc\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oidc")

            try
            {
                // Request an authorization URL to start an OIDC login flow.
                apiInstance.PostAuthOidcOidcAuthUrl(oidcOidcAuthUrlRequest, oidcMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthOidcOidcAuthUrl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **oidcMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oidc&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthOidcOidcCallback (OidcOidcCallbackRequest oidcOidcCallbackRequest, string oidcMountPath = null)

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
    public class PostAuthOidcOidcCallbackExample
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
            var oidcMountPath = "\"oidc\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oidc")

            try
            {
                // Callback endpoint to handle form_posts.
                apiInstance.PostAuthOidcOidcCallback(oidcOidcCallbackRequest, oidcMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthOidcOidcCallback: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **oidcMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oidc&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthOidcRoleName (string name, OidcRoleRequest oidcRoleRequest, string oidcMountPath = null)

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
    public class PostAuthOidcRoleNameExample
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
            var oidcRoleRequest = new OidcRoleRequest(); // OidcRoleRequest | 
            var oidcMountPath = "\"oidc\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "oidc")

            try
            {
                // Register an role with the backend.
                apiInstance.PostAuthOidcRoleName(name, oidcRoleRequest, oidcMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthOidcRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **oidcRoleRequest** | [**OidcRoleRequest**](OidcRoleRequest.md)|  | 
 **oidcMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;oidc&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthOktaConfig (OktaConfigRequest oktaConfigRequest, string oktaMountPath = null)

This endpoint allows you to configure the Okta and its configuration options.  The Okta organization are the characters at the front of the URL for Okta. Example https://ORG.okta.com

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthOktaConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var oktaConfigRequest = new OktaConfigRequest(); // OktaConfigRequest | 
            var oktaMountPath = "\"okta\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "okta")

            try
            {
                // This endpoint allows you to configure the Okta and its configuration options.  The Okta organization are the characters at the front of the URL for Okta. Example https://ORG.okta.com
                apiInstance.PostAuthOktaConfig(oktaConfigRequest, oktaMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthOktaConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oktaConfigRequest** | [**OktaConfigRequest**](OktaConfigRequest.md)|  | 
 **oktaMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;okta&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthOktaGroupsName (string name, OktaGroupsRequest oktaGroupsRequest, string oktaMountPath = null)

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
    public class PostAuthOktaGroupsNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | Name of the Okta group.
            var oktaGroupsRequest = new OktaGroupsRequest(); // OktaGroupsRequest | 
            var oktaMountPath = "\"okta\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "okta")

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.PostAuthOktaGroupsName(name, oktaGroupsRequest, oktaMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthOktaGroupsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **oktaGroupsRequest** | [**OktaGroupsRequest**](OktaGroupsRequest.md)|  | 
 **oktaMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;okta&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthOktaLoginUsername (string username, OktaLoginRequest oktaLoginRequest, string oktaMountPath = null)

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
    public class PostAuthOktaLoginUsernameExample
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
            var oktaMountPath = "\"okta\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "okta")

            try
            {
                // Log in with a username and password.
                apiInstance.PostAuthOktaLoginUsername(username, oktaLoginRequest, oktaMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthOktaLoginUsername: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **oktaMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;okta&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthOktaUsersName (string name, OktaUsersRequest oktaUsersRequest, string oktaMountPath = null)

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
    public class PostAuthOktaUsersNameExample
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
            var oktaMountPath = "\"okta\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "okta")

            try
            {
                // Manage additional groups for users allowed to authenticate.
                apiInstance.PostAuthOktaUsersName(name, oktaUsersRequest, oktaMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthOktaUsersName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **oktaMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;okta&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthRadiusConfig (RadiusConfigRequest radiusConfigRequest, string radiusMountPath = null)

Configure the RADIUS server to connect to, along with its options.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthRadiusConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var radiusConfigRequest = new RadiusConfigRequest(); // RadiusConfigRequest | 
            var radiusMountPath = "\"radius\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "radius")

            try
            {
                // Configure the RADIUS server to connect to, along with its options.
                apiInstance.PostAuthRadiusConfig(radiusConfigRequest, radiusMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthRadiusConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **radiusConfigRequest** | [**RadiusConfigRequest**](RadiusConfigRequest.md)|  | 
 **radiusMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;radius&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthRadiusLogin (RadiusLoginRequest radiusLoginRequest, string radiusMountPath = null)

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
    public class PostAuthRadiusLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var radiusLoginRequest = new RadiusLoginRequest(); // RadiusLoginRequest | 
            var radiusMountPath = "\"radius\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "radius")

            try
            {
                // Log in with a username and password.
                apiInstance.PostAuthRadiusLogin(radiusLoginRequest, radiusMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthRadiusLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **radiusLoginRequest** | [**RadiusLoginRequest**](RadiusLoginRequest.md)|  | 
 **radiusMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;radius&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthRadiusLoginUrlusername (string urlusername, RadiusLoginRequest radiusLoginRequest, string radiusMountPath = null)

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
    public class PostAuthRadiusLoginUrlusernameExample
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
            var radiusMountPath = "\"radius\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "radius")

            try
            {
                // Log in with a username and password.
                apiInstance.PostAuthRadiusLoginUrlusername(urlusername, radiusLoginRequest, radiusMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthRadiusLoginUrlusername: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **radiusMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;radius&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthRadiusUsersName (string name, RadiusUsersRequest radiusUsersRequest, string radiusMountPath = null)

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
    public class PostAuthRadiusUsersNameExample
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
            var radiusUsersRequest = new RadiusUsersRequest(); // RadiusUsersRequest | 
            var radiusMountPath = "\"radius\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "radius")

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.PostAuthRadiusUsersName(name, radiusUsersRequest, radiusMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthRadiusUsersName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **radiusUsersRequest** | [**RadiusUsersRequest**](RadiusUsersRequest.md)|  | 
 **radiusMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;radius&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthTokenCreate (TokenCreateRequest tokenCreateRequest, string format = null, string tokenMountPath = null)

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
    public class PostAuthTokenCreateExample
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
            var format = "\"\"";  // string | Return json formatted output (optional)  (default to "")
            var tokenMountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // The token create path is used to create new tokens.
                apiInstance.PostAuthTokenCreate(tokenCreateRequest, format, tokenMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthTokenCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **format** | **string**| Return json formatted output | [optional] [default to &quot;&quot;]
 **tokenMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthtokencreateorphan"></a>
# **PostAuthTokenCreateOrphan**
> void PostAuthTokenCreateOrphan (TokenCreateOrphanRequest tokenCreateOrphanRequest, string format = null, string tokenMountPath = null)

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
    public class PostAuthTokenCreateOrphanExample
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
            var format = "\"\"";  // string | Return json formatted output (optional)  (default to "")
            var tokenMountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // The token create path is used to create new orphan tokens.
                apiInstance.PostAuthTokenCreateOrphan(tokenCreateOrphanRequest, format, tokenMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthTokenCreateOrphan: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **format** | **string**| Return json formatted output | [optional] [default to &quot;&quot;]
 **tokenMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthtokencreaterolename"></a>
# **PostAuthTokenCreateRoleName**
> void PostAuthTokenCreateRoleName (string roleName, TokenCreateRequest tokenCreateRequest, string format = null, string tokenMountPath = null)

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
    public class PostAuthTokenCreateRoleNameExample
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
            var format = "\"\"";  // string | Return json formatted output (optional)  (default to "")
            var tokenMountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This token create path is used to create new tokens adhering to the given role.
                apiInstance.PostAuthTokenCreateRoleName(roleName, tokenCreateRequest, format, tokenMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthTokenCreateRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **format** | **string**| Return json formatted output | [optional] [default to &quot;&quot;]
 **tokenMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthtokenlookup"></a>
# **PostAuthTokenLookup**
> void PostAuthTokenLookup (TokenLookupRequest tokenLookupRequest, string tokenMountPath = null)

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
    public class PostAuthTokenLookupExample
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
            var tokenMountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint will lookup a token and its properties.
                apiInstance.PostAuthTokenLookup(tokenLookupRequest, tokenMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthTokenLookup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **tokenMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthTokenLookupAccessor (TokenLookupAccessorRequest tokenLookupAccessorRequest, string tokenMountPath = null)

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
    public class PostAuthTokenLookupAccessorExample
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
            var tokenMountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint will lookup a token associated with the given accessor and its properties. Response will not contain the token ID.
                apiInstance.PostAuthTokenLookupAccessor(tokenLookupAccessorRequest, tokenMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthTokenLookupAccessor: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **tokenMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthTokenLookupSelf (TokenLookupSelfRequest tokenLookupSelfRequest, string tokenMountPath = null)

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
    public class PostAuthTokenLookupSelfExample
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
            var tokenMountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint will lookup a token and its properties.
                apiInstance.PostAuthTokenLookupSelf(tokenLookupSelfRequest, tokenMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthTokenLookupSelf: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **tokenMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthTokenRenew (TokenRenewRequest tokenRenewRequest, string tokenMountPath = null)

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
    public class PostAuthTokenRenewExample
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
            var tokenMountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint will renew the given token and prevent expiration.
                apiInstance.PostAuthTokenRenew(tokenRenewRequest, tokenMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthTokenRenew: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **tokenMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthTokenRenewAccessor (TokenRenewAccessorRequest tokenRenewAccessorRequest, string tokenMountPath = null)

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
    public class PostAuthTokenRenewAccessorExample
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
            var tokenMountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint will renew a token associated with the given accessor and its properties. Response will not contain the token ID.
                apiInstance.PostAuthTokenRenewAccessor(tokenRenewAccessorRequest, tokenMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthTokenRenewAccessor: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **tokenMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthTokenRenewSelf (TokenRenewSelfRequest tokenRenewSelfRequest, string tokenMountPath = null)

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
    public class PostAuthTokenRenewSelfExample
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
            var tokenMountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint will renew the token used to call it and prevent expiration.
                apiInstance.PostAuthTokenRenewSelf(tokenRenewSelfRequest, tokenMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthTokenRenewSelf: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **tokenMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthTokenRevoke (TokenRevokeRequest tokenRevokeRequest, string tokenMountPath = null)

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
    public class PostAuthTokenRevokeExample
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
            var tokenMountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint will delete the given token and all of its child tokens.
                apiInstance.PostAuthTokenRevoke(tokenRevokeRequest, tokenMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthTokenRevoke: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **tokenMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthTokenRevokeAccessor (TokenRevokeAccessorRequest tokenRevokeAccessorRequest, string tokenMountPath = null)

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
    public class PostAuthTokenRevokeAccessorExample
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
            var tokenMountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint will delete the token associated with the accessor and all of its child tokens.
                apiInstance.PostAuthTokenRevokeAccessor(tokenRevokeAccessorRequest, tokenMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthTokenRevokeAccessor: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **tokenMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthTokenRevokeOrphan (TokenRevokeOrphanRequest tokenRevokeOrphanRequest, string tokenMountPath = null)

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
    public class PostAuthTokenRevokeOrphanExample
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
            var tokenMountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint will delete the token and orphan its child tokens.
                apiInstance.PostAuthTokenRevokeOrphan(tokenRevokeOrphanRequest, tokenMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthTokenRevokeOrphan: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **tokenMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthTokenRevokeSelf (string tokenMountPath = null)

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
    public class PostAuthTokenRevokeSelfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var tokenMountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint will delete the token used to call it and all of its child tokens.
                apiInstance.PostAuthTokenRevokeSelf(tokenMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthTokenRevokeSelf: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthTokenRolesRoleName (string roleName, TokenRolesRequest tokenRolesRequest, string tokenMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostAuthTokenRolesRoleNameExample
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
            var tokenMountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                apiInstance.PostAuthTokenRolesRoleName(roleName, tokenRolesRequest, tokenMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthTokenRolesRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **tokenMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthTokenTidy (string tokenMountPath = null)

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
    public class PostAuthTokenTidyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            var tokenMountPath = "\"token\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "token")

            try
            {
                // This endpoint performs cleanup tasks that can be run if certain error conditions have occurred.
                apiInstance.PostAuthTokenTidy(tokenMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthTokenTidy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;token&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthUserpassLoginUsername (string username, UserpassLoginRequest userpassLoginRequest, string userpassMountPath = null)

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
    public class PostAuthUserpassLoginUsernameExample
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
            var userpassLoginRequest = new UserpassLoginRequest(); // UserpassLoginRequest | 
            var userpassMountPath = "\"userpass\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "userpass")

            try
            {
                // Log in with a username and password.
                apiInstance.PostAuthUserpassLoginUsername(username, userpassLoginRequest, userpassMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthUserpassLoginUsername: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **userpassLoginRequest** | [**UserpassLoginRequest**](UserpassLoginRequest.md)|  | 
 **userpassMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;userpass&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthUserpassUsersUsername (string username, UserpassUsersRequest userpassUsersRequest, string userpassMountPath = null)

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
    public class PostAuthUserpassUsersUsernameExample
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
            var userpassMountPath = "\"userpass\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "userpass")

            try
            {
                // Manage users allowed to authenticate.
                apiInstance.PostAuthUserpassUsersUsername(username, userpassUsersRequest, userpassMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthUserpassUsersUsername: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **userpassMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;userpass&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthUserpassUsersUsernamePassword (string username, UserpassUsersPasswordRequest userpassUsersPasswordRequest, string userpassMountPath = null)

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
    public class PostAuthUserpassUsersUsernamePasswordExample
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
            var userpassMountPath = "\"userpass\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "userpass")

            try
            {
                // Reset user's password.
                apiInstance.PostAuthUserpassUsersUsernamePassword(username, userpassUsersPasswordRequest, userpassMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthUserpassUsersUsernamePassword: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **userpassMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;userpass&quot;]

### Return type

void (empty response body)

### Authorization

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
> void PostAuthUserpassUsersUsernamePolicies (string username, UserpassUsersPoliciesRequest userpassUsersPoliciesRequest, string userpassMountPath = null)

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
    public class PostAuthUserpassUsersUsernamePoliciesExample
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
            var userpassMountPath = "\"userpass\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "userpass")

            try
            {
                // Update the policies associated with the username.
                apiInstance.PostAuthUserpassUsersUsernamePolicies(username, userpassUsersPoliciesRequest, userpassMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.PostAuthUserpassUsersUsernamePolicies: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **userpassMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;userpass&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

