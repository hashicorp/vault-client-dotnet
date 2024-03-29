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
    /// KubernetesWriteRoleRequest
    /// </summary>
    [DataContract(Name = "KubernetesWriteRoleRequest")]
    public partial class KubernetesWriteRoleRequest : IEquatable<KubernetesWriteRoleRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="KubernetesWriteRoleRequest" /> class.
        /// </summary>

        /// <param name="AllowedKubernetesNamespaceSelector">A label selector for Kubernetes namespaces in which credentials can be generated. Accepts either a JSON or YAML object. If set with allowed_kubernetes_namespaces, the conditions are conjuncted..</param>

        /// <param name="AllowedKubernetesNamespaces">A list of the Kubernetes namespaces in which credentials can be generated. If set to \&quot;*\&quot; all namespaces are allowed..</param>

        /// <param name="ExtraAnnotations">Additional annotations to apply to all generated Kubernetes objects..</param>

        /// <param name="ExtraLabels">Additional labels to apply to all generated Kubernetes objects..</param>

        /// <param name="GeneratedRoleRules">The Role or ClusterRole rules to use when generating a role. Accepts either a JSON or YAML object. If set, the entire chain of Kubernetes objects will be generated..</param>

        /// <param name="KubernetesRoleName">The pre-existing Role or ClusterRole to bind a generated service account to. If set, Kubernetes token, service account, and role binding objects will be created..</param>

        /// <param name="KubernetesRoleType">Specifies whether the Kubernetes role is a Role or ClusterRole. (default to &quot;Role&quot;).</param>

        /// <param name="NameTemplate">The name template to use when generating service accounts, roles and role bindings. If unset, a default template is used..</param>

        /// <param name="ServiceAccountName">The pre-existing service account to generate tokens for. Mutually exclusive with all role parameters. If set, only a Kubernetes service account token will be created..</param>

        /// <param name="TokenDefaultAudiences">The default audiences for generated Kubernetes service account tokens. If not set or set to \&quot;\&quot;, will use k8s cluster default..</param>

        /// <param name="TokenDefaultTtl">The default ttl for generated Kubernetes service account tokens. If not set or set to 0, will use system default..</param>

        /// <param name="TokenMaxTtl">The maximum ttl for generated Kubernetes service account tokens. If not set or set to 0, will use system default..</param>


        public KubernetesWriteRoleRequest(string AllowedKubernetesNamespaceSelector = default(string), List<string> AllowedKubernetesNamespaces = default(List<string>), Object ExtraAnnotations = default(Object), Object ExtraLabels = default(Object), string GeneratedRoleRules = default(string), string KubernetesRoleName = default(string), string KubernetesRoleType = "Role", string NameTemplate = default(string), string ServiceAccountName = default(string), List<string> TokenDefaultAudiences = default(List<string>), string TokenDefaultTtl = default(string), string TokenMaxTtl = default(string))
        {

            this.AllowedKubernetesNamespaceSelector = AllowedKubernetesNamespaceSelector;

            this.AllowedKubernetesNamespaces = AllowedKubernetesNamespaces;

            this.ExtraAnnotations = ExtraAnnotations;

            this.ExtraLabels = ExtraLabels;

            this.GeneratedRoleRules = GeneratedRoleRules;

            this.KubernetesRoleName = KubernetesRoleName;

            // use default value if no "KubernetesRoleType" provided
            this.KubernetesRoleType = KubernetesRoleType ?? "Role";


            this.NameTemplate = NameTemplate;

            this.ServiceAccountName = ServiceAccountName;

            this.TokenDefaultAudiences = TokenDefaultAudiences;

            this.TokenDefaultTtl = TokenDefaultTtl;

            this.TokenMaxTtl = TokenMaxTtl;

        }

        /// <summary>
        /// A label selector for Kubernetes namespaces in which credentials can be generated. Accepts either a JSON or YAML object. If set with allowed_kubernetes_namespaces, the conditions are conjuncted.
        /// </summary>
        /// <value>A label selector for Kubernetes namespaces in which credentials can be generated. Accepts either a JSON or YAML object. If set with allowed_kubernetes_namespaces, the conditions are conjuncted.</value>
        [DataMember(Name = "allowed_kubernetes_namespace_selector", EmitDefaultValue = false)]

        public string AllowedKubernetesNamespaceSelector { get; set; }


        /// <summary>
        /// A list of the Kubernetes namespaces in which credentials can be generated. If set to \&quot;*\&quot; all namespaces are allowed.
        /// </summary>
        /// <value>A list of the Kubernetes namespaces in which credentials can be generated. If set to \&quot;*\&quot; all namespaces are allowed.</value>
        [DataMember(Name = "allowed_kubernetes_namespaces", EmitDefaultValue = false)]

        public List<string> AllowedKubernetesNamespaces { get; set; }


        /// <summary>
        /// Additional annotations to apply to all generated Kubernetes objects.
        /// </summary>
        /// <value>Additional annotations to apply to all generated Kubernetes objects.</value>
        [DataMember(Name = "extra_annotations", EmitDefaultValue = false)]

        public Object ExtraAnnotations { get; set; }


        /// <summary>
        /// Additional labels to apply to all generated Kubernetes objects.
        /// </summary>
        /// <value>Additional labels to apply to all generated Kubernetes objects.</value>
        [DataMember(Name = "extra_labels", EmitDefaultValue = false)]

        public Object ExtraLabels { get; set; }


        /// <summary>
        /// The Role or ClusterRole rules to use when generating a role. Accepts either a JSON or YAML object. If set, the entire chain of Kubernetes objects will be generated.
        /// </summary>
        /// <value>The Role or ClusterRole rules to use when generating a role. Accepts either a JSON or YAML object. If set, the entire chain of Kubernetes objects will be generated.</value>
        [DataMember(Name = "generated_role_rules", EmitDefaultValue = false)]

        public string GeneratedRoleRules { get; set; }


        /// <summary>
        /// The pre-existing Role or ClusterRole to bind a generated service account to. If set, Kubernetes token, service account, and role binding objects will be created.
        /// </summary>
        /// <value>The pre-existing Role or ClusterRole to bind a generated service account to. If set, Kubernetes token, service account, and role binding objects will be created.</value>
        [DataMember(Name = "kubernetes_role_name", EmitDefaultValue = false)]

        public string KubernetesRoleName { get; set; }


        /// <summary>
        /// Specifies whether the Kubernetes role is a Role or ClusterRole.
        /// </summary>
        /// <value>Specifies whether the Kubernetes role is a Role or ClusterRole.</value>
        [DataMember(Name = "kubernetes_role_type", EmitDefaultValue = false)]

        public string KubernetesRoleType { get; set; }


        /// <summary>
        /// The name template to use when generating service accounts, roles and role bindings. If unset, a default template is used.
        /// </summary>
        /// <value>The name template to use when generating service accounts, roles and role bindings. If unset, a default template is used.</value>
        [DataMember(Name = "name_template", EmitDefaultValue = false)]

        public string NameTemplate { get; set; }


        /// <summary>
        /// The pre-existing service account to generate tokens for. Mutually exclusive with all role parameters. If set, only a Kubernetes service account token will be created.
        /// </summary>
        /// <value>The pre-existing service account to generate tokens for. Mutually exclusive with all role parameters. If set, only a Kubernetes service account token will be created.</value>
        [DataMember(Name = "service_account_name", EmitDefaultValue = false)]

        public string ServiceAccountName { get; set; }


        /// <summary>
        /// The default audiences for generated Kubernetes service account tokens. If not set or set to \&quot;\&quot;, will use k8s cluster default.
        /// </summary>
        /// <value>The default audiences for generated Kubernetes service account tokens. If not set or set to \&quot;\&quot;, will use k8s cluster default.</value>
        [DataMember(Name = "token_default_audiences", EmitDefaultValue = false)]

        public List<string> TokenDefaultAudiences { get; set; }


        /// <summary>
        /// The default ttl for generated Kubernetes service account tokens. If not set or set to 0, will use system default.
        /// </summary>
        /// <value>The default ttl for generated Kubernetes service account tokens. If not set or set to 0, will use system default.</value>
        [DataMember(Name = "token_default_ttl", EmitDefaultValue = false)]

        public string TokenDefaultTtl { get; set; }


        /// <summary>
        /// The maximum ttl for generated Kubernetes service account tokens. If not set or set to 0, will use system default.
        /// </summary>
        /// <value>The maximum ttl for generated Kubernetes service account tokens. If not set or set to 0, will use system default.</value>
        [DataMember(Name = "token_max_ttl", EmitDefaultValue = false)]

        public string TokenMaxTtl { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KubernetesWriteRoleRequest {\n");
            sb.Append("  AllowedKubernetesNamespaceSelector: ").Append(AllowedKubernetesNamespaceSelector).Append("\n");
            sb.Append("  AllowedKubernetesNamespaces: ").Append(AllowedKubernetesNamespaces).Append("\n");
            sb.Append("  ExtraAnnotations: ").Append(ExtraAnnotations).Append("\n");
            sb.Append("  ExtraLabels: ").Append(ExtraLabels).Append("\n");
            sb.Append("  GeneratedRoleRules: ").Append(GeneratedRoleRules).Append("\n");
            sb.Append("  KubernetesRoleName: ").Append(KubernetesRoleName).Append("\n");
            sb.Append("  KubernetesRoleType: ").Append(KubernetesRoleType).Append("\n");
            sb.Append("  NameTemplate: ").Append(NameTemplate).Append("\n");
            sb.Append("  ServiceAccountName: ").Append(ServiceAccountName).Append("\n");
            sb.Append("  TokenDefaultAudiences: ").Append(TokenDefaultAudiences).Append("\n");
            sb.Append("  TokenDefaultTtl: ").Append(TokenDefaultTtl).Append("\n");
            sb.Append("  TokenMaxTtl: ").Append(TokenMaxTtl).Append("\n");
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
            return this.Equals(input as KubernetesWriteRoleRequest);
        }

        /// <summary>
        /// Returns true if KubernetesWriteRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of KubernetesWriteRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KubernetesWriteRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AllowedKubernetesNamespaceSelector == input.AllowedKubernetesNamespaceSelector ||
                    (this.AllowedKubernetesNamespaceSelector != null &&
                    this.AllowedKubernetesNamespaceSelector.Equals(input.AllowedKubernetesNamespaceSelector))

                ) &&
                (
                    this.AllowedKubernetesNamespaces == input.AllowedKubernetesNamespaces ||
                    this.AllowedKubernetesNamespaces != null &&
                    input.AllowedKubernetesNamespaces != null &&
                    this.AllowedKubernetesNamespaces.SequenceEqual(input.AllowedKubernetesNamespaces)
                ) &&
                (
                    this.ExtraAnnotations == input.ExtraAnnotations ||
                    (this.ExtraAnnotations != null &&
                    this.ExtraAnnotations.Equals(input.ExtraAnnotations))

                ) &&
                (
                    this.ExtraLabels == input.ExtraLabels ||
                    (this.ExtraLabels != null &&
                    this.ExtraLabels.Equals(input.ExtraLabels))

                ) &&
                (
                    this.GeneratedRoleRules == input.GeneratedRoleRules ||
                    (this.GeneratedRoleRules != null &&
                    this.GeneratedRoleRules.Equals(input.GeneratedRoleRules))

                ) &&
                (
                    this.KubernetesRoleName == input.KubernetesRoleName ||
                    (this.KubernetesRoleName != null &&
                    this.KubernetesRoleName.Equals(input.KubernetesRoleName))

                ) &&
                (
                    this.KubernetesRoleType == input.KubernetesRoleType ||
                    (this.KubernetesRoleType != null &&
                    this.KubernetesRoleType.Equals(input.KubernetesRoleType))

                ) &&
                (
                    this.NameTemplate == input.NameTemplate ||
                    (this.NameTemplate != null &&
                    this.NameTemplate.Equals(input.NameTemplate))

                ) &&
                (
                    this.ServiceAccountName == input.ServiceAccountName ||
                    (this.ServiceAccountName != null &&
                    this.ServiceAccountName.Equals(input.ServiceAccountName))

                ) &&
                (
                    this.TokenDefaultAudiences == input.TokenDefaultAudiences ||
                    this.TokenDefaultAudiences != null &&
                    input.TokenDefaultAudiences != null &&
                    this.TokenDefaultAudiences.SequenceEqual(input.TokenDefaultAudiences)
                ) &&
                (
                    this.TokenDefaultTtl == input.TokenDefaultTtl ||
                    (this.TokenDefaultTtl != null &&
                    this.TokenDefaultTtl.Equals(input.TokenDefaultTtl))

                ) &&
                (
                    this.TokenMaxTtl == input.TokenMaxTtl ||
                    (this.TokenMaxTtl != null &&
                    this.TokenMaxTtl.Equals(input.TokenMaxTtl))

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

                if (this.AllowedKubernetesNamespaceSelector != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedKubernetesNamespaceSelector.GetHashCode();
                }

                if (this.AllowedKubernetesNamespaces != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedKubernetesNamespaces.GetHashCode();
                }

                if (this.ExtraAnnotations != null)
                {
                    hashCode = (hashCode * 59) + this.ExtraAnnotations.GetHashCode();
                }

                if (this.ExtraLabels != null)
                {
                    hashCode = (hashCode * 59) + this.ExtraLabels.GetHashCode();
                }

                if (this.GeneratedRoleRules != null)
                {
                    hashCode = (hashCode * 59) + this.GeneratedRoleRules.GetHashCode();
                }

                if (this.KubernetesRoleName != null)
                {
                    hashCode = (hashCode * 59) + this.KubernetesRoleName.GetHashCode();
                }

                if (this.KubernetesRoleType != null)
                {
                    hashCode = (hashCode * 59) + this.KubernetesRoleType.GetHashCode();
                }

                if (this.NameTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.NameTemplate.GetHashCode();
                }

                if (this.ServiceAccountName != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceAccountName.GetHashCode();
                }

                if (this.TokenDefaultAudiences != null)
                {
                    hashCode = (hashCode * 59) + this.TokenDefaultAudiences.GetHashCode();
                }

                if (this.TokenDefaultTtl != null)
                {
                    hashCode = (hashCode * 59) + this.TokenDefaultTtl.GetHashCode();
                }

                if (this.TokenMaxTtl != null)
                {
                    hashCode = (hashCode * 59) + this.TokenMaxTtl.GetHashCode();
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
