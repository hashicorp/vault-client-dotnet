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
    /// MountsReadTuningInformationResponse
    /// </summary>
    [DataContract(Name = "MountsReadTuningInformationResponse")]
    public partial class MountsReadTuningInformationResponse : IEquatable<MountsReadTuningInformationResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="MountsReadTuningInformationResponse" /> class.
        /// </summary>

        /// <param name="AllowedManagedKeys">AllowedManagedKeys.</param>

        /// <param name="AllowedResponseHeaders">A list of headers to whitelist and allow a plugin to set on responses..</param>

        /// <param name="AuditNonHmacRequestKeys">AuditNonHmacRequestKeys.</param>

        /// <param name="AuditNonHmacResponseKeys">AuditNonHmacResponseKeys.</param>

        /// <param name="DefaultLeaseTtl">The default lease TTL for this mount..</param>

        /// <param name="Description">User-friendly description for this credential backend..</param>

        /// <param name="ExternalEntropyAccess">ExternalEntropyAccess.</param>

        /// <param name="ForceNoCache">ForceNoCache.</param>

        /// <param name="ListingVisibility">ListingVisibility.</param>

        /// <param name="MaxLeaseTtl">The max lease TTL for this mount..</param>

        /// <param name="Options">The options to pass into the backend. Should be a json object with string keys and values..</param>

        /// <param name="PassthroughRequestHeaders">PassthroughRequestHeaders.</param>

        /// <param name="PluginVersion">The semantic version of the plugin to use, or image tag if oci_image is provided..</param>

        /// <param name="TokenType">The type of token to issue (service or batch)..</param>

        /// <param name="UserLockoutCounterResetDuration">UserLockoutCounterResetDuration.</param>

        /// <param name="UserLockoutDisable">UserLockoutDisable.</param>

        /// <param name="UserLockoutDuration">UserLockoutDuration.</param>

        /// <param name="UserLockoutThreshold">UserLockoutThreshold.</param>


        public MountsReadTuningInformationResponse(List<string> AllowedManagedKeys = default(List<string>), List<string> AllowedResponseHeaders = default(List<string>), List<string> AuditNonHmacRequestKeys = default(List<string>), List<string> AuditNonHmacResponseKeys = default(List<string>), int DefaultLeaseTtl = default(int), string Description = default(string), bool ExternalEntropyAccess = default(bool), bool ForceNoCache = default(bool), string ListingVisibility = default(string), int MaxLeaseTtl = default(int), Object Options = default(Object), List<string> PassthroughRequestHeaders = default(List<string>), string PluginVersion = default(string), string TokenType = default(string), long UserLockoutCounterResetDuration = default(long), bool UserLockoutDisable = default(bool), long UserLockoutDuration = default(long), long UserLockoutThreshold = default(long))
        {

            this.AllowedManagedKeys = AllowedManagedKeys;

            this.AllowedResponseHeaders = AllowedResponseHeaders;

            this.AuditNonHmacRequestKeys = AuditNonHmacRequestKeys;

            this.AuditNonHmacResponseKeys = AuditNonHmacResponseKeys;

            this.DefaultLeaseTtl = DefaultLeaseTtl;

            this.Description = Description;

            this.ExternalEntropyAccess = ExternalEntropyAccess;

            this.ForceNoCache = ForceNoCache;

            this.ListingVisibility = ListingVisibility;

            this.MaxLeaseTtl = MaxLeaseTtl;

            this.Options = Options;

            this.PassthroughRequestHeaders = PassthroughRequestHeaders;

            this.PluginVersion = PluginVersion;

            this.TokenType = TokenType;

            this.UserLockoutCounterResetDuration = UserLockoutCounterResetDuration;

            this.UserLockoutDisable = UserLockoutDisable;

            this.UserLockoutDuration = UserLockoutDuration;

            this.UserLockoutThreshold = UserLockoutThreshold;

        }

        /// <summary>
        /// Gets or Sets AllowedManagedKeys
        /// </summary>
        [DataMember(Name = "allowed_managed_keys", EmitDefaultValue = false)]

        public List<string> AllowedManagedKeys { get; set; }


        /// <summary>
        /// A list of headers to whitelist and allow a plugin to set on responses.
        /// </summary>
        /// <value>A list of headers to whitelist and allow a plugin to set on responses.</value>
        [DataMember(Name = "allowed_response_headers", EmitDefaultValue = false)]

        public List<string> AllowedResponseHeaders { get; set; }


        /// <summary>
        /// Gets or Sets AuditNonHmacRequestKeys
        /// </summary>
        [DataMember(Name = "audit_non_hmac_request_keys", EmitDefaultValue = false)]

        public List<string> AuditNonHmacRequestKeys { get; set; }


        /// <summary>
        /// Gets or Sets AuditNonHmacResponseKeys
        /// </summary>
        [DataMember(Name = "audit_non_hmac_response_keys", EmitDefaultValue = false)]

        public List<string> AuditNonHmacResponseKeys { get; set; }


        /// <summary>
        /// The default lease TTL for this mount.
        /// </summary>
        /// <value>The default lease TTL for this mount.</value>
        [DataMember(Name = "default_lease_ttl", EmitDefaultValue = false)]

        public int DefaultLeaseTtl { get; set; }


        /// <summary>
        /// User-friendly description for this credential backend.
        /// </summary>
        /// <value>User-friendly description for this credential backend.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]

        public string Description { get; set; }


        /// <summary>
        /// Gets or Sets ExternalEntropyAccess
        /// </summary>
        [DataMember(Name = "external_entropy_access", EmitDefaultValue = true)]

        public bool ExternalEntropyAccess { get; set; }


        /// <summary>
        /// Gets or Sets ForceNoCache
        /// </summary>
        [DataMember(Name = "force_no_cache", EmitDefaultValue = true)]

        public bool ForceNoCache { get; set; }


        /// <summary>
        /// Gets or Sets ListingVisibility
        /// </summary>
        [DataMember(Name = "listing_visibility", EmitDefaultValue = false)]

        public string ListingVisibility { get; set; }


        /// <summary>
        /// The max lease TTL for this mount.
        /// </summary>
        /// <value>The max lease TTL for this mount.</value>
        [DataMember(Name = "max_lease_ttl", EmitDefaultValue = false)]

        public int MaxLeaseTtl { get; set; }


        /// <summary>
        /// The options to pass into the backend. Should be a json object with string keys and values.
        /// </summary>
        /// <value>The options to pass into the backend. Should be a json object with string keys and values.</value>
        [DataMember(Name = "options", EmitDefaultValue = false)]

        public Object Options { get; set; }


        /// <summary>
        /// Gets or Sets PassthroughRequestHeaders
        /// </summary>
        [DataMember(Name = "passthrough_request_headers", EmitDefaultValue = false)]

        public List<string> PassthroughRequestHeaders { get; set; }


        /// <summary>
        /// The semantic version of the plugin to use, or image tag if oci_image is provided.
        /// </summary>
        /// <value>The semantic version of the plugin to use, or image tag if oci_image is provided.</value>
        [DataMember(Name = "plugin_version", EmitDefaultValue = false)]

        public string PluginVersion { get; set; }


        /// <summary>
        /// The type of token to issue (service or batch).
        /// </summary>
        /// <value>The type of token to issue (service or batch).</value>
        [DataMember(Name = "token_type", EmitDefaultValue = false)]

        public string TokenType { get; set; }


        /// <summary>
        /// Gets or Sets UserLockoutCounterResetDuration
        /// </summary>
        [DataMember(Name = "user_lockout_counter_reset_duration", EmitDefaultValue = false)]

        public long UserLockoutCounterResetDuration { get; set; }


        /// <summary>
        /// Gets or Sets UserLockoutDisable
        /// </summary>
        [DataMember(Name = "user_lockout_disable", EmitDefaultValue = true)]

        public bool UserLockoutDisable { get; set; }


        /// <summary>
        /// Gets or Sets UserLockoutDuration
        /// </summary>
        [DataMember(Name = "user_lockout_duration", EmitDefaultValue = false)]

        public long UserLockoutDuration { get; set; }


        /// <summary>
        /// Gets or Sets UserLockoutThreshold
        /// </summary>
        [DataMember(Name = "user_lockout_threshold", EmitDefaultValue = false)]

        public long UserLockoutThreshold { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MountsReadTuningInformationResponse {\n");
            sb.Append("  AllowedManagedKeys: ").Append(AllowedManagedKeys).Append("\n");
            sb.Append("  AllowedResponseHeaders: ").Append(AllowedResponseHeaders).Append("\n");
            sb.Append("  AuditNonHmacRequestKeys: ").Append(AuditNonHmacRequestKeys).Append("\n");
            sb.Append("  AuditNonHmacResponseKeys: ").Append(AuditNonHmacResponseKeys).Append("\n");
            sb.Append("  DefaultLeaseTtl: ").Append(DefaultLeaseTtl).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExternalEntropyAccess: ").Append(ExternalEntropyAccess).Append("\n");
            sb.Append("  ForceNoCache: ").Append(ForceNoCache).Append("\n");
            sb.Append("  ListingVisibility: ").Append(ListingVisibility).Append("\n");
            sb.Append("  MaxLeaseTtl: ").Append(MaxLeaseTtl).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  PassthroughRequestHeaders: ").Append(PassthroughRequestHeaders).Append("\n");
            sb.Append("  PluginVersion: ").Append(PluginVersion).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  UserLockoutCounterResetDuration: ").Append(UserLockoutCounterResetDuration).Append("\n");
            sb.Append("  UserLockoutDisable: ").Append(UserLockoutDisable).Append("\n");
            sb.Append("  UserLockoutDuration: ").Append(UserLockoutDuration).Append("\n");
            sb.Append("  UserLockoutThreshold: ").Append(UserLockoutThreshold).Append("\n");
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
            return this.Equals(input as MountsReadTuningInformationResponse);
        }

        /// <summary>
        /// Returns true if MountsReadTuningInformationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MountsReadTuningInformationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MountsReadTuningInformationResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AllowedManagedKeys == input.AllowedManagedKeys ||
                    this.AllowedManagedKeys != null &&
                    input.AllowedManagedKeys != null &&
                    this.AllowedManagedKeys.SequenceEqual(input.AllowedManagedKeys)
                ) &&
                (
                    this.AllowedResponseHeaders == input.AllowedResponseHeaders ||
                    this.AllowedResponseHeaders != null &&
                    input.AllowedResponseHeaders != null &&
                    this.AllowedResponseHeaders.SequenceEqual(input.AllowedResponseHeaders)
                ) &&
                (
                    this.AuditNonHmacRequestKeys == input.AuditNonHmacRequestKeys ||
                    this.AuditNonHmacRequestKeys != null &&
                    input.AuditNonHmacRequestKeys != null &&
                    this.AuditNonHmacRequestKeys.SequenceEqual(input.AuditNonHmacRequestKeys)
                ) &&
                (
                    this.AuditNonHmacResponseKeys == input.AuditNonHmacResponseKeys ||
                    this.AuditNonHmacResponseKeys != null &&
                    input.AuditNonHmacResponseKeys != null &&
                    this.AuditNonHmacResponseKeys.SequenceEqual(input.AuditNonHmacResponseKeys)
                ) &&
                (
                    this.DefaultLeaseTtl == input.DefaultLeaseTtl ||

                    this.DefaultLeaseTtl.Equals(input.DefaultLeaseTtl)
                ) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))

                ) &&
                (
                    this.ExternalEntropyAccess == input.ExternalEntropyAccess ||

                    this.ExternalEntropyAccess.Equals(input.ExternalEntropyAccess)
                ) &&
                (
                    this.ForceNoCache == input.ForceNoCache ||

                    this.ForceNoCache.Equals(input.ForceNoCache)
                ) &&
                (
                    this.ListingVisibility == input.ListingVisibility ||
                    (this.ListingVisibility != null &&
                    this.ListingVisibility.Equals(input.ListingVisibility))

                ) &&
                (
                    this.MaxLeaseTtl == input.MaxLeaseTtl ||

                    this.MaxLeaseTtl.Equals(input.MaxLeaseTtl)
                ) &&
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))

                ) &&
                (
                    this.PassthroughRequestHeaders == input.PassthroughRequestHeaders ||
                    this.PassthroughRequestHeaders != null &&
                    input.PassthroughRequestHeaders != null &&
                    this.PassthroughRequestHeaders.SequenceEqual(input.PassthroughRequestHeaders)
                ) &&
                (
                    this.PluginVersion == input.PluginVersion ||
                    (this.PluginVersion != null &&
                    this.PluginVersion.Equals(input.PluginVersion))

                ) &&
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))

                ) &&
                (
                    this.UserLockoutCounterResetDuration == input.UserLockoutCounterResetDuration ||

                    this.UserLockoutCounterResetDuration.Equals(input.UserLockoutCounterResetDuration)
                ) &&
                (
                    this.UserLockoutDisable == input.UserLockoutDisable ||

                    this.UserLockoutDisable.Equals(input.UserLockoutDisable)
                ) &&
                (
                    this.UserLockoutDuration == input.UserLockoutDuration ||

                    this.UserLockoutDuration.Equals(input.UserLockoutDuration)
                ) &&
                (
                    this.UserLockoutThreshold == input.UserLockoutThreshold ||

                    this.UserLockoutThreshold.Equals(input.UserLockoutThreshold)
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

                if (this.AllowedManagedKeys != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedManagedKeys.GetHashCode();
                }

                if (this.AllowedResponseHeaders != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedResponseHeaders.GetHashCode();
                }

                if (this.AuditNonHmacRequestKeys != null)
                {
                    hashCode = (hashCode * 59) + this.AuditNonHmacRequestKeys.GetHashCode();
                }

                if (this.AuditNonHmacResponseKeys != null)
                {
                    hashCode = (hashCode * 59) + this.AuditNonHmacResponseKeys.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.DefaultLeaseTtl.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.ExternalEntropyAccess.GetHashCode();

                hashCode = (hashCode * 59) + this.ForceNoCache.GetHashCode();
                if (this.ListingVisibility != null)
                {
                    hashCode = (hashCode * 59) + this.ListingVisibility.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.MaxLeaseTtl.GetHashCode();
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
                }

                if (this.PassthroughRequestHeaders != null)
                {
                    hashCode = (hashCode * 59) + this.PassthroughRequestHeaders.GetHashCode();
                }

                if (this.PluginVersion != null)
                {
                    hashCode = (hashCode * 59) + this.PluginVersion.GetHashCode();
                }

                if (this.TokenType != null)
                {
                    hashCode = (hashCode * 59) + this.TokenType.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.UserLockoutCounterResetDuration.GetHashCode();

                hashCode = (hashCode * 59) + this.UserLockoutDisable.GetHashCode();

                hashCode = (hashCode * 59) + this.UserLockoutDuration.GetHashCode();

                hashCode = (hashCode * 59) + this.UserLockoutThreshold.GetHashCode();
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
