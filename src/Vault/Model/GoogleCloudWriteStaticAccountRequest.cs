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
    /// GoogleCloudWriteStaticAccountRequest
    /// </summary>
    [DataContract(Name = "GoogleCloudWriteStaticAccountRequest")]
    public partial class GoogleCloudWriteStaticAccountRequest : IEquatable<GoogleCloudWriteStaticAccountRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleCloudWriteStaticAccountRequest" /> class.
        /// </summary>
        /// <param name="bindings">Bindings configuration string..</param>
        /// <param name="secretType">Type of secret generated for this account. Cannot be updated. Defaults to \&quot;access_token\&quot; (default to &quot;access_token&quot;).</param>
        /// <param name="serviceAccountEmail">Required. Email of the GCP service account to manage. Cannot be updated..</param>
        /// <param name="tokenScopes">List of OAuth scopes to assign to access tokens generated under this account. Ignored if \&quot;secret_type\&quot; is not \&quot;\&quot;access_token\&quot;\&quot;.</param>
        public GoogleCloudWriteStaticAccountRequest(string bindings = default(string), string secretType = "access_token", string serviceAccountEmail = default(string), List<string> tokenScopes = default(List<string>))
        {
            this.Bindings = bindings;
            // use default value if no "secretType" provided
            this.SecretType = secretType ?? "access_token";
            this.ServiceAccountEmail = serviceAccountEmail;
            this.TokenScopes = tokenScopes;
        }

        /// <summary>
        /// Bindings configuration string.
        /// </summary>
        /// <value>Bindings configuration string.</value>
        [DataMember(Name = "bindings", EmitDefaultValue = false)]
        public string Bindings { get; set; }

        /// <summary>
        /// Type of secret generated for this account. Cannot be updated. Defaults to \&quot;access_token\&quot;
        /// </summary>
        /// <value>Type of secret generated for this account. Cannot be updated. Defaults to \&quot;access_token\&quot;</value>
        [DataMember(Name = "secret_type", EmitDefaultValue = false)]
        public string SecretType { get; set; }

        /// <summary>
        /// Required. Email of the GCP service account to manage. Cannot be updated.
        /// </summary>
        /// <value>Required. Email of the GCP service account to manage. Cannot be updated.</value>
        [DataMember(Name = "service_account_email", EmitDefaultValue = false)]
        public string ServiceAccountEmail { get; set; }

        /// <summary>
        /// List of OAuth scopes to assign to access tokens generated under this account. Ignored if \&quot;secret_type\&quot; is not \&quot;\&quot;access_token\&quot;\&quot;
        /// </summary>
        /// <value>List of OAuth scopes to assign to access tokens generated under this account. Ignored if \&quot;secret_type\&quot; is not \&quot;\&quot;access_token\&quot;\&quot;</value>
        [DataMember(Name = "token_scopes", EmitDefaultValue = false)]
        public List<string> TokenScopes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoogleCloudWriteStaticAccountRequest {\n");
            sb.Append("  Bindings: ").Append(Bindings).Append("\n");
            sb.Append("  SecretType: ").Append(SecretType).Append("\n");
            sb.Append("  ServiceAccountEmail: ").Append(ServiceAccountEmail).Append("\n");
            sb.Append("  TokenScopes: ").Append(TokenScopes).Append("\n");
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
            return this.Equals(input as GoogleCloudWriteStaticAccountRequest);
        }

        /// <summary>
        /// Returns true if GoogleCloudWriteStaticAccountRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleCloudWriteStaticAccountRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleCloudWriteStaticAccountRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Bindings == input.Bindings ||
                    (this.Bindings != null &&
                    this.Bindings.Equals(input.Bindings))
                ) &&
                (
                    this.SecretType == input.SecretType ||
                    (this.SecretType != null &&
                    this.SecretType.Equals(input.SecretType))
                ) &&
                (
                    this.ServiceAccountEmail == input.ServiceAccountEmail ||
                    (this.ServiceAccountEmail != null &&
                    this.ServiceAccountEmail.Equals(input.ServiceAccountEmail))
                ) &&
                (
                    this.TokenScopes == input.TokenScopes ||
                    this.TokenScopes != null &&
                    input.TokenScopes != null &&
                    this.TokenScopes.SequenceEqual(input.TokenScopes)
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
                if (this.Bindings != null)
                {
                    hashCode = (hashCode * 59) + this.Bindings.GetHashCode();
                }
                if (this.SecretType != null)
                {
                    hashCode = (hashCode * 59) + this.SecretType.GetHashCode();
                }
                if (this.ServiceAccountEmail != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceAccountEmail.GetHashCode();
                }
                if (this.TokenScopes != null)
                {
                    hashCode = (hashCode * 59) + this.TokenScopes.GetHashCode();
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
