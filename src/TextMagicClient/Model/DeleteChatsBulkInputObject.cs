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
    /// DeleteChatsBulkInputObject
    /// </summary>
    [DataContract]
    public partial class DeleteChatsBulkInputObject :  IEquatable<DeleteChatsBulkInputObject>, IValidatableObject
    {
        /// <summary>
        /// Default is an empty string. If set, all entities with specified status will be affected.
        /// </summary>
        /// <value>Default is an empty string. If set, all entities with specified status will be affected.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum A for value: a
            /// </summary>
            [EnumMember(Value = "a")]
            A = 1,
            
            /// <summary>
            /// Enum C for value: c
            /// </summary>
            [EnumMember(Value = "c")]
            C = 2,
            
            /// <summary>
            /// Enum D for value: d
            /// </summary>
            [EnumMember(Value = "d")]
            D = 3
        }

        /// <summary>
        /// Default is an empty string. If set, all entities with specified status will be affected.
        /// </summary>
        /// <value>Default is an empty string. If set, all entities with specified status will be affected.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteChatsBulkInputObject" /> class.
        /// </summary>
        /// <param name="ids">Entity ID(s), separated by comma..</param>
        /// <param name="all">Entity ID(s), separated by comma..</param>
        /// <param name="status">Default is an empty string. If set, all entities with specified status will be affected..</param>
        public DeleteChatsBulkInputObject(string ids = default(string), bool? all = default(bool?), StatusEnum? status = default(StatusEnum?))
        {
            this.Ids = ids;
            this.All = all;
            this.Status = status;
        }
        
        /// <summary>
        /// Entity ID(s), separated by comma.
        /// </summary>
        /// <value>Entity ID(s), separated by comma.</value>
        [DataMember(Name="ids", EmitDefaultValue=false)]
        public string Ids { get; set; }

        /// <summary>
        /// Entity ID(s), separated by comma.
        /// </summary>
        /// <value>Entity ID(s), separated by comma.</value>
        [DataMember(Name="all", EmitDefaultValue=false)]
        public bool? All { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteChatsBulkInputObject {\n");
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
            return this.Equals(input as DeleteChatsBulkInputObject);
        }

        /// <summary>
        /// Returns true if DeleteChatsBulkInputObject instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteChatsBulkInputObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteChatsBulkInputObject input)
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
