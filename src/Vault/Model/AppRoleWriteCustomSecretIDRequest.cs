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
    /// AppRoleWriteCustomSecretIDRequest
    /// </summary>
    [DataContract(Name = "AppRoleWriteCustomSecretIDRequest")]
    public partial class AppRoleWriteCustomSecretIDRequest : IEquatable<AppRoleWriteCustomSecretIDRequest>, IValidatableObject
    {















        /// <summary>
        /// Initializes a new instance of the <see cref="AppRoleWriteCustomSecretIDRequest" /> class.
        /// </summary>

        /// <param name="CidrList">Comma separated string or list of CIDR blocks enforcing secret IDs to be used from specific set of IP addresses. If &#x27;bound_cidr_list&#x27; is set on the role, then the list of CIDR blocks listed here should be a subset of the CIDR blocks listed on the role..</param>

        /// <param name="Metadata">Metadata to be tied to the SecretID. This should be a JSON formatted string containing metadata in key value pairs..</param>

        /// <param name="NumUses">Number of times this SecretID can be used, after which the SecretID expires. Overrides secret_id_num_uses role option when supplied. May not be higher than role&#x27;s secret_id_num_uses..</param>

        /// <param name="SecretId">SecretID to be attached to the role..</param>

        /// <param name="TokenBoundCidrs">Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token. Should be a subset of the token CIDR blocks listed on the role, if any..</param>

        /// <param name="Ttl">Duration in seconds after which this SecretID expires. Overrides secret_id_ttl role option when supplied. May not be longer than role&#x27;s secret_id_ttl..</param>


        public AppRoleWriteCustomSecretIDRequest(List<string> CidrList = default(List<string>), string Metadata = default(string), int NumUses = default(int), string SecretId = default(string), List<string> TokenBoundCidrs = default(List<string>), int Ttl = default(int))
        {

            this.CidrList = CidrList;

            this.Metadata = Metadata;

            this.NumUses = NumUses;

            this.SecretId = SecretId;

            this.TokenBoundCidrs = TokenBoundCidrs;

            this.Ttl = Ttl;

        }

        /// <summary>
        /// Comma separated string or list of CIDR blocks enforcing secret IDs to be used from specific set of IP addresses. If &#x27;bound_cidr_list&#x27; is set on the role, then the list of CIDR blocks listed here should be a subset of the CIDR blocks listed on the role.
        /// </summary>
        /// <value>Comma separated string or list of CIDR blocks enforcing secret IDs to be used from specific set of IP addresses. If &#x27;bound_cidr_list&#x27; is set on the role, then the list of CIDR blocks listed here should be a subset of the CIDR blocks listed on the role.</value>
        [DataMember(Name = "cidr_list", EmitDefaultValue = false)]


        public List<string> CidrList { get; set; }


        /// <summary>
        /// Metadata to be tied to the SecretID. This should be a JSON formatted string containing metadata in key value pairs.
        /// </summary>
        /// <value>Metadata to be tied to the SecretID. This should be a JSON formatted string containing metadata in key value pairs.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]


        public string Metadata { get; set; }


        /// <summary>
        /// Number of times this SecretID can be used, after which the SecretID expires. Overrides secret_id_num_uses role option when supplied. May not be higher than role&#x27;s secret_id_num_uses.
        /// </summary>
        /// <value>Number of times this SecretID can be used, after which the SecretID expires. Overrides secret_id_num_uses role option when supplied. May not be higher than role&#x27;s secret_id_num_uses.</value>
        [DataMember(Name = "num_uses", EmitDefaultValue = false)]


        public int NumUses { get; set; }


        /// <summary>
        /// SecretID to be attached to the role.
        /// </summary>
        /// <value>SecretID to be attached to the role.</value>
        [DataMember(Name = "secret_id", EmitDefaultValue = false)]


        public string SecretId { get; set; }


        /// <summary>
        /// Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token. Should be a subset of the token CIDR blocks listed on the role, if any.
        /// </summary>
        /// <value>Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can use the returned token. Should be a subset of the token CIDR blocks listed on the role, if any.</value>
        [DataMember(Name = "token_bound_cidrs", EmitDefaultValue = false)]


        public List<string> TokenBoundCidrs { get; set; }


        /// <summary>
        /// Duration in seconds after which this SecretID expires. Overrides secret_id_ttl role option when supplied. May not be longer than role&#x27;s secret_id_ttl.
        /// </summary>
        /// <value>Duration in seconds after which this SecretID expires. Overrides secret_id_ttl role option when supplied. May not be longer than role&#x27;s secret_id_ttl.</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]


        public int Ttl { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppRoleWriteCustomSecretIDRequest {\n");
            sb.Append("  CidrList: ").Append(CidrList).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  NumUses: ").Append(NumUses).Append("\n");
            sb.Append("  SecretId: ").Append(SecretId).Append("\n");
            sb.Append("  TokenBoundCidrs: ").Append(TokenBoundCidrs).Append("\n");
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
            return this.Equals(input as AppRoleWriteCustomSecretIDRequest);
        }

        /// <summary>
        /// Returns true if AppRoleWriteCustomSecretIDRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AppRoleWriteCustomSecretIDRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppRoleWriteCustomSecretIDRequest input)
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
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))

                ) &&
                (
                    this.NumUses == input.NumUses ||

                    this.NumUses.Equals(input.NumUses)
                ) &&
                (
                    this.SecretId == input.SecretId ||
                    (this.SecretId != null &&
                    this.SecretId.Equals(input.SecretId))

                ) &&
                (
                    this.TokenBoundCidrs == input.TokenBoundCidrs ||
                    this.TokenBoundCidrs != null &&
                    input.TokenBoundCidrs != null &&
                    this.TokenBoundCidrs.SequenceEqual(input.TokenBoundCidrs)
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

                if (this.CidrList != null)
                {
                    hashCode = (hashCode * 59) + this.CidrList.GetHashCode();
                }

                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.NumUses.GetHashCode();
                if (this.SecretId != null)
                {
                    hashCode = (hashCode * 59) + this.SecretId.GetHashCode();
                }

                if (this.TokenBoundCidrs != null)
                {
                    hashCode = (hashCode * 59) + this.TokenBoundCidrs.GetHashCode();
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
