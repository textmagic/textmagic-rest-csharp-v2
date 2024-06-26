/* 
 * Textmagic API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = TextMagicClient.Client.SwaggerDateConverter;

namespace TextMagicClient.Model
{
    /// <summary>
    /// DeleteScheduledMessagesBulkInputObject
    /// </summary>
    [DataContract]
    public partial class DeleteScheduledMessagesBulkInputObject :  IEquatable<DeleteScheduledMessagesBulkInputObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteScheduledMessagesBulkInputObject" /> class.
        /// </summary>
        /// <param name="ids">Entity ID(s), separated by comma..</param>
        /// <param name="all">Default is 0 (false). If set to 1, all the entities will be removed..</param>
        /// <param name="status">Default is an empty string (false). If set, all entities with specified status will be affected. (default to &quot;&quot;).</param>
        public DeleteScheduledMessagesBulkInputObject(string ids = default(string), int? all = default(int?), string status = "")
        {
            this.Ids = ids;
            this.All = all;
            // use default value if no "status" provided
            if (status == null)
            {
                this.Status = "";
            }
            else
            {
                this.Status = status;
            }
        }
        
        /// <summary>
        /// Entity ID(s), separated by comma.
        /// </summary>
        /// <value>Entity ID(s), separated by comma.</value>
        [DataMember(Name="ids", EmitDefaultValue=false)]
        public string Ids { get; set; }

        /// <summary>
        /// Default is 0 (false). If set to 1, all the entities will be removed.
        /// </summary>
        /// <value>Default is 0 (false). If set to 1, all the entities will be removed.</value>
        [DataMember(Name="all", EmitDefaultValue=false)]
        public int? All { get; set; }

        /// <summary>
        /// Default is an empty string (false). If set, all entities with specified status will be affected.
        /// </summary>
        /// <value>Default is an empty string (false). If set, all entities with specified status will be affected.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteScheduledMessagesBulkInputObject {\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  All: ").Append(All).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteScheduledMessagesBulkInputObject);
        }

        /// <summary>
        /// Returns true if DeleteScheduledMessagesBulkInputObject instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteScheduledMessagesBulkInputObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteScheduledMessagesBulkInputObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ids == input.Ids ||
                    (this.Ids != null &&
                    this.Ids.Equals(input.Ids))
                ) && 
                (
                    this.All == input.All ||
                    (this.All != null &&
                    this.All.Equals(input.All))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Ids != null)
                    hashCode = hashCode * 59 + this.Ids.GetHashCode();
                if (this.All != null)
                    hashCode = hashCode * 59 + this.All.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
