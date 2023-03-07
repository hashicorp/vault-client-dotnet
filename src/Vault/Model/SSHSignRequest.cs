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
    /// SSHSignRequest
    /// </summary>
    [DataContract(Name = "SSHSignRequest")]
    public partial class SSHSignRequest : IEquatable<SSHSignRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="SSHSignRequest" /> class.
        /// </summary>

        /// <param name="CertType">Type of certificate to be created; either \&quot;user\&quot; or \&quot;host\&quot;. (default to &quot;user&quot;).</param>

        /// <param name="CriticalOptions">Critical options that the certificate should be signed for..</param>

        /// <param name="Extensions">Extensions that the certificate should be signed for..</param>

        /// <param name="KeyId">Key id that the created certificate should have. If not specified, the display name of the token will be used..</param>

        /// <param name="PublicKey">SSH public key that should be signed..</param>

        /// <param name="Ttl">The requested Time To Live for the SSH certificate; sets the expiration date. If not specified the role default, backend default, or system default TTL is used, in that order. Cannot be later than the role max TTL..</param>

        /// <param name="ValidPrincipals">Valid principals, either usernames or hostnames, that the certificate should be signed for..</param>


        public SSHSignRequest(string CertType = "user", Object CriticalOptions = default(Object), Object Extensions = default(Object), string KeyId = default(string), string PublicKey = default(string), int Ttl = default(int), string ValidPrincipals = default(string))
        {

            // use default value if no "CertType" provided
            this.CertType = CertType ?? "user";


            this.CriticalOptions = CriticalOptions;

            this.Extensions = Extensions;

            this.KeyId = KeyId;

            this.PublicKey = PublicKey;

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
        /// Key id that the created certificate should have. If not specified, the display name of the token will be used.
        /// </summary>
        /// <value>Key id that the created certificate should have. If not specified, the display name of the token will be used.</value>
        [DataMember(Name = "key_id", EmitDefaultValue = false)]

        public string KeyId { get; set; }


        /// <summary>
        /// SSH public key that should be signed.
        /// </summary>
        /// <value>SSH public key that should be signed.</value>
        [DataMember(Name = "public_key", EmitDefaultValue = false)]

        public string PublicKey { get; set; }


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
            sb.Append("class SSHSignRequest {\n");
            sb.Append("  CertType: ").Append(CertType).Append("\n");
            sb.Append("  CriticalOptions: ").Append(CriticalOptions).Append("\n");
            sb.Append("  Extensions: ").Append(Extensions).Append("\n");
            sb.Append("  KeyId: ").Append(KeyId).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
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
            return this.Equals(input as SSHSignRequest);
        }

        /// <summary>
        /// Returns true if SSHSignRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SSHSignRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SSHSignRequest input)
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
                    this.KeyId == input.KeyId ||
                    (this.KeyId != null &&
                    this.KeyId.Equals(input.KeyId))

                ) &&
                (
                    this.PublicKey == input.PublicKey ||
                    (this.PublicKey != null &&
                    this.PublicKey.Equals(input.PublicKey))

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

                if (this.KeyId != null)
                {
                    hashCode = (hashCode * 59) + this.KeyId.GetHashCode();
                }

                if (this.PublicKey != null)
                {
                    hashCode = (hashCode * 59) + this.PublicKey.GetHashCode();
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
