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
    /// KubernetesWriteConfigRequest
    /// </summary>
    [DataContract(Name = "KubernetesWriteConfigRequest")]
    public partial class KubernetesWriteConfigRequest : IEquatable<KubernetesWriteConfigRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="KubernetesWriteConfigRequest" /> class.
        /// </summary>

        /// <param name="DisableLocalCaJwt">Disable defaulting to the local CA certificate and service account JWT when running in a Kubernetes pod. (default to false).</param>

        /// <param name="KubernetesCaCert">PEM encoded CA certificate to use to verify the Kubernetes API server certificate. Defaults to the local pod&#x27;s CA if found..</param>

        /// <param name="KubernetesHost">Kubernetes API URL to connect to. Defaults to https://$KUBERNETES_SERVICE_HOST:KUBERNETES_SERVICE_PORT if those environment variables are set..</param>

        /// <param name="ServiceAccountJwt">The JSON web token of the service account used by the secret engine to manage Kubernetes credentials. Defaults to the local pod&#x27;s JWT if found..</param>


        public KubernetesWriteConfigRequest(bool DisableLocalCaJwt = false, string KubernetesCaCert = default(string), string KubernetesHost = default(string), string ServiceAccountJwt = default(string))
        {

            this.DisableLocalCaJwt = DisableLocalCaJwt;

            this.KubernetesCaCert = KubernetesCaCert;

            this.KubernetesHost = KubernetesHost;

            this.ServiceAccountJwt = ServiceAccountJwt;

        }

        /// <summary>
        /// Disable defaulting to the local CA certificate and service account JWT when running in a Kubernetes pod.
        /// </summary>
        /// <value>Disable defaulting to the local CA certificate and service account JWT when running in a Kubernetes pod.</value>
        [DataMember(Name = "disable_local_ca_jwt", EmitDefaultValue = true)]

        public bool DisableLocalCaJwt { get; set; }


        /// <summary>
        /// PEM encoded CA certificate to use to verify the Kubernetes API server certificate. Defaults to the local pod&#x27;s CA if found.
        /// </summary>
        /// <value>PEM encoded CA certificate to use to verify the Kubernetes API server certificate. Defaults to the local pod&#x27;s CA if found.</value>
        [DataMember(Name = "kubernetes_ca_cert", EmitDefaultValue = false)]

        public string KubernetesCaCert { get; set; }


        /// <summary>
        /// Kubernetes API URL to connect to. Defaults to https://$KUBERNETES_SERVICE_HOST:KUBERNETES_SERVICE_PORT if those environment variables are set.
        /// </summary>
        /// <value>Kubernetes API URL to connect to. Defaults to https://$KUBERNETES_SERVICE_HOST:KUBERNETES_SERVICE_PORT if those environment variables are set.</value>
        [DataMember(Name = "kubernetes_host", EmitDefaultValue = false)]

        public string KubernetesHost { get; set; }


        /// <summary>
        /// The JSON web token of the service account used by the secret engine to manage Kubernetes credentials. Defaults to the local pod&#x27;s JWT if found.
        /// </summary>
        /// <value>The JSON web token of the service account used by the secret engine to manage Kubernetes credentials. Defaults to the local pod&#x27;s JWT if found.</value>
        [DataMember(Name = "service_account_jwt", EmitDefaultValue = false)]

        public string ServiceAccountJwt { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KubernetesWriteConfigRequest {\n");
            sb.Append("  DisableLocalCaJwt: ").Append(DisableLocalCaJwt).Append("\n");
            sb.Append("  KubernetesCaCert: ").Append(KubernetesCaCert).Append("\n");
            sb.Append("  KubernetesHost: ").Append(KubernetesHost).Append("\n");
            sb.Append("  ServiceAccountJwt: ").Append(ServiceAccountJwt).Append("\n");
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
            return this.Equals(input as KubernetesWriteConfigRequest);
        }

        /// <summary>
        /// Returns true if KubernetesWriteConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of KubernetesWriteConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KubernetesWriteConfigRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.DisableLocalCaJwt == input.DisableLocalCaJwt ||

                    this.DisableLocalCaJwt.Equals(input.DisableLocalCaJwt)
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
                    this.ServiceAccountJwt == input.ServiceAccountJwt ||
                    (this.ServiceAccountJwt != null &&
                    this.ServiceAccountJwt.Equals(input.ServiceAccountJwt))

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


                hashCode = (hashCode * 59) + this.DisableLocalCaJwt.GetHashCode();
                if (this.KubernetesCaCert != null)
                {
                    hashCode = (hashCode * 59) + this.KubernetesCaCert.GetHashCode();
                }

                if (this.KubernetesHost != null)
                {
                    hashCode = (hashCode * 59) + this.KubernetesHost.GetHashCode();
                }

                if (this.ServiceAccountJwt != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceAccountJwt.GetHashCode();
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
