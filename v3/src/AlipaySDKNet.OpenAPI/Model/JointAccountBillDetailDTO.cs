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
    /// JointAccountBillDetailDTO
    /// </summary>
    [DataContract(Name = "JointAccountBillDetailDTO")]
    public partial class JointAccountBillDetailDTO : IEquatable<JointAccountBillDetailDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JointAccountBillDetailDTO" /> class.
        /// </summary>
        /// <param name="accountId">共同账户ID.</param>
        /// <param name="amount">消费金额.</param>
        /// <param name="billNo">账单业务号.</param>
        /// <param name="bizDate">业务时间.</param>
        /// <param name="bizNo">订单号.</param>
        /// <param name="inOut">1-退款，2-支付.</param>
        /// <param name="openId">共同账户消费的成员openid.</param>
        /// <param name="outTradeNo">外部交易单号，正向支付为外部交易单号，逆向退款是为外部退款单号.</param>
        /// <param name="sellerFullName">间连商户显示二级商户全名，直连、直付通则显示一级商户全名。企业商户该字段不脱敏，非企业商户该字段会脱敏.</param>
        /// <param name="sellerLogonId">收款方登录号信息。间连商户显示二级商户的登录号信息；直连、直付通显示一级商户的登录号信息；该字段脱敏.</param>
        /// <param name="title">账单标题.</param>
        /// <param name="userId">共同账户消费的成员ID.</param>
        public JointAccountBillDetailDTO(string accountId = default(string), string amount = default(string), string billNo = default(string), string bizDate = default(string), string bizNo = default(string), string inOut = default(string), string openId = default(string), string outTradeNo = default(string), string sellerFullName = default(string), string sellerLogonId = default(string), string title = default(string), string userId = default(string))
        {
            this.AccountId = accountId;
            this.Amount = amount;
            this.BillNo = billNo;
            this.BizDate = bizDate;
            this.BizNo = bizNo;
            this.InOut = inOut;
            this.OpenId = openId;
            this.OutTradeNo = outTradeNo;
            this.SellerFullName = sellerFullName;
            this.SellerLogonId = sellerLogonId;
            this.Title = title;
            this.UserId = userId;
        }

        /// <summary>
        /// 共同账户ID
        /// </summary>
        /// <value>共同账户ID</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 消费金额
        /// </summary>
        /// <value>消费金额</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 账单业务号
        /// </summary>
        /// <value>账单业务号</value>
        [DataMember(Name = "bill_no", EmitDefaultValue = false)]
        public string BillNo { get; set; }

        /// <summary>
        /// 业务时间
        /// </summary>
        /// <value>业务时间</value>
        [DataMember(Name = "biz_date", EmitDefaultValue = false)]
        public string BizDate { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        /// <value>订单号</value>
        [DataMember(Name = "biz_no", EmitDefaultValue = false)]
        public string BizNo { get; set; }

        /// <summary>
        /// 1-退款，2-支付
        /// </summary>
        /// <value>1-退款，2-支付</value>
        [DataMember(Name = "in_out", EmitDefaultValue = false)]
        public string InOut { get; set; }

        /// <summary>
        /// 共同账户消费的成员openid
        /// </summary>
        /// <value>共同账户消费的成员openid</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部交易单号，正向支付为外部交易单号，逆向退款是为外部退款单号
        /// </summary>
        /// <value>外部交易单号，正向支付为外部交易单号，逆向退款是为外部退款单号</value>
        [DataMember(Name = "out_trade_no", EmitDefaultValue = false)]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 间连商户显示二级商户全名，直连、直付通则显示一级商户全名。企业商户该字段不脱敏，非企业商户该字段会脱敏
        /// </summary>
        /// <value>间连商户显示二级商户全名，直连、直付通则显示一级商户全名。企业商户该字段不脱敏，非企业商户该字段会脱敏</value>
        [DataMember(Name = "seller_full_name", EmitDefaultValue = false)]
        public string SellerFullName { get; set; }

        /// <summary>
        /// 收款方登录号信息。间连商户显示二级商户的登录号信息；直连、直付通显示一级商户的登录号信息；该字段脱敏
        /// </summary>
        /// <value>收款方登录号信息。间连商户显示二级商户的登录号信息；直连、直付通显示一级商户的登录号信息；该字段脱敏</value>
        [DataMember(Name = "seller_logon_id", EmitDefaultValue = false)]
        public string SellerLogonId { get; set; }

        /// <summary>
        /// 账单标题
        /// </summary>
        /// <value>账单标题</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// 共同账户消费的成员ID
        /// </summary>
        /// <value>共同账户消费的成员ID</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JointAccountBillDetailDTO {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BillNo: ").Append(BillNo).Append("\n");
            sb.Append("  BizDate: ").Append(BizDate).Append("\n");
            sb.Append("  BizNo: ").Append(BizNo).Append("\n");
            sb.Append("  InOut: ").Append(InOut).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  OutTradeNo: ").Append(OutTradeNo).Append("\n");
            sb.Append("  SellerFullName: ").Append(SellerFullName).Append("\n");
            sb.Append("  SellerLogonId: ").Append(SellerLogonId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as JointAccountBillDetailDTO);
        }

        /// <summary>
        /// Returns true if JointAccountBillDetailDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of JointAccountBillDetailDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JointAccountBillDetailDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.BillNo == input.BillNo ||
                    (this.BillNo != null &&
                    this.BillNo.Equals(input.BillNo))
                ) && 
                (
                    this.BizDate == input.BizDate ||
                    (this.BizDate != null &&
                    this.BizDate.Equals(input.BizDate))
                ) && 
                (
                    this.BizNo == input.BizNo ||
                    (this.BizNo != null &&
                    this.BizNo.Equals(input.BizNo))
                ) && 
                (
                    this.InOut == input.InOut ||
                    (this.InOut != null &&
                    this.InOut.Equals(input.InOut))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.OutTradeNo == input.OutTradeNo ||
                    (this.OutTradeNo != null &&
                    this.OutTradeNo.Equals(input.OutTradeNo))
                ) && 
                (
                    this.SellerFullName == input.SellerFullName ||
                    (this.SellerFullName != null &&
                    this.SellerFullName.Equals(input.SellerFullName))
                ) && 
                (
                    this.SellerLogonId == input.SellerLogonId ||
                    (this.SellerLogonId != null &&
                    this.SellerLogonId.Equals(input.SellerLogonId))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.BillNo != null)
                {
                    hashCode = (hashCode * 59) + this.BillNo.GetHashCode();
                }
                if (this.BizDate != null)
                {
                    hashCode = (hashCode * 59) + this.BizDate.GetHashCode();
                }
                if (this.BizNo != null)
                {
                    hashCode = (hashCode * 59) + this.BizNo.GetHashCode();
                }
                if (this.InOut != null)
                {
                    hashCode = (hashCode * 59) + this.InOut.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.OutTradeNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutTradeNo.GetHashCode();
                }
                if (this.SellerFullName != null)
                {
                    hashCode = (hashCode * 59) + this.SellerFullName.GetHashCode();
                }
                if (this.SellerLogonId != null)
                {
                    hashCode = (hashCode * 59) + this.SellerLogonId.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
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
