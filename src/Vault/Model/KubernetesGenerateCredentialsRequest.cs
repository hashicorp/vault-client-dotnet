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
    /// KubernetesGenerateCredentialsRequest
    /// </summary>
    [DataContract(Name = "KubernetesGenerateCredentialsRequest")]
    public partial class KubernetesGenerateCredentialsRequest : IEquatable<KubernetesGenerateCredentialsRequest>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="KubernetesGenerateCredentialsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KubernetesGenerateCredentialsRequest() { }


        /// <summary>
        /// Initializes a new instance of the <see cref="KubernetesGenerateCredentialsRequest" /> class.
        /// </summary>

        /// <param name="Audiences">The intended audiences of the generated credentials.</param>

        /// <param name="ClusterRoleBinding">If true, generate a ClusterRoleBinding to grant permissions across the whole cluster instead of within a namespace. Requires the Vault role to have kubernetes_role_type set to ClusterRole..</param>

        /// <param name="KubernetesNamespace">The name of the Kubernetes namespace in which to generate the credentials (required).</param>

        /// <param name="Ttl">The TTL of the generated credentials.</param>


        public KubernetesGenerateCredentialsRequest(List<string> Audiences = default(List<string>), bool ClusterRoleBinding = default(bool), string KubernetesNamespace = default(string), string Ttl = default(string))
        {

            // to ensure "KubernetesNamespace" is required (not null)
            if (KubernetesNamespace == null)
            {
                throw new ArgumentNullException("KubernetesNamespace is a required property for KubernetesGenerateCredentialsRequest and cannot be null");
            }
            this.KubernetesNamespace = KubernetesNamespace;


            this.Audiences = Audiences;

            this.ClusterRoleBinding = ClusterRoleBinding;

            this.Ttl = Ttl;

        }

        /// <summary>
        /// The intended audiences of the generated credentials
        /// </summary>
        /// <value>The intended audiences of the generated credentials</value>
        [DataMember(Name = "audiences", EmitDefaultValue = false)]

        public List<string> Audiences { get; set; }


        /// <summary>
        /// If true, generate a ClusterRoleBinding to grant permissions across the whole cluster instead of within a namespace. Requires the Vault role to have kubernetes_role_type set to ClusterRole.
        /// </summary>
        /// <value>If true, generate a ClusterRoleBinding to grant permissions across the whole cluster instead of within a namespace. Requires the Vault role to have kubernetes_role_type set to ClusterRole.</value>
        [DataMember(Name = "cluster_role_binding", EmitDefaultValue = true)]

        public bool ClusterRoleBinding { get; set; }


        /// <summary>
        /// The name of the Kubernetes namespace in which to generate the credentials
        /// </summary>
        /// <value>The name of the Kubernetes namespace in which to generate the credentials</value>
        [DataMember(Name = "kubernetes_namespace", IsRequired = true, EmitDefaultValue = false)]

        public string KubernetesNamespace { get; set; }


        /// <summary>
        /// The TTL of the generated credentials
        /// </summary>
        /// <value>The TTL of the generated credentials</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]

        public string Ttl { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KubernetesGenerateCredentialsRequest {\n");
            sb.Append("  Audiences: ").Append(Audiences).Append("\n");
            sb.Append("  ClusterRoleBinding: ").Append(ClusterRoleBinding).Append("\n");
            sb.Append("  KubernetesNamespace: ").Append(KubernetesNamespace).Append("\n");
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
            return this.Equals(input as KubernetesGenerateCredentialsRequest);
        }

        /// <summary>
        /// Returns true if KubernetesGenerateCredentialsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of KubernetesGenerateCredentialsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KubernetesGenerateCredentialsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Audiences == input.Audiences ||
                    this.Audiences != null &&
                    input.Audiences != null &&
                    this.Audiences.SequenceEqual(input.Audiences)
                ) &&
                (
                    this.ClusterRoleBinding == input.ClusterRoleBinding ||

                    this.ClusterRoleBinding.Equals(input.ClusterRoleBinding)
                ) &&
                (
                    this.KubernetesNamespace == input.KubernetesNamespace ||
                    (this.KubernetesNamespace != null &&
                    this.KubernetesNamespace.Equals(input.KubernetesNamespace))

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

                if (this.Audiences != null)
                {
                    hashCode = (hashCode * 59) + this.Audiences.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.ClusterRoleBinding.GetHashCode();
                if (this.KubernetesNamespace != null)
                {
                    hashCode = (hashCode * 59) + this.KubernetesNamespace.GetHashCode();
                }

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
