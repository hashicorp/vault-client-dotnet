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
    /// MFAValidateRequest
    /// </summary>
    [DataContract(Name = "MFAValidateRequest")]
    public partial class MFAValidateRequest : IEquatable<MFAValidateRequest>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="MFAValidateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MFAValidateRequest() { }


        /// <summary>
        /// Initializes a new instance of the <see cref="MFAValidateRequest" /> class.
        /// </summary>

        /// <param name="MfaPayload">A map from MFA method ID to a slice of passcodes or an empty slice if the method does not use passcodes (required).</param>

        /// <param name="MfaRequestId">ID for this MFA request (required).</param>


        public MFAValidateRequest(Object MfaPayload = default(Object), string MfaRequestId = default(string))
        {

            // to ensure "MfaPayload" is required (not null)
            if (MfaPayload == null)
            {
                throw new ArgumentNullException("MfaPayload is a required property for MFAValidateRequest and cannot be null");
            }
            this.MfaPayload = MfaPayload;


            // to ensure "MfaRequestId" is required (not null)
            if (MfaRequestId == null)
            {
                throw new ArgumentNullException("MfaRequestId is a required property for MFAValidateRequest and cannot be null");
            }
            this.MfaRequestId = MfaRequestId;


        }

        /// <summary>
        /// A map from MFA method ID to a slice of passcodes or an empty slice if the method does not use passcodes
        /// </summary>
        /// <value>A map from MFA method ID to a slice of passcodes or an empty slice if the method does not use passcodes</value>
        [DataMember(Name = "mfa_payload", IsRequired = true, EmitDefaultValue = false)]

        public Object MfaPayload { get; set; }


        /// <summary>
        /// ID for this MFA request
        /// </summary>
        /// <value>ID for this MFA request</value>
        [DataMember(Name = "mfa_request_id", IsRequired = true, EmitDefaultValue = false)]

        public string MfaRequestId { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MFAValidateRequest {\n");
            sb.Append("  MfaPayload: ").Append(MfaPayload).Append("\n");
            sb.Append("  MfaRequestId: ").Append(MfaRequestId).Append("\n");
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
            return this.Equals(input as MFAValidateRequest);
        }

        /// <summary>
        /// Returns true if MFAValidateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MFAValidateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MFAValidateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.MfaPayload == input.MfaPayload ||
                    (this.MfaPayload != null &&
                    this.MfaPayload.Equals(input.MfaPayload))

                ) &&
                (
                    this.MfaRequestId == input.MfaRequestId ||
                    (this.MfaRequestId != null &&
                    this.MfaRequestId.Equals(input.MfaRequestId))

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

                if (this.MfaPayload != null)
                {
                    hashCode = (hashCode * 59) + this.MfaPayload.GetHashCode();
                }

                if (this.MfaRequestId != null)
                {
                    hashCode = (hashCode * 59) + this.MfaRequestId.GetHashCode();
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
