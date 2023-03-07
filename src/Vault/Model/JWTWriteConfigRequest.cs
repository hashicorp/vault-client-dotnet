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
    /// JWTWriteConfigRequest
    /// </summary>
    [DataContract(Name = "JWTWriteConfigRequest")]
    public partial class JWTWriteConfigRequest : IEquatable<JWTWriteConfigRequest>, IValidatableObject
    {































        /// <summary>
        /// Initializes a new instance of the <see cref="JWTWriteConfigRequest" /> class.
        /// </summary>

        /// <param name="BoundIssuer">The value against which to match the &#x27;iss&#x27; claim in a JWT. Optional..</param>

        /// <param name="DefaultRole">The default role to use if none is provided during login. If not set, a role is required during login..</param>

        /// <param name="JwksCaPem">The CA certificate or chain of certificates, in PEM format, to use to validate connections to the JWKS URL. If not set, system certificates are used..</param>

        /// <param name="JwksUrl">JWKS URL to use to authenticate signatures. Cannot be used with \&quot;oidc_discovery_url\&quot; or \&quot;jwt_validation_pubkeys\&quot;..</param>

        /// <param name="JwtSupportedAlgs">A list of supported signing algorithms. Defaults to RS256..</param>

        /// <param name="JwtValidationPubkeys">A list of PEM-encoded public keys to use to authenticate signatures locally. Cannot be used with \&quot;jwks_url\&quot; or \&quot;oidc_discovery_url\&quot;..</param>

        /// <param name="NamespaceInState">Pass namespace in the OIDC state parameter instead of as a separate query parameter. With this setting, the allowed redirect URL(s) in Vault and on the provider side should not contain a namespace query parameter. This means only one redirect URL entry needs to be maintained on the provider side for all vault namespaces that will be authenticating against it. Defaults to true for new configs..</param>

        /// <param name="OidcClientId">The OAuth Client ID configured with your OIDC provider..</param>

        /// <param name="OidcClientSecret">The OAuth Client Secret configured with your OIDC provider..</param>

        /// <param name="OidcDiscoveryCaPem">The CA certificate or chain of certificates, in PEM format, to use to validate connections to the OIDC Discovery URL. If not set, system certificates are used..</param>

        /// <param name="OidcDiscoveryUrl">OIDC Discovery URL, without any .well-known component (base path). Cannot be used with \&quot;jwks_url\&quot; or \&quot;jwt_validation_pubkeys\&quot;..</param>

        /// <param name="OidcResponseMode">The response mode to be used in the OAuth2 request. Allowed values are &#x27;query&#x27; and &#x27;form_post&#x27;..</param>

        /// <param name="OidcResponseTypes">The response types to request. Allowed values are &#x27;code&#x27; and &#x27;id_token&#x27;. Defaults to &#x27;code&#x27;..</param>

        /// <param name="ProviderConfig">Provider-specific configuration. Optional..</param>


        public JWTWriteConfigRequest(string BoundIssuer = default(string), string DefaultRole = default(string), string JwksCaPem = default(string), string JwksUrl = default(string), List<string> JwtSupportedAlgs = default(List<string>), List<string> JwtValidationPubkeys = default(List<string>), bool NamespaceInState = default(bool), string OidcClientId = default(string), string OidcClientSecret = default(string), string OidcDiscoveryCaPem = default(string), string OidcDiscoveryUrl = default(string), string OidcResponseMode = default(string), List<string> OidcResponseTypes = default(List<string>), Object ProviderConfig = default(Object))
        {

            this.BoundIssuer = BoundIssuer;

            this.DefaultRole = DefaultRole;

            this.JwksCaPem = JwksCaPem;

            this.JwksUrl = JwksUrl;

            this.JwtSupportedAlgs = JwtSupportedAlgs;

            this.JwtValidationPubkeys = JwtValidationPubkeys;

            this.NamespaceInState = NamespaceInState;

            this.OidcClientId = OidcClientId;

            this.OidcClientSecret = OidcClientSecret;

            this.OidcDiscoveryCaPem = OidcDiscoveryCaPem;

            this.OidcDiscoveryUrl = OidcDiscoveryUrl;

            this.OidcResponseMode = OidcResponseMode;

            this.OidcResponseTypes = OidcResponseTypes;

            this.ProviderConfig = ProviderConfig;

        }

        /// <summary>
        /// The value against which to match the &#x27;iss&#x27; claim in a JWT. Optional.
        /// </summary>
        /// <value>The value against which to match the &#x27;iss&#x27; claim in a JWT. Optional.</value>
        [DataMember(Name = "bound_issuer", EmitDefaultValue = false)]


        public string BoundIssuer { get; set; }


        /// <summary>
        /// The default role to use if none is provided during login. If not set, a role is required during login.
        /// </summary>
        /// <value>The default role to use if none is provided during login. If not set, a role is required during login.</value>
        [DataMember(Name = "default_role", EmitDefaultValue = false)]


        public string DefaultRole { get; set; }


        /// <summary>
        /// The CA certificate or chain of certificates, in PEM format, to use to validate connections to the JWKS URL. If not set, system certificates are used.
        /// </summary>
        /// <value>The CA certificate or chain of certificates, in PEM format, to use to validate connections to the JWKS URL. If not set, system certificates are used.</value>
        [DataMember(Name = "jwks_ca_pem", EmitDefaultValue = false)]


        public string JwksCaPem { get; set; }


        /// <summary>
        /// JWKS URL to use to authenticate signatures. Cannot be used with \&quot;oidc_discovery_url\&quot; or \&quot;jwt_validation_pubkeys\&quot;.
        /// </summary>
        /// <value>JWKS URL to use to authenticate signatures. Cannot be used with \&quot;oidc_discovery_url\&quot; or \&quot;jwt_validation_pubkeys\&quot;.</value>
        [DataMember(Name = "jwks_url", EmitDefaultValue = false)]


        public string JwksUrl { get; set; }


        /// <summary>
        /// A list of supported signing algorithms. Defaults to RS256.
        /// </summary>
        /// <value>A list of supported signing algorithms. Defaults to RS256.</value>
        [DataMember(Name = "jwt_supported_algs", EmitDefaultValue = false)]


        public List<string> JwtSupportedAlgs { get; set; }


        /// <summary>
        /// A list of PEM-encoded public keys to use to authenticate signatures locally. Cannot be used with \&quot;jwks_url\&quot; or \&quot;oidc_discovery_url\&quot;.
        /// </summary>
        /// <value>A list of PEM-encoded public keys to use to authenticate signatures locally. Cannot be used with \&quot;jwks_url\&quot; or \&quot;oidc_discovery_url\&quot;.</value>
        [DataMember(Name = "jwt_validation_pubkeys", EmitDefaultValue = false)]


        public List<string> JwtValidationPubkeys { get; set; }


        /// <summary>
        /// Pass namespace in the OIDC state parameter instead of as a separate query parameter. With this setting, the allowed redirect URL(s) in Vault and on the provider side should not contain a namespace query parameter. This means only one redirect URL entry needs to be maintained on the provider side for all vault namespaces that will be authenticating against it. Defaults to true for new configs.
        /// </summary>
        /// <value>Pass namespace in the OIDC state parameter instead of as a separate query parameter. With this setting, the allowed redirect URL(s) in Vault and on the provider side should not contain a namespace query parameter. This means only one redirect URL entry needs to be maintained on the provider side for all vault namespaces that will be authenticating against it. Defaults to true for new configs.</value>
        [DataMember(Name = "namespace_in_state", EmitDefaultValue = true)]


        public bool NamespaceInState { get; set; }


        /// <summary>
        /// The OAuth Client ID configured with your OIDC provider.
        /// </summary>
        /// <value>The OAuth Client ID configured with your OIDC provider.</value>
        [DataMember(Name = "oidc_client_id", EmitDefaultValue = false)]


        public string OidcClientId { get; set; }


        /// <summary>
        /// The OAuth Client Secret configured with your OIDC provider.
        /// </summary>
        /// <value>The OAuth Client Secret configured with your OIDC provider.</value>
        [DataMember(Name = "oidc_client_secret", EmitDefaultValue = false)]


        public string OidcClientSecret { get; set; }


        /// <summary>
        /// The CA certificate or chain of certificates, in PEM format, to use to validate connections to the OIDC Discovery URL. If not set, system certificates are used.
        /// </summary>
        /// <value>The CA certificate or chain of certificates, in PEM format, to use to validate connections to the OIDC Discovery URL. If not set, system certificates are used.</value>
        [DataMember(Name = "oidc_discovery_ca_pem", EmitDefaultValue = false)]


        public string OidcDiscoveryCaPem { get; set; }


        /// <summary>
        /// OIDC Discovery URL, without any .well-known component (base path). Cannot be used with \&quot;jwks_url\&quot; or \&quot;jwt_validation_pubkeys\&quot;.
        /// </summary>
        /// <value>OIDC Discovery URL, without any .well-known component (base path). Cannot be used with \&quot;jwks_url\&quot; or \&quot;jwt_validation_pubkeys\&quot;.</value>
        [DataMember(Name = "oidc_discovery_url", EmitDefaultValue = false)]


        public string OidcDiscoveryUrl { get; set; }


        /// <summary>
        /// The response mode to be used in the OAuth2 request. Allowed values are &#x27;query&#x27; and &#x27;form_post&#x27;.
        /// </summary>
        /// <value>The response mode to be used in the OAuth2 request. Allowed values are &#x27;query&#x27; and &#x27;form_post&#x27;.</value>
        [DataMember(Name = "oidc_response_mode", EmitDefaultValue = false)]


        public string OidcResponseMode { get; set; }


        /// <summary>
        /// The response types to request. Allowed values are &#x27;code&#x27; and &#x27;id_token&#x27;. Defaults to &#x27;code&#x27;.
        /// </summary>
        /// <value>The response types to request. Allowed values are &#x27;code&#x27; and &#x27;id_token&#x27;. Defaults to &#x27;code&#x27;.</value>
        [DataMember(Name = "oidc_response_types", EmitDefaultValue = false)]


        public List<string> OidcResponseTypes { get; set; }


        /// <summary>
        /// Provider-specific configuration. Optional.
        /// </summary>
        /// <value>Provider-specific configuration. Optional.</value>
        [DataMember(Name = "provider_config", EmitDefaultValue = false)]


        public Object ProviderConfig { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JWTWriteConfigRequest {\n");
            sb.Append("  BoundIssuer: ").Append(BoundIssuer).Append("\n");
            sb.Append("  DefaultRole: ").Append(DefaultRole).Append("\n");
            sb.Append("  JwksCaPem: ").Append(JwksCaPem).Append("\n");
            sb.Append("  JwksUrl: ").Append(JwksUrl).Append("\n");
            sb.Append("  JwtSupportedAlgs: ").Append(JwtSupportedAlgs).Append("\n");
            sb.Append("  JwtValidationPubkeys: ").Append(JwtValidationPubkeys).Append("\n");
            sb.Append("  NamespaceInState: ").Append(NamespaceInState).Append("\n");
            sb.Append("  OidcClientId: ").Append(OidcClientId).Append("\n");
            sb.Append("  OidcClientSecret: ").Append(OidcClientSecret).Append("\n");
            sb.Append("  OidcDiscoveryCaPem: ").Append(OidcDiscoveryCaPem).Append("\n");
            sb.Append("  OidcDiscoveryUrl: ").Append(OidcDiscoveryUrl).Append("\n");
            sb.Append("  OidcResponseMode: ").Append(OidcResponseMode).Append("\n");
            sb.Append("  OidcResponseTypes: ").Append(OidcResponseTypes).Append("\n");
            sb.Append("  ProviderConfig: ").Append(ProviderConfig).Append("\n");
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
            return this.Equals(input as JWTWriteConfigRequest);
        }

        /// <summary>
        /// Returns true if JWTWriteConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of JWTWriteConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JWTWriteConfigRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.BoundIssuer == input.BoundIssuer ||
                    (this.BoundIssuer != null &&
                    this.BoundIssuer.Equals(input.BoundIssuer))

                ) &&
                (
                    this.DefaultRole == input.DefaultRole ||
                    (this.DefaultRole != null &&
                    this.DefaultRole.Equals(input.DefaultRole))

                ) &&
                (
                    this.JwksCaPem == input.JwksCaPem ||
                    (this.JwksCaPem != null &&
                    this.JwksCaPem.Equals(input.JwksCaPem))

                ) &&
                (
                    this.JwksUrl == input.JwksUrl ||
                    (this.JwksUrl != null &&
                    this.JwksUrl.Equals(input.JwksUrl))

                ) &&
                (
                    this.JwtSupportedAlgs == input.JwtSupportedAlgs ||
                    this.JwtSupportedAlgs != null &&
                    input.JwtSupportedAlgs != null &&
                    this.JwtSupportedAlgs.SequenceEqual(input.JwtSupportedAlgs)
                ) &&
                (
                    this.JwtValidationPubkeys == input.JwtValidationPubkeys ||
                    this.JwtValidationPubkeys != null &&
                    input.JwtValidationPubkeys != null &&
                    this.JwtValidationPubkeys.SequenceEqual(input.JwtValidationPubkeys)
                ) &&
                (
                    this.NamespaceInState == input.NamespaceInState ||

                    this.NamespaceInState.Equals(input.NamespaceInState)
                ) &&
                (
                    this.OidcClientId == input.OidcClientId ||
                    (this.OidcClientId != null &&
                    this.OidcClientId.Equals(input.OidcClientId))

                ) &&
                (
                    this.OidcClientSecret == input.OidcClientSecret ||
                    (this.OidcClientSecret != null &&
                    this.OidcClientSecret.Equals(input.OidcClientSecret))

                ) &&
                (
                    this.OidcDiscoveryCaPem == input.OidcDiscoveryCaPem ||
                    (this.OidcDiscoveryCaPem != null &&
                    this.OidcDiscoveryCaPem.Equals(input.OidcDiscoveryCaPem))

                ) &&
                (
                    this.OidcDiscoveryUrl == input.OidcDiscoveryUrl ||
                    (this.OidcDiscoveryUrl != null &&
                    this.OidcDiscoveryUrl.Equals(input.OidcDiscoveryUrl))

                ) &&
                (
                    this.OidcResponseMode == input.OidcResponseMode ||
                    (this.OidcResponseMode != null &&
                    this.OidcResponseMode.Equals(input.OidcResponseMode))

                ) &&
                (
                    this.OidcResponseTypes == input.OidcResponseTypes ||
                    this.OidcResponseTypes != null &&
                    input.OidcResponseTypes != null &&
                    this.OidcResponseTypes.SequenceEqual(input.OidcResponseTypes)
                ) &&
                (
                    this.ProviderConfig == input.ProviderConfig ||
                    (this.ProviderConfig != null &&
                    this.ProviderConfig.Equals(input.ProviderConfig))

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

                if (this.BoundIssuer != null)
                {
                    hashCode = (hashCode * 59) + this.BoundIssuer.GetHashCode();
                }

                if (this.DefaultRole != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultRole.GetHashCode();
                }

                if (this.JwksCaPem != null)
                {
                    hashCode = (hashCode * 59) + this.JwksCaPem.GetHashCode();
                }

                if (this.JwksUrl != null)
                {
                    hashCode = (hashCode * 59) + this.JwksUrl.GetHashCode();
                }

                if (this.JwtSupportedAlgs != null)
                {
                    hashCode = (hashCode * 59) + this.JwtSupportedAlgs.GetHashCode();
                }

                if (this.JwtValidationPubkeys != null)
                {
                    hashCode = (hashCode * 59) + this.JwtValidationPubkeys.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.NamespaceInState.GetHashCode();
                if (this.OidcClientId != null)
                {
                    hashCode = (hashCode * 59) + this.OidcClientId.GetHashCode();
                }

                if (this.OidcClientSecret != null)
                {
                    hashCode = (hashCode * 59) + this.OidcClientSecret.GetHashCode();
                }

                if (this.OidcDiscoveryCaPem != null)
                {
                    hashCode = (hashCode * 59) + this.OidcDiscoveryCaPem.GetHashCode();
                }

                if (this.OidcDiscoveryUrl != null)
                {
                    hashCode = (hashCode * 59) + this.OidcDiscoveryUrl.GetHashCode();
                }

                if (this.OidcResponseMode != null)
                {
                    hashCode = (hashCode * 59) + this.OidcResponseMode.GetHashCode();
                }

                if (this.OidcResponseTypes != null)
                {
                    hashCode = (hashCode * 59) + this.OidcResponseTypes.GetHashCode();
                }

                if (this.ProviderConfig != null)
                {
                    hashCode = (hashCode * 59) + this.ProviderConfig.GetHashCode();
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
