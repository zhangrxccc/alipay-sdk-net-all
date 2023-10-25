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
    /// VoucherAvailableGeographyShopInfo
    /// </summary>
    [DataContract(Name = "VoucherAvailableGeographyShopInfo")]
    public partial class VoucherAvailableGeographyShopInfo : IEquatable<VoucherAvailableGeographyShopInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherAvailableGeographyShopInfo" /> class.
        /// </summary>
        /// <param name="availableGeographyAllShop">availableGeographyAllShop.</param>
        /// <param name="availableRealShopIds">代运营商业关系门店列表，列表中的门店id是调用接口alipay.business.relation.shop.create创建门店返回的real_shop_id 接口参数是列表类型。.</param>
        /// <param name="availableShopIds">券可使用的门店列表。列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店id 接口参数是列表类型。.</param>
        public VoucherAvailableGeographyShopInfo(VoucherAvailableGeographyAllShopInfo availableGeographyAllShop = default(VoucherAvailableGeographyAllShopInfo), List<string> availableRealShopIds = default(List<string>), List<string> availableShopIds = default(List<string>))
        {
            this.AvailableGeographyAllShop = availableGeographyAllShop;
            this.AvailableRealShopIds = availableRealShopIds;
            this.AvailableShopIds = availableShopIds;
        }

        /// <summary>
        /// Gets or Sets AvailableGeographyAllShop
        /// </summary>
        [DataMember(Name = "available_geography_all_shop", EmitDefaultValue = false)]
        public VoucherAvailableGeographyAllShopInfo AvailableGeographyAllShop { get; set; }

        /// <summary>
        /// 代运营商业关系门店列表，列表中的门店id是调用接口alipay.business.relation.shop.create创建门店返回的real_shop_id 接口参数是列表类型。
        /// </summary>
        /// <value>代运营商业关系门店列表，列表中的门店id是调用接口alipay.business.relation.shop.create创建门店返回的real_shop_id 接口参数是列表类型。</value>
        [DataMember(Name = "available_real_shop_ids", EmitDefaultValue = false)]
        public List<string> AvailableRealShopIds { get; set; }

        /// <summary>
        /// 券可使用的门店列表。列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店id 接口参数是列表类型。
        /// </summary>
        /// <value>券可使用的门店列表。列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店id 接口参数是列表类型。</value>
        [DataMember(Name = "available_shop_ids", EmitDefaultValue = false)]
        public List<string> AvailableShopIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherAvailableGeographyShopInfo {\n");
            sb.Append("  AvailableGeographyAllShop: ").Append(AvailableGeographyAllShop).Append("\n");
            sb.Append("  AvailableRealShopIds: ").Append(AvailableRealShopIds).Append("\n");
            sb.Append("  AvailableShopIds: ").Append(AvailableShopIds).Append("\n");
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
            return this.Equals(input as VoucherAvailableGeographyShopInfo);
        }

        /// <summary>
        /// Returns true if VoucherAvailableGeographyShopInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherAvailableGeographyShopInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherAvailableGeographyShopInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AvailableGeographyAllShop == input.AvailableGeographyAllShop ||
                    (this.AvailableGeographyAllShop != null &&
                    this.AvailableGeographyAllShop.Equals(input.AvailableGeographyAllShop))
                ) && 
                (
                    this.AvailableRealShopIds == input.AvailableRealShopIds ||
                    this.AvailableRealShopIds != null &&
                    input.AvailableRealShopIds != null &&
                    this.AvailableRealShopIds.SequenceEqual(input.AvailableRealShopIds)
                ) && 
                (
                    this.AvailableShopIds == input.AvailableShopIds ||
                    this.AvailableShopIds != null &&
                    input.AvailableShopIds != null &&
                    this.AvailableShopIds.SequenceEqual(input.AvailableShopIds)
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
                if (this.AvailableGeographyAllShop != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableGeographyAllShop.GetHashCode();
                }
                if (this.AvailableRealShopIds != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableRealShopIds.GetHashCode();
                }
                if (this.AvailableShopIds != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableShopIds.GetHashCode();
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
