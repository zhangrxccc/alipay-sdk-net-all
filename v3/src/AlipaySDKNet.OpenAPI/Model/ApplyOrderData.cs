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
    /// ApplyOrderData
    /// </summary>
    [DataContract(Name = "ApplyOrderData")]
    public partial class ApplyOrderData : IEquatable<ApplyOrderData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyOrderData" /> class.
        /// </summary>
        /// <param name="accessType">申请类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达.</param>
        /// <param name="appName">小程序名称.</param>
        /// <param name="appid">小程序id.</param>
        /// <param name="auditReason">审核原因.</param>
        /// <param name="brandTemplateId">品牌的模板id ONE_WITH_TWO：一拖二、DEFAULT：一拖四.</param>
        /// <param name="createTime">创建时间.</param>
        /// <param name="isOldData">标识老工单.</param>
        /// <param name="latest">是不是最新的工单.</param>
        /// <param name="majorStatus">服务主状态,INITIAL:初始化；VALID：已生效；INVALID：已失效.</param>
        /// <param name="orderId">申请单ID.</param>
        /// <param name="partAgreeInfo">审核提效部分剔除数据的信息.</param>
        /// <param name="sceneCode">场景编码.</param>
        /// <param name="sceneName">场景名称.</param>
        /// <param name="serviceCode">服务码.</param>
        /// <param name="status">申请状态 AGREE、REJECT、EDIT、AUDIT.</param>
        /// <param name="subServiceName">子服务名称.</param>
        public ApplyOrderData(string accessType = default(string), string appName = default(string), string appid = default(string), string auditReason = default(string), string brandTemplateId = default(string), string createTime = default(string), bool isOldData = default(bool), bool latest = default(bool), string majorStatus = default(string), string orderId = default(string), List<SearchPartAgreeInfo> partAgreeInfo = default(List<SearchPartAgreeInfo>), string sceneCode = default(string), string sceneName = default(string), string serviceCode = default(string), string status = default(string), string subServiceName = default(string))
        {
            this.AccessType = accessType;
            this.AppName = appName;
            this.Appid = appid;
            this.AuditReason = auditReason;
            this.BrandTemplateId = brandTemplateId;
            this.CreateTime = createTime;
            this.IsOldData = isOldData;
            this.Latest = latest;
            this.MajorStatus = majorStatus;
            this.OrderId = orderId;
            this.PartAgreeInfo = partAgreeInfo;
            this.SceneCode = sceneCode;
            this.SceneName = sceneName;
            this.ServiceCode = serviceCode;
            this.Status = status;
            this.SubServiceName = subServiceName;
        }

        /// <summary>
        /// 申请类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达
        /// </summary>
        /// <value>申请类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达</value>
        [DataMember(Name = "access_type", EmitDefaultValue = false)]
        public string AccessType { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        /// <value>小程序名称</value>
        [DataMember(Name = "app_name", EmitDefaultValue = false)]
        public string AppName { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        /// <value>小程序id</value>
        [DataMember(Name = "appid", EmitDefaultValue = false)]
        public string Appid { get; set; }

        /// <summary>
        /// 审核原因
        /// </summary>
        /// <value>审核原因</value>
        [DataMember(Name = "audit_reason", EmitDefaultValue = false)]
        public string AuditReason { get; set; }

        /// <summary>
        /// 品牌的模板id ONE_WITH_TWO：一拖二、DEFAULT：一拖四
        /// </summary>
        /// <value>品牌的模板id ONE_WITH_TWO：一拖二、DEFAULT：一拖四</value>
        [DataMember(Name = "brand_template_id", EmitDefaultValue = false)]
        public string BrandTemplateId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        /// <value>创建时间</value>
        [DataMember(Name = "create_time", EmitDefaultValue = false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 标识老工单
        /// </summary>
        /// <value>标识老工单</value>
        [DataMember(Name = "is_old_data", EmitDefaultValue = true)]
        public bool IsOldData { get; set; }

        /// <summary>
        /// 是不是最新的工单
        /// </summary>
        /// <value>是不是最新的工单</value>
        [DataMember(Name = "latest", EmitDefaultValue = true)]
        public bool Latest { get; set; }

        /// <summary>
        /// 服务主状态,INITIAL:初始化；VALID：已生效；INVALID：已失效
        /// </summary>
        /// <value>服务主状态,INITIAL:初始化；VALID：已生效；INVALID：已失效</value>
        [DataMember(Name = "major_status", EmitDefaultValue = false)]
        public string MajorStatus { get; set; }

        /// <summary>
        /// 申请单ID
        /// </summary>
        /// <value>申请单ID</value>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// 审核提效部分剔除数据的信息
        /// </summary>
        /// <value>审核提效部分剔除数据的信息</value>
        [DataMember(Name = "part_agree_info", EmitDefaultValue = false)]
        public List<SearchPartAgreeInfo> PartAgreeInfo { get; set; }

        /// <summary>
        /// 场景编码
        /// </summary>
        /// <value>场景编码</value>
        [DataMember(Name = "scene_code", EmitDefaultValue = false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// 场景名称
        /// </summary>
        /// <value>场景名称</value>
        [DataMember(Name = "scene_name", EmitDefaultValue = false)]
        public string SceneName { get; set; }

        /// <summary>
        /// 服务码
        /// </summary>
        /// <value>服务码</value>
        [DataMember(Name = "service_code", EmitDefaultValue = false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 申请状态 AGREE、REJECT、EDIT、AUDIT
        /// </summary>
        /// <value>申请状态 AGREE、REJECT、EDIT、AUDIT</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 子服务名称
        /// </summary>
        /// <value>子服务名称</value>
        [DataMember(Name = "sub_service_name", EmitDefaultValue = false)]
        public string SubServiceName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplyOrderData {\n");
            sb.Append("  AccessType: ").Append(AccessType).Append("\n");
            sb.Append("  AppName: ").Append(AppName).Append("\n");
            sb.Append("  Appid: ").Append(Appid).Append("\n");
            sb.Append("  AuditReason: ").Append(AuditReason).Append("\n");
            sb.Append("  BrandTemplateId: ").Append(BrandTemplateId).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  IsOldData: ").Append(IsOldData).Append("\n");
            sb.Append("  Latest: ").Append(Latest).Append("\n");
            sb.Append("  MajorStatus: ").Append(MajorStatus).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  PartAgreeInfo: ").Append(PartAgreeInfo).Append("\n");
            sb.Append("  SceneCode: ").Append(SceneCode).Append("\n");
            sb.Append("  SceneName: ").Append(SceneName).Append("\n");
            sb.Append("  ServiceCode: ").Append(ServiceCode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubServiceName: ").Append(SubServiceName).Append("\n");
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
            return this.Equals(input as ApplyOrderData);
        }

        /// <summary>
        /// Returns true if ApplyOrderData instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplyOrderData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplyOrderData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccessType == input.AccessType ||
                    (this.AccessType != null &&
                    this.AccessType.Equals(input.AccessType))
                ) && 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.Appid == input.Appid ||
                    (this.Appid != null &&
                    this.Appid.Equals(input.Appid))
                ) && 
                (
                    this.AuditReason == input.AuditReason ||
                    (this.AuditReason != null &&
                    this.AuditReason.Equals(input.AuditReason))
                ) && 
                (
                    this.BrandTemplateId == input.BrandTemplateId ||
                    (this.BrandTemplateId != null &&
                    this.BrandTemplateId.Equals(input.BrandTemplateId))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.IsOldData == input.IsOldData ||
                    this.IsOldData.Equals(input.IsOldData)
                ) && 
                (
                    this.Latest == input.Latest ||
                    this.Latest.Equals(input.Latest)
                ) && 
                (
                    this.MajorStatus == input.MajorStatus ||
                    (this.MajorStatus != null &&
                    this.MajorStatus.Equals(input.MajorStatus))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.PartAgreeInfo == input.PartAgreeInfo ||
                    this.PartAgreeInfo != null &&
                    input.PartAgreeInfo != null &&
                    this.PartAgreeInfo.SequenceEqual(input.PartAgreeInfo)
                ) && 
                (
                    this.SceneCode == input.SceneCode ||
                    (this.SceneCode != null &&
                    this.SceneCode.Equals(input.SceneCode))
                ) && 
                (
                    this.SceneName == input.SceneName ||
                    (this.SceneName != null &&
                    this.SceneName.Equals(input.SceneName))
                ) && 
                (
                    this.ServiceCode == input.ServiceCode ||
                    (this.ServiceCode != null &&
                    this.ServiceCode.Equals(input.ServiceCode))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SubServiceName == input.SubServiceName ||
                    (this.SubServiceName != null &&
                    this.SubServiceName.Equals(input.SubServiceName))
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
                if (this.AccessType != null)
                {
                    hashCode = (hashCode * 59) + this.AccessType.GetHashCode();
                }
                if (this.AppName != null)
                {
                    hashCode = (hashCode * 59) + this.AppName.GetHashCode();
                }
                if (this.Appid != null)
                {
                    hashCode = (hashCode * 59) + this.Appid.GetHashCode();
                }
                if (this.AuditReason != null)
                {
                    hashCode = (hashCode * 59) + this.AuditReason.GetHashCode();
                }
                if (this.BrandTemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.BrandTemplateId.GetHashCode();
                }
                if (this.CreateTime != null)
                {
                    hashCode = (hashCode * 59) + this.CreateTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsOldData.GetHashCode();
                hashCode = (hashCode * 59) + this.Latest.GetHashCode();
                if (this.MajorStatus != null)
                {
                    hashCode = (hashCode * 59) + this.MajorStatus.GetHashCode();
                }
                if (this.OrderId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                }
                if (this.PartAgreeInfo != null)
                {
                    hashCode = (hashCode * 59) + this.PartAgreeInfo.GetHashCode();
                }
                if (this.SceneCode != null)
                {
                    hashCode = (hashCode * 59) + this.SceneCode.GetHashCode();
                }
                if (this.SceneName != null)
                {
                    hashCode = (hashCode * 59) + this.SceneName.GetHashCode();
                }
                if (this.ServiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceCode.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.SubServiceName != null)
                {
                    hashCode = (hashCode * 59) + this.SubServiceName.GetHashCode();
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
