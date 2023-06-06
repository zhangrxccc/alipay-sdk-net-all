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
    /// AlipayIserviceCcmSwOrderSyncModel
    /// </summary>
    [DataContract(Name = "AlipayIserviceCcmSwOrderSyncModel")]
    public partial class AlipayIserviceCcmSwOrderSyncModel : IEquatable<AlipayIserviceCcmSwOrderSyncModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmSwOrderSyncModel" /> class.
        /// </summary>
        /// <param name="amount">订单金额.</param>
        /// <param name="linkUrl">订单链接.</param>
        /// <param name="logisticCount">订单物流数量.</param>
        /// <param name="logistics">物流信息列表.</param>
        /// <param name="orderCreateTime">订单创建时间.</param>
        /// <param name="orderId">订单id.</param>
        /// <param name="orderType">普通订单：NORMAL 预售订单：PRE_SALE.</param>
        /// <param name="spuCount">订单商品种类.</param>
        /// <param name="spus">订单商品信息.</param>
        /// <param name="status">订单状态，目前支持以下几种状态 下单未支付 WAIT_PAY 支付未发货 PAIED 已发货 IN_DELIVERY 售后中 IN_AFTER_SALE 订单完成 FINISHED.</param>
        /// <param name="subStatus">订单子状态.</param>
        /// <param name="userId">下单用户id(外部系统ID).</param>
        public AlipayIserviceCcmSwOrderSyncModel(string amount = default(string), string linkUrl = default(string), int logisticCount = default(int), List<LogisticInfo> logistics = default(List<LogisticInfo>), string orderCreateTime = default(string), string orderId = default(string), string orderType = default(string), int spuCount = default(int), List<SpuInfo> spus = default(List<SpuInfo>), string status = default(string), string subStatus = default(string), string userId = default(string))
        {
            this.Amount = amount;
            this.LinkUrl = linkUrl;
            this.LogisticCount = logisticCount;
            this.Logistics = logistics;
            this.OrderCreateTime = orderCreateTime;
            this.OrderId = orderId;
            this.OrderType = orderType;
            this.SpuCount = spuCount;
            this.Spus = spus;
            this.Status = status;
            this.SubStatus = subStatus;
            this.UserId = userId;
        }

        /// <summary>
        /// 订单金额
        /// </summary>
        /// <value>订单金额</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 订单链接
        /// </summary>
        /// <value>订单链接</value>
        [DataMember(Name = "link_url", EmitDefaultValue = false)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 订单物流数量
        /// </summary>
        /// <value>订单物流数量</value>
        [DataMember(Name = "logistic_count", EmitDefaultValue = false)]
        public int LogisticCount { get; set; }

        /// <summary>
        /// 物流信息列表
        /// </summary>
        /// <value>物流信息列表</value>
        [DataMember(Name = "logistics", EmitDefaultValue = false)]
        public List<LogisticInfo> Logistics { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        /// <value>订单创建时间</value>
        [DataMember(Name = "order_create_time", EmitDefaultValue = false)]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        /// <value>订单id</value>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// 普通订单：NORMAL 预售订单：PRE_SALE
        /// </summary>
        /// <value>普通订单：NORMAL 预售订单：PRE_SALE</value>
        [DataMember(Name = "order_type", EmitDefaultValue = false)]
        public string OrderType { get; set; }

        /// <summary>
        /// 订单商品种类
        /// </summary>
        /// <value>订单商品种类</value>
        [DataMember(Name = "spu_count", EmitDefaultValue = false)]
        public int SpuCount { get; set; }

        /// <summary>
        /// 订单商品信息
        /// </summary>
        /// <value>订单商品信息</value>
        [DataMember(Name = "spus", EmitDefaultValue = false)]
        public List<SpuInfo> Spus { get; set; }

        /// <summary>
        /// 订单状态，目前支持以下几种状态 下单未支付 WAIT_PAY 支付未发货 PAIED 已发货 IN_DELIVERY 售后中 IN_AFTER_SALE 订单完成 FINISHED
        /// </summary>
        /// <value>订单状态，目前支持以下几种状态 下单未支付 WAIT_PAY 支付未发货 PAIED 已发货 IN_DELIVERY 售后中 IN_AFTER_SALE 订单完成 FINISHED</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 订单子状态
        /// </summary>
        /// <value>订单子状态</value>
        [DataMember(Name = "sub_status", EmitDefaultValue = false)]
        public string SubStatus { get; set; }

        /// <summary>
        /// 下单用户id(外部系统ID)
        /// </summary>
        /// <value>下单用户id(外部系统ID)</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayIserviceCcmSwOrderSyncModel {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  LinkUrl: ").Append(LinkUrl).Append("\n");
            sb.Append("  LogisticCount: ").Append(LogisticCount).Append("\n");
            sb.Append("  Logistics: ").Append(Logistics).Append("\n");
            sb.Append("  OrderCreateTime: ").Append(OrderCreateTime).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
            sb.Append("  SpuCount: ").Append(SpuCount).Append("\n");
            sb.Append("  Spus: ").Append(Spus).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubStatus: ").Append(SubStatus).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as AlipayIserviceCcmSwOrderSyncModel);
        }

        /// <summary>
        /// Returns true if AlipayIserviceCcmSwOrderSyncModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayIserviceCcmSwOrderSyncModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayIserviceCcmSwOrderSyncModel input)
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
                    this.LinkUrl == input.LinkUrl ||
                    (this.LinkUrl != null &&
                    this.LinkUrl.Equals(input.LinkUrl))
                ) && 
                (
                    this.LogisticCount == input.LogisticCount ||
                    this.LogisticCount.Equals(input.LogisticCount)
                ) && 
                (
                    this.Logistics == input.Logistics ||
                    this.Logistics != null &&
                    input.Logistics != null &&
                    this.Logistics.SequenceEqual(input.Logistics)
                ) && 
                (
                    this.OrderCreateTime == input.OrderCreateTime ||
                    (this.OrderCreateTime != null &&
                    this.OrderCreateTime.Equals(input.OrderCreateTime))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.OrderType == input.OrderType ||
                    (this.OrderType != null &&
                    this.OrderType.Equals(input.OrderType))
                ) && 
                (
                    this.SpuCount == input.SpuCount ||
                    this.SpuCount.Equals(input.SpuCount)
                ) && 
                (
                    this.Spus == input.Spus ||
                    this.Spus != null &&
                    input.Spus != null &&
                    this.Spus.SequenceEqual(input.Spus)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SubStatus == input.SubStatus ||
                    (this.SubStatus != null &&
                    this.SubStatus.Equals(input.SubStatus))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.LinkUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LinkUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LogisticCount.GetHashCode();
                if (this.Logistics != null)
                {
                    hashCode = (hashCode * 59) + this.Logistics.GetHashCode();
                }
                if (this.OrderCreateTime != null)
                {
                    hashCode = (hashCode * 59) + this.OrderCreateTime.GetHashCode();
                }
                if (this.OrderId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                }
                if (this.OrderType != null)
                {
                    hashCode = (hashCode * 59) + this.OrderType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SpuCount.GetHashCode();
                if (this.Spus != null)
                {
                    hashCode = (hashCode * 59) + this.Spus.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.SubStatus != null)
                {
                    hashCode = (hashCode * 59) + this.SubStatus.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
