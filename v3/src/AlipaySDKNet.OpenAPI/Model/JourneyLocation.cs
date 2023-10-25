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
    /// JourneyLocation
    /// </summary>
    [DataContract(Name = "JourneyLocation")]
    public partial class JourneyLocation : IEquatable<JourneyLocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyLocation" /> class.
        /// </summary>
        /// <param name="aoiId">支付宝域内aoiId.</param>
        /// <param name="city">城市名.</param>
        /// <param name="extInfo">扩展信息.</param>
        /// <param name="locationId">支付宝侧地点id.</param>
        /// <param name="locationIdType">地点id类型.</param>
        /// <param name="merchantDivisionId">商户侧行政区划代码.</param>
        /// <param name="merchantId">(废弃)商户侧地点id.</param>
        /// <param name="merchantPoi">商户侧poi信息.</param>
        /// <param name="name">地点名称.</param>
        /// <param name="poiId">支付宝域内poiId.</param>
        public JourneyLocation(string aoiId = default(string), string city = default(string), List<OrderExtInfo> extInfo = default(List<OrderExtInfo>), string locationId = default(string), string locationIdType = default(string), string merchantDivisionId = default(string), string merchantId = default(string), string merchantPoi = default(string), string name = default(string), string poiId = default(string))
        {
            this.AoiId = aoiId;
            this.City = city;
            this.ExtInfo = extInfo;
            this.LocationId = locationId;
            this.LocationIdType = locationIdType;
            this.MerchantDivisionId = merchantDivisionId;
            this.MerchantId = merchantId;
            this.MerchantPoi = merchantPoi;
            this.Name = name;
            this.PoiId = poiId;
        }

        /// <summary>
        /// 支付宝域内aoiId
        /// </summary>
        /// <value>支付宝域内aoiId</value>
        [DataMember(Name = "aoi_id", EmitDefaultValue = false)]
        public string AoiId { get; set; }

        /// <summary>
        /// 城市名
        /// </summary>
        /// <value>城市名</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        /// <value>扩展信息</value>
        [DataMember(Name = "ext_info", EmitDefaultValue = false)]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 支付宝侧地点id
        /// </summary>
        /// <value>支付宝侧地点id</value>
        [DataMember(Name = "location_id", EmitDefaultValue = false)]
        public string LocationId { get; set; }

        /// <summary>
        /// 地点id类型
        /// </summary>
        /// <value>地点id类型</value>
        [DataMember(Name = "location_id_type", EmitDefaultValue = false)]
        public string LocationIdType { get; set; }

        /// <summary>
        /// 商户侧行政区划代码
        /// </summary>
        /// <value>商户侧行政区划代码</value>
        [DataMember(Name = "merchant_division_id", EmitDefaultValue = false)]
        public string MerchantDivisionId { get; set; }

        /// <summary>
        /// (废弃)商户侧地点id
        /// </summary>
        /// <value>(废弃)商户侧地点id</value>
        [DataMember(Name = "merchant_id", EmitDefaultValue = false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户侧poi信息
        /// </summary>
        /// <value>商户侧poi信息</value>
        [DataMember(Name = "merchant_poi", EmitDefaultValue = false)]
        public string MerchantPoi { get; set; }

        /// <summary>
        /// 地点名称
        /// </summary>
        /// <value>地点名称</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 支付宝域内poiId
        /// </summary>
        /// <value>支付宝域内poiId</value>
        [DataMember(Name = "poi_id", EmitDefaultValue = false)]
        public string PoiId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JourneyLocation {\n");
            sb.Append("  AoiId: ").Append(AoiId).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  ExtInfo: ").Append(ExtInfo).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  LocationIdType: ").Append(LocationIdType).Append("\n");
            sb.Append("  MerchantDivisionId: ").Append(MerchantDivisionId).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  MerchantPoi: ").Append(MerchantPoi).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PoiId: ").Append(PoiId).Append("\n");
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
            return this.Equals(input as JourneyLocation);
        }

        /// <summary>
        /// Returns true if JourneyLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of JourneyLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyLocation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AoiId == input.AoiId ||
                    (this.AoiId != null &&
                    this.AoiId.Equals(input.AoiId))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.ExtInfo == input.ExtInfo ||
                    this.ExtInfo != null &&
                    input.ExtInfo != null &&
                    this.ExtInfo.SequenceEqual(input.ExtInfo)
                ) && 
                (
                    this.LocationId == input.LocationId ||
                    (this.LocationId != null &&
                    this.LocationId.Equals(input.LocationId))
                ) && 
                (
                    this.LocationIdType == input.LocationIdType ||
                    (this.LocationIdType != null &&
                    this.LocationIdType.Equals(input.LocationIdType))
                ) && 
                (
                    this.MerchantDivisionId == input.MerchantDivisionId ||
                    (this.MerchantDivisionId != null &&
                    this.MerchantDivisionId.Equals(input.MerchantDivisionId))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.MerchantPoi == input.MerchantPoi ||
                    (this.MerchantPoi != null &&
                    this.MerchantPoi.Equals(input.MerchantPoi))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PoiId == input.PoiId ||
                    (this.PoiId != null &&
                    this.PoiId.Equals(input.PoiId))
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
                if (this.AoiId != null)
                {
                    hashCode = (hashCode * 59) + this.AoiId.GetHashCode();
                }
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.ExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExtInfo.GetHashCode();
                }
                if (this.LocationId != null)
                {
                    hashCode = (hashCode * 59) + this.LocationId.GetHashCode();
                }
                if (this.LocationIdType != null)
                {
                    hashCode = (hashCode * 59) + this.LocationIdType.GetHashCode();
                }
                if (this.MerchantDivisionId != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantDivisionId.GetHashCode();
                }
                if (this.MerchantId != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantId.GetHashCode();
                }
                if (this.MerchantPoi != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantPoi.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.PoiId != null)
                {
                    hashCode = (hashCode * 59) + this.PoiId.GetHashCode();
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
