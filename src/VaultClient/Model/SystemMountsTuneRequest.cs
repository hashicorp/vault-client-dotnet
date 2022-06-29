/*
 * HashiCorp Vault API
 *
 * HTTP API that gives you full access to Vault. All API routes are prefixed with `/v1/`.
 *
 * The version of the OpenAPI document: 1.11.0
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
    /// SystemMountsTuneRequest
    /// </summary>
    [DataContract(Name = "SystemMountsTuneRequest")]
    public partial class SystemMountsTuneRequest : IEquatable<SystemMountsTuneRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemMountsTuneRequest" /> class.
        /// </summary>
        /// <param name="allowedManagedKeys">allowedManagedKeys.</param>
        /// <param name="allowedResponseHeaders">A list of headers to whitelist and allow a plugin to set on responses..</param>
        /// <param name="auditNonHmacRequestKeys">The list of keys in the request data object that will not be HMAC&#39;ed by audit devices..</param>
        /// <param name="auditNonHmacResponseKeys">The list of keys in the response data object that will not be HMAC&#39;ed by audit devices..</param>
        /// <param name="defaultLeaseTtl">The default lease TTL for this mount..</param>
        /// <param name="description">User-friendly description for this credential backend..</param>
        /// <param name="listingVisibility">Determines the visibility of the mount in the UI-specific listing endpoint. Accepted value are &#39;unauth&#39; and &#39;&#39;..</param>
        /// <param name="maxLeaseTtl">The max lease TTL for this mount..</param>
        /// <param name="options">The options to pass into the backend. Should be a json object with string keys and values..</param>
        /// <param name="passthroughRequestHeaders">A list of headers to whitelist and pass from the request to the plugin..</param>
        /// <param name="tokenType">The type of token to issue (service or batch)..</param>
        public SystemMountsTuneRequest(List<string> allowedManagedKeys = default(List<string>), List<string> allowedResponseHeaders = default(List<string>), List<string> auditNonHmacRequestKeys = default(List<string>), List<string> auditNonHmacResponseKeys = default(List<string>), string defaultLeaseTtl = default(string), string description = default(string), string listingVisibility = default(string), string maxLeaseTtl = default(string), Object options = default(Object), List<string> passthroughRequestHeaders = default(List<string>), string tokenType = default(string))
        {
            this.AllowedManagedKeys = allowedManagedKeys;
            this.AllowedResponseHeaders = allowedResponseHeaders;
            this.AuditNonHmacRequestKeys = auditNonHmacRequestKeys;
            this.AuditNonHmacResponseKeys = auditNonHmacResponseKeys;
            this.DefaultLeaseTtl = defaultLeaseTtl;
            this.Description = description;
            this.ListingVisibility = listingVisibility;
            this.MaxLeaseTtl = maxLeaseTtl;
            this.Options = options;
            this.PassthroughRequestHeaders = passthroughRequestHeaders;
            this.TokenType = tokenType;
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
        /// The list of keys in the request data object that will not be HMAC&#39;ed by audit devices.
        /// </summary>
        /// <value>The list of keys in the request data object that will not be HMAC&#39;ed by audit devices.</value>
        [DataMember(Name = "audit_non_hmac_request_keys", EmitDefaultValue = false)]
        public List<string> AuditNonHmacRequestKeys { get; set; }

        /// <summary>
        /// The list of keys in the response data object that will not be HMAC&#39;ed by audit devices.
        /// </summary>
        /// <value>The list of keys in the response data object that will not be HMAC&#39;ed by audit devices.</value>
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
        /// Determines the visibility of the mount in the UI-specific listing endpoint. Accepted value are &#39;unauth&#39; and &#39;&#39;.
        /// </summary>
        /// <value>Determines the visibility of the mount in the UI-specific listing endpoint. Accepted value are &#39;unauth&#39; and &#39;&#39;.</value>
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
        /// The type of token to issue (service or batch).
        /// </summary>
        /// <value>The type of token to issue (service or batch).</value>
        [DataMember(Name = "token_type", EmitDefaultValue = false)]
        public string TokenType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SystemMountsTuneRequest {\n");
            sb.Append("  AllowedManagedKeys: ").Append(AllowedManagedKeys).Append("\n");
            sb.Append("  AllowedResponseHeaders: ").Append(AllowedResponseHeaders).Append("\n");
            sb.Append("  AuditNonHmacRequestKeys: ").Append(AuditNonHmacRequestKeys).Append("\n");
            sb.Append("  AuditNonHmacResponseKeys: ").Append(AuditNonHmacResponseKeys).Append("\n");
            sb.Append("  DefaultLeaseTtl: ").Append(DefaultLeaseTtl).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ListingVisibility: ").Append(ListingVisibility).Append("\n");
            sb.Append("  MaxLeaseTtl: ").Append(MaxLeaseTtl).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  PassthroughRequestHeaders: ").Append(PassthroughRequestHeaders).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
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
            return this.Equals(input as SystemMountsTuneRequest);
        }

        /// <summary>
        /// Returns true if SystemMountsTuneRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemMountsTuneRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemMountsTuneRequest input)
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
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
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
                if (this.TokenType != null)
                {
                    hashCode = (hashCode * 59) + this.TokenType.GetHashCode();
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
