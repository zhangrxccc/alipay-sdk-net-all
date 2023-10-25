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
    /// SearchBoxBasicInfoModule
    /// </summary>
    [DataContract(Name = "SearchBoxBasicInfoModule")]
    public partial class SearchBoxBasicInfoModule : IEquatable<SearchBoxBasicInfoModule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchBoxBasicInfoModule" /> class.
        /// </summary>
        /// <param name="applyNo">申请单号.</param>
        /// <param name="boxDesc">介绍，已生效的数据.</param>
        /// <param name="failReason">审核失败原因.</param>
        /// <param name="gmtModified">修改时间.</param>
        /// <param name="latestAuditBoxDesc">介绍，最近一次审核内容.</param>
        /// <param name="moduleId">模块配置ID.</param>
        /// <param name="moduleType">搜索直达模块类型.</param>
        /// <param name="status">状态，INITIAL-初始/AUDIT-审核中/CANCEL-已取消/ONLINE-已上架/REJECT-驳回/OFFLINE-已下架/EXPIRE-已失效.</param>
        public SearchBoxBasicInfoModule(string applyNo = default(string), string boxDesc = default(string), string failReason = default(string), string gmtModified = default(string), string latestAuditBoxDesc = default(string), string moduleId = default(string), string moduleType = default(string), string status = default(string))
        {
            this.ApplyNo = applyNo;
            this.BoxDesc = boxDesc;
            this.FailReason = failReason;
            this.GmtModified = gmtModified;
            this.LatestAuditBoxDesc = latestAuditBoxDesc;
            this.ModuleId = moduleId;
            this.ModuleType = moduleType;
            this.Status = status;
        }

        /// <summary>
        /// 申请单号
        /// </summary>
        /// <value>申请单号</value>
        [DataMember(Name = "apply_no", EmitDefaultValue = false)]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 介绍，已生效的数据
        /// </summary>
        /// <value>介绍，已生效的数据</value>
        [DataMember(Name = "box_desc", EmitDefaultValue = false)]
        public string BoxDesc { get; set; }

        /// <summary>
        /// 审核失败原因
        /// </summary>
        /// <value>审核失败原因</value>
        [DataMember(Name = "fail_reason", EmitDefaultValue = false)]
        public string FailReason { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        /// <value>修改时间</value>
        [DataMember(Name = "gmt_modified", EmitDefaultValue = false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// 介绍，最近一次审核内容
        /// </summary>
        /// <value>介绍，最近一次审核内容</value>
        [DataMember(Name = "latest_audit_box_desc", EmitDefaultValue = false)]
        public string LatestAuditBoxDesc { get; set; }

        /// <summary>
        /// 模块配置ID
        /// </summary>
        /// <value>模块配置ID</value>
        [DataMember(Name = "module_id", EmitDefaultValue = false)]
        public string ModuleId { get; set; }

        /// <summary>
        /// 搜索直达模块类型
        /// </summary>
        /// <value>搜索直达模块类型</value>
        [DataMember(Name = "module_type", EmitDefaultValue = false)]
        public string ModuleType { get; set; }

        /// <summary>
        /// 状态，INITIAL-初始/AUDIT-审核中/CANCEL-已取消/ONLINE-已上架/REJECT-驳回/OFFLINE-已下架/EXPIRE-已失效
        /// </summary>
        /// <value>状态，INITIAL-初始/AUDIT-审核中/CANCEL-已取消/ONLINE-已上架/REJECT-驳回/OFFLINE-已下架/EXPIRE-已失效</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchBoxBasicInfoModule {\n");
            sb.Append("  ApplyNo: ").Append(ApplyNo).Append("\n");
            sb.Append("  BoxDesc: ").Append(BoxDesc).Append("\n");
            sb.Append("  FailReason: ").Append(FailReason).Append("\n");
            sb.Append("  GmtModified: ").Append(GmtModified).Append("\n");
            sb.Append("  LatestAuditBoxDesc: ").Append(LatestAuditBoxDesc).Append("\n");
            sb.Append("  ModuleId: ").Append(ModuleId).Append("\n");
            sb.Append("  ModuleType: ").Append(ModuleType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as SearchBoxBasicInfoModule);
        }

        /// <summary>
        /// Returns true if SearchBoxBasicInfoModule instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchBoxBasicInfoModule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchBoxBasicInfoModule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApplyNo == input.ApplyNo ||
                    (this.ApplyNo != null &&
                    this.ApplyNo.Equals(input.ApplyNo))
                ) && 
                (
                    this.BoxDesc == input.BoxDesc ||
                    (this.BoxDesc != null &&
                    this.BoxDesc.Equals(input.BoxDesc))
                ) && 
                (
                    this.FailReason == input.FailReason ||
                    (this.FailReason != null &&
                    this.FailReason.Equals(input.FailReason))
                ) && 
                (
                    this.GmtModified == input.GmtModified ||
                    (this.GmtModified != null &&
                    this.GmtModified.Equals(input.GmtModified))
                ) && 
                (
                    this.LatestAuditBoxDesc == input.LatestAuditBoxDesc ||
                    (this.LatestAuditBoxDesc != null &&
                    this.LatestAuditBoxDesc.Equals(input.LatestAuditBoxDesc))
                ) && 
                (
                    this.ModuleId == input.ModuleId ||
                    (this.ModuleId != null &&
                    this.ModuleId.Equals(input.ModuleId))
                ) && 
                (
                    this.ModuleType == input.ModuleType ||
                    (this.ModuleType != null &&
                    this.ModuleType.Equals(input.ModuleType))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.ApplyNo != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyNo.GetHashCode();
                }
                if (this.BoxDesc != null)
                {
                    hashCode = (hashCode * 59) + this.BoxDesc.GetHashCode();
                }
                if (this.FailReason != null)
                {
                    hashCode = (hashCode * 59) + this.FailReason.GetHashCode();
                }
                if (this.GmtModified != null)
                {
                    hashCode = (hashCode * 59) + this.GmtModified.GetHashCode();
                }
                if (this.LatestAuditBoxDesc != null)
                {
                    hashCode = (hashCode * 59) + this.LatestAuditBoxDesc.GetHashCode();
                }
                if (this.ModuleId != null)
                {
                    hashCode = (hashCode * 59) + this.ModuleId.GetHashCode();
                }
                if (this.ModuleType != null)
                {
                    hashCode = (hashCode * 59) + this.ModuleType.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
