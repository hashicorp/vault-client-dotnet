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
    /// AwsConfigureClientRequest
    /// </summary>
    [DataContract(Name = "AwsConfigureClientRequest")]
    public partial class AwsConfigureClientRequest : IEquatable<AwsConfigureClientRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="AwsConfigureClientRequest" /> class.
        /// </summary>

        /// <param name="AccessKey">AWS Access Key ID for the account used to make AWS API requests. (default to &quot;&quot;).</param>

        /// <param name="AllowedStsHeaderValues">List of additional headers that are allowed to be in AWS STS request headers.</param>

        /// <param name="Endpoint">URL to override the default generated endpoint for making AWS EC2 API calls. (default to &quot;&quot;).</param>

        /// <param name="IamEndpoint">URL to override the default generated endpoint for making AWS IAM API calls. (default to &quot;&quot;).</param>

        /// <param name="IamServerIdHeaderValue">Value to require in the X-Vault-AWS-IAM-Server-ID request header (default to &quot;&quot;).</param>

        /// <param name="MaxRetries">Maximum number of retries for recoverable exceptions of AWS APIs (default to -1).</param>

        /// <param name="SecretKey">AWS Secret Access Key for the account used to make AWS API requests. (default to &quot;&quot;).</param>

        /// <param name="StsEndpoint">URL to override the default generated endpoint for making AWS STS API calls. (default to &quot;&quot;).</param>

        /// <param name="StsRegion">The region ID for the sts_endpoint, if set. (default to &quot;&quot;).</param>

        /// <param name="UseStsRegionFromClient">Uses the STS region from client requests for making AWS STS API calls. (default to false).</param>


        public AwsConfigureClientRequest(string AccessKey = "", List<string> AllowedStsHeaderValues = default(List<string>), string Endpoint = "", string IamEndpoint = "", string IamServerIdHeaderValue = "", int MaxRetries = -1, string SecretKey = "", string StsEndpoint = "", string StsRegion = "", bool UseStsRegionFromClient = false)
        {

            // use default value if no "AccessKey" provided
            this.AccessKey = AccessKey ?? "";


            this.AllowedStsHeaderValues = AllowedStsHeaderValues;

            // use default value if no "Endpoint" provided
            this.Endpoint = Endpoint ?? "";


            // use default value if no "IamEndpoint" provided
            this.IamEndpoint = IamEndpoint ?? "";


            // use default value if no "IamServerIdHeaderValue" provided
            this.IamServerIdHeaderValue = IamServerIdHeaderValue ?? "";


            this.MaxRetries = MaxRetries;

            // use default value if no "SecretKey" provided
            this.SecretKey = SecretKey ?? "";


            // use default value if no "StsEndpoint" provided
            this.StsEndpoint = StsEndpoint ?? "";


            // use default value if no "StsRegion" provided
            this.StsRegion = StsRegion ?? "";


            this.UseStsRegionFromClient = UseStsRegionFromClient;

        }

        /// <summary>
        /// AWS Access Key ID for the account used to make AWS API requests.
        /// </summary>
        /// <value>AWS Access Key ID for the account used to make AWS API requests.</value>
        [DataMember(Name = "access_key", EmitDefaultValue = false)]

        public string AccessKey { get; set; }


        /// <summary>
        /// List of additional headers that are allowed to be in AWS STS request headers
        /// </summary>
        /// <value>List of additional headers that are allowed to be in AWS STS request headers</value>
        [DataMember(Name = "allowed_sts_header_values", EmitDefaultValue = false)]

        public List<string> AllowedStsHeaderValues { get; set; }


        /// <summary>
        /// URL to override the default generated endpoint for making AWS EC2 API calls.
        /// </summary>
        /// <value>URL to override the default generated endpoint for making AWS EC2 API calls.</value>
        [DataMember(Name = "endpoint", EmitDefaultValue = false)]

        public string Endpoint { get; set; }


        /// <summary>
        /// URL to override the default generated endpoint for making AWS IAM API calls.
        /// </summary>
        /// <value>URL to override the default generated endpoint for making AWS IAM API calls.</value>
        [DataMember(Name = "iam_endpoint", EmitDefaultValue = false)]

        public string IamEndpoint { get; set; }


        /// <summary>
        /// Value to require in the X-Vault-AWS-IAM-Server-ID request header
        /// </summary>
        /// <value>Value to require in the X-Vault-AWS-IAM-Server-ID request header</value>
        [DataMember(Name = "iam_server_id_header_value", EmitDefaultValue = false)]

        public string IamServerIdHeaderValue { get; set; }


        /// <summary>
        /// Maximum number of retries for recoverable exceptions of AWS APIs
        /// </summary>
        /// <value>Maximum number of retries for recoverable exceptions of AWS APIs</value>
        [DataMember(Name = "max_retries", EmitDefaultValue = false)]

        public int MaxRetries { get; set; }


        /// <summary>
        /// AWS Secret Access Key for the account used to make AWS API requests.
        /// </summary>
        /// <value>AWS Secret Access Key for the account used to make AWS API requests.</value>
        [DataMember(Name = "secret_key", EmitDefaultValue = false)]

        public string SecretKey { get; set; }


        /// <summary>
        /// URL to override the default generated endpoint for making AWS STS API calls.
        /// </summary>
        /// <value>URL to override the default generated endpoint for making AWS STS API calls.</value>
        [DataMember(Name = "sts_endpoint", EmitDefaultValue = false)]

        public string StsEndpoint { get; set; }


        /// <summary>
        /// The region ID for the sts_endpoint, if set.
        /// </summary>
        /// <value>The region ID for the sts_endpoint, if set.</value>
        [DataMember(Name = "sts_region", EmitDefaultValue = false)]

        public string StsRegion { get; set; }


        /// <summary>
        /// Uses the STS region from client requests for making AWS STS API calls.
        /// </summary>
        /// <value>Uses the STS region from client requests for making AWS STS API calls.</value>
        [DataMember(Name = "use_sts_region_from_client", EmitDefaultValue = true)]

        public bool UseStsRegionFromClient { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AwsConfigureClientRequest {\n");
            sb.Append("  AccessKey: ").Append(AccessKey).Append("\n");
            sb.Append("  AllowedStsHeaderValues: ").Append(AllowedStsHeaderValues).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  IamEndpoint: ").Append(IamEndpoint).Append("\n");
            sb.Append("  IamServerIdHeaderValue: ").Append(IamServerIdHeaderValue).Append("\n");
            sb.Append("  MaxRetries: ").Append(MaxRetries).Append("\n");
            sb.Append("  SecretKey: ").Append(SecretKey).Append("\n");
            sb.Append("  StsEndpoint: ").Append(StsEndpoint).Append("\n");
            sb.Append("  StsRegion: ").Append(StsRegion).Append("\n");
            sb.Append("  UseStsRegionFromClient: ").Append(UseStsRegionFromClient).Append("\n");
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
            return this.Equals(input as AwsConfigureClientRequest);
        }

        /// <summary>
        /// Returns true if AwsConfigureClientRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AwsConfigureClientRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AwsConfigureClientRequest input)
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
                    this.AllowedStsHeaderValues == input.AllowedStsHeaderValues ||
                    this.AllowedStsHeaderValues != null &&
                    input.AllowedStsHeaderValues != null &&
                    this.AllowedStsHeaderValues.SequenceEqual(input.AllowedStsHeaderValues)
                ) &&
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))

                ) &&
                (
                    this.IamEndpoint == input.IamEndpoint ||
                    (this.IamEndpoint != null &&
                    this.IamEndpoint.Equals(input.IamEndpoint))

                ) &&
                (
                    this.IamServerIdHeaderValue == input.IamServerIdHeaderValue ||
                    (this.IamServerIdHeaderValue != null &&
                    this.IamServerIdHeaderValue.Equals(input.IamServerIdHeaderValue))

                ) &&
                (
                    this.MaxRetries == input.MaxRetries ||

                    this.MaxRetries.Equals(input.MaxRetries)
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
                    this.StsRegion == input.StsRegion ||
                    (this.StsRegion != null &&
                    this.StsRegion.Equals(input.StsRegion))

                ) &&
                (
                    this.UseStsRegionFromClient == input.UseStsRegionFromClient ||

                    this.UseStsRegionFromClient.Equals(input.UseStsRegionFromClient)
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

                if (this.AllowedStsHeaderValues != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedStsHeaderValues.GetHashCode();
                }

                if (this.Endpoint != null)
                {
                    hashCode = (hashCode * 59) + this.Endpoint.GetHashCode();
                }

                if (this.IamEndpoint != null)
                {
                    hashCode = (hashCode * 59) + this.IamEndpoint.GetHashCode();
                }

                if (this.IamServerIdHeaderValue != null)
                {
                    hashCode = (hashCode * 59) + this.IamServerIdHeaderValue.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.MaxRetries.GetHashCode();
                if (this.SecretKey != null)
                {
                    hashCode = (hashCode * 59) + this.SecretKey.GetHashCode();
                }

                if (this.StsEndpoint != null)
                {
                    hashCode = (hashCode * 59) + this.StsEndpoint.GetHashCode();
                }

                if (this.StsRegion != null)
                {
                    hashCode = (hashCode * 59) + this.StsRegion.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.UseStsRegionFromClient.GetHashCode();
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
