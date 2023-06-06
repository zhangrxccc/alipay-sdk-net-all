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
    /// AlipayMarketingCardMessageNotifyModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingCardMessageNotifyModel")]
    public partial class AlipayMarketingCardMessageNotifyModel : IEquatable<AlipayMarketingCardMessageNotifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCardMessageNotifyModel" /> class.
        /// </summary>
        /// <param name="notifyInfo">消息通知详情，包含消息通知需要的信息，map 格式存储。 积分过期提醒： &lt;br&gt;expired_point 过期积分值 &lt;br&gt;expired_time 过期时间.</param>
        /// <param name="notifyNo">消息通知幂等标识，业务流水号.</param>
        /// <param name="notifyType">消息通知类型, &lt;br&gt;POINT_REMIND 积分过期提醒.</param>
        /// <param name="occurTime">标识业务发生时间，时间格式为\&quot;yyyy-MM-dd HH:mm:ss\&quot;。.</param>
        /// <param name="targetCardNo">支付宝业务卡号，即通过 alipay.marketing.card.open 接口开卡后获取的 card_info.biz_card_no 值。.</param>
        /// <param name="targetCardNoType">卡号ID类型。支持： BIZ_CARD：支付宝业务卡号（商户会员卡场景使用）。.</param>
        public AlipayMarketingCardMessageNotifyModel(string notifyInfo = default(string), string notifyNo = default(string), string notifyType = default(string), string occurTime = default(string), string targetCardNo = default(string), string targetCardNoType = default(string))
        {
            this.NotifyInfo = notifyInfo;
            this.NotifyNo = notifyNo;
            this.NotifyType = notifyType;
            this.OccurTime = occurTime;
            this.TargetCardNo = targetCardNo;
            this.TargetCardNoType = targetCardNoType;
        }

        /// <summary>
        /// 消息通知详情，包含消息通知需要的信息，map 格式存储。 积分过期提醒： &lt;br&gt;expired_point 过期积分值 &lt;br&gt;expired_time 过期时间
        /// </summary>
        /// <value>消息通知详情，包含消息通知需要的信息，map 格式存储。 积分过期提醒： &lt;br&gt;expired_point 过期积分值 &lt;br&gt;expired_time 过期时间</value>
        [DataMember(Name = "notify_info", EmitDefaultValue = false)]
        public string NotifyInfo { get; set; }

        /// <summary>
        /// 消息通知幂等标识，业务流水号
        /// </summary>
        /// <value>消息通知幂等标识，业务流水号</value>
        [DataMember(Name = "notify_no", EmitDefaultValue = false)]
        public string NotifyNo { get; set; }

        /// <summary>
        /// 消息通知类型, &lt;br&gt;POINT_REMIND 积分过期提醒
        /// </summary>
        /// <value>消息通知类型, &lt;br&gt;POINT_REMIND 积分过期提醒</value>
        [DataMember(Name = "notify_type", EmitDefaultValue = false)]
        public string NotifyType { get; set; }

        /// <summary>
        /// 标识业务发生时间，时间格式为\&quot;yyyy-MM-dd HH:mm:ss\&quot;。
        /// </summary>
        /// <value>标识业务发生时间，时间格式为\&quot;yyyy-MM-dd HH:mm:ss\&quot;。</value>
        [DataMember(Name = "occur_time", EmitDefaultValue = false)]
        public string OccurTime { get; set; }

        /// <summary>
        /// 支付宝业务卡号，即通过 alipay.marketing.card.open 接口开卡后获取的 card_info.biz_card_no 值。
        /// </summary>
        /// <value>支付宝业务卡号，即通过 alipay.marketing.card.open 接口开卡后获取的 card_info.biz_card_no 值。</value>
        [DataMember(Name = "target_card_no", EmitDefaultValue = false)]
        public string TargetCardNo { get; set; }

        /// <summary>
        /// 卡号ID类型。支持： BIZ_CARD：支付宝业务卡号（商户会员卡场景使用）。
        /// </summary>
        /// <value>卡号ID类型。支持： BIZ_CARD：支付宝业务卡号（商户会员卡场景使用）。</value>
        [DataMember(Name = "target_card_no_type", EmitDefaultValue = false)]
        public string TargetCardNoType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingCardMessageNotifyModel {\n");
            sb.Append("  NotifyInfo: ").Append(NotifyInfo).Append("\n");
            sb.Append("  NotifyNo: ").Append(NotifyNo).Append("\n");
            sb.Append("  NotifyType: ").Append(NotifyType).Append("\n");
            sb.Append("  OccurTime: ").Append(OccurTime).Append("\n");
            sb.Append("  TargetCardNo: ").Append(TargetCardNo).Append("\n");
            sb.Append("  TargetCardNoType: ").Append(TargetCardNoType).Append("\n");
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
            return this.Equals(input as AlipayMarketingCardMessageNotifyModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingCardMessageNotifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingCardMessageNotifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingCardMessageNotifyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NotifyInfo == input.NotifyInfo ||
                    (this.NotifyInfo != null &&
                    this.NotifyInfo.Equals(input.NotifyInfo))
                ) && 
                (
                    this.NotifyNo == input.NotifyNo ||
                    (this.NotifyNo != null &&
                    this.NotifyNo.Equals(input.NotifyNo))
                ) && 
                (
                    this.NotifyType == input.NotifyType ||
                    (this.NotifyType != null &&
                    this.NotifyType.Equals(input.NotifyType))
                ) && 
                (
                    this.OccurTime == input.OccurTime ||
                    (this.OccurTime != null &&
                    this.OccurTime.Equals(input.OccurTime))
                ) && 
                (
                    this.TargetCardNo == input.TargetCardNo ||
                    (this.TargetCardNo != null &&
                    this.TargetCardNo.Equals(input.TargetCardNo))
                ) && 
                (
                    this.TargetCardNoType == input.TargetCardNoType ||
                    (this.TargetCardNoType != null &&
                    this.TargetCardNoType.Equals(input.TargetCardNoType))
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
                if (this.NotifyInfo != null)
                {
                    hashCode = (hashCode * 59) + this.NotifyInfo.GetHashCode();
                }
                if (this.NotifyNo != null)
                {
                    hashCode = (hashCode * 59) + this.NotifyNo.GetHashCode();
                }
                if (this.NotifyType != null)
                {
                    hashCode = (hashCode * 59) + this.NotifyType.GetHashCode();
                }
                if (this.OccurTime != null)
                {
                    hashCode = (hashCode * 59) + this.OccurTime.GetHashCode();
                }
                if (this.TargetCardNo != null)
                {
                    hashCode = (hashCode * 59) + this.TargetCardNo.GetHashCode();
                }
                if (this.TargetCardNoType != null)
                {
                    hashCode = (hashCode * 59) + this.TargetCardNoType.GetHashCode();
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
