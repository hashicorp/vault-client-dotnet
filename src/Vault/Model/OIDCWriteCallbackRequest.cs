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
    /// OIDCWriteCallbackRequest
    /// </summary>
    [DataContract(Name = "OIDCWriteCallbackRequest")]
    public partial class OIDCWriteCallbackRequest : IEquatable<OIDCWriteCallbackRequest>, IValidatableObject
    {











        /// <summary>
        /// Initializes a new instance of the <see cref="OIDCWriteCallbackRequest" /> class.
        /// </summary>

        /// <param name="ClientNonce">ClientNonce.</param>

        /// <param name="Code">Code.</param>

        /// <param name="IdToken">IdToken.</param>

        /// <param name="State">State.</param>


        public OIDCWriteCallbackRequest(string ClientNonce = default(string), string Code = default(string), string IdToken = default(string), string State = default(string))
        {

            this.ClientNonce = ClientNonce;

            this.Code = Code;

            this.IdToken = IdToken;

            this.State = State;

        }

        /// <summary>
        /// Gets or Sets ClientNonce
        /// </summary>
        [DataMember(Name = "client_nonce", EmitDefaultValue = false)]

        public string ClientNonce { get; set; }


        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]

        public string Code { get; set; }


        /// <summary>
        /// Gets or Sets IdToken
        /// </summary>
        [DataMember(Name = "id_token", EmitDefaultValue = false)]

        public string IdToken { get; set; }


        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]

        public string State { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OIDCWriteCallbackRequest {\n");
            sb.Append("  ClientNonce: ").Append(ClientNonce).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  IdToken: ").Append(IdToken).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as OIDCWriteCallbackRequest);
        }

        /// <summary>
        /// Returns true if OIDCWriteCallbackRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OIDCWriteCallbackRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OIDCWriteCallbackRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.ClientNonce == input.ClientNonce ||
                    (this.ClientNonce != null &&
                    this.ClientNonce.Equals(input.ClientNonce))

                ) &&
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))

                ) &&
                (
                    this.IdToken == input.IdToken ||
                    (this.IdToken != null &&
                    this.IdToken.Equals(input.IdToken))

                ) &&
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))

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

                if (this.ClientNonce != null)
                {
                    hashCode = (hashCode * 59) + this.ClientNonce.GetHashCode();
                }

                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }

                if (this.IdToken != null)
                {
                    hashCode = (hashCode * 59) + this.IdToken.GetHashCode();
                }

                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
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
