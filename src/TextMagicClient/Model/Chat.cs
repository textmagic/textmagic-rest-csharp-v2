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
    /// Chat
    /// </summary>
    [DataContract]
    public partial class Chat :  IEquatable<Chat>, IValidatableObject
    {
        /// <summary>
        /// Chat status:   * **a** - Active;   * **c** - Closed;   * **d** - Deleted. 
        /// </summary>
        /// <value>Chat status:   * **a** - Active;   * **c** - Closed;   * **d** - Deleted. </value>
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
        /// Chat status:   * **a** - Active;   * **c** - Closed;   * **d** - Deleted. 
        /// </summary>
        /// <value>Chat status:   * **a** - Active;   * **c** - Closed;   * **d** - Deleted. </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Last message type: * **ci** - incoming call; * **co** - outgoing call; * **i** - incoming message; * **o** - outgoing message. 
        /// </summary>
        /// <value>Last message type: * **ci** - incoming call; * **co** - outgoing call; * **i** - incoming message; * **o** - outgoing message. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionEnum
        {
            
            /// <summary>
            /// Enum Ci for value: ci
            /// </summary>
            [EnumMember(Value = "ci")]
            Ci = 1,
            
            /// <summary>
            /// Enum Co for value: co
            /// </summary>
            [EnumMember(Value = "co")]
            Co = 2,
            
            /// <summary>
            /// Enum I for value: i
            /// </summary>
            [EnumMember(Value = "i")]
            I = 3,
            
            /// <summary>
            /// Enum O for value: o
            /// </summary>
            [EnumMember(Value = "o")]
            O = 4
        }

        /// <summary>
        /// Last message type: * **ci** - incoming call; * **co** - outgoing call; * **i** - incoming message; * **o** - outgoing message. 
        /// </summary>
        /// <value>Last message type: * **ci** - incoming call; * **co** - outgoing call; * **i** - incoming message; * **o** - outgoing message. </value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum Direction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Chat" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Chat() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Chat" /> class.
        /// </summary>
        /// <param name="id">Chat ID. (required).</param>
        /// <param name="originalId">originalId (required).</param>
        /// <param name="phone">Chat partner&#39;s phone number. (required).</param>
        /// <param name="contact">contact (required).</param>
        /// <param name="unsubscribedContactId">If this field has a value, it means that the chat phone number has been unsubscribed from you and this value is an ID of an Unsubscribed contact entity. See [Get all unsubscribed contacts](https://docs.textmagic.com/#operation/getUnsubscribers). (required).</param>
        /// <param name="unread">Total unread incoming messages. (required).</param>
        /// <param name="updatedAt">Time when the last incoming message arrived at this chat. (required).</param>
        /// <param name="status">Chat status:   * **a** - Active;   * **c** - Closed;   * **d** - Deleted.  (required).</param>
        /// <param name="mute">Indicates when the chat is muted. (required).</param>
        /// <param name="lastMessage">The last message content of a chat. (required).</param>
        /// <param name="direction">Last message type: * **ci** - incoming call; * **co** - outgoing call; * **i** - incoming message; * **o** - outgoing message.  (required).</param>
        /// <param name="replyOptionsType">Used for chats prices. (required).</param>
        /// <param name="from">If filled, the value will be used as a sender number for all outgoing messages of a chat. (required).</param>
        /// <param name="mutedUntil">Date and time until the chat will be muted. (required).</param>
        /// <param name="timeLeftMute">Time left untill the chat will be unmuted (seconds). (required).</param>
        /// <param name="country">country (required).</param>
        /// <param name="pinned">Indicates when the chat is pinned. (required).</param>
        public Chat(int? id = default(int?), int? originalId = default(int?), string phone = default(string), Contact contact = default(Contact), int? unsubscribedContactId = default(int?), int? unread = default(int?), DateTime? updatedAt = default(DateTime?), StatusEnum status = default(StatusEnum), int? mute = default(int?), string lastMessage = default(string), DirectionEnum direction = default(DirectionEnum), string replyOptionsType = default(string), string from = default(string), DateTime? mutedUntil = default(DateTime?), int? timeLeftMute = default(int?), Country country = default(Country), bool? pinned = default(bool?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Chat and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "originalId" is required (not null)
            if (originalId == null)
            {
                throw new InvalidDataException("originalId is a required property for Chat and cannot be null");
            }
            else
            {
                this.OriginalId = originalId;
            }
            // to ensure "phone" is required (not null)
            if (phone == null)
            {
                throw new InvalidDataException("phone is a required property for Chat and cannot be null");
            }
            else
            {
                this.Phone = phone;
            }
            // to ensure "contact" is required (not null)
            if (contact == null)
            {
                throw new InvalidDataException("contact is a required property for Chat and cannot be null");
            }
            else
            {
                this.Contact = contact;
            }
            // to ensure "unsubscribedContactId" is required (not null)
            if (unsubscribedContactId == null)
            {
                throw new InvalidDataException("unsubscribedContactId is a required property for Chat and cannot be null");
            }
            else
            {
                this.UnsubscribedContactId = unsubscribedContactId;
            }
            // to ensure "unread" is required (not null)
            if (unread == null)
            {
                throw new InvalidDataException("unread is a required property for Chat and cannot be null");
            }
            else
            {
                this.Unread = unread;
            }
            // to ensure "updatedAt" is required (not null)
            if (updatedAt == null)
            {
                throw new InvalidDataException("updatedAt is a required property for Chat and cannot be null");
            }
            else
            {
                this.UpdatedAt = updatedAt;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for Chat and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "mute" is required (not null)
            if (mute == null)
            {
                throw new InvalidDataException("mute is a required property for Chat and cannot be null");
            }
            else
            {
                this.Mute = mute;
            }
            // to ensure "lastMessage" is required (not null)
            if (lastMessage == null)
            {
                throw new InvalidDataException("lastMessage is a required property for Chat and cannot be null");
            }
            else
            {
                this.LastMessage = lastMessage;
            }
            // to ensure "direction" is required (not null)
            if (direction == null)
            {
                throw new InvalidDataException("direction is a required property for Chat and cannot be null");
            }
            else
            {
                this.Direction = direction;
            }
            // to ensure "replyOptionsType" is required (not null)
            if (replyOptionsType == null)
            {
                throw new InvalidDataException("replyOptionsType is a required property for Chat and cannot be null");
            }
            else
            {
                this.ReplyOptionsType = replyOptionsType;
            }
            // to ensure "from" is required (not null)
            if (from == null)
            {
                throw new InvalidDataException("from is a required property for Chat and cannot be null");
            }
            else
            {
                this.From = from;
            }
            // to ensure "mutedUntil" is required (not null)
            if (mutedUntil == null)
            {
                throw new InvalidDataException("mutedUntil is a required property for Chat and cannot be null");
            }
            else
            {
                this.MutedUntil = mutedUntil;
            }
            // to ensure "timeLeftMute" is required (not null)
            if (timeLeftMute == null)
            {
                throw new InvalidDataException("timeLeftMute is a required property for Chat and cannot be null");
            }
            else
            {
                this.TimeLeftMute = timeLeftMute;
            }
            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new InvalidDataException("country is a required property for Chat and cannot be null");
            }
            else
            {
                this.Country = country;
            }
            // to ensure "pinned" is required (not null)
            if (pinned == null)
            {
                throw new InvalidDataException("pinned is a required property for Chat and cannot be null");
            }
            else
            {
                this.Pinned = pinned;
            }
        }
        
        /// <summary>
        /// Chat ID.
        /// </summary>
        /// <value>Chat ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets OriginalId
        /// </summary>
        [DataMember(Name="originalId", EmitDefaultValue=false)]
        public int? OriginalId { get; set; }

        /// <summary>
        /// Chat partner&#39;s phone number.
        /// </summary>
        /// <value>Chat partner&#39;s phone number.</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public Contact Contact { get; set; }

        /// <summary>
        /// If this field has a value, it means that the chat phone number has been unsubscribed from you and this value is an ID of an Unsubscribed contact entity. See [Get all unsubscribed contacts](https://docs.textmagic.com/#operation/getUnsubscribers).
        /// </summary>
        /// <value>If this field has a value, it means that the chat phone number has been unsubscribed from you and this value is an ID of an Unsubscribed contact entity. See [Get all unsubscribed contacts](https://docs.textmagic.com/#operation/getUnsubscribers).</value>
        [DataMember(Name="unsubscribedContactId", EmitDefaultValue=false)]
        public int? UnsubscribedContactId { get; set; }

        /// <summary>
        /// Total unread incoming messages.
        /// </summary>
        /// <value>Total unread incoming messages.</value>
        [DataMember(Name="unread", EmitDefaultValue=false)]
        public int? Unread { get; set; }

        /// <summary>
        /// Time when the last incoming message arrived at this chat.
        /// </summary>
        /// <value>Time when the last incoming message arrived at this chat.</value>
        [DataMember(Name="updatedAt", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }


        /// <summary>
        /// Indicates when the chat is muted.
        /// </summary>
        /// <value>Indicates when the chat is muted.</value>
        [DataMember(Name="mute", EmitDefaultValue=false)]
        public int? Mute { get; set; }

        /// <summary>
        /// The last message content of a chat.
        /// </summary>
        /// <value>The last message content of a chat.</value>
        [DataMember(Name="lastMessage", EmitDefaultValue=false)]
        public string LastMessage { get; set; }


        /// <summary>
        /// Used for chats prices.
        /// </summary>
        /// <value>Used for chats prices.</value>
        [DataMember(Name="replyOptionsType", EmitDefaultValue=false)]
        public string ReplyOptionsType { get; set; }

        /// <summary>
        /// If filled, the value will be used as a sender number for all outgoing messages of a chat.
        /// </summary>
        /// <value>If filled, the value will be used as a sender number for all outgoing messages of a chat.</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// Date and time until the chat will be muted.
        /// </summary>
        /// <value>Date and time until the chat will be muted.</value>
        [DataMember(Name="mutedUntil", EmitDefaultValue=false)]
        public DateTime? MutedUntil { get; set; }

        /// <summary>
        /// Time left untill the chat will be unmuted (seconds).
        /// </summary>
        /// <value>Time left untill the chat will be unmuted (seconds).</value>
        [DataMember(Name="timeLeftMute", EmitDefaultValue=false)]
        public int? TimeLeftMute { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public Country Country { get; set; }

        /// <summary>
        /// Indicates when the chat is pinned.
        /// </summary>
        /// <value>Indicates when the chat is pinned.</value>
        [DataMember(Name="pinned", EmitDefaultValue=false)]
        public bool? Pinned { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Chat {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OriginalId: ").Append(OriginalId).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  UnsubscribedContactId: ").Append(UnsubscribedContactId).Append("\n");
            sb.Append("  Unread: ").Append(Unread).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Mute: ").Append(Mute).Append("\n");
            sb.Append("  LastMessage: ").Append(LastMessage).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  ReplyOptionsType: ").Append(ReplyOptionsType).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  MutedUntil: ").Append(MutedUntil).Append("\n");
            sb.Append("  TimeLeftMute: ").Append(TimeLeftMute).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Pinned: ").Append(Pinned).Append("\n");
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
            return this.Equals(input as Chat);
        }

        /// <summary>
        /// Returns true if Chat instances are equal
        /// </summary>
        /// <param name="input">Instance of Chat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Chat input)
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
                    this.OriginalId == input.OriginalId ||
                    (this.OriginalId != null &&
                    this.OriginalId.Equals(input.OriginalId))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.UnsubscribedContactId == input.UnsubscribedContactId ||
                    (this.UnsubscribedContactId != null &&
                    this.UnsubscribedContactId.Equals(input.UnsubscribedContactId))
                ) && 
                (
                    this.Unread == input.Unread ||
                    (this.Unread != null &&
                    this.Unread.Equals(input.Unread))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Mute == input.Mute ||
                    (this.Mute != null &&
                    this.Mute.Equals(input.Mute))
                ) && 
                (
                    this.LastMessage == input.LastMessage ||
                    (this.LastMessage != null &&
                    this.LastMessage.Equals(input.LastMessage))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.ReplyOptionsType == input.ReplyOptionsType ||
                    (this.ReplyOptionsType != null &&
                    this.ReplyOptionsType.Equals(input.ReplyOptionsType))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.MutedUntil == input.MutedUntil ||
                    (this.MutedUntil != null &&
                    this.MutedUntil.Equals(input.MutedUntil))
                ) && 
                (
                    this.TimeLeftMute == input.TimeLeftMute ||
                    (this.TimeLeftMute != null &&
                    this.TimeLeftMute.Equals(input.TimeLeftMute))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Pinned == input.Pinned ||
                    (this.Pinned != null &&
                    this.Pinned.Equals(input.Pinned))
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
                if (this.OriginalId != null)
                    hashCode = hashCode * 59 + this.OriginalId.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.UnsubscribedContactId != null)
                    hashCode = hashCode * 59 + this.UnsubscribedContactId.GetHashCode();
                if (this.Unread != null)
                    hashCode = hashCode * 59 + this.Unread.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Mute != null)
                    hashCode = hashCode * 59 + this.Mute.GetHashCode();
                if (this.LastMessage != null)
                    hashCode = hashCode * 59 + this.LastMessage.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.ReplyOptionsType != null)
                    hashCode = hashCode * 59 + this.ReplyOptionsType.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.MutedUntil != null)
                    hashCode = hashCode * 59 + this.MutedUntil.GetHashCode();
                if (this.TimeLeftMute != null)
                    hashCode = hashCode * 59 + this.TimeLeftMute.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Pinned != null)
                    hashCode = hashCode * 59 + this.Pinned.GetHashCode();
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
