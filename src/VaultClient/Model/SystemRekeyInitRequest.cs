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
    /// SystemRekeyInitRequest
    /// </summary>
    [DataContract(Name = "SystemRekeyInitRequest")]
    public partial class SystemRekeyInitRequest : IEquatable<SystemRekeyInitRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemRekeyInitRequest" /> class.
        /// </summary>
        /// <param name="backup">Specifies if using PGP-encrypted keys, whether Vault should also store a plaintext backup of the PGP-encrypted keys..</param>
        /// <param name="pgpKeys">Specifies an array of PGP public keys used to encrypt the output unseal keys. Ordering is preserved. The keys must be base64-encoded from their original binary representation. The size of this array must be the same as secret_shares..</param>
        /// <param name="requireVerification">Turns on verification functionality.</param>
        /// <param name="secretShares">Specifies the number of shares to split the unseal key into..</param>
        /// <param name="secretThreshold">Specifies the number of shares required to reconstruct the unseal key. This must be less than or equal secret_shares. If using Vault HSM with auto-unsealing, this value must be the same as secret_shares..</param>
        public SystemRekeyInitRequest(bool backup = default(bool), List<string> pgpKeys = default(List<string>), bool requireVerification = default(bool), int secretShares = default(int), int secretThreshold = default(int))
        {
            this.Backup = backup;
            this.PgpKeys = pgpKeys;
            this.RequireVerification = requireVerification;
            this.SecretShares = secretShares;
            this.SecretThreshold = secretThreshold;
        }

        /// <summary>
        /// Specifies if using PGP-encrypted keys, whether Vault should also store a plaintext backup of the PGP-encrypted keys.
        /// </summary>
        /// <value>Specifies if using PGP-encrypted keys, whether Vault should also store a plaintext backup of the PGP-encrypted keys.</value>
        [DataMember(Name = "backup", EmitDefaultValue = true)]
        public bool Backup { get; set; }

        /// <summary>
        /// Specifies an array of PGP public keys used to encrypt the output unseal keys. Ordering is preserved. The keys must be base64-encoded from their original binary representation. The size of this array must be the same as secret_shares.
        /// </summary>
        /// <value>Specifies an array of PGP public keys used to encrypt the output unseal keys. Ordering is preserved. The keys must be base64-encoded from their original binary representation. The size of this array must be the same as secret_shares.</value>
        [DataMember(Name = "pgp_keys", EmitDefaultValue = false)]
        public List<string> PgpKeys { get; set; }

        /// <summary>
        /// Turns on verification functionality
        /// </summary>
        /// <value>Turns on verification functionality</value>
        [DataMember(Name = "require_verification", EmitDefaultValue = true)]
        public bool RequireVerification { get; set; }

        /// <summary>
        /// Specifies the number of shares to split the unseal key into.
        /// </summary>
        /// <value>Specifies the number of shares to split the unseal key into.</value>
        [DataMember(Name = "secret_shares", EmitDefaultValue = false)]
        public int SecretShares { get; set; }

        /// <summary>
        /// Specifies the number of shares required to reconstruct the unseal key. This must be less than or equal secret_shares. If using Vault HSM with auto-unsealing, this value must be the same as secret_shares.
        /// </summary>
        /// <value>Specifies the number of shares required to reconstruct the unseal key. This must be less than or equal secret_shares. If using Vault HSM with auto-unsealing, this value must be the same as secret_shares.</value>
        [DataMember(Name = "secret_threshold", EmitDefaultValue = false)]
        public int SecretThreshold { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SystemRekeyInitRequest {\n");
            sb.Append("  Backup: ").Append(Backup).Append("\n");
            sb.Append("  PgpKeys: ").Append(PgpKeys).Append("\n");
            sb.Append("  RequireVerification: ").Append(RequireVerification).Append("\n");
            sb.Append("  SecretShares: ").Append(SecretShares).Append("\n");
            sb.Append("  SecretThreshold: ").Append(SecretThreshold).Append("\n");
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
            return this.Equals(input as SystemRekeyInitRequest);
        }

        /// <summary>
        /// Returns true if SystemRekeyInitRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemRekeyInitRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemRekeyInitRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Backup == input.Backup ||
                    this.Backup.Equals(input.Backup)
                ) && 
                (
                    this.PgpKeys == input.PgpKeys ||
                    this.PgpKeys != null &&
                    input.PgpKeys != null &&
                    this.PgpKeys.SequenceEqual(input.PgpKeys)
                ) && 
                (
                    this.RequireVerification == input.RequireVerification ||
                    this.RequireVerification.Equals(input.RequireVerification)
                ) && 
                (
                    this.SecretShares == input.SecretShares ||
                    this.SecretShares.Equals(input.SecretShares)
                ) && 
                (
                    this.SecretThreshold == input.SecretThreshold ||
                    this.SecretThreshold.Equals(input.SecretThreshold)
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
                hashCode = (hashCode * 59) + this.Backup.GetHashCode();
                if (this.PgpKeys != null)
                {
                    hashCode = (hashCode * 59) + this.PgpKeys.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RequireVerification.GetHashCode();
                hashCode = (hashCode * 59) + this.SecretShares.GetHashCode();
                hashCode = (hashCode * 59) + this.SecretThreshold.GetHashCode();
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
