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
    /// DatabaseWriteStaticRoleRequest
    /// </summary>
    [DataContract(Name = "DatabaseWriteStaticRoleRequest")]
    public partial class DatabaseWriteStaticRoleRequest : IEquatable<DatabaseWriteStaticRoleRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseWriteStaticRoleRequest" /> class.
        /// </summary>

        /// <param name="CredentialConfig">The configuration for the given credential_type..</param>

        /// <param name="CredentialType">The type of credential to manage. Options include: &#x27;password&#x27;, &#x27;rsa_private_key&#x27;. Defaults to &#x27;password&#x27;. (default to &quot;password&quot;).</param>

        /// <param name="DbName">Name of the database this role acts on..</param>

        /// <param name="RotationPeriod">Period for automatic credential rotation of the given username. Not valid unless used with \&quot;username\&quot;..</param>

        /// <param name="RotationStatements">Specifies the database statements to be executed to rotate the accounts credentials. Not every plugin type will support this functionality. See the plugin&#x27;s API page for more information on support and formatting for this parameter..</param>

        /// <param name="Username">Name of the static user account for Vault to manage. Requires \&quot;rotation_period\&quot; to be specified.</param>


        public DatabaseWriteStaticRoleRequest(Object CredentialConfig = default(Object), string CredentialType = "password", string DbName = default(string), string RotationPeriod = default(string), List<string> RotationStatements = default(List<string>), string Username = default(string))
        {

            this.CredentialConfig = CredentialConfig;

            // use default value if no "CredentialType" provided
            this.CredentialType = CredentialType ?? "password";


            this.DbName = DbName;

            this.RotationPeriod = RotationPeriod;

            this.RotationStatements = RotationStatements;

            this.Username = Username;

        }

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
        /// Period for automatic credential rotation of the given username. Not valid unless used with \&quot;username\&quot;.
        /// </summary>
        /// <value>Period for automatic credential rotation of the given username. Not valid unless used with \&quot;username\&quot;.</value>
        [DataMember(Name = "rotation_period", EmitDefaultValue = false)]

        public string RotationPeriod { get; set; }


        /// <summary>
        /// Specifies the database statements to be executed to rotate the accounts credentials. Not every plugin type will support this functionality. See the plugin&#x27;s API page for more information on support and formatting for this parameter.
        /// </summary>
        /// <value>Specifies the database statements to be executed to rotate the accounts credentials. Not every plugin type will support this functionality. See the plugin&#x27;s API page for more information on support and formatting for this parameter.</value>
        [DataMember(Name = "rotation_statements", EmitDefaultValue = false)]

        public List<string> RotationStatements { get; set; }


        /// <summary>
        /// Name of the static user account for Vault to manage. Requires \&quot;rotation_period\&quot; to be specified
        /// </summary>
        /// <value>Name of the static user account for Vault to manage. Requires \&quot;rotation_period\&quot; to be specified</value>
        [DataMember(Name = "username", EmitDefaultValue = false)]

        public string Username { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatabaseWriteStaticRoleRequest {\n");
            sb.Append("  CredentialConfig: ").Append(CredentialConfig).Append("\n");
            sb.Append("  CredentialType: ").Append(CredentialType).Append("\n");
            sb.Append("  DbName: ").Append(DbName).Append("\n");
            sb.Append("  RotationPeriod: ").Append(RotationPeriod).Append("\n");
            sb.Append("  RotationStatements: ").Append(RotationStatements).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(input as DatabaseWriteStaticRoleRequest);
        }

        /// <summary>
        /// Returns true if DatabaseWriteStaticRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DatabaseWriteStaticRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatabaseWriteStaticRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
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
                    this.RotationPeriod == input.RotationPeriod ||
                    (this.RotationPeriod != null &&
                    this.RotationPeriod.Equals(input.RotationPeriod))

                ) &&
                (
                    this.RotationStatements == input.RotationStatements ||
                    this.RotationStatements != null &&
                    input.RotationStatements != null &&
                    this.RotationStatements.SequenceEqual(input.RotationStatements)
                ) &&
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))

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

                if (this.RotationPeriod != null)
                {
                    hashCode = (hashCode * 59) + this.RotationPeriod.GetHashCode();
                }

                if (this.RotationStatements != null)
                {
                    hashCode = (hashCode * 59) + this.RotationStatements.GetHashCode();
                }

                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
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
