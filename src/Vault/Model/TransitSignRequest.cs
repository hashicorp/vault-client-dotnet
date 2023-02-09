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
    /// TransitSignRequest
    /// </summary>
    [DataContract(Name = "TransitSignRequest")]
    public partial class TransitSignRequest : IEquatable<TransitSignRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransitSignRequest" /> class.
        /// </summary>
        /// <param name="algorithm">Deprecated: use \&quot;hash_algorithm\&quot; instead. (default to &quot;sha2-256&quot;).</param>
        /// <param name="context">Base64 encoded context for key derivation. Required if key derivation is enabled; currently only available with ed25519 keys..</param>
        /// <param name="hashAlgorithm">Hash algorithm to use (POST body parameter). Valid values are: * sha1 * sha2-224 * sha2-256 * sha2-384 * sha2-512 * sha3-224 * sha3-256 * sha3-384 * sha3-512 * none Defaults to \&quot;sha2-256\&quot;. Not valid for all key types, including ed25519. Using none requires setting prehashed&#x3D;true and signature_algorithm&#x3D;pkcs1v15, yielding a PKCSv1_5_NoOID instead of the usual PKCSv1_5_DERnull signature. (default to &quot;sha2-256&quot;).</param>
        /// <param name="input">The base64-encoded input data.</param>
        /// <param name="keyVersion">The version of the key to use for signing. Must be 0 (for latest) or a value greater than or equal to the min_encryption_version configured on the key..</param>
        /// <param name="marshalingAlgorithm">The method by which to marshal the signature. The default is &#39;asn1&#39; which is used by openssl and X.509. It can also be set to &#39;jws&#39; which is used for JWT signatures; setting it to this will also cause the encoding of the signature to be url-safe base64 instead of using standard base64 encoding. Currently only valid for ECDSA P-256 key types\&quot;. (default to &quot;asn1&quot;).</param>
        /// <param name="prehashed">Set to &#39;true&#39; when the input is already hashed. If the key type is &#39;rsa-2048&#39;, &#39;rsa-3072&#39; or &#39;rsa-4096&#39;, then the algorithm used to hash the input should be indicated by the &#39;algorithm&#39; parameter..</param>
        /// <param name="saltLength">The salt length used to sign. Currently only applies to the RSA PSS signature scheme. Options are &#39;auto&#39; (the default used by Golang, causing the salt to be as large as possible when signing), &#39;hash&#39; (causes the salt length to equal the length of the hash used in the signature), or an integer between the minimum and the maximum permissible salt lengths for the given RSA key size. Defaults to &#39;auto&#39;. (default to &quot;auto&quot;).</param>
        /// <param name="signatureAlgorithm">The signature algorithm to use for signing. Currently only applies to RSA key types. Options are &#39;pss&#39; or &#39;pkcs1v15&#39;. Defaults to &#39;pss&#39;.</param>
        /// <param name="urlalgorithm">Hash algorithm to use (POST URL parameter).</param>
        public TransitSignRequest(string algorithm = "sha2-256", string context = default(string), string hashAlgorithm = "sha2-256", string input = default(string), int keyVersion = default(int), string marshalingAlgorithm = "asn1", bool prehashed = default(bool), string saltLength = "auto", string signatureAlgorithm = default(string), string urlalgorithm = default(string))
        {
            // use default value if no "algorithm" provided
            this.Algorithm = algorithm ?? "sha2-256";
            this.Context = context;
            // use default value if no "hashAlgorithm" provided
            this.HashAlgorithm = hashAlgorithm ?? "sha2-256";
            this.Input = input;
            this.KeyVersion = keyVersion;
            // use default value if no "marshalingAlgorithm" provided
            this.MarshalingAlgorithm = marshalingAlgorithm ?? "asn1";
            this.Prehashed = prehashed;
            // use default value if no "saltLength" provided
            this.SaltLength = saltLength ?? "auto";
            this.SignatureAlgorithm = signatureAlgorithm;
            this.Urlalgorithm = urlalgorithm;
        }

        /// <summary>
        /// Deprecated: use \&quot;hash_algorithm\&quot; instead.
        /// </summary>
        /// <value>Deprecated: use \&quot;hash_algorithm\&quot; instead.</value>
        [DataMember(Name = "algorithm", EmitDefaultValue = false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// Base64 encoded context for key derivation. Required if key derivation is enabled; currently only available with ed25519 keys.
        /// </summary>
        /// <value>Base64 encoded context for key derivation. Required if key derivation is enabled; currently only available with ed25519 keys.</value>
        [DataMember(Name = "context", EmitDefaultValue = false)]
        public string Context { get; set; }

        /// <summary>
        /// Hash algorithm to use (POST body parameter). Valid values are: * sha1 * sha2-224 * sha2-256 * sha2-384 * sha2-512 * sha3-224 * sha3-256 * sha3-384 * sha3-512 * none Defaults to \&quot;sha2-256\&quot;. Not valid for all key types, including ed25519. Using none requires setting prehashed&#x3D;true and signature_algorithm&#x3D;pkcs1v15, yielding a PKCSv1_5_NoOID instead of the usual PKCSv1_5_DERnull signature.
        /// </summary>
        /// <value>Hash algorithm to use (POST body parameter). Valid values are: * sha1 * sha2-224 * sha2-256 * sha2-384 * sha2-512 * sha3-224 * sha3-256 * sha3-384 * sha3-512 * none Defaults to \&quot;sha2-256\&quot;. Not valid for all key types, including ed25519. Using none requires setting prehashed&#x3D;true and signature_algorithm&#x3D;pkcs1v15, yielding a PKCSv1_5_NoOID instead of the usual PKCSv1_5_DERnull signature.</value>
        [DataMember(Name = "hash_algorithm", EmitDefaultValue = false)]
        public string HashAlgorithm { get; set; }

        /// <summary>
        /// The base64-encoded input data
        /// </summary>
        /// <value>The base64-encoded input data</value>
        [DataMember(Name = "input", EmitDefaultValue = false)]
        public string Input { get; set; }

        /// <summary>
        /// The version of the key to use for signing. Must be 0 (for latest) or a value greater than or equal to the min_encryption_version configured on the key.
        /// </summary>
        /// <value>The version of the key to use for signing. Must be 0 (for latest) or a value greater than or equal to the min_encryption_version configured on the key.</value>
        [DataMember(Name = "key_version", EmitDefaultValue = false)]
        public int KeyVersion { get; set; }

        /// <summary>
        /// The method by which to marshal the signature. The default is &#39;asn1&#39; which is used by openssl and X.509. It can also be set to &#39;jws&#39; which is used for JWT signatures; setting it to this will also cause the encoding of the signature to be url-safe base64 instead of using standard base64 encoding. Currently only valid for ECDSA P-256 key types\&quot;.
        /// </summary>
        /// <value>The method by which to marshal the signature. The default is &#39;asn1&#39; which is used by openssl and X.509. It can also be set to &#39;jws&#39; which is used for JWT signatures; setting it to this will also cause the encoding of the signature to be url-safe base64 instead of using standard base64 encoding. Currently only valid for ECDSA P-256 key types\&quot;.</value>
        [DataMember(Name = "marshaling_algorithm", EmitDefaultValue = false)]
        public string MarshalingAlgorithm { get; set; }

        /// <summary>
        /// Set to &#39;true&#39; when the input is already hashed. If the key type is &#39;rsa-2048&#39;, &#39;rsa-3072&#39; or &#39;rsa-4096&#39;, then the algorithm used to hash the input should be indicated by the &#39;algorithm&#39; parameter.
        /// </summary>
        /// <value>Set to &#39;true&#39; when the input is already hashed. If the key type is &#39;rsa-2048&#39;, &#39;rsa-3072&#39; or &#39;rsa-4096&#39;, then the algorithm used to hash the input should be indicated by the &#39;algorithm&#39; parameter.</value>
        [DataMember(Name = "prehashed", EmitDefaultValue = true)]
        public bool Prehashed { get; set; }

        /// <summary>
        /// The salt length used to sign. Currently only applies to the RSA PSS signature scheme. Options are &#39;auto&#39; (the default used by Golang, causing the salt to be as large as possible when signing), &#39;hash&#39; (causes the salt length to equal the length of the hash used in the signature), or an integer between the minimum and the maximum permissible salt lengths for the given RSA key size. Defaults to &#39;auto&#39;.
        /// </summary>
        /// <value>The salt length used to sign. Currently only applies to the RSA PSS signature scheme. Options are &#39;auto&#39; (the default used by Golang, causing the salt to be as large as possible when signing), &#39;hash&#39; (causes the salt length to equal the length of the hash used in the signature), or an integer between the minimum and the maximum permissible salt lengths for the given RSA key size. Defaults to &#39;auto&#39;.</value>
        [DataMember(Name = "salt_length", EmitDefaultValue = false)]
        public string SaltLength { get; set; }

        /// <summary>
        /// The signature algorithm to use for signing. Currently only applies to RSA key types. Options are &#39;pss&#39; or &#39;pkcs1v15&#39;. Defaults to &#39;pss&#39;
        /// </summary>
        /// <value>The signature algorithm to use for signing. Currently only applies to RSA key types. Options are &#39;pss&#39; or &#39;pkcs1v15&#39;. Defaults to &#39;pss&#39;</value>
        [DataMember(Name = "signature_algorithm", EmitDefaultValue = false)]
        public string SignatureAlgorithm { get; set; }

        /// <summary>
        /// Hash algorithm to use (POST URL parameter)
        /// </summary>
        /// <value>Hash algorithm to use (POST URL parameter)</value>
        [DataMember(Name = "urlalgorithm", EmitDefaultValue = false)]
        public string Urlalgorithm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransitSignRequest {\n");
            sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  HashAlgorithm: ").Append(HashAlgorithm).Append("\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  KeyVersion: ").Append(KeyVersion).Append("\n");
            sb.Append("  MarshalingAlgorithm: ").Append(MarshalingAlgorithm).Append("\n");
            sb.Append("  Prehashed: ").Append(Prehashed).Append("\n");
            sb.Append("  SaltLength: ").Append(SaltLength).Append("\n");
            sb.Append("  SignatureAlgorithm: ").Append(SignatureAlgorithm).Append("\n");
            sb.Append("  Urlalgorithm: ").Append(Urlalgorithm).Append("\n");
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
            return this.Equals(input as TransitSignRequest);
        }

        /// <summary>
        /// Returns true if TransitSignRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransitSignRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransitSignRequest input)
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
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.HashAlgorithm == input.HashAlgorithm ||
                    (this.HashAlgorithm != null &&
                    this.HashAlgorithm.Equals(input.HashAlgorithm))
                ) && 
                (
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))
                ) && 
                (
                    this.KeyVersion == input.KeyVersion ||
                    this.KeyVersion.Equals(input.KeyVersion)
                ) && 
                (
                    this.MarshalingAlgorithm == input.MarshalingAlgorithm ||
                    (this.MarshalingAlgorithm != null &&
                    this.MarshalingAlgorithm.Equals(input.MarshalingAlgorithm))
                ) && 
                (
                    this.Prehashed == input.Prehashed ||
                    this.Prehashed.Equals(input.Prehashed)
                ) && 
                (
                    this.SaltLength == input.SaltLength ||
                    (this.SaltLength != null &&
                    this.SaltLength.Equals(input.SaltLength))
                ) && 
                (
                    this.SignatureAlgorithm == input.SignatureAlgorithm ||
                    (this.SignatureAlgorithm != null &&
                    this.SignatureAlgorithm.Equals(input.SignatureAlgorithm))
                ) && 
                (
                    this.Urlalgorithm == input.Urlalgorithm ||
                    (this.Urlalgorithm != null &&
                    this.Urlalgorithm.Equals(input.Urlalgorithm))
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
                if (this.Context != null)
                {
                    hashCode = (hashCode * 59) + this.Context.GetHashCode();
                }
                if (this.HashAlgorithm != null)
                {
                    hashCode = (hashCode * 59) + this.HashAlgorithm.GetHashCode();
                }
                if (this.Input != null)
                {
                    hashCode = (hashCode * 59) + this.Input.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.KeyVersion.GetHashCode();
                if (this.MarshalingAlgorithm != null)
                {
                    hashCode = (hashCode * 59) + this.MarshalingAlgorithm.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Prehashed.GetHashCode();
                if (this.SaltLength != null)
                {
                    hashCode = (hashCode * 59) + this.SaltLength.GetHashCode();
                }
                if (this.SignatureAlgorithm != null)
                {
                    hashCode = (hashCode * 59) + this.SignatureAlgorithm.GetHashCode();
                }
                if (this.Urlalgorithm != null)
                {
                    hashCode = (hashCode * 59) + this.Urlalgorithm.GetHashCode();
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
