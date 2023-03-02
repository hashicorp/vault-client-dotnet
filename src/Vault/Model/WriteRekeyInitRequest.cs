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
    /// WriteRekeyInitRequest
    /// </summary>
    [DataContract(Name = "WriteRekeyInitRequest")]

    public partial class WriteRekeyInitRequest : IEquatable<WriteRekeyInitRequest>, IValidatableObject
    {













        /// <summary>
        /// Initializes a new instance of the <see cref="WriteRekeyInitRequest" /> class.
        /// </summary>

        /// <param name="Backup">Specifies if using PGP-encrypted keys, whether Vault should also store a plaintext backup of the PGP-encrypted keys..</param>

        /// <param name="PgpKeys">Specifies an array of PGP public keys used to encrypt the output unseal keys. Ordering is preserved. The keys must be base64-encoded from their original binary representation. The size of this array must be the same as secret_shares..</param>

        /// <param name="RequireVerification">Turns on verification functionality.</param>

        /// <param name="SecretShares">Specifies the number of shares to split the unseal key into..</param>

        /// <param name="SecretThreshold">Specifies the number of shares required to reconstruct the unseal key. This must be less than or equal secret_shares. If using Vault HSM with auto-unsealing, this value must be the same as secret_shares..</param>


        public WriteRekeyInitRequest(bool Backup = default(bool), List<string> PgpKeys = default(List<string>), bool RequireVerification = default(bool), int SecretShares = default(int), int SecretThreshold = default(int))
        {

            this.Backup = Backup;

            this.PgpKeys = PgpKeys;

            this.RequireVerification = RequireVerification;

            this.SecretShares = SecretShares;

            this.SecretThreshold = SecretThreshold;

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
            sb.Append("class WriteRekeyInitRequest {\n");
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
            return this.Equals(input as WriteRekeyInitRequest);
        }

        /// <summary>
        /// Returns true if WriteRekeyInitRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WriteRekeyInitRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WriteRekeyInitRequest input)
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
