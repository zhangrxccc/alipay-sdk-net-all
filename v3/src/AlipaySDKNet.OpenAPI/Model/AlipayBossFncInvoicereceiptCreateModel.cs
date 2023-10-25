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
    /// AlipayBossFncInvoicereceiptCreateModel
    /// </summary>
    [DataContract(Name = "AlipayBossFncInvoicereceiptCreateModel")]
    public partial class AlipayBossFncInvoicereceiptCreateModel : IEquatable<AlipayBossFncInvoicereceiptCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayBossFncInvoicereceiptCreateModel" /> class.
        /// </summary>
        /// <param name="eventCode">账单金额变更消息事件码  AR_MTHLY_BILL_CREATE:应收账单创建,  AR_MTHLY_BILL_CHANGE:应收金额更新.</param>
        /// <param name="eventType">账单金额变更消息事件类型  CREATE:创建事件,UPDATE:更新事件.</param>
        /// <param name="monthlyBill">monthlyBill.</param>
        /// <param name="msgId">事件全局id，可以使用uuid.</param>
        /// <param name="outBizType">消息来源 01:主站，02：芝麻，03:金融云,04:微贷.</param>
        public AlipayBossFncInvoicereceiptCreateModel(string eventCode = default(string), string eventType = default(string), ArMonthlyBillDTO monthlyBill = default(ArMonthlyBillDTO), string msgId = default(string), string outBizType = default(string))
        {
            this.EventCode = eventCode;
            this.EventType = eventType;
            this.MonthlyBill = monthlyBill;
            this.MsgId = msgId;
            this.OutBizType = outBizType;
        }

        /// <summary>
        /// 账单金额变更消息事件码  AR_MTHLY_BILL_CREATE:应收账单创建,  AR_MTHLY_BILL_CHANGE:应收金额更新
        /// </summary>
        /// <value>账单金额变更消息事件码  AR_MTHLY_BILL_CREATE:应收账单创建,  AR_MTHLY_BILL_CHANGE:应收金额更新</value>
        [DataMember(Name = "event_code", EmitDefaultValue = false)]
        public string EventCode { get; set; }

        /// <summary>
        /// 账单金额变更消息事件类型  CREATE:创建事件,UPDATE:更新事件
        /// </summary>
        /// <value>账单金额变更消息事件类型  CREATE:创建事件,UPDATE:更新事件</value>
        [DataMember(Name = "event_type", EmitDefaultValue = false)]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyBill
        /// </summary>
        [DataMember(Name = "monthly_bill", EmitDefaultValue = false)]
        public ArMonthlyBillDTO MonthlyBill { get; set; }

        /// <summary>
        /// 事件全局id，可以使用uuid
        /// </summary>
        /// <value>事件全局id，可以使用uuid</value>
        [DataMember(Name = "msg_id", EmitDefaultValue = false)]
        public string MsgId { get; set; }

        /// <summary>
        /// 消息来源 01:主站，02：芝麻，03:金融云,04:微贷
        /// </summary>
        /// <value>消息来源 01:主站，02：芝麻，03:金融云,04:微贷</value>
        [DataMember(Name = "out_biz_type", EmitDefaultValue = false)]
        public string OutBizType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayBossFncInvoicereceiptCreateModel {\n");
            sb.Append("  EventCode: ").Append(EventCode).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  MonthlyBill: ").Append(MonthlyBill).Append("\n");
            sb.Append("  MsgId: ").Append(MsgId).Append("\n");
            sb.Append("  OutBizType: ").Append(OutBizType).Append("\n");
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
            return this.Equals(input as AlipayBossFncInvoicereceiptCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayBossFncInvoicereceiptCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayBossFncInvoicereceiptCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayBossFncInvoicereceiptCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EventCode == input.EventCode ||
                    (this.EventCode != null &&
                    this.EventCode.Equals(input.EventCode))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.MonthlyBill == input.MonthlyBill ||
                    (this.MonthlyBill != null &&
                    this.MonthlyBill.Equals(input.MonthlyBill))
                ) && 
                (
                    this.MsgId == input.MsgId ||
                    (this.MsgId != null &&
                    this.MsgId.Equals(input.MsgId))
                ) && 
                (
                    this.OutBizType == input.OutBizType ||
                    (this.OutBizType != null &&
                    this.OutBizType.Equals(input.OutBizType))
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
                if (this.EventCode != null)
                {
                    hashCode = (hashCode * 59) + this.EventCode.GetHashCode();
                }
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                if (this.MonthlyBill != null)
                {
                    hashCode = (hashCode * 59) + this.MonthlyBill.GetHashCode();
                }
                if (this.MsgId != null)
                {
                    hashCode = (hashCode * 59) + this.MsgId.GetHashCode();
                }
                if (this.OutBizType != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizType.GetHashCode();
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
