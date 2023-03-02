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
    /// ConsulWriteAccessConfigRequest
    /// </summary>
    [DataContract(Name = "ConsulWriteAccessConfigRequest")]

    public partial class ConsulWriteAccessConfigRequest : IEquatable<ConsulWriteAccessConfigRequest>, IValidatableObject
    {















        /// <summary>
        /// Initializes a new instance of the <see cref="ConsulWriteAccessConfigRequest" /> class.
        /// </summary>

        /// <param name="Address">Consul server address.</param>

        /// <param name="CaCert">CA certificate to use when verifying Consul server certificate, must be x509 PEM encoded..</param>

        /// <param name="ClientCert">Client certificate used for Consul&#x27;s TLS communication, must be x509 PEM encoded and if this is set you need to also set client_key..</param>

        /// <param name="ClientKey">Client key used for Consul&#x27;s TLS communication, must be x509 PEM encoded and if this is set you need to also set client_cert..</param>

        /// <param name="Scheme">URI scheme for the Consul address (default to &quot;http&quot;).</param>

        /// <param name="Token">Token for API calls.</param>


        public ConsulWriteAccessConfigRequest(string Address = default(string), string CaCert = default(string), string ClientCert = default(string), string ClientKey = default(string), string Scheme = "http", string Token = default(string))
        {

            this.Address = Address;

            this.CaCert = CaCert;

            this.ClientCert = ClientCert;

            this.ClientKey = ClientKey;

            // use default value if no "Scheme" provided
            this.Scheme = Scheme ?? "http";


            this.Token = Token;

        }

        /// <summary>
        /// Consul server address
        /// </summary>
        /// <value>Consul server address</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]


        public string Address { get; set; }


        /// <summary>
        /// CA certificate to use when verifying Consul server certificate, must be x509 PEM encoded.
        /// </summary>
        /// <value>CA certificate to use when verifying Consul server certificate, must be x509 PEM encoded.</value>
        [DataMember(Name = "ca_cert", EmitDefaultValue = false)]


        public string CaCert { get; set; }


        /// <summary>
        /// Client certificate used for Consul&#x27;s TLS communication, must be x509 PEM encoded and if this is set you need to also set client_key.
        /// </summary>
        /// <value>Client certificate used for Consul&#x27;s TLS communication, must be x509 PEM encoded and if this is set you need to also set client_key.</value>
        [DataMember(Name = "client_cert", EmitDefaultValue = false)]


        public string ClientCert { get; set; }


        /// <summary>
        /// Client key used for Consul&#x27;s TLS communication, must be x509 PEM encoded and if this is set you need to also set client_cert.
        /// </summary>
        /// <value>Client key used for Consul&#x27;s TLS communication, must be x509 PEM encoded and if this is set you need to also set client_cert.</value>
        [DataMember(Name = "client_key", EmitDefaultValue = false)]


        public string ClientKey { get; set; }


        /// <summary>
        /// URI scheme for the Consul address
        /// </summary>
        /// <value>URI scheme for the Consul address</value>
        [DataMember(Name = "scheme", EmitDefaultValue = false)]


        public string Scheme { get; set; }


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
            sb.Append("class ConsulWriteAccessConfigRequest {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  CaCert: ").Append(CaCert).Append("\n");
            sb.Append("  ClientCert: ").Append(ClientCert).Append("\n");
            sb.Append("  ClientKey: ").Append(ClientKey).Append("\n");
            sb.Append("  Scheme: ").Append(Scheme).Append("\n");
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
            return this.Equals(input as ConsulWriteAccessConfigRequest);
        }

        /// <summary>
        /// Returns true if ConsulWriteAccessConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ConsulWriteAccessConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsulWriteAccessConfigRequest input)
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
                    this.Scheme == input.Scheme ||
                    (this.Scheme != null &&
                    this.Scheme.Equals(input.Scheme))

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

                if (this.Scheme != null)
                {
                    hashCode = (hashCode * 59) + this.Scheme.GetHashCode();
                }

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
