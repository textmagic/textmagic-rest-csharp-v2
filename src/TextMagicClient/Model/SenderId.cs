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
    /// SenderId
    /// </summary>
    [DataContract]
    public partial class SenderId :  IEquatable<SenderId>, IValidatableObject
    {
        /// <summary>
        /// *   **P** for Pending - this Sender ID is being reviewed by our support team; *   **R** for Rejected - our support team rejected your application for this Sender ID; *   **A** for Active. 
        /// </summary>
        /// <value>*   **P** for Pending - this Sender ID is being reviewed by our support team; *   **R** for Rejected - our support team rejected your application for this Sender ID; *   **A** for Active. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum A for value: A
            /// </summary>
            [EnumMember(Value = "A")]
            A = 1,
            
            /// <summary>
            /// Enum R for value: R
            /// </summary>
            [EnumMember(Value = "R")]
            R = 2,
            
            /// <summary>
            /// Enum P for value: P
            /// </summary>
            [EnumMember(Value = "P")]
            P = 3
        }

        /// <summary>
        /// *   **P** for Pending - this Sender ID is being reviewed by our support team; *   **R** for Rejected - our support team rejected your application for this Sender ID; *   **A** for Active. 
        /// </summary>
        /// <value>*   **P** for Pending - this Sender ID is being reviewed by our support team; *   **R** for Rejected - our support team rejected your application for this Sender ID; *   **A** for Active. </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SenderId" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SenderId() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SenderId" /> class.
        /// </summary>
        /// <param name="id">Numeric sender ID. (required).</param>
        /// <param name="displayTimeFormat">Format for representation of time..</param>
        /// <param name="senderId">Alphanumeric ID. (required).</param>
        /// <param name="user">user (required).</param>
        /// <param name="status">*   **P** for Pending - this Sender ID is being reviewed by our support team; *   **R** for Rejected - our support team rejected your application for this Sender ID; *   **A** for Active.  (required).</param>
        public SenderId(int? id = default(int?), string displayTimeFormat = default(string), string senderId = default(string), User user = default(User), StatusEnum status = default(StatusEnum))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for SenderId and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "senderId" is required (not null)
            if (senderId == null)
            {
                throw new InvalidDataException("senderId is a required property for SenderId and cannot be null");
            }
            else
            {
                this._SenderId = senderId;
            }
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new InvalidDataException("user is a required property for SenderId and cannot be null");
            }
            else
            {
                this.User = user;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for SenderId and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            this.DisplayTimeFormat = displayTimeFormat;
        }
        
        /// <summary>
        /// Numeric sender ID.
        /// </summary>
        /// <value>Numeric sender ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Format for representation of time.
        /// </summary>
        /// <value>Format for representation of time.</value>
        [DataMember(Name="displayTimeFormat", EmitDefaultValue=false)]
        public string DisplayTimeFormat { get; set; }

        /// <summary>
        /// Alphanumeric ID.
        /// </summary>
        /// <value>Alphanumeric ID.</value>
        [DataMember(Name="senderId", EmitDefaultValue=false)]
        public string _SenderId { get; set; }

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
            sb.Append("class SenderId {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayTimeFormat: ").Append(DisplayTimeFormat).Append("\n");
            sb.Append("  _SenderId: ").Append(_SenderId).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as SenderId);
        }

        /// <summary>
        /// Returns true if SenderId instances are equal
        /// </summary>
        /// <param name="input">Instance of SenderId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SenderId input)
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
                    this.DisplayTimeFormat == input.DisplayTimeFormat ||
                    (this.DisplayTimeFormat != null &&
                    this.DisplayTimeFormat.Equals(input.DisplayTimeFormat))
                ) && 
                (
                    this._SenderId == input._SenderId ||
                    (this._SenderId != null &&
                    this._SenderId.Equals(input._SenderId))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DisplayTimeFormat != null)
                    hashCode = hashCode * 59 + this.DisplayTimeFormat.GetHashCode();
                if (this._SenderId != null)
                    hashCode = hashCode * 59 + this._SenderId.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
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
