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
    /// PKIWriteKeysConfigRequest
    /// </summary>
    [DataContract(Name = "PKIWriteKeysConfigRequest")]
    public partial class PKIWriteKeysConfigRequest : IEquatable<PKIWriteKeysConfigRequest>, IValidatableObject
    {



        /// <summary>
        /// Initializes a new instance of the <see cref="PKIWriteKeysConfigRequest" /> class.
        /// </summary>

        /// <param name="Default">Reference (name or identifier) of the default key..</param>


        public PKIWriteKeysConfigRequest(string Default = default(string))
        {

            this.Default = Default;

        }

        /// <summary>
        /// Reference (name or identifier) of the default key.
        /// </summary>
        /// <value>Reference (name or identifier) of the default key.</value>
        [DataMember(Name = "default", EmitDefaultValue = false)]

        public string Default { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PKIWriteKeysConfigRequest {\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
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
            return this.Equals(input as PKIWriteKeysConfigRequest);
        }

        /// <summary>
        /// Returns true if PKIWriteKeysConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PKIWriteKeysConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PKIWriteKeysConfigRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))

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

                if (this.Default != null)
                {
                    hashCode = (hashCode * 59) + this.Default.GetHashCode();
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
