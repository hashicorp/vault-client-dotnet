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
    /// WriteCapabilitiesAccessorRequest
    /// </summary>
    [DataContract(Name = "WriteCapabilitiesAccessorRequest")]
    public partial class WriteCapabilitiesAccessorRequest : IEquatable<WriteCapabilitiesAccessorRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WriteCapabilitiesAccessorRequest" /> class.
        /// </summary>
        /// <param name="accessor">Accessor of the token for which capabilities are being queried..</param>
        /// <param name="path">Use &#39;paths&#39; instead..</param>
        /// <param name="paths">Paths on which capabilities are being queried..</param>
        public WriteCapabilitiesAccessorRequest(string accessor = default(string), List<string> path = default(List<string>), List<string> paths = default(List<string>))
        {
            this.Accessor = accessor;
            this.Path = path;
            this.Paths = paths;
        }

        /// <summary>
        /// Accessor of the token for which capabilities are being queried.
        /// </summary>
        /// <value>Accessor of the token for which capabilities are being queried.</value>
        [DataMember(Name = "accessor", EmitDefaultValue = false)]
        public string Accessor { get; set; }

        /// <summary>
        /// Use &#39;paths&#39; instead.
        /// </summary>
        /// <value>Use &#39;paths&#39; instead.</value>
        [DataMember(Name = "path", EmitDefaultValue = false)]
        [Obsolete]
        public List<string> Path { get; set; }

        /// <summary>
        /// Paths on which capabilities are being queried.
        /// </summary>
        /// <value>Paths on which capabilities are being queried.</value>
        [DataMember(Name = "paths", EmitDefaultValue = false)]
        public List<string> Paths { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WriteCapabilitiesAccessorRequest {\n");
            sb.Append("  Accessor: ").Append(Accessor).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Paths: ").Append(Paths).Append("\n");
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
            return this.Equals(input as WriteCapabilitiesAccessorRequest);
        }

        /// <summary>
        /// Returns true if WriteCapabilitiesAccessorRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WriteCapabilitiesAccessorRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WriteCapabilitiesAccessorRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Accessor == input.Accessor ||
                    (this.Accessor != null &&
                    this.Accessor.Equals(input.Accessor))
                ) && 
                (
                    this.Path == input.Path ||
                    this.Path != null &&
                    input.Path != null &&
                    this.Path.SequenceEqual(input.Path)
                ) && 
                (
                    this.Paths == input.Paths ||
                    this.Paths != null &&
                    input.Paths != null &&
                    this.Paths.SequenceEqual(input.Paths)
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
                if (this.Accessor != null)
                {
                    hashCode = (hashCode * 59) + this.Accessor.GetHashCode();
                }
                if (this.Path != null)
                {
                    hashCode = (hashCode * 59) + this.Path.GetHashCode();
                }
                if (this.Paths != null)
                {
                    hashCode = (hashCode * 59) + this.Paths.GetHashCode();
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