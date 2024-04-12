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
    /// UserStatement
    /// </summary>
    [DataContract]
    public partial class UserStatement :  IEquatable<UserStatement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserStatement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserStatement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserStatement" /> class.
        /// </summary>
        /// <param name="id">User statement ID. (required).</param>
        /// <param name="userId">User ID. (required).</param>
        /// <param name="date">User statement date. (required).</param>
        /// <param name="balance">balance (required).</param>
        /// <param name="delta">Balance change amount. (required).</param>
        /// <param name="type">Type of statement (what you have been charged for): *   **sms** - for sending SMS *   **number** - for renewing a dedicated number; *   **schedule** - for scheduling text messages; *   **topup** - for adding credits to your account.  (required).</param>
        /// <param name="value">Value differs by **type**: *   for **sms**, it is the sent messages amount; *   for **number**, it is a dedicated phone number; *   for **schedule**, it is a scheduled messages amount; *   for **top-up**, it is an invoice ID.  (required).</param>
        /// <param name="comment">Optional comment. (required).</param>
        public UserStatement(int? id = default(int?), int? userId = default(int?), DateTime? date = default(DateTime?), double? balance = default(double?), float? delta = default(float?), string type = default(string), string value = default(string), string comment = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for UserStatement and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for UserStatement and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }
            // to ensure "date" is required (not null)
            if (date == null)
            {
                throw new InvalidDataException("date is a required property for UserStatement and cannot be null");
            }
            else
            {
                this.Date = date;
            }
            // to ensure "balance" is required (not null)
            if (balance == null)
            {
                throw new InvalidDataException("balance is a required property for UserStatement and cannot be null");
            }
            else
            {
                this.Balance = balance;
            }
            // to ensure "delta" is required (not null)
            if (delta == null)
            {
                throw new InvalidDataException("delta is a required property for UserStatement and cannot be null");
            }
            else
            {
                this.Delta = delta;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for UserStatement and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for UserStatement and cannot be null");
            }
            else
            {
                this.Value = value;
            }
            // to ensure "comment" is required (not null)
            if (comment == null)
            {
                throw new InvalidDataException("comment is a required property for UserStatement and cannot be null");
            }
            else
            {
                this.Comment = comment;
            }
        }
        
        /// <summary>
        /// User statement ID.
        /// </summary>
        /// <value>User statement ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// User ID.
        /// </summary>
        /// <value>User ID.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// User statement date.
        /// </summary>
        /// <value>User statement date.</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public double? Balance { get; set; }

        /// <summary>
        /// Balance change amount.
        /// </summary>
        /// <value>Balance change amount.</value>
        [DataMember(Name="delta", EmitDefaultValue=false)]
        public float? Delta { get; set; }

        /// <summary>
        /// Type of statement (what you have been charged for): *   **sms** - for sending SMS *   **number** - for renewing a dedicated number; *   **schedule** - for scheduling text messages; *   **topup** - for adding credits to your account. 
        /// </summary>
        /// <value>Type of statement (what you have been charged for): *   **sms** - for sending SMS *   **number** - for renewing a dedicated number; *   **schedule** - for scheduling text messages; *   **topup** - for adding credits to your account. </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Value differs by **type**: *   for **sms**, it is the sent messages amount; *   for **number**, it is a dedicated phone number; *   for **schedule**, it is a scheduled messages amount; *   for **top-up**, it is an invoice ID. 
        /// </summary>
        /// <value>Value differs by **type**: *   for **sms**, it is the sent messages amount; *   for **number**, it is a dedicated phone number; *   for **schedule**, it is a scheduled messages amount; *   for **top-up**, it is an invoice ID. </value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Optional comment.
        /// </summary>
        /// <value>Optional comment.</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserStatement {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Delta: ").Append(Delta).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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
            return this.Equals(input as UserStatement);
        }

        /// <summary>
        /// Returns true if UserStatement instances are equal
        /// </summary>
        /// <param name="input">Instance of UserStatement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserStatement input)
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
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.Delta == input.Delta ||
                    (this.Delta != null &&
                    this.Delta.Equals(input.Delta))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.Delta != null)
                    hashCode = hashCode * 59 + this.Delta.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
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
