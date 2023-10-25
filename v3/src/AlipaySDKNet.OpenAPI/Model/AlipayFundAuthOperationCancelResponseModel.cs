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
    /// AlipayFundAuthOperationCancelResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundAuthOperationCancelResponseModel")]
    public partial class AlipayFundAuthOperationCancelResponseModel : IEquatable<AlipayFundAuthOperationCancelResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundAuthOperationCancelResponseModel" /> class.
        /// </summary>
        /// <param name="action">本次撤销触发的资金动作  close：关闭冻结明细，无资金解冻  unfreeze：产生了资金解冻.</param>
        /// <param name="authNo">支付宝资金授权订单号。.</param>
        /// <param name="operationId">支付宝的冻结操作流水号。.</param>
        /// <param name="outOrderNo">商户的授权资金订单号。.</param>
        /// <param name="outRequestNo">商户的冻结操作流水号 。.</param>
        public AlipayFundAuthOperationCancelResponseModel(string action = default(string), string authNo = default(string), string operationId = default(string), string outOrderNo = default(string), string outRequestNo = default(string))
        {
            this.Action = action;
            this.AuthNo = authNo;
            this.OperationId = operationId;
            this.OutOrderNo = outOrderNo;
            this.OutRequestNo = outRequestNo;
        }

        /// <summary>
        /// 本次撤销触发的资金动作  close：关闭冻结明细，无资金解冻  unfreeze：产生了资金解冻
        /// </summary>
        /// <value>本次撤销触发的资金动作  close：关闭冻结明细，无资金解冻  unfreeze：产生了资金解冻</value>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public string Action { get; set; }

        /// <summary>
        /// 支付宝资金授权订单号。
        /// </summary>
        /// <value>支付宝资金授权订单号。</value>
        [DataMember(Name = "auth_no", EmitDefaultValue = false)]
        public string AuthNo { get; set; }

        /// <summary>
        /// 支付宝的冻结操作流水号。
        /// </summary>
        /// <value>支付宝的冻结操作流水号。</value>
        [DataMember(Name = "operation_id", EmitDefaultValue = false)]
        public string OperationId { get; set; }

        /// <summary>
        /// 商户的授权资金订单号。
        /// </summary>
        /// <value>商户的授权资金订单号。</value>
        [DataMember(Name = "out_order_no", EmitDefaultValue = false)]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户的冻结操作流水号 。
        /// </summary>
        /// <value>商户的冻结操作流水号 。</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundAuthOperationCancelResponseModel {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  AuthNo: ").Append(AuthNo).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  OutOrderNo: ").Append(OutOrderNo).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
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
            return this.Equals(input as AlipayFundAuthOperationCancelResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundAuthOperationCancelResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundAuthOperationCancelResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundAuthOperationCancelResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.AuthNo == input.AuthNo ||
                    (this.AuthNo != null &&
                    this.AuthNo.Equals(input.AuthNo))
                ) && 
                (
                    this.OperationId == input.OperationId ||
                    (this.OperationId != null &&
                    this.OperationId.Equals(input.OperationId))
                ) && 
                (
                    this.OutOrderNo == input.OutOrderNo ||
                    (this.OutOrderNo != null &&
                    this.OutOrderNo.Equals(input.OutOrderNo))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
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
                if (this.Action != null)
                {
                    hashCode = (hashCode * 59) + this.Action.GetHashCode();
                }
                if (this.AuthNo != null)
                {
                    hashCode = (hashCode * 59) + this.AuthNo.GetHashCode();
                }
                if (this.OperationId != null)
                {
                    hashCode = (hashCode * 59) + this.OperationId.GetHashCode();
                }
                if (this.OutOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutOrderNo.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
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
