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
    /// Conversation
    /// </summary>
    [DataContract]
    public partial class Conversation :  IEquatable<Conversation>, IValidatableObject
    {
        /// <summary>
        /// Message type: inbound or outbound. 
        /// </summary>
        /// <value>Message type: inbound or outbound. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionEnum
        {
            
            /// <summary>
            /// Enum In for value: in
            /// </summary>
            [EnumMember(Value = "in")]
            In = 1,
            
            /// <summary>
            /// Enum Out for value: out
            /// </summary>
            [EnumMember(Value = "out")]
            Out = 2,
            
            /// <summary>
            /// Enum O for value: o
            /// </summary>
            [EnumMember(Value = "o")]
            O = 3,
            
            /// <summary>
            /// Enum I for value: i
            /// </summary>
            [EnumMember(Value = "i")]
            I = 4
        }

        /// <summary>
        /// Message type: inbound or outbound. 
        /// </summary>
        /// <value>Message type: inbound or outbound. </value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum Direction { get; set; }
        /// <summary>
        /// Message type.
        /// </summary>
        /// <value>Message type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Text for value: text
            /// </summary>
            [EnumMember(Value = "text")]
            Text = 1,
            
            /// <summary>
            /// Enum Image for value: image
            /// </summary>
            [EnumMember(Value = "image")]
            Image = 2,
            
            /// <summary>
            /// Enum Audio for value: audio
            /// </summary>
            [EnumMember(Value = "audio")]
            Audio = 3,
            
            /// <summary>
            /// Enum Voice for value: voice
            /// </summary>
            [EnumMember(Value = "voice")]
            Voice = 4,
            
            /// <summary>
            /// Enum Document for value: document
            /// </summary>
            [EnumMember(Value = "document")]
            Document = 5,
            
            /// <summary>
            /// Enum Video for value: video
            /// </summary>
            [EnumMember(Value = "video")]
            Video = 6,
            
            /// <summary>
            /// Enum Log for value: log
            /// </summary>
            [EnumMember(Value = "log")]
            Log = 7,
            
            /// <summary>
            /// Enum Initial for value: initial
            /// </summary>
            [EnumMember(Value = "initial")]
            Initial = 8,
            
            /// <summary>
            /// Enum Note for value: note
            /// </summary>
            [EnumMember(Value = "note")]
            Note = 9
        }

        /// <summary>
        /// Message type.
        /// </summary>
        /// <value>Message type.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Chat type.
        /// </summary>
        /// <value>Chat type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChatTypeEnum
        {
            
            /// <summary>
            /// Enum Sms for value: sms
            /// </summary>
            [EnumMember(Value = "sms")]
            Sms = 1,
            
            /// <summary>
            /// Enum Facebookmessenger for value: facebook_messenger
            /// </summary>
            [EnumMember(Value = "facebook_messenger")]
            Facebookmessenger = 2,
            
            /// <summary>
            /// Enum Instagram for value: instagram
            /// </summary>
            [EnumMember(Value = "instagram")]
            Instagram = 3,
            
            /// <summary>
            /// Enum Whatsappbusiness for value: whatsapp_business
            /// </summary>
            [EnumMember(Value = "whatsapp_business")]
            Whatsappbusiness = 4,
            
            /// <summary>
            /// Enum Livechat for value: live_chat
            /// </summary>
            [EnumMember(Value = "live_chat")]
            Livechat = 5
        }

        /// <summary>
        /// Chat type.
        /// </summary>
        /// <value>Chat type.</value>
        [DataMember(Name="chatType", EmitDefaultValue=false)]
        public ChatTypeEnum? ChatType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Conversation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Conversation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Conversation" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="direction">Message type: inbound or outbound.  (required).</param>
        /// <param name="sender">Sender phone number. (required).</param>
        /// <param name="messageTime">Time when  the message arrived at Textmagic. (required).</param>
        /// <param name="text">Message text. (required).</param>
        /// <param name="receiver">Receiver&#39;s phone number. (required).</param>
        /// <param name="status">Message status (for chats outbound only). See [message delivery statuses](https://docs.textmagic.com/#section/Delivery-status-codes) for details. (required).</param>
        /// <param name="firstName">Contact first name. (required).</param>
        /// <param name="lastName">Contact last name. (required).</param>
        /// <param name="sessionId">Session ID of a message. See [message sessions](https://docs.textmagic.com/#tag/Outbound-Message-Sessions) for details. (required).</param>
        /// <param name="initiatorId">Initiator ID of a message. See [message sessions](https://docs.textmagic.com/#tag/Outbound-Message-Sessions) for details..</param>
        /// <param name="messageFileId">Message file id..</param>
        /// <param name="type">Message type..</param>
        /// <param name="chatType">Chat type..</param>
        /// <param name="chatId">Chat id..</param>
        /// <param name="isEdited">isEdited.</param>
        /// <param name="errorCode">Error code..</param>
        /// <param name="files">files.</param>
        /// <param name="payload">payload.</param>
        /// <param name="avatar">avatar.</param>
        public Conversation(int? id = default(int?), DirectionEnum direction = default(DirectionEnum), string sender = default(string), DateTime? messageTime = default(DateTime?), string text = default(string), string receiver = default(string), string status = default(string), string firstName = default(string), string lastName = default(string), int? sessionId = default(int?), int? initiatorId = default(int?), int? messageFileId = default(int?), TypeEnum? type = default(TypeEnum?), ChatTypeEnum? chatType = default(ChatTypeEnum?), int? chatId = default(int?), bool? isEdited = default(bool?), string errorCode = default(string), List<System.IO.Stream> files = default(List<System.IO.Stream>), MessagePayload payload = default(MessagePayload), string avatar = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Conversation and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "direction" is required (not null)
            if (direction == null)
            {
                throw new InvalidDataException("direction is a required property for Conversation and cannot be null");
            }
            else
            {
                this.Direction = direction;
            }
            // to ensure "sender" is required (not null)
            if (sender == null)
            {
                throw new InvalidDataException("sender is a required property for Conversation and cannot be null");
            }
            else
            {
                this.Sender = sender;
            }
            // to ensure "messageTime" is required (not null)
            if (messageTime == null)
            {
                throw new InvalidDataException("messageTime is a required property for Conversation and cannot be null");
            }
            else
            {
                this.MessageTime = messageTime;
            }
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new InvalidDataException("text is a required property for Conversation and cannot be null");
            }
            else
            {
                this.Text = text;
            }
            // to ensure "receiver" is required (not null)
            if (receiver == null)
            {
                throw new InvalidDataException("receiver is a required property for Conversation and cannot be null");
            }
            else
            {
                this.Receiver = receiver;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for Conversation and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new InvalidDataException("firstName is a required property for Conversation and cannot be null");
            }
            else
            {
                this.FirstName = firstName;
            }
            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new InvalidDataException("lastName is a required property for Conversation and cannot be null");
            }
            else
            {
                this.LastName = lastName;
            }
            // to ensure "sessionId" is required (not null)
            if (sessionId == null)
            {
                throw new InvalidDataException("sessionId is a required property for Conversation and cannot be null");
            }
            else
            {
                this.SessionId = sessionId;
            }
            this.InitiatorId = initiatorId;
            this.MessageFileId = messageFileId;
            this.Type = type;
            this.ChatType = chatType;
            this.ChatId = chatId;
            this.IsEdited = isEdited;
            this.ErrorCode = errorCode;
            this.Files = files;
            this.Payload = payload;
            this.Avatar = avatar;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }


        /// <summary>
        /// Sender phone number.
        /// </summary>
        /// <value>Sender phone number.</value>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public string Sender { get; set; }

        /// <summary>
        /// Time when  the message arrived at Textmagic.
        /// </summary>
        /// <value>Time when  the message arrived at Textmagic.</value>
        [DataMember(Name="messageTime", EmitDefaultValue=false)]
        public DateTime? MessageTime { get; set; }

        /// <summary>
        /// Message text.
        /// </summary>
        /// <value>Message text.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Receiver&#39;s phone number.
        /// </summary>
        /// <value>Receiver&#39;s phone number.</value>
        [DataMember(Name="receiver", EmitDefaultValue=false)]
        public string Receiver { get; set; }

        /// <summary>
        /// Message status (for chats outbound only). See [message delivery statuses](https://docs.textmagic.com/#section/Delivery-status-codes) for details.
        /// </summary>
        /// <value>Message status (for chats outbound only). See [message delivery statuses](https://docs.textmagic.com/#section/Delivery-status-codes) for details.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Contact first name.
        /// </summary>
        /// <value>Contact first name.</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Contact last name.
        /// </summary>
        /// <value>Contact last name.</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Session ID of a message. See [message sessions](https://docs.textmagic.com/#tag/Outbound-Message-Sessions) for details.
        /// </summary>
        /// <value>Session ID of a message. See [message sessions](https://docs.textmagic.com/#tag/Outbound-Message-Sessions) for details.</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public int? SessionId { get; set; }

        /// <summary>
        /// Initiator ID of a message. See [message sessions](https://docs.textmagic.com/#tag/Outbound-Message-Sessions) for details.
        /// </summary>
        /// <value>Initiator ID of a message. See [message sessions](https://docs.textmagic.com/#tag/Outbound-Message-Sessions) for details.</value>
        [DataMember(Name="initiatorId", EmitDefaultValue=false)]
        public int? InitiatorId { get; set; }

        /// <summary>
        /// Message file id.
        /// </summary>
        /// <value>Message file id.</value>
        [DataMember(Name="messageFileId", EmitDefaultValue=false)]
        public int? MessageFileId { get; set; }



        /// <summary>
        /// Chat id.
        /// </summary>
        /// <value>Chat id.</value>
        [DataMember(Name="chatId", EmitDefaultValue=false)]
        public int? ChatId { get; set; }

        /// <summary>
        /// Gets or Sets IsEdited
        /// </summary>
        [DataMember(Name="isEdited", EmitDefaultValue=false)]
        public bool? IsEdited { get; set; }

        /// <summary>
        /// Error code.
        /// </summary>
        /// <value>Error code.</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or Sets Files
        /// </summary>
        [DataMember(Name="files", EmitDefaultValue=false)]
        public List<System.IO.Stream> Files { get; set; }

        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name="payload", EmitDefaultValue=false)]
        public MessagePayload Payload { get; set; }

        /// <summary>
        /// Gets or Sets Avatar
        /// </summary>
        [DataMember(Name="avatar", EmitDefaultValue=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Conversation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  MessageTime: ").Append(MessageTime).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Receiver: ").Append(Receiver).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  InitiatorId: ").Append(InitiatorId).Append("\n");
            sb.Append("  MessageFileId: ").Append(MessageFileId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ChatType: ").Append(ChatType).Append("\n");
            sb.Append("  ChatId: ").Append(ChatId).Append("\n");
            sb.Append("  IsEdited: ").Append(IsEdited).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
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
            return this.Equals(input as Conversation);
        }

        /// <summary>
        /// Returns true if Conversation instances are equal
        /// </summary>
        /// <param name="input">Instance of Conversation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Conversation input)
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
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.MessageTime == input.MessageTime ||
                    (this.MessageTime != null &&
                    this.MessageTime.Equals(input.MessageTime))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Receiver == input.Receiver ||
                    (this.Receiver != null &&
                    this.Receiver.Equals(input.Receiver))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
                ) && 
                (
                    this.InitiatorId == input.InitiatorId ||
                    (this.InitiatorId != null &&
                    this.InitiatorId.Equals(input.InitiatorId))
                ) && 
                (
                    this.MessageFileId == input.MessageFileId ||
                    (this.MessageFileId != null &&
                    this.MessageFileId.Equals(input.MessageFileId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ChatType == input.ChatType ||
                    (this.ChatType != null &&
                    this.ChatType.Equals(input.ChatType))
                ) && 
                (
                    this.ChatId == input.ChatId ||
                    (this.ChatId != null &&
                    this.ChatId.Equals(input.ChatId))
                ) && 
                (
                    this.IsEdited == input.IsEdited ||
                    (this.IsEdited != null &&
                    this.IsEdited.Equals(input.IsEdited))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.Files == input.Files ||
                    this.Files != null &&
                    this.Files.SequenceEqual(input.Files)
                ) && 
                (
                    this.Payload == input.Payload ||
                    (this.Payload != null &&
                    this.Payload.Equals(input.Payload))
                ) && 
                (
                    this.Avatar == input.Avatar ||
                    (this.Avatar != null &&
                    this.Avatar.Equals(input.Avatar))
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
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.MessageTime != null)
                    hashCode = hashCode * 59 + this.MessageTime.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Receiver != null)
                    hashCode = hashCode * 59 + this.Receiver.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.SessionId != null)
                    hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.InitiatorId != null)
                    hashCode = hashCode * 59 + this.InitiatorId.GetHashCode();
                if (this.MessageFileId != null)
                    hashCode = hashCode * 59 + this.MessageFileId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ChatType != null)
                    hashCode = hashCode * 59 + this.ChatType.GetHashCode();
                if (this.ChatId != null)
                    hashCode = hashCode * 59 + this.ChatId.GetHashCode();
                if (this.IsEdited != null)
                    hashCode = hashCode * 59 + this.IsEdited.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.Files != null)
                    hashCode = hashCode * 59 + this.Files.GetHashCode();
                if (this.Payload != null)
                    hashCode = hashCode * 59 + this.Payload.GetHashCode();
                if (this.Avatar != null)
                    hashCode = hashCode * 59 + this.Avatar.GetHashCode();
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
