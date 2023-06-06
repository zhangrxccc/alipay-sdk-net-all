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
    /// RoyaltyDetailInfos
    /// </summary>
    [DataContract(Name = "RoyaltyDetailInfos")]
    public partial class RoyaltyDetailInfos : IEquatable<RoyaltyDetailInfos>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoyaltyDetailInfos" /> class.
        /// </summary>
        /// <param name="amount">分账的金额，单位为元.</param>
        /// <param name="amountPercentage">分账的比例，值为20代表按20%的比例分账.</param>
        /// <param name="batchNo">分账批次号  分账批次号。  目前需要和转入账号类型为bankIndex配合使用。.</param>
        /// <param name="desc">分账描述信息.</param>
        /// <param name="outRelationId">商户分账的外部关联号，用于关联到每一笔分账信息，商户需保证其唯一性。  如果为空，该值则默认为“商户网站唯一订单号+分账序列号”.</param>
        /// <param name="serialNo">分账序列号，表示分账执行的顺序，必须为正整数.</param>
        /// <param name="transIn">如果转入账号类型为userId，本参数为接受分账金额的支付宝账号对应的支付宝唯一用户号。以2088开头的纯16位数字。  &amp;#61548; 如果转入账号类型为bankIndex，本参数为28位的银行编号（商户和支付宝签约时确定）。  如果转入账号类型为storeId，本参数为商户的门店ID。.</param>
        /// <param name="transInType">接受分账金额的账户类型：  &amp;#61548; userId：支付宝账号对应的支付宝唯一用户号。  &amp;#61548; bankIndex：分账到银行账户的银行编号。目前暂时只支持分账到一个银行编号。  storeId：分账到门店对应的银行卡编号。  默认值为userId。.</param>
        /// <param name="transOut">如果转出账号类型为userId，本参数为要分账的支付宝账号对应的支付宝唯一用户号。以2088开头的纯16位数字。.</param>
        /// <param name="transOutType">要分账的账户类型。  目前只支持userId：支付宝账号对应的支付宝唯一用户号。  默认值为userId。.</param>
        public RoyaltyDetailInfos(string amount = default(string), string amountPercentage = default(string), string batchNo = default(string), string desc = default(string), string outRelationId = default(string), int serialNo = default(int), string transIn = default(string), string transInType = default(string), string transOut = default(string), string transOutType = default(string))
        {
            this.Amount = amount;
            this.AmountPercentage = amountPercentage;
            this.BatchNo = batchNo;
            this.Desc = desc;
            this.OutRelationId = outRelationId;
            this.SerialNo = serialNo;
            this.TransIn = transIn;
            this.TransInType = transInType;
            this.TransOut = transOut;
            this.TransOutType = transOutType;
        }

        /// <summary>
        /// 分账的金额，单位为元
        /// </summary>
        /// <value>分账的金额，单位为元</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 分账的比例，值为20代表按20%的比例分账
        /// </summary>
        /// <value>分账的比例，值为20代表按20%的比例分账</value>
        [DataMember(Name = "amount_percentage", EmitDefaultValue = false)]
        public string AmountPercentage { get; set; }

        /// <summary>
        /// 分账批次号  分账批次号。  目前需要和转入账号类型为bankIndex配合使用。
        /// </summary>
        /// <value>分账批次号  分账批次号。  目前需要和转入账号类型为bankIndex配合使用。</value>
        [DataMember(Name = "batch_no", EmitDefaultValue = false)]
        public string BatchNo { get; set; }

        /// <summary>
        /// 分账描述信息
        /// </summary>
        /// <value>分账描述信息</value>
        [DataMember(Name = "desc", EmitDefaultValue = false)]
        public string Desc { get; set; }

        /// <summary>
        /// 商户分账的外部关联号，用于关联到每一笔分账信息，商户需保证其唯一性。  如果为空，该值则默认为“商户网站唯一订单号+分账序列号”
        /// </summary>
        /// <value>商户分账的外部关联号，用于关联到每一笔分账信息，商户需保证其唯一性。  如果为空，该值则默认为“商户网站唯一订单号+分账序列号”</value>
        [DataMember(Name = "out_relation_id", EmitDefaultValue = false)]
        public string OutRelationId { get; set; }

        /// <summary>
        /// 分账序列号，表示分账执行的顺序，必须为正整数
        /// </summary>
        /// <value>分账序列号，表示分账执行的顺序，必须为正整数</value>
        [DataMember(Name = "serial_no", EmitDefaultValue = false)]
        public int SerialNo { get; set; }

        /// <summary>
        /// 如果转入账号类型为userId，本参数为接受分账金额的支付宝账号对应的支付宝唯一用户号。以2088开头的纯16位数字。  &amp;#61548; 如果转入账号类型为bankIndex，本参数为28位的银行编号（商户和支付宝签约时确定）。  如果转入账号类型为storeId，本参数为商户的门店ID。
        /// </summary>
        /// <value>如果转入账号类型为userId，本参数为接受分账金额的支付宝账号对应的支付宝唯一用户号。以2088开头的纯16位数字。  &amp;#61548; 如果转入账号类型为bankIndex，本参数为28位的银行编号（商户和支付宝签约时确定）。  如果转入账号类型为storeId，本参数为商户的门店ID。</value>
        [DataMember(Name = "trans_in", EmitDefaultValue = false)]
        public string TransIn { get; set; }

        /// <summary>
        /// 接受分账金额的账户类型：  &amp;#61548; userId：支付宝账号对应的支付宝唯一用户号。  &amp;#61548; bankIndex：分账到银行账户的银行编号。目前暂时只支持分账到一个银行编号。  storeId：分账到门店对应的银行卡编号。  默认值为userId。
        /// </summary>
        /// <value>接受分账金额的账户类型：  &amp;#61548; userId：支付宝账号对应的支付宝唯一用户号。  &amp;#61548; bankIndex：分账到银行账户的银行编号。目前暂时只支持分账到一个银行编号。  storeId：分账到门店对应的银行卡编号。  默认值为userId。</value>
        [DataMember(Name = "trans_in_type", EmitDefaultValue = false)]
        public string TransInType { get; set; }

        /// <summary>
        /// 如果转出账号类型为userId，本参数为要分账的支付宝账号对应的支付宝唯一用户号。以2088开头的纯16位数字。
        /// </summary>
        /// <value>如果转出账号类型为userId，本参数为要分账的支付宝账号对应的支付宝唯一用户号。以2088开头的纯16位数字。</value>
        [DataMember(Name = "trans_out", EmitDefaultValue = false)]
        public string TransOut { get; set; }

        /// <summary>
        /// 要分账的账户类型。  目前只支持userId：支付宝账号对应的支付宝唯一用户号。  默认值为userId。
        /// </summary>
        /// <value>要分账的账户类型。  目前只支持userId：支付宝账号对应的支付宝唯一用户号。  默认值为userId。</value>
        [DataMember(Name = "trans_out_type", EmitDefaultValue = false)]
        public string TransOutType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RoyaltyDetailInfos {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AmountPercentage: ").Append(AmountPercentage).Append("\n");
            sb.Append("  BatchNo: ").Append(BatchNo).Append("\n");
            sb.Append("  Desc: ").Append(Desc).Append("\n");
            sb.Append("  OutRelationId: ").Append(OutRelationId).Append("\n");
            sb.Append("  SerialNo: ").Append(SerialNo).Append("\n");
            sb.Append("  TransIn: ").Append(TransIn).Append("\n");
            sb.Append("  TransInType: ").Append(TransInType).Append("\n");
            sb.Append("  TransOut: ").Append(TransOut).Append("\n");
            sb.Append("  TransOutType: ").Append(TransOutType).Append("\n");
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
            return this.Equals(input as RoyaltyDetailInfos);
        }

        /// <summary>
        /// Returns true if RoyaltyDetailInfos instances are equal
        /// </summary>
        /// <param name="input">Instance of RoyaltyDetailInfos to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoyaltyDetailInfos input)
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
                    this.AmountPercentage == input.AmountPercentage ||
                    (this.AmountPercentage != null &&
                    this.AmountPercentage.Equals(input.AmountPercentage))
                ) && 
                (
                    this.BatchNo == input.BatchNo ||
                    (this.BatchNo != null &&
                    this.BatchNo.Equals(input.BatchNo))
                ) && 
                (
                    this.Desc == input.Desc ||
                    (this.Desc != null &&
                    this.Desc.Equals(input.Desc))
                ) && 
                (
                    this.OutRelationId == input.OutRelationId ||
                    (this.OutRelationId != null &&
                    this.OutRelationId.Equals(input.OutRelationId))
                ) && 
                (
                    this.SerialNo == input.SerialNo ||
                    this.SerialNo.Equals(input.SerialNo)
                ) && 
                (
                    this.TransIn == input.TransIn ||
                    (this.TransIn != null &&
                    this.TransIn.Equals(input.TransIn))
                ) && 
                (
                    this.TransInType == input.TransInType ||
                    (this.TransInType != null &&
                    this.TransInType.Equals(input.TransInType))
                ) && 
                (
                    this.TransOut == input.TransOut ||
                    (this.TransOut != null &&
                    this.TransOut.Equals(input.TransOut))
                ) && 
                (
                    this.TransOutType == input.TransOutType ||
                    (this.TransOutType != null &&
                    this.TransOutType.Equals(input.TransOutType))
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
                if (this.AmountPercentage != null)
                {
                    hashCode = (hashCode * 59) + this.AmountPercentage.GetHashCode();
                }
                if (this.BatchNo != null)
                {
                    hashCode = (hashCode * 59) + this.BatchNo.GetHashCode();
                }
                if (this.Desc != null)
                {
                    hashCode = (hashCode * 59) + this.Desc.GetHashCode();
                }
                if (this.OutRelationId != null)
                {
                    hashCode = (hashCode * 59) + this.OutRelationId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SerialNo.GetHashCode();
                if (this.TransIn != null)
                {
                    hashCode = (hashCode * 59) + this.TransIn.GetHashCode();
                }
                if (this.TransInType != null)
                {
                    hashCode = (hashCode * 59) + this.TransInType.GetHashCode();
                }
                if (this.TransOut != null)
                {
                    hashCode = (hashCode * 59) + this.TransOut.GetHashCode();
                }
                if (this.TransOutType != null)
                {
                    hashCode = (hashCode * 59) + this.TransOutType.GetHashCode();
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
