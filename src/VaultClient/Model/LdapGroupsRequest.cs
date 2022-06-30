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
using OpenAPIDateConverter = VaultClient.Client.OpenAPIDateConverter;

namespace VaultClient.Model
{
    /// <summary>
    /// LdapGroupsRequest
    /// </summary>
    [DataContract(Name = "LdapGroupsRequest")]
    public partial class LdapGroupsRequest : IEquatable<LdapGroupsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LdapGroupsRequest" /> class.
        /// </summary>
        /// <param name="policies">Comma-separated list of policies associated to the group..</param>
        public LdapGroupsRequest(List<string> policies = default(List<string>))
        {
            this.Policies = policies;
        }

        /// <summary>
        /// Comma-separated list of policies associated to the group.
        /// </summary>
        /// <value>Comma-separated list of policies associated to the group.</value>
        [DataMember(Name = "policies", EmitDefaultValue = false)]
        public List<string> Policies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LdapGroupsRequest {\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
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
            return this.Equals(input as LdapGroupsRequest);
        }

        /// <summary>
        /// Returns true if LdapGroupsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LdapGroupsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LdapGroupsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Policies == input.Policies ||
                    this.Policies != null &&
                    input.Policies != null &&
                    this.Policies.SequenceEqual(input.Policies)
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
                if (this.Policies != null)
                {
                    hashCode = (hashCode * 59) + this.Policies.GetHashCode();
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
