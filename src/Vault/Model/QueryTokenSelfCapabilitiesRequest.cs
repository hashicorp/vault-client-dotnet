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
    /// QueryTokenSelfCapabilitiesRequest
    /// </summary>
    [DataContract(Name = "QueryTokenSelfCapabilitiesRequest")]
    public partial class QueryTokenSelfCapabilitiesRequest : IEquatable<QueryTokenSelfCapabilitiesRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="QueryTokenSelfCapabilitiesRequest" /> class.
        /// </summary>

        /// <param name="Path">Use &#x27;paths&#x27; instead..</param>

        /// <param name="Paths">Paths on which capabilities are being queried..</param>

        /// <param name="Token">Token for which capabilities are being queried..</param>


        public QueryTokenSelfCapabilitiesRequest(List<string> Path = default(List<string>), List<string> Paths = default(List<string>), string Token = default(string))
        {

            this.Path = Path;

            this.Paths = Paths;

            this.Token = Token;

        }

        /// <summary>
        /// Use &#x27;paths&#x27; instead.
        /// </summary>
        /// <value>Use &#x27;paths&#x27; instead.</value>
        [DataMember(Name = "path", EmitDefaultValue = false)]

        [Obsolete] public List<string> Path { get; set; }


        /// <summary>
        /// Paths on which capabilities are being queried.
        /// </summary>
        /// <value>Paths on which capabilities are being queried.</value>
        [DataMember(Name = "paths", EmitDefaultValue = false)]

        public List<string> Paths { get; set; }


        /// <summary>
        /// Token for which capabilities are being queried.
        /// </summary>
        /// <value>Token for which capabilities are being queried.</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]

        public string Token { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QueryTokenSelfCapabilitiesRequest {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Paths: ").Append(Paths).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(input as QueryTokenSelfCapabilitiesRequest);
        }

        /// <summary>
        /// Returns true if QueryTokenSelfCapabilitiesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryTokenSelfCapabilitiesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryTokenSelfCapabilitiesRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Path == input.Path ||
                    this.Path != null &&
                    input.Path != null &&
                    this.Path.SequenceEqual(input.Path)
                ) &&
                (
                    this.Paths == input.Paths ||
                    this.Paths != null &&
                    input.Paths != null &&
                    this.Paths.SequenceEqual(input.Paths)
                ) &&
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))

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

                if (this.Path != null)
                {
                    hashCode = (hashCode * 59) + this.Path.GetHashCode();
                }

                if (this.Paths != null)
                {
                    hashCode = (hashCode * 59) + this.Paths.GetHashCode();
                }

                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
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
