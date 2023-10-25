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
    /// AlipayEbppInvoiceApplyStatusNotifyModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceApplyStatusNotifyModel")]
    public partial class AlipayEbppInvoiceApplyStatusNotifyModel : IEquatable<AlipayEbppInvoiceApplyStatusNotifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceApplyStatusNotifyModel" /> class.
        /// </summary>
        /// <param name="applyId">发票申请ID，由阿里发票平台生成。字母或数字组成。 申请单的唯一标识，幂等字段。.</param>
        /// <param name="applyStatus">申请状态，可选值： applying: 申请中，初始状态； cancelled: 申请已取消、或商户已驳回； creating_inv: 商户已受理/开票中，待发票结果回传； inv_failed: 开票失败； inv_success: 开票成功； inv_part_success: 部分成功（拆单场景下存在。举例：发票申请拆单之后有10张票，其中有1张开票成功时，此时申请状态为inv_part_success，当10张票全部成功申请状态则为inv_success）.</param>
        /// <param name="invoiceUks">该申请下所有已开具成功的发票。 状态变更为 apply_status&#x3D;inv_success 时该字段必传.</param>
        /// <param name="message">说明信息：驳回或失败原因 apply_status&#x3D;inv_failed 或 apply_status&#x3D;cancelled 时必传.</param>
        public AlipayEbppInvoiceApplyStatusNotifyModel(string applyId = default(string), string applyStatus = default(string), List<InvoiceUkDTO> invoiceUks = default(List<InvoiceUkDTO>), string message = default(string))
        {
            this.ApplyId = applyId;
            this.ApplyStatus = applyStatus;
            this.InvoiceUks = invoiceUks;
            this.Message = message;
        }

        /// <summary>
        /// 发票申请ID，由阿里发票平台生成。字母或数字组成。 申请单的唯一标识，幂等字段。
        /// </summary>
        /// <value>发票申请ID，由阿里发票平台生成。字母或数字组成。 申请单的唯一标识，幂等字段。</value>
        [DataMember(Name = "apply_id", EmitDefaultValue = false)]
        public string ApplyId { get; set; }

        /// <summary>
        /// 申请状态，可选值： applying: 申请中，初始状态； cancelled: 申请已取消、或商户已驳回； creating_inv: 商户已受理/开票中，待发票结果回传； inv_failed: 开票失败； inv_success: 开票成功； inv_part_success: 部分成功（拆单场景下存在。举例：发票申请拆单之后有10张票，其中有1张开票成功时，此时申请状态为inv_part_success，当10张票全部成功申请状态则为inv_success）
        /// </summary>
        /// <value>申请状态，可选值： applying: 申请中，初始状态； cancelled: 申请已取消、或商户已驳回； creating_inv: 商户已受理/开票中，待发票结果回传； inv_failed: 开票失败； inv_success: 开票成功； inv_part_success: 部分成功（拆单场景下存在。举例：发票申请拆单之后有10张票，其中有1张开票成功时，此时申请状态为inv_part_success，当10张票全部成功申请状态则为inv_success）</value>
        [DataMember(Name = "apply_status", EmitDefaultValue = false)]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 该申请下所有已开具成功的发票。 状态变更为 apply_status&#x3D;inv_success 时该字段必传
        /// </summary>
        /// <value>该申请下所有已开具成功的发票。 状态变更为 apply_status&#x3D;inv_success 时该字段必传</value>
        [DataMember(Name = "invoice_uks", EmitDefaultValue = false)]
        public List<InvoiceUkDTO> InvoiceUks { get; set; }

        /// <summary>
        /// 说明信息：驳回或失败原因 apply_status&#x3D;inv_failed 或 apply_status&#x3D;cancelled 时必传
        /// </summary>
        /// <value>说明信息：驳回或失败原因 apply_status&#x3D;inv_failed 或 apply_status&#x3D;cancelled 时必传</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceApplyStatusNotifyModel {\n");
            sb.Append("  ApplyId: ").Append(ApplyId).Append("\n");
            sb.Append("  ApplyStatus: ").Append(ApplyStatus).Append("\n");
            sb.Append("  InvoiceUks: ").Append(InvoiceUks).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceApplyStatusNotifyModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceApplyStatusNotifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceApplyStatusNotifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceApplyStatusNotifyModel input)
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
                    this.ApplyStatus == input.ApplyStatus ||
                    (this.ApplyStatus != null &&
                    this.ApplyStatus.Equals(input.ApplyStatus))
                ) && 
                (
                    this.InvoiceUks == input.InvoiceUks ||
                    this.InvoiceUks != null &&
                    input.InvoiceUks != null &&
                    this.InvoiceUks.SequenceEqual(input.InvoiceUks)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.ApplyStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyStatus.GetHashCode();
                }
                if (this.InvoiceUks != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceUks.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
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
