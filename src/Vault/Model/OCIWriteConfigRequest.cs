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
    /// OCIWriteConfigRequest
    /// </summary>
    [DataContract(Name = "OCIWriteConfigRequest")]

    public partial class OCIWriteConfigRequest : IEquatable<OCIWriteConfigRequest>, IValidatableObject
    {





        /// <summary>
        /// Initializes a new instance of the <see cref="OCIWriteConfigRequest" /> class.
        /// </summary>

        /// <param name="HomeTenancyId">The tenancy id of the account..</param>


        public OCIWriteConfigRequest(string HomeTenancyId = default(string))
        {

            this.HomeTenancyId = HomeTenancyId;

        }

        /// <summary>
        /// The tenancy id of the account.
        /// </summary>
        /// <value>The tenancy id of the account.</value>
        [DataMember(Name = "home_tenancy_id", EmitDefaultValue = false)]


        public string HomeTenancyId { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OCIWriteConfigRequest {\n");
            sb.Append("  HomeTenancyId: ").Append(HomeTenancyId).Append("\n");
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
            return this.Equals(input as OCIWriteConfigRequest);
        }

        /// <summary>
        /// Returns true if OCIWriteConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OCIWriteConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OCIWriteConfigRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.HomeTenancyId == input.HomeTenancyId ||
                    (this.HomeTenancyId != null &&
                    this.HomeTenancyId.Equals(input.HomeTenancyId))

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

                if (this.HomeTenancyId != null)
                {
                    hashCode = (hashCode * 59) + this.HomeTenancyId.GetHashCode();
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
