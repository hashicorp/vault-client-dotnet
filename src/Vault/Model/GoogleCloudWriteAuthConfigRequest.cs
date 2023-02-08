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
    /// GoogleCloudWriteAuthConfigRequest
    /// </summary>
    [DataContract(Name = "GoogleCloudWriteAuthConfigRequest")]
    public partial class GoogleCloudWriteAuthConfigRequest : IEquatable<GoogleCloudWriteAuthConfigRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleCloudWriteAuthConfigRequest" /> class.
        /// </summary>
        /// <param name="credentials">Google credentials JSON that Vault will use to verify users against GCP APIs. If not specified, will use application default credentials.</param>
        /// <param name="customEndpoint">Specifies overrides for various Google API Service Endpoints used in requests..</param>
        /// <param name="gceAlias">Indicates what value to use when generating an alias for GCE authentications. (default to &quot;role_id&quot;).</param>
        /// <param name="gceMetadata">The metadata to include on the aliases and audit logs generated by this plugin. When set to &#39;default&#39;, includes: instance_creation_timestamp, instance_id, instance_name, project_id, project_number, role, service_account_id, service_account_email, zone. Not editing this field means the &#39;default&#39; fields are included. Explicitly setting this field to empty overrides the &#39;default&#39; and means no metadata will be included. If not using &#39;default&#39;, explicit fields must be sent like: &#39;field1,field2&#39;..</param>
        /// <param name="googleCertsEndpoint">Deprecated. This field does nothing and be removed in a future release.</param>
        /// <param name="iamAlias">Indicates what value to use when generating an alias for IAM authentications. (default to &quot;role_id&quot;).</param>
        /// <param name="iamMetadata">The metadata to include on the aliases and audit logs generated by this plugin. When set to &#39;default&#39;, includes: project_id, role, service_account_id, service_account_email. Not editing this field means the &#39;default&#39; fields are included. Explicitly setting this field to empty overrides the &#39;default&#39; and means no metadata will be included. If not using &#39;default&#39;, explicit fields must be sent like: &#39;field1,field2&#39;..</param>
        public GoogleCloudWriteAuthConfigRequest(string credentials = default(string), Object customEndpoint = default(Object), string gceAlias = "role_id", List<string> gceMetadata = default(List<string>), string googleCertsEndpoint = default(string), string iamAlias = "role_id", List<string> iamMetadata = default(List<string>))
        {
            this.Credentials = credentials;
            this.CustomEndpoint = customEndpoint;
            // use default value if no "gceAlias" provided
            this.GceAlias = gceAlias ?? "role_id";
            this.GceMetadata = gceMetadata;
            this.GoogleCertsEndpoint = googleCertsEndpoint;
            // use default value if no "iamAlias" provided
            this.IamAlias = iamAlias ?? "role_id";
            this.IamMetadata = iamMetadata;
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
        /// The metadata to include on the aliases and audit logs generated by this plugin. When set to &#39;default&#39;, includes: instance_creation_timestamp, instance_id, instance_name, project_id, project_number, role, service_account_id, service_account_email, zone. Not editing this field means the &#39;default&#39; fields are included. Explicitly setting this field to empty overrides the &#39;default&#39; and means no metadata will be included. If not using &#39;default&#39;, explicit fields must be sent like: &#39;field1,field2&#39;.
        /// </summary>
        /// <value>The metadata to include on the aliases and audit logs generated by this plugin. When set to &#39;default&#39;, includes: instance_creation_timestamp, instance_id, instance_name, project_id, project_number, role, service_account_id, service_account_email, zone. Not editing this field means the &#39;default&#39; fields are included. Explicitly setting this field to empty overrides the &#39;default&#39; and means no metadata will be included. If not using &#39;default&#39;, explicit fields must be sent like: &#39;field1,field2&#39;.</value>
        [DataMember(Name = "gce_metadata", EmitDefaultValue = false)]
        public List<string> GceMetadata { get; set; }

        /// <summary>
        /// Deprecated. This field does nothing and be removed in a future release
        /// </summary>
        /// <value>Deprecated. This field does nothing and be removed in a future release</value>
        [DataMember(Name = "google_certs_endpoint", EmitDefaultValue = false)]
        [Obsolete]
        public string GoogleCertsEndpoint { get; set; }

        /// <summary>
        /// Indicates what value to use when generating an alias for IAM authentications.
        /// </summary>
        /// <value>Indicates what value to use when generating an alias for IAM authentications.</value>
        [DataMember(Name = "iam_alias", EmitDefaultValue = false)]
        public string IamAlias { get; set; }

        /// <summary>
        /// The metadata to include on the aliases and audit logs generated by this plugin. When set to &#39;default&#39;, includes: project_id, role, service_account_id, service_account_email. Not editing this field means the &#39;default&#39; fields are included. Explicitly setting this field to empty overrides the &#39;default&#39; and means no metadata will be included. If not using &#39;default&#39;, explicit fields must be sent like: &#39;field1,field2&#39;.
        /// </summary>
        /// <value>The metadata to include on the aliases and audit logs generated by this plugin. When set to &#39;default&#39;, includes: project_id, role, service_account_id, service_account_email. Not editing this field means the &#39;default&#39; fields are included. Explicitly setting this field to empty overrides the &#39;default&#39; and means no metadata will be included. If not using &#39;default&#39;, explicit fields must be sent like: &#39;field1,field2&#39;.</value>
        [DataMember(Name = "iam_metadata", EmitDefaultValue = false)]
        public List<string> IamMetadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoogleCloudWriteAuthConfigRequest {\n");
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
            return this.Equals(input as GoogleCloudWriteAuthConfigRequest);
        }

        /// <summary>
        /// Returns true if GoogleCloudWriteAuthConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleCloudWriteAuthConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleCloudWriteAuthConfigRequest input)
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
