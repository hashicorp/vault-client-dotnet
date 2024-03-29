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
    /// AliCloudConfigureRequest
    /// </summary>
    [DataContract(Name = "AliCloudConfigureRequest")]
    public partial class AliCloudConfigureRequest : IEquatable<AliCloudConfigureRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="AliCloudConfigureRequest" /> class.
        /// </summary>

        /// <param name="AccessKey">Access key with appropriate permissions..</param>

        /// <param name="SecretKey">Secret key with appropriate permissions..</param>


        public AliCloudConfigureRequest(string AccessKey = default(string), string SecretKey = default(string))
        {

            this.AccessKey = AccessKey;

            this.SecretKey = SecretKey;

        }

        /// <summary>
        /// Access key with appropriate permissions.
        /// </summary>
        /// <value>Access key with appropriate permissions.</value>
        [DataMember(Name = "access_key", EmitDefaultValue = false)]

        public string AccessKey { get; set; }


        /// <summary>
        /// Secret key with appropriate permissions.
        /// </summary>
        /// <value>Secret key with appropriate permissions.</value>
        [DataMember(Name = "secret_key", EmitDefaultValue = false)]

        public string SecretKey { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AliCloudConfigureRequest {\n");
            sb.Append("  AccessKey: ").Append(AccessKey).Append("\n");
            sb.Append("  SecretKey: ").Append(SecretKey).Append("\n");
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
            return this.Equals(input as AliCloudConfigureRequest);
        }

        /// <summary>
        /// Returns true if AliCloudConfigureRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AliCloudConfigureRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AliCloudConfigureRequest input)
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
                    this.SecretKey == input.SecretKey ||
                    (this.SecretKey != null &&
                    this.SecretKey.Equals(input.SecretKey))

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

                if (this.SecretKey != null)
                {
                    hashCode = (hashCode * 59) + this.SecretKey.GetHashCode();
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
