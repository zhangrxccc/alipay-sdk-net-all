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
    /// CustomsDeclareRecordInfo
    /// </summary>
    [DataContract(Name = "CustomsDeclareRecordInfo")]
    public partial class CustomsDeclareRecordInfo : IEquatable<CustomsDeclareRecordInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomsDeclareRecordInfo" /> class.
        /// </summary>
        /// <param name="alipayDeclareNo">支付宝报关流水号。.</param>
        /// <param name="amount">报关金额，单位为人民币“元”，精确到小数点后2位。.</param>
        /// <param name="customsPlace">此记录所报关的海关编号，参见“ &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/pre-open/01x3kh#%E6%B5%B7%E5%85%B3%E7%BC%96%E5%8F%B7\&quot;&gt;海关编号&lt;/a&gt;”。.</param>
        /// <param name="customsResultCode">发起报关后，海关返回回执中的结果码。目前只有总署的报关，并且总署回执接收成功的请求才会返回此参数  2：电子口岸申报中  3：发送海关成功  4：发送海关失败  100：海关退单  399：海关审结  小于0的数字：表示处理异常回执     注意：  支付宝原样返回海关返回的数据，参数值以海关的定义为准。.</param>
        /// <param name="customsResultInfo">发起报关后，海关返回回执中的结果描述信息。目前只有总署报关，并且总署成功返回回执的时候会有此值.</param>
        /// <param name="customsResultReturnTime">发起报关后，海关返回回执的时间，格式为：yyyyMMddHHmmss。目前只有总署报关，并且总署成功返回回执的时候才会有此参数。.</param>
        /// <param name="isSplit">T: 拆单；F：非拆单。当请求没有拆单或者请求传入的is_split&#x3D;F时，不会返回此参数。.</param>
        /// <param name="lastModifiedTime">报关记录状态最后更新时间.</param>
        /// <param name="memo">备注说明.</param>
        /// <param name="merchantCustomsCode">商户在海关备案的编号。.</param>
        /// <param name="merchantCustomsName">商户海关备案名称.</param>
        /// <param name="outRequestNo">报关请求号。商户端报关请求号，对应入参中的某条报关请求号。.</param>
        /// <param name="status">该报关单当前的状态：  - ws等待发送海关  - sending已提交发送海关  - succ 海关返回受理成功.</param>
        /// <param name="subOutBizNo">拆单子订单号。如果报关请求没有请求拆单则不会返回此参数。.</param>
        /// <param name="tradeNo">支付宝推送到海关的支付单据号。针对拆单的报关，这个单据号不等于支付宝原始交易号。.</param>
        public CustomsDeclareRecordInfo(string alipayDeclareNo = default(string), string amount = default(string), string customsPlace = default(string), string customsResultCode = default(string), string customsResultInfo = default(string), string customsResultReturnTime = default(string), string isSplit = default(string), string lastModifiedTime = default(string), string memo = default(string), string merchantCustomsCode = default(string), string merchantCustomsName = default(string), string outRequestNo = default(string), string status = default(string), string subOutBizNo = default(string), string tradeNo = default(string))
        {
            this.AlipayDeclareNo = alipayDeclareNo;
            this.Amount = amount;
            this.CustomsPlace = customsPlace;
            this.CustomsResultCode = customsResultCode;
            this.CustomsResultInfo = customsResultInfo;
            this.CustomsResultReturnTime = customsResultReturnTime;
            this.IsSplit = isSplit;
            this.LastModifiedTime = lastModifiedTime;
            this.Memo = memo;
            this.MerchantCustomsCode = merchantCustomsCode;
            this.MerchantCustomsName = merchantCustomsName;
            this.OutRequestNo = outRequestNo;
            this.Status = status;
            this.SubOutBizNo = subOutBizNo;
            this.TradeNo = tradeNo;
        }

        /// <summary>
        /// 支付宝报关流水号。
        /// </summary>
        /// <value>支付宝报关流水号。</value>
        [DataMember(Name = "alipay_declare_no", EmitDefaultValue = false)]
        public string AlipayDeclareNo { get; set; }

        /// <summary>
        /// 报关金额，单位为人民币“元”，精确到小数点后2位。
        /// </summary>
        /// <value>报关金额，单位为人民币“元”，精确到小数点后2位。</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 此记录所报关的海关编号，参见“ &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/pre-open/01x3kh#%E6%B5%B7%E5%85%B3%E7%BC%96%E5%8F%B7\&quot;&gt;海关编号&lt;/a&gt;”。
        /// </summary>
        /// <value>此记录所报关的海关编号，参见“ &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/pre-open/01x3kh#%E6%B5%B7%E5%85%B3%E7%BC%96%E5%8F%B7\&quot;&gt;海关编号&lt;/a&gt;”。</value>
        [DataMember(Name = "customs_place", EmitDefaultValue = false)]
        public string CustomsPlace { get; set; }

        /// <summary>
        /// 发起报关后，海关返回回执中的结果码。目前只有总署的报关，并且总署回执接收成功的请求才会返回此参数  2：电子口岸申报中  3：发送海关成功  4：发送海关失败  100：海关退单  399：海关审结  小于0的数字：表示处理异常回执     注意：  支付宝原样返回海关返回的数据，参数值以海关的定义为准。
        /// </summary>
        /// <value>发起报关后，海关返回回执中的结果码。目前只有总署的报关，并且总署回执接收成功的请求才会返回此参数  2：电子口岸申报中  3：发送海关成功  4：发送海关失败  100：海关退单  399：海关审结  小于0的数字：表示处理异常回执     注意：  支付宝原样返回海关返回的数据，参数值以海关的定义为准。</value>
        [DataMember(Name = "customs_result_code", EmitDefaultValue = false)]
        public string CustomsResultCode { get; set; }

        /// <summary>
        /// 发起报关后，海关返回回执中的结果描述信息。目前只有总署报关，并且总署成功返回回执的时候会有此值
        /// </summary>
        /// <value>发起报关后，海关返回回执中的结果描述信息。目前只有总署报关，并且总署成功返回回执的时候会有此值</value>
        [DataMember(Name = "customs_result_info", EmitDefaultValue = false)]
        public string CustomsResultInfo { get; set; }

        /// <summary>
        /// 发起报关后，海关返回回执的时间，格式为：yyyyMMddHHmmss。目前只有总署报关，并且总署成功返回回执的时候才会有此参数。
        /// </summary>
        /// <value>发起报关后，海关返回回执的时间，格式为：yyyyMMddHHmmss。目前只有总署报关，并且总署成功返回回执的时候才会有此参数。</value>
        [DataMember(Name = "customs_result_return_time", EmitDefaultValue = false)]
        public string CustomsResultReturnTime { get; set; }

        /// <summary>
        /// T: 拆单；F：非拆单。当请求没有拆单或者请求传入的is_split&#x3D;F时，不会返回此参数。
        /// </summary>
        /// <value>T: 拆单；F：非拆单。当请求没有拆单或者请求传入的is_split&#x3D;F时，不会返回此参数。</value>
        [DataMember(Name = "is_split", EmitDefaultValue = false)]
        public string IsSplit { get; set; }

        /// <summary>
        /// 报关记录状态最后更新时间
        /// </summary>
        /// <value>报关记录状态最后更新时间</value>
        [DataMember(Name = "last_modified_time", EmitDefaultValue = false)]
        public string LastModifiedTime { get; set; }

        /// <summary>
        /// 备注说明
        /// </summary>
        /// <value>备注说明</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// 商户在海关备案的编号。
        /// </summary>
        /// <value>商户在海关备案的编号。</value>
        [DataMember(Name = "merchant_customs_code", EmitDefaultValue = false)]
        public string MerchantCustomsCode { get; set; }

        /// <summary>
        /// 商户海关备案名称
        /// </summary>
        /// <value>商户海关备案名称</value>
        [DataMember(Name = "merchant_customs_name", EmitDefaultValue = false)]
        public string MerchantCustomsName { get; set; }

        /// <summary>
        /// 报关请求号。商户端报关请求号，对应入参中的某条报关请求号。
        /// </summary>
        /// <value>报关请求号。商户端报关请求号，对应入参中的某条报关请求号。</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 该报关单当前的状态：  - ws等待发送海关  - sending已提交发送海关  - succ 海关返回受理成功
        /// </summary>
        /// <value>该报关单当前的状态：  - ws等待发送海关  - sending已提交发送海关  - succ 海关返回受理成功</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 拆单子订单号。如果报关请求没有请求拆单则不会返回此参数。
        /// </summary>
        /// <value>拆单子订单号。如果报关请求没有请求拆单则不会返回此参数。</value>
        [DataMember(Name = "sub_out_biz_no", EmitDefaultValue = false)]
        public string SubOutBizNo { get; set; }

        /// <summary>
        /// 支付宝推送到海关的支付单据号。针对拆单的报关，这个单据号不等于支付宝原始交易号。
        /// </summary>
        /// <value>支付宝推送到海关的支付单据号。针对拆单的报关，这个单据号不等于支付宝原始交易号。</value>
        [DataMember(Name = "trade_no", EmitDefaultValue = false)]
        public string TradeNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomsDeclareRecordInfo {\n");
            sb.Append("  AlipayDeclareNo: ").Append(AlipayDeclareNo).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  CustomsPlace: ").Append(CustomsPlace).Append("\n");
            sb.Append("  CustomsResultCode: ").Append(CustomsResultCode).Append("\n");
            sb.Append("  CustomsResultInfo: ").Append(CustomsResultInfo).Append("\n");
            sb.Append("  CustomsResultReturnTime: ").Append(CustomsResultReturnTime).Append("\n");
            sb.Append("  IsSplit: ").Append(IsSplit).Append("\n");
            sb.Append("  LastModifiedTime: ").Append(LastModifiedTime).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  MerchantCustomsCode: ").Append(MerchantCustomsCode).Append("\n");
            sb.Append("  MerchantCustomsName: ").Append(MerchantCustomsName).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubOutBizNo: ").Append(SubOutBizNo).Append("\n");
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
            return this.Equals(input as CustomsDeclareRecordInfo);
        }

        /// <summary>
        /// Returns true if CustomsDeclareRecordInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomsDeclareRecordInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomsDeclareRecordInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AlipayDeclareNo == input.AlipayDeclareNo ||
                    (this.AlipayDeclareNo != null &&
                    this.AlipayDeclareNo.Equals(input.AlipayDeclareNo))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.CustomsPlace == input.CustomsPlace ||
                    (this.CustomsPlace != null &&
                    this.CustomsPlace.Equals(input.CustomsPlace))
                ) && 
                (
                    this.CustomsResultCode == input.CustomsResultCode ||
                    (this.CustomsResultCode != null &&
                    this.CustomsResultCode.Equals(input.CustomsResultCode))
                ) && 
                (
                    this.CustomsResultInfo == input.CustomsResultInfo ||
                    (this.CustomsResultInfo != null &&
                    this.CustomsResultInfo.Equals(input.CustomsResultInfo))
                ) && 
                (
                    this.CustomsResultReturnTime == input.CustomsResultReturnTime ||
                    (this.CustomsResultReturnTime != null &&
                    this.CustomsResultReturnTime.Equals(input.CustomsResultReturnTime))
                ) && 
                (
                    this.IsSplit == input.IsSplit ||
                    (this.IsSplit != null &&
                    this.IsSplit.Equals(input.IsSplit))
                ) && 
                (
                    this.LastModifiedTime == input.LastModifiedTime ||
                    (this.LastModifiedTime != null &&
                    this.LastModifiedTime.Equals(input.LastModifiedTime))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.MerchantCustomsCode == input.MerchantCustomsCode ||
                    (this.MerchantCustomsCode != null &&
                    this.MerchantCustomsCode.Equals(input.MerchantCustomsCode))
                ) && 
                (
                    this.MerchantCustomsName == input.MerchantCustomsName ||
                    (this.MerchantCustomsName != null &&
                    this.MerchantCustomsName.Equals(input.MerchantCustomsName))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SubOutBizNo == input.SubOutBizNo ||
                    (this.SubOutBizNo != null &&
                    this.SubOutBizNo.Equals(input.SubOutBizNo))
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
                if (this.AlipayDeclareNo != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayDeclareNo.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.CustomsPlace != null)
                {
                    hashCode = (hashCode * 59) + this.CustomsPlace.GetHashCode();
                }
                if (this.CustomsResultCode != null)
                {
                    hashCode = (hashCode * 59) + this.CustomsResultCode.GetHashCode();
                }
                if (this.CustomsResultInfo != null)
                {
                    hashCode = (hashCode * 59) + this.CustomsResultInfo.GetHashCode();
                }
                if (this.CustomsResultReturnTime != null)
                {
                    hashCode = (hashCode * 59) + this.CustomsResultReturnTime.GetHashCode();
                }
                if (this.IsSplit != null)
                {
                    hashCode = (hashCode * 59) + this.IsSplit.GetHashCode();
                }
                if (this.LastModifiedTime != null)
                {
                    hashCode = (hashCode * 59) + this.LastModifiedTime.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.MerchantCustomsCode != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantCustomsCode.GetHashCode();
                }
                if (this.MerchantCustomsName != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantCustomsName.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.SubOutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.SubOutBizNo.GetHashCode();
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
