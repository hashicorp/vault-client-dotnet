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
    /// OIDCWriteScopeRequest
    /// </summary>
    [DataContract(Name = "OIDCWriteScopeRequest")]

    public partial class OIDCWriteScopeRequest : IEquatable<OIDCWriteScopeRequest>, IValidatableObject
    {







        /// <summary>
        /// Initializes a new instance of the <see cref="OIDCWriteScopeRequest" /> class.
        /// </summary>

        /// <param name="Description">The description of the scope.</param>

        /// <param name="Template">The template string to use for the scope. This may be in string-ified JSON or base64 format..</param>


        public OIDCWriteScopeRequest(string Description = default(string), string Template = default(string))
        {

            this.Description = Description;

            this.Template = Template;

        }

        /// <summary>
        /// The description of the scope
        /// </summary>
        /// <value>The description of the scope</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]


        public string Description { get; set; }


        /// <summary>
        /// The template string to use for the scope. This may be in string-ified JSON or base64 format.
        /// </summary>
        /// <value>The template string to use for the scope. This may be in string-ified JSON or base64 format.</value>
        [DataMember(Name = "template", EmitDefaultValue = false)]


        public string Template { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OIDCWriteScopeRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
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
            return this.Equals(input as OIDCWriteScopeRequest);
        }

        /// <summary>
        /// Returns true if OIDCWriteScopeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OIDCWriteScopeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OIDCWriteScopeRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))

                ) &&
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))

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

                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }

                if (this.Template != null)
                {
                    hashCode = (hashCode * 59) + this.Template.GetHashCode();
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
