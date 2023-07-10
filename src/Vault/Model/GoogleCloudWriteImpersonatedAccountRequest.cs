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
    /// GoogleCloudWriteImpersonatedAccountRequest
    /// </summary>
    [DataContract(Name = "GoogleCloudWriteImpersonatedAccountRequest")]
    public partial class GoogleCloudWriteImpersonatedAccountRequest : IEquatable<GoogleCloudWriteImpersonatedAccountRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleCloudWriteImpersonatedAccountRequest" /> class.
        /// </summary>

        /// <param name="ServiceAccountEmail">Required. Email of the GCP service account to manage. Cannot be updated..</param>

        /// <param name="TokenScopes">List of OAuth scopes to assign to access tokens generated under this account..</param>

        /// <param name="Ttl">Lifetime of the token for the impersonated account..</param>


        public GoogleCloudWriteImpersonatedAccountRequest(string ServiceAccountEmail = default(string), List<string> TokenScopes = default(List<string>), string Ttl = default(string))
        {

            this.ServiceAccountEmail = ServiceAccountEmail;

            this.TokenScopes = TokenScopes;

            this.Ttl = Ttl;

        }

        /// <summary>
        /// Required. Email of the GCP service account to manage. Cannot be updated.
        /// </summary>
        /// <value>Required. Email of the GCP service account to manage. Cannot be updated.</value>
        [DataMember(Name = "service_account_email", EmitDefaultValue = false)]

        public string ServiceAccountEmail { get; set; }


        /// <summary>
        /// List of OAuth scopes to assign to access tokens generated under this account.
        /// </summary>
        /// <value>List of OAuth scopes to assign to access tokens generated under this account.</value>
        [DataMember(Name = "token_scopes", EmitDefaultValue = false)]

        public List<string> TokenScopes { get; set; }


        /// <summary>
        /// Lifetime of the token for the impersonated account.
        /// </summary>
        /// <value>Lifetime of the token for the impersonated account.</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]

        public string Ttl { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoogleCloudWriteImpersonatedAccountRequest {\n");
            sb.Append("  ServiceAccountEmail: ").Append(ServiceAccountEmail).Append("\n");
            sb.Append("  TokenScopes: ").Append(TokenScopes).Append("\n");
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
            return this.Equals(input as GoogleCloudWriteImpersonatedAccountRequest);
        }

        /// <summary>
        /// Returns true if GoogleCloudWriteImpersonatedAccountRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleCloudWriteImpersonatedAccountRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleCloudWriteImpersonatedAccountRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
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
                ) &&
                (
                    this.Ttl == input.Ttl ||
                    (this.Ttl != null &&
                    this.Ttl.Equals(input.Ttl))

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

                if (this.ServiceAccountEmail != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceAccountEmail.GetHashCode();
                }

                if (this.TokenScopes != null)
                {
                    hashCode = (hashCode * 59) + this.TokenScopes.GetHashCode();
                }

                if (this.Ttl != null)
                {
                    hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
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
