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
    /// RadiusConfigureRequest
    /// </summary>
    [DataContract(Name = "RadiusConfigureRequest")]
    public partial class RadiusConfigureRequest : IEquatable<RadiusConfigureRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="RadiusConfigureRequest" /> class.
        /// </summary>

        /// <param name="DialTimeout">Number of seconds before connect times out (default: 10) (default to &quot;10&quot;).</param>

        /// <param name="Host">RADIUS server host.</param>

        /// <param name="NasIdentifier">RADIUS NAS Identifier field (optional) (default to &quot;&quot;).</param>

        /// <param name="NasPort">RADIUS NAS port field (default: 10) (default to 10).</param>

        /// <param name="Port">RADIUS server port (default: 1812) (default to 1812).</param>

        /// <param name="ReadTimeout">Number of seconds before response times out (default: 10) (default to &quot;10&quot;).</param>

        /// <param name="Secret">Secret shared with the RADIUS server.</param>

        /// <param name="TokenBoundCidrs">Comma separated string or JSON list of CIDR blocks. If set, specifies the blocks of IP addresses which are allowed to use the generated token..</param>

        /// <param name="TokenExplicitMaxTtl">If set, tokens created via this role carry an explicit maximum TTL. During renewal, the current maximum TTL values of the role and the mount are not checked for changes, and any updates to these values will have no effect on the token being renewed..</param>

        /// <param name="TokenMaxTtl">The maximum lifetime of the generated token.</param>

        /// <param name="TokenNoDefaultPolicy">If true, the &#x27;default&#x27; policy will not automatically be added to generated tokens.</param>

        /// <param name="TokenNumUses">The maximum number of times a token may be used, a value of zero means unlimited.</param>

        /// <param name="TokenPeriod">If set, tokens created via this role will have no max lifetime; instead, their renewal period will be fixed to this value. This takes an integer number of seconds, or a string duration (e.g. \&quot;24h\&quot;)..</param>

        /// <param name="TokenPolicies">Comma-separated list of policies. This will apply to all tokens generated by this auth method, in addition to any configured for specific users..</param>

        /// <param name="TokenTtl">The initial ttl of the token to generate.</param>

        /// <param name="TokenType">The type of token to generate, service or batch (default to &quot;default-service&quot;).</param>

        /// <param name="UnregisteredUserPolicies">Comma-separated list of policies to grant upon successful RADIUS authentication of an unregistered user (default: empty) (default to &quot;&quot;).</param>


        public RadiusConfigureRequest(string DialTimeout = "10", string Host = default(string), string NasIdentifier = "", int NasPort = 10, int Port = 1812, string ReadTimeout = "10", string Secret = default(string), List<string> TokenBoundCidrs = default(List<string>), string TokenExplicitMaxTtl = default(string), string TokenMaxTtl = default(string), bool TokenNoDefaultPolicy = default(bool), int TokenNumUses = default(int), string TokenPeriod = default(string), List<string> TokenPolicies = default(List<string>), string TokenTtl = default(string), string TokenType = "default-service", string UnregisteredUserPolicies = "")
        {

            // use default value if no "DialTimeout" provided
            this.DialTimeout = DialTimeout ?? "10";


            this.Host = Host;

            // use default value if no "NasIdentifier" provided
            this.NasIdentifier = NasIdentifier ?? "";


            this.NasPort = NasPort;

            this.Port = Port;

            // use default value if no "ReadTimeout" provided
            this.ReadTimeout = ReadTimeout ?? "10";


            this.Secret = Secret;

            this.TokenBoundCidrs = TokenBoundCidrs;

            this.TokenExplicitMaxTtl = TokenExplicitMaxTtl;

            this.TokenMaxTtl = TokenMaxTtl;

            this.TokenNoDefaultPolicy = TokenNoDefaultPolicy;

            this.TokenNumUses = TokenNumUses;

            this.TokenPeriod = TokenPeriod;

            this.TokenPolicies = TokenPolicies;

            this.TokenTtl = TokenTtl;

            // use default value if no "TokenType" provided
            this.TokenType = TokenType ?? "default-service";


            // use default value if no "UnregisteredUserPolicies" provided
            this.UnregisteredUserPolicies = UnregisteredUserPolicies ?? "";


        }

        /// <summary>
        /// Number of seconds before connect times out (default: 10)
        /// </summary>
        /// <value>Number of seconds before connect times out (default: 10)</value>
        [DataMember(Name = "dial_timeout", EmitDefaultValue = false)]

        public string DialTimeout { get; set; }


        /// <summary>
        /// RADIUS server host
        /// </summary>
        /// <value>RADIUS server host</value>
        [DataMember(Name = "host", EmitDefaultValue = false)]

        public string Host { get; set; }


        /// <summary>
        /// RADIUS NAS Identifier field (optional)
        /// </summary>
        /// <value>RADIUS NAS Identifier field (optional)</value>
        [DataMember(Name = "nas_identifier", EmitDefaultValue = false)]

        public string NasIdentifier { get; set; }


        /// <summary>
        /// RADIUS NAS port field (default: 10)
        /// </summary>
        /// <value>RADIUS NAS port field (default: 10)</value>
        [DataMember(Name = "nas_port", EmitDefaultValue = false)]

        public int NasPort { get; set; }


        /// <summary>
        /// RADIUS server port (default: 1812)
        /// </summary>
        /// <value>RADIUS server port (default: 1812)</value>
        [DataMember(Name = "port", EmitDefaultValue = false)]

        public int Port { get; set; }


        /// <summary>
        /// Number of seconds before response times out (default: 10)
        /// </summary>
        /// <value>Number of seconds before response times out (default: 10)</value>
        [DataMember(Name = "read_timeout", EmitDefaultValue = false)]

        public string ReadTimeout { get; set; }


        /// <summary>
        /// Secret shared with the RADIUS server
        /// </summary>
        /// <value>Secret shared with the RADIUS server</value>
        [DataMember(Name = "secret", EmitDefaultValue = false)]

        public string Secret { get; set; }


        /// <summary>
        /// Comma separated string or JSON list of CIDR blocks. If set, specifies the blocks of IP addresses which are allowed to use the generated token.
        /// </summary>
        /// <value>Comma separated string or JSON list of CIDR blocks. If set, specifies the blocks of IP addresses which are allowed to use the generated token.</value>
        [DataMember(Name = "token_bound_cidrs", EmitDefaultValue = false)]

        public List<string> TokenBoundCidrs { get; set; }


        /// <summary>
        /// If set, tokens created via this role carry an explicit maximum TTL. During renewal, the current maximum TTL values of the role and the mount are not checked for changes, and any updates to these values will have no effect on the token being renewed.
        /// </summary>
        /// <value>If set, tokens created via this role carry an explicit maximum TTL. During renewal, the current maximum TTL values of the role and the mount are not checked for changes, and any updates to these values will have no effect on the token being renewed.</value>
        [DataMember(Name = "token_explicit_max_ttl", EmitDefaultValue = false)]

        public string TokenExplicitMaxTtl { get; set; }


        /// <summary>
        /// The maximum lifetime of the generated token
        /// </summary>
        /// <value>The maximum lifetime of the generated token</value>
        [DataMember(Name = "token_max_ttl", EmitDefaultValue = false)]

        public string TokenMaxTtl { get; set; }


        /// <summary>
        /// If true, the &#x27;default&#x27; policy will not automatically be added to generated tokens
        /// </summary>
        /// <value>If true, the &#x27;default&#x27; policy will not automatically be added to generated tokens</value>
        [DataMember(Name = "token_no_default_policy", EmitDefaultValue = true)]

        public bool TokenNoDefaultPolicy { get; set; }


        /// <summary>
        /// The maximum number of times a token may be used, a value of zero means unlimited
        /// </summary>
        /// <value>The maximum number of times a token may be used, a value of zero means unlimited</value>
        [DataMember(Name = "token_num_uses", EmitDefaultValue = false)]

        public int TokenNumUses { get; set; }


        /// <summary>
        /// If set, tokens created via this role will have no max lifetime; instead, their renewal period will be fixed to this value. This takes an integer number of seconds, or a string duration (e.g. \&quot;24h\&quot;).
        /// </summary>
        /// <value>If set, tokens created via this role will have no max lifetime; instead, their renewal period will be fixed to this value. This takes an integer number of seconds, or a string duration (e.g. \&quot;24h\&quot;).</value>
        [DataMember(Name = "token_period", EmitDefaultValue = false)]

        public string TokenPeriod { get; set; }


        /// <summary>
        /// Comma-separated list of policies. This will apply to all tokens generated by this auth method, in addition to any configured for specific users.
        /// </summary>
        /// <value>Comma-separated list of policies. This will apply to all tokens generated by this auth method, in addition to any configured for specific users.</value>
        [DataMember(Name = "token_policies", EmitDefaultValue = false)]

        public List<string> TokenPolicies { get; set; }


        /// <summary>
        /// The initial ttl of the token to generate
        /// </summary>
        /// <value>The initial ttl of the token to generate</value>
        [DataMember(Name = "token_ttl", EmitDefaultValue = false)]

        public string TokenTtl { get; set; }


        /// <summary>
        /// The type of token to generate, service or batch
        /// </summary>
        /// <value>The type of token to generate, service or batch</value>
        [DataMember(Name = "token_type", EmitDefaultValue = false)]

        public string TokenType { get; set; }


        /// <summary>
        /// Comma-separated list of policies to grant upon successful RADIUS authentication of an unregistered user (default: empty)
        /// </summary>
        /// <value>Comma-separated list of policies to grant upon successful RADIUS authentication of an unregistered user (default: empty)</value>
        [DataMember(Name = "unregistered_user_policies", EmitDefaultValue = false)]

        public string UnregisteredUserPolicies { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RadiusConfigureRequest {\n");
            sb.Append("  DialTimeout: ").Append(DialTimeout).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  NasIdentifier: ").Append(NasIdentifier).Append("\n");
            sb.Append("  NasPort: ").Append(NasPort).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  ReadTimeout: ").Append(ReadTimeout).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  TokenBoundCidrs: ").Append(TokenBoundCidrs).Append("\n");
            sb.Append("  TokenExplicitMaxTtl: ").Append(TokenExplicitMaxTtl).Append("\n");
            sb.Append("  TokenMaxTtl: ").Append(TokenMaxTtl).Append("\n");
            sb.Append("  TokenNoDefaultPolicy: ").Append(TokenNoDefaultPolicy).Append("\n");
            sb.Append("  TokenNumUses: ").Append(TokenNumUses).Append("\n");
            sb.Append("  TokenPeriod: ").Append(TokenPeriod).Append("\n");
            sb.Append("  TokenPolicies: ").Append(TokenPolicies).Append("\n");
            sb.Append("  TokenTtl: ").Append(TokenTtl).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  UnregisteredUserPolicies: ").Append(UnregisteredUserPolicies).Append("\n");
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
            return this.Equals(input as RadiusConfigureRequest);
        }

        /// <summary>
        /// Returns true if RadiusConfigureRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RadiusConfigureRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RadiusConfigureRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.DialTimeout == input.DialTimeout ||
                    (this.DialTimeout != null &&
                    this.DialTimeout.Equals(input.DialTimeout))

                ) &&
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))

                ) &&
                (
                    this.NasIdentifier == input.NasIdentifier ||
                    (this.NasIdentifier != null &&
                    this.NasIdentifier.Equals(input.NasIdentifier))

                ) &&
                (
                    this.NasPort == input.NasPort ||

                    this.NasPort.Equals(input.NasPort)
                ) &&
                (
                    this.Port == input.Port ||

                    this.Port.Equals(input.Port)
                ) &&
                (
                    this.ReadTimeout == input.ReadTimeout ||
                    (this.ReadTimeout != null &&
                    this.ReadTimeout.Equals(input.ReadTimeout))

                ) &&
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))

                ) &&
                (
                    this.TokenBoundCidrs == input.TokenBoundCidrs ||
                    this.TokenBoundCidrs != null &&
                    input.TokenBoundCidrs != null &&
                    this.TokenBoundCidrs.SequenceEqual(input.TokenBoundCidrs)
                ) &&
                (
                    this.TokenExplicitMaxTtl == input.TokenExplicitMaxTtl ||
                    (this.TokenExplicitMaxTtl != null &&
                    this.TokenExplicitMaxTtl.Equals(input.TokenExplicitMaxTtl))

                ) &&
                (
                    this.TokenMaxTtl == input.TokenMaxTtl ||
                    (this.TokenMaxTtl != null &&
                    this.TokenMaxTtl.Equals(input.TokenMaxTtl))

                ) &&
                (
                    this.TokenNoDefaultPolicy == input.TokenNoDefaultPolicy ||

                    this.TokenNoDefaultPolicy.Equals(input.TokenNoDefaultPolicy)
                ) &&
                (
                    this.TokenNumUses == input.TokenNumUses ||

                    this.TokenNumUses.Equals(input.TokenNumUses)
                ) &&
                (
                    this.TokenPeriod == input.TokenPeriod ||
                    (this.TokenPeriod != null &&
                    this.TokenPeriod.Equals(input.TokenPeriod))

                ) &&
                (
                    this.TokenPolicies == input.TokenPolicies ||
                    this.TokenPolicies != null &&
                    input.TokenPolicies != null &&
                    this.TokenPolicies.SequenceEqual(input.TokenPolicies)
                ) &&
                (
                    this.TokenTtl == input.TokenTtl ||
                    (this.TokenTtl != null &&
                    this.TokenTtl.Equals(input.TokenTtl))

                ) &&
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))

                ) &&
                (
                    this.UnregisteredUserPolicies == input.UnregisteredUserPolicies ||
                    (this.UnregisteredUserPolicies != null &&
                    this.UnregisteredUserPolicies.Equals(input.UnregisteredUserPolicies))

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

                if (this.DialTimeout != null)
                {
                    hashCode = (hashCode * 59) + this.DialTimeout.GetHashCode();
                }

                if (this.Host != null)
                {
                    hashCode = (hashCode * 59) + this.Host.GetHashCode();
                }

                if (this.NasIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.NasIdentifier.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.NasPort.GetHashCode();

                hashCode = (hashCode * 59) + this.Port.GetHashCode();
                if (this.ReadTimeout != null)
                {
                    hashCode = (hashCode * 59) + this.ReadTimeout.GetHashCode();
                }

                if (this.Secret != null)
                {
                    hashCode = (hashCode * 59) + this.Secret.GetHashCode();
                }

                if (this.TokenBoundCidrs != null)
                {
                    hashCode = (hashCode * 59) + this.TokenBoundCidrs.GetHashCode();
                }

                if (this.TokenExplicitMaxTtl != null)
                {
                    hashCode = (hashCode * 59) + this.TokenExplicitMaxTtl.GetHashCode();
                }

                if (this.TokenMaxTtl != null)
                {
                    hashCode = (hashCode * 59) + this.TokenMaxTtl.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.TokenNoDefaultPolicy.GetHashCode();

                hashCode = (hashCode * 59) + this.TokenNumUses.GetHashCode();
                if (this.TokenPeriod != null)
                {
                    hashCode = (hashCode * 59) + this.TokenPeriod.GetHashCode();
                }

                if (this.TokenPolicies != null)
                {
                    hashCode = (hashCode * 59) + this.TokenPolicies.GetHashCode();
                }

                if (this.TokenTtl != null)
                {
                    hashCode = (hashCode * 59) + this.TokenTtl.GetHashCode();
                }

                if (this.TokenType != null)
                {
                    hashCode = (hashCode * 59) + this.TokenType.GetHashCode();
                }

                if (this.UnregisteredUserPolicies != null)
                {
                    hashCode = (hashCode * 59) + this.UnregisteredUserPolicies.GetHashCode();
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
