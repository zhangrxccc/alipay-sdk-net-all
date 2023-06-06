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
    /// OrderJourneyInfo
    /// </summary>
    [DataContract(Name = "OrderJourneyInfo")]
    public partial class OrderJourneyInfo : IEquatable<OrderJourneyInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderJourneyInfo" /> class.
        /// </summary>
        /// <param name="action">操作动作 -DELETE 删除，删除后的行程不再展示.</param>
        /// <param name="extInfo">扩展信息.</param>
        /// <param name="journeyCreateTime">行程创建时间.</param>
        /// <param name="journeyDesc">行程描述.</param>
        /// <param name="journeyElements">行程元素列表.</param>
        /// <param name="journeyIndex">描述本行程为整个行程中的第几程.</param>
        /// <param name="journeyModifyTime">行程修改时间.</param>
        /// <param name="merchantJourneyNo">商户行程单号 注：同一个pid下的行程单号需唯一。同一个pid下外部行程单号唯一.</param>
        /// <param name="status">行程状态 注：行程状态必须与支付宝侧进行约定.</param>
        /// <param name="statusDesc">行程状态描述.</param>
        /// <param name="subType">行程子类型.</param>
        /// <param name="title">行程标题.</param>
        /// <param name="type">行程类型.</param>
        public OrderJourneyInfo(string action = default(string), List<OrderExtInfo> extInfo = default(List<OrderExtInfo>), string journeyCreateTime = default(string), string journeyDesc = default(string), List<OrderJourneyElement> journeyElements = default(List<OrderJourneyElement>), string journeyIndex = default(string), string journeyModifyTime = default(string), string merchantJourneyNo = default(string), string status = default(string), string statusDesc = default(string), string subType = default(string), string title = default(string), string type = default(string))
        {
            this.Action = action;
            this.ExtInfo = extInfo;
            this.JourneyCreateTime = journeyCreateTime;
            this.JourneyDesc = journeyDesc;
            this.JourneyElements = journeyElements;
            this.JourneyIndex = journeyIndex;
            this.JourneyModifyTime = journeyModifyTime;
            this.MerchantJourneyNo = merchantJourneyNo;
            this.Status = status;
            this.StatusDesc = statusDesc;
            this.SubType = subType;
            this.Title = title;
            this.Type = type;
        }

        /// <summary>
        /// 操作动作 -DELETE 删除，删除后的行程不再展示
        /// </summary>
        /// <value>操作动作 -DELETE 删除，删除后的行程不再展示</value>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public string Action { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        /// <value>扩展信息</value>
        [DataMember(Name = "ext_info", EmitDefaultValue = false)]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 行程创建时间
        /// </summary>
        /// <value>行程创建时间</value>
        [DataMember(Name = "journey_create_time", EmitDefaultValue = false)]
        public string JourneyCreateTime { get; set; }

        /// <summary>
        /// 行程描述
        /// </summary>
        /// <value>行程描述</value>
        [DataMember(Name = "journey_desc", EmitDefaultValue = false)]
        public string JourneyDesc { get; set; }

        /// <summary>
        /// 行程元素列表
        /// </summary>
        /// <value>行程元素列表</value>
        [DataMember(Name = "journey_elements", EmitDefaultValue = false)]
        public List<OrderJourneyElement> JourneyElements { get; set; }

        /// <summary>
        /// 描述本行程为整个行程中的第几程
        /// </summary>
        /// <value>描述本行程为整个行程中的第几程</value>
        [DataMember(Name = "journey_index", EmitDefaultValue = false)]
        public string JourneyIndex { get; set; }

        /// <summary>
        /// 行程修改时间
        /// </summary>
        /// <value>行程修改时间</value>
        [DataMember(Name = "journey_modify_time", EmitDefaultValue = false)]
        public string JourneyModifyTime { get; set; }

        /// <summary>
        /// 商户行程单号 注：同一个pid下的行程单号需唯一。同一个pid下外部行程单号唯一
        /// </summary>
        /// <value>商户行程单号 注：同一个pid下的行程单号需唯一。同一个pid下外部行程单号唯一</value>
        [DataMember(Name = "merchant_journey_no", EmitDefaultValue = false)]
        public string MerchantJourneyNo { get; set; }

        /// <summary>
        /// 行程状态 注：行程状态必须与支付宝侧进行约定
        /// </summary>
        /// <value>行程状态 注：行程状态必须与支付宝侧进行约定</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 行程状态描述
        /// </summary>
        /// <value>行程状态描述</value>
        [DataMember(Name = "status_desc", EmitDefaultValue = false)]
        public string StatusDesc { get; set; }

        /// <summary>
        /// 行程子类型
        /// </summary>
        /// <value>行程子类型</value>
        [DataMember(Name = "sub_type", EmitDefaultValue = false)]
        public string SubType { get; set; }

        /// <summary>
        /// 行程标题
        /// </summary>
        /// <value>行程标题</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// 行程类型
        /// </summary>
        /// <value>行程类型</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderJourneyInfo {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ExtInfo: ").Append(ExtInfo).Append("\n");
            sb.Append("  JourneyCreateTime: ").Append(JourneyCreateTime).Append("\n");
            sb.Append("  JourneyDesc: ").Append(JourneyDesc).Append("\n");
            sb.Append("  JourneyElements: ").Append(JourneyElements).Append("\n");
            sb.Append("  JourneyIndex: ").Append(JourneyIndex).Append("\n");
            sb.Append("  JourneyModifyTime: ").Append(JourneyModifyTime).Append("\n");
            sb.Append("  MerchantJourneyNo: ").Append(MerchantJourneyNo).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDesc: ").Append(StatusDesc).Append("\n");
            sb.Append("  SubType: ").Append(SubType).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as OrderJourneyInfo);
        }

        /// <summary>
        /// Returns true if OrderJourneyInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderJourneyInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderJourneyInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.ExtInfo == input.ExtInfo ||
                    this.ExtInfo != null &&
                    input.ExtInfo != null &&
                    this.ExtInfo.SequenceEqual(input.ExtInfo)
                ) && 
                (
                    this.JourneyCreateTime == input.JourneyCreateTime ||
                    (this.JourneyCreateTime != null &&
                    this.JourneyCreateTime.Equals(input.JourneyCreateTime))
                ) && 
                (
                    this.JourneyDesc == input.JourneyDesc ||
                    (this.JourneyDesc != null &&
                    this.JourneyDesc.Equals(input.JourneyDesc))
                ) && 
                (
                    this.JourneyElements == input.JourneyElements ||
                    this.JourneyElements != null &&
                    input.JourneyElements != null &&
                    this.JourneyElements.SequenceEqual(input.JourneyElements)
                ) && 
                (
                    this.JourneyIndex == input.JourneyIndex ||
                    (this.JourneyIndex != null &&
                    this.JourneyIndex.Equals(input.JourneyIndex))
                ) && 
                (
                    this.JourneyModifyTime == input.JourneyModifyTime ||
                    (this.JourneyModifyTime != null &&
                    this.JourneyModifyTime.Equals(input.JourneyModifyTime))
                ) && 
                (
                    this.MerchantJourneyNo == input.MerchantJourneyNo ||
                    (this.MerchantJourneyNo != null &&
                    this.MerchantJourneyNo.Equals(input.MerchantJourneyNo))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusDesc == input.StatusDesc ||
                    (this.StatusDesc != null &&
                    this.StatusDesc.Equals(input.StatusDesc))
                ) && 
                (
                    this.SubType == input.SubType ||
                    (this.SubType != null &&
                    this.SubType.Equals(input.SubType))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Action != null)
                {
                    hashCode = (hashCode * 59) + this.Action.GetHashCode();
                }
                if (this.ExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExtInfo.GetHashCode();
                }
                if (this.JourneyCreateTime != null)
                {
                    hashCode = (hashCode * 59) + this.JourneyCreateTime.GetHashCode();
                }
                if (this.JourneyDesc != null)
                {
                    hashCode = (hashCode * 59) + this.JourneyDesc.GetHashCode();
                }
                if (this.JourneyElements != null)
                {
                    hashCode = (hashCode * 59) + this.JourneyElements.GetHashCode();
                }
                if (this.JourneyIndex != null)
                {
                    hashCode = (hashCode * 59) + this.JourneyIndex.GetHashCode();
                }
                if (this.JourneyModifyTime != null)
                {
                    hashCode = (hashCode * 59) + this.JourneyModifyTime.GetHashCode();
                }
                if (this.MerchantJourneyNo != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantJourneyNo.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.StatusDesc != null)
                {
                    hashCode = (hashCode * 59) + this.StatusDesc.GetHashCode();
                }
                if (this.SubType != null)
                {
                    hashCode = (hashCode * 59) + this.SubType.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
