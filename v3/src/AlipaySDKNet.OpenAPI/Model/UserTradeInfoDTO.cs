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
    /// UserTradeInfoDTO
    /// </summary>
    [DataContract(Name = "UserTradeInfoDTO")]
    public partial class UserTradeInfoDTO : IEquatable<UserTradeInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserTradeInfoDTO" /> class.
        /// </summary>
        /// <param name="goodsInfoList">商品信息列表.</param>
        /// <param name="partnerId">门店ISV的PID.</param>
        /// <param name="riskLevel">是否是风险交易：NO_RISK-无风险；POTENTIAL_RISK-潜在风险（中等风险）；HIGH_RISK-高风险.</param>
        /// <param name="tradeAmount">交易总金额，单位元，精确两位小数点.</param>
        /// <param name="tradeNo">交易单号.</param>
        /// <param name="tradeTime">交易时间.</param>
        /// <param name="unfilteredTotalGoodsCount">商品数据会根据活动商品列表进行过滤，该字段代表未过滤的商品列表大小.</param>
        /// <param name="userId">消费者支付宝ID.</param>
        public UserTradeInfoDTO(List<GoodsInfoDTO> goodsInfoList = default(List<GoodsInfoDTO>), string partnerId = default(string), string riskLevel = default(string), string tradeAmount = default(string), string tradeNo = default(string), string tradeTime = default(string), int unfilteredTotalGoodsCount = default(int), string userId = default(string))
        {
            this.GoodsInfoList = goodsInfoList;
            this.PartnerId = partnerId;
            this.RiskLevel = riskLevel;
            this.TradeAmount = tradeAmount;
            this.TradeNo = tradeNo;
            this.TradeTime = tradeTime;
            this.UnfilteredTotalGoodsCount = unfilteredTotalGoodsCount;
            this.UserId = userId;
        }

        /// <summary>
        /// 商品信息列表
        /// </summary>
        /// <value>商品信息列表</value>
        [DataMember(Name = "goods_info_list", EmitDefaultValue = false)]
        public List<GoodsInfoDTO> GoodsInfoList { get; set; }

        /// <summary>
        /// 门店ISV的PID
        /// </summary>
        /// <value>门店ISV的PID</value>
        [DataMember(Name = "partner_id", EmitDefaultValue = false)]
        public string PartnerId { get; set; }

        /// <summary>
        /// 是否是风险交易：NO_RISK-无风险；POTENTIAL_RISK-潜在风险（中等风险）；HIGH_RISK-高风险
        /// </summary>
        /// <value>是否是风险交易：NO_RISK-无风险；POTENTIAL_RISK-潜在风险（中等风险）；HIGH_RISK-高风险</value>
        [DataMember(Name = "risk_level", EmitDefaultValue = false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 交易总金额，单位元，精确两位小数点
        /// </summary>
        /// <value>交易总金额，单位元，精确两位小数点</value>
        [DataMember(Name = "trade_amount", EmitDefaultValue = false)]
        public string TradeAmount { get; set; }

        /// <summary>
        /// 交易单号
        /// </summary>
        /// <value>交易单号</value>
        [DataMember(Name = "trade_no", EmitDefaultValue = false)]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        /// <value>交易时间</value>
        [DataMember(Name = "trade_time", EmitDefaultValue = false)]
        public string TradeTime { get; set; }

        /// <summary>
        /// 商品数据会根据活动商品列表进行过滤，该字段代表未过滤的商品列表大小
        /// </summary>
        /// <value>商品数据会根据活动商品列表进行过滤，该字段代表未过滤的商品列表大小</value>
        [DataMember(Name = "unfiltered_total_goods_count", EmitDefaultValue = false)]
        public int UnfilteredTotalGoodsCount { get; set; }

        /// <summary>
        /// 消费者支付宝ID
        /// </summary>
        /// <value>消费者支付宝ID</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserTradeInfoDTO {\n");
            sb.Append("  GoodsInfoList: ").Append(GoodsInfoList).Append("\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            sb.Append("  RiskLevel: ").Append(RiskLevel).Append("\n");
            sb.Append("  TradeAmount: ").Append(TradeAmount).Append("\n");
            sb.Append("  TradeNo: ").Append(TradeNo).Append("\n");
            sb.Append("  TradeTime: ").Append(TradeTime).Append("\n");
            sb.Append("  UnfilteredTotalGoodsCount: ").Append(UnfilteredTotalGoodsCount).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as UserTradeInfoDTO);
        }

        /// <summary>
        /// Returns true if UserTradeInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of UserTradeInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserTradeInfoDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GoodsInfoList == input.GoodsInfoList ||
                    this.GoodsInfoList != null &&
                    input.GoodsInfoList != null &&
                    this.GoodsInfoList.SequenceEqual(input.GoodsInfoList)
                ) && 
                (
                    this.PartnerId == input.PartnerId ||
                    (this.PartnerId != null &&
                    this.PartnerId.Equals(input.PartnerId))
                ) && 
                (
                    this.RiskLevel == input.RiskLevel ||
                    (this.RiskLevel != null &&
                    this.RiskLevel.Equals(input.RiskLevel))
                ) && 
                (
                    this.TradeAmount == input.TradeAmount ||
                    (this.TradeAmount != null &&
                    this.TradeAmount.Equals(input.TradeAmount))
                ) && 
                (
                    this.TradeNo == input.TradeNo ||
                    (this.TradeNo != null &&
                    this.TradeNo.Equals(input.TradeNo))
                ) && 
                (
                    this.TradeTime == input.TradeTime ||
                    (this.TradeTime != null &&
                    this.TradeTime.Equals(input.TradeTime))
                ) && 
                (
                    this.UnfilteredTotalGoodsCount == input.UnfilteredTotalGoodsCount ||
                    this.UnfilteredTotalGoodsCount.Equals(input.UnfilteredTotalGoodsCount)
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.GoodsInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsInfoList.GetHashCode();
                }
                if (this.PartnerId != null)
                {
                    hashCode = (hashCode * 59) + this.PartnerId.GetHashCode();
                }
                if (this.RiskLevel != null)
                {
                    hashCode = (hashCode * 59) + this.RiskLevel.GetHashCode();
                }
                if (this.TradeAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TradeAmount.GetHashCode();
                }
                if (this.TradeNo != null)
                {
                    hashCode = (hashCode * 59) + this.TradeNo.GetHashCode();
                }
                if (this.TradeTime != null)
                {
                    hashCode = (hashCode * 59) + this.TradeTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UnfilteredTotalGoodsCount.GetHashCode();
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
