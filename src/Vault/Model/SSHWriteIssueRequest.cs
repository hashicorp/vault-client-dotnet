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
    /// SSHWriteIssueRequest
    /// </summary>
    [DataContract(Name = "SSHWriteIssueRequest")]

    public partial class SSHWriteIssueRequest : IEquatable<SSHWriteIssueRequest>, IValidatableObject
    {



















        /// <summary>
        /// Initializes a new instance of the <see cref="SSHWriteIssueRequest" /> class.
        /// </summary>

        /// <param name="CertType">Type of certificate to be created; either \&quot;user\&quot; or \&quot;host\&quot;. (default to &quot;user&quot;).</param>

        /// <param name="CriticalOptions">Critical options that the certificate should be signed for..</param>

        /// <param name="Extensions">Extensions that the certificate should be signed for..</param>

        /// <param name="KeyBits">Specifies the number of bits to use for the generated keys. (default to 0).</param>

        /// <param name="KeyId">Key id that the created certificate should have. If not specified, the display name of the token will be used..</param>

        /// <param name="KeyType">Specifies the desired key type; must be &#x60;rsa&#x60;, &#x60;ed25519&#x60; or &#x60;ec&#x60; (default to &quot;rsa&quot;).</param>

        /// <param name="Ttl">The requested Time To Live for the SSH certificate; sets the expiration date. If not specified the role default, backend default, or system default TTL is used, in that order. Cannot be later than the role max TTL..</param>

        /// <param name="ValidPrincipals">Valid principals, either usernames or hostnames, that the certificate should be signed for..</param>


        public SSHWriteIssueRequest(string CertType = "user", Object CriticalOptions = default(Object), Object Extensions = default(Object), int KeyBits = 0, string KeyId = default(string), string KeyType = "rsa", int Ttl = default(int), string ValidPrincipals = default(string))
        {

            // use default value if no "CertType" provided
            this.CertType = CertType ?? "user";


            this.CriticalOptions = CriticalOptions;

            this.Extensions = Extensions;

            this.KeyBits = KeyBits;

            this.KeyId = KeyId;

            // use default value if no "KeyType" provided
            this.KeyType = KeyType ?? "rsa";


            this.Ttl = Ttl;

            this.ValidPrincipals = ValidPrincipals;

        }

        /// <summary>
        /// Type of certificate to be created; either \&quot;user\&quot; or \&quot;host\&quot;.
        /// </summary>
        /// <value>Type of certificate to be created; either \&quot;user\&quot; or \&quot;host\&quot;.</value>
        [DataMember(Name = "cert_type", EmitDefaultValue = false)]


        public string CertType { get; set; }


        /// <summary>
        /// Critical options that the certificate should be signed for.
        /// </summary>
        /// <value>Critical options that the certificate should be signed for.</value>
        [DataMember(Name = "critical_options", EmitDefaultValue = false)]


        public Object CriticalOptions { get; set; }


        /// <summary>
        /// Extensions that the certificate should be signed for.
        /// </summary>
        /// <value>Extensions that the certificate should be signed for.</value>
        [DataMember(Name = "extensions", EmitDefaultValue = false)]


        public Object Extensions { get; set; }


        /// <summary>
        /// Specifies the number of bits to use for the generated keys.
        /// </summary>
        /// <value>Specifies the number of bits to use for the generated keys.</value>
        [DataMember(Name = "key_bits", EmitDefaultValue = false)]


        public int KeyBits { get; set; }


        /// <summary>
        /// Key id that the created certificate should have. If not specified, the display name of the token will be used.
        /// </summary>
        /// <value>Key id that the created certificate should have. If not specified, the display name of the token will be used.</value>
        [DataMember(Name = "key_id", EmitDefaultValue = false)]


        public string KeyId { get; set; }


        /// <summary>
        /// Specifies the desired key type; must be &#x60;rsa&#x60;, &#x60;ed25519&#x60; or &#x60;ec&#x60;
        /// </summary>
        /// <value>Specifies the desired key type; must be &#x60;rsa&#x60;, &#x60;ed25519&#x60; or &#x60;ec&#x60;</value>
        [DataMember(Name = "key_type", EmitDefaultValue = false)]


        public string KeyType { get; set; }


        /// <summary>
        /// The requested Time To Live for the SSH certificate; sets the expiration date. If not specified the role default, backend default, or system default TTL is used, in that order. Cannot be later than the role max TTL.
        /// </summary>
        /// <value>The requested Time To Live for the SSH certificate; sets the expiration date. If not specified the role default, backend default, or system default TTL is used, in that order. Cannot be later than the role max TTL.</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]


        public int Ttl { get; set; }


        /// <summary>
        /// Valid principals, either usernames or hostnames, that the certificate should be signed for.
        /// </summary>
        /// <value>Valid principals, either usernames or hostnames, that the certificate should be signed for.</value>
        [DataMember(Name = "valid_principals", EmitDefaultValue = false)]


        public string ValidPrincipals { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SSHWriteIssueRequest {\n");
            sb.Append("  CertType: ").Append(CertType).Append("\n");
            sb.Append("  CriticalOptions: ").Append(CriticalOptions).Append("\n");
            sb.Append("  Extensions: ").Append(Extensions).Append("\n");
            sb.Append("  KeyBits: ").Append(KeyBits).Append("\n");
            sb.Append("  KeyId: ").Append(KeyId).Append("\n");
            sb.Append("  KeyType: ").Append(KeyType).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
            sb.Append("  ValidPrincipals: ").Append(ValidPrincipals).Append("\n");
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
            return this.Equals(input as SSHWriteIssueRequest);
        }

        /// <summary>
        /// Returns true if SSHWriteIssueRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SSHWriteIssueRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SSHWriteIssueRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.CertType == input.CertType ||
                    (this.CertType != null &&
                    this.CertType.Equals(input.CertType))

                ) &&
                (
                    this.CriticalOptions == input.CriticalOptions ||
                    (this.CriticalOptions != null &&
                    this.CriticalOptions.Equals(input.CriticalOptions))

                ) &&
                (
                    this.Extensions == input.Extensions ||
                    (this.Extensions != null &&
                    this.Extensions.Equals(input.Extensions))

                ) &&
                (
                    this.KeyBits == input.KeyBits ||

                    this.KeyBits.Equals(input.KeyBits)
                ) &&
                (
                    this.KeyId == input.KeyId ||
                    (this.KeyId != null &&
                    this.KeyId.Equals(input.KeyId))

                ) &&
                (
                    this.KeyType == input.KeyType ||
                    (this.KeyType != null &&
                    this.KeyType.Equals(input.KeyType))

                ) &&
                (
                    this.Ttl == input.Ttl ||

                    this.Ttl.Equals(input.Ttl)
                ) &&
                (
                    this.ValidPrincipals == input.ValidPrincipals ||
                    (this.ValidPrincipals != null &&
                    this.ValidPrincipals.Equals(input.ValidPrincipals))

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

                if (this.CertType != null)
                {
                    hashCode = (hashCode * 59) + this.CertType.GetHashCode();
                }

                if (this.CriticalOptions != null)
                {
                    hashCode = (hashCode * 59) + this.CriticalOptions.GetHashCode();
                }

                if (this.Extensions != null)
                {
                    hashCode = (hashCode * 59) + this.Extensions.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.KeyBits.GetHashCode();
                if (this.KeyId != null)
                {
                    hashCode = (hashCode * 59) + this.KeyId.GetHashCode();
                }

                if (this.KeyType != null)
                {
                    hashCode = (hashCode * 59) + this.KeyType.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
                if (this.ValidPrincipals != null)
                {
                    hashCode = (hashCode * 59) + this.ValidPrincipals.GetHashCode();
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
