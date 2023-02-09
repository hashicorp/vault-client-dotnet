// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0
//
// Code generated with OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.


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
    /// WriteInitRequest
    /// </summary>
    [DataContract(Name = "WriteInitRequest")]
    public partial class WriteInitRequest : IEquatable<WriteInitRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WriteInitRequest" /> class.
        /// </summary>
        /// <param name="pgpKeys">Specifies an array of PGP public keys used to encrypt the output unseal keys. Ordering is preserved. The keys must be base64-encoded from their original binary representation. The size of this array must be the same as &#x60;secret_shares&#x60;..</param>
        /// <param name="recoveryPgpKeys">Specifies an array of PGP public keys used to encrypt the output recovery keys. Ordering is preserved. The keys must be base64-encoded from their original binary representation. The size of this array must be the same as &#x60;recovery_shares&#x60;..</param>
        /// <param name="recoveryShares">Specifies the number of shares to split the recovery key into..</param>
        /// <param name="recoveryThreshold">Specifies the number of shares required to reconstruct the recovery key. This must be less than or equal to &#x60;recovery_shares&#x60;..</param>
        /// <param name="rootTokenPgpKey">Specifies a PGP public key used to encrypt the initial root token. The key must be base64-encoded from its original binary representation..</param>
        /// <param name="secretShares">Specifies the number of shares to split the unseal key into..</param>
        /// <param name="secretThreshold">Specifies the number of shares required to reconstruct the unseal key. This must be less than or equal secret_shares. If using Vault HSM with auto-unsealing, this value must be the same as &#x60;secret_shares&#x60;..</param>
        /// <param name="storedShares">Specifies the number of shares that should be encrypted by the HSM and stored for auto-unsealing. Currently must be the same as &#x60;secret_shares&#x60;..</param>
        public WriteInitRequest(List<string> pgpKeys = default(List<string>), List<string> recoveryPgpKeys = default(List<string>), int recoveryShares = default(int), int recoveryThreshold = default(int), string rootTokenPgpKey = default(string), int secretShares = default(int), int secretThreshold = default(int), int storedShares = default(int))
        {
            this.PgpKeys = pgpKeys;
            this.RecoveryPgpKeys = recoveryPgpKeys;
            this.RecoveryShares = recoveryShares;
            this.RecoveryThreshold = recoveryThreshold;
            this.RootTokenPgpKey = rootTokenPgpKey;
            this.SecretShares = secretShares;
            this.SecretThreshold = secretThreshold;
            this.StoredShares = storedShares;
        }

        /// <summary>
        /// Specifies an array of PGP public keys used to encrypt the output unseal keys. Ordering is preserved. The keys must be base64-encoded from their original binary representation. The size of this array must be the same as &#x60;secret_shares&#x60;.
        /// </summary>
        /// <value>Specifies an array of PGP public keys used to encrypt the output unseal keys. Ordering is preserved. The keys must be base64-encoded from their original binary representation. The size of this array must be the same as &#x60;secret_shares&#x60;.</value>
        [DataMember(Name = "pgp_keys", EmitDefaultValue = false)]
        public List<string> PgpKeys { get; set; }

        /// <summary>
        /// Specifies an array of PGP public keys used to encrypt the output recovery keys. Ordering is preserved. The keys must be base64-encoded from their original binary representation. The size of this array must be the same as &#x60;recovery_shares&#x60;.
        /// </summary>
        /// <value>Specifies an array of PGP public keys used to encrypt the output recovery keys. Ordering is preserved. The keys must be base64-encoded from their original binary representation. The size of this array must be the same as &#x60;recovery_shares&#x60;.</value>
        [DataMember(Name = "recovery_pgp_keys", EmitDefaultValue = false)]
        public List<string> RecoveryPgpKeys { get; set; }

        /// <summary>
        /// Specifies the number of shares to split the recovery key into.
        /// </summary>
        /// <value>Specifies the number of shares to split the recovery key into.</value>
        [DataMember(Name = "recovery_shares", EmitDefaultValue = false)]
        public int RecoveryShares { get; set; }

        /// <summary>
        /// Specifies the number of shares required to reconstruct the recovery key. This must be less than or equal to &#x60;recovery_shares&#x60;.
        /// </summary>
        /// <value>Specifies the number of shares required to reconstruct the recovery key. This must be less than or equal to &#x60;recovery_shares&#x60;.</value>
        [DataMember(Name = "recovery_threshold", EmitDefaultValue = false)]
        public int RecoveryThreshold { get; set; }

        /// <summary>
        /// Specifies a PGP public key used to encrypt the initial root token. The key must be base64-encoded from its original binary representation.
        /// </summary>
        /// <value>Specifies a PGP public key used to encrypt the initial root token. The key must be base64-encoded from its original binary representation.</value>
        [DataMember(Name = "root_token_pgp_key", EmitDefaultValue = false)]
        public string RootTokenPgpKey { get; set; }

        /// <summary>
        /// Specifies the number of shares to split the unseal key into.
        /// </summary>
        /// <value>Specifies the number of shares to split the unseal key into.</value>
        [DataMember(Name = "secret_shares", EmitDefaultValue = false)]
        public int SecretShares { get; set; }

        /// <summary>
        /// Specifies the number of shares required to reconstruct the unseal key. This must be less than or equal secret_shares. If using Vault HSM with auto-unsealing, this value must be the same as &#x60;secret_shares&#x60;.
        /// </summary>
        /// <value>Specifies the number of shares required to reconstruct the unseal key. This must be less than or equal secret_shares. If using Vault HSM with auto-unsealing, this value must be the same as &#x60;secret_shares&#x60;.</value>
        [DataMember(Name = "secret_threshold", EmitDefaultValue = false)]
        public int SecretThreshold { get; set; }

        /// <summary>
        /// Specifies the number of shares that should be encrypted by the HSM and stored for auto-unsealing. Currently must be the same as &#x60;secret_shares&#x60;.
        /// </summary>
        /// <value>Specifies the number of shares that should be encrypted by the HSM and stored for auto-unsealing. Currently must be the same as &#x60;secret_shares&#x60;.</value>
        [DataMember(Name = "stored_shares", EmitDefaultValue = false)]
        public int StoredShares { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WriteInitRequest {\n");
            sb.Append("  PgpKeys: ").Append(PgpKeys).Append("\n");
            sb.Append("  RecoveryPgpKeys: ").Append(RecoveryPgpKeys).Append("\n");
            sb.Append("  RecoveryShares: ").Append(RecoveryShares).Append("\n");
            sb.Append("  RecoveryThreshold: ").Append(RecoveryThreshold).Append("\n");
            sb.Append("  RootTokenPgpKey: ").Append(RootTokenPgpKey).Append("\n");
            sb.Append("  SecretShares: ").Append(SecretShares).Append("\n");
            sb.Append("  SecretThreshold: ").Append(SecretThreshold).Append("\n");
            sb.Append("  StoredShares: ").Append(StoredShares).Append("\n");
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
            return this.Equals(input as WriteInitRequest);
        }

        /// <summary>
        /// Returns true if WriteInitRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WriteInitRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WriteInitRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PgpKeys == input.PgpKeys ||
                    this.PgpKeys != null &&
                    input.PgpKeys != null &&
                    this.PgpKeys.SequenceEqual(input.PgpKeys)
                ) && 
                (
                    this.RecoveryPgpKeys == input.RecoveryPgpKeys ||
                    this.RecoveryPgpKeys != null &&
                    input.RecoveryPgpKeys != null &&
                    this.RecoveryPgpKeys.SequenceEqual(input.RecoveryPgpKeys)
                ) && 
                (
                    this.RecoveryShares == input.RecoveryShares ||
                    this.RecoveryShares.Equals(input.RecoveryShares)
                ) && 
                (
                    this.RecoveryThreshold == input.RecoveryThreshold ||
                    this.RecoveryThreshold.Equals(input.RecoveryThreshold)
                ) && 
                (
                    this.RootTokenPgpKey == input.RootTokenPgpKey ||
                    (this.RootTokenPgpKey != null &&
                    this.RootTokenPgpKey.Equals(input.RootTokenPgpKey))
                ) && 
                (
                    this.SecretShares == input.SecretShares ||
                    this.SecretShares.Equals(input.SecretShares)
                ) && 
                (
                    this.SecretThreshold == input.SecretThreshold ||
                    this.SecretThreshold.Equals(input.SecretThreshold)
                ) && 
                (
                    this.StoredShares == input.StoredShares ||
                    this.StoredShares.Equals(input.StoredShares)
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
                if (this.PgpKeys != null)
                {
                    hashCode = (hashCode * 59) + this.PgpKeys.GetHashCode();
                }
                if (this.RecoveryPgpKeys != null)
                {
                    hashCode = (hashCode * 59) + this.RecoveryPgpKeys.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RecoveryShares.GetHashCode();
                hashCode = (hashCode * 59) + this.RecoveryThreshold.GetHashCode();
                if (this.RootTokenPgpKey != null)
                {
                    hashCode = (hashCode * 59) + this.RootTokenPgpKey.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SecretShares.GetHashCode();
                hashCode = (hashCode * 59) + this.SecretThreshold.GetHashCode();
                hashCode = (hashCode * 59) + this.StoredShares.GetHashCode();
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
