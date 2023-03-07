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
    /// PKIWriteCRLConfigRequest
    /// </summary>
    [DataContract(Name = "PKIWriteCRLConfigRequest")]
    public partial class PKIWriteCRLConfigRequest : IEquatable<PKIWriteCRLConfigRequest>, IValidatableObject
    {



















        /// <summary>
        /// Initializes a new instance of the <see cref="PKIWriteCRLConfigRequest" /> class.
        /// </summary>

        /// <param name="AutoRebuild">If set to true, enables automatic rebuilding of the CRL.</param>

        /// <param name="AutoRebuildGracePeriod">The time before the CRL expires to automatically rebuild it, when enabled. Must be shorter than the CRL expiry. Defaults to 12h. (default to &quot;12h&quot;).</param>

        /// <param name="DeltaRebuildInterval">The time between delta CRL rebuilds if a new revocation has occurred. Must be shorter than the CRL expiry. Defaults to 15m. (default to &quot;15m&quot;).</param>

        /// <param name="Disable">If set to true, disables generating the CRL entirely..</param>

        /// <param name="EnableDelta">Whether to enable delta CRLs between authoritative CRL rebuilds.</param>

        /// <param name="Expiry">The amount of time the generated CRL should be valid; defaults to 72 hours (default to &quot;72h&quot;).</param>

        /// <param name="OcspDisable">If set to true, ocsp unauthorized responses will be returned..</param>

        /// <param name="OcspExpiry">The amount of time an OCSP response will be valid (controls the NextUpdate field); defaults to 12 hours (default to &quot;1h&quot;).</param>


        public PKIWriteCRLConfigRequest(bool AutoRebuild = default(bool), string AutoRebuildGracePeriod = "12h", string DeltaRebuildInterval = "15m", bool Disable = default(bool), bool EnableDelta = default(bool), string Expiry = "72h", bool OcspDisable = default(bool), string OcspExpiry = "1h")
        {

            this.AutoRebuild = AutoRebuild;

            // use default value if no "AutoRebuildGracePeriod" provided
            this.AutoRebuildGracePeriod = AutoRebuildGracePeriod ?? "12h";


            // use default value if no "DeltaRebuildInterval" provided
            this.DeltaRebuildInterval = DeltaRebuildInterval ?? "15m";


            this.Disable = Disable;

            this.EnableDelta = EnableDelta;

            // use default value if no "Expiry" provided
            this.Expiry = Expiry ?? "72h";


            this.OcspDisable = OcspDisable;

            // use default value if no "OcspExpiry" provided
            this.OcspExpiry = OcspExpiry ?? "1h";


        }

        /// <summary>
        /// If set to true, enables automatic rebuilding of the CRL
        /// </summary>
        /// <value>If set to true, enables automatic rebuilding of the CRL</value>
        [DataMember(Name = "auto_rebuild", EmitDefaultValue = true)]


        public bool AutoRebuild { get; set; }


        /// <summary>
        /// The time before the CRL expires to automatically rebuild it, when enabled. Must be shorter than the CRL expiry. Defaults to 12h.
        /// </summary>
        /// <value>The time before the CRL expires to automatically rebuild it, when enabled. Must be shorter than the CRL expiry. Defaults to 12h.</value>
        [DataMember(Name = "auto_rebuild_grace_period", EmitDefaultValue = false)]


        public string AutoRebuildGracePeriod { get; set; }


        /// <summary>
        /// The time between delta CRL rebuilds if a new revocation has occurred. Must be shorter than the CRL expiry. Defaults to 15m.
        /// </summary>
        /// <value>The time between delta CRL rebuilds if a new revocation has occurred. Must be shorter than the CRL expiry. Defaults to 15m.</value>
        [DataMember(Name = "delta_rebuild_interval", EmitDefaultValue = false)]


        public string DeltaRebuildInterval { get; set; }


        /// <summary>
        /// If set to true, disables generating the CRL entirely.
        /// </summary>
        /// <value>If set to true, disables generating the CRL entirely.</value>
        [DataMember(Name = "disable", EmitDefaultValue = true)]


        public bool Disable { get; set; }


        /// <summary>
        /// Whether to enable delta CRLs between authoritative CRL rebuilds
        /// </summary>
        /// <value>Whether to enable delta CRLs between authoritative CRL rebuilds</value>
        [DataMember(Name = "enable_delta", EmitDefaultValue = true)]


        public bool EnableDelta { get; set; }


        /// <summary>
        /// The amount of time the generated CRL should be valid; defaults to 72 hours
        /// </summary>
        /// <value>The amount of time the generated CRL should be valid; defaults to 72 hours</value>
        [DataMember(Name = "expiry", EmitDefaultValue = false)]


        public string Expiry { get; set; }


        /// <summary>
        /// If set to true, ocsp unauthorized responses will be returned.
        /// </summary>
        /// <value>If set to true, ocsp unauthorized responses will be returned.</value>
        [DataMember(Name = "ocsp_disable", EmitDefaultValue = true)]


        public bool OcspDisable { get; set; }


        /// <summary>
        /// The amount of time an OCSP response will be valid (controls the NextUpdate field); defaults to 12 hours
        /// </summary>
        /// <value>The amount of time an OCSP response will be valid (controls the NextUpdate field); defaults to 12 hours</value>
        [DataMember(Name = "ocsp_expiry", EmitDefaultValue = false)]


        public string OcspExpiry { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PKIWriteCRLConfigRequest {\n");
            sb.Append("  AutoRebuild: ").Append(AutoRebuild).Append("\n");
            sb.Append("  AutoRebuildGracePeriod: ").Append(AutoRebuildGracePeriod).Append("\n");
            sb.Append("  DeltaRebuildInterval: ").Append(DeltaRebuildInterval).Append("\n");
            sb.Append("  Disable: ").Append(Disable).Append("\n");
            sb.Append("  EnableDelta: ").Append(EnableDelta).Append("\n");
            sb.Append("  Expiry: ").Append(Expiry).Append("\n");
            sb.Append("  OcspDisable: ").Append(OcspDisable).Append("\n");
            sb.Append("  OcspExpiry: ").Append(OcspExpiry).Append("\n");
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
            return this.Equals(input as PKIWriteCRLConfigRequest);
        }

        /// <summary>
        /// Returns true if PKIWriteCRLConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PKIWriteCRLConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PKIWriteCRLConfigRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AutoRebuild == input.AutoRebuild ||

                    this.AutoRebuild.Equals(input.AutoRebuild)
                ) &&
                (
                    this.AutoRebuildGracePeriod == input.AutoRebuildGracePeriod ||
                    (this.AutoRebuildGracePeriod != null &&
                    this.AutoRebuildGracePeriod.Equals(input.AutoRebuildGracePeriod))

                ) &&
                (
                    this.DeltaRebuildInterval == input.DeltaRebuildInterval ||
                    (this.DeltaRebuildInterval != null &&
                    this.DeltaRebuildInterval.Equals(input.DeltaRebuildInterval))

                ) &&
                (
                    this.Disable == input.Disable ||

                    this.Disable.Equals(input.Disable)
                ) &&
                (
                    this.EnableDelta == input.EnableDelta ||

                    this.EnableDelta.Equals(input.EnableDelta)
                ) &&
                (
                    this.Expiry == input.Expiry ||
                    (this.Expiry != null &&
                    this.Expiry.Equals(input.Expiry))

                ) &&
                (
                    this.OcspDisable == input.OcspDisable ||

                    this.OcspDisable.Equals(input.OcspDisable)
                ) &&
                (
                    this.OcspExpiry == input.OcspExpiry ||
                    (this.OcspExpiry != null &&
                    this.OcspExpiry.Equals(input.OcspExpiry))

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


                hashCode = (hashCode * 59) + this.AutoRebuild.GetHashCode();
                if (this.AutoRebuildGracePeriod != null)
                {
                    hashCode = (hashCode * 59) + this.AutoRebuildGracePeriod.GetHashCode();
                }

                if (this.DeltaRebuildInterval != null)
                {
                    hashCode = (hashCode * 59) + this.DeltaRebuildInterval.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Disable.GetHashCode();

                hashCode = (hashCode * 59) + this.EnableDelta.GetHashCode();
                if (this.Expiry != null)
                {
                    hashCode = (hashCode * 59) + this.Expiry.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.OcspDisable.GetHashCode();
                if (this.OcspExpiry != null)
                {
                    hashCode = (hashCode * 59) + this.OcspExpiry.GetHashCode();
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
