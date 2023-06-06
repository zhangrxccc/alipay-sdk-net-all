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
    /// IntelligentPromoEffect
    /// </summary>
    [DataContract(Name = "IntelligentPromoEffect")]
    public partial class IntelligentPromoEffect : IEquatable<IntelligentPromoEffect>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntelligentPromoEffect" /> class.
        /// </summary>
        /// <param name="avgPrizeIncrease">平均客单价提升比例.</param>
        /// <param name="cost">成本.</param>
        /// <param name="currentTotalAmount">当前效益.</param>
        /// <param name="effectId">营销活动的预期效果id.</param>
        /// <param name="gmtFrom">时间范围左值.</param>
        /// <param name="gmtTo">时间范围右值.</param>
        /// <param name="gmv">成交额.</param>
        /// <param name="remainStockNum">剩余库存数.</param>
        /// <param name="repayRateIncrease">复购率提升比例.</param>
        /// <param name="sendCountIncrease">发券量提升比例.</param>
        /// <param name="takeCount">发券数量.</param>
        /// <param name="type">营销活动效果类型。FORECAST：预估；STATISTICS：统计.</param>
        /// <param name="useCount">核销量.</param>
        public IntelligentPromoEffect(string avgPrizeIncrease = default(string), string cost = default(string), string currentTotalAmount = default(string), string effectId = default(string), string gmtFrom = default(string), string gmtTo = default(string), string gmv = default(string), int remainStockNum = default(int), string repayRateIncrease = default(string), string sendCountIncrease = default(string), int takeCount = default(int), string type = default(string), int useCount = default(int))
        {
            this.AvgPrizeIncrease = avgPrizeIncrease;
            this.Cost = cost;
            this.CurrentTotalAmount = currentTotalAmount;
            this.EffectId = effectId;
            this.GmtFrom = gmtFrom;
            this.GmtTo = gmtTo;
            this.Gmv = gmv;
            this.RemainStockNum = remainStockNum;
            this.RepayRateIncrease = repayRateIncrease;
            this.SendCountIncrease = sendCountIncrease;
            this.TakeCount = takeCount;
            this.Type = type;
            this.UseCount = useCount;
        }

        /// <summary>
        /// 平均客单价提升比例
        /// </summary>
        /// <value>平均客单价提升比例</value>
        [DataMember(Name = "avg_prize_increase", EmitDefaultValue = false)]
        public string AvgPrizeIncrease { get; set; }

        /// <summary>
        /// 成本
        /// </summary>
        /// <value>成本</value>
        [DataMember(Name = "cost", EmitDefaultValue = false)]
        public string Cost { get; set; }

        /// <summary>
        /// 当前效益
        /// </summary>
        /// <value>当前效益</value>
        [DataMember(Name = "current_total_amount", EmitDefaultValue = false)]
        public string CurrentTotalAmount { get; set; }

        /// <summary>
        /// 营销活动的预期效果id
        /// </summary>
        /// <value>营销活动的预期效果id</value>
        [DataMember(Name = "effect_id", EmitDefaultValue = false)]
        public string EffectId { get; set; }

        /// <summary>
        /// 时间范围左值
        /// </summary>
        /// <value>时间范围左值</value>
        [DataMember(Name = "gmt_from", EmitDefaultValue = false)]
        public string GmtFrom { get; set; }

        /// <summary>
        /// 时间范围右值
        /// </summary>
        /// <value>时间范围右值</value>
        [DataMember(Name = "gmt_to", EmitDefaultValue = false)]
        public string GmtTo { get; set; }

        /// <summary>
        /// 成交额
        /// </summary>
        /// <value>成交额</value>
        [DataMember(Name = "gmv", EmitDefaultValue = false)]
        public string Gmv { get; set; }

        /// <summary>
        /// 剩余库存数
        /// </summary>
        /// <value>剩余库存数</value>
        [DataMember(Name = "remain_stock_num", EmitDefaultValue = false)]
        public int RemainStockNum { get; set; }

        /// <summary>
        /// 复购率提升比例
        /// </summary>
        /// <value>复购率提升比例</value>
        [DataMember(Name = "repay_rate_increase", EmitDefaultValue = false)]
        public string RepayRateIncrease { get; set; }

        /// <summary>
        /// 发券量提升比例
        /// </summary>
        /// <value>发券量提升比例</value>
        [DataMember(Name = "send_count_increase", EmitDefaultValue = false)]
        public string SendCountIncrease { get; set; }

        /// <summary>
        /// 发券数量
        /// </summary>
        /// <value>发券数量</value>
        [DataMember(Name = "take_count", EmitDefaultValue = false)]
        public int TakeCount { get; set; }

        /// <summary>
        /// 营销活动效果类型。FORECAST：预估；STATISTICS：统计
        /// </summary>
        /// <value>营销活动效果类型。FORECAST：预估；STATISTICS：统计</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// 核销量
        /// </summary>
        /// <value>核销量</value>
        [DataMember(Name = "use_count", EmitDefaultValue = false)]
        public int UseCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IntelligentPromoEffect {\n");
            sb.Append("  AvgPrizeIncrease: ").Append(AvgPrizeIncrease).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  CurrentTotalAmount: ").Append(CurrentTotalAmount).Append("\n");
            sb.Append("  EffectId: ").Append(EffectId).Append("\n");
            sb.Append("  GmtFrom: ").Append(GmtFrom).Append("\n");
            sb.Append("  GmtTo: ").Append(GmtTo).Append("\n");
            sb.Append("  Gmv: ").Append(Gmv).Append("\n");
            sb.Append("  RemainStockNum: ").Append(RemainStockNum).Append("\n");
            sb.Append("  RepayRateIncrease: ").Append(RepayRateIncrease).Append("\n");
            sb.Append("  SendCountIncrease: ").Append(SendCountIncrease).Append("\n");
            sb.Append("  TakeCount: ").Append(TakeCount).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UseCount: ").Append(UseCount).Append("\n");
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
            return this.Equals(input as IntelligentPromoEffect);
        }

        /// <summary>
        /// Returns true if IntelligentPromoEffect instances are equal
        /// </summary>
        /// <param name="input">Instance of IntelligentPromoEffect to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntelligentPromoEffect input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AvgPrizeIncrease == input.AvgPrizeIncrease ||
                    (this.AvgPrizeIncrease != null &&
                    this.AvgPrizeIncrease.Equals(input.AvgPrizeIncrease))
                ) && 
                (
                    this.Cost == input.Cost ||
                    (this.Cost != null &&
                    this.Cost.Equals(input.Cost))
                ) && 
                (
                    this.CurrentTotalAmount == input.CurrentTotalAmount ||
                    (this.CurrentTotalAmount != null &&
                    this.CurrentTotalAmount.Equals(input.CurrentTotalAmount))
                ) && 
                (
                    this.EffectId == input.EffectId ||
                    (this.EffectId != null &&
                    this.EffectId.Equals(input.EffectId))
                ) && 
                (
                    this.GmtFrom == input.GmtFrom ||
                    (this.GmtFrom != null &&
                    this.GmtFrom.Equals(input.GmtFrom))
                ) && 
                (
                    this.GmtTo == input.GmtTo ||
                    (this.GmtTo != null &&
                    this.GmtTo.Equals(input.GmtTo))
                ) && 
                (
                    this.Gmv == input.Gmv ||
                    (this.Gmv != null &&
                    this.Gmv.Equals(input.Gmv))
                ) && 
                (
                    this.RemainStockNum == input.RemainStockNum ||
                    this.RemainStockNum.Equals(input.RemainStockNum)
                ) && 
                (
                    this.RepayRateIncrease == input.RepayRateIncrease ||
                    (this.RepayRateIncrease != null &&
                    this.RepayRateIncrease.Equals(input.RepayRateIncrease))
                ) && 
                (
                    this.SendCountIncrease == input.SendCountIncrease ||
                    (this.SendCountIncrease != null &&
                    this.SendCountIncrease.Equals(input.SendCountIncrease))
                ) && 
                (
                    this.TakeCount == input.TakeCount ||
                    this.TakeCount.Equals(input.TakeCount)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UseCount == input.UseCount ||
                    this.UseCount.Equals(input.UseCount)
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
                if (this.AvgPrizeIncrease != null)
                {
                    hashCode = (hashCode * 59) + this.AvgPrizeIncrease.GetHashCode();
                }
                if (this.Cost != null)
                {
                    hashCode = (hashCode * 59) + this.Cost.GetHashCode();
                }
                if (this.CurrentTotalAmount != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentTotalAmount.GetHashCode();
                }
                if (this.EffectId != null)
                {
                    hashCode = (hashCode * 59) + this.EffectId.GetHashCode();
                }
                if (this.GmtFrom != null)
                {
                    hashCode = (hashCode * 59) + this.GmtFrom.GetHashCode();
                }
                if (this.GmtTo != null)
                {
                    hashCode = (hashCode * 59) + this.GmtTo.GetHashCode();
                }
                if (this.Gmv != null)
                {
                    hashCode = (hashCode * 59) + this.Gmv.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RemainStockNum.GetHashCode();
                if (this.RepayRateIncrease != null)
                {
                    hashCode = (hashCode * 59) + this.RepayRateIncrease.GetHashCode();
                }
                if (this.SendCountIncrease != null)
                {
                    hashCode = (hashCode * 59) + this.SendCountIncrease.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TakeCount.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UseCount.GetHashCode();
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
