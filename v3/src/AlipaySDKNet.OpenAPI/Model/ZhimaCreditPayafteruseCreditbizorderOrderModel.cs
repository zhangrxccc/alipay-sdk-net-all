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
    /// ZhimaCreditPayafteruseCreditbizorderOrderModel
    /// </summary>
    [DataContract(Name = "ZhimaCreditPayafteruseCreditbizorderOrderModel")]
    public partial class ZhimaCreditPayafteruseCreditbizorderOrderModel : IEquatable<ZhimaCreditPayafteruseCreditbizorderOrderModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCreditPayafteruseCreditbizorderOrderModel" /> class.
        /// </summary>
        /// <param name="amountType">只有当传递了order_amount时，该参数才有意义； 1）该参数不传时，默认为ORDER_AMOUNT。 2）传ORDER_AMOUNT时，表示order_amount传入的金额为后付金额，在发起扣款时，最大扣款支付金额为order_amount传入的值； 3）传RISK_AMOUNT时，表示ORDER_AMOUNT传入的金额为风险预估金额，在发起扣款时，最大扣款支付金额为商户签约时约定的上限额度。.</param>
        /// <param name="body">订单描述.</param>
        /// <param name="categoryId">芝麻外部类目.</param>
        /// <param name="creditAgreementId">芝麻开通协议号.</param>
        /// <param name="extendParams">业务扩展参数.</param>
        /// <param name="orderAmount">订单金额，该金额为当前订单扣款的累计最大额度。例如，下单时传递10.00，则扣款时最大支付金额为10元。若该参数不传，则默认使用商户签约时约定的上限额度。芝麻速办业务场景（极速回收、极速返利、极速退款等）商户请求时，order_amount必传，且amount_type类型需传递ORDER_AMOUNT。.</param>
        /// <param name="outOrderNo">商户外部订单号，保证不重复.</param>
        /// <param name="productCode">产品码，不传默认为CREDIT_PAY_AFTER_USE.</param>
        /// <param name="subject">订单标题。 注意：不可使用特殊字符，如 /，&#x3D;，&amp; 等。.</param>
        public ZhimaCreditPayafteruseCreditbizorderOrderModel(string amountType = default(string), string body = default(string), string categoryId = default(string), string creditAgreementId = default(string), string extendParams = default(string), string orderAmount = default(string), string outOrderNo = default(string), string productCode = default(string), string subject = default(string))
        {
            this.AmountType = amountType;
            this.Body = body;
            this.CategoryId = categoryId;
            this.CreditAgreementId = creditAgreementId;
            this.ExtendParams = extendParams;
            this.OrderAmount = orderAmount;
            this.OutOrderNo = outOrderNo;
            this.ProductCode = productCode;
            this.Subject = subject;
        }

        /// <summary>
        /// 只有当传递了order_amount时，该参数才有意义； 1）该参数不传时，默认为ORDER_AMOUNT。 2）传ORDER_AMOUNT时，表示order_amount传入的金额为后付金额，在发起扣款时，最大扣款支付金额为order_amount传入的值； 3）传RISK_AMOUNT时，表示ORDER_AMOUNT传入的金额为风险预估金额，在发起扣款时，最大扣款支付金额为商户签约时约定的上限额度。
        /// </summary>
        /// <value>只有当传递了order_amount时，该参数才有意义； 1）该参数不传时，默认为ORDER_AMOUNT。 2）传ORDER_AMOUNT时，表示order_amount传入的金额为后付金额，在发起扣款时，最大扣款支付金额为order_amount传入的值； 3）传RISK_AMOUNT时，表示ORDER_AMOUNT传入的金额为风险预估金额，在发起扣款时，最大扣款支付金额为商户签约时约定的上限额度。</value>
        [DataMember(Name = "amount_type", EmitDefaultValue = false)]
        public string AmountType { get; set; }

        /// <summary>
        /// 订单描述
        /// </summary>
        /// <value>订单描述</value>
        [DataMember(Name = "body", EmitDefaultValue = false)]
        public string Body { get; set; }

        /// <summary>
        /// 芝麻外部类目
        /// </summary>
        /// <value>芝麻外部类目</value>
        [DataMember(Name = "category_id", EmitDefaultValue = false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// 芝麻开通协议号
        /// </summary>
        /// <value>芝麻开通协议号</value>
        [DataMember(Name = "credit_agreement_id", EmitDefaultValue = false)]
        public string CreditAgreementId { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        /// <value>业务扩展参数</value>
        [DataMember(Name = "extend_params", EmitDefaultValue = false)]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 订单金额，该金额为当前订单扣款的累计最大额度。例如，下单时传递10.00，则扣款时最大支付金额为10元。若该参数不传，则默认使用商户签约时约定的上限额度。芝麻速办业务场景（极速回收、极速返利、极速退款等）商户请求时，order_amount必传，且amount_type类型需传递ORDER_AMOUNT。
        /// </summary>
        /// <value>订单金额，该金额为当前订单扣款的累计最大额度。例如，下单时传递10.00，则扣款时最大支付金额为10元。若该参数不传，则默认使用商户签约时约定的上限额度。芝麻速办业务场景（极速回收、极速返利、极速退款等）商户请求时，order_amount必传，且amount_type类型需传递ORDER_AMOUNT。</value>
        [DataMember(Name = "order_amount", EmitDefaultValue = false)]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 商户外部订单号，保证不重复
        /// </summary>
        /// <value>商户外部订单号，保证不重复</value>
        [DataMember(Name = "out_order_no", EmitDefaultValue = false)]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 产品码，不传默认为CREDIT_PAY_AFTER_USE
        /// </summary>
        /// <value>产品码，不传默认为CREDIT_PAY_AFTER_USE</value>
        [DataMember(Name = "product_code", EmitDefaultValue = false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// 订单标题。 注意：不可使用特殊字符，如 /，&#x3D;，&amp; 等。
        /// </summary>
        /// <value>订单标题。 注意：不可使用特殊字符，如 /，&#x3D;，&amp; 等。</value>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZhimaCreditPayafteruseCreditbizorderOrderModel {\n");
            sb.Append("  AmountType: ").Append(AmountType).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  CreditAgreementId: ").Append(CreditAgreementId).Append("\n");
            sb.Append("  ExtendParams: ").Append(ExtendParams).Append("\n");
            sb.Append("  OrderAmount: ").Append(OrderAmount).Append("\n");
            sb.Append("  OutOrderNo: ").Append(OutOrderNo).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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
            return this.Equals(input as ZhimaCreditPayafteruseCreditbizorderOrderModel);
        }

        /// <summary>
        /// Returns true if ZhimaCreditPayafteruseCreditbizorderOrderModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaCreditPayafteruseCreditbizorderOrderModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaCreditPayafteruseCreditbizorderOrderModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AmountType == input.AmountType ||
                    (this.AmountType != null &&
                    this.AmountType.Equals(input.AmountType))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.CategoryId == input.CategoryId ||
                    (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) && 
                (
                    this.CreditAgreementId == input.CreditAgreementId ||
                    (this.CreditAgreementId != null &&
                    this.CreditAgreementId.Equals(input.CreditAgreementId))
                ) && 
                (
                    this.ExtendParams == input.ExtendParams ||
                    (this.ExtendParams != null &&
                    this.ExtendParams.Equals(input.ExtendParams))
                ) && 
                (
                    this.OrderAmount == input.OrderAmount ||
                    (this.OrderAmount != null &&
                    this.OrderAmount.Equals(input.OrderAmount))
                ) && 
                (
                    this.OutOrderNo == input.OutOrderNo ||
                    (this.OutOrderNo != null &&
                    this.OutOrderNo.Equals(input.OutOrderNo))
                ) && 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
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
                if (this.AmountType != null)
                {
                    hashCode = (hashCode * 59) + this.AmountType.GetHashCode();
                }
                if (this.Body != null)
                {
                    hashCode = (hashCode * 59) + this.Body.GetHashCode();
                }
                if (this.CategoryId != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryId.GetHashCode();
                }
                if (this.CreditAgreementId != null)
                {
                    hashCode = (hashCode * 59) + this.CreditAgreementId.GetHashCode();
                }
                if (this.ExtendParams != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendParams.GetHashCode();
                }
                if (this.OrderAmount != null)
                {
                    hashCode = (hashCode * 59) + this.OrderAmount.GetHashCode();
                }
                if (this.OutOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutOrderNo.GetHashCode();
                }
                if (this.ProductCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProductCode.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
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
