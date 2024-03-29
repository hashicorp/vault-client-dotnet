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
    /// AwsWriteRoleRequest
    /// </summary>
    [DataContract(Name = "AwsWriteRoleRequest")]
    public partial class AwsWriteRoleRequest : IEquatable<AwsWriteRoleRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="AwsWriteRoleRequest" /> class.
        /// </summary>

        /// <param name="Arn">Use role_arns or policy_arns instead..</param>

        /// <param name="CredentialType">Type of credential to retrieve. Must be one of assumed_role, iam_user, or federation_token.</param>

        /// <param name="DefaultStsTtl">Default TTL for assumed_role and federation_token credential types when no TTL is explicitly requested with the credentials.</param>

        /// <param name="IamGroups">Names of IAM groups that generated IAM users will be added to. For a credential type of assumed_role or federation_token, the policies sent to the corresponding AWS call (sts:AssumeRole or sts:GetFederation) will be the policies from each group in iam_groups combined with the policy_document and policy_arns parameters..</param>

        /// <param name="IamTags">IAM tags to be set for any users created by this role. These must be presented as Key-Value pairs. This can be represented as a map or a list of equal sign delimited key pairs..</param>

        /// <param name="MaxStsTtl">Max allowed TTL for assumed_role and federation_token credential types.</param>

        /// <param name="PermissionsBoundaryArn">ARN of an IAM policy to attach as a permissions boundary on IAM user credentials; only valid when credential_type isiam_user.</param>

        /// <param name="Policy">Use policy_document instead..</param>

        /// <param name="PolicyArns">ARNs of AWS policies. Behavior varies by credential_type. When credential_type is iam_user, then it will attach the specified policies to the generated IAM user. When credential_type is assumed_role or federation_token, the policies will be passed as the PolicyArns parameter, acting as a filter on permissions available..</param>

        /// <param name="PolicyDocument">JSON-encoded IAM policy document. Behavior varies by credential_type. When credential_type is iam_user, then it will attach the contents of the policy_document to the IAM user generated. When credential_type is assumed_role or federation_token, this will be passed in as the Policy parameter to the AssumeRole or GetFederationToken API call, acting as a filter on permissions available..</param>

        /// <param name="RoleArns">ARNs of AWS roles allowed to be assumed. Only valid when credential_type is assumed_role.</param>

        /// <param name="UserPath">Path for IAM User. Only valid when credential_type is iam_user (default to &quot;/&quot;).</param>


        public AwsWriteRoleRequest(string Arn = default(string), string CredentialType = default(string), string DefaultStsTtl = default(string), List<string> IamGroups = default(List<string>), Object IamTags = default(Object), string MaxStsTtl = default(string), string PermissionsBoundaryArn = default(string), string Policy = default(string), List<string> PolicyArns = default(List<string>), string PolicyDocument = default(string), List<string> RoleArns = default(List<string>), string UserPath = "/")
        {

            this.Arn = Arn;

            this.CredentialType = CredentialType;

            this.DefaultStsTtl = DefaultStsTtl;

            this.IamGroups = IamGroups;

            this.IamTags = IamTags;

            this.MaxStsTtl = MaxStsTtl;

            this.PermissionsBoundaryArn = PermissionsBoundaryArn;

            this.Policy = Policy;

            this.PolicyArns = PolicyArns;

            this.PolicyDocument = PolicyDocument;

            this.RoleArns = RoleArns;

            // use default value if no "UserPath" provided
            this.UserPath = UserPath ?? "/";


        }

        /// <summary>
        /// Use role_arns or policy_arns instead.
        /// </summary>
        /// <value>Use role_arns or policy_arns instead.</value>
        [DataMember(Name = "arn", EmitDefaultValue = false)]

        [Obsolete] public string Arn { get; set; }


        /// <summary>
        /// Type of credential to retrieve. Must be one of assumed_role, iam_user, or federation_token
        /// </summary>
        /// <value>Type of credential to retrieve. Must be one of assumed_role, iam_user, or federation_token</value>
        [DataMember(Name = "credential_type", EmitDefaultValue = false)]

        public string CredentialType { get; set; }


        /// <summary>
        /// Default TTL for assumed_role and federation_token credential types when no TTL is explicitly requested with the credentials
        /// </summary>
        /// <value>Default TTL for assumed_role and federation_token credential types when no TTL is explicitly requested with the credentials</value>
        [DataMember(Name = "default_sts_ttl", EmitDefaultValue = false)]

        public string DefaultStsTtl { get; set; }


        /// <summary>
        /// Names of IAM groups that generated IAM users will be added to. For a credential type of assumed_role or federation_token, the policies sent to the corresponding AWS call (sts:AssumeRole or sts:GetFederation) will be the policies from each group in iam_groups combined with the policy_document and policy_arns parameters.
        /// </summary>
        /// <value>Names of IAM groups that generated IAM users will be added to. For a credential type of assumed_role or federation_token, the policies sent to the corresponding AWS call (sts:AssumeRole or sts:GetFederation) will be the policies from each group in iam_groups combined with the policy_document and policy_arns parameters.</value>
        [DataMember(Name = "iam_groups", EmitDefaultValue = false)]

        public List<string> IamGroups { get; set; }


        /// <summary>
        /// IAM tags to be set for any users created by this role. These must be presented as Key-Value pairs. This can be represented as a map or a list of equal sign delimited key pairs.
        /// </summary>
        /// <value>IAM tags to be set for any users created by this role. These must be presented as Key-Value pairs. This can be represented as a map or a list of equal sign delimited key pairs.</value>
        [DataMember(Name = "iam_tags", EmitDefaultValue = false)]

        public Object IamTags { get; set; }


        /// <summary>
        /// Max allowed TTL for assumed_role and federation_token credential types
        /// </summary>
        /// <value>Max allowed TTL for assumed_role and federation_token credential types</value>
        [DataMember(Name = "max_sts_ttl", EmitDefaultValue = false)]

        public string MaxStsTtl { get; set; }


        /// <summary>
        /// ARN of an IAM policy to attach as a permissions boundary on IAM user credentials; only valid when credential_type isiam_user
        /// </summary>
        /// <value>ARN of an IAM policy to attach as a permissions boundary on IAM user credentials; only valid when credential_type isiam_user</value>
        [DataMember(Name = "permissions_boundary_arn", EmitDefaultValue = false)]

        public string PermissionsBoundaryArn { get; set; }


        /// <summary>
        /// Use policy_document instead.
        /// </summary>
        /// <value>Use policy_document instead.</value>
        [DataMember(Name = "policy", EmitDefaultValue = false)]

        [Obsolete] public string Policy { get; set; }


        /// <summary>
        /// ARNs of AWS policies. Behavior varies by credential_type. When credential_type is iam_user, then it will attach the specified policies to the generated IAM user. When credential_type is assumed_role or federation_token, the policies will be passed as the PolicyArns parameter, acting as a filter on permissions available.
        /// </summary>
        /// <value>ARNs of AWS policies. Behavior varies by credential_type. When credential_type is iam_user, then it will attach the specified policies to the generated IAM user. When credential_type is assumed_role or federation_token, the policies will be passed as the PolicyArns parameter, acting as a filter on permissions available.</value>
        [DataMember(Name = "policy_arns", EmitDefaultValue = false)]

        public List<string> PolicyArns { get; set; }


        /// <summary>
        /// JSON-encoded IAM policy document. Behavior varies by credential_type. When credential_type is iam_user, then it will attach the contents of the policy_document to the IAM user generated. When credential_type is assumed_role or federation_token, this will be passed in as the Policy parameter to the AssumeRole or GetFederationToken API call, acting as a filter on permissions available.
        /// </summary>
        /// <value>JSON-encoded IAM policy document. Behavior varies by credential_type. When credential_type is iam_user, then it will attach the contents of the policy_document to the IAM user generated. When credential_type is assumed_role or federation_token, this will be passed in as the Policy parameter to the AssumeRole or GetFederationToken API call, acting as a filter on permissions available.</value>
        [DataMember(Name = "policy_document", EmitDefaultValue = false)]

        public string PolicyDocument { get; set; }


        /// <summary>
        /// ARNs of AWS roles allowed to be assumed. Only valid when credential_type is assumed_role
        /// </summary>
        /// <value>ARNs of AWS roles allowed to be assumed. Only valid when credential_type is assumed_role</value>
        [DataMember(Name = "role_arns", EmitDefaultValue = false)]

        public List<string> RoleArns { get; set; }


        /// <summary>
        /// Path for IAM User. Only valid when credential_type is iam_user
        /// </summary>
        /// <value>Path for IAM User. Only valid when credential_type is iam_user</value>
        [DataMember(Name = "user_path", EmitDefaultValue = false)]

        public string UserPath { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AwsWriteRoleRequest {\n");
            sb.Append("  Arn: ").Append(Arn).Append("\n");
            sb.Append("  CredentialType: ").Append(CredentialType).Append("\n");
            sb.Append("  DefaultStsTtl: ").Append(DefaultStsTtl).Append("\n");
            sb.Append("  IamGroups: ").Append(IamGroups).Append("\n");
            sb.Append("  IamTags: ").Append(IamTags).Append("\n");
            sb.Append("  MaxStsTtl: ").Append(MaxStsTtl).Append("\n");
            sb.Append("  PermissionsBoundaryArn: ").Append(PermissionsBoundaryArn).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  PolicyArns: ").Append(PolicyArns).Append("\n");
            sb.Append("  PolicyDocument: ").Append(PolicyDocument).Append("\n");
            sb.Append("  RoleArns: ").Append(RoleArns).Append("\n");
            sb.Append("  UserPath: ").Append(UserPath).Append("\n");
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
            return this.Equals(input as AwsWriteRoleRequest);
        }

        /// <summary>
        /// Returns true if AwsWriteRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AwsWriteRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AwsWriteRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Arn == input.Arn ||
                    (this.Arn != null &&
                    this.Arn.Equals(input.Arn))

                ) &&
                (
                    this.CredentialType == input.CredentialType ||
                    (this.CredentialType != null &&
                    this.CredentialType.Equals(input.CredentialType))

                ) &&
                (
                    this.DefaultStsTtl == input.DefaultStsTtl ||
                    (this.DefaultStsTtl != null &&
                    this.DefaultStsTtl.Equals(input.DefaultStsTtl))

                ) &&
                (
                    this.IamGroups == input.IamGroups ||
                    this.IamGroups != null &&
                    input.IamGroups != null &&
                    this.IamGroups.SequenceEqual(input.IamGroups)
                ) &&
                (
                    this.IamTags == input.IamTags ||
                    (this.IamTags != null &&
                    this.IamTags.Equals(input.IamTags))

                ) &&
                (
                    this.MaxStsTtl == input.MaxStsTtl ||
                    (this.MaxStsTtl != null &&
                    this.MaxStsTtl.Equals(input.MaxStsTtl))

                ) &&
                (
                    this.PermissionsBoundaryArn == input.PermissionsBoundaryArn ||
                    (this.PermissionsBoundaryArn != null &&
                    this.PermissionsBoundaryArn.Equals(input.PermissionsBoundaryArn))

                ) &&
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))

                ) &&
                (
                    this.PolicyArns == input.PolicyArns ||
                    this.PolicyArns != null &&
                    input.PolicyArns != null &&
                    this.PolicyArns.SequenceEqual(input.PolicyArns)
                ) &&
                (
                    this.PolicyDocument == input.PolicyDocument ||
                    (this.PolicyDocument != null &&
                    this.PolicyDocument.Equals(input.PolicyDocument))

                ) &&
                (
                    this.RoleArns == input.RoleArns ||
                    this.RoleArns != null &&
                    input.RoleArns != null &&
                    this.RoleArns.SequenceEqual(input.RoleArns)
                ) &&
                (
                    this.UserPath == input.UserPath ||
                    (this.UserPath != null &&
                    this.UserPath.Equals(input.UserPath))

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

                if (this.Arn != null)
                {
                    hashCode = (hashCode * 59) + this.Arn.GetHashCode();
                }

                if (this.CredentialType != null)
                {
                    hashCode = (hashCode * 59) + this.CredentialType.GetHashCode();
                }

                if (this.DefaultStsTtl != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultStsTtl.GetHashCode();
                }

                if (this.IamGroups != null)
                {
                    hashCode = (hashCode * 59) + this.IamGroups.GetHashCode();
                }

                if (this.IamTags != null)
                {
                    hashCode = (hashCode * 59) + this.IamTags.GetHashCode();
                }

                if (this.MaxStsTtl != null)
                {
                    hashCode = (hashCode * 59) + this.MaxStsTtl.GetHashCode();
                }

                if (this.PermissionsBoundaryArn != null)
                {
                    hashCode = (hashCode * 59) + this.PermissionsBoundaryArn.GetHashCode();
                }

                if (this.Policy != null)
                {
                    hashCode = (hashCode * 59) + this.Policy.GetHashCode();
                }

                if (this.PolicyArns != null)
                {
                    hashCode = (hashCode * 59) + this.PolicyArns.GetHashCode();
                }

                if (this.PolicyDocument != null)
                {
                    hashCode = (hashCode * 59) + this.PolicyDocument.GetHashCode();
                }

                if (this.RoleArns != null)
                {
                    hashCode = (hashCode * 59) + this.RoleArns.GetHashCode();
                }

                if (this.UserPath != null)
                {
                    hashCode = (hashCode * 59) + this.UserPath.GetHashCode();
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
