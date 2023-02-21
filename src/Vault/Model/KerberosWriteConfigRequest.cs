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
    /// KerberosWriteConfigRequest
    /// </summary>
    [DataContract(Name = "KerberosWriteConfigRequest")]
    public partial class KerberosWriteConfigRequest : IEquatable<KerberosWriteConfigRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KerberosWriteConfigRequest" /> class.
        /// </summary>
        /// <param name="addGroupAliases">If set to true, returns any groups found in LDAP as a group alias..</param>
        /// <param name="keytab">Base64 encoded keytab.</param>
        /// <param name="removeInstanceName">Remove instance/FQDN from keytab principal names..</param>
        /// <param name="serviceAccount">Service Account.</param>
        public KerberosWriteConfigRequest(bool addGroupAliases = default(bool), string keytab = default(string), bool removeInstanceName = default(bool), string serviceAccount = default(string))
        {
            this.AddGroupAliases = addGroupAliases;
            this.Keytab = keytab;
            this.RemoveInstanceName = removeInstanceName;
            this.ServiceAccount = serviceAccount;
        }

        /// <summary>
        /// If set to true, returns any groups found in LDAP as a group alias.
        /// </summary>
        /// <value>If set to true, returns any groups found in LDAP as a group alias.</value>
        [DataMember(Name = "add_group_aliases", EmitDefaultValue = true)]
        public bool AddGroupAliases { get; set; }

        /// <summary>
        /// Base64 encoded keytab
        /// </summary>
        /// <value>Base64 encoded keytab</value>
        [DataMember(Name = "keytab", EmitDefaultValue = false)]
        public string Keytab { get; set; }

        /// <summary>
        /// Remove instance/FQDN from keytab principal names.
        /// </summary>
        /// <value>Remove instance/FQDN from keytab principal names.</value>
        [DataMember(Name = "remove_instance_name", EmitDefaultValue = true)]
        public bool RemoveInstanceName { get; set; }

        /// <summary>
        /// Service Account
        /// </summary>
        /// <value>Service Account</value>
        [DataMember(Name = "service_account", EmitDefaultValue = false)]
        public string ServiceAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KerberosWriteConfigRequest {\n");
            sb.Append("  AddGroupAliases: ").Append(AddGroupAliases).Append("\n");
            sb.Append("  Keytab: ").Append(Keytab).Append("\n");
            sb.Append("  RemoveInstanceName: ").Append(RemoveInstanceName).Append("\n");
            sb.Append("  ServiceAccount: ").Append(ServiceAccount).Append("\n");
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
            return this.Equals(input as KerberosWriteConfigRequest);
        }

        /// <summary>
        /// Returns true if KerberosWriteConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of KerberosWriteConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KerberosWriteConfigRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AddGroupAliases == input.AddGroupAliases ||
                    this.AddGroupAliases.Equals(input.AddGroupAliases)
                ) &&
                (
                    this.Keytab == input.Keytab ||
                    (this.Keytab != null &&
                    this.Keytab.Equals(input.Keytab))
                ) &&
                (
                    this.RemoveInstanceName == input.RemoveInstanceName ||
                    this.RemoveInstanceName.Equals(input.RemoveInstanceName)
                ) &&
                (
                    this.ServiceAccount == input.ServiceAccount ||
                    (this.ServiceAccount != null &&
                    this.ServiceAccount.Equals(input.ServiceAccount))
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
                hashCode = (hashCode * 59) + this.AddGroupAliases.GetHashCode();
                if (this.Keytab != null)
                {
                    hashCode = (hashCode * 59) + this.Keytab.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RemoveInstanceName.GetHashCode();
                if (this.ServiceAccount != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceAccount.GetHashCode();
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
