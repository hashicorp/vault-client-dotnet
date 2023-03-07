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
    /// CloudFoundryWriteConfigRequest
    /// </summary>
    [DataContract(Name = "CloudFoundryWriteConfigRequest")]
    public partial class CloudFoundryWriteConfigRequest : IEquatable<CloudFoundryWriteConfigRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="CloudFoundryWriteConfigRequest" /> class.
        /// </summary>

        /// <param name="CfApiAddr">CF’s API address..</param>

        /// <param name="CfApiMutualTlsCertificate">The PEM-format certificates that are presented for mutual TLS with the CloudFoundry API. If not set, mutual TLS is not used.</param>

        /// <param name="CfApiMutualTlsKey">The PEM-format private key that are used for mutual TLS with the CloudFoundry API. If not set, mutual TLS is not used.</param>

        /// <param name="CfApiTrustedCertificates">The PEM-format CA certificates that are acceptable for the CF API to present..</param>

        /// <param name="CfClientId">The client id for CF’s API..</param>

        /// <param name="CfClientSecret">The client secret for CF’s API..</param>

        /// <param name="CfPassword">The password for CF’s API..</param>

        /// <param name="CfUsername">The username for CF’s API..</param>

        /// <param name="IdentityCaCertificates">The PEM-format CA certificates that are required to have issued the instance certificates presented for logging in..</param>

        /// <param name="LoginMaxSecondsNotAfter">Duration in seconds for the maximum acceptable length in the future a \&quot;signing_time\&quot; can be. Useful for clock drift. Set low to reduce the opportunity for replay attacks. (default to 60).</param>

        /// <param name="LoginMaxSecondsNotBefore">Duration in seconds for the maximum acceptable age of a \&quot;signing_time\&quot;. Useful for clock drift. Set low to reduce the opportunity for replay attacks. (default to 300).</param>

        /// <param name="PcfApiAddr">Deprecated. Please use \&quot;cf_api_addr\&quot;..</param>

        /// <param name="PcfApiTrustedCertificates">Deprecated. Please use \&quot;cf_api_trusted_certificates\&quot;..</param>

        /// <param name="PcfPassword">Deprecated. Please use \&quot;cf_password\&quot;..</param>

        /// <param name="PcfUsername">Deprecated. Please use \&quot;cf_username\&quot;..</param>


        public CloudFoundryWriteConfigRequest(string CfApiAddr = default(string), string CfApiMutualTlsCertificate = default(string), string CfApiMutualTlsKey = default(string), List<string> CfApiTrustedCertificates = default(List<string>), string CfClientId = default(string), string CfClientSecret = default(string), string CfPassword = default(string), string CfUsername = default(string), List<string> IdentityCaCertificates = default(List<string>), int LoginMaxSecondsNotAfter = 60, int LoginMaxSecondsNotBefore = 300, string PcfApiAddr = default(string), List<string> PcfApiTrustedCertificates = default(List<string>), string PcfPassword = default(string), string PcfUsername = default(string))
        {

            this.CfApiAddr = CfApiAddr;

            this.CfApiMutualTlsCertificate = CfApiMutualTlsCertificate;

            this.CfApiMutualTlsKey = CfApiMutualTlsKey;

            this.CfApiTrustedCertificates = CfApiTrustedCertificates;

            this.CfClientId = CfClientId;

            this.CfClientSecret = CfClientSecret;

            this.CfPassword = CfPassword;

            this.CfUsername = CfUsername;

            this.IdentityCaCertificates = IdentityCaCertificates;

            this.LoginMaxSecondsNotAfter = LoginMaxSecondsNotAfter;

            this.LoginMaxSecondsNotBefore = LoginMaxSecondsNotBefore;

            this.PcfApiAddr = PcfApiAddr;

            this.PcfApiTrustedCertificates = PcfApiTrustedCertificates;

            this.PcfPassword = PcfPassword;

            this.PcfUsername = PcfUsername;

        }

        /// <summary>
        /// CF’s API address.
        /// </summary>
        /// <value>CF’s API address.</value>
        [DataMember(Name = "cf_api_addr", EmitDefaultValue = false)]

        public string CfApiAddr { get; set; }


        /// <summary>
        /// The PEM-format certificates that are presented for mutual TLS with the CloudFoundry API. If not set, mutual TLS is not used
        /// </summary>
        /// <value>The PEM-format certificates that are presented for mutual TLS with the CloudFoundry API. If not set, mutual TLS is not used</value>
        [DataMember(Name = "cf_api_mutual_tls_certificate", EmitDefaultValue = false)]

        public string CfApiMutualTlsCertificate { get; set; }


        /// <summary>
        /// The PEM-format private key that are used for mutual TLS with the CloudFoundry API. If not set, mutual TLS is not used
        /// </summary>
        /// <value>The PEM-format private key that are used for mutual TLS with the CloudFoundry API. If not set, mutual TLS is not used</value>
        [DataMember(Name = "cf_api_mutual_tls_key", EmitDefaultValue = false)]

        public string CfApiMutualTlsKey { get; set; }


        /// <summary>
        /// The PEM-format CA certificates that are acceptable for the CF API to present.
        /// </summary>
        /// <value>The PEM-format CA certificates that are acceptable for the CF API to present.</value>
        [DataMember(Name = "cf_api_trusted_certificates", EmitDefaultValue = false)]

        public List<string> CfApiTrustedCertificates { get; set; }


        /// <summary>
        /// The client id for CF’s API.
        /// </summary>
        /// <value>The client id for CF’s API.</value>
        [DataMember(Name = "cf_client_id", EmitDefaultValue = false)]

        public string CfClientId { get; set; }


        /// <summary>
        /// The client secret for CF’s API.
        /// </summary>
        /// <value>The client secret for CF’s API.</value>
        [DataMember(Name = "cf_client_secret", EmitDefaultValue = false)]

        public string CfClientSecret { get; set; }


        /// <summary>
        /// The password for CF’s API.
        /// </summary>
        /// <value>The password for CF’s API.</value>
        [DataMember(Name = "cf_password", EmitDefaultValue = false)]

        public string CfPassword { get; set; }


        /// <summary>
        /// The username for CF’s API.
        /// </summary>
        /// <value>The username for CF’s API.</value>
        [DataMember(Name = "cf_username", EmitDefaultValue = false)]

        public string CfUsername { get; set; }


        /// <summary>
        /// The PEM-format CA certificates that are required to have issued the instance certificates presented for logging in.
        /// </summary>
        /// <value>The PEM-format CA certificates that are required to have issued the instance certificates presented for logging in.</value>
        [DataMember(Name = "identity_ca_certificates", EmitDefaultValue = false)]

        public List<string> IdentityCaCertificates { get; set; }


        /// <summary>
        /// Duration in seconds for the maximum acceptable length in the future a \&quot;signing_time\&quot; can be. Useful for clock drift. Set low to reduce the opportunity for replay attacks.
        /// </summary>
        /// <value>Duration in seconds for the maximum acceptable length in the future a \&quot;signing_time\&quot; can be. Useful for clock drift. Set low to reduce the opportunity for replay attacks.</value>
        [DataMember(Name = "login_max_seconds_not_after", EmitDefaultValue = false)]

        public int LoginMaxSecondsNotAfter { get; set; }


        /// <summary>
        /// Duration in seconds for the maximum acceptable age of a \&quot;signing_time\&quot;. Useful for clock drift. Set low to reduce the opportunity for replay attacks.
        /// </summary>
        /// <value>Duration in seconds for the maximum acceptable age of a \&quot;signing_time\&quot;. Useful for clock drift. Set low to reduce the opportunity for replay attacks.</value>
        [DataMember(Name = "login_max_seconds_not_before", EmitDefaultValue = false)]

        public int LoginMaxSecondsNotBefore { get; set; }


        /// <summary>
        /// Deprecated. Please use \&quot;cf_api_addr\&quot;.
        /// </summary>
        /// <value>Deprecated. Please use \&quot;cf_api_addr\&quot;.</value>
        [DataMember(Name = "pcf_api_addr", EmitDefaultValue = false)]

        [Obsolete] public string PcfApiAddr { get; set; }


        /// <summary>
        /// Deprecated. Please use \&quot;cf_api_trusted_certificates\&quot;.
        /// </summary>
        /// <value>Deprecated. Please use \&quot;cf_api_trusted_certificates\&quot;.</value>
        [DataMember(Name = "pcf_api_trusted_certificates", EmitDefaultValue = false)]

        [Obsolete] public List<string> PcfApiTrustedCertificates { get; set; }


        /// <summary>
        /// Deprecated. Please use \&quot;cf_password\&quot;.
        /// </summary>
        /// <value>Deprecated. Please use \&quot;cf_password\&quot;.</value>
        [DataMember(Name = "pcf_password", EmitDefaultValue = false)]

        [Obsolete] public string PcfPassword { get; set; }


        /// <summary>
        /// Deprecated. Please use \&quot;cf_username\&quot;.
        /// </summary>
        /// <value>Deprecated. Please use \&quot;cf_username\&quot;.</value>
        [DataMember(Name = "pcf_username", EmitDefaultValue = false)]

        [Obsolete] public string PcfUsername { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CloudFoundryWriteConfigRequest {\n");
            sb.Append("  CfApiAddr: ").Append(CfApiAddr).Append("\n");
            sb.Append("  CfApiMutualTlsCertificate: ").Append(CfApiMutualTlsCertificate).Append("\n");
            sb.Append("  CfApiMutualTlsKey: ").Append(CfApiMutualTlsKey).Append("\n");
            sb.Append("  CfApiTrustedCertificates: ").Append(CfApiTrustedCertificates).Append("\n");
            sb.Append("  CfClientId: ").Append(CfClientId).Append("\n");
            sb.Append("  CfClientSecret: ").Append(CfClientSecret).Append("\n");
            sb.Append("  CfPassword: ").Append(CfPassword).Append("\n");
            sb.Append("  CfUsername: ").Append(CfUsername).Append("\n");
            sb.Append("  IdentityCaCertificates: ").Append(IdentityCaCertificates).Append("\n");
            sb.Append("  LoginMaxSecondsNotAfter: ").Append(LoginMaxSecondsNotAfter).Append("\n");
            sb.Append("  LoginMaxSecondsNotBefore: ").Append(LoginMaxSecondsNotBefore).Append("\n");
            sb.Append("  PcfApiAddr: ").Append(PcfApiAddr).Append("\n");
            sb.Append("  PcfApiTrustedCertificates: ").Append(PcfApiTrustedCertificates).Append("\n");
            sb.Append("  PcfPassword: ").Append(PcfPassword).Append("\n");
            sb.Append("  PcfUsername: ").Append(PcfUsername).Append("\n");
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
            return this.Equals(input as CloudFoundryWriteConfigRequest);
        }

        /// <summary>
        /// Returns true if CloudFoundryWriteConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudFoundryWriteConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudFoundryWriteConfigRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.CfApiAddr == input.CfApiAddr ||
                    (this.CfApiAddr != null &&
                    this.CfApiAddr.Equals(input.CfApiAddr))

                ) &&
                (
                    this.CfApiMutualTlsCertificate == input.CfApiMutualTlsCertificate ||
                    (this.CfApiMutualTlsCertificate != null &&
                    this.CfApiMutualTlsCertificate.Equals(input.CfApiMutualTlsCertificate))

                ) &&
                (
                    this.CfApiMutualTlsKey == input.CfApiMutualTlsKey ||
                    (this.CfApiMutualTlsKey != null &&
                    this.CfApiMutualTlsKey.Equals(input.CfApiMutualTlsKey))

                ) &&
                (
                    this.CfApiTrustedCertificates == input.CfApiTrustedCertificates ||
                    this.CfApiTrustedCertificates != null &&
                    input.CfApiTrustedCertificates != null &&
                    this.CfApiTrustedCertificates.SequenceEqual(input.CfApiTrustedCertificates)
                ) &&
                (
                    this.CfClientId == input.CfClientId ||
                    (this.CfClientId != null &&
                    this.CfClientId.Equals(input.CfClientId))

                ) &&
                (
                    this.CfClientSecret == input.CfClientSecret ||
                    (this.CfClientSecret != null &&
                    this.CfClientSecret.Equals(input.CfClientSecret))

                ) &&
                (
                    this.CfPassword == input.CfPassword ||
                    (this.CfPassword != null &&
                    this.CfPassword.Equals(input.CfPassword))

                ) &&
                (
                    this.CfUsername == input.CfUsername ||
                    (this.CfUsername != null &&
                    this.CfUsername.Equals(input.CfUsername))

                ) &&
                (
                    this.IdentityCaCertificates == input.IdentityCaCertificates ||
                    this.IdentityCaCertificates != null &&
                    input.IdentityCaCertificates != null &&
                    this.IdentityCaCertificates.SequenceEqual(input.IdentityCaCertificates)
                ) &&
                (
                    this.LoginMaxSecondsNotAfter == input.LoginMaxSecondsNotAfter ||

                    this.LoginMaxSecondsNotAfter.Equals(input.LoginMaxSecondsNotAfter)
                ) &&
                (
                    this.LoginMaxSecondsNotBefore == input.LoginMaxSecondsNotBefore ||

                    this.LoginMaxSecondsNotBefore.Equals(input.LoginMaxSecondsNotBefore)
                ) &&
                (
                    this.PcfApiAddr == input.PcfApiAddr ||
                    (this.PcfApiAddr != null &&
                    this.PcfApiAddr.Equals(input.PcfApiAddr))

                ) &&
                (
                    this.PcfApiTrustedCertificates == input.PcfApiTrustedCertificates ||
                    this.PcfApiTrustedCertificates != null &&
                    input.PcfApiTrustedCertificates != null &&
                    this.PcfApiTrustedCertificates.SequenceEqual(input.PcfApiTrustedCertificates)
                ) &&
                (
                    this.PcfPassword == input.PcfPassword ||
                    (this.PcfPassword != null &&
                    this.PcfPassword.Equals(input.PcfPassword))

                ) &&
                (
                    this.PcfUsername == input.PcfUsername ||
                    (this.PcfUsername != null &&
                    this.PcfUsername.Equals(input.PcfUsername))

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

                if (this.CfApiAddr != null)
                {
                    hashCode = (hashCode * 59) + this.CfApiAddr.GetHashCode();
                }

                if (this.CfApiMutualTlsCertificate != null)
                {
                    hashCode = (hashCode * 59) + this.CfApiMutualTlsCertificate.GetHashCode();
                }

                if (this.CfApiMutualTlsKey != null)
                {
                    hashCode = (hashCode * 59) + this.CfApiMutualTlsKey.GetHashCode();
                }

                if (this.CfApiTrustedCertificates != null)
                {
                    hashCode = (hashCode * 59) + this.CfApiTrustedCertificates.GetHashCode();
                }

                if (this.CfClientId != null)
                {
                    hashCode = (hashCode * 59) + this.CfClientId.GetHashCode();
                }

                if (this.CfClientSecret != null)
                {
                    hashCode = (hashCode * 59) + this.CfClientSecret.GetHashCode();
                }

                if (this.CfPassword != null)
                {
                    hashCode = (hashCode * 59) + this.CfPassword.GetHashCode();
                }

                if (this.CfUsername != null)
                {
                    hashCode = (hashCode * 59) + this.CfUsername.GetHashCode();
                }

                if (this.IdentityCaCertificates != null)
                {
                    hashCode = (hashCode * 59) + this.IdentityCaCertificates.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.LoginMaxSecondsNotAfter.GetHashCode();

                hashCode = (hashCode * 59) + this.LoginMaxSecondsNotBefore.GetHashCode();
                if (this.PcfApiAddr != null)
                {
                    hashCode = (hashCode * 59) + this.PcfApiAddr.GetHashCode();
                }

                if (this.PcfApiTrustedCertificates != null)
                {
                    hashCode = (hashCode * 59) + this.PcfApiTrustedCertificates.GetHashCode();
                }

                if (this.PcfPassword != null)
                {
                    hashCode = (hashCode * 59) + this.PcfPassword.GetHashCode();
                }

                if (this.PcfUsername != null)
                {
                    hashCode = (hashCode * 59) + this.PcfUsername.GetHashCode();
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
