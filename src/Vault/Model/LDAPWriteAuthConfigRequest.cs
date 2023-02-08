// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

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
    /// LDAPWriteAuthConfigRequest
    /// </summary>
    [DataContract(Name = "LDAPWriteAuthConfigRequest")]
    public partial class LDAPWriteAuthConfigRequest : IEquatable<LDAPWriteAuthConfigRequest>, IValidatableObject
    {
        /// <summary>
        /// Maximum TLS version to use. Accepted values are &#39;tls10&#39;, &#39;tls11&#39;, &#39;tls12&#39; or &#39;tls13&#39;. Defaults to &#39;tls12&#39;
        /// </summary>
        /// <value>Maximum TLS version to use. Accepted values are &#39;tls10&#39;, &#39;tls11&#39;, &#39;tls12&#39; or &#39;tls13&#39;. Defaults to &#39;tls12&#39;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TlsMaxVersionEnum
        {
            /// <summary>
            /// Enum Tls10 for value: tls10
            /// </summary>
            [EnumMember(Value = "tls10")]
            Tls10 = 1,

            /// <summary>
            /// Enum Tls11 for value: tls11
            /// </summary>
            [EnumMember(Value = "tls11")]
            Tls11 = 2,

            /// <summary>
            /// Enum Tls12 for value: tls12
            /// </summary>
            [EnumMember(Value = "tls12")]
            Tls12 = 3,

            /// <summary>
            /// Enum Tls13 for value: tls13
            /// </summary>
            [EnumMember(Value = "tls13")]
            Tls13 = 4

        }


        /// <summary>
        /// Maximum TLS version to use. Accepted values are &#39;tls10&#39;, &#39;tls11&#39;, &#39;tls12&#39; or &#39;tls13&#39;. Defaults to &#39;tls12&#39;
        /// </summary>
        /// <value>Maximum TLS version to use. Accepted values are &#39;tls10&#39;, &#39;tls11&#39;, &#39;tls12&#39; or &#39;tls13&#39;. Defaults to &#39;tls12&#39;</value>
        [DataMember(Name = "tls_max_version", EmitDefaultValue = false)]
        public TlsMaxVersionEnum? TlsMaxVersion { get; set; }
        /// <summary>
        /// Minimum TLS version to use. Accepted values are &#39;tls10&#39;, &#39;tls11&#39;, &#39;tls12&#39; or &#39;tls13&#39;. Defaults to &#39;tls12&#39;
        /// </summary>
        /// <value>Minimum TLS version to use. Accepted values are &#39;tls10&#39;, &#39;tls11&#39;, &#39;tls12&#39; or &#39;tls13&#39;. Defaults to &#39;tls12&#39;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TlsMinVersionEnum
        {
            /// <summary>
            /// Enum Tls10 for value: tls10
            /// </summary>
            [EnumMember(Value = "tls10")]
            Tls10 = 1,

            /// <summary>
            /// Enum Tls11 for value: tls11
            /// </summary>
            [EnumMember(Value = "tls11")]
            Tls11 = 2,

            /// <summary>
            /// Enum Tls12 for value: tls12
            /// </summary>
            [EnumMember(Value = "tls12")]
            Tls12 = 3,

            /// <summary>
            /// Enum Tls13 for value: tls13
            /// </summary>
            [EnumMember(Value = "tls13")]
            Tls13 = 4

        }


        /// <summary>
        /// Minimum TLS version to use. Accepted values are &#39;tls10&#39;, &#39;tls11&#39;, &#39;tls12&#39; or &#39;tls13&#39;. Defaults to &#39;tls12&#39;
        /// </summary>
        /// <value>Minimum TLS version to use. Accepted values are &#39;tls10&#39;, &#39;tls11&#39;, &#39;tls12&#39; or &#39;tls13&#39;. Defaults to &#39;tls12&#39;</value>
        [DataMember(Name = "tls_min_version", EmitDefaultValue = false)]
        public TlsMinVersionEnum? TlsMinVersion { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LDAPWriteAuthConfigRequest" /> class.
        /// </summary>
        /// <param name="anonymousGroupSearch">Use anonymous binds when performing LDAP group searches (if true the initial credentials will still be used for the initial connection test). (default to false).</param>
        /// <param name="binddn">LDAP DN for searching for the user DN (optional).</param>
        /// <param name="bindpass">LDAP password for searching for the user DN (optional).</param>
        /// <param name="caseSensitiveNames">If true, case sensitivity will be used when comparing usernames and groups for matching policies..</param>
        /// <param name="certificate">CA certificate to use when verifying LDAP server certificate, must be x509 PEM encoded (optional).</param>
        /// <param name="clientTlsCert">Client certificate to provide to the LDAP server, must be x509 PEM encoded (optional).</param>
        /// <param name="clientTlsKey">Client certificate key to provide to the LDAP server, must be x509 PEM encoded (optional).</param>
        /// <param name="denyNullBind">Denies an unauthenticated LDAP bind request if the user&#39;s password is empty; defaults to true (default to true).</param>
        /// <param name="discoverdn">Use anonymous bind to discover the bind DN of a user (optional).</param>
        /// <param name="groupattr">LDAP attribute to follow on objects returned by &lt;groupfilter&gt; in order to enumerate user group membership. Examples: \&quot;cn\&quot; or \&quot;memberOf\&quot;, etc. Default: cn (default to &quot;cn&quot;).</param>
        /// <param name="groupdn">LDAP search base to use for group membership search (eg: ou&#x3D;Groups,dc&#x3D;example,dc&#x3D;org).</param>
        /// <param name="groupfilter">Go template for querying group membership of user (optional) The template can access the following context variables: UserDN, Username Example: (&amp;(objectClass&#x3D;group)(member:1.2.840.113556.1.4.1941:&#x3D;{{.UserDN}})) Default: (|(memberUid&#x3D;{{.Username}})(member&#x3D;{{.UserDN}})(uniqueMember&#x3D;{{.UserDN}})) (default to &quot;(|(memberUid&#x3D;{{.Username}})(member&#x3D;{{.UserDN}})(uniqueMember&#x3D;{{.UserDN}}))&quot;).</param>
        /// <param name="insecureTls">Skip LDAP server SSL Certificate verification - VERY insecure (optional).</param>
        /// <param name="requestTimeout">Timeout, in seconds, for the connection when making requests against the server before returning back an error..</param>
        /// <param name="starttls">Issue a StartTLS command after establishing unencrypted connection (optional).</param>
        /// <param name="tlsMaxVersion">Maximum TLS version to use. Accepted values are &#39;tls10&#39;, &#39;tls11&#39;, &#39;tls12&#39; or &#39;tls13&#39;. Defaults to &#39;tls12&#39; (default to TlsMaxVersionEnum.Tls12).</param>
        /// <param name="tlsMinVersion">Minimum TLS version to use. Accepted values are &#39;tls10&#39;, &#39;tls11&#39;, &#39;tls12&#39; or &#39;tls13&#39;. Defaults to &#39;tls12&#39; (default to TlsMinVersionEnum.Tls12).</param>
        /// <param name="tokenBoundCidrs">Comma separated string or JSON list of CIDR blocks. If set, specifies the blocks of IP addresses which are allowed to use the generated token..</param>
        /// <param name="tokenExplicitMaxTtl">If set, tokens created via this role carry an explicit maximum TTL. During renewal, the current maximum TTL values of the role and the mount are not checked for changes, and any updates to these values will have no effect on the token being renewed..</param>
        /// <param name="tokenMaxTtl">The maximum lifetime of the generated token.</param>
        /// <param name="tokenNoDefaultPolicy">If true, the &#39;default&#39; policy will not automatically be added to generated tokens.</param>
        /// <param name="tokenNumUses">The maximum number of times a token may be used, a value of zero means unlimited.</param>
        /// <param name="tokenPeriod">If set, tokens created via this role will have no max lifetime; instead, their renewal period will be fixed to this value. This takes an integer number of seconds, or a string duration (e.g. \&quot;24h\&quot;)..</param>
        /// <param name="tokenPolicies">Comma-separated list of policies. This will apply to all tokens generated by this auth method, in addition to any configured for specific users/groups..</param>
        /// <param name="tokenTtl">The initial ttl of the token to generate.</param>
        /// <param name="tokenType">The type of token to generate, service or batch (default to &quot;default-service&quot;).</param>
        /// <param name="upndomain">Enables userPrincipalDomain login with [username]@UPNDomain (optional).</param>
        /// <param name="url">LDAP URL to connect to (default: ldap://127.0.0.1). Multiple URLs can be specified by concatenating them with commas; they will be tried in-order. (default to &quot;ldap://127.0.0.1&quot;).</param>
        /// <param name="usePre111GroupCnBehavior">In Vault 1.1.1 a fix for handling group CN values of different cases unfortunately introduced a regression that could cause previously defined groups to not be found due to a change in the resulting name. If set true, the pre-1.1.1 behavior for matching group CNs will be used. This is only needed in some upgrade scenarios for backwards compatibility. It is enabled by default if the config is upgraded but disabled by default on new configurations..</param>
        /// <param name="useTokenGroups">If true, use the Active Directory tokenGroups constructed attribute of the user to find the group memberships. This will find all security groups including nested ones. (default to false).</param>
        /// <param name="userattr">Attribute used for users (default: cn) (default to &quot;cn&quot;).</param>
        /// <param name="userdn">LDAP domain to use for users (eg: ou&#x3D;People,dc&#x3D;example,dc&#x3D;org).</param>
        /// <param name="userfilter">Go template for LDAP user search filer (optional) The template can access the following context variables: UserAttr, Username Default: ({{.UserAttr}}&#x3D;{{.Username}}) (default to &quot;({{.UserAttr}}&#x3D;{{.Username}})&quot;).</param>
        /// <param name="usernameAsAlias">If true, sets the alias name to the username (default to false).</param>
        public LDAPWriteAuthConfigRequest(bool anonymousGroupSearch = false, string binddn = default(string), string bindpass = default(string), bool caseSensitiveNames = default(bool), string certificate = default(string), string clientTlsCert = default(string), string clientTlsKey = default(string), bool denyNullBind = true, bool discoverdn = default(bool), string groupattr = "cn", string groupdn = default(string), string groupfilter = "(|(memberUid={{.Username}})(member={{.UserDN}})(uniqueMember={{.UserDN}}))", bool insecureTls = default(bool), int requestTimeout = default(int), bool starttls = default(bool), TlsMaxVersionEnum? tlsMaxVersion = TlsMaxVersionEnum.Tls12, TlsMinVersionEnum? tlsMinVersion = TlsMinVersionEnum.Tls12, List<string> tokenBoundCidrs = default(List<string>), int tokenExplicitMaxTtl = default(int), int tokenMaxTtl = default(int), bool tokenNoDefaultPolicy = default(bool), int tokenNumUses = default(int), int tokenPeriod = default(int), List<string> tokenPolicies = default(List<string>), int tokenTtl = default(int), string tokenType = "default-service", string upndomain = default(string), string url = "ldap://127.0.0.1", bool usePre111GroupCnBehavior = default(bool), bool useTokenGroups = false, string userattr = "cn", string userdn = default(string), string userfilter = "({{.UserAttr}}={{.Username}})", bool usernameAsAlias = false)
        {
            this.AnonymousGroupSearch = anonymousGroupSearch;
            this.Binddn = binddn;
            this.Bindpass = bindpass;
            this.CaseSensitiveNames = caseSensitiveNames;
            this.Certificate = certificate;
            this.ClientTlsCert = clientTlsCert;
            this.ClientTlsKey = clientTlsKey;
            this.DenyNullBind = denyNullBind;
            this.Discoverdn = discoverdn;
            // use default value if no "groupattr" provided
            this.Groupattr = groupattr ?? "cn";
            this.Groupdn = groupdn;
            // use default value if no "groupfilter" provided
            this.Groupfilter = groupfilter ?? "(|(memberUid={{.Username}})(member={{.UserDN}})(uniqueMember={{.UserDN}}))";
            this.InsecureTls = insecureTls;
            this.RequestTimeout = requestTimeout;
            this.Starttls = starttls;
            this.TlsMaxVersion = tlsMaxVersion;
            this.TlsMinVersion = tlsMinVersion;
            this.TokenBoundCidrs = tokenBoundCidrs;
            this.TokenExplicitMaxTtl = tokenExplicitMaxTtl;
            this.TokenMaxTtl = tokenMaxTtl;
            this.TokenNoDefaultPolicy = tokenNoDefaultPolicy;
            this.TokenNumUses = tokenNumUses;
            this.TokenPeriod = tokenPeriod;
            this.TokenPolicies = tokenPolicies;
            this.TokenTtl = tokenTtl;
            // use default value if no "tokenType" provided
            this.TokenType = tokenType ?? "default-service";
            this.Upndomain = upndomain;
            // use default value if no "url" provided
            this.Url = url ?? "ldap://127.0.0.1";
            this.UsePre111GroupCnBehavior = usePre111GroupCnBehavior;
            this.UseTokenGroups = useTokenGroups;
            // use default value if no "userattr" provided
            this.Userattr = userattr ?? "cn";
            this.Userdn = userdn;
            // use default value if no "userfilter" provided
            this.Userfilter = userfilter ?? "({{.UserAttr}}={{.Username}})";
            this.UsernameAsAlias = usernameAsAlias;
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
        /// Denies an unauthenticated LDAP bind request if the user&#39;s password is empty; defaults to true
        /// </summary>
        /// <value>Denies an unauthenticated LDAP bind request if the user&#39;s password is empty; defaults to true</value>
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
        /// Timeout, in seconds, for the connection when making requests against the server before returning back an error.
        /// </summary>
        /// <value>Timeout, in seconds, for the connection when making requests against the server before returning back an error.</value>
        [DataMember(Name = "request_timeout", EmitDefaultValue = false)]
        public int RequestTimeout { get; set; }

        /// <summary>
        /// Issue a StartTLS command after establishing unencrypted connection (optional)
        /// </summary>
        /// <value>Issue a StartTLS command after establishing unencrypted connection (optional)</value>
        [DataMember(Name = "starttls", EmitDefaultValue = true)]
        public bool Starttls { get; set; }

        /// <summary>
        /// Comma separated string or JSON list of CIDR blocks. If set, specifies the blocks of IP addresses which are allowed to use the generated token.
        /// </summary>
        /// <value>Comma separated string or JSON list of CIDR blocks. If set, specifies the blocks of IP addresses which are allowed to use the generated token.</value>
        [DataMember(Name = "token_bound_cidrs", EmitDefaultValue = false)]
        public List<string> TokenBoundCidrs { get; set; }

        /// <summary>
        /// If set, tokens created via this role carry an explicit maximum TTL. During renewal, the current maximum TTL values of the role and the mount are not checked for changes, and any updates to these values will have no effect on the token being renewed.
        /// </summary>
        /// <value>If set, tokens created via this role carry an explicit maximum TTL. During renewal, the current maximum TTL values of the role and the mount are not checked for changes, and any updates to these values will have no effect on the token being renewed.</value>
        [DataMember(Name = "token_explicit_max_ttl", EmitDefaultValue = false)]
        public int TokenExplicitMaxTtl { get; set; }

        /// <summary>
        /// The maximum lifetime of the generated token
        /// </summary>
        /// <value>The maximum lifetime of the generated token</value>
        [DataMember(Name = "token_max_ttl", EmitDefaultValue = false)]
        public int TokenMaxTtl { get; set; }

        /// <summary>
        /// If true, the &#39;default&#39; policy will not automatically be added to generated tokens
        /// </summary>
        /// <value>If true, the &#39;default&#39; policy will not automatically be added to generated tokens</value>
        [DataMember(Name = "token_no_default_policy", EmitDefaultValue = true)]
        public bool TokenNoDefaultPolicy { get; set; }

        /// <summary>
        /// The maximum number of times a token may be used, a value of zero means unlimited
        /// </summary>
        /// <value>The maximum number of times a token may be used, a value of zero means unlimited</value>
        [DataMember(Name = "token_num_uses", EmitDefaultValue = false)]
        public int TokenNumUses { get; set; }

        /// <summary>
        /// If set, tokens created via this role will have no max lifetime; instead, their renewal period will be fixed to this value. This takes an integer number of seconds, or a string duration (e.g. \&quot;24h\&quot;).
        /// </summary>
        /// <value>If set, tokens created via this role will have no max lifetime; instead, their renewal period will be fixed to this value. This takes an integer number of seconds, or a string duration (e.g. \&quot;24h\&quot;).</value>
        [DataMember(Name = "token_period", EmitDefaultValue = false)]
        public int TokenPeriod { get; set; }

        /// <summary>
        /// Comma-separated list of policies. This will apply to all tokens generated by this auth method, in addition to any configured for specific users/groups.
        /// </summary>
        /// <value>Comma-separated list of policies. This will apply to all tokens generated by this auth method, in addition to any configured for specific users/groups.</value>
        [DataMember(Name = "token_policies", EmitDefaultValue = false)]
        public List<string> TokenPolicies { get; set; }

        /// <summary>
        /// The initial ttl of the token to generate
        /// </summary>
        /// <value>The initial ttl of the token to generate</value>
        [DataMember(Name = "token_ttl", EmitDefaultValue = false)]
        public int TokenTtl { get; set; }

        /// <summary>
        /// The type of token to generate, service or batch
        /// </summary>
        /// <value>The type of token to generate, service or batch</value>
        [DataMember(Name = "token_type", EmitDefaultValue = false)]
        public string TokenType { get; set; }

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
            sb.Append("class LDAPWriteAuthConfigRequest {\n");
            sb.Append("  AnonymousGroupSearch: ").Append(AnonymousGroupSearch).Append("\n");
            sb.Append("  Binddn: ").Append(Binddn).Append("\n");
            sb.Append("  Bindpass: ").Append(Bindpass).Append("\n");
            sb.Append("  CaseSensitiveNames: ").Append(CaseSensitiveNames).Append("\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  ClientTlsCert: ").Append(ClientTlsCert).Append("\n");
            sb.Append("  ClientTlsKey: ").Append(ClientTlsKey).Append("\n");
            sb.Append("  DenyNullBind: ").Append(DenyNullBind).Append("\n");
            sb.Append("  Discoverdn: ").Append(Discoverdn).Append("\n");
            sb.Append("  Groupattr: ").Append(Groupattr).Append("\n");
            sb.Append("  Groupdn: ").Append(Groupdn).Append("\n");
            sb.Append("  Groupfilter: ").Append(Groupfilter).Append("\n");
            sb.Append("  InsecureTls: ").Append(InsecureTls).Append("\n");
            sb.Append("  RequestTimeout: ").Append(RequestTimeout).Append("\n");
            sb.Append("  Starttls: ").Append(Starttls).Append("\n");
            sb.Append("  TlsMaxVersion: ").Append(TlsMaxVersion).Append("\n");
            sb.Append("  TlsMinVersion: ").Append(TlsMinVersion).Append("\n");
            sb.Append("  TokenBoundCidrs: ").Append(TokenBoundCidrs).Append("\n");
            sb.Append("  TokenExplicitMaxTtl: ").Append(TokenExplicitMaxTtl).Append("\n");
            sb.Append("  TokenMaxTtl: ").Append(TokenMaxTtl).Append("\n");
            sb.Append("  TokenNoDefaultPolicy: ").Append(TokenNoDefaultPolicy).Append("\n");
            sb.Append("  TokenNumUses: ").Append(TokenNumUses).Append("\n");
            sb.Append("  TokenPeriod: ").Append(TokenPeriod).Append("\n");
            sb.Append("  TokenPolicies: ").Append(TokenPolicies).Append("\n");
            sb.Append("  TokenTtl: ").Append(TokenTtl).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
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
            return this.Equals(input as LDAPWriteAuthConfigRequest);
        }

        /// <summary>
        /// Returns true if LDAPWriteAuthConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LDAPWriteAuthConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LDAPWriteAuthConfigRequest input)
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
                    this.DenyNullBind == input.DenyNullBind ||
                    this.DenyNullBind.Equals(input.DenyNullBind)
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
                    this.RequestTimeout == input.RequestTimeout ||
                    this.RequestTimeout.Equals(input.RequestTimeout)
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
                    this.TokenBoundCidrs == input.TokenBoundCidrs ||
                    this.TokenBoundCidrs != null &&
                    input.TokenBoundCidrs != null &&
                    this.TokenBoundCidrs.SequenceEqual(input.TokenBoundCidrs)
                ) && 
                (
                    this.TokenExplicitMaxTtl == input.TokenExplicitMaxTtl ||
                    this.TokenExplicitMaxTtl.Equals(input.TokenExplicitMaxTtl)
                ) && 
                (
                    this.TokenMaxTtl == input.TokenMaxTtl ||
                    this.TokenMaxTtl.Equals(input.TokenMaxTtl)
                ) && 
                (
                    this.TokenNoDefaultPolicy == input.TokenNoDefaultPolicy ||
                    this.TokenNoDefaultPolicy.Equals(input.TokenNoDefaultPolicy)
                ) && 
                (
                    this.TokenNumUses == input.TokenNumUses ||
                    this.TokenNumUses.Equals(input.TokenNumUses)
                ) && 
                (
                    this.TokenPeriod == input.TokenPeriod ||
                    this.TokenPeriod.Equals(input.TokenPeriod)
                ) && 
                (
                    this.TokenPolicies == input.TokenPolicies ||
                    this.TokenPolicies != null &&
                    input.TokenPolicies != null &&
                    this.TokenPolicies.SequenceEqual(input.TokenPolicies)
                ) && 
                (
                    this.TokenTtl == input.TokenTtl ||
                    this.TokenTtl.Equals(input.TokenTtl)
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
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
                hashCode = (hashCode * 59) + this.DenyNullBind.GetHashCode();
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
                hashCode = (hashCode * 59) + this.RequestTimeout.GetHashCode();
                hashCode = (hashCode * 59) + this.Starttls.GetHashCode();
                hashCode = (hashCode * 59) + this.TlsMaxVersion.GetHashCode();
                hashCode = (hashCode * 59) + this.TlsMinVersion.GetHashCode();
                if (this.TokenBoundCidrs != null)
                {
                    hashCode = (hashCode * 59) + this.TokenBoundCidrs.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TokenExplicitMaxTtl.GetHashCode();
                hashCode = (hashCode * 59) + this.TokenMaxTtl.GetHashCode();
                hashCode = (hashCode * 59) + this.TokenNoDefaultPolicy.GetHashCode();
                hashCode = (hashCode * 59) + this.TokenNumUses.GetHashCode();
                hashCode = (hashCode * 59) + this.TokenPeriod.GetHashCode();
                if (this.TokenPolicies != null)
                {
                    hashCode = (hashCode * 59) + this.TokenPolicies.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TokenTtl.GetHashCode();
                if (this.TokenType != null)
                {
                    hashCode = (hashCode * 59) + this.TokenType.GetHashCode();
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
