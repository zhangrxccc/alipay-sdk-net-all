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
    /// IssueRuleInfo
    /// </summary>
    [DataContract(Name = "IssueRuleInfo")]
    public partial class IssueRuleInfo : IEquatable<IssueRuleInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueRuleInfo" /> class.
        /// </summary>
        /// <param name="effectivePeriod">生效时间段.</param>
        /// <param name="invalidMode">累计类型，默认为0 可选值：0（不可累计）、1（可累计）、2（累计天数）、3（累计到指定日期）.</param>
        /// <param name="invalidModeValue">累计类型值.</param>
        /// <param name="issueAmountValue">发放金额，单位元.</param>
        /// <param name="issueEndDate">发放规则有效结束时间.</param>
        /// <param name="issueRuleId">发放规则id.</param>
        /// <param name="issueRuleName">发放规则名称.</param>
        /// <param name="issueStartDate">发放规则有效起始时间.</param>
        /// <param name="issueType">发放类型.</param>
        /// <param name="outerSourceId">外部发放规则id.</param>
        /// <param name="quotaType">额度类型.</param>
        /// <param name="shareMode">是否可转赠.</param>
        /// <param name="targetId">目标id.</param>
        /// <param name="targetType">发放规则归属的目标类型.</param>
        public IssueRuleInfo(string effectivePeriod = default(string), int invalidMode = default(int), string invalidModeValue = default(string), string issueAmountValue = default(string), string issueEndDate = default(string), string issueRuleId = default(string), string issueRuleName = default(string), string issueStartDate = default(string), string issueType = default(string), string outerSourceId = default(string), string quotaType = default(string), int shareMode = default(int), string targetId = default(string), string targetType = default(string))
        {
            this.EffectivePeriod = effectivePeriod;
            this.InvalidMode = invalidMode;
            this.InvalidModeValue = invalidModeValue;
            this.IssueAmountValue = issueAmountValue;
            this.IssueEndDate = issueEndDate;
            this.IssueRuleId = issueRuleId;
            this.IssueRuleName = issueRuleName;
            this.IssueStartDate = issueStartDate;
            this.IssueType = issueType;
            this.OuterSourceId = outerSourceId;
            this.QuotaType = quotaType;
            this.ShareMode = shareMode;
            this.TargetId = targetId;
            this.TargetType = targetType;
        }

        /// <summary>
        /// 生效时间段
        /// </summary>
        /// <value>生效时间段</value>
        [DataMember(Name = "effective_period", EmitDefaultValue = false)]
        public string EffectivePeriod { get; set; }

        /// <summary>
        /// 累计类型，默认为0 可选值：0（不可累计）、1（可累计）、2（累计天数）、3（累计到指定日期）
        /// </summary>
        /// <value>累计类型，默认为0 可选值：0（不可累计）、1（可累计）、2（累计天数）、3（累计到指定日期）</value>
        [DataMember(Name = "invalid_mode", EmitDefaultValue = false)]
        public int InvalidMode { get; set; }

        /// <summary>
        /// 累计类型值
        /// </summary>
        /// <value>累计类型值</value>
        [DataMember(Name = "invalid_mode_value", EmitDefaultValue = false)]
        public string InvalidModeValue { get; set; }

        /// <summary>
        /// 发放金额，单位元
        /// </summary>
        /// <value>发放金额，单位元</value>
        [DataMember(Name = "issue_amount_value", EmitDefaultValue = false)]
        public string IssueAmountValue { get; set; }

        /// <summary>
        /// 发放规则有效结束时间
        /// </summary>
        /// <value>发放规则有效结束时间</value>
        [DataMember(Name = "issue_end_date", EmitDefaultValue = false)]
        public string IssueEndDate { get; set; }

        /// <summary>
        /// 发放规则id
        /// </summary>
        /// <value>发放规则id</value>
        [DataMember(Name = "issue_rule_id", EmitDefaultValue = false)]
        public string IssueRuleId { get; set; }

        /// <summary>
        /// 发放规则名称
        /// </summary>
        /// <value>发放规则名称</value>
        [DataMember(Name = "issue_rule_name", EmitDefaultValue = false)]
        public string IssueRuleName { get; set; }

        /// <summary>
        /// 发放规则有效起始时间
        /// </summary>
        /// <value>发放规则有效起始时间</value>
        [DataMember(Name = "issue_start_date", EmitDefaultValue = false)]
        public string IssueStartDate { get; set; }

        /// <summary>
        /// 发放类型
        /// </summary>
        /// <value>发放类型</value>
        [DataMember(Name = "issue_type", EmitDefaultValue = false)]
        public string IssueType { get; set; }

        /// <summary>
        /// 外部发放规则id
        /// </summary>
        /// <value>外部发放规则id</value>
        [DataMember(Name = "outer_source_id", EmitDefaultValue = false)]
        public string OuterSourceId { get; set; }

        /// <summary>
        /// 额度类型
        /// </summary>
        /// <value>额度类型</value>
        [DataMember(Name = "quota_type", EmitDefaultValue = false)]
        public string QuotaType { get; set; }

        /// <summary>
        /// 是否可转赠
        /// </summary>
        /// <value>是否可转赠</value>
        [DataMember(Name = "share_mode", EmitDefaultValue = false)]
        public int ShareMode { get; set; }

        /// <summary>
        /// 目标id
        /// </summary>
        /// <value>目标id</value>
        [DataMember(Name = "target_id", EmitDefaultValue = false)]
        public string TargetId { get; set; }

        /// <summary>
        /// 发放规则归属的目标类型
        /// </summary>
        /// <value>发放规则归属的目标类型</value>
        [DataMember(Name = "target_type", EmitDefaultValue = false)]
        public string TargetType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IssueRuleInfo {\n");
            sb.Append("  EffectivePeriod: ").Append(EffectivePeriod).Append("\n");
            sb.Append("  InvalidMode: ").Append(InvalidMode).Append("\n");
            sb.Append("  InvalidModeValue: ").Append(InvalidModeValue).Append("\n");
            sb.Append("  IssueAmountValue: ").Append(IssueAmountValue).Append("\n");
            sb.Append("  IssueEndDate: ").Append(IssueEndDate).Append("\n");
            sb.Append("  IssueRuleId: ").Append(IssueRuleId).Append("\n");
            sb.Append("  IssueRuleName: ").Append(IssueRuleName).Append("\n");
            sb.Append("  IssueStartDate: ").Append(IssueStartDate).Append("\n");
            sb.Append("  IssueType: ").Append(IssueType).Append("\n");
            sb.Append("  OuterSourceId: ").Append(OuterSourceId).Append("\n");
            sb.Append("  QuotaType: ").Append(QuotaType).Append("\n");
            sb.Append("  ShareMode: ").Append(ShareMode).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  TargetType: ").Append(TargetType).Append("\n");
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
            return this.Equals(input as IssueRuleInfo);
        }

        /// <summary>
        /// Returns true if IssueRuleInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of IssueRuleInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssueRuleInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EffectivePeriod == input.EffectivePeriod ||
                    (this.EffectivePeriod != null &&
                    this.EffectivePeriod.Equals(input.EffectivePeriod))
                ) && 
                (
                    this.InvalidMode == input.InvalidMode ||
                    this.InvalidMode.Equals(input.InvalidMode)
                ) && 
                (
                    this.InvalidModeValue == input.InvalidModeValue ||
                    (this.InvalidModeValue != null &&
                    this.InvalidModeValue.Equals(input.InvalidModeValue))
                ) && 
                (
                    this.IssueAmountValue == input.IssueAmountValue ||
                    (this.IssueAmountValue != null &&
                    this.IssueAmountValue.Equals(input.IssueAmountValue))
                ) && 
                (
                    this.IssueEndDate == input.IssueEndDate ||
                    (this.IssueEndDate != null &&
                    this.IssueEndDate.Equals(input.IssueEndDate))
                ) && 
                (
                    this.IssueRuleId == input.IssueRuleId ||
                    (this.IssueRuleId != null &&
                    this.IssueRuleId.Equals(input.IssueRuleId))
                ) && 
                (
                    this.IssueRuleName == input.IssueRuleName ||
                    (this.IssueRuleName != null &&
                    this.IssueRuleName.Equals(input.IssueRuleName))
                ) && 
                (
                    this.IssueStartDate == input.IssueStartDate ||
                    (this.IssueStartDate != null &&
                    this.IssueStartDate.Equals(input.IssueStartDate))
                ) && 
                (
                    this.IssueType == input.IssueType ||
                    (this.IssueType != null &&
                    this.IssueType.Equals(input.IssueType))
                ) && 
                (
                    this.OuterSourceId == input.OuterSourceId ||
                    (this.OuterSourceId != null &&
                    this.OuterSourceId.Equals(input.OuterSourceId))
                ) && 
                (
                    this.QuotaType == input.QuotaType ||
                    (this.QuotaType != null &&
                    this.QuotaType.Equals(input.QuotaType))
                ) && 
                (
                    this.ShareMode == input.ShareMode ||
                    this.ShareMode.Equals(input.ShareMode)
                ) && 
                (
                    this.TargetId == input.TargetId ||
                    (this.TargetId != null &&
                    this.TargetId.Equals(input.TargetId))
                ) && 
                (
                    this.TargetType == input.TargetType ||
                    (this.TargetType != null &&
                    this.TargetType.Equals(input.TargetType))
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
                if (this.EffectivePeriod != null)
                {
                    hashCode = (hashCode * 59) + this.EffectivePeriod.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InvalidMode.GetHashCode();
                if (this.InvalidModeValue != null)
                {
                    hashCode = (hashCode * 59) + this.InvalidModeValue.GetHashCode();
                }
                if (this.IssueAmountValue != null)
                {
                    hashCode = (hashCode * 59) + this.IssueAmountValue.GetHashCode();
                }
                if (this.IssueEndDate != null)
                {
                    hashCode = (hashCode * 59) + this.IssueEndDate.GetHashCode();
                }
                if (this.IssueRuleId != null)
                {
                    hashCode = (hashCode * 59) + this.IssueRuleId.GetHashCode();
                }
                if (this.IssueRuleName != null)
                {
                    hashCode = (hashCode * 59) + this.IssueRuleName.GetHashCode();
                }
                if (this.IssueStartDate != null)
                {
                    hashCode = (hashCode * 59) + this.IssueStartDate.GetHashCode();
                }
                if (this.IssueType != null)
                {
                    hashCode = (hashCode * 59) + this.IssueType.GetHashCode();
                }
                if (this.OuterSourceId != null)
                {
                    hashCode = (hashCode * 59) + this.OuterSourceId.GetHashCode();
                }
                if (this.QuotaType != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ShareMode.GetHashCode();
                if (this.TargetId != null)
                {
                    hashCode = (hashCode * 59) + this.TargetId.GetHashCode();
                }
                if (this.TargetType != null)
                {
                    hashCode = (hashCode * 59) + this.TargetType.GetHashCode();
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
