/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-10-25
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = AlipaySDKNet.OpenAPI.Client.OpenAPIDateConverter;

namespace AlipaySDKNet.OpenAPI.Model
{
    /// <summary>
    /// TemplateInfo
    /// </summary>
    [DataContract(Name = "TemplateInfo")]
    public partial class TemplateInfo : IEquatable<TemplateInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateInfo" /> class.
        /// </summary>
        /// <param name="fillContents">模板填充项.</param>
        /// <param name="name">文件名称.</param>
        /// <param name="signfields">signfields.</param>
        /// <param name="templateId">模板id.</param>
        public TemplateInfo(List<FillContent> fillContents = default(List<FillContent>), string name = default(string), SignField signfields = default(SignField), string templateId = default(string))
        {
            this.FillContents = fillContents;
            this.Name = name;
            this.Signfields = signfields;
            this.TemplateId = templateId;
        }

        /// <summary>
        /// 模板填充项
        /// </summary>
        /// <value>模板填充项</value>
        [DataMember(Name = "fill_contents", EmitDefaultValue = false)]
        public List<FillContent> FillContents { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        /// <value>文件名称</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Signfields
        /// </summary>
        [DataMember(Name = "signfields", EmitDefaultValue = false)]
        public SignField Signfields { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        /// <value>模板id</value>
        [DataMember(Name = "template_id", EmitDefaultValue = false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateInfo {\n");
            sb.Append("  FillContents: ").Append(FillContents).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Signfields: ").Append(Signfields).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateInfo);
        }

        /// <summary>
        /// Returns true if TemplateInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FillContents == input.FillContents ||
                    this.FillContents != null &&
                    input.FillContents != null &&
                    this.FillContents.SequenceEqual(input.FillContents)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Signfields == input.Signfields ||
                    (this.Signfields != null &&
                    this.Signfields.Equals(input.Signfields))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
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
                if (this.FillContents != null)
                {
                    hashCode = (hashCode * 59) + this.FillContents.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Signfields != null)
                {
                    hashCode = (hashCode * 59) + this.Signfields.GetHashCode();
                }
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
