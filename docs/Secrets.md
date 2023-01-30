# Vault.Api.Secrets

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AWSConfigReadLease**](Secrets.md#awsconfigreadlease) | **GET** /{aws_mount_path}/config/lease | Configure the default lease information for generated credentials.
[**AWSConfigReadRootIAMCredentials**](Secrets.md#awsconfigreadrootiamcredentials) | **GET** /{aws_mount_path}/config/root | Configure the root credentials that are used to manage IAM.
[**AWSConfigRotateRootIAMCredentials**](Secrets.md#awsconfigrotaterootiamcredentials) | **POST** /{aws_mount_path}/config/rotate-root | 
[**AWSConfigWriteLease**](Secrets.md#awsconfigwritelease) | **POST** /{aws_mount_path}/config/lease | Configure the default lease information for generated credentials.
[**AWSConfigWriteRootIAMCredentials**](Secrets.md#awsconfigwriterootiamcredentials) | **POST** /{aws_mount_path}/config/root | Configure the root credentials that are used to manage IAM.
[**AWSDeleteRole**](Secrets.md#awsdeleterole) | **DELETE** /{aws_mount_path}/roles/{name} | Read, write and reference IAM policies that access keys can be made for.
[**AWSListRoles**](Secrets.md#awslistroles) | **GET** /{aws_mount_path}/roles | List the existing roles in this backend
[**AWSReadCredentials**](Secrets.md#awsreadcredentials) | **GET** /{aws_mount_path}/creds | Generate AWS credentials from a specific Vault role.
[**AWSReadRole**](Secrets.md#awsreadrole) | **GET** /{aws_mount_path}/roles/{name} | Read, write and reference IAM policies that access keys can be made for.
[**AWSReadSecurityTokenService**](Secrets.md#awsreadsecuritytokenservice) | **GET** /{aws_mount_path}/sts/{name} | Generate AWS credentials from a specific Vault role.
[**AWSWriteCredentials**](Secrets.md#awswritecredentials) | **POST** /{aws_mount_path}/creds | Generate AWS credentials from a specific Vault role.
[**AWSWriteRole**](Secrets.md#awswriterole) | **POST** /{aws_mount_path}/roles/{name} | Read, write and reference IAM policies that access keys can be made for.
[**AWSWriteSecurityTokenService**](Secrets.md#awswritesecuritytokenservice) | **POST** /{aws_mount_path}/sts/{name} | Generate AWS credentials from a specific Vault role.
[**ActiveDirectoryCheckInLibrary**](Secrets.md#activedirectorycheckinlibrary) | **POST** /{ad_mount_path}/library/{name}/check-in | Check service accounts in to the library.
[**ActiveDirectoryCheckInManageLibrary**](Secrets.md#activedirectorycheckinmanagelibrary) | **POST** /{ad_mount_path}/library/manage/{name}/check-in | Check service accounts in to the library.
[**ActiveDirectoryCheckOutLibrary**](Secrets.md#activedirectorycheckoutlibrary) | **POST** /{ad_mount_path}/library/{name}/check-out | Check a service account out from the library.
[**ActiveDirectoryDeleteConfig**](Secrets.md#activedirectorydeleteconfig) | **DELETE** /{ad_mount_path}/config | Configure the AD server to connect to, along with password options.
[**ActiveDirectoryDeleteLibrary**](Secrets.md#activedirectorydeletelibrary) | **DELETE** /{ad_mount_path}/library/{name} | Delete a library set.
[**ActiveDirectoryDeleteRole**](Secrets.md#activedirectorydeleterole) | **DELETE** /{ad_mount_path}/roles/{name} | Manage roles to build links between Vault and Active Directory service accounts.
[**ActiveDirectoryListLibraries**](Secrets.md#activedirectorylistlibraries) | **GET** /{ad_mount_path}/library | 
[**ActiveDirectoryListRoles**](Secrets.md#activedirectorylistroles) | **GET** /{ad_mount_path}/roles | List the name of each role currently stored.
[**ActiveDirectoryReadConfig**](Secrets.md#activedirectoryreadconfig) | **GET** /{ad_mount_path}/config | Configure the AD server to connect to, along with password options.
[**ActiveDirectoryReadCredentials**](Secrets.md#activedirectoryreadcredentials) | **GET** /{ad_mount_path}/creds/{name} | 
[**ActiveDirectoryReadLibrary**](Secrets.md#activedirectoryreadlibrary) | **GET** /{ad_mount_path}/library/{name} | Read a library set.
[**ActiveDirectoryReadLibraryStatus**](Secrets.md#activedirectoryreadlibrarystatus) | **GET** /{ad_mount_path}/library/{name}/status | Check the status of the service accounts in a library set.
[**ActiveDirectoryReadRole**](Secrets.md#activedirectoryreadrole) | **GET** /{ad_mount_path}/roles/{name} | Manage roles to build links between Vault and Active Directory service accounts.
[**ActiveDirectoryRotateRole**](Secrets.md#activedirectoryrotaterole) | **POST** /{ad_mount_path}/rotate-role/{name} | 
[**ActiveDirectoryRotateRoot**](Secrets.md#activedirectoryrotateroot) | **POST** /{ad_mount_path}/rotate-root | 
[**ActiveDirectoryWriteConfig**](Secrets.md#activedirectorywriteconfig) | **POST** /{ad_mount_path}/config | Configure the AD server to connect to, along with password options.
[**ActiveDirectoryWriteLibrary**](Secrets.md#activedirectorywritelibrary) | **POST** /{ad_mount_path}/library/{name} | Update a library set.
[**ActiveDirectoryWriteRole**](Secrets.md#activedirectorywriterole) | **POST** /{ad_mount_path}/roles/{name} | Manage roles to build links between Vault and Active Directory service accounts.
[**AliCloudDeleteConfig**](Secrets.md#aliclouddeleteconfig) | **DELETE** /{alicloud_mount_path}/config | Configure the access key and secret to use for RAM and STS calls.
[**AliCloudDeleteRole**](Secrets.md#aliclouddeleterole) | **DELETE** /{alicloud_mount_path}/role/{name} | Read, write and reference policies and roles that API keys or STS credentials can be made for.
[**AliCloudListRoles**](Secrets.md#alicloudlistroles) | **GET** /{alicloud_mount_path}/role | List the existing roles in this backend.
[**AliCloudReadConfig**](Secrets.md#alicloudreadconfig) | **GET** /{alicloud_mount_path}/config | Configure the access key and secret to use for RAM and STS calls.
[**AliCloudReadCredentials**](Secrets.md#alicloudreadcredentials) | **GET** /{alicloud_mount_path}/creds/{name} | Generate an API key or STS credential using the given role&#39;s configuration.&#39;
[**AliCloudReadRole**](Secrets.md#alicloudreadrole) | **GET** /{alicloud_mount_path}/role/{name} | Read, write and reference policies and roles that API keys or STS credentials can be made for.
[**AliCloudWriteConfig**](Secrets.md#alicloudwriteconfig) | **POST** /{alicloud_mount_path}/config | Configure the access key and secret to use for RAM and STS calls.
[**AliCloudWriteRole**](Secrets.md#alicloudwriterole) | **POST** /{alicloud_mount_path}/role/{name} | Read, write and reference policies and roles that API keys or STS credentials can be made for.
[**AzureDeleteConfig**](Secrets.md#azuredeleteconfig) | **DELETE** /{azure_mount_path}/config | 
[**AzureDeleteRole**](Secrets.md#azuredeleterole) | **DELETE** /{azure_mount_path}/roles/{name} | Manage the Vault roles used to generate Azure credentials.
[**AzureListRoles**](Secrets.md#azurelistroles) | **GET** /{azure_mount_path}/roles | List existing roles.
[**AzureReadConfig**](Secrets.md#azurereadconfig) | **GET** /{azure_mount_path}/config | 
[**AzureReadCredentials**](Secrets.md#azurereadcredentials) | **GET** /{azure_mount_path}/creds/{role} | 
[**AzureReadRole**](Secrets.md#azurereadrole) | **GET** /{azure_mount_path}/roles/{name} | Manage the Vault roles used to generate Azure credentials.
[**AzureRotateRoot**](Secrets.md#azurerotateroot) | **POST** /{azure_mount_path}/rotate-root | 
[**AzureWriteConfig**](Secrets.md#azurewriteconfig) | **POST** /{azure_mount_path}/config | 
[**AzureWriteRole**](Secrets.md#azurewriterole) | **POST** /{azure_mount_path}/roles/{name} | Manage the Vault roles used to generate Azure credentials.
[**ConsulDeleteRole**](Secrets.md#consuldeleterole) | **DELETE** /{consul_mount_path}/roles/{name} | 
[**ConsulListRoles**](Secrets.md#consullistroles) | **GET** /{consul_mount_path}/roles | 
[**ConsulReadAccessConfig**](Secrets.md#consulreadaccessconfig) | **GET** /{consul_mount_path}/config/access | 
[**ConsulReadCredentials**](Secrets.md#consulreadcredentials) | **GET** /{consul_mount_path}/creds/{role} | 
[**ConsulReadRole**](Secrets.md#consulreadrole) | **GET** /{consul_mount_path}/roles/{name} | 
[**ConsulWriteAccessConfig**](Secrets.md#consulwriteaccessconfig) | **POST** /{consul_mount_path}/config/access | 
[**ConsulWriteRole**](Secrets.md#consulwriterole) | **POST** /{consul_mount_path}/roles/{name} | 
[**CubbyholeDelete**](Secrets.md#cubbyholedelete) | **DELETE** /{cubbyhole_mount_path}/{path} | Deletes the secret at the specified location.
[**CubbyholeRead**](Secrets.md#cubbyholeread) | **GET** /{cubbyhole_mount_path}/{path} | Retrieve the secret at the specified location.
[**CubbyholeWrite**](Secrets.md#cubbyholewrite) | **POST** /{cubbyhole_mount_path}/{path} | Store a secret at the specified location.
[**GoogleCloudDeleteRoleset**](Secrets.md#googleclouddeleteroleset) | **DELETE** /{gcp_mount_path}/roleset/{name} | 
[**GoogleCloudDeleteStaticAccount**](Secrets.md#googleclouddeletestaticaccount) | **DELETE** /{gcp_mount_path}/static-account/{name} | 
[**GoogleCloudKMSDecrypt**](Secrets.md#googlecloudkmsdecrypt) | **POST** /{gcpkms_mount_path}/decrypt/{key} | Decrypt a ciphertext value using a named key
[**GoogleCloudKMSDeleteConfig**](Secrets.md#googlecloudkmsdeleteconfig) | **DELETE** /{gcpkms_mount_path}/config | Configure the GCP KMS secrets engine
[**GoogleCloudKMSDeleteKey**](Secrets.md#googlecloudkmsdeletekey) | **DELETE** /{gcpkms_mount_path}/keys/{key} | Interact with crypto keys in Vault and Google Cloud KMS
[**GoogleCloudKMSDeregisterKey**](Secrets.md#googlecloudkmsderegisterkey) | **POST** /{gcpkms_mount_path}/keys/deregister/{key} | Deregister an existing key in Vault
[**GoogleCloudKMSEncrypt**](Secrets.md#googlecloudkmsencrypt) | **POST** /{gcpkms_mount_path}/encrypt/{key} | Encrypt a plaintext value using a named key
[**GoogleCloudKMSListKeys**](Secrets.md#googlecloudkmslistkeys) | **GET** /{gcpkms_mount_path}/keys | List named keys
[**GoogleCloudKMSReadConfig**](Secrets.md#googlecloudkmsreadconfig) | **GET** /{gcpkms_mount_path}/config | Configure the GCP KMS secrets engine
[**GoogleCloudKMSReadKey**](Secrets.md#googlecloudkmsreadkey) | **GET** /{gcpkms_mount_path}/keys/{key} | Interact with crypto keys in Vault and Google Cloud KMS
[**GoogleCloudKMSReadKeyConfig**](Secrets.md#googlecloudkmsreadkeyconfig) | **GET** /{gcpkms_mount_path}/keys/config/{key} | Configure the key in Vault
[**GoogleCloudKMSReadPubkey**](Secrets.md#googlecloudkmsreadpubkey) | **GET** /{gcpkms_mount_path}/pubkey/{key} | Retrieve the public key associated with the named key
[**GoogleCloudKMSReencrypt**](Secrets.md#googlecloudkmsreencrypt) | **POST** /{gcpkms_mount_path}/reencrypt/{key} | Re-encrypt existing ciphertext data to a new version
[**GoogleCloudKMSRegisterKey**](Secrets.md#googlecloudkmsregisterkey) | **POST** /{gcpkms_mount_path}/keys/register/{key} | Register an existing crypto key in Google Cloud KMS
[**GoogleCloudKMSRotateKey**](Secrets.md#googlecloudkmsrotatekey) | **POST** /{gcpkms_mount_path}/keys/rotate/{key} | Rotate a crypto key to a new primary version
[**GoogleCloudKMSSign**](Secrets.md#googlecloudkmssign) | **POST** /{gcpkms_mount_path}/sign/{key} | Signs a message or digest using a named key
[**GoogleCloudKMSTrimKey**](Secrets.md#googlecloudkmstrimkey) | **POST** /{gcpkms_mount_path}/keys/trim/{key} | Delete old crypto key versions from Google Cloud KMS
[**GoogleCloudKMSVerify**](Secrets.md#googlecloudkmsverify) | **POST** /{gcpkms_mount_path}/verify/{key} | Verify a signature using a named key
[**GoogleCloudKMSWriteConfig**](Secrets.md#googlecloudkmswriteconfig) | **POST** /{gcpkms_mount_path}/config | Configure the GCP KMS secrets engine
[**GoogleCloudKMSWriteKey**](Secrets.md#googlecloudkmswritekey) | **POST** /{gcpkms_mount_path}/keys/{key} | Interact with crypto keys in Vault and Google Cloud KMS
[**GoogleCloudKMSWriteKeyConfig**](Secrets.md#googlecloudkmswritekeyconfig) | **POST** /{gcpkms_mount_path}/keys/config/{key} | Configure the key in Vault
[**GoogleCloudListRolesets**](Secrets.md#googlecloudlistrolesets) | **GET** /{gcp_mount_path}/rolesets | 
[**GoogleCloudListStaticAccounts**](Secrets.md#googlecloudliststaticaccounts) | **GET** /{gcp_mount_path}/static-accounts | 
[**GoogleCloudReadConfig**](Secrets.md#googlecloudreadconfig) | **GET** /{gcp_mount_path}/config | 
[**GoogleCloudReadKey**](Secrets.md#googlecloudreadkey) | **GET** /{gcp_mount_path}/key/{roleset} | 
[**GoogleCloudReadRoleset**](Secrets.md#googlecloudreadroleset) | **GET** /{gcp_mount_path}/roleset/{name} | 
[**GoogleCloudReadRolesetKey**](Secrets.md#googlecloudreadrolesetkey) | **GET** /{gcp_mount_path}/roleset/{roleset}/key | 
[**GoogleCloudReadRolesetToken**](Secrets.md#googlecloudreadrolesettoken) | **GET** /{gcp_mount_path}/roleset/{roleset}/token | 
[**GoogleCloudReadStaticAccount**](Secrets.md#googlecloudreadstaticaccount) | **GET** /{gcp_mount_path}/static-account/{name} | 
[**GoogleCloudReadStaticAccountKey**](Secrets.md#googlecloudreadstaticaccountkey) | **GET** /{gcp_mount_path}/static-account/{name}/key | 
[**GoogleCloudReadStaticAccountToken**](Secrets.md#googlecloudreadstaticaccounttoken) | **GET** /{gcp_mount_path}/static-account/{name}/token | 
[**GoogleCloudReadToken**](Secrets.md#googlecloudreadtoken) | **GET** /{gcp_mount_path}/token/{roleset} | 
[**GoogleCloudRotateRoleset**](Secrets.md#googlecloudrotateroleset) | **POST** /{gcp_mount_path}/roleset/{name}/rotate | 
[**GoogleCloudRotateRolesetKey**](Secrets.md#googlecloudrotaterolesetkey) | **POST** /{gcp_mount_path}/roleset/{name}/rotate-key | 
[**GoogleCloudRotateRoot**](Secrets.md#googlecloudrotateroot) | **POST** /{gcp_mount_path}/config/rotate-root | 
[**GoogleCloudRotateStaticAccountKey**](Secrets.md#googlecloudrotatestaticaccountkey) | **POST** /{gcp_mount_path}/static-account/{name}/rotate-key | 
[**GoogleCloudWriteConfig**](Secrets.md#googlecloudwriteconfig) | **POST** /{gcp_mount_path}/config | 
[**GoogleCloudWriteKey**](Secrets.md#googlecloudwritekey) | **POST** /{gcp_mount_path}/key/{roleset} | 
[**GoogleCloudWriteRoleset**](Secrets.md#googlecloudwriteroleset) | **POST** /{gcp_mount_path}/roleset/{name} | 
[**GoogleCloudWriteRolesetKey**](Secrets.md#googlecloudwriterolesetkey) | **POST** /{gcp_mount_path}/roleset/{roleset}/key | 
[**GoogleCloudWriteRolesetToken**](Secrets.md#googlecloudwriterolesettoken) | **POST** /{gcp_mount_path}/roleset/{roleset}/token | 
[**GoogleCloudWriteStaticAccount**](Secrets.md#googlecloudwritestaticaccount) | **POST** /{gcp_mount_path}/static-account/{name} | 
[**GoogleCloudWriteStaticAccountKey**](Secrets.md#googlecloudwritestaticaccountkey) | **POST** /{gcp_mount_path}/static-account/{name}/key | 
[**GoogleCloudWriteStaticAccountToken**](Secrets.md#googlecloudwritestaticaccounttoken) | **POST** /{gcp_mount_path}/static-account/{name}/token | 
[**GoogleCloudWriteToken**](Secrets.md#googlecloudwritetoken) | **POST** /{gcp_mount_path}/token/{roleset} | 
[**KVv1Delete**](Secrets.md#kvv1delete) | **DELETE** /{kv_mount_path}/{path} | Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.
[**KVv1Read**](Secrets.md#kvv1read) | **GET** /{kv_mount_path}/{path} | Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.
[**KVv1Write**](Secrets.md#kvv1write) | **POST** /{kv_mount_path}/{path} | Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.
[**KVv2Delete**](Secrets.md#kvv2delete) | **DELETE** /{secret_mount_path}/data/{path} | Write, Patch, Read, and Delete data in the Key-Value Store.
[**KVv2DeleteMetadata**](Secrets.md#kvv2deletemetadata) | **DELETE** /{secret_mount_path}/metadata/{path} | Configures settings for the KV store
[**KVv2DeleteVersions**](Secrets.md#kvv2deleteversions) | **POST** /{secret_mount_path}/delete/{path} | Marks one or more versions as deleted in the KV store.
[**KVv2DestroyVersions**](Secrets.md#kvv2destroyversions) | **POST** /{secret_mount_path}/destroy/{path} | Permanently removes one or more versions in the KV store
[**KVv2Read**](Secrets.md#kvv2read) | **GET** /{secret_mount_path}/data/{path} | Write, Patch, Read, and Delete data in the Key-Value Store.
[**KVv2ReadConfig**](Secrets.md#kvv2readconfig) | **GET** /{secret_mount_path}/config | Read the backend level settings.
[**KVv2ReadMetadata**](Secrets.md#kvv2readmetadata) | **GET** /{secret_mount_path}/metadata/{path} | Configures settings for the KV store
[**KVv2ReadSubkeys**](Secrets.md#kvv2readsubkeys) | **GET** /{secret_mount_path}/subkeys/{path} | Read the structure of a secret entry from the Key-Value store with the values removed.
[**KVv2UndeleteVersions**](Secrets.md#kvv2undeleteversions) | **POST** /{secret_mount_path}/undelete/{path} | Undeletes one or more versions from the KV store.
[**KVv2Write**](Secrets.md#kvv2write) | **POST** /{secret_mount_path}/data/{path} | Write, Patch, Read, and Delete data in the Key-Value Store.
[**KVv2WriteConfig**](Secrets.md#kvv2writeconfig) | **POST** /{secret_mount_path}/config | Configure backend level settings that are applied to every key in the key-value store.
[**KVv2WriteMetadata**](Secrets.md#kvv2writemetadata) | **POST** /{secret_mount_path}/metadata/{path} | Configures settings for the KV store
[**KubernetesDeleteConfig**](Secrets.md#kubernetesdeleteconfig) | **DELETE** /{kubernetes_mount_path}/config | 
[**KubernetesDeleteRole**](Secrets.md#kubernetesdeleterole) | **DELETE** /{kubernetes_mount_path}/roles/{name} | 
[**KubernetesListRoles**](Secrets.md#kuberneteslistroles) | **GET** /{kubernetes_mount_path}/roles | 
[**KubernetesReadConfig**](Secrets.md#kubernetesreadconfig) | **GET** /{kubernetes_mount_path}/config | 
[**KubernetesReadRole**](Secrets.md#kubernetesreadrole) | **GET** /{kubernetes_mount_path}/roles/{name} | 
[**KubernetesWriteConfig**](Secrets.md#kuberneteswriteconfig) | **POST** /{kubernetes_mount_path}/config | 
[**KubernetesWriteCredentials**](Secrets.md#kuberneteswritecredentials) | **POST** /{kubernetes_mount_path}/creds/{name} | 
[**KubernetesWriteRole**](Secrets.md#kuberneteswriterole) | **POST** /{kubernetes_mount_path}/roles/{name} | 
[**LDAPCheckInLibrary**](Secrets.md#ldapcheckinlibrary) | **POST** /{ldap_mount_path}/library/{name}/check-in | Check service accounts in to the library.
[**LDAPCheckInManageLibrary**](Secrets.md#ldapcheckinmanagelibrary) | **POST** /{ldap_mount_path}/library/manage/{name}/check-in | Check service accounts in to the library.
[**LDAPCheckOutLibrary**](Secrets.md#ldapcheckoutlibrary) | **POST** /{ldap_mount_path}/library/{name}/check-out | Check a service account out from the library.
[**LDAPDeleteConfig**](Secrets.md#ldapdeleteconfig) | **DELETE** /{ldap_mount_path}/config | 
[**LDAPDeleteLibrary**](Secrets.md#ldapdeletelibrary) | **DELETE** /{ldap_mount_path}/library/{name} | Delete a library set.
[**LDAPDeleteRole**](Secrets.md#ldapdeleterole) | **DELETE** /{ldap_mount_path}/role/{name} | 
[**LDAPDeleteStaticRole**](Secrets.md#ldapdeletestaticrole) | **DELETE** /{ldap_mount_path}/static-role/{name} | 
[**LDAPListLibraries**](Secrets.md#ldaplistlibraries) | **GET** /{ldap_mount_path}/library | 
[**LDAPListRoles**](Secrets.md#ldaplistroles) | **GET** /{ldap_mount_path}/role | 
[**LDAPListStaticRoles**](Secrets.md#ldapliststaticroles) | **GET** /{ldap_mount_path}/static-role | 
[**LDAPReadConfig**](Secrets.md#ldapreadconfig) | **GET** /{ldap_mount_path}/config | 
[**LDAPReadCredentials**](Secrets.md#ldapreadcredentials) | **GET** /{ldap_mount_path}/creds/{name} | 
[**LDAPReadLibrary**](Secrets.md#ldapreadlibrary) | **GET** /{ldap_mount_path}/library/{name} | Read a library set.
[**LDAPReadLibraryStatus**](Secrets.md#ldapreadlibrarystatus) | **GET** /{ldap_mount_path}/library/{name}/status | Check the status of the service accounts in a library set.
[**LDAPReadRole**](Secrets.md#ldapreadrole) | **GET** /{ldap_mount_path}/role/{name} | 
[**LDAPReadStaticCredentials**](Secrets.md#ldapreadstaticcredentials) | **GET** /{ldap_mount_path}/static-cred/{name} | 
[**LDAPReadStaticRole**](Secrets.md#ldapreadstaticrole) | **GET** /{ldap_mount_path}/static-role/{name} | 
[**LDAPRotateRole**](Secrets.md#ldaprotaterole) | **POST** /{ldap_mount_path}/rotate-role/{name} | 
[**LDAPRotateRoot**](Secrets.md#ldaprotateroot) | **POST** /{ldap_mount_path}/rotate-root | 
[**LDAPWriteConfig**](Secrets.md#ldapwriteconfig) | **POST** /{ldap_mount_path}/config | 
[**LDAPWriteLibrary**](Secrets.md#ldapwritelibrary) | **POST** /{ldap_mount_path}/library/{name} | Update a library set.
[**LDAPWriteRole**](Secrets.md#ldapwriterole) | **POST** /{ldap_mount_path}/role/{name} | 
[**LDAPWriteStaticRole**](Secrets.md#ldapwritestaticrole) | **POST** /{ldap_mount_path}/static-role/{name} | 
[**MongoDBAtlasDeleteRole**](Secrets.md#mongodbatlasdeleterole) | **DELETE** /{mongodbatlas_mount_path}/roles/{name} | Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
[**MongoDBAtlasListRoles**](Secrets.md#mongodbatlaslistroles) | **GET** /{mongodbatlas_mount_path}/roles | List the existing roles in this backend
[**MongoDBAtlasReadConfig**](Secrets.md#mongodbatlasreadconfig) | **GET** /{mongodbatlas_mount_path}/config | Configure the  credentials that are used to manage Database Users.
[**MongoDBAtlasReadCredentials**](Secrets.md#mongodbatlasreadcredentials) | **GET** /{mongodbatlas_mount_path}/creds/{name} | Generate MongoDB Atlas Programmatic API from a specific Vault role.
[**MongoDBAtlasReadRole**](Secrets.md#mongodbatlasreadrole) | **GET** /{mongodbatlas_mount_path}/roles/{name} | Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
[**MongoDBAtlasWriteConfig**](Secrets.md#mongodbatlaswriteconfig) | **POST** /{mongodbatlas_mount_path}/config | Configure the  credentials that are used to manage Database Users.
[**MongoDBAtlasWriteCredentials**](Secrets.md#mongodbatlaswritecredentials) | **POST** /{mongodbatlas_mount_path}/creds/{name} | Generate MongoDB Atlas Programmatic API from a specific Vault role.
[**MongoDBAtlasWriteRole**](Secrets.md#mongodbatlaswriterole) | **POST** /{mongodbatlas_mount_path}/roles/{name} | Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
[**NomadDeleteAccessConfig**](Secrets.md#nomaddeleteaccessconfig) | **DELETE** /{nomad_mount_path}/config/access | 
[**NomadDeleteLeaseConfig**](Secrets.md#nomaddeleteleaseconfig) | **DELETE** /{nomad_mount_path}/config/lease | Configure the lease parameters for generated tokens
[**NomadDeleteRole**](Secrets.md#nomaddeleterole) | **DELETE** /{nomad_mount_path}/role/{name} | 
[**NomadListRoles**](Secrets.md#nomadlistroles) | **GET** /{nomad_mount_path}/role | 
[**NomadReadAccessConfig**](Secrets.md#nomadreadaccessconfig) | **GET** /{nomad_mount_path}/config/access | 
[**NomadReadCredentials**](Secrets.md#nomadreadcredentials) | **GET** /{nomad_mount_path}/creds/{name} | 
[**NomadReadLeaseConfig**](Secrets.md#nomadreadleaseconfig) | **GET** /{nomad_mount_path}/config/lease | Configure the lease parameters for generated tokens
[**NomadReadRole**](Secrets.md#nomadreadrole) | **GET** /{nomad_mount_path}/role/{name} | 
[**NomadWriteAccessConfig**](Secrets.md#nomadwriteaccessconfig) | **POST** /{nomad_mount_path}/config/access | 
[**NomadWriteLeaseConfig**](Secrets.md#nomadwriteleaseconfig) | **POST** /{nomad_mount_path}/config/lease | Configure the lease parameters for generated tokens
[**NomadWriteRole**](Secrets.md#nomadwriterole) | **POST** /{nomad_mount_path}/role/{name} | 
[**OpenLDAPCheckInLibrary**](Secrets.md#openldapcheckinlibrary) | **POST** /{openldap_mount_path}/library/{name}/check-in | Check service accounts in to the library.
[**OpenLDAPCheckInManageLibrary**](Secrets.md#openldapcheckinmanagelibrary) | **POST** /{openldap_mount_path}/library/manage/{name}/check-in | Check service accounts in to the library.
[**OpenLDAPCheckOutLibrary**](Secrets.md#openldapcheckoutlibrary) | **POST** /{openldap_mount_path}/library/{name}/check-out | Check a service account out from the library.
[**OpenLDAPDeleteConfig**](Secrets.md#openldapdeleteconfig) | **DELETE** /{openldap_mount_path}/config | 
[**OpenLDAPDeleteLibrary**](Secrets.md#openldapdeletelibrary) | **DELETE** /{openldap_mount_path}/library/{name} | Delete a library set.
[**OpenLDAPDeleteRole**](Secrets.md#openldapdeleterole) | **DELETE** /{openldap_mount_path}/role/{name} | 
[**OpenLDAPDeleteStaticRole**](Secrets.md#openldapdeletestaticrole) | **DELETE** /{openldap_mount_path}/static-role/{name} | 
[**OpenLDAPListLibraries**](Secrets.md#openldaplistlibraries) | **GET** /{openldap_mount_path}/library | 
[**OpenLDAPListRoles**](Secrets.md#openldaplistroles) | **GET** /{openldap_mount_path}/role | 
[**OpenLDAPListStaticRoles**](Secrets.md#openldapliststaticroles) | **GET** /{openldap_mount_path}/static-role | 
[**OpenLDAPReadConfig**](Secrets.md#openldapreadconfig) | **GET** /{openldap_mount_path}/config | 
[**OpenLDAPReadCredentials**](Secrets.md#openldapreadcredentials) | **GET** /{openldap_mount_path}/creds/{name} | 
[**OpenLDAPReadLibrary**](Secrets.md#openldapreadlibrary) | **GET** /{openldap_mount_path}/library/{name} | Read a library set.
[**OpenLDAPReadLibraryStatus**](Secrets.md#openldapreadlibrarystatus) | **GET** /{openldap_mount_path}/library/{name}/status | Check the status of the service accounts in a library set.
[**OpenLDAPReadRole**](Secrets.md#openldapreadrole) | **GET** /{openldap_mount_path}/role/{name} | 
[**OpenLDAPReadStaticCredentials**](Secrets.md#openldapreadstaticcredentials) | **GET** /{openldap_mount_path}/static-cred/{name} | 
[**OpenLDAPReadStaticRole**](Secrets.md#openldapreadstaticrole) | **GET** /{openldap_mount_path}/static-role/{name} | 
[**OpenLDAPRotateRole**](Secrets.md#openldaprotaterole) | **POST** /{openldap_mount_path}/rotate-role/{name} | 
[**OpenLDAPRotateRoot**](Secrets.md#openldaprotateroot) | **POST** /{openldap_mount_path}/rotate-root | 
[**OpenLDAPWriteConfig**](Secrets.md#openldapwriteconfig) | **POST** /{openldap_mount_path}/config | 
[**OpenLDAPWriteLibrary**](Secrets.md#openldapwritelibrary) | **POST** /{openldap_mount_path}/library/{name} | Update a library set.
[**OpenLDAPWriteRole**](Secrets.md#openldapwriterole) | **POST** /{openldap_mount_path}/role/{name} | 
[**OpenLDAPWriteStaticRole**](Secrets.md#openldapwritestaticrole) | **POST** /{openldap_mount_path}/static-role/{name} | 
[**PKIBundleWrite**](Secrets.md#pkibundlewrite) | **POST** /{pki_mount_path}/bundle | 
[**PKIDeleteKey**](Secrets.md#pkideletekey) | **DELETE** /{pki_mount_path}/key/{key_ref} | 
[**PKIDeleteRole**](Secrets.md#pkideleterole) | **DELETE** /{pki_mount_path}/roles/{name} | 
[**PKIDeleteRoot**](Secrets.md#pkideleteroot) | **DELETE** /{pki_mount_path}/root | 
[**PKIGenerateRoot**](Secrets.md#pkigenerateroot) | **POST** /{pki_mount_path}/root/generate/{exported} | 
[**PKIImportKeys**](Secrets.md#pkiimportkeys) | **POST** /{pki_mount_path}/keys/import | 
[**PKIIssuerIssueRole**](Secrets.md#pkiissuerissuerole) | **POST** /{pki_mount_path}/issuer/{issuer_ref}/issue/{role} | 
[**PKIIssuerResignCRLs**](Secrets.md#pkiissuerresigncrls) | **POST** /{pki_mount_path}/issuer/{issuer_ref}/resign-crls | 
[**PKIIssuerRevoke**](Secrets.md#pkiissuerrevoke) | **POST** /{pki_mount_path}/issuer/{issuer_ref}/revoke | 
[**PKIIssuerSignIntermediate**](Secrets.md#pkiissuersignintermediate) | **POST** /{pki_mount_path}/issuer/{issuer_ref}/sign-intermediate | 
[**PKIIssuerSignRevocationList**](Secrets.md#pkiissuersignrevocationlist) | **POST** /{pki_mount_path}/issuer/{issuer_ref}/sign-revocation-list | 
[**PKIIssuerSignRole**](Secrets.md#pkiissuersignrole) | **POST** /{pki_mount_path}/issuer/{issuer_ref}/sign/{role} | 
[**PKIIssuerSignSelfIssued**](Secrets.md#pkiissuersignselfissued) | **POST** /{pki_mount_path}/issuer/{issuer_ref}/sign-self-issued | 
[**PKIIssuerSignVerbatim**](Secrets.md#pkiissuersignverbatim) | **POST** /{pki_mount_path}/issuer/{issuer_ref}/sign-verbatim | 
[**PKIIssuerSignVerbatimRole**](Secrets.md#pkiissuersignverbatimrole) | **POST** /{pki_mount_path}/issuer/{issuer_ref}/sign-verbatim/{role} | 
[**PKIIssuersGenerateIntermediate**](Secrets.md#pkiissuersgenerateintermediate) | **POST** /{pki_mount_path}/issuers/generate/intermediate/{exported} | 
[**PKIIssuersGenerateRoot**](Secrets.md#pkiissuersgenerateroot) | **POST** /{pki_mount_path}/issuers/generate/root/{exported} | 
[**PKIIssuersList**](Secrets.md#pkiissuerslist) | **GET** /{pki_mount_path}/issuers | 
[**PKIListCerts**](Secrets.md#pkilistcerts) | **GET** /{pki_mount_path}/certs | 
[**PKIListCertsRevoked**](Secrets.md#pkilistcertsrevoked) | **GET** /{pki_mount_path}/certs/revoked | 
[**PKIListKeys**](Secrets.md#pkilistkeys) | **GET** /{pki_mount_path}/keys | 
[**PKIListRoles**](Secrets.md#pkilistroles) | **GET** /{pki_mount_path}/roles | 
[**PKIReadAutoTidyConfig**](Secrets.md#pkireadautotidyconfig) | **GET** /{pki_mount_path}/config/auto-tidy | 
[**PKIReadCA**](Secrets.md#pkireadca) | **GET** /{pki_mount_path}/ca | 
[**PKIReadCAChain**](Secrets.md#pkireadcachain) | **GET** /{pki_mount_path}/ca_chain | 
[**PKIReadCAPem**](Secrets.md#pkireadcapem) | **GET** /{pki_mount_path}/ca/pem | 
[**PKIReadCRL**](Secrets.md#pkireadcrl) | **GET** /{pki_mount_path}/crl | 
[**PKIReadCRLConfig**](Secrets.md#pkireadcrlconfig) | **GET** /{pki_mount_path}/config/crl | 
[**PKIReadCRLRotate**](Secrets.md#pkireadcrlrotate) | **GET** /{pki_mount_path}/crl/rotate | 
[**PKIReadCRLRotateDelta**](Secrets.md#pkireadcrlrotatedelta) | **GET** /{pki_mount_path}/crl/rotate-delta | 
[**PKIReadCert**](Secrets.md#pkireadcert) | **GET** /{pki_mount_path}/cert/{serial} | 
[**PKIReadCertCAChain**](Secrets.md#pkireadcertcachain) | **GET** /{pki_mount_path}/cert/ca_chain | 
[**PKIReadCertRaw**](Secrets.md#pkireadcertraw) | **GET** /{pki_mount_path}/cert/{serial}/raw | 
[**PKIReadCertRawPem**](Secrets.md#pkireadcertrawpem) | **GET** /{pki_mount_path}/cert/{serial}/raw/pem | 
[**PKIReadClusterConfig**](Secrets.md#pkireadclusterconfig) | **GET** /{pki_mount_path}/config/cluster | 
[**PKIReadDeltaCRL**](Secrets.md#pkireaddeltacrl) | **GET** /{pki_mount_path}/delta-crl | 
[**PKIReadIssuersConfig**](Secrets.md#pkireadissuersconfig) | **GET** /{pki_mount_path}/config/issuers | 
[**PKIReadKey**](Secrets.md#pkireadkey) | **GET** /{pki_mount_path}/key/{key_ref} | 
[**PKIReadKeysConfig**](Secrets.md#pkireadkeysconfig) | **GET** /{pki_mount_path}/config/keys | 
[**PKIReadOCSPReq**](Secrets.md#pkireadocspreq) | **GET** /{pki_mount_path}/ocsp/{req} | 
[**PKIReadRole**](Secrets.md#pkireadrole) | **GET** /{pki_mount_path}/roles/{name} | 
[**PKIReadURLConfig**](Secrets.md#pkireadurlconfig) | **GET** /{pki_mount_path}/config/urls | 
[**PKIReplaceRoot**](Secrets.md#pkireplaceroot) | **POST** /{pki_mount_path}/root/replace | 
[**PKIRevoke**](Secrets.md#pkirevoke) | **POST** /{pki_mount_path}/revoke | 
[**PKIRevokeWithKey**](Secrets.md#pkirevokewithkey) | **POST** /{pki_mount_path}/revoke-with-key | 
[**PKIRootSignIntermediate**](Secrets.md#pkirootsignintermediate) | **POST** /{pki_mount_path}/root/sign-intermediate | 
[**PKIRootSignSelfIssued**](Secrets.md#pkirootsignselfissued) | **POST** /{pki_mount_path}/root/sign-self-issued | 
[**PKIRotateRoot**](Secrets.md#pkirotateroot) | **POST** /{pki_mount_path}/root/rotate/{exported} | 
[**PKISignRole**](Secrets.md#pkisignrole) | **POST** /{pki_mount_path}/sign/{role} | 
[**PKISignVerbatim**](Secrets.md#pkisignverbatim) | **POST** /{pki_mount_path}/sign-verbatim | 
[**PKISignVerbatimRole**](Secrets.md#pkisignverbatimrole) | **POST** /{pki_mount_path}/sign-verbatim/{role} | 
[**PKITidy**](Secrets.md#pkitidy) | **POST** /{pki_mount_path}/tidy | 
[**PKITidyCancel**](Secrets.md#pkitidycancel) | **POST** /{pki_mount_path}/tidy-cancel | 
[**PKITidyStatus**](Secrets.md#pkitidystatus) | **GET** /{pki_mount_path}/tidy-status | 
[**PKIWriteAutoTidyConfig**](Secrets.md#pkiwriteautotidyconfig) | **POST** /{pki_mount_path}/config/auto-tidy | 
[**PKIWriteCAConfig**](Secrets.md#pkiwritecaconfig) | **POST** /{pki_mount_path}/config/ca | 
[**PKIWriteCRLConfig**](Secrets.md#pkiwritecrlconfig) | **POST** /{pki_mount_path}/config/crl | 
[**PKIWriteCerts**](Secrets.md#pkiwritecerts) | **POST** /{pki_mount_path}/cert | 
[**PKIWriteClusterConfig**](Secrets.md#pkiwriteclusterconfig) | **POST** /{pki_mount_path}/config/cluster | 
[**PKIWriteIntermediateCrossSign**](Secrets.md#pkiwriteintermediatecrosssign) | **POST** /{pki_mount_path}/intermediate/cross-sign | 
[**PKIWriteIntermediateGenerate**](Secrets.md#pkiwriteintermediategenerate) | **POST** /{pki_mount_path}/intermediate/generate/{exported} | 
[**PKIWriteIntermediateSetSigned**](Secrets.md#pkiwriteintermediatesetsigned) | **POST** /{pki_mount_path}/intermediate/set-signed | 
[**PKIWriteInternalExported**](Secrets.md#pkiwriteinternalexported) | **POST** /{pki_mount_path}/internal|exported | 
[**PKIWriteIssueRole**](Secrets.md#pkiwriteissuerole) | **POST** /{pki_mount_path}/issue/{role} | 
[**PKIWriteIssuersConfig**](Secrets.md#pkiwriteissuersconfig) | **POST** /{pki_mount_path}/config/issuers | 
[**PKIWriteKMS**](Secrets.md#pkiwritekms) | **POST** /{pki_mount_path}/kms | 
[**PKIWriteKey**](Secrets.md#pkiwritekey) | **POST** /{pki_mount_path}/key/{key_ref} | 
[**PKIWriteKeysConfig**](Secrets.md#pkiwritekeysconfig) | **POST** /{pki_mount_path}/config/keys | 
[**PKIWriteOCSP**](Secrets.md#pkiwriteocsp) | **POST** /{pki_mount_path}/ocsp | 
[**PKIWriteRole**](Secrets.md#pkiwriterole) | **POST** /{pki_mount_path}/roles/{name} | 
[**PKIWriteURLConfig**](Secrets.md#pkiwriteurlconfig) | **POST** /{pki_mount_path}/config/urls | 
[**PkiDeleteIssuerRefDerPem**](Secrets.md#pkideleteissuerrefderpem) | **DELETE** /{pki_mount_path}/{issuer_ref}/der|/pem | 
[**PkiDeleteJson**](Secrets.md#pkideletejson) | **DELETE** /{pki_mount_path}//json | 
[**PkiReadDelta**](Secrets.md#pkireaddelta) | **GET** /{pki_mount_path}//delta | 
[**PkiReadDeltaPem**](Secrets.md#pkireaddeltapem) | **GET** /{pki_mount_path}//delta/pem | 
[**PkiReadDer**](Secrets.md#pkireadder) | **GET** /{pki_mount_path}//der | 
[**PkiReadIssuerRefCrlPemDerDeltaPem**](Secrets.md#pkireadissuerrefcrlpemderdeltapem) | **GET** /{pki_mount_path}/{issuer_ref}/crl/pem|/der|/delta/pem | 
[**PkiReadIssuerRefDerPem**](Secrets.md#pkireadissuerrefderpem) | **GET** /{pki_mount_path}/{issuer_ref}/der|/pem | 
[**PkiReadJson**](Secrets.md#pkireadjson) | **GET** /{pki_mount_path}//json | 
[**PkiReadPem**](Secrets.md#pkireadpem) | **GET** /{pki_mount_path}//pem | 
[**PkiWriteIssuerRefDerPem**](Secrets.md#pkiwriteissuerrefderpem) | **POST** /{pki_mount_path}/{issuer_ref}/der|/pem | 
[**PkiWriteJson**](Secrets.md#pkiwritejson) | **POST** /{pki_mount_path}//json | 
[**RabbitMQDeleteRole**](Secrets.md#rabbitmqdeleterole) | **DELETE** /{rabbitmq_mount_path}/roles/{name} | Manage the roles that can be created with this backend.
[**RabbitMQListRoles**](Secrets.md#rabbitmqlistroles) | **GET** /{rabbitmq_mount_path}/roles | Manage the roles that can be created with this backend.
[**RabbitMQReadCredentials**](Secrets.md#rabbitmqreadcredentials) | **GET** /{rabbitmq_mount_path}/creds/{name} | Request RabbitMQ credentials for a certain role.
[**RabbitMQReadLeaseConfig**](Secrets.md#rabbitmqreadleaseconfig) | **GET** /{rabbitmq_mount_path}/config/lease | Configure the lease parameters for generated credentials
[**RabbitMQReadRole**](Secrets.md#rabbitmqreadrole) | **GET** /{rabbitmq_mount_path}/roles/{name} | Manage the roles that can be created with this backend.
[**RabbitMQWriteConnectionConfig**](Secrets.md#rabbitmqwriteconnectionconfig) | **POST** /{rabbitmq_mount_path}/config/connection | Configure the connection URI, username, and password to talk to RabbitMQ management HTTP API.
[**RabbitMQWriteLeaseConfig**](Secrets.md#rabbitmqwriteleaseconfig) | **POST** /{rabbitmq_mount_path}/config/lease | Configure the lease parameters for generated credentials
[**RabbitMQWriteRole**](Secrets.md#rabbitmqwriterole) | **POST** /{rabbitmq_mount_path}/roles/{name} | Manage the roles that can be created with this backend.
[**SSHDeleteCAConfig**](Secrets.md#sshdeletecaconfig) | **DELETE** /{ssh_mount_path}/config/ca | Set the SSH private key used for signing certificates.
[**SSHDeleteKeys**](Secrets.md#sshdeletekeys) | **DELETE** /{ssh_mount_path}/keys/{key_name} | Register a shared private key with Vault.
[**SSHDeleteRole**](Secrets.md#sshdeleterole) | **DELETE** /{ssh_mount_path}/roles/{role} | Manage the &#39;roles&#39; that can be created with this backend.
[**SSHDeleteZeroAddressConfig**](Secrets.md#sshdeletezeroaddressconfig) | **DELETE** /{ssh_mount_path}/config/zeroaddress | Assign zero address as default CIDR block for select roles.
[**SSHListRoles**](Secrets.md#sshlistroles) | **GET** /{ssh_mount_path}/roles | Manage the &#39;roles&#39; that can be created with this backend.
[**SSHLookup**](Secrets.md#sshlookup) | **POST** /{ssh_mount_path}/lookup | List all the roles associated with the given IP address.
[**SSHReadCAConfig**](Secrets.md#sshreadcaconfig) | **GET** /{ssh_mount_path}/config/ca | Set the SSH private key used for signing certificates.
[**SSHReadPublicKey**](Secrets.md#sshreadpublickey) | **GET** /{ssh_mount_path}/public_key | Retrieve the public key.
[**SSHReadRole**](Secrets.md#sshreadrole) | **GET** /{ssh_mount_path}/roles/{role} | Manage the &#39;roles&#39; that can be created with this backend.
[**SSHReadZeroAddressConfig**](Secrets.md#sshreadzeroaddressconfig) | **GET** /{ssh_mount_path}/config/zeroaddress | Assign zero address as default CIDR block for select roles.
[**SSHSign**](Secrets.md#sshsign) | **POST** /{ssh_mount_path}/sign/{role} | Request signing an SSH key using a certain role with the provided details.
[**SSHVerify**](Secrets.md#sshverify) | **POST** /{ssh_mount_path}/verify | Validate the OTP provided by Vault SSH Agent.
[**SSHWriteCAConfig**](Secrets.md#sshwritecaconfig) | **POST** /{ssh_mount_path}/config/ca | Set the SSH private key used for signing certificates.
[**SSHWriteCredentials**](Secrets.md#sshwritecredentials) | **POST** /{ssh_mount_path}/creds/{role} | Creates a credential for establishing SSH connection with the remote host.
[**SSHWriteIssue**](Secrets.md#sshwriteissue) | **POST** /{ssh_mount_path}/issue/{role} | 
[**SSHWriteKeys**](Secrets.md#sshwritekeys) | **POST** /{ssh_mount_path}/keys/{key_name} | Register a shared private key with Vault.
[**SSHWriteRole**](Secrets.md#sshwriterole) | **POST** /{ssh_mount_path}/roles/{role} | Manage the &#39;roles&#39; that can be created with this backend.
[**SSHWriteZeroAddressConfig**](Secrets.md#sshwritezeroaddressconfig) | **POST** /{ssh_mount_path}/config/zeroaddress | Assign zero address as default CIDR block for select roles.
[**TOTPDeleteKey**](Secrets.md#totpdeletekey) | **DELETE** /{totp_mount_path}/keys/{name} | Manage the keys that can be created with this backend.
[**TOTPListKeys**](Secrets.md#totplistkeys) | **GET** /{totp_mount_path}/keys | Manage the keys that can be created with this backend.
[**TOTPReadCode**](Secrets.md#totpreadcode) | **GET** /{totp_mount_path}/code/{name} | Request time-based one-time use password or validate a password for a certain key .
[**TOTPReadKey**](Secrets.md#totpreadkey) | **GET** /{totp_mount_path}/keys/{name} | Manage the keys that can be created with this backend.
[**TOTPWriteCode**](Secrets.md#totpwritecode) | **POST** /{totp_mount_path}/code/{name} | Request time-based one-time use password or validate a password for a certain key .
[**TOTPWriteKey**](Secrets.md#totpwritekey) | **POST** /{totp_mount_path}/keys/{name} | Manage the keys that can be created with this backend.
[**TerraformDeleteConfig**](Secrets.md#terraformdeleteconfig) | **DELETE** /{terraform_mount_path}/config | 
[**TerraformDeleteRole**](Secrets.md#terraformdeleterole) | **DELETE** /{terraform_mount_path}/role/{name} | 
[**TerraformListRoles**](Secrets.md#terraformlistroles) | **GET** /{terraform_mount_path}/role | 
[**TerraformReadConfig**](Secrets.md#terraformreadconfig) | **GET** /{terraform_mount_path}/config | 
[**TerraformReadCredentials**](Secrets.md#terraformreadcredentials) | **GET** /{terraform_mount_path}/creds/{name} | Generate a Terraform Cloud or Enterprise API token from a specific Vault role.
[**TerraformReadRole**](Secrets.md#terraformreadrole) | **GET** /{terraform_mount_path}/role/{name} | 
[**TerraformRotateRole**](Secrets.md#terraformrotaterole) | **POST** /{terraform_mount_path}/rotate-role/{name} | 
[**TerraformWriteConfig**](Secrets.md#terraformwriteconfig) | **POST** /{terraform_mount_path}/config | 
[**TerraformWriteCredentials**](Secrets.md#terraformwritecredentials) | **POST** /{terraform_mount_path}/creds/{name} | Generate a Terraform Cloud or Enterprise API token from a specific Vault role.
[**TerraformWriteRole**](Secrets.md#terraformwriterole) | **POST** /{terraform_mount_path}/role/{name} | 
[**TransitBackup**](Secrets.md#transitbackup) | **GET** /{transit_mount_path}/backup/{name} | Backup the named key
[**TransitDecrypt**](Secrets.md#transitdecrypt) | **POST** /{transit_mount_path}/decrypt/{name} | Decrypt a ciphertext value using a named key
[**TransitDeleteKey**](Secrets.md#transitdeletekey) | **DELETE** /{transit_mount_path}/keys/{name} | Managed named encryption keys
[**TransitEncrypt**](Secrets.md#transitencrypt) | **POST** /{transit_mount_path}/encrypt/{name} | Encrypt a plaintext value or a batch of plaintext blocks using a named key
[**TransitExport**](Secrets.md#transitexport) | **GET** /{transit_mount_path}/export/{type}/{name} | Export named encryption or signing key
[**TransitExportVersion**](Secrets.md#transitexportversion) | **GET** /{transit_mount_path}/export/{type}/{name}/{version} | Export named encryption or signing key
[**TransitGenerateDataKey**](Secrets.md#transitgeneratedatakey) | **POST** /{transit_mount_path}/datakey/{plaintext}/{name} | Generate a data key
[**TransitGenerateHMAC**](Secrets.md#transitgeneratehmac) | **POST** /{transit_mount_path}/hmac/{name} | Generate an HMAC for input data using the named key
[**TransitGenerateHMACWithAlgorithm**](Secrets.md#transitgeneratehmacwithalgorithm) | **POST** /{transit_mount_path}/hmac/{name}/{urlalgorithm} | Generate an HMAC for input data using the named key
[**TransitGenerateRandom**](Secrets.md#transitgeneraterandom) | **POST** /{transit_mount_path}/random | Generate random bytes
[**TransitGenerateRandomSource**](Secrets.md#transitgeneraterandomsource) | **POST** /{transit_mount_path}/random/{source} | Generate random bytes
[**TransitGenerateRandomSourceBytes**](Secrets.md#transitgeneraterandomsourcebytes) | **POST** /{transit_mount_path}/random/{source}/{urlbytes} | Generate random bytes
[**TransitHash**](Secrets.md#transithash) | **POST** /{transit_mount_path}/hash | Generate a hash sum for input data
[**TransitHashWithAlgorithm**](Secrets.md#transithashwithalgorithm) | **POST** /{transit_mount_path}/hash/{urlalgorithm} | Generate a hash sum for input data
[**TransitImportKey**](Secrets.md#transitimportkey) | **POST** /{transit_mount_path}/keys/{name}/import | Imports an externally-generated key into a new transit key
[**TransitImportKeyVersion**](Secrets.md#transitimportkeyversion) | **POST** /{transit_mount_path}/keys/{name}/import_version | Imports an externally-generated key into an existing imported key
[**TransitListKeys**](Secrets.md#transitlistkeys) | **GET** /{transit_mount_path}/keys | Managed named encryption keys
[**TransitReadCacheConfig**](Secrets.md#transitreadcacheconfig) | **GET** /{transit_mount_path}/cache-config | Returns the size of the active cache
[**TransitReadConfigKeys**](Secrets.md#transitreadconfigkeys) | **GET** /{transit_mount_path}/config/keys | Configuration common across all keys
[**TransitReadKey**](Secrets.md#transitreadkey) | **GET** /{transit_mount_path}/keys/{name} | Managed named encryption keys
[**TransitReadWrappingKey**](Secrets.md#transitreadwrappingkey) | **GET** /{transit_mount_path}/wrapping_key | Returns the public key to use for wrapping imported keys
[**TransitRestore**](Secrets.md#transitrestore) | **POST** /{transit_mount_path}/restore | Restore the named key
[**TransitRestoreKey**](Secrets.md#transitrestorekey) | **POST** /{transit_mount_path}/restore/{name} | Restore the named key
[**TransitRewrap**](Secrets.md#transitrewrap) | **POST** /{transit_mount_path}/rewrap/{name} | Rewrap ciphertext
[**TransitRotateKey**](Secrets.md#transitrotatekey) | **POST** /{transit_mount_path}/keys/{name}/rotate | Rotate named encryption key
[**TransitSign**](Secrets.md#transitsign) | **POST** /{transit_mount_path}/sign/{name} | Generate a signature for input data using the named key
[**TransitSignWithAlgorithm**](Secrets.md#transitsignwithalgorithm) | **POST** /{transit_mount_path}/sign/{name}/{urlalgorithm} | Generate a signature for input data using the named key
[**TransitTrimKey**](Secrets.md#transittrimkey) | **POST** /{transit_mount_path}/keys/{name}/trim | Trim key versions of a named key
[**TransitVerify**](Secrets.md#transitverify) | **POST** /{transit_mount_path}/verify/{name} | Verify a signature or HMAC for input data created using the named key
[**TransitVerifyWithAlgorithm**](Secrets.md#transitverifywithalgorithm) | **POST** /{transit_mount_path}/verify/{name}/{urlalgorithm} | Verify a signature or HMAC for input data created using the named key
[**TransitWriteCacheConfig**](Secrets.md#transitwritecacheconfig) | **POST** /{transit_mount_path}/cache-config | Configures a new cache of the specified size
[**TransitWriteConfigKeys**](Secrets.md#transitwriteconfigkeys) | **POST** /{transit_mount_path}/config/keys | Configuration common across all keys
[**TransitWriteKey**](Secrets.md#transitwritekey) | **POST** /{transit_mount_path}/keys/{name} | Managed named encryption keys
[**TransitWriteKeyConfig**](Secrets.md#transitwritekeyconfig) | **POST** /{transit_mount_path}/keys/{name}/config | Configure a named encryption key
[**TransitWriteRandomUrlbytes**](Secrets.md#transitwriterandomurlbytes) | **POST** /{transit_mount_path}/random/{urlbytes} | Generate random bytes


<a name="awsconfigreadlease"></a>
# **AWSConfigReadLease**
> void AWSConfigReadLease (string awsMountPath = "aws", TimeSpan? wrapTTL = null)

Configure the default lease information for generated credentials.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AWSConfigReadLeaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Configure the default lease information for generated credentials.
                apiInstance.AWSConfigReadLease(string awsMountPath = "aws", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AWSConfigReadLease: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="awsconfigreadrootiamcredentials"></a>
# **AWSConfigReadRootIAMCredentials**
> void AWSConfigReadRootIAMCredentials (string awsMountPath = "aws", TimeSpan? wrapTTL = null)

Configure the root credentials that are used to manage IAM.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AWSConfigReadRootIAMCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Configure the root credentials that are used to manage IAM.
                apiInstance.AWSConfigReadRootIAMCredentials(string awsMountPath = "aws", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AWSConfigReadRootIAMCredentials: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="awsconfigrotaterootiamcredentials"></a>
# **AWSConfigRotateRootIAMCredentials**
> void AWSConfigRotateRootIAMCredentials (string awsMountPath = "aws", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AWSConfigRotateRootIAMCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.AWSConfigRotateRootIAMCredentials(string awsMountPath = "aws", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AWSConfigRotateRootIAMCredentials: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="awsconfigwritelease"></a>
# **AWSConfigWriteLease**
> void AWSConfigWriteLease (AWSConfigWriteLeaseRequest aWSConfigWriteLeaseRequest, string awsMountPath = "aws", TimeSpan? wrapTTL = null)

Configure the default lease information for generated credentials.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AWSConfigWriteLeaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var aWSConfigWriteLeaseRequest = new AWSConfigWriteLeaseRequest(); // AWSConfigWriteLeaseRequest | 
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Configure the default lease information for generated credentials.
                apiInstance.AWSConfigWriteLease(AWSConfigWriteLeaseRequest aWSConfigWriteLeaseRequest, string awsMountPath = "aws", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AWSConfigWriteLease: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aWSConfigWriteLeaseRequest** | [**AWSConfigWriteLeaseRequest**](AWSConfigWriteLeaseRequest.md)|  | 
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

<a name="awsconfigwriterootiamcredentials"></a>
# **AWSConfigWriteRootIAMCredentials**
> void AWSConfigWriteRootIAMCredentials (AWSConfigWriteRootIAMCredentialsRequest aWSConfigWriteRootIAMCredentialsRequest, string awsMountPath = "aws", TimeSpan? wrapTTL = null)

Configure the root credentials that are used to manage IAM.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AWSConfigWriteRootIAMCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var aWSConfigWriteRootIAMCredentialsRequest = new AWSConfigWriteRootIAMCredentialsRequest(); // AWSConfigWriteRootIAMCredentialsRequest | 
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Configure the root credentials that are used to manage IAM.
                apiInstance.AWSConfigWriteRootIAMCredentials(AWSConfigWriteRootIAMCredentialsRequest aWSConfigWriteRootIAMCredentialsRequest, string awsMountPath = "aws", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AWSConfigWriteRootIAMCredentials: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aWSConfigWriteRootIAMCredentialsRequest** | [**AWSConfigWriteRootIAMCredentialsRequest**](AWSConfigWriteRootIAMCredentialsRequest.md)|  | 
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

<a name="awsdeleterole"></a>
# **AWSDeleteRole**
> void AWSDeleteRole (string name, string awsMountPath = "aws", TimeSpan? wrapTTL = null)

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
    public class AWSDeleteRoleExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Read, write and reference IAM policies that access keys can be made for.
                apiInstance.AWSDeleteRole(string name, string awsMountPath = "aws", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AWSDeleteRole: " + e.Message );
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

<a name="awslistroles"></a>
# **AWSListRoles**
> void AWSListRoles (string awsMountPath = "aws", TimeSpan? wrapTTL = null)

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
    public class AWSListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // List the existing roles in this backend
                apiInstance.AWSListRoles(string awsMountPath = "aws", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AWSListRoles: " + e.Message );
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

<a name="awsreadcredentials"></a>
# **AWSReadCredentials**
> void AWSReadCredentials (string awsMountPath = "aws", TimeSpan? wrapTTL = null)

Generate AWS credentials from a specific Vault role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AWSReadCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Generate AWS credentials from a specific Vault role.
                apiInstance.AWSReadCredentials(string awsMountPath = "aws", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AWSReadCredentials: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="awsreadrole"></a>
# **AWSReadRole**
> void AWSReadRole (string name, string awsMountPath = "aws", TimeSpan? wrapTTL = null)

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
    public class AWSReadRoleExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Read, write and reference IAM policies that access keys can be made for.
                apiInstance.AWSReadRole(string name, string awsMountPath = "aws", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AWSReadRole: " + e.Message );
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

<a name="awsreadsecuritytokenservice"></a>
# **AWSReadSecurityTokenService**
> void AWSReadSecurityTokenService (string name, string awsMountPath = "aws", TimeSpan? wrapTTL = null)

Generate AWS credentials from a specific Vault role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AWSReadSecurityTokenServiceExample
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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Generate AWS credentials from a specific Vault role.
                apiInstance.AWSReadSecurityTokenService(string name, string awsMountPath = "aws", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AWSReadSecurityTokenService: " + e.Message );
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

<a name="awswritecredentials"></a>
# **AWSWriteCredentials**
> void AWSWriteCredentials (AWSWriteCredentialsRequest aWSWriteCredentialsRequest, string awsMountPath = "aws", TimeSpan? wrapTTL = null)

Generate AWS credentials from a specific Vault role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AWSWriteCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var aWSWriteCredentialsRequest = new AWSWriteCredentialsRequest(); // AWSWriteCredentialsRequest | 
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Generate AWS credentials from a specific Vault role.
                apiInstance.AWSWriteCredentials(AWSWriteCredentialsRequest aWSWriteCredentialsRequest, string awsMountPath = "aws", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AWSWriteCredentials: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aWSWriteCredentialsRequest** | [**AWSWriteCredentialsRequest**](AWSWriteCredentialsRequest.md)|  | 
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

<a name="awswriterole"></a>
# **AWSWriteRole**
> void AWSWriteRole (AWSWriteRoleRequest aWSWriteRoleRequest, string name, string awsMountPath = "aws", TimeSpan? wrapTTL = null)

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
    public class AWSWriteRoleExample
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
            var aWSWriteRoleRequest = new AWSWriteRoleRequest(); // AWSWriteRoleRequest | 
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Read, write and reference IAM policies that access keys can be made for.
                apiInstance.AWSWriteRole(AWSWriteRoleRequest aWSWriteRoleRequest, string name, string awsMountPath = "aws", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AWSWriteRole: " + e.Message );
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
 **aWSWriteRoleRequest** | [**AWSWriteRoleRequest**](AWSWriteRoleRequest.md)|  | 
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

<a name="awswritesecuritytokenservice"></a>
# **AWSWriteSecurityTokenService**
> void AWSWriteSecurityTokenService (AWSWriteSecurityTokenServiceRequest aWSWriteSecurityTokenServiceRequest, string name, string awsMountPath = "aws", TimeSpan? wrapTTL = null)

Generate AWS credentials from a specific Vault role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AWSWriteSecurityTokenServiceExample
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
            var aWSWriteSecurityTokenServiceRequest = new AWSWriteSecurityTokenServiceRequest(); // AWSWriteSecurityTokenServiceRequest | 
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Generate AWS credentials from a specific Vault role.
                apiInstance.AWSWriteSecurityTokenService(AWSWriteSecurityTokenServiceRequest aWSWriteSecurityTokenServiceRequest, string name, string awsMountPath = "aws", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AWSWriteSecurityTokenService: " + e.Message );
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
 **aWSWriteSecurityTokenServiceRequest** | [**AWSWriteSecurityTokenServiceRequest**](AWSWriteSecurityTokenServiceRequest.md)|  | 
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

<a name="activedirectorycheckinlibrary"></a>
# **ActiveDirectoryCheckInLibrary**
> void ActiveDirectoryCheckInLibrary (ActiveDirectoryCheckInLibraryRequest activeDirectoryCheckInLibraryRequest, string name, string adMountPath = "ad", TimeSpan? wrapTTL = null)

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
    public class ActiveDirectoryCheckInLibraryExample
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
            var activeDirectoryCheckInLibraryRequest = new ActiveDirectoryCheckInLibraryRequest(); // ActiveDirectoryCheckInLibraryRequest | 
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Check service accounts in to the library.
                apiInstance.ActiveDirectoryCheckInLibrary(ActiveDirectoryCheckInLibraryRequest activeDirectoryCheckInLibraryRequest, string name, string adMountPath = "ad", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ActiveDirectoryCheckInLibrary: " + e.Message );
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
 **activeDirectoryCheckInLibraryRequest** | [**ActiveDirectoryCheckInLibraryRequest**](ActiveDirectoryCheckInLibraryRequest.md)|  | 
 **adMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activedirectorycheckinmanagelibrary"></a>
# **ActiveDirectoryCheckInManageLibrary**
> void ActiveDirectoryCheckInManageLibrary (ActiveDirectoryCheckInManageLibraryRequest activeDirectoryCheckInManageLibraryRequest, string name, string adMountPath = "ad", TimeSpan? wrapTTL = null)

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
    public class ActiveDirectoryCheckInManageLibraryExample
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
            var activeDirectoryCheckInManageLibraryRequest = new ActiveDirectoryCheckInManageLibraryRequest(); // ActiveDirectoryCheckInManageLibraryRequest | 
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Check service accounts in to the library.
                apiInstance.ActiveDirectoryCheckInManageLibrary(ActiveDirectoryCheckInManageLibraryRequest activeDirectoryCheckInManageLibraryRequest, string name, string adMountPath = "ad", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ActiveDirectoryCheckInManageLibrary: " + e.Message );
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
 **activeDirectoryCheckInManageLibraryRequest** | [**ActiveDirectoryCheckInManageLibraryRequest**](ActiveDirectoryCheckInManageLibraryRequest.md)|  | 
 **adMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activedirectorycheckoutlibrary"></a>
# **ActiveDirectoryCheckOutLibrary**
> void ActiveDirectoryCheckOutLibrary (ActiveDirectoryCheckOutLibraryRequest activeDirectoryCheckOutLibraryRequest, string name, string adMountPath = "ad", TimeSpan? wrapTTL = null)

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
    public class ActiveDirectoryCheckOutLibraryExample
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
            var activeDirectoryCheckOutLibraryRequest = new ActiveDirectoryCheckOutLibraryRequest(); // ActiveDirectoryCheckOutLibraryRequest | 
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Check a service account out from the library.
                apiInstance.ActiveDirectoryCheckOutLibrary(ActiveDirectoryCheckOutLibraryRequest activeDirectoryCheckOutLibraryRequest, string name, string adMountPath = "ad", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ActiveDirectoryCheckOutLibrary: " + e.Message );
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
 **activeDirectoryCheckOutLibraryRequest** | [**ActiveDirectoryCheckOutLibraryRequest**](ActiveDirectoryCheckOutLibraryRequest.md)|  | 
 **adMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activedirectorydeleteconfig"></a>
# **ActiveDirectoryDeleteConfig**
> void ActiveDirectoryDeleteConfig (string adMountPath = "ad", TimeSpan? wrapTTL = null)

Configure the AD server to connect to, along with password options.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ActiveDirectoryDeleteConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Configure the AD server to connect to, along with password options.
                apiInstance.ActiveDirectoryDeleteConfig(string adMountPath = "ad", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ActiveDirectoryDeleteConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **adMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activedirectorydeletelibrary"></a>
# **ActiveDirectoryDeleteLibrary**
> void ActiveDirectoryDeleteLibrary (string name, string adMountPath = "ad", TimeSpan? wrapTTL = null)

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
    public class ActiveDirectoryDeleteLibraryExample
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
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Delete a library set.
                apiInstance.ActiveDirectoryDeleteLibrary(string name, string adMountPath = "ad", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ActiveDirectoryDeleteLibrary: " + e.Message );
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
 **adMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activedirectorydeleterole"></a>
# **ActiveDirectoryDeleteRole**
> void ActiveDirectoryDeleteRole (string name, string adMountPath = "ad", TimeSpan? wrapTTL = null)

Manage roles to build links between Vault and Active Directory service accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ActiveDirectoryDeleteRoleExample
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
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Manage roles to build links between Vault and Active Directory service accounts.
                apiInstance.ActiveDirectoryDeleteRole(string name, string adMountPath = "ad", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ActiveDirectoryDeleteRole: " + e.Message );
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
 **adMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activedirectorylistlibraries"></a>
# **ActiveDirectoryListLibraries**
> void ActiveDirectoryListLibraries (string adMountPath = "ad", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ActiveDirectoryListLibrariesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                apiInstance.ActiveDirectoryListLibraries(string adMountPath = "ad", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ActiveDirectoryListLibraries: " + e.Message );
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
 **adMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activedirectorylistroles"></a>
# **ActiveDirectoryListRoles**
> void ActiveDirectoryListRoles (string adMountPath = "ad", TimeSpan? wrapTTL = null)

List the name of each role currently stored.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ActiveDirectoryListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // List the name of each role currently stored.
                apiInstance.ActiveDirectoryListRoles(string adMountPath = "ad", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ActiveDirectoryListRoles: " + e.Message );
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
 **adMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activedirectoryreadconfig"></a>
# **ActiveDirectoryReadConfig**
> void ActiveDirectoryReadConfig (string adMountPath = "ad", TimeSpan? wrapTTL = null)

Configure the AD server to connect to, along with password options.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ActiveDirectoryReadConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Configure the AD server to connect to, along with password options.
                apiInstance.ActiveDirectoryReadConfig(string adMountPath = "ad", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ActiveDirectoryReadConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **adMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activedirectoryreadcredentials"></a>
# **ActiveDirectoryReadCredentials**
> void ActiveDirectoryReadCredentials (string name, string adMountPath = "ad", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ActiveDirectoryReadCredentialsExample
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
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                apiInstance.ActiveDirectoryReadCredentials(string name, string adMountPath = "ad", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ActiveDirectoryReadCredentials: " + e.Message );
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
 **adMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activedirectoryreadlibrary"></a>
# **ActiveDirectoryReadLibrary**
> void ActiveDirectoryReadLibrary (string name, string adMountPath = "ad", TimeSpan? wrapTTL = null)

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
    public class ActiveDirectoryReadLibraryExample
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
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Read a library set.
                apiInstance.ActiveDirectoryReadLibrary(string name, string adMountPath = "ad", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ActiveDirectoryReadLibrary: " + e.Message );
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
 **adMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activedirectoryreadlibrarystatus"></a>
# **ActiveDirectoryReadLibraryStatus**
> void ActiveDirectoryReadLibraryStatus (string name, string adMountPath = "ad", TimeSpan? wrapTTL = null)

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
    public class ActiveDirectoryReadLibraryStatusExample
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
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Check the status of the service accounts in a library set.
                apiInstance.ActiveDirectoryReadLibraryStatus(string name, string adMountPath = "ad", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ActiveDirectoryReadLibraryStatus: " + e.Message );
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
 **adMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activedirectoryreadrole"></a>
# **ActiveDirectoryReadRole**
> void ActiveDirectoryReadRole (string name, string adMountPath = "ad", TimeSpan? wrapTTL = null)

Manage roles to build links between Vault and Active Directory service accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ActiveDirectoryReadRoleExample
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
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Manage roles to build links between Vault and Active Directory service accounts.
                apiInstance.ActiveDirectoryReadRole(string name, string adMountPath = "ad", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ActiveDirectoryReadRole: " + e.Message );
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
 **adMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activedirectoryrotaterole"></a>
# **ActiveDirectoryRotateRole**
> void ActiveDirectoryRotateRole (string name, string adMountPath = "ad", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ActiveDirectoryRotateRoleExample
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
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                apiInstance.ActiveDirectoryRotateRole(string name, string adMountPath = "ad", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ActiveDirectoryRotateRole: " + e.Message );
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
 **adMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activedirectoryrotateroot"></a>
# **ActiveDirectoryRotateRoot**
> void ActiveDirectoryRotateRoot (string adMountPath = "ad", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ActiveDirectoryRotateRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                apiInstance.ActiveDirectoryRotateRoot(string adMountPath = "ad", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ActiveDirectoryRotateRoot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **adMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activedirectorywriteconfig"></a>
# **ActiveDirectoryWriteConfig**
> void ActiveDirectoryWriteConfig (ActiveDirectoryWriteConfigRequest activeDirectoryWriteConfigRequest, string adMountPath = "ad", TimeSpan? wrapTTL = null)

Configure the AD server to connect to, along with password options.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ActiveDirectoryWriteConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var activeDirectoryWriteConfigRequest = new ActiveDirectoryWriteConfigRequest(); // ActiveDirectoryWriteConfigRequest | 
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Configure the AD server to connect to, along with password options.
                apiInstance.ActiveDirectoryWriteConfig(ActiveDirectoryWriteConfigRequest activeDirectoryWriteConfigRequest, string adMountPath = "ad", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ActiveDirectoryWriteConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activeDirectoryWriteConfigRequest** | [**ActiveDirectoryWriteConfigRequest**](ActiveDirectoryWriteConfigRequest.md)|  | 
 **adMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activedirectorywritelibrary"></a>
# **ActiveDirectoryWriteLibrary**
> void ActiveDirectoryWriteLibrary (ActiveDirectoryWriteLibraryRequest activeDirectoryWriteLibraryRequest, string name, string adMountPath = "ad", TimeSpan? wrapTTL = null)

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
    public class ActiveDirectoryWriteLibraryExample
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
            var activeDirectoryWriteLibraryRequest = new ActiveDirectoryWriteLibraryRequest(); // ActiveDirectoryWriteLibraryRequest | 
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Update a library set.
                apiInstance.ActiveDirectoryWriteLibrary(ActiveDirectoryWriteLibraryRequest activeDirectoryWriteLibraryRequest, string name, string adMountPath = "ad", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ActiveDirectoryWriteLibrary: " + e.Message );
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
 **activeDirectoryWriteLibraryRequest** | [**ActiveDirectoryWriteLibraryRequest**](ActiveDirectoryWriteLibraryRequest.md)|  | 
 **adMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activedirectorywriterole"></a>
# **ActiveDirectoryWriteRole**
> void ActiveDirectoryWriteRole (ActiveDirectoryWriteRoleRequest activeDirectoryWriteRoleRequest, string name, string adMountPath = "ad", TimeSpan? wrapTTL = null)

Manage roles to build links between Vault and Active Directory service accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ActiveDirectoryWriteRoleExample
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
            var activeDirectoryWriteRoleRequest = new ActiveDirectoryWriteRoleRequest(); // ActiveDirectoryWriteRoleRequest | 
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Manage roles to build links between Vault and Active Directory service accounts.
                apiInstance.ActiveDirectoryWriteRole(ActiveDirectoryWriteRoleRequest activeDirectoryWriteRoleRequest, string name, string adMountPath = "ad", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ActiveDirectoryWriteRole: " + e.Message );
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
 **activeDirectoryWriteRoleRequest** | [**ActiveDirectoryWriteRoleRequest**](ActiveDirectoryWriteRoleRequest.md)|  | 
 **adMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aliclouddeleteconfig"></a>
# **AliCloudDeleteConfig**
> void AliCloudDeleteConfig (string alicloudMountPath = "alicloud", TimeSpan? wrapTTL = null)

Configure the access key and secret to use for RAM and STS calls.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AliCloudDeleteConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var alicloudMountPath = "\"alicloud\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "alicloud")

            try
            {
                // Configure the access key and secret to use for RAM and STS calls.
                apiInstance.AliCloudDeleteConfig(string alicloudMountPath = "alicloud", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AliCloudDeleteConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="aliclouddeleterole"></a>
# **AliCloudDeleteRole**
> void AliCloudDeleteRole (string name, string alicloudMountPath = "alicloud", TimeSpan? wrapTTL = null)

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
            var alicloudMountPath = "\"alicloud\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "alicloud")

            try
            {
                // Read, write and reference policies and roles that API keys or STS credentials can be made for.
                apiInstance.AliCloudDeleteRole(string name, string alicloudMountPath = "alicloud", TimeSpan? wrapTTL = null);
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

<a name="alicloudlistroles"></a>
# **AliCloudListRoles**
> void AliCloudListRoles (string alicloudMountPath = "alicloud", TimeSpan? wrapTTL = null)

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
            var list = "true";  // string | Must be set to `true`
            var alicloudMountPath = "\"alicloud\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "alicloud")

            try
            {
                // List the existing roles in this backend.
                apiInstance.AliCloudListRoles(string alicloudMountPath = "alicloud", TimeSpan? wrapTTL = null);
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

<a name="alicloudreadconfig"></a>
# **AliCloudReadConfig**
> void AliCloudReadConfig (string alicloudMountPath = "alicloud", TimeSpan? wrapTTL = null)

Configure the access key and secret to use for RAM and STS calls.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AliCloudReadConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var alicloudMountPath = "\"alicloud\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "alicloud")

            try
            {
                // Configure the access key and secret to use for RAM and STS calls.
                apiInstance.AliCloudReadConfig(string alicloudMountPath = "alicloud", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AliCloudReadConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="alicloudreadcredentials"></a>
# **AliCloudReadCredentials**
> void AliCloudReadCredentials (string name, string alicloudMountPath = "alicloud", TimeSpan? wrapTTL = null)

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
    public class AliCloudReadCredentialsExample
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
            var alicloudMountPath = "\"alicloud\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "alicloud")

            try
            {
                // Generate an API key or STS credential using the given role's configuration.'
                apiInstance.AliCloudReadCredentials(string name, string alicloudMountPath = "alicloud", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AliCloudReadCredentials: " + e.Message );
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

<a name="alicloudreadrole"></a>
# **AliCloudReadRole**
> void AliCloudReadRole (string name, string alicloudMountPath = "alicloud", TimeSpan? wrapTTL = null)

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
            var alicloudMountPath = "\"alicloud\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "alicloud")

            try
            {
                // Read, write and reference policies and roles that API keys or STS credentials can be made for.
                apiInstance.AliCloudReadRole(string name, string alicloudMountPath = "alicloud", TimeSpan? wrapTTL = null);
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

<a name="alicloudwriteconfig"></a>
# **AliCloudWriteConfig**
> void AliCloudWriteConfig (AliCloudWriteConfigRequest aliCloudWriteConfigRequest, string alicloudMountPath = "alicloud", TimeSpan? wrapTTL = null)

Configure the access key and secret to use for RAM and STS calls.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AliCloudWriteConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var aliCloudWriteConfigRequest = new AliCloudWriteConfigRequest(); // AliCloudWriteConfigRequest | 
            var alicloudMountPath = "\"alicloud\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "alicloud")

            try
            {
                // Configure the access key and secret to use for RAM and STS calls.
                apiInstance.AliCloudWriteConfig(AliCloudWriteConfigRequest aliCloudWriteConfigRequest, string alicloudMountPath = "alicloud", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AliCloudWriteConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aliCloudWriteConfigRequest** | [**AliCloudWriteConfigRequest**](AliCloudWriteConfigRequest.md)|  | 
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

<a name="alicloudwriterole"></a>
# **AliCloudWriteRole**
> void AliCloudWriteRole (AliCloudWriteRoleRequest aliCloudWriteRoleRequest, string name, string alicloudMountPath = "alicloud", TimeSpan? wrapTTL = null)

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
            var aliCloudWriteRoleRequest = new AliCloudWriteRoleRequest(); // AliCloudWriteRoleRequest | 
            var alicloudMountPath = "\"alicloud\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "alicloud")

            try
            {
                // Read, write and reference policies and roles that API keys or STS credentials can be made for.
                apiInstance.AliCloudWriteRole(AliCloudWriteRoleRequest aliCloudWriteRoleRequest, string name, string alicloudMountPath = "alicloud", TimeSpan? wrapTTL = null);
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
 **aliCloudWriteRoleRequest** | [**AliCloudWriteRoleRequest**](AliCloudWriteRoleRequest.md)|  | 
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

<a name="azuredeleteconfig"></a>
# **AzureDeleteConfig**
> void AzureDeleteConfig (string azureMountPath = "azure", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AzureDeleteConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                apiInstance.AzureDeleteConfig(string azureMountPath = "azure", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AzureDeleteConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="azuredeleterole"></a>
# **AzureDeleteRole**
> void AzureDeleteRole (string name, string azureMountPath = "azure", TimeSpan? wrapTTL = null)

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
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                // Manage the Vault roles used to generate Azure credentials.
                apiInstance.AzureDeleteRole(string name, string azureMountPath = "azure", TimeSpan? wrapTTL = null);
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

<a name="azurelistroles"></a>
# **AzureListRoles**
> void AzureListRoles (string azureMountPath = "azure", TimeSpan? wrapTTL = null)

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
            var list = "true";  // string | Must be set to `true`
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                // List existing roles.
                apiInstance.AzureListRoles(string azureMountPath = "azure", TimeSpan? wrapTTL = null);
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

<a name="azurereadconfig"></a>
# **AzureReadConfig**
> void AzureReadConfig (string azureMountPath = "azure", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AzureReadConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                apiInstance.AzureReadConfig(string azureMountPath = "azure", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AzureReadConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="azurereadcredentials"></a>
# **AzureReadCredentials**
> void AzureReadCredentials (string role, string azureMountPath = "azure", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AzureReadCredentialsExample
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
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                apiInstance.AzureReadCredentials(string role, string azureMountPath = "azure", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AzureReadCredentials: " + e.Message );
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

<a name="azurereadrole"></a>
# **AzureReadRole**
> void AzureReadRole (string name, string azureMountPath = "azure", TimeSpan? wrapTTL = null)

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
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                // Manage the Vault roles used to generate Azure credentials.
                apiInstance.AzureReadRole(string name, string azureMountPath = "azure", TimeSpan? wrapTTL = null);
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

<a name="azurerotateroot"></a>
# **AzureRotateRoot**
> void AzureRotateRoot (string azureMountPath = "azure", TimeSpan? wrapTTL = null)



### Example
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
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                apiInstance.AzureRotateRoot(string azureMountPath = "azure", TimeSpan? wrapTTL = null);
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

<a name="azurewriteconfig"></a>
# **AzureWriteConfig**
> void AzureWriteConfig (AzureWriteConfigRequest azureWriteConfigRequest, string azureMountPath = "azure", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class AzureWriteConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var azureWriteConfigRequest = new AzureWriteConfigRequest(); // AzureWriteConfigRequest | 
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                apiInstance.AzureWriteConfig(AzureWriteConfigRequest azureWriteConfigRequest, string azureMountPath = "azure", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.AzureWriteConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **azureWriteConfigRequest** | [**AzureWriteConfigRequest**](AzureWriteConfigRequest.md)|  | 
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

<a name="azurewriterole"></a>
# **AzureWriteRole**
> void AzureWriteRole (AzureWriteRoleRequest azureWriteRoleRequest, string name, string azureMountPath = "azure", TimeSpan? wrapTTL = null)

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
            var azureWriteRoleRequest = new AzureWriteRoleRequest(); // AzureWriteRoleRequest | 
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                // Manage the Vault roles used to generate Azure credentials.
                apiInstance.AzureWriteRole(AzureWriteRoleRequest azureWriteRoleRequest, string name, string azureMountPath = "azure", TimeSpan? wrapTTL = null);
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
 **azureWriteRoleRequest** | [**AzureWriteRoleRequest**](AzureWriteRoleRequest.md)|  | 
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

<a name="consuldeleterole"></a>
# **ConsulDeleteRole**
> void ConsulDeleteRole (string name, string consulMountPath = "consul", TimeSpan? wrapTTL = null)



### Example
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
            var consulMountPath = "\"consul\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "consul")

            try
            {
                apiInstance.ConsulDeleteRole(string name, string consulMountPath = "consul", TimeSpan? wrapTTL = null);
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
 **consulMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;consul&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="consullistroles"></a>
# **ConsulListRoles**
> void ConsulListRoles (string consulMountPath = "consul", TimeSpan? wrapTTL = null)



### Example
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
            var list = "true";  // string | Must be set to `true`
            var consulMountPath = "\"consul\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "consul")

            try
            {
                apiInstance.ConsulListRoles(string consulMountPath = "consul", TimeSpan? wrapTTL = null);
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
 **list** | **string**| Must be set to &#x60;true&#x60; | 
 **consulMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;consul&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="consulreadaccessconfig"></a>
# **ConsulReadAccessConfig**
> void ConsulReadAccessConfig (string consulMountPath = "consul", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ConsulReadAccessConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var consulMountPath = "\"consul\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "consul")

            try
            {
                apiInstance.ConsulReadAccessConfig(string consulMountPath = "consul", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ConsulReadAccessConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **consulMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;consul&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="consulreadcredentials"></a>
# **ConsulReadCredentials**
> void ConsulReadCredentials (string role, string consulMountPath = "consul", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ConsulReadCredentialsExample
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
            var consulMountPath = "\"consul\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "consul")

            try
            {
                apiInstance.ConsulReadCredentials(string role, string consulMountPath = "consul", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ConsulReadCredentials: " + e.Message );
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
 **consulMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;consul&quot;]

### Return type

void (empty response body)

### Authorization

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
> void ConsulReadRole (string name, string consulMountPath = "consul", TimeSpan? wrapTTL = null)



### Example
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
            var consulMountPath = "\"consul\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "consul")

            try
            {
                apiInstance.ConsulReadRole(string name, string consulMountPath = "consul", TimeSpan? wrapTTL = null);
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
 **consulMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;consul&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="consulwriteaccessconfig"></a>
# **ConsulWriteAccessConfig**
> void ConsulWriteAccessConfig (ConsulWriteAccessConfigRequest consulWriteAccessConfigRequest, string consulMountPath = "consul", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ConsulWriteAccessConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var consulWriteAccessConfigRequest = new ConsulWriteAccessConfigRequest(); // ConsulWriteAccessConfigRequest | 
            var consulMountPath = "\"consul\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "consul")

            try
            {
                apiInstance.ConsulWriteAccessConfig(ConsulWriteAccessConfigRequest consulWriteAccessConfigRequest, string consulMountPath = "consul", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ConsulWriteAccessConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **consulWriteAccessConfigRequest** | [**ConsulWriteAccessConfigRequest**](ConsulWriteAccessConfigRequest.md)|  | 
 **consulMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;consul&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="consulwriterole"></a>
# **ConsulWriteRole**
> void ConsulWriteRole (ConsulWriteRoleRequest consulWriteRoleRequest, string name, string consulMountPath = "consul", TimeSpan? wrapTTL = null)



### Example
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
            var consulWriteRoleRequest = new ConsulWriteRoleRequest(); // ConsulWriteRoleRequest | 
            var consulMountPath = "\"consul\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "consul")

            try
            {
                apiInstance.ConsulWriteRole(ConsulWriteRoleRequest consulWriteRoleRequest, string name, string consulMountPath = "consul", TimeSpan? wrapTTL = null);
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
 **consulWriteRoleRequest** | [**ConsulWriteRoleRequest**](ConsulWriteRoleRequest.md)|  | 
 **consulMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;consul&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cubbyholedelete"></a>
# **CubbyholeDelete**
> void CubbyholeDelete (string path, string cubbyholeMountPath = "cubbyhole", TimeSpan? wrapTTL = null)

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
            var cubbyholeMountPath = "\"cubbyhole\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cubbyhole")

            try
            {
                // Deletes the secret at the specified location.
                apiInstance.CubbyholeDelete(string path, string cubbyholeMountPath = "cubbyhole", TimeSpan? wrapTTL = null);
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
 **cubbyholeMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cubbyhole&quot;]

### Return type

void (empty response body)

### Authorization

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
> void CubbyholeRead (string path, string cubbyholeMountPath = "cubbyhole", string list = default(string), TimeSpan? wrapTTL = null)

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
            var cubbyholeMountPath = "\"cubbyhole\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cubbyhole")
            var list = "list_example";  // string | Return a list if `true` (optional) 

            try
            {
                // Retrieve the secret at the specified location.
                apiInstance.CubbyholeRead(string path, string cubbyholeMountPath = "cubbyhole", string list = default(string), TimeSpan? wrapTTL = null);
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
 **cubbyholeMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cubbyhole&quot;]
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
> void CubbyholeWrite (string path, string cubbyholeMountPath = "cubbyhole", TimeSpan? wrapTTL = null)

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
            var cubbyholeMountPath = "\"cubbyhole\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cubbyhole")

            try
            {
                // Store a secret at the specified location.
                apiInstance.CubbyholeWrite(string path, string cubbyholeMountPath = "cubbyhole", TimeSpan? wrapTTL = null);
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
 **cubbyholeMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cubbyhole&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="googleclouddeleteroleset"></a>
# **GoogleCloudDeleteRoleset**
> void GoogleCloudDeleteRoleset (string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudDeleteRoleset(string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
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

<a name="googleclouddeletestaticaccount"></a>
# **GoogleCloudDeleteStaticAccount**
> void GoogleCloudDeleteStaticAccount (string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudDeleteStaticAccount(string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
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

<a name="googlecloudkmsdecrypt"></a>
# **GoogleCloudKMSDecrypt**
> void GoogleCloudKMSDecrypt (GoogleCloudKMSDecryptRequest googleCloudKMSDecryptRequest, string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null)

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
    public class GoogleCloudKMSDecryptExample
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
            var googleCloudKMSDecryptRequest = new GoogleCloudKMSDecryptRequest(); // GoogleCloudKMSDecryptRequest | 
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Decrypt a ciphertext value using a named key
                apiInstance.GoogleCloudKMSDecrypt(GoogleCloudKMSDecryptRequest googleCloudKMSDecryptRequest, string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKMSDecrypt: " + e.Message );
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
 **googleCloudKMSDecryptRequest** | [**GoogleCloudKMSDecryptRequest**](GoogleCloudKMSDecryptRequest.md)|  | 
 **gcpkmsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="googlecloudkmsdeleteconfig"></a>
# **GoogleCloudKMSDeleteConfig**
> void GoogleCloudKMSDeleteConfig (string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null)

Configure the GCP KMS secrets engine

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKMSDeleteConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Configure the GCP KMS secrets engine
                apiInstance.GoogleCloudKMSDeleteConfig(string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKMSDeleteConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gcpkmsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

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
# **GoogleCloudKMSDeleteKey**
> void GoogleCloudKMSDeleteKey (string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null)

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
    public class GoogleCloudKMSDeleteKeyExample
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
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Interact with crypto keys in Vault and Google Cloud KMS
                apiInstance.GoogleCloudKMSDeleteKey(string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKMSDeleteKey: " + e.Message );
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
 **gcpkmsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

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
# **GoogleCloudKMSDeregisterKey**
> void GoogleCloudKMSDeregisterKey (string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null)

Deregister an existing key in Vault

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKMSDeregisterKeyExample
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
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Deregister an existing key in Vault
                apiInstance.GoogleCloudKMSDeregisterKey(string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKMSDeregisterKey: " + e.Message );
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
 **gcpkmsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="googlecloudkmsencrypt"></a>
# **GoogleCloudKMSEncrypt**
> void GoogleCloudKMSEncrypt (GoogleCloudKMSEncryptRequest googleCloudKMSEncryptRequest, string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null)

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
    public class GoogleCloudKMSEncryptExample
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
            var googleCloudKMSEncryptRequest = new GoogleCloudKMSEncryptRequest(); // GoogleCloudKMSEncryptRequest | 
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Encrypt a plaintext value using a named key
                apiInstance.GoogleCloudKMSEncrypt(GoogleCloudKMSEncryptRequest googleCloudKMSEncryptRequest, string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKMSEncrypt: " + e.Message );
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
 **googleCloudKMSEncryptRequest** | [**GoogleCloudKMSEncryptRequest**](GoogleCloudKMSEncryptRequest.md)|  | 
 **gcpkmsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="googlecloudkmslistkeys"></a>
# **GoogleCloudKMSListKeys**
> void GoogleCloudKMSListKeys (string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null)

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
    public class GoogleCloudKMSListKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // List named keys
                apiInstance.GoogleCloudKMSListKeys(string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKMSListKeys: " + e.Message );
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
 **gcpkmsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="googlecloudkmsreadconfig"></a>
# **GoogleCloudKMSReadConfig**
> void GoogleCloudKMSReadConfig (string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null)

Configure the GCP KMS secrets engine

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKMSReadConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Configure the GCP KMS secrets engine
                apiInstance.GoogleCloudKMSReadConfig(string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKMSReadConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gcpkmsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

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
# **GoogleCloudKMSReadKey**
> void GoogleCloudKMSReadKey (string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null)

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
    public class GoogleCloudKMSReadKeyExample
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
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Interact with crypto keys in Vault and Google Cloud KMS
                apiInstance.GoogleCloudKMSReadKey(string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKMSReadKey: " + e.Message );
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
 **gcpkmsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="googlecloudkmsreadkeyconfig"></a>
# **GoogleCloudKMSReadKeyConfig**
> void GoogleCloudKMSReadKeyConfig (string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null)

Configure the key in Vault

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKMSReadKeyConfigExample
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
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Configure the key in Vault
                apiInstance.GoogleCloudKMSReadKeyConfig(string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKMSReadKeyConfig: " + e.Message );
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
 **gcpkmsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="googlecloudkmsreadpubkey"></a>
# **GoogleCloudKMSReadPubkey**
> void GoogleCloudKMSReadPubkey (string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null)

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
    public class GoogleCloudKMSReadPubkeyExample
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
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Retrieve the public key associated with the named key
                apiInstance.GoogleCloudKMSReadPubkey(string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKMSReadPubkey: " + e.Message );
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
 **gcpkmsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

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
# **GoogleCloudKMSReencrypt**
> void GoogleCloudKMSReencrypt (GoogleCloudKMSReencryptRequest googleCloudKMSReencryptRequest, string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null)

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
    public class GoogleCloudKMSReencryptExample
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
            var googleCloudKMSReencryptRequest = new GoogleCloudKMSReencryptRequest(); // GoogleCloudKMSReencryptRequest | 
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Re-encrypt existing ciphertext data to a new version
                apiInstance.GoogleCloudKMSReencrypt(GoogleCloudKMSReencryptRequest googleCloudKMSReencryptRequest, string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKMSReencrypt: " + e.Message );
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
 **googleCloudKMSReencryptRequest** | [**GoogleCloudKMSReencryptRequest**](GoogleCloudKMSReencryptRequest.md)|  | 
 **gcpkmsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="googlecloudkmsregisterkey"></a>
# **GoogleCloudKMSRegisterKey**
> void GoogleCloudKMSRegisterKey (GoogleCloudKMSRegisterKeyRequest googleCloudKMSRegisterKeyRequest, string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null)

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
    public class GoogleCloudKMSRegisterKeyExample
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
            var googleCloudKMSRegisterKeyRequest = new GoogleCloudKMSRegisterKeyRequest(); // GoogleCloudKMSRegisterKeyRequest | 
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Register an existing crypto key in Google Cloud KMS
                apiInstance.GoogleCloudKMSRegisterKey(GoogleCloudKMSRegisterKeyRequest googleCloudKMSRegisterKeyRequest, string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKMSRegisterKey: " + e.Message );
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
 **googleCloudKMSRegisterKeyRequest** | [**GoogleCloudKMSRegisterKeyRequest**](GoogleCloudKMSRegisterKeyRequest.md)|  | 
 **gcpkmsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="googlecloudkmsrotatekey"></a>
# **GoogleCloudKMSRotateKey**
> void GoogleCloudKMSRotateKey (string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null)

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
    public class GoogleCloudKMSRotateKeyExample
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
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Rotate a crypto key to a new primary version
                apiInstance.GoogleCloudKMSRotateKey(string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKMSRotateKey: " + e.Message );
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
 **gcpkmsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

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
# **GoogleCloudKMSSign**
> void GoogleCloudKMSSign (GoogleCloudKMSSignRequest googleCloudKMSSignRequest, string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null)

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
    public class GoogleCloudKMSSignExample
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
            var googleCloudKMSSignRequest = new GoogleCloudKMSSignRequest(); // GoogleCloudKMSSignRequest | 
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Signs a message or digest using a named key
                apiInstance.GoogleCloudKMSSign(GoogleCloudKMSSignRequest googleCloudKMSSignRequest, string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKMSSign: " + e.Message );
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
 **googleCloudKMSSignRequest** | [**GoogleCloudKMSSignRequest**](GoogleCloudKMSSignRequest.md)|  | 
 **gcpkmsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="googlecloudkmstrimkey"></a>
# **GoogleCloudKMSTrimKey**
> void GoogleCloudKMSTrimKey (string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null)

Delete old crypto key versions from Google Cloud KMS

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKMSTrimKeyExample
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
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Delete old crypto key versions from Google Cloud KMS
                apiInstance.GoogleCloudKMSTrimKey(string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKMSTrimKey: " + e.Message );
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
 **gcpkmsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="googlecloudkmsverify"></a>
# **GoogleCloudKMSVerify**
> void GoogleCloudKMSVerify (GoogleCloudKMSVerifyRequest googleCloudKMSVerifyRequest, string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null)

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
    public class GoogleCloudKMSVerifyExample
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
            var googleCloudKMSVerifyRequest = new GoogleCloudKMSVerifyRequest(); // GoogleCloudKMSVerifyRequest | 
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Verify a signature using a named key
                apiInstance.GoogleCloudKMSVerify(GoogleCloudKMSVerifyRequest googleCloudKMSVerifyRequest, string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKMSVerify: " + e.Message );
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
 **googleCloudKMSVerifyRequest** | [**GoogleCloudKMSVerifyRequest**](GoogleCloudKMSVerifyRequest.md)|  | 
 **gcpkmsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="googlecloudkmswriteconfig"></a>
# **GoogleCloudKMSWriteConfig**
> void GoogleCloudKMSWriteConfig (GoogleCloudKMSWriteConfigRequest googleCloudKMSWriteConfigRequest, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null)

Configure the GCP KMS secrets engine

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKMSWriteConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var googleCloudKMSWriteConfigRequest = new GoogleCloudKMSWriteConfigRequest(); // GoogleCloudKMSWriteConfigRequest | 
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Configure the GCP KMS secrets engine
                apiInstance.GoogleCloudKMSWriteConfig(GoogleCloudKMSWriteConfigRequest googleCloudKMSWriteConfigRequest, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKMSWriteConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **googleCloudKMSWriteConfigRequest** | [**GoogleCloudKMSWriteConfigRequest**](GoogleCloudKMSWriteConfigRequest.md)|  | 
 **gcpkmsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="googlecloudkmswritekey"></a>
# **GoogleCloudKMSWriteKey**
> void GoogleCloudKMSWriteKey (GoogleCloudKMSWriteKeyRequest googleCloudKMSWriteKeyRequest, string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null)

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
    public class GoogleCloudKMSWriteKeyExample
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
            var googleCloudKMSWriteKeyRequest = new GoogleCloudKMSWriteKeyRequest(); // GoogleCloudKMSWriteKeyRequest | 
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Interact with crypto keys in Vault and Google Cloud KMS
                apiInstance.GoogleCloudKMSWriteKey(GoogleCloudKMSWriteKeyRequest googleCloudKMSWriteKeyRequest, string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKMSWriteKey: " + e.Message );
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
 **googleCloudKMSWriteKeyRequest** | [**GoogleCloudKMSWriteKeyRequest**](GoogleCloudKMSWriteKeyRequest.md)|  | 
 **gcpkmsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="googlecloudkmswritekeyconfig"></a>
# **GoogleCloudKMSWriteKeyConfig**
> void GoogleCloudKMSWriteKeyConfig (GoogleCloudKMSWriteKeyConfigRequest googleCloudKMSWriteKeyConfigRequest, string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null)

Configure the key in Vault

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudKMSWriteKeyConfigExample
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
            var googleCloudKMSWriteKeyConfigRequest = new GoogleCloudKMSWriteKeyConfigRequest(); // GoogleCloudKMSWriteKeyConfigRequest | 
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Configure the key in Vault
                apiInstance.GoogleCloudKMSWriteKeyConfig(GoogleCloudKMSWriteKeyConfigRequest googleCloudKMSWriteKeyConfigRequest, string key, string gcpkmsMountPath = "gcpkms", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudKMSWriteKeyConfig: " + e.Message );
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
 **googleCloudKMSWriteKeyConfigRequest** | [**GoogleCloudKMSWriteKeyConfigRequest**](GoogleCloudKMSWriteKeyConfigRequest.md)|  | 
 **gcpkmsMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="googlecloudlistrolesets"></a>
# **GoogleCloudListRolesets**
> void GoogleCloudListRolesets (string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
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
            var list = "true";  // string | Must be set to `true`
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudListRolesets(string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
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

<a name="googlecloudliststaticaccounts"></a>
# **GoogleCloudListStaticAccounts**
> void GoogleCloudListStaticAccounts (string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
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
            var list = "true";  // string | Must be set to `true`
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudListStaticAccounts(string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
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

<a name="googlecloudreadconfig"></a>
# **GoogleCloudReadConfig**
> void GoogleCloudReadConfig (string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudReadConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudReadConfig(string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudReadConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="googlecloudreadkey"></a>
# **GoogleCloudReadKey**
> void GoogleCloudReadKey (string roleset, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudReadKeyExample
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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudReadKey(string roleset, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudReadKey: " + e.Message );
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

<a name="googlecloudreadroleset"></a>
# **GoogleCloudReadRoleset**
> void GoogleCloudReadRoleset (string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudReadRoleset(string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
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

<a name="googlecloudreadrolesetkey"></a>
# **GoogleCloudReadRolesetKey**
> void GoogleCloudReadRolesetKey (string roleset, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudReadRolesetKeyExample
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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudReadRolesetKey(string roleset, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudReadRolesetKey: " + e.Message );
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

<a name="googlecloudreadrolesettoken"></a>
# **GoogleCloudReadRolesetToken**
> void GoogleCloudReadRolesetToken (string roleset, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudReadRolesetTokenExample
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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudReadRolesetToken(string roleset, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudReadRolesetToken: " + e.Message );
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

<a name="googlecloudreadstaticaccount"></a>
# **GoogleCloudReadStaticAccount**
> void GoogleCloudReadStaticAccount (string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudReadStaticAccount(string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
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

<a name="googlecloudreadstaticaccountkey"></a>
# **GoogleCloudReadStaticAccountKey**
> void GoogleCloudReadStaticAccountKey (string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudReadStaticAccountKeyExample
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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudReadStaticAccountKey(string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudReadStaticAccountKey: " + e.Message );
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

<a name="googlecloudreadstaticaccounttoken"></a>
# **GoogleCloudReadStaticAccountToken**
> void GoogleCloudReadStaticAccountToken (string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudReadStaticAccountTokenExample
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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudReadStaticAccountToken(string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudReadStaticAccountToken: " + e.Message );
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

<a name="googlecloudreadtoken"></a>
# **GoogleCloudReadToken**
> void GoogleCloudReadToken (string roleset, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudReadTokenExample
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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudReadToken(string roleset, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudReadToken: " + e.Message );
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

<a name="googlecloudrotateroleset"></a>
# **GoogleCloudRotateRoleset**
> void GoogleCloudRotateRoleset (string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudRotateRoleset(string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
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

<a name="googlecloudrotaterolesetkey"></a>
# **GoogleCloudRotateRolesetKey**
> void GoogleCloudRotateRolesetKey (string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudRotateRolesetKey(string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
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

<a name="googlecloudrotateroot"></a>
# **GoogleCloudRotateRoot**
> void GoogleCloudRotateRoot (string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudRotateRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudRotateRoot(string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudRotateRoot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="googlecloudrotatestaticaccountkey"></a>
# **GoogleCloudRotateStaticAccountKey**
> void GoogleCloudRotateStaticAccountKey (string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudRotateStaticAccountKey(string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
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

<a name="googlecloudwriteconfig"></a>
# **GoogleCloudWriteConfig**
> void GoogleCloudWriteConfig (GoogleCloudWriteConfigRequest googleCloudWriteConfigRequest, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudWriteConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var googleCloudWriteConfigRequest = new GoogleCloudWriteConfigRequest(); // GoogleCloudWriteConfigRequest | 
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudWriteConfig(GoogleCloudWriteConfigRequest googleCloudWriteConfigRequest, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudWriteConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **googleCloudWriteConfigRequest** | [**GoogleCloudWriteConfigRequest**](GoogleCloudWriteConfigRequest.md)|  | 
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

<a name="googlecloudwritekey"></a>
# **GoogleCloudWriteKey**
> void GoogleCloudWriteKey (GoogleCloudWriteKeyRequest googleCloudWriteKeyRequest, string roleset, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudWriteKeyExample
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
            var googleCloudWriteKeyRequest = new GoogleCloudWriteKeyRequest(); // GoogleCloudWriteKeyRequest | 
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudWriteKey(GoogleCloudWriteKeyRequest googleCloudWriteKeyRequest, string roleset, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudWriteKey: " + e.Message );
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
 **googleCloudWriteKeyRequest** | [**GoogleCloudWriteKeyRequest**](GoogleCloudWriteKeyRequest.md)|  | 
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

<a name="googlecloudwriteroleset"></a>
# **GoogleCloudWriteRoleset**
> void GoogleCloudWriteRoleset (GoogleCloudWriteRolesetRequest googleCloudWriteRolesetRequest, string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
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
            var googleCloudWriteRolesetRequest = new GoogleCloudWriteRolesetRequest(); // GoogleCloudWriteRolesetRequest | 
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudWriteRoleset(GoogleCloudWriteRolesetRequest googleCloudWriteRolesetRequest, string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
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
 **googleCloudWriteRolesetRequest** | [**GoogleCloudWriteRolesetRequest**](GoogleCloudWriteRolesetRequest.md)|  | 
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

<a name="googlecloudwriterolesetkey"></a>
# **GoogleCloudWriteRolesetKey**
> void GoogleCloudWriteRolesetKey (GoogleCloudWriteRolesetKeyRequest googleCloudWriteRolesetKeyRequest, string roleset, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudWriteRolesetKeyExample
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
            var googleCloudWriteRolesetKeyRequest = new GoogleCloudWriteRolesetKeyRequest(); // GoogleCloudWriteRolesetKeyRequest | 
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudWriteRolesetKey(GoogleCloudWriteRolesetKeyRequest googleCloudWriteRolesetKeyRequest, string roleset, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudWriteRolesetKey: " + e.Message );
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
 **googleCloudWriteRolesetKeyRequest** | [**GoogleCloudWriteRolesetKeyRequest**](GoogleCloudWriteRolesetKeyRequest.md)|  | 
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

<a name="googlecloudwriterolesettoken"></a>
# **GoogleCloudWriteRolesetToken**
> void GoogleCloudWriteRolesetToken (string roleset, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudWriteRolesetTokenExample
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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudWriteRolesetToken(string roleset, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudWriteRolesetToken: " + e.Message );
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

<a name="googlecloudwritestaticaccount"></a>
# **GoogleCloudWriteStaticAccount**
> void GoogleCloudWriteStaticAccount (GoogleCloudWriteStaticAccountRequest googleCloudWriteStaticAccountRequest, string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
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
            var googleCloudWriteStaticAccountRequest = new GoogleCloudWriteStaticAccountRequest(); // GoogleCloudWriteStaticAccountRequest | 
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudWriteStaticAccount(GoogleCloudWriteStaticAccountRequest googleCloudWriteStaticAccountRequest, string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
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
 **googleCloudWriteStaticAccountRequest** | [**GoogleCloudWriteStaticAccountRequest**](GoogleCloudWriteStaticAccountRequest.md)|  | 
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

<a name="googlecloudwritestaticaccountkey"></a>
# **GoogleCloudWriteStaticAccountKey**
> void GoogleCloudWriteStaticAccountKey (GoogleCloudWriteStaticAccountKeyRequest googleCloudWriteStaticAccountKeyRequest, string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudWriteStaticAccountKeyExample
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
            var googleCloudWriteStaticAccountKeyRequest = new GoogleCloudWriteStaticAccountKeyRequest(); // GoogleCloudWriteStaticAccountKeyRequest | 
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudWriteStaticAccountKey(GoogleCloudWriteStaticAccountKeyRequest googleCloudWriteStaticAccountKeyRequest, string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudWriteStaticAccountKey: " + e.Message );
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
 **googleCloudWriteStaticAccountKeyRequest** | [**GoogleCloudWriteStaticAccountKeyRequest**](GoogleCloudWriteStaticAccountKeyRequest.md)|  | 
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

<a name="googlecloudwritestaticaccounttoken"></a>
# **GoogleCloudWriteStaticAccountToken**
> void GoogleCloudWriteStaticAccountToken (string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudWriteStaticAccountTokenExample
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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudWriteStaticAccountToken(string name, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudWriteStaticAccountToken: " + e.Message );
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

<a name="googlecloudwritetoken"></a>
# **GoogleCloudWriteToken**
> void GoogleCloudWriteToken (string roleset, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GoogleCloudWriteTokenExample
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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GoogleCloudWriteToken(string roleset, string gcpMountPath = "gcp", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GoogleCloudWriteToken: " + e.Message );
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

<a name="kvv1delete"></a>
# **KVv1Delete**
> void KVv1Delete (string path, string kvMountPath = "kv", TimeSpan? wrapTTL = null)

Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KVv1DeleteExample
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
            var kvMountPath = "\"kv\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kv")

            try
            {
                // Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.
                apiInstance.KVv1Delete(string path, string kvMountPath = "kv", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KVv1Delete: " + e.Message );
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
 **kvMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kv&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="kvv1read"></a>
# **KVv1Read**
> void KVv1Read (string path, string kvMountPath = "kv", string list = default(string), TimeSpan? wrapTTL = null)

Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KVv1ReadExample
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
            var kvMountPath = "\"kv\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kv")
            var list = "list_example";  // string | Return a list if `true` (optional) 

            try
            {
                // Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.
                apiInstance.KVv1Read(string path, string kvMountPath = "kv", string list = default(string), TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KVv1Read: " + e.Message );
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
 **kvMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kv&quot;]
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
# **KVv1Write**
> void KVv1Write (string path, string kvMountPath = "kv", TimeSpan? wrapTTL = null)

Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KVv1WriteExample
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
            var kvMountPath = "\"kv\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kv")

            try
            {
                // Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.
                apiInstance.KVv1Write(string path, string kvMountPath = "kv", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KVv1Write: " + e.Message );
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
 **kvMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;kv&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="kvv2delete"></a>
# **KVv2Delete**
> void KVv2Delete (string path, string secretMountPath = "secret", TimeSpan? wrapTTL = null)

Write, Patch, Read, and Delete data in the Key-Value Store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KVv2DeleteExample
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
            var secretMountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Write, Patch, Read, and Delete data in the Key-Value Store.
                apiInstance.KVv2Delete(string path, string secretMountPath = "secret", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KVv2Delete: " + e.Message );
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
 **secretMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;secret&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="kvv2deletemetadata"></a>
# **KVv2DeleteMetadata**
> void KVv2DeleteMetadata (string path, string secretMountPath = "secret", TimeSpan? wrapTTL = null)

Configures settings for the KV store

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KVv2DeleteMetadataExample
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
            var secretMountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Configures settings for the KV store
                apiInstance.KVv2DeleteMetadata(string path, string secretMountPath = "secret", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KVv2DeleteMetadata: " + e.Message );
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
 **secretMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;secret&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="kvv2deleteversions"></a>
# **KVv2DeleteVersions**
> void KVv2DeleteVersions (KVv2DeleteVersionsRequest kVv2DeleteVersionsRequest, string path, string secretMountPath = "secret", TimeSpan? wrapTTL = null)

Marks one or more versions as deleted in the KV store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KVv2DeleteVersionsExample
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
            var kVv2DeleteVersionsRequest = new KVv2DeleteVersionsRequest(); // KVv2DeleteVersionsRequest | 
            var secretMountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Marks one or more versions as deleted in the KV store.
                apiInstance.KVv2DeleteVersions(KVv2DeleteVersionsRequest kVv2DeleteVersionsRequest, string path, string secretMountPath = "secret", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KVv2DeleteVersions: " + e.Message );
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
 **kVv2DeleteVersionsRequest** | [**KVv2DeleteVersionsRequest**](KVv2DeleteVersionsRequest.md)|  | 
 **secretMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;secret&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="kvv2destroyversions"></a>
# **KVv2DestroyVersions**
> void KVv2DestroyVersions (KVv2DestroyVersionsRequest kVv2DestroyVersionsRequest, string path, string secretMountPath = "secret", TimeSpan? wrapTTL = null)

Permanently removes one or more versions in the KV store

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KVv2DestroyVersionsExample
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
            var kVv2DestroyVersionsRequest = new KVv2DestroyVersionsRequest(); // KVv2DestroyVersionsRequest | 
            var secretMountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Permanently removes one or more versions in the KV store
                apiInstance.KVv2DestroyVersions(KVv2DestroyVersionsRequest kVv2DestroyVersionsRequest, string path, string secretMountPath = "secret", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KVv2DestroyVersions: " + e.Message );
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
 **kVv2DestroyVersionsRequest** | [**KVv2DestroyVersionsRequest**](KVv2DestroyVersionsRequest.md)|  | 
 **secretMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;secret&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="kvv2read"></a>
# **KVv2Read**
> void KVv2Read (string path, string secretMountPath = "secret", TimeSpan? wrapTTL = null)

Write, Patch, Read, and Delete data in the Key-Value Store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KVv2ReadExample
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
            var secretMountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Write, Patch, Read, and Delete data in the Key-Value Store.
                apiInstance.KVv2Read(string path, string secretMountPath = "secret", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KVv2Read: " + e.Message );
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
 **secretMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;secret&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="kvv2readconfig"></a>
# **KVv2ReadConfig**
> void KVv2ReadConfig (string secretMountPath = "secret", TimeSpan? wrapTTL = null)

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
    public class KVv2ReadConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var secretMountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Read the backend level settings.
                apiInstance.KVv2ReadConfig(string secretMountPath = "secret", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KVv2ReadConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **secretMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;secret&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="kvv2readmetadata"></a>
# **KVv2ReadMetadata**
> void KVv2ReadMetadata (string path, string secretMountPath = "secret", string list = default(string), TimeSpan? wrapTTL = null)

Configures settings for the KV store

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KVv2ReadMetadataExample
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
            var secretMountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")
            var list = "list_example";  // string | Return a list if `true` (optional) 

            try
            {
                // Configures settings for the KV store
                apiInstance.KVv2ReadMetadata(string path, string secretMountPath = "secret", string list = default(string), TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KVv2ReadMetadata: " + e.Message );
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
 **secretMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;secret&quot;]
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

<a name="kvv2readsubkeys"></a>
# **KVv2ReadSubkeys**
> void KVv2ReadSubkeys (string path, string secretMountPath = "secret", TimeSpan? wrapTTL = null)

Read the structure of a secret entry from the Key-Value store with the values removed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KVv2ReadSubkeysExample
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
            var secretMountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Read the structure of a secret entry from the Key-Value store with the values removed.
                apiInstance.KVv2ReadSubkeys(string path, string secretMountPath = "secret", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KVv2ReadSubkeys: " + e.Message );
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
 **secretMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;secret&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="kvv2undeleteversions"></a>
# **KVv2UndeleteVersions**
> void KVv2UndeleteVersions (KVv2UndeleteVersionsRequest kVv2UndeleteVersionsRequest, string path, string secretMountPath = "secret", TimeSpan? wrapTTL = null)

Undeletes one or more versions from the KV store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KVv2UndeleteVersionsExample
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
            var kVv2UndeleteVersionsRequest = new KVv2UndeleteVersionsRequest(); // KVv2UndeleteVersionsRequest | 
            var secretMountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Undeletes one or more versions from the KV store.
                apiInstance.KVv2UndeleteVersions(KVv2UndeleteVersionsRequest kVv2UndeleteVersionsRequest, string path, string secretMountPath = "secret", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KVv2UndeleteVersions: " + e.Message );
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
 **kVv2UndeleteVersionsRequest** | [**KVv2UndeleteVersionsRequest**](KVv2UndeleteVersionsRequest.md)|  | 
 **secretMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;secret&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="kvv2write"></a>
# **KVv2Write**
> void KVv2Write (KVv2WriteRequest kVv2WriteRequest, string path, string secretMountPath = "secret", TimeSpan? wrapTTL = null)

Write, Patch, Read, and Delete data in the Key-Value Store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KVv2WriteExample
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
            var kVv2WriteRequest = new KVv2WriteRequest(); // KVv2WriteRequest | 
            var secretMountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Write, Patch, Read, and Delete data in the Key-Value Store.
                apiInstance.KVv2Write(KVv2WriteRequest kVv2WriteRequest, string path, string secretMountPath = "secret", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KVv2Write: " + e.Message );
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
 **kVv2WriteRequest** | [**KVv2WriteRequest**](KVv2WriteRequest.md)|  | 
 **secretMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;secret&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="kvv2writeconfig"></a>
# **KVv2WriteConfig**
> void KVv2WriteConfig (KVv2WriteConfigRequest kVv2WriteConfigRequest, string secretMountPath = "secret", TimeSpan? wrapTTL = null)

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
    public class KVv2WriteConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var kVv2WriteConfigRequest = new KVv2WriteConfigRequest(); // KVv2WriteConfigRequest | 
            var secretMountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Configure backend level settings that are applied to every key in the key-value store.
                apiInstance.KVv2WriteConfig(KVv2WriteConfigRequest kVv2WriteConfigRequest, string secretMountPath = "secret", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KVv2WriteConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kVv2WriteConfigRequest** | [**KVv2WriteConfigRequest**](KVv2WriteConfigRequest.md)|  | 
 **secretMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;secret&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="kvv2writemetadata"></a>
# **KVv2WriteMetadata**
> void KVv2WriteMetadata (KVv2WriteMetadataRequest kVv2WriteMetadataRequest, string path, string secretMountPath = "secret", TimeSpan? wrapTTL = null)

Configures settings for the KV store

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KVv2WriteMetadataExample
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
            var kVv2WriteMetadataRequest = new KVv2WriteMetadataRequest(); // KVv2WriteMetadataRequest | 
            var secretMountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Configures settings for the KV store
                apiInstance.KVv2WriteMetadata(KVv2WriteMetadataRequest kVv2WriteMetadataRequest, string path, string secretMountPath = "secret", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KVv2WriteMetadata: " + e.Message );
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
 **kVv2WriteMetadataRequest** | [**KVv2WriteMetadataRequest**](KVv2WriteMetadataRequest.md)|  | 
 **secretMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;secret&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="kubernetesdeleteconfig"></a>
# **KubernetesDeleteConfig**
> void KubernetesDeleteConfig (string kubernetesMountPath = "kubernetes", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KubernetesDeleteConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                apiInstance.KubernetesDeleteConfig(string kubernetesMountPath = "kubernetes", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KubernetesDeleteConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="kubernetesdeleterole"></a>
# **KubernetesDeleteRole**
> void KubernetesDeleteRole (string name, string kubernetesMountPath = "kubernetes", TimeSpan? wrapTTL = null)



### Example
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
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                apiInstance.KubernetesDeleteRole(string name, string kubernetesMountPath = "kubernetes", TimeSpan? wrapTTL = null);
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

<a name="kuberneteslistroles"></a>
# **KubernetesListRoles**
> void KubernetesListRoles (string kubernetesMountPath = "kubernetes", TimeSpan? wrapTTL = null)



### Example
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
            var list = "true";  // string | Must be set to `true`
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                apiInstance.KubernetesListRoles(string kubernetesMountPath = "kubernetes", TimeSpan? wrapTTL = null);
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

<a name="kubernetesreadconfig"></a>
# **KubernetesReadConfig**
> void KubernetesReadConfig (string kubernetesMountPath = "kubernetes", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KubernetesReadConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                apiInstance.KubernetesReadConfig(string kubernetesMountPath = "kubernetes", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KubernetesReadConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="kubernetesreadrole"></a>
# **KubernetesReadRole**
> void KubernetesReadRole (string name, string kubernetesMountPath = "kubernetes", TimeSpan? wrapTTL = null)



### Example
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
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                apiInstance.KubernetesReadRole(string name, string kubernetesMountPath = "kubernetes", TimeSpan? wrapTTL = null);
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

<a name="kuberneteswriteconfig"></a>
# **KubernetesWriteConfig**
> void KubernetesWriteConfig (KubernetesWriteConfigRequest kubernetesWriteConfigRequest, string kubernetesMountPath = "kubernetes", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KubernetesWriteConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var kubernetesWriteConfigRequest = new KubernetesWriteConfigRequest(); // KubernetesWriteConfigRequest | 
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                apiInstance.KubernetesWriteConfig(KubernetesWriteConfigRequest kubernetesWriteConfigRequest, string kubernetesMountPath = "kubernetes", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KubernetesWriteConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kubernetesWriteConfigRequest** | [**KubernetesWriteConfigRequest**](KubernetesWriteConfigRequest.md)|  | 
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

<a name="kuberneteswritecredentials"></a>
# **KubernetesWriteCredentials**
> void KubernetesWriteCredentials (KubernetesWriteCredentialsRequest kubernetesWriteCredentialsRequest, string name, string kubernetesMountPath = "kubernetes", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class KubernetesWriteCredentialsExample
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
            var kubernetesWriteCredentialsRequest = new KubernetesWriteCredentialsRequest(); // KubernetesWriteCredentialsRequest | 
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                apiInstance.KubernetesWriteCredentials(KubernetesWriteCredentialsRequest kubernetesWriteCredentialsRequest, string name, string kubernetesMountPath = "kubernetes", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.KubernetesWriteCredentials: " + e.Message );
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
 **kubernetesWriteCredentialsRequest** | [**KubernetesWriteCredentialsRequest**](KubernetesWriteCredentialsRequest.md)|  | 
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

<a name="kuberneteswriterole"></a>
# **KubernetesWriteRole**
> void KubernetesWriteRole (KubernetesWriteRoleRequest kubernetesWriteRoleRequest, string name, string kubernetesMountPath = "kubernetes", TimeSpan? wrapTTL = null)



### Example
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
            var kubernetesWriteRoleRequest = new KubernetesWriteRoleRequest(); // KubernetesWriteRoleRequest | 
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                apiInstance.KubernetesWriteRole(KubernetesWriteRoleRequest kubernetesWriteRoleRequest, string name, string kubernetesMountPath = "kubernetes", TimeSpan? wrapTTL = null);
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
 **kubernetesWriteRoleRequest** | [**KubernetesWriteRoleRequest**](KubernetesWriteRoleRequest.md)|  | 
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

<a name="ldapcheckinlibrary"></a>
# **LDAPCheckInLibrary**
> void LDAPCheckInLibrary (LDAPCheckInLibraryRequest lDAPCheckInLibraryRequest, string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null)

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
    public class LDAPCheckInLibraryExample
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
            var lDAPCheckInLibraryRequest = new LDAPCheckInLibraryRequest(); // LDAPCheckInLibraryRequest | 
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                // Check service accounts in to the library.
                apiInstance.LDAPCheckInLibrary(LDAPCheckInLibraryRequest lDAPCheckInLibraryRequest, string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LDAPCheckInLibrary: " + e.Message );
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
 **lDAPCheckInLibraryRequest** | [**LDAPCheckInLibraryRequest**](LDAPCheckInLibraryRequest.md)|  | 
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

<a name="ldapcheckinmanagelibrary"></a>
# **LDAPCheckInManageLibrary**
> void LDAPCheckInManageLibrary (LDAPCheckInManageLibraryRequest lDAPCheckInManageLibraryRequest, string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null)

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
    public class LDAPCheckInManageLibraryExample
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
            var lDAPCheckInManageLibraryRequest = new LDAPCheckInManageLibraryRequest(); // LDAPCheckInManageLibraryRequest | 
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                // Check service accounts in to the library.
                apiInstance.LDAPCheckInManageLibrary(LDAPCheckInManageLibraryRequest lDAPCheckInManageLibraryRequest, string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LDAPCheckInManageLibrary: " + e.Message );
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
 **lDAPCheckInManageLibraryRequest** | [**LDAPCheckInManageLibraryRequest**](LDAPCheckInManageLibraryRequest.md)|  | 
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

<a name="ldapcheckoutlibrary"></a>
# **LDAPCheckOutLibrary**
> void LDAPCheckOutLibrary (LDAPCheckOutLibraryRequest lDAPCheckOutLibraryRequest, string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null)

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
    public class LDAPCheckOutLibraryExample
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
            var lDAPCheckOutLibraryRequest = new LDAPCheckOutLibraryRequest(); // LDAPCheckOutLibraryRequest | 
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                // Check a service account out from the library.
                apiInstance.LDAPCheckOutLibrary(LDAPCheckOutLibraryRequest lDAPCheckOutLibraryRequest, string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LDAPCheckOutLibrary: " + e.Message );
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
 **lDAPCheckOutLibraryRequest** | [**LDAPCheckOutLibraryRequest**](LDAPCheckOutLibraryRequest.md)|  | 
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

<a name="ldapdeleteconfig"></a>
# **LDAPDeleteConfig**
> void LDAPDeleteConfig (string ldapMountPath = "ldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LDAPDeleteConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.LDAPDeleteConfig(string ldapMountPath = "ldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LDAPDeleteConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ldapdeletelibrary"></a>
# **LDAPDeleteLibrary**
> void LDAPDeleteLibrary (string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null)

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
    public class LDAPDeleteLibraryExample
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
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                // Delete a library set.
                apiInstance.LDAPDeleteLibrary(string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LDAPDeleteLibrary: " + e.Message );
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

<a name="ldapdeleterole"></a>
# **LDAPDeleteRole**
> void LDAPDeleteRole (string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LDAPDeleteRoleExample
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
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.LDAPDeleteRole(string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LDAPDeleteRole: " + e.Message );
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

<a name="ldapdeletestaticrole"></a>
# **LDAPDeleteStaticRole**
> void LDAPDeleteStaticRole (string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LDAPDeleteStaticRoleExample
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
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.LDAPDeleteStaticRole(string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LDAPDeleteStaticRole: " + e.Message );
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

<a name="ldaplistlibraries"></a>
# **LDAPListLibraries**
> void LDAPListLibraries (string ldapMountPath = "ldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LDAPListLibrariesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.LDAPListLibraries(string ldapMountPath = "ldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LDAPListLibraries: " + e.Message );
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

<a name="ldaplistroles"></a>
# **LDAPListRoles**
> void LDAPListRoles (string ldapMountPath = "ldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LDAPListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.LDAPListRoles(string ldapMountPath = "ldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LDAPListRoles: " + e.Message );
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

<a name="ldapliststaticroles"></a>
# **LDAPListStaticRoles**
> void LDAPListStaticRoles (string ldapMountPath = "ldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LDAPListStaticRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.LDAPListStaticRoles(string ldapMountPath = "ldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LDAPListStaticRoles: " + e.Message );
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

<a name="ldapreadconfig"></a>
# **LDAPReadConfig**
> void LDAPReadConfig (string ldapMountPath = "ldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LDAPReadConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.LDAPReadConfig(string ldapMountPath = "ldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LDAPReadConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="ldapreadcredentials"></a>
# **LDAPReadCredentials**
> void LDAPReadCredentials (string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LDAPReadCredentialsExample
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
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.LDAPReadCredentials(string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LDAPReadCredentials: " + e.Message );
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

<a name="ldapreadlibrary"></a>
# **LDAPReadLibrary**
> void LDAPReadLibrary (string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null)

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
    public class LDAPReadLibraryExample
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
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                // Read a library set.
                apiInstance.LDAPReadLibrary(string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LDAPReadLibrary: " + e.Message );
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

<a name="ldapreadlibrarystatus"></a>
# **LDAPReadLibraryStatus**
> void LDAPReadLibraryStatus (string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null)

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
    public class LDAPReadLibraryStatusExample
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
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                // Check the status of the service accounts in a library set.
                apiInstance.LDAPReadLibraryStatus(string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LDAPReadLibraryStatus: " + e.Message );
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

<a name="ldapreadrole"></a>
# **LDAPReadRole**
> void LDAPReadRole (string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LDAPReadRoleExample
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
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.LDAPReadRole(string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LDAPReadRole: " + e.Message );
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

<a name="ldapreadstaticcredentials"></a>
# **LDAPReadStaticCredentials**
> void LDAPReadStaticCredentials (string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LDAPReadStaticCredentialsExample
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
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.LDAPReadStaticCredentials(string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LDAPReadStaticCredentials: " + e.Message );
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

<a name="ldapreadstaticrole"></a>
# **LDAPReadStaticRole**
> void LDAPReadStaticRole (string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LDAPReadStaticRoleExample
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
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.LDAPReadStaticRole(string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LDAPReadStaticRole: " + e.Message );
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

<a name="ldaprotaterole"></a>
# **LDAPRotateRole**
> void LDAPRotateRole (string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LDAPRotateRoleExample
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
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.LDAPRotateRole(string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LDAPRotateRole: " + e.Message );
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

<a name="ldaprotateroot"></a>
# **LDAPRotateRoot**
> void LDAPRotateRoot (string ldapMountPath = "ldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LDAPRotateRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.LDAPRotateRoot(string ldapMountPath = "ldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LDAPRotateRoot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="ldapwriteconfig"></a>
# **LDAPWriteConfig**
> void LDAPWriteConfig (LDAPWriteConfigRequest lDAPWriteConfigRequest, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LDAPWriteConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var lDAPWriteConfigRequest = new LDAPWriteConfigRequest(); // LDAPWriteConfigRequest | 
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.LDAPWriteConfig(LDAPWriteConfigRequest lDAPWriteConfigRequest, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LDAPWriteConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lDAPWriteConfigRequest** | [**LDAPWriteConfigRequest**](LDAPWriteConfigRequest.md)|  | 
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

<a name="ldapwritelibrary"></a>
# **LDAPWriteLibrary**
> void LDAPWriteLibrary (LDAPWriteLibraryRequest lDAPWriteLibraryRequest, string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null)

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
    public class LDAPWriteLibraryExample
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
            var lDAPWriteLibraryRequest = new LDAPWriteLibraryRequest(); // LDAPWriteLibraryRequest | 
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                // Update a library set.
                apiInstance.LDAPWriteLibrary(LDAPWriteLibraryRequest lDAPWriteLibraryRequest, string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LDAPWriteLibrary: " + e.Message );
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
 **lDAPWriteLibraryRequest** | [**LDAPWriteLibraryRequest**](LDAPWriteLibraryRequest.md)|  | 
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

<a name="ldapwriterole"></a>
# **LDAPWriteRole**
> void LDAPWriteRole (LDAPWriteRoleRequest lDAPWriteRoleRequest, string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LDAPWriteRoleExample
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
            var lDAPWriteRoleRequest = new LDAPWriteRoleRequest(); // LDAPWriteRoleRequest | 
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.LDAPWriteRole(LDAPWriteRoleRequest lDAPWriteRoleRequest, string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LDAPWriteRole: " + e.Message );
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
 **lDAPWriteRoleRequest** | [**LDAPWriteRoleRequest**](LDAPWriteRoleRequest.md)|  | 
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

<a name="ldapwritestaticrole"></a>
# **LDAPWriteStaticRole**
> void LDAPWriteStaticRole (LDAPWriteStaticRoleRequest lDAPWriteStaticRoleRequest, string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class LDAPWriteStaticRoleExample
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
            var lDAPWriteStaticRoleRequest = new LDAPWriteStaticRoleRequest(); // LDAPWriteStaticRoleRequest | 
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.LDAPWriteStaticRole(LDAPWriteStaticRoleRequest lDAPWriteStaticRoleRequest, string name, string ldapMountPath = "ldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.LDAPWriteStaticRole: " + e.Message );
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
 **lDAPWriteStaticRoleRequest** | [**LDAPWriteStaticRoleRequest**](LDAPWriteStaticRoleRequest.md)|  | 
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

<a name="mongodbatlasdeleterole"></a>
# **MongoDBAtlasDeleteRole**
> void MongoDBAtlasDeleteRole (string name, string mongodbatlasMountPath = "mongodbatlas", TimeSpan? wrapTTL = null)

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
    public class MongoDBAtlasDeleteRoleExample
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
            var mongodbatlasMountPath = "\"mongodbatlas\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "mongodbatlas")

            try
            {
                // Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
                apiInstance.MongoDBAtlasDeleteRole(string name, string mongodbatlasMountPath = "mongodbatlas", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.MongoDBAtlasDeleteRole: " + e.Message );
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
 **mongodbatlasMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;mongodbatlas&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mongodbatlaslistroles"></a>
# **MongoDBAtlasListRoles**
> void MongoDBAtlasListRoles (string mongodbatlasMountPath = "mongodbatlas", TimeSpan? wrapTTL = null)

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
    public class MongoDBAtlasListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var mongodbatlasMountPath = "\"mongodbatlas\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "mongodbatlas")

            try
            {
                // List the existing roles in this backend
                apiInstance.MongoDBAtlasListRoles(string mongodbatlasMountPath = "mongodbatlas", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.MongoDBAtlasListRoles: " + e.Message );
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
 **mongodbatlasMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;mongodbatlas&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mongodbatlasreadconfig"></a>
# **MongoDBAtlasReadConfig**
> void MongoDBAtlasReadConfig (string mongodbatlasMountPath = "mongodbatlas", TimeSpan? wrapTTL = null)

Configure the  credentials that are used to manage Database Users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MongoDBAtlasReadConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mongodbatlasMountPath = "\"mongodbatlas\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "mongodbatlas")

            try
            {
                // Configure the  credentials that are used to manage Database Users.
                apiInstance.MongoDBAtlasReadConfig(string mongodbatlasMountPath = "mongodbatlas", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.MongoDBAtlasReadConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mongodbatlasMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;mongodbatlas&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mongodbatlasreadcredentials"></a>
# **MongoDBAtlasReadCredentials**
> void MongoDBAtlasReadCredentials (string name, string mongodbatlasMountPath = "mongodbatlas", TimeSpan? wrapTTL = null)

Generate MongoDB Atlas Programmatic API from a specific Vault role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MongoDBAtlasReadCredentialsExample
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
            var mongodbatlasMountPath = "\"mongodbatlas\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "mongodbatlas")

            try
            {
                // Generate MongoDB Atlas Programmatic API from a specific Vault role.
                apiInstance.MongoDBAtlasReadCredentials(string name, string mongodbatlasMountPath = "mongodbatlas", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.MongoDBAtlasReadCredentials: " + e.Message );
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
 **mongodbatlasMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;mongodbatlas&quot;]

### Return type

void (empty response body)

### Authorization

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
# **MongoDBAtlasReadRole**
> void MongoDBAtlasReadRole (string name, string mongodbatlasMountPath = "mongodbatlas", TimeSpan? wrapTTL = null)

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
    public class MongoDBAtlasReadRoleExample
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
            var mongodbatlasMountPath = "\"mongodbatlas\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "mongodbatlas")

            try
            {
                // Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
                apiInstance.MongoDBAtlasReadRole(string name, string mongodbatlasMountPath = "mongodbatlas", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.MongoDBAtlasReadRole: " + e.Message );
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
 **mongodbatlasMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;mongodbatlas&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mongodbatlaswriteconfig"></a>
# **MongoDBAtlasWriteConfig**
> void MongoDBAtlasWriteConfig (MongoDBAtlasWriteConfigRequest mongoDBAtlasWriteConfigRequest, string mongodbatlasMountPath = "mongodbatlas", TimeSpan? wrapTTL = null)

Configure the  credentials that are used to manage Database Users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MongoDBAtlasWriteConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mongoDBAtlasWriteConfigRequest = new MongoDBAtlasWriteConfigRequest(); // MongoDBAtlasWriteConfigRequest | 
            var mongodbatlasMountPath = "\"mongodbatlas\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "mongodbatlas")

            try
            {
                // Configure the  credentials that are used to manage Database Users.
                apiInstance.MongoDBAtlasWriteConfig(MongoDBAtlasWriteConfigRequest mongoDBAtlasWriteConfigRequest, string mongodbatlasMountPath = "mongodbatlas", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.MongoDBAtlasWriteConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mongoDBAtlasWriteConfigRequest** | [**MongoDBAtlasWriteConfigRequest**](MongoDBAtlasWriteConfigRequest.md)|  | 
 **mongodbatlasMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;mongodbatlas&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mongodbatlaswritecredentials"></a>
# **MongoDBAtlasWriteCredentials**
> void MongoDBAtlasWriteCredentials (string name, string mongodbatlasMountPath = "mongodbatlas", TimeSpan? wrapTTL = null)

Generate MongoDB Atlas Programmatic API from a specific Vault role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MongoDBAtlasWriteCredentialsExample
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
            var mongodbatlasMountPath = "\"mongodbatlas\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "mongodbatlas")

            try
            {
                // Generate MongoDB Atlas Programmatic API from a specific Vault role.
                apiInstance.MongoDBAtlasWriteCredentials(string name, string mongodbatlasMountPath = "mongodbatlas", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.MongoDBAtlasWriteCredentials: " + e.Message );
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
 **mongodbatlasMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;mongodbatlas&quot;]

### Return type

void (empty response body)

### Authorization

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
# **MongoDBAtlasWriteRole**
> void MongoDBAtlasWriteRole (MongoDBAtlasWriteRoleRequest mongoDBAtlasWriteRoleRequest, string name, string mongodbatlasMountPath = "mongodbatlas", TimeSpan? wrapTTL = null)

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
    public class MongoDBAtlasWriteRoleExample
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
            var mongoDBAtlasWriteRoleRequest = new MongoDBAtlasWriteRoleRequest(); // MongoDBAtlasWriteRoleRequest | 
            var mongodbatlasMountPath = "\"mongodbatlas\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "mongodbatlas")

            try
            {
                // Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
                apiInstance.MongoDBAtlasWriteRole(MongoDBAtlasWriteRoleRequest mongoDBAtlasWriteRoleRequest, string name, string mongodbatlasMountPath = "mongodbatlas", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.MongoDBAtlasWriteRole: " + e.Message );
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
 **mongoDBAtlasWriteRoleRequest** | [**MongoDBAtlasWriteRoleRequest**](MongoDBAtlasWriteRoleRequest.md)|  | 
 **mongodbatlasMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;mongodbatlas&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="nomaddeleteaccessconfig"></a>
# **NomadDeleteAccessConfig**
> void NomadDeleteAccessConfig (string nomadMountPath = "nomad", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class NomadDeleteAccessConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var nomadMountPath = "\"nomad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "nomad")

            try
            {
                apiInstance.NomadDeleteAccessConfig(string nomadMountPath = "nomad", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.NomadDeleteAccessConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nomadMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;nomad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="nomaddeleteleaseconfig"></a>
# **NomadDeleteLeaseConfig**
> void NomadDeleteLeaseConfig (string nomadMountPath = "nomad", TimeSpan? wrapTTL = null)

Configure the lease parameters for generated tokens

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class NomadDeleteLeaseConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var nomadMountPath = "\"nomad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "nomad")

            try
            {
                // Configure the lease parameters for generated tokens
                apiInstance.NomadDeleteLeaseConfig(string nomadMountPath = "nomad", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.NomadDeleteLeaseConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nomadMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;nomad&quot;]

### Return type

void (empty response body)

### Authorization

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
> void NomadDeleteRole (string name, string nomadMountPath = "nomad", TimeSpan? wrapTTL = null)



### Example
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
            var nomadMountPath = "\"nomad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "nomad")

            try
            {
                apiInstance.NomadDeleteRole(string name, string nomadMountPath = "nomad", TimeSpan? wrapTTL = null);
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
 **nomadMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;nomad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="nomadlistroles"></a>
# **NomadListRoles**
> void NomadListRoles (string nomadMountPath = "nomad", TimeSpan? wrapTTL = null)



### Example
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
            var list = "true";  // string | Must be set to `true`
            var nomadMountPath = "\"nomad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "nomad")

            try
            {
                apiInstance.NomadListRoles(string nomadMountPath = "nomad", TimeSpan? wrapTTL = null);
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
 **list** | **string**| Must be set to &#x60;true&#x60; | 
 **nomadMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;nomad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="nomadreadaccessconfig"></a>
# **NomadReadAccessConfig**
> void NomadReadAccessConfig (string nomadMountPath = "nomad", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class NomadReadAccessConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var nomadMountPath = "\"nomad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "nomad")

            try
            {
                apiInstance.NomadReadAccessConfig(string nomadMountPath = "nomad", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.NomadReadAccessConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nomadMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;nomad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="nomadreadcredentials"></a>
# **NomadReadCredentials**
> void NomadReadCredentials (string name, string nomadMountPath = "nomad", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class NomadReadCredentialsExample
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
            var nomadMountPath = "\"nomad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "nomad")

            try
            {
                apiInstance.NomadReadCredentials(string name, string nomadMountPath = "nomad", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.NomadReadCredentials: " + e.Message );
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
 **nomadMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;nomad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="nomadreadleaseconfig"></a>
# **NomadReadLeaseConfig**
> void NomadReadLeaseConfig (string nomadMountPath = "nomad", TimeSpan? wrapTTL = null)

Configure the lease parameters for generated tokens

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class NomadReadLeaseConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var nomadMountPath = "\"nomad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "nomad")

            try
            {
                // Configure the lease parameters for generated tokens
                apiInstance.NomadReadLeaseConfig(string nomadMountPath = "nomad", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.NomadReadLeaseConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nomadMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;nomad&quot;]

### Return type

void (empty response body)

### Authorization

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
> void NomadReadRole (string name, string nomadMountPath = "nomad", TimeSpan? wrapTTL = null)



### Example
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
            var nomadMountPath = "\"nomad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "nomad")

            try
            {
                apiInstance.NomadReadRole(string name, string nomadMountPath = "nomad", TimeSpan? wrapTTL = null);
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
 **nomadMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;nomad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="nomadwriteaccessconfig"></a>
# **NomadWriteAccessConfig**
> void NomadWriteAccessConfig (NomadWriteAccessConfigRequest nomadWriteAccessConfigRequest, string nomadMountPath = "nomad", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class NomadWriteAccessConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var nomadWriteAccessConfigRequest = new NomadWriteAccessConfigRequest(); // NomadWriteAccessConfigRequest | 
            var nomadMountPath = "\"nomad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "nomad")

            try
            {
                apiInstance.NomadWriteAccessConfig(NomadWriteAccessConfigRequest nomadWriteAccessConfigRequest, string nomadMountPath = "nomad", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.NomadWriteAccessConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nomadWriteAccessConfigRequest** | [**NomadWriteAccessConfigRequest**](NomadWriteAccessConfigRequest.md)|  | 
 **nomadMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;nomad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="nomadwriteleaseconfig"></a>
# **NomadWriteLeaseConfig**
> void NomadWriteLeaseConfig (NomadWriteLeaseConfigRequest nomadWriteLeaseConfigRequest, string nomadMountPath = "nomad", TimeSpan? wrapTTL = null)

Configure the lease parameters for generated tokens

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class NomadWriteLeaseConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var nomadWriteLeaseConfigRequest = new NomadWriteLeaseConfigRequest(); // NomadWriteLeaseConfigRequest | 
            var nomadMountPath = "\"nomad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "nomad")

            try
            {
                // Configure the lease parameters for generated tokens
                apiInstance.NomadWriteLeaseConfig(NomadWriteLeaseConfigRequest nomadWriteLeaseConfigRequest, string nomadMountPath = "nomad", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.NomadWriteLeaseConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nomadWriteLeaseConfigRequest** | [**NomadWriteLeaseConfigRequest**](NomadWriteLeaseConfigRequest.md)|  | 
 **nomadMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;nomad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="nomadwriterole"></a>
# **NomadWriteRole**
> void NomadWriteRole (NomadWriteRoleRequest nomadWriteRoleRequest, string name, string nomadMountPath = "nomad", TimeSpan? wrapTTL = null)



### Example
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
            var nomadWriteRoleRequest = new NomadWriteRoleRequest(); // NomadWriteRoleRequest | 
            var nomadMountPath = "\"nomad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "nomad")

            try
            {
                apiInstance.NomadWriteRole(NomadWriteRoleRequest nomadWriteRoleRequest, string name, string nomadMountPath = "nomad", TimeSpan? wrapTTL = null);
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
 **nomadWriteRoleRequest** | [**NomadWriteRoleRequest**](NomadWriteRoleRequest.md)|  | 
 **nomadMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;nomad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="openldapcheckinlibrary"></a>
# **OpenLDAPCheckInLibrary**
> void OpenLDAPCheckInLibrary (OpenLDAPCheckInLibraryRequest openLDAPCheckInLibraryRequest, string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null)

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
    public class OpenLDAPCheckInLibraryExample
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
            var openLDAPCheckInLibraryRequest = new OpenLDAPCheckInLibraryRequest(); // OpenLDAPCheckInLibraryRequest | 
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                // Check service accounts in to the library.
                apiInstance.OpenLDAPCheckInLibrary(OpenLDAPCheckInLibraryRequest openLDAPCheckInLibraryRequest, string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.OpenLDAPCheckInLibrary: " + e.Message );
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
 **openLDAPCheckInLibraryRequest** | [**OpenLDAPCheckInLibraryRequest**](OpenLDAPCheckInLibraryRequest.md)|  | 
 **openldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;openldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="openldapcheckinmanagelibrary"></a>
# **OpenLDAPCheckInManageLibrary**
> void OpenLDAPCheckInManageLibrary (OpenLDAPCheckInManageLibraryRequest openLDAPCheckInManageLibraryRequest, string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null)

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
    public class OpenLDAPCheckInManageLibraryExample
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
            var openLDAPCheckInManageLibraryRequest = new OpenLDAPCheckInManageLibraryRequest(); // OpenLDAPCheckInManageLibraryRequest | 
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                // Check service accounts in to the library.
                apiInstance.OpenLDAPCheckInManageLibrary(OpenLDAPCheckInManageLibraryRequest openLDAPCheckInManageLibraryRequest, string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.OpenLDAPCheckInManageLibrary: " + e.Message );
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
 **openLDAPCheckInManageLibraryRequest** | [**OpenLDAPCheckInManageLibraryRequest**](OpenLDAPCheckInManageLibraryRequest.md)|  | 
 **openldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;openldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="openldapcheckoutlibrary"></a>
# **OpenLDAPCheckOutLibrary**
> void OpenLDAPCheckOutLibrary (OpenLDAPCheckOutLibraryRequest openLDAPCheckOutLibraryRequest, string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null)

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
    public class OpenLDAPCheckOutLibraryExample
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
            var openLDAPCheckOutLibraryRequest = new OpenLDAPCheckOutLibraryRequest(); // OpenLDAPCheckOutLibraryRequest | 
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                // Check a service account out from the library.
                apiInstance.OpenLDAPCheckOutLibrary(OpenLDAPCheckOutLibraryRequest openLDAPCheckOutLibraryRequest, string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.OpenLDAPCheckOutLibrary: " + e.Message );
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
 **openLDAPCheckOutLibraryRequest** | [**OpenLDAPCheckOutLibraryRequest**](OpenLDAPCheckOutLibraryRequest.md)|  | 
 **openldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;openldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="openldapdeleteconfig"></a>
# **OpenLDAPDeleteConfig**
> void OpenLDAPDeleteConfig (string openldapMountPath = "openldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OpenLDAPDeleteConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.OpenLDAPDeleteConfig(string openldapMountPath = "openldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.OpenLDAPDeleteConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **openldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;openldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="openldapdeletelibrary"></a>
# **OpenLDAPDeleteLibrary**
> void OpenLDAPDeleteLibrary (string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null)

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
    public class OpenLDAPDeleteLibraryExample
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
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                // Delete a library set.
                apiInstance.OpenLDAPDeleteLibrary(string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.OpenLDAPDeleteLibrary: " + e.Message );
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
 **openldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;openldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="openldapdeleterole"></a>
# **OpenLDAPDeleteRole**
> void OpenLDAPDeleteRole (string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OpenLDAPDeleteRoleExample
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
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.OpenLDAPDeleteRole(string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.OpenLDAPDeleteRole: " + e.Message );
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
 **openldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;openldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="openldapdeletestaticrole"></a>
# **OpenLDAPDeleteStaticRole**
> void OpenLDAPDeleteStaticRole (string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OpenLDAPDeleteStaticRoleExample
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
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.OpenLDAPDeleteStaticRole(string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.OpenLDAPDeleteStaticRole: " + e.Message );
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
 **openldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;openldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="openldaplistlibraries"></a>
# **OpenLDAPListLibraries**
> void OpenLDAPListLibraries (string openldapMountPath = "openldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OpenLDAPListLibrariesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.OpenLDAPListLibraries(string openldapMountPath = "openldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.OpenLDAPListLibraries: " + e.Message );
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
 **openldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;openldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="openldaplistroles"></a>
# **OpenLDAPListRoles**
> void OpenLDAPListRoles (string openldapMountPath = "openldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OpenLDAPListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.OpenLDAPListRoles(string openldapMountPath = "openldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.OpenLDAPListRoles: " + e.Message );
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
 **openldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;openldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="openldapliststaticroles"></a>
# **OpenLDAPListStaticRoles**
> void OpenLDAPListStaticRoles (string openldapMountPath = "openldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OpenLDAPListStaticRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.OpenLDAPListStaticRoles(string openldapMountPath = "openldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.OpenLDAPListStaticRoles: " + e.Message );
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
 **openldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;openldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="openldapreadconfig"></a>
# **OpenLDAPReadConfig**
> void OpenLDAPReadConfig (string openldapMountPath = "openldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OpenLDAPReadConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.OpenLDAPReadConfig(string openldapMountPath = "openldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.OpenLDAPReadConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **openldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;openldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="openldapreadcredentials"></a>
# **OpenLDAPReadCredentials**
> void OpenLDAPReadCredentials (string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OpenLDAPReadCredentialsExample
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
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.OpenLDAPReadCredentials(string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.OpenLDAPReadCredentials: " + e.Message );
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
 **openldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;openldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="openldapreadlibrary"></a>
# **OpenLDAPReadLibrary**
> void OpenLDAPReadLibrary (string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null)

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
    public class OpenLDAPReadLibraryExample
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
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                // Read a library set.
                apiInstance.OpenLDAPReadLibrary(string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.OpenLDAPReadLibrary: " + e.Message );
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
 **openldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;openldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="openldapreadlibrarystatus"></a>
# **OpenLDAPReadLibraryStatus**
> void OpenLDAPReadLibraryStatus (string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null)

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
    public class OpenLDAPReadLibraryStatusExample
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
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                // Check the status of the service accounts in a library set.
                apiInstance.OpenLDAPReadLibraryStatus(string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.OpenLDAPReadLibraryStatus: " + e.Message );
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
 **openldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;openldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="openldapreadrole"></a>
# **OpenLDAPReadRole**
> void OpenLDAPReadRole (string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OpenLDAPReadRoleExample
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
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.OpenLDAPReadRole(string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.OpenLDAPReadRole: " + e.Message );
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
 **openldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;openldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="openldapreadstaticcredentials"></a>
# **OpenLDAPReadStaticCredentials**
> void OpenLDAPReadStaticCredentials (string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OpenLDAPReadStaticCredentialsExample
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
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.OpenLDAPReadStaticCredentials(string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.OpenLDAPReadStaticCredentials: " + e.Message );
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
 **openldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;openldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="openldapreadstaticrole"></a>
# **OpenLDAPReadStaticRole**
> void OpenLDAPReadStaticRole (string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OpenLDAPReadStaticRoleExample
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
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.OpenLDAPReadStaticRole(string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.OpenLDAPReadStaticRole: " + e.Message );
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
 **openldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;openldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="openldaprotaterole"></a>
# **OpenLDAPRotateRole**
> void OpenLDAPRotateRole (string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OpenLDAPRotateRoleExample
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
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.OpenLDAPRotateRole(string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.OpenLDAPRotateRole: " + e.Message );
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
 **openldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;openldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="openldaprotateroot"></a>
# **OpenLDAPRotateRoot**
> void OpenLDAPRotateRoot (string openldapMountPath = "openldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OpenLDAPRotateRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.OpenLDAPRotateRoot(string openldapMountPath = "openldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.OpenLDAPRotateRoot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **openldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;openldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="openldapwriteconfig"></a>
# **OpenLDAPWriteConfig**
> void OpenLDAPWriteConfig (OpenLDAPWriteConfigRequest openLDAPWriteConfigRequest, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OpenLDAPWriteConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var openLDAPWriteConfigRequest = new OpenLDAPWriteConfigRequest(); // OpenLDAPWriteConfigRequest | 
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.OpenLDAPWriteConfig(OpenLDAPWriteConfigRequest openLDAPWriteConfigRequest, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.OpenLDAPWriteConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **openLDAPWriteConfigRequest** | [**OpenLDAPWriteConfigRequest**](OpenLDAPWriteConfigRequest.md)|  | 
 **openldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;openldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="openldapwritelibrary"></a>
# **OpenLDAPWriteLibrary**
> void OpenLDAPWriteLibrary (OpenLDAPWriteLibraryRequest openLDAPWriteLibraryRequest, string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null)

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
    public class OpenLDAPWriteLibraryExample
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
            var openLDAPWriteLibraryRequest = new OpenLDAPWriteLibraryRequest(); // OpenLDAPWriteLibraryRequest | 
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                // Update a library set.
                apiInstance.OpenLDAPWriteLibrary(OpenLDAPWriteLibraryRequest openLDAPWriteLibraryRequest, string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.OpenLDAPWriteLibrary: " + e.Message );
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
 **openLDAPWriteLibraryRequest** | [**OpenLDAPWriteLibraryRequest**](OpenLDAPWriteLibraryRequest.md)|  | 
 **openldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;openldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="openldapwriterole"></a>
# **OpenLDAPWriteRole**
> void OpenLDAPWriteRole (OpenLDAPWriteRoleRequest openLDAPWriteRoleRequest, string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OpenLDAPWriteRoleExample
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
            var openLDAPWriteRoleRequest = new OpenLDAPWriteRoleRequest(); // OpenLDAPWriteRoleRequest | 
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.OpenLDAPWriteRole(OpenLDAPWriteRoleRequest openLDAPWriteRoleRequest, string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.OpenLDAPWriteRole: " + e.Message );
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
 **openLDAPWriteRoleRequest** | [**OpenLDAPWriteRoleRequest**](OpenLDAPWriteRoleRequest.md)|  | 
 **openldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;openldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="openldapwritestaticrole"></a>
# **OpenLDAPWriteStaticRole**
> void OpenLDAPWriteStaticRole (OpenLDAPWriteStaticRoleRequest openLDAPWriteStaticRoleRequest, string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class OpenLDAPWriteStaticRoleExample
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
            var openLDAPWriteStaticRoleRequest = new OpenLDAPWriteStaticRoleRequest(); // OpenLDAPWriteStaticRoleRequest | 
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.OpenLDAPWriteStaticRole(OpenLDAPWriteStaticRoleRequest openLDAPWriteStaticRoleRequest, string name, string openldapMountPath = "openldap", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.OpenLDAPWriteStaticRole: " + e.Message );
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
 **openLDAPWriteStaticRoleRequest** | [**OpenLDAPWriteStaticRoleRequest**](OpenLDAPWriteStaticRoleRequest.md)|  | 
 **openldapMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;openldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkibundlewrite"></a>
# **PKIBundleWrite**
> void PKIBundleWrite (PKIBundleWriteRequest pKIBundleWriteRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIBundleWriteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pKIBundleWriteRequest = new PKIBundleWriteRequest(); // PKIBundleWriteRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIBundleWrite(PKIBundleWriteRequest pKIBundleWriteRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIBundleWrite: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pKIBundleWriteRequest** | [**PKIBundleWriteRequest**](PKIBundleWriteRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkideletekey"></a>
# **PKIDeleteKey**
> void PKIDeleteKey (string keyRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIDeleteKeyExample
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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIDeleteKey(string keyRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIDeleteKey: " + e.Message );
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
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkideleterole"></a>
# **PKIDeleteRole**
> void PKIDeleteRole (string name, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIDeleteRoleExample
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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIDeleteRole(string name, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIDeleteRole: " + e.Message );
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
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkideleteroot"></a>
# **PKIDeleteRoot**
> void PKIDeleteRoot (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIDeleteRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIDeleteRoot(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIDeleteRoot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkigenerateroot"></a>
# **PKIGenerateRoot**
> void PKIGenerateRoot (PKIGenerateRootRequest pKIGenerateRootRequest, string exported, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIGenerateRootExample
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
            var pKIGenerateRootRequest = new PKIGenerateRootRequest(); // PKIGenerateRootRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIGenerateRoot(PKIGenerateRootRequest pKIGenerateRootRequest, string exported, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIGenerateRoot: " + e.Message );
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
 **pKIGenerateRootRequest** | [**PKIGenerateRootRequest**](PKIGenerateRootRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiimportkeys"></a>
# **PKIImportKeys**
> void PKIImportKeys (PKIImportKeysRequest pKIImportKeysRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIImportKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pKIImportKeysRequest = new PKIImportKeysRequest(); // PKIImportKeysRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIImportKeys(PKIImportKeysRequest pKIImportKeysRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIImportKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pKIImportKeysRequest** | [**PKIImportKeysRequest**](PKIImportKeysRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiissuerissuerole"></a>
# **PKIIssuerIssueRole**
> void PKIIssuerIssueRole (PKIIssuerIssueRoleRequest pKIIssuerIssueRoleRequest, string issuerRef, string role, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIIssuerIssueRoleExample
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
            var pKIIssuerIssueRoleRequest = new PKIIssuerIssueRoleRequest(); // PKIIssuerIssueRoleRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIIssuerIssueRole(PKIIssuerIssueRoleRequest pKIIssuerIssueRoleRequest, string issuerRef, string role, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIIssuerIssueRole: " + e.Message );
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
 **pKIIssuerIssueRoleRequest** | [**PKIIssuerIssueRoleRequest**](PKIIssuerIssueRoleRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiissuerresigncrls"></a>
# **PKIIssuerResignCRLs**
> void PKIIssuerResignCRLs (PKIIssuerResignCRLsRequest pKIIssuerResignCRLsRequest, string issuerRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIIssuerResignCRLsExample
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
            var pKIIssuerResignCRLsRequest = new PKIIssuerResignCRLsRequest(); // PKIIssuerResignCRLsRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIIssuerResignCRLs(PKIIssuerResignCRLsRequest pKIIssuerResignCRLsRequest, string issuerRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIIssuerResignCRLs: " + e.Message );
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
 **pKIIssuerResignCRLsRequest** | [**PKIIssuerResignCRLsRequest**](PKIIssuerResignCRLsRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiissuerrevoke"></a>
# **PKIIssuerRevoke**
> void PKIIssuerRevoke (string issuerRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIIssuerRevokeExample
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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIIssuerRevoke(string issuerRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIIssuerRevoke: " + e.Message );
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
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiissuersignintermediate"></a>
# **PKIIssuerSignIntermediate**
> void PKIIssuerSignIntermediate (PKIIssuerSignIntermediateRequest pKIIssuerSignIntermediateRequest, string issuerRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIIssuerSignIntermediateExample
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
            var pKIIssuerSignIntermediateRequest = new PKIIssuerSignIntermediateRequest(); // PKIIssuerSignIntermediateRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIIssuerSignIntermediate(PKIIssuerSignIntermediateRequest pKIIssuerSignIntermediateRequest, string issuerRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIIssuerSignIntermediate: " + e.Message );
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
 **pKIIssuerSignIntermediateRequest** | [**PKIIssuerSignIntermediateRequest**](PKIIssuerSignIntermediateRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiissuersignrevocationlist"></a>
# **PKIIssuerSignRevocationList**
> void PKIIssuerSignRevocationList (PKIIssuerSignRevocationListRequest pKIIssuerSignRevocationListRequest, string issuerRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIIssuerSignRevocationListExample
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
            var pKIIssuerSignRevocationListRequest = new PKIIssuerSignRevocationListRequest(); // PKIIssuerSignRevocationListRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIIssuerSignRevocationList(PKIIssuerSignRevocationListRequest pKIIssuerSignRevocationListRequest, string issuerRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIIssuerSignRevocationList: " + e.Message );
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
 **pKIIssuerSignRevocationListRequest** | [**PKIIssuerSignRevocationListRequest**](PKIIssuerSignRevocationListRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiissuersignrole"></a>
# **PKIIssuerSignRole**
> void PKIIssuerSignRole (PKIIssuerSignRoleRequest pKIIssuerSignRoleRequest, string issuerRef, string role, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIIssuerSignRoleExample
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
            var pKIIssuerSignRoleRequest = new PKIIssuerSignRoleRequest(); // PKIIssuerSignRoleRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIIssuerSignRole(PKIIssuerSignRoleRequest pKIIssuerSignRoleRequest, string issuerRef, string role, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIIssuerSignRole: " + e.Message );
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
 **pKIIssuerSignRoleRequest** | [**PKIIssuerSignRoleRequest**](PKIIssuerSignRoleRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiissuersignselfissued"></a>
# **PKIIssuerSignSelfIssued**
> void PKIIssuerSignSelfIssued (PKIIssuerSignSelfIssuedRequest pKIIssuerSignSelfIssuedRequest, string issuerRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIIssuerSignSelfIssuedExample
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
            var pKIIssuerSignSelfIssuedRequest = new PKIIssuerSignSelfIssuedRequest(); // PKIIssuerSignSelfIssuedRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIIssuerSignSelfIssued(PKIIssuerSignSelfIssuedRequest pKIIssuerSignSelfIssuedRequest, string issuerRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIIssuerSignSelfIssued: " + e.Message );
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
 **pKIIssuerSignSelfIssuedRequest** | [**PKIIssuerSignSelfIssuedRequest**](PKIIssuerSignSelfIssuedRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiissuersignverbatim"></a>
# **PKIIssuerSignVerbatim**
> void PKIIssuerSignVerbatim (PKIIssuerSignVerbatimRequest pKIIssuerSignVerbatimRequest, string issuerRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIIssuerSignVerbatimExample
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
            var pKIIssuerSignVerbatimRequest = new PKIIssuerSignVerbatimRequest(); // PKIIssuerSignVerbatimRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIIssuerSignVerbatim(PKIIssuerSignVerbatimRequest pKIIssuerSignVerbatimRequest, string issuerRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIIssuerSignVerbatim: " + e.Message );
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
 **pKIIssuerSignVerbatimRequest** | [**PKIIssuerSignVerbatimRequest**](PKIIssuerSignVerbatimRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiissuersignverbatimrole"></a>
# **PKIIssuerSignVerbatimRole**
> void PKIIssuerSignVerbatimRole (PKIIssuerSignVerbatimRoleRequest pKIIssuerSignVerbatimRoleRequest, string issuerRef, string role, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIIssuerSignVerbatimRoleExample
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
            var pKIIssuerSignVerbatimRoleRequest = new PKIIssuerSignVerbatimRoleRequest(); // PKIIssuerSignVerbatimRoleRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIIssuerSignVerbatimRole(PKIIssuerSignVerbatimRoleRequest pKIIssuerSignVerbatimRoleRequest, string issuerRef, string role, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIIssuerSignVerbatimRole: " + e.Message );
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
 **pKIIssuerSignVerbatimRoleRequest** | [**PKIIssuerSignVerbatimRoleRequest**](PKIIssuerSignVerbatimRoleRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiissuersgenerateintermediate"></a>
# **PKIIssuersGenerateIntermediate**
> void PKIIssuersGenerateIntermediate (PKIIssuersGenerateIntermediateRequest pKIIssuersGenerateIntermediateRequest, string exported, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIIssuersGenerateIntermediateExample
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
            var pKIIssuersGenerateIntermediateRequest = new PKIIssuersGenerateIntermediateRequest(); // PKIIssuersGenerateIntermediateRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIIssuersGenerateIntermediate(PKIIssuersGenerateIntermediateRequest pKIIssuersGenerateIntermediateRequest, string exported, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIIssuersGenerateIntermediate: " + e.Message );
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
 **pKIIssuersGenerateIntermediateRequest** | [**PKIIssuersGenerateIntermediateRequest**](PKIIssuersGenerateIntermediateRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiissuersgenerateroot"></a>
# **PKIIssuersGenerateRoot**
> void PKIIssuersGenerateRoot (PKIIssuersGenerateRootRequest pKIIssuersGenerateRootRequest, string exported, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIIssuersGenerateRootExample
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
            var pKIIssuersGenerateRootRequest = new PKIIssuersGenerateRootRequest(); // PKIIssuersGenerateRootRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIIssuersGenerateRoot(PKIIssuersGenerateRootRequest pKIIssuersGenerateRootRequest, string exported, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIIssuersGenerateRoot: " + e.Message );
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
 **pKIIssuersGenerateRootRequest** | [**PKIIssuersGenerateRootRequest**](PKIIssuersGenerateRootRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiissuerslist"></a>
# **PKIIssuersList**
> void PKIIssuersList (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIIssuersListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIIssuersList(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIIssuersList: " + e.Message );
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
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkilistcerts"></a>
# **PKIListCerts**
> void PKIListCerts (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIListCertsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIListCerts(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIListCerts: " + e.Message );
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
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkilistcertsrevoked"></a>
# **PKIListCertsRevoked**
> void PKIListCertsRevoked (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIListCertsRevokedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIListCertsRevoked(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIListCertsRevoked: " + e.Message );
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
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkilistkeys"></a>
# **PKIListKeys**
> void PKIListKeys (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIListKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIListKeys(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIListKeys: " + e.Message );
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
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkilistroles"></a>
# **PKIListRoles**
> void PKIListRoles (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIListRoles(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIListRoles: " + e.Message );
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
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireadautotidyconfig"></a>
# **PKIReadAutoTidyConfig**
> void PKIReadAutoTidyConfig (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIReadAutoTidyConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIReadAutoTidyConfig(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIReadAutoTidyConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireadca"></a>
# **PKIReadCA**
> void PKIReadCA (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIReadCAExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIReadCA(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIReadCA: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireadcachain"></a>
# **PKIReadCAChain**
> void PKIReadCAChain (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIReadCAChainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIReadCAChain(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIReadCAChain: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireadcapem"></a>
# **PKIReadCAPem**
> void PKIReadCAPem (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIReadCAPemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIReadCAPem(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIReadCAPem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireadcrl"></a>
# **PKIReadCRL**
> void PKIReadCRL (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIReadCRLExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIReadCRL(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIReadCRL: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireadcrlconfig"></a>
# **PKIReadCRLConfig**
> void PKIReadCRLConfig (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIReadCRLConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIReadCRLConfig(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIReadCRLConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireadcrlrotate"></a>
# **PKIReadCRLRotate**
> void PKIReadCRLRotate (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIReadCRLRotateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIReadCRLRotate(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIReadCRLRotate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireadcrlrotatedelta"></a>
# **PKIReadCRLRotateDelta**
> void PKIReadCRLRotateDelta (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIReadCRLRotateDeltaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIReadCRLRotateDelta(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIReadCRLRotateDelta: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireadcert"></a>
# **PKIReadCert**
> void PKIReadCert (string serial, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIReadCertExample
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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIReadCert(string serial, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIReadCert: " + e.Message );
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
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireadcertcachain"></a>
# **PKIReadCertCAChain**
> void PKIReadCertCAChain (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIReadCertCAChainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIReadCertCAChain(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIReadCertCAChain: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireadcertraw"></a>
# **PKIReadCertRaw**
> void PKIReadCertRaw (string serial, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIReadCertRawExample
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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIReadCertRaw(string serial, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIReadCertRaw: " + e.Message );
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
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireadcertrawpem"></a>
# **PKIReadCertRawPem**
> void PKIReadCertRawPem (string serial, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIReadCertRawPemExample
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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIReadCertRawPem(string serial, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIReadCertRawPem: " + e.Message );
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
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireadclusterconfig"></a>
# **PKIReadClusterConfig**
> void PKIReadClusterConfig (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIReadClusterConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIReadClusterConfig(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIReadClusterConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireaddeltacrl"></a>
# **PKIReadDeltaCRL**
> void PKIReadDeltaCRL (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIReadDeltaCRLExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIReadDeltaCRL(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIReadDeltaCRL: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireadissuersconfig"></a>
# **PKIReadIssuersConfig**
> void PKIReadIssuersConfig (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIReadIssuersConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIReadIssuersConfig(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIReadIssuersConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireadkey"></a>
# **PKIReadKey**
> void PKIReadKey (string keyRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIReadKeyExample
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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIReadKey(string keyRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIReadKey: " + e.Message );
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
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireadkeysconfig"></a>
# **PKIReadKeysConfig**
> void PKIReadKeysConfig (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIReadKeysConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIReadKeysConfig(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIReadKeysConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireadocspreq"></a>
# **PKIReadOCSPReq**
> void PKIReadOCSPReq (string req, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIReadOCSPReqExample
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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIReadOCSPReq(string req, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIReadOCSPReq: " + e.Message );
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
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireadrole"></a>
# **PKIReadRole**
> void PKIReadRole (string name, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIReadRoleExample
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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIReadRole(string name, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIReadRole: " + e.Message );
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
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireadurlconfig"></a>
# **PKIReadURLConfig**
> void PKIReadURLConfig (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIReadURLConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIReadURLConfig(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIReadURLConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireplaceroot"></a>
# **PKIReplaceRoot**
> void PKIReplaceRoot (PKIReplaceRootRequest pKIReplaceRootRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIReplaceRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pKIReplaceRootRequest = new PKIReplaceRootRequest(); // PKIReplaceRootRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIReplaceRoot(PKIReplaceRootRequest pKIReplaceRootRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIReplaceRoot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pKIReplaceRootRequest** | [**PKIReplaceRootRequest**](PKIReplaceRootRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkirevoke"></a>
# **PKIRevoke**
> void PKIRevoke (PKIRevokeRequest pKIRevokeRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIRevokeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pKIRevokeRequest = new PKIRevokeRequest(); // PKIRevokeRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIRevoke(PKIRevokeRequest pKIRevokeRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIRevoke: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pKIRevokeRequest** | [**PKIRevokeRequest**](PKIRevokeRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkirevokewithkey"></a>
# **PKIRevokeWithKey**
> void PKIRevokeWithKey (PKIRevokeWithKeyRequest pKIRevokeWithKeyRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIRevokeWithKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pKIRevokeWithKeyRequest = new PKIRevokeWithKeyRequest(); // PKIRevokeWithKeyRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIRevokeWithKey(PKIRevokeWithKeyRequest pKIRevokeWithKeyRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIRevokeWithKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pKIRevokeWithKeyRequest** | [**PKIRevokeWithKeyRequest**](PKIRevokeWithKeyRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkirootsignintermediate"></a>
# **PKIRootSignIntermediate**
> void PKIRootSignIntermediate (PKIRootSignIntermediateRequest pKIRootSignIntermediateRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIRootSignIntermediateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pKIRootSignIntermediateRequest = new PKIRootSignIntermediateRequest(); // PKIRootSignIntermediateRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIRootSignIntermediate(PKIRootSignIntermediateRequest pKIRootSignIntermediateRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIRootSignIntermediate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pKIRootSignIntermediateRequest** | [**PKIRootSignIntermediateRequest**](PKIRootSignIntermediateRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkirootsignselfissued"></a>
# **PKIRootSignSelfIssued**
> void PKIRootSignSelfIssued (PKIRootSignSelfIssuedRequest pKIRootSignSelfIssuedRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIRootSignSelfIssuedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pKIRootSignSelfIssuedRequest = new PKIRootSignSelfIssuedRequest(); // PKIRootSignSelfIssuedRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIRootSignSelfIssued(PKIRootSignSelfIssuedRequest pKIRootSignSelfIssuedRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIRootSignSelfIssued: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pKIRootSignSelfIssuedRequest** | [**PKIRootSignSelfIssuedRequest**](PKIRootSignSelfIssuedRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkirotateroot"></a>
# **PKIRotateRoot**
> void PKIRotateRoot (PKIRotateRootRequest pKIRotateRootRequest, string exported, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIRotateRootExample
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
            var pKIRotateRootRequest = new PKIRotateRootRequest(); // PKIRotateRootRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIRotateRoot(PKIRotateRootRequest pKIRotateRootRequest, string exported, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIRotateRoot: " + e.Message );
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
 **pKIRotateRootRequest** | [**PKIRotateRootRequest**](PKIRotateRootRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkisignrole"></a>
# **PKISignRole**
> void PKISignRole (PKISignRoleRequest pKISignRoleRequest, string role, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKISignRoleExample
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
            var pKISignRoleRequest = new PKISignRoleRequest(); // PKISignRoleRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKISignRole(PKISignRoleRequest pKISignRoleRequest, string role, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKISignRole: " + e.Message );
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
 **pKISignRoleRequest** | [**PKISignRoleRequest**](PKISignRoleRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkisignverbatim"></a>
# **PKISignVerbatim**
> void PKISignVerbatim (PKISignVerbatimRequest pKISignVerbatimRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKISignVerbatimExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pKISignVerbatimRequest = new PKISignVerbatimRequest(); // PKISignVerbatimRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKISignVerbatim(PKISignVerbatimRequest pKISignVerbatimRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKISignVerbatim: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pKISignVerbatimRequest** | [**PKISignVerbatimRequest**](PKISignVerbatimRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkisignverbatimrole"></a>
# **PKISignVerbatimRole**
> void PKISignVerbatimRole (PKISignVerbatimRoleRequest pKISignVerbatimRoleRequest, string role, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKISignVerbatimRoleExample
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
            var pKISignVerbatimRoleRequest = new PKISignVerbatimRoleRequest(); // PKISignVerbatimRoleRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKISignVerbatimRole(PKISignVerbatimRoleRequest pKISignVerbatimRoleRequest, string role, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKISignVerbatimRole: " + e.Message );
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
 **pKISignVerbatimRoleRequest** | [**PKISignVerbatimRoleRequest**](PKISignVerbatimRoleRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkitidy"></a>
# **PKITidy**
> void PKITidy (PKITidyRequest pKITidyRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKITidyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pKITidyRequest = new PKITidyRequest(); // PKITidyRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKITidy(PKITidyRequest pKITidyRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKITidy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pKITidyRequest** | [**PKITidyRequest**](PKITidyRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkitidycancel"></a>
# **PKITidyCancel**
> void PKITidyCancel (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKITidyCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKITidyCancel(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKITidyCancel: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkitidystatus"></a>
# **PKITidyStatus**
> void PKITidyStatus (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKITidyStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKITidyStatus(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKITidyStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiwriteautotidyconfig"></a>
# **PKIWriteAutoTidyConfig**
> void PKIWriteAutoTidyConfig (PKIWriteAutoTidyConfigRequest pKIWriteAutoTidyConfigRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIWriteAutoTidyConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pKIWriteAutoTidyConfigRequest = new PKIWriteAutoTidyConfigRequest(); // PKIWriteAutoTidyConfigRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIWriteAutoTidyConfig(PKIWriteAutoTidyConfigRequest pKIWriteAutoTidyConfigRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIWriteAutoTidyConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pKIWriteAutoTidyConfigRequest** | [**PKIWriteAutoTidyConfigRequest**](PKIWriteAutoTidyConfigRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiwritecaconfig"></a>
# **PKIWriteCAConfig**
> void PKIWriteCAConfig (PKIWriteCAConfigRequest pKIWriteCAConfigRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIWriteCAConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pKIWriteCAConfigRequest = new PKIWriteCAConfigRequest(); // PKIWriteCAConfigRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIWriteCAConfig(PKIWriteCAConfigRequest pKIWriteCAConfigRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIWriteCAConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pKIWriteCAConfigRequest** | [**PKIWriteCAConfigRequest**](PKIWriteCAConfigRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiwritecrlconfig"></a>
# **PKIWriteCRLConfig**
> void PKIWriteCRLConfig (PKIWriteCRLConfigRequest pKIWriteCRLConfigRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIWriteCRLConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pKIWriteCRLConfigRequest = new PKIWriteCRLConfigRequest(); // PKIWriteCRLConfigRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIWriteCRLConfig(PKIWriteCRLConfigRequest pKIWriteCRLConfigRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIWriteCRLConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pKIWriteCRLConfigRequest** | [**PKIWriteCRLConfigRequest**](PKIWriteCRLConfigRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiwritecerts"></a>
# **PKIWriteCerts**
> void PKIWriteCerts (PKIWriteCertsRequest pKIWriteCertsRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIWriteCertsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pKIWriteCertsRequest = new PKIWriteCertsRequest(); // PKIWriteCertsRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIWriteCerts(PKIWriteCertsRequest pKIWriteCertsRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIWriteCerts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pKIWriteCertsRequest** | [**PKIWriteCertsRequest**](PKIWriteCertsRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiwriteclusterconfig"></a>
# **PKIWriteClusterConfig**
> void PKIWriteClusterConfig (PKIWriteClusterConfigRequest pKIWriteClusterConfigRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIWriteClusterConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pKIWriteClusterConfigRequest = new PKIWriteClusterConfigRequest(); // PKIWriteClusterConfigRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIWriteClusterConfig(PKIWriteClusterConfigRequest pKIWriteClusterConfigRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIWriteClusterConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pKIWriteClusterConfigRequest** | [**PKIWriteClusterConfigRequest**](PKIWriteClusterConfigRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiwriteintermediatecrosssign"></a>
# **PKIWriteIntermediateCrossSign**
> void PKIWriteIntermediateCrossSign (PKIWriteIntermediateCrossSignRequest pKIWriteIntermediateCrossSignRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIWriteIntermediateCrossSignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pKIWriteIntermediateCrossSignRequest = new PKIWriteIntermediateCrossSignRequest(); // PKIWriteIntermediateCrossSignRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIWriteIntermediateCrossSign(PKIWriteIntermediateCrossSignRequest pKIWriteIntermediateCrossSignRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIWriteIntermediateCrossSign: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pKIWriteIntermediateCrossSignRequest** | [**PKIWriteIntermediateCrossSignRequest**](PKIWriteIntermediateCrossSignRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiwriteintermediategenerate"></a>
# **PKIWriteIntermediateGenerate**
> void PKIWriteIntermediateGenerate (PKIWriteIntermediateGenerateRequest pKIWriteIntermediateGenerateRequest, string exported, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIWriteIntermediateGenerateExample
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
            var pKIWriteIntermediateGenerateRequest = new PKIWriteIntermediateGenerateRequest(); // PKIWriteIntermediateGenerateRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIWriteIntermediateGenerate(PKIWriteIntermediateGenerateRequest pKIWriteIntermediateGenerateRequest, string exported, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIWriteIntermediateGenerate: " + e.Message );
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
 **pKIWriteIntermediateGenerateRequest** | [**PKIWriteIntermediateGenerateRequest**](PKIWriteIntermediateGenerateRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiwriteintermediatesetsigned"></a>
# **PKIWriteIntermediateSetSigned**
> void PKIWriteIntermediateSetSigned (PKIWriteIntermediateSetSignedRequest pKIWriteIntermediateSetSignedRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIWriteIntermediateSetSignedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pKIWriteIntermediateSetSignedRequest = new PKIWriteIntermediateSetSignedRequest(); // PKIWriteIntermediateSetSignedRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIWriteIntermediateSetSigned(PKIWriteIntermediateSetSignedRequest pKIWriteIntermediateSetSignedRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIWriteIntermediateSetSigned: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pKIWriteIntermediateSetSignedRequest** | [**PKIWriteIntermediateSetSignedRequest**](PKIWriteIntermediateSetSignedRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiwriteinternalexported"></a>
# **PKIWriteInternalExported**
> void PKIWriteInternalExported (PKIWriteInternalExportedRequest pKIWriteInternalExportedRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIWriteInternalExportedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pKIWriteInternalExportedRequest = new PKIWriteInternalExportedRequest(); // PKIWriteInternalExportedRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIWriteInternalExported(PKIWriteInternalExportedRequest pKIWriteInternalExportedRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIWriteInternalExported: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pKIWriteInternalExportedRequest** | [**PKIWriteInternalExportedRequest**](PKIWriteInternalExportedRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiwriteissuerole"></a>
# **PKIWriteIssueRole**
> void PKIWriteIssueRole (PKIWriteIssueRoleRequest pKIWriteIssueRoleRequest, string role, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIWriteIssueRoleExample
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
            var pKIWriteIssueRoleRequest = new PKIWriteIssueRoleRequest(); // PKIWriteIssueRoleRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIWriteIssueRole(PKIWriteIssueRoleRequest pKIWriteIssueRoleRequest, string role, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIWriteIssueRole: " + e.Message );
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
 **pKIWriteIssueRoleRequest** | [**PKIWriteIssueRoleRequest**](PKIWriteIssueRoleRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiwriteissuersconfig"></a>
# **PKIWriteIssuersConfig**
> void PKIWriteIssuersConfig (PKIWriteIssuersConfigRequest pKIWriteIssuersConfigRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIWriteIssuersConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pKIWriteIssuersConfigRequest = new PKIWriteIssuersConfigRequest(); // PKIWriteIssuersConfigRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIWriteIssuersConfig(PKIWriteIssuersConfigRequest pKIWriteIssuersConfigRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIWriteIssuersConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pKIWriteIssuersConfigRequest** | [**PKIWriteIssuersConfigRequest**](PKIWriteIssuersConfigRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiwritekms"></a>
# **PKIWriteKMS**
> void PKIWriteKMS (PKIWriteKMSRequest pKIWriteKMSRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIWriteKMSExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pKIWriteKMSRequest = new PKIWriteKMSRequest(); // PKIWriteKMSRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIWriteKMS(PKIWriteKMSRequest pKIWriteKMSRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIWriteKMS: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pKIWriteKMSRequest** | [**PKIWriteKMSRequest**](PKIWriteKMSRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiwritekey"></a>
# **PKIWriteKey**
> void PKIWriteKey (PKIWriteKeyRequest pKIWriteKeyRequest, string keyRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIWriteKeyExample
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
            var pKIWriteKeyRequest = new PKIWriteKeyRequest(); // PKIWriteKeyRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIWriteKey(PKIWriteKeyRequest pKIWriteKeyRequest, string keyRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIWriteKey: " + e.Message );
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
 **pKIWriteKeyRequest** | [**PKIWriteKeyRequest**](PKIWriteKeyRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiwritekeysconfig"></a>
# **PKIWriteKeysConfig**
> void PKIWriteKeysConfig (PKIWriteKeysConfigRequest pKIWriteKeysConfigRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIWriteKeysConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pKIWriteKeysConfigRequest = new PKIWriteKeysConfigRequest(); // PKIWriteKeysConfigRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIWriteKeysConfig(PKIWriteKeysConfigRequest pKIWriteKeysConfigRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIWriteKeysConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pKIWriteKeysConfigRequest** | [**PKIWriteKeysConfigRequest**](PKIWriteKeysConfigRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiwriteocsp"></a>
# **PKIWriteOCSP**
> void PKIWriteOCSP (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIWriteOCSPExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIWriteOCSP(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIWriteOCSP: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiwriterole"></a>
# **PKIWriteRole**
> void PKIWriteRole (PKIWriteRoleRequest pKIWriteRoleRequest, string name, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIWriteRoleExample
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
            var pKIWriteRoleRequest = new PKIWriteRoleRequest(); // PKIWriteRoleRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIWriteRole(PKIWriteRoleRequest pKIWriteRoleRequest, string name, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIWriteRole: " + e.Message );
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
 **pKIWriteRoleRequest** | [**PKIWriteRoleRequest**](PKIWriteRoleRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiwriteurlconfig"></a>
# **PKIWriteURLConfig**
> void PKIWriteURLConfig (PKIWriteURLConfigRequest pKIWriteURLConfigRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PKIWriteURLConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pKIWriteURLConfigRequest = new PKIWriteURLConfigRequest(); // PKIWriteURLConfigRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PKIWriteURLConfig(PKIWriteURLConfigRequest pKIWriteURLConfigRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PKIWriteURLConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pKIWriteURLConfigRequest** | [**PKIWriteURLConfigRequest**](PKIWriteURLConfigRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkideleteissuerrefderpem"></a>
# **PkiDeleteIssuerRefDerPem**
> void PkiDeleteIssuerRefDerPem (string issuerRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiDeleteIssuerRefDerPemExample
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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PkiDeleteIssuerRefDerPem(string issuerRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiDeleteIssuerRefDerPem: " + e.Message );
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
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkideletejson"></a>
# **PkiDeleteJson**
> void PkiDeleteJson (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiDeleteJsonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PkiDeleteJson(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiDeleteJson: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireaddelta"></a>
# **PkiReadDelta**
> void PkiReadDelta (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadDeltaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PkiReadDelta(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadDelta: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireaddeltapem"></a>
# **PkiReadDeltaPem**
> void PkiReadDeltaPem (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadDeltaPemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PkiReadDeltaPem(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadDeltaPem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireadder"></a>
# **PkiReadDer**
> void PkiReadDer (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadDerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PkiReadDer(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadDer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireadissuerrefcrlpemderdeltapem"></a>
# **PkiReadIssuerRefCrlPemDerDeltaPem**
> void PkiReadIssuerRefCrlPemDerDeltaPem (string issuerRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadIssuerRefCrlPemDerDeltaPemExample
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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PkiReadIssuerRefCrlPemDerDeltaPem(string issuerRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadIssuerRefCrlPemDerDeltaPem: " + e.Message );
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
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireadissuerrefderpem"></a>
# **PkiReadIssuerRefDerPem**
> void PkiReadIssuerRefDerPem (string issuerRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadIssuerRefDerPemExample
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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PkiReadIssuerRefDerPem(string issuerRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadIssuerRefDerPem: " + e.Message );
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
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireadjson"></a>
# **PkiReadJson**
> void PkiReadJson (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadJsonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PkiReadJson(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadJson: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkireadpem"></a>
# **PkiReadPem**
> void PkiReadPem (string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiReadPemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PkiReadPem(string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiReadPem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiwriteissuerrefderpem"></a>
# **PkiWriteIssuerRefDerPem**
> void PkiWriteIssuerRefDerPem (PkiWriteIssuerRefDerPemRequest pkiWriteIssuerRefDerPemRequest, string issuerRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiWriteIssuerRefDerPemExample
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
            var pkiWriteIssuerRefDerPemRequest = new PkiWriteIssuerRefDerPemRequest(); // PkiWriteIssuerRefDerPemRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PkiWriteIssuerRefDerPem(PkiWriteIssuerRefDerPemRequest pkiWriteIssuerRefDerPemRequest, string issuerRef, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiWriteIssuerRefDerPem: " + e.Message );
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
 **pkiWriteIssuerRefDerPemRequest** | [**PkiWriteIssuerRefDerPemRequest**](PkiWriteIssuerRefDerPemRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pkiwritejson"></a>
# **PkiWriteJson**
> void PkiWriteJson (PkiWriteJsonRequest pkiWriteJsonRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PkiWriteJsonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiWriteJsonRequest = new PkiWriteJsonRequest(); // PkiWriteJsonRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PkiWriteJson(PkiWriteJsonRequest pkiWriteJsonRequest, string pkiMountPath = "pki", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PkiWriteJson: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiWriteJsonRequest** | [**PkiWriteJsonRequest**](PkiWriteJsonRequest.md)|  | 
 **pkiMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rabbitmqdeleterole"></a>
# **RabbitMQDeleteRole**
> void RabbitMQDeleteRole (string name, string rabbitmqMountPath = "rabbitmq", TimeSpan? wrapTTL = null)

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
    public class RabbitMQDeleteRoleExample
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
            var rabbitmqMountPath = "\"rabbitmq\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "rabbitmq")

            try
            {
                // Manage the roles that can be created with this backend.
                apiInstance.RabbitMQDeleteRole(string name, string rabbitmqMountPath = "rabbitmq", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.RabbitMQDeleteRole: " + e.Message );
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
 **rabbitmqMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;rabbitmq&quot;]

### Return type

void (empty response body)

### Authorization

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
# **RabbitMQListRoles**
> void RabbitMQListRoles (string rabbitmqMountPath = "rabbitmq", TimeSpan? wrapTTL = null)

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
    public class RabbitMQListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var rabbitmqMountPath = "\"rabbitmq\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "rabbitmq")

            try
            {
                // Manage the roles that can be created with this backend.
                apiInstance.RabbitMQListRoles(string rabbitmqMountPath = "rabbitmq", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.RabbitMQListRoles: " + e.Message );
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
 **rabbitmqMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;rabbitmq&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rabbitmqreadcredentials"></a>
# **RabbitMQReadCredentials**
> void RabbitMQReadCredentials (string name, string rabbitmqMountPath = "rabbitmq", TimeSpan? wrapTTL = null)

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
    public class RabbitMQReadCredentialsExample
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
            var rabbitmqMountPath = "\"rabbitmq\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "rabbitmq")

            try
            {
                // Request RabbitMQ credentials for a certain role.
                apiInstance.RabbitMQReadCredentials(string name, string rabbitmqMountPath = "rabbitmq", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.RabbitMQReadCredentials: " + e.Message );
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
 **rabbitmqMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;rabbitmq&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rabbitmqreadleaseconfig"></a>
# **RabbitMQReadLeaseConfig**
> void RabbitMQReadLeaseConfig (string rabbitmqMountPath = "rabbitmq", TimeSpan? wrapTTL = null)

Configure the lease parameters for generated credentials

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class RabbitMQReadLeaseConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var rabbitmqMountPath = "\"rabbitmq\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "rabbitmq")

            try
            {
                // Configure the lease parameters for generated credentials
                apiInstance.RabbitMQReadLeaseConfig(string rabbitmqMountPath = "rabbitmq", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.RabbitMQReadLeaseConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rabbitmqMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;rabbitmq&quot;]

### Return type

void (empty response body)

### Authorization

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
# **RabbitMQReadRole**
> void RabbitMQReadRole (string name, string rabbitmqMountPath = "rabbitmq", TimeSpan? wrapTTL = null)

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
    public class RabbitMQReadRoleExample
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
            var rabbitmqMountPath = "\"rabbitmq\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "rabbitmq")

            try
            {
                // Manage the roles that can be created with this backend.
                apiInstance.RabbitMQReadRole(string name, string rabbitmqMountPath = "rabbitmq", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.RabbitMQReadRole: " + e.Message );
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
 **rabbitmqMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;rabbitmq&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rabbitmqwriteconnectionconfig"></a>
# **RabbitMQWriteConnectionConfig**
> void RabbitMQWriteConnectionConfig (RabbitMQWriteConnectionConfigRequest rabbitMQWriteConnectionConfigRequest, string rabbitmqMountPath = "rabbitmq", TimeSpan? wrapTTL = null)

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
    public class RabbitMQWriteConnectionConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var rabbitMQWriteConnectionConfigRequest = new RabbitMQWriteConnectionConfigRequest(); // RabbitMQWriteConnectionConfigRequest | 
            var rabbitmqMountPath = "\"rabbitmq\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "rabbitmq")

            try
            {
                // Configure the connection URI, username, and password to talk to RabbitMQ management HTTP API.
                apiInstance.RabbitMQWriteConnectionConfig(RabbitMQWriteConnectionConfigRequest rabbitMQWriteConnectionConfigRequest, string rabbitmqMountPath = "rabbitmq", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.RabbitMQWriteConnectionConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rabbitMQWriteConnectionConfigRequest** | [**RabbitMQWriteConnectionConfigRequest**](RabbitMQWriteConnectionConfigRequest.md)|  | 
 **rabbitmqMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;rabbitmq&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rabbitmqwriteleaseconfig"></a>
# **RabbitMQWriteLeaseConfig**
> void RabbitMQWriteLeaseConfig (RabbitMQWriteLeaseConfigRequest rabbitMQWriteLeaseConfigRequest, string rabbitmqMountPath = "rabbitmq", TimeSpan? wrapTTL = null)

Configure the lease parameters for generated credentials

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class RabbitMQWriteLeaseConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var rabbitMQWriteLeaseConfigRequest = new RabbitMQWriteLeaseConfigRequest(); // RabbitMQWriteLeaseConfigRequest | 
            var rabbitmqMountPath = "\"rabbitmq\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "rabbitmq")

            try
            {
                // Configure the lease parameters for generated credentials
                apiInstance.RabbitMQWriteLeaseConfig(RabbitMQWriteLeaseConfigRequest rabbitMQWriteLeaseConfigRequest, string rabbitmqMountPath = "rabbitmq", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.RabbitMQWriteLeaseConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rabbitMQWriteLeaseConfigRequest** | [**RabbitMQWriteLeaseConfigRequest**](RabbitMQWriteLeaseConfigRequest.md)|  | 
 **rabbitmqMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;rabbitmq&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rabbitmqwriterole"></a>
# **RabbitMQWriteRole**
> void RabbitMQWriteRole (RabbitMQWriteRoleRequest rabbitMQWriteRoleRequest, string name, string rabbitmqMountPath = "rabbitmq", TimeSpan? wrapTTL = null)

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
    public class RabbitMQWriteRoleExample
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
            var rabbitMQWriteRoleRequest = new RabbitMQWriteRoleRequest(); // RabbitMQWriteRoleRequest | 
            var rabbitmqMountPath = "\"rabbitmq\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "rabbitmq")

            try
            {
                // Manage the roles that can be created with this backend.
                apiInstance.RabbitMQWriteRole(RabbitMQWriteRoleRequest rabbitMQWriteRoleRequest, string name, string rabbitmqMountPath = "rabbitmq", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.RabbitMQWriteRole: " + e.Message );
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
 **rabbitMQWriteRoleRequest** | [**RabbitMQWriteRoleRequest**](RabbitMQWriteRoleRequest.md)|  | 
 **rabbitmqMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;rabbitmq&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sshdeletecaconfig"></a>
# **SSHDeleteCAConfig**
> void SSHDeleteCAConfig (string sshMountPath = "ssh", TimeSpan? wrapTTL = null)

Set the SSH private key used for signing certificates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SSHDeleteCAConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Set the SSH private key used for signing certificates.
                apiInstance.SSHDeleteCAConfig(string sshMountPath = "ssh", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SSHDeleteCAConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sshMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sshdeletekeys"></a>
# **SSHDeleteKeys**
> void SSHDeleteKeys (string keyName, string sshMountPath = "ssh", TimeSpan? wrapTTL = null)

Register a shared private key with Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SSHDeleteKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var keyName = "keyName_example";  // string | [Required] Name of the key
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Register a shared private key with Vault.
                apiInstance.SSHDeleteKeys(string keyName, string sshMountPath = "ssh", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SSHDeleteKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyName** | **string**| [Required] Name of the key | 
 **sshMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]

### Return type

void (empty response body)

### Authorization

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
# **SSHDeleteRole**
> void SSHDeleteRole (string role, string sshMountPath = "ssh", TimeSpan? wrapTTL = null)

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
    public class SSHDeleteRoleExample
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
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Manage the 'roles' that can be created with this backend.
                apiInstance.SSHDeleteRole(string role, string sshMountPath = "ssh", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SSHDeleteRole: " + e.Message );
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
 **sshMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sshdeletezeroaddressconfig"></a>
# **SSHDeleteZeroAddressConfig**
> void SSHDeleteZeroAddressConfig (string sshMountPath = "ssh", TimeSpan? wrapTTL = null)

Assign zero address as default CIDR block for select roles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SSHDeleteZeroAddressConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Assign zero address as default CIDR block for select roles.
                apiInstance.SSHDeleteZeroAddressConfig(string sshMountPath = "ssh", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SSHDeleteZeroAddressConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sshMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sshlistroles"></a>
# **SSHListRoles**
> void SSHListRoles (string sshMountPath = "ssh", TimeSpan? wrapTTL = null)

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
    public class SSHListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Manage the 'roles' that can be created with this backend.
                apiInstance.SSHListRoles(string sshMountPath = "ssh", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SSHListRoles: " + e.Message );
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
 **sshMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sshlookup"></a>
# **SSHLookup**
> void SSHLookup (SSHLookupRequest sSHLookupRequest, string sshMountPath = "ssh", TimeSpan? wrapTTL = null)

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
    public class SSHLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var sSHLookupRequest = new SSHLookupRequest(); // SSHLookupRequest | 
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // List all the roles associated with the given IP address.
                apiInstance.SSHLookup(SSHLookupRequest sSHLookupRequest, string sshMountPath = "ssh", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SSHLookup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sSHLookupRequest** | [**SSHLookupRequest**](SSHLookupRequest.md)|  | 
 **sshMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sshreadcaconfig"></a>
# **SSHReadCAConfig**
> void SSHReadCAConfig (string sshMountPath = "ssh", TimeSpan? wrapTTL = null)

Set the SSH private key used for signing certificates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SSHReadCAConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Set the SSH private key used for signing certificates.
                apiInstance.SSHReadCAConfig(string sshMountPath = "ssh", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SSHReadCAConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sshMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]

### Return type

void (empty response body)

### Authorization

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
# **SSHReadPublicKey**
> void SSHReadPublicKey (string sshMountPath = "ssh", TimeSpan? wrapTTL = null)

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
    public class SSHReadPublicKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Retrieve the public key.
                apiInstance.SSHReadPublicKey(string sshMountPath = "ssh", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SSHReadPublicKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sshMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]

### Return type

void (empty response body)

### Authorization

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
# **SSHReadRole**
> void SSHReadRole (string role, string sshMountPath = "ssh", TimeSpan? wrapTTL = null)

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
    public class SSHReadRoleExample
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
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Manage the 'roles' that can be created with this backend.
                apiInstance.SSHReadRole(string role, string sshMountPath = "ssh", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SSHReadRole: " + e.Message );
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
 **sshMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sshreadzeroaddressconfig"></a>
# **SSHReadZeroAddressConfig**
> void SSHReadZeroAddressConfig (string sshMountPath = "ssh", TimeSpan? wrapTTL = null)

Assign zero address as default CIDR block for select roles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SSHReadZeroAddressConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Assign zero address as default CIDR block for select roles.
                apiInstance.SSHReadZeroAddressConfig(string sshMountPath = "ssh", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SSHReadZeroAddressConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sshMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sshsign"></a>
# **SSHSign**
> void SSHSign (SSHSignRequest sSHSignRequest, string role, string sshMountPath = "ssh", TimeSpan? wrapTTL = null)

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
    public class SSHSignExample
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
            var sSHSignRequest = new SSHSignRequest(); // SSHSignRequest | 
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Request signing an SSH key using a certain role with the provided details.
                apiInstance.SSHSign(SSHSignRequest sSHSignRequest, string role, string sshMountPath = "ssh", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SSHSign: " + e.Message );
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
 **sSHSignRequest** | [**SSHSignRequest**](SSHSignRequest.md)|  | 
 **sshMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sshverify"></a>
# **SSHVerify**
> void SSHVerify (SSHVerifyRequest sSHVerifyRequest, string sshMountPath = "ssh", TimeSpan? wrapTTL = null)

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
    public class SSHVerifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var sSHVerifyRequest = new SSHVerifyRequest(); // SSHVerifyRequest | 
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Validate the OTP provided by Vault SSH Agent.
                apiInstance.SSHVerify(SSHVerifyRequest sSHVerifyRequest, string sshMountPath = "ssh", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SSHVerify: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sSHVerifyRequest** | [**SSHVerifyRequest**](SSHVerifyRequest.md)|  | 
 **sshMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sshwritecaconfig"></a>
# **SSHWriteCAConfig**
> void SSHWriteCAConfig (SSHWriteCAConfigRequest sSHWriteCAConfigRequest, string sshMountPath = "ssh", TimeSpan? wrapTTL = null)

Set the SSH private key used for signing certificates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SSHWriteCAConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var sSHWriteCAConfigRequest = new SSHWriteCAConfigRequest(); // SSHWriteCAConfigRequest | 
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Set the SSH private key used for signing certificates.
                apiInstance.SSHWriteCAConfig(SSHWriteCAConfigRequest sSHWriteCAConfigRequest, string sshMountPath = "ssh", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SSHWriteCAConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sSHWriteCAConfigRequest** | [**SSHWriteCAConfigRequest**](SSHWriteCAConfigRequest.md)|  | 
 **sshMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sshwritecredentials"></a>
# **SSHWriteCredentials**
> void SSHWriteCredentials (SSHWriteCredentialsRequest sSHWriteCredentialsRequest, string role, string sshMountPath = "ssh", TimeSpan? wrapTTL = null)

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
    public class SSHWriteCredentialsExample
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
            var sSHWriteCredentialsRequest = new SSHWriteCredentialsRequest(); // SSHWriteCredentialsRequest | 
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Creates a credential for establishing SSH connection with the remote host.
                apiInstance.SSHWriteCredentials(SSHWriteCredentialsRequest sSHWriteCredentialsRequest, string role, string sshMountPath = "ssh", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SSHWriteCredentials: " + e.Message );
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
 **sSHWriteCredentialsRequest** | [**SSHWriteCredentialsRequest**](SSHWriteCredentialsRequest.md)|  | 
 **sshMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sshwriteissue"></a>
# **SSHWriteIssue**
> void SSHWriteIssue (SSHWriteIssueRequest sSHWriteIssueRequest, string role, string sshMountPath = "ssh", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SSHWriteIssueExample
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
            var sSHWriteIssueRequest = new SSHWriteIssueRequest(); // SSHWriteIssueRequest | 
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                apiInstance.SSHWriteIssue(SSHWriteIssueRequest sSHWriteIssueRequest, string role, string sshMountPath = "ssh", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SSHWriteIssue: " + e.Message );
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
 **sSHWriteIssueRequest** | [**SSHWriteIssueRequest**](SSHWriteIssueRequest.md)|  | 
 **sshMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sshwritekeys"></a>
# **SSHWriteKeys**
> void SSHWriteKeys (SSHWriteKeysRequest sSHWriteKeysRequest, string keyName, string sshMountPath = "ssh", TimeSpan? wrapTTL = null)

Register a shared private key with Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SSHWriteKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var keyName = "keyName_example";  // string | [Required] Name of the key
            var sSHWriteKeysRequest = new SSHWriteKeysRequest(); // SSHWriteKeysRequest | 
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Register a shared private key with Vault.
                apiInstance.SSHWriteKeys(SSHWriteKeysRequest sSHWriteKeysRequest, string keyName, string sshMountPath = "ssh", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SSHWriteKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyName** | **string**| [Required] Name of the key | 
 **sSHWriteKeysRequest** | [**SSHWriteKeysRequest**](SSHWriteKeysRequest.md)|  | 
 **sshMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sshwriterole"></a>
# **SSHWriteRole**
> void SSHWriteRole (SSHWriteRoleRequest sSHWriteRoleRequest, string role, string sshMountPath = "ssh", TimeSpan? wrapTTL = null)

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
    public class SSHWriteRoleExample
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
            var sSHWriteRoleRequest = new SSHWriteRoleRequest(); // SSHWriteRoleRequest | 
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Manage the 'roles' that can be created with this backend.
                apiInstance.SSHWriteRole(SSHWriteRoleRequest sSHWriteRoleRequest, string role, string sshMountPath = "ssh", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SSHWriteRole: " + e.Message );
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
 **sSHWriteRoleRequest** | [**SSHWriteRoleRequest**](SSHWriteRoleRequest.md)|  | 
 **sshMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sshwritezeroaddressconfig"></a>
# **SSHWriteZeroAddressConfig**
> void SSHWriteZeroAddressConfig (SSHWriteZeroAddressConfigRequest sSHWriteZeroAddressConfigRequest, string sshMountPath = "ssh", TimeSpan? wrapTTL = null)

Assign zero address as default CIDR block for select roles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SSHWriteZeroAddressConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var sSHWriteZeroAddressConfigRequest = new SSHWriteZeroAddressConfigRequest(); // SSHWriteZeroAddressConfigRequest | 
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Assign zero address as default CIDR block for select roles.
                apiInstance.SSHWriteZeroAddressConfig(SSHWriteZeroAddressConfigRequest sSHWriteZeroAddressConfigRequest, string sshMountPath = "ssh", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.SSHWriteZeroAddressConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sSHWriteZeroAddressConfigRequest** | [**SSHWriteZeroAddressConfigRequest**](SSHWriteZeroAddressConfigRequest.md)|  | 
 **sshMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="totpdeletekey"></a>
# **TOTPDeleteKey**
> void TOTPDeleteKey (string name, string totpMountPath = "totp", TimeSpan? wrapTTL = null)

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
    public class TOTPDeleteKeyExample
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
            var totpMountPath = "\"totp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "totp")

            try
            {
                // Manage the keys that can be created with this backend.
                apiInstance.TOTPDeleteKey(string name, string totpMountPath = "totp", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TOTPDeleteKey: " + e.Message );
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
 **totpMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;totp&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="totplistkeys"></a>
# **TOTPListKeys**
> void TOTPListKeys (string totpMountPath = "totp", TimeSpan? wrapTTL = null)

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
    public class TOTPListKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var totpMountPath = "\"totp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "totp")

            try
            {
                // Manage the keys that can be created with this backend.
                apiInstance.TOTPListKeys(string totpMountPath = "totp", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TOTPListKeys: " + e.Message );
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
 **totpMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;totp&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="totpreadcode"></a>
# **TOTPReadCode**
> void TOTPReadCode (string name, string totpMountPath = "totp", TimeSpan? wrapTTL = null)

Request time-based one-time use password or validate a password for a certain key .

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TOTPReadCodeExample
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
            var totpMountPath = "\"totp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "totp")

            try
            {
                // Request time-based one-time use password or validate a password for a certain key .
                apiInstance.TOTPReadCode(string name, string totpMountPath = "totp", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TOTPReadCode: " + e.Message );
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
 **totpMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;totp&quot;]

### Return type

void (empty response body)

### Authorization

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
# **TOTPReadKey**
> void TOTPReadKey (string name, string totpMountPath = "totp", TimeSpan? wrapTTL = null)

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
    public class TOTPReadKeyExample
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
            var totpMountPath = "\"totp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "totp")

            try
            {
                // Manage the keys that can be created with this backend.
                apiInstance.TOTPReadKey(string name, string totpMountPath = "totp", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TOTPReadKey: " + e.Message );
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
 **totpMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;totp&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="totpwritecode"></a>
# **TOTPWriteCode**
> void TOTPWriteCode (TOTPWriteCodeRequest tOTPWriteCodeRequest, string name, string totpMountPath = "totp", TimeSpan? wrapTTL = null)

Request time-based one-time use password or validate a password for a certain key .

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TOTPWriteCodeExample
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
            var tOTPWriteCodeRequest = new TOTPWriteCodeRequest(); // TOTPWriteCodeRequest | 
            var totpMountPath = "\"totp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "totp")

            try
            {
                // Request time-based one-time use password or validate a password for a certain key .
                apiInstance.TOTPWriteCode(TOTPWriteCodeRequest tOTPWriteCodeRequest, string name, string totpMountPath = "totp", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TOTPWriteCode: " + e.Message );
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
 **tOTPWriteCodeRequest** | [**TOTPWriteCodeRequest**](TOTPWriteCodeRequest.md)|  | 
 **totpMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;totp&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="totpwritekey"></a>
# **TOTPWriteKey**
> void TOTPWriteKey (TOTPWriteKeyRequest tOTPWriteKeyRequest, string name, string totpMountPath = "totp", TimeSpan? wrapTTL = null)

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
    public class TOTPWriteKeyExample
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
            var tOTPWriteKeyRequest = new TOTPWriteKeyRequest(); // TOTPWriteKeyRequest | 
            var totpMountPath = "\"totp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "totp")

            try
            {
                // Manage the keys that can be created with this backend.
                apiInstance.TOTPWriteKey(TOTPWriteKeyRequest tOTPWriteKeyRequest, string name, string totpMountPath = "totp", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TOTPWriteKey: " + e.Message );
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
 **tOTPWriteKeyRequest** | [**TOTPWriteKeyRequest**](TOTPWriteKeyRequest.md)|  | 
 **totpMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;totp&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="terraformdeleteconfig"></a>
# **TerraformDeleteConfig**
> void TerraformDeleteConfig (string terraformMountPath = "terraform", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TerraformDeleteConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var terraformMountPath = "\"terraform\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "terraform")

            try
            {
                apiInstance.TerraformDeleteConfig(string terraformMountPath = "terraform", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TerraformDeleteConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **terraformMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;terraform&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="terraformdeleterole"></a>
# **TerraformDeleteRole**
> void TerraformDeleteRole (string name, string terraformMountPath = "terraform", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TerraformDeleteRoleExample
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
            var terraformMountPath = "\"terraform\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "terraform")

            try
            {
                apiInstance.TerraformDeleteRole(string name, string terraformMountPath = "terraform", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TerraformDeleteRole: " + e.Message );
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
 **terraformMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;terraform&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="terraformlistroles"></a>
# **TerraformListRoles**
> void TerraformListRoles (string terraformMountPath = "terraform", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TerraformListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`
            var terraformMountPath = "\"terraform\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "terraform")

            try
            {
                apiInstance.TerraformListRoles(string terraformMountPath = "terraform", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TerraformListRoles: " + e.Message );
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
 **terraformMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;terraform&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="terraformreadconfig"></a>
# **TerraformReadConfig**
> void TerraformReadConfig (string terraformMountPath = "terraform", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TerraformReadConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var terraformMountPath = "\"terraform\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "terraform")

            try
            {
                apiInstance.TerraformReadConfig(string terraformMountPath = "terraform", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TerraformReadConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **terraformMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;terraform&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="terraformreadcredentials"></a>
# **TerraformReadCredentials**
> void TerraformReadCredentials (string name, string terraformMountPath = "terraform", TimeSpan? wrapTTL = null)

Generate a Terraform Cloud or Enterprise API token from a specific Vault role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TerraformReadCredentialsExample
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
            var terraformMountPath = "\"terraform\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "terraform")

            try
            {
                // Generate a Terraform Cloud or Enterprise API token from a specific Vault role.
                apiInstance.TerraformReadCredentials(string name, string terraformMountPath = "terraform", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TerraformReadCredentials: " + e.Message );
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
 **terraformMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;terraform&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="terraformreadrole"></a>
# **TerraformReadRole**
> void TerraformReadRole (string name, string terraformMountPath = "terraform", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TerraformReadRoleExample
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
            var terraformMountPath = "\"terraform\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "terraform")

            try
            {
                apiInstance.TerraformReadRole(string name, string terraformMountPath = "terraform", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TerraformReadRole: " + e.Message );
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
 **terraformMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;terraform&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="terraformrotaterole"></a>
# **TerraformRotateRole**
> void TerraformRotateRole (string name, string terraformMountPath = "terraform", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TerraformRotateRoleExample
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
            var terraformMountPath = "\"terraform\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "terraform")

            try
            {
                apiInstance.TerraformRotateRole(string name, string terraformMountPath = "terraform", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TerraformRotateRole: " + e.Message );
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
 **terraformMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;terraform&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="terraformwriteconfig"></a>
# **TerraformWriteConfig**
> void TerraformWriteConfig (TerraformWriteConfigRequest terraformWriteConfigRequest, string terraformMountPath = "terraform", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TerraformWriteConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var terraformWriteConfigRequest = new TerraformWriteConfigRequest(); // TerraformWriteConfigRequest | 
            var terraformMountPath = "\"terraform\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "terraform")

            try
            {
                apiInstance.TerraformWriteConfig(TerraformWriteConfigRequest terraformWriteConfigRequest, string terraformMountPath = "terraform", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TerraformWriteConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **terraformWriteConfigRequest** | [**TerraformWriteConfigRequest**](TerraformWriteConfigRequest.md)|  | 
 **terraformMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;terraform&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="terraformwritecredentials"></a>
# **TerraformWriteCredentials**
> void TerraformWriteCredentials (string name, string terraformMountPath = "terraform", TimeSpan? wrapTTL = null)

Generate a Terraform Cloud or Enterprise API token from a specific Vault role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TerraformWriteCredentialsExample
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
            var terraformMountPath = "\"terraform\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "terraform")

            try
            {
                // Generate a Terraform Cloud or Enterprise API token from a specific Vault role.
                apiInstance.TerraformWriteCredentials(string name, string terraformMountPath = "terraform", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TerraformWriteCredentials: " + e.Message );
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
 **terraformMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;terraform&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="terraformwriterole"></a>
# **TerraformWriteRole**
> void TerraformWriteRole (TerraformWriteRoleRequest terraformWriteRoleRequest, string name, string terraformMountPath = "terraform", TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TerraformWriteRoleExample
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
            var terraformWriteRoleRequest = new TerraformWriteRoleRequest(); // TerraformWriteRoleRequest | 
            var terraformMountPath = "\"terraform\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "terraform")

            try
            {
                apiInstance.TerraformWriteRole(TerraformWriteRoleRequest terraformWriteRoleRequest, string name, string terraformMountPath = "terraform", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TerraformWriteRole: " + e.Message );
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
 **terraformWriteRoleRequest** | [**TerraformWriteRoleRequest**](TerraformWriteRoleRequest.md)|  | 
 **terraformMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;terraform&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitbackup"></a>
# **TransitBackup**
> void TransitBackup (string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
    public class TransitBackupExample
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
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Backup the named key
                apiInstance.TransitBackup(string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitBackup: " + e.Message );
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
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitdecrypt"></a>
# **TransitDecrypt**
> void TransitDecrypt (TransitDecryptRequest transitDecryptRequest, string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
            var transitDecryptRequest = new TransitDecryptRequest(); // TransitDecryptRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Decrypt a ciphertext value using a named key
                apiInstance.TransitDecrypt(TransitDecryptRequest transitDecryptRequest, string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
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
 **transitDecryptRequest** | [**TransitDecryptRequest**](TransitDecryptRequest.md)|  | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitdeletekey"></a>
# **TransitDeleteKey**
> void TransitDeleteKey (string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Managed named encryption keys
                apiInstance.TransitDeleteKey(string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
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
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

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
> void TransitEncrypt (TransitEncryptRequest transitEncryptRequest, string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
            var transitEncryptRequest = new TransitEncryptRequest(); // TransitEncryptRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Encrypt a plaintext value or a batch of plaintext blocks using a named key
                apiInstance.TransitEncrypt(TransitEncryptRequest transitEncryptRequest, string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
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
 **transitEncryptRequest** | [**TransitEncryptRequest**](TransitEncryptRequest.md)|  | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitexport"></a>
# **TransitExport**
> void TransitExport (string name, string type, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
    public class TransitExportExample
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
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Export named encryption or signing key
                apiInstance.TransitExport(string name, string type, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitExport: " + e.Message );
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
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitexportversion"></a>
# **TransitExportVersion**
> void TransitExportVersion (string name, string type, string version, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
    public class TransitExportVersionExample
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
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Export named encryption or signing key
                apiInstance.TransitExportVersion(string name, string type, string version, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitExportVersion: " + e.Message );
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
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

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
> void TransitGenerateDataKey (TransitGenerateDataKeyRequest transitGenerateDataKeyRequest, string name, string plaintext, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
            var transitGenerateDataKeyRequest = new TransitGenerateDataKeyRequest(); // TransitGenerateDataKeyRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Generate a data key
                apiInstance.TransitGenerateDataKey(TransitGenerateDataKeyRequest transitGenerateDataKeyRequest, string name, string plaintext, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
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
 **transitGenerateDataKeyRequest** | [**TransitGenerateDataKeyRequest**](TransitGenerateDataKeyRequest.md)|  | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitgeneratehmac"></a>
# **TransitGenerateHMAC**
> void TransitGenerateHMAC (TransitGenerateHMACRequest transitGenerateHMACRequest, string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
    public class TransitGenerateHMACExample
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
            var transitGenerateHMACRequest = new TransitGenerateHMACRequest(); // TransitGenerateHMACRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Generate an HMAC for input data using the named key
                apiInstance.TransitGenerateHMAC(TransitGenerateHMACRequest transitGenerateHMACRequest, string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitGenerateHMAC: " + e.Message );
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
 **transitGenerateHMACRequest** | [**TransitGenerateHMACRequest**](TransitGenerateHMACRequest.md)|  | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitgeneratehmacwithalgorithm"></a>
# **TransitGenerateHMACWithAlgorithm**
> void TransitGenerateHMACWithAlgorithm (TransitGenerateHMACWithAlgorithmRequest transitGenerateHMACWithAlgorithmRequest, string name, string urlalgorithm, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
    public class TransitGenerateHMACWithAlgorithmExample
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
            var transitGenerateHMACWithAlgorithmRequest = new TransitGenerateHMACWithAlgorithmRequest(); // TransitGenerateHMACWithAlgorithmRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Generate an HMAC for input data using the named key
                apiInstance.TransitGenerateHMACWithAlgorithm(TransitGenerateHMACWithAlgorithmRequest transitGenerateHMACWithAlgorithmRequest, string name, string urlalgorithm, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitGenerateHMACWithAlgorithm: " + e.Message );
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
 **transitGenerateHMACWithAlgorithmRequest** | [**TransitGenerateHMACWithAlgorithmRequest**](TransitGenerateHMACWithAlgorithmRequest.md)|  | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitgeneraterandom"></a>
# **TransitGenerateRandom**
> void TransitGenerateRandom (TransitGenerateRandomRequest transitGenerateRandomRequest, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
            var transitGenerateRandomRequest = new TransitGenerateRandomRequest(); // TransitGenerateRandomRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Generate random bytes
                apiInstance.TransitGenerateRandom(TransitGenerateRandomRequest transitGenerateRandomRequest, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
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
 **transitGenerateRandomRequest** | [**TransitGenerateRandomRequest**](TransitGenerateRandomRequest.md)|  | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitgeneraterandomsource"></a>
# **TransitGenerateRandomSource**
> void TransitGenerateRandomSource (TransitGenerateRandomSourceRequest transitGenerateRandomSourceRequest, string source, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
    public class TransitGenerateRandomSourceExample
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
            var transitGenerateRandomSourceRequest = new TransitGenerateRandomSourceRequest(); // TransitGenerateRandomSourceRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Generate random bytes
                apiInstance.TransitGenerateRandomSource(TransitGenerateRandomSourceRequest transitGenerateRandomSourceRequest, string source, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitGenerateRandomSource: " + e.Message );
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
 **transitGenerateRandomSourceRequest** | [**TransitGenerateRandomSourceRequest**](TransitGenerateRandomSourceRequest.md)|  | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitgeneraterandomsourcebytes"></a>
# **TransitGenerateRandomSourceBytes**
> void TransitGenerateRandomSourceBytes (TransitGenerateRandomSourceBytesRequest transitGenerateRandomSourceBytesRequest, string source, string urlbytes, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
    public class TransitGenerateRandomSourceBytesExample
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
            var transitGenerateRandomSourceBytesRequest = new TransitGenerateRandomSourceBytesRequest(); // TransitGenerateRandomSourceBytesRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Generate random bytes
                apiInstance.TransitGenerateRandomSourceBytes(TransitGenerateRandomSourceBytesRequest transitGenerateRandomSourceBytesRequest, string source, string urlbytes, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitGenerateRandomSourceBytes: " + e.Message );
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
 **transitGenerateRandomSourceBytesRequest** | [**TransitGenerateRandomSourceBytesRequest**](TransitGenerateRandomSourceBytesRequest.md)|  | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transithash"></a>
# **TransitHash**
> void TransitHash (TransitHashRequest transitHashRequest, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
            var transitHashRequest = new TransitHashRequest(); // TransitHashRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Generate a hash sum for input data
                apiInstance.TransitHash(TransitHashRequest transitHashRequest, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
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
 **transitHashRequest** | [**TransitHashRequest**](TransitHashRequest.md)|  | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transithashwithalgorithm"></a>
# **TransitHashWithAlgorithm**
> void TransitHashWithAlgorithm (TransitHashWithAlgorithmRequest transitHashWithAlgorithmRequest, string urlalgorithm, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
            var transitHashWithAlgorithmRequest = new TransitHashWithAlgorithmRequest(); // TransitHashWithAlgorithmRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Generate a hash sum for input data
                apiInstance.TransitHashWithAlgorithm(TransitHashWithAlgorithmRequest transitHashWithAlgorithmRequest, string urlalgorithm, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
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
 **transitHashWithAlgorithmRequest** | [**TransitHashWithAlgorithmRequest**](TransitHashWithAlgorithmRequest.md)|  | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitimportkey"></a>
# **TransitImportKey**
> void TransitImportKey (TransitImportKeyRequest transitImportKeyRequest, string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
            var transitImportKeyRequest = new TransitImportKeyRequest(); // TransitImportKeyRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Imports an externally-generated key into a new transit key
                apiInstance.TransitImportKey(TransitImportKeyRequest transitImportKeyRequest, string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
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
 **transitImportKeyRequest** | [**TransitImportKeyRequest**](TransitImportKeyRequest.md)|  | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitimportkeyversion"></a>
# **TransitImportKeyVersion**
> void TransitImportKeyVersion (TransitImportKeyVersionRequest transitImportKeyVersionRequest, string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
            var transitImportKeyVersionRequest = new TransitImportKeyVersionRequest(); // TransitImportKeyVersionRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Imports an externally-generated key into an existing imported key
                apiInstance.TransitImportKeyVersion(TransitImportKeyVersionRequest transitImportKeyVersionRequest, string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
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
 **transitImportKeyVersionRequest** | [**TransitImportKeyVersionRequest**](TransitImportKeyVersionRequest.md)|  | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitlistkeys"></a>
# **TransitListKeys**
> void TransitListKeys (string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
            var list = "true";  // string | Must be set to `true`
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Managed named encryption keys
                apiInstance.TransitListKeys(string transitMountPath = "transit", TimeSpan? wrapTTL = null);
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
 **list** | **string**| Must be set to &#x60;true&#x60; | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitreadcacheconfig"></a>
# **TransitReadCacheConfig**
> void TransitReadCacheConfig (string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
    public class TransitReadCacheConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Returns the size of the active cache
                apiInstance.TransitReadCacheConfig(string transitMountPath = "transit", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitReadCacheConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitreadconfigkeys"></a>
# **TransitReadConfigKeys**
> void TransitReadConfigKeys (string transitMountPath = "transit", TimeSpan? wrapTTL = null)

Configuration common across all keys

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitReadConfigKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Configuration common across all keys
                apiInstance.TransitReadConfigKeys(string transitMountPath = "transit", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitReadConfigKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

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
> void TransitReadKey (string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Managed named encryption keys
                apiInstance.TransitReadKey(string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
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
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

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
> void TransitReadWrappingKey (string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Returns the public key to use for wrapping imported keys
                apiInstance.TransitReadWrappingKey(string transitMountPath = "transit", TimeSpan? wrapTTL = null);
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
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitrestore"></a>
# **TransitRestore**
> void TransitRestore (TransitRestoreRequest transitRestoreRequest, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
    public class TransitRestoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var transitRestoreRequest = new TransitRestoreRequest(); // TransitRestoreRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Restore the named key
                apiInstance.TransitRestore(TransitRestoreRequest transitRestoreRequest, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitRestore: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transitRestoreRequest** | [**TransitRestoreRequest**](TransitRestoreRequest.md)|  | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitrestorekey"></a>
# **TransitRestoreKey**
> void TransitRestoreKey (TransitRestoreKeyRequest transitRestoreKeyRequest, string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
            var name = "name_example";  // string | If set, this will be the name of the restored key.
            var transitRestoreKeyRequest = new TransitRestoreKeyRequest(); // TransitRestoreKeyRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Restore the named key
                apiInstance.TransitRestoreKey(TransitRestoreKeyRequest transitRestoreKeyRequest, string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
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
 **name** | **string**| If set, this will be the name of the restored key. | 
 **transitRestoreKeyRequest** | [**TransitRestoreKeyRequest**](TransitRestoreKeyRequest.md)|  | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitrewrap"></a>
# **TransitRewrap**
> void TransitRewrap (TransitRewrapRequest transitRewrapRequest, string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
            var transitRewrapRequest = new TransitRewrapRequest(); // TransitRewrapRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Rewrap ciphertext
                apiInstance.TransitRewrap(TransitRewrapRequest transitRewrapRequest, string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
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
 **transitRewrapRequest** | [**TransitRewrapRequest**](TransitRewrapRequest.md)|  | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitrotatekey"></a>
# **TransitRotateKey**
> void TransitRotateKey (string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Rotate named encryption key
                apiInstance.TransitRotateKey(string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
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
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitsign"></a>
# **TransitSign**
> void TransitSign (TransitSignRequest transitSignRequest, string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
            var transitSignRequest = new TransitSignRequest(); // TransitSignRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Generate a signature for input data using the named key
                apiInstance.TransitSign(TransitSignRequest transitSignRequest, string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
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
 **transitSignRequest** | [**TransitSignRequest**](TransitSignRequest.md)|  | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitsignwithalgorithm"></a>
# **TransitSignWithAlgorithm**
> void TransitSignWithAlgorithm (TransitSignWithAlgorithmRequest transitSignWithAlgorithmRequest, string name, string urlalgorithm, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
            var transitSignWithAlgorithmRequest = new TransitSignWithAlgorithmRequest(); // TransitSignWithAlgorithmRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Generate a signature for input data using the named key
                apiInstance.TransitSignWithAlgorithm(TransitSignWithAlgorithmRequest transitSignWithAlgorithmRequest, string name, string urlalgorithm, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
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
 **transitSignWithAlgorithmRequest** | [**TransitSignWithAlgorithmRequest**](TransitSignWithAlgorithmRequest.md)|  | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transittrimkey"></a>
# **TransitTrimKey**
> void TransitTrimKey (TransitTrimKeyRequest transitTrimKeyRequest, string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
            var transitTrimKeyRequest = new TransitTrimKeyRequest(); // TransitTrimKeyRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Trim key versions of a named key
                apiInstance.TransitTrimKey(TransitTrimKeyRequest transitTrimKeyRequest, string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
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
 **transitTrimKeyRequest** | [**TransitTrimKeyRequest**](TransitTrimKeyRequest.md)|  | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitverify"></a>
# **TransitVerify**
> void TransitVerify (TransitVerifyRequest transitVerifyRequest, string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
            var transitVerifyRequest = new TransitVerifyRequest(); // TransitVerifyRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Verify a signature or HMAC for input data created using the named key
                apiInstance.TransitVerify(TransitVerifyRequest transitVerifyRequest, string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
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
 **transitVerifyRequest** | [**TransitVerifyRequest**](TransitVerifyRequest.md)|  | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitverifywithalgorithm"></a>
# **TransitVerifyWithAlgorithm**
> void TransitVerifyWithAlgorithm (TransitVerifyWithAlgorithmRequest transitVerifyWithAlgorithmRequest, string name, string urlalgorithm, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
            var transitVerifyWithAlgorithmRequest = new TransitVerifyWithAlgorithmRequest(); // TransitVerifyWithAlgorithmRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Verify a signature or HMAC for input data created using the named key
                apiInstance.TransitVerifyWithAlgorithm(TransitVerifyWithAlgorithmRequest transitVerifyWithAlgorithmRequest, string name, string urlalgorithm, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
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
 **transitVerifyWithAlgorithmRequest** | [**TransitVerifyWithAlgorithmRequest**](TransitVerifyWithAlgorithmRequest.md)|  | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitwritecacheconfig"></a>
# **TransitWriteCacheConfig**
> void TransitWriteCacheConfig (TransitWriteCacheConfigRequest transitWriteCacheConfigRequest, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
    public class TransitWriteCacheConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var transitWriteCacheConfigRequest = new TransitWriteCacheConfigRequest(); // TransitWriteCacheConfigRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Configures a new cache of the specified size
                apiInstance.TransitWriteCacheConfig(TransitWriteCacheConfigRequest transitWriteCacheConfigRequest, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitWriteCacheConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transitWriteCacheConfigRequest** | [**TransitWriteCacheConfigRequest**](TransitWriteCacheConfigRequest.md)|  | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitwriteconfigkeys"></a>
# **TransitWriteConfigKeys**
> void TransitWriteConfigKeys (TransitWriteConfigKeysRequest transitWriteConfigKeysRequest, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

Configuration common across all keys

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class TransitWriteConfigKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var transitWriteConfigKeysRequest = new TransitWriteConfigKeysRequest(); // TransitWriteConfigKeysRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Configuration common across all keys
                apiInstance.TransitWriteConfigKeys(TransitWriteConfigKeysRequest transitWriteConfigKeysRequest, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitWriteConfigKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transitWriteConfigKeysRequest** | [**TransitWriteConfigKeysRequest**](TransitWriteConfigKeysRequest.md)|  | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitwritekey"></a>
# **TransitWriteKey**
> void TransitWriteKey (TransitWriteKeyRequest transitWriteKeyRequest, string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
    public class TransitWriteKeyExample
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
            var transitWriteKeyRequest = new TransitWriteKeyRequest(); // TransitWriteKeyRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Managed named encryption keys
                apiInstance.TransitWriteKey(TransitWriteKeyRequest transitWriteKeyRequest, string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitWriteKey: " + e.Message );
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
 **transitWriteKeyRequest** | [**TransitWriteKeyRequest**](TransitWriteKeyRequest.md)|  | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitwritekeyconfig"></a>
# **TransitWriteKeyConfig**
> void TransitWriteKeyConfig (TransitWriteKeyConfigRequest transitWriteKeyConfigRequest, string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
    public class TransitWriteKeyConfigExample
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
            var transitWriteKeyConfigRequest = new TransitWriteKeyConfigRequest(); // TransitWriteKeyConfigRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Configure a named encryption key
                apiInstance.TransitWriteKeyConfig(TransitWriteKeyConfigRequest transitWriteKeyConfigRequest, string name, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitWriteKeyConfig: " + e.Message );
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
 **transitWriteKeyConfigRequest** | [**TransitWriteKeyConfigRequest**](TransitWriteKeyConfigRequest.md)|  | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transitwriterandomurlbytes"></a>
# **TransitWriteRandomUrlbytes**
> void TransitWriteRandomUrlbytes (TransitWriteRandomUrlbytesRequest transitWriteRandomUrlbytesRequest, string urlbytes, string transitMountPath = "transit", TimeSpan? wrapTTL = null)

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
    public class TransitWriteRandomUrlbytesExample
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
            var transitWriteRandomUrlbytesRequest = new TransitWriteRandomUrlbytesRequest(); // TransitWriteRandomUrlbytesRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Generate random bytes
                apiInstance.TransitWriteRandomUrlbytes(TransitWriteRandomUrlbytesRequest transitWriteRandomUrlbytesRequest, string urlbytes, string transitMountPath = "transit", TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.TransitWriteRandomUrlbytes: " + e.Message );
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
 **transitWriteRandomUrlbytesRequest** | [**TransitWriteRandomUrlbytesRequest**](TransitWriteRandomUrlbytesRequest.md)|  | 
 **transitMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

