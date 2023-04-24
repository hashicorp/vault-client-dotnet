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
    /// AliCloudWriteRoleRequest
    /// </summary>
    [DataContract(Name = "AliCloudWriteRoleRequest")]
    public partial class AliCloudWriteRoleRequest : IEquatable<AliCloudWriteRoleRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="AliCloudWriteRoleRequest" /> class.
        /// </summary>

        /// <param name="InlinePolicies">JSON of policies to be dynamically applied to users of this role..</param>

        /// <param name="MaxTtl">The maximum allowed lifetime of tokens issued using this role..</param>

        /// <param name="RemotePolicies">The name and type of each remote policy to be applied. Example: \&quot;name:AliyunRDSReadOnlyAccess,type:System\&quot;..</param>

        /// <param name="RoleArn">ARN of the role to be assumed. If provided, inline_policies and remote_policies should be blank. At creation time, this role must have configured trusted actors, and the access key and secret that will be used to assume the role (in /config) must qualify as a trusted actor..</param>

        /// <param name="Ttl">Duration in seconds after which the issued token should expire. Defaults to 0, in which case the value will fallback to the system/mount defaults..</param>


        public AliCloudWriteRoleRequest(string InlinePolicies = default(string), int MaxTtl = default(int), List<string> RemotePolicies = default(List<string>), string RoleArn = default(string), int Ttl = default(int))
        {

            this.InlinePolicies = InlinePolicies;

            this.MaxTtl = MaxTtl;

            this.RemotePolicies = RemotePolicies;

            this.RoleArn = RoleArn;

            this.Ttl = Ttl;

        }

        /// <summary>
        /// JSON of policies to be dynamically applied to users of this role.
        /// </summary>
        /// <value>JSON of policies to be dynamically applied to users of this role.</value>
        [DataMember(Name = "inline_policies", EmitDefaultValue = false)]

        public string InlinePolicies { get; set; }


        /// <summary>
        /// The maximum allowed lifetime of tokens issued using this role.
        /// </summary>
        /// <value>The maximum allowed lifetime of tokens issued using this role.</value>
        [DataMember(Name = "max_ttl", EmitDefaultValue = false)]

        public int MaxTtl { get; set; }


        /// <summary>
        /// The name and type of each remote policy to be applied. Example: \&quot;name:AliyunRDSReadOnlyAccess,type:System\&quot;.
        /// </summary>
        /// <value>The name and type of each remote policy to be applied. Example: \&quot;name:AliyunRDSReadOnlyAccess,type:System\&quot;.</value>
        [DataMember(Name = "remote_policies", EmitDefaultValue = false)]

        public List<string> RemotePolicies { get; set; }


        /// <summary>
        /// ARN of the role to be assumed. If provided, inline_policies and remote_policies should be blank. At creation time, this role must have configured trusted actors, and the access key and secret that will be used to assume the role (in /config) must qualify as a trusted actor.
        /// </summary>
        /// <value>ARN of the role to be assumed. If provided, inline_policies and remote_policies should be blank. At creation time, this role must have configured trusted actors, and the access key and secret that will be used to assume the role (in /config) must qualify as a trusted actor.</value>
        [DataMember(Name = "role_arn", EmitDefaultValue = false)]

        public string RoleArn { get; set; }


        /// <summary>
        /// Duration in seconds after which the issued token should expire. Defaults to 0, in which case the value will fallback to the system/mount defaults.
        /// </summary>
        /// <value>Duration in seconds after which the issued token should expire. Defaults to 0, in which case the value will fallback to the system/mount defaults.</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]

        public int Ttl { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AliCloudWriteRoleRequest {\n");
            sb.Append("  InlinePolicies: ").Append(InlinePolicies).Append("\n");
            sb.Append("  MaxTtl: ").Append(MaxTtl).Append("\n");
            sb.Append("  RemotePolicies: ").Append(RemotePolicies).Append("\n");
            sb.Append("  RoleArn: ").Append(RoleArn).Append("\n");
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
            return this.Equals(input as AliCloudWriteRoleRequest);
        }

        /// <summary>
        /// Returns true if AliCloudWriteRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AliCloudWriteRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AliCloudWriteRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.InlinePolicies == input.InlinePolicies ||
                    (this.InlinePolicies != null &&
                    this.InlinePolicies.Equals(input.InlinePolicies))

                ) &&
                (
                    this.MaxTtl == input.MaxTtl ||

                    this.MaxTtl.Equals(input.MaxTtl)
                ) &&
                (
                    this.RemotePolicies == input.RemotePolicies ||
                    this.RemotePolicies != null &&
                    input.RemotePolicies != null &&
                    this.RemotePolicies.SequenceEqual(input.RemotePolicies)
                ) &&
                (
                    this.RoleArn == input.RoleArn ||
                    (this.RoleArn != null &&
                    this.RoleArn.Equals(input.RoleArn))

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

                if (this.InlinePolicies != null)
                {
                    hashCode = (hashCode * 59) + this.InlinePolicies.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.MaxTtl.GetHashCode();
                if (this.RemotePolicies != null)
                {
                    hashCode = (hashCode * 59) + this.RemotePolicies.GetHashCode();
                }

                if (this.RoleArn != null)
                {
                    hashCode = (hashCode * 59) + this.RoleArn.GetHashCode();
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
