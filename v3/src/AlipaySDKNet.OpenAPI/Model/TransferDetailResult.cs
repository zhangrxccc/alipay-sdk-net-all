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
    /// TransferDetailResult
    /// </summary>
    [DataContract(Name = "TransferDetailResult")]
    public partial class TransferDetailResult : IEquatable<TransferDetailResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferDetailResult" /> class.
        /// </summary>
        /// <param name="account">付款/收款账户。充值记录中是付款账户。提现、转账记录中是收款账户。支付宝名称及账号脱敏；银行账户的户名脱敏，银行账户显示银行名称+银行卡号后四位.</param>
        /// <param name="amount">金额.</param>
        /// <param name="fundDesc">资金来源/去向类型。在充值记录中，表示资金来源类型，在转账和提现类型中，表示去向类型.</param>
        /// <param name="instructionId">银行单据号。对账使用，无需脱敏.</param>
        /// <param name="memo">备注信息.</param>
        /// <param name="orderNo">业务订单号。该笔业务单据的唯一识别编号.</param>
        /// <param name="serviceFee">服务费金额.</param>
        /// <param name="status">资金状态.</param>
        /// <param name="subTypeDesc">子类型。“充值类型”，普通充值、大额充值。“转账类型”，暂无实现。转账至支付宝账户、转账至银行卡、批量转账支付宝账户、批量转账至银行卡、批量付款。“提现类型”，暂无实现。普通提现、批量委托提现。对账使用，无需脱敏.</param>
        /// <param name="transDt">业务发生时间.</param>
        /// <param name="typeDesc">查询类型描述：充值、转账、提现.</param>
        public TransferDetailResult(string account = default(string), string amount = default(string), string fundDesc = default(string), string instructionId = default(string), string memo = default(string), string orderNo = default(string), string serviceFee = default(string), string status = default(string), string subTypeDesc = default(string), string transDt = default(string), string typeDesc = default(string))
        {
            this.Account = account;
            this.Amount = amount;
            this.FundDesc = fundDesc;
            this.InstructionId = instructionId;
            this.Memo = memo;
            this.OrderNo = orderNo;
            this.ServiceFee = serviceFee;
            this.Status = status;
            this.SubTypeDesc = subTypeDesc;
            this.TransDt = transDt;
            this.TypeDesc = typeDesc;
        }

        /// <summary>
        /// 付款/收款账户。充值记录中是付款账户。提现、转账记录中是收款账户。支付宝名称及账号脱敏；银行账户的户名脱敏，银行账户显示银行名称+银行卡号后四位
        /// </summary>
        /// <value>付款/收款账户。充值记录中是付款账户。提现、转账记录中是收款账户。支付宝名称及账号脱敏；银行账户的户名脱敏，银行账户显示银行名称+银行卡号后四位</value>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        public string Account { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        /// <value>金额</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 资金来源/去向类型。在充值记录中，表示资金来源类型，在转账和提现类型中，表示去向类型
        /// </summary>
        /// <value>资金来源/去向类型。在充值记录中，表示资金来源类型，在转账和提现类型中，表示去向类型</value>
        [DataMember(Name = "fund_desc", EmitDefaultValue = false)]
        public string FundDesc { get; set; }

        /// <summary>
        /// 银行单据号。对账使用，无需脱敏
        /// </summary>
        /// <value>银行单据号。对账使用，无需脱敏</value>
        [DataMember(Name = "instruction_id", EmitDefaultValue = false)]
        public string InstructionId { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        /// <value>备注信息</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// 业务订单号。该笔业务单据的唯一识别编号
        /// </summary>
        /// <value>业务订单号。该笔业务单据的唯一识别编号</value>
        [DataMember(Name = "order_no", EmitDefaultValue = false)]
        public string OrderNo { get; set; }

        /// <summary>
        /// 服务费金额
        /// </summary>
        /// <value>服务费金额</value>
        [DataMember(Name = "service_fee", EmitDefaultValue = false)]
        public string ServiceFee { get; set; }

        /// <summary>
        /// 资金状态
        /// </summary>
        /// <value>资金状态</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 子类型。“充值类型”，普通充值、大额充值。“转账类型”，暂无实现。转账至支付宝账户、转账至银行卡、批量转账支付宝账户、批量转账至银行卡、批量付款。“提现类型”，暂无实现。普通提现、批量委托提现。对账使用，无需脱敏
        /// </summary>
        /// <value>子类型。“充值类型”，普通充值、大额充值。“转账类型”，暂无实现。转账至支付宝账户、转账至银行卡、批量转账支付宝账户、批量转账至银行卡、批量付款。“提现类型”，暂无实现。普通提现、批量委托提现。对账使用，无需脱敏</value>
        [DataMember(Name = "sub_type_desc", EmitDefaultValue = false)]
        public string SubTypeDesc { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        /// <value>业务发生时间</value>
        [DataMember(Name = "trans_dt", EmitDefaultValue = false)]
        public string TransDt { get; set; }

        /// <summary>
        /// 查询类型描述：充值、转账、提现
        /// </summary>
        /// <value>查询类型描述：充值、转账、提现</value>
        [DataMember(Name = "type_desc", EmitDefaultValue = false)]
        public string TypeDesc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransferDetailResult {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  FundDesc: ").Append(FundDesc).Append("\n");
            sb.Append("  InstructionId: ").Append(InstructionId).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
            sb.Append("  ServiceFee: ").Append(ServiceFee).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubTypeDesc: ").Append(SubTypeDesc).Append("\n");
            sb.Append("  TransDt: ").Append(TransDt).Append("\n");
            sb.Append("  TypeDesc: ").Append(TypeDesc).Append("\n");
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
            return this.Equals(input as TransferDetailResult);
        }

        /// <summary>
        /// Returns true if TransferDetailResult instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferDetailResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferDetailResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.FundDesc == input.FundDesc ||
                    (this.FundDesc != null &&
                    this.FundDesc.Equals(input.FundDesc))
                ) && 
                (
                    this.InstructionId == input.InstructionId ||
                    (this.InstructionId != null &&
                    this.InstructionId.Equals(input.InstructionId))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.OrderNo == input.OrderNo ||
                    (this.OrderNo != null &&
                    this.OrderNo.Equals(input.OrderNo))
                ) && 
                (
                    this.ServiceFee == input.ServiceFee ||
                    (this.ServiceFee != null &&
                    this.ServiceFee.Equals(input.ServiceFee))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SubTypeDesc == input.SubTypeDesc ||
                    (this.SubTypeDesc != null &&
                    this.SubTypeDesc.Equals(input.SubTypeDesc))
                ) && 
                (
                    this.TransDt == input.TransDt ||
                    (this.TransDt != null &&
                    this.TransDt.Equals(input.TransDt))
                ) && 
                (
                    this.TypeDesc == input.TypeDesc ||
                    (this.TypeDesc != null &&
                    this.TypeDesc.Equals(input.TypeDesc))
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
                if (this.Account != null)
                {
                    hashCode = (hashCode * 59) + this.Account.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.FundDesc != null)
                {
                    hashCode = (hashCode * 59) + this.FundDesc.GetHashCode();
                }
                if (this.InstructionId != null)
                {
                    hashCode = (hashCode * 59) + this.InstructionId.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.OrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OrderNo.GetHashCode();
                }
                if (this.ServiceFee != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceFee.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.SubTypeDesc != null)
                {
                    hashCode = (hashCode * 59) + this.SubTypeDesc.GetHashCode();
                }
                if (this.TransDt != null)
                {
                    hashCode = (hashCode * 59) + this.TransDt.GetHashCode();
                }
                if (this.TypeDesc != null)
                {
                    hashCode = (hashCode * 59) + this.TypeDesc.GetHashCode();
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
