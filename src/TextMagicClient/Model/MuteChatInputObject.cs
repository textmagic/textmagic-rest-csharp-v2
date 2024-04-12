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
    /// MuteChatInputObject
    /// </summary>
    [DataContract]
    public partial class MuteChatInputObject :  IEquatable<MuteChatInputObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MuteChatInputObject" /> class.
        /// </summary>
        /// <param name="id">Chat ID..</param>
        /// <param name="mute">Mute notifications sound..</param>
        /// <param name="_for">Mute for N hours..</param>
        public MuteChatInputObject(int? id = default(int?), bool? mute = default(bool?), int? _for = default(int?))
        {
            this.Id = id;
            this.Mute = mute;
            this.For = _for;
        }
        
        /// <summary>
        /// Chat ID.
        /// </summary>
        /// <value>Chat ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Mute notifications sound.
        /// </summary>
        /// <value>Mute notifications sound.</value>
        [DataMember(Name="mute", EmitDefaultValue=false)]
        public bool? Mute { get; set; }

        /// <summary>
        /// Mute for N hours.
        /// </summary>
        /// <value>Mute for N hours.</value>
        [DataMember(Name="for", EmitDefaultValue=false)]
        public int? For { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MuteChatInputObject {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Mute: ").Append(Mute).Append("\n");
            sb.Append("  For: ").Append(For).Append("\n");
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
            return this.Equals(input as MuteChatInputObject);
        }

        /// <summary>
        /// Returns true if MuteChatInputObject instances are equal
        /// </summary>
        /// <param name="input">Instance of MuteChatInputObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MuteChatInputObject input)
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
                    this.Mute == input.Mute ||
                    (this.Mute != null &&
                    this.Mute.Equals(input.Mute))
                ) && 
                (
                    this.For == input.For ||
                    (this.For != null &&
                    this.For.Equals(input.For))
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
                if (this.Mute != null)
                    hashCode = hashCode * 59 + this.Mute.GetHashCode();
                if (this.For != null)
                    hashCode = hashCode * 59 + this.For.GetHashCode();
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
