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
    /// Returned when input data validation process has been failed.
    /// </summary>
    [DataContract]
    public partial class BadRequestResponse :  IEquatable<BadRequestResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BadRequestResponse" /> class.
        /// </summary>
        /// <param name="code">Error code. Meanings of error codes are similar to [HTTP response codes](https://en.wikipedia.org/wiki/List_of_HTTP_status_codes)..</param>
        /// <param name="message">Brief error message. You could display this message to your user or save it in a log..</param>
        /// <param name="errors">errors.</param>
        public BadRequestResponse(int? code = default(int?), string message = default(string), BadRequestResponseErrors errors = default(BadRequestResponseErrors))
        {
            this.Code = code;
            this.Message = message;
            this.Errors = errors;
        }
        
        /// <summary>
        /// Error code. Meanings of error codes are similar to [HTTP response codes](https://en.wikipedia.org/wiki/List_of_HTTP_status_codes).
        /// </summary>
        /// <value>Error code. Meanings of error codes are similar to [HTTP response codes](https://en.wikipedia.org/wiki/List_of_HTTP_status_codes).</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public int? Code { get; set; }

        /// <summary>
        /// Brief error message. You could display this message to your user or save it in a log.
        /// </summary>
        /// <value>Brief error message. You could display this message to your user or save it in a log.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public BadRequestResponseErrors Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BadRequestResponse {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(input as BadRequestResponse);
        }

        /// <summary>
        /// Returns true if BadRequestResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BadRequestResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BadRequestResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Errors == input.Errors ||
                    (this.Errors != null &&
                    this.Errors.Equals(input.Errors))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
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
