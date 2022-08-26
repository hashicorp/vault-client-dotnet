/*
 * HashiCorp Vault API
 *
 * HTTP API that gives you full access to Vault. All API routes are prefixed with `/v1/`.
 *
 * The version of the OpenAPI document: 1.12.0
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
    /// OpenldapStaticRoleRequest
    /// </summary>
    [DataContract(Name = "OpenldapStaticRoleRequest")]
    public partial class OpenldapStaticRoleRequest : IEquatable<OpenldapStaticRoleRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenldapStaticRoleRequest" /> class.
        /// </summary>
        /// <param name="dn">The distinguished name of the entry to manage..</param>
        /// <param name="rotationPeriod">Period for automatic credential rotation of the given entry..</param>
        /// <param name="ttl">The time-to-live for the password..</param>
        /// <param name="username">The username/logon name for the entry with which this role will be associated..</param>
        public OpenldapStaticRoleRequest(string dn = default(string), int rotationPeriod = default(int), int ttl = default(int), string username = default(string))
        {
            this.Dn = dn;
            this.RotationPeriod = rotationPeriod;
            this.Ttl = ttl;
            this.Username = username;
        }

        /// <summary>
        /// The distinguished name of the entry to manage.
        /// </summary>
        /// <value>The distinguished name of the entry to manage.</value>
        [DataMember(Name = "dn", EmitDefaultValue = false)]
        public string Dn { get; set; }

        /// <summary>
        /// Period for automatic credential rotation of the given entry.
        /// </summary>
        /// <value>Period for automatic credential rotation of the given entry.</value>
        [DataMember(Name = "rotation_period", EmitDefaultValue = false)]
        public int RotationPeriod { get; set; }

        /// <summary>
        /// The time-to-live for the password.
        /// </summary>
        /// <value>The time-to-live for the password.</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]
        public int Ttl { get; set; }

        /// <summary>
        /// The username/logon name for the entry with which this role will be associated.
        /// </summary>
        /// <value>The username/logon name for the entry with which this role will be associated.</value>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OpenldapStaticRoleRequest {\n");
            sb.Append("  Dn: ").Append(Dn).Append("\n");
            sb.Append("  RotationPeriod: ").Append(RotationPeriod).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
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
            return this.Equals(input as OpenldapStaticRoleRequest);
        }

        /// <summary>
        /// Returns true if OpenldapStaticRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OpenldapStaticRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenldapStaticRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Dn == input.Dn ||
                    (this.Dn != null &&
                    this.Dn.Equals(input.Dn))
                ) && 
                (
                    this.RotationPeriod == input.RotationPeriod ||
                    this.RotationPeriod.Equals(input.RotationPeriod)
                ) && 
                (
                    this.Ttl == input.Ttl ||
                    this.Ttl.Equals(input.Ttl)
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
                if (this.Dn != null)
                {
                    hashCode = (hashCode * 59) + this.Dn.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RotationPeriod.GetHashCode();
                hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
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
