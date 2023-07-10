// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0
//
// Code generated with OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

using System.ComponentModel.DataAnnotations;
using FileParameter = Vault.Client.FileParameter;


namespace Vault.Model
{
    /// <summary>
    /// LdapConfigureRequest
    /// </summary>
    [DataContract(Name = "LdapConfigureRequest")]
    public partial class LdapConfigureRequest : IEquatable<LdapConfigureRequest>, IValidatableObject
    {        /// <summary>
             /// When aliases should be dereferenced on search operations. Accepted values are &#x27;never&#x27;, &#x27;finding&#x27;, &#x27;searching&#x27;, &#x27;always&#x27;. Defaults to &#x27;never&#x27;.
             /// </summary>
             /// <value>When aliases should be dereferenced on search operations. Accepted values are &#x27;never&#x27;, &#x27;finding&#x27;, &#x27;searching&#x27;, &#x27;always&#x27;. Defaults to &#x27;never&#x27;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DereferenceAliasesEnum
        {

            /// <summary>
            /// Enum Never for value: never
            /// </summary>
            [EnumMember(Value = "never")]
            Never = 0,
            /// <summary>
            /// Enum Finding for value: finding
            /// </summary>
            [EnumMember(Value = "finding")]
            Finding = 1,
            /// <summary>
            /// Enum Searching for value: searching
            /// </summary>
            [EnumMember(Value = "searching")]
            Searching = 2,
            /// <summary>
            /// Enum Always for value: always
            /// </summary>
            [EnumMember(Value = "always")]
            Always = 3
        }
        /// <summary>
        /// When aliases should be dereferenced on search operations. Accepted values are &#x27;never&#x27;, &#x27;finding&#x27;, &#x27;searching&#x27;, &#x27;always&#x27;. Defaults to &#x27;never&#x27;.
        /// </summary>
        /// <value>When aliases should be dereferenced on search operations. Accepted values are &#x27;never&#x27;, &#x27;finding&#x27;, &#x27;searching&#x27;, &#x27;always&#x27;. Defaults to &#x27;never&#x27;.</value>

        [DataMember(Name = "dereference_aliases", EmitDefaultValue = false)]
        public DereferenceAliasesEnum? DereferenceAliases { get; set; }

        /// <summary>
        /// Maximum TLS version to use. Accepted values are &#x27;tls10&#x27;, &#x27;tls11&#x27;, &#x27;tls12&#x27; or &#x27;tls13&#x27;. Defaults to &#x27;tls12&#x27;
        /// </summary>
        /// <value>Maximum TLS version to use. Accepted values are &#x27;tls10&#x27;, &#x27;tls11&#x27;, &#x27;tls12&#x27; or &#x27;tls13&#x27;. Defaults to &#x27;tls12&#x27;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TlsMaxVersionEnum
        {

            /// <summary>
            /// Enum Tls10 for value: tls10
            /// </summary>
            [EnumMember(Value = "tls10")]
            Tls10 = 0,
            /// <summary>
            /// Enum Tls11 for value: tls11
            /// </summary>
            [EnumMember(Value = "tls11")]
            Tls11 = 1,
            /// <summary>
            /// Enum Tls12 for value: tls12
            /// </summary>
            [EnumMember(Value = "tls12")]
            Tls12 = 2,
            /// <summary>
            /// Enum Tls13 for value: tls13
            /// </summary>
            [EnumMember(Value = "tls13")]
            Tls13 = 3
        }
        /// <summary>
        /// Maximum TLS version to use. Accepted values are &#x27;tls10&#x27;, &#x27;tls11&#x27;, &#x27;tls12&#x27; or &#x27;tls13&#x27;. Defaults to &#x27;tls12&#x27;
        /// </summary>
        /// <value>Maximum TLS version to use. Accepted values are &#x27;tls10&#x27;, &#x27;tls11&#x27;, &#x27;tls12&#x27; or &#x27;tls13&#x27;. Defaults to &#x27;tls12&#x27;</value>

        [DataMember(Name = "tls_max_version", EmitDefaultValue = false)]
        public TlsMaxVersionEnum? TlsMaxVersion { get; set; }

