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
    /// AzureConfigureRequest
    /// </summary>
    [DataContract(Name = "AzureConfigureRequest")]
    public partial class AzureConfigureRequest : IEquatable<AzureConfigureRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="AzureConfigureRequest" /> class.
        /// </summary>

        /// <param name="ClientId">The OAuth2 client id to connect to Azure. This value can also be provided with the AZURE_CLIENT_ID environment variable..</param>

        /// <param name="ClientSecret">The OAuth2 client secret to connect to Azure. This value can also be provided with the AZURE_CLIENT_SECRET environment variable..</param>

        /// <param name="Environment">The Azure environment name. If not provided, AzurePublicCloud is used. This value can also be provided with the AZURE_ENVIRONMENT environment variable..</param>

        /// <param name="PasswordPolicy">Name of the password policy to use to generate passwords for dynamic credentials..</param>

        /// <param name="RootPasswordTtl">The TTL of the root password in Azure. This can be either a number of seconds or a time formatted duration (ex: 24h, 48ds) (default to &quot;15768000000000000&quot;).</param>

        /// <param name="SubscriptionId">The subscription id for the Azure Active Directory. This value can also be provided with the AZURE_SUBSCRIPTION_ID environment variable..</param>

        /// <param name="TenantId">The tenant id for the Azure Active Directory. This value can also be provided with the AZURE_TENANT_ID environment variable..</param>


        public AzureConfigureRequest(string ClientId = default(string), string ClientSecret = default(string), string Environment = default(string), string PasswordPolicy = default(string), string RootPasswordTtl = "15768000000000000", string SubscriptionId = default(string), string TenantId = default(string))
        {

            this.ClientId = ClientId;

            this.ClientSecret = ClientSecret;

            this.Environment = Environment;

            this.PasswordPolicy = PasswordPolicy;

            // use default value if no "RootPasswordTtl" provided
            this.RootPasswordTtl = RootPasswordTtl ?? "15768000000000000";


            this.SubscriptionId = SubscriptionId;

            this.TenantId = TenantId;

        }

        /// <summary>
        /// The OAuth2 client id to connect to Azure. This value can also be provided with the AZURE_CLIENT_ID environment variable.
        /// </summary>
        /// <value>The OAuth2 client id to connect to Azure. This value can also be provided with the AZURE_CLIENT_ID environment variable.</value>
        [DataMember(Name = "client_id", EmitDefaultValue = false)]

        public string ClientId { get; set; }


        /// <summary>
        /// The OAuth2 client secret to connect to Azure. This value can also be provided with the AZURE_CLIENT_SECRET environment variable.
        /// </summary>
        /// <value>The OAuth2 client secret to connect to Azure. This value can also be provided with the AZURE_CLIENT_SECRET environment variable.</value>
        [DataMember(Name = "client_secret", EmitDefaultValue = false)]

        public string ClientSecret { get; set; }


        /// <summary>
        /// The Azure environment name. If not provided, AzurePublicCloud is used. This value can also be provided with the AZURE_ENVIRONMENT environment variable.
        /// </summary>
        /// <value>The Azure environment name. If not provided, AzurePublicCloud is used. This value can also be provided with the AZURE_ENVIRONMENT environment variable.</value>
        [DataMember(Name = "environment", EmitDefaultValue = false)]

        public string Environment { get; set; }


        /// <summary>
        /// Name of the password policy to use to generate passwords for dynamic credentials.
        /// </summary>
        /// <value>Name of the password policy to use to generate passwords for dynamic credentials.</value>
        [DataMember(Name = "password_policy", EmitDefaultValue = false)]

        public string PasswordPolicy { get; set; }


        /// <summary>
        /// The TTL of the root password in Azure. This can be either a number of seconds or a time formatted duration (ex: 24h, 48ds)
        /// </summary>
        /// <value>The TTL of the root password in Azure. This can be either a number of seconds or a time formatted duration (ex: 24h, 48ds)</value>
        [DataMember(Name = "root_password_ttl", EmitDefaultValue = false)]

        public string RootPasswordTtl { get; set; }


        /// <summary>
        /// The subscription id for the Azure Active Directory. This value can also be provided with the AZURE_SUBSCRIPTION_ID environment variable.
        /// </summary>
        /// <value>The subscription id for the Azure Active Directory. This value can also be provided with the AZURE_SUBSCRIPTION_ID environment variable.</value>
        [DataMember(Name = "subscription_id", EmitDefaultValue = false)]

        public string SubscriptionId { get; set; }


        /// <summary>
        /// The tenant id for the Azure Active Directory. This value can also be provided with the AZURE_TENANT_ID environment variable.
        /// </summary>
        /// <value>The tenant id for the Azure Active Directory. This value can also be provided with the AZURE_TENANT_ID environment variable.</value>
        [DataMember(Name = "tenant_id", EmitDefaultValue = false)]

        public string TenantId { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AzureConfigureRequest {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  PasswordPolicy: ").Append(PasswordPolicy).Append("\n");
            sb.Append("  RootPasswordTtl: ").Append(RootPasswordTtl).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
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
            return this.Equals(input as AzureConfigureRequest);
        }

        /// <summary>
        /// Returns true if AzureConfigureRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AzureConfigureRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AzureConfigureRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))

                ) &&
                (
                    this.ClientSecret == input.ClientSecret ||
                    (this.ClientSecret != null &&
                    this.ClientSecret.Equals(input.ClientSecret))

                ) &&
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))

                ) &&
                (
                    this.PasswordPolicy == input.PasswordPolicy ||
                    (this.PasswordPolicy != null &&
                    this.PasswordPolicy.Equals(input.PasswordPolicy))

                ) &&
                (
                    this.RootPasswordTtl == input.RootPasswordTtl ||
                    (this.RootPasswordTtl != null &&
                    this.RootPasswordTtl.Equals(input.RootPasswordTtl))

                ) &&
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))

                ) &&
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))

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

                if (this.ClientId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientId.GetHashCode();
                }

                if (this.ClientSecret != null)
                {
                    hashCode = (hashCode * 59) + this.ClientSecret.GetHashCode();
                }

                if (this.Environment != null)
                {
                    hashCode = (hashCode * 59) + this.Environment.GetHashCode();
                }

                if (this.PasswordPolicy != null)
                {
                    hashCode = (hashCode * 59) + this.PasswordPolicy.GetHashCode();
                }

                if (this.RootPasswordTtl != null)
                {
                    hashCode = (hashCode * 59) + this.RootPasswordTtl.GetHashCode();
                }

                if (this.SubscriptionId != null)
                {
                    hashCode = (hashCode * 59) + this.SubscriptionId.GetHashCode();
                }

                if (this.TenantId != null)
                {
                    hashCode = (hashCode * 59) + this.TenantId.GetHashCode();
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
