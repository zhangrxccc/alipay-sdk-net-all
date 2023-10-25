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
    /// AlipayEbppInvoiceExpenseProgressSyncModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceExpenseProgressSyncModel")]
    public partial class AlipayEbppInvoiceExpenseProgressSyncModel : IEquatable<AlipayEbppInvoiceExpenseProgressSyncModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceExpenseProgressSyncModel" /> class.
        /// </summary>
        /// <param name="applyId">同步申请id，每次发起同步时生成，isv每次请求需要保证唯一.</param>
        /// <param name="businessTime">报销状态变更执行时间.</param>
        /// <param name="expenseDetailUrl">报销详情地址，提供用户通过发票管家查看报销进度的地址  如果报销企业入驻发票管家时需要isv传入报销详情地址，则必须提供.</param>
        /// <param name="expenseOrderNo">报销单据号.</param>
        /// <param name="expenseTaxNo">报销企业税号.</param>
        /// <param name="invoiceCode">发票代码.</param>
        /// <param name="invoiceNo">发票号码.</param>
        /// <param name="memo">备注.</param>
        /// <param name="openId">open_id，支付宝用户id.</param>
        /// <param name="status">报销操作。枚举值如下： *EXPENSE_APPLY：用户已提交申请。*EXPENSE_APPROVAL_PASS：报销审核通过。 *EXPENSE_FINISHED：报销完结。 *EXPENSE_CANCEL：报销撤回。.</param>
        /// <param name="userId">发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。.</param>
        public AlipayEbppInvoiceExpenseProgressSyncModel(string applyId = default(string), string businessTime = default(string), string expenseDetailUrl = default(string), string expenseOrderNo = default(string), string expenseTaxNo = default(string), string invoiceCode = default(string), string invoiceNo = default(string), string memo = default(string), string openId = default(string), string status = default(string), string userId = default(string))
        {
            this.ApplyId = applyId;
            this.BusinessTime = businessTime;
            this.ExpenseDetailUrl = expenseDetailUrl;
            this.ExpenseOrderNo = expenseOrderNo;
            this.ExpenseTaxNo = expenseTaxNo;
            this.InvoiceCode = invoiceCode;
            this.InvoiceNo = invoiceNo;
            this.Memo = memo;
            this.OpenId = openId;
            this.Status = status;
            this.UserId = userId;
        }

        /// <summary>
        /// 同步申请id，每次发起同步时生成，isv每次请求需要保证唯一
        /// </summary>
        /// <value>同步申请id，每次发起同步时生成，isv每次请求需要保证唯一</value>
        [DataMember(Name = "apply_id", EmitDefaultValue = false)]
        public string ApplyId { get; set; }

        /// <summary>
        /// 报销状态变更执行时间
        /// </summary>
        /// <value>报销状态变更执行时间</value>
        [DataMember(Name = "business_time", EmitDefaultValue = false)]
        public string BusinessTime { get; set; }

        /// <summary>
        /// 报销详情地址，提供用户通过发票管家查看报销进度的地址  如果报销企业入驻发票管家时需要isv传入报销详情地址，则必须提供
        /// </summary>
        /// <value>报销详情地址，提供用户通过发票管家查看报销进度的地址  如果报销企业入驻发票管家时需要isv传入报销详情地址，则必须提供</value>
        [DataMember(Name = "expense_detail_url", EmitDefaultValue = false)]
        public string ExpenseDetailUrl { get; set; }

        /// <summary>
        /// 报销单据号
        /// </summary>
        /// <value>报销单据号</value>
        [DataMember(Name = "expense_order_no", EmitDefaultValue = false)]
        public string ExpenseOrderNo { get; set; }

        /// <summary>
        /// 报销企业税号
        /// </summary>
        /// <value>报销企业税号</value>
        [DataMember(Name = "expense_tax_no", EmitDefaultValue = false)]
        public string ExpenseTaxNo { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        /// <value>发票代码</value>
        [DataMember(Name = "invoice_code", EmitDefaultValue = false)]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        /// <value>发票号码</value>
        [DataMember(Name = "invoice_no", EmitDefaultValue = false)]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        /// <value>备注</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// open_id，支付宝用户id
        /// </summary>
        /// <value>open_id，支付宝用户id</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 报销操作。枚举值如下： *EXPENSE_APPLY：用户已提交申请。*EXPENSE_APPROVAL_PASS：报销审核通过。 *EXPENSE_FINISHED：报销完结。 *EXPENSE_CANCEL：报销撤回。
        /// </summary>
        /// <value>报销操作。枚举值如下： *EXPENSE_APPLY：用户已提交申请。*EXPENSE_APPROVAL_PASS：报销审核通过。 *EXPENSE_FINISHED：报销完结。 *EXPENSE_CANCEL：报销撤回。</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。
        /// </summary>
        /// <value>发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceExpenseProgressSyncModel {\n");
            sb.Append("  ApplyId: ").Append(ApplyId).Append("\n");
            sb.Append("  BusinessTime: ").Append(BusinessTime).Append("\n");
            sb.Append("  ExpenseDetailUrl: ").Append(ExpenseDetailUrl).Append("\n");
            sb.Append("  ExpenseOrderNo: ").Append(ExpenseOrderNo).Append("\n");
            sb.Append("  ExpenseTaxNo: ").Append(ExpenseTaxNo).Append("\n");
            sb.Append("  InvoiceCode: ").Append(InvoiceCode).Append("\n");
            sb.Append("  InvoiceNo: ").Append(InvoiceNo).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceExpenseProgressSyncModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceExpenseProgressSyncModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceExpenseProgressSyncModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceExpenseProgressSyncModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApplyId == input.ApplyId ||
                    (this.ApplyId != null &&
                    this.ApplyId.Equals(input.ApplyId))
                ) && 
                (
                    this.BusinessTime == input.BusinessTime ||
                    (this.BusinessTime != null &&
                    this.BusinessTime.Equals(input.BusinessTime))
                ) && 
                (
                    this.ExpenseDetailUrl == input.ExpenseDetailUrl ||
                    (this.ExpenseDetailUrl != null &&
                    this.ExpenseDetailUrl.Equals(input.ExpenseDetailUrl))
                ) && 
                (
                    this.ExpenseOrderNo == input.ExpenseOrderNo ||
                    (this.ExpenseOrderNo != null &&
                    this.ExpenseOrderNo.Equals(input.ExpenseOrderNo))
                ) && 
                (
                    this.ExpenseTaxNo == input.ExpenseTaxNo ||
                    (this.ExpenseTaxNo != null &&
                    this.ExpenseTaxNo.Equals(input.ExpenseTaxNo))
                ) && 
                (
                    this.InvoiceCode == input.InvoiceCode ||
                    (this.InvoiceCode != null &&
                    this.InvoiceCode.Equals(input.InvoiceCode))
                ) && 
                (
                    this.InvoiceNo == input.InvoiceNo ||
                    (this.InvoiceNo != null &&
                    this.InvoiceNo.Equals(input.InvoiceNo))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.ApplyId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyId.GetHashCode();
                }
                if (this.BusinessTime != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessTime.GetHashCode();
                }
                if (this.ExpenseDetailUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ExpenseDetailUrl.GetHashCode();
                }
                if (this.ExpenseOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.ExpenseOrderNo.GetHashCode();
                }
                if (this.ExpenseTaxNo != null)
                {
                    hashCode = (hashCode * 59) + this.ExpenseTaxNo.GetHashCode();
                }
                if (this.InvoiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceCode.GetHashCode();
                }
                if (this.InvoiceNo != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceNo.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
