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
    /// ChargeInfo
    /// </summary>
    [DataContract(Name = "ChargeInfo")]
    public partial class ChargeInfo : IEquatable<ChargeInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeInfo" /> class.
        /// </summary>
        /// <param name="chargeFee">实收费用.</param>
        /// <param name="chargeType">收单手续费trade，花呗分期手续hbfq，其他手续费charge.</param>
        /// <param name="isRatingOnSwitch">是否合约指定收费账号出资，值为\&quot;Y\&quot;或\&quot;N\&quot;.</param>
        /// <param name="isRatingOnTradeReceiver">是否收款账号出资，值为\&quot;Y\&quot;或\&quot;N\&quot;.</param>
        /// <param name="originalChargeFee">原始费用.</param>
        /// <param name="subFeeDetailList">组合支付收费明细.</param>
        /// <param name="switchFeeRate">签约费率.</param>
        public ChargeInfo(string chargeFee = default(string), string chargeType = default(string), string isRatingOnSwitch = default(string), string isRatingOnTradeReceiver = default(string), string originalChargeFee = default(string), List<SubFee> subFeeDetailList = default(List<SubFee>), string switchFeeRate = default(string))
        {
            this.ChargeFee = chargeFee;
            this.ChargeType = chargeType;
            this.IsRatingOnSwitch = isRatingOnSwitch;
            this.IsRatingOnTradeReceiver = isRatingOnTradeReceiver;
            this.OriginalChargeFee = originalChargeFee;
            this.SubFeeDetailList = subFeeDetailList;
            this.SwitchFeeRate = switchFeeRate;
        }

        /// <summary>
        /// 实收费用
        /// </summary>
        /// <value>实收费用</value>
        [DataMember(Name = "charge_fee", EmitDefaultValue = false)]
        public string ChargeFee { get; set; }

        /// <summary>
        /// 收单手续费trade，花呗分期手续hbfq，其他手续费charge
        /// </summary>
        /// <value>收单手续费trade，花呗分期手续hbfq，其他手续费charge</value>
        [DataMember(Name = "charge_type", EmitDefaultValue = false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// 是否合约指定收费账号出资，值为\&quot;Y\&quot;或\&quot;N\&quot;
        /// </summary>
        /// <value>是否合约指定收费账号出资，值为\&quot;Y\&quot;或\&quot;N\&quot;</value>
        [DataMember(Name = "is_rating_on_switch", EmitDefaultValue = false)]
        public string IsRatingOnSwitch { get; set; }

        /// <summary>
        /// 是否收款账号出资，值为\&quot;Y\&quot;或\&quot;N\&quot;
        /// </summary>
        /// <value>是否收款账号出资，值为\&quot;Y\&quot;或\&quot;N\&quot;</value>
        [DataMember(Name = "is_rating_on_trade_receiver", EmitDefaultValue = false)]
        public string IsRatingOnTradeReceiver { get; set; }

        /// <summary>
        /// 原始费用
        /// </summary>
        /// <value>原始费用</value>
        [DataMember(Name = "original_charge_fee", EmitDefaultValue = false)]
        public string OriginalChargeFee { get; set; }

        /// <summary>
        /// 组合支付收费明细
        /// </summary>
        /// <value>组合支付收费明细</value>
        [DataMember(Name = "sub_fee_detail_list", EmitDefaultValue = false)]
        public List<SubFee> SubFeeDetailList { get; set; }

        /// <summary>
        /// 签约费率
        /// </summary>
        /// <value>签约费率</value>
        [DataMember(Name = "switch_fee_rate", EmitDefaultValue = false)]
        public string SwitchFeeRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChargeInfo {\n");
            sb.Append("  ChargeFee: ").Append(ChargeFee).Append("\n");
            sb.Append("  ChargeType: ").Append(ChargeType).Append("\n");
            sb.Append("  IsRatingOnSwitch: ").Append(IsRatingOnSwitch).Append("\n");
            sb.Append("  IsRatingOnTradeReceiver: ").Append(IsRatingOnTradeReceiver).Append("\n");
            sb.Append("  OriginalChargeFee: ").Append(OriginalChargeFee).Append("\n");
            sb.Append("  SubFeeDetailList: ").Append(SubFeeDetailList).Append("\n");
            sb.Append("  SwitchFeeRate: ").Append(SwitchFeeRate).Append("\n");
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
            return this.Equals(input as ChargeInfo);
        }

        /// <summary>
        /// Returns true if ChargeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ChargeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ChargeFee == input.ChargeFee ||
                    (this.ChargeFee != null &&
                    this.ChargeFee.Equals(input.ChargeFee))
                ) && 
                (
                    this.ChargeType == input.ChargeType ||
                    (this.ChargeType != null &&
                    this.ChargeType.Equals(input.ChargeType))
                ) && 
                (
                    this.IsRatingOnSwitch == input.IsRatingOnSwitch ||
                    (this.IsRatingOnSwitch != null &&
                    this.IsRatingOnSwitch.Equals(input.IsRatingOnSwitch))
                ) && 
                (
                    this.IsRatingOnTradeReceiver == input.IsRatingOnTradeReceiver ||
                    (this.IsRatingOnTradeReceiver != null &&
                    this.IsRatingOnTradeReceiver.Equals(input.IsRatingOnTradeReceiver))
                ) && 
                (
                    this.OriginalChargeFee == input.OriginalChargeFee ||
                    (this.OriginalChargeFee != null &&
                    this.OriginalChargeFee.Equals(input.OriginalChargeFee))
                ) && 
                (
                    this.SubFeeDetailList == input.SubFeeDetailList ||
                    this.SubFeeDetailList != null &&
                    input.SubFeeDetailList != null &&
                    this.SubFeeDetailList.SequenceEqual(input.SubFeeDetailList)
                ) && 
                (
                    this.SwitchFeeRate == input.SwitchFeeRate ||
                    (this.SwitchFeeRate != null &&
                    this.SwitchFeeRate.Equals(input.SwitchFeeRate))
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
                if (this.ChargeFee != null)
                {
                    hashCode = (hashCode * 59) + this.ChargeFee.GetHashCode();
                }
                if (this.ChargeType != null)
                {
                    hashCode = (hashCode * 59) + this.ChargeType.GetHashCode();
                }
                if (this.IsRatingOnSwitch != null)
                {
                    hashCode = (hashCode * 59) + this.IsRatingOnSwitch.GetHashCode();
                }
                if (this.IsRatingOnTradeReceiver != null)
                {
                    hashCode = (hashCode * 59) + this.IsRatingOnTradeReceiver.GetHashCode();
                }
                if (this.OriginalChargeFee != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalChargeFee.GetHashCode();
                }
                if (this.SubFeeDetailList != null)
                {
                    hashCode = (hashCode * 59) + this.SubFeeDetailList.GetHashCode();
                }
                if (this.SwitchFeeRate != null)
                {
                    hashCode = (hashCode * 59) + this.SwitchFeeRate.GetHashCode();
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
