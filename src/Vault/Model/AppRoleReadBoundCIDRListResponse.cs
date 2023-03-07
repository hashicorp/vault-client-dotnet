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
    /// AppRoleReadBoundCIDRListResponse
    /// </summary>
    [DataContract(Name = "AppRoleReadBoundCIDRListResponse")]

    public partial class AppRoleReadBoundCIDRListResponse : IEquatable<AppRoleReadBoundCIDRListResponse>, IValidatableObject
    {





        /// <summary>
        /// Initializes a new instance of the <see cref="AppRoleReadBoundCIDRListResponse" /> class.
        /// </summary>

        /// <param name="BoundCidrList">Deprecated: Please use \&quot;secret_id_bound_cidrs\&quot; instead. Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can perform the login operation..</param>


        public AppRoleReadBoundCIDRListResponse(List<string> BoundCidrList = default(List<string>))
        {

            this.BoundCidrList = BoundCidrList;

        }

        /// <summary>
        /// Deprecated: Please use \&quot;secret_id_bound_cidrs\&quot; instead. Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can perform the login operation.
        /// </summary>
        /// <value>Deprecated: Please use \&quot;secret_id_bound_cidrs\&quot; instead. Comma separated string or list of CIDR blocks. If set, specifies the blocks of IP addresses which can perform the login operation.</value>
        [DataMember(Name = "bound_cidr_list", EmitDefaultValue = false)]

        [Obsolete]
        public List<string> BoundCidrList { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppRoleReadBoundCIDRListResponse {\n");
            sb.Append("  BoundCidrList: ").Append(BoundCidrList).Append("\n");
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
            return this.Equals(input as AppRoleReadBoundCIDRListResponse);
        }

        /// <summary>
        /// Returns true if AppRoleReadBoundCIDRListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AppRoleReadBoundCIDRListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppRoleReadBoundCIDRListResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.BoundCidrList == input.BoundCidrList ||
                    this.BoundCidrList != null &&
                    input.BoundCidrList != null &&
                    this.BoundCidrList.SequenceEqual(input.BoundCidrList)
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

                if (this.BoundCidrList != null)
                {
                    hashCode = (hashCode * 59) + this.BoundCidrList.GetHashCode();
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
