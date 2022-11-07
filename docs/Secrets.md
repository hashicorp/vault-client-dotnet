# Vault.Api.Secrets

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAwsRolesName**](Secrets.md#deleteawsrolesname) | **DELETE** /{mount_path}/roles/{name} | Read, write and reference IAM policies that access keys can be made for.
[**DeleteCubbyholePath**](Secrets.md#deletecubbyholepath) | **DELETE** /{mount_path}/{path} | Deletes the secret at the specified location.
[**DeleteGcpRolesetName**](Secrets.md#deletegcprolesetname) | **DELETE** /{mount_path}/roleset/{name} | 
[**DeleteGcpStaticAccountName**](Secrets.md#deletegcpstaticaccountname) | **DELETE** /{mount_path}/static-account/{name} | 
[**DeleteGcpkmsKeysDeregisterKey**](Secrets.md#deletegcpkmskeysderegisterkey) | **DELETE** /{mount_path}/keys/deregister/{key} | Deregister an existing key in Vault
[**DeleteGcpkmsKeysKey**](Secrets.md#deletegcpkmskeyskey) | **DELETE** /{mount_path}/keys/{key} | Interact with crypto keys in Vault and Google Cloud KMS
[**DeleteGcpkmsKeysTrimKey**](Secrets.md#deletegcpkmskeystrimkey) | **DELETE** /{mount_path}/keys/trim/{key} | Delete old crypto key versions from Google Cloud KMS
[**DeleteLdapLibraryName**](Secrets.md#deleteldaplibraryname) | **DELETE** /{mount_path}/library/{name} | Delete a library set.
[**DeleteLdapRoleName**](Secrets.md#deleteldaprolename) | **DELETE** /{mount_path}/role/{name} | 
[**DeleteLdapStaticRoleName**](Secrets.md#deleteldapstaticrolename) | **DELETE** /{mount_path}/static-role/{name} | 
[**DeleteNomadConfigAccess**](Secrets.md#deletenomadconfigaccess) | **DELETE** /{mount_path}/config/access | 
[**DeletePkiIssuerRefDerPem**](Secrets.md#deletepkiissuerrefderpem) | **DELETE** /{mount_path}/{issuer_ref}/der|/pem | 
[**DeletePkiJson**](Secrets.md#deletepkijson) | **DELETE** /{mount_path}//json | 
[**DeletePkiKeyKeyRef**](Secrets.md#deletepkikeykeyref) | **DELETE** /{mount_path}/key/{key_ref} | 
[**DeletePkiRoot**](Secrets.md#deletepkiroot) | **DELETE** /{mount_path}/root | 
[**DeleteSecretDataPath**](Secrets.md#deletesecretdatapath) | **DELETE** /{mount_path}/data/{path} | Write, Patch, Read, and Delete data in the Key-Value Store.
[**DeleteSecretMetadataPath**](Secrets.md#deletesecretmetadatapath) | **DELETE** /{mount_path}/metadata/{path} | Configures settings for the KV store
[**DeleteSshConfigZeroaddress**](Secrets.md#deletesshconfigzeroaddress) | **DELETE** /{mount_path}/config/zeroaddress | Assign zero address as default CIDR block for select roles.
[**DeleteSshKeysKeyName**](Secrets.md#deletesshkeyskeyname) | **DELETE** /{mount_path}/keys/{key_name} | Register a shared private key with Vault.
[**DeleteSshRolesRole**](Secrets.md#deletesshrolesrole) | **DELETE** /{mount_path}/roles/{role} | Manage the &#39;roles&#39; that can be created with this backend.
[**DeleteTotpKeysName**](Secrets.md#deletetotpkeysname) | **DELETE** /{mount_path}/keys/{name} | Manage the keys that can be created with this backend.
[**ListAwsRoles**](Secrets.md#listawsroles) | **GET** /{mount_path}/roles | List the existing roles in this backend
[**ListGcpRolesets**](Secrets.md#listgcprolesets) | **GET** /{mount_path}/rolesets | 
[**ListGcpStaticAccounts**](Secrets.md#listgcpstaticaccounts) | **GET** /{mount_path}/static-accounts | 
[**ListLdapLibrary**](Secrets.md#listldaplibrary) | **GET** /{mount_path}/library | 
[**ListLdapRole**](Secrets.md#listldaprole) | **GET** /{mount_path}/role | 
[**ListLdapStaticRole**](Secrets.md#listldapstaticrole) | **GET** /{mount_path}/static-role | 
[**ListPkiCerts**](Secrets.md#listpkicerts) | **GET** /{mount_path}/certs | 
[**ListPkiIssuers**](Secrets.md#listpkiissuers) | **GET** /{mount_path}/issuers | 
[**ListTotpKeys**](Secrets.md#listtotpkeys) | **GET** /{mount_path}/keys | Manage the keys that can be created with this backend.
[**ReadAwsConfigLease**](Secrets.md#readawsconfiglease) | **GET** /{mount_path}/config/lease | Configure the default lease information for generated credentials.
[**ReadAwsConfigRoot**](Secrets.md#readawsconfigroot) | **GET** /{mount_path}/config/root | Configure the root credentials that are used to manage IAM.
[**ReadAwsCreds**](Secrets.md#readawscreds) | **GET** /{mount_path}/creds | Generate AWS credentials from a specific Vault role.
[**ReadAwsRolesName**](Secrets.md#readawsrolesname) | **GET** /{mount_path}/roles/{name} | Read, write and reference IAM policies that access keys can be made for.
[**ReadAwsStsName**](Secrets.md#readawsstsname) | **GET** /{mount_path}/sts/{name} | Generate AWS credentials from a specific Vault role.
[**ReadAzureCredsRole**](Secrets.md#readazurecredsrole) | **GET** /{mount_path}/creds/{role} | 
[**ReadCubbyholePath**](Secrets.md#readcubbyholepath) | **GET** /{mount_path}/{path} | Retrieve the secret at the specified location.
[**ReadGcpConfig**](Secrets.md#readgcpconfig) | **GET** /{mount_path}/config | 
[**ReadGcpKeyRoleset**](Secrets.md#readgcpkeyroleset) | **GET** /{mount_path}/key/{roleset} | 
[**ReadGcpRolesetName**](Secrets.md#readgcprolesetname) | **GET** /{mount_path}/roleset/{name} | 
[**ReadGcpRolesetRolesetKey**](Secrets.md#readgcprolesetrolesetkey) | **GET** /{mount_path}/roleset/{roleset}/key | 
[**ReadGcpRolesetRolesetToken**](Secrets.md#readgcprolesetrolesettoken) | **GET** /{mount_path}/roleset/{roleset}/token | 
[**ReadGcpStaticAccountName**](Secrets.md#readgcpstaticaccountname) | **GET** /{mount_path}/static-account/{name} | 
[**ReadGcpStaticAccountNameKey**](Secrets.md#readgcpstaticaccountnamekey) | **GET** /{mount_path}/static-account/{name}/key | 
[**ReadGcpStaticAccountNameToken**](Secrets.md#readgcpstaticaccountnametoken) | **GET** /{mount_path}/static-account/{name}/token | 
[**ReadGcpTokenRoleset**](Secrets.md#readgcptokenroleset) | **GET** /{mount_path}/token/{roleset} | 
[**ReadGcpkmsKeysConfigKey**](Secrets.md#readgcpkmskeysconfigkey) | **GET** /{mount_path}/keys/config/{key} | Configure the key in Vault
[**ReadGcpkmsKeysKey**](Secrets.md#readgcpkmskeyskey) | **GET** /{mount_path}/keys/{key} | Interact with crypto keys in Vault and Google Cloud KMS
[**ReadGcpkmsPubkeyKey**](Secrets.md#readgcpkmspubkeykey) | **GET** /{mount_path}/pubkey/{key} | Retrieve the public key associated with the named key
[**ReadLdapCredsName**](Secrets.md#readldapcredsname) | **GET** /{mount_path}/creds/{name} | 
[**ReadLdapLibraryName**](Secrets.md#readldaplibraryname) | **GET** /{mount_path}/library/{name} | Read a library set.
[**ReadLdapLibraryNameStatus**](Secrets.md#readldaplibrarynamestatus) | **GET** /{mount_path}/library/{name}/status | Check the status of the service accounts in a library set.
[**ReadLdapRoleName**](Secrets.md#readldaprolename) | **GET** /{mount_path}/role/{name} | 
[**ReadLdapStaticCredName**](Secrets.md#readldapstaticcredname) | **GET** /{mount_path}/static-cred/{name} | 
[**ReadLdapStaticRoleName**](Secrets.md#readldapstaticrolename) | **GET** /{mount_path}/static-role/{name} | 
[**ReadNomadConfigAccess**](Secrets.md#readnomadconfigaccess) | **GET** /{mount_path}/config/access | 
[**ReadPkiCa**](Secrets.md#readpkica) | **GET** /{mount_path}/ca | 
[**ReadPkiCaChain**](Secrets.md#readpkicachain) | **GET** /{mount_path}/ca_chain | 
[**ReadPkiCaPem**](Secrets.md#readpkicapem) | **GET** /{mount_path}/ca/pem | 
[**ReadPkiCertCaChain**](Secrets.md#readpkicertcachain) | **GET** /{mount_path}/cert/ca_chain | 
[**ReadPkiCertSerial**](Secrets.md#readpkicertserial) | **GET** /{mount_path}/cert/{serial} | 
[**ReadPkiCertSerialRaw**](Secrets.md#readpkicertserialraw) | **GET** /{mount_path}/cert/{serial}/raw | 
[**ReadPkiCertSerialRawPem**](Secrets.md#readpkicertserialrawpem) | **GET** /{mount_path}/cert/{serial}/raw/pem | 
[**ReadPkiConfigAutoTidy**](Secrets.md#readpkiconfigautotidy) | **GET** /{mount_path}/config/auto-tidy | 
[**ReadPkiConfigCrl**](Secrets.md#readpkiconfigcrl) | **GET** /{mount_path}/config/crl | 
[**ReadPkiConfigIssuers**](Secrets.md#readpkiconfigissuers) | **GET** /{mount_path}/config/issuers | 
[**ReadPkiConfigKeys**](Secrets.md#readpkiconfigkeys) | **GET** /{mount_path}/config/keys | 
[**ReadPkiConfigUrls**](Secrets.md#readpkiconfigurls) | **GET** /{mount_path}/config/urls | 
[**ReadPkiCrl**](Secrets.md#readpkicrl) | **GET** /{mount_path}/crl | 
[**ReadPkiCrlRotate**](Secrets.md#readpkicrlrotate) | **GET** /{mount_path}/crl/rotate | 
[**ReadPkiCrlRotateDelta**](Secrets.md#readpkicrlrotatedelta) | **GET** /{mount_path}/crl/rotate-delta | 
[**ReadPkiDelta**](Secrets.md#readpkidelta) | **GET** /{mount_path}//delta | 
[**ReadPkiDeltaCrl**](Secrets.md#readpkideltacrl) | **GET** /{mount_path}/delta-crl | 
[**ReadPkiDeltaPem**](Secrets.md#readpkideltapem) | **GET** /{mount_path}//delta/pem | 
[**ReadPkiDer**](Secrets.md#readpkider) | **GET** /{mount_path}//der | 
[**ReadPkiIssuerRefCrlPemDerDeltaPem**](Secrets.md#readpkiissuerrefcrlpemderdeltapem) | **GET** /{mount_path}/{issuer_ref}/crl/pem|/der|/delta/pem | 
[**ReadPkiIssuerRefDerPem**](Secrets.md#readpkiissuerrefderpem) | **GET** /{mount_path}/{issuer_ref}/der|/pem | 
[**ReadPkiJson**](Secrets.md#readpkijson) | **GET** /{mount_path}//json | 
[**ReadPkiKeyKeyRef**](Secrets.md#readpkikeykeyref) | **GET** /{mount_path}/key/{key_ref} | 
[**ReadPkiOcspReq**](Secrets.md#readpkiocspreq) | **GET** /{mount_path}/ocsp/{req} | 
[**ReadPkiPem**](Secrets.md#readpkipem) | **GET** /{mount_path}//pem | 
[**ReadPkiTidyStatus**](Secrets.md#readpkitidystatus) | **GET** /{mount_path}/tidy-status | 
[**ReadSecretDataPath**](Secrets.md#readsecretdatapath) | **GET** /{mount_path}/data/{path} | Write, Patch, Read, and Delete data in the Key-Value Store.
[**ReadSecretMetadataPath**](Secrets.md#readsecretmetadatapath) | **GET** /{mount_path}/metadata/{path} | Configures settings for the KV store
[**ReadSecretSubkeysPath**](Secrets.md#readsecretsubkeyspath) | **GET** /{mount_path}/subkeys/{path} | Read the structure of a secret entry from the Key-Value store with the values removed.
[**ReadSshConfigZeroaddress**](Secrets.md#readsshconfigzeroaddress) | **GET** /{mount_path}/config/zeroaddress | Assign zero address as default CIDR block for select roles.
[**ReadSshPublicKey**](Secrets.md#readsshpublickey) | **GET** /{mount_path}/public_key | Retrieve the public key.
[**ReadSshRolesRole**](Secrets.md#readsshrolesrole) | **GET** /{mount_path}/roles/{role} | Manage the &#39;roles&#39; that can be created with this backend.
[**ReadTotpCodeName**](Secrets.md#readtotpcodename) | **GET** /{mount_path}/code/{name} | Request time-based one-time use password or validate a password for a certain key .
[**ReadTotpKeysName**](Secrets.md#readtotpkeysname) | **GET** /{mount_path}/keys/{name} | Manage the keys that can be created with this backend.
[**ReadTransitBackupName**](Secrets.md#readtransitbackupname) | **GET** /{mount_path}/backup/{name} | Backup the named key
[**ReadTransitCacheConfig**](Secrets.md#readtransitcacheconfig) | **GET** /{mount_path}/cache-config | Returns the size of the active cache
[**ReadTransitExportTypeName**](Secrets.md#readtransitexporttypename) | **GET** /{mount_path}/export/{type}/{name} | Export named encryption or signing key
[**ReadTransitExportTypeNameVersion**](Secrets.md#readtransitexporttypenameversion) | **GET** /{mount_path}/export/{type}/{name}/{version} | Export named encryption or signing key
[**ReadTransitWrappingKey**](Secrets.md#readtransitwrappingkey) | **GET** /{mount_path}/wrapping_key | Returns the public key to use for wrapping imported keys
[**UpdateAwsConfigLease**](Secrets.md#updateawsconfiglease) | **POST** /{mount_path}/config/lease | Configure the default lease information for generated credentials.
[**UpdateAwsConfigRoot**](Secrets.md#updateawsconfigroot) | **POST** /{mount_path}/config/root | Configure the root credentials that are used to manage IAM.
[**UpdateAwsCreds**](Secrets.md#updateawscreds) | **POST** /{mount_path}/creds | Generate AWS credentials from a specific Vault role.
[**UpdateAwsRolesName**](Secrets.md#updateawsrolesname) | **POST** /{mount_path}/roles/{name} | Read, write and reference IAM policies that access keys can be made for.
[**UpdateAwsStsName**](Secrets.md#updateawsstsname) | **POST** /{mount_path}/sts/{name} | Generate AWS credentials from a specific Vault role.
[**UpdateCubbyholePath**](Secrets.md#updatecubbyholepath) | **POST** /{mount_path}/{path} | Store a secret at the specified location.
[**UpdateGcpConfig**](Secrets.md#updategcpconfig) | **POST** /{mount_path}/config | 
[**UpdateGcpConfigRotateRoot**](Secrets.md#updategcpconfigrotateroot) | **POST** /{mount_path}/config/rotate-root | 
[**UpdateGcpKeyRoleset**](Secrets.md#updategcpkeyroleset) | **POST** /{mount_path}/key/{roleset} | 
[**UpdateGcpRolesetName**](Secrets.md#updategcprolesetname) | **POST** /{mount_path}/roleset/{name} | 
[**UpdateGcpRolesetNameRotate**](Secrets.md#updategcprolesetnamerotate) | **POST** /{mount_path}/roleset/{name}/rotate | 
[**UpdateGcpRolesetNameRotateKey**](Secrets.md#updategcprolesetnamerotatekey) | **POST** /{mount_path}/roleset/{name}/rotate-key | 
[**UpdateGcpRolesetRolesetKey**](Secrets.md#updategcprolesetrolesetkey) | **POST** /{mount_path}/roleset/{roleset}/key | 
[**UpdateGcpRolesetRolesetToken**](Secrets.md#updategcprolesetrolesettoken) | **POST** /{mount_path}/roleset/{roleset}/token | 
[**UpdateGcpStaticAccountName**](Secrets.md#updategcpstaticaccountname) | **POST** /{mount_path}/static-account/{name} | 
[**UpdateGcpStaticAccountNameKey**](Secrets.md#updategcpstaticaccountnamekey) | **POST** /{mount_path}/static-account/{name}/key | 
[**UpdateGcpStaticAccountNameRotateKey**](Secrets.md#updategcpstaticaccountnamerotatekey) | **POST** /{mount_path}/static-account/{name}/rotate-key | 
[**UpdateGcpStaticAccountNameToken**](Secrets.md#updategcpstaticaccountnametoken) | **POST** /{mount_path}/static-account/{name}/token | 
[**UpdateGcpTokenRoleset**](Secrets.md#updategcptokenroleset) | **POST** /{mount_path}/token/{roleset} | 
[**UpdateGcpkmsDecryptKey**](Secrets.md#updategcpkmsdecryptkey) | **POST** /{mount_path}/decrypt/{key} | Decrypt a ciphertext value using a named key
[**UpdateGcpkmsEncryptKey**](Secrets.md#updategcpkmsencryptkey) | **POST** /{mount_path}/encrypt/{key} | Encrypt a plaintext value using a named key
[**UpdateGcpkmsKeysConfigKey**](Secrets.md#updategcpkmskeysconfigkey) | **POST** /{mount_path}/keys/config/{key} | Configure the key in Vault
[**UpdateGcpkmsKeysDeregisterKey**](Secrets.md#updategcpkmskeysderegisterkey) | **POST** /{mount_path}/keys/deregister/{key} | Deregister an existing key in Vault
[**UpdateGcpkmsKeysKey**](Secrets.md#updategcpkmskeyskey) | **POST** /{mount_path}/keys/{key} | Interact with crypto keys in Vault and Google Cloud KMS
[**UpdateGcpkmsKeysRegisterKey**](Secrets.md#updategcpkmskeysregisterkey) | **POST** /{mount_path}/keys/register/{key} | Register an existing crypto key in Google Cloud KMS
[**UpdateGcpkmsKeysRotateKey**](Secrets.md#updategcpkmskeysrotatekey) | **POST** /{mount_path}/keys/rotate/{key} | Rotate a crypto key to a new primary version
[**UpdateGcpkmsKeysTrimKey**](Secrets.md#updategcpkmskeystrimkey) | **POST** /{mount_path}/keys/trim/{key} | Delete old crypto key versions from Google Cloud KMS
[**UpdateGcpkmsReencryptKey**](Secrets.md#updategcpkmsreencryptkey) | **POST** /{mount_path}/reencrypt/{key} | Re-encrypt existing ciphertext data to a new version
[**UpdateGcpkmsSignKey**](Secrets.md#updategcpkmssignkey) | **POST** /{mount_path}/sign/{key} | Signs a message or digest using a named key
[**UpdateGcpkmsVerifyKey**](Secrets.md#updategcpkmsverifykey) | **POST** /{mount_path}/verify/{key} | Verify a signature using a named key
[**UpdateLdapLibraryManageNameCheckIn**](Secrets.md#updateldaplibrarymanagenamecheckin) | **POST** /{mount_path}/library/manage/{name}/check-in | Check service accounts in to the library.
[**UpdateLdapLibraryName**](Secrets.md#updateldaplibraryname) | **POST** /{mount_path}/library/{name} | Update a library set.
[**UpdateLdapLibraryNameCheckIn**](Secrets.md#updateldaplibrarynamecheckin) | **POST** /{mount_path}/library/{name}/check-in | Check service accounts in to the library.
[**UpdateLdapLibraryNameCheckOut**](Secrets.md#updateldaplibrarynamecheckout) | **POST** /{mount_path}/library/{name}/check-out | Check a service account out from the library.
[**UpdateLdapRoleName**](Secrets.md#updateldaprolename) | **POST** /{mount_path}/role/{name} | 
[**UpdateLdapRotateRoleName**](Secrets.md#updateldaprotaterolename) | **POST** /{mount_path}/rotate-role/{name} | 
[**UpdateLdapRotateRoot**](Secrets.md#updateldaprotateroot) | **POST** /{mount_path}/rotate-root | 
[**UpdateLdapStaticRoleName**](Secrets.md#updateldapstaticrolename) | **POST** /{mount_path}/static-role/{name} | 
[**UpdateNomadConfigAccess**](Secrets.md#updatenomadconfigaccess) | **POST** /{mount_path}/config/access | 
[**UpdatePkiBundle**](Secrets.md#updatepkibundle) | **POST** /{mount_path}/bundle | 
[**UpdatePkiCert**](Secrets.md#updatepkicert) | **POST** /{mount_path}/cert | 
[**UpdatePkiConfigAutoTidy**](Secrets.md#updatepkiconfigautotidy) | **POST** /{mount_path}/config/auto-tidy | 
[**UpdatePkiConfigCa**](Secrets.md#updatepkiconfigca) | **POST** /{mount_path}/config/ca | 
[**UpdatePkiConfigCrl**](Secrets.md#updatepkiconfigcrl) | **POST** /{mount_path}/config/crl | 
[**UpdatePkiConfigIssuers**](Secrets.md#updatepkiconfigissuers) | **POST** /{mount_path}/config/issuers | 
[**UpdatePkiConfigKeys**](Secrets.md#updatepkiconfigkeys) | **POST** /{mount_path}/config/keys | 
[**UpdatePkiConfigUrls**](Secrets.md#updatepkiconfigurls) | **POST** /{mount_path}/config/urls | 
[**UpdatePkiIntermediateCrossSign**](Secrets.md#updatepkiintermediatecrosssign) | **POST** /{mount_path}/intermediate/cross-sign | 
[**UpdatePkiIntermediateGenerateExported**](Secrets.md#updatepkiintermediategenerateexported) | **POST** /{mount_path}/intermediate/generate/{exported} | 
[**UpdatePkiIntermediateSetSigned**](Secrets.md#updatepkiintermediatesetsigned) | **POST** /{mount_path}/intermediate/set-signed | 
[**UpdatePkiIssueRole**](Secrets.md#updatepkiissuerole) | **POST** /{mount_path}/issue/{role} | 
[**UpdatePkiIssuerIssuerRefIssueRole**](Secrets.md#updatepkiissuerissuerrefissuerole) | **POST** /{mount_path}/issuer/{issuer_ref}/issue/{role} | 
[**UpdatePkiIssuerIssuerRefRevoke**](Secrets.md#updatepkiissuerissuerrefrevoke) | **POST** /{mount_path}/issuer/{issuer_ref}/revoke | 
[**UpdatePkiIssuerIssuerRefSignIntermediate**](Secrets.md#updatepkiissuerissuerrefsignintermediate) | **POST** /{mount_path}/issuer/{issuer_ref}/sign-intermediate | 
[**UpdatePkiIssuerIssuerRefSignRole**](Secrets.md#updatepkiissuerissuerrefsignrole) | **POST** /{mount_path}/issuer/{issuer_ref}/sign/{role} | 
[**UpdatePkiIssuerIssuerRefSignSelfIssued**](Secrets.md#updatepkiissuerissuerrefsignselfissued) | **POST** /{mount_path}/issuer/{issuer_ref}/sign-self-issued | 
[**UpdatePkiIssuerIssuerRefSignVerbatim**](Secrets.md#updatepkiissuerissuerrefsignverbatim) | **POST** /{mount_path}/issuer/{issuer_ref}/sign-verbatim | 
[**UpdatePkiIssuerIssuerRefSignVerbatimRole**](Secrets.md#updatepkiissuerissuerrefsignverbatimrole) | **POST** /{mount_path}/issuer/{issuer_ref}/sign-verbatim/{role} | 
[**UpdatePkiIssuersGenerateIntermediateExported**](Secrets.md#updatepkiissuersgenerateintermediateexported) | **POST** /{mount_path}/issuers/generate/intermediate/{exported} | 
[**UpdatePkiIssuersGenerateRootExported**](Secrets.md#updatepkiissuersgeneraterootexported) | **POST** /{mount_path}/issuers/generate/root/{exported} | 
[**UpdatePkiJson**](Secrets.md#updatepkijson) | **POST** /{mount_path}//json | 
[**UpdatePkiKeyKeyRef**](Secrets.md#updatepkikeykeyref) | **POST** /{mount_path}/key/{key_ref} | 
[**UpdatePkiKeysImport**](Secrets.md#updatepkikeysimport) | **POST** /{mount_path}/keys/import | 
[**UpdatePkiKms**](Secrets.md#updatepkikms) | **POST** /{mount_path}/kms | 
[**UpdatePkiOcsp**](Secrets.md#updatepkiocsp) | **POST** /{mount_path}/ocsp | 
[**UpdatePkiRevoke**](Secrets.md#updatepkirevoke) | **POST** /{mount_path}/revoke | 
[**UpdatePkiRevokeWithKey**](Secrets.md#updatepkirevokewithkey) | **POST** /{mount_path}/revoke-with-key | 
[**UpdatePkiRootGenerateExported**](Secrets.md#updatepkirootgenerateexported) | **POST** /{mount_path}/root/generate/{exported} | 
[**UpdatePkiRootReplace**](Secrets.md#updatepkirootreplace) | **POST** /{mount_path}/root/replace | 
[**UpdatePkiRootRotateExported**](Secrets.md#updatepkirootrotateexported) | **POST** /{mount_path}/root/rotate/{exported} | 
[**UpdatePkiRootSignIntermediate**](Secrets.md#updatepkirootsignintermediate) | **POST** /{mount_path}/root/sign-intermediate | 
[**UpdatePkiRootSignSelfIssued**](Secrets.md#updatepkirootsignselfissued) | **POST** /{mount_path}/root/sign-self-issued | 
[**UpdatePkiSignRole**](Secrets.md#updatepkisignrole) | **POST** /{mount_path}/sign/{role} | 
[**UpdatePkiSignVerbatim**](Secrets.md#updatepkisignverbatim) | **POST** /{mount_path}/sign-verbatim | 
[**UpdatePkiSignVerbatimRole**](Secrets.md#updatepkisignverbatimrole) | **POST** /{mount_path}/sign-verbatim/{role} | 
[**UpdatePkiTidy**](Secrets.md#updatepkitidy) | **POST** /{mount_path}/tidy | 
[**UpdatePkiTidyCancel**](Secrets.md#updatepkitidycancel) | **POST** /{mount_path}/tidy-cancel | 
[**UpdateRabbitmqConfigConnection**](Secrets.md#updaterabbitmqconfigconnection) | **POST** /{mount_path}/config/connection | Configure the connection URI, username, and password to talk to RabbitMQ management HTTP API.
[**UpdateSecretDataPath**](Secrets.md#updatesecretdatapath) | **POST** /{mount_path}/data/{path} | Write, Patch, Read, and Delete data in the Key-Value Store.
[**UpdateSecretDeletePath**](Secrets.md#updatesecretdeletepath) | **POST** /{mount_path}/delete/{path} | Marks one or more versions as deleted in the KV store.
[**UpdateSecretDestroyPath**](Secrets.md#updatesecretdestroypath) | **POST** /{mount_path}/destroy/{path} | Permanently removes one or more versions in the KV store
[**UpdateSecretMetadataPath**](Secrets.md#updatesecretmetadatapath) | **POST** /{mount_path}/metadata/{path} | Configures settings for the KV store
[**UpdateSecretUndeletePath**](Secrets.md#updatesecretundeletepath) | **POST** /{mount_path}/undelete/{path} | Undeletes one or more versions from the KV store.
[**UpdateSshConfigZeroaddress**](Secrets.md#updatesshconfigzeroaddress) | **POST** /{mount_path}/config/zeroaddress | Assign zero address as default CIDR block for select roles.
[**UpdateSshKeysKeyName**](Secrets.md#updatesshkeyskeyname) | **POST** /{mount_path}/keys/{key_name} | Register a shared private key with Vault.
[**UpdateSshLookup**](Secrets.md#updatesshlookup) | **POST** /{mount_path}/lookup | List all the roles associated with the given IP address.
[**UpdateSshRolesRole**](Secrets.md#updatesshrolesrole) | **POST** /{mount_path}/roles/{role} | Manage the &#39;roles&#39; that can be created with this backend.
[**UpdateSshVerify**](Secrets.md#updatesshverify) | **POST** /{mount_path}/verify | Validate the OTP provided by Vault SSH Agent.
[**UpdateTotpCodeName**](Secrets.md#updatetotpcodename) | **POST** /{mount_path}/code/{name} | Request time-based one-time use password or validate a password for a certain key .
[**UpdateTotpKeysName**](Secrets.md#updatetotpkeysname) | **POST** /{mount_path}/keys/{name} | Manage the keys that can be created with this backend.
[**UpdateTransitCacheConfig**](Secrets.md#updatetransitcacheconfig) | **POST** /{mount_path}/cache-config | Configures a new cache of the specified size
[**UpdateTransitDatakeyPlaintextName**](Secrets.md#updatetransitdatakeyplaintextname) | **POST** /{mount_path}/datakey/{plaintext}/{name} | Generate a data key
[**UpdateTransitDecryptName**](Secrets.md#updatetransitdecryptname) | **POST** /{mount_path}/decrypt/{name} | Decrypt a ciphertext value using a named key
[**UpdateTransitEncryptName**](Secrets.md#updatetransitencryptname) | **POST** /{mount_path}/encrypt/{name} | Encrypt a plaintext value or a batch of plaintext blocks using a named key
[**UpdateTransitHash**](Secrets.md#updatetransithash) | **POST** /{mount_path}/hash | Generate a hash sum for input data
[**UpdateTransitHashUrlalgorithm**](Secrets.md#updatetransithashurlalgorithm) | **POST** /{mount_path}/hash/{urlalgorithm} | Generate a hash sum for input data
[**UpdateTransitHmacName**](Secrets.md#updatetransithmacname) | **POST** /{mount_path}/hmac/{name} | Generate an HMAC for input data using the named key
[**UpdateTransitHmacNameUrlalgorithm**](Secrets.md#updatetransithmacnameurlalgorithm) | **POST** /{mount_path}/hmac/{name}/{urlalgorithm} | Generate an HMAC for input data using the named key
[**UpdateTransitKeysNameConfig**](Secrets.md#updatetransitkeysnameconfig) | **POST** /{mount_path}/keys/{name}/config | Configure a named encryption key
[**UpdateTransitKeysNameImport**](Secrets.md#updatetransitkeysnameimport) | **POST** /{mount_path}/keys/{name}/import | Imports an externally-generated key into a new transit key
[**UpdateTransitKeysNameImportVersion**](Secrets.md#updatetransitkeysnameimportversion) | **POST** /{mount_path}/keys/{name}/import_version | Imports an externally-generated key into an existing imported key
[**UpdateTransitKeysNameRotate**](Secrets.md#updatetransitkeysnamerotate) | **POST** /{mount_path}/keys/{name}/rotate | Rotate named encryption key
[**UpdateTransitKeysNameTrim**](Secrets.md#updatetransitkeysnametrim) | **POST** /{mount_path}/keys/{name}/trim | Trim key versions of a named key
[**UpdateTransitRandom**](Secrets.md#updatetransitrandom) | **POST** /{mount_path}/random | Generate random bytes
[**UpdateTransitRandomSource**](Secrets.md#updatetransitrandomsource) | **POST** /{mount_path}/random/{source} | Generate random bytes
[**UpdateTransitRandomSourceUrlbytes**](Secrets.md#updatetransitrandomsourceurlbytes) | **POST** /{mount_path}/random/{source}/{urlbytes} | Generate random bytes
[**UpdateTransitRandomUrlbytes**](Secrets.md#updatetransitrandomurlbytes) | **POST** /{mount_path}/random/{urlbytes} | Generate random bytes
[**UpdateTransitRestore**](Secrets.md#updatetransitrestore) | **POST** /{mount_path}/restore | Restore the named key
[**UpdateTransitRestoreName**](Secrets.md#updatetransitrestorename) | **POST** /{mount_path}/restore/{name} | Restore the named key
[**UpdateTransitRewrapName**](Secrets.md#updatetransitrewrapname) | **POST** /{mount_path}/rewrap/{name} | Rewrap ciphertext
[**UpdateTransitSignName**](Secrets.md#updatetransitsignname) | **POST** /{mount_path}/sign/{name} | Generate a signature for input data using the named key
[**UpdateTransitSignNameUrlalgorithm**](Secrets.md#updatetransitsignnameurlalgorithm) | **POST** /{mount_path}/sign/{name}/{urlalgorithm} | Generate a signature for input data using the named key
[**UpdateTransitVerifyName**](Secrets.md#updatetransitverifyname) | **POST** /{mount_path}/verify/{name} | Verify a signature or HMAC for input data created using the named key
[**UpdateTransitVerifyNameUrlalgorithm**](Secrets.md#updatetransitverifynameurlalgorithm) | **POST** /{mount_path}/verify/{name}/{urlalgorithm} | Verify a signature or HMAC for input data created using the named key


<a name="deleteawsrolesname"></a>
# **DeleteAwsRolesName**
> void DeleteAwsRolesName (string name, string mountPath = null)

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
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Read, write and reference IAM policies that access keys can be made for.
                apiInstance.DeleteAwsRolesName(name, mountPath);
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

<a name="deletecubbyholepath"></a>
# **DeleteCubbyholePath**
> void DeleteCubbyholePath (string path, string mountPath = null)

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
            var mountPath = "\"cubbyhole\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cubbyhole")

            try
            {
                // Deletes the secret at the specified location.
                apiInstance.DeleteCubbyholePath(path, mountPath);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cubbyhole&quot;]

### Return type

void (empty response body)

### Authorization

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
> void DeleteGcpRolesetName (string name, string mountPath = null)



### Example
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
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.DeleteGcpRolesetName(name, mountPath);
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
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegcpstaticaccountname"></a>
# **DeleteGcpStaticAccountName**
> void DeleteGcpStaticAccountName (string name, string mountPath = null)



### Example
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
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.DeleteGcpStaticAccountName(name, mountPath);
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
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegcpkmskeysderegisterkey"></a>
# **DeleteGcpkmsKeysDeregisterKey**
> void DeleteGcpkmsKeysDeregisterKey (string key, string mountPath = null)

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
            var mountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Deregister an existing key in Vault
                apiInstance.DeleteGcpkmsKeysDeregisterKey(key, mountPath);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

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
> void DeleteGcpkmsKeysKey (string key, string mountPath = null)

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
            var mountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Interact with crypto keys in Vault and Google Cloud KMS
                apiInstance.DeleteGcpkmsKeysKey(key, mountPath);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

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
> void DeleteGcpkmsKeysTrimKey (string key, string mountPath = null)

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
            var mountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Delete old crypto key versions from Google Cloud KMS
                apiInstance.DeleteGcpkmsKeysTrimKey(key, mountPath);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

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
> void DeleteLdapLibraryName (string name, string mountPath = null)

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
            var mountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                // Delete a library set.
                apiInstance.DeleteLdapLibraryName(name, mountPath);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]

### Return type

void (empty response body)

### Authorization

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
> void DeleteLdapRoleName (string name, string mountPath = null)



### Example
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
            var mountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.DeleteLdapRoleName(name, mountPath);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]

### Return type

void (empty response body)

### Authorization

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
> void DeleteLdapStaticRoleName (string name, string mountPath = null)



### Example
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
            var mountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.DeleteLdapStaticRoleName(name, mountPath);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]

### Return type

void (empty response body)

### Authorization

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
> void DeleteNomadConfigAccess (string mountPath = null)



### Example
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
            var mountPath = "\"nomad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "nomad")

            try
            {
                apiInstance.DeleteNomadConfigAccess(mountPath);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;nomad&quot;]

### Return type

void (empty response body)

### Authorization

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
> void DeletePkiIssuerRefDerPem (string issuerRef, string mountPath = null)



### Example
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.DeletePkiIssuerRefDerPem(issuerRef, mountPath);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

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
> void DeletePkiJson (string mountPath = null)



### Example
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.DeletePkiJson(mountPath);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

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
> void DeletePkiKeyKeyRef (string keyRef, string mountPath = null)



### Example
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.DeletePkiKeyKeyRef(keyRef, mountPath);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

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
> void DeletePkiRoot (string mountPath = null)



### Example
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.DeletePkiRoot(mountPath);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

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
> void DeleteSecretDataPath (string path, string mountPath = null)

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
            var mountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Write, Patch, Read, and Delete data in the Key-Value Store.
                apiInstance.DeleteSecretDataPath(path, mountPath);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;secret&quot;]

### Return type

void (empty response body)

### Authorization

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
> void DeleteSecretMetadataPath (string path, string mountPath = null)

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
            var mountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Configures settings for the KV store
                apiInstance.DeleteSecretMetadataPath(path, mountPath);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;secret&quot;]

### Return type

void (empty response body)

### Authorization

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
> void DeleteSshConfigZeroaddress (string mountPath = null)

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
            var mountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Assign zero address as default CIDR block for select roles.
                apiInstance.DeleteSshConfigZeroaddress(mountPath);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]

### Return type

void (empty response body)

### Authorization

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
> void DeleteSshKeysKeyName (string keyName, string mountPath = null)

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
            var mountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Register a shared private key with Vault.
                apiInstance.DeleteSshKeysKeyName(keyName, mountPath);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]

### Return type

void (empty response body)

### Authorization

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
> void DeleteSshRolesRole (string role, string mountPath = null)

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
            var mountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Manage the 'roles' that can be created with this backend.
                apiInstance.DeleteSshRolesRole(role, mountPath);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]

### Return type

void (empty response body)

### Authorization

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
> void DeleteTotpKeysName (string name, string mountPath = null)

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
            var mountPath = "\"totp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "totp")

            try
            {
                // Manage the keys that can be created with this backend.
                apiInstance.DeleteTotpKeysName(name, mountPath);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;totp&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listawsroles"></a>
# **ListAwsRoles**
> void ListAwsRoles (string list, string mountPath = null)

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
    public class ListAwsRolesExample
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
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // List the existing roles in this backend
                apiInstance.ListAwsRoles(list, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ListAwsRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="listgcprolesets"></a>
# **ListGcpRolesets**
> void ListGcpRolesets (string list, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListGcpRolesetsExample
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
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.ListGcpRolesets(list, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ListGcpRolesets: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="listgcpstaticaccounts"></a>
# **ListGcpStaticAccounts**
> void ListGcpStaticAccounts (string list, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListGcpStaticAccountsExample
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
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.ListGcpStaticAccounts(list, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ListGcpStaticAccounts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="listldaplibrary"></a>
# **ListLdapLibrary**
> void ListLdapLibrary (string list, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListLdapLibraryExample
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
            var mountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.ListLdapLibrary(list, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ListLdapLibrary: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listldaprole"></a>
# **ListLdapRole**
> void ListLdapRole (string list, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListLdapRoleExample
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
            var mountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.ListLdapRole(list, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ListLdapRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listldapstaticrole"></a>
# **ListLdapStaticRole**
> void ListLdapStaticRole (string list, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListLdapStaticRoleExample
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
            var mountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.ListLdapStaticRole(list, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ListLdapStaticRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpkicerts"></a>
# **ListPkiCerts**
> void ListPkiCerts (string list, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListPkiCertsExample
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ListPkiCerts(list, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ListPkiCerts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpkiissuers"></a>
# **ListPkiIssuers**
> void ListPkiIssuers (string list, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListPkiIssuersExample
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ListPkiIssuers(list, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ListPkiIssuers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtotpkeys"></a>
# **ListTotpKeys**
> void ListTotpKeys (string list, string mountPath = null)

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
    public class ListTotpKeysExample
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
            var mountPath = "\"totp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "totp")

            try
            {
                // Manage the keys that can be created with this backend.
                apiInstance.ListTotpKeys(list, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ListTotpKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;totp&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readawsconfiglease"></a>
# **ReadAwsConfigLease**
> void ReadAwsConfigLease (string mountPath = null)

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
    public class ReadAwsConfigLeaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Configure the default lease information for generated credentials.
                apiInstance.ReadAwsConfigLease(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadAwsConfigLease: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="readawsconfigroot"></a>
# **ReadAwsConfigRoot**
> void ReadAwsConfigRoot (string mountPath = null)

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
    public class ReadAwsConfigRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Configure the root credentials that are used to manage IAM.
                apiInstance.ReadAwsConfigRoot(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadAwsConfigRoot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="readawscreds"></a>
# **ReadAwsCreds**
> void ReadAwsCreds (string mountPath = null)

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
    public class ReadAwsCredsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Generate AWS credentials from a specific Vault role.
                apiInstance.ReadAwsCreds(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadAwsCreds: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="readawsrolesname"></a>
# **ReadAwsRolesName**
> void ReadAwsRolesName (string name, string mountPath = null)

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
    public class ReadAwsRolesNameExample
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
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Read, write and reference IAM policies that access keys can be made for.
                apiInstance.ReadAwsRolesName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadAwsRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="readawsstsname"></a>
# **ReadAwsStsName**
> void ReadAwsStsName (string name, string mountPath = null)

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
    public class ReadAwsStsNameExample
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
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")

            try
            {
                // Generate AWS credentials from a specific Vault role.
                apiInstance.ReadAwsStsName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadAwsStsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="readazurecredsrole"></a>
# **ReadAzureCredsRole**
> void ReadAzureCredsRole (string role, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadAzureCredsRoleExample
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
            var mountPath = "\"azure\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "azure")

            try
            {
                apiInstance.ReadAzureCredsRole(role, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadAzureCredsRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;azure&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readcubbyholepath"></a>
# **ReadCubbyholePath**
> void ReadCubbyholePath (string path, string mountPath = null, string list = null)

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
    public class ReadCubbyholePathExample
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
            var mountPath = "\"cubbyhole\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cubbyhole")
            var list = "list_example";  // string | Return a list if `true` (optional) 

            try
            {
                // Retrieve the secret at the specified location.
                apiInstance.ReadCubbyholePath(path, mountPath, list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadCubbyholePath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cubbyhole&quot;]
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

<a name="readgcpconfig"></a>
# **ReadGcpConfig**
> void ReadGcpConfig (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadGcpConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.ReadGcpConfig(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadGcpConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="readgcpkeyroleset"></a>
# **ReadGcpKeyRoleset**
> void ReadGcpKeyRoleset (string roleset, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadGcpKeyRolesetExample
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
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.ReadGcpKeyRoleset(roleset, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadGcpKeyRoleset: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="readgcprolesetname"></a>
# **ReadGcpRolesetName**
> void ReadGcpRolesetName (string name, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadGcpRolesetNameExample
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
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.ReadGcpRolesetName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadGcpRolesetName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="readgcprolesetrolesetkey"></a>
# **ReadGcpRolesetRolesetKey**
> void ReadGcpRolesetRolesetKey (string roleset, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadGcpRolesetRolesetKeyExample
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
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.ReadGcpRolesetRolesetKey(roleset, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadGcpRolesetRolesetKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="readgcprolesetrolesettoken"></a>
# **ReadGcpRolesetRolesetToken**
> void ReadGcpRolesetRolesetToken (string roleset, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadGcpRolesetRolesetTokenExample
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
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.ReadGcpRolesetRolesetToken(roleset, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadGcpRolesetRolesetToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="readgcpstaticaccountname"></a>
# **ReadGcpStaticAccountName**
> void ReadGcpStaticAccountName (string name, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadGcpStaticAccountNameExample
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
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.ReadGcpStaticAccountName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadGcpStaticAccountName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="readgcpstaticaccountnamekey"></a>
# **ReadGcpStaticAccountNameKey**
> void ReadGcpStaticAccountNameKey (string name, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadGcpStaticAccountNameKeyExample
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
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.ReadGcpStaticAccountNameKey(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadGcpStaticAccountNameKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="readgcpstaticaccountnametoken"></a>
# **ReadGcpStaticAccountNameToken**
> void ReadGcpStaticAccountNameToken (string name, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadGcpStaticAccountNameTokenExample
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
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.ReadGcpStaticAccountNameToken(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadGcpStaticAccountNameToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="readgcptokenroleset"></a>
# **ReadGcpTokenRoleset**
> void ReadGcpTokenRoleset (string roleset, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadGcpTokenRolesetExample
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
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.ReadGcpTokenRoleset(roleset, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadGcpTokenRoleset: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="readgcpkmskeysconfigkey"></a>
# **ReadGcpkmsKeysConfigKey**
> void ReadGcpkmsKeysConfigKey (string key, string mountPath = null)

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
    public class ReadGcpkmsKeysConfigKeyExample
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
            var mountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Configure the key in Vault
                apiInstance.ReadGcpkmsKeysConfigKey(key, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadGcpkmsKeysConfigKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readgcpkmskeyskey"></a>
# **ReadGcpkmsKeysKey**
> void ReadGcpkmsKeysKey (string key, string mountPath = null)

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
    public class ReadGcpkmsKeysKeyExample
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
            var mountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Interact with crypto keys in Vault and Google Cloud KMS
                apiInstance.ReadGcpkmsKeysKey(key, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadGcpkmsKeysKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readgcpkmspubkeykey"></a>
# **ReadGcpkmsPubkeyKey**
> void ReadGcpkmsPubkeyKey (string key, string mountPath = null)

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
    public class ReadGcpkmsPubkeyKeyExample
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
            var mountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Retrieve the public key associated with the named key
                apiInstance.ReadGcpkmsPubkeyKey(key, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadGcpkmsPubkeyKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readldapcredsname"></a>
# **ReadLdapCredsName**
> void ReadLdapCredsName (string name, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadLdapCredsNameExample
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
            var mountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.ReadLdapCredsName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadLdapCredsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readldaplibraryname"></a>
# **ReadLdapLibraryName**
> void ReadLdapLibraryName (string name, string mountPath = null)

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
    public class ReadLdapLibraryNameExample
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
            var mountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                // Read a library set.
                apiInstance.ReadLdapLibraryName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadLdapLibraryName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readldaplibrarynamestatus"></a>
# **ReadLdapLibraryNameStatus**
> void ReadLdapLibraryNameStatus (string name, string mountPath = null)

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
    public class ReadLdapLibraryNameStatusExample
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
            var mountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                // Check the status of the service accounts in a library set.
                apiInstance.ReadLdapLibraryNameStatus(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadLdapLibraryNameStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readldaprolename"></a>
# **ReadLdapRoleName**
> void ReadLdapRoleName (string name, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadLdapRoleNameExample
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
            var mountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.ReadLdapRoleName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadLdapRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readldapstaticcredname"></a>
# **ReadLdapStaticCredName**
> void ReadLdapStaticCredName (string name, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadLdapStaticCredNameExample
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
            var mountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.ReadLdapStaticCredName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadLdapStaticCredName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readldapstaticrolename"></a>
# **ReadLdapStaticRoleName**
> void ReadLdapStaticRoleName (string name, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadLdapStaticRoleNameExample
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
            var mountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.ReadLdapStaticRoleName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadLdapStaticRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readnomadconfigaccess"></a>
# **ReadNomadConfigAccess**
> void ReadNomadConfigAccess (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadNomadConfigAccessExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"nomad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "nomad")

            try
            {
                apiInstance.ReadNomadConfigAccess(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadNomadConfigAccess: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;nomad&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkica"></a>
# **ReadPkiCa**
> void ReadPkiCa (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiCaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiCa(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiCa: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkicachain"></a>
# **ReadPkiCaChain**
> void ReadPkiCaChain (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiCaChainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiCaChain(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiCaChain: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkicapem"></a>
# **ReadPkiCaPem**
> void ReadPkiCaPem (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiCaPemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiCaPem(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiCaPem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkicertcachain"></a>
# **ReadPkiCertCaChain**
> void ReadPkiCertCaChain (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiCertCaChainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiCertCaChain(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiCertCaChain: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkicertserial"></a>
# **ReadPkiCertSerial**
> void ReadPkiCertSerial (string serial, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiCertSerialExample
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiCertSerial(serial, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiCertSerial: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkicertserialraw"></a>
# **ReadPkiCertSerialRaw**
> void ReadPkiCertSerialRaw (string serial, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiCertSerialRawExample
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiCertSerialRaw(serial, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiCertSerialRaw: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkicertserialrawpem"></a>
# **ReadPkiCertSerialRawPem**
> void ReadPkiCertSerialRawPem (string serial, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiCertSerialRawPemExample
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiCertSerialRawPem(serial, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiCertSerialRawPem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkiconfigautotidy"></a>
# **ReadPkiConfigAutoTidy**
> void ReadPkiConfigAutoTidy (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiConfigAutoTidyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiConfigAutoTidy(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiConfigAutoTidy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkiconfigcrl"></a>
# **ReadPkiConfigCrl**
> void ReadPkiConfigCrl (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiConfigCrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiConfigCrl(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiConfigCrl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkiconfigissuers"></a>
# **ReadPkiConfigIssuers**
> void ReadPkiConfigIssuers (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiConfigIssuersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiConfigIssuers(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiConfigIssuers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkiconfigkeys"></a>
# **ReadPkiConfigKeys**
> void ReadPkiConfigKeys (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiConfigKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiConfigKeys(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiConfigKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkiconfigurls"></a>
# **ReadPkiConfigUrls**
> void ReadPkiConfigUrls (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiConfigUrlsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiConfigUrls(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiConfigUrls: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkicrl"></a>
# **ReadPkiCrl**
> void ReadPkiCrl (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiCrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiCrl(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiCrl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkicrlrotate"></a>
# **ReadPkiCrlRotate**
> void ReadPkiCrlRotate (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiCrlRotateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiCrlRotate(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiCrlRotate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkicrlrotatedelta"></a>
# **ReadPkiCrlRotateDelta**
> void ReadPkiCrlRotateDelta (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiCrlRotateDeltaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiCrlRotateDelta(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiCrlRotateDelta: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkidelta"></a>
# **ReadPkiDelta**
> void ReadPkiDelta (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiDeltaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiDelta(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiDelta: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkideltacrl"></a>
# **ReadPkiDeltaCrl**
> void ReadPkiDeltaCrl (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiDeltaCrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiDeltaCrl(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiDeltaCrl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkideltapem"></a>
# **ReadPkiDeltaPem**
> void ReadPkiDeltaPem (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiDeltaPemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiDeltaPem(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiDeltaPem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkider"></a>
# **ReadPkiDer**
> void ReadPkiDer (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiDerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiDer(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiDer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkiissuerrefcrlpemderdeltapem"></a>
# **ReadPkiIssuerRefCrlPemDerDeltaPem**
> void ReadPkiIssuerRefCrlPemDerDeltaPem (string issuerRef, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiIssuerRefCrlPemDerDeltaPemExample
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiIssuerRefCrlPemDerDeltaPem(issuerRef, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiIssuerRefCrlPemDerDeltaPem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkiissuerrefderpem"></a>
# **ReadPkiIssuerRefDerPem**
> void ReadPkiIssuerRefDerPem (string issuerRef, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiIssuerRefDerPemExample
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiIssuerRefDerPem(issuerRef, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiIssuerRefDerPem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkijson"></a>
# **ReadPkiJson**
> void ReadPkiJson (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiJsonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiJson(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiJson: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkikeykeyref"></a>
# **ReadPkiKeyKeyRef**
> void ReadPkiKeyKeyRef (string keyRef, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiKeyKeyRefExample
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiKeyKeyRef(keyRef, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiKeyKeyRef: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkiocspreq"></a>
# **ReadPkiOcspReq**
> void ReadPkiOcspReq (string req, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiOcspReqExample
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiOcspReq(req, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiOcspReq: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkipem"></a>
# **ReadPkiPem**
> void ReadPkiPem (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiPemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiPem(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiPem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpkitidystatus"></a>
# **ReadPkiTidyStatus**
> void ReadPkiTidyStatus (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPkiTidyStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.ReadPkiTidyStatus(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadPkiTidyStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readsecretdatapath"></a>
# **ReadSecretDataPath**
> void ReadSecretDataPath (string path, string mountPath = null)

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
    public class ReadSecretDataPathExample
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
            var mountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Write, Patch, Read, and Delete data in the Key-Value Store.
                apiInstance.ReadSecretDataPath(path, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadSecretDataPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;secret&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readsecretmetadatapath"></a>
# **ReadSecretMetadataPath**
> void ReadSecretMetadataPath (string path, string mountPath = null, string list = null)

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
    public class ReadSecretMetadataPathExample
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
            var mountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")
            var list = "list_example";  // string | Return a list if `true` (optional) 

            try
            {
                // Configures settings for the KV store
                apiInstance.ReadSecretMetadataPath(path, mountPath, list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadSecretMetadataPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;secret&quot;]
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

<a name="readsecretsubkeyspath"></a>
# **ReadSecretSubkeysPath**
> void ReadSecretSubkeysPath (string path, string mountPath = null)

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
    public class ReadSecretSubkeysPathExample
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
            var mountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")

            try
            {
                // Read the structure of a secret entry from the Key-Value store with the values removed.
                apiInstance.ReadSecretSubkeysPath(path, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadSecretSubkeysPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;secret&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readsshconfigzeroaddress"></a>
# **ReadSshConfigZeroaddress**
> void ReadSshConfigZeroaddress (string mountPath = null)

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
    public class ReadSshConfigZeroaddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Assign zero address as default CIDR block for select roles.
                apiInstance.ReadSshConfigZeroaddress(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadSshConfigZeroaddress: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readsshpublickey"></a>
# **ReadSshPublicKey**
> void ReadSshPublicKey (string mountPath = null)

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
    public class ReadSshPublicKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Retrieve the public key.
                apiInstance.ReadSshPublicKey(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadSshPublicKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readsshrolesrole"></a>
# **ReadSshRolesRole**
> void ReadSshRolesRole (string role, string mountPath = null)

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
    public class ReadSshRolesRoleExample
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
            var mountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")

            try
            {
                // Manage the 'roles' that can be created with this backend.
                apiInstance.ReadSshRolesRole(role, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadSshRolesRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readtotpcodename"></a>
# **ReadTotpCodeName**
> void ReadTotpCodeName (string name, string mountPath = null)

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
    public class ReadTotpCodeNameExample
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
            var mountPath = "\"totp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "totp")

            try
            {
                // Request time-based one-time use password or validate a password for a certain key .
                apiInstance.ReadTotpCodeName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadTotpCodeName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;totp&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readtotpkeysname"></a>
# **ReadTotpKeysName**
> void ReadTotpKeysName (string name, string mountPath = null)

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
    public class ReadTotpKeysNameExample
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
            var mountPath = "\"totp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "totp")

            try
            {
                // Manage the keys that can be created with this backend.
                apiInstance.ReadTotpKeysName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadTotpKeysName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;totp&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readtransitbackupname"></a>
# **ReadTransitBackupName**
> void ReadTransitBackupName (string name, string mountPath = null)

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
    public class ReadTransitBackupNameExample
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
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Backup the named key
                apiInstance.ReadTransitBackupName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadTransitBackupName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readtransitcacheconfig"></a>
# **ReadTransitCacheConfig**
> void ReadTransitCacheConfig (string mountPath = null)

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
    public class ReadTransitCacheConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Returns the size of the active cache
                apiInstance.ReadTransitCacheConfig(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadTransitCacheConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readtransitexporttypename"></a>
# **ReadTransitExportTypeName**
> void ReadTransitExportTypeName (string name, string type, string mountPath = null)

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
    public class ReadTransitExportTypeNameExample
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
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Export named encryption or signing key
                apiInstance.ReadTransitExportTypeName(name, type, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadTransitExportTypeName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readtransitexporttypenameversion"></a>
# **ReadTransitExportTypeNameVersion**
> void ReadTransitExportTypeNameVersion (string name, string type, string version, string mountPath = null)

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
    public class ReadTransitExportTypeNameVersionExample
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
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Export named encryption or signing key
                apiInstance.ReadTransitExportTypeNameVersion(name, type, version, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadTransitExportTypeNameVersion: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readtransitwrappingkey"></a>
# **ReadTransitWrappingKey**
> void ReadTransitWrappingKey (string mountPath = null)

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
    public class ReadTransitWrappingKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Returns the public key to use for wrapping imported keys
                apiInstance.ReadTransitWrappingKey(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.ReadTransitWrappingKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateawsconfiglease"></a>
# **UpdateAwsConfigLease**
> void UpdateAwsConfigLease (string mountPath = null, AwsConfigLeaseRequest awsConfigLeaseRequest = null)

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
    public class UpdateAwsConfigLeaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")
            var awsConfigLeaseRequest = new AwsConfigLeaseRequest(); // AwsConfigLeaseRequest |  (optional) 

            try
            {
                // Configure the default lease information for generated credentials.
                apiInstance.UpdateAwsConfigLease(mountPath, awsConfigLeaseRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateAwsConfigLease: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="updateawsconfigroot"></a>
# **UpdateAwsConfigRoot**
> void UpdateAwsConfigRoot (string mountPath = null, AwsConfigRootRequest awsConfigRootRequest = null)

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
    public class UpdateAwsConfigRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")
            var awsConfigRootRequest = new AwsConfigRootRequest(); // AwsConfigRootRequest |  (optional) 

            try
            {
                // Configure the root credentials that are used to manage IAM.
                apiInstance.UpdateAwsConfigRoot(mountPath, awsConfigRootRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateAwsConfigRoot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="updateawscreds"></a>
# **UpdateAwsCreds**
> void UpdateAwsCreds (string mountPath = null, AwsCredsRequest awsCredsRequest = null)

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
    public class UpdateAwsCredsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")
            var awsCredsRequest = new AwsCredsRequest(); // AwsCredsRequest |  (optional) 

            try
            {
                // Generate AWS credentials from a specific Vault role.
                apiInstance.UpdateAwsCreds(mountPath, awsCredsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateAwsCreds: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="updateawsrolesname"></a>
# **UpdateAwsRolesName**
> void UpdateAwsRolesName (string name, string mountPath = null, AwsRolesRequest awsRolesRequest = null)

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
    public class UpdateAwsRolesNameExample
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
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")
            var awsRolesRequest = new AwsRolesRequest(); // AwsRolesRequest |  (optional) 

            try
            {
                // Read, write and reference IAM policies that access keys can be made for.
                apiInstance.UpdateAwsRolesName(name, mountPath, awsRolesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateAwsRolesName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]
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

<a name="updateawsstsname"></a>
# **UpdateAwsStsName**
> void UpdateAwsStsName (string name, string mountPath = null, AwsStsRequest awsStsRequest = null)

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
    public class UpdateAwsStsNameExample
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
            var mountPath = "\"aws\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "aws")
            var awsStsRequest = new AwsStsRequest(); // AwsStsRequest |  (optional) 

            try
            {
                // Generate AWS credentials from a specific Vault role.
                apiInstance.UpdateAwsStsName(name, mountPath, awsStsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateAwsStsName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;aws&quot;]
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

<a name="updatecubbyholepath"></a>
# **UpdateCubbyholePath**
> void UpdateCubbyholePath (string path, string mountPath = null)

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
    public class UpdateCubbyholePathExample
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
            var mountPath = "\"cubbyhole\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "cubbyhole")

            try
            {
                // Store a secret at the specified location.
                apiInstance.UpdateCubbyholePath(path, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateCubbyholePath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;cubbyhole&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategcpconfig"></a>
# **UpdateGcpConfig**
> void UpdateGcpConfig (string mountPath = null, GcpConfigRequest gcpConfigRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateGcpConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")
            var gcpConfigRequest = new GcpConfigRequest(); // GcpConfigRequest |  (optional) 

            try
            {
                apiInstance.UpdateGcpConfig(mountPath, gcpConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateGcpConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcp&quot;]
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

<a name="updategcpconfigrotateroot"></a>
# **UpdateGcpConfigRotateRoot**
> void UpdateGcpConfigRotateRoot (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateGcpConfigRotateRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.UpdateGcpConfigRotateRoot(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateGcpConfigRotateRoot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="updategcpkeyroleset"></a>
# **UpdateGcpKeyRoleset**
> void UpdateGcpKeyRoleset (string roleset, string mountPath = null, GcpKeyRequest gcpKeyRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateGcpKeyRolesetExample
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
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")
            var gcpKeyRequest = new GcpKeyRequest(); // GcpKeyRequest |  (optional) 

            try
            {
                apiInstance.UpdateGcpKeyRoleset(roleset, mountPath, gcpKeyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateGcpKeyRoleset: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcp&quot;]
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

<a name="updategcprolesetname"></a>
# **UpdateGcpRolesetName**
> void UpdateGcpRolesetName (string name, string mountPath = null, GcpRolesetRequest gcpRolesetRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateGcpRolesetNameExample
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
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")
            var gcpRolesetRequest = new GcpRolesetRequest(); // GcpRolesetRequest |  (optional) 

            try
            {
                apiInstance.UpdateGcpRolesetName(name, mountPath, gcpRolesetRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateGcpRolesetName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcp&quot;]
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

<a name="updategcprolesetnamerotate"></a>
# **UpdateGcpRolesetNameRotate**
> void UpdateGcpRolesetNameRotate (string name, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateGcpRolesetNameRotateExample
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
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.UpdateGcpRolesetNameRotate(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateGcpRolesetNameRotate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategcprolesetnamerotatekey"></a>
# **UpdateGcpRolesetNameRotateKey**
> void UpdateGcpRolesetNameRotateKey (string name, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateGcpRolesetNameRotateKeyExample
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
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.UpdateGcpRolesetNameRotateKey(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateGcpRolesetNameRotateKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategcprolesetrolesetkey"></a>
# **UpdateGcpRolesetRolesetKey**
> void UpdateGcpRolesetRolesetKey (string roleset, string mountPath = null, GcpRolesetKeyRequest gcpRolesetKeyRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateGcpRolesetRolesetKeyExample
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
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")
            var gcpRolesetKeyRequest = new GcpRolesetKeyRequest(); // GcpRolesetKeyRequest |  (optional) 

            try
            {
                apiInstance.UpdateGcpRolesetRolesetKey(roleset, mountPath, gcpRolesetKeyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateGcpRolesetRolesetKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcp&quot;]
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

<a name="updategcprolesetrolesettoken"></a>
# **UpdateGcpRolesetRolesetToken**
> void UpdateGcpRolesetRolesetToken (string roleset, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateGcpRolesetRolesetTokenExample
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
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.UpdateGcpRolesetRolesetToken(roleset, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateGcpRolesetRolesetToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="updategcpstaticaccountname"></a>
# **UpdateGcpStaticAccountName**
> void UpdateGcpStaticAccountName (string name, string mountPath = null, GcpStaticAccountRequest gcpStaticAccountRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateGcpStaticAccountNameExample
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
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")
            var gcpStaticAccountRequest = new GcpStaticAccountRequest(); // GcpStaticAccountRequest |  (optional) 

            try
            {
                apiInstance.UpdateGcpStaticAccountName(name, mountPath, gcpStaticAccountRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateGcpStaticAccountName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcp&quot;]
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

<a name="updategcpstaticaccountnamekey"></a>
# **UpdateGcpStaticAccountNameKey**
> void UpdateGcpStaticAccountNameKey (string name, string mountPath = null, GcpStaticAccountKeyRequest gcpStaticAccountKeyRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateGcpStaticAccountNameKeyExample
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
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")
            var gcpStaticAccountKeyRequest = new GcpStaticAccountKeyRequest(); // GcpStaticAccountKeyRequest |  (optional) 

            try
            {
                apiInstance.UpdateGcpStaticAccountNameKey(name, mountPath, gcpStaticAccountKeyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateGcpStaticAccountNameKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcp&quot;]
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

<a name="updategcpstaticaccountnamerotatekey"></a>
# **UpdateGcpStaticAccountNameRotateKey**
> void UpdateGcpStaticAccountNameRotateKey (string name, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateGcpStaticAccountNameRotateKeyExample
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
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.UpdateGcpStaticAccountNameRotateKey(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateGcpStaticAccountNameRotateKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="updategcpstaticaccountnametoken"></a>
# **UpdateGcpStaticAccountNameToken**
> void UpdateGcpStaticAccountNameToken (string name, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateGcpStaticAccountNameTokenExample
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
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.UpdateGcpStaticAccountNameToken(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateGcpStaticAccountNameToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="updategcptokenroleset"></a>
# **UpdateGcpTokenRoleset**
> void UpdateGcpTokenRoleset (string roleset, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateGcpTokenRolesetExample
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
            var mountPath = "\"gcp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcp")

            try
            {
                apiInstance.UpdateGcpTokenRoleset(roleset, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateGcpTokenRoleset: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="updategcpkmsdecryptkey"></a>
# **UpdateGcpkmsDecryptKey**
> void UpdateGcpkmsDecryptKey (string key, string mountPath = null, GcpkmsDecryptRequest gcpkmsDecryptRequest = null)

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
    public class UpdateGcpkmsDecryptKeyExample
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
            var mountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")
            var gcpkmsDecryptRequest = new GcpkmsDecryptRequest(); // GcpkmsDecryptRequest |  (optional) 

            try
            {
                // Decrypt a ciphertext value using a named key
                apiInstance.UpdateGcpkmsDecryptKey(key, mountPath, gcpkmsDecryptRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateGcpkmsDecryptKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]
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

<a name="updategcpkmsencryptkey"></a>
# **UpdateGcpkmsEncryptKey**
> void UpdateGcpkmsEncryptKey (string key, string mountPath = null, GcpkmsEncryptRequest gcpkmsEncryptRequest = null)

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
    public class UpdateGcpkmsEncryptKeyExample
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
            var mountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")
            var gcpkmsEncryptRequest = new GcpkmsEncryptRequest(); // GcpkmsEncryptRequest |  (optional) 

            try
            {
                // Encrypt a plaintext value using a named key
                apiInstance.UpdateGcpkmsEncryptKey(key, mountPath, gcpkmsEncryptRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateGcpkmsEncryptKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]
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

<a name="updategcpkmskeysconfigkey"></a>
# **UpdateGcpkmsKeysConfigKey**
> void UpdateGcpkmsKeysConfigKey (string key, string mountPath = null, GcpkmsKeysConfigRequest gcpkmsKeysConfigRequest = null)

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
    public class UpdateGcpkmsKeysConfigKeyExample
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
            var mountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")
            var gcpkmsKeysConfigRequest = new GcpkmsKeysConfigRequest(); // GcpkmsKeysConfigRequest |  (optional) 

            try
            {
                // Configure the key in Vault
                apiInstance.UpdateGcpkmsKeysConfigKey(key, mountPath, gcpkmsKeysConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateGcpkmsKeysConfigKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]
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

<a name="updategcpkmskeysderegisterkey"></a>
# **UpdateGcpkmsKeysDeregisterKey**
> void UpdateGcpkmsKeysDeregisterKey (string key, string mountPath = null)

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
    public class UpdateGcpkmsKeysDeregisterKeyExample
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
            var mountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Deregister an existing key in Vault
                apiInstance.UpdateGcpkmsKeysDeregisterKey(key, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateGcpkmsKeysDeregisterKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategcpkmskeyskey"></a>
# **UpdateGcpkmsKeysKey**
> void UpdateGcpkmsKeysKey (string key, string mountPath = null, GcpkmsKeysRequest gcpkmsKeysRequest = null)

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
    public class UpdateGcpkmsKeysKeyExample
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
            var mountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")
            var gcpkmsKeysRequest = new GcpkmsKeysRequest(); // GcpkmsKeysRequest |  (optional) 

            try
            {
                // Interact with crypto keys in Vault and Google Cloud KMS
                apiInstance.UpdateGcpkmsKeysKey(key, mountPath, gcpkmsKeysRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateGcpkmsKeysKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]
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

<a name="updategcpkmskeysregisterkey"></a>
# **UpdateGcpkmsKeysRegisterKey**
> void UpdateGcpkmsKeysRegisterKey (string key, string mountPath = null, GcpkmsKeysRegisterRequest gcpkmsKeysRegisterRequest = null)

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
    public class UpdateGcpkmsKeysRegisterKeyExample
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
            var mountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")
            var gcpkmsKeysRegisterRequest = new GcpkmsKeysRegisterRequest(); // GcpkmsKeysRegisterRequest |  (optional) 

            try
            {
                // Register an existing crypto key in Google Cloud KMS
                apiInstance.UpdateGcpkmsKeysRegisterKey(key, mountPath, gcpkmsKeysRegisterRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateGcpkmsKeysRegisterKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]
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

<a name="updategcpkmskeysrotatekey"></a>
# **UpdateGcpkmsKeysRotateKey**
> void UpdateGcpkmsKeysRotateKey (string key, string mountPath = null)

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
    public class UpdateGcpkmsKeysRotateKeyExample
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
            var mountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Rotate a crypto key to a new primary version
                apiInstance.UpdateGcpkmsKeysRotateKey(key, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateGcpkmsKeysRotateKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategcpkmskeystrimkey"></a>
# **UpdateGcpkmsKeysTrimKey**
> void UpdateGcpkmsKeysTrimKey (string key, string mountPath = null)

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
    public class UpdateGcpkmsKeysTrimKeyExample
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
            var mountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")

            try
            {
                // Delete old crypto key versions from Google Cloud KMS
                apiInstance.UpdateGcpkmsKeysTrimKey(key, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateGcpkmsKeysTrimKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategcpkmsreencryptkey"></a>
# **UpdateGcpkmsReencryptKey**
> void UpdateGcpkmsReencryptKey (string key, string mountPath = null, GcpkmsReencryptRequest gcpkmsReencryptRequest = null)

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
    public class UpdateGcpkmsReencryptKeyExample
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
            var mountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")
            var gcpkmsReencryptRequest = new GcpkmsReencryptRequest(); // GcpkmsReencryptRequest |  (optional) 

            try
            {
                // Re-encrypt existing ciphertext data to a new version
                apiInstance.UpdateGcpkmsReencryptKey(key, mountPath, gcpkmsReencryptRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateGcpkmsReencryptKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]
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

<a name="updategcpkmssignkey"></a>
# **UpdateGcpkmsSignKey**
> void UpdateGcpkmsSignKey (string key, string mountPath = null, GcpkmsSignRequest gcpkmsSignRequest = null)

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
    public class UpdateGcpkmsSignKeyExample
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
            var mountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")
            var gcpkmsSignRequest = new GcpkmsSignRequest(); // GcpkmsSignRequest |  (optional) 

            try
            {
                // Signs a message or digest using a named key
                apiInstance.UpdateGcpkmsSignKey(key, mountPath, gcpkmsSignRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateGcpkmsSignKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]
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

<a name="updategcpkmsverifykey"></a>
# **UpdateGcpkmsVerifyKey**
> void UpdateGcpkmsVerifyKey (string key, string mountPath = null, GcpkmsVerifyRequest gcpkmsVerifyRequest = null)

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
    public class UpdateGcpkmsVerifyKeyExample
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
            var mountPath = "\"gcpkms\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "gcpkms")
            var gcpkmsVerifyRequest = new GcpkmsVerifyRequest(); // GcpkmsVerifyRequest |  (optional) 

            try
            {
                // Verify a signature using a named key
                apiInstance.UpdateGcpkmsVerifyKey(key, mountPath, gcpkmsVerifyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateGcpkmsVerifyKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;gcpkms&quot;]
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

<a name="updateldaplibrarymanagenamecheckin"></a>
# **UpdateLdapLibraryManageNameCheckIn**
> void UpdateLdapLibraryManageNameCheckIn (string name, string mountPath = null, LdapLibraryManageCheckInRequest ldapLibraryManageCheckInRequest = null)

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
    public class UpdateLdapLibraryManageNameCheckInExample
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
            var mountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")
            var ldapLibraryManageCheckInRequest = new LdapLibraryManageCheckInRequest(); // LdapLibraryManageCheckInRequest |  (optional) 

            try
            {
                // Check service accounts in to the library.
                apiInstance.UpdateLdapLibraryManageNameCheckIn(name, mountPath, ldapLibraryManageCheckInRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateLdapLibraryManageNameCheckIn: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]
 **ldapLibraryManageCheckInRequest** | [**LdapLibraryManageCheckInRequest**](LdapLibraryManageCheckInRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateldaplibraryname"></a>
# **UpdateLdapLibraryName**
> void UpdateLdapLibraryName (string name, string mountPath = null, LdapLibraryRequest ldapLibraryRequest = null)

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
    public class UpdateLdapLibraryNameExample
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
            var mountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")
            var ldapLibraryRequest = new LdapLibraryRequest(); // LdapLibraryRequest |  (optional) 

            try
            {
                // Update a library set.
                apiInstance.UpdateLdapLibraryName(name, mountPath, ldapLibraryRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateLdapLibraryName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]
 **ldapLibraryRequest** | [**LdapLibraryRequest**](LdapLibraryRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateldaplibrarynamecheckin"></a>
# **UpdateLdapLibraryNameCheckIn**
> void UpdateLdapLibraryNameCheckIn (string name, string mountPath = null, LdapLibraryCheckInRequest ldapLibraryCheckInRequest = null)

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
    public class UpdateLdapLibraryNameCheckInExample
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
            var mountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")
            var ldapLibraryCheckInRequest = new LdapLibraryCheckInRequest(); // LdapLibraryCheckInRequest |  (optional) 

            try
            {
                // Check service accounts in to the library.
                apiInstance.UpdateLdapLibraryNameCheckIn(name, mountPath, ldapLibraryCheckInRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateLdapLibraryNameCheckIn: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]
 **ldapLibraryCheckInRequest** | [**LdapLibraryCheckInRequest**](LdapLibraryCheckInRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateldaplibrarynamecheckout"></a>
# **UpdateLdapLibraryNameCheckOut**
> void UpdateLdapLibraryNameCheckOut (string name, string mountPath = null, LdapLibraryCheckOutRequest ldapLibraryCheckOutRequest = null)

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
    public class UpdateLdapLibraryNameCheckOutExample
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
            var mountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")
            var ldapLibraryCheckOutRequest = new LdapLibraryCheckOutRequest(); // LdapLibraryCheckOutRequest |  (optional) 

            try
            {
                // Check a service account out from the library.
                apiInstance.UpdateLdapLibraryNameCheckOut(name, mountPath, ldapLibraryCheckOutRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateLdapLibraryNameCheckOut: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]
 **ldapLibraryCheckOutRequest** | [**LdapLibraryCheckOutRequest**](LdapLibraryCheckOutRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateldaprolename"></a>
# **UpdateLdapRoleName**
> void UpdateLdapRoleName (string name, string mountPath = null, LdapRoleRequest ldapRoleRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateLdapRoleNameExample
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
            var mountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")
            var ldapRoleRequest = new LdapRoleRequest(); // LdapRoleRequest |  (optional) 

            try
            {
                apiInstance.UpdateLdapRoleName(name, mountPath, ldapRoleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateLdapRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]
 **ldapRoleRequest** | [**LdapRoleRequest**](LdapRoleRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateldaprotaterolename"></a>
# **UpdateLdapRotateRoleName**
> void UpdateLdapRotateRoleName (string name, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateLdapRotateRoleNameExample
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
            var mountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.UpdateLdapRotateRoleName(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateLdapRotateRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateldaprotateroot"></a>
# **UpdateLdapRotateRoot**
> void UpdateLdapRotateRoot (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateLdapRotateRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")

            try
            {
                apiInstance.UpdateLdapRotateRoot(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateLdapRotateRoot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateldapstaticrolename"></a>
# **UpdateLdapStaticRoleName**
> void UpdateLdapStaticRoleName (string name, string mountPath = null, LdapStaticRoleRequest ldapStaticRoleRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateLdapStaticRoleNameExample
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
            var mountPath = "\"ldap\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ldap")
            var ldapStaticRoleRequest = new LdapStaticRoleRequest(); // LdapStaticRoleRequest |  (optional) 

            try
            {
                apiInstance.UpdateLdapStaticRoleName(name, mountPath, ldapStaticRoleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateLdapStaticRoleName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ldap&quot;]
 **ldapStaticRoleRequest** | [**LdapStaticRoleRequest**](LdapStaticRoleRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatenomadconfigaccess"></a>
# **UpdateNomadConfigAccess**
> void UpdateNomadConfigAccess (string mountPath = null, NomadConfigAccessRequest nomadConfigAccessRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateNomadConfigAccessExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"nomad\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "nomad")
            var nomadConfigAccessRequest = new NomadConfigAccessRequest(); // NomadConfigAccessRequest |  (optional) 

            try
            {
                apiInstance.UpdateNomadConfigAccess(mountPath, nomadConfigAccessRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateNomadConfigAccess: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;nomad&quot;]
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

<a name="updatepkibundle"></a>
# **UpdatePkiBundle**
> void UpdatePkiBundle (string mountPath = null, PkiBundleRequest pkiBundleRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiBundleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiBundleRequest = new PkiBundleRequest(); // PkiBundleRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiBundle(mountPath, pkiBundleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiBundle: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkicert"></a>
# **UpdatePkiCert**
> void UpdatePkiCert (string mountPath = null, PkiCertRequest pkiCertRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiCertExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiCertRequest = new PkiCertRequest(); // PkiCertRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiCert(mountPath, pkiCertRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiCert: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkiconfigautotidy"></a>
# **UpdatePkiConfigAutoTidy**
> void UpdatePkiConfigAutoTidy (string mountPath = null, PkiConfigAutoTidyRequest pkiConfigAutoTidyRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiConfigAutoTidyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiConfigAutoTidyRequest = new PkiConfigAutoTidyRequest(); // PkiConfigAutoTidyRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiConfigAutoTidy(mountPath, pkiConfigAutoTidyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiConfigAutoTidy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
 **pkiConfigAutoTidyRequest** | [**PkiConfigAutoTidyRequest**](PkiConfigAutoTidyRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepkiconfigca"></a>
# **UpdatePkiConfigCa**
> void UpdatePkiConfigCa (string mountPath = null, PkiConfigCaRequest pkiConfigCaRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiConfigCaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiConfigCaRequest = new PkiConfigCaRequest(); // PkiConfigCaRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiConfigCa(mountPath, pkiConfigCaRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiConfigCa: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkiconfigcrl"></a>
# **UpdatePkiConfigCrl**
> void UpdatePkiConfigCrl (string mountPath = null, PkiConfigCrlRequest pkiConfigCrlRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiConfigCrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiConfigCrlRequest = new PkiConfigCrlRequest(); // PkiConfigCrlRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiConfigCrl(mountPath, pkiConfigCrlRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiConfigCrl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkiconfigissuers"></a>
# **UpdatePkiConfigIssuers**
> void UpdatePkiConfigIssuers (string mountPath = null, PkiConfigIssuersRequest pkiConfigIssuersRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiConfigIssuersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiConfigIssuersRequest = new PkiConfigIssuersRequest(); // PkiConfigIssuersRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiConfigIssuers(mountPath, pkiConfigIssuersRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiConfigIssuers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkiconfigkeys"></a>
# **UpdatePkiConfigKeys**
> void UpdatePkiConfigKeys (string mountPath = null, PkiConfigKeysRequest pkiConfigKeysRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiConfigKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiConfigKeysRequest = new PkiConfigKeysRequest(); // PkiConfigKeysRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiConfigKeys(mountPath, pkiConfigKeysRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiConfigKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkiconfigurls"></a>
# **UpdatePkiConfigUrls**
> void UpdatePkiConfigUrls (string mountPath = null, PkiConfigUrlsRequest pkiConfigUrlsRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiConfigUrlsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiConfigUrlsRequest = new PkiConfigUrlsRequest(); // PkiConfigUrlsRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiConfigUrls(mountPath, pkiConfigUrlsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiConfigUrls: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkiintermediatecrosssign"></a>
# **UpdatePkiIntermediateCrossSign**
> void UpdatePkiIntermediateCrossSign (string mountPath = null, PkiIntermediateCrossSignRequest pkiIntermediateCrossSignRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiIntermediateCrossSignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiIntermediateCrossSignRequest = new PkiIntermediateCrossSignRequest(); // PkiIntermediateCrossSignRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiIntermediateCrossSign(mountPath, pkiIntermediateCrossSignRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiIntermediateCrossSign: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkiintermediategenerateexported"></a>
# **UpdatePkiIntermediateGenerateExported**
> void UpdatePkiIntermediateGenerateExported (string exported, string mountPath = null, PkiIntermediateGenerateRequest pkiIntermediateGenerateRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiIntermediateGenerateExportedExample
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiIntermediateGenerateRequest = new PkiIntermediateGenerateRequest(); // PkiIntermediateGenerateRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiIntermediateGenerateExported(exported, mountPath, pkiIntermediateGenerateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiIntermediateGenerateExported: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkiintermediatesetsigned"></a>
# **UpdatePkiIntermediateSetSigned**
> void UpdatePkiIntermediateSetSigned (string mountPath = null, PkiIntermediateSetSignedRequest pkiIntermediateSetSignedRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiIntermediateSetSignedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiIntermediateSetSignedRequest = new PkiIntermediateSetSignedRequest(); // PkiIntermediateSetSignedRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiIntermediateSetSigned(mountPath, pkiIntermediateSetSignedRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiIntermediateSetSigned: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkiissuerole"></a>
# **UpdatePkiIssueRole**
> void UpdatePkiIssueRole (string role, string mountPath = null, PkiIssueRequest pkiIssueRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiIssueRoleExample
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiIssueRequest = new PkiIssueRequest(); // PkiIssueRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiIssueRole(role, mountPath, pkiIssueRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiIssueRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkiissuerissuerrefissuerole"></a>
# **UpdatePkiIssuerIssuerRefIssueRole**
> void UpdatePkiIssuerIssuerRefIssueRole (string issuerRef, string role, string mountPath = null, PkiIssuerIssueRequest pkiIssuerIssueRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiIssuerIssuerRefIssueRoleExample
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiIssuerIssueRequest = new PkiIssuerIssueRequest(); // PkiIssuerIssueRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiIssuerIssuerRefIssueRole(issuerRef, role, mountPath, pkiIssuerIssueRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiIssuerIssuerRefIssueRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkiissuerissuerrefrevoke"></a>
# **UpdatePkiIssuerIssuerRefRevoke**
> void UpdatePkiIssuerIssuerRefRevoke (string issuerRef, string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiIssuerIssuerRefRevokeExample
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.UpdatePkiIssuerIssuerRefRevoke(issuerRef, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiIssuerIssuerRefRevoke: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepkiissuerissuerrefsignintermediate"></a>
# **UpdatePkiIssuerIssuerRefSignIntermediate**
> void UpdatePkiIssuerIssuerRefSignIntermediate (string issuerRef, string mountPath = null, PkiIssuerSignIntermediateRequest pkiIssuerSignIntermediateRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiIssuerIssuerRefSignIntermediateExample
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiIssuerSignIntermediateRequest = new PkiIssuerSignIntermediateRequest(); // PkiIssuerSignIntermediateRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiIssuerIssuerRefSignIntermediate(issuerRef, mountPath, pkiIssuerSignIntermediateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiIssuerIssuerRefSignIntermediate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkiissuerissuerrefsignrole"></a>
# **UpdatePkiIssuerIssuerRefSignRole**
> void UpdatePkiIssuerIssuerRefSignRole (string issuerRef, string role, string mountPath = null, PkiIssuerSignRequest pkiIssuerSignRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiIssuerIssuerRefSignRoleExample
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiIssuerSignRequest = new PkiIssuerSignRequest(); // PkiIssuerSignRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiIssuerIssuerRefSignRole(issuerRef, role, mountPath, pkiIssuerSignRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiIssuerIssuerRefSignRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkiissuerissuerrefsignselfissued"></a>
# **UpdatePkiIssuerIssuerRefSignSelfIssued**
> void UpdatePkiIssuerIssuerRefSignSelfIssued (string issuerRef, string mountPath = null, PkiIssuerSignSelfIssuedRequest pkiIssuerSignSelfIssuedRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiIssuerIssuerRefSignSelfIssuedExample
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiIssuerSignSelfIssuedRequest = new PkiIssuerSignSelfIssuedRequest(); // PkiIssuerSignSelfIssuedRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiIssuerIssuerRefSignSelfIssued(issuerRef, mountPath, pkiIssuerSignSelfIssuedRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiIssuerIssuerRefSignSelfIssued: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkiissuerissuerrefsignverbatim"></a>
# **UpdatePkiIssuerIssuerRefSignVerbatim**
> void UpdatePkiIssuerIssuerRefSignVerbatim (string issuerRef, string mountPath = null, PkiIssuerSignVerbatimRequest pkiIssuerSignVerbatimRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiIssuerIssuerRefSignVerbatimExample
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiIssuerSignVerbatimRequest = new PkiIssuerSignVerbatimRequest(); // PkiIssuerSignVerbatimRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiIssuerIssuerRefSignVerbatim(issuerRef, mountPath, pkiIssuerSignVerbatimRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiIssuerIssuerRefSignVerbatim: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkiissuerissuerrefsignverbatimrole"></a>
# **UpdatePkiIssuerIssuerRefSignVerbatimRole**
> void UpdatePkiIssuerIssuerRefSignVerbatimRole (string issuerRef, string role, string mountPath = null, PkiIssuerSignVerbatimRequest pkiIssuerSignVerbatimRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiIssuerIssuerRefSignVerbatimRoleExample
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiIssuerSignVerbatimRequest = new PkiIssuerSignVerbatimRequest(); // PkiIssuerSignVerbatimRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiIssuerIssuerRefSignVerbatimRole(issuerRef, role, mountPath, pkiIssuerSignVerbatimRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiIssuerIssuerRefSignVerbatimRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkiissuersgenerateintermediateexported"></a>
# **UpdatePkiIssuersGenerateIntermediateExported**
> void UpdatePkiIssuersGenerateIntermediateExported (string exported, string mountPath = null, PkiIssuersGenerateIntermediateRequest pkiIssuersGenerateIntermediateRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiIssuersGenerateIntermediateExportedExample
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiIssuersGenerateIntermediateRequest = new PkiIssuersGenerateIntermediateRequest(); // PkiIssuersGenerateIntermediateRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiIssuersGenerateIntermediateExported(exported, mountPath, pkiIssuersGenerateIntermediateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiIssuersGenerateIntermediateExported: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkiissuersgeneraterootexported"></a>
# **UpdatePkiIssuersGenerateRootExported**
> void UpdatePkiIssuersGenerateRootExported (string exported, string mountPath = null, PkiIssuersGenerateRootRequest pkiIssuersGenerateRootRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiIssuersGenerateRootExportedExample
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiIssuersGenerateRootRequest = new PkiIssuersGenerateRootRequest(); // PkiIssuersGenerateRootRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiIssuersGenerateRootExported(exported, mountPath, pkiIssuersGenerateRootRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiIssuersGenerateRootExported: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkijson"></a>
# **UpdatePkiJson**
> void UpdatePkiJson (string mountPath = null, PkiJsonRequest pkiJsonRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiJsonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiJsonRequest = new PkiJsonRequest(); // PkiJsonRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiJson(mountPath, pkiJsonRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiJson: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkikeykeyref"></a>
# **UpdatePkiKeyKeyRef**
> void UpdatePkiKeyKeyRef (string keyRef, string mountPath = null, PkiKeyRequest pkiKeyRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiKeyKeyRefExample
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiKeyRequest = new PkiKeyRequest(); // PkiKeyRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiKeyKeyRef(keyRef, mountPath, pkiKeyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiKeyKeyRef: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkikeysimport"></a>
# **UpdatePkiKeysImport**
> void UpdatePkiKeysImport (string mountPath = null, PkiKeysImportRequest pkiKeysImportRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiKeysImportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiKeysImportRequest = new PkiKeysImportRequest(); // PkiKeysImportRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiKeysImport(mountPath, pkiKeysImportRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiKeysImport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkikms"></a>
# **UpdatePkiKms**
> void UpdatePkiKms (string mountPath = null, PkiKmsRequest pkiKmsRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiKmsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiKmsRequest = new PkiKmsRequest(); // PkiKmsRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiKms(mountPath, pkiKmsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiKms: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkiocsp"></a>
# **UpdatePkiOcsp**
> void UpdatePkiOcsp (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiOcspExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.UpdatePkiOcsp(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiOcsp: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepkirevoke"></a>
# **UpdatePkiRevoke**
> void UpdatePkiRevoke (string mountPath = null, PkiRevokeRequest pkiRevokeRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiRevokeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiRevokeRequest = new PkiRevokeRequest(); // PkiRevokeRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiRevoke(mountPath, pkiRevokeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiRevoke: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkirevokewithkey"></a>
# **UpdatePkiRevokeWithKey**
> void UpdatePkiRevokeWithKey (string mountPath = null, PkiRevokeWithKeyRequest pkiRevokeWithKeyRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiRevokeWithKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiRevokeWithKeyRequest = new PkiRevokeWithKeyRequest(); // PkiRevokeWithKeyRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiRevokeWithKey(mountPath, pkiRevokeWithKeyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiRevokeWithKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
 **pkiRevokeWithKeyRequest** | [**PkiRevokeWithKeyRequest**](PkiRevokeWithKeyRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepkirootgenerateexported"></a>
# **UpdatePkiRootGenerateExported**
> void UpdatePkiRootGenerateExported (string exported, string mountPath = null, PkiRootGenerateRequest pkiRootGenerateRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiRootGenerateExportedExample
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiRootGenerateRequest = new PkiRootGenerateRequest(); // PkiRootGenerateRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiRootGenerateExported(exported, mountPath, pkiRootGenerateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiRootGenerateExported: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkirootreplace"></a>
# **UpdatePkiRootReplace**
> void UpdatePkiRootReplace (string mountPath = null, PkiRootReplaceRequest pkiRootReplaceRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiRootReplaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiRootReplaceRequest = new PkiRootReplaceRequest(); // PkiRootReplaceRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiRootReplace(mountPath, pkiRootReplaceRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiRootReplace: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkirootrotateexported"></a>
# **UpdatePkiRootRotateExported**
> void UpdatePkiRootRotateExported (string exported, string mountPath = null, PkiRootRotateRequest pkiRootRotateRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiRootRotateExportedExample
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiRootRotateRequest = new PkiRootRotateRequest(); // PkiRootRotateRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiRootRotateExported(exported, mountPath, pkiRootRotateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiRootRotateExported: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkirootsignintermediate"></a>
# **UpdatePkiRootSignIntermediate**
> void UpdatePkiRootSignIntermediate (string mountPath = null, PkiRootSignIntermediateRequest pkiRootSignIntermediateRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiRootSignIntermediateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiRootSignIntermediateRequest = new PkiRootSignIntermediateRequest(); // PkiRootSignIntermediateRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiRootSignIntermediate(mountPath, pkiRootSignIntermediateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiRootSignIntermediate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkirootsignselfissued"></a>
# **UpdatePkiRootSignSelfIssued**
> void UpdatePkiRootSignSelfIssued (string mountPath = null, PkiRootSignSelfIssuedRequest pkiRootSignSelfIssuedRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiRootSignSelfIssuedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiRootSignSelfIssuedRequest = new PkiRootSignSelfIssuedRequest(); // PkiRootSignSelfIssuedRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiRootSignSelfIssued(mountPath, pkiRootSignSelfIssuedRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiRootSignSelfIssued: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkisignrole"></a>
# **UpdatePkiSignRole**
> void UpdatePkiSignRole (string role, string mountPath = null, PkiSignRequest pkiSignRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiSignRoleExample
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiSignRequest = new PkiSignRequest(); // PkiSignRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiSignRole(role, mountPath, pkiSignRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiSignRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkisignverbatim"></a>
# **UpdatePkiSignVerbatim**
> void UpdatePkiSignVerbatim (string mountPath = null, PkiSignVerbatimRequest pkiSignVerbatimRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiSignVerbatimExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiSignVerbatimRequest = new PkiSignVerbatimRequest(); // PkiSignVerbatimRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiSignVerbatim(mountPath, pkiSignVerbatimRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiSignVerbatim: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkisignverbatimrole"></a>
# **UpdatePkiSignVerbatimRole**
> void UpdatePkiSignVerbatimRole (string role, string mountPath = null, PkiSignVerbatimRequest pkiSignVerbatimRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiSignVerbatimRoleExample
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
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiSignVerbatimRequest = new PkiSignVerbatimRequest(); // PkiSignVerbatimRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiSignVerbatimRole(role, mountPath, pkiSignVerbatimRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiSignVerbatimRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkitidy"></a>
# **UpdatePkiTidy**
> void UpdatePkiTidy (string mountPath = null, PkiTidyRequest pkiTidyRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiTidyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")
            var pkiTidyRequest = new PkiTidyRequest(); // PkiTidyRequest |  (optional) 

            try
            {
                apiInstance.UpdatePkiTidy(mountPath, pkiTidyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiTidy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]
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

<a name="updatepkitidycancel"></a>
# **UpdatePkiTidyCancel**
> void UpdatePkiTidyCancel (string mountPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdatePkiTidyCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"pki\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "pki")

            try
            {
                apiInstance.UpdatePkiTidyCancel(mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdatePkiTidyCancel: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;pki&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterabbitmqconfigconnection"></a>
# **UpdateRabbitmqConfigConnection**
> void UpdateRabbitmqConfigConnection (string mountPath = null, RabbitmqConfigConnectionRequest rabbitmqConfigConnectionRequest = null)

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
    public class UpdateRabbitmqConfigConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"rabbitmq\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "rabbitmq")
            var rabbitmqConfigConnectionRequest = new RabbitmqConfigConnectionRequest(); // RabbitmqConfigConnectionRequest |  (optional) 

            try
            {
                // Configure the connection URI, username, and password to talk to RabbitMQ management HTTP API.
                apiInstance.UpdateRabbitmqConfigConnection(mountPath, rabbitmqConfigConnectionRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateRabbitmqConfigConnection: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;rabbitmq&quot;]
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

<a name="updatesecretdatapath"></a>
# **UpdateSecretDataPath**
> void UpdateSecretDataPath (string path, string mountPath = null, KvDataRequest kvDataRequest = null)

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
    public class UpdateSecretDataPathExample
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
            var mountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")
            var kvDataRequest = new KvDataRequest(); // KvDataRequest |  (optional) 

            try
            {
                // Write, Patch, Read, and Delete data in the Key-Value Store.
                apiInstance.UpdateSecretDataPath(path, mountPath, kvDataRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateSecretDataPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;secret&quot;]
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

<a name="updatesecretdeletepath"></a>
# **UpdateSecretDeletePath**
> void UpdateSecretDeletePath (string path, string mountPath = null, KvDeleteRequest kvDeleteRequest = null)

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
    public class UpdateSecretDeletePathExample
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
            var mountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")
            var kvDeleteRequest = new KvDeleteRequest(); // KvDeleteRequest |  (optional) 

            try
            {
                // Marks one or more versions as deleted in the KV store.
                apiInstance.UpdateSecretDeletePath(path, mountPath, kvDeleteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateSecretDeletePath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;secret&quot;]
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

<a name="updatesecretdestroypath"></a>
# **UpdateSecretDestroyPath**
> void UpdateSecretDestroyPath (string path, string mountPath = null, KvDestroyRequest kvDestroyRequest = null)

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
    public class UpdateSecretDestroyPathExample
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
            var mountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")
            var kvDestroyRequest = new KvDestroyRequest(); // KvDestroyRequest |  (optional) 

            try
            {
                // Permanently removes one or more versions in the KV store
                apiInstance.UpdateSecretDestroyPath(path, mountPath, kvDestroyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateSecretDestroyPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;secret&quot;]
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

<a name="updatesecretmetadatapath"></a>
# **UpdateSecretMetadataPath**
> void UpdateSecretMetadataPath (string path, string mountPath = null, KvMetadataRequest kvMetadataRequest = null)

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
    public class UpdateSecretMetadataPathExample
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
            var mountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")
            var kvMetadataRequest = new KvMetadataRequest(); // KvMetadataRequest |  (optional) 

            try
            {
                // Configures settings for the KV store
                apiInstance.UpdateSecretMetadataPath(path, mountPath, kvMetadataRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateSecretMetadataPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;secret&quot;]
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

<a name="updatesecretundeletepath"></a>
# **UpdateSecretUndeletePath**
> void UpdateSecretUndeletePath (string path, string mountPath = null, KvUndeleteRequest kvUndeleteRequest = null)

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
    public class UpdateSecretUndeletePathExample
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
            var mountPath = "\"secret\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "secret")
            var kvUndeleteRequest = new KvUndeleteRequest(); // KvUndeleteRequest |  (optional) 

            try
            {
                // Undeletes one or more versions from the KV store.
                apiInstance.UpdateSecretUndeletePath(path, mountPath, kvUndeleteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateSecretUndeletePath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;secret&quot;]
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

<a name="updatesshconfigzeroaddress"></a>
# **UpdateSshConfigZeroaddress**
> void UpdateSshConfigZeroaddress (string mountPath = null, SshConfigZeroaddressRequest sshConfigZeroaddressRequest = null)

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
    public class UpdateSshConfigZeroaddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")
            var sshConfigZeroaddressRequest = new SshConfigZeroaddressRequest(); // SshConfigZeroaddressRequest |  (optional) 

            try
            {
                // Assign zero address as default CIDR block for select roles.
                apiInstance.UpdateSshConfigZeroaddress(mountPath, sshConfigZeroaddressRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateSshConfigZeroaddress: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]
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

<a name="updatesshkeyskeyname"></a>
# **UpdateSshKeysKeyName**
> void UpdateSshKeysKeyName (string keyName, string mountPath = null, SshKeysRequest sshKeysRequest = null)

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
    public class UpdateSshKeysKeyNameExample
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
            var mountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")
            var sshKeysRequest = new SshKeysRequest(); // SshKeysRequest |  (optional) 

            try
            {
                // Register a shared private key with Vault.
                apiInstance.UpdateSshKeysKeyName(keyName, mountPath, sshKeysRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateSshKeysKeyName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]
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

<a name="updatesshlookup"></a>
# **UpdateSshLookup**
> void UpdateSshLookup (string mountPath = null, SshLookupRequest sshLookupRequest = null)

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
    public class UpdateSshLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")
            var sshLookupRequest = new SshLookupRequest(); // SshLookupRequest |  (optional) 

            try
            {
                // List all the roles associated with the given IP address.
                apiInstance.UpdateSshLookup(mountPath, sshLookupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateSshLookup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]
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

<a name="updatesshrolesrole"></a>
# **UpdateSshRolesRole**
> void UpdateSshRolesRole (string role, string mountPath = null, SshRolesRequest sshRolesRequest = null)

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
    public class UpdateSshRolesRoleExample
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
            var mountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")
            var sshRolesRequest = new SshRolesRequest(); // SshRolesRequest |  (optional) 

            try
            {
                // Manage the 'roles' that can be created with this backend.
                apiInstance.UpdateSshRolesRole(role, mountPath, sshRolesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateSshRolesRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]
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

<a name="updatesshverify"></a>
# **UpdateSshVerify**
> void UpdateSshVerify (string mountPath = null, SshVerifyRequest sshVerifyRequest = null)

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
    public class UpdateSshVerifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"ssh\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "ssh")
            var sshVerifyRequest = new SshVerifyRequest(); // SshVerifyRequest |  (optional) 

            try
            {
                // Validate the OTP provided by Vault SSH Agent.
                apiInstance.UpdateSshVerify(mountPath, sshVerifyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateSshVerify: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;ssh&quot;]
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

<a name="updatetotpcodename"></a>
# **UpdateTotpCodeName**
> void UpdateTotpCodeName (string name, string mountPath = null, TotpCodeRequest totpCodeRequest = null)

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
    public class UpdateTotpCodeNameExample
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
            var mountPath = "\"totp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "totp")
            var totpCodeRequest = new TotpCodeRequest(); // TotpCodeRequest |  (optional) 

            try
            {
                // Request time-based one-time use password or validate a password for a certain key .
                apiInstance.UpdateTotpCodeName(name, mountPath, totpCodeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTotpCodeName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;totp&quot;]
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

<a name="updatetotpkeysname"></a>
# **UpdateTotpKeysName**
> void UpdateTotpKeysName (string name, string mountPath = null, TotpKeysRequest totpKeysRequest = null)

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
    public class UpdateTotpKeysNameExample
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
            var mountPath = "\"totp\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "totp")
            var totpKeysRequest = new TotpKeysRequest(); // TotpKeysRequest |  (optional) 

            try
            {
                // Manage the keys that can be created with this backend.
                apiInstance.UpdateTotpKeysName(name, mountPath, totpKeysRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTotpKeysName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;totp&quot;]
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

<a name="updatetransitcacheconfig"></a>
# **UpdateTransitCacheConfig**
> void UpdateTransitCacheConfig (string mountPath = null, TransitCacheConfigRequest transitCacheConfigRequest = null)

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
    public class UpdateTransitCacheConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")
            var transitCacheConfigRequest = new TransitCacheConfigRequest(); // TransitCacheConfigRequest |  (optional) 

            try
            {
                // Configures a new cache of the specified size
                apiInstance.UpdateTransitCacheConfig(mountPath, transitCacheConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTransitCacheConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]
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

<a name="updatetransitdatakeyplaintextname"></a>
# **UpdateTransitDatakeyPlaintextName**
> void UpdateTransitDatakeyPlaintextName (string name, string plaintext, string mountPath = null, TransitDatakeyRequest transitDatakeyRequest = null)

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
    public class UpdateTransitDatakeyPlaintextNameExample
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
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")
            var transitDatakeyRequest = new TransitDatakeyRequest(); // TransitDatakeyRequest |  (optional) 

            try
            {
                // Generate a data key
                apiInstance.UpdateTransitDatakeyPlaintextName(name, plaintext, mountPath, transitDatakeyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTransitDatakeyPlaintextName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]
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

<a name="updatetransitdecryptname"></a>
# **UpdateTransitDecryptName**
> void UpdateTransitDecryptName (string name, string mountPath = null, TransitDecryptRequest transitDecryptRequest = null)

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
    public class UpdateTransitDecryptNameExample
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
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")
            var transitDecryptRequest = new TransitDecryptRequest(); // TransitDecryptRequest |  (optional) 

            try
            {
                // Decrypt a ciphertext value using a named key
                apiInstance.UpdateTransitDecryptName(name, mountPath, transitDecryptRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTransitDecryptName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]
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

<a name="updatetransitencryptname"></a>
# **UpdateTransitEncryptName**
> void UpdateTransitEncryptName (string name, string mountPath = null, TransitEncryptRequest transitEncryptRequest = null)

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
    public class UpdateTransitEncryptNameExample
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
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")
            var transitEncryptRequest = new TransitEncryptRequest(); // TransitEncryptRequest |  (optional) 

            try
            {
                // Encrypt a plaintext value or a batch of plaintext blocks using a named key
                apiInstance.UpdateTransitEncryptName(name, mountPath, transitEncryptRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTransitEncryptName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]
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

<a name="updatetransithash"></a>
# **UpdateTransitHash**
> void UpdateTransitHash (string mountPath = null, TransitHashRequest transitHashRequest = null)

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
    public class UpdateTransitHashExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")
            var transitHashRequest = new TransitHashRequest(); // TransitHashRequest |  (optional) 

            try
            {
                // Generate a hash sum for input data
                apiInstance.UpdateTransitHash(mountPath, transitHashRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTransitHash: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]
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

<a name="updatetransithashurlalgorithm"></a>
# **UpdateTransitHashUrlalgorithm**
> void UpdateTransitHashUrlalgorithm (string urlalgorithm, string mountPath = null, TransitHashRequest transitHashRequest = null)

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
    public class UpdateTransitHashUrlalgorithmExample
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
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")
            var transitHashRequest = new TransitHashRequest(); // TransitHashRequest |  (optional) 

            try
            {
                // Generate a hash sum for input data
                apiInstance.UpdateTransitHashUrlalgorithm(urlalgorithm, mountPath, transitHashRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTransitHashUrlalgorithm: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]
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

<a name="updatetransithmacname"></a>
# **UpdateTransitHmacName**
> void UpdateTransitHmacName (string name, string mountPath = null, TransitHmacRequest transitHmacRequest = null)

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
    public class UpdateTransitHmacNameExample
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
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")
            var transitHmacRequest = new TransitHmacRequest(); // TransitHmacRequest |  (optional) 

            try
            {
                // Generate an HMAC for input data using the named key
                apiInstance.UpdateTransitHmacName(name, mountPath, transitHmacRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTransitHmacName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]
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

<a name="updatetransithmacnameurlalgorithm"></a>
# **UpdateTransitHmacNameUrlalgorithm**
> void UpdateTransitHmacNameUrlalgorithm (string name, string urlalgorithm, string mountPath = null, TransitHmacRequest transitHmacRequest = null)

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
    public class UpdateTransitHmacNameUrlalgorithmExample
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
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")
            var transitHmacRequest = new TransitHmacRequest(); // TransitHmacRequest |  (optional) 

            try
            {
                // Generate an HMAC for input data using the named key
                apiInstance.UpdateTransitHmacNameUrlalgorithm(name, urlalgorithm, mountPath, transitHmacRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTransitHmacNameUrlalgorithm: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]
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

<a name="updatetransitkeysnameconfig"></a>
# **UpdateTransitKeysNameConfig**
> void UpdateTransitKeysNameConfig (string name, string mountPath = null, TransitKeysConfigRequest transitKeysConfigRequest = null)

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
    public class UpdateTransitKeysNameConfigExample
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
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")
            var transitKeysConfigRequest = new TransitKeysConfigRequest(); // TransitKeysConfigRequest |  (optional) 

            try
            {
                // Configure a named encryption key
                apiInstance.UpdateTransitKeysNameConfig(name, mountPath, transitKeysConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTransitKeysNameConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]
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

<a name="updatetransitkeysnameimport"></a>
# **UpdateTransitKeysNameImport**
> void UpdateTransitKeysNameImport (string name, string mountPath = null, TransitKeysImportRequest transitKeysImportRequest = null)

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
    public class UpdateTransitKeysNameImportExample
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
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")
            var transitKeysImportRequest = new TransitKeysImportRequest(); // TransitKeysImportRequest |  (optional) 

            try
            {
                // Imports an externally-generated key into a new transit key
                apiInstance.UpdateTransitKeysNameImport(name, mountPath, transitKeysImportRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTransitKeysNameImport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]
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

<a name="updatetransitkeysnameimportversion"></a>
# **UpdateTransitKeysNameImportVersion**
> void UpdateTransitKeysNameImportVersion (string name, string mountPath = null, TransitKeysImportVersionRequest transitKeysImportVersionRequest = null)

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
    public class UpdateTransitKeysNameImportVersionExample
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
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")
            var transitKeysImportVersionRequest = new TransitKeysImportVersionRequest(); // TransitKeysImportVersionRequest |  (optional) 

            try
            {
                // Imports an externally-generated key into an existing imported key
                apiInstance.UpdateTransitKeysNameImportVersion(name, mountPath, transitKeysImportVersionRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTransitKeysNameImportVersion: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]
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

<a name="updatetransitkeysnamerotate"></a>
# **UpdateTransitKeysNameRotate**
> void UpdateTransitKeysNameRotate (string name, string mountPath = null)

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
    public class UpdateTransitKeysNameRotateExample
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
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")

            try
            {
                // Rotate named encryption key
                apiInstance.UpdateTransitKeysNameRotate(name, mountPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTransitKeysNameRotate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetransitkeysnametrim"></a>
# **UpdateTransitKeysNameTrim**
> void UpdateTransitKeysNameTrim (string name, string mountPath = null, TransitKeysTrimRequest transitKeysTrimRequest = null)

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
    public class UpdateTransitKeysNameTrimExample
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
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")
            var transitKeysTrimRequest = new TransitKeysTrimRequest(); // TransitKeysTrimRequest |  (optional) 

            try
            {
                // Trim key versions of a named key
                apiInstance.UpdateTransitKeysNameTrim(name, mountPath, transitKeysTrimRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTransitKeysNameTrim: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]
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

<a name="updatetransitrandom"></a>
# **UpdateTransitRandom**
> void UpdateTransitRandom (string mountPath = null, TransitRandomRequest transitRandomRequest = null)

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
    public class UpdateTransitRandomExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")
            var transitRandomRequest = new TransitRandomRequest(); // TransitRandomRequest |  (optional) 

            try
            {
                // Generate random bytes
                apiInstance.UpdateTransitRandom(mountPath, transitRandomRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTransitRandom: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]
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

<a name="updatetransitrandomsource"></a>
# **UpdateTransitRandomSource**
> void UpdateTransitRandomSource (string source, string mountPath = null, TransitRandomRequest transitRandomRequest = null)

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
    public class UpdateTransitRandomSourceExample
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
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")
            var transitRandomRequest = new TransitRandomRequest(); // TransitRandomRequest |  (optional) 

            try
            {
                // Generate random bytes
                apiInstance.UpdateTransitRandomSource(source, mountPath, transitRandomRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTransitRandomSource: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]
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

<a name="updatetransitrandomsourceurlbytes"></a>
# **UpdateTransitRandomSourceUrlbytes**
> void UpdateTransitRandomSourceUrlbytes (string source, string urlbytes, string mountPath = null, TransitRandomRequest transitRandomRequest = null)

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
    public class UpdateTransitRandomSourceUrlbytesExample
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
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")
            var transitRandomRequest = new TransitRandomRequest(); // TransitRandomRequest |  (optional) 

            try
            {
                // Generate random bytes
                apiInstance.UpdateTransitRandomSourceUrlbytes(source, urlbytes, mountPath, transitRandomRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTransitRandomSourceUrlbytes: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]
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

<a name="updatetransitrandomurlbytes"></a>
# **UpdateTransitRandomUrlbytes**
> void UpdateTransitRandomUrlbytes (string urlbytes, string mountPath = null, TransitRandomRequest transitRandomRequest = null)

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
    public class UpdateTransitRandomUrlbytesExample
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
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")
            var transitRandomRequest = new TransitRandomRequest(); // TransitRandomRequest |  (optional) 

            try
            {
                // Generate random bytes
                apiInstance.UpdateTransitRandomUrlbytes(urlbytes, mountPath, transitRandomRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTransitRandomUrlbytes: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]
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

<a name="updatetransitrestore"></a>
# **UpdateTransitRestore**
> void UpdateTransitRestore (string mountPath = null, TransitRestoreRequest transitRestoreRequest = null)

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
    public class UpdateTransitRestoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new Secrets(httpClient, config, httpClientHandler);
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")
            var transitRestoreRequest = new TransitRestoreRequest(); // TransitRestoreRequest |  (optional) 

            try
            {
                // Restore the named key
                apiInstance.UpdateTransitRestore(mountPath, transitRestoreRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTransitRestore: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]
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

<a name="updatetransitrestorename"></a>
# **UpdateTransitRestoreName**
> void UpdateTransitRestoreName (string name, string mountPath = null, TransitRestoreRequest transitRestoreRequest = null)

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
    public class UpdateTransitRestoreNameExample
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
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")
            var transitRestoreRequest = new TransitRestoreRequest(); // TransitRestoreRequest |  (optional) 

            try
            {
                // Restore the named key
                apiInstance.UpdateTransitRestoreName(name, mountPath, transitRestoreRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTransitRestoreName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]
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

<a name="updatetransitrewrapname"></a>
# **UpdateTransitRewrapName**
> void UpdateTransitRewrapName (string name, string mountPath = null, TransitRewrapRequest transitRewrapRequest = null)

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
    public class UpdateTransitRewrapNameExample
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
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")
            var transitRewrapRequest = new TransitRewrapRequest(); // TransitRewrapRequest |  (optional) 

            try
            {
                // Rewrap ciphertext
                apiInstance.UpdateTransitRewrapName(name, mountPath, transitRewrapRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTransitRewrapName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]
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

<a name="updatetransitsignname"></a>
# **UpdateTransitSignName**
> void UpdateTransitSignName (string name, string mountPath = null, TransitSignRequest transitSignRequest = null)

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
    public class UpdateTransitSignNameExample
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
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")
            var transitSignRequest = new TransitSignRequest(); // TransitSignRequest |  (optional) 

            try
            {
                // Generate a signature for input data using the named key
                apiInstance.UpdateTransitSignName(name, mountPath, transitSignRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTransitSignName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]
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

<a name="updatetransitsignnameurlalgorithm"></a>
# **UpdateTransitSignNameUrlalgorithm**
> void UpdateTransitSignNameUrlalgorithm (string name, string urlalgorithm, string mountPath = null, TransitSignRequest transitSignRequest = null)

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
    public class UpdateTransitSignNameUrlalgorithmExample
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
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")
            var transitSignRequest = new TransitSignRequest(); // TransitSignRequest |  (optional) 

            try
            {
                // Generate a signature for input data using the named key
                apiInstance.UpdateTransitSignNameUrlalgorithm(name, urlalgorithm, mountPath, transitSignRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTransitSignNameUrlalgorithm: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]
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

<a name="updatetransitverifyname"></a>
# **UpdateTransitVerifyName**
> void UpdateTransitVerifyName (string name, string mountPath = null, TransitVerifyRequest transitVerifyRequest = null)

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
    public class UpdateTransitVerifyNameExample
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
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")
            var transitVerifyRequest = new TransitVerifyRequest(); // TransitVerifyRequest |  (optional) 

            try
            {
                // Verify a signature or HMAC for input data created using the named key
                apiInstance.UpdateTransitVerifyName(name, mountPath, transitVerifyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTransitVerifyName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]
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

<a name="updatetransitverifynameurlalgorithm"></a>
# **UpdateTransitVerifyNameUrlalgorithm**
> void UpdateTransitVerifyNameUrlalgorithm (string name, string urlalgorithm, string mountPath = null, TransitVerifyRequest transitVerifyRequest = null)

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
    public class UpdateTransitVerifyNameUrlalgorithmExample
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
            var mountPath = "\"transit\"";  // string | Path where the backend was mounted; the endpoint path will be offset by the mount path (optional)  (default to "transit")
            var transitVerifyRequest = new TransitVerifyRequest(); // TransitVerifyRequest |  (optional) 

            try
            {
                // Verify a signature or HMAC for input data created using the named key
                apiInstance.UpdateTransitVerifyNameUrlalgorithm(name, urlalgorithm, mountPath, transitVerifyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Secrets.UpdateTransitVerifyNameUrlalgorithm: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **mountPath** | **string**| Path where the backend was mounted; the endpoint path will be offset by the mount path | [optional] [default to &quot;transit&quot;]
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

