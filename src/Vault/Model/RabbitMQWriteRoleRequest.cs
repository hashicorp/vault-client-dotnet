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
    /// RabbitMQWriteRoleRequest
    /// </summary>
    [DataContract(Name = "RabbitMQWriteRoleRequest")]
    public partial class RabbitMQWriteRoleRequest : IEquatable<RabbitMQWriteRoleRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RabbitMQWriteRoleRequest" /> class.
        /// </summary>
        /// <param name="tags">Comma-separated list of tags for this role..</param>
        /// <param name="vhostTopics">A nested map of virtual hosts and exchanges to topic permissions..</param>
        /// <param name="vhosts">A map of virtual hosts to permissions..</param>
        public RabbitMQWriteRoleRequest(string tags = default(string), string vhostTopics = default(string), string vhosts = default(string))
        {
            this.Tags = tags;
            this.VhostTopics = vhostTopics;
            this.Vhosts = vhosts;
        }

        /// <summary>
        /// Comma-separated list of tags for this role.
        /// </summary>
        /// <value>Comma-separated list of tags for this role.</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public string Tags { get; set; }

        /// <summary>
        /// A nested map of virtual hosts and exchanges to topic permissions.
        /// </summary>
        /// <value>A nested map of virtual hosts and exchanges to topic permissions.</value>
        [DataMember(Name = "vhost_topics", EmitDefaultValue = false)]
        public string VhostTopics { get; set; }

        /// <summary>
        /// A map of virtual hosts to permissions.
        /// </summary>
        /// <value>A map of virtual hosts to permissions.</value>
        [DataMember(Name = "vhosts", EmitDefaultValue = false)]
        public string Vhosts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RabbitMQWriteRoleRequest {\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  VhostTopics: ").Append(VhostTopics).Append("\n");
            sb.Append("  Vhosts: ").Append(Vhosts).Append("\n");
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
            return this.Equals(input as RabbitMQWriteRoleRequest);
        }

        /// <summary>
        /// Returns true if RabbitMQWriteRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RabbitMQWriteRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RabbitMQWriteRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) &&
                (
                    this.VhostTopics == input.VhostTopics ||
                    (this.VhostTopics != null &&
                    this.VhostTopics.Equals(input.VhostTopics))
                ) &&
                (
                    this.Vhosts == input.Vhosts ||
                    (this.Vhosts != null &&
                    this.Vhosts.Equals(input.Vhosts))
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
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.VhostTopics != null)
                {
                    hashCode = (hashCode * 59) + this.VhostTopics.GetHashCode();
                }
                if (this.Vhosts != null)
                {
                    hashCode = (hashCode * 59) + this.Vhosts.GetHashCode();
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
