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
    /// AzureWriteRoleRequest
    /// </summary>
    [DataContract(Name = "AzureWriteRoleRequest")]
    public partial class AzureWriteRoleRequest : IEquatable<AzureWriteRoleRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureWriteRoleRequest" /> class.
        /// </summary>
        /// <param name="applicationObjectId">Application Object ID to use for static service principal credentials..</param>
        /// <param name="azureGroups">JSON list of Azure groups to add the service principal to..</param>
        /// <param name="azureRoles">JSON list of Azure roles to assign..</param>
        /// <param name="maxTtl">Maximum time a service principal. If not set or set to 0, will use system default..</param>
        /// <param name="permanentlyDelete">Indicates whether new application objects should be permanently deleted. If not set, objects will not be permanently deleted. (default to false).</param>
        /// <param name="ttl">Default lease for generated credentials. If not set or set to 0, will use system default..</param>
        public AzureWriteRoleRequest(string applicationObjectId = default(string), string azureGroups = default(string), string azureRoles = default(string), int maxTtl = default(int), bool permanentlyDelete = false, int ttl = default(int))
        {
            this.ApplicationObjectId = applicationObjectId;
            this.AzureGroups = azureGroups;
            this.AzureRoles = azureRoles;
            this.MaxTtl = maxTtl;
            this.PermanentlyDelete = permanentlyDelete;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Application Object ID to use for static service principal credentials.
        /// </summary>
        /// <value>Application Object ID to use for static service principal credentials.</value>
        [DataMember(Name = "application_object_id", EmitDefaultValue = false)]
        public string ApplicationObjectId { get; set; }

        /// <summary>
        /// JSON list of Azure groups to add the service principal to.
        /// </summary>
        /// <value>JSON list of Azure groups to add the service principal to.</value>
        [DataMember(Name = "azure_groups", EmitDefaultValue = false)]
        public string AzureGroups { get; set; }

        /// <summary>
        /// JSON list of Azure roles to assign.
        /// </summary>
        /// <value>JSON list of Azure roles to assign.</value>
        [DataMember(Name = "azure_roles", EmitDefaultValue = false)]
        public string AzureRoles { get; set; }

        /// <summary>
        /// Maximum time a service principal. If not set or set to 0, will use system default.
        /// </summary>
        /// <value>Maximum time a service principal. If not set or set to 0, will use system default.</value>
        [DataMember(Name = "max_ttl", EmitDefaultValue = false)]
        public int MaxTtl { get; set; }

        /// <summary>
        /// Indicates whether new application objects should be permanently deleted. If not set, objects will not be permanently deleted.
        /// </summary>
        /// <value>Indicates whether new application objects should be permanently deleted. If not set, objects will not be permanently deleted.</value>
        [DataMember(Name = "permanently_delete", EmitDefaultValue = true)]
        public bool PermanentlyDelete { get; set; }

        /// <summary>
        /// Default lease for generated credentials. If not set or set to 0, will use system default.
        /// </summary>
        /// <value>Default lease for generated credentials. If not set or set to 0, will use system default.</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]
        public int Ttl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AzureWriteRoleRequest {\n");
            sb.Append("  ApplicationObjectId: ").Append(ApplicationObjectId).Append("\n");
            sb.Append("  AzureGroups: ").Append(AzureGroups).Append("\n");
            sb.Append("  AzureRoles: ").Append(AzureRoles).Append("\n");
            sb.Append("  MaxTtl: ").Append(MaxTtl).Append("\n");
            sb.Append("  PermanentlyDelete: ").Append(PermanentlyDelete).Append("\n");
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
            return this.Equals(input as AzureWriteRoleRequest);
        }

        /// <summary>
        /// Returns true if AzureWriteRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AzureWriteRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AzureWriteRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApplicationObjectId == input.ApplicationObjectId ||
                    (this.ApplicationObjectId != null &&
                    this.ApplicationObjectId.Equals(input.ApplicationObjectId))
                ) && 
                (
                    this.AzureGroups == input.AzureGroups ||
                    (this.AzureGroups != null &&
                    this.AzureGroups.Equals(input.AzureGroups))
                ) && 
                (
                    this.AzureRoles == input.AzureRoles ||
                    (this.AzureRoles != null &&
                    this.AzureRoles.Equals(input.AzureRoles))
                ) && 
                (
                    this.MaxTtl == input.MaxTtl ||
                    this.MaxTtl.Equals(input.MaxTtl)
                ) && 
                (
                    this.PermanentlyDelete == input.PermanentlyDelete ||
                    this.PermanentlyDelete.Equals(input.PermanentlyDelete)
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
                if (this.ApplicationObjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationObjectId.GetHashCode();
                }
                if (this.AzureGroups != null)
                {
                    hashCode = (hashCode * 59) + this.AzureGroups.GetHashCode();
                }
                if (this.AzureRoles != null)
                {
                    hashCode = (hashCode * 59) + this.AzureRoles.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxTtl.GetHashCode();
                hashCode = (hashCode * 59) + this.PermanentlyDelete.GetHashCode();
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
