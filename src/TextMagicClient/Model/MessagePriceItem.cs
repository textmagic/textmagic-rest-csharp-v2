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
    /// MessagePriceItem
    /// </summary>
    [DataContract]
    public partial class MessagePriceItem :  IEquatable<MessagePriceItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagePriceItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessagePriceItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagePriceItem" /> class.
        /// </summary>
        /// <param name="name">Country name. (required).</param>
        /// <param name="price">Price to send message to desired country. (required).</param>
        /// <param name="country">The 2-letter ISO country code of the recipient&#39;s phone number. (required).</param>
        public MessagePriceItem(string name = default(string), string price = default(string), string country = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for MessagePriceItem and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "price" is required (not null)
            if (price == null)
            {
                throw new InvalidDataException("price is a required property for MessagePriceItem and cannot be null");
            }
            else
            {
                this.Price = price;
            }
            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new InvalidDataException("country is a required property for MessagePriceItem and cannot be null");
            }
            else
            {
                this.Country = country;
            }
        }
        
        /// <summary>
        /// Country name.
        /// </summary>
        /// <value>Country name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Price to send message to desired country.
        /// </summary>
        /// <value>Price to send message to desired country.</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public string Price { get; set; }

        /// <summary>
        /// The 2-letter ISO country code of the recipient&#39;s phone number.
        /// </summary>
        /// <value>The 2-letter ISO country code of the recipient&#39;s phone number.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessagePriceItem {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(input as MessagePriceItem);
        }

        /// <summary>
        /// Returns true if MessagePriceItem instances are equal
        /// </summary>
        /// <param name="input">Instance of MessagePriceItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessagePriceItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
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
