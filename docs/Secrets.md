# VaultClient.Api.Secrets

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAdConfig**](Secrets.md#deleteadconfig) | **DELETE** /ad/config | Configure the AD server to connect to, along with password options.
[**DeleteAdLibraryName**](Secrets.md#deleteadlibraryname) | **DELETE** /ad/library/{name} | Delete a library set.
[**DeleteAdRolesName**](Secrets.md#deleteadrolesname) | **DELETE** /ad/roles/{name} | Manage roles to build links between Vault and Active Directory service accounts.
[**DeleteAlicloudConfig**](Secrets.md#deletealicloudconfig) | **DELETE** /alicloud/config | Configure the access key and secret to use for RAM and STS calls.
[**DeleteAlicloudRoleName**](Secrets.md#deletealicloudrolename) | **DELETE** /alicloud/role/{name} | Read, write and reference policies and roles that API keys or STS credentials can be made for.
[**DeleteAwsRolesName**](Secrets.md#deleteawsrolesname) | **DELETE** /aws/roles/{name} | Read, write and reference IAM policies that access keys can be made for.
[**DeleteAzureConfig**](Secrets.md#deleteazureconfig) | **DELETE** /azure/config | 
[**DeleteAzureRolesName**](Secrets.md#deleteazurerolesname) | **DELETE** /azure/roles/{name} | Manage the Vault roles used to generate Azure credentials.
[**DeleteConsulRolesName**](Secrets.md#deleteconsulrolesname) | **DELETE** /consul/roles/{name} | 
[**DeleteCubbyholePath**](Secrets.md#deletecubbyholepath) | **DELETE** /cubbyhole/{path} | Deletes the secret at the specified location.
[**DeleteGcpRolesetName**](Secrets.md#deletegcprolesetname) | **DELETE** /gcp/roleset/{name} | 
[**DeleteGcpStaticAccountName**](Secrets.md#deletegcpstaticaccountname) | **DELETE** /gcp/static-account/{name} | 
[**DeleteGcpkmsConfig**](Secrets.md#deletegcpkmsconfig) | **DELETE** /gcpkms/config | Configure the GCP KMS secrets engine
[**DeleteGcpkmsKeysDeregisterKey**](Secrets.md#deletegcpkmskeysderegisterkey) | **DELETE** /gcpkms/keys/deregister/{key} | Deregister an existing key in Vault
[**DeleteGcpkmsKeysKey**](Secrets.md#deletegcpkmskeyskey) | **DELETE** /gcpkms/keys/{key} | Interact with crypto keys in Vault and Google Cloud KMS
[**DeleteGcpkmsKeysTrimKey**](Secrets.md#deletegcpkmskeystrimkey) | **DELETE** /gcpkms/keys/trim/{key} | Delete old crypto key versions from Google Cloud KMS
[**DeleteKubernetesConfig**](Secrets.md#deletekubernetesconfig) | **DELETE** /kubernetes/config | 
[**DeleteKubernetesRolesName**](Secrets.md#deletekubernetesrolesname) | **DELETE** /kubernetes/roles/{name} | 
[**DeleteKvPath**](Secrets.md#deletekvpath) | **DELETE** /kv/{path} | Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.
[**DeleteMongodbatlasRolesName**](Secrets.md#deletemongodbatlasrolesname) | **DELETE** /mongodbatlas/roles/{name} | Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
[**DeleteNomadConfigAccess**](Secrets.md#deletenomadconfigaccess) | **DELETE** /nomad/config/access | 
[**DeleteNomadConfigLease**](Secrets.md#deletenomadconfiglease) | **DELETE** /nomad/config/lease | Configure the lease parameters for generated tokens
[**DeleteNomadRoleName**](Secrets.md#deletenomadrolename) | **DELETE** /nomad/role/{name} | 
[**DeleteOpenldapConfig**](Secrets.md#deleteopenldapconfig) | **DELETE** /openldap/config | 
[**DeleteOpenldapRoleName**](Secrets.md#deleteopenldaprolename) | **DELETE** /openldap/role/{name} | 
[**DeleteOpenldapStaticRoleName**](Secrets.md#deleteopenldapstaticrolename) | **DELETE** /openldap/static-role/{name} | 
[**DeletePkiIssuerRefDerPem**](Secrets.md#deletepkiissuerrefderpem) | **DELETE** /pki/{issuer_ref}/der|/pem | 
[**DeletePkiJson**](Secrets.md#deletepkijson) | **DELETE** /pki//json | 
[**DeletePkiKeyKeyRef**](Secrets.md#deletepkikeykeyref) | **DELETE** /pki/key/{key_ref} | 
[**DeletePkiRolesName**](Secrets.md#deletepkirolesname) | **DELETE** /pki/roles/{name} | 
[**DeletePkiRoot**](Secrets.md#deletepkiroot) | **DELETE** /pki/root | 
[**DeleteRabbitmqRolesName**](Secrets.md#deleterabbitmqrolesname) | **DELETE** /rabbitmq/roles/{name} | Manage the roles that can be created with this backend.
[**DeleteSecretDataPath**](Secrets.md#deletesecretdatapath) | **DELETE** /secret/data/{path} | Write, Patch, Read, and Delete data in the Key-Value Store.
[**DeleteSecretMetadataPath**](Secrets.md#deletesecretmetadatapath) | **DELETE** /secret/metadata/{path} | Configures settings for the KV store
[**DeleteSshConfigCa**](Secrets.md#deletesshconfigca) | **DELETE** /ssh/config/ca | Set the SSH private key used for signing certificates.
[**DeleteSshConfigZeroaddress**](Secrets.md#deletesshconfigzeroaddress) | **DELETE** /ssh/config/zeroaddress | Assign zero address as default CIDR block for select roles.
[**DeleteSshKeysKeyName**](Secrets.md#deletesshkeyskeyname) | **DELETE** /ssh/keys/{key_name} | Register a shared private key with Vault.
[**DeleteSshRolesRole**](Secrets.md#deletesshrolesrole) | **DELETE** /ssh/roles/{role} | Manage the &#39;roles&#39; that can be created with this backend.
[**DeleteTerraformConfig**](Secrets.md#deleteterraformconfig) | **DELETE** /terraform/config | 
[**DeleteTerraformRoleName**](Secrets.md#deleteterraformrolename) | **DELETE** /terraform/role/{name} | 
[**DeleteTotpKeysName**](Secrets.md#deletetotpkeysname) | **DELETE** /totp/keys/{name} | Manage the keys that can be created with this backend.
[**DeleteTransitKeysName**](Secrets.md#deletetransitkeysname) | **DELETE** /transit/keys/{name} | Managed named encryption keys
[**GetAdConfig**](Secrets.md#getadconfig) | **GET** /ad/config | Configure the AD server to connect to, along with password options.
[**GetAdCredsName**](Secrets.md#getadcredsname) | **GET** /ad/creds/{name} | 
[**GetAdLibrary**](Secrets.md#getadlibrary) | **GET** /ad/library | 
[**GetAdLibraryName**](Secrets.md#getadlibraryname) | **GET** /ad/library/{name} | Read a library set.
[**GetAdLibraryNameStatus**](Secrets.md#getadlibrarynamestatus) | **GET** /ad/library/{name}/status | Check the status of the service accounts in a library set.
[**GetAdRoles**](Secrets.md#getadroles) | **GET** /ad/roles | List the name of each role currently stored.
[**GetAdRolesName**](Secrets.md#getadrolesname) | **GET** /ad/roles/{name} | Manage roles to build links between Vault and Active Directory service accounts.
[**GetAdRotateRoot**](Secrets.md#getadrotateroot) | **GET** /ad/rotate-root | 
[**GetAlicloudConfig**](Secrets.md#getalicloudconfig) | **GET** /alicloud/config | Configure the access key and secret to use for RAM and STS calls.
[**GetAlicloudCredsName**](Secrets.md#getalicloudcredsname) | **GET** /alicloud/creds/{name} | Generate an API key or STS credential using the given role&#39;s configuration.&#39;
[**GetAlicloudRole**](Secrets.md#getalicloudrole) | **GET** /alicloud/role | List the existing roles in this backend.
[**GetAlicloudRoleName**](Secrets.md#getalicloudrolename) | **GET** /alicloud/role/{name} | Read, write and reference policies and roles that API keys or STS credentials can be made for.
[**GetAwsConfigLease**](Secrets.md#getawsconfiglease) | **GET** /aws/config/lease | Configure the default lease information for generated credentials.
[**GetAwsConfigRoot**](Secrets.md#getawsconfigroot) | **GET** /aws/config/root | Configure the root credentials that are used to manage IAM.
[**GetAwsCreds**](Secrets.md#getawscreds) | **GET** /aws/creds | Generate AWS credentials from a specific Vault role.
[**GetAwsRoles**](Secrets.md#getawsroles) | **GET** /aws/roles | List the existing roles in this backend
[**GetAwsRolesName**](Secrets.md#getawsrolesname) | **GET** /aws/roles/{name} | Read, write and reference IAM policies that access keys can be made for.
[**GetAwsStsName**](Secrets.md#getawsstsname) | **GET** /aws/sts/{name} | Generate AWS credentials from a specific Vault role.
[**GetAzureConfig**](Secrets.md#getazureconfig) | **GET** /azure/config | 
[**GetAzureCredsRole**](Secrets.md#getazurecredsrole) | **GET** /azure/creds/{role} | 
[**GetAzureRoles**](Secrets.md#getazureroles) | **GET** /azure/roles | List existing roles.
[**GetAzureRolesName**](Secrets.md#getazurerolesname) | **GET** /azure/roles/{name} | Manage the Vault roles used to generate Azure credentials.
[**GetConsulConfigAccess**](Secrets.md#getconsulconfigaccess) | **GET** /consul/config/access | 
[**GetConsulCredsRole**](Secrets.md#getconsulcredsrole) | **GET** /consul/creds/{role} | 
[**GetConsulRoles**](Secrets.md#getconsulroles) | **GET** /consul/roles | 
[**GetConsulRolesName**](Secrets.md#getconsulrolesname) | **GET** /consul/roles/{name} | 
[**GetCubbyholePath**](Secrets.md#getcubbyholepath) | **GET** /cubbyhole/{path} | Retrieve the secret at the specified location.
[**GetGcpConfig**](Secrets.md#getgcpconfig) | **GET** /gcp/config | 
[**GetGcpKeyRoleset**](Secrets.md#getgcpkeyroleset) | **GET** /gcp/key/{roleset} | 
[**GetGcpRolesetName**](Secrets.md#getgcprolesetname) | **GET** /gcp/roleset/{name} | 
[**GetGcpRolesetRolesetKey**](Secrets.md#getgcprolesetrolesetkey) | **GET** /gcp/roleset/{roleset}/key | 
[**GetGcpRolesetRolesetToken**](Secrets.md#getgcprolesetrolesettoken) | **GET** /gcp/roleset/{roleset}/token | 
[**GetGcpRolesets**](Secrets.md#getgcprolesets) | **GET** /gcp/rolesets | 
[**GetGcpStaticAccountName**](Secrets.md#getgcpstaticaccountname) | **GET** /gcp/static-account/{name} | 
[**GetGcpStaticAccountNameKey**](Secrets.md#getgcpstaticaccountnamekey) | **GET** /gcp/static-account/{name}/key | 
[**GetGcpStaticAccountNameToken**](Secrets.md#getgcpstaticaccountnametoken) | **GET** /gcp/static-account/{name}/token | 
[**GetGcpStaticAccounts**](Secrets.md#getgcpstaticaccounts) | **GET** /gcp/static-accounts | 
[**GetGcpTokenRoleset**](Secrets.md#getgcptokenroleset) | **GET** /gcp/token/{roleset} | 
[**GetGcpkmsConfig**](Secrets.md#getgcpkmsconfig) | **GET** /gcpkms/config | Configure the GCP KMS secrets engine
[**GetGcpkmsKeys**](Secrets.md#getgcpkmskeys) | **GET** /gcpkms/keys | List named keys
[**GetGcpkmsKeysConfigKey**](Secrets.md#getgcpkmskeysconfigkey) | **GET** /gcpkms/keys/config/{key} | Configure the key in Vault
[**GetGcpkmsKeysKey**](Secrets.md#getgcpkmskeyskey) | **GET** /gcpkms/keys/{key} | Interact with crypto keys in Vault and Google Cloud KMS
[**GetGcpkmsPubkeyKey**](Secrets.md#getgcpkmspubkeykey) | **GET** /gcpkms/pubkey/{key} | Retrieve the public key associated with the named key
[**GetKubernetesConfig**](Secrets.md#getkubernetesconfig) | **GET** /kubernetes/config | 
[**GetKubernetesRoles**](Secrets.md#getkubernetesroles) | **GET** /kubernetes/roles | 
[**GetKubernetesRolesName**](Secrets.md#getkubernetesrolesname) | **GET** /kubernetes/roles/{name} | 
[**GetKvPath**](Secrets.md#getkvpath) | **GET** /kv/{path} | Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.
[**GetMongodbatlasConfig**](Secrets.md#getmongodbatlasconfig) | **GET** /mongodbatlas/config | Configure the  credentials that are used to manage Database Users.
[**GetMongodbatlasCredsName**](Secrets.md#getmongodbatlascredsname) | **GET** /mongodbatlas/creds/{name} | Generate MongoDB Atlas Programmatic API from a specific Vault role.
[**GetMongodbatlasRoles**](Secrets.md#getmongodbatlasroles) | **GET** /mongodbatlas/roles | List the existing roles in this backend
[**GetMongodbatlasRolesName**](Secrets.md#getmongodbatlasrolesname) | **GET** /mongodbatlas/roles/{name} | Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
[**GetNomadConfigAccess**](Secrets.md#getnomadconfigaccess) | **GET** /nomad/config/access | 
[**GetNomadConfigLease**](Secrets.md#getnomadconfiglease) | **GET** /nomad/config/lease | Configure the lease parameters for generated tokens
[**GetNomadCredsName**](Secrets.md#getnomadcredsname) | **GET** /nomad/creds/{name} | 
[**GetNomadRole**](Secrets.md#getnomadrole) | **GET** /nomad/role | 
[**GetNomadRoleName**](Secrets.md#getnomadrolename) | **GET** /nomad/role/{name} | 
[**GetOpenldapConfig**](Secrets.md#getopenldapconfig) | **GET** /openldap/config | 
[**GetOpenldapCredsName**](Secrets.md#getopenldapcredsname) | **GET** /openldap/creds/{name} | 
[**GetOpenldapRole**](Secrets.md#getopenldaprole) | **GET** /openldap/role | 
[**GetOpenldapRoleName**](Secrets.md#getopenldaprolename) | **GET** /openldap/role/{name} | 
[**GetOpenldapStaticCredName**](Secrets.md#getopenldapstaticcredname) | **GET** /openldap/static-cred/{name} | 
[**GetOpenldapStaticRole**](Secrets.md#getopenldapstaticrole) | **GET** /openldap/static-role | 
[**GetOpenldapStaticRoleName**](Secrets.md#getopenldapstaticrolename) | **GET** /openldap/static-role/{name} | 
[**GetPkiCa**](Secrets.md#getpkica) | **GET** /pki/ca | 
[**GetPkiCaChain**](Secrets.md#getpkicachain) | **GET** /pki/ca_chain | 
[**GetPkiCaPem**](Secrets.md#getpkicapem) | **GET** /pki/ca/pem | 
[**GetPkiCertCaChain**](Secrets.md#getpkicertcachain) | **GET** /pki/cert/ca_chain | 
[**GetPkiCertCrl**](Secrets.md#getpkicertcrl) | **GET** /pki/cert/crl | 
[**GetPkiCertSerial**](Secrets.md#getpkicertserial) | **GET** /pki/cert/{serial} | 
[**GetPkiCertSerialRaw**](Secrets.md#getpkicertserialraw) | **GET** /pki/cert/{serial}/raw | 
[**GetPkiCertSerialRawPem**](Secrets.md#getpkicertserialrawpem) | **GET** /pki/cert/{serial}/raw/pem | 
[**GetPkiCerts**](Secrets.md#getpkicerts) | **GET** /pki/certs | 
[**GetPkiConfigCrl**](Secrets.md#getpkiconfigcrl) | **GET** /pki/config/crl | 
[**GetPkiConfigIssuers**](Secrets.md#getpkiconfigissuers) | **GET** /pki/config/issuers | 
[**GetPkiConfigKeys**](Secrets.md#getpkiconfigkeys) | **GET** /pki/config/keys | 
[**GetPkiConfigUrls**](Secrets.md#getpkiconfigurls) | **GET** /pki/config/urls | 
[**GetPkiCrl**](Secrets.md#getpkicrl) | **GET** /pki/crl | 
[**GetPkiCrlPem**](Secrets.md#getpkicrlpem) | **GET** /pki/crl/pem | 
[**GetPkiCrlRotate**](Secrets.md#getpkicrlrotate) | **GET** /pki/crl/rotate | 
[**GetPkiDer**](Secrets.md#getpkider) | **GET** /pki//der | 
[**GetPkiIssuerRefCrlPem**](Secrets.md#getpkiissuerrefcrlpem) | **GET** /pki/{issuer_ref}/crl/pem | 
[**GetPkiIssuerRefDerPem**](Secrets.md#getpkiissuerrefderpem) | **GET** /pki/{issuer_ref}/der|/pem | 
[**GetPkiIssuers**](Secrets.md#getpkiissuers) | **GET** /pki/issuers | 
[**GetPkiJson**](Secrets.md#getpkijson) | **GET** /pki//json | 
[**GetPkiKeyKeyRef**](Secrets.md#getpkikeykeyref) | **GET** /pki/key/{key_ref} | 
[**GetPkiKeys**](Secrets.md#getpkikeys) | **GET** /pki/keys | 
[**GetPkiRoles**](Secrets.md#getpkiroles) | **GET** /pki/roles | 
[**GetPkiRolesName**](Secrets.md#getpkirolesname) | **GET** /pki/roles/{name} | 
[**GetPkiTidyStatus**](Secrets.md#getpkitidystatus) | **GET** /pki/tidy-status | 
[**GetRabbitmqConfigLease**](Secrets.md#getrabbitmqconfiglease) | **GET** /rabbitmq/config/lease | Configure the lease parameters for generated credentials
[**GetRabbitmqCredsName**](Secrets.md#getrabbitmqcredsname) | **GET** /rabbitmq/creds/{name} | Request RabbitMQ credentials for a certain role.
[**GetRabbitmqRoles**](Secrets.md#getrabbitmqroles) | **GET** /rabbitmq/roles | Manage the roles that can be created with this backend.
[**GetRabbitmqRolesName**](Secrets.md#getrabbitmqrolesname) | **GET** /rabbitmq/roles/{name} | Manage the roles that can be created with this backend.
[**GetSecretConfig**](Secrets.md#getsecretconfig) | **GET** /secret/config | Read the backend level settings.
[**GetSecretDataPath**](Secrets.md#getsecretdatapath) | **GET** /secret/data/{path} | Write, Patch, Read, and Delete data in the Key-Value Store.
[**GetSecretMetadataPath**](Secrets.md#getsecretmetadatapath) | **GET** /secret/metadata/{path} | Configures settings for the KV store
[**GetSecretSubkeysPath**](Secrets.md#getsecretsubkeyspath) | **GET** /secret/subkeys/{path} | Read the structure of a secret entry from the Key-Value store with the values removed.
[**GetSshConfigCa**](Secrets.md#getsshconfigca) | **GET** /ssh/config/ca | Set the SSH private key used for signing certificates.
[**GetSshConfigZeroaddress**](Secrets.md#getsshconfigzeroaddress) | **GET** /ssh/config/zeroaddress | Assign zero address as default CIDR block for select roles.
[**GetSshPublicKey**](Secrets.md#getsshpublickey) | **GET** /ssh/public_key | Retrieve the public key.
[**GetSshRoles**](Secrets.md#getsshroles) | **GET** /ssh/roles | Manage the &#39;roles&#39; that can be created with this backend.
[**GetSshRolesRole**](Secrets.md#getsshrolesrole) | **GET** /ssh/roles/{role} | Manage the &#39;roles&#39; that can be created with this backend.
[**GetTerraformConfig**](Secrets.md#getterraformconfig) | **GET** /terraform/config | 
[**GetTerraformCredsName**](Secrets.md#getterraformcredsname) | **GET** /terraform/creds/{name} | Generate a Terraform Cloud or Enterprise API token from a specific Vault role.
[**GetTerraformRole**](Secrets.md#getterraformrole) | **GET** /terraform/role | 
[**GetTerraformRoleName**](Secrets.md#getterraformrolename) | **GET** /terraform/role/{name} | 
[**GetTotpCodeName**](Secrets.md#gettotpcodename) | **GET** /totp/code/{name} | Request time-based one-time use password or validate a password for a certain key .
[**GetTotpKeys**](Secrets.md#gettotpkeys) | **GET** /totp/keys | Manage the keys that can be created with this backend.
[**GetTotpKeysName**](Secrets.md#gettotpkeysname) | **GET** /totp/keys/{name} | Manage the keys that can be created with this backend.
[**GetTransitBackupName**](Secrets.md#gettransitbackupname) | **GET** /transit/backup/{name} | Backup the named key
[**GetTransitCacheConfig**](Secrets.md#gettransitcacheconfig) | **GET** /transit/cache-config | Returns the size of the active cache
[**GetTransitExportTypeName**](Secrets.md#gettransitexporttypename) | **GET** /transit/export/{type}/{name} | Export named encryption or signing key
[**GetTransitExportTypeNameVersion**](Secrets.md#gettransitexporttypenameversion) | **GET** /transit/export/{type}/{name}/{version} | Export named encryption or signing key
[**GetTransitKeys**](Secrets.md#gettransitkeys) | **GET** /transit/keys | Managed named encryption keys
[**GetTransitKeysName**](Secrets.md#gettransitkeysname) | **GET** /transit/keys/{name} | Managed named encryption keys
[**GetTransitWrappingKey**](Secrets.md#gettransitwrappingkey) | **GET** /transit/wrapping_key | Returns the public key to use for wrapping imported keys
[**PostAdConfig**](Secrets.md#postadconfig) | **POST** /ad/config | Configure the AD server to connect to, along with password options.
[**PostAdLibraryManageNameCheckIn**](Secrets.md#postadlibrarymanagenamecheckin) | **POST** /ad/library/manage/{name}/check-in | Check service accounts in to the library.
[**PostAdLibraryName**](Secrets.md#postadlibraryname) | **POST** /ad/library/{name} | Update a library set.
[**PostAdLibraryNameCheckIn**](Secrets.md#postadlibrarynamecheckin) | **POST** /ad/library/{name}/check-in | Check service accounts in to the library.
[**PostAdLibraryNameCheckOut**](Secrets.md#postadlibrarynamecheckout) | **POST** /ad/library/{name}/check-out | Check a service account out from the library.
[**PostAdRolesName**](Secrets.md#postadrolesname) | **POST** /ad/roles/{name} | Manage roles to build links between Vault and Active Directory service accounts.
[**PostAdRotateRoleName**](Secrets.md#postadrotaterolename) | **POST** /ad/rotate-role/{name} | 
[**PostAdRotateRoot**](Secrets.md#postadrotateroot) | **POST** /ad/rotate-root | 
[**PostAlicloudConfig**](Secrets.md#postalicloudconfig) | **POST** /alicloud/config | Configure the access key and secret to use for RAM and STS calls.
[**PostAlicloudRoleName**](Secrets.md#postalicloudrolename) | **POST** /alicloud/role/{name} | Read, write and reference policies and roles that API keys or STS credentials can be made for.
[**PostAwsConfigLease**](Secrets.md#postawsconfiglease) | **POST** /aws/config/lease | Configure the default lease information for generated credentials.
[**PostAwsConfigRoot**](Secrets.md#postawsconfigroot) | **POST** /aws/config/root | Configure the root credentials that are used to manage IAM.
[**PostAwsConfigRotateRoot**](Secrets.md#postawsconfigrotateroot) | **POST** /aws/config/rotate-root | 
[**PostAwsCreds**](Secrets.md#postawscreds) | **POST** /aws/creds | Generate AWS credentials from a specific Vault role.
[**PostAwsRolesName**](Secrets.md#postawsrolesname) | **POST** /aws/roles/{name} | Read, write and reference IAM policies that access keys can be made for.
[**PostAwsStsName**](Secrets.md#postawsstsname) | **POST** /aws/sts/{name} | Generate AWS credentials from a specific Vault role.
[**PostAzureConfig**](Secrets.md#postazureconfig) | **POST** /azure/config | 
[**PostAzureRolesName**](Secrets.md#postazurerolesname) | **POST** /azure/roles/{name} | Manage the Vault roles used to generate Azure credentials.
[**PostAzureRotateRoot**](Secrets.md#postazurerotateroot) | **POST** /azure/rotate-root | 
[**PostConsulConfigAccess**](Secrets.md#postconsulconfigaccess) | **POST** /consul/config/access | 
[**PostConsulRolesName**](Secrets.md#postconsulrolesname) | **POST** /consul/roles/{name} | 
[**PostCubbyholePath**](Secrets.md#postcubbyholepath) | **POST** /cubbyhole/{path} | Store a secret at the specified location.
[**PostGcpConfig**](Secrets.md#postgcpconfig) | **POST** /gcp/config | 
[**PostGcpConfigRotateRoot**](Secrets.md#postgcpconfigrotateroot) | **POST** /gcp/config/rotate-root | 
[**PostGcpKeyRoleset**](Secrets.md#postgcpkeyroleset) | **POST** /gcp/key/{roleset} | 
[**PostGcpRolesetName**](Secrets.md#postgcprolesetname) | **POST** /gcp/roleset/{name} | 
[**PostGcpRolesetNameRotate**](Secrets.md#postgcprolesetnamerotate) | **POST** /gcp/roleset/{name}/rotate | 
[**PostGcpRolesetNameRotateKey**](Secrets.md#postgcprolesetnamerotatekey) | **POST** /gcp/roleset/{name}/rotate-key | 
[**PostGcpRolesetRolesetKey**](Secrets.md#postgcprolesetrolesetkey) | **POST** /gcp/roleset/{roleset}/key | 
[**PostGcpRolesetRolesetToken**](Secrets.md#postgcprolesetrolesettoken) | **POST** /gcp/roleset/{roleset}/token | 
[**PostGcpStaticAccountName**](Secrets.md#postgcpstaticaccountname) | **POST** /gcp/static-account/{name} | 
[**PostGcpStaticAccountNameKey**](Secrets.md#postgcpstaticaccountnamekey) | **POST** /gcp/static-account/{name}/key | 
[**PostGcpStaticAccountNameRotateKey**](Secrets.md#postgcpstaticaccountnamerotatekey) | **POST** /gcp/static-account/{name}/rotate-key | 
[**PostGcpStaticAccountNameToken**](Secrets.md#postgcpstaticaccountnametoken) | **POST** /gcp/static-account/{name}/token | 
[**PostGcpTokenRoleset**](Secrets.md#postgcptokenroleset) | **POST** /gcp/token/{roleset} | 
[**PostGcpkmsConfig**](Secrets.md#postgcpkmsconfig) | **POST** /gcpkms/config | Configure the GCP KMS secrets engine
[**PostGcpkmsDecryptKey**](Secrets.md#postgcpkmsdecryptkey) | **POST** /gcpkms/decrypt/{key} | Decrypt a ciphertext value using a named key
[**PostGcpkmsEncryptKey**](Secrets.md#postgcpkmsencryptkey) | **POST** /gcpkms/encrypt/{key} | Encrypt a plaintext value using a named key
[**PostGcpkmsKeysConfigKey**](Secrets.md#postgcpkmskeysconfigkey) | **POST** /gcpkms/keys/config/{key} | Configure the key in Vault
[**PostGcpkmsKeysDeregisterKey**](Secrets.md#postgcpkmskeysderegisterkey) | **POST** /gcpkms/keys/deregister/{key} | Deregister an existing key in Vault
[**PostGcpkmsKeysKey**](Secrets.md#postgcpkmskeyskey) | **POST** /gcpkms/keys/{key} | Interact with crypto keys in Vault and Google Cloud KMS
[**PostGcpkmsKeysRegisterKey**](Secrets.md#postgcpkmskeysregisterkey) | **POST** /gcpkms/keys/register/{key} | Register an existing crypto key in Google Cloud KMS
[**PostGcpkmsKeysRotateKey**](Secrets.md#postgcpkmskeysrotatekey) | **POST** /gcpkms/keys/rotate/{key} | Rotate a crypto key to a new primary version
[**PostGcpkmsKeysTrimKey**](Secrets.md#postgcpkmskeystrimkey) | **POST** /gcpkms/keys/trim/{key} | Delete old crypto key versions from Google Cloud KMS
[**PostGcpkmsReencryptKey**](Secrets.md#postgcpkmsreencryptkey) | **POST** /gcpkms/reencrypt/{key} | Re-encrypt existing ciphertext data to a new version
[**PostGcpkmsSignKey**](Secrets.md#postgcpkmssignkey) | **POST** /gcpkms/sign/{key} | Signs a message or digest using a named key
[**PostGcpkmsVerifyKey**](Secrets.md#postgcpkmsverifykey) | **POST** /gcpkms/verify/{key} | Verify a signature using a named key
[**PostKubernetesConfig**](Secrets.md#postkubernetesconfig) | **POST** /kubernetes/config | 
[**PostKubernetesCredsName**](Secrets.md#postkubernetescredsname) | **POST** /kubernetes/creds/{name} | 
[**PostKubernetesRolesName**](Secrets.md#postkubernetesrolesname) | **POST** /kubernetes/roles/{name} | 
[**PostKvPath**](Secrets.md#postkvpath) | **POST** /kv/{path} | Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.
[**PostMongodbatlasConfig**](Secrets.md#postmongodbatlasconfig) | **POST** /mongodbatlas/config | Configure the  credentials that are used to manage Database Users.
[**PostMongodbatlasCredsName**](Secrets.md#postmongodbatlascredsname) | **POST** /mongodbatlas/creds/{name} | Generate MongoDB Atlas Programmatic API from a specific Vault role.
[**PostMongodbatlasRolesName**](Secrets.md#postmongodbatlasrolesname) | **POST** /mongodbatlas/roles/{name} | Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
[**PostNomadConfigAccess**](Secrets.md#postnomadconfigaccess) | **POST** /nomad/config/access | 
[**PostNomadConfigLease**](Secrets.md#postnomadconfiglease) | **POST** /nomad/config/lease | Configure the lease parameters for generated tokens
[**PostNomadRoleName**](Secrets.md#postnomadrolename) | **POST** /nomad/role/{name} | 
[**PostOpenldapConfig**](Secrets.md#postopenldapconfig) | **POST** /openldap/config | 
[**PostOpenldapRoleName**](Secrets.md#postopenldaprolename) | **POST** /openldap/role/{name} | 
[**PostOpenldapRotateRoleName**](Secrets.md#postopenldaprotaterolename) | **POST** /openldap/rotate-role/{name} | 
[**PostOpenldapRotateRoot**](Secrets.md#postopenldaprotateroot) | **POST** /openldap/rotate-root | 
[**PostOpenldapStaticRoleName**](Secrets.md#postopenldapstaticrolename) | **POST** /openldap/static-role/{name} | 
[**PostPkiBundle**](Secrets.md#postpkibundle) | **POST** /pki/bundle | 
[**PostPkiCert**](Secrets.md#postpkicert) | **POST** /pki/cert | 
[**PostPkiConfigCa**](Secrets.md#postpkiconfigca) | **POST** /pki/config/ca | 
[**PostPkiConfigCrl**](Secrets.md#postpkiconfigcrl) | **POST** /pki/config/crl | 
[**PostPkiConfigIssuers**](Secrets.md#postpkiconfigissuers) | **POST** /pki/config/issuers | 
[**PostPkiConfigKeys**](Secrets.md#postpkiconfigkeys) | **POST** /pki/config/keys | 
[**PostPkiConfigUrls**](Secrets.md#postpkiconfigurls) | **POST** /pki/config/urls | 
[**PostPkiIntermediateCrossSign**](Secrets.md#postpkiintermediatecrosssign) | **POST** /pki/intermediate/cross-sign | 
[**PostPkiIntermediateGenerateExported**](Secrets.md#postpkiintermediategenerateexported) | **POST** /pki/intermediate/generate/{exported} | 
[**PostPkiIntermediateSetSigned**](Secrets.md#postpkiintermediatesetsigned) | **POST** /pki/intermediate/set-signed | 
[**PostPkiInternalExported**](Secrets.md#postpkiinternalexported) | **POST** /pki/internal|exported | 
[**PostPkiIssueRole**](Secrets.md#postpkiissuerole) | **POST** /pki/issue/{role} | 
[**PostPkiIssuerIssuerRefIssueRole**](Secrets.md#postpkiissuerissuerrefissuerole) | **POST** /pki/issuer/{issuer_ref}/issue/{role} | 
[**PostPkiIssuerIssuerRefSignIntermediate**](Secrets.md#postpkiissuerissuerrefsignintermediate) | **POST** /pki/issuer/{issuer_ref}/sign-intermediate | 
[**PostPkiIssuerIssuerRefSignRole**](Secrets.md#postpkiissuerissuerrefsignrole) | **POST** /pki/issuer/{issuer_ref}/sign/{role} | 
[**PostPkiIssuerIssuerRefSignSelfIssued**](Secrets.md#postpkiissuerissuerrefsignselfissued) | **POST** /pki/issuer/{issuer_ref}/sign-self-issued | 
[**PostPkiIssuerIssuerRefSignVerbatim**](Secrets.md#postpkiissuerissuerrefsignverbatim) | **POST** /pki/issuer/{issuer_ref}/sign-verbatim | 
[**PostPkiIssuerIssuerRefSignVerbatimRole**](Secrets.md#postpkiissuerissuerrefsignverbatimrole) | **POST** /pki/issuer/{issuer_ref}/sign-verbatim/{role} | 
[**PostPkiIssuerRefDerPem**](Secrets.md#postpkiissuerrefderpem) | **POST** /pki/{issuer_ref}/der|/pem | 
[**PostPkiIssuersGenerateIntermediateExported**](Secrets.md#postpkiissuersgenerateintermediateexported) | **POST** /pki/issuers/generate/intermediate/{exported} | 
[**PostPkiIssuersGenerateRootExported**](Secrets.md#postpkiissuersgeneraterootexported) | **POST** /pki/issuers/generate/root/{exported} | 
[**PostPkiJson**](Secrets.md#postpkijson) | **POST** /pki//json | 
[**PostPkiKeyKeyRef**](Secrets.md#postpkikeykeyref) | **POST** /pki/key/{key_ref} | 
[**PostPkiKeysImport**](Secrets.md#postpkikeysimport) | **POST** /pki/keys/import | 
[**PostPkiKms**](Secrets.md#postpkikms) | **POST** /pki/kms | 
[**PostPkiRevoke**](Secrets.md#postpkirevoke) | **POST** /pki/revoke | 
[**PostPkiRolesName**](Secrets.md#postpkirolesname) | **POST** /pki/roles/{name} | 
[**PostPkiRootGenerateExported**](Secrets.md#postpkirootgenerateexported) | **POST** /pki/root/generate/{exported} | 
[**PostPkiRootReplace**](Secrets.md#postpkirootreplace) | **POST** /pki/root/replace | 
[**PostPkiRootRotateExported**](Secrets.md#postpkirootrotateexported) | **POST** /pki/root/rotate/{exported} | 
[**PostPkiRootSignIntermediate**](Secrets.md#postpkirootsignintermediate) | **POST** /pki/root/sign-intermediate | 
[**PostPkiRootSignSelfIssued**](Secrets.md#postpkirootsignselfissued) | **POST** /pki/root/sign-self-issued | 
[**PostPkiSignRole**](Secrets.md#postpkisignrole) | **POST** /pki/sign/{role} | 
[**PostPkiSignVerbatim**](Secrets.md#postpkisignverbatim) | **POST** /pki/sign-verbatim | 
[**PostPkiSignVerbatimRole**](Secrets.md#postpkisignverbatimrole) | **POST** /pki/sign-verbatim/{role} | 
[**PostPkiTidy**](Secrets.md#postpkitidy) | **POST** /pki/tidy | 
[**PostRabbitmqConfigConnection**](Secrets.md#postrabbitmqconfigconnection) | **POST** /rabbitmq/config/connection | Configure the connection URI, username, and password to talk to RabbitMQ management HTTP API.
[**PostRabbitmqConfigLease**](Secrets.md#postrabbitmqconfiglease) | **POST** /rabbitmq/config/lease | Configure the lease parameters for generated credentials
[**PostRabbitmqRolesName**](Secrets.md#postrabbitmqrolesname) | **POST** /rabbitmq/roles/{name} | Manage the roles that can be created with this backend.
[**PostSecretConfig**](Secrets.md#postsecretconfig) | **POST** /secret/config | Configure backend level settings that are applied to every key in the key-value store.
[**PostSecretDataPath**](Secrets.md#postsecretdatapath) | **POST** /secret/data/{path} | Write, Patch, Read, and Delete data in the Key-Value Store.
[**PostSecretDeletePath**](Secrets.md#postsecretdeletepath) | **POST** /secret/delete/{path} | Marks one or more versions as deleted in the KV store.
[**PostSecretDestroyPath**](Secrets.md#postsecretdestroypath) | **POST** /secret/destroy/{path} | Permanently removes one or more versions in the KV store
[**PostSecretMetadataPath**](Secrets.md#postsecretmetadatapath) | **POST** /secret/metadata/{path} | Configures settings for the KV store
[**PostSecretUndeletePath**](Secrets.md#postsecretundeletepath) | **POST** /secret/undelete/{path} | Undeletes one or more versions from the KV store.
[**PostSshConfigCa**](Secrets.md#postsshconfigca) | **POST** /ssh/config/ca | Set the SSH private key used for signing certificates.
[**PostSshConfigZeroaddress**](Secrets.md#postsshconfigzeroaddress) | **POST** /ssh/config/zeroaddress | Assign zero address as default CIDR block for select roles.
[**PostSshCredsRole**](Secrets.md#postsshcredsrole) | **POST** /ssh/creds/{role} | Creates a credential for establishing SSH connection with the remote host.
[**PostSshKeysKeyName**](Secrets.md#postsshkeyskeyname) | **POST** /ssh/keys/{key_name} | Register a shared private key with Vault.
[**PostSshLookup**](Secrets.md#postsshlookup) | **POST** /ssh/lookup | List all the roles associated with the given IP address.
[**PostSshRolesRole**](Secrets.md#postsshrolesrole) | **POST** /ssh/roles/{role} | Manage the &#39;roles&#39; that can be created with this backend.
[**PostSshSignRole**](Secrets.md#postsshsignrole) | **POST** /ssh/sign/{role} | Request signing an SSH key using a certain role with the provided details.
[**PostSshVerify**](Secrets.md#postsshverify) | **POST** /ssh/verify | Validate the OTP provided by Vault SSH Agent.
[**PostTerraformConfig**](Secrets.md#postterraformconfig) | **POST** /terraform/config | 
[**PostTerraformCredsName**](Secrets.md#postterraformcredsname) | **POST** /terraform/creds/{name} | Generate a Terraform Cloud or Enterprise API token from a specific Vault role.
[**PostTerraformRoleName**](Secrets.md#postterraformrolename) | **POST** /terraform/role/{name} | 
[**PostTerraformRotateRoleName**](Secrets.md#postterraformrotaterolename) | **POST** /terraform/rotate-role/{name} | 
[**PostTotpCodeName**](Secrets.md#posttotpcodename) | **POST** /totp/code/{name} | Request time-based one-time use password or validate a password for a certain key .
[**PostTotpKeysName**](Secrets.md#posttotpkeysname) | **POST** /totp/keys/{name} | Manage the keys that can be created with this backend.
[**PostTransitCacheConfig**](Secrets.md#posttransitcacheconfig) | **POST** /transit/cache-config | Configures a new cache of the specified size
[**PostTransitDatakeyPlaintextName**](Secrets.md#posttransitdatakeyplaintextname) | **POST** /transit/datakey/{plaintext}/{name} | Generate a data key
[**PostTransitDecryptName**](Secrets.md#posttransitdecryptname) | **POST** /transit/decrypt/{name} | Decrypt a ciphertext value using a named key
[**PostTransitEncryptName**](Secrets.md#posttransitencryptname) | **POST** /transit/encrypt/{name} | Encrypt a plaintext value or a batch of plaintext blocks using a named key
[**PostTransitHash**](Secrets.md#posttransithash) | **POST** /transit/hash | Generate a hash sum for input data
[**PostTransitHashUrlalgorithm**](Secrets.md#posttransithashurlalgorithm) | **POST** /transit/hash/{urlalgorithm} | Generate a hash sum for input data
[**PostTransitHmacName**](Secrets.md#posttransithmacname) | **POST** /transit/hmac/{name} | Generate an HMAC for input data using the named key
[**PostTransitHmacNameUrlalgorithm**](Secrets.md#posttransithmacnameurlalgorithm) | **POST** /transit/hmac/{name}/{urlalgorithm} | Generate an HMAC for input data using the named key
[**PostTransitKeysName**](Secrets.md#posttransitkeysname) | **POST** /transit/keys/{name} | Managed named encryption keys
[**PostTransitKeysNameConfig**](Secrets.md#posttransitkeysnameconfig) | **POST** /transit/keys/{name}/config | Configure a named encryption key
[**PostTransitKeysNameImport**](Secrets.md#posttransitkeysnameimport) | **POST** /transit/keys/{name}/import | Imports an externally-generated key into a new transit key
[**PostTransitKeysNameImportVersion**](Secrets.md#posttransitkeysnameimportversion) | **POST** /transit/keys/{name}/import_version | Imports an externally-generated key into an existing imported key
[**PostTransitKeysNameRotate**](Secrets.md#posttransitkeysnamerotate) | **POST** /transit/keys/{name}/rotate | Rotate named encryption key
[**PostTransitKeysNameTrim**](Secrets.md#posttransitkeysnametrim) | **POST** /transit/keys/{name}/trim | Trim key versions of a named key
[**PostTransitRandom**](Secrets.md#posttransitrandom) | **POST** /transit/random | Generate random bytes
[**PostTransitRandomSource**](Secrets.md#posttransitrandomsource) | **POST** /transit/random/{source} | Generate random bytes
[**PostTransitRandomSourceUrlbytes**](Secrets.md#posttransitrandomsourceurlbytes) | **POST** /transit/random/{source}/{urlbytes} | Generate random bytes
[**PostTransitRandomUrlbytes**](Secrets.md#posttransitrandomurlbytes) | **POST** /transit/random/{urlbytes} | Generate random bytes
[**PostTransitRestore**](Secrets.md#posttransitrestore) | **POST** /transit/restore | Restore the named key
[**PostTransitRestoreName**](Secrets.md#posttransitrestorename) | **POST** /transit/restore/{name} | Restore the named key
[**PostTransitRewrapName**](Secrets.md#posttransitrewrapname) | **POST** /transit/rewrap/{name} | Rewrap ciphertext
[**PostTransitSignName**](Secrets.md#posttransitsignname) | **POST** /transit/sign/{name} | Generate a signature for input data using the named key
[**PostTransitSignNameUrlalgorithm**](Secrets.md#posttransitsignnameurlalgorithm) | **POST** /transit/sign/{name}/{urlalgorithm} | Generate a signature for input data using the named key
[**PostTransitVerifyName**](Secrets.md#posttransitverifyname) | **POST** /transit/verify/{name} | Verify a signature or HMAC for input data created using the named key
[**PostTransitVerifyNameUrlalgorithm**](Secrets.md#posttransitverifynameurlalgorithm) | **POST** /transit/verify/{name}/{urlalgorithm} | Verify a signature or HMAC for input data created using the named key


<a name="deleteadconfig"></a>
# **DeleteAdConfig**
> void DeleteAdConfig ()

Configure the AD server to connect to, along with password options.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAdConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                // Configure the AD server to connect to, along with password options.
                apiInstance.DeleteAdConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteAdConfig: " + e.Message );
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

<a name="deleteadlibraryname"></a>
# **DeleteAdLibraryName**
> void DeleteAdLibraryName (string name)

Delete a library set.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAdLibraryNameExample
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

            try
            {
                // Delete a library set.
                apiInstance.DeleteAdLibraryName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteAdLibraryName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the set. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteadrolesname"></a>
# **DeleteAdRolesName**
> void DeleteAdRolesName (string name)

Manage roles to build links between Vault and Active Directory service accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAdRolesNameExample
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

            try
            {
                // Manage roles to build links between Vault and Active Directory service accounts.
                apiInstance.DeleteAdRolesName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteAdRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="deletealicloudconfig"></a>
# **DeleteAlicloudConfig**
> void DeleteAlicloudConfig ()

Configure the access key and secret to use for RAM and STS calls.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAlicloudConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                // Configure the access key and secret to use for RAM and STS calls.
                apiInstance.DeleteAlicloudConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteAlicloudConfig: " + e.Message );
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

<a name="deletealicloudrolename"></a>
# **DeleteAlicloudRoleName**
> void DeleteAlicloudRoleName (string name)

Read, write and reference policies and roles that API keys or STS credentials can be made for.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAlicloudRoleNameExample
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

            try
            {
                // Read, write and reference policies and roles that API keys or STS credentials can be made for.
                apiInstance.DeleteAlicloudRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteAlicloudRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the role. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteawsrolesname"></a>
# **DeleteAwsRolesName**
> void DeleteAwsRolesName (string name)

Read, write and reference IAM policies that access keys can be made for.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAwsRolesNameExample
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

            try
            {
                // Read, write and reference IAM policies that access keys can be made for.
                apiInstance.DeleteAwsRolesName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteAwsRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the policy | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteazureconfig"></a>
# **DeleteAzureConfig**
> void DeleteAzureConfig ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAzureConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.DeleteAzureConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteAzureConfig: " + e.Message );
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

<a name="deleteazurerolesname"></a>
# **DeleteAzureRolesName**
> void DeleteAzureRolesName (string name)

Manage the Vault roles used to generate Azure credentials.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteAzureRolesNameExample
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

            try
            {
                // Manage the Vault roles used to generate Azure credentials.
                apiInstance.DeleteAzureRolesName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteAzureRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="deleteconsulrolesname"></a>
# **DeleteConsulRolesName**
> void DeleteConsulRolesName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteConsulRolesNameExample
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

            try
            {
                apiInstance.DeleteConsulRolesName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteConsulRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="deletecubbyholepath"></a>
# **DeleteCubbyholePath**
> void DeleteCubbyholePath (string path)

Deletes the secret at the specified location.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteCubbyholePathExample
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
                apiInstance.DeleteCubbyholePath(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteCubbyholePath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deletegcprolesetname"></a>
# **DeleteGcpRolesetName**
> void DeleteGcpRolesetName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteGcpRolesetNameExample
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

            try
            {
                apiInstance.DeleteGcpRolesetName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteGcpRolesetName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Required. Name of the role. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegcpstaticaccountname"></a>
# **DeleteGcpStaticAccountName**
> void DeleteGcpStaticAccountName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteGcpStaticAccountNameExample
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

            try
            {
                apiInstance.DeleteGcpStaticAccountName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteGcpStaticAccountName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Required. Name to refer to this static account in Vault. Cannot be updated. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegcpkmsconfig"></a>
# **DeleteGcpkmsConfig**
> void DeleteGcpkmsConfig ()

Configure the GCP KMS secrets engine

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteGcpkmsConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                // Configure the GCP KMS secrets engine
                apiInstance.DeleteGcpkmsConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteGcpkmsConfig: " + e.Message );
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

<a name="deletegcpkmskeysderegisterkey"></a>
# **DeleteGcpkmsKeysDeregisterKey**
> void DeleteGcpkmsKeysDeregisterKey (string key)

Deregister an existing key in Vault

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteGcpkmsKeysDeregisterKeyExample
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

            try
            {
                // Deregister an existing key in Vault
                apiInstance.DeleteGcpkmsKeysDeregisterKey(key);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteGcpkmsKeysDeregisterKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key to deregister in Vault. If the key exists in Google Cloud KMS, it will be left untouched. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegcpkmskeyskey"></a>
# **DeleteGcpkmsKeysKey**
> void DeleteGcpkmsKeysKey (string key)

Interact with crypto keys in Vault and Google Cloud KMS

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteGcpkmsKeysKeyExample
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

            try
            {
                // Interact with crypto keys in Vault and Google Cloud KMS
                apiInstance.DeleteGcpkmsKeysKey(key);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteGcpkmsKeysKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key in Vault. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegcpkmskeystrimkey"></a>
# **DeleteGcpkmsKeysTrimKey**
> void DeleteGcpkmsKeysTrimKey (string key)

Delete old crypto key versions from Google Cloud KMS

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteGcpkmsKeysTrimKeyExample
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

            try
            {
                // Delete old crypto key versions from Google Cloud KMS
                apiInstance.DeleteGcpkmsKeysTrimKey(key);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteGcpkmsKeysTrimKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key in Vault. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletekubernetesconfig"></a>
# **DeleteKubernetesConfig**
> void DeleteKubernetesConfig ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteKubernetesConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.DeleteKubernetesConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteKubernetesConfig: " + e.Message );
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

<a name="deletekubernetesrolesname"></a>
# **DeleteKubernetesRolesName**
> void DeleteKubernetesRolesName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteKubernetesRolesNameExample
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

            try
            {
                apiInstance.DeleteKubernetesRolesName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteKubernetesRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="deletekvpath"></a>
# **DeleteKvPath**
> void DeleteKvPath (string path)

Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteKvPathExample
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

            try
            {
                // Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.
                apiInstance.DeleteKvPath(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteKvPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemongodbatlasrolesname"></a>
# **DeleteMongodbatlasRolesName**
> void DeleteMongodbatlasRolesName (string name)

Manage the roles used to generate MongoDB Atlas Programmatic API Keys.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteMongodbatlasRolesNameExample
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

            try
            {
                // Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
                apiInstance.DeleteMongodbatlasRolesName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteMongodbatlasRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the Roles | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletenomadconfigaccess"></a>
# **DeleteNomadConfigAccess**
> void DeleteNomadConfigAccess ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteNomadConfigAccessExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.DeleteNomadConfigAccess();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteNomadConfigAccess: " + e.Message );
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

<a name="deletenomadconfiglease"></a>
# **DeleteNomadConfigLease**
> void DeleteNomadConfigLease ()

Configure the lease parameters for generated tokens

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteNomadConfigLeaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                // Configure the lease parameters for generated tokens
                apiInstance.DeleteNomadConfigLease();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteNomadConfigLease: " + e.Message );
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

<a name="deletenomadrolename"></a>
# **DeleteNomadRoleName**
> void DeleteNomadRoleName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteNomadRoleNameExample
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

            try
            {
                apiInstance.DeleteNomadRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteNomadRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="deleteopenldapconfig"></a>
# **DeleteOpenldapConfig**
> void DeleteOpenldapConfig ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteOpenldapConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.DeleteOpenldapConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteOpenldapConfig: " + e.Message );
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

<a name="deleteopenldaprolename"></a>
# **DeleteOpenldapRoleName**
> void DeleteOpenldapRoleName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteOpenldapRoleNameExample
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

            try
            {
                apiInstance.DeleteOpenldapRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteOpenldapRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the role (lowercase) | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteopenldapstaticrolename"></a>
# **DeleteOpenldapStaticRoleName**
> void DeleteOpenldapStaticRoleName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteOpenldapStaticRoleNameExample
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

            try
            {
                apiInstance.DeleteOpenldapStaticRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteOpenldapStaticRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="deletepkiissuerrefderpem"></a>
# **DeletePkiIssuerRefDerPem**
> void DeletePkiIssuerRefDerPem (string issuerRef)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeletePkiIssuerRefDerPemExample
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

            try
            {
                apiInstance.DeletePkiIssuerRefDerPem(issuerRef);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeletePkiIssuerRefDerPem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepkijson"></a>
# **DeletePkiJson**
> void DeletePkiJson ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeletePkiJsonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.DeletePkiJson();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeletePkiJson: " + e.Message );
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

<a name="deletepkikeykeyref"></a>
# **DeletePkiKeyKeyRef**
> void DeletePkiKeyKeyRef (string keyRef)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeletePkiKeyKeyRefExample
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

            try
            {
                apiInstance.DeletePkiKeyKeyRef(keyRef);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeletePkiKeyKeyRef: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyRef** | **string**| Reference to key; either \&quot;default\&quot; for the configured default key, an identifier of a key, or the name assigned to the key. | [default to &quot;default&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepkirolesname"></a>
# **DeletePkiRolesName**
> void DeletePkiRolesName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeletePkiRolesNameExample
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

            try
            {
                apiInstance.DeletePkiRolesName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeletePkiRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="deletepkiroot"></a>
# **DeletePkiRoot**
> void DeletePkiRoot ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeletePkiRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.DeletePkiRoot();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeletePkiRoot: " + e.Message );
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

<a name="deleterabbitmqrolesname"></a>
# **DeleteRabbitmqRolesName**
> void DeleteRabbitmqRolesName (string name)

Manage the roles that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteRabbitmqRolesNameExample
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

            try
            {
                // Manage the roles that can be created with this backend.
                apiInstance.DeleteRabbitmqRolesName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteRabbitmqRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="deletesecretdatapath"></a>
# **DeleteSecretDataPath**
> void DeleteSecretDataPath (string path)

Write, Patch, Read, and Delete data in the Key-Value Store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSecretDataPathExample
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

            try
            {
                // Write, Patch, Read, and Delete data in the Key-Value Store.
                apiInstance.DeleteSecretDataPath(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteSecretDataPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesecretmetadatapath"></a>
# **DeleteSecretMetadataPath**
> void DeleteSecretMetadataPath (string path)

Configures settings for the KV store

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSecretMetadataPathExample
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

            try
            {
                // Configures settings for the KV store
                apiInstance.DeleteSecretMetadataPath(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteSecretMetadataPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesshconfigca"></a>
# **DeleteSshConfigCa**
> void DeleteSshConfigCa ()

Set the SSH private key used for signing certificates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSshConfigCaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                // Set the SSH private key used for signing certificates.
                apiInstance.DeleteSshConfigCa();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteSshConfigCa: " + e.Message );
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

<a name="deletesshconfigzeroaddress"></a>
# **DeleteSshConfigZeroaddress**
> void DeleteSshConfigZeroaddress ()

Assign zero address as default CIDR block for select roles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSshConfigZeroaddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                // Assign zero address as default CIDR block for select roles.
                apiInstance.DeleteSshConfigZeroaddress();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteSshConfigZeroaddress: " + e.Message );
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

<a name="deletesshkeyskeyname"></a>
# **DeleteSshKeysKeyName**
> void DeleteSshKeysKeyName (string keyName)

Register a shared private key with Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSshKeysKeyNameExample
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

            try
            {
                // Register a shared private key with Vault.
                apiInstance.DeleteSshKeysKeyName(keyName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteSshKeysKeyName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyName** | **string**| [Required] Name of the key | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesshrolesrole"></a>
# **DeleteSshRolesRole**
> void DeleteSshRolesRole (string role)

Manage the 'roles' that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSshRolesRoleExample
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

            try
            {
                // Manage the 'roles' that can be created with this backend.
                apiInstance.DeleteSshRolesRole(role);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteSshRolesRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| [Required for all types] Name of the role being created. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteterraformconfig"></a>
# **DeleteTerraformConfig**
> void DeleteTerraformConfig ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteTerraformConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.DeleteTerraformConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteTerraformConfig: " + e.Message );
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

<a name="deleteterraformrolename"></a>
# **DeleteTerraformRoleName**
> void DeleteTerraformRoleName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteTerraformRoleNameExample
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

            try
            {
                apiInstance.DeleteTerraformRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteTerraformRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="deletetotpkeysname"></a>
# **DeleteTotpKeysName**
> void DeleteTotpKeysName (string name)

Manage the keys that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteTotpKeysNameExample
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

            try
            {
                // Manage the keys that can be created with this backend.
                apiInstance.DeleteTotpKeysName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteTotpKeysName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the key. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetransitkeysname"></a>
# **DeleteTransitKeysName**
> void DeleteTransitKeysName (string name)

Managed named encryption keys

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteTransitKeysNameExample
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

            try
            {
                // Managed named encryption keys
                apiInstance.DeleteTransitKeysName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteTransitKeysName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getadconfig"></a>
# **GetAdConfig**
> void GetAdConfig ()

Configure the AD server to connect to, along with password options.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAdConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                // Configure the AD server to connect to, along with password options.
                apiInstance.GetAdConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetAdConfig: " + e.Message );
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

<a name="getadcredsname"></a>
# **GetAdCredsName**
> void GetAdCredsName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAdCredsNameExample
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

            try
            {
                apiInstance.GetAdCredsName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetAdCredsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getadlibrary"></a>
# **GetAdLibrary**
> void GetAdLibrary (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAdLibraryExample
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

            try
            {
                apiInstance.GetAdLibrary(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetAdLibrary: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getadlibraryname"></a>
# **GetAdLibraryName**
> void GetAdLibraryName (string name)

Read a library set.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAdLibraryNameExample
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

            try
            {
                // Read a library set.
                apiInstance.GetAdLibraryName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetAdLibraryName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the set. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getadlibrarynamestatus"></a>
# **GetAdLibraryNameStatus**
> void GetAdLibraryNameStatus (string name)

Check the status of the service accounts in a library set.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAdLibraryNameStatusExample
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

            try
            {
                // Check the status of the service accounts in a library set.
                apiInstance.GetAdLibraryNameStatus(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetAdLibraryNameStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the set. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getadroles"></a>
# **GetAdRoles**
> void GetAdRoles (string list)

List the name of each role currently stored.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAdRolesExample
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

            try
            {
                // List the name of each role currently stored.
                apiInstance.GetAdRoles(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetAdRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getadrolesname"></a>
# **GetAdRolesName**
> void GetAdRolesName (string name)

Manage roles to build links between Vault and Active Directory service accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAdRolesNameExample
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

            try
            {
                // Manage roles to build links between Vault and Active Directory service accounts.
                apiInstance.GetAdRolesName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetAdRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getadrotateroot"></a>
# **GetAdRotateRoot**
> void GetAdRotateRoot ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAdRotateRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetAdRotateRoot();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetAdRotateRoot: " + e.Message );
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

<a name="getalicloudconfig"></a>
# **GetAlicloudConfig**
> void GetAlicloudConfig ()

Configure the access key and secret to use for RAM and STS calls.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAlicloudConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                // Configure the access key and secret to use for RAM and STS calls.
                apiInstance.GetAlicloudConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetAlicloudConfig: " + e.Message );
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

<a name="getalicloudcredsname"></a>
# **GetAlicloudCredsName**
> void GetAlicloudCredsName (string name)

Generate an API key or STS credential using the given role's configuration.'

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAlicloudCredsNameExample
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

            try
            {
                // Generate an API key or STS credential using the given role's configuration.'
                apiInstance.GetAlicloudCredsName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetAlicloudCredsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the role. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalicloudrole"></a>
# **GetAlicloudRole**
> void GetAlicloudRole (string list)

List the existing roles in this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAlicloudRoleExample
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

            try
            {
                // List the existing roles in this backend.
                apiInstance.GetAlicloudRole(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetAlicloudRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getalicloudrolename"></a>
# **GetAlicloudRoleName**
> void GetAlicloudRoleName (string name)

Read, write and reference policies and roles that API keys or STS credentials can be made for.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAlicloudRoleNameExample
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

            try
            {
                // Read, write and reference policies and roles that API keys or STS credentials can be made for.
                apiInstance.GetAlicloudRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetAlicloudRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the role. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getawsconfiglease"></a>
# **GetAwsConfigLease**
> void GetAwsConfigLease ()

Configure the default lease information for generated credentials.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAwsConfigLeaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                // Configure the default lease information for generated credentials.
                apiInstance.GetAwsConfigLease();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetAwsConfigLease: " + e.Message );
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

<a name="getawsconfigroot"></a>
# **GetAwsConfigRoot**
> void GetAwsConfigRoot ()

Configure the root credentials that are used to manage IAM.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAwsConfigRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                // Configure the root credentials that are used to manage IAM.
                apiInstance.GetAwsConfigRoot();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetAwsConfigRoot: " + e.Message );
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

<a name="getawscreds"></a>
# **GetAwsCreds**
> void GetAwsCreds ()

Generate AWS credentials from a specific Vault role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAwsCredsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                // Generate AWS credentials from a specific Vault role.
                apiInstance.GetAwsCreds();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetAwsCreds: " + e.Message );
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

<a name="getawsroles"></a>
# **GetAwsRoles**
> void GetAwsRoles (string list)

List the existing roles in this backend

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAwsRolesExample
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

            try
            {
                // List the existing roles in this backend
                apiInstance.GetAwsRoles(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetAwsRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getawsrolesname"></a>
# **GetAwsRolesName**
> void GetAwsRolesName (string name)

Read, write and reference IAM policies that access keys can be made for.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAwsRolesNameExample
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

            try
            {
                // Read, write and reference IAM policies that access keys can be made for.
                apiInstance.GetAwsRolesName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetAwsRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the policy | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getawsstsname"></a>
# **GetAwsStsName**
> void GetAwsStsName (string name)

Generate AWS credentials from a specific Vault role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAwsStsNameExample
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

            try
            {
                // Generate AWS credentials from a specific Vault role.
                apiInstance.GetAwsStsName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetAwsStsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getazureconfig"></a>
# **GetAzureConfig**
> void GetAzureConfig ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAzureConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetAzureConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetAzureConfig: " + e.Message );
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

<a name="getazurecredsrole"></a>
# **GetAzureCredsRole**
> void GetAzureCredsRole (string role)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAzureCredsRoleExample
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

            try
            {
                apiInstance.GetAzureCredsRole(role);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetAzureCredsRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| Name of the Vault role | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getazureroles"></a>
# **GetAzureRoles**
> void GetAzureRoles (string list)

List existing roles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAzureRolesExample
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

            try
            {
                // List existing roles.
                apiInstance.GetAzureRoles(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetAzureRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getazurerolesname"></a>
# **GetAzureRolesName**
> void GetAzureRolesName (string name)

Manage the Vault roles used to generate Azure credentials.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetAzureRolesNameExample
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

            try
            {
                // Manage the Vault roles used to generate Azure credentials.
                apiInstance.GetAzureRolesName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetAzureRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getconsulconfigaccess"></a>
# **GetConsulConfigAccess**
> void GetConsulConfigAccess ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetConsulConfigAccessExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetConsulConfigAccess();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetConsulConfigAccess: " + e.Message );
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

<a name="getconsulcredsrole"></a>
# **GetConsulCredsRole**
> void GetConsulCredsRole (string role)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetConsulCredsRoleExample
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

            try
            {
                apiInstance.GetConsulCredsRole(role);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetConsulCredsRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getconsulroles"></a>
# **GetConsulRoles**
> void GetConsulRoles (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetConsulRolesExample
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

            try
            {
                apiInstance.GetConsulRoles(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetConsulRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getconsulrolesname"></a>
# **GetConsulRolesName**
> void GetConsulRolesName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetConsulRolesNameExample
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

            try
            {
                apiInstance.GetConsulRolesName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetConsulRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getcubbyholepath"></a>
# **GetCubbyholePath**
> void GetCubbyholePath (string path, string list = null)

Retrieve the secret at the specified location.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetCubbyholePathExample
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
                apiInstance.GetCubbyholePath(path, list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetCubbyholePath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getgcpconfig"></a>
# **GetGcpConfig**
> void GetGcpConfig ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetGcpConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetGcpConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetGcpConfig: " + e.Message );
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

<a name="getgcpkeyroleset"></a>
# **GetGcpKeyRoleset**
> void GetGcpKeyRoleset (string roleset)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetGcpKeyRolesetExample
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

            try
            {
                apiInstance.GetGcpKeyRoleset(roleset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetGcpKeyRoleset: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleset** | **string**| Required. Name of the role set. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgcprolesetname"></a>
# **GetGcpRolesetName**
> void GetGcpRolesetName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetGcpRolesetNameExample
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

            try
            {
                apiInstance.GetGcpRolesetName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetGcpRolesetName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Required. Name of the role. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgcprolesetrolesetkey"></a>
# **GetGcpRolesetRolesetKey**
> void GetGcpRolesetRolesetKey (string roleset)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetGcpRolesetRolesetKeyExample
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

            try
            {
                apiInstance.GetGcpRolesetRolesetKey(roleset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetGcpRolesetRolesetKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleset** | **string**| Required. Name of the role set. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgcprolesetrolesettoken"></a>
# **GetGcpRolesetRolesetToken**
> void GetGcpRolesetRolesetToken (string roleset)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetGcpRolesetRolesetTokenExample
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

            try
            {
                apiInstance.GetGcpRolesetRolesetToken(roleset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetGcpRolesetRolesetToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleset** | **string**| Required. Name of the role set. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgcprolesets"></a>
# **GetGcpRolesets**
> void GetGcpRolesets (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetGcpRolesetsExample
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

            try
            {
                apiInstance.GetGcpRolesets(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetGcpRolesets: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getgcpstaticaccountname"></a>
# **GetGcpStaticAccountName**
> void GetGcpStaticAccountName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetGcpStaticAccountNameExample
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

            try
            {
                apiInstance.GetGcpStaticAccountName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetGcpStaticAccountName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Required. Name to refer to this static account in Vault. Cannot be updated. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgcpstaticaccountnamekey"></a>
# **GetGcpStaticAccountNameKey**
> void GetGcpStaticAccountNameKey (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetGcpStaticAccountNameKeyExample
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

            try
            {
                apiInstance.GetGcpStaticAccountNameKey(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetGcpStaticAccountNameKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Required. Name of the static account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgcpstaticaccountnametoken"></a>
# **GetGcpStaticAccountNameToken**
> void GetGcpStaticAccountNameToken (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetGcpStaticAccountNameTokenExample
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

            try
            {
                apiInstance.GetGcpStaticAccountNameToken(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetGcpStaticAccountNameToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Required. Name of the static account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgcpstaticaccounts"></a>
# **GetGcpStaticAccounts**
> void GetGcpStaticAccounts (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetGcpStaticAccountsExample
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

            try
            {
                apiInstance.GetGcpStaticAccounts(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetGcpStaticAccounts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getgcptokenroleset"></a>
# **GetGcpTokenRoleset**
> void GetGcpTokenRoleset (string roleset)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetGcpTokenRolesetExample
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

            try
            {
                apiInstance.GetGcpTokenRoleset(roleset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetGcpTokenRoleset: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleset** | **string**| Required. Name of the role set. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgcpkmsconfig"></a>
# **GetGcpkmsConfig**
> void GetGcpkmsConfig ()

Configure the GCP KMS secrets engine

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetGcpkmsConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                // Configure the GCP KMS secrets engine
                apiInstance.GetGcpkmsConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetGcpkmsConfig: " + e.Message );
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

<a name="getgcpkmskeys"></a>
# **GetGcpkmsKeys**
> void GetGcpkmsKeys (string list)

List named keys

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetGcpkmsKeysExample
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

            try
            {
                // List named keys
                apiInstance.GetGcpkmsKeys(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetGcpkmsKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getgcpkmskeysconfigkey"></a>
# **GetGcpkmsKeysConfigKey**
> void GetGcpkmsKeysConfigKey (string key)

Configure the key in Vault

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetGcpkmsKeysConfigKeyExample
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

            try
            {
                // Configure the key in Vault
                apiInstance.GetGcpkmsKeysConfigKey(key);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetGcpkmsKeysConfigKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key in Vault. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgcpkmskeyskey"></a>
# **GetGcpkmsKeysKey**
> void GetGcpkmsKeysKey (string key)

Interact with crypto keys in Vault and Google Cloud KMS

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetGcpkmsKeysKeyExample
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

            try
            {
                // Interact with crypto keys in Vault and Google Cloud KMS
                apiInstance.GetGcpkmsKeysKey(key);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetGcpkmsKeysKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key in Vault. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgcpkmspubkeykey"></a>
# **GetGcpkmsPubkeyKey**
> void GetGcpkmsPubkeyKey (string key)

Retrieve the public key associated with the named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetGcpkmsPubkeyKeyExample
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

            try
            {
                // Retrieve the public key associated with the named key
                apiInstance.GetGcpkmsPubkeyKey(key);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetGcpkmsPubkeyKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key for which to get the public key. This key must already exist in Vault and Google Cloud KMS. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getkubernetesconfig"></a>
# **GetKubernetesConfig**
> void GetKubernetesConfig ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetKubernetesConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetKubernetesConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetKubernetesConfig: " + e.Message );
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

<a name="getkubernetesroles"></a>
# **GetKubernetesRoles**
> void GetKubernetesRoles (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetKubernetesRolesExample
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

            try
            {
                apiInstance.GetKubernetesRoles(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetKubernetesRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getkubernetesrolesname"></a>
# **GetKubernetesRolesName**
> void GetKubernetesRolesName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetKubernetesRolesNameExample
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

            try
            {
                apiInstance.GetKubernetesRolesName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetKubernetesRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getkvpath"></a>
# **GetKvPath**
> void GetKvPath (string path, string list = null)

Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetKvPathExample
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
            var list = "list_example";  // string | Return a list if `true` (optional) 

            try
            {
                // Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.
                apiInstance.GetKvPath(path, list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetKvPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 
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

<a name="getmongodbatlasconfig"></a>
# **GetMongodbatlasConfig**
> void GetMongodbatlasConfig ()

Configure the  credentials that are used to manage Database Users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetMongodbatlasConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                // Configure the  credentials that are used to manage Database Users.
                apiInstance.GetMongodbatlasConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetMongodbatlasConfig: " + e.Message );
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

<a name="getmongodbatlascredsname"></a>
# **GetMongodbatlasCredsName**
> void GetMongodbatlasCredsName (string name)

Generate MongoDB Atlas Programmatic API from a specific Vault role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetMongodbatlasCredsNameExample
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

            try
            {
                // Generate MongoDB Atlas Programmatic API from a specific Vault role.
                apiInstance.GetMongodbatlasCredsName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetMongodbatlasCredsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getmongodbatlasroles"></a>
# **GetMongodbatlasRoles**
> void GetMongodbatlasRoles (string list)

List the existing roles in this backend

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetMongodbatlasRolesExample
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

            try
            {
                // List the existing roles in this backend
                apiInstance.GetMongodbatlasRoles(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetMongodbatlasRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getmongodbatlasrolesname"></a>
# **GetMongodbatlasRolesName**
> void GetMongodbatlasRolesName (string name)

Manage the roles used to generate MongoDB Atlas Programmatic API Keys.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetMongodbatlasRolesNameExample
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

            try
            {
                // Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
                apiInstance.GetMongodbatlasRolesName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetMongodbatlasRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the Roles | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnomadconfigaccess"></a>
# **GetNomadConfigAccess**
> void GetNomadConfigAccess ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetNomadConfigAccessExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetNomadConfigAccess();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetNomadConfigAccess: " + e.Message );
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

<a name="getnomadconfiglease"></a>
# **GetNomadConfigLease**
> void GetNomadConfigLease ()

Configure the lease parameters for generated tokens

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetNomadConfigLeaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                // Configure the lease parameters for generated tokens
                apiInstance.GetNomadConfigLease();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetNomadConfigLease: " + e.Message );
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

<a name="getnomadcredsname"></a>
# **GetNomadCredsName**
> void GetNomadCredsName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetNomadCredsNameExample
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

            try
            {
                apiInstance.GetNomadCredsName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetNomadCredsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getnomadrole"></a>
# **GetNomadRole**
> void GetNomadRole (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetNomadRoleExample
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

            try
            {
                apiInstance.GetNomadRole(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetNomadRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getnomadrolename"></a>
# **GetNomadRoleName**
> void GetNomadRoleName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetNomadRoleNameExample
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

            try
            {
                apiInstance.GetNomadRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetNomadRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getopenldapconfig"></a>
# **GetOpenldapConfig**
> void GetOpenldapConfig ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetOpenldapConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetOpenldapConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetOpenldapConfig: " + e.Message );
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

<a name="getopenldapcredsname"></a>
# **GetOpenldapCredsName**
> void GetOpenldapCredsName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetOpenldapCredsNameExample
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

            try
            {
                apiInstance.GetOpenldapCredsName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetOpenldapCredsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the dynamic role. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getopenldaprole"></a>
# **GetOpenldapRole**
> void GetOpenldapRole (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetOpenldapRoleExample
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

            try
            {
                apiInstance.GetOpenldapRole(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetOpenldapRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getopenldaprolename"></a>
# **GetOpenldapRoleName**
> void GetOpenldapRoleName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetOpenldapRoleNameExample
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

            try
            {
                apiInstance.GetOpenldapRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetOpenldapRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the role (lowercase) | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getopenldapstaticcredname"></a>
# **GetOpenldapStaticCredName**
> void GetOpenldapStaticCredName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetOpenldapStaticCredNameExample
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

            try
            {
                apiInstance.GetOpenldapStaticCredName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetOpenldapStaticCredName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the static role. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getopenldapstaticrole"></a>
# **GetOpenldapStaticRole**
> void GetOpenldapStaticRole (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetOpenldapStaticRoleExample
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

            try
            {
                apiInstance.GetOpenldapStaticRole(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetOpenldapStaticRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getopenldapstaticrolename"></a>
# **GetOpenldapStaticRoleName**
> void GetOpenldapStaticRoleName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetOpenldapStaticRoleNameExample
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

            try
            {
                apiInstance.GetOpenldapStaticRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetOpenldapStaticRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getpkica"></a>
# **GetPkiCa**
> void GetPkiCa ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiCaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetPkiCa();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiCa: " + e.Message );
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

<a name="getpkicachain"></a>
# **GetPkiCaChain**
> void GetPkiCaChain ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiCaChainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetPkiCaChain();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiCaChain: " + e.Message );
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

<a name="getpkicapem"></a>
# **GetPkiCaPem**
> void GetPkiCaPem ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiCaPemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetPkiCaPem();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiCaPem: " + e.Message );
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

<a name="getpkicertcachain"></a>
# **GetPkiCertCaChain**
> void GetPkiCertCaChain ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiCertCaChainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetPkiCertCaChain();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiCertCaChain: " + e.Message );
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

<a name="getpkicertcrl"></a>
# **GetPkiCertCrl**
> void GetPkiCertCrl ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiCertCrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetPkiCertCrl();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiCertCrl: " + e.Message );
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

<a name="getpkicertserial"></a>
# **GetPkiCertSerial**
> void GetPkiCertSerial (string serial)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiCertSerialExample
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

            try
            {
                apiInstance.GetPkiCertSerial(serial);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiCertSerial: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serial** | **string**| Certificate serial number, in colon- or hyphen-separated octal | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpkicertserialraw"></a>
# **GetPkiCertSerialRaw**
> void GetPkiCertSerialRaw (string serial)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiCertSerialRawExample
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

            try
            {
                apiInstance.GetPkiCertSerialRaw(serial);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiCertSerialRaw: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serial** | **string**| Certificate serial number, in colon- or hyphen-separated octal | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpkicertserialrawpem"></a>
# **GetPkiCertSerialRawPem**
> void GetPkiCertSerialRawPem (string serial)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiCertSerialRawPemExample
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

            try
            {
                apiInstance.GetPkiCertSerialRawPem(serial);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiCertSerialRawPem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serial** | **string**| Certificate serial number, in colon- or hyphen-separated octal | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpkicerts"></a>
# **GetPkiCerts**
> void GetPkiCerts (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiCertsExample
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

            try
            {
                apiInstance.GetPkiCerts(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiCerts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getpkiconfigcrl"></a>
# **GetPkiConfigCrl**
> void GetPkiConfigCrl ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiConfigCrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetPkiConfigCrl();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiConfigCrl: " + e.Message );
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

<a name="getpkiconfigissuers"></a>
# **GetPkiConfigIssuers**
> void GetPkiConfigIssuers ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiConfigIssuersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetPkiConfigIssuers();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiConfigIssuers: " + e.Message );
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

<a name="getpkiconfigkeys"></a>
# **GetPkiConfigKeys**
> void GetPkiConfigKeys ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiConfigKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetPkiConfigKeys();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiConfigKeys: " + e.Message );
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

<a name="getpkiconfigurls"></a>
# **GetPkiConfigUrls**
> void GetPkiConfigUrls ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiConfigUrlsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetPkiConfigUrls();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiConfigUrls: " + e.Message );
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

<a name="getpkicrl"></a>
# **GetPkiCrl**
> void GetPkiCrl ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiCrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetPkiCrl();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiCrl: " + e.Message );
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

<a name="getpkicrlpem"></a>
# **GetPkiCrlPem**
> void GetPkiCrlPem ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiCrlPemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetPkiCrlPem();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiCrlPem: " + e.Message );
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

<a name="getpkicrlrotate"></a>
# **GetPkiCrlRotate**
> void GetPkiCrlRotate ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiCrlRotateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetPkiCrlRotate();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiCrlRotate: " + e.Message );
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

<a name="getpkider"></a>
# **GetPkiDer**
> void GetPkiDer ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiDerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetPkiDer();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiDer: " + e.Message );
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

<a name="getpkiissuerrefcrlpem"></a>
# **GetPkiIssuerRefCrlPem**
> void GetPkiIssuerRefCrlPem (string issuerRef)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiIssuerRefCrlPemExample
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

            try
            {
                apiInstance.GetPkiIssuerRefCrlPem(issuerRef);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiIssuerRefCrlPem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpkiissuerrefderpem"></a>
# **GetPkiIssuerRefDerPem**
> void GetPkiIssuerRefDerPem (string issuerRef)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiIssuerRefDerPemExample
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

            try
            {
                apiInstance.GetPkiIssuerRefDerPem(issuerRef);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiIssuerRefDerPem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpkiissuers"></a>
# **GetPkiIssuers**
> void GetPkiIssuers (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiIssuersExample
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

            try
            {
                apiInstance.GetPkiIssuers(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiIssuers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getpkijson"></a>
# **GetPkiJson**
> void GetPkiJson ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiJsonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetPkiJson();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiJson: " + e.Message );
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

<a name="getpkikeykeyref"></a>
# **GetPkiKeyKeyRef**
> void GetPkiKeyKeyRef (string keyRef)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiKeyKeyRefExample
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

            try
            {
                apiInstance.GetPkiKeyKeyRef(keyRef);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiKeyKeyRef: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyRef** | **string**| Reference to key; either \&quot;default\&quot; for the configured default key, an identifier of a key, or the name assigned to the key. | [default to &quot;default&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpkikeys"></a>
# **GetPkiKeys**
> void GetPkiKeys (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiKeysExample
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

            try
            {
                apiInstance.GetPkiKeys(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getpkiroles"></a>
# **GetPkiRoles**
> void GetPkiRoles (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiRolesExample
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

            try
            {
                apiInstance.GetPkiRoles(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getpkirolesname"></a>
# **GetPkiRolesName**
> void GetPkiRolesName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiRolesNameExample
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

            try
            {
                apiInstance.GetPkiRolesName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getpkitidystatus"></a>
# **GetPkiTidyStatus**
> void GetPkiTidyStatus ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetPkiTidyStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetPkiTidyStatus();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiTidyStatus: " + e.Message );
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

<a name="getrabbitmqconfiglease"></a>
# **GetRabbitmqConfigLease**
> void GetRabbitmqConfigLease ()

Configure the lease parameters for generated credentials

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetRabbitmqConfigLeaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                // Configure the lease parameters for generated credentials
                apiInstance.GetRabbitmqConfigLease();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetRabbitmqConfigLease: " + e.Message );
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

<a name="getrabbitmqcredsname"></a>
# **GetRabbitmqCredsName**
> void GetRabbitmqCredsName (string name)

Request RabbitMQ credentials for a certain role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetRabbitmqCredsNameExample
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

            try
            {
                // Request RabbitMQ credentials for a certain role.
                apiInstance.GetRabbitmqCredsName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetRabbitmqCredsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getrabbitmqroles"></a>
# **GetRabbitmqRoles**
> void GetRabbitmqRoles (string list)

Manage the roles that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetRabbitmqRolesExample
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

            try
            {
                // Manage the roles that can be created with this backend.
                apiInstance.GetRabbitmqRoles(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetRabbitmqRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getrabbitmqrolesname"></a>
# **GetRabbitmqRolesName**
> void GetRabbitmqRolesName (string name)

Manage the roles that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetRabbitmqRolesNameExample
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

            try
            {
                // Manage the roles that can be created with this backend.
                apiInstance.GetRabbitmqRolesName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetRabbitmqRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getsecretconfig"></a>
# **GetSecretConfig**
> void GetSecretConfig ()

Read the backend level settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSecretConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                // Read the backend level settings.
                apiInstance.GetSecretConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetSecretConfig: " + e.Message );
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

<a name="getsecretdatapath"></a>
# **GetSecretDataPath**
> void GetSecretDataPath (string path)

Write, Patch, Read, and Delete data in the Key-Value Store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSecretDataPathExample
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

            try
            {
                // Write, Patch, Read, and Delete data in the Key-Value Store.
                apiInstance.GetSecretDataPath(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetSecretDataPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsecretmetadatapath"></a>
# **GetSecretMetadataPath**
> void GetSecretMetadataPath (string path, string list = null)

Configures settings for the KV store

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSecretMetadataPathExample
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
            var list = "list_example";  // string | Return a list if `true` (optional) 

            try
            {
                // Configures settings for the KV store
                apiInstance.GetSecretMetadataPath(path, list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetSecretMetadataPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 
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

<a name="getsecretsubkeyspath"></a>
# **GetSecretSubkeysPath**
> void GetSecretSubkeysPath (string path)

Read the structure of a secret entry from the Key-Value store with the values removed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSecretSubkeysPathExample
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

            try
            {
                // Read the structure of a secret entry from the Key-Value store with the values removed.
                apiInstance.GetSecretSubkeysPath(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetSecretSubkeysPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsshconfigca"></a>
# **GetSshConfigCa**
> void GetSshConfigCa ()

Set the SSH private key used for signing certificates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSshConfigCaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                // Set the SSH private key used for signing certificates.
                apiInstance.GetSshConfigCa();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetSshConfigCa: " + e.Message );
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

<a name="getsshconfigzeroaddress"></a>
# **GetSshConfigZeroaddress**
> void GetSshConfigZeroaddress ()

Assign zero address as default CIDR block for select roles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSshConfigZeroaddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                // Assign zero address as default CIDR block for select roles.
                apiInstance.GetSshConfigZeroaddress();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetSshConfigZeroaddress: " + e.Message );
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

<a name="getsshpublickey"></a>
# **GetSshPublicKey**
> void GetSshPublicKey ()

Retrieve the public key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSshPublicKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                // Retrieve the public key.
                apiInstance.GetSshPublicKey();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetSshPublicKey: " + e.Message );
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

<a name="getsshroles"></a>
# **GetSshRoles**
> void GetSshRoles (string list)

Manage the 'roles' that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSshRolesExample
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

            try
            {
                // Manage the 'roles' that can be created with this backend.
                apiInstance.GetSshRoles(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetSshRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getsshrolesrole"></a>
# **GetSshRolesRole**
> void GetSshRolesRole (string role)

Manage the 'roles' that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSshRolesRoleExample
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

            try
            {
                // Manage the 'roles' that can be created with this backend.
                apiInstance.GetSshRolesRole(role);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetSshRolesRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| [Required for all types] Name of the role being created. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getterraformconfig"></a>
# **GetTerraformConfig**
> void GetTerraformConfig ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetTerraformConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetTerraformConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetTerraformConfig: " + e.Message );
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

<a name="getterraformcredsname"></a>
# **GetTerraformCredsName**
> void GetTerraformCredsName (string name)

Generate a Terraform Cloud or Enterprise API token from a specific Vault role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetTerraformCredsNameExample
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

            try
            {
                // Generate a Terraform Cloud or Enterprise API token from a specific Vault role.
                apiInstance.GetTerraformCredsName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetTerraformCredsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getterraformrole"></a>
# **GetTerraformRole**
> void GetTerraformRole (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetTerraformRoleExample
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

            try
            {
                apiInstance.GetTerraformRole(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetTerraformRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getterraformrolename"></a>
# **GetTerraformRoleName**
> void GetTerraformRoleName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetTerraformRoleNameExample
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

            try
            {
                apiInstance.GetTerraformRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetTerraformRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="gettotpcodename"></a>
# **GetTotpCodeName**
> void GetTotpCodeName (string name)

Request time-based one-time use password or validate a password for a certain key .

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetTotpCodeNameExample
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

            try
            {
                // Request time-based one-time use password or validate a password for a certain key .
                apiInstance.GetTotpCodeName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetTotpCodeName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the key. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettotpkeys"></a>
# **GetTotpKeys**
> void GetTotpKeys (string list)

Manage the keys that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetTotpKeysExample
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

            try
            {
                // Manage the keys that can be created with this backend.
                apiInstance.GetTotpKeys(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetTotpKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="gettotpkeysname"></a>
# **GetTotpKeysName**
> void GetTotpKeysName (string name)

Manage the keys that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetTotpKeysNameExample
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

            try
            {
                // Manage the keys that can be created with this backend.
                apiInstance.GetTotpKeysName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetTotpKeysName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the key. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransitbackupname"></a>
# **GetTransitBackupName**
> void GetTransitBackupName (string name)

Backup the named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetTransitBackupNameExample
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

            try
            {
                // Backup the named key
                apiInstance.GetTransitBackupName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetTransitBackupName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="gettransitcacheconfig"></a>
# **GetTransitCacheConfig**
> void GetTransitCacheConfig ()

Returns the size of the active cache

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetTransitCacheConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                // Returns the size of the active cache
                apiInstance.GetTransitCacheConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetTransitCacheConfig: " + e.Message );
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

<a name="gettransitexporttypename"></a>
# **GetTransitExportTypeName**
> void GetTransitExportTypeName (string name, string type)

Export named encryption or signing key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetTransitExportTypeNameExample
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

            try
            {
                // Export named encryption or signing key
                apiInstance.GetTransitExportTypeName(name, type);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetTransitExportTypeName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **type** | **string**| Type of key to export (encryption-key, signing-key, hmac-key) | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransitexporttypenameversion"></a>
# **GetTransitExportTypeNameVersion**
> void GetTransitExportTypeNameVersion (string name, string type, string version)

Export named encryption or signing key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetTransitExportTypeNameVersionExample
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

            try
            {
                // Export named encryption or signing key
                apiInstance.GetTransitExportTypeNameVersion(name, type, version);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetTransitExportTypeNameVersion: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **type** | **string**| Type of key to export (encryption-key, signing-key, hmac-key) | 
 **version** | **string**| Version of the key | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransitkeys"></a>
# **GetTransitKeys**
> void GetTransitKeys (string list)

Managed named encryption keys

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetTransitKeysExample
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

            try
            {
                // Managed named encryption keys
                apiInstance.GetTransitKeys(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetTransitKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="gettransitkeysname"></a>
# **GetTransitKeysName**
> void GetTransitKeysName (string name)

Managed named encryption keys

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetTransitKeysNameExample
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

            try
            {
                // Managed named encryption keys
                apiInstance.GetTransitKeysName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetTransitKeysName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="gettransitwrappingkey"></a>
# **GetTransitWrappingKey**
> void GetTransitWrappingKey ()

Returns the public key to use for wrapping imported keys

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetTransitWrappingKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                // Returns the public key to use for wrapping imported keys
                apiInstance.GetTransitWrappingKey();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetTransitWrappingKey: " + e.Message );
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

<a name="postadconfig"></a>
# **PostAdConfig**
> void PostAdConfig (AdConfigRequest adConfigRequest = null)

Configure the AD server to connect to, along with password options.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAdConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var adConfigRequest = new AdConfigRequest(); // AdConfigRequest |  (optional) 

            try
            {
                // Configure the AD server to connect to, along with password options.
                apiInstance.PostAdConfig(adConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostAdConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **adConfigRequest** | [**AdConfigRequest**](AdConfigRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postadlibrarymanagenamecheckin"></a>
# **PostAdLibraryManageNameCheckIn**
> void PostAdLibraryManageNameCheckIn (string name, AdLibraryManageCheckInRequest adLibraryManageCheckInRequest = null)

Check service accounts in to the library.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAdLibraryManageNameCheckInExample
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
            var adLibraryManageCheckInRequest = new AdLibraryManageCheckInRequest(); // AdLibraryManageCheckInRequest |  (optional) 

            try
            {
                // Check service accounts in to the library.
                apiInstance.PostAdLibraryManageNameCheckIn(name, adLibraryManageCheckInRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostAdLibraryManageNameCheckIn: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the set. | 
 **adLibraryManageCheckInRequest** | [**AdLibraryManageCheckInRequest**](AdLibraryManageCheckInRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postadlibraryname"></a>
# **PostAdLibraryName**
> void PostAdLibraryName (string name, AdLibraryRequest adLibraryRequest = null)

Update a library set.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAdLibraryNameExample
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
            var adLibraryRequest = new AdLibraryRequest(); // AdLibraryRequest |  (optional) 

            try
            {
                // Update a library set.
                apiInstance.PostAdLibraryName(name, adLibraryRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostAdLibraryName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the set. | 
 **adLibraryRequest** | [**AdLibraryRequest**](AdLibraryRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postadlibrarynamecheckin"></a>
# **PostAdLibraryNameCheckIn**
> void PostAdLibraryNameCheckIn (string name, AdLibraryCheckInRequest adLibraryCheckInRequest = null)

Check service accounts in to the library.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAdLibraryNameCheckInExample
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
            var adLibraryCheckInRequest = new AdLibraryCheckInRequest(); // AdLibraryCheckInRequest |  (optional) 

            try
            {
                // Check service accounts in to the library.
                apiInstance.PostAdLibraryNameCheckIn(name, adLibraryCheckInRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostAdLibraryNameCheckIn: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the set. | 
 **adLibraryCheckInRequest** | [**AdLibraryCheckInRequest**](AdLibraryCheckInRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postadlibrarynamecheckout"></a>
# **PostAdLibraryNameCheckOut**
> void PostAdLibraryNameCheckOut (string name, AdLibraryCheckOutRequest adLibraryCheckOutRequest = null)

Check a service account out from the library.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAdLibraryNameCheckOutExample
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
            var adLibraryCheckOutRequest = new AdLibraryCheckOutRequest(); // AdLibraryCheckOutRequest |  (optional) 

            try
            {
                // Check a service account out from the library.
                apiInstance.PostAdLibraryNameCheckOut(name, adLibraryCheckOutRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostAdLibraryNameCheckOut: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the set | 
 **adLibraryCheckOutRequest** | [**AdLibraryCheckOutRequest**](AdLibraryCheckOutRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postadrolesname"></a>
# **PostAdRolesName**
> void PostAdRolesName (string name, AdRolesRequest adRolesRequest = null)

Manage roles to build links between Vault and Active Directory service accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAdRolesNameExample
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
            var adRolesRequest = new AdRolesRequest(); // AdRolesRequest |  (optional) 

            try
            {
                // Manage roles to build links between Vault and Active Directory service accounts.
                apiInstance.PostAdRolesName(name, adRolesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostAdRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **adRolesRequest** | [**AdRolesRequest**](AdRolesRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postadrotaterolename"></a>
# **PostAdRotateRoleName**
> void PostAdRotateRoleName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAdRotateRoleNameExample
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

            try
            {
                apiInstance.PostAdRotateRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostAdRotateRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the static role | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postadrotateroot"></a>
# **PostAdRotateRoot**
> void PostAdRotateRoot ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAdRotateRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.PostAdRotateRoot();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostAdRotateRoot: " + e.Message );
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

<a name="postalicloudconfig"></a>
# **PostAlicloudConfig**
> void PostAlicloudConfig (AlicloudConfigRequest alicloudConfigRequest = null)

Configure the access key and secret to use for RAM and STS calls.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAlicloudConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var alicloudConfigRequest = new AlicloudConfigRequest(); // AlicloudConfigRequest |  (optional) 

            try
            {
                // Configure the access key and secret to use for RAM and STS calls.
                apiInstance.PostAlicloudConfig(alicloudConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostAlicloudConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **alicloudConfigRequest** | [**AlicloudConfigRequest**](AlicloudConfigRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postalicloudrolename"></a>
# **PostAlicloudRoleName**
> void PostAlicloudRoleName (string name, AlicloudRoleRequest alicloudRoleRequest = null)

Read, write and reference policies and roles that API keys or STS credentials can be made for.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAlicloudRoleNameExample
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
            var alicloudRoleRequest = new AlicloudRoleRequest(); // AlicloudRoleRequest |  (optional) 

            try
            {
                // Read, write and reference policies and roles that API keys or STS credentials can be made for.
                apiInstance.PostAlicloudRoleName(name, alicloudRoleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostAlicloudRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the role. | 
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

<a name="postawsconfiglease"></a>
# **PostAwsConfigLease**
> void PostAwsConfigLease (AwsConfigLeaseRequest awsConfigLeaseRequest = null)

Configure the default lease information for generated credentials.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAwsConfigLeaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var awsConfigLeaseRequest = new AwsConfigLeaseRequest(); // AwsConfigLeaseRequest |  (optional) 

            try
            {
                // Configure the default lease information for generated credentials.
                apiInstance.PostAwsConfigLease(awsConfigLeaseRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostAwsConfigLease: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsConfigLeaseRequest** | [**AwsConfigLeaseRequest**](AwsConfigLeaseRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postawsconfigroot"></a>
# **PostAwsConfigRoot**
> void PostAwsConfigRoot (AwsConfigRootRequest awsConfigRootRequest = null)

Configure the root credentials that are used to manage IAM.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAwsConfigRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var awsConfigRootRequest = new AwsConfigRootRequest(); // AwsConfigRootRequest |  (optional) 

            try
            {
                // Configure the root credentials that are used to manage IAM.
                apiInstance.PostAwsConfigRoot(awsConfigRootRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostAwsConfigRoot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsConfigRootRequest** | [**AwsConfigRootRequest**](AwsConfigRootRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postawsconfigrotateroot"></a>
# **PostAwsConfigRotateRoot**
> void PostAwsConfigRotateRoot ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAwsConfigRotateRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.PostAwsConfigRotateRoot();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostAwsConfigRotateRoot: " + e.Message );
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

<a name="postawscreds"></a>
# **PostAwsCreds**
> void PostAwsCreds (AwsCredsRequest awsCredsRequest = null)

Generate AWS credentials from a specific Vault role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAwsCredsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var awsCredsRequest = new AwsCredsRequest(); // AwsCredsRequest |  (optional) 

            try
            {
                // Generate AWS credentials from a specific Vault role.
                apiInstance.PostAwsCreds(awsCredsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostAwsCreds: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awsCredsRequest** | [**AwsCredsRequest**](AwsCredsRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postawsrolesname"></a>
# **PostAwsRolesName**
> void PostAwsRolesName (string name, AwsRolesRequest awsRolesRequest = null)

Read, write and reference IAM policies that access keys can be made for.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAwsRolesNameExample
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
            var awsRolesRequest = new AwsRolesRequest(); // AwsRolesRequest |  (optional) 

            try
            {
                // Read, write and reference IAM policies that access keys can be made for.
                apiInstance.PostAwsRolesName(name, awsRolesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostAwsRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the policy | 
 **awsRolesRequest** | [**AwsRolesRequest**](AwsRolesRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postawsstsname"></a>
# **PostAwsStsName**
> void PostAwsStsName (string name, AwsStsRequest awsStsRequest = null)

Generate AWS credentials from a specific Vault role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAwsStsNameExample
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
            var awsStsRequest = new AwsStsRequest(); // AwsStsRequest |  (optional) 

            try
            {
                // Generate AWS credentials from a specific Vault role.
                apiInstance.PostAwsStsName(name, awsStsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostAwsStsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **awsStsRequest** | [**AwsStsRequest**](AwsStsRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postazureconfig"></a>
# **PostAzureConfig**
> void PostAzureConfig (AzureConfigRequest azureConfigRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAzureConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var azureConfigRequest = new AzureConfigRequest(); // AzureConfigRequest |  (optional) 

            try
            {
                apiInstance.PostAzureConfig(azureConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostAzureConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postazurerolesname"></a>
# **PostAzureRolesName**
> void PostAzureRolesName (string name, AzureRolesRequest azureRolesRequest = null)

Manage the Vault roles used to generate Azure credentials.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAzureRolesNameExample
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
            var azureRolesRequest = new AzureRolesRequest(); // AzureRolesRequest |  (optional) 

            try
            {
                // Manage the Vault roles used to generate Azure credentials.
                apiInstance.PostAzureRolesName(name, azureRolesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostAzureRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **azureRolesRequest** | [**AzureRolesRequest**](AzureRolesRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postazurerotateroot"></a>
# **PostAzureRotateRoot**
> void PostAzureRotateRoot ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostAzureRotateRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.PostAzureRotateRoot();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostAzureRotateRoot: " + e.Message );
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

<a name="postconsulconfigaccess"></a>
# **PostConsulConfigAccess**
> void PostConsulConfigAccess (ConsulConfigAccessRequest consulConfigAccessRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostConsulConfigAccessExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var consulConfigAccessRequest = new ConsulConfigAccessRequest(); // ConsulConfigAccessRequest |  (optional) 

            try
            {
                apiInstance.PostConsulConfigAccess(consulConfigAccessRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostConsulConfigAccess: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **consulConfigAccessRequest** | [**ConsulConfigAccessRequest**](ConsulConfigAccessRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postconsulrolesname"></a>
# **PostConsulRolesName**
> void PostConsulRolesName (string name, ConsulRolesRequest consulRolesRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostConsulRolesNameExample
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
            var consulRolesRequest = new ConsulRolesRequest(); // ConsulRolesRequest |  (optional) 

            try
            {
                apiInstance.PostConsulRolesName(name, consulRolesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostConsulRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **consulRolesRequest** | [**ConsulRolesRequest**](ConsulRolesRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcubbyholepath"></a>
# **PostCubbyholePath**
> void PostCubbyholePath (string path)

Store a secret at the specified location.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostCubbyholePathExample
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
                apiInstance.PostCubbyholePath(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostCubbyholePath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="postgcpconfig"></a>
# **PostGcpConfig**
> void PostGcpConfig (GcpConfigRequest gcpConfigRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostGcpConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var gcpConfigRequest = new GcpConfigRequest(); // GcpConfigRequest |  (optional) 

            try
            {
                apiInstance.PostGcpConfig(gcpConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostGcpConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postgcpconfigrotateroot"></a>
# **PostGcpConfigRotateRoot**
> void PostGcpConfigRotateRoot ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostGcpConfigRotateRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.PostGcpConfigRotateRoot();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostGcpConfigRotateRoot: " + e.Message );
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

<a name="postgcpkeyroleset"></a>
# **PostGcpKeyRoleset**
> void PostGcpKeyRoleset (string roleset, GcpKeyRequest gcpKeyRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostGcpKeyRolesetExample
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
            var gcpKeyRequest = new GcpKeyRequest(); // GcpKeyRequest |  (optional) 

            try
            {
                apiInstance.PostGcpKeyRoleset(roleset, gcpKeyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostGcpKeyRoleset: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleset** | **string**| Required. Name of the role set. | 
 **gcpKeyRequest** | [**GcpKeyRequest**](GcpKeyRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgcprolesetname"></a>
# **PostGcpRolesetName**
> void PostGcpRolesetName (string name, GcpRolesetRequest gcpRolesetRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostGcpRolesetNameExample
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
            var gcpRolesetRequest = new GcpRolesetRequest(); // GcpRolesetRequest |  (optional) 

            try
            {
                apiInstance.PostGcpRolesetName(name, gcpRolesetRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostGcpRolesetName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Required. Name of the role. | 
 **gcpRolesetRequest** | [**GcpRolesetRequest**](GcpRolesetRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgcprolesetnamerotate"></a>
# **PostGcpRolesetNameRotate**
> void PostGcpRolesetNameRotate (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostGcpRolesetNameRotateExample
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

            try
            {
                apiInstance.PostGcpRolesetNameRotate(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostGcpRolesetNameRotate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postgcprolesetnamerotatekey"></a>
# **PostGcpRolesetNameRotateKey**
> void PostGcpRolesetNameRotateKey (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostGcpRolesetNameRotateKeyExample
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

            try
            {
                apiInstance.PostGcpRolesetNameRotateKey(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostGcpRolesetNameRotateKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postgcprolesetrolesetkey"></a>
# **PostGcpRolesetRolesetKey**
> void PostGcpRolesetRolesetKey (string roleset, GcpRolesetKeyRequest gcpRolesetKeyRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostGcpRolesetRolesetKeyExample
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
            var gcpRolesetKeyRequest = new GcpRolesetKeyRequest(); // GcpRolesetKeyRequest |  (optional) 

            try
            {
                apiInstance.PostGcpRolesetRolesetKey(roleset, gcpRolesetKeyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostGcpRolesetRolesetKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleset** | **string**| Required. Name of the role set. | 
 **gcpRolesetKeyRequest** | [**GcpRolesetKeyRequest**](GcpRolesetKeyRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgcprolesetrolesettoken"></a>
# **PostGcpRolesetRolesetToken**
> void PostGcpRolesetRolesetToken (string roleset)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostGcpRolesetRolesetTokenExample
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

            try
            {
                apiInstance.PostGcpRolesetRolesetToken(roleset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostGcpRolesetRolesetToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleset** | **string**| Required. Name of the role set. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgcpstaticaccountname"></a>
# **PostGcpStaticAccountName**
> void PostGcpStaticAccountName (string name, GcpStaticAccountRequest gcpStaticAccountRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostGcpStaticAccountNameExample
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
            var gcpStaticAccountRequest = new GcpStaticAccountRequest(); // GcpStaticAccountRequest |  (optional) 

            try
            {
                apiInstance.PostGcpStaticAccountName(name, gcpStaticAccountRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostGcpStaticAccountName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Required. Name to refer to this static account in Vault. Cannot be updated. | 
 **gcpStaticAccountRequest** | [**GcpStaticAccountRequest**](GcpStaticAccountRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgcpstaticaccountnamekey"></a>
# **PostGcpStaticAccountNameKey**
> void PostGcpStaticAccountNameKey (string name, GcpStaticAccountKeyRequest gcpStaticAccountKeyRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostGcpStaticAccountNameKeyExample
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
            var gcpStaticAccountKeyRequest = new GcpStaticAccountKeyRequest(); // GcpStaticAccountKeyRequest |  (optional) 

            try
            {
                apiInstance.PostGcpStaticAccountNameKey(name, gcpStaticAccountKeyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostGcpStaticAccountNameKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Required. Name of the static account. | 
 **gcpStaticAccountKeyRequest** | [**GcpStaticAccountKeyRequest**](GcpStaticAccountKeyRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgcpstaticaccountnamerotatekey"></a>
# **PostGcpStaticAccountNameRotateKey**
> void PostGcpStaticAccountNameRotateKey (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostGcpStaticAccountNameRotateKeyExample
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

            try
            {
                apiInstance.PostGcpStaticAccountNameRotateKey(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostGcpStaticAccountNameRotateKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgcpstaticaccountnametoken"></a>
# **PostGcpStaticAccountNameToken**
> void PostGcpStaticAccountNameToken (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostGcpStaticAccountNameTokenExample
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

            try
            {
                apiInstance.PostGcpStaticAccountNameToken(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostGcpStaticAccountNameToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Required. Name of the static account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgcptokenroleset"></a>
# **PostGcpTokenRoleset**
> void PostGcpTokenRoleset (string roleset)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostGcpTokenRolesetExample
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

            try
            {
                apiInstance.PostGcpTokenRoleset(roleset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostGcpTokenRoleset: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleset** | **string**| Required. Name of the role set. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgcpkmsconfig"></a>
# **PostGcpkmsConfig**
> void PostGcpkmsConfig (GcpkmsConfigRequest gcpkmsConfigRequest = null)

Configure the GCP KMS secrets engine

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostGcpkmsConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var gcpkmsConfigRequest = new GcpkmsConfigRequest(); // GcpkmsConfigRequest |  (optional) 

            try
            {
                // Configure the GCP KMS secrets engine
                apiInstance.PostGcpkmsConfig(gcpkmsConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostGcpkmsConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gcpkmsConfigRequest** | [**GcpkmsConfigRequest**](GcpkmsConfigRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgcpkmsdecryptkey"></a>
# **PostGcpkmsDecryptKey**
> void PostGcpkmsDecryptKey (string key, GcpkmsDecryptRequest gcpkmsDecryptRequest = null)

Decrypt a ciphertext value using a named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostGcpkmsDecryptKeyExample
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
            var gcpkmsDecryptRequest = new GcpkmsDecryptRequest(); // GcpkmsDecryptRequest |  (optional) 

            try
            {
                // Decrypt a ciphertext value using a named key
                apiInstance.PostGcpkmsDecryptKey(key, gcpkmsDecryptRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostGcpkmsDecryptKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key in Vault to use for decryption. This key must already exist in Vault and must map back to a Google Cloud KMS key. | 
 **gcpkmsDecryptRequest** | [**GcpkmsDecryptRequest**](GcpkmsDecryptRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgcpkmsencryptkey"></a>
# **PostGcpkmsEncryptKey**
> void PostGcpkmsEncryptKey (string key, GcpkmsEncryptRequest gcpkmsEncryptRequest = null)

Encrypt a plaintext value using a named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostGcpkmsEncryptKeyExample
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
            var gcpkmsEncryptRequest = new GcpkmsEncryptRequest(); // GcpkmsEncryptRequest |  (optional) 

            try
            {
                // Encrypt a plaintext value using a named key
                apiInstance.PostGcpkmsEncryptKey(key, gcpkmsEncryptRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostGcpkmsEncryptKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key in Vault to use for encryption. This key must already exist in Vault and must map back to a Google Cloud KMS key. | 
 **gcpkmsEncryptRequest** | [**GcpkmsEncryptRequest**](GcpkmsEncryptRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgcpkmskeysconfigkey"></a>
# **PostGcpkmsKeysConfigKey**
> void PostGcpkmsKeysConfigKey (string key, GcpkmsKeysConfigRequest gcpkmsKeysConfigRequest = null)

Configure the key in Vault

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostGcpkmsKeysConfigKeyExample
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
            var gcpkmsKeysConfigRequest = new GcpkmsKeysConfigRequest(); // GcpkmsKeysConfigRequest |  (optional) 

            try
            {
                // Configure the key in Vault
                apiInstance.PostGcpkmsKeysConfigKey(key, gcpkmsKeysConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostGcpkmsKeysConfigKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key in Vault. | 
 **gcpkmsKeysConfigRequest** | [**GcpkmsKeysConfigRequest**](GcpkmsKeysConfigRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgcpkmskeysderegisterkey"></a>
# **PostGcpkmsKeysDeregisterKey**
> void PostGcpkmsKeysDeregisterKey (string key)

Deregister an existing key in Vault

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostGcpkmsKeysDeregisterKeyExample
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

            try
            {
                // Deregister an existing key in Vault
                apiInstance.PostGcpkmsKeysDeregisterKey(key);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostGcpkmsKeysDeregisterKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key to deregister in Vault. If the key exists in Google Cloud KMS, it will be left untouched. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgcpkmskeyskey"></a>
# **PostGcpkmsKeysKey**
> void PostGcpkmsKeysKey (string key, GcpkmsKeysRequest gcpkmsKeysRequest = null)

Interact with crypto keys in Vault and Google Cloud KMS

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostGcpkmsKeysKeyExample
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
            var gcpkmsKeysRequest = new GcpkmsKeysRequest(); // GcpkmsKeysRequest |  (optional) 

            try
            {
                // Interact with crypto keys in Vault and Google Cloud KMS
                apiInstance.PostGcpkmsKeysKey(key, gcpkmsKeysRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostGcpkmsKeysKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key in Vault. | 
 **gcpkmsKeysRequest** | [**GcpkmsKeysRequest**](GcpkmsKeysRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgcpkmskeysregisterkey"></a>
# **PostGcpkmsKeysRegisterKey**
> void PostGcpkmsKeysRegisterKey (string key, GcpkmsKeysRegisterRequest gcpkmsKeysRegisterRequest = null)

Register an existing crypto key in Google Cloud KMS

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostGcpkmsKeysRegisterKeyExample
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
            var gcpkmsKeysRegisterRequest = new GcpkmsKeysRegisterRequest(); // GcpkmsKeysRegisterRequest |  (optional) 

            try
            {
                // Register an existing crypto key in Google Cloud KMS
                apiInstance.PostGcpkmsKeysRegisterKey(key, gcpkmsKeysRegisterRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostGcpkmsKeysRegisterKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key to register in Vault. This will be the named used to refer to the underlying crypto key when encrypting or decrypting data. | 
 **gcpkmsKeysRegisterRequest** | [**GcpkmsKeysRegisterRequest**](GcpkmsKeysRegisterRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgcpkmskeysrotatekey"></a>
# **PostGcpkmsKeysRotateKey**
> void PostGcpkmsKeysRotateKey (string key)

Rotate a crypto key to a new primary version

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostGcpkmsKeysRotateKeyExample
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

            try
            {
                // Rotate a crypto key to a new primary version
                apiInstance.PostGcpkmsKeysRotateKey(key);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostGcpkmsKeysRotateKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key to rotate. This key must already be registered with Vault and point to a valid Google Cloud KMS crypto key. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgcpkmskeystrimkey"></a>
# **PostGcpkmsKeysTrimKey**
> void PostGcpkmsKeysTrimKey (string key)

Delete old crypto key versions from Google Cloud KMS

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostGcpkmsKeysTrimKeyExample
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

            try
            {
                // Delete old crypto key versions from Google Cloud KMS
                apiInstance.PostGcpkmsKeysTrimKey(key);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostGcpkmsKeysTrimKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key in Vault. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgcpkmsreencryptkey"></a>
# **PostGcpkmsReencryptKey**
> void PostGcpkmsReencryptKey (string key, GcpkmsReencryptRequest gcpkmsReencryptRequest = null)

Re-encrypt existing ciphertext data to a new version

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostGcpkmsReencryptKeyExample
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
            var gcpkmsReencryptRequest = new GcpkmsReencryptRequest(); // GcpkmsReencryptRequest |  (optional) 

            try
            {
                // Re-encrypt existing ciphertext data to a new version
                apiInstance.PostGcpkmsReencryptKey(key, gcpkmsReencryptRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostGcpkmsReencryptKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key to use for encryption. This key must already exist in Vault and Google Cloud KMS. | 
 **gcpkmsReencryptRequest** | [**GcpkmsReencryptRequest**](GcpkmsReencryptRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgcpkmssignkey"></a>
# **PostGcpkmsSignKey**
> void PostGcpkmsSignKey (string key, GcpkmsSignRequest gcpkmsSignRequest = null)

Signs a message or digest using a named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostGcpkmsSignKeyExample
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
            var gcpkmsSignRequest = new GcpkmsSignRequest(); // GcpkmsSignRequest |  (optional) 

            try
            {
                // Signs a message or digest using a named key
                apiInstance.PostGcpkmsSignKey(key, gcpkmsSignRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostGcpkmsSignKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key in Vault to use for signing. This key must already exist in Vault and must map back to a Google Cloud KMS key. | 
 **gcpkmsSignRequest** | [**GcpkmsSignRequest**](GcpkmsSignRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgcpkmsverifykey"></a>
# **PostGcpkmsVerifyKey**
> void PostGcpkmsVerifyKey (string key, GcpkmsVerifyRequest gcpkmsVerifyRequest = null)

Verify a signature using a named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostGcpkmsVerifyKeyExample
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
            var gcpkmsVerifyRequest = new GcpkmsVerifyRequest(); // GcpkmsVerifyRequest |  (optional) 

            try
            {
                // Verify a signature using a named key
                apiInstance.PostGcpkmsVerifyKey(key, gcpkmsVerifyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostGcpkmsVerifyKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Name of the key in Vault to use for verification. This key must already exist in Vault and must map back to a Google Cloud KMS key. | 
 **gcpkmsVerifyRequest** | [**GcpkmsVerifyRequest**](GcpkmsVerifyRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postkubernetesconfig"></a>
# **PostKubernetesConfig**
> void PostKubernetesConfig (KubernetesConfigRequest kubernetesConfigRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostKubernetesConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var kubernetesConfigRequest = new KubernetesConfigRequest(); // KubernetesConfigRequest |  (optional) 

            try
            {
                apiInstance.PostKubernetesConfig(kubernetesConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostKubernetesConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postkubernetescredsname"></a>
# **PostKubernetesCredsName**
> void PostKubernetesCredsName (string name, KubernetesCredsRequest kubernetesCredsRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostKubernetesCredsNameExample
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
            var kubernetesCredsRequest = new KubernetesCredsRequest(); // KubernetesCredsRequest |  (optional) 

            try
            {
                apiInstance.PostKubernetesCredsName(name, kubernetesCredsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostKubernetesCredsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the Vault role | 
 **kubernetesCredsRequest** | [**KubernetesCredsRequest**](KubernetesCredsRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postkubernetesrolesname"></a>
# **PostKubernetesRolesName**
> void PostKubernetesRolesName (string name, KubernetesRolesRequest kubernetesRolesRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostKubernetesRolesNameExample
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
            var kubernetesRolesRequest = new KubernetesRolesRequest(); // KubernetesRolesRequest |  (optional) 

            try
            {
                apiInstance.PostKubernetesRolesName(name, kubernetesRolesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostKubernetesRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **kubernetesRolesRequest** | [**KubernetesRolesRequest**](KubernetesRolesRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postkvpath"></a>
# **PostKvPath**
> void PostKvPath (string path)

Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostKvPathExample
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

            try
            {
                // Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.
                apiInstance.PostKvPath(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostKvPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postmongodbatlasconfig"></a>
# **PostMongodbatlasConfig**
> void PostMongodbatlasConfig (MongodbatlasConfigRequest mongodbatlasConfigRequest = null)

Configure the  credentials that are used to manage Database Users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostMongodbatlasConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mongodbatlasConfigRequest = new MongodbatlasConfigRequest(); // MongodbatlasConfigRequest |  (optional) 

            try
            {
                // Configure the  credentials that are used to manage Database Users.
                apiInstance.PostMongodbatlasConfig(mongodbatlasConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostMongodbatlasConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mongodbatlasConfigRequest** | [**MongodbatlasConfigRequest**](MongodbatlasConfigRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postmongodbatlascredsname"></a>
# **PostMongodbatlasCredsName**
> void PostMongodbatlasCredsName (string name)

Generate MongoDB Atlas Programmatic API from a specific Vault role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostMongodbatlasCredsNameExample
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

            try
            {
                // Generate MongoDB Atlas Programmatic API from a specific Vault role.
                apiInstance.PostMongodbatlasCredsName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostMongodbatlasCredsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postmongodbatlasrolesname"></a>
# **PostMongodbatlasRolesName**
> void PostMongodbatlasRolesName (string name, MongodbatlasRolesRequest mongodbatlasRolesRequest = null)

Manage the roles used to generate MongoDB Atlas Programmatic API Keys.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostMongodbatlasRolesNameExample
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
            var mongodbatlasRolesRequest = new MongodbatlasRolesRequest(); // MongodbatlasRolesRequest |  (optional) 

            try
            {
                // Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
                apiInstance.PostMongodbatlasRolesName(name, mongodbatlasRolesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostMongodbatlasRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the Roles | 
 **mongodbatlasRolesRequest** | [**MongodbatlasRolesRequest**](MongodbatlasRolesRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postnomadconfigaccess"></a>
# **PostNomadConfigAccess**
> void PostNomadConfigAccess (NomadConfigAccessRequest nomadConfigAccessRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostNomadConfigAccessExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var nomadConfigAccessRequest = new NomadConfigAccessRequest(); // NomadConfigAccessRequest |  (optional) 

            try
            {
                apiInstance.PostNomadConfigAccess(nomadConfigAccessRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostNomadConfigAccess: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nomadConfigAccessRequest** | [**NomadConfigAccessRequest**](NomadConfigAccessRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postnomadconfiglease"></a>
# **PostNomadConfigLease**
> void PostNomadConfigLease (NomadConfigLeaseRequest nomadConfigLeaseRequest = null)

Configure the lease parameters for generated tokens

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostNomadConfigLeaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var nomadConfigLeaseRequest = new NomadConfigLeaseRequest(); // NomadConfigLeaseRequest |  (optional) 

            try
            {
                // Configure the lease parameters for generated tokens
                apiInstance.PostNomadConfigLease(nomadConfigLeaseRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostNomadConfigLease: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nomadConfigLeaseRequest** | [**NomadConfigLeaseRequest**](NomadConfigLeaseRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postnomadrolename"></a>
# **PostNomadRoleName**
> void PostNomadRoleName (string name, NomadRoleRequest nomadRoleRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostNomadRoleNameExample
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
            var nomadRoleRequest = new NomadRoleRequest(); // NomadRoleRequest |  (optional) 

            try
            {
                apiInstance.PostNomadRoleName(name, nomadRoleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostNomadRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **nomadRoleRequest** | [**NomadRoleRequest**](NomadRoleRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postopenldapconfig"></a>
# **PostOpenldapConfig**
> void PostOpenldapConfig (OpenldapConfigRequest openldapConfigRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostOpenldapConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var openldapConfigRequest = new OpenldapConfigRequest(); // OpenldapConfigRequest |  (optional) 

            try
            {
                apiInstance.PostOpenldapConfig(openldapConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostOpenldapConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **openldapConfigRequest** | [**OpenldapConfigRequest**](OpenldapConfigRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postopenldaprolename"></a>
# **PostOpenldapRoleName**
> void PostOpenldapRoleName (string name, OpenldapRoleRequest openldapRoleRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostOpenldapRoleNameExample
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
            var openldapRoleRequest = new OpenldapRoleRequest(); // OpenldapRoleRequest |  (optional) 

            try
            {
                apiInstance.PostOpenldapRoleName(name, openldapRoleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostOpenldapRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the role (lowercase) | 
 **openldapRoleRequest** | [**OpenldapRoleRequest**](OpenldapRoleRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postopenldaprotaterolename"></a>
# **PostOpenldapRotateRoleName**
> void PostOpenldapRotateRoleName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostOpenldapRotateRoleNameExample
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

            try
            {
                apiInstance.PostOpenldapRotateRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostOpenldapRotateRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the static role | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postopenldaprotateroot"></a>
# **PostOpenldapRotateRoot**
> void PostOpenldapRotateRoot ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostOpenldapRotateRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.PostOpenldapRotateRoot();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostOpenldapRotateRoot: " + e.Message );
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

<a name="postopenldapstaticrolename"></a>
# **PostOpenldapStaticRoleName**
> void PostOpenldapStaticRoleName (string name, OpenldapStaticRoleRequest openldapStaticRoleRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostOpenldapStaticRoleNameExample
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
            var openldapStaticRoleRequest = new OpenldapStaticRoleRequest(); // OpenldapStaticRoleRequest |  (optional) 

            try
            {
                apiInstance.PostOpenldapStaticRoleName(name, openldapStaticRoleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostOpenldapStaticRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **openldapStaticRoleRequest** | [**OpenldapStaticRoleRequest**](OpenldapStaticRoleRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkibundle"></a>
# **PostPkiBundle**
> void PostPkiBundle (PkiBundleRequest pkiBundleRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiBundleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiBundleRequest = new PkiBundleRequest(); // PkiBundleRequest |  (optional) 

            try
            {
                apiInstance.PostPkiBundle(pkiBundleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiBundle: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiBundleRequest** | [**PkiBundleRequest**](PkiBundleRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkicert"></a>
# **PostPkiCert**
> void PostPkiCert (PkiCertRequest pkiCertRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiCertExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiCertRequest = new PkiCertRequest(); // PkiCertRequest |  (optional) 

            try
            {
                apiInstance.PostPkiCert(pkiCertRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiCert: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiCertRequest** | [**PkiCertRequest**](PkiCertRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkiconfigca"></a>
# **PostPkiConfigCa**
> void PostPkiConfigCa (PkiConfigCaRequest pkiConfigCaRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiConfigCaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiConfigCaRequest = new PkiConfigCaRequest(); // PkiConfigCaRequest |  (optional) 

            try
            {
                apiInstance.PostPkiConfigCa(pkiConfigCaRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiConfigCa: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiConfigCaRequest** | [**PkiConfigCaRequest**](PkiConfigCaRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkiconfigcrl"></a>
# **PostPkiConfigCrl**
> void PostPkiConfigCrl (PkiConfigCrlRequest pkiConfigCrlRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiConfigCrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiConfigCrlRequest = new PkiConfigCrlRequest(); // PkiConfigCrlRequest |  (optional) 

            try
            {
                apiInstance.PostPkiConfigCrl(pkiConfigCrlRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiConfigCrl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiConfigCrlRequest** | [**PkiConfigCrlRequest**](PkiConfigCrlRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkiconfigissuers"></a>
# **PostPkiConfigIssuers**
> void PostPkiConfigIssuers (PkiConfigIssuersRequest pkiConfigIssuersRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiConfigIssuersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiConfigIssuersRequest = new PkiConfigIssuersRequest(); // PkiConfigIssuersRequest |  (optional) 

            try
            {
                apiInstance.PostPkiConfigIssuers(pkiConfigIssuersRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiConfigIssuers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiConfigIssuersRequest** | [**PkiConfigIssuersRequest**](PkiConfigIssuersRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkiconfigkeys"></a>
# **PostPkiConfigKeys**
> void PostPkiConfigKeys (PkiConfigKeysRequest pkiConfigKeysRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiConfigKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiConfigKeysRequest = new PkiConfigKeysRequest(); // PkiConfigKeysRequest |  (optional) 

            try
            {
                apiInstance.PostPkiConfigKeys(pkiConfigKeysRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiConfigKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiConfigKeysRequest** | [**PkiConfigKeysRequest**](PkiConfigKeysRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkiconfigurls"></a>
# **PostPkiConfigUrls**
> void PostPkiConfigUrls (PkiConfigUrlsRequest pkiConfigUrlsRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiConfigUrlsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiConfigUrlsRequest = new PkiConfigUrlsRequest(); // PkiConfigUrlsRequest |  (optional) 

            try
            {
                apiInstance.PostPkiConfigUrls(pkiConfigUrlsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiConfigUrls: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiConfigUrlsRequest** | [**PkiConfigUrlsRequest**](PkiConfigUrlsRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkiintermediatecrosssign"></a>
# **PostPkiIntermediateCrossSign**
> void PostPkiIntermediateCrossSign (PkiIntermediateCrossSignRequest pkiIntermediateCrossSignRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiIntermediateCrossSignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiIntermediateCrossSignRequest = new PkiIntermediateCrossSignRequest(); // PkiIntermediateCrossSignRequest |  (optional) 

            try
            {
                apiInstance.PostPkiIntermediateCrossSign(pkiIntermediateCrossSignRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiIntermediateCrossSign: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiIntermediateCrossSignRequest** | [**PkiIntermediateCrossSignRequest**](PkiIntermediateCrossSignRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkiintermediategenerateexported"></a>
# **PostPkiIntermediateGenerateExported**
> void PostPkiIntermediateGenerateExported (string exported, PkiIntermediateGenerateRequest pkiIntermediateGenerateRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiIntermediateGenerateExportedExample
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
            var pkiIntermediateGenerateRequest = new PkiIntermediateGenerateRequest(); // PkiIntermediateGenerateRequest |  (optional) 

            try
            {
                apiInstance.PostPkiIntermediateGenerateExported(exported, pkiIntermediateGenerateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiIntermediateGenerateExported: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exported** | **string**| Must be \&quot;internal\&quot;, \&quot;exported\&quot; or \&quot;kms\&quot;. If set to \&quot;exported\&quot;, the generated private key will be returned. This is your *only* chance to retrieve the private key! | 
 **pkiIntermediateGenerateRequest** | [**PkiIntermediateGenerateRequest**](PkiIntermediateGenerateRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkiintermediatesetsigned"></a>
# **PostPkiIntermediateSetSigned**
> void PostPkiIntermediateSetSigned (PkiIntermediateSetSignedRequest pkiIntermediateSetSignedRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiIntermediateSetSignedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiIntermediateSetSignedRequest = new PkiIntermediateSetSignedRequest(); // PkiIntermediateSetSignedRequest |  (optional) 

            try
            {
                apiInstance.PostPkiIntermediateSetSigned(pkiIntermediateSetSignedRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiIntermediateSetSigned: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiIntermediateSetSignedRequest** | [**PkiIntermediateSetSignedRequest**](PkiIntermediateSetSignedRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkiinternalexported"></a>
# **PostPkiInternalExported**
> void PostPkiInternalExported (PkiInternalExportedRequest pkiInternalExportedRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiInternalExportedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiInternalExportedRequest = new PkiInternalExportedRequest(); // PkiInternalExportedRequest |  (optional) 

            try
            {
                apiInstance.PostPkiInternalExported(pkiInternalExportedRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiInternalExported: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiInternalExportedRequest** | [**PkiInternalExportedRequest**](PkiInternalExportedRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkiissuerole"></a>
# **PostPkiIssueRole**
> void PostPkiIssueRole (string role, PkiIssueRequest pkiIssueRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiIssueRoleExample
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
            var pkiIssueRequest = new PkiIssueRequest(); // PkiIssueRequest |  (optional) 

            try
            {
                apiInstance.PostPkiIssueRole(role, pkiIssueRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiIssueRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The desired role with configuration for this request | 
 **pkiIssueRequest** | [**PkiIssueRequest**](PkiIssueRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkiissuerissuerrefissuerole"></a>
# **PostPkiIssuerIssuerRefIssueRole**
> void PostPkiIssuerIssuerRefIssueRole (string issuerRef, string role, PkiIssuerIssueRequest pkiIssuerIssueRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiIssuerIssuerRefIssueRoleExample
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
            var pkiIssuerIssueRequest = new PkiIssuerIssueRequest(); // PkiIssuerIssueRequest |  (optional) 

            try
            {
                apiInstance.PostPkiIssuerIssuerRefIssueRole(issuerRef, role, pkiIssuerIssueRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiIssuerIssuerRefIssueRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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
 **pkiIssuerIssueRequest** | [**PkiIssuerIssueRequest**](PkiIssuerIssueRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkiissuerissuerrefsignintermediate"></a>
# **PostPkiIssuerIssuerRefSignIntermediate**
> void PostPkiIssuerIssuerRefSignIntermediate (string issuerRef, PkiIssuerSignIntermediateRequest pkiIssuerSignIntermediateRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiIssuerIssuerRefSignIntermediateExample
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
            var pkiIssuerSignIntermediateRequest = new PkiIssuerSignIntermediateRequest(); // PkiIssuerSignIntermediateRequest |  (optional) 

            try
            {
                apiInstance.PostPkiIssuerIssuerRefSignIntermediate(issuerRef, pkiIssuerSignIntermediateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiIssuerIssuerRefSignIntermediate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]
 **pkiIssuerSignIntermediateRequest** | [**PkiIssuerSignIntermediateRequest**](PkiIssuerSignIntermediateRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkiissuerissuerrefsignrole"></a>
# **PostPkiIssuerIssuerRefSignRole**
> void PostPkiIssuerIssuerRefSignRole (string issuerRef, string role, PkiIssuerSignRequest pkiIssuerSignRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiIssuerIssuerRefSignRoleExample
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
            var pkiIssuerSignRequest = new PkiIssuerSignRequest(); // PkiIssuerSignRequest |  (optional) 

            try
            {
                apiInstance.PostPkiIssuerIssuerRefSignRole(issuerRef, role, pkiIssuerSignRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiIssuerIssuerRefSignRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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
 **pkiIssuerSignRequest** | [**PkiIssuerSignRequest**](PkiIssuerSignRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkiissuerissuerrefsignselfissued"></a>
# **PostPkiIssuerIssuerRefSignSelfIssued**
> void PostPkiIssuerIssuerRefSignSelfIssued (string issuerRef, PkiIssuerSignSelfIssuedRequest pkiIssuerSignSelfIssuedRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiIssuerIssuerRefSignSelfIssuedExample
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
            var pkiIssuerSignSelfIssuedRequest = new PkiIssuerSignSelfIssuedRequest(); // PkiIssuerSignSelfIssuedRequest |  (optional) 

            try
            {
                apiInstance.PostPkiIssuerIssuerRefSignSelfIssued(issuerRef, pkiIssuerSignSelfIssuedRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiIssuerIssuerRefSignSelfIssued: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]
 **pkiIssuerSignSelfIssuedRequest** | [**PkiIssuerSignSelfIssuedRequest**](PkiIssuerSignSelfIssuedRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkiissuerissuerrefsignverbatim"></a>
# **PostPkiIssuerIssuerRefSignVerbatim**
> void PostPkiIssuerIssuerRefSignVerbatim (string issuerRef, PkiIssuerSignVerbatimRequest pkiIssuerSignVerbatimRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiIssuerIssuerRefSignVerbatimExample
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
            var pkiIssuerSignVerbatimRequest = new PkiIssuerSignVerbatimRequest(); // PkiIssuerSignVerbatimRequest |  (optional) 

            try
            {
                apiInstance.PostPkiIssuerIssuerRefSignVerbatim(issuerRef, pkiIssuerSignVerbatimRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiIssuerIssuerRefSignVerbatim: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]
 **pkiIssuerSignVerbatimRequest** | [**PkiIssuerSignVerbatimRequest**](PkiIssuerSignVerbatimRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkiissuerissuerrefsignverbatimrole"></a>
# **PostPkiIssuerIssuerRefSignVerbatimRole**
> void PostPkiIssuerIssuerRefSignVerbatimRole (string issuerRef, string role, PkiIssuerSignVerbatimRequest pkiIssuerSignVerbatimRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiIssuerIssuerRefSignVerbatimRoleExample
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
            var pkiIssuerSignVerbatimRequest = new PkiIssuerSignVerbatimRequest(); // PkiIssuerSignVerbatimRequest |  (optional) 

            try
            {
                apiInstance.PostPkiIssuerIssuerRefSignVerbatimRole(issuerRef, role, pkiIssuerSignVerbatimRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiIssuerIssuerRefSignVerbatimRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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
 **pkiIssuerSignVerbatimRequest** | [**PkiIssuerSignVerbatimRequest**](PkiIssuerSignVerbatimRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkiissuerrefderpem"></a>
# **PostPkiIssuerRefDerPem**
> void PostPkiIssuerRefDerPem (string issuerRef, PkiDerPemRequest pkiDerPemRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiIssuerRefDerPemExample
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
            var pkiDerPemRequest = new PkiDerPemRequest(); // PkiDerPemRequest |  (optional) 

            try
            {
                apiInstance.PostPkiIssuerRefDerPem(issuerRef, pkiDerPemRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiIssuerRefDerPem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuerRef** | **string**| Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. | [default to &quot;default&quot;]
 **pkiDerPemRequest** | [**PkiDerPemRequest**](PkiDerPemRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkiissuersgenerateintermediateexported"></a>
# **PostPkiIssuersGenerateIntermediateExported**
> void PostPkiIssuersGenerateIntermediateExported (string exported, PkiIssuersGenerateIntermediateRequest pkiIssuersGenerateIntermediateRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiIssuersGenerateIntermediateExportedExample
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
            var pkiIssuersGenerateIntermediateRequest = new PkiIssuersGenerateIntermediateRequest(); // PkiIssuersGenerateIntermediateRequest |  (optional) 

            try
            {
                apiInstance.PostPkiIssuersGenerateIntermediateExported(exported, pkiIssuersGenerateIntermediateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiIssuersGenerateIntermediateExported: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exported** | **string**| Must be \&quot;internal\&quot;, \&quot;exported\&quot; or \&quot;kms\&quot;. If set to \&quot;exported\&quot;, the generated private key will be returned. This is your *only* chance to retrieve the private key! | 
 **pkiIssuersGenerateIntermediateRequest** | [**PkiIssuersGenerateIntermediateRequest**](PkiIssuersGenerateIntermediateRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkiissuersgeneraterootexported"></a>
# **PostPkiIssuersGenerateRootExported**
> void PostPkiIssuersGenerateRootExported (string exported, PkiIssuersGenerateRootRequest pkiIssuersGenerateRootRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiIssuersGenerateRootExportedExample
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
            var pkiIssuersGenerateRootRequest = new PkiIssuersGenerateRootRequest(); // PkiIssuersGenerateRootRequest |  (optional) 

            try
            {
                apiInstance.PostPkiIssuersGenerateRootExported(exported, pkiIssuersGenerateRootRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiIssuersGenerateRootExported: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exported** | **string**| Must be \&quot;internal\&quot;, \&quot;exported\&quot; or \&quot;kms\&quot;. If set to \&quot;exported\&quot;, the generated private key will be returned. This is your *only* chance to retrieve the private key! | 
 **pkiIssuersGenerateRootRequest** | [**PkiIssuersGenerateRootRequest**](PkiIssuersGenerateRootRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkijson"></a>
# **PostPkiJson**
> void PostPkiJson (PkiJsonRequest pkiJsonRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiJsonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiJsonRequest = new PkiJsonRequest(); // PkiJsonRequest |  (optional) 

            try
            {
                apiInstance.PostPkiJson(pkiJsonRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiJson: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiJsonRequest** | [**PkiJsonRequest**](PkiJsonRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkikeykeyref"></a>
# **PostPkiKeyKeyRef**
> void PostPkiKeyKeyRef (string keyRef, PkiKeyRequest pkiKeyRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiKeyKeyRefExample
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
            var pkiKeyRequest = new PkiKeyRequest(); // PkiKeyRequest |  (optional) 

            try
            {
                apiInstance.PostPkiKeyKeyRef(keyRef, pkiKeyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiKeyKeyRef: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyRef** | **string**| Reference to key; either \&quot;default\&quot; for the configured default key, an identifier of a key, or the name assigned to the key. | [default to &quot;default&quot;]
 **pkiKeyRequest** | [**PkiKeyRequest**](PkiKeyRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkikeysimport"></a>
# **PostPkiKeysImport**
> void PostPkiKeysImport (PkiKeysImportRequest pkiKeysImportRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiKeysImportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiKeysImportRequest = new PkiKeysImportRequest(); // PkiKeysImportRequest |  (optional) 

            try
            {
                apiInstance.PostPkiKeysImport(pkiKeysImportRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiKeysImport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiKeysImportRequest** | [**PkiKeysImportRequest**](PkiKeysImportRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkikms"></a>
# **PostPkiKms**
> void PostPkiKms (PkiKmsRequest pkiKmsRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiKmsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiKmsRequest = new PkiKmsRequest(); // PkiKmsRequest |  (optional) 

            try
            {
                apiInstance.PostPkiKms(pkiKmsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiKms: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiKmsRequest** | [**PkiKmsRequest**](PkiKmsRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkirevoke"></a>
# **PostPkiRevoke**
> void PostPkiRevoke (PkiRevokeRequest pkiRevokeRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiRevokeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiRevokeRequest = new PkiRevokeRequest(); // PkiRevokeRequest |  (optional) 

            try
            {
                apiInstance.PostPkiRevoke(pkiRevokeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiRevoke: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiRevokeRequest** | [**PkiRevokeRequest**](PkiRevokeRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkirolesname"></a>
# **PostPkiRolesName**
> void PostPkiRolesName (string name, PkiRolesRequest pkiRolesRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiRolesNameExample
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
            var pkiRolesRequest = new PkiRolesRequest(); // PkiRolesRequest |  (optional) 

            try
            {
                apiInstance.PostPkiRolesName(name, pkiRolesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **pkiRolesRequest** | [**PkiRolesRequest**](PkiRolesRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkirootgenerateexported"></a>
# **PostPkiRootGenerateExported**
> void PostPkiRootGenerateExported (string exported, PkiRootGenerateRequest pkiRootGenerateRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiRootGenerateExportedExample
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
            var pkiRootGenerateRequest = new PkiRootGenerateRequest(); // PkiRootGenerateRequest |  (optional) 

            try
            {
                apiInstance.PostPkiRootGenerateExported(exported, pkiRootGenerateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiRootGenerateExported: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exported** | **string**| Must be \&quot;internal\&quot;, \&quot;exported\&quot; or \&quot;kms\&quot;. If set to \&quot;exported\&quot;, the generated private key will be returned. This is your *only* chance to retrieve the private key! | 
 **pkiRootGenerateRequest** | [**PkiRootGenerateRequest**](PkiRootGenerateRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkirootreplace"></a>
# **PostPkiRootReplace**
> void PostPkiRootReplace (PkiRootReplaceRequest pkiRootReplaceRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiRootReplaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiRootReplaceRequest = new PkiRootReplaceRequest(); // PkiRootReplaceRequest |  (optional) 

            try
            {
                apiInstance.PostPkiRootReplace(pkiRootReplaceRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiRootReplace: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiRootReplaceRequest** | [**PkiRootReplaceRequest**](PkiRootReplaceRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkirootrotateexported"></a>
# **PostPkiRootRotateExported**
> void PostPkiRootRotateExported (string exported, PkiRootRotateRequest pkiRootRotateRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiRootRotateExportedExample
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
            var pkiRootRotateRequest = new PkiRootRotateRequest(); // PkiRootRotateRequest |  (optional) 

            try
            {
                apiInstance.PostPkiRootRotateExported(exported, pkiRootRotateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiRootRotateExported: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exported** | **string**| Must be \&quot;internal\&quot;, \&quot;exported\&quot; or \&quot;kms\&quot;. If set to \&quot;exported\&quot;, the generated private key will be returned. This is your *only* chance to retrieve the private key! | 
 **pkiRootRotateRequest** | [**PkiRootRotateRequest**](PkiRootRotateRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkirootsignintermediate"></a>
# **PostPkiRootSignIntermediate**
> void PostPkiRootSignIntermediate (PkiRootSignIntermediateRequest pkiRootSignIntermediateRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiRootSignIntermediateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiRootSignIntermediateRequest = new PkiRootSignIntermediateRequest(); // PkiRootSignIntermediateRequest |  (optional) 

            try
            {
                apiInstance.PostPkiRootSignIntermediate(pkiRootSignIntermediateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiRootSignIntermediate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiRootSignIntermediateRequest** | [**PkiRootSignIntermediateRequest**](PkiRootSignIntermediateRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkirootsignselfissued"></a>
# **PostPkiRootSignSelfIssued**
> void PostPkiRootSignSelfIssued (PkiRootSignSelfIssuedRequest pkiRootSignSelfIssuedRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiRootSignSelfIssuedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiRootSignSelfIssuedRequest = new PkiRootSignSelfIssuedRequest(); // PkiRootSignSelfIssuedRequest |  (optional) 

            try
            {
                apiInstance.PostPkiRootSignSelfIssued(pkiRootSignSelfIssuedRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiRootSignSelfIssued: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiRootSignSelfIssuedRequest** | [**PkiRootSignSelfIssuedRequest**](PkiRootSignSelfIssuedRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkisignrole"></a>
# **PostPkiSignRole**
> void PostPkiSignRole (string role, PkiSignRequest pkiSignRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiSignRoleExample
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
            var pkiSignRequest = new PkiSignRequest(); // PkiSignRequest |  (optional) 

            try
            {
                apiInstance.PostPkiSignRole(role, pkiSignRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiSignRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The desired role with configuration for this request | 
 **pkiSignRequest** | [**PkiSignRequest**](PkiSignRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkisignverbatim"></a>
# **PostPkiSignVerbatim**
> void PostPkiSignVerbatim (PkiSignVerbatimRequest pkiSignVerbatimRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiSignVerbatimExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiSignVerbatimRequest = new PkiSignVerbatimRequest(); // PkiSignVerbatimRequest |  (optional) 

            try
            {
                apiInstance.PostPkiSignVerbatim(pkiSignVerbatimRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiSignVerbatim: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiSignVerbatimRequest** | [**PkiSignVerbatimRequest**](PkiSignVerbatimRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkisignverbatimrole"></a>
# **PostPkiSignVerbatimRole**
> void PostPkiSignVerbatimRole (string role, PkiSignVerbatimRequest pkiSignVerbatimRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiSignVerbatimRoleExample
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
            var pkiSignVerbatimRequest = new PkiSignVerbatimRequest(); // PkiSignVerbatimRequest |  (optional) 

            try
            {
                apiInstance.PostPkiSignVerbatimRole(role, pkiSignVerbatimRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiSignVerbatimRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The desired role with configuration for this request | 
 **pkiSignVerbatimRequest** | [**PkiSignVerbatimRequest**](PkiSignVerbatimRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpkitidy"></a>
# **PostPkiTidy**
> void PostPkiTidy (PkiTidyRequest pkiTidyRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostPkiTidyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiTidyRequest = new PkiTidyRequest(); // PkiTidyRequest |  (optional) 

            try
            {
                apiInstance.PostPkiTidy(pkiTidyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiTidy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiTidyRequest** | [**PkiTidyRequest**](PkiTidyRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postrabbitmqconfigconnection"></a>
# **PostRabbitmqConfigConnection**
> void PostRabbitmqConfigConnection (RabbitmqConfigConnectionRequest rabbitmqConfigConnectionRequest = null)

Configure the connection URI, username, and password to talk to RabbitMQ management HTTP API.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostRabbitmqConfigConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var rabbitmqConfigConnectionRequest = new RabbitmqConfigConnectionRequest(); // RabbitmqConfigConnectionRequest |  (optional) 

            try
            {
                // Configure the connection URI, username, and password to talk to RabbitMQ management HTTP API.
                apiInstance.PostRabbitmqConfigConnection(rabbitmqConfigConnectionRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostRabbitmqConfigConnection: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rabbitmqConfigConnectionRequest** | [**RabbitmqConfigConnectionRequest**](RabbitmqConfigConnectionRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postrabbitmqconfiglease"></a>
# **PostRabbitmqConfigLease**
> void PostRabbitmqConfigLease (RabbitmqConfigLeaseRequest rabbitmqConfigLeaseRequest = null)

Configure the lease parameters for generated credentials

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostRabbitmqConfigLeaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var rabbitmqConfigLeaseRequest = new RabbitmqConfigLeaseRequest(); // RabbitmqConfigLeaseRequest |  (optional) 

            try
            {
                // Configure the lease parameters for generated credentials
                apiInstance.PostRabbitmqConfigLease(rabbitmqConfigLeaseRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostRabbitmqConfigLease: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rabbitmqConfigLeaseRequest** | [**RabbitmqConfigLeaseRequest**](RabbitmqConfigLeaseRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postrabbitmqrolesname"></a>
# **PostRabbitmqRolesName**
> void PostRabbitmqRolesName (string name, RabbitmqRolesRequest rabbitmqRolesRequest = null)

Manage the roles that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostRabbitmqRolesNameExample
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
            var rabbitmqRolesRequest = new RabbitmqRolesRequest(); // RabbitmqRolesRequest |  (optional) 

            try
            {
                // Manage the roles that can be created with this backend.
                apiInstance.PostRabbitmqRolesName(name, rabbitmqRolesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostRabbitmqRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **rabbitmqRolesRequest** | [**RabbitmqRolesRequest**](RabbitmqRolesRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsecretconfig"></a>
# **PostSecretConfig**
> void PostSecretConfig (KvConfigRequest kvConfigRequest = null)

Configure backend level settings that are applied to every key in the key-value store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSecretConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var kvConfigRequest = new KvConfigRequest(); // KvConfigRequest |  (optional) 

            try
            {
                // Configure backend level settings that are applied to every key in the key-value store.
                apiInstance.PostSecretConfig(kvConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostSecretConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kvConfigRequest** | [**KvConfigRequest**](KvConfigRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsecretdatapath"></a>
# **PostSecretDataPath**
> void PostSecretDataPath (string path, KvDataRequest kvDataRequest = null)

Write, Patch, Read, and Delete data in the Key-Value Store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSecretDataPathExample
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
            var kvDataRequest = new KvDataRequest(); // KvDataRequest |  (optional) 

            try
            {
                // Write, Patch, Read, and Delete data in the Key-Value Store.
                apiInstance.PostSecretDataPath(path, kvDataRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostSecretDataPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 
 **kvDataRequest** | [**KvDataRequest**](KvDataRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsecretdeletepath"></a>
# **PostSecretDeletePath**
> void PostSecretDeletePath (string path, KvDeleteRequest kvDeleteRequest = null)

Marks one or more versions as deleted in the KV store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSecretDeletePathExample
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
            var kvDeleteRequest = new KvDeleteRequest(); // KvDeleteRequest |  (optional) 

            try
            {
                // Marks one or more versions as deleted in the KV store.
                apiInstance.PostSecretDeletePath(path, kvDeleteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostSecretDeletePath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 
 **kvDeleteRequest** | [**KvDeleteRequest**](KvDeleteRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsecretdestroypath"></a>
# **PostSecretDestroyPath**
> void PostSecretDestroyPath (string path, KvDestroyRequest kvDestroyRequest = null)

Permanently removes one or more versions in the KV store

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSecretDestroyPathExample
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
            var kvDestroyRequest = new KvDestroyRequest(); // KvDestroyRequest |  (optional) 

            try
            {
                // Permanently removes one or more versions in the KV store
                apiInstance.PostSecretDestroyPath(path, kvDestroyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostSecretDestroyPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 
 **kvDestroyRequest** | [**KvDestroyRequest**](KvDestroyRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsecretmetadatapath"></a>
# **PostSecretMetadataPath**
> void PostSecretMetadataPath (string path, KvMetadataRequest kvMetadataRequest = null)

Configures settings for the KV store

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSecretMetadataPathExample
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
            var kvMetadataRequest = new KvMetadataRequest(); // KvMetadataRequest |  (optional) 

            try
            {
                // Configures settings for the KV store
                apiInstance.PostSecretMetadataPath(path, kvMetadataRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostSecretMetadataPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 
 **kvMetadataRequest** | [**KvMetadataRequest**](KvMetadataRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsecretundeletepath"></a>
# **PostSecretUndeletePath**
> void PostSecretUndeletePath (string path, KvUndeleteRequest kvUndeleteRequest = null)

Undeletes one or more versions from the KV store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSecretUndeletePathExample
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
            var kvUndeleteRequest = new KvUndeleteRequest(); // KvUndeleteRequest |  (optional) 

            try
            {
                // Undeletes one or more versions from the KV store.
                apiInstance.PostSecretUndeletePath(path, kvUndeleteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostSecretUndeletePath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Location of the secret. | 
 **kvUndeleteRequest** | [**KvUndeleteRequest**](KvUndeleteRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsshconfigca"></a>
# **PostSshConfigCa**
> void PostSshConfigCa (SshConfigCaRequest sshConfigCaRequest = null)

Set the SSH private key used for signing certificates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSshConfigCaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var sshConfigCaRequest = new SshConfigCaRequest(); // SshConfigCaRequest |  (optional) 

            try
            {
                // Set the SSH private key used for signing certificates.
                apiInstance.PostSshConfigCa(sshConfigCaRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostSshConfigCa: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sshConfigCaRequest** | [**SshConfigCaRequest**](SshConfigCaRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsshconfigzeroaddress"></a>
# **PostSshConfigZeroaddress**
> void PostSshConfigZeroaddress (SshConfigZeroaddressRequest sshConfigZeroaddressRequest = null)

Assign zero address as default CIDR block for select roles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSshConfigZeroaddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var sshConfigZeroaddressRequest = new SshConfigZeroaddressRequest(); // SshConfigZeroaddressRequest |  (optional) 

            try
            {
                // Assign zero address as default CIDR block for select roles.
                apiInstance.PostSshConfigZeroaddress(sshConfigZeroaddressRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostSshConfigZeroaddress: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sshConfigZeroaddressRequest** | [**SshConfigZeroaddressRequest**](SshConfigZeroaddressRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsshcredsrole"></a>
# **PostSshCredsRole**
> void PostSshCredsRole (string role, SshCredsRequest sshCredsRequest = null)

Creates a credential for establishing SSH connection with the remote host.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSshCredsRoleExample
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
            var sshCredsRequest = new SshCredsRequest(); // SshCredsRequest |  (optional) 

            try
            {
                // Creates a credential for establishing SSH connection with the remote host.
                apiInstance.PostSshCredsRole(role, sshCredsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostSshCredsRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| [Required] Name of the role | 
 **sshCredsRequest** | [**SshCredsRequest**](SshCredsRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsshkeyskeyname"></a>
# **PostSshKeysKeyName**
> void PostSshKeysKeyName (string keyName, SshKeysRequest sshKeysRequest = null)

Register a shared private key with Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSshKeysKeyNameExample
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
            var sshKeysRequest = new SshKeysRequest(); // SshKeysRequest |  (optional) 

            try
            {
                // Register a shared private key with Vault.
                apiInstance.PostSshKeysKeyName(keyName, sshKeysRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostSshKeysKeyName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyName** | **string**| [Required] Name of the key | 
 **sshKeysRequest** | [**SshKeysRequest**](SshKeysRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsshlookup"></a>
# **PostSshLookup**
> void PostSshLookup (SshLookupRequest sshLookupRequest = null)

List all the roles associated with the given IP address.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSshLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var sshLookupRequest = new SshLookupRequest(); // SshLookupRequest |  (optional) 

            try
            {
                // List all the roles associated with the given IP address.
                apiInstance.PostSshLookup(sshLookupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostSshLookup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sshLookupRequest** | [**SshLookupRequest**](SshLookupRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsshrolesrole"></a>
# **PostSshRolesRole**
> void PostSshRolesRole (string role, SshRolesRequest sshRolesRequest = null)

Manage the 'roles' that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSshRolesRoleExample
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
            var sshRolesRequest = new SshRolesRequest(); // SshRolesRequest |  (optional) 

            try
            {
                // Manage the 'roles' that can be created with this backend.
                apiInstance.PostSshRolesRole(role, sshRolesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostSshRolesRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| [Required for all types] Name of the role being created. | 
 **sshRolesRequest** | [**SshRolesRequest**](SshRolesRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsshsignrole"></a>
# **PostSshSignRole**
> void PostSshSignRole (string role, SshSignRequest sshSignRequest = null)

Request signing an SSH key using a certain role with the provided details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSshSignRoleExample
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
            var sshSignRequest = new SshSignRequest(); // SshSignRequest |  (optional) 

            try
            {
                // Request signing an SSH key using a certain role with the provided details.
                apiInstance.PostSshSignRole(role, sshSignRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostSshSignRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The desired role with configuration for this request. | 
 **sshSignRequest** | [**SshSignRequest**](SshSignRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsshverify"></a>
# **PostSshVerify**
> void PostSshVerify (SshVerifyRequest sshVerifyRequest = null)

Validate the OTP provided by Vault SSH Agent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSshVerifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var sshVerifyRequest = new SshVerifyRequest(); // SshVerifyRequest |  (optional) 

            try
            {
                // Validate the OTP provided by Vault SSH Agent.
                apiInstance.PostSshVerify(sshVerifyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostSshVerify: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sshVerifyRequest** | [**SshVerifyRequest**](SshVerifyRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postterraformconfig"></a>
# **PostTerraformConfig**
> void PostTerraformConfig (TerraformConfigRequest terraformConfigRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTerraformConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var terraformConfigRequest = new TerraformConfigRequest(); // TerraformConfigRequest |  (optional) 

            try
            {
                apiInstance.PostTerraformConfig(terraformConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTerraformConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **terraformConfigRequest** | [**TerraformConfigRequest**](TerraformConfigRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postterraformcredsname"></a>
# **PostTerraformCredsName**
> void PostTerraformCredsName (string name)

Generate a Terraform Cloud or Enterprise API token from a specific Vault role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTerraformCredsNameExample
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

            try
            {
                // Generate a Terraform Cloud or Enterprise API token from a specific Vault role.
                apiInstance.PostTerraformCredsName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTerraformCredsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postterraformrolename"></a>
# **PostTerraformRoleName**
> void PostTerraformRoleName (string name, TerraformRoleRequest terraformRoleRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTerraformRoleNameExample
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
            var terraformRoleRequest = new TerraformRoleRequest(); // TerraformRoleRequest |  (optional) 

            try
            {
                apiInstance.PostTerraformRoleName(name, terraformRoleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTerraformRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **terraformRoleRequest** | [**TerraformRoleRequest**](TerraformRoleRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postterraformrotaterolename"></a>
# **PostTerraformRotateRoleName**
> void PostTerraformRotateRoleName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTerraformRotateRoleNameExample
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

            try
            {
                apiInstance.PostTerraformRotateRoleName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTerraformRotateRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the team or organization role | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttotpcodename"></a>
# **PostTotpCodeName**
> void PostTotpCodeName (string name, TotpCodeRequest totpCodeRequest = null)

Request time-based one-time use password or validate a password for a certain key .

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTotpCodeNameExample
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
            var totpCodeRequest = new TotpCodeRequest(); // TotpCodeRequest |  (optional) 

            try
            {
                // Request time-based one-time use password or validate a password for a certain key .
                apiInstance.PostTotpCodeName(name, totpCodeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTotpCodeName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the key. | 
 **totpCodeRequest** | [**TotpCodeRequest**](TotpCodeRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttotpkeysname"></a>
# **PostTotpKeysName**
> void PostTotpKeysName (string name, TotpKeysRequest totpKeysRequest = null)

Manage the keys that can be created with this backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTotpKeysNameExample
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
            var totpKeysRequest = new TotpKeysRequest(); // TotpKeysRequest |  (optional) 

            try
            {
                // Manage the keys that can be created with this backend.
                apiInstance.PostTotpKeysName(name, totpKeysRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTotpKeysName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the key. | 
 **totpKeysRequest** | [**TotpKeysRequest**](TotpKeysRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransitcacheconfig"></a>
# **PostTransitCacheConfig**
> void PostTransitCacheConfig (TransitCacheConfigRequest transitCacheConfigRequest = null)

Configures a new cache of the specified size

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTransitCacheConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var transitCacheConfigRequest = new TransitCacheConfigRequest(); // TransitCacheConfigRequest |  (optional) 

            try
            {
                // Configures a new cache of the specified size
                apiInstance.PostTransitCacheConfig(transitCacheConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTransitCacheConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transitCacheConfigRequest** | [**TransitCacheConfigRequest**](TransitCacheConfigRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransitdatakeyplaintextname"></a>
# **PostTransitDatakeyPlaintextName**
> void PostTransitDatakeyPlaintextName (string name, string plaintext, TransitDatakeyRequest transitDatakeyRequest = null)

Generate a data key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTransitDatakeyPlaintextNameExample
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
            var transitDatakeyRequest = new TransitDatakeyRequest(); // TransitDatakeyRequest |  (optional) 

            try
            {
                // Generate a data key
                apiInstance.PostTransitDatakeyPlaintextName(name, plaintext, transitDatakeyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTransitDatakeyPlaintextName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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
 **transitDatakeyRequest** | [**TransitDatakeyRequest**](TransitDatakeyRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransitdecryptname"></a>
# **PostTransitDecryptName**
> void PostTransitDecryptName (string name, TransitDecryptRequest transitDecryptRequest = null)

Decrypt a ciphertext value using a named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTransitDecryptNameExample
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
            var transitDecryptRequest = new TransitDecryptRequest(); // TransitDecryptRequest |  (optional) 

            try
            {
                // Decrypt a ciphertext value using a named key
                apiInstance.PostTransitDecryptName(name, transitDecryptRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTransitDecryptName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the policy | 
 **transitDecryptRequest** | [**TransitDecryptRequest**](TransitDecryptRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransitencryptname"></a>
# **PostTransitEncryptName**
> void PostTransitEncryptName (string name, TransitEncryptRequest transitEncryptRequest = null)

Encrypt a plaintext value or a batch of plaintext blocks using a named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTransitEncryptNameExample
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
            var transitEncryptRequest = new TransitEncryptRequest(); // TransitEncryptRequest |  (optional) 

            try
            {
                // Encrypt a plaintext value or a batch of plaintext blocks using a named key
                apiInstance.PostTransitEncryptName(name, transitEncryptRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTransitEncryptName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the policy | 
 **transitEncryptRequest** | [**TransitEncryptRequest**](TransitEncryptRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransithash"></a>
# **PostTransitHash**
> void PostTransitHash (TransitHashRequest transitHashRequest = null)

Generate a hash sum for input data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTransitHashExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var transitHashRequest = new TransitHashRequest(); // TransitHashRequest |  (optional) 

            try
            {
                // Generate a hash sum for input data
                apiInstance.PostTransitHash(transitHashRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTransitHash: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transitHashRequest** | [**TransitHashRequest**](TransitHashRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransithashurlalgorithm"></a>
# **PostTransitHashUrlalgorithm**
> void PostTransitHashUrlalgorithm (string urlalgorithm, TransitHashRequest transitHashRequest = null)

Generate a hash sum for input data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTransitHashUrlalgorithmExample
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
            var transitHashRequest = new TransitHashRequest(); // TransitHashRequest |  (optional) 

            try
            {
                // Generate a hash sum for input data
                apiInstance.PostTransitHashUrlalgorithm(urlalgorithm, transitHashRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTransitHashUrlalgorithm: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **urlalgorithm** | **string**| Algorithm to use (POST URL parameter) | 
 **transitHashRequest** | [**TransitHashRequest**](TransitHashRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransithmacname"></a>
# **PostTransitHmacName**
> void PostTransitHmacName (string name, TransitHmacRequest transitHmacRequest = null)

Generate an HMAC for input data using the named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTransitHmacNameExample
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
            var transitHmacRequest = new TransitHmacRequest(); // TransitHmacRequest |  (optional) 

            try
            {
                // Generate an HMAC for input data using the named key
                apiInstance.PostTransitHmacName(name, transitHmacRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTransitHmacName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The key to use for the HMAC function | 
 **transitHmacRequest** | [**TransitHmacRequest**](TransitHmacRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransithmacnameurlalgorithm"></a>
# **PostTransitHmacNameUrlalgorithm**
> void PostTransitHmacNameUrlalgorithm (string name, string urlalgorithm, TransitHmacRequest transitHmacRequest = null)

Generate an HMAC for input data using the named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTransitHmacNameUrlalgorithmExample
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
            var transitHmacRequest = new TransitHmacRequest(); // TransitHmacRequest |  (optional) 

            try
            {
                // Generate an HMAC for input data using the named key
                apiInstance.PostTransitHmacNameUrlalgorithm(name, urlalgorithm, transitHmacRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTransitHmacNameUrlalgorithm: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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
 **transitHmacRequest** | [**TransitHmacRequest**](TransitHmacRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransitkeysname"></a>
# **PostTransitKeysName**
> void PostTransitKeysName (string name, TransitKeysRequest transitKeysRequest = null)

Managed named encryption keys

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTransitKeysNameExample
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
            var transitKeysRequest = new TransitKeysRequest(); // TransitKeysRequest |  (optional) 

            try
            {
                // Managed named encryption keys
                apiInstance.PostTransitKeysName(name, transitKeysRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTransitKeysName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **transitKeysRequest** | [**TransitKeysRequest**](TransitKeysRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransitkeysnameconfig"></a>
# **PostTransitKeysNameConfig**
> void PostTransitKeysNameConfig (string name, TransitKeysConfigRequest transitKeysConfigRequest = null)

Configure a named encryption key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTransitKeysNameConfigExample
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
            var transitKeysConfigRequest = new TransitKeysConfigRequest(); // TransitKeysConfigRequest |  (optional) 

            try
            {
                // Configure a named encryption key
                apiInstance.PostTransitKeysNameConfig(name, transitKeysConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTransitKeysNameConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **transitKeysConfigRequest** | [**TransitKeysConfigRequest**](TransitKeysConfigRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransitkeysnameimport"></a>
# **PostTransitKeysNameImport**
> void PostTransitKeysNameImport (string name, TransitKeysImportRequest transitKeysImportRequest = null)

Imports an externally-generated key into a new transit key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTransitKeysNameImportExample
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
            var transitKeysImportRequest = new TransitKeysImportRequest(); // TransitKeysImportRequest |  (optional) 

            try
            {
                // Imports an externally-generated key into a new transit key
                apiInstance.PostTransitKeysNameImport(name, transitKeysImportRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTransitKeysNameImport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the key | 
 **transitKeysImportRequest** | [**TransitKeysImportRequest**](TransitKeysImportRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransitkeysnameimportversion"></a>
# **PostTransitKeysNameImportVersion**
> void PostTransitKeysNameImportVersion (string name, TransitKeysImportVersionRequest transitKeysImportVersionRequest = null)

Imports an externally-generated key into an existing imported key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTransitKeysNameImportVersionExample
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
            var transitKeysImportVersionRequest = new TransitKeysImportVersionRequest(); // TransitKeysImportVersionRequest |  (optional) 

            try
            {
                // Imports an externally-generated key into an existing imported key
                apiInstance.PostTransitKeysNameImportVersion(name, transitKeysImportVersionRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTransitKeysNameImportVersion: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the key | 
 **transitKeysImportVersionRequest** | [**TransitKeysImportVersionRequest**](TransitKeysImportVersionRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransitkeysnamerotate"></a>
# **PostTransitKeysNameRotate**
> void PostTransitKeysNameRotate (string name)

Rotate named encryption key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTransitKeysNameRotateExample
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

            try
            {
                // Rotate named encryption key
                apiInstance.PostTransitKeysNameRotate(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTransitKeysNameRotate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="posttransitkeysnametrim"></a>
# **PostTransitKeysNameTrim**
> void PostTransitKeysNameTrim (string name, TransitKeysTrimRequest transitKeysTrimRequest = null)

Trim key versions of a named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTransitKeysNameTrimExample
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
            var transitKeysTrimRequest = new TransitKeysTrimRequest(); // TransitKeysTrimRequest |  (optional) 

            try
            {
                // Trim key versions of a named key
                apiInstance.PostTransitKeysNameTrim(name, transitKeysTrimRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTransitKeysNameTrim: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **transitKeysTrimRequest** | [**TransitKeysTrimRequest**](TransitKeysTrimRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransitrandom"></a>
# **PostTransitRandom**
> void PostTransitRandom (TransitRandomRequest transitRandomRequest = null)

Generate random bytes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTransitRandomExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var transitRandomRequest = new TransitRandomRequest(); // TransitRandomRequest |  (optional) 

            try
            {
                // Generate random bytes
                apiInstance.PostTransitRandom(transitRandomRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTransitRandom: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transitRandomRequest** | [**TransitRandomRequest**](TransitRandomRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransitrandomsource"></a>
# **PostTransitRandomSource**
> void PostTransitRandomSource (string source, TransitRandomRequest transitRandomRequest = null)

Generate random bytes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTransitRandomSourceExample
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
            var transitRandomRequest = new TransitRandomRequest(); // TransitRandomRequest |  (optional) 

            try
            {
                // Generate random bytes
                apiInstance.PostTransitRandomSource(source, transitRandomRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTransitRandomSource: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **source** | **string**| Which system to source random data from, ether \&quot;platform\&quot;, \&quot;seal\&quot;, or \&quot;all\&quot;. | [default to &quot;platform&quot;]
 **transitRandomRequest** | [**TransitRandomRequest**](TransitRandomRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransitrandomsourceurlbytes"></a>
# **PostTransitRandomSourceUrlbytes**
> void PostTransitRandomSourceUrlbytes (string source, string urlbytes, TransitRandomRequest transitRandomRequest = null)

Generate random bytes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTransitRandomSourceUrlbytesExample
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
            var transitRandomRequest = new TransitRandomRequest(); // TransitRandomRequest |  (optional) 

            try
            {
                // Generate random bytes
                apiInstance.PostTransitRandomSourceUrlbytes(source, urlbytes, transitRandomRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTransitRandomSourceUrlbytes: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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
 **transitRandomRequest** | [**TransitRandomRequest**](TransitRandomRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransitrandomurlbytes"></a>
# **PostTransitRandomUrlbytes**
> void PostTransitRandomUrlbytes (string urlbytes, TransitRandomRequest transitRandomRequest = null)

Generate random bytes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTransitRandomUrlbytesExample
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
            var transitRandomRequest = new TransitRandomRequest(); // TransitRandomRequest |  (optional) 

            try
            {
                // Generate random bytes
                apiInstance.PostTransitRandomUrlbytes(urlbytes, transitRandomRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTransitRandomUrlbytes: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **urlbytes** | **string**| The number of bytes to generate (POST URL parameter) | 
 **transitRandomRequest** | [**TransitRandomRequest**](TransitRandomRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransitrestore"></a>
# **PostTransitRestore**
> void PostTransitRestore (TransitRestoreRequest transitRestoreRequest = null)

Restore the named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTransitRestoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var transitRestoreRequest = new TransitRestoreRequest(); // TransitRestoreRequest |  (optional) 

            try
            {
                // Restore the named key
                apiInstance.PostTransitRestore(transitRestoreRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTransitRestore: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transitRestoreRequest** | [**TransitRestoreRequest**](TransitRestoreRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransitrestorename"></a>
# **PostTransitRestoreName**
> void PostTransitRestoreName (string name, TransitRestoreRequest transitRestoreRequest = null)

Restore the named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTransitRestoreNameExample
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
            var transitRestoreRequest = new TransitRestoreRequest(); // TransitRestoreRequest |  (optional) 

            try
            {
                // Restore the named key
                apiInstance.PostTransitRestoreName(name, transitRestoreRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTransitRestoreName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| If set, this will be the name of the restored key. | 
 **transitRestoreRequest** | [**TransitRestoreRequest**](TransitRestoreRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransitrewrapname"></a>
# **PostTransitRewrapName**
> void PostTransitRewrapName (string name, TransitRewrapRequest transitRewrapRequest = null)

Rewrap ciphertext

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTransitRewrapNameExample
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
            var transitRewrapRequest = new TransitRewrapRequest(); // TransitRewrapRequest |  (optional) 

            try
            {
                // Rewrap ciphertext
                apiInstance.PostTransitRewrapName(name, transitRewrapRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTransitRewrapName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **transitRewrapRequest** | [**TransitRewrapRequest**](TransitRewrapRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransitsignname"></a>
# **PostTransitSignName**
> void PostTransitSignName (string name, TransitSignRequest transitSignRequest = null)

Generate a signature for input data using the named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTransitSignNameExample
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
            var transitSignRequest = new TransitSignRequest(); // TransitSignRequest |  (optional) 

            try
            {
                // Generate a signature for input data using the named key
                apiInstance.PostTransitSignName(name, transitSignRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTransitSignName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The key to use | 
 **transitSignRequest** | [**TransitSignRequest**](TransitSignRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransitsignnameurlalgorithm"></a>
# **PostTransitSignNameUrlalgorithm**
> void PostTransitSignNameUrlalgorithm (string name, string urlalgorithm, TransitSignRequest transitSignRequest = null)

Generate a signature for input data using the named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTransitSignNameUrlalgorithmExample
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
            var transitSignRequest = new TransitSignRequest(); // TransitSignRequest |  (optional) 

            try
            {
                // Generate a signature for input data using the named key
                apiInstance.PostTransitSignNameUrlalgorithm(name, urlalgorithm, transitSignRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTransitSignNameUrlalgorithm: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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
 **transitSignRequest** | [**TransitSignRequest**](TransitSignRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransitverifyname"></a>
# **PostTransitVerifyName**
> void PostTransitVerifyName (string name, TransitVerifyRequest transitVerifyRequest = null)

Verify a signature or HMAC for input data created using the named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTransitVerifyNameExample
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
            var transitVerifyRequest = new TransitVerifyRequest(); // TransitVerifyRequest |  (optional) 

            try
            {
                // Verify a signature or HMAC for input data created using the named key
                apiInstance.PostTransitVerifyName(name, transitVerifyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTransitVerifyName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The key to use | 
 **transitVerifyRequest** | [**TransitVerifyRequest**](TransitVerifyRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransitverifynameurlalgorithm"></a>
# **PostTransitVerifyNameUrlalgorithm**
> void PostTransitVerifyNameUrlalgorithm (string name, string urlalgorithm, TransitVerifyRequest transitVerifyRequest = null)

Verify a signature or HMAC for input data created using the named key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostTransitVerifyNameUrlalgorithmExample
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
            var transitVerifyRequest = new TransitVerifyRequest(); // TransitVerifyRequest |  (optional) 

            try
            {
                // Verify a signature or HMAC for input data created using the named key
                apiInstance.PostTransitVerifyNameUrlalgorithm(name, urlalgorithm, transitVerifyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostTransitVerifyNameUrlalgorithm: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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
 **transitVerifyRequest** | [**TransitVerifyRequest**](TransitVerifyRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

