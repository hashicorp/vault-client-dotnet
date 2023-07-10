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
    /// PkiIssuersImportBundleResponse
    /// </summary>
    [DataContract(Name = "PkiIssuersImportBundleResponse")]
    public partial class PkiIssuersImportBundleResponse : IEquatable<PkiIssuersImportBundleResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PkiIssuersImportBundleResponse" /> class.
        /// </summary>

        /// <param name="ExistingIssuers">Existing issuers specified as part of the import bundle of this request.</param>

        /// <param name="ExistingKeys">Existing keys specified as part of the import bundle of this request.</param>

        /// <param name="ImportedIssuers">Net-new issuers imported as a part of this request.</param>

        /// <param name="ImportedKeys">Net-new keys imported as a part of this request.</param>

        /// <param name="Mapping">A mapping of issuer_id to key_id for all issuers included in this request.</param>


        public PkiIssuersImportBundleResponse(List<string> ExistingIssuers = default(List<string>), List<string> ExistingKeys = default(List<string>), List<string> ImportedIssuers = default(List<string>), List<string> ImportedKeys = default(List<string>), Object Mapping = default(Object))
        {

            this.ExistingIssuers = ExistingIssuers;

            this.ExistingKeys = ExistingKeys;

            this.ImportedIssuers = ImportedIssuers;

            this.ImportedKeys = ImportedKeys;

            this.Mapping = Mapping;

        }

        /// <summary>
        /// Existing issuers specified as part of the import bundle of this request
        /// </summary>
        /// <value>Existing issuers specified as part of the import bundle of this request</value>
        [DataMember(Name = "existing_issuers", EmitDefaultValue = false)]

        public List<string> ExistingIssuers { get; set; }


        /// <summary>
        /// Existing keys specified as part of the import bundle of this request
        /// </summary>
        /// <value>Existing keys specified as part of the import bundle of this request</value>
        [DataMember(Name = "existing_keys", EmitDefaultValue = false)]

        public List<string> ExistingKeys { get; set; }


        /// <summary>
        /// Net-new issuers imported as a part of this request
        /// </summary>
        /// <value>Net-new issuers imported as a part of this request</value>
        [DataMember(Name = "imported_issuers", EmitDefaultValue = false)]

        public List<string> ImportedIssuers { get; set; }


        /// <summary>
        /// Net-new keys imported as a part of this request
        /// </summary>
        /// <value>Net-new keys imported as a part of this request</value>
        [DataMember(Name = "imported_keys", EmitDefaultValue = false)]

        public List<string> ImportedKeys { get; set; }


        /// <summary>
        /// A mapping of issuer_id to key_id for all issuers included in this request
        /// </summary>
        /// <value>A mapping of issuer_id to key_id for all issuers included in this request</value>
        [DataMember(Name = "mapping", EmitDefaultValue = false)]

        public Object Mapping { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiIssuersImportBundleResponse {\n");
            sb.Append("  ExistingIssuers: ").Append(ExistingIssuers).Append("\n");
            sb.Append("  ExistingKeys: ").Append(ExistingKeys).Append("\n");
            sb.Append("  ImportedIssuers: ").Append(ImportedIssuers).Append("\n");
            sb.Append("  ImportedKeys: ").Append(ImportedKeys).Append("\n");
            sb.Append("  Mapping: ").Append(Mapping).Append("\n");
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
            return this.Equals(input as PkiIssuersImportBundleResponse);
        }

        /// <summary>
        /// Returns true if PkiIssuersImportBundleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiIssuersImportBundleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiIssuersImportBundleResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.ExistingIssuers == input.ExistingIssuers ||
                    this.ExistingIssuers != null &&
                    input.ExistingIssuers != null &&
                    this.ExistingIssuers.SequenceEqual(input.ExistingIssuers)
                ) &&
                (
                    this.ExistingKeys == input.ExistingKeys ||
                    this.ExistingKeys != null &&
                    input.ExistingKeys != null &&
                    this.ExistingKeys.SequenceEqual(input.ExistingKeys)
                ) &&
                (
                    this.ImportedIssuers == input.ImportedIssuers ||
                    this.ImportedIssuers != null &&
                    input.ImportedIssuers != null &&
                    this.ImportedIssuers.SequenceEqual(input.ImportedIssuers)
                ) &&
                (
                    this.ImportedKeys == input.ImportedKeys ||
                    this.ImportedKeys != null &&
                    input.ImportedKeys != null &&
                    this.ImportedKeys.SequenceEqual(input.ImportedKeys)
                ) &&
                (
                    this.Mapping == input.Mapping ||
                    (this.Mapping != null &&
                    this.Mapping.Equals(input.Mapping))

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

                if (this.ExistingIssuers != null)
                {
                    hashCode = (hashCode * 59) + this.ExistingIssuers.GetHashCode();
                }

                if (this.ExistingKeys != null)
                {
                    hashCode = (hashCode * 59) + this.ExistingKeys.GetHashCode();
                }

                if (this.ImportedIssuers != null)
                {
                    hashCode = (hashCode * 59) + this.ImportedIssuers.GetHashCode();
                }

                if (this.ImportedKeys != null)
                {
                    hashCode = (hashCode * 59) + this.ImportedKeys.GetHashCode();
                }

                if (this.Mapping != null)
                {
                    hashCode = (hashCode * 59) + this.Mapping.GetHashCode();
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
