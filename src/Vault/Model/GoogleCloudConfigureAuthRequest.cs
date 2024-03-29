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
    /// GoogleCloudConfigureAuthRequest
    /// </summary>
    [DataContract(Name = "GoogleCloudConfigureAuthRequest")]
    public partial class GoogleCloudConfigureAuthRequest : IEquatable<GoogleCloudConfigureAuthRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleCloudConfigureAuthRequest" /> class.
        /// </summary>

        /// <param name="Credentials">Google credentials JSON that Vault will use to verify users against GCP APIs. If not specified, will use application default credentials.</param>

        /// <param name="CustomEndpoint">Specifies overrides for various Google API Service Endpoints used in requests..</param>

        /// <param name="GceAlias">Indicates what value to use when generating an alias for GCE authentications. (default to &quot;role_id&quot;).</param>

        /// <param name="GceMetadata">The metadata to include on the aliases and audit logs generated by this plugin. When set to &#x27;default&#x27;, includes: instance_creation_timestamp, instance_id, instance_name, project_id, project_number, role, service_account_id, service_account_email, zone. Not editing this field means the &#x27;default&#x27; fields are included. Explicitly setting this field to empty overrides the &#x27;default&#x27; and means no metadata will be included. If not using &#x27;default&#x27;, explicit fields must be sent like: &#x27;field1,field2&#x27;..</param>

        /// <param name="GoogleCertsEndpoint">Deprecated. This field does nothing and be removed in a future release.</param>

        /// <param name="IamAlias">Indicates what value to use when generating an alias for IAM authentications. (default to &quot;role_id&quot;).</param>

        /// <param name="IamMetadata">The metadata to include on the aliases and audit logs generated by this plugin. When set to &#x27;default&#x27;, includes: project_id, role, service_account_id, service_account_email. Not editing this field means the &#x27;default&#x27; fields are included. Explicitly setting this field to empty overrides the &#x27;default&#x27; and means no metadata will be included. If not using &#x27;default&#x27;, explicit fields must be sent like: &#x27;field1,field2&#x27;..</param>


        public GoogleCloudConfigureAuthRequest(string Credentials = default(string), Object CustomEndpoint = default(Object), string GceAlias = "role_id", List<string> GceMetadata = default(List<string>), string GoogleCertsEndpoint = default(string), string IamAlias = "role_id", List<string> IamMetadata = default(List<string>))
        {

            this.Credentials = Credentials;

            this.CustomEndpoint = CustomEndpoint;

            // use default value if no "GceAlias" provided
            this.GceAlias = GceAlias ?? "role_id";


            this.GceMetadata = GceMetadata;

            this.GoogleCertsEndpoint = GoogleCertsEndpoint;

            // use default value if no "IamAlias" provided
            this.IamAlias = IamAlias ?? "role_id";


            this.IamMetadata = IamMetadata;

        }

        /// <summary>
        /// Google credentials JSON that Vault will use to verify users against GCP APIs. If not specified, will use application default credentials
        /// </summary>
        /// <value>Google credentials JSON that Vault will use to verify users against GCP APIs. If not specified, will use application default credentials</value>
        [DataMember(Name = "credentials", EmitDefaultValue = false)]

        public string Credentials { get; set; }


        /// <summary>
        /// Specifies overrides for various Google API Service Endpoints used in requests.
        /// </summary>
        /// <value>Specifies overrides for various Google API Service Endpoints used in requests.</value>
        [DataMember(Name = "custom_endpoint", EmitDefaultValue = false)]

        public Object CustomEndpoint { get; set; }


        /// <summary>
        /// Indicates what value to use when generating an alias for GCE authentications.
        /// </summary>
        /// <value>Indicates what value to use when generating an alias for GCE authentications.</value>
        [DataMember(Name = "gce_alias", EmitDefaultValue = false)]

        public string GceAlias { get; set; }


        /// <summary>
        /// The metadata to include on the aliases and audit logs generated by this plugin. When set to &#x27;default&#x27;, includes: instance_creation_timestamp, instance_id, instance_name, project_id, project_number, role, service_account_id, service_account_email, zone. Not editing this field means the &#x27;default&#x27; fields are included. Explicitly setting this field to empty overrides the &#x27;default&#x27; and means no metadata will be included. If not using &#x27;default&#x27;, explicit fields must be sent like: &#x27;field1,field2&#x27;.
        /// </summary>
        /// <value>The metadata to include on the aliases and audit logs generated by this plugin. When set to &#x27;default&#x27;, includes: instance_creation_timestamp, instance_id, instance_name, project_id, project_number, role, service_account_id, service_account_email, zone. Not editing this field means the &#x27;default&#x27; fields are included. Explicitly setting this field to empty overrides the &#x27;default&#x27; and means no metadata will be included. If not using &#x27;default&#x27;, explicit fields must be sent like: &#x27;field1,field2&#x27;.</value>
        [DataMember(Name = "gce_metadata", EmitDefaultValue = false)]

        public List<string> GceMetadata { get; set; }


        /// <summary>
        /// Deprecated. This field does nothing and be removed in a future release
        /// </summary>
        /// <value>Deprecated. This field does nothing and be removed in a future release</value>
        [DataMember(Name = "google_certs_endpoint", EmitDefaultValue = false)]

        [Obsolete] public string GoogleCertsEndpoint { get; set; }


        /// <summary>
        /// Indicates what value to use when generating an alias for IAM authentications.
        /// </summary>
        /// <value>Indicates what value to use when generating an alias for IAM authentications.</value>
        [DataMember(Name = "iam_alias", EmitDefaultValue = false)]

        public string IamAlias { get; set; }


        /// <summary>
        /// The metadata to include on the aliases and audit logs generated by this plugin. When set to &#x27;default&#x27;, includes: project_id, role, service_account_id, service_account_email. Not editing this field means the &#x27;default&#x27; fields are included. Explicitly setting this field to empty overrides the &#x27;default&#x27; and means no metadata will be included. If not using &#x27;default&#x27;, explicit fields must be sent like: &#x27;field1,field2&#x27;.
        /// </summary>
        /// <value>The metadata to include on the aliases and audit logs generated by this plugin. When set to &#x27;default&#x27;, includes: project_id, role, service_account_id, service_account_email. Not editing this field means the &#x27;default&#x27; fields are included. Explicitly setting this field to empty overrides the &#x27;default&#x27; and means no metadata will be included. If not using &#x27;default&#x27;, explicit fields must be sent like: &#x27;field1,field2&#x27;.</value>
        [DataMember(Name = "iam_metadata", EmitDefaultValue = false)]

        public List<string> IamMetadata { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoogleCloudConfigureAuthRequest {\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  CustomEndpoint: ").Append(CustomEndpoint).Append("\n");
            sb.Append("  GceAlias: ").Append(GceAlias).Append("\n");
            sb.Append("  GceMetadata: ").Append(GceMetadata).Append("\n");
            sb.Append("  GoogleCertsEndpoint: ").Append(GoogleCertsEndpoint).Append("\n");
            sb.Append("  IamAlias: ").Append(IamAlias).Append("\n");
            sb.Append("  IamMetadata: ").Append(IamMetadata).Append("\n");
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
            return this.Equals(input as GoogleCloudConfigureAuthRequest);
        }

        /// <summary>
        /// Returns true if GoogleCloudConfigureAuthRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleCloudConfigureAuthRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleCloudConfigureAuthRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))

                ) &&
                (
                    this.CustomEndpoint == input.CustomEndpoint ||
                    (this.CustomEndpoint != null &&
                    this.CustomEndpoint.Equals(input.CustomEndpoint))

                ) &&
                (
                    this.GceAlias == input.GceAlias ||
                    (this.GceAlias != null &&
                    this.GceAlias.Equals(input.GceAlias))

                ) &&
                (
                    this.GceMetadata == input.GceMetadata ||
                    this.GceMetadata != null &&
                    input.GceMetadata != null &&
                    this.GceMetadata.SequenceEqual(input.GceMetadata)
                ) &&
                (
                    this.GoogleCertsEndpoint == input.GoogleCertsEndpoint ||
                    (this.GoogleCertsEndpoint != null &&
                    this.GoogleCertsEndpoint.Equals(input.GoogleCertsEndpoint))

                ) &&
                (
                    this.IamAlias == input.IamAlias ||
                    (this.IamAlias != null &&
                    this.IamAlias.Equals(input.IamAlias))

                ) &&
                (
                    this.IamMetadata == input.IamMetadata ||
                    this.IamMetadata != null &&
                    input.IamMetadata != null &&
                    this.IamMetadata.SequenceEqual(input.IamMetadata)
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

                if (this.Credentials != null)
                {
                    hashCode = (hashCode * 59) + this.Credentials.GetHashCode();
                }

                if (this.CustomEndpoint != null)
                {
                    hashCode = (hashCode * 59) + this.CustomEndpoint.GetHashCode();
                }

                if (this.GceAlias != null)
                {
                    hashCode = (hashCode * 59) + this.GceAlias.GetHashCode();
                }

                if (this.GceMetadata != null)
                {
                    hashCode = (hashCode * 59) + this.GceMetadata.GetHashCode();
                }

                if (this.GoogleCertsEndpoint != null)
                {
                    hashCode = (hashCode * 59) + this.GoogleCertsEndpoint.GetHashCode();
                }

                if (this.IamAlias != null)
                {
                    hashCode = (hashCode * 59) + this.IamAlias.GetHashCode();
                }

                if (this.IamMetadata != null)
                {
                    hashCode = (hashCode * 59) + this.IamMetadata.GetHashCode();
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
