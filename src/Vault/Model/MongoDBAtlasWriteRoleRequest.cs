// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

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
    /// MongoDBAtlasWriteRoleRequest
    /// </summary>
    [DataContract(Name = "MongoDBAtlasWriteRoleRequest")]
    public partial class MongoDBAtlasWriteRoleRequest : IEquatable<MongoDBAtlasWriteRoleRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MongoDBAtlasWriteRoleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MongoDBAtlasWriteRoleRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MongoDBAtlasWriteRoleRequest" /> class.
        /// </summary>
        /// <param name="cidrBlocks">Access list entry in CIDR notation to be added for the API key. Optional for organization and project keys..</param>
        /// <param name="ipAddresses">IP address to be added to the access list for the API key. Optional for organization and project keys..</param>
        /// <param name="maxTtl">The maximum allowed lifetime of credentials issued using this role..</param>
        /// <param name="organizationId">Organization ID required for an organization API key.</param>
        /// <param name="projectId">Project ID the project API key belongs to..</param>
        /// <param name="projectRoles">Roles assigned when an organization API Key is assigned to a project API key.</param>
        /// <param name="roles">List of roles that the API Key should be granted. A minimum of one role must be provided. Any roles provided must be valid for the assigned Project, required for organization and project keys. (required).</param>
        /// <param name="ttl">Duration in seconds after which the issued credential should expire. Defaults to 0, in which case the value will fallback to the system/mount defaults..</param>
        public MongoDBAtlasWriteRoleRequest(List<string> cidrBlocks = default(List<string>), List<string> ipAddresses = default(List<string>), int maxTtl = default(int), string organizationId = default(string), string projectId = default(string), List<string> projectRoles = default(List<string>), List<string> roles = default(List<string>), int ttl = default(int))
        {
            // to ensure "roles" is required (not null)
            if (roles == null) {
                throw new ArgumentNullException("roles is a required property for MongoDBAtlasWriteRoleRequest and cannot be null");
            }
            this.Roles = roles;
            this.CidrBlocks = cidrBlocks;
            this.IpAddresses = ipAddresses;
            this.MaxTtl = maxTtl;
            this.OrganizationId = organizationId;
            this.ProjectId = projectId;
            this.ProjectRoles = projectRoles;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Access list entry in CIDR notation to be added for the API key. Optional for organization and project keys.
        /// </summary>
        /// <value>Access list entry in CIDR notation to be added for the API key. Optional for organization and project keys.</value>
        [DataMember(Name = "cidr_blocks", EmitDefaultValue = false)]
        public List<string> CidrBlocks { get; set; }

        /// <summary>
        /// IP address to be added to the access list for the API key. Optional for organization and project keys.
        /// </summary>
        /// <value>IP address to be added to the access list for the API key. Optional for organization and project keys.</value>
        [DataMember(Name = "ip_addresses", EmitDefaultValue = false)]
        public List<string> IpAddresses { get; set; }

        /// <summary>
        /// The maximum allowed lifetime of credentials issued using this role.
        /// </summary>
        /// <value>The maximum allowed lifetime of credentials issued using this role.</value>
        [DataMember(Name = "max_ttl", EmitDefaultValue = false)]
        public int MaxTtl { get; set; }

        /// <summary>
        /// Organization ID required for an organization API key
        /// </summary>
        /// <value>Organization ID required for an organization API key</value>
        [DataMember(Name = "organization_id", EmitDefaultValue = false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Project ID the project API key belongs to.
        /// </summary>
        /// <value>Project ID the project API key belongs to.</value>
        [DataMember(Name = "project_id", EmitDefaultValue = false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Roles assigned when an organization API Key is assigned to a project API key
        /// </summary>
        /// <value>Roles assigned when an organization API Key is assigned to a project API key</value>
        [DataMember(Name = "project_roles", EmitDefaultValue = false)]
        public List<string> ProjectRoles { get; set; }

        /// <summary>
        /// List of roles that the API Key should be granted. A minimum of one role must be provided. Any roles provided must be valid for the assigned Project, required for organization and project keys.
        /// </summary>
        /// <value>List of roles that the API Key should be granted. A minimum of one role must be provided. Any roles provided must be valid for the assigned Project, required for organization and project keys.</value>
        [DataMember(Name = "roles", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Duration in seconds after which the issued credential should expire. Defaults to 0, in which case the value will fallback to the system/mount defaults.
        /// </summary>
        /// <value>Duration in seconds after which the issued credential should expire. Defaults to 0, in which case the value will fallback to the system/mount defaults.</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]
        public int Ttl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MongoDBAtlasWriteRoleRequest {\n");
            sb.Append("  CidrBlocks: ").Append(CidrBlocks).Append("\n");
            sb.Append("  IpAddresses: ").Append(IpAddresses).Append("\n");
            sb.Append("  MaxTtl: ").Append(MaxTtl).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  ProjectRoles: ").Append(ProjectRoles).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
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
            return this.Equals(input as MongoDBAtlasWriteRoleRequest);
        }

        /// <summary>
        /// Returns true if MongoDBAtlasWriteRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MongoDBAtlasWriteRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MongoDBAtlasWriteRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CidrBlocks == input.CidrBlocks ||
                    this.CidrBlocks != null &&
                    input.CidrBlocks != null &&
                    this.CidrBlocks.SequenceEqual(input.CidrBlocks)
                ) && 
                (
                    this.IpAddresses == input.IpAddresses ||
                    this.IpAddresses != null &&
                    input.IpAddresses != null &&
                    this.IpAddresses.SequenceEqual(input.IpAddresses)
                ) && 
                (
                    this.MaxTtl == input.MaxTtl ||
                    this.MaxTtl.Equals(input.MaxTtl)
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ProjectRoles == input.ProjectRoles ||
                    this.ProjectRoles != null &&
                    input.ProjectRoles != null &&
                    this.ProjectRoles.SequenceEqual(input.ProjectRoles)
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
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
                if (this.CidrBlocks != null)
                {
                    hashCode = (hashCode * 59) + this.CidrBlocks.GetHashCode();
                }
                if (this.IpAddresses != null)
                {
                    hashCode = (hashCode * 59) + this.IpAddresses.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxTtl.GetHashCode();
                if (this.OrganizationId != null)
                {
                    hashCode = (hashCode * 59) + this.OrganizationId.GetHashCode();
                }
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                if (this.ProjectRoles != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectRoles.GetHashCode();
                }
                if (this.Roles != null)
                {
                    hashCode = (hashCode * 59) + this.Roles.GetHashCode();
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