        /// <summary>
        /// Minimum TLS version to use. Accepted values are &#x27;tls10&#x27;, &#x27;tls11&#x27;, &#x27;tls12&#x27; or &#x27;tls13&#x27;. Defaults to &#x27;tls12&#x27;
        /// </summary>
        /// <value>Minimum TLS version to use. Accepted values are &#x27;tls10&#x27;, &#x27;tls11&#x27;, &#x27;tls12&#x27; or &#x27;tls13&#x27;. Defaults to &#x27;tls12&#x27;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TlsMinVersionEnum
        {

            /// <summary>
            /// Enum Tls10 for value: tls10
            /// </summary>
            [EnumMember(Value = "tls10")]
            Tls10 = 0,
            /// <summary>
            /// Enum Tls11 for value: tls11
            /// </summary>
            [EnumMember(Value = "tls11")]
            Tls11 = 1,
            /// <summary>
            /// Enum Tls12 for value: tls12
            /// </summary>
            [EnumMember(Value = "tls12")]
            Tls12 = 2,
            /// <summary>
            /// Enum Tls13 for value: tls13
            /// </summary>
            [EnumMember(Value = "tls13")]
            Tls13 = 3
        }
        /// <summary>
        /// Minimum TLS version to use. Accepted values are &#x27;tls10&#x27;, &#x27;tls11&#x27;, &#x27;tls12&#x27; or &#x27;tls13&#x27;. Defaults to &#x27;tls12&#x27;
        /// </summary>
        /// <value>Minimum TLS version to use. Accepted values are &#x27;tls10&#x27;, &#x27;tls11&#x27;, &#x27;tls12&#x27; or &#x27;tls13&#x27;. Defaults to &#x27;tls12&#x27;</value>

        [DataMember(Name = "tls_min_version", EmitDefaultValue = false)]
        public TlsMinVersionEnum? TlsMinVersion { get; set; }




        /// <summary>
        /// Initializes a new instance of the <see cref="LdapConfigureRequest" /> class.
        /// </summary>

        /// <param name="AnonymousGroupSearch">Use anonymous binds when performing LDAP group searches (if true the initial credentials will still be used for the initial connection test). (default to false).</param>

        /// <param name="Binddn">LDAP DN for searching for the user DN (optional).</param>

        /// <param name="Bindpass">LDAP password for searching for the user DN (optional).</param>

        /// <param name="CaseSensitiveNames">If true, case sensitivity will be used when comparing usernames and groups for matching policies..</param>

        /// <param name="Certificate">CA certificate to use when verifying LDAP server certificate, must be x509 PEM encoded (optional).</param>

        /// <param name="ClientTlsCert">Client certificate to provide to the LDAP server, must be x509 PEM encoded (optional).</param>

        /// <param name="ClientTlsKey">Client certificate key to provide to the LDAP server, must be x509 PEM encoded (optional).</param>

        /// <param name="ConnectionTimeout">Timeout, in seconds, when attempting to connect to the LDAP server before trying the next URL in the configuration. (default to &quot;30s&quot;).</param>

        /// <param name="DenyNullBind">Denies an unauthenticated LDAP bind request if the user&#x27;s password is empty; defaults to true (default to true).</param>

        /// <param name="DereferenceAliases">When aliases should be dereferenced on search operations. Accepted values are &#x27;never&#x27;, &#x27;finding&#x27;, &#x27;searching&#x27;, &#x27;always&#x27;. Defaults to &#x27;never&#x27;. (default to DereferenceAliasesEnum.Never).</param>

        /// <param name="Discoverdn">Use anonymous bind to discover the bind DN of a user (optional).</param>

        /// <param name="Groupattr">LDAP attribute to follow on objects returned by &lt;groupfilter&gt; in order to enumerate user group membership. Examples: \&quot;cn\&quot; or \&quot;memberOf\&quot;, etc. Default: cn (default to &quot;cn&quot;).</param>

        /// <param name="Groupdn">LDAP search base to use for group membership search (eg: ou&#x3D;Groups,dc&#x3D;example,dc&#x3D;org).</param>

        /// <param name="Groupfilter">Go template for querying group membership of user (optional) The template can access the following context variables: UserDN, Username Example: (&amp;(objectClass&#x3D;group)(member:1.2.840.113556.1.4.1941:&#x3D;{{.UserDN}})) Default: (|(memberUid&#x3D;{{.Username}})(member&#x3D;{{.UserDN}})(uniqueMember&#x3D;{{.UserDN}})) (default to &quot;(|(memberUid&#x3D;{{.Username}})(member&#x3D;{{.UserDN}})(uniqueMember&#x3D;{{.UserDN}}))&quot;).</param>

        /// <param name="InsecureTls">Skip LDAP server SSL Certificate verification - VERY insecure (optional).</param>

        /// <param name="Length">The desired length of passwords that Vault generates..</param>

        /// <param name="MaxPageSize">If set to a value greater than 0, the LDAP backend will use the LDAP server&#x27;s paged search control to request pages of up to the given size. This can be used to avoid hitting the LDAP server&#x27;s maximum result size limit. Otherwise, the LDAP backend will not use the paged search control. (default to 0).</param>

        /// <param name="MaxTtl">The maximum password time-to-live..</param>

        /// <param name="PasswordPolicy">Password policy to use to generate passwords.</param>

        /// <param name="RequestTimeout">Timeout, in seconds, for the connection when making requests against the server before returning back an error. (default to &quot;90s&quot;).</param>

