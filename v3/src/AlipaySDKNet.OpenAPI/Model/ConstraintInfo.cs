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
    /// ConstraintInfo
    /// </summary>
    [DataContract(Name = "ConstraintInfo")]
    public partial class ConstraintInfo : IEquatable<ConstraintInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstraintInfo" /> class.
        /// </summary>
        /// <param name="cashPoolId">资金池ID  （数据来源：需要ISV自己去口碑销售中台创建资金池，拿到对应的资金池ID，此参数仅适用ISV接入口福业务场景时使用，其他场景不需要传递此参数）.</param>
        /// <param name="crowdGroupId">人群规则组ID  仅直发奖类型活动设置有效，通过调用营销活动人群组规则创建接口参数返回.</param>
        /// <param name="crowdRestriction">针对指定人群的约束条件.</param>
        /// <param name="crowdRestrictionValue">根据crowd_restriction的值不同，设置相应的值，如果crowd_restriction是“MEMBER_CARD”，crowd_restriction_value就是关联会员卡模版ID集合，用逗号拼接.</param>
        /// <param name="itemIds">单品码列表  仅在创建消费单品送活动时设置，最多设置500个单品码,由商户根据自己的商品管理自定义，一般为国标码.</param>
        /// <param name="minCost">最低消费金额，单位元  仅在创建消费送礼包活动时设置.</param>
        /// <param name="subsidyPercent">补贴百分比,95表示 95%，支持两位小数  （参数说明：补贴比例95%，表示ISV出资95%，商户出资5%，此参数仅适用ISV接入口福业务场景时使用，其他场景不需要传递此参数）.</param>
        /// <param name="suitShops">活动适用的门店列表  仅品牌商发起的招商活动可为空  最多支持10w家门店.</param>
        /// <param name="userWinCount">活动期间用户能够参与的次数限制  如果不设置则不限制参与次数.</param>
        /// <param name="userWinFrequency">活动期间用户能够参与的频率限制  如果不设置则不限制参与频率  每日中奖1次: D||1   每周中奖2次: W||2   每月中奖3次: M||3.</param>
        public ConstraintInfo(string cashPoolId = default(string), string crowdGroupId = default(string), string crowdRestriction = default(string), string crowdRestrictionValue = default(string), List<string> itemIds = default(List<string>), string minCost = default(string), string subsidyPercent = default(string), List<string> suitShops = default(List<string>), string userWinCount = default(string), string userWinFrequency = default(string))
        {
            this.CashPoolId = cashPoolId;
            this.CrowdGroupId = crowdGroupId;
            this.CrowdRestriction = crowdRestriction;
            this.CrowdRestrictionValue = crowdRestrictionValue;
            this.ItemIds = itemIds;
            this.MinCost = minCost;
            this.SubsidyPercent = subsidyPercent;
            this.SuitShops = suitShops;
            this.UserWinCount = userWinCount;
            this.UserWinFrequency = userWinFrequency;
        }

        /// <summary>
        /// 资金池ID  （数据来源：需要ISV自己去口碑销售中台创建资金池，拿到对应的资金池ID，此参数仅适用ISV接入口福业务场景时使用，其他场景不需要传递此参数）
        /// </summary>
        /// <value>资金池ID  （数据来源：需要ISV自己去口碑销售中台创建资金池，拿到对应的资金池ID，此参数仅适用ISV接入口福业务场景时使用，其他场景不需要传递此参数）</value>
        [DataMember(Name = "cash_pool_id", EmitDefaultValue = false)]
        public string CashPoolId { get; set; }

        /// <summary>
        /// 人群规则组ID  仅直发奖类型活动设置有效，通过调用营销活动人群组规则创建接口参数返回
        /// </summary>
        /// <value>人群规则组ID  仅直发奖类型活动设置有效，通过调用营销活动人群组规则创建接口参数返回</value>
        [DataMember(Name = "crowd_group_id", EmitDefaultValue = false)]
        public string CrowdGroupId { get; set; }

        /// <summary>
        /// 针对指定人群的约束条件
        /// </summary>
        /// <value>针对指定人群的约束条件</value>
        [DataMember(Name = "crowd_restriction", EmitDefaultValue = false)]
        public string CrowdRestriction { get; set; }

        /// <summary>
        /// 根据crowd_restriction的值不同，设置相应的值，如果crowd_restriction是“MEMBER_CARD”，crowd_restriction_value就是关联会员卡模版ID集合，用逗号拼接
        /// </summary>
        /// <value>根据crowd_restriction的值不同，设置相应的值，如果crowd_restriction是“MEMBER_CARD”，crowd_restriction_value就是关联会员卡模版ID集合，用逗号拼接</value>
        [DataMember(Name = "crowd_restriction_value", EmitDefaultValue = false)]
        public string CrowdRestrictionValue { get; set; }

        /// <summary>
        /// 单品码列表  仅在创建消费单品送活动时设置，最多设置500个单品码,由商户根据自己的商品管理自定义，一般为国标码
        /// </summary>
        /// <value>单品码列表  仅在创建消费单品送活动时设置，最多设置500个单品码,由商户根据自己的商品管理自定义，一般为国标码</value>
        [DataMember(Name = "item_ids", EmitDefaultValue = false)]
        public List<string> ItemIds { get; set; }

        /// <summary>
        /// 最低消费金额，单位元  仅在创建消费送礼包活动时设置
        /// </summary>
        /// <value>最低消费金额，单位元  仅在创建消费送礼包活动时设置</value>
        [DataMember(Name = "min_cost", EmitDefaultValue = false)]
        public string MinCost { get; set; }

        /// <summary>
        /// 补贴百分比,95表示 95%，支持两位小数  （参数说明：补贴比例95%，表示ISV出资95%，商户出资5%，此参数仅适用ISV接入口福业务场景时使用，其他场景不需要传递此参数）
        /// </summary>
        /// <value>补贴百分比,95表示 95%，支持两位小数  （参数说明：补贴比例95%，表示ISV出资95%，商户出资5%，此参数仅适用ISV接入口福业务场景时使用，其他场景不需要传递此参数）</value>
        [DataMember(Name = "subsidy_percent", EmitDefaultValue = false)]
        public string SubsidyPercent { get; set; }

        /// <summary>
        /// 活动适用的门店列表  仅品牌商发起的招商活动可为空  最多支持10w家门店
        /// </summary>
        /// <value>活动适用的门店列表  仅品牌商发起的招商活动可为空  最多支持10w家门店</value>
        [DataMember(Name = "suit_shops", EmitDefaultValue = false)]
        public List<string> SuitShops { get; set; }

        /// <summary>
        /// 活动期间用户能够参与的次数限制  如果不设置则不限制参与次数
        /// </summary>
        /// <value>活动期间用户能够参与的次数限制  如果不设置则不限制参与次数</value>
        [DataMember(Name = "user_win_count", EmitDefaultValue = false)]
        public string UserWinCount { get; set; }

        /// <summary>
        /// 活动期间用户能够参与的频率限制  如果不设置则不限制参与频率  每日中奖1次: D||1   每周中奖2次: W||2   每月中奖3次: M||3
        /// </summary>
        /// <value>活动期间用户能够参与的频率限制  如果不设置则不限制参与频率  每日中奖1次: D||1   每周中奖2次: W||2   每月中奖3次: M||3</value>
        [DataMember(Name = "user_win_frequency", EmitDefaultValue = false)]
        public string UserWinFrequency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConstraintInfo {\n");
            sb.Append("  CashPoolId: ").Append(CashPoolId).Append("\n");
            sb.Append("  CrowdGroupId: ").Append(CrowdGroupId).Append("\n");
            sb.Append("  CrowdRestriction: ").Append(CrowdRestriction).Append("\n");
            sb.Append("  CrowdRestrictionValue: ").Append(CrowdRestrictionValue).Append("\n");
            sb.Append("  ItemIds: ").Append(ItemIds).Append("\n");
            sb.Append("  MinCost: ").Append(MinCost).Append("\n");
            sb.Append("  SubsidyPercent: ").Append(SubsidyPercent).Append("\n");
            sb.Append("  SuitShops: ").Append(SuitShops).Append("\n");
            sb.Append("  UserWinCount: ").Append(UserWinCount).Append("\n");
            sb.Append("  UserWinFrequency: ").Append(UserWinFrequency).Append("\n");
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
            return this.Equals(input as ConstraintInfo);
        }

        /// <summary>
        /// Returns true if ConstraintInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ConstraintInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConstraintInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CashPoolId == input.CashPoolId ||
                    (this.CashPoolId != null &&
                    this.CashPoolId.Equals(input.CashPoolId))
                ) && 
                (
                    this.CrowdGroupId == input.CrowdGroupId ||
                    (this.CrowdGroupId != null &&
                    this.CrowdGroupId.Equals(input.CrowdGroupId))
                ) && 
                (
                    this.CrowdRestriction == input.CrowdRestriction ||
                    (this.CrowdRestriction != null &&
                    this.CrowdRestriction.Equals(input.CrowdRestriction))
                ) && 
                (
                    this.CrowdRestrictionValue == input.CrowdRestrictionValue ||
                    (this.CrowdRestrictionValue != null &&
                    this.CrowdRestrictionValue.Equals(input.CrowdRestrictionValue))
                ) && 
                (
                    this.ItemIds == input.ItemIds ||
                    this.ItemIds != null &&
                    input.ItemIds != null &&
                    this.ItemIds.SequenceEqual(input.ItemIds)
                ) && 
                (
                    this.MinCost == input.MinCost ||
                    (this.MinCost != null &&
                    this.MinCost.Equals(input.MinCost))
                ) && 
                (
                    this.SubsidyPercent == input.SubsidyPercent ||
                    (this.SubsidyPercent != null &&
                    this.SubsidyPercent.Equals(input.SubsidyPercent))
                ) && 
                (
                    this.SuitShops == input.SuitShops ||
                    this.SuitShops != null &&
                    input.SuitShops != null &&
                    this.SuitShops.SequenceEqual(input.SuitShops)
                ) && 
                (
                    this.UserWinCount == input.UserWinCount ||
                    (this.UserWinCount != null &&
                    this.UserWinCount.Equals(input.UserWinCount))
                ) && 
                (
                    this.UserWinFrequency == input.UserWinFrequency ||
                    (this.UserWinFrequency != null &&
                    this.UserWinFrequency.Equals(input.UserWinFrequency))
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
                if (this.CashPoolId != null)
                {
                    hashCode = (hashCode * 59) + this.CashPoolId.GetHashCode();
                }
                if (this.CrowdGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.CrowdGroupId.GetHashCode();
                }
                if (this.CrowdRestriction != null)
                {
                    hashCode = (hashCode * 59) + this.CrowdRestriction.GetHashCode();
                }
                if (this.CrowdRestrictionValue != null)
                {
                    hashCode = (hashCode * 59) + this.CrowdRestrictionValue.GetHashCode();
                }
                if (this.ItemIds != null)
                {
                    hashCode = (hashCode * 59) + this.ItemIds.GetHashCode();
                }
                if (this.MinCost != null)
                {
                    hashCode = (hashCode * 59) + this.MinCost.GetHashCode();
                }
                if (this.SubsidyPercent != null)
                {
                    hashCode = (hashCode * 59) + this.SubsidyPercent.GetHashCode();
                }
                if (this.SuitShops != null)
                {
                    hashCode = (hashCode * 59) + this.SuitShops.GetHashCode();
                }
                if (this.UserWinCount != null)
                {
                    hashCode = (hashCode * 59) + this.UserWinCount.GetHashCode();
                }
                if (this.UserWinFrequency != null)
                {
                    hashCode = (hashCode * 59) + this.UserWinFrequency.GetHashCode();
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
