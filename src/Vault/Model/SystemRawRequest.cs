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
using OpenAPIDateConverter = Vault.Client.OpenAPIDateConverter;

namespace Vault.Model
{
    /// <summary>
    /// SystemRawRequest
    /// </summary>
    [DataContract(Name = "SystemRawRequest")]
    public partial class SystemRawRequest : IEquatable<SystemRawRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemRawRequest" /> class.
        /// </summary>
        /// <param name="compressed">compressed.</param>
        /// <param name="compressionType">compressionType.</param>
        /// <param name="encoding">encoding.</param>
        /// <param name="value">value.</param>
        public SystemRawRequest(bool compressed = default(bool), string compressionType = default(string), string encoding = default(string), string value = default(string))
        {
            this.Compressed = compressed;
            this.CompressionType = compressionType;
            this.Encoding = encoding;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets Compressed
        /// </summary>
        [DataMember(Name = "compressed", EmitDefaultValue = true)]
        public bool Compressed { get; set; }

        /// <summary>
        /// Gets or Sets CompressionType
        /// </summary>
        [DataMember(Name = "compression_type", EmitDefaultValue = false)]
        public string CompressionType { get; set; }

        /// <summary>
        /// Gets or Sets Encoding
        /// </summary>
        [DataMember(Name = "encoding", EmitDefaultValue = false)]
        public string Encoding { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SystemRawRequest {\n");
            sb.Append("  Compressed: ").Append(Compressed).Append("\n");
            sb.Append("  CompressionType: ").Append(CompressionType).Append("\n");
            sb.Append("  Encoding: ").Append(Encoding).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as SystemRawRequest);
        }

        /// <summary>
        /// Returns true if SystemRawRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemRawRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemRawRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Compressed == input.Compressed ||
                    this.Compressed.Equals(input.Compressed)
                ) && 
                (
                    this.CompressionType == input.CompressionType ||
                    (this.CompressionType != null &&
                    this.CompressionType.Equals(input.CompressionType))
                ) && 
                (
                    this.Encoding == input.Encoding ||
                    (this.Encoding != null &&
                    this.Encoding.Equals(input.Encoding))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                hashCode = (hashCode * 59) + this.Compressed.GetHashCode();
                if (this.CompressionType != null)
                {
                    hashCode = (hashCode * 59) + this.CompressionType.GetHashCode();
                }
                if (this.Encoding != null)
                {
                    hashCode = (hashCode * 59) + this.Encoding.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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