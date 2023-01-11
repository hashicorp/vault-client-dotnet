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
    /// AWSWriteSecurityTokenServiceRequest
    /// </summary>
    [DataContract(Name = "AWSWriteSecurityTokenServiceRequest")]
    public partial class AWSWriteSecurityTokenServiceRequest : IEquatable<AWSWriteSecurityTokenServiceRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AWSWriteSecurityTokenServiceRequest" /> class.
        /// </summary>
        /// <param name="roleArn">ARN of role to assume when credential_type is assumed_role.</param>
        /// <param name="roleSessionName">Session name to use when assuming role. Max chars: 64.</param>
        /// <param name="ttl">Lifetime of the returned credentials in seconds (default to 3600).</param>
        public AWSWriteSecurityTokenServiceRequest(string roleArn = default(string), string roleSessionName = default(string), int ttl = 3600)
        {
            this.RoleArn = roleArn;
            this.RoleSessionName = roleSessionName;
            this.Ttl = ttl;
        }

        /// <summary>
        /// ARN of role to assume when credential_type is assumed_role
        /// </summary>
        /// <value>ARN of role to assume when credential_type is assumed_role</value>
        [DataMember(Name = "role_arn", EmitDefaultValue = false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Session name to use when assuming role. Max chars: 64
        /// </summary>
        /// <value>Session name to use when assuming role. Max chars: 64</value>
        [DataMember(Name = "role_session_name", EmitDefaultValue = false)]
        public string RoleSessionName { get; set; }

        /// <summary>
        /// Lifetime of the returned credentials in seconds
        /// </summary>
        /// <value>Lifetime of the returned credentials in seconds</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]
        public int Ttl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AWSWriteSecurityTokenServiceRequest {\n");
            sb.Append("  RoleArn: ").Append(RoleArn).Append("\n");
            sb.Append("  RoleSessionName: ").Append(RoleSessionName).Append("\n");
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
            return this.Equals(input as AWSWriteSecurityTokenServiceRequest);
        }

        /// <summary>
        /// Returns true if AWSWriteSecurityTokenServiceRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AWSWriteSecurityTokenServiceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AWSWriteSecurityTokenServiceRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RoleArn == input.RoleArn ||
                    (this.RoleArn != null &&
                    this.RoleArn.Equals(input.RoleArn))
                ) && 
                (
                    this.RoleSessionName == input.RoleSessionName ||
                    (this.RoleSessionName != null &&
                    this.RoleSessionName.Equals(input.RoleSessionName))
                ) && 
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
                if (this.RoleArn != null)
                {
                    hashCode = (hashCode * 59) + this.RoleArn.GetHashCode();
                }
                if (this.RoleSessionName != null)
                {
                    hashCode = (hashCode * 59) + this.RoleSessionName.GetHashCode();
                }
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