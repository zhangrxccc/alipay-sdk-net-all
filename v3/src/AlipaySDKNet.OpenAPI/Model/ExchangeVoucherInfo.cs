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
    /// ExchangeVoucherInfo
    /// </summary>
    [DataContract(Name = "ExchangeVoucherInfo")]
    public partial class ExchangeVoucherInfo : IEquatable<ExchangeVoucherInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeVoucherInfo" /> class.
        /// </summary>
        /// <param name="amount">券的价值.</param>
        /// <param name="bizType">兑换券业务类型。 注意：兑换券通过大促活动权益报名能力推广至支付宝会场时，本参数必填。.</param>
        /// <param name="exchangeGoodsInfo">exchangeGoodsInfo.</param>
        /// <param name="floorAmount">优惠门槛金额，表示只有当订单金额大于等于门槛金额时券才能使用。该字段为空时表示无门槛。  门槛金额的校验由服务商(商户)核销时自行校验，支付宝侧只做展示使用。.</param>
        /// <param name="voucherDeductThresholdInfo">voucherDeductThresholdInfo.</param>
        public ExchangeVoucherInfo(string amount = default(string), string bizType = default(string), VoucherExchangeGoodsInfo exchangeGoodsInfo = default(VoucherExchangeGoodsInfo), string floorAmount = default(string), VoucherDeductThresholdInfo voucherDeductThresholdInfo = default(VoucherDeductThresholdInfo))
        {
            this.Amount = amount;
            this.BizType = bizType;
            this.ExchangeGoodsInfo = exchangeGoodsInfo;
            this.FloorAmount = floorAmount;
            this.VoucherDeductThresholdInfo = voucherDeductThresholdInfo;
        }

        /// <summary>
        /// 券的价值
        /// </summary>
        /// <value>券的价值</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 兑换券业务类型。 注意：兑换券通过大促活动权益报名能力推广至支付宝会场时，本参数必填。
        /// </summary>
        /// <value>兑换券业务类型。 注意：兑换券通过大促活动权益报名能力推广至支付宝会场时，本参数必填。</value>
        [DataMember(Name = "biz_type", EmitDefaultValue = false)]
        public string BizType { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeGoodsInfo
        /// </summary>
        [DataMember(Name = "exchange_goods_info", EmitDefaultValue = false)]
        public VoucherExchangeGoodsInfo ExchangeGoodsInfo { get; set; }

        /// <summary>
        /// 优惠门槛金额，表示只有当订单金额大于等于门槛金额时券才能使用。该字段为空时表示无门槛。  门槛金额的校验由服务商(商户)核销时自行校验，支付宝侧只做展示使用。
        /// </summary>
        /// <value>优惠门槛金额，表示只有当订单金额大于等于门槛金额时券才能使用。该字段为空时表示无门槛。  门槛金额的校验由服务商(商户)核销时自行校验，支付宝侧只做展示使用。</value>
        [DataMember(Name = "floor_amount", EmitDefaultValue = false)]
        public string FloorAmount { get; set; }

        /// <summary>
        /// Gets or Sets VoucherDeductThresholdInfo
        /// </summary>
        [DataMember(Name = "voucher_deduct_threshold_info", EmitDefaultValue = false)]
        public VoucherDeductThresholdInfo VoucherDeductThresholdInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExchangeVoucherInfo {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BizType: ").Append(BizType).Append("\n");
            sb.Append("  ExchangeGoodsInfo: ").Append(ExchangeGoodsInfo).Append("\n");
            sb.Append("  FloorAmount: ").Append(FloorAmount).Append("\n");
            sb.Append("  VoucherDeductThresholdInfo: ").Append(VoucherDeductThresholdInfo).Append("\n");
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
            return this.Equals(input as ExchangeVoucherInfo);
        }

        /// <summary>
        /// Returns true if ExchangeVoucherInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeVoucherInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeVoucherInfo input)
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
                    this.BizType == input.BizType ||
                    (this.BizType != null &&
                    this.BizType.Equals(input.BizType))
                ) && 
                (
                    this.ExchangeGoodsInfo == input.ExchangeGoodsInfo ||
                    (this.ExchangeGoodsInfo != null &&
                    this.ExchangeGoodsInfo.Equals(input.ExchangeGoodsInfo))
                ) && 
                (
                    this.FloorAmount == input.FloorAmount ||
                    (this.FloorAmount != null &&
                    this.FloorAmount.Equals(input.FloorAmount))
                ) && 
                (
                    this.VoucherDeductThresholdInfo == input.VoucherDeductThresholdInfo ||
                    (this.VoucherDeductThresholdInfo != null &&
                    this.VoucherDeductThresholdInfo.Equals(input.VoucherDeductThresholdInfo))
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
                if (this.BizType != null)
                {
                    hashCode = (hashCode * 59) + this.BizType.GetHashCode();
                }
                if (this.ExchangeGoodsInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExchangeGoodsInfo.GetHashCode();
                }
                if (this.FloorAmount != null)
                {
                    hashCode = (hashCode * 59) + this.FloorAmount.GetHashCode();
                }
                if (this.VoucherDeductThresholdInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherDeductThresholdInfo.GetHashCode();
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
