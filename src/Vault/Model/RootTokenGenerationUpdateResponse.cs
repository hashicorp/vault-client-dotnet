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
    /// RootTokenGenerationUpdateResponse
    /// </summary>
    [DataContract(Name = "RootTokenGenerationUpdateResponse")]
    public partial class RootTokenGenerationUpdateResponse : IEquatable<RootTokenGenerationUpdateResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="RootTokenGenerationUpdateResponse" /> class.
        /// </summary>

        /// <param name="Complete">Complete.</param>

        /// <param name="EncodedRootToken">EncodedRootToken.</param>

        /// <param name="EncodedToken">EncodedToken.</param>

        /// <param name="Nonce">Nonce.</param>

        /// <param name="Otp">Otp.</param>

        /// <param name="OtpLength">OtpLength.</param>

        /// <param name="PgpFingerprint">PgpFingerprint.</param>

        /// <param name="Progress">Progress.</param>

        /// <param name="Required">Required.</param>

        /// <param name="Started">Started.</param>


        public RootTokenGenerationUpdateResponse(bool Complete = default(bool), string EncodedRootToken = default(string), string EncodedToken = default(string), string Nonce = default(string), string Otp = default(string), int OtpLength = default(int), string PgpFingerprint = default(string), int Progress = default(int), int Required = default(int), bool Started = default(bool))
        {

            this.Complete = Complete;

            this.EncodedRootToken = EncodedRootToken;

            this.EncodedToken = EncodedToken;

            this.Nonce = Nonce;

            this.Otp = Otp;

            this.OtpLength = OtpLength;

            this.PgpFingerprint = PgpFingerprint;

            this.Progress = Progress;

            this.Required = Required;

            this.Started = Started;

        }

        /// <summary>
        /// Gets or Sets Complete
        /// </summary>
        [DataMember(Name = "complete", EmitDefaultValue = true)]

        public bool Complete { get; set; }


        /// <summary>
        /// Gets or Sets EncodedRootToken
        /// </summary>
        [DataMember(Name = "encoded_root_token", EmitDefaultValue = false)]

        public string EncodedRootToken { get; set; }


        /// <summary>
        /// Gets or Sets EncodedToken
        /// </summary>
        [DataMember(Name = "encoded_token", EmitDefaultValue = false)]

        public string EncodedToken { get; set; }


        /// <summary>
        /// Gets or Sets Nonce
        /// </summary>
        [DataMember(Name = "nonce", EmitDefaultValue = false)]

        public string Nonce { get; set; }


        /// <summary>
        /// Gets or Sets Otp
        /// </summary>
        [DataMember(Name = "otp", EmitDefaultValue = false)]

        public string Otp { get; set; }


        /// <summary>
        /// Gets or Sets OtpLength
        /// </summary>
        [DataMember(Name = "otp_length", EmitDefaultValue = false)]

        public int OtpLength { get; set; }


        /// <summary>
        /// Gets or Sets PgpFingerprint
        /// </summary>
        [DataMember(Name = "pgp_fingerprint", EmitDefaultValue = false)]

        public string PgpFingerprint { get; set; }


        /// <summary>
        /// Gets or Sets Progress
        /// </summary>
        [DataMember(Name = "progress", EmitDefaultValue = false)]

        public int Progress { get; set; }


        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name = "required", EmitDefaultValue = false)]

        public int Required { get; set; }


        /// <summary>
        /// Gets or Sets Started
        /// </summary>
        [DataMember(Name = "started", EmitDefaultValue = true)]

        public bool Started { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RootTokenGenerationUpdateResponse {\n");
            sb.Append("  Complete: ").Append(Complete).Append("\n");
            sb.Append("  EncodedRootToken: ").Append(EncodedRootToken).Append("\n");
            sb.Append("  EncodedToken: ").Append(EncodedToken).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  Otp: ").Append(Otp).Append("\n");
            sb.Append("  OtpLength: ").Append(OtpLength).Append("\n");
            sb.Append("  PgpFingerprint: ").Append(PgpFingerprint).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Started: ").Append(Started).Append("\n");
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
            return this.Equals(input as RootTokenGenerationUpdateResponse);
        }

        /// <summary>
        /// Returns true if RootTokenGenerationUpdateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RootTokenGenerationUpdateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RootTokenGenerationUpdateResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Complete == input.Complete ||

                    this.Complete.Equals(input.Complete)
                ) &&
                (
                    this.EncodedRootToken == input.EncodedRootToken ||
                    (this.EncodedRootToken != null &&
                    this.EncodedRootToken.Equals(input.EncodedRootToken))

                ) &&
                (
                    this.EncodedToken == input.EncodedToken ||
                    (this.EncodedToken != null &&
                    this.EncodedToken.Equals(input.EncodedToken))

                ) &&
                (
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))

                ) &&
                (
                    this.Otp == input.Otp ||
                    (this.Otp != null &&
                    this.Otp.Equals(input.Otp))

                ) &&
                (
                    this.OtpLength == input.OtpLength ||

                    this.OtpLength.Equals(input.OtpLength)
                ) &&
                (
                    this.PgpFingerprint == input.PgpFingerprint ||
                    (this.PgpFingerprint != null &&
                    this.PgpFingerprint.Equals(input.PgpFingerprint))

                ) &&
                (
                    this.Progress == input.Progress ||

                    this.Progress.Equals(input.Progress)
                ) &&
                (
                    this.Required == input.Required ||

                    this.Required.Equals(input.Required)
                ) &&
                (
                    this.Started == input.Started ||

                    this.Started.Equals(input.Started)
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


                hashCode = (hashCode * 59) + this.Complete.GetHashCode();
                if (this.EncodedRootToken != null)
                {
                    hashCode = (hashCode * 59) + this.EncodedRootToken.GetHashCode();
                }

                if (this.EncodedToken != null)
                {
                    hashCode = (hashCode * 59) + this.EncodedToken.GetHashCode();
                }

                if (this.Nonce != null)
                {
                    hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                }

                if (this.Otp != null)
                {
                    hashCode = (hashCode * 59) + this.Otp.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.OtpLength.GetHashCode();
                if (this.PgpFingerprint != null)
                {
                    hashCode = (hashCode * 59) + this.PgpFingerprint.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Progress.GetHashCode();

                hashCode = (hashCode * 59) + this.Required.GetHashCode();

                hashCode = (hashCode * 59) + this.Started.GetHashCode();
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
