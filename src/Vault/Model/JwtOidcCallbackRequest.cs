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
using FileParameter = Vault.Client.FileParameter;
using OpenAPIDateConverter = Vault.Client.OpenAPIDateConverter;

namespace Vault.Model
{
    /// <summary>
    /// JwtOidcCallbackRequest
    /// </summary>
    [DataContract(Name = "JwtOidcCallbackRequest")]
    public partial class JwtOidcCallbackRequest : IEquatable<JwtOidcCallbackRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JwtOidcCallbackRequest" /> class.
        /// </summary>
        /// <param name="clientNonce">clientNonce.</param>
        /// <param name="code">code.</param>
        /// <param name="idToken">idToken.</param>
        /// <param name="state">state.</param>
        public JwtOidcCallbackRequest(string clientNonce = default(string), string code = default(string), string idToken = default(string), string state = default(string))
        {
            this.ClientNonce = clientNonce;
            this.Code = code;
            this.IdToken = idToken;
            this.State = state;
        }

        /// <summary>
        /// Gets or Sets ClientNonce
        /// </summary>
        [DataMember(Name = "client_nonce", EmitDefaultValue = false)]
        public string ClientNonce { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets IdToken
        /// </summary>
        [DataMember(Name = "id_token", EmitDefaultValue = false)]
        public string IdToken { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JwtOidcCallbackRequest {\n");
            sb.Append("  ClientNonce: ").Append(ClientNonce).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  IdToken: ").Append(IdToken).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as JwtOidcCallbackRequest);
        }

        /// <summary>
        /// Returns true if JwtOidcCallbackRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of JwtOidcCallbackRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JwtOidcCallbackRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ClientNonce == input.ClientNonce ||
                    (this.ClientNonce != null &&
                    this.ClientNonce.Equals(input.ClientNonce))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.IdToken == input.IdToken ||
                    (this.IdToken != null &&
                    this.IdToken.Equals(input.IdToken))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.ClientNonce != null)
                {
                    hashCode = (hashCode * 59) + this.ClientNonce.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.IdToken != null)
                {
                    hashCode = (hashCode * 59) + this.IdToken.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
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