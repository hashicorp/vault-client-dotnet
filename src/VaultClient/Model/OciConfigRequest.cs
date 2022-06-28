/*
 * HashiCorp Vault API
 *
 * HTTP API that gives you full access to Vault. All API routes are prefixed with `/v1/`.
 *
 * The version of the OpenAPI document: 1.11.0
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
    /// OciConfigRequest
    /// </summary>
    [DataContract(Name = "OciConfigRequest")]
    public partial class OciConfigRequest : IEquatable<OciConfigRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OciConfigRequest" /> class.
        /// </summary>
        /// <param name="homeTenancyId">The tenancy id of the account..</param>
        public OciConfigRequest(string homeTenancyId = default(string))
        {
            this.HomeTenancyId = homeTenancyId;
        }

        /// <summary>
        /// The tenancy id of the account.
        /// </summary>
        /// <value>The tenancy id of the account.</value>
        [DataMember(Name = "home_tenancy_id", EmitDefaultValue = false)]
        public string HomeTenancyId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OciConfigRequest {\n");
            sb.Append("  HomeTenancyId: ").Append(HomeTenancyId).Append("\n");
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
            return this.Equals(input as OciConfigRequest);
        }

        /// <summary>
        /// Returns true if OciConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OciConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OciConfigRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HomeTenancyId == input.HomeTenancyId ||
                    (this.HomeTenancyId != null &&
                    this.HomeTenancyId.Equals(input.HomeTenancyId))
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
                if (this.HomeTenancyId != null)
                {
                    hashCode = (hashCode * 59) + this.HomeTenancyId.GetHashCode();
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