        /// <param name="Schema">The desired LDAP schema used when modifying user account passwords. (default to &quot;openldap&quot;).</param>

        /// <param name="Starttls">Issue a StartTLS command after establishing unencrypted connection (optional).</param>

        /// <param name="TlsMaxVersion">Maximum TLS version to use. Accepted values are &#x27;tls10&#x27;, &#x27;tls11&#x27;, &#x27;tls12&#x27; or &#x27;tls13&#x27;. Defaults to &#x27;tls12&#x27; (default to TlsMaxVersionEnum.Tls12).</param>

        /// <param name="TlsMinVersion">Minimum TLS version to use. Accepted values are &#x27;tls10&#x27;, &#x27;tls11&#x27;, &#x27;tls12&#x27; or &#x27;tls13&#x27;. Defaults to &#x27;tls12&#x27; (default to TlsMinVersionEnum.Tls12).</param>

        /// <param name="Ttl">The default password time-to-live..</param>

        /// <param name="Upndomain">Enables userPrincipalDomain login with [username]@UPNDomain (optional).</param>

        /// <param name="Url">LDAP URL to connect to (default: ldap://127.0.0.1). Multiple URLs can be specified by concatenating them with commas; they will be tried in-order. (default to &quot;ldap://127.0.0.1&quot;).</param>

        /// <param name="UsePre111GroupCnBehavior">In Vault 1.1.1 a fix for handling group CN values of different cases unfortunately introduced a regression that could cause previously defined groups to not be found due to a change in the resulting name. If set true, the pre-1.1.1 behavior for matching group CNs will be used. This is only needed in some upgrade scenarios for backwards compatibility. It is enabled by default if the config is upgraded but disabled by default on new configurations..</param>

        /// <param name="UseTokenGroups">If true, use the Active Directory tokenGroups constructed attribute of the user to find the group memberships. This will find all security groups including nested ones. (default to false).</param>

        /// <param name="Userattr">Attribute used for users (default: cn) (default to &quot;cn&quot;).</param>

        /// <param name="Userdn">LDAP domain to use for users (eg: ou&#x3D;People,dc&#x3D;example,dc&#x3D;org).</param>

        /// <param name="Userfilter">Go template for LDAP user search filer (optional) The template can access the following context variables: UserAttr, Username Default: ({{.UserAttr}}&#x3D;{{.Username}}) (default to &quot;({{.UserAttr}}&#x3D;{{.Username}})&quot;).</param>

        /// <param name="UsernameAsAlias">If true, sets the alias name to the username (default to false).</param>


        public LdapConfigureRequest(bool AnonymousGroupSearch = false, string Binddn = default(string), string Bindpass = default(string), bool CaseSensitiveNames = default(bool), string Certificate = default(string), string ClientTlsCert = default(string), string ClientTlsKey = default(string), string ConnectionTimeout = "30s", bool DenyNullBind = true, DereferenceAliasesEnum? DereferenceAliases = DereferenceAliasesEnum.Never, bool Discoverdn = default(bool), string Groupattr = "cn", string Groupdn = default(string), string Groupfilter = "(|(memberUid={{.Username}})(member={{.UserDN}})(uniqueMember={{.UserDN}}))", bool InsecureTls = default(bool), int Length = default(int), int MaxPageSize = 0, string MaxTtl = default(string), string PasswordPolicy = default(string), string RequestTimeout = "90s", string Schema = "openldap", bool Starttls = default(bool), TlsMaxVersionEnum? TlsMaxVersion = TlsMaxVersionEnum.Tls12, TlsMinVersionEnum? TlsMinVersion = TlsMinVersionEnum.Tls12, string Ttl = default(string), string Upndomain = default(string), string Url = "ldap://127.0.0.1", bool UsePre111GroupCnBehavior = default(bool), bool UseTokenGroups = false, string Userattr = "cn", string Userdn = default(string), string Userfilter = "({{.UserAttr}}={{.Username}})", bool UsernameAsAlias = false)
        {

            this.AnonymousGroupSearch = AnonymousGroupSearch;

            this.Binddn = Binddn;

            this.Bindpass = Bindpass;

            this.CaseSensitiveNames = CaseSensitiveNames;

            this.Certificate = Certificate;

            this.ClientTlsCert = ClientTlsCert;

            this.ClientTlsKey = ClientTlsKey;

            // use default value if no "ConnectionTimeout" provided
            this.ConnectionTimeout = ConnectionTimeout ?? "30s";


            this.DenyNullBind = DenyNullBind;

            this.DereferenceAliases = DereferenceAliases;

            this.Discoverdn = Discoverdn;

            // use default value if no "Groupattr" provided
            this.Groupattr = Groupattr ?? "cn";


            this.Groupdn = Groupdn;

            // use default value if no "Groupfilter" provided
            this.Groupfilter = Groupfilter ?? "(|(memberUid={{.Username}})(member={{.UserDN}})(uniqueMember={{.UserDN}}))";


            this.InsecureTls = InsecureTls;

            this.Length = Length;

            this.MaxPageSize = MaxPageSize;

            this.MaxTtl = MaxTtl;

            this.PasswordPolicy = PasswordPolicy;

            // use default value if no "RequestTimeout" provided
            this.RequestTimeout = RequestTimeout ?? "90s";


            // use default value if no "Schema" provided
            this.Schema = Schema ?? "openldap";


            this.Starttls = Starttls;

            this.TlsMaxVersion = TlsMaxVersion;

            this.TlsMinVersion = TlsMinVersion;

            this.Ttl = Ttl;

            this.Upndomain = Upndomain;

            // use default value if no "Url" provided
            this.Url = Url ?? "ldap://127.0.0.1";


            this.UsePre111GroupCnBehavior = UsePre111GroupCnBehavior;

            this.UseTokenGroups = UseTokenGroups;

            // use default value if no "Userattr" provided
            this.Userattr = Userattr ?? "cn";


            this.Userdn = Userdn;

            // use default value if no "Userfilter" provided
            this.Userfilter = Userfilter ?? "({{.UserAttr}}={{.Username}})";


            this.UsernameAsAlias = UsernameAsAlias;

        }

