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
    /// MFAMethodWriteTOTPRequest
    /// </summary>
    [DataContract(Name = "MFAMethodWriteTOTPRequest")]

    public partial class MFAMethodWriteTOTPRequest : IEquatable<MFAMethodWriteTOTPRequest>, IValidatableObject
    {





















        /// <summary>
        /// Initializes a new instance of the <see cref="MFAMethodWriteTOTPRequest" /> class.
        /// </summary>

        /// <param name="Algorithm">The hashing algorithm used to generate the TOTP token. Options include SHA1, SHA256 and SHA512. (default to &quot;SHA1&quot;).</param>

        /// <param name="Digits">The number of digits in the generated TOTP token. This value can either be 6 or 8. (default to 6).</param>

        /// <param name="Issuer">The name of the key&#x27;s issuing organization..</param>

        /// <param name="KeySize">Determines the size in bytes of the generated key. (default to 20).</param>

        /// <param name="MaxValidationAttempts">Max number of allowed validation attempts..</param>

        /// <param name="MethodId">The unique identifier for this MFA method..</param>

        /// <param name="Period">The length of time used to generate a counter for the TOTP token calculation. (default to 30).</param>

        /// <param name="QrSize">The pixel size of the generated square QR code. (default to 200).</param>

        /// <param name="Skew">The number of delay periods that are allowed when validating a TOTP token. This value can either be 0 or 1. (default to 1).</param>


        public MFAMethodWriteTOTPRequest(string Algorithm = "SHA1", int Digits = 6, string Issuer = default(string), int KeySize = 20, int MaxValidationAttempts = default(int), string MethodId = default(string), int Period = 30, int QrSize = 200, int Skew = 1)
        {

            // use default value if no "Algorithm" provided
            this.Algorithm = Algorithm ?? "SHA1";


            this.Digits = Digits;

            this.Issuer = Issuer;

            this.KeySize = KeySize;

            this.MaxValidationAttempts = MaxValidationAttempts;

            this.MethodId = MethodId;

            this.Period = Period;

            this.QrSize = QrSize;

            this.Skew = Skew;

        }

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
        /// The name of the key&#x27;s issuing organization.
        /// </summary>
        /// <value>The name of the key&#x27;s issuing organization.</value>
        [DataMember(Name = "issuer", EmitDefaultValue = false)]


        public string Issuer { get; set; }


        /// <summary>
        /// Determines the size in bytes of the generated key.
        /// </summary>
        /// <value>Determines the size in bytes of the generated key.</value>
        [DataMember(Name = "key_size", EmitDefaultValue = false)]


        public int KeySize { get; set; }


        /// <summary>
        /// Max number of allowed validation attempts.
        /// </summary>
        /// <value>Max number of allowed validation attempts.</value>
        [DataMember(Name = "max_validation_attempts", EmitDefaultValue = false)]


        public int MaxValidationAttempts { get; set; }


        /// <summary>
        /// The unique identifier for this MFA method.
        /// </summary>
        /// <value>The unique identifier for this MFA method.</value>
        [DataMember(Name = "method_id", EmitDefaultValue = false)]


        public string MethodId { get; set; }


        /// <summary>
        /// The length of time used to generate a counter for the TOTP token calculation.
        /// </summary>
        /// <value>The length of time used to generate a counter for the TOTP token calculation.</value>
        [DataMember(Name = "period", EmitDefaultValue = false)]


        public int Period { get; set; }


        /// <summary>
        /// The pixel size of the generated square QR code.
        /// </summary>
        /// <value>The pixel size of the generated square QR code.</value>
        [DataMember(Name = "qr_size", EmitDefaultValue = false)]


        public int QrSize { get; set; }


        /// <summary>
        /// The number of delay periods that are allowed when validating a TOTP token. This value can either be 0 or 1.
        /// </summary>
        /// <value>The number of delay periods that are allowed when validating a TOTP token. This value can either be 0 or 1.</value>
        [DataMember(Name = "skew", EmitDefaultValue = false)]


        public int Skew { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MFAMethodWriteTOTPRequest {\n");
            sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("  Digits: ").Append(Digits).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  KeySize: ").Append(KeySize).Append("\n");
            sb.Append("  MaxValidationAttempts: ").Append(MaxValidationAttempts).Append("\n");
            sb.Append("  MethodId: ").Append(MethodId).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  QrSize: ").Append(QrSize).Append("\n");
            sb.Append("  Skew: ").Append(Skew).Append("\n");
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
            return this.Equals(input as MFAMethodWriteTOTPRequest);
        }

        /// <summary>
        /// Returns true if MFAMethodWriteTOTPRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MFAMethodWriteTOTPRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MFAMethodWriteTOTPRequest input)
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
                    this.Digits == input.Digits ||

                    this.Digits.Equals(input.Digits)
                ) &&
                (
                    this.Issuer == input.Issuer ||
                    (this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer))

                ) &&
                (
                    this.KeySize == input.KeySize ||

                    this.KeySize.Equals(input.KeySize)
                ) &&
                (
                    this.MaxValidationAttempts == input.MaxValidationAttempts ||

                    this.MaxValidationAttempts.Equals(input.MaxValidationAttempts)
                ) &&
                (
                    this.MethodId == input.MethodId ||
                    (this.MethodId != null &&
                    this.MethodId.Equals(input.MethodId))

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


                hashCode = (hashCode * 59) + this.Digits.GetHashCode();
                if (this.Issuer != null)
                {
                    hashCode = (hashCode * 59) + this.Issuer.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.KeySize.GetHashCode();

                hashCode = (hashCode * 59) + this.MaxValidationAttempts.GetHashCode();
                if (this.MethodId != null)
                {
                    hashCode = (hashCode * 59) + this.MethodId.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Period.GetHashCode();

                hashCode = (hashCode * 59) + this.QrSize.GetHashCode();

                hashCode = (hashCode * 59) + this.Skew.GetHashCode();
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
