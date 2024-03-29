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
    /// PkiIssuerResignCrlsRequest
    /// </summary>
    [DataContract(Name = "PkiIssuerResignCrlsRequest")]
    public partial class PkiIssuerResignCrlsRequest : IEquatable<PkiIssuerResignCrlsRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PkiIssuerResignCrlsRequest" /> class.
        /// </summary>

        /// <param name="CrlNumber">The sequence number to be written within the CRL Number extension..</param>

        /// <param name="Crls">A list of PEM encoded CRLs to combine, originally signed by the requested issuer..</param>

        /// <param name="DeltaCrlBaseNumber">Using a zero or greater value specifies the base CRL revision number to encode within a Delta CRL indicator extension, otherwise the extension will not be added. (default to -1).</param>

        /// <param name="Format">The format of the combined CRL, can be \&quot;pem\&quot; or \&quot;der\&quot;. If \&quot;der\&quot;, the value will be base64 encoded. Defaults to \&quot;pem\&quot;. (default to &quot;pem&quot;).</param>

        /// <param name="NextUpdate">The amount of time the generated CRL should be valid; defaults to 72 hours. (default to &quot;72h&quot;).</param>


        public PkiIssuerResignCrlsRequest(int CrlNumber = default(int), List<string> Crls = default(List<string>), int DeltaCrlBaseNumber = -1, string Format = "pem", string NextUpdate = "72h")
        {

            this.CrlNumber = CrlNumber;

            this.Crls = Crls;

            this.DeltaCrlBaseNumber = DeltaCrlBaseNumber;

            // use default value if no "Format" provided
            this.Format = Format ?? "pem";


            // use default value if no "NextUpdate" provided
            this.NextUpdate = NextUpdate ?? "72h";


        }

        /// <summary>
        /// The sequence number to be written within the CRL Number extension.
        /// </summary>
        /// <value>The sequence number to be written within the CRL Number extension.</value>
        [DataMember(Name = "crl_number", EmitDefaultValue = false)]

        public int CrlNumber { get; set; }


        /// <summary>
        /// A list of PEM encoded CRLs to combine, originally signed by the requested issuer.
        /// </summary>
        /// <value>A list of PEM encoded CRLs to combine, originally signed by the requested issuer.</value>
        [DataMember(Name = "crls", EmitDefaultValue = false)]

        public List<string> Crls { get; set; }


        /// <summary>
        /// Using a zero or greater value specifies the base CRL revision number to encode within a Delta CRL indicator extension, otherwise the extension will not be added.
        /// </summary>
        /// <value>Using a zero or greater value specifies the base CRL revision number to encode within a Delta CRL indicator extension, otherwise the extension will not be added.</value>
        [DataMember(Name = "delta_crl_base_number", EmitDefaultValue = false)]

        public int DeltaCrlBaseNumber { get; set; }


        /// <summary>
        /// The format of the combined CRL, can be \&quot;pem\&quot; or \&quot;der\&quot;. If \&quot;der\&quot;, the value will be base64 encoded. Defaults to \&quot;pem\&quot;.
        /// </summary>
        /// <value>The format of the combined CRL, can be \&quot;pem\&quot; or \&quot;der\&quot;. If \&quot;der\&quot;, the value will be base64 encoded. Defaults to \&quot;pem\&quot;.</value>
        [DataMember(Name = "format", EmitDefaultValue = false)]

        public string Format { get; set; }


        /// <summary>
        /// The amount of time the generated CRL should be valid; defaults to 72 hours.
        /// </summary>
        /// <value>The amount of time the generated CRL should be valid; defaults to 72 hours.</value>
        [DataMember(Name = "next_update", EmitDefaultValue = false)]

        public string NextUpdate { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiIssuerResignCrlsRequest {\n");
            sb.Append("  CrlNumber: ").Append(CrlNumber).Append("\n");
            sb.Append("  Crls: ").Append(Crls).Append("\n");
            sb.Append("  DeltaCrlBaseNumber: ").Append(DeltaCrlBaseNumber).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  NextUpdate: ").Append(NextUpdate).Append("\n");
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
            return this.Equals(input as PkiIssuerResignCrlsRequest);
        }

        /// <summary>
        /// Returns true if PkiIssuerResignCrlsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiIssuerResignCrlsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiIssuerResignCrlsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.CrlNumber == input.CrlNumber ||

                    this.CrlNumber.Equals(input.CrlNumber)
                ) &&
                (
                    this.Crls == input.Crls ||
                    this.Crls != null &&
                    input.Crls != null &&
                    this.Crls.SequenceEqual(input.Crls)
                ) &&
                (
                    this.DeltaCrlBaseNumber == input.DeltaCrlBaseNumber ||

                    this.DeltaCrlBaseNumber.Equals(input.DeltaCrlBaseNumber)
                ) &&
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))

                ) &&
                (
                    this.NextUpdate == input.NextUpdate ||
                    (this.NextUpdate != null &&
                    this.NextUpdate.Equals(input.NextUpdate))

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


                hashCode = (hashCode * 59) + this.CrlNumber.GetHashCode();
                if (this.Crls != null)
                {
                    hashCode = (hashCode * 59) + this.Crls.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.DeltaCrlBaseNumber.GetHashCode();
                if (this.Format != null)
                {
                    hashCode = (hashCode * 59) + this.Format.GetHashCode();
                }

                if (this.NextUpdate != null)
                {
                    hashCode = (hashCode * 59) + this.NextUpdate.GetHashCode();
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