        /// <summary>
        /// Use anonymous binds when performing LDAP group searches (if true the initial credentials will still be used for the initial connection test).
        /// </summary>
        /// <value>Use anonymous binds when performing LDAP group searches (if true the initial credentials will still be used for the initial connection test).</value>
        [DataMember(Name = "anonymous_group_search", EmitDefaultValue = true)]

        public bool AnonymousGroupSearch { get; set; }


        /// <summary>
        /// LDAP DN for searching for the user DN (optional)
        /// </summary>
        /// <value>LDAP DN for searching for the user DN (optional)</value>
        [DataMember(Name = "binddn", EmitDefaultValue = false)]

        public string Binddn { get; set; }


        /// <summary>
        /// LDAP password for searching for the user DN (optional)
        /// </summary>
        /// <value>LDAP password for searching for the user DN (optional)</value>
        [DataMember(Name = "bindpass", EmitDefaultValue = false)]

        public string Bindpass { get; set; }


        /// <summary>
        /// If true, case sensitivity will be used when comparing usernames and groups for matching policies.
        /// </summary>
        /// <value>If true, case sensitivity will be used when comparing usernames and groups for matching policies.</value>
        [DataMember(Name = "case_sensitive_names", EmitDefaultValue = true)]

        public bool CaseSensitiveNames { get; set; }


        /// <summary>
        /// CA certificate to use when verifying LDAP server certificate, must be x509 PEM encoded (optional)
        /// </summary>
        /// <value>CA certificate to use when verifying LDAP server certificate, must be x509 PEM encoded (optional)</value>
        [DataMember(Name = "certificate", EmitDefaultValue = false)]

        public string Certificate { get; set; }


        /// <summary>
        /// Client certificate to provide to the LDAP server, must be x509 PEM encoded (optional)
        /// </summary>
        /// <value>Client certificate to provide to the LDAP server, must be x509 PEM encoded (optional)</value>
        [DataMember(Name = "client_tls_cert", EmitDefaultValue = false)]

        public string ClientTlsCert { get; set; }


        /// <summary>
        /// Client certificate key to provide to the LDAP server, must be x509 PEM encoded (optional)
        /// </summary>
        /// <value>Client certificate key to provide to the LDAP server, must be x509 PEM encoded (optional)</value>
        [DataMember(Name = "client_tls_key", EmitDefaultValue = false)]

        public string ClientTlsKey { get; set; }


        /// <summary>
        /// Timeout, in seconds, when attempting to connect to the LDAP server before trying the next URL in the configuration.
        /// </summary>
        /// <value>Timeout, in seconds, when attempting to connect to the LDAP server before trying the next URL in the configuration.</value>
        [DataMember(Name = "connection_timeout", EmitDefaultValue = false)]

        public string ConnectionTimeout { get; set; }


        /// <summary>
        /// Denies an unauthenticated LDAP bind request if the user&#x27;s password is empty; defaults to true
        /// </summary>
        /// <value>Denies an unauthenticated LDAP bind request if the user&#x27;s password is empty; defaults to true</value>
        [DataMember(Name = "deny_null_bind", EmitDefaultValue = true)]

        public bool DenyNullBind { get; set; }


        /// <summary>
        /// Use anonymous bind to discover the bind DN of a user (optional)
        /// </summary>
        /// <value>Use anonymous bind to discover the bind DN of a user (optional)</value>
        [DataMember(Name = "discoverdn", EmitDefaultValue = true)]

        public bool Discoverdn { get; set; }


