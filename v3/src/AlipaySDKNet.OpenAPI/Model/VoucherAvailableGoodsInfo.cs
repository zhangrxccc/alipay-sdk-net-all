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
    /// VoucherAvailableGoodsInfo
    /// </summary>
    [DataContract(Name = "VoucherAvailableGoodsInfo")]
    public partial class VoucherAvailableGoodsInfo : IEquatable<VoucherAvailableGoodsInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherAvailableGoodsInfo" /> class.
        /// </summary>
        /// <param name="availableGoodsSkuIds">可优惠商品编码，商家自定义商品编码。当用户支付时，交易中的商品编码和支付券配置的商品编码有任一匹配时，可以使用优惠券。.</param>
        /// <param name="excludeGoodsSkuIds">不可核销商品编码，商家自定义商品编码。当用户支付时，交易中的商品编码和支付券配置的商品编码有任一匹配时，不可以使用优惠券。.</param>
        /// <param name="goodsDescription">商品描述信息。 用于券面展示，向用户介绍商品.</param>
        /// <param name="goodsDetail">商品详情，会展示在特定渠道(如服务市场团购业务插件的套餐明细)。.</param>
        /// <param name="goodsDetailImages">商品详情图片列表，会展示在特定渠道(如服务市场团购业务插件的头图).</param>
        /// <param name="goodsDetailRichDescription">商品详情富文本描述.</param>
        /// <param name="goodsName">商品名称。.</param>
        /// <param name="originAmount">原价。说明：该字段可不填，填入商品名称goods_name则必填;.</param>
        public VoucherAvailableGoodsInfo(List<string> availableGoodsSkuIds = default(List<string>), List<string> excludeGoodsSkuIds = default(List<string>), string goodsDescription = default(string), string goodsDetail = default(string), List<string> goodsDetailImages = default(List<string>), string goodsDetailRichDescription = default(string), string goodsName = default(string), string originAmount = default(string))
        {
            this.AvailableGoodsSkuIds = availableGoodsSkuIds;
            this.ExcludeGoodsSkuIds = excludeGoodsSkuIds;
            this.GoodsDescription = goodsDescription;
            this.GoodsDetail = goodsDetail;
            this.GoodsDetailImages = goodsDetailImages;
            this.GoodsDetailRichDescription = goodsDetailRichDescription;
            this.GoodsName = goodsName;
            this.OriginAmount = originAmount;
        }

        /// <summary>
        /// 可优惠商品编码，商家自定义商品编码。当用户支付时，交易中的商品编码和支付券配置的商品编码有任一匹配时，可以使用优惠券。
        /// </summary>
        /// <value>可优惠商品编码，商家自定义商品编码。当用户支付时，交易中的商品编码和支付券配置的商品编码有任一匹配时，可以使用优惠券。</value>
        [DataMember(Name = "available_goods_sku_ids", EmitDefaultValue = false)]
        public List<string> AvailableGoodsSkuIds { get; set; }

        /// <summary>
        /// 不可核销商品编码，商家自定义商品编码。当用户支付时，交易中的商品编码和支付券配置的商品编码有任一匹配时，不可以使用优惠券。
        /// </summary>
        /// <value>不可核销商品编码，商家自定义商品编码。当用户支付时，交易中的商品编码和支付券配置的商品编码有任一匹配时，不可以使用优惠券。</value>
        [DataMember(Name = "exclude_goods_sku_ids", EmitDefaultValue = false)]
        public List<string> ExcludeGoodsSkuIds { get; set; }

        /// <summary>
        /// 商品描述信息。 用于券面展示，向用户介绍商品
        /// </summary>
        /// <value>商品描述信息。 用于券面展示，向用户介绍商品</value>
        [DataMember(Name = "goods_description", EmitDefaultValue = false)]
        public string GoodsDescription { get; set; }

        /// <summary>
        /// 商品详情，会展示在特定渠道(如服务市场团购业务插件的套餐明细)。
        /// </summary>
        /// <value>商品详情，会展示在特定渠道(如服务市场团购业务插件的套餐明细)。</value>
        [DataMember(Name = "goods_detail", EmitDefaultValue = false)]
        public string GoodsDetail { get; set; }

        /// <summary>
        /// 商品详情图片列表，会展示在特定渠道(如服务市场团购业务插件的头图)
        /// </summary>
        /// <value>商品详情图片列表，会展示在特定渠道(如服务市场团购业务插件的头图)</value>
        [DataMember(Name = "goods_detail_images", EmitDefaultValue = false)]
        public List<string> GoodsDetailImages { get; set; }

        /// <summary>
        /// 商品详情富文本描述
        /// </summary>
        /// <value>商品详情富文本描述</value>
        [DataMember(Name = "goods_detail_rich_description", EmitDefaultValue = false)]
        public string GoodsDetailRichDescription { get; set; }

        /// <summary>
        /// 商品名称。
        /// </summary>
        /// <value>商品名称。</value>
        [DataMember(Name = "goods_name", EmitDefaultValue = false)]
        public string GoodsName { get; set; }

        /// <summary>
        /// 原价。说明：该字段可不填，填入商品名称goods_name则必填;
        /// </summary>
        /// <value>原价。说明：该字段可不填，填入商品名称goods_name则必填;</value>
        [DataMember(Name = "origin_amount", EmitDefaultValue = false)]
        public string OriginAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherAvailableGoodsInfo {\n");
            sb.Append("  AvailableGoodsSkuIds: ").Append(AvailableGoodsSkuIds).Append("\n");
            sb.Append("  ExcludeGoodsSkuIds: ").Append(ExcludeGoodsSkuIds).Append("\n");
            sb.Append("  GoodsDescription: ").Append(GoodsDescription).Append("\n");
            sb.Append("  GoodsDetail: ").Append(GoodsDetail).Append("\n");
            sb.Append("  GoodsDetailImages: ").Append(GoodsDetailImages).Append("\n");
            sb.Append("  GoodsDetailRichDescription: ").Append(GoodsDetailRichDescription).Append("\n");
            sb.Append("  GoodsName: ").Append(GoodsName).Append("\n");
            sb.Append("  OriginAmount: ").Append(OriginAmount).Append("\n");
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
            return this.Equals(input as VoucherAvailableGoodsInfo);
        }

        /// <summary>
        /// Returns true if VoucherAvailableGoodsInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherAvailableGoodsInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherAvailableGoodsInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AvailableGoodsSkuIds == input.AvailableGoodsSkuIds ||
                    this.AvailableGoodsSkuIds != null &&
                    input.AvailableGoodsSkuIds != null &&
                    this.AvailableGoodsSkuIds.SequenceEqual(input.AvailableGoodsSkuIds)
                ) && 
                (
                    this.ExcludeGoodsSkuIds == input.ExcludeGoodsSkuIds ||
                    this.ExcludeGoodsSkuIds != null &&
                    input.ExcludeGoodsSkuIds != null &&
                    this.ExcludeGoodsSkuIds.SequenceEqual(input.ExcludeGoodsSkuIds)
                ) && 
                (
                    this.GoodsDescription == input.GoodsDescription ||
                    (this.GoodsDescription != null &&
                    this.GoodsDescription.Equals(input.GoodsDescription))
                ) && 
                (
                    this.GoodsDetail == input.GoodsDetail ||
                    (this.GoodsDetail != null &&
                    this.GoodsDetail.Equals(input.GoodsDetail))
                ) && 
                (
                    this.GoodsDetailImages == input.GoodsDetailImages ||
                    this.GoodsDetailImages != null &&
                    input.GoodsDetailImages != null &&
                    this.GoodsDetailImages.SequenceEqual(input.GoodsDetailImages)
                ) && 
                (
                    this.GoodsDetailRichDescription == input.GoodsDetailRichDescription ||
                    (this.GoodsDetailRichDescription != null &&
                    this.GoodsDetailRichDescription.Equals(input.GoodsDetailRichDescription))
                ) && 
                (
                    this.GoodsName == input.GoodsName ||
                    (this.GoodsName != null &&
                    this.GoodsName.Equals(input.GoodsName))
                ) && 
                (
                    this.OriginAmount == input.OriginAmount ||
                    (this.OriginAmount != null &&
                    this.OriginAmount.Equals(input.OriginAmount))
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
                if (this.AvailableGoodsSkuIds != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableGoodsSkuIds.GetHashCode();
                }
                if (this.ExcludeGoodsSkuIds != null)
                {
                    hashCode = (hashCode * 59) + this.ExcludeGoodsSkuIds.GetHashCode();
                }
                if (this.GoodsDescription != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsDescription.GetHashCode();
                }
                if (this.GoodsDetail != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsDetail.GetHashCode();
                }
                if (this.GoodsDetailImages != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsDetailImages.GetHashCode();
                }
                if (this.GoodsDetailRichDescription != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsDetailRichDescription.GetHashCode();
                }
                if (this.GoodsName != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsName.GetHashCode();
                }
                if (this.OriginAmount != null)
                {
                    hashCode = (hashCode * 59) + this.OriginAmount.GetHashCode();
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
