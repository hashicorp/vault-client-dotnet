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
    /// PKIWriteRoleRequest
    /// </summary>
    [DataContract(Name = "PKIWriteRoleRequest")]
    public partial class PKIWriteRoleRequest : IEquatable<PKIWriteRoleRequest>, IValidatableObject
    {





















































        /// <summary>
        /// The type of key to use; defaults to RSA. \&quot;rsa\&quot; \&quot;ec\&quot;, \&quot;ed25519\&quot; and \&quot;any\&quot; are the only valid values.
        /// </summary>
        /// <value>The type of key to use; defaults to RSA. \&quot;rsa\&quot; \&quot;ec\&quot;, \&quot;ed25519\&quot; and \&quot;any\&quot; are the only valid values.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum KeyTypeEnum
        {

            /// <summary>
            /// Enum Rsa for value: rsa
            /// </summary>
            [EnumMember(Value = "rsa")]
            Rsa = 0,
            /// <summary>
            /// Enum Ec for value: ec
            /// </summary>
            [EnumMember(Value = "ec")]
            Ec = 1,
            /// <summary>
            /// Enum Ed25519 for value: ed25519
            /// </summary>
            [EnumMember(Value = "ed25519")]
            Ed25519 = 2,
            /// <summary>
            /// Enum Any for value: any
            /// </summary>
            [EnumMember(Value = "any")]
            Any = 3
        }

        /// <summary>
        /// The type of key to use; defaults to RSA. \&quot;rsa\&quot; \&quot;ec\&quot;, \&quot;ed25519\&quot; and \&quot;any\&quot; are the only valid values.
        /// </summary>
        /// <value>The type of key to use; defaults to RSA. \&quot;rsa\&quot; \&quot;ec\&quot;, \&quot;ed25519\&quot; and \&quot;any\&quot; are the only valid values.</value>

        [DataMember(Name = "key_type", EmitDefaultValue = false)]

        public KeyTypeEnum? KeyType { get; set; }










































        /// <summary>
        /// Initializes a new instance of the <see cref="PKIWriteRoleRequest" /> class.
        /// </summary>

        /// <param name="AllowAnyName">If set, clients can request certificates for any domain, regardless of allowed_domains restrictions. See the documentation for more information..</param>

        /// <param name="AllowBareDomains">If set, clients can request certificates for the base domains themselves, e.g. \&quot;example.com\&quot; of domains listed in allowed_domains. This is a separate option as in some cases this can be considered a security threat. See the documentation for more information..</param>

        /// <param name="AllowGlobDomains">If set, domains specified in allowed_domains can include shell-style glob patterns, e.g. \&quot;ftp*.example.com\&quot;. See the documentation for more information..</param>

        /// <param name="AllowIpSans">If set, IP Subject Alternative Names are allowed. Any valid IP is accepted and No authorization checking is performed. (default to true).</param>

        /// <param name="AllowLocalhost">Whether to allow \&quot;localhost\&quot; and \&quot;localdomain\&quot; as a valid common name in a request, independent of allowed_domains value. (default to true).</param>

        /// <param name="AllowSubdomains">If set, clients can request certificates for subdomains of domains listed in allowed_domains, including wildcard subdomains. See the documentation for more information..</param>

        /// <param name="AllowWildcardCertificates">If set, allows certificates with wildcards in the common name to be issued, conforming to RFC 6125&#x27;s Section 6.4.3; e.g., \&quot;*.example.net\&quot; or \&quot;b*z.example.net\&quot;. See the documentation for more information. (default to true).</param>

        /// <param name="AllowedDomains">Specifies the domains this role is allowed to issue certificates for. This is used with the allow_bare_domains, allow_subdomains, and allow_glob_domains to determine matches for the common name, DNS-typed SAN entries, and Email-typed SAN entries of certificates. See the documentation for more information. This parameter accepts a comma-separated string or list of domains..</param>

        /// <param name="AllowedDomainsTemplate">If set, Allowed domains can be specified using identity template policies. Non-templated domains are also permitted. (default to false).</param>

        /// <param name="AllowedOtherSans">If set, an array of allowed other names to put in SANs. These values support globbing and must be in the format &lt;oid&gt;;&lt;type&gt;:&lt;value&gt;. Currently only \&quot;utf8\&quot; is a valid type. All values, including globbing values, must use this syntax, with the exception being a single \&quot;*\&quot; which allows any OID and any value (but type must still be utf8)..</param>

        /// <param name="AllowedSerialNumbers">If set, an array of allowed serial numbers to put in Subject. These values support globbing..</param>

        /// <param name="AllowedUriSans">If set, an array of allowed URIs for URI Subject Alternative Names. Any valid URI is accepted, these values support globbing..</param>

        /// <param name="AllowedUriSansTemplate">If set, Allowed URI SANs can be specified using identity template policies. Non-templated URI SANs are also permitted. (default to false).</param>

        /// <param name="Backend">Backend Type.</param>

        /// <param name="BasicConstraintsValidForNonCa">Mark Basic Constraints valid when issuing non-CA certificates..</param>

        /// <param name="ClientFlag">If set, certificates are flagged for client auth use. Defaults to true. See also RFC 5280 Section 4.2.1.12. (default to true).</param>

        /// <param name="CnValidations">List of allowed validations to run against the Common Name field. Values can include &#x27;email&#x27; to validate the CN is a email address, &#x27;hostname&#x27; to validate the CN is a valid hostname (potentially including wildcards). When multiple validations are specified, these take OR semantics (either email OR hostname are allowed). The special value &#x27;disabled&#x27; allows disabling all CN name validations, allowing for arbitrary non-Hostname, non-Email address CNs..</param>

        /// <param name="CodeSigningFlag">If set, certificates are flagged for code signing use. Defaults to false. See also RFC 5280 Section 4.2.1.12..</param>

        /// <param name="Country">If set, Country will be set to this value in certificates issued by this role..</param>

        /// <param name="EmailProtectionFlag">If set, certificates are flagged for email protection use. Defaults to false. See also RFC 5280 Section 4.2.1.12..</param>

        /// <param name="EnforceHostnames">If set, only valid host names are allowed for CN and DNS SANs, and the host part of email addresses. Defaults to true. (default to true).</param>

        /// <param name="ExtKeyUsage">A comma-separated string or list of extended key usages. Valid values can be found at https://golang.org/pkg/crypto/x509/#ExtKeyUsage - - simply drop the \&quot;ExtKeyUsage\&quot; part of the name. To remove all key usages from being set, set this value to an empty list. See also RFC 5280 Section 4.2.1.12..</param>

        /// <param name="ExtKeyUsageOids">A comma-separated string or list of extended key usage oids..</param>

        /// <param name="GenerateLease">If set, certificates issued/signed against this role will have Vault leases attached to them. Defaults to \&quot;false\&quot;. Certificates can be added to the CRL by \&quot;vault revoke &lt;lease_id&gt;\&quot; when certificates are associated with leases. It can also be done using the \&quot;pki/revoke\&quot; endpoint. However, when lease generation is disabled, invoking \&quot;pki/revoke\&quot; would be the only way to add the certificates to the CRL. When large number of certificates are generated with long lifetimes, it is recommended that lease generation be disabled, as large amount of leases adversely affect the startup time of Vault..</param>

        /// <param name="IssuerRef">Reference to the issuer used to sign requests serviced by this role. (default to &quot;default&quot;).</param>

        /// <param name="KeyBits">The number of bits to use. Allowed values are 0 (universal default); with rsa key_type: 2048 (default), 3072, or 4096; with ec key_type: 224, 256 (default), 384, or 521; ignored with ed25519. (default to 0).</param>

        /// <param name="KeyType">The type of key to use; defaults to RSA. \&quot;rsa\&quot; \&quot;ec\&quot;, \&quot;ed25519\&quot; and \&quot;any\&quot; are the only valid values. (default to KeyTypeEnum.Rsa).</param>

        /// <param name="KeyUsage">A comma-separated string or list of key usages (not extended key usages). Valid values can be found at https://golang.org/pkg/crypto/x509/#KeyUsage - - simply drop the \&quot;KeyUsage\&quot; part of the name. To remove all key usages from being set, set this value to an empty list. See also RFC 5280 Section 4.2.1.3..</param>

        /// <param name="Locality">If set, Locality will be set to this value in certificates issued by this role..</param>

        /// <param name="MaxTtl">The maximum allowed lease duration. If not set, defaults to the system maximum lease TTL..</param>

        /// <param name="NoStore">If set, certificates issued/signed against this role will not be stored in the storage backend. This can improve performance when issuing large numbers of certificates. However, certificates issued in this way cannot be enumerated or revoked, so this option is recommended only for certificates that are non-sensitive, or extremely short-lived. This option implies a value of \&quot;false\&quot; for \&quot;generate_lease\&quot;..</param>

        /// <param name="NotAfter">Set the not after field of the certificate with specified date value. The value format should be given in UTC format YYYY-MM-ddTHH:MM:SSZ..</param>

        /// <param name="NotBeforeDuration">The duration before now which the certificate needs to be backdated by. (default to 30).</param>

        /// <param name="Organization">If set, O (Organization) will be set to this value in certificates issued by this role..</param>

        /// <param name="Ou">If set, OU (OrganizationalUnit) will be set to this value in certificates issued by this role..</param>

        /// <param name="PolicyIdentifiers">A comma-separated string or list of policy OIDs, or a JSON list of qualified policy information, which must include an oid, and may include a notice and/or cps url, using the form [{\&quot;oid\&quot;&#x3D;\&quot;1.3.6.1.4.1.7.8\&quot;,\&quot;notice\&quot;&#x3D;\&quot;I am a user Notice\&quot;}, {\&quot;oid\&quot;&#x3D;\&quot;1.3.6.1.4.1.44947.1.2.4 \&quot;,\&quot;cps\&quot;&#x3D;\&quot;https://example.com\&quot;}]..</param>

        /// <param name="PostalCode">If set, Postal Code will be set to this value in certificates issued by this role..</param>

        /// <param name="Province">If set, Province will be set to this value in certificates issued by this role..</param>

        /// <param name="RequireCn">If set to false, makes the &#x27;common_name&#x27; field optional while generating a certificate. (default to true).</param>

        /// <param name="ServerFlag">If set, certificates are flagged for server auth use. Defaults to true. See also RFC 5280 Section 4.2.1.12. (default to true).</param>

        /// <param name="SignatureBits">The number of bits to use in the signature algorithm; accepts 256 for SHA-2-256, 384 for SHA-2-384, and 512 for SHA-2-512. Defaults to 0 to automatically detect based on key length (SHA-2-256 for RSA keys, and matching the curve size for NIST P-Curves). (default to 0).</param>

        /// <param name="StreetAddress">If set, Street Address will be set to this value in certificates issued by this role..</param>

        /// <param name="Ttl">The lease duration (validity period of the certificate) if no specific lease duration is requested. The lease duration controls the expiration of certificates issued by this backend. Defaults to the system default value or the value of max_ttl, whichever is shorter..</param>

        /// <param name="UseCsrCommonName">If set, when used with a signing profile, the common name in the CSR will be used. This does *not* include any requested Subject Alternative Names; use use_csr_sans for that. Defaults to true. (default to true).</param>

        /// <param name="UseCsrSans">If set, when used with a signing profile, the SANs in the CSR will be used. This does *not* include the Common Name (cn); use use_csr_common_name for that. Defaults to true. (default to true).</param>

        /// <param name="UsePss">Whether or not to use PSS signatures when using a RSA key-type issuer. Defaults to false. (default to false).</param>


        public PKIWriteRoleRequest(bool AllowAnyName = default(bool), bool AllowBareDomains = default(bool), bool AllowGlobDomains = default(bool), bool AllowIpSans = true, bool AllowLocalhost = true, bool AllowSubdomains = default(bool), bool AllowWildcardCertificates = true, List<string> AllowedDomains = default(List<string>), bool AllowedDomainsTemplate = false, List<string> AllowedOtherSans = default(List<string>), List<string> AllowedSerialNumbers = default(List<string>), List<string> AllowedUriSans = default(List<string>), bool AllowedUriSansTemplate = false, string Backend = default(string), bool BasicConstraintsValidForNonCa = default(bool), bool ClientFlag = true, List<string> CnValidations = default(List<string>), bool CodeSigningFlag = default(bool), List<string> Country = default(List<string>), bool EmailProtectionFlag = default(bool), bool EnforceHostnames = true, List<string> ExtKeyUsage = default(List<string>), List<string> ExtKeyUsageOids = default(List<string>), bool GenerateLease = default(bool), string IssuerRef = "default", int KeyBits = 0, KeyTypeEnum? KeyType = KeyTypeEnum.Rsa, List<string> KeyUsage = default(List<string>), List<string> Locality = default(List<string>), int MaxTtl = default(int), bool NoStore = default(bool), string NotAfter = default(string), int NotBeforeDuration = 30, List<string> Organization = default(List<string>), List<string> Ou = default(List<string>), List<string> PolicyIdentifiers = default(List<string>), List<string> PostalCode = default(List<string>), List<string> Province = default(List<string>), bool RequireCn = true, bool ServerFlag = true, int SignatureBits = 0, List<string> StreetAddress = default(List<string>), int Ttl = default(int), bool UseCsrCommonName = true, bool UseCsrSans = true, bool UsePss = false)
        {

            this.AllowAnyName = AllowAnyName;

            this.AllowBareDomains = AllowBareDomains;

            this.AllowGlobDomains = AllowGlobDomains;

            this.AllowIpSans = AllowIpSans;

            this.AllowLocalhost = AllowLocalhost;

            this.AllowSubdomains = AllowSubdomains;

            this.AllowWildcardCertificates = AllowWildcardCertificates;

            this.AllowedDomains = AllowedDomains;

            this.AllowedDomainsTemplate = AllowedDomainsTemplate;

            this.AllowedOtherSans = AllowedOtherSans;

            this.AllowedSerialNumbers = AllowedSerialNumbers;

            this.AllowedUriSans = AllowedUriSans;

            this.AllowedUriSansTemplate = AllowedUriSansTemplate;

            this.Backend = Backend;

            this.BasicConstraintsValidForNonCa = BasicConstraintsValidForNonCa;

            this.ClientFlag = ClientFlag;

            this.CnValidations = CnValidations;

            this.CodeSigningFlag = CodeSigningFlag;

            this.Country = Country;

            this.EmailProtectionFlag = EmailProtectionFlag;

            this.EnforceHostnames = EnforceHostnames;

            this.ExtKeyUsage = ExtKeyUsage;

            this.ExtKeyUsageOids = ExtKeyUsageOids;

            this.GenerateLease = GenerateLease;

            // use default value if no "IssuerRef" provided
            this.IssuerRef = IssuerRef ?? "default";


            this.KeyBits = KeyBits;

            this.KeyType = KeyType;

            this.KeyUsage = KeyUsage;

            this.Locality = Locality;

            this.MaxTtl = MaxTtl;

            this.NoStore = NoStore;

            this.NotAfter = NotAfter;

            this.NotBeforeDuration = NotBeforeDuration;

            this.Organization = Organization;

            this.Ou = Ou;

            this.PolicyIdentifiers = PolicyIdentifiers;

            this.PostalCode = PostalCode;

            this.Province = Province;

            this.RequireCn = RequireCn;

            this.ServerFlag = ServerFlag;

            this.SignatureBits = SignatureBits;

            this.StreetAddress = StreetAddress;

            this.Ttl = Ttl;

            this.UseCsrCommonName = UseCsrCommonName;

            this.UseCsrSans = UseCsrSans;

            this.UsePss = UsePss;

        }

        /// <summary>
        /// If set, clients can request certificates for any domain, regardless of allowed_domains restrictions. See the documentation for more information.
        /// </summary>
        /// <value>If set, clients can request certificates for any domain, regardless of allowed_domains restrictions. See the documentation for more information.</value>
        [DataMember(Name = "allow_any_name", EmitDefaultValue = true)]


        public bool AllowAnyName { get; set; }


        /// <summary>
        /// If set, clients can request certificates for the base domains themselves, e.g. \&quot;example.com\&quot; of domains listed in allowed_domains. This is a separate option as in some cases this can be considered a security threat. See the documentation for more information.
        /// </summary>
        /// <value>If set, clients can request certificates for the base domains themselves, e.g. \&quot;example.com\&quot; of domains listed in allowed_domains. This is a separate option as in some cases this can be considered a security threat. See the documentation for more information.</value>
        [DataMember(Name = "allow_bare_domains", EmitDefaultValue = true)]


        public bool AllowBareDomains { get; set; }


        /// <summary>
        /// If set, domains specified in allowed_domains can include shell-style glob patterns, e.g. \&quot;ftp*.example.com\&quot;. See the documentation for more information.
        /// </summary>
        /// <value>If set, domains specified in allowed_domains can include shell-style glob patterns, e.g. \&quot;ftp*.example.com\&quot;. See the documentation for more information.</value>
        [DataMember(Name = "allow_glob_domains", EmitDefaultValue = true)]


        public bool AllowGlobDomains { get; set; }


        /// <summary>
        /// If set, IP Subject Alternative Names are allowed. Any valid IP is accepted and No authorization checking is performed.
        /// </summary>
        /// <value>If set, IP Subject Alternative Names are allowed. Any valid IP is accepted and No authorization checking is performed.</value>
        [DataMember(Name = "allow_ip_sans", EmitDefaultValue = true)]


        public bool AllowIpSans { get; set; }


        /// <summary>
        /// Whether to allow \&quot;localhost\&quot; and \&quot;localdomain\&quot; as a valid common name in a request, independent of allowed_domains value.
        /// </summary>
        /// <value>Whether to allow \&quot;localhost\&quot; and \&quot;localdomain\&quot; as a valid common name in a request, independent of allowed_domains value.</value>
        [DataMember(Name = "allow_localhost", EmitDefaultValue = true)]


        public bool AllowLocalhost { get; set; }


        /// <summary>
        /// If set, clients can request certificates for subdomains of domains listed in allowed_domains, including wildcard subdomains. See the documentation for more information.
        /// </summary>
        /// <value>If set, clients can request certificates for subdomains of domains listed in allowed_domains, including wildcard subdomains. See the documentation for more information.</value>
        [DataMember(Name = "allow_subdomains", EmitDefaultValue = true)]


        public bool AllowSubdomains { get; set; }


        /// <summary>
        /// If set, allows certificates with wildcards in the common name to be issued, conforming to RFC 6125&#x27;s Section 6.4.3; e.g., \&quot;*.example.net\&quot; or \&quot;b*z.example.net\&quot;. See the documentation for more information.
        /// </summary>
        /// <value>If set, allows certificates with wildcards in the common name to be issued, conforming to RFC 6125&#x27;s Section 6.4.3; e.g., \&quot;*.example.net\&quot; or \&quot;b*z.example.net\&quot;. See the documentation for more information.</value>
        [DataMember(Name = "allow_wildcard_certificates", EmitDefaultValue = true)]


        public bool AllowWildcardCertificates { get; set; }


        /// <summary>
        /// Specifies the domains this role is allowed to issue certificates for. This is used with the allow_bare_domains, allow_subdomains, and allow_glob_domains to determine matches for the common name, DNS-typed SAN entries, and Email-typed SAN entries of certificates. See the documentation for more information. This parameter accepts a comma-separated string or list of domains.
        /// </summary>
        /// <value>Specifies the domains this role is allowed to issue certificates for. This is used with the allow_bare_domains, allow_subdomains, and allow_glob_domains to determine matches for the common name, DNS-typed SAN entries, and Email-typed SAN entries of certificates. See the documentation for more information. This parameter accepts a comma-separated string or list of domains.</value>
        [DataMember(Name = "allowed_domains", EmitDefaultValue = false)]


        public List<string> AllowedDomains { get; set; }


        /// <summary>
        /// If set, Allowed domains can be specified using identity template policies. Non-templated domains are also permitted.
        /// </summary>
        /// <value>If set, Allowed domains can be specified using identity template policies. Non-templated domains are also permitted.</value>
        [DataMember(Name = "allowed_domains_template", EmitDefaultValue = true)]


        public bool AllowedDomainsTemplate { get; set; }


        /// <summary>
        /// If set, an array of allowed other names to put in SANs. These values support globbing and must be in the format &lt;oid&gt;;&lt;type&gt;:&lt;value&gt;. Currently only \&quot;utf8\&quot; is a valid type. All values, including globbing values, must use this syntax, with the exception being a single \&quot;*\&quot; which allows any OID and any value (but type must still be utf8).
        /// </summary>
        /// <value>If set, an array of allowed other names to put in SANs. These values support globbing and must be in the format &lt;oid&gt;;&lt;type&gt;:&lt;value&gt;. Currently only \&quot;utf8\&quot; is a valid type. All values, including globbing values, must use this syntax, with the exception being a single \&quot;*\&quot; which allows any OID and any value (but type must still be utf8).</value>
        [DataMember(Name = "allowed_other_sans", EmitDefaultValue = false)]


        public List<string> AllowedOtherSans { get; set; }


        /// <summary>
        /// If set, an array of allowed serial numbers to put in Subject. These values support globbing.
        /// </summary>
        /// <value>If set, an array of allowed serial numbers to put in Subject. These values support globbing.</value>
        [DataMember(Name = "allowed_serial_numbers", EmitDefaultValue = false)]


        public List<string> AllowedSerialNumbers { get; set; }


        /// <summary>
        /// If set, an array of allowed URIs for URI Subject Alternative Names. Any valid URI is accepted, these values support globbing.
        /// </summary>
        /// <value>If set, an array of allowed URIs for URI Subject Alternative Names. Any valid URI is accepted, these values support globbing.</value>
        [DataMember(Name = "allowed_uri_sans", EmitDefaultValue = false)]


        public List<string> AllowedUriSans { get; set; }


        /// <summary>
        /// If set, Allowed URI SANs can be specified using identity template policies. Non-templated URI SANs are also permitted.
        /// </summary>
        /// <value>If set, Allowed URI SANs can be specified using identity template policies. Non-templated URI SANs are also permitted.</value>
        [DataMember(Name = "allowed_uri_sans_template", EmitDefaultValue = true)]


        public bool AllowedUriSansTemplate { get; set; }


        /// <summary>
        /// Backend Type
        /// </summary>
        /// <value>Backend Type</value>
        [DataMember(Name = "backend", EmitDefaultValue = false)]


        public string Backend { get; set; }


        /// <summary>
        /// Mark Basic Constraints valid when issuing non-CA certificates.
        /// </summary>
        /// <value>Mark Basic Constraints valid when issuing non-CA certificates.</value>
        [DataMember(Name = "basic_constraints_valid_for_non_ca", EmitDefaultValue = true)]


        public bool BasicConstraintsValidForNonCa { get; set; }


        /// <summary>
        /// If set, certificates are flagged for client auth use. Defaults to true. See also RFC 5280 Section 4.2.1.12.
        /// </summary>
        /// <value>If set, certificates are flagged for client auth use. Defaults to true. See also RFC 5280 Section 4.2.1.12.</value>
        [DataMember(Name = "client_flag", EmitDefaultValue = true)]


        public bool ClientFlag { get; set; }


        /// <summary>
        /// List of allowed validations to run against the Common Name field. Values can include &#x27;email&#x27; to validate the CN is a email address, &#x27;hostname&#x27; to validate the CN is a valid hostname (potentially including wildcards). When multiple validations are specified, these take OR semantics (either email OR hostname are allowed). The special value &#x27;disabled&#x27; allows disabling all CN name validations, allowing for arbitrary non-Hostname, non-Email address CNs.
        /// </summary>
        /// <value>List of allowed validations to run against the Common Name field. Values can include &#x27;email&#x27; to validate the CN is a email address, &#x27;hostname&#x27; to validate the CN is a valid hostname (potentially including wildcards). When multiple validations are specified, these take OR semantics (either email OR hostname are allowed). The special value &#x27;disabled&#x27; allows disabling all CN name validations, allowing for arbitrary non-Hostname, non-Email address CNs.</value>
        [DataMember(Name = "cn_validations", EmitDefaultValue = false)]


        public List<string> CnValidations { get; set; }


        /// <summary>
        /// If set, certificates are flagged for code signing use. Defaults to false. See also RFC 5280 Section 4.2.1.12.
        /// </summary>
        /// <value>If set, certificates are flagged for code signing use. Defaults to false. See also RFC 5280 Section 4.2.1.12.</value>
        [DataMember(Name = "code_signing_flag", EmitDefaultValue = true)]


        public bool CodeSigningFlag { get; set; }


        /// <summary>
        /// If set, Country will be set to this value in certificates issued by this role.
        /// </summary>
        /// <value>If set, Country will be set to this value in certificates issued by this role.</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]


        public List<string> Country { get; set; }


        /// <summary>
        /// If set, certificates are flagged for email protection use. Defaults to false. See also RFC 5280 Section 4.2.1.12.
        /// </summary>
        /// <value>If set, certificates are flagged for email protection use. Defaults to false. See also RFC 5280 Section 4.2.1.12.</value>
        [DataMember(Name = "email_protection_flag", EmitDefaultValue = true)]


        public bool EmailProtectionFlag { get; set; }


        /// <summary>
        /// If set, only valid host names are allowed for CN and DNS SANs, and the host part of email addresses. Defaults to true.
        /// </summary>
        /// <value>If set, only valid host names are allowed for CN and DNS SANs, and the host part of email addresses. Defaults to true.</value>
        [DataMember(Name = "enforce_hostnames", EmitDefaultValue = true)]


        public bool EnforceHostnames { get; set; }


        /// <summary>
        /// A comma-separated string or list of extended key usages. Valid values can be found at https://golang.org/pkg/crypto/x509/#ExtKeyUsage - - simply drop the \&quot;ExtKeyUsage\&quot; part of the name. To remove all key usages from being set, set this value to an empty list. See also RFC 5280 Section 4.2.1.12.
        /// </summary>
        /// <value>A comma-separated string or list of extended key usages. Valid values can be found at https://golang.org/pkg/crypto/x509/#ExtKeyUsage - - simply drop the \&quot;ExtKeyUsage\&quot; part of the name. To remove all key usages from being set, set this value to an empty list. See also RFC 5280 Section 4.2.1.12.</value>
        [DataMember(Name = "ext_key_usage", EmitDefaultValue = false)]


        public List<string> ExtKeyUsage { get; set; }


        /// <summary>
        /// A comma-separated string or list of extended key usage oids.
        /// </summary>
        /// <value>A comma-separated string or list of extended key usage oids.</value>
        [DataMember(Name = "ext_key_usage_oids", EmitDefaultValue = false)]


        public List<string> ExtKeyUsageOids { get; set; }


        /// <summary>
        /// If set, certificates issued/signed against this role will have Vault leases attached to them. Defaults to \&quot;false\&quot;. Certificates can be added to the CRL by \&quot;vault revoke &lt;lease_id&gt;\&quot; when certificates are associated with leases. It can also be done using the \&quot;pki/revoke\&quot; endpoint. However, when lease generation is disabled, invoking \&quot;pki/revoke\&quot; would be the only way to add the certificates to the CRL. When large number of certificates are generated with long lifetimes, it is recommended that lease generation be disabled, as large amount of leases adversely affect the startup time of Vault.
        /// </summary>
        /// <value>If set, certificates issued/signed against this role will have Vault leases attached to them. Defaults to \&quot;false\&quot;. Certificates can be added to the CRL by \&quot;vault revoke &lt;lease_id&gt;\&quot; when certificates are associated with leases. It can also be done using the \&quot;pki/revoke\&quot; endpoint. However, when lease generation is disabled, invoking \&quot;pki/revoke\&quot; would be the only way to add the certificates to the CRL. When large number of certificates are generated with long lifetimes, it is recommended that lease generation be disabled, as large amount of leases adversely affect the startup time of Vault.</value>
        [DataMember(Name = "generate_lease", EmitDefaultValue = true)]


        public bool GenerateLease { get; set; }


        /// <summary>
        /// Reference to the issuer used to sign requests serviced by this role.
        /// </summary>
        /// <value>Reference to the issuer used to sign requests serviced by this role.</value>
        [DataMember(Name = "issuer_ref", EmitDefaultValue = false)]


        public string IssuerRef { get; set; }


        /// <summary>
        /// The number of bits to use. Allowed values are 0 (universal default); with rsa key_type: 2048 (default), 3072, or 4096; with ec key_type: 224, 256 (default), 384, or 521; ignored with ed25519.
        /// </summary>
        /// <value>The number of bits to use. Allowed values are 0 (universal default); with rsa key_type: 2048 (default), 3072, or 4096; with ec key_type: 224, 256 (default), 384, or 521; ignored with ed25519.</value>
        [DataMember(Name = "key_bits", EmitDefaultValue = false)]


        public int KeyBits { get; set; }


        /// <summary>
        /// A comma-separated string or list of key usages (not extended key usages). Valid values can be found at https://golang.org/pkg/crypto/x509/#KeyUsage - - simply drop the \&quot;KeyUsage\&quot; part of the name. To remove all key usages from being set, set this value to an empty list. See also RFC 5280 Section 4.2.1.3.
        /// </summary>
        /// <value>A comma-separated string or list of key usages (not extended key usages). Valid values can be found at https://golang.org/pkg/crypto/x509/#KeyUsage - - simply drop the \&quot;KeyUsage\&quot; part of the name. To remove all key usages from being set, set this value to an empty list. See also RFC 5280 Section 4.2.1.3.</value>
        [DataMember(Name = "key_usage", EmitDefaultValue = false)]


        public List<string> KeyUsage { get; set; }


        /// <summary>
        /// If set, Locality will be set to this value in certificates issued by this role.
        /// </summary>
        /// <value>If set, Locality will be set to this value in certificates issued by this role.</value>
        [DataMember(Name = "locality", EmitDefaultValue = false)]


        public List<string> Locality { get; set; }


        /// <summary>
        /// The maximum allowed lease duration. If not set, defaults to the system maximum lease TTL.
        /// </summary>
        /// <value>The maximum allowed lease duration. If not set, defaults to the system maximum lease TTL.</value>
        [DataMember(Name = "max_ttl", EmitDefaultValue = false)]


        public int MaxTtl { get; set; }


        /// <summary>
        /// If set, certificates issued/signed against this role will not be stored in the storage backend. This can improve performance when issuing large numbers of certificates. However, certificates issued in this way cannot be enumerated or revoked, so this option is recommended only for certificates that are non-sensitive, or extremely short-lived. This option implies a value of \&quot;false\&quot; for \&quot;generate_lease\&quot;.
        /// </summary>
        /// <value>If set, certificates issued/signed against this role will not be stored in the storage backend. This can improve performance when issuing large numbers of certificates. However, certificates issued in this way cannot be enumerated or revoked, so this option is recommended only for certificates that are non-sensitive, or extremely short-lived. This option implies a value of \&quot;false\&quot; for \&quot;generate_lease\&quot;.</value>
        [DataMember(Name = "no_store", EmitDefaultValue = true)]


        public bool NoStore { get; set; }


        /// <summary>
        /// Set the not after field of the certificate with specified date value. The value format should be given in UTC format YYYY-MM-ddTHH:MM:SSZ.
        /// </summary>
        /// <value>Set the not after field of the certificate with specified date value. The value format should be given in UTC format YYYY-MM-ddTHH:MM:SSZ.</value>
        [DataMember(Name = "not_after", EmitDefaultValue = false)]


        public string NotAfter { get; set; }


        /// <summary>
        /// The duration before now which the certificate needs to be backdated by.
        /// </summary>
        /// <value>The duration before now which the certificate needs to be backdated by.</value>
        [DataMember(Name = "not_before_duration", EmitDefaultValue = false)]


        public int NotBeforeDuration { get; set; }


        /// <summary>
        /// If set, O (Organization) will be set to this value in certificates issued by this role.
        /// </summary>
        /// <value>If set, O (Organization) will be set to this value in certificates issued by this role.</value>
        [DataMember(Name = "organization", EmitDefaultValue = false)]


        public List<string> Organization { get; set; }


        /// <summary>
        /// If set, OU (OrganizationalUnit) will be set to this value in certificates issued by this role.
        /// </summary>
        /// <value>If set, OU (OrganizationalUnit) will be set to this value in certificates issued by this role.</value>
        [DataMember(Name = "ou", EmitDefaultValue = false)]


        public List<string> Ou { get; set; }


        /// <summary>
        /// A comma-separated string or list of policy OIDs, or a JSON list of qualified policy information, which must include an oid, and may include a notice and/or cps url, using the form [{\&quot;oid\&quot;&#x3D;\&quot;1.3.6.1.4.1.7.8\&quot;,\&quot;notice\&quot;&#x3D;\&quot;I am a user Notice\&quot;}, {\&quot;oid\&quot;&#x3D;\&quot;1.3.6.1.4.1.44947.1.2.4 \&quot;,\&quot;cps\&quot;&#x3D;\&quot;https://example.com\&quot;}].
        /// </summary>
        /// <value>A comma-separated string or list of policy OIDs, or a JSON list of qualified policy information, which must include an oid, and may include a notice and/or cps url, using the form [{\&quot;oid\&quot;&#x3D;\&quot;1.3.6.1.4.1.7.8\&quot;,\&quot;notice\&quot;&#x3D;\&quot;I am a user Notice\&quot;}, {\&quot;oid\&quot;&#x3D;\&quot;1.3.6.1.4.1.44947.1.2.4 \&quot;,\&quot;cps\&quot;&#x3D;\&quot;https://example.com\&quot;}].</value>
        [DataMember(Name = "policy_identifiers", EmitDefaultValue = false)]


        public List<string> PolicyIdentifiers { get; set; }


        /// <summary>
        /// If set, Postal Code will be set to this value in certificates issued by this role.
        /// </summary>
        /// <value>If set, Postal Code will be set to this value in certificates issued by this role.</value>
        [DataMember(Name = "postal_code", EmitDefaultValue = false)]


        public List<string> PostalCode { get; set; }


        /// <summary>
        /// If set, Province will be set to this value in certificates issued by this role.
        /// </summary>
        /// <value>If set, Province will be set to this value in certificates issued by this role.</value>
        [DataMember(Name = "province", EmitDefaultValue = false)]


        public List<string> Province { get; set; }


        /// <summary>
        /// If set to false, makes the &#x27;common_name&#x27; field optional while generating a certificate.
        /// </summary>
        /// <value>If set to false, makes the &#x27;common_name&#x27; field optional while generating a certificate.</value>
        [DataMember(Name = "require_cn", EmitDefaultValue = true)]


        public bool RequireCn { get; set; }


        /// <summary>
        /// If set, certificates are flagged for server auth use. Defaults to true. See also RFC 5280 Section 4.2.1.12.
        /// </summary>
        /// <value>If set, certificates are flagged for server auth use. Defaults to true. See also RFC 5280 Section 4.2.1.12.</value>
        [DataMember(Name = "server_flag", EmitDefaultValue = true)]


        public bool ServerFlag { get; set; }


        /// <summary>
        /// The number of bits to use in the signature algorithm; accepts 256 for SHA-2-256, 384 for SHA-2-384, and 512 for SHA-2-512. Defaults to 0 to automatically detect based on key length (SHA-2-256 for RSA keys, and matching the curve size for NIST P-Curves).
        /// </summary>
        /// <value>The number of bits to use in the signature algorithm; accepts 256 for SHA-2-256, 384 for SHA-2-384, and 512 for SHA-2-512. Defaults to 0 to automatically detect based on key length (SHA-2-256 for RSA keys, and matching the curve size for NIST P-Curves).</value>
        [DataMember(Name = "signature_bits", EmitDefaultValue = false)]


        public int SignatureBits { get; set; }


        /// <summary>
        /// If set, Street Address will be set to this value in certificates issued by this role.
        /// </summary>
        /// <value>If set, Street Address will be set to this value in certificates issued by this role.</value>
        [DataMember(Name = "street_address", EmitDefaultValue = false)]


        public List<string> StreetAddress { get; set; }


        /// <summary>
        /// The lease duration (validity period of the certificate) if no specific lease duration is requested. The lease duration controls the expiration of certificates issued by this backend. Defaults to the system default value or the value of max_ttl, whichever is shorter.
        /// </summary>
        /// <value>The lease duration (validity period of the certificate) if no specific lease duration is requested. The lease duration controls the expiration of certificates issued by this backend. Defaults to the system default value or the value of max_ttl, whichever is shorter.</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]


        public int Ttl { get; set; }


        /// <summary>
        /// If set, when used with a signing profile, the common name in the CSR will be used. This does *not* include any requested Subject Alternative Names; use use_csr_sans for that. Defaults to true.
        /// </summary>
        /// <value>If set, when used with a signing profile, the common name in the CSR will be used. This does *not* include any requested Subject Alternative Names; use use_csr_sans for that. Defaults to true.</value>
        [DataMember(Name = "use_csr_common_name", EmitDefaultValue = true)]


        public bool UseCsrCommonName { get; set; }


        /// <summary>
        /// If set, when used with a signing profile, the SANs in the CSR will be used. This does *not* include the Common Name (cn); use use_csr_common_name for that. Defaults to true.
        /// </summary>
        /// <value>If set, when used with a signing profile, the SANs in the CSR will be used. This does *not* include the Common Name (cn); use use_csr_common_name for that. Defaults to true.</value>
        [DataMember(Name = "use_csr_sans", EmitDefaultValue = true)]


        public bool UseCsrSans { get; set; }


        /// <summary>
        /// Whether or not to use PSS signatures when using a RSA key-type issuer. Defaults to false.
        /// </summary>
        /// <value>Whether or not to use PSS signatures when using a RSA key-type issuer. Defaults to false.</value>
        [DataMember(Name = "use_pss", EmitDefaultValue = true)]


        public bool UsePss { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PKIWriteRoleRequest {\n");
            sb.Append("  AllowAnyName: ").Append(AllowAnyName).Append("\n");
            sb.Append("  AllowBareDomains: ").Append(AllowBareDomains).Append("\n");
            sb.Append("  AllowGlobDomains: ").Append(AllowGlobDomains).Append("\n");
            sb.Append("  AllowIpSans: ").Append(AllowIpSans).Append("\n");
            sb.Append("  AllowLocalhost: ").Append(AllowLocalhost).Append("\n");
            sb.Append("  AllowSubdomains: ").Append(AllowSubdomains).Append("\n");
            sb.Append("  AllowWildcardCertificates: ").Append(AllowWildcardCertificates).Append("\n");
            sb.Append("  AllowedDomains: ").Append(AllowedDomains).Append("\n");
            sb.Append("  AllowedDomainsTemplate: ").Append(AllowedDomainsTemplate).Append("\n");
            sb.Append("  AllowedOtherSans: ").Append(AllowedOtherSans).Append("\n");
            sb.Append("  AllowedSerialNumbers: ").Append(AllowedSerialNumbers).Append("\n");
            sb.Append("  AllowedUriSans: ").Append(AllowedUriSans).Append("\n");
            sb.Append("  AllowedUriSansTemplate: ").Append(AllowedUriSansTemplate).Append("\n");
            sb.Append("  Backend: ").Append(Backend).Append("\n");
            sb.Append("  BasicConstraintsValidForNonCa: ").Append(BasicConstraintsValidForNonCa).Append("\n");
            sb.Append("  ClientFlag: ").Append(ClientFlag).Append("\n");
            sb.Append("  CnValidations: ").Append(CnValidations).Append("\n");
            sb.Append("  CodeSigningFlag: ").Append(CodeSigningFlag).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  EmailProtectionFlag: ").Append(EmailProtectionFlag).Append("\n");
            sb.Append("  EnforceHostnames: ").Append(EnforceHostnames).Append("\n");
            sb.Append("  ExtKeyUsage: ").Append(ExtKeyUsage).Append("\n");
            sb.Append("  ExtKeyUsageOids: ").Append(ExtKeyUsageOids).Append("\n");
            sb.Append("  GenerateLease: ").Append(GenerateLease).Append("\n");
            sb.Append("  IssuerRef: ").Append(IssuerRef).Append("\n");
            sb.Append("  KeyBits: ").Append(KeyBits).Append("\n");
            sb.Append("  KeyType: ").Append(KeyType).Append("\n");
            sb.Append("  KeyUsage: ").Append(KeyUsage).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  MaxTtl: ").Append(MaxTtl).Append("\n");
            sb.Append("  NoStore: ").Append(NoStore).Append("\n");
            sb.Append("  NotAfter: ").Append(NotAfter).Append("\n");
            sb.Append("  NotBeforeDuration: ").Append(NotBeforeDuration).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Ou: ").Append(Ou).Append("\n");
            sb.Append("  PolicyIdentifiers: ").Append(PolicyIdentifiers).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Province: ").Append(Province).Append("\n");
            sb.Append("  RequireCn: ").Append(RequireCn).Append("\n");
            sb.Append("  ServerFlag: ").Append(ServerFlag).Append("\n");
            sb.Append("  SignatureBits: ").Append(SignatureBits).Append("\n");
            sb.Append("  StreetAddress: ").Append(StreetAddress).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
            sb.Append("  UseCsrCommonName: ").Append(UseCsrCommonName).Append("\n");
            sb.Append("  UseCsrSans: ").Append(UseCsrSans).Append("\n");
            sb.Append("  UsePss: ").Append(UsePss).Append("\n");
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
            return this.Equals(input as PKIWriteRoleRequest);
        }

        /// <summary>
        /// Returns true if PKIWriteRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PKIWriteRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PKIWriteRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AllowAnyName == input.AllowAnyName ||

                    this.AllowAnyName.Equals(input.AllowAnyName)
                ) &&
                (
                    this.AllowBareDomains == input.AllowBareDomains ||

                    this.AllowBareDomains.Equals(input.AllowBareDomains)
                ) &&
                (
                    this.AllowGlobDomains == input.AllowGlobDomains ||

                    this.AllowGlobDomains.Equals(input.AllowGlobDomains)
                ) &&
                (
                    this.AllowIpSans == input.AllowIpSans ||

                    this.AllowIpSans.Equals(input.AllowIpSans)
                ) &&
                (
                    this.AllowLocalhost == input.AllowLocalhost ||

                    this.AllowLocalhost.Equals(input.AllowLocalhost)
                ) &&
                (
                    this.AllowSubdomains == input.AllowSubdomains ||

                    this.AllowSubdomains.Equals(input.AllowSubdomains)
                ) &&
                (
                    this.AllowWildcardCertificates == input.AllowWildcardCertificates ||

                    this.AllowWildcardCertificates.Equals(input.AllowWildcardCertificates)
                ) &&
                (
                    this.AllowedDomains == input.AllowedDomains ||
                    this.AllowedDomains != null &&
                    input.AllowedDomains != null &&
                    this.AllowedDomains.SequenceEqual(input.AllowedDomains)
                ) &&
                (
                    this.AllowedDomainsTemplate == input.AllowedDomainsTemplate ||

                    this.AllowedDomainsTemplate.Equals(input.AllowedDomainsTemplate)
                ) &&
                (
                    this.AllowedOtherSans == input.AllowedOtherSans ||
                    this.AllowedOtherSans != null &&
                    input.AllowedOtherSans != null &&
                    this.AllowedOtherSans.SequenceEqual(input.AllowedOtherSans)
                ) &&
                (
                    this.AllowedSerialNumbers == input.AllowedSerialNumbers ||
                    this.AllowedSerialNumbers != null &&
                    input.AllowedSerialNumbers != null &&
                    this.AllowedSerialNumbers.SequenceEqual(input.AllowedSerialNumbers)
                ) &&
                (
                    this.AllowedUriSans == input.AllowedUriSans ||
                    this.AllowedUriSans != null &&
                    input.AllowedUriSans != null &&
                    this.AllowedUriSans.SequenceEqual(input.AllowedUriSans)
                ) &&
                (
                    this.AllowedUriSansTemplate == input.AllowedUriSansTemplate ||

                    this.AllowedUriSansTemplate.Equals(input.AllowedUriSansTemplate)
                ) &&
                (
                    this.Backend == input.Backend ||
                    (this.Backend != null &&
                    this.Backend.Equals(input.Backend))

                ) &&
                (
                    this.BasicConstraintsValidForNonCa == input.BasicConstraintsValidForNonCa ||

                    this.BasicConstraintsValidForNonCa.Equals(input.BasicConstraintsValidForNonCa)
                ) &&
                (
                    this.ClientFlag == input.ClientFlag ||

                    this.ClientFlag.Equals(input.ClientFlag)
                ) &&
                (
                    this.CnValidations == input.CnValidations ||
                    this.CnValidations != null &&
                    input.CnValidations != null &&
                    this.CnValidations.SequenceEqual(input.CnValidations)
                ) &&
                (
                    this.CodeSigningFlag == input.CodeSigningFlag ||

                    this.CodeSigningFlag.Equals(input.CodeSigningFlag)
                ) &&
                (
                    this.Country == input.Country ||
                    this.Country != null &&
                    input.Country != null &&
                    this.Country.SequenceEqual(input.Country)
                ) &&
                (
                    this.EmailProtectionFlag == input.EmailProtectionFlag ||

                    this.EmailProtectionFlag.Equals(input.EmailProtectionFlag)
                ) &&
                (
                    this.EnforceHostnames == input.EnforceHostnames ||

                    this.EnforceHostnames.Equals(input.EnforceHostnames)
                ) &&
                (
                    this.ExtKeyUsage == input.ExtKeyUsage ||
                    this.ExtKeyUsage != null &&
                    input.ExtKeyUsage != null &&
                    this.ExtKeyUsage.SequenceEqual(input.ExtKeyUsage)
                ) &&
                (
                    this.ExtKeyUsageOids == input.ExtKeyUsageOids ||
                    this.ExtKeyUsageOids != null &&
                    input.ExtKeyUsageOids != null &&
                    this.ExtKeyUsageOids.SequenceEqual(input.ExtKeyUsageOids)
                ) &&
                (
                    this.GenerateLease == input.GenerateLease ||

                    this.GenerateLease.Equals(input.GenerateLease)
                ) &&
                (
                    this.IssuerRef == input.IssuerRef ||
                    (this.IssuerRef != null &&
                    this.IssuerRef.Equals(input.IssuerRef))

                ) &&
                (
                    this.KeyBits == input.KeyBits ||

                    this.KeyBits.Equals(input.KeyBits)
                ) &&
                (
                    this.KeyType == input.KeyType ||

                    this.KeyType.Equals(input.KeyType)
                ) &&
                (
                    this.KeyUsage == input.KeyUsage ||
                    this.KeyUsage != null &&
                    input.KeyUsage != null &&
                    this.KeyUsage.SequenceEqual(input.KeyUsage)
                ) &&
                (
                    this.Locality == input.Locality ||
                    this.Locality != null &&
                    input.Locality != null &&
                    this.Locality.SequenceEqual(input.Locality)
                ) &&
                (
                    this.MaxTtl == input.MaxTtl ||

                    this.MaxTtl.Equals(input.MaxTtl)
                ) &&
                (
                    this.NoStore == input.NoStore ||

                    this.NoStore.Equals(input.NoStore)
                ) &&
                (
                    this.NotAfter == input.NotAfter ||
                    (this.NotAfter != null &&
                    this.NotAfter.Equals(input.NotAfter))

                ) &&
                (
                    this.NotBeforeDuration == input.NotBeforeDuration ||

                    this.NotBeforeDuration.Equals(input.NotBeforeDuration)
                ) &&
                (
                    this.Organization == input.Organization ||
                    this.Organization != null &&
                    input.Organization != null &&
                    this.Organization.SequenceEqual(input.Organization)
                ) &&
                (
                    this.Ou == input.Ou ||
                    this.Ou != null &&
                    input.Ou != null &&
                    this.Ou.SequenceEqual(input.Ou)
                ) &&
                (
                    this.PolicyIdentifiers == input.PolicyIdentifiers ||
                    this.PolicyIdentifiers != null &&
                    input.PolicyIdentifiers != null &&
                    this.PolicyIdentifiers.SequenceEqual(input.PolicyIdentifiers)
                ) &&
                (
                    this.PostalCode == input.PostalCode ||
                    this.PostalCode != null &&
                    input.PostalCode != null &&
                    this.PostalCode.SequenceEqual(input.PostalCode)
                ) &&
                (
                    this.Province == input.Province ||
                    this.Province != null &&
                    input.Province != null &&
                    this.Province.SequenceEqual(input.Province)
                ) &&
                (
                    this.RequireCn == input.RequireCn ||

                    this.RequireCn.Equals(input.RequireCn)
                ) &&
                (
                    this.ServerFlag == input.ServerFlag ||

                    this.ServerFlag.Equals(input.ServerFlag)
                ) &&
                (
                    this.SignatureBits == input.SignatureBits ||

                    this.SignatureBits.Equals(input.SignatureBits)
                ) &&
                (
                    this.StreetAddress == input.StreetAddress ||
                    this.StreetAddress != null &&
                    input.StreetAddress != null &&
                    this.StreetAddress.SequenceEqual(input.StreetAddress)
                ) &&
                (
                    this.Ttl == input.Ttl ||

                    this.Ttl.Equals(input.Ttl)
                ) &&
                (
                    this.UseCsrCommonName == input.UseCsrCommonName ||

                    this.UseCsrCommonName.Equals(input.UseCsrCommonName)
                ) &&
                (
                    this.UseCsrSans == input.UseCsrSans ||

                    this.UseCsrSans.Equals(input.UseCsrSans)
                ) &&
                (
                    this.UsePss == input.UsePss ||

                    this.UsePss.Equals(input.UsePss)
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


                hashCode = (hashCode * 59) + this.AllowAnyName.GetHashCode();

                hashCode = (hashCode * 59) + this.AllowBareDomains.GetHashCode();

                hashCode = (hashCode * 59) + this.AllowGlobDomains.GetHashCode();

                hashCode = (hashCode * 59) + this.AllowIpSans.GetHashCode();

                hashCode = (hashCode * 59) + this.AllowLocalhost.GetHashCode();

                hashCode = (hashCode * 59) + this.AllowSubdomains.GetHashCode();

                hashCode = (hashCode * 59) + this.AllowWildcardCertificates.GetHashCode();
                if (this.AllowedDomains != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedDomains.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.AllowedDomainsTemplate.GetHashCode();
                if (this.AllowedOtherSans != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedOtherSans.GetHashCode();
                }

                if (this.AllowedSerialNumbers != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedSerialNumbers.GetHashCode();
                }

                if (this.AllowedUriSans != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedUriSans.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.AllowedUriSansTemplate.GetHashCode();
                if (this.Backend != null)
                {
                    hashCode = (hashCode * 59) + this.Backend.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.BasicConstraintsValidForNonCa.GetHashCode();

                hashCode = (hashCode * 59) + this.ClientFlag.GetHashCode();
                if (this.CnValidations != null)
                {
                    hashCode = (hashCode * 59) + this.CnValidations.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.CodeSigningFlag.GetHashCode();
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.EmailProtectionFlag.GetHashCode();

                hashCode = (hashCode * 59) + this.EnforceHostnames.GetHashCode();
                if (this.ExtKeyUsage != null)
                {
                    hashCode = (hashCode * 59) + this.ExtKeyUsage.GetHashCode();
                }

                if (this.ExtKeyUsageOids != null)
                {
                    hashCode = (hashCode * 59) + this.ExtKeyUsageOids.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.GenerateLease.GetHashCode();
                if (this.IssuerRef != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerRef.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.KeyBits.GetHashCode();

                hashCode = (hashCode * 59) + this.KeyType.GetHashCode();
                if (this.KeyUsage != null)
                {
                    hashCode = (hashCode * 59) + this.KeyUsage.GetHashCode();
                }

                if (this.Locality != null)
                {
                    hashCode = (hashCode * 59) + this.Locality.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.MaxTtl.GetHashCode();

                hashCode = (hashCode * 59) + this.NoStore.GetHashCode();
                if (this.NotAfter != null)
                {
                    hashCode = (hashCode * 59) + this.NotAfter.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.NotBeforeDuration.GetHashCode();
                if (this.Organization != null)
                {
                    hashCode = (hashCode * 59) + this.Organization.GetHashCode();
                }

                if (this.Ou != null)
                {
                    hashCode = (hashCode * 59) + this.Ou.GetHashCode();
                }

                if (this.PolicyIdentifiers != null)
                {
                    hashCode = (hashCode * 59) + this.PolicyIdentifiers.GetHashCode();
                }

                if (this.PostalCode != null)
                {
                    hashCode = (hashCode * 59) + this.PostalCode.GetHashCode();
                }

                if (this.Province != null)
                {
                    hashCode = (hashCode * 59) + this.Province.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.RequireCn.GetHashCode();

                hashCode = (hashCode * 59) + this.ServerFlag.GetHashCode();

                hashCode = (hashCode * 59) + this.SignatureBits.GetHashCode();
                if (this.StreetAddress != null)
                {
                    hashCode = (hashCode * 59) + this.StreetAddress.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Ttl.GetHashCode();

                hashCode = (hashCode * 59) + this.UseCsrCommonName.GetHashCode();

                hashCode = (hashCode * 59) + this.UseCsrSans.GetHashCode();

                hashCode = (hashCode * 59) + this.UsePss.GetHashCode();
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
