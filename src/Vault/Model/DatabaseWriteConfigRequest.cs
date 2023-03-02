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
    /// DatabaseWriteConfigRequest
    /// </summary>
    [DataContract(Name = "DatabaseWriteConfigRequest")]

    public partial class DatabaseWriteConfigRequest : IEquatable<DatabaseWriteConfigRequest>, IValidatableObject
    {















        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseWriteConfigRequest" /> class.
        /// </summary>

        /// <param name="AllowedRoles">Comma separated string or array of the role names allowed to get creds from this database connection. If empty no roles are allowed. If \&quot;*\&quot; all roles are allowed..</param>

        /// <param name="PasswordPolicy">Password policy to use when generating passwords..</param>

        /// <param name="PluginName">The name of a builtin or previously registered plugin known to vault. This endpoint will create an instance of that plugin type..</param>

        /// <param name="PluginVersion">The version of the plugin to use..</param>

        /// <param name="RootRotationStatements">Specifies the database statements to be executed to rotate the root user&#x27;s credentials. See the plugin&#x27;s API page for more information on support and formatting for this parameter..</param>

        /// <param name="VerifyConnection">If true, the connection details are verified by actually connecting to the database. Defaults to true. (default to true).</param>


        public DatabaseWriteConfigRequest(List<string> AllowedRoles = default(List<string>), string PasswordPolicy = default(string), string PluginName = default(string), string PluginVersion = default(string), List<string> RootRotationStatements = default(List<string>), bool VerifyConnection = true)
        {

            this.AllowedRoles = AllowedRoles;

            this.PasswordPolicy = PasswordPolicy;

            this.PluginName = PluginName;

            this.PluginVersion = PluginVersion;

            this.RootRotationStatements = RootRotationStatements;

            this.VerifyConnection = VerifyConnection;

        }

        /// <summary>
        /// Comma separated string or array of the role names allowed to get creds from this database connection. If empty no roles are allowed. If \&quot;*\&quot; all roles are allowed.
        /// </summary>
        /// <value>Comma separated string or array of the role names allowed to get creds from this database connection. If empty no roles are allowed. If \&quot;*\&quot; all roles are allowed.</value>
        [DataMember(Name = "allowed_roles", EmitDefaultValue = false)]


        public List<string> AllowedRoles { get; set; }


        /// <summary>
        /// Password policy to use when generating passwords.
        /// </summary>
        /// <value>Password policy to use when generating passwords.</value>
        [DataMember(Name = "password_policy", EmitDefaultValue = false)]


        public string PasswordPolicy { get; set; }


        /// <summary>
        /// The name of a builtin or previously registered plugin known to vault. This endpoint will create an instance of that plugin type.
        /// </summary>
        /// <value>The name of a builtin or previously registered plugin known to vault. This endpoint will create an instance of that plugin type.</value>
        [DataMember(Name = "plugin_name", EmitDefaultValue = false)]


        public string PluginName { get; set; }


        /// <summary>
        /// The version of the plugin to use.
        /// </summary>
        /// <value>The version of the plugin to use.</value>
        [DataMember(Name = "plugin_version", EmitDefaultValue = false)]


        public string PluginVersion { get; set; }


        /// <summary>
        /// Specifies the database statements to be executed to rotate the root user&#x27;s credentials. See the plugin&#x27;s API page for more information on support and formatting for this parameter.
        /// </summary>
        /// <value>Specifies the database statements to be executed to rotate the root user&#x27;s credentials. See the plugin&#x27;s API page for more information on support and formatting for this parameter.</value>
        [DataMember(Name = "root_rotation_statements", EmitDefaultValue = false)]


        public List<string> RootRotationStatements { get; set; }


        /// <summary>
        /// If true, the connection details are verified by actually connecting to the database. Defaults to true.
        /// </summary>
        /// <value>If true, the connection details are verified by actually connecting to the database. Defaults to true.</value>
        [DataMember(Name = "verify_connection", EmitDefaultValue = true)]


        public bool VerifyConnection { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatabaseWriteConfigRequest {\n");
            sb.Append("  AllowedRoles: ").Append(AllowedRoles).Append("\n");
            sb.Append("  PasswordPolicy: ").Append(PasswordPolicy).Append("\n");
            sb.Append("  PluginName: ").Append(PluginName).Append("\n");
            sb.Append("  PluginVersion: ").Append(PluginVersion).Append("\n");
            sb.Append("  RootRotationStatements: ").Append(RootRotationStatements).Append("\n");
            sb.Append("  VerifyConnection: ").Append(VerifyConnection).Append("\n");
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
            return this.Equals(input as DatabaseWriteConfigRequest);
        }

        /// <summary>
        /// Returns true if DatabaseWriteConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DatabaseWriteConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatabaseWriteConfigRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AllowedRoles == input.AllowedRoles ||
                    this.AllowedRoles != null &&
                    input.AllowedRoles != null &&
                    this.AllowedRoles.SequenceEqual(input.AllowedRoles)
                ) &&
                (
                    this.PasswordPolicy == input.PasswordPolicy ||
                    (this.PasswordPolicy != null &&
                    this.PasswordPolicy.Equals(input.PasswordPolicy))

                ) &&
                (
                    this.PluginName == input.PluginName ||
                    (this.PluginName != null &&
                    this.PluginName.Equals(input.PluginName))

                ) &&
                (
                    this.PluginVersion == input.PluginVersion ||
                    (this.PluginVersion != null &&
                    this.PluginVersion.Equals(input.PluginVersion))

                ) &&
                (
                    this.RootRotationStatements == input.RootRotationStatements ||
                    this.RootRotationStatements != null &&
                    input.RootRotationStatements != null &&
                    this.RootRotationStatements.SequenceEqual(input.RootRotationStatements)
                ) &&
                (
                    this.VerifyConnection == input.VerifyConnection ||

                    this.VerifyConnection.Equals(input.VerifyConnection)
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

                if (this.AllowedRoles != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedRoles.GetHashCode();
                }

                if (this.PasswordPolicy != null)
                {
                    hashCode = (hashCode * 59) + this.PasswordPolicy.GetHashCode();
                }

                if (this.PluginName != null)
                {
                    hashCode = (hashCode * 59) + this.PluginName.GetHashCode();
                }

                if (this.PluginVersion != null)
                {
                    hashCode = (hashCode * 59) + this.PluginVersion.GetHashCode();
                }

                if (this.RootRotationStatements != null)
                {
                    hashCode = (hashCode * 59) + this.RootRotationStatements.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.VerifyConnection.GetHashCode();
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
