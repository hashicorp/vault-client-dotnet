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
    /// TransitWriteKeyConfigRequest
    /// </summary>
    [DataContract(Name = "TransitWriteKeyConfigRequest")]
    public partial class TransitWriteKeyConfigRequest : IEquatable<TransitWriteKeyConfigRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransitWriteKeyConfigRequest" /> class.
        /// </summary>
        /// <param name="allowPlaintextBackup">Enables taking a backup of the named key in plaintext format. Once set, this cannot be disabled..</param>
        /// <param name="autoRotatePeriod">Amount of time the key should live before being automatically rotated. A value of 0 disables automatic rotation for the key..</param>
        /// <param name="deletionAllowed">Whether to allow deletion of the key.</param>
        /// <param name="exportable">Enables export of the key. Once set, this cannot be disabled..</param>
        /// <param name="minDecryptionVersion">If set, the minimum version of the key allowed to be decrypted. For signing keys, the minimum version allowed to be used for verification..</param>
        /// <param name="minEncryptionVersion">If set, the minimum version of the key allowed to be used for encryption; or for signing keys, to be used for signing. If set to zero, only the latest version of the key is allowed..</param>
        public TransitWriteKeyConfigRequest(bool allowPlaintextBackup = default(bool), int autoRotatePeriod = default(int), bool deletionAllowed = default(bool), bool exportable = default(bool), int minDecryptionVersion = default(int), int minEncryptionVersion = default(int))
        {
            this.AllowPlaintextBackup = allowPlaintextBackup;
            this.AutoRotatePeriod = autoRotatePeriod;
            this.DeletionAllowed = deletionAllowed;
            this.Exportable = exportable;
            this.MinDecryptionVersion = minDecryptionVersion;
            this.MinEncryptionVersion = minEncryptionVersion;
        }

        /// <summary>
        /// Enables taking a backup of the named key in plaintext format. Once set, this cannot be disabled.
        /// </summary>
        /// <value>Enables taking a backup of the named key in plaintext format. Once set, this cannot be disabled.</value>
        [DataMember(Name = "allow_plaintext_backup", EmitDefaultValue = true)]
        public bool AllowPlaintextBackup { get; set; }

        /// <summary>
        /// Amount of time the key should live before being automatically rotated. A value of 0 disables automatic rotation for the key.
        /// </summary>
        /// <value>Amount of time the key should live before being automatically rotated. A value of 0 disables automatic rotation for the key.</value>
        [DataMember(Name = "auto_rotate_period", EmitDefaultValue = false)]
        public int AutoRotatePeriod { get; set; }

        /// <summary>
        /// Whether to allow deletion of the key
        /// </summary>
        /// <value>Whether to allow deletion of the key</value>
        [DataMember(Name = "deletion_allowed", EmitDefaultValue = true)]
        public bool DeletionAllowed { get; set; }

        /// <summary>
        /// Enables export of the key. Once set, this cannot be disabled.
        /// </summary>
        /// <value>Enables export of the key. Once set, this cannot be disabled.</value>
        [DataMember(Name = "exportable", EmitDefaultValue = true)]
        public bool Exportable { get; set; }

        /// <summary>
        /// If set, the minimum version of the key allowed to be decrypted. For signing keys, the minimum version allowed to be used for verification.
        /// </summary>
        /// <value>If set, the minimum version of the key allowed to be decrypted. For signing keys, the minimum version allowed to be used for verification.</value>
        [DataMember(Name = "min_decryption_version", EmitDefaultValue = false)]
        public int MinDecryptionVersion { get; set; }

        /// <summary>
        /// If set, the minimum version of the key allowed to be used for encryption; or for signing keys, to be used for signing. If set to zero, only the latest version of the key is allowed.
        /// </summary>
        /// <value>If set, the minimum version of the key allowed to be used for encryption; or for signing keys, to be used for signing. If set to zero, only the latest version of the key is allowed.</value>
        [DataMember(Name = "min_encryption_version", EmitDefaultValue = false)]
        public int MinEncryptionVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransitWriteKeyConfigRequest {\n");
            sb.Append("  AllowPlaintextBackup: ").Append(AllowPlaintextBackup).Append("\n");
            sb.Append("  AutoRotatePeriod: ").Append(AutoRotatePeriod).Append("\n");
            sb.Append("  DeletionAllowed: ").Append(DeletionAllowed).Append("\n");
            sb.Append("  Exportable: ").Append(Exportable).Append("\n");
            sb.Append("  MinDecryptionVersion: ").Append(MinDecryptionVersion).Append("\n");
            sb.Append("  MinEncryptionVersion: ").Append(MinEncryptionVersion).Append("\n");
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
            return this.Equals(input as TransitWriteKeyConfigRequest);
        }

        /// <summary>
        /// Returns true if TransitWriteKeyConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransitWriteKeyConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransitWriteKeyConfigRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AllowPlaintextBackup == input.AllowPlaintextBackup ||
                    this.AllowPlaintextBackup.Equals(input.AllowPlaintextBackup)
                ) &&
                (
                    this.AutoRotatePeriod == input.AutoRotatePeriod ||
                    this.AutoRotatePeriod.Equals(input.AutoRotatePeriod)
                ) &&
                (
                    this.DeletionAllowed == input.DeletionAllowed ||
                    this.DeletionAllowed.Equals(input.DeletionAllowed)
                ) &&
                (
                    this.Exportable == input.Exportable ||
                    this.Exportable.Equals(input.Exportable)
                ) &&
                (
                    this.MinDecryptionVersion == input.MinDecryptionVersion ||
                    this.MinDecryptionVersion.Equals(input.MinDecryptionVersion)
                ) &&
                (
                    this.MinEncryptionVersion == input.MinEncryptionVersion ||
                    this.MinEncryptionVersion.Equals(input.MinEncryptionVersion)
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
                hashCode = (hashCode * 59) + this.AllowPlaintextBackup.GetHashCode();
                hashCode = (hashCode * 59) + this.AutoRotatePeriod.GetHashCode();
                hashCode = (hashCode * 59) + this.DeletionAllowed.GetHashCode();
                hashCode = (hashCode * 59) + this.Exportable.GetHashCode();
                hashCode = (hashCode * 59) + this.MinDecryptionVersion.GetHashCode();
                hashCode = (hashCode * 59) + this.MinEncryptionVersion.GetHashCode();
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
