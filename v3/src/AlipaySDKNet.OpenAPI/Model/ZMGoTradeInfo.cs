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
    /// ZMGoTradeInfo
    /// </summary>
    [DataContract(Name = "ZMGoTradeInfo")]
    public partial class ZMGoTradeInfo : IEquatable<ZMGoTradeInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZMGoTradeInfo" /> class.
        /// </summary>
        /// <param name="amount">用户和商户发生交易的交易单金额，单位元.</param>
        /// <param name="tradeNo">用户和商户发生交易的交易单号，仅在商户需要回传交易信息时传入。.</param>
        public ZMGoTradeInfo(string amount = default(string), string tradeNo = default(string))
        {
            this.Amount = amount;
            this.TradeNo = tradeNo;
        }

        /// <summary>
        /// 用户和商户发生交易的交易单金额，单位元
        /// </summary>
        /// <value>用户和商户发生交易的交易单金额，单位元</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 用户和商户发生交易的交易单号，仅在商户需要回传交易信息时传入。
        /// </summary>
        /// <value>用户和商户发生交易的交易单号，仅在商户需要回传交易信息时传入。</value>
        [DataMember(Name = "trade_no", EmitDefaultValue = false)]
        public string TradeNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZMGoTradeInfo {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as ZMGoTradeInfo);
        }

        /// <summary>
        /// Returns true if ZMGoTradeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ZMGoTradeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZMGoTradeInfo input)
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
