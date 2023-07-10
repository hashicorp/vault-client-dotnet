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
    /// PkiWriteRolesRoleAcmeOrderOrderIdRequest
    /// </summary>
    [DataContract(Name = "PkiWriteRolesRoleAcmeOrderOrder_idRequest")]
    public partial class PkiWriteRolesRoleAcmeOrderOrderIdRequest : IEquatable<PkiWriteRolesRoleAcmeOrderOrderIdRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PkiWriteRolesRoleAcmeOrderOrderIdRequest" /> class.
        /// </summary>

        /// <param name="Payload">ACME request &#x27;payload&#x27; value.</param>

        /// <param name="Protected">ACME request &#x27;protected&#x27; value.</param>

        /// <param name="Signature">ACME request &#x27;signature&#x27; value.</param>


        public PkiWriteRolesRoleAcmeOrderOrderIdRequest(string Payload = default(string), string Protected = default(string), string Signature = default(string))
        {

            this.Payload = Payload;

            this.Protected = Protected;

            this.Signature = Signature;

        }

        /// <summary>
        /// ACME request &#x27;payload&#x27; value
        /// </summary>
        /// <value>ACME request &#x27;payload&#x27; value</value>
        [DataMember(Name = "payload", EmitDefaultValue = false)]

        public string Payload { get; set; }


        /// <summary>
        /// ACME request &#x27;protected&#x27; value
        /// </summary>
        /// <value>ACME request &#x27;protected&#x27; value</value>
        [DataMember(Name = "protected", EmitDefaultValue = false)]

        public string Protected { get; set; }


        /// <summary>
        /// ACME request &#x27;signature&#x27; value
        /// </summary>
        /// <value>ACME request &#x27;signature&#x27; value</value>
        [DataMember(Name = "signature", EmitDefaultValue = false)]

        public string Signature { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiWriteRolesRoleAcmeOrderOrderIdRequest {\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Protected: ").Append(Protected).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
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
            return this.Equals(input as PkiWriteRolesRoleAcmeOrderOrderIdRequest);
        }

        /// <summary>
        /// Returns true if PkiWriteRolesRoleAcmeOrderOrderIdRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiWriteRolesRoleAcmeOrderOrderIdRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiWriteRolesRoleAcmeOrderOrderIdRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Payload == input.Payload ||
                    (this.Payload != null &&
                    this.Payload.Equals(input.Payload))

                ) &&
                (
                    this.Protected == input.Protected ||
                    (this.Protected != null &&
                    this.Protected.Equals(input.Protected))

                ) &&
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))

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

                if (this.Payload != null)
                {
                    hashCode = (hashCode * 59) + this.Payload.GetHashCode();
                }

                if (this.Protected != null)
                {
                    hashCode = (hashCode * 59) + this.Protected.GetHashCode();
                }

                if (this.Signature != null)
                {
                    hashCode = (hashCode * 59) + this.Signature.GetHashCode();
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
