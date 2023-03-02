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
    /// MFAMethodAdminDestroyTOTPRequest
    /// </summary>
    [DataContract(Name = "MFAMethodAdminDestroyTOTPRequest")]

    public partial class MFAMethodAdminDestroyTOTPRequest : IEquatable<MFAMethodAdminDestroyTOTPRequest>, IValidatableObject
    {






        /// <summary>
        /// Initializes a new instance of the <see cref="MFAMethodAdminDestroyTOTPRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MFAMethodAdminDestroyTOTPRequest() { }


        /// <summary>
        /// Initializes a new instance of the <see cref="MFAMethodAdminDestroyTOTPRequest" /> class.
        /// </summary>

        /// <param name="EntityId">Identifier of the entity from which the MFA method secret needs to be removed. (required).</param>

        /// <param name="MethodId">The unique identifier for this MFA method. (required).</param>


        public MFAMethodAdminDestroyTOTPRequest(string EntityId = default(string), string MethodId = default(string))
        {

            // to ensure "EntityId" is required (not null)
            if (EntityId == null)
            {
                throw new ArgumentNullException("EntityId is a required property for MFAMethodAdminDestroyTOTPRequest and cannot be null");
            }
            this.EntityId = EntityId;


            // to ensure "MethodId" is required (not null)
            if (MethodId == null)
            {
                throw new ArgumentNullException("MethodId is a required property for MFAMethodAdminDestroyTOTPRequest and cannot be null");
            }
            this.MethodId = MethodId;


        }

        /// <summary>
        /// Identifier of the entity from which the MFA method secret needs to be removed.
        /// </summary>
        /// <value>Identifier of the entity from which the MFA method secret needs to be removed.</value>
        [DataMember(Name = "entity_id", IsRequired = true, EmitDefaultValue = false)]


        public string EntityId { get; set; }


        /// <summary>
        /// The unique identifier for this MFA method.
        /// </summary>
        /// <value>The unique identifier for this MFA method.</value>
        [DataMember(Name = "method_id", IsRequired = true, EmitDefaultValue = false)]


        public string MethodId { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MFAMethodAdminDestroyTOTPRequest {\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  MethodId: ").Append(MethodId).Append("\n");
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
            return this.Equals(input as MFAMethodAdminDestroyTOTPRequest);
        }

        /// <summary>
        /// Returns true if MFAMethodAdminDestroyTOTPRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MFAMethodAdminDestroyTOTPRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MFAMethodAdminDestroyTOTPRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))

                ) &&
                (
                    this.MethodId == input.MethodId ||
                    (this.MethodId != null &&
                    this.MethodId.Equals(input.MethodId))

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

                if (this.EntityId != null)
                {
                    hashCode = (hashCode * 59) + this.EntityId.GetHashCode();
                }

                if (this.MethodId != null)
                {
                    hashCode = (hashCode * 59) + this.MethodId.GetHashCode();
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
