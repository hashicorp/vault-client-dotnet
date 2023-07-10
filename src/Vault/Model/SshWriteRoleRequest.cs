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
    /// SshWriteRoleRequest
    /// </summary>
    [DataContract(Name = "SshWriteRoleRequest")]
    public partial class SshWriteRoleRequest : IEquatable<SshWriteRoleRequest>, IValidatableObject
    {        /// <summary>
             /// [Not applicable for OTP type] [Optional for CA type] When supplied, this value specifies a signing algorithm for the key. Possible values: ssh-rsa, rsa-sha2-256, rsa-sha2-512, default, or the empty string.
             /// </summary>
             /// <value>[Not applicable for OTP type] [Optional for CA type] When supplied, this value specifies a signing algorithm for the key. Possible values: ssh-rsa, rsa-sha2-256, rsa-sha2-512, default, or the empty string.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlgorithmSignerEnum
        {

            /// <summary>
            /// Enum Empty for value: 
            /// </summary>
            [EnumMember(Value = "")]
            Empty = 0,
            /// <summary>
            /// Enum Default for value: default
            /// </summary>
            [EnumMember(Value = "default")]
            Default = 1,
            /// <summary>
            /// Enum SshRsa for value: ssh-rsa
            /// </summary>
            [EnumMember(Value = "ssh-rsa")]
            SshRsa = 2,
            /// <summary>
            /// Enum RsaSha2256 for value: rsa-sha2-256
            /// </summary>
            [EnumMember(Value = "rsa-sha2-256")]
            RsaSha2256 = 3,
            /// <summary>
            /// Enum RsaSha2512 for value: rsa-sha2-512
            /// </summary>
            [EnumMember(Value = "rsa-sha2-512")]
            RsaSha2512 = 4
        }
        /// <summary>
        /// [Not applicable for OTP type] [Optional for CA type] When supplied, this value specifies a signing algorithm for the key. Possible values: ssh-rsa, rsa-sha2-256, rsa-sha2-512, default, or the empty string.
        /// </summary>
        /// <value>[Not applicable for OTP type] [Optional for CA type] When supplied, this value specifies a signing algorithm for the key. Possible values: ssh-rsa, rsa-sha2-256, rsa-sha2-512, default, or the empty string.</value>

        [DataMember(Name = "algorithm_signer", EmitDefaultValue = false)]
        public AlgorithmSignerEnum? AlgorithmSigner { get; set; }

        /// <summary>
        /// [Required for all types] Type of key used to login to hosts. It can be either &#x27;otp&#x27; or &#x27;ca&#x27;. &#x27;otp&#x27; type requires agent to be installed in remote hosts.
        /// </summary>
        /// <value>[Required for all types] Type of key used to login to hosts. It can be either &#x27;otp&#x27; or &#x27;ca&#x27;. &#x27;otp&#x27; type requires agent to be installed in remote hosts.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum KeyTypeEnum
        {

            /// <summary>
            /// Enum Otp for value: otp
            /// </summary>
            [EnumMember(Value = "otp")]
            Otp = 0,
            /// <summary>
            /// Enum Ca for value: ca
            /// </summary>
            [EnumMember(Value = "ca")]
            Ca = 1
        }
        /// <summary>
        /// [Required for all types] Type of key used to login to hosts. It can be either &#x27;otp&#x27; or &#x27;ca&#x27;. &#x27;otp&#x27; type requires agent to be installed in remote hosts.
        /// </summary>
        /// <value>[Required for all types] Type of key used to login to hosts. It can be either &#x27;otp&#x27; or &#x27;ca&#x27;. &#x27;otp&#x27; type requires agent to be installed in remote hosts.</value>

        [DataMember(Name = "key_type", EmitDefaultValue = false)]
        public KeyTypeEnum? KeyType { get; set; }




        /// <summary>
        /// Initializes a new instance of the <see cref="SshWriteRoleRequest" /> class.
        /// </summary>

        /// <param name="AlgorithmSigner">[Not applicable for OTP type] [Optional for CA type] When supplied, this value specifies a signing algorithm for the key. Possible values: ssh-rsa, rsa-sha2-256, rsa-sha2-512, default, or the empty string..</param>

        /// <param name="AllowBareDomains">[Not applicable for OTP type] [Optional for CA type] If set, host certificates that are requested are allowed to use the base domains listed in \&quot;allowed_domains\&quot;, e.g. \&quot;example.com\&quot;. This is a separate option as in some cases this can be considered a security threat..</param>

        /// <param name="AllowHostCertificates">[Not applicable for OTP type] [Optional for CA type] If set, certificates are allowed to be signed for use as a &#x27;host&#x27;. (default to false).</param>

        /// <param name="AllowSubdomains">[Not applicable for OTP type] [Optional for CA type] If set, host certificates that are requested are allowed to use subdomains of those listed in \&quot;allowed_domains\&quot;..</param>

        /// <param name="AllowUserCertificates">[Not applicable for OTP type] [Optional for CA type] If set, certificates are allowed to be signed for use as a &#x27;user&#x27;. (default to false).</param>

        /// <param name="AllowUserKeyIds">[Not applicable for OTP type] [Optional for CA type] If true, users can override the key ID for a signed certificate with the \&quot;key_id\&quot; field. When false, the key ID will always be the token display name. The key ID is logged by the SSH server and can be useful for auditing..</param>

        /// <param name="AllowedCriticalOptions">[Not applicable for OTP type] [Optional for CA type] A comma-separated list of critical options that certificates can have when signed. To allow any critical options, set this to an empty string..</param>

        /// <param name="AllowedDomains">[Not applicable for OTP type] [Optional for CA type] If this option is not specified, client can request for a signed certificate for any valid host. If only certain domains are allowed, then this list enforces it..</param>

        /// <param name="AllowedDomainsTemplate">[Not applicable for OTP type] [Optional for CA type] If set, Allowed domains can be specified using identity template policies. Non-templated domains are also permitted. (default to false).</param>

        /// <param name="AllowedExtensions">[Not applicable for OTP type] [Optional for CA type] A comma-separated list of extensions that certificates can have when signed. An empty list means that no extension overrides are allowed by an end-user; explicitly specify &#x27;*&#x27; to allow any extensions to be set..</param>

        /// <param name="AllowedUserKeyLengths">[Not applicable for OTP type] [Optional for CA type] If set, allows the enforcement of key types and minimum key sizes to be signed..</param>

        /// <param name="AllowedUsers">[Optional for all types] [Works differently for CA type] If this option is not specified, or is &#x27;*&#x27;, client can request a credential for any valid user at the remote host, including the admin user. If only certain usernames are to be allowed, then this list enforces it. If this field is set, then credentials can only be created for default_user and usernames present in this list. Setting this option will enable all the users with access to this role to fetch credentials for all other usernames in this list. Use with caution. N.B.: with the CA type, an empty list means that no users are allowed; explicitly specify &#x27;*&#x27; to allow any user..</param>

        /// <param name="AllowedUsersTemplate">[Not applicable for OTP type] [Optional for CA type] If set, Allowed users can be specified using identity template policies. Non-templated users are also permitted. (default to false).</param>

        /// <param name="CidrList">[Optional for OTP type] [Not applicable for CA type] Comma separated list of CIDR blocks for which the role is applicable for. CIDR blocks can belong to more than one role..</param>

        /// <param name="DefaultCriticalOptions">[Not applicable for OTP type] [Optional for CA type] Critical options certificates should have if none are provided when signing. This field takes in key value pairs in JSON format. Note that these are not restricted by \&quot;allowed_critical_options\&quot;. Defaults to none..</param>

        /// <param name="DefaultExtensions">[Not applicable for OTP type] [Optional for CA type] Extensions certificates should have if none are provided when signing. This field takes in key value pairs in JSON format. Note that these are not restricted by \&quot;allowed_extensions\&quot;. Defaults to none..</param>

        /// <param name="DefaultExtensionsTemplate">[Not applicable for OTP type] [Optional for CA type] If set, Default extension values can be specified using identity template policies. Non-templated extension values are also permitted. (default to false).</param>

        /// <param name="DefaultUser">[Required for OTP type] [Optional for CA type] Default username for which a credential will be generated. When the endpoint &#x27;creds/&#x27; is used without a username, this value will be used as default username..</param>

        /// <param name="DefaultUserTemplate">[Not applicable for OTP type] [Optional for CA type] If set, Default user can be specified using identity template policies. Non-templated users are also permitted. (default to false).</param>

        /// <param name="ExcludeCidrList">[Optional for OTP type] [Not applicable for CA type] Comma separated list of CIDR blocks. IP addresses belonging to these blocks are not accepted by the role. This is particularly useful when big CIDR blocks are being used by the role and certain parts of it needs to be kept out..</param>

        /// <param name="KeyIdFormat">[Not applicable for OTP type] [Optional for CA type] When supplied, this value specifies a custom format for the key id of a signed certificate. The following variables are available for use: &#x27;{{token_display_name}}&#x27; - The display name of the token used to make the request. &#x27;{{role_name}}&#x27; - The name of the role signing the request. &#x27;{{public_key_hash}}&#x27; - A SHA256 checksum of the public key that is being signed..</param>

        /// <param name="KeyType">[Required for all types] Type of key used to login to hosts. It can be either &#x27;otp&#x27; or &#x27;ca&#x27;. &#x27;otp&#x27; type requires agent to be installed in remote hosts..</param>

        /// <param name="MaxTtl">[Not applicable for OTP type] [Optional for CA type] The maximum allowed lease duration.</param>

        /// <param name="NotBeforeDuration">[Not applicable for OTP type] [Optional for CA type] The duration that the SSH certificate should be backdated by at issuance. (default to &quot;30&quot;).</param>

        /// <param name="Port">[Optional for OTP type] [Not applicable for CA type] Port number for SSH connection. Default is &#x27;22&#x27;. Port number does not play any role in creation of OTP. For &#x27;otp&#x27; type, this is just a way to inform client about the port number to use. Port number will be returned to client by Vault server along with OTP..</param>

        /// <param name="Ttl">[Not applicable for OTP type] [Optional for CA type] The lease duration if no specific lease duration is requested. The lease duration controls the expiration of certificates issued by this backend. Defaults to the value of max_ttl..</param>


        public SshWriteRoleRequest(AlgorithmSignerEnum? AlgorithmSigner = default(AlgorithmSignerEnum?), bool AllowBareDomains = default(bool), bool AllowHostCertificates = false, bool AllowSubdomains = default(bool), bool AllowUserCertificates = false, bool AllowUserKeyIds = default(bool), string AllowedCriticalOptions = default(string), string AllowedDomains = default(string), bool AllowedDomainsTemplate = false, string AllowedExtensions = default(string), Object AllowedUserKeyLengths = default(Object), string AllowedUsers = default(string), bool AllowedUsersTemplate = false, string CidrList = default(string), Object DefaultCriticalOptions = default(Object), Object DefaultExtensions = default(Object), bool DefaultExtensionsTemplate = false, string DefaultUser = default(string), bool DefaultUserTemplate = false, string ExcludeCidrList = default(string), string KeyIdFormat = default(string), KeyTypeEnum? KeyType = default(KeyTypeEnum?), string MaxTtl = default(string), string NotBeforeDuration = "30", int Port = default(int), string Ttl = default(string))
        {

            this.AlgorithmSigner = AlgorithmSigner;

            this.AllowBareDomains = AllowBareDomains;

            this.AllowHostCertificates = AllowHostCertificates;

            this.AllowSubdomains = AllowSubdomains;

            this.AllowUserCertificates = AllowUserCertificates;

            this.AllowUserKeyIds = AllowUserKeyIds;

            this.AllowedCriticalOptions = AllowedCriticalOptions;

            this.AllowedDomains = AllowedDomains;

            this.AllowedDomainsTemplate = AllowedDomainsTemplate;

            this.AllowedExtensions = AllowedExtensions;

            this.AllowedUserKeyLengths = AllowedUserKeyLengths;

            this.AllowedUsers = AllowedUsers;

            this.AllowedUsersTemplate = AllowedUsersTemplate;

            this.CidrList = CidrList;

            this.DefaultCriticalOptions = DefaultCriticalOptions;

            this.DefaultExtensions = DefaultExtensions;

            this.DefaultExtensionsTemplate = DefaultExtensionsTemplate;

            this.DefaultUser = DefaultUser;

            this.DefaultUserTemplate = DefaultUserTemplate;

            this.ExcludeCidrList = ExcludeCidrList;

            this.KeyIdFormat = KeyIdFormat;

            this.KeyType = KeyType;

            this.MaxTtl = MaxTtl;

            // use default value if no "NotBeforeDuration" provided
            this.NotBeforeDuration = NotBeforeDuration ?? "30";


            this.Port = Port;

            this.Ttl = Ttl;

        }

        /// <summary>
        /// [Not applicable for OTP type] [Optional for CA type] If set, host certificates that are requested are allowed to use the base domains listed in \&quot;allowed_domains\&quot;, e.g. \&quot;example.com\&quot;. This is a separate option as in some cases this can be considered a security threat.
        /// </summary>
        /// <value>[Not applicable for OTP type] [Optional for CA type] If set, host certificates that are requested are allowed to use the base domains listed in \&quot;allowed_domains\&quot;, e.g. \&quot;example.com\&quot;. This is a separate option as in some cases this can be considered a security threat.</value>
        [DataMember(Name = "allow_bare_domains", EmitDefaultValue = true)]

        public bool AllowBareDomains { get; set; }


        /// <summary>
        /// [Not applicable for OTP type] [Optional for CA type] If set, certificates are allowed to be signed for use as a &#x27;host&#x27;.
        /// </summary>
        /// <value>[Not applicable for OTP type] [Optional for CA type] If set, certificates are allowed to be signed for use as a &#x27;host&#x27;.</value>
        [DataMember(Name = "allow_host_certificates", EmitDefaultValue = true)]

        public bool AllowHostCertificates { get; set; }


        /// <summary>
        /// [Not applicable for OTP type] [Optional for CA type] If set, host certificates that are requested are allowed to use subdomains of those listed in \&quot;allowed_domains\&quot;.
        /// </summary>
        /// <value>[Not applicable for OTP type] [Optional for CA type] If set, host certificates that are requested are allowed to use subdomains of those listed in \&quot;allowed_domains\&quot;.</value>
        [DataMember(Name = "allow_subdomains", EmitDefaultValue = true)]

        public bool AllowSubdomains { get; set; }


        /// <summary>
        /// [Not applicable for OTP type] [Optional for CA type] If set, certificates are allowed to be signed for use as a &#x27;user&#x27;.
        /// </summary>
        /// <value>[Not applicable for OTP type] [Optional for CA type] If set, certificates are allowed to be signed for use as a &#x27;user&#x27;.</value>
        [DataMember(Name = "allow_user_certificates", EmitDefaultValue = true)]

        public bool AllowUserCertificates { get; set; }


        /// <summary>
        /// [Not applicable for OTP type] [Optional for CA type] If true, users can override the key ID for a signed certificate with the \&quot;key_id\&quot; field. When false, the key ID will always be the token display name. The key ID is logged by the SSH server and can be useful for auditing.
        /// </summary>
        /// <value>[Not applicable for OTP type] [Optional for CA type] If true, users can override the key ID for a signed certificate with the \&quot;key_id\&quot; field. When false, the key ID will always be the token display name. The key ID is logged by the SSH server and can be useful for auditing.</value>
        [DataMember(Name = "allow_user_key_ids", EmitDefaultValue = true)]

        public bool AllowUserKeyIds { get; set; }


        /// <summary>
        /// [Not applicable for OTP type] [Optional for CA type] A comma-separated list of critical options that certificates can have when signed. To allow any critical options, set this to an empty string.
        /// </summary>
        /// <value>[Not applicable for OTP type] [Optional for CA type] A comma-separated list of critical options that certificates can have when signed. To allow any critical options, set this to an empty string.</value>
        [DataMember(Name = "allowed_critical_options", EmitDefaultValue = false)]

        public string AllowedCriticalOptions { get; set; }


        /// <summary>
        /// [Not applicable for OTP type] [Optional for CA type] If this option is not specified, client can request for a signed certificate for any valid host. If only certain domains are allowed, then this list enforces it.
        /// </summary>
        /// <value>[Not applicable for OTP type] [Optional for CA type] If this option is not specified, client can request for a signed certificate for any valid host. If only certain domains are allowed, then this list enforces it.</value>
        [DataMember(Name = "allowed_domains", EmitDefaultValue = false)]

        public string AllowedDomains { get; set; }


        /// <summary>
        /// [Not applicable for OTP type] [Optional for CA type] If set, Allowed domains can be specified using identity template policies. Non-templated domains are also permitted.
        /// </summary>
        /// <value>[Not applicable for OTP type] [Optional for CA type] If set, Allowed domains can be specified using identity template policies. Non-templated domains are also permitted.</value>
        [DataMember(Name = "allowed_domains_template", EmitDefaultValue = true)]

        public bool AllowedDomainsTemplate { get; set; }


        /// <summary>
        /// [Not applicable for OTP type] [Optional for CA type] A comma-separated list of extensions that certificates can have when signed. An empty list means that no extension overrides are allowed by an end-user; explicitly specify &#x27;*&#x27; to allow any extensions to be set.
        /// </summary>
        /// <value>[Not applicable for OTP type] [Optional for CA type] A comma-separated list of extensions that certificates can have when signed. An empty list means that no extension overrides are allowed by an end-user; explicitly specify &#x27;*&#x27; to allow any extensions to be set.</value>
        [DataMember(Name = "allowed_extensions", EmitDefaultValue = false)]

        public string AllowedExtensions { get; set; }


        /// <summary>
        /// [Not applicable for OTP type] [Optional for CA type] If set, allows the enforcement of key types and minimum key sizes to be signed.
        /// </summary>
        /// <value>[Not applicable for OTP type] [Optional for CA type] If set, allows the enforcement of key types and minimum key sizes to be signed.</value>
        [DataMember(Name = "allowed_user_key_lengths", EmitDefaultValue = false)]

        public Object AllowedUserKeyLengths { get; set; }


        /// <summary>
        /// [Optional for all types] [Works differently for CA type] If this option is not specified, or is &#x27;*&#x27;, client can request a credential for any valid user at the remote host, including the admin user. If only certain usernames are to be allowed, then this list enforces it. If this field is set, then credentials can only be created for default_user and usernames present in this list. Setting this option will enable all the users with access to this role to fetch credentials for all other usernames in this list. Use with caution. N.B.: with the CA type, an empty list means that no users are allowed; explicitly specify &#x27;*&#x27; to allow any user.
        /// </summary>
        /// <value>[Optional for all types] [Works differently for CA type] If this option is not specified, or is &#x27;*&#x27;, client can request a credential for any valid user at the remote host, including the admin user. If only certain usernames are to be allowed, then this list enforces it. If this field is set, then credentials can only be created for default_user and usernames present in this list. Setting this option will enable all the users with access to this role to fetch credentials for all other usernames in this list. Use with caution. N.B.: with the CA type, an empty list means that no users are allowed; explicitly specify &#x27;*&#x27; to allow any user.</value>
        [DataMember(Name = "allowed_users", EmitDefaultValue = false)]

        public string AllowedUsers { get; set; }


        /// <summary>
        /// [Not applicable for OTP type] [Optional for CA type] If set, Allowed users can be specified using identity template policies. Non-templated users are also permitted.
        /// </summary>
        /// <value>[Not applicable for OTP type] [Optional for CA type] If set, Allowed users can be specified using identity template policies. Non-templated users are also permitted.</value>
        [DataMember(Name = "allowed_users_template", EmitDefaultValue = true)]

        public bool AllowedUsersTemplate { get; set; }


        /// <summary>
        /// [Optional for OTP type] [Not applicable for CA type] Comma separated list of CIDR blocks for which the role is applicable for. CIDR blocks can belong to more than one role.
        /// </summary>
        /// <value>[Optional for OTP type] [Not applicable for CA type] Comma separated list of CIDR blocks for which the role is applicable for. CIDR blocks can belong to more than one role.</value>
        [DataMember(Name = "cidr_list", EmitDefaultValue = false)]

        public string CidrList { get; set; }


        /// <summary>
        /// [Not applicable for OTP type] [Optional for CA type] Critical options certificates should have if none are provided when signing. This field takes in key value pairs in JSON format. Note that these are not restricted by \&quot;allowed_critical_options\&quot;. Defaults to none.
        /// </summary>
        /// <value>[Not applicable for OTP type] [Optional for CA type] Critical options certificates should have if none are provided when signing. This field takes in key value pairs in JSON format. Note that these are not restricted by \&quot;allowed_critical_options\&quot;. Defaults to none.</value>
        [DataMember(Name = "default_critical_options", EmitDefaultValue = false)]

        public Object DefaultCriticalOptions { get; set; }


        /// <summary>
        /// [Not applicable for OTP type] [Optional for CA type] Extensions certificates should have if none are provided when signing. This field takes in key value pairs in JSON format. Note that these are not restricted by \&quot;allowed_extensions\&quot;. Defaults to none.
        /// </summary>
        /// <value>[Not applicable for OTP type] [Optional for CA type] Extensions certificates should have if none are provided when signing. This field takes in key value pairs in JSON format. Note that these are not restricted by \&quot;allowed_extensions\&quot;. Defaults to none.</value>
        [DataMember(Name = "default_extensions", EmitDefaultValue = false)]

        public Object DefaultExtensions { get; set; }


        /// <summary>
        /// [Not applicable for OTP type] [Optional for CA type] If set, Default extension values can be specified using identity template policies. Non-templated extension values are also permitted.
        /// </summary>
        /// <value>[Not applicable for OTP type] [Optional for CA type] If set, Default extension values can be specified using identity template policies. Non-templated extension values are also permitted.</value>
        [DataMember(Name = "default_extensions_template", EmitDefaultValue = true)]

        public bool DefaultExtensionsTemplate { get; set; }


        /// <summary>
        /// [Required for OTP type] [Optional for CA type] Default username for which a credential will be generated. When the endpoint &#x27;creds/&#x27; is used without a username, this value will be used as default username.
        /// </summary>
        /// <value>[Required for OTP type] [Optional for CA type] Default username for which a credential will be generated. When the endpoint &#x27;creds/&#x27; is used without a username, this value will be used as default username.</value>
        [DataMember(Name = "default_user", EmitDefaultValue = false)]

        public string DefaultUser { get; set; }


        /// <summary>
        /// [Not applicable for OTP type] [Optional for CA type] If set, Default user can be specified using identity template policies. Non-templated users are also permitted.
        /// </summary>
        /// <value>[Not applicable for OTP type] [Optional for CA type] If set, Default user can be specified using identity template policies. Non-templated users are also permitted.</value>
        [DataMember(Name = "default_user_template", EmitDefaultValue = true)]

        public bool DefaultUserTemplate { get; set; }


        /// <summary>
        /// [Optional for OTP type] [Not applicable for CA type] Comma separated list of CIDR blocks. IP addresses belonging to these blocks are not accepted by the role. This is particularly useful when big CIDR blocks are being used by the role and certain parts of it needs to be kept out.
        /// </summary>
        /// <value>[Optional for OTP type] [Not applicable for CA type] Comma separated list of CIDR blocks. IP addresses belonging to these blocks are not accepted by the role. This is particularly useful when big CIDR blocks are being used by the role and certain parts of it needs to be kept out.</value>
        [DataMember(Name = "exclude_cidr_list", EmitDefaultValue = false)]

        public string ExcludeCidrList { get; set; }


        /// <summary>
        /// [Not applicable for OTP type] [Optional for CA type] When supplied, this value specifies a custom format for the key id of a signed certificate. The following variables are available for use: &#x27;{{token_display_name}}&#x27; - The display name of the token used to make the request. &#x27;{{role_name}}&#x27; - The name of the role signing the request. &#x27;{{public_key_hash}}&#x27; - A SHA256 checksum of the public key that is being signed.
        /// </summary>
        /// <value>[Not applicable for OTP type] [Optional for CA type] When supplied, this value specifies a custom format for the key id of a signed certificate. The following variables are available for use: &#x27;{{token_display_name}}&#x27; - The display name of the token used to make the request. &#x27;{{role_name}}&#x27; - The name of the role signing the request. &#x27;{{public_key_hash}}&#x27; - A SHA256 checksum of the public key that is being signed.</value>
        [DataMember(Name = "key_id_format", EmitDefaultValue = false)]

        public string KeyIdFormat { get; set; }


        /// <summary>
        /// [Not applicable for OTP type] [Optional for CA type] The maximum allowed lease duration
        /// </summary>
        /// <value>[Not applicable for OTP type] [Optional for CA type] The maximum allowed lease duration</value>
        [DataMember(Name = "max_ttl", EmitDefaultValue = false)]

        public string MaxTtl { get; set; }


        /// <summary>
        /// [Not applicable for OTP type] [Optional for CA type] The duration that the SSH certificate should be backdated by at issuance.
        /// </summary>
        /// <value>[Not applicable for OTP type] [Optional for CA type] The duration that the SSH certificate should be backdated by at issuance.</value>
        [DataMember(Name = "not_before_duration", EmitDefaultValue = false)]

        public string NotBeforeDuration { get; set; }


        /// <summary>
        /// [Optional for OTP type] [Not applicable for CA type] Port number for SSH connection. Default is &#x27;22&#x27;. Port number does not play any role in creation of OTP. For &#x27;otp&#x27; type, this is just a way to inform client about the port number to use. Port number will be returned to client by Vault server along with OTP.
        /// </summary>
        /// <value>[Optional for OTP type] [Not applicable for CA type] Port number for SSH connection. Default is &#x27;22&#x27;. Port number does not play any role in creation of OTP. For &#x27;otp&#x27; type, this is just a way to inform client about the port number to use. Port number will be returned to client by Vault server along with OTP.</value>
        [DataMember(Name = "port", EmitDefaultValue = false)]

        public int Port { get; set; }


        /// <summary>
        /// [Not applicable for OTP type] [Optional for CA type] The lease duration if no specific lease duration is requested. The lease duration controls the expiration of certificates issued by this backend. Defaults to the value of max_ttl.
        /// </summary>
        /// <value>[Not applicable for OTP type] [Optional for CA type] The lease duration if no specific lease duration is requested. The lease duration controls the expiration of certificates issued by this backend. Defaults to the value of max_ttl.</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]

        public string Ttl { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SshWriteRoleRequest {\n");
            sb.Append("  AlgorithmSigner: ").Append(AlgorithmSigner).Append("\n");
            sb.Append("  AllowBareDomains: ").Append(AllowBareDomains).Append("\n");
            sb.Append("  AllowHostCertificates: ").Append(AllowHostCertificates).Append("\n");
            sb.Append("  AllowSubdomains: ").Append(AllowSubdomains).Append("\n");
            sb.Append("  AllowUserCertificates: ").Append(AllowUserCertificates).Append("\n");
            sb.Append("  AllowUserKeyIds: ").Append(AllowUserKeyIds).Append("\n");
            sb.Append("  AllowedCriticalOptions: ").Append(AllowedCriticalOptions).Append("\n");
            sb.Append("  AllowedDomains: ").Append(AllowedDomains).Append("\n");
            sb.Append("  AllowedDomainsTemplate: ").Append(AllowedDomainsTemplate).Append("\n");
            sb.Append("  AllowedExtensions: ").Append(AllowedExtensions).Append("\n");
            sb.Append("  AllowedUserKeyLengths: ").Append(AllowedUserKeyLengths).Append("\n");
            sb.Append("  AllowedUsers: ").Append(AllowedUsers).Append("\n");
            sb.Append("  AllowedUsersTemplate: ").Append(AllowedUsersTemplate).Append("\n");
            sb.Append("  CidrList: ").Append(CidrList).Append("\n");
            sb.Append("  DefaultCriticalOptions: ").Append(DefaultCriticalOptions).Append("\n");
            sb.Append("  DefaultExtensions: ").Append(DefaultExtensions).Append("\n");
            sb.Append("  DefaultExtensionsTemplate: ").Append(DefaultExtensionsTemplate).Append("\n");
            sb.Append("  DefaultUser: ").Append(DefaultUser).Append("\n");
            sb.Append("  DefaultUserTemplate: ").Append(DefaultUserTemplate).Append("\n");
            sb.Append("  ExcludeCidrList: ").Append(ExcludeCidrList).Append("\n");
            sb.Append("  KeyIdFormat: ").Append(KeyIdFormat).Append("\n");
            sb.Append("  KeyType: ").Append(KeyType).Append("\n");
            sb.Append("  MaxTtl: ").Append(MaxTtl).Append("\n");
            sb.Append("  NotBeforeDuration: ").Append(NotBeforeDuration).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
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
            return this.Equals(input as SshWriteRoleRequest);
        }

        /// <summary>
        /// Returns true if SshWriteRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SshWriteRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SshWriteRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AlgorithmSigner == input.AlgorithmSigner ||

                    this.AlgorithmSigner.Equals(input.AlgorithmSigner)
                ) &&
                (
                    this.AllowBareDomains == input.AllowBareDomains ||

                    this.AllowBareDomains.Equals(input.AllowBareDomains)
                ) &&
                (
                    this.AllowHostCertificates == input.AllowHostCertificates ||

                    this.AllowHostCertificates.Equals(input.AllowHostCertificates)
                ) &&
                (
                    this.AllowSubdomains == input.AllowSubdomains ||

                    this.AllowSubdomains.Equals(input.AllowSubdomains)
                ) &&
                (
                    this.AllowUserCertificates == input.AllowUserCertificates ||

                    this.AllowUserCertificates.Equals(input.AllowUserCertificates)
                ) &&
                (
                    this.AllowUserKeyIds == input.AllowUserKeyIds ||

                    this.AllowUserKeyIds.Equals(input.AllowUserKeyIds)
                ) &&
                (
                    this.AllowedCriticalOptions == input.AllowedCriticalOptions ||
                    (this.AllowedCriticalOptions != null &&
                    this.AllowedCriticalOptions.Equals(input.AllowedCriticalOptions))

                ) &&
                (
                    this.AllowedDomains == input.AllowedDomains ||
                    (this.AllowedDomains != null &&
                    this.AllowedDomains.Equals(input.AllowedDomains))

                ) &&
                (
                    this.AllowedDomainsTemplate == input.AllowedDomainsTemplate ||

                    this.AllowedDomainsTemplate.Equals(input.AllowedDomainsTemplate)
                ) &&
                (
                    this.AllowedExtensions == input.AllowedExtensions ||
                    (this.AllowedExtensions != null &&
                    this.AllowedExtensions.Equals(input.AllowedExtensions))

                ) &&
                (
                    this.AllowedUserKeyLengths == input.AllowedUserKeyLengths ||
                    (this.AllowedUserKeyLengths != null &&
                    this.AllowedUserKeyLengths.Equals(input.AllowedUserKeyLengths))

                ) &&
                (
                    this.AllowedUsers == input.AllowedUsers ||
                    (this.AllowedUsers != null &&
                    this.AllowedUsers.Equals(input.AllowedUsers))

                ) &&
                (
                    this.AllowedUsersTemplate == input.AllowedUsersTemplate ||

                    this.AllowedUsersTemplate.Equals(input.AllowedUsersTemplate)
                ) &&
                (
                    this.CidrList == input.CidrList ||
                    (this.CidrList != null &&
                    this.CidrList.Equals(input.CidrList))

                ) &&
                (
                    this.DefaultCriticalOptions == input.DefaultCriticalOptions ||
                    (this.DefaultCriticalOptions != null &&
                    this.DefaultCriticalOptions.Equals(input.DefaultCriticalOptions))

                ) &&
                (
                    this.DefaultExtensions == input.DefaultExtensions ||
                    (this.DefaultExtensions != null &&
                    this.DefaultExtensions.Equals(input.DefaultExtensions))

                ) &&
                (
                    this.DefaultExtensionsTemplate == input.DefaultExtensionsTemplate ||

                    this.DefaultExtensionsTemplate.Equals(input.DefaultExtensionsTemplate)
                ) &&
                (
                    this.DefaultUser == input.DefaultUser ||
                    (this.DefaultUser != null &&
                    this.DefaultUser.Equals(input.DefaultUser))

                ) &&
                (
                    this.DefaultUserTemplate == input.DefaultUserTemplate ||

                    this.DefaultUserTemplate.Equals(input.DefaultUserTemplate)
                ) &&
                (
                    this.ExcludeCidrList == input.ExcludeCidrList ||
                    (this.ExcludeCidrList != null &&
                    this.ExcludeCidrList.Equals(input.ExcludeCidrList))

                ) &&
                (
                    this.KeyIdFormat == input.KeyIdFormat ||
                    (this.KeyIdFormat != null &&
                    this.KeyIdFormat.Equals(input.KeyIdFormat))

                ) &&
                (
                    this.KeyType == input.KeyType ||

                    this.KeyType.Equals(input.KeyType)
                ) &&
                (
                    this.MaxTtl == input.MaxTtl ||
                    (this.MaxTtl != null &&
                    this.MaxTtl.Equals(input.MaxTtl))

                ) &&
                (
                    this.NotBeforeDuration == input.NotBeforeDuration ||
                    (this.NotBeforeDuration != null &&
                    this.NotBeforeDuration.Equals(input.NotBeforeDuration))

                ) &&
                (
                    this.Port == input.Port ||

                    this.Port.Equals(input.Port)
                ) &&
                (
                    this.Ttl == input.Ttl ||
                    (this.Ttl != null &&
                    this.Ttl.Equals(input.Ttl))

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


                hashCode = (hashCode * 59) + this.AlgorithmSigner.GetHashCode();

                hashCode = (hashCode * 59) + this.AllowBareDomains.GetHashCode();

                hashCode = (hashCode * 59) + this.AllowHostCertificates.GetHashCode();

                hashCode = (hashCode * 59) + this.AllowSubdomains.GetHashCode();

                hashCode = (hashCode * 59) + this.AllowUserCertificates.GetHashCode();

                hashCode = (hashCode * 59) + this.AllowUserKeyIds.GetHashCode();
                if (this.AllowedCriticalOptions != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedCriticalOptions.GetHashCode();
                }

                if (this.AllowedDomains != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedDomains.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.AllowedDomainsTemplate.GetHashCode();
                if (this.AllowedExtensions != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedExtensions.GetHashCode();
                }

                if (this.AllowedUserKeyLengths != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedUserKeyLengths.GetHashCode();
                }

                if (this.AllowedUsers != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedUsers.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.AllowedUsersTemplate.GetHashCode();
                if (this.CidrList != null)
                {
                    hashCode = (hashCode * 59) + this.CidrList.GetHashCode();
                }

                if (this.DefaultCriticalOptions != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultCriticalOptions.GetHashCode();
                }

                if (this.DefaultExtensions != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultExtensions.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.DefaultExtensionsTemplate.GetHashCode();
                if (this.DefaultUser != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultUser.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.DefaultUserTemplate.GetHashCode();
                if (this.ExcludeCidrList != null)
                {
                    hashCode = (hashCode * 59) + this.ExcludeCidrList.GetHashCode();
                }

                if (this.KeyIdFormat != null)
                {
                    hashCode = (hashCode * 59) + this.KeyIdFormat.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.KeyType.GetHashCode();
                if (this.MaxTtl != null)
                {
                    hashCode = (hashCode * 59) + this.MaxTtl.GetHashCode();
                }

                if (this.NotBeforeDuration != null)
                {
                    hashCode = (hashCode * 59) + this.NotBeforeDuration.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Port.GetHashCode();
                if (this.Ttl != null)
                {
                    hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
                }

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
