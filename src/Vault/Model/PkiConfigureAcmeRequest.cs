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
    /// PkiConfigureAcmeRequest
    /// </summary>
    [DataContract(Name = "PkiConfigureAcmeRequest")]
    public partial class PkiConfigureAcmeRequest : IEquatable<PkiConfigureAcmeRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PkiConfigureAcmeRequest" /> class.
        /// </summary>

        /// <param name="AllowRoleExtKeyUsage">whether the ExtKeyUsage field from a role is used, defaults to false meaning that certificate will be signed with ServerAuth. (default to false).</param>

        /// <param name="AllowedIssuers">which issuers are allowed for use with ACME; by default, this will only be the primary (default) issuer.</param>

        /// <param name="AllowedRoles">which roles are allowed for use with ACME; by default via &#x27;*&#x27;, these will be all roles including sign-verbatim; when concrete role names are specified, any default_directory_policy role must be included to allow usage of the default acme directories under /pki/acme/directory and /pki/issuer/:issuer_id/acme/directory..</param>

        /// <param name="DefaultDirectoryPolicy">the policy to be used for non-role-qualified ACME requests; by default ACME issuance will be otherwise unrestricted, equivalent to the sign-verbatim endpoint; one may also specify a role to use as this policy, as \&quot;role:&lt;role_name&gt;\&quot;, the specified role must be allowed by allowed_roles (default to &quot;sign-verbatim&quot;).</param>

        /// <param name="DnsResolver">DNS resolver to use for domain resolution on this mount. Defaults to using the default system resolver. Must be in the format &lt;host&gt;:&lt;port&gt;, with both parts mandatory. (default to &quot;&quot;).</param>

        /// <param name="EabPolicy">Specify the policy to use for external account binding behaviour, &#x27;not-required&#x27;, &#x27;new-account-required&#x27; or &#x27;always-required&#x27; (default to &quot;always-required&quot;).</param>

        /// <param name="Enabled">whether ACME is enabled, defaults to false meaning that clusters will by default not get ACME support (default to false).</param>


        public PkiConfigureAcmeRequest(bool AllowRoleExtKeyUsage = false, List<string> AllowedIssuers = default(List<string>), List<string> AllowedRoles = default(List<string>), string DefaultDirectoryPolicy = "sign-verbatim", string DnsResolver = "", string EabPolicy = "always-required", bool Enabled = false)
        {

            this.AllowRoleExtKeyUsage = AllowRoleExtKeyUsage;

            this.AllowedIssuers = AllowedIssuers;

            this.AllowedRoles = AllowedRoles;

            // use default value if no "DefaultDirectoryPolicy" provided
            this.DefaultDirectoryPolicy = DefaultDirectoryPolicy ?? "sign-verbatim";


            // use default value if no "DnsResolver" provided
            this.DnsResolver = DnsResolver ?? "";


            // use default value if no "EabPolicy" provided
            this.EabPolicy = EabPolicy ?? "always-required";


            this.Enabled = Enabled;

        }

        /// <summary>
        /// whether the ExtKeyUsage field from a role is used, defaults to false meaning that certificate will be signed with ServerAuth.
        /// </summary>
        /// <value>whether the ExtKeyUsage field from a role is used, defaults to false meaning that certificate will be signed with ServerAuth.</value>
        [DataMember(Name = "allow_role_ext_key_usage", EmitDefaultValue = true)]

        public bool AllowRoleExtKeyUsage { get; set; }


        /// <summary>
        /// which issuers are allowed for use with ACME; by default, this will only be the primary (default) issuer
        /// </summary>
        /// <value>which issuers are allowed for use with ACME; by default, this will only be the primary (default) issuer</value>
        [DataMember(Name = "allowed_issuers", EmitDefaultValue = false)]

        public List<string> AllowedIssuers { get; set; }


        /// <summary>
        /// which roles are allowed for use with ACME; by default via &#x27;*&#x27;, these will be all roles including sign-verbatim; when concrete role names are specified, any default_directory_policy role must be included to allow usage of the default acme directories under /pki/acme/directory and /pki/issuer/:issuer_id/acme/directory.
        /// </summary>
        /// <value>which roles are allowed for use with ACME; by default via &#x27;*&#x27;, these will be all roles including sign-verbatim; when concrete role names are specified, any default_directory_policy role must be included to allow usage of the default acme directories under /pki/acme/directory and /pki/issuer/:issuer_id/acme/directory.</value>
        [DataMember(Name = "allowed_roles", EmitDefaultValue = false)]

        public List<string> AllowedRoles { get; set; }


        /// <summary>
        /// the policy to be used for non-role-qualified ACME requests; by default ACME issuance will be otherwise unrestricted, equivalent to the sign-verbatim endpoint; one may also specify a role to use as this policy, as \&quot;role:&lt;role_name&gt;\&quot;, the specified role must be allowed by allowed_roles
        /// </summary>
        /// <value>the policy to be used for non-role-qualified ACME requests; by default ACME issuance will be otherwise unrestricted, equivalent to the sign-verbatim endpoint; one may also specify a role to use as this policy, as \&quot;role:&lt;role_name&gt;\&quot;, the specified role must be allowed by allowed_roles</value>
        [DataMember(Name = "default_directory_policy", EmitDefaultValue = false)]

        public string DefaultDirectoryPolicy { get; set; }


        /// <summary>
        /// DNS resolver to use for domain resolution on this mount. Defaults to using the default system resolver. Must be in the format &lt;host&gt;:&lt;port&gt;, with both parts mandatory.
        /// </summary>
        /// <value>DNS resolver to use for domain resolution on this mount. Defaults to using the default system resolver. Must be in the format &lt;host&gt;:&lt;port&gt;, with both parts mandatory.</value>
        [DataMember(Name = "dns_resolver", EmitDefaultValue = false)]

        public string DnsResolver { get; set; }


        /// <summary>
        /// Specify the policy to use for external account binding behaviour, &#x27;not-required&#x27;, &#x27;new-account-required&#x27; or &#x27;always-required&#x27;
        /// </summary>
        /// <value>Specify the policy to use for external account binding behaviour, &#x27;not-required&#x27;, &#x27;new-account-required&#x27; or &#x27;always-required&#x27;</value>
        [DataMember(Name = "eab_policy", EmitDefaultValue = false)]

        public string EabPolicy { get; set; }


        /// <summary>
        /// whether ACME is enabled, defaults to false meaning that clusters will by default not get ACME support
        /// </summary>
        /// <value>whether ACME is enabled, defaults to false meaning that clusters will by default not get ACME support</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]

        public bool Enabled { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiConfigureAcmeRequest {\n");
            sb.Append("  AllowRoleExtKeyUsage: ").Append(AllowRoleExtKeyUsage).Append("\n");
            sb.Append("  AllowedIssuers: ").Append(AllowedIssuers).Append("\n");
            sb.Append("  AllowedRoles: ").Append(AllowedRoles).Append("\n");
            sb.Append("  DefaultDirectoryPolicy: ").Append(DefaultDirectoryPolicy).Append("\n");
            sb.Append("  DnsResolver: ").Append(DnsResolver).Append("\n");
            sb.Append("  EabPolicy: ").Append(EabPolicy).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(input as PkiConfigureAcmeRequest);
        }

        /// <summary>
        /// Returns true if PkiConfigureAcmeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiConfigureAcmeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiConfigureAcmeRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AllowRoleExtKeyUsage == input.AllowRoleExtKeyUsage ||

                    this.AllowRoleExtKeyUsage.Equals(input.AllowRoleExtKeyUsage)
                ) &&
                (
                    this.AllowedIssuers == input.AllowedIssuers ||
                    this.AllowedIssuers != null &&
                    input.AllowedIssuers != null &&
                    this.AllowedIssuers.SequenceEqual(input.AllowedIssuers)
                ) &&
                (
                    this.AllowedRoles == input.AllowedRoles ||
                    this.AllowedRoles != null &&
                    input.AllowedRoles != null &&
                    this.AllowedRoles.SequenceEqual(input.AllowedRoles)
                ) &&
                (
                    this.DefaultDirectoryPolicy == input.DefaultDirectoryPolicy ||
                    (this.DefaultDirectoryPolicy != null &&
                    this.DefaultDirectoryPolicy.Equals(input.DefaultDirectoryPolicy))

                ) &&
                (
                    this.DnsResolver == input.DnsResolver ||
                    (this.DnsResolver != null &&
                    this.DnsResolver.Equals(input.DnsResolver))

                ) &&
                (
                    this.EabPolicy == input.EabPolicy ||
                    (this.EabPolicy != null &&
                    this.EabPolicy.Equals(input.EabPolicy))

                ) &&
                (
                    this.Enabled == input.Enabled ||

                    this.Enabled.Equals(input.Enabled)
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


                hashCode = (hashCode * 59) + this.AllowRoleExtKeyUsage.GetHashCode();
                if (this.AllowedIssuers != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedIssuers.GetHashCode();
                }

                if (this.AllowedRoles != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedRoles.GetHashCode();
                }

                if (this.DefaultDirectoryPolicy != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultDirectoryPolicy.GetHashCode();
                }

                if (this.DnsResolver != null)
                {
                    hashCode = (hashCode * 59) + this.DnsResolver.GetHashCode();
                }

                if (this.EabPolicy != null)
                {
                    hashCode = (hashCode * 59) + this.EabPolicy.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
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
