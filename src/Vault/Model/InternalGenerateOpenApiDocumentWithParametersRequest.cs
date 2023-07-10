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
    /// InternalGenerateOpenApiDocumentWithParametersRequest
    /// </summary>
    [DataContract(Name = "InternalGenerateOpenApiDocumentWithParametersRequest")]
    public partial class InternalGenerateOpenApiDocumentWithParametersRequest : IEquatable<InternalGenerateOpenApiDocumentWithParametersRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="InternalGenerateOpenApiDocumentWithParametersRequest" /> class.
        /// </summary>

        /// <param name="Context">Context string appended to every operationId.</param>


        public InternalGenerateOpenApiDocumentWithParametersRequest(string Context = default(string))
        {

            this.Context = Context;

        }

        /// <summary>
        /// Context string appended to every operationId
        /// </summary>
        /// <value>Context string appended to every operationId</value>
        [DataMember(Name = "context", EmitDefaultValue = false)]

        public string Context { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InternalGenerateOpenApiDocumentWithParametersRequest {\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
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
            return this.Equals(input as InternalGenerateOpenApiDocumentWithParametersRequest);
        }

        /// <summary>
        /// Returns true if InternalGenerateOpenApiDocumentWithParametersRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of InternalGenerateOpenApiDocumentWithParametersRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InternalGenerateOpenApiDocumentWithParametersRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))

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

                if (this.Context != null)
                {
                    hashCode = (hashCode * 59) + this.Context.GetHashCode();
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
