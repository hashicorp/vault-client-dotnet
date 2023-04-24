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
    /// InternalUiListEnabledVisibleMountsResponse
    /// </summary>
    [DataContract(Name = "InternalUiListEnabledVisibleMountsResponse")]
    public partial class InternalUiListEnabledVisibleMountsResponse : IEquatable<InternalUiListEnabledVisibleMountsResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="InternalUiListEnabledVisibleMountsResponse" /> class.
        /// </summary>

        /// <param name="Auth">auth mounts.</param>

        /// <param name="Secret">secret mounts.</param>


        public InternalUiListEnabledVisibleMountsResponse(Object Auth = default(Object), Object Secret = default(Object))
        {

            this.Auth = Auth;

            this.Secret = Secret;

        }

        /// <summary>
        /// auth mounts
        /// </summary>
        /// <value>auth mounts</value>
        [DataMember(Name = "auth", EmitDefaultValue = false)]

        public Object Auth { get; set; }


        /// <summary>
        /// secret mounts
        /// </summary>
        /// <value>secret mounts</value>
        [DataMember(Name = "secret", EmitDefaultValue = false)]

        public Object Secret { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InternalUiListEnabledVisibleMountsResponse {\n");
            sb.Append("  Auth: ").Append(Auth).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
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
            return this.Equals(input as InternalUiListEnabledVisibleMountsResponse);
        }

        /// <summary>
        /// Returns true if InternalUiListEnabledVisibleMountsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InternalUiListEnabledVisibleMountsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InternalUiListEnabledVisibleMountsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Auth == input.Auth ||
                    (this.Auth != null &&
                    this.Auth.Equals(input.Auth))

                ) &&
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))

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

                if (this.Auth != null)
                {
                    hashCode = (hashCode * 59) + this.Auth.GetHashCode();
                }

                if (this.Secret != null)
                {
                    hashCode = (hashCode * 59) + this.Secret.GetHashCode();
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
