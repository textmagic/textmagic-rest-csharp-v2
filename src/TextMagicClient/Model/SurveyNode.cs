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
    /// SurveyNode
    /// </summary>
    [DataContract]
    public partial class SurveyNode :  IEquatable<SurveyNode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyNode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SurveyNode() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyNode" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="label">label (required).</param>
        /// <param name="body">body (required).</param>
        /// <param name="nodeType">nodeType (required).</param>
        /// <param name="isEndNode">isEndNode (required).</param>
        /// <param name="sendDelay">sendDelay (required).</param>
        /// <param name="startNodes">startNodes (required).</param>
        /// <param name="endNodes">endNodes (required).</param>
        public SurveyNode(int? id = default(int?), string label = default(string), string body = default(string), string nodeType = default(string), bool? isEndNode = default(bool?), int? sendDelay = default(int?), List<string> startNodes = default(List<string>), List<string> endNodes = default(List<string>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for SurveyNode and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "label" is required (not null)
            if (label == null)
            {
                throw new InvalidDataException("label is a required property for SurveyNode and cannot be null");
            }
            else
            {
                this.Label = label;
            }
            // to ensure "body" is required (not null)
            if (body == null)
            {
                throw new InvalidDataException("body is a required property for SurveyNode and cannot be null");
            }
            else
            {
                this.Body = body;
            }
            // to ensure "nodeType" is required (not null)
            if (nodeType == null)
            {
                throw new InvalidDataException("nodeType is a required property for SurveyNode and cannot be null");
            }
            else
            {
                this.NodeType = nodeType;
            }
            // to ensure "isEndNode" is required (not null)
            if (isEndNode == null)
            {
                throw new InvalidDataException("isEndNode is a required property for SurveyNode and cannot be null");
            }
            else
            {
                this.IsEndNode = isEndNode;
            }
            // to ensure "sendDelay" is required (not null)
            if (sendDelay == null)
            {
                throw new InvalidDataException("sendDelay is a required property for SurveyNode and cannot be null");
            }
            else
            {
                this.SendDelay = sendDelay;
            }
            // to ensure "startNodes" is required (not null)
            if (startNodes == null)
            {
                throw new InvalidDataException("startNodes is a required property for SurveyNode and cannot be null");
            }
            else
            {
                this.StartNodes = startNodes;
            }
            // to ensure "endNodes" is required (not null)
            if (endNodes == null)
            {
                throw new InvalidDataException("endNodes is a required property for SurveyNode and cannot be null");
            }
            else
            {
                this.EndNodes = endNodes;
            }
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or Sets NodeType
        /// </summary>
        [DataMember(Name="nodeType", EmitDefaultValue=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// Gets or Sets IsEndNode
        /// </summary>
        [DataMember(Name="isEndNode", EmitDefaultValue=false)]
        public bool? IsEndNode { get; set; }

        /// <summary>
        /// Gets or Sets SendDelay
        /// </summary>
        [DataMember(Name="sendDelay", EmitDefaultValue=false)]
        public int? SendDelay { get; set; }

        /// <summary>
        /// Gets or Sets StartNodes
        /// </summary>
        [DataMember(Name="startNodes", EmitDefaultValue=false)]
        public List<string> StartNodes { get; set; }

        /// <summary>
        /// Gets or Sets EndNodes
        /// </summary>
        [DataMember(Name="endNodes", EmitDefaultValue=false)]
        public List<string> EndNodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SurveyNode {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  NodeType: ").Append(NodeType).Append("\n");
            sb.Append("  IsEndNode: ").Append(IsEndNode).Append("\n");
            sb.Append("  SendDelay: ").Append(SendDelay).Append("\n");
            sb.Append("  StartNodes: ").Append(StartNodes).Append("\n");
            sb.Append("  EndNodes: ").Append(EndNodes).Append("\n");
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
            return this.Equals(input as SurveyNode);
        }

        /// <summary>
        /// Returns true if SurveyNode instances are equal
        /// </summary>
        /// <param name="input">Instance of SurveyNode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SurveyNode input)
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
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.NodeType == input.NodeType ||
                    (this.NodeType != null &&
                    this.NodeType.Equals(input.NodeType))
                ) && 
                (
                    this.IsEndNode == input.IsEndNode ||
                    (this.IsEndNode != null &&
                    this.IsEndNode.Equals(input.IsEndNode))
                ) && 
                (
                    this.SendDelay == input.SendDelay ||
                    (this.SendDelay != null &&
                    this.SendDelay.Equals(input.SendDelay))
                ) && 
                (
                    this.StartNodes == input.StartNodes ||
                    this.StartNodes != null &&
                    this.StartNodes.SequenceEqual(input.StartNodes)
                ) && 
                (
                    this.EndNodes == input.EndNodes ||
                    this.EndNodes != null &&
                    this.EndNodes.SequenceEqual(input.EndNodes)
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
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.NodeType != null)
                    hashCode = hashCode * 59 + this.NodeType.GetHashCode();
                if (this.IsEndNode != null)
                    hashCode = hashCode * 59 + this.IsEndNode.GetHashCode();
                if (this.SendDelay != null)
                    hashCode = hashCode * 59 + this.SendDelay.GetHashCode();
                if (this.StartNodes != null)
                    hashCode = hashCode * 59 + this.StartNodes.GetHashCode();
                if (this.EndNodes != null)
                    hashCode = hashCode * 59 + this.EndNodes.GetHashCode();
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
