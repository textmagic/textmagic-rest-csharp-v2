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
    /// UpdateChatDesktopNotificationSettingsInputObject
    /// </summary>
    [DataContract]
    public partial class UpdateChatDesktopNotificationSettingsInputObject :  IEquatable<UpdateChatDesktopNotificationSettingsInputObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChatDesktopNotificationSettingsInputObject" /> class.
        /// </summary>
        /// <param name="playSound">Enable notification sound?.</param>
        /// <param name="showNotifications">Show desktop notifications about new messages..</param>
        /// <param name="showText">Incoming message text will be displayed in desktop notifications..</param>
        /// <param name="soundId">Sound Id of a notification..</param>
        public UpdateChatDesktopNotificationSettingsInputObject(bool? playSound = default(bool?), bool? showNotifications = default(bool?), bool? showText = default(bool?), int? soundId = default(int?))
        {
            this.PlaySound = playSound;
            this.ShowNotifications = showNotifications;
            this.ShowText = showText;
            this.SoundId = soundId;
        }
        
        /// <summary>
        /// Enable notification sound?
        /// </summary>
        /// <value>Enable notification sound?</value>
        [DataMember(Name="playSound", EmitDefaultValue=false)]
        public bool? PlaySound { get; set; }

        /// <summary>
        /// Show desktop notifications about new messages.
        /// </summary>
        /// <value>Show desktop notifications about new messages.</value>
        [DataMember(Name="showNotifications", EmitDefaultValue=false)]
        public bool? ShowNotifications { get; set; }

        /// <summary>
        /// Incoming message text will be displayed in desktop notifications.
        /// </summary>
        /// <value>Incoming message text will be displayed in desktop notifications.</value>
        [DataMember(Name="showText", EmitDefaultValue=false)]
        public bool? ShowText { get; set; }

        /// <summary>
        /// Sound Id of a notification.
        /// </summary>
        /// <value>Sound Id of a notification.</value>
        [DataMember(Name="soundId", EmitDefaultValue=false)]
        public int? SoundId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateChatDesktopNotificationSettingsInputObject {\n");
            sb.Append("  PlaySound: ").Append(PlaySound).Append("\n");
            sb.Append("  ShowNotifications: ").Append(ShowNotifications).Append("\n");
            sb.Append("  ShowText: ").Append(ShowText).Append("\n");
            sb.Append("  SoundId: ").Append(SoundId).Append("\n");
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
            return this.Equals(input as UpdateChatDesktopNotificationSettingsInputObject);
        }

        /// <summary>
        /// Returns true if UpdateChatDesktopNotificationSettingsInputObject instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateChatDesktopNotificationSettingsInputObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateChatDesktopNotificationSettingsInputObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PlaySound == input.PlaySound ||
                    (this.PlaySound != null &&
                    this.PlaySound.Equals(input.PlaySound))
                ) && 
                (
                    this.ShowNotifications == input.ShowNotifications ||
                    (this.ShowNotifications != null &&
                    this.ShowNotifications.Equals(input.ShowNotifications))
                ) && 
                (
                    this.ShowText == input.ShowText ||
                    (this.ShowText != null &&
                    this.ShowText.Equals(input.ShowText))
                ) && 
                (
                    this.SoundId == input.SoundId ||
                    (this.SoundId != null &&
                    this.SoundId.Equals(input.SoundId))
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
                if (this.PlaySound != null)
                    hashCode = hashCode * 59 + this.PlaySound.GetHashCode();
                if (this.ShowNotifications != null)
                    hashCode = hashCode * 59 + this.ShowNotifications.GetHashCode();
                if (this.ShowText != null)
                    hashCode = hashCode * 59 + this.ShowText.GetHashCode();
                if (this.SoundId != null)
                    hashCode = hashCode * 59 + this.SoundId.GetHashCode();
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
