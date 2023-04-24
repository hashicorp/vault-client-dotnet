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
    /// AppRoleLookUpSecretIdByAccessorResponse
    /// </summary>
    [DataContract(Name = "AppRoleLookUpSecretIdByAccessorResponse")]
    public partial class AppRoleLookUpSecretIdByAccessorResponse : IEquatable<AppRoleLookUpSecretIdByAccessorResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="AppRoleLookUpSecretIdByAccessorResponse" /> class.
        /// </summary>

        /// <param name="CidrList">List of CIDR blocks enforcing secret IDs to be used from specific set of IP addresses. If &#x27;bound_cidr_list&#x27; is set on the role, then the list of CIDR blocks listed here should be a subset of the CIDR blocks listed on the role..</param>

        /// <param name="CreationTime">CreationTime.</param>

        /// <param name="ExpirationTime">ExpirationTime.</param>

        /// <param name="LastUpdatedTime">LastUpdatedTime.</param>

        /// <param name="Metadata">Metadata.</param>

        /// <param name="SecretIdAccessor">Accessor of the secret ID.</param>

        /// <param name="SecretIdNumUses">Number of times a secret ID can access the role, after which the secret ID will expire..</param>

        /// <param name="SecretIdTtl">Duration in seconds after which the issued secret ID expires..</param>

        /// <param name="TokenBoundCidrs">List of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token. Should be a subset of the token CIDR blocks listed on the role, if any..</param>


        public AppRoleLookUpSecretIdByAccessorResponse(List<string> CidrList = default(List<string>), DateTime CreationTime = default(DateTime), DateTime ExpirationTime = default(DateTime), DateTime LastUpdatedTime = default(DateTime), Object Metadata = default(Object), string SecretIdAccessor = default(string), int SecretIdNumUses = default(int), int SecretIdTtl = default(int), List<string> TokenBoundCidrs = default(List<string>))
        {

            this.CidrList = CidrList;

            this.CreationTime = CreationTime;

            this.ExpirationTime = ExpirationTime;

            this.LastUpdatedTime = LastUpdatedTime;

            this.Metadata = Metadata;

            this.SecretIdAccessor = SecretIdAccessor;

            this.SecretIdNumUses = SecretIdNumUses;

            this.SecretIdTtl = SecretIdTtl;

            this.TokenBoundCidrs = TokenBoundCidrs;

        }

        /// <summary>
        /// List of CIDR blocks enforcing secret IDs to be used from specific set of IP addresses. If &#x27;bound_cidr_list&#x27; is set on the role, then the list of CIDR blocks listed here should be a subset of the CIDR blocks listed on the role.
        /// </summary>
        /// <value>List of CIDR blocks enforcing secret IDs to be used from specific set of IP addresses. If &#x27;bound_cidr_list&#x27; is set on the role, then the list of CIDR blocks listed here should be a subset of the CIDR blocks listed on the role.</value>
        [DataMember(Name = "cidr_list", EmitDefaultValue = false)]

        public List<string> CidrList { get; set; }


        /// <summary>
        /// Gets or Sets CreationTime
        /// </summary>
        [DataMember(Name = "creation_time", EmitDefaultValue = false)]

        public DateTime CreationTime { get; set; }


        /// <summary>
        /// Gets or Sets ExpirationTime
        /// </summary>
        [DataMember(Name = "expiration_time", EmitDefaultValue = false)]

        public DateTime ExpirationTime { get; set; }


        /// <summary>
        /// Gets or Sets LastUpdatedTime
        /// </summary>
        [DataMember(Name = "last_updated_time", EmitDefaultValue = false)]

        public DateTime LastUpdatedTime { get; set; }


        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]

        public Object Metadata { get; set; }


        /// <summary>
        /// Accessor of the secret ID
        /// </summary>
        /// <value>Accessor of the secret ID</value>
        [DataMember(Name = "secret_id_accessor", EmitDefaultValue = false)]

        public string SecretIdAccessor { get; set; }


        /// <summary>
        /// Number of times a secret ID can access the role, after which the secret ID will expire.
        /// </summary>
        /// <value>Number of times a secret ID can access the role, after which the secret ID will expire.</value>
        [DataMember(Name = "secret_id_num_uses", EmitDefaultValue = false)]

        public int SecretIdNumUses { get; set; }


        /// <summary>
        /// Duration in seconds after which the issued secret ID expires.
        /// </summary>
        /// <value>Duration in seconds after which the issued secret ID expires.</value>
        [DataMember(Name = "secret_id_ttl", EmitDefaultValue = false)]

        public int SecretIdTtl { get; set; }


        /// <summary>
        /// List of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token. Should be a subset of the token CIDR blocks listed on the role, if any.
        /// </summary>
        /// <value>List of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token. Should be a subset of the token CIDR blocks listed on the role, if any.</value>
        [DataMember(Name = "token_bound_cidrs", EmitDefaultValue = false)]

        public List<string> TokenBoundCidrs { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppRoleLookUpSecretIdByAccessorResponse {\n");
            sb.Append("  CidrList: ").Append(CidrList).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  ExpirationTime: ").Append(ExpirationTime).Append("\n");
            sb.Append("  LastUpdatedTime: ").Append(LastUpdatedTime).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  SecretIdAccessor: ").Append(SecretIdAccessor).Append("\n");
            sb.Append("  SecretIdNumUses: ").Append(SecretIdNumUses).Append("\n");
            sb.Append("  SecretIdTtl: ").Append(SecretIdTtl).Append("\n");
            sb.Append("  TokenBoundCidrs: ").Append(TokenBoundCidrs).Append("\n");
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
            return this.Equals(input as AppRoleLookUpSecretIdByAccessorResponse);
        }

        /// <summary>
        /// Returns true if AppRoleLookUpSecretIdByAccessorResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AppRoleLookUpSecretIdByAccessorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppRoleLookUpSecretIdByAccessorResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.CidrList == input.CidrList ||
                    this.CidrList != null &&
                    input.CidrList != null &&
                    this.CidrList.SequenceEqual(input.CidrList)
                ) &&
                (
                    this.CreationTime == input.CreationTime ||
                    (this.CreationTime != null &&
                    this.CreationTime.Equals(input.CreationTime))

                ) &&
                (
                    this.ExpirationTime == input.ExpirationTime ||
                    (this.ExpirationTime != null &&
                    this.ExpirationTime.Equals(input.ExpirationTime))

                ) &&
                (
                    this.LastUpdatedTime == input.LastUpdatedTime ||
                    (this.LastUpdatedTime != null &&
                    this.LastUpdatedTime.Equals(input.LastUpdatedTime))

                ) &&
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))

                ) &&
                (
                    this.SecretIdAccessor == input.SecretIdAccessor ||
                    (this.SecretIdAccessor != null &&
                    this.SecretIdAccessor.Equals(input.SecretIdAccessor))

                ) &&
                (
                    this.SecretIdNumUses == input.SecretIdNumUses ||

                    this.SecretIdNumUses.Equals(input.SecretIdNumUses)
                ) &&
                (
                    this.SecretIdTtl == input.SecretIdTtl ||

                    this.SecretIdTtl.Equals(input.SecretIdTtl)
                ) &&
                (
                    this.TokenBoundCidrs == input.TokenBoundCidrs ||
                    this.TokenBoundCidrs != null &&
                    input.TokenBoundCidrs != null &&
                    this.TokenBoundCidrs.SequenceEqual(input.TokenBoundCidrs)
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

                if (this.CidrList != null)
                {
                    hashCode = (hashCode * 59) + this.CidrList.GetHashCode();
                }

                if (this.CreationTime != null)
                {
                    hashCode = (hashCode * 59) + this.CreationTime.GetHashCode();
                }

                if (this.ExpirationTime != null)
                {
                    hashCode = (hashCode * 59) + this.ExpirationTime.GetHashCode();
                }

                if (this.LastUpdatedTime != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdatedTime.GetHashCode();
                }

                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }

                if (this.SecretIdAccessor != null)
                {
                    hashCode = (hashCode * 59) + this.SecretIdAccessor.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.SecretIdNumUses.GetHashCode();

                hashCode = (hashCode * 59) + this.SecretIdTtl.GetHashCode();
                if (this.TokenBoundCidrs != null)
                {
                    hashCode = (hashCode * 59) + this.TokenBoundCidrs.GetHashCode();
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
