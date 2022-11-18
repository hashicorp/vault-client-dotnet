# Vault.Api.Secrets

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAdConfig**](Secrets.md#deleteadconfig) | **DELETE** /{ad_mount_path}/config | Configure the AD server to connect to, along with password options.
[**DeleteAdLibraryName**](Secrets.md#deleteadlibraryname) | **DELETE** /{ad_mount_path}/library/{name} | Delete a library set.
[**DeleteAdRolesName**](Secrets.md#deleteadrolesname) | **DELETE** /{ad_mount_path}/roles/{name} | Manage roles to build links between Vault and Active Directory service accounts.
[**DeleteAlicloudConfig**](Secrets.md#deletealicloudconfig) | **DELETE** /{alicloud_mount_path}/config | Configure the access key and secret to use for RAM and STS calls.
[**DeleteAlicloudRoleName**](Secrets.md#deletealicloudrolename) | **DELETE** /{alicloud_mount_path}/role/{name} | Read, write and reference policies and roles that API keys or STS credentials can be made for.
[**DeleteAwsRolesName**](Secrets.md#deleteawsrolesname) | **DELETE** /{aws_mount_path}/roles/{name} | Read, write and reference IAM policies that access keys can be made for.
[**DeleteAzureConfig**](Secrets.md#deleteazureconfig) | **DELETE** /{azure_mount_path}/config | 
[**DeleteAzureRolesName**](Secrets.md#deleteazurerolesname) | **DELETE** /{azure_mount_path}/roles/{name} | Manage the Vault roles used to generate Azure credentials.
[**DeleteConsulRolesName**](Secrets.md#deleteconsulrolesname) | **DELETE** /{consul_mount_path}/roles/{name} | 
[**DeleteCubbyholePath**](Secrets.md#deletecubbyholepath) | **DELETE** /{cubbyhole_mount_path}/{path} | Deletes the secret at the specified location.
[**DeleteGcpRolesetName**](Secrets.md#deletegcprolesetname) | **DELETE** /{gcp_mount_path}/roleset/{name} | 
[**DeleteGcpStaticAccountName**](Secrets.md#deletegcpstaticaccountname) | **DELETE** /{gcp_mount_path}/static-account/{name} | 
[**DeleteGcpkmsConfig**](Secrets.md#deletegcpkmsconfig) | **DELETE** /{gcpkms_mount_path}/config | Configure the GCP KMS secrets engine
[**DeleteGcpkmsKeysDeregisterKey**](Secrets.md#deletegcpkmskeysderegisterkey) | **DELETE** /{gcpkms_mount_path}/keys/deregister/{key} | Deregister an existing key in Vault
[**DeleteGcpkmsKeysKey**](Secrets.md#deletegcpkmskeyskey) | **DELETE** /{gcpkms_mount_path}/keys/{key} | Interact with crypto keys in Vault and Google Cloud KMS
[**DeleteGcpkmsKeysTrimKey**](Secrets.md#deletegcpkmskeystrimkey) | **DELETE** /{gcpkms_mount_path}/keys/trim/{key} | Delete old crypto key versions from Google Cloud KMS
[**DeleteKubernetesConfig**](Secrets.md#deletekubernetesconfig) | **DELETE** /{kubernetes_mount_path}/config | 
[**DeleteKubernetesRolesName**](Secrets.md#deletekubernetesrolesname) | **DELETE** /{kubernetes_mount_path}/roles/{name} | 
[**DeleteLdapConfig**](Secrets.md#deleteldapconfig) | **DELETE** /{ldap_mount_path}/config | 
[**DeleteLdapLibraryName**](Secrets.md#deleteldaplibraryname) | **DELETE** /{ldap_mount_path}/library/{name} | Delete a library set.
[**DeleteLdapRoleName**](Secrets.md#deleteldaprolename) | **DELETE** /{ldap_mount_path}/role/{name} | 
[**DeleteLdapStaticRoleName**](Secrets.md#deleteldapstaticrolename) | **DELETE** /{ldap_mount_path}/static-role/{name} | 
[**DeleteMongodbatlasRolesName**](Secrets.md#deletemongodbatlasrolesname) | **DELETE** /{mongodbatlas_mount_path}/roles/{name} | Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
[**DeleteNomadConfigAccess**](Secrets.md#deletenomadconfigaccess) | **DELETE** /{nomad_mount_path}/config/access | 
[**DeleteNomadConfigLease**](Secrets.md#deletenomadconfiglease) | **DELETE** /{nomad_mount_path}/config/lease | Configure the lease parameters for generated tokens
[**DeleteNomadRoleName**](Secrets.md#deletenomadrolename) | **DELETE** /{nomad_mount_path}/role/{name} | 
[**DeleteOpenldapConfig**](Secrets.md#deleteopenldapconfig) | **DELETE** /{openldap_mount_path}/config | 
[**DeleteOpenldapLibraryName**](Secrets.md#deleteopenldaplibraryname) | **DELETE** /{openldap_mount_path}/library/{name} | Delete a library set.
[**DeleteOpenldapRoleName**](Secrets.md#deleteopenldaprolename) | **DELETE** /{openldap_mount_path}/role/{name} | 
[**DeleteOpenldapStaticRoleName**](Secrets.md#deleteopenldapstaticrolename) | **DELETE** /{openldap_mount_path}/static-role/{name} | 
[**DeletePkiIssuerRefDerPem**](Secrets.md#deletepkiissuerrefderpem) | **DELETE** /{pki_mount_path}/{issuer_ref}/der|/pem | 
[**DeletePkiJson**](Secrets.md#deletepkijson) | **DELETE** /{pki_mount_path}//json | 
[**DeletePkiKeyKeyRef**](Secrets.md#deletepkikeykeyref) | **DELETE** /{pki_mount_path}/key/{key_ref} | 
[**DeletePkiRolesName**](Secrets.md#deletepkirolesname) | **DELETE** /{pki_mount_path}/roles/{name} | 
[**DeletePkiRoot**](Secrets.md#deletepkiroot) | **DELETE** /{pki_mount_path}/root | 
[**DeleteRabbitmqRolesName**](Secrets.md#deleterabbitmqrolesname) | **DELETE** /{rabbitmq_mount_path}/roles/{name} | Manage the roles that can be created with this backend.
[**DeleteSecretDataPath**](Secrets.md#deletesecretdatapath) | **DELETE** /{secret_mount_path}/data/{path} | Write, Patch, Read, and Delete data in the Key-Value Store.
[**DeleteSecretMetadataPath**](Secrets.md#deletesecretmetadatapath) | **DELETE** /{secret_mount_path}/metadata/{path} | Configures settings for the KV store
[**DeleteSecretPath**](Secrets.md#deletesecretpath) | **DELETE** /{secret_mount_path}/{path} | Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.
[**DeleteSshConfigCa**](Secrets.md#deletesshconfigca) | **DELETE** /{ssh_mount_path}/config/ca | Set the SSH private key used for signing certificates.
[**DeleteSshConfigZeroaddress**](Secrets.md#deletesshconfigzeroaddress) | **DELETE** /{ssh_mount_path}/config/zeroaddress | Assign zero address as default CIDR block for select roles.
[**DeleteSshKeysKeyName**](Secrets.md#deletesshkeyskeyname) | **DELETE** /{ssh_mount_path}/keys/{key_name} | Register a shared private key with Vault.
[**DeleteSshRolesRole**](Secrets.md#deletesshrolesrole) | **DELETE** /{ssh_mount_path}/roles/{role} | Manage the &#39;roles&#39; that can be created with this backend.
[**DeleteTerraformConfig**](Secrets.md#deleteterraformconfig) | **DELETE** /{terraform_mount_path}/config | 
[**DeleteTerraformRoleName**](Secrets.md#deleteterraformrolename) | **DELETE** /{terraform_mount_path}/role/{name} | 
[**DeleteTotpKeysName**](Secrets.md#deletetotpkeysname) | **DELETE** /{totp_mount_path}/keys/{name} | Manage the keys that can be created with this backend.
[**DeleteTransitKeysName**](Secrets.md#deletetransitkeysname) | **DELETE** /{transit_mount_path}/keys/{name} | Managed named encryption keys
[**GetAdConfig**](Secrets.md#getadconfig) | **GET** /{ad_mount_path}/config | Configure the AD server to connect to, along with password options.
[**GetAdCredsName**](Secrets.md#getadcredsname) | **GET** /{ad_mount_path}/creds/{name} | 
[**GetAdLibrary**](Secrets.md#getadlibrary) | **GET** /{ad_mount_path}/library | 
[**GetAdLibraryName**](Secrets.md#getadlibraryname) | **GET** /{ad_mount_path}/library/{name} | Read a library set.
[**GetAdLibraryNameStatus**](Secrets.md#getadlibrarynamestatus) | **GET** /{ad_mount_path}/library/{name}/status | Check the status of the service accounts in a library set.
[**GetAdRoles**](Secrets.md#getadroles) | **GET** /{ad_mount_path}/roles | List the name of each role currently stored.
[**GetAdRolesName**](Secrets.md#getadrolesname) | **GET** /{ad_mount_path}/roles/{name} | Manage roles to build links between Vault and Active Directory service accounts.
[**GetAdRotateRoot**](Secrets.md#getadrotateroot) | **GET** /{ad_mount_path}/rotate-root | 
[**GetAlicloudConfig**](Secrets.md#getalicloudconfig) | **GET** /{alicloud_mount_path}/config | Configure the access key and secret to use for RAM and STS calls.
[**GetAlicloudCredsName**](Secrets.md#getalicloudcredsname) | **GET** /{alicloud_mount_path}/creds/{name} | Generate an API key or STS credential using the given role&#39;s configuration.&#39;
[**GetAlicloudRole**](Secrets.md#getalicloudrole) | **GET** /{alicloud_mount_path}/role | List the existing roles in this backend.
[**GetAlicloudRoleName**](Secrets.md#getalicloudrolename) | **GET** /{alicloud_mount_path}/role/{name} | Read, write and reference policies and roles that API keys or STS credentials can be made for.
[**GetAwsConfigLease**](Secrets.md#getawsconfiglease) | **GET** /{aws_mount_path}/config/lease | Configure the default lease information for generated credentials.
[**GetAwsConfigRoot**](Secrets.md#getawsconfigroot) | **GET** /{aws_mount_path}/config/root | Configure the root credentials that are used to manage IAM.
[**GetAwsCreds**](Secrets.md#getawscreds) | **GET** /{aws_mount_path}/creds | Generate AWS credentials from a specific Vault role.
[**GetAwsRoles**](Secrets.md#getawsroles) | **GET** /{aws_mount_path}/roles | List the existing roles in this backend
[**GetAwsRolesName**](Secrets.md#getawsrolesname) | **GET** /{aws_mount_path}/roles/{name} | Read, write and reference IAM policies that access keys can be made for.
[**GetAwsStsName**](Secrets.md#getawsstsname) | **GET** /{aws_mount_path}/sts/{name} | Generate AWS credentials from a specific Vault role.
[**GetAzureConfig**](Secrets.md#getazureconfig) | **GET** /{azure_mount_path}/config | 
[**GetAzureCredsRole**](Secrets.md#getazurecredsrole) | **GET** /{azure_mount_path}/creds/{role} | 
[**GetAzureRoles**](Secrets.md#getazureroles) | **GET** /{azure_mount_path}/roles | List existing roles.
[**GetAzureRolesName**](Secrets.md#getazurerolesname) | **GET** /{azure_mount_path}/roles/{name} | Manage the Vault roles used to generate Azure credentials.
[**GetConsulConfigAccess**](Secrets.md#getconsulconfigaccess) | **GET** /{consul_mount_path}/config/access | 
[**GetConsulCredsRole**](Secrets.md#getconsulcredsrole) | **GET** /{consul_mount_path}/creds/{role} | 
[**GetConsulRoles**](Secrets.md#getconsulroles) | **GET** /{consul_mount_path}/roles | 
[**GetConsulRolesName**](Secrets.md#getconsulrolesname) | **GET** /{consul_mount_path}/roles/{name} | 
[**GetCubbyholePath**](Secrets.md#getcubbyholepath) | **GET** /{cubbyhole_mount_path}/{path} | Retrieve the secret at the specified location.
[**GetGcpConfig**](Secrets.md#getgcpconfig) | **GET** /{gcp_mount_path}/config | 
[**GetGcpKeyRoleset**](Secrets.md#getgcpkeyroleset) | **GET** /{gcp_mount_path}/key/{roleset} | 
[**GetGcpRolesetName**](Secrets.md#getgcprolesetname) | **GET** /{gcp_mount_path}/roleset/{name} | 
[**GetGcpRolesetRolesetKey**](Secrets.md#getgcprolesetrolesetkey) | **GET** /{gcp_mount_path}/roleset/{roleset}/key | 
[**GetGcpRolesetRolesetToken**](Secrets.md#getgcprolesetrolesettoken) | **GET** /{gcp_mount_path}/roleset/{roleset}/token | 
[**GetGcpRolesets**](Secrets.md#getgcprolesets) | **GET** /{gcp_mount_path}/rolesets | 
[**GetGcpStaticAccountName**](Secrets.md#getgcpstaticaccountname) | **GET** /{gcp_mount_path}/static-account/{name} | 
[**GetGcpStaticAccountNameKey**](Secrets.md#getgcpstaticaccountnamekey) | **GET** /{gcp_mount_path}/static-account/{name}/key | 
[**GetGcpStaticAccountNameToken**](Secrets.md#getgcpstaticaccountnametoken) | **GET** /{gcp_mount_path}/static-account/{name}/token | 
[**GetGcpStaticAccounts**](Secrets.md#getgcpstaticaccounts) | **GET** /{gcp_mount_path}/static-accounts | 
[**GetGcpTokenRoleset**](Secrets.md#getgcptokenroleset) | **GET** /{gcp_mount_path}/token/{roleset} | 
[**GetGcpkmsConfig**](Secrets.md#getgcpkmsconfig) | **GET** /{gcpkms_mount_path}/config | Configure the GCP KMS secrets engine
[**GetGcpkmsKeys**](Secrets.md#getgcpkmskeys) | **GET** /{gcpkms_mount_path}/keys | List named keys
[**GetGcpkmsKeysConfigKey**](Secrets.md#getgcpkmskeysconfigkey) | **GET** /{gcpkms_mount_path}/keys/config/{key} | Configure the key in Vault
[**GetGcpkmsKeysKey**](Secrets.md#getgcpkmskeyskey) | **GET** /{gcpkms_mount_path}/keys/{key} | Interact with crypto keys in Vault and Google Cloud KMS
[**GetGcpkmsPubkeyKey**](Secrets.md#getgcpkmspubkeykey) | **GET** /{gcpkms_mount_path}/pubkey/{key} | Retrieve the public key associated with the named key
[**GetKubernetesConfig**](Secrets.md#getkubernetesconfig) | **GET** /{kubernetes_mount_path}/config | 
[**GetKubernetesRoles**](Secrets.md#getkubernetesroles) | **GET** /{kubernetes_mount_path}/roles | 
[**GetKubernetesRolesName**](Secrets.md#getkubernetesrolesname) | **GET** /{kubernetes_mount_path}/roles/{name} | 
[**GetLdapConfig**](Secrets.md#getldapconfig) | **GET** /{ldap_mount_path}/config | 
[**GetLdapCredsName**](Secrets.md#getldapcredsname) | **GET** /{ldap_mount_path}/creds/{name} | 
[**GetLdapLibrary**](Secrets.md#getldaplibrary) | **GET** /{ldap_mount_path}/library | 
[**GetLdapLibraryName**](Secrets.md#getldaplibraryname) | **GET** /{ldap_mount_path}/library/{name} | Read a library set.
[**GetLdapLibraryNameStatus**](Secrets.md#getldaplibrarynamestatus) | **GET** /{ldap_mount_path}/library/{name}/status | Check the status of the service accounts in a library set.
[**GetLdapRole**](Secrets.md#getldaprole) | **GET** /{ldap_mount_path}/role | 
[**GetLdapRoleName**](Secrets.md#getldaprolename) | **GET** /{ldap_mount_path}/role/{name} | 
[**GetLdapStaticCredName**](Secrets.md#getldapstaticcredname) | **GET** /{ldap_mount_path}/static-cred/{name} | 
[**GetLdapStaticRole**](Secrets.md#getldapstaticrole) | **GET** /{ldap_mount_path}/static-role | 
[**GetLdapStaticRoleName**](Secrets.md#getldapstaticrolename) | **GET** /{ldap_mount_path}/static-role/{name} | 
[**GetMongodbatlasConfig**](Secrets.md#getmongodbatlasconfig) | **GET** /{mongodbatlas_mount_path}/config | Configure the  credentials that are used to manage Database Users.
[**GetMongodbatlasCredsName**](Secrets.md#getmongodbatlascredsname) | **GET** /{mongodbatlas_mount_path}/creds/{name} | Generate MongoDB Atlas Programmatic API from a specific Vault role.
[**GetMongodbatlasRoles**](Secrets.md#getmongodbatlasroles) | **GET** /{mongodbatlas_mount_path}/roles | List the existing roles in this backend
[**GetMongodbatlasRolesName**](Secrets.md#getmongodbatlasrolesname) | **GET** /{mongodbatlas_mount_path}/roles/{name} | Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
[**GetNomadConfigAccess**](Secrets.md#getnomadconfigaccess) | **GET** /{nomad_mount_path}/config/access | 
[**GetNomadConfigLease**](Secrets.md#getnomadconfiglease) | **GET** /{nomad_mount_path}/config/lease | Configure the lease parameters for generated tokens
[**GetNomadCredsName**](Secrets.md#getnomadcredsname) | **GET** /{nomad_mount_path}/creds/{name} | 
[**GetNomadRole**](Secrets.md#getnomadrole) | **GET** /{nomad_mount_path}/role | 
[**GetNomadRoleName**](Secrets.md#getnomadrolename) | **GET** /{nomad_mount_path}/role/{name} | 
[**GetOpenldapConfig**](Secrets.md#getopenldapconfig) | **GET** /{openldap_mount_path}/config | 
[**GetOpenldapCredsName**](Secrets.md#getopenldapcredsname) | **GET** /{openldap_mount_path}/creds/{name} | 
[**GetOpenldapLibrary**](Secrets.md#getopenldaplibrary) | **GET** /{openldap_mount_path}/library | 
[**GetOpenldapLibraryName**](Secrets.md#getopenldaplibraryname) | **GET** /{openldap_mount_path}/library/{name} | Read a library set.
[**GetOpenldapLibraryNameStatus**](Secrets.md#getopenldaplibrarynamestatus) | **GET** /{openldap_mount_path}/library/{name}/status | Check the status of the service accounts in a library set.
[**GetOpenldapRole**](Secrets.md#getopenldaprole) | **GET** /{openldap_mount_path}/role | 
[**GetOpenldapRoleName**](Secrets.md#getopenldaprolename) | **GET** /{openldap_mount_path}/role/{name} | 
[**GetOpenldapStaticCredName**](Secrets.md#getopenldapstaticcredname) | **GET** /{openldap_mount_path}/static-cred/{name} | 
[**GetOpenldapStaticRole**](Secrets.md#getopenldapstaticrole) | **GET** /{openldap_mount_path}/static-role | 
[**GetOpenldapStaticRoleName**](Secrets.md#getopenldapstaticrolename) | **GET** /{openldap_mount_path}/static-role/{name} | 
[**GetPkiCa**](Secrets.md#getpkica) | **GET** /{pki_mount_path}/ca | 
[**GetPkiCaChain**](Secrets.md#getpkicachain) | **GET** /{pki_mount_path}/ca_chain | 
[**GetPkiCaPem**](Secrets.md#getpkicapem) | **GET** /{pki_mount_path}/ca/pem | 
[**GetPkiCertCaChain**](Secrets.md#getpkicertcachain) | **GET** /{pki_mount_path}/cert/ca_chain | 
[**GetPkiCertSerial**](Secrets.md#getpkicertserial) | **GET** /{pki_mount_path}/cert/{serial} | 
[**GetPkiCertSerialRaw**](Secrets.md#getpkicertserialraw) | **GET** /{pki_mount_path}/cert/{serial}/raw | 
[**GetPkiCertSerialRawPem**](Secrets.md#getpkicertserialrawpem) | **GET** /{pki_mount_path}/cert/{serial}/raw/pem | 
[**GetPkiCerts**](Secrets.md#getpkicerts) | **GET** /{pki_mount_path}/certs | 
[**GetPkiCertsRevoked**](Secrets.md#getpkicertsrevoked) | **GET** /{pki_mount_path}/certs/revoked | 
[**GetPkiConfigAutoTidy**](Secrets.md#getpkiconfigautotidy) | **GET** /{pki_mount_path}/config/auto-tidy | 
[**GetPkiConfigCrl**](Secrets.md#getpkiconfigcrl) | **GET** /{pki_mount_path}/config/crl | 
[**GetPkiConfigIssuers**](Secrets.md#getpkiconfigissuers) | **GET** /{pki_mount_path}/config/issuers | 
[**GetPkiConfigKeys**](Secrets.md#getpkiconfigkeys) | **GET** /{pki_mount_path}/config/keys | 
[**GetPkiConfigUrls**](Secrets.md#getpkiconfigurls) | **GET** /{pki_mount_path}/config/urls | 
[**GetPkiCrl**](Secrets.md#getpkicrl) | **GET** /{pki_mount_path}/crl | 
[**GetPkiCrlRotate**](Secrets.md#getpkicrlrotate) | **GET** /{pki_mount_path}/crl/rotate | 
[**GetPkiCrlRotateDelta**](Secrets.md#getpkicrlrotatedelta) | **GET** /{pki_mount_path}/crl/rotate-delta | 
[**GetPkiDelta**](Secrets.md#getpkidelta) | **GET** /{pki_mount_path}//delta | 
[**GetPkiDeltaCrl**](Secrets.md#getpkideltacrl) | **GET** /{pki_mount_path}/delta-crl | 
[**GetPkiDeltaPem**](Secrets.md#getpkideltapem) | **GET** /{pki_mount_path}//delta/pem | 
[**GetPkiDer**](Secrets.md#getpkider) | **GET** /{pki_mount_path}//der | 
[**GetPkiIssuerRefCrlPemDerDeltaPem**](Secrets.md#getpkiissuerrefcrlpemderdeltapem) | **GET** /{pki_mount_path}/{issuer_ref}/crl/pem|/der|/delta/pem | 
[**GetPkiIssuerRefDerPem**](Secrets.md#getpkiissuerrefderpem) | **GET** /{pki_mount_path}/{issuer_ref}/der|/pem | 
[**GetPkiIssuers**](Secrets.md#getpkiissuers) | **GET** /{pki_mount_path}/issuers | 
[**GetPkiJson**](Secrets.md#getpkijson) | **GET** /{pki_mount_path}//json | 
[**GetPkiKeyKeyRef**](Secrets.md#getpkikeykeyref) | **GET** /{pki_mount_path}/key/{key_ref} | 
[**GetPkiKeys**](Secrets.md#getpkikeys) | **GET** /{pki_mount_path}/keys | 
[**GetPkiOcspReq**](Secrets.md#getpkiocspreq) | **GET** /{pki_mount_path}/ocsp/{req} | 
[**GetPkiPem**](Secrets.md#getpkipem) | **GET** /{pki_mount_path}//pem | 
[**GetPkiRoles**](Secrets.md#getpkiroles) | **GET** /{pki_mount_path}/roles | 
[**GetPkiRolesName**](Secrets.md#getpkirolesname) | **GET** /{pki_mount_path}/roles/{name} | 
[**GetPkiTidyStatus**](Secrets.md#getpkitidystatus) | **GET** /{pki_mount_path}/tidy-status | 
[**GetRabbitmqConfigLease**](Secrets.md#getrabbitmqconfiglease) | **GET** /{rabbitmq_mount_path}/config/lease | Configure the lease parameters for generated credentials
[**GetRabbitmqCredsName**](Secrets.md#getrabbitmqcredsname) | **GET** /{rabbitmq_mount_path}/creds/{name} | Request RabbitMQ credentials for a certain role.
[**GetRabbitmqRoles**](Secrets.md#getrabbitmqroles) | **GET** /{rabbitmq_mount_path}/roles | Manage the roles that can be created with this backend.
[**GetRabbitmqRolesName**](Secrets.md#getrabbitmqrolesname) | **GET** /{rabbitmq_mount_path}/roles/{name} | Manage the roles that can be created with this backend.
[**GetSecretConfig**](Secrets.md#getsecretconfig) | **GET** /{secret_mount_path}/config | Read the backend level settings.
[**GetSecretDataPath**](Secrets.md#getsecretdatapath) | **GET** /{secret_mount_path}/data/{path} | Write, Patch, Read, and Delete data in the Key-Value Store.
[**GetSecretMetadataPath**](Secrets.md#getsecretmetadatapath) | **GET** /{secret_mount_path}/metadata/{path} | Configures settings for the KV store
[**GetSecretPath**](Secrets.md#getsecretpath) | **GET** /{secret_mount_path}/{path} | Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.
[**GetSecretSubkeysPath**](Secrets.md#getsecretsubkeyspath) | **GET** /{secret_mount_path}/subkeys/{path} | Read the structure of a secret entry from the Key-Value store with the values removed.
[**GetSshConfigCa**](Secrets.md#getsshconfigca) | **GET** /{ssh_mount_path}/config/ca | Set the SSH private key used for signing certificates.
[**GetSshConfigZeroaddress**](Secrets.md#getsshconfigzeroaddress) | **GET** /{ssh_mount_path}/config/zeroaddress | Assign zero address as default CIDR block for select roles.
[**GetSshPublicKey**](Secrets.md#getsshpublickey) | **GET** /{ssh_mount_path}/public_key | Retrieve the public key.
[**GetSshRoles**](Secrets.md#getsshroles) | **GET** /{ssh_mount_path}/roles | Manage the &#39;roles&#39; that can be created with this backend.
[**GetSshRolesRole**](Secrets.md#getsshrolesrole) | **GET** /{ssh_mount_path}/roles/{role} | Manage the &#39;roles&#39; that can be created with this backend.
[**GetTerraformConfig**](Secrets.md#getterraformconfig) | **GET** /{terraform_mount_path}/config | 
[**GetTerraformCredsName**](Secrets.md#getterraformcredsname) | **GET** /{terraform_mount_path}/creds/{name} | Generate a Terraform Cloud or Enterprise API token from a specific Vault role.
[**GetTerraformRole**](Secrets.md#getterraformrole) | **GET** /{terraform_mount_path}/role | 
[**GetTerraformRoleName**](Secrets.md#getterraformrolename) | **GET** /{terraform_mount_path}/role/{name} | 
[**GetTotpCodeName**](Secrets.md#gettotpcodename) | **GET** /{totp_mount_path}/code/{name} | Request time-based one-time use password or validate a password for a certain key .
[**GetTotpKeys**](Secrets.md#gettotpkeys) | **GET** /{totp_mount_path}/keys | Manage the keys that can be created with this backend.
[**GetTotpKeysName**](Secrets.md#gettotpkeysname) | **GET** /{totp_mount_path}/keys/{name} | Manage the keys that can be created with this backend.
[**GetTransitBackupName**](Secrets.md#gettransitbackupname) | **GET** /{transit_mount_path}/backup/{name} | Backup the named key
[**GetTransitCacheConfig**](Secrets.md#gettransitcacheconfig) | **GET** /{transit_mount_path}/cache-config | Returns the size of the active cache
[**GetTransitExportTypeName**](Secrets.md#gettransitexporttypename) | **GET** /{transit_mount_path}/export/{type}/{name} | Export named encryption or signing key
[**GetTransitExportTypeNameVersion**](Secrets.md#gettransitexporttypenameversion) | **GET** /{transit_mount_path}/export/{type}/{name}/{version} | Export named encryption or signing key
[**GetTransitKeys**](Secrets.md#gettransitkeys) | **GET** /{transit_mount_path}/keys | Managed named encryption keys
[**GetTransitKeysName**](Secrets.md#gettransitkeysname) | **GET** /{transit_mount_path}/keys/{name} | Managed named encryption keys
[**GetTransitWrappingKey**](Secrets.md#gettransitwrappingkey) | **GET** /{transit_mount_path}/wrapping_key | Returns the public key to use for wrapping imported keys
[**PostAdConfig**](Secrets.md#postadconfig) | **POST** /{ad_mount_path}/config | Configure the AD server to connect to, along with password options.
[**PostAdLibraryManageNameCheckIn**](Secrets.md#postadlibrarymanagenamecheckin) | **POST** /{ad_mount_path}/library/manage/{name}/check-in | Check service accounts in to the library.
[**PostAdLibraryName**](Secrets.md#postadlibraryname) | **POST** /{ad_mount_path}/library/{name} | Update a library set.
[**PostAdLibraryNameCheckIn**](Secrets.md#postadlibrarynamecheckin) | **POST** /{ad_mount_path}/library/{name}/check-in | Check service accounts in to the library.
[**PostAdLibraryNameCheckOut**](Secrets.md#postadlibrarynamecheckout) | **POST** /{ad_mount_path}/library/{name}/check-out | Check a service account out from the library.
[**PostAdRolesName**](Secrets.md#postadrolesname) | **POST** /{ad_mount_path}/roles/{name} | Manage roles to build links between Vault and Active Directory service accounts.
[**PostAdRotateRoleName**](Secrets.md#postadrotaterolename) | **POST** /{ad_mount_path}/rotate-role/{name} | 
[**PostAdRotateRoot**](Secrets.md#postadrotateroot) | **POST** /{ad_mount_path}/rotate-root | 
[**PostAlicloudConfig**](Secrets.md#postalicloudconfig) | **POST** /{alicloud_mount_path}/config | Configure the access key and secret to use for RAM and STS calls.
[**PostAlicloudRoleName**](Secrets.md#postalicloudrolename) | **POST** /{alicloud_mount_path}/role/{name} | Read, write and reference policies and roles that API keys or STS credentials can be made for.
[**PostAwsConfigLease**](Secrets.md#postawsconfiglease) | **POST** /{aws_mount_path}/config/lease | Configure the default lease information for generated credentials.
[**PostAwsConfigRoot**](Secrets.md#postawsconfigroot) | **POST** /{aws_mount_path}/config/root | Configure the root credentials that are used to manage IAM.
[**PostAwsConfigRotateRoot**](Secrets.md#postawsconfigrotateroot) | **POST** /{aws_mount_path}/config/rotate-root | 
[**PostAwsCreds**](Secrets.md#postawscreds) | **POST** /{aws_mount_path}/creds | Generate AWS credentials from a specific Vault role.
[**PostAwsRolesName**](Secrets.md#postawsrolesname) | **POST** /{aws_mount_path}/roles/{name} | Read, write and reference IAM policies that access keys can be made for.
[**PostAwsStsName**](Secrets.md#postawsstsname) | **POST** /{aws_mount_path}/sts/{name} | Generate AWS credentials from a specific Vault role.
[**PostAzureConfig**](Secrets.md#postazureconfig) | **POST** /{azure_mount_path}/config | 
[**PostAzureRolesName**](Secrets.md#postazurerolesname) | **POST** /{azure_mount_path}/roles/{name} | Manage the Vault roles used to generate Azure credentials.
[**PostAzureRotateRoot**](Secrets.md#postazurerotateroot) | **POST** /{azure_mount_path}/rotate-root | 
[**PostConsulConfigAccess**](Secrets.md#postconsulconfigaccess) | **POST** /{consul_mount_path}/config/access | 
[**PostConsulRolesName**](Secrets.md#postconsulrolesname) | **POST** /{consul_mount_path}/roles/{name} | 
[**PostCubbyholePath**](Secrets.md#postcubbyholepath) | **POST** /{cubbyhole_mount_path}/{path} | Store a secret at the specified location.
[**PostGcpConfig**](Secrets.md#postgcpconfig) | **POST** /{gcp_mount_path}/config | 
[**PostGcpConfigRotateRoot**](Secrets.md#postgcpconfigrotateroot) | **POST** /{gcp_mount_path}/config/rotate-root | 
[**PostGcpKeyRoleset**](Secrets.md#postgcpkeyroleset) | **POST** /{gcp_mount_path}/key/{roleset} | 
[**PostGcpRolesetName**](Secrets.md#postgcprolesetname) | **POST** /{gcp_mount_path}/roleset/{name} | 
[**PostGcpRolesetNameRotate**](Secrets.md#postgcprolesetnamerotate) | **POST** /{gcp_mount_path}/roleset/{name}/rotate | 
[**PostGcpRolesetNameRotateKey**](Secrets.md#postgcprolesetnamerotatekey) | **POST** /{gcp_mount_path}/roleset/{name}/rotate-key | 
[**PostGcpRolesetRolesetKey**](Secrets.md#postgcprolesetrolesetkey) | **POST** /{gcp_mount_path}/roleset/{roleset}/key | 
[**PostGcpRolesetRolesetToken**](Secrets.md#postgcprolesetrolesettoken) | **POST** /{gcp_mount_path}/roleset/{roleset}/token | 
[**PostGcpStaticAccountName**](Secrets.md#postgcpstaticaccountname) | **POST** /{gcp_mount_path}/static-account/{name} | 
[**PostGcpStaticAccountNameKey**](Secrets.md#postgcpstaticaccountnamekey) | **POST** /{gcp_mount_path}/static-account/{name}/key | 
[**PostGcpStaticAccountNameRotateKey**](Secrets.md#postgcpstaticaccountnamerotatekey) | **POST** /{gcp_mount_path}/static-account/{name}/rotate-key | 
[**PostGcpStaticAccountNameToken**](Secrets.md#postgcpstaticaccountnametoken) | **POST** /{gcp_mount_path}/static-account/{name}/token | 
[**PostGcpTokenRoleset**](Secrets.md#postgcptokenroleset) | **POST** /{gcp_mount_path}/token/{roleset} | 
[**PostGcpkmsConfig**](Secrets.md#postgcpkmsconfig) | **POST** /{gcpkms_mount_path}/config | Configure the GCP KMS secrets engine
[**PostGcpkmsDecryptKey**](Secrets.md#postgcpkmsdecryptkey) | **POST** /{gcpkms_mount_path}/decrypt/{key} | Decrypt a ciphertext value using a named key
[**PostGcpkmsEncryptKey**](Secrets.md#postgcpkmsencryptkey) | **POST** /{gcpkms_mount_path}/encrypt/{key} | Encrypt a plaintext value using a named key
[**PostGcpkmsKeysConfigKey**](Secrets.md#postgcpkmskeysconfigkey) | **POST** /{gcpkms_mount_path}/keys/config/{key} | Configure the key in Vault
[**PostGcpkmsKeysDeregisterKey**](Secrets.md#postgcpkmskeysderegisterkey) | **POST** /{gcpkms_mount_path}/keys/deregister/{key} | Deregister an existing key in Vault
[**PostGcpkmsKeysKey**](Secrets.md#postgcpkmskeyskey) | **POST** /{gcpkms_mount_path}/keys/{key} | Interact with crypto keys in Vault and Google Cloud KMS
[**PostGcpkmsKeysRegisterKey**](Secrets.md#postgcpkmskeysregisterkey) | **POST** /{gcpkms_mount_path}/keys/register/{key} | Register an existing crypto key in Google Cloud KMS
[**PostGcpkmsKeysRotateKey**](Secrets.md#postgcpkmskeysrotatekey) | **POST** /{gcpkms_mount_path}/keys/rotate/{key} | Rotate a crypto key to a new primary version
[**PostGcpkmsKeysTrimKey**](Secrets.md#postgcpkmskeystrimkey) | **POST** /{gcpkms_mount_path}/keys/trim/{key} | Delete old crypto key versions from Google Cloud KMS
[**PostGcpkmsReencryptKey**](Secrets.md#postgcpkmsreencryptkey) | **POST** /{gcpkms_mount_path}/reencrypt/{key} | Re-encrypt existing ciphertext data to a new version
[**PostGcpkmsSignKey**](Secrets.md#postgcpkmssignkey) | **POST** /{gcpkms_mount_path}/sign/{key} | Signs a message or digest using a named key
[**PostGcpkmsVerifyKey**](Secrets.md#postgcpkmsverifykey) | **POST** /{gcpkms_mount_path}/verify/{key} | Verify a signature using a named key
[**PostKubernetesConfig**](Secrets.md#postkubernetesconfig) | **POST** /{kubernetes_mount_path}/config | 
[**PostKubernetesCredsName**](Secrets.md#postkubernetescredsname) | **POST** /{kubernetes_mount_path}/creds/{name} | 
[**PostKubernetesRolesName**](Secrets.md#postkubernetesrolesname) | **POST** /{kubernetes_mount_path}/roles/{name} | 
[**PostLdapConfig**](Secrets.md#postldapconfig) | **POST** /{ldap_mount_path}/config | 
[**PostLdapLibraryManageNameCheckIn**](Secrets.md#postldaplibrarymanagenamecheckin) | **POST** /{ldap_mount_path}/library/manage/{name}/check-in | Check service accounts in to the library.
[**PostLdapLibraryName**](Secrets.md#postldaplibraryname) | **POST** /{ldap_mount_path}/library/{name} | Update a library set.
[**PostLdapLibraryNameCheckIn**](Secrets.md#postldaplibrarynamecheckin) | **POST** /{ldap_mount_path}/library/{name}/check-in | Check service accounts in to the library.
[**PostLdapLibraryNameCheckOut**](Secrets.md#postldaplibrarynamecheckout) | **POST** /{ldap_mount_path}/library/{name}/check-out | Check a service account out from the library.
[**PostLdapRoleName**](Secrets.md#postldaprolename) | **POST** /{ldap_mount_path}/role/{name} | 
[**PostLdapRotateRoleName**](Secrets.md#postldaprotaterolename) | **POST** /{ldap_mount_path}/rotate-role/{name} | 
[**PostLdapRotateRoot**](Secrets.md#postldaprotateroot) | **POST** /{ldap_mount_path}/rotate-root | 
[**PostLdapStaticRoleName**](Secrets.md#postldapstaticrolename) | **POST** /{ldap_mount_path}/static-role/{name} | 
[**PostMongodbatlasConfig**](Secrets.md#postmongodbatlasconfig) | **POST** /{mongodbatlas_mount_path}/config | Configure the  credentials that are used to manage Database Users.
[**PostMongodbatlasCredsName**](Secrets.md#postmongodbatlascredsname) | **POST** /{mongodbatlas_mount_path}/creds/{name} | Generate MongoDB Atlas Programmatic API from a specific Vault role.
[**PostMongodbatlasRolesName**](Secrets.md#postmongodbatlasrolesname) | **POST** /{mongodbatlas_mount_path}/roles/{name} | Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
[**PostNomadConfigAccess**](Secrets.md#postnomadconfigaccess) | **POST** /{nomad_mount_path}/config/access | 
[**PostNomadConfigLease**](Secrets.md#postnomadconfiglease) | **POST** /{nomad_mount_path}/config/lease | Configure the lease parameters for generated tokens
[**PostNomadRoleName**](Secrets.md#postnomadrolename) | **POST** /{nomad_mount_path}/role/{name} | 
[**PostOpenldapConfig**](Secrets.md#postopenldapconfig) | **POST** /{openldap_mount_path}/config | 
[**PostOpenldapLibraryManageNameCheckIn**](Secrets.md#postopenldaplibrarymanagenamecheckin) | **POST** /{openldap_mount_path}/library/manage/{name}/check-in | Check service accounts in to the library.
[**PostOpenldapLibraryName**](Secrets.md#postopenldaplibraryname) | **POST** /{openldap_mount_path}/library/{name} | Update a library set.
[**PostOpenldapLibraryNameCheckIn**](Secrets.md#postopenldaplibrarynamecheckin) | **POST** /{openldap_mount_path}/library/{name}/check-in | Check service accounts in to the library.
[**PostOpenldapLibraryNameCheckOut**](Secrets.md#postopenldaplibrarynamecheckout) | **POST** /{openldap_mount_path}/library/{name}/check-out | Check a service account out from the library.
[**PostOpenldapRoleName**](Secrets.md#postopenldaprolename) | **POST** /{openldap_mount_path}/role/{name} | 
[**PostOpenldapRotateRoleName**](Secrets.md#postopenldaprotaterolename) | **POST** /{openldap_mount_path}/rotate-role/{name} | 
[**PostOpenldapRotateRoot**](Secrets.md#postopenldaprotateroot) | **POST** /{openldap_mount_path}/rotate-root | 
[**PostOpenldapStaticRoleName**](Secrets.md#postopenldapstaticrolename) | **POST** /{openldap_mount_path}/static-role/{name} | 
[**PostPkiBundle**](Secrets.md#postpkibundle) | **POST** /{pki_mount_path}/bundle | 
[**PostPkiCert**](Secrets.md#postpkicert) | **POST** /{pki_mount_path}/cert | 
[**PostPkiConfigAutoTidy**](Secrets.md#postpkiconfigautotidy) | **POST** /{pki_mount_path}/config/auto-tidy | 
[**PostPkiConfigCa**](Secrets.md#postpkiconfigca) | **POST** /{pki_mount_path}/config/ca | 
[**PostPkiConfigCrl**](Secrets.md#postpkiconfigcrl) | **POST** /{pki_mount_path}/config/crl | 
[**PostPkiConfigIssuers**](Secrets.md#postpkiconfigissuers) | **POST** /{pki_mount_path}/config/issuers | 
[**PostPkiConfigKeys**](Secrets.md#postpkiconfigkeys) | **POST** /{pki_mount_path}/config/keys | 
[**PostPkiConfigUrls**](Secrets.md#postpkiconfigurls) | **POST** /{pki_mount_path}/config/urls | 
[**PostPkiIntermediateCrossSign**](Secrets.md#postpkiintermediatecrosssign) | **POST** /{pki_mount_path}/intermediate/cross-sign | 
[**PostPkiIntermediateGenerateExported**](Secrets.md#postpkiintermediategenerateexported) | **POST** /{pki_mount_path}/intermediate/generate/{exported} | 
[**PostPkiIntermediateSetSigned**](Secrets.md#postpkiintermediatesetsigned) | **POST** /{pki_mount_path}/intermediate/set-signed | 
[**PostPkiInternalExported**](Secrets.md#postpkiinternalexported) | **POST** /{pki_mount_path}/internal|exported | 
[**PostPkiIssueRole**](Secrets.md#postpkiissuerole) | **POST** /{pki_mount_path}/issue/{role} | 
[**PostPkiIssuerIssuerRefIssueRole**](Secrets.md#postpkiissuerissuerrefissuerole) | **POST** /{pki_mount_path}/issuer/{issuer_ref}/issue/{role} | 
[**PostPkiIssuerIssuerRefRevoke**](Secrets.md#postpkiissuerissuerrefrevoke) | **POST** /{pki_mount_path}/issuer/{issuer_ref}/revoke | 
[**PostPkiIssuerIssuerRefSignIntermediate**](Secrets.md#postpkiissuerissuerrefsignintermediate) | **POST** /{pki_mount_path}/issuer/{issuer_ref}/sign-intermediate | 
[**PostPkiIssuerIssuerRefSignRole**](Secrets.md#postpkiissuerissuerrefsignrole) | **POST** /{pki_mount_path}/issuer/{issuer_ref}/sign/{role} | 
[**PostPkiIssuerIssuerRefSignSelfIssued**](Secrets.md#postpkiissuerissuerrefsignselfissued) | **POST** /{pki_mount_path}/issuer/{issuer_ref}/sign-self-issued | 
[**PostPkiIssuerIssuerRefSignVerbatim**](Secrets.md#postpkiissuerissuerrefsignverbatim) | **POST** /{pki_mount_path}/issuer/{issuer_ref}/sign-verbatim | 
[**PostPkiIssuerIssuerRefSignVerbatimRole**](Secrets.md#postpkiissuerissuerrefsignverbatimrole) | **POST** /{pki_mount_path}/issuer/{issuer_ref}/sign-verbatim/{role} | 
[**PostPkiIssuerRefDerPem**](Secrets.md#postpkiissuerrefderpem) | **POST** /{pki_mount_path}/{issuer_ref}/der|/pem | 
[**PostPkiIssuersGenerateIntermediateExported**](Secrets.md#postpkiissuersgenerateintermediateexported) | **POST** /{pki_mount_path}/issuers/generate/intermediate/{exported} | 
[**PostPkiIssuersGenerateRootExported**](Secrets.md#postpkiissuersgeneraterootexported) | **POST** /{pki_mount_path}/issuers/generate/root/{exported} | 
[**PostPkiJson**](Secrets.md#postpkijson) | **POST** /{pki_mount_path}//json | 
[**PostPkiKeyKeyRef**](Secrets.md#postpkikeykeyref) | **POST** /{pki_mount_path}/key/{key_ref} | 
[**PostPkiKeysImport**](Secrets.md#postpkikeysimport) | **POST** /{pki_mount_path}/keys/import | 
[**PostPkiKms**](Secrets.md#postpkikms) | **POST** /{pki_mount_path}/kms | 
[**PostPkiOcsp**](Secrets.md#postpkiocsp) | **POST** /{pki_mount_path}/ocsp | 
[**PostPkiRevoke**](Secrets.md#postpkirevoke) | **POST** /{pki_mount_path}/revoke | 
[**PostPkiRevokeWithKey**](Secrets.md#postpkirevokewithkey) | **POST** /{pki_mount_path}/revoke-with-key | 
[**PostPkiRolesName**](Secrets.md#postpkirolesname) | **POST** /{pki_mount_path}/roles/{name} | 
[**PostPkiRootGenerateExported**](Secrets.md#postpkirootgenerateexported) | **POST** /{pki_mount_path}/root/generate/{exported} | 
[**PostPkiRootReplace**](Secrets.md#postpkirootreplace) | **POST** /{pki_mount_path}/root/replace | 
[**PostPkiRootRotateExported**](Secrets.md#postpkirootrotateexported) | **POST** /{pki_mount_path}/root/rotate/{exported} | 
[**PostPkiRootSignIntermediate**](Secrets.md#postpkirootsignintermediate) | **POST** /{pki_mount_path}/root/sign-intermediate | 
[**PostPkiRootSignSelfIssued**](Secrets.md#postpkirootsignselfissued) | **POST** /{pki_mount_path}/root/sign-self-issued | 
[**PostPkiSignRole**](Secrets.md#postpkisignrole) | **POST** /{pki_mount_path}/sign/{role} | 
[**PostPkiSignVerbatim**](Secrets.md#postpkisignverbatim) | **POST** /{pki_mount_path}/sign-verbatim | 
[**PostPkiSignVerbatimRole**](Secrets.md#postpkisignverbatimrole) | **POST** /{pki_mount_path}/sign-verbatim/{role} | 
[**PostPkiTidy**](Secrets.md#postpkitidy) | **POST** /{pki_mount_path}/tidy | 
[**PostPkiTidyCancel**](Secrets.md#postpkitidycancel) | **POST** /{pki_mount_path}/tidy-cancel | 
[**PostRabbitmqConfigConnection**](Secrets.md#postrabbitmqconfigconnection) | **POST** /{rabbitmq_mount_path}/config/connection | Configure the connection URI, username, and password to talk to RabbitMQ management HTTP API.
[**PostRabbitmqConfigLease**](Secrets.md#postrabbitmqconfiglease) | **POST** /{rabbitmq_mount_path}/config/lease | Configure the lease parameters for generated credentials
[**PostRabbitmqRolesName**](Secrets.md#postrabbitmqrolesname) | **POST** /{rabbitmq_mount_path}/roles/{name} | Manage the roles that can be created with this backend.
[**PostSecretConfig**](Secrets.md#postsecretconfig) | **POST** /{secret_mount_path}/config | Configure backend level settings that are applied to every key in the key-value store.
[**PostSecretDataPath**](Secrets.md#postsecretdatapath) | **POST** /{secret_mount_path}/data/{path} | Write, Patch, Read, and Delete data in the Key-Value Store.
[**PostSecretDeletePath**](Secrets.md#postsecretdeletepath) | **POST** /{secret_mount_path}/delete/{path} | Marks one or more versions as deleted in the KV store.
[**PostSecretDestroyPath**](Secrets.md#postsecretdestroypath) | **POST** /{secret_mount_path}/destroy/{path} | Permanently removes one or more versions in the KV store
[**PostSecretMetadataPath**](Secrets.md#postsecretmetadatapath) | **POST** /{secret_mount_path}/metadata/{path} | Configures settings for the KV store
[**PostSecretPath**](Secrets.md#postsecretpath) | **POST** /{secret_mount_path}/{path} | Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.
[**PostSecretUndeletePath**](Secrets.md#postsecretundeletepath) | **POST** /{secret_mount_path}/undelete/{path} | Undeletes one or more versions from the KV store.
[**PostSshConfigCa**](Secrets.md#postsshconfigca) | **POST** /{ssh_mount_path}/config/ca | Set the SSH private key used for signing certificates.
[**PostSshConfigZeroaddress**](Secrets.md#postsshconfigzeroaddress) | **POST** /{ssh_mount_path}/config/zeroaddress | Assign zero address as default CIDR block for select roles.
[**PostSshCredsRole**](Secrets.md#postsshcredsrole) | **POST** /{ssh_mount_path}/creds/{role} | Creates a credential for establishing SSH connection with the remote host.
[**PostSshIssueRole**](Secrets.md#postsshissuerole) | **POST** /{ssh_mount_path}/issue/{role} | 
[**PostSshKeysKeyName**](Secrets.md#postsshkeyskeyname) | **POST** /{ssh_mount_path}/keys/{key_name} | Register a shared private key with Vault.
[**PostSshLookup**](Secrets.md#postsshlookup) | **POST** /{ssh_mount_path}/lookup | List all the roles associated with the given IP address.
[**PostSshRolesRole**](Secrets.md#postsshrolesrole) | **POST** /{ssh_mount_path}/roles/{role} | Manage the &#39;roles&#39; that can be created with this backend.
[**PostSshSignRole**](Secrets.md#postsshsignrole) | **POST** /{ssh_mount_path}/sign/{role} | Request signing an SSH key using a certain role with the provided details.
[**PostSshVerify**](Secrets.md#postsshverify) | **POST** /{ssh_mount_path}/verify | Validate the OTP provided by Vault SSH Agent.
[**PostTerraformConfig**](Secrets.md#postterraformconfig) | **POST** /{terraform_mount_path}/config | 
[**PostTerraformCredsName**](Secrets.md#postterraformcredsname) | **POST** /{terraform_mount_path}/creds/{name} | Generate a Terraform Cloud or Enterprise API token from a specific Vault role.
[**PostTerraformRoleName**](Secrets.md#postterraformrolename) | **POST** /{terraform_mount_path}/role/{name} | 
[**PostTerraformRotateRoleName**](Secrets.md#postterraformrotaterolename) | **POST** /{terraform_mount_path}/rotate-role/{name} | 
[**PostTotpCodeName**](Secrets.md#posttotpcodename) | **POST** /{totp_mount_path}/code/{name} | Request time-based one-time use password or validate a password for a certain key .
[**PostTotpKeysName**](Secrets.md#posttotpkeysname) | **POST** /{totp_mount_path}/keys/{name} | Manage the keys that can be created with this backend.
[**PostTransitCacheConfig**](Secrets.md#posttransitcacheconfig) | **POST** /{transit_mount_path}/cache-config | Configures a new cache of the specified size
[**PostTransitDatakeyPlaintextName**](Secrets.md#posttransitdatakeyplaintextname) | **POST** /{transit_mount_path}/datakey/{plaintext}/{name} | Generate a data key
[**PostTransitDecryptName**](Secrets.md#posttransitdecryptname) | **POST** /{transit_mount_path}/decrypt/{name} | Decrypt a ciphertext value using a named key
[**PostTransitEncryptName**](Secrets.md#posttransitencryptname) | **POST** /{transit_mount_path}/encrypt/{name} | Encrypt a plaintext value or a batch of plaintext blocks using a named key
[**PostTransitHash**](Secrets.md#posttransithash) | **POST** /{transit_mount_path}/hash | Generate a hash sum for input data
[**PostTransitHashUrlalgorithm**](Secrets.md#posttransithashurlalgorithm) | **POST** /{transit_mount_path}/hash/{urlalgorithm} | Generate a hash sum for input data
[**PostTransitHmacName**](Secrets.md#posttransithmacname) | **POST** /{transit_mount_path}/hmac/{name} | Generate an HMAC for input data using the named key
[**PostTransitHmacNameUrlalgorithm**](Secrets.md#posttransithmacnameurlalgorithm) | **POST** /{transit_mount_path}/hmac/{name}/{urlalgorithm} | Generate an HMAC for input data using the named key
[**PostTransitKeysName**](Secrets.md#posttransitkeysname) | **POST** /{transit_mount_path}/keys/{name} | Managed named encryption keys
[**PostTransitKeysNameConfig**](Secrets.md#posttransitkeysnameconfig) | **POST** /{transit_mount_path}/keys/{name}/config | Configure a named encryption key
[**PostTransitKeysNameImport**](Secrets.md#posttransitkeysnameimport) | **POST** /{transit_mount_path}/keys/{name}/import | Imports an externally-generated key into a new transit key
[**PostTransitKeysNameImportVersion**](Secrets.md#posttransitkeysnameimportversion) | **POST** /{transit_mount_path}/keys/{name}/import_version | Imports an externally-generated key into an existing imported key
[**PostTransitKeysNameRotate**](Secrets.md#posttransitkeysnamerotate) | **POST** /{transit_mount_path}/keys/{name}/rotate | Rotate named encryption key
[**PostTransitKeysNameTrim**](Secrets.md#posttransitkeysnametrim) | **POST** /{transit_mount_path}/keys/{name}/trim | Trim key versions of a named key
[**PostTransitRandom**](Secrets.md#posttransitrandom) | **POST** /{transit_mount_path}/random | Generate random bytes
[**PostTransitRandomSource**](Secrets.md#posttransitrandomsource) | **POST** /{transit_mount_path}/random/{source} | Generate random bytes
[**PostTransitRandomSourceUrlbytes**](Secrets.md#posttransitrandomsourceurlbytes) | **POST** /{transit_mount_path}/random/{source}/{urlbytes} | Generate random bytes
[**PostTransitRandomUrlbytes**](Secrets.md#posttransitrandomurlbytes) | **POST** /{transit_mount_path}/random/{urlbytes} | Generate random bytes
[**PostTransitRestore**](Secrets.md#posttransitrestore) | **POST** /{transit_mount_path}/restore | Restore the named key
[**PostTransitRestoreName**](Secrets.md#posttransitrestorename) | **POST** /{transit_mount_path}/restore/{name} | Restore the named key
[**PostTransitRewrapName**](Secrets.md#posttransitrewrapname) | **POST** /{transit_mount_path}/rewrap/{name} | Rewrap ciphertext
[**PostTransitSignName**](Secrets.md#posttransitsignname) | **POST** /{transit_mount_path}/sign/{name} | Generate a signature for input data using the named key
[**PostTransitSignNameUrlalgorithm**](Secrets.md#posttransitsignnameurlalgorithm) | **POST** /{transit_mount_path}/sign/{name}/{urlalgorithm} | Generate a signature for input data using the named key
[**PostTransitVerifyName**](Secrets.md#posttransitverifyname) | **POST** /{transit_mount_path}/verify/{name} | Verify a signature or HMAC for input data created using the named key
[**PostTransitVerifyNameUrlalgorithm**](Secrets.md#posttransitverifynameurlalgorithm) | **POST** /{transit_mount_path}/verify/{name}/{urlalgorithm} | Verify a signature or HMAC for input data created using the named key


<a name="deleteadconfig"></a>
# **DeleteAdConfig**
> void DeleteAdConfig (string adMountPath = null)

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
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Configure the AD server to connect to, along with password options.
                apiInstance.DeleteAdConfig(adMountPath);
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

<a name="deleteadlibraryname"></a>
# **DeleteAdLibraryName**
> void DeleteAdLibraryName (string name, string adMountPath = null)

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
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Delete a library set.
                apiInstance.DeleteAdLibraryName(name, adMountPath);
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

<a name="deleteadrolesname"></a>
# **DeleteAdRolesName**
> void DeleteAdRolesName (string name, string adMountPath = null)

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
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Manage roles to build links between Vault and Active Directory service accounts.
                apiInstance.DeleteAdRolesName(name, adMountPath);
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

<a name="deletealicloudconfig"></a>
# **DeleteAlicloudConfig**
> void DeleteAlicloudConfig (string alicloudMountPath = null)

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
            var alicloudMountPath = "\"alicloud\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "alicloud")

            try
            {
                // Configure the access key and secret to use for RAM and STS calls.
                apiInstance.DeleteAlicloudConfig(alicloudMountPath);
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

<a name="deletealicloudrolename"></a>
# **DeleteAlicloudRoleName**
> void DeleteAlicloudRoleName (string name, string alicloudMountPath = null)

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
            var alicloudMountPath = "\"alicloud\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "alicloud")

            try
            {
                // Read, write and reference policies and roles that API keys or STS credentials can be made for.
                apiInstance.DeleteAlicloudRoleName(name, alicloudMountPath);
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

<a name="deleteawsrolesname"></a>
# **DeleteAwsRolesName**
> void DeleteAwsRolesName (string name, string awsMountPath = null)

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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Read, write and reference IAM policies that access keys can be made for.
                apiInstance.DeleteAwsRolesName(name, awsMountPath);
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

<a name="deleteazureconfig"></a>
# **DeleteAzureConfig**
> void DeleteAzureConfig (string azureMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                apiInstance.DeleteAzureConfig(azureMountPath);
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

<a name="deleteazurerolesname"></a>
# **DeleteAzureRolesName**
> void DeleteAzureRolesName (string name, string azureMountPath = null)

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
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                // Manage the Vault roles used to generate Azure credentials.
                apiInstance.DeleteAzureRolesName(name, azureMountPath);
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

<a name="deleteconsulrolesname"></a>
# **DeleteConsulRolesName**
> void DeleteConsulRolesName (string name, string consulMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var consulMountPath = "\"consul\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "consul")

            try
            {
                apiInstance.DeleteConsulRolesName(name, consulMountPath);
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

<a name="deletecubbyholepath"></a>
# **DeleteCubbyholePath**
> void DeleteCubbyholePath (string path, string cubbyholeMountPath = null)

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
            var cubbyholeMountPath = "\"cubbyhole\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cubbyhole")

            try
            {
                // Deletes the secret at the specified location.
                apiInstance.DeleteCubbyholePath(path, cubbyholeMountPath);
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

<a name="deletegcprolesetname"></a>
# **DeleteGcpRolesetName**
> void DeleteGcpRolesetName (string name, string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.DeleteGcpRolesetName(name, gcpMountPath);
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

<a name="deletegcpstaticaccountname"></a>
# **DeleteGcpStaticAccountName**
> void DeleteGcpStaticAccountName (string name, string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.DeleteGcpStaticAccountName(name, gcpMountPath);
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

<a name="deletegcpkmsconfig"></a>
# **DeleteGcpkmsConfig**
> void DeleteGcpkmsConfig (string gcpkmsMountPath = null)

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
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Configure the GCP KMS secrets engine
                apiInstance.DeleteGcpkmsConfig(gcpkmsMountPath);
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

<a name="deletegcpkmskeysderegisterkey"></a>
# **DeleteGcpkmsKeysDeregisterKey**
> void DeleteGcpkmsKeysDeregisterKey (string key, string gcpkmsMountPath = null)

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
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Deregister an existing key in Vault
                apiInstance.DeleteGcpkmsKeysDeregisterKey(key, gcpkmsMountPath);
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

<a name="deletegcpkmskeyskey"></a>
# **DeleteGcpkmsKeysKey**
> void DeleteGcpkmsKeysKey (string key, string gcpkmsMountPath = null)

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
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Interact with crypto keys in Vault and Google Cloud KMS
                apiInstance.DeleteGcpkmsKeysKey(key, gcpkmsMountPath);
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

<a name="deletegcpkmskeystrimkey"></a>
# **DeleteGcpkmsKeysTrimKey**
> void DeleteGcpkmsKeysTrimKey (string key, string gcpkmsMountPath = null)

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
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Delete old crypto key versions from Google Cloud KMS
                apiInstance.DeleteGcpkmsKeysTrimKey(key, gcpkmsMountPath);
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

<a name="deletekubernetesconfig"></a>
# **DeleteKubernetesConfig**
> void DeleteKubernetesConfig (string kubernetesMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                apiInstance.DeleteKubernetesConfig(kubernetesMountPath);
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

<a name="deletekubernetesrolesname"></a>
# **DeleteKubernetesRolesName**
> void DeleteKubernetesRolesName (string name, string kubernetesMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                apiInstance.DeleteKubernetesRolesName(name, kubernetesMountPath);
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

<a name="deleteldapconfig"></a>
# **DeleteLdapConfig**
> void DeleteLdapConfig (string ldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteLdapConfigExample
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
                apiInstance.DeleteLdapConfig(ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteLdapConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteldaplibraryname"></a>
# **DeleteLdapLibraryName**
> void DeleteLdapLibraryName (string name, string ldapMountPath = null)

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
    public class DeleteLdapLibraryNameExample
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
                apiInstance.DeleteLdapLibraryName(name, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteLdapLibraryName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="deleteldaprolename"></a>
# **DeleteLdapRoleName**
> void DeleteLdapRoleName (string name, string ldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteLdapRoleNameExample
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
                apiInstance.DeleteLdapRoleName(name, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteLdapRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="deleteldapstaticrolename"></a>
# **DeleteLdapStaticRoleName**
> void DeleteLdapStaticRoleName (string name, string ldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteLdapStaticRoleNameExample
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
                apiInstance.DeleteLdapStaticRoleName(name, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteLdapStaticRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="deletemongodbatlasrolesname"></a>
# **DeleteMongodbatlasRolesName**
> void DeleteMongodbatlasRolesName (string name, string mongodbatlasMountPath = null)

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
            var mongodbatlasMountPath = "\"mongodbatlas\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "mongodbatlas")

            try
            {
                // Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
                apiInstance.DeleteMongodbatlasRolesName(name, mongodbatlasMountPath);
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

<a name="deletenomadconfigaccess"></a>
# **DeleteNomadConfigAccess**
> void DeleteNomadConfigAccess (string nomadMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var nomadMountPath = "\"nomad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "nomad")

            try
            {
                apiInstance.DeleteNomadConfigAccess(nomadMountPath);
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

<a name="deletenomadconfiglease"></a>
# **DeleteNomadConfigLease**
> void DeleteNomadConfigLease (string nomadMountPath = null)

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
            var nomadMountPath = "\"nomad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "nomad")

            try
            {
                // Configure the lease parameters for generated tokens
                apiInstance.DeleteNomadConfigLease(nomadMountPath);
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

<a name="deletenomadrolename"></a>
# **DeleteNomadRoleName**
> void DeleteNomadRoleName (string name, string nomadMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var nomadMountPath = "\"nomad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "nomad")

            try
            {
                apiInstance.DeleteNomadRoleName(name, nomadMountPath);
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

<a name="deleteopenldapconfig"></a>
# **DeleteOpenldapConfig**
> void DeleteOpenldapConfig (string openldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.DeleteOpenldapConfig(openldapMountPath);
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

<a name="deleteopenldaplibraryname"></a>
# **DeleteOpenldapLibraryName**
> void DeleteOpenldapLibraryName (string name, string openldapMountPath = null)

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
    public class DeleteOpenldapLibraryNameExample
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
                apiInstance.DeleteOpenldapLibraryName(name, openldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteOpenldapLibraryName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="deleteopenldaprolename"></a>
# **DeleteOpenldapRoleName**
> void DeleteOpenldapRoleName (string name, string openldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.DeleteOpenldapRoleName(name, openldapMountPath);
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

<a name="deleteopenldapstaticrolename"></a>
# **DeleteOpenldapStaticRoleName**
> void DeleteOpenldapStaticRoleName (string name, string openldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.DeleteOpenldapStaticRoleName(name, openldapMountPath);
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

<a name="deletepkiissuerrefderpem"></a>
# **DeletePkiIssuerRefDerPem**
> void DeletePkiIssuerRefDerPem (string issuerRef, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.DeletePkiIssuerRefDerPem(issuerRef, pkiMountPath);
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

<a name="deletepkijson"></a>
# **DeletePkiJson**
> void DeletePkiJson (string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.DeletePkiJson(pkiMountPath);
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

<a name="deletepkikeykeyref"></a>
# **DeletePkiKeyKeyRef**
> void DeletePkiKeyKeyRef (string keyRef, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.DeletePkiKeyKeyRef(keyRef, pkiMountPath);
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

<a name="deletepkirolesname"></a>
# **DeletePkiRolesName**
> void DeletePkiRolesName (string name, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.DeletePkiRolesName(name, pkiMountPath);
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

<a name="deletepkiroot"></a>
# **DeletePkiRoot**
> void DeletePkiRoot (string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.DeletePkiRoot(pkiMountPath);
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

<a name="deleterabbitmqrolesname"></a>
# **DeleteRabbitmqRolesName**
> void DeleteRabbitmqRolesName (string name, string rabbitmqMountPath = null)

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
            var rabbitmqMountPath = "\"rabbitmq\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "rabbitmq")

            try
            {
                // Manage the roles that can be created with this backend.
                apiInstance.DeleteRabbitmqRolesName(name, rabbitmqMountPath);
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

<a name="deletesecretdatapath"></a>
# **DeleteSecretDataPath**
> void DeleteSecretDataPath (string path, string secretMountPath = null)

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
            var secretMountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Write, Patch, Read, and Delete data in the Key-Value Store.
                apiInstance.DeleteSecretDataPath(path, secretMountPath);
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

<a name="deletesecretmetadatapath"></a>
# **DeleteSecretMetadataPath**
> void DeleteSecretMetadataPath (string path, string secretMountPath = null)

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
            var secretMountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Configures settings for the KV store
                apiInstance.DeleteSecretMetadataPath(path, secretMountPath);
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

<a name="deletesecretpath"></a>
# **DeleteSecretPath**
> void DeleteSecretPath (string path, string secretMountPath = null)

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
    public class DeleteSecretPathExample
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
                // Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.
                apiInstance.DeleteSecretPath(path, secretMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.DeleteSecretPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="deletesshconfigca"></a>
# **DeleteSshConfigCa**
> void DeleteSshConfigCa (string sshMountPath = null)

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
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Set the SSH private key used for signing certificates.
                apiInstance.DeleteSshConfigCa(sshMountPath);
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

<a name="deletesshconfigzeroaddress"></a>
# **DeleteSshConfigZeroaddress**
> void DeleteSshConfigZeroaddress (string sshMountPath = null)

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
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Assign zero address as default CIDR block for select roles.
                apiInstance.DeleteSshConfigZeroaddress(sshMountPath);
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

<a name="deletesshkeyskeyname"></a>
# **DeleteSshKeysKeyName**
> void DeleteSshKeysKeyName (string keyName, string sshMountPath = null)

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
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Register a shared private key with Vault.
                apiInstance.DeleteSshKeysKeyName(keyName, sshMountPath);
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

<a name="deletesshrolesrole"></a>
# **DeleteSshRolesRole**
> void DeleteSshRolesRole (string role, string sshMountPath = null)

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
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Manage the 'roles' that can be created with this backend.
                apiInstance.DeleteSshRolesRole(role, sshMountPath);
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

<a name="deleteterraformconfig"></a>
# **DeleteTerraformConfig**
> void DeleteTerraformConfig (string terraformMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var terraformMountPath = "\"terraform\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "terraform")

            try
            {
                apiInstance.DeleteTerraformConfig(terraformMountPath);
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

<a name="deleteterraformrolename"></a>
# **DeleteTerraformRoleName**
> void DeleteTerraformRoleName (string name, string terraformMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var terraformMountPath = "\"terraform\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "terraform")

            try
            {
                apiInstance.DeleteTerraformRoleName(name, terraformMountPath);
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

<a name="deletetotpkeysname"></a>
# **DeleteTotpKeysName**
> void DeleteTotpKeysName (string name, string totpMountPath = null)

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
            var totpMountPath = "\"totp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "totp")

            try
            {
                // Manage the keys that can be created with this backend.
                apiInstance.DeleteTotpKeysName(name, totpMountPath);
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

<a name="deletetransitkeysname"></a>
# **DeleteTransitKeysName**
> void DeleteTransitKeysName (string name, string transitMountPath = null)

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
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Managed named encryption keys
                apiInstance.DeleteTransitKeysName(name, transitMountPath);
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

<a name="getadconfig"></a>
# **GetAdConfig**
> void GetAdConfig (string adMountPath = null)

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
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Configure the AD server to connect to, along with password options.
                apiInstance.GetAdConfig(adMountPath);
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

<a name="getadcredsname"></a>
# **GetAdCredsName**
> void GetAdCredsName (string name, string adMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                apiInstance.GetAdCredsName(name, adMountPath);
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

<a name="getadlibrary"></a>
# **GetAdLibrary**
> void GetAdLibrary (string list, string adMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                apiInstance.GetAdLibrary(list, adMountPath);
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

<a name="getadlibraryname"></a>
# **GetAdLibraryName**
> void GetAdLibraryName (string name, string adMountPath = null)

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
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Read a library set.
                apiInstance.GetAdLibraryName(name, adMountPath);
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

<a name="getadlibrarynamestatus"></a>
# **GetAdLibraryNameStatus**
> void GetAdLibraryNameStatus (string name, string adMountPath = null)

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
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Check the status of the service accounts in a library set.
                apiInstance.GetAdLibraryNameStatus(name, adMountPath);
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

<a name="getadroles"></a>
# **GetAdRoles**
> void GetAdRoles (string list, string adMountPath = null)

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
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // List the name of each role currently stored.
                apiInstance.GetAdRoles(list, adMountPath);
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

<a name="getadrolesname"></a>
# **GetAdRolesName**
> void GetAdRolesName (string name, string adMountPath = null)

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
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Manage roles to build links between Vault and Active Directory service accounts.
                apiInstance.GetAdRolesName(name, adMountPath);
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

<a name="getadrotateroot"></a>
# **GetAdRotateRoot**
> void GetAdRotateRoot (string adMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                apiInstance.GetAdRotateRoot(adMountPath);
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

<a name="getalicloudconfig"></a>
# **GetAlicloudConfig**
> void GetAlicloudConfig (string alicloudMountPath = null)

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
            var alicloudMountPath = "\"alicloud\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "alicloud")

            try
            {
                // Configure the access key and secret to use for RAM and STS calls.
                apiInstance.GetAlicloudConfig(alicloudMountPath);
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

<a name="getalicloudcredsname"></a>
# **GetAlicloudCredsName**
> void GetAlicloudCredsName (string name, string alicloudMountPath = null)

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
            var alicloudMountPath = "\"alicloud\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "alicloud")

            try
            {
                // Generate an API key or STS credential using the given role's configuration.'
                apiInstance.GetAlicloudCredsName(name, alicloudMountPath);
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

<a name="getalicloudrole"></a>
# **GetAlicloudRole**
> void GetAlicloudRole (string list, string alicloudMountPath = null)

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
            var alicloudMountPath = "\"alicloud\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "alicloud")

            try
            {
                // List the existing roles in this backend.
                apiInstance.GetAlicloudRole(list, alicloudMountPath);
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

<a name="getalicloudrolename"></a>
# **GetAlicloudRoleName**
> void GetAlicloudRoleName (string name, string alicloudMountPath = null)

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
            var alicloudMountPath = "\"alicloud\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "alicloud")

            try
            {
                // Read, write and reference policies and roles that API keys or STS credentials can be made for.
                apiInstance.GetAlicloudRoleName(name, alicloudMountPath);
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

<a name="getawsconfiglease"></a>
# **GetAwsConfigLease**
> void GetAwsConfigLease (string awsMountPath = null)

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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Configure the default lease information for generated credentials.
                apiInstance.GetAwsConfigLease(awsMountPath);
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

<a name="getawsconfigroot"></a>
# **GetAwsConfigRoot**
> void GetAwsConfigRoot (string awsMountPath = null)

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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Configure the root credentials that are used to manage IAM.
                apiInstance.GetAwsConfigRoot(awsMountPath);
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

<a name="getawscreds"></a>
# **GetAwsCreds**
> void GetAwsCreds (string awsMountPath = null)

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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Generate AWS credentials from a specific Vault role.
                apiInstance.GetAwsCreds(awsMountPath);
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

<a name="getawsroles"></a>
# **GetAwsRoles**
> void GetAwsRoles (string list, string awsMountPath = null)

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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // List the existing roles in this backend
                apiInstance.GetAwsRoles(list, awsMountPath);
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

<a name="getawsrolesname"></a>
# **GetAwsRolesName**
> void GetAwsRolesName (string name, string awsMountPath = null)

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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Read, write and reference IAM policies that access keys can be made for.
                apiInstance.GetAwsRolesName(name, awsMountPath);
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

<a name="getawsstsname"></a>
# **GetAwsStsName**
> void GetAwsStsName (string name, string awsMountPath = null)

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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Generate AWS credentials from a specific Vault role.
                apiInstance.GetAwsStsName(name, awsMountPath);
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

<a name="getazureconfig"></a>
# **GetAzureConfig**
> void GetAzureConfig (string azureMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                apiInstance.GetAzureConfig(azureMountPath);
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

<a name="getazurecredsrole"></a>
# **GetAzureCredsRole**
> void GetAzureCredsRole (string role, string azureMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                apiInstance.GetAzureCredsRole(role, azureMountPath);
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

<a name="getazureroles"></a>
# **GetAzureRoles**
> void GetAzureRoles (string list, string azureMountPath = null)

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
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                // List existing roles.
                apiInstance.GetAzureRoles(list, azureMountPath);
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

<a name="getazurerolesname"></a>
# **GetAzureRolesName**
> void GetAzureRolesName (string name, string azureMountPath = null)

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
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                // Manage the Vault roles used to generate Azure credentials.
                apiInstance.GetAzureRolesName(name, azureMountPath);
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

<a name="getconsulconfigaccess"></a>
# **GetConsulConfigAccess**
> void GetConsulConfigAccess (string consulMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var consulMountPath = "\"consul\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "consul")

            try
            {
                apiInstance.GetConsulConfigAccess(consulMountPath);
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

<a name="getconsulcredsrole"></a>
# **GetConsulCredsRole**
> void GetConsulCredsRole (string role, string consulMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var consulMountPath = "\"consul\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "consul")

            try
            {
                apiInstance.GetConsulCredsRole(role, consulMountPath);
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

<a name="getconsulroles"></a>
# **GetConsulRoles**
> void GetConsulRoles (string list, string consulMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var consulMountPath = "\"consul\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "consul")

            try
            {
                apiInstance.GetConsulRoles(list, consulMountPath);
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

<a name="getconsulrolesname"></a>
# **GetConsulRolesName**
> void GetConsulRolesName (string name, string consulMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var consulMountPath = "\"consul\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "consul")

            try
            {
                apiInstance.GetConsulRolesName(name, consulMountPath);
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

<a name="getcubbyholepath"></a>
# **GetCubbyholePath**
> void GetCubbyholePath (string path, string cubbyholeMountPath = null, string list = null)

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
            var cubbyholeMountPath = "\"cubbyhole\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cubbyhole")
            var list = "\"false\"";  // string | Return a list if `true` (optional)  (default to "false")

            try
            {
                // Retrieve the secret at the specified location.
                apiInstance.GetCubbyholePath(path, cubbyholeMountPath, list);
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
 **cubbyholeMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cubbyhole&quot;]
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

<a name="getgcpconfig"></a>
# **GetGcpConfig**
> void GetGcpConfig (string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GetGcpConfig(gcpMountPath);
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

<a name="getgcpkeyroleset"></a>
# **GetGcpKeyRoleset**
> void GetGcpKeyRoleset (string roleset, string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GetGcpKeyRoleset(roleset, gcpMountPath);
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

<a name="getgcprolesetname"></a>
# **GetGcpRolesetName**
> void GetGcpRolesetName (string name, string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GetGcpRolesetName(name, gcpMountPath);
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

<a name="getgcprolesetrolesetkey"></a>
# **GetGcpRolesetRolesetKey**
> void GetGcpRolesetRolesetKey (string roleset, string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GetGcpRolesetRolesetKey(roleset, gcpMountPath);
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

<a name="getgcprolesetrolesettoken"></a>
# **GetGcpRolesetRolesetToken**
> void GetGcpRolesetRolesetToken (string roleset, string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GetGcpRolesetRolesetToken(roleset, gcpMountPath);
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

<a name="getgcprolesets"></a>
# **GetGcpRolesets**
> void GetGcpRolesets (string list, string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GetGcpRolesets(list, gcpMountPath);
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

<a name="getgcpstaticaccountname"></a>
# **GetGcpStaticAccountName**
> void GetGcpStaticAccountName (string name, string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GetGcpStaticAccountName(name, gcpMountPath);
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

<a name="getgcpstaticaccountnamekey"></a>
# **GetGcpStaticAccountNameKey**
> void GetGcpStaticAccountNameKey (string name, string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GetGcpStaticAccountNameKey(name, gcpMountPath);
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

<a name="getgcpstaticaccountnametoken"></a>
# **GetGcpStaticAccountNameToken**
> void GetGcpStaticAccountNameToken (string name, string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GetGcpStaticAccountNameToken(name, gcpMountPath);
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

<a name="getgcpstaticaccounts"></a>
# **GetGcpStaticAccounts**
> void GetGcpStaticAccounts (string list, string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GetGcpStaticAccounts(list, gcpMountPath);
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

<a name="getgcptokenroleset"></a>
# **GetGcpTokenRoleset**
> void GetGcpTokenRoleset (string roleset, string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.GetGcpTokenRoleset(roleset, gcpMountPath);
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

<a name="getgcpkmsconfig"></a>
# **GetGcpkmsConfig**
> void GetGcpkmsConfig (string gcpkmsMountPath = null)

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
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Configure the GCP KMS secrets engine
                apiInstance.GetGcpkmsConfig(gcpkmsMountPath);
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

<a name="getgcpkmskeys"></a>
# **GetGcpkmsKeys**
> void GetGcpkmsKeys (string list, string gcpkmsMountPath = null)

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
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // List named keys
                apiInstance.GetGcpkmsKeys(list, gcpkmsMountPath);
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

<a name="getgcpkmskeysconfigkey"></a>
# **GetGcpkmsKeysConfigKey**
> void GetGcpkmsKeysConfigKey (string key, string gcpkmsMountPath = null)

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
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Configure the key in Vault
                apiInstance.GetGcpkmsKeysConfigKey(key, gcpkmsMountPath);
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

<a name="getgcpkmskeyskey"></a>
# **GetGcpkmsKeysKey**
> void GetGcpkmsKeysKey (string key, string gcpkmsMountPath = null)

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
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Interact with crypto keys in Vault and Google Cloud KMS
                apiInstance.GetGcpkmsKeysKey(key, gcpkmsMountPath);
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

<a name="getgcpkmspubkeykey"></a>
# **GetGcpkmsPubkeyKey**
> void GetGcpkmsPubkeyKey (string key, string gcpkmsMountPath = null)

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
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Retrieve the public key associated with the named key
                apiInstance.GetGcpkmsPubkeyKey(key, gcpkmsMountPath);
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

<a name="getkubernetesconfig"></a>
# **GetKubernetesConfig**
> void GetKubernetesConfig (string kubernetesMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                apiInstance.GetKubernetesConfig(kubernetesMountPath);
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

<a name="getkubernetesroles"></a>
# **GetKubernetesRoles**
> void GetKubernetesRoles (string list, string kubernetesMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                apiInstance.GetKubernetesRoles(list, kubernetesMountPath);
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

<a name="getkubernetesrolesname"></a>
# **GetKubernetesRolesName**
> void GetKubernetesRolesName (string name, string kubernetesMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                apiInstance.GetKubernetesRolesName(name, kubernetesMountPath);
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

<a name="getldapconfig"></a>
# **GetLdapConfig**
> void GetLdapConfig (string ldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetLdapConfigExample
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
                apiInstance.GetLdapConfig(ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetLdapConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getldapcredsname"></a>
# **GetLdapCredsName**
> void GetLdapCredsName (string name, string ldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetLdapCredsNameExample
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
                apiInstance.GetLdapCredsName(name, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetLdapCredsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getldaplibrary"></a>
# **GetLdapLibrary**
> void GetLdapLibrary (string list, string ldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetLdapLibraryExample
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
                apiInstance.GetLdapLibrary(list, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetLdapLibrary: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getldaplibraryname"></a>
# **GetLdapLibraryName**
> void GetLdapLibraryName (string name, string ldapMountPath = null)

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
    public class GetLdapLibraryNameExample
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
                apiInstance.GetLdapLibraryName(name, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetLdapLibraryName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getldaplibrarynamestatus"></a>
# **GetLdapLibraryNameStatus**
> void GetLdapLibraryNameStatus (string name, string ldapMountPath = null)

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
    public class GetLdapLibraryNameStatusExample
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
                apiInstance.GetLdapLibraryNameStatus(name, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetLdapLibraryNameStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getldaprole"></a>
# **GetLdapRole**
> void GetLdapRole (string list, string ldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetLdapRoleExample
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
                apiInstance.GetLdapRole(list, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetLdapRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getldaprolename"></a>
# **GetLdapRoleName**
> void GetLdapRoleName (string name, string ldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetLdapRoleNameExample
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
                apiInstance.GetLdapRoleName(name, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetLdapRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getldapstaticcredname"></a>
# **GetLdapStaticCredName**
> void GetLdapStaticCredName (string name, string ldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetLdapStaticCredNameExample
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
                apiInstance.GetLdapStaticCredName(name, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetLdapStaticCredName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getldapstaticrole"></a>
# **GetLdapStaticRole**
> void GetLdapStaticRole (string list, string ldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetLdapStaticRoleExample
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
                apiInstance.GetLdapStaticRole(list, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetLdapStaticRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getldapstaticrolename"></a>
# **GetLdapStaticRoleName**
> void GetLdapStaticRoleName (string name, string ldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetLdapStaticRoleNameExample
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
                apiInstance.GetLdapStaticRoleName(name, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetLdapStaticRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getmongodbatlasconfig"></a>
# **GetMongodbatlasConfig**
> void GetMongodbatlasConfig (string mongodbatlasMountPath = null)

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
            var mongodbatlasMountPath = "\"mongodbatlas\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "mongodbatlas")

            try
            {
                // Configure the  credentials that are used to manage Database Users.
                apiInstance.GetMongodbatlasConfig(mongodbatlasMountPath);
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

<a name="getmongodbatlascredsname"></a>
# **GetMongodbatlasCredsName**
> void GetMongodbatlasCredsName (string name, string mongodbatlasMountPath = null)

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
            var mongodbatlasMountPath = "\"mongodbatlas\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "mongodbatlas")

            try
            {
                // Generate MongoDB Atlas Programmatic API from a specific Vault role.
                apiInstance.GetMongodbatlasCredsName(name, mongodbatlasMountPath);
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

<a name="getmongodbatlasroles"></a>
# **GetMongodbatlasRoles**
> void GetMongodbatlasRoles (string list, string mongodbatlasMountPath = null)

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
            var mongodbatlasMountPath = "\"mongodbatlas\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "mongodbatlas")

            try
            {
                // List the existing roles in this backend
                apiInstance.GetMongodbatlasRoles(list, mongodbatlasMountPath);
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

<a name="getmongodbatlasrolesname"></a>
# **GetMongodbatlasRolesName**
> void GetMongodbatlasRolesName (string name, string mongodbatlasMountPath = null)

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
            var mongodbatlasMountPath = "\"mongodbatlas\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "mongodbatlas")

            try
            {
                // Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
                apiInstance.GetMongodbatlasRolesName(name, mongodbatlasMountPath);
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

<a name="getnomadconfigaccess"></a>
# **GetNomadConfigAccess**
> void GetNomadConfigAccess (string nomadMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var nomadMountPath = "\"nomad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "nomad")

            try
            {
                apiInstance.GetNomadConfigAccess(nomadMountPath);
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

<a name="getnomadconfiglease"></a>
# **GetNomadConfigLease**
> void GetNomadConfigLease (string nomadMountPath = null)

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
            var nomadMountPath = "\"nomad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "nomad")

            try
            {
                // Configure the lease parameters for generated tokens
                apiInstance.GetNomadConfigLease(nomadMountPath);
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

<a name="getnomadcredsname"></a>
# **GetNomadCredsName**
> void GetNomadCredsName (string name, string nomadMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var nomadMountPath = "\"nomad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "nomad")

            try
            {
                apiInstance.GetNomadCredsName(name, nomadMountPath);
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

<a name="getnomadrole"></a>
# **GetNomadRole**
> void GetNomadRole (string list, string nomadMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var nomadMountPath = "\"nomad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "nomad")

            try
            {
                apiInstance.GetNomadRole(list, nomadMountPath);
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

<a name="getnomadrolename"></a>
# **GetNomadRoleName**
> void GetNomadRoleName (string name, string nomadMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var nomadMountPath = "\"nomad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "nomad")

            try
            {
                apiInstance.GetNomadRoleName(name, nomadMountPath);
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

<a name="getopenldapconfig"></a>
# **GetOpenldapConfig**
> void GetOpenldapConfig (string openldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.GetOpenldapConfig(openldapMountPath);
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

<a name="getopenldapcredsname"></a>
# **GetOpenldapCredsName**
> void GetOpenldapCredsName (string name, string openldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.GetOpenldapCredsName(name, openldapMountPath);
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

<a name="getopenldaplibrary"></a>
# **GetOpenldapLibrary**
> void GetOpenldapLibrary (string list, string openldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetOpenldapLibraryExample
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
                apiInstance.GetOpenldapLibrary(list, openldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetOpenldapLibrary: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getopenldaplibraryname"></a>
# **GetOpenldapLibraryName**
> void GetOpenldapLibraryName (string name, string openldapMountPath = null)

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
    public class GetOpenldapLibraryNameExample
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
                apiInstance.GetOpenldapLibraryName(name, openldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetOpenldapLibraryName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getopenldaplibrarynamestatus"></a>
# **GetOpenldapLibraryNameStatus**
> void GetOpenldapLibraryNameStatus (string name, string openldapMountPath = null)

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
    public class GetOpenldapLibraryNameStatusExample
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
                apiInstance.GetOpenldapLibraryNameStatus(name, openldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetOpenldapLibraryNameStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getopenldaprole"></a>
# **GetOpenldapRole**
> void GetOpenldapRole (string list, string openldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.GetOpenldapRole(list, openldapMountPath);
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

<a name="getopenldaprolename"></a>
# **GetOpenldapRoleName**
> void GetOpenldapRoleName (string name, string openldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.GetOpenldapRoleName(name, openldapMountPath);
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

<a name="getopenldapstaticcredname"></a>
# **GetOpenldapStaticCredName**
> void GetOpenldapStaticCredName (string name, string openldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.GetOpenldapStaticCredName(name, openldapMountPath);
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

<a name="getopenldapstaticrole"></a>
# **GetOpenldapStaticRole**
> void GetOpenldapStaticRole (string list, string openldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.GetOpenldapStaticRole(list, openldapMountPath);
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

<a name="getopenldapstaticrolename"></a>
# **GetOpenldapStaticRoleName**
> void GetOpenldapStaticRoleName (string name, string openldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.GetOpenldapStaticRoleName(name, openldapMountPath);
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

<a name="getpkica"></a>
# **GetPkiCa**
> void GetPkiCa (string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.GetPkiCa(pkiMountPath);
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

<a name="getpkicachain"></a>
# **GetPkiCaChain**
> void GetPkiCaChain (string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.GetPkiCaChain(pkiMountPath);
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

<a name="getpkicapem"></a>
# **GetPkiCaPem**
> void GetPkiCaPem (string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.GetPkiCaPem(pkiMountPath);
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

<a name="getpkicertcachain"></a>
# **GetPkiCertCaChain**
> void GetPkiCertCaChain (string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.GetPkiCertCaChain(pkiMountPath);
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

<a name="getpkicertserial"></a>
# **GetPkiCertSerial**
> void GetPkiCertSerial (string serial, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.GetPkiCertSerial(serial, pkiMountPath);
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

<a name="getpkicertserialraw"></a>
# **GetPkiCertSerialRaw**
> void GetPkiCertSerialRaw (string serial, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.GetPkiCertSerialRaw(serial, pkiMountPath);
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

<a name="getpkicertserialrawpem"></a>
# **GetPkiCertSerialRawPem**
> void GetPkiCertSerialRawPem (string serial, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.GetPkiCertSerialRawPem(serial, pkiMountPath);
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

<a name="getpkicerts"></a>
# **GetPkiCerts**
> void GetPkiCerts (string list, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.GetPkiCerts(list, pkiMountPath);
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

<a name="getpkicertsrevoked"></a>
# **GetPkiCertsRevoked**
> void GetPkiCertsRevoked (string list, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetPkiCertsRevokedExample
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
                apiInstance.GetPkiCertsRevoked(list, pkiMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiCertsRevoked: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getpkiconfigautotidy"></a>
# **GetPkiConfigAutoTidy**
> void GetPkiConfigAutoTidy (string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetPkiConfigAutoTidyExample
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
                apiInstance.GetPkiConfigAutoTidy(pkiMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiConfigAutoTidy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getpkiconfigcrl"></a>
# **GetPkiConfigCrl**
> void GetPkiConfigCrl (string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.GetPkiConfigCrl(pkiMountPath);
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

<a name="getpkiconfigissuers"></a>
# **GetPkiConfigIssuers**
> void GetPkiConfigIssuers (string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.GetPkiConfigIssuers(pkiMountPath);
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

<a name="getpkiconfigkeys"></a>
# **GetPkiConfigKeys**
> void GetPkiConfigKeys (string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.GetPkiConfigKeys(pkiMountPath);
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

<a name="getpkiconfigurls"></a>
# **GetPkiConfigUrls**
> void GetPkiConfigUrls (string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.GetPkiConfigUrls(pkiMountPath);
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

<a name="getpkicrl"></a>
# **GetPkiCrl**
> void GetPkiCrl (string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.GetPkiCrl(pkiMountPath);
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

<a name="getpkicrlrotate"></a>
# **GetPkiCrlRotate**
> void GetPkiCrlRotate (string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.GetPkiCrlRotate(pkiMountPath);
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

<a name="getpkicrlrotatedelta"></a>
# **GetPkiCrlRotateDelta**
> void GetPkiCrlRotateDelta (string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetPkiCrlRotateDeltaExample
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
                apiInstance.GetPkiCrlRotateDelta(pkiMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiCrlRotateDelta: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getpkidelta"></a>
# **GetPkiDelta**
> void GetPkiDelta (string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetPkiDeltaExample
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
                apiInstance.GetPkiDelta(pkiMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiDelta: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getpkideltacrl"></a>
# **GetPkiDeltaCrl**
> void GetPkiDeltaCrl (string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetPkiDeltaCrlExample
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
                apiInstance.GetPkiDeltaCrl(pkiMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiDeltaCrl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getpkideltapem"></a>
# **GetPkiDeltaPem**
> void GetPkiDeltaPem (string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetPkiDeltaPemExample
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
                apiInstance.GetPkiDeltaPem(pkiMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiDeltaPem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getpkider"></a>
# **GetPkiDer**
> void GetPkiDer (string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.GetPkiDer(pkiMountPath);
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

<a name="getpkiissuerrefcrlpemderdeltapem"></a>
# **GetPkiIssuerRefCrlPemDerDeltaPem**
> void GetPkiIssuerRefCrlPemDerDeltaPem (string issuerRef, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetPkiIssuerRefCrlPemDerDeltaPemExample
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
                apiInstance.GetPkiIssuerRefCrlPemDerDeltaPem(issuerRef, pkiMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiIssuerRefCrlPemDerDeltaPem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="getpkiissuerrefderpem"></a>
# **GetPkiIssuerRefDerPem**
> void GetPkiIssuerRefDerPem (string issuerRef, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.GetPkiIssuerRefDerPem(issuerRef, pkiMountPath);
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

<a name="getpkiissuers"></a>
# **GetPkiIssuers**
> void GetPkiIssuers (string list, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.GetPkiIssuers(list, pkiMountPath);
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

<a name="getpkijson"></a>
# **GetPkiJson**
> void GetPkiJson (string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.GetPkiJson(pkiMountPath);
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

<a name="getpkikeykeyref"></a>
# **GetPkiKeyKeyRef**
> void GetPkiKeyKeyRef (string keyRef, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.GetPkiKeyKeyRef(keyRef, pkiMountPath);
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

<a name="getpkikeys"></a>
# **GetPkiKeys**
> void GetPkiKeys (string list, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.GetPkiKeys(list, pkiMountPath);
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

<a name="getpkiocspreq"></a>
# **GetPkiOcspReq**
> void GetPkiOcspReq (string req, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetPkiOcspReqExample
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
                apiInstance.GetPkiOcspReq(req, pkiMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiOcspReq: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getpkipem"></a>
# **GetPkiPem**
> void GetPkiPem (string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class GetPkiPemExample
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
                apiInstance.GetPkiPem(pkiMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetPkiPem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="getpkiroles"></a>
# **GetPkiRoles**
> void GetPkiRoles (string list, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.GetPkiRoles(list, pkiMountPath);
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

<a name="getpkirolesname"></a>
# **GetPkiRolesName**
> void GetPkiRolesName (string name, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.GetPkiRolesName(name, pkiMountPath);
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

<a name="getpkitidystatus"></a>
# **GetPkiTidyStatus**
> void GetPkiTidyStatus (string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.GetPkiTidyStatus(pkiMountPath);
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

<a name="getrabbitmqconfiglease"></a>
# **GetRabbitmqConfigLease**
> void GetRabbitmqConfigLease (string rabbitmqMountPath = null)

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
            var rabbitmqMountPath = "\"rabbitmq\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "rabbitmq")

            try
            {
                // Configure the lease parameters for generated credentials
                apiInstance.GetRabbitmqConfigLease(rabbitmqMountPath);
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

<a name="getrabbitmqcredsname"></a>
# **GetRabbitmqCredsName**
> void GetRabbitmqCredsName (string name, string rabbitmqMountPath = null)

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
            var rabbitmqMountPath = "\"rabbitmq\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "rabbitmq")

            try
            {
                // Request RabbitMQ credentials for a certain role.
                apiInstance.GetRabbitmqCredsName(name, rabbitmqMountPath);
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

<a name="getrabbitmqroles"></a>
# **GetRabbitmqRoles**
> void GetRabbitmqRoles (string list, string rabbitmqMountPath = null)

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
            var rabbitmqMountPath = "\"rabbitmq\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "rabbitmq")

            try
            {
                // Manage the roles that can be created with this backend.
                apiInstance.GetRabbitmqRoles(list, rabbitmqMountPath);
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

<a name="getrabbitmqrolesname"></a>
# **GetRabbitmqRolesName**
> void GetRabbitmqRolesName (string name, string rabbitmqMountPath = null)

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
            var rabbitmqMountPath = "\"rabbitmq\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "rabbitmq")

            try
            {
                // Manage the roles that can be created with this backend.
                apiInstance.GetRabbitmqRolesName(name, rabbitmqMountPath);
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

<a name="getsecretconfig"></a>
# **GetSecretConfig**
> void GetSecretConfig (string secretMountPath = null)

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
            var secretMountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Read the backend level settings.
                apiInstance.GetSecretConfig(secretMountPath);
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

<a name="getsecretdatapath"></a>
# **GetSecretDataPath**
> void GetSecretDataPath (string path, string secretMountPath = null)

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
            var secretMountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Write, Patch, Read, and Delete data in the Key-Value Store.
                apiInstance.GetSecretDataPath(path, secretMountPath);
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

<a name="getsecretmetadatapath"></a>
# **GetSecretMetadataPath**
> void GetSecretMetadataPath (string path, string secretMountPath = null, string list = null)

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
            var secretMountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")
            var list = "\"false\"";  // string | Return a list if `true` (optional)  (default to "false")

            try
            {
                // Configures settings for the KV store
                apiInstance.GetSecretMetadataPath(path, secretMountPath, list);
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
 **secretMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;secret&quot;]
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

<a name="getsecretpath"></a>
# **GetSecretPath**
> void GetSecretPath (string path, string secretMountPath = null, string list = null)

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
    public class GetSecretPathExample
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
            var list = "\"false\"";  // string | Return a list if `true` (optional)  (default to "false")

            try
            {
                // Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.
                apiInstance.GetSecretPath(path, secretMountPath, list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.GetSecretPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **secretMountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;secret&quot;]
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

<a name="getsecretsubkeyspath"></a>
# **GetSecretSubkeysPath**
> void GetSecretSubkeysPath (string path, string secretMountPath = null)

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
            var secretMountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Read the structure of a secret entry from the Key-Value store with the values removed.
                apiInstance.GetSecretSubkeysPath(path, secretMountPath);
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

<a name="getsshconfigca"></a>
# **GetSshConfigCa**
> void GetSshConfigCa (string sshMountPath = null)

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
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Set the SSH private key used for signing certificates.
                apiInstance.GetSshConfigCa(sshMountPath);
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

<a name="getsshconfigzeroaddress"></a>
# **GetSshConfigZeroaddress**
> void GetSshConfigZeroaddress (string sshMountPath = null)

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
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Assign zero address as default CIDR block for select roles.
                apiInstance.GetSshConfigZeroaddress(sshMountPath);
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

<a name="getsshpublickey"></a>
# **GetSshPublicKey**
> void GetSshPublicKey (string sshMountPath = null)

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
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Retrieve the public key.
                apiInstance.GetSshPublicKey(sshMountPath);
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

<a name="getsshroles"></a>
# **GetSshRoles**
> void GetSshRoles (string list, string sshMountPath = null)

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
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Manage the 'roles' that can be created with this backend.
                apiInstance.GetSshRoles(list, sshMountPath);
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

<a name="getsshrolesrole"></a>
# **GetSshRolesRole**
> void GetSshRolesRole (string role, string sshMountPath = null)

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
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Manage the 'roles' that can be created with this backend.
                apiInstance.GetSshRolesRole(role, sshMountPath);
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

<a name="getterraformconfig"></a>
# **GetTerraformConfig**
> void GetTerraformConfig (string terraformMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var terraformMountPath = "\"terraform\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "terraform")

            try
            {
                apiInstance.GetTerraformConfig(terraformMountPath);
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

<a name="getterraformcredsname"></a>
# **GetTerraformCredsName**
> void GetTerraformCredsName (string name, string terraformMountPath = null)

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
            var terraformMountPath = "\"terraform\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "terraform")

            try
            {
                // Generate a Terraform Cloud or Enterprise API token from a specific Vault role.
                apiInstance.GetTerraformCredsName(name, terraformMountPath);
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

<a name="getterraformrole"></a>
# **GetTerraformRole**
> void GetTerraformRole (string list, string terraformMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var terraformMountPath = "\"terraform\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "terraform")

            try
            {
                apiInstance.GetTerraformRole(list, terraformMountPath);
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

<a name="getterraformrolename"></a>
# **GetTerraformRoleName**
> void GetTerraformRoleName (string name, string terraformMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var terraformMountPath = "\"terraform\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "terraform")

            try
            {
                apiInstance.GetTerraformRoleName(name, terraformMountPath);
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

<a name="gettotpcodename"></a>
# **GetTotpCodeName**
> void GetTotpCodeName (string name, string totpMountPath = null)

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
            var totpMountPath = "\"totp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "totp")

            try
            {
                // Request time-based one-time use password or validate a password for a certain key .
                apiInstance.GetTotpCodeName(name, totpMountPath);
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

<a name="gettotpkeys"></a>
# **GetTotpKeys**
> void GetTotpKeys (string list, string totpMountPath = null)

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
            var totpMountPath = "\"totp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "totp")

            try
            {
                // Manage the keys that can be created with this backend.
                apiInstance.GetTotpKeys(list, totpMountPath);
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

<a name="gettotpkeysname"></a>
# **GetTotpKeysName**
> void GetTotpKeysName (string name, string totpMountPath = null)

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
            var totpMountPath = "\"totp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "totp")

            try
            {
                // Manage the keys that can be created with this backend.
                apiInstance.GetTotpKeysName(name, totpMountPath);
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

<a name="gettransitbackupname"></a>
# **GetTransitBackupName**
> void GetTransitBackupName (string name, string transitMountPath = null)

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
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Backup the named key
                apiInstance.GetTransitBackupName(name, transitMountPath);
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

<a name="gettransitcacheconfig"></a>
# **GetTransitCacheConfig**
> void GetTransitCacheConfig (string transitMountPath = null)

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
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Returns the size of the active cache
                apiInstance.GetTransitCacheConfig(transitMountPath);
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

<a name="gettransitexporttypename"></a>
# **GetTransitExportTypeName**
> void GetTransitExportTypeName (string name, string type, string transitMountPath = null)

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
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Export named encryption or signing key
                apiInstance.GetTransitExportTypeName(name, type, transitMountPath);
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

<a name="gettransitexporttypenameversion"></a>
# **GetTransitExportTypeNameVersion**
> void GetTransitExportTypeNameVersion (string name, string type, string version, string transitMountPath = null)

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
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Export named encryption or signing key
                apiInstance.GetTransitExportTypeNameVersion(name, type, version, transitMountPath);
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

<a name="gettransitkeys"></a>
# **GetTransitKeys**
> void GetTransitKeys (string list, string transitMountPath = null)

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
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Managed named encryption keys
                apiInstance.GetTransitKeys(list, transitMountPath);
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

<a name="gettransitkeysname"></a>
# **GetTransitKeysName**
> void GetTransitKeysName (string name, string transitMountPath = null)

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
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Managed named encryption keys
                apiInstance.GetTransitKeysName(name, transitMountPath);
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

<a name="gettransitwrappingkey"></a>
# **GetTransitWrappingKey**
> void GetTransitWrappingKey (string transitMountPath = null)

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
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Returns the public key to use for wrapping imported keys
                apiInstance.GetTransitWrappingKey(transitMountPath);
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

<a name="postadconfig"></a>
# **PostAdConfig**
> void PostAdConfig (AdConfigRequest adConfigRequest, string adMountPath = null)

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
            var adConfigRequest = new AdConfigRequest(); // AdConfigRequest | 
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Configure the AD server to connect to, along with password options.
                apiInstance.PostAdConfig(adConfigRequest, adMountPath);
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
 **adConfigRequest** | [**AdConfigRequest**](AdConfigRequest.md)|  | 
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

<a name="postadlibrarymanagenamecheckin"></a>
# **PostAdLibraryManageNameCheckIn**
> void PostAdLibraryManageNameCheckIn (string name, AdLibraryManageCheckInRequest adLibraryManageCheckInRequest, string adMountPath = null)

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
            var adLibraryManageCheckInRequest = new AdLibraryManageCheckInRequest(); // AdLibraryManageCheckInRequest | 
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Check service accounts in to the library.
                apiInstance.PostAdLibraryManageNameCheckIn(name, adLibraryManageCheckInRequest, adMountPath);
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
 **adLibraryManageCheckInRequest** | [**AdLibraryManageCheckInRequest**](AdLibraryManageCheckInRequest.md)|  | 
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

<a name="postadlibraryname"></a>
# **PostAdLibraryName**
> void PostAdLibraryName (string name, AdLibraryRequest adLibraryRequest, string adMountPath = null)

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
            var adLibraryRequest = new AdLibraryRequest(); // AdLibraryRequest | 
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Update a library set.
                apiInstance.PostAdLibraryName(name, adLibraryRequest, adMountPath);
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
 **adLibraryRequest** | [**AdLibraryRequest**](AdLibraryRequest.md)|  | 
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

<a name="postadlibrarynamecheckin"></a>
# **PostAdLibraryNameCheckIn**
> void PostAdLibraryNameCheckIn (string name, AdLibraryCheckInRequest adLibraryCheckInRequest, string adMountPath = null)

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
            var adLibraryCheckInRequest = new AdLibraryCheckInRequest(); // AdLibraryCheckInRequest | 
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Check service accounts in to the library.
                apiInstance.PostAdLibraryNameCheckIn(name, adLibraryCheckInRequest, adMountPath);
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
 **adLibraryCheckInRequest** | [**AdLibraryCheckInRequest**](AdLibraryCheckInRequest.md)|  | 
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

<a name="postadlibrarynamecheckout"></a>
# **PostAdLibraryNameCheckOut**
> void PostAdLibraryNameCheckOut (string name, AdLibraryCheckOutRequest adLibraryCheckOutRequest, string adMountPath = null)

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
            var adLibraryCheckOutRequest = new AdLibraryCheckOutRequest(); // AdLibraryCheckOutRequest | 
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Check a service account out from the library.
                apiInstance.PostAdLibraryNameCheckOut(name, adLibraryCheckOutRequest, adMountPath);
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
 **adLibraryCheckOutRequest** | [**AdLibraryCheckOutRequest**](AdLibraryCheckOutRequest.md)|  | 
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

<a name="postadrolesname"></a>
# **PostAdRolesName**
> void PostAdRolesName (string name, AdRolesRequest adRolesRequest, string adMountPath = null)

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
            var adRolesRequest = new AdRolesRequest(); // AdRolesRequest | 
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                // Manage roles to build links between Vault and Active Directory service accounts.
                apiInstance.PostAdRolesName(name, adRolesRequest, adMountPath);
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
 **adRolesRequest** | [**AdRolesRequest**](AdRolesRequest.md)|  | 
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

<a name="postadrotaterolename"></a>
# **PostAdRotateRoleName**
> void PostAdRotateRoleName (string name, string adMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                apiInstance.PostAdRotateRoleName(name, adMountPath);
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

<a name="postadrotateroot"></a>
# **PostAdRotateRoot**
> void PostAdRotateRoot (string adMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var adMountPath = "\"ad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ad")

            try
            {
                apiInstance.PostAdRotateRoot(adMountPath);
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

<a name="postalicloudconfig"></a>
# **PostAlicloudConfig**
> void PostAlicloudConfig (AlicloudConfigRequest alicloudConfigRequest, string alicloudMountPath = null)

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
            var alicloudConfigRequest = new AlicloudConfigRequest(); // AlicloudConfigRequest | 
            var alicloudMountPath = "\"alicloud\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "alicloud")

            try
            {
                // Configure the access key and secret to use for RAM and STS calls.
                apiInstance.PostAlicloudConfig(alicloudConfigRequest, alicloudMountPath);
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
 **alicloudConfigRequest** | [**AlicloudConfigRequest**](AlicloudConfigRequest.md)|  | 
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

<a name="postalicloudrolename"></a>
# **PostAlicloudRoleName**
> void PostAlicloudRoleName (string name, AlicloudRoleRequest alicloudRoleRequest, string alicloudMountPath = null)

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
            var alicloudRoleRequest = new AlicloudRoleRequest(); // AlicloudRoleRequest | 
            var alicloudMountPath = "\"alicloud\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "alicloud")

            try
            {
                // Read, write and reference policies and roles that API keys or STS credentials can be made for.
                apiInstance.PostAlicloudRoleName(name, alicloudRoleRequest, alicloudMountPath);
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

<a name="postawsconfiglease"></a>
# **PostAwsConfigLease**
> void PostAwsConfigLease (AwsConfigLeaseRequest awsConfigLeaseRequest, string awsMountPath = null)

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
            var awsConfigLeaseRequest = new AwsConfigLeaseRequest(); // AwsConfigLeaseRequest | 
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Configure the default lease information for generated credentials.
                apiInstance.PostAwsConfigLease(awsConfigLeaseRequest, awsMountPath);
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
 **awsConfigLeaseRequest** | [**AwsConfigLeaseRequest**](AwsConfigLeaseRequest.md)|  | 
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

<a name="postawsconfigroot"></a>
# **PostAwsConfigRoot**
> void PostAwsConfigRoot (AwsConfigRootRequest awsConfigRootRequest, string awsMountPath = null)

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
            var awsConfigRootRequest = new AwsConfigRootRequest(); // AwsConfigRootRequest | 
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Configure the root credentials that are used to manage IAM.
                apiInstance.PostAwsConfigRoot(awsConfigRootRequest, awsMountPath);
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
 **awsConfigRootRequest** | [**AwsConfigRootRequest**](AwsConfigRootRequest.md)|  | 
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

<a name="postawsconfigrotateroot"></a>
# **PostAwsConfigRotateRoot**
> void PostAwsConfigRotateRoot (string awsMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                apiInstance.PostAwsConfigRotateRoot(awsMountPath);
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

<a name="postawscreds"></a>
# **PostAwsCreds**
> void PostAwsCreds (AwsCredsRequest awsCredsRequest, string awsMountPath = null)

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
            var awsCredsRequest = new AwsCredsRequest(); // AwsCredsRequest | 
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Generate AWS credentials from a specific Vault role.
                apiInstance.PostAwsCreds(awsCredsRequest, awsMountPath);
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
 **awsCredsRequest** | [**AwsCredsRequest**](AwsCredsRequest.md)|  | 
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

<a name="postawsrolesname"></a>
# **PostAwsRolesName**
> void PostAwsRolesName (string name, AwsRolesRequest awsRolesRequest, string awsMountPath = null)

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
            var awsRolesRequest = new AwsRolesRequest(); // AwsRolesRequest | 
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Read, write and reference IAM policies that access keys can be made for.
                apiInstance.PostAwsRolesName(name, awsRolesRequest, awsMountPath);
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
 **awsRolesRequest** | [**AwsRolesRequest**](AwsRolesRequest.md)|  | 
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

<a name="postawsstsname"></a>
# **PostAwsStsName**
> void PostAwsStsName (string name, AwsStsRequest awsStsRequest, string awsMountPath = null)

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
            var awsStsRequest = new AwsStsRequest(); // AwsStsRequest | 
            var awsMountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Generate AWS credentials from a specific Vault role.
                apiInstance.PostAwsStsName(name, awsStsRequest, awsMountPath);
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
 **awsStsRequest** | [**AwsStsRequest**](AwsStsRequest.md)|  | 
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

<a name="postazureconfig"></a>
# **PostAzureConfig**
> void PostAzureConfig (AzureConfigRequest azureConfigRequest, string azureMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var azureConfigRequest = new AzureConfigRequest(); // AzureConfigRequest | 
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                apiInstance.PostAzureConfig(azureConfigRequest, azureMountPath);
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

<a name="postazurerolesname"></a>
# **PostAzureRolesName**
> void PostAzureRolesName (string name, AzureRolesRequest azureRolesRequest, string azureMountPath = null)

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
            var azureRolesRequest = new AzureRolesRequest(); // AzureRolesRequest | 
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                // Manage the Vault roles used to generate Azure credentials.
                apiInstance.PostAzureRolesName(name, azureRolesRequest, azureMountPath);
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
 **azureRolesRequest** | [**AzureRolesRequest**](AzureRolesRequest.md)|  | 
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

<a name="postazurerotateroot"></a>
# **PostAzureRotateRoot**
> void PostAzureRotateRoot (string azureMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var azureMountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                apiInstance.PostAzureRotateRoot(azureMountPath);
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

<a name="postconsulconfigaccess"></a>
# **PostConsulConfigAccess**
> void PostConsulConfigAccess (ConsulConfigAccessRequest consulConfigAccessRequest, string consulMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var consulConfigAccessRequest = new ConsulConfigAccessRequest(); // ConsulConfigAccessRequest | 
            var consulMountPath = "\"consul\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "consul")

            try
            {
                apiInstance.PostConsulConfigAccess(consulConfigAccessRequest, consulMountPath);
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
 **consulConfigAccessRequest** | [**ConsulConfigAccessRequest**](ConsulConfigAccessRequest.md)|  | 
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

<a name="postconsulrolesname"></a>
# **PostConsulRolesName**
> void PostConsulRolesName (string name, ConsulRolesRequest consulRolesRequest, string consulMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var consulRolesRequest = new ConsulRolesRequest(); // ConsulRolesRequest | 
            var consulMountPath = "\"consul\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "consul")

            try
            {
                apiInstance.PostConsulRolesName(name, consulRolesRequest, consulMountPath);
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
 **consulRolesRequest** | [**ConsulRolesRequest**](ConsulRolesRequest.md)|  | 
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

<a name="postcubbyholepath"></a>
# **PostCubbyholePath**
> void PostCubbyholePath (string path, string cubbyholeMountPath = null)

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
            var cubbyholeMountPath = "\"cubbyhole\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cubbyhole")

            try
            {
                // Store a secret at the specified location.
                apiInstance.PostCubbyholePath(path, cubbyholeMountPath);
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

<a name="postgcpconfig"></a>
# **PostGcpConfig**
> void PostGcpConfig (GcpConfigRequest gcpConfigRequest, string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpConfigRequest = new GcpConfigRequest(); // GcpConfigRequest | 
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.PostGcpConfig(gcpConfigRequest, gcpMountPath);
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

<a name="postgcpconfigrotateroot"></a>
# **PostGcpConfigRotateRoot**
> void PostGcpConfigRotateRoot (string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.PostGcpConfigRotateRoot(gcpMountPath);
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

<a name="postgcpkeyroleset"></a>
# **PostGcpKeyRoleset**
> void PostGcpKeyRoleset (string roleset, GcpKeyRequest gcpKeyRequest, string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpKeyRequest = new GcpKeyRequest(); // GcpKeyRequest | 
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.PostGcpKeyRoleset(roleset, gcpKeyRequest, gcpMountPath);
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
 **gcpKeyRequest** | [**GcpKeyRequest**](GcpKeyRequest.md)|  | 
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

<a name="postgcprolesetname"></a>
# **PostGcpRolesetName**
> void PostGcpRolesetName (string name, GcpRolesetRequest gcpRolesetRequest, string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpRolesetRequest = new GcpRolesetRequest(); // GcpRolesetRequest | 
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.PostGcpRolesetName(name, gcpRolesetRequest, gcpMountPath);
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
 **gcpRolesetRequest** | [**GcpRolesetRequest**](GcpRolesetRequest.md)|  | 
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

<a name="postgcprolesetnamerotate"></a>
# **PostGcpRolesetNameRotate**
> void PostGcpRolesetNameRotate (string name, string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.PostGcpRolesetNameRotate(name, gcpMountPath);
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

<a name="postgcprolesetnamerotatekey"></a>
# **PostGcpRolesetNameRotateKey**
> void PostGcpRolesetNameRotateKey (string name, string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.PostGcpRolesetNameRotateKey(name, gcpMountPath);
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

<a name="postgcprolesetrolesetkey"></a>
# **PostGcpRolesetRolesetKey**
> void PostGcpRolesetRolesetKey (string roleset, GcpRolesetKeyRequest gcpRolesetKeyRequest, string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpRolesetKeyRequest = new GcpRolesetKeyRequest(); // GcpRolesetKeyRequest | 
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.PostGcpRolesetRolesetKey(roleset, gcpRolesetKeyRequest, gcpMountPath);
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
 **gcpRolesetKeyRequest** | [**GcpRolesetKeyRequest**](GcpRolesetKeyRequest.md)|  | 
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

<a name="postgcprolesetrolesettoken"></a>
# **PostGcpRolesetRolesetToken**
> void PostGcpRolesetRolesetToken (string roleset, string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.PostGcpRolesetRolesetToken(roleset, gcpMountPath);
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

<a name="postgcpstaticaccountname"></a>
# **PostGcpStaticAccountName**
> void PostGcpStaticAccountName (string name, GcpStaticAccountRequest gcpStaticAccountRequest, string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpStaticAccountRequest = new GcpStaticAccountRequest(); // GcpStaticAccountRequest | 
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.PostGcpStaticAccountName(name, gcpStaticAccountRequest, gcpMountPath);
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
 **gcpStaticAccountRequest** | [**GcpStaticAccountRequest**](GcpStaticAccountRequest.md)|  | 
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

<a name="postgcpstaticaccountnamekey"></a>
# **PostGcpStaticAccountNameKey**
> void PostGcpStaticAccountNameKey (string name, GcpStaticAccountKeyRequest gcpStaticAccountKeyRequest, string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpStaticAccountKeyRequest = new GcpStaticAccountKeyRequest(); // GcpStaticAccountKeyRequest | 
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.PostGcpStaticAccountNameKey(name, gcpStaticAccountKeyRequest, gcpMountPath);
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
 **gcpStaticAccountKeyRequest** | [**GcpStaticAccountKeyRequest**](GcpStaticAccountKeyRequest.md)|  | 
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

<a name="postgcpstaticaccountnamerotatekey"></a>
# **PostGcpStaticAccountNameRotateKey**
> void PostGcpStaticAccountNameRotateKey (string name, string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.PostGcpStaticAccountNameRotateKey(name, gcpMountPath);
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

<a name="postgcpstaticaccountnametoken"></a>
# **PostGcpStaticAccountNameToken**
> void PostGcpStaticAccountNameToken (string name, string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.PostGcpStaticAccountNameToken(name, gcpMountPath);
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

<a name="postgcptokenroleset"></a>
# **PostGcpTokenRoleset**
> void PostGcpTokenRoleset (string roleset, string gcpMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var gcpMountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.PostGcpTokenRoleset(roleset, gcpMountPath);
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

<a name="postgcpkmsconfig"></a>
# **PostGcpkmsConfig**
> void PostGcpkmsConfig (GcpkmsConfigRequest gcpkmsConfigRequest, string gcpkmsMountPath = null)

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
            var gcpkmsConfigRequest = new GcpkmsConfigRequest(); // GcpkmsConfigRequest | 
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Configure the GCP KMS secrets engine
                apiInstance.PostGcpkmsConfig(gcpkmsConfigRequest, gcpkmsMountPath);
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
 **gcpkmsConfigRequest** | [**GcpkmsConfigRequest**](GcpkmsConfigRequest.md)|  | 
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

<a name="postgcpkmsdecryptkey"></a>
# **PostGcpkmsDecryptKey**
> void PostGcpkmsDecryptKey (string key, GcpkmsDecryptRequest gcpkmsDecryptRequest, string gcpkmsMountPath = null)

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
            var gcpkmsDecryptRequest = new GcpkmsDecryptRequest(); // GcpkmsDecryptRequest | 
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Decrypt a ciphertext value using a named key
                apiInstance.PostGcpkmsDecryptKey(key, gcpkmsDecryptRequest, gcpkmsMountPath);
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
 **gcpkmsDecryptRequest** | [**GcpkmsDecryptRequest**](GcpkmsDecryptRequest.md)|  | 
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

<a name="postgcpkmsencryptkey"></a>
# **PostGcpkmsEncryptKey**
> void PostGcpkmsEncryptKey (string key, GcpkmsEncryptRequest gcpkmsEncryptRequest, string gcpkmsMountPath = null)

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
            var gcpkmsEncryptRequest = new GcpkmsEncryptRequest(); // GcpkmsEncryptRequest | 
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Encrypt a plaintext value using a named key
                apiInstance.PostGcpkmsEncryptKey(key, gcpkmsEncryptRequest, gcpkmsMountPath);
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
 **gcpkmsEncryptRequest** | [**GcpkmsEncryptRequest**](GcpkmsEncryptRequest.md)|  | 
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

<a name="postgcpkmskeysconfigkey"></a>
# **PostGcpkmsKeysConfigKey**
> void PostGcpkmsKeysConfigKey (string key, GcpkmsKeysConfigRequest gcpkmsKeysConfigRequest, string gcpkmsMountPath = null)

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
            var gcpkmsKeysConfigRequest = new GcpkmsKeysConfigRequest(); // GcpkmsKeysConfigRequest | 
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Configure the key in Vault
                apiInstance.PostGcpkmsKeysConfigKey(key, gcpkmsKeysConfigRequest, gcpkmsMountPath);
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
 **gcpkmsKeysConfigRequest** | [**GcpkmsKeysConfigRequest**](GcpkmsKeysConfigRequest.md)|  | 
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

<a name="postgcpkmskeysderegisterkey"></a>
# **PostGcpkmsKeysDeregisterKey**
> void PostGcpkmsKeysDeregisterKey (string key, string gcpkmsMountPath = null)

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
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Deregister an existing key in Vault
                apiInstance.PostGcpkmsKeysDeregisterKey(key, gcpkmsMountPath);
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

<a name="postgcpkmskeyskey"></a>
# **PostGcpkmsKeysKey**
> void PostGcpkmsKeysKey (string key, GcpkmsKeysRequest gcpkmsKeysRequest, string gcpkmsMountPath = null)

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
            var gcpkmsKeysRequest = new GcpkmsKeysRequest(); // GcpkmsKeysRequest | 
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Interact with crypto keys in Vault and Google Cloud KMS
                apiInstance.PostGcpkmsKeysKey(key, gcpkmsKeysRequest, gcpkmsMountPath);
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
 **gcpkmsKeysRequest** | [**GcpkmsKeysRequest**](GcpkmsKeysRequest.md)|  | 
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

<a name="postgcpkmskeysregisterkey"></a>
# **PostGcpkmsKeysRegisterKey**
> void PostGcpkmsKeysRegisterKey (string key, GcpkmsKeysRegisterRequest gcpkmsKeysRegisterRequest, string gcpkmsMountPath = null)

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
            var gcpkmsKeysRegisterRequest = new GcpkmsKeysRegisterRequest(); // GcpkmsKeysRegisterRequest | 
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Register an existing crypto key in Google Cloud KMS
                apiInstance.PostGcpkmsKeysRegisterKey(key, gcpkmsKeysRegisterRequest, gcpkmsMountPath);
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
 **gcpkmsKeysRegisterRequest** | [**GcpkmsKeysRegisterRequest**](GcpkmsKeysRegisterRequest.md)|  | 
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

<a name="postgcpkmskeysrotatekey"></a>
# **PostGcpkmsKeysRotateKey**
> void PostGcpkmsKeysRotateKey (string key, string gcpkmsMountPath = null)

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
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Rotate a crypto key to a new primary version
                apiInstance.PostGcpkmsKeysRotateKey(key, gcpkmsMountPath);
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

<a name="postgcpkmskeystrimkey"></a>
# **PostGcpkmsKeysTrimKey**
> void PostGcpkmsKeysTrimKey (string key, string gcpkmsMountPath = null)

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
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Delete old crypto key versions from Google Cloud KMS
                apiInstance.PostGcpkmsKeysTrimKey(key, gcpkmsMountPath);
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

<a name="postgcpkmsreencryptkey"></a>
# **PostGcpkmsReencryptKey**
> void PostGcpkmsReencryptKey (string key, GcpkmsReencryptRequest gcpkmsReencryptRequest, string gcpkmsMountPath = null)

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
            var gcpkmsReencryptRequest = new GcpkmsReencryptRequest(); // GcpkmsReencryptRequest | 
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Re-encrypt existing ciphertext data to a new version
                apiInstance.PostGcpkmsReencryptKey(key, gcpkmsReencryptRequest, gcpkmsMountPath);
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
 **gcpkmsReencryptRequest** | [**GcpkmsReencryptRequest**](GcpkmsReencryptRequest.md)|  | 
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

<a name="postgcpkmssignkey"></a>
# **PostGcpkmsSignKey**
> void PostGcpkmsSignKey (string key, GcpkmsSignRequest gcpkmsSignRequest, string gcpkmsMountPath = null)

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
            var gcpkmsSignRequest = new GcpkmsSignRequest(); // GcpkmsSignRequest | 
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Signs a message or digest using a named key
                apiInstance.PostGcpkmsSignKey(key, gcpkmsSignRequest, gcpkmsMountPath);
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
 **gcpkmsSignRequest** | [**GcpkmsSignRequest**](GcpkmsSignRequest.md)|  | 
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

<a name="postgcpkmsverifykey"></a>
# **PostGcpkmsVerifyKey**
> void PostGcpkmsVerifyKey (string key, GcpkmsVerifyRequest gcpkmsVerifyRequest, string gcpkmsMountPath = null)

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
            var gcpkmsVerifyRequest = new GcpkmsVerifyRequest(); // GcpkmsVerifyRequest | 
            var gcpkmsMountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Verify a signature using a named key
                apiInstance.PostGcpkmsVerifyKey(key, gcpkmsVerifyRequest, gcpkmsMountPath);
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
 **gcpkmsVerifyRequest** | [**GcpkmsVerifyRequest**](GcpkmsVerifyRequest.md)|  | 
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

<a name="postkubernetesconfig"></a>
# **PostKubernetesConfig**
> void PostKubernetesConfig (KubernetesConfigRequest kubernetesConfigRequest, string kubernetesMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var kubernetesConfigRequest = new KubernetesConfigRequest(); // KubernetesConfigRequest | 
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                apiInstance.PostKubernetesConfig(kubernetesConfigRequest, kubernetesMountPath);
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

<a name="postkubernetescredsname"></a>
# **PostKubernetesCredsName**
> void PostKubernetesCredsName (string name, KubernetesCredsRequest kubernetesCredsRequest, string kubernetesMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var kubernetesCredsRequest = new KubernetesCredsRequest(); // KubernetesCredsRequest | 
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                apiInstance.PostKubernetesCredsName(name, kubernetesCredsRequest, kubernetesMountPath);
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
 **kubernetesCredsRequest** | [**KubernetesCredsRequest**](KubernetesCredsRequest.md)|  | 
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

<a name="postkubernetesrolesname"></a>
# **PostKubernetesRolesName**
> void PostKubernetesRolesName (string name, KubernetesRolesRequest kubernetesRolesRequest, string kubernetesMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var kubernetesRolesRequest = new KubernetesRolesRequest(); // KubernetesRolesRequest | 
            var kubernetesMountPath = "\"kubernetes\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "kubernetes")

            try
            {
                apiInstance.PostKubernetesRolesName(name, kubernetesRolesRequest, kubernetesMountPath);
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
 **kubernetesRolesRequest** | [**KubernetesRolesRequest**](KubernetesRolesRequest.md)|  | 
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

<a name="postldapconfig"></a>
# **PostLdapConfig**
> void PostLdapConfig (LdapConfigRequest ldapConfigRequest, string ldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostLdapConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var ldapConfigRequest = new LdapConfigRequest(); // LdapConfigRequest | 
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.PostLdapConfig(ldapConfigRequest, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostLdapConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postldaplibrarymanagenamecheckin"></a>
# **PostLdapLibraryManageNameCheckIn**
> void PostLdapLibraryManageNameCheckIn (string name, LdapLibraryManageCheckInRequest ldapLibraryManageCheckInRequest, string ldapMountPath = null)

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
    public class PostLdapLibraryManageNameCheckInExample
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
            var ldapLibraryManageCheckInRequest = new LdapLibraryManageCheckInRequest(); // LdapLibraryManageCheckInRequest | 
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                // Check service accounts in to the library.
                apiInstance.PostLdapLibraryManageNameCheckIn(name, ldapLibraryManageCheckInRequest, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostLdapLibraryManageNameCheckIn: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **ldapLibraryManageCheckInRequest** | [**LdapLibraryManageCheckInRequest**](LdapLibraryManageCheckInRequest.md)|  | 
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

<a name="postldaplibraryname"></a>
# **PostLdapLibraryName**
> void PostLdapLibraryName (string name, LdapLibraryRequest ldapLibraryRequest, string ldapMountPath = null)

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
    public class PostLdapLibraryNameExample
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
            var ldapLibraryRequest = new LdapLibraryRequest(); // LdapLibraryRequest | 
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                // Update a library set.
                apiInstance.PostLdapLibraryName(name, ldapLibraryRequest, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostLdapLibraryName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **ldapLibraryRequest** | [**LdapLibraryRequest**](LdapLibraryRequest.md)|  | 
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

<a name="postldaplibrarynamecheckin"></a>
# **PostLdapLibraryNameCheckIn**
> void PostLdapLibraryNameCheckIn (string name, LdapLibraryCheckInRequest ldapLibraryCheckInRequest, string ldapMountPath = null)

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
    public class PostLdapLibraryNameCheckInExample
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
            var ldapLibraryCheckInRequest = new LdapLibraryCheckInRequest(); // LdapLibraryCheckInRequest | 
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                // Check service accounts in to the library.
                apiInstance.PostLdapLibraryNameCheckIn(name, ldapLibraryCheckInRequest, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostLdapLibraryNameCheckIn: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **ldapLibraryCheckInRequest** | [**LdapLibraryCheckInRequest**](LdapLibraryCheckInRequest.md)|  | 
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

<a name="postldaplibrarynamecheckout"></a>
# **PostLdapLibraryNameCheckOut**
> void PostLdapLibraryNameCheckOut (string name, LdapLibraryCheckOutRequest ldapLibraryCheckOutRequest, string ldapMountPath = null)

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
    public class PostLdapLibraryNameCheckOutExample
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
            var ldapLibraryCheckOutRequest = new LdapLibraryCheckOutRequest(); // LdapLibraryCheckOutRequest | 
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                // Check a service account out from the library.
                apiInstance.PostLdapLibraryNameCheckOut(name, ldapLibraryCheckOutRequest, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostLdapLibraryNameCheckOut: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **ldapLibraryCheckOutRequest** | [**LdapLibraryCheckOutRequest**](LdapLibraryCheckOutRequest.md)|  | 
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

<a name="postldaprolename"></a>
# **PostLdapRoleName**
> void PostLdapRoleName (string name, LdapRoleRequest ldapRoleRequest, string ldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostLdapRoleNameExample
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
            var ldapRoleRequest = new LdapRoleRequest(); // LdapRoleRequest | 
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.PostLdapRoleName(name, ldapRoleRequest, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostLdapRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **ldapRoleRequest** | [**LdapRoleRequest**](LdapRoleRequest.md)|  | 
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

<a name="postldaprotaterolename"></a>
# **PostLdapRotateRoleName**
> void PostLdapRotateRoleName (string name, string ldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostLdapRotateRoleNameExample
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
                apiInstance.PostLdapRotateRoleName(name, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostLdapRotateRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postldaprotateroot"></a>
# **PostLdapRotateRoot**
> void PostLdapRotateRoot (string ldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostLdapRotateRootExample
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
                apiInstance.PostLdapRotateRoot(ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostLdapRotateRoot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postldapstaticrolename"></a>
# **PostLdapStaticRoleName**
> void PostLdapStaticRoleName (string name, LdapStaticRoleRequest ldapStaticRoleRequest, string ldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostLdapStaticRoleNameExample
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
            var ldapStaticRoleRequest = new LdapStaticRoleRequest(); // LdapStaticRoleRequest | 
            var ldapMountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.PostLdapStaticRoleName(name, ldapStaticRoleRequest, ldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostLdapStaticRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **ldapStaticRoleRequest** | [**LdapStaticRoleRequest**](LdapStaticRoleRequest.md)|  | 
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

<a name="postmongodbatlasconfig"></a>
# **PostMongodbatlasConfig**
> void PostMongodbatlasConfig (MongodbatlasConfigRequest mongodbatlasConfigRequest, string mongodbatlasMountPath = null)

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
            var mongodbatlasConfigRequest = new MongodbatlasConfigRequest(); // MongodbatlasConfigRequest | 
            var mongodbatlasMountPath = "\"mongodbatlas\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "mongodbatlas")

            try
            {
                // Configure the  credentials that are used to manage Database Users.
                apiInstance.PostMongodbatlasConfig(mongodbatlasConfigRequest, mongodbatlasMountPath);
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
 **mongodbatlasConfigRequest** | [**MongodbatlasConfigRequest**](MongodbatlasConfigRequest.md)|  | 
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

<a name="postmongodbatlascredsname"></a>
# **PostMongodbatlasCredsName**
> void PostMongodbatlasCredsName (string name, string mongodbatlasMountPath = null)

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
            var mongodbatlasMountPath = "\"mongodbatlas\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "mongodbatlas")

            try
            {
                // Generate MongoDB Atlas Programmatic API from a specific Vault role.
                apiInstance.PostMongodbatlasCredsName(name, mongodbatlasMountPath);
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

<a name="postmongodbatlasrolesname"></a>
# **PostMongodbatlasRolesName**
> void PostMongodbatlasRolesName (string name, MongodbatlasRolesRequest mongodbatlasRolesRequest, string mongodbatlasMountPath = null)

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
            var mongodbatlasRolesRequest = new MongodbatlasRolesRequest(); // MongodbatlasRolesRequest | 
            var mongodbatlasMountPath = "\"mongodbatlas\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "mongodbatlas")

            try
            {
                // Manage the roles used to generate MongoDB Atlas Programmatic API Keys.
                apiInstance.PostMongodbatlasRolesName(name, mongodbatlasRolesRequest, mongodbatlasMountPath);
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
 **mongodbatlasRolesRequest** | [**MongodbatlasRolesRequest**](MongodbatlasRolesRequest.md)|  | 
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

<a name="postnomadconfigaccess"></a>
# **PostNomadConfigAccess**
> void PostNomadConfigAccess (NomadConfigAccessRequest nomadConfigAccessRequest, string nomadMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var nomadConfigAccessRequest = new NomadConfigAccessRequest(); // NomadConfigAccessRequest | 
            var nomadMountPath = "\"nomad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "nomad")

            try
            {
                apiInstance.PostNomadConfigAccess(nomadConfigAccessRequest, nomadMountPath);
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
 **nomadConfigAccessRequest** | [**NomadConfigAccessRequest**](NomadConfigAccessRequest.md)|  | 
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

<a name="postnomadconfiglease"></a>
# **PostNomadConfigLease**
> void PostNomadConfigLease (NomadConfigLeaseRequest nomadConfigLeaseRequest, string nomadMountPath = null)

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
            var nomadConfigLeaseRequest = new NomadConfigLeaseRequest(); // NomadConfigLeaseRequest | 
            var nomadMountPath = "\"nomad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "nomad")

            try
            {
                // Configure the lease parameters for generated tokens
                apiInstance.PostNomadConfigLease(nomadConfigLeaseRequest, nomadMountPath);
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
 **nomadConfigLeaseRequest** | [**NomadConfigLeaseRequest**](NomadConfigLeaseRequest.md)|  | 
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

<a name="postnomadrolename"></a>
# **PostNomadRoleName**
> void PostNomadRoleName (string name, NomadRoleRequest nomadRoleRequest, string nomadMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var nomadRoleRequest = new NomadRoleRequest(); // NomadRoleRequest | 
            var nomadMountPath = "\"nomad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "nomad")

            try
            {
                apiInstance.PostNomadRoleName(name, nomadRoleRequest, nomadMountPath);
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
 **nomadRoleRequest** | [**NomadRoleRequest**](NomadRoleRequest.md)|  | 
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

<a name="postopenldapconfig"></a>
# **PostOpenldapConfig**
> void PostOpenldapConfig (OpenldapConfigRequest openldapConfigRequest, string openldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var openldapConfigRequest = new OpenldapConfigRequest(); // OpenldapConfigRequest | 
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.PostOpenldapConfig(openldapConfigRequest, openldapMountPath);
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
 **openldapConfigRequest** | [**OpenldapConfigRequest**](OpenldapConfigRequest.md)|  | 
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

<a name="postopenldaplibrarymanagenamecheckin"></a>
# **PostOpenldapLibraryManageNameCheckIn**
> void PostOpenldapLibraryManageNameCheckIn (string name, OpenldapLibraryManageCheckInRequest openldapLibraryManageCheckInRequest, string openldapMountPath = null)

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
    public class PostOpenldapLibraryManageNameCheckInExample
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
            var openldapLibraryManageCheckInRequest = new OpenldapLibraryManageCheckInRequest(); // OpenldapLibraryManageCheckInRequest | 
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                // Check service accounts in to the library.
                apiInstance.PostOpenldapLibraryManageNameCheckIn(name, openldapLibraryManageCheckInRequest, openldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostOpenldapLibraryManageNameCheckIn: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **openldapLibraryManageCheckInRequest** | [**OpenldapLibraryManageCheckInRequest**](OpenldapLibraryManageCheckInRequest.md)|  | 
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

<a name="postopenldaplibraryname"></a>
# **PostOpenldapLibraryName**
> void PostOpenldapLibraryName (string name, OpenldapLibraryRequest openldapLibraryRequest, string openldapMountPath = null)

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
    public class PostOpenldapLibraryNameExample
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
            var openldapLibraryRequest = new OpenldapLibraryRequest(); // OpenldapLibraryRequest | 
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                // Update a library set.
                apiInstance.PostOpenldapLibraryName(name, openldapLibraryRequest, openldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostOpenldapLibraryName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **openldapLibraryRequest** | [**OpenldapLibraryRequest**](OpenldapLibraryRequest.md)|  | 
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

<a name="postopenldaplibrarynamecheckin"></a>
# **PostOpenldapLibraryNameCheckIn**
> void PostOpenldapLibraryNameCheckIn (string name, OpenldapLibraryCheckInRequest openldapLibraryCheckInRequest, string openldapMountPath = null)

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
    public class PostOpenldapLibraryNameCheckInExample
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
            var openldapLibraryCheckInRequest = new OpenldapLibraryCheckInRequest(); // OpenldapLibraryCheckInRequest | 
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                // Check service accounts in to the library.
                apiInstance.PostOpenldapLibraryNameCheckIn(name, openldapLibraryCheckInRequest, openldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostOpenldapLibraryNameCheckIn: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **openldapLibraryCheckInRequest** | [**OpenldapLibraryCheckInRequest**](OpenldapLibraryCheckInRequest.md)|  | 
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

<a name="postopenldaplibrarynamecheckout"></a>
# **PostOpenldapLibraryNameCheckOut**
> void PostOpenldapLibraryNameCheckOut (string name, OpenldapLibraryCheckOutRequest openldapLibraryCheckOutRequest, string openldapMountPath = null)

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
    public class PostOpenldapLibraryNameCheckOutExample
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
            var openldapLibraryCheckOutRequest = new OpenldapLibraryCheckOutRequest(); // OpenldapLibraryCheckOutRequest | 
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                // Check a service account out from the library.
                apiInstance.PostOpenldapLibraryNameCheckOut(name, openldapLibraryCheckOutRequest, openldapMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostOpenldapLibraryNameCheckOut: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **openldapLibraryCheckOutRequest** | [**OpenldapLibraryCheckOutRequest**](OpenldapLibraryCheckOutRequest.md)|  | 
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

<a name="postopenldaprolename"></a>
# **PostOpenldapRoleName**
> void PostOpenldapRoleName (string name, OpenldapRoleRequest openldapRoleRequest, string openldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var openldapRoleRequest = new OpenldapRoleRequest(); // OpenldapRoleRequest | 
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.PostOpenldapRoleName(name, openldapRoleRequest, openldapMountPath);
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
 **openldapRoleRequest** | [**OpenldapRoleRequest**](OpenldapRoleRequest.md)|  | 
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

<a name="postopenldaprotaterolename"></a>
# **PostOpenldapRotateRoleName**
> void PostOpenldapRotateRoleName (string name, string openldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.PostOpenldapRotateRoleName(name, openldapMountPath);
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

<a name="postopenldaprotateroot"></a>
# **PostOpenldapRotateRoot**
> void PostOpenldapRotateRoot (string openldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.PostOpenldapRotateRoot(openldapMountPath);
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

<a name="postopenldapstaticrolename"></a>
# **PostOpenldapStaticRoleName**
> void PostOpenldapStaticRoleName (string name, OpenldapStaticRoleRequest openldapStaticRoleRequest, string openldapMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var openldapStaticRoleRequest = new OpenldapStaticRoleRequest(); // OpenldapStaticRoleRequest | 
            var openldapMountPath = "\"openldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "openldap")

            try
            {
                apiInstance.PostOpenldapStaticRoleName(name, openldapStaticRoleRequest, openldapMountPath);
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
 **openldapStaticRoleRequest** | [**OpenldapStaticRoleRequest**](OpenldapStaticRoleRequest.md)|  | 
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

<a name="postpkibundle"></a>
# **PostPkiBundle**
> void PostPkiBundle (PkiBundleRequest pkiBundleRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiBundleRequest = new PkiBundleRequest(); // PkiBundleRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiBundle(pkiBundleRequest, pkiMountPath);
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
 **pkiBundleRequest** | [**PkiBundleRequest**](PkiBundleRequest.md)|  | 
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

<a name="postpkicert"></a>
# **PostPkiCert**
> void PostPkiCert (PkiCertRequest pkiCertRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiCertRequest = new PkiCertRequest(); // PkiCertRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiCert(pkiCertRequest, pkiMountPath);
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
 **pkiCertRequest** | [**PkiCertRequest**](PkiCertRequest.md)|  | 
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

<a name="postpkiconfigautotidy"></a>
# **PostPkiConfigAutoTidy**
> void PostPkiConfigAutoTidy (PkiConfigAutoTidyRequest pkiConfigAutoTidyRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostPkiConfigAutoTidyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiConfigAutoTidyRequest = new PkiConfigAutoTidyRequest(); // PkiConfigAutoTidyRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiConfigAutoTidy(pkiConfigAutoTidyRequest, pkiMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiConfigAutoTidy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiConfigAutoTidyRequest** | [**PkiConfigAutoTidyRequest**](PkiConfigAutoTidyRequest.md)|  | 
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

<a name="postpkiconfigca"></a>
# **PostPkiConfigCa**
> void PostPkiConfigCa (PkiConfigCaRequest pkiConfigCaRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiConfigCaRequest = new PkiConfigCaRequest(); // PkiConfigCaRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiConfigCa(pkiConfigCaRequest, pkiMountPath);
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
 **pkiConfigCaRequest** | [**PkiConfigCaRequest**](PkiConfigCaRequest.md)|  | 
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

<a name="postpkiconfigcrl"></a>
# **PostPkiConfigCrl**
> void PostPkiConfigCrl (PkiConfigCrlRequest pkiConfigCrlRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiConfigCrlRequest = new PkiConfigCrlRequest(); // PkiConfigCrlRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiConfigCrl(pkiConfigCrlRequest, pkiMountPath);
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
 **pkiConfigCrlRequest** | [**PkiConfigCrlRequest**](PkiConfigCrlRequest.md)|  | 
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

<a name="postpkiconfigissuers"></a>
# **PostPkiConfigIssuers**
> void PostPkiConfigIssuers (PkiConfigIssuersRequest pkiConfigIssuersRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiConfigIssuersRequest = new PkiConfigIssuersRequest(); // PkiConfigIssuersRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiConfigIssuers(pkiConfigIssuersRequest, pkiMountPath);
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
 **pkiConfigIssuersRequest** | [**PkiConfigIssuersRequest**](PkiConfigIssuersRequest.md)|  | 
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

<a name="postpkiconfigkeys"></a>
# **PostPkiConfigKeys**
> void PostPkiConfigKeys (PkiConfigKeysRequest pkiConfigKeysRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiConfigKeysRequest = new PkiConfigKeysRequest(); // PkiConfigKeysRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiConfigKeys(pkiConfigKeysRequest, pkiMountPath);
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
 **pkiConfigKeysRequest** | [**PkiConfigKeysRequest**](PkiConfigKeysRequest.md)|  | 
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

<a name="postpkiconfigurls"></a>
# **PostPkiConfigUrls**
> void PostPkiConfigUrls (PkiConfigUrlsRequest pkiConfigUrlsRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiConfigUrlsRequest = new PkiConfigUrlsRequest(); // PkiConfigUrlsRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiConfigUrls(pkiConfigUrlsRequest, pkiMountPath);
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
 **pkiConfigUrlsRequest** | [**PkiConfigUrlsRequest**](PkiConfigUrlsRequest.md)|  | 
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

<a name="postpkiintermediatecrosssign"></a>
# **PostPkiIntermediateCrossSign**
> void PostPkiIntermediateCrossSign (PkiIntermediateCrossSignRequest pkiIntermediateCrossSignRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiIntermediateCrossSignRequest = new PkiIntermediateCrossSignRequest(); // PkiIntermediateCrossSignRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiIntermediateCrossSign(pkiIntermediateCrossSignRequest, pkiMountPath);
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
 **pkiIntermediateCrossSignRequest** | [**PkiIntermediateCrossSignRequest**](PkiIntermediateCrossSignRequest.md)|  | 
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

<a name="postpkiintermediategenerateexported"></a>
# **PostPkiIntermediateGenerateExported**
> void PostPkiIntermediateGenerateExported (string exported, PkiIntermediateGenerateRequest pkiIntermediateGenerateRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiIntermediateGenerateRequest = new PkiIntermediateGenerateRequest(); // PkiIntermediateGenerateRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiIntermediateGenerateExported(exported, pkiIntermediateGenerateRequest, pkiMountPath);
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
 **pkiIntermediateGenerateRequest** | [**PkiIntermediateGenerateRequest**](PkiIntermediateGenerateRequest.md)|  | 
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

<a name="postpkiintermediatesetsigned"></a>
# **PostPkiIntermediateSetSigned**
> void PostPkiIntermediateSetSigned (PkiIntermediateSetSignedRequest pkiIntermediateSetSignedRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiIntermediateSetSignedRequest = new PkiIntermediateSetSignedRequest(); // PkiIntermediateSetSignedRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiIntermediateSetSigned(pkiIntermediateSetSignedRequest, pkiMountPath);
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
 **pkiIntermediateSetSignedRequest** | [**PkiIntermediateSetSignedRequest**](PkiIntermediateSetSignedRequest.md)|  | 
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

<a name="postpkiinternalexported"></a>
# **PostPkiInternalExported**
> void PostPkiInternalExported (PkiInternalExportedRequest pkiInternalExportedRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiInternalExportedRequest = new PkiInternalExportedRequest(); // PkiInternalExportedRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiInternalExported(pkiInternalExportedRequest, pkiMountPath);
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
 **pkiInternalExportedRequest** | [**PkiInternalExportedRequest**](PkiInternalExportedRequest.md)|  | 
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

<a name="postpkiissuerole"></a>
# **PostPkiIssueRole**
> void PostPkiIssueRole (string role, PkiIssueRequest pkiIssueRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiIssueRequest = new PkiIssueRequest(); // PkiIssueRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiIssueRole(role, pkiIssueRequest, pkiMountPath);
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
 **pkiIssueRequest** | [**PkiIssueRequest**](PkiIssueRequest.md)|  | 
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

<a name="postpkiissuerissuerrefissuerole"></a>
# **PostPkiIssuerIssuerRefIssueRole**
> void PostPkiIssuerIssuerRefIssueRole (string issuerRef, string role, PkiIssuerIssueRequest pkiIssuerIssueRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiIssuerIssueRequest = new PkiIssuerIssueRequest(); // PkiIssuerIssueRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiIssuerIssuerRefIssueRole(issuerRef, role, pkiIssuerIssueRequest, pkiMountPath);
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
 **pkiIssuerIssueRequest** | [**PkiIssuerIssueRequest**](PkiIssuerIssueRequest.md)|  | 
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

<a name="postpkiissuerissuerrefrevoke"></a>
# **PostPkiIssuerIssuerRefRevoke**
> void PostPkiIssuerIssuerRefRevoke (string issuerRef, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostPkiIssuerIssuerRefRevokeExample
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
                apiInstance.PostPkiIssuerIssuerRefRevoke(issuerRef, pkiMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiIssuerIssuerRefRevoke: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postpkiissuerissuerrefsignintermediate"></a>
# **PostPkiIssuerIssuerRefSignIntermediate**
> void PostPkiIssuerIssuerRefSignIntermediate (string issuerRef, PkiIssuerSignIntermediateRequest pkiIssuerSignIntermediateRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiIssuerSignIntermediateRequest = new PkiIssuerSignIntermediateRequest(); // PkiIssuerSignIntermediateRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiIssuerIssuerRefSignIntermediate(issuerRef, pkiIssuerSignIntermediateRequest, pkiMountPath);
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
 **pkiIssuerSignIntermediateRequest** | [**PkiIssuerSignIntermediateRequest**](PkiIssuerSignIntermediateRequest.md)|  | 
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

<a name="postpkiissuerissuerrefsignrole"></a>
# **PostPkiIssuerIssuerRefSignRole**
> void PostPkiIssuerIssuerRefSignRole (string issuerRef, string role, PkiIssuerSignRequest pkiIssuerSignRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiIssuerSignRequest = new PkiIssuerSignRequest(); // PkiIssuerSignRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiIssuerIssuerRefSignRole(issuerRef, role, pkiIssuerSignRequest, pkiMountPath);
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
 **pkiIssuerSignRequest** | [**PkiIssuerSignRequest**](PkiIssuerSignRequest.md)|  | 
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

<a name="postpkiissuerissuerrefsignselfissued"></a>
# **PostPkiIssuerIssuerRefSignSelfIssued**
> void PostPkiIssuerIssuerRefSignSelfIssued (string issuerRef, PkiIssuerSignSelfIssuedRequest pkiIssuerSignSelfIssuedRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiIssuerSignSelfIssuedRequest = new PkiIssuerSignSelfIssuedRequest(); // PkiIssuerSignSelfIssuedRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiIssuerIssuerRefSignSelfIssued(issuerRef, pkiIssuerSignSelfIssuedRequest, pkiMountPath);
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
 **pkiIssuerSignSelfIssuedRequest** | [**PkiIssuerSignSelfIssuedRequest**](PkiIssuerSignSelfIssuedRequest.md)|  | 
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

<a name="postpkiissuerissuerrefsignverbatim"></a>
# **PostPkiIssuerIssuerRefSignVerbatim**
> void PostPkiIssuerIssuerRefSignVerbatim (string issuerRef, PkiIssuerSignVerbatimRequest pkiIssuerSignVerbatimRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiIssuerSignVerbatimRequest = new PkiIssuerSignVerbatimRequest(); // PkiIssuerSignVerbatimRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiIssuerIssuerRefSignVerbatim(issuerRef, pkiIssuerSignVerbatimRequest, pkiMountPath);
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
 **pkiIssuerSignVerbatimRequest** | [**PkiIssuerSignVerbatimRequest**](PkiIssuerSignVerbatimRequest.md)|  | 
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

<a name="postpkiissuerissuerrefsignverbatimrole"></a>
# **PostPkiIssuerIssuerRefSignVerbatimRole**
> void PostPkiIssuerIssuerRefSignVerbatimRole (string issuerRef, string role, PkiIssuerSignVerbatimRequest pkiIssuerSignVerbatimRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiIssuerSignVerbatimRequest = new PkiIssuerSignVerbatimRequest(); // PkiIssuerSignVerbatimRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiIssuerIssuerRefSignVerbatimRole(issuerRef, role, pkiIssuerSignVerbatimRequest, pkiMountPath);
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
 **pkiIssuerSignVerbatimRequest** | [**PkiIssuerSignVerbatimRequest**](PkiIssuerSignVerbatimRequest.md)|  | 
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

<a name="postpkiissuerrefderpem"></a>
# **PostPkiIssuerRefDerPem**
> void PostPkiIssuerRefDerPem (string issuerRef, PkiDerPemRequest pkiDerPemRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiDerPemRequest = new PkiDerPemRequest(); // PkiDerPemRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiIssuerRefDerPem(issuerRef, pkiDerPemRequest, pkiMountPath);
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
 **pkiDerPemRequest** | [**PkiDerPemRequest**](PkiDerPemRequest.md)|  | 
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

<a name="postpkiissuersgenerateintermediateexported"></a>
# **PostPkiIssuersGenerateIntermediateExported**
> void PostPkiIssuersGenerateIntermediateExported (string exported, PkiIssuersGenerateIntermediateRequest pkiIssuersGenerateIntermediateRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiIssuersGenerateIntermediateRequest = new PkiIssuersGenerateIntermediateRequest(); // PkiIssuersGenerateIntermediateRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiIssuersGenerateIntermediateExported(exported, pkiIssuersGenerateIntermediateRequest, pkiMountPath);
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
 **pkiIssuersGenerateIntermediateRequest** | [**PkiIssuersGenerateIntermediateRequest**](PkiIssuersGenerateIntermediateRequest.md)|  | 
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

<a name="postpkiissuersgeneraterootexported"></a>
# **PostPkiIssuersGenerateRootExported**
> void PostPkiIssuersGenerateRootExported (string exported, PkiIssuersGenerateRootRequest pkiIssuersGenerateRootRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiIssuersGenerateRootRequest = new PkiIssuersGenerateRootRequest(); // PkiIssuersGenerateRootRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiIssuersGenerateRootExported(exported, pkiIssuersGenerateRootRequest, pkiMountPath);
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
 **pkiIssuersGenerateRootRequest** | [**PkiIssuersGenerateRootRequest**](PkiIssuersGenerateRootRequest.md)|  | 
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

<a name="postpkijson"></a>
# **PostPkiJson**
> void PostPkiJson (PkiJsonRequest pkiJsonRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiJsonRequest = new PkiJsonRequest(); // PkiJsonRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiJson(pkiJsonRequest, pkiMountPath);
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
 **pkiJsonRequest** | [**PkiJsonRequest**](PkiJsonRequest.md)|  | 
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

<a name="postpkikeykeyref"></a>
# **PostPkiKeyKeyRef**
> void PostPkiKeyKeyRef (string keyRef, PkiKeyRequest pkiKeyRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiKeyRequest = new PkiKeyRequest(); // PkiKeyRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiKeyKeyRef(keyRef, pkiKeyRequest, pkiMountPath);
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
 **pkiKeyRequest** | [**PkiKeyRequest**](PkiKeyRequest.md)|  | 
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

<a name="postpkikeysimport"></a>
# **PostPkiKeysImport**
> void PostPkiKeysImport (PkiKeysImportRequest pkiKeysImportRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiKeysImportRequest = new PkiKeysImportRequest(); // PkiKeysImportRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiKeysImport(pkiKeysImportRequest, pkiMountPath);
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
 **pkiKeysImportRequest** | [**PkiKeysImportRequest**](PkiKeysImportRequest.md)|  | 
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

<a name="postpkikms"></a>
# **PostPkiKms**
> void PostPkiKms (PkiKmsRequest pkiKmsRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiKmsRequest = new PkiKmsRequest(); // PkiKmsRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiKms(pkiKmsRequest, pkiMountPath);
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
 **pkiKmsRequest** | [**PkiKmsRequest**](PkiKmsRequest.md)|  | 
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

<a name="postpkiocsp"></a>
# **PostPkiOcsp**
> void PostPkiOcsp (string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostPkiOcspExample
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
                apiInstance.PostPkiOcsp(pkiMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiOcsp: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="postpkirevoke"></a>
# **PostPkiRevoke**
> void PostPkiRevoke (PkiRevokeRequest pkiRevokeRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiRevokeRequest = new PkiRevokeRequest(); // PkiRevokeRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiRevoke(pkiRevokeRequest, pkiMountPath);
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
 **pkiRevokeRequest** | [**PkiRevokeRequest**](PkiRevokeRequest.md)|  | 
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

<a name="postpkirevokewithkey"></a>
# **PostPkiRevokeWithKey**
> void PostPkiRevokeWithKey (PkiRevokeWithKeyRequest pkiRevokeWithKeyRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostPkiRevokeWithKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var pkiRevokeWithKeyRequest = new PkiRevokeWithKeyRequest(); // PkiRevokeWithKeyRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiRevokeWithKey(pkiRevokeWithKeyRequest, pkiMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiRevokeWithKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiRevokeWithKeyRequest** | [**PkiRevokeWithKeyRequest**](PkiRevokeWithKeyRequest.md)|  | 
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

<a name="postpkirolesname"></a>
# **PostPkiRolesName**
> void PostPkiRolesName (string name, PkiRolesRequest pkiRolesRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiRolesRequest = new PkiRolesRequest(); // PkiRolesRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiRolesName(name, pkiRolesRequest, pkiMountPath);
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
 **pkiRolesRequest** | [**PkiRolesRequest**](PkiRolesRequest.md)|  | 
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

<a name="postpkirootgenerateexported"></a>
# **PostPkiRootGenerateExported**
> void PostPkiRootGenerateExported (string exported, PkiRootGenerateRequest pkiRootGenerateRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiRootGenerateRequest = new PkiRootGenerateRequest(); // PkiRootGenerateRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiRootGenerateExported(exported, pkiRootGenerateRequest, pkiMountPath);
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
 **pkiRootGenerateRequest** | [**PkiRootGenerateRequest**](PkiRootGenerateRequest.md)|  | 
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

<a name="postpkirootreplace"></a>
# **PostPkiRootReplace**
> void PostPkiRootReplace (PkiRootReplaceRequest pkiRootReplaceRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiRootReplaceRequest = new PkiRootReplaceRequest(); // PkiRootReplaceRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiRootReplace(pkiRootReplaceRequest, pkiMountPath);
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
 **pkiRootReplaceRequest** | [**PkiRootReplaceRequest**](PkiRootReplaceRequest.md)|  | 
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

<a name="postpkirootrotateexported"></a>
# **PostPkiRootRotateExported**
> void PostPkiRootRotateExported (string exported, PkiRootRotateRequest pkiRootRotateRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiRootRotateRequest = new PkiRootRotateRequest(); // PkiRootRotateRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiRootRotateExported(exported, pkiRootRotateRequest, pkiMountPath);
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
 **pkiRootRotateRequest** | [**PkiRootRotateRequest**](PkiRootRotateRequest.md)|  | 
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

<a name="postpkirootsignintermediate"></a>
# **PostPkiRootSignIntermediate**
> void PostPkiRootSignIntermediate (PkiRootSignIntermediateRequest pkiRootSignIntermediateRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiRootSignIntermediateRequest = new PkiRootSignIntermediateRequest(); // PkiRootSignIntermediateRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiRootSignIntermediate(pkiRootSignIntermediateRequest, pkiMountPath);
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
 **pkiRootSignIntermediateRequest** | [**PkiRootSignIntermediateRequest**](PkiRootSignIntermediateRequest.md)|  | 
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

<a name="postpkirootsignselfissued"></a>
# **PostPkiRootSignSelfIssued**
> void PostPkiRootSignSelfIssued (PkiRootSignSelfIssuedRequest pkiRootSignSelfIssuedRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiRootSignSelfIssuedRequest = new PkiRootSignSelfIssuedRequest(); // PkiRootSignSelfIssuedRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiRootSignSelfIssued(pkiRootSignSelfIssuedRequest, pkiMountPath);
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
 **pkiRootSignSelfIssuedRequest** | [**PkiRootSignSelfIssuedRequest**](PkiRootSignSelfIssuedRequest.md)|  | 
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

<a name="postpkisignrole"></a>
# **PostPkiSignRole**
> void PostPkiSignRole (string role, PkiSignRequest pkiSignRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiSignRequest = new PkiSignRequest(); // PkiSignRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiSignRole(role, pkiSignRequest, pkiMountPath);
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
 **pkiSignRequest** | [**PkiSignRequest**](PkiSignRequest.md)|  | 
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

<a name="postpkisignverbatim"></a>
# **PostPkiSignVerbatim**
> void PostPkiSignVerbatim (PkiSignVerbatimRequest pkiSignVerbatimRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiSignVerbatimRequest = new PkiSignVerbatimRequest(); // PkiSignVerbatimRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiSignVerbatim(pkiSignVerbatimRequest, pkiMountPath);
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
 **pkiSignVerbatimRequest** | [**PkiSignVerbatimRequest**](PkiSignVerbatimRequest.md)|  | 
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

<a name="postpkisignverbatimrole"></a>
# **PostPkiSignVerbatimRole**
> void PostPkiSignVerbatimRole (string role, PkiSignVerbatimRequest pkiSignVerbatimRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiSignVerbatimRequest = new PkiSignVerbatimRequest(); // PkiSignVerbatimRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiSignVerbatimRole(role, pkiSignVerbatimRequest, pkiMountPath);
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
 **pkiSignVerbatimRequest** | [**PkiSignVerbatimRequest**](PkiSignVerbatimRequest.md)|  | 
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

<a name="postpkitidy"></a>
# **PostPkiTidy**
> void PostPkiTidy (PkiTidyRequest pkiTidyRequest, string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var pkiTidyRequest = new PkiTidyRequest(); // PkiTidyRequest | 
            var pkiMountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.PostPkiTidy(pkiTidyRequest, pkiMountPath);
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
 **pkiTidyRequest** | [**PkiTidyRequest**](PkiTidyRequest.md)|  | 
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

<a name="postpkitidycancel"></a>
# **PostPkiTidyCancel**
> void PostPkiTidyCancel (string pkiMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostPkiTidyCancelExample
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
                apiInstance.PostPkiTidyCancel(pkiMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostPkiTidyCancel: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="postrabbitmqconfigconnection"></a>
# **PostRabbitmqConfigConnection**
> void PostRabbitmqConfigConnection (RabbitmqConfigConnectionRequest rabbitmqConfigConnectionRequest, string rabbitmqMountPath = null)

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
            var rabbitmqConfigConnectionRequest = new RabbitmqConfigConnectionRequest(); // RabbitmqConfigConnectionRequest | 
            var rabbitmqMountPath = "\"rabbitmq\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "rabbitmq")

            try
            {
                // Configure the connection URI, username, and password to talk to RabbitMQ management HTTP API.
                apiInstance.PostRabbitmqConfigConnection(rabbitmqConfigConnectionRequest, rabbitmqMountPath);
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
 **rabbitmqConfigConnectionRequest** | [**RabbitmqConfigConnectionRequest**](RabbitmqConfigConnectionRequest.md)|  | 
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

<a name="postrabbitmqconfiglease"></a>
# **PostRabbitmqConfigLease**
> void PostRabbitmqConfigLease (RabbitmqConfigLeaseRequest rabbitmqConfigLeaseRequest, string rabbitmqMountPath = null)

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
            var rabbitmqConfigLeaseRequest = new RabbitmqConfigLeaseRequest(); // RabbitmqConfigLeaseRequest | 
            var rabbitmqMountPath = "\"rabbitmq\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "rabbitmq")

            try
            {
                // Configure the lease parameters for generated credentials
                apiInstance.PostRabbitmqConfigLease(rabbitmqConfigLeaseRequest, rabbitmqMountPath);
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
 **rabbitmqConfigLeaseRequest** | [**RabbitmqConfigLeaseRequest**](RabbitmqConfigLeaseRequest.md)|  | 
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

<a name="postrabbitmqrolesname"></a>
# **PostRabbitmqRolesName**
> void PostRabbitmqRolesName (string name, RabbitmqRolesRequest rabbitmqRolesRequest, string rabbitmqMountPath = null)

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
            var rabbitmqRolesRequest = new RabbitmqRolesRequest(); // RabbitmqRolesRequest | 
            var rabbitmqMountPath = "\"rabbitmq\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "rabbitmq")

            try
            {
                // Manage the roles that can be created with this backend.
                apiInstance.PostRabbitmqRolesName(name, rabbitmqRolesRequest, rabbitmqMountPath);
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
 **rabbitmqRolesRequest** | [**RabbitmqRolesRequest**](RabbitmqRolesRequest.md)|  | 
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

<a name="postsecretconfig"></a>
# **PostSecretConfig**
> void PostSecretConfig (KvConfigRequest kvConfigRequest, string secretMountPath = null)

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
            var kvConfigRequest = new KvConfigRequest(); // KvConfigRequest | 
            var secretMountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Configure backend level settings that are applied to every key in the key-value store.
                apiInstance.PostSecretConfig(kvConfigRequest, secretMountPath);
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
 **kvConfigRequest** | [**KvConfigRequest**](KvConfigRequest.md)|  | 
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

<a name="postsecretdatapath"></a>
# **PostSecretDataPath**
> void PostSecretDataPath (string path, KvDataRequest kvDataRequest, string secretMountPath = null)

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
            var kvDataRequest = new KvDataRequest(); // KvDataRequest | 
            var secretMountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Write, Patch, Read, and Delete data in the Key-Value Store.
                apiInstance.PostSecretDataPath(path, kvDataRequest, secretMountPath);
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
 **kvDataRequest** | [**KvDataRequest**](KvDataRequest.md)|  | 
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

<a name="postsecretdeletepath"></a>
# **PostSecretDeletePath**
> void PostSecretDeletePath (string path, KvDeleteRequest kvDeleteRequest, string secretMountPath = null)

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
            var kvDeleteRequest = new KvDeleteRequest(); // KvDeleteRequest | 
            var secretMountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Marks one or more versions as deleted in the KV store.
                apiInstance.PostSecretDeletePath(path, kvDeleteRequest, secretMountPath);
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
 **kvDeleteRequest** | [**KvDeleteRequest**](KvDeleteRequest.md)|  | 
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

<a name="postsecretdestroypath"></a>
# **PostSecretDestroyPath**
> void PostSecretDestroyPath (string path, KvDestroyRequest kvDestroyRequest, string secretMountPath = null)

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
            var kvDestroyRequest = new KvDestroyRequest(); // KvDestroyRequest | 
            var secretMountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Permanently removes one or more versions in the KV store
                apiInstance.PostSecretDestroyPath(path, kvDestroyRequest, secretMountPath);
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
 **kvDestroyRequest** | [**KvDestroyRequest**](KvDestroyRequest.md)|  | 
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

<a name="postsecretmetadatapath"></a>
# **PostSecretMetadataPath**
> void PostSecretMetadataPath (string path, KvMetadataRequest kvMetadataRequest, string secretMountPath = null)

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
            var kvMetadataRequest = new KvMetadataRequest(); // KvMetadataRequest | 
            var secretMountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Configures settings for the KV store
                apiInstance.PostSecretMetadataPath(path, kvMetadataRequest, secretMountPath);
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
 **kvMetadataRequest** | [**KvMetadataRequest**](KvMetadataRequest.md)|  | 
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

<a name="postsecretpath"></a>
# **PostSecretPath**
> void PostSecretPath (string path, string secretMountPath = null)

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
    public class PostSecretPathExample
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
                // Pass-through secret storage to the storage backend, allowing you to read/write arbitrary data into secret storage.
                apiInstance.PostSecretPath(path, secretMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostSecretPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="postsecretundeletepath"></a>
# **PostSecretUndeletePath**
> void PostSecretUndeletePath (string path, KvUndeleteRequest kvUndeleteRequest, string secretMountPath = null)

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
            var kvUndeleteRequest = new KvUndeleteRequest(); // KvUndeleteRequest | 
            var secretMountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Undeletes one or more versions from the KV store.
                apiInstance.PostSecretUndeletePath(path, kvUndeleteRequest, secretMountPath);
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
 **kvUndeleteRequest** | [**KvUndeleteRequest**](KvUndeleteRequest.md)|  | 
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

<a name="postsshconfigca"></a>
# **PostSshConfigCa**
> void PostSshConfigCa (SshConfigCaRequest sshConfigCaRequest, string sshMountPath = null)

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
            var sshConfigCaRequest = new SshConfigCaRequest(); // SshConfigCaRequest | 
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Set the SSH private key used for signing certificates.
                apiInstance.PostSshConfigCa(sshConfigCaRequest, sshMountPath);
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
 **sshConfigCaRequest** | [**SshConfigCaRequest**](SshConfigCaRequest.md)|  | 
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

<a name="postsshconfigzeroaddress"></a>
# **PostSshConfigZeroaddress**
> void PostSshConfigZeroaddress (SshConfigZeroaddressRequest sshConfigZeroaddressRequest, string sshMountPath = null)

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
            var sshConfigZeroaddressRequest = new SshConfigZeroaddressRequest(); // SshConfigZeroaddressRequest | 
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Assign zero address as default CIDR block for select roles.
                apiInstance.PostSshConfigZeroaddress(sshConfigZeroaddressRequest, sshMountPath);
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
 **sshConfigZeroaddressRequest** | [**SshConfigZeroaddressRequest**](SshConfigZeroaddressRequest.md)|  | 
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

<a name="postsshcredsrole"></a>
# **PostSshCredsRole**
> void PostSshCredsRole (string role, SshCredsRequest sshCredsRequest, string sshMountPath = null)

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
            var sshCredsRequest = new SshCredsRequest(); // SshCredsRequest | 
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Creates a credential for establishing SSH connection with the remote host.
                apiInstance.PostSshCredsRole(role, sshCredsRequest, sshMountPath);
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
 **sshCredsRequest** | [**SshCredsRequest**](SshCredsRequest.md)|  | 
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

<a name="postsshissuerole"></a>
# **PostSshIssueRole**
> void PostSshIssueRole (string role, SshIssueRequest sshIssueRequest, string sshMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PostSshIssueRoleExample
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
            var sshIssueRequest = new SshIssueRequest(); // SshIssueRequest | 
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                apiInstance.PostSshIssueRole(role, sshIssueRequest, sshMountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.PostSshIssueRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **sshIssueRequest** | [**SshIssueRequest**](SshIssueRequest.md)|  | 
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

<a name="postsshkeyskeyname"></a>
# **PostSshKeysKeyName**
> void PostSshKeysKeyName (string keyName, SshKeysRequest sshKeysRequest, string sshMountPath = null)

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
            var sshKeysRequest = new SshKeysRequest(); // SshKeysRequest | 
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Register a shared private key with Vault.
                apiInstance.PostSshKeysKeyName(keyName, sshKeysRequest, sshMountPath);
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
 **sshKeysRequest** | [**SshKeysRequest**](SshKeysRequest.md)|  | 
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

<a name="postsshlookup"></a>
# **PostSshLookup**
> void PostSshLookup (SshLookupRequest sshLookupRequest, string sshMountPath = null)

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
            var sshLookupRequest = new SshLookupRequest(); // SshLookupRequest | 
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // List all the roles associated with the given IP address.
                apiInstance.PostSshLookup(sshLookupRequest, sshMountPath);
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
 **sshLookupRequest** | [**SshLookupRequest**](SshLookupRequest.md)|  | 
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

<a name="postsshrolesrole"></a>
# **PostSshRolesRole**
> void PostSshRolesRole (string role, SshRolesRequest sshRolesRequest, string sshMountPath = null)

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
            var sshRolesRequest = new SshRolesRequest(); // SshRolesRequest | 
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Manage the 'roles' that can be created with this backend.
                apiInstance.PostSshRolesRole(role, sshRolesRequest, sshMountPath);
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
 **sshRolesRequest** | [**SshRolesRequest**](SshRolesRequest.md)|  | 
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

<a name="postsshsignrole"></a>
# **PostSshSignRole**
> void PostSshSignRole (string role, SshSignRequest sshSignRequest, string sshMountPath = null)

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
            var sshSignRequest = new SshSignRequest(); // SshSignRequest | 
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Request signing an SSH key using a certain role with the provided details.
                apiInstance.PostSshSignRole(role, sshSignRequest, sshMountPath);
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
 **sshSignRequest** | [**SshSignRequest**](SshSignRequest.md)|  | 
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

<a name="postsshverify"></a>
# **PostSshVerify**
> void PostSshVerify (SshVerifyRequest sshVerifyRequest, string sshMountPath = null)

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
            var sshVerifyRequest = new SshVerifyRequest(); // SshVerifyRequest | 
            var sshMountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Validate the OTP provided by Vault SSH Agent.
                apiInstance.PostSshVerify(sshVerifyRequest, sshMountPath);
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
 **sshVerifyRequest** | [**SshVerifyRequest**](SshVerifyRequest.md)|  | 
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

<a name="postterraformconfig"></a>
# **PostTerraformConfig**
> void PostTerraformConfig (TerraformConfigRequest terraformConfigRequest, string terraformMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var terraformConfigRequest = new TerraformConfigRequest(); // TerraformConfigRequest | 
            var terraformMountPath = "\"terraform\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "terraform")

            try
            {
                apiInstance.PostTerraformConfig(terraformConfigRequest, terraformMountPath);
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
 **terraformConfigRequest** | [**TerraformConfigRequest**](TerraformConfigRequest.md)|  | 
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

<a name="postterraformcredsname"></a>
# **PostTerraformCredsName**
> void PostTerraformCredsName (string name, string terraformMountPath = null)

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
            var terraformMountPath = "\"terraform\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "terraform")

            try
            {
                // Generate a Terraform Cloud or Enterprise API token from a specific Vault role.
                apiInstance.PostTerraformCredsName(name, terraformMountPath);
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

<a name="postterraformrolename"></a>
# **PostTerraformRoleName**
> void PostTerraformRoleName (string name, TerraformRoleRequest terraformRoleRequest, string terraformMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var terraformRoleRequest = new TerraformRoleRequest(); // TerraformRoleRequest | 
            var terraformMountPath = "\"terraform\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "terraform")

            try
            {
                apiInstance.PostTerraformRoleName(name, terraformRoleRequest, terraformMountPath);
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
 **terraformRoleRequest** | [**TerraformRoleRequest**](TerraformRoleRequest.md)|  | 
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

<a name="postterraformrotaterolename"></a>
# **PostTerraformRotateRoleName**
> void PostTerraformRotateRoleName (string name, string terraformMountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

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
            var terraformMountPath = "\"terraform\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "terraform")

            try
            {
                apiInstance.PostTerraformRotateRoleName(name, terraformMountPath);
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

<a name="posttotpcodename"></a>
# **PostTotpCodeName**
> void PostTotpCodeName (string name, TotpCodeRequest totpCodeRequest, string totpMountPath = null)

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
            var totpCodeRequest = new TotpCodeRequest(); // TotpCodeRequest | 
            var totpMountPath = "\"totp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "totp")

            try
            {
                // Request time-based one-time use password or validate a password for a certain key .
                apiInstance.PostTotpCodeName(name, totpCodeRequest, totpMountPath);
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
 **totpCodeRequest** | [**TotpCodeRequest**](TotpCodeRequest.md)|  | 
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

<a name="posttotpkeysname"></a>
# **PostTotpKeysName**
> void PostTotpKeysName (string name, TotpKeysRequest totpKeysRequest, string totpMountPath = null)

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
            var totpKeysRequest = new TotpKeysRequest(); // TotpKeysRequest | 
            var totpMountPath = "\"totp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "totp")

            try
            {
                // Manage the keys that can be created with this backend.
                apiInstance.PostTotpKeysName(name, totpKeysRequest, totpMountPath);
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
 **totpKeysRequest** | [**TotpKeysRequest**](TotpKeysRequest.md)|  | 
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

<a name="posttransitcacheconfig"></a>
# **PostTransitCacheConfig**
> void PostTransitCacheConfig (TransitCacheConfigRequest transitCacheConfigRequest, string transitMountPath = null)

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
            var transitCacheConfigRequest = new TransitCacheConfigRequest(); // TransitCacheConfigRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Configures a new cache of the specified size
                apiInstance.PostTransitCacheConfig(transitCacheConfigRequest, transitMountPath);
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
 **transitCacheConfigRequest** | [**TransitCacheConfigRequest**](TransitCacheConfigRequest.md)|  | 
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

<a name="posttransitdatakeyplaintextname"></a>
# **PostTransitDatakeyPlaintextName**
> void PostTransitDatakeyPlaintextName (string name, string plaintext, TransitDatakeyRequest transitDatakeyRequest, string transitMountPath = null)

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
            var transitDatakeyRequest = new TransitDatakeyRequest(); // TransitDatakeyRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Generate a data key
                apiInstance.PostTransitDatakeyPlaintextName(name, plaintext, transitDatakeyRequest, transitMountPath);
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
 **transitDatakeyRequest** | [**TransitDatakeyRequest**](TransitDatakeyRequest.md)|  | 
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

<a name="posttransitdecryptname"></a>
# **PostTransitDecryptName**
> void PostTransitDecryptName (string name, TransitDecryptRequest transitDecryptRequest, string transitMountPath = null)

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
            var name = "name_example";  // string | Name of the key
            var transitDecryptRequest = new TransitDecryptRequest(); // TransitDecryptRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Decrypt a ciphertext value using a named key
                apiInstance.PostTransitDecryptName(name, transitDecryptRequest, transitMountPath);
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

<a name="posttransitencryptname"></a>
# **PostTransitEncryptName**
> void PostTransitEncryptName (string name, TransitEncryptRequest transitEncryptRequest, string transitMountPath = null)

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
            var name = "name_example";  // string | Name of the key
            var transitEncryptRequest = new TransitEncryptRequest(); // TransitEncryptRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Encrypt a plaintext value or a batch of plaintext blocks using a named key
                apiInstance.PostTransitEncryptName(name, transitEncryptRequest, transitMountPath);
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

<a name="posttransithash"></a>
# **PostTransitHash**
> void PostTransitHash (TransitHashRequest transitHashRequest, string transitMountPath = null)

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
            var transitHashRequest = new TransitHashRequest(); // TransitHashRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Generate a hash sum for input data
                apiInstance.PostTransitHash(transitHashRequest, transitMountPath);
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

<a name="posttransithashurlalgorithm"></a>
# **PostTransitHashUrlalgorithm**
> void PostTransitHashUrlalgorithm (string urlalgorithm, TransitHashRequest transitHashRequest, string transitMountPath = null)

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
            var transitHashRequest = new TransitHashRequest(); // TransitHashRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Generate a hash sum for input data
                apiInstance.PostTransitHashUrlalgorithm(urlalgorithm, transitHashRequest, transitMountPath);
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

<a name="posttransithmacname"></a>
# **PostTransitHmacName**
> void PostTransitHmacName (string name, TransitHmacRequest transitHmacRequest, string transitMountPath = null)

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
            var transitHmacRequest = new TransitHmacRequest(); // TransitHmacRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Generate an HMAC for input data using the named key
                apiInstance.PostTransitHmacName(name, transitHmacRequest, transitMountPath);
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
 **transitHmacRequest** | [**TransitHmacRequest**](TransitHmacRequest.md)|  | 
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

<a name="posttransithmacnameurlalgorithm"></a>
# **PostTransitHmacNameUrlalgorithm**
> void PostTransitHmacNameUrlalgorithm (string name, string urlalgorithm, TransitHmacRequest transitHmacRequest, string transitMountPath = null)

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
            var transitHmacRequest = new TransitHmacRequest(); // TransitHmacRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Generate an HMAC for input data using the named key
                apiInstance.PostTransitHmacNameUrlalgorithm(name, urlalgorithm, transitHmacRequest, transitMountPath);
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
 **transitHmacRequest** | [**TransitHmacRequest**](TransitHmacRequest.md)|  | 
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

<a name="posttransitkeysname"></a>
# **PostTransitKeysName**
> void PostTransitKeysName (string name, TransitKeysRequest transitKeysRequest, string transitMountPath = null)

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
            var transitKeysRequest = new TransitKeysRequest(); // TransitKeysRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Managed named encryption keys
                apiInstance.PostTransitKeysName(name, transitKeysRequest, transitMountPath);
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
 **transitKeysRequest** | [**TransitKeysRequest**](TransitKeysRequest.md)|  | 
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

<a name="posttransitkeysnameconfig"></a>
# **PostTransitKeysNameConfig**
> void PostTransitKeysNameConfig (string name, TransitKeysConfigRequest transitKeysConfigRequest, string transitMountPath = null)

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
            var transitKeysConfigRequest = new TransitKeysConfigRequest(); // TransitKeysConfigRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Configure a named encryption key
                apiInstance.PostTransitKeysNameConfig(name, transitKeysConfigRequest, transitMountPath);
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
 **transitKeysConfigRequest** | [**TransitKeysConfigRequest**](TransitKeysConfigRequest.md)|  | 
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

<a name="posttransitkeysnameimport"></a>
# **PostTransitKeysNameImport**
> void PostTransitKeysNameImport (string name, TransitKeysImportRequest transitKeysImportRequest, string transitMountPath = null)

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
            var transitKeysImportRequest = new TransitKeysImportRequest(); // TransitKeysImportRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Imports an externally-generated key into a new transit key
                apiInstance.PostTransitKeysNameImport(name, transitKeysImportRequest, transitMountPath);
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
 **transitKeysImportRequest** | [**TransitKeysImportRequest**](TransitKeysImportRequest.md)|  | 
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

<a name="posttransitkeysnameimportversion"></a>
# **PostTransitKeysNameImportVersion**
> void PostTransitKeysNameImportVersion (string name, TransitKeysImportVersionRequest transitKeysImportVersionRequest, string transitMountPath = null)

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
            var transitKeysImportVersionRequest = new TransitKeysImportVersionRequest(); // TransitKeysImportVersionRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Imports an externally-generated key into an existing imported key
                apiInstance.PostTransitKeysNameImportVersion(name, transitKeysImportVersionRequest, transitMountPath);
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
 **transitKeysImportVersionRequest** | [**TransitKeysImportVersionRequest**](TransitKeysImportVersionRequest.md)|  | 
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

<a name="posttransitkeysnamerotate"></a>
# **PostTransitKeysNameRotate**
> void PostTransitKeysNameRotate (string name, string transitMountPath = null)

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
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Rotate named encryption key
                apiInstance.PostTransitKeysNameRotate(name, transitMountPath);
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

<a name="posttransitkeysnametrim"></a>
# **PostTransitKeysNameTrim**
> void PostTransitKeysNameTrim (string name, TransitKeysTrimRequest transitKeysTrimRequest, string transitMountPath = null)

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
            var transitKeysTrimRequest = new TransitKeysTrimRequest(); // TransitKeysTrimRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Trim key versions of a named key
                apiInstance.PostTransitKeysNameTrim(name, transitKeysTrimRequest, transitMountPath);
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
 **transitKeysTrimRequest** | [**TransitKeysTrimRequest**](TransitKeysTrimRequest.md)|  | 
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

<a name="posttransitrandom"></a>
# **PostTransitRandom**
> void PostTransitRandom (TransitRandomRequest transitRandomRequest, string transitMountPath = null)

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
            var transitRandomRequest = new TransitRandomRequest(); // TransitRandomRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Generate random bytes
                apiInstance.PostTransitRandom(transitRandomRequest, transitMountPath);
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
 **transitRandomRequest** | [**TransitRandomRequest**](TransitRandomRequest.md)|  | 
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

<a name="posttransitrandomsource"></a>
# **PostTransitRandomSource**
> void PostTransitRandomSource (string source, TransitRandomRequest transitRandomRequest, string transitMountPath = null)

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
            var transitRandomRequest = new TransitRandomRequest(); // TransitRandomRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Generate random bytes
                apiInstance.PostTransitRandomSource(source, transitRandomRequest, transitMountPath);
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
 **transitRandomRequest** | [**TransitRandomRequest**](TransitRandomRequest.md)|  | 
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

<a name="posttransitrandomsourceurlbytes"></a>
# **PostTransitRandomSourceUrlbytes**
> void PostTransitRandomSourceUrlbytes (string source, string urlbytes, TransitRandomRequest transitRandomRequest, string transitMountPath = null)

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
            var transitRandomRequest = new TransitRandomRequest(); // TransitRandomRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Generate random bytes
                apiInstance.PostTransitRandomSourceUrlbytes(source, urlbytes, transitRandomRequest, transitMountPath);
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
 **transitRandomRequest** | [**TransitRandomRequest**](TransitRandomRequest.md)|  | 
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

<a name="posttransitrandomurlbytes"></a>
# **PostTransitRandomUrlbytes**
> void PostTransitRandomUrlbytes (string urlbytes, TransitRandomRequest transitRandomRequest, string transitMountPath = null)

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
            var transitRandomRequest = new TransitRandomRequest(); // TransitRandomRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Generate random bytes
                apiInstance.PostTransitRandomUrlbytes(urlbytes, transitRandomRequest, transitMountPath);
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
 **transitRandomRequest** | [**TransitRandomRequest**](TransitRandomRequest.md)|  | 
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

<a name="posttransitrestore"></a>
# **PostTransitRestore**
> void PostTransitRestore (TransitRestoreRequest transitRestoreRequest, string transitMountPath = null)

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
            var transitRestoreRequest = new TransitRestoreRequest(); // TransitRestoreRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Restore the named key
                apiInstance.PostTransitRestore(transitRestoreRequest, transitMountPath);
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

<a name="posttransitrestorename"></a>
# **PostTransitRestoreName**
> void PostTransitRestoreName (string name, TransitRestoreRequest transitRestoreRequest, string transitMountPath = null)

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
            var transitRestoreRequest = new TransitRestoreRequest(); // TransitRestoreRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Restore the named key
                apiInstance.PostTransitRestoreName(name, transitRestoreRequest, transitMountPath);
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

<a name="posttransitrewrapname"></a>
# **PostTransitRewrapName**
> void PostTransitRewrapName (string name, TransitRewrapRequest transitRewrapRequest, string transitMountPath = null)

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
            var transitRewrapRequest = new TransitRewrapRequest(); // TransitRewrapRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Rewrap ciphertext
                apiInstance.PostTransitRewrapName(name, transitRewrapRequest, transitMountPath);
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

<a name="posttransitsignname"></a>
# **PostTransitSignName**
> void PostTransitSignName (string name, TransitSignRequest transitSignRequest, string transitMountPath = null)

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
            var transitSignRequest = new TransitSignRequest(); // TransitSignRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Generate a signature for input data using the named key
                apiInstance.PostTransitSignName(name, transitSignRequest, transitMountPath);
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

<a name="posttransitsignnameurlalgorithm"></a>
# **PostTransitSignNameUrlalgorithm**
> void PostTransitSignNameUrlalgorithm (string name, string urlalgorithm, TransitSignRequest transitSignRequest, string transitMountPath = null)

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
            var transitSignRequest = new TransitSignRequest(); // TransitSignRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Generate a signature for input data using the named key
                apiInstance.PostTransitSignNameUrlalgorithm(name, urlalgorithm, transitSignRequest, transitMountPath);
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

<a name="posttransitverifyname"></a>
# **PostTransitVerifyName**
> void PostTransitVerifyName (string name, TransitVerifyRequest transitVerifyRequest, string transitMountPath = null)

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
            var transitVerifyRequest = new TransitVerifyRequest(); // TransitVerifyRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Verify a signature or HMAC for input data created using the named key
                apiInstance.PostTransitVerifyName(name, transitVerifyRequest, transitMountPath);
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

<a name="posttransitverifynameurlalgorithm"></a>
# **PostTransitVerifyNameUrlalgorithm**
> void PostTransitVerifyNameUrlalgorithm (string name, string urlalgorithm, TransitVerifyRequest transitVerifyRequest, string transitMountPath = null)

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
            var transitVerifyRequest = new TransitVerifyRequest(); // TransitVerifyRequest | 
            var transitMountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Verify a signature or HMAC for input data created using the named key
                apiInstance.PostTransitVerifyNameUrlalgorithm(name, urlalgorithm, transitVerifyRequest, transitMountPath);
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

