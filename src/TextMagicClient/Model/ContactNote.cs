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
    /// ContactNote
    /// </summary>
    [DataContract]
    public partial class ContactNote :  IEquatable<ContactNote>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactNote" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactNote() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactNote" /> class.
        /// </summary>
        /// <param name="id">Contact note ID. (required).</param>
        /// <param name="createdAt">Contact note creation time. (required).</param>
        /// <param name="note">Contact note text. (required).</param>
        /// <param name="user">user (required).</param>
        public ContactNote(int? id = default(int?), DateTime? createdAt = default(DateTime?), string note = default(string), User user = default(User))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ContactNote and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for ContactNote and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            // to ensure "note" is required (not null)
            if (note == null)
            {
                throw new InvalidDataException("note is a required property for ContactNote and cannot be null");
            }
            else
            {
                this.Note = note;
            }
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new InvalidDataException("user is a required property for ContactNote and cannot be null");
            }
            else
            {
                this.User = user;
            }
        }
        
        /// <summary>
        /// Contact note ID.
        /// </summary>
        /// <value>Contact note ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Contact note creation time.
        /// </summary>
        /// <value>Contact note creation time.</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Contact note text.
        /// </summary>
        /// <value>Contact note text.</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactNote {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as ContactNote);
        }

        /// <summary>
        /// Returns true if ContactNote instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactNote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactNote input)
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
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
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
