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
    /// CustomFieldListItem
    /// </summary>
    [DataContract]
    public partial class CustomFieldListItem :  IEquatable<CustomFieldListItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFieldListItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomFieldListItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFieldListItem" /> class.
        /// </summary>
        /// <param name="id">Custom Field ID. (required).</param>
        /// <param name="userCustomFieldId">Old property custom Field ID. (required).</param>
        /// <param name="name">Custom Field name. (required).</param>
        /// <param name="value">Custom Field value. (required).</param>
        /// <param name="createdAt">Custom field creation time. (required).</param>
        public CustomFieldListItem(int? id = default(int?), int? userCustomFieldId = default(int?), string name = default(string), string value = default(string), DateTime? createdAt = default(DateTime?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for CustomFieldListItem and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "userCustomFieldId" is required (not null)
            if (userCustomFieldId == null)
            {
                throw new InvalidDataException("userCustomFieldId is a required property for CustomFieldListItem and cannot be null");
            }
            else
            {
                this.UserCustomFieldId = userCustomFieldId;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for CustomFieldListItem and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for CustomFieldListItem and cannot be null");
            }
            else
            {
                this.Value = value;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for CustomFieldListItem and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
        }
        
        /// <summary>
        /// Custom Field ID.
        /// </summary>
        /// <value>Custom Field ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Old property custom Field ID.
        /// </summary>
        /// <value>Old property custom Field ID.</value>
        [DataMember(Name="userCustomFieldId", EmitDefaultValue=false)]
        public int? UserCustomFieldId { get; set; }

        /// <summary>
        /// Custom Field name.
        /// </summary>
        /// <value>Custom Field name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Custom Field value.
        /// </summary>
        /// <value>Custom Field value.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Custom field creation time.
        /// </summary>
        /// <value>Custom field creation time.</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomFieldListItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserCustomFieldId: ").Append(UserCustomFieldId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as CustomFieldListItem);
        }

        /// <summary>
        /// Returns true if CustomFieldListItem instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomFieldListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomFieldListItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.UserCustomFieldId == input.UserCustomFieldId ||
                    (this.UserCustomFieldId != null &&
                    this.UserCustomFieldId.Equals(input.UserCustomFieldId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.UserCustomFieldId != null)
                    hashCode = hashCode * 59 + this.UserCustomFieldId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
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
