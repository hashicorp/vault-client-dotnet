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
    /// GoogleCloudWriteRoleRequest
    /// </summary>
    [DataContract(Name = "GoogleCloudWriteRoleRequest")]
    public partial class GoogleCloudWriteRoleRequest : IEquatable<GoogleCloudWriteRoleRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleCloudWriteRoleRequest" /> class.
        /// </summary>
        /// <param name="addGroupAliases">If true, will add group aliases to auth tokens generated under this role. This will add the full list of ancestors (projects, folders, organizations) for the given entity&#39;s project. Requires IAM permission &#x60;resourcemanager.projects.get&#x60; on this project. (default to false).</param>
        /// <param name="allowGceInference">&#39;iam&#39; roles only. If false, Vault will not not allow GCE instances to login in against this role (default to true).</param>
        /// <param name="boundInstanceGroup">Deprecated: use \&quot;bound_instance_groups\&quot; instead..</param>
        /// <param name="boundInstanceGroups">Comma-separated list of permitted instance groups to which the GCE instance must belong. This option only applies to \&quot;gce\&quot; roles..</param>
        /// <param name="boundLabels">Comma-separated list of GCP labels formatted as\&quot;key:value\&quot; strings that must be present on the GCE instance in order to authenticate. This option only applies to \&quot;gce\&quot; roles..</param>
        /// <param name="boundProjects">GCP Projects that authenticating entities must belong to..</param>
        /// <param name="boundRegion">Deprecated: use \&quot;bound_regions\&quot; instead..</param>
        /// <param name="boundRegions">Comma-separated list of permitted regions to which the GCE instance must belong. If a group is provided, it is assumed to be a regional group. If \&quot;zone\&quot; is provided, this option is ignored. This can be a self-link or region name. This option only applies to \&quot;gce\&quot; roles..</param>
        /// <param name="boundServiceAccounts">Can be set for both &#39;iam&#39; and &#39;gce&#39; roles (required for &#39;iam&#39;). A comma-seperated list of authorized service accounts. If the single value \&quot;*\&quot; is given, this is assumed to be all service accounts under the role&#39;s project. If this is set on a GCE role, the inferred service account from the instance metadata token will be used..</param>
        /// <param name="boundZone">Deprecated: use \&quot;bound_zones\&quot; instead..</param>
        /// <param name="boundZones">Comma-separated list of permitted zones to which the GCE instance must belong. If a group is provided, it is assumed to be a zonal group. This can be a self-link or zone name. This option only applies to \&quot;gce\&quot; roles..</param>
        /// <param name="maxJwtExp">Currently enabled for &#39;iam&#39; only. Duration in seconds from time of validation that a JWT must expire within. (default to 900).</param>
        /// <param name="maxTtl">Use \&quot;token_max_ttl\&quot; instead. If this and \&quot;token_max_ttl\&quot; are both specified, only \&quot;token_max_ttl\&quot; will be used..</param>
        /// <param name="period">Use \&quot;token_period\&quot; instead. If this and \&quot;token_period\&quot; are both specified, only \&quot;token_period\&quot; will be used..</param>
        /// <param name="policies">Use \&quot;token_policies\&quot; instead. If this and \&quot;token_policies\&quot; are both specified, only \&quot;token_policies\&quot; will be used..</param>
        /// <param name="projectId">Deprecated: use \&quot;bound_projects\&quot; instead.</param>
        /// <param name="serviceAccounts">Deprecated: use \&quot;bound_service_accounts\&quot; instead..</param>
        /// <param name="tokenBoundCidrs">Comma separated string or JSON list of CIDR blocks. If set, specifies the blocks of IP addresses which are allowed to use the generated token..</param>
        /// <param name="tokenExplicitMaxTtl">If set, tokens created via this role carry an explicit maximum TTL. During renewal, the current maximum TTL values of the role and the mount are not checked for changes, and any updates to these values will have no effect on the token being renewed..</param>
        /// <param name="tokenMaxTtl">The maximum lifetime of the generated token.</param>
        /// <param name="tokenNoDefaultPolicy">If true, the &#39;default&#39; policy will not automatically be added to generated tokens.</param>
        /// <param name="tokenNumUses">The maximum number of times a token may be used, a value of zero means unlimited.</param>
        /// <param name="tokenPeriod">If set, tokens created via this role will have no max lifetime; instead, their renewal period will be fixed to this value. This takes an integer number of seconds, or a string duration (e.g. \&quot;24h\&quot;)..</param>
        /// <param name="tokenPolicies">Comma-separated list of policies.</param>
        /// <param name="tokenTtl">The initial ttl of the token to generate.</param>
        /// <param name="tokenType">The type of token to generate, service or batch (default to &quot;default-service&quot;).</param>
        /// <param name="ttl">Use \&quot;token_ttl\&quot; instead. If this and \&quot;token_ttl\&quot; are both specified, only \&quot;token_ttl\&quot; will be used..</param>
        /// <param name="type">Type of the role. Currently supported: iam, gce.</param>
        public GoogleCloudWriteRoleRequest(bool addGroupAliases = false, bool allowGceInference = true, string boundInstanceGroup = default(string), List<string> boundInstanceGroups = default(List<string>), List<string> boundLabels = default(List<string>), List<string> boundProjects = default(List<string>), string boundRegion = default(string), List<string> boundRegions = default(List<string>), List<string> boundServiceAccounts = default(List<string>), string boundZone = default(string), List<string> boundZones = default(List<string>), int maxJwtExp = 900, int maxTtl = default(int), int period = default(int), List<string> policies = default(List<string>), string projectId = default(string), List<string> serviceAccounts = default(List<string>), List<string> tokenBoundCidrs = default(List<string>), int tokenExplicitMaxTtl = default(int), int tokenMaxTtl = default(int), bool tokenNoDefaultPolicy = default(bool), int tokenNumUses = default(int), int tokenPeriod = default(int), List<string> tokenPolicies = default(List<string>), int tokenTtl = default(int), string tokenType = "default-service", int ttl = default(int), string type = default(string))
        {
            this.AddGroupAliases = addGroupAliases;
            this.AllowGceInference = allowGceInference;
            this.BoundInstanceGroup = boundInstanceGroup;
            this.BoundInstanceGroups = boundInstanceGroups;
            this.BoundLabels = boundLabels;
            this.BoundProjects = boundProjects;
            this.BoundRegion = boundRegion;
            this.BoundRegions = boundRegions;
            this.BoundServiceAccounts = boundServiceAccounts;
            this.BoundZone = boundZone;
            this.BoundZones = boundZones;
            this.MaxJwtExp = maxJwtExp;
            this.MaxTtl = maxTtl;
            this.Period = period;
            this.Policies = policies;
            this.ProjectId = projectId;
            this.ServiceAccounts = serviceAccounts;
            this.TokenBoundCidrs = tokenBoundCidrs;
            this.TokenExplicitMaxTtl = tokenExplicitMaxTtl;
            this.TokenMaxTtl = tokenMaxTtl;
            this.TokenNoDefaultPolicy = tokenNoDefaultPolicy;
            this.TokenNumUses = tokenNumUses;
            this.TokenPeriod = tokenPeriod;
            this.TokenPolicies = tokenPolicies;
            this.TokenTtl = tokenTtl;
            // use default value if no "tokenType" provided
            this.TokenType = tokenType ?? "default-service";
            this.Ttl = ttl;
            this.Type = type;
        }

        /// <summary>
        /// If true, will add group aliases to auth tokens generated under this role. This will add the full list of ancestors (projects, folders, organizations) for the given entity&#39;s project. Requires IAM permission &#x60;resourcemanager.projects.get&#x60; on this project.
        /// </summary>
        /// <value>If true, will add group aliases to auth tokens generated under this role. This will add the full list of ancestors (projects, folders, organizations) for the given entity&#39;s project. Requires IAM permission &#x60;resourcemanager.projects.get&#x60; on this project.</value>
        [DataMember(Name = "add_group_aliases", EmitDefaultValue = true)]
        public bool AddGroupAliases { get; set; }

        /// <summary>
        /// &#39;iam&#39; roles only. If false, Vault will not not allow GCE instances to login in against this role
        /// </summary>
        /// <value>&#39;iam&#39; roles only. If false, Vault will not not allow GCE instances to login in against this role</value>
        [DataMember(Name = "allow_gce_inference", EmitDefaultValue = true)]
        public bool AllowGceInference { get; set; }

        /// <summary>
        /// Deprecated: use \&quot;bound_instance_groups\&quot; instead.
        /// </summary>
        /// <value>Deprecated: use \&quot;bound_instance_groups\&quot; instead.</value>
        [DataMember(Name = "bound_instance_group", EmitDefaultValue = false)]
        public string BoundInstanceGroup { get; set; }

        /// <summary>
        /// Comma-separated list of permitted instance groups to which the GCE instance must belong. This option only applies to \&quot;gce\&quot; roles.
        /// </summary>
        /// <value>Comma-separated list of permitted instance groups to which the GCE instance must belong. This option only applies to \&quot;gce\&quot; roles.</value>
        [DataMember(Name = "bound_instance_groups", EmitDefaultValue = false)]
        public List<string> BoundInstanceGroups { get; set; }

        /// <summary>
        /// Comma-separated list of GCP labels formatted as\&quot;key:value\&quot; strings that must be present on the GCE instance in order to authenticate. This option only applies to \&quot;gce\&quot; roles.
        /// </summary>
        /// <value>Comma-separated list of GCP labels formatted as\&quot;key:value\&quot; strings that must be present on the GCE instance in order to authenticate. This option only applies to \&quot;gce\&quot; roles.</value>
        [DataMember(Name = "bound_labels", EmitDefaultValue = false)]
        public List<string> BoundLabels { get; set; }

        /// <summary>
        /// GCP Projects that authenticating entities must belong to.
        /// </summary>
        /// <value>GCP Projects that authenticating entities must belong to.</value>
        [DataMember(Name = "bound_projects", EmitDefaultValue = false)]
        public List<string> BoundProjects { get; set; }

        /// <summary>
        /// Deprecated: use \&quot;bound_regions\&quot; instead.
        /// </summary>
        /// <value>Deprecated: use \&quot;bound_regions\&quot; instead.</value>
        [DataMember(Name = "bound_region", EmitDefaultValue = false)]
        public string BoundRegion { get; set; }

        /// <summary>
        /// Comma-separated list of permitted regions to which the GCE instance must belong. If a group is provided, it is assumed to be a regional group. If \&quot;zone\&quot; is provided, this option is ignored. This can be a self-link or region name. This option only applies to \&quot;gce\&quot; roles.
        /// </summary>
        /// <value>Comma-separated list of permitted regions to which the GCE instance must belong. If a group is provided, it is assumed to be a regional group. If \&quot;zone\&quot; is provided, this option is ignored. This can be a self-link or region name. This option only applies to \&quot;gce\&quot; roles.</value>
        [DataMember(Name = "bound_regions", EmitDefaultValue = false)]
        public List<string> BoundRegions { get; set; }

        /// <summary>
        /// Can be set for both &#39;iam&#39; and &#39;gce&#39; roles (required for &#39;iam&#39;). A comma-seperated list of authorized service accounts. If the single value \&quot;*\&quot; is given, this is assumed to be all service accounts under the role&#39;s project. If this is set on a GCE role, the inferred service account from the instance metadata token will be used.
        /// </summary>
        /// <value>Can be set for both &#39;iam&#39; and &#39;gce&#39; roles (required for &#39;iam&#39;). A comma-seperated list of authorized service accounts. If the single value \&quot;*\&quot; is given, this is assumed to be all service accounts under the role&#39;s project. If this is set on a GCE role, the inferred service account from the instance metadata token will be used.</value>
        [DataMember(Name = "bound_service_accounts", EmitDefaultValue = false)]
        public List<string> BoundServiceAccounts { get; set; }

        /// <summary>
        /// Deprecated: use \&quot;bound_zones\&quot; instead.
        /// </summary>
        /// <value>Deprecated: use \&quot;bound_zones\&quot; instead.</value>
        [DataMember(Name = "bound_zone", EmitDefaultValue = false)]
        public string BoundZone { get; set; }

        /// <summary>
        /// Comma-separated list of permitted zones to which the GCE instance must belong. If a group is provided, it is assumed to be a zonal group. This can be a self-link or zone name. This option only applies to \&quot;gce\&quot; roles.
        /// </summary>
        /// <value>Comma-separated list of permitted zones to which the GCE instance must belong. If a group is provided, it is assumed to be a zonal group. This can be a self-link or zone name. This option only applies to \&quot;gce\&quot; roles.</value>
        [DataMember(Name = "bound_zones", EmitDefaultValue = false)]
        public List<string> BoundZones { get; set; }

        /// <summary>
        /// Currently enabled for &#39;iam&#39; only. Duration in seconds from time of validation that a JWT must expire within.
        /// </summary>
        /// <value>Currently enabled for &#39;iam&#39; only. Duration in seconds from time of validation that a JWT must expire within.</value>
        [DataMember(Name = "max_jwt_exp", EmitDefaultValue = false)]
        public int MaxJwtExp { get; set; }

        /// <summary>
        /// Use \&quot;token_max_ttl\&quot; instead. If this and \&quot;token_max_ttl\&quot; are both specified, only \&quot;token_max_ttl\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_max_ttl\&quot; instead. If this and \&quot;token_max_ttl\&quot; are both specified, only \&quot;token_max_ttl\&quot; will be used.</value>
        [DataMember(Name = "max_ttl", EmitDefaultValue = false)]
        [Obsolete]
        public int MaxTtl { get; set; }

        /// <summary>
        /// Use \&quot;token_period\&quot; instead. If this and \&quot;token_period\&quot; are both specified, only \&quot;token_period\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_period\&quot; instead. If this and \&quot;token_period\&quot; are both specified, only \&quot;token_period\&quot; will be used.</value>
        [DataMember(Name = "period", EmitDefaultValue = false)]
        [Obsolete]
        public int Period { get; set; }

        /// <summary>
        /// Use \&quot;token_policies\&quot; instead. If this and \&quot;token_policies\&quot; are both specified, only \&quot;token_policies\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_policies\&quot; instead. If this and \&quot;token_policies\&quot; are both specified, only \&quot;token_policies\&quot; will be used.</value>
        [DataMember(Name = "policies", EmitDefaultValue = false)]
        [Obsolete]
        public List<string> Policies { get; set; }

        /// <summary>
        /// Deprecated: use \&quot;bound_projects\&quot; instead
        /// </summary>
        /// <value>Deprecated: use \&quot;bound_projects\&quot; instead</value>
        [DataMember(Name = "project_id", EmitDefaultValue = false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Deprecated: use \&quot;bound_service_accounts\&quot; instead.
        /// </summary>
        /// <value>Deprecated: use \&quot;bound_service_accounts\&quot; instead.</value>
        [DataMember(Name = "service_accounts", EmitDefaultValue = false)]
        public List<string> ServiceAccounts { get; set; }

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
        public int TokenExplicitMaxTtl { get; set; }

        /// <summary>
        /// The maximum lifetime of the generated token
        /// </summary>
        /// <value>The maximum lifetime of the generated token</value>
        [DataMember(Name = "token_max_ttl", EmitDefaultValue = false)]
        public int TokenMaxTtl { get; set; }

        /// <summary>
        /// If true, the &#39;default&#39; policy will not automatically be added to generated tokens
        /// </summary>
        /// <value>If true, the &#39;default&#39; policy will not automatically be added to generated tokens</value>
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
        public int TokenPeriod { get; set; }

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
        public int TokenTtl { get; set; }

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
        [Obsolete]
        public int Ttl { get; set; }

        /// <summary>
        /// Type of the role. Currently supported: iam, gce
        /// </summary>
        /// <value>Type of the role. Currently supported: iam, gce</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoogleCloudWriteRoleRequest {\n");
            sb.Append("  AddGroupAliases: ").Append(AddGroupAliases).Append("\n");
            sb.Append("  AllowGceInference: ").Append(AllowGceInference).Append("\n");
            sb.Append("  BoundInstanceGroup: ").Append(BoundInstanceGroup).Append("\n");
            sb.Append("  BoundInstanceGroups: ").Append(BoundInstanceGroups).Append("\n");
            sb.Append("  BoundLabels: ").Append(BoundLabels).Append("\n");
            sb.Append("  BoundProjects: ").Append(BoundProjects).Append("\n");
            sb.Append("  BoundRegion: ").Append(BoundRegion).Append("\n");
            sb.Append("  BoundRegions: ").Append(BoundRegions).Append("\n");
            sb.Append("  BoundServiceAccounts: ").Append(BoundServiceAccounts).Append("\n");
            sb.Append("  BoundZone: ").Append(BoundZone).Append("\n");
            sb.Append("  BoundZones: ").Append(BoundZones).Append("\n");
            sb.Append("  MaxJwtExp: ").Append(MaxJwtExp).Append("\n");
            sb.Append("  MaxTtl: ").Append(MaxTtl).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  ServiceAccounts: ").Append(ServiceAccounts).Append("\n");
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
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as GoogleCloudWriteRoleRequest);
        }

        /// <summary>
        /// Returns true if GoogleCloudWriteRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleCloudWriteRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleCloudWriteRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AddGroupAliases == input.AddGroupAliases ||
                    this.AddGroupAliases.Equals(input.AddGroupAliases)
                ) &&
                (
                    this.AllowGceInference == input.AllowGceInference ||
                    this.AllowGceInference.Equals(input.AllowGceInference)
                ) &&
                (
                    this.BoundInstanceGroup == input.BoundInstanceGroup ||
                    (this.BoundInstanceGroup != null &&
                    this.BoundInstanceGroup.Equals(input.BoundInstanceGroup))
                ) &&
                (
                    this.BoundInstanceGroups == input.BoundInstanceGroups ||
                    this.BoundInstanceGroups != null &&
                    input.BoundInstanceGroups != null &&
                    this.BoundInstanceGroups.SequenceEqual(input.BoundInstanceGroups)
                ) &&
                (
                    this.BoundLabels == input.BoundLabels ||
                    this.BoundLabels != null &&
                    input.BoundLabels != null &&
                    this.BoundLabels.SequenceEqual(input.BoundLabels)
                ) &&
                (
                    this.BoundProjects == input.BoundProjects ||
                    this.BoundProjects != null &&
                    input.BoundProjects != null &&
                    this.BoundProjects.SequenceEqual(input.BoundProjects)
                ) &&
                (
                    this.BoundRegion == input.BoundRegion ||
                    (this.BoundRegion != null &&
                    this.BoundRegion.Equals(input.BoundRegion))
                ) &&
                (
                    this.BoundRegions == input.BoundRegions ||
                    this.BoundRegions != null &&
                    input.BoundRegions != null &&
                    this.BoundRegions.SequenceEqual(input.BoundRegions)
                ) &&
                (
                    this.BoundServiceAccounts == input.BoundServiceAccounts ||
                    this.BoundServiceAccounts != null &&
                    input.BoundServiceAccounts != null &&
                    this.BoundServiceAccounts.SequenceEqual(input.BoundServiceAccounts)
                ) &&
                (
                    this.BoundZone == input.BoundZone ||
                    (this.BoundZone != null &&
                    this.BoundZone.Equals(input.BoundZone))
                ) &&
                (
                    this.BoundZones == input.BoundZones ||
                    this.BoundZones != null &&
                    input.BoundZones != null &&
                    this.BoundZones.SequenceEqual(input.BoundZones)
                ) &&
                (
                    this.MaxJwtExp == input.MaxJwtExp ||
                    this.MaxJwtExp.Equals(input.MaxJwtExp)
                ) &&
                (
                    this.MaxTtl == input.MaxTtl ||
                    this.MaxTtl.Equals(input.MaxTtl)
                ) &&
                (
                    this.Period == input.Period ||
                    this.Period.Equals(input.Period)
                ) &&
                (
                    this.Policies == input.Policies ||
                    this.Policies != null &&
                    input.Policies != null &&
                    this.Policies.SequenceEqual(input.Policies)
                ) &&
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) &&
                (
                    this.ServiceAccounts == input.ServiceAccounts ||
                    this.ServiceAccounts != null &&
                    input.ServiceAccounts != null &&
                    this.ServiceAccounts.SequenceEqual(input.ServiceAccounts)
                ) &&
                (
                    this.TokenBoundCidrs == input.TokenBoundCidrs ||
                    this.TokenBoundCidrs != null &&
                    input.TokenBoundCidrs != null &&
                    this.TokenBoundCidrs.SequenceEqual(input.TokenBoundCidrs)
                ) &&
                (
                    this.TokenExplicitMaxTtl == input.TokenExplicitMaxTtl ||
                    this.TokenExplicitMaxTtl.Equals(input.TokenExplicitMaxTtl)
                ) &&
                (
                    this.TokenMaxTtl == input.TokenMaxTtl ||
                    this.TokenMaxTtl.Equals(input.TokenMaxTtl)
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
                    this.TokenPeriod.Equals(input.TokenPeriod)
                ) &&
                (
                    this.TokenPolicies == input.TokenPolicies ||
                    this.TokenPolicies != null &&
                    input.TokenPolicies != null &&
                    this.TokenPolicies.SequenceEqual(input.TokenPolicies)
                ) &&
                (
                    this.TokenTtl == input.TokenTtl ||
                    this.TokenTtl.Equals(input.TokenTtl)
                ) &&
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
                ) &&
                (
                    this.Ttl == input.Ttl ||
                    this.Ttl.Equals(input.Ttl)
                ) &&
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                hashCode = (hashCode * 59) + this.AddGroupAliases.GetHashCode();
                hashCode = (hashCode * 59) + this.AllowGceInference.GetHashCode();
                if (this.BoundInstanceGroup != null)
                {
                    hashCode = (hashCode * 59) + this.BoundInstanceGroup.GetHashCode();
                }
                if (this.BoundInstanceGroups != null)
                {
                    hashCode = (hashCode * 59) + this.BoundInstanceGroups.GetHashCode();
                }
                if (this.BoundLabels != null)
                {
                    hashCode = (hashCode * 59) + this.BoundLabels.GetHashCode();
                }
                if (this.BoundProjects != null)
                {
                    hashCode = (hashCode * 59) + this.BoundProjects.GetHashCode();
                }
                if (this.BoundRegion != null)
                {
                    hashCode = (hashCode * 59) + this.BoundRegion.GetHashCode();
                }
                if (this.BoundRegions != null)
                {
                    hashCode = (hashCode * 59) + this.BoundRegions.GetHashCode();
                }
                if (this.BoundServiceAccounts != null)
                {
                    hashCode = (hashCode * 59) + this.BoundServiceAccounts.GetHashCode();
                }
                if (this.BoundZone != null)
                {
                    hashCode = (hashCode * 59) + this.BoundZone.GetHashCode();
                }
                if (this.BoundZones != null)
                {
                    hashCode = (hashCode * 59) + this.BoundZones.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxJwtExp.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxTtl.GetHashCode();
                hashCode = (hashCode * 59) + this.Period.GetHashCode();
                if (this.Policies != null)
                {
                    hashCode = (hashCode * 59) + this.Policies.GetHashCode();
                }
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                if (this.ServiceAccounts != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceAccounts.GetHashCode();
                }
                if (this.TokenBoundCidrs != null)
                {
                    hashCode = (hashCode * 59) + this.TokenBoundCidrs.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TokenExplicitMaxTtl.GetHashCode();
                hashCode = (hashCode * 59) + this.TokenMaxTtl.GetHashCode();
                hashCode = (hashCode * 59) + this.TokenNoDefaultPolicy.GetHashCode();
                hashCode = (hashCode * 59) + this.TokenNumUses.GetHashCode();
                hashCode = (hashCode * 59) + this.TokenPeriod.GetHashCode();
                if (this.TokenPolicies != null)
                {
                    hashCode = (hashCode * 59) + this.TokenPolicies.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TokenTtl.GetHashCode();
                if (this.TokenType != null)
                {
                    hashCode = (hashCode * 59) + this.TokenType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
