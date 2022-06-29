/*
 * HashiCorp Vault API
 *
 * HTTP API that gives you full access to Vault. All API routes are prefixed with `/v1/`.
 *
 * The version of the OpenAPI document: 1.11.0
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
using FileParameter = VaultClient.Client.FileParameter;
using OpenAPIDateConverter = VaultClient.Client.OpenAPIDateConverter;

namespace VaultClient.Model
{
    /// <summary>
    /// IdentityEntityAliasIdRequest
    /// </summary>
    [DataContract(Name = "IdentityEntityAliasIdRequest")]
    public partial class IdentityEntityAliasIdRequest : IEquatable<IdentityEntityAliasIdRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityEntityAliasIdRequest" /> class.
        /// </summary>
        /// <param name="canonicalId">Entity ID to which this alias should be tied to.</param>
        /// <param name="customMetadata">User provided key-value pairs.</param>
        /// <param name="entityId">Entity ID to which this alias belongs to. This field is deprecated, use canonical_id..</param>
        /// <param name="mountAccessor">(Unused).</param>
        /// <param name="name">(Unused).</param>
        public IdentityEntityAliasIdRequest(string canonicalId = default(string), Object customMetadata = default(Object), string entityId = default(string), string mountAccessor = default(string), string name = default(string))
        {
            this.CanonicalId = canonicalId;
            this.CustomMetadata = customMetadata;
            this.EntityId = entityId;
            this.MountAccessor = mountAccessor;
            this.Name = name;
        }

        /// <summary>
        /// Entity ID to which this alias should be tied to
        /// </summary>
        /// <value>Entity ID to which this alias should be tied to</value>
        [DataMember(Name = "canonical_id", EmitDefaultValue = false)]
        public string CanonicalId { get; set; }

        /// <summary>
        /// User provided key-value pairs
        /// </summary>
        /// <value>User provided key-value pairs</value>
        [DataMember(Name = "custom_metadata", EmitDefaultValue = false)]
        public Object CustomMetadata { get; set; }

        /// <summary>
        /// Entity ID to which this alias belongs to. This field is deprecated, use canonical_id.
        /// </summary>
        /// <value>Entity ID to which this alias belongs to. This field is deprecated, use canonical_id.</value>
        [DataMember(Name = "entity_id", EmitDefaultValue = false)]
        public string EntityId { get; set; }

        /// <summary>
        /// (Unused)
        /// </summary>
        /// <value>(Unused)</value>
        [DataMember(Name = "mount_accessor", EmitDefaultValue = false)]
        public string MountAccessor { get; set; }

        /// <summary>
        /// (Unused)
        /// </summary>
        /// <value>(Unused)</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IdentityEntityAliasIdRequest {\n");
            sb.Append("  CanonicalId: ").Append(CanonicalId).Append("\n");
            sb.Append("  CustomMetadata: ").Append(CustomMetadata).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  MountAccessor: ").Append(MountAccessor).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as IdentityEntityAliasIdRequest);
        }

        /// <summary>
        /// Returns true if IdentityEntityAliasIdRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of IdentityEntityAliasIdRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentityEntityAliasIdRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CanonicalId == input.CanonicalId ||
                    (this.CanonicalId != null &&
                    this.CanonicalId.Equals(input.CanonicalId))
                ) && 
                (
                    this.CustomMetadata == input.CustomMetadata ||
                    (this.CustomMetadata != null &&
                    this.CustomMetadata.Equals(input.CustomMetadata))
                ) && 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.MountAccessor == input.MountAccessor ||
                    (this.MountAccessor != null &&
                    this.MountAccessor.Equals(input.MountAccessor))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.CanonicalId != null)
                {
                    hashCode = (hashCode * 59) + this.CanonicalId.GetHashCode();
                }
                if (this.CustomMetadata != null)
                {
                    hashCode = (hashCode * 59) + this.CustomMetadata.GetHashCode();
                }
                if (this.EntityId != null)
                {
                    hashCode = (hashCode * 59) + this.EntityId.GetHashCode();
                }
                if (this.MountAccessor != null)
                {
                    hashCode = (hashCode * 59) + this.MountAccessor.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
