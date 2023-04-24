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
    /// PkiIssuersImportBundleRequest
    /// </summary>
    [DataContract(Name = "PkiIssuersImportBundleRequest")]
    public partial class PkiIssuersImportBundleRequest : IEquatable<PkiIssuersImportBundleRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PkiIssuersImportBundleRequest" /> class.
        /// </summary>

        /// <param name="PemBundle">PEM-format, concatenated unencrypted secret-key (optional) and certificates..</param>


        public PkiIssuersImportBundleRequest(string PemBundle = default(string))
        {

            this.PemBundle = PemBundle;

        }

        /// <summary>
        /// PEM-format, concatenated unencrypted secret-key (optional) and certificates.
        /// </summary>
        /// <value>PEM-format, concatenated unencrypted secret-key (optional) and certificates.</value>
        [DataMember(Name = "pem_bundle", EmitDefaultValue = false)]

        public string PemBundle { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiIssuersImportBundleRequest {\n");
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
            return this.Equals(input as PkiIssuersImportBundleRequest);
        }

        /// <summary>
        /// Returns true if PkiIssuersImportBundleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiIssuersImportBundleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiIssuersImportBundleRequest input)
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
