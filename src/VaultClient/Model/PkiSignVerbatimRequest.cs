/*
 * HashiCorp Vault API
 *
 * HTTP API that gives you full access to Vault. All API routes are prefixed with `/v1/`.
 *
 * The version of the OpenAPI document: 1.12.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


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
using FileParameter = VaultClient.Client.FileParameter;
using OpenAPIDateConverter = VaultClient.Client.OpenAPIDateConverter;

namespace VaultClient.Model
{
    /// <summary>
    /// PkiSignVerbatimRequest
    /// </summary>
    [DataContract(Name = "PkiSignVerbatimRequest")]
    public partial class PkiSignVerbatimRequest : IEquatable<PkiSignVerbatimRequest>, IValidatableObject
    {
        /// <summary>
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
            Pem = 1,

            /// <summary>
            /// Enum Der for value: der
            /// </summary>
            [EnumMember(Value = "der")]
            Der = 2,

            /// <summary>
            /// Enum PemBundle for value: pem_bundle
            /// </summary>
            [EnumMember(Value = "pem_bundle")]
            PemBundle = 3

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
            Empty = 1,

            /// <summary>
            /// Enum Der for value: der
            /// </summary>
            [EnumMember(Value = "der")]
            Der = 2,

            /// <summary>
            /// Enum Pem for value: pem
            /// </summary>
            [EnumMember(Value = "pem")]
            Pem = 3,

            /// <summary>
            /// Enum Pkcs8 for value: pkcs8
            /// </summary>
            [EnumMember(Value = "pkcs8")]
            Pkcs8 = 4

        }


        /// <summary>
        /// Format for the returned private key. Generally the default will be controlled by the \&quot;format\&quot; parameter as either base64-encoded DER or PEM-encoded DER. However, this can be set to \&quot;pkcs8\&quot; to have the returned private key contain base64-encoded pkcs8 or PEM-encoded pkcs8 instead. Defaults to \&quot;der\&quot;.
        /// </summary>
        /// <value>Format for the returned private key. Generally the default will be controlled by the \&quot;format\&quot; parameter as either base64-encoded DER or PEM-encoded DER. However, this can be set to \&quot;pkcs8\&quot; to have the returned private key contain base64-encoded pkcs8 or PEM-encoded pkcs8 instead. Defaults to \&quot;der\&quot;.</value>
        [DataMember(Name = "private_key_format", EmitDefaultValue = false)]
        public PrivateKeyFormatEnum? PrivateKeyFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PkiSignVerbatimRequest" /> class.
        /// </summary>
        /// <param name="altNames">The requested Subject Alternative Names, if any, in a comma-delimited list. If email protection is enabled for the role, this may contain email addresses..</param>
        /// <param name="commonName">The requested common name; if you want more than one, specify the alternative names in the alt_names map. If email protection is enabled in the role, this may be an email address..</param>
        /// <param name="csr">PEM-format CSR to be signed. Values will be taken verbatim from the CSR, except for basic constraints. (default to &quot;&quot;).</param>
        /// <param name="excludeCnFromSans">If true, the Common Name will not be included in DNS or Email Subject Alternate Names. Defaults to false (CN is included). (default to false).</param>
        /// <param name="extKeyUsage">A comma-separated string or list of extended key usages. Valid values can be found at https://golang.org/pkg/crypto/x509/#ExtKeyUsage - - simply drop the \&quot;ExtKeyUsage\&quot; part of the name. To remove all key usages from being set, set this value to an empty list..</param>
        /// <param name="extKeyUsageOids">A comma-separated string or list of extended key usage oids..</param>
        /// <param name="format">Format for returned data. Can be \&quot;pem\&quot;, \&quot;der\&quot;, or \&quot;pem_bundle\&quot;. If \&quot;pem_bundle\&quot;, any private key and issuing cert will be appended to the certificate pem. If \&quot;der\&quot;, the value will be base64 encoded. Defaults to \&quot;pem\&quot;. (default to FormatEnum.Pem).</param>
        /// <param name="ipSans">The requested IP SANs, if any, in a comma-delimited list.</param>
        /// <param name="issuerRef">Reference to a existing issuer; either \&quot;default\&quot; for the configured default issuer, an identifier or the name assigned to the issuer. (default to &quot;default&quot;).</param>
        /// <param name="keyUsage">A comma-separated string or list of key usages (not extended key usages). Valid values can be found at https://golang.org/pkg/crypto/x509/#KeyUsage - - simply drop the \&quot;KeyUsage\&quot; part of the name. To remove all key usages from being set, set this value to an empty list..</param>
        /// <param name="notAfter">Set the not after field of the certificate with specified date value. The value format should be given in UTC format YYYY-MM-ddTHH:MM:SSZ.</param>
        /// <param name="otherSans">Requested other SANs, in an array with the format &lt;oid&gt;;UTF8:&lt;utf8 string value&gt; for each entry..</param>
        /// <param name="privateKeyFormat">Format for the returned private key. Generally the default will be controlled by the \&quot;format\&quot; parameter as either base64-encoded DER or PEM-encoded DER. However, this can be set to \&quot;pkcs8\&quot; to have the returned private key contain base64-encoded pkcs8 or PEM-encoded pkcs8 instead. Defaults to \&quot;der\&quot;. (default to PrivateKeyFormatEnum.Der).</param>
        /// <param name="role">The desired role with configuration for this request.</param>
        /// <param name="serialNumber">The Subject&#39;s requested serial number, if any. See RFC 4519 Section 2.31 &#39;serialNumber&#39; for a description of this field. If you want more than one, specify alternative names in the alt_names map using OID 2.5.4.5. This has no impact on the final certificate&#39;s Serial Number field..</param>
        /// <param name="ttl">The requested Time To Live for the certificate; sets the expiration date. If not specified the role default, backend default, or system default TTL is used, in that order. Cannot be larger than the role max TTL..</param>
        /// <param name="uriSans">The requested URI SANs, if any, in a comma-delimited list..</param>
        public PkiSignVerbatimRequest(string altNames = default(string), string commonName = default(string), string csr = "", bool excludeCnFromSans = false, List<string> extKeyUsage = default(List<string>), List<string> extKeyUsageOids = default(List<string>), FormatEnum? format = FormatEnum.Pem, List<string> ipSans = default(List<string>), string issuerRef = "default", List<string> keyUsage = default(List<string>), string notAfter = default(string), List<string> otherSans = default(List<string>), PrivateKeyFormatEnum? privateKeyFormat = PrivateKeyFormatEnum.Der, string role = default(string), string serialNumber = default(string), int ttl = default(int), List<string> uriSans = default(List<string>))
        {
            this.AltNames = altNames;
            this.CommonName = commonName;
            // use default value if no "csr" provided
            this.Csr = csr ?? "";
            this.ExcludeCnFromSans = excludeCnFromSans;
            this.ExtKeyUsage = extKeyUsage;
            this.ExtKeyUsageOids = extKeyUsageOids;
            this.Format = format;
            this.IpSans = ipSans;
            // use default value if no "issuerRef" provided
            this.IssuerRef = issuerRef ?? "default";
            this.KeyUsage = keyUsage;
            this.NotAfter = notAfter;
            this.OtherSans = otherSans;
            this.PrivateKeyFormat = privateKeyFormat;
            this.Role = role;
            this.SerialNumber = serialNumber;
            this.Ttl = ttl;
            this.UriSans = uriSans;
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
        /// PEM-format CSR to be signed. Values will be taken verbatim from the CSR, except for basic constraints.
        /// </summary>
        /// <value>PEM-format CSR to be signed. Values will be taken verbatim from the CSR, except for basic constraints.</value>
        [DataMember(Name = "csr", EmitDefaultValue = false)]
        public string Csr { get; set; }

        /// <summary>
        /// If true, the Common Name will not be included in DNS or Email Subject Alternate Names. Defaults to false (CN is included).
        /// </summary>
        /// <value>If true, the Common Name will not be included in DNS or Email Subject Alternate Names. Defaults to false (CN is included).</value>
        [DataMember(Name = "exclude_cn_from_sans", EmitDefaultValue = true)]
        public bool ExcludeCnFromSans { get; set; }

        /// <summary>
        /// A comma-separated string or list of extended key usages. Valid values can be found at https://golang.org/pkg/crypto/x509/#ExtKeyUsage - - simply drop the \&quot;ExtKeyUsage\&quot; part of the name. To remove all key usages from being set, set this value to an empty list.
        /// </summary>
        /// <value>A comma-separated string or list of extended key usages. Valid values can be found at https://golang.org/pkg/crypto/x509/#ExtKeyUsage - - simply drop the \&quot;ExtKeyUsage\&quot; part of the name. To remove all key usages from being set, set this value to an empty list.</value>
        [DataMember(Name = "ext_key_usage", EmitDefaultValue = false)]
        public List<string> ExtKeyUsage { get; set; }

        /// <summary>
        /// A comma-separated string or list of extended key usage oids.
        /// </summary>
        /// <value>A comma-separated string or list of extended key usage oids.</value>
        [DataMember(Name = "ext_key_usage_oids", EmitDefaultValue = false)]
        public List<string> ExtKeyUsageOids { get; set; }

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
        /// A comma-separated string or list of key usages (not extended key usages). Valid values can be found at https://golang.org/pkg/crypto/x509/#KeyUsage - - simply drop the \&quot;KeyUsage\&quot; part of the name. To remove all key usages from being set, set this value to an empty list.
        /// </summary>
        /// <value>A comma-separated string or list of key usages (not extended key usages). Valid values can be found at https://golang.org/pkg/crypto/x509/#KeyUsage - - simply drop the \&quot;KeyUsage\&quot; part of the name. To remove all key usages from being set, set this value to an empty list.</value>
        [DataMember(Name = "key_usage", EmitDefaultValue = false)]
        public List<string> KeyUsage { get; set; }

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
        /// The desired role with configuration for this request
        /// </summary>
        /// <value>The desired role with configuration for this request</value>
        [DataMember(Name = "role", EmitDefaultValue = false)]
        public string Role { get; set; }

        /// <summary>
        /// The Subject&#39;s requested serial number, if any. See RFC 4519 Section 2.31 &#39;serialNumber&#39; for a description of this field. If you want more than one, specify alternative names in the alt_names map using OID 2.5.4.5. This has no impact on the final certificate&#39;s Serial Number field.
        /// </summary>
        /// <value>The Subject&#39;s requested serial number, if any. See RFC 4519 Section 2.31 &#39;serialNumber&#39; for a description of this field. If you want more than one, specify alternative names in the alt_names map using OID 2.5.4.5. This has no impact on the final certificate&#39;s Serial Number field.</value>
        [DataMember(Name = "serial_number", EmitDefaultValue = false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// The requested Time To Live for the certificate; sets the expiration date. If not specified the role default, backend default, or system default TTL is used, in that order. Cannot be larger than the role max TTL.
        /// </summary>
        /// <value>The requested Time To Live for the certificate; sets the expiration date. If not specified the role default, backend default, or system default TTL is used, in that order. Cannot be larger than the role max TTL.</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]
        public int Ttl { get; set; }

        /// <summary>
        /// The requested URI SANs, if any, in a comma-delimited list.
        /// </summary>
        /// <value>The requested URI SANs, if any, in a comma-delimited list.</value>
        [DataMember(Name = "uri_sans", EmitDefaultValue = false)]
        public List<string> UriSans { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiSignVerbatimRequest {\n");
            sb.Append("  AltNames: ").Append(AltNames).Append("\n");
            sb.Append("  CommonName: ").Append(CommonName).Append("\n");
            sb.Append("  Csr: ").Append(Csr).Append("\n");
            sb.Append("  ExcludeCnFromSans: ").Append(ExcludeCnFromSans).Append("\n");
            sb.Append("  ExtKeyUsage: ").Append(ExtKeyUsage).Append("\n");
            sb.Append("  ExtKeyUsageOids: ").Append(ExtKeyUsageOids).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  IpSans: ").Append(IpSans).Append("\n");
            sb.Append("  IssuerRef: ").Append(IssuerRef).Append("\n");
            sb.Append("  KeyUsage: ").Append(KeyUsage).Append("\n");
            sb.Append("  NotAfter: ").Append(NotAfter).Append("\n");
            sb.Append("  OtherSans: ").Append(OtherSans).Append("\n");
            sb.Append("  PrivateKeyFormat: ").Append(PrivateKeyFormat).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
            sb.Append("  UriSans: ").Append(UriSans).Append("\n");
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
            return this.Equals(input as PkiSignVerbatimRequest);
        }

        /// <summary>
        /// Returns true if PkiSignVerbatimRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiSignVerbatimRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiSignVerbatimRequest input)
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
                    this.ExtKeyUsage == input.ExtKeyUsage ||
                    this.ExtKeyUsage != null &&
                    input.ExtKeyUsage != null &&
                    this.ExtKeyUsage.SequenceEqual(input.ExtKeyUsage)
                ) && 
                (
                    this.ExtKeyUsageOids == input.ExtKeyUsageOids ||
                    this.ExtKeyUsageOids != null &&
                    input.ExtKeyUsageOids != null &&
                    this.ExtKeyUsageOids.SequenceEqual(input.ExtKeyUsageOids)
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
                    this.KeyUsage == input.KeyUsage ||
                    this.KeyUsage != null &&
                    input.KeyUsage != null &&
                    this.KeyUsage.SequenceEqual(input.KeyUsage)
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
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.Ttl == input.Ttl ||
                    this.Ttl.Equals(input.Ttl)
                ) && 
                (
                    this.UriSans == input.UriSans ||
                    this.UriSans != null &&
                    input.UriSans != null &&
                    this.UriSans.SequenceEqual(input.UriSans)
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
                if (this.ExtKeyUsage != null)
                {
                    hashCode = (hashCode * 59) + this.ExtKeyUsage.GetHashCode();
                }
                if (this.ExtKeyUsageOids != null)
                {
                    hashCode = (hashCode * 59) + this.ExtKeyUsageOids.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Format.GetHashCode();
                if (this.IpSans != null)
                {
                    hashCode = (hashCode * 59) + this.IpSans.GetHashCode();
                }
                if (this.IssuerRef != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerRef.GetHashCode();
                }
                if (this.KeyUsage != null)
                {
                    hashCode = (hashCode * 59) + this.KeyUsage.GetHashCode();
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
                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
                }
                if (this.SerialNumber != null)
                {
                    hashCode = (hashCode * 59) + this.SerialNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
                if (this.UriSans != null)
                {
                    hashCode = (hashCode * 59) + this.UriSans.GetHashCode();
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
