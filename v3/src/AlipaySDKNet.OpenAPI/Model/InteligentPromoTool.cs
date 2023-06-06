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
    /// InteligentPromoTool
    /// </summary>
    [DataContract(Name = "InteligentPromoTool")]
    public partial class InteligentPromoTool : IEquatable<InteligentPromoTool>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InteligentPromoTool" /> class.
        /// </summary>
        /// <param name="inteligentSendRule">inteligentSendRule.</param>
        /// <param name="inteligentVoucher">inteligentVoucher.</param>
        /// <param name="status">单个营销工具的生效状态，当在招商部分券失效后会使用这个字段.</param>
        /// <param name="voucherNo">营销工具uid,创建营销活动时无需设置.</param>
        public InteligentPromoTool(InteligentSendRule inteligentSendRule = default(InteligentSendRule), InteligentVoucher inteligentVoucher = default(InteligentVoucher), string status = default(string), string voucherNo = default(string))
        {
            this.InteligentSendRule = inteligentSendRule;
            this.InteligentVoucher = inteligentVoucher;
            this.Status = status;
            this.VoucherNo = voucherNo;
        }

        /// <summary>
        /// Gets or Sets InteligentSendRule
        /// </summary>
        [DataMember(Name = "inteligent_send_rule", EmitDefaultValue = false)]
        public InteligentSendRule InteligentSendRule { get; set; }

        /// <summary>
        /// Gets or Sets InteligentVoucher
        /// </summary>
        [DataMember(Name = "inteligent_voucher", EmitDefaultValue = false)]
        public InteligentVoucher InteligentVoucher { get; set; }

        /// <summary>
        /// 单个营销工具的生效状态，当在招商部分券失效后会使用这个字段
        /// </summary>
        /// <value>单个营销工具的生效状态，当在招商部分券失效后会使用这个字段</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 营销工具uid,创建营销活动时无需设置
        /// </summary>
        /// <value>营销工具uid,创建营销活动时无需设置</value>
        [DataMember(Name = "voucher_no", EmitDefaultValue = false)]
        public string VoucherNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InteligentPromoTool {\n");
            sb.Append("  InteligentSendRule: ").Append(InteligentSendRule).Append("\n");
            sb.Append("  InteligentVoucher: ").Append(InteligentVoucher).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  VoucherNo: ").Append(VoucherNo).Append("\n");
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
            return this.Equals(input as InteligentPromoTool);
        }

        /// <summary>
        /// Returns true if InteligentPromoTool instances are equal
        /// </summary>
        /// <param name="input">Instance of InteligentPromoTool to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InteligentPromoTool input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InteligentSendRule == input.InteligentSendRule ||
                    (this.InteligentSendRule != null &&
                    this.InteligentSendRule.Equals(input.InteligentSendRule))
                ) && 
                (
                    this.InteligentVoucher == input.InteligentVoucher ||
                    (this.InteligentVoucher != null &&
                    this.InteligentVoucher.Equals(input.InteligentVoucher))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.VoucherNo == input.VoucherNo ||
                    (this.VoucherNo != null &&
                    this.VoucherNo.Equals(input.VoucherNo))
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
                if (this.InteligentSendRule != null)
                {
                    hashCode = (hashCode * 59) + this.InteligentSendRule.GetHashCode();
                }
                if (this.InteligentVoucher != null)
                {
                    hashCode = (hashCode * 59) + this.InteligentVoucher.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.VoucherNo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherNo.GetHashCode();
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