        /// <summary>
        /// LDAP attribute to follow on objects returned by &lt;groupfilter&gt; in order to enumerate user group membership. Examples: \&quot;cn\&quot; or \&quot;memberOf\&quot;, etc. Default: cn
        /// </summary>
        /// <value>LDAP attribute to follow on objects returned by &lt;groupfilter&gt; in order to enumerate user group membership. Examples: \&quot;cn\&quot; or \&quot;memberOf\&quot;, etc. Default: cn</value>
        [DataMember(Name = "groupattr", EmitDefaultValue = false)]

        public string Groupattr { get; set; }


        /// <summary>
        /// LDAP search base to use for group membership search (eg: ou&#x3D;Groups,dc&#x3D;example,dc&#x3D;org)
        /// </summary>
        /// <value>LDAP search base to use for group membership search (eg: ou&#x3D;Groups,dc&#x3D;example,dc&#x3D;org)</value>
        [DataMember(Name = "groupdn", EmitDefaultValue = false)]

        public string Groupdn { get; set; }


        /// <summary>
        /// Go template for querying group membership of user (optional) The template can access the following context variables: UserDN, Username Example: (&amp;(objectClass&#x3D;group)(member:1.2.840.113556.1.4.1941:&#x3D;{{.UserDN}})) Default: (|(memberUid&#x3D;{{.Username}})(member&#x3D;{{.UserDN}})(uniqueMember&#x3D;{{.UserDN}}))
        /// </summary>
        /// <value>Go template for querying group membership of user (optional) The template can access the following context variables: UserDN, Username Example: (&amp;(objectClass&#x3D;group)(member:1.2.840.113556.1.4.1941:&#x3D;{{.UserDN}})) Default: (|(memberUid&#x3D;{{.Username}})(member&#x3D;{{.UserDN}})(uniqueMember&#x3D;{{.UserDN}}))</value>
        [DataMember(Name = "groupfilter", EmitDefaultValue = false)]

        public string Groupfilter { get; set; }


        /// <summary>
        /// Skip LDAP server SSL Certificate verification - VERY insecure (optional)
        /// </summary>
        /// <value>Skip LDAP server SSL Certificate verification - VERY insecure (optional)</value>
        [DataMember(Name = "insecure_tls", EmitDefaultValue = true)]

        public bool InsecureTls { get; set; }


        /// <summary>
        /// The desired length of passwords that Vault generates.
        /// </summary>
        /// <value>The desired length of passwords that Vault generates.</value>
        [DataMember(Name = "length", EmitDefaultValue = false)]

        [Obsolete] public int Length { get; set; }


        /// <summary>
        /// If set to a value greater than 0, the LDAP backend will use the LDAP server&#x27;s paged search control to request pages of up to the given size. This can be used to avoid hitting the LDAP server&#x27;s maximum result size limit. Otherwise, the LDAP backend will not use the paged search control.
        /// </summary>
        /// <value>If set to a value greater than 0, the LDAP backend will use the LDAP server&#x27;s paged search control to request pages of up to the given size. This can be used to avoid hitting the LDAP server&#x27;s maximum result size limit. Otherwise, the LDAP backend will not use the paged search control.</value>
        [DataMember(Name = "max_page_size", EmitDefaultValue = false)]

        public int MaxPageSize { get; set; }


        /// <summary>
        /// The maximum password time-to-live.
        /// </summary>
        /// <value>The maximum password time-to-live.</value>
        [DataMember(Name = "max_ttl", EmitDefaultValue = false)]

        public string MaxTtl { get; set; }


        /// <summary>
        /// Password policy to use to generate passwords
        /// </summary>
        /// <value>Password policy to use to generate passwords</value>
        [DataMember(Name = "password_policy", EmitDefaultValue = false)]

        public string PasswordPolicy { get; set; }


        /// <summary>
        /// Timeout, in seconds, for the connection when making requests against the server before returning back an error.
        /// </summary>
        /// <value>Timeout, in seconds, for the connection when making requests against the server before returning back an error.</value>
        [DataMember(Name = "request_timeout", EmitDefaultValue = false)]

        public string RequestTimeout { get; set; }


        /// <summary>
        /// The desired LDAP schema used when modifying user account passwords.
        /// </summary>
        /// <value>The desired LDAP schema used when modifying user account passwords.</value>
        [DataMember(Name = "schema", EmitDefaultValue = false)]

        public string Schema { get; set; }


        /// <summary>
        /// Issue a StartTLS command after establishing unencrypted connection (optional)
        /// </summary>
        /// <value>Issue a StartTLS command after establishing unencrypted connection (optional)</value>
        [DataMember(Name = "starttls", EmitDefaultValue = true)]

        public bool Starttls { get; set; }


        /// <summary>
        /// The default password time-to-live.
        /// </summary>
        /// <value>The default password time-to-live.</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]

        public string Ttl { get; set; }


