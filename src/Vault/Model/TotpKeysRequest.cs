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

namespace Vault.Model
{
    /// <summary>
    /// TotpKeysRequest
    /// </summary>
    [DataContract(Name = "TotpKeysRequest")]
    public partial class TotpKeysRequest : IEquatable<TotpKeysRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TotpKeysRequest" /> class.
        /// </summary>
        /// <param name="accountName">The name of the account associated with the key. Required if generate is true..</param>
        /// <param name="algorithm">The hashing algorithm used to generate the TOTP token. Options include SHA1, SHA256 and SHA512. (default to &quot;SHA1&quot;).</param>
        /// <param name="digits">The number of digits in the generated TOTP token. This value can either be 6 or 8. (default to 6).</param>
        /// <param name="exported">Determines if a QR code and url are returned upon generating a key. Only used if generate is true. (default to true).</param>
        /// <param name="generate">Determines if a key should be generated by Vault or if a key is being passed from another service. (default to false).</param>
        /// <param name="issuer">The name of the key&#39;s issuing organization. Required if generate is true..</param>
        /// <param name="key">The shared master key used to generate a TOTP token. Only used if generate is false..</param>
        /// <param name="keySize">Determines the size in bytes of the generated key. Only used if generate is true. (default to 20).</param>
        /// <param name="period">The length of time used to generate a counter for the TOTP token calculation. (default to 30).</param>
        /// <param name="qrSize">The pixel size of the generated square QR code. Only used if generate is true and exported is true. If this value is 0, a QR code will not be returned. (default to 200).</param>
        /// <param name="skew">The number of delay periods that are allowed when validating a TOTP token. This value can either be 0 or 1. Only used if generate is true. (default to 1).</param>
        /// <param name="url">A TOTP url string containing all of the parameters for key setup. Only used if generate is false..</param>
        public TotpKeysRequest(string accountName = default(string), string algorithm = "SHA1", int digits = 6, bool exported = true, bool generate = false, string issuer = default(string), string key = default(string), int keySize = 20, int period = 30, int qrSize = 200, int skew = 1, string url = default(string))
        {
            this.AccountName = accountName;
            // use default value if no "algorithm" provided
            this.Algorithm = algorithm ?? "SHA1";
            this.Digits = digits;
            this.Exported = exported;
            this.Generate = generate;
            this.Issuer = issuer;
            this.Key = key;
            this.KeySize = keySize;
            this.Period = period;
            this.QrSize = qrSize;
            this.Skew = skew;
            this.Url = url;
        }

