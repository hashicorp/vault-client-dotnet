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
    /// KubernetesWriteCredentialsRequest
    /// </summary>
    [DataContract(Name = "KubernetesWriteCredentialsRequest")]
    public partial class KubernetesWriteCredentialsRequest : IEquatable<KubernetesWriteCredentialsRequest>, IValidatableObject
    {




        /// <summary>
        /// Initializes a new instance of the <see cref="KubernetesWriteCredentialsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KubernetesWriteCredentialsRequest() { }


        /// <summary>
        /// Initializes a new instance of the <see cref="KubernetesWriteCredentialsRequest" /> class.
        /// </summary>

        /// <param name="ClusterRoleBinding">If true, generate a ClusterRoleBinding to grant permissions across the whole cluster instead of within a namespace. Requires the Vault role to have kubernetes_role_type set to ClusterRole..</param>

        /// <param name="KubernetesNamespace">The name of the Kubernetes namespace in which to generate the credentials (required).</param>

        /// <param name="Ttl">The TTL of the generated credentials.</param>


        public KubernetesWriteCredentialsRequest(bool ClusterRoleBinding = default(bool), string KubernetesNamespace = default(string), int Ttl = default(int))
        {

            // to ensure "KubernetesNamespace" is required (not null)
            if (KubernetesNamespace == null)
            {
                throw new ArgumentNullException("KubernetesNamespace is a required property for KubernetesWriteCredentialsRequest and cannot be null");
            }
            this.KubernetesNamespace = KubernetesNamespace;


            this.ClusterRoleBinding = ClusterRoleBinding;

            this.Ttl = Ttl;

        }

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

        public int Ttl { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KubernetesWriteCredentialsRequest {\n");
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
            return this.Equals(input as KubernetesWriteCredentialsRequest);
        }

        /// <summary>
        /// Returns true if KubernetesWriteCredentialsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of KubernetesWriteCredentialsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KubernetesWriteCredentialsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
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


                hashCode = (hashCode * 59) + this.ClusterRoleBinding.GetHashCode();
                if (this.KubernetesNamespace != null)
                {
                    hashCode = (hashCode * 59) + this.KubernetesNamespace.GetHashCode();
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
