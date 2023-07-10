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
    /// ConsulWriteRoleRequest
    /// </summary>
    [DataContract(Name = "ConsulWriteRoleRequest")]
    public partial class ConsulWriteRoleRequest : IEquatable<ConsulWriteRoleRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="ConsulWriteRoleRequest" /> class.
        /// </summary>

        /// <param name="ConsulNamespace">Indicates which namespace that the token will be created within. Defaults to &#x27;default&#x27;. Available in Consul 1.7 and above..</param>

        /// <param name="ConsulPolicies">List of policies to attach to the token. Either \&quot;consul_policies\&quot; or \&quot;consul_roles\&quot; are required for Consul 1.5 and above, or just \&quot;consul_policies\&quot; if using Consul 1.4..</param>

        /// <param name="ConsulRoles">List of Consul roles to attach to the token. Either \&quot;policies\&quot; or \&quot;consul_roles\&quot; are required for Consul 1.5 and above..</param>

        /// <param name="Lease">Use \&quot;ttl\&quot; instead..</param>

        /// <param name="Local">Indicates that the token should not be replicated globally and instead be local to the current datacenter. Available in Consul 1.4 and above..</param>

        /// <param name="MaxTtl">Max TTL for the Consul token created from the role..</param>

        /// <param name="NodeIdentities">List of Node Identities to attach to the token. Available in Consul 1.8.1 or above..</param>

        /// <param name="Partition">Indicates which admin partition that the token will be created within. Defaults to &#x27;default&#x27;. Available in Consul 1.11 and above..</param>

        /// <param name="Policies">Use \&quot;consul_policies\&quot; instead..</param>

        /// <param name="Policy">Policy document, base64 encoded. Required for &#x27;client&#x27; tokens. Required for Consul pre-1.4..</param>

        /// <param name="ServiceIdentities">List of Service Identities to attach to the token, separated by semicolons. Available in Consul 1.5 or above..</param>

        /// <param name="TokenType">Which type of token to create: &#x27;client&#x27; or &#x27;management&#x27;. If a &#x27;management&#x27; token, the \&quot;policy\&quot;, \&quot;policies\&quot;, and \&quot;consul_roles\&quot; parameters are not required. Defaults to &#x27;client&#x27;. (default to &quot;client&quot;).</param>

        /// <param name="Ttl">TTL for the Consul token created from the role..</param>


        public ConsulWriteRoleRequest(string ConsulNamespace = default(string), List<string> ConsulPolicies = default(List<string>), List<string> ConsulRoles = default(List<string>), string Lease = default(string), bool Local = default(bool), string MaxTtl = default(string), List<string> NodeIdentities = default(List<string>), string Partition = default(string), List<string> Policies = default(List<string>), string Policy = default(string), List<string> ServiceIdentities = default(List<string>), string TokenType = "client", string Ttl = default(string))
        {

            this.ConsulNamespace = ConsulNamespace;

            this.ConsulPolicies = ConsulPolicies;

            this.ConsulRoles = ConsulRoles;

            this.Lease = Lease;

            this.Local = Local;

            this.MaxTtl = MaxTtl;

            this.NodeIdentities = NodeIdentities;

            this.Partition = Partition;

            this.Policies = Policies;

            this.Policy = Policy;

            this.ServiceIdentities = ServiceIdentities;

            // use default value if no "TokenType" provided
            this.TokenType = TokenType ?? "client";


            this.Ttl = Ttl;

        }

        /// <summary>
        /// Indicates which namespace that the token will be created within. Defaults to &#x27;default&#x27;. Available in Consul 1.7 and above.
        /// </summary>
        /// <value>Indicates which namespace that the token will be created within. Defaults to &#x27;default&#x27;. Available in Consul 1.7 and above.</value>
        [DataMember(Name = "consul_namespace", EmitDefaultValue = false)]

        public string ConsulNamespace { get; set; }


        /// <summary>
        /// List of policies to attach to the token. Either \&quot;consul_policies\&quot; or \&quot;consul_roles\&quot; are required for Consul 1.5 and above, or just \&quot;consul_policies\&quot; if using Consul 1.4.
        /// </summary>
        /// <value>List of policies to attach to the token. Either \&quot;consul_policies\&quot; or \&quot;consul_roles\&quot; are required for Consul 1.5 and above, or just \&quot;consul_policies\&quot; if using Consul 1.4.</value>
        [DataMember(Name = "consul_policies", EmitDefaultValue = false)]

        public List<string> ConsulPolicies { get; set; }


        /// <summary>
        /// List of Consul roles to attach to the token. Either \&quot;policies\&quot; or \&quot;consul_roles\&quot; are required for Consul 1.5 and above.
        /// </summary>
        /// <value>List of Consul roles to attach to the token. Either \&quot;policies\&quot; or \&quot;consul_roles\&quot; are required for Consul 1.5 and above.</value>
        [DataMember(Name = "consul_roles", EmitDefaultValue = false)]

        public List<string> ConsulRoles { get; set; }


        /// <summary>
        /// Use \&quot;ttl\&quot; instead.
        /// </summary>
        /// <value>Use \&quot;ttl\&quot; instead.</value>
        [DataMember(Name = "lease", EmitDefaultValue = false)]

        [Obsolete] public string Lease { get; set; }


        /// <summary>
        /// Indicates that the token should not be replicated globally and instead be local to the current datacenter. Available in Consul 1.4 and above.
        /// </summary>
        /// <value>Indicates that the token should not be replicated globally and instead be local to the current datacenter. Available in Consul 1.4 and above.</value>
        [DataMember(Name = "local", EmitDefaultValue = true)]

        public bool Local { get; set; }


        /// <summary>
        /// Max TTL for the Consul token created from the role.
        /// </summary>
        /// <value>Max TTL for the Consul token created from the role.</value>
        [DataMember(Name = "max_ttl", EmitDefaultValue = false)]

        public string MaxTtl { get; set; }


        /// <summary>
        /// List of Node Identities to attach to the token. Available in Consul 1.8.1 or above.
        /// </summary>
        /// <value>List of Node Identities to attach to the token. Available in Consul 1.8.1 or above.</value>
        [DataMember(Name = "node_identities", EmitDefaultValue = false)]

        public List<string> NodeIdentities { get; set; }


        /// <summary>
        /// Indicates which admin partition that the token will be created within. Defaults to &#x27;default&#x27;. Available in Consul 1.11 and above.
        /// </summary>
        /// <value>Indicates which admin partition that the token will be created within. Defaults to &#x27;default&#x27;. Available in Consul 1.11 and above.</value>
        [DataMember(Name = "partition", EmitDefaultValue = false)]

        public string Partition { get; set; }


        /// <summary>
        /// Use \&quot;consul_policies\&quot; instead.
        /// </summary>
        /// <value>Use \&quot;consul_policies\&quot; instead.</value>
        [DataMember(Name = "policies", EmitDefaultValue = false)]

        [Obsolete] public List<string> Policies { get; set; }


        /// <summary>
        /// Policy document, base64 encoded. Required for &#x27;client&#x27; tokens. Required for Consul pre-1.4.
        /// </summary>
        /// <value>Policy document, base64 encoded. Required for &#x27;client&#x27; tokens. Required for Consul pre-1.4.</value>
        [DataMember(Name = "policy", EmitDefaultValue = false)]

        [Obsolete] public string Policy { get; set; }


        /// <summary>
        /// List of Service Identities to attach to the token, separated by semicolons. Available in Consul 1.5 or above.
        /// </summary>
        /// <value>List of Service Identities to attach to the token, separated by semicolons. Available in Consul 1.5 or above.</value>
        [DataMember(Name = "service_identities", EmitDefaultValue = false)]

        public List<string> ServiceIdentities { get; set; }


        /// <summary>
        /// Which type of token to create: &#x27;client&#x27; or &#x27;management&#x27;. If a &#x27;management&#x27; token, the \&quot;policy\&quot;, \&quot;policies\&quot;, and \&quot;consul_roles\&quot; parameters are not required. Defaults to &#x27;client&#x27;.
        /// </summary>
        /// <value>Which type of token to create: &#x27;client&#x27; or &#x27;management&#x27;. If a &#x27;management&#x27; token, the \&quot;policy\&quot;, \&quot;policies\&quot;, and \&quot;consul_roles\&quot; parameters are not required. Defaults to &#x27;client&#x27;.</value>
        [DataMember(Name = "token_type", EmitDefaultValue = false)]

        [Obsolete] public string TokenType { get; set; }


        /// <summary>
        /// TTL for the Consul token created from the role.
        /// </summary>
        /// <value>TTL for the Consul token created from the role.</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]

        public string Ttl { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConsulWriteRoleRequest {\n");
            sb.Append("  ConsulNamespace: ").Append(ConsulNamespace).Append("\n");
            sb.Append("  ConsulPolicies: ").Append(ConsulPolicies).Append("\n");
            sb.Append("  ConsulRoles: ").Append(ConsulRoles).Append("\n");
            sb.Append("  Lease: ").Append(Lease).Append("\n");
            sb.Append("  Local: ").Append(Local).Append("\n");
            sb.Append("  MaxTtl: ").Append(MaxTtl).Append("\n");
            sb.Append("  NodeIdentities: ").Append(NodeIdentities).Append("\n");
            sb.Append("  Partition: ").Append(Partition).Append("\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  ServiceIdentities: ").Append(ServiceIdentities).Append("\n");
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
            return this.Equals(input as ConsulWriteRoleRequest);
        }

        /// <summary>
        /// Returns true if ConsulWriteRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ConsulWriteRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsulWriteRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.ConsulNamespace == input.ConsulNamespace ||
                    (this.ConsulNamespace != null &&
                    this.ConsulNamespace.Equals(input.ConsulNamespace))

                ) &&
                (
                    this.ConsulPolicies == input.ConsulPolicies ||
                    this.ConsulPolicies != null &&
                    input.ConsulPolicies != null &&
                    this.ConsulPolicies.SequenceEqual(input.ConsulPolicies)
                ) &&
                (
                    this.ConsulRoles == input.ConsulRoles ||
                    this.ConsulRoles != null &&
                    input.ConsulRoles != null &&
                    this.ConsulRoles.SequenceEqual(input.ConsulRoles)
                ) &&
                (
                    this.Lease == input.Lease ||
                    (this.Lease != null &&
                    this.Lease.Equals(input.Lease))

                ) &&
                (
                    this.Local == input.Local ||

                    this.Local.Equals(input.Local)
                ) &&
                (
                    this.MaxTtl == input.MaxTtl ||
                    (this.MaxTtl != null &&
                    this.MaxTtl.Equals(input.MaxTtl))

                ) &&
                (
                    this.NodeIdentities == input.NodeIdentities ||
                    this.NodeIdentities != null &&
                    input.NodeIdentities != null &&
                    this.NodeIdentities.SequenceEqual(input.NodeIdentities)
                ) &&
                (
                    this.Partition == input.Partition ||
                    (this.Partition != null &&
                    this.Partition.Equals(input.Partition))

                ) &&
                (
                    this.Policies == input.Policies ||
                    this.Policies != null &&
                    input.Policies != null &&
                    this.Policies.SequenceEqual(input.Policies)
                ) &&
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))

                ) &&
                (
                    this.ServiceIdentities == input.ServiceIdentities ||
                    this.ServiceIdentities != null &&
                    input.ServiceIdentities != null &&
                    this.ServiceIdentities.SequenceEqual(input.ServiceIdentities)
                ) &&
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))

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

                if (this.ConsulNamespace != null)
                {
                    hashCode = (hashCode * 59) + this.ConsulNamespace.GetHashCode();
                }

                if (this.ConsulPolicies != null)
                {
                    hashCode = (hashCode * 59) + this.ConsulPolicies.GetHashCode();
                }

                if (this.ConsulRoles != null)
                {
                    hashCode = (hashCode * 59) + this.ConsulRoles.GetHashCode();
                }

                if (this.Lease != null)
                {
                    hashCode = (hashCode * 59) + this.Lease.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Local.GetHashCode();
                if (this.MaxTtl != null)
                {
                    hashCode = (hashCode * 59) + this.MaxTtl.GetHashCode();
                }

                if (this.NodeIdentities != null)
                {
                    hashCode = (hashCode * 59) + this.NodeIdentities.GetHashCode();
                }

                if (this.Partition != null)
                {
                    hashCode = (hashCode * 59) + this.Partition.GetHashCode();
                }

                if (this.Policies != null)
                {
                    hashCode = (hashCode * 59) + this.Policies.GetHashCode();
                }

                if (this.Policy != null)
                {
                    hashCode = (hashCode * 59) + this.Policy.GetHashCode();
                }

                if (this.ServiceIdentities != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceIdentities.GetHashCode();
                }

                if (this.TokenType != null)
                {
                    hashCode = (hashCode * 59) + this.TokenType.GetHashCode();
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
