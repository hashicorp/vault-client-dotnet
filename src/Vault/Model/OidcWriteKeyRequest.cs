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
    /// OidcWriteKeyRequest
    /// </summary>
    [DataContract(Name = "OidcWriteKeyRequest")]
    public partial class OidcWriteKeyRequest : IEquatable<OidcWriteKeyRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="OidcWriteKeyRequest" /> class.
        /// </summary>

        /// <param name="Algorithm">Signing algorithm to use. This will default to RS256. (default to &quot;RS256&quot;).</param>

        /// <param name="AllowedClientIds">Comma separated string or array of role client ids allowed to use this key for signing. If empty no roles are allowed. If \&quot;*\&quot; all roles are allowed..</param>

        /// <param name="RotationPeriod">How often to generate a new keypair. (default to &quot;24h&quot;).</param>

        /// <param name="VerificationTtl">Controls how long the public portion of a key will be available for verification after being rotated. (default to &quot;24h&quot;).</param>


        public OidcWriteKeyRequest(string Algorithm = "RS256", List<string> AllowedClientIds = default(List<string>), string RotationPeriod = "24h", string VerificationTtl = "24h")
        {

            // use default value if no "Algorithm" provided
            this.Algorithm = Algorithm ?? "RS256";


            this.AllowedClientIds = AllowedClientIds;

            // use default value if no "RotationPeriod" provided
            this.RotationPeriod = RotationPeriod ?? "24h";


            // use default value if no "VerificationTtl" provided
            this.VerificationTtl = VerificationTtl ?? "24h";


        }

        /// <summary>
        /// Signing algorithm to use. This will default to RS256.
        /// </summary>
        /// <value>Signing algorithm to use. This will default to RS256.</value>
        [DataMember(Name = "algorithm", EmitDefaultValue = false)]

        public string Algorithm { get; set; }


        /// <summary>
        /// Comma separated string or array of role client ids allowed to use this key for signing. If empty no roles are allowed. If \&quot;*\&quot; all roles are allowed.
        /// </summary>
        /// <value>Comma separated string or array of role client ids allowed to use this key for signing. If empty no roles are allowed. If \&quot;*\&quot; all roles are allowed.</value>
        [DataMember(Name = "allowed_client_ids", EmitDefaultValue = false)]

        public List<string> AllowedClientIds { get; set; }


        /// <summary>
        /// How often to generate a new keypair.
        /// </summary>
        /// <value>How often to generate a new keypair.</value>
        [DataMember(Name = "rotation_period", EmitDefaultValue = false)]

        public string RotationPeriod { get; set; }


        /// <summary>
        /// Controls how long the public portion of a key will be available for verification after being rotated.
        /// </summary>
        /// <value>Controls how long the public portion of a key will be available for verification after being rotated.</value>
        [DataMember(Name = "verification_ttl", EmitDefaultValue = false)]

        public string VerificationTtl { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OidcWriteKeyRequest {\n");
            sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("  AllowedClientIds: ").Append(AllowedClientIds).Append("\n");
            sb.Append("  RotationPeriod: ").Append(RotationPeriod).Append("\n");
            sb.Append("  VerificationTtl: ").Append(VerificationTtl).Append("\n");
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
            return this.Equals(input as OidcWriteKeyRequest);
        }

        /// <summary>
        /// Returns true if OidcWriteKeyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OidcWriteKeyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OidcWriteKeyRequest input)
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
                    this.AllowedClientIds == input.AllowedClientIds ||
                    this.AllowedClientIds != null &&
                    input.AllowedClientIds != null &&
                    this.AllowedClientIds.SequenceEqual(input.AllowedClientIds)
                ) &&
                (
                    this.RotationPeriod == input.RotationPeriod ||
                    (this.RotationPeriod != null &&
                    this.RotationPeriod.Equals(input.RotationPeriod))

                ) &&
                (
                    this.VerificationTtl == input.VerificationTtl ||
                    (this.VerificationTtl != null &&
                    this.VerificationTtl.Equals(input.VerificationTtl))

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

                if (this.AllowedClientIds != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedClientIds.GetHashCode();
                }

                if (this.RotationPeriod != null)
                {
                    hashCode = (hashCode * 59) + this.RotationPeriod.GetHashCode();
                }

                if (this.VerificationTtl != null)
                {
                    hashCode = (hashCode * 59) + this.VerificationTtl.GetHashCode();
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
