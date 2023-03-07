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
    /// TransitWriteConfigKeysRequest
    /// </summary>
    [DataContract(Name = "TransitWriteConfigKeysRequest")]
    public partial class TransitWriteConfigKeysRequest : IEquatable<TransitWriteConfigKeysRequest>, IValidatableObject
    {





        /// <summary>
        /// Initializes a new instance of the <see cref="TransitWriteConfigKeysRequest" /> class.
        /// </summary>

        /// <param name="DisableUpsert">Whether to allow automatic upserting (creation) of keys on the encrypt endpoint..</param>


        public TransitWriteConfigKeysRequest(bool DisableUpsert = default(bool))
        {

            this.DisableUpsert = DisableUpsert;

        }

        /// <summary>
        /// Whether to allow automatic upserting (creation) of keys on the encrypt endpoint.
        /// </summary>
        /// <value>Whether to allow automatic upserting (creation) of keys on the encrypt endpoint.</value>
        [DataMember(Name = "disable_upsert", EmitDefaultValue = true)]

        public bool DisableUpsert { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransitWriteConfigKeysRequest {\n");
            sb.Append("  DisableUpsert: ").Append(DisableUpsert).Append("\n");
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
            return this.Equals(input as TransitWriteConfigKeysRequest);
        }

        /// <summary>
        /// Returns true if TransitWriteConfigKeysRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransitWriteConfigKeysRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransitWriteConfigKeysRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.DisableUpsert == input.DisableUpsert ||

                    this.DisableUpsert.Equals(input.DisableUpsert)
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


                hashCode = (hashCode * 59) + this.DisableUpsert.GetHashCode();
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
