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
    /// AliCloudLoginRequest
    /// </summary>
    [DataContract(Name = "AliCloudLoginRequest")]
    public partial class AliCloudLoginRequest : IEquatable<AliCloudLoginRequest>, IValidatableObject
    {








        /// <summary>
        /// Initializes a new instance of the <see cref="AliCloudLoginRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AliCloudLoginRequest() { }


        /// <summary>
        /// Initializes a new instance of the <see cref="AliCloudLoginRequest" /> class.
        /// </summary>

        /// <param name="IdentityRequestHeaders">The request headers. This must include the headers over which AliCloud has included a signature..</param>

        /// <param name="IdentityRequestUrl">Base64-encoded full URL against which to make the AliCloud request..</param>

        /// <param name="Role">Name of the role against which the login is being attempted. If &#x27;role&#x27; is not specified, then the login endpoint looks for a role name in the ARN returned by the GetCallerIdentity request. If a matching role is not found, login fails. (required).</param>


        public AliCloudLoginRequest(string IdentityRequestHeaders = default(string), string IdentityRequestUrl = default(string), string Role = default(string))
        {

            // to ensure "Role" is required (not null)
            if (Role == null)
            {
                throw new ArgumentNullException("Role is a required property for AliCloudLoginRequest and cannot be null");
            }
            this.Role = Role;


            this.IdentityRequestHeaders = IdentityRequestHeaders;

            this.IdentityRequestUrl = IdentityRequestUrl;

        }

        /// <summary>
        /// The request headers. This must include the headers over which AliCloud has included a signature.
        /// </summary>
        /// <value>The request headers. This must include the headers over which AliCloud has included a signature.</value>
        [DataMember(Name = "identity_request_headers", EmitDefaultValue = false)]


        public string IdentityRequestHeaders { get; set; }


        /// <summary>
        /// Base64-encoded full URL against which to make the AliCloud request.
        /// </summary>
        /// <value>Base64-encoded full URL against which to make the AliCloud request.</value>
        [DataMember(Name = "identity_request_url", EmitDefaultValue = false)]


        public string IdentityRequestUrl { get; set; }


        /// <summary>
        /// Name of the role against which the login is being attempted. If &#x27;role&#x27; is not specified, then the login endpoint looks for a role name in the ARN returned by the GetCallerIdentity request. If a matching role is not found, login fails.
        /// </summary>
        /// <value>Name of the role against which the login is being attempted. If &#x27;role&#x27; is not specified, then the login endpoint looks for a role name in the ARN returned by the GetCallerIdentity request. If a matching role is not found, login fails.</value>
        [DataMember(Name = "role", IsRequired = true, EmitDefaultValue = false)]


        public string Role { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AliCloudLoginRequest {\n");
            sb.Append("  IdentityRequestHeaders: ").Append(IdentityRequestHeaders).Append("\n");
            sb.Append("  IdentityRequestUrl: ").Append(IdentityRequestUrl).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
            return this.Equals(input as AliCloudLoginRequest);
        }

        /// <summary>
        /// Returns true if AliCloudLoginRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AliCloudLoginRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AliCloudLoginRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.IdentityRequestHeaders == input.IdentityRequestHeaders ||
                    (this.IdentityRequestHeaders != null &&
                    this.IdentityRequestHeaders.Equals(input.IdentityRequestHeaders))

                ) &&
                (
                    this.IdentityRequestUrl == input.IdentityRequestUrl ||
                    (this.IdentityRequestUrl != null &&
                    this.IdentityRequestUrl.Equals(input.IdentityRequestUrl))

                ) &&
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))

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

                if (this.IdentityRequestHeaders != null)
                {
                    hashCode = (hashCode * 59) + this.IdentityRequestHeaders.GetHashCode();
                }

                if (this.IdentityRequestUrl != null)
                {
                    hashCode = (hashCode * 59) + this.IdentityRequestUrl.GetHashCode();
                }

                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
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
