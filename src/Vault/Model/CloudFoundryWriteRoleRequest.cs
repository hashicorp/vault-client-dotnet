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
    /// CloudFoundryWriteRoleRequest
    /// </summary>
    [DataContract(Name = "CloudFoundryWriteRoleRequest")]
    public partial class CloudFoundryWriteRoleRequest : IEquatable<CloudFoundryWriteRoleRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="CloudFoundryWriteRoleRequest" /> class.
        /// </summary>

        /// <param name="BoundApplicationIds">Require that the client certificate presented has at least one of these app IDs..</param>

        /// <param name="BoundCidrs">Use \&quot;token_bound_cidrs\&quot; instead. If this and \&quot;token_bound_cidrs\&quot; are both specified, only \&quot;token_bound_cidrs\&quot; will be used..</param>

        /// <param name="BoundInstanceIds">Require that the client certificate presented has at least one of these instance IDs..</param>

        /// <param name="BoundOrganizationIds">Require that the client certificate presented has at least one of these org IDs..</param>

        /// <param name="BoundSpaceIds">Require that the client certificate presented has at least one of these space IDs..</param>

        /// <param name="DisableIpMatching">If set to true, disables the default behavior that logging in must be performed from an acceptable IP address described by the certificate presented. (default to false).</param>

        /// <param name="MaxTtl">Use \&quot;token_max_ttl\&quot; instead. If this and \&quot;token_max_ttl\&quot; are both specified, only \&quot;token_max_ttl\&quot; will be used..</param>

        /// <param name="Period">Use \&quot;token_period\&quot; instead. If this and \&quot;token_period\&quot; are both specified, only \&quot;token_period\&quot; will be used..</param>

        /// <param name="Policies">Use \&quot;token_policies\&quot; instead. If this and \&quot;token_policies\&quot; are both specified, only \&quot;token_policies\&quot; will be used..</param>

        /// <param name="TokenBoundCidrs">Comma separated string or JSON list of CIDR blocks. If set, specifies the blocks of IP addresses which are allowed to use the generated token..</param>

        /// <param name="TokenExplicitMaxTtl">If set, tokens created via this role carry an explicit maximum TTL. During renewal, the current maximum TTL values of the role and the mount are not checked for changes, and any updates to these values will have no effect on the token being renewed..</param>

        /// <param name="TokenMaxTtl">The maximum lifetime of the generated token.</param>

        /// <param name="TokenNoDefaultPolicy">If true, the &#x27;default&#x27; policy will not automatically be added to generated tokens.</param>

        /// <param name="TokenNumUses">The maximum number of times a token may be used, a value of zero means unlimited.</param>

        /// <param name="TokenPeriod">If set, tokens created via this role will have no max lifetime; instead, their renewal period will be fixed to this value. This takes an integer number of seconds, or a string duration (e.g. \&quot;24h\&quot;)..</param>

        /// <param name="TokenPolicies">Comma-separated list of policies.</param>

        /// <param name="TokenTtl">The initial ttl of the token to generate.</param>

        /// <param name="TokenType">The type of token to generate, service or batch (default to &quot;default-service&quot;).</param>

        /// <param name="Ttl">Use \&quot;token_ttl\&quot; instead. If this and \&quot;token_ttl\&quot; are both specified, only \&quot;token_ttl\&quot; will be used..</param>


        public CloudFoundryWriteRoleRequest(List<string> BoundApplicationIds = default(List<string>), List<string> BoundCidrs = default(List<string>), List<string> BoundInstanceIds = default(List<string>), List<string> BoundOrganizationIds = default(List<string>), List<string> BoundSpaceIds = default(List<string>), bool DisableIpMatching = false, string MaxTtl = default(string), string Period = default(string), List<string> Policies = default(List<string>), List<string> TokenBoundCidrs = default(List<string>), string TokenExplicitMaxTtl = default(string), string TokenMaxTtl = default(string), bool TokenNoDefaultPolicy = default(bool), int TokenNumUses = default(int), string TokenPeriod = default(string), List<string> TokenPolicies = default(List<string>), string TokenTtl = default(string), string TokenType = "default-service", string Ttl = default(string))
        {

            this.BoundApplicationIds = BoundApplicationIds;

            this.BoundCidrs = BoundCidrs;

            this.BoundInstanceIds = BoundInstanceIds;

            this.BoundOrganizationIds = BoundOrganizationIds;

            this.BoundSpaceIds = BoundSpaceIds;

            this.DisableIpMatching = DisableIpMatching;

            this.MaxTtl = MaxTtl;

            this.Period = Period;

            this.Policies = Policies;

            this.TokenBoundCidrs = TokenBoundCidrs;

            this.TokenExplicitMaxTtl = TokenExplicitMaxTtl;

            this.TokenMaxTtl = TokenMaxTtl;

            this.TokenNoDefaultPolicy = TokenNoDefaultPolicy;

            this.TokenNumUses = TokenNumUses;

            this.TokenPeriod = TokenPeriod;

            this.TokenPolicies = TokenPolicies;

            this.TokenTtl = TokenTtl;

            // use default value if no "TokenType" provided
            this.TokenType = TokenType ?? "default-service";


            this.Ttl = Ttl;

        }

        /// <summary>
        /// Require that the client certificate presented has at least one of these app IDs.
        /// </summary>
        /// <value>Require that the client certificate presented has at least one of these app IDs.</value>
        [DataMember(Name = "bound_application_ids", EmitDefaultValue = false)]

        public List<string> BoundApplicationIds { get; set; }


        /// <summary>
        /// Use \&quot;token_bound_cidrs\&quot; instead. If this and \&quot;token_bound_cidrs\&quot; are both specified, only \&quot;token_bound_cidrs\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_bound_cidrs\&quot; instead. If this and \&quot;token_bound_cidrs\&quot; are both specified, only \&quot;token_bound_cidrs\&quot; will be used.</value>
        [DataMember(Name = "bound_cidrs", EmitDefaultValue = false)]

        [Obsolete] public List<string> BoundCidrs { get; set; }


        /// <summary>
        /// Require that the client certificate presented has at least one of these instance IDs.
        /// </summary>
        /// <value>Require that the client certificate presented has at least one of these instance IDs.</value>
        [DataMember(Name = "bound_instance_ids", EmitDefaultValue = false)]

        public List<string> BoundInstanceIds { get; set; }


        /// <summary>
        /// Require that the client certificate presented has at least one of these org IDs.
        /// </summary>
        /// <value>Require that the client certificate presented has at least one of these org IDs.</value>
        [DataMember(Name = "bound_organization_ids", EmitDefaultValue = false)]

        public List<string> BoundOrganizationIds { get; set; }


        /// <summary>
        /// Require that the client certificate presented has at least one of these space IDs.
        /// </summary>
        /// <value>Require that the client certificate presented has at least one of these space IDs.</value>
        [DataMember(Name = "bound_space_ids", EmitDefaultValue = false)]

        public List<string> BoundSpaceIds { get; set; }


        /// <summary>
        /// If set to true, disables the default behavior that logging in must be performed from an acceptable IP address described by the certificate presented.
        /// </summary>
        /// <value>If set to true, disables the default behavior that logging in must be performed from an acceptable IP address described by the certificate presented.</value>
        [DataMember(Name = "disable_ip_matching", EmitDefaultValue = true)]

        public bool DisableIpMatching { get; set; }


        /// <summary>
        /// Use \&quot;token_max_ttl\&quot; instead. If this and \&quot;token_max_ttl\&quot; are both specified, only \&quot;token_max_ttl\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_max_ttl\&quot; instead. If this and \&quot;token_max_ttl\&quot; are both specified, only \&quot;token_max_ttl\&quot; will be used.</value>
        [DataMember(Name = "max_ttl", EmitDefaultValue = false)]

        [Obsolete] public string MaxTtl { get; set; }


        /// <summary>
        /// Use \&quot;token_period\&quot; instead. If this and \&quot;token_period\&quot; are both specified, only \&quot;token_period\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_period\&quot; instead. If this and \&quot;token_period\&quot; are both specified, only \&quot;token_period\&quot; will be used.</value>
        [DataMember(Name = "period", EmitDefaultValue = false)]

        [Obsolete] public string Period { get; set; }


        /// <summary>
        /// Use \&quot;token_policies\&quot; instead. If this and \&quot;token_policies\&quot; are both specified, only \&quot;token_policies\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_policies\&quot; instead. If this and \&quot;token_policies\&quot; are both specified, only \&quot;token_policies\&quot; will be used.</value>
        [DataMember(Name = "policies", EmitDefaultValue = false)]

        [Obsolete] public List<string> Policies { get; set; }


        /// <summary>
        /// Comma separated string or JSON list of CIDR blocks. If set, specifies the blocks of IP addresses which are allowed to use the generated token.
        /// </summary>
        /// <value>Comma separated string or JSON list of CIDR blocks. If set, specifies the blocks of IP addresses which are allowed to use the generated token.</value>
        [DataMember(Name = "token_bound_cidrs", EmitDefaultValue = false)]

        public List<string> TokenBoundCidrs { get; set; }


        /// <summary>
        /// If set, tokens created via this role carry an explicit maximum TTL. During renewal, the current maximum TTL values of the role and the mount are not checked for changes, and any updates to these values will have no effect on the token being renewed.
        /// </summary>
        /// <value>If set, tokens created via this role carry an explicit maximum TTL. During renewal, the current maximum TTL values of the role and the mount are not checked for changes, and any updates to these values will have no effect on the token being renewed.</value>
        [DataMember(Name = "token_explicit_max_ttl", EmitDefaultValue = false)]

        public string TokenExplicitMaxTtl { get; set; }


        /// <summary>
        /// The maximum lifetime of the generated token
        /// </summary>
        /// <value>The maximum lifetime of the generated token</value>
        [DataMember(Name = "token_max_ttl", EmitDefaultValue = false)]

        public string TokenMaxTtl { get; set; }


        /// <summary>
        /// If true, the &#x27;default&#x27; policy will not automatically be added to generated tokens
        /// </summary>
        /// <value>If true, the &#x27;default&#x27; policy will not automatically be added to generated tokens</value>
        [DataMember(Name = "token_no_default_policy", EmitDefaultValue = true)]

        public bool TokenNoDefaultPolicy { get; set; }


        /// <summary>
        /// The maximum number of times a token may be used, a value of zero means unlimited
        /// </summary>
        /// <value>The maximum number of times a token may be used, a value of zero means unlimited</value>
        [DataMember(Name = "token_num_uses", EmitDefaultValue = false)]

        public int TokenNumUses { get; set; }


        /// <summary>
        /// If set, tokens created via this role will have no max lifetime; instead, their renewal period will be fixed to this value. This takes an integer number of seconds, or a string duration (e.g. \&quot;24h\&quot;).
        /// </summary>
        /// <value>If set, tokens created via this role will have no max lifetime; instead, their renewal period will be fixed to this value. This takes an integer number of seconds, or a string duration (e.g. \&quot;24h\&quot;).</value>
        [DataMember(Name = "token_period", EmitDefaultValue = false)]

        public string TokenPeriod { get; set; }


        /// <summary>
        /// Comma-separated list of policies
        /// </summary>
        /// <value>Comma-separated list of policies</value>
        [DataMember(Name = "token_policies", EmitDefaultValue = false)]

        public List<string> TokenPolicies { get; set; }


        /// <summary>
        /// The initial ttl of the token to generate
        /// </summary>
        /// <value>The initial ttl of the token to generate</value>
        [DataMember(Name = "token_ttl", EmitDefaultValue = false)]

        public string TokenTtl { get; set; }


        /// <summary>
        /// The type of token to generate, service or batch
        /// </summary>
        /// <value>The type of token to generate, service or batch</value>
        [DataMember(Name = "token_type", EmitDefaultValue = false)]

        public string TokenType { get; set; }


        /// <summary>
        /// Use \&quot;token_ttl\&quot; instead. If this and \&quot;token_ttl\&quot; are both specified, only \&quot;token_ttl\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_ttl\&quot; instead. If this and \&quot;token_ttl\&quot; are both specified, only \&quot;token_ttl\&quot; will be used.</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]

        [Obsolete] public string Ttl { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CloudFoundryWriteRoleRequest {\n");
            sb.Append("  BoundApplicationIds: ").Append(BoundApplicationIds).Append("\n");
            sb.Append("  BoundCidrs: ").Append(BoundCidrs).Append("\n");
            sb.Append("  BoundInstanceIds: ").Append(BoundInstanceIds).Append("\n");
            sb.Append("  BoundOrganizationIds: ").Append(BoundOrganizationIds).Append("\n");
            sb.Append("  BoundSpaceIds: ").Append(BoundSpaceIds).Append("\n");
            sb.Append("  DisableIpMatching: ").Append(DisableIpMatching).Append("\n");
            sb.Append("  MaxTtl: ").Append(MaxTtl).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
            sb.Append("  TokenBoundCidrs: ").Append(TokenBoundCidrs).Append("\n");
            sb.Append("  TokenExplicitMaxTtl: ").Append(TokenExplicitMaxTtl).Append("\n");
            sb.Append("  TokenMaxTtl: ").Append(TokenMaxTtl).Append("\n");
            sb.Append("  TokenNoDefaultPolicy: ").Append(TokenNoDefaultPolicy).Append("\n");
            sb.Append("  TokenNumUses: ").Append(TokenNumUses).Append("\n");
            sb.Append("  TokenPeriod: ").Append(TokenPeriod).Append("\n");
            sb.Append("  TokenPolicies: ").Append(TokenPolicies).Append("\n");
            sb.Append("  TokenTtl: ").Append(TokenTtl).Append("\n");
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
            return this.Equals(input as CloudFoundryWriteRoleRequest);
        }

        /// <summary>
        /// Returns true if CloudFoundryWriteRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudFoundryWriteRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudFoundryWriteRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.BoundApplicationIds == input.BoundApplicationIds ||
                    this.BoundApplicationIds != null &&
                    input.BoundApplicationIds != null &&
                    this.BoundApplicationIds.SequenceEqual(input.BoundApplicationIds)
                ) &&
                (
                    this.BoundCidrs == input.BoundCidrs ||
                    this.BoundCidrs != null &&
                    input.BoundCidrs != null &&
                    this.BoundCidrs.SequenceEqual(input.BoundCidrs)
                ) &&
                (
                    this.BoundInstanceIds == input.BoundInstanceIds ||
                    this.BoundInstanceIds != null &&
                    input.BoundInstanceIds != null &&
                    this.BoundInstanceIds.SequenceEqual(input.BoundInstanceIds)
                ) &&
                (
                    this.BoundOrganizationIds == input.BoundOrganizationIds ||
                    this.BoundOrganizationIds != null &&
                    input.BoundOrganizationIds != null &&
                    this.BoundOrganizationIds.SequenceEqual(input.BoundOrganizationIds)
                ) &&
                (
                    this.BoundSpaceIds == input.BoundSpaceIds ||
                    this.BoundSpaceIds != null &&
                    input.BoundSpaceIds != null &&
                    this.BoundSpaceIds.SequenceEqual(input.BoundSpaceIds)
                ) &&
                (
                    this.DisableIpMatching == input.DisableIpMatching ||

                    this.DisableIpMatching.Equals(input.DisableIpMatching)
                ) &&
                (
                    this.MaxTtl == input.MaxTtl ||
                    (this.MaxTtl != null &&
                    this.MaxTtl.Equals(input.MaxTtl))

                ) &&
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))

                ) &&
                (
                    this.Policies == input.Policies ||
                    this.Policies != null &&
                    input.Policies != null &&
                    this.Policies.SequenceEqual(input.Policies)
                ) &&
                (
                    this.TokenBoundCidrs == input.TokenBoundCidrs ||
                    this.TokenBoundCidrs != null &&
                    input.TokenBoundCidrs != null &&
                    this.TokenBoundCidrs.SequenceEqual(input.TokenBoundCidrs)
                ) &&
                (
                    this.TokenExplicitMaxTtl == input.TokenExplicitMaxTtl ||
                    (this.TokenExplicitMaxTtl != null &&
                    this.TokenExplicitMaxTtl.Equals(input.TokenExplicitMaxTtl))

                ) &&
                (
                    this.TokenMaxTtl == input.TokenMaxTtl ||
                    (this.TokenMaxTtl != null &&
                    this.TokenMaxTtl.Equals(input.TokenMaxTtl))

                ) &&
                (
                    this.TokenNoDefaultPolicy == input.TokenNoDefaultPolicy ||

                    this.TokenNoDefaultPolicy.Equals(input.TokenNoDefaultPolicy)
                ) &&
                (
                    this.TokenNumUses == input.TokenNumUses ||

                    this.TokenNumUses.Equals(input.TokenNumUses)
                ) &&
                (
                    this.TokenPeriod == input.TokenPeriod ||
                    (this.TokenPeriod != null &&
                    this.TokenPeriod.Equals(input.TokenPeriod))

                ) &&
                (
                    this.TokenPolicies == input.TokenPolicies ||
                    this.TokenPolicies != null &&
                    input.TokenPolicies != null &&
                    this.TokenPolicies.SequenceEqual(input.TokenPolicies)
                ) &&
                (
                    this.TokenTtl == input.TokenTtl ||
                    (this.TokenTtl != null &&
                    this.TokenTtl.Equals(input.TokenTtl))

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

                if (this.BoundApplicationIds != null)
                {
                    hashCode = (hashCode * 59) + this.BoundApplicationIds.GetHashCode();
                }

                if (this.BoundCidrs != null)
                {
                    hashCode = (hashCode * 59) + this.BoundCidrs.GetHashCode();
                }

                if (this.BoundInstanceIds != null)
                {
                    hashCode = (hashCode * 59) + this.BoundInstanceIds.GetHashCode();
                }

                if (this.BoundOrganizationIds != null)
                {
                    hashCode = (hashCode * 59) + this.BoundOrganizationIds.GetHashCode();
                }

                if (this.BoundSpaceIds != null)
                {
                    hashCode = (hashCode * 59) + this.BoundSpaceIds.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.DisableIpMatching.GetHashCode();
                if (this.MaxTtl != null)
                {
                    hashCode = (hashCode * 59) + this.MaxTtl.GetHashCode();
                }

                if (this.Period != null)
                {
                    hashCode = (hashCode * 59) + this.Period.GetHashCode();
                }

                if (this.Policies != null)
                {
                    hashCode = (hashCode * 59) + this.Policies.GetHashCode();
                }

                if (this.TokenBoundCidrs != null)
                {
                    hashCode = (hashCode * 59) + this.TokenBoundCidrs.GetHashCode();
                }

                if (this.TokenExplicitMaxTtl != null)
                {
                    hashCode = (hashCode * 59) + this.TokenExplicitMaxTtl.GetHashCode();
                }

                if (this.TokenMaxTtl != null)
                {
                    hashCode = (hashCode * 59) + this.TokenMaxTtl.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.TokenNoDefaultPolicy.GetHashCode();

                hashCode = (hashCode * 59) + this.TokenNumUses.GetHashCode();
                if (this.TokenPeriod != null)
                {
                    hashCode = (hashCode * 59) + this.TokenPeriod.GetHashCode();
                }

                if (this.TokenPolicies != null)
                {
                    hashCode = (hashCode * 59) + this.TokenPolicies.GetHashCode();
                }

                if (this.TokenTtl != null)
                {
                    hashCode = (hashCode * 59) + this.TokenTtl.GetHashCode();
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
