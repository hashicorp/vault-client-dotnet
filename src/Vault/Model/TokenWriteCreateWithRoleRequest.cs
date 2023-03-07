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
    /// TokenWriteCreateWithRoleRequest
    /// </summary>
    [DataContract(Name = "TokenWriteCreateWithRoleRequest")]
    public partial class TokenWriteCreateWithRoleRequest : IEquatable<TokenWriteCreateWithRoleRequest>, IValidatableObject
    {





























        /// <summary>
        /// Initializes a new instance of the <see cref="TokenWriteCreateWithRoleRequest" /> class.
        /// </summary>

        /// <param name="DisplayName">Name to associate with this token.</param>

        /// <param name="EntityAlias">Name of the entity alias to associate with this token.</param>

        /// <param name="ExplicitMaxTtl">Explicit Max TTL of this token.</param>

        /// <param name="Id">Value for the token.</param>

        /// <param name="Metadata">Arbitrary key&#x3D;value metadata to associate with the token.</param>

        /// <param name="NoDefaultPolicy">Do not include default policy for this token.</param>

        /// <param name="NoParent">Create the token with no parent.</param>

        /// <param name="NumUses">Max number of uses for this token.</param>

        /// <param name="Period">Renew period.</param>

        /// <param name="Policies">List of policies for the token.</param>

        /// <param name="Renewable">Allow token to be renewed past its initial TTL up to system/mount maximum TTL.</param>

        /// <param name="Ttl">Time to live for this token.</param>

        /// <param name="Type">Token type.</param>


        public TokenWriteCreateWithRoleRequest(string DisplayName = default(string), string EntityAlias = default(string), string ExplicitMaxTtl = default(string), string Id = default(string), Object Metadata = default(Object), bool NoDefaultPolicy = default(bool), bool NoParent = default(bool), int NumUses = default(int), string Period = default(string), List<string> Policies = default(List<string>), bool Renewable = default(bool), string Ttl = default(string), string Type = default(string))
        {

            this.DisplayName = DisplayName;

            this.EntityAlias = EntityAlias;

            this.ExplicitMaxTtl = ExplicitMaxTtl;

            this.Id = Id;

            this.Metadata = Metadata;

            this.NoDefaultPolicy = NoDefaultPolicy;

            this.NoParent = NoParent;

            this.NumUses = NumUses;

            this.Period = Period;

            this.Policies = Policies;

            this.Renewable = Renewable;

            this.Ttl = Ttl;

            this.Type = Type;

        }

        /// <summary>
        /// Name to associate with this token
        /// </summary>
        /// <value>Name to associate with this token</value>
        [DataMember(Name = "display_name", EmitDefaultValue = false)]

        public string DisplayName { get; set; }


        /// <summary>
        /// Name of the entity alias to associate with this token
        /// </summary>
        /// <value>Name of the entity alias to associate with this token</value>
        [DataMember(Name = "entity_alias", EmitDefaultValue = false)]

        public string EntityAlias { get; set; }


        /// <summary>
        /// Explicit Max TTL of this token
        /// </summary>
        /// <value>Explicit Max TTL of this token</value>
        [DataMember(Name = "explicit_max_ttl", EmitDefaultValue = false)]

        public string ExplicitMaxTtl { get; set; }


        /// <summary>
        /// Value for the token
        /// </summary>
        /// <value>Value for the token</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]

        public string Id { get; set; }


        /// <summary>
        /// Arbitrary key&#x3D;value metadata to associate with the token
        /// </summary>
        /// <value>Arbitrary key&#x3D;value metadata to associate with the token</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]

        public Object Metadata { get; set; }


        /// <summary>
        /// Do not include default policy for this token
        /// </summary>
        /// <value>Do not include default policy for this token</value>
        [DataMember(Name = "no_default_policy", EmitDefaultValue = true)]

        public bool NoDefaultPolicy { get; set; }


        /// <summary>
        /// Create the token with no parent
        /// </summary>
        /// <value>Create the token with no parent</value>
        [DataMember(Name = "no_parent", EmitDefaultValue = true)]

        public bool NoParent { get; set; }


        /// <summary>
        /// Max number of uses for this token
        /// </summary>
        /// <value>Max number of uses for this token</value>
        [DataMember(Name = "num_uses", EmitDefaultValue = false)]

        public int NumUses { get; set; }


        /// <summary>
        /// Renew period
        /// </summary>
        /// <value>Renew period</value>
        [DataMember(Name = "period", EmitDefaultValue = false)]

        public string Period { get; set; }


        /// <summary>
        /// List of policies for the token
        /// </summary>
        /// <value>List of policies for the token</value>
        [DataMember(Name = "policies", EmitDefaultValue = false)]

        public List<string> Policies { get; set; }


        /// <summary>
        /// Allow token to be renewed past its initial TTL up to system/mount maximum TTL
        /// </summary>
        /// <value>Allow token to be renewed past its initial TTL up to system/mount maximum TTL</value>
        [DataMember(Name = "renewable", EmitDefaultValue = true)]

        public bool Renewable { get; set; }


        /// <summary>
        /// Time to live for this token
        /// </summary>
        /// <value>Time to live for this token</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]

        public string Ttl { get; set; }


        /// <summary>
        /// Token type
        /// </summary>
        /// <value>Token type</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]

        public string Type { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokenWriteCreateWithRoleRequest {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  EntityAlias: ").Append(EntityAlias).Append("\n");
            sb.Append("  ExplicitMaxTtl: ").Append(ExplicitMaxTtl).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  NoDefaultPolicy: ").Append(NoDefaultPolicy).Append("\n");
            sb.Append("  NoParent: ").Append(NoParent).Append("\n");
            sb.Append("  NumUses: ").Append(NumUses).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
            sb.Append("  Renewable: ").Append(Renewable).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as TokenWriteCreateWithRoleRequest);
        }

        /// <summary>
        /// Returns true if TokenWriteCreateWithRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenWriteCreateWithRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenWriteCreateWithRoleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))

                ) &&
                (
                    this.EntityAlias == input.EntityAlias ||
                    (this.EntityAlias != null &&
                    this.EntityAlias.Equals(input.EntityAlias))

                ) &&
                (
                    this.ExplicitMaxTtl == input.ExplicitMaxTtl ||
                    (this.ExplicitMaxTtl != null &&
                    this.ExplicitMaxTtl.Equals(input.ExplicitMaxTtl))

                ) &&
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))

                ) &&
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))

                ) &&
                (
                    this.NoDefaultPolicy == input.NoDefaultPolicy ||

                    this.NoDefaultPolicy.Equals(input.NoDefaultPolicy)
                ) &&
                (
                    this.NoParent == input.NoParent ||

                    this.NoParent.Equals(input.NoParent)
                ) &&
                (
                    this.NumUses == input.NumUses ||

                    this.NumUses.Equals(input.NumUses)
                ) &&
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))

                ) &&
                (
                    this.Policies == input.Policies ||
                    this.Policies != null &&
                    input.Policies != null &&
                    this.Policies.SequenceEqual(input.Policies)
                ) &&
                (
                    this.Renewable == input.Renewable ||

                    this.Renewable.Equals(input.Renewable)
                ) &&
                (
                    this.Ttl == input.Ttl ||
                    (this.Ttl != null &&
                    this.Ttl.Equals(input.Ttl))

                ) &&
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))

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

                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }

                if (this.EntityAlias != null)
                {
                    hashCode = (hashCode * 59) + this.EntityAlias.GetHashCode();
                }

                if (this.ExplicitMaxTtl != null)
                {
                    hashCode = (hashCode * 59) + this.ExplicitMaxTtl.GetHashCode();
                }

                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }

                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.NoDefaultPolicy.GetHashCode();

                hashCode = (hashCode * 59) + this.NoParent.GetHashCode();

                hashCode = (hashCode * 59) + this.NumUses.GetHashCode();
                if (this.Period != null)
                {
                    hashCode = (hashCode * 59) + this.Period.GetHashCode();
                }

                if (this.Policies != null)
                {
                    hashCode = (hashCode * 59) + this.Policies.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.Renewable.GetHashCode();
                if (this.Ttl != null)
                {
                    hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
                }

                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
