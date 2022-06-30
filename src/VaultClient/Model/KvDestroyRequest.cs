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
    /// KvDestroyRequest
    /// </summary>
    [DataContract(Name = "KvDestroyRequest")]
    public partial class KvDestroyRequest : IEquatable<KvDestroyRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KvDestroyRequest" /> class.
        /// </summary>
        /// <param name="versions">The versions to destroy. Their data will be permanently deleted..</param>
        public KvDestroyRequest(List<int> versions = default(List<int>))
        {
            this.Versions = versions;
        }

        /// <summary>
        /// The versions to destroy. Their data will be permanently deleted.
        /// </summary>
        /// <value>The versions to destroy. Their data will be permanently deleted.</value>
        [DataMember(Name = "versions", EmitDefaultValue = false)]
        public List<int> Versions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KvDestroyRequest {\n");
            sb.Append("  Versions: ").Append(Versions).Append("\n");
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
            return this.Equals(input as KvDestroyRequest);
        }

        /// <summary>
        /// Returns true if KvDestroyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of KvDestroyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KvDestroyRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Versions == input.Versions ||
                    this.Versions != null &&
                    input.Versions != null &&
                    this.Versions.SequenceEqual(input.Versions)
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
                if (this.Versions != null)
                {
                    hashCode = (hashCode * 59) + this.Versions.GetHashCode();
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
