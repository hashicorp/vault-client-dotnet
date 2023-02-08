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
    /// MongoDBAtlasWriteConfigRequest
    /// </summary>
    [DataContract(Name = "MongoDBAtlasWriteConfigRequest")]
    public partial class MongoDBAtlasWriteConfigRequest : IEquatable<MongoDBAtlasWriteConfigRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MongoDBAtlasWriteConfigRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MongoDBAtlasWriteConfigRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MongoDBAtlasWriteConfigRequest" /> class.
        /// </summary>
        /// <param name="privateKey">MongoDB Atlas Programmatic Private Key (required).</param>
        /// <param name="publicKey">MongoDB Atlas Programmatic Public Key (required).</param>
        public MongoDBAtlasWriteConfigRequest(string privateKey = default(string), string publicKey = default(string))
        {
            // to ensure "privateKey" is required (not null)
            if (privateKey == null) {
                throw new ArgumentNullException("privateKey is a required property for MongoDBAtlasWriteConfigRequest and cannot be null");
            }
            this.PrivateKey = privateKey;
            // to ensure "publicKey" is required (not null)
            if (publicKey == null) {
                throw new ArgumentNullException("publicKey is a required property for MongoDBAtlasWriteConfigRequest and cannot be null");
            }
            this.PublicKey = publicKey;
        }

        /// <summary>
        /// MongoDB Atlas Programmatic Private Key
        /// </summary>
        /// <value>MongoDB Atlas Programmatic Private Key</value>
        [DataMember(Name = "private_key", IsRequired = true, EmitDefaultValue = false)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// MongoDB Atlas Programmatic Public Key
        /// </summary>
        /// <value>MongoDB Atlas Programmatic Public Key</value>
        [DataMember(Name = "public_key", IsRequired = true, EmitDefaultValue = false)]
        public string PublicKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MongoDBAtlasWriteConfigRequest {\n");
            sb.Append("  PrivateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
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
            return this.Equals(input as MongoDBAtlasWriteConfigRequest);
        }

        /// <summary>
        /// Returns true if MongoDBAtlasWriteConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MongoDBAtlasWriteConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MongoDBAtlasWriteConfigRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PrivateKey == input.PrivateKey ||
                    (this.PrivateKey != null &&
                    this.PrivateKey.Equals(input.PrivateKey))
                ) && 
                (
                    this.PublicKey == input.PublicKey ||
                    (this.PublicKey != null &&
                    this.PublicKey.Equals(input.PublicKey))
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
                if (this.PrivateKey != null)
                {
                    hashCode = (hashCode * 59) + this.PrivateKey.GetHashCode();
                }
                if (this.PublicKey != null)
                {
                    hashCode = (hashCode * 59) + this.PublicKey.GetHashCode();
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
