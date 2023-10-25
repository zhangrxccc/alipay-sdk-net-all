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
    /// AlipayFundTransPayResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundTransPayResponseModel")]
    public partial class AlipayFundTransPayResponseModel : IEquatable<AlipayFundTransPayResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundTransPayResponseModel" /> class.
        /// </summary>
        /// <param name="orderId">该笔转账在支付宝系统内部的单据ID.</param>
        /// <param name="outBizNo">商户端的唯一订单号.</param>
        /// <param name="payFundOrderId">支付宝支付资金流水号.</param>
        /// <param name="status">SUCCESS：支付成功；  FAIL：支付失败；  UNKNOWN：未知；建议通过查询确认最新状态.</param>
        /// <param name="transPayTime">订单支付时间，格式为yyyy-MM-dd HH:mm:ss.</param>
        public AlipayFundTransPayResponseModel(string orderId = default(string), string outBizNo = default(string), string payFundOrderId = default(string), string status = default(string), string transPayTime = default(string))
        {
            this.OrderId = orderId;
            this.OutBizNo = outBizNo;
            this.PayFundOrderId = payFundOrderId;
            this.Status = status;
            this.TransPayTime = transPayTime;
        }

        /// <summary>
        /// 该笔转账在支付宝系统内部的单据ID
        /// </summary>
        /// <value>该笔转账在支付宝系统内部的单据ID</value>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户端的唯一订单号
        /// </summary>
        /// <value>商户端的唯一订单号</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝支付资金流水号
        /// </summary>
        /// <value>支付宝支付资金流水号</value>
        [DataMember(Name = "pay_fund_order_id", EmitDefaultValue = false)]
        public string PayFundOrderId { get; set; }

        /// <summary>
        /// SUCCESS：支付成功；  FAIL：支付失败；  UNKNOWN：未知；建议通过查询确认最新状态
        /// </summary>
        /// <value>SUCCESS：支付成功；  FAIL：支付失败；  UNKNOWN：未知；建议通过查询确认最新状态</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 订单支付时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>订单支付时间，格式为yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "trans_pay_time", EmitDefaultValue = false)]
        public string TransPayTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundTransPayResponseModel {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  PayFundOrderId: ").Append(PayFundOrderId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TransPayTime: ").Append(TransPayTime).Append("\n");
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
            return this.Equals(input as AlipayFundTransPayResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundTransPayResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundTransPayResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundTransPayResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
                ) && 
                (
                    this.PayFundOrderId == input.PayFundOrderId ||
                    (this.PayFundOrderId != null &&
                    this.PayFundOrderId.Equals(input.PayFundOrderId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TransPayTime == input.TransPayTime ||
                    (this.TransPayTime != null &&
                    this.TransPayTime.Equals(input.TransPayTime))
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
                if (this.OrderId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
                }
                if (this.PayFundOrderId != null)
                {
                    hashCode = (hashCode * 59) + this.PayFundOrderId.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.TransPayTime != null)
                {
                    hashCode = (hashCode * 59) + this.TransPayTime.GetHashCode();
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
