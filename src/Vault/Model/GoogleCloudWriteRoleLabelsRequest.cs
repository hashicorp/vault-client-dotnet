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
    /// GoogleCloudWriteRoleLabelsRequest
    /// </summary>
    [DataContract(Name = "GoogleCloudWriteRoleLabelsRequest")]
    public partial class GoogleCloudWriteRoleLabelsRequest : IEquatable<GoogleCloudWriteRoleLabelsRequest>, IValidatableObject
    {







        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleCloudWriteRoleLabelsRequest" /> class.
        /// </summary>

        /// <param name="Add">BoundLabels to add (in $key:$value).</param>

        /// <param name="Remove">Label key values to remove.</param>


        public GoogleCloudWriteRoleLabelsRequest(List<string> Add = default(List<string>), List<string> Remove = default(List<string>))
        {

            this.Add = Add;

            this.Remove = Remove;

        }

        /// <summary>
        /// BoundLabels to add (in $key:$value)
        /// </summary>
        /// <value>BoundLabels to add (in $key:$value)</value>
        [DataMember(Name = "add", EmitDefaultValue = false)]


        public List<string> Add { get; set; }


        /// <summary>
        /// Label key values to remove
        /// </summary>
        /// <value>Label key values to remove</value>
        [DataMember(Name = "remove", EmitDefaultValue = false)]


        public List<string> Remove { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoogleCloudWriteRoleLabelsRequest {\n");
            sb.Append("  Add: ").Append(Add).Append("\n");
            sb.Append("  Remove: ").Append(Remove).Append("\n");
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
            return this.Equals(input as GoogleCloudWriteRoleLabelsRequest);
        }

        /// <summary>
        /// Returns true if GoogleCloudWriteRoleLabelsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleCloudWriteRoleLabelsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleCloudWriteRoleLabelsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Add == input.Add ||
                    this.Add != null &&
                    input.Add != null &&
                    this.Add.SequenceEqual(input.Add)
                ) &&
                (
                    this.Remove == input.Remove ||
                    this.Remove != null &&
                    input.Remove != null &&
                    this.Remove.SequenceEqual(input.Remove)
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

                if (this.Add != null)
                {
                    hashCode = (hashCode * 59) + this.Add.GetHashCode();
                }

                if (this.Remove != null)
                {
                    hashCode = (hashCode * 59) + this.Remove.GetHashCode();
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
