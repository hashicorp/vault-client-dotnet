/*
 * HashiCorp Vault API
 *
 * HTTP API that gives you full access to Vault. All API routes are prefixed with `/v1/`.
 *
 * The version of the OpenAPI document: 1.13.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


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
    /// AWSConfigWriteIdentityRequest
    /// </summary>
    [DataContract(Name = "AWSConfigWriteIdentityRequest")]
    public partial class AWSConfigWriteIdentityRequest : IEquatable<AWSConfigWriteIdentityRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AWSConfigWriteIdentityRequest" /> class.
        /// </summary>
        /// <param name="ec2Alias">Configure how the AWS auth method generates entity alias when using EC2 auth. Valid values are \&quot;role_id\&quot;, \&quot;instance_id\&quot;, and \&quot;image_id\&quot;. Defaults to \&quot;role_id\&quot;. (default to &quot;instance_id&quot;).</param>
        /// <param name="ec2Metadata">The metadata to include on the aliases and audit logs generated by this plugin. When set to &#39;default&#39;, includes: account_id, auth_type. These fields are available to add: ami_id, instance_id, region. Not editing this field means the &#39;default&#39; fields are included. Explicitly setting this field to empty overrides the &#39;default&#39; and means no metadata will be included. If not using &#39;default&#39;, explicit fields must be sent like: &#39;field1,field2&#39;..</param>
        /// <param name="iamAlias">Configure how the AWS auth method generates entity aliases when using IAM auth. Valid values are \&quot;role_id\&quot;, \&quot;unique_id\&quot;, and \&quot;full_arn\&quot;. Defaults to \&quot;role_id\&quot;. (default to &quot;unique_id&quot;).</param>
        /// <param name="iamMetadata">The metadata to include on the aliases and audit logs generated by this plugin. When set to &#39;default&#39;, includes: account_id, auth_type. These fields are available to add: canonical_arn, client_arn, client_user_id, inferred_aws_region, inferred_entity_id, inferred_entity_type. Not editing this field means the &#39;default&#39; fields are included. Explicitly setting this field to empty overrides the &#39;default&#39; and means no metadata will be included. If not using &#39;default&#39;, explicit fields must be sent like: &#39;field1,field2&#39;..</param>
        public AWSConfigWriteIdentityRequest(string ec2Alias = "instance_id", List<string> ec2Metadata = default(List<string>), string iamAlias = "unique_id", List<string> iamMetadata = default(List<string>))
        {
            // use default value if no "ec2Alias" provided
            this.Ec2Alias = ec2Alias ?? "instance_id";
            this.Ec2Metadata = ec2Metadata;
            // use default value if no "iamAlias" provided
            this.IamAlias = iamAlias ?? "unique_id";
            this.IamMetadata = iamMetadata;
        }

        /// <summary>
        /// Configure how the AWS auth method generates entity alias when using EC2 auth. Valid values are \&quot;role_id\&quot;, \&quot;instance_id\&quot;, and \&quot;image_id\&quot;. Defaults to \&quot;role_id\&quot;.
        /// </summary>
        /// <value>Configure how the AWS auth method generates entity alias when using EC2 auth. Valid values are \&quot;role_id\&quot;, \&quot;instance_id\&quot;, and \&quot;image_id\&quot;. Defaults to \&quot;role_id\&quot;.</value>
        [DataMember(Name = "ec2_alias", EmitDefaultValue = false)]
        public string Ec2Alias { get; set; }

        /// <summary>
        /// The metadata to include on the aliases and audit logs generated by this plugin. When set to &#39;default&#39;, includes: account_id, auth_type. These fields are available to add: ami_id, instance_id, region. Not editing this field means the &#39;default&#39; fields are included. Explicitly setting this field to empty overrides the &#39;default&#39; and means no metadata will be included. If not using &#39;default&#39;, explicit fields must be sent like: &#39;field1,field2&#39;.
        /// </summary>
        /// <value>The metadata to include on the aliases and audit logs generated by this plugin. When set to &#39;default&#39;, includes: account_id, auth_type. These fields are available to add: ami_id, instance_id, region. Not editing this field means the &#39;default&#39; fields are included. Explicitly setting this field to empty overrides the &#39;default&#39; and means no metadata will be included. If not using &#39;default&#39;, explicit fields must be sent like: &#39;field1,field2&#39;.</value>
        [DataMember(Name = "ec2_metadata", EmitDefaultValue = false)]
        public List<string> Ec2Metadata { get; set; }

        /// <summary>
        /// Configure how the AWS auth method generates entity aliases when using IAM auth. Valid values are \&quot;role_id\&quot;, \&quot;unique_id\&quot;, and \&quot;full_arn\&quot;. Defaults to \&quot;role_id\&quot;.
        /// </summary>
        /// <value>Configure how the AWS auth method generates entity aliases when using IAM auth. Valid values are \&quot;role_id\&quot;, \&quot;unique_id\&quot;, and \&quot;full_arn\&quot;. Defaults to \&quot;role_id\&quot;.</value>
        [DataMember(Name = "iam_alias", EmitDefaultValue = false)]
        public string IamAlias { get; set; }

        /// <summary>
        /// The metadata to include on the aliases and audit logs generated by this plugin. When set to &#39;default&#39;, includes: account_id, auth_type. These fields are available to add: canonical_arn, client_arn, client_user_id, inferred_aws_region, inferred_entity_id, inferred_entity_type. Not editing this field means the &#39;default&#39; fields are included. Explicitly setting this field to empty overrides the &#39;default&#39; and means no metadata will be included. If not using &#39;default&#39;, explicit fields must be sent like: &#39;field1,field2&#39;.
        /// </summary>
        /// <value>The metadata to include on the aliases and audit logs generated by this plugin. When set to &#39;default&#39;, includes: account_id, auth_type. These fields are available to add: canonical_arn, client_arn, client_user_id, inferred_aws_region, inferred_entity_id, inferred_entity_type. Not editing this field means the &#39;default&#39; fields are included. Explicitly setting this field to empty overrides the &#39;default&#39; and means no metadata will be included. If not using &#39;default&#39;, explicit fields must be sent like: &#39;field1,field2&#39;.</value>
        [DataMember(Name = "iam_metadata", EmitDefaultValue = false)]
        public List<string> IamMetadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AWSConfigWriteIdentityRequest {\n");
            sb.Append("  Ec2Alias: ").Append(Ec2Alias).Append("\n");
            sb.Append("  Ec2Metadata: ").Append(Ec2Metadata).Append("\n");
            sb.Append("  IamAlias: ").Append(IamAlias).Append("\n");
            sb.Append("  IamMetadata: ").Append(IamMetadata).Append("\n");
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
            return this.Equals(input as AWSConfigWriteIdentityRequest);
        }

        /// <summary>
        /// Returns true if AWSConfigWriteIdentityRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AWSConfigWriteIdentityRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AWSConfigWriteIdentityRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Ec2Alias == input.Ec2Alias ||
                    (this.Ec2Alias != null &&
                    this.Ec2Alias.Equals(input.Ec2Alias))
                ) && 
                (
                    this.Ec2Metadata == input.Ec2Metadata ||
                    this.Ec2Metadata != null &&
                    input.Ec2Metadata != null &&
                    this.Ec2Metadata.SequenceEqual(input.Ec2Metadata)
                ) && 
                (
                    this.IamAlias == input.IamAlias ||
                    (this.IamAlias != null &&
                    this.IamAlias.Equals(input.IamAlias))
                ) && 
                (
                    this.IamMetadata == input.IamMetadata ||
                    this.IamMetadata != null &&
                    input.IamMetadata != null &&
                    this.IamMetadata.SequenceEqual(input.IamMetadata)
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
                if (this.Ec2Alias != null)
                {
                    hashCode = (hashCode * 59) + this.Ec2Alias.GetHashCode();
                }
                if (this.Ec2Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Ec2Metadata.GetHashCode();
                }
                if (this.IamAlias != null)
                {
                    hashCode = (hashCode * 59) + this.IamAlias.GetHashCode();
                }
                if (this.IamMetadata != null)
                {
                    hashCode = (hashCode * 59) + this.IamMetadata.GetHashCode();
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
