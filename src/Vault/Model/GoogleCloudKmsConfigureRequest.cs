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
    /// GoogleCloudKmsConfigureRequest
    /// </summary>
    [DataContract(Name = "GoogleCloudKmsConfigureRequest")]
    public partial class GoogleCloudKmsConfigureRequest : IEquatable<GoogleCloudKmsConfigureRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleCloudKmsConfigureRequest" /> class.
        /// </summary>

        /// <param name="Credentials">The credentials to use for authenticating to Google Cloud. Leave this blank to use the Default Application Credentials or instance metadata authentication..</param>

        /// <param name="Scopes">The list of full-URL scopes to request when authenticating. By default, this requests https://www.googleapis.com/auth/cloudkms..</param>


        public GoogleCloudKmsConfigureRequest(string Credentials = default(string), List<string> Scopes = default(List<string>))
        {

            this.Credentials = Credentials;

            this.Scopes = Scopes;

        }

        /// <summary>
        /// The credentials to use for authenticating to Google Cloud. Leave this blank to use the Default Application Credentials or instance metadata authentication.
        /// </summary>
        /// <value>The credentials to use for authenticating to Google Cloud. Leave this blank to use the Default Application Credentials or instance metadata authentication.</value>
        [DataMember(Name = "credentials", EmitDefaultValue = false)]

        public string Credentials { get; set; }


        /// <summary>
        /// The list of full-URL scopes to request when authenticating. By default, this requests https://www.googleapis.com/auth/cloudkms.
        /// </summary>
        /// <value>The list of full-URL scopes to request when authenticating. By default, this requests https://www.googleapis.com/auth/cloudkms.</value>
        [DataMember(Name = "scopes", EmitDefaultValue = false)]

        public List<string> Scopes { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoogleCloudKmsConfigureRequest {\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  Scopes: ").Append(Scopes).Append("\n");
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
            return this.Equals(input as GoogleCloudKmsConfigureRequest);
        }

        /// <summary>
        /// Returns true if GoogleCloudKmsConfigureRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleCloudKmsConfigureRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleCloudKmsConfigureRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))

                ) &&
                (
                    this.Scopes == input.Scopes ||
                    this.Scopes != null &&
                    input.Scopes != null &&
                    this.Scopes.SequenceEqual(input.Scopes)
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

                if (this.Credentials != null)
                {
                    hashCode = (hashCode * 59) + this.Credentials.GetHashCode();
                }

                if (this.Scopes != null)
                {
                    hashCode = (hashCode * 59) + this.Scopes.GetHashCode();
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
