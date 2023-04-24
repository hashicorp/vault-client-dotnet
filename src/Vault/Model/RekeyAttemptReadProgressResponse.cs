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
    /// RekeyAttemptReadProgressResponse
    /// </summary>
    [DataContract(Name = "RekeyAttemptReadProgressResponse")]
    public partial class RekeyAttemptReadProgressResponse : IEquatable<RekeyAttemptReadProgressResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="RekeyAttemptReadProgressResponse" /> class.
        /// </summary>

        /// <param name="Backup">Backup.</param>

        /// <param name="N">N.</param>

        /// <param name="Nounce">Nounce.</param>

        /// <param name="PgpFingerprints">PgpFingerprints.</param>

        /// <param name="Progress">Progress.</param>

        /// <param name="Required">Required.</param>

        /// <param name="Started">Started.</param>

        /// <param name="T">T.</param>

        /// <param name="VerificationNonce">VerificationNonce.</param>

        /// <param name="VerificationRequired">VerificationRequired.</param>


        public RekeyAttemptReadProgressResponse(bool Backup = default(bool), int N = default(int), string Nounce = default(string), List<string> PgpFingerprints = default(List<string>), int Progress = default(int), int Required = default(int), string Started = default(string), int T = default(int), string VerificationNonce = default(string), bool VerificationRequired = default(bool))
        {

            this.Backup = Backup;

            this.N = N;

            this.Nounce = Nounce;

            this.PgpFingerprints = PgpFingerprints;

            this.Progress = Progress;

            this.Required = Required;

            this.Started = Started;

            this.T = T;

            this.VerificationNonce = VerificationNonce;

            this.VerificationRequired = VerificationRequired;

        }

        /// <summary>
        /// Gets or Sets Backup
        /// </summary>
        [DataMember(Name = "backup", EmitDefaultValue = true)]

        public bool Backup { get; set; }


        /// <summary>
        /// Gets or Sets N
        /// </summary>
        [DataMember(Name = "n", EmitDefaultValue = false)]

        public int N { get; set; }


        /// <summary>
        /// Gets or Sets Nounce
        /// </summary>
        [DataMember(Name = "nounce", EmitDefaultValue = false)]

        public string Nounce { get; set; }


        /// <summary>
        /// Gets or Sets PgpFingerprints
        /// </summary>
        [DataMember(Name = "pgp_fingerprints", EmitDefaultValue = false)]

        public List<string> PgpFingerprints { get; set; }


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
        [DataMember(Name = "started", EmitDefaultValue = false)]

        public string Started { get; set; }


        /// <summary>
        /// Gets or Sets T
        /// </summary>
        [DataMember(Name = "t", EmitDefaultValue = false)]

        public int T { get; set; }


        /// <summary>
        /// Gets or Sets VerificationNonce
        /// </summary>
        [DataMember(Name = "verification_nonce", EmitDefaultValue = false)]

        public string VerificationNonce { get; set; }


        /// <summary>
        /// Gets or Sets VerificationRequired
        /// </summary>
        [DataMember(Name = "verification_required", EmitDefaultValue = true)]

        public bool VerificationRequired { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RekeyAttemptReadProgressResponse {\n");
            sb.Append("  Backup: ").Append(Backup).Append("\n");
            sb.Append("  N: ").Append(N).Append("\n");
            sb.Append("  Nounce: ").Append(Nounce).Append("\n");
            sb.Append("  PgpFingerprints: ").Append(PgpFingerprints).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Started: ").Append(Started).Append("\n");
            sb.Append("  T: ").Append(T).Append("\n");
            sb.Append("  VerificationNonce: ").Append(VerificationNonce).Append("\n");
            sb.Append("  VerificationRequired: ").Append(VerificationRequired).Append("\n");
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
            return this.Equals(input as RekeyAttemptReadProgressResponse);
        }

        /// <summary>
        /// Returns true if RekeyAttemptReadProgressResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RekeyAttemptReadProgressResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RekeyAttemptReadProgressResponse input)
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
                    this.N == input.N ||

                    this.N.Equals(input.N)
                ) &&
                (
                    this.Nounce == input.Nounce ||
                    (this.Nounce != null &&
                    this.Nounce.Equals(input.Nounce))

                ) &&
                (
                    this.PgpFingerprints == input.PgpFingerprints ||
                    this.PgpFingerprints != null &&
                    input.PgpFingerprints != null &&
                    this.PgpFingerprints.SequenceEqual(input.PgpFingerprints)
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
                    (this.Started != null &&
                    this.Started.Equals(input.Started))

                ) &&
                (
                    this.T == input.T ||

                    this.T.Equals(input.T)
                ) &&
                (
                    this.VerificationNonce == input.VerificationNonce ||
                    (this.VerificationNonce != null &&
                    this.VerificationNonce.Equals(input.VerificationNonce))

                ) &&
                (
                    this.VerificationRequired == input.VerificationRequired ||

                    this.VerificationRequired.Equals(input.VerificationRequired)
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

                hashCode = (hashCode * 59) + this.N.GetHashCode();
                if (this.Nounce != null)
                {
                    hashCode = (hashCode * 59) + this.Nounce.GetHashCode();
                }

                if (this.PgpFingerprints != null)
                {
                    hashCode = (hashCode * 59) + this.PgpFingerprints.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Progress.GetHashCode();

                hashCode = (hashCode * 59) + this.Required.GetHashCode();
                if (this.Started != null)
                {
                    hashCode = (hashCode * 59) + this.Started.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.T.GetHashCode();
                if (this.VerificationNonce != null)
                {
                    hashCode = (hashCode * 59) + this.VerificationNonce.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.VerificationRequired.GetHashCode();
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
