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
    /// ActiveDirectoryWriteRoleRequest
    /// </summary>
    [DataContract(Name = "ActiveDirectoryWriteRoleRequest")]
    public partial class ActiveDirectoryWriteRoleRequest : IEquatable<ActiveDirectoryWriteRoleRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveDirectoryWriteRoleRequest" /> class.
        /// </summary>
        /// <param name="serviceAccountName">The username/logon name for the service account with which this role will be associated..</param>
        /// <param name="ttl">In seconds, the default password time-to-live..</param>
        public ActiveDirectoryWriteRoleRequest(string serviceAccountName = default(string), int ttl = default(int))
        {
            this.ServiceAccountName = serviceAccountName;
            this.Ttl = ttl;
        }

        /// <summary>
        /// The username/logon name for the service account with which this role will be associated.
        /// </summary>
        /// <value>The username/logon name for the service account with which this role will be associated.</value>
        [DataMember(Name = "service_account_name", EmitDefaultValue = false)]
        public string ServiceAccountName { get; set; }

        /// <summary>
        /// In seconds, the default password time-to-live.
        /// </summary>
        /// <value>In seconds, the default password time-to-live.</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]
        public int Ttl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ActiveDirectoryWriteRoleRequest {\n");
            sb.Append("  ServiceAccountName: ").Append(ServiceAccountName).Append("\n");
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
            return this.Equals(input as ActiveDirectoryWriteRoleRequest);
        }

        /// <summary>
        /// Returns true if ActiveDirectoryWriteRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ActiveDirectoryWriteRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActiveDirectoryWriteRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.ServiceAccountName == input.ServiceAccountName ||
                    (this.ServiceAccountName != null &&
                    this.ServiceAccountName.Equals(input.ServiceAccountName))
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
                if (this.ServiceAccountName != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceAccountName.GetHashCode();
                }
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
