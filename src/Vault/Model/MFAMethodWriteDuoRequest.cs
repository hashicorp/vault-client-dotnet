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
    /// MFAMethodWriteDuoRequest
    /// </summary>
    [DataContract(Name = "MFAMethodWriteDuoRequest")]
    public partial class MFAMethodWriteDuoRequest : IEquatable<MFAMethodWriteDuoRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MFAMethodWriteDuoRequest" /> class.
        /// </summary>
        /// <param name="apiHostname">API host name for Duo..</param>
        /// <param name="integrationKey">Integration key for Duo..</param>
        /// <param name="methodId">The unique identifier for this MFA method..</param>
        /// <param name="pushInfo">Push information for Duo..</param>
        /// <param name="secretKey">Secret key for Duo..</param>
        /// <param name="usePasscode">If true, the user is reminded to use the passcode upon MFA validation. This option does not enforce using the passcode. Defaults to false..</param>
        /// <param name="usernameFormat">A template string for mapping Identity names to MFA method names. Values to subtitute should be placed in {{}}. For example, \&quot;{{alias.name}}@example.com\&quot;. Currently-supported mappings: alias.name: The name returned by the mount configured via the mount_accessor parameter If blank, the Alias&#39;s name field will be used as-is..</param>
        public MFAMethodWriteDuoRequest(string apiHostname = default(string), string integrationKey = default(string), string methodId = default(string), string pushInfo = default(string), string secretKey = default(string), bool usePasscode = default(bool), string usernameFormat = default(string))
        {
            this.ApiHostname = apiHostname;
            this.IntegrationKey = integrationKey;
            this.MethodId = methodId;
            this.PushInfo = pushInfo;
            this.SecretKey = secretKey;
            this.UsePasscode = usePasscode;
            this.UsernameFormat = usernameFormat;
        }

        /// <summary>
        /// API host name for Duo.
        /// </summary>
        /// <value>API host name for Duo.</value>
        [DataMember(Name = "api_hostname", EmitDefaultValue = false)]
        public string ApiHostname { get; set; }

        /// <summary>
        /// Integration key for Duo.
        /// </summary>
        /// <value>Integration key for Duo.</value>
        [DataMember(Name = "integration_key", EmitDefaultValue = false)]
        public string IntegrationKey { get; set; }

        /// <summary>
        /// The unique identifier for this MFA method.
        /// </summary>
        /// <value>The unique identifier for this MFA method.</value>
        [DataMember(Name = "method_id", EmitDefaultValue = false)]
        public string MethodId { get; set; }

        /// <summary>
        /// Push information for Duo.
        /// </summary>
        /// <value>Push information for Duo.</value>
        [DataMember(Name = "push_info", EmitDefaultValue = false)]
        public string PushInfo { get; set; }

        /// <summary>
        /// Secret key for Duo.
        /// </summary>
        /// <value>Secret key for Duo.</value>
        [DataMember(Name = "secret_key", EmitDefaultValue = false)]
        public string SecretKey { get; set; }

        /// <summary>
        /// If true, the user is reminded to use the passcode upon MFA validation. This option does not enforce using the passcode. Defaults to false.
        /// </summary>
        /// <value>If true, the user is reminded to use the passcode upon MFA validation. This option does not enforce using the passcode. Defaults to false.</value>
        [DataMember(Name = "use_passcode", EmitDefaultValue = true)]
        public bool UsePasscode { get; set; }

        /// <summary>
        /// A template string for mapping Identity names to MFA method names. Values to subtitute should be placed in {{}}. For example, \&quot;{{alias.name}}@example.com\&quot;. Currently-supported mappings: alias.name: The name returned by the mount configured via the mount_accessor parameter If blank, the Alias&#39;s name field will be used as-is.
        /// </summary>
        /// <value>A template string for mapping Identity names to MFA method names. Values to subtitute should be placed in {{}}. For example, \&quot;{{alias.name}}@example.com\&quot;. Currently-supported mappings: alias.name: The name returned by the mount configured via the mount_accessor parameter If blank, the Alias&#39;s name field will be used as-is.</value>
        [DataMember(Name = "username_format", EmitDefaultValue = false)]
        public string UsernameFormat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MFAMethodWriteDuoRequest {\n");
            sb.Append("  ApiHostname: ").Append(ApiHostname).Append("\n");
            sb.Append("  IntegrationKey: ").Append(IntegrationKey).Append("\n");
            sb.Append("  MethodId: ").Append(MethodId).Append("\n");
            sb.Append("  PushInfo: ").Append(PushInfo).Append("\n");
            sb.Append("  SecretKey: ").Append(SecretKey).Append("\n");
            sb.Append("  UsePasscode: ").Append(UsePasscode).Append("\n");
            sb.Append("  UsernameFormat: ").Append(UsernameFormat).Append("\n");
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
            return this.Equals(input as MFAMethodWriteDuoRequest);
        }

        /// <summary>
        /// Returns true if MFAMethodWriteDuoRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MFAMethodWriteDuoRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MFAMethodWriteDuoRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.ApiHostname == input.ApiHostname ||
                    (this.ApiHostname != null &&
                    this.ApiHostname.Equals(input.ApiHostname))
                ) &&
                (
                    this.IntegrationKey == input.IntegrationKey ||
                    (this.IntegrationKey != null &&
                    this.IntegrationKey.Equals(input.IntegrationKey))
                ) &&
                (
                    this.MethodId == input.MethodId ||
                    (this.MethodId != null &&
                    this.MethodId.Equals(input.MethodId))
                ) &&
                (
                    this.PushInfo == input.PushInfo ||
                    (this.PushInfo != null &&
                    this.PushInfo.Equals(input.PushInfo))
                ) &&
                (
                    this.SecretKey == input.SecretKey ||
                    (this.SecretKey != null &&
                    this.SecretKey.Equals(input.SecretKey))
                ) &&
                (
                    this.UsePasscode == input.UsePasscode ||
                    this.UsePasscode.Equals(input.UsePasscode)
                ) &&
                (
                    this.UsernameFormat == input.UsernameFormat ||
                    (this.UsernameFormat != null &&
                    this.UsernameFormat.Equals(input.UsernameFormat))
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
                if (this.ApiHostname != null)
                {
                    hashCode = (hashCode * 59) + this.ApiHostname.GetHashCode();
                }
                if (this.IntegrationKey != null)
                {
                    hashCode = (hashCode * 59) + this.IntegrationKey.GetHashCode();
                }
                if (this.MethodId != null)
                {
                    hashCode = (hashCode * 59) + this.MethodId.GetHashCode();
                }
                if (this.PushInfo != null)
                {
                    hashCode = (hashCode * 59) + this.PushInfo.GetHashCode();
                }
                if (this.SecretKey != null)
                {
                    hashCode = (hashCode * 59) + this.SecretKey.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UsePasscode.GetHashCode();
                if (this.UsernameFormat != null)
                {
                    hashCode = (hashCode * 59) + this.UsernameFormat.GetHashCode();
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
