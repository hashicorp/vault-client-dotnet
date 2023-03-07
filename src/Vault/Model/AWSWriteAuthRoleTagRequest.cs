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
    /// AWSWriteAuthRoleTagRequest
    /// </summary>
    [DataContract(Name = "AWSWriteAuthRoleTagRequest")]

    public partial class AWSWriteAuthRoleTagRequest : IEquatable<AWSWriteAuthRoleTagRequest>, IValidatableObject
    {













        /// <summary>
        /// Initializes a new instance of the <see cref="AWSWriteAuthRoleTagRequest" /> class.
        /// </summary>

        /// <param name="AllowInstanceMigration">If set, allows migration of the underlying instance where the client resides. This keys off of pendingTime in the metadata document, so essentially, this disables the client nonce check whenever the instance is migrated to a new host and pendingTime is newer than the previously-remembered time. Use with caution. (default to false).</param>

        /// <param name="DisallowReauthentication">If set, only allows a single token to be granted per instance ID. In order to perform a fresh login, the entry in access list for the instance ID needs to be cleared using the &#x27;auth/aws-ec2/identity-accesslist/&lt;instance_id&gt;&#x27; endpoint. (default to false).</param>

        /// <param name="InstanceId">Instance ID for which this tag is intended for. If set, the created tag can only be used by the instance with the given ID..</param>

        /// <param name="MaxTtl">If set, specifies the maximum allowed token lifetime. (default to 0).</param>

        /// <param name="Policies">Policies to be associated with the tag. If set, must be a subset of the role&#x27;s policies. If set, but set to an empty value, only the &#x27;default&#x27; policy will be given to issued tokens..</param>


        public AWSWriteAuthRoleTagRequest(bool AllowInstanceMigration = false, bool DisallowReauthentication = false, string InstanceId = default(string), int MaxTtl = 0, List<string> Policies = default(List<string>))
        {

            this.AllowInstanceMigration = AllowInstanceMigration;

            this.DisallowReauthentication = DisallowReauthentication;

            this.InstanceId = InstanceId;

            this.MaxTtl = MaxTtl;

            this.Policies = Policies;

        }

        /// <summary>
        /// If set, allows migration of the underlying instance where the client resides. This keys off of pendingTime in the metadata document, so essentially, this disables the client nonce check whenever the instance is migrated to a new host and pendingTime is newer than the previously-remembered time. Use with caution.
        /// </summary>
        /// <value>If set, allows migration of the underlying instance where the client resides. This keys off of pendingTime in the metadata document, so essentially, this disables the client nonce check whenever the instance is migrated to a new host and pendingTime is newer than the previously-remembered time. Use with caution.</value>
        [DataMember(Name = "allow_instance_migration", EmitDefaultValue = true)]


        public bool AllowInstanceMigration { get; set; }


        /// <summary>
        /// If set, only allows a single token to be granted per instance ID. In order to perform a fresh login, the entry in access list for the instance ID needs to be cleared using the &#x27;auth/aws-ec2/identity-accesslist/&lt;instance_id&gt;&#x27; endpoint.
        /// </summary>
        /// <value>If set, only allows a single token to be granted per instance ID. In order to perform a fresh login, the entry in access list for the instance ID needs to be cleared using the &#x27;auth/aws-ec2/identity-accesslist/&lt;instance_id&gt;&#x27; endpoint.</value>
        [DataMember(Name = "disallow_reauthentication", EmitDefaultValue = true)]


        public bool DisallowReauthentication { get; set; }


        /// <summary>
        /// Instance ID for which this tag is intended for. If set, the created tag can only be used by the instance with the given ID.
        /// </summary>
        /// <value>Instance ID for which this tag is intended for. If set, the created tag can only be used by the instance with the given ID.</value>
        [DataMember(Name = "instance_id", EmitDefaultValue = false)]


        public string InstanceId { get; set; }


        /// <summary>
        /// If set, specifies the maximum allowed token lifetime.
        /// </summary>
        /// <value>If set, specifies the maximum allowed token lifetime.</value>
        [DataMember(Name = "max_ttl", EmitDefaultValue = false)]


        public int MaxTtl { get; set; }


        /// <summary>
        /// Policies to be associated with the tag. If set, must be a subset of the role&#x27;s policies. If set, but set to an empty value, only the &#x27;default&#x27; policy will be given to issued tokens.
        /// </summary>
        /// <value>Policies to be associated with the tag. If set, must be a subset of the role&#x27;s policies. If set, but set to an empty value, only the &#x27;default&#x27; policy will be given to issued tokens.</value>
        [DataMember(Name = "policies", EmitDefaultValue = false)]


        public List<string> Policies { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AWSWriteAuthRoleTagRequest {\n");
            sb.Append("  AllowInstanceMigration: ").Append(AllowInstanceMigration).Append("\n");
            sb.Append("  DisallowReauthentication: ").Append(DisallowReauthentication).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  MaxTtl: ").Append(MaxTtl).Append("\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
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
            return this.Equals(input as AWSWriteAuthRoleTagRequest);
        }

        /// <summary>
        /// Returns true if AWSWriteAuthRoleTagRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AWSWriteAuthRoleTagRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AWSWriteAuthRoleTagRequest input)
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
                    this.DisallowReauthentication == input.DisallowReauthentication ||

                    this.DisallowReauthentication.Equals(input.DisallowReauthentication)
                ) &&
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))

                ) &&
                (
                    this.MaxTtl == input.MaxTtl ||

                    this.MaxTtl.Equals(input.MaxTtl)
                ) &&
                (
                    this.Policies == input.Policies ||
                    this.Policies != null &&
                    input.Policies != null &&
                    this.Policies.SequenceEqual(input.Policies)
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

                hashCode = (hashCode * 59) + this.DisallowReauthentication.GetHashCode();
                if (this.InstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.InstanceId.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.MaxTtl.GetHashCode();
                if (this.Policies != null)
                {
                    hashCode = (hashCode * 59) + this.Policies.GetHashCode();
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
