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
    /// TransitGenerateCsrForKeyRequest
    /// </summary>
    [DataContract(Name = "TransitGenerateCsrForKeyRequest")]
    public partial class TransitGenerateCsrForKeyRequest : IEquatable<TransitGenerateCsrForKeyRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="TransitGenerateCsrForKeyRequest" /> class.
        /// </summary>

        /// <param name="Csr">PEM encoded CSR template. The information attributes will be used as a basis for the CSR with the key in transit. If not set, an empty CSR is returned..</param>

        /// <param name="_Version">Optional version of key, &#x27;latest&#x27; if not set.</param>


        public TransitGenerateCsrForKeyRequest(string Csr = default(string), int _Version = default(int))
        {

            this.Csr = Csr;

            this._Version = _Version;

        }

        /// <summary>
        /// PEM encoded CSR template. The information attributes will be used as a basis for the CSR with the key in transit. If not set, an empty CSR is returned.
        /// </summary>
        /// <value>PEM encoded CSR template. The information attributes will be used as a basis for the CSR with the key in transit. If not set, an empty CSR is returned.</value>
        [DataMember(Name = "csr", EmitDefaultValue = false)]

        public string Csr { get; set; }


        /// <summary>
        /// Optional version of key, &#x27;latest&#x27; if not set
        /// </summary>
        /// <value>Optional version of key, &#x27;latest&#x27; if not set</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]

        public int _Version { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransitGenerateCsrForKeyRequest {\n");
            sb.Append("  Csr: ").Append(Csr).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
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
            return this.Equals(input as TransitGenerateCsrForKeyRequest);
        }

        /// <summary>
        /// Returns true if TransitGenerateCsrForKeyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransitGenerateCsrForKeyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransitGenerateCsrForKeyRequest input)
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
                    this._Version == input._Version ||

                    this._Version.Equals(input._Version)
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


                hashCode = (hashCode * 59) + this._Version.GetHashCode();
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
