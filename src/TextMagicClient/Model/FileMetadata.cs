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
    /// FileMetadata
    /// </summary>
    [DataContract]
    public partial class FileMetadata :  IEquatable<FileMetadata>, IValidatableObject
    {
        /// <summary>
        /// File metadata type.
        /// </summary>
        /// <value>File metadata type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Image for value: image
            /// </summary>
            [EnumMember(Value = "image")]
            Image = 1,
            
            /// <summary>
            /// Enum Video for value: video
            /// </summary>
            [EnumMember(Value = "video")]
            Video = 2
        }

        /// <summary>
        /// File metadata type.
        /// </summary>
        /// <value>File metadata type.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileMetadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileMetadata() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileMetadata" /> class.
        /// </summary>
        /// <param name="type">File metadata type. (required).</param>
        /// <param name="height">height (required).</param>
        /// <param name="width">width (required).</param>
        /// <param name="preview">preview (required).</param>
        public FileMetadata(TypeEnum type = default(TypeEnum), int? height = default(int?), int? width = default(int?), FileMetadataPreview preview = default(FileMetadataPreview))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for FileMetadata and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "height" is required (not null)
            if (height == null)
            {
                throw new InvalidDataException("height is a required property for FileMetadata and cannot be null");
            }
            else
            {
                this.Height = height;
            }
            // to ensure "width" is required (not null)
            if (width == null)
            {
                throw new InvalidDataException("width is a required property for FileMetadata and cannot be null");
            }
            else
            {
                this.Width = width;
            }
            // to ensure "preview" is required (not null)
            if (preview == null)
            {
                throw new InvalidDataException("preview is a required property for FileMetadata and cannot be null");
            }
            else
            {
                this.Preview = preview;
            }
        }
        

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public int? Width { get; set; }

        /// <summary>
        /// Gets or Sets Preview
        /// </summary>
        [DataMember(Name="preview", EmitDefaultValue=false)]
        public FileMetadataPreview Preview { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileMetadata {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Preview: ").Append(Preview).Append("\n");
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
            return this.Equals(input as FileMetadata);
        }

        /// <summary>
        /// Returns true if FileMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of FileMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.Preview == input.Preview ||
                    (this.Preview != null &&
                    this.Preview.Equals(input.Preview))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Preview != null)
                    hashCode = hashCode * 59 + this.Preview.GetHashCode();
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
