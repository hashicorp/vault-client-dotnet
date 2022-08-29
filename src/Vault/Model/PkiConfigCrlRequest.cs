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
    /// PkiConfigCrlRequest
    /// </summary>
    [DataContract(Name = "PkiConfigCrlRequest")]
    public partial class PkiConfigCrlRequest : IEquatable<PkiConfigCrlRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PkiConfigCrlRequest" /> class.
        /// </summary>
        /// <param name="disable">If set to true, disables generating the CRL entirely..</param>
        /// <param name="expiry">The amount of time the generated CRL should be valid; defaults to 72 hours (default to &quot;72h&quot;).</param>
        public PkiConfigCrlRequest(bool disable = default(bool), string expiry = "72h")
        {
            this.Disable = disable;
            // use default value if no "expiry" provided
            this.Expiry = expiry ?? "72h";
        }

        /// <summary>
        /// If set to true, disables generating the CRL entirely.
        /// </summary>
        /// <value>If set to true, disables generating the CRL entirely.</value>
        [DataMember(Name = "disable", EmitDefaultValue = true)]
        public bool Disable { get; set; }

        /// <summary>
        /// The amount of time the generated CRL should be valid; defaults to 72 hours
        /// </summary>
        /// <value>The amount of time the generated CRL should be valid; defaults to 72 hours</value>
        [DataMember(Name = "expiry", EmitDefaultValue = false)]
        public string Expiry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiConfigCrlRequest {\n");
            sb.Append("  Disable: ").Append(Disable).Append("\n");
            sb.Append("  Expiry: ").Append(Expiry).Append("\n");
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
            return this.Equals(input as PkiConfigCrlRequest);
        }

        /// <summary>
        /// Returns true if PkiConfigCrlRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiConfigCrlRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiConfigCrlRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Disable == input.Disable ||
                    this.Disable.Equals(input.Disable)
                ) && 
                (
                    this.Expiry == input.Expiry ||
                    (this.Expiry != null &&
                    this.Expiry.Equals(input.Expiry))
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
                hashCode = (hashCode * 59) + this.Disable.GetHashCode();
                if (this.Expiry != null)
                {
                    hashCode = (hashCode * 59) + this.Expiry.GetHashCode();
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
