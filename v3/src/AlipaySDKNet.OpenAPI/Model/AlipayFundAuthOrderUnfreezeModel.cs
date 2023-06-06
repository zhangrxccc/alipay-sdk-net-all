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
    /// AlipayFundAuthOrderUnfreezeModel
    /// </summary>
    [DataContract(Name = "AlipayFundAuthOrderUnfreezeModel")]
    public partial class AlipayFundAuthOrderUnfreezeModel : IEquatable<AlipayFundAuthOrderUnfreezeModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundAuthOrderUnfreezeModel" /> class.
        /// </summary>
        /// <param name="amount">本次操作解冻的金额，单位为：元（人民币），精确到小数点后两位。 取值范围：[0.01,100000000.00].</param>
        /// <param name="authNo">支付宝资金授权订单号。.</param>
        /// <param name="extraParam">解冻扩展信息。map&lt;string, string&gt;的json格式，目前支持如下key： unfreezeBizInfo：由芝麻消费，当前支持value如下： \&quot;bizComplete\&quot;:\&quot;true\&quot;——标识本次解冻用户已履约，true表示信用单履约完结.</param>
        /// <param name="notifyUrl">通知地址.</param>
        /// <param name="outRequestNo">解冻请求流水号。 如果是针对同一笔授权单不同的解冻请求，如第一次解冻1元，第二次解冻2元，则解冻请求流水号必须不重复； 如果是针对同一笔解冻请求的多次发起，则需要保证每次发起，解冻请求流水号和解冻金额都相同.</param>
        /// <param name="remark">商户对本次解冻操作的附言描述.</param>
        public AlipayFundAuthOrderUnfreezeModel(string amount = default(string), string authNo = default(string), string extraParam = default(string), string notifyUrl = default(string), string outRequestNo = default(string), string remark = default(string))
        {
            this.Amount = amount;
            this.AuthNo = authNo;
            this.ExtraParam = extraParam;
            this.NotifyUrl = notifyUrl;
            this.OutRequestNo = outRequestNo;
            this.Remark = remark;
        }

        /// <summary>
        /// 本次操作解冻的金额，单位为：元（人民币），精确到小数点后两位。 取值范围：[0.01,100000000.00]
        /// </summary>
        /// <value>本次操作解冻的金额，单位为：元（人民币），精确到小数点后两位。 取值范围：[0.01,100000000.00]</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 支付宝资金授权订单号。
        /// </summary>
        /// <value>支付宝资金授权订单号。</value>
        [DataMember(Name = "auth_no", EmitDefaultValue = false)]
        public string AuthNo { get; set; }

        /// <summary>
        /// 解冻扩展信息。map&lt;string, string&gt;的json格式，目前支持如下key： unfreezeBizInfo：由芝麻消费，当前支持value如下： \&quot;bizComplete\&quot;:\&quot;true\&quot;——标识本次解冻用户已履约，true表示信用单履约完结
        /// </summary>
        /// <value>解冻扩展信息。map&lt;string, string&gt;的json格式，目前支持如下key： unfreezeBizInfo：由芝麻消费，当前支持value如下： \&quot;bizComplete\&quot;:\&quot;true\&quot;——标识本次解冻用户已履约，true表示信用单履约完结</value>
        [DataMember(Name = "extra_param", EmitDefaultValue = false)]
        public string ExtraParam { get; set; }

        /// <summary>
        /// 通知地址
        /// </summary>
        /// <value>通知地址</value>
        [DataMember(Name = "notify_url", EmitDefaultValue = false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 解冻请求流水号。 如果是针对同一笔授权单不同的解冻请求，如第一次解冻1元，第二次解冻2元，则解冻请求流水号必须不重复； 如果是针对同一笔解冻请求的多次发起，则需要保证每次发起，解冻请求流水号和解冻金额都相同
        /// </summary>
        /// <value>解冻请求流水号。 如果是针对同一笔授权单不同的解冻请求，如第一次解冻1元，第二次解冻2元，则解冻请求流水号必须不重复； 如果是针对同一笔解冻请求的多次发起，则需要保证每次发起，解冻请求流水号和解冻金额都相同</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户对本次解冻操作的附言描述
        /// </summary>
        /// <value>商户对本次解冻操作的附言描述</value>
        [DataMember(Name = "remark", EmitDefaultValue = false)]
        public string Remark { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundAuthOrderUnfreezeModel {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AuthNo: ").Append(AuthNo).Append("\n");
            sb.Append("  ExtraParam: ").Append(ExtraParam).Append("\n");
            sb.Append("  NotifyUrl: ").Append(NotifyUrl).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  Remark: ").Append(Remark).Append("\n");
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
            return this.Equals(input as AlipayFundAuthOrderUnfreezeModel);
        }

        /// <summary>
        /// Returns true if AlipayFundAuthOrderUnfreezeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundAuthOrderUnfreezeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundAuthOrderUnfreezeModel input)
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
                    this.AuthNo == input.AuthNo ||
                    (this.AuthNo != null &&
                    this.AuthNo.Equals(input.AuthNo))
                ) && 
                (
                    this.ExtraParam == input.ExtraParam ||
                    (this.ExtraParam != null &&
                    this.ExtraParam.Equals(input.ExtraParam))
                ) && 
                (
                    this.NotifyUrl == input.NotifyUrl ||
                    (this.NotifyUrl != null &&
                    this.NotifyUrl.Equals(input.NotifyUrl))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.Remark == input.Remark ||
                    (this.Remark != null &&
                    this.Remark.Equals(input.Remark))
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
                if (this.AuthNo != null)
                {
                    hashCode = (hashCode * 59) + this.AuthNo.GetHashCode();
                }
                if (this.ExtraParam != null)
                {
                    hashCode = (hashCode * 59) + this.ExtraParam.GetHashCode();
                }
                if (this.NotifyUrl != null)
                {
                    hashCode = (hashCode * 59) + this.NotifyUrl.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.Remark != null)
                {
                    hashCode = (hashCode * 59) + this.Remark.GetHashCode();
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
