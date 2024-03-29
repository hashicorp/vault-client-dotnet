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
    /// AwsConfigureCertificateRequest
    /// </summary>
    [DataContract(Name = "AwsConfigureCertificateRequest")]
    public partial class AwsConfigureCertificateRequest : IEquatable<AwsConfigureCertificateRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="AwsConfigureCertificateRequest" /> class.
        /// </summary>

        /// <param name="AwsPublicCert">Base64 encoded AWS Public cert required to verify PKCS7 signature of the EC2 instance metadata..</param>

        /// <param name="Type">Takes the value of either \&quot;pkcs7\&quot; or \&quot;identity\&quot;, indicating the type of document which can be verified using the given certificate. The reason is that the PKCS#7 document will have a DSA digest and the identity signature will have an RSA signature, and accordingly the public certificates to verify those also vary. Defaults to \&quot;pkcs7\&quot;. (default to &quot;pkcs7&quot;).</param>


        public AwsConfigureCertificateRequest(string AwsPublicCert = default(string), string Type = "pkcs7")
        {

            this.AwsPublicCert = AwsPublicCert;

            // use default value if no "Type" provided
            this.Type = Type ?? "pkcs7";


        }

        /// <summary>
        /// Base64 encoded AWS Public cert required to verify PKCS7 signature of the EC2 instance metadata.
        /// </summary>
        /// <value>Base64 encoded AWS Public cert required to verify PKCS7 signature of the EC2 instance metadata.</value>
        [DataMember(Name = "aws_public_cert", EmitDefaultValue = false)]

        public string AwsPublicCert { get; set; }


        /// <summary>
        /// Takes the value of either \&quot;pkcs7\&quot; or \&quot;identity\&quot;, indicating the type of document which can be verified using the given certificate. The reason is that the PKCS#7 document will have a DSA digest and the identity signature will have an RSA signature, and accordingly the public certificates to verify those also vary. Defaults to \&quot;pkcs7\&quot;.
        /// </summary>
        /// <value>Takes the value of either \&quot;pkcs7\&quot; or \&quot;identity\&quot;, indicating the type of document which can be verified using the given certificate. The reason is that the PKCS#7 document will have a DSA digest and the identity signature will have an RSA signature, and accordingly the public certificates to verify those also vary. Defaults to \&quot;pkcs7\&quot;.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]

        public string Type { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AwsConfigureCertificateRequest {\n");
            sb.Append("  AwsPublicCert: ").Append(AwsPublicCert).Append("\n");
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
            return this.Equals(input as AwsConfigureCertificateRequest);
        }

        /// <summary>
        /// Returns true if AwsConfigureCertificateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AwsConfigureCertificateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AwsConfigureCertificateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AwsPublicCert == input.AwsPublicCert ||
                    (this.AwsPublicCert != null &&
                    this.AwsPublicCert.Equals(input.AwsPublicCert))

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

                if (this.AwsPublicCert != null)
                {
                    hashCode = (hashCode * 59) + this.AwsPublicCert.GetHashCode();
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
