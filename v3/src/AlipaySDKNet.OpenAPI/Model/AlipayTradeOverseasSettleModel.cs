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
    /// AlipayTradeOverseasSettleModel
    /// </summary>
    [DataContract(Name = "AlipayTradeOverseasSettleModel")]
    public partial class AlipayTradeOverseasSettleModel : IEquatable<AlipayTradeOverseasSettleModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeOverseasSettleModel" /> class.
        /// </summary>
        /// <param name="amount">跨境结算的人民币金额，单位为元；等于交易金额 (实际为实收金额)，加上净补差金额，减去已退款金额，减去净收费金额，再减去净分账金额，.</param>
        /// <param name="extendParams">extendParams.</param>
        /// <param name="foreignSettleCurrency">跨境结算的外币币种.</param>
        /// <param name="outRequestNo">外部请求号，开发者自行生成并保证唯一性，作为业务幂等性控制.</param>
        /// <param name="tradeNo">支付宝交易号.</param>
        public AlipayTradeOverseasSettleModel(string amount = default(string), OverseasExtendParams extendParams = default(OverseasExtendParams), string foreignSettleCurrency = default(string), string outRequestNo = default(string), string tradeNo = default(string))
        {
            this.Amount = amount;
            this.ExtendParams = extendParams;
            this.ForeignSettleCurrency = foreignSettleCurrency;
            this.OutRequestNo = outRequestNo;
            this.TradeNo = tradeNo;
        }

        /// <summary>
        /// 跨境结算的人民币金额，单位为元；等于交易金额 (实际为实收金额)，加上净补差金额，减去已退款金额，减去净收费金额，再减去净分账金额，
        /// </summary>
        /// <value>跨境结算的人民币金额，单位为元；等于交易金额 (实际为实收金额)，加上净补差金额，减去已退款金额，减去净收费金额，再减去净分账金额，</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or Sets ExtendParams
        /// </summary>
        [DataMember(Name = "extend_params", EmitDefaultValue = false)]
        public OverseasExtendParams ExtendParams { get; set; }

        /// <summary>
        /// 跨境结算的外币币种
        /// </summary>
        /// <value>跨境结算的外币币种</value>
        [DataMember(Name = "foreign_settle_currency", EmitDefaultValue = false)]
        public string ForeignSettleCurrency { get; set; }

        /// <summary>
        /// 外部请求号，开发者自行生成并保证唯一性，作为业务幂等性控制
        /// </summary>
        /// <value>外部请求号，开发者自行生成并保证唯一性，作为业务幂等性控制</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        /// <value>支付宝交易号</value>
        [DataMember(Name = "trade_no", EmitDefaultValue = false)]
        public string TradeNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayTradeOverseasSettleModel {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ExtendParams: ").Append(ExtendParams).Append("\n");
            sb.Append("  ForeignSettleCurrency: ").Append(ForeignSettleCurrency).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  TradeNo: ").Append(TradeNo).Append("\n");
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
            return this.Equals(input as AlipayTradeOverseasSettleModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeOverseasSettleModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeOverseasSettleModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeOverseasSettleModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.ExtendParams == input.ExtendParams ||
                    (this.ExtendParams != null &&
                    this.ExtendParams.Equals(input.ExtendParams))
                ) && 
                (
                    this.ForeignSettleCurrency == input.ForeignSettleCurrency ||
                    (this.ForeignSettleCurrency != null &&
                    this.ForeignSettleCurrency.Equals(input.ForeignSettleCurrency))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.TradeNo == input.TradeNo ||
                    (this.TradeNo != null &&
                    this.TradeNo.Equals(input.TradeNo))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.ExtendParams != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendParams.GetHashCode();
                }
                if (this.ForeignSettleCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.ForeignSettleCurrency.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.TradeNo != null)
                {
                    hashCode = (hashCode * 59) + this.TradeNo.GetHashCode();
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
