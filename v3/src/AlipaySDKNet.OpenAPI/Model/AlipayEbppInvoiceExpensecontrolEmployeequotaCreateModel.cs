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
    /// AlipayEbppInvoiceExpensecontrolEmployeequotaCreateModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceExpensecontrolEmployeequotaCreateModel")]
    public partial class AlipayEbppInvoiceExpensecontrolEmployeequotaCreateModel : IEquatable<AlipayEbppInvoiceExpensecontrolEmployeequotaCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceExpensecontrolEmployeequotaCreateModel" /> class.
        /// </summary>
        /// <param name="accountId">共同账号ID.</param>
        /// <param name="agreementNo">授权签约协议号.</param>
        /// <param name="effectiveEndDate">余额失效时间（默认有效期100年）.</param>
        /// <param name="effectiveStartDate">余额生效时间(默认当前时间).</param>
        /// <param name="outerSourceId">外部操作幂等ID（接入方接口调用幂等控制ID）.</param>
        /// <param name="ownerId">切换open_id前请使用：余额所属者ID owner_type为员工时为员工支付宝ID.</param>
        /// <param name="ownerOpenId">切换open_id后请使用：余额所属者ID owner_type为员工时为员工open_id.</param>
        /// <param name="ownerType">余额所属者类型 EMPLOYEE: 员工.</param>
        /// <param name="platform">外部平台编码（通常为接入方大写英文缩写）.</param>
        /// <param name="quotaModel">余额同步模式，默认 DEFAULT_STANDARD.</param>
        /// <param name="quotaValue">余额，以（分）为单位 特殊说明：余额不超过100000元.</param>
        public AlipayEbppInvoiceExpensecontrolEmployeequotaCreateModel(string accountId = default(string), string agreementNo = default(string), string effectiveEndDate = default(string), string effectiveStartDate = default(string), string outerSourceId = default(string), string ownerId = default(string), string ownerOpenId = default(string), string ownerType = default(string), string platform = default(string), string quotaModel = default(string), string quotaValue = default(string))
        {
            this.AccountId = accountId;
            this.AgreementNo = agreementNo;
            this.EffectiveEndDate = effectiveEndDate;
            this.EffectiveStartDate = effectiveStartDate;
            this.OuterSourceId = outerSourceId;
            this.OwnerId = ownerId;
            this.OwnerOpenId = ownerOpenId;
            this.OwnerType = ownerType;
            this.Platform = platform;
            this.QuotaModel = quotaModel;
            this.QuotaValue = quotaValue;
        }

        /// <summary>
        /// 共同账号ID
        /// </summary>
        /// <value>共同账号ID</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        /// <value>授权签约协议号</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 余额失效时间（默认有效期100年）
        /// </summary>
        /// <value>余额失效时间（默认有效期100年）</value>
        [DataMember(Name = "effective_end_date", EmitDefaultValue = false)]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 余额生效时间(默认当前时间)
        /// </summary>
        /// <value>余额生效时间(默认当前时间)</value>
        [DataMember(Name = "effective_start_date", EmitDefaultValue = false)]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 外部操作幂等ID（接入方接口调用幂等控制ID）
        /// </summary>
        /// <value>外部操作幂等ID（接入方接口调用幂等控制ID）</value>
        [DataMember(Name = "outer_source_id", EmitDefaultValue = false)]
        public string OuterSourceId { get; set; }

        /// <summary>
        /// 切换open_id前请使用：余额所属者ID owner_type为员工时为员工支付宝ID
        /// </summary>
        /// <value>切换open_id前请使用：余额所属者ID owner_type为员工时为员工支付宝ID</value>
        [DataMember(Name = "owner_id", EmitDefaultValue = false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// 切换open_id后请使用：余额所属者ID owner_type为员工时为员工open_id
        /// </summary>
        /// <value>切换open_id后请使用：余额所属者ID owner_type为员工时为员工open_id</value>
        [DataMember(Name = "owner_open_id", EmitDefaultValue = false)]
        public string OwnerOpenId { get; set; }

        /// <summary>
        /// 余额所属者类型 EMPLOYEE: 员工
        /// </summary>
        /// <value>余额所属者类型 EMPLOYEE: 员工</value>
        [DataMember(Name = "owner_type", EmitDefaultValue = false)]
        public string OwnerType { get; set; }

        /// <summary>
        /// 外部平台编码（通常为接入方大写英文缩写）
        /// </summary>
        /// <value>外部平台编码（通常为接入方大写英文缩写）</value>
        [DataMember(Name = "platform", EmitDefaultValue = false)]
        public string Platform { get; set; }

        /// <summary>
        /// 余额同步模式，默认 DEFAULT_STANDARD
        /// </summary>
        /// <value>余额同步模式，默认 DEFAULT_STANDARD</value>
        [DataMember(Name = "quota_model", EmitDefaultValue = false)]
        public string QuotaModel { get; set; }

        /// <summary>
        /// 余额，以（分）为单位 特殊说明：余额不超过100000元
        /// </summary>
        /// <value>余额，以（分）为单位 特殊说明：余额不超过100000元</value>
        [DataMember(Name = "quota_value", EmitDefaultValue = false)]
        public string QuotaValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceExpensecontrolEmployeequotaCreateModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  EffectiveEndDate: ").Append(EffectiveEndDate).Append("\n");
            sb.Append("  EffectiveStartDate: ").Append(EffectiveStartDate).Append("\n");
            sb.Append("  OuterSourceId: ").Append(OuterSourceId).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  OwnerOpenId: ").Append(OwnerOpenId).Append("\n");
            sb.Append("  OwnerType: ").Append(OwnerType).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  QuotaModel: ").Append(QuotaModel).Append("\n");
            sb.Append("  QuotaValue: ").Append(QuotaValue).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceExpensecontrolEmployeequotaCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceExpensecontrolEmployeequotaCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceExpensecontrolEmployeequotaCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceExpensecontrolEmployeequotaCreateModel input)
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
                    this.AgreementNo == input.AgreementNo ||
                    (this.AgreementNo != null &&
                    this.AgreementNo.Equals(input.AgreementNo))
                ) && 
                (
                    this.EffectiveEndDate == input.EffectiveEndDate ||
                    (this.EffectiveEndDate != null &&
                    this.EffectiveEndDate.Equals(input.EffectiveEndDate))
                ) && 
                (
                    this.EffectiveStartDate == input.EffectiveStartDate ||
                    (this.EffectiveStartDate != null &&
                    this.EffectiveStartDate.Equals(input.EffectiveStartDate))
                ) && 
                (
                    this.OuterSourceId == input.OuterSourceId ||
                    (this.OuterSourceId != null &&
                    this.OuterSourceId.Equals(input.OuterSourceId))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.OwnerOpenId == input.OwnerOpenId ||
                    (this.OwnerOpenId != null &&
                    this.OwnerOpenId.Equals(input.OwnerOpenId))
                ) && 
                (
                    this.OwnerType == input.OwnerType ||
                    (this.OwnerType != null &&
                    this.OwnerType.Equals(input.OwnerType))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.QuotaModel == input.QuotaModel ||
                    (this.QuotaModel != null &&
                    this.QuotaModel.Equals(input.QuotaModel))
                ) && 
                (
                    this.QuotaValue == input.QuotaValue ||
                    (this.QuotaValue != null &&
                    this.QuotaValue.Equals(input.QuotaValue))
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
                if (this.AgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNo.GetHashCode();
                }
                if (this.EffectiveEndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveEndDate.GetHashCode();
                }
                if (this.EffectiveStartDate != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveStartDate.GetHashCode();
                }
                if (this.OuterSourceId != null)
                {
                    hashCode = (hashCode * 59) + this.OuterSourceId.GetHashCode();
                }
                if (this.OwnerId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerId.GetHashCode();
                }
                if (this.OwnerOpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerOpenId.GetHashCode();
                }
                if (this.OwnerType != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerType.GetHashCode();
                }
                if (this.Platform != null)
                {
                    hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                }
                if (this.QuotaModel != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaModel.GetHashCode();
                }
                if (this.QuotaValue != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaValue.GetHashCode();
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
