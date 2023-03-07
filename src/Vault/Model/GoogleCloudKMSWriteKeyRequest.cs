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
    /// GoogleCloudKMSWriteKeyRequest
    /// </summary>
    [DataContract(Name = "GoogleCloudKMSWriteKeyRequest")]
    public partial class GoogleCloudKMSWriteKeyRequest : IEquatable<GoogleCloudKMSWriteKeyRequest>, IValidatableObject
    {

















        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleCloudKMSWriteKeyRequest" /> class.
        /// </summary>

        /// <param name="Algorithm">Algorithm to use for encryption, decryption, or signing. The value depends on the key purpose. The value cannot be changed after creation. For a key purpose of \&quot;encrypt_decrypt\&quot;, the valid values are: - symmetric_encryption (default) For a key purpose of \&quot;asymmetric_sign\&quot;, valid values are: - rsa_sign_pss_2048_sha256 - rsa_sign_pss_3072_sha256 - rsa_sign_pss_4096_sha256 - rsa_sign_pkcs1_2048_sha256 - rsa_sign_pkcs1_3072_sha256 - rsa_sign_pkcs1_4096_sha256 - ec_sign_p256_sha256 - ec_sign_p384_sha384 For a key purpose of \&quot;asymmetric_decrypt\&quot;, valid values are: - rsa_decrypt_oaep_2048_sha256 - rsa_decrypt_oaep_3072_sha256 - rsa_decrypt_oaep_4096_sha256.</param>

        /// <param name="CryptoKey">Name of the crypto key to use. If the given crypto key does not exist, Vault will try to create it. This defaults to the name of the key given to Vault as the parameter if unspecified..</param>

        /// <param name="KeyRing">Full Google Cloud resource ID of the key ring with the project and location (e.g. projects/my-project/locations/global/keyRings/my-keyring). If the given key ring does not exist, Vault will try to create it during a create operation..</param>

        /// <param name="Labels">Arbitrary key&#x3D;value label to apply to the crypto key. To specify multiple labels, specify this argument multiple times (e.g. labels&#x3D;\&quot;a&#x3D;b\&quot; labels&#x3D;\&quot;c&#x3D;d\&quot;)..</param>

        /// <param name="ProtectionLevel">Level of protection to use for the key management. Valid values are \&quot;software\&quot; and \&quot;hsm\&quot;. The default value is \&quot;software\&quot;. The value cannot be changed after creation..</param>

        /// <param name="Purpose">Purpose of the key. Valid options are \&quot;asymmetric_decrypt\&quot;, \&quot;asymmetric_sign\&quot;, and \&quot;encrypt_decrypt\&quot;. The default value is \&quot;encrypt_decrypt\&quot;. The value cannot be changed after creation..</param>

        /// <param name="RotationPeriod">Amount of time between crypto key version rotations. This is specified as a time duration value like 72h (72 hours). The smallest possible value is 24h. This value only applies to keys with a purpose of \&quot;encrypt_decrypt\&quot;..</param>


        public GoogleCloudKMSWriteKeyRequest(string Algorithm = default(string), string CryptoKey = default(string), string KeyRing = default(string), Object Labels = default(Object), string ProtectionLevel = default(string), string Purpose = default(string), int RotationPeriod = default(int))
        {

            this.Algorithm = Algorithm;

            this.CryptoKey = CryptoKey;

            this.KeyRing = KeyRing;

            this.Labels = Labels;

            this.ProtectionLevel = ProtectionLevel;

            this.Purpose = Purpose;

            this.RotationPeriod = RotationPeriod;

        }

        /// <summary>
        /// Algorithm to use for encryption, decryption, or signing. The value depends on the key purpose. The value cannot be changed after creation. For a key purpose of \&quot;encrypt_decrypt\&quot;, the valid values are: - symmetric_encryption (default) For a key purpose of \&quot;asymmetric_sign\&quot;, valid values are: - rsa_sign_pss_2048_sha256 - rsa_sign_pss_3072_sha256 - rsa_sign_pss_4096_sha256 - rsa_sign_pkcs1_2048_sha256 - rsa_sign_pkcs1_3072_sha256 - rsa_sign_pkcs1_4096_sha256 - ec_sign_p256_sha256 - ec_sign_p384_sha384 For a key purpose of \&quot;asymmetric_decrypt\&quot;, valid values are: - rsa_decrypt_oaep_2048_sha256 - rsa_decrypt_oaep_3072_sha256 - rsa_decrypt_oaep_4096_sha256
        /// </summary>
        /// <value>Algorithm to use for encryption, decryption, or signing. The value depends on the key purpose. The value cannot be changed after creation. For a key purpose of \&quot;encrypt_decrypt\&quot;, the valid values are: - symmetric_encryption (default) For a key purpose of \&quot;asymmetric_sign\&quot;, valid values are: - rsa_sign_pss_2048_sha256 - rsa_sign_pss_3072_sha256 - rsa_sign_pss_4096_sha256 - rsa_sign_pkcs1_2048_sha256 - rsa_sign_pkcs1_3072_sha256 - rsa_sign_pkcs1_4096_sha256 - ec_sign_p256_sha256 - ec_sign_p384_sha384 For a key purpose of \&quot;asymmetric_decrypt\&quot;, valid values are: - rsa_decrypt_oaep_2048_sha256 - rsa_decrypt_oaep_3072_sha256 - rsa_decrypt_oaep_4096_sha256</value>
        [DataMember(Name = "algorithm", EmitDefaultValue = false)]


        public string Algorithm { get; set; }


        /// <summary>
        /// Name of the crypto key to use. If the given crypto key does not exist, Vault will try to create it. This defaults to the name of the key given to Vault as the parameter if unspecified.
        /// </summary>
        /// <value>Name of the crypto key to use. If the given crypto key does not exist, Vault will try to create it. This defaults to the name of the key given to Vault as the parameter if unspecified.</value>
        [DataMember(Name = "crypto_key", EmitDefaultValue = false)]


        public string CryptoKey { get; set; }


        /// <summary>
        /// Full Google Cloud resource ID of the key ring with the project and location (e.g. projects/my-project/locations/global/keyRings/my-keyring). If the given key ring does not exist, Vault will try to create it during a create operation.
        /// </summary>
        /// <value>Full Google Cloud resource ID of the key ring with the project and location (e.g. projects/my-project/locations/global/keyRings/my-keyring). If the given key ring does not exist, Vault will try to create it during a create operation.</value>
        [DataMember(Name = "key_ring", EmitDefaultValue = false)]


        public string KeyRing { get; set; }


        /// <summary>
        /// Arbitrary key&#x3D;value label to apply to the crypto key. To specify multiple labels, specify this argument multiple times (e.g. labels&#x3D;\&quot;a&#x3D;b\&quot; labels&#x3D;\&quot;c&#x3D;d\&quot;).
        /// </summary>
        /// <value>Arbitrary key&#x3D;value label to apply to the crypto key. To specify multiple labels, specify this argument multiple times (e.g. labels&#x3D;\&quot;a&#x3D;b\&quot; labels&#x3D;\&quot;c&#x3D;d\&quot;).</value>
        [DataMember(Name = "labels", EmitDefaultValue = false)]


        public Object Labels { get; set; }


        /// <summary>
        /// Level of protection to use for the key management. Valid values are \&quot;software\&quot; and \&quot;hsm\&quot;. The default value is \&quot;software\&quot;. The value cannot be changed after creation.
        /// </summary>
        /// <value>Level of protection to use for the key management. Valid values are \&quot;software\&quot; and \&quot;hsm\&quot;. The default value is \&quot;software\&quot;. The value cannot be changed after creation.</value>
        [DataMember(Name = "protection_level", EmitDefaultValue = false)]


        public string ProtectionLevel { get; set; }


        /// <summary>
        /// Purpose of the key. Valid options are \&quot;asymmetric_decrypt\&quot;, \&quot;asymmetric_sign\&quot;, and \&quot;encrypt_decrypt\&quot;. The default value is \&quot;encrypt_decrypt\&quot;. The value cannot be changed after creation.
        /// </summary>
        /// <value>Purpose of the key. Valid options are \&quot;asymmetric_decrypt\&quot;, \&quot;asymmetric_sign\&quot;, and \&quot;encrypt_decrypt\&quot;. The default value is \&quot;encrypt_decrypt\&quot;. The value cannot be changed after creation.</value>
        [DataMember(Name = "purpose", EmitDefaultValue = false)]


        public string Purpose { get; set; }


        /// <summary>
        /// Amount of time between crypto key version rotations. This is specified as a time duration value like 72h (72 hours). The smallest possible value is 24h. This value only applies to keys with a purpose of \&quot;encrypt_decrypt\&quot;.
        /// </summary>
        /// <value>Amount of time between crypto key version rotations. This is specified as a time duration value like 72h (72 hours). The smallest possible value is 24h. This value only applies to keys with a purpose of \&quot;encrypt_decrypt\&quot;.</value>
        [DataMember(Name = "rotation_period", EmitDefaultValue = false)]


        public int RotationPeriod { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoogleCloudKMSWriteKeyRequest {\n");
            sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("  CryptoKey: ").Append(CryptoKey).Append("\n");
            sb.Append("  KeyRing: ").Append(KeyRing).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  ProtectionLevel: ").Append(ProtectionLevel).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  RotationPeriod: ").Append(RotationPeriod).Append("\n");
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
            return this.Equals(input as GoogleCloudKMSWriteKeyRequest);
        }

        /// <summary>
        /// Returns true if GoogleCloudKMSWriteKeyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleCloudKMSWriteKeyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleCloudKMSWriteKeyRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Algorithm == input.Algorithm ||
                    (this.Algorithm != null &&
                    this.Algorithm.Equals(input.Algorithm))

                ) &&
                (
                    this.CryptoKey == input.CryptoKey ||
                    (this.CryptoKey != null &&
                    this.CryptoKey.Equals(input.CryptoKey))

                ) &&
                (
                    this.KeyRing == input.KeyRing ||
                    (this.KeyRing != null &&
                    this.KeyRing.Equals(input.KeyRing))

                ) &&
                (
                    this.Labels == input.Labels ||
                    (this.Labels != null &&
                    this.Labels.Equals(input.Labels))

                ) &&
                (
                    this.ProtectionLevel == input.ProtectionLevel ||
                    (this.ProtectionLevel != null &&
                    this.ProtectionLevel.Equals(input.ProtectionLevel))

                ) &&
                (
                    this.Purpose == input.Purpose ||
                    (this.Purpose != null &&
                    this.Purpose.Equals(input.Purpose))

                ) &&
                (
                    this.RotationPeriod == input.RotationPeriod ||

                    this.RotationPeriod.Equals(input.RotationPeriod)
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

                if (this.Algorithm != null)
                {
                    hashCode = (hashCode * 59) + this.Algorithm.GetHashCode();
                }

                if (this.CryptoKey != null)
                {
                    hashCode = (hashCode * 59) + this.CryptoKey.GetHashCode();
                }

                if (this.KeyRing != null)
                {
                    hashCode = (hashCode * 59) + this.KeyRing.GetHashCode();
                }

                if (this.Labels != null)
                {
                    hashCode = (hashCode * 59) + this.Labels.GetHashCode();
                }

                if (this.ProtectionLevel != null)
                {
                    hashCode = (hashCode * 59) + this.ProtectionLevel.GetHashCode();
                }

                if (this.Purpose != null)
                {
                    hashCode = (hashCode * 59) + this.Purpose.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.RotationPeriod.GetHashCode();
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
