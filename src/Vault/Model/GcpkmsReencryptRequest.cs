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
    /// GcpkmsReencryptRequest
    /// </summary>
    [DataContract(Name = "GcpkmsReencryptRequest")]
    public partial class GcpkmsReencryptRequest : IEquatable<GcpkmsReencryptRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GcpkmsReencryptRequest" /> class.
        /// </summary>
        /// <param name="additionalAuthenticatedData">Optional data that, if specified, must also be provided during decryption..</param>
        /// <param name="ciphertext">Ciphertext to be re-encrypted to the latest key version. This must be ciphertext that Vault previously generated for this named key..</param>
        /// <param name="keyVersion">Integer version of the crypto key version to use for the new encryption. If unspecified, this defaults to the latest active crypto key version..</param>
        public GcpkmsReencryptRequest(string additionalAuthenticatedData = default(string), string ciphertext = default(string), int keyVersion = default(int))
        {
            this.AdditionalAuthenticatedData = additionalAuthenticatedData;
            this.Ciphertext = ciphertext;
            this.KeyVersion = keyVersion;
        }

        /// <summary>
        /// Optional data that, if specified, must also be provided during decryption.
        /// </summary>
        /// <value>Optional data that, if specified, must also be provided during decryption.</value>
        [DataMember(Name = "additional_authenticated_data", EmitDefaultValue = false)]
        public string AdditionalAuthenticatedData { get; set; }

        /// <summary>
        /// Ciphertext to be re-encrypted to the latest key version. This must be ciphertext that Vault previously generated for this named key.
        /// </summary>
        /// <value>Ciphertext to be re-encrypted to the latest key version. This must be ciphertext that Vault previously generated for this named key.</value>
        [DataMember(Name = "ciphertext", EmitDefaultValue = false)]
        public string Ciphertext { get; set; }

        /// <summary>
        /// Integer version of the crypto key version to use for the new encryption. If unspecified, this defaults to the latest active crypto key version.
        /// </summary>
        /// <value>Integer version of the crypto key version to use for the new encryption. If unspecified, this defaults to the latest active crypto key version.</value>
        [DataMember(Name = "key_version", EmitDefaultValue = false)]
        public int KeyVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GcpkmsReencryptRequest {\n");
            sb.Append("  AdditionalAuthenticatedData: ").Append(AdditionalAuthenticatedData).Append("\n");
            sb.Append("  Ciphertext: ").Append(Ciphertext).Append("\n");
            sb.Append("  KeyVersion: ").Append(KeyVersion).Append("\n");
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
            return this.Equals(input as GcpkmsReencryptRequest);
        }

        /// <summary>
        /// Returns true if GcpkmsReencryptRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GcpkmsReencryptRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GcpkmsReencryptRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AdditionalAuthenticatedData == input.AdditionalAuthenticatedData ||
                    (this.AdditionalAuthenticatedData != null &&
                    this.AdditionalAuthenticatedData.Equals(input.AdditionalAuthenticatedData))
                ) && 
                (
                    this.Ciphertext == input.Ciphertext ||
                    (this.Ciphertext != null &&
                    this.Ciphertext.Equals(input.Ciphertext))
                ) && 
                (
                    this.KeyVersion == input.KeyVersion ||
                    this.KeyVersion.Equals(input.KeyVersion)
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
                if (this.AdditionalAuthenticatedData != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalAuthenticatedData.GetHashCode();
                }
                if (this.Ciphertext != null)
                {
                    hashCode = (hashCode * 59) + this.Ciphertext.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.KeyVersion.GetHashCode();
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