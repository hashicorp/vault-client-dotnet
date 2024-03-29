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
    /// LdapWriteDynamicRoleRequest
    /// </summary>
    [DataContract(Name = "LdapWriteDynamicRoleRequest")]
    public partial class LdapWriteDynamicRoleRequest : IEquatable<LdapWriteDynamicRoleRequest>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LdapWriteDynamicRoleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LdapWriteDynamicRoleRequest() { }


        /// <summary>
        /// Initializes a new instance of the <see cref="LdapWriteDynamicRoleRequest" /> class.
        /// </summary>

        /// <param name="CreationLdif">LDIF string used to create new entities within the LDAP system. This LDIF can be templated. (required).</param>

        /// <param name="DefaultTtl">Default TTL for dynamic credentials.</param>

        /// <param name="DeletionLdif">LDIF string used to delete entities created within the LDAP system. This LDIF can be templated. (required).</param>

        /// <param name="MaxTtl">Max TTL a dynamic credential can be extended to.</param>

        /// <param name="RollbackLdif">LDIF string used to rollback changes in the event of a failure to create credentials. This LDIF can be templated..</param>

        /// <param name="UsernameTemplate">The template used to create a username.</param>


        public LdapWriteDynamicRoleRequest(string CreationLdif = default(string), string DefaultTtl = default(string), string DeletionLdif = default(string), string MaxTtl = default(string), string RollbackLdif = default(string), string UsernameTemplate = default(string))
        {

            // to ensure "CreationLdif" is required (not null)
            if (CreationLdif == null)
            {
                throw new ArgumentNullException("CreationLdif is a required property for LdapWriteDynamicRoleRequest and cannot be null");
            }
            this.CreationLdif = CreationLdif;


            // to ensure "DeletionLdif" is required (not null)
            if (DeletionLdif == null)
            {
                throw new ArgumentNullException("DeletionLdif is a required property for LdapWriteDynamicRoleRequest and cannot be null");
            }
            this.DeletionLdif = DeletionLdif;


            this.DefaultTtl = DefaultTtl;

            this.MaxTtl = MaxTtl;

            this.RollbackLdif = RollbackLdif;

            this.UsernameTemplate = UsernameTemplate;

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

        public string DefaultTtl { get; set; }


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

        public string MaxTtl { get; set; }


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
            sb.Append("class LdapWriteDynamicRoleRequest {\n");
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
            return this.Equals(input as LdapWriteDynamicRoleRequest);
        }

        /// <summary>
        /// Returns true if LdapWriteDynamicRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LdapWriteDynamicRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LdapWriteDynamicRoleRequest input)
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
                    (this.DefaultTtl != null &&
                    this.DefaultTtl.Equals(input.DefaultTtl))

                ) &&
                (
                    this.DeletionLdif == input.DeletionLdif ||
                    (this.DeletionLdif != null &&
                    this.DeletionLdif.Equals(input.DeletionLdif))

                ) &&
                (
                    this.MaxTtl == input.MaxTtl ||
                    (this.MaxTtl != null &&
                    this.MaxTtl.Equals(input.MaxTtl))

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

                if (this.DefaultTtl != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultTtl.GetHashCode();
                }

                if (this.DeletionLdif != null)
                {
                    hashCode = (hashCode * 59) + this.DeletionLdif.GetHashCode();
                }

                if (this.MaxTtl != null)
                {
                    hashCode = (hashCode * 59) + this.MaxTtl.GetHashCode();
                }

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
