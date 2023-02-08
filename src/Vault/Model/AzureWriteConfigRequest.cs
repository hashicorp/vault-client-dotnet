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
    /// AzureWriteConfigRequest
    /// </summary>
    [DataContract(Name = "AzureWriteConfigRequest")]
    public partial class AzureWriteConfigRequest : IEquatable<AzureWriteConfigRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureWriteConfigRequest" /> class.
        /// </summary>
        /// <param name="clientId">The OAuth2 client id to connect to Azure. This value can also be provided with the AZURE_CLIENT_ID environment variable..</param>
        /// <param name="clientSecret">The OAuth2 client secret to connect to Azure. This value can also be provided with the AZURE_CLIENT_SECRET environment variable..</param>
        /// <param name="environment">The Azure environment name. If not provided, AzurePublicCloud is used. This value can also be provided with the AZURE_ENVIRONMENT environment variable..</param>
        /// <param name="passwordPolicy">Name of the password policy to use to generate passwords for dynamic credentials..</param>
        /// <param name="rootPasswordTtl">The TTL of the root password in Azure. This can be either a number of seconds or a time formatted duration (ex: 24h, 48ds).</param>
        /// <param name="subscriptionId">The subscription id for the Azure Active Directory. This value can also be provided with the AZURE_SUBSCRIPTION_ID environment variable..</param>
        /// <param name="tenantId">The tenant id for the Azure Active Directory. This value can also be provided with the AZURE_TENANT_ID environment variable..</param>
        public AzureWriteConfigRequest(string clientId = default(string), string clientSecret = default(string), string environment = default(string), string passwordPolicy = default(string), int rootPasswordTtl = default(int), string subscriptionId = default(string), string tenantId = default(string))
        {
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.Environment = environment;
            this.PasswordPolicy = passwordPolicy;
            this.RootPasswordTtl = rootPasswordTtl;
            this.SubscriptionId = subscriptionId;
            this.TenantId = tenantId;
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
        public int RootPasswordTtl { get; set; }

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
            sb.Append("class AzureWriteConfigRequest {\n");
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
            return this.Equals(input as AzureWriteConfigRequest);
        }

        /// <summary>
        /// Returns true if AzureWriteConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AzureWriteConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AzureWriteConfigRequest input)
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
                    this.RootPasswordTtl.Equals(input.RootPasswordTtl)
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
                hashCode = (hashCode * 59) + this.RootPasswordTtl.GetHashCode();
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
