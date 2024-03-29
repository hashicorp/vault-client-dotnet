# Vault.Model.LdapConfigureRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnonymousGroupSearch** | **bool** | Use anonymous binds when performing LDAP group searches (if true the initial credentials will still be used for the initial connection test). | [optional] [default to false]
**Binddn** | **string** | LDAP DN for searching for the user DN (optional) | [optional] 
**Bindpass** | **string** | LDAP password for searching for the user DN (optional) | [optional] 
**CaseSensitiveNames** | **bool** | If true, case sensitivity will be used when comparing usernames and groups for matching policies. | [optional] 
**Certificate** | **string** | CA certificate to use when verifying LDAP server certificate, must be x509 PEM encoded (optional) | [optional] 
**ClientTlsCert** | **string** | Client certificate to provide to the LDAP server, must be x509 PEM encoded (optional) | [optional] 
**ClientTlsKey** | **string** | Client certificate key to provide to the LDAP server, must be x509 PEM encoded (optional) | [optional] 
**ConnectionTimeout** | **string** | Timeout, in seconds, when attempting to connect to the LDAP server before trying the next URL in the configuration. | [optional] [default to "30s"]
**DenyNullBind** | **bool** | Denies an unauthenticated LDAP bind request if the user&#x27;s password is empty; defaults to true | [optional] [default to true]
**DereferenceAliases** | **string** | When aliases should be dereferenced on search operations. Accepted values are &#x27;never&#x27;, &#x27;finding&#x27;, &#x27;searching&#x27;, &#x27;always&#x27;. Defaults to &#x27;never&#x27;. | [optional] [default to DereferenceAliasesEnum.Never]
**Discoverdn** | **bool** | Use anonymous bind to discover the bind DN of a user (optional) | [optional] 
**Groupattr** | **string** | LDAP attribute to follow on objects returned by &lt;groupfilter&gt; in order to enumerate user group membership. Examples: \&quot;cn\&quot; or \&quot;memberOf\&quot;, etc. Default: cn | [optional] [default to "cn"]
**Groupdn** | **string** | LDAP search base to use for group membership search (eg: ou&#x3D;Groups,dc&#x3D;example,dc&#x3D;org) | [optional] 
**Groupfilter** | **string** | Go template for querying group membership of user (optional) The template can access the following context variables: UserDN, Username Example: (&amp;(objectClass&#x3D;group)(member:1.2.840.113556.1.4.1941:&#x3D;{{.UserDN}})) Default: (|(memberUid&#x3D;{{.Username}})(member&#x3D;{{.UserDN}})(uniqueMember&#x3D;{{.UserDN}})) | [optional] [default to "(|(memberUid={{.Username}})(member={{.UserDN}})(uniqueMember={{.UserDN}}))"]
**InsecureTls** | **bool** | Skip LDAP server SSL Certificate verification - VERY insecure (optional) | [optional] 
**Length** | **int** | The desired length of passwords that Vault generates. | [optional] 
**MaxPageSize** | **int** | If set to a value greater than 0, the LDAP backend will use the LDAP server&#x27;s paged search control to request pages of up to the given size. This can be used to avoid hitting the LDAP server&#x27;s maximum result size limit. Otherwise, the LDAP backend will not use the paged search control. | [optional] [default to 0]
**MaxTtl** | **string** | The maximum password time-to-live. | [optional] 
**PasswordPolicy** | **string** | Password policy to use to generate passwords | [optional] 
**RequestTimeout** | **string** | Timeout, in seconds, for the connection when making requests against the server before returning back an error. | [optional] [default to "90s"]
**Schema** | **string** | The desired LDAP schema used when modifying user account passwords. | [optional] [default to "openldap"]
**Starttls** | **bool** | Issue a StartTLS command after establishing unencrypted connection (optional) | [optional] 
**TlsMaxVersion** | **string** | Maximum TLS version to use. Accepted values are &#x27;tls10&#x27;, &#x27;tls11&#x27;, &#x27;tls12&#x27; or &#x27;tls13&#x27;. Defaults to &#x27;tls12&#x27; | [optional] [default to TlsMaxVersionEnum.Tls12]
**TlsMinVersion** | **string** | Minimum TLS version to use. Accepted values are &#x27;tls10&#x27;, &#x27;tls11&#x27;, &#x27;tls12&#x27; or &#x27;tls13&#x27;. Defaults to &#x27;tls12&#x27; | [optional] [default to TlsMinVersionEnum.Tls12]
**Ttl** | **string** | The default password time-to-live. | [optional] 
**Upndomain** | **string** | Enables userPrincipalDomain login with [username]@UPNDomain (optional) | [optional] 
**Url** | **string** | LDAP URL to connect to (default: ldap://127.0.0.1). Multiple URLs can be specified by concatenating them with commas; they will be tried in-order. | [optional] [default to "ldap://127.0.0.1"]
**UsePre111GroupCnBehavior** | **bool** | In Vault 1.1.1 a fix for handling group CN values of different cases unfortunately introduced a regression that could cause previously defined groups to not be found due to a change in the resulting name. If set true, the pre-1.1.1 behavior for matching group CNs will be used. This is only needed in some upgrade scenarios for backwards compatibility. It is enabled by default if the config is upgraded but disabled by default on new configurations. | [optional] 
**UseTokenGroups** | **bool** | If true, use the Active Directory tokenGroups constructed attribute of the user to find the group memberships. This will find all security groups including nested ones. | [optional] [default to false]
**Userattr** | **string** | Attribute used for users (default: cn) | [optional] [default to "cn"]
**Userdn** | **string** | LDAP domain to use for users (eg: ou&#x3D;People,dc&#x3D;example,dc&#x3D;org) | [optional] 
**Userfilter** | **string** | Go template for LDAP user search filer (optional) The template can access the following context variables: UserAttr, Username Default: ({{.UserAttr}}&#x3D;{{.Username}}) | [optional] [default to "({{.UserAttr}}={{.Username}})"]
**UsernameAsAlias** | **bool** | If true, sets the alias name to the username | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

