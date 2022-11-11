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
    /// OpenldapLibraryCheckOutRequest
    /// </summary>
    [DataContract(Name = "OpenldapLibraryCheckOutRequest")]
    public partial class OpenldapLibraryCheckOutRequest : IEquatable<OpenldapLibraryCheckOutRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenldapLibraryCheckOutRequest" /> class.
        /// </summary>
        /// <param name="ttl">The length of time before the check-out will expire, in seconds..</param>
        public OpenldapLibraryCheckOutRequest(int ttl = default(int))
        {
            this.Ttl = ttl;
        }

        /// <summary>
        /// The length of time before the check-out will expire, in seconds.
        /// </summary>
        /// <value>The length of time before the check-out will expire, in seconds.</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]
        public int Ttl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OpenldapLibraryCheckOutRequest {\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
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
            return this.Equals(input as OpenldapLibraryCheckOutRequest);
        }

        /// <summary>
        /// Returns true if OpenldapLibraryCheckOutRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OpenldapLibraryCheckOutRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenldapLibraryCheckOutRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Ttl == input.Ttl ||
                    this.Ttl.Equals(input.Ttl)
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
                hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
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