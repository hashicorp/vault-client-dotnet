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
    /// TerraformWriteRoleRequest
    /// </summary>
    [DataContract(Name = "TerraformWriteRoleRequest")]

    public partial class TerraformWriteRoleRequest : IEquatable<TerraformWriteRoleRequest>, IValidatableObject
    {













        /// <summary>
        /// Initializes a new instance of the <see cref="TerraformWriteRoleRequest" /> class.
        /// </summary>

        /// <param name="MaxTtl">Maximum time for role. If not set or set to 0, will use system default..</param>

        /// <param name="Organization">Name of the Terraform Cloud or Enterprise organization.</param>

        /// <param name="TeamId">ID of the Terraform Cloud or Enterprise team under organization (e.g., settings/teams/team-xxxxxxxxxxxxx).</param>

        /// <param name="Ttl">Default lease for generated credentials. If not set or set to 0, will use system default..</param>

        /// <param name="UserId">ID of the Terraform Cloud or Enterprise user (e.g., user-xxxxxxxxxxxxxxxx).</param>


        public TerraformWriteRoleRequest(int MaxTtl = default(int), string Organization = default(string), string TeamId = default(string), int Ttl = default(int), string UserId = default(string))
        {

            this.MaxTtl = MaxTtl;

            this.Organization = Organization;

            this.TeamId = TeamId;

            this.Ttl = Ttl;

            this.UserId = UserId;

        }

        /// <summary>
        /// Maximum time for role. If not set or set to 0, will use system default.
        /// </summary>
        /// <value>Maximum time for role. If not set or set to 0, will use system default.</value>
        [DataMember(Name = "max_ttl", EmitDefaultValue = false)]


        public int MaxTtl { get; set; }


        /// <summary>
        /// Name of the Terraform Cloud or Enterprise organization
        /// </summary>
        /// <value>Name of the Terraform Cloud or Enterprise organization</value>
        [DataMember(Name = "organization", EmitDefaultValue = false)]


        public string Organization { get; set; }


        /// <summary>
        /// ID of the Terraform Cloud or Enterprise team under organization (e.g., settings/teams/team-xxxxxxxxxxxxx)
        /// </summary>
        /// <value>ID of the Terraform Cloud or Enterprise team under organization (e.g., settings/teams/team-xxxxxxxxxxxxx)</value>
        [DataMember(Name = "team_id", EmitDefaultValue = false)]


        public string TeamId { get; set; }


        /// <summary>
        /// Default lease for generated credentials. If not set or set to 0, will use system default.
        /// </summary>
        /// <value>Default lease for generated credentials. If not set or set to 0, will use system default.</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]


        public int Ttl { get; set; }


        /// <summary>
        /// ID of the Terraform Cloud or Enterprise user (e.g., user-xxxxxxxxxxxxxxxx)
        /// </summary>
        /// <value>ID of the Terraform Cloud or Enterprise user (e.g., user-xxxxxxxxxxxxxxxx)</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]


        public string UserId { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TerraformWriteRoleRequest {\n");
            sb.Append("  MaxTtl: ").Append(MaxTtl).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as TerraformWriteRoleRequest);
        }

        /// <summary>
        /// Returns true if TerraformWriteRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TerraformWriteRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TerraformWriteRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.MaxTtl == input.MaxTtl ||

                    this.MaxTtl.Equals(input.MaxTtl)
                ) &&
                (
                    this.Organization == input.Organization ||
                    (this.Organization != null &&
                    this.Organization.Equals(input.Organization))

                ) &&
                (
                    this.TeamId == input.TeamId ||
                    (this.TeamId != null &&
                    this.TeamId.Equals(input.TeamId))

                ) &&
                (
                    this.Ttl == input.Ttl ||

                    this.Ttl.Equals(input.Ttl)
                ) &&
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))

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


                hashCode = (hashCode * 59) + this.MaxTtl.GetHashCode();
                if (this.Organization != null)
                {
                    hashCode = (hashCode * 59) + this.Organization.GetHashCode();
                }

                if (this.TeamId != null)
                {
                    hashCode = (hashCode * 59) + this.TeamId.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
