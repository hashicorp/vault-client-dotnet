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
        /// <param name="consulNamespace">Indicates which namespace that the token will be created within. Defaults to &#39;default&#39;. Available in Consul 1.7 and above..</param>
        /// <param name="consulPolicies">List of policies to attach to the token. Either \&quot;consul_policies\&quot; or \&quot;consul_roles\&quot; are required for Consul 1.5 and above, or just \&quot;consul_policies\&quot; if using Consul 1.4..</param>
        /// <param name="consulRoles">List of Consul roles to attach to the token. Either \&quot;policies\&quot; or \&quot;consul_roles\&quot; are required for Consul 1.5 and above..</param>
        /// <param name="lease">Use \&quot;ttl\&quot; instead..</param>
        /// <param name="local">Indicates that the token should not be replicated globally and instead be local to the current datacenter. Available in Consul 1.4 and above..</param>
        /// <param name="maxTtl">Max TTL for the Consul token created from the role..</param>
        /// <param name="nodeIdentities">List of Node Identities to attach to the token. Available in Consul 1.8.1 or above..</param>
        /// <param name="partition">Indicates which admin partition that the token will be created within. Defaults to &#39;default&#39;. Available in Consul 1.11 and above..</param>
        /// <param name="policies">Use \&quot;consul_policies\&quot; instead..</param>
        /// <param name="policy">Policy document, base64 encoded. Required for &#39;client&#39; tokens. Required for Consul pre-1.4..</param>
        /// <param name="serviceIdentities">List of Service Identities to attach to the token, separated by semicolons. Available in Consul 1.5 or above..</param>
        /// <param name="tokenType">Which type of token to create: &#39;client&#39; or &#39;management&#39;. If a &#39;management&#39; token, the \&quot;policy\&quot;, \&quot;policies\&quot;, and \&quot;consul_roles\&quot; parameters are not required. Defaults to &#39;client&#39;. (default to &quot;client&quot;).</param>
        /// <param name="ttl">TTL for the Consul token created from the role..</param>
        public ConsulWriteRoleRequest(string consulNamespace = default(string), List<string> consulPolicies = default(List<string>), List<string> consulRoles = default(List<string>), int lease = default(int), bool local = default(bool), int maxTtl = default(int), List<string> nodeIdentities = default(List<string>), string partition = default(string), List<string> policies = default(List<string>), string policy = default(string), List<string> serviceIdentities = default(List<string>), string tokenType = "client", int ttl = default(int))
        {
            this.ConsulNamespace = consulNamespace;
            this.ConsulPolicies = consulPolicies;
            this.ConsulRoles = consulRoles;
            this.Lease = lease;
            this.Local = local;
            this.MaxTtl = maxTtl;
            this.NodeIdentities = nodeIdentities;
            this.Partition = partition;
            this.Policies = policies;
            this.Policy = policy;
            this.ServiceIdentities = serviceIdentities;
            // use default value if no "tokenType" provided
            this.TokenType = tokenType ?? "client";
            this.Ttl = ttl;
        }

        /// <summary>
        /// Indicates which namespace that the token will be created within. Defaults to &#39;default&#39;. Available in Consul 1.7 and above.
        /// </summary>
        /// <value>Indicates which namespace that the token will be created within. Defaults to &#39;default&#39;. Available in Consul 1.7 and above.</value>
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
        [Obsolete]
        public int Lease { get; set; }

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
        public int MaxTtl { get; set; }

        /// <summary>
        /// List of Node Identities to attach to the token. Available in Consul 1.8.1 or above.
        /// </summary>
        /// <value>List of Node Identities to attach to the token. Available in Consul 1.8.1 or above.</value>
        [DataMember(Name = "node_identities", EmitDefaultValue = false)]
        public List<string> NodeIdentities { get; set; }

        /// <summary>
        /// Indicates which admin partition that the token will be created within. Defaults to &#39;default&#39;. Available in Consul 1.11 and above.
        /// </summary>
        /// <value>Indicates which admin partition that the token will be created within. Defaults to &#39;default&#39;. Available in Consul 1.11 and above.</value>
        [DataMember(Name = "partition", EmitDefaultValue = false)]
        public string Partition { get; set; }

        /// <summary>
        /// Use \&quot;consul_policies\&quot; instead.
        /// </summary>
        /// <value>Use \&quot;consul_policies\&quot; instead.</value>
        [DataMember(Name = "policies", EmitDefaultValue = false)]
        [Obsolete]
        public List<string> Policies { get; set; }

        /// <summary>
        /// Policy document, base64 encoded. Required for &#39;client&#39; tokens. Required for Consul pre-1.4.
        /// </summary>
        /// <value>Policy document, base64 encoded. Required for &#39;client&#39; tokens. Required for Consul pre-1.4.</value>
        [DataMember(Name = "policy", EmitDefaultValue = false)]
        [Obsolete]
        public string Policy { get; set; }

        /// <summary>
        /// List of Service Identities to attach to the token, separated by semicolons. Available in Consul 1.5 or above.
        /// </summary>
        /// <value>List of Service Identities to attach to the token, separated by semicolons. Available in Consul 1.5 or above.</value>
        [DataMember(Name = "service_identities", EmitDefaultValue = false)]
        public List<string> ServiceIdentities { get; set; }

        /// <summary>
        /// Which type of token to create: &#39;client&#39; or &#39;management&#39;. If a &#39;management&#39; token, the \&quot;policy\&quot;, \&quot;policies\&quot;, and \&quot;consul_roles\&quot; parameters are not required. Defaults to &#39;client&#39;.
        /// </summary>
        /// <value>Which type of token to create: &#39;client&#39; or &#39;management&#39;. If a &#39;management&#39; token, the \&quot;policy\&quot;, \&quot;policies\&quot;, and \&quot;consul_roles\&quot; parameters are not required. Defaults to &#39;client&#39;.</value>
        [DataMember(Name = "token_type", EmitDefaultValue = false)]
        [Obsolete]
        public string TokenType { get; set; }

        /// <summary>
        /// TTL for the Consul token created from the role.
        /// </summary>
        /// <value>TTL for the Consul token created from the role.</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]
        public int Ttl { get; set; }

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
                    this.Lease.Equals(input.Lease)
                ) &&
                (
                    this.Local == input.Local ||
                    this.Local.Equals(input.Local)
                ) &&
                (
                    this.MaxTtl == input.MaxTtl ||
                    this.MaxTtl.Equals(input.MaxTtl)
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
                hashCode = (hashCode * 59) + this.Lease.GetHashCode();
                hashCode = (hashCode * 59) + this.Local.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxTtl.GetHashCode();
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
