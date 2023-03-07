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
    /// LDAPCheckInLibraryRequest
    /// </summary>
    [DataContract(Name = "LDAPCheckInLibraryRequest")]

    public partial class LDAPCheckInLibraryRequest : IEquatable<LDAPCheckInLibraryRequest>, IValidatableObject
    {





        /// <summary>
        /// Initializes a new instance of the <see cref="LDAPCheckInLibraryRequest" /> class.
        /// </summary>

        /// <param name="ServiceAccountNames">The username/logon name for the service accounts to check in..</param>


        public LDAPCheckInLibraryRequest(List<string> ServiceAccountNames = default(List<string>))
        {

            this.ServiceAccountNames = ServiceAccountNames;

        }

        /// <summary>
        /// The username/logon name for the service accounts to check in.
        /// </summary>
        /// <value>The username/logon name for the service accounts to check in.</value>
        [DataMember(Name = "service_account_names", EmitDefaultValue = false)]


        public List<string> ServiceAccountNames { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LDAPCheckInLibraryRequest {\n");
            sb.Append("  ServiceAccountNames: ").Append(ServiceAccountNames).Append("\n");
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
            return this.Equals(input as LDAPCheckInLibraryRequest);
        }

        /// <summary>
        /// Returns true if LDAPCheckInLibraryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LDAPCheckInLibraryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LDAPCheckInLibraryRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.ServiceAccountNames == input.ServiceAccountNames ||
                    this.ServiceAccountNames != null &&
                    input.ServiceAccountNames != null &&
                    this.ServiceAccountNames.SequenceEqual(input.ServiceAccountNames)
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

                if (this.ServiceAccountNames != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceAccountNames.GetHashCode();
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
