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
    /// NomadWriteRoleRequest
    /// </summary>
    [DataContract(Name = "NomadWriteRoleRequest")]
    public partial class NomadWriteRoleRequest : IEquatable<NomadWriteRoleRequest>, IValidatableObject
    {









        /// <summary>
        /// Initializes a new instance of the <see cref="NomadWriteRoleRequest" /> class.
        /// </summary>

        /// <param name="Global">Boolean value describing if the token should be global or not. Defaults to false..</param>

        /// <param name="Policies">Comma-separated string or list of policies as previously created in Nomad. Required for &#x27;client&#x27; token..</param>

        /// <param name="Type">Which type of token to create: &#x27;client&#x27; or &#x27;management&#x27;. If a &#x27;management&#x27; token, the \&quot;policies\&quot; parameter is not required. Defaults to &#x27;client&#x27;. (default to &quot;client&quot;).</param>


        public NomadWriteRoleRequest(bool Global = default(bool), List<string> Policies = default(List<string>), string Type = "client")
        {

            this.Global = Global;

            this.Policies = Policies;

            // use default value if no "Type" provided
            this.Type = Type ?? "client";


        }

        /// <summary>
        /// Boolean value describing if the token should be global or not. Defaults to false.
        /// </summary>
        /// <value>Boolean value describing if the token should be global or not. Defaults to false.</value>
        [DataMember(Name = "global", EmitDefaultValue = true)]

        public bool Global { get; set; }


        /// <summary>
        /// Comma-separated string or list of policies as previously created in Nomad. Required for &#x27;client&#x27; token.
        /// </summary>
        /// <value>Comma-separated string or list of policies as previously created in Nomad. Required for &#x27;client&#x27; token.</value>
        [DataMember(Name = "policies", EmitDefaultValue = false)]

        public List<string> Policies { get; set; }


        /// <summary>
        /// Which type of token to create: &#x27;client&#x27; or &#x27;management&#x27;. If a &#x27;management&#x27; token, the \&quot;policies\&quot; parameter is not required. Defaults to &#x27;client&#x27;.
        /// </summary>
        /// <value>Which type of token to create: &#x27;client&#x27; or &#x27;management&#x27;. If a &#x27;management&#x27; token, the \&quot;policies\&quot; parameter is not required. Defaults to &#x27;client&#x27;.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]

        public string Type { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NomadWriteRoleRequest {\n");
            sb.Append("  Global: ").Append(Global).Append("\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as NomadWriteRoleRequest);
        }

        /// <summary>
        /// Returns true if NomadWriteRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of NomadWriteRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NomadWriteRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Global == input.Global ||

                    this.Global.Equals(input.Global)
                ) &&
                (
                    this.Policies == input.Policies ||
                    this.Policies != null &&
                    input.Policies != null &&
                    this.Policies.SequenceEqual(input.Policies)
                ) &&
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))

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


                hashCode = (hashCode * 59) + this.Global.GetHashCode();
                if (this.Policies != null)
                {
                    hashCode = (hashCode * 59) + this.Policies.GetHashCode();
                }

                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
