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
    /// AwsWriteAuthRoleRequest
    /// </summary>
    [DataContract(Name = "AwsWriteAuthRoleRequest")]
    public partial class AwsWriteAuthRoleRequest : IEquatable<AwsWriteAuthRoleRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="AwsWriteAuthRoleRequest" /> class.
        /// </summary>

        /// <param name="AllowInstanceMigration">If set, allows migration of the underlying instance where the client resides. This keys off of pendingTime in the metadata document, so essentially, this disables the client nonce check whenever the instance is migrated to a new host and pendingTime is newer than the previously-remembered time. Use with caution. This is only checked when auth_type is ec2. (default to false).</param>

        /// <param name="AuthType">The auth_type permitted to authenticate to this role. Must be one of iam or ec2 and cannot be changed after role creation..</param>

        /// <param name="BoundAccountId">If set, defines a constraint on the EC2 instances that the account ID in its identity document to match one of the IDs specified by this parameter. This is only applicable when auth_type is ec2 or inferred_entity_type is ec2_instance..</param>

        /// <param name="BoundAmiId">If set, defines a constraint on the EC2 instances that they should be using one of the AMI IDs specified by this parameter. This is only applicable when auth_type is ec2 or inferred_entity_type is ec2_instance..</param>

        /// <param name="BoundEc2InstanceId">If set, defines a constraint on the EC2 instances to have one of the given instance IDs. Can be a list or comma-separated string of EC2 instance IDs. This is only applicable when auth_type is ec2 or inferred_entity_type is ec2_instance..</param>

        /// <param name="BoundIamInstanceProfileArn">If set, defines a constraint on the EC2 instances to be associated with an IAM instance profile ARN which has a prefix that matches one of the values specified by this parameter. The value is prefix-matched (as though it were a glob ending in &#x27;*&#x27;). This is only applicable when auth_type is ec2 or inferred_entity_type is ec2_instance..</param>

        /// <param name="BoundIamPrincipalArn">ARN of the IAM principals to bind to this role. Only applicable when auth_type is iam..</param>

        /// <param name="BoundIamRoleArn">If set, defines a constraint on the authenticating EC2 instance that it must match one of the IAM role ARNs specified by this parameter. The value is prefix-matched (as though it were a glob ending in &#x27;*&#x27;). The configured IAM user or EC2 instance role must be allowed to execute the &#x27;iam:GetInstanceProfile&#x27; action if this is specified. This is only applicable when auth_type is ec2 or inferred_entity_type is ec2_instance..</param>

        /// <param name="BoundRegion">If set, defines a constraint on the EC2 instances that the region in its identity document match one of the regions specified by this parameter. This is only applicable when auth_type is ec2..</param>

        /// <param name="BoundSubnetId">If set, defines a constraint on the EC2 instance to be associated with the subnet ID that matches one of the values specified by this parameter. This is only applicable when auth_type is ec2 or inferred_entity_type is ec2_instance..</param>

        /// <param name="BoundVpcId">If set, defines a constraint on the EC2 instance to be associated with a VPC ID that matches one of the value specified by this parameter. This is only applicable when auth_type is ec2 or inferred_entity_type is ec2_instance..</param>

        /// <param name="DisallowReauthentication">If set, only allows a single token to be granted per instance ID. In order to perform a fresh login, the entry in the access list for the instance ID needs to be cleared using &#x27;auth/aws-ec2/identity-accesslist/&lt;instance_id&gt;&#x27; endpoint. This is only applicable when auth_type is ec2. (default to false).</param>

        /// <param name="InferredAwsRegion">When auth_type is iam and inferred_entity_type is set, the region to assume the inferred entity exists in..</param>

        /// <param name="InferredEntityType">When auth_type is iam, the AWS entity type to infer from the authenticated principal. The only supported value is ec2_instance, which will extract the EC2 instance ID from the authenticated role and apply the following restrictions specific to EC2 instances: bound_ami_id, bound_account_id, bound_iam_role_arn, bound_iam_instance_profile_arn, bound_vpc_id, bound_subnet_id. The configured EC2 client must be able to find the inferred instance ID in the results, and the instance must be running. If unable to determine the EC2 instance ID or unable to find the EC2 instance ID among running instances, then authentication will fail..</param>

        /// <param name="MaxTtl">Use \&quot;token_max_ttl\&quot; instead. If this and \&quot;token_max_ttl\&quot; are both specified, only \&quot;token_max_ttl\&quot; will be used..</param>

        /// <param name="Period">Use \&quot;token_period\&quot; instead. If this and \&quot;token_period\&quot; are both specified, only \&quot;token_period\&quot; will be used..</param>

        /// <param name="Policies">Use \&quot;token_policies\&quot; instead. If this and \&quot;token_policies\&quot; are both specified, only \&quot;token_policies\&quot; will be used..</param>

        /// <param name="ResolveAwsUniqueIds">If set, resolve all AWS IAM ARNs into AWS&#x27;s internal unique IDs. When an IAM entity (e.g., user, role, or instance profile) is deleted, then all references to it within the role will be invalidated, which prevents a new IAM entity from being created with the same name and matching the role&#x27;s IAM binds. Once set, this cannot be unset. (default to true).</param>

        /// <param name="RoleTag">If set, enables the role tags for this role. The value set for this field should be the &#x27;key&#x27; of the tag on the EC2 instance. The &#x27;value&#x27; of the tag should be generated using &#x27;role/&lt;role&gt;/tag&#x27; endpoint. Defaults to an empty string, meaning that role tags are disabled. This is only allowed if auth_type is ec2. (default to &quot;&quot;).</param>

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


        public AwsWriteAuthRoleRequest(bool AllowInstanceMigration = false, string AuthType = default(string), List<string> BoundAccountId = default(List<string>), List<string> BoundAmiId = default(List<string>), List<string> BoundEc2InstanceId = default(List<string>), List<string> BoundIamInstanceProfileArn = default(List<string>), List<string> BoundIamPrincipalArn = default(List<string>), List<string> BoundIamRoleArn = default(List<string>), List<string> BoundRegion = default(List<string>), List<string> BoundSubnetId = default(List<string>), List<string> BoundVpcId = default(List<string>), bool DisallowReauthentication = false, string InferredAwsRegion = default(string), string InferredEntityType = default(string), int MaxTtl = default(int), int Period = default(int), List<string> Policies = default(List<string>), bool ResolveAwsUniqueIds = true, string RoleTag = "", List<string> TokenBoundCidrs = default(List<string>), int TokenExplicitMaxTtl = default(int), int TokenMaxTtl = default(int), bool TokenNoDefaultPolicy = default(bool), int TokenNumUses = default(int), int TokenPeriod = default(int), List<string> TokenPolicies = default(List<string>), int TokenTtl = default(int), string TokenType = "default-service", int Ttl = default(int))
        {

            this.AllowInstanceMigration = AllowInstanceMigration;

            this.AuthType = AuthType;

            this.BoundAccountId = BoundAccountId;

            this.BoundAmiId = BoundAmiId;

            this.BoundEc2InstanceId = BoundEc2InstanceId;

            this.BoundIamInstanceProfileArn = BoundIamInstanceProfileArn;

            this.BoundIamPrincipalArn = BoundIamPrincipalArn;

            this.BoundIamRoleArn = BoundIamRoleArn;

            this.BoundRegion = BoundRegion;

            this.BoundSubnetId = BoundSubnetId;

            this.BoundVpcId = BoundVpcId;

            this.DisallowReauthentication = DisallowReauthentication;

            this.InferredAwsRegion = InferredAwsRegion;

            this.InferredEntityType = InferredEntityType;

            this.MaxTtl = MaxTtl;

            this.Period = Period;

            this.Policies = Policies;

            this.ResolveAwsUniqueIds = ResolveAwsUniqueIds;

            // use default value if no "RoleTag" provided
            this.RoleTag = RoleTag ?? "";


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
        /// If set, allows migration of the underlying instance where the client resides. This keys off of pendingTime in the metadata document, so essentially, this disables the client nonce check whenever the instance is migrated to a new host and pendingTime is newer than the previously-remembered time. Use with caution. This is only checked when auth_type is ec2.
        /// </summary>
        /// <value>If set, allows migration of the underlying instance where the client resides. This keys off of pendingTime in the metadata document, so essentially, this disables the client nonce check whenever the instance is migrated to a new host and pendingTime is newer than the previously-remembered time. Use with caution. This is only checked when auth_type is ec2.</value>
        [DataMember(Name = "allow_instance_migration", EmitDefaultValue = true)]

        public bool AllowInstanceMigration { get; set; }


        /// <summary>
        /// The auth_type permitted to authenticate to this role. Must be one of iam or ec2 and cannot be changed after role creation.
        /// </summary>
        /// <value>The auth_type permitted to authenticate to this role. Must be one of iam or ec2 and cannot be changed after role creation.</value>
        [DataMember(Name = "auth_type", EmitDefaultValue = false)]

        public string AuthType { get; set; }


        /// <summary>
        /// If set, defines a constraint on the EC2 instances that the account ID in its identity document to match one of the IDs specified by this parameter. This is only applicable when auth_type is ec2 or inferred_entity_type is ec2_instance.
        /// </summary>
        /// <value>If set, defines a constraint on the EC2 instances that the account ID in its identity document to match one of the IDs specified by this parameter. This is only applicable when auth_type is ec2 or inferred_entity_type is ec2_instance.</value>
        [DataMember(Name = "bound_account_id", EmitDefaultValue = false)]

        public List<string> BoundAccountId { get; set; }


        /// <summary>
        /// If set, defines a constraint on the EC2 instances that they should be using one of the AMI IDs specified by this parameter. This is only applicable when auth_type is ec2 or inferred_entity_type is ec2_instance.
        /// </summary>
        /// <value>If set, defines a constraint on the EC2 instances that they should be using one of the AMI IDs specified by this parameter. This is only applicable when auth_type is ec2 or inferred_entity_type is ec2_instance.</value>
        [DataMember(Name = "bound_ami_id", EmitDefaultValue = false)]

        public List<string> BoundAmiId { get; set; }


        /// <summary>
        /// If set, defines a constraint on the EC2 instances to have one of the given instance IDs. Can be a list or comma-separated string of EC2 instance IDs. This is only applicable when auth_type is ec2 or inferred_entity_type is ec2_instance.
        /// </summary>
        /// <value>If set, defines a constraint on the EC2 instances to have one of the given instance IDs. Can be a list or comma-separated string of EC2 instance IDs. This is only applicable when auth_type is ec2 or inferred_entity_type is ec2_instance.</value>
        [DataMember(Name = "bound_ec2_instance_id", EmitDefaultValue = false)]

        public List<string> BoundEc2InstanceId { get; set; }


        /// <summary>
        /// If set, defines a constraint on the EC2 instances to be associated with an IAM instance profile ARN which has a prefix that matches one of the values specified by this parameter. The value is prefix-matched (as though it were a glob ending in &#x27;*&#x27;). This is only applicable when auth_type is ec2 or inferred_entity_type is ec2_instance.
        /// </summary>
        /// <value>If set, defines a constraint on the EC2 instances to be associated with an IAM instance profile ARN which has a prefix that matches one of the values specified by this parameter. The value is prefix-matched (as though it were a glob ending in &#x27;*&#x27;). This is only applicable when auth_type is ec2 or inferred_entity_type is ec2_instance.</value>
        [DataMember(Name = "bound_iam_instance_profile_arn", EmitDefaultValue = false)]

        public List<string> BoundIamInstanceProfileArn { get; set; }


        /// <summary>
        /// ARN of the IAM principals to bind to this role. Only applicable when auth_type is iam.
        /// </summary>
        /// <value>ARN of the IAM principals to bind to this role. Only applicable when auth_type is iam.</value>
        [DataMember(Name = "bound_iam_principal_arn", EmitDefaultValue = false)]

        public List<string> BoundIamPrincipalArn { get; set; }


        /// <summary>
        /// If set, defines a constraint on the authenticating EC2 instance that it must match one of the IAM role ARNs specified by this parameter. The value is prefix-matched (as though it were a glob ending in &#x27;*&#x27;). The configured IAM user or EC2 instance role must be allowed to execute the &#x27;iam:GetInstanceProfile&#x27; action if this is specified. This is only applicable when auth_type is ec2 or inferred_entity_type is ec2_instance.
        /// </summary>
        /// <value>If set, defines a constraint on the authenticating EC2 instance that it must match one of the IAM role ARNs specified by this parameter. The value is prefix-matched (as though it were a glob ending in &#x27;*&#x27;). The configured IAM user or EC2 instance role must be allowed to execute the &#x27;iam:GetInstanceProfile&#x27; action if this is specified. This is only applicable when auth_type is ec2 or inferred_entity_type is ec2_instance.</value>
        [DataMember(Name = "bound_iam_role_arn", EmitDefaultValue = false)]

        public List<string> BoundIamRoleArn { get; set; }


        /// <summary>
        /// If set, defines a constraint on the EC2 instances that the region in its identity document match one of the regions specified by this parameter. This is only applicable when auth_type is ec2.
        /// </summary>
        /// <value>If set, defines a constraint on the EC2 instances that the region in its identity document match one of the regions specified by this parameter. This is only applicable when auth_type is ec2.</value>
        [DataMember(Name = "bound_region", EmitDefaultValue = false)]

        public List<string> BoundRegion { get; set; }


        /// <summary>
        /// If set, defines a constraint on the EC2 instance to be associated with the subnet ID that matches one of the values specified by this parameter. This is only applicable when auth_type is ec2 or inferred_entity_type is ec2_instance.
        /// </summary>
        /// <value>If set, defines a constraint on the EC2 instance to be associated with the subnet ID that matches one of the values specified by this parameter. This is only applicable when auth_type is ec2 or inferred_entity_type is ec2_instance.</value>
        [DataMember(Name = "bound_subnet_id", EmitDefaultValue = false)]

        public List<string> BoundSubnetId { get; set; }


        /// <summary>
        /// If set, defines a constraint on the EC2 instance to be associated with a VPC ID that matches one of the value specified by this parameter. This is only applicable when auth_type is ec2 or inferred_entity_type is ec2_instance.
        /// </summary>
        /// <value>If set, defines a constraint on the EC2 instance to be associated with a VPC ID that matches one of the value specified by this parameter. This is only applicable when auth_type is ec2 or inferred_entity_type is ec2_instance.</value>
        [DataMember(Name = "bound_vpc_id", EmitDefaultValue = false)]

        public List<string> BoundVpcId { get; set; }


        /// <summary>
        /// If set, only allows a single token to be granted per instance ID. In order to perform a fresh login, the entry in the access list for the instance ID needs to be cleared using &#x27;auth/aws-ec2/identity-accesslist/&lt;instance_id&gt;&#x27; endpoint. This is only applicable when auth_type is ec2.
        /// </summary>
        /// <value>If set, only allows a single token to be granted per instance ID. In order to perform a fresh login, the entry in the access list for the instance ID needs to be cleared using &#x27;auth/aws-ec2/identity-accesslist/&lt;instance_id&gt;&#x27; endpoint. This is only applicable when auth_type is ec2.</value>
        [DataMember(Name = "disallow_reauthentication", EmitDefaultValue = true)]

        public bool DisallowReauthentication { get; set; }


        /// <summary>
        /// When auth_type is iam and inferred_entity_type is set, the region to assume the inferred entity exists in.
        /// </summary>
        /// <value>When auth_type is iam and inferred_entity_type is set, the region to assume the inferred entity exists in.</value>
        [DataMember(Name = "inferred_aws_region", EmitDefaultValue = false)]

        public string InferredAwsRegion { get; set; }


        /// <summary>
        /// When auth_type is iam, the AWS entity type to infer from the authenticated principal. The only supported value is ec2_instance, which will extract the EC2 instance ID from the authenticated role and apply the following restrictions specific to EC2 instances: bound_ami_id, bound_account_id, bound_iam_role_arn, bound_iam_instance_profile_arn, bound_vpc_id, bound_subnet_id. The configured EC2 client must be able to find the inferred instance ID in the results, and the instance must be running. If unable to determine the EC2 instance ID or unable to find the EC2 instance ID among running instances, then authentication will fail.
        /// </summary>
        /// <value>When auth_type is iam, the AWS entity type to infer from the authenticated principal. The only supported value is ec2_instance, which will extract the EC2 instance ID from the authenticated role and apply the following restrictions specific to EC2 instances: bound_ami_id, bound_account_id, bound_iam_role_arn, bound_iam_instance_profile_arn, bound_vpc_id, bound_subnet_id. The configured EC2 client must be able to find the inferred instance ID in the results, and the instance must be running. If unable to determine the EC2 instance ID or unable to find the EC2 instance ID among running instances, then authentication will fail.</value>
        [DataMember(Name = "inferred_entity_type", EmitDefaultValue = false)]

        public string InferredEntityType { get; set; }


        /// <summary>
        /// Use \&quot;token_max_ttl\&quot; instead. If this and \&quot;token_max_ttl\&quot; are both specified, only \&quot;token_max_ttl\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_max_ttl\&quot; instead. If this and \&quot;token_max_ttl\&quot; are both specified, only \&quot;token_max_ttl\&quot; will be used.</value>
        [DataMember(Name = "max_ttl", EmitDefaultValue = false)]

        [Obsolete] public int MaxTtl { get; set; }


        /// <summary>
        /// Use \&quot;token_period\&quot; instead. If this and \&quot;token_period\&quot; are both specified, only \&quot;token_period\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_period\&quot; instead. If this and \&quot;token_period\&quot; are both specified, only \&quot;token_period\&quot; will be used.</value>
        [DataMember(Name = "period", EmitDefaultValue = false)]

        [Obsolete] public int Period { get; set; }


        /// <summary>
        /// Use \&quot;token_policies\&quot; instead. If this and \&quot;token_policies\&quot; are both specified, only \&quot;token_policies\&quot; will be used.
        /// </summary>
        /// <value>Use \&quot;token_policies\&quot; instead. If this and \&quot;token_policies\&quot; are both specified, only \&quot;token_policies\&quot; will be used.</value>
        [DataMember(Name = "policies", EmitDefaultValue = false)]

        [Obsolete] public List<string> Policies { get; set; }


        /// <summary>
        /// If set, resolve all AWS IAM ARNs into AWS&#x27;s internal unique IDs. When an IAM entity (e.g., user, role, or instance profile) is deleted, then all references to it within the role will be invalidated, which prevents a new IAM entity from being created with the same name and matching the role&#x27;s IAM binds. Once set, this cannot be unset.
        /// </summary>
        /// <value>If set, resolve all AWS IAM ARNs into AWS&#x27;s internal unique IDs. When an IAM entity (e.g., user, role, or instance profile) is deleted, then all references to it within the role will be invalidated, which prevents a new IAM entity from being created with the same name and matching the role&#x27;s IAM binds. Once set, this cannot be unset.</value>
        [DataMember(Name = "resolve_aws_unique_ids", EmitDefaultValue = true)]

        public bool ResolveAwsUniqueIds { get; set; }


        /// <summary>
        /// If set, enables the role tags for this role. The value set for this field should be the &#x27;key&#x27; of the tag on the EC2 instance. The &#x27;value&#x27; of the tag should be generated using &#x27;role/&lt;role&gt;/tag&#x27; endpoint. Defaults to an empty string, meaning that role tags are disabled. This is only allowed if auth_type is ec2.
        /// </summary>
        /// <value>If set, enables the role tags for this role. The value set for this field should be the &#x27;key&#x27; of the tag on the EC2 instance. The &#x27;value&#x27; of the tag should be generated using &#x27;role/&lt;role&gt;/tag&#x27; endpoint. Defaults to an empty string, meaning that role tags are disabled. This is only allowed if auth_type is ec2.</value>
        [DataMember(Name = "role_tag", EmitDefaultValue = false)]

        public string RoleTag { get; set; }


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

        [Obsolete] public int Ttl { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AwsWriteAuthRoleRequest {\n");
            sb.Append("  AllowInstanceMigration: ").Append(AllowInstanceMigration).Append("\n");
            sb.Append("  AuthType: ").Append(AuthType).Append("\n");
            sb.Append("  BoundAccountId: ").Append(BoundAccountId).Append("\n");
            sb.Append("  BoundAmiId: ").Append(BoundAmiId).Append("\n");
            sb.Append("  BoundEc2InstanceId: ").Append(BoundEc2InstanceId).Append("\n");
            sb.Append("  BoundIamInstanceProfileArn: ").Append(BoundIamInstanceProfileArn).Append("\n");
            sb.Append("  BoundIamPrincipalArn: ").Append(BoundIamPrincipalArn).Append("\n");
            sb.Append("  BoundIamRoleArn: ").Append(BoundIamRoleArn).Append("\n");
            sb.Append("  BoundRegion: ").Append(BoundRegion).Append("\n");
            sb.Append("  BoundSubnetId: ").Append(BoundSubnetId).Append("\n");
            sb.Append("  BoundVpcId: ").Append(BoundVpcId).Append("\n");
            sb.Append("  DisallowReauthentication: ").Append(DisallowReauthentication).Append("\n");
            sb.Append("  InferredAwsRegion: ").Append(InferredAwsRegion).Append("\n");
            sb.Append("  InferredEntityType: ").Append(InferredEntityType).Append("\n");
            sb.Append("  MaxTtl: ").Append(MaxTtl).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
            sb.Append("  ResolveAwsUniqueIds: ").Append(ResolveAwsUniqueIds).Append("\n");
            sb.Append("  RoleTag: ").Append(RoleTag).Append("\n");
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
            return this.Equals(input as AwsWriteAuthRoleRequest);
        }

        /// <summary>
        /// Returns true if AwsWriteAuthRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AwsWriteAuthRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AwsWriteAuthRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AllowInstanceMigration == input.AllowInstanceMigration ||

                    this.AllowInstanceMigration.Equals(input.AllowInstanceMigration)
                ) &&
                (
                    this.AuthType == input.AuthType ||
                    (this.AuthType != null &&
                    this.AuthType.Equals(input.AuthType))

                ) &&
                (
                    this.BoundAccountId == input.BoundAccountId ||
                    this.BoundAccountId != null &&
                    input.BoundAccountId != null &&
                    this.BoundAccountId.SequenceEqual(input.BoundAccountId)
                ) &&
                (
                    this.BoundAmiId == input.BoundAmiId ||
                    this.BoundAmiId != null &&
                    input.BoundAmiId != null &&
                    this.BoundAmiId.SequenceEqual(input.BoundAmiId)
                ) &&
                (
                    this.BoundEc2InstanceId == input.BoundEc2InstanceId ||
                    this.BoundEc2InstanceId != null &&
                    input.BoundEc2InstanceId != null &&
                    this.BoundEc2InstanceId.SequenceEqual(input.BoundEc2InstanceId)
                ) &&
                (
                    this.BoundIamInstanceProfileArn == input.BoundIamInstanceProfileArn ||
                    this.BoundIamInstanceProfileArn != null &&
                    input.BoundIamInstanceProfileArn != null &&
                    this.BoundIamInstanceProfileArn.SequenceEqual(input.BoundIamInstanceProfileArn)
                ) &&
                (
                    this.BoundIamPrincipalArn == input.BoundIamPrincipalArn ||
                    this.BoundIamPrincipalArn != null &&
                    input.BoundIamPrincipalArn != null &&
                    this.BoundIamPrincipalArn.SequenceEqual(input.BoundIamPrincipalArn)
                ) &&
                (
                    this.BoundIamRoleArn == input.BoundIamRoleArn ||
                    this.BoundIamRoleArn != null &&
                    input.BoundIamRoleArn != null &&
                    this.BoundIamRoleArn.SequenceEqual(input.BoundIamRoleArn)
                ) &&
                (
                    this.BoundRegion == input.BoundRegion ||
                    this.BoundRegion != null &&
                    input.BoundRegion != null &&
                    this.BoundRegion.SequenceEqual(input.BoundRegion)
                ) &&
                (
                    this.BoundSubnetId == input.BoundSubnetId ||
                    this.BoundSubnetId != null &&
                    input.BoundSubnetId != null &&
                    this.BoundSubnetId.SequenceEqual(input.BoundSubnetId)
                ) &&
                (
                    this.BoundVpcId == input.BoundVpcId ||
                    this.BoundVpcId != null &&
                    input.BoundVpcId != null &&
                    this.BoundVpcId.SequenceEqual(input.BoundVpcId)
                ) &&
                (
                    this.DisallowReauthentication == input.DisallowReauthentication ||

                    this.DisallowReauthentication.Equals(input.DisallowReauthentication)
                ) &&
                (
                    this.InferredAwsRegion == input.InferredAwsRegion ||
                    (this.InferredAwsRegion != null &&
                    this.InferredAwsRegion.Equals(input.InferredAwsRegion))

                ) &&
                (
                    this.InferredEntityType == input.InferredEntityType ||
                    (this.InferredEntityType != null &&
                    this.InferredEntityType.Equals(input.InferredEntityType))

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
                    this.ResolveAwsUniqueIds == input.ResolveAwsUniqueIds ||

                    this.ResolveAwsUniqueIds.Equals(input.ResolveAwsUniqueIds)
                ) &&
                (
                    this.RoleTag == input.RoleTag ||
                    (this.RoleTag != null &&
                    this.RoleTag.Equals(input.RoleTag))

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


                hashCode = (hashCode * 59) + this.AllowInstanceMigration.GetHashCode();
                if (this.AuthType != null)
                {
                    hashCode = (hashCode * 59) + this.AuthType.GetHashCode();
                }

                if (this.BoundAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.BoundAccountId.GetHashCode();
                }

                if (this.BoundAmiId != null)
                {
                    hashCode = (hashCode * 59) + this.BoundAmiId.GetHashCode();
                }

                if (this.BoundEc2InstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.BoundEc2InstanceId.GetHashCode();
                }

                if (this.BoundIamInstanceProfileArn != null)
                {
                    hashCode = (hashCode * 59) + this.BoundIamInstanceProfileArn.GetHashCode();
                }

                if (this.BoundIamPrincipalArn != null)
                {
                    hashCode = (hashCode * 59) + this.BoundIamPrincipalArn.GetHashCode();
                }

                if (this.BoundIamRoleArn != null)
                {
                    hashCode = (hashCode * 59) + this.BoundIamRoleArn.GetHashCode();
                }

                if (this.BoundRegion != null)
                {
                    hashCode = (hashCode * 59) + this.BoundRegion.GetHashCode();
                }

                if (this.BoundSubnetId != null)
                {
                    hashCode = (hashCode * 59) + this.BoundSubnetId.GetHashCode();
                }

                if (this.BoundVpcId != null)
                {
                    hashCode = (hashCode * 59) + this.BoundVpcId.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.DisallowReauthentication.GetHashCode();
                if (this.InferredAwsRegion != null)
                {
                    hashCode = (hashCode * 59) + this.InferredAwsRegion.GetHashCode();
                }

                if (this.InferredEntityType != null)
                {
                    hashCode = (hashCode * 59) + this.InferredEntityType.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.MaxTtl.GetHashCode();

                hashCode = (hashCode * 59) + this.Period.GetHashCode();
                if (this.Policies != null)
                {
                    hashCode = (hashCode * 59) + this.Policies.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.ResolveAwsUniqueIds.GetHashCode();
                if (this.RoleTag != null)
                {
                    hashCode = (hashCode * 59) + this.RoleTag.GetHashCode();
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
