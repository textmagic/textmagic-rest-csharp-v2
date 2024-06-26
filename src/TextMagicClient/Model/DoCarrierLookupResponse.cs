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
    /// DoCarrierLookupResponse
    /// </summary>
    [DataContract]
    public partial class DoCarrierLookupResponse :  IEquatable<DoCarrierLookupResponse>, IValidatableObject
    {
        /// <summary>
        /// Phone number type.
        /// </summary>
        /// <value>Phone number type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Mobile for value: mobile
            /// </summary>
            [EnumMember(Value = "mobile")]
            Mobile = 1,
            
            /// <summary>
            /// Enum Landline for value: landline
            /// </summary>
            [EnumMember(Value = "landline")]
            Landline = 2,
            
            /// <summary>
            /// Enum Voip for value: voip
            /// </summary>
            [EnumMember(Value = "voip")]
            Voip = 3
        }

        /// <summary>
        /// Phone number type.
        /// </summary>
        /// <value>Phone number type.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DoCarrierLookupResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DoCarrierLookupResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DoCarrierLookupResponse" /> class.
        /// </summary>
        /// <param name="cost">The cost to check that one number is constant – 0.04 in your account currency. (required).</param>
        /// <param name="country">Phone number country..</param>
        /// <param name="local">Phone number in [National format](https://en.wikipedia.org/wiki/National_conventions_for_writing_telephone_numbers). (required).</param>
        /// <param name="type">Phone number type. (required).</param>
        /// <param name="carrier">Carrier name. (required).</param>
        /// <param name="number164">Phone number in [E.164 format](https://en.wikipedia.org/wiki/E.164). (required).</param>
        /// <param name="valid">This field shows whether the entered phone number is valid or not. (required).</param>
        public DoCarrierLookupResponse(decimal? cost = default(decimal?), Country country = default(Country), string local = default(string), TypeEnum type = default(TypeEnum), string carrier = default(string), string number164 = default(string), bool? valid = default(bool?))
        {
            // to ensure "cost" is required (not null)
            if (cost == null)
            {
                throw new InvalidDataException("cost is a required property for DoCarrierLookupResponse and cannot be null");
            }
            else
            {
                this.Cost = cost;
            }
            // to ensure "local" is required (not null)
            if (local == null)
            {
                throw new InvalidDataException("local is a required property for DoCarrierLookupResponse and cannot be null");
            }
            else
            {
                this.Local = local;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for DoCarrierLookupResponse and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "carrier" is required (not null)
            if (carrier == null)
            {
                throw new InvalidDataException("carrier is a required property for DoCarrierLookupResponse and cannot be null");
            }
            else
            {
                this.Carrier = carrier;
            }
            // to ensure "number164" is required (not null)
            if (number164 == null)
            {
                throw new InvalidDataException("number164 is a required property for DoCarrierLookupResponse and cannot be null");
            }
            else
            {
                this.Number164 = number164;
            }
            // to ensure "valid" is required (not null)
            if (valid == null)
            {
                throw new InvalidDataException("valid is a required property for DoCarrierLookupResponse and cannot be null");
            }
            else
            {
                this.Valid = valid;
            }
            this.Country = country;
        }
        
        /// <summary>
        /// The cost to check that one number is constant – 0.04 in your account currency.
        /// </summary>
        /// <value>The cost to check that one number is constant – 0.04 in your account currency.</value>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public decimal? Cost { get; set; }

        /// <summary>
        /// Phone number country.
        /// </summary>
        /// <value>Phone number country.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public Country Country { get; set; }

        /// <summary>
        /// Phone number in [National format](https://en.wikipedia.org/wiki/National_conventions_for_writing_telephone_numbers).
        /// </summary>
        /// <value>Phone number in [National format](https://en.wikipedia.org/wiki/National_conventions_for_writing_telephone_numbers).</value>
        [DataMember(Name="local", EmitDefaultValue=false)]
        public string Local { get; set; }


        /// <summary>
        /// Carrier name.
        /// </summary>
        /// <value>Carrier name.</value>
        [DataMember(Name="carrier", EmitDefaultValue=false)]
        public string Carrier { get; set; }

        /// <summary>
        /// Phone number in [E.164 format](https://en.wikipedia.org/wiki/E.164).
        /// </summary>
        /// <value>Phone number in [E.164 format](https://en.wikipedia.org/wiki/E.164).</value>
        [DataMember(Name="number164", EmitDefaultValue=false)]
        public string Number164 { get; set; }

        /// <summary>
        /// This field shows whether the entered phone number is valid or not.
        /// </summary>
        /// <value>This field shows whether the entered phone number is valid or not.</value>
        [DataMember(Name="valid", EmitDefaultValue=false)]
        public bool? Valid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DoCarrierLookupResponse {\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Local: ").Append(Local).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  Number164: ").Append(Number164).Append("\n");
            sb.Append("  Valid: ").Append(Valid).Append("\n");
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
            return this.Equals(input as DoCarrierLookupResponse);
        }

        /// <summary>
        /// Returns true if DoCarrierLookupResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DoCarrierLookupResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DoCarrierLookupResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cost == input.Cost ||
                    (this.Cost != null &&
                    this.Cost.Equals(input.Cost))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Local == input.Local ||
                    (this.Local != null &&
                    this.Local.Equals(input.Local))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Carrier == input.Carrier ||
                    (this.Carrier != null &&
                    this.Carrier.Equals(input.Carrier))
                ) && 
                (
                    this.Number164 == input.Number164 ||
                    (this.Number164 != null &&
                    this.Number164.Equals(input.Number164))
                ) && 
                (
                    this.Valid == input.Valid ||
                    (this.Valid != null &&
                    this.Valid.Equals(input.Valid))
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
                if (this.Cost != null)
                    hashCode = hashCode * 59 + this.Cost.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Local != null)
                    hashCode = hashCode * 59 + this.Local.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Carrier != null)
                    hashCode = hashCode * 59 + this.Carrier.GetHashCode();
                if (this.Number164 != null)
                    hashCode = hashCode * 59 + this.Number164.GetHashCode();
                if (this.Valid != null)
                    hashCode = hashCode * 59 + this.Valid.GetHashCode();
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
