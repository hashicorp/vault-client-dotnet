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
    /// PkiSignWithRoleRequest
    /// </summary>
    [DataContract(Name = "PkiSignWithRoleRequest")]
    public partial class PkiSignWithRoleRequest : IEquatable<PkiSignWithRoleRequest>, IValidatableObject
    {        /// <summary>
             /// Format for returned data. Can be \&quot;pem\&quot;, \&quot;der\&quot;, or \&quot;pem_bundle\&quot;. If \&quot;pem_bundle\&quot;, any private key and issuing cert will be appended to the certificate pem. If \&quot;der\&quot;, the value will be base64 encoded. Defaults to \&quot;pem\&quot;.
             /// </summary>
             /// <value>Format for returned data. Can be \&quot;pem\&quot;, \&quot;der\&quot;, or \&quot;pem_bundle\&quot;. If \&quot;pem_bundle\&quot;, any private key and issuing cert will be appended to the certificate pem. If \&quot;der\&quot;, the value will be base64 encoded. Defaults to \&quot;pem\&quot;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatEnum
        {

            /// <summary>
            /// Enum Pem for value: pem
            /// </summary>
            [EnumMember(Value = "pem")]
            Pem = 0,
            /// <summary>
            /// Enum Der for value: der
            /// </summary>
            [EnumMember(Value = "der")]
            Der = 1,
            /// <summary>
            /// Enum PemBundle for value: pem_bundle
            /// </summary>
            [EnumMember(Value = "pem_bundle")]
            PemBundle = 2
        }
        /// <summary>
        /// Format for returned data. Can be \&quot;pem\&quot;, \&quot;der\&quot;, or \&quot;pem_bundle\&quot;. If \&quot;pem_bundle\&quot;, any private key and issuing cert will be appended to the certificate pem. If \&quot;der\&quot;, the value will be base64 encoded. Defaults to \&quot;pem\&quot;.
        /// </summary>
        /// <value>Format for returned data. Can be \&quot;pem\&quot;, \&quot;der\&quot;, or \&quot;pem_bundle\&quot;. If \&quot;pem_bundle\&quot;, any private key and issuing cert will be appended to the certificate pem. If \&quot;der\&quot;, the value will be base64 encoded. Defaults to \&quot;pem\&quot;.</value>

        [DataMember(Name = "format", EmitDefaultValue = false)]
        public FormatEnum? Format { get; set; }

        /// <summary>
        /// Format for the returned private key. Generally the default will be controlled by the \&quot;format\&quot; parameter as either base64-encoded DER or PEM-encoded DER. However, this can be set to \&quot;pkcs8\&quot; to have the returned private key contain base64-encoded pkcs8 or PEM-encoded pkcs8 instead. Defaults to \&quot;der\&quot;.
        /// </summary>
        /// <value>Format for the returned private key. Generally the default will be controlled by the \&quot;format\&quot; parameter as either base64-encoded DER or PEM-encoded DER. However, this can be set to \&quot;pkcs8\&quot; to have the returned private key contain base64-encoded pkcs8 or PEM-encoded pkcs8 instead. Defaults to \&quot;der\&quot;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PrivateKeyFormatEnum
        {

            /// <summary>
            /// Enum Empty for value: 
            /// </summary>
            [EnumMember(Value = "")]
            Empty = 0,
            /// <summary>
            /// Enum Der for value: der
            /// </summary>
            [EnumMember(Value = "der")]
            Der = 1,
            /// <summary>
            /// Enum Pem for value: pem
            /// </summary>
            [EnumMember(Value = "pem")]
            Pem = 2,
            /// <summary>
            /// Enum Pkcs8 for value: pkcs8
            /// </summary>
            [EnumMember(Value = "pkcs8")]
            Pkcs8 = 3
        }
        /// <summary>
        /// Format for the returned private key. Generally the default will be controlled by the \&quot;format\&quot; parameter as either base64-encoded DER or PEM-encoded DER. However, this can be set to \&quot;pkcs8\&quot; to have the returned private key contain base64-encoded pkcs8 or PEM-encoded pkcs8 instead. Defaults to \&quot;der\&quot;.
        /// </summary>
        /// <value>Format for the returned private key. Generally the default will be controlled by the \&quot;format\&quot; parameter as either base64-encoded DER or PEM-encoded DER. However, this can be set to \&quot;pkcs8\&quot; to have the returned private key contain base64-encoded pkcs8 or PEM-encoded pkcs8 instead. Defaults to \&quot;der\&quot;.</value>

        [DataMember(Name = "private_key_format", EmitDefaultValue = false)]
        public PrivateKeyFormatEnum? PrivateKeyFormat { get; set; }




        /// <summary>
        /// Initializes a new instance of the <see cref="PkiSignWithRoleRequest" /> class.
        /// </summary>

        /// <param name="AltNames">The requested Subject Alternative Names, if any, in a comma-delimited list. If email protection is enabled for the role, this may contain email addresses..</param>

        /// <param name="CommonName">The requested common name; if you want more than one, specify the alternative names in the alt_names map. If email protection is enabled in the role, this may be an email address..</param>

        /// <param name="Csr">PEM-format CSR to be signed. (default to &quot;&quot;).</param>

        /// <param name="ExcludeCnFromSans">If true, the Common Name will not be included in DNS or Email Subject Alternate Names. Defaults to false (CN is included). (default to false).</param>

        /// <param name="Format">Format for returned data. Can be \&quot;pem\&quot;, \&quot;der\&quot;, or \&quot;pem_bundle\&quot;. If \&quot;pem_bundle\&quot;, any private key and issuing cert will be appended to the certificate pem. If \&quot;der\&quot;, the value will be base64 encoded. Defaults to \&quot;pem\&quot;. (default to FormatEnum.Pem).</param>

        /// <param name="IpSans">The requested IP SANs, if any, in a comma-delimited list.</param>

        /// <param name="IssuerRef">Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. (default to &quot;default&quot;).</param>

        /// <param name="NotAfter">Set the not after field of the certificate with specified date value. The value format should be given in UTC format YYYY-MM-ddTHH:MM:SSZ.</param>

        /// <param name="OtherSans">Requested other SANs, in an array with the format &lt;oid&gt;;UTF8:&lt;utf8 string value&gt; for each entry..</param>

        /// <param name="PrivateKeyFormat">Format for the returned private key. Generally the default will be controlled by the \&quot;format\&quot; parameter as either base64-encoded DER or PEM-encoded DER. However, this can be set to \&quot;pkcs8\&quot; to have the returned private key contain base64-encoded pkcs8 or PEM-encoded pkcs8 instead. Defaults to \&quot;der\&quot;. (default to PrivateKeyFormatEnum.Der).</param>

        /// <param name="RemoveRootsFromChain">Whether or not to remove self-signed CA certificates in the output of the ca_chain field. (default to false).</param>

        /// <param name="SerialNumber">The Subject&#x27;s requested serial number, if any. See RFC 4519 Section 2.31 &#x27;serialNumber&#x27; for a description of this field. If you want more than one, specify alternative names in the alt_names map using OID 2.5.4.5. This has no impact on the final certificate&#x27;s Serial Number field..</param>

        /// <param name="Ttl">The requested Time To Live for the certificate; sets the expiration date. If not specified the role default, backend default, or system default TTL is used, in that order. Cannot be larger than the role max TTL..</param>

        /// <param name="UriSans">The requested URI SANs, if any, in a comma-delimited list..</param>

        /// <param name="UserIds">The requested user_ids value to place in the subject, if any, in a comma-delimited list. Restricted by allowed_user_ids. Any values are added with OID 0.9.2342.19200300.100.1.1..</param>


        public PkiSignWithRoleRequest(string AltNames = default(string), string CommonName = default(string), string Csr = "", bool ExcludeCnFromSans = false, FormatEnum? Format = FormatEnum.Pem, List<string> IpSans = default(List<string>), string IssuerRef = "default", string NotAfter = default(string), List<string> OtherSans = default(List<string>), PrivateKeyFormatEnum? PrivateKeyFormat = PrivateKeyFormatEnum.Der, bool RemoveRootsFromChain = false, string SerialNumber = default(string), string Ttl = default(string), List<string> UriSans = default(List<string>), List<string> UserIds = default(List<string>))
        {

            this.AltNames = AltNames;

            this.CommonName = CommonName;

            // use default value if no "Csr" provided
            this.Csr = Csr ?? "";


            this.ExcludeCnFromSans = ExcludeCnFromSans;

            this.Format = Format;

            this.IpSans = IpSans;

            // use default value if no "IssuerRef" provided
            this.IssuerRef = IssuerRef ?? "default";


            this.NotAfter = NotAfter;

            this.OtherSans = OtherSans;

            this.PrivateKeyFormat = PrivateKeyFormat;

            this.RemoveRootsFromChain = RemoveRootsFromChain;

            this.SerialNumber = SerialNumber;

            this.Ttl = Ttl;

            this.UriSans = UriSans;

            this.UserIds = UserIds;

        }

        /// <summary>
        /// The requested Subject Alternative Names, if any, in a comma-delimited list. If email protection is enabled for the role, this may contain email addresses.
        /// </summary>
        /// <value>The requested Subject Alternative Names, if any, in a comma-delimited list. If email protection is enabled for the role, this may contain email addresses.</value>
        [DataMember(Name = "alt_names", EmitDefaultValue = false)]

        public string AltNames { get; set; }


        /// <summary>
        /// The requested common name; if you want more than one, specify the alternative names in the alt_names map. If email protection is enabled in the role, this may be an email address.
        /// </summary>
        /// <value>The requested common name; if you want more than one, specify the alternative names in the alt_names map. If email protection is enabled in the role, this may be an email address.</value>
        [DataMember(Name = "common_name", EmitDefaultValue = false)]

        public string CommonName { get; set; }


        /// <summary>
        /// PEM-format CSR to be signed.
        /// </summary>
        /// <value>PEM-format CSR to be signed.</value>
        [DataMember(Name = "csr", EmitDefaultValue = false)]

        public string Csr { get; set; }


        /// <summary>
        /// If true, the Common Name will not be included in DNS or Email Subject Alternate Names. Defaults to false (CN is included).
        /// </summary>
        /// <value>If true, the Common Name will not be included in DNS or Email Subject Alternate Names. Defaults to false (CN is included).</value>
        [DataMember(Name = "exclude_cn_from_sans", EmitDefaultValue = true)]

        public bool ExcludeCnFromSans { get; set; }


        /// <summary>
        /// The requested IP SANs, if any, in a comma-delimited list
        /// </summary>
        /// <value>The requested IP SANs, if any, in a comma-delimited list</value>
        [DataMember(Name = "ip_sans", EmitDefaultValue = false)]

        public List<string> IpSans { get; set; }


        /// <summary>
        /// Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer.
        /// </summary>
        /// <value>Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer.</value>
        [DataMember(Name = "issuer_ref", EmitDefaultValue = false)]

        public string IssuerRef { get; set; }


        /// <summary>
        /// Set the not after field of the certificate with specified date value. The value format should be given in UTC format YYYY-MM-ddTHH:MM:SSZ
        /// </summary>
        /// <value>Set the not after field of the certificate with specified date value. The value format should be given in UTC format YYYY-MM-ddTHH:MM:SSZ</value>
        [DataMember(Name = "not_after", EmitDefaultValue = false)]

        public string NotAfter { get; set; }


        /// <summary>
        /// Requested other SANs, in an array with the format &lt;oid&gt;;UTF8:&lt;utf8 string value&gt; for each entry.
        /// </summary>
        /// <value>Requested other SANs, in an array with the format &lt;oid&gt;;UTF8:&lt;utf8 string value&gt; for each entry.</value>
        [DataMember(Name = "other_sans", EmitDefaultValue = false)]

        public List<string> OtherSans { get; set; }


        /// <summary>
        /// Whether or not to remove self-signed CA certificates in the output of the ca_chain field.
        /// </summary>
        /// <value>Whether or not to remove self-signed CA certificates in the output of the ca_chain field.</value>
        [DataMember(Name = "remove_roots_from_chain", EmitDefaultValue = true)]

        public bool RemoveRootsFromChain { get; set; }


        /// <summary>
        /// The Subject&#x27;s requested serial number, if any. See RFC 4519 Section 2.31 &#x27;serialNumber&#x27; for a description of this field. If you want more than one, specify alternative names in the alt_names map using OID 2.5.4.5. This has no impact on the final certificate&#x27;s Serial Number field.
        /// </summary>
        /// <value>The Subject&#x27;s requested serial number, if any. See RFC 4519 Section 2.31 &#x27;serialNumber&#x27; for a description of this field. If you want more than one, specify alternative names in the alt_names map using OID 2.5.4.5. This has no impact on the final certificate&#x27;s Serial Number field.</value>
        [DataMember(Name = "serial_number", EmitDefaultValue = false)]

        public string SerialNumber { get; set; }


        /// <summary>
        /// The requested Time To Live for the certificate; sets the expiration date. If not specified the role default, backend default, or system default TTL is used, in that order. Cannot be larger than the role max TTL.
        /// </summary>
        /// <value>The requested Time To Live for the certificate; sets the expiration date. If not specified the role default, backend default, or system default TTL is used, in that order. Cannot be larger than the role max TTL.</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]

        public string Ttl { get; set; }


        /// <summary>
        /// The requested URI SANs, if any, in a comma-delimited list.
        /// </summary>
        /// <value>The requested URI SANs, if any, in a comma-delimited list.</value>
        [DataMember(Name = "uri_sans", EmitDefaultValue = false)]

        public List<string> UriSans { get; set; }


        /// <summary>
        /// The requested user_ids value to place in the subject, if any, in a comma-delimited list. Restricted by allowed_user_ids. Any values are added with OID 0.9.2342.19200300.100.1.1.
        /// </summary>
        /// <value>The requested user_ids value to place in the subject, if any, in a comma-delimited list. Restricted by allowed_user_ids. Any values are added with OID 0.9.2342.19200300.100.1.1.</value>
        [DataMember(Name = "user_ids", EmitDefaultValue = false)]

        public List<string> UserIds { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiSignWithRoleRequest {\n");
            sb.Append("  AltNames: ").Append(AltNames).Append("\n");
            sb.Append("  CommonName: ").Append(CommonName).Append("\n");
            sb.Append("  Csr: ").Append(Csr).Append("\n");
            sb.Append("  ExcludeCnFromSans: ").Append(ExcludeCnFromSans).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  IpSans: ").Append(IpSans).Append("\n");
            sb.Append("  IssuerRef: ").Append(IssuerRef).Append("\n");
            sb.Append("  NotAfter: ").Append(NotAfter).Append("\n");
            sb.Append("  OtherSans: ").Append(OtherSans).Append("\n");
            sb.Append("  PrivateKeyFormat: ").Append(PrivateKeyFormat).Append("\n");
            sb.Append("  RemoveRootsFromChain: ").Append(RemoveRootsFromChain).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
            sb.Append("  UriSans: ").Append(UriSans).Append("\n");
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
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
            return this.Equals(input as PkiSignWithRoleRequest);
        }

        /// <summary>
        /// Returns true if PkiSignWithRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiSignWithRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiSignWithRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AltNames == input.AltNames ||
                    (this.AltNames != null &&
                    this.AltNames.Equals(input.AltNames))

                ) &&
                (
                    this.CommonName == input.CommonName ||
                    (this.CommonName != null &&
                    this.CommonName.Equals(input.CommonName))

                ) &&
                (
                    this.Csr == input.Csr ||
                    (this.Csr != null &&
                    this.Csr.Equals(input.Csr))

                ) &&
                (
                    this.ExcludeCnFromSans == input.ExcludeCnFromSans ||

                    this.ExcludeCnFromSans.Equals(input.ExcludeCnFromSans)
                ) &&
                (
                    this.Format == input.Format ||

                    this.Format.Equals(input.Format)
                ) &&
                (
                    this.IpSans == input.IpSans ||
                    this.IpSans != null &&
                    input.IpSans != null &&
                    this.IpSans.SequenceEqual(input.IpSans)
                ) &&
                (
                    this.IssuerRef == input.IssuerRef ||
                    (this.IssuerRef != null &&
                    this.IssuerRef.Equals(input.IssuerRef))

                ) &&
                (
                    this.NotAfter == input.NotAfter ||
                    (this.NotAfter != null &&
                    this.NotAfter.Equals(input.NotAfter))

                ) &&
                (
                    this.OtherSans == input.OtherSans ||
                    this.OtherSans != null &&
                    input.OtherSans != null &&
                    this.OtherSans.SequenceEqual(input.OtherSans)
                ) &&
                (
                    this.PrivateKeyFormat == input.PrivateKeyFormat ||

                    this.PrivateKeyFormat.Equals(input.PrivateKeyFormat)
                ) &&
                (
                    this.RemoveRootsFromChain == input.RemoveRootsFromChain ||

                    this.RemoveRootsFromChain.Equals(input.RemoveRootsFromChain)
                ) &&
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))

                ) &&
                (
                    this.Ttl == input.Ttl ||
                    (this.Ttl != null &&
                    this.Ttl.Equals(input.Ttl))

                ) &&
                (
                    this.UriSans == input.UriSans ||
                    this.UriSans != null &&
                    input.UriSans != null &&
                    this.UriSans.SequenceEqual(input.UriSans)
                ) &&
                (
                    this.UserIds == input.UserIds ||
                    this.UserIds != null &&
                    input.UserIds != null &&
                    this.UserIds.SequenceEqual(input.UserIds)
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

                if (this.AltNames != null)
                {
                    hashCode = (hashCode * 59) + this.AltNames.GetHashCode();
                }

                if (this.CommonName != null)
                {
                    hashCode = (hashCode * 59) + this.CommonName.GetHashCode();
                }

                if (this.Csr != null)
                {
                    hashCode = (hashCode * 59) + this.Csr.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.ExcludeCnFromSans.GetHashCode();

                hashCode = (hashCode * 59) + this.Format.GetHashCode();
                if (this.IpSans != null)
                {
                    hashCode = (hashCode * 59) + this.IpSans.GetHashCode();
                }

                if (this.IssuerRef != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerRef.GetHashCode();
                }

                if (this.NotAfter != null)
                {
                    hashCode = (hashCode * 59) + this.NotAfter.GetHashCode();
                }

                if (this.OtherSans != null)
                {
                    hashCode = (hashCode * 59) + this.OtherSans.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.PrivateKeyFormat.GetHashCode();

                hashCode = (hashCode * 59) + this.RemoveRootsFromChain.GetHashCode();
                if (this.SerialNumber != null)
                {
                    hashCode = (hashCode * 59) + this.SerialNumber.GetHashCode();
                }

                if (this.Ttl != null)
                {
                    hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
                }

                if (this.UriSans != null)
                {
                    hashCode = (hashCode * 59) + this.UriSans.GetHashCode();
                }

                if (this.UserIds != null)
                {
                    hashCode = (hashCode * 59) + this.UserIds.GetHashCode();
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
