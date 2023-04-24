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
    /// PkiIssuersGenerateIntermediateResponse
    /// </summary>
    [DataContract(Name = "PkiIssuersGenerateIntermediateResponse")]
    public partial class PkiIssuersGenerateIntermediateResponse : IEquatable<PkiIssuersGenerateIntermediateResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PkiIssuersGenerateIntermediateResponse" /> class.
        /// </summary>

        /// <param name="Csr">Certificate signing request..</param>

        /// <param name="KeyId">Id of the key..</param>

        /// <param name="PrivateKey">Generated private key..</param>

        /// <param name="PrivateKeyType">Specifies the format used for marshaling the private key..</param>


        public PkiIssuersGenerateIntermediateResponse(string Csr = default(string), string KeyId = default(string), string PrivateKey = default(string), string PrivateKeyType = default(string))
        {

            this.Csr = Csr;

            this.KeyId = KeyId;

            this.PrivateKey = PrivateKey;

            this.PrivateKeyType = PrivateKeyType;

        }

        /// <summary>
        /// Certificate signing request.
        /// </summary>
        /// <value>Certificate signing request.</value>
        [DataMember(Name = "csr", EmitDefaultValue = false)]

        public string Csr { get; set; }


        /// <summary>
        /// Id of the key.
        /// </summary>
        /// <value>Id of the key.</value>
        [DataMember(Name = "key_id", EmitDefaultValue = false)]

        public string KeyId { get; set; }


        /// <summary>
        /// Generated private key.
        /// </summary>
        /// <value>Generated private key.</value>
        [DataMember(Name = "private_key", EmitDefaultValue = false)]

        public string PrivateKey { get; set; }


        /// <summary>
        /// Specifies the format used for marshaling the private key.
        /// </summary>
        /// <value>Specifies the format used for marshaling the private key.</value>
        [DataMember(Name = "private_key_type", EmitDefaultValue = false)]

        public string PrivateKeyType { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiIssuersGenerateIntermediateResponse {\n");
            sb.Append("  Csr: ").Append(Csr).Append("\n");
            sb.Append("  KeyId: ").Append(KeyId).Append("\n");
            sb.Append("  PrivateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  PrivateKeyType: ").Append(PrivateKeyType).Append("\n");
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
            return this.Equals(input as PkiIssuersGenerateIntermediateResponse);
        }

        /// <summary>
        /// Returns true if PkiIssuersGenerateIntermediateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiIssuersGenerateIntermediateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiIssuersGenerateIntermediateResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Csr == input.Csr ||
                    (this.Csr != null &&
                    this.Csr.Equals(input.Csr))

                ) &&
                (
                    this.KeyId == input.KeyId ||
                    (this.KeyId != null &&
                    this.KeyId.Equals(input.KeyId))

                ) &&
                (
                    this.PrivateKey == input.PrivateKey ||
                    (this.PrivateKey != null &&
                    this.PrivateKey.Equals(input.PrivateKey))

                ) &&
                (
                    this.PrivateKeyType == input.PrivateKeyType ||
                    (this.PrivateKeyType != null &&
                    this.PrivateKeyType.Equals(input.PrivateKeyType))

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

                if (this.Csr != null)
                {
                    hashCode = (hashCode * 59) + this.Csr.GetHashCode();
                }

                if (this.KeyId != null)
                {
                    hashCode = (hashCode * 59) + this.KeyId.GetHashCode();
                }

                if (this.PrivateKey != null)
                {
                    hashCode = (hashCode * 59) + this.PrivateKey.GetHashCode();
                }

                if (this.PrivateKeyType != null)
                {
                    hashCode = (hashCode * 59) + this.PrivateKeyType.GetHashCode();
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
