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
    /// LDAPWriteRoleRequest
    /// </summary>
    [DataContract(Name = "LDAPWriteRoleRequest")]
    public partial class LDAPWriteRoleRequest : IEquatable<LDAPWriteRoleRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LDAPWriteRoleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LDAPWriteRoleRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LDAPWriteRoleRequest" /> class.
        /// </summary>
        /// <param name="creationLdif">LDIF string used to create new entities within the LDAP system. This LDIF can be templated. (required).</param>
        /// <param name="defaultTtl">Default TTL for dynamic credentials.</param>
        /// <param name="deletionLdif">LDIF string used to delete entities created within the LDAP system. This LDIF can be templated. (required).</param>
        /// <param name="maxTtl">Max TTL a dynamic credential can be extended to.</param>
        /// <param name="rollbackLdif">LDIF string used to rollback changes in the event of a failure to create credentials. This LDIF can be templated..</param>
        /// <param name="usernameTemplate">The template used to create a username.</param>
        public LDAPWriteRoleRequest(string creationLdif = default(string), int defaultTtl = default(int), string deletionLdif = default(string), int maxTtl = default(int), string rollbackLdif = default(string), string usernameTemplate = default(string))
        {
            // to ensure "creationLdif" is required (not null)
            if (creationLdif == null) {
                throw new ArgumentNullException("creationLdif is a required property for LDAPWriteRoleRequest and cannot be null");
            }
            this.CreationLdif = creationLdif;
            // to ensure "deletionLdif" is required (not null)
            if (deletionLdif == null) {
                throw new ArgumentNullException("deletionLdif is a required property for LDAPWriteRoleRequest and cannot be null");
            }
            this.DeletionLdif = deletionLdif;
            this.DefaultTtl = defaultTtl;
            this.MaxTtl = maxTtl;
            this.RollbackLdif = rollbackLdif;
            this.UsernameTemplate = usernameTemplate;
        }

        /// <summary>
        /// LDIF string used to create new entities within the LDAP system. This LDIF can be templated.
        /// </summary>
        /// <value>LDIF string used to create new entities within the LDAP system. This LDIF can be templated.</value>
        [DataMember(Name = "creation_ldif", IsRequired = true, EmitDefaultValue = false)]
        public string CreationLdif { get; set; }

        /// <summary>
        /// Default TTL for dynamic credentials
        /// </summary>
        /// <value>Default TTL for dynamic credentials</value>
        [DataMember(Name = "default_ttl", EmitDefaultValue = false)]
        public int DefaultTtl { get; set; }

        /// <summary>
        /// LDIF string used to delete entities created within the LDAP system. This LDIF can be templated.
        /// </summary>
        /// <value>LDIF string used to delete entities created within the LDAP system. This LDIF can be templated.</value>
        [DataMember(Name = "deletion_ldif", IsRequired = true, EmitDefaultValue = false)]
        public string DeletionLdif { get; set; }

        /// <summary>
        /// Max TTL a dynamic credential can be extended to
        /// </summary>
        /// <value>Max TTL a dynamic credential can be extended to</value>
        [DataMember(Name = "max_ttl", EmitDefaultValue = false)]
        public int MaxTtl { get; set; }

        /// <summary>
        /// LDIF string used to rollback changes in the event of a failure to create credentials. This LDIF can be templated.
        /// </summary>
        /// <value>LDIF string used to rollback changes in the event of a failure to create credentials. This LDIF can be templated.</value>
        [DataMember(Name = "rollback_ldif", EmitDefaultValue = false)]
        public string RollbackLdif { get; set; }

        /// <summary>
        /// The template used to create a username
        /// </summary>
        /// <value>The template used to create a username</value>
        [DataMember(Name = "username_template", EmitDefaultValue = false)]
        public string UsernameTemplate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LDAPWriteRoleRequest {\n");
            sb.Append("  CreationLdif: ").Append(CreationLdif).Append("\n");
            sb.Append("  DefaultTtl: ").Append(DefaultTtl).Append("\n");
            sb.Append("  DeletionLdif: ").Append(DeletionLdif).Append("\n");
            sb.Append("  MaxTtl: ").Append(MaxTtl).Append("\n");
            sb.Append("  RollbackLdif: ").Append(RollbackLdif).Append("\n");
            sb.Append("  UsernameTemplate: ").Append(UsernameTemplate).Append("\n");
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
            return this.Equals(input as LDAPWriteRoleRequest);
        }

        /// <summary>
        /// Returns true if LDAPWriteRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LDAPWriteRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LDAPWriteRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreationLdif == input.CreationLdif ||
                    (this.CreationLdif != null &&
                    this.CreationLdif.Equals(input.CreationLdif))
                ) && 
                (
                    this.DefaultTtl == input.DefaultTtl ||
                    this.DefaultTtl.Equals(input.DefaultTtl)
                ) && 
                (
                    this.DeletionLdif == input.DeletionLdif ||
                    (this.DeletionLdif != null &&
                    this.DeletionLdif.Equals(input.DeletionLdif))
                ) && 
                (
                    this.MaxTtl == input.MaxTtl ||
                    this.MaxTtl.Equals(input.MaxTtl)
                ) && 
                (
                    this.RollbackLdif == input.RollbackLdif ||
                    (this.RollbackLdif != null &&
                    this.RollbackLdif.Equals(input.RollbackLdif))
                ) && 
                (
                    this.UsernameTemplate == input.UsernameTemplate ||
                    (this.UsernameTemplate != null &&
                    this.UsernameTemplate.Equals(input.UsernameTemplate))
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
                if (this.CreationLdif != null)
                {
                    hashCode = (hashCode * 59) + this.CreationLdif.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DefaultTtl.GetHashCode();
                if (this.DeletionLdif != null)
                {
                    hashCode = (hashCode * 59) + this.DeletionLdif.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxTtl.GetHashCode();
                if (this.RollbackLdif != null)
                {
                    hashCode = (hashCode * 59) + this.RollbackLdif.GetHashCode();
                }
                if (this.UsernameTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.UsernameTemplate.GetHashCode();
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
