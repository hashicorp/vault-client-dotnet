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
    /// CertificatesWriteConfigRequest
    /// </summary>
    [DataContract(Name = "CertificatesWriteConfigRequest")]

    public partial class CertificatesWriteConfigRequest : IEquatable<CertificatesWriteConfigRequest>, IValidatableObject
    {









        /// <summary>
        /// Initializes a new instance of the <see cref="CertificatesWriteConfigRequest" /> class.
        /// </summary>

        /// <param name="DisableBinding">If set, during renewal, skips the matching of presented client identity with the client identity used during login. Defaults to false. (default to false).</param>

        /// <param name="EnableIdentityAliasMetadata">If set, metadata of the certificate including the metadata corresponding to allowed_metadata_extensions will be stored in the alias. Defaults to false. (default to false).</param>

        /// <param name="OcspCacheSize">The size of the in memory OCSP response cache, shared by all configured certs (default to 100).</param>


        public CertificatesWriteConfigRequest(bool DisableBinding = false, bool EnableIdentityAliasMetadata = false, int OcspCacheSize = 100)
        {

            this.DisableBinding = DisableBinding;

            this.EnableIdentityAliasMetadata = EnableIdentityAliasMetadata;

            this.OcspCacheSize = OcspCacheSize;

        }

        /// <summary>
        /// If set, during renewal, skips the matching of presented client identity with the client identity used during login. Defaults to false.
        /// </summary>
        /// <value>If set, during renewal, skips the matching of presented client identity with the client identity used during login. Defaults to false.</value>
        [DataMember(Name = "disable_binding", EmitDefaultValue = true)]


        public bool DisableBinding { get; set; }


        /// <summary>
        /// If set, metadata of the certificate including the metadata corresponding to allowed_metadata_extensions will be stored in the alias. Defaults to false.
        /// </summary>
        /// <value>If set, metadata of the certificate including the metadata corresponding to allowed_metadata_extensions will be stored in the alias. Defaults to false.</value>
        [DataMember(Name = "enable_identity_alias_metadata", EmitDefaultValue = true)]


        public bool EnableIdentityAliasMetadata { get; set; }


        /// <summary>
        /// The size of the in memory OCSP response cache, shared by all configured certs
        /// </summary>
        /// <value>The size of the in memory OCSP response cache, shared by all configured certs</value>
        [DataMember(Name = "ocsp_cache_size", EmitDefaultValue = false)]


        public int OcspCacheSize { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CertificatesWriteConfigRequest {\n");
            sb.Append("  DisableBinding: ").Append(DisableBinding).Append("\n");
            sb.Append("  EnableIdentityAliasMetadata: ").Append(EnableIdentityAliasMetadata).Append("\n");
            sb.Append("  OcspCacheSize: ").Append(OcspCacheSize).Append("\n");
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
            return this.Equals(input as CertificatesWriteConfigRequest);
        }

        /// <summary>
        /// Returns true if CertificatesWriteConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CertificatesWriteConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CertificatesWriteConfigRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.DisableBinding == input.DisableBinding ||

                    this.DisableBinding.Equals(input.DisableBinding)
                ) &&
                (
                    this.EnableIdentityAliasMetadata == input.EnableIdentityAliasMetadata ||

                    this.EnableIdentityAliasMetadata.Equals(input.EnableIdentityAliasMetadata)
                ) &&
                (
                    this.OcspCacheSize == input.OcspCacheSize ||

                    this.OcspCacheSize.Equals(input.OcspCacheSize)
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


                hashCode = (hashCode * 59) + this.DisableBinding.GetHashCode();

                hashCode = (hashCode * 59) + this.EnableIdentityAliasMetadata.GetHashCode();

                hashCode = (hashCode * 59) + this.OcspCacheSize.GetHashCode();
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
