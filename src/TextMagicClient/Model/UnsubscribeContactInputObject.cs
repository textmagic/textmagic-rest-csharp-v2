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
    /// UnsubscribeContactInputObject
    /// </summary>
    [DataContract]
    public partial class UnsubscribeContactInputObject :  IEquatable<UnsubscribeContactInputObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnsubscribeContactInputObject" /> class.
        /// </summary>
        /// <param name="phone">Contact phone number..</param>
        /// <param name="blockIncoming">If set to 1, incoming messages from this number will be blocked..</param>
        public UnsubscribeContactInputObject(string phone = default(string), int? blockIncoming = default(int?))
        {
            this.Phone = phone;
            this.BlockIncoming = blockIncoming;
        }
        
        /// <summary>
        /// Contact phone number.
        /// </summary>
        /// <value>Contact phone number.</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// If set to 1, incoming messages from this number will be blocked.
        /// </summary>
        /// <value>If set to 1, incoming messages from this number will be blocked.</value>
        [DataMember(Name="blockIncoming", EmitDefaultValue=false)]
        public int? BlockIncoming { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnsubscribeContactInputObject {\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  BlockIncoming: ").Append(BlockIncoming).Append("\n");
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
            return this.Equals(input as UnsubscribeContactInputObject);
        }

        /// <summary>
        /// Returns true if UnsubscribeContactInputObject instances are equal
        /// </summary>
        /// <param name="input">Instance of UnsubscribeContactInputObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnsubscribeContactInputObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.BlockIncoming == input.BlockIncoming ||
                    (this.BlockIncoming != null &&
                    this.BlockIncoming.Equals(input.BlockIncoming))
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
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.BlockIncoming != null)
                    hashCode = hashCode * 59 + this.BlockIncoming.GetHashCode();
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
