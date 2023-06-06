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
    /// VoucherUseRuleInfo
    /// </summary>
    [DataContract(Name = "VoucherUseRuleInfo")]
    public partial class VoucherUseRuleInfo : IEquatable<VoucherUseRuleInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherUseRuleInfo" /> class.
        /// </summary>
        /// <param name="quantityLimitPerUser">核销次数限制。.</param>
        /// <param name="quantityLimitPerUserPeriodType">核销周期。.</param>
        /// <param name="voucherMaxUseTimes">券最大核销次数。.</param>
        /// <param name="voucherUseExtInfo">自定义扩展信息.</param>
        /// <param name="voucherUseTimeInfo">voucherUseTimeInfo.</param>
        public VoucherUseRuleInfo(int quantityLimitPerUser = default(int), string quantityLimitPerUserPeriodType = default(string), int voucherMaxUseTimes = default(int), string voucherUseExtInfo = default(string), VoucherUseTimeInfo voucherUseTimeInfo = default(VoucherUseTimeInfo))
        {
            this.QuantityLimitPerUser = quantityLimitPerUser;
            this.QuantityLimitPerUserPeriodType = quantityLimitPerUserPeriodType;
            this.VoucherMaxUseTimes = voucherMaxUseTimes;
            this.VoucherUseExtInfo = voucherUseExtInfo;
            this.VoucherUseTimeInfo = voucherUseTimeInfo;
        }

        /// <summary>
        /// 核销次数限制。
        /// </summary>
        /// <value>核销次数限制。</value>
        [DataMember(Name = "quantity_limit_per_user", EmitDefaultValue = false)]
        public int QuantityLimitPerUser { get; set; }

        /// <summary>
        /// 核销周期。
        /// </summary>
        /// <value>核销周期。</value>
        [DataMember(Name = "quantity_limit_per_user_period_type", EmitDefaultValue = false)]
        public string QuantityLimitPerUserPeriodType { get; set; }

        /// <summary>
        /// 券最大核销次数。
        /// </summary>
        /// <value>券最大核销次数。</value>
        [DataMember(Name = "voucher_max_use_times", EmitDefaultValue = false)]
        public int VoucherMaxUseTimes { get; set; }

        /// <summary>
        /// 自定义扩展信息
        /// </summary>
        /// <value>自定义扩展信息</value>
        [DataMember(Name = "voucher_use_ext_info", EmitDefaultValue = false)]
        public string VoucherUseExtInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherUseTimeInfo
        /// </summary>
        [DataMember(Name = "voucher_use_time_info", EmitDefaultValue = false)]
        public VoucherUseTimeInfo VoucherUseTimeInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherUseRuleInfo {\n");
            sb.Append("  QuantityLimitPerUser: ").Append(QuantityLimitPerUser).Append("\n");
            sb.Append("  QuantityLimitPerUserPeriodType: ").Append(QuantityLimitPerUserPeriodType).Append("\n");
            sb.Append("  VoucherMaxUseTimes: ").Append(VoucherMaxUseTimes).Append("\n");
            sb.Append("  VoucherUseExtInfo: ").Append(VoucherUseExtInfo).Append("\n");
            sb.Append("  VoucherUseTimeInfo: ").Append(VoucherUseTimeInfo).Append("\n");
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
            return this.Equals(input as VoucherUseRuleInfo);
        }

        /// <summary>
        /// Returns true if VoucherUseRuleInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherUseRuleInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherUseRuleInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.QuantityLimitPerUser == input.QuantityLimitPerUser ||
                    this.QuantityLimitPerUser.Equals(input.QuantityLimitPerUser)
                ) && 
                (
                    this.QuantityLimitPerUserPeriodType == input.QuantityLimitPerUserPeriodType ||
                    (this.QuantityLimitPerUserPeriodType != null &&
                    this.QuantityLimitPerUserPeriodType.Equals(input.QuantityLimitPerUserPeriodType))
                ) && 
                (
                    this.VoucherMaxUseTimes == input.VoucherMaxUseTimes ||
                    this.VoucherMaxUseTimes.Equals(input.VoucherMaxUseTimes)
                ) && 
                (
                    this.VoucherUseExtInfo == input.VoucherUseExtInfo ||
                    (this.VoucherUseExtInfo != null &&
                    this.VoucherUseExtInfo.Equals(input.VoucherUseExtInfo))
                ) && 
                (
                    this.VoucherUseTimeInfo == input.VoucherUseTimeInfo ||
                    (this.VoucherUseTimeInfo != null &&
                    this.VoucherUseTimeInfo.Equals(input.VoucherUseTimeInfo))
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
                hashCode = (hashCode * 59) + this.QuantityLimitPerUser.GetHashCode();
                if (this.QuantityLimitPerUserPeriodType != null)
                {
                    hashCode = (hashCode * 59) + this.QuantityLimitPerUserPeriodType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VoucherMaxUseTimes.GetHashCode();
                if (this.VoucherUseExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherUseExtInfo.GetHashCode();
                }
                if (this.VoucherUseTimeInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherUseTimeInfo.GetHashCode();
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
