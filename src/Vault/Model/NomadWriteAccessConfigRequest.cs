// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

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
    /// NomadWriteAccessConfigRequest
    /// </summary>
    [DataContract(Name = "NomadWriteAccessConfigRequest")]
    public partial class NomadWriteAccessConfigRequest : IEquatable<NomadWriteAccessConfigRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NomadWriteAccessConfigRequest" /> class.
        /// </summary>
        /// <param name="address">Nomad server address.</param>
        /// <param name="caCert">CA certificate to use when verifying Nomad server certificate, must be x509 PEM encoded..</param>
        /// <param name="clientCert">Client certificate used for Nomad&#39;s TLS communication, must be x509 PEM encoded and if this is set you need to also set client_key..</param>
        /// <param name="clientKey">Client key used for Nomad&#39;s TLS communication, must be x509 PEM encoded and if this is set you need to also set client_cert..</param>
        /// <param name="maxTokenNameLength">Max length for name of generated Nomad tokens.</param>
        /// <param name="token">Token for API calls.</param>
        public NomadWriteAccessConfigRequest(string address = default(string), string caCert = default(string), string clientCert = default(string), string clientKey = default(string), int maxTokenNameLength = default(int), string token = default(string))
        {
            this.Address = address;
            this.CaCert = caCert;
            this.ClientCert = clientCert;
            this.ClientKey = clientKey;
            this.MaxTokenNameLength = maxTokenNameLength;
            this.Token = token;
        }

        /// <summary>
        /// Nomad server address
        /// </summary>
        /// <value>Nomad server address</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// CA certificate to use when verifying Nomad server certificate, must be x509 PEM encoded.
        /// </summary>
        /// <value>CA certificate to use when verifying Nomad server certificate, must be x509 PEM encoded.</value>
        [DataMember(Name = "ca_cert", EmitDefaultValue = false)]
        public string CaCert { get; set; }

        /// <summary>
        /// Client certificate used for Nomad&#39;s TLS communication, must be x509 PEM encoded and if this is set you need to also set client_key.
        /// </summary>
        /// <value>Client certificate used for Nomad&#39;s TLS communication, must be x509 PEM encoded and if this is set you need to also set client_key.</value>
        [DataMember(Name = "client_cert", EmitDefaultValue = false)]
        public string ClientCert { get; set; }

        /// <summary>
        /// Client key used for Nomad&#39;s TLS communication, must be x509 PEM encoded and if this is set you need to also set client_cert.
        /// </summary>
        /// <value>Client key used for Nomad&#39;s TLS communication, must be x509 PEM encoded and if this is set you need to also set client_cert.</value>
        [DataMember(Name = "client_key", EmitDefaultValue = false)]
        public string ClientKey { get; set; }

        /// <summary>
        /// Max length for name of generated Nomad tokens
        /// </summary>
        /// <value>Max length for name of generated Nomad tokens</value>
        [DataMember(Name = "max_token_name_length", EmitDefaultValue = false)]
        public int MaxTokenNameLength { get; set; }

        /// <summary>
        /// Token for API calls
        /// </summary>
        /// <value>Token for API calls</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NomadWriteAccessConfigRequest {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  CaCert: ").Append(CaCert).Append("\n");
            sb.Append("  ClientCert: ").Append(ClientCert).Append("\n");
            sb.Append("  ClientKey: ").Append(ClientKey).Append("\n");
            sb.Append("  MaxTokenNameLength: ").Append(MaxTokenNameLength).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(input as NomadWriteAccessConfigRequest);
        }

        /// <summary>
        /// Returns true if NomadWriteAccessConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of NomadWriteAccessConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NomadWriteAccessConfigRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.CaCert == input.CaCert ||
                    (this.CaCert != null &&
                    this.CaCert.Equals(input.CaCert))
                ) && 
                (
                    this.ClientCert == input.ClientCert ||
                    (this.ClientCert != null &&
                    this.ClientCert.Equals(input.ClientCert))
                ) && 
                (
                    this.ClientKey == input.ClientKey ||
                    (this.ClientKey != null &&
                    this.ClientKey.Equals(input.ClientKey))
                ) && 
                (
                    this.MaxTokenNameLength == input.MaxTokenNameLength ||
                    this.MaxTokenNameLength.Equals(input.MaxTokenNameLength)
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.CaCert != null)
                {
                    hashCode = (hashCode * 59) + this.CaCert.GetHashCode();
                }
                if (this.ClientCert != null)
                {
                    hashCode = (hashCode * 59) + this.ClientCert.GetHashCode();
                }
                if (this.ClientKey != null)
                {
                    hashCode = (hashCode * 59) + this.ClientKey.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxTokenNameLength.GetHashCode();
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
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
