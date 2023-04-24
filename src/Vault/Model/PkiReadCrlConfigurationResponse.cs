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
    /// PkiReadCrlConfigurationResponse
    /// </summary>
    [DataContract(Name = "PkiReadCrlConfigurationResponse")]
    public partial class PkiReadCrlConfigurationResponse : IEquatable<PkiReadCrlConfigurationResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PkiReadCrlConfigurationResponse" /> class.
        /// </summary>

        /// <param name="AutoRebuild">If set to true, enables automatic rebuilding of the CRL.</param>

        /// <param name="AutoRebuildGracePeriod">The time before the CRL expires to automatically rebuild it, when enabled. Must be shorter than the CRL expiry. Defaults to 12h..</param>

        /// <param name="CrossClusterRevocation">Whether to enable a global, cross-cluster revocation queue. Must be used with auto_rebuild&#x3D;true..</param>

        /// <param name="DeltaRebuildInterval">The time between delta CRL rebuilds if a new revocation has occurred. Must be shorter than the CRL expiry. Defaults to 15m..</param>

        /// <param name="Disable">If set to true, disables generating the CRL entirely..</param>

        /// <param name="EnableDelta">Whether to enable delta CRLs between authoritative CRL rebuilds.</param>

        /// <param name="Expiry">The amount of time the generated CRL should be valid; defaults to 72 hours.</param>

        /// <param name="OcspDisable">If set to true, ocsp unauthorized responses will be returned..</param>

        /// <param name="OcspExpiry">The amount of time an OCSP response will be valid (controls the NextUpdate field); defaults to 12 hours.</param>

        /// <param name="UnifiedCrl">If set to true enables global replication of revocation entries, also enabling unified versions of OCSP and CRLs if their respective features are enabled. disable for CRLs and ocsp_disable for OCSP..</param>

        /// <param name="UnifiedCrlOnExistingPaths">If set to true, existing CRL and OCSP paths will return the unified CRL instead of a response based on cluster-local data.</param>


        public PkiReadCrlConfigurationResponse(bool AutoRebuild = default(bool), string AutoRebuildGracePeriod = default(string), bool CrossClusterRevocation = default(bool), string DeltaRebuildInterval = default(string), bool Disable = default(bool), bool EnableDelta = default(bool), string Expiry = default(string), bool OcspDisable = default(bool), string OcspExpiry = default(string), bool UnifiedCrl = default(bool), bool UnifiedCrlOnExistingPaths = default(bool))
        {

            this.AutoRebuild = AutoRebuild;

            this.AutoRebuildGracePeriod = AutoRebuildGracePeriod;

            this.CrossClusterRevocation = CrossClusterRevocation;

            this.DeltaRebuildInterval = DeltaRebuildInterval;

            this.Disable = Disable;

            this.EnableDelta = EnableDelta;

            this.Expiry = Expiry;

            this.OcspDisable = OcspDisable;

            this.OcspExpiry = OcspExpiry;

            this.UnifiedCrl = UnifiedCrl;

            this.UnifiedCrlOnExistingPaths = UnifiedCrlOnExistingPaths;

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
        /// Whether to enable a global, cross-cluster revocation queue. Must be used with auto_rebuild&#x3D;true.
        /// </summary>
        /// <value>Whether to enable a global, cross-cluster revocation queue. Must be used with auto_rebuild&#x3D;true.</value>
        [DataMember(Name = "cross_cluster_revocation", EmitDefaultValue = true)]

        public bool CrossClusterRevocation { get; set; }


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
        /// If set to true enables global replication of revocation entries, also enabling unified versions of OCSP and CRLs if their respective features are enabled. disable for CRLs and ocsp_disable for OCSP.
        /// </summary>
        /// <value>If set to true enables global replication of revocation entries, also enabling unified versions of OCSP and CRLs if their respective features are enabled. disable for CRLs and ocsp_disable for OCSP.</value>
        [DataMember(Name = "unified_crl", EmitDefaultValue = true)]

        public bool UnifiedCrl { get; set; }


        /// <summary>
        /// If set to true, existing CRL and OCSP paths will return the unified CRL instead of a response based on cluster-local data
        /// </summary>
        /// <value>If set to true, existing CRL and OCSP paths will return the unified CRL instead of a response based on cluster-local data</value>
        [DataMember(Name = "unified_crl_on_existing_paths", EmitDefaultValue = true)]

        public bool UnifiedCrlOnExistingPaths { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiReadCrlConfigurationResponse {\n");
            sb.Append("  AutoRebuild: ").Append(AutoRebuild).Append("\n");
            sb.Append("  AutoRebuildGracePeriod: ").Append(AutoRebuildGracePeriod).Append("\n");
            sb.Append("  CrossClusterRevocation: ").Append(CrossClusterRevocation).Append("\n");
            sb.Append("  DeltaRebuildInterval: ").Append(DeltaRebuildInterval).Append("\n");
            sb.Append("  Disable: ").Append(Disable).Append("\n");
            sb.Append("  EnableDelta: ").Append(EnableDelta).Append("\n");
            sb.Append("  Expiry: ").Append(Expiry).Append("\n");
            sb.Append("  OcspDisable: ").Append(OcspDisable).Append("\n");
            sb.Append("  OcspExpiry: ").Append(OcspExpiry).Append("\n");
            sb.Append("  UnifiedCrl: ").Append(UnifiedCrl).Append("\n");
            sb.Append("  UnifiedCrlOnExistingPaths: ").Append(UnifiedCrlOnExistingPaths).Append("\n");
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
            return this.Equals(input as PkiReadCrlConfigurationResponse);
        }

        /// <summary>
        /// Returns true if PkiReadCrlConfigurationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiReadCrlConfigurationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiReadCrlConfigurationResponse input)
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
                    this.CrossClusterRevocation == input.CrossClusterRevocation ||

                    this.CrossClusterRevocation.Equals(input.CrossClusterRevocation)
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

                ) &&
                (
                    this.UnifiedCrl == input.UnifiedCrl ||

                    this.UnifiedCrl.Equals(input.UnifiedCrl)
                ) &&
                (
                    this.UnifiedCrlOnExistingPaths == input.UnifiedCrlOnExistingPaths ||

                    this.UnifiedCrlOnExistingPaths.Equals(input.UnifiedCrlOnExistingPaths)
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


                hashCode = (hashCode * 59) + this.CrossClusterRevocation.GetHashCode();
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


                hashCode = (hashCode * 59) + this.UnifiedCrl.GetHashCode();

                hashCode = (hashCode * 59) + this.UnifiedCrlOnExistingPaths.GetHashCode();
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
