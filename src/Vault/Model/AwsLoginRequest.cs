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
    /// AwsLoginRequest
    /// </summary>
    [DataContract(Name = "AwsLoginRequest")]
    public partial class AwsLoginRequest : IEquatable<AwsLoginRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="AwsLoginRequest" /> class.
        /// </summary>

        /// <param name="IamHttpRequestMethod">HTTP method to use for the AWS request when auth_type is iam. This must match what has been signed in the presigned request..</param>

        /// <param name="IamRequestBody">Base64-encoded request body when auth_type is iam. This must match the request body included in the signature..</param>

        /// <param name="IamRequestHeaders">Key/value pairs of headers for use in the sts:GetCallerIdentity HTTP requests headers when auth_type is iam. Can be either a Base64-encoded, JSON-serialized string, or a JSON object of key/value pairs. This must at a minimum include the headers over which AWS has included a signature..</param>

        /// <param name="IamRequestUrl">Base64-encoded full URL against which to make the AWS request when using iam auth_type..</param>

        /// <param name="Identity">Base64 encoded EC2 instance identity document. This needs to be supplied along with the &#x27;signature&#x27; parameter. If using &#x27;curl&#x27; for fetching the identity document, consider using the option &#x27;-w 0&#x27; while piping the output to &#x27;base64&#x27; binary..</param>

        /// <param name="Nonce">The nonce to be used for subsequent login requests when auth_type is ec2. If this parameter is not specified at all and if reauthentication is allowed, then the backend will generate a random nonce, attaches it to the instance&#x27;s identity access list entry and returns the nonce back as part of auth metadata. This value should be used with further login requests, to establish client authenticity. Clients can choose to set a custom nonce if preferred, in which case, it is recommended that clients provide a strong nonce. If a nonce is provided but with an empty value, it indicates intent to disable reauthentication. Note that, when &#x27;disallow_reauthentication&#x27; option is enabled on either the role or the role tag, the &#x27;nonce&#x27; holds no significance..</param>

        /// <param name="Pkcs7">PKCS7 signature of the identity document when using an auth_type of ec2..</param>

        /// <param name="Role">Name of the role against which the login is being attempted. If &#x27;role&#x27; is not specified, then the login endpoint looks for a role bearing the name of the AMI ID of the EC2 instance that is trying to login. If a matching role is not found, login fails..</param>

        /// <param name="Signature">Base64 encoded SHA256 RSA signature of the instance identity document. This needs to be supplied along with &#x27;identity&#x27; parameter..</param>


        public AwsLoginRequest(string IamHttpRequestMethod = default(string), string IamRequestBody = default(string), string IamRequestHeaders = default(string), string IamRequestUrl = default(string), string Identity = default(string), string Nonce = default(string), string Pkcs7 = default(string), string Role = default(string), string Signature = default(string))
        {

            this.IamHttpRequestMethod = IamHttpRequestMethod;

            this.IamRequestBody = IamRequestBody;

            this.IamRequestHeaders = IamRequestHeaders;

            this.IamRequestUrl = IamRequestUrl;

            this.Identity = Identity;

            this.Nonce = Nonce;

            this.Pkcs7 = Pkcs7;

            this.Role = Role;

            this.Signature = Signature;

        }

        /// <summary>
        /// HTTP method to use for the AWS request when auth_type is iam. This must match what has been signed in the presigned request.
        /// </summary>
        /// <value>HTTP method to use for the AWS request when auth_type is iam. This must match what has been signed in the presigned request.</value>
        [DataMember(Name = "iam_http_request_method", EmitDefaultValue = false)]

        public string IamHttpRequestMethod { get; set; }


        /// <summary>
        /// Base64-encoded request body when auth_type is iam. This must match the request body included in the signature.
        /// </summary>
        /// <value>Base64-encoded request body when auth_type is iam. This must match the request body included in the signature.</value>
        [DataMember(Name = "iam_request_body", EmitDefaultValue = false)]

        public string IamRequestBody { get; set; }


        /// <summary>
        /// Key/value pairs of headers for use in the sts:GetCallerIdentity HTTP requests headers when auth_type is iam. Can be either a Base64-encoded, JSON-serialized string, or a JSON object of key/value pairs. This must at a minimum include the headers over which AWS has included a signature.
        /// </summary>
        /// <value>Key/value pairs of headers for use in the sts:GetCallerIdentity HTTP requests headers when auth_type is iam. Can be either a Base64-encoded, JSON-serialized string, or a JSON object of key/value pairs. This must at a minimum include the headers over which AWS has included a signature.</value>
        [DataMember(Name = "iam_request_headers", EmitDefaultValue = false)]

        public string IamRequestHeaders { get; set; }


        /// <summary>
        /// Base64-encoded full URL against which to make the AWS request when using iam auth_type.
        /// </summary>
        /// <value>Base64-encoded full URL against which to make the AWS request when using iam auth_type.</value>
        [DataMember(Name = "iam_request_url", EmitDefaultValue = false)]

        public string IamRequestUrl { get; set; }


        /// <summary>
        /// Base64 encoded EC2 instance identity document. This needs to be supplied along with the &#x27;signature&#x27; parameter. If using &#x27;curl&#x27; for fetching the identity document, consider using the option &#x27;-w 0&#x27; while piping the output to &#x27;base64&#x27; binary.
        /// </summary>
        /// <value>Base64 encoded EC2 instance identity document. This needs to be supplied along with the &#x27;signature&#x27; parameter. If using &#x27;curl&#x27; for fetching the identity document, consider using the option &#x27;-w 0&#x27; while piping the output to &#x27;base64&#x27; binary.</value>
        [DataMember(Name = "identity", EmitDefaultValue = false)]

        public string Identity { get; set; }


        /// <summary>
        /// The nonce to be used for subsequent login requests when auth_type is ec2. If this parameter is not specified at all and if reauthentication is allowed, then the backend will generate a random nonce, attaches it to the instance&#x27;s identity access list entry and returns the nonce back as part of auth metadata. This value should be used with further login requests, to establish client authenticity. Clients can choose to set a custom nonce if preferred, in which case, it is recommended that clients provide a strong nonce. If a nonce is provided but with an empty value, it indicates intent to disable reauthentication. Note that, when &#x27;disallow_reauthentication&#x27; option is enabled on either the role or the role tag, the &#x27;nonce&#x27; holds no significance.
        /// </summary>
        /// <value>The nonce to be used for subsequent login requests when auth_type is ec2. If this parameter is not specified at all and if reauthentication is allowed, then the backend will generate a random nonce, attaches it to the instance&#x27;s identity access list entry and returns the nonce back as part of auth metadata. This value should be used with further login requests, to establish client authenticity. Clients can choose to set a custom nonce if preferred, in which case, it is recommended that clients provide a strong nonce. If a nonce is provided but with an empty value, it indicates intent to disable reauthentication. Note that, when &#x27;disallow_reauthentication&#x27; option is enabled on either the role or the role tag, the &#x27;nonce&#x27; holds no significance.</value>
        [DataMember(Name = "nonce", EmitDefaultValue = false)]

        public string Nonce { get; set; }


        /// <summary>
        /// PKCS7 signature of the identity document when using an auth_type of ec2.
        /// </summary>
        /// <value>PKCS7 signature of the identity document when using an auth_type of ec2.</value>
        [DataMember(Name = "pkcs7", EmitDefaultValue = false)]

        public string Pkcs7 { get; set; }


        /// <summary>
        /// Name of the role against which the login is being attempted. If &#x27;role&#x27; is not specified, then the login endpoint looks for a role bearing the name of the AMI ID of the EC2 instance that is trying to login. If a matching role is not found, login fails.
        /// </summary>
        /// <value>Name of the role against which the login is being attempted. If &#x27;role&#x27; is not specified, then the login endpoint looks for a role bearing the name of the AMI ID of the EC2 instance that is trying to login. If a matching role is not found, login fails.</value>
        [DataMember(Name = "role", EmitDefaultValue = false)]

        public string Role { get; set; }


        /// <summary>
        /// Base64 encoded SHA256 RSA signature of the instance identity document. This needs to be supplied along with &#x27;identity&#x27; parameter.
        /// </summary>
        /// <value>Base64 encoded SHA256 RSA signature of the instance identity document. This needs to be supplied along with &#x27;identity&#x27; parameter.</value>
        [DataMember(Name = "signature", EmitDefaultValue = false)]

        public string Signature { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AwsLoginRequest {\n");
            sb.Append("  IamHttpRequestMethod: ").Append(IamHttpRequestMethod).Append("\n");
            sb.Append("  IamRequestBody: ").Append(IamRequestBody).Append("\n");
            sb.Append("  IamRequestHeaders: ").Append(IamRequestHeaders).Append("\n");
            sb.Append("  IamRequestUrl: ").Append(IamRequestUrl).Append("\n");
            sb.Append("  Identity: ").Append(Identity).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  Pkcs7: ").Append(Pkcs7).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
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
            return this.Equals(input as AwsLoginRequest);
        }

        /// <summary>
        /// Returns true if AwsLoginRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AwsLoginRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AwsLoginRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.IamHttpRequestMethod == input.IamHttpRequestMethod ||
                    (this.IamHttpRequestMethod != null &&
                    this.IamHttpRequestMethod.Equals(input.IamHttpRequestMethod))

                ) &&
                (
                    this.IamRequestBody == input.IamRequestBody ||
                    (this.IamRequestBody != null &&
                    this.IamRequestBody.Equals(input.IamRequestBody))

                ) &&
                (
                    this.IamRequestHeaders == input.IamRequestHeaders ||
                    (this.IamRequestHeaders != null &&
                    this.IamRequestHeaders.Equals(input.IamRequestHeaders))

                ) &&
                (
                    this.IamRequestUrl == input.IamRequestUrl ||
                    (this.IamRequestUrl != null &&
                    this.IamRequestUrl.Equals(input.IamRequestUrl))

                ) &&
                (
                    this.Identity == input.Identity ||
                    (this.Identity != null &&
                    this.Identity.Equals(input.Identity))

                ) &&
                (
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))

                ) &&
                (
                    this.Pkcs7 == input.Pkcs7 ||
                    (this.Pkcs7 != null &&
                    this.Pkcs7.Equals(input.Pkcs7))

                ) &&
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))

                ) &&
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))

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

                if (this.IamHttpRequestMethod != null)
                {
                    hashCode = (hashCode * 59) + this.IamHttpRequestMethod.GetHashCode();
                }

                if (this.IamRequestBody != null)
                {
                    hashCode = (hashCode * 59) + this.IamRequestBody.GetHashCode();
                }

                if (this.IamRequestHeaders != null)
                {
                    hashCode = (hashCode * 59) + this.IamRequestHeaders.GetHashCode();
                }

                if (this.IamRequestUrl != null)
                {
                    hashCode = (hashCode * 59) + this.IamRequestUrl.GetHashCode();
                }

                if (this.Identity != null)
                {
                    hashCode = (hashCode * 59) + this.Identity.GetHashCode();
                }

                if (this.Nonce != null)
                {
                    hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                }

                if (this.Pkcs7 != null)
                {
                    hashCode = (hashCode * 59) + this.Pkcs7.GetHashCode();
                }

                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
                }

                if (this.Signature != null)
                {
                    hashCode = (hashCode * 59) + this.Signature.GetHashCode();
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
