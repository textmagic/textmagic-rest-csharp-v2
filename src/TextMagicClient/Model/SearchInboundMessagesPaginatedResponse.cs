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
    /// SearchInboundMessagesPaginatedResponse
    /// </summary>
    [DataContract]
    public partial class SearchInboundMessagesPaginatedResponse :  IEquatable<SearchInboundMessagesPaginatedResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchInboundMessagesPaginatedResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchInboundMessagesPaginatedResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchInboundMessagesPaginatedResponse" /> class.
        /// </summary>
        /// <param name="page">page (required).</param>
        /// <param name="pageCount">The total number of pages. (required).</param>
        /// <param name="limit">The number of results per page. (required).</param>
        /// <param name="resources">resources (required).</param>
        public SearchInboundMessagesPaginatedResponse(int? page = default(int?), int? pageCount = default(int?), int? limit = default(int?), List<MessageIn> resources = default(List<MessageIn>))
        {
            // to ensure "page" is required (not null)
            if (page == null)
            {
                throw new InvalidDataException("page is a required property for SearchInboundMessagesPaginatedResponse and cannot be null");
            }
            else
            {
                this.Page = page;
            }
            // to ensure "pageCount" is required (not null)
            if (pageCount == null)
            {
                throw new InvalidDataException("pageCount is a required property for SearchInboundMessagesPaginatedResponse and cannot be null");
            }
            else
            {
                this.PageCount = pageCount;
            }
            // to ensure "limit" is required (not null)
            if (limit == null)
            {
                throw new InvalidDataException("limit is a required property for SearchInboundMessagesPaginatedResponse and cannot be null");
            }
            else
            {
                this.Limit = limit;
            }
            // to ensure "resources" is required (not null)
            if (resources == null)
            {
                throw new InvalidDataException("resources is a required property for SearchInboundMessagesPaginatedResponse and cannot be null");
            }
            else
            {
                this.Resources = resources;
            }
        }
        
        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public int? Page { get; set; }

        /// <summary>
        /// The total number of pages.
        /// </summary>
        /// <value>The total number of pages.</value>
        [DataMember(Name="pageCount", EmitDefaultValue=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// The number of results per page.
        /// </summary>
        /// <value>The number of results per page.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// Gets or Sets Resources
        /// </summary>
        [DataMember(Name="resources", EmitDefaultValue=false)]
        public List<MessageIn> Resources { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchInboundMessagesPaginatedResponse {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
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
            return this.Equals(input as SearchInboundMessagesPaginatedResponse);
        }

        /// <summary>
        /// Returns true if SearchInboundMessagesPaginatedResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchInboundMessagesPaginatedResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchInboundMessagesPaginatedResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.PageCount == input.PageCount ||
                    (this.PageCount != null &&
                    this.PageCount.Equals(input.PageCount))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Resources == input.Resources ||
                    this.Resources != null &&
                    this.Resources.SequenceEqual(input.Resources)
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
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.PageCount != null)
                    hashCode = hashCode * 59 + this.PageCount.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
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
