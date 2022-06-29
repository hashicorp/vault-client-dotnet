/*
 * HashiCorp Vault API
 *
 * HTTP API that gives you full access to Vault. All API routes are prefixed with `/v1/`.
 *
 * The version of the OpenAPI document: 1.11.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


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
using FileParameter = VaultClient.Client.FileParameter;
using OpenAPIDateConverter = VaultClient.Client.OpenAPIDateConverter;

namespace VaultClient.Model
{
    /// <summary>
    /// SystemPluginsCatalogRequest
    /// </summary>
    [DataContract(Name = "SystemPluginsCatalogRequest")]
    public partial class SystemPluginsCatalogRequest : IEquatable<SystemPluginsCatalogRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemPluginsCatalogRequest" /> class.
        /// </summary>
        /// <param name="args">The args passed to plugin command..</param>
        /// <param name="command">The command used to start the plugin. The executable defined in this command must exist in vault&#39;s plugin directory..</param>
        /// <param name="env">The environment variables passed to plugin command. Each entry is of the form \&quot;key&#x3D;value\&quot;..</param>
        /// <param name="sha256">The SHA256 sum of the executable used in the command field. This should be HEX encoded..</param>
        /// <param name="type">The type of the plugin, may be auth, secret, or database.</param>
        public SystemPluginsCatalogRequest(List<string> args = default(List<string>), string command = default(string), List<string> env = default(List<string>), string sha256 = default(string), string type = default(string))
        {
            this.Args = args;
            this.Command = command;
            this.Env = env;
            this.Sha256 = sha256;
            this.Type = type;
        }

        /// <summary>
        /// The args passed to plugin command.
        /// </summary>
        /// <value>The args passed to plugin command.</value>
        [DataMember(Name = "args", EmitDefaultValue = false)]
        public List<string> Args { get; set; }

        /// <summary>
        /// The command used to start the plugin. The executable defined in this command must exist in vault&#39;s plugin directory.
        /// </summary>
        /// <value>The command used to start the plugin. The executable defined in this command must exist in vault&#39;s plugin directory.</value>
        [DataMember(Name = "command", EmitDefaultValue = false)]
        public string Command { get; set; }

        /// <summary>
        /// The environment variables passed to plugin command. Each entry is of the form \&quot;key&#x3D;value\&quot;.
        /// </summary>
        /// <value>The environment variables passed to plugin command. Each entry is of the form \&quot;key&#x3D;value\&quot;.</value>
        [DataMember(Name = "env", EmitDefaultValue = false)]
        public List<string> Env { get; set; }

        /// <summary>
        /// The SHA256 sum of the executable used in the command field. This should be HEX encoded.
        /// </summary>
        /// <value>The SHA256 sum of the executable used in the command field. This should be HEX encoded.</value>
        [DataMember(Name = "sha256", EmitDefaultValue = false)]
        public string Sha256 { get; set; }

        /// <summary>
        /// The type of the plugin, may be auth, secret, or database
        /// </summary>
        /// <value>The type of the plugin, may be auth, secret, or database</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SystemPluginsCatalogRequest {\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
            sb.Append("  Env: ").Append(Env).Append("\n");
            sb.Append("  Sha256: ").Append(Sha256).Append("\n");
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
            return this.Equals(input as SystemPluginsCatalogRequest);
        }

        /// <summary>
        /// Returns true if SystemPluginsCatalogRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemPluginsCatalogRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemPluginsCatalogRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Args == input.Args ||
                    this.Args != null &&
                    input.Args != null &&
                    this.Args.SequenceEqual(input.Args)
                ) && 
                (
                    this.Command == input.Command ||
                    (this.Command != null &&
                    this.Command.Equals(input.Command))
                ) && 
                (
                    this.Env == input.Env ||
                    this.Env != null &&
                    input.Env != null &&
                    this.Env.SequenceEqual(input.Env)
                ) && 
                (
                    this.Sha256 == input.Sha256 ||
                    (this.Sha256 != null &&
                    this.Sha256.Equals(input.Sha256))
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
                if (this.Args != null)
                {
                    hashCode = (hashCode * 59) + this.Args.GetHashCode();
                }
                if (this.Command != null)
                {
                    hashCode = (hashCode * 59) + this.Command.GetHashCode();
                }
                if (this.Env != null)
                {
                    hashCode = (hashCode * 59) + this.Env.GetHashCode();
                }
                if (this.Sha256 != null)
                {
                    hashCode = (hashCode * 59) + this.Sha256.GetHashCode();
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