        /// <summary>
        /// Enables userPrincipalDomain login with [username]@UPNDomain (optional)
        /// </summary>
        /// <value>Enables userPrincipalDomain login with [username]@UPNDomain (optional)</value>
        [DataMember(Name = "upndomain", EmitDefaultValue = false)]

        public string Upndomain { get; set; }


        /// <summary>
        /// LDAP URL to connect to (default: ldap://127.0.0.1). Multiple URLs can be specified by concatenating them with commas; they will be tried in-order.
        /// </summary>
        /// <value>LDAP URL to connect to (default: ldap://127.0.0.1). Multiple URLs can be specified by concatenating them with commas; they will be tried in-order.</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]

        public string Url { get; set; }


        /// <summary>
        /// In Vault 1.1.1 a fix for handling group CN values of different cases unfortunately introduced a regression that could cause previously defined groups to not be found due to a change in the resulting name. If set true, the pre-1.1.1 behavior for matching group CNs will be used. This is only needed in some upgrade scenarios for backwards compatibility. It is enabled by default if the config is upgraded but disabled by default on new configurations.
        /// </summary>
        /// <value>In Vault 1.1.1 a fix for handling group CN values of different cases unfortunately introduced a regression that could cause previously defined groups to not be found due to a change in the resulting name. If set true, the pre-1.1.1 behavior for matching group CNs will be used. This is only needed in some upgrade scenarios for backwards compatibility. It is enabled by default if the config is upgraded but disabled by default on new configurations.</value>
        [DataMember(Name = "use_pre111_group_cn_behavior", EmitDefaultValue = true)]

        public bool UsePre111GroupCnBehavior { get; set; }


        /// <summary>
        /// If true, use the Active Directory tokenGroups constructed attribute of the user to find the group memberships. This will find all security groups including nested ones.
        /// </summary>
        /// <value>If true, use the Active Directory tokenGroups constructed attribute of the user to find the group memberships. This will find all security groups including nested ones.</value>
        [DataMember(Name = "use_token_groups", EmitDefaultValue = true)]

        public bool UseTokenGroups { get; set; }


        /// <summary>
        /// Attribute used for users (default: cn)
        /// </summary>
        /// <value>Attribute used for users (default: cn)</value>
        [DataMember(Name = "userattr", EmitDefaultValue = false)]

        public string Userattr { get; set; }


        /// <summary>
        /// LDAP domain to use for users (eg: ou&#x3D;People,dc&#x3D;example,dc&#x3D;org)
        /// </summary>
        /// <value>LDAP domain to use for users (eg: ou&#x3D;People,dc&#x3D;example,dc&#x3D;org)</value>
        [DataMember(Name = "userdn", EmitDefaultValue = false)]

        public string Userdn { get; set; }


        /// <summary>
        /// Go template for LDAP user search filer (optional) The template can access the following context variables: UserAttr, Username Default: ({{.UserAttr}}&#x3D;{{.Username}})
        /// </summary>
        /// <value>Go template for LDAP user search filer (optional) The template can access the following context variables: UserAttr, Username Default: ({{.UserAttr}}&#x3D;{{.Username}})</value>
        [DataMember(Name = "userfilter", EmitDefaultValue = false)]

        public string Userfilter { get; set; }


        /// <summary>
        /// If true, sets the alias name to the username
        /// </summary>
        /// <value>If true, sets the alias name to the username</value>
        [DataMember(Name = "username_as_alias", EmitDefaultValue = true)]

        public bool UsernameAsAlias { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LdapConfigureRequest {\n");
            sb.Append("  AnonymousGroupSearch: ").Append(AnonymousGroupSearch).Append("\n");
            sb.Append("  Binddn: ").Append(Binddn).Append("\n");
            sb.Append("  Bindpass: ").Append(Bindpass).Append("\n");
            sb.Append("  CaseSensitiveNames: ").Append(CaseSensitiveNames).Append("\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  ClientTlsCert: ").Append(ClientTlsCert).Append("\n");
            sb.Append("  ClientTlsKey: ").Append(ClientTlsKey).Append("\n");
            sb.Append("  ConnectionTimeout: ").Append(ConnectionTimeout).Append("\n");
            sb.Append("  DenyNullBind: ").Append(DenyNullBind).Append("\n");
            sb.Append("  DereferenceAliases: ").Append(DereferenceAliases).Append("\n");
            sb.Append("  Discoverdn: ").Append(Discoverdn).Append("\n");
            sb.Append("  Groupattr: ").Append(Groupattr).Append("\n");
            sb.Append("  Groupdn: ").Append(Groupdn).Append("\n");
            sb.Append("  Groupfilter: ").Append(Groupfilter).Append("\n");
            sb.Append("  InsecureTls: ").Append(InsecureTls).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  MaxPageSize: ").Append(MaxPageSize).Append("\n");
            sb.Append("  MaxTtl: ").Append(MaxTtl).Append("\n");
            sb.Append("  PasswordPolicy: ").Append(PasswordPolicy).Append("\n");
            sb.Append("  RequestTimeout: ").Append(RequestTimeout).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Starttls: ").Append(Starttls).Append("\n");
            sb.Append("  TlsMaxVersion: ").Append(TlsMaxVersion).Append("\n");
            sb.Append("  TlsMinVersion: ").Append(TlsMinVersion).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
            sb.Append("  Upndomain: ").Append(Upndomain).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  UsePre111GroupCnBehavior: ").Append(UsePre111GroupCnBehavior).Append("\n");
            sb.Append("  UseTokenGroups: ").Append(UseTokenGroups).Append("\n");
            sb.Append("  Userattr: ").Append(Userattr).Append("\n");
            sb.Append("  Userdn: ").Append(Userdn).Append("\n");
            sb.Append("  Userfilter: ").Append(Userfilter).Append("\n");
            sb.Append("  UsernameAsAlias: ").Append(UsernameAsAlias).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LdapConfigureRequest);
        }

