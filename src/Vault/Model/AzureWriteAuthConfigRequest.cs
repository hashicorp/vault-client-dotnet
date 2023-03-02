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
    /// AzureWriteAuthConfigRequest
    /// </summary>
    [DataContract(Name = "AzureWriteAuthConfigRequest")]

    public partial class AzureWriteAuthConfigRequest : IEquatable<AzureWriteAuthConfigRequest>, IValidatableObject
    {













        /// <summary>
        /// Initializes a new instance of the <see cref="AzureWriteAuthConfigRequest" /> class.
        /// </summary>

        /// <param name="ClientId">The OAuth2 client id to connection to Azure. This value can also be provided with the AZURE_CLIENT_ID environment variable..</param>

        /// <param name="ClientSecret">The OAuth2 client secret to connection to Azure. This value can also be provided with the AZURE_CLIENT_SECRET environment variable..</param>

        /// <param name="Environment">The Azure environment name. If not provided, AzurePublicCloud is used. This value can also be provided with the AZURE_ENVIRONMENT environment variable..</param>

        /// <param name="Resource">The resource URL for the vault application in Azure Active Directory. This value can also be provided with the AZURE_AD_RESOURCE environment variable..</param>

        /// <param name="TenantId">The tenant id for the Azure Active Directory. This is sometimes referred to as Directory ID in AD. This value can also be provided with the AZURE_TENANT_ID environment variable..</param>


        public AzureWriteAuthConfigRequest(string ClientId = default(string), string ClientSecret = default(string), string Environment = default(string), string Resource = default(string), string TenantId = default(string))
        {

            this.ClientId = ClientId;

            this.ClientSecret = ClientSecret;

            this.Environment = Environment;

            this.Resource = Resource;

            this.TenantId = TenantId;

        }

        /// <summary>
        /// The OAuth2 client id to connection to Azure. This value can also be provided with the AZURE_CLIENT_ID environment variable.
        /// </summary>
        /// <value>The OAuth2 client id to connection to Azure. This value can also be provided with the AZURE_CLIENT_ID environment variable.</value>
        [DataMember(Name = "client_id", EmitDefaultValue = false)]


        public string ClientId { get; set; }


        /// <summary>
        /// The OAuth2 client secret to connection to Azure. This value can also be provided with the AZURE_CLIENT_SECRET environment variable.
        /// </summary>
        /// <value>The OAuth2 client secret to connection to Azure. This value can also be provided with the AZURE_CLIENT_SECRET environment variable.</value>
        [DataMember(Name = "client_secret", EmitDefaultValue = false)]


        public string ClientSecret { get; set; }


        /// <summary>
        /// The Azure environment name. If not provided, AzurePublicCloud is used. This value can also be provided with the AZURE_ENVIRONMENT environment variable.
        /// </summary>
        /// <value>The Azure environment name. If not provided, AzurePublicCloud is used. This value can also be provided with the AZURE_ENVIRONMENT environment variable.</value>
        [DataMember(Name = "environment", EmitDefaultValue = false)]


        public string Environment { get; set; }


        /// <summary>
        /// The resource URL for the vault application in Azure Active Directory. This value can also be provided with the AZURE_AD_RESOURCE environment variable.
        /// </summary>
        /// <value>The resource URL for the vault application in Azure Active Directory. This value can also be provided with the AZURE_AD_RESOURCE environment variable.</value>
        [DataMember(Name = "resource", EmitDefaultValue = false)]


        public string Resource { get; set; }


        /// <summary>
        /// The tenant id for the Azure Active Directory. This is sometimes referred to as Directory ID in AD. This value can also be provided with the AZURE_TENANT_ID environment variable.
        /// </summary>
        /// <value>The tenant id for the Azure Active Directory. This is sometimes referred to as Directory ID in AD. This value can also be provided with the AZURE_TENANT_ID environment variable.</value>
        [DataMember(Name = "tenant_id", EmitDefaultValue = false)]


        public string TenantId { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AzureWriteAuthConfigRequest {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
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
            return this.Equals(input as AzureWriteAuthConfigRequest);
        }

        /// <summary>
        /// Returns true if AzureWriteAuthConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AzureWriteAuthConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AzureWriteAuthConfigRequest input)
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
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))

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

                if (this.Resource != null)
                {
                    hashCode = (hashCode * 59) + this.Resource.GetHashCode();
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
