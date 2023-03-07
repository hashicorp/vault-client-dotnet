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
    /// WriteAuthMethodTuneRequest
    /// </summary>
    [DataContract(Name = "WriteAuthMethodTuneRequest")]
    public partial class WriteAuthMethodTuneRequest : IEquatable<WriteAuthMethodTuneRequest>, IValidatableObject
    {














        /// <summary>
        /// Initializes a new instance of the <see cref="WriteAuthMethodTuneRequest" /> class.
        /// </summary>

        /// <param name="AllowedResponseHeaders">A list of headers to whitelist and allow a plugin to set on responses..</param>

        /// <param name="AuditNonHmacRequestKeys">The list of keys in the request data object that will not be HMAC&#x27;ed by audit devices..</param>

        /// <param name="AuditNonHmacResponseKeys">The list of keys in the response data object that will not be HMAC&#x27;ed by audit devices..</param>

        /// <param name="DefaultLeaseTtl">The default lease TTL for this mount..</param>

        /// <param name="Description">User-friendly description for this credential backend..</param>

        /// <param name="ListingVisibility">Determines the visibility of the mount in the UI-specific listing endpoint. Accepted value are &#x27;unauth&#x27; and &#x27;hidden&#x27;, with the empty default (&#x27;&#x27;) behaving like &#x27;hidden&#x27;..</param>

        /// <param name="MaxLeaseTtl">The max lease TTL for this mount..</param>

        /// <param name="Options">The options to pass into the backend. Should be a json object with string keys and values..</param>

        /// <param name="PassthroughRequestHeaders">A list of headers to whitelist and pass from the request to the plugin..</param>

        /// <param name="PluginVersion">The semantic version of the plugin to use..</param>

        /// <param name="TokenType">The type of token to issue (service or batch)..</param>

        /// <param name="UserLockoutConfig">The user lockout configuration to pass into the backend. Should be a json object with string keys and values..</param>


        public WriteAuthMethodTuneRequest(List<string> AllowedResponseHeaders = default(List<string>), List<string> AuditNonHmacRequestKeys = default(List<string>), List<string> AuditNonHmacResponseKeys = default(List<string>), string DefaultLeaseTtl = default(string), string Description = default(string), string ListingVisibility = default(string), string MaxLeaseTtl = default(string), Object Options = default(Object), List<string> PassthroughRequestHeaders = default(List<string>), string PluginVersion = default(string), string TokenType = default(string), Object UserLockoutConfig = default(Object))
        {

            this.AllowedResponseHeaders = AllowedResponseHeaders;

            this.AuditNonHmacRequestKeys = AuditNonHmacRequestKeys;

            this.AuditNonHmacResponseKeys = AuditNonHmacResponseKeys;

            this.DefaultLeaseTtl = DefaultLeaseTtl;

            this.Description = Description;

            this.ListingVisibility = ListingVisibility;

            this.MaxLeaseTtl = MaxLeaseTtl;

            this.Options = Options;

            this.PassthroughRequestHeaders = PassthroughRequestHeaders;

            this.PluginVersion = PluginVersion;

            this.TokenType = TokenType;

            this.UserLockoutConfig = UserLockoutConfig;

        }

        /// <summary>
        /// A list of headers to whitelist and allow a plugin to set on responses.
        /// </summary>
        /// <value>A list of headers to whitelist and allow a plugin to set on responses.</value>
        [DataMember(Name = "allowed_response_headers", EmitDefaultValue = false)]

        public List<string> AllowedResponseHeaders { get; set; }


        /// <summary>
        /// The list of keys in the request data object that will not be HMAC&#x27;ed by audit devices.
        /// </summary>
        /// <value>The list of keys in the request data object that will not be HMAC&#x27;ed by audit devices.</value>
        [DataMember(Name = "audit_non_hmac_request_keys", EmitDefaultValue = false)]

        public List<string> AuditNonHmacRequestKeys { get; set; }


        /// <summary>
        /// The list of keys in the response data object that will not be HMAC&#x27;ed by audit devices.
        /// </summary>
        /// <value>The list of keys in the response data object that will not be HMAC&#x27;ed by audit devices.</value>
        [DataMember(Name = "audit_non_hmac_response_keys", EmitDefaultValue = false)]

        public List<string> AuditNonHmacResponseKeys { get; set; }


        /// <summary>
        /// The default lease TTL for this mount.
        /// </summary>
        /// <value>The default lease TTL for this mount.</value>
        [DataMember(Name = "default_lease_ttl", EmitDefaultValue = false)]

        public string DefaultLeaseTtl { get; set; }


        /// <summary>
        /// User-friendly description for this credential backend.
        /// </summary>
        /// <value>User-friendly description for this credential backend.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]

        public string Description { get; set; }


        /// <summary>
        /// Determines the visibility of the mount in the UI-specific listing endpoint. Accepted value are &#x27;unauth&#x27; and &#x27;hidden&#x27;, with the empty default (&#x27;&#x27;) behaving like &#x27;hidden&#x27;.
        /// </summary>
        /// <value>Determines the visibility of the mount in the UI-specific listing endpoint. Accepted value are &#x27;unauth&#x27; and &#x27;hidden&#x27;, with the empty default (&#x27;&#x27;) behaving like &#x27;hidden&#x27;.</value>
        [DataMember(Name = "listing_visibility", EmitDefaultValue = false)]

        public string ListingVisibility { get; set; }


        /// <summary>
        /// The max lease TTL for this mount.
        /// </summary>
        /// <value>The max lease TTL for this mount.</value>
        [DataMember(Name = "max_lease_ttl", EmitDefaultValue = false)]

        public string MaxLeaseTtl { get; set; }


        /// <summary>
        /// The options to pass into the backend. Should be a json object with string keys and values.
        /// </summary>
        /// <value>The options to pass into the backend. Should be a json object with string keys and values.</value>
        [DataMember(Name = "options", EmitDefaultValue = false)]

        public Object Options { get; set; }


        /// <summary>
        /// A list of headers to whitelist and pass from the request to the plugin.
        /// </summary>
        /// <value>A list of headers to whitelist and pass from the request to the plugin.</value>
        [DataMember(Name = "passthrough_request_headers", EmitDefaultValue = false)]

        public List<string> PassthroughRequestHeaders { get; set; }


        /// <summary>
        /// The semantic version of the plugin to use.
        /// </summary>
        /// <value>The semantic version of the plugin to use.</value>
        [DataMember(Name = "plugin_version", EmitDefaultValue = false)]

        public string PluginVersion { get; set; }


        /// <summary>
        /// The type of token to issue (service or batch).
        /// </summary>
        /// <value>The type of token to issue (service or batch).</value>
        [DataMember(Name = "token_type", EmitDefaultValue = false)]

        public string TokenType { get; set; }


        /// <summary>
        /// The user lockout configuration to pass into the backend. Should be a json object with string keys and values.
        /// </summary>
        /// <value>The user lockout configuration to pass into the backend. Should be a json object with string keys and values.</value>
        [DataMember(Name = "user_lockout_config", EmitDefaultValue = false)]

        public Object UserLockoutConfig { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WriteAuthMethodTuneRequest {\n");
            sb.Append("  AllowedResponseHeaders: ").Append(AllowedResponseHeaders).Append("\n");
            sb.Append("  AuditNonHmacRequestKeys: ").Append(AuditNonHmacRequestKeys).Append("\n");
            sb.Append("  AuditNonHmacResponseKeys: ").Append(AuditNonHmacResponseKeys).Append("\n");
            sb.Append("  DefaultLeaseTtl: ").Append(DefaultLeaseTtl).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ListingVisibility: ").Append(ListingVisibility).Append("\n");
            sb.Append("  MaxLeaseTtl: ").Append(MaxLeaseTtl).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  PassthroughRequestHeaders: ").Append(PassthroughRequestHeaders).Append("\n");
            sb.Append("  PluginVersion: ").Append(PluginVersion).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  UserLockoutConfig: ").Append(UserLockoutConfig).Append("\n");
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
            return this.Equals(input as WriteAuthMethodTuneRequest);
        }

        /// <summary>
        /// Returns true if WriteAuthMethodTuneRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WriteAuthMethodTuneRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WriteAuthMethodTuneRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
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
                    (this.DefaultLeaseTtl != null &&
                    this.DefaultLeaseTtl.Equals(input.DefaultLeaseTtl))

                ) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))

                ) &&
                (
                    this.ListingVisibility == input.ListingVisibility ||
                    (this.ListingVisibility != null &&
                    this.ListingVisibility.Equals(input.ListingVisibility))

                ) &&
                (
                    this.MaxLeaseTtl == input.MaxLeaseTtl ||
                    (this.MaxLeaseTtl != null &&
                    this.MaxLeaseTtl.Equals(input.MaxLeaseTtl))

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
                    this.UserLockoutConfig == input.UserLockoutConfig ||
                    (this.UserLockoutConfig != null &&
                    this.UserLockoutConfig.Equals(input.UserLockoutConfig))

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

                if (this.DefaultLeaseTtl != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultLeaseTtl.GetHashCode();
                }

                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }

                if (this.ListingVisibility != null)
                {
                    hashCode = (hashCode * 59) + this.ListingVisibility.GetHashCode();
                }

                if (this.MaxLeaseTtl != null)
                {
                    hashCode = (hashCode * 59) + this.MaxLeaseTtl.GetHashCode();
                }

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

                if (this.UserLockoutConfig != null)
                {
                    hashCode = (hashCode * 59) + this.UserLockoutConfig.GetHashCode();
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
