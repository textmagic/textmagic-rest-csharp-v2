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
    /// GetSenderSettingsResponse
    /// </summary>
    [DataContract]
    public partial class GetSenderSettingsResponse :  IEquatable<GetSenderSettingsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSenderSettingsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetSenderSettingsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSenderSettingsResponse" /> class.
        /// </summary>
        /// <param name="user">user (required).</param>
        /// <param name="special">special (required).</param>
        /// <param name="other">other (required).</param>
        public GetSenderSettingsResponse(List<SenderSettingsItem> user = default(List<SenderSettingsItem>), List<SenderSettingsItem> special = default(List<SenderSettingsItem>), List<SenderSettingsItem> other = default(List<SenderSettingsItem>))
        {
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new InvalidDataException("user is a required property for GetSenderSettingsResponse and cannot be null");
            }
            else
            {
                this.User = user;
            }
            // to ensure "special" is required (not null)
            if (special == null)
            {
                throw new InvalidDataException("special is a required property for GetSenderSettingsResponse and cannot be null");
            }
            else
            {
                this.Special = special;
            }
            // to ensure "other" is required (not null)
            if (other == null)
            {
                throw new InvalidDataException("other is a required property for GetSenderSettingsResponse and cannot be null");
            }
            else
            {
                this.Other = other;
            }
        }
        
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public List<SenderSettingsItem> User { get; set; }

        /// <summary>
        /// Gets or Sets Special
        /// </summary>
        [DataMember(Name="special", EmitDefaultValue=false)]
        public List<SenderSettingsItem> Special { get; set; }

        /// <summary>
        /// Gets or Sets Other
        /// </summary>
        [DataMember(Name="other", EmitDefaultValue=false)]
        public List<SenderSettingsItem> Other { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetSenderSettingsResponse {\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Special: ").Append(Special).Append("\n");
            sb.Append("  Other: ").Append(Other).Append("\n");
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
            return this.Equals(input as GetSenderSettingsResponse);
        }

        /// <summary>
        /// Returns true if GetSenderSettingsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSenderSettingsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSenderSettingsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.User == input.User ||
                    this.User != null &&
                    this.User.SequenceEqual(input.User)
                ) && 
                (
                    this.Special == input.Special ||
                    this.Special != null &&
                    this.Special.SequenceEqual(input.Special)
                ) && 
                (
                    this.Other == input.Other ||
                    this.Other != null &&
                    this.Other.SequenceEqual(input.Other)
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
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Special != null)
                    hashCode = hashCode * 59 + this.Special.GetHashCode();
                if (this.Other != null)
                    hashCode = hashCode * 59 + this.Other.GetHashCode();
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
