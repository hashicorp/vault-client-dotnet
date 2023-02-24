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
    /// OIDCWriteProviderRequest
    /// </summary>
    [DataContract(Name = "OIDCWriteProviderRequest")]
    public partial class OIDCWriteProviderRequest : IEquatable<OIDCWriteProviderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OIDCWriteProviderRequest" /> class.
        /// </summary>
        /// <param name="allowedClientIds">The client IDs that are permitted to use the provider.</param>
        /// <param name="issuer">Specifies what will be used for the iss claim of ID tokens..</param>
        /// <param name="scopesSupported">The scopes supported for requesting on the provider.</param>
        public OIDCWriteProviderRequest(List<string> allowedClientIds = default(List<string>), string issuer = default(string), List<string> scopesSupported = default(List<string>))
        {
            this.AllowedClientIds = allowedClientIds;
            this.Issuer = issuer;
            this.ScopesSupported = scopesSupported;
        }

        /// <summary>
        /// The client IDs that are permitted to use the provider
        /// </summary>
        /// <value>The client IDs that are permitted to use the provider</value>
        [DataMember(Name = "allowed_client_ids", EmitDefaultValue = false)]
        public List<string> AllowedClientIds { get; set; }

        /// <summary>
        /// Specifies what will be used for the iss claim of ID tokens.
        /// </summary>
        /// <value>Specifies what will be used for the iss claim of ID tokens.</value>
        [DataMember(Name = "issuer", EmitDefaultValue = false)]
        public string Issuer { get; set; }

        /// <summary>
        /// The scopes supported for requesting on the provider
        /// </summary>
        /// <value>The scopes supported for requesting on the provider</value>
        [DataMember(Name = "scopes_supported", EmitDefaultValue = false)]
        public List<string> ScopesSupported { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OIDCWriteProviderRequest {\n");
            sb.Append("  AllowedClientIds: ").Append(AllowedClientIds).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  ScopesSupported: ").Append(ScopesSupported).Append("\n");
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
            return this.Equals(input as OIDCWriteProviderRequest);
        }

        /// <summary>
        /// Returns true if OIDCWriteProviderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OIDCWriteProviderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OIDCWriteProviderRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AllowedClientIds == input.AllowedClientIds ||
                    this.AllowedClientIds != null &&
                    input.AllowedClientIds != null &&
                    this.AllowedClientIds.SequenceEqual(input.AllowedClientIds)
                ) &&
                (
                    this.Issuer == input.Issuer ||
                    (this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer))
                ) &&
                (
                    this.ScopesSupported == input.ScopesSupported ||
                    this.ScopesSupported != null &&
                    input.ScopesSupported != null &&
                    this.ScopesSupported.SequenceEqual(input.ScopesSupported)
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
                if (this.AllowedClientIds != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedClientIds.GetHashCode();
                }
                if (this.Issuer != null)
                {
                    hashCode = (hashCode * 59) + this.Issuer.GetHashCode();
                }
                if (this.ScopesSupported != null)
                {
                    hashCode = (hashCode * 59) + this.ScopesSupported.GetHashCode();
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
