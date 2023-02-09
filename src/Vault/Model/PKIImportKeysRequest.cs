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
    /// PKIImportKeysRequest
    /// </summary>
    [DataContract(Name = "PKIImportKeysRequest")]
    public partial class PKIImportKeysRequest : IEquatable<PKIImportKeysRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PKIImportKeysRequest" /> class.
        /// </summary>
        /// <param name="keyName">Optional name to be used for this key.</param>
        /// <param name="pemBundle">PEM-format, unencrypted secret key.</param>
        public PKIImportKeysRequest(string keyName = default(string), string pemBundle = default(string))
        {
            this.KeyName = keyName;
            this.PemBundle = pemBundle;
        }

        /// <summary>
        /// Optional name to be used for this key
        /// </summary>
        /// <value>Optional name to be used for this key</value>
        [DataMember(Name = "key_name", EmitDefaultValue = false)]
        public string KeyName { get; set; }

        /// <summary>
        /// PEM-format, unencrypted secret key
        /// </summary>
        /// <value>PEM-format, unencrypted secret key</value>
        [DataMember(Name = "pem_bundle", EmitDefaultValue = false)]
        public string PemBundle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PKIImportKeysRequest {\n");
            sb.Append("  KeyName: ").Append(KeyName).Append("\n");
            sb.Append("  PemBundle: ").Append(PemBundle).Append("\n");
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
            return this.Equals(input as PKIImportKeysRequest);
        }

        /// <summary>
        /// Returns true if PKIImportKeysRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PKIImportKeysRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PKIImportKeysRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.KeyName == input.KeyName ||
                    (this.KeyName != null &&
                    this.KeyName.Equals(input.KeyName))
                ) && 
                (
                    this.PemBundle == input.PemBundle ||
                    (this.PemBundle != null &&
                    this.PemBundle.Equals(input.PemBundle))
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
                if (this.KeyName != null)
                {
                    hashCode = (hashCode * 59) + this.KeyName.GetHashCode();
                }
                if (this.PemBundle != null)
                {
                    hashCode = (hashCode * 59) + this.PemBundle.GetHashCode();
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
