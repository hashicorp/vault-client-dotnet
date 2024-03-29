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
    /// AzureLoginRequest
    /// </summary>
    [DataContract(Name = "AzureLoginRequest")]
    public partial class AzureLoginRequest : IEquatable<AzureLoginRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="AzureLoginRequest" /> class.
        /// </summary>

        /// <param name="Jwt">A signed JWT.</param>

        /// <param name="ResourceGroupName">The resource group from the instance..</param>

        /// <param name="ResourceId">The fully qualified ID of the resource, includingthe resource name and resource type. Use the format, /subscriptions/{guid}/resourceGroups/{resource-group-name}/{resource-provider-namespace}/{resource-type}/{resource-name}. This value is ignored if vm_name or vmss_name is specified..</param>

        /// <param name="Role">The token role..</param>

        /// <param name="SubscriptionId">The subscription id for the instance..</param>

        /// <param name="VmName">The name of the virtual machine. This value is ignored if vmss_name is specified..</param>

        /// <param name="VmssName">The name of the virtual machine scale set the instance is in..</param>


        public AzureLoginRequest(string Jwt = default(string), string ResourceGroupName = default(string), string ResourceId = default(string), string Role = default(string), string SubscriptionId = default(string), string VmName = default(string), string VmssName = default(string))
        {

            this.Jwt = Jwt;

            this.ResourceGroupName = ResourceGroupName;

            this.ResourceId = ResourceId;

            this.Role = Role;

            this.SubscriptionId = SubscriptionId;

            this.VmName = VmName;

            this.VmssName = VmssName;

        }

        /// <summary>
        /// A signed JWT
        /// </summary>
        /// <value>A signed JWT</value>
        [DataMember(Name = "jwt", EmitDefaultValue = false)]

        public string Jwt { get; set; }


        /// <summary>
        /// The resource group from the instance.
        /// </summary>
        /// <value>The resource group from the instance.</value>
        [DataMember(Name = "resource_group_name", EmitDefaultValue = false)]

        public string ResourceGroupName { get; set; }


        /// <summary>
        /// The fully qualified ID of the resource, includingthe resource name and resource type. Use the format, /subscriptions/{guid}/resourceGroups/{resource-group-name}/{resource-provider-namespace}/{resource-type}/{resource-name}. This value is ignored if vm_name or vmss_name is specified.
        /// </summary>
        /// <value>The fully qualified ID of the resource, includingthe resource name and resource type. Use the format, /subscriptions/{guid}/resourceGroups/{resource-group-name}/{resource-provider-namespace}/{resource-type}/{resource-name}. This value is ignored if vm_name or vmss_name is specified.</value>
        [DataMember(Name = "resource_id", EmitDefaultValue = false)]

        public string ResourceId { get; set; }


        /// <summary>
        /// The token role.
        /// </summary>
        /// <value>The token role.</value>
        [DataMember(Name = "role", EmitDefaultValue = false)]

        public string Role { get; set; }


        /// <summary>
        /// The subscription id for the instance.
        /// </summary>
        /// <value>The subscription id for the instance.</value>
        [DataMember(Name = "subscription_id", EmitDefaultValue = false)]

        public string SubscriptionId { get; set; }


        /// <summary>
        /// The name of the virtual machine. This value is ignored if vmss_name is specified.
        /// </summary>
        /// <value>The name of the virtual machine. This value is ignored if vmss_name is specified.</value>
        [DataMember(Name = "vm_name", EmitDefaultValue = false)]

        public string VmName { get; set; }


        /// <summary>
        /// The name of the virtual machine scale set the instance is in.
        /// </summary>
        /// <value>The name of the virtual machine scale set the instance is in.</value>
        [DataMember(Name = "vmss_name", EmitDefaultValue = false)]

        public string VmssName { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AzureLoginRequest {\n");
            sb.Append("  Jwt: ").Append(Jwt).Append("\n");
            sb.Append("  ResourceGroupName: ").Append(ResourceGroupName).Append("\n");
            sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  VmName: ").Append(VmName).Append("\n");
            sb.Append("  VmssName: ").Append(VmssName).Append("\n");
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
            return this.Equals(input as AzureLoginRequest);
        }

        /// <summary>
        /// Returns true if AzureLoginRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AzureLoginRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AzureLoginRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Jwt == input.Jwt ||
                    (this.Jwt != null &&
                    this.Jwt.Equals(input.Jwt))

                ) &&
                (
                    this.ResourceGroupName == input.ResourceGroupName ||
                    (this.ResourceGroupName != null &&
                    this.ResourceGroupName.Equals(input.ResourceGroupName))

                ) &&
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))

                ) &&
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))

                ) &&
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))

                ) &&
                (
                    this.VmName == input.VmName ||
                    (this.VmName != null &&
                    this.VmName.Equals(input.VmName))

                ) &&
                (
                    this.VmssName == input.VmssName ||
                    (this.VmssName != null &&
                    this.VmssName.Equals(input.VmssName))

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

                if (this.Jwt != null)
                {
                    hashCode = (hashCode * 59) + this.Jwt.GetHashCode();
                }

                if (this.ResourceGroupName != null)
                {
                    hashCode = (hashCode * 59) + this.ResourceGroupName.GetHashCode();
                }

                if (this.ResourceId != null)
                {
                    hashCode = (hashCode * 59) + this.ResourceId.GetHashCode();
                }

                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
                }

                if (this.SubscriptionId != null)
                {
                    hashCode = (hashCode * 59) + this.SubscriptionId.GetHashCode();
                }

                if (this.VmName != null)
                {
                    hashCode = (hashCode * 59) + this.VmName.GetHashCode();
                }

                if (this.VmssName != null)
                {
                    hashCode = (hashCode * 59) + this.VmssName.GetHashCode();
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
