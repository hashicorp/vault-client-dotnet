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
    /// TransitRestoreKeyRequest
    /// </summary>
    [DataContract(Name = "TransitRestoreKeyRequest")]

    public partial class TransitRestoreKeyRequest : IEquatable<TransitRestoreKeyRequest>, IValidatableObject
    {







        /// <summary>
        /// Initializes a new instance of the <see cref="TransitRestoreKeyRequest" /> class.
        /// </summary>

        /// <param name="Backup">Backed up key data to be restored. This should be the output from the &#x27;backup/&#x27; endpoint..</param>

        /// <param name="Force">If set and a key by the given name exists, force the restore operation and override the key. (default to false).</param>


        public TransitRestoreKeyRequest(string Backup = default(string), bool Force = false)
        {

            this.Backup = Backup;

            this.Force = Force;

        }

        /// <summary>
        /// Backed up key data to be restored. This should be the output from the &#x27;backup/&#x27; endpoint.
        /// </summary>
        /// <value>Backed up key data to be restored. This should be the output from the &#x27;backup/&#x27; endpoint.</value>
        [DataMember(Name = "backup", EmitDefaultValue = false)]


        public string Backup { get; set; }


        /// <summary>
        /// If set and a key by the given name exists, force the restore operation and override the key.
        /// </summary>
        /// <value>If set and a key by the given name exists, force the restore operation and override the key.</value>
        [DataMember(Name = "force", EmitDefaultValue = true)]


        public bool Force { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransitRestoreKeyRequest {\n");
            sb.Append("  Backup: ").Append(Backup).Append("\n");
            sb.Append("  Force: ").Append(Force).Append("\n");
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
            return this.Equals(input as TransitRestoreKeyRequest);
        }

        /// <summary>
        /// Returns true if TransitRestoreKeyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransitRestoreKeyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransitRestoreKeyRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Backup == input.Backup ||
                    (this.Backup != null &&
                    this.Backup.Equals(input.Backup))

                ) &&
                (
                    this.Force == input.Force ||

                    this.Force.Equals(input.Force)
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

                if (this.Backup != null)
                {
                    hashCode = (hashCode * 59) + this.Backup.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Force.GetHashCode();
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
