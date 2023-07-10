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
    /// PkiGenerateEabKeyForIssuerAndRoleResponse
    /// </summary>
    [DataContract(Name = "PkiGenerateEabKeyForIssuerAndRoleResponse")]
    public partial class PkiGenerateEabKeyForIssuerAndRoleResponse : IEquatable<PkiGenerateEabKeyForIssuerAndRoleResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PkiGenerateEabKeyForIssuerAndRoleResponse" /> class.
        /// </summary>

        /// <param name="AcmeDirectory">The ACME directory to which the key belongs.</param>

        /// <param name="CreatedOn">An RFC3339 formatted date time when the EAB token was created.</param>

        /// <param name="Id">The EAB key identifier.</param>

        /// <param name="Key">The EAB hmac key.</param>

        /// <param name="KeyType">The EAB key type.</param>


        public PkiGenerateEabKeyForIssuerAndRoleResponse(string AcmeDirectory = default(string), DateTime CreatedOn = default(DateTime), string Id = default(string), string Key = default(string), string KeyType = default(string))
        {

            this.AcmeDirectory = AcmeDirectory;

            this.CreatedOn = CreatedOn;

            this.Id = Id;

            this.Key = Key;

            this.KeyType = KeyType;

        }

        /// <summary>
        /// The ACME directory to which the key belongs
        /// </summary>
        /// <value>The ACME directory to which the key belongs</value>
        [DataMember(Name = "acme_directory", EmitDefaultValue = false)]

        public string AcmeDirectory { get; set; }


        /// <summary>
        /// An RFC3339 formatted date time when the EAB token was created
        /// </summary>
        /// <value>An RFC3339 formatted date time when the EAB token was created</value>
        [DataMember(Name = "created_on", EmitDefaultValue = false)]

        public DateTime CreatedOn { get; set; }


        /// <summary>
        /// The EAB key identifier
        /// </summary>
        /// <value>The EAB key identifier</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]

        public string Id { get; set; }


        /// <summary>
        /// The EAB hmac key
        /// </summary>
        /// <value>The EAB hmac key</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]

        public string Key { get; set; }


        /// <summary>
        /// The EAB key type
        /// </summary>
        /// <value>The EAB key type</value>
        [DataMember(Name = "key_type", EmitDefaultValue = false)]

        public string KeyType { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiGenerateEabKeyForIssuerAndRoleResponse {\n");
            sb.Append("  AcmeDirectory: ").Append(AcmeDirectory).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  KeyType: ").Append(KeyType).Append("\n");
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
            return this.Equals(input as PkiGenerateEabKeyForIssuerAndRoleResponse);
        }

        /// <summary>
        /// Returns true if PkiGenerateEabKeyForIssuerAndRoleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiGenerateEabKeyForIssuerAndRoleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiGenerateEabKeyForIssuerAndRoleResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AcmeDirectory == input.AcmeDirectory ||
                    (this.AcmeDirectory != null &&
                    this.AcmeDirectory.Equals(input.AcmeDirectory))

                ) &&
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))

                ) &&
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))

                ) &&
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))

                ) &&
                (
                    this.KeyType == input.KeyType ||
                    (this.KeyType != null &&
                    this.KeyType.Equals(input.KeyType))

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

                if (this.AcmeDirectory != null)
                {
                    hashCode = (hashCode * 59) + this.AcmeDirectory.GetHashCode();
                }

                if (this.CreatedOn != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedOn.GetHashCode();
                }

                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }

                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }

                if (this.KeyType != null)
                {
                    hashCode = (hashCode * 59) + this.KeyType.GetHashCode();
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
