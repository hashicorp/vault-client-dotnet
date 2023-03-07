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
    /// DatabaseWriteRoleRequest
    /// </summary>
    [DataContract(Name = "DatabaseWriteRoleRequest")]
    public partial class DatabaseWriteRoleRequest : IEquatable<DatabaseWriteRoleRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseWriteRoleRequest" /> class.
        /// </summary>

        /// <param name="CreationStatements">Specifies the database statements executed to create and configure a user. See the plugin&#x27;s API page for more information on support and formatting for this parameter..</param>

        /// <param name="CredentialConfig">The configuration for the given credential_type..</param>

        /// <param name="CredentialType">The type of credential to manage. Options include: &#x27;password&#x27;, &#x27;rsa_private_key&#x27;. Defaults to &#x27;password&#x27;. (default to &quot;password&quot;).</param>

        /// <param name="DbName">Name of the database this role acts on..</param>

        /// <param name="DefaultTtl">Default ttl for role..</param>

        /// <param name="MaxTtl">Maximum time a credential is valid for.</param>

        /// <param name="RenewStatements">Specifies the database statements to be executed to renew a user. Not every plugin type will support this functionality. See the plugin&#x27;s API page for more information on support and formatting for this parameter..</param>

        /// <param name="RevocationStatements">Specifies the database statements to be executed to revoke a user. See the plugin&#x27;s API page for more information on support and formatting for this parameter..</param>

        /// <param name="RollbackStatements">Specifies the database statements to be executed rollback a create operation in the event of an error. Not every plugin type will support this functionality. See the plugin&#x27;s API page for more information on support and formatting for this parameter..</param>


        public DatabaseWriteRoleRequest(List<string> CreationStatements = default(List<string>), Object CredentialConfig = default(Object), string CredentialType = "password", string DbName = default(string), int DefaultTtl = default(int), int MaxTtl = default(int), List<string> RenewStatements = default(List<string>), List<string> RevocationStatements = default(List<string>), List<string> RollbackStatements = default(List<string>))
        {

            this.CreationStatements = CreationStatements;

            this.CredentialConfig = CredentialConfig;

            // use default value if no "CredentialType" provided
            this.CredentialType = CredentialType ?? "password";


            this.DbName = DbName;

            this.DefaultTtl = DefaultTtl;

            this.MaxTtl = MaxTtl;

            this.RenewStatements = RenewStatements;

            this.RevocationStatements = RevocationStatements;

            this.RollbackStatements = RollbackStatements;

        }

        /// <summary>
        /// Specifies the database statements executed to create and configure a user. See the plugin&#x27;s API page for more information on support and formatting for this parameter.
        /// </summary>
        /// <value>Specifies the database statements executed to create and configure a user. See the plugin&#x27;s API page for more information on support and formatting for this parameter.</value>
        [DataMember(Name = "creation_statements", EmitDefaultValue = false)]

        public List<string> CreationStatements { get; set; }


        /// <summary>
        /// The configuration for the given credential_type.
        /// </summary>
        /// <value>The configuration for the given credential_type.</value>
        [DataMember(Name = "credential_config", EmitDefaultValue = false)]

        public Object CredentialConfig { get; set; }


        /// <summary>
        /// The type of credential to manage. Options include: &#x27;password&#x27;, &#x27;rsa_private_key&#x27;. Defaults to &#x27;password&#x27;.
        /// </summary>
        /// <value>The type of credential to manage. Options include: &#x27;password&#x27;, &#x27;rsa_private_key&#x27;. Defaults to &#x27;password&#x27;.</value>
        [DataMember(Name = "credential_type", EmitDefaultValue = false)]

        public string CredentialType { get; set; }


        /// <summary>
        /// Name of the database this role acts on.
        /// </summary>
        /// <value>Name of the database this role acts on.</value>
        [DataMember(Name = "db_name", EmitDefaultValue = false)]

        public string DbName { get; set; }


        /// <summary>
        /// Default ttl for role.
        /// </summary>
        /// <value>Default ttl for role.</value>
        [DataMember(Name = "default_ttl", EmitDefaultValue = false)]

        public int DefaultTtl { get; set; }


        /// <summary>
        /// Maximum time a credential is valid for
        /// </summary>
        /// <value>Maximum time a credential is valid for</value>
        [DataMember(Name = "max_ttl", EmitDefaultValue = false)]

        public int MaxTtl { get; set; }


        /// <summary>
        /// Specifies the database statements to be executed to renew a user. Not every plugin type will support this functionality. See the plugin&#x27;s API page for more information on support and formatting for this parameter.
        /// </summary>
        /// <value>Specifies the database statements to be executed to renew a user. Not every plugin type will support this functionality. See the plugin&#x27;s API page for more information on support and formatting for this parameter.</value>
        [DataMember(Name = "renew_statements", EmitDefaultValue = false)]

        public List<string> RenewStatements { get; set; }


        /// <summary>
        /// Specifies the database statements to be executed to revoke a user. See the plugin&#x27;s API page for more information on support and formatting for this parameter.
        /// </summary>
        /// <value>Specifies the database statements to be executed to revoke a user. See the plugin&#x27;s API page for more information on support and formatting for this parameter.</value>
        [DataMember(Name = "revocation_statements", EmitDefaultValue = false)]

        public List<string> RevocationStatements { get; set; }


        /// <summary>
        /// Specifies the database statements to be executed rollback a create operation in the event of an error. Not every plugin type will support this functionality. See the plugin&#x27;s API page for more information on support and formatting for this parameter.
        /// </summary>
        /// <value>Specifies the database statements to be executed rollback a create operation in the event of an error. Not every plugin type will support this functionality. See the plugin&#x27;s API page for more information on support and formatting for this parameter.</value>
        [DataMember(Name = "rollback_statements", EmitDefaultValue = false)]

        public List<string> RollbackStatements { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatabaseWriteRoleRequest {\n");
            sb.Append("  CreationStatements: ").Append(CreationStatements).Append("\n");
            sb.Append("  CredentialConfig: ").Append(CredentialConfig).Append("\n");
            sb.Append("  CredentialType: ").Append(CredentialType).Append("\n");
            sb.Append("  DbName: ").Append(DbName).Append("\n");
            sb.Append("  DefaultTtl: ").Append(DefaultTtl).Append("\n");
            sb.Append("  MaxTtl: ").Append(MaxTtl).Append("\n");
            sb.Append("  RenewStatements: ").Append(RenewStatements).Append("\n");
            sb.Append("  RevocationStatements: ").Append(RevocationStatements).Append("\n");
            sb.Append("  RollbackStatements: ").Append(RollbackStatements).Append("\n");
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
            return this.Equals(input as DatabaseWriteRoleRequest);
        }

        /// <summary>
        /// Returns true if DatabaseWriteRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DatabaseWriteRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatabaseWriteRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.CreationStatements == input.CreationStatements ||
                    this.CreationStatements != null &&
                    input.CreationStatements != null &&
                    this.CreationStatements.SequenceEqual(input.CreationStatements)
                ) &&
                (
                    this.CredentialConfig == input.CredentialConfig ||
                    (this.CredentialConfig != null &&
                    this.CredentialConfig.Equals(input.CredentialConfig))

                ) &&
                (
                    this.CredentialType == input.CredentialType ||
                    (this.CredentialType != null &&
                    this.CredentialType.Equals(input.CredentialType))

                ) &&
                (
                    this.DbName == input.DbName ||
                    (this.DbName != null &&
                    this.DbName.Equals(input.DbName))

                ) &&
                (
                    this.DefaultTtl == input.DefaultTtl ||

                    this.DefaultTtl.Equals(input.DefaultTtl)
                ) &&
                (
                    this.MaxTtl == input.MaxTtl ||

                    this.MaxTtl.Equals(input.MaxTtl)
                ) &&
                (
                    this.RenewStatements == input.RenewStatements ||
                    this.RenewStatements != null &&
                    input.RenewStatements != null &&
                    this.RenewStatements.SequenceEqual(input.RenewStatements)
                ) &&
                (
                    this.RevocationStatements == input.RevocationStatements ||
                    this.RevocationStatements != null &&
                    input.RevocationStatements != null &&
                    this.RevocationStatements.SequenceEqual(input.RevocationStatements)
                ) &&
                (
                    this.RollbackStatements == input.RollbackStatements ||
                    this.RollbackStatements != null &&
                    input.RollbackStatements != null &&
                    this.RollbackStatements.SequenceEqual(input.RollbackStatements)
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

                if (this.CreationStatements != null)
                {
                    hashCode = (hashCode * 59) + this.CreationStatements.GetHashCode();
                }

                if (this.CredentialConfig != null)
                {
                    hashCode = (hashCode * 59) + this.CredentialConfig.GetHashCode();
                }

                if (this.CredentialType != null)
                {
                    hashCode = (hashCode * 59) + this.CredentialType.GetHashCode();
                }

                if (this.DbName != null)
                {
                    hashCode = (hashCode * 59) + this.DbName.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.DefaultTtl.GetHashCode();

                hashCode = (hashCode * 59) + this.MaxTtl.GetHashCode();
                if (this.RenewStatements != null)
                {
                    hashCode = (hashCode * 59) + this.RenewStatements.GetHashCode();
                }

                if (this.RevocationStatements != null)
                {
                    hashCode = (hashCode * 59) + this.RevocationStatements.GetHashCode();
                }

                if (this.RollbackStatements != null)
                {
                    hashCode = (hashCode * 59) + this.RollbackStatements.GetHashCode();
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
