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
    /// MfaCreatePingIdMethodRequest
    /// </summary>
    [DataContract(Name = "MfaCreatePingIdMethodRequest")]
    public partial class MfaCreatePingIdMethodRequest : IEquatable<MfaCreatePingIdMethodRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="MfaCreatePingIdMethodRequest" /> class.
        /// </summary>

        /// <param name="MethodName">The unique name identifier for this MFA method..</param>

        /// <param name="SettingsFileBase64">The settings file provided by Ping, Base64-encoded. This must be a settings file suitable for third-party clients, not the PingID SDK or PingFederate..</param>

        /// <param name="UsernameFormat">A template string for mapping Identity names to MFA method names. Values to subtitute should be placed in {{}}. For example, \&quot;{{alias.name}}@example.com\&quot;. Currently-supported mappings: alias.name: The name returned by the mount configured via the mount_accessor parameter If blank, the Alias&#x27;s name field will be used as-is..</param>


        public MfaCreatePingIdMethodRequest(string MethodName = default(string), string SettingsFileBase64 = default(string), string UsernameFormat = default(string))
        {

            this.MethodName = MethodName;

            this.SettingsFileBase64 = SettingsFileBase64;

            this.UsernameFormat = UsernameFormat;

        }

        /// <summary>
        /// The unique name identifier for this MFA method.
        /// </summary>
        /// <value>The unique name identifier for this MFA method.</value>
        [DataMember(Name = "method_name", EmitDefaultValue = false)]

        public string MethodName { get; set; }


        /// <summary>
        /// The settings file provided by Ping, Base64-encoded. This must be a settings file suitable for third-party clients, not the PingID SDK or PingFederate.
        /// </summary>
        /// <value>The settings file provided by Ping, Base64-encoded. This must be a settings file suitable for third-party clients, not the PingID SDK or PingFederate.</value>
        [DataMember(Name = "settings_file_base64", EmitDefaultValue = false)]

        public string SettingsFileBase64 { get; set; }


        /// <summary>
        /// A template string for mapping Identity names to MFA method names. Values to subtitute should be placed in {{}}. For example, \&quot;{{alias.name}}@example.com\&quot;. Currently-supported mappings: alias.name: The name returned by the mount configured via the mount_accessor parameter If blank, the Alias&#x27;s name field will be used as-is.
        /// </summary>
        /// <value>A template string for mapping Identity names to MFA method names. Values to subtitute should be placed in {{}}. For example, \&quot;{{alias.name}}@example.com\&quot;. Currently-supported mappings: alias.name: The name returned by the mount configured via the mount_accessor parameter If blank, the Alias&#x27;s name field will be used as-is.</value>
        [DataMember(Name = "username_format", EmitDefaultValue = false)]

        public string UsernameFormat { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MfaCreatePingIdMethodRequest {\n");
            sb.Append("  MethodName: ").Append(MethodName).Append("\n");
            sb.Append("  SettingsFileBase64: ").Append(SettingsFileBase64).Append("\n");
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
            return this.Equals(input as MfaCreatePingIdMethodRequest);
        }

        /// <summary>
        /// Returns true if MfaCreatePingIdMethodRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MfaCreatePingIdMethodRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MfaCreatePingIdMethodRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.MethodName == input.MethodName ||
                    (this.MethodName != null &&
                    this.MethodName.Equals(input.MethodName))

                ) &&
                (
                    this.SettingsFileBase64 == input.SettingsFileBase64 ||
                    (this.SettingsFileBase64 != null &&
                    this.SettingsFileBase64.Equals(input.SettingsFileBase64))

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

                if (this.MethodName != null)
                {
                    hashCode = (hashCode * 59) + this.MethodName.GetHashCode();
                }

                if (this.SettingsFileBase64 != null)
                {
                    hashCode = (hashCode * 59) + this.SettingsFileBase64.GetHashCode();
                }

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
