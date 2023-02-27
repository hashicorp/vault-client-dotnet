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
    /// RabbitMQWriteConnectionConfigRequest
    /// </summary>
    [DataContract(Name = "RabbitMQWriteConnectionConfigRequest")]
    public partial class RabbitMQWriteConnectionConfigRequest : IEquatable<RabbitMQWriteConnectionConfigRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RabbitMQWriteConnectionConfigRequest" /> class.
        /// </summary>
        /// <param name="connectionUri">RabbitMQ Management URI.</param>
        /// <param name="password">Password of the provided RabbitMQ management user.</param>
        /// <param name="passwordPolicy">Name of the password policy to use to generate passwords for dynamic credentials..</param>
        /// <param name="username">Username of a RabbitMQ management administrator.</param>
        /// <param name="usernameTemplate">Template describing how dynamic usernames are generated..</param>
        /// <param name="verifyConnection">If set, connection_uri is verified by actually connecting to the RabbitMQ management API (default to true).</param>
        public RabbitMQWriteConnectionConfigRequest(string connectionUri = default(string), string password = default(string), string passwordPolicy = default(string), string username = default(string), string usernameTemplate = default(string), bool verifyConnection = true)
        {
            this.ConnectionUri = connectionUri;
            this.Password = password;
            this.PasswordPolicy = passwordPolicy;
            this.Username = username;
            this.UsernameTemplate = usernameTemplate;
            this.VerifyConnection = verifyConnection;
        }

        /// <summary>
        /// RabbitMQ Management URI
        /// </summary>
        /// <value>RabbitMQ Management URI</value>
        [DataMember(Name = "connection_uri", EmitDefaultValue = false)]
        public string ConnectionUri { get; set; }

        /// <summary>
        /// Password of the provided RabbitMQ management user
        /// </summary>
        /// <value>Password of the provided RabbitMQ management user</value>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Name of the password policy to use to generate passwords for dynamic credentials.
        /// </summary>
        /// <value>Name of the password policy to use to generate passwords for dynamic credentials.</value>
        [DataMember(Name = "password_policy", EmitDefaultValue = false)]
        public string PasswordPolicy { get; set; }

        /// <summary>
        /// Username of a RabbitMQ management administrator
        /// </summary>
        /// <value>Username of a RabbitMQ management administrator</value>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Template describing how dynamic usernames are generated.
        /// </summary>
        /// <value>Template describing how dynamic usernames are generated.</value>
        [DataMember(Name = "username_template", EmitDefaultValue = false)]
        public string UsernameTemplate { get; set; }

        /// <summary>
        /// If set, connection_uri is verified by actually connecting to the RabbitMQ management API
        /// </summary>
        /// <value>If set, connection_uri is verified by actually connecting to the RabbitMQ management API</value>
        [DataMember(Name = "verify_connection", EmitDefaultValue = true)]
        public bool VerifyConnection { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RabbitMQWriteConnectionConfigRequest {\n");
            sb.Append("  ConnectionUri: ").Append(ConnectionUri).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  PasswordPolicy: ").Append(PasswordPolicy).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  UsernameTemplate: ").Append(UsernameTemplate).Append("\n");
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
            return this.Equals(input as RabbitMQWriteConnectionConfigRequest);
        }

        /// <summary>
        /// Returns true if RabbitMQWriteConnectionConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RabbitMQWriteConnectionConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RabbitMQWriteConnectionConfigRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.ConnectionUri == input.ConnectionUri ||
                    (this.ConnectionUri != null &&
                    this.ConnectionUri.Equals(input.ConnectionUri))
                ) &&
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) &&
                (
                    this.PasswordPolicy == input.PasswordPolicy ||
                    (this.PasswordPolicy != null &&
                    this.PasswordPolicy.Equals(input.PasswordPolicy))
                ) &&
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) &&
                (
                    this.UsernameTemplate == input.UsernameTemplate ||
                    (this.UsernameTemplate != null &&
                    this.UsernameTemplate.Equals(input.UsernameTemplate))
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
                if (this.ConnectionUri != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectionUri.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                if (this.PasswordPolicy != null)
                {
                    hashCode = (hashCode * 59) + this.PasswordPolicy.GetHashCode();
                }
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
                }
                if (this.UsernameTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.UsernameTemplate.GetHashCode();
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
