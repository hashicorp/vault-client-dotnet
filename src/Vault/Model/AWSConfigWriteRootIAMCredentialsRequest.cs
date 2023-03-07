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
    /// AWSConfigWriteRootIAMCredentialsRequest
    /// </summary>
    [DataContract(Name = "AWSConfigWriteRootIAMCredentialsRequest")]

    public partial class AWSConfigWriteRootIAMCredentialsRequest : IEquatable<AWSConfigWriteRootIAMCredentialsRequest>, IValidatableObject
    {

















        /// <summary>
        /// Initializes a new instance of the <see cref="AWSConfigWriteRootIAMCredentialsRequest" /> class.
        /// </summary>

        /// <param name="AccessKey">Access key with permission to create new keys..</param>

        /// <param name="IamEndpoint">Endpoint to custom IAM server URL.</param>

        /// <param name="MaxRetries">Maximum number of retries for recoverable exceptions of AWS APIs (default to -1).</param>

        /// <param name="Region">Region for API calls..</param>

        /// <param name="SecretKey">Secret key with permission to create new keys..</param>

        /// <param name="StsEndpoint">Endpoint to custom STS server URL.</param>

        /// <param name="UsernameTemplate">Template to generate custom IAM usernames.</param>


        public AWSConfigWriteRootIAMCredentialsRequest(string AccessKey = default(string), string IamEndpoint = default(string), int MaxRetries = -1, string Region = default(string), string SecretKey = default(string), string StsEndpoint = default(string), string UsernameTemplate = default(string))
        {

            this.AccessKey = AccessKey;

            this.IamEndpoint = IamEndpoint;

            this.MaxRetries = MaxRetries;

            this.Region = Region;

            this.SecretKey = SecretKey;

            this.StsEndpoint = StsEndpoint;

            this.UsernameTemplate = UsernameTemplate;

        }

        /// <summary>
        /// Access key with permission to create new keys.
        /// </summary>
        /// <value>Access key with permission to create new keys.</value>
        [DataMember(Name = "access_key", EmitDefaultValue = false)]


        public string AccessKey { get; set; }


        /// <summary>
        /// Endpoint to custom IAM server URL
        /// </summary>
        /// <value>Endpoint to custom IAM server URL</value>
        [DataMember(Name = "iam_endpoint", EmitDefaultValue = false)]


        public string IamEndpoint { get; set; }


        /// <summary>
        /// Maximum number of retries for recoverable exceptions of AWS APIs
        /// </summary>
        /// <value>Maximum number of retries for recoverable exceptions of AWS APIs</value>
        [DataMember(Name = "max_retries", EmitDefaultValue = false)]


        public int MaxRetries { get; set; }


        /// <summary>
        /// Region for API calls.
        /// </summary>
        /// <value>Region for API calls.</value>
        [DataMember(Name = "region", EmitDefaultValue = false)]


        public string Region { get; set; }


        /// <summary>
        /// Secret key with permission to create new keys.
        /// </summary>
        /// <value>Secret key with permission to create new keys.</value>
        [DataMember(Name = "secret_key", EmitDefaultValue = false)]


        public string SecretKey { get; set; }


        /// <summary>
        /// Endpoint to custom STS server URL
        /// </summary>
        /// <value>Endpoint to custom STS server URL</value>
        [DataMember(Name = "sts_endpoint", EmitDefaultValue = false)]


        public string StsEndpoint { get; set; }


        /// <summary>
        /// Template to generate custom IAM usernames
        /// </summary>
        /// <value>Template to generate custom IAM usernames</value>
        [DataMember(Name = "username_template", EmitDefaultValue = false)]


        public string UsernameTemplate { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AWSConfigWriteRootIAMCredentialsRequest {\n");
            sb.Append("  AccessKey: ").Append(AccessKey).Append("\n");
            sb.Append("  IamEndpoint: ").Append(IamEndpoint).Append("\n");
            sb.Append("  MaxRetries: ").Append(MaxRetries).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  SecretKey: ").Append(SecretKey).Append("\n");
            sb.Append("  StsEndpoint: ").Append(StsEndpoint).Append("\n");
            sb.Append("  UsernameTemplate: ").Append(UsernameTemplate).Append("\n");
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
            return this.Equals(input as AWSConfigWriteRootIAMCredentialsRequest);
        }

        /// <summary>
        /// Returns true if AWSConfigWriteRootIAMCredentialsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AWSConfigWriteRootIAMCredentialsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AWSConfigWriteRootIAMCredentialsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AccessKey == input.AccessKey ||
                    (this.AccessKey != null &&
                    this.AccessKey.Equals(input.AccessKey))

                ) &&
                (
                    this.IamEndpoint == input.IamEndpoint ||
                    (this.IamEndpoint != null &&
                    this.IamEndpoint.Equals(input.IamEndpoint))

                ) &&
                (
                    this.MaxRetries == input.MaxRetries ||

                    this.MaxRetries.Equals(input.MaxRetries)
                ) &&
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))

                ) &&
                (
                    this.SecretKey == input.SecretKey ||
                    (this.SecretKey != null &&
                    this.SecretKey.Equals(input.SecretKey))

                ) &&
                (
                    this.StsEndpoint == input.StsEndpoint ||
                    (this.StsEndpoint != null &&
                    this.StsEndpoint.Equals(input.StsEndpoint))

                ) &&
                (
                    this.UsernameTemplate == input.UsernameTemplate ||
                    (this.UsernameTemplate != null &&
                    this.UsernameTemplate.Equals(input.UsernameTemplate))

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

                if (this.AccessKey != null)
                {
                    hashCode = (hashCode * 59) + this.AccessKey.GetHashCode();
                }

                if (this.IamEndpoint != null)
                {
                    hashCode = (hashCode * 59) + this.IamEndpoint.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.MaxRetries.GetHashCode();
                if (this.Region != null)
                {
                    hashCode = (hashCode * 59) + this.Region.GetHashCode();
                }

                if (this.SecretKey != null)
                {
                    hashCode = (hashCode * 59) + this.SecretKey.GetHashCode();
                }

                if (this.StsEndpoint != null)
                {
                    hashCode = (hashCode * 59) + this.StsEndpoint.GetHashCode();
                }

                if (this.UsernameTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.UsernameTemplate.GetHashCode();
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
