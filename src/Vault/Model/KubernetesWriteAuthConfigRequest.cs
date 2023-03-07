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
    /// KubernetesWriteAuthConfigRequest
    /// </summary>
    [DataContract(Name = "KubernetesWriteAuthConfigRequest")]
    public partial class KubernetesWriteAuthConfigRequest : IEquatable<KubernetesWriteAuthConfigRequest>, IValidatableObject
    {

















        /// <summary>
        /// Initializes a new instance of the <see cref="KubernetesWriteAuthConfigRequest" /> class.
        /// </summary>

        /// <param name="DisableIssValidation">Disable JWT issuer validation (Deprecated, will be removed in a future release) (default to true).</param>

        /// <param name="DisableLocalCaJwt">Disable defaulting to the local CA cert and service account JWT when running in a Kubernetes pod (default to false).</param>

        /// <param name="Issuer">Optional JWT issuer. If no issuer is specified, then this plugin will use kubernetes.io/serviceaccount as the default issuer. (Deprecated, will be removed in a future release).</param>

        /// <param name="KubernetesCaCert">PEM encoded CA cert for use by the TLS client used to talk with the API..</param>

        /// <param name="KubernetesHost">Host must be a host string, a host:port pair, or a URL to the base of the Kubernetes API server..</param>

        /// <param name="PemKeys">Optional list of PEM-formated public keys or certificates used to verify the signatures of kubernetes service account JWTs. If a certificate is given, its public key will be extracted. Not every installation of Kubernetes exposes these keys..</param>

        /// <param name="TokenReviewerJwt">A service account JWT used to access the TokenReview API to validate other JWTs during login. If not set the JWT used for login will be used to access the API..</param>


        public KubernetesWriteAuthConfigRequest(bool DisableIssValidation = true, bool DisableLocalCaJwt = false, string Issuer = default(string), string KubernetesCaCert = default(string), string KubernetesHost = default(string), List<string> PemKeys = default(List<string>), string TokenReviewerJwt = default(string))
        {

            this.DisableIssValidation = DisableIssValidation;

            this.DisableLocalCaJwt = DisableLocalCaJwt;

            this.Issuer = Issuer;

            this.KubernetesCaCert = KubernetesCaCert;

            this.KubernetesHost = KubernetesHost;

            this.PemKeys = PemKeys;

            this.TokenReviewerJwt = TokenReviewerJwt;

        }

        /// <summary>
        /// Disable JWT issuer validation (Deprecated, will be removed in a future release)
        /// </summary>
        /// <value>Disable JWT issuer validation (Deprecated, will be removed in a future release)</value>
        [DataMember(Name = "disable_iss_validation", EmitDefaultValue = true)]

        [Obsolete] public bool DisableIssValidation { get; set; }


        /// <summary>
        /// Disable defaulting to the local CA cert and service account JWT when running in a Kubernetes pod
        /// </summary>
        /// <value>Disable defaulting to the local CA cert and service account JWT when running in a Kubernetes pod</value>
        [DataMember(Name = "disable_local_ca_jwt", EmitDefaultValue = true)]

        public bool DisableLocalCaJwt { get; set; }


        /// <summary>
        /// Optional JWT issuer. If no issuer is specified, then this plugin will use kubernetes.io/serviceaccount as the default issuer. (Deprecated, will be removed in a future release)
        /// </summary>
        /// <value>Optional JWT issuer. If no issuer is specified, then this plugin will use kubernetes.io/serviceaccount as the default issuer. (Deprecated, will be removed in a future release)</value>
        [DataMember(Name = "issuer", EmitDefaultValue = false)]

        [Obsolete] public string Issuer { get; set; }


        /// <summary>
        /// PEM encoded CA cert for use by the TLS client used to talk with the API.
        /// </summary>
        /// <value>PEM encoded CA cert for use by the TLS client used to talk with the API.</value>
        [DataMember(Name = "kubernetes_ca_cert", EmitDefaultValue = false)]

        public string KubernetesCaCert { get; set; }


        /// <summary>
        /// Host must be a host string, a host:port pair, or a URL to the base of the Kubernetes API server.
        /// </summary>
        /// <value>Host must be a host string, a host:port pair, or a URL to the base of the Kubernetes API server.</value>
        [DataMember(Name = "kubernetes_host", EmitDefaultValue = false)]

        public string KubernetesHost { get; set; }


        /// <summary>
        /// Optional list of PEM-formated public keys or certificates used to verify the signatures of kubernetes service account JWTs. If a certificate is given, its public key will be extracted. Not every installation of Kubernetes exposes these keys.
        /// </summary>
        /// <value>Optional list of PEM-formated public keys or certificates used to verify the signatures of kubernetes service account JWTs. If a certificate is given, its public key will be extracted. Not every installation of Kubernetes exposes these keys.</value>
        [DataMember(Name = "pem_keys", EmitDefaultValue = false)]

        public List<string> PemKeys { get; set; }


        /// <summary>
        /// A service account JWT used to access the TokenReview API to validate other JWTs during login. If not set the JWT used for login will be used to access the API.
        /// </summary>
        /// <value>A service account JWT used to access the TokenReview API to validate other JWTs during login. If not set the JWT used for login will be used to access the API.</value>
        [DataMember(Name = "token_reviewer_jwt", EmitDefaultValue = false)]

        public string TokenReviewerJwt { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KubernetesWriteAuthConfigRequest {\n");
            sb.Append("  DisableIssValidation: ").Append(DisableIssValidation).Append("\n");
            sb.Append("  DisableLocalCaJwt: ").Append(DisableLocalCaJwt).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  KubernetesCaCert: ").Append(KubernetesCaCert).Append("\n");
            sb.Append("  KubernetesHost: ").Append(KubernetesHost).Append("\n");
            sb.Append("  PemKeys: ").Append(PemKeys).Append("\n");
            sb.Append("  TokenReviewerJwt: ").Append(TokenReviewerJwt).Append("\n");
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
            return this.Equals(input as KubernetesWriteAuthConfigRequest);
        }

        /// <summary>
        /// Returns true if KubernetesWriteAuthConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of KubernetesWriteAuthConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KubernetesWriteAuthConfigRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.DisableIssValidation == input.DisableIssValidation ||

                    this.DisableIssValidation.Equals(input.DisableIssValidation)
                ) &&
                (
                    this.DisableLocalCaJwt == input.DisableLocalCaJwt ||

                    this.DisableLocalCaJwt.Equals(input.DisableLocalCaJwt)
                ) &&
                (
                    this.Issuer == input.Issuer ||
                    (this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer))

                ) &&
                (
                    this.KubernetesCaCert == input.KubernetesCaCert ||
                    (this.KubernetesCaCert != null &&
                    this.KubernetesCaCert.Equals(input.KubernetesCaCert))

                ) &&
                (
                    this.KubernetesHost == input.KubernetesHost ||
                    (this.KubernetesHost != null &&
                    this.KubernetesHost.Equals(input.KubernetesHost))

                ) &&
                (
                    this.PemKeys == input.PemKeys ||
                    this.PemKeys != null &&
                    input.PemKeys != null &&
                    this.PemKeys.SequenceEqual(input.PemKeys)
                ) &&
                (
                    this.TokenReviewerJwt == input.TokenReviewerJwt ||
                    (this.TokenReviewerJwt != null &&
                    this.TokenReviewerJwt.Equals(input.TokenReviewerJwt))

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


                hashCode = (hashCode * 59) + this.DisableIssValidation.GetHashCode();

                hashCode = (hashCode * 59) + this.DisableLocalCaJwt.GetHashCode();
                if (this.Issuer != null)
                {
                    hashCode = (hashCode * 59) + this.Issuer.GetHashCode();
                }

                if (this.KubernetesCaCert != null)
                {
                    hashCode = (hashCode * 59) + this.KubernetesCaCert.GetHashCode();
                }

                if (this.KubernetesHost != null)
                {
                    hashCode = (hashCode * 59) + this.KubernetesHost.GetHashCode();
                }

                if (this.PemKeys != null)
                {
                    hashCode = (hashCode * 59) + this.PemKeys.GetHashCode();
                }

                if (this.TokenReviewerJwt != null)
                {
                    hashCode = (hashCode * 59) + this.TokenReviewerJwt.GetHashCode();
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
