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
    /// SendMessageInputObject
    /// </summary>
    [DataContract]
    public partial class SendMessageInputObject :  IEquatable<SendMessageInputObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendMessageInputObject" /> class.
        /// </summary>
        /// <param name="text">Message text. Required if the **template_id** is not set..</param>
        /// <param name="templateId">Template used instead of message text. Required if the **text** is not set..</param>
        /// <param name="sendingTime">DEPRECATED, consider using sendingDateTime and sendingTimezone parameters instead: Optional (required with rrule set). Message sending time in unix timestamp format. Default is now..</param>
        /// <param name="sendingDateTime">Sending time in Y-m-d H:i:s format (e.g. 2022-05-27 13:05:10). This time is relative to **sendingTimezone**. Note: for correct operation, the value of seconds must not be less than 10..</param>
        /// <param name="sendingTimezone">ID or ISO-name of timezone used for sending when sendingDateTime parameter is set. E.g. if you specify sendingDateTime &#x3D; \\\&quot;2016-05-27 13:02:33\\\&quot; and sendingTimezone &#x3D; \\\&quot;America/Buenos_Aires\\\&quot;, your message will be sent at May 27, 2016 13:02:33 Buenos Aires time, or 16:02:33 UTC. Default is account timezone..</param>
        /// <param name="contacts">Comma separated array of contact resources id message will be sent to..</param>
        /// <param name="lists">Comma separated array of list resources id message will be sent to..</param>
        /// <param name="phones">Comma separated array of E.164 phone numbers message will be sent to..</param>
        /// <param name="cutExtra">Should sending method cut extra characters which not fit supplied partsCount or return 400 Bad request response instead. (default to false).</param>
        /// <param name="partsCount">Maximum message parts count (Textmagic allows sending 1 to 6 message parts)..</param>
        /// <param name="referenceId">Custom message reference id which can be used in your application infrastructure..</param>
        /// <param name="from">One of allowed Sender ID (phone number or alphanumeric sender ID). If specified Sender ID is not allowed for some destinations, a fallback default Sender ID will be used to ensure delivery. See [Get timezones](https://docs.textmagic.com/#tag/Sender-IDs)..</param>
        /// <param name="rrule">iCal RRULE parameter to create recurrent scheduled messages. When used, sendingTime is mandatory as start point of sending. See https://www.textmagic.com/free-tools/rrule-generator for format details..</param>
        /// <param name="createChat">Should sending method try to create new Chat (if not exist) with specified recipients? (default to false).</param>
        /// <param name="tts">Send a Text-to-Speech message. (default to false).</param>
        /// <param name="local">Treat phone numbers passed in the \\&#39;phones\\&#39; field as local. (default to false).</param>
        /// <param name="localCountry">The 2-letter ISO country code for local phone numbers, used when \\&#39;local\\&#39; is set to true. Default is the account country..</param>
        /// <param name="destination">Messsage destination type allowed [mms, tts]..</param>
        /// <param name="resources">File name from mms attachment response (named as resource).</param>
        public SendMessageInputObject(string text = default(string), int? templateId = default(int?), int? sendingTime = default(int?), string sendingDateTime = default(string), string sendingTimezone = default(string), string contacts = default(string), string lists = default(string), string phones = default(string), bool? cutExtra = false, int? partsCount = default(int?), int? referenceId = default(int?), string from = default(string), string rrule = default(string), bool? createChat = false, bool? tts = false, bool? local = false, string localCountry = default(string), string destination = default(string), string resources = default(string))
        {
            this.Text = text;
            this.TemplateId = templateId;
            this.SendingTime = sendingTime;
            this.SendingDateTime = sendingDateTime;
            this.SendingTimezone = sendingTimezone;
            this.Contacts = contacts;
            this.Lists = lists;
            this.Phones = phones;
            // use default value if no "cutExtra" provided
            if (cutExtra == null)
            {
                this.CutExtra = false;
            }
            else
            {
                this.CutExtra = cutExtra;
            }
            this.PartsCount = partsCount;
            this.ReferenceId = referenceId;
            this.From = from;
            this.Rrule = rrule;
            // use default value if no "createChat" provided
            if (createChat == null)
            {
                this.CreateChat = false;
            }
            else
            {
                this.CreateChat = createChat;
            }
            // use default value if no "tts" provided
            if (tts == null)
            {
                this.Tts = false;
            }
            else
            {
                this.Tts = tts;
            }
            // use default value if no "local" provided
            if (local == null)
            {
                this.Local = false;
            }
            else
            {
                this.Local = local;
            }
            this.LocalCountry = localCountry;
            this.Destination = destination;
            this.Resources = resources;
        }
        
        /// <summary>
        /// Message text. Required if the **template_id** is not set.
        /// </summary>
        /// <value>Message text. Required if the **template_id** is not set.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Template used instead of message text. Required if the **text** is not set.
        /// </summary>
        /// <value>Template used instead of message text. Required if the **text** is not set.</value>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public int? TemplateId { get; set; }

        /// <summary>
        /// DEPRECATED, consider using sendingDateTime and sendingTimezone parameters instead: Optional (required with rrule set). Message sending time in unix timestamp format. Default is now.
        /// </summary>
        /// <value>DEPRECATED, consider using sendingDateTime and sendingTimezone parameters instead: Optional (required with rrule set). Message sending time in unix timestamp format. Default is now.</value>
        [DataMember(Name="sendingTime", EmitDefaultValue=false)]
        public int? SendingTime { get; set; }

        /// <summary>
        /// Sending time in Y-m-d H:i:s format (e.g. 2022-05-27 13:05:10). This time is relative to **sendingTimezone**. Note: for correct operation, the value of seconds must not be less than 10.
        /// </summary>
        /// <value>Sending time in Y-m-d H:i:s format (e.g. 2022-05-27 13:05:10). This time is relative to **sendingTimezone**. Note: for correct operation, the value of seconds must not be less than 10.</value>
        [DataMember(Name="sendingDateTime", EmitDefaultValue=false)]
        public string SendingDateTime { get; set; }

        /// <summary>
        /// ID or ISO-name of timezone used for sending when sendingDateTime parameter is set. E.g. if you specify sendingDateTime &#x3D; \\\&quot;2016-05-27 13:02:33\\\&quot; and sendingTimezone &#x3D; \\\&quot;America/Buenos_Aires\\\&quot;, your message will be sent at May 27, 2016 13:02:33 Buenos Aires time, or 16:02:33 UTC. Default is account timezone.
        /// </summary>
        /// <value>ID or ISO-name of timezone used for sending when sendingDateTime parameter is set. E.g. if you specify sendingDateTime &#x3D; \\\&quot;2016-05-27 13:02:33\\\&quot; and sendingTimezone &#x3D; \\\&quot;America/Buenos_Aires\\\&quot;, your message will be sent at May 27, 2016 13:02:33 Buenos Aires time, or 16:02:33 UTC. Default is account timezone.</value>
        [DataMember(Name="sendingTimezone", EmitDefaultValue=false)]
        public string SendingTimezone { get; set; }

        /// <summary>
        /// Comma separated array of contact resources id message will be sent to.
        /// </summary>
        /// <value>Comma separated array of contact resources id message will be sent to.</value>
        [DataMember(Name="contacts", EmitDefaultValue=false)]
        public string Contacts { get; set; }

        /// <summary>
        /// Comma separated array of list resources id message will be sent to.
        /// </summary>
        /// <value>Comma separated array of list resources id message will be sent to.</value>
        [DataMember(Name="lists", EmitDefaultValue=false)]
        public string Lists { get; set; }

        /// <summary>
        /// Comma separated array of E.164 phone numbers message will be sent to.
        /// </summary>
        /// <value>Comma separated array of E.164 phone numbers message will be sent to.</value>
        [DataMember(Name="phones", EmitDefaultValue=false)]
        public string Phones { get; set; }

        /// <summary>
        /// Should sending method cut extra characters which not fit supplied partsCount or return 400 Bad request response instead.
        /// </summary>
        /// <value>Should sending method cut extra characters which not fit supplied partsCount or return 400 Bad request response instead.</value>
        [DataMember(Name="cutExtra", EmitDefaultValue=false)]
        public bool? CutExtra { get; set; }

        /// <summary>
        /// Maximum message parts count (Textmagic allows sending 1 to 6 message parts).
        /// </summary>
        /// <value>Maximum message parts count (Textmagic allows sending 1 to 6 message parts).</value>
        [DataMember(Name="partsCount", EmitDefaultValue=false)]
        public int? PartsCount { get; set; }

        /// <summary>
        /// Custom message reference id which can be used in your application infrastructure.
        /// </summary>
        /// <value>Custom message reference id which can be used in your application infrastructure.</value>
        [DataMember(Name="referenceId", EmitDefaultValue=false)]
        public int? ReferenceId { get; set; }

        /// <summary>
        /// One of allowed Sender ID (phone number or alphanumeric sender ID). If specified Sender ID is not allowed for some destinations, a fallback default Sender ID will be used to ensure delivery. See [Get timezones](https://docs.textmagic.com/#tag/Sender-IDs).
        /// </summary>
        /// <value>One of allowed Sender ID (phone number or alphanumeric sender ID). If specified Sender ID is not allowed for some destinations, a fallback default Sender ID will be used to ensure delivery. See [Get timezones](https://docs.textmagic.com/#tag/Sender-IDs).</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// iCal RRULE parameter to create recurrent scheduled messages. When used, sendingTime is mandatory as start point of sending. See https://www.textmagic.com/free-tools/rrule-generator for format details.
        /// </summary>
        /// <value>iCal RRULE parameter to create recurrent scheduled messages. When used, sendingTime is mandatory as start point of sending. See https://www.textmagic.com/free-tools/rrule-generator for format details.</value>
        [DataMember(Name="rrule", EmitDefaultValue=false)]
        public string Rrule { get; set; }

        /// <summary>
        /// Should sending method try to create new Chat (if not exist) with specified recipients?
        /// </summary>
        /// <value>Should sending method try to create new Chat (if not exist) with specified recipients?</value>
        [DataMember(Name="createChat", EmitDefaultValue=false)]
        public bool? CreateChat { get; set; }

        /// <summary>
        /// Send a Text-to-Speech message.
        /// </summary>
        /// <value>Send a Text-to-Speech message.</value>
        [DataMember(Name="tts", EmitDefaultValue=false)]
        public bool? Tts { get; set; }

        /// <summary>
        /// Treat phone numbers passed in the \\&#39;phones\\&#39; field as local.
        /// </summary>
        /// <value>Treat phone numbers passed in the \\&#39;phones\\&#39; field as local.</value>
        [DataMember(Name="local", EmitDefaultValue=false)]
        public bool? Local { get; set; }

        /// <summary>
        /// The 2-letter ISO country code for local phone numbers, used when \\&#39;local\\&#39; is set to true. Default is the account country.
        /// </summary>
        /// <value>The 2-letter ISO country code for local phone numbers, used when \\&#39;local\\&#39; is set to true. Default is the account country.</value>
        [DataMember(Name="localCountry", EmitDefaultValue=false)]
        public string LocalCountry { get; set; }

        /// <summary>
        /// Messsage destination type allowed [mms, tts].
        /// </summary>
        /// <value>Messsage destination type allowed [mms, tts].</value>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public string Destination { get; set; }

        /// <summary>
        /// File name from mms attachment response (named as resource)
        /// </summary>
        /// <value>File name from mms attachment response (named as resource)</value>
        [DataMember(Name="resources", EmitDefaultValue=false)]
        public string Resources { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendMessageInputObject {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  SendingTime: ").Append(SendingTime).Append("\n");
            sb.Append("  SendingDateTime: ").Append(SendingDateTime).Append("\n");
            sb.Append("  SendingTimezone: ").Append(SendingTimezone).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  Lists: ").Append(Lists).Append("\n");
            sb.Append("  Phones: ").Append(Phones).Append("\n");
            sb.Append("  CutExtra: ").Append(CutExtra).Append("\n");
            sb.Append("  PartsCount: ").Append(PartsCount).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Rrule: ").Append(Rrule).Append("\n");
            sb.Append("  CreateChat: ").Append(CreateChat).Append("\n");
            sb.Append("  Tts: ").Append(Tts).Append("\n");
            sb.Append("  Local: ").Append(Local).Append("\n");
            sb.Append("  LocalCountry: ").Append(LocalCountry).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
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
            return this.Equals(input as SendMessageInputObject);
        }

        /// <summary>
        /// Returns true if SendMessageInputObject instances are equal
        /// </summary>
        /// <param name="input">Instance of SendMessageInputObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendMessageInputObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.SendingTime == input.SendingTime ||
                    (this.SendingTime != null &&
                    this.SendingTime.Equals(input.SendingTime))
                ) && 
                (
                    this.SendingDateTime == input.SendingDateTime ||
                    (this.SendingDateTime != null &&
                    this.SendingDateTime.Equals(input.SendingDateTime))
                ) && 
                (
                    this.SendingTimezone == input.SendingTimezone ||
                    (this.SendingTimezone != null &&
                    this.SendingTimezone.Equals(input.SendingTimezone))
                ) && 
                (
                    this.Contacts == input.Contacts ||
                    (this.Contacts != null &&
                    this.Contacts.Equals(input.Contacts))
                ) && 
                (
                    this.Lists == input.Lists ||
                    (this.Lists != null &&
                    this.Lists.Equals(input.Lists))
                ) && 
                (
                    this.Phones == input.Phones ||
                    (this.Phones != null &&
                    this.Phones.Equals(input.Phones))
                ) && 
                (
                    this.CutExtra == input.CutExtra ||
                    (this.CutExtra != null &&
                    this.CutExtra.Equals(input.CutExtra))
                ) && 
                (
                    this.PartsCount == input.PartsCount ||
                    (this.PartsCount != null &&
                    this.PartsCount.Equals(input.PartsCount))
                ) && 
                (
                    this.ReferenceId == input.ReferenceId ||
                    (this.ReferenceId != null &&
                    this.ReferenceId.Equals(input.ReferenceId))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Rrule == input.Rrule ||
                    (this.Rrule != null &&
                    this.Rrule.Equals(input.Rrule))
                ) && 
                (
                    this.CreateChat == input.CreateChat ||
                    (this.CreateChat != null &&
                    this.CreateChat.Equals(input.CreateChat))
                ) && 
                (
                    this.Tts == input.Tts ||
                    (this.Tts != null &&
                    this.Tts.Equals(input.Tts))
                ) && 
                (
                    this.Local == input.Local ||
                    (this.Local != null &&
                    this.Local.Equals(input.Local))
                ) && 
                (
                    this.LocalCountry == input.LocalCountry ||
                    (this.LocalCountry != null &&
                    this.LocalCountry.Equals(input.LocalCountry))
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.Resources == input.Resources ||
                    (this.Resources != null &&
                    this.Resources.Equals(input.Resources))
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
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.SendingTime != null)
                    hashCode = hashCode * 59 + this.SendingTime.GetHashCode();
                if (this.SendingDateTime != null)
                    hashCode = hashCode * 59 + this.SendingDateTime.GetHashCode();
                if (this.SendingTimezone != null)
                    hashCode = hashCode * 59 + this.SendingTimezone.GetHashCode();
                if (this.Contacts != null)
                    hashCode = hashCode * 59 + this.Contacts.GetHashCode();
                if (this.Lists != null)
                    hashCode = hashCode * 59 + this.Lists.GetHashCode();
                if (this.Phones != null)
                    hashCode = hashCode * 59 + this.Phones.GetHashCode();
                if (this.CutExtra != null)
                    hashCode = hashCode * 59 + this.CutExtra.GetHashCode();
                if (this.PartsCount != null)
                    hashCode = hashCode * 59 + this.PartsCount.GetHashCode();
                if (this.ReferenceId != null)
                    hashCode = hashCode * 59 + this.ReferenceId.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Rrule != null)
                    hashCode = hashCode * 59 + this.Rrule.GetHashCode();
                if (this.CreateChat != null)
                    hashCode = hashCode * 59 + this.CreateChat.GetHashCode();
                if (this.Tts != null)
                    hashCode = hashCode * 59 + this.Tts.GetHashCode();
                if (this.Local != null)
                    hashCode = hashCode * 59 + this.Local.GetHashCode();
                if (this.LocalCountry != null)
                    hashCode = hashCode * 59 + this.LocalCountry.GetHashCode();
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.Resources != null)
                    hashCode = hashCode * 59 + this.Resources.GetHashCode();
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
