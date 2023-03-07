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
    /// MFAMethodWriteOktaRequest
    /// </summary>
    [DataContract(Name = "MFAMethodWriteOktaRequest")]
    public partial class MFAMethodWriteOktaRequest : IEquatable<MFAMethodWriteOktaRequest>, IValidatableObject
    {









        /// <summary>
        /// Initializes a new instance of the <see cref="MFAMethodWriteOktaRequest" /> class.
        /// </summary>

        /// <param name="ApiToken">Okta API key..</param>

        /// <param name="BaseUrl">The base domain to use for the Okta API. When not specified in the configuration, \&quot;okta.com\&quot; is used..</param>

        /// <param name="MethodId">The unique identifier for this MFA method..</param>

        /// <param name="OrgName">Name of the organization to be used in the Okta API..</param>

        /// <param name="PrimaryEmail">If true, the username will only match the primary email for the account. Defaults to false..</param>

        /// <param name="Production">(DEPRECATED) Use base_url instead..</param>

        /// <param name="UsernameFormat">A template string for mapping Identity names to MFA method names. Values to substitute should be placed in {{}}. For example, \&quot;{{entity.name}}@example.com\&quot;. If blank, the Entity&#x27;s name field will be used as-is..</param>


        public MFAMethodWriteOktaRequest(string ApiToken = default(string), string BaseUrl = default(string), string MethodId = default(string), string OrgName = default(string), bool PrimaryEmail = default(bool), bool Production = default(bool), string UsernameFormat = default(string))
        {

            this.ApiToken = ApiToken;

            this.BaseUrl = BaseUrl;

            this.MethodId = MethodId;

            this.OrgName = OrgName;

            this.PrimaryEmail = PrimaryEmail;

            this.Production = Production;

            this.UsernameFormat = UsernameFormat;

        }

        /// <summary>
        /// Okta API key.
        /// </summary>
        /// <value>Okta API key.</value>
        [DataMember(Name = "api_token", EmitDefaultValue = false)]

        public string ApiToken { get; set; }


        /// <summary>
        /// The base domain to use for the Okta API. When not specified in the configuration, \&quot;okta.com\&quot; is used.
        /// </summary>
        /// <value>The base domain to use for the Okta API. When not specified in the configuration, \&quot;okta.com\&quot; is used.</value>
        [DataMember(Name = "base_url", EmitDefaultValue = false)]

        public string BaseUrl { get; set; }


        /// <summary>
        /// The unique identifier for this MFA method.
        /// </summary>
        /// <value>The unique identifier for this MFA method.</value>
        [DataMember(Name = "method_id", EmitDefaultValue = false)]

        public string MethodId { get; set; }


        /// <summary>
        /// Name of the organization to be used in the Okta API.
        /// </summary>
        /// <value>Name of the organization to be used in the Okta API.</value>
        [DataMember(Name = "org_name", EmitDefaultValue = false)]

        public string OrgName { get; set; }


        /// <summary>
        /// If true, the username will only match the primary email for the account. Defaults to false.
        /// </summary>
        /// <value>If true, the username will only match the primary email for the account. Defaults to false.</value>
        [DataMember(Name = "primary_email", EmitDefaultValue = true)]

        public bool PrimaryEmail { get; set; }


        /// <summary>
        /// (DEPRECATED) Use base_url instead.
        /// </summary>
        /// <value>(DEPRECATED) Use base_url instead.</value>
        [DataMember(Name = "production", EmitDefaultValue = true)]

        public bool Production { get; set; }


        /// <summary>
        /// A template string for mapping Identity names to MFA method names. Values to substitute should be placed in {{}}. For example, \&quot;{{entity.name}}@example.com\&quot;. If blank, the Entity&#x27;s name field will be used as-is.
        /// </summary>
        /// <value>A template string for mapping Identity names to MFA method names. Values to substitute should be placed in {{}}. For example, \&quot;{{entity.name}}@example.com\&quot;. If blank, the Entity&#x27;s name field will be used as-is.</value>
        [DataMember(Name = "username_format", EmitDefaultValue = false)]

        public string UsernameFormat { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MFAMethodWriteOktaRequest {\n");
            sb.Append("  ApiToken: ").Append(ApiToken).Append("\n");
            sb.Append("  BaseUrl: ").Append(BaseUrl).Append("\n");
            sb.Append("  MethodId: ").Append(MethodId).Append("\n");
            sb.Append("  OrgName: ").Append(OrgName).Append("\n");
            sb.Append("  PrimaryEmail: ").Append(PrimaryEmail).Append("\n");
            sb.Append("  Production: ").Append(Production).Append("\n");
            sb.Append("  UsernameFormat: ").Append(UsernameFormat).Append("\n");
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
            return this.Equals(input as MFAMethodWriteOktaRequest);
        }

        /// <summary>
        /// Returns true if MFAMethodWriteOktaRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MFAMethodWriteOktaRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MFAMethodWriteOktaRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.ApiToken == input.ApiToken ||
                    (this.ApiToken != null &&
                    this.ApiToken.Equals(input.ApiToken))

                ) &&
                (
                    this.BaseUrl == input.BaseUrl ||
                    (this.BaseUrl != null &&
                    this.BaseUrl.Equals(input.BaseUrl))

                ) &&
                (
                    this.MethodId == input.MethodId ||
                    (this.MethodId != null &&
                    this.MethodId.Equals(input.MethodId))

                ) &&
                (
                    this.OrgName == input.OrgName ||
                    (this.OrgName != null &&
                    this.OrgName.Equals(input.OrgName))

                ) &&
                (
                    this.PrimaryEmail == input.PrimaryEmail ||

                    this.PrimaryEmail.Equals(input.PrimaryEmail)
                ) &&
                (
                    this.Production == input.Production ||

                    this.Production.Equals(input.Production)
                ) &&
                (
                    this.UsernameFormat == input.UsernameFormat ||
                    (this.UsernameFormat != null &&
                    this.UsernameFormat.Equals(input.UsernameFormat))

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

                if (this.ApiToken != null)
                {
                    hashCode = (hashCode * 59) + this.ApiToken.GetHashCode();
                }

                if (this.BaseUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BaseUrl.GetHashCode();
                }

                if (this.MethodId != null)
                {
                    hashCode = (hashCode * 59) + this.MethodId.GetHashCode();
                }

                if (this.OrgName != null)
                {
                    hashCode = (hashCode * 59) + this.OrgName.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.PrimaryEmail.GetHashCode();

                hashCode = (hashCode * 59) + this.Production.GetHashCode();
                if (this.UsernameFormat != null)
                {
                    hashCode = (hashCode * 59) + this.UsernameFormat.GetHashCode();
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
