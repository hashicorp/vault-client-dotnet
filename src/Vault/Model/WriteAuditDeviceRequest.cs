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
    /// WriteAuditDeviceRequest
    /// </summary>
    [DataContract(Name = "WriteAuditDeviceRequest")]
    public partial class WriteAuditDeviceRequest : IEquatable<WriteAuditDeviceRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WriteAuditDeviceRequest" /> class.
        /// </summary>
        /// <param name="description">User-friendly description for this audit backend..</param>
        /// <param name="local">Mark the mount as a local mount, which is not replicated and is unaffected by replication. (default to false).</param>
        /// <param name="options">Configuration options for the audit backend..</param>
        /// <param name="type">The type of the backend. Example: \&quot;mysql\&quot;.</param>
        public WriteAuditDeviceRequest(string description = default(string), bool local = false, Object options = default(Object), string type = default(string))
        {
            this.Description = description;
            this.Local = local;
            this.Options = options;
            this.Type = type;
        }

        /// <summary>
        /// User-friendly description for this audit backend.
        /// </summary>
        /// <value>User-friendly description for this audit backend.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Mark the mount as a local mount, which is not replicated and is unaffected by replication.
        /// </summary>
        /// <value>Mark the mount as a local mount, which is not replicated and is unaffected by replication.</value>
        [DataMember(Name = "local", EmitDefaultValue = true)]
        public bool Local { get; set; }

        /// <summary>
        /// Configuration options for the audit backend.
        /// </summary>
        /// <value>Configuration options for the audit backend.</value>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public Object Options { get; set; }

        /// <summary>
        /// The type of the backend. Example: \&quot;mysql\&quot;
        /// </summary>
        /// <value>The type of the backend. Example: \&quot;mysql\&quot;</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WriteAuditDeviceRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Local: ").Append(Local).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as WriteAuditDeviceRequest);
        }

        /// <summary>
        /// Returns true if WriteAuditDeviceRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WriteAuditDeviceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WriteAuditDeviceRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Local == input.Local ||
                    this.Local.Equals(input.Local)
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Local.GetHashCode();
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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