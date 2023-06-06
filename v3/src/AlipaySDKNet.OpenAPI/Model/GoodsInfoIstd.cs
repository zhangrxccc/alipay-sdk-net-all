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
    /// GoodsInfoIstd
    /// </summary>
    [DataContract(Name = "GoodsInfoIstd")]
    public partial class GoodsInfoIstd : IEquatable<GoodsInfoIstd>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoodsInfoIstd" /> class.
        /// </summary>
        /// <param name="deliveryInfo">交货信息，用于骑手交付商品.</param>
        /// <param name="firstClass">一级品类类目.</param>
        /// <param name="height">商品高度，单位为cm.</param>
        /// <param name="length">商品长度，单位为cm.</param>
        /// <param name="pickupInfo">取货信息，用于骑手到店取货.</param>
        /// <param name="price">总价.</param>
        /// <param name="secondClass">二级品类类目.</param>
        /// <param name="weight">货物重量，单位为kg，精确到小数点后两位.</param>
        /// <param name="width">商品宽度，单位为cm.</param>
        public GoodsInfoIstd(string deliveryInfo = default(string), string firstClass = default(string), int height = default(int), int length = default(int), string pickupInfo = default(string), string price = default(string), string secondClass = default(string), string weight = default(string), int width = default(int))
        {
            this.DeliveryInfo = deliveryInfo;
            this.FirstClass = firstClass;
            this.Height = height;
            this.Length = length;
            this.PickupInfo = pickupInfo;
            this.Price = price;
            this.SecondClass = secondClass;
            this.Weight = weight;
            this.Width = width;
        }

        /// <summary>
        /// 交货信息，用于骑手交付商品
        /// </summary>
        /// <value>交货信息，用于骑手交付商品</value>
        [DataMember(Name = "delivery_info", EmitDefaultValue = false)]
        public string DeliveryInfo { get; set; }

        /// <summary>
        /// 一级品类类目
        /// </summary>
        /// <value>一级品类类目</value>
        [DataMember(Name = "first_class", EmitDefaultValue = false)]
        public string FirstClass { get; set; }

        /// <summary>
        /// 商品高度，单位为cm
        /// </summary>
        /// <value>商品高度，单位为cm</value>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public int Height { get; set; }

        /// <summary>
        /// 商品长度，单位为cm
        /// </summary>
        /// <value>商品长度，单位为cm</value>
        [DataMember(Name = "length", EmitDefaultValue = false)]
        public int Length { get; set; }

        /// <summary>
        /// 取货信息，用于骑手到店取货
        /// </summary>
        /// <value>取货信息，用于骑手到店取货</value>
        [DataMember(Name = "pickup_info", EmitDefaultValue = false)]
        public string PickupInfo { get; set; }

        /// <summary>
        /// 总价
        /// </summary>
        /// <value>总价</value>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public string Price { get; set; }

        /// <summary>
        /// 二级品类类目
        /// </summary>
        /// <value>二级品类类目</value>
        [DataMember(Name = "second_class", EmitDefaultValue = false)]
        public string SecondClass { get; set; }

        /// <summary>
        /// 货物重量，单位为kg，精确到小数点后两位
        /// </summary>
        /// <value>货物重量，单位为kg，精确到小数点后两位</value>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        public string Weight { get; set; }

        /// <summary>
        /// 商品宽度，单位为cm
        /// </summary>
        /// <value>商品宽度，单位为cm</value>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public int Width { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoodsInfoIstd {\n");
            sb.Append("  DeliveryInfo: ").Append(DeliveryInfo).Append("\n");
            sb.Append("  FirstClass: ").Append(FirstClass).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  PickupInfo: ").Append(PickupInfo).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  SecondClass: ").Append(SecondClass).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
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
            return this.Equals(input as GoodsInfoIstd);
        }

        /// <summary>
        /// Returns true if GoodsInfoIstd instances are equal
        /// </summary>
        /// <param name="input">Instance of GoodsInfoIstd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoodsInfoIstd input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeliveryInfo == input.DeliveryInfo ||
                    (this.DeliveryInfo != null &&
                    this.DeliveryInfo.Equals(input.DeliveryInfo))
                ) && 
                (
                    this.FirstClass == input.FirstClass ||
                    (this.FirstClass != null &&
                    this.FirstClass.Equals(input.FirstClass))
                ) && 
                (
                    this.Height == input.Height ||
                    this.Height.Equals(input.Height)
                ) && 
                (
                    this.Length == input.Length ||
                    this.Length.Equals(input.Length)
                ) && 
                (
                    this.PickupInfo == input.PickupInfo ||
                    (this.PickupInfo != null &&
                    this.PickupInfo.Equals(input.PickupInfo))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.SecondClass == input.SecondClass ||
                    (this.SecondClass != null &&
                    this.SecondClass.Equals(input.SecondClass))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) && 
                (
                    this.Width == input.Width ||
                    this.Width.Equals(input.Width)
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
                if (this.DeliveryInfo != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryInfo.GetHashCode();
                }
                if (this.FirstClass != null)
                {
                    hashCode = (hashCode * 59) + this.FirstClass.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Height.GetHashCode();
                hashCode = (hashCode * 59) + this.Length.GetHashCode();
                if (this.PickupInfo != null)
                {
                    hashCode = (hashCode * 59) + this.PickupInfo.GetHashCode();
                }
                if (this.Price != null)
                {
                    hashCode = (hashCode * 59) + this.Price.GetHashCode();
                }
                if (this.SecondClass != null)
                {
                    hashCode = (hashCode * 59) + this.SecondClass.GetHashCode();
                }
                if (this.Weight != null)
                {
                    hashCode = (hashCode * 59) + this.Weight.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Width.GetHashCode();
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