        /// <summary>
        /// The name of the account associated with the key. Required if generate is true.
        /// </summary>
        /// <value>The name of the account associated with the key. Required if generate is true.</value>
        [DataMember(Name = "account_name", EmitDefaultValue = false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The hashing algorithm used to generate the TOTP token. Options include SHA1, SHA256 and SHA512.
        /// </summary>
        /// <value>The hashing algorithm used to generate the TOTP token. Options include SHA1, SHA256 and SHA512.</value>
        [DataMember(Name = "algorithm", EmitDefaultValue = false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// The number of digits in the generated TOTP token. This value can either be 6 or 8.
        /// </summary>
        /// <value>The number of digits in the generated TOTP token. This value can either be 6 or 8.</value>
        [DataMember(Name = "digits", EmitDefaultValue = false)]
        public int Digits { get; set; }

        /// <summary>
        /// Determines if a QR code and url are returned upon generating a key. Only used if generate is true.
        /// </summary>
        /// <value>Determines if a QR code and url are returned upon generating a key. Only used if generate is true.</value>
        [DataMember(Name = "exported", EmitDefaultValue = true)]
        public bool Exported { get; set; }

        /// <summary>
        /// Determines if a key should be generated by Vault or if a key is being passed from another service.
        /// </summary>
        /// <value>Determines if a key should be generated by Vault or if a key is being passed from another service.</value>
        [DataMember(Name = "generate", EmitDefaultValue = true)]
        public bool Generate { get; set; }

        /// <summary>
        /// The name of the key&#39;s issuing organization. Required if generate is true.
        /// </summary>
        /// <value>The name of the key&#39;s issuing organization. Required if generate is true.</value>
        [DataMember(Name = "issuer", EmitDefaultValue = false)]
        public string Issuer { get; set; }

        /// <summary>
        /// The shared master key used to generate a TOTP token. Only used if generate is false.
        /// </summary>
        /// <value>The shared master key used to generate a TOTP token. Only used if generate is false.</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Determines the size in bytes of the generated key. Only used if generate is true.
        /// </summary>
        /// <value>Determines the size in bytes of the generated key. Only used if generate is true.</value>
        [DataMember(Name = "key_size", EmitDefaultValue = false)]
        public int KeySize { get; set; }

        /// <summary>
        /// The length of time used to generate a counter for the TOTP token calculation.
        /// </summary>
        /// <value>The length of time used to generate a counter for the TOTP token calculation.</value>
        [DataMember(Name = "period", EmitDefaultValue = false)]
        public int Period { get; set; }

        /// <summary>
        /// The pixel size of the generated square QR code. Only used if generate is true and exported is true. If this value is 0, a QR code will not be returned.
        /// </summary>
        /// <value>The pixel size of the generated square QR code. Only used if generate is true and exported is true. If this value is 0, a QR code will not be returned.</value>
        [DataMember(Name = "qr_size", EmitDefaultValue = false)]
        public int QrSize { get; set; }

        /// <summary>
        /// The number of delay periods that are allowed when validating a TOTP token. This value can either be 0 or 1. Only used if generate is true.
        /// </summary>
        /// <value>The number of delay periods that are allowed when validating a TOTP token. This value can either be 0 or 1. Only used if generate is true.</value>
        [DataMember(Name = "skew", EmitDefaultValue = false)]
        public int Skew { get; set; }

        /// <summary>
        /// A TOTP url string containing all of the parameters for key setup. Only used if generate is false.
        /// </summary>
        /// <value>A TOTP url string containing all of the parameters for key setup. Only used if generate is false.</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TotpKeysRequest {\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("  Digits: ").Append(Digits).Append("\n");
            sb.Append("  Exported: ").Append(Exported).Append("\n");
            sb.Append("  Generate: ").Append(Generate).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  KeySize: ").Append(KeySize).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  QrSize: ").Append(QrSize).Append("\n");
            sb.Append("  Skew: ").Append(Skew).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as TotpKeysRequest);
        }

        /// <summary>
        /// Returns true if TotpKeysRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TotpKeysRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TotpKeysRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.Algorithm == input.Algorithm ||
                    (this.Algorithm != null &&
                    this.Algorithm.Equals(input.Algorithm))
                ) && 
                (
                    this.Digits == input.Digits ||
                    this.Digits.Equals(input.Digits)
                ) && 
                (
                    this.Exported == input.Exported ||
                    this.Exported.Equals(input.Exported)
                ) && 
                (
                    this.Generate == input.Generate ||
                    this.Generate.Equals(input.Generate)
                ) && 
                (
                    this.Issuer == input.Issuer ||
                    (this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.KeySize == input.KeySize ||
                    this.KeySize.Equals(input.KeySize)
                ) && 
                (
                    this.Period == input.Period ||
                    this.Period.Equals(input.Period)
                ) && 
                (
                    this.QrSize == input.QrSize ||
                    this.QrSize.Equals(input.QrSize)
                ) && 
                (
                    this.Skew == input.Skew ||
                    this.Skew.Equals(input.Skew)
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.AccountName != null)
                {
                    hashCode = (hashCode * 59) + this.AccountName.GetHashCode();
                }
                if (this.Algorithm != null)
                {
                    hashCode = (hashCode * 59) + this.Algorithm.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Digits.GetHashCode();
                hashCode = (hashCode * 59) + this.Exported.GetHashCode();
                hashCode = (hashCode * 59) + this.Generate.GetHashCode();
                if (this.Issuer != null)
                {
                    hashCode = (hashCode * 59) + this.Issuer.GetHashCode();
                }
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.KeySize.GetHashCode();
                hashCode = (hashCode * 59) + this.Period.GetHashCode();
                hashCode = (hashCode * 59) + this.QrSize.GetHashCode();
                hashCode = (hashCode * 59) + this.Skew.GetHashCode();
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
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
