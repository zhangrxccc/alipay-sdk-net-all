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
    /// OrderItem
    /// </summary>
    [DataContract(Name = "OrderItem")]
    public partial class OrderItem : IEquatable<OrderItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItem" /> class.
        /// </summary>
        /// <param name="address">店铺所在具体位置.</param>
        /// <param name="brandName">品牌名称.</param>
        /// <param name="category">店铺品类.</param>
        /// <param name="city">店铺所在的市.</param>
        /// <param name="cityCode">城市编码.</param>
        /// <param name="commodityId">订购的服务商品ID.</param>
        /// <param name="contacts">订单联系人.</param>
        /// <param name="creator">门店创建人(已删除).</param>
        /// <param name="expireDate">过期时间.</param>
        /// <param name="merchantName">商户名称.</param>
        /// <param name="merchantPid">商户PID.</param>
        /// <param name="miniAppId">小程序APPID，订购实体为小程序的场景该字段必填.</param>
        /// <param name="miniAppName">小程序应用名称，订购实体为小程序的场景该字段必填.</param>
        /// <param name="onlineTime">上架时间.</param>
        /// <param name="openIdModel">应用用户标识模式.</param>
        /// <param name="orderStatus">TO_DO-未实施,DOING-实施中,TO_CONFIRM-待商户确认,CONFIRMED-商户已确认,DONE-已完成,MERCHANT_REJECTED-商户已回绝,MERCHANT_CANCELLED-商户已取消,ISV_REJECTED-服务商已回绝,ISV_CANCELLED-服务商已取消.</param>
        /// <param name="phoneNo">订单所属人联系方式（手机或者座机）.</param>
        /// <param name="province">店铺所在的省份.</param>
        /// <param name="serviceEffectDate">订购的服务有效期生效时间.</param>
        /// <param name="serviceExpireDate">服务有效期截止时间.</param>
        /// <param name="shopId">店铺ID，订购实体为口碑门店的场景该字段必填.</param>
        /// <param name="shopName">店铺名称，订购实体为口碑门店的场景该字段必填.</param>
        /// <param name="shopStatus">店铺状态（ONLINE- -已上架 OFFLINE- -未上架 AVAILABLE- -已开通 INIT- -未开通 EXPIRED- -已过期）.</param>
        /// <param name="status">待服务商接单.</param>
        public OrderItem(string address = default(string), string brandName = default(string), string category = default(string), string city = default(string), string cityCode = default(string), string commodityId = default(string), string contacts = default(string), string creator = default(string), string expireDate = default(string), string merchantName = default(string), string merchantPid = default(string), string miniAppId = default(string), string miniAppName = default(string), string onlineTime = default(string), string openIdModel = default(string), string orderStatus = default(string), string phoneNo = default(string), string province = default(string), string serviceEffectDate = default(string), string serviceExpireDate = default(string), string shopId = default(string), string shopName = default(string), string shopStatus = default(string), string status = default(string))
        {
            this.Address = address;
            this.BrandName = brandName;
            this.Category = category;
            this.City = city;
            this.CityCode = cityCode;
            this.CommodityId = commodityId;
            this.Contacts = contacts;
            this.Creator = creator;
            this.ExpireDate = expireDate;
            this.MerchantName = merchantName;
            this.MerchantPid = merchantPid;
            this.MiniAppId = miniAppId;
            this.MiniAppName = miniAppName;
            this.OnlineTime = onlineTime;
            this.OpenIdModel = openIdModel;
            this.OrderStatus = orderStatus;
            this.PhoneNo = phoneNo;
            this.Province = province;
            this.ServiceEffectDate = serviceEffectDate;
            this.ServiceExpireDate = serviceExpireDate;
            this.ShopId = shopId;
            this.ShopName = shopName;
            this.ShopStatus = shopStatus;
            this.Status = status;
        }

        /// <summary>
        /// 店铺所在具体位置
        /// </summary>
        /// <value>店铺所在具体位置</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        /// <value>品牌名称</value>
        [DataMember(Name = "brand_name", EmitDefaultValue = false)]
        public string BrandName { get; set; }

        /// <summary>
        /// 店铺品类
        /// </summary>
        /// <value>店铺品类</value>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// 店铺所在的市
        /// </summary>
        /// <value>店铺所在的市</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        /// <value>城市编码</value>
        [DataMember(Name = "city_code", EmitDefaultValue = false)]
        public string CityCode { get; set; }

        /// <summary>
        /// 订购的服务商品ID
        /// </summary>
        /// <value>订购的服务商品ID</value>
        [DataMember(Name = "commodity_id", EmitDefaultValue = false)]
        public string CommodityId { get; set; }

        /// <summary>
        /// 订单联系人
        /// </summary>
        /// <value>订单联系人</value>
        [DataMember(Name = "contacts", EmitDefaultValue = false)]
        public string Contacts { get; set; }

        /// <summary>
        /// 门店创建人(已删除)
        /// </summary>
        /// <value>门店创建人(已删除)</value>
        [DataMember(Name = "creator", EmitDefaultValue = false)]
        public string Creator { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        /// <value>过期时间</value>
        [DataMember(Name = "expire_date", EmitDefaultValue = false)]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        /// <value>商户名称</value>
        [DataMember(Name = "merchant_name", EmitDefaultValue = false)]
        public string MerchantName { get; set; }

        /// <summary>
        /// 商户PID
        /// </summary>
        /// <value>商户PID</value>
        [DataMember(Name = "merchant_pid", EmitDefaultValue = false)]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 小程序APPID，订购实体为小程序的场景该字段必填
        /// </summary>
        /// <value>小程序APPID，订购实体为小程序的场景该字段必填</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序应用名称，订购实体为小程序的场景该字段必填
        /// </summary>
        /// <value>小程序应用名称，订购实体为小程序的场景该字段必填</value>
        [DataMember(Name = "mini_app_name", EmitDefaultValue = false)]
        public string MiniAppName { get; set; }

        /// <summary>
        /// 上架时间
        /// </summary>
        /// <value>上架时间</value>
        [DataMember(Name = "online_time", EmitDefaultValue = false)]
        public string OnlineTime { get; set; }

        /// <summary>
        /// 应用用户标识模式
        /// </summary>
        /// <value>应用用户标识模式</value>
        [DataMember(Name = "open_id_model", EmitDefaultValue = false)]
        public string OpenIdModel { get; set; }

        /// <summary>
        /// TO_DO-未实施,DOING-实施中,TO_CONFIRM-待商户确认,CONFIRMED-商户已确认,DONE-已完成,MERCHANT_REJECTED-商户已回绝,MERCHANT_CANCELLED-商户已取消,ISV_REJECTED-服务商已回绝,ISV_CANCELLED-服务商已取消
        /// </summary>
        /// <value>TO_DO-未实施,DOING-实施中,TO_CONFIRM-待商户确认,CONFIRMED-商户已确认,DONE-已完成,MERCHANT_REJECTED-商户已回绝,MERCHANT_CANCELLED-商户已取消,ISV_REJECTED-服务商已回绝,ISV_CANCELLED-服务商已取消</value>
        [DataMember(Name = "order_status", EmitDefaultValue = false)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单所属人联系方式（手机或者座机）
        /// </summary>
        /// <value>订单所属人联系方式（手机或者座机）</value>
        [DataMember(Name = "phone_no", EmitDefaultValue = false)]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 店铺所在的省份
        /// </summary>
        /// <value>店铺所在的省份</value>
        [DataMember(Name = "province", EmitDefaultValue = false)]
        public string Province { get; set; }

        /// <summary>
        /// 订购的服务有效期生效时间
        /// </summary>
        /// <value>订购的服务有效期生效时间</value>
        [DataMember(Name = "service_effect_date", EmitDefaultValue = false)]
        public string ServiceEffectDate { get; set; }

        /// <summary>
        /// 服务有效期截止时间
        /// </summary>
        /// <value>服务有效期截止时间</value>
        [DataMember(Name = "service_expire_date", EmitDefaultValue = false)]
        public string ServiceExpireDate { get; set; }

        /// <summary>
        /// 店铺ID，订购实体为口碑门店的场景该字段必填
        /// </summary>
        /// <value>店铺ID，订购实体为口碑门店的场景该字段必填</value>
        [DataMember(Name = "shop_id", EmitDefaultValue = false)]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名称，订购实体为口碑门店的场景该字段必填
        /// </summary>
        /// <value>店铺名称，订购实体为口碑门店的场景该字段必填</value>
        [DataMember(Name = "shop_name", EmitDefaultValue = false)]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺状态（ONLINE- -已上架 OFFLINE- -未上架 AVAILABLE- -已开通 INIT- -未开通 EXPIRED- -已过期）
        /// </summary>
        /// <value>店铺状态（ONLINE- -已上架 OFFLINE- -未上架 AVAILABLE- -已开通 INIT- -未开通 EXPIRED- -已过期）</value>
        [DataMember(Name = "shop_status", EmitDefaultValue = false)]
        public string ShopStatus { get; set; }

        /// <summary>
        /// 待服务商接单
        /// </summary>
        /// <value>待服务商接单</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderItem {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  BrandName: ").Append(BrandName).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CityCode: ").Append(CityCode).Append("\n");
            sb.Append("  CommodityId: ").Append(CommodityId).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  ExpireDate: ").Append(ExpireDate).Append("\n");
            sb.Append("  MerchantName: ").Append(MerchantName).Append("\n");
            sb.Append("  MerchantPid: ").Append(MerchantPid).Append("\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
            sb.Append("  MiniAppName: ").Append(MiniAppName).Append("\n");
            sb.Append("  OnlineTime: ").Append(OnlineTime).Append("\n");
            sb.Append("  OpenIdModel: ").Append(OpenIdModel).Append("\n");
            sb.Append("  OrderStatus: ").Append(OrderStatus).Append("\n");
            sb.Append("  PhoneNo: ").Append(PhoneNo).Append("\n");
            sb.Append("  Province: ").Append(Province).Append("\n");
            sb.Append("  ServiceEffectDate: ").Append(ServiceEffectDate).Append("\n");
            sb.Append("  ServiceExpireDate: ").Append(ServiceExpireDate).Append("\n");
            sb.Append("  ShopId: ").Append(ShopId).Append("\n");
            sb.Append("  ShopName: ").Append(ShopName).Append("\n");
            sb.Append("  ShopStatus: ").Append(ShopStatus).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as OrderItem);
        }

        /// <summary>
        /// Returns true if OrderItem instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.BrandName == input.BrandName ||
                    (this.BrandName != null &&
                    this.BrandName.Equals(input.BrandName))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.CityCode == input.CityCode ||
                    (this.CityCode != null &&
                    this.CityCode.Equals(input.CityCode))
                ) && 
                (
                    this.CommodityId == input.CommodityId ||
                    (this.CommodityId != null &&
                    this.CommodityId.Equals(input.CommodityId))
                ) && 
                (
                    this.Contacts == input.Contacts ||
                    (this.Contacts != null &&
                    this.Contacts.Equals(input.Contacts))
                ) && 
                (
                    this.Creator == input.Creator ||
                    (this.Creator != null &&
                    this.Creator.Equals(input.Creator))
                ) && 
                (
                    this.ExpireDate == input.ExpireDate ||
                    (this.ExpireDate != null &&
                    this.ExpireDate.Equals(input.ExpireDate))
                ) && 
                (
                    this.MerchantName == input.MerchantName ||
                    (this.MerchantName != null &&
                    this.MerchantName.Equals(input.MerchantName))
                ) && 
                (
                    this.MerchantPid == input.MerchantPid ||
                    (this.MerchantPid != null &&
                    this.MerchantPid.Equals(input.MerchantPid))
                ) && 
                (
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
                ) && 
                (
                    this.MiniAppName == input.MiniAppName ||
                    (this.MiniAppName != null &&
                    this.MiniAppName.Equals(input.MiniAppName))
                ) && 
                (
                    this.OnlineTime == input.OnlineTime ||
                    (this.OnlineTime != null &&
                    this.OnlineTime.Equals(input.OnlineTime))
                ) && 
                (
                    this.OpenIdModel == input.OpenIdModel ||
                    (this.OpenIdModel != null &&
                    this.OpenIdModel.Equals(input.OpenIdModel))
                ) && 
                (
                    this.OrderStatus == input.OrderStatus ||
                    (this.OrderStatus != null &&
                    this.OrderStatus.Equals(input.OrderStatus))
                ) && 
                (
                    this.PhoneNo == input.PhoneNo ||
                    (this.PhoneNo != null &&
                    this.PhoneNo.Equals(input.PhoneNo))
                ) && 
                (
                    this.Province == input.Province ||
                    (this.Province != null &&
                    this.Province.Equals(input.Province))
                ) && 
                (
                    this.ServiceEffectDate == input.ServiceEffectDate ||
                    (this.ServiceEffectDate != null &&
                    this.ServiceEffectDate.Equals(input.ServiceEffectDate))
                ) && 
                (
                    this.ServiceExpireDate == input.ServiceExpireDate ||
                    (this.ServiceExpireDate != null &&
                    this.ServiceExpireDate.Equals(input.ServiceExpireDate))
                ) && 
                (
                    this.ShopId == input.ShopId ||
                    (this.ShopId != null &&
                    this.ShopId.Equals(input.ShopId))
                ) && 
                (
                    this.ShopName == input.ShopName ||
                    (this.ShopName != null &&
                    this.ShopName.Equals(input.ShopName))
                ) && 
                (
                    this.ShopStatus == input.ShopStatus ||
                    (this.ShopStatus != null &&
                    this.ShopStatus.Equals(input.ShopStatus))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.BrandName != null)
                {
                    hashCode = (hashCode * 59) + this.BrandName.GetHashCode();
                }
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.CityCode != null)
                {
                    hashCode = (hashCode * 59) + this.CityCode.GetHashCode();
                }
                if (this.CommodityId != null)
                {
                    hashCode = (hashCode * 59) + this.CommodityId.GetHashCode();
                }
                if (this.Contacts != null)
                {
                    hashCode = (hashCode * 59) + this.Contacts.GetHashCode();
                }
                if (this.Creator != null)
                {
                    hashCode = (hashCode * 59) + this.Creator.GetHashCode();
                }
                if (this.ExpireDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExpireDate.GetHashCode();
                }
                if (this.MerchantName != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantName.GetHashCode();
                }
                if (this.MerchantPid != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantPid.GetHashCode();
                }
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
                }
                if (this.MiniAppName != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppName.GetHashCode();
                }
                if (this.OnlineTime != null)
                {
                    hashCode = (hashCode * 59) + this.OnlineTime.GetHashCode();
                }
                if (this.OpenIdModel != null)
                {
                    hashCode = (hashCode * 59) + this.OpenIdModel.GetHashCode();
                }
                if (this.OrderStatus != null)
                {
                    hashCode = (hashCode * 59) + this.OrderStatus.GetHashCode();
                }
                if (this.PhoneNo != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNo.GetHashCode();
                }
                if (this.Province != null)
                {
                    hashCode = (hashCode * 59) + this.Province.GetHashCode();
                }
                if (this.ServiceEffectDate != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceEffectDate.GetHashCode();
                }
                if (this.ServiceExpireDate != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceExpireDate.GetHashCode();
                }
                if (this.ShopId != null)
                {
                    hashCode = (hashCode * 59) + this.ShopId.GetHashCode();
                }
                if (this.ShopName != null)
                {
                    hashCode = (hashCode * 59) + this.ShopName.GetHashCode();
                }
                if (this.ShopStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ShopStatus.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
