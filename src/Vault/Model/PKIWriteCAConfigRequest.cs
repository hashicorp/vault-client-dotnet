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
    /// PKIWriteCAConfigRequest
    /// </summary>
    [DataContract(Name = "PKIWriteCAConfigRequest")]
    public partial class PKIWriteCAConfigRequest : IEquatable<PKIWriteCAConfigRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PKIWriteCAConfigRequest" /> class.
        /// </summary>
        /// <param name="pemBundle">PEM-format, concatenated unencrypted secret key and certificate..</param>
        public PKIWriteCAConfigRequest(string pemBundle = default(string))
        {
            this.PemBundle = pemBundle;
        }

        /// <summary>
        /// PEM-format, concatenated unencrypted secret key and certificate.
        /// </summary>
        /// <value>PEM-format, concatenated unencrypted secret key and certificate.</value>
        [DataMember(Name = "pem_bundle", EmitDefaultValue = false)]
        public string PemBundle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PKIWriteCAConfigRequest {\n");
            sb.Append("  PemBundle: ").Append(PemBundle).Append("\n");
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
            return this.Equals(input as PKIWriteCAConfigRequest);
        }

        /// <summary>
        /// Returns true if PKIWriteCAConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PKIWriteCAConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PKIWriteCAConfigRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PemBundle == input.PemBundle ||
                    (this.PemBundle != null &&
                    this.PemBundle.Equals(input.PemBundle))
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
                if (this.PemBundle != null)
                {
                    hashCode = (hashCode * 59) + this.PemBundle.GetHashCode();
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
