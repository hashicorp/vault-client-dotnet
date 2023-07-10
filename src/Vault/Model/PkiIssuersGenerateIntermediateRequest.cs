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
    /// PkiIssuersGenerateIntermediateRequest
    /// </summary>
    [DataContract(Name = "PkiIssuersGenerateIntermediateRequest")]
    public partial class PkiIssuersGenerateIntermediateRequest : IEquatable<PkiIssuersGenerateIntermediateRequest>, IValidatableObject
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
        /// The type of key to use; defaults to RSA. \&quot;rsa\&quot; \&quot;ec\&quot; and \&quot;ed25519\&quot; are the only valid values.
        /// </summary>
        /// <value>The type of key to use; defaults to RSA. \&quot;rsa\&quot; \&quot;ec\&quot; and \&quot;ed25519\&quot; are the only valid values.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum KeyTypeEnum
        {

            /// <summary>
            /// Enum Rsa for value: rsa
            /// </summary>
            [EnumMember(Value = "rsa")]
            Rsa = 0,
            /// <summary>
            /// Enum Ec for value: ec
            /// </summary>
            [EnumMember(Value = "ec")]
            Ec = 1,
            /// <summary>
            /// Enum Ed25519 for value: ed25519
            /// </summary>
            [EnumMember(Value = "ed25519")]
            Ed25519 = 2
        }
        /// <summary>
        /// The type of key to use; defaults to RSA. \&quot;rsa\&quot; \&quot;ec\&quot; and \&quot;ed25519\&quot; are the only valid values.
        /// </summary>
        /// <value>The type of key to use; defaults to RSA. \&quot;rsa\&quot; \&quot;ec\&quot; and \&quot;ed25519\&quot; are the only valid values.</value>

        [DataMember(Name = "key_type", EmitDefaultValue = false)]
        public KeyTypeEnum? KeyType { get; set; }

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
        /// Initializes a new instance of the <see cref="PkiIssuersGenerateIntermediateRequest" /> class.
        /// </summary>

        /// <param name="AddBasicConstraints">Whether to add a Basic Constraints extension with CA: true. Only needed as a workaround in some compatibility scenarios with Active Directory Certificate Services..</param>

        /// <param name="AltNames">The requested Subject Alternative Names, if any, in a comma-delimited list. May contain both DNS names and email addresses..</param>

        /// <param name="CommonName">The requested common name; if you want more than one, specify the alternative names in the alt_names map. If not specified when signing, the common name will be taken from the CSR; other names must still be specified in alt_names or ip_sans..</param>

        /// <param name="Country">If set, Country will be set to this value..</param>

        /// <param name="ExcludeCnFromSans">If true, the Common Name will not be included in DNS or Email Subject Alternate Names. Defaults to false (CN is included). (default to false).</param>

        /// <param name="Format">Format for returned data. Can be \&quot;pem\&quot;, \&quot;der\&quot;, or \&quot;pem_bundle\&quot;. If \&quot;pem_bundle\&quot;, any private key and issuing cert will be appended to the certificate pem. If \&quot;der\&quot;, the value will be base64 encoded. Defaults to \&quot;pem\&quot;. (default to FormatEnum.Pem).</param>

        /// <param name="IpSans">The requested IP SANs, if any, in a comma-delimited list.</param>

        /// <param name="KeyBits">The number of bits to use. Allowed values are 0 (universal default); with rsa key_type: 2048 (default), 3072, or 4096; with ec key_type: 224, 256 (default), 384, or 521; ignored with ed25519. (default to 0).</param>

        /// <param name="KeyName">Provide a name to the generated or existing key, the name must be unique across all keys and not be the reserved value &#x27;default&#x27;.</param>

        /// <param name="KeyRef">Reference to a existing key; either \&quot;default\&quot; for the configured default key, an identifier or the name assigned to the key. (default to &quot;default&quot;).</param>

        /// <param name="KeyType">The type of key to use; defaults to RSA. \&quot;rsa\&quot; \&quot;ec\&quot; and \&quot;ed25519\&quot; are the only valid values. (default to KeyTypeEnum.Rsa).</param>

        /// <param name="Locality">If set, Locality will be set to this value..</param>

        /// <param name="ManagedKeyId">The name of the managed key to use when the exported type is kms. When kms type is the key type, this field or managed_key_name is required. Ignored for other types..</param>

        /// <param name="ManagedKeyName">The name of the managed key to use when the exported type is kms. When kms type is the key type, this field or managed_key_id is required. Ignored for other types..</param>

        /// <param name="NotAfter">Set the not after field of the certificate with specified date value. The value format should be given in UTC format YYYY-MM-ddTHH:MM:SSZ.</param>

        /// <param name="NotBeforeDuration">The duration before now which the certificate needs to be backdated by. (default to &quot;30&quot;).</param>

        /// <param name="Organization">If set, O (Organization) will be set to this value..</param>

        /// <param name="OtherSans">Requested other SANs, in an array with the format &lt;oid&gt;;UTF8:&lt;utf8 string value&gt; for each entry..</param>

        /// <param name="Ou">If set, OU (OrganizationalUnit) will be set to this value..</param>

        /// <param name="PostalCode">If set, Postal Code will be set to this value..</param>

        /// <param name="PrivateKeyFormat">Format for the returned private key. Generally the default will be controlled by the \&quot;format\&quot; parameter as either base64-encoded DER or PEM-encoded DER. However, this can be set to \&quot;pkcs8\&quot; to have the returned private key contain base64-encoded pkcs8 or PEM-encoded pkcs8 instead. Defaults to \&quot;der\&quot;. (default to PrivateKeyFormatEnum.Der).</param>

        /// <param name="Province">If set, Province will be set to this value..</param>

        /// <param name="SerialNumber">The Subject&#x27;s requested serial number, if any. See RFC 4519 Section 2.31 &#x27;serialNumber&#x27; for a description of this field. If you want more than one, specify alternative names in the alt_names map using OID 2.5.4.5. This has no impact on the final certificate&#x27;s Serial Number field..</param>

        /// <param name="SignatureBits">The number of bits to use in the signature algorithm; accepts 256 for SHA-2-256, 384 for SHA-2-384, and 512 for SHA-2-512. Defaults to 0 to automatically detect based on key length (SHA-2-256 for RSA keys, and matching the curve size for NIST P-Curves). (default to 0).</param>

        /// <param name="StreetAddress">If set, Street Address will be set to this value..</param>

        /// <param name="Ttl">The requested Time To Live for the certificate; sets the expiration date. If not specified the role default, backend default, or system default TTL is used, in that order. Cannot be larger than the mount max TTL. Note: this only has an effect when generating a CA cert or signing a CA cert, not when generating a CSR for an intermediate CA..</param>

        /// <param name="UriSans">The requested URI SANs, if any, in a comma-delimited list..</param>


        public PkiIssuersGenerateIntermediateRequest(bool AddBasicConstraints = default(bool), string AltNames = default(string), string CommonName = default(string), List<string> Country = default(List<string>), bool ExcludeCnFromSans = false, FormatEnum? Format = FormatEnum.Pem, List<string> IpSans = default(List<string>), int KeyBits = 0, string KeyName = default(string), string KeyRef = "default", KeyTypeEnum? KeyType = KeyTypeEnum.Rsa, List<string> Locality = default(List<string>), string ManagedKeyId = default(string), string ManagedKeyName = default(string), string NotAfter = default(string), string NotBeforeDuration = "30", List<string> Organization = default(List<string>), List<string> OtherSans = default(List<string>), List<string> Ou = default(List<string>), List<string> PostalCode = default(List<string>), PrivateKeyFormatEnum? PrivateKeyFormat = PrivateKeyFormatEnum.Der, List<string> Province = default(List<string>), string SerialNumber = default(string), int SignatureBits = 0, List<string> StreetAddress = default(List<string>), string Ttl = default(string), List<string> UriSans = default(List<string>))
        {

            this.AddBasicConstraints = AddBasicConstraints;

            this.AltNames = AltNames;

            this.CommonName = CommonName;

            this.Country = Country;

            this.ExcludeCnFromSans = ExcludeCnFromSans;

            this.Format = Format;

            this.IpSans = IpSans;

            this.KeyBits = KeyBits;

            this.KeyName = KeyName;

            // use default value if no "KeyRef" provided
            this.KeyRef = KeyRef ?? "default";


            this.KeyType = KeyType;

            this.Locality = Locality;

            this.ManagedKeyId = ManagedKeyId;

            this.ManagedKeyName = ManagedKeyName;

            this.NotAfter = NotAfter;

            // use default value if no "NotBeforeDuration" provided
            this.NotBeforeDuration = NotBeforeDuration ?? "30";


            this.Organization = Organization;

            this.OtherSans = OtherSans;

            this.Ou = Ou;

            this.PostalCode = PostalCode;

            this.PrivateKeyFormat = PrivateKeyFormat;

            this.Province = Province;

            this.SerialNumber = SerialNumber;

            this.SignatureBits = SignatureBits;

            this.StreetAddress = StreetAddress;

            this.Ttl = Ttl;

            this.UriSans = UriSans;

        }

        /// <summary>
        /// Whether to add a Basic Constraints extension with CA: true. Only needed as a workaround in some compatibility scenarios with Active Directory Certificate Services.
        /// </summary>
        /// <value>Whether to add a Basic Constraints extension with CA: true. Only needed as a workaround in some compatibility scenarios with Active Directory Certificate Services.</value>
        [DataMember(Name = "add_basic_constraints", EmitDefaultValue = true)]

        public bool AddBasicConstraints { get; set; }


        /// <summary>
        /// The requested Subject Alternative Names, if any, in a comma-delimited list. May contain both DNS names and email addresses.
        /// </summary>
        /// <value>The requested Subject Alternative Names, if any, in a comma-delimited list. May contain both DNS names and email addresses.</value>
        [DataMember(Name = "alt_names", EmitDefaultValue = false)]

        public string AltNames { get; set; }


        /// <summary>
        /// The requested common name; if you want more than one, specify the alternative names in the alt_names map. If not specified when signing, the common name will be taken from the CSR; other names must still be specified in alt_names or ip_sans.
        /// </summary>
        /// <value>The requested common name; if you want more than one, specify the alternative names in the alt_names map. If not specified when signing, the common name will be taken from the CSR; other names must still be specified in alt_names or ip_sans.</value>
        [DataMember(Name = "common_name", EmitDefaultValue = false)]

        public string CommonName { get; set; }


        /// <summary>
        /// If set, Country will be set to this value.
        /// </summary>
        /// <value>If set, Country will be set to this value.</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]

        public List<string> Country { get; set; }


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
        /// The number of bits to use. Allowed values are 0 (universal default); with rsa key_type: 2048 (default), 3072, or 4096; with ec key_type: 224, 256 (default), 384, or 521; ignored with ed25519.
        /// </summary>
        /// <value>The number of bits to use. Allowed values are 0 (universal default); with rsa key_type: 2048 (default), 3072, or 4096; with ec key_type: 224, 256 (default), 384, or 521; ignored with ed25519.</value>
        [DataMember(Name = "key_bits", EmitDefaultValue = false)]

        public int KeyBits { get; set; }


        /// <summary>
        /// Provide a name to the generated or existing key, the name must be unique across all keys and not be the reserved value &#x27;default&#x27;
        /// </summary>
        /// <value>Provide a name to the generated or existing key, the name must be unique across all keys and not be the reserved value &#x27;default&#x27;</value>
        [DataMember(Name = "key_name", EmitDefaultValue = false)]

        public string KeyName { get; set; }


        /// <summary>
        /// Reference to a existing key; either \&quot;default\&quot; for the configured default key, an identifier or the name assigned to the key.
        /// </summary>
        /// <value>Reference to a existing key; either \&quot;default\&quot; for the configured default key, an identifier or the name assigned to the key.</value>
        [DataMember(Name = "key_ref", EmitDefaultValue = false)]

        public string KeyRef { get; set; }


        /// <summary>
        /// If set, Locality will be set to this value.
        /// </summary>
        /// <value>If set, Locality will be set to this value.</value>
        [DataMember(Name = "locality", EmitDefaultValue = false)]

        public List<string> Locality { get; set; }


        /// <summary>
        /// The name of the managed key to use when the exported type is kms. When kms type is the key type, this field or managed_key_name is required. Ignored for other types.
        /// </summary>
        /// <value>The name of the managed key to use when the exported type is kms. When kms type is the key type, this field or managed_key_name is required. Ignored for other types.</value>
        [DataMember(Name = "managed_key_id", EmitDefaultValue = false)]

        public string ManagedKeyId { get; set; }


        /// <summary>
        /// The name of the managed key to use when the exported type is kms. When kms type is the key type, this field or managed_key_id is required. Ignored for other types.
        /// </summary>
        /// <value>The name of the managed key to use when the exported type is kms. When kms type is the key type, this field or managed_key_id is required. Ignored for other types.</value>
        [DataMember(Name = "managed_key_name", EmitDefaultValue = false)]

        public string ManagedKeyName { get; set; }


        /// <summary>
        /// Set the not after field of the certificate with specified date value. The value format should be given in UTC format YYYY-MM-ddTHH:MM:SSZ
        /// </summary>
        /// <value>Set the not after field of the certificate with specified date value. The value format should be given in UTC format YYYY-MM-ddTHH:MM:SSZ</value>
        [DataMember(Name = "not_after", EmitDefaultValue = false)]

        public string NotAfter { get; set; }


        /// <summary>
        /// The duration before now which the certificate needs to be backdated by.
        /// </summary>
        /// <value>The duration before now which the certificate needs to be backdated by.</value>
        [DataMember(Name = "not_before_duration", EmitDefaultValue = false)]

        public string NotBeforeDuration { get; set; }


        /// <summary>
        /// If set, O (Organization) will be set to this value.
        /// </summary>
        /// <value>If set, O (Organization) will be set to this value.</value>
        [DataMember(Name = "organization", EmitDefaultValue = false)]

        public List<string> Organization { get; set; }


        /// <summary>
        /// Requested other SANs, in an array with the format &lt;oid&gt;;UTF8:&lt;utf8 string value&gt; for each entry.
        /// </summary>
        /// <value>Requested other SANs, in an array with the format &lt;oid&gt;;UTF8:&lt;utf8 string value&gt; for each entry.</value>
        [DataMember(Name = "other_sans", EmitDefaultValue = false)]

        public List<string> OtherSans { get; set; }


        /// <summary>
        /// If set, OU (OrganizationalUnit) will be set to this value.
        /// </summary>
        /// <value>If set, OU (OrganizationalUnit) will be set to this value.</value>
        [DataMember(Name = "ou", EmitDefaultValue = false)]

        public List<string> Ou { get; set; }


        /// <summary>
        /// If set, Postal Code will be set to this value.
        /// </summary>
        /// <value>If set, Postal Code will be set to this value.</value>
        [DataMember(Name = "postal_code", EmitDefaultValue = false)]

        public List<string> PostalCode { get; set; }


        /// <summary>
        /// If set, Province will be set to this value.
        /// </summary>
        /// <value>If set, Province will be set to this value.</value>
        [DataMember(Name = "province", EmitDefaultValue = false)]

        public List<string> Province { get; set; }


        /// <summary>
        /// The Subject&#x27;s requested serial number, if any. See RFC 4519 Section 2.31 &#x27;serialNumber&#x27; for a description of this field. If you want more than one, specify alternative names in the alt_names map using OID 2.5.4.5. This has no impact on the final certificate&#x27;s Serial Number field.
        /// </summary>
        /// <value>The Subject&#x27;s requested serial number, if any. See RFC 4519 Section 2.31 &#x27;serialNumber&#x27; for a description of this field. If you want more than one, specify alternative names in the alt_names map using OID 2.5.4.5. This has no impact on the final certificate&#x27;s Serial Number field.</value>
        [DataMember(Name = "serial_number", EmitDefaultValue = false)]

        public string SerialNumber { get; set; }


        /// <summary>
        /// The number of bits to use in the signature algorithm; accepts 256 for SHA-2-256, 384 for SHA-2-384, and 512 for SHA-2-512. Defaults to 0 to automatically detect based on key length (SHA-2-256 for RSA keys, and matching the curve size for NIST P-Curves).
        /// </summary>
        /// <value>The number of bits to use in the signature algorithm; accepts 256 for SHA-2-256, 384 for SHA-2-384, and 512 for SHA-2-512. Defaults to 0 to automatically detect based on key length (SHA-2-256 for RSA keys, and matching the curve size for NIST P-Curves).</value>
        [DataMember(Name = "signature_bits", EmitDefaultValue = false)]

        public int SignatureBits { get; set; }


        /// <summary>
        /// If set, Street Address will be set to this value.
        /// </summary>
        /// <value>If set, Street Address will be set to this value.</value>
        [DataMember(Name = "street_address", EmitDefaultValue = false)]

        public List<string> StreetAddress { get; set; }


        /// <summary>
        /// The requested Time To Live for the certificate; sets the expiration date. If not specified the role default, backend default, or system default TTL is used, in that order. Cannot be larger than the mount max TTL. Note: this only has an effect when generating a CA cert or signing a CA cert, not when generating a CSR for an intermediate CA.
        /// </summary>
        /// <value>The requested Time To Live for the certificate; sets the expiration date. If not specified the role default, backend default, or system default TTL is used, in that order. Cannot be larger than the mount max TTL. Note: this only has an effect when generating a CA cert or signing a CA cert, not when generating a CSR for an intermediate CA.</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]

        public string Ttl { get; set; }


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
            sb.Append("class PkiIssuersGenerateIntermediateRequest {\n");
            sb.Append("  AddBasicConstraints: ").Append(AddBasicConstraints).Append("\n");
            sb.Append("  AltNames: ").Append(AltNames).Append("\n");
            sb.Append("  CommonName: ").Append(CommonName).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  ExcludeCnFromSans: ").Append(ExcludeCnFromSans).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  IpSans: ").Append(IpSans).Append("\n");
            sb.Append("  KeyBits: ").Append(KeyBits).Append("\n");
            sb.Append("  KeyName: ").Append(KeyName).Append("\n");
            sb.Append("  KeyRef: ").Append(KeyRef).Append("\n");
            sb.Append("  KeyType: ").Append(KeyType).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  ManagedKeyId: ").Append(ManagedKeyId).Append("\n");
            sb.Append("  ManagedKeyName: ").Append(ManagedKeyName).Append("\n");
            sb.Append("  NotAfter: ").Append(NotAfter).Append("\n");
            sb.Append("  NotBeforeDuration: ").Append(NotBeforeDuration).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  OtherSans: ").Append(OtherSans).Append("\n");
            sb.Append("  Ou: ").Append(Ou).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  PrivateKeyFormat: ").Append(PrivateKeyFormat).Append("\n");
            sb.Append("  Province: ").Append(Province).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  SignatureBits: ").Append(SignatureBits).Append("\n");
            sb.Append("  StreetAddress: ").Append(StreetAddress).Append("\n");
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
            return this.Equals(input as PkiIssuersGenerateIntermediateRequest);
        }

        /// <summary>
        /// Returns true if PkiIssuersGenerateIntermediateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiIssuersGenerateIntermediateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiIssuersGenerateIntermediateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AddBasicConstraints == input.AddBasicConstraints ||

                    this.AddBasicConstraints.Equals(input.AddBasicConstraints)
                ) &&
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
                    this.Country == input.Country ||
                    this.Country != null &&
                    input.Country != null &&
                    this.Country.SequenceEqual(input.Country)
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
                    this.KeyBits == input.KeyBits ||

                    this.KeyBits.Equals(input.KeyBits)
                ) &&
                (
                    this.KeyName == input.KeyName ||
                    (this.KeyName != null &&
                    this.KeyName.Equals(input.KeyName))

                ) &&
                (
                    this.KeyRef == input.KeyRef ||
                    (this.KeyRef != null &&
                    this.KeyRef.Equals(input.KeyRef))

                ) &&
                (
                    this.KeyType == input.KeyType ||

                    this.KeyType.Equals(input.KeyType)
                ) &&
                (
                    this.Locality == input.Locality ||
                    this.Locality != null &&
                    input.Locality != null &&
                    this.Locality.SequenceEqual(input.Locality)
                ) &&
                (
                    this.ManagedKeyId == input.ManagedKeyId ||
                    (this.ManagedKeyId != null &&
                    this.ManagedKeyId.Equals(input.ManagedKeyId))

                ) &&
                (
                    this.ManagedKeyName == input.ManagedKeyName ||
                    (this.ManagedKeyName != null &&
                    this.ManagedKeyName.Equals(input.ManagedKeyName))

                ) &&
                (
                    this.NotAfter == input.NotAfter ||
                    (this.NotAfter != null &&
                    this.NotAfter.Equals(input.NotAfter))

                ) &&
                (
                    this.NotBeforeDuration == input.NotBeforeDuration ||
                    (this.NotBeforeDuration != null &&
                    this.NotBeforeDuration.Equals(input.NotBeforeDuration))

                ) &&
                (
                    this.Organization == input.Organization ||
                    this.Organization != null &&
                    input.Organization != null &&
                    this.Organization.SequenceEqual(input.Organization)
                ) &&
                (
                    this.OtherSans == input.OtherSans ||
                    this.OtherSans != null &&
                    input.OtherSans != null &&
                    this.OtherSans.SequenceEqual(input.OtherSans)
                ) &&
                (
                    this.Ou == input.Ou ||
                    this.Ou != null &&
                    input.Ou != null &&
                    this.Ou.SequenceEqual(input.Ou)
                ) &&
                (
                    this.PostalCode == input.PostalCode ||
                    this.PostalCode != null &&
                    input.PostalCode != null &&
                    this.PostalCode.SequenceEqual(input.PostalCode)
                ) &&
                (
                    this.PrivateKeyFormat == input.PrivateKeyFormat ||

                    this.PrivateKeyFormat.Equals(input.PrivateKeyFormat)
                ) &&
                (
                    this.Province == input.Province ||
                    this.Province != null &&
                    input.Province != null &&
                    this.Province.SequenceEqual(input.Province)
                ) &&
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))

                ) &&
                (
                    this.SignatureBits == input.SignatureBits ||

                    this.SignatureBits.Equals(input.SignatureBits)
                ) &&
                (
                    this.StreetAddress == input.StreetAddress ||
                    this.StreetAddress != null &&
                    input.StreetAddress != null &&
                    this.StreetAddress.SequenceEqual(input.StreetAddress)
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


                hashCode = (hashCode * 59) + this.AddBasicConstraints.GetHashCode();
                if (this.AltNames != null)
                {
                    hashCode = (hashCode * 59) + this.AltNames.GetHashCode();
                }

                if (this.CommonName != null)
                {
                    hashCode = (hashCode * 59) + this.CommonName.GetHashCode();
                }

                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.ExcludeCnFromSans.GetHashCode();

                hashCode = (hashCode * 59) + this.Format.GetHashCode();
                if (this.IpSans != null)
                {
                    hashCode = (hashCode * 59) + this.IpSans.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.KeyBits.GetHashCode();
                if (this.KeyName != null)
                {
                    hashCode = (hashCode * 59) + this.KeyName.GetHashCode();
                }

                if (this.KeyRef != null)
                {
                    hashCode = (hashCode * 59) + this.KeyRef.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.KeyType.GetHashCode();
                if (this.Locality != null)
                {
                    hashCode = (hashCode * 59) + this.Locality.GetHashCode();
                }

                if (this.ManagedKeyId != null)
                {
                    hashCode = (hashCode * 59) + this.ManagedKeyId.GetHashCode();
                }

                if (this.ManagedKeyName != null)
                {
                    hashCode = (hashCode * 59) + this.ManagedKeyName.GetHashCode();
                }

                if (this.NotAfter != null)
                {
                    hashCode = (hashCode * 59) + this.NotAfter.GetHashCode();
                }

                if (this.NotBeforeDuration != null)
                {
                    hashCode = (hashCode * 59) + this.NotBeforeDuration.GetHashCode();
                }

                if (this.Organization != null)
                {
                    hashCode = (hashCode * 59) + this.Organization.GetHashCode();
                }

                if (this.OtherSans != null)
                {
                    hashCode = (hashCode * 59) + this.OtherSans.GetHashCode();
                }

                if (this.Ou != null)
                {
                    hashCode = (hashCode * 59) + this.Ou.GetHashCode();
                }

                if (this.PostalCode != null)
                {
                    hashCode = (hashCode * 59) + this.PostalCode.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.PrivateKeyFormat.GetHashCode();
                if (this.Province != null)
                {
                    hashCode = (hashCode * 59) + this.Province.GetHashCode();
                }

                if (this.SerialNumber != null)
                {
                    hashCode = (hashCode * 59) + this.SerialNumber.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.SignatureBits.GetHashCode();
                if (this.StreetAddress != null)
                {
                    hashCode = (hashCode * 59) + this.StreetAddress.GetHashCode();
                }

                if (this.Ttl != null)
                {
                    hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
                }

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
