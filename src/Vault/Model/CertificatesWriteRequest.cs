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
    /// CertificatesWriteRequest
    /// </summary>
    [DataContract(Name = "CertificatesWriteRequest")]
    public partial class CertificatesWriteRequest : IEquatable<CertificatesWriteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CertificatesWriteRequest" /> class.
        /// </summary>
        /// <param name="allowedCommonNames">A comma-separated list of names. At least one must exist in the Common Name. Supports globbing..</param>
        /// <param name="allowedDnsSans">A comma-separated list of DNS names. At least one must exist in the SANs. Supports globbing..</param>
        /// <param name="allowedEmailSans">A comma-separated list of Email Addresses. At least one must exist in the SANs. Supports globbing..</param>
        /// <param name="allowedMetadataExtensions">A comma-separated string or array of oid extensions. Upon successful authentication, these extensions will be added as metadata if they are present in the certificate. The metadata key will be the string consisting of the oid numbers separated by a dash (-) instead of a dot (.) to allow usage in ACL templates..</param>
        /// <param name="allowedNames">A comma-separated list of names. At least one must exist in either the Common Name or SANs. Supports globbing. This parameter is deprecated, please use allowed_common_names, allowed_dns_sans, allowed_email_sans, allowed_uri_sans..</param>
        /// <param name="allowedOrganizationalUnits">A comma-separated list of Organizational Units names. At least one must exist in the OU field..</param>
        /// <param name="allowedUriSans">A comma-separated list of URIs. At least one must exist in the SANs. Supports globbing..</param>
        /// <param name="boundCidrs">Use \&quot;token_bound_cidrs\&quot; instead. If this and \&quot;token_bound_cidrs\&quot; are both specified, only \&quot;token_bound_cidrs\&quot; will be used..</param>
        /// <param name="certificate">The public certificate that should be trusted. Must be x509 PEM encoded..</param>
        /// <param name="displayName">The display name to use for clients using this certificate..</param>
        /// <param name="lease">Use \&quot;token_ttl\&quot; instead. If this and \&quot;token_ttl\&quot; are both specified, only \&quot;token_ttl\&quot; will be used..</param>
        /// <param name="maxTtl">Use \&quot;token_max_ttl\&quot; instead. If this and \&quot;token_max_ttl\&quot; are both specified, only \&quot;token_max_ttl\&quot; will be used..</param>
        /// <param name="ocspCaCertificates">Any additional CA certificates needed to communicate with OCSP servers.</param>
        /// <param name="ocspEnabled">Whether to attempt OCSP verification of certificates at login.</param>
        /// <param name="ocspFailOpen">If set to true, if an OCSP revocation cannot be made successfully, login will proceed rather than failing. If false, failing to get an OCSP status fails the request. (default to false).</param>
        /// <param name="ocspQueryAllServers">If set to true, rather than accepting the first successful OCSP response, query all servers and consider the certificate valid only if all servers agree. (default to false).</param>
        /// <param name="ocspServersOverride">A comma-separated list of OCSP server addresses. If unset, the OCSP server is determined from the AuthorityInformationAccess extension on the certificate being inspected..</param>
        /// <param name="period">Use \&quot;token_period\&quot; instead. If this and \&quot;token_period\&quot; are both specified, only \&quot;token_period\&quot; will be used..</param>
        /// <param name="policies">Use \&quot;token_policies\&quot; instead. If this and \&quot;token_policies\&quot; are both specified, only \&quot;token_policies\&quot; will be used..</param>
        /// <param name="requiredExtensions">A comma-separated string or array of extensions formatted as \&quot;oid:value\&quot;. Expects the extension value to be some type of ASN1 encoded string. All values much match. Supports globbing on \&quot;value\&quot;..</param>
        /// <param name="tokenBoundCidrs">Comma separated string or JSON list of CIDR blocks. If set, specifies the blocks of IP addresses which are allowed to use the generated token..</param>
        /// <param name="tokenExplicitMaxTtl">If set, tokens created via this role carry an explicit maximum TTL. During renewal, the current maximum TTL values of the role and the mount are not checked for changes, and any updates to these values will have no effect on the token being renewed..</param>
        /// <param name="tokenMaxTtl">The maximum lifetime of the generated token.</param>
        /// <param name="tokenNoDefaultPolicy">If true, the &#39;default&#39; policy will not automatically be added to generated tokens.</param>
        /// <param name="tokenNumUses">The maximum number of times a token may be used, a value of zero means unlimited.</param>
        /// <param name="tokenPeriod">If set, tokens created via this role will have no max lifetime; instead, their renewal period will be fixed to this value. This takes an integer number of seconds, or a string duration (e.g. \&quot;24h\&quot;)..</param>
        /// <param name="tokenPolicies">Comma-separated list of policies.</param>
        /// <param name="tokenTtl">The initial ttl of the token to generate.</param>
        /// <param name="tokenType">The type of token to generate, service or batch (default to &quot;default-service&quot;).</param>
        /// <param name="ttl">Use \&quot;token_ttl\&quot; instead. If this and \&quot;token_ttl\&quot; are both specified, only \&quot;token_ttl\&quot; will be used..</param>
        public CertificatesWriteRequest(List<string> allowedCommonNames = default(List<string>), List<string> allowedDnsSans = default(List<string>), List<string> allowedEmailSans = default(List<string>), List<string> allowedMetadataExtensions = default(List<string>), List<string> allowedNames = default(List<string>), List<string> allowedOrganizationalUnits = default(List<string>), List<string> allowedUriSans = default(List<string>), List<string> boundCidrs = default(List<string>), string certificate = default(string), string displayName = default(string), int lease = default(int), int maxTtl = default(int), string ocspCaCertificates = default(string), bool ocspEnabled = default(bool), bool ocspFailOpen = false, bool ocspQueryAllServers = false, List<string> ocspServersOverride = default(List<string>), int period = default(int), List<string> policies = default(List<string>), List<string> requiredExtensions = default(List<string>), List<string> tokenBoundCidrs = default(List<string>), int tokenExplicitMaxTtl = default(int), int tokenMaxTtl = default(int), bool tokenNoDefaultPolicy = default(bool), int tokenNumUses = default(int), int tokenPeriod = default(int), List<string> tokenPolicies = default(List<string>), int tokenTtl = default(int), string tokenType = "default-service", int ttl = default(int))
        {
            this.AllowedCommonNames = allowedCommonNames;
            this.AllowedDnsSans = allowedDnsSans;
            this.AllowedEmailSans = allowedEmailSans;
            this.AllowedMetadataExtensions = allowedMetadataExtensions;
            this.AllowedNames = allowedNames;
            this.AllowedOrganizationalUnits = allowedOrganizationalUnits;
            this.AllowedUriSans = allowedUriSans;
            this.BoundCidrs = boundCidrs;
            this.Certificate = certificate;
            this.DisplayName = displayName;
            this.Lease = lease;
            this.MaxTtl = maxTtl;
            this.OcspCaCertificates = ocspCaCertificates;
            this.OcspEnabled = ocspEnabled;
            this.OcspFailOpen = ocspFailOpen;
            this.OcspQueryAllServers = ocspQueryAllServers;
            this.OcspServersOverride = ocspServersOverride;
            this.Period = period;
            this.Policies = policies;
            this.RequiredExtensions = requiredExtensions;
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
            this.Ttl = ttl;
        }

        /// <summary>
        /// A comma-separated list of names. At least one must exist in the Common Name. Supports globbing.
        /// </summary>
        /// <value>A comma-separated list of names. At least one must exist in the Common Name. Supports globbing.</value>
        [DataMember(Name = "allowed_common_names", EmitDefaultValue = false)]
        public List<string> AllowedCommonNames { get; set; }

        /// <summary>
        /// A comma-separated list of DNS names. At least one must exist in the SANs. Supports globbing.
        /// </summary>
        /// <value>A comma-separated list of DNS names. At least one must exist in the SANs. Supports globbing.</value>
        [DataMember(Name = "allowed_dns_sans", EmitDefaultValue = false)]
        public List<string> AllowedDnsSans { get; set; }

        /// <summary>
        /// A comma-separated list of Email Addresses. At least one must exist in the SANs. Supports globbing.
        /// </summary>
        /// <value>A comma-separated list of Email Addresses. At least one must exist in the SANs. Supports globbing.</value>
        [DataMember(Name = "allowed_email_sans", EmitDefaultValue = false)]
        public List<string> AllowedEmailSans { get; set; }

        /// <summary>
        /// A comma-separated string or array of oid extensions. Upon successful authentication, these extensions will be added as metadata if they are present in the certificate. The metadata key will be the string consisting of the oid numbers separated by a dash (-) instead of a dot (.) to allow usage in ACL templates.
        /// </summary>
        /// <value>A comma-separated string or array of oid extensions. Upon successful authentication, these extensions will be added as metadata if they are present in the certificate. The metadata key will be the string consisting of the oid numbers separated by a dash (-) instead of a dot (.) to allow usage in ACL templates.</value>
        [DataMember(Name = "allowed_metadata_extensions", EmitDefaultValue = false)]
        public List<string> AllowedMetadataExtensions { get; set; }

        /// <summary>
        /// A comma-separated list of names. At least one must exist in either the Common Name or SANs. Supports globbing. This parameter is deprecated, please use allowed_common_names, allowed_dns_sans, allowed_email_sans, allowed_uri_sans.
        /// </summary>
        /// <value>A comma-separated list of names. At least one must exist in either the Common Name or SANs. Supports globbing. This parameter is deprecated, please use allowed_common_names, allowed_dns_sans, allowed_email_sans, allowed_uri_sans.</value>
        [DataMember(Name = "allowed_names", EmitDefaultValue = false)]
        public List<string> AllowedNames { get; set; }

        /// <summary>
        /// A comma-separated list of Organizational Units names. At least one must exist in the OU field.
        /// </summary>
        /// <value>A comma-separated list of Organizational Units names. At least one must exist in the OU field.</value>
        [DataMember(Name = "allowed_organizational_units", EmitDefaultValue = false)]
        public List<string> AllowedOrganizationalUnits { get; set; }

        /// <summary>
        /// A comma-separated list of URIs. At least one must exist in the SANs. Supports globbing.
        /// </summary>
        /// <value>A comma-separated list of URIs. At least one must exist in the SANs. Supports globbing.</value>
        [DataMember(Name = "allowed_uri_sans", EmitDefaultValue = false)]
        public List<string> AllowedUriSans { get; set; }

        /// <summary>
        /// Use \&quot;token_bound_cidrs\&quot; instead. If this and \&quot;token_bound_cidrs\&quot; are both specified, only \&quot;token_bound_cidrs\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_bound_cidrs\&quot; instead. If this and \&quot;token_bound_cidrs\&quot; are both specified, only \&quot;token_bound_cidrs\&quot; will be used.</value>
        [DataMember(Name = "bound_cidrs", EmitDefaultValue = false)]
        [Obsolete]
        public List<string> BoundCidrs { get; set; }

        /// <summary>
        /// The public certificate that should be trusted. Must be x509 PEM encoded.
        /// </summary>
        /// <value>The public certificate that should be trusted. Must be x509 PEM encoded.</value>
        [DataMember(Name = "certificate", EmitDefaultValue = false)]
        public string Certificate { get; set; }

        /// <summary>
        /// The display name to use for clients using this certificate.
        /// </summary>
        /// <value>The display name to use for clients using this certificate.</value>
        [DataMember(Name = "display_name", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Use \&quot;token_ttl\&quot; instead. If this and \&quot;token_ttl\&quot; are both specified, only \&quot;token_ttl\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_ttl\&quot; instead. If this and \&quot;token_ttl\&quot; are both specified, only \&quot;token_ttl\&quot; will be used.</value>
        [DataMember(Name = "lease", EmitDefaultValue = false)]
        [Obsolete]
        public int Lease { get; set; }

        /// <summary>
        /// Use \&quot;token_max_ttl\&quot; instead. If this and \&quot;token_max_ttl\&quot; are both specified, only \&quot;token_max_ttl\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_max_ttl\&quot; instead. If this and \&quot;token_max_ttl\&quot; are both specified, only \&quot;token_max_ttl\&quot; will be used.</value>
        [DataMember(Name = "max_ttl", EmitDefaultValue = false)]
        [Obsolete]
        public int MaxTtl { get; set; }

        /// <summary>
        /// Any additional CA certificates needed to communicate with OCSP servers
        /// </summary>
        /// <value>Any additional CA certificates needed to communicate with OCSP servers</value>
        [DataMember(Name = "ocsp_ca_certificates", EmitDefaultValue = false)]
        public string OcspCaCertificates { get; set; }

        /// <summary>
        /// Whether to attempt OCSP verification of certificates at login
        /// </summary>
        /// <value>Whether to attempt OCSP verification of certificates at login</value>
        [DataMember(Name = "ocsp_enabled", EmitDefaultValue = true)]
        public bool OcspEnabled { get; set; }

        /// <summary>
        /// If set to true, if an OCSP revocation cannot be made successfully, login will proceed rather than failing. If false, failing to get an OCSP status fails the request.
        /// </summary>
        /// <value>If set to true, if an OCSP revocation cannot be made successfully, login will proceed rather than failing. If false, failing to get an OCSP status fails the request.</value>
        [DataMember(Name = "ocsp_fail_open", EmitDefaultValue = true)]
        public bool OcspFailOpen { get; set; }

        /// <summary>
        /// If set to true, rather than accepting the first successful OCSP response, query all servers and consider the certificate valid only if all servers agree.
        /// </summary>
        /// <value>If set to true, rather than accepting the first successful OCSP response, query all servers and consider the certificate valid only if all servers agree.</value>
        [DataMember(Name = "ocsp_query_all_servers", EmitDefaultValue = true)]
        public bool OcspQueryAllServers { get; set; }

        /// <summary>
        /// A comma-separated list of OCSP server addresses. If unset, the OCSP server is determined from the AuthorityInformationAccess extension on the certificate being inspected.
        /// </summary>
        /// <value>A comma-separated list of OCSP server addresses. If unset, the OCSP server is determined from the AuthorityInformationAccess extension on the certificate being inspected.</value>
        [DataMember(Name = "ocsp_servers_override", EmitDefaultValue = false)]
        public List<string> OcspServersOverride { get; set; }

        /// <summary>
        /// Use \&quot;token_period\&quot; instead. If this and \&quot;token_period\&quot; are both specified, only \&quot;token_period\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_period\&quot; instead. If this and \&quot;token_period\&quot; are both specified, only \&quot;token_period\&quot; will be used.</value>
        [DataMember(Name = "period", EmitDefaultValue = false)]
        [Obsolete]
        public int Period { get; set; }

        /// <summary>
        /// Use \&quot;token_policies\&quot; instead. If this and \&quot;token_policies\&quot; are both specified, only \&quot;token_policies\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_policies\&quot; instead. If this and \&quot;token_policies\&quot; are both specified, only \&quot;token_policies\&quot; will be used.</value>
        [DataMember(Name = "policies", EmitDefaultValue = false)]
        [Obsolete]
        public List<string> Policies { get; set; }

        /// <summary>
        /// A comma-separated string or array of extensions formatted as \&quot;oid:value\&quot;. Expects the extension value to be some type of ASN1 encoded string. All values much match. Supports globbing on \&quot;value\&quot;.
        /// </summary>
        /// <value>A comma-separated string or array of extensions formatted as \&quot;oid:value\&quot;. Expects the extension value to be some type of ASN1 encoded string. All values much match. Supports globbing on \&quot;value\&quot;.</value>
        [DataMember(Name = "required_extensions", EmitDefaultValue = false)]
        public List<string> RequiredExtensions { get; set; }

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
        /// Comma-separated list of policies
        /// </summary>
        /// <value>Comma-separated list of policies</value>
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
        /// Use \&quot;token_ttl\&quot; instead. If this and \&quot;token_ttl\&quot; are both specified, only \&quot;token_ttl\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_ttl\&quot; instead. If this and \&quot;token_ttl\&quot; are both specified, only \&quot;token_ttl\&quot; will be used.</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]
        [Obsolete]
        public int Ttl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CertificatesWriteRequest {\n");
            sb.Append("  AllowedCommonNames: ").Append(AllowedCommonNames).Append("\n");
            sb.Append("  AllowedDnsSans: ").Append(AllowedDnsSans).Append("\n");
            sb.Append("  AllowedEmailSans: ").Append(AllowedEmailSans).Append("\n");
            sb.Append("  AllowedMetadataExtensions: ").Append(AllowedMetadataExtensions).Append("\n");
            sb.Append("  AllowedNames: ").Append(AllowedNames).Append("\n");
            sb.Append("  AllowedOrganizationalUnits: ").Append(AllowedOrganizationalUnits).Append("\n");
            sb.Append("  AllowedUriSans: ").Append(AllowedUriSans).Append("\n");
            sb.Append("  BoundCidrs: ").Append(BoundCidrs).Append("\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Lease: ").Append(Lease).Append("\n");
            sb.Append("  MaxTtl: ").Append(MaxTtl).Append("\n");
            sb.Append("  OcspCaCertificates: ").Append(OcspCaCertificates).Append("\n");
            sb.Append("  OcspEnabled: ").Append(OcspEnabled).Append("\n");
            sb.Append("  OcspFailOpen: ").Append(OcspFailOpen).Append("\n");
            sb.Append("  OcspQueryAllServers: ").Append(OcspQueryAllServers).Append("\n");
            sb.Append("  OcspServersOverride: ").Append(OcspServersOverride).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
            sb.Append("  RequiredExtensions: ").Append(RequiredExtensions).Append("\n");
            sb.Append("  TokenBoundCidrs: ").Append(TokenBoundCidrs).Append("\n");
            sb.Append("  TokenExplicitMaxTtl: ").Append(TokenExplicitMaxTtl).Append("\n");
            sb.Append("  TokenMaxTtl: ").Append(TokenMaxTtl).Append("\n");
            sb.Append("  TokenNoDefaultPolicy: ").Append(TokenNoDefaultPolicy).Append("\n");
            sb.Append("  TokenNumUses: ").Append(TokenNumUses).Append("\n");
            sb.Append("  TokenPeriod: ").Append(TokenPeriod).Append("\n");
            sb.Append("  TokenPolicies: ").Append(TokenPolicies).Append("\n");
            sb.Append("  TokenTtl: ").Append(TokenTtl).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
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
            return this.Equals(input as CertificatesWriteRequest);
        }

        /// <summary>
        /// Returns true if CertificatesWriteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CertificatesWriteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CertificatesWriteRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AllowedCommonNames == input.AllowedCommonNames ||
                    this.AllowedCommonNames != null &&
                    input.AllowedCommonNames != null &&
                    this.AllowedCommonNames.SequenceEqual(input.AllowedCommonNames)
                ) && 
                (
                    this.AllowedDnsSans == input.AllowedDnsSans ||
                    this.AllowedDnsSans != null &&
                    input.AllowedDnsSans != null &&
                    this.AllowedDnsSans.SequenceEqual(input.AllowedDnsSans)
                ) && 
                (
                    this.AllowedEmailSans == input.AllowedEmailSans ||
                    this.AllowedEmailSans != null &&
                    input.AllowedEmailSans != null &&
                    this.AllowedEmailSans.SequenceEqual(input.AllowedEmailSans)
                ) && 
                (
                    this.AllowedMetadataExtensions == input.AllowedMetadataExtensions ||
                    this.AllowedMetadataExtensions != null &&
                    input.AllowedMetadataExtensions != null &&
                    this.AllowedMetadataExtensions.SequenceEqual(input.AllowedMetadataExtensions)
                ) && 
                (
                    this.AllowedNames == input.AllowedNames ||
                    this.AllowedNames != null &&
                    input.AllowedNames != null &&
                    this.AllowedNames.SequenceEqual(input.AllowedNames)
                ) && 
                (
                    this.AllowedOrganizationalUnits == input.AllowedOrganizationalUnits ||
                    this.AllowedOrganizationalUnits != null &&
                    input.AllowedOrganizationalUnits != null &&
                    this.AllowedOrganizationalUnits.SequenceEqual(input.AllowedOrganizationalUnits)
                ) && 
                (
                    this.AllowedUriSans == input.AllowedUriSans ||
                    this.AllowedUriSans != null &&
                    input.AllowedUriSans != null &&
                    this.AllowedUriSans.SequenceEqual(input.AllowedUriSans)
                ) && 
                (
                    this.BoundCidrs == input.BoundCidrs ||
                    this.BoundCidrs != null &&
                    input.BoundCidrs != null &&
                    this.BoundCidrs.SequenceEqual(input.BoundCidrs)
                ) && 
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Lease == input.Lease ||
                    this.Lease.Equals(input.Lease)
                ) && 
                (
                    this.MaxTtl == input.MaxTtl ||
                    this.MaxTtl.Equals(input.MaxTtl)
                ) && 
                (
                    this.OcspCaCertificates == input.OcspCaCertificates ||
                    (this.OcspCaCertificates != null &&
                    this.OcspCaCertificates.Equals(input.OcspCaCertificates))
                ) && 
                (
                    this.OcspEnabled == input.OcspEnabled ||
                    this.OcspEnabled.Equals(input.OcspEnabled)
                ) && 
                (
                    this.OcspFailOpen == input.OcspFailOpen ||
                    this.OcspFailOpen.Equals(input.OcspFailOpen)
                ) && 
                (
                    this.OcspQueryAllServers == input.OcspQueryAllServers ||
                    this.OcspQueryAllServers.Equals(input.OcspQueryAllServers)
                ) && 
                (
                    this.OcspServersOverride == input.OcspServersOverride ||
                    this.OcspServersOverride != null &&
                    input.OcspServersOverride != null &&
                    this.OcspServersOverride.SequenceEqual(input.OcspServersOverride)
                ) && 
                (
                    this.Period == input.Period ||
                    this.Period.Equals(input.Period)
                ) && 
                (
                    this.Policies == input.Policies ||
                    this.Policies != null &&
                    input.Policies != null &&
                    this.Policies.SequenceEqual(input.Policies)
                ) && 
                (
                    this.RequiredExtensions == input.RequiredExtensions ||
                    this.RequiredExtensions != null &&
                    input.RequiredExtensions != null &&
                    this.RequiredExtensions.SequenceEqual(input.RequiredExtensions)
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
                    this.Ttl == input.Ttl ||
                    this.Ttl.Equals(input.Ttl)
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
                if (this.AllowedCommonNames != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedCommonNames.GetHashCode();
                }
                if (this.AllowedDnsSans != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedDnsSans.GetHashCode();
                }
                if (this.AllowedEmailSans != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedEmailSans.GetHashCode();
                }
                if (this.AllowedMetadataExtensions != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedMetadataExtensions.GetHashCode();
                }
                if (this.AllowedNames != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedNames.GetHashCode();
                }
                if (this.AllowedOrganizationalUnits != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedOrganizationalUnits.GetHashCode();
                }
                if (this.AllowedUriSans != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedUriSans.GetHashCode();
                }
                if (this.BoundCidrs != null)
                {
                    hashCode = (hashCode * 59) + this.BoundCidrs.GetHashCode();
                }
                if (this.Certificate != null)
                {
                    hashCode = (hashCode * 59) + this.Certificate.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Lease.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxTtl.GetHashCode();
                if (this.OcspCaCertificates != null)
                {
                    hashCode = (hashCode * 59) + this.OcspCaCertificates.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OcspEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.OcspFailOpen.GetHashCode();
                hashCode = (hashCode * 59) + this.OcspQueryAllServers.GetHashCode();
                if (this.OcspServersOverride != null)
                {
                    hashCode = (hashCode * 59) + this.OcspServersOverride.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Period.GetHashCode();
                if (this.Policies != null)
                {
                    hashCode = (hashCode * 59) + this.Policies.GetHashCode();
                }
                if (this.RequiredExtensions != null)
                {
                    hashCode = (hashCode * 59) + this.RequiredExtensions.GetHashCode();
                }
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
                hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
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
