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
    /// WriteQuotasRateLimitRequest
    /// </summary>
    [DataContract(Name = "WriteQuotasRateLimitRequest")]
    public partial class WriteQuotasRateLimitRequest : IEquatable<WriteQuotasRateLimitRequest>, IValidatableObject
    {















        /// <summary>
        /// Initializes a new instance of the <see cref="WriteQuotasRateLimitRequest" /> class.
        /// </summary>

        /// <param name="BlockInterval">If set, when a client reaches a rate limit threshold, the client will be prohibited from any further requests until after the &#x27;block_interval&#x27; has elapsed..</param>

        /// <param name="Interval">The duration to enforce rate limiting for (default &#x27;1s&#x27;)..</param>

        /// <param name="Path">Path of the mount or namespace to apply the quota. A blank path configures a global quota. For example namespace1/ adds a quota to a full namespace, namespace1/auth/userpass adds a quota to userpass in namespace1..</param>

        /// <param name="Rate">The maximum number of requests in a given interval to be allowed by the quota rule. The &#x27;rate&#x27; must be positive..</param>

        /// <param name="Role">Login role to apply this quota to. Note that when set, path must be configured to a valid auth method with a concept of roles..</param>

        /// <param name="Type">Type of the quota rule..</param>


        public WriteQuotasRateLimitRequest(int BlockInterval = default(int), int Interval = default(int), string Path = default(string), float Rate = default(float), string Role = default(string), string Type = default(string))
        {

            this.BlockInterval = BlockInterval;

            this.Interval = Interval;

            this.Path = Path;

            this.Rate = Rate;

            this.Role = Role;

            this.Type = Type;

        }

        /// <summary>
        /// If set, when a client reaches a rate limit threshold, the client will be prohibited from any further requests until after the &#x27;block_interval&#x27; has elapsed.
        /// </summary>
        /// <value>If set, when a client reaches a rate limit threshold, the client will be prohibited from any further requests until after the &#x27;block_interval&#x27; has elapsed.</value>
        [DataMember(Name = "block_interval", EmitDefaultValue = false)]


        public int BlockInterval { get; set; }


        /// <summary>
        /// The duration to enforce rate limiting for (default &#x27;1s&#x27;).
        /// </summary>
        /// <value>The duration to enforce rate limiting for (default &#x27;1s&#x27;).</value>
        [DataMember(Name = "interval", EmitDefaultValue = false)]


        public int Interval { get; set; }


        /// <summary>
        /// Path of the mount or namespace to apply the quota. A blank path configures a global quota. For example namespace1/ adds a quota to a full namespace, namespace1/auth/userpass adds a quota to userpass in namespace1.
        /// </summary>
        /// <value>Path of the mount or namespace to apply the quota. A blank path configures a global quota. For example namespace1/ adds a quota to a full namespace, namespace1/auth/userpass adds a quota to userpass in namespace1.</value>
        [DataMember(Name = "path", EmitDefaultValue = false)]


        public string Path { get; set; }


        /// <summary>
        /// The maximum number of requests in a given interval to be allowed by the quota rule. The &#x27;rate&#x27; must be positive.
        /// </summary>
        /// <value>The maximum number of requests in a given interval to be allowed by the quota rule. The &#x27;rate&#x27; must be positive.</value>
        [DataMember(Name = "rate", EmitDefaultValue = false)]


        public float Rate { get; set; }


        /// <summary>
        /// Login role to apply this quota to. Note that when set, path must be configured to a valid auth method with a concept of roles.
        /// </summary>
        /// <value>Login role to apply this quota to. Note that when set, path must be configured to a valid auth method with a concept of roles.</value>
        [DataMember(Name = "role", EmitDefaultValue = false)]


        public string Role { get; set; }


        /// <summary>
        /// Type of the quota rule.
        /// </summary>
        /// <value>Type of the quota rule.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]


        public string Type { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WriteQuotasRateLimitRequest {\n");
            sb.Append("  BlockInterval: ").Append(BlockInterval).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as WriteQuotasRateLimitRequest);
        }

        /// <summary>
        /// Returns true if WriteQuotasRateLimitRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WriteQuotasRateLimitRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WriteQuotasRateLimitRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.BlockInterval == input.BlockInterval ||

                    this.BlockInterval.Equals(input.BlockInterval)
                ) &&
                (
                    this.Interval == input.Interval ||

                    this.Interval.Equals(input.Interval)
                ) &&
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))

                ) &&
                (
                    this.Rate == input.Rate ||

                    this.Rate.Equals(input.Rate)
                ) &&
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))

                ) &&
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))

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


                hashCode = (hashCode * 59) + this.BlockInterval.GetHashCode();

                hashCode = (hashCode * 59) + this.Interval.GetHashCode();
                if (this.Path != null)
                {
                    hashCode = (hashCode * 59) + this.Path.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Rate.GetHashCode();
                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
                }

                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
