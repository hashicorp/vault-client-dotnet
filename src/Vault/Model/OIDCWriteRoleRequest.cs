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
    /// OIDCWriteRoleRequest
    /// </summary>
    [DataContract(Name = "OIDCWriteRoleRequest")]

    public partial class OIDCWriteRoleRequest : IEquatable<OIDCWriteRoleRequest>, IValidatableObject
    {










        /// <summary>
        /// Initializes a new instance of the <see cref="OIDCWriteRoleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OIDCWriteRoleRequest() { }


        /// <summary>
        /// Initializes a new instance of the <see cref="OIDCWriteRoleRequest" /> class.
        /// </summary>

        /// <param name="ClientId">Optional client_id.</param>

        /// <param name="Key">The OIDC key to use for generating tokens. The specified key must already exist. (required).</param>

        /// <param name="Template">The template string to use for generating tokens. This may be in string-ified JSON or base64 format..</param>

        /// <param name="Ttl">TTL of the tokens generated against the role..</param>


        public OIDCWriteRoleRequest(string ClientId = default(string), string Key = default(string), string Template = default(string), int Ttl = default(int))
        {

            // to ensure "Key" is required (not null)
            if (Key == null)
            {
                throw new ArgumentNullException("Key is a required property for OIDCWriteRoleRequest and cannot be null");
            }
            this.Key = Key;


            this.ClientId = ClientId;

            this.Template = Template;

            this.Ttl = Ttl;

        }

        /// <summary>
        /// Optional client_id
        /// </summary>
        /// <value>Optional client_id</value>
        [DataMember(Name = "client_id", EmitDefaultValue = false)]


        public string ClientId { get; set; }


        /// <summary>
        /// The OIDC key to use for generating tokens. The specified key must already exist.
        /// </summary>
        /// <value>The OIDC key to use for generating tokens. The specified key must already exist.</value>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = false)]


        public string Key { get; set; }


        /// <summary>
        /// The template string to use for generating tokens. This may be in string-ified JSON or base64 format.
        /// </summary>
        /// <value>The template string to use for generating tokens. This may be in string-ified JSON or base64 format.</value>
        [DataMember(Name = "template", EmitDefaultValue = false)]


        public string Template { get; set; }


        /// <summary>
        /// TTL of the tokens generated against the role.
        /// </summary>
        /// <value>TTL of the tokens generated against the role.</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]


        public int Ttl { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OIDCWriteRoleRequest {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
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
            return this.Equals(input as OIDCWriteRoleRequest);
        }

        /// <summary>
        /// Returns true if OIDCWriteRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OIDCWriteRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OIDCWriteRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))

                ) &&
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))

                ) &&
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))

                ) &&
                (
                    this.Ttl == input.Ttl ||

                    this.Ttl.Equals(input.Ttl)
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

                if (this.ClientId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientId.GetHashCode();
                }

                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }

                if (this.Template != null)
                {
                    hashCode = (hashCode * 59) + this.Template.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
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
