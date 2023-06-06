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
    /// InteligentUseRule
    /// </summary>
    [DataContract(Name = "InteligentUseRule")]
    public partial class InteligentUseRule : IEquatable<InteligentUseRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InteligentUseRule" /> class.
        /// </summary>
        /// <param name="inteligentForbiddenTime">inteligentForbiddenTime.</param>
        /// <param name="inteligentUseTimes">券可用时间段.</param>
        /// <param name="limitRule">优惠券的使用支付渠道限制规  则，  不受支付渠道限制  :USE_NO_LIMIT;  仅限口碑储值卡支付时可用  :USE_ON_CURRENT_PAY_C  HANNEL;  口碑储值卡支付时不可用  :NOT_ALLOWED_USE;  【备注】支付渠道限制不允许修改.</param>
        /// <param name="minConsume">券核销的最低消费门槛，单位元.</param>
        /// <param name="minConsumeCondition">minConsumeCondition.</param>
        /// <param name="payRedirectUrl">券买单跳转链接.</param>
        /// <param name="suitShops">券适用门店列表  仅品牌商发起的招商活动可为空  直发奖类型活动必须与活动适用门店一致  最多支持10w家门店.</param>
        public InteligentUseRule(InteligentForbiddenTime inteligentForbiddenTime = default(InteligentForbiddenTime), List<InteligentUseTime> inteligentUseTimes = default(List<InteligentUseTime>), string limitRule = default(string), string minConsume = default(string), InteligentDataCondition minConsumeCondition = default(InteligentDataCondition), string payRedirectUrl = default(string), List<string> suitShops = default(List<string>))
        {
            this.InteligentForbiddenTime = inteligentForbiddenTime;
            this.InteligentUseTimes = inteligentUseTimes;
            this.LimitRule = limitRule;
            this.MinConsume = minConsume;
            this.MinConsumeCondition = minConsumeCondition;
            this.PayRedirectUrl = payRedirectUrl;
            this.SuitShops = suitShops;
        }

        /// <summary>
        /// Gets or Sets InteligentForbiddenTime
        /// </summary>
        [DataMember(Name = "inteligent_forbidden_time", EmitDefaultValue = false)]
        public InteligentForbiddenTime InteligentForbiddenTime { get; set; }

        /// <summary>
        /// 券可用时间段
        /// </summary>
        /// <value>券可用时间段</value>
        [DataMember(Name = "inteligent_use_times", EmitDefaultValue = false)]
        public List<InteligentUseTime> InteligentUseTimes { get; set; }

        /// <summary>
        /// 优惠券的使用支付渠道限制规  则，  不受支付渠道限制  :USE_NO_LIMIT;  仅限口碑储值卡支付时可用  :USE_ON_CURRENT_PAY_C  HANNEL;  口碑储值卡支付时不可用  :NOT_ALLOWED_USE;  【备注】支付渠道限制不允许修改
        /// </summary>
        /// <value>优惠券的使用支付渠道限制规  则，  不受支付渠道限制  :USE_NO_LIMIT;  仅限口碑储值卡支付时可用  :USE_ON_CURRENT_PAY_C  HANNEL;  口碑储值卡支付时不可用  :NOT_ALLOWED_USE;  【备注】支付渠道限制不允许修改</value>
        [DataMember(Name = "limit_rule", EmitDefaultValue = false)]
        public string LimitRule { get; set; }

        /// <summary>
        /// 券核销的最低消费门槛，单位元
        /// </summary>
        /// <value>券核销的最低消费门槛，单位元</value>
        [DataMember(Name = "min_consume", EmitDefaultValue = false)]
        public string MinConsume { get; set; }

        /// <summary>
        /// Gets or Sets MinConsumeCondition
        /// </summary>
        [DataMember(Name = "min_consume_condition", EmitDefaultValue = false)]
        public InteligentDataCondition MinConsumeCondition { get; set; }

        /// <summary>
        /// 券买单跳转链接
        /// </summary>
        /// <value>券买单跳转链接</value>
        [DataMember(Name = "pay_redirect_url", EmitDefaultValue = false)]
        public string PayRedirectUrl { get; set; }

        /// <summary>
        /// 券适用门店列表  仅品牌商发起的招商活动可为空  直发奖类型活动必须与活动适用门店一致  最多支持10w家门店
        /// </summary>
        /// <value>券适用门店列表  仅品牌商发起的招商活动可为空  直发奖类型活动必须与活动适用门店一致  最多支持10w家门店</value>
        [DataMember(Name = "suit_shops", EmitDefaultValue = false)]
        public List<string> SuitShops { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InteligentUseRule {\n");
            sb.Append("  InteligentForbiddenTime: ").Append(InteligentForbiddenTime).Append("\n");
            sb.Append("  InteligentUseTimes: ").Append(InteligentUseTimes).Append("\n");
            sb.Append("  LimitRule: ").Append(LimitRule).Append("\n");
            sb.Append("  MinConsume: ").Append(MinConsume).Append("\n");
            sb.Append("  MinConsumeCondition: ").Append(MinConsumeCondition).Append("\n");
            sb.Append("  PayRedirectUrl: ").Append(PayRedirectUrl).Append("\n");
            sb.Append("  SuitShops: ").Append(SuitShops).Append("\n");
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
            return this.Equals(input as InteligentUseRule);
        }

        /// <summary>
        /// Returns true if InteligentUseRule instances are equal
        /// </summary>
        /// <param name="input">Instance of InteligentUseRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InteligentUseRule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InteligentForbiddenTime == input.InteligentForbiddenTime ||
                    (this.InteligentForbiddenTime != null &&
                    this.InteligentForbiddenTime.Equals(input.InteligentForbiddenTime))
                ) && 
                (
                    this.InteligentUseTimes == input.InteligentUseTimes ||
                    this.InteligentUseTimes != null &&
                    input.InteligentUseTimes != null &&
                    this.InteligentUseTimes.SequenceEqual(input.InteligentUseTimes)
                ) && 
                (
                    this.LimitRule == input.LimitRule ||
                    (this.LimitRule != null &&
                    this.LimitRule.Equals(input.LimitRule))
                ) && 
                (
                    this.MinConsume == input.MinConsume ||
                    (this.MinConsume != null &&
                    this.MinConsume.Equals(input.MinConsume))
                ) && 
                (
                    this.MinConsumeCondition == input.MinConsumeCondition ||
                    (this.MinConsumeCondition != null &&
                    this.MinConsumeCondition.Equals(input.MinConsumeCondition))
                ) && 
                (
                    this.PayRedirectUrl == input.PayRedirectUrl ||
                    (this.PayRedirectUrl != null &&
                    this.PayRedirectUrl.Equals(input.PayRedirectUrl))
                ) && 
                (
                    this.SuitShops == input.SuitShops ||
                    this.SuitShops != null &&
                    input.SuitShops != null &&
                    this.SuitShops.SequenceEqual(input.SuitShops)
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
                if (this.InteligentForbiddenTime != null)
                {
                    hashCode = (hashCode * 59) + this.InteligentForbiddenTime.GetHashCode();
                }
                if (this.InteligentUseTimes != null)
                {
                    hashCode = (hashCode * 59) + this.InteligentUseTimes.GetHashCode();
                }
                if (this.LimitRule != null)
                {
                    hashCode = (hashCode * 59) + this.LimitRule.GetHashCode();
                }
                if (this.MinConsume != null)
                {
                    hashCode = (hashCode * 59) + this.MinConsume.GetHashCode();
                }
                if (this.MinConsumeCondition != null)
                {
                    hashCode = (hashCode * 59) + this.MinConsumeCondition.GetHashCode();
                }
                if (this.PayRedirectUrl != null)
                {
                    hashCode = (hashCode * 59) + this.PayRedirectUrl.GetHashCode();
                }
                if (this.SuitShops != null)
                {
                    hashCode = (hashCode * 59) + this.SuitShops.GetHashCode();
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
