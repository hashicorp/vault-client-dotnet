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
    /// RadiusLoginWithUsernameRequest
    /// </summary>
    [DataContract(Name = "RadiusLoginWithUsernameRequest")]
    public partial class RadiusLoginWithUsernameRequest : IEquatable<RadiusLoginWithUsernameRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RadiusLoginWithUsernameRequest" /> class.
        /// </summary>
        /// <param name="password">Password for this user..</param>
        /// <param name="username">Username to be used for login. (POST request body).</param>
        public RadiusLoginWithUsernameRequest(string password = default(string), string username = default(string))
        {
            this.Password = password;
            this.Username = username;
        }

        /// <summary>
        /// Password for this user.
        /// </summary>
        /// <value>Password for this user.</value>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Username to be used for login. (POST request body)
        /// </summary>
        /// <value>Username to be used for login. (POST request body)</value>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RadiusLoginWithUsernameRequest {\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(input as RadiusLoginWithUsernameRequest);
        }

        /// <summary>
        /// Returns true if RadiusLoginWithUsernameRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RadiusLoginWithUsernameRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RadiusLoginWithUsernameRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
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