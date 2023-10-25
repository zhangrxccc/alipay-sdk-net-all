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
    /// AlipayOpenServicemarketOrderQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenServicemarketOrderQueryResponseModel")]
    public partial class AlipayOpenServicemarketOrderQueryResponseModel : IEquatable<AlipayOpenServicemarketOrderQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenServicemarketOrderQueryResponseModel" /> class.
        /// </summary>
        /// <param name="autoUpgrade">true：开启；false：关闭；需要同步校验commodity_id，如果没有查询到订购信息的话，忽略该字段返回值.</param>
        /// <param name="commodityId">订购服务商品ID.</param>
        /// <param name="currentPage">当前查询页（本接口支持最多查询100条记录）.</param>
        /// <param name="orderItems">订单明细列表.</param>
        /// <param name="specifications">用于区分同一个服务的不同版本.</param>
        /// <param name="status">MERCHANT_ORDED（待服务商接单）.</param>
        /// <param name="totalSize">总记录数.</param>
        public AlipayOpenServicemarketOrderQueryResponseModel(bool autoUpgrade = default(bool), string commodityId = default(string), int currentPage = default(int), List<OrderItem> orderItems = default(List<OrderItem>), string specifications = default(string), string status = default(string), int totalSize = default(int))
        {
            this.AutoUpgrade = autoUpgrade;
            this.CommodityId = commodityId;
            this.CurrentPage = currentPage;
            this.OrderItems = orderItems;
            this.Specifications = specifications;
            this.Status = status;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// true：开启；false：关闭；需要同步校验commodity_id，如果没有查询到订购信息的话，忽略该字段返回值
        /// </summary>
        /// <value>true：开启；false：关闭；需要同步校验commodity_id，如果没有查询到订购信息的话，忽略该字段返回值</value>
        [DataMember(Name = "auto_upgrade", EmitDefaultValue = true)]
        public bool AutoUpgrade { get; set; }

        /// <summary>
        /// 订购服务商品ID
        /// </summary>
        /// <value>订购服务商品ID</value>
        [DataMember(Name = "commodity_id", EmitDefaultValue = false)]
        public string CommodityId { get; set; }

        /// <summary>
        /// 当前查询页（本接口支持最多查询100条记录）
        /// </summary>
        /// <value>当前查询页（本接口支持最多查询100条记录）</value>
        [DataMember(Name = "current_page", EmitDefaultValue = false)]
        public int CurrentPage { get; set; }

        /// <summary>
        /// 订单明细列表
        /// </summary>
        /// <value>订单明细列表</value>
        [DataMember(Name = "order_items", EmitDefaultValue = false)]
        public List<OrderItem> OrderItems { get; set; }

        /// <summary>
        /// 用于区分同一个服务的不同版本
        /// </summary>
        /// <value>用于区分同一个服务的不同版本</value>
        [DataMember(Name = "specifications", EmitDefaultValue = false)]
        public string Specifications { get; set; }

        /// <summary>
        /// MERCHANT_ORDED（待服务商接单）
        /// </summary>
        /// <value>MERCHANT_ORDED（待服务商接单）</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        /// <value>总记录数</value>
        [DataMember(Name = "total_size", EmitDefaultValue = false)]
        public int TotalSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenServicemarketOrderQueryResponseModel {\n");
            sb.Append("  AutoUpgrade: ").Append(AutoUpgrade).Append("\n");
            sb.Append("  CommodityId: ").Append(CommodityId).Append("\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  OrderItems: ").Append(OrderItems).Append("\n");
            sb.Append("  Specifications: ").Append(Specifications).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TotalSize: ").Append(TotalSize).Append("\n");
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
            return this.Equals(input as AlipayOpenServicemarketOrderQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenServicemarketOrderQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenServicemarketOrderQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenServicemarketOrderQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AutoUpgrade == input.AutoUpgrade ||
                    this.AutoUpgrade.Equals(input.AutoUpgrade)
                ) && 
                (
                    this.CommodityId == input.CommodityId ||
                    (this.CommodityId != null &&
                    this.CommodityId.Equals(input.CommodityId))
                ) && 
                (
                    this.CurrentPage == input.CurrentPage ||
                    this.CurrentPage.Equals(input.CurrentPage)
                ) && 
                (
                    this.OrderItems == input.OrderItems ||
                    this.OrderItems != null &&
                    input.OrderItems != null &&
                    this.OrderItems.SequenceEqual(input.OrderItems)
                ) && 
                (
                    this.Specifications == input.Specifications ||
                    (this.Specifications != null &&
                    this.Specifications.Equals(input.Specifications))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TotalSize == input.TotalSize ||
                    this.TotalSize.Equals(input.TotalSize)
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
                hashCode = (hashCode * 59) + this.AutoUpgrade.GetHashCode();
                if (this.CommodityId != null)
                {
                    hashCode = (hashCode * 59) + this.CommodityId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CurrentPage.GetHashCode();
                if (this.OrderItems != null)
                {
                    hashCode = (hashCode * 59) + this.OrderItems.GetHashCode();
                }
                if (this.Specifications != null)
                {
                    hashCode = (hashCode * 59) + this.Specifications.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalSize.GetHashCode();
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
