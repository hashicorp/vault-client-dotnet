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
    /// PKIReplaceRootRequest
    /// </summary>
    [DataContract(Name = "PKIReplaceRootRequest")]
    public partial class PKIReplaceRootRequest : IEquatable<PKIReplaceRootRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PKIReplaceRootRequest" /> class.
        /// </summary>
        /// <param name="_default">Reference (name or identifier) to the default issuer. (default to &quot;next&quot;).</param>
        public PKIReplaceRootRequest(string _default = "next")
        {
            // use default value if no "_default" provided
            this.Default = _default ?? "next";
        }

        /// <summary>
        /// Reference (name or identifier) to the default issuer.
        /// </summary>
        /// <value>Reference (name or identifier) to the default issuer.</value>
        [DataMember(Name = "default", EmitDefaultValue = false)]
        public string Default { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PKIReplaceRootRequest {\n");
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
            return this.Equals(input as PKIReplaceRootRequest);
        }

        /// <summary>
        /// Returns true if PKIReplaceRootRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PKIReplaceRootRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PKIReplaceRootRequest input)
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
