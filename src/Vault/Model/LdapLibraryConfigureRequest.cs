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
    /// LdapLibraryConfigureRequest
    /// </summary>
    [DataContract(Name = "LdapLibraryConfigureRequest")]
    public partial class LdapLibraryConfigureRequest : IEquatable<LdapLibraryConfigureRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="LdapLibraryConfigureRequest" /> class.
        /// </summary>

        /// <param name="DisableCheckInEnforcement">Disable the default behavior of requiring that check-ins are performed by the entity that checked them out. (default to false).</param>

        /// <param name="MaxTtl">In seconds, the max amount of time a check-out&#x27;s renewals should last. Defaults to 24 hours. (default to &quot;86400&quot;).</param>

        /// <param name="ServiceAccountNames">The username/logon name for the service accounts with which this set will be associated..</param>

        /// <param name="Ttl">In seconds, the amount of time a check-out should last. Defaults to 24 hours. (default to &quot;86400&quot;).</param>


        public LdapLibraryConfigureRequest(bool DisableCheckInEnforcement = false, string MaxTtl = "86400", List<string> ServiceAccountNames = default(List<string>), string Ttl = "86400")
        {

            this.DisableCheckInEnforcement = DisableCheckInEnforcement;

            // use default value if no "MaxTtl" provided
            this.MaxTtl = MaxTtl ?? "86400";


            this.ServiceAccountNames = ServiceAccountNames;

            // use default value if no "Ttl" provided
            this.Ttl = Ttl ?? "86400";


        }

        /// <summary>
        /// Disable the default behavior of requiring that check-ins are performed by the entity that checked them out.
        /// </summary>
        /// <value>Disable the default behavior of requiring that check-ins are performed by the entity that checked them out.</value>
        [DataMember(Name = "disable_check_in_enforcement", EmitDefaultValue = true)]

        public bool DisableCheckInEnforcement { get; set; }


        /// <summary>
        /// In seconds, the max amount of time a check-out&#x27;s renewals should last. Defaults to 24 hours.
        /// </summary>
        /// <value>In seconds, the max amount of time a check-out&#x27;s renewals should last. Defaults to 24 hours.</value>
        [DataMember(Name = "max_ttl", EmitDefaultValue = false)]

        public string MaxTtl { get; set; }


        /// <summary>
        /// The username/logon name for the service accounts with which this set will be associated.
        /// </summary>
        /// <value>The username/logon name for the service accounts with which this set will be associated.</value>
        [DataMember(Name = "service_account_names", EmitDefaultValue = false)]

        public List<string> ServiceAccountNames { get; set; }


        /// <summary>
        /// In seconds, the amount of time a check-out should last. Defaults to 24 hours.
        /// </summary>
        /// <value>In seconds, the amount of time a check-out should last. Defaults to 24 hours.</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]

        public string Ttl { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LdapLibraryConfigureRequest {\n");
            sb.Append("  DisableCheckInEnforcement: ").Append(DisableCheckInEnforcement).Append("\n");
            sb.Append("  MaxTtl: ").Append(MaxTtl).Append("\n");
            sb.Append("  ServiceAccountNames: ").Append(ServiceAccountNames).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
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
            return this.Equals(input as LdapLibraryConfigureRequest);
        }

        /// <summary>
        /// Returns true if LdapLibraryConfigureRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LdapLibraryConfigureRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LdapLibraryConfigureRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.DisableCheckInEnforcement == input.DisableCheckInEnforcement ||

                    this.DisableCheckInEnforcement.Equals(input.DisableCheckInEnforcement)
                ) &&
                (
                    this.MaxTtl == input.MaxTtl ||
                    (this.MaxTtl != null &&
                    this.MaxTtl.Equals(input.MaxTtl))

                ) &&
                (
                    this.ServiceAccountNames == input.ServiceAccountNames ||
                    this.ServiceAccountNames != null &&
                    input.ServiceAccountNames != null &&
                    this.ServiceAccountNames.SequenceEqual(input.ServiceAccountNames)
                ) &&
                (
                    this.Ttl == input.Ttl ||
                    (this.Ttl != null &&
                    this.Ttl.Equals(input.Ttl))

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


                hashCode = (hashCode * 59) + this.DisableCheckInEnforcement.GetHashCode();
                if (this.MaxTtl != null)
                {
                    hashCode = (hashCode * 59) + this.MaxTtl.GetHashCode();
                }

                if (this.ServiceAccountNames != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceAccountNames.GetHashCode();
                }

                if (this.Ttl != null)
                {
                    hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
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
