/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-06-06
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
    /// RecruitMaterial
    /// </summary>
    [DataContract(Name = "RecruitMaterial")]
    public partial class RecruitMaterial : IEquatable<RecruitMaterial>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecruitMaterial" /> class.
        /// </summary>
        /// <param name="data">提报的素材内容，json字符串，使用时需要把此字符串解析成json对象。 字段来源于“招商方案查询接口（https://opendocs.alipay.com/pre-open/02bhl7）”中返回的素材字段field。如：activityImage、contentId等。 字段类型mediaType包含：   IMAGE，图片类型   TEXT，文本类型   DATASOURCE，数据源类型， 如：内容ID（contentId）字段类型为DATASOURCE 字段取值：   图片（IMAGE）：     aftsFileId：“营销图片资源上传接口（https://opendocs.alipay.com/pre-open/02bhlj）”返回的图片唯一资源ID   文本（TEXT）：     text：文本内容   数据源（DATASOURCE）：     text：当前仅支持内容ID值，可通过“内容批量查询接口（https://opendocs.alipay.com/pre-apis/02lu12，仅供受邀用户使用）”查询内容ID。.</param>
        /// <param name="description">对这个素材的描述，用于后续管理该素材.</param>
        /// <param name="materialAuditInfo">素材审核信息，展示给商家的素材审核不通过的意见。素材审核通过时该字段为空。 报名详情查询接口不用填写该字段。.</param>
        /// <param name="name">素材名名称.</param>
        /// <param name="subjectId">关联的报名主体ID。 enroll_scene_type是VOUCHER时，报名主体ID是activity_id；enroll_scene_type是MINI_APP时，报名主体ID是mini_app_id.</param>
        public RecruitMaterial(string data = default(string), string description = default(string), string materialAuditInfo = default(string), string name = default(string), string subjectId = default(string))
        {
            this.Data = data;
            this.Description = description;
            this.MaterialAuditInfo = materialAuditInfo;
            this.Name = name;
            this.SubjectId = subjectId;
        }

        /// <summary>
        /// 提报的素材内容，json字符串，使用时需要把此字符串解析成json对象。 字段来源于“招商方案查询接口（https://opendocs.alipay.com/pre-open/02bhl7）”中返回的素材字段field。如：activityImage、contentId等。 字段类型mediaType包含：   IMAGE，图片类型   TEXT，文本类型   DATASOURCE，数据源类型， 如：内容ID（contentId）字段类型为DATASOURCE 字段取值：   图片（IMAGE）：     aftsFileId：“营销图片资源上传接口（https://opendocs.alipay.com/pre-open/02bhlj）”返回的图片唯一资源ID   文本（TEXT）：     text：文本内容   数据源（DATASOURCE）：     text：当前仅支持内容ID值，可通过“内容批量查询接口（https://opendocs.alipay.com/pre-apis/02lu12，仅供受邀用户使用）”查询内容ID。
        /// </summary>
        /// <value>提报的素材内容，json字符串，使用时需要把此字符串解析成json对象。 字段来源于“招商方案查询接口（https://opendocs.alipay.com/pre-open/02bhl7）”中返回的素材字段field。如：activityImage、contentId等。 字段类型mediaType包含：   IMAGE，图片类型   TEXT，文本类型   DATASOURCE，数据源类型， 如：内容ID（contentId）字段类型为DATASOURCE 字段取值：   图片（IMAGE）：     aftsFileId：“营销图片资源上传接口（https://opendocs.alipay.com/pre-open/02bhlj）”返回的图片唯一资源ID   文本（TEXT）：     text：文本内容   数据源（DATASOURCE）：     text：当前仅支持内容ID值，可通过“内容批量查询接口（https://opendocs.alipay.com/pre-apis/02lu12，仅供受邀用户使用）”查询内容ID。</value>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public string Data { get; set; }

        /// <summary>
        /// 对这个素材的描述，用于后续管理该素材
        /// </summary>
        /// <value>对这个素材的描述，用于后续管理该素材</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// 素材审核信息，展示给商家的素材审核不通过的意见。素材审核通过时该字段为空。 报名详情查询接口不用填写该字段。
        /// </summary>
        /// <value>素材审核信息，展示给商家的素材审核不通过的意见。素材审核通过时该字段为空。 报名详情查询接口不用填写该字段。</value>
        [DataMember(Name = "material_audit_info", EmitDefaultValue = false)]
        public string MaterialAuditInfo { get; set; }

        /// <summary>
        /// 素材名名称
        /// </summary>
        /// <value>素材名名称</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 关联的报名主体ID。 enroll_scene_type是VOUCHER时，报名主体ID是activity_id；enroll_scene_type是MINI_APP时，报名主体ID是mini_app_id
        /// </summary>
        /// <value>关联的报名主体ID。 enroll_scene_type是VOUCHER时，报名主体ID是activity_id；enroll_scene_type是MINI_APP时，报名主体ID是mini_app_id</value>
        [DataMember(Name = "subject_id", EmitDefaultValue = false)]
        public string SubjectId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecruitMaterial {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MaterialAuditInfo: ").Append(MaterialAuditInfo).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SubjectId: ").Append(SubjectId).Append("\n");
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
            return this.Equals(input as RecruitMaterial);
        }

        /// <summary>
        /// Returns true if RecruitMaterial instances are equal
        /// </summary>
        /// <param name="input">Instance of RecruitMaterial to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecruitMaterial input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.MaterialAuditInfo == input.MaterialAuditInfo ||
                    (this.MaterialAuditInfo != null &&
                    this.MaterialAuditInfo.Equals(input.MaterialAuditInfo))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SubjectId == input.SubjectId ||
                    (this.SubjectId != null &&
                    this.SubjectId.Equals(input.SubjectId))
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.MaterialAuditInfo != null)
                {
                    hashCode = (hashCode * 59) + this.MaterialAuditInfo.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.SubjectId != null)
                {
                    hashCode = (hashCode * 59) + this.SubjectId.GetHashCode();
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
