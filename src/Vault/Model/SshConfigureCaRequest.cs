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
    /// SshConfigureCaRequest
    /// </summary>
    [DataContract(Name = "SshConfigureCaRequest")]
    public partial class SshConfigureCaRequest : IEquatable<SshConfigureCaRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="SshConfigureCaRequest" /> class.
        /// </summary>

        /// <param name="GenerateSigningKey">Generate SSH key pair internally rather than use the private_key and public_key fields. (default to true).</param>

        /// <param name="KeyBits">Specifies the desired key bits when generating variable-length keys (such as when key_type&#x3D;\&quot;ssh-rsa\&quot;) or which NIST P-curve to use when key_type&#x3D;\&quot;ec\&quot; (256, 384, or 521). (default to 0).</param>

        /// <param name="KeyType">Specifies the desired key type when generating; could be a OpenSSH key type identifier (ssh-rsa, ecdsa-sha2-nistp256, ecdsa-sha2-nistp384, ecdsa-sha2-nistp521, or ssh-ed25519) or an algorithm (rsa, ec, ed25519). (default to &quot;ssh-rsa&quot;).</param>

        /// <param name="PrivateKey">Private half of the SSH key that will be used to sign certificates..</param>

        /// <param name="PublicKey">Public half of the SSH key that will be used to sign certificates..</param>


        public SshConfigureCaRequest(bool GenerateSigningKey = true, int KeyBits = 0, string KeyType = "ssh-rsa", string PrivateKey = default(string), string PublicKey = default(string))
        {

            this.GenerateSigningKey = GenerateSigningKey;

            this.KeyBits = KeyBits;

            // use default value if no "KeyType" provided
            this.KeyType = KeyType ?? "ssh-rsa";


            this.PrivateKey = PrivateKey;

            this.PublicKey = PublicKey;

        }

        /// <summary>
        /// Generate SSH key pair internally rather than use the private_key and public_key fields.
        /// </summary>
        /// <value>Generate SSH key pair internally rather than use the private_key and public_key fields.</value>
        [DataMember(Name = "generate_signing_key", EmitDefaultValue = true)]

        public bool GenerateSigningKey { get; set; }


        /// <summary>
        /// Specifies the desired key bits when generating variable-length keys (such as when key_type&#x3D;\&quot;ssh-rsa\&quot;) or which NIST P-curve to use when key_type&#x3D;\&quot;ec\&quot; (256, 384, or 521).
        /// </summary>
        /// <value>Specifies the desired key bits when generating variable-length keys (such as when key_type&#x3D;\&quot;ssh-rsa\&quot;) or which NIST P-curve to use when key_type&#x3D;\&quot;ec\&quot; (256, 384, or 521).</value>
        [DataMember(Name = "key_bits", EmitDefaultValue = false)]

        public int KeyBits { get; set; }


        /// <summary>
        /// Specifies the desired key type when generating; could be a OpenSSH key type identifier (ssh-rsa, ecdsa-sha2-nistp256, ecdsa-sha2-nistp384, ecdsa-sha2-nistp521, or ssh-ed25519) or an algorithm (rsa, ec, ed25519).
        /// </summary>
        /// <value>Specifies the desired key type when generating; could be a OpenSSH key type identifier (ssh-rsa, ecdsa-sha2-nistp256, ecdsa-sha2-nistp384, ecdsa-sha2-nistp521, or ssh-ed25519) or an algorithm (rsa, ec, ed25519).</value>
        [DataMember(Name = "key_type", EmitDefaultValue = false)]

        public string KeyType { get; set; }


        /// <summary>
        /// Private half of the SSH key that will be used to sign certificates.
        /// </summary>
        /// <value>Private half of the SSH key that will be used to sign certificates.</value>
        [DataMember(Name = "private_key", EmitDefaultValue = false)]

        public string PrivateKey { get; set; }


        /// <summary>
        /// Public half of the SSH key that will be used to sign certificates.
        /// </summary>
        /// <value>Public half of the SSH key that will be used to sign certificates.</value>
        [DataMember(Name = "public_key", EmitDefaultValue = false)]

        public string PublicKey { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SshConfigureCaRequest {\n");
            sb.Append("  GenerateSigningKey: ").Append(GenerateSigningKey).Append("\n");
            sb.Append("  KeyBits: ").Append(KeyBits).Append("\n");
            sb.Append("  KeyType: ").Append(KeyType).Append("\n");
            sb.Append("  PrivateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
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
            return this.Equals(input as SshConfigureCaRequest);
        }

        /// <summary>
        /// Returns true if SshConfigureCaRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SshConfigureCaRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SshConfigureCaRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.GenerateSigningKey == input.GenerateSigningKey ||

                    this.GenerateSigningKey.Equals(input.GenerateSigningKey)
                ) &&
                (
                    this.KeyBits == input.KeyBits ||

                    this.KeyBits.Equals(input.KeyBits)
                ) &&
                (
                    this.KeyType == input.KeyType ||
                    (this.KeyType != null &&
                    this.KeyType.Equals(input.KeyType))

                ) &&
                (
                    this.PrivateKey == input.PrivateKey ||
                    (this.PrivateKey != null &&
                    this.PrivateKey.Equals(input.PrivateKey))

                ) &&
                (
                    this.PublicKey == input.PublicKey ||
                    (this.PublicKey != null &&
                    this.PublicKey.Equals(input.PublicKey))

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


                hashCode = (hashCode * 59) + this.GenerateSigningKey.GetHashCode();

                hashCode = (hashCode * 59) + this.KeyBits.GetHashCode();
                if (this.KeyType != null)
                {
                    hashCode = (hashCode * 59) + this.KeyType.GetHashCode();
                }

                if (this.PrivateKey != null)
                {
                    hashCode = (hashCode * 59) + this.PrivateKey.GetHashCode();
                }

                if (this.PublicKey != null)
                {
                    hashCode = (hashCode * 59) + this.PublicKey.GetHashCode();
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
