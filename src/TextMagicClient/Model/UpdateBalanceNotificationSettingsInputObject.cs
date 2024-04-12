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
    /// UpdateBalanceNotificationSettingsInputObject
    /// </summary>
    [DataContract]
    public partial class UpdateBalanceNotificationSettingsInputObject :  IEquatable<UpdateBalanceNotificationSettingsInputObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBalanceNotificationSettingsInputObject" /> class.
        /// </summary>
        /// <param name="lowBalanceNotification">Should user receive low balance notification..</param>
        /// <param name="alertBalance">If balance is below this value, user receive low balance notification..</param>
        /// <param name="alertPhone">Low balance notification phone number..</param>
        /// <param name="alertEmail1">Low balance notification email 1..</param>
        /// <param name="alertEmail2">Low balance notification email 2..</param>
        /// <param name="alertEmail3">Low balance notification email 3..</param>
        public UpdateBalanceNotificationSettingsInputObject(bool? lowBalanceNotification = default(bool?), string alertBalance = default(string), string alertPhone = default(string), string alertEmail1 = default(string), string alertEmail2 = default(string), string alertEmail3 = default(string))
        {
            this.LowBalanceNotification = lowBalanceNotification;
            this.AlertBalance = alertBalance;
            this.AlertPhone = alertPhone;
            this.AlertEmail1 = alertEmail1;
            this.AlertEmail2 = alertEmail2;
            this.AlertEmail3 = alertEmail3;
        }
        
        /// <summary>
        /// Should user receive low balance notification.
        /// </summary>
        /// <value>Should user receive low balance notification.</value>
        [DataMember(Name="lowBalanceNotification", EmitDefaultValue=false)]
        public bool? LowBalanceNotification { get; set; }

        /// <summary>
        /// If balance is below this value, user receive low balance notification.
        /// </summary>
        /// <value>If balance is below this value, user receive low balance notification.</value>
        [DataMember(Name="alertBalance", EmitDefaultValue=false)]
        public string AlertBalance { get; set; }

        /// <summary>
        /// Low balance notification phone number.
        /// </summary>
        /// <value>Low balance notification phone number.</value>
        [DataMember(Name="alertPhone", EmitDefaultValue=false)]
        public string AlertPhone { get; set; }

        /// <summary>
        /// Low balance notification email 1.
        /// </summary>
        /// <value>Low balance notification email 1.</value>
        [DataMember(Name="alertEmail1", EmitDefaultValue=false)]
        public string AlertEmail1 { get; set; }

        /// <summary>
        /// Low balance notification email 2.
        /// </summary>
        /// <value>Low balance notification email 2.</value>
        [DataMember(Name="alertEmail2", EmitDefaultValue=false)]
        public string AlertEmail2 { get; set; }

        /// <summary>
        /// Low balance notification email 3.
        /// </summary>
        /// <value>Low balance notification email 3.</value>
        [DataMember(Name="alertEmail3", EmitDefaultValue=false)]
        public string AlertEmail3 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateBalanceNotificationSettingsInputObject {\n");
            sb.Append("  LowBalanceNotification: ").Append(LowBalanceNotification).Append("\n");
            sb.Append("  AlertBalance: ").Append(AlertBalance).Append("\n");
            sb.Append("  AlertPhone: ").Append(AlertPhone).Append("\n");
            sb.Append("  AlertEmail1: ").Append(AlertEmail1).Append("\n");
            sb.Append("  AlertEmail2: ").Append(AlertEmail2).Append("\n");
            sb.Append("  AlertEmail3: ").Append(AlertEmail3).Append("\n");
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
            return this.Equals(input as UpdateBalanceNotificationSettingsInputObject);
        }

        /// <summary>
        /// Returns true if UpdateBalanceNotificationSettingsInputObject instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateBalanceNotificationSettingsInputObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateBalanceNotificationSettingsInputObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LowBalanceNotification == input.LowBalanceNotification ||
                    (this.LowBalanceNotification != null &&
                    this.LowBalanceNotification.Equals(input.LowBalanceNotification))
                ) && 
                (
                    this.AlertBalance == input.AlertBalance ||
                    (this.AlertBalance != null &&
                    this.AlertBalance.Equals(input.AlertBalance))
                ) && 
                (
                    this.AlertPhone == input.AlertPhone ||
                    (this.AlertPhone != null &&
                    this.AlertPhone.Equals(input.AlertPhone))
                ) && 
                (
                    this.AlertEmail1 == input.AlertEmail1 ||
                    (this.AlertEmail1 != null &&
                    this.AlertEmail1.Equals(input.AlertEmail1))
                ) && 
                (
                    this.AlertEmail2 == input.AlertEmail2 ||
                    (this.AlertEmail2 != null &&
                    this.AlertEmail2.Equals(input.AlertEmail2))
                ) && 
                (
                    this.AlertEmail3 == input.AlertEmail3 ||
                    (this.AlertEmail3 != null &&
                    this.AlertEmail3.Equals(input.AlertEmail3))
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
                if (this.LowBalanceNotification != null)
                    hashCode = hashCode * 59 + this.LowBalanceNotification.GetHashCode();
                if (this.AlertBalance != null)
                    hashCode = hashCode * 59 + this.AlertBalance.GetHashCode();
                if (this.AlertPhone != null)
                    hashCode = hashCode * 59 + this.AlertPhone.GetHashCode();
                if (this.AlertEmail1 != null)
                    hashCode = hashCode * 59 + this.AlertEmail1.GetHashCode();
                if (this.AlertEmail2 != null)
                    hashCode = hashCode * 59 + this.AlertEmail2.GetHashCode();
                if (this.AlertEmail3 != null)
                    hashCode = hashCode * 59 + this.AlertEmail3.GetHashCode();
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
