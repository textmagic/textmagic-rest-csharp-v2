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
    /// BulkSession
    /// </summary>
    [DataContract]
    public partial class BulkSession :  IEquatable<BulkSession>, IValidatableObject
    {
        /// <summary>
        /// * **n** – bulk session is just created * **w** - work in progress * **f** - failed * **c** - completed with success * **s** - suspended 
        /// </summary>
        /// <value>* **n** – bulk session is just created * **w** - work in progress * **f** - failed * **c** - completed with success * **s** - suspended </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum N for value: n
            /// </summary>
            [EnumMember(Value = "n")]
            N = 1,
            
            /// <summary>
            /// Enum W for value: w
            /// </summary>
            [EnumMember(Value = "w")]
            W = 2,
            
            /// <summary>
            /// Enum F for value: f
            /// </summary>
            [EnumMember(Value = "f")]
            F = 3,
            
            /// <summary>
            /// Enum C for value: c
            /// </summary>
            [EnumMember(Value = "c")]
            C = 4,
            
            /// <summary>
            /// Enum S for value: s
            /// </summary>
            [EnumMember(Value = "s")]
            S = 5
        }

        /// <summary>
        /// * **n** – bulk session is just created * **w** - work in progress * **f** - failed * **c** - completed with success * **s** - suspended 
        /// </summary>
        /// <value>* **n** – bulk session is just created * **w** - work in progress * **f** - failed * **c** - completed with success * **s** - suspended </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSession" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkSession() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSession" /> class.
        /// </summary>
        /// <param name="id">Bulk Session ID. (required).</param>
        /// <param name="status">* **n** – bulk session is just created * **w** - work in progress * **f** - failed * **c** - completed with success * **s** - suspended  (required).</param>
        /// <param name="itemsProcessed">Amount of messages already processed. (required).</param>
        /// <param name="itemsTotal">Total amount of messages to be processed. (required).</param>
        /// <param name="createdAt">Creation date and time of a Bulk Session. (required).</param>
        /// <param name="session">session (required).</param>
        /// <param name="text">Message text of a Bulk Session. (required).</param>
        public BulkSession(int? id = default(int?), StatusEnum status = default(StatusEnum), int? itemsProcessed = default(int?), int? itemsTotal = default(int?), DateTime? createdAt = default(DateTime?), MessageSession session = default(MessageSession), string text = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for BulkSession and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for BulkSession and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "itemsProcessed" is required (not null)
            if (itemsProcessed == null)
            {
                throw new InvalidDataException("itemsProcessed is a required property for BulkSession and cannot be null");
            }
            else
            {
                this.ItemsProcessed = itemsProcessed;
            }
            // to ensure "itemsTotal" is required (not null)
            if (itemsTotal == null)
            {
                throw new InvalidDataException("itemsTotal is a required property for BulkSession and cannot be null");
            }
            else
            {
                this.ItemsTotal = itemsTotal;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for BulkSession and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            // to ensure "session" is required (not null)
            if (session == null)
            {
                throw new InvalidDataException("session is a required property for BulkSession and cannot be null");
            }
            else
            {
                this.Session = session;
            }
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new InvalidDataException("text is a required property for BulkSession and cannot be null");
            }
            else
            {
                this.Text = text;
            }
        }
        
        /// <summary>
        /// Bulk Session ID.
        /// </summary>
        /// <value>Bulk Session ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }


        /// <summary>
        /// Amount of messages already processed.
        /// </summary>
        /// <value>Amount of messages already processed.</value>
        [DataMember(Name="itemsProcessed", EmitDefaultValue=false)]
        public int? ItemsProcessed { get; set; }

        /// <summary>
        /// Total amount of messages to be processed.
        /// </summary>
        /// <value>Total amount of messages to be processed.</value>
        [DataMember(Name="itemsTotal", EmitDefaultValue=false)]
        public int? ItemsTotal { get; set; }

        /// <summary>
        /// Creation date and time of a Bulk Session.
        /// </summary>
        /// <value>Creation date and time of a Bulk Session.</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Session
        /// </summary>
        [DataMember(Name="session", EmitDefaultValue=false)]
        public MessageSession Session { get; set; }

        /// <summary>
        /// Message text of a Bulk Session.
        /// </summary>
        /// <value>Message text of a Bulk Session.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkSession {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ItemsProcessed: ").Append(ItemsProcessed).Append("\n");
            sb.Append("  ItemsTotal: ").Append(ItemsTotal).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Session: ").Append(Session).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(input as BulkSession);
        }

        /// <summary>
        /// Returns true if BulkSession instances are equal
        /// </summary>
        /// <param name="input">Instance of BulkSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkSession input)
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ItemsProcessed == input.ItemsProcessed ||
                    (this.ItemsProcessed != null &&
                    this.ItemsProcessed.Equals(input.ItemsProcessed))
                ) && 
                (
                    this.ItemsTotal == input.ItemsTotal ||
                    (this.ItemsTotal != null &&
                    this.ItemsTotal.Equals(input.ItemsTotal))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Session == input.Session ||
                    (this.Session != null &&
                    this.Session.Equals(input.Session))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ItemsProcessed != null)
                    hashCode = hashCode * 59 + this.ItemsProcessed.GetHashCode();
                if (this.ItemsTotal != null)
                    hashCode = hashCode * 59 + this.ItemsTotal.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Session != null)
                    hashCode = hashCode * 59 + this.Session.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
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
