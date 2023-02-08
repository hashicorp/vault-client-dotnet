// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

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
    /// TerraformWriteConfigRequest
    /// </summary>
    [DataContract(Name = "TerraformWriteConfigRequest")]
    public partial class TerraformWriteConfigRequest : IEquatable<TerraformWriteConfigRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TerraformWriteConfigRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TerraformWriteConfigRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TerraformWriteConfigRequest" /> class.
        /// </summary>
        /// <param name="address">The address to access Terraform Cloud or Enterprise. Default is \&quot;https://app.terraform.io\&quot;. (default to &quot;https://app.terraform.io&quot;).</param>
        /// <param name="basePath">The base path for the Terraform Cloud or Enterprise API. Default is \&quot;/api/v2/\&quot;. (default to &quot;/api/v2/&quot;).</param>
        /// <param name="token">The token to access Terraform Cloud (required).</param>
        public TerraformWriteConfigRequest(string address = "https://app.terraform.io", string basePath = "/api/v2/", string token = default(string))
        {
            // to ensure "token" is required (not null)
            if (token == null) {
                throw new ArgumentNullException("token is a required property for TerraformWriteConfigRequest and cannot be null");
            }
            this.Token = token;
            // use default value if no "address" provided
            this.Address = address ?? "https://app.terraform.io";
            // use default value if no "basePath" provided
            this.BasePath = basePath ?? "/api/v2/";
        }

        /// <summary>
        /// The address to access Terraform Cloud or Enterprise. Default is \&quot;https://app.terraform.io\&quot;.
        /// </summary>
        /// <value>The address to access Terraform Cloud or Enterprise. Default is \&quot;https://app.terraform.io\&quot;.</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// The base path for the Terraform Cloud or Enterprise API. Default is \&quot;/api/v2/\&quot;.
        /// </summary>
        /// <value>The base path for the Terraform Cloud or Enterprise API. Default is \&quot;/api/v2/\&quot;.</value>
        [DataMember(Name = "base_path", EmitDefaultValue = false)]
        public string BasePath { get; set; }

        /// <summary>
        /// The token to access Terraform Cloud
        /// </summary>
        /// <value>The token to access Terraform Cloud</value>
        [DataMember(Name = "token", IsRequired = true, EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TerraformWriteConfigRequest {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  BasePath: ").Append(BasePath).Append("\n");
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
            return this.Equals(input as TerraformWriteConfigRequest);
        }

        /// <summary>
        /// Returns true if TerraformWriteConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TerraformWriteConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TerraformWriteConfigRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.BasePath == input.BasePath ||
                    (this.BasePath != null &&
                    this.BasePath.Equals(input.BasePath))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.BasePath != null)
                {
                    hashCode = (hashCode * 59) + this.BasePath.GetHashCode();
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
