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
    /// CertificatesLoginRequest
    /// </summary>
    [DataContract(Name = "CertificatesLoginRequest")]
    public partial class CertificatesLoginRequest : IEquatable<CertificatesLoginRequest>, IValidatableObject
    {



        /// <summary>
        /// Initializes a new instance of the <see cref="CertificatesLoginRequest" /> class.
        /// </summary>

        /// <param name="Name">The name of the certificate role to authenticate against..</param>


        public CertificatesLoginRequest(string Name = default(string))
        {

            this.Name = Name;

        }

        /// <summary>
        /// The name of the certificate role to authenticate against.
        /// </summary>
        /// <value>The name of the certificate role to authenticate against.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]

        public string Name { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CertificatesLoginRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as CertificatesLoginRequest);
        }

        /// <summary>
        /// Returns true if CertificatesLoginRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CertificatesLoginRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CertificatesLoginRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))

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

                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
