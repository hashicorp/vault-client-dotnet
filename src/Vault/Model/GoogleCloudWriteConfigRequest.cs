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
    /// GoogleCloudWriteConfigRequest
    /// </summary>
    [DataContract(Name = "GoogleCloudWriteConfigRequest")]
    public partial class GoogleCloudWriteConfigRequest : IEquatable<GoogleCloudWriteConfigRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleCloudWriteConfigRequest" /> class.
        /// </summary>
        /// <param name="credentials">GCP IAM service account credentials JSON with permissions to create new service accounts and set IAM policies.</param>
        /// <param name="maxTtl">Maximum time a service account key is valid for. If &lt;&#x3D; 0, will use system default..</param>
        /// <param name="ttl">Default lease for generated keys. If &lt;&#x3D; 0, will use system default..</param>
        public GoogleCloudWriteConfigRequest(string credentials = default(string), int maxTtl = default(int), int ttl = default(int))
        {
            this.Credentials = credentials;
            this.MaxTtl = maxTtl;
            this.Ttl = ttl;
        }

        /// <summary>
        /// GCP IAM service account credentials JSON with permissions to create new service accounts and set IAM policies
        /// </summary>
        /// <value>GCP IAM service account credentials JSON with permissions to create new service accounts and set IAM policies</value>
        [DataMember(Name = "credentials", EmitDefaultValue = false)]
        public string Credentials { get; set; }

        /// <summary>
        /// Maximum time a service account key is valid for. If &lt;&#x3D; 0, will use system default.
        /// </summary>
        /// <value>Maximum time a service account key is valid for. If &lt;&#x3D; 0, will use system default.</value>
        [DataMember(Name = "max_ttl", EmitDefaultValue = false)]
        public int MaxTtl { get; set; }

        /// <summary>
        /// Default lease for generated keys. If &lt;&#x3D; 0, will use system default.
        /// </summary>
        /// <value>Default lease for generated keys. If &lt;&#x3D; 0, will use system default.</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]
        public int Ttl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoogleCloudWriteConfigRequest {\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  MaxTtl: ").Append(MaxTtl).Append("\n");
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
            return this.Equals(input as GoogleCloudWriteConfigRequest);
        }

        /// <summary>
        /// Returns true if GoogleCloudWriteConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleCloudWriteConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleCloudWriteConfigRequest input)
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
                    this.MaxTtl == input.MaxTtl ||
                    this.MaxTtl.Equals(input.MaxTtl)
                ) && 
                (
                    this.Ttl == input.Ttl ||
                    this.Ttl.Equals(input.Ttl)
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
                hashCode = (hashCode * 59) + this.MaxTtl.GetHashCode();
                hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
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
