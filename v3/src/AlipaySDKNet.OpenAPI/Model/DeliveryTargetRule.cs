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
    /// DeliveryTargetRule
    /// </summary>
    [DataContract(Name = "DeliveryTargetRule")]
    public partial class DeliveryTargetRule : IEquatable<DeliveryTargetRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryTargetRule" /> class.
        /// </summary>
        /// <param name="brandIdList">指定品牌id。 说明：如商户需选择某个品牌下维护的收款账号，请上传相关品牌id.</param>
        /// <param name="deliveryAvailableScope">deliveryAvailableScope.</param>
        /// <param name="deliveryCityCodeRule">deliveryCityCodeRule.</param>
        /// <param name="deliveryMerchantInfos">曝光商户选取列表。 说明：需要传入您期望曝光的商户的商户号，传入为空时默认使用投放优惠券活动的适用范围。 限制：曝光商户号需与投放归属商户号相同，或传入有跨主体授权关系的商户号或有弱绑定关系的M3账号.</param>
        /// <param name="deliveryMerchantMode">指定支付成功页模式。 枚举值： MANUAL_INPUT_MERCHANT：指定收款账号 IN_SERVICE_VOUCHER_MERCHANT：优惠券可核收款账号（仅支持支付券） 收款账号相关规则:接入指南.</param>
        /// <param name="deliveryMerchantRule">deliveryMerchantRule.</param>
        /// <param name="deliveryPromoTags">推荐定向曝光订单优惠标记。 1. 创建交易订单时，上传符合的订单优惠标。在业务参数信息“business_params”的子字段“delivery_promo_tags”填充订单优惠标。“统一收单交易支付接口”详情查看：https://opendocs.alipay.com/open/02ekfp?scene&#x3D;32。 2. 订单优惠标，检验规则： * 单个优惠标最大长度32字节。多个标记值以英文逗号分隔。 * 单个优惠标仅支持字母/数字/下划线。 3. 订单优惠标规则和其他推荐规则同时叠加。.</param>
        /// <param name="deliveryRecallMode">投放召回模式，现在支持CITY_RECALL（城市召回)和SHOP_RECALL（门店召回)两种模式。城市召回即当前城市投放，用户当前城市可领取；门店模式即门店附近投放，用户距离门店附近可领取。.</param>
        /// <param name="deliverySearchBoxRule">deliverySearchBoxRule.</param>
        /// <param name="deliveryType">小程序推广可用。枚举值：SERVICE_DIRECT.</param>
        public DeliveryTargetRule(List<string> brandIdList = default(List<string>), DeliveryAvailableScope deliveryAvailableScope = default(DeliveryAvailableScope), DeliveryCityCodeRule deliveryCityCodeRule = default(DeliveryCityCodeRule), List<DeliveryMerchantInfo> deliveryMerchantInfos = default(List<DeliveryMerchantInfo>), string deliveryMerchantMode = default(string), DeliveryMerchantRule deliveryMerchantRule = default(DeliveryMerchantRule), string deliveryPromoTags = default(string), string deliveryRecallMode = default(string), DeliverySearchBoxRule deliverySearchBoxRule = default(DeliverySearchBoxRule), string deliveryType = default(string))
        {
            this.BrandIdList = brandIdList;
            this.DeliveryAvailableScope = deliveryAvailableScope;
            this.DeliveryCityCodeRule = deliveryCityCodeRule;
            this.DeliveryMerchantInfos = deliveryMerchantInfos;
            this.DeliveryMerchantMode = deliveryMerchantMode;
            this.DeliveryMerchantRule = deliveryMerchantRule;
            this.DeliveryPromoTags = deliveryPromoTags;
            this.DeliveryRecallMode = deliveryRecallMode;
            this.DeliverySearchBoxRule = deliverySearchBoxRule;
            this.DeliveryType = deliveryType;
        }

        /// <summary>
        /// 指定品牌id。 说明：如商户需选择某个品牌下维护的收款账号，请上传相关品牌id
        /// </summary>
        /// <value>指定品牌id。 说明：如商户需选择某个品牌下维护的收款账号，请上传相关品牌id</value>
        [DataMember(Name = "brand_id_list", EmitDefaultValue = false)]
        public List<string> BrandIdList { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryAvailableScope
        /// </summary>
        [DataMember(Name = "delivery_available_scope", EmitDefaultValue = false)]
        public DeliveryAvailableScope DeliveryAvailableScope { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryCityCodeRule
        /// </summary>
        [DataMember(Name = "delivery_city_code_rule", EmitDefaultValue = false)]
        public DeliveryCityCodeRule DeliveryCityCodeRule { get; set; }

        /// <summary>
        /// 曝光商户选取列表。 说明：需要传入您期望曝光的商户的商户号，传入为空时默认使用投放优惠券活动的适用范围。 限制：曝光商户号需与投放归属商户号相同，或传入有跨主体授权关系的商户号或有弱绑定关系的M3账号
        /// </summary>
        /// <value>曝光商户选取列表。 说明：需要传入您期望曝光的商户的商户号，传入为空时默认使用投放优惠券活动的适用范围。 限制：曝光商户号需与投放归属商户号相同，或传入有跨主体授权关系的商户号或有弱绑定关系的M3账号</value>
        [DataMember(Name = "delivery_merchant_infos", EmitDefaultValue = false)]
        public List<DeliveryMerchantInfo> DeliveryMerchantInfos { get; set; }

        /// <summary>
        /// 指定支付成功页模式。 枚举值： MANUAL_INPUT_MERCHANT：指定收款账号 IN_SERVICE_VOUCHER_MERCHANT：优惠券可核收款账号（仅支持支付券） 收款账号相关规则:接入指南
        /// </summary>
        /// <value>指定支付成功页模式。 枚举值： MANUAL_INPUT_MERCHANT：指定收款账号 IN_SERVICE_VOUCHER_MERCHANT：优惠券可核收款账号（仅支持支付券） 收款账号相关规则:接入指南</value>
        [DataMember(Name = "delivery_merchant_mode", EmitDefaultValue = false)]
        public string DeliveryMerchantMode { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryMerchantRule
        /// </summary>
        [DataMember(Name = "delivery_merchant_rule", EmitDefaultValue = false)]
        public DeliveryMerchantRule DeliveryMerchantRule { get; set; }

        /// <summary>
        /// 推荐定向曝光订单优惠标记。 1. 创建交易订单时，上传符合的订单优惠标。在业务参数信息“business_params”的子字段“delivery_promo_tags”填充订单优惠标。“统一收单交易支付接口”详情查看：https://opendocs.alipay.com/open/02ekfp?scene&#x3D;32。 2. 订单优惠标，检验规则： * 单个优惠标最大长度32字节。多个标记值以英文逗号分隔。 * 单个优惠标仅支持字母/数字/下划线。 3. 订单优惠标规则和其他推荐规则同时叠加。
        /// </summary>
        /// <value>推荐定向曝光订单优惠标记。 1. 创建交易订单时，上传符合的订单优惠标。在业务参数信息“business_params”的子字段“delivery_promo_tags”填充订单优惠标。“统一收单交易支付接口”详情查看：https://opendocs.alipay.com/open/02ekfp?scene&#x3D;32。 2. 订单优惠标，检验规则： * 单个优惠标最大长度32字节。多个标记值以英文逗号分隔。 * 单个优惠标仅支持字母/数字/下划线。 3. 订单优惠标规则和其他推荐规则同时叠加。</value>
        [DataMember(Name = "delivery_promo_tags", EmitDefaultValue = false)]
        public string DeliveryPromoTags { get; set; }

        /// <summary>
        /// 投放召回模式，现在支持CITY_RECALL（城市召回)和SHOP_RECALL（门店召回)两种模式。城市召回即当前城市投放，用户当前城市可领取；门店模式即门店附近投放，用户距离门店附近可领取。
        /// </summary>
        /// <value>投放召回模式，现在支持CITY_RECALL（城市召回)和SHOP_RECALL（门店召回)两种模式。城市召回即当前城市投放，用户当前城市可领取；门店模式即门店附近投放，用户距离门店附近可领取。</value>
        [DataMember(Name = "delivery_recall_mode", EmitDefaultValue = false)]
        public string DeliveryRecallMode { get; set; }

        /// <summary>
        /// Gets or Sets DeliverySearchBoxRule
        /// </summary>
        [DataMember(Name = "delivery_search_box_rule", EmitDefaultValue = false)]
        public DeliverySearchBoxRule DeliverySearchBoxRule { get; set; }

        /// <summary>
        /// 小程序推广可用。枚举值：SERVICE_DIRECT
        /// </summary>
        /// <value>小程序推广可用。枚举值：SERVICE_DIRECT</value>
        [DataMember(Name = "delivery_type", EmitDefaultValue = false)]
        public string DeliveryType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeliveryTargetRule {\n");
            sb.Append("  BrandIdList: ").Append(BrandIdList).Append("\n");
            sb.Append("  DeliveryAvailableScope: ").Append(DeliveryAvailableScope).Append("\n");
            sb.Append("  DeliveryCityCodeRule: ").Append(DeliveryCityCodeRule).Append("\n");
            sb.Append("  DeliveryMerchantInfos: ").Append(DeliveryMerchantInfos).Append("\n");
            sb.Append("  DeliveryMerchantMode: ").Append(DeliveryMerchantMode).Append("\n");
            sb.Append("  DeliveryMerchantRule: ").Append(DeliveryMerchantRule).Append("\n");
            sb.Append("  DeliveryPromoTags: ").Append(DeliveryPromoTags).Append("\n");
            sb.Append("  DeliveryRecallMode: ").Append(DeliveryRecallMode).Append("\n");
            sb.Append("  DeliverySearchBoxRule: ").Append(DeliverySearchBoxRule).Append("\n");
            sb.Append("  DeliveryType: ").Append(DeliveryType).Append("\n");
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
            return this.Equals(input as DeliveryTargetRule);
        }

        /// <summary>
        /// Returns true if DeliveryTargetRule instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryTargetRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryTargetRule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BrandIdList == input.BrandIdList ||
                    this.BrandIdList != null &&
                    input.BrandIdList != null &&
                    this.BrandIdList.SequenceEqual(input.BrandIdList)
                ) && 
                (
                    this.DeliveryAvailableScope == input.DeliveryAvailableScope ||
                    (this.DeliveryAvailableScope != null &&
                    this.DeliveryAvailableScope.Equals(input.DeliveryAvailableScope))
                ) && 
                (
                    this.DeliveryCityCodeRule == input.DeliveryCityCodeRule ||
                    (this.DeliveryCityCodeRule != null &&
                    this.DeliveryCityCodeRule.Equals(input.DeliveryCityCodeRule))
                ) && 
                (
                    this.DeliveryMerchantInfos == input.DeliveryMerchantInfos ||
                    this.DeliveryMerchantInfos != null &&
                    input.DeliveryMerchantInfos != null &&
                    this.DeliveryMerchantInfos.SequenceEqual(input.DeliveryMerchantInfos)
                ) && 
                (
                    this.DeliveryMerchantMode == input.DeliveryMerchantMode ||
                    (this.DeliveryMerchantMode != null &&
                    this.DeliveryMerchantMode.Equals(input.DeliveryMerchantMode))
                ) && 
                (
                    this.DeliveryMerchantRule == input.DeliveryMerchantRule ||
                    (this.DeliveryMerchantRule != null &&
                    this.DeliveryMerchantRule.Equals(input.DeliveryMerchantRule))
                ) && 
                (
                    this.DeliveryPromoTags == input.DeliveryPromoTags ||
                    (this.DeliveryPromoTags != null &&
                    this.DeliveryPromoTags.Equals(input.DeliveryPromoTags))
                ) && 
                (
                    this.DeliveryRecallMode == input.DeliveryRecallMode ||
                    (this.DeliveryRecallMode != null &&
                    this.DeliveryRecallMode.Equals(input.DeliveryRecallMode))
                ) && 
                (
                    this.DeliverySearchBoxRule == input.DeliverySearchBoxRule ||
                    (this.DeliverySearchBoxRule != null &&
                    this.DeliverySearchBoxRule.Equals(input.DeliverySearchBoxRule))
                ) && 
                (
                    this.DeliveryType == input.DeliveryType ||
                    (this.DeliveryType != null &&
                    this.DeliveryType.Equals(input.DeliveryType))
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
                if (this.BrandIdList != null)
                {
                    hashCode = (hashCode * 59) + this.BrandIdList.GetHashCode();
                }
                if (this.DeliveryAvailableScope != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryAvailableScope.GetHashCode();
                }
                if (this.DeliveryCityCodeRule != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryCityCodeRule.GetHashCode();
                }
                if (this.DeliveryMerchantInfos != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryMerchantInfos.GetHashCode();
                }
                if (this.DeliveryMerchantMode != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryMerchantMode.GetHashCode();
                }
                if (this.DeliveryMerchantRule != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryMerchantRule.GetHashCode();
                }
                if (this.DeliveryPromoTags != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryPromoTags.GetHashCode();
                }
                if (this.DeliveryRecallMode != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryRecallMode.GetHashCode();
                }
                if (this.DeliverySearchBoxRule != null)
                {
                    hashCode = (hashCode * 59) + this.DeliverySearchBoxRule.GetHashCode();
                }
                if (this.DeliveryType != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryType.GetHashCode();
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
