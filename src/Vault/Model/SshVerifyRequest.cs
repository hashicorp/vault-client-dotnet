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
    /// SshVerifyRequest
    /// </summary>
    [DataContract(Name = "SshVerifyRequest")]
    public partial class SshVerifyRequest : IEquatable<SshVerifyRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SshVerifyRequest" /> class.
        /// </summary>
        /// <param name="otp">[Required] One-Time-Key that needs to be validated.</param>
        public SshVerifyRequest(string otp = default(string))
        {
            this.Otp = otp;
        }

        /// <summary>
        /// [Required] One-Time-Key that needs to be validated
        /// </summary>
        /// <value>[Required] One-Time-Key that needs to be validated</value>
        [DataMember(Name = "otp", EmitDefaultValue = false)]
        public string Otp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SshVerifyRequest {\n");
            sb.Append("  Otp: ").Append(Otp).Append("\n");
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
            return this.Equals(input as SshVerifyRequest);
        }

        /// <summary>
        /// Returns true if SshVerifyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SshVerifyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SshVerifyRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Otp == input.Otp ||
                    (this.Otp != null &&
                    this.Otp.Equals(input.Otp))
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
                if (this.Otp != null)
                {
                    hashCode = (hashCode * 59) + this.Otp.GetHashCode();
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