        /// <summary>
        /// Returns true if LdapConfigureRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LdapConfigureRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LdapConfigureRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AnonymousGroupSearch == input.AnonymousGroupSearch ||

                    this.AnonymousGroupSearch.Equals(input.AnonymousGroupSearch)
                ) &&
                (
                    this.Binddn == input.Binddn ||
                    (this.Binddn != null &&
                    this.Binddn.Equals(input.Binddn))

                ) &&
                (
                    this.Bindpass == input.Bindpass ||
                    (this.Bindpass != null &&
                    this.Bindpass.Equals(input.Bindpass))

                ) &&
                (
                    this.CaseSensitiveNames == input.CaseSensitiveNames ||

                    this.CaseSensitiveNames.Equals(input.CaseSensitiveNames)
                ) &&
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))

                ) &&
                (
                    this.ClientTlsCert == input.ClientTlsCert ||
                    (this.ClientTlsCert != null &&
                    this.ClientTlsCert.Equals(input.ClientTlsCert))

                ) &&
                (
                    this.ClientTlsKey == input.ClientTlsKey ||
                    (this.ClientTlsKey != null &&
                    this.ClientTlsKey.Equals(input.ClientTlsKey))

                ) &&
                (
                    this.ConnectionTimeout == input.ConnectionTimeout ||
                    (this.ConnectionTimeout != null &&
                    this.ConnectionTimeout.Equals(input.ConnectionTimeout))

                ) &&
                (
                    this.DenyNullBind == input.DenyNullBind ||

                    this.DenyNullBind.Equals(input.DenyNullBind)
                ) &&
                (
                    this.DereferenceAliases == input.DereferenceAliases ||

                    this.DereferenceAliases.Equals(input.DereferenceAliases)
                ) &&
                (
                    this.Discoverdn == input.Discoverdn ||

                    this.Discoverdn.Equals(input.Discoverdn)
                ) &&
                (
                    this.Groupattr == input.Groupattr ||
                    (this.Groupattr != null &&
                    this.Groupattr.Equals(input.Groupattr))

                ) &&
                (
                    this.Groupdn == input.Groupdn ||
                    (this.Groupdn != null &&
                    this.Groupdn.Equals(input.Groupdn))

                ) &&
                (
                    this.Groupfilter == input.Groupfilter ||
                    (this.Groupfilter != null &&
                    this.Groupfilter.Equals(input.Groupfilter))

                ) &&
                (
                    this.InsecureTls == input.InsecureTls ||

                    this.InsecureTls.Equals(input.InsecureTls)
                ) &&
                (
                    this.Length == input.Length ||

                    this.Length.Equals(input.Length)
                ) &&
                (
                    this.MaxPageSize == input.MaxPageSize ||

                    this.MaxPageSize.Equals(input.MaxPageSize)
                ) &&
                (
                    this.MaxTtl == input.MaxTtl ||
                    (this.MaxTtl != null &&
                    this.MaxTtl.Equals(input.MaxTtl))

                ) &&
                (
                    this.PasswordPolicy == input.PasswordPolicy ||
                    (this.PasswordPolicy != null &&
                    this.PasswordPolicy.Equals(input.PasswordPolicy))

                ) &&
                (
                    this.RequestTimeout == input.RequestTimeout ||
                    (this.RequestTimeout != null &&
                    this.RequestTimeout.Equals(input.RequestTimeout))

                ) &&
                (
                    this.Schema == input.Schema ||
                    (this.Schema != null &&
                    this.Schema.Equals(input.Schema))

                ) &&
                (
                    this.Starttls == input.Starttls ||

                    this.Starttls.Equals(input.Starttls)
                ) &&
                (
                    this.TlsMaxVersion == input.TlsMaxVersion ||

                    this.TlsMaxVersion.Equals(input.TlsMaxVersion)
                ) &&
                (
                    this.TlsMinVersion == input.TlsMinVersion ||

                    this.TlsMinVersion.Equals(input.TlsMinVersion)
                ) &&
                (
                    this.Ttl == input.Ttl ||
                    (this.Ttl != null &&
                    this.Ttl.Equals(input.Ttl))

                ) &&
                (
                    this.Upndomain == input.Upndomain ||
                    (this.Upndomain != null &&
                    this.Upndomain.Equals(input.Upndomain))

                ) &&
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))

                ) &&
                (
                    this.UsePre111GroupCnBehavior == input.UsePre111GroupCnBehavior ||

                    this.UsePre111GroupCnBehavior.Equals(input.UsePre111GroupCnBehavior)
                ) &&
                (
                    this.UseTokenGroups == input.UseTokenGroups ||

                    this.UseTokenGroups.Equals(input.UseTokenGroups)
                ) &&
                (
                    this.Userattr == input.Userattr ||
                    (this.Userattr != null &&
                    this.Userattr.Equals(input.Userattr))

                ) &&
                (
                    this.Userdn == input.Userdn ||
                    (this.Userdn != null &&
                    this.Userdn.Equals(input.Userdn))

                ) &&
                (
                    this.Userfilter == input.Userfilter ||
                    (this.Userfilter != null &&
                    this.Userfilter.Equals(input.Userfilter))

                ) &&
                (
                    this.UsernameAsAlias == input.UsernameAsAlias ||

                    this.UsernameAsAlias.Equals(input.UsernameAsAlias)
                );

        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;


                hashCode = (hashCode * 59) + this.AnonymousGroupSearch.GetHashCode();
                if (this.Binddn != null)
                {
                    hashCode = (hashCode * 59) + this.Binddn.GetHashCode();
                }

                if (this.Bindpass != null)
                {
                    hashCode = (hashCode * 59) + this.Bindpass.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.CaseSensitiveNames.GetHashCode();
                if (this.Certificate != null)
                {
                    hashCode = (hashCode * 59) + this.Certificate.GetHashCode();
                }

                if (this.ClientTlsCert != null)
                {
                    hashCode = (hashCode * 59) + this.ClientTlsCert.GetHashCode();
                }

                if (this.ClientTlsKey != null)
                {
                    hashCode = (hashCode * 59) + this.ClientTlsKey.GetHashCode();
                }

                if (this.ConnectionTimeout != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectionTimeout.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.DenyNullBind.GetHashCode();

                hashCode = (hashCode * 59) + this.DereferenceAliases.GetHashCode();

                hashCode = (hashCode * 59) + this.Discoverdn.GetHashCode();
                if (this.Groupattr != null)
                {
                    hashCode = (hashCode * 59) + this.Groupattr.GetHashCode();
                }

                if (this.Groupdn != null)
                {
                    hashCode = (hashCode * 59) + this.Groupdn.GetHashCode();
                }

                if (this.Groupfilter != null)
                {
                    hashCode = (hashCode * 59) + this.Groupfilter.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.InsecureTls.GetHashCode();

                hashCode = (hashCode * 59) + this.Length.GetHashCode();

                hashCode = (hashCode * 59) + this.MaxPageSize.GetHashCode();
                if (this.MaxTtl != null)
                {
                    hashCode = (hashCode * 59) + this.MaxTtl.GetHashCode();
                }

                if (this.PasswordPolicy != null)
                {
                    hashCode = (hashCode * 59) + this.PasswordPolicy.GetHashCode();
                }

                if (this.RequestTimeout != null)
                {
                    hashCode = (hashCode * 59) + this.RequestTimeout.GetHashCode();
                }

                if (this.Schema != null)
                {
                    hashCode = (hashCode * 59) + this.Schema.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Starttls.GetHashCode();

                hashCode = (hashCode * 59) + this.TlsMaxVersion.GetHashCode();

                hashCode = (hashCode * 59) + this.TlsMinVersion.GetHashCode();
                if (this.Ttl != null)
                {
                    hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
                }

                if (this.Upndomain != null)
                {
                    hashCode = (hashCode * 59) + this.Upndomain.GetHashCode();
                }

                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.UsePre111GroupCnBehavior.GetHashCode();

                hashCode = (hashCode * 59) + this.UseTokenGroups.GetHashCode();
                if (this.Userattr != null)
                {
                    hashCode = (hashCode * 59) + this.Userattr.GetHashCode();
                }

                if (this.Userdn != null)
                {
                    hashCode = (hashCode * 59) + this.Userdn.GetHashCode();
                }

                if (this.Userfilter != null)
                {
                    hashCode = (hashCode * 59) + this.Userfilter.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.UsernameAsAlias.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
