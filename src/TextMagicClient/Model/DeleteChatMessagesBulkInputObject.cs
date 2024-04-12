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
    /// DeleteChatMessagesBulkInputObject
    /// </summary>
    [DataContract]
    public partial class DeleteChatMessagesBulkInputObject :  IEquatable<DeleteChatMessagesBulkInputObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteChatMessagesBulkInputObject" /> class.
        /// </summary>
        /// <param name="inboundIds">Inbound message IDs to delete. Require when \&quot;all\&quot; is equal to 0 (false)..</param>
        /// <param name="sentIds">Sent message IDs to delete. Require when \&quot;all\&quot; is equal to 0 (false)..</param>
        /// <param name="callsIds">Calls IDs to delete. Require when \&quot;all\&quot; is equal to 0 (false)..</param>
        /// <param name="all">Default is 0 (false). If set to 1, all the entities will be removed..</param>
        public DeleteChatMessagesBulkInputObject(string inboundIds = default(string), string sentIds = default(string), string callsIds = default(string), bool? all = default(bool?))
        {
            this.InboundIds = inboundIds;
            this.SentIds = sentIds;
            this.CallsIds = callsIds;
            this.All = all;
        }
        
        /// <summary>
        /// Inbound message IDs to delete. Require when \&quot;all\&quot; is equal to 0 (false).
        /// </summary>
        /// <value>Inbound message IDs to delete. Require when \&quot;all\&quot; is equal to 0 (false).</value>
        [DataMember(Name="inbound_ids", EmitDefaultValue=false)]
        public string InboundIds { get; set; }

        /// <summary>
        /// Sent message IDs to delete. Require when \&quot;all\&quot; is equal to 0 (false).
        /// </summary>
        /// <value>Sent message IDs to delete. Require when \&quot;all\&quot; is equal to 0 (false).</value>
        [DataMember(Name="sent_ids", EmitDefaultValue=false)]
        public string SentIds { get; set; }

        /// <summary>
        /// Calls IDs to delete. Require when \&quot;all\&quot; is equal to 0 (false).
        /// </summary>
        /// <value>Calls IDs to delete. Require when \&quot;all\&quot; is equal to 0 (false).</value>
        [DataMember(Name="calls_ids", EmitDefaultValue=false)]
        public string CallsIds { get; set; }

        /// <summary>
        /// Default is 0 (false). If set to 1, all the entities will be removed.
        /// </summary>
        /// <value>Default is 0 (false). If set to 1, all the entities will be removed.</value>
        [DataMember(Name="all", EmitDefaultValue=false)]
        public bool? All { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteChatMessagesBulkInputObject {\n");
            sb.Append("  InboundIds: ").Append(InboundIds).Append("\n");
            sb.Append("  SentIds: ").Append(SentIds).Append("\n");
            sb.Append("  CallsIds: ").Append(CallsIds).Append("\n");
            sb.Append("  All: ").Append(All).Append("\n");
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
            return this.Equals(input as DeleteChatMessagesBulkInputObject);
        }

        /// <summary>
        /// Returns true if DeleteChatMessagesBulkInputObject instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteChatMessagesBulkInputObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteChatMessagesBulkInputObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InboundIds == input.InboundIds ||
                    (this.InboundIds != null &&
                    this.InboundIds.Equals(input.InboundIds))
                ) && 
                (
                    this.SentIds == input.SentIds ||
                    (this.SentIds != null &&
                    this.SentIds.Equals(input.SentIds))
                ) && 
                (
                    this.CallsIds == input.CallsIds ||
                    (this.CallsIds != null &&
                    this.CallsIds.Equals(input.CallsIds))
                ) && 
                (
                    this.All == input.All ||
                    (this.All != null &&
                    this.All.Equals(input.All))
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
                if (this.InboundIds != null)
                    hashCode = hashCode * 59 + this.InboundIds.GetHashCode();
                if (this.SentIds != null)
                    hashCode = hashCode * 59 + this.SentIds.GetHashCode();
                if (this.CallsIds != null)
                    hashCode = hashCode * 59 + this.CallsIds.GetHashCode();
                if (this.All != null)
                    hashCode = hashCode * 59 + this.All.GetHashCode();
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
