# Vault.Api.Secrets

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AliCloudConfigure**](SecretsApi.md#alicloudconfigure) | **POST** /{alicloud_mount_path}/config | 
[**AliCloudDeleteConfiguration**](SecretsApi.md#aliclouddeleteconfiguration) | **DELETE** /{alicloud_mount_path}/config | 
[**AliCloudDeleteRole**](SecretsApi.md#aliclouddeleterole) | **DELETE** /{alicloud_mount_path}/role/{name} | Read, write and reference policies and roles that API keys or STS credentials can be made for.
[**AliCloudGenerateCredentials**](SecretsApi.md#alicloudgeneratecredentials) | **GET** /{alicloud_mount_path}/creds/{name} | Generate an API key or STS credential using the given role&#x27;s configuration.&#x27;
[**AliCloudListRoles**](SecretsApi.md#alicloudlistroles) | **GET** /{alicloud_mount_path}/role | List the existing roles in this backend.
[**AliCloudReadConfiguration**](SecretsApi.md#alicloudreadconfiguration) | **GET** /{alicloud_mount_path}/config | 
[**AliCloudReadRole**](SecretsApi.md#alicloudreadrole) | **GET** /{alicloud_mount_path}/role/{name} | Read, write and reference policies and roles that API keys or STS credentials can be made for.
[**AliCloudWriteRole**](SecretsApi.md#alicloudwriterole) | **POST** /{alicloud_mount_path}/role/{name} | Read, write and reference policies and roles that API keys or STS credentials can be made for.
[**AwsConfigureLease**](SecretsApi.md#awsconfigurelease) | **POST** /{aws_mount_path}/config/lease | 
[**AwsConfigureRootIamCredentials**](SecretsApi.md#awsconfigurerootiamcredentials) | **POST** /{aws_mount_path}/config/root | 
[**AwsDeleteRole**](SecretsApi.md#awsdeleterole) | **DELETE** /{aws_mount_path}/roles/{name} | Read, write and reference IAM policies that access keys can be made for.
[**AwsGenerateCredentials**](SecretsApi.md#awsgeneratecredentials) | **GET** /{aws_mount_path}/creds/{name} | 
[**AwsGenerateCredentials2**](SecretsApi.md#awsgeneratecredentials2) | **POST** /{aws_mount_path}/creds/{name} | 
[**AwsGenerateStsCredentials**](SecretsApi.md#awsgeneratestscredentials) | **GET** /{aws_mount_path}/sts/{name} | 
[**AwsGenerateStsCredentials2**](SecretsApi.md#awsgeneratestscredentials2) | **POST** /{aws_mount_path}/sts/{name} | 
[**AwsListRoles**](SecretsApi.md#awslistroles) | **GET** /{aws_mount_path}/roles | List the existing roles in this backend
[**AwsReadLeaseConfiguration**](SecretsApi.md#awsreadleaseconfiguration) | **GET** /{aws_mount_path}/config/lease | 
[**AwsReadRole**](SecretsApi.md#awsreadrole) | **GET** /{aws_mount_path}/roles/{name} | Read, write and reference IAM policies that access keys can be made for.
[**AwsReadRootIamCredentialsConfiguration**](SecretsApi.md#awsreadrootiamcredentialsconfiguration) | **GET** /{aws_mount_path}/config/root | 
[**AwsRotateRootIamCredentials**](SecretsApi.md#awsrotaterootiamcredentials) | **POST** /{aws_mount_path}/config/rotate-root | 
[**AwsWriteRole**](SecretsApi.md#awswriterole) | **POST** /{aws_mount_path}/roles/{name} | Read, write and reference IAM policies that access keys can be made for.
[**AzureConfigure**](SecretsApi.md#azureconfigure) | **POST** /{azure_mount_path}/config | 
[**AzureDeleteConfiguration**](SecretsApi.md#azuredeleteconfiguration) | **DELETE** /{azure_mount_path}/config | 
[**AzureDeleteRole**](SecretsApi.md#azuredeleterole) | **DELETE** /{azure_mount_path}/roles/{name} | Manage the Vault roles used to generate Azure credentials.
[**AzureListRoles**](SecretsApi.md#azurelistroles) | **GET** /{azure_mount_path}/roles | List existing roles.
[**AzureReadConfiguration**](SecretsApi.md#azurereadconfiguration) | **GET** /{azure_mount_path}/config | 
[**AzureReadRole**](SecretsApi.md#azurereadrole) | **GET** /{azure_mount_path}/roles/{name} | Manage the Vault roles used to generate Azure credentials.
[**AzureRequestServicePrincipalCredentials**](SecretsApi.md#azurerequestserviceprincipalcredentials) | **GET** /{azure_mount_path}/creds/{role} | 
[**AzureRotateRoot**](SecretsApi.md#azurerotateroot) | **POST** /{azure_mount_path}/rotate-root | 
[**AzureWriteRole**](SecretsApi.md#azurewriterole) | **POST** /{azure_mount_path}/roles/{name} | Manage the Vault roles used to generate Azure credentials.
[**ConsulConfigureAccess**](SecretsApi.md#consulconfigureaccess) | **POST** /{consul_mount_path}/config/access | 
[**ConsulDeleteRole**](SecretsApi.md#consuldeleterole) | **DELETE** /{consul_mount_path}/roles/{name} | 
[**ConsulGenerateCredentials**](SecretsApi.md#consulgeneratecredentials) | **GET** /{consul_mount_path}/creds/{role} | 
[**ConsulListRoles**](SecretsApi.md#consullistroles) | **GET** /{consul_mount_path}/roles | 
[**ConsulReadAccessConfiguration**](SecretsApi.md#consulreadaccessconfiguration) | **GET** /{consul_mount_path}/config/access | 
[**ConsulReadRole**](SecretsApi.md#consulreadrole) | **GET** /{consul_mount_path}/roles/{name} | 
[**ConsulWriteRole**](SecretsApi.md#consulwriterole) | **POST** /{consul_mount_path}/roles/{name} | 
[**CubbyholeDelete**](SecretsApi.md#cubbyholedelete) | **DELETE** /cubbyhole/{path} | Deletes the secret at the specified location.
[**CubbyholeRead**](SecretsApi.md#cubbyholeread) | **GET** /cubbyhole/{path} | Retrieve the secret at the specified location.
[**CubbyholeWrite**](SecretsApi.md#cubbyholewrite) | **POST** /cubbyhole/{path} | Store a secret at the specified location.
[**DatabaseConfigureConnection**](SecretsApi.md#databaseconfigureconnection) | **POST** /{database_mount_path}/config/{name} | 
[**DatabaseDeleteConnectionConfiguration**](SecretsApi.md#databasedeleteconnectionconfiguration) | **DELETE** /{database_mount_path}/config/{name} | 
[**DatabaseDeleteRole**](SecretsApi.md#databasedeleterole) | **DELETE** /{database_mount_path}/roles/{name} | Manage the roles that can be created with this backend.
[**DatabaseDeleteStaticRole**](SecretsApi.md#databasedeletestaticrole) | **DELETE** /{database_mount_path}/static-roles/{name} | Manage the static roles that can be created with this backend.
[**DatabaseGenerateCredentials**](SecretsApi.md#databasegeneratecredentials) | **GET** /{database_mount_path}/creds/{name} | Request database credentials for a certain role.
[**DatabaseListConnections**](SecretsApi.md#databaselistconnections) | **GET** /{database_mount_path}/config | Configure connection details to a database plugin.
[**DatabaseListRoles**](SecretsApi.md#databaselistroles) | **GET** /{database_mount_path}/roles | Manage the roles that can be created with this backend.
[**DatabaseListStaticRoles**](SecretsApi.md#databaseliststaticroles) | **GET** /{database_mount_path}/static-roles | Manage the static roles that can be created with this backend.
[**DatabaseReadConnectionConfiguration**](SecretsApi.md#databasereadconnectionconfiguration) | **GET** /{database_mount_path}/config/{name} | 
[**DatabaseReadRole**](SecretsApi.md#databasereadrole) | **GET** /{database_mount_path}/roles/{name} | Manage the roles that can be created with this backend.
[**DatabaseReadStaticRole**](SecretsApi.md#databasereadstaticrole) | **GET** /{database_mount_path}/static-roles/{name} | Manage the static roles that can be created with this backend.
[**DatabaseReadStaticRoleCredentials**](SecretsApi.md#databasereadstaticrolecredentials) | **GET** /{database_mount_path}/static-creds/{name} | Request database credentials for a certain static role. These credentials are rotated periodically.
[**DatabaseResetConnection**](SecretsApi.md#databaseresetconnection) | **POST** /{database_mount_path}/reset/{name} | Resets a database plugin.
[**DatabaseRotateRootCredentials**](SecretsApi.md#databaserotaterootcredentials) | **POST** /{database_mount_path}/rotate-root/{name} | 
[**DatabaseRotateStaticRoleCredentials**](SecretsApi.md#databaserotatestaticrolecredentials) | **POST** /{database_mount_path}/rotate-role/{name} | 
[**DatabaseWriteRole**](SecretsApi.md#databasewriterole) | **POST** /{database_mount_path}/roles/{name} | Manage the roles that can be created with this backend.
[**DatabaseWriteStaticRole**](SecretsApi.md#databasewritestaticrole) | **POST** /{database_mount_path}/static-roles/{name} | Manage the static roles that can be created with this backend.
[**GoogleCloudConfigure**](SecretsApi.md#googlecloudconfigure) | **POST** /{gcp_mount_path}/config | 
[**GoogleCloudDeleteImpersonatedAccount**](SecretsApi.md#googleclouddeleteimpersonatedaccount) | **DELETE** /{gcp_mount_path}/impersonated-account/{name} | 
[**GoogleCloudDeleteRoleset**](SecretsApi.md#googleclouddeleteroleset) | **DELETE** /{gcp_mount_path}/roleset/{name} | 
[**GoogleCloudDeleteStaticAccount**](SecretsApi.md#googleclouddeletestaticaccount) | **DELETE** /{gcp_mount_path}/static-account/{name} | 
[**GoogleCloudGenerateImpersonatedAccountAccessToken**](SecretsApi.md#googlecloudgenerateimpersonatedaccountaccesstoken) | **GET** /{gcp_mount_path}/impersonated-account/{name}/token | 
[**GoogleCloudGenerateImpersonatedAccountAccessToken2**](SecretsApi.md#googlecloudgenerateimpersonatedaccountaccesstoken2) | **POST** /{gcp_mount_path}/impersonated-account/{name}/token | 
[**GoogleCloudGenerateRolesetAccessToken**](SecretsApi.md#googlecloudgeneraterolesetaccesstoken) | **GET** /{gcp_mount_path}/roleset/{roleset}/token | 
[**GoogleCloudGenerateRolesetAccessToken2**](SecretsApi.md#googlecloudgeneraterolesetaccesstoken2) | **GET** /{gcp_mount_path}/token/{roleset} | 
[**GoogleCloudGenerateRolesetAccessTokenWithParameters**](SecretsApi.md#googlecloudgeneraterolesetaccesstokenwithparameters) | **POST** /{gcp_mount_path}/roleset/{roleset}/token | 
[**GoogleCloudGenerateRolesetAccessTokenWithParameters2**](SecretsApi.md#googlecloudgeneraterolesetaccesstokenwithparameters2) | **POST** /{gcp_mount_path}/token/{roleset} | 
[**GoogleCloudGenerateRolesetKey**](SecretsApi.md#googlecloudgeneraterolesetkey) | **GET** /{gcp_mount_path}/roleset/{roleset}/key | 
[**GoogleCloudGenerateRolesetKey2**](SecretsApi.md#googlecloudgeneraterolesetkey2) | **GET** /{gcp_mount_path}/key/{roleset} | 
[**GoogleCloudGenerateRolesetKeyWithParameters**](SecretsApi.md#googlecloudgeneraterolesetkeywithparameters) | **POST** /{gcp_mount_path}/roleset/{roleset}/key | 
[**GoogleCloudGenerateRolesetKeyWithParameters2**](SecretsApi.md#googlecloudgeneraterolesetkeywithparameters2) | **POST** /{gcp_mount_path}/key/{roleset} | 
[**GoogleCloudGenerateStaticAccountAccessToken**](SecretsApi.md#googlecloudgeneratestaticaccountaccesstoken) | **GET** /{gcp_mount_path}/static-account/{name}/token | 
[**GoogleCloudGenerateStaticAccountAccessTokenWithParameters**](SecretsApi.md#googlecloudgeneratestaticaccountaccesstokenwithparameters) | **POST** /{gcp_mount_path}/static-account/{name}/token | 
[**GoogleCloudGenerateStaticAccountKey**](SecretsApi.md#googlecloudgeneratestaticaccountkey) | **GET** /{gcp_mount_path}/static-account/{name}/key | 
[**GoogleCloudGenerateStaticAccountKeyWithParameters**](SecretsApi.md#googlecloudgeneratestaticaccountkeywithparameters) | **POST** /{gcp_mount_path}/static-account/{name}/key | 
[**GoogleCloudKmsConfigure**](SecretsApi.md#googlecloudkmsconfigure) | **POST** /{gcpkms_mount_path}/config | 
[**GoogleCloudKmsConfigureKey**](SecretsApi.md#googlecloudkmsconfigurekey) | **POST** /{gcpkms_mount_path}/keys/config/{key} | 
[**GoogleCloudKmsDecrypt**](SecretsApi.md#googlecloudkmsdecrypt) | **POST** /{gcpkms_mount_path}/decrypt/{key} | Decrypt a ciphertext value using a named key
[**GoogleCloudKmsDeleteConfiguration**](SecretsApi.md#googlecloudkmsdeleteconfiguration) | **DELETE** /{gcpkms_mount_path}/config | 
[**GoogleCloudKmsDeleteKey**](SecretsApi.md#googlecloudkmsdeletekey) | **DELETE** /{gcpkms_mount_path}/keys/{key} | Interact with crypto keys in Vault and Google Cloud KMS
[**GoogleCloudKmsDeregisterKey**](SecretsApi.md#googlecloudkmsderegisterkey) | **POST** /{gcpkms_mount_path}/keys/deregister/{key} | 
[**GoogleCloudKmsDeregisterKey2**](SecretsApi.md#googlecloudkmsderegisterkey2) | **DELETE** /{gcpkms_mount_path}/keys/deregister/{key} | 
[**GoogleCloudKmsEncrypt**](SecretsApi.md#googlecloudkmsencrypt) | **POST** /{gcpkms_mount_path}/encrypt/{key} | Encrypt a plaintext value using a named key
[**GoogleCloudKmsListKeys**](SecretsApi.md#googlecloudkmslistkeys) | **GET** /{gcpkms_mount_path}/keys | List named keys
[**GoogleCloudKmsReadConfiguration**](SecretsApi.md#googlecloudkmsreadconfiguration) | **GET** /{gcpkms_mount_path}/config | 
[**GoogleCloudKmsReadKey**](SecretsApi.md#googlecloudkmsreadkey) | **GET** /{gcpkms_mount_path}/keys/{key} | Interact with crypto keys in Vault and Google Cloud KMS
[**GoogleCloudKmsReadKeyConfiguration**](SecretsApi.md#googlecloudkmsreadkeyconfiguration) | **GET** /{gcpkms_mount_path}/keys/config/{key} | 
[**GoogleCloudKmsReencrypt**](SecretsApi.md#googlecloudkmsreencrypt) | **POST** /{gcpkms_mount_path}/reencrypt/{key} | Re-encrypt existing ciphertext data to a new version
[**GoogleCloudKmsRegisterKey**](SecretsApi.md#googlecloudkmsregisterkey) | **POST** /{gcpkms_mount_path}/keys/register/{key} | Register an existing crypto key in Google Cloud KMS
[**GoogleCloudKmsRetrievePublicKey**](SecretsApi.md#googlecloudkmsretrievepublickey) | **GET** /{gcpkms_mount_path}/pubkey/{key} | Retrieve the public key associated with the named key
[**GoogleCloudKmsRotateKey**](SecretsApi.md#googlecloudkmsrotatekey) | **POST** /{gcpkms_mount_path}/keys/rotate/{key} | Rotate a crypto key to a new primary version
[**GoogleCloudKmsSign**](SecretsApi.md#googlecloudkmssign) | **POST** /{gcpkms_mount_path}/sign/{key} | Signs a message or digest using a named key
[**GoogleCloudKmsTrimKeyVersions**](SecretsApi.md#googlecloudkmstrimkeyversions) | **POST** /{gcpkms_mount_path}/keys/trim/{key} | 
[**GoogleCloudKmsTrimKeyVersions2**](SecretsApi.md#googlecloudkmstrimkeyversions2) | **DELETE** /{gcpkms_mount_path}/keys/trim/{key} | 
[**GoogleCloudKmsVerify**](SecretsApi.md#googlecloudkmsverify) | **POST** /{gcpkms_mount_path}/verify/{key} | Verify a signature using a named key
[**GoogleCloudKmsWriteKey**](SecretsApi.md#googlecloudkmswritekey) | **POST** /{gcpkms_mount_path}/keys/{key} | Interact with crypto keys in Vault and Google Cloud KMS
[**GoogleCloudListImpersonatedAccounts**](SecretsApi.md#googlecloudlistimpersonatedaccounts) | **GET** /{gcp_mount_path}/impersonated-account | 
[**GoogleCloudListImpersonatedAccounts2**](SecretsApi.md#googlecloudlistimpersonatedaccounts2) | **GET** /{gcp_mount_path}/impersonated-accounts | 
[**GoogleCloudListRolesets**](SecretsApi.md#googlecloudlistrolesets) | **GET** /{gcp_mount_path}/roleset | 
[**GoogleCloudListRolesets2**](SecretsApi.md#googlecloudlistrolesets2) | **GET** /{gcp_mount_path}/rolesets | 
[**GoogleCloudListStaticAccounts**](SecretsApi.md#googlecloudliststaticaccounts) | **GET** /{gcp_mount_path}/static-account | 
[**GoogleCloudListStaticAccounts2**](SecretsApi.md#googlecloudliststaticaccounts2) | **GET** /{gcp_mount_path}/static-accounts | 
[**GoogleCloudReadConfiguration**](SecretsApi.md#googlecloudreadconfiguration) | **GET** /{gcp_mount_path}/config | 
[**GoogleCloudReadImpersonatedAccount**](SecretsApi.md#googlecloudreadimpersonatedaccount) | **GET** /{gcp_mount_path}/impersonated-account/{name} | 
[**GoogleCloudReadRoleset**](SecretsApi.md#googlecloudreadroleset) | **GET** /{gcp_mount_path}/roleset/{name} | 
[**GoogleCloudReadStaticAccount**](SecretsApi.md#googlecloudreadstaticaccount) | **GET** /{gcp_mount_path}/static-account/{name} | 
[**GoogleCloudRotateRoleset**](SecretsApi.md#googlecloudrotateroleset) | **POST** /{gcp_mount_path}/roleset/{name}/rotate | 
[**GoogleCloudRotateRolesetKey**](SecretsApi.md#googlecloudrotaterolesetkey) | **POST** /{gcp_mount_path}/roleset/{name}/rotate-key | 
[**GoogleCloudRotateRootCredentials**](SecretsApi.md#googlecloudrotaterootcredentials) | **POST** /{gcp_mount_path}/config/rotate-root | 
[**GoogleCloudRotateStaticAccountKey**](SecretsApi.md#googlecloudrotatestaticaccountkey) | **POST** /{gcp_mount_path}/static-account/{name}/rotate-key | 
[**GoogleCloudWriteImpersonatedAccount**](SecretsApi.md#googlecloudwriteimpersonatedaccount) | **POST** /{gcp_mount_path}/impersonated-account/{name} | 
[**GoogleCloudWriteRoleset**](SecretsApi.md#googlecloudwriteroleset) | **POST** /{gcp_mount_path}/roleset/{name} | 
[**GoogleCloudWriteStaticAccount**](SecretsApi.md#googlecloudwritestaticaccount) | **POST** /{gcp_mount_path}/static-account/{name} | 
[**KubernetesCheckConfiguration**](SecretsApi.md#kubernetescheckconfiguration) | **GET** /{kubernetes_mount_path}/check | 
[**KubernetesConfigure**](SecretsApi.md#kubernetesconfigure) | **POST** /{kubernetes_mount_path}/config | 
[**KubernetesDeleteConfiguration**](SecretsApi.md#kubernetesdeleteconfiguration) | **DELETE** /{kubernetes_mount_path}/config | 
[**KubernetesDeleteRole**](SecretsApi.md#kubernetesdeleterole) | **DELETE** /{kubernetes_mount_path}/roles/{name} | 
[**KubernetesGenerateCredentials**](SecretsApi.md#kubernetesgeneratecredentials) | **POST** /{kubernetes_mount_path}/creds/{name} | 
[**KubernetesListRoles**](SecretsApi.md#kuberneteslistroles) | **GET** /{kubernetes_mount_path}/roles | 
[**KubernetesReadConfiguration**](SecretsApi.md#kubernetesreadconfiguration) | **GET** /{kubernetes_mount_path}/config | 
[**KubernetesReadRole**](SecretsApi.md#kubernetesreadrole) | **GET** /{kubernetes_mount_path}/roles/{name} | 
[**KubernetesWriteRole**](SecretsApi.md#kuberneteswriterole) | **POST** /{kubernetes_mount_path}/roles/{name} | 
[**KvV1Delete**](SecretsApi.md#kvv1delete) | **DELETE** /{kv-v1_mount_path}/{path} | 
[**KvV1Read**](SecretsApi.md#kvv1read) | **GET** /{kv-v1_mount_path}/{path} | 
[**KvV1Write**](SecretsApi.md#kvv1write) | **POST** /{kv-v1_mount_path}/{path} | 
[**KvV2Configure**](SecretsApi.md#kvv2configure) | **POST** /{kv-v2_mount_path}/config | Configure backend level settings that are applied to every key in the key-value store.
[**KvV2Delete**](SecretsApi.md#kvv2delete) | **DELETE** /{kv-v2_mount_path}/data/{path} | 
[**KvV2DeleteMetadata**](SecretsApi.md#kvv2deletemetadata) | **DELETE** /{kv-v2_mount_path}/metadata/{path} | 
[**KvV2DeleteVersions**](SecretsApi.md#kvv2deleteversions) | **POST** /{kv-v2_mount_path}/delete/{path} | 
[**KvV2DestroyVersions**](SecretsApi.md#kvv2destroyversions) | **POST** /{kv-v2_mount_path}/destroy/{path} | 
[**KvV2Read**](SecretsApi.md#kvv2read) | **GET** /{kv-v2_mount_path}/data/{path} | 
[**KvV2ReadConfiguration**](SecretsApi.md#kvv2readconfiguration) | **GET** /{kv-v2_mount_path}/config | Read the backend level settings.
[**KvV2ReadMetadata**](SecretsApi.md#kvv2readmetadata) | **GET** /{kv-v2_mount_path}/metadata/{path} | 
[**KvV2ReadSubkeys**](SecretsApi.md#kvv2readsubkeys) | **GET** /{kv-v2_mount_path}/subkeys/{path} | 
[**KvV2UndeleteVersions**](SecretsApi.md#kvv2undeleteversions) | **POST** /{kv-v2_mount_path}/undelete/{path} | 
[**KvV2Write**](SecretsApi.md#kvv2write) | **POST** /{kv-v2_mount_path}/data/{path} | 
[**KvV2WriteMetadata**](SecretsApi.md#kvv2writemetadata) | **POST** /{kv-v2_mount_path}/metadata/{path} | 
[**LdapConfigure**](SecretsApi.md#ldapconfigure) | **POST** /{ldap_mount_path}/config | 
[**LdapDeleteConfiguration**](SecretsApi.md#ldapdeleteconfiguration) | **DELETE** /{ldap_mount_path}/config | 
[**LdapDeleteDynamicRole**](SecretsApi.md#ldapdeletedynamicrole) | **DELETE** /{ldap_mount_path}/role/{name} | 
[**LdapDeleteStaticRole**](SecretsApi.md#ldapdeletestaticrole) | **DELETE** /{ldap_mount_path}/static-role/{name} | 
[**LdapLibraryCheckIn**](SecretsApi.md#ldaplibrarycheckin) | **POST** /{ldap_mount_path}/library/{name}/check-in | Check service accounts in to the library.
[**LdapLibraryCheckOut**](SecretsApi.md#ldaplibrarycheckout) | **POST** /{ldap_mount_path}/library/{name}/check-out | Check a service account out from the library.
[**LdapLibraryCheckStatus**](SecretsApi.md#ldaplibrarycheckstatus) | **GET** /{ldap_mount_path}/library/{name}/status | Check the status of the service accounts in a library set.
[**LdapLibraryConfigure**](SecretsApi.md#ldaplibraryconfigure) | **POST** /{ldap_mount_path}/library/{name} | Update a library set.
[**LdapLibraryDelete**](SecretsApi.md#ldaplibrarydelete) | **DELETE** /{ldap_mount_path}/library/{name} | Delete a library set.
[**LdapLibraryForceCheckIn**](SecretsApi.md#ldaplibraryforcecheckin) | **POST** /{ldap_mount_path}/library/manage/{name}/check-in | Check service accounts in to the library.
[**LdapLibraryList**](SecretsApi.md#ldaplibrarylist) | **GET** /{ldap_mount_path}/library | 
[**LdapLibraryRead**](SecretsApi.md#ldaplibraryread) | **GET** /{ldap_mount_path}/library/{name} | Read a library set.
[**LdapListDynamicRoles**](SecretsApi.md#ldaplistdynamicroles) | **GET** /{ldap_mount_path}/role | 
[**LdapListStaticRoles**](SecretsApi.md#ldapliststaticroles) | **GET** /{ldap_mount_path}/static-role | 
[**LdapReadConfiguration**](SecretsApi.md#ldapreadconfiguration) | **GET** /{ldap_mount_path}/config | 
[**LdapReadDynamicRole**](SecretsApi.md#ldapreaddynamicrole) | **GET** /{ldap_mount_path}/role/{name} | 
[**LdapReadStaticRole**](SecretsApi.md#ldapreadstaticrole) | **GET** /{ldap_mount_path}/static-role/{name} | 
[**LdapRequestDynamicRoleCredentials**](SecretsApi.md#ldaprequestdynamicrolecredentials) | **GET** /{ldap_mount_path}/creds/{name} | 
[**LdapRequestStaticRoleCredentials**](SecretsApi.md#ldaprequeststaticrolecredentials) | **GET** /{ldap_mount_path}/static-cred/{name} | 
[**LdapRotateRootCredentials**](SecretsApi.md#ldaprotaterootcredentials) | **POST** /{ldap_mount_path}/rotate-root | 
[**LdapRotateStaticRole**](SecretsApi.md#ldaprotatestaticrole) | **POST** /{ldap_mount_path}/rotate-role/{name} | 
[**LdapWriteDynamicRole**](SecretsApi.md#ldapwritedynamicrole) | **POST** /{ldap_mount_path}/role/{name} | 
[**LdapWriteStaticRole**](SecretsApi.md#ldapwritestaticrole) | **POST** /{ldap_mount_path}/static-role/{name} | 
[**MongoDbAtlasConfigure**](SecretsApi.md#mongodbatlasconfigure) | **POST** /{mongodbatlas_mount_path}/config | 
[**MongoDbAtlasDeleteRole**](SecretsApi.md#mongodbatlasdeleterole) | **DELETE** /{mongodbatlas_mount_path}/roles/{name} | Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
[**MongoDbAtlasGenerateCredentials**](SecretsApi.md#mongodbatlasgeneratecredentials) | **GET** /{mongodbatlas_mount_path}/creds/{name} | 
[**MongoDbAtlasGenerateCredentials2**](SecretsApi.md#mongodbatlasgeneratecredentials2) | **POST** /{mongodbatlas_mount_path}/creds/{name} | 
[**MongoDbAtlasListRoles**](SecretsApi.md#mongodbatlaslistroles) | **GET** /{mongodbatlas_mount_path}/roles | List the existing roles in this backend
[**MongoDbAtlasReadConfiguration**](SecretsApi.md#mongodbatlasreadconfiguration) | **GET** /{mongodbatlas_mount_path}/config | 
[**MongoDbAtlasReadRole**](SecretsApi.md#mongodbatlasreadrole) | **GET** /{mongodbatlas_mount_path}/roles/{name} | Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
[**MongoDbAtlasWriteRole**](SecretsApi.md#mongodbatlaswriterole) | **POST** /{mongodbatlas_mount_path}/roles/{name} | Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
[**NomadConfigureAccess**](SecretsApi.md#nomadconfigureaccess) | **POST** /{nomad_mount_path}/config/access | 
[**NomadConfigureLease**](SecretsApi.md#nomadconfigurelease) | **POST** /{nomad_mount_path}/config/lease | 
[**NomadDeleteAccessConfiguration**](SecretsApi.md#nomaddeleteaccessconfiguration) | **DELETE** /{nomad_mount_path}/config/access | 
[**NomadDeleteLeaseConfiguration**](SecretsApi.md#nomaddeleteleaseconfiguration) | **DELETE** /{nomad_mount_path}/config/lease | 
[**NomadDeleteRole**](SecretsApi.md#nomaddeleterole) | **DELETE** /{nomad_mount_path}/role/{name} | 
[**NomadGenerateCredentials**](SecretsApi.md#nomadgeneratecredentials) | **GET** /{nomad_mount_path}/creds/{name} | 
[**NomadListRoles**](SecretsApi.md#nomadlistroles) | **GET** /{nomad_mount_path}/role | 
[**NomadReadAccessConfiguration**](SecretsApi.md#nomadreadaccessconfiguration) | **GET** /{nomad_mount_path}/config/access | 
[**NomadReadLeaseConfiguration**](SecretsApi.md#nomadreadleaseconfiguration) | **GET** /{nomad_mount_path}/config/lease | 
[**NomadReadRole**](SecretsApi.md#nomadreadrole) | **GET** /{nomad_mount_path}/role/{name} | 
[**NomadWriteRole**](SecretsApi.md#nomadwriterole) | **POST** /{nomad_mount_path}/role/{name} | 
[**PkiConfigureAutoTidy**](SecretsApi.md#pkiconfigureautotidy) | **POST** /{pki_mount_path}/config/auto-tidy | 
[**PkiConfigureCa**](SecretsApi.md#pkiconfigureca) | **POST** /{pki_mount_path}/config/ca | 
[**PkiConfigureCluster**](SecretsApi.md#pkiconfigurecluster) | **POST** /{pki_mount_path}/config/cluster | 
[**PkiConfigureCrl**](SecretsApi.md#pkiconfigurecrl) | **POST** /{pki_mount_path}/config/crl | 
[**PkiConfigureIssuers**](SecretsApi.md#pkiconfigureissuers) | **POST** /{pki_mount_path}/config/issuers | 
[**PkiConfigureKeys**](SecretsApi.md#pkiconfigurekeys) | **POST** /{pki_mount_path}/config/keys | 
[**PkiConfigureUrls**](SecretsApi.md#pkiconfigureurls) | **POST** /{pki_mount_path}/config/urls | 
[**PkiCrossSignIntermediate**](SecretsApi.md#pkicrosssignintermediate) | **POST** /{pki_mount_path}/intermediate/cross-sign | 
[**PkiDeleteIssuer**](SecretsApi.md#pkideleteissuer) | **DELETE** /{pki_mount_path}/issuer/{issuer_ref} | 
[**PkiDeleteKey**](SecretsApi.md#pkideletekey) | **DELETE** /{pki_mount_path}/key/{key_ref} | 
[**PkiDeleteRole**](SecretsApi.md#pkideleterole) | **DELETE** /{pki_mount_path}/roles/{name} | 
[**PkiDeleteRoot**](SecretsApi.md#pkideleteroot) | **DELETE** /{pki_mount_path}/root | 
[**PkiGenerateExportedKey**](SecretsApi.md#pkigenerateexportedkey) | **POST** /{pki_mount_path}/keys/generate/exported | 
[**PkiGenerateIntermediate**](SecretsApi.md#pkigenerateintermediate) | **POST** /{pki_mount_path}/intermediate/generate/{exported} | 
[**PkiGenerateInternalKey**](SecretsApi.md#pkigenerateinternalkey) | **POST** /{pki_mount_path}/keys/generate/internal | 
[**PkiGenerateKmsKey**](SecretsApi.md#pkigeneratekmskey) | **POST** /{pki_mount_path}/keys/generate/kms | 
[**PkiGenerateRoot**](SecretsApi.md#pkigenerateroot) | **POST** /{pki_mount_path}/root/generate/{exported} | 
[**PkiImportKey**](SecretsApi.md#pkiimportkey) | **POST** /{pki_mount_path}/keys/import | 
[**PkiIssueWithRole**](SecretsApi.md#pkiissuewithrole) | **POST** /{pki_mount_path}/issue/{role} | 
[**PkiIssuerIssueWithRole**](SecretsApi.md#pkiissuerissuewithrole) | **POST** /{pki_mount_path}/issuer/{issuer_ref}/issue/{role} | 
[**PkiIssuerReadCrl**](SecretsApi.md#pkiissuerreadcrl) | **GET** /{pki_mount_path}/issuer/{issuer_ref}/crl | 
[**PkiIssuerReadCrlDelta**](SecretsApi.md#pkiissuerreadcrldelta) | **GET** /{pki_mount_path}/issuer/{issuer_ref}/crl/delta | 
[**PkiIssuerReadCrlDeltaDer**](SecretsApi.md#pkiissuerreadcrldeltader) | **GET** /{pki_mount_path}/issuer/{issuer_ref}/crl/delta/der | 
[**PkiIssuerReadCrlDeltaPem**](SecretsApi.md#pkiissuerreadcrldeltapem) | **GET** /{pki_mount_path}/issuer/{issuer_ref}/crl/delta/pem | 
[**PkiIssuerReadCrlDer**](SecretsApi.md#pkiissuerreadcrlder) | **GET** /{pki_mount_path}/issuer/{issuer_ref}/crl/der | 
[**PkiIssuerReadCrlPem**](SecretsApi.md#pkiissuerreadcrlpem) | **GET** /{pki_mount_path}/issuer/{issuer_ref}/crl/pem | 
[**PkiIssuerResignCrls**](SecretsApi.md#pkiissuerresigncrls) | **POST** /{pki_mount_path}/issuer/{issuer_ref}/resign-crls | 
[**PkiIssuerSignIntermediate**](SecretsApi.md#pkiissuersignintermediate) | **POST** /{pki_mount_path}/issuer/{issuer_ref}/sign-intermediate | 
[**PkiIssuerSignRevocationList**](SecretsApi.md#pkiissuersignrevocationlist) | **POST** /{pki_mount_path}/issuer/{issuer_ref}/sign-revocation-list | 
[**PkiIssuerSignSelfIssued**](SecretsApi.md#pkiissuersignselfissued) | **POST** /{pki_mount_path}/issuer/{issuer_ref}/sign-self-issued | 
[**PkiIssuerSignVerbatim**](SecretsApi.md#pkiissuersignverbatim) | **POST** /{pki_mount_path}/issuer/{issuer_ref}/sign-verbatim | 
[**PkiIssuerSignVerbatimWithRole**](SecretsApi.md#pkiissuersignverbatimwithrole) | **POST** /{pki_mount_path}/issuer/{issuer_ref}/sign-verbatim/{role} | 
[**PkiIssuerSignWithRole**](SecretsApi.md#pkiissuersignwithrole) | **POST** /{pki_mount_path}/issuer/{issuer_ref}/sign/{role} | 
[**PkiIssuersGenerateIntermediate**](SecretsApi.md#pkiissuersgenerateintermediate) | **POST** /{pki_mount_path}/issuers/generate/intermediate/{exported} | 
[**PkiIssuersGenerateRoot**](SecretsApi.md#pkiissuersgenerateroot) | **POST** /{pki_mount_path}/issuers/generate/root/{exported} | 
[**PkiIssuersImportBundle**](SecretsApi.md#pkiissuersimportbundle) | **POST** /{pki_mount_path}/issuers/import/bundle | 
[**PkiIssuersImportCert**](SecretsApi.md#pkiissuersimportcert) | **POST** /{pki_mount_path}/issuers/import/cert | 
[**PkiIssuersRotateRoot**](SecretsApi.md#pkiissuersrotateroot) | **POST** /{pki_mount_path}/root/rotate/{exported} | 
[**PkiListCerts**](SecretsApi.md#pkilistcerts) | **GET** /{pki_mount_path}/certs | 
[**PkiListIssuers**](SecretsApi.md#pkilistissuers) | **GET** /{pki_mount_path}/issuers | 
[**PkiListKeys**](SecretsApi.md#pkilistkeys) | **GET** /{pki_mount_path}/keys | 
[**PkiListRevokedCerts**](SecretsApi.md#pkilistrevokedcerts) | **GET** /{pki_mount_path}/certs/revoked | 
[**PkiListRoles**](SecretsApi.md#pkilistroles) | **GET** /{pki_mount_path}/roles | 
[**PkiQueryOcsp**](SecretsApi.md#pkiqueryocsp) | **POST** /{pki_mount_path}/ocsp | 
[**PkiQueryOcspWithGetReq**](SecretsApi.md#pkiqueryocspwithgetreq) | **GET** /{pki_mount_path}/ocsp/{req} | 
[**PkiReadAutoTidyConfiguration**](SecretsApi.md#pkireadautotidyconfiguration) | **GET** /{pki_mount_path}/config/auto-tidy | 
[**PkiReadCaChainPem**](SecretsApi.md#pkireadcachainpem) | **GET** /{pki_mount_path}/ca_chain | 
[**PkiReadCaDer**](SecretsApi.md#pkireadcader) | **GET** /{pki_mount_path}/ca | 
[**PkiReadCaPem**](SecretsApi.md#pkireadcapem) | **GET** /{pki_mount_path}/ca/pem | 
[**PkiReadCert**](SecretsApi.md#pkireadcert) | **GET** /{pki_mount_path}/cert/{serial} | 
[**PkiReadCertCaChain**](SecretsApi.md#pkireadcertcachain) | **GET** /{pki_mount_path}/cert/ca_chain | 
[**PkiReadCertCrl**](SecretsApi.md#pkireadcertcrl) | **GET** /{pki_mount_path}/cert/crl | 
[**PkiReadCertDeltaCrl**](SecretsApi.md#pkireadcertdeltacrl) | **GET** /{pki_mount_path}/cert/delta-crl | 
[**PkiReadCertRawDer**](SecretsApi.md#pkireadcertrawder) | **GET** /{pki_mount_path}/cert/{serial}/raw | 
[**PkiReadCertRawPem**](SecretsApi.md#pkireadcertrawpem) | **GET** /{pki_mount_path}/cert/{serial}/raw/pem | 
[**PkiReadClusterConfiguration**](SecretsApi.md#pkireadclusterconfiguration) | **GET** /{pki_mount_path}/config/cluster | 
[**PkiReadCrlConfiguration**](SecretsApi.md#pkireadcrlconfiguration) | **GET** /{pki_mount_path}/config/crl | 
[**PkiReadCrlDelta**](SecretsApi.md#pkireadcrldelta) | **GET** /{pki_mount_path}/crl/delta | 
[**PkiReadCrlDeltaPem**](SecretsApi.md#pkireadcrldeltapem) | **GET** /{pki_mount_path}/crl/delta/pem | 
[**PkiReadCrlDer**](SecretsApi.md#pkireadcrlder) | **GET** /{pki_mount_path}/crl | 
[**PkiReadCrlPem**](SecretsApi.md#pkireadcrlpem) | **GET** /{pki_mount_path}/crl/pem | 
[**PkiReadIssuer**](SecretsApi.md#pkireadissuer) | **GET** /{pki_mount_path}/issuer/{issuer_ref} | 
[**PkiReadIssuerDer**](SecretsApi.md#pkireadissuerder) | **GET** /{pki_mount_path}/issuer/{issuer_ref}/der | 
[**PkiReadIssuerJson**](SecretsApi.md#pkireadissuerjson) | **GET** /{pki_mount_path}/issuer/{issuer_ref}/json | 
[**PkiReadIssuerPem**](SecretsApi.md#pkireadissuerpem) | **GET** /{pki_mount_path}/issuer/{issuer_ref}/pem | 
[**PkiReadIssuersConfiguration**](SecretsApi.md#pkireadissuersconfiguration) | **GET** /{pki_mount_path}/config/issuers | 
[**PkiReadKey**](SecretsApi.md#pkireadkey) | **GET** /{pki_mount_path}/key/{key_ref} | 
[**PkiReadKeysConfiguration**](SecretsApi.md#pkireadkeysconfiguration) | **GET** /{pki_mount_path}/config/keys | 
[**PkiReadRole**](SecretsApi.md#pkireadrole) | **GET** /{pki_mount_path}/roles/{name} | 
[**PkiReadUrlsConfiguration**](SecretsApi.md#pkireadurlsconfiguration) | **GET** /{pki_mount_path}/config/urls | 
[**PkiReplaceRoot**](SecretsApi.md#pkireplaceroot) | **POST** /{pki_mount_path}/root/replace | 
[**PkiRevoke**](SecretsApi.md#pkirevoke) | **POST** /{pki_mount_path}/revoke | 
[**PkiRevokeIssuer**](SecretsApi.md#pkirevokeissuer) | **POST** /{pki_mount_path}/issuer/{issuer_ref}/revoke | 
[**PkiRevokeWithKey**](SecretsApi.md#pkirevokewithkey) | **POST** /{pki_mount_path}/revoke-with-key | 
[**PkiRootSignIntermediate**](SecretsApi.md#pkirootsignintermediate) | **POST** /{pki_mount_path}/root/sign-intermediate | 
[**PkiRootSignSelfIssued**](SecretsApi.md#pkirootsignselfissued) | **POST** /{pki_mount_path}/root/sign-self-issued | 
[**PkiRotateCrl**](SecretsApi.md#pkirotatecrl) | **GET** /{pki_mount_path}/crl/rotate | 
[**PkiRotateDeltaCrl**](SecretsApi.md#pkirotatedeltacrl) | **GET** /{pki_mount_path}/crl/rotate-delta | 
[**PkiSetSignedIntermediate**](SecretsApi.md#pkisetsignedintermediate) | **POST** /{pki_mount_path}/intermediate/set-signed | 
[**PkiSignVerbatim**](SecretsApi.md#pkisignverbatim) | **POST** /{pki_mount_path}/sign-verbatim | 
[**PkiSignVerbatimWithRole**](SecretsApi.md#pkisignverbatimwithrole) | **POST** /{pki_mount_path}/sign-verbatim/{role} | 
[**PkiSignWithRole**](SecretsApi.md#pkisignwithrole) | **POST** /{pki_mount_path}/sign/{role} | 
[**PkiTidy**](SecretsApi.md#pkitidy) | **POST** /{pki_mount_path}/tidy | 
[**PkiTidyCancel**](SecretsApi.md#pkitidycancel) | **POST** /{pki_mount_path}/tidy-cancel | 
[**PkiTidyStatus**](SecretsApi.md#pkitidystatus) | **GET** /{pki_mount_path}/tidy-status | 
[**PkiWriteIssuer**](SecretsApi.md#pkiwriteissuer) | **POST** /{pki_mount_path}/issuer/{issuer_ref} | 
[**PkiWriteKey**](SecretsApi.md#pkiwritekey) | **POST** /{pki_mount_path}/key/{key_ref} | 
[**PkiWriteRole**](SecretsApi.md#pkiwriterole) | **POST** /{pki_mount_path}/roles/{name} | 
[**RabbitMqConfigureConnection**](SecretsApi.md#rabbitmqconfigureconnection) | **POST** /{rabbitmq_mount_path}/config/connection | Configure the connection URI, username, and password to talk to RabbitMQ management HTTP API.
[**RabbitMqConfigureLease**](SecretsApi.md#rabbitmqconfigurelease) | **POST** /{rabbitmq_mount_path}/config/lease | 
[**RabbitMqDeleteRole**](SecretsApi.md#rabbitmqdeleterole) | **DELETE** /{rabbitmq_mount_path}/roles/{name} | Manage the roles that can be created with this backend.
[**RabbitMqListRoles**](SecretsApi.md#rabbitmqlistroles) | **GET** /{rabbitmq_mount_path}/roles | Manage the roles that can be created with this backend.
[**RabbitMqReadLeaseConfiguration**](SecretsApi.md#rabbitmqreadleaseconfiguration) | **GET** /{rabbitmq_mount_path}/config/lease | 
[**RabbitMqReadRole**](SecretsApi.md#rabbitmqreadrole) | **GET** /{rabbitmq_mount_path}/roles/{name} | Manage the roles that can be created with this backend.
[**RabbitMqRequestCredentials**](SecretsApi.md#rabbitmqrequestcredentials) | **GET** /{rabbitmq_mount_path}/creds/{name} | Request RabbitMQ credentials for a certain role.
[**RabbitMqWriteRole**](SecretsApi.md#rabbitmqwriterole) | **POST** /{rabbitmq_mount_path}/roles/{name} | Manage the roles that can be created with this backend.
[**SshConfigureCa**](SecretsApi.md#sshconfigureca) | **POST** /{ssh_mount_path}/config/ca | 
[**SshConfigureZeroAddress**](SecretsApi.md#sshconfigurezeroaddress) | **POST** /{ssh_mount_path}/config/zeroaddress | 
[**SshDeleteCaConfiguration**](SecretsApi.md#sshdeletecaconfiguration) | **DELETE** /{ssh_mount_path}/config/ca | 
[**SshDeleteRole**](SecretsApi.md#sshdeleterole) | **DELETE** /{ssh_mount_path}/roles/{role} | Manage the &#x27;roles&#x27; that can be created with this backend.
[**SshDeleteZeroAddressConfiguration**](SecretsApi.md#sshdeletezeroaddressconfiguration) | **DELETE** /{ssh_mount_path}/config/zeroaddress | 
[**SshGenerateCredentials**](SecretsApi.md#sshgeneratecredentials) | **POST** /{ssh_mount_path}/creds/{role} | Creates a credential for establishing SSH connection with the remote host.
[**SshIssueCertificate**](SecretsApi.md#sshissuecertificate) | **POST** /{ssh_mount_path}/issue/{role} | 
[**SshListRoles**](SecretsApi.md#sshlistroles) | **GET** /{ssh_mount_path}/roles | Manage the &#x27;roles&#x27; that can be created with this backend.
[**SshListRolesByIp**](SecretsApi.md#sshlistrolesbyip) | **POST** /{ssh_mount_path}/lookup | List all the roles associated with the given IP address.
[**SshReadCaConfiguration**](SecretsApi.md#sshreadcaconfiguration) | **GET** /{ssh_mount_path}/config/ca | 
[**SshReadPublicKey**](SecretsApi.md#sshreadpublickey) | **GET** /{ssh_mount_path}/public_key | Retrieve the public key.
[**SshReadRole**](SecretsApi.md#sshreadrole) | **GET** /{ssh_mount_path}/roles/{role} | Manage the &#x27;roles&#x27; that can be created with this backend.
[**SshReadZeroAddressConfiguration**](SecretsApi.md#sshreadzeroaddressconfiguration) | **GET** /{ssh_mount_path}/config/zeroaddress | 
[**SshSignCertificate**](SecretsApi.md#sshsigncertificate) | **POST** /{ssh_mount_path}/sign/{role} | Request signing an SSH key using a certain role with the provided details.
[**SshTidyDynamicHostKeys**](SecretsApi.md#sshtidydynamichostkeys) | **DELETE** /{ssh_mount_path}/tidy/dynamic-keys | This endpoint removes the stored host keys used for the removed Dynamic Key feature, if present.
[**SshVerifyOtp**](SecretsApi.md#sshverifyotp) | **POST** /{ssh_mount_path}/verify | Validate the OTP provided by Vault SSH Agent.
[**SshWriteRole**](SecretsApi.md#sshwriterole) | **POST** /{ssh_mount_path}/roles/{role} | Manage the &#x27;roles&#x27; that can be created with this backend.
[**TerraformCloudConfigure**](SecretsApi.md#terraformcloudconfigure) | **POST** /{terraform_mount_path}/config | 
[**TerraformCloudDeleteConfiguration**](SecretsApi.md#terraformclouddeleteconfiguration) | **DELETE** /{terraform_mount_path}/config | 
[**TerraformCloudDeleteRole**](SecretsApi.md#terraformclouddeleterole) | **DELETE** /{terraform_mount_path}/role/{name} | 
[**TerraformCloudGenerateCredentials**](SecretsApi.md#terraformcloudgeneratecredentials) | **GET** /{terraform_mount_path}/creds/{name} | 
[**TerraformCloudGenerateCredentials2**](SecretsApi.md#terraformcloudgeneratecredentials2) | **POST** /{terraform_mount_path}/creds/{name} | 
[**TerraformCloudListRoles**](SecretsApi.md#terraformcloudlistroles) | **GET** /{terraform_mount_path}/role | 
[**TerraformCloudReadConfiguration**](SecretsApi.md#terraformcloudreadconfiguration) | **GET** /{terraform_mount_path}/config | 
[**TerraformCloudReadRole**](SecretsApi.md#terraformcloudreadrole) | **GET** /{terraform_mount_path}/role/{name} | 
[**TerraformCloudRotateRole**](SecretsApi.md#terraformcloudrotaterole) | **POST** /{terraform_mount_path}/rotate-role/{name} | 
[**TerraformCloudWriteRole**](SecretsApi.md#terraformcloudwriterole) | **POST** /{terraform_mount_path}/role/{name} | 
[**TotpCreateKey**](SecretsApi.md#totpcreatekey) | **POST** /{totp_mount_path}/keys/{name} | 
[**TotpDeleteKey**](SecretsApi.md#totpdeletekey) | **DELETE** /{totp_mount_path}/keys/{name} | 
[**TotpGenerateCode**](SecretsApi.md#totpgeneratecode) | **GET** /{totp_mount_path}/code/{name} | 
[**TotpListKeys**](SecretsApi.md#totplistkeys) | **GET** /{totp_mount_path}/keys | Manage the keys that can be created with this backend.
[**TotpReadKey**](SecretsApi.md#totpreadkey) | **GET** /{totp_mount_path}/keys/{name} | 
[**TotpValidateCode**](SecretsApi.md#totpvalidatecode) | **POST** /{totp_mount_path}/code/{name} | 
[**TransitBackUpKey**](SecretsApi.md#transitbackupkey) | **GET** /{transit_mount_path}/backup/{name} | Backup the named key
[**TransitConfigureCache**](SecretsApi.md#transitconfigurecache) | **POST** /{transit_mount_path}/cache-config | Configures a new cache of the specified size
[**TransitConfigureKey**](SecretsApi.md#transitconfigurekey) | **POST** /{transit_mount_path}/keys/{name}/config | Configure a named encryption key
[**TransitConfigureKeys**](SecretsApi.md#transitconfigurekeys) | **POST** /{transit_mount_path}/config/keys | 
[**TransitCreateKey**](SecretsApi.md#transitcreatekey) | **POST** /{transit_mount_path}/keys/{name} | 
[**TransitDecrypt**](SecretsApi.md#transitdecrypt) | **POST** /{transit_mount_path}/decrypt/{name} | Decrypt a ciphertext value using a named key
[**TransitDeleteKey**](SecretsApi.md#transitdeletekey) | **DELETE** /{transit_mount_path}/keys/{name} | 
[**TransitEncrypt**](SecretsApi.md#transitencrypt) | **POST** /{transit_mount_path}/encrypt/{name} | Encrypt a plaintext value or a batch of plaintext blocks using a named key
[**TransitExportKey**](SecretsApi.md#transitexportkey) | **GET** /{transit_mount_path}/export/{type}/{name} | Export named encryption or signing key
[**TransitExportKeyVersion**](SecretsApi.md#transitexportkeyversion) | **GET** /{transit_mount_path}/export/{type}/{name}/{version} | Export named encryption or signing key
[**TransitGenerateDataKey**](SecretsApi.md#transitgeneratedatakey) | **POST** /{transit_mount_path}/datakey/{plaintext}/{name} | Generate a data key
[**TransitGenerateHmac**](SecretsApi.md#transitgeneratehmac) | **POST** /{transit_mount_path}/hmac/{name} | Generate an HMAC for input data using the named key
[**TransitGenerateHmacWithAlgorithm**](SecretsApi.md#transitgeneratehmacwithalgorithm) | **POST** /{transit_mount_path}/hmac/{name}/{urlalgorithm} | Generate an HMAC for input data using the named key
[**TransitGenerateRandom**](SecretsApi.md#transitgeneraterandom) | **POST** /{transit_mount_path}/random | Generate random bytes
[**TransitGenerateRandomWithBytes**](SecretsApi.md#transitgeneraterandomwithbytes) | **POST** /{transit_mount_path}/random/{urlbytes} | Generate random bytes
[**TransitGenerateRandomWithSource**](SecretsApi.md#transitgeneraterandomwithsource) | **POST** /{transit_mount_path}/random/{source} | Generate random bytes
[**TransitGenerateRandomWithSourceAndBytes**](SecretsApi.md#transitgeneraterandomwithsourceandbytes) | **POST** /{transit_mount_path}/random/{source}/{urlbytes} | Generate random bytes
[**TransitHash**](SecretsApi.md#transithash) | **POST** /{transit_mount_path}/hash | Generate a hash sum for input data
[**TransitHashWithAlgorithm**](SecretsApi.md#transithashwithalgorithm) | **POST** /{transit_mount_path}/hash/{urlalgorithm} | Generate a hash sum for input data
[**TransitImportKey**](SecretsApi.md#transitimportkey) | **POST** /{transit_mount_path}/keys/{name}/import | Imports an externally-generated key into a new transit key
[**TransitImportKeyVersion**](SecretsApi.md#transitimportkeyversion) | **POST** /{transit_mount_path}/keys/{name}/import_version | Imports an externally-generated key into an existing imported key
[**TransitListKeys**](SecretsApi.md#transitlistkeys) | **GET** /{transit_mount_path}/keys | Managed named encryption keys
[**TransitReadCacheConfiguration**](SecretsApi.md#transitreadcacheconfiguration) | **GET** /{transit_mount_path}/cache-config | Returns the size of the active cache
[**TransitReadKey**](SecretsApi.md#transitreadkey) | **GET** /{transit_mount_path}/keys/{name} | 
[**TransitReadKeysConfiguration**](SecretsApi.md#transitreadkeysconfiguration) | **GET** /{transit_mount_path}/config/keys | 
[**TransitReadWrappingKey**](SecretsApi.md#transitreadwrappingkey) | **GET** /{transit_mount_path}/wrapping_key | Returns the public key to use for wrapping imported keys
[**TransitRestoreAndRenameKey**](SecretsApi.md#transitrestoreandrenamekey) | **POST** /{transit_mount_path}/restore/{name} | Restore the named key
[**TransitRestoreKey**](SecretsApi.md#transitrestorekey) | **POST** /{transit_mount_path}/restore | Restore the named key
[**TransitRewrap**](SecretsApi.md#transitrewrap) | **POST** /{transit_mount_path}/rewrap/{name} | Rewrap ciphertext
[**TransitRotateKey**](SecretsApi.md#transitrotatekey) | **POST** /{transit_mount_path}/keys/{name}/rotate | Rotate named encryption key
[**TransitSign**](SecretsApi.md#transitsign) | **POST** /{transit_mount_path}/sign/{name} | Generate a signature for input data using the named key
[**TransitSignWithAlgorithm**](SecretsApi.md#transitsignwithalgorithm) | **POST** /{transit_mount_path}/sign/{name}/{urlalgorithm} | Generate a signature for input data using the named key
[**TransitTrimKey**](SecretsApi.md#transittrimkey) | **POST** /{transit_mount_path}/keys/{name}/trim | Trim key versions of a named key
[**TransitVerify**](SecretsApi.md#transitverify) | **POST** /{transit_mount_path}/verify/{name} | Verify a signature or HMAC for input data created using the named key
[**TransitVerifyWithAlgorithm**](SecretsApi.md#transitverifywithalgorithm) | **POST** /{transit_mount_path}/verify/{name}/{urlalgorithm} | Verify a signature or HMAC for input data created using the named key




<a name="alicloudconfigure"></a>
# **AliCloudConfigure**

> void AliCloudConfigure (string alicloudMountPath, AliCloudConfigureRequest aliCloudConfigureRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AliCloudConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var alicloudMountPath = "\"alicloud\"";  // string | Path that the backend was mounted at (default to "alicloud")
            
            
            
            
            
            var aliCloudConfigureRequest = new AliCloudConfigureRequest(); // AliCloudConfigureRequest | 
            
            

            try
            {
                

                apiInstance.AliCloudConfigure(string alicloudMountPath, AliCloudConfigureRequest aliCloudConfigureRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AliCloudConfigure: " + e.Message );
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
 **aliCloudConfigureRequest** | [**AliCloudConfigureRequest**](AliCloudConfigureRequest.md)|  | 


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


<a name="aliclouddeleteconfiguration"></a>
# **AliCloudDeleteConfiguration**

> void AliCloudDeleteConfiguration (string alicloudMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AliCloudDeleteConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var alicloudMountPath = "\"alicloud\"";  // string | Path that the backend was mounted at (default to "alicloud")
            
            
            

            try
            {
                

                apiInstance.AliCloudDeleteConfiguration(string alicloudMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AliCloudDeleteConfiguration: " + e.Message );
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


### Return type

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


<a name="aliclouddeleterole"></a>
# **AliCloudDeleteRole**

> void AliCloudDeleteRole (string name, string alicloudMountPath, TimeSpan? wrapTTL = null)

Read, write and reference policies and roles that API keys or STS credentials can be made for.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AliCloudDeleteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | The name of the role.
            
            
            
            
            var alicloudMountPath = "\"alicloud\"";  // string | Path that the backend was mounted at (default to "alicloud")
            
            
            

            try
            {
                
                // Read, write and reference policies and roles that API keys or STS credentials can be made for.
                

                apiInstance.AliCloudDeleteRole(string name, string alicloudMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AliCloudDeleteRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the role. | 
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


<a name="alicloudgeneratecredentials"></a>
# **AliCloudGenerateCredentials**

> void AliCloudGenerateCredentials (string name, string alicloudMountPath, TimeSpan? wrapTTL = null)

Generate an API key or STS credential using the given role's configuration.'

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AliCloudGenerateCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | The name of the role.
            
            
            
            
            var alicloudMountPath = "\"alicloud\"";  // string | Path that the backend was mounted at (default to "alicloud")
            
            
            

            try
            {
                
                // Generate an API key or STS credential using the given role's configuration.'
                

                apiInstance.AliCloudGenerateCredentials(string name, string alicloudMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AliCloudGenerateCredentials: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the role. | 
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


<a name="alicloudlistroles"></a>
# **AliCloudListRoles**

> void AliCloudListRoles (string alicloudMountPath, TimeSpan? wrapTTL = null)

List the existing roles in this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AliCloudListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var alicloudMountPath = "\"alicloud\"";  // string | Path that the backend was mounted at (default to "alicloud")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // List the existing roles in this backend.
                

                apiInstance.AliCloudListRoles(string alicloudMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AliCloudListRoles: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="alicloudreadconfiguration"></a>
# **AliCloudReadConfiguration**

> void AliCloudReadConfiguration (string alicloudMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AliCloudReadConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var alicloudMountPath = "\"alicloud\"";  // string | Path that the backend was mounted at (default to "alicloud")
            
            
            

            try
            {
                

                apiInstance.AliCloudReadConfiguration(string alicloudMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AliCloudReadConfiguration: " + e.Message );
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


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="alicloudreadrole"></a>
# **AliCloudReadRole**

> void AliCloudReadRole (string name, string alicloudMountPath, TimeSpan? wrapTTL = null)

Read, write and reference policies and roles that API keys or STS credentials can be made for.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AliCloudReadRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | The name of the role.
            
            
            
            
            var alicloudMountPath = "\"alicloud\"";  // string | Path that the backend was mounted at (default to "alicloud")
            
            
            

            try
            {
                
                // Read, write and reference policies and roles that API keys or STS credentials can be made for.
                

                apiInstance.AliCloudReadRole(string name, string alicloudMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AliCloudReadRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the role. | 
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


<a name="alicloudwriterole"></a>
# **AliCloudWriteRole**

> void AliCloudWriteRole (string name, string alicloudMountPath, AliCloudWriteRoleRequest aliCloudWriteRoleRequest, TimeSpan? wrapTTL = null)

Read, write and reference policies and roles that API keys or STS credentials can be made for.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AliCloudWriteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | The name of the role.
            
            
            
            
            var alicloudMountPath = "\"alicloud\"";  // string | Path that the backend was mounted at (default to "alicloud")
            
            
            
            
            
            var aliCloudWriteRoleRequest = new AliCloudWriteRoleRequest(); // AliCloudWriteRoleRequest | 
            
            

            try
            {
                
                // Read, write and reference policies and roles that API keys or STS credentials can be made for.
                

                apiInstance.AliCloudWriteRole(string name, string alicloudMountPath, AliCloudWriteRoleRequest aliCloudWriteRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AliCloudWriteRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the role. | 
 **alicloudMountPath** | **string**| Path that the backend was mounted at | [default to &quot;alicloud&quot;]
 **aliCloudWriteRoleRequest** | [**AliCloudWriteRoleRequest**](AliCloudWriteRoleRequest.md)|  | 


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


<a name="awsconfigurelease"></a>
# **AwsConfigureLease**

> void AwsConfigureLease (string awsMountPath, AwsConfigureLeaseRequest awsConfigureLeaseRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsConfigureLeaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            
            var awsConfigureLeaseRequest = new AwsConfigureLeaseRequest(); // AwsConfigureLeaseRequest | 
            
            

            try
            {
                

                apiInstance.AwsConfigureLease(string awsMountPath, AwsConfigureLeaseRequest awsConfigureLeaseRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AwsConfigureLease: " + e.Message );
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
 **awsConfigureLeaseRequest** | [**AwsConfigureLeaseRequest**](AwsConfigureLeaseRequest.md)|  | 


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


<a name="awsconfigurerootiamcredentials"></a>
# **AwsConfigureRootIamCredentials**

> void AwsConfigureRootIamCredentials (string awsMountPath, AwsConfigureRootIamCredentialsRequest awsConfigureRootIamCredentialsRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsConfigureRootIamCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            
            var awsConfigureRootIamCredentialsRequest = new AwsConfigureRootIamCredentialsRequest(); // AwsConfigureRootIamCredentialsRequest | 
            
            

            try
            {
                

                apiInstance.AwsConfigureRootIamCredentials(string awsMountPath, AwsConfigureRootIamCredentialsRequest awsConfigureRootIamCredentialsRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AwsConfigureRootIamCredentials: " + e.Message );
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
 **awsConfigureRootIamCredentialsRequest** | [**AwsConfigureRootIamCredentialsRequest**](AwsConfigureRootIamCredentialsRequest.md)|  | 


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


<a name="awsdeleterole"></a>
# **AwsDeleteRole**

> void AwsDeleteRole (string name, string awsMountPath, TimeSpan? wrapTTL = null)

Read, write and reference IAM policies that access keys can be made for.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsDeleteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the policy
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                
                // Read, write and reference IAM policies that access keys can be made for.
                

                apiInstance.AwsDeleteRole(string name, string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AwsDeleteRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the policy | 
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


<a name="awsgeneratecredentials"></a>
# **AwsGenerateCredentials**

> void AwsGenerateCredentials (string name, string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsGenerateCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsGenerateCredentials(string name, string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AwsGenerateCredentials: " + e.Message );
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


<a name="awsgeneratecredentials2"></a>
# **AwsGenerateCredentials2**

> void AwsGenerateCredentials2 (string name, string awsMountPath, AwsGenerateCredentials2Request awsGenerateCredentials2Request, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsGenerateCredentials2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            
            var awsGenerateCredentials2Request = new AwsGenerateCredentials2Request(); // AwsGenerateCredentials2Request | 
            
            

            try
            {
                

                apiInstance.AwsGenerateCredentials2(string name, string awsMountPath, AwsGenerateCredentials2Request awsGenerateCredentials2Request, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AwsGenerateCredentials2: " + e.Message );
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
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]
 **awsGenerateCredentials2Request** | [**AwsGenerateCredentials2Request**](AwsGenerateCredentials2Request.md)|  | 


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


<a name="awsgeneratestscredentials"></a>
# **AwsGenerateStsCredentials**

> void AwsGenerateStsCredentials (string name, string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsGenerateStsCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsGenerateStsCredentials(string name, string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AwsGenerateStsCredentials: " + e.Message );
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


<a name="awsgeneratestscredentials2"></a>
# **AwsGenerateStsCredentials2**

> void AwsGenerateStsCredentials2 (string name, string awsMountPath, AwsGenerateStsCredentials2Request awsGenerateStsCredentials2Request, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsGenerateStsCredentials2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            
            var awsGenerateStsCredentials2Request = new AwsGenerateStsCredentials2Request(); // AwsGenerateStsCredentials2Request | 
            
            

            try
            {
                

                apiInstance.AwsGenerateStsCredentials2(string name, string awsMountPath, AwsGenerateStsCredentials2Request awsGenerateStsCredentials2Request, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AwsGenerateStsCredentials2: " + e.Message );
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
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]
 **awsGenerateStsCredentials2Request** | [**AwsGenerateStsCredentials2Request**](AwsGenerateStsCredentials2Request.md)|  | 


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


<a name="awslistroles"></a>
# **AwsListRoles**

> void AwsListRoles (string awsMountPath, TimeSpan? wrapTTL = null)

List the existing roles in this backend

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // List the existing roles in this backend
                

                apiInstance.AwsListRoles(string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AwsListRoles: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="awsreadleaseconfiguration"></a>
# **AwsReadLeaseConfiguration**

> void AwsReadLeaseConfiguration (string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsReadLeaseConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsReadLeaseConfiguration(string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AwsReadLeaseConfiguration: " + e.Message );
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


<a name="awsreadrole"></a>
# **AwsReadRole**

> void AwsReadRole (string name, string awsMountPath, TimeSpan? wrapTTL = null)

Read, write and reference IAM policies that access keys can be made for.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsReadRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the policy
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                
                // Read, write and reference IAM policies that access keys can be made for.
                

                apiInstance.AwsReadRole(string name, string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AwsReadRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the policy | 
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


<a name="awsreadrootiamcredentialsconfiguration"></a>
# **AwsReadRootIamCredentialsConfiguration**

> void AwsReadRootIamCredentialsConfiguration (string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsReadRootIamCredentialsConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsReadRootIamCredentialsConfiguration(string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AwsReadRootIamCredentialsConfiguration: " + e.Message );
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


<a name="awsrotaterootiamcredentials"></a>
# **AwsRotateRootIamCredentials**

> void AwsRotateRootIamCredentials (string awsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsRotateRootIamCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            

            try
            {
                

                apiInstance.AwsRotateRootIamCredentials(string awsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AwsRotateRootIamCredentials: " + e.Message );
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


<a name="awswriterole"></a>
# **AwsWriteRole**

> void AwsWriteRole (string name, string awsMountPath, AwsWriteRoleRequest awsWriteRoleRequest, TimeSpan? wrapTTL = null)

Read, write and reference IAM policies that access keys can be made for.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AwsWriteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the policy
            
            
            
            
            var awsMountPath = "\"aws\"";  // string | Path that the backend was mounted at (default to "aws")
            
            
            
            
            
            var awsWriteRoleRequest = new AwsWriteRoleRequest(); // AwsWriteRoleRequest | 
            
            

            try
            {
                
                // Read, write and reference IAM policies that access keys can be made for.
                

                apiInstance.AwsWriteRole(string name, string awsMountPath, AwsWriteRoleRequest awsWriteRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AwsWriteRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the policy | 
 **awsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;aws&quot;]
 **awsWriteRoleRequest** | [**AwsWriteRoleRequest**](AwsWriteRoleRequest.md)|  | 


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


<a name="azureconfigure"></a>
# **AzureConfigure**

> void AzureConfigure (string azureMountPath, AzureConfigureRequest azureConfigureRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AzureConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var azureMountPath = "\"azure\"";  // string | Path that the backend was mounted at (default to "azure")
            
            
            
            
            
            var azureConfigureRequest = new AzureConfigureRequest(); // AzureConfigureRequest | 
            
            

            try
            {
                

                apiInstance.AzureConfigure(string azureMountPath, AzureConfigureRequest azureConfigureRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AzureConfigure: " + e.Message );
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
 **azureConfigureRequest** | [**AzureConfigureRequest**](AzureConfigureRequest.md)|  | 


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


<a name="azuredeleteconfiguration"></a>
# **AzureDeleteConfiguration**

> void AzureDeleteConfiguration (string azureMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AzureDeleteConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var azureMountPath = "\"azure\"";  // string | Path that the backend was mounted at (default to "azure")
            
            
            

            try
            {
                

                apiInstance.AzureDeleteConfiguration(string azureMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AzureDeleteConfiguration: " + e.Message );
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


<a name="azuredeleterole"></a>
# **AzureDeleteRole**

> void AzureDeleteRole (string name, string azureMountPath, TimeSpan? wrapTTL = null)

Manage the Vault roles used to generate Azure credentials.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AzureDeleteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role.
            
            
            
            
            var azureMountPath = "\"azure\"";  // string | Path that the backend was mounted at (default to "azure")
            
            
            

            try
            {
                
                // Manage the Vault roles used to generate Azure credentials.
                

                apiInstance.AzureDeleteRole(string name, string azureMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AzureDeleteRole: " + e.Message );
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


<a name="azurelistroles"></a>
# **AzureListRoles**

> void AzureListRoles (string azureMountPath, TimeSpan? wrapTTL = null)

List existing roles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AzureListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var azureMountPath = "\"azure\"";  // string | Path that the backend was mounted at (default to "azure")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // List existing roles.
                

                apiInstance.AzureListRoles(string azureMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AzureListRoles: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="azurereadconfiguration"></a>
# **AzureReadConfiguration**

> void AzureReadConfiguration (string azureMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AzureReadConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var azureMountPath = "\"azure\"";  // string | Path that the backend was mounted at (default to "azure")
            
            
            

            try
            {
                

                apiInstance.AzureReadConfiguration(string azureMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AzureReadConfiguration: " + e.Message );
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


<a name="azurereadrole"></a>
# **AzureReadRole**

> void AzureReadRole (string name, string azureMountPath, TimeSpan? wrapTTL = null)

Manage the Vault roles used to generate Azure credentials.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AzureReadRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role.
            
            
            
            
            var azureMountPath = "\"azure\"";  // string | Path that the backend was mounted at (default to "azure")
            
            
            

            try
            {
                
                // Manage the Vault roles used to generate Azure credentials.
                

                apiInstance.AzureReadRole(string name, string azureMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AzureReadRole: " + e.Message );
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


<a name="azurerequestserviceprincipalcredentials"></a>
# **AzureRequestServicePrincipalCredentials**

> void AzureRequestServicePrincipalCredentials (string role, string azureMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AzureRequestServicePrincipalCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var role = "role_example";  // string | Name of the Vault role
            
            
            
            
            var azureMountPath = "\"azure\"";  // string | Path that the backend was mounted at (default to "azure")
            
            
            

            try
            {
                

                apiInstance.AzureRequestServicePrincipalCredentials(string role, string azureMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AzureRequestServicePrincipalCredentials: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| Name of the Vault role | 
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


<a name="azurerotateroot"></a>
# **AzureRotateRoot**

> void AzureRotateRoot (string azureMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AzureRotateRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var azureMountPath = "\"azure\"";  // string | Path that the backend was mounted at (default to "azure")
            
            
            

            try
            {
                

                apiInstance.AzureRotateRoot(string azureMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AzureRotateRoot: " + e.Message );
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


<a name="azurewriterole"></a>
# **AzureWriteRole**

> void AzureWriteRole (string name, string azureMountPath, AzureWriteRoleRequest azureWriteRoleRequest, TimeSpan? wrapTTL = null)

Manage the Vault roles used to generate Azure credentials.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AzureWriteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role.
            
            
            
            
            var azureMountPath = "\"azure\"";  // string | Path that the backend was mounted at (default to "azure")
            
            
            
            
            
            var azureWriteRoleRequest = new AzureWriteRoleRequest(); // AzureWriteRoleRequest | 
            
            

            try
            {
                
                // Manage the Vault roles used to generate Azure credentials.
                

                apiInstance.AzureWriteRole(string name, string azureMountPath, AzureWriteRoleRequest azureWriteRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AzureWriteRole: " + e.Message );
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
 **azureWriteRoleRequest** | [**AzureWriteRoleRequest**](AzureWriteRoleRequest.md)|  | 


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


<a name="consulconfigureaccess"></a>
# **ConsulConfigureAccess**

> void ConsulConfigureAccess (string consulMountPath, ConsulConfigureAccessRequest consulConfigureAccessRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ConsulConfigureAccessExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var consulMountPath = "\"consul\"";  // string | Path that the backend was mounted at (default to "consul")
            
            
            
            
            
            var consulConfigureAccessRequest = new ConsulConfigureAccessRequest(); // ConsulConfigureAccessRequest | 
            
            

            try
            {
                

                apiInstance.ConsulConfigureAccess(string consulMountPath, ConsulConfigureAccessRequest consulConfigureAccessRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ConsulConfigureAccess: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **consulMountPath** | **string**| Path that the backend was mounted at | [default to &quot;consul&quot;]
 **consulConfigureAccessRequest** | [**ConsulConfigureAccessRequest**](ConsulConfigureAccessRequest.md)|  | 


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


<a name="consuldeleterole"></a>
# **ConsulDeleteRole**

> void ConsulDeleteRole (string name, string consulMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ConsulDeleteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role.
            
            
            
            
            var consulMountPath = "\"consul\"";  // string | Path that the backend was mounted at (default to "consul")
            
            
            

            try
            {
                

                apiInstance.ConsulDeleteRole(string name, string consulMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ConsulDeleteRole: " + e.Message );
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
 **consulMountPath** | **string**| Path that the backend was mounted at | [default to &quot;consul&quot;]


### Return type

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


<a name="consulgeneratecredentials"></a>
# **ConsulGenerateCredentials**

> void ConsulGenerateCredentials (string role, string consulMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ConsulGenerateCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var role = "role_example";  // string | Name of the role.
            
            
            
            
            var consulMountPath = "\"consul\"";  // string | Path that the backend was mounted at (default to "consul")
            
            
            

            try
            {
                

                apiInstance.ConsulGenerateCredentials(string role, string consulMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ConsulGenerateCredentials: " + e.Message );
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
 **consulMountPath** | **string**| Path that the backend was mounted at | [default to &quot;consul&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="consullistroles"></a>
# **ConsulListRoles**

> void ConsulListRoles (string consulMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ConsulListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var consulMountPath = "\"consul\"";  // string | Path that the backend was mounted at (default to "consul")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                apiInstance.ConsulListRoles(string consulMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ConsulListRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **consulMountPath** | **string**| Path that the backend was mounted at | [default to &quot;consul&quot;]
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


<a name="consulreadaccessconfiguration"></a>
# **ConsulReadAccessConfiguration**

> void ConsulReadAccessConfiguration (string consulMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ConsulReadAccessConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var consulMountPath = "\"consul\"";  // string | Path that the backend was mounted at (default to "consul")
            
            
            

            try
            {
                

                apiInstance.ConsulReadAccessConfiguration(string consulMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ConsulReadAccessConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **consulMountPath** | **string**| Path that the backend was mounted at | [default to &quot;consul&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="consulreadrole"></a>
# **ConsulReadRole**

> void ConsulReadRole (string name, string consulMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ConsulReadRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role.
            
            
            
            
            var consulMountPath = "\"consul\"";  // string | Path that the backend was mounted at (default to "consul")
            
            
            

            try
            {
                

                apiInstance.ConsulReadRole(string name, string consulMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ConsulReadRole: " + e.Message );
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
 **consulMountPath** | **string**| Path that the backend was mounted at | [default to &quot;consul&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="consulwriterole"></a>
# **ConsulWriteRole**

> void ConsulWriteRole (string name, string consulMountPath, ConsulWriteRoleRequest consulWriteRoleRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ConsulWriteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role.
            
            
            
            
            var consulMountPath = "\"consul\"";  // string | Path that the backend was mounted at (default to "consul")
            
            
            
            
            
            var consulWriteRoleRequest = new ConsulWriteRoleRequest(); // ConsulWriteRoleRequest | 
            
            

            try
            {
                

                apiInstance.ConsulWriteRole(string name, string consulMountPath, ConsulWriteRoleRequest consulWriteRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ConsulWriteRole: " + e.Message );
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
 **consulMountPath** | **string**| Path that the backend was mounted at | [default to &quot;consul&quot;]
 **consulWriteRoleRequest** | [**ConsulWriteRoleRequest**](ConsulWriteRoleRequest.md)|  | 


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


<a name="cubbyholedelete"></a>
# **CubbyholeDelete**

> void CubbyholeDelete (string path, TimeSpan? wrapTTL = null)

Deletes the secret at the specified location.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class CubbyholeDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var path = "path_example";  // string | Specifies the path of the secret.
            
            
            

            try
            {
                
                // Deletes the secret at the specified location.
                

                apiInstance.CubbyholeDelete(string path, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.CubbyholeDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Specifies the path of the secret. | 


### Return type

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


<a name="cubbyholeread"></a>
# **CubbyholeRead**

> void CubbyholeRead (string path, string list = default(string), TimeSpan? wrapTTL = null)

Retrieve the secret at the specified location.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class CubbyholeReadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var path = "path_example";  // string | Specifies the path of the secret.
            
            
            
            
            var list = "list_example";  // string | Return a list if `true` (optional) 
            
            
            

            try
            {
                
                // Retrieve the secret at the specified location.
                

                apiInstance.CubbyholeRead(string path, string list = default(string), TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.CubbyholeRead: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Specifies the path of the secret. | 
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


<a name="cubbyholewrite"></a>
# **CubbyholeWrite**

> void CubbyholeWrite (string path, TimeSpan? wrapTTL = null)

Store a secret at the specified location.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class CubbyholeWriteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var path = "path_example";  // string | Specifies the path of the secret.
            
            
            

            try
            {
                
                // Store a secret at the specified location.
                

                apiInstance.CubbyholeWrite(string path, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.CubbyholeWrite: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Specifies the path of the secret. | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="databaseconfigureconnection"></a>
# **DatabaseConfigureConnection**

> void DatabaseConfigureConnection (string name, string databaseMountPath, DatabaseConfigureConnectionRequest databaseConfigureConnectionRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DatabaseConfigureConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of this database connection
            
            
            
            
            var databaseMountPath = "\"database\"";  // string | Path that the backend was mounted at (default to "database")
            
            
            
            
            
            var databaseConfigureConnectionRequest = new DatabaseConfigureConnectionRequest(); // DatabaseConfigureConnectionRequest | 
            
            

            try
            {
                

                apiInstance.DatabaseConfigureConnection(string name, string databaseMountPath, DatabaseConfigureConnectionRequest databaseConfigureConnectionRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DatabaseConfigureConnection: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of this database connection | 
 **databaseMountPath** | **string**| Path that the backend was mounted at | [default to &quot;database&quot;]
 **databaseConfigureConnectionRequest** | [**DatabaseConfigureConnectionRequest**](DatabaseConfigureConnectionRequest.md)|  | 


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


<a name="databasedeleteconnectionconfiguration"></a>
# **DatabaseDeleteConnectionConfiguration**

> void DatabaseDeleteConnectionConfiguration (string name, string databaseMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DatabaseDeleteConnectionConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of this database connection
            
            
            
            
            var databaseMountPath = "\"database\"";  // string | Path that the backend was mounted at (default to "database")
            
            
            

            try
            {
                

                apiInstance.DatabaseDeleteConnectionConfiguration(string name, string databaseMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DatabaseDeleteConnectionConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of this database connection | 
 **databaseMountPath** | **string**| Path that the backend was mounted at | [default to &quot;database&quot;]


### Return type

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


<a name="databasedeleterole"></a>
# **DatabaseDeleteRole**

> void DatabaseDeleteRole (string name, string databaseMountPath, TimeSpan? wrapTTL = null)

Manage the roles that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DatabaseDeleteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role.
            
            
            
            
            var databaseMountPath = "\"database\"";  // string | Path that the backend was mounted at (default to "database")
            
            
            

            try
            {
                
                // Manage the roles that can be created with this backend.
                

                apiInstance.DatabaseDeleteRole(string name, string databaseMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DatabaseDeleteRole: " + e.Message );
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
 **databaseMountPath** | **string**| Path that the backend was mounted at | [default to &quot;database&quot;]


### Return type

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


<a name="databasedeletestaticrole"></a>
# **DatabaseDeleteStaticRole**

> void DatabaseDeleteStaticRole (string name, string databaseMountPath, TimeSpan? wrapTTL = null)

Manage the static roles that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DatabaseDeleteStaticRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role.
            
            
            
            
            var databaseMountPath = "\"database\"";  // string | Path that the backend was mounted at (default to "database")
            
            
            

            try
            {
                
                // Manage the static roles that can be created with this backend.
                

                apiInstance.DatabaseDeleteStaticRole(string name, string databaseMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DatabaseDeleteStaticRole: " + e.Message );
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
 **databaseMountPath** | **string**| Path that the backend was mounted at | [default to &quot;database&quot;]


### Return type

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


<a name="databasegeneratecredentials"></a>
# **DatabaseGenerateCredentials**

> void DatabaseGenerateCredentials (string name, string databaseMountPath, TimeSpan? wrapTTL = null)

Request database credentials for a certain role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DatabaseGenerateCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role.
            
            
            
            
            var databaseMountPath = "\"database\"";  // string | Path that the backend was mounted at (default to "database")
            
            
            

            try
            {
                
                // Request database credentials for a certain role.
                

                apiInstance.DatabaseGenerateCredentials(string name, string databaseMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DatabaseGenerateCredentials: " + e.Message );
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
 **databaseMountPath** | **string**| Path that the backend was mounted at | [default to &quot;database&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="databaselistconnections"></a>
# **DatabaseListConnections**

> void DatabaseListConnections (string databaseMountPath, TimeSpan? wrapTTL = null)

Configure connection details to a database plugin.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DatabaseListConnectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var databaseMountPath = "\"database\"";  // string | Path that the backend was mounted at (default to "database")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // Configure connection details to a database plugin.
                

                apiInstance.DatabaseListConnections(string databaseMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DatabaseListConnections: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **databaseMountPath** | **string**| Path that the backend was mounted at | [default to &quot;database&quot;]
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


<a name="databaselistroles"></a>
# **DatabaseListRoles**

> void DatabaseListRoles (string databaseMountPath, TimeSpan? wrapTTL = null)

Manage the roles that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DatabaseListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var databaseMountPath = "\"database\"";  // string | Path that the backend was mounted at (default to "database")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // Manage the roles that can be created with this backend.
                

                apiInstance.DatabaseListRoles(string databaseMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DatabaseListRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **databaseMountPath** | **string**| Path that the backend was mounted at | [default to &quot;database&quot;]
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


<a name="databaseliststaticroles"></a>
# **DatabaseListStaticRoles**

> void DatabaseListStaticRoles (string databaseMountPath, TimeSpan? wrapTTL = null)

Manage the static roles that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DatabaseListStaticRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var databaseMountPath = "\"database\"";  // string | Path that the backend was mounted at (default to "database")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // Manage the static roles that can be created with this backend.
                

                apiInstance.DatabaseListStaticRoles(string databaseMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DatabaseListStaticRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **databaseMountPath** | **string**| Path that the backend was mounted at | [default to &quot;database&quot;]
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


<a name="databasereadconnectionconfiguration"></a>
# **DatabaseReadConnectionConfiguration**

> void DatabaseReadConnectionConfiguration (string name, string databaseMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DatabaseReadConnectionConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of this database connection
            
            
            
            
            var databaseMountPath = "\"database\"";  // string | Path that the backend was mounted at (default to "database")
            
            
            

            try
            {
                

                apiInstance.DatabaseReadConnectionConfiguration(string name, string databaseMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DatabaseReadConnectionConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of this database connection | 
 **databaseMountPath** | **string**| Path that the backend was mounted at | [default to &quot;database&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="databasereadrole"></a>
# **DatabaseReadRole**

> void DatabaseReadRole (string name, string databaseMountPath, TimeSpan? wrapTTL = null)

Manage the roles that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DatabaseReadRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role.
            
            
            
            
            var databaseMountPath = "\"database\"";  // string | Path that the backend was mounted at (default to "database")
            
            
            

            try
            {
                
                // Manage the roles that can be created with this backend.
                

                apiInstance.DatabaseReadRole(string name, string databaseMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DatabaseReadRole: " + e.Message );
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
 **databaseMountPath** | **string**| Path that the backend was mounted at | [default to &quot;database&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="databasereadstaticrole"></a>
# **DatabaseReadStaticRole**

> void DatabaseReadStaticRole (string name, string databaseMountPath, TimeSpan? wrapTTL = null)

Manage the static roles that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DatabaseReadStaticRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role.
            
            
            
            
            var databaseMountPath = "\"database\"";  // string | Path that the backend was mounted at (default to "database")
            
            
            

            try
            {
                
                // Manage the static roles that can be created with this backend.
                

                apiInstance.DatabaseReadStaticRole(string name, string databaseMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DatabaseReadStaticRole: " + e.Message );
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
 **databaseMountPath** | **string**| Path that the backend was mounted at | [default to &quot;database&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="databasereadstaticrolecredentials"></a>
# **DatabaseReadStaticRoleCredentials**

> void DatabaseReadStaticRoleCredentials (string name, string databaseMountPath, TimeSpan? wrapTTL = null)

Request database credentials for a certain static role. These credentials are rotated periodically.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DatabaseReadStaticRoleCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the static role.
            
            
            
            
            var databaseMountPath = "\"database\"";  // string | Path that the backend was mounted at (default to "database")
            
            
            

            try
            {
                
                // Request database credentials for a certain static role. These credentials are rotated periodically.
                

                apiInstance.DatabaseReadStaticRoleCredentials(string name, string databaseMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DatabaseReadStaticRoleCredentials: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the static role. | 
 **databaseMountPath** | **string**| Path that the backend was mounted at | [default to &quot;database&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="databaseresetconnection"></a>
# **DatabaseResetConnection**

> void DatabaseResetConnection (string name, string databaseMountPath, TimeSpan? wrapTTL = null)

Resets a database plugin.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DatabaseResetConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of this database connection
            
            
            
            
            var databaseMountPath = "\"database\"";  // string | Path that the backend was mounted at (default to "database")
            
            
            

            try
            {
                
                // Resets a database plugin.
                

                apiInstance.DatabaseResetConnection(string name, string databaseMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DatabaseResetConnection: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of this database connection | 
 **databaseMountPath** | **string**| Path that the backend was mounted at | [default to &quot;database&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="databaserotaterootcredentials"></a>
# **DatabaseRotateRootCredentials**

> void DatabaseRotateRootCredentials (string name, string databaseMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DatabaseRotateRootCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of this database connection
            
            
            
            
            var databaseMountPath = "\"database\"";  // string | Path that the backend was mounted at (default to "database")
            
            
            

            try
            {
                

                apiInstance.DatabaseRotateRootCredentials(string name, string databaseMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DatabaseRotateRootCredentials: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of this database connection | 
 **databaseMountPath** | **string**| Path that the backend was mounted at | [default to &quot;database&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="databaserotatestaticrolecredentials"></a>
# **DatabaseRotateStaticRoleCredentials**

> void DatabaseRotateStaticRoleCredentials (string name, string databaseMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DatabaseRotateStaticRoleCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the static role
            
            
            
            
            var databaseMountPath = "\"database\"";  // string | Path that the backend was mounted at (default to "database")
            
            
            

            try
            {
                

                apiInstance.DatabaseRotateStaticRoleCredentials(string name, string databaseMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DatabaseRotateStaticRoleCredentials: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the static role | 
 **databaseMountPath** | **string**| Path that the backend was mounted at | [default to &quot;database&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="databasewriterole"></a>
# **DatabaseWriteRole**

> void DatabaseWriteRole (string name, string databaseMountPath, DatabaseWriteRoleRequest databaseWriteRoleRequest, TimeSpan? wrapTTL = null)

Manage the roles that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DatabaseWriteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role.
            
            
            
            
            var databaseMountPath = "\"database\"";  // string | Path that the backend was mounted at (default to "database")
            
            
            
            
            
            var databaseWriteRoleRequest = new DatabaseWriteRoleRequest(); // DatabaseWriteRoleRequest | 
            
            

            try
            {
                
                // Manage the roles that can be created with this backend.
                

                apiInstance.DatabaseWriteRole(string name, string databaseMountPath, DatabaseWriteRoleRequest databaseWriteRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DatabaseWriteRole: " + e.Message );
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
 **databaseMountPath** | **string**| Path that the backend was mounted at | [default to &quot;database&quot;]
 **databaseWriteRoleRequest** | [**DatabaseWriteRoleRequest**](DatabaseWriteRoleRequest.md)|  | 


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


<a name="databasewritestaticrole"></a>
# **DatabaseWriteStaticRole**

> void DatabaseWriteStaticRole (string name, string databaseMountPath, DatabaseWriteStaticRoleRequest databaseWriteStaticRoleRequest, TimeSpan? wrapTTL = null)

Manage the static roles that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DatabaseWriteStaticRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role.
            
            
            
            
            var databaseMountPath = "\"database\"";  // string | Path that the backend was mounted at (default to "database")
            
            
            
            
            
            var databaseWriteStaticRoleRequest = new DatabaseWriteStaticRoleRequest(); // DatabaseWriteStaticRoleRequest | 
            
            

            try
            {
                
                // Manage the static roles that can be created with this backend.
                

                apiInstance.DatabaseWriteStaticRole(string name, string databaseMountPath, DatabaseWriteStaticRoleRequest databaseWriteStaticRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DatabaseWriteStaticRole: " + e.Message );
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
 **databaseMountPath** | **string**| Path that the backend was mounted at | [default to &quot;database&quot;]
 **databaseWriteStaticRoleRequest** | [**DatabaseWriteStaticRoleRequest**](DatabaseWriteStaticRoleRequest.md)|  | 


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


<a name="googlecloudconfigure"></a>
# **GoogleCloudConfigure**

> void GoogleCloudConfigure (string gcpMountPath, GoogleCloudConfigureRequest googleCloudConfigureRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            
            
            
            var googleCloudConfigureRequest = new GoogleCloudConfigureRequest(); // GoogleCloudConfigureRequest | 
            
            

            try
            {
                

                apiInstance.GoogleCloudConfigure(string gcpMountPath, GoogleCloudConfigureRequest googleCloudConfigureRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudConfigure: " + e.Message );
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
 **googleCloudConfigureRequest** | [**GoogleCloudConfigureRequest**](GoogleCloudConfigureRequest.md)|  | 


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


<a name="googleclouddeleteimpersonatedaccount"></a>
# **GoogleCloudDeleteImpersonatedAccount**

> void GoogleCloudDeleteImpersonatedAccount (string name, string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudDeleteImpersonatedAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Required. Name to refer to this impersonated account in Vault. Cannot be updated.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudDeleteImpersonatedAccount(string name, string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudDeleteImpersonatedAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Required. Name to refer to this impersonated account in Vault. Cannot be updated. | 
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


<a name="googleclouddeleteroleset"></a>
# **GoogleCloudDeleteRoleset**

> void GoogleCloudDeleteRoleset (string name, string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudDeleteRolesetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Required. Name of the role.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudDeleteRoleset(string name, string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudDeleteRoleset: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Required. Name of the role. | 
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


<a name="googleclouddeletestaticaccount"></a>
# **GoogleCloudDeleteStaticAccount**

> void GoogleCloudDeleteStaticAccount (string name, string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudDeleteStaticAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Required. Name to refer to this static account in Vault. Cannot be updated.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudDeleteStaticAccount(string name, string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudDeleteStaticAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Required. Name to refer to this static account in Vault. Cannot be updated. | 
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


<a name="googlecloudgenerateimpersonatedaccountaccesstoken"></a>
# **GoogleCloudGenerateImpersonatedAccountAccessToken**

> void GoogleCloudGenerateImpersonatedAccountAccessToken (string name, string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudGenerateImpersonatedAccountAccessTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Required. Name of the impersonated account.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudGenerateImpersonatedAccountAccessToken(string name, string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudGenerateImpersonatedAccountAccessToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Required. Name of the impersonated account. | 
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


<a name="googlecloudgenerateimpersonatedaccountaccesstoken2"></a>
# **GoogleCloudGenerateImpersonatedAccountAccessToken2**

> void GoogleCloudGenerateImpersonatedAccountAccessToken2 (string name, string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudGenerateImpersonatedAccountAccessToken2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Required. Name of the impersonated account.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudGenerateImpersonatedAccountAccessToken2(string name, string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudGenerateImpersonatedAccountAccessToken2: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Required. Name of the impersonated account. | 
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


<a name="googlecloudgeneraterolesetaccesstoken"></a>
# **GoogleCloudGenerateRolesetAccessToken**

> void GoogleCloudGenerateRolesetAccessToken (string roleset, string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudGenerateRolesetAccessTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var roleset = "roleset_example";  // string | Required. Name of the role set.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudGenerateRolesetAccessToken(string roleset, string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudGenerateRolesetAccessToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleset** | **string**| Required. Name of the role set. | 
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


<a name="googlecloudgeneraterolesetaccesstoken2"></a>
# **GoogleCloudGenerateRolesetAccessToken2**

> void GoogleCloudGenerateRolesetAccessToken2 (string roleset, string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudGenerateRolesetAccessToken2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var roleset = "roleset_example";  // string | Required. Name of the role set.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudGenerateRolesetAccessToken2(string roleset, string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudGenerateRolesetAccessToken2: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleset** | **string**| Required. Name of the role set. | 
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


<a name="googlecloudgeneraterolesetaccesstokenwithparameters"></a>
# **GoogleCloudGenerateRolesetAccessTokenWithParameters**

> void GoogleCloudGenerateRolesetAccessTokenWithParameters (string roleset, string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudGenerateRolesetAccessTokenWithParametersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var roleset = "roleset_example";  // string | Required. Name of the role set.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudGenerateRolesetAccessTokenWithParameters(string roleset, string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudGenerateRolesetAccessTokenWithParameters: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleset** | **string**| Required. Name of the role set. | 
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


<a name="googlecloudgeneraterolesetaccesstokenwithparameters2"></a>
# **GoogleCloudGenerateRolesetAccessTokenWithParameters2**

> void GoogleCloudGenerateRolesetAccessTokenWithParameters2 (string roleset, string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudGenerateRolesetAccessTokenWithParameters2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var roleset = "roleset_example";  // string | Required. Name of the role set.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudGenerateRolesetAccessTokenWithParameters2(string roleset, string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudGenerateRolesetAccessTokenWithParameters2: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleset** | **string**| Required. Name of the role set. | 
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


<a name="googlecloudgeneraterolesetkey"></a>
# **GoogleCloudGenerateRolesetKey**

> void GoogleCloudGenerateRolesetKey (string roleset, string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudGenerateRolesetKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var roleset = "roleset_example";  // string | Required. Name of the role set.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudGenerateRolesetKey(string roleset, string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudGenerateRolesetKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleset** | **string**| Required. Name of the role set. | 
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


<a name="googlecloudgeneraterolesetkey2"></a>
# **GoogleCloudGenerateRolesetKey2**

> void GoogleCloudGenerateRolesetKey2 (string roleset, string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudGenerateRolesetKey2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var roleset = "roleset_example";  // string | Required. Name of the role set.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudGenerateRolesetKey2(string roleset, string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudGenerateRolesetKey2: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleset** | **string**| Required. Name of the role set. | 
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


<a name="googlecloudgeneraterolesetkeywithparameters"></a>
# **GoogleCloudGenerateRolesetKeyWithParameters**

> void GoogleCloudGenerateRolesetKeyWithParameters (string roleset, string gcpMountPath, GoogleCloudGenerateRolesetKeyWithParametersRequest googleCloudGenerateRolesetKeyWithParametersRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudGenerateRolesetKeyWithParametersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var roleset = "roleset_example";  // string | Required. Name of the role set.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            
            
            
            var googleCloudGenerateRolesetKeyWithParametersRequest = new GoogleCloudGenerateRolesetKeyWithParametersRequest(); // GoogleCloudGenerateRolesetKeyWithParametersRequest | 
            
            

            try
            {
                

                apiInstance.GoogleCloudGenerateRolesetKeyWithParameters(string roleset, string gcpMountPath, GoogleCloudGenerateRolesetKeyWithParametersRequest googleCloudGenerateRolesetKeyWithParametersRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudGenerateRolesetKeyWithParameters: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleset** | **string**| Required. Name of the role set. | 
 **gcpMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcp&quot;]
 **googleCloudGenerateRolesetKeyWithParametersRequest** | [**GoogleCloudGenerateRolesetKeyWithParametersRequest**](GoogleCloudGenerateRolesetKeyWithParametersRequest.md)|  | 


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


<a name="googlecloudgeneraterolesetkeywithparameters2"></a>
# **GoogleCloudGenerateRolesetKeyWithParameters2**

> void GoogleCloudGenerateRolesetKeyWithParameters2 (string roleset, string gcpMountPath, GoogleCloudGenerateRolesetKeyWithParameters2Request googleCloudGenerateRolesetKeyWithParameters2Request, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudGenerateRolesetKeyWithParameters2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var roleset = "roleset_example";  // string | Required. Name of the role set.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            
            
            
            var googleCloudGenerateRolesetKeyWithParameters2Request = new GoogleCloudGenerateRolesetKeyWithParameters2Request(); // GoogleCloudGenerateRolesetKeyWithParameters2Request | 
            
            

            try
            {
                

                apiInstance.GoogleCloudGenerateRolesetKeyWithParameters2(string roleset, string gcpMountPath, GoogleCloudGenerateRolesetKeyWithParameters2Request googleCloudGenerateRolesetKeyWithParameters2Request, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudGenerateRolesetKeyWithParameters2: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleset** | **string**| Required. Name of the role set. | 
 **gcpMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcp&quot;]
 **googleCloudGenerateRolesetKeyWithParameters2Request** | [**GoogleCloudGenerateRolesetKeyWithParameters2Request**](GoogleCloudGenerateRolesetKeyWithParameters2Request.md)|  | 


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


<a name="googlecloudgeneratestaticaccountaccesstoken"></a>
# **GoogleCloudGenerateStaticAccountAccessToken**

> void GoogleCloudGenerateStaticAccountAccessToken (string name, string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudGenerateStaticAccountAccessTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Required. Name of the static account.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudGenerateStaticAccountAccessToken(string name, string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudGenerateStaticAccountAccessToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Required. Name of the static account. | 
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


<a name="googlecloudgeneratestaticaccountaccesstokenwithparameters"></a>
# **GoogleCloudGenerateStaticAccountAccessTokenWithParameters**

> void GoogleCloudGenerateStaticAccountAccessTokenWithParameters (string name, string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudGenerateStaticAccountAccessTokenWithParametersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Required. Name of the static account.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudGenerateStaticAccountAccessTokenWithParameters(string name, string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudGenerateStaticAccountAccessTokenWithParameters: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Required. Name of the static account. | 
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


<a name="googlecloudgeneratestaticaccountkey"></a>
# **GoogleCloudGenerateStaticAccountKey**

> void GoogleCloudGenerateStaticAccountKey (string name, string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudGenerateStaticAccountKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Required. Name of the static account.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudGenerateStaticAccountKey(string name, string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudGenerateStaticAccountKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Required. Name of the static account. | 
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


<a name="googlecloudgeneratestaticaccountkeywithparameters"></a>
# **GoogleCloudGenerateStaticAccountKeyWithParameters**

> void GoogleCloudGenerateStaticAccountKeyWithParameters (string name, string gcpMountPath, GoogleCloudGenerateStaticAccountKeyWithParametersRequest googleCloudGenerateStaticAccountKeyWithParametersRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudGenerateStaticAccountKeyWithParametersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Required. Name of the static account.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            
            
            
            var googleCloudGenerateStaticAccountKeyWithParametersRequest = new GoogleCloudGenerateStaticAccountKeyWithParametersRequest(); // GoogleCloudGenerateStaticAccountKeyWithParametersRequest | 
            
            

            try
            {
                

                apiInstance.GoogleCloudGenerateStaticAccountKeyWithParameters(string name, string gcpMountPath, GoogleCloudGenerateStaticAccountKeyWithParametersRequest googleCloudGenerateStaticAccountKeyWithParametersRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudGenerateStaticAccountKeyWithParameters: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Required. Name of the static account. | 
 **gcpMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcp&quot;]
 **googleCloudGenerateStaticAccountKeyWithParametersRequest** | [**GoogleCloudGenerateStaticAccountKeyWithParametersRequest**](GoogleCloudGenerateStaticAccountKeyWithParametersRequest.md)|  | 


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


<a name="googlecloudkmsconfigure"></a>
# **GoogleCloudKmsConfigure**

> void GoogleCloudKmsConfigure (string gcpkmsMountPath, GoogleCloudKmsConfigureRequest googleCloudKmsConfigureRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKmsConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path that the backend was mounted at (default to "gcpkms")
            
            
            
            
            
            var googleCloudKmsConfigureRequest = new GoogleCloudKmsConfigureRequest(); // GoogleCloudKmsConfigureRequest | 
            
            

            try
            {
                

                apiInstance.GoogleCloudKmsConfigure(string gcpkmsMountPath, GoogleCloudKmsConfigureRequest googleCloudKmsConfigureRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKmsConfigure: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gcpkmsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcpkms&quot;]
 **googleCloudKmsConfigureRequest** | [**GoogleCloudKmsConfigureRequest**](GoogleCloudKmsConfigureRequest.md)|  | 


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


<a name="googlecloudkmsconfigurekey"></a>
# **GoogleCloudKmsConfigureKey**

> void GoogleCloudKmsConfigureKey (string key, string gcpkmsMountPath, GoogleCloudKmsConfigureKeyRequest googleCloudKmsConfigureKeyRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKmsConfigureKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var key = "key_example";  // string | Name of the key in Vault.
            
            
            
            
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path that the backend was mounted at (default to "gcpkms")
            
            
            
            
            
            var googleCloudKmsConfigureKeyRequest = new GoogleCloudKmsConfigureKeyRequest(); // GoogleCloudKmsConfigureKeyRequest | 
            
            

            try
            {
                

                apiInstance.GoogleCloudKmsConfigureKey(string key, string gcpkmsMountPath, GoogleCloudKmsConfigureKeyRequest googleCloudKmsConfigureKeyRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKmsConfigureKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key in Vault. | 
 **gcpkmsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcpkms&quot;]
 **googleCloudKmsConfigureKeyRequest** | [**GoogleCloudKmsConfigureKeyRequest**](GoogleCloudKmsConfigureKeyRequest.md)|  | 


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


<a name="googlecloudkmsdecrypt"></a>
# **GoogleCloudKmsDecrypt**

> void GoogleCloudKmsDecrypt (string key, string gcpkmsMountPath, GoogleCloudKmsDecryptRequest googleCloudKmsDecryptRequest, TimeSpan? wrapTTL = null)

Decrypt a ciphertext value using a named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKmsDecryptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var key = "key_example";  // string | Name of the key in Vault to use for decryption. This key must already exist in Vault and must map back to a Google Cloud KMS key.
            
            
            
            
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path that the backend was mounted at (default to "gcpkms")
            
            
            
            
            
            var googleCloudKmsDecryptRequest = new GoogleCloudKmsDecryptRequest(); // GoogleCloudKmsDecryptRequest | 
            
            

            try
            {
                
                // Decrypt a ciphertext value using a named key
                

                apiInstance.GoogleCloudKmsDecrypt(string key, string gcpkmsMountPath, GoogleCloudKmsDecryptRequest googleCloudKmsDecryptRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKmsDecrypt: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key in Vault to use for decryption. This key must already exist in Vault and must map back to a Google Cloud KMS key. | 
 **gcpkmsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcpkms&quot;]
 **googleCloudKmsDecryptRequest** | [**GoogleCloudKmsDecryptRequest**](GoogleCloudKmsDecryptRequest.md)|  | 


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


<a name="googlecloudkmsdeleteconfiguration"></a>
# **GoogleCloudKmsDeleteConfiguration**

> void GoogleCloudKmsDeleteConfiguration (string gcpkmsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKmsDeleteConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path that the backend was mounted at (default to "gcpkms")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudKmsDeleteConfiguration(string gcpkmsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKmsDeleteConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gcpkmsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcpkms&quot;]


### Return type

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


<a name="googlecloudkmsdeletekey"></a>
# **GoogleCloudKmsDeleteKey**

> void GoogleCloudKmsDeleteKey (string key, string gcpkmsMountPath, TimeSpan? wrapTTL = null)

Interact with crypto keys in Vault and Google Cloud KMS

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKmsDeleteKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var key = "key_example";  // string | Name of the key in Vault.
            
            
            
            
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path that the backend was mounted at (default to "gcpkms")
            
            
            

            try
            {
                
                // Interact with crypto keys in Vault and Google Cloud KMS
                

                apiInstance.GoogleCloudKmsDeleteKey(string key, string gcpkmsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKmsDeleteKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key in Vault. | 
 **gcpkmsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcpkms&quot;]


### Return type

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


<a name="googlecloudkmsderegisterkey"></a>
# **GoogleCloudKmsDeregisterKey**

> void GoogleCloudKmsDeregisterKey (string key, string gcpkmsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKmsDeregisterKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var key = "key_example";  // string | Name of the key to deregister in Vault. If the key exists in Google Cloud KMS, it will be left untouched.
            
            
            
            
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path that the backend was mounted at (default to "gcpkms")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudKmsDeregisterKey(string key, string gcpkmsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKmsDeregisterKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key to deregister in Vault. If the key exists in Google Cloud KMS, it will be left untouched. | 
 **gcpkmsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcpkms&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="googlecloudkmsderegisterkey2"></a>
# **GoogleCloudKmsDeregisterKey2**

> void GoogleCloudKmsDeregisterKey2 (string key, string gcpkmsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKmsDeregisterKey2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var key = "key_example";  // string | Name of the key to deregister in Vault. If the key exists in Google Cloud KMS, it will be left untouched.
            
            
            
            
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path that the backend was mounted at (default to "gcpkms")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudKmsDeregisterKey2(string key, string gcpkmsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKmsDeregisterKey2: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key to deregister in Vault. If the key exists in Google Cloud KMS, it will be left untouched. | 
 **gcpkmsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcpkms&quot;]


### Return type

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


<a name="googlecloudkmsencrypt"></a>
# **GoogleCloudKmsEncrypt**

> void GoogleCloudKmsEncrypt (string key, string gcpkmsMountPath, GoogleCloudKmsEncryptRequest googleCloudKmsEncryptRequest, TimeSpan? wrapTTL = null)

Encrypt a plaintext value using a named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKmsEncryptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var key = "key_example";  // string | Name of the key in Vault to use for encryption. This key must already exist in Vault and must map back to a Google Cloud KMS key.
            
            
            
            
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path that the backend was mounted at (default to "gcpkms")
            
            
            
            
            
            var googleCloudKmsEncryptRequest = new GoogleCloudKmsEncryptRequest(); // GoogleCloudKmsEncryptRequest | 
            
            

            try
            {
                
                // Encrypt a plaintext value using a named key
                

                apiInstance.GoogleCloudKmsEncrypt(string key, string gcpkmsMountPath, GoogleCloudKmsEncryptRequest googleCloudKmsEncryptRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKmsEncrypt: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key in Vault to use for encryption. This key must already exist in Vault and must map back to a Google Cloud KMS key. | 
 **gcpkmsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcpkms&quot;]
 **googleCloudKmsEncryptRequest** | [**GoogleCloudKmsEncryptRequest**](GoogleCloudKmsEncryptRequest.md)|  | 


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


<a name="googlecloudkmslistkeys"></a>
# **GoogleCloudKmsListKeys**

> void GoogleCloudKmsListKeys (string gcpkmsMountPath, TimeSpan? wrapTTL = null)

List named keys

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKmsListKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path that the backend was mounted at (default to "gcpkms")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // List named keys
                

                apiInstance.GoogleCloudKmsListKeys(string gcpkmsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKmsListKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gcpkmsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcpkms&quot;]
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


<a name="googlecloudkmsreadconfiguration"></a>
# **GoogleCloudKmsReadConfiguration**

> void GoogleCloudKmsReadConfiguration (string gcpkmsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKmsReadConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path that the backend was mounted at (default to "gcpkms")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudKmsReadConfiguration(string gcpkmsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKmsReadConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gcpkmsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcpkms&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="googlecloudkmsreadkey"></a>
# **GoogleCloudKmsReadKey**

> void GoogleCloudKmsReadKey (string key, string gcpkmsMountPath, TimeSpan? wrapTTL = null)

Interact with crypto keys in Vault and Google Cloud KMS

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKmsReadKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var key = "key_example";  // string | Name of the key in Vault.
            
            
            
            
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path that the backend was mounted at (default to "gcpkms")
            
            
            

            try
            {
                
                // Interact with crypto keys in Vault and Google Cloud KMS
                

                apiInstance.GoogleCloudKmsReadKey(string key, string gcpkmsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKmsReadKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key in Vault. | 
 **gcpkmsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcpkms&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="googlecloudkmsreadkeyconfiguration"></a>
# **GoogleCloudKmsReadKeyConfiguration**

> void GoogleCloudKmsReadKeyConfiguration (string key, string gcpkmsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKmsReadKeyConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var key = "key_example";  // string | Name of the key in Vault.
            
            
            
            
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path that the backend was mounted at (default to "gcpkms")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudKmsReadKeyConfiguration(string key, string gcpkmsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKmsReadKeyConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key in Vault. | 
 **gcpkmsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcpkms&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="googlecloudkmsreencrypt"></a>
# **GoogleCloudKmsReencrypt**

> void GoogleCloudKmsReencrypt (string key, string gcpkmsMountPath, GoogleCloudKmsReencryptRequest googleCloudKmsReencryptRequest, TimeSpan? wrapTTL = null)

Re-encrypt existing ciphertext data to a new version

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKmsReencryptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var key = "key_example";  // string | Name of the key to use for encryption. This key must already exist in Vault and Google Cloud KMS.
            
            
            
            
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path that the backend was mounted at (default to "gcpkms")
            
            
            
            
            
            var googleCloudKmsReencryptRequest = new GoogleCloudKmsReencryptRequest(); // GoogleCloudKmsReencryptRequest | 
            
            

            try
            {
                
                // Re-encrypt existing ciphertext data to a new version
                

                apiInstance.GoogleCloudKmsReencrypt(string key, string gcpkmsMountPath, GoogleCloudKmsReencryptRequest googleCloudKmsReencryptRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKmsReencrypt: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key to use for encryption. This key must already exist in Vault and Google Cloud KMS. | 
 **gcpkmsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcpkms&quot;]
 **googleCloudKmsReencryptRequest** | [**GoogleCloudKmsReencryptRequest**](GoogleCloudKmsReencryptRequest.md)|  | 


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


<a name="googlecloudkmsregisterkey"></a>
# **GoogleCloudKmsRegisterKey**

> void GoogleCloudKmsRegisterKey (string key, string gcpkmsMountPath, GoogleCloudKmsRegisterKeyRequest googleCloudKmsRegisterKeyRequest, TimeSpan? wrapTTL = null)

Register an existing crypto key in Google Cloud KMS

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKmsRegisterKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var key = "key_example";  // string | Name of the key to register in Vault. This will be the named used to refer to the underlying crypto key when encrypting or decrypting data.
            
            
            
            
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path that the backend was mounted at (default to "gcpkms")
            
            
            
            
            
            var googleCloudKmsRegisterKeyRequest = new GoogleCloudKmsRegisterKeyRequest(); // GoogleCloudKmsRegisterKeyRequest | 
            
            

            try
            {
                
                // Register an existing crypto key in Google Cloud KMS
                

                apiInstance.GoogleCloudKmsRegisterKey(string key, string gcpkmsMountPath, GoogleCloudKmsRegisterKeyRequest googleCloudKmsRegisterKeyRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKmsRegisterKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key to register in Vault. This will be the named used to refer to the underlying crypto key when encrypting or decrypting data. | 
 **gcpkmsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcpkms&quot;]
 **googleCloudKmsRegisterKeyRequest** | [**GoogleCloudKmsRegisterKeyRequest**](GoogleCloudKmsRegisterKeyRequest.md)|  | 


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


<a name="googlecloudkmsretrievepublickey"></a>
# **GoogleCloudKmsRetrievePublicKey**

> void GoogleCloudKmsRetrievePublicKey (string key, string gcpkmsMountPath, TimeSpan? wrapTTL = null)

Retrieve the public key associated with the named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKmsRetrievePublicKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var key = "key_example";  // string | Name of the key for which to get the public key. This key must already exist in Vault and Google Cloud KMS.
            
            
            
            
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path that the backend was mounted at (default to "gcpkms")
            
            
            

            try
            {
                
                // Retrieve the public key associated with the named key
                

                apiInstance.GoogleCloudKmsRetrievePublicKey(string key, string gcpkmsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKmsRetrievePublicKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key for which to get the public key. This key must already exist in Vault and Google Cloud KMS. | 
 **gcpkmsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcpkms&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="googlecloudkmsrotatekey"></a>
# **GoogleCloudKmsRotateKey**

> void GoogleCloudKmsRotateKey (string key, string gcpkmsMountPath, TimeSpan? wrapTTL = null)

Rotate a crypto key to a new primary version

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKmsRotateKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var key = "key_example";  // string | Name of the key to rotate. This key must already be registered with Vault and point to a valid Google Cloud KMS crypto key.
            
            
            
            
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path that the backend was mounted at (default to "gcpkms")
            
            
            

            try
            {
                
                // Rotate a crypto key to a new primary version
                

                apiInstance.GoogleCloudKmsRotateKey(string key, string gcpkmsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKmsRotateKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key to rotate. This key must already be registered with Vault and point to a valid Google Cloud KMS crypto key. | 
 **gcpkmsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcpkms&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="googlecloudkmssign"></a>
# **GoogleCloudKmsSign**

> void GoogleCloudKmsSign (string key, string gcpkmsMountPath, GoogleCloudKmsSignRequest googleCloudKmsSignRequest, TimeSpan? wrapTTL = null)

Signs a message or digest using a named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKmsSignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var key = "key_example";  // string | Name of the key in Vault to use for signing. This key must already exist in Vault and must map back to a Google Cloud KMS key.
            
            
            
            
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path that the backend was mounted at (default to "gcpkms")
            
            
            
            
            
            var googleCloudKmsSignRequest = new GoogleCloudKmsSignRequest(); // GoogleCloudKmsSignRequest | 
            
            

            try
            {
                
                // Signs a message or digest using a named key
                

                apiInstance.GoogleCloudKmsSign(string key, string gcpkmsMountPath, GoogleCloudKmsSignRequest googleCloudKmsSignRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKmsSign: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key in Vault to use for signing. This key must already exist in Vault and must map back to a Google Cloud KMS key. | 
 **gcpkmsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcpkms&quot;]
 **googleCloudKmsSignRequest** | [**GoogleCloudKmsSignRequest**](GoogleCloudKmsSignRequest.md)|  | 


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


<a name="googlecloudkmstrimkeyversions"></a>
# **GoogleCloudKmsTrimKeyVersions**

> void GoogleCloudKmsTrimKeyVersions (string key, string gcpkmsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKmsTrimKeyVersionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var key = "key_example";  // string | Name of the key in Vault.
            
            
            
            
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path that the backend was mounted at (default to "gcpkms")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudKmsTrimKeyVersions(string key, string gcpkmsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKmsTrimKeyVersions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key in Vault. | 
 **gcpkmsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcpkms&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="googlecloudkmstrimkeyversions2"></a>
# **GoogleCloudKmsTrimKeyVersions2**

> void GoogleCloudKmsTrimKeyVersions2 (string key, string gcpkmsMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKmsTrimKeyVersions2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var key = "key_example";  // string | Name of the key in Vault.
            
            
            
            
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path that the backend was mounted at (default to "gcpkms")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudKmsTrimKeyVersions2(string key, string gcpkmsMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKmsTrimKeyVersions2: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key in Vault. | 
 **gcpkmsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcpkms&quot;]


### Return type

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


<a name="googlecloudkmsverify"></a>
# **GoogleCloudKmsVerify**

> void GoogleCloudKmsVerify (string key, string gcpkmsMountPath, GoogleCloudKmsVerifyRequest googleCloudKmsVerifyRequest, TimeSpan? wrapTTL = null)

Verify a signature using a named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKmsVerifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var key = "key_example";  // string | Name of the key in Vault to use for verification. This key must already exist in Vault and must map back to a Google Cloud KMS key.
            
            
            
            
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path that the backend was mounted at (default to "gcpkms")
            
            
            
            
            
            var googleCloudKmsVerifyRequest = new GoogleCloudKmsVerifyRequest(); // GoogleCloudKmsVerifyRequest | 
            
            

            try
            {
                
                // Verify a signature using a named key
                

                apiInstance.GoogleCloudKmsVerify(string key, string gcpkmsMountPath, GoogleCloudKmsVerifyRequest googleCloudKmsVerifyRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKmsVerify: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key in Vault to use for verification. This key must already exist in Vault and must map back to a Google Cloud KMS key. | 
 **gcpkmsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcpkms&quot;]
 **googleCloudKmsVerifyRequest** | [**GoogleCloudKmsVerifyRequest**](GoogleCloudKmsVerifyRequest.md)|  | 


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


<a name="googlecloudkmswritekey"></a>
# **GoogleCloudKmsWriteKey**

> void GoogleCloudKmsWriteKey (string key, string gcpkmsMountPath, GoogleCloudKmsWriteKeyRequest googleCloudKmsWriteKeyRequest, TimeSpan? wrapTTL = null)

Interact with crypto keys in Vault and Google Cloud KMS

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKmsWriteKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var key = "key_example";  // string | Name of the key in Vault.
            
            
            
            
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path that the backend was mounted at (default to "gcpkms")
            
            
            
            
            
            var googleCloudKmsWriteKeyRequest = new GoogleCloudKmsWriteKeyRequest(); // GoogleCloudKmsWriteKeyRequest | 
            
            

            try
            {
                
                // Interact with crypto keys in Vault and Google Cloud KMS
                

                apiInstance.GoogleCloudKmsWriteKey(string key, string gcpkmsMountPath, GoogleCloudKmsWriteKeyRequest googleCloudKmsWriteKeyRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKmsWriteKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key in Vault. | 
 **gcpkmsMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcpkms&quot;]
 **googleCloudKmsWriteKeyRequest** | [**GoogleCloudKmsWriteKeyRequest**](GoogleCloudKmsWriteKeyRequest.md)|  | 


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


<a name="googlecloudlistimpersonatedaccounts"></a>
# **GoogleCloudListImpersonatedAccounts**

> void GoogleCloudListImpersonatedAccounts (string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudListImpersonatedAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                apiInstance.GoogleCloudListImpersonatedAccounts(string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudListImpersonatedAccounts: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="googlecloudlistimpersonatedaccounts2"></a>
# **GoogleCloudListImpersonatedAccounts2**

> void GoogleCloudListImpersonatedAccounts2 (string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudListImpersonatedAccounts2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                apiInstance.GoogleCloudListImpersonatedAccounts2(string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudListImpersonatedAccounts2: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="googlecloudlistrolesets"></a>
# **GoogleCloudListRolesets**

> void GoogleCloudListRolesets (string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudListRolesetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                apiInstance.GoogleCloudListRolesets(string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudListRolesets: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="googlecloudlistrolesets2"></a>
# **GoogleCloudListRolesets2**

> void GoogleCloudListRolesets2 (string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudListRolesets2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                apiInstance.GoogleCloudListRolesets2(string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudListRolesets2: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="googlecloudliststaticaccounts"></a>
# **GoogleCloudListStaticAccounts**

> void GoogleCloudListStaticAccounts (string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudListStaticAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                apiInstance.GoogleCloudListStaticAccounts(string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudListStaticAccounts: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="googlecloudliststaticaccounts2"></a>
# **GoogleCloudListStaticAccounts2**

> void GoogleCloudListStaticAccounts2 (string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudListStaticAccounts2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                apiInstance.GoogleCloudListStaticAccounts2(string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudListStaticAccounts2: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="googlecloudreadconfiguration"></a>
# **GoogleCloudReadConfiguration**

> void GoogleCloudReadConfiguration (string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudReadConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudReadConfiguration(string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudReadConfiguration: " + e.Message );
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


<a name="googlecloudreadimpersonatedaccount"></a>
# **GoogleCloudReadImpersonatedAccount**

> void GoogleCloudReadImpersonatedAccount (string name, string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudReadImpersonatedAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Required. Name to refer to this impersonated account in Vault. Cannot be updated.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudReadImpersonatedAccount(string name, string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudReadImpersonatedAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Required. Name to refer to this impersonated account in Vault. Cannot be updated. | 
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


<a name="googlecloudreadroleset"></a>
# **GoogleCloudReadRoleset**

> void GoogleCloudReadRoleset (string name, string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudReadRolesetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Required. Name of the role.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudReadRoleset(string name, string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudReadRoleset: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Required. Name of the role. | 
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


<a name="googlecloudreadstaticaccount"></a>
# **GoogleCloudReadStaticAccount**

> void GoogleCloudReadStaticAccount (string name, string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudReadStaticAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Required. Name to refer to this static account in Vault. Cannot be updated.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudReadStaticAccount(string name, string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudReadStaticAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Required. Name to refer to this static account in Vault. Cannot be updated. | 
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


<a name="googlecloudrotateroleset"></a>
# **GoogleCloudRotateRoleset**

> void GoogleCloudRotateRoleset (string name, string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudRotateRolesetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudRotateRoleset(string name, string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudRotateRoleset: " + e.Message );
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


<a name="googlecloudrotaterolesetkey"></a>
# **GoogleCloudRotateRolesetKey**

> void GoogleCloudRotateRolesetKey (string name, string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudRotateRolesetKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudRotateRolesetKey(string name, string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudRotateRolesetKey: " + e.Message );
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


<a name="googlecloudrotaterootcredentials"></a>
# **GoogleCloudRotateRootCredentials**

> void GoogleCloudRotateRootCredentials (string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudRotateRootCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudRotateRootCredentials(string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudRotateRootCredentials: " + e.Message );
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


<a name="googlecloudrotatestaticaccountkey"></a>
# **GoogleCloudRotateStaticAccountKey**

> void GoogleCloudRotateStaticAccountKey (string name, string gcpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudRotateStaticAccountKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the account.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            

            try
            {
                

                apiInstance.GoogleCloudRotateStaticAccountKey(string name, string gcpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudRotateStaticAccountKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the account. | 
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


<a name="googlecloudwriteimpersonatedaccount"></a>
# **GoogleCloudWriteImpersonatedAccount**

> void GoogleCloudWriteImpersonatedAccount (string name, string gcpMountPath, GoogleCloudWriteImpersonatedAccountRequest googleCloudWriteImpersonatedAccountRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudWriteImpersonatedAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Required. Name to refer to this impersonated account in Vault. Cannot be updated.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            
            
            
            var googleCloudWriteImpersonatedAccountRequest = new GoogleCloudWriteImpersonatedAccountRequest(); // GoogleCloudWriteImpersonatedAccountRequest | 
            
            

            try
            {
                

                apiInstance.GoogleCloudWriteImpersonatedAccount(string name, string gcpMountPath, GoogleCloudWriteImpersonatedAccountRequest googleCloudWriteImpersonatedAccountRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudWriteImpersonatedAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Required. Name to refer to this impersonated account in Vault. Cannot be updated. | 
 **gcpMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcp&quot;]
 **googleCloudWriteImpersonatedAccountRequest** | [**GoogleCloudWriteImpersonatedAccountRequest**](GoogleCloudWriteImpersonatedAccountRequest.md)|  | 


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


<a name="googlecloudwriteroleset"></a>
# **GoogleCloudWriteRoleset**

> void GoogleCloudWriteRoleset (string name, string gcpMountPath, GoogleCloudWriteRolesetRequest googleCloudWriteRolesetRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudWriteRolesetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Required. Name of the role.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            
            
            
            var googleCloudWriteRolesetRequest = new GoogleCloudWriteRolesetRequest(); // GoogleCloudWriteRolesetRequest | 
            
            

            try
            {
                

                apiInstance.GoogleCloudWriteRoleset(string name, string gcpMountPath, GoogleCloudWriteRolesetRequest googleCloudWriteRolesetRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudWriteRoleset: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Required. Name of the role. | 
 **gcpMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcp&quot;]
 **googleCloudWriteRolesetRequest** | [**GoogleCloudWriteRolesetRequest**](GoogleCloudWriteRolesetRequest.md)|  | 


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


<a name="googlecloudwritestaticaccount"></a>
# **GoogleCloudWriteStaticAccount**

> void GoogleCloudWriteStaticAccount (string name, string gcpMountPath, GoogleCloudWriteStaticAccountRequest googleCloudWriteStaticAccountRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudWriteStaticAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Required. Name to refer to this static account in Vault. Cannot be updated.
            
            
            
            
            var gcpMountPath = "\"gcp\"";  // string | Path that the backend was mounted at (default to "gcp")
            
            
            
            
            
            var googleCloudWriteStaticAccountRequest = new GoogleCloudWriteStaticAccountRequest(); // GoogleCloudWriteStaticAccountRequest | 
            
            

            try
            {
                

                apiInstance.GoogleCloudWriteStaticAccount(string name, string gcpMountPath, GoogleCloudWriteStaticAccountRequest googleCloudWriteStaticAccountRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudWriteStaticAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Required. Name to refer to this static account in Vault. Cannot be updated. | 
 **gcpMountPath** | **string**| Path that the backend was mounted at | [default to &quot;gcp&quot;]
 **googleCloudWriteStaticAccountRequest** | [**GoogleCloudWriteStaticAccountRequest**](GoogleCloudWriteStaticAccountRequest.md)|  | 


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


<a name="kubernetescheckconfiguration"></a>
# **KubernetesCheckConfiguration**

> void KubernetesCheckConfiguration (string kubernetesMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KubernetesCheckConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path that the backend was mounted at (default to "kubernetes")
            
            
            

            try
            {
                

                apiInstance.KubernetesCheckConfiguration(string kubernetesMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KubernetesCheckConfiguration: " + e.Message );
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


<a name="kubernetesconfigure"></a>
# **KubernetesConfigure**

> void KubernetesConfigure (string kubernetesMountPath, KubernetesConfigureRequest kubernetesConfigureRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KubernetesConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path that the backend was mounted at (default to "kubernetes")
            
            
            
            
            
            var kubernetesConfigureRequest = new KubernetesConfigureRequest(); // KubernetesConfigureRequest | 
            
            

            try
            {
                

                apiInstance.KubernetesConfigure(string kubernetesMountPath, KubernetesConfigureRequest kubernetesConfigureRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KubernetesConfigure: " + e.Message );
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
 **kubernetesConfigureRequest** | [**KubernetesConfigureRequest**](KubernetesConfigureRequest.md)|  | 


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


<a name="kubernetesdeleteconfiguration"></a>
# **KubernetesDeleteConfiguration**

> void KubernetesDeleteConfiguration (string kubernetesMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KubernetesDeleteConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path that the backend was mounted at (default to "kubernetes")
            
            
            

            try
            {
                

                apiInstance.KubernetesDeleteConfiguration(string kubernetesMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KubernetesDeleteConfiguration: " + e.Message );
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

| **204** | empty body |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="kubernetesdeleterole"></a>
# **KubernetesDeleteRole**

> void KubernetesDeleteRole (string name, string kubernetesMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KubernetesDeleteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            
            
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path that the backend was mounted at (default to "kubernetes")
            
            
            

            try
            {
                

                apiInstance.KubernetesDeleteRole(string name, string kubernetesMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KubernetesDeleteRole: " + e.Message );
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


<a name="kubernetesgeneratecredentials"></a>
# **KubernetesGenerateCredentials**

> void KubernetesGenerateCredentials (string name, string kubernetesMountPath, KubernetesGenerateCredentialsRequest kubernetesGenerateCredentialsRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KubernetesGenerateCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the Vault role
            
            
            
            
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path that the backend was mounted at (default to "kubernetes")
            
            
            
            
            
            var kubernetesGenerateCredentialsRequest = new KubernetesGenerateCredentialsRequest(); // KubernetesGenerateCredentialsRequest | 
            
            

            try
            {
                

                apiInstance.KubernetesGenerateCredentials(string name, string kubernetesMountPath, KubernetesGenerateCredentialsRequest kubernetesGenerateCredentialsRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KubernetesGenerateCredentials: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the Vault role | 
 **kubernetesMountPath** | **string**| Path that the backend was mounted at | [default to &quot;kubernetes&quot;]
 **kubernetesGenerateCredentialsRequest** | [**KubernetesGenerateCredentialsRequest**](KubernetesGenerateCredentialsRequest.md)|  | 


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


<a name="kuberneteslistroles"></a>
# **KubernetesListRoles**

> void KubernetesListRoles (string kubernetesMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KubernetesListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path that the backend was mounted at (default to "kubernetes")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                apiInstance.KubernetesListRoles(string kubernetesMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KubernetesListRoles: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="kubernetesreadconfiguration"></a>
# **KubernetesReadConfiguration**

> void KubernetesReadConfiguration (string kubernetesMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KubernetesReadConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path that the backend was mounted at (default to "kubernetes")
            
            
            

            try
            {
                

                apiInstance.KubernetesReadConfiguration(string kubernetesMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KubernetesReadConfiguration: " + e.Message );
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


<a name="kubernetesreadrole"></a>
# **KubernetesReadRole**

> void KubernetesReadRole (string name, string kubernetesMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KubernetesReadRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            
            
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path that the backend was mounted at (default to "kubernetes")
            
            
            

            try
            {
                

                apiInstance.KubernetesReadRole(string name, string kubernetesMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KubernetesReadRole: " + e.Message );
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


<a name="kuberneteswriterole"></a>
# **KubernetesWriteRole**

> void KubernetesWriteRole (string name, string kubernetesMountPath, KubernetesWriteRoleRequest kubernetesWriteRoleRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KubernetesWriteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            
            
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path that the backend was mounted at (default to "kubernetes")
            
            
            
            
            
            var kubernetesWriteRoleRequest = new KubernetesWriteRoleRequest(); // KubernetesWriteRoleRequest | 
            
            

            try
            {
                

                apiInstance.KubernetesWriteRole(string name, string kubernetesMountPath, KubernetesWriteRoleRequest kubernetesWriteRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KubernetesWriteRole: " + e.Message );
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
 **kubernetesMountPath** | **string**| Path that the backend was mounted at | [default to &quot;kubernetes&quot;]
 **kubernetesWriteRoleRequest** | [**KubernetesWriteRoleRequest**](KubernetesWriteRoleRequest.md)|  | 


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


<a name="kvv1delete"></a>
# **KvV1Delete**

> void KvV1Delete (string path, string kvV1MountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KvV1DeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var path = "path_example";  // string | Location of the secret.
            
            
            
            
            var kvV1MountPath = "\"kv-v1\"";  // string | Path that the backend was mounted at (default to "kv-v1")
            
            
            

            try
            {
                

                apiInstance.KvV1Delete(string path, string kvV1MountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KvV1Delete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 
 **kvV1MountPath** | **string**| Path that the backend was mounted at | [default to &quot;kv-v1&quot;]


### Return type

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


<a name="kvv1read"></a>
# **KvV1Read**

> void KvV1Read (string path, string kvV1MountPath, string list = default(string), TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KvV1ReadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var path = "path_example";  // string | Location of the secret.
            
            
            
            
            var kvV1MountPath = "\"kv-v1\"";  // string | Path that the backend was mounted at (default to "kv-v1")
            
            
            
            
            var list = "list_example";  // string | Return a list if `true` (optional) 
            
            
            

            try
            {
                

                apiInstance.KvV1Read(string path, string kvV1MountPath, string list = default(string), TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KvV1Read: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 
 **kvV1MountPath** | **string**| Path that the backend was mounted at | [default to &quot;kv-v1&quot;]
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


<a name="kvv1write"></a>
# **KvV1Write**

> void KvV1Write (string path, string kvV1MountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KvV1WriteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var path = "path_example";  // string | Location of the secret.
            
            
            
            
            var kvV1MountPath = "\"kv-v1\"";  // string | Path that the backend was mounted at (default to "kv-v1")
            
            
            

            try
            {
                

                apiInstance.KvV1Write(string path, string kvV1MountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KvV1Write: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 
 **kvV1MountPath** | **string**| Path that the backend was mounted at | [default to &quot;kv-v1&quot;]


### Return type

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


<a name="kvv2configure"></a>
# **KvV2Configure**

> void KvV2Configure (string kvV2MountPath, KvV2ConfigureRequest kvV2ConfigureRequest, TimeSpan? wrapTTL = null)

Configure backend level settings that are applied to every key in the key-value store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KvV2ConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var kvV2MountPath = "\"kv-v2\"";  // string | Path that the backend was mounted at (default to "kv-v2")
            
            
            
            
            
            var kvV2ConfigureRequest = new KvV2ConfigureRequest(); // KvV2ConfigureRequest | 
            
            

            try
            {
                
                // Configure backend level settings that are applied to every key in the key-value store.
                

                apiInstance.KvV2Configure(string kvV2MountPath, KvV2ConfigureRequest kvV2ConfigureRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KvV2Configure: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kvV2MountPath** | **string**| Path that the backend was mounted at | [default to &quot;kv-v2&quot;]
 **kvV2ConfigureRequest** | [**KvV2ConfigureRequest**](KvV2ConfigureRequest.md)|  | 


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


<a name="kvv2delete"></a>
# **KvV2Delete**

> void KvV2Delete (string path, string kvV2MountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KvV2DeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var path = "path_example";  // string | Location of the secret.
            
            
            
            
            var kvV2MountPath = "\"kv-v2\"";  // string | Path that the backend was mounted at (default to "kv-v2")
            
            
            

            try
            {
                

                apiInstance.KvV2Delete(string path, string kvV2MountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KvV2Delete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 
 **kvV2MountPath** | **string**| Path that the backend was mounted at | [default to &quot;kv-v2&quot;]


### Return type

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


<a name="kvv2deletemetadata"></a>
# **KvV2DeleteMetadata**

> void KvV2DeleteMetadata (string path, string kvV2MountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KvV2DeleteMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var path = "path_example";  // string | Location of the secret.
            
            
            
            
            var kvV2MountPath = "\"kv-v2\"";  // string | Path that the backend was mounted at (default to "kv-v2")
            
            
            

            try
            {
                

                apiInstance.KvV2DeleteMetadata(string path, string kvV2MountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KvV2DeleteMetadata: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 
 **kvV2MountPath** | **string**| Path that the backend was mounted at | [default to &quot;kv-v2&quot;]


### Return type

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


<a name="kvv2deleteversions"></a>
# **KvV2DeleteVersions**

> void KvV2DeleteVersions (string path, string kvV2MountPath, KvV2DeleteVersionsRequest kvV2DeleteVersionsRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KvV2DeleteVersionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var path = "path_example";  // string | Location of the secret.
            
            
            
            
            var kvV2MountPath = "\"kv-v2\"";  // string | Path that the backend was mounted at (default to "kv-v2")
            
            
            
            
            
            var kvV2DeleteVersionsRequest = new KvV2DeleteVersionsRequest(); // KvV2DeleteVersionsRequest | 
            
            

            try
            {
                

                apiInstance.KvV2DeleteVersions(string path, string kvV2MountPath, KvV2DeleteVersionsRequest kvV2DeleteVersionsRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KvV2DeleteVersions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 
 **kvV2MountPath** | **string**| Path that the backend was mounted at | [default to &quot;kv-v2&quot;]
 **kvV2DeleteVersionsRequest** | [**KvV2DeleteVersionsRequest**](KvV2DeleteVersionsRequest.md)|  | 


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


<a name="kvv2destroyversions"></a>
# **KvV2DestroyVersions**

> void KvV2DestroyVersions (string path, string kvV2MountPath, KvV2DestroyVersionsRequest kvV2DestroyVersionsRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KvV2DestroyVersionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var path = "path_example";  // string | Location of the secret.
            
            
            
            
            var kvV2MountPath = "\"kv-v2\"";  // string | Path that the backend was mounted at (default to "kv-v2")
            
            
            
            
            
            var kvV2DestroyVersionsRequest = new KvV2DestroyVersionsRequest(); // KvV2DestroyVersionsRequest | 
            
            

            try
            {
                

                apiInstance.KvV2DestroyVersions(string path, string kvV2MountPath, KvV2DestroyVersionsRequest kvV2DestroyVersionsRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KvV2DestroyVersions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 
 **kvV2MountPath** | **string**| Path that the backend was mounted at | [default to &quot;kv-v2&quot;]
 **kvV2DestroyVersionsRequest** | [**KvV2DestroyVersionsRequest**](KvV2DestroyVersionsRequest.md)|  | 


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


<a name="kvv2read"></a>
# **KvV2Read**

> KvV2ReadResponse KvV2Read (string path, string kvV2MountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KvV2ReadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var path = "path_example";  // string | Location of the secret.
            
            
            
            
            var kvV2MountPath = "\"kv-v2\"";  // string | Path that the backend was mounted at (default to "kv-v2")
            
            
            

            try
            {
                

                KvV2ReadResponse result = apiInstance.KvV2Read(string path, string kvV2MountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KvV2Read: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 
 **kvV2MountPath** | **string**| Path that the backend was mounted at | [default to &quot;kv-v2&quot;]


### Return type

[**KvV2ReadResponse**](KvV2ReadResponse.md)

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


<a name="kvv2readconfiguration"></a>
# **KvV2ReadConfiguration**

> KvV2ReadConfigurationResponse KvV2ReadConfiguration (string kvV2MountPath, TimeSpan? wrapTTL = null)

Read the backend level settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KvV2ReadConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var kvV2MountPath = "\"kv-v2\"";  // string | Path that the backend was mounted at (default to "kv-v2")
            
            
            

            try
            {
                
                // Read the backend level settings.
                

                KvV2ReadConfigurationResponse result = apiInstance.KvV2ReadConfiguration(string kvV2MountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KvV2ReadConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kvV2MountPath** | **string**| Path that the backend was mounted at | [default to &quot;kv-v2&quot;]


### Return type

[**KvV2ReadConfigurationResponse**](KvV2ReadConfigurationResponse.md)

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


<a name="kvv2readmetadata"></a>
# **KvV2ReadMetadata**

> KvV2ReadMetadataResponse KvV2ReadMetadata (string path, string kvV2MountPath, string list = default(string), TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KvV2ReadMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var path = "path_example";  // string | Location of the secret.
            
            
            
            
            var kvV2MountPath = "\"kv-v2\"";  // string | Path that the backend was mounted at (default to "kv-v2")
            
            
            
            
            var list = "list_example";  // string | Return a list if `true` (optional) 
            
            
            

            try
            {
                

                KvV2ReadMetadataResponse result = apiInstance.KvV2ReadMetadata(string path, string kvV2MountPath, string list = default(string), TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KvV2ReadMetadata: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 
 **kvV2MountPath** | **string**| Path that the backend was mounted at | [default to &quot;kv-v2&quot;]
 **list** | **string**| Return a list if &#x60;true&#x60; | [optional] 


### Return type

[**KvV2ReadMetadataResponse**](KvV2ReadMetadataResponse.md)

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


<a name="kvv2readsubkeys"></a>
# **KvV2ReadSubkeys**

> KvV2ReadSubkeysResponse KvV2ReadSubkeys (string path, string kvV2MountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KvV2ReadSubkeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var path = "path_example";  // string | Location of the secret.
            
            
            
            
            var kvV2MountPath = "\"kv-v2\"";  // string | Path that the backend was mounted at (default to "kv-v2")
            
            
            

            try
            {
                

                KvV2ReadSubkeysResponse result = apiInstance.KvV2ReadSubkeys(string path, string kvV2MountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KvV2ReadSubkeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 
 **kvV2MountPath** | **string**| Path that the backend was mounted at | [default to &quot;kv-v2&quot;]


### Return type

[**KvV2ReadSubkeysResponse**](KvV2ReadSubkeysResponse.md)

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


<a name="kvv2undeleteversions"></a>
# **KvV2UndeleteVersions**

> void KvV2UndeleteVersions (string path, string kvV2MountPath, KvV2UndeleteVersionsRequest kvV2UndeleteVersionsRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KvV2UndeleteVersionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var path = "path_example";  // string | Location of the secret.
            
            
            
            
            var kvV2MountPath = "\"kv-v2\"";  // string | Path that the backend was mounted at (default to "kv-v2")
            
            
            
            
            
            var kvV2UndeleteVersionsRequest = new KvV2UndeleteVersionsRequest(); // KvV2UndeleteVersionsRequest | 
            
            

            try
            {
                

                apiInstance.KvV2UndeleteVersions(string path, string kvV2MountPath, KvV2UndeleteVersionsRequest kvV2UndeleteVersionsRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KvV2UndeleteVersions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 
 **kvV2MountPath** | **string**| Path that the backend was mounted at | [default to &quot;kv-v2&quot;]
 **kvV2UndeleteVersionsRequest** | [**KvV2UndeleteVersionsRequest**](KvV2UndeleteVersionsRequest.md)|  | 


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


<a name="kvv2write"></a>
# **KvV2Write**

> KvV2WriteResponse KvV2Write (string path, string kvV2MountPath, KvV2WriteRequest kvV2WriteRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KvV2WriteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var path = "path_example";  // string | Location of the secret.
            
            
            
            
            var kvV2MountPath = "\"kv-v2\"";  // string | Path that the backend was mounted at (default to "kv-v2")
            
            
            
            
            
            var kvV2WriteRequest = new KvV2WriteRequest(); // KvV2WriteRequest | 
            
            

            try
            {
                

                KvV2WriteResponse result = apiInstance.KvV2Write(string path, string kvV2MountPath, KvV2WriteRequest kvV2WriteRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KvV2Write: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 
 **kvV2MountPath** | **string**| Path that the backend was mounted at | [default to &quot;kv-v2&quot;]
 **kvV2WriteRequest** | [**KvV2WriteRequest**](KvV2WriteRequest.md)|  | 


### Return type

[**KvV2WriteResponse**](KvV2WriteResponse.md)

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


<a name="kvv2writemetadata"></a>
# **KvV2WriteMetadata**

> void KvV2WriteMetadata (string path, string kvV2MountPath, KvV2WriteMetadataRequest kvV2WriteMetadataRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KvV2WriteMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var path = "path_example";  // string | Location of the secret.
            
            
            
            
            var kvV2MountPath = "\"kv-v2\"";  // string | Path that the backend was mounted at (default to "kv-v2")
            
            
            
            
            
            var kvV2WriteMetadataRequest = new KvV2WriteMetadataRequest(); // KvV2WriteMetadataRequest | 
            
            

            try
            {
                

                apiInstance.KvV2WriteMetadata(string path, string kvV2MountPath, KvV2WriteMetadataRequest kvV2WriteMetadataRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KvV2WriteMetadata: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 
 **kvV2MountPath** | **string**| Path that the backend was mounted at | [default to &quot;kv-v2&quot;]
 **kvV2WriteMetadataRequest** | [**KvV2WriteMetadataRequest**](KvV2WriteMetadataRequest.md)|  | 


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


<a name="ldapconfigure"></a>
# **LdapConfigure**

> void LdapConfigure (string ldapMountPath, LdapConfigureRequest ldapConfigureRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LdapConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            
            
            
            var ldapConfigureRequest = new LdapConfigureRequest(); // LdapConfigureRequest | 
            
            

            try
            {
                

                apiInstance.LdapConfigure(string ldapMountPath, LdapConfigureRequest ldapConfigureRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LdapConfigure: " + e.Message );
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
 **ldapConfigureRequest** | [**LdapConfigureRequest**](LdapConfigureRequest.md)|  | 


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


<a name="ldapdeleteconfiguration"></a>
# **LdapDeleteConfiguration**

> void LdapDeleteConfiguration (string ldapMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LdapDeleteConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            

            try
            {
                

                apiInstance.LdapDeleteConfiguration(string ldapMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LdapDeleteConfiguration: " + e.Message );
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

| **204** | empty body |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="ldapdeletedynamicrole"></a>
# **LdapDeleteDynamicRole**

> void LdapDeleteDynamicRole (string name, string ldapMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LdapDeleteDynamicRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role (lowercase)
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            

            try
            {
                

                apiInstance.LdapDeleteDynamicRole(string name, string ldapMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LdapDeleteDynamicRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the role (lowercase) | 
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


<a name="ldapdeletestaticrole"></a>
# **LdapDeleteStaticRole**

> void LdapDeleteStaticRole (string name, string ldapMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LdapDeleteStaticRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            

            try
            {
                

                apiInstance.LdapDeleteStaticRole(string name, string ldapMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LdapDeleteStaticRole: " + e.Message );
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


<a name="ldaplibrarycheckin"></a>
# **LdapLibraryCheckIn**

> void LdapLibraryCheckIn (string name, string ldapMountPath, LdapLibraryCheckInRequest ldapLibraryCheckInRequest, TimeSpan? wrapTTL = null)

Check service accounts in to the library.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LdapLibraryCheckInExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the set.
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            
            
            
            var ldapLibraryCheckInRequest = new LdapLibraryCheckInRequest(); // LdapLibraryCheckInRequest | 
            
            

            try
            {
                
                // Check service accounts in to the library.
                

                apiInstance.LdapLibraryCheckIn(string name, string ldapMountPath, LdapLibraryCheckInRequest ldapLibraryCheckInRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LdapLibraryCheckIn: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the set. | 
 **ldapMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ldap&quot;]
 **ldapLibraryCheckInRequest** | [**LdapLibraryCheckInRequest**](LdapLibraryCheckInRequest.md)|  | 


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


<a name="ldaplibrarycheckout"></a>
# **LdapLibraryCheckOut**

> void LdapLibraryCheckOut (string name, string ldapMountPath, LdapLibraryCheckOutRequest ldapLibraryCheckOutRequest, TimeSpan? wrapTTL = null)

Check a service account out from the library.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LdapLibraryCheckOutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the set
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            
            
            
            var ldapLibraryCheckOutRequest = new LdapLibraryCheckOutRequest(); // LdapLibraryCheckOutRequest | 
            
            

            try
            {
                
                // Check a service account out from the library.
                

                apiInstance.LdapLibraryCheckOut(string name, string ldapMountPath, LdapLibraryCheckOutRequest ldapLibraryCheckOutRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LdapLibraryCheckOut: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the set | 
 **ldapMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ldap&quot;]
 **ldapLibraryCheckOutRequest** | [**LdapLibraryCheckOutRequest**](LdapLibraryCheckOutRequest.md)|  | 


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


<a name="ldaplibrarycheckstatus"></a>
# **LdapLibraryCheckStatus**

> void LdapLibraryCheckStatus (string name, string ldapMountPath, TimeSpan? wrapTTL = null)

Check the status of the service accounts in a library set.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LdapLibraryCheckStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the set.
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            

            try
            {
                
                // Check the status of the service accounts in a library set.
                

                apiInstance.LdapLibraryCheckStatus(string name, string ldapMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LdapLibraryCheckStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the set. | 
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


<a name="ldaplibraryconfigure"></a>
# **LdapLibraryConfigure**

> void LdapLibraryConfigure (string name, string ldapMountPath, LdapLibraryConfigureRequest ldapLibraryConfigureRequest, TimeSpan? wrapTTL = null)

Update a library set.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LdapLibraryConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the set.
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            
            
            
            var ldapLibraryConfigureRequest = new LdapLibraryConfigureRequest(); // LdapLibraryConfigureRequest | 
            
            

            try
            {
                
                // Update a library set.
                

                apiInstance.LdapLibraryConfigure(string name, string ldapMountPath, LdapLibraryConfigureRequest ldapLibraryConfigureRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LdapLibraryConfigure: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the set. | 
 **ldapMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ldap&quot;]
 **ldapLibraryConfigureRequest** | [**LdapLibraryConfigureRequest**](LdapLibraryConfigureRequest.md)|  | 


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


<a name="ldaplibrarydelete"></a>
# **LdapLibraryDelete**

> void LdapLibraryDelete (string name, string ldapMountPath, TimeSpan? wrapTTL = null)

Delete a library set.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LdapLibraryDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the set.
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            

            try
            {
                
                // Delete a library set.
                

                apiInstance.LdapLibraryDelete(string name, string ldapMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LdapLibraryDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the set. | 
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


<a name="ldaplibraryforcecheckin"></a>
# **LdapLibraryForceCheckIn**

> void LdapLibraryForceCheckIn (string name, string ldapMountPath, LdapLibraryForceCheckInRequest ldapLibraryForceCheckInRequest, TimeSpan? wrapTTL = null)

Check service accounts in to the library.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LdapLibraryForceCheckInExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the set.
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            
            
            
            var ldapLibraryForceCheckInRequest = new LdapLibraryForceCheckInRequest(); // LdapLibraryForceCheckInRequest | 
            
            

            try
            {
                
                // Check service accounts in to the library.
                

                apiInstance.LdapLibraryForceCheckIn(string name, string ldapMountPath, LdapLibraryForceCheckInRequest ldapLibraryForceCheckInRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LdapLibraryForceCheckIn: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the set. | 
 **ldapMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ldap&quot;]
 **ldapLibraryForceCheckInRequest** | [**LdapLibraryForceCheckInRequest**](LdapLibraryForceCheckInRequest.md)|  | 


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


<a name="ldaplibrarylist"></a>
# **LdapLibraryList**

> void LdapLibraryList (string ldapMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LdapLibraryListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                apiInstance.LdapLibraryList(string ldapMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LdapLibraryList: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="ldaplibraryread"></a>
# **LdapLibraryRead**

> void LdapLibraryRead (string name, string ldapMountPath, TimeSpan? wrapTTL = null)

Read a library set.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LdapLibraryReadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the set.
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            

            try
            {
                
                // Read a library set.
                

                apiInstance.LdapLibraryRead(string name, string ldapMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LdapLibraryRead: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the set. | 
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


<a name="ldaplistdynamicroles"></a>
# **LdapListDynamicRoles**

> void LdapListDynamicRoles (string ldapMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LdapListDynamicRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                apiInstance.LdapListDynamicRoles(string ldapMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LdapListDynamicRoles: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="ldapliststaticroles"></a>
# **LdapListStaticRoles**

> void LdapListStaticRoles (string ldapMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LdapListStaticRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                apiInstance.LdapListStaticRoles(string ldapMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LdapListStaticRoles: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="ldapreadconfiguration"></a>
# **LdapReadConfiguration**

> void LdapReadConfiguration (string ldapMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LdapReadConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            

            try
            {
                

                apiInstance.LdapReadConfiguration(string ldapMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LdapReadConfiguration: " + e.Message );
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


<a name="ldapreaddynamicrole"></a>
# **LdapReadDynamicRole**

> void LdapReadDynamicRole (string name, string ldapMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LdapReadDynamicRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role (lowercase)
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            

            try
            {
                

                apiInstance.LdapReadDynamicRole(string name, string ldapMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LdapReadDynamicRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the role (lowercase) | 
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


<a name="ldapreadstaticrole"></a>
# **LdapReadStaticRole**

> void LdapReadStaticRole (string name, string ldapMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LdapReadStaticRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            

            try
            {
                

                apiInstance.LdapReadStaticRole(string name, string ldapMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LdapReadStaticRole: " + e.Message );
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


<a name="ldaprequestdynamicrolecredentials"></a>
# **LdapRequestDynamicRoleCredentials**

> void LdapRequestDynamicRoleCredentials (string name, string ldapMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LdapRequestDynamicRoleCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the dynamic role.
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            

            try
            {
                

                apiInstance.LdapRequestDynamicRoleCredentials(string name, string ldapMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LdapRequestDynamicRoleCredentials: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the dynamic role. | 
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


<a name="ldaprequeststaticrolecredentials"></a>
# **LdapRequestStaticRoleCredentials**

> void LdapRequestStaticRoleCredentials (string name, string ldapMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LdapRequestStaticRoleCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the static role.
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            

            try
            {
                

                apiInstance.LdapRequestStaticRoleCredentials(string name, string ldapMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LdapRequestStaticRoleCredentials: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the static role. | 
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


<a name="ldaprotaterootcredentials"></a>
# **LdapRotateRootCredentials**

> void LdapRotateRootCredentials (string ldapMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LdapRotateRootCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            

            try
            {
                

                apiInstance.LdapRotateRootCredentials(string ldapMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LdapRotateRootCredentials: " + e.Message );
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


<a name="ldaprotatestaticrole"></a>
# **LdapRotateStaticRole**

> void LdapRotateStaticRole (string name, string ldapMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LdapRotateStaticRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the static role
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            

            try
            {
                

                apiInstance.LdapRotateStaticRole(string name, string ldapMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LdapRotateStaticRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the static role | 
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


<a name="ldapwritedynamicrole"></a>
# **LdapWriteDynamicRole**

> void LdapWriteDynamicRole (string name, string ldapMountPath, LdapWriteDynamicRoleRequest ldapWriteDynamicRoleRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LdapWriteDynamicRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role (lowercase)
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            
            
            
            var ldapWriteDynamicRoleRequest = new LdapWriteDynamicRoleRequest(); // LdapWriteDynamicRoleRequest | 
            
            

            try
            {
                

                apiInstance.LdapWriteDynamicRole(string name, string ldapMountPath, LdapWriteDynamicRoleRequest ldapWriteDynamicRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LdapWriteDynamicRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the role (lowercase) | 
 **ldapMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ldap&quot;]
 **ldapWriteDynamicRoleRequest** | [**LdapWriteDynamicRoleRequest**](LdapWriteDynamicRoleRequest.md)|  | 


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


<a name="ldapwritestaticrole"></a>
# **LdapWriteStaticRole**

> void LdapWriteStaticRole (string name, string ldapMountPath, LdapWriteStaticRoleRequest ldapWriteStaticRoleRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LdapWriteStaticRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            
            
            var ldapMountPath = "\"ldap\"";  // string | Path that the backend was mounted at (default to "ldap")
            
            
            
            
            
            var ldapWriteStaticRoleRequest = new LdapWriteStaticRoleRequest(); // LdapWriteStaticRoleRequest | 
            
            

            try
            {
                

                apiInstance.LdapWriteStaticRole(string name, string ldapMountPath, LdapWriteStaticRoleRequest ldapWriteStaticRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LdapWriteStaticRole: " + e.Message );
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
 **ldapMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ldap&quot;]
 **ldapWriteStaticRoleRequest** | [**LdapWriteStaticRoleRequest**](LdapWriteStaticRoleRequest.md)|  | 


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


<a name="mongodbatlasconfigure"></a>
# **MongoDbAtlasConfigure**

> void MongoDbAtlasConfigure (string mongodbatlasMountPath, MongoDbAtlasConfigureRequest mongoDbAtlasConfigureRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MongoDbAtlasConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var mongodbatlasMountPath = "\"mongodbatlas\"";  // string | Path that the backend was mounted at (default to "mongodbatlas")
            
            
            
            
            
            var mongoDbAtlasConfigureRequest = new MongoDbAtlasConfigureRequest(); // MongoDbAtlasConfigureRequest | 
            
            

            try
            {
                

                apiInstance.MongoDbAtlasConfigure(string mongodbatlasMountPath, MongoDbAtlasConfigureRequest mongoDbAtlasConfigureRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.MongoDbAtlasConfigure: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mongodbatlasMountPath** | **string**| Path that the backend was mounted at | [default to &quot;mongodbatlas&quot;]
 **mongoDbAtlasConfigureRequest** | [**MongoDbAtlasConfigureRequest**](MongoDbAtlasConfigureRequest.md)|  | 


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


<a name="mongodbatlasdeleterole"></a>
# **MongoDbAtlasDeleteRole**

> void MongoDbAtlasDeleteRole (string name, string mongodbatlasMountPath, TimeSpan? wrapTTL = null)

Manage the roles used to generate MongoDB Atlas Programmatic API Keys.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MongoDbAtlasDeleteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the Roles
            
            
            
            
            var mongodbatlasMountPath = "\"mongodbatlas\"";  // string | Path that the backend was mounted at (default to "mongodbatlas")
            
            
            

            try
            {
                
                // Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
                

                apiInstance.MongoDbAtlasDeleteRole(string name, string mongodbatlasMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.MongoDbAtlasDeleteRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the Roles | 
 **mongodbatlasMountPath** | **string**| Path that the backend was mounted at | [default to &quot;mongodbatlas&quot;]


### Return type

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


<a name="mongodbatlasgeneratecredentials"></a>
# **MongoDbAtlasGenerateCredentials**

> void MongoDbAtlasGenerateCredentials (string name, string mongodbatlasMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MongoDbAtlasGenerateCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            
            
            var mongodbatlasMountPath = "\"mongodbatlas\"";  // string | Path that the backend was mounted at (default to "mongodbatlas")
            
            
            

            try
            {
                

                apiInstance.MongoDbAtlasGenerateCredentials(string name, string mongodbatlasMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.MongoDbAtlasGenerateCredentials: " + e.Message );
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
 **mongodbatlasMountPath** | **string**| Path that the backend was mounted at | [default to &quot;mongodbatlas&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mongodbatlasgeneratecredentials2"></a>
# **MongoDbAtlasGenerateCredentials2**

> void MongoDbAtlasGenerateCredentials2 (string name, string mongodbatlasMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MongoDbAtlasGenerateCredentials2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            
            
            var mongodbatlasMountPath = "\"mongodbatlas\"";  // string | Path that the backend was mounted at (default to "mongodbatlas")
            
            
            

            try
            {
                

                apiInstance.MongoDbAtlasGenerateCredentials2(string name, string mongodbatlasMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.MongoDbAtlasGenerateCredentials2: " + e.Message );
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
 **mongodbatlasMountPath** | **string**| Path that the backend was mounted at | [default to &quot;mongodbatlas&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mongodbatlaslistroles"></a>
# **MongoDbAtlasListRoles**

> void MongoDbAtlasListRoles (string mongodbatlasMountPath, TimeSpan? wrapTTL = null)

List the existing roles in this backend

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MongoDbAtlasListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var mongodbatlasMountPath = "\"mongodbatlas\"";  // string | Path that the backend was mounted at (default to "mongodbatlas")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // List the existing roles in this backend
                

                apiInstance.MongoDbAtlasListRoles(string mongodbatlasMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.MongoDbAtlasListRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mongodbatlasMountPath** | **string**| Path that the backend was mounted at | [default to &quot;mongodbatlas&quot;]
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


<a name="mongodbatlasreadconfiguration"></a>
# **MongoDbAtlasReadConfiguration**

> void MongoDbAtlasReadConfiguration (string mongodbatlasMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MongoDbAtlasReadConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var mongodbatlasMountPath = "\"mongodbatlas\"";  // string | Path that the backend was mounted at (default to "mongodbatlas")
            
            
            

            try
            {
                

                apiInstance.MongoDbAtlasReadConfiguration(string mongodbatlasMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.MongoDbAtlasReadConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mongodbatlasMountPath** | **string**| Path that the backend was mounted at | [default to &quot;mongodbatlas&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mongodbatlasreadrole"></a>
# **MongoDbAtlasReadRole**

> void MongoDbAtlasReadRole (string name, string mongodbatlasMountPath, TimeSpan? wrapTTL = null)

Manage the roles used to generate MongoDB Atlas Programmatic API Keys.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MongoDbAtlasReadRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the Roles
            
            
            
            
            var mongodbatlasMountPath = "\"mongodbatlas\"";  // string | Path that the backend was mounted at (default to "mongodbatlas")
            
            
            

            try
            {
                
                // Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
                

                apiInstance.MongoDbAtlasReadRole(string name, string mongodbatlasMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.MongoDbAtlasReadRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the Roles | 
 **mongodbatlasMountPath** | **string**| Path that the backend was mounted at | [default to &quot;mongodbatlas&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="mongodbatlaswriterole"></a>
# **MongoDbAtlasWriteRole**

> void MongoDbAtlasWriteRole (string name, string mongodbatlasMountPath, MongoDbAtlasWriteRoleRequest mongoDbAtlasWriteRoleRequest, TimeSpan? wrapTTL = null)

Manage the roles used to generate MongoDB Atlas Programmatic API Keys.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MongoDbAtlasWriteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the Roles
            
            
            
            
            var mongodbatlasMountPath = "\"mongodbatlas\"";  // string | Path that the backend was mounted at (default to "mongodbatlas")
            
            
            
            
            
            var mongoDbAtlasWriteRoleRequest = new MongoDbAtlasWriteRoleRequest(); // MongoDbAtlasWriteRoleRequest | 
            
            

            try
            {
                
                // Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
                

                apiInstance.MongoDbAtlasWriteRole(string name, string mongodbatlasMountPath, MongoDbAtlasWriteRoleRequest mongoDbAtlasWriteRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.MongoDbAtlasWriteRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the Roles | 
 **mongodbatlasMountPath** | **string**| Path that the backend was mounted at | [default to &quot;mongodbatlas&quot;]
 **mongoDbAtlasWriteRoleRequest** | [**MongoDbAtlasWriteRoleRequest**](MongoDbAtlasWriteRoleRequest.md)|  | 


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


<a name="nomadconfigureaccess"></a>
# **NomadConfigureAccess**

> void NomadConfigureAccess (string nomadMountPath, NomadConfigureAccessRequest nomadConfigureAccessRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class NomadConfigureAccessExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var nomadMountPath = "\"nomad\"";  // string | Path that the backend was mounted at (default to "nomad")
            
            
            
            
            
            var nomadConfigureAccessRequest = new NomadConfigureAccessRequest(); // NomadConfigureAccessRequest | 
            
            

            try
            {
                

                apiInstance.NomadConfigureAccess(string nomadMountPath, NomadConfigureAccessRequest nomadConfigureAccessRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.NomadConfigureAccess: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nomadMountPath** | **string**| Path that the backend was mounted at | [default to &quot;nomad&quot;]
 **nomadConfigureAccessRequest** | [**NomadConfigureAccessRequest**](NomadConfigureAccessRequest.md)|  | 


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


<a name="nomadconfigurelease"></a>
# **NomadConfigureLease**

> void NomadConfigureLease (string nomadMountPath, NomadConfigureLeaseRequest nomadConfigureLeaseRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class NomadConfigureLeaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var nomadMountPath = "\"nomad\"";  // string | Path that the backend was mounted at (default to "nomad")
            
            
            
            
            
            var nomadConfigureLeaseRequest = new NomadConfigureLeaseRequest(); // NomadConfigureLeaseRequest | 
            
            

            try
            {
                

                apiInstance.NomadConfigureLease(string nomadMountPath, NomadConfigureLeaseRequest nomadConfigureLeaseRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.NomadConfigureLease: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nomadMountPath** | **string**| Path that the backend was mounted at | [default to &quot;nomad&quot;]
 **nomadConfigureLeaseRequest** | [**NomadConfigureLeaseRequest**](NomadConfigureLeaseRequest.md)|  | 


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


<a name="nomaddeleteaccessconfiguration"></a>
# **NomadDeleteAccessConfiguration**

> void NomadDeleteAccessConfiguration (string nomadMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class NomadDeleteAccessConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var nomadMountPath = "\"nomad\"";  // string | Path that the backend was mounted at (default to "nomad")
            
            
            

            try
            {
                

                apiInstance.NomadDeleteAccessConfiguration(string nomadMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.NomadDeleteAccessConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nomadMountPath** | **string**| Path that the backend was mounted at | [default to &quot;nomad&quot;]


### Return type

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


<a name="nomaddeleteleaseconfiguration"></a>
# **NomadDeleteLeaseConfiguration**

> void NomadDeleteLeaseConfiguration (string nomadMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class NomadDeleteLeaseConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var nomadMountPath = "\"nomad\"";  // string | Path that the backend was mounted at (default to "nomad")
            
            
            

            try
            {
                

                apiInstance.NomadDeleteLeaseConfiguration(string nomadMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.NomadDeleteLeaseConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nomadMountPath** | **string**| Path that the backend was mounted at | [default to &quot;nomad&quot;]


### Return type

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


<a name="nomaddeleterole"></a>
# **NomadDeleteRole**

> void NomadDeleteRole (string name, string nomadMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class NomadDeleteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            
            
            var nomadMountPath = "\"nomad\"";  // string | Path that the backend was mounted at (default to "nomad")
            
            
            

            try
            {
                

                apiInstance.NomadDeleteRole(string name, string nomadMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.NomadDeleteRole: " + e.Message );
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
 **nomadMountPath** | **string**| Path that the backend was mounted at | [default to &quot;nomad&quot;]


### Return type

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


<a name="nomadgeneratecredentials"></a>
# **NomadGenerateCredentials**

> void NomadGenerateCredentials (string name, string nomadMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class NomadGenerateCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            
            
            var nomadMountPath = "\"nomad\"";  // string | Path that the backend was mounted at (default to "nomad")
            
            
            

            try
            {
                

                apiInstance.NomadGenerateCredentials(string name, string nomadMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.NomadGenerateCredentials: " + e.Message );
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
 **nomadMountPath** | **string**| Path that the backend was mounted at | [default to &quot;nomad&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="nomadlistroles"></a>
# **NomadListRoles**

> void NomadListRoles (string nomadMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class NomadListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var nomadMountPath = "\"nomad\"";  // string | Path that the backend was mounted at (default to "nomad")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                apiInstance.NomadListRoles(string nomadMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.NomadListRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nomadMountPath** | **string**| Path that the backend was mounted at | [default to &quot;nomad&quot;]
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


<a name="nomadreadaccessconfiguration"></a>
# **NomadReadAccessConfiguration**

> void NomadReadAccessConfiguration (string nomadMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class NomadReadAccessConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var nomadMountPath = "\"nomad\"";  // string | Path that the backend was mounted at (default to "nomad")
            
            
            

            try
            {
                

                apiInstance.NomadReadAccessConfiguration(string nomadMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.NomadReadAccessConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nomadMountPath** | **string**| Path that the backend was mounted at | [default to &quot;nomad&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="nomadreadleaseconfiguration"></a>
# **NomadReadLeaseConfiguration**

> void NomadReadLeaseConfiguration (string nomadMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class NomadReadLeaseConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var nomadMountPath = "\"nomad\"";  // string | Path that the backend was mounted at (default to "nomad")
            
            
            

            try
            {
                

                apiInstance.NomadReadLeaseConfiguration(string nomadMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.NomadReadLeaseConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nomadMountPath** | **string**| Path that the backend was mounted at | [default to &quot;nomad&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="nomadreadrole"></a>
# **NomadReadRole**

> void NomadReadRole (string name, string nomadMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class NomadReadRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            
            
            var nomadMountPath = "\"nomad\"";  // string | Path that the backend was mounted at (default to "nomad")
            
            
            

            try
            {
                

                apiInstance.NomadReadRole(string name, string nomadMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.NomadReadRole: " + e.Message );
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
 **nomadMountPath** | **string**| Path that the backend was mounted at | [default to &quot;nomad&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="nomadwriterole"></a>
# **NomadWriteRole**

> void NomadWriteRole (string name, string nomadMountPath, NomadWriteRoleRequest nomadWriteRoleRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class NomadWriteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            
            
            var nomadMountPath = "\"nomad\"";  // string | Path that the backend was mounted at (default to "nomad")
            
            
            
            
            
            var nomadWriteRoleRequest = new NomadWriteRoleRequest(); // NomadWriteRoleRequest | 
            
            

            try
            {
                

                apiInstance.NomadWriteRole(string name, string nomadMountPath, NomadWriteRoleRequest nomadWriteRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.NomadWriteRole: " + e.Message );
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
 **nomadMountPath** | **string**| Path that the backend was mounted at | [default to &quot;nomad&quot;]
 **nomadWriteRoleRequest** | [**NomadWriteRoleRequest**](NomadWriteRoleRequest.md)|  | 


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


<a name="pkiconfigureautotidy"></a>
# **PkiConfigureAutoTidy**

> PkiConfigureAutoTidyResponse PkiConfigureAutoTidy (string pkiMountPath, PkiConfigureAutoTidyRequest pkiConfigureAutoTidyRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiConfigureAutoTidyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiConfigureAutoTidyRequest = new PkiConfigureAutoTidyRequest(); // PkiConfigureAutoTidyRequest | 
            
            

            try
            {
                

                PkiConfigureAutoTidyResponse result = apiInstance.PkiConfigureAutoTidy(string pkiMountPath, PkiConfigureAutoTidyRequest pkiConfigureAutoTidyRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiConfigureAutoTidy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiConfigureAutoTidyRequest** | [**PkiConfigureAutoTidyRequest**](PkiConfigureAutoTidyRequest.md)|  | 


### Return type

[**PkiConfigureAutoTidyResponse**](PkiConfigureAutoTidyResponse.md)

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


<a name="pkiconfigureca"></a>
# **PkiConfigureCa**

> PkiConfigureCaResponse PkiConfigureCa (string pkiMountPath, PkiConfigureCaRequest pkiConfigureCaRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiConfigureCaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiConfigureCaRequest = new PkiConfigureCaRequest(); // PkiConfigureCaRequest | 
            
            

            try
            {
                

                PkiConfigureCaResponse result = apiInstance.PkiConfigureCa(string pkiMountPath, PkiConfigureCaRequest pkiConfigureCaRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiConfigureCa: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiConfigureCaRequest** | [**PkiConfigureCaRequest**](PkiConfigureCaRequest.md)|  | 


### Return type

[**PkiConfigureCaResponse**](PkiConfigureCaResponse.md)

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


<a name="pkiconfigurecluster"></a>
# **PkiConfigureCluster**

> PkiConfigureClusterResponse PkiConfigureCluster (string pkiMountPath, PkiConfigureClusterRequest pkiConfigureClusterRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiConfigureClusterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiConfigureClusterRequest = new PkiConfigureClusterRequest(); // PkiConfigureClusterRequest | 
            
            

            try
            {
                

                PkiConfigureClusterResponse result = apiInstance.PkiConfigureCluster(string pkiMountPath, PkiConfigureClusterRequest pkiConfigureClusterRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiConfigureCluster: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiConfigureClusterRequest** | [**PkiConfigureClusterRequest**](PkiConfigureClusterRequest.md)|  | 


### Return type

[**PkiConfigureClusterResponse**](PkiConfigureClusterResponse.md)

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


<a name="pkiconfigurecrl"></a>
# **PkiConfigureCrl**

> PkiConfigureCrlResponse PkiConfigureCrl (string pkiMountPath, PkiConfigureCrlRequest pkiConfigureCrlRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiConfigureCrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiConfigureCrlRequest = new PkiConfigureCrlRequest(); // PkiConfigureCrlRequest | 
            
            

            try
            {
                

                PkiConfigureCrlResponse result = apiInstance.PkiConfigureCrl(string pkiMountPath, PkiConfigureCrlRequest pkiConfigureCrlRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiConfigureCrl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiConfigureCrlRequest** | [**PkiConfigureCrlRequest**](PkiConfigureCrlRequest.md)|  | 


### Return type

[**PkiConfigureCrlResponse**](PkiConfigureCrlResponse.md)

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


<a name="pkiconfigureissuers"></a>
# **PkiConfigureIssuers**

> PkiConfigureIssuersResponse PkiConfigureIssuers (string pkiMountPath, PkiConfigureIssuersRequest pkiConfigureIssuersRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiConfigureIssuersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiConfigureIssuersRequest = new PkiConfigureIssuersRequest(); // PkiConfigureIssuersRequest | 
            
            

            try
            {
                

                PkiConfigureIssuersResponse result = apiInstance.PkiConfigureIssuers(string pkiMountPath, PkiConfigureIssuersRequest pkiConfigureIssuersRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiConfigureIssuers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiConfigureIssuersRequest** | [**PkiConfigureIssuersRequest**](PkiConfigureIssuersRequest.md)|  | 


### Return type

[**PkiConfigureIssuersResponse**](PkiConfigureIssuersResponse.md)

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


<a name="pkiconfigurekeys"></a>
# **PkiConfigureKeys**

> PkiConfigureKeysResponse PkiConfigureKeys (string pkiMountPath, PkiConfigureKeysRequest pkiConfigureKeysRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiConfigureKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiConfigureKeysRequest = new PkiConfigureKeysRequest(); // PkiConfigureKeysRequest | 
            
            

            try
            {
                

                PkiConfigureKeysResponse result = apiInstance.PkiConfigureKeys(string pkiMountPath, PkiConfigureKeysRequest pkiConfigureKeysRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiConfigureKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiConfigureKeysRequest** | [**PkiConfigureKeysRequest**](PkiConfigureKeysRequest.md)|  | 


### Return type

[**PkiConfigureKeysResponse**](PkiConfigureKeysResponse.md)

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


<a name="pkiconfigureurls"></a>
# **PkiConfigureUrls**

> PkiConfigureUrlsResponse PkiConfigureUrls (string pkiMountPath, PkiConfigureUrlsRequest pkiConfigureUrlsRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiConfigureUrlsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiConfigureUrlsRequest = new PkiConfigureUrlsRequest(); // PkiConfigureUrlsRequest | 
            
            

            try
            {
                

                PkiConfigureUrlsResponse result = apiInstance.PkiConfigureUrls(string pkiMountPath, PkiConfigureUrlsRequest pkiConfigureUrlsRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiConfigureUrls: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiConfigureUrlsRequest** | [**PkiConfigureUrlsRequest**](PkiConfigureUrlsRequest.md)|  | 


### Return type

[**PkiConfigureUrlsResponse**](PkiConfigureUrlsResponse.md)

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


<a name="pkicrosssignintermediate"></a>
# **PkiCrossSignIntermediate**

> PkiCrossSignIntermediateResponse PkiCrossSignIntermediate (string pkiMountPath, PkiCrossSignIntermediateRequest pkiCrossSignIntermediateRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiCrossSignIntermediateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiCrossSignIntermediateRequest = new PkiCrossSignIntermediateRequest(); // PkiCrossSignIntermediateRequest | 
            
            

            try
            {
                

                PkiCrossSignIntermediateResponse result = apiInstance.PkiCrossSignIntermediate(string pkiMountPath, PkiCrossSignIntermediateRequest pkiCrossSignIntermediateRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiCrossSignIntermediate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiCrossSignIntermediateRequest** | [**PkiCrossSignIntermediateRequest**](PkiCrossSignIntermediateRequest.md)|  | 


### Return type

[**PkiCrossSignIntermediateResponse**](PkiCrossSignIntermediateResponse.md)

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


<a name="pkideleteissuer"></a>
# **PkiDeleteIssuer**

> void PkiDeleteIssuer (string issuerRef, string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiDeleteIssuerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var issuerRef = "\"default\"";  // string | Reference to a existing issuer; either \"default\" for the configured default issuer, an identifier or the name assigned to the issuer. (default to "default")
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                apiInstance.PkiDeleteIssuer(string issuerRef, string pkiMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiDeleteIssuer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

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


<a name="pkideletekey"></a>
# **PkiDeleteKey**

> void PkiDeleteKey (string keyRef, string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiDeleteKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var keyRef = "\"default\"";  // string | Reference to key; either \"default\" for the configured default key, an identifier of a key, or the name assigned to the key. (default to "default")
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                apiInstance.PkiDeleteKey(string keyRef, string pkiMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiDeleteKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyRef** | **string**| Reference to key; either \&quot;default\&quot; for the configured default key, an identifier of a key, or the name assigned to the key. | [default to &quot;default&quot;]
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

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


<a name="pkideleterole"></a>
# **PkiDeleteRole**

> void PkiDeleteRole (string name, string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiDeleteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                apiInstance.PkiDeleteRole(string name, string pkiMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiDeleteRole: " + e.Message );
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
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

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


<a name="pkideleteroot"></a>
# **PkiDeleteRoot**

> void PkiDeleteRoot (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiDeleteRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                apiInstance.PkiDeleteRoot(string pkiMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiDeleteRoot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="pkigenerateexportedkey"></a>
# **PkiGenerateExportedKey**

> PkiGenerateExportedKeyResponse PkiGenerateExportedKey (string pkiMountPath, PkiGenerateExportedKeyRequest pkiGenerateExportedKeyRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiGenerateExportedKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiGenerateExportedKeyRequest = new PkiGenerateExportedKeyRequest(); // PkiGenerateExportedKeyRequest | 
            
            

            try
            {
                

                PkiGenerateExportedKeyResponse result = apiInstance.PkiGenerateExportedKey(string pkiMountPath, PkiGenerateExportedKeyRequest pkiGenerateExportedKeyRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiGenerateExportedKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiGenerateExportedKeyRequest** | [**PkiGenerateExportedKeyRequest**](PkiGenerateExportedKeyRequest.md)|  | 


### Return type

[**PkiGenerateExportedKeyResponse**](PkiGenerateExportedKeyResponse.md)

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


<a name="pkigenerateintermediate"></a>
# **PkiGenerateIntermediate**

> PkiGenerateIntermediateResponse PkiGenerateIntermediate (string exported, string pkiMountPath, PkiGenerateIntermediateRequest pkiGenerateIntermediateRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiGenerateIntermediateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var exported = "internal";  // string | Must be \"internal\", \"exported\" or \"kms\". If set to \"exported\", the generated private key will be returned. This is your *only* chance to retrieve the private key!
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiGenerateIntermediateRequest = new PkiGenerateIntermediateRequest(); // PkiGenerateIntermediateRequest | 
            
            

            try
            {
                

                PkiGenerateIntermediateResponse result = apiInstance.PkiGenerateIntermediate(string exported, string pkiMountPath, PkiGenerateIntermediateRequest pkiGenerateIntermediateRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiGenerateIntermediate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exported** | **string**| Must be \&quot;internal\&quot;, \&quot;exported\&quot; or \&quot;kms\&quot;. If set to \&quot;exported\&quot;, the generated private key will be returned. This is your *only* chance to retrieve the private key! | 
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiGenerateIntermediateRequest** | [**PkiGenerateIntermediateRequest**](PkiGenerateIntermediateRequest.md)|  | 


### Return type

[**PkiGenerateIntermediateResponse**](PkiGenerateIntermediateResponse.md)

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


<a name="pkigenerateinternalkey"></a>
# **PkiGenerateInternalKey**

> PkiGenerateInternalKeyResponse PkiGenerateInternalKey (string pkiMountPath, PkiGenerateInternalKeyRequest pkiGenerateInternalKeyRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiGenerateInternalKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiGenerateInternalKeyRequest = new PkiGenerateInternalKeyRequest(); // PkiGenerateInternalKeyRequest | 
            
            

            try
            {
                

                PkiGenerateInternalKeyResponse result = apiInstance.PkiGenerateInternalKey(string pkiMountPath, PkiGenerateInternalKeyRequest pkiGenerateInternalKeyRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiGenerateInternalKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiGenerateInternalKeyRequest** | [**PkiGenerateInternalKeyRequest**](PkiGenerateInternalKeyRequest.md)|  | 


### Return type

[**PkiGenerateInternalKeyResponse**](PkiGenerateInternalKeyResponse.md)

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


<a name="pkigeneratekmskey"></a>
# **PkiGenerateKmsKey**

> PkiGenerateKmsKeyResponse PkiGenerateKmsKey (string pkiMountPath, PkiGenerateKmsKeyRequest pkiGenerateKmsKeyRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiGenerateKmsKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiGenerateKmsKeyRequest = new PkiGenerateKmsKeyRequest(); // PkiGenerateKmsKeyRequest | 
            
            

            try
            {
                

                PkiGenerateKmsKeyResponse result = apiInstance.PkiGenerateKmsKey(string pkiMountPath, PkiGenerateKmsKeyRequest pkiGenerateKmsKeyRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiGenerateKmsKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiGenerateKmsKeyRequest** | [**PkiGenerateKmsKeyRequest**](PkiGenerateKmsKeyRequest.md)|  | 


### Return type

[**PkiGenerateKmsKeyResponse**](PkiGenerateKmsKeyResponse.md)

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


<a name="pkigenerateroot"></a>
# **PkiGenerateRoot**

> PkiGenerateRootResponse PkiGenerateRoot (string exported, string pkiMountPath, PkiGenerateRootRequest pkiGenerateRootRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiGenerateRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var exported = "internal";  // string | Must be \"internal\", \"exported\" or \"kms\". If set to \"exported\", the generated private key will be returned. This is your *only* chance to retrieve the private key!
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiGenerateRootRequest = new PkiGenerateRootRequest(); // PkiGenerateRootRequest | 
            
            

            try
            {
                

                PkiGenerateRootResponse result = apiInstance.PkiGenerateRoot(string exported, string pkiMountPath, PkiGenerateRootRequest pkiGenerateRootRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiGenerateRoot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exported** | **string**| Must be \&quot;internal\&quot;, \&quot;exported\&quot; or \&quot;kms\&quot;. If set to \&quot;exported\&quot;, the generated private key will be returned. This is your *only* chance to retrieve the private key! | 
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiGenerateRootRequest** | [**PkiGenerateRootRequest**](PkiGenerateRootRequest.md)|  | 


### Return type

[**PkiGenerateRootResponse**](PkiGenerateRootResponse.md)

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


<a name="pkiimportkey"></a>
# **PkiImportKey**

> PkiImportKeyResponse PkiImportKey (string pkiMountPath, PkiImportKeyRequest pkiImportKeyRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiImportKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiImportKeyRequest = new PkiImportKeyRequest(); // PkiImportKeyRequest | 
            
            

            try
            {
                

                PkiImportKeyResponse result = apiInstance.PkiImportKey(string pkiMountPath, PkiImportKeyRequest pkiImportKeyRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiImportKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiImportKeyRequest** | [**PkiImportKeyRequest**](PkiImportKeyRequest.md)|  | 


### Return type

[**PkiImportKeyResponse**](PkiImportKeyResponse.md)

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


<a name="pkiissuewithrole"></a>
# **PkiIssueWithRole**

> PkiIssueWithRoleResponse PkiIssueWithRole (string role, string pkiMountPath, PkiIssueWithRoleRequest pkiIssueWithRoleRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiIssueWithRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var role = "role_example";  // string | The desired role with configuration for this request
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiIssueWithRoleRequest = new PkiIssueWithRoleRequest(); // PkiIssueWithRoleRequest | 
            
            

            try
            {
                

                PkiIssueWithRoleResponse result = apiInstance.PkiIssueWithRole(string role, string pkiMountPath, PkiIssueWithRoleRequest pkiIssueWithRoleRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiIssueWithRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The desired role with configuration for this request | 
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiIssueWithRoleRequest** | [**PkiIssueWithRoleRequest**](PkiIssueWithRoleRequest.md)|  | 


### Return type

[**PkiIssueWithRoleResponse**](PkiIssueWithRoleResponse.md)

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


<a name="pkiissuerissuewithrole"></a>
# **PkiIssuerIssueWithRole**

> PkiIssuerIssueWithRoleResponse PkiIssuerIssueWithRole (string issuerRef, string role, string pkiMountPath, PkiIssuerIssueWithRoleRequest pkiIssuerIssueWithRoleRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiIssuerIssueWithRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var issuerRef = "\"default\"";  // string | Reference to a existing issuer; either \"default\" for the configured default issuer, an identifier or the name assigned to the issuer. (default to "default")
            
            
            
            
            var role = "role_example";  // string | The desired role with configuration for this request
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiIssuerIssueWithRoleRequest = new PkiIssuerIssueWithRoleRequest(); // PkiIssuerIssueWithRoleRequest | 
            
            

            try
            {
                

                PkiIssuerIssueWithRoleResponse result = apiInstance.PkiIssuerIssueWithRole(string issuerRef, string role, string pkiMountPath, PkiIssuerIssueWithRoleRequest pkiIssuerIssueWithRoleRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiIssuerIssueWithRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]
 **role** | **string**| The desired role with configuration for this request | 
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiIssuerIssueWithRoleRequest** | [**PkiIssuerIssueWithRoleRequest**](PkiIssuerIssueWithRoleRequest.md)|  | 


### Return type

[**PkiIssuerIssueWithRoleResponse**](PkiIssuerIssueWithRoleResponse.md)

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


<a name="pkiissuerreadcrl"></a>
# **PkiIssuerReadCrl**

> PkiIssuerReadCrlResponse PkiIssuerReadCrl (string issuerRef, string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiIssuerReadCrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var issuerRef = "\"default\"";  // string | Reference to a existing issuer; either \"default\" for the configured default issuer, an identifier or the name assigned to the issuer. (default to "default")
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiIssuerReadCrlResponse result = apiInstance.PkiIssuerReadCrl(string issuerRef, string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiIssuerReadCrl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiIssuerReadCrlResponse**](PkiIssuerReadCrlResponse.md)

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


<a name="pkiissuerreadcrldelta"></a>
# **PkiIssuerReadCrlDelta**

> PkiIssuerReadCrlDeltaResponse PkiIssuerReadCrlDelta (string issuerRef, string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiIssuerReadCrlDeltaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var issuerRef = "\"default\"";  // string | Reference to a existing issuer; either \"default\" for the configured default issuer, an identifier or the name assigned to the issuer. (default to "default")
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiIssuerReadCrlDeltaResponse result = apiInstance.PkiIssuerReadCrlDelta(string issuerRef, string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiIssuerReadCrlDelta: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiIssuerReadCrlDeltaResponse**](PkiIssuerReadCrlDeltaResponse.md)

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


<a name="pkiissuerreadcrldeltader"></a>
# **PkiIssuerReadCrlDeltaDer**

> PkiIssuerReadCrlDeltaDerResponse PkiIssuerReadCrlDeltaDer (string issuerRef, string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiIssuerReadCrlDeltaDerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var issuerRef = "\"default\"";  // string | Reference to a existing issuer; either \"default\" for the configured default issuer, an identifier or the name assigned to the issuer. (default to "default")
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiIssuerReadCrlDeltaDerResponse result = apiInstance.PkiIssuerReadCrlDeltaDer(string issuerRef, string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiIssuerReadCrlDeltaDer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiIssuerReadCrlDeltaDerResponse**](PkiIssuerReadCrlDeltaDerResponse.md)

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


<a name="pkiissuerreadcrldeltapem"></a>
# **PkiIssuerReadCrlDeltaPem**

> PkiIssuerReadCrlDeltaPemResponse PkiIssuerReadCrlDeltaPem (string issuerRef, string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiIssuerReadCrlDeltaPemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var issuerRef = "\"default\"";  // string | Reference to a existing issuer; either \"default\" for the configured default issuer, an identifier or the name assigned to the issuer. (default to "default")
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiIssuerReadCrlDeltaPemResponse result = apiInstance.PkiIssuerReadCrlDeltaPem(string issuerRef, string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiIssuerReadCrlDeltaPem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiIssuerReadCrlDeltaPemResponse**](PkiIssuerReadCrlDeltaPemResponse.md)

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


<a name="pkiissuerreadcrlder"></a>
# **PkiIssuerReadCrlDer**

> PkiIssuerReadCrlDerResponse PkiIssuerReadCrlDer (string issuerRef, string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiIssuerReadCrlDerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var issuerRef = "\"default\"";  // string | Reference to a existing issuer; either \"default\" for the configured default issuer, an identifier or the name assigned to the issuer. (default to "default")
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiIssuerReadCrlDerResponse result = apiInstance.PkiIssuerReadCrlDer(string issuerRef, string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiIssuerReadCrlDer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiIssuerReadCrlDerResponse**](PkiIssuerReadCrlDerResponse.md)

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


<a name="pkiissuerreadcrlpem"></a>
# **PkiIssuerReadCrlPem**

> PkiIssuerReadCrlPemResponse PkiIssuerReadCrlPem (string issuerRef, string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiIssuerReadCrlPemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var issuerRef = "\"default\"";  // string | Reference to a existing issuer; either \"default\" for the configured default issuer, an identifier or the name assigned to the issuer. (default to "default")
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiIssuerReadCrlPemResponse result = apiInstance.PkiIssuerReadCrlPem(string issuerRef, string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiIssuerReadCrlPem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiIssuerReadCrlPemResponse**](PkiIssuerReadCrlPemResponse.md)

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


<a name="pkiissuerresigncrls"></a>
# **PkiIssuerResignCrls**

> PkiIssuerResignCrlsResponse PkiIssuerResignCrls (string issuerRef, string pkiMountPath, PkiIssuerResignCrlsRequest pkiIssuerResignCrlsRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiIssuerResignCrlsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var issuerRef = "\"default\"";  // string | Reference to a existing issuer; either \"default\" for the configured default issuer, an identifier or the name assigned to the issuer. (default to "default")
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiIssuerResignCrlsRequest = new PkiIssuerResignCrlsRequest(); // PkiIssuerResignCrlsRequest | 
            
            

            try
            {
                

                PkiIssuerResignCrlsResponse result = apiInstance.PkiIssuerResignCrls(string issuerRef, string pkiMountPath, PkiIssuerResignCrlsRequest pkiIssuerResignCrlsRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiIssuerResignCrls: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiIssuerResignCrlsRequest** | [**PkiIssuerResignCrlsRequest**](PkiIssuerResignCrlsRequest.md)|  | 


### Return type

[**PkiIssuerResignCrlsResponse**](PkiIssuerResignCrlsResponse.md)

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


<a name="pkiissuersignintermediate"></a>
# **PkiIssuerSignIntermediate**

> PkiIssuerSignIntermediateResponse PkiIssuerSignIntermediate (string issuerRef, string pkiMountPath, PkiIssuerSignIntermediateRequest pkiIssuerSignIntermediateRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiIssuerSignIntermediateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var issuerRef = "\"default\"";  // string | Reference to a existing issuer; either \"default\" for the configured default issuer, an identifier or the name assigned to the issuer. (default to "default")
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiIssuerSignIntermediateRequest = new PkiIssuerSignIntermediateRequest(); // PkiIssuerSignIntermediateRequest | 
            
            

            try
            {
                

                PkiIssuerSignIntermediateResponse result = apiInstance.PkiIssuerSignIntermediate(string issuerRef, string pkiMountPath, PkiIssuerSignIntermediateRequest pkiIssuerSignIntermediateRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiIssuerSignIntermediate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiIssuerSignIntermediateRequest** | [**PkiIssuerSignIntermediateRequest**](PkiIssuerSignIntermediateRequest.md)|  | 


### Return type

[**PkiIssuerSignIntermediateResponse**](PkiIssuerSignIntermediateResponse.md)

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


<a name="pkiissuersignrevocationlist"></a>
# **PkiIssuerSignRevocationList**

> PkiIssuerSignRevocationListResponse PkiIssuerSignRevocationList (string issuerRef, string pkiMountPath, PkiIssuerSignRevocationListRequest pkiIssuerSignRevocationListRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiIssuerSignRevocationListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var issuerRef = "\"default\"";  // string | Reference to a existing issuer; either \"default\" for the configured default issuer, an identifier or the name assigned to the issuer. (default to "default")
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiIssuerSignRevocationListRequest = new PkiIssuerSignRevocationListRequest(); // PkiIssuerSignRevocationListRequest | 
            
            

            try
            {
                

                PkiIssuerSignRevocationListResponse result = apiInstance.PkiIssuerSignRevocationList(string issuerRef, string pkiMountPath, PkiIssuerSignRevocationListRequest pkiIssuerSignRevocationListRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiIssuerSignRevocationList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiIssuerSignRevocationListRequest** | [**PkiIssuerSignRevocationListRequest**](PkiIssuerSignRevocationListRequest.md)|  | 


### Return type

[**PkiIssuerSignRevocationListResponse**](PkiIssuerSignRevocationListResponse.md)

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


<a name="pkiissuersignselfissued"></a>
# **PkiIssuerSignSelfIssued**

> PkiIssuerSignSelfIssuedResponse PkiIssuerSignSelfIssued (string issuerRef, string pkiMountPath, PkiIssuerSignSelfIssuedRequest pkiIssuerSignSelfIssuedRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiIssuerSignSelfIssuedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var issuerRef = "\"default\"";  // string | Reference to a existing issuer; either \"default\" for the configured default issuer, an identifier or the name assigned to the issuer. (default to "default")
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiIssuerSignSelfIssuedRequest = new PkiIssuerSignSelfIssuedRequest(); // PkiIssuerSignSelfIssuedRequest | 
            
            

            try
            {
                

                PkiIssuerSignSelfIssuedResponse result = apiInstance.PkiIssuerSignSelfIssued(string issuerRef, string pkiMountPath, PkiIssuerSignSelfIssuedRequest pkiIssuerSignSelfIssuedRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiIssuerSignSelfIssued: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiIssuerSignSelfIssuedRequest** | [**PkiIssuerSignSelfIssuedRequest**](PkiIssuerSignSelfIssuedRequest.md)|  | 


### Return type

[**PkiIssuerSignSelfIssuedResponse**](PkiIssuerSignSelfIssuedResponse.md)

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


<a name="pkiissuersignverbatim"></a>
# **PkiIssuerSignVerbatim**

> PkiIssuerSignVerbatimResponse PkiIssuerSignVerbatim (string issuerRef, string pkiMountPath, PkiIssuerSignVerbatimRequest pkiIssuerSignVerbatimRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiIssuerSignVerbatimExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var issuerRef = "\"default\"";  // string | Reference to a existing issuer; either \"default\" for the configured default issuer, an identifier or the name assigned to the issuer. (default to "default")
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiIssuerSignVerbatimRequest = new PkiIssuerSignVerbatimRequest(); // PkiIssuerSignVerbatimRequest | 
            
            

            try
            {
                

                PkiIssuerSignVerbatimResponse result = apiInstance.PkiIssuerSignVerbatim(string issuerRef, string pkiMountPath, PkiIssuerSignVerbatimRequest pkiIssuerSignVerbatimRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiIssuerSignVerbatim: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiIssuerSignVerbatimRequest** | [**PkiIssuerSignVerbatimRequest**](PkiIssuerSignVerbatimRequest.md)|  | 


### Return type

[**PkiIssuerSignVerbatimResponse**](PkiIssuerSignVerbatimResponse.md)

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


<a name="pkiissuersignverbatimwithrole"></a>
# **PkiIssuerSignVerbatimWithRole**

> PkiIssuerSignVerbatimWithRoleResponse PkiIssuerSignVerbatimWithRole (string issuerRef, string role, string pkiMountPath, PkiIssuerSignVerbatimWithRoleRequest pkiIssuerSignVerbatimWithRoleRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiIssuerSignVerbatimWithRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var issuerRef = "\"default\"";  // string | Reference to a existing issuer; either \"default\" for the configured default issuer, an identifier or the name assigned to the issuer. (default to "default")
            
            
            
            
            var role = "role_example";  // string | The desired role with configuration for this request
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiIssuerSignVerbatimWithRoleRequest = new PkiIssuerSignVerbatimWithRoleRequest(); // PkiIssuerSignVerbatimWithRoleRequest | 
            
            

            try
            {
                

                PkiIssuerSignVerbatimWithRoleResponse result = apiInstance.PkiIssuerSignVerbatimWithRole(string issuerRef, string role, string pkiMountPath, PkiIssuerSignVerbatimWithRoleRequest pkiIssuerSignVerbatimWithRoleRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiIssuerSignVerbatimWithRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]
 **role** | **string**| The desired role with configuration for this request | 
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiIssuerSignVerbatimWithRoleRequest** | [**PkiIssuerSignVerbatimWithRoleRequest**](PkiIssuerSignVerbatimWithRoleRequest.md)|  | 


### Return type

[**PkiIssuerSignVerbatimWithRoleResponse**](PkiIssuerSignVerbatimWithRoleResponse.md)

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


<a name="pkiissuersignwithrole"></a>
# **PkiIssuerSignWithRole**

> PkiIssuerSignWithRoleResponse PkiIssuerSignWithRole (string issuerRef, string role, string pkiMountPath, PkiIssuerSignWithRoleRequest pkiIssuerSignWithRoleRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiIssuerSignWithRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var issuerRef = "\"default\"";  // string | Reference to a existing issuer; either \"default\" for the configured default issuer, an identifier or the name assigned to the issuer. (default to "default")
            
            
            
            
            var role = "role_example";  // string | The desired role with configuration for this request
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiIssuerSignWithRoleRequest = new PkiIssuerSignWithRoleRequest(); // PkiIssuerSignWithRoleRequest | 
            
            

            try
            {
                

                PkiIssuerSignWithRoleResponse result = apiInstance.PkiIssuerSignWithRole(string issuerRef, string role, string pkiMountPath, PkiIssuerSignWithRoleRequest pkiIssuerSignWithRoleRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiIssuerSignWithRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]
 **role** | **string**| The desired role with configuration for this request | 
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiIssuerSignWithRoleRequest** | [**PkiIssuerSignWithRoleRequest**](PkiIssuerSignWithRoleRequest.md)|  | 


### Return type

[**PkiIssuerSignWithRoleResponse**](PkiIssuerSignWithRoleResponse.md)

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


<a name="pkiissuersgenerateintermediate"></a>
# **PkiIssuersGenerateIntermediate**

> PkiIssuersGenerateIntermediateResponse PkiIssuersGenerateIntermediate (string exported, string pkiMountPath, PkiIssuersGenerateIntermediateRequest pkiIssuersGenerateIntermediateRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiIssuersGenerateIntermediateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var exported = "internal";  // string | Must be \"internal\", \"exported\" or \"kms\". If set to \"exported\", the generated private key will be returned. This is your *only* chance to retrieve the private key!
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiIssuersGenerateIntermediateRequest = new PkiIssuersGenerateIntermediateRequest(); // PkiIssuersGenerateIntermediateRequest | 
            
            

            try
            {
                

                PkiIssuersGenerateIntermediateResponse result = apiInstance.PkiIssuersGenerateIntermediate(string exported, string pkiMountPath, PkiIssuersGenerateIntermediateRequest pkiIssuersGenerateIntermediateRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiIssuersGenerateIntermediate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exported** | **string**| Must be \&quot;internal\&quot;, \&quot;exported\&quot; or \&quot;kms\&quot;. If set to \&quot;exported\&quot;, the generated private key will be returned. This is your *only* chance to retrieve the private key! | 
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiIssuersGenerateIntermediateRequest** | [**PkiIssuersGenerateIntermediateRequest**](PkiIssuersGenerateIntermediateRequest.md)|  | 


### Return type

[**PkiIssuersGenerateIntermediateResponse**](PkiIssuersGenerateIntermediateResponse.md)

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


<a name="pkiissuersgenerateroot"></a>
# **PkiIssuersGenerateRoot**

> PkiIssuersGenerateRootResponse PkiIssuersGenerateRoot (string exported, string pkiMountPath, PkiIssuersGenerateRootRequest pkiIssuersGenerateRootRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiIssuersGenerateRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var exported = "internal";  // string | Must be \"internal\", \"exported\" or \"kms\". If set to \"exported\", the generated private key will be returned. This is your *only* chance to retrieve the private key!
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiIssuersGenerateRootRequest = new PkiIssuersGenerateRootRequest(); // PkiIssuersGenerateRootRequest | 
            
            

            try
            {
                

                PkiIssuersGenerateRootResponse result = apiInstance.PkiIssuersGenerateRoot(string exported, string pkiMountPath, PkiIssuersGenerateRootRequest pkiIssuersGenerateRootRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiIssuersGenerateRoot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exported** | **string**| Must be \&quot;internal\&quot;, \&quot;exported\&quot; or \&quot;kms\&quot;. If set to \&quot;exported\&quot;, the generated private key will be returned. This is your *only* chance to retrieve the private key! | 
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiIssuersGenerateRootRequest** | [**PkiIssuersGenerateRootRequest**](PkiIssuersGenerateRootRequest.md)|  | 


### Return type

[**PkiIssuersGenerateRootResponse**](PkiIssuersGenerateRootResponse.md)

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


<a name="pkiissuersimportbundle"></a>
# **PkiIssuersImportBundle**

> PkiIssuersImportBundleResponse PkiIssuersImportBundle (string pkiMountPath, PkiIssuersImportBundleRequest pkiIssuersImportBundleRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiIssuersImportBundleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiIssuersImportBundleRequest = new PkiIssuersImportBundleRequest(); // PkiIssuersImportBundleRequest | 
            
            

            try
            {
                

                PkiIssuersImportBundleResponse result = apiInstance.PkiIssuersImportBundle(string pkiMountPath, PkiIssuersImportBundleRequest pkiIssuersImportBundleRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiIssuersImportBundle: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiIssuersImportBundleRequest** | [**PkiIssuersImportBundleRequest**](PkiIssuersImportBundleRequest.md)|  | 


### Return type

[**PkiIssuersImportBundleResponse**](PkiIssuersImportBundleResponse.md)

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


<a name="pkiissuersimportcert"></a>
# **PkiIssuersImportCert**

> PkiIssuersImportCertResponse PkiIssuersImportCert (string pkiMountPath, PkiIssuersImportCertRequest pkiIssuersImportCertRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiIssuersImportCertExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiIssuersImportCertRequest = new PkiIssuersImportCertRequest(); // PkiIssuersImportCertRequest | 
            
            

            try
            {
                

                PkiIssuersImportCertResponse result = apiInstance.PkiIssuersImportCert(string pkiMountPath, PkiIssuersImportCertRequest pkiIssuersImportCertRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiIssuersImportCert: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiIssuersImportCertRequest** | [**PkiIssuersImportCertRequest**](PkiIssuersImportCertRequest.md)|  | 


### Return type

[**PkiIssuersImportCertResponse**](PkiIssuersImportCertResponse.md)

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


<a name="pkiissuersrotateroot"></a>
# **PkiIssuersRotateRoot**

> PkiIssuersRotateRootResponse PkiIssuersRotateRoot (string exported, string pkiMountPath, PkiIssuersRotateRootRequest pkiIssuersRotateRootRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiIssuersRotateRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var exported = "internal";  // string | Must be \"internal\", \"exported\" or \"kms\". If set to \"exported\", the generated private key will be returned. This is your *only* chance to retrieve the private key!
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiIssuersRotateRootRequest = new PkiIssuersRotateRootRequest(); // PkiIssuersRotateRootRequest | 
            
            

            try
            {
                

                PkiIssuersRotateRootResponse result = apiInstance.PkiIssuersRotateRoot(string exported, string pkiMountPath, PkiIssuersRotateRootRequest pkiIssuersRotateRootRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiIssuersRotateRoot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exported** | **string**| Must be \&quot;internal\&quot;, \&quot;exported\&quot; or \&quot;kms\&quot;. If set to \&quot;exported\&quot;, the generated private key will be returned. This is your *only* chance to retrieve the private key! | 
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiIssuersRotateRootRequest** | [**PkiIssuersRotateRootRequest**](PkiIssuersRotateRootRequest.md)|  | 


### Return type

[**PkiIssuersRotateRootResponse**](PkiIssuersRotateRootResponse.md)

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


<a name="pkilistcerts"></a>
# **PkiListCerts**

> PkiListCertsResponse PkiListCerts (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiListCertsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                PkiListCertsResponse result = apiInstance.PkiListCerts(string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiListCerts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **list** | **string**| Must be set to &#x60;true&#x60; | 


### Return type

[**PkiListCertsResponse**](PkiListCertsResponse.md)

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


<a name="pkilistissuers"></a>
# **PkiListIssuers**

> PkiListIssuersResponse PkiListIssuers (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiListIssuersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                PkiListIssuersResponse result = apiInstance.PkiListIssuers(string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiListIssuers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **list** | **string**| Must be set to &#x60;true&#x60; | 


### Return type

[**PkiListIssuersResponse**](PkiListIssuersResponse.md)

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


<a name="pkilistkeys"></a>
# **PkiListKeys**

> PkiListKeysResponse PkiListKeys (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiListKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                PkiListKeysResponse result = apiInstance.PkiListKeys(string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiListKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **list** | **string**| Must be set to &#x60;true&#x60; | 


### Return type

[**PkiListKeysResponse**](PkiListKeysResponse.md)

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


<a name="pkilistrevokedcerts"></a>
# **PkiListRevokedCerts**

> PkiListRevokedCertsResponse PkiListRevokedCerts (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiListRevokedCertsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                PkiListRevokedCertsResponse result = apiInstance.PkiListRevokedCerts(string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiListRevokedCerts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **list** | **string**| Must be set to &#x60;true&#x60; | 


### Return type

[**PkiListRevokedCertsResponse**](PkiListRevokedCertsResponse.md)

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


<a name="pkilistroles"></a>
# **PkiListRoles**

> PkiListRolesResponse PkiListRoles (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                PkiListRolesResponse result = apiInstance.PkiListRoles(string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiListRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **list** | **string**| Must be set to &#x60;true&#x60; | 


### Return type

[**PkiListRolesResponse**](PkiListRolesResponse.md)

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


<a name="pkiqueryocsp"></a>
# **PkiQueryOcsp**

> void PkiQueryOcsp (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiQueryOcspExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                apiInstance.PkiQueryOcsp(string pkiMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiQueryOcsp: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="pkiqueryocspwithgetreq"></a>
# **PkiQueryOcspWithGetReq**

> void PkiQueryOcspWithGetReq (string req, string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiQueryOcspWithGetReqExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var req = "req_example";  // string | base-64 encoded ocsp request
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                apiInstance.PkiQueryOcspWithGetReq(string req, string pkiMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiQueryOcspWithGetReq: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **req** | **string**| base-64 encoded ocsp request | 
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="pkireadautotidyconfiguration"></a>
# **PkiReadAutoTidyConfiguration**

> PkiReadAutoTidyConfigurationResponse PkiReadAutoTidyConfiguration (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadAutoTidyConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiReadAutoTidyConfigurationResponse result = apiInstance.PkiReadAutoTidyConfiguration(string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadAutoTidyConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiReadAutoTidyConfigurationResponse**](PkiReadAutoTidyConfigurationResponse.md)

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


<a name="pkireadcachainpem"></a>
# **PkiReadCaChainPem**

> PkiReadCaChainPemResponse PkiReadCaChainPem (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadCaChainPemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiReadCaChainPemResponse result = apiInstance.PkiReadCaChainPem(string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadCaChainPem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiReadCaChainPemResponse**](PkiReadCaChainPemResponse.md)

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


<a name="pkireadcader"></a>
# **PkiReadCaDer**

> PkiReadCaDerResponse PkiReadCaDer (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadCaDerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiReadCaDerResponse result = apiInstance.PkiReadCaDer(string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadCaDer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiReadCaDerResponse**](PkiReadCaDerResponse.md)

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


<a name="pkireadcapem"></a>
# **PkiReadCaPem**

> PkiReadCaPemResponse PkiReadCaPem (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadCaPemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiReadCaPemResponse result = apiInstance.PkiReadCaPem(string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadCaPem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiReadCaPemResponse**](PkiReadCaPemResponse.md)

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


<a name="pkireadcert"></a>
# **PkiReadCert**

> PkiReadCertResponse PkiReadCert (string serial, string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadCertExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var serial = "serial_example";  // string | Certificate serial number, in colon- or hyphen-separated octal
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiReadCertResponse result = apiInstance.PkiReadCert(string serial, string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadCert: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serial** | **string**| Certificate serial number, in colon- or hyphen-separated octal | 
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiReadCertResponse**](PkiReadCertResponse.md)

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


<a name="pkireadcertcachain"></a>
# **PkiReadCertCaChain**

> PkiReadCertCaChainResponse PkiReadCertCaChain (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadCertCaChainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiReadCertCaChainResponse result = apiInstance.PkiReadCertCaChain(string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadCertCaChain: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiReadCertCaChainResponse**](PkiReadCertCaChainResponse.md)

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


<a name="pkireadcertcrl"></a>
# **PkiReadCertCrl**

> PkiReadCertCrlResponse PkiReadCertCrl (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadCertCrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiReadCertCrlResponse result = apiInstance.PkiReadCertCrl(string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadCertCrl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiReadCertCrlResponse**](PkiReadCertCrlResponse.md)

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


<a name="pkireadcertdeltacrl"></a>
# **PkiReadCertDeltaCrl**

> PkiReadCertDeltaCrlResponse PkiReadCertDeltaCrl (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadCertDeltaCrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiReadCertDeltaCrlResponse result = apiInstance.PkiReadCertDeltaCrl(string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadCertDeltaCrl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiReadCertDeltaCrlResponse**](PkiReadCertDeltaCrlResponse.md)

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


<a name="pkireadcertrawder"></a>
# **PkiReadCertRawDer**

> PkiReadCertRawDerResponse PkiReadCertRawDer (string serial, string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadCertRawDerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var serial = "serial_example";  // string | Certificate serial number, in colon- or hyphen-separated octal
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiReadCertRawDerResponse result = apiInstance.PkiReadCertRawDer(string serial, string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadCertRawDer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serial** | **string**| Certificate serial number, in colon- or hyphen-separated octal | 
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiReadCertRawDerResponse**](PkiReadCertRawDerResponse.md)

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


<a name="pkireadcertrawpem"></a>
# **PkiReadCertRawPem**

> PkiReadCertRawPemResponse PkiReadCertRawPem (string serial, string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadCertRawPemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var serial = "serial_example";  // string | Certificate serial number, in colon- or hyphen-separated octal
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiReadCertRawPemResponse result = apiInstance.PkiReadCertRawPem(string serial, string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadCertRawPem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serial** | **string**| Certificate serial number, in colon- or hyphen-separated octal | 
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiReadCertRawPemResponse**](PkiReadCertRawPemResponse.md)

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


<a name="pkireadclusterconfiguration"></a>
# **PkiReadClusterConfiguration**

> PkiReadClusterConfigurationResponse PkiReadClusterConfiguration (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadClusterConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiReadClusterConfigurationResponse result = apiInstance.PkiReadClusterConfiguration(string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadClusterConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiReadClusterConfigurationResponse**](PkiReadClusterConfigurationResponse.md)

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


<a name="pkireadcrlconfiguration"></a>
# **PkiReadCrlConfiguration**

> PkiReadCrlConfigurationResponse PkiReadCrlConfiguration (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadCrlConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiReadCrlConfigurationResponse result = apiInstance.PkiReadCrlConfiguration(string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadCrlConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiReadCrlConfigurationResponse**](PkiReadCrlConfigurationResponse.md)

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


<a name="pkireadcrldelta"></a>
# **PkiReadCrlDelta**

> PkiReadCrlDeltaResponse PkiReadCrlDelta (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadCrlDeltaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiReadCrlDeltaResponse result = apiInstance.PkiReadCrlDelta(string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadCrlDelta: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiReadCrlDeltaResponse**](PkiReadCrlDeltaResponse.md)

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


<a name="pkireadcrldeltapem"></a>
# **PkiReadCrlDeltaPem**

> PkiReadCrlDeltaPemResponse PkiReadCrlDeltaPem (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadCrlDeltaPemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiReadCrlDeltaPemResponse result = apiInstance.PkiReadCrlDeltaPem(string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadCrlDeltaPem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiReadCrlDeltaPemResponse**](PkiReadCrlDeltaPemResponse.md)

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


<a name="pkireadcrlder"></a>
# **PkiReadCrlDer**

> PkiReadCrlDerResponse PkiReadCrlDer (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadCrlDerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiReadCrlDerResponse result = apiInstance.PkiReadCrlDer(string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadCrlDer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiReadCrlDerResponse**](PkiReadCrlDerResponse.md)

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


<a name="pkireadcrlpem"></a>
# **PkiReadCrlPem**

> PkiReadCrlPemResponse PkiReadCrlPem (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadCrlPemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiReadCrlPemResponse result = apiInstance.PkiReadCrlPem(string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadCrlPem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiReadCrlPemResponse**](PkiReadCrlPemResponse.md)

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


<a name="pkireadissuer"></a>
# **PkiReadIssuer**

> PkiReadIssuerResponse PkiReadIssuer (string issuerRef, string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadIssuerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var issuerRef = "\"default\"";  // string | Reference to a existing issuer; either \"default\" for the configured default issuer, an identifier or the name assigned to the issuer. (default to "default")
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiReadIssuerResponse result = apiInstance.PkiReadIssuer(string issuerRef, string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadIssuer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiReadIssuerResponse**](PkiReadIssuerResponse.md)

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


<a name="pkireadissuerder"></a>
# **PkiReadIssuerDer**

> PkiReadIssuerDerResponse PkiReadIssuerDer (string issuerRef, string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadIssuerDerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var issuerRef = "\"default\"";  // string | Reference to a existing issuer; either \"default\" for the configured default issuer, an identifier or the name assigned to the issuer. (default to "default")
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiReadIssuerDerResponse result = apiInstance.PkiReadIssuerDer(string issuerRef, string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadIssuerDer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiReadIssuerDerResponse**](PkiReadIssuerDerResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |

| **304** | Not Modified |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="pkireadissuerjson"></a>
# **PkiReadIssuerJson**

> PkiReadIssuerJsonResponse PkiReadIssuerJson (string issuerRef, string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadIssuerJsonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var issuerRef = "\"default\"";  // string | Reference to a existing issuer; either \"default\" for the configured default issuer, an identifier or the name assigned to the issuer. (default to "default")
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiReadIssuerJsonResponse result = apiInstance.PkiReadIssuerJson(string issuerRef, string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadIssuerJson: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiReadIssuerJsonResponse**](PkiReadIssuerJsonResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |

| **304** | Not Modified |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="pkireadissuerpem"></a>
# **PkiReadIssuerPem**

> PkiReadIssuerPemResponse PkiReadIssuerPem (string issuerRef, string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadIssuerPemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var issuerRef = "\"default\"";  // string | Reference to a existing issuer; either \"default\" for the configured default issuer, an identifier or the name assigned to the issuer. (default to "default")
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiReadIssuerPemResponse result = apiInstance.PkiReadIssuerPem(string issuerRef, string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadIssuerPem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiReadIssuerPemResponse**](PkiReadIssuerPemResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |

| **304** | Not Modified |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="pkireadissuersconfiguration"></a>
# **PkiReadIssuersConfiguration**

> PkiReadIssuersConfigurationResponse PkiReadIssuersConfiguration (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadIssuersConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiReadIssuersConfigurationResponse result = apiInstance.PkiReadIssuersConfiguration(string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadIssuersConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiReadIssuersConfigurationResponse**](PkiReadIssuersConfigurationResponse.md)

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


<a name="pkireadkey"></a>
# **PkiReadKey**

> PkiReadKeyResponse PkiReadKey (string keyRef, string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var keyRef = "\"default\"";  // string | Reference to key; either \"default\" for the configured default key, an identifier of a key, or the name assigned to the key. (default to "default")
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiReadKeyResponse result = apiInstance.PkiReadKey(string keyRef, string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyRef** | **string**| Reference to key; either \&quot;default\&quot; for the configured default key, an identifier of a key, or the name assigned to the key. | [default to &quot;default&quot;]
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiReadKeyResponse**](PkiReadKeyResponse.md)

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


<a name="pkireadkeysconfiguration"></a>
# **PkiReadKeysConfiguration**

> PkiReadKeysConfigurationResponse PkiReadKeysConfiguration (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadKeysConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiReadKeysConfigurationResponse result = apiInstance.PkiReadKeysConfiguration(string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadKeysConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiReadKeysConfigurationResponse**](PkiReadKeysConfigurationResponse.md)

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


<a name="pkireadrole"></a>
# **PkiReadRole**

> PkiReadRoleResponse PkiReadRole (string name, string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiReadRoleResponse result = apiInstance.PkiReadRole(string name, string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadRole: " + e.Message );
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
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiReadRoleResponse**](PkiReadRoleResponse.md)

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


<a name="pkireadurlsconfiguration"></a>
# **PkiReadUrlsConfiguration**

> PkiReadUrlsConfigurationResponse PkiReadUrlsConfiguration (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadUrlsConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiReadUrlsConfigurationResponse result = apiInstance.PkiReadUrlsConfiguration(string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadUrlsConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiReadUrlsConfigurationResponse**](PkiReadUrlsConfigurationResponse.md)

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


<a name="pkireplaceroot"></a>
# **PkiReplaceRoot**

> PkiReplaceRootResponse PkiReplaceRoot (string pkiMountPath, PkiReplaceRootRequest pkiReplaceRootRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReplaceRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiReplaceRootRequest = new PkiReplaceRootRequest(); // PkiReplaceRootRequest | 
            
            

            try
            {
                

                PkiReplaceRootResponse result = apiInstance.PkiReplaceRoot(string pkiMountPath, PkiReplaceRootRequest pkiReplaceRootRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReplaceRoot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiReplaceRootRequest** | [**PkiReplaceRootRequest**](PkiReplaceRootRequest.md)|  | 


### Return type

[**PkiReplaceRootResponse**](PkiReplaceRootResponse.md)

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


<a name="pkirevoke"></a>
# **PkiRevoke**

> PkiRevokeResponse PkiRevoke (string pkiMountPath, PkiRevokeRequest pkiRevokeRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiRevokeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiRevokeRequest = new PkiRevokeRequest(); // PkiRevokeRequest | 
            
            

            try
            {
                

                PkiRevokeResponse result = apiInstance.PkiRevoke(string pkiMountPath, PkiRevokeRequest pkiRevokeRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiRevoke: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiRevokeRequest** | [**PkiRevokeRequest**](PkiRevokeRequest.md)|  | 


### Return type

[**PkiRevokeResponse**](PkiRevokeResponse.md)

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


<a name="pkirevokeissuer"></a>
# **PkiRevokeIssuer**

> PkiRevokeIssuerResponse PkiRevokeIssuer (string issuerRef, string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiRevokeIssuerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var issuerRef = "\"default\"";  // string | Reference to a existing issuer; either \"default\" for the configured default issuer, an identifier or the name assigned to the issuer. (default to "default")
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiRevokeIssuerResponse result = apiInstance.PkiRevokeIssuer(string issuerRef, string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiRevokeIssuer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiRevokeIssuerResponse**](PkiRevokeIssuerResponse.md)

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


<a name="pkirevokewithkey"></a>
# **PkiRevokeWithKey**

> PkiRevokeWithKeyResponse PkiRevokeWithKey (string pkiMountPath, PkiRevokeWithKeyRequest pkiRevokeWithKeyRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiRevokeWithKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiRevokeWithKeyRequest = new PkiRevokeWithKeyRequest(); // PkiRevokeWithKeyRequest | 
            
            

            try
            {
                

                PkiRevokeWithKeyResponse result = apiInstance.PkiRevokeWithKey(string pkiMountPath, PkiRevokeWithKeyRequest pkiRevokeWithKeyRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiRevokeWithKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiRevokeWithKeyRequest** | [**PkiRevokeWithKeyRequest**](PkiRevokeWithKeyRequest.md)|  | 


### Return type

[**PkiRevokeWithKeyResponse**](PkiRevokeWithKeyResponse.md)

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


<a name="pkirootsignintermediate"></a>
# **PkiRootSignIntermediate**

> PkiRootSignIntermediateResponse PkiRootSignIntermediate (string pkiMountPath, PkiRootSignIntermediateRequest pkiRootSignIntermediateRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiRootSignIntermediateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiRootSignIntermediateRequest = new PkiRootSignIntermediateRequest(); // PkiRootSignIntermediateRequest | 
            
            

            try
            {
                

                PkiRootSignIntermediateResponse result = apiInstance.PkiRootSignIntermediate(string pkiMountPath, PkiRootSignIntermediateRequest pkiRootSignIntermediateRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiRootSignIntermediate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiRootSignIntermediateRequest** | [**PkiRootSignIntermediateRequest**](PkiRootSignIntermediateRequest.md)|  | 


### Return type

[**PkiRootSignIntermediateResponse**](PkiRootSignIntermediateResponse.md)

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


<a name="pkirootsignselfissued"></a>
# **PkiRootSignSelfIssued**

> PkiRootSignSelfIssuedResponse PkiRootSignSelfIssued (string pkiMountPath, PkiRootSignSelfIssuedRequest pkiRootSignSelfIssuedRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiRootSignSelfIssuedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiRootSignSelfIssuedRequest = new PkiRootSignSelfIssuedRequest(); // PkiRootSignSelfIssuedRequest | 
            
            

            try
            {
                

                PkiRootSignSelfIssuedResponse result = apiInstance.PkiRootSignSelfIssued(string pkiMountPath, PkiRootSignSelfIssuedRequest pkiRootSignSelfIssuedRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiRootSignSelfIssued: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiRootSignSelfIssuedRequest** | [**PkiRootSignSelfIssuedRequest**](PkiRootSignSelfIssuedRequest.md)|  | 


### Return type

[**PkiRootSignSelfIssuedResponse**](PkiRootSignSelfIssuedResponse.md)

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


<a name="pkirotatecrl"></a>
# **PkiRotateCrl**

> PkiRotateCrlResponse PkiRotateCrl (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiRotateCrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiRotateCrlResponse result = apiInstance.PkiRotateCrl(string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiRotateCrl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiRotateCrlResponse**](PkiRotateCrlResponse.md)

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


<a name="pkirotatedeltacrl"></a>
# **PkiRotateDeltaCrl**

> PkiRotateDeltaCrlResponse PkiRotateDeltaCrl (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiRotateDeltaCrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiRotateDeltaCrlResponse result = apiInstance.PkiRotateDeltaCrl(string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiRotateDeltaCrl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiRotateDeltaCrlResponse**](PkiRotateDeltaCrlResponse.md)

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


<a name="pkisetsignedintermediate"></a>
# **PkiSetSignedIntermediate**

> PkiSetSignedIntermediateResponse PkiSetSignedIntermediate (string pkiMountPath, PkiSetSignedIntermediateRequest pkiSetSignedIntermediateRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiSetSignedIntermediateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiSetSignedIntermediateRequest = new PkiSetSignedIntermediateRequest(); // PkiSetSignedIntermediateRequest | 
            
            

            try
            {
                

                PkiSetSignedIntermediateResponse result = apiInstance.PkiSetSignedIntermediate(string pkiMountPath, PkiSetSignedIntermediateRequest pkiSetSignedIntermediateRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiSetSignedIntermediate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiSetSignedIntermediateRequest** | [**PkiSetSignedIntermediateRequest**](PkiSetSignedIntermediateRequest.md)|  | 


### Return type

[**PkiSetSignedIntermediateResponse**](PkiSetSignedIntermediateResponse.md)

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


<a name="pkisignverbatim"></a>
# **PkiSignVerbatim**

> PkiSignVerbatimResponse PkiSignVerbatim (string pkiMountPath, PkiSignVerbatimRequest pkiSignVerbatimRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiSignVerbatimExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiSignVerbatimRequest = new PkiSignVerbatimRequest(); // PkiSignVerbatimRequest | 
            
            

            try
            {
                

                PkiSignVerbatimResponse result = apiInstance.PkiSignVerbatim(string pkiMountPath, PkiSignVerbatimRequest pkiSignVerbatimRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiSignVerbatim: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiSignVerbatimRequest** | [**PkiSignVerbatimRequest**](PkiSignVerbatimRequest.md)|  | 


### Return type

[**PkiSignVerbatimResponse**](PkiSignVerbatimResponse.md)

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


<a name="pkisignverbatimwithrole"></a>
# **PkiSignVerbatimWithRole**

> PkiSignVerbatimWithRoleResponse PkiSignVerbatimWithRole (string role, string pkiMountPath, PkiSignVerbatimWithRoleRequest pkiSignVerbatimWithRoleRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiSignVerbatimWithRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var role = "role_example";  // string | The desired role with configuration for this request
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiSignVerbatimWithRoleRequest = new PkiSignVerbatimWithRoleRequest(); // PkiSignVerbatimWithRoleRequest | 
            
            

            try
            {
                

                PkiSignVerbatimWithRoleResponse result = apiInstance.PkiSignVerbatimWithRole(string role, string pkiMountPath, PkiSignVerbatimWithRoleRequest pkiSignVerbatimWithRoleRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiSignVerbatimWithRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The desired role with configuration for this request | 
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiSignVerbatimWithRoleRequest** | [**PkiSignVerbatimWithRoleRequest**](PkiSignVerbatimWithRoleRequest.md)|  | 


### Return type

[**PkiSignVerbatimWithRoleResponse**](PkiSignVerbatimWithRoleResponse.md)

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


<a name="pkisignwithrole"></a>
# **PkiSignWithRole**

> PkiSignWithRoleResponse PkiSignWithRole (string role, string pkiMountPath, PkiSignWithRoleRequest pkiSignWithRoleRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiSignWithRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var role = "role_example";  // string | The desired role with configuration for this request
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiSignWithRoleRequest = new PkiSignWithRoleRequest(); // PkiSignWithRoleRequest | 
            
            

            try
            {
                

                PkiSignWithRoleResponse result = apiInstance.PkiSignWithRole(string role, string pkiMountPath, PkiSignWithRoleRequest pkiSignWithRoleRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiSignWithRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The desired role with configuration for this request | 
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiSignWithRoleRequest** | [**PkiSignWithRoleRequest**](PkiSignWithRoleRequest.md)|  | 


### Return type

[**PkiSignWithRoleResponse**](PkiSignWithRoleResponse.md)

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


<a name="pkitidy"></a>
# **PkiTidy**

> void PkiTidy (string pkiMountPath, PkiTidyRequest pkiTidyRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiTidyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiTidyRequest = new PkiTidyRequest(); // PkiTidyRequest | 
            
            

            try
            {
                

                apiInstance.PkiTidy(string pkiMountPath, PkiTidyRequest pkiTidyRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiTidy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiTidyRequest** | [**PkiTidyRequest**](PkiTidyRequest.md)|  | 


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

| **202** | Accepted |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="pkitidycancel"></a>
# **PkiTidyCancel**

> PkiTidyCancelResponse PkiTidyCancel (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiTidyCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiTidyCancelResponse result = apiInstance.PkiTidyCancel(string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiTidyCancel: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiTidyCancelResponse**](PkiTidyCancelResponse.md)

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


<a name="pkitidystatus"></a>
# **PkiTidyStatus**

> PkiTidyStatusResponse PkiTidyStatus (string pkiMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiTidyStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            

            try
            {
                

                PkiTidyStatusResponse result = apiInstance.PkiTidyStatus(string pkiMountPath, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiTidyStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]


### Return type

[**PkiTidyStatusResponse**](PkiTidyStatusResponse.md)

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


<a name="pkiwriteissuer"></a>
# **PkiWriteIssuer**

> PkiWriteIssuerResponse PkiWriteIssuer (string issuerRef, string pkiMountPath, PkiWriteIssuerRequest pkiWriteIssuerRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiWriteIssuerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var issuerRef = "\"default\"";  // string | Reference to a existing issuer; either \"default\" for the configured default issuer, an identifier or the name assigned to the issuer. (default to "default")
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiWriteIssuerRequest = new PkiWriteIssuerRequest(); // PkiWriteIssuerRequest | 
            
            

            try
            {
                

                PkiWriteIssuerResponse result = apiInstance.PkiWriteIssuer(string issuerRef, string pkiMountPath, PkiWriteIssuerRequest pkiWriteIssuerRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiWriteIssuer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiWriteIssuerRequest** | [**PkiWriteIssuerRequest**](PkiWriteIssuerRequest.md)|  | 


### Return type

[**PkiWriteIssuerResponse**](PkiWriteIssuerResponse.md)

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


<a name="pkiwritekey"></a>
# **PkiWriteKey**

> PkiWriteKeyResponse PkiWriteKey (string keyRef, string pkiMountPath, PkiWriteKeyRequest pkiWriteKeyRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiWriteKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var keyRef = "\"default\"";  // string | Reference to key; either \"default\" for the configured default key, an identifier of a key, or the name assigned to the key. (default to "default")
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiWriteKeyRequest = new PkiWriteKeyRequest(); // PkiWriteKeyRequest | 
            
            

            try
            {
                

                PkiWriteKeyResponse result = apiInstance.PkiWriteKey(string keyRef, string pkiMountPath, PkiWriteKeyRequest pkiWriteKeyRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiWriteKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyRef** | **string**| Reference to key; either \&quot;default\&quot; for the configured default key, an identifier of a key, or the name assigned to the key. | [default to &quot;default&quot;]
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiWriteKeyRequest** | [**PkiWriteKeyRequest**](PkiWriteKeyRequest.md)|  | 


### Return type

[**PkiWriteKeyResponse**](PkiWriteKeyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="pkiwriterole"></a>
# **PkiWriteRole**

> PkiWriteRoleResponse PkiWriteRole (string name, string pkiMountPath, PkiWriteRoleRequest pkiWriteRoleRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiWriteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            
            
            var pkiMountPath = "\"pki\"";  // string | Path that the backend was mounted at (default to "pki")
            
            
            
            
            
            var pkiWriteRoleRequest = new PkiWriteRoleRequest(); // PkiWriteRoleRequest | 
            
            

            try
            {
                

                PkiWriteRoleResponse result = apiInstance.PkiWriteRole(string name, string pkiMountPath, PkiWriteRoleRequest pkiWriteRoleRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiWriteRole: " + e.Message );
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
 **pkiMountPath** | **string**| Path that the backend was mounted at | [default to &quot;pki&quot;]
 **pkiWriteRoleRequest** | [**PkiWriteRoleRequest**](PkiWriteRoleRequest.md)|  | 


### Return type

[**PkiWriteRoleResponse**](PkiWriteRoleResponse.md)

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


<a name="rabbitmqconfigureconnection"></a>
# **RabbitMqConfigureConnection**

> void RabbitMqConfigureConnection (string rabbitmqMountPath, RabbitMqConfigureConnectionRequest rabbitMqConfigureConnectionRequest, TimeSpan? wrapTTL = null)

Configure the connection URI, username, and password to talk to RabbitMQ management HTTP API.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class RabbitMqConfigureConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var rabbitmqMountPath = "\"rabbitmq\"";  // string | Path that the backend was mounted at (default to "rabbitmq")
            
            
            
            
            
            var rabbitMqConfigureConnectionRequest = new RabbitMqConfigureConnectionRequest(); // RabbitMqConfigureConnectionRequest | 
            
            

            try
            {
                
                // Configure the connection URI, username, and password to talk to RabbitMQ management HTTP API.
                

                apiInstance.RabbitMqConfigureConnection(string rabbitmqMountPath, RabbitMqConfigureConnectionRequest rabbitMqConfigureConnectionRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.RabbitMqConfigureConnection: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rabbitmqMountPath** | **string**| Path that the backend was mounted at | [default to &quot;rabbitmq&quot;]
 **rabbitMqConfigureConnectionRequest** | [**RabbitMqConfigureConnectionRequest**](RabbitMqConfigureConnectionRequest.md)|  | 


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


<a name="rabbitmqconfigurelease"></a>
# **RabbitMqConfigureLease**

> void RabbitMqConfigureLease (string rabbitmqMountPath, RabbitMqConfigureLeaseRequest rabbitMqConfigureLeaseRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class RabbitMqConfigureLeaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var rabbitmqMountPath = "\"rabbitmq\"";  // string | Path that the backend was mounted at (default to "rabbitmq")
            
            
            
            
            
            var rabbitMqConfigureLeaseRequest = new RabbitMqConfigureLeaseRequest(); // RabbitMqConfigureLeaseRequest | 
            
            

            try
            {
                

                apiInstance.RabbitMqConfigureLease(string rabbitmqMountPath, RabbitMqConfigureLeaseRequest rabbitMqConfigureLeaseRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.RabbitMqConfigureLease: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rabbitmqMountPath** | **string**| Path that the backend was mounted at | [default to &quot;rabbitmq&quot;]
 **rabbitMqConfigureLeaseRequest** | [**RabbitMqConfigureLeaseRequest**](RabbitMqConfigureLeaseRequest.md)|  | 


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


<a name="rabbitmqdeleterole"></a>
# **RabbitMqDeleteRole**

> void RabbitMqDeleteRole (string name, string rabbitmqMountPath, TimeSpan? wrapTTL = null)

Manage the roles that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class RabbitMqDeleteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role.
            
            
            
            
            var rabbitmqMountPath = "\"rabbitmq\"";  // string | Path that the backend was mounted at (default to "rabbitmq")
            
            
            

            try
            {
                
                // Manage the roles that can be created with this backend.
                

                apiInstance.RabbitMqDeleteRole(string name, string rabbitmqMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.RabbitMqDeleteRole: " + e.Message );
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
 **rabbitmqMountPath** | **string**| Path that the backend was mounted at | [default to &quot;rabbitmq&quot;]


### Return type

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


<a name="rabbitmqlistroles"></a>
# **RabbitMqListRoles**

> void RabbitMqListRoles (string rabbitmqMountPath, TimeSpan? wrapTTL = null)

Manage the roles that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class RabbitMqListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var rabbitmqMountPath = "\"rabbitmq\"";  // string | Path that the backend was mounted at (default to "rabbitmq")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // Manage the roles that can be created with this backend.
                

                apiInstance.RabbitMqListRoles(string rabbitmqMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.RabbitMqListRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rabbitmqMountPath** | **string**| Path that the backend was mounted at | [default to &quot;rabbitmq&quot;]
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


<a name="rabbitmqreadleaseconfiguration"></a>
# **RabbitMqReadLeaseConfiguration**

> void RabbitMqReadLeaseConfiguration (string rabbitmqMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class RabbitMqReadLeaseConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var rabbitmqMountPath = "\"rabbitmq\"";  // string | Path that the backend was mounted at (default to "rabbitmq")
            
            
            

            try
            {
                

                apiInstance.RabbitMqReadLeaseConfiguration(string rabbitmqMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.RabbitMqReadLeaseConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rabbitmqMountPath** | **string**| Path that the backend was mounted at | [default to &quot;rabbitmq&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="rabbitmqreadrole"></a>
# **RabbitMqReadRole**

> void RabbitMqReadRole (string name, string rabbitmqMountPath, TimeSpan? wrapTTL = null)

Manage the roles that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class RabbitMqReadRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role.
            
            
            
            
            var rabbitmqMountPath = "\"rabbitmq\"";  // string | Path that the backend was mounted at (default to "rabbitmq")
            
            
            

            try
            {
                
                // Manage the roles that can be created with this backend.
                

                apiInstance.RabbitMqReadRole(string name, string rabbitmqMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.RabbitMqReadRole: " + e.Message );
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
 **rabbitmqMountPath** | **string**| Path that the backend was mounted at | [default to &quot;rabbitmq&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="rabbitmqrequestcredentials"></a>
# **RabbitMqRequestCredentials**

> void RabbitMqRequestCredentials (string name, string rabbitmqMountPath, TimeSpan? wrapTTL = null)

Request RabbitMQ credentials for a certain role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class RabbitMqRequestCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role.
            
            
            
            
            var rabbitmqMountPath = "\"rabbitmq\"";  // string | Path that the backend was mounted at (default to "rabbitmq")
            
            
            

            try
            {
                
                // Request RabbitMQ credentials for a certain role.
                

                apiInstance.RabbitMqRequestCredentials(string name, string rabbitmqMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.RabbitMqRequestCredentials: " + e.Message );
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
 **rabbitmqMountPath** | **string**| Path that the backend was mounted at | [default to &quot;rabbitmq&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="rabbitmqwriterole"></a>
# **RabbitMqWriteRole**

> void RabbitMqWriteRole (string name, string rabbitmqMountPath, RabbitMqWriteRoleRequest rabbitMqWriteRoleRequest, TimeSpan? wrapTTL = null)

Manage the roles that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class RabbitMqWriteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role.
            
            
            
            
            var rabbitmqMountPath = "\"rabbitmq\"";  // string | Path that the backend was mounted at (default to "rabbitmq")
            
            
            
            
            
            var rabbitMqWriteRoleRequest = new RabbitMqWriteRoleRequest(); // RabbitMqWriteRoleRequest | 
            
            

            try
            {
                
                // Manage the roles that can be created with this backend.
                

                apiInstance.RabbitMqWriteRole(string name, string rabbitmqMountPath, RabbitMqWriteRoleRequest rabbitMqWriteRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.RabbitMqWriteRole: " + e.Message );
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
 **rabbitmqMountPath** | **string**| Path that the backend was mounted at | [default to &quot;rabbitmq&quot;]
 **rabbitMqWriteRoleRequest** | [**RabbitMqWriteRoleRequest**](RabbitMqWriteRoleRequest.md)|  | 


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


<a name="sshconfigureca"></a>
# **SshConfigureCa**

> void SshConfigureCa (string sshMountPath, SshConfigureCaRequest sshConfigureCaRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SshConfigureCaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var sshMountPath = "\"ssh\"";  // string | Path that the backend was mounted at (default to "ssh")
            
            
            
            
            
            var sshConfigureCaRequest = new SshConfigureCaRequest(); // SshConfigureCaRequest | 
            
            

            try
            {
                

                apiInstance.SshConfigureCa(string sshMountPath, SshConfigureCaRequest sshConfigureCaRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SshConfigureCa: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sshMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ssh&quot;]
 **sshConfigureCaRequest** | [**SshConfigureCaRequest**](SshConfigureCaRequest.md)|  | 


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


<a name="sshconfigurezeroaddress"></a>
# **SshConfigureZeroAddress**

> void SshConfigureZeroAddress (string sshMountPath, SshConfigureZeroAddressRequest sshConfigureZeroAddressRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SshConfigureZeroAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var sshMountPath = "\"ssh\"";  // string | Path that the backend was mounted at (default to "ssh")
            
            
            
            
            
            var sshConfigureZeroAddressRequest = new SshConfigureZeroAddressRequest(); // SshConfigureZeroAddressRequest | 
            
            

            try
            {
                

                apiInstance.SshConfigureZeroAddress(string sshMountPath, SshConfigureZeroAddressRequest sshConfigureZeroAddressRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SshConfigureZeroAddress: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sshMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ssh&quot;]
 **sshConfigureZeroAddressRequest** | [**SshConfigureZeroAddressRequest**](SshConfigureZeroAddressRequest.md)|  | 


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


<a name="sshdeletecaconfiguration"></a>
# **SshDeleteCaConfiguration**

> void SshDeleteCaConfiguration (string sshMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SshDeleteCaConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var sshMountPath = "\"ssh\"";  // string | Path that the backend was mounted at (default to "ssh")
            
            
            

            try
            {
                

                apiInstance.SshDeleteCaConfiguration(string sshMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SshDeleteCaConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sshMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ssh&quot;]


### Return type

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


<a name="sshdeleterole"></a>
# **SshDeleteRole**

> void SshDeleteRole (string role, string sshMountPath, TimeSpan? wrapTTL = null)

Manage the 'roles' that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SshDeleteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var role = "role_example";  // string | [Required for all types] Name of the role being created.
            
            
            
            
            var sshMountPath = "\"ssh\"";  // string | Path that the backend was mounted at (default to "ssh")
            
            
            

            try
            {
                
                // Manage the 'roles' that can be created with this backend.
                

                apiInstance.SshDeleteRole(string role, string sshMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SshDeleteRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| [Required for all types] Name of the role being created. | 
 **sshMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ssh&quot;]


### Return type

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


<a name="sshdeletezeroaddressconfiguration"></a>
# **SshDeleteZeroAddressConfiguration**

> void SshDeleteZeroAddressConfiguration (string sshMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SshDeleteZeroAddressConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var sshMountPath = "\"ssh\"";  // string | Path that the backend was mounted at (default to "ssh")
            
            
            

            try
            {
                

                apiInstance.SshDeleteZeroAddressConfiguration(string sshMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SshDeleteZeroAddressConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sshMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ssh&quot;]


### Return type

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


<a name="sshgeneratecredentials"></a>
# **SshGenerateCredentials**

> void SshGenerateCredentials (string role, string sshMountPath, SshGenerateCredentialsRequest sshGenerateCredentialsRequest, TimeSpan? wrapTTL = null)

Creates a credential for establishing SSH connection with the remote host.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SshGenerateCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var role = "role_example";  // string | [Required] Name of the role
            
            
            
            
            var sshMountPath = "\"ssh\"";  // string | Path that the backend was mounted at (default to "ssh")
            
            
            
            
            
            var sshGenerateCredentialsRequest = new SshGenerateCredentialsRequest(); // SshGenerateCredentialsRequest | 
            
            

            try
            {
                
                // Creates a credential for establishing SSH connection with the remote host.
                

                apiInstance.SshGenerateCredentials(string role, string sshMountPath, SshGenerateCredentialsRequest sshGenerateCredentialsRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SshGenerateCredentials: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| [Required] Name of the role | 
 **sshMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ssh&quot;]
 **sshGenerateCredentialsRequest** | [**SshGenerateCredentialsRequest**](SshGenerateCredentialsRequest.md)|  | 


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


<a name="sshissuecertificate"></a>
# **SshIssueCertificate**

> void SshIssueCertificate (string role, string sshMountPath, SshIssueCertificateRequest sshIssueCertificateRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SshIssueCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var role = "role_example";  // string | The desired role with configuration for this request.
            
            
            
            
            var sshMountPath = "\"ssh\"";  // string | Path that the backend was mounted at (default to "ssh")
            
            
            
            
            
            var sshIssueCertificateRequest = new SshIssueCertificateRequest(); // SshIssueCertificateRequest | 
            
            

            try
            {
                

                apiInstance.SshIssueCertificate(string role, string sshMountPath, SshIssueCertificateRequest sshIssueCertificateRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SshIssueCertificate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The desired role with configuration for this request. | 
 **sshMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ssh&quot;]
 **sshIssueCertificateRequest** | [**SshIssueCertificateRequest**](SshIssueCertificateRequest.md)|  | 


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


<a name="sshlistroles"></a>
# **SshListRoles**

> void SshListRoles (string sshMountPath, TimeSpan? wrapTTL = null)

Manage the 'roles' that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SshListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var sshMountPath = "\"ssh\"";  // string | Path that the backend was mounted at (default to "ssh")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // Manage the 'roles' that can be created with this backend.
                

                apiInstance.SshListRoles(string sshMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SshListRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sshMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ssh&quot;]
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


<a name="sshlistrolesbyip"></a>
# **SshListRolesByIp**

> void SshListRolesByIp (string sshMountPath, SshListRolesByIpRequest sshListRolesByIpRequest, TimeSpan? wrapTTL = null)

List all the roles associated with the given IP address.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SshListRolesByIpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var sshMountPath = "\"ssh\"";  // string | Path that the backend was mounted at (default to "ssh")
            
            
            
            
            
            var sshListRolesByIpRequest = new SshListRolesByIpRequest(); // SshListRolesByIpRequest | 
            
            

            try
            {
                
                // List all the roles associated with the given IP address.
                

                apiInstance.SshListRolesByIp(string sshMountPath, SshListRolesByIpRequest sshListRolesByIpRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SshListRolesByIp: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sshMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ssh&quot;]
 **sshListRolesByIpRequest** | [**SshListRolesByIpRequest**](SshListRolesByIpRequest.md)|  | 


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


<a name="sshreadcaconfiguration"></a>
# **SshReadCaConfiguration**

> void SshReadCaConfiguration (string sshMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SshReadCaConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var sshMountPath = "\"ssh\"";  // string | Path that the backend was mounted at (default to "ssh")
            
            
            

            try
            {
                

                apiInstance.SshReadCaConfiguration(string sshMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SshReadCaConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sshMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ssh&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="sshreadpublickey"></a>
# **SshReadPublicKey**

> void SshReadPublicKey (string sshMountPath, TimeSpan? wrapTTL = null)

Retrieve the public key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SshReadPublicKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var sshMountPath = "\"ssh\"";  // string | Path that the backend was mounted at (default to "ssh")
            
            
            

            try
            {
                
                // Retrieve the public key.
                

                apiInstance.SshReadPublicKey(string sshMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SshReadPublicKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sshMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ssh&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="sshreadrole"></a>
# **SshReadRole**

> void SshReadRole (string role, string sshMountPath, TimeSpan? wrapTTL = null)

Manage the 'roles' that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SshReadRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var role = "role_example";  // string | [Required for all types] Name of the role being created.
            
            
            
            
            var sshMountPath = "\"ssh\"";  // string | Path that the backend was mounted at (default to "ssh")
            
            
            

            try
            {
                
                // Manage the 'roles' that can be created with this backend.
                

                apiInstance.SshReadRole(string role, string sshMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SshReadRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| [Required for all types] Name of the role being created. | 
 **sshMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ssh&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="sshreadzeroaddressconfiguration"></a>
# **SshReadZeroAddressConfiguration**

> void SshReadZeroAddressConfiguration (string sshMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SshReadZeroAddressConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var sshMountPath = "\"ssh\"";  // string | Path that the backend was mounted at (default to "ssh")
            
            
            

            try
            {
                

                apiInstance.SshReadZeroAddressConfiguration(string sshMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SshReadZeroAddressConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sshMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ssh&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="sshsigncertificate"></a>
# **SshSignCertificate**

> void SshSignCertificate (string role, string sshMountPath, SshSignCertificateRequest sshSignCertificateRequest, TimeSpan? wrapTTL = null)

Request signing an SSH key using a certain role with the provided details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SshSignCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var role = "role_example";  // string | The desired role with configuration for this request.
            
            
            
            
            var sshMountPath = "\"ssh\"";  // string | Path that the backend was mounted at (default to "ssh")
            
            
            
            
            
            var sshSignCertificateRequest = new SshSignCertificateRequest(); // SshSignCertificateRequest | 
            
            

            try
            {
                
                // Request signing an SSH key using a certain role with the provided details.
                

                apiInstance.SshSignCertificate(string role, string sshMountPath, SshSignCertificateRequest sshSignCertificateRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SshSignCertificate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The desired role with configuration for this request. | 
 **sshMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ssh&quot;]
 **sshSignCertificateRequest** | [**SshSignCertificateRequest**](SshSignCertificateRequest.md)|  | 


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


<a name="sshtidydynamichostkeys"></a>
# **SshTidyDynamicHostKeys**

> void SshTidyDynamicHostKeys (string sshMountPath, TimeSpan? wrapTTL = null)

This endpoint removes the stored host keys used for the removed Dynamic Key feature, if present.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SshTidyDynamicHostKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var sshMountPath = "\"ssh\"";  // string | Path that the backend was mounted at (default to "ssh")
            
            
            

            try
            {
                
                // This endpoint removes the stored host keys used for the removed Dynamic Key feature, if present.
                

                apiInstance.SshTidyDynamicHostKeys(string sshMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SshTidyDynamicHostKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sshMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ssh&quot;]


### Return type

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


<a name="sshverifyotp"></a>
# **SshVerifyOtp**

> void SshVerifyOtp (string sshMountPath, SshVerifyOtpRequest sshVerifyOtpRequest, TimeSpan? wrapTTL = null)

Validate the OTP provided by Vault SSH Agent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SshVerifyOtpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var sshMountPath = "\"ssh\"";  // string | Path that the backend was mounted at (default to "ssh")
            
            
            
            
            
            var sshVerifyOtpRequest = new SshVerifyOtpRequest(); // SshVerifyOtpRequest | 
            
            

            try
            {
                
                // Validate the OTP provided by Vault SSH Agent.
                

                apiInstance.SshVerifyOtp(string sshMountPath, SshVerifyOtpRequest sshVerifyOtpRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SshVerifyOtp: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sshMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ssh&quot;]
 **sshVerifyOtpRequest** | [**SshVerifyOtpRequest**](SshVerifyOtpRequest.md)|  | 


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


<a name="sshwriterole"></a>
# **SshWriteRole**

> void SshWriteRole (string role, string sshMountPath, SshWriteRoleRequest sshWriteRoleRequest, TimeSpan? wrapTTL = null)

Manage the 'roles' that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SshWriteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var role = "role_example";  // string | [Required for all types] Name of the role being created.
            
            
            
            
            var sshMountPath = "\"ssh\"";  // string | Path that the backend was mounted at (default to "ssh")
            
            
            
            
            
            var sshWriteRoleRequest = new SshWriteRoleRequest(); // SshWriteRoleRequest | 
            
            

            try
            {
                
                // Manage the 'roles' that can be created with this backend.
                

                apiInstance.SshWriteRole(string role, string sshMountPath, SshWriteRoleRequest sshWriteRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SshWriteRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| [Required for all types] Name of the role being created. | 
 **sshMountPath** | **string**| Path that the backend was mounted at | [default to &quot;ssh&quot;]
 **sshWriteRoleRequest** | [**SshWriteRoleRequest**](SshWriteRoleRequest.md)|  | 


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


<a name="terraformcloudconfigure"></a>
# **TerraformCloudConfigure**

> void TerraformCloudConfigure (string terraformMountPath, TerraformCloudConfigureRequest terraformCloudConfigureRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TerraformCloudConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var terraformMountPath = "\"terraform\"";  // string | Path that the backend was mounted at (default to "terraform")
            
            
            
            
            
            var terraformCloudConfigureRequest = new TerraformCloudConfigureRequest(); // TerraformCloudConfigureRequest | 
            
            

            try
            {
                

                apiInstance.TerraformCloudConfigure(string terraformMountPath, TerraformCloudConfigureRequest terraformCloudConfigureRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TerraformCloudConfigure: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **terraformMountPath** | **string**| Path that the backend was mounted at | [default to &quot;terraform&quot;]
 **terraformCloudConfigureRequest** | [**TerraformCloudConfigureRequest**](TerraformCloudConfigureRequest.md)|  | 


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


<a name="terraformclouddeleteconfiguration"></a>
# **TerraformCloudDeleteConfiguration**

> void TerraformCloudDeleteConfiguration (string terraformMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TerraformCloudDeleteConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var terraformMountPath = "\"terraform\"";  // string | Path that the backend was mounted at (default to "terraform")
            
            
            

            try
            {
                

                apiInstance.TerraformCloudDeleteConfiguration(string terraformMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TerraformCloudDeleteConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **terraformMountPath** | **string**| Path that the backend was mounted at | [default to &quot;terraform&quot;]


### Return type

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


<a name="terraformclouddeleterole"></a>
# **TerraformCloudDeleteRole**

> void TerraformCloudDeleteRole (string name, string terraformMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TerraformCloudDeleteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            
            
            var terraformMountPath = "\"terraform\"";  // string | Path that the backend was mounted at (default to "terraform")
            
            
            

            try
            {
                

                apiInstance.TerraformCloudDeleteRole(string name, string terraformMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TerraformCloudDeleteRole: " + e.Message );
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
 **terraformMountPath** | **string**| Path that the backend was mounted at | [default to &quot;terraform&quot;]


### Return type

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


<a name="terraformcloudgeneratecredentials"></a>
# **TerraformCloudGenerateCredentials**

> void TerraformCloudGenerateCredentials (string name, string terraformMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TerraformCloudGenerateCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            
            
            var terraformMountPath = "\"terraform\"";  // string | Path that the backend was mounted at (default to "terraform")
            
            
            

            try
            {
                

                apiInstance.TerraformCloudGenerateCredentials(string name, string terraformMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TerraformCloudGenerateCredentials: " + e.Message );
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
 **terraformMountPath** | **string**| Path that the backend was mounted at | [default to &quot;terraform&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="terraformcloudgeneratecredentials2"></a>
# **TerraformCloudGenerateCredentials2**

> void TerraformCloudGenerateCredentials2 (string name, string terraformMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TerraformCloudGenerateCredentials2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            
            
            var terraformMountPath = "\"terraform\"";  // string | Path that the backend was mounted at (default to "terraform")
            
            
            

            try
            {
                

                apiInstance.TerraformCloudGenerateCredentials2(string name, string terraformMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TerraformCloudGenerateCredentials2: " + e.Message );
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
 **terraformMountPath** | **string**| Path that the backend was mounted at | [default to &quot;terraform&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="terraformcloudlistroles"></a>
# **TerraformCloudListRoles**

> void TerraformCloudListRoles (string terraformMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TerraformCloudListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var terraformMountPath = "\"terraform\"";  // string | Path that the backend was mounted at (default to "terraform")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                

                apiInstance.TerraformCloudListRoles(string terraformMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TerraformCloudListRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **terraformMountPath** | **string**| Path that the backend was mounted at | [default to &quot;terraform&quot;]
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


<a name="terraformcloudreadconfiguration"></a>
# **TerraformCloudReadConfiguration**

> void TerraformCloudReadConfiguration (string terraformMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TerraformCloudReadConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var terraformMountPath = "\"terraform\"";  // string | Path that the backend was mounted at (default to "terraform")
            
            
            

            try
            {
                

                apiInstance.TerraformCloudReadConfiguration(string terraformMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TerraformCloudReadConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **terraformMountPath** | **string**| Path that the backend was mounted at | [default to &quot;terraform&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="terraformcloudreadrole"></a>
# **TerraformCloudReadRole**

> void TerraformCloudReadRole (string name, string terraformMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TerraformCloudReadRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            
            
            var terraformMountPath = "\"terraform\"";  // string | Path that the backend was mounted at (default to "terraform")
            
            
            

            try
            {
                

                apiInstance.TerraformCloudReadRole(string name, string terraformMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TerraformCloudReadRole: " + e.Message );
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
 **terraformMountPath** | **string**| Path that the backend was mounted at | [default to &quot;terraform&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="terraformcloudrotaterole"></a>
# **TerraformCloudRotateRole**

> void TerraformCloudRotateRole (string name, string terraformMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TerraformCloudRotateRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the team or organization role
            
            
            
            
            var terraformMountPath = "\"terraform\"";  // string | Path that the backend was mounted at (default to "terraform")
            
            
            

            try
            {
                

                apiInstance.TerraformCloudRotateRole(string name, string terraformMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TerraformCloudRotateRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the team or organization role | 
 **terraformMountPath** | **string**| Path that the backend was mounted at | [default to &quot;terraform&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="terraformcloudwriterole"></a>
# **TerraformCloudWriteRole**

> void TerraformCloudWriteRole (string name, string terraformMountPath, TerraformCloudWriteRoleRequest terraformCloudWriteRoleRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TerraformCloudWriteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the role
            
            
            
            
            var terraformMountPath = "\"terraform\"";  // string | Path that the backend was mounted at (default to "terraform")
            
            
            
            
            
            var terraformCloudWriteRoleRequest = new TerraformCloudWriteRoleRequest(); // TerraformCloudWriteRoleRequest | 
            
            

            try
            {
                

                apiInstance.TerraformCloudWriteRole(string name, string terraformMountPath, TerraformCloudWriteRoleRequest terraformCloudWriteRoleRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TerraformCloudWriteRole: " + e.Message );
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
 **terraformMountPath** | **string**| Path that the backend was mounted at | [default to &quot;terraform&quot;]
 **terraformCloudWriteRoleRequest** | [**TerraformCloudWriteRoleRequest**](TerraformCloudWriteRoleRequest.md)|  | 


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


<a name="totpcreatekey"></a>
# **TotpCreateKey**

> void TotpCreateKey (string name, string totpMountPath, TotpCreateKeyRequest totpCreateKeyRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TotpCreateKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the key.
            
            
            
            
            var totpMountPath = "\"totp\"";  // string | Path that the backend was mounted at (default to "totp")
            
            
            
            
            
            var totpCreateKeyRequest = new TotpCreateKeyRequest(); // TotpCreateKeyRequest | 
            
            

            try
            {
                

                apiInstance.TotpCreateKey(string name, string totpMountPath, TotpCreateKeyRequest totpCreateKeyRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TotpCreateKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the key. | 
 **totpMountPath** | **string**| Path that the backend was mounted at | [default to &quot;totp&quot;]
 **totpCreateKeyRequest** | [**TotpCreateKeyRequest**](TotpCreateKeyRequest.md)|  | 


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


<a name="totpdeletekey"></a>
# **TotpDeleteKey**

> void TotpDeleteKey (string name, string totpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TotpDeleteKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the key.
            
            
            
            
            var totpMountPath = "\"totp\"";  // string | Path that the backend was mounted at (default to "totp")
            
            
            

            try
            {
                

                apiInstance.TotpDeleteKey(string name, string totpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TotpDeleteKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the key. | 
 **totpMountPath** | **string**| Path that the backend was mounted at | [default to &quot;totp&quot;]


### Return type

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


<a name="totpgeneratecode"></a>
# **TotpGenerateCode**

> void TotpGenerateCode (string name, string totpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TotpGenerateCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the key.
            
            
            
            
            var totpMountPath = "\"totp\"";  // string | Path that the backend was mounted at (default to "totp")
            
            
            

            try
            {
                

                apiInstance.TotpGenerateCode(string name, string totpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TotpGenerateCode: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the key. | 
 **totpMountPath** | **string**| Path that the backend was mounted at | [default to &quot;totp&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="totplistkeys"></a>
# **TotpListKeys**

> void TotpListKeys (string totpMountPath, TimeSpan? wrapTTL = null)

Manage the keys that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TotpListKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var totpMountPath = "\"totp\"";  // string | Path that the backend was mounted at (default to "totp")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // Manage the keys that can be created with this backend.
                

                apiInstance.TotpListKeys(string totpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TotpListKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **totpMountPath** | **string**| Path that the backend was mounted at | [default to &quot;totp&quot;]
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


<a name="totpreadkey"></a>
# **TotpReadKey**

> void TotpReadKey (string name, string totpMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TotpReadKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the key.
            
            
            
            
            var totpMountPath = "\"totp\"";  // string | Path that the backend was mounted at (default to "totp")
            
            
            

            try
            {
                

                apiInstance.TotpReadKey(string name, string totpMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TotpReadKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the key. | 
 **totpMountPath** | **string**| Path that the backend was mounted at | [default to &quot;totp&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="totpvalidatecode"></a>
# **TotpValidateCode**

> void TotpValidateCode (string name, string totpMountPath, TotpValidateCodeRequest totpValidateCodeRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TotpValidateCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the key.
            
            
            
            
            var totpMountPath = "\"totp\"";  // string | Path that the backend was mounted at (default to "totp")
            
            
            
            
            
            var totpValidateCodeRequest = new TotpValidateCodeRequest(); // TotpValidateCodeRequest | 
            
            

            try
            {
                

                apiInstance.TotpValidateCode(string name, string totpMountPath, TotpValidateCodeRequest totpValidateCodeRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TotpValidateCode: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the key. | 
 **totpMountPath** | **string**| Path that the backend was mounted at | [default to &quot;totp&quot;]
 **totpValidateCodeRequest** | [**TotpValidateCodeRequest**](TotpValidateCodeRequest.md)|  | 


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


<a name="transitbackupkey"></a>
# **TransitBackUpKey**

> void TransitBackUpKey (string name, string transitMountPath, TimeSpan? wrapTTL = null)

Backup the named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitBackUpKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the key
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            

            try
            {
                
                // Backup the named key
                

                apiInstance.TransitBackUpKey(string name, string transitMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitBackUpKey: " + e.Message );
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
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="transitconfigurecache"></a>
# **TransitConfigureCache**

> void TransitConfigureCache (string transitMountPath, TransitConfigureCacheRequest transitConfigureCacheRequest, TimeSpan? wrapTTL = null)

Configures a new cache of the specified size

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitConfigureCacheExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitConfigureCacheRequest = new TransitConfigureCacheRequest(); // TransitConfigureCacheRequest | 
            
            

            try
            {
                
                // Configures a new cache of the specified size
                

                apiInstance.TransitConfigureCache(string transitMountPath, TransitConfigureCacheRequest transitConfigureCacheRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitConfigureCache: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitConfigureCacheRequest** | [**TransitConfigureCacheRequest**](TransitConfigureCacheRequest.md)|  | 


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


<a name="transitconfigurekey"></a>
# **TransitConfigureKey**

> void TransitConfigureKey (string name, string transitMountPath, TransitConfigureKeyRequest transitConfigureKeyRequest, TimeSpan? wrapTTL = null)

Configure a named encryption key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitConfigureKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the key
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitConfigureKeyRequest = new TransitConfigureKeyRequest(); // TransitConfigureKeyRequest | 
            
            

            try
            {
                
                // Configure a named encryption key
                

                apiInstance.TransitConfigureKey(string name, string transitMountPath, TransitConfigureKeyRequest transitConfigureKeyRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitConfigureKey: " + e.Message );
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
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitConfigureKeyRequest** | [**TransitConfigureKeyRequest**](TransitConfigureKeyRequest.md)|  | 


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


<a name="transitconfigurekeys"></a>
# **TransitConfigureKeys**

> void TransitConfigureKeys (string transitMountPath, TransitConfigureKeysRequest transitConfigureKeysRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitConfigureKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitConfigureKeysRequest = new TransitConfigureKeysRequest(); // TransitConfigureKeysRequest | 
            
            

            try
            {
                

                apiInstance.TransitConfigureKeys(string transitMountPath, TransitConfigureKeysRequest transitConfigureKeysRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitConfigureKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitConfigureKeysRequest** | [**TransitConfigureKeysRequest**](TransitConfigureKeysRequest.md)|  | 


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


<a name="transitcreatekey"></a>
# **TransitCreateKey**

> void TransitCreateKey (string name, string transitMountPath, TransitCreateKeyRequest transitCreateKeyRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitCreateKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the key
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitCreateKeyRequest = new TransitCreateKeyRequest(); // TransitCreateKeyRequest | 
            
            

            try
            {
                

                apiInstance.TransitCreateKey(string name, string transitMountPath, TransitCreateKeyRequest transitCreateKeyRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitCreateKey: " + e.Message );
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
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitCreateKeyRequest** | [**TransitCreateKeyRequest**](TransitCreateKeyRequest.md)|  | 


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


<a name="transitdecrypt"></a>
# **TransitDecrypt**

> void TransitDecrypt (string name, string transitMountPath, TransitDecryptRequest transitDecryptRequest, TimeSpan? wrapTTL = null)

Decrypt a ciphertext value using a named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitDecryptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the key
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitDecryptRequest = new TransitDecryptRequest(); // TransitDecryptRequest | 
            
            

            try
            {
                
                // Decrypt a ciphertext value using a named key
                

                apiInstance.TransitDecrypt(string name, string transitMountPath, TransitDecryptRequest transitDecryptRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitDecrypt: " + e.Message );
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
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitDecryptRequest** | [**TransitDecryptRequest**](TransitDecryptRequest.md)|  | 


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


<a name="transitdeletekey"></a>
# **TransitDeleteKey**

> void TransitDeleteKey (string name, string transitMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitDeleteKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the key
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            

            try
            {
                

                apiInstance.TransitDeleteKey(string name, string transitMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitDeleteKey: " + e.Message );
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
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]


### Return type

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


<a name="transitencrypt"></a>
# **TransitEncrypt**

> void TransitEncrypt (string name, string transitMountPath, TransitEncryptRequest transitEncryptRequest, TimeSpan? wrapTTL = null)

Encrypt a plaintext value or a batch of plaintext blocks using a named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitEncryptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the key
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitEncryptRequest = new TransitEncryptRequest(); // TransitEncryptRequest | 
            
            

            try
            {
                
                // Encrypt a plaintext value or a batch of plaintext blocks using a named key
                

                apiInstance.TransitEncrypt(string name, string transitMountPath, TransitEncryptRequest transitEncryptRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitEncrypt: " + e.Message );
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
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitEncryptRequest** | [**TransitEncryptRequest**](TransitEncryptRequest.md)|  | 


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


<a name="transitexportkey"></a>
# **TransitExportKey**

> void TransitExportKey (string name, string type, string transitMountPath, TimeSpan? wrapTTL = null)

Export named encryption or signing key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitExportKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the key
            
            
            
            
            var type = "type_example";  // string | Type of key to export (encryption-key, signing-key, hmac-key)
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            

            try
            {
                
                // Export named encryption or signing key
                

                apiInstance.TransitExportKey(string name, string type, string transitMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitExportKey: " + e.Message );
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
 **type** | **string**| Type of key to export (encryption-key, signing-key, hmac-key) | 
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="transitexportkeyversion"></a>
# **TransitExportKeyVersion**

> void TransitExportKeyVersion (string name, string type, string version, string transitMountPath, TimeSpan? wrapTTL = null)

Export named encryption or signing key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitExportKeyVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the key
            
            
            
            
            var type = "type_example";  // string | Type of key to export (encryption-key, signing-key, hmac-key)
            
            
            
            
            var version = "version_example";  // string | Version of the key
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            

            try
            {
                
                // Export named encryption or signing key
                

                apiInstance.TransitExportKeyVersion(string name, string type, string version, string transitMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitExportKeyVersion: " + e.Message );
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
 **type** | **string**| Type of key to export (encryption-key, signing-key, hmac-key) | 
 **version** | **string**| Version of the key | 
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="transitgeneratedatakey"></a>
# **TransitGenerateDataKey**

> void TransitGenerateDataKey (string name, string plaintext, string transitMountPath, TransitGenerateDataKeyRequest transitGenerateDataKeyRequest, TimeSpan? wrapTTL = null)

Generate a data key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitGenerateDataKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | The backend key used for encrypting the data key
            
            
            
            
            var plaintext = "plaintext_example";  // string | \"plaintext\" will return the key in both plaintext and ciphertext; \"wrapped\" will return the ciphertext only.
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitGenerateDataKeyRequest = new TransitGenerateDataKeyRequest(); // TransitGenerateDataKeyRequest | 
            
            

            try
            {
                
                // Generate a data key
                

                apiInstance.TransitGenerateDataKey(string name, string plaintext, string transitMountPath, TransitGenerateDataKeyRequest transitGenerateDataKeyRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitGenerateDataKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The backend key used for encrypting the data key | 
 **plaintext** | **string**| \&quot;plaintext\&quot; will return the key in both plaintext and ciphertext; \&quot;wrapped\&quot; will return the ciphertext only. | 
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitGenerateDataKeyRequest** | [**TransitGenerateDataKeyRequest**](TransitGenerateDataKeyRequest.md)|  | 


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


<a name="transitgeneratehmac"></a>
# **TransitGenerateHmac**

> void TransitGenerateHmac (string name, string transitMountPath, TransitGenerateHmacRequest transitGenerateHmacRequest, TimeSpan? wrapTTL = null)

Generate an HMAC for input data using the named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitGenerateHmacExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | The key to use for the HMAC function
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitGenerateHmacRequest = new TransitGenerateHmacRequest(); // TransitGenerateHmacRequest | 
            
            

            try
            {
                
                // Generate an HMAC for input data using the named key
                

                apiInstance.TransitGenerateHmac(string name, string transitMountPath, TransitGenerateHmacRequest transitGenerateHmacRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitGenerateHmac: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The key to use for the HMAC function | 
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitGenerateHmacRequest** | [**TransitGenerateHmacRequest**](TransitGenerateHmacRequest.md)|  | 


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


<a name="transitgeneratehmacwithalgorithm"></a>
# **TransitGenerateHmacWithAlgorithm**

> void TransitGenerateHmacWithAlgorithm (string name, string urlalgorithm, string transitMountPath, TransitGenerateHmacWithAlgorithmRequest transitGenerateHmacWithAlgorithmRequest, TimeSpan? wrapTTL = null)

Generate an HMAC for input data using the named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitGenerateHmacWithAlgorithmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | The key to use for the HMAC function
            
            
            
            
            var urlalgorithm = "urlalgorithm_example";  // string | Algorithm to use (POST URL parameter)
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitGenerateHmacWithAlgorithmRequest = new TransitGenerateHmacWithAlgorithmRequest(); // TransitGenerateHmacWithAlgorithmRequest | 
            
            

            try
            {
                
                // Generate an HMAC for input data using the named key
                

                apiInstance.TransitGenerateHmacWithAlgorithm(string name, string urlalgorithm, string transitMountPath, TransitGenerateHmacWithAlgorithmRequest transitGenerateHmacWithAlgorithmRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitGenerateHmacWithAlgorithm: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The key to use for the HMAC function | 
 **urlalgorithm** | **string**| Algorithm to use (POST URL parameter) | 
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitGenerateHmacWithAlgorithmRequest** | [**TransitGenerateHmacWithAlgorithmRequest**](TransitGenerateHmacWithAlgorithmRequest.md)|  | 


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


<a name="transitgeneraterandom"></a>
# **TransitGenerateRandom**

> void TransitGenerateRandom (string transitMountPath, TransitGenerateRandomRequest transitGenerateRandomRequest, TimeSpan? wrapTTL = null)

Generate random bytes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitGenerateRandomExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitGenerateRandomRequest = new TransitGenerateRandomRequest(); // TransitGenerateRandomRequest | 
            
            

            try
            {
                
                // Generate random bytes
                

                apiInstance.TransitGenerateRandom(string transitMountPath, TransitGenerateRandomRequest transitGenerateRandomRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitGenerateRandom: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitGenerateRandomRequest** | [**TransitGenerateRandomRequest**](TransitGenerateRandomRequest.md)|  | 


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


<a name="transitgeneraterandomwithbytes"></a>
# **TransitGenerateRandomWithBytes**

> void TransitGenerateRandomWithBytes (string urlbytes, string transitMountPath, TransitGenerateRandomWithBytesRequest transitGenerateRandomWithBytesRequest, TimeSpan? wrapTTL = null)

Generate random bytes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitGenerateRandomWithBytesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var urlbytes = "urlbytes_example";  // string | The number of bytes to generate (POST URL parameter)
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitGenerateRandomWithBytesRequest = new TransitGenerateRandomWithBytesRequest(); // TransitGenerateRandomWithBytesRequest | 
            
            

            try
            {
                
                // Generate random bytes
                

                apiInstance.TransitGenerateRandomWithBytes(string urlbytes, string transitMountPath, TransitGenerateRandomWithBytesRequest transitGenerateRandomWithBytesRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitGenerateRandomWithBytes: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **urlbytes** | **string**| The number of bytes to generate (POST URL parameter) | 
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitGenerateRandomWithBytesRequest** | [**TransitGenerateRandomWithBytesRequest**](TransitGenerateRandomWithBytesRequest.md)|  | 


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


<a name="transitgeneraterandomwithsource"></a>
# **TransitGenerateRandomWithSource**

> void TransitGenerateRandomWithSource (string source, string transitMountPath, TransitGenerateRandomWithSourceRequest transitGenerateRandomWithSourceRequest, TimeSpan? wrapTTL = null)

Generate random bytes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitGenerateRandomWithSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var source = "\"platform\"";  // string | Which system to source random data from, ether \"platform\", \"seal\", or \"all\". (default to "platform")
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitGenerateRandomWithSourceRequest = new TransitGenerateRandomWithSourceRequest(); // TransitGenerateRandomWithSourceRequest | 
            
            

            try
            {
                
                // Generate random bytes
                

                apiInstance.TransitGenerateRandomWithSource(string source, string transitMountPath, TransitGenerateRandomWithSourceRequest transitGenerateRandomWithSourceRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitGenerateRandomWithSource: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **source** | **string**| Which system to source random data from, ether \&quot;platform\&quot;, \&quot;seal\&quot;, or \&quot;all\&quot;. | [default to &quot;platform&quot;]
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitGenerateRandomWithSourceRequest** | [**TransitGenerateRandomWithSourceRequest**](TransitGenerateRandomWithSourceRequest.md)|  | 


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


<a name="transitgeneraterandomwithsourceandbytes"></a>
# **TransitGenerateRandomWithSourceAndBytes**

> void TransitGenerateRandomWithSourceAndBytes (string source, string urlbytes, string transitMountPath, TransitGenerateRandomWithSourceAndBytesRequest transitGenerateRandomWithSourceAndBytesRequest, TimeSpan? wrapTTL = null)

Generate random bytes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitGenerateRandomWithSourceAndBytesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var source = "\"platform\"";  // string | Which system to source random data from, ether \"platform\", \"seal\", or \"all\". (default to "platform")
            
            
            
            
            var urlbytes = "urlbytes_example";  // string | The number of bytes to generate (POST URL parameter)
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitGenerateRandomWithSourceAndBytesRequest = new TransitGenerateRandomWithSourceAndBytesRequest(); // TransitGenerateRandomWithSourceAndBytesRequest | 
            
            

            try
            {
                
                // Generate random bytes
                

                apiInstance.TransitGenerateRandomWithSourceAndBytes(string source, string urlbytes, string transitMountPath, TransitGenerateRandomWithSourceAndBytesRequest transitGenerateRandomWithSourceAndBytesRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitGenerateRandomWithSourceAndBytes: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **source** | **string**| Which system to source random data from, ether \&quot;platform\&quot;, \&quot;seal\&quot;, or \&quot;all\&quot;. | [default to &quot;platform&quot;]
 **urlbytes** | **string**| The number of bytes to generate (POST URL parameter) | 
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitGenerateRandomWithSourceAndBytesRequest** | [**TransitGenerateRandomWithSourceAndBytesRequest**](TransitGenerateRandomWithSourceAndBytesRequest.md)|  | 


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


<a name="transithash"></a>
# **TransitHash**

> void TransitHash (string transitMountPath, TransitHashRequest transitHashRequest, TimeSpan? wrapTTL = null)

Generate a hash sum for input data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitHashExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitHashRequest = new TransitHashRequest(); // TransitHashRequest | 
            
            

            try
            {
                
                // Generate a hash sum for input data
                

                apiInstance.TransitHash(string transitMountPath, TransitHashRequest transitHashRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitHash: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitHashRequest** | [**TransitHashRequest**](TransitHashRequest.md)|  | 


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


<a name="transithashwithalgorithm"></a>
# **TransitHashWithAlgorithm**

> void TransitHashWithAlgorithm (string urlalgorithm, string transitMountPath, TransitHashWithAlgorithmRequest transitHashWithAlgorithmRequest, TimeSpan? wrapTTL = null)

Generate a hash sum for input data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitHashWithAlgorithmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var urlalgorithm = "urlalgorithm_example";  // string | Algorithm to use (POST URL parameter)
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitHashWithAlgorithmRequest = new TransitHashWithAlgorithmRequest(); // TransitHashWithAlgorithmRequest | 
            
            

            try
            {
                
                // Generate a hash sum for input data
                

                apiInstance.TransitHashWithAlgorithm(string urlalgorithm, string transitMountPath, TransitHashWithAlgorithmRequest transitHashWithAlgorithmRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitHashWithAlgorithm: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **urlalgorithm** | **string**| Algorithm to use (POST URL parameter) | 
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitHashWithAlgorithmRequest** | [**TransitHashWithAlgorithmRequest**](TransitHashWithAlgorithmRequest.md)|  | 


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


<a name="transitimportkey"></a>
# **TransitImportKey**

> void TransitImportKey (string name, string transitMountPath, TransitImportKeyRequest transitImportKeyRequest, TimeSpan? wrapTTL = null)

Imports an externally-generated key into a new transit key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitImportKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | The name of the key
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitImportKeyRequest = new TransitImportKeyRequest(); // TransitImportKeyRequest | 
            
            

            try
            {
                
                // Imports an externally-generated key into a new transit key
                

                apiInstance.TransitImportKey(string name, string transitMountPath, TransitImportKeyRequest transitImportKeyRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitImportKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the key | 
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitImportKeyRequest** | [**TransitImportKeyRequest**](TransitImportKeyRequest.md)|  | 


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


<a name="transitimportkeyversion"></a>
# **TransitImportKeyVersion**

> void TransitImportKeyVersion (string name, string transitMountPath, TransitImportKeyVersionRequest transitImportKeyVersionRequest, TimeSpan? wrapTTL = null)

Imports an externally-generated key into an existing imported key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitImportKeyVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | The name of the key
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitImportKeyVersionRequest = new TransitImportKeyVersionRequest(); // TransitImportKeyVersionRequest | 
            
            

            try
            {
                
                // Imports an externally-generated key into an existing imported key
                

                apiInstance.TransitImportKeyVersion(string name, string transitMountPath, TransitImportKeyVersionRequest transitImportKeyVersionRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitImportKeyVersion: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the key | 
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitImportKeyVersionRequest** | [**TransitImportKeyVersionRequest**](TransitImportKeyVersionRequest.md)|  | 


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


<a name="transitlistkeys"></a>
# **TransitListKeys**

> void TransitListKeys (string transitMountPath, TimeSpan? wrapTTL = null)

Managed named encryption keys

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitListKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // Managed named encryption keys
                

                apiInstance.TransitListKeys(string transitMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitListKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
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


<a name="transitreadcacheconfiguration"></a>
# **TransitReadCacheConfiguration**

> void TransitReadCacheConfiguration (string transitMountPath, TimeSpan? wrapTTL = null)

Returns the size of the active cache

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitReadCacheConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            

            try
            {
                
                // Returns the size of the active cache
                

                apiInstance.TransitReadCacheConfiguration(string transitMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitReadCacheConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="transitreadkey"></a>
# **TransitReadKey**

> void TransitReadKey (string name, string transitMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitReadKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the key
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            

            try
            {
                

                apiInstance.TransitReadKey(string name, string transitMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitReadKey: " + e.Message );
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
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="transitreadkeysconfiguration"></a>
# **TransitReadKeysConfiguration**

> void TransitReadKeysConfiguration (string transitMountPath, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitReadKeysConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            

            try
            {
                

                apiInstance.TransitReadKeysConfiguration(string transitMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitReadKeysConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="transitreadwrappingkey"></a>
# **TransitReadWrappingKey**

> void TransitReadWrappingKey (string transitMountPath, TimeSpan? wrapTTL = null)

Returns the public key to use for wrapping imported keys

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitReadWrappingKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            

            try
            {
                
                // Returns the public key to use for wrapping imported keys
                

                apiInstance.TransitReadWrappingKey(string transitMountPath, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitReadWrappingKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


<a name="transitrestoreandrenamekey"></a>
# **TransitRestoreAndRenameKey**

> void TransitRestoreAndRenameKey (string name, string transitMountPath, TransitRestoreAndRenameKeyRequest transitRestoreAndRenameKeyRequest, TimeSpan? wrapTTL = null)

Restore the named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitRestoreAndRenameKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | If set, this will be the name of the restored key.
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitRestoreAndRenameKeyRequest = new TransitRestoreAndRenameKeyRequest(); // TransitRestoreAndRenameKeyRequest | 
            
            

            try
            {
                
                // Restore the named key
                

                apiInstance.TransitRestoreAndRenameKey(string name, string transitMountPath, TransitRestoreAndRenameKeyRequest transitRestoreAndRenameKeyRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitRestoreAndRenameKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| If set, this will be the name of the restored key. | 
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitRestoreAndRenameKeyRequest** | [**TransitRestoreAndRenameKeyRequest**](TransitRestoreAndRenameKeyRequest.md)|  | 


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


<a name="transitrestorekey"></a>
# **TransitRestoreKey**

> void TransitRestoreKey (string transitMountPath, TransitRestoreKeyRequest transitRestoreKeyRequest, TimeSpan? wrapTTL = null)

Restore the named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitRestoreKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitRestoreKeyRequest = new TransitRestoreKeyRequest(); // TransitRestoreKeyRequest | 
            
            

            try
            {
                
                // Restore the named key
                

                apiInstance.TransitRestoreKey(string transitMountPath, TransitRestoreKeyRequest transitRestoreKeyRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitRestoreKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitRestoreKeyRequest** | [**TransitRestoreKeyRequest**](TransitRestoreKeyRequest.md)|  | 


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


<a name="transitrewrap"></a>
# **TransitRewrap**

> void TransitRewrap (string name, string transitMountPath, TransitRewrapRequest transitRewrapRequest, TimeSpan? wrapTTL = null)

Rewrap ciphertext

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitRewrapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the key
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitRewrapRequest = new TransitRewrapRequest(); // TransitRewrapRequest | 
            
            

            try
            {
                
                // Rewrap ciphertext
                

                apiInstance.TransitRewrap(string name, string transitMountPath, TransitRewrapRequest transitRewrapRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitRewrap: " + e.Message );
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
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitRewrapRequest** | [**TransitRewrapRequest**](TransitRewrapRequest.md)|  | 


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


<a name="transitrotatekey"></a>
# **TransitRotateKey**

> void TransitRotateKey (string name, string transitMountPath, TransitRotateKeyRequest transitRotateKeyRequest, TimeSpan? wrapTTL = null)

Rotate named encryption key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitRotateKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the key
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitRotateKeyRequest = new TransitRotateKeyRequest(); // TransitRotateKeyRequest | 
            
            

            try
            {
                
                // Rotate named encryption key
                

                apiInstance.TransitRotateKey(string name, string transitMountPath, TransitRotateKeyRequest transitRotateKeyRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitRotateKey: " + e.Message );
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
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitRotateKeyRequest** | [**TransitRotateKeyRequest**](TransitRotateKeyRequest.md)|  | 


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


<a name="transitsign"></a>
# **TransitSign**

> void TransitSign (string name, string transitMountPath, TransitSignRequest transitSignRequest, TimeSpan? wrapTTL = null)

Generate a signature for input data using the named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitSignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | The key to use
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitSignRequest = new TransitSignRequest(); // TransitSignRequest | 
            
            

            try
            {
                
                // Generate a signature for input data using the named key
                

                apiInstance.TransitSign(string name, string transitMountPath, TransitSignRequest transitSignRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitSign: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The key to use | 
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitSignRequest** | [**TransitSignRequest**](TransitSignRequest.md)|  | 


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


<a name="transitsignwithalgorithm"></a>
# **TransitSignWithAlgorithm**

> void TransitSignWithAlgorithm (string name, string urlalgorithm, string transitMountPath, TransitSignWithAlgorithmRequest transitSignWithAlgorithmRequest, TimeSpan? wrapTTL = null)

Generate a signature for input data using the named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitSignWithAlgorithmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | The key to use
            
            
            
            
            var urlalgorithm = "urlalgorithm_example";  // string | Hash algorithm to use (POST URL parameter)
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitSignWithAlgorithmRequest = new TransitSignWithAlgorithmRequest(); // TransitSignWithAlgorithmRequest | 
            
            

            try
            {
                
                // Generate a signature for input data using the named key
                

                apiInstance.TransitSignWithAlgorithm(string name, string urlalgorithm, string transitMountPath, TransitSignWithAlgorithmRequest transitSignWithAlgorithmRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitSignWithAlgorithm: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The key to use | 
 **urlalgorithm** | **string**| Hash algorithm to use (POST URL parameter) | 
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitSignWithAlgorithmRequest** | [**TransitSignWithAlgorithmRequest**](TransitSignWithAlgorithmRequest.md)|  | 


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


<a name="transittrimkey"></a>
# **TransitTrimKey**

> void TransitTrimKey (string name, string transitMountPath, TransitTrimKeyRequest transitTrimKeyRequest, TimeSpan? wrapTTL = null)

Trim key versions of a named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitTrimKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | Name of the key
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitTrimKeyRequest = new TransitTrimKeyRequest(); // TransitTrimKeyRequest | 
            
            

            try
            {
                
                // Trim key versions of a named key
                

                apiInstance.TransitTrimKey(string name, string transitMountPath, TransitTrimKeyRequest transitTrimKeyRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitTrimKey: " + e.Message );
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
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitTrimKeyRequest** | [**TransitTrimKeyRequest**](TransitTrimKeyRequest.md)|  | 


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


<a name="transitverify"></a>
# **TransitVerify**

> void TransitVerify (string name, string transitMountPath, TransitVerifyRequest transitVerifyRequest, TimeSpan? wrapTTL = null)

Verify a signature or HMAC for input data created using the named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitVerifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | The key to use
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitVerifyRequest = new TransitVerifyRequest(); // TransitVerifyRequest | 
            
            

            try
            {
                
                // Verify a signature or HMAC for input data created using the named key
                

                apiInstance.TransitVerify(string name, string transitMountPath, TransitVerifyRequest transitVerifyRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitVerify: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The key to use | 
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitVerifyRequest** | [**TransitVerifyRequest**](TransitVerifyRequest.md)|  | 


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


<a name="transitverifywithalgorithm"></a>
# **TransitVerifyWithAlgorithm**

> void TransitVerifyWithAlgorithm (string name, string urlalgorithm, string transitMountPath, TransitVerifyWithAlgorithmRequest transitVerifyWithAlgorithmRequest, TimeSpan? wrapTTL = null)

Verify a signature or HMAC for input data created using the named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using System.Net.Http;

using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitVerifyWithAlgorithmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | The key to use
            
            
            
            
            var urlalgorithm = "urlalgorithm_example";  // string | Hash algorithm to use (POST URL parameter)
            
            
            
            
            var transitMountPath = "\"transit\"";  // string | Path that the backend was mounted at (default to "transit")
            
            
            
            
            
            var transitVerifyWithAlgorithmRequest = new TransitVerifyWithAlgorithmRequest(); // TransitVerifyWithAlgorithmRequest | 
            
            

            try
            {
                
                // Verify a signature or HMAC for input data created using the named key
                

                apiInstance.TransitVerifyWithAlgorithm(string name, string urlalgorithm, string transitMountPath, TransitVerifyWithAlgorithmRequest transitVerifyWithAlgorithmRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitVerifyWithAlgorithm: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The key to use | 
 **urlalgorithm** | **string**| Hash algorithm to use (POST URL parameter) | 
 **transitMountPath** | **string**| Path that the backend was mounted at | [default to &quot;transit&quot;]
 **transitVerifyWithAlgorithmRequest** | [**TransitVerifyWithAlgorithmRequest**](TransitVerifyWithAlgorithmRequest.md)|  | 


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


