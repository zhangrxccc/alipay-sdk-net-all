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
    /// AlipayMarketingActivityOrdervoucherQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingActivityOrdervoucherQueryResponseModel")]
    public partial class AlipayMarketingActivityOrdervoucherQueryResponseModel : IEquatable<AlipayMarketingActivityOrdervoucherQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityOrdervoucherQueryResponseModel" /> class.
        /// </summary>
        /// <param name="activityBaseInfo">activityBaseInfo.</param>
        /// <param name="activityId">活动id.</param>
        /// <param name="activityName">活动名称。不对用户进行展示，仅供商家在后台管理活动使用。.</param>
        /// <param name="activityOperationStatus">活动操作状态.</param>
        /// <param name="activityStatus">活动状态。已激活状态代表活动正常运行，已终止状态代表商家终止活动，不可再发放。.</param>
        /// <param name="belongMerchantInfo">belongMerchantInfo.</param>
        /// <param name="bizTag">商家券业务标签，影响商家券对C端用户的展示形式。.</param>
        /// <param name="customerGuide">customerGuide.</param>
        /// <param name="publishEndTime">券发放结束时间。格式为：yyyy-MM-dd HH:mm:ss.</param>
        /// <param name="publishStartTime">券发放开始时间。格式为：yyyy-MM-dd HH:mm:ss.</param>
        /// <param name="summary">summary.</param>
        /// <param name="voucherAvailableScopeInfo">voucherAvailableScopeInfo.</param>
        /// <param name="voucherCustomerGuideInfo">voucherCustomerGuideInfo.</param>
        /// <param name="voucherDeductInfo">voucherDeductInfo.</param>
        /// <param name="voucherDisplayInfo">voucherDisplayInfo.</param>
        /// <param name="voucherDisplayPatternInfo">voucherDisplayPatternInfo.</param>
        /// <param name="voucherInventoryInfo">voucherInventoryInfo.</param>
        /// <param name="voucherSendModeInfo">voucherSendModeInfo.</param>
        /// <param name="voucherSendRule">voucherSendRule.</param>
        /// <param name="voucherType">券类型.</param>
        /// <param name="voucherUseRule">voucherUseRule.</param>
        /// <param name="voucherUseRuleInfo">voucherUseRuleInfo.</param>
        public AlipayMarketingActivityOrdervoucherQueryResponseModel(ActivityBaseInfo activityBaseInfo = default(ActivityBaseInfo), string activityId = default(string), string activityName = default(string), string activityOperationStatus = default(string), string activityStatus = default(string), BelongMerchantInfo belongMerchantInfo = default(BelongMerchantInfo), string bizTag = default(string), CustomerGuide customerGuide = default(CustomerGuide), string publishEndTime = default(string), string publishStartTime = default(string), VoucherSummary summary = default(VoucherSummary), VoucherAvailableScopeInfo voucherAvailableScopeInfo = default(VoucherAvailableScopeInfo), VoucherCustomerGuideInfo voucherCustomerGuideInfo = default(VoucherCustomerGuideInfo), VoucherDeductInfo voucherDeductInfo = default(VoucherDeductInfo), VoucherDisplayInfo voucherDisplayInfo = default(VoucherDisplayInfo), VoucherDisplayPatternInfo voucherDisplayPatternInfo = default(VoucherDisplayPatternInfo), VoucherInventoryInfo voucherInventoryInfo = default(VoucherInventoryInfo), VoucherSendModeInfo voucherSendModeInfo = default(VoucherSendModeInfo), VoucherSendRuleDetail voucherSendRule = default(VoucherSendRuleDetail), string voucherType = default(string), VoucherUseRule voucherUseRule = default(VoucherUseRule), VoucherUseRuleInfo voucherUseRuleInfo = default(VoucherUseRuleInfo))
        {
            this.ActivityBaseInfo = activityBaseInfo;
            this.ActivityId = activityId;
            this.ActivityName = activityName;
            this.ActivityOperationStatus = activityOperationStatus;
            this.ActivityStatus = activityStatus;
            this.BelongMerchantInfo = belongMerchantInfo;
            this.BizTag = bizTag;
            this.CustomerGuide = customerGuide;
            this.PublishEndTime = publishEndTime;
            this.PublishStartTime = publishStartTime;
            this.Summary = summary;
            this.VoucherAvailableScopeInfo = voucherAvailableScopeInfo;
            this.VoucherCustomerGuideInfo = voucherCustomerGuideInfo;
            this.VoucherDeductInfo = voucherDeductInfo;
            this.VoucherDisplayInfo = voucherDisplayInfo;
            this.VoucherDisplayPatternInfo = voucherDisplayPatternInfo;
            this.VoucherInventoryInfo = voucherInventoryInfo;
            this.VoucherSendModeInfo = voucherSendModeInfo;
            this.VoucherSendRule = voucherSendRule;
            this.VoucherType = voucherType;
            this.VoucherUseRule = voucherUseRule;
            this.VoucherUseRuleInfo = voucherUseRuleInfo;
        }

        /// <summary>
        /// Gets or Sets ActivityBaseInfo
        /// </summary>
        [DataMember(Name = "activity_base_info", EmitDefaultValue = false)]
        public ActivityBaseInfo ActivityBaseInfo { get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        /// <value>活动id</value>
        [DataMember(Name = "activity_id", EmitDefaultValue = false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称。不对用户进行展示，仅供商家在后台管理活动使用。
        /// </summary>
        /// <value>活动名称。不对用户进行展示，仅供商家在后台管理活动使用。</value>
        [DataMember(Name = "activity_name", EmitDefaultValue = false)]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动操作状态
        /// </summary>
        /// <value>活动操作状态</value>
        [DataMember(Name = "activity_operation_status", EmitDefaultValue = false)]
        public string ActivityOperationStatus { get; set; }

        /// <summary>
        /// 活动状态。已激活状态代表活动正常运行，已终止状态代表商家终止活动，不可再发放。
        /// </summary>
        /// <value>活动状态。已激活状态代表活动正常运行，已终止状态代表商家终止活动，不可再发放。</value>
        [DataMember(Name = "activity_status", EmitDefaultValue = false)]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// Gets or Sets BelongMerchantInfo
        /// </summary>
        [DataMember(Name = "belong_merchant_info", EmitDefaultValue = false)]
        public BelongMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// 商家券业务标签，影响商家券对C端用户的展示形式。
        /// </summary>
        /// <value>商家券业务标签，影响商家券对C端用户的展示形式。</value>
        [DataMember(Name = "biz_tag", EmitDefaultValue = false)]
        public string BizTag { get; set; }

        /// <summary>
        /// Gets or Sets CustomerGuide
        /// </summary>
        [DataMember(Name = "customer_guide", EmitDefaultValue = false)]
        public CustomerGuide CustomerGuide { get; set; }

        /// <summary>
        /// 券发放结束时间。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>券发放结束时间。格式为：yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "publish_end_time", EmitDefaultValue = false)]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 券发放开始时间。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>券发放开始时间。格式为：yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "publish_start_time", EmitDefaultValue = false)]
        public string PublishStartTime { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", EmitDefaultValue = false)]
        public VoucherSummary Summary { get; set; }

        /// <summary>
        /// Gets or Sets VoucherAvailableScopeInfo
        /// </summary>
        [DataMember(Name = "voucher_available_scope_info", EmitDefaultValue = false)]
        public VoucherAvailableScopeInfo VoucherAvailableScopeInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherCustomerGuideInfo
        /// </summary>
        [DataMember(Name = "voucher_customer_guide_info", EmitDefaultValue = false)]
        public VoucherCustomerGuideInfo VoucherCustomerGuideInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherDeductInfo
        /// </summary>
        [DataMember(Name = "voucher_deduct_info", EmitDefaultValue = false)]
        public VoucherDeductInfo VoucherDeductInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherDisplayInfo
        /// </summary>
        [DataMember(Name = "voucher_display_info", EmitDefaultValue = false)]
        public VoucherDisplayInfo VoucherDisplayInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherDisplayPatternInfo
        /// </summary>
        [DataMember(Name = "voucher_display_pattern_info", EmitDefaultValue = false)]
        public VoucherDisplayPatternInfo VoucherDisplayPatternInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherInventoryInfo
        /// </summary>
        [DataMember(Name = "voucher_inventory_info", EmitDefaultValue = false)]
        public VoucherInventoryInfo VoucherInventoryInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherSendModeInfo
        /// </summary>
        [DataMember(Name = "voucher_send_mode_info", EmitDefaultValue = false)]
        public VoucherSendModeInfo VoucherSendModeInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherSendRule
        /// </summary>
        [DataMember(Name = "voucher_send_rule", EmitDefaultValue = false)]
        public VoucherSendRuleDetail VoucherSendRule { get; set; }

        /// <summary>
        /// 券类型
        /// </summary>
        /// <value>券类型</value>
        [DataMember(Name = "voucher_type", EmitDefaultValue = false)]
        public string VoucherType { get; set; }

        /// <summary>
        /// Gets or Sets VoucherUseRule
        /// </summary>
        [DataMember(Name = "voucher_use_rule", EmitDefaultValue = false)]
        public VoucherUseRule VoucherUseRule { get; set; }

        /// <summary>
        /// Gets or Sets VoucherUseRuleInfo
        /// </summary>
        [DataMember(Name = "voucher_use_rule_info", EmitDefaultValue = false)]
        public VoucherUseRuleInfo VoucherUseRuleInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingActivityOrdervoucherQueryResponseModel {\n");
            sb.Append("  ActivityBaseInfo: ").Append(ActivityBaseInfo).Append("\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  ActivityName: ").Append(ActivityName).Append("\n");
            sb.Append("  ActivityOperationStatus: ").Append(ActivityOperationStatus).Append("\n");
            sb.Append("  ActivityStatus: ").Append(ActivityStatus).Append("\n");
            sb.Append("  BelongMerchantInfo: ").Append(BelongMerchantInfo).Append("\n");
            sb.Append("  BizTag: ").Append(BizTag).Append("\n");
            sb.Append("  CustomerGuide: ").Append(CustomerGuide).Append("\n");
            sb.Append("  PublishEndTime: ").Append(PublishEndTime).Append("\n");
            sb.Append("  PublishStartTime: ").Append(PublishStartTime).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  VoucherAvailableScopeInfo: ").Append(VoucherAvailableScopeInfo).Append("\n");
            sb.Append("  VoucherCustomerGuideInfo: ").Append(VoucherCustomerGuideInfo).Append("\n");
            sb.Append("  VoucherDeductInfo: ").Append(VoucherDeductInfo).Append("\n");
            sb.Append("  VoucherDisplayInfo: ").Append(VoucherDisplayInfo).Append("\n");
            sb.Append("  VoucherDisplayPatternInfo: ").Append(VoucherDisplayPatternInfo).Append("\n");
            sb.Append("  VoucherInventoryInfo: ").Append(VoucherInventoryInfo).Append("\n");
            sb.Append("  VoucherSendModeInfo: ").Append(VoucherSendModeInfo).Append("\n");
            sb.Append("  VoucherSendRule: ").Append(VoucherSendRule).Append("\n");
            sb.Append("  VoucherType: ").Append(VoucherType).Append("\n");
            sb.Append("  VoucherUseRule: ").Append(VoucherUseRule).Append("\n");
            sb.Append("  VoucherUseRuleInfo: ").Append(VoucherUseRuleInfo).Append("\n");
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
            return this.Equals(input as AlipayMarketingActivityOrdervoucherQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingActivityOrdervoucherQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingActivityOrdervoucherQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingActivityOrdervoucherQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActivityBaseInfo == input.ActivityBaseInfo ||
                    (this.ActivityBaseInfo != null &&
                    this.ActivityBaseInfo.Equals(input.ActivityBaseInfo))
                ) && 
                (
                    this.ActivityId == input.ActivityId ||
                    (this.ActivityId != null &&
                    this.ActivityId.Equals(input.ActivityId))
                ) && 
                (
                    this.ActivityName == input.ActivityName ||
                    (this.ActivityName != null &&
                    this.ActivityName.Equals(input.ActivityName))
                ) && 
                (
                    this.ActivityOperationStatus == input.ActivityOperationStatus ||
                    (this.ActivityOperationStatus != null &&
                    this.ActivityOperationStatus.Equals(input.ActivityOperationStatus))
                ) && 
                (
                    this.ActivityStatus == input.ActivityStatus ||
                    (this.ActivityStatus != null &&
                    this.ActivityStatus.Equals(input.ActivityStatus))
                ) && 
                (
                    this.BelongMerchantInfo == input.BelongMerchantInfo ||
                    (this.BelongMerchantInfo != null &&
                    this.BelongMerchantInfo.Equals(input.BelongMerchantInfo))
                ) && 
                (
                    this.BizTag == input.BizTag ||
                    (this.BizTag != null &&
                    this.BizTag.Equals(input.BizTag))
                ) && 
                (
                    this.CustomerGuide == input.CustomerGuide ||
                    (this.CustomerGuide != null &&
                    this.CustomerGuide.Equals(input.CustomerGuide))
                ) && 
                (
                    this.PublishEndTime == input.PublishEndTime ||
                    (this.PublishEndTime != null &&
                    this.PublishEndTime.Equals(input.PublishEndTime))
                ) && 
                (
                    this.PublishStartTime == input.PublishStartTime ||
                    (this.PublishStartTime != null &&
                    this.PublishStartTime.Equals(input.PublishStartTime))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.VoucherAvailableScopeInfo == input.VoucherAvailableScopeInfo ||
                    (this.VoucherAvailableScopeInfo != null &&
                    this.VoucherAvailableScopeInfo.Equals(input.VoucherAvailableScopeInfo))
                ) && 
                (
                    this.VoucherCustomerGuideInfo == input.VoucherCustomerGuideInfo ||
                    (this.VoucherCustomerGuideInfo != null &&
                    this.VoucherCustomerGuideInfo.Equals(input.VoucherCustomerGuideInfo))
                ) && 
                (
                    this.VoucherDeductInfo == input.VoucherDeductInfo ||
                    (this.VoucherDeductInfo != null &&
                    this.VoucherDeductInfo.Equals(input.VoucherDeductInfo))
                ) && 
                (
                    this.VoucherDisplayInfo == input.VoucherDisplayInfo ||
                    (this.VoucherDisplayInfo != null &&
                    this.VoucherDisplayInfo.Equals(input.VoucherDisplayInfo))
                ) && 
                (
                    this.VoucherDisplayPatternInfo == input.VoucherDisplayPatternInfo ||
                    (this.VoucherDisplayPatternInfo != null &&
                    this.VoucherDisplayPatternInfo.Equals(input.VoucherDisplayPatternInfo))
                ) && 
                (
                    this.VoucherInventoryInfo == input.VoucherInventoryInfo ||
                    (this.VoucherInventoryInfo != null &&
                    this.VoucherInventoryInfo.Equals(input.VoucherInventoryInfo))
                ) && 
                (
                    this.VoucherSendModeInfo == input.VoucherSendModeInfo ||
                    (this.VoucherSendModeInfo != null &&
                    this.VoucherSendModeInfo.Equals(input.VoucherSendModeInfo))
                ) && 
                (
                    this.VoucherSendRule == input.VoucherSendRule ||
                    (this.VoucherSendRule != null &&
                    this.VoucherSendRule.Equals(input.VoucherSendRule))
                ) && 
                (
                    this.VoucherType == input.VoucherType ||
                    (this.VoucherType != null &&
                    this.VoucherType.Equals(input.VoucherType))
                ) && 
                (
                    this.VoucherUseRule == input.VoucherUseRule ||
                    (this.VoucherUseRule != null &&
                    this.VoucherUseRule.Equals(input.VoucherUseRule))
                ) && 
                (
                    this.VoucherUseRuleInfo == input.VoucherUseRuleInfo ||
                    (this.VoucherUseRuleInfo != null &&
                    this.VoucherUseRuleInfo.Equals(input.VoucherUseRuleInfo))
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
                if (this.ActivityBaseInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityBaseInfo.GetHashCode();
                }
                if (this.ActivityId != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityId.GetHashCode();
                }
                if (this.ActivityName != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityName.GetHashCode();
                }
                if (this.ActivityOperationStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityOperationStatus.GetHashCode();
                }
                if (this.ActivityStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityStatus.GetHashCode();
                }
                if (this.BelongMerchantInfo != null)
                {
                    hashCode = (hashCode * 59) + this.BelongMerchantInfo.GetHashCode();
                }
                if (this.BizTag != null)
                {
                    hashCode = (hashCode * 59) + this.BizTag.GetHashCode();
                }
                if (this.CustomerGuide != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerGuide.GetHashCode();
                }
                if (this.PublishEndTime != null)
                {
                    hashCode = (hashCode * 59) + this.PublishEndTime.GetHashCode();
                }
                if (this.PublishStartTime != null)
                {
                    hashCode = (hashCode * 59) + this.PublishStartTime.GetHashCode();
                }
                if (this.Summary != null)
                {
                    hashCode = (hashCode * 59) + this.Summary.GetHashCode();
                }
                if (this.VoucherAvailableScopeInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherAvailableScopeInfo.GetHashCode();
                }
                if (this.VoucherCustomerGuideInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherCustomerGuideInfo.GetHashCode();
                }
                if (this.VoucherDeductInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherDeductInfo.GetHashCode();
                }
                if (this.VoucherDisplayInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherDisplayInfo.GetHashCode();
                }
                if (this.VoucherDisplayPatternInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherDisplayPatternInfo.GetHashCode();
                }
                if (this.VoucherInventoryInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherInventoryInfo.GetHashCode();
                }
                if (this.VoucherSendModeInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherSendModeInfo.GetHashCode();
                }
                if (this.VoucherSendRule != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherSendRule.GetHashCode();
                }
                if (this.VoucherType != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherType.GetHashCode();
                }
                if (this.VoucherUseRule != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherUseRule.GetHashCode();
                }
                if (this.VoucherUseRuleInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherUseRuleInfo.GetHashCode();
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
