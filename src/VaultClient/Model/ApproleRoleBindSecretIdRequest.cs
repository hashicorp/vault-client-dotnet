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
using FileParameter = VaultClient.Client.FileParameter;
using OpenAPIDateConverter = VaultClient.Client.OpenAPIDateConverter;

namespace VaultClient.Model
{
    /// <summary>
    /// ApproleRoleBindSecretIdRequest
    /// </summary>
    [DataContract(Name = "ApproleRoleBindSecretIdRequest")]
    public partial class ApproleRoleBindSecretIdRequest : IEquatable<ApproleRoleBindSecretIdRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApproleRoleBindSecretIdRequest" /> class.
        /// </summary>
        /// <param name="bindSecretId">Impose secret_id to be presented when logging in using this role. (default to true).</param>
        public ApproleRoleBindSecretIdRequest(bool bindSecretId = true)
        {
            this.BindSecretId = bindSecretId;
        }

        /// <summary>
        /// Impose secret_id to be presented when logging in using this role.
        /// </summary>
        /// <value>Impose secret_id to be presented when logging in using this role.</value>
        [DataMember(Name = "bind_secret_id", EmitDefaultValue = true)]
        public bool BindSecretId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApproleRoleBindSecretIdRequest {\n");
            sb.Append("  BindSecretId: ").Append(BindSecretId).Append("\n");
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
            return this.Equals(input as ApproleRoleBindSecretIdRequest);
        }

        /// <summary>
        /// Returns true if ApproleRoleBindSecretIdRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApproleRoleBindSecretIdRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApproleRoleBindSecretIdRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BindSecretId == input.BindSecretId ||
                    this.BindSecretId.Equals(input.BindSecretId)
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
                hashCode = (hashCode * 59) + this.BindSecretId.GetHashCode();
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
