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
    /// TokenRevokeAccessorRequest
    /// </summary>
    [DataContract(Name = "TokenRevokeAccessorRequest")]

    public partial class TokenRevokeAccessorRequest : IEquatable<TokenRevokeAccessorRequest>, IValidatableObject
    {





        /// <summary>
        /// Initializes a new instance of the <see cref="TokenRevokeAccessorRequest" /> class.
        /// </summary>

        /// <param name="Accessor">Accessor of the token (request body).</param>


        public TokenRevokeAccessorRequest(string Accessor = default(string))
        {

            this.Accessor = Accessor;

        }

        /// <summary>
        /// Accessor of the token (request body)
        /// </summary>
        /// <value>Accessor of the token (request body)</value>
        [DataMember(Name = "accessor", EmitDefaultValue = false)]


        public string Accessor { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokenRevokeAccessorRequest {\n");
            sb.Append("  Accessor: ").Append(Accessor).Append("\n");
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
            return this.Equals(input as TokenRevokeAccessorRequest);
        }

        /// <summary>
        /// Returns true if TokenRevokeAccessorRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenRevokeAccessorRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenRevokeAccessorRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Accessor == input.Accessor ||
                    (this.Accessor != null &&
                    this.Accessor.Equals(input.Accessor))

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

                if (this.Accessor != null)
                {
                    hashCode = (hashCode * 59) + this.Accessor.GetHashCode();
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
