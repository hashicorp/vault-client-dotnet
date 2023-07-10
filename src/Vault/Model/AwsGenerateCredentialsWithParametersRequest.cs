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
    /// AwsGenerateCredentialsWithParametersRequest
    /// </summary>
    [DataContract(Name = "AwsGenerateCredentialsWithParametersRequest")]
    public partial class AwsGenerateCredentialsWithParametersRequest : IEquatable<AwsGenerateCredentialsWithParametersRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="AwsGenerateCredentialsWithParametersRequest" /> class.
        /// </summary>

        /// <param name="RoleArn">ARN of role to assume when credential_type is assumed_role.</param>

        /// <param name="RoleSessionName">Session name to use when assuming role. Max chars: 64.</param>

        /// <param name="Ttl">Lifetime of the returned credentials in seconds (default to &quot;3600&quot;).</param>


        public AwsGenerateCredentialsWithParametersRequest(string RoleArn = default(string), string RoleSessionName = default(string), string Ttl = "3600")
        {

            this.RoleArn = RoleArn;

            this.RoleSessionName = RoleSessionName;

            // use default value if no "Ttl" provided
            this.Ttl = Ttl ?? "3600";


        }

        /// <summary>
        /// ARN of role to assume when credential_type is assumed_role
        /// </summary>
        /// <value>ARN of role to assume when credential_type is assumed_role</value>
        [DataMember(Name = "role_arn", EmitDefaultValue = false)]

        public string RoleArn { get; set; }


        /// <summary>
        /// Session name to use when assuming role. Max chars: 64
        /// </summary>
        /// <value>Session name to use when assuming role. Max chars: 64</value>
        [DataMember(Name = "role_session_name", EmitDefaultValue = false)]

        public string RoleSessionName { get; set; }


        /// <summary>
        /// Lifetime of the returned credentials in seconds
        /// </summary>
        /// <value>Lifetime of the returned credentials in seconds</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]

        public string Ttl { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AwsGenerateCredentialsWithParametersRequest {\n");
            sb.Append("  RoleArn: ").Append(RoleArn).Append("\n");
            sb.Append("  RoleSessionName: ").Append(RoleSessionName).Append("\n");
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
            return this.Equals(input as AwsGenerateCredentialsWithParametersRequest);
        }

        /// <summary>
        /// Returns true if AwsGenerateCredentialsWithParametersRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AwsGenerateCredentialsWithParametersRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AwsGenerateCredentialsWithParametersRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.RoleArn == input.RoleArn ||
                    (this.RoleArn != null &&
                    this.RoleArn.Equals(input.RoleArn))

                ) &&
                (
                    this.RoleSessionName == input.RoleSessionName ||
                    (this.RoleSessionName != null &&
                    this.RoleSessionName.Equals(input.RoleSessionName))

                ) &&
                (
                    this.Ttl == input.Ttl ||
                    (this.Ttl != null &&
                    this.Ttl.Equals(input.Ttl))

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

                if (this.RoleArn != null)
                {
                    hashCode = (hashCode * 59) + this.RoleArn.GetHashCode();
                }

                if (this.RoleSessionName != null)
                {
                    hashCode = (hashCode * 59) + this.RoleSessionName.GetHashCode();
                }

                if (this.Ttl != null)
                {
                    hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
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
