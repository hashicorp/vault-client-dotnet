# Vault.Api.Auth

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AliCloudDeleteAuthRole**](AuthApi.md#aliclouddeleteauthrole) | **DELETE** /auth/{alicloud_mount_path}/role/{role} | Create a role and associate policies to it.
[**AliCloudListAuthRoles**](AuthApi.md#alicloudlistauthroles) | **GET** /auth/{alicloud_mount_path}/role/ | Lists all the roles that are registered with Vault.
[**AliCloudLogin**](AuthApi.md#alicloudlogin) | **POST** /auth/{alicloud_mount_path}/login | Authenticates an RAM entity with Vault.
[**AliCloudReadAuthRole**](AuthApi.md#alicloudreadauthrole) | **GET** /auth/{alicloud_mount_path}/role/{role} | Create a role and associate policies to it.
[**AliCloudWriteAuthRole**](AuthApi.md#alicloudwriteauthrole) | **POST** /auth/{alicloud_mount_path}/role/{role} | Create a role and associate policies to it.
[**AppRoleDeleteBindSecretId**](AuthApi.md#approledeletebindsecretid) | **DELETE** /auth/{approle_mount_path}/role/{role_name}/bind-secret-id | 
[**AppRoleDeleteBoundCidrList**](AuthApi.md#approledeleteboundcidrlist) | **DELETE** /auth/{approle_mount_path}/role/{role_name}/bound-cidr-list | 
[**AppRoleDeletePeriod**](AuthApi.md#approledeleteperiod) | **DELETE** /auth/{approle_mount_path}/role/{role_name}/period | 
[**AppRoleDeletePolicies**](AuthApi.md#approledeletepolicies) | **DELETE** /auth/{approle_mount_path}/role/{role_name}/policies | 
[**AppRoleDeleteRole**](AuthApi.md#approledeleterole) | **DELETE** /auth/{approle_mount_path}/role/{role_name} | 
[**AppRoleDeleteSecretIdBoundCidrs**](AuthApi.md#approledeletesecretidboundcidrs) | **DELETE** /auth/{approle_mount_path}/role/{role_name}/secret-id-bound-cidrs | 
[**AppRoleDeleteSecretIdNumUses**](AuthApi.md#approledeletesecretidnumuses) | **DELETE** /auth/{approle_mount_path}/role/{role_name}/secret-id-num-uses | 
[**AppRoleDeleteSecretIdTtl**](AuthApi.md#approledeletesecretidttl) | **DELETE** /auth/{approle_mount_path}/role/{role_name}/secret-id-ttl | 
[**AppRoleDeleteTokenBoundCidrs**](AuthApi.md#approledeletetokenboundcidrs) | **DELETE** /auth/{approle_mount_path}/role/{role_name}/token-bound-cidrs | 
[**AppRoleDeleteTokenMaxTtl**](AuthApi.md#approledeletetokenmaxttl) | **DELETE** /auth/{approle_mount_path}/role/{role_name}/token-max-ttl | 
[**AppRoleDeleteTokenNumUses**](AuthApi.md#approledeletetokennumuses) | **DELETE** /auth/{approle_mount_path}/role/{role_name}/token-num-uses | 
[**AppRoleDeleteTokenTtl**](AuthApi.md#approledeletetokenttl) | **DELETE** /auth/{approle_mount_path}/role/{role_name}/token-ttl | 
[**AppRoleDestroySecretId**](AuthApi.md#approledestroysecretid) | **POST** /auth/{approle_mount_path}/role/{role_name}/secret-id/destroy | 
[**AppRoleDestroySecretIdByAccessor**](AuthApi.md#approledestroysecretidbyaccessor) | **POST** /auth/{approle_mount_path}/role/{role_name}/secret-id-accessor/destroy | 
[**AppRoleListRoles**](AuthApi.md#approlelistroles) | **GET** /auth/{approle_mount_path}/role/ | 
[**AppRoleListSecretIds**](AuthApi.md#approlelistsecretids) | **GET** /auth/{approle_mount_path}/role/{role_name}/secret-id/ | 
[**AppRoleLogin**](AuthApi.md#approlelogin) | **POST** /auth/{approle_mount_path}/login | 
[**AppRoleLookUpSecretId**](AuthApi.md#approlelookupsecretid) | **POST** /auth/{approle_mount_path}/role/{role_name}/secret-id/lookup | 
[**AppRoleLookUpSecretIdByAccessor**](AuthApi.md#approlelookupsecretidbyaccessor) | **POST** /auth/{approle_mount_path}/role/{role_name}/secret-id-accessor/lookup | 
[**AppRoleReadBindSecretId**](AuthApi.md#approlereadbindsecretid) | **GET** /auth/{approle_mount_path}/role/{role_name}/bind-secret-id | 
[**AppRoleReadBoundCidrList**](AuthApi.md#approlereadboundcidrlist) | **GET** /auth/{approle_mount_path}/role/{role_name}/bound-cidr-list | 
[**AppRoleReadLocalSecretIds**](AuthApi.md#approlereadlocalsecretids) | **GET** /auth/{approle_mount_path}/role/{role_name}/local-secret-ids | 
[**AppRoleReadPeriod**](AuthApi.md#approlereadperiod) | **GET** /auth/{approle_mount_path}/role/{role_name}/period | 
[**AppRoleReadPolicies**](AuthApi.md#approlereadpolicies) | **GET** /auth/{approle_mount_path}/role/{role_name}/policies | 
[**AppRoleReadRole**](AuthApi.md#approlereadrole) | **GET** /auth/{approle_mount_path}/role/{role_name} | 
[**AppRoleReadRoleId**](AuthApi.md#approlereadroleid) | **GET** /auth/{approle_mount_path}/role/{role_name}/role-id | 
[**AppRoleReadSecretIdBoundCidrs**](AuthApi.md#approlereadsecretidboundcidrs) | **GET** /auth/{approle_mount_path}/role/{role_name}/secret-id-bound-cidrs | 
[**AppRoleReadSecretIdNumUses**](AuthApi.md#approlereadsecretidnumuses) | **GET** /auth/{approle_mount_path}/role/{role_name}/secret-id-num-uses | 
[**AppRoleReadSecretIdTtl**](AuthApi.md#approlereadsecretidttl) | **GET** /auth/{approle_mount_path}/role/{role_name}/secret-id-ttl | 
[**AppRoleReadTokenBoundCidrs**](AuthApi.md#approlereadtokenboundcidrs) | **GET** /auth/{approle_mount_path}/role/{role_name}/token-bound-cidrs | 
[**AppRoleReadTokenMaxTtl**](AuthApi.md#approlereadtokenmaxttl) | **GET** /auth/{approle_mount_path}/role/{role_name}/token-max-ttl | 
[**AppRoleReadTokenNumUses**](AuthApi.md#approlereadtokennumuses) | **GET** /auth/{approle_mount_path}/role/{role_name}/token-num-uses | 
[**AppRoleReadTokenTtl**](AuthApi.md#approlereadtokenttl) | **GET** /auth/{approle_mount_path}/role/{role_name}/token-ttl | 
[**AppRoleTidySecretId**](AuthApi.md#approletidysecretid) | **POST** /auth/{approle_mount_path}/tidy/secret-id | 
[**AppRoleWriteBindSecretId**](AuthApi.md#approlewritebindsecretid) | **POST** /auth/{approle_mount_path}/role/{role_name}/bind-secret-id | 
[**AppRoleWriteBoundCidrList**](AuthApi.md#approlewriteboundcidrlist) | **POST** /auth/{approle_mount_path}/role/{role_name}/bound-cidr-list | 
[**AppRoleWriteCustomSecretId**](AuthApi.md#approlewritecustomsecretid) | **POST** /auth/{approle_mount_path}/role/{role_name}/custom-secret-id | 
[**AppRoleWritePeriod**](AuthApi.md#approlewriteperiod) | **POST** /auth/{approle_mount_path}/role/{role_name}/period | 
[**AppRoleWritePolicies**](AuthApi.md#approlewritepolicies) | **POST** /auth/{approle_mount_path}/role/{role_name}/policies | 
[**AppRoleWriteRole**](AuthApi.md#approlewriterole) | **POST** /auth/{approle_mount_path}/role/{role_name} | 
[**AppRoleWriteRoleId**](AuthApi.md#approlewriteroleid) | **POST** /auth/{approle_mount_path}/role/{role_name}/role-id | 
[**AppRoleWriteSecretId**](AuthApi.md#approlewritesecretid) | **POST** /auth/{approle_mount_path}/role/{role_name}/secret-id | 
[**AppRoleWriteSecretIdBoundCidrs**](AuthApi.md#approlewritesecretidboundcidrs) | **POST** /auth/{approle_mount_path}/role/{role_name}/secret-id-bound-cidrs | 
[**AppRoleWriteSecretIdNumUses**](AuthApi.md#approlewritesecretidnumuses) | **POST** /auth/{approle_mount_path}/role/{role_name}/secret-id-num-uses | 
[**AppRoleWriteSecretIdTtl**](AuthApi.md#approlewritesecretidttl) | **POST** /auth/{approle_mount_path}/role/{role_name}/secret-id-ttl | 
[**AppRoleWriteTokenBoundCidrs**](AuthApi.md#approlewritetokenboundcidrs) | **POST** /auth/{approle_mount_path}/role/{role_name}/token-bound-cidrs | 
[**AppRoleWriteTokenMaxTtl**](AuthApi.md#approlewritetokenmaxttl) | **POST** /auth/{approle_mount_path}/role/{role_name}/token-max-ttl | 
[**AppRoleWriteTokenNumUses**](AuthApi.md#approlewritetokennumuses) | **POST** /auth/{approle_mount_path}/role/{role_name}/token-num-uses | 
[**AppRoleWriteTokenTtl**](AuthApi.md#approlewritetokenttl) | **POST** /auth/{approle_mount_path}/role/{role_name}/token-ttl | 
[**AwsConfigureCertificate**](AuthApi.md#awsconfigurecertificate) | **POST** /auth/{aws_mount_path}/config/certificate/{cert_name} | 
[**AwsConfigureClient**](AuthApi.md#awsconfigureclient) | **POST** /auth/{aws_mount_path}/config/client | 
[**AwsConfigureIdentityAccessListTidyOperation**](AuthApi.md#awsconfigureidentityaccesslisttidyoperation) | **POST** /auth/{aws_mount_path}/config/tidy/identity-accesslist | 
[**AwsConfigureIdentityIntegration**](AuthApi.md#awsconfigureidentityintegration) | **POST** /auth/{aws_mount_path}/config/identity | 
[**AwsConfigureIdentityWhitelistTidyOperation**](AuthApi.md#awsconfigureidentitywhitelisttidyoperation) | **POST** /auth/{aws_mount_path}/config/tidy/identity-whitelist | 
[**AwsConfigureRoleTagBlacklistTidyOperation**](AuthApi.md#awsconfigureroletagblacklisttidyoperation) | **POST** /auth/{aws_mount_path}/config/tidy/roletag-blacklist | 
[**AwsConfigureRoleTagDenyListTidyOperation**](AuthApi.md#awsconfigureroletagdenylisttidyoperation) | **POST** /auth/{aws_mount_path}/config/tidy/roletag-denylist | 
[**AwsDeleteAuthRole**](AuthApi.md#awsdeleteauthrole) | **DELETE** /auth/{aws_mount_path}/role/{role} | 
[**AwsDeleteCertificateConfiguration**](AuthApi.md#awsdeletecertificateconfiguration) | **DELETE** /auth/{aws_mount_path}/config/certificate/{cert_name} | 
[**AwsDeleteClientConfiguration**](AuthApi.md#awsdeleteclientconfiguration) | **DELETE** /auth/{aws_mount_path}/config/client | 
[**AwsDeleteIdentityAccessList**](AuthApi.md#awsdeleteidentityaccesslist) | **DELETE** /auth/{aws_mount_path}/identity-accesslist/{instance_id} | 
[**AwsDeleteIdentityAccessListTidySettings**](AuthApi.md#awsdeleteidentityaccesslisttidysettings) | **DELETE** /auth/{aws_mount_path}/config/tidy/identity-accesslist | 
[**AwsDeleteIdentityWhitelist**](AuthApi.md#awsdeleteidentitywhitelist) | **DELETE** /auth/{aws_mount_path}/identity-whitelist/{instance_id} | 
[**AwsDeleteIdentityWhitelistTidySettings**](AuthApi.md#awsdeleteidentitywhitelisttidysettings) | **DELETE** /auth/{aws_mount_path}/config/tidy/identity-whitelist | 
[**AwsDeleteRoleTagBlacklist**](AuthApi.md#awsdeleteroletagblacklist) | **DELETE** /auth/{aws_mount_path}/roletag-blacklist/{role_tag} | 
[**AwsDeleteRoleTagBlacklistTidySettings**](AuthApi.md#awsdeleteroletagblacklisttidysettings) | **DELETE** /auth/{aws_mount_path}/config/tidy/roletag-blacklist | 
[**AwsDeleteRoleTagDenyList**](AuthApi.md#awsdeleteroletagdenylist) | **DELETE** /auth/{aws_mount_path}/roletag-denylist/{role_tag} | 
[**AwsDeleteRoleTagDenyListTidySettings**](AuthApi.md#awsdeleteroletagdenylisttidysettings) | **DELETE** /auth/{aws_mount_path}/config/tidy/roletag-denylist | 
[**AwsDeleteStsRole**](AuthApi.md#awsdeletestsrole) | **DELETE** /auth/{aws_mount_path}/config/sts/{account_id} | 
[**AwsListAuthRoles**](AuthApi.md#awslistauthroles) | **GET** /auth/{aws_mount_path}/role/ | 
[**AwsListCertificateConfigurations**](AuthApi.md#awslistcertificateconfigurations) | **GET** /auth/{aws_mount_path}/config/certificates/ | 
[**AwsListIdentityAccessList**](AuthApi.md#awslistidentityaccesslist) | **GET** /auth/{aws_mount_path}/identity-accesslist/ | 
[**AwsListIdentityWhitelist**](AuthApi.md#awslistidentitywhitelist) | **GET** /auth/{aws_mount_path}/identity-whitelist/ | 
[**AwsListRoleTagBlacklists**](AuthApi.md#awslistroletagblacklists) | **GET** /auth/{aws_mount_path}/roletag-blacklist/ | 
[**AwsListRoleTagDenyLists**](AuthApi.md#awslistroletagdenylists) | **GET** /auth/{aws_mount_path}/roletag-denylist/ | 
[**AwsListStsRoleRelationships**](AuthApi.md#awsliststsrolerelationships) | **GET** /auth/{aws_mount_path}/config/sts/ | 
[**AwsLogin**](AuthApi.md#awslogin) | **POST** /auth/{aws_mount_path}/login | 
[**AwsReadAuthRole**](AuthApi.md#awsreadauthrole) | **GET** /auth/{aws_mount_path}/role/{role} | 
[**AwsReadCertificateConfiguration**](AuthApi.md#awsreadcertificateconfiguration) | **GET** /auth/{aws_mount_path}/config/certificate/{cert_name} | 
[**AwsReadClientConfiguration**](AuthApi.md#awsreadclientconfiguration) | **GET** /auth/{aws_mount_path}/config/client | 
[**AwsReadIdentityAccessList**](AuthApi.md#awsreadidentityaccesslist) | **GET** /auth/{aws_mount_path}/identity-accesslist/{instance_id} | 
[**AwsReadIdentityAccessListTidySettings**](AuthApi.md#awsreadidentityaccesslisttidysettings) | **GET** /auth/{aws_mount_path}/config/tidy/identity-accesslist | 
[**AwsReadIdentityIntegrationConfiguration**](AuthApi.md#awsreadidentityintegrationconfiguration) | **GET** /auth/{aws_mount_path}/config/identity | 
[**AwsReadIdentityWhitelist**](AuthApi.md#awsreadidentitywhitelist) | **GET** /auth/{aws_mount_path}/identity-whitelist/{instance_id} | 
[**AwsReadIdentityWhitelistTidySettings**](AuthApi.md#awsreadidentitywhitelisttidysettings) | **GET** /auth/{aws_mount_path}/config/tidy/identity-whitelist | 
[**AwsReadRoleTagBlacklist**](AuthApi.md#awsreadroletagblacklist) | **GET** /auth/{aws_mount_path}/roletag-blacklist/{role_tag} | 
[**AwsReadRoleTagBlacklistTidySettings**](AuthApi.md#awsreadroletagblacklisttidysettings) | **GET** /auth/{aws_mount_path}/config/tidy/roletag-blacklist | 
[**AwsReadRoleTagDenyList**](AuthApi.md#awsreadroletagdenylist) | **GET** /auth/{aws_mount_path}/roletag-denylist/{role_tag} | 
[**AwsReadRoleTagDenyListTidySettings**](AuthApi.md#awsreadroletagdenylisttidysettings) | **GET** /auth/{aws_mount_path}/config/tidy/roletag-denylist | 
[**AwsReadStsRole**](AuthApi.md#awsreadstsrole) | **GET** /auth/{aws_mount_path}/config/sts/{account_id} | 
[**AwsRotateRootCredentials**](AuthApi.md#awsrotaterootcredentials) | **POST** /auth/{aws_mount_path}/config/rotate-root | 
[**AwsTidyIdentityAccessList**](AuthApi.md#awstidyidentityaccesslist) | **POST** /auth/{aws_mount_path}/tidy/identity-accesslist | 
[**AwsTidyIdentityWhitelist**](AuthApi.md#awstidyidentitywhitelist) | **POST** /auth/{aws_mount_path}/tidy/identity-whitelist | 
[**AwsTidyRoleTagBlacklist**](AuthApi.md#awstidyroletagblacklist) | **POST** /auth/{aws_mount_path}/tidy/roletag-blacklist | 
[**AwsTidyRoleTagDenyList**](AuthApi.md#awstidyroletagdenylist) | **POST** /auth/{aws_mount_path}/tidy/roletag-denylist | 
[**AwsWriteAuthRole**](AuthApi.md#awswriteauthrole) | **POST** /auth/{aws_mount_path}/role/{role} | 
[**AwsWriteRoleTag**](AuthApi.md#awswriteroletag) | **POST** /auth/{aws_mount_path}/role/{role}/tag | 
[**AwsWriteRoleTagBlacklist**](AuthApi.md#awswriteroletagblacklist) | **POST** /auth/{aws_mount_path}/roletag-blacklist/{role_tag} | 
[**AwsWriteRoleTagDenyList**](AuthApi.md#awswriteroletagdenylist) | **POST** /auth/{aws_mount_path}/roletag-denylist/{role_tag} | 
[**AwsWriteStsRole**](AuthApi.md#awswritestsrole) | **POST** /auth/{aws_mount_path}/config/sts/{account_id} | 
[**AzureConfigureAuth**](AuthApi.md#azureconfigureauth) | **POST** /auth/{azure_mount_path}/config | 
[**AzureDeleteAuthConfiguration**](AuthApi.md#azuredeleteauthconfiguration) | **DELETE** /auth/{azure_mount_path}/config | 
[**AzureDeleteAuthRole**](AuthApi.md#azuredeleteauthrole) | **DELETE** /auth/{azure_mount_path}/role/{name} | 
[**AzureListAuthRoles**](AuthApi.md#azurelistauthroles) | **GET** /auth/{azure_mount_path}/role/ | 
[**AzureLogin**](AuthApi.md#azurelogin) | **POST** /auth/{azure_mount_path}/login | 
[**AzureReadAuthConfiguration**](AuthApi.md#azurereadauthconfiguration) | **GET** /auth/{azure_mount_path}/config | 
[**AzureReadAuthRole**](AuthApi.md#azurereadauthrole) | **GET** /auth/{azure_mount_path}/role/{name} | 
[**AzureRotateRootCredentials**](AuthApi.md#azurerotaterootcredentials) | **POST** /auth/{azure_mount_path}/rotate-root | 
[**AzureWriteAuthRole**](AuthApi.md#azurewriteauthrole) | **POST** /auth/{azure_mount_path}/role/{name} | 
[**CentrifyConfigure**](AuthApi.md#centrifyconfigure) | **POST** /auth/{centrify_mount_path}/config | 
[**CentrifyLogin**](AuthApi.md#centrifylogin) | **POST** /auth/{centrify_mount_path}/login | Log in with a username and password.
[**CentrifyReadConfiguration**](AuthApi.md#centrifyreadconfiguration) | **GET** /auth/{centrify_mount_path}/config | 
[**CertConfigure**](AuthApi.md#certconfigure) | **POST** /auth/{cert_mount_path}/config | 
[**CertDeleteCertificate**](AuthApi.md#certdeletecertificate) | **DELETE** /auth/{cert_mount_path}/certs/{name} | Manage trusted certificates used for authentication.
[**CertDeleteCrl**](AuthApi.md#certdeletecrl) | **DELETE** /auth/{cert_mount_path}/crls/{name} | Manage Certificate Revocation Lists checked during authentication.
[**CertListCertificates**](AuthApi.md#certlistcertificates) | **GET** /auth/{cert_mount_path}/certs/ | Manage trusted certificates used for authentication.
[**CertListCrls**](AuthApi.md#certlistcrls) | **GET** /auth/{cert_mount_path}/crls/ | 
[**CertLogin**](AuthApi.md#certlogin) | **POST** /auth/{cert_mount_path}/login | 
[**CertReadCertificate**](AuthApi.md#certreadcertificate) | **GET** /auth/{cert_mount_path}/certs/{name} | Manage trusted certificates used for authentication.
[**CertReadConfiguration**](AuthApi.md#certreadconfiguration) | **GET** /auth/{cert_mount_path}/config | 
[**CertReadCrl**](AuthApi.md#certreadcrl) | **GET** /auth/{cert_mount_path}/crls/{name} | Manage Certificate Revocation Lists checked during authentication.
[**CertWriteCertificate**](AuthApi.md#certwritecertificate) | **POST** /auth/{cert_mount_path}/certs/{name} | Manage trusted certificates used for authentication.
[**CertWriteCrl**](AuthApi.md#certwritecrl) | **POST** /auth/{cert_mount_path}/crls/{name} | Manage Certificate Revocation Lists checked during authentication.
[**CloudFoundryConfigure**](AuthApi.md#cloudfoundryconfigure) | **POST** /auth/{cf_mount_path}/config | 
[**CloudFoundryDeleteConfiguration**](AuthApi.md#cloudfoundrydeleteconfiguration) | **DELETE** /auth/{cf_mount_path}/config | 
[**CloudFoundryDeleteRole**](AuthApi.md#cloudfoundrydeleterole) | **DELETE** /auth/{cf_mount_path}/roles/{role} | 
[**CloudFoundryListRoles**](AuthApi.md#cloudfoundrylistroles) | **GET** /auth/{cf_mount_path}/roles/ | 
[**CloudFoundryLogin**](AuthApi.md#cloudfoundrylogin) | **POST** /auth/{cf_mount_path}/login | 
[**CloudFoundryReadConfiguration**](AuthApi.md#cloudfoundryreadconfiguration) | **GET** /auth/{cf_mount_path}/config | 
[**CloudFoundryReadRole**](AuthApi.md#cloudfoundryreadrole) | **GET** /auth/{cf_mount_path}/roles/{role} | 
[**CloudFoundryWriteRole**](AuthApi.md#cloudfoundrywriterole) | **POST** /auth/{cf_mount_path}/roles/{role} | 
[**GithubConfigure**](AuthApi.md#githubconfigure) | **POST** /auth/{github_mount_path}/config | 
[**GithubDeleteTeamMapping**](AuthApi.md#githubdeleteteammapping) | **DELETE** /auth/{github_mount_path}/map/teams/{key} | Read/write/delete a single teams mapping
[**GithubDeleteUserMapping**](AuthApi.md#githubdeleteusermapping) | **DELETE** /auth/{github_mount_path}/map/users/{key} | Read/write/delete a single users mapping
[**GithubListTeams**](AuthApi.md#githublistteams) | **GET** /auth/{github_mount_path}/map/teams/ | Read mappings for teams
[**GithubListUsers**](AuthApi.md#githublistusers) | **GET** /auth/{github_mount_path}/map/users/ | Read mappings for users
[**GithubLogin**](AuthApi.md#githublogin) | **POST** /auth/{github_mount_path}/login | 
[**GithubReadConfiguration**](AuthApi.md#githubreadconfiguration) | **GET** /auth/{github_mount_path}/config | 
[**GithubReadTeamMapping**](AuthApi.md#githubreadteammapping) | **GET** /auth/{github_mount_path}/map/teams/{key} | Read/write/delete a single teams mapping
[**GithubReadUserMapping**](AuthApi.md#githubreadusermapping) | **GET** /auth/{github_mount_path}/map/users/{key} | Read/write/delete a single users mapping
[**GithubWriteTeamMapping**](AuthApi.md#githubwriteteammapping) | **POST** /auth/{github_mount_path}/map/teams/{key} | Read/write/delete a single teams mapping
[**GithubWriteUserMapping**](AuthApi.md#githubwriteusermapping) | **POST** /auth/{github_mount_path}/map/users/{key} | Read/write/delete a single users mapping
[**GoogleCloudConfigureAuth**](AuthApi.md#googlecloudconfigureauth) | **POST** /auth/{gcp_mount_path}/config | 
[**GoogleCloudDeleteRole**](AuthApi.md#googleclouddeleterole) | **DELETE** /auth/{gcp_mount_path}/role/{name} | Create a GCP role with associated policies and required attributes.
[**GoogleCloudEditLabelsForRole**](AuthApi.md#googlecloudeditlabelsforrole) | **POST** /auth/{gcp_mount_path}/role/{name}/labels | Add or remove labels for an existing &#x27;gce&#x27; role
[**GoogleCloudEditServiceAccountsForRole**](AuthApi.md#googlecloudeditserviceaccountsforrole) | **POST** /auth/{gcp_mount_path}/role/{name}/service-accounts | Add or remove service accounts for an existing &#x60;iam&#x60; role
[**GoogleCloudListRoles**](AuthApi.md#googlecloudlistroles) | **GET** /auth/{gcp_mount_path}/role/ | Lists all the roles that are registered with Vault.
[**GoogleCloudLogin**](AuthApi.md#googlecloudlogin) | **POST** /auth/{gcp_mount_path}/login | 
[**GoogleCloudReadAuthConfiguration**](AuthApi.md#googlecloudreadauthconfiguration) | **GET** /auth/{gcp_mount_path}/config | 
[**GoogleCloudReadRole**](AuthApi.md#googlecloudreadrole) | **GET** /auth/{gcp_mount_path}/role/{name} | Create a GCP role with associated policies and required attributes.
[**GoogleCloudWriteRole**](AuthApi.md#googlecloudwriterole) | **POST** /auth/{gcp_mount_path}/role/{name} | Create a GCP role with associated policies and required attributes.
[**JwtConfigure**](AuthApi.md#jwtconfigure) | **POST** /auth/{jwt_mount_path}/config | Configure the JWT authentication backend.
[**JwtDeleteRole**](AuthApi.md#jwtdeleterole) | **DELETE** /auth/{jwt_mount_path}/role/{name} | Delete an existing role.
[**JwtListRoles**](AuthApi.md#jwtlistroles) | **GET** /auth/{jwt_mount_path}/role/ | Lists all the roles registered with the backend.
[**JwtLogin**](AuthApi.md#jwtlogin) | **POST** /auth/{jwt_mount_path}/login | Authenticates to Vault using a JWT (or OIDC) token.
[**JwtOidcCallback**](AuthApi.md#jwtoidccallback) | **GET** /auth/{jwt_mount_path}/oidc/callback | Callback endpoint to complete an OIDC login.
[**JwtOidcCallbackFormPost**](AuthApi.md#jwtoidccallbackformpost) | **POST** /auth/{jwt_mount_path}/oidc/callback | Callback endpoint to handle form_posts.
[**JwtOidcRequestAuthorizationUrl**](AuthApi.md#jwtoidcrequestauthorizationurl) | **POST** /auth/{jwt_mount_path}/oidc/auth_url | Request an authorization URL to start an OIDC login flow.
[**JwtReadConfiguration**](AuthApi.md#jwtreadconfiguration) | **GET** /auth/{jwt_mount_path}/config | Read the current JWT authentication backend configuration.
[**JwtReadRole**](AuthApi.md#jwtreadrole) | **GET** /auth/{jwt_mount_path}/role/{name} | Read an existing role.
[**JwtWriteRole**](AuthApi.md#jwtwriterole) | **POST** /auth/{jwt_mount_path}/role/{name} | Register an role with the backend.
[**KerberosConfigure**](AuthApi.md#kerberosconfigure) | **POST** /auth/{kerberos_mount_path}/config | 
[**KerberosConfigureLdap**](AuthApi.md#kerberosconfigureldap) | **POST** /auth/{kerberos_mount_path}/config/ldap | 
[**KerberosDeleteGroup**](AuthApi.md#kerberosdeletegroup) | **DELETE** /auth/{kerberos_mount_path}/groups/{name} | 
[**KerberosListGroups**](AuthApi.md#kerberoslistgroups) | **GET** /auth/{kerberos_mount_path}/groups/ | 
[**KerberosLogin**](AuthApi.md#kerberoslogin) | **POST** /auth/{kerberos_mount_path}/login | 
[**KerberosReadConfiguration**](AuthApi.md#kerberosreadconfiguration) | **GET** /auth/{kerberos_mount_path}/config | 
[**KerberosReadGroup**](AuthApi.md#kerberosreadgroup) | **GET** /auth/{kerberos_mount_path}/groups/{name} | 
[**KerberosReadLdapConfiguration**](AuthApi.md#kerberosreadldapconfiguration) | **GET** /auth/{kerberos_mount_path}/config/ldap | 
[**KerberosWriteGroup**](AuthApi.md#kerberoswritegroup) | **POST** /auth/{kerberos_mount_path}/groups/{name} | 
[**KubernetesConfigureAuth**](AuthApi.md#kubernetesconfigureauth) | **POST** /auth/{kubernetes_mount_path}/config | 
[**KubernetesDeleteAuthRole**](AuthApi.md#kubernetesdeleteauthrole) | **DELETE** /auth/{kubernetes_mount_path}/role/{name} | Register an role with the backend.
[**KubernetesListAuthRoles**](AuthApi.md#kuberneteslistauthroles) | **GET** /auth/{kubernetes_mount_path}/role/ | Lists all the roles registered with the backend.
[**KubernetesLogin**](AuthApi.md#kuberneteslogin) | **POST** /auth/{kubernetes_mount_path}/login | Authenticates Kubernetes service accounts with Vault.
[**KubernetesReadAuthConfiguration**](AuthApi.md#kubernetesreadauthconfiguration) | **GET** /auth/{kubernetes_mount_path}/config | 
[**KubernetesReadAuthRole**](AuthApi.md#kubernetesreadauthrole) | **GET** /auth/{kubernetes_mount_path}/role/{name} | Register an role with the backend.
[**KubernetesWriteAuthRole**](AuthApi.md#kuberneteswriteauthrole) | **POST** /auth/{kubernetes_mount_path}/role/{name} | Register an role with the backend.
[**LdapConfigureAuth**](AuthApi.md#ldapconfigureauth) | **POST** /auth/{ldap_mount_path}/config | 
[**LdapDeleteGroup**](AuthApi.md#ldapdeletegroup) | **DELETE** /auth/{ldap_mount_path}/groups/{name} | Manage additional groups for users allowed to authenticate.
[**LdapDeleteUser**](AuthApi.md#ldapdeleteuser) | **DELETE** /auth/{ldap_mount_path}/users/{name} | Manage users allowed to authenticate.
[**LdapListGroups**](AuthApi.md#ldaplistgroups) | **GET** /auth/{ldap_mount_path}/groups/ | Manage additional groups for users allowed to authenticate.
[**LdapListUsers**](AuthApi.md#ldaplistusers) | **GET** /auth/{ldap_mount_path}/users/ | Manage users allowed to authenticate.
[**LdapLogin**](AuthApi.md#ldaplogin) | **POST** /auth/{ldap_mount_path}/login/{username} | Log in with a username and password.
[**LdapReadAuthConfiguration**](AuthApi.md#ldapreadauthconfiguration) | **GET** /auth/{ldap_mount_path}/config | 
[**LdapReadGroup**](AuthApi.md#ldapreadgroup) | **GET** /auth/{ldap_mount_path}/groups/{name} | Manage additional groups for users allowed to authenticate.
[**LdapReadUser**](AuthApi.md#ldapreaduser) | **GET** /auth/{ldap_mount_path}/users/{name} | Manage users allowed to authenticate.
[**LdapWriteGroup**](AuthApi.md#ldapwritegroup) | **POST** /auth/{ldap_mount_path}/groups/{name} | Manage additional groups for users allowed to authenticate.
[**LdapWriteUser**](AuthApi.md#ldapwriteuser) | **POST** /auth/{ldap_mount_path}/users/{name} | Manage users allowed to authenticate.
[**OciConfigure**](AuthApi.md#ociconfigure) | **POST** /auth/{oci_mount_path}/config | 
[**OciDeleteConfiguration**](AuthApi.md#ocideleteconfiguration) | **DELETE** /auth/{oci_mount_path}/config | 
[**OciDeleteRole**](AuthApi.md#ocideleterole) | **DELETE** /auth/{oci_mount_path}/role/{role} | Create a role and associate policies to it.
[**OciListRoles**](AuthApi.md#ocilistroles) | **GET** /auth/{oci_mount_path}/role/ | Lists all the roles that are registered with Vault.
[**OciLogin**](AuthApi.md#ocilogin) | **POST** /auth/{oci_mount_path}/login/{role} | Authenticates to Vault using OCI credentials
[**OciReadConfiguration**](AuthApi.md#ocireadconfiguration) | **GET** /auth/{oci_mount_path}/config | 
[**OciReadRole**](AuthApi.md#ocireadrole) | **GET** /auth/{oci_mount_path}/role/{role} | Create a role and associate policies to it.
[**OciWriteRole**](AuthApi.md#ociwriterole) | **POST** /auth/{oci_mount_path}/role/{role} | Create a role and associate policies to it.
[**OktaConfigure**](AuthApi.md#oktaconfigure) | **POST** /auth/{okta_mount_path}/config | 
[**OktaDeleteGroup**](AuthApi.md#oktadeletegroup) | **DELETE** /auth/{okta_mount_path}/groups/{name} | Manage users allowed to authenticate.
[**OktaDeleteUser**](AuthApi.md#oktadeleteuser) | **DELETE** /auth/{okta_mount_path}/users/{name} | Manage additional groups for users allowed to authenticate.
[**OktaListGroups**](AuthApi.md#oktalistgroups) | **GET** /auth/{okta_mount_path}/groups/ | Manage users allowed to authenticate.
[**OktaListUsers**](AuthApi.md#oktalistusers) | **GET** /auth/{okta_mount_path}/users/ | Manage additional groups for users allowed to authenticate.
[**OktaLogin**](AuthApi.md#oktalogin) | **POST** /auth/{okta_mount_path}/login/{username} | Log in with a username and password.
[**OktaReadConfiguration**](AuthApi.md#oktareadconfiguration) | **GET** /auth/{okta_mount_path}/config | 
[**OktaReadGroup**](AuthApi.md#oktareadgroup) | **GET** /auth/{okta_mount_path}/groups/{name} | Manage users allowed to authenticate.
[**OktaReadUser**](AuthApi.md#oktareaduser) | **GET** /auth/{okta_mount_path}/users/{name} | Manage additional groups for users allowed to authenticate.
[**OktaVerify**](AuthApi.md#oktaverify) | **GET** /auth/{okta_mount_path}/verify/{nonce} | 
[**OktaWriteGroup**](AuthApi.md#oktawritegroup) | **POST** /auth/{okta_mount_path}/groups/{name} | Manage users allowed to authenticate.
[**OktaWriteUser**](AuthApi.md#oktawriteuser) | **POST** /auth/{okta_mount_path}/users/{name} | Manage additional groups for users allowed to authenticate.
[**RadiusConfigure**](AuthApi.md#radiusconfigure) | **POST** /auth/{radius_mount_path}/config | 
[**RadiusDeleteUser**](AuthApi.md#radiusdeleteuser) | **DELETE** /auth/{radius_mount_path}/users/{name} | Manage users allowed to authenticate.
[**RadiusListUsers**](AuthApi.md#radiuslistusers) | **GET** /auth/{radius_mount_path}/users/ | Manage users allowed to authenticate.
[**RadiusLogin**](AuthApi.md#radiuslogin) | **POST** /auth/{radius_mount_path}/login | Log in with a username and password.
[**RadiusLoginWithUsername**](AuthApi.md#radiusloginwithusername) | **POST** /auth/{radius_mount_path}/login/{urlusername} | Log in with a username and password.
[**RadiusReadConfiguration**](AuthApi.md#radiusreadconfiguration) | **GET** /auth/{radius_mount_path}/config | 
[**RadiusReadUser**](AuthApi.md#radiusreaduser) | **GET** /auth/{radius_mount_path}/users/{name} | Manage users allowed to authenticate.
[**RadiusWriteUser**](AuthApi.md#radiuswriteuser) | **POST** /auth/{radius_mount_path}/users/{name} | Manage users allowed to authenticate.
[**TokenCreate**](AuthApi.md#tokencreate) | **POST** /auth/token/create | The token create path is used to create new tokens.
[**TokenCreateAgainstRole**](AuthApi.md#tokencreateagainstrole) | **POST** /auth/token/create/{role_name} | This token create path is used to create new tokens adhering to the given role.
[**TokenCreateOrphan**](AuthApi.md#tokencreateorphan) | **POST** /auth/token/create-orphan | The token create path is used to create new orphan tokens.
[**TokenDeleteRole**](AuthApi.md#tokendeleterole) | **DELETE** /auth/token/roles/{role_name} | 
[**TokenListAccessors**](AuthApi.md#tokenlistaccessors) | **GET** /auth/token/accessors/ | List token accessors, which can then be be used to iterate and discover their properties or revoke them. Because this can be used to cause a denial of service, this endpoint requires &#x27;sudo&#x27; capability in addition to &#x27;list&#x27;.
[**TokenListRoles**](AuthApi.md#tokenlistroles) | **GET** /auth/token/roles/ | This endpoint lists configured roles.
[**TokenLookUp**](AuthApi.md#tokenlookup) | **POST** /auth/token/lookup | 
[**TokenLookUpAccessor**](AuthApi.md#tokenlookupaccessor) | **POST** /auth/token/lookup-accessor | This endpoint will lookup a token associated with the given accessor and its properties. Response will not contain the token ID.
[**TokenLookUpSelf**](AuthApi.md#tokenlookupself) | **GET** /auth/token/lookup-self | 
[**TokenReadRole**](AuthApi.md#tokenreadrole) | **GET** /auth/token/roles/{role_name} | 
[**TokenRenew**](AuthApi.md#tokenrenew) | **POST** /auth/token/renew | This endpoint will renew the given token and prevent expiration.
[**TokenRenewAccessor**](AuthApi.md#tokenrenewaccessor) | **POST** /auth/token/renew-accessor | This endpoint will renew a token associated with the given accessor and its properties. Response will not contain the token ID.
[**TokenRenewSelf**](AuthApi.md#tokenrenewself) | **POST** /auth/token/renew-self | This endpoint will renew the token used to call it and prevent expiration.
[**TokenRevoke**](AuthApi.md#tokenrevoke) | **POST** /auth/token/revoke | This endpoint will delete the given token and all of its child tokens.
[**TokenRevokeAccessor**](AuthApi.md#tokenrevokeaccessor) | **POST** /auth/token/revoke-accessor | This endpoint will delete the token associated with the accessor and all of its child tokens.
[**TokenRevokeOrphan**](AuthApi.md#tokenrevokeorphan) | **POST** /auth/token/revoke-orphan | This endpoint will delete the token and orphan its child tokens.
[**TokenRevokeSelf**](AuthApi.md#tokenrevokeself) | **POST** /auth/token/revoke-self | This endpoint will delete the token used to call it and all of its child tokens.
[**TokenTidy**](AuthApi.md#tokentidy) | **POST** /auth/token/tidy | This endpoint performs cleanup tasks that can be run if certain error conditions have occurred.
[**TokenWriteRole**](AuthApi.md#tokenwriterole) | **POST** /auth/token/roles/{role_name} | 
[**UserpassDeleteUser**](AuthApi.md#userpassdeleteuser) | **DELETE** /auth/{userpass_mount_path}/users/{username} | Manage users allowed to authenticate.
[**UserpassListUsers**](AuthApi.md#userpasslistusers) | **GET** /auth/{userpass_mount_path}/users/ | Manage users allowed to authenticate.
[**UserpassLogin**](AuthApi.md#userpasslogin) | **POST** /auth/{userpass_mount_path}/login/{username} | Log in with a username and password.
[**UserpassReadUser**](AuthApi.md#userpassreaduser) | **GET** /auth/{userpass_mount_path}/users/{username} | Manage users allowed to authenticate.
[**UserpassResetPassword**](AuthApi.md#userpassresetpassword) | **POST** /auth/{userpass_mount_path}/users/{username}/password | Reset user&#x27;s password.
[**UserpassUpdatePolicies**](AuthApi.md#userpassupdatepolicies) | **POST** /auth/{userpass_mount_path}/users/{username}/policies | Update the policies associated with the username.
[**UserpassWriteUser**](AuthApi.md#userpasswriteuser) | **POST** /auth/{userpass_mount_path}/users/{username} | Manage users allowed to authenticate.

<a name="aliclouddeleteauthrole"></a>
# **AliCloudDeleteAuthRole**

> void AliCloudDeleteAuthRole (string role, string alicloudMountPath, TimeSpan? wrapTTL = null)

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
    public class AliCloudDeleteAuthRoleExample
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
            
            
            
            
            var alicloudMountPath = "\"alicloud\"";  // string | Path that the backend was mounted at (default to "alicloud")
            
            
            

            try
            {
                
                // Create a role and associate policies to it.
                

                apiInstance.AliCloudDeleteAuthRole(string role, string alicloudMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AliCloudDeleteAuthRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The name of the role as it should appear in Vault. | 
 **alicloudMountPath** | **string**| Path that the backend was mounted at | [default to &quot;alicloud&quot;]


### Return type

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

<a name="alicloudlistauthroles"></a>
# **AliCloudListAuthRoles**

> StandardListResponse AliCloudListAuthRoles (string alicloudMountPath, TimeSpan? wrapTTL = null)

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
    public class AliCloudListAuthRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var alicloudMountPath = "\"alicloud\"";  // string | Path that the backend was mounted at (default to "alicloud")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // Lists all the roles that are registered with Vault.
                

                StandardListResponse result = apiInstance.AliCloudListAuthRoles(string alicloudMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AliCloudListAuthRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **alicloudMountPath** | **string**| Path that the backend was mounted at | [default to &quot;alicloud&quot;]
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

<a name="alicloudlogin"></a>
# **AliCloudLogin**

> void AliCloudLogin (string alicloudMountPath, AliCloudLoginRequest aliCloudLoginRequest, TimeSpan? wrapTTL = null)

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
    public class AliCloudLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var alicloudMountPath = "\"alicloud\"";  // string | Path that the backend was mounted at (default to "alicloud")
            
            
            
            
            
            var aliCloudLoginRequest = new AliCloudLoginRequest(); // AliCloudLoginRequest | 
            
            

            try
            {
                
                // Authenticates an RAM entity with Vault.
                

                apiInstance.AliCloudLogin(string alicloudMountPath, AliCloudLoginRequest aliCloudLoginRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AliCloudLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **alicloudMountPath** | **string**| Path that the backend was mounted at | [default to &quot;alicloud&quot;]
 **aliCloudLoginRequest** | [**AliCloudLoginRequest**](AliCloudLoginRequest.md)|  | 


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

<a name="alicloudreadauthrole"></a>
# **AliCloudReadAuthRole**

> void AliCloudReadAuthRole (string role, string alicloudMountPath, TimeSpan? wrapTTL = null)

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
    public class AliCloudReadAuthRoleExample
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
            
            
            
            
            var alicloudMountPath = "\"alicloud\"";  // string | Path that the backend was mounted at (default to "alicloud")
            
            
            

            try
            {
                
                // Create a role and associate policies to it.
                

                apiInstance.AliCloudReadAuthRole(string role, string alicloudMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AliCloudReadAuthRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The name of the role as it should appear in Vault. | 
 **alicloudMountPath** | **string**| Path that the backend was mounted at | [default to &quot;alicloud&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="alicloudwriteauthrole"></a>
# **AliCloudWriteAuthRole**

> void AliCloudWriteAuthRole (string role, string alicloudMountPath, AliCloudWriteAuthRoleRequest aliCloudWriteAuthRoleRequest, TimeSpan? wrapTTL = null)

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
    public class AliCloudWriteAuthRoleExample
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
            
            
            
            
            var alicloudMountPath = "\"alicloud\"";  // string | Path that the backend was mounted at (default to "alicloud")
            
            
            
            
            
            var aliCloudWriteAuthRoleRequest = new AliCloudWriteAuthRoleRequest(); // AliCloudWriteAuthRoleRequest | 
            
            

            try
            {
                
                // Create a role and associate policies to it.
                

                apiInstance.AliCloudWriteAuthRole(string role, string alicloudMountPath, AliCloudWriteAuthRoleRequest aliCloudWriteAuthRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AliCloudWriteAuthRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The name of the role as it should appear in Vault. | 
 **alicloudMountPath** | **string**| Path that the backend was mounted at | [default to &quot;alicloud&quot;]
 **aliCloudWriteAuthRoleRequest** | [**AliCloudWriteAuthRoleRequest**](AliCloudWriteAuthRoleRequest.md)|  | 


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

<a name="approledeletebindsecretid"></a>
# **AppRoleDeleteBindSecretId**

> void AppRoleDeleteBindSecretId (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleDeleteBindSecretIdExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                apiInstance.AppRoleDeleteBindSecretId(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleDeleteBindSecretId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

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

<a name="approledeleteboundcidrlist"></a>
# **AppRoleDeleteBoundCidrList**

> void AppRoleDeleteBoundCidrList (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleDeleteBoundCidrListExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                apiInstance.AppRoleDeleteBoundCidrList(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleDeleteBoundCidrList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

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

<a name="approledeleteperiod"></a>
# **AppRoleDeletePeriod**

> void AppRoleDeletePeriod (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleDeletePeriodExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                apiInstance.AppRoleDeletePeriod(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleDeletePeriod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

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

<a name="approledeletepolicies"></a>
# **AppRoleDeletePolicies**

> void AppRoleDeletePolicies (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleDeletePoliciesExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                apiInstance.AppRoleDeletePolicies(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleDeletePolicies: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

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

<a name="approledeleterole"></a>
# **AppRoleDeleteRole**

> void AppRoleDeleteRole (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleDeleteRoleExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                apiInstance.AppRoleDeleteRole(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleDeleteRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

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

<a name="approledeletesecretidboundcidrs"></a>
# **AppRoleDeleteSecretIdBoundCidrs**

> void AppRoleDeleteSecretIdBoundCidrs (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleDeleteSecretIdBoundCidrsExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                apiInstance.AppRoleDeleteSecretIdBoundCidrs(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleDeleteSecretIdBoundCidrs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

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

<a name="approledeletesecretidnumuses"></a>
# **AppRoleDeleteSecretIdNumUses**

> void AppRoleDeleteSecretIdNumUses (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleDeleteSecretIdNumUsesExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                apiInstance.AppRoleDeleteSecretIdNumUses(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleDeleteSecretIdNumUses: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

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

<a name="approledeletesecretidttl"></a>
# **AppRoleDeleteSecretIdTtl**

> void AppRoleDeleteSecretIdTtl (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleDeleteSecretIdTtlExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                apiInstance.AppRoleDeleteSecretIdTtl(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleDeleteSecretIdTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

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

<a name="approledeletetokenboundcidrs"></a>
# **AppRoleDeleteTokenBoundCidrs**

> void AppRoleDeleteTokenBoundCidrs (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleDeleteTokenBoundCidrsExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                apiInstance.AppRoleDeleteTokenBoundCidrs(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleDeleteTokenBoundCidrs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

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

<a name="approledeletetokenmaxttl"></a>
# **AppRoleDeleteTokenMaxTtl**

> void AppRoleDeleteTokenMaxTtl (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleDeleteTokenMaxTtlExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                apiInstance.AppRoleDeleteTokenMaxTtl(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleDeleteTokenMaxTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

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

<a name="approledeletetokennumuses"></a>
# **AppRoleDeleteTokenNumUses**

> void AppRoleDeleteTokenNumUses (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleDeleteTokenNumUsesExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                apiInstance.AppRoleDeleteTokenNumUses(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleDeleteTokenNumUses: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

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

<a name="approledeletetokenttl"></a>
# **AppRoleDeleteTokenTtl**

> void AppRoleDeleteTokenTtl (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleDeleteTokenTtlExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                apiInstance.AppRoleDeleteTokenTtl(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleDeleteTokenTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

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

<a name="approledestroysecretid"></a>
# **AppRoleDestroySecretId**

> void AppRoleDestroySecretId (string roleName, string approleMountPath, AppRoleDestroySecretIdRequest appRoleDestroySecretIdRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleDestroySecretIdExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            
            
            
            var appRoleDestroySecretIdRequest = new AppRoleDestroySecretIdRequest(); // AppRoleDestroySecretIdRequest | 
            
            

            try
            {
                

                apiInstance.AppRoleDestroySecretId(string roleName, string approleMountPath, AppRoleDestroySecretIdRequest appRoleDestroySecretIdRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleDestroySecretId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]
 **appRoleDestroySecretIdRequest** | [**AppRoleDestroySecretIdRequest**](AppRoleDestroySecretIdRequest.md)|  | 


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

| **204** | No Content |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="approledestroysecretidbyaccessor"></a>
# **AppRoleDestroySecretIdByAccessor**

> void AppRoleDestroySecretIdByAccessor (string roleName, string approleMountPath, AppRoleDestroySecretIdByAccessorRequest appRoleDestroySecretIdByAccessorRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleDestroySecretIdByAccessorExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            
            
            
            var appRoleDestroySecretIdByAccessorRequest = new AppRoleDestroySecretIdByAccessorRequest(); // AppRoleDestroySecretIdByAccessorRequest | 
            
            

            try
            {
                

                apiInstance.AppRoleDestroySecretIdByAccessor(string roleName, string approleMountPath, AppRoleDestroySecretIdByAccessorRequest appRoleDestroySecretIdByAccessorRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleDestroySecretIdByAccessor: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]
 **appRoleDestroySecretIdByAccessorRequest** | [**AppRoleDestroySecretIdByAccessorRequest**](AppRoleDestroySecretIdByAccessorRequest.md)|  | 


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

| **204** | No Content |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="approlelistroles"></a>
# **AppRoleListRoles**

> StandardListResponse AppRoleListRoles (string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                StandardListResponse result = apiInstance.AppRoleListRoles(string approleMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleListRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]
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

<a name="approlelistsecretids"></a>
# **AppRoleListSecretIds**

> StandardListResponse AppRoleListSecretIds (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleListSecretIdsExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                StandardListResponse result = apiInstance.AppRoleListSecretIds(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleListSecretIds: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]
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

<a name="approlelogin"></a>
# **AppRoleLogin**

> void AppRoleLogin (string approleMountPath, AppRoleLoginRequest appRoleLoginRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            
            
            
            var appRoleLoginRequest = new AppRoleLoginRequest(); // AppRoleLoginRequest | 
            
            

            try
            {
                

                apiInstance.AppRoleLogin(string approleMountPath, AppRoleLoginRequest appRoleLoginRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]
 **appRoleLoginRequest** | [**AppRoleLoginRequest**](AppRoleLoginRequest.md)|  | 


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

<a name="approlelookupsecretid"></a>
# **AppRoleLookUpSecretId**

> AppRoleLookUpSecretIdResponse AppRoleLookUpSecretId (string roleName, string approleMountPath, AppRoleLookUpSecretIdRequest appRoleLookUpSecretIdRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleLookUpSecretIdExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            
            
            
            var appRoleLookUpSecretIdRequest = new AppRoleLookUpSecretIdRequest(); // AppRoleLookUpSecretIdRequest | 
            
            

            try
            {
                

                AppRoleLookUpSecretIdResponse result = apiInstance.AppRoleLookUpSecretId(string roleName, string approleMountPath, AppRoleLookUpSecretIdRequest appRoleLookUpSecretIdRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleLookUpSecretId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]
 **appRoleLookUpSecretIdRequest** | [**AppRoleLookUpSecretIdRequest**](AppRoleLookUpSecretIdRequest.md)|  | 


### Return type

[**AppRoleLookUpSecretIdResponse**](AppRoleLookUpSecretIdResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="approlelookupsecretidbyaccessor"></a>
# **AppRoleLookUpSecretIdByAccessor**

> AppRoleLookUpSecretIdByAccessorResponse AppRoleLookUpSecretIdByAccessor (string roleName, string approleMountPath, AppRoleLookUpSecretIdByAccessorRequest appRoleLookUpSecretIdByAccessorRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleLookUpSecretIdByAccessorExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            
            
            
            var appRoleLookUpSecretIdByAccessorRequest = new AppRoleLookUpSecretIdByAccessorRequest(); // AppRoleLookUpSecretIdByAccessorRequest | 
            
            

            try
            {
                

                AppRoleLookUpSecretIdByAccessorResponse result = apiInstance.AppRoleLookUpSecretIdByAccessor(string roleName, string approleMountPath, AppRoleLookUpSecretIdByAccessorRequest appRoleLookUpSecretIdByAccessorRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleLookUpSecretIdByAccessor: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]
 **appRoleLookUpSecretIdByAccessorRequest** | [**AppRoleLookUpSecretIdByAccessorRequest**](AppRoleLookUpSecretIdByAccessorRequest.md)|  | 


### Return type

[**AppRoleLookUpSecretIdByAccessorResponse**](AppRoleLookUpSecretIdByAccessorResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="approlereadbindsecretid"></a>
# **AppRoleReadBindSecretId**

> AppRoleReadBindSecretIdResponse AppRoleReadBindSecretId (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleReadBindSecretIdExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                AppRoleReadBindSecretIdResponse result = apiInstance.AppRoleReadBindSecretId(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleReadBindSecretId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

[**AppRoleReadBindSecretIdResponse**](AppRoleReadBindSecretIdResponse.md)

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

<a name="approlereadboundcidrlist"></a>
# **AppRoleReadBoundCidrList**

> AppRoleReadBoundCidrListResponse AppRoleReadBoundCidrList (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleReadBoundCidrListExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                AppRoleReadBoundCidrListResponse result = apiInstance.AppRoleReadBoundCidrList(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleReadBoundCidrList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

[**AppRoleReadBoundCidrListResponse**](AppRoleReadBoundCidrListResponse.md)

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

<a name="approlereadlocalsecretids"></a>
# **AppRoleReadLocalSecretIds**

> AppRoleReadLocalSecretIdsResponse AppRoleReadLocalSecretIds (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleReadLocalSecretIdsExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                AppRoleReadLocalSecretIdsResponse result = apiInstance.AppRoleReadLocalSecretIds(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleReadLocalSecretIds: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

[**AppRoleReadLocalSecretIdsResponse**](AppRoleReadLocalSecretIdsResponse.md)

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

<a name="approlereadperiod"></a>
# **AppRoleReadPeriod**

> AppRoleReadPeriodResponse AppRoleReadPeriod (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleReadPeriodExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                AppRoleReadPeriodResponse result = apiInstance.AppRoleReadPeriod(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleReadPeriod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

[**AppRoleReadPeriodResponse**](AppRoleReadPeriodResponse.md)

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

<a name="approlereadpolicies"></a>
# **AppRoleReadPolicies**

> AppRoleReadPoliciesResponse AppRoleReadPolicies (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleReadPoliciesExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                AppRoleReadPoliciesResponse result = apiInstance.AppRoleReadPolicies(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleReadPolicies: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

[**AppRoleReadPoliciesResponse**](AppRoleReadPoliciesResponse.md)

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

<a name="approlereadrole"></a>
# **AppRoleReadRole**

> AppRoleReadRoleResponse AppRoleReadRole (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleReadRoleExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                AppRoleReadRoleResponse result = apiInstance.AppRoleReadRole(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleReadRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

[**AppRoleReadRoleResponse**](AppRoleReadRoleResponse.md)

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

<a name="approlereadroleid"></a>
# **AppRoleReadRoleId**

> AppRoleReadRoleIdResponse AppRoleReadRoleId (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleReadRoleIdExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                AppRoleReadRoleIdResponse result = apiInstance.AppRoleReadRoleId(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleReadRoleId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

[**AppRoleReadRoleIdResponse**](AppRoleReadRoleIdResponse.md)

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

<a name="approlereadsecretidboundcidrs"></a>
# **AppRoleReadSecretIdBoundCidrs**

> AppRoleReadSecretIdBoundCidrsResponse AppRoleReadSecretIdBoundCidrs (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleReadSecretIdBoundCidrsExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                AppRoleReadSecretIdBoundCidrsResponse result = apiInstance.AppRoleReadSecretIdBoundCidrs(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleReadSecretIdBoundCidrs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

[**AppRoleReadSecretIdBoundCidrsResponse**](AppRoleReadSecretIdBoundCidrsResponse.md)

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

<a name="approlereadsecretidnumuses"></a>
# **AppRoleReadSecretIdNumUses**

> AppRoleReadSecretIdNumUsesResponse AppRoleReadSecretIdNumUses (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleReadSecretIdNumUsesExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                AppRoleReadSecretIdNumUsesResponse result = apiInstance.AppRoleReadSecretIdNumUses(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleReadSecretIdNumUses: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

[**AppRoleReadSecretIdNumUsesResponse**](AppRoleReadSecretIdNumUsesResponse.md)

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

<a name="approlereadsecretidttl"></a>
# **AppRoleReadSecretIdTtl**

> AppRoleReadSecretIdTtlResponse AppRoleReadSecretIdTtl (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleReadSecretIdTtlExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                AppRoleReadSecretIdTtlResponse result = apiInstance.AppRoleReadSecretIdTtl(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleReadSecretIdTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

[**AppRoleReadSecretIdTtlResponse**](AppRoleReadSecretIdTtlResponse.md)

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

<a name="approlereadtokenboundcidrs"></a>
# **AppRoleReadTokenBoundCidrs**

> AppRoleReadTokenBoundCidrsResponse AppRoleReadTokenBoundCidrs (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleReadTokenBoundCidrsExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                AppRoleReadTokenBoundCidrsResponse result = apiInstance.AppRoleReadTokenBoundCidrs(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleReadTokenBoundCidrs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

[**AppRoleReadTokenBoundCidrsResponse**](AppRoleReadTokenBoundCidrsResponse.md)

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

<a name="approlereadtokenmaxttl"></a>
# **AppRoleReadTokenMaxTtl**

> AppRoleReadTokenMaxTtlResponse AppRoleReadTokenMaxTtl (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleReadTokenMaxTtlExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                AppRoleReadTokenMaxTtlResponse result = apiInstance.AppRoleReadTokenMaxTtl(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleReadTokenMaxTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

[**AppRoleReadTokenMaxTtlResponse**](AppRoleReadTokenMaxTtlResponse.md)

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

<a name="approlereadtokennumuses"></a>
# **AppRoleReadTokenNumUses**

> AppRoleReadTokenNumUsesResponse AppRoleReadTokenNumUses (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleReadTokenNumUsesExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                AppRoleReadTokenNumUsesResponse result = apiInstance.AppRoleReadTokenNumUses(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleReadTokenNumUses: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

[**AppRoleReadTokenNumUsesResponse**](AppRoleReadTokenNumUsesResponse.md)

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

<a name="approlereadtokenttl"></a>
# **AppRoleReadTokenTtl**

> AppRoleReadTokenTtlResponse AppRoleReadTokenTtl (string roleName, string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleReadTokenTtlExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                AppRoleReadTokenTtlResponse result = apiInstance.AppRoleReadTokenTtl(string roleName, string approleMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleReadTokenTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

[**AppRoleReadTokenTtlResponse**](AppRoleReadTokenTtlResponse.md)

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

<a name="approletidysecretid"></a>
# **AppRoleTidySecretId**

> void AppRoleTidySecretId (string approleMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleTidySecretIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            

            try
            {
                

                apiInstance.AppRoleTidySecretId(string approleMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleTidySecretId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **202** | Accepted |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="approlewritebindsecretid"></a>
# **AppRoleWriteBindSecretId**

> void AppRoleWriteBindSecretId (string roleName, string approleMountPath, AppRoleWriteBindSecretIdRequest appRoleWriteBindSecretIdRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleWriteBindSecretIdExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            
            
            
            var appRoleWriteBindSecretIdRequest = new AppRoleWriteBindSecretIdRequest(); // AppRoleWriteBindSecretIdRequest | 
            
            

            try
            {
                

                apiInstance.AppRoleWriteBindSecretId(string roleName, string approleMountPath, AppRoleWriteBindSecretIdRequest appRoleWriteBindSecretIdRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleWriteBindSecretId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]
 **appRoleWriteBindSecretIdRequest** | [**AppRoleWriteBindSecretIdRequest**](AppRoleWriteBindSecretIdRequest.md)|  | 


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

| **204** | No Content |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="approlewriteboundcidrlist"></a>
# **AppRoleWriteBoundCidrList**

> void AppRoleWriteBoundCidrList (string roleName, string approleMountPath, AppRoleWriteBoundCidrListRequest appRoleWriteBoundCidrListRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleWriteBoundCidrListExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            
            
            
            var appRoleWriteBoundCidrListRequest = new AppRoleWriteBoundCidrListRequest(); // AppRoleWriteBoundCidrListRequest | 
            
            

            try
            {
                

                apiInstance.AppRoleWriteBoundCidrList(string roleName, string approleMountPath, AppRoleWriteBoundCidrListRequest appRoleWriteBoundCidrListRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleWriteBoundCidrList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]
 **appRoleWriteBoundCidrListRequest** | [**AppRoleWriteBoundCidrListRequest**](AppRoleWriteBoundCidrListRequest.md)|  | 


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

| **204** | No Content |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="approlewritecustomsecretid"></a>
# **AppRoleWriteCustomSecretId**

> AppRoleWriteCustomSecretIdResponse AppRoleWriteCustomSecretId (string roleName, string approleMountPath, AppRoleWriteCustomSecretIdRequest appRoleWriteCustomSecretIdRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleWriteCustomSecretIdExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            
            
            
            var appRoleWriteCustomSecretIdRequest = new AppRoleWriteCustomSecretIdRequest(); // AppRoleWriteCustomSecretIdRequest | 
            
            

            try
            {
                

                AppRoleWriteCustomSecretIdResponse result = apiInstance.AppRoleWriteCustomSecretId(string roleName, string approleMountPath, AppRoleWriteCustomSecretIdRequest appRoleWriteCustomSecretIdRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleWriteCustomSecretId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]
 **appRoleWriteCustomSecretIdRequest** | [**AppRoleWriteCustomSecretIdRequest**](AppRoleWriteCustomSecretIdRequest.md)|  | 


### Return type

[**AppRoleWriteCustomSecretIdResponse**](AppRoleWriteCustomSecretIdResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="approlewriteperiod"></a>
# **AppRoleWritePeriod**

> void AppRoleWritePeriod (string roleName, string approleMountPath, AppRoleWritePeriodRequest appRoleWritePeriodRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleWritePeriodExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            
            
            
            var appRoleWritePeriodRequest = new AppRoleWritePeriodRequest(); // AppRoleWritePeriodRequest | 
            
            

            try
            {
                

                apiInstance.AppRoleWritePeriod(string roleName, string approleMountPath, AppRoleWritePeriodRequest appRoleWritePeriodRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleWritePeriod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]
 **appRoleWritePeriodRequest** | [**AppRoleWritePeriodRequest**](AppRoleWritePeriodRequest.md)|  | 


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

| **204** | No Content |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="approlewritepolicies"></a>
# **AppRoleWritePolicies**

> void AppRoleWritePolicies (string roleName, string approleMountPath, AppRoleWritePoliciesRequest appRoleWritePoliciesRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleWritePoliciesExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            
            
            
            var appRoleWritePoliciesRequest = new AppRoleWritePoliciesRequest(); // AppRoleWritePoliciesRequest | 
            
            

            try
            {
                

                apiInstance.AppRoleWritePolicies(string roleName, string approleMountPath, AppRoleWritePoliciesRequest appRoleWritePoliciesRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleWritePolicies: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]
 **appRoleWritePoliciesRequest** | [**AppRoleWritePoliciesRequest**](AppRoleWritePoliciesRequest.md)|  | 


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

| **204** | No Content |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="approlewriterole"></a>
# **AppRoleWriteRole**

> void AppRoleWriteRole (string roleName, string approleMountPath, AppRoleWriteRoleRequest appRoleWriteRoleRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleWriteRoleExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            
            
            
            var appRoleWriteRoleRequest = new AppRoleWriteRoleRequest(); // AppRoleWriteRoleRequest | 
            
            

            try
            {
                

                apiInstance.AppRoleWriteRole(string roleName, string approleMountPath, AppRoleWriteRoleRequest appRoleWriteRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleWriteRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]
 **appRoleWriteRoleRequest** | [**AppRoleWriteRoleRequest**](AppRoleWriteRoleRequest.md)|  | 


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

<a name="approlewriteroleid"></a>
# **AppRoleWriteRoleId**

> void AppRoleWriteRoleId (string roleName, string approleMountPath, AppRoleWriteRoleIdRequest appRoleWriteRoleIdRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleWriteRoleIdExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            
            
            
            var appRoleWriteRoleIdRequest = new AppRoleWriteRoleIdRequest(); // AppRoleWriteRoleIdRequest | 
            
            

            try
            {
                

                apiInstance.AppRoleWriteRoleId(string roleName, string approleMountPath, AppRoleWriteRoleIdRequest appRoleWriteRoleIdRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleWriteRoleId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]
 **appRoleWriteRoleIdRequest** | [**AppRoleWriteRoleIdRequest**](AppRoleWriteRoleIdRequest.md)|  | 


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

| **204** | No Content |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="approlewritesecretid"></a>
# **AppRoleWriteSecretId**

> AppRoleWriteSecretIdResponse AppRoleWriteSecretId (string roleName, string approleMountPath, AppRoleWriteSecretIdRequest appRoleWriteSecretIdRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleWriteSecretIdExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            
            
            
            var appRoleWriteSecretIdRequest = new AppRoleWriteSecretIdRequest(); // AppRoleWriteSecretIdRequest | 
            
            

            try
            {
                

                AppRoleWriteSecretIdResponse result = apiInstance.AppRoleWriteSecretId(string roleName, string approleMountPath, AppRoleWriteSecretIdRequest appRoleWriteSecretIdRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleWriteSecretId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]
 **appRoleWriteSecretIdRequest** | [**AppRoleWriteSecretIdRequest**](AppRoleWriteSecretIdRequest.md)|  | 


### Return type

[**AppRoleWriteSecretIdResponse**](AppRoleWriteSecretIdResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="approlewritesecretidboundcidrs"></a>
# **AppRoleWriteSecretIdBoundCidrs**

> void AppRoleWriteSecretIdBoundCidrs (string roleName, string approleMountPath, AppRoleWriteSecretIdBoundCidrsRequest appRoleWriteSecretIdBoundCidrsRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleWriteSecretIdBoundCidrsExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            
            
            
            var appRoleWriteSecretIdBoundCidrsRequest = new AppRoleWriteSecretIdBoundCidrsRequest(); // AppRoleWriteSecretIdBoundCidrsRequest | 
            
            

            try
            {
                

                apiInstance.AppRoleWriteSecretIdBoundCidrs(string roleName, string approleMountPath, AppRoleWriteSecretIdBoundCidrsRequest appRoleWriteSecretIdBoundCidrsRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleWriteSecretIdBoundCidrs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]
 **appRoleWriteSecretIdBoundCidrsRequest** | [**AppRoleWriteSecretIdBoundCidrsRequest**](AppRoleWriteSecretIdBoundCidrsRequest.md)|  | 


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

| **204** | No Content |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="approlewritesecretidnumuses"></a>
# **AppRoleWriteSecretIdNumUses**

> void AppRoleWriteSecretIdNumUses (string roleName, string approleMountPath, AppRoleWriteSecretIdNumUsesRequest appRoleWriteSecretIdNumUsesRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleWriteSecretIdNumUsesExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            
            
            
            var appRoleWriteSecretIdNumUsesRequest = new AppRoleWriteSecretIdNumUsesRequest(); // AppRoleWriteSecretIdNumUsesRequest | 
            
            

            try
            {
                

                apiInstance.AppRoleWriteSecretIdNumUses(string roleName, string approleMountPath, AppRoleWriteSecretIdNumUsesRequest appRoleWriteSecretIdNumUsesRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleWriteSecretIdNumUses: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]
 **appRoleWriteSecretIdNumUsesRequest** | [**AppRoleWriteSecretIdNumUsesRequest**](AppRoleWriteSecretIdNumUsesRequest.md)|  | 


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

| **204** | No Content |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="approlewritesecretidttl"></a>
# **AppRoleWriteSecretIdTtl**

> void AppRoleWriteSecretIdTtl (string roleName, string approleMountPath, AppRoleWriteSecretIdTtlRequest appRoleWriteSecretIdTtlRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleWriteSecretIdTtlExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            
            
            
            var appRoleWriteSecretIdTtlRequest = new AppRoleWriteSecretIdTtlRequest(); // AppRoleWriteSecretIdTtlRequest | 
            
            

            try
            {
                

                apiInstance.AppRoleWriteSecretIdTtl(string roleName, string approleMountPath, AppRoleWriteSecretIdTtlRequest appRoleWriteSecretIdTtlRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleWriteSecretIdTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]
 **appRoleWriteSecretIdTtlRequest** | [**AppRoleWriteSecretIdTtlRequest**](AppRoleWriteSecretIdTtlRequest.md)|  | 


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

| **204** | No Content |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="approlewritetokenboundcidrs"></a>
# **AppRoleWriteTokenBoundCidrs**

> void AppRoleWriteTokenBoundCidrs (string roleName, string approleMountPath, AppRoleWriteTokenBoundCidrsRequest appRoleWriteTokenBoundCidrsRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleWriteTokenBoundCidrsExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            
            
            
            var appRoleWriteTokenBoundCidrsRequest = new AppRoleWriteTokenBoundCidrsRequest(); // AppRoleWriteTokenBoundCidrsRequest | 
            
            

            try
            {
                

                apiInstance.AppRoleWriteTokenBoundCidrs(string roleName, string approleMountPath, AppRoleWriteTokenBoundCidrsRequest appRoleWriteTokenBoundCidrsRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleWriteTokenBoundCidrs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]
 **appRoleWriteTokenBoundCidrsRequest** | [**AppRoleWriteTokenBoundCidrsRequest**](AppRoleWriteTokenBoundCidrsRequest.md)|  | 


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

| **204** | No Content |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="approlewritetokenmaxttl"></a>
# **AppRoleWriteTokenMaxTtl**

> void AppRoleWriteTokenMaxTtl (string roleName, string approleMountPath, AppRoleWriteTokenMaxTtlRequest appRoleWriteTokenMaxTtlRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleWriteTokenMaxTtlExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            
            
            
            var appRoleWriteTokenMaxTtlRequest = new AppRoleWriteTokenMaxTtlRequest(); // AppRoleWriteTokenMaxTtlRequest | 
            
            

            try
            {
                

                apiInstance.AppRoleWriteTokenMaxTtl(string roleName, string approleMountPath, AppRoleWriteTokenMaxTtlRequest appRoleWriteTokenMaxTtlRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleWriteTokenMaxTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]
 **appRoleWriteTokenMaxTtlRequest** | [**AppRoleWriteTokenMaxTtlRequest**](AppRoleWriteTokenMaxTtlRequest.md)|  | 


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

| **204** | No Content |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="approlewritetokennumuses"></a>
# **AppRoleWriteTokenNumUses**

> void AppRoleWriteTokenNumUses (string roleName, string approleMountPath, AppRoleWriteTokenNumUsesRequest appRoleWriteTokenNumUsesRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleWriteTokenNumUsesExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            
            
            
            var appRoleWriteTokenNumUsesRequest = new AppRoleWriteTokenNumUsesRequest(); // AppRoleWriteTokenNumUsesRequest | 
            
            

            try
            {
                

                apiInstance.AppRoleWriteTokenNumUses(string roleName, string approleMountPath, AppRoleWriteTokenNumUsesRequest appRoleWriteTokenNumUsesRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleWriteTokenNumUses: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]
 **appRoleWriteTokenNumUsesRequest** | [**AppRoleWriteTokenNumUsesRequest**](AppRoleWriteTokenNumUsesRequest.md)|  | 


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

| **204** | No Content |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="approlewritetokenttl"></a>
# **AppRoleWriteTokenTtl**

> void AppRoleWriteTokenTtl (string roleName, string approleMountPath, AppRoleWriteTokenTtlRequest appRoleWriteTokenTtlRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AppRoleWriteTokenTtlExample
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
            
            
            
            
            var approleMountPath = "\"approle\"";  // string | Path that the backend was mounted at (default to "approle")
            
            
            
            
            
            var appRoleWriteTokenTtlRequest = new AppRoleWriteTokenTtlRequest(); // AppRoleWriteTokenTtlRequest | 
            
            

            try
            {
                

                apiInstance.AppRoleWriteTokenTtl(string roleName, string approleMountPath, AppRoleWriteTokenTtlRequest appRoleWriteTokenTtlRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AppRoleWriteTokenTtl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role. Must be less than 4096 bytes. | 
 **approleMountPath** | **string**| Path that the backend was mounted at | [default to &quot;approle&quot;]
 **appRoleWriteTokenTtlRequest** | [**AppRoleWriteTokenTtlRequest**](AppRoleWriteTokenTtlRequest.md)|  | 


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

| **204** | No Content |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awsconfigurecertificate"></a>
# **AwsConfigureCertificate**

> void AwsConfigureCertificate (string certName, string awsMountPath, AwsConfigureCertificateRequest awsConfigureCertificateRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsConfigureCertificateExample
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
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            
            var awsConfigureCertificateRequest = new AwsConfigureCertificateRequest(); // AwsConfigureCertificateRequest | 
            
            

            try
            {
                

                apiInstance.AwsConfigureCertificate(string certName, string awsMountPath, AwsConfigureCertificateRequest awsConfigureCertificateRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsConfigureCertificate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **certName** | **string**| Name of the certificate. | 
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]
 **awsConfigureCertificateRequest** | [**AwsConfigureCertificateRequest**](AwsConfigureCertificateRequest.md)|  | 


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

<a name="awsconfigureclient"></a>
# **AwsConfigureClient**

> void AwsConfigureClient (string awsMountPath, AwsConfigureClientRequest awsConfigureClientRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsConfigureClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            
            var awsConfigureClientRequest = new AwsConfigureClientRequest(); // AwsConfigureClientRequest | 
            
            

            try
            {
                

                apiInstance.AwsConfigureClient(string awsMountPath, AwsConfigureClientRequest awsConfigureClientRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsConfigureClient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]
 **awsConfigureClientRequest** | [**AwsConfigureClientRequest**](AwsConfigureClientRequest.md)|  | 


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

<a name="awsconfigureidentityaccesslisttidyoperation"></a>
# **AwsConfigureIdentityAccessListTidyOperation**

> void AwsConfigureIdentityAccessListTidyOperation (string awsMountPath, AwsConfigureIdentityAccessListTidyOperationRequest awsConfigureIdentityAccessListTidyOperationRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsConfigureIdentityAccessListTidyOperationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            
            var awsConfigureIdentityAccessListTidyOperationRequest = new AwsConfigureIdentityAccessListTidyOperationRequest(); // AwsConfigureIdentityAccessListTidyOperationRequest | 
            
            

            try
            {
                

                apiInstance.AwsConfigureIdentityAccessListTidyOperation(string awsMountPath, AwsConfigureIdentityAccessListTidyOperationRequest awsConfigureIdentityAccessListTidyOperationRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsConfigureIdentityAccessListTidyOperation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]
 **awsConfigureIdentityAccessListTidyOperationRequest** | [**AwsConfigureIdentityAccessListTidyOperationRequest**](AwsConfigureIdentityAccessListTidyOperationRequest.md)|  | 


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

<a name="awsconfigureidentityintegration"></a>
# **AwsConfigureIdentityIntegration**

> void AwsConfigureIdentityIntegration (string awsMountPath, AwsConfigureIdentityIntegrationRequest awsConfigureIdentityIntegrationRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsConfigureIdentityIntegrationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            
            var awsConfigureIdentityIntegrationRequest = new AwsConfigureIdentityIntegrationRequest(); // AwsConfigureIdentityIntegrationRequest | 
            
            

            try
            {
                

                apiInstance.AwsConfigureIdentityIntegration(string awsMountPath, AwsConfigureIdentityIntegrationRequest awsConfigureIdentityIntegrationRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsConfigureIdentityIntegration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]
 **awsConfigureIdentityIntegrationRequest** | [**AwsConfigureIdentityIntegrationRequest**](AwsConfigureIdentityIntegrationRequest.md)|  | 


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

<a name="awsconfigureidentitywhitelisttidyoperation"></a>
# **AwsConfigureIdentityWhitelistTidyOperation**

> void AwsConfigureIdentityWhitelistTidyOperation (string awsMountPath, AwsConfigureIdentityWhitelistTidyOperationRequest awsConfigureIdentityWhitelistTidyOperationRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsConfigureIdentityWhitelistTidyOperationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            
            var awsConfigureIdentityWhitelistTidyOperationRequest = new AwsConfigureIdentityWhitelistTidyOperationRequest(); // AwsConfigureIdentityWhitelistTidyOperationRequest | 
            
            

            try
            {
                

                apiInstance.AwsConfigureIdentityWhitelistTidyOperation(string awsMountPath, AwsConfigureIdentityWhitelistTidyOperationRequest awsConfigureIdentityWhitelistTidyOperationRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsConfigureIdentityWhitelistTidyOperation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]
 **awsConfigureIdentityWhitelistTidyOperationRequest** | [**AwsConfigureIdentityWhitelistTidyOperationRequest**](AwsConfigureIdentityWhitelistTidyOperationRequest.md)|  | 


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

<a name="awsconfigureroletagblacklisttidyoperation"></a>
# **AwsConfigureRoleTagBlacklistTidyOperation**

> void AwsConfigureRoleTagBlacklistTidyOperation (string awsMountPath, AwsConfigureRoleTagBlacklistTidyOperationRequest awsConfigureRoleTagBlacklistTidyOperationRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsConfigureRoleTagBlacklistTidyOperationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            
            var awsConfigureRoleTagBlacklistTidyOperationRequest = new AwsConfigureRoleTagBlacklistTidyOperationRequest(); // AwsConfigureRoleTagBlacklistTidyOperationRequest | 
            
            

            try
            {
                

                apiInstance.AwsConfigureRoleTagBlacklistTidyOperation(string awsMountPath, AwsConfigureRoleTagBlacklistTidyOperationRequest awsConfigureRoleTagBlacklistTidyOperationRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsConfigureRoleTagBlacklistTidyOperation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]
 **awsConfigureRoleTagBlacklistTidyOperationRequest** | [**AwsConfigureRoleTagBlacklistTidyOperationRequest**](AwsConfigureRoleTagBlacklistTidyOperationRequest.md)|  | 


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

<a name="awsconfigureroletagdenylisttidyoperation"></a>
# **AwsConfigureRoleTagDenyListTidyOperation**

> void AwsConfigureRoleTagDenyListTidyOperation (string awsMountPath, AwsConfigureRoleTagDenyListTidyOperationRequest awsConfigureRoleTagDenyListTidyOperationRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsConfigureRoleTagDenyListTidyOperationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            
            var awsConfigureRoleTagDenyListTidyOperationRequest = new AwsConfigureRoleTagDenyListTidyOperationRequest(); // AwsConfigureRoleTagDenyListTidyOperationRequest | 
            
            

            try
            {
                

                apiInstance.AwsConfigureRoleTagDenyListTidyOperation(string awsMountPath, AwsConfigureRoleTagDenyListTidyOperationRequest awsConfigureRoleTagDenyListTidyOperationRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsConfigureRoleTagDenyListTidyOperation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]
 **awsConfigureRoleTagDenyListTidyOperationRequest** | [**AwsConfigureRoleTagDenyListTidyOperationRequest**](AwsConfigureRoleTagDenyListTidyOperationRequest.md)|  | 


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

<a name="awsdeleteauthrole"></a>
# **AwsDeleteAuthRole**

> void AwsDeleteAuthRole (string role, string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsDeleteAuthRoleExample
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
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsDeleteAuthRole(string role, string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsDeleteAuthRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| Name of the role. | 
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

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

<a name="awsdeletecertificateconfiguration"></a>
# **AwsDeleteCertificateConfiguration**

> void AwsDeleteCertificateConfiguration (string certName, string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsDeleteCertificateConfigurationExample
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
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsDeleteCertificateConfiguration(string certName, string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsDeleteCertificateConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **certName** | **string**| Name of the certificate. | 
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

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

<a name="awsdeleteclientconfiguration"></a>
# **AwsDeleteClientConfiguration**

> void AwsDeleteClientConfiguration (string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsDeleteClientConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsDeleteClientConfiguration(string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsDeleteClientConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

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

<a name="awsdeleteidentityaccesslist"></a>
# **AwsDeleteIdentityAccessList**

> void AwsDeleteIdentityAccessList (string instanceId, string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsDeleteIdentityAccessListExample
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
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsDeleteIdentityAccessList(string instanceId, string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsDeleteIdentityAccessList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instanceId** | **string**| EC2 instance ID. A successful login operation from an EC2 instance gets cached in this accesslist, keyed off of instance ID. | 
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

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

<a name="awsdeleteidentityaccesslisttidysettings"></a>
# **AwsDeleteIdentityAccessListTidySettings**

> void AwsDeleteIdentityAccessListTidySettings (string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsDeleteIdentityAccessListTidySettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsDeleteIdentityAccessListTidySettings(string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsDeleteIdentityAccessListTidySettings: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

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

<a name="awsdeleteidentitywhitelist"></a>
# **AwsDeleteIdentityWhitelist**

> void AwsDeleteIdentityWhitelist (string instanceId, string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsDeleteIdentityWhitelistExample
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
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsDeleteIdentityWhitelist(string instanceId, string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsDeleteIdentityWhitelist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instanceId** | **string**| EC2 instance ID. A successful login operation from an EC2 instance gets cached in this accesslist, keyed off of instance ID. | 
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

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

<a name="awsdeleteidentitywhitelisttidysettings"></a>
# **AwsDeleteIdentityWhitelistTidySettings**

> void AwsDeleteIdentityWhitelistTidySettings (string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsDeleteIdentityWhitelistTidySettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsDeleteIdentityWhitelistTidySettings(string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsDeleteIdentityWhitelistTidySettings: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

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

<a name="awsdeleteroletagblacklist"></a>
# **AwsDeleteRoleTagBlacklist**

> void AwsDeleteRoleTagBlacklist (string roleTag, string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsDeleteRoleTagBlacklistExample
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
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsDeleteRoleTagBlacklist(string roleTag, string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsDeleteRoleTagBlacklist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleTag** | **string**| Role tag to be deny listed. The tag can be supplied as-is. In order to avoid any encoding problems, it can be base64 encoded. | 
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

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

<a name="awsdeleteroletagblacklisttidysettings"></a>
# **AwsDeleteRoleTagBlacklistTidySettings**

> void AwsDeleteRoleTagBlacklistTidySettings (string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsDeleteRoleTagBlacklistTidySettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsDeleteRoleTagBlacklistTidySettings(string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsDeleteRoleTagBlacklistTidySettings: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

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

<a name="awsdeleteroletagdenylist"></a>
# **AwsDeleteRoleTagDenyList**

> void AwsDeleteRoleTagDenyList (string roleTag, string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsDeleteRoleTagDenyListExample
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
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsDeleteRoleTagDenyList(string roleTag, string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsDeleteRoleTagDenyList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleTag** | **string**| Role tag to be deny listed. The tag can be supplied as-is. In order to avoid any encoding problems, it can be base64 encoded. | 
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

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

<a name="awsdeleteroletagdenylisttidysettings"></a>
# **AwsDeleteRoleTagDenyListTidySettings**

> void AwsDeleteRoleTagDenyListTidySettings (string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsDeleteRoleTagDenyListTidySettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsDeleteRoleTagDenyListTidySettings(string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsDeleteRoleTagDenyListTidySettings: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

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

<a name="awsdeletestsrole"></a>
# **AwsDeleteStsRole**

> void AwsDeleteStsRole (string accountId, string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsDeleteStsRoleExample
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
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsDeleteStsRole(string accountId, string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsDeleteStsRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| AWS account ID to be associated with STS role. If set, Vault will use assumed credentials to verify any login attempts from EC2 instances in this account. | 
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

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

<a name="awslistauthroles"></a>
# **AwsListAuthRoles**

> StandardListResponse AwsListAuthRoles (string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsListAuthRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                StandardListResponse result = apiInstance.AwsListAuthRoles(string awsMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsListAuthRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]
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

<a name="awslistcertificateconfigurations"></a>
# **AwsListCertificateConfigurations**

> StandardListResponse AwsListCertificateConfigurations (string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsListCertificateConfigurationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                StandardListResponse result = apiInstance.AwsListCertificateConfigurations(string awsMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsListCertificateConfigurations: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]
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

<a name="awslistidentityaccesslist"></a>
# **AwsListIdentityAccessList**

> StandardListResponse AwsListIdentityAccessList (string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsListIdentityAccessListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                StandardListResponse result = apiInstance.AwsListIdentityAccessList(string awsMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsListIdentityAccessList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]
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

<a name="awslistidentitywhitelist"></a>
# **AwsListIdentityWhitelist**

> StandardListResponse AwsListIdentityWhitelist (string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsListIdentityWhitelistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                StandardListResponse result = apiInstance.AwsListIdentityWhitelist(string awsMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsListIdentityWhitelist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]
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

<a name="awslistroletagblacklists"></a>
# **AwsListRoleTagBlacklists**

> StandardListResponse AwsListRoleTagBlacklists (string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsListRoleTagBlacklistsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                StandardListResponse result = apiInstance.AwsListRoleTagBlacklists(string awsMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsListRoleTagBlacklists: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]
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

<a name="awslistroletagdenylists"></a>
# **AwsListRoleTagDenyLists**

> StandardListResponse AwsListRoleTagDenyLists (string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsListRoleTagDenyListsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                StandardListResponse result = apiInstance.AwsListRoleTagDenyLists(string awsMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsListRoleTagDenyLists: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]
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

<a name="awsliststsrolerelationships"></a>
# **AwsListStsRoleRelationships**

> StandardListResponse AwsListStsRoleRelationships (string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsListStsRoleRelationshipsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                StandardListResponse result = apiInstance.AwsListStsRoleRelationships(string awsMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsListStsRoleRelationships: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]
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

<a name="awslogin"></a>
# **AwsLogin**

> void AwsLogin (string awsMountPath, AwsLoginRequest awsLoginRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            
            var awsLoginRequest = new AwsLoginRequest(); // AwsLoginRequest | 
            
            

            try
            {
                

                apiInstance.AwsLogin(string awsMountPath, AwsLoginRequest awsLoginRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]
 **awsLoginRequest** | [**AwsLoginRequest**](AwsLoginRequest.md)|  | 


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

<a name="awsreadauthrole"></a>
# **AwsReadAuthRole**

> void AwsReadAuthRole (string role, string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsReadAuthRoleExample
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
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsReadAuthRole(string role, string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsReadAuthRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| Name of the role. | 
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awsreadcertificateconfiguration"></a>
# **AwsReadCertificateConfiguration**

> void AwsReadCertificateConfiguration (string certName, string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsReadCertificateConfigurationExample
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
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsReadCertificateConfiguration(string certName, string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsReadCertificateConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **certName** | **string**| Name of the certificate. | 
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awsreadclientconfiguration"></a>
# **AwsReadClientConfiguration**

> void AwsReadClientConfiguration (string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsReadClientConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsReadClientConfiguration(string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsReadClientConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awsreadidentityaccesslist"></a>
# **AwsReadIdentityAccessList**

> void AwsReadIdentityAccessList (string instanceId, string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsReadIdentityAccessListExample
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
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsReadIdentityAccessList(string instanceId, string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsReadIdentityAccessList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instanceId** | **string**| EC2 instance ID. A successful login operation from an EC2 instance gets cached in this accesslist, keyed off of instance ID. | 
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awsreadidentityaccesslisttidysettings"></a>
# **AwsReadIdentityAccessListTidySettings**

> void AwsReadIdentityAccessListTidySettings (string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsReadIdentityAccessListTidySettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsReadIdentityAccessListTidySettings(string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsReadIdentityAccessListTidySettings: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awsreadidentityintegrationconfiguration"></a>
# **AwsReadIdentityIntegrationConfiguration**

> void AwsReadIdentityIntegrationConfiguration (string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsReadIdentityIntegrationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsReadIdentityIntegrationConfiguration(string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsReadIdentityIntegrationConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awsreadidentitywhitelist"></a>
# **AwsReadIdentityWhitelist**

> void AwsReadIdentityWhitelist (string instanceId, string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsReadIdentityWhitelistExample
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
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsReadIdentityWhitelist(string instanceId, string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsReadIdentityWhitelist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instanceId** | **string**| EC2 instance ID. A successful login operation from an EC2 instance gets cached in this accesslist, keyed off of instance ID. | 
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awsreadidentitywhitelisttidysettings"></a>
# **AwsReadIdentityWhitelistTidySettings**

> void AwsReadIdentityWhitelistTidySettings (string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsReadIdentityWhitelistTidySettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsReadIdentityWhitelistTidySettings(string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsReadIdentityWhitelistTidySettings: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awsreadroletagblacklist"></a>
# **AwsReadRoleTagBlacklist**

> void AwsReadRoleTagBlacklist (string roleTag, string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsReadRoleTagBlacklistExample
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
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsReadRoleTagBlacklist(string roleTag, string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsReadRoleTagBlacklist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleTag** | **string**| Role tag to be deny listed. The tag can be supplied as-is. In order to avoid any encoding problems, it can be base64 encoded. | 
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awsreadroletagblacklisttidysettings"></a>
# **AwsReadRoleTagBlacklistTidySettings**

> void AwsReadRoleTagBlacklistTidySettings (string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsReadRoleTagBlacklistTidySettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsReadRoleTagBlacklistTidySettings(string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsReadRoleTagBlacklistTidySettings: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awsreadroletagdenylist"></a>
# **AwsReadRoleTagDenyList**

> void AwsReadRoleTagDenyList (string roleTag, string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsReadRoleTagDenyListExample
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
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsReadRoleTagDenyList(string roleTag, string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsReadRoleTagDenyList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleTag** | **string**| Role tag to be deny listed. The tag can be supplied as-is. In order to avoid any encoding problems, it can be base64 encoded. | 
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awsreadroletagdenylisttidysettings"></a>
# **AwsReadRoleTagDenyListTidySettings**

> void AwsReadRoleTagDenyListTidySettings (string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsReadRoleTagDenyListTidySettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsReadRoleTagDenyListTidySettings(string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsReadRoleTagDenyListTidySettings: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awsreadstsrole"></a>
# **AwsReadStsRole**

> void AwsReadStsRole (string accountId, string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsReadStsRoleExample
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
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsReadStsRole(string accountId, string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsReadStsRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| AWS account ID to be associated with STS role. If set, Vault will use assumed credentials to verify any login attempts from EC2 instances in this account. | 
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awsrotaterootcredentials"></a>
# **AwsRotateRootCredentials**

> void AwsRotateRootCredentials (string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsRotateRootCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsRotateRootCredentials(string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsRotateRootCredentials: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awstidyidentityaccesslist"></a>
# **AwsTidyIdentityAccessList**

> void AwsTidyIdentityAccessList (string awsMountPath, AwsTidyIdentityAccessListRequest awsTidyIdentityAccessListRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsTidyIdentityAccessListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            
            var awsTidyIdentityAccessListRequest = new AwsTidyIdentityAccessListRequest(); // AwsTidyIdentityAccessListRequest | 
            
            

            try
            {
                

                apiInstance.AwsTidyIdentityAccessList(string awsMountPath, AwsTidyIdentityAccessListRequest awsTidyIdentityAccessListRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsTidyIdentityAccessList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]
 **awsTidyIdentityAccessListRequest** | [**AwsTidyIdentityAccessListRequest**](AwsTidyIdentityAccessListRequest.md)|  | 


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

<a name="awstidyidentitywhitelist"></a>
# **AwsTidyIdentityWhitelist**

> void AwsTidyIdentityWhitelist (string awsMountPath, AwsTidyIdentityWhitelistRequest awsTidyIdentityWhitelistRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsTidyIdentityWhitelistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            
            var awsTidyIdentityWhitelistRequest = new AwsTidyIdentityWhitelistRequest(); // AwsTidyIdentityWhitelistRequest | 
            
            

            try
            {
                

                apiInstance.AwsTidyIdentityWhitelist(string awsMountPath, AwsTidyIdentityWhitelistRequest awsTidyIdentityWhitelistRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsTidyIdentityWhitelist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]
 **awsTidyIdentityWhitelistRequest** | [**AwsTidyIdentityWhitelistRequest**](AwsTidyIdentityWhitelistRequest.md)|  | 


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

<a name="awstidyroletagblacklist"></a>
# **AwsTidyRoleTagBlacklist**

> void AwsTidyRoleTagBlacklist (string awsMountPath, AwsTidyRoleTagBlacklistRequest awsTidyRoleTagBlacklistRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsTidyRoleTagBlacklistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            
            var awsTidyRoleTagBlacklistRequest = new AwsTidyRoleTagBlacklistRequest(); // AwsTidyRoleTagBlacklistRequest | 
            
            

            try
            {
                

                apiInstance.AwsTidyRoleTagBlacklist(string awsMountPath, AwsTidyRoleTagBlacklistRequest awsTidyRoleTagBlacklistRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsTidyRoleTagBlacklist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]
 **awsTidyRoleTagBlacklistRequest** | [**AwsTidyRoleTagBlacklistRequest**](AwsTidyRoleTagBlacklistRequest.md)|  | 


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

<a name="awstidyroletagdenylist"></a>
# **AwsTidyRoleTagDenyList**

> void AwsTidyRoleTagDenyList (string awsMountPath, AwsTidyRoleTagDenyListRequest awsTidyRoleTagDenyListRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsTidyRoleTagDenyListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            
            var awsTidyRoleTagDenyListRequest = new AwsTidyRoleTagDenyListRequest(); // AwsTidyRoleTagDenyListRequest | 
            
            

            try
            {
                

                apiInstance.AwsTidyRoleTagDenyList(string awsMountPath, AwsTidyRoleTagDenyListRequest awsTidyRoleTagDenyListRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsTidyRoleTagDenyList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]
 **awsTidyRoleTagDenyListRequest** | [**AwsTidyRoleTagDenyListRequest**](AwsTidyRoleTagDenyListRequest.md)|  | 


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

<a name="awswriteauthrole"></a>
# **AwsWriteAuthRole**

> void AwsWriteAuthRole (string role, string awsMountPath, AwsWriteAuthRoleRequest awsWriteAuthRoleRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsWriteAuthRoleExample
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
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            
            var awsWriteAuthRoleRequest = new AwsWriteAuthRoleRequest(); // AwsWriteAuthRoleRequest | 
            
            

            try
            {
                

                apiInstance.AwsWriteAuthRole(string role, string awsMountPath, AwsWriteAuthRoleRequest awsWriteAuthRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsWriteAuthRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| Name of the role. | 
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]
 **awsWriteAuthRoleRequest** | [**AwsWriteAuthRoleRequest**](AwsWriteAuthRoleRequest.md)|  | 


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

<a name="awswriteroletag"></a>
# **AwsWriteRoleTag**

> void AwsWriteRoleTag (string role, string awsMountPath, AwsWriteRoleTagRequest awsWriteRoleTagRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsWriteRoleTagExample
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
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            
            var awsWriteRoleTagRequest = new AwsWriteRoleTagRequest(); // AwsWriteRoleTagRequest | 
            
            

            try
            {
                

                apiInstance.AwsWriteRoleTag(string role, string awsMountPath, AwsWriteRoleTagRequest awsWriteRoleTagRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsWriteRoleTag: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| Name of the role. | 
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]
 **awsWriteRoleTagRequest** | [**AwsWriteRoleTagRequest**](AwsWriteRoleTagRequest.md)|  | 


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

<a name="awswriteroletagblacklist"></a>
# **AwsWriteRoleTagBlacklist**

> void AwsWriteRoleTagBlacklist (string roleTag, string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsWriteRoleTagBlacklistExample
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
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsWriteRoleTagBlacklist(string roleTag, string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsWriteRoleTagBlacklist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleTag** | **string**| Role tag to be deny listed. The tag can be supplied as-is. In order to avoid any encoding problems, it can be base64 encoded. | 
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awswriteroletagdenylist"></a>
# **AwsWriteRoleTagDenyList**

> void AwsWriteRoleTagDenyList (string roleTag, string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsWriteRoleTagDenyListExample
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
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsWriteRoleTagDenyList(string roleTag, string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsWriteRoleTagDenyList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleTag** | **string**| Role tag to be deny listed. The tag can be supplied as-is. In order to avoid any encoding problems, it can be base64 encoded. | 
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awswritestsrole"></a>
# **AwsWriteStsRole**

> void AwsWriteStsRole (string accountId, string awsMountPath, AwsWriteStsRoleRequest awsWriteStsRoleRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsWriteStsRoleExample
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
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            
            var awsWriteStsRoleRequest = new AwsWriteStsRoleRequest(); // AwsWriteStsRoleRequest | 
            
            

            try
            {
                

                apiInstance.AwsWriteStsRole(string accountId, string awsMountPath, AwsWriteStsRoleRequest awsWriteStsRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AwsWriteStsRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| AWS account ID to be associated with STS role. If set, Vault will use assumed credentials to verify any login attempts from EC2 instances in this account. | 
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]
 **awsWriteStsRoleRequest** | [**AwsWriteStsRoleRequest**](AwsWriteStsRoleRequest.md)|  | 


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

<a name="azureconfigureauth"></a>
# **AzureConfigureAuth**

> void AzureConfigureAuth (string azureMountPath, AzureConfigureAuthRequest azureConfigureAuthRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AzureConfigureAuthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var azureMountPath = "\"azure\"";  // string | Path that the backend was mounted at (default to "azure")
            
            
            
            
            
            var azureConfigureAuthRequest = new AzureConfigureAuthRequest(); // AzureConfigureAuthRequest | 
            
            

            try
            {
                

                apiInstance.AzureConfigureAuth(string azureMountPath, AzureConfigureAuthRequest azureConfigureAuthRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AzureConfigureAuth: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **azureMountPath** | **string**| Path that the backend was mounted at | [default to &quot;azure&quot;]
 **azureConfigureAuthRequest** | [**AzureConfigureAuthRequest**](AzureConfigureAuthRequest.md)|  | 


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

<a name="azuredeleteauthconfiguration"></a>
# **AzureDeleteAuthConfiguration**

> void AzureDeleteAuthConfiguration (string azureMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AzureDeleteAuthConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var azureMountPath = "\"azure\"";  // string | Path that the backend was mounted at (default to "azure")
            
            
            

            try
            {
                

                apiInstance.AzureDeleteAuthConfiguration(string azureMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AzureDeleteAuthConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **azureMountPath** | **string**| Path that the backend was mounted at | [default to &quot;azure&quot;]


### Return type

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

<a name="azuredeleteauthrole"></a>
# **AzureDeleteAuthRole**

> void AzureDeleteAuthRole (string name, string azureMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AzureDeleteAuthRoleExample
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
            
            
            
            
            var azureMountPath = "\"azure\"";  // string | Path that the backend was mounted at (default to "azure")
            
            
            

            try
            {
                

                apiInstance.AzureDeleteAuthRole(string name, string azureMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AzureDeleteAuthRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the role. | 
 **azureMountPath** | **string**| Path that the backend was mounted at | [default to &quot;azure&quot;]


### Return type

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

<a name="azurelistauthroles"></a>
# **AzureListAuthRoles**

> StandardListResponse AzureListAuthRoles (string azureMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AzureListAuthRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var azureMountPath = "\"azure\"";  // string | Path that the backend was mounted at (default to "azure")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                StandardListResponse result = apiInstance.AzureListAuthRoles(string azureMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AzureListAuthRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **azureMountPath** | **string**| Path that the backend was mounted at | [default to &quot;azure&quot;]
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

<a name="azurelogin"></a>
# **AzureLogin**

> void AzureLogin (string azureMountPath, AzureLoginRequest azureLoginRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AzureLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var azureMountPath = "\"azure\"";  // string | Path that the backend was mounted at (default to "azure")
            
            
            
            
            
            var azureLoginRequest = new AzureLoginRequest(); // AzureLoginRequest | 
            
            

            try
            {
                

                apiInstance.AzureLogin(string azureMountPath, AzureLoginRequest azureLoginRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AzureLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **azureMountPath** | **string**| Path that the backend was mounted at | [default to &quot;azure&quot;]
 **azureLoginRequest** | [**AzureLoginRequest**](AzureLoginRequest.md)|  | 


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

<a name="azurereadauthconfiguration"></a>
# **AzureReadAuthConfiguration**

> void AzureReadAuthConfiguration (string azureMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AzureReadAuthConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var azureMountPath = "\"azure\"";  // string | Path that the backend was mounted at (default to "azure")
            
            
            

            try
            {
                

                apiInstance.AzureReadAuthConfiguration(string azureMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AzureReadAuthConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **azureMountPath** | **string**| Path that the backend was mounted at | [default to &quot;azure&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="azurereadauthrole"></a>
# **AzureReadAuthRole**

> void AzureReadAuthRole (string name, string azureMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AzureReadAuthRoleExample
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
            
            
            
            
            var azureMountPath = "\"azure\"";  // string | Path that the backend was mounted at (default to "azure")
            
            
            

            try
            {
                

                apiInstance.AzureReadAuthRole(string name, string azureMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AzureReadAuthRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the role. | 
 **azureMountPath** | **string**| Path that the backend was mounted at | [default to &quot;azure&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="azurerotaterootcredentials"></a>
# **AzureRotateRootCredentials**

> void AzureRotateRootCredentials (string azureMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AzureRotateRootCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var azureMountPath = "\"azure\"";  // string | Path that the backend was mounted at (default to "azure")
            
            
            

            try
            {
                

                apiInstance.AzureRotateRootCredentials(string azureMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AzureRotateRootCredentials: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **azureMountPath** | **string**| Path that the backend was mounted at | [default to &quot;azure&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="azurewriteauthrole"></a>
# **AzureWriteAuthRole**

> void AzureWriteAuthRole (string name, string azureMountPath, AzureWriteAuthRoleRequest azureWriteAuthRoleRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AzureWriteAuthRoleExample
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
            
            
            
            
            var azureMountPath = "\"azure\"";  // string | Path that the backend was mounted at (default to "azure")
            
            
            
            
            
            var azureWriteAuthRoleRequest = new AzureWriteAuthRoleRequest(); // AzureWriteAuthRoleRequest | 
            
            

            try
            {
                

                apiInstance.AzureWriteAuthRole(string name, string azureMountPath, AzureWriteAuthRoleRequest azureWriteAuthRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.AzureWriteAuthRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the role. | 
 **azureMountPath** | **string**| Path that the backend was mounted at | [default to &quot;azure&quot;]
 **azureWriteAuthRoleRequest** | [**AzureWriteAuthRoleRequest**](AzureWriteAuthRoleRequest.md)|  | 


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

<a name="centrifyconfigure"></a>
# **CentrifyConfigure**

> void CentrifyConfigure (string centrifyMountPath, CentrifyConfigureRequest centrifyConfigureRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class CentrifyConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var centrifyMountPath = "\"centrify\"";  // string | Path that the backend was mounted at (default to "centrify")
            
            
            
            
            
            var centrifyConfigureRequest = new CentrifyConfigureRequest(); // CentrifyConfigureRequest | 
            
            

            try
            {
                

                apiInstance.CentrifyConfigure(string centrifyMountPath, CentrifyConfigureRequest centrifyConfigureRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.CentrifyConfigure: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **centrifyMountPath** | **string**| Path that the backend was mounted at | [default to &quot;centrify&quot;]
 **centrifyConfigureRequest** | [**CentrifyConfigureRequest**](CentrifyConfigureRequest.md)|  | 


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

<a name="centrifylogin"></a>
# **CentrifyLogin**

> void CentrifyLogin (string centrifyMountPath, CentrifyLoginRequest centrifyLoginRequest, TimeSpan? wrapTTL = null)

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
    public class CentrifyLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var centrifyMountPath = "\"centrify\"";  // string | Path that the backend was mounted at (default to "centrify")
            
            
            
            
            
            var centrifyLoginRequest = new CentrifyLoginRequest(); // CentrifyLoginRequest | 
            
            

            try
            {
                
                // Log in with a username and password.
                

                apiInstance.CentrifyLogin(string centrifyMountPath, CentrifyLoginRequest centrifyLoginRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.CentrifyLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **centrifyMountPath** | **string**| Path that the backend was mounted at | [default to &quot;centrify&quot;]
 **centrifyLoginRequest** | [**CentrifyLoginRequest**](CentrifyLoginRequest.md)|  | 


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

<a name="centrifyreadconfiguration"></a>
# **CentrifyReadConfiguration**

> void CentrifyReadConfiguration (string centrifyMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class CentrifyReadConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var centrifyMountPath = "\"centrify\"";  // string | Path that the backend was mounted at (default to "centrify")
            
            
            

            try
            {
                

                apiInstance.CentrifyReadConfiguration(string centrifyMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.CentrifyReadConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **centrifyMountPath** | **string**| Path that the backend was mounted at | [default to &quot;centrify&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="certconfigure"></a>
# **CertConfigure**

> void CertConfigure (string certMountPath, CertConfigureRequest certConfigureRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class CertConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var certMountPath = "\"cert\"";  // string | Path that the backend was mounted at (default to "cert")
            
            
            
            
            
            var certConfigureRequest = new CertConfigureRequest(); // CertConfigureRequest | 
            
            

            try
            {
                

                apiInstance.CertConfigure(string certMountPath, CertConfigureRequest certConfigureRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.CertConfigure: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **certMountPath** | **string**| Path that the backend was mounted at | [default to &quot;cert&quot;]
 **certConfigureRequest** | [**CertConfigureRequest**](CertConfigureRequest.md)|  | 


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

<a name="certdeletecertificate"></a>
# **CertDeleteCertificate**

> void CertDeleteCertificate (string name, string certMountPath, TimeSpan? wrapTTL = null)

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
    public class CertDeleteCertificateExample
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
            
            
            
            
            var certMountPath = "\"cert\"";  // string | Path that the backend was mounted at (default to "cert")
            
            
            

            try
            {
                
                // Manage trusted certificates used for authentication.
                

                apiInstance.CertDeleteCertificate(string name, string certMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.CertDeleteCertificate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the certificate | 
 **certMountPath** | **string**| Path that the backend was mounted at | [default to &quot;cert&quot;]


### Return type

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

<a name="certdeletecrl"></a>
# **CertDeleteCrl**

> void CertDeleteCrl (string name, string certMountPath, TimeSpan? wrapTTL = null)

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
    public class CertDeleteCrlExample
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
            
            
            
            
            var certMountPath = "\"cert\"";  // string | Path that the backend was mounted at (default to "cert")
            
            
            

            try
            {
                
                // Manage Certificate Revocation Lists checked during authentication.
                

                apiInstance.CertDeleteCrl(string name, string certMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.CertDeleteCrl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the certificate | 
 **certMountPath** | **string**| Path that the backend was mounted at | [default to &quot;cert&quot;]


### Return type

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

<a name="certlistcertificates"></a>
# **CertListCertificates**

> StandardListResponse CertListCertificates (string certMountPath, TimeSpan? wrapTTL = null)

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
    public class CertListCertificatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var certMountPath = "\"cert\"";  // string | Path that the backend was mounted at (default to "cert")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // Manage trusted certificates used for authentication.
                

                StandardListResponse result = apiInstance.CertListCertificates(string certMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.CertListCertificates: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **certMountPath** | **string**| Path that the backend was mounted at | [default to &quot;cert&quot;]
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

<a name="certlistcrls"></a>
# **CertListCrls**

> StandardListResponse CertListCrls (string certMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class CertListCrlsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var certMountPath = "\"cert\"";  // string | Path that the backend was mounted at (default to "cert")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                StandardListResponse result = apiInstance.CertListCrls(string certMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.CertListCrls: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **certMountPath** | **string**| Path that the backend was mounted at | [default to &quot;cert&quot;]
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

<a name="certlogin"></a>
# **CertLogin**

> void CertLogin (string certMountPath, CertLoginRequest certLoginRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class CertLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var certMountPath = "\"cert\"";  // string | Path that the backend was mounted at (default to "cert")
            
            
            
            
            
            var certLoginRequest = new CertLoginRequest(); // CertLoginRequest | 
            
            

            try
            {
                

                apiInstance.CertLogin(string certMountPath, CertLoginRequest certLoginRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.CertLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **certMountPath** | **string**| Path that the backend was mounted at | [default to &quot;cert&quot;]
 **certLoginRequest** | [**CertLoginRequest**](CertLoginRequest.md)|  | 


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

<a name="certreadcertificate"></a>
# **CertReadCertificate**

> void CertReadCertificate (string name, string certMountPath, TimeSpan? wrapTTL = null)

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
    public class CertReadCertificateExample
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
            
            
            
            
            var certMountPath = "\"cert\"";  // string | Path that the backend was mounted at (default to "cert")
            
            
            

            try
            {
                
                // Manage trusted certificates used for authentication.
                

                apiInstance.CertReadCertificate(string name, string certMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.CertReadCertificate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the certificate | 
 **certMountPath** | **string**| Path that the backend was mounted at | [default to &quot;cert&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="certreadconfiguration"></a>
# **CertReadConfiguration**

> void CertReadConfiguration (string certMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class CertReadConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var certMountPath = "\"cert\"";  // string | Path that the backend was mounted at (default to "cert")
            
            
            

            try
            {
                

                apiInstance.CertReadConfiguration(string certMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.CertReadConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **certMountPath** | **string**| Path that the backend was mounted at | [default to &quot;cert&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="certreadcrl"></a>
# **CertReadCrl**

> void CertReadCrl (string name, string certMountPath, TimeSpan? wrapTTL = null)

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
    public class CertReadCrlExample
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
            
            
            
            
            var certMountPath = "\"cert\"";  // string | Path that the backend was mounted at (default to "cert")
            
            
            

            try
            {
                
                // Manage Certificate Revocation Lists checked during authentication.
                

                apiInstance.CertReadCrl(string name, string certMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.CertReadCrl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the certificate | 
 **certMountPath** | **string**| Path that the backend was mounted at | [default to &quot;cert&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="certwritecertificate"></a>
# **CertWriteCertificate**

> void CertWriteCertificate (string name, string certMountPath, CertWriteCertificateRequest certWriteCertificateRequest, TimeSpan? wrapTTL = null)

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
    public class CertWriteCertificateExample
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
            
            
            
            
            var certMountPath = "\"cert\"";  // string | Path that the backend was mounted at (default to "cert")
            
            
            
            
            
            var certWriteCertificateRequest = new CertWriteCertificateRequest(); // CertWriteCertificateRequest | 
            
            

            try
            {
                
                // Manage trusted certificates used for authentication.
                

                apiInstance.CertWriteCertificate(string name, string certMountPath, CertWriteCertificateRequest certWriteCertificateRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.CertWriteCertificate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the certificate | 
 **certMountPath** | **string**| Path that the backend was mounted at | [default to &quot;cert&quot;]
 **certWriteCertificateRequest** | [**CertWriteCertificateRequest**](CertWriteCertificateRequest.md)|  | 


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

<a name="certwritecrl"></a>
# **CertWriteCrl**

> void CertWriteCrl (string name, string certMountPath, CertWriteCrlRequest certWriteCrlRequest, TimeSpan? wrapTTL = null)

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
    public class CertWriteCrlExample
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
            
            
            
            
            var certMountPath = "\"cert\"";  // string | Path that the backend was mounted at (default to "cert")
            
            
            
            
            
            var certWriteCrlRequest = new CertWriteCrlRequest(); // CertWriteCrlRequest | 
            
            

            try
            {
                
                // Manage Certificate Revocation Lists checked during authentication.
                

                apiInstance.CertWriteCrl(string name, string certMountPath, CertWriteCrlRequest certWriteCrlRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.CertWriteCrl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the certificate | 
 **certMountPath** | **string**| Path that the backend was mounted at | [default to &quot;cert&quot;]
 **certWriteCrlRequest** | [**CertWriteCrlRequest**](CertWriteCrlRequest.md)|  | 


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

<a name="cloudfoundryconfigure"></a>
# **CloudFoundryConfigure**

> void CloudFoundryConfigure (string cfMountPath, CloudFoundryConfigureRequest cloudFoundryConfigureRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class CloudFoundryConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var cfMountPath = "\"cf\"";  // string | Path that the backend was mounted at (default to "cf")
            
            
            
            
            
            var cloudFoundryConfigureRequest = new CloudFoundryConfigureRequest(); // CloudFoundryConfigureRequest | 
            
            

            try
            {
                

                apiInstance.CloudFoundryConfigure(string cfMountPath, CloudFoundryConfigureRequest cloudFoundryConfigureRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.CloudFoundryConfigure: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cfMountPath** | **string**| Path that the backend was mounted at | [default to &quot;cf&quot;]
 **cloudFoundryConfigureRequest** | [**CloudFoundryConfigureRequest**](CloudFoundryConfigureRequest.md)|  | 


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

<a name="cloudfoundrydeleteconfiguration"></a>
# **CloudFoundryDeleteConfiguration**

> void CloudFoundryDeleteConfiguration (string cfMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class CloudFoundryDeleteConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var cfMountPath = "\"cf\"";  // string | Path that the backend was mounted at (default to "cf")
            
            
            

            try
            {
                

                apiInstance.CloudFoundryDeleteConfiguration(string cfMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.CloudFoundryDeleteConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cfMountPath** | **string**| Path that the backend was mounted at | [default to &quot;cf&quot;]


### Return type

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

<a name="cloudfoundrydeleterole"></a>
# **CloudFoundryDeleteRole**

> void CloudFoundryDeleteRole (string role, string cfMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class CloudFoundryDeleteRoleExample
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
            
            
            
            
            var cfMountPath = "\"cf\"";  // string | Path that the backend was mounted at (default to "cf")
            
            
            

            try
            {
                

                apiInstance.CloudFoundryDeleteRole(string role, string cfMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.CloudFoundryDeleteRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The name of the role. | 
 **cfMountPath** | **string**| Path that the backend was mounted at | [default to &quot;cf&quot;]


### Return type

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

<a name="cloudfoundrylistroles"></a>
# **CloudFoundryListRoles**

> StandardListResponse CloudFoundryListRoles (string cfMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class CloudFoundryListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var cfMountPath = "\"cf\"";  // string | Path that the backend was mounted at (default to "cf")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                StandardListResponse result = apiInstance.CloudFoundryListRoles(string cfMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.CloudFoundryListRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cfMountPath** | **string**| Path that the backend was mounted at | [default to &quot;cf&quot;]
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

<a name="cloudfoundrylogin"></a>
# **CloudFoundryLogin**

> void CloudFoundryLogin (string cfMountPath, CloudFoundryLoginRequest cloudFoundryLoginRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class CloudFoundryLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var cfMountPath = "\"cf\"";  // string | Path that the backend was mounted at (default to "cf")
            
            
            
            
            
            var cloudFoundryLoginRequest = new CloudFoundryLoginRequest(); // CloudFoundryLoginRequest | 
            
            

            try
            {
                

                apiInstance.CloudFoundryLogin(string cfMountPath, CloudFoundryLoginRequest cloudFoundryLoginRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.CloudFoundryLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cfMountPath** | **string**| Path that the backend was mounted at | [default to &quot;cf&quot;]
 **cloudFoundryLoginRequest** | [**CloudFoundryLoginRequest**](CloudFoundryLoginRequest.md)|  | 


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

<a name="cloudfoundryreadconfiguration"></a>
# **CloudFoundryReadConfiguration**

> void CloudFoundryReadConfiguration (string cfMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class CloudFoundryReadConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var cfMountPath = "\"cf\"";  // string | Path that the backend was mounted at (default to "cf")
            
            
            

            try
            {
                

                apiInstance.CloudFoundryReadConfiguration(string cfMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.CloudFoundryReadConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cfMountPath** | **string**| Path that the backend was mounted at | [default to &quot;cf&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cloudfoundryreadrole"></a>
# **CloudFoundryReadRole**

> void CloudFoundryReadRole (string role, string cfMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class CloudFoundryReadRoleExample
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
            
            
            
            
            var cfMountPath = "\"cf\"";  // string | Path that the backend was mounted at (default to "cf")
            
            
            

            try
            {
                

                apiInstance.CloudFoundryReadRole(string role, string cfMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.CloudFoundryReadRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The name of the role. | 
 **cfMountPath** | **string**| Path that the backend was mounted at | [default to &quot;cf&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cloudfoundrywriterole"></a>
# **CloudFoundryWriteRole**

> void CloudFoundryWriteRole (string role, string cfMountPath, CloudFoundryWriteRoleRequest cloudFoundryWriteRoleRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class CloudFoundryWriteRoleExample
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
            
            
            
            
            var cfMountPath = "\"cf\"";  // string | Path that the backend was mounted at (default to "cf")
            
            
            
            
            
            var cloudFoundryWriteRoleRequest = new CloudFoundryWriteRoleRequest(); // CloudFoundryWriteRoleRequest | 
            
            

            try
            {
                

                apiInstance.CloudFoundryWriteRole(string role, string cfMountPath, CloudFoundryWriteRoleRequest cloudFoundryWriteRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.CloudFoundryWriteRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The name of the role. | 
 **cfMountPath** | **string**| Path that the backend was mounted at | [default to &quot;cf&quot;]
 **cloudFoundryWriteRoleRequest** | [**CloudFoundryWriteRoleRequest**](CloudFoundryWriteRoleRequest.md)|  | 


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

<a name="githubconfigure"></a>
# **GithubConfigure**

> void GithubConfigure (string githubMountPath, GithubConfigureRequest githubConfigureRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GithubConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var githubMountPath = "\"github\"";  // string | Path that the backend was mounted at (default to "github")
            
            
            
            
            
            var githubConfigureRequest = new GithubConfigureRequest(); // GithubConfigureRequest | 
            
            

            try
            {
                

                apiInstance.GithubConfigure(string githubMountPath, GithubConfigureRequest githubConfigureRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GithubConfigure: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **githubMountPath** | **string**| Path that the backend was mounted at | [default to &quot;github&quot;]
 **githubConfigureRequest** | [**GithubConfigureRequest**](GithubConfigureRequest.md)|  | 


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

<a name="githubdeleteteammapping"></a>
# **GithubDeleteTeamMapping**

> void GithubDeleteTeamMapping (string key, string githubMountPath, TimeSpan? wrapTTL = null)

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
    public class GithubDeleteTeamMappingExample
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
            
            
            
            
            var githubMountPath = "\"github\"";  // string | Path that the backend was mounted at (default to "github")
            
            
            

            try
            {
                
                // Read/write/delete a single teams mapping
                

                apiInstance.GithubDeleteTeamMapping(string key, string githubMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GithubDeleteTeamMapping: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Key for the teams mapping | 
 **githubMountPath** | **string**| Path that the backend was mounted at | [default to &quot;github&quot;]


### Return type

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

<a name="githubdeleteusermapping"></a>
# **GithubDeleteUserMapping**

> void GithubDeleteUserMapping (string key, string githubMountPath, TimeSpan? wrapTTL = null)

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
    public class GithubDeleteUserMappingExample
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
            
            
            
            
            var githubMountPath = "\"github\"";  // string | Path that the backend was mounted at (default to "github")
            
            
            

            try
            {
                
                // Read/write/delete a single users mapping
                

                apiInstance.GithubDeleteUserMapping(string key, string githubMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GithubDeleteUserMapping: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Key for the users mapping | 
 **githubMountPath** | **string**| Path that the backend was mounted at | [default to &quot;github&quot;]


### Return type

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

<a name="githublistteams"></a>
# **GithubListTeams**

> StandardListResponse GithubListTeams (string githubMountPath, TimeSpan? wrapTTL = null)

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
    public class GithubListTeamsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var githubMountPath = "\"github\"";  // string | Path that the backend was mounted at (default to "github")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // Read mappings for teams
                

                StandardListResponse result = apiInstance.GithubListTeams(string githubMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GithubListTeams: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **githubMountPath** | **string**| Path that the backend was mounted at | [default to &quot;github&quot;]
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

<a name="githublistusers"></a>
# **GithubListUsers**

> StandardListResponse GithubListUsers (string githubMountPath, TimeSpan? wrapTTL = null)

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
    public class GithubListUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var githubMountPath = "\"github\"";  // string | Path that the backend was mounted at (default to "github")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // Read mappings for users
                

                StandardListResponse result = apiInstance.GithubListUsers(string githubMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GithubListUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **githubMountPath** | **string**| Path that the backend was mounted at | [default to &quot;github&quot;]
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

<a name="githublogin"></a>
# **GithubLogin**

> void GithubLogin (string githubMountPath, GithubLoginRequest githubLoginRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GithubLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var githubMountPath = "\"github\"";  // string | Path that the backend was mounted at (default to "github")
            
            
            
            
            
            var githubLoginRequest = new GithubLoginRequest(); // GithubLoginRequest | 
            
            

            try
            {
                

                apiInstance.GithubLogin(string githubMountPath, GithubLoginRequest githubLoginRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GithubLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **githubMountPath** | **string**| Path that the backend was mounted at | [default to &quot;github&quot;]
 **githubLoginRequest** | [**GithubLoginRequest**](GithubLoginRequest.md)|  | 


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

<a name="githubreadconfiguration"></a>
# **GithubReadConfiguration**

> void GithubReadConfiguration (string githubMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GithubReadConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var githubMountPath = "\"github\"";  // string | Path that the backend was mounted at (default to "github")
            
            
            

            try
            {
                

                apiInstance.GithubReadConfiguration(string githubMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GithubReadConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **githubMountPath** | **string**| Path that the backend was mounted at | [default to &quot;github&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="githubreadteammapping"></a>
# **GithubReadTeamMapping**

> void GithubReadTeamMapping (string key, string githubMountPath, TimeSpan? wrapTTL = null)

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
    public class GithubReadTeamMappingExample
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
            
            
            
            
            var githubMountPath = "\"github\"";  // string | Path that the backend was mounted at (default to "github")
            
            
            

            try
            {
                
                // Read/write/delete a single teams mapping
                

                apiInstance.GithubReadTeamMapping(string key, string githubMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GithubReadTeamMapping: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Key for the teams mapping | 
 **githubMountPath** | **string**| Path that the backend was mounted at | [default to &quot;github&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="githubreadusermapping"></a>
# **GithubReadUserMapping**

> void GithubReadUserMapping (string key, string githubMountPath, TimeSpan? wrapTTL = null)

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
    public class GithubReadUserMappingExample
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
            
            
            
            
            var githubMountPath = "\"github\"";  // string | Path that the backend was mounted at (default to "github")
            
            
            

            try
            {
                
                // Read/write/delete a single users mapping
                

                apiInstance.GithubReadUserMapping(string key, string githubMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GithubReadUserMapping: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Key for the users mapping | 
 **githubMountPath** | **string**| Path that the backend was mounted at | [default to &quot;github&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="githubwriteteammapping"></a>
# **GithubWriteTeamMapping**

> void GithubWriteTeamMapping (string key, string githubMountPath, GithubWriteTeamMappingRequest githubWriteTeamMappingRequest, TimeSpan? wrapTTL = null)

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
    public class GithubWriteTeamMappingExample
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
            
            
            
            
            var githubMountPath = "\"github\"";  // string | Path that the backend was mounted at (default to "github")
            
            
            
            
            
            var githubWriteTeamMappingRequest = new GithubWriteTeamMappingRequest(); // GithubWriteTeamMappingRequest | 
            
            

            try
            {
                
                // Read/write/delete a single teams mapping
                

                apiInstance.GithubWriteTeamMapping(string key, string githubMountPath, GithubWriteTeamMappingRequest githubWriteTeamMappingRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GithubWriteTeamMapping: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Key for the teams mapping | 
 **githubMountPath** | **string**| Path that the backend was mounted at | [default to &quot;github&quot;]
 **githubWriteTeamMappingRequest** | [**GithubWriteTeamMappingRequest**](GithubWriteTeamMappingRequest.md)|  | 


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

<a name="githubwriteusermapping"></a>
# **GithubWriteUserMapping**

> void GithubWriteUserMapping (string key, string githubMountPath, GithubWriteUserMappingRequest githubWriteUserMappingRequest, TimeSpan? wrapTTL = null)

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
    public class GithubWriteUserMappingExample
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
            
            
            
            
            var githubMountPath = "\"github\"";  // string | Path that the backend was mounted at (default to "github")
            
            
            
            
            
            var githubWriteUserMappingRequest = new GithubWriteUserMappingRequest(); // GithubWriteUserMappingRequest | 
            
            

            try
            {
                
                // Read/write/delete a single users mapping
                

                apiInstance.GithubWriteUserMapping(string key, string githubMountPath, GithubWriteUserMappingRequest githubWriteUserMappingRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GithubWriteUserMapping: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Key for the users mapping | 
 **githubMountPath** | **string**| Path that the backend was mounted at | [default to &quot;github&quot;]
 **githubWriteUserMappingRequest** | [**GithubWriteUserMappingRequest**](GithubWriteUserMappingRequest.md)|  | 


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

<a name="googlecloudconfigureauth"></a>
# **GoogleCloudConfigureAuth**

> void GoogleCloudConfigureAuth (string gcpMountPath, GoogleCloudConfigureAuthRequest googleCloudConfigureAuthRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudConfigureAuthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            
            
            
            var googleCloudConfigureAuthRequest = new GoogleCloudConfigureAuthRequest(); // GoogleCloudConfigureAuthRequest | 
            
            

            try
            {
                

                apiInstance.GoogleCloudConfigureAuth(string gcpMountPath, GoogleCloudConfigureAuthRequest googleCloudConfigureAuthRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GoogleCloudConfigureAuth: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gcpMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcp&quot;]
 **googleCloudConfigureAuthRequest** | [**GoogleCloudConfigureAuthRequest**](GoogleCloudConfigureAuthRequest.md)|  | 


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

<a name="googleclouddeleterole"></a>
# **GoogleCloudDeleteRole**

> void GoogleCloudDeleteRole (string name, string gcpMountPath, TimeSpan? wrapTTL = null)

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
    public class GoogleCloudDeleteRoleExample
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
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            

            try
            {
                
                // Create a GCP role with associated policies and required attributes.
                

                apiInstance.GoogleCloudDeleteRole(string name, string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GoogleCloudDeleteRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the role. | 
 **gcpMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcp&quot;]


### Return type

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

<a name="googlecloudeditlabelsforrole"></a>
# **GoogleCloudEditLabelsForRole**

> void GoogleCloudEditLabelsForRole (string name, string gcpMountPath, GoogleCloudEditLabelsForRoleRequest googleCloudEditLabelsForRoleRequest, TimeSpan? wrapTTL = null)

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
    public class GoogleCloudEditLabelsForRoleExample
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
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            
            
            
            var googleCloudEditLabelsForRoleRequest = new GoogleCloudEditLabelsForRoleRequest(); // GoogleCloudEditLabelsForRoleRequest | 
            
            

            try
            {
                
                // Add or remove labels for an existing 'gce' role
                

                apiInstance.GoogleCloudEditLabelsForRole(string name, string gcpMountPath, GoogleCloudEditLabelsForRoleRequest googleCloudEditLabelsForRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GoogleCloudEditLabelsForRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the role. | 
 **gcpMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcp&quot;]
 **googleCloudEditLabelsForRoleRequest** | [**GoogleCloudEditLabelsForRoleRequest**](GoogleCloudEditLabelsForRoleRequest.md)|  | 


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

<a name="googlecloudeditserviceaccountsforrole"></a>
# **GoogleCloudEditServiceAccountsForRole**

> void GoogleCloudEditServiceAccountsForRole (string name, string gcpMountPath, GoogleCloudEditServiceAccountsForRoleRequest googleCloudEditServiceAccountsForRoleRequest, TimeSpan? wrapTTL = null)

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
    public class GoogleCloudEditServiceAccountsForRoleExample
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
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            
            
            
            var googleCloudEditServiceAccountsForRoleRequest = new GoogleCloudEditServiceAccountsForRoleRequest(); // GoogleCloudEditServiceAccountsForRoleRequest | 
            
            

            try
            {
                
                // Add or remove service accounts for an existing `iam` role
                

                apiInstance.GoogleCloudEditServiceAccountsForRole(string name, string gcpMountPath, GoogleCloudEditServiceAccountsForRoleRequest googleCloudEditServiceAccountsForRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GoogleCloudEditServiceAccountsForRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the role. | 
 **gcpMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcp&quot;]
 **googleCloudEditServiceAccountsForRoleRequest** | [**GoogleCloudEditServiceAccountsForRoleRequest**](GoogleCloudEditServiceAccountsForRoleRequest.md)|  | 


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

<a name="googlecloudlistroles"></a>
# **GoogleCloudListRoles**

> StandardListResponse GoogleCloudListRoles (string gcpMountPath, TimeSpan? wrapTTL = null)

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
    public class GoogleCloudListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // Lists all the roles that are registered with Vault.
                

                StandardListResponse result = apiInstance.GoogleCloudListRoles(string gcpMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GoogleCloudListRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gcpMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcp&quot;]
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

<a name="googlecloudlogin"></a>
# **GoogleCloudLogin**

> void GoogleCloudLogin (string gcpMountPath, GoogleCloudLoginRequest googleCloudLoginRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            
            
            
            var googleCloudLoginRequest = new GoogleCloudLoginRequest(); // GoogleCloudLoginRequest | 
            
            

            try
            {
                

                apiInstance.GoogleCloudLogin(string gcpMountPath, GoogleCloudLoginRequest googleCloudLoginRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GoogleCloudLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gcpMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcp&quot;]
 **googleCloudLoginRequest** | [**GoogleCloudLoginRequest**](GoogleCloudLoginRequest.md)|  | 


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

<a name="googlecloudreadauthconfiguration"></a>
# **GoogleCloudReadAuthConfiguration**

> void GoogleCloudReadAuthConfiguration (string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudReadAuthConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudReadAuthConfiguration(string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GoogleCloudReadAuthConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gcpMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcp&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="googlecloudreadrole"></a>
# **GoogleCloudReadRole**

> void GoogleCloudReadRole (string name, string gcpMountPath, TimeSpan? wrapTTL = null)

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
    public class GoogleCloudReadRoleExample
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
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            

            try
            {
                
                // Create a GCP role with associated policies and required attributes.
                

                apiInstance.GoogleCloudReadRole(string name, string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GoogleCloudReadRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the role. | 
 **gcpMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcp&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="googlecloudwriterole"></a>
# **GoogleCloudWriteRole**

> void GoogleCloudWriteRole (string name, string gcpMountPath, GoogleCloudWriteRoleRequest googleCloudWriteRoleRequest, TimeSpan? wrapTTL = null)

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
    public class GoogleCloudWriteRoleExample
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
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            
            
            
            var googleCloudWriteRoleRequest = new GoogleCloudWriteRoleRequest(); // GoogleCloudWriteRoleRequest | 
            
            

            try
            {
                
                // Create a GCP role with associated policies and required attributes.
                

                apiInstance.GoogleCloudWriteRole(string name, string gcpMountPath, GoogleCloudWriteRoleRequest googleCloudWriteRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.GoogleCloudWriteRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the role. | 
 **gcpMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcp&quot;]
 **googleCloudWriteRoleRequest** | [**GoogleCloudWriteRoleRequest**](GoogleCloudWriteRoleRequest.md)|  | 


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

<a name="jwtconfigure"></a>
# **JwtConfigure**

> void JwtConfigure (string jwtMountPath, JwtConfigureRequest jwtConfigureRequest, TimeSpan? wrapTTL = null)

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
    public class JwtConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var jwtMountPath = "\"jwt\"";  // string | Path that the backend was mounted at (default to "jwt")
            
            
            
            
            
            var jwtConfigureRequest = new JwtConfigureRequest(); // JwtConfigureRequest | 
            
            

            try
            {
                
                // Configure the JWT authentication backend.
                

                apiInstance.JwtConfigure(string jwtMountPath, JwtConfigureRequest jwtConfigureRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.JwtConfigure: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jwtMountPath** | **string**| Path that the backend was mounted at | [default to &quot;jwt&quot;]
 **jwtConfigureRequest** | [**JwtConfigureRequest**](JwtConfigureRequest.md)|  | 


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

<a name="jwtdeleterole"></a>
# **JwtDeleteRole**

> void JwtDeleteRole (string name, string jwtMountPath, TimeSpan? wrapTTL = null)

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
    public class JwtDeleteRoleExample
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
            
            
            
            
            var jwtMountPath = "\"jwt\"";  // string | Path that the backend was mounted at (default to "jwt")
            
            
            

            try
            {
                
                // Delete an existing role.
                

                apiInstance.JwtDeleteRole(string name, string jwtMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.JwtDeleteRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the role. | 
 **jwtMountPath** | **string**| Path that the backend was mounted at | [default to &quot;jwt&quot;]


### Return type

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

<a name="jwtlistroles"></a>
# **JwtListRoles**

> StandardListResponse JwtListRoles (string jwtMountPath, TimeSpan? wrapTTL = null)

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
    public class JwtListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var jwtMountPath = "\"jwt\"";  // string | Path that the backend was mounted at (default to "jwt")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // Lists all the roles registered with the backend.
                

                StandardListResponse result = apiInstance.JwtListRoles(string jwtMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.JwtListRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jwtMountPath** | **string**| Path that the backend was mounted at | [default to &quot;jwt&quot;]
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

<a name="jwtlogin"></a>
# **JwtLogin**

> void JwtLogin (string jwtMountPath, JwtLoginRequest jwtLoginRequest, TimeSpan? wrapTTL = null)

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
    public class JwtLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var jwtMountPath = "\"jwt\"";  // string | Path that the backend was mounted at (default to "jwt")
            
            
            
            
            
            var jwtLoginRequest = new JwtLoginRequest(); // JwtLoginRequest | 
            
            

            try
            {
                
                // Authenticates to Vault using a JWT (or OIDC) token.
                

                apiInstance.JwtLogin(string jwtMountPath, JwtLoginRequest jwtLoginRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.JwtLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jwtMountPath** | **string**| Path that the backend was mounted at | [default to &quot;jwt&quot;]
 **jwtLoginRequest** | [**JwtLoginRequest**](JwtLoginRequest.md)|  | 


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

<a name="jwtoidccallback"></a>
# **JwtOidcCallback**

> void JwtOidcCallback (string jwtMountPath, string clientNonce = default(string), string code = default(string), string state = default(string), TimeSpan? wrapTTL = null)

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
    public class JwtOidcCallbackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var jwtMountPath = "\"jwt\"";  // string | Path that the backend was mounted at (default to "jwt")
            
            
            
            
            var clientNonce = "clientNonce_example";  // string |  (optional) 
            
            
            
            
            var code = "code_example";  // string |  (optional) 
            
            
            
            
            var state = "state_example";  // string |  (optional) 
            
            
            

            try
            {
                
                // Callback endpoint to complete an OIDC login.
                

                apiInstance.JwtOidcCallback(string jwtMountPath, string clientNonce = default(string), string code = default(string), string state = default(string), TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.JwtOidcCallback: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jwtMountPath** | **string**| Path that the backend was mounted at | [default to &quot;jwt&quot;]
 **clientNonce** | **string**|  | [optional] 
 **code** | **string**|  | [optional] 
 **state** | **string**|  | [optional] 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jwtoidccallbackformpost"></a>
# **JwtOidcCallbackFormPost**

> void JwtOidcCallbackFormPost (string jwtMountPath, JwtOidcCallbackFormPostRequest jwtOidcCallbackFormPostRequest, TimeSpan? wrapTTL = null)

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
    public class JwtOidcCallbackFormPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var jwtMountPath = "\"jwt\"";  // string | Path that the backend was mounted at (default to "jwt")
            
            
            
            
            
            var jwtOidcCallbackFormPostRequest = new JwtOidcCallbackFormPostRequest(); // JwtOidcCallbackFormPostRequest | 
            
            

            try
            {
                
                // Callback endpoint to handle form_posts.
                

                apiInstance.JwtOidcCallbackFormPost(string jwtMountPath, JwtOidcCallbackFormPostRequest jwtOidcCallbackFormPostRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.JwtOidcCallbackFormPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jwtMountPath** | **string**| Path that the backend was mounted at | [default to &quot;jwt&quot;]
 **jwtOidcCallbackFormPostRequest** | [**JwtOidcCallbackFormPostRequest**](JwtOidcCallbackFormPostRequest.md)|  | 


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

<a name="jwtoidcrequestauthorizationurl"></a>
# **JwtOidcRequestAuthorizationUrl**

> void JwtOidcRequestAuthorizationUrl (string jwtMountPath, JwtOidcRequestAuthorizationUrlRequest jwtOidcRequestAuthorizationUrlRequest, TimeSpan? wrapTTL = null)

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
    public class JwtOidcRequestAuthorizationUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var jwtMountPath = "\"jwt\"";  // string | Path that the backend was mounted at (default to "jwt")
            
            
            
            
            
            var jwtOidcRequestAuthorizationUrlRequest = new JwtOidcRequestAuthorizationUrlRequest(); // JwtOidcRequestAuthorizationUrlRequest | 
            
            

            try
            {
                
                // Request an authorization URL to start an OIDC login flow.
                

                apiInstance.JwtOidcRequestAuthorizationUrl(string jwtMountPath, JwtOidcRequestAuthorizationUrlRequest jwtOidcRequestAuthorizationUrlRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.JwtOidcRequestAuthorizationUrl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jwtMountPath** | **string**| Path that the backend was mounted at | [default to &quot;jwt&quot;]
 **jwtOidcRequestAuthorizationUrlRequest** | [**JwtOidcRequestAuthorizationUrlRequest**](JwtOidcRequestAuthorizationUrlRequest.md)|  | 


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

<a name="jwtreadconfiguration"></a>
# **JwtReadConfiguration**

> void JwtReadConfiguration (string jwtMountPath, TimeSpan? wrapTTL = null)

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
    public class JwtReadConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var jwtMountPath = "\"jwt\"";  // string | Path that the backend was mounted at (default to "jwt")
            
            
            

            try
            {
                
                // Read the current JWT authentication backend configuration.
                

                apiInstance.JwtReadConfiguration(string jwtMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.JwtReadConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jwtMountPath** | **string**| Path that the backend was mounted at | [default to &quot;jwt&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jwtreadrole"></a>
# **JwtReadRole**

> void JwtReadRole (string name, string jwtMountPath, TimeSpan? wrapTTL = null)

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
    public class JwtReadRoleExample
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
            
            
            
            
            var jwtMountPath = "\"jwt\"";  // string | Path that the backend was mounted at (default to "jwt")
            
            
            

            try
            {
                
                // Read an existing role.
                

                apiInstance.JwtReadRole(string name, string jwtMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.JwtReadRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the role. | 
 **jwtMountPath** | **string**| Path that the backend was mounted at | [default to &quot;jwt&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jwtwriterole"></a>
# **JwtWriteRole**

> void JwtWriteRole (string name, string jwtMountPath, JwtWriteRoleRequest jwtWriteRoleRequest, TimeSpan? wrapTTL = null)

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
    public class JwtWriteRoleExample
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
            
            
            
            
            var jwtMountPath = "\"jwt\"";  // string | Path that the backend was mounted at (default to "jwt")
            
            
            
            
            
            var jwtWriteRoleRequest = new JwtWriteRoleRequest(); // JwtWriteRoleRequest | 
            
            

            try
            {
                
                // Register an role with the backend.
                

                apiInstance.JwtWriteRole(string name, string jwtMountPath, JwtWriteRoleRequest jwtWriteRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.JwtWriteRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the role. | 
 **jwtMountPath** | **string**| Path that the backend was mounted at | [default to &quot;jwt&quot;]
 **jwtWriteRoleRequest** | [**JwtWriteRoleRequest**](JwtWriteRoleRequest.md)|  | 


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

<a name="kerberosconfigure"></a>
# **KerberosConfigure**

> void KerberosConfigure (string kerberosMountPath, KerberosConfigureRequest kerberosConfigureRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KerberosConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var kerberosMountPath = "\"kerberos\"";  // string | Path that the backend was mounted at (default to "kerberos")
            
            
            
            
            
            var kerberosConfigureRequest = new KerberosConfigureRequest(); // KerberosConfigureRequest | 
            
            

            try
            {
                

                apiInstance.KerberosConfigure(string kerberosMountPath, KerberosConfigureRequest kerberosConfigureRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.KerberosConfigure: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kerberosMountPath** | **string**| Path that the backend was mounted at | [default to &quot;kerberos&quot;]
 **kerberosConfigureRequest** | [**KerberosConfigureRequest**](KerberosConfigureRequest.md)|  | 


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

<a name="kerberosconfigureldap"></a>
# **KerberosConfigureLdap**

> void KerberosConfigureLdap (string kerberosMountPath, KerberosConfigureLdapRequest kerberosConfigureLdapRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KerberosConfigureLdapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var kerberosMountPath = "\"kerberos\"";  // string | Path that the backend was mounted at (default to "kerberos")
            
            
            
            
            
            var kerberosConfigureLdapRequest = new KerberosConfigureLdapRequest(); // KerberosConfigureLdapRequest | 
            
            

            try
            {
                

                apiInstance.KerberosConfigureLdap(string kerberosMountPath, KerberosConfigureLdapRequest kerberosConfigureLdapRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.KerberosConfigureLdap: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kerberosMountPath** | **string**| Path that the backend was mounted at | [default to &quot;kerberos&quot;]
 **kerberosConfigureLdapRequest** | [**KerberosConfigureLdapRequest**](KerberosConfigureLdapRequest.md)|  | 


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

<a name="kerberosdeletegroup"></a>
# **KerberosDeleteGroup**

> void KerberosDeleteGroup (string name, string kerberosMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KerberosDeleteGroupExample
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
            
            
            
            
            var kerberosMountPath = "\"kerberos\"";  // string | Path that the backend was mounted at (default to "kerberos")
            
            
            

            try
            {
                

                apiInstance.KerberosDeleteGroup(string name, string kerberosMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.KerberosDeleteGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the LDAP group. | 
 **kerberosMountPath** | **string**| Path that the backend was mounted at | [default to &quot;kerberos&quot;]


### Return type

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

<a name="kerberoslistgroups"></a>
# **KerberosListGroups**

> StandardListResponse KerberosListGroups (string kerberosMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KerberosListGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var kerberosMountPath = "\"kerberos\"";  // string | Path that the backend was mounted at (default to "kerberos")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                StandardListResponse result = apiInstance.KerberosListGroups(string kerberosMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.KerberosListGroups: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kerberosMountPath** | **string**| Path that the backend was mounted at | [default to &quot;kerberos&quot;]
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

<a name="kerberoslogin"></a>
# **KerberosLogin**

> void KerberosLogin (string kerberosMountPath, KerberosLoginRequest kerberosLoginRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KerberosLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var kerberosMountPath = "\"kerberos\"";  // string | Path that the backend was mounted at (default to "kerberos")
            
            
            
            
            
            var kerberosLoginRequest = new KerberosLoginRequest(); // KerberosLoginRequest | 
            
            

            try
            {
                

                apiInstance.KerberosLogin(string kerberosMountPath, KerberosLoginRequest kerberosLoginRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.KerberosLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kerberosMountPath** | **string**| Path that the backend was mounted at | [default to &quot;kerberos&quot;]
 **kerberosLoginRequest** | [**KerberosLoginRequest**](KerberosLoginRequest.md)|  | 


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

<a name="kerberosreadconfiguration"></a>
# **KerberosReadConfiguration**

> void KerberosReadConfiguration (string kerberosMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KerberosReadConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var kerberosMountPath = "\"kerberos\"";  // string | Path that the backend was mounted at (default to "kerberos")
            
            
            

            try
            {
                

                apiInstance.KerberosReadConfiguration(string kerberosMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.KerberosReadConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kerberosMountPath** | **string**| Path that the backend was mounted at | [default to &quot;kerberos&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="kerberosreadgroup"></a>
# **KerberosReadGroup**

> void KerberosReadGroup (string name, string kerberosMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KerberosReadGroupExample
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
            
            
            
            
            var kerberosMountPath = "\"kerberos\"";  // string | Path that the backend was mounted at (default to "kerberos")
            
            
            

            try
            {
                

                apiInstance.KerberosReadGroup(string name, string kerberosMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.KerberosReadGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the LDAP group. | 
 **kerberosMountPath** | **string**| Path that the backend was mounted at | [default to &quot;kerberos&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="kerberosreadldapconfiguration"></a>
# **KerberosReadLdapConfiguration**

> void KerberosReadLdapConfiguration (string kerberosMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KerberosReadLdapConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var kerberosMountPath = "\"kerberos\"";  // string | Path that the backend was mounted at (default to "kerberos")
            
            
            

            try
            {
                

                apiInstance.KerberosReadLdapConfiguration(string kerberosMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.KerberosReadLdapConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kerberosMountPath** | **string**| Path that the backend was mounted at | [default to &quot;kerberos&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="kerberoswritegroup"></a>
# **KerberosWriteGroup**

> void KerberosWriteGroup (string name, string kerberosMountPath, KerberosWriteGroupRequest kerberosWriteGroupRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KerberosWriteGroupExample
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
            
            
            
            
            var kerberosMountPath = "\"kerberos\"";  // string | Path that the backend was mounted at (default to "kerberos")
            
            
            
            
            
            var kerberosWriteGroupRequest = new KerberosWriteGroupRequest(); // KerberosWriteGroupRequest | 
            
            

            try
            {
                

                apiInstance.KerberosWriteGroup(string name, string kerberosMountPath, KerberosWriteGroupRequest kerberosWriteGroupRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.KerberosWriteGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the LDAP group. | 
 **kerberosMountPath** | **string**| Path that the backend was mounted at | [default to &quot;kerberos&quot;]
 **kerberosWriteGroupRequest** | [**KerberosWriteGroupRequest**](KerberosWriteGroupRequest.md)|  | 


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

<a name="kubernetesconfigureauth"></a>
# **KubernetesConfigureAuth**

> void KubernetesConfigureAuth (string kubernetesMountPath, KubernetesConfigureAuthRequest kubernetesConfigureAuthRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KubernetesConfigureAuthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path that the backend was mounted at (default to "kubernetes")
            
            
            
            
            
            var kubernetesConfigureAuthRequest = new KubernetesConfigureAuthRequest(); // KubernetesConfigureAuthRequest | 
            
            

            try
            {
                

                apiInstance.KubernetesConfigureAuth(string kubernetesMountPath, KubernetesConfigureAuthRequest kubernetesConfigureAuthRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.KubernetesConfigureAuth: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kubernetesMountPath** | **string**| Path that the backend was mounted at | [default to &quot;kubernetes&quot;]
 **kubernetesConfigureAuthRequest** | [**KubernetesConfigureAuthRequest**](KubernetesConfigureAuthRequest.md)|  | 


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

<a name="kubernetesdeleteauthrole"></a>
# **KubernetesDeleteAuthRole**

> void KubernetesDeleteAuthRole (string name, string kubernetesMountPath, TimeSpan? wrapTTL = null)

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
    public class KubernetesDeleteAuthRoleExample
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
            
            
            
            
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path that the backend was mounted at (default to "kubernetes")
            
            
            

            try
            {
                
                // Register an role with the backend.
                

                apiInstance.KubernetesDeleteAuthRole(string name, string kubernetesMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.KubernetesDeleteAuthRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the role. | 
 **kubernetesMountPath** | **string**| Path that the backend was mounted at | [default to &quot;kubernetes&quot;]


### Return type

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

<a name="kuberneteslistauthroles"></a>
# **KubernetesListAuthRoles**

> StandardListResponse KubernetesListAuthRoles (string kubernetesMountPath, TimeSpan? wrapTTL = null)

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
    public class KubernetesListAuthRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path that the backend was mounted at (default to "kubernetes")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // Lists all the roles registered with the backend.
                

                StandardListResponse result = apiInstance.KubernetesListAuthRoles(string kubernetesMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.KubernetesListAuthRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kubernetesMountPath** | **string**| Path that the backend was mounted at | [default to &quot;kubernetes&quot;]
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

<a name="kuberneteslogin"></a>
# **KubernetesLogin**

> void KubernetesLogin (string kubernetesMountPath, KubernetesLoginRequest kubernetesLoginRequest, TimeSpan? wrapTTL = null)

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
    public class KubernetesLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path that the backend was mounted at (default to "kubernetes")
            
            
            
            
            
            var kubernetesLoginRequest = new KubernetesLoginRequest(); // KubernetesLoginRequest | 
            
            

            try
            {
                
                // Authenticates Kubernetes service accounts with Vault.
                

                apiInstance.KubernetesLogin(string kubernetesMountPath, KubernetesLoginRequest kubernetesLoginRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.KubernetesLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kubernetesMountPath** | **string**| Path that the backend was mounted at | [default to &quot;kubernetes&quot;]
 **kubernetesLoginRequest** | [**KubernetesLoginRequest**](KubernetesLoginRequest.md)|  | 


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

<a name="kubernetesreadauthconfiguration"></a>
# **KubernetesReadAuthConfiguration**

> void KubernetesReadAuthConfiguration (string kubernetesMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KubernetesReadAuthConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path that the backend was mounted at (default to "kubernetes")
            
            
            

            try
            {
                

                apiInstance.KubernetesReadAuthConfiguration(string kubernetesMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.KubernetesReadAuthConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kubernetesMountPath** | **string**| Path that the backend was mounted at | [default to &quot;kubernetes&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="kubernetesreadauthrole"></a>
# **KubernetesReadAuthRole**

> void KubernetesReadAuthRole (string name, string kubernetesMountPath, TimeSpan? wrapTTL = null)

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
    public class KubernetesReadAuthRoleExample
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
            
            
            
            
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path that the backend was mounted at (default to "kubernetes")
            
            
            

            try
            {
                
                // Register an role with the backend.
                

                apiInstance.KubernetesReadAuthRole(string name, string kubernetesMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.KubernetesReadAuthRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the role. | 
 **kubernetesMountPath** | **string**| Path that the backend was mounted at | [default to &quot;kubernetes&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="kuberneteswriteauthrole"></a>
# **KubernetesWriteAuthRole**

> void KubernetesWriteAuthRole (string name, string kubernetesMountPath, KubernetesWriteAuthRoleRequest kubernetesWriteAuthRoleRequest, TimeSpan? wrapTTL = null)

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
    public class KubernetesWriteAuthRoleExample
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
            
            
            
            
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path that the backend was mounted at (default to "kubernetes")
            
            
            
            
            
            var kubernetesWriteAuthRoleRequest = new KubernetesWriteAuthRoleRequest(); // KubernetesWriteAuthRoleRequest | 
            
            

            try
            {
                
                // Register an role with the backend.
                

                apiInstance.KubernetesWriteAuthRole(string name, string kubernetesMountPath, KubernetesWriteAuthRoleRequest kubernetesWriteAuthRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.KubernetesWriteAuthRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the role. | 
 **kubernetesMountPath** | **string**| Path that the backend was mounted at | [default to &quot;kubernetes&quot;]
 **kubernetesWriteAuthRoleRequest** | [**KubernetesWriteAuthRoleRequest**](KubernetesWriteAuthRoleRequest.md)|  | 


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

<a name="ldapconfigureauth"></a>
# **LdapConfigureAuth**

> void LdapConfigureAuth (string ldapMountPath, LdapConfigureAuthRequest ldapConfigureAuthRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LdapConfigureAuthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            
            
            
            var ldapConfigureAuthRequest = new LdapConfigureAuthRequest(); // LdapConfigureAuthRequest | 
            
            

            try
            {
                

                apiInstance.LdapConfigureAuth(string ldapMountPath, LdapConfigureAuthRequest ldapConfigureAuthRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.LdapConfigureAuth: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ldapMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ldap&quot;]
 **ldapConfigureAuthRequest** | [**LdapConfigureAuthRequest**](LdapConfigureAuthRequest.md)|  | 


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

<a name="ldapdeletegroup"></a>
# **LdapDeleteGroup**

> void LdapDeleteGroup (string name, string ldapMountPath, TimeSpan? wrapTTL = null)

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
    public class LdapDeleteGroupExample
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
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            

            try
            {
                
                // Manage additional groups for users allowed to authenticate.
                

                apiInstance.LdapDeleteGroup(string name, string ldapMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.LdapDeleteGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the LDAP group. | 
 **ldapMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ldap&quot;]


### Return type

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

<a name="ldapdeleteuser"></a>
# **LdapDeleteUser**

> void LdapDeleteUser (string name, string ldapMountPath, TimeSpan? wrapTTL = null)

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
    public class LdapDeleteUserExample
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
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            

            try
            {
                
                // Manage users allowed to authenticate.
                

                apiInstance.LdapDeleteUser(string name, string ldapMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.LdapDeleteUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the LDAP user. | 
 **ldapMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ldap&quot;]


### Return type

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

<a name="ldaplistgroups"></a>
# **LdapListGroups**

> StandardListResponse LdapListGroups (string ldapMountPath, TimeSpan? wrapTTL = null)

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
    public class LdapListGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // Manage additional groups for users allowed to authenticate.
                

                StandardListResponse result = apiInstance.LdapListGroups(string ldapMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.LdapListGroups: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ldapMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ldap&quot;]
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

<a name="ldaplistusers"></a>
# **LdapListUsers**

> StandardListResponse LdapListUsers (string ldapMountPath, TimeSpan? wrapTTL = null)

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
    public class LdapListUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // Manage users allowed to authenticate.
                

                StandardListResponse result = apiInstance.LdapListUsers(string ldapMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.LdapListUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ldapMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ldap&quot;]
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

<a name="ldaplogin"></a>
# **LdapLogin**

> void LdapLogin (string username, string ldapMountPath, LdapLoginRequest ldapLoginRequest, TimeSpan? wrapTTL = null)

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
    public class LdapLoginExample
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
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            
            
            
            var ldapLoginRequest = new LdapLoginRequest(); // LdapLoginRequest | 
            
            

            try
            {
                
                // Log in with a username and password.
                

                apiInstance.LdapLogin(string username, string ldapMountPath, LdapLoginRequest ldapLoginRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.LdapLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| DN (distinguished name) to be used for login. | 
 **ldapMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ldap&quot;]
 **ldapLoginRequest** | [**LdapLoginRequest**](LdapLoginRequest.md)|  | 


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

<a name="ldapreadauthconfiguration"></a>
# **LdapReadAuthConfiguration**

> void LdapReadAuthConfiguration (string ldapMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LdapReadAuthConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            

            try
            {
                

                apiInstance.LdapReadAuthConfiguration(string ldapMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.LdapReadAuthConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ldapMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ldap&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ldapreadgroup"></a>
# **LdapReadGroup**

> void LdapReadGroup (string name, string ldapMountPath, TimeSpan? wrapTTL = null)

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
    public class LdapReadGroupExample
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
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            

            try
            {
                
                // Manage additional groups for users allowed to authenticate.
                

                apiInstance.LdapReadGroup(string name, string ldapMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.LdapReadGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the LDAP group. | 
 **ldapMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ldap&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ldapreaduser"></a>
# **LdapReadUser**

> void LdapReadUser (string name, string ldapMountPath, TimeSpan? wrapTTL = null)

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
    public class LdapReadUserExample
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
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            

            try
            {
                
                // Manage users allowed to authenticate.
                

                apiInstance.LdapReadUser(string name, string ldapMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.LdapReadUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the LDAP user. | 
 **ldapMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ldap&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ldapwritegroup"></a>
# **LdapWriteGroup**

> void LdapWriteGroup (string name, string ldapMountPath, LdapWriteGroupRequest ldapWriteGroupRequest, TimeSpan? wrapTTL = null)

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
    public class LdapWriteGroupExample
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
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            
            
            
            var ldapWriteGroupRequest = new LdapWriteGroupRequest(); // LdapWriteGroupRequest | 
            
            

            try
            {
                
                // Manage additional groups for users allowed to authenticate.
                

                apiInstance.LdapWriteGroup(string name, string ldapMountPath, LdapWriteGroupRequest ldapWriteGroupRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.LdapWriteGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the LDAP group. | 
 **ldapMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ldap&quot;]
 **ldapWriteGroupRequest** | [**LdapWriteGroupRequest**](LdapWriteGroupRequest.md)|  | 


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

<a name="ldapwriteuser"></a>
# **LdapWriteUser**

> void LdapWriteUser (string name, string ldapMountPath, LdapWriteUserRequest ldapWriteUserRequest, TimeSpan? wrapTTL = null)

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
    public class LdapWriteUserExample
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
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            
            
            
            var ldapWriteUserRequest = new LdapWriteUserRequest(); // LdapWriteUserRequest | 
            
            

            try
            {
                
                // Manage users allowed to authenticate.
                

                apiInstance.LdapWriteUser(string name, string ldapMountPath, LdapWriteUserRequest ldapWriteUserRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.LdapWriteUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the LDAP user. | 
 **ldapMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ldap&quot;]
 **ldapWriteUserRequest** | [**LdapWriteUserRequest**](LdapWriteUserRequest.md)|  | 


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

<a name="ociconfigure"></a>
# **OciConfigure**

> void OciConfigure (string ociMountPath, OciConfigureRequest ociConfigureRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OciConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var ociMountPath = "\"oci\"";  // string | Path that the backend was mounted at (default to "oci")
            
            
            
            
            
            var ociConfigureRequest = new OciConfigureRequest(); // OciConfigureRequest | 
            
            

            try
            {
                

                apiInstance.OciConfigure(string ociMountPath, OciConfigureRequest ociConfigureRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.OciConfigure: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ociMountPath** | **string**| Path that the backend was mounted at | [default to &quot;oci&quot;]
 **ociConfigureRequest** | [**OciConfigureRequest**](OciConfigureRequest.md)|  | 


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

<a name="ocideleteconfiguration"></a>
# **OciDeleteConfiguration**

> void OciDeleteConfiguration (string ociMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OciDeleteConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var ociMountPath = "\"oci\"";  // string | Path that the backend was mounted at (default to "oci")
            
            
            

            try
            {
                

                apiInstance.OciDeleteConfiguration(string ociMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.OciDeleteConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ociMountPath** | **string**| Path that the backend was mounted at | [default to &quot;oci&quot;]


### Return type

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

<a name="ocideleterole"></a>
# **OciDeleteRole**

> void OciDeleteRole (string role, string ociMountPath, TimeSpan? wrapTTL = null)

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
    public class OciDeleteRoleExample
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
            
            
            
            
            var ociMountPath = "\"oci\"";  // string | Path that the backend was mounted at (default to "oci")
            
            
            

            try
            {
                
                // Create a role and associate policies to it.
                

                apiInstance.OciDeleteRole(string role, string ociMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.OciDeleteRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| Name of the role. | 
 **ociMountPath** | **string**| Path that the backend was mounted at | [default to &quot;oci&quot;]


### Return type

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

<a name="ocilistroles"></a>
# **OciListRoles**

> StandardListResponse OciListRoles (string ociMountPath, TimeSpan? wrapTTL = null)

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
    public class OciListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var ociMountPath = "\"oci\"";  // string | Path that the backend was mounted at (default to "oci")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // Lists all the roles that are registered with Vault.
                

                StandardListResponse result = apiInstance.OciListRoles(string ociMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.OciListRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ociMountPath** | **string**| Path that the backend was mounted at | [default to &quot;oci&quot;]
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

<a name="ocilogin"></a>
# **OciLogin**

> void OciLogin (string role, string ociMountPath, OciLoginRequest ociLoginRequest, TimeSpan? wrapTTL = null)

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
    public class OciLoginExample
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
            
            
            
            
            var ociMountPath = "\"oci\"";  // string | Path that the backend was mounted at (default to "oci")
            
            
            
            
            
            var ociLoginRequest = new OciLoginRequest(); // OciLoginRequest | 
            
            

            try
            {
                
                // Authenticates to Vault using OCI credentials
                

                apiInstance.OciLogin(string role, string ociMountPath, OciLoginRequest ociLoginRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.OciLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| Name of the role. | 
 **ociMountPath** | **string**| Path that the backend was mounted at | [default to &quot;oci&quot;]
 **ociLoginRequest** | [**OciLoginRequest**](OciLoginRequest.md)|  | 


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

<a name="ocireadconfiguration"></a>
# **OciReadConfiguration**

> void OciReadConfiguration (string ociMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OciReadConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var ociMountPath = "\"oci\"";  // string | Path that the backend was mounted at (default to "oci")
            
            
            

            try
            {
                

                apiInstance.OciReadConfiguration(string ociMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.OciReadConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ociMountPath** | **string**| Path that the backend was mounted at | [default to &quot;oci&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ocireadrole"></a>
# **OciReadRole**

> void OciReadRole (string role, string ociMountPath, TimeSpan? wrapTTL = null)

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
    public class OciReadRoleExample
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
            
            
            
            
            var ociMountPath = "\"oci\"";  // string | Path that the backend was mounted at (default to "oci")
            
            
            

            try
            {
                
                // Create a role and associate policies to it.
                

                apiInstance.OciReadRole(string role, string ociMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.OciReadRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| Name of the role. | 
 **ociMountPath** | **string**| Path that the backend was mounted at | [default to &quot;oci&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ociwriterole"></a>
# **OciWriteRole**

> void OciWriteRole (string role, string ociMountPath, OciWriteRoleRequest ociWriteRoleRequest, TimeSpan? wrapTTL = null)

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
    public class OciWriteRoleExample
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
            
            
            
            
            var ociMountPath = "\"oci\"";  // string | Path that the backend was mounted at (default to "oci")
            
            
            
            
            
            var ociWriteRoleRequest = new OciWriteRoleRequest(); // OciWriteRoleRequest | 
            
            

            try
            {
                
                // Create a role and associate policies to it.
                

                apiInstance.OciWriteRole(string role, string ociMountPath, OciWriteRoleRequest ociWriteRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.OciWriteRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| Name of the role. | 
 **ociMountPath** | **string**| Path that the backend was mounted at | [default to &quot;oci&quot;]
 **ociWriteRoleRequest** | [**OciWriteRoleRequest**](OciWriteRoleRequest.md)|  | 


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

<a name="oktaconfigure"></a>
# **OktaConfigure**

> void OktaConfigure (string oktaMountPath, OktaConfigureRequest oktaConfigureRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OktaConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var oktaMountPath = "\"okta\"";  // string | Path that the backend was mounted at (default to "okta")
            
            
            
            
            
            var oktaConfigureRequest = new OktaConfigureRequest(); // OktaConfigureRequest | 
            
            

            try
            {
                

                apiInstance.OktaConfigure(string oktaMountPath, OktaConfigureRequest oktaConfigureRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.OktaConfigure: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oktaMountPath** | **string**| Path that the backend was mounted at | [default to &quot;okta&quot;]
 **oktaConfigureRequest** | [**OktaConfigureRequest**](OktaConfigureRequest.md)|  | 


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

<a name="oktadeletegroup"></a>
# **OktaDeleteGroup**

> void OktaDeleteGroup (string name, string oktaMountPath, TimeSpan? wrapTTL = null)

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
    public class OktaDeleteGroupExample
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
            
            
            
            
            var oktaMountPath = "\"okta\"";  // string | Path that the backend was mounted at (default to "okta")
            
            
            

            try
            {
                
                // Manage users allowed to authenticate.
                

                apiInstance.OktaDeleteGroup(string name, string oktaMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.OktaDeleteGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the Okta group. | 
 **oktaMountPath** | **string**| Path that the backend was mounted at | [default to &quot;okta&quot;]


### Return type

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

<a name="oktadeleteuser"></a>
# **OktaDeleteUser**

> void OktaDeleteUser (string name, string oktaMountPath, TimeSpan? wrapTTL = null)

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
    public class OktaDeleteUserExample
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
            
            
            
            
            var oktaMountPath = "\"okta\"";  // string | Path that the backend was mounted at (default to "okta")
            
            
            

            try
            {
                
                // Manage additional groups for users allowed to authenticate.
                

                apiInstance.OktaDeleteUser(string name, string oktaMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.OktaDeleteUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the user. | 
 **oktaMountPath** | **string**| Path that the backend was mounted at | [default to &quot;okta&quot;]


### Return type

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

<a name="oktalistgroups"></a>
# **OktaListGroups**

> StandardListResponse OktaListGroups (string oktaMountPath, TimeSpan? wrapTTL = null)

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
    public class OktaListGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var oktaMountPath = "\"okta\"";  // string | Path that the backend was mounted at (default to "okta")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // Manage users allowed to authenticate.
                

                StandardListResponse result = apiInstance.OktaListGroups(string oktaMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.OktaListGroups: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oktaMountPath** | **string**| Path that the backend was mounted at | [default to &quot;okta&quot;]
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

<a name="oktalistusers"></a>
# **OktaListUsers**

> StandardListResponse OktaListUsers (string oktaMountPath, TimeSpan? wrapTTL = null)

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
    public class OktaListUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var oktaMountPath = "\"okta\"";  // string | Path that the backend was mounted at (default to "okta")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // Manage additional groups for users allowed to authenticate.
                

                StandardListResponse result = apiInstance.OktaListUsers(string oktaMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.OktaListUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oktaMountPath** | **string**| Path that the backend was mounted at | [default to &quot;okta&quot;]
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

<a name="oktalogin"></a>
# **OktaLogin**

> void OktaLogin (string username, string oktaMountPath, OktaLoginRequest oktaLoginRequest, TimeSpan? wrapTTL = null)

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
    public class OktaLoginExample
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
            
            
            
            
            var oktaMountPath = "\"okta\"";  // string | Path that the backend was mounted at (default to "okta")
            
            
            
            
            
            var oktaLoginRequest = new OktaLoginRequest(); // OktaLoginRequest | 
            
            

            try
            {
                
                // Log in with a username and password.
                

                apiInstance.OktaLogin(string username, string oktaMountPath, OktaLoginRequest oktaLoginRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.OktaLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| Username to be used for login. | 
 **oktaMountPath** | **string**| Path that the backend was mounted at | [default to &quot;okta&quot;]
 **oktaLoginRequest** | [**OktaLoginRequest**](OktaLoginRequest.md)|  | 


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

<a name="oktareadconfiguration"></a>
# **OktaReadConfiguration**

> void OktaReadConfiguration (string oktaMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OktaReadConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var oktaMountPath = "\"okta\"";  // string | Path that the backend was mounted at (default to "okta")
            
            
            

            try
            {
                

                apiInstance.OktaReadConfiguration(string oktaMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.OktaReadConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oktaMountPath** | **string**| Path that the backend was mounted at | [default to &quot;okta&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oktareadgroup"></a>
# **OktaReadGroup**

> void OktaReadGroup (string name, string oktaMountPath, TimeSpan? wrapTTL = null)

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
    public class OktaReadGroupExample
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
            
            
            
            
            var oktaMountPath = "\"okta\"";  // string | Path that the backend was mounted at (default to "okta")
            
            
            

            try
            {
                
                // Manage users allowed to authenticate.
                

                apiInstance.OktaReadGroup(string name, string oktaMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.OktaReadGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the Okta group. | 
 **oktaMountPath** | **string**| Path that the backend was mounted at | [default to &quot;okta&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oktareaduser"></a>
# **OktaReadUser**

> void OktaReadUser (string name, string oktaMountPath, TimeSpan? wrapTTL = null)

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
    public class OktaReadUserExample
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
            
            
            
            
            var oktaMountPath = "\"okta\"";  // string | Path that the backend was mounted at (default to "okta")
            
            
            

            try
            {
                
                // Manage additional groups for users allowed to authenticate.
                

                apiInstance.OktaReadUser(string name, string oktaMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.OktaReadUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the user. | 
 **oktaMountPath** | **string**| Path that the backend was mounted at | [default to &quot;okta&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oktaverify"></a>
# **OktaVerify**

> void OktaVerify (string nonce, string oktaMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OktaVerifyExample
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
            
            
            
            
            var oktaMountPath = "\"okta\"";  // string | Path that the backend was mounted at (default to "okta")
            
            
            

            try
            {
                

                apiInstance.OktaVerify(string nonce, string oktaMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.OktaVerify: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nonce** | **string**| Nonce provided during a login request to retrieve the number verification challenge for the matching request. | 
 **oktaMountPath** | **string**| Path that the backend was mounted at | [default to &quot;okta&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oktawritegroup"></a>
# **OktaWriteGroup**

> void OktaWriteGroup (string name, string oktaMountPath, OktaWriteGroupRequest oktaWriteGroupRequest, TimeSpan? wrapTTL = null)

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
    public class OktaWriteGroupExample
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
            
            
            
            
            var oktaMountPath = "\"okta\"";  // string | Path that the backend was mounted at (default to "okta")
            
            
            
            
            
            var oktaWriteGroupRequest = new OktaWriteGroupRequest(); // OktaWriteGroupRequest | 
            
            

            try
            {
                
                // Manage users allowed to authenticate.
                

                apiInstance.OktaWriteGroup(string name, string oktaMountPath, OktaWriteGroupRequest oktaWriteGroupRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.OktaWriteGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the Okta group. | 
 **oktaMountPath** | **string**| Path that the backend was mounted at | [default to &quot;okta&quot;]
 **oktaWriteGroupRequest** | [**OktaWriteGroupRequest**](OktaWriteGroupRequest.md)|  | 


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

<a name="oktawriteuser"></a>
# **OktaWriteUser**

> void OktaWriteUser (string name, string oktaMountPath, OktaWriteUserRequest oktaWriteUserRequest, TimeSpan? wrapTTL = null)

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
    public class OktaWriteUserExample
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
            
            
            
            
            var oktaMountPath = "\"okta\"";  // string | Path that the backend was mounted at (default to "okta")
            
            
            
            
            
            var oktaWriteUserRequest = new OktaWriteUserRequest(); // OktaWriteUserRequest | 
            
            

            try
            {
                
                // Manage additional groups for users allowed to authenticate.
                

                apiInstance.OktaWriteUser(string name, string oktaMountPath, OktaWriteUserRequest oktaWriteUserRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.OktaWriteUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the user. | 
 **oktaMountPath** | **string**| Path that the backend was mounted at | [default to &quot;okta&quot;]
 **oktaWriteUserRequest** | [**OktaWriteUserRequest**](OktaWriteUserRequest.md)|  | 


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

<a name="radiusconfigure"></a>
# **RadiusConfigure**

> void RadiusConfigure (string radiusMountPath, RadiusConfigureRequest radiusConfigureRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class RadiusConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var radiusMountPath = "\"radius\"";  // string | Path that the backend was mounted at (default to "radius")
            
            
            
            
            
            var radiusConfigureRequest = new RadiusConfigureRequest(); // RadiusConfigureRequest | 
            
            

            try
            {
                

                apiInstance.RadiusConfigure(string radiusMountPath, RadiusConfigureRequest radiusConfigureRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.RadiusConfigure: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **radiusMountPath** | **string**| Path that the backend was mounted at | [default to &quot;radius&quot;]
 **radiusConfigureRequest** | [**RadiusConfigureRequest**](RadiusConfigureRequest.md)|  | 


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

<a name="radiusdeleteuser"></a>
# **RadiusDeleteUser**

> void RadiusDeleteUser (string name, string radiusMountPath, TimeSpan? wrapTTL = null)

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
    public class RadiusDeleteUserExample
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
            
            
            
            
            var radiusMountPath = "\"radius\"";  // string | Path that the backend was mounted at (default to "radius")
            
            
            

            try
            {
                
                // Manage users allowed to authenticate.
                

                apiInstance.RadiusDeleteUser(string name, string radiusMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.RadiusDeleteUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the RADIUS user. | 
 **radiusMountPath** | **string**| Path that the backend was mounted at | [default to &quot;radius&quot;]


### Return type

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

<a name="radiuslistusers"></a>
# **RadiusListUsers**

> StandardListResponse RadiusListUsers (string radiusMountPath, TimeSpan? wrapTTL = null)

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
    public class RadiusListUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var radiusMountPath = "\"radius\"";  // string | Path that the backend was mounted at (default to "radius")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // Manage users allowed to authenticate.
                

                StandardListResponse result = apiInstance.RadiusListUsers(string radiusMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.RadiusListUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **radiusMountPath** | **string**| Path that the backend was mounted at | [default to &quot;radius&quot;]
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

<a name="radiuslogin"></a>
# **RadiusLogin**

> void RadiusLogin (string radiusMountPath, RadiusLoginRequest radiusLoginRequest, TimeSpan? wrapTTL = null)

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
    public class RadiusLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var radiusMountPath = "\"radius\"";  // string | Path that the backend was mounted at (default to "radius")
            
            
            
            
            
            var radiusLoginRequest = new RadiusLoginRequest(); // RadiusLoginRequest | 
            
            

            try
            {
                
                // Log in with a username and password.
                

                apiInstance.RadiusLogin(string radiusMountPath, RadiusLoginRequest radiusLoginRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.RadiusLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **radiusMountPath** | **string**| Path that the backend was mounted at | [default to &quot;radius&quot;]
 **radiusLoginRequest** | [**RadiusLoginRequest**](RadiusLoginRequest.md)|  | 


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

<a name="radiusloginwithusername"></a>
# **RadiusLoginWithUsername**

> void RadiusLoginWithUsername (string urlusername, string radiusMountPath, RadiusLoginWithUsernameRequest radiusLoginWithUsernameRequest, TimeSpan? wrapTTL = null)

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
    public class RadiusLoginWithUsernameExample
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
            
            
            
            
            var radiusMountPath = "\"radius\"";  // string | Path that the backend was mounted at (default to "radius")
            
            
            
            
            
            var radiusLoginWithUsernameRequest = new RadiusLoginWithUsernameRequest(); // RadiusLoginWithUsernameRequest | 
            
            

            try
            {
                
                // Log in with a username and password.
                

                apiInstance.RadiusLoginWithUsername(string urlusername, string radiusMountPath, RadiusLoginWithUsernameRequest radiusLoginWithUsernameRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.RadiusLoginWithUsername: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **urlusername** | **string**| Username to be used for login. (URL parameter) | 
 **radiusMountPath** | **string**| Path that the backend was mounted at | [default to &quot;radius&quot;]
 **radiusLoginWithUsernameRequest** | [**RadiusLoginWithUsernameRequest**](RadiusLoginWithUsernameRequest.md)|  | 


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

<a name="radiusreadconfiguration"></a>
# **RadiusReadConfiguration**

> void RadiusReadConfiguration (string radiusMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class RadiusReadConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var radiusMountPath = "\"radius\"";  // string | Path that the backend was mounted at (default to "radius")
            
            
            

            try
            {
                

                apiInstance.RadiusReadConfiguration(string radiusMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.RadiusReadConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **radiusMountPath** | **string**| Path that the backend was mounted at | [default to &quot;radius&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="radiusreaduser"></a>
# **RadiusReadUser**

> void RadiusReadUser (string name, string radiusMountPath, TimeSpan? wrapTTL = null)

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
    public class RadiusReadUserExample
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
            
            
            
            
            var radiusMountPath = "\"radius\"";  // string | Path that the backend was mounted at (default to "radius")
            
            
            

            try
            {
                
                // Manage users allowed to authenticate.
                

                apiInstance.RadiusReadUser(string name, string radiusMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.RadiusReadUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the RADIUS user. | 
 **radiusMountPath** | **string**| Path that the backend was mounted at | [default to &quot;radius&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="radiuswriteuser"></a>
# **RadiusWriteUser**

> void RadiusWriteUser (string name, string radiusMountPath, RadiusWriteUserRequest radiusWriteUserRequest, TimeSpan? wrapTTL = null)

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
    public class RadiusWriteUserExample
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
            
            
            
            
            var radiusMountPath = "\"radius\"";  // string | Path that the backend was mounted at (default to "radius")
            
            
            
            
            
            var radiusWriteUserRequest = new RadiusWriteUserRequest(); // RadiusWriteUserRequest | 
            
            

            try
            {
                
                // Manage users allowed to authenticate.
                

                apiInstance.RadiusWriteUser(string name, string radiusMountPath, RadiusWriteUserRequest radiusWriteUserRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.RadiusWriteUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the RADIUS user. | 
 **radiusMountPath** | **string**| Path that the backend was mounted at | [default to &quot;radius&quot;]
 **radiusWriteUserRequest** | [**RadiusWriteUserRequest**](RadiusWriteUserRequest.md)|  | 


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

<a name="tokencreate"></a>
# **TokenCreate**

> void TokenCreate (TokenCreateRequest tokenCreateRequest, TimeSpan? wrapTTL = null)

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
    public class TokenCreateExample
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
            
            

            try
            {
                
                // The token create path is used to create new tokens.
                

                apiInstance.TokenCreate(TokenCreateRequest tokenCreateRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.TokenCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenCreateRequest** | [**TokenCreateRequest**](TokenCreateRequest.md)|  | 


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

<a name="tokencreateagainstrole"></a>
# **TokenCreateAgainstRole**

> void TokenCreateAgainstRole (string roleName, TokenCreateAgainstRoleRequest tokenCreateAgainstRoleRequest, TimeSpan? wrapTTL = null)

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
    public class TokenCreateAgainstRoleExample
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
            
            
            
            
            
            var tokenCreateAgainstRoleRequest = new TokenCreateAgainstRoleRequest(); // TokenCreateAgainstRoleRequest | 
            
            

            try
            {
                
                // This token create path is used to create new tokens adhering to the given role.
                

                apiInstance.TokenCreateAgainstRole(string roleName, TokenCreateAgainstRoleRequest tokenCreateAgainstRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.TokenCreateAgainstRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role | 
 **tokenCreateAgainstRoleRequest** | [**TokenCreateAgainstRoleRequest**](TokenCreateAgainstRoleRequest.md)|  | 


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

<a name="tokencreateorphan"></a>
# **TokenCreateOrphan**

> void TokenCreateOrphan (TokenCreateOrphanRequest tokenCreateOrphanRequest, TimeSpan? wrapTTL = null)

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
    public class TokenCreateOrphanExample
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
            
            

            try
            {
                
                // The token create path is used to create new orphan tokens.
                

                apiInstance.TokenCreateOrphan(TokenCreateOrphanRequest tokenCreateOrphanRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.TokenCreateOrphan: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenCreateOrphanRequest** | [**TokenCreateOrphanRequest**](TokenCreateOrphanRequest.md)|  | 


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

<a name="tokendeleterole"></a>
# **TokenDeleteRole**

> void TokenDeleteRole (string roleName, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TokenDeleteRoleExample
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
            
            
            

            try
            {
                

                apiInstance.TokenDeleteRole(string roleName, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.TokenDeleteRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="tokenlistaccessors"></a>
# **TokenListAccessors**

> StandardListResponse TokenListAccessors (TimeSpan? wrapTTL = null)

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
    public class TokenListAccessorsExample
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
            
            
            

            try
            {
                
                // List token accessors, which can then be be used to iterate and discover their properties or revoke them. Because this can be used to cause a denial of service, this endpoint requires 'sudo' capability in addition to 'list'.
                

                StandardListResponse result = apiInstance.TokenListAccessors(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.TokenListAccessors: " + e.Message );
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

<a name="tokenlistroles"></a>
# **TokenListRoles**

> StandardListResponse TokenListRoles (TimeSpan? wrapTTL = null)

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
    public class TokenListRolesExample
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
            
            
            

            try
            {
                
                // This endpoint lists configured roles.
                

                StandardListResponse result = apiInstance.TokenListRoles(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.TokenListRoles: " + e.Message );
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

<a name="tokenlookup"></a>
# **TokenLookUp**

> void TokenLookUp (TokenLookUpRequest tokenLookUpRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TokenLookUpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            
            var tokenLookUpRequest = new TokenLookUpRequest(); // TokenLookUpRequest | 
            
            

            try
            {
                

                apiInstance.TokenLookUp(TokenLookUpRequest tokenLookUpRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.TokenLookUp: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenLookUpRequest** | [**TokenLookUpRequest**](TokenLookUpRequest.md)|  | 


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

<a name="tokenlookupaccessor"></a>
# **TokenLookUpAccessor**

> void TokenLookUpAccessor (TokenLookUpAccessorRequest tokenLookUpAccessorRequest, TimeSpan? wrapTTL = null)

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
    public class TokenLookUpAccessorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            
            var tokenLookUpAccessorRequest = new TokenLookUpAccessorRequest(); // TokenLookUpAccessorRequest | 
            
            

            try
            {
                
                // This endpoint will lookup a token associated with the given accessor and its properties. Response will not contain the token ID.
                

                apiInstance.TokenLookUpAccessor(TokenLookUpAccessorRequest tokenLookUpAccessorRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.TokenLookUpAccessor: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenLookUpAccessorRequest** | [**TokenLookUpAccessorRequest**](TokenLookUpAccessorRequest.md)|  | 


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

<a name="tokenlookupself"></a>
# **TokenLookUpSelf**

> void TokenLookUpSelf (TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TokenLookUpSelfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            

            try
            {
                

                apiInstance.TokenLookUpSelf(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.TokenLookUpSelf: " + e.Message );
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

<a name="tokenreadrole"></a>
# **TokenReadRole**

> void TokenReadRole (string roleName, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TokenReadRoleExample
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
            
            
            

            try
            {
                

                apiInstance.TokenReadRole(string roleName, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.TokenReadRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="tokenrenew"></a>
# **TokenRenew**

> void TokenRenew (TokenRenewRequest tokenRenewRequest, TimeSpan? wrapTTL = null)

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
    public class TokenRenewExample
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
            
            

            try
            {
                
                // This endpoint will renew the given token and prevent expiration.
                

                apiInstance.TokenRenew(TokenRenewRequest tokenRenewRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.TokenRenew: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenRenewRequest** | [**TokenRenewRequest**](TokenRenewRequest.md)|  | 


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

<a name="tokenrenewaccessor"></a>
# **TokenRenewAccessor**

> void TokenRenewAccessor (TokenRenewAccessorRequest tokenRenewAccessorRequest, TimeSpan? wrapTTL = null)

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
    public class TokenRenewAccessorExample
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
            
            

            try
            {
                
                // This endpoint will renew a token associated with the given accessor and its properties. Response will not contain the token ID.
                

                apiInstance.TokenRenewAccessor(TokenRenewAccessorRequest tokenRenewAccessorRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.TokenRenewAccessor: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenRenewAccessorRequest** | [**TokenRenewAccessorRequest**](TokenRenewAccessorRequest.md)|  | 


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

<a name="tokenrenewself"></a>
# **TokenRenewSelf**

> void TokenRenewSelf (TokenRenewSelfRequest tokenRenewSelfRequest, TimeSpan? wrapTTL = null)

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
    public class TokenRenewSelfExample
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
            
            

            try
            {
                
                // This endpoint will renew the token used to call it and prevent expiration.
                

                apiInstance.TokenRenewSelf(TokenRenewSelfRequest tokenRenewSelfRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.TokenRenewSelf: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenRenewSelfRequest** | [**TokenRenewSelfRequest**](TokenRenewSelfRequest.md)|  | 


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

<a name="tokenrevoke"></a>
# **TokenRevoke**

> void TokenRevoke (TokenRevokeRequest tokenRevokeRequest, TimeSpan? wrapTTL = null)

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
    public class TokenRevokeExample
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
            
            

            try
            {
                
                // This endpoint will delete the given token and all of its child tokens.
                

                apiInstance.TokenRevoke(TokenRevokeRequest tokenRevokeRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.TokenRevoke: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenRevokeRequest** | [**TokenRevokeRequest**](TokenRevokeRequest.md)|  | 


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

<a name="tokenrevokeaccessor"></a>
# **TokenRevokeAccessor**

> void TokenRevokeAccessor (TokenRevokeAccessorRequest tokenRevokeAccessorRequest, TimeSpan? wrapTTL = null)

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
    public class TokenRevokeAccessorExample
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
            
            

            try
            {
                
                // This endpoint will delete the token associated with the accessor and all of its child tokens.
                

                apiInstance.TokenRevokeAccessor(TokenRevokeAccessorRequest tokenRevokeAccessorRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.TokenRevokeAccessor: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenRevokeAccessorRequest** | [**TokenRevokeAccessorRequest**](TokenRevokeAccessorRequest.md)|  | 


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

<a name="tokenrevokeorphan"></a>
# **TokenRevokeOrphan**

> void TokenRevokeOrphan (TokenRevokeOrphanRequest tokenRevokeOrphanRequest, TimeSpan? wrapTTL = null)

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
    public class TokenRevokeOrphanExample
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
            
            

            try
            {
                
                // This endpoint will delete the token and orphan its child tokens.
                

                apiInstance.TokenRevokeOrphan(TokenRevokeOrphanRequest tokenRevokeOrphanRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.TokenRevokeOrphan: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenRevokeOrphanRequest** | [**TokenRevokeOrphanRequest**](TokenRevokeOrphanRequest.md)|  | 


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

<a name="tokenrevokeself"></a>
# **TokenRevokeSelf**

> void TokenRevokeSelf (TimeSpan? wrapTTL = null)

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
    public class TokenRevokeSelfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            

            try
            {
                
                // This endpoint will delete the token used to call it and all of its child tokens.
                

                apiInstance.TokenRevokeSelf(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.TokenRevokeSelf: " + e.Message );
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

<a name="tokentidy"></a>
# **TokenTidy**

> void TokenTidy (TimeSpan? wrapTTL = null)

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
    public class TokenTidyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            

            try
            {
                
                // This endpoint performs cleanup tasks that can be run if certain error conditions have occurred.
                

                apiInstance.TokenTidy(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.TokenTidy: " + e.Message );
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

<a name="tokenwriterole"></a>
# **TokenWriteRole**

> void TokenWriteRole (string roleName, TokenWriteRoleRequest tokenWriteRoleRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TokenWriteRoleExample
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
            
            
            
            
            
            var tokenWriteRoleRequest = new TokenWriteRoleRequest(); // TokenWriteRoleRequest | 
            
            

            try
            {
                

                apiInstance.TokenWriteRole(string roleName, TokenWriteRoleRequest tokenWriteRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.TokenWriteRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleName** | **string**| Name of the role | 
 **tokenWriteRoleRequest** | [**TokenWriteRoleRequest**](TokenWriteRoleRequest.md)|  | 


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

<a name="userpassdeleteuser"></a>
# **UserpassDeleteUser**

> void UserpassDeleteUser (string username, string userpassMountPath, TimeSpan? wrapTTL = null)

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
    public class UserpassDeleteUserExample
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
            
            
            
            
            var userpassMountPath = "\"userpass\"";  // string | Path that the backend was mounted at (default to "userpass")
            
            
            

            try
            {
                
                // Manage users allowed to authenticate.
                

                apiInstance.UserpassDeleteUser(string username, string userpassMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UserpassDeleteUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| Username for this user. | 
 **userpassMountPath** | **string**| Path that the backend was mounted at | [default to &quot;userpass&quot;]


### Return type

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

<a name="userpasslistusers"></a>
# **UserpassListUsers**

> StandardListResponse UserpassListUsers (string userpassMountPath, TimeSpan? wrapTTL = null)

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
    public class UserpassListUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Auth(httpClient, config, httpClientHandler);
            
            
            
            
            var userpassMountPath = "\"userpass\"";  // string | Path that the backend was mounted at (default to "userpass")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // Manage users allowed to authenticate.
                

                StandardListResponse result = apiInstance.UserpassListUsers(string userpassMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UserpassListUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userpassMountPath** | **string**| Path that the backend was mounted at | [default to &quot;userpass&quot;]
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

<a name="userpasslogin"></a>
# **UserpassLogin**

> void UserpassLogin (string username, string userpassMountPath, UserpassLoginRequest userpassLoginRequest, TimeSpan? wrapTTL = null)

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
    public class UserpassLoginExample
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
            
            
            
            
            var userpassMountPath = "\"userpass\"";  // string | Path that the backend was mounted at (default to "userpass")
            
            
            
            
            
            var userpassLoginRequest = new UserpassLoginRequest(); // UserpassLoginRequest | 
            
            

            try
            {
                
                // Log in with a username and password.
                

                apiInstance.UserpassLogin(string username, string userpassMountPath, UserpassLoginRequest userpassLoginRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UserpassLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| Username of the user. | 
 **userpassMountPath** | **string**| Path that the backend was mounted at | [default to &quot;userpass&quot;]
 **userpassLoginRequest** | [**UserpassLoginRequest**](UserpassLoginRequest.md)|  | 


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

<a name="userpassreaduser"></a>
# **UserpassReadUser**

> void UserpassReadUser (string username, string userpassMountPath, TimeSpan? wrapTTL = null)

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
    public class UserpassReadUserExample
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
            
            
            
            
            var userpassMountPath = "\"userpass\"";  // string | Path that the backend was mounted at (default to "userpass")
            
            
            

            try
            {
                
                // Manage users allowed to authenticate.
                

                apiInstance.UserpassReadUser(string username, string userpassMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UserpassReadUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| Username for this user. | 
 **userpassMountPath** | **string**| Path that the backend was mounted at | [default to &quot;userpass&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userpassresetpassword"></a>
# **UserpassResetPassword**

> void UserpassResetPassword (string username, string userpassMountPath, UserpassResetPasswordRequest userpassResetPasswordRequest, TimeSpan? wrapTTL = null)

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
    public class UserpassResetPasswordExample
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
            
            
            
            
            var userpassMountPath = "\"userpass\"";  // string | Path that the backend was mounted at (default to "userpass")
            
            
            
            
            
            var userpassResetPasswordRequest = new UserpassResetPasswordRequest(); // UserpassResetPasswordRequest | 
            
            

            try
            {
                
                // Reset user's password.
                

                apiInstance.UserpassResetPassword(string username, string userpassMountPath, UserpassResetPasswordRequest userpassResetPasswordRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UserpassResetPassword: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| Username for this user. | 
 **userpassMountPath** | **string**| Path that the backend was mounted at | [default to &quot;userpass&quot;]
 **userpassResetPasswordRequest** | [**UserpassResetPasswordRequest**](UserpassResetPasswordRequest.md)|  | 


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

<a name="userpassupdatepolicies"></a>
# **UserpassUpdatePolicies**

> void UserpassUpdatePolicies (string username, string userpassMountPath, UserpassUpdatePoliciesRequest userpassUpdatePoliciesRequest, TimeSpan? wrapTTL = null)

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
    public class UserpassUpdatePoliciesExample
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
            
            
            
            
            var userpassMountPath = "\"userpass\"";  // string | Path that the backend was mounted at (default to "userpass")
            
            
            
            
            
            var userpassUpdatePoliciesRequest = new UserpassUpdatePoliciesRequest(); // UserpassUpdatePoliciesRequest | 
            
            

            try
            {
                
                // Update the policies associated with the username.
                

                apiInstance.UserpassUpdatePolicies(string username, string userpassMountPath, UserpassUpdatePoliciesRequest userpassUpdatePoliciesRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UserpassUpdatePolicies: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| Username for this user. | 
 **userpassMountPath** | **string**| Path that the backend was mounted at | [default to &quot;userpass&quot;]
 **userpassUpdatePoliciesRequest** | [**UserpassUpdatePoliciesRequest**](UserpassUpdatePoliciesRequest.md)|  | 


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

<a name="userpasswriteuser"></a>
# **UserpassWriteUser**

> void UserpassWriteUser (string username, string userpassMountPath, UserpassWriteUserRequest userpassWriteUserRequest, TimeSpan? wrapTTL = null)

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
    public class UserpassWriteUserExample
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
            
            
            
            
            var userpassMountPath = "\"userpass\"";  // string | Path that the backend was mounted at (default to "userpass")
            
            
            
            
            
            var userpassWriteUserRequest = new UserpassWriteUserRequest(); // UserpassWriteUserRequest | 
            
            

            try
            {
                
                // Manage users allowed to authenticate.
                

                apiInstance.UserpassWriteUser(string username, string userpassMountPath, UserpassWriteUserRequest userpassWriteUserRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth.UserpassWriteUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| Username for this user. | 
 **userpassMountPath** | **string**| Path that the backend was mounted at | [default to &quot;userpass&quot;]
 **userpassWriteUserRequest** | [**UserpassWriteUserRequest**](UserpassWriteUserRequest.md)|  | 


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

