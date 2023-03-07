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
    /// GoogleCloudWriteRolesetRequest
    /// </summary>
    [DataContract(Name = "GoogleCloudWriteRolesetRequest")]
    public partial class GoogleCloudWriteRolesetRequest : IEquatable<GoogleCloudWriteRolesetRequest>, IValidatableObject
    {











        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleCloudWriteRolesetRequest" /> class.
        /// </summary>

        /// <param name="Bindings">Bindings configuration string..</param>

        /// <param name="Project">Name of the GCP project that this roleset&#x27;s service account will belong to..</param>

        /// <param name="SecretType">Type of secret generated for this role set. Defaults to &#x27;access_token&#x27; (default to &quot;access_token&quot;).</param>

        /// <param name="TokenScopes">List of OAuth scopes to assign to credentials generated under this role set.</param>


        public GoogleCloudWriteRolesetRequest(string Bindings = default(string), string Project = default(string), string SecretType = "access_token", List<string> TokenScopes = default(List<string>))
        {

            this.Bindings = Bindings;

            this.Project = Project;

            // use default value if no "SecretType" provided
            this.SecretType = SecretType ?? "access_token";


            this.TokenScopes = TokenScopes;

        }

        /// <summary>
        /// Bindings configuration string.
        /// </summary>
        /// <value>Bindings configuration string.</value>
        [DataMember(Name = "bindings", EmitDefaultValue = false)]


        public string Bindings { get; set; }


        /// <summary>
        /// Name of the GCP project that this roleset&#x27;s service account will belong to.
        /// </summary>
        /// <value>Name of the GCP project that this roleset&#x27;s service account will belong to.</value>
        [DataMember(Name = "project", EmitDefaultValue = false)]


        public string Project { get; set; }


        /// <summary>
        /// Type of secret generated for this role set. Defaults to &#x27;access_token&#x27;
        /// </summary>
        /// <value>Type of secret generated for this role set. Defaults to &#x27;access_token&#x27;</value>
        [DataMember(Name = "secret_type", EmitDefaultValue = false)]


        public string SecretType { get; set; }


        /// <summary>
        /// List of OAuth scopes to assign to credentials generated under this role set
        /// </summary>
        /// <value>List of OAuth scopes to assign to credentials generated under this role set</value>
        [DataMember(Name = "token_scopes", EmitDefaultValue = false)]


        public List<string> TokenScopes { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoogleCloudWriteRolesetRequest {\n");
            sb.Append("  Bindings: ").Append(Bindings).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  SecretType: ").Append(SecretType).Append("\n");
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
            return this.Equals(input as GoogleCloudWriteRolesetRequest);
        }

        /// <summary>
        /// Returns true if GoogleCloudWriteRolesetRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleCloudWriteRolesetRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleCloudWriteRolesetRequest input)
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
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))

                ) &&
                (
                    this.SecretType == input.SecretType ||
                    (this.SecretType != null &&
                    this.SecretType.Equals(input.SecretType))

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

                if (this.Project != null)
                {
                    hashCode = (hashCode * 59) + this.Project.GetHashCode();
                }

                if (this.SecretType != null)
                {
                    hashCode = (hashCode * 59) + this.SecretType.GetHashCode();
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
